using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Input;
using _2DGAMELIB;
using SlaveEngine.Graphics;
using SlaveEngine.Assets;
using SlaveEngine.Assets.Models;
using SlaveEngine.Assets.Processors;
using SlaveEngine.Assets.Primitives;

namespace SlaveEngine
{
    public class Program
    {
        private static IGameWindow gameWindow = null!;
        private static GL gl = null!;
        private static bool isRunning = true;

        private static uint vao;
        private static uint vbo;
        private static uint shaderProgram;
        private static int vertexCount;

        private static int currentWidth = 1280;
        private static int currentHeight = 720;
        
        private static int uResolutionLocation;
        private static int uPanLocation;
        private static int uZoomLocation;
        private static int uRenderModeLocation;

        private static Vector2D cameraPan = new Vector2D(0.0, 0.0);
        private static double cameraZoom = 1.0;
        private static bool isDragging = false;
        private static bool showWireframe = false;
        private static Vector2D lastMousePos = new Vector2D(0.0, 0.0);

        private struct BoundingBox
        {
            public double MinX;
            public double MaxX;
            public double MinY;
            public double MaxY;
            public bool IsEmpty;
            public double Width => IsEmpty ? 0 : MaxX - MinX;
            public double Height => IsEmpty ? 0 : MaxY - MinY;
            public static BoundingBox Empty => new BoundingBox { 
                IsEmpty = true, MinX = double.MaxValue, MaxX = double.MinValue, 
                MinY = double.MaxValue, MaxY = double.MinValue 
            };
            public void Update(Vector2D p) {
                if (p.X < MinX) MinX = p.X; if (p.X > MaxX) MaxX = p.X;
                if (p.Y < MinY) MinY = p.Y; if (p.Y > MaxY) MaxY = p.Y;
                IsEmpty = false;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("starting native desktop engine... ✧");
            Graphics.GLFWWindow glfwWin = new Graphics.GLFWWindow(currentWidth, currentHeight);
            glfwWin.SetTitle("Slave Engine (ShapePart Grid)");
            StartGameEngine(glfwWin);
            while (isRunning) {
                gameWindow.PollEvents();
                if (isRunning) {
                    TickEngineFrame();
                    GLFW.Glfw.SwapBuffers(glfwWin.window);
                }
            }
        }

        public static void StartGameEngine(IGameWindow window)
        {
            gameWindow = window;
            gameWindow.Resize += (int w, int h) => { currentWidth = w; currentHeight = h; gl?.Viewport(0, 0, (uint)w, (uint)h); };
            gameWindow.MouseClick += (MouseButtons btn) => {
                if ((btn & MouseButtons.Left) != 0) { isDragging = true; lastMousePos = gameWindow.GetCursorPoint(); }
                else isDragging = false;
                showWireframe = (btn & MouseButtons.Right) != 0;
            };
            gameWindow.MouseMove += (Vector2D pos) => {
                Vector2D currentPos = new Vector2D(pos.X, pos.Y);
                if (isDragging) {
                    double deltaX = currentPos.X - lastMousePos.X;
                    double deltaY = currentPos.Y - lastMousePos.Y;
                    double minRes = System.Math.Min(currentWidth, currentHeight);
                    cameraPan.X += (deltaX / minRes) * 2.0 / cameraZoom;
                    cameraPan.Y -= (deltaY / minRes) * 2.0 / cameraZoom;
                }
                lastMousePos = currentPos;
            };
            gameWindow.MouseScroll += (double offsetx, double offsety) => {
                double minRes = System.Math.Min(currentWidth, currentHeight);
                double uvX = (2.0 * lastMousePos.X - currentWidth) / minRes;
                double uvY = -(2.0 * lastMousePos.Y - currentHeight) / minRes;
                double modelMouseX = (uvX / cameraZoom) - cameraPan.X;
                double modelMouseY = (uvY / cameraZoom) - cameraPan.Y;
                if (offsety > 0) cameraZoom *= 1.1; else if (offsety < 0) cameraZoom /= 1.1;
                cameraZoom = System.Math.Max(0.00001, System.Math.Min(cameraZoom, 1000000.0));
                cameraPan.X = (uvX / cameraZoom) - modelMouseX; cameraPan.Y = (uvY / cameraZoom) - modelMouseY;
            };
            gameWindow.Closing += () => { isRunning = false; gl.DeleteVertexArray(vao); gl.DeleteBuffer(vbo); gl.DeleteProgram(shaderProgram); gameWindow.Dispose(); };

            gl = window.CreateGlContext();
            gl.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            gl.Enable(EnableCap.ProgramPointSize);

            List<double> masterGeometry = new List<double>();
            string assetPath = "Assets";
            for (int i = 0; i < 5; i++) { if (Directory.Exists(assetPath)) break; assetPath = Path.Combine("..", assetPath); }

            if (!Directory.Exists(assetPath)) {
                Console.WriteLine("Could not find Assets directory!");
            } else {
                ResourceManager resourceManager = new ResourceManager(assetPath);
                resourceManager.RegisterProcessor(new PartProcessor());
                resourceManager.Initialize();
                List<string> ids = resourceManager.GetAssetIds().ToList();
                
                List<(PathGroup Group, BoundingBox BBox)> partsToRender = new List<(PathGroup Group, BoundingBox BBox)>();

                foreach (string id in ids) {
                    if (partsToRender.Count >= 50) break;
                    PartAsset asset = resourceManager.GetAsset<PartAsset>(id);
                    if (asset == null) continue;
                    foreach (VariantAsset variant in asset.Variants) {
                        if (partsToRender.Count >= 50) break;
                        foreach (PathGroup group in variant.Groups) {
                            if (partsToRender.Count >= 50) break;
                            BoundingBox bbox = BoundingBox.Empty;
                            foreach (PathData path in group.Paths) {
                                List<List<Vector2D>> polylines = CommandsToPolylines(path.Commands, 0.05);
                                foreach (Vector2D p in polylines.SelectMany(pl => pl)) bbox.Update(p);
                            }
                            if (!bbox.IsEmpty) partsToRender.Add((group, bbox));
                        }
                    }
                }

                Console.WriteLine($"Processing {partsToRender.Count} ShapeParts...");

                double maxWidth = partsToRender.Count > 0 ? partsToRender.Max(p => p.BBox.Width) : 0;
                double maxHeight = partsToRender.Count > 0 ? partsToRender.Max(p => p.BBox.Height) : 0;
                int gridWidth = (int)System.Math.Ceiling(System.Math.Sqrt(partsToRender.Count));
                double margin = System.Math.Max(maxWidth, maxHeight) * 0.2;
                double stepX = maxWidth + margin;
                double stepY = maxHeight + margin;
                Random rng = new Random(42);

                // Pass 1: Fills
                for (int i = 0; i < partsToRender.Count; i++) {
                    (PathGroup group, BoundingBox bbox) = partsToRender[i];
                    int col = i % gridWidth;
                    int row = i / gridWidth;
                    Vector2D tileCenter = new Vector2D(col * stepX, -row * stepY);
                    Vector2D offset = tileCenter - new Vector2D(bbox.MinX + bbox.Width / 2, bbox.MinY + bbox.Height / 2);
                    double colorSeed = rng.NextDouble() * 1000.0 + 10.0;

                    bool isGroupClosed = group.Paths.Length > 0 && group.Paths[0].IsClosed;
                    List<List<Vector2D>> fillContours = new List<List<Vector2D>>();

                    if (isGroupClosed) {
                        // Each path is a separate loop
                        foreach (PathData path in group.Paths) {
                            List<List<Vector2D>> polylines = CommandsToPolylines(path.Commands, 0.05);
                            foreach (List<Vector2D> poly in polylines)
                                fillContours.Add(poly.Select(p => ApplyTransform(p, group) + offset).ToList());
                        }
                    } else {
                        // All paths are one figure with implicit line bridges
                        List<Vector2D> combined = new List<Vector2D>();
                        foreach (PathData path in group.Paths) {
                            List<List<Vector2D>> polylines = CommandsToPolylines(path.Commands, 0.05);
                            foreach (List<Vector2D> poly in polylines)
                                combined.AddRange(poly.Select(p => ApplyTransform(p, group) + offset));
                        }
                        if (combined.Count >= 3) fillContours.Add(combined);
                    }

                    if (fillContours.Count > 0) {
                        List<double> triangles = Triangulation.Triangulate(fillContours);
                        AppendGeometryWithColorFlag(masterGeometry, triangles, colorSeed);
                    }
                }

                // Pass 2: Outlines
                for (int i = 0; i < partsToRender.Count; i++) {
                    (PathGroup group, BoundingBox bbox) = partsToRender[i];
                    int col = i % gridWidth;
                    int row = i / gridWidth;
                    Vector2D tileCenter = new Vector2D(col * stepX, -row * stepY);
                    Vector2D offset = tileCenter - new Vector2D(bbox.MinX + bbox.Width / 2, bbox.MinY + bbox.Height / 2);

                    foreach (PathData path in group.Paths) {
                        List<List<Vector2D>> polylines = CommandsToPolylines(path.Commands, 0.02);
                        foreach (List<Vector2D> poly in polylines) {
                            List<Vector2D> transformed = poly.Select(p => ApplyTransform(p, group) + offset).ToList();
                            if (!string.IsNullOrEmpty(path.Stroke) && path.Stroke != "none" && path.StrokeWidth > 0) {
                                List<double> strip = Triangulation.ToStrip(path.StrokeWidth, transformed, path.IsClosed);
                                AppendGeometryWithColorFlag(masterGeometry, strip, 1.0);
                            }
                        }
                    }
                }
            }

            float[] vertexData = masterGeometry.ConvertAll(d => (float)d).ToArray();
            vertexCount = vertexData.Length / 4;
            InitShaders();
            InitBuffers(vertexData);
        }

