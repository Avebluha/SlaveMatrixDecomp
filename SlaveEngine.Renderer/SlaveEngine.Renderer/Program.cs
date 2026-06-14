using System;
using System.Collections.Generic;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Input;
using _2DGAMELIB;
using SlaveEngine.Graphics;

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

        private static Vector2D cameraPan = new Vector2D(0.0, 0.0);
        private static double cameraZoom = 1.0;
        private static bool isDragging = false;
        private static Vector2D lastMousePos = new Vector2D(0.0, 0.0);

        public static void Main(string[] args)
        {
            Console.WriteLine("starting native desktop engine... ✧");
            
            var glfwWin = new Graphics.GLFWWindow(currentWidth, currentHeight);
            glfwWin.SetTitle("Slave Engine (Desktop zoom to cursor)");
            
            StartGameEngine(glfwWin);

            while (isRunning)
            {
                gameWindow.PollEvents();
                
                if (isRunning)
                {
                    TickEngineFrame();
                    GLFW.Glfw.SwapBuffers(glfwWin.window);
                }
            }
        }

        public static void StartGameEngine(IGameWindow window)
        {
            gameWindow = window;
            
            gameWindow.Resize += (w, h) => {
                currentWidth = w;
                currentHeight = h;
                gl?.Viewport(0, 0, (uint)w, (uint)h);
            };

            gameWindow.MouseClick += (btn) => {
                if ((btn & MouseButtons.Left) != 0)
                {
                    isDragging = true;
                    lastMousePos = gameWindow.GetCursorPoint();
                }else{
                    isDragging = false;
                }
            };

            gameWindow.MouseMove += (pos) => {
                var currentPos = new Vector2D(pos.X, pos.Y);
                if (isDragging)
                {
                    double deltaX = currentPos.X - lastMousePos.X;
                    double deltaY = currentPos.Y - lastMousePos.Y;

                    double minRes = System.Math.Min(currentWidth, currentHeight);
                    cameraPan.X += (deltaX / minRes) * 2.0 / cameraZoom;
                    cameraPan.Y -= (deltaY / minRes) * 2.0 / cameraZoom;
                }
                lastMousePos = currentPos;
            };

            gameWindow.MouseScroll += (offsetx, offsety) => {
                double minRes = System.Math.Min(currentWidth, currentHeight);
                
                // 1. convert the raw cursor location into your local aspect-corrected space
                double uvX = (2.0 * lastMousePos.X - currentWidth) / minRes;
                double uvY = -(2.0 * lastMousePos.Y - currentHeight) / minRes; // invert window coordinate bounds

                // 2. un-project back into the model coordinate space using current transforms
                double modelMouseX = (uvX / cameraZoom) - cameraPan.X;
                double modelMouseY = (uvY / cameraZoom) - cameraPan.Y;

                double oldZoom = cameraZoom;
                double factor = 1.1;

                if (offsety > 0)
                {
                    cameraZoom *= factor;
                }
                else if (offsety < 0)
                {
                    cameraZoom /= factor;
                }

                // 3. shift pan settings to hold the coordinate steady under the cursor point
                cameraPan.X = (uvX / cameraZoom) - modelMouseX;
                cameraPan.Y = (uvY / cameraZoom) - modelMouseY;
            };

            gameWindow.Closing += () => {
                isRunning = false;
                gl.DeleteVertexArray(vao);
                gl.DeleteBuffer(vbo);
                gl.DeleteProgram(shaderProgram);
                gameWindow.Dispose();
            };

            gl = gameWindow.CreateGlContext();
            gl.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);

            var masterGeometry = new List<double>();

            var faceCircle = CreateCirclePath(new Vector2D(0, 0), 0.6, 64);
            var faceTriangles = Triangulation.Triangulate(faceCircle);
            AppendGeometryWithColorFlag(masterGeometry, faceTriangles, 1.0); 

            var leftEye = CreateCirclePath(new Vector2D(-0.2, 0.2), 0.06, 16);
            var leftEyeTriangles = Triangulation.Triangulate(leftEye);
            AppendGeometryWithColorFlag(masterGeometry, leftEyeTriangles, 2.0); 

            var leftEyeOutlinePath = CreateCirclePath(new Vector2D(-0.2, 0.2), 0.08, 32);
            var leftEyeOutlineStrip = Triangulation.ToStrip(0.015, leftEyeOutlinePath, closed: true);
            AppendGeometryWithColorFlag(masterGeometry, leftEyeOutlineStrip, 3.0); 

            var rightEye = CreateCirclePath(new Vector2D(0.2, 0.2), 0.06, 16);
            var rightEyeTriangles = Triangulation.Triangulate(rightEye);
            AppendGeometryWithColorFlag(masterGeometry, rightEyeTriangles, 2.0);

            var rightEyeOutlinePath = CreateCirclePath(new Vector2D(0.2, 0.2), 0.08, 32);
            var rightEyeOutlineStrip = Triangulation.ToStrip(0.015, rightEyeOutlinePath, closed: true);
            AppendGeometryWithColorFlag(masterGeometry, rightEyeOutlineStrip, 3.0);

            var wiggleKnots = new List<Vector2D>();
            int knotCount = 12;
            double startX = -0.3;
            double endX = 0.3;
            double baselineY = -0.2; 
            double amplitude = 0.06; 
            double frequency = 3.5;  

            for (int i = 0; i < knotCount; i++)
            {
                double t = (double)i / (knotCount - 1);
                double x = startX + t * (endX - startX);
                double y = baselineY + System.Math.Sin(t * frequency * 2.0 * System.Math.PI) * amplitude;
                wiggleKnots.Add(new Vector2D(x, y));
            }

            var mouthBezier = Spline.CanonicalToBezierSpline(0.0, wiggleKnots, closed: false);
            var mouthPolyline = Spline.SplineToPolyLine(0.01, mouthBezier);
            var mouthStrip = Triangulation.ToStrip(0.03, mouthPolyline, closed: false);
            AppendGeometryWithColorFlag(masterGeometry, mouthStrip, 2.0);

            float[] vertexData = masterGeometry.ConvertAll(d => (float)d).ToArray();
            vertexCount = vertexData.Length / 4;

            InitShaders();
            InitBuffers(vertexData);
        }

        private static List<Vector2D> CreateCirclePath(Vector2D center, double radius, int segments)
        {
            var path = new List<Vector2D>();
            for (int i = 0; i < segments; i++)
            {
                double angle = ((double)i / segments) * 2.0 * System.Math.PI;
                path.Add(new Vector2D(center.X + System.Math.Cos(angle) * radius, center.Y + System.Math.Sin(angle) * radius));
            }
            return path;
        }

        private static void AppendGeometryWithColorFlag(List<double> masterList, List<double> subGeometry, double colorFlag)
        {
            for (int i = 0; i < subGeometry.Count; i += 4)
            {
                masterList.Add(subGeometry[i]);     
                masterList.Add(subGeometry[i + 1]); 
                masterList.Add(subGeometry[i + 2]); 
                masterList.Add(colorFlag);          
            }
        }

        private static void InitShaders()
        {
            string vertCode = @"#version 330 core
            layout (location = 0) in vec4 aPosition;
            
            uniform vec2 u_resolution;
            uniform vec2 u_pan;
            uniform float u_zoom;
            
            out float vColorFlag;

            void main() {
                vec2 transformedPos = (aPosition.xy + u_pan) * u_zoom;
                float minRes = min(u_resolution.x, u_resolution.y);
                vec2 correctedPos = transformedPos * (minRes / u_resolution.xy);
                
                gl_Position = vec4(correctedPos, 0.0, 1.0);
                vColorFlag = aPosition.w;
            }";

            string fragCode = @"#version 330 core
            in float vColorFlag;
            out vec4 FragColor;

            void main() {
                if (vColorFlag > 2.5) {
                    FragColor = vec4(1.0, 1.0, 1.0, 1.0);
                } else if (vColorFlag > 1.5) {
                    FragColor = vec4(0.0, 0.0, 0.0, 1.0);
                } else {
                    FragColor = vec4(1.0, 0.9, 0.0, 1.0);
                }
            }";

            uint vertShader = CompileShaderTarget(ShaderType.VertexShader, vertCode);
            uint fragShader = CompileShaderTarget(ShaderType.FragmentShader, fragCode);

            shaderProgram = gl.CreateProgram();
            gl.AttachShader(shaderProgram, vertShader);
            gl.AttachShader(shaderProgram, fragShader);
            gl.LinkProgram(shaderProgram);

            uResolutionLocation = gl.GetUniformLocation(shaderProgram, "u_resolution");
            uPanLocation = gl.GetUniformLocation(shaderProgram, "u_pan");
            uZoomLocation = gl.GetUniformLocation(shaderProgram, "u_zoom");

            gl.DetachShader(shaderProgram, vertShader);
            gl.DetachShader(shaderProgram, fragShader);
            gl.DeleteShader(vertShader);
            gl.DeleteShader(fragShader);
        }

        private static uint CompileShaderTarget(ShaderType type, string source)
        {
            uint shader = gl.CreateShader(type);
            gl.ShaderSource(shader, source);
            gl.CompileShader(shader);
            return shader;
        }

        private static unsafe void InitBuffers(float[] vertexData)
        {
            vao = gl.GenVertexArray();
            vbo = gl.GenBuffer();

            gl.BindVertexArray(vao);
            gl.BindBuffer(BufferTargetARB.ArrayBuffer, vbo);
            
            fixed (void* ptr = vertexData)
            {
                gl.BufferData(BufferTargetARB.ArrayBuffer, (nuint)(vertexData.Length * sizeof(float)), ptr, BufferUsageARB.StaticDraw);
            }

            gl.VertexAttribPointer(0, 4, VertexAttribPointerType.Float, false, 4 * sizeof(float), (void*)0);
            gl.EnableVertexAttribArray(0);

            gl.BindBuffer(BufferTargetARB.ArrayBuffer, 0);
            gl.BindVertexArray(0);
        }

        private static void TickEngineFrame()
        {
            gl.Clear((uint)GLEnum.ColorBufferBit);

            gl.UseProgram(shaderProgram);
            gl.Uniform2(uResolutionLocation, (float)currentWidth, (float)currentHeight);
            gl.Uniform2(uPanLocation, (float)cameraPan.X, (float)cameraPan.Y);
            gl.Uniform1(uZoomLocation, (float)cameraZoom);

            gl.BindVertexArray(vao);
            gl.DrawArrays(PrimitiveType.Triangles, 0, (uint)vertexCount);

            gl.BindVertexArray(0);
            gl.UseProgram(0);
        }
    }
}