using System.Linq;
using Silk.NET.OpenGL;
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

        // --- Asset / part list state ---
        private static List<PartAsset> allAssets = new();
        private static List<PartEntry> partsToRender = new();
        private static int currentAssetIndex = -1;

        private const int MaxParts = 200;
        private const int MaxPartsComposite = 1000;
        private static bool compositeMode = false;
        private static bool characterMode = false;
        private static Dictionary<string, PartAsset> assetById = new();

        private static Dictionary<PathData, List<List<Vector2D>>> polylineCacheCoarse = new();
        private static Dictionary<PathData, List<List<Vector2D>>> polylineCacheFine = new();

        // Geometry cache: keyed by currentAssetIndex so navigating back is instant
        private static Dictionary<int, (float[] Data, int Count)> geometryCache = new();

        private struct PartEntry
        {
            public VariantAsset Variant;
            public PartAsset Asset;
            public BoundingBox BBox;
            public int ZOrder;
            public bool MirrorX;
            public double RotOffset;
            public Vector2D PosOffset;
        }

        // ----------------------------------------------------------------
        //  Layer mapping — mirrors the game's hardcoded painter's order:
        //  Back→Legs→Waist→Torso→Chest→Neck→Shoulder→Arms→Head→Hair→Front→Overlay
        // ----------------------------------------------------------------
        private static int LookupZOrder(string key)
        {
            switch (key)
            {
                case "Stain": case "Pressing": return 0;
                case "BackHair0": case "BackHair1": return 1;
                case "BackOfHead": case "Back": return 2;
                case "Fin": case "Leaf": return 3;
                case "Thigh": case "QuadrupedThigh": return 5;
                case "Leg": case "QuadrupedLeg": return 6;
                case "Foot": case "QuadrupedFoot": return 7;
                case "Tail": case "Tail_肢中": return 8;
                case "Waist": case "QuadrupedWaist": return 10;
                case "WaistSkin": return 11;
                case "Torso": case "QuadrupedTorso": case "TorsoSkin": case "TorsoPlate": return 12;
                case "Chest": case "QuadrupedChest": case "ChestSkin": case "ChestPlate": return 13;
                case "Neck": return 14;
                case "Shoulder": return 15;
                case "UpperArm": case "LowerArm": case "Hand": return 16;
                case "鳥翼UpperArm": case "鳥翼LowerArm": case "BirdWingHand": return 16;
                case "獣翼UpperArm": case "獣翼LowerArm": case "BeastWingHand": return 16;
                case "四足UpperArm": case "四足LowerArm": case "QuadrupedHand": return 16;
                case "MembraneBase": case "MembraneTip": return 16;
                case "InsectScythe": case "SegmentLeg": return 16;
                case "LeftBreast": case "RightBreast": return 17;
                case "ChestHair": return 18;
                case "腹部": case "腹筋": return 18;
                case "Head": return 20;
                case "Face": return 21;
                case "MonoEye": case "MonoEyelid": return 21;
                case "EyeLeft": case "EyeScarLeft": return 21;
                case "AlienEyeLeft": return 21;
                case "DemonicWeakEyelidLeft": case "DemonicMidEyelidLeft": case "DemonicStrongEyelidLeft": return 21;
                case "BestialEyelidLeft": return 21;
                case "ForeheadEye": case "ForeheadEyelid": return 21;
                case "CheekEyeLeft": case "CheekEyelidLeft": return 21;
                case "Nose": case "NoseSkin": return 22;
                case "Mouth": case "Tongue": return 23;
                case "CheekSkinLeft": case "Blush": return 24;
                case "FaceHighlightLeft": case "TearLeft": return 24;
                case "EyeCornerShadowLeft": case "NoseDripLeft": return 24;
                case "DroolLeft": case "DroolMouthGashLeft": return 24;
                case "Ear": case "BeastEar": return 25;
                case "BaseHair": return 26;
                case "SideHairLeft": return 27;
                case "FrontHair": return 28;
                case "Hat": case "Horn": case "Forehead": case "Antenna": return 29;
                case "BallGag": case "Blindfold": return 30;
                case "Plant": case "MandibleBase": case "MandibleUpper": return 30;
                case "Tentacle": return 31;
                case "RestraintUpper": case "RestraintLower": case "RestraintChain": return 32;
                case "Chain": return 32;
                case "Forewing": case "Hindwing": return 33;
                default: return 50;
            }
        }

        private struct BoundingBox
        {
            public double MinX;
            public double MaxX;
            public double MinY;
            public double MaxY;
            public bool IsEmpty;
            public double Width => IsEmpty ? 0 : MaxX - MinX;
            public double Height => IsEmpty ? 0 : MaxY - MinY;
            public static BoundingBox Empty => new BoundingBox
            {
                IsEmpty = true, MinX = double.MaxValue, MaxX = double.MinValue,
                MinY = double.MaxValue, MaxY = double.MinValue
            };
            public void Update(Vector2D p)
            {
                if (p.X < MinX) MinX = p.X; if (p.X > MaxX) MaxX = p.X;
                if (p.Y < MinY) MinY = p.Y; if (p.Y > MaxY) MaxY = p.Y;
                IsEmpty = false;
            }
        }

        // ----------------------------------------------------------------
        //  Character assembly — maps .spart IDs + variant coords to
        //  form a complete character
        // ----------------------------------------------------------------
        private readonly struct CharPart
        {
            public readonly string Id;
            public readonly int VX, VY;
            public readonly bool MirrorX;
            public readonly double Rot;
            public readonly double OffX, OffY;
            public CharPart(string id, int vx = 0, int vy = 0,
                bool mirrorX = false, double rot = 0,
                double offX = 0, double offY = 0)
            { Id = id; VX = vx; VY = vy; MirrorX = mirrorX; Rot = rot; OffX = offX; OffY = offY; }
        }

        // ================================================================
        //  PHOENIX CHARACTER — part layout & known issues
        //
        //  Each CharPart maps a ShapePart to a specific variant (vx,vy).
        //  Parts are rendered in ZOrder (determined by LookupZOrder), not
        //  by array position.  Centering offset is computed from the union
        //  bounding box of ALL parts, so OffX/OffY fine-tune relative to
        //  that global center.
        //
        //  ViewBox is 0 0 1 1 (origin top-left).  PathGroup transforms
        //  (translate+rotate+scale) map local geometry → viewBox space.
        //  The centering offset then shifts everything so the composite
        //  sits at origin, then ApplyExtraTransforms applies mirrorX,
        //  rotation, and PosOffset (offX, offY) in that order.
        //
        //  Geometry bounds (viewBox Y, computed from SVG path data):
        //    Waist:      [0.195, 0.285]  bottom  = 0.285
        //    Torso:      [0.140, 0.218]
        //    Chest:      [0.078, 0.162]
        //    Neck:       [0.056, 0.109]
        //    Head:       [0.024, 0.069]
        //    Shoulder:   [0.142, 0.181]  (sits on Waist/Torso boundary)
        //    UpperArm:   [0.132, 0.179]  (overlaps Shoulder vertically)
        //    LowerArm:   [0.134, 0.187]
        //    Hand:       [0.145, 0.179]
        //    QuadThigh:  [0.394, 0.464]  top = 0.394  gap to Waist = 0.109
        //    QuadLeg:    [0.451, 0.510]
        //    QuadFoot:   [0.451, 0.514]
        //    Tail (y9):  [0.264, 0.292]  (just below Waist bottom)
        //    Tail_肢中:  [0.552, 0.571]  (far below body)
        //
        //  Known issues:
        //    - Waist→Thigh gap of 0.109 viewBox units → offY: -0.109 on
        //      all leg parts shifts them up to meet Waist bottom.
        //    - Tail_肢中 needs offY ~-0.25 (guessed, not precision-tuned)
        //    - Tail (bird y=9) barely extends past Waist; might need
        //      slight nudge down or up depending on desired look.
        //    - Shoulder→UpperArm joint may need X-axis adjustment;
        //      their Y-ranges already overlap.
        // ================================================================
        private static readonly CharPart[] PhoenixParts =
        {
            // ---- Core body (center) ----
            new("Waist"), new("Torso"), new("Chest"), new("Neck"), new("Head"),
            new("BaseHair"),
            new("SideHairLeft"),
            new("FrontHair"),

            // ---- Face features ----
            new("EyeLeft"),
            new("Nose"), new("Mouth"), new("Tongue"), new("Ear"),

            // ---- Left wing ----
            new("Shoulder"),
            new("鳥翼UpperArm"),
            new("鳥翼LowerArm"),
            new("BirdWingHand"),

            // ---- Right wing (mirrored) ----
            new("Shoulder", mirrorX: true),
            new("鳥翼UpperArm", mirrorX: true),
            new("鳥翼LowerArm", mirrorX: true),
            new("BirdWingHand", mirrorX: true),

            // ---- Back / chest ----
            new("Back"), new("LeftBreast"),

            // ---- Left leg (bird = quadruped variant at x=2) ----
            // offY: -0.109 shifts up by the Waist-bottom→Thigh-top gap
            new("QuadrupedThigh", 2, offY: -0.109),
            new("QuadrupedLeg", 2, offY: -0.109),
            new("QuadrupedFoot", 2, offY: -0.109),

            // ---- Right leg (mirrored) ----
            new("QuadrupedThigh", 2, mirrorX: true, offY: -0.109),
            new("QuadrupedLeg", 2, mirrorX: true, offY: -0.109),
            new("QuadrupedFoot", 2, mirrorX: true, offY: -0.109),

            // ---- Right-side face parts (mirrored) ----
            new("EyeLeft", mirrorX: true),
            new("SideHairLeft", mirrorX: true),

            // ---- Bird tail (from 尻尾, variant y=9 = 鳥尾) ----
            // Sits at viewBox Y~0.264-0.292; waist bottom is 0.285.
            // Already near the right spot — may need minor tuning.
            new("Tail", 0, 9),

            // ---- Phoenix tails (5× fanned out, from 肢中, variant x=2) ----
            // These sit at viewBox Y~0.552-0.571, far below the waist.
            // offY brings them up; exact value depends on how rotation
            // interacts with the centering offset.
            new("Tail_肢中", 2, rot: -45, offX: 0.2),
            new("Tail_肢中", 2, rot: -22, offX: 0.1),
            new("Tail_肢中", 2, rot: 0),
            new("Tail_肢中", 2, rot: 22, offX: -0.1),
            new("Tail_肢中", 2, rot: 45, offX: -0.2),
        };

        private static VariantAsset? FindVariant(PartAsset asset, int vx, int vy)
        {
            for (int i = 0; i < asset.Variants.Length; i++)
                if (asset.Variants[i].X == vx && asset.Variants[i].Y == vy)
                    return asset.Variants[i];
            return null;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("starting native desktop engine... ✧");
            Graphics.GLFWWindow glfwWin = new Graphics.GLFWWindow(currentWidth, currentHeight);
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

        // ----------------------------------------------------------------
        //  Rebuild — scan current asset(s) and collect up to MaxParts
        // ----------------------------------------------------------------
        private static void RebuildPartList()
        {
            partsToRender.Clear();
            polylineCacheCoarse.Clear();
            polylineCacheFine.Clear();
            geometryCache.Clear();

            if (characterMode)
            {
                BuildCharacterParts(PhoenixParts);
                BuildGeometry();
                return;
            }

            var source = currentAssetIndex < 0
                ? allAssets
                : (currentAssetIndex < allAssets.Count
                    ? new List<PartAsset> { allAssets[currentAssetIndex] }
                    : allAssets);

            int limit = compositeMode ? MaxPartsComposite : MaxParts;
            ProgBegin("BBox", limit);
            BuildPartListFromSource(source, limit);
            ProgEnd();
            BuildGeometry();
        }

        private static void BuildPartListFromSource(IEnumerable<PartAsset> source, int limit)
        {
            foreach (PartAsset asset in source)
            {
                VariantAsset[] variants = asset.Variants;
                for (int vi = 0; vi < variants.Length && partsToRender.Count < limit; vi++)
                {
                    VariantAsset variant = variants[vi];
                    BoundingBox bbox = ComputeBBox(variant);
                    if (!bbox.IsEmpty)
                    {
                        int z = LookupZOrder(asset.Id);
                        partsToRender.Add(new PartEntry { Variant = variant, Asset = asset, BBox = bbox, ZOrder = z });
                        ProgTick();
                    }
                }
            }
        }

        private static void BuildCharacterParts(CharPart[] parts)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                if (!assetById.TryGetValue(parts[i].Id, out var asset)) continue;
                var variant = FindVariant(asset, parts[i].VX, parts[i].VY);
                if (variant == null) continue;
                var bbox = ComputeBBox(variant);
                if (!bbox.IsEmpty)
                    partsToRender.Add(new PartEntry
                    {
                        Variant = variant, Asset = asset, BBox = bbox,
                        ZOrder = LookupZOrder(asset.Id),
                        MirrorX = parts[i].MirrorX,
                        RotOffset = parts[i].Rot,
                        PosOffset = new Vector2D(parts[i].OffX, parts[i].OffY)
                    });
            }
            Console.WriteLine($"Character: {partsToRender.Count} parts loaded");
        }

        private static BoundingBox ComputeBBox(VariantAsset variant)
        {
            BoundingBox bbox = BoundingBox.Empty;
            for (int gi = 0; gi < variant.Groups.Length; gi++)
            {
                PathGroup group = variant.Groups[gi];
                for (int pi = 0; pi < group.Paths.Length; pi++)
                {
                    PathData path = group.Paths[pi];
                    if (!polylineCacheCoarse.TryGetValue(path, out var polylines))
                    {
                        polylines = CommandsToPolylines(path.Commands, 0.05);
                        polylineCacheCoarse[path] = polylines;
                    }
                    for (int pli = 0; pli < polylines.Count; pli++)
                    {
                        List<Vector2D> poly = polylines[pli];
                        for (int pt = 0; pt < poly.Count; pt++)
                            bbox.Update(ApplyTransform(poly[pt], group));
                    }
                }
            }
            return bbox;
        }

        // ----------------------------------------------------------------
        //  BuildGeometry — flatten all parts into a single vertex buffer
        //
        //  Painter's algorithm: everything draws in one GL_TRIANGLES call.
        //  Later geometry paints over earlier geometry at overlapping pixels.
        //
        //  Ordering hierarchy (back → front):
        //    1. Parts by ZOrder (composite mode only; grid mode = no sort)
        //    2. PathGroups by array index within the variant
        //    3. Fill → Stroke within each PathGroup
        //
        //  Vertex format: vec4(x, y, gradY, colorFlag)
        //    gradY     = 0..1 normalized Y within group bbox (for vertical gradients)
        //    colorFlag = 1.0 for strokes (white), >10 for fills (hash-seeded color)
        // ----------------------------------------------------------------
        private static void BuildGeometry()
        {
            List<double> geo = new List<double>();
            Console.WriteLine($"Processing {partsToRender.Count} ShapeParts...");

            // Tear down old GL resources before rebuilding
            if (shaderProgram != 0) gl.DeleteProgram(shaderProgram);
            if (vao != 0) gl.DeleteVertexArray(vao);
            if (vbo != 0) gl.DeleteBuffer(vbo);
            shaderProgram = 0; vao = 0; vbo = 0;

            // Single-asset cache: skip rebuild if we've already computed this asset
            if (!compositeMode && !characterMode && currentAssetIndex >= 0
                && geometryCache.TryGetValue(currentAssetIndex, out var cached))
            {
                vertexCount = cached.Count;
                InitShaders();
                InitBuffers(cached.Data);
                Console.WriteLine($"  Cached: {allAssets[currentAssetIndex].OriginalKey} ({vertexCount} verts)");
                return;
            }

            if (partsToRender.Count == 0)
            {
                vertexCount = 0;
                InitShaders(); InitBuffers(Array.Empty<float>());
                return;
            }

            // --- Step 1: compute per-part screen offset and draw order ---
            double[] ox = new double[partsToRender.Count];
            double[] oy = new double[partsToRender.Count];
            int[] drawOrder;

            if (characterMode)
            {
                // Character: preserve viewBox-space positions, center the whole group
                double minX = double.MaxValue, minY = double.MaxValue;
                double maxX = double.MinValue, maxY = double.MinValue;
                for (int i = 0; i < partsToRender.Count; i++)
                {
                    var bb = partsToRender[i].BBox;
                    if (!bb.IsEmpty)
                    {
                        if (bb.MinX < minX) minX = bb.MinX;
                        if (bb.MinY < minY) minY = bb.MinY;
                        if (bb.MaxX > maxX) maxX = bb.MaxX;
                        if (bb.MaxY > maxY) maxY = bb.MaxY;
                    }
                }
                double cxo = -(minX + maxX) / 2;
                double cyo = -(minY + maxY) / 2;
                for (int i = 0; i < partsToRender.Count; i++)
                {
                    ox[i] = cxo;
                    oy[i] = cyo;
                }
                drawOrder = Enumerable.Range(0, partsToRender.Count)
                    .OrderBy(i => partsToRender[i].ZOrder).ToArray();
            }
            else if (compositeMode)
            {
                // Composite: center every part at the origin, sort by ZOrder
                for (int i = 0; i < partsToRender.Count; i++)
                {
                    var bb = partsToRender[i].BBox;
                    ox[i] = -(bb.MinX + bb.Width / 2);
                    oy[i] = -(bb.MinY + bb.Height / 2);
                }
                drawOrder = Enumerable.Range(0, partsToRender.Count)
                    .OrderBy(i => partsToRender[i].ZOrder).ToArray();
            }
            else
            {
                // Grid: tile parts left-to-right, top-to-bottom, no sort
                double maxW = 0, maxH = 0;
                for (int i = 0; i < partsToRender.Count; i++)
                {
                    double w = partsToRender[i].BBox.Width;
                    double h = partsToRender[i].BBox.Height;
                    if (w > maxW) maxW = w;
                    if (h > maxH) maxH = h;
                }
                double margin = System.Math.Max(maxW, maxH) * 0.2;
                double stepX = maxW + margin;
                double stepY = maxH + margin;
                int gridCols = (int)System.Math.Ceiling(System.Math.Sqrt(partsToRender.Count));
                for (int i = 0; i < partsToRender.Count; i++)
                {
                    var bb = partsToRender[i].BBox;
                    int col = i % gridCols;
                    int row = i / gridCols;
                    Vector2D tileCenter = new Vector2D(col * stepX, -row * stepY);
                    ox[i] = tileCenter.X - (bb.MinX + bb.Width / 2);
                    oy[i] = tileCenter.Y - (bb.MinY + bb.Height / 2);
                }
                drawOrder = Enumerable.Range(0, partsToRender.Count).ToArray();
            }

            // --- Step 2: paint all geometry in back-to-front order ---
            //
            //  Each part (VariantAsset) contains PathGroups, each PathGroup
            //  contains PathDatas.  For every path that has a fill colour we
            //  emit ear-clipped triangles; for every path that has a stroke
            //  colour we emit an extruded strip.  The append order within the
            //  vertex buffer determines draw order on screen.
            //
            Random rng = new Random(42); // deterministic hash-colour seed
            ProgBegin("Parts", drawOrder.Length);

            for (int oi = 0; oi < drawOrder.Length; oi++)
            {
                int pi = drawOrder[oi];
                VariantAsset variant = partsToRender[pi].Variant;
                Vector2D offset = new Vector2D(ox[pi], oy[pi]);

                for (int gi = 0; gi < variant.Groups.Length; gi++)
                {
                    PathGroup group = variant.Groups[gi];
                    // Each PathGroup gets a deterministic random colour
                    double colourId = rng.NextDouble() * 1000.0 + 10.0;

                    // ------ Fill pass: collect filled contours, triangulate, emit ------
                    //
                    // GDI+ semantics: ALL curves in a ShapePart merge into one
                    // GraphicsPath for FillPath.  We replicate that by collecting
                    // every path with `fill != "none"` into one contour list and
                    // ear-clip triangulating the lot as a unified region.
                    //
                    List<List<Vector2D>> fillContours = new List<List<Vector2D>>();
                    for (int pi2 = 0; pi2 < group.Paths.Length; pi2++)
                    {
                        PathData path = group.Paths[pi2];
                        if (path.Fill == "none" || string.IsNullOrEmpty(path.Fill))
                            continue;

                        // Tesselate bezier commands → polyline, cache result
                        if (!polylineCacheCoarse.TryGetValue(path, out var polylines))
                        {
                            polylines = CommandsToPolylines(path.Commands, 0.05);
                            polylineCacheCoarse[path] = polylines;
                        }

                        // Transform every vertex through the PathGroup transform
                        // then shift by the tile/composite offset
                        foreach (var poly in polylines)
                        {
                            List<Vector2D> xf = new List<Vector2D>(poly.Count);
                            foreach (var pt in poly)
                                xf.Add(ApplyExtraTransforms(ApplyTransform(pt, group), partsToRender[pi], offset));
                            fillContours.Add(xf);
                        }
                    }

                    if (fillContours.Count > 0)
                    {
                        // Compute vertical gradient bounds (Col1=top, Col2=bottom)
                        double minY = double.MaxValue, maxY = double.MinValue;
                        foreach (var c in fillContours)
                            foreach (var pt in c)
                            { if (pt.Y < minY) minY = pt.Y; if (pt.Y > maxY) maxY = pt.Y; }
                        double yRange = maxY - minY;

                        // Ear-clip triangulation → flat triangle list (x,y,_,_)
                        List<double> tris = Triangulation.Triangulate(fillContours);

                        // Stitch gradient-Y into the Z component of every vertex
                        for (int j = 0; j < tris.Count; j += 4)
                        {
                            double ny = yRange > 1e-10
                                ? (tris[j + 1] - minY) / yRange
                                : 0.5;
                            tris[j + 2] = ny < 0.0 ? 0.0 : ny > 1.0 ? 1.0 : ny;
                        }

                        AppendGeometry(geo, tris, colourId);
                    }

                    // ------ Stroke pass: extrude outline paths into thin strips ------
                    //
                    // Curves flagged as Outline=true in the original ShapePart become
                    // separate stroke-only paths.  Each is extruded (ToStrip) into a
                    // ribbon of triangles along the polyline.
                    //
                    for (int pi2 = 0; pi2 < group.Paths.Length; pi2++)
                    {
                        PathData path = group.Paths[pi2];
                        if (string.IsNullOrEmpty(path.Stroke) || path.Stroke == "none"
                            || path.StrokeWidth <= 0)
                            continue;

                        // Finer tesselation for strokes so curved outlines stay smooth
                        if (!polylineCacheFine.TryGetValue(path, out var polylines))
                        {
                            polylines = CommandsToPolylines(path.Commands, 0.02);
                            polylineCacheFine[path] = polylines;
                        }

                        foreach (var poly in polylines)
                        {
                            List<Vector2D> xf = new List<Vector2D>(poly.Count);
                            foreach (var pt in poly)
                                xf.Add(ApplyExtraTransforms(ApplyTransform(pt, group), partsToRender[pi], offset));

                            List<double> strip = Triangulation.ToStrip(
                                path.StrokeWidth, xf, path.IsClosed);
                            AppendGeometry(geo, strip, 1.0);
                        }
                    }
                }

                ProgTick();
            }
            ProgEnd();

            // Flatten the accumulated double list into a float[] for the GPU
            float[] vertexData = new float[geo.Count];
            for (int i = 0; i < geo.Count; i++)
                vertexData[i] = (float)geo[i];
            vertexCount = vertexData.Length / 4;

            // Cache hit for subsequent single-asset navigation
            if (!compositeMode && !characterMode && currentAssetIndex >= 0)
                geometryCache[currentAssetIndex] = (vertexData, vertexCount);

            InitShaders();
            InitBuffers(vertexData);
        }

        // ----------------------------------------------------------------
        //  StartGameEngine
        // ----------------------------------------------------------------
        public static void StartGameEngine(IGameWindow window)
        {
            gameWindow = window;
            gameWindow.Resize += (int w, int h) => { currentWidth = w; currentHeight = h; gl?.Viewport(0, 0, (uint)w, (uint)h); };
            gameWindow.MouseClick += (MouseButtons btn) =>
            {
                if ((btn & MouseButtons.Left) != 0) { isDragging = true; lastMousePos = gameWindow.GetCursorPoint(); }
                else isDragging = false;
                showWireframe = (btn & MouseButtons.Right) != 0;
            };
            gameWindow.MouseMove += (Vector2D pos) =>
            {
                Vector2D currentPos = new Vector2D(pos.X, pos.Y);
                if (isDragging)
                {
                    double deltaX = currentPos.X - lastMousePos.X;
                    double deltaY = currentPos.Y - lastMousePos.Y;
                    double minRes = System.Math.Min(currentWidth, currentHeight);
                    cameraPan.X += (deltaX / minRes) * 2.0 / cameraZoom;
                    cameraPan.Y += (deltaY / minRes) * 2.0 / cameraZoom;
                }
                lastMousePos = currentPos;
            };
            gameWindow.MouseScroll += (double offsetx, double offsety) =>
            {
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
            gameWindow.KeyDown += OnKeyDown;

            gl = window.CreateGlContext();
            gl.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            gl.Enable(EnableCap.ProgramPointSize);

            string assetPath = "Assets";
            for (int i = 0; i < 5; i++) { if (Directory.Exists(assetPath)) break; assetPath = Path.Combine("..", assetPath); }

            if (!Directory.Exists(assetPath))
            {
                Console.WriteLine("Could not find Assets directory!");
            }
            else
            {
                ResourceManager resourceManager = new ResourceManager(assetPath);
                resourceManager.RegisterProcessor(new PartProcessor());
                resourceManager.Initialize();
                List<string> ids = resourceManager.GetAssetIds().ToList();

                for (int i = 0; i < ids.Count; i++)
                {
                    PartAsset? asset = resourceManager.GetAsset<PartAsset>(ids[i]);
                    if (asset != null) { allAssets.Add(asset); assetById[asset.Id] = asset; }
                }

                Console.WriteLine($"Loaded {allAssets.Count} part assets.");
                Console.WriteLine("←/→ switch asset  ↑ focus single  ↓ show all  C composite  P phoenix  Space reset  Esc exit");
                Console.WriteLine("Tip: dotnet run -c Release for ~10x faster geometry");
                RebuildPartList();
                UpdateTitle();
            }
        }

        // ----------------------------------------------------------------
        //  Keyboard navigation
        // ----------------------------------------------------------------
        private static void OnKeyDown(KeyCode key)
        {
            switch (key)
            {
                case KeyCode.Left:
                    if (currentAssetIndex > 0) { currentAssetIndex--; RebuildPartList(); UpdateTitle(); }
                    break;
                case KeyCode.Right:
                    if (currentAssetIndex < allAssets.Count - 1) { currentAssetIndex++; RebuildPartList(); UpdateTitle(); }
                    break;
                case KeyCode.Up:
                    if (currentAssetIndex < 0) { currentAssetIndex = 0; RebuildPartList(); UpdateTitle(); }
                    break;
                case KeyCode.Down:
                    currentAssetIndex = -1; RebuildPartList(); UpdateTitle();
                    break;
                case KeyCode.Home:
                    currentAssetIndex = 0; RebuildPartList(); UpdateTitle();
                    break;
                case KeyCode.End:
                    currentAssetIndex = allAssets.Count - 1; RebuildPartList(); UpdateTitle();
                    break;
                case KeyCode.Space:
                    cameraPan = new Vector2D(0, 0); cameraZoom = 1.0;
                    break;
                case KeyCode.Escape:
                    isRunning = false;
                    break;
                case KeyCode.C:
                    compositeMode = !compositeMode;
                    if (compositeMode) characterMode = false;
                    Console.WriteLine($"Composite mode: {(compositeMode ? "ON" : "OFF")}");
                    geometryCache.Clear();
                    RebuildPartList();
                    UpdateTitle();
                    break;
                case KeyCode.P:
                    characterMode = !characterMode;
                    if (characterMode)
                    {
                        compositeMode = false; currentAssetIndex = -1;
                        cameraPan = new Vector2D(0, 0); cameraZoom = 4.0;
                    }
                    Console.WriteLine($"Character mode: {(characterMode ? "PHOENIX" : "OFF")}");
                    geometryCache.Clear();
                    RebuildPartList();
                    UpdateTitle();
                    break;
            }
        }

        private static void UpdateTitle()
        {
            string assetName = characterMode ? "Phoenix"
                : currentAssetIndex < 0 ? "All Assets"
                : allAssets[currentAssetIndex].OriginalKey;
            string mode = compositeMode ? " [COMPOSITE]" : characterMode ? " [CHARACTER]" : "";
            gameWindow?.SetTitle($"Slave Engine — {assetName}{mode} ({partsToRender.Count} parts shown)");
        }

        // ----------------------------------------------------------------
        //  Progress helpers
        // ----------------------------------------------------------------
        private static string progLabel = "";
        private static int progCur, progTot;
        private static DateTime progStart;
        private static void ProgBegin(string label, int total)
        {
            progLabel = label; progCur = 0; progTot = total; progStart = DateTime.UtcNow;
            ProgTick();
        }
        private static void ProgTick()
        {
            if (progCur < progTot) progCur++;
            if (progTot > 0)
            {
                double t = (DateTime.UtcNow - progStart).TotalSeconds;
                Console.Write($"\r  {progLabel} [{progCur}/{progTot}] {t:F1}s");
            }
        }
        private static void ProgEnd()
        {
            double t = (DateTime.UtcNow - progStart).TotalSeconds;
            Console.WriteLine($"\r  {progLabel} [{progCur}/{progTot}] {t:F1}s     ");
        }

        // ----------------------------------------------------------------
        //  Geometry helpers
        // ----------------------------------------------------------------
        private static List<List<Vector2D>> CommandsToPolylines(BezierCommand[] commands, double delta)
        {
            List<List<Vector2D>> polylines = new List<List<Vector2D>>();
            List<Vector2D>? currentPoly = null;
            Vector2D currentPos = new Vector2D(0, 0);
            Vector2D startPos = new Vector2D(0, 0);
            void CloseCurrent() { if (currentPoly != null && currentPoly.Count >= 2) polylines.Add(currentPoly); currentPoly = null; }
            foreach (BezierCommand cmd in commands)
            {
                switch (cmd.Type)
                {
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
                        for (int ci = 1; ci < curve.Count; ci++)
                            currentPoly.Add(curve[ci]);
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
            double x1 = p.X * group.Sx + group.Bx;
            double y1 = p.Y * group.Sy + group.By;
            double rad = group.Angle * System.Math.PI / 180.0;
            double cos = System.Math.Cos(rad);
            double sin = System.Math.Sin(rad);
            return new Vector2D(x1 * cos - y1 * sin + group.Tx, x1 * sin + y1 * cos + group.Ty);
        }

        private static Vector2D RotatePoint(Vector2D p, double rad)
        {
            double cos = System.Math.Cos(rad);
            double sin = System.Math.Sin(rad);
            return new Vector2D(p.X * cos - p.Y * sin, p.X * sin + p.Y * cos);
        }

        // Transform order: centering offset → mirrorX → rotation → PosOffset.
        // PosOffset (offX, offY) applies AFTER rotation, so rotated parts'
        // offY direction is rotated too (not a simple screen-space shift).
        private static Vector2D ApplyExtraTransforms(Vector2D p, PartEntry entry, Vector2D offset)
        {
            p += offset;
            if (entry.MirrorX) p.X = -p.X;
            if (entry.RotOffset != 0.0)
                p = RotatePoint(p, entry.RotOffset * System.Math.PI / 180.0);
            p += entry.PosOffset;
            return p;
        }

        private static void AppendGeometry(List<double> dest, List<double> src, double colorFlag)
        {
            for (int i = 0; i < src.Count; i += 4)
            {
                dest.Add(src[i]); dest.Add(src[i + 1]);
                dest.Add(src[i + 2]); dest.Add(colorFlag);
            }
        }

        // ----------------------------------------------------------------
        //  GL boilerplate
        // ----------------------------------------------------------------
        private static void InitShaders()
        {
            string vertCode = @"#version 330 core
            layout (location = 0) in vec4 aPosition;
            uniform vec2 u_resolution; uniform vec2 u_pan; uniform float u_zoom;
            out float vColorFlag;
            out float vGradY;
            void main() {
                vec2 transformedPos = (aPosition.xy + u_pan) * u_zoom;
                transformedPos.y = -transformedPos.y;
                float minRes = min(u_resolution.x, u_resolution.y);
                gl_Position = vec4(transformedPos * (minRes / u_resolution.xy), 0.0, 1.0);
                gl_PointSize = 6.0; vColorFlag = aPosition.w; vGradY = aPosition.z;
            }";
            string fragCode = @"#version 330 core
            in float vColorFlag; in float vGradY; uniform int u_render_mode; out vec4 FragColor;
            vec3 hash3(float n) { return fract(sin(vec3(n, n + 1.0, n + 2.0)) * vec3(43758.5453123, 22578.1459123, 19642.3490423)); }
            void main() {
                if (u_render_mode == 1) FragColor = vec4(1.0, 0.2, 0.2, 1.0);
                else if (u_render_mode == 2) FragColor = vec4(0.0, 0.9, 1.0, 1.0);
                else {
                    if (vColorFlag < 1.5) FragColor = vec4(1.0, 1.0, 1.0, 1.0);
                    else {
                        vec3 base = hash3(vColorFlag);
                        vec3 light = mix(base, vec3(1.0), 0.25);
                        vec3 dark = mix(base, vec3(0.0), 0.35);
                        FragColor = vec4(mix(light, dark, vGradY), 1.0);
                    }
                }
            }";
            uint vertShader = gl.CreateShader(ShaderType.VertexShader);
            gl.ShaderSource(vertShader, vertCode); gl.CompileShader(vertShader);
            uint fragShader = gl.CreateShader(ShaderType.FragmentShader);
            gl.ShaderSource(fragShader, fragCode); gl.CompileShader(fragShader);
            shaderProgram = gl.CreateProgram();
            gl.AttachShader(shaderProgram, vertShader); gl.AttachShader(shaderProgram, fragShader);
            gl.LinkProgram(shaderProgram);
            uResolutionLocation = gl.GetUniformLocation(shaderProgram, "u_resolution");
            uPanLocation = gl.GetUniformLocation(shaderProgram, "u_pan");
            uZoomLocation = gl.GetUniformLocation(shaderProgram, "u_zoom");
            uRenderModeLocation = gl.GetUniformLocation(shaderProgram, "u_render_mode");
            gl.DeleteShader(vertShader); gl.DeleteShader(fragShader);
        }

        private static unsafe void InitBuffers(float[] vertexData)
        {
            vao = gl.GenVertexArray(); vbo = gl.GenBuffer();
            gl.BindVertexArray(vao); gl.BindBuffer(BufferTargetARB.ArrayBuffer, vbo);
            fixed (void* ptr = vertexData)
                gl.BufferData(BufferTargetARB.ArrayBuffer, (nuint)(vertexData.Length * sizeof(float)), ptr, BufferUsageARB.StaticDraw);
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
            if (showWireframe)
            {
                gl.PolygonMode(GLEnum.FrontAndBack, GLEnum.Line);
                gl.Uniform1(uRenderModeLocation, 2);
                gl.DrawArrays(PrimitiveType.Triangles, 0, (uint)vertexCount);
                gl.PolygonMode(GLEnum.FrontAndBack, GLEnum.Fill);
                gl.Uniform1(uRenderModeLocation, 1);
                gl.DrawArrays(PrimitiveType.Points, 0, (uint)vertexCount);
            }
            else
            {
                gl.PolygonMode(GLEnum.FrontAndBack, GLEnum.Fill);
                gl.Uniform1(uRenderModeLocation, 0);
                gl.DrawArrays(PrimitiveType.Triangles, 0, (uint)vertexCount);
            }
        }
    }
}