        private static List<List<Vector2D>> CommandsToPolylines(BezierCommand[] commands, double delta)
        {
            List<List<Vector2D>> polylines = new List<List<Vector2D>>();
            List<Vector2D>? currentPoly = null;
            Vector2D currentPos = new Vector2D(0, 0);
            Vector2D startPos = new Vector2D(0, 0);
            void CloseCurrent() { if (currentPoly != null && currentPoly.Count >= 2) polylines.Add(currentPoly); currentPoly = null; }
            foreach (BezierCommand cmd in commands) {
                switch (cmd.Type) {
                    case CommandType.MoveTo:
                        CloseCurrent();
                        currentPoly = new List<Vector2D>();
                        currentPos = new Vector2D(cmd.Args[0], cmd.Args[1]);
                        startPos = currentPos;
                        currentPoly.Add(currentPos); break;
                    case CommandType.LineTo:
                        if (currentPoly == null) currentPoly = new List<Vector2D> { currentPos };
                        Vector2D lp = new Vector2D(cmd.Args[0], cmd.Args[1]);
                        currentPos = lp; currentPoly.Add(currentPos); break;
                    case CommandType.CubicBezierTo:
                        if (currentPoly == null) currentPoly = new List<Vector2D> { currentPos };
                        Vector2D c1 = new Vector2D(cmd.Args[0], cmd.Args[1]);
                        Vector2D c2 = new Vector2D(cmd.Args[2], cmd.Args[3]);
                        Vector2D p3 = new Vector2D(cmd.Args[4], cmd.Args[5]);
                        List<Vector2D> curve = Spline.CubicBezierToPolyline(currentPos, c1, c2, p3, delta);
                        currentPoly.AddRange(curve.Skip(1));
                        currentPos = p3; break;
                    case CommandType.Close:
                        if (currentPoly != null && (currentPoly[0] - currentPos).Length() > 1e-6) currentPoly.Add(startPos);
                        CloseCurrent(); currentPos = startPos; break;
                }
            }
            CloseCurrent(); return polylines;
        }

        private static Vector2D ApplyTransform(Vector2D p, PathGroup group)
        {
            if (!group.HasTransform) return p;
            // 2DGAMELIB logic: Rotate(p * s - bp * s) + pos
            // Our SVG has Tx/Ty = pos, Bx/By = -bp * s, Sx/Sy = s
            // So P_final = R * (p * s + Bx) + Tx
            double x1 = p.X * group.Sx + group.Bx;
            double y1 = p.Y * group.Sy + group.By;
            double rad = group.Angle * System.Math.PI / 180.0;
            double cos = System.Math.Cos(rad);
            double sin = System.Math.Sin(rad);
            return new Vector2D(x1 * cos - y1 * sin + group.Tx, x1 * sin + y1 * cos + group.Ty);
        }

        private static void AppendGeometryWithColorFlag(List<double> masterList, List<double> subGeometry, double colorFlag)
        {
            for (int i = 0; i < subGeometry.Count; i += 4) {
                masterList.Add(subGeometry[i]); masterList.Add(subGeometry[i + 1]); 
                masterList.Add(subGeometry[i + 2]); masterList.Add(colorFlag);
            }
        }

        private static void InitShaders()
        {
            string vertCode = @"#version 330 core
            layout (location = 0) in vec4 aPosition;
            uniform vec2 u_resolution; uniform vec2 u_pan; uniform float u_zoom;
            out float vColorFlag;
            void main() {
                vec2 transformedPos = (aPosition.xy + u_pan) * u_zoom;
                float minRes = min(u_resolution.x, u_resolution.y);
                gl_Position = vec4(transformedPos * (minRes / u_resolution.xy), 0.0, 1.0);
                gl_PointSize = 6.0; vColorFlag = aPosition.w;
            }";
            string fragCode = @"#version 330 core
            in float vColorFlag; uniform int u_render_mode; out vec4 FragColor;
            vec3 hash3(float n) { return fract(sin(vec3(n, n + 1.0, n + 2.0)) * vec3(43758.5453123, 22578.1459123, 19642.3490423)); }
            void main() {
                if (u_render_mode == 1) FragColor = vec4(1.0, 0.2, 0.2, 1.0);
                else if (u_render_mode == 2) FragColor = vec4(0.0, 0.9, 1.0, 1.0);
                else {
                    if (vColorFlag < 1.5) FragColor = vec4(1.0, 1.0, 1.0, 1.0);
                    else FragColor = vec4(hash3(vColorFlag), 1.0);
                }
            }";
            uint vertShader = gl.CreateShader(ShaderType.VertexShader); gl.ShaderSource(vertShader, vertCode); gl.CompileShader(vertShader);
            uint fragShader = gl.CreateShader(ShaderType.FragmentShader); gl.ShaderSource(fragShader, fragCode); gl.CompileShader(fragShader);
            shaderProgram = gl.CreateProgram(); gl.AttachShader(shaderProgram, vertShader); gl.AttachShader(shaderProgram, fragShader); gl.LinkProgram(shaderProgram);
            uResolutionLocation = gl.GetUniformLocation(shaderProgram, "u_resolution"); uPanLocation = gl.GetUniformLocation(shaderProgram, "u_pan");
            uZoomLocation = gl.GetUniformLocation(shaderProgram, "u_zoom"); uRenderModeLocation = gl.GetUniformLocation(shaderProgram, "u_render_mode");
            gl.DeleteShader(vertShader); gl.DeleteShader(fragShader);
        }

        private static unsafe void InitBuffers(float[] vertexData)
        {
            vao = gl.GenVertexArray(); vbo = gl.GenBuffer();
            gl.BindVertexArray(vao); gl.BindBuffer(BufferTargetARB.ArrayBuffer, vbo);
            fixed (void* ptr = vertexData) gl.BufferData(BufferTargetARB.ArrayBuffer, (nuint)(vertexData.Length * sizeof(float)), ptr, BufferUsageARB.StaticDraw);
            gl.VertexAttribPointer(0, 4, VertexAttribPointerType.Float, false, 4 * sizeof(float), (void*)0);
            gl.EnableVertexAttribArray(0);
        }

        private static void TickEngineFrame()
        {
            gl.Clear((uint)GLEnum.ColorBufferBit); gl.UseProgram(shaderProgram);
            gl.Uniform2(uResolutionLocation, (float)currentWidth, (float)currentHeight);
            gl.Uniform2(uPanLocation, (float)cameraPan.X, (float)cameraPan.Y);
            gl.Uniform1(uZoomLocation, (float)cameraZoom);
            gl.BindVertexArray(vao);
            if (showWireframe) {
                gl.PolygonMode(GLEnum.FrontAndBack, GLEnum.Line); gl.Uniform1(uRenderModeLocation, 2); 
                gl.DrawArrays(PrimitiveType.Triangles, 0, (uint)vertexCount);
                gl.PolygonMode(GLEnum.FrontAndBack, GLEnum.Fill); gl.Uniform1(uRenderModeLocation, 1);
                gl.DrawArrays(PrimitiveType.Points, 0, (uint)vertexCount);
            } else {
                gl.PolygonMode(GLEnum.FrontAndBack, GLEnum.Fill); gl.Uniform1(uRenderModeLocation, 0);
                gl.DrawArrays(PrimitiveType.Triangles, 0, (uint)vertexCount);
            }
        }
    }
}
