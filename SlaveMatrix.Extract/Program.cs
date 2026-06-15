using _2DGAMELIB;
using SlaveMatrix.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SlaveMatrix.Extract;

class Program
{
    static readonly string ProjectRoot = Environment.CurrentDirectory;

    static string AssetsDir = Path.Combine(ProjectRoot, "SlaveMatrix", "Assets");
    static string OutputDir;

    // Complete translation map for extraction output.
    // Separate from the runtime KeyMap in ObjExtensions — the runtime map only
    // contains entries that match the old game code's string lookups.
    static readonly Dictionary<string, string> EnglishNameMap = new()
    {
        ["咳"] = "Cough",
        ["腰"] = "Waist",
        ["胴"] = "Torso",
        ["首"] = "Neck",
        ["頭"] = "Head",
        ["後髪0"] = "BackHair0",
        ["後髪1"] = "BackHair1",
        ["横髪"] = "SideHair",
        ["脚"] = "Leg",
        ["腕"] = "Arm",
        ["肩"] = "Shoulder",
        ["胸"] = "Chest",
        ["下腕"] = "LowerArm",
        ["上腕"] = "UpperArm",
        ["鳥翼上腕"] = "鳥翼UpperArm",
        ["獣翼上腕"] = "獣翼UpperArm",
        ["四足上腕"] = "四足UpperArm",
        ["鳥翼下腕"] = "鳥翼LowerArm",
        ["獣翼下腕"] = "獣翼LowerArm",
        ["四足下腕"] = "四足LowerArm",
        ["基髪"] = "BaseHair",
        ["胸毛"] = "ChestHair",
        ["前髪"] = "FrontHair",
        ["眉左"] = "EyebrowLeft",
        ["額目"] = "ForeheadEye",
        ["額瞼"] = "ForeheadEyelid",
        ["顔ハイライト左"] = "FaceHighlightLeft",
        ["顔面"] = "Face",
        ["魔性中瞼左"] = "DemonicMidEyelidLeft",
        ["魔性強瞼左"] = "DemonicStrongEyelidLeft",
        ["魔性弱瞼左"] = "DemonicWeakEyelidLeft",
        ["単眼目"] = "MonoEye",
        ["単眼眉"] = "MonoEyebrow",
        ["単眼瞼"] = "MonoEyelid",
        ["単足"] = "MonoLeg",
        ["獣性瞼左"] = "BestialEyelidLeft",
        ["目傷左"] = "EyeScarLeft",
        ["目尻影左"] = "EyeCornerShadowLeft",
        ["目左"] = "EyeLeft",
        ["目隠帯"] = "Blindfold",
        ["頬目左"] = "CheekEyeLeft",
        ["頬瞼左"] = "CheekEyelidLeft",
        ["頬肌左"] = "CheekSkinLeft",
        ["口"] = "Mouth",
        ["舌"] = "Tongue",
        ["涎左"] = "DroolLeft",
        ["涎口裂け左"] = "DroolMouthGashLeft",
        ["呼気"] = "Breath",
        ["吹出し"] = "SpeechBubble",
        ["鼻"] = "Nose",
        ["鼻水左"] = "NoseDripLeft",
        ["鼻肌"] = "NoseSkin",
        ["耳"] = "Ear",
        ["獣耳"] = "BeastEar",
        ["角"] = "Horn",
        ["胸郭"] = "Chest",
        ["胸郭肌"] = "ChestSkin",
        ["胸郭腹板"] = "ChestPlate",
        ["胸左"] = "LeftBreast",
        ["胴肌"] = "TorsoSkin",
        ["胴腹板"] = "TorsoPlate",
        ["腰肌"] = "WaistSkin",
        ["ボテ腹"] = "PregnantBelly",
        ["ボテ腹板"] = "PregnantBellyPlate",
        ["固定帯"] = "FixingBelt",
        ["紅潮"] = "Blush",
        ["肛門"] = "Anus",
        ["肛門精液垂れ"] = "AnusSemenDrip",
        ["膣基"] = "VaginaBase",
        ["膣内精液"] = "InternalSemen",
        ["性器"] = "Genitals",
        ["性器精液垂れ"] = "GenitalsSemenDrip",
        ["射精"] = "Ejaculation",
        ["放尿"] = "Urination",
        ["噴乳左"] = "LactationLeft",
        ["潮吹"] = "Squirting",
        ["尾"] = "Tail",
        ["背中"] = "Back",
        ["手"] = "Hand",
        ["足"] = "Foot",
        ["腿"] = "Thigh",
        ["前翅"] = "Forewing",
        ["後翅"] = "Hindwing",
        ["触手"] = "Tentacle",
        ["触覚"] = "Antenna",
        ["節足"] = "SegmentLeg",
        ["虫鎌"] = "InsectScythe",
        ["虫顎"] = "InsectJaw",
        ["植"] = "Plant",
        ["葉"] = "Leaf",
        ["羽根箒"] = "FeatherDuster",
        ["飛沫"] = "Splash",
        ["飛膜先"] = "MembraneTip",
        ["飛膜根"] = "MembraneBase",
        ["上着トップ"] = "JacketTop",
        ["上着ミドル"] = "JacketMid",
        ["上着ボトム前"] = "JacketBottomFront",
        ["上着ボトム後"] = "JacketBottomBack",
        ["下着トップ"] = "UnderwearTop",
        ["下着ボトム"] = "UnderwearBottom",
        ["下着乳首左"] = "UnderwearNippleLeft",
        ["下着陰核"] = "UnderwearClitoris",
        ["帽子"] = "Hat",
        ["パンスト"] = "Pantyhose",
        ["キャップ左"] = "CapLeft",
        ["キャップ中"] = "CapMid",
        ["玉口枷"] = "BallGag",
        ["留具前"] = "FastenerFront",
        ["留具後"] = "FastenerBack",
        ["拘束具上"] = "RestraintUpper",
        ["拘束具下"] = "RestraintLower",
        ["拘束鎖"] = "RestraintChain",
        ["押し付け"] = "Pressing",
        ["コモン"] = "CommonCursor",
        ["ハンド"] = "HandCursor",
        ["ペニス"] = "PenisCursor",
        ["アナル"] = "AnalCursor",
        ["マウス"] = "MouthCursor",
        ["ディル"] = "DildoCursor",
        ["デンマ"] = "VibratorCursor",
        ["ドリル"] = "DrillCursor",
        ["パール"] = "PearlCursor",
        ["ロータ"] = "RotoCursor",
        ["T字剃刀"] = "TRazorCursor",
        ["ぶっかけ"] = "Bukkake",
        ["キスマーク"] = "KissMark",
        ["汗"] = "Sweat",
        ["汚れ"] = "Stain",
        ["流血中"] = "BleedingMid",
        ["流血大"] = "BleedingLarge",
        ["流血小"] = "BleedingSmall",
        ["鞭痕"] = "WhipMark",
        ["横髪左"] = "SideHairLeft",
        ["涙左"] = "TearLeft",
        ["青筋左"] = "VeinLeft",
        ["頭部前"] = "Forehead",
        ["頭部後"] = "BackOfHead",
        ["鰭"] = "Fin",
        ["獣翼手"] = "BeastWingHand",
        ["鳥翼手"] = "BirdWingHand",
        ["エイリアン目左"] = "AlienEyeLeft",
        ["ピアス"] = "Piercing",
        ["反応"] = "Reaction",
        ["多足"] = "MultiLeg",
        ["大顎上"] = "MandibleUpper",
        ["大顎基"] = "MandibleBase",
        ["意思表示"] = "Expression",
        ["断面"] = "CrossSection",
        ["染み"] = "Spot",
        ["長物"] = "Phallus",
        ["調教鞭"] = "Whip",
        ["衝撃"] = "Impact",
        ["鎖"] = "Chain",
        ["四足ボテ腹"] = "QuadrupedPregnantBelly",
        ["四足固定帯"] = "QuadrupedFixingBelt",
        ["四足性器"] = "QuadrupedGenitals",
        ["四足性器精液垂れ"] = "QuadrupedGenitalsSemenDrip",
        ["四足手"] = "QuadrupedHand",
        ["四足放尿"] = "QuadrupedUrination",
        ["四足断面"] = "QuadrupedCrossSection",
        ["四足染み"] = "QuadrupedSpot",
        ["四足潮吹"] = "QuadrupedSquirting",
        ["四足留具前"] = "QuadrupedFastenerFront",
        ["四足留具後"] = "QuadrupedFastenerBack",
        ["四足肛門"] = "QuadrupedAnus",
        ["四足肛門精液垂れ"] = "QuadrupedAnusSemenDrip",
        ["四足胴"] = "QuadrupedTorso",
        ["四足胸郭"] = "QuadrupedChest",
        ["四足脇"] = "QuadrupedSide",
        ["四足脚"] = "QuadrupedLeg",
        ["四足腰"] = "QuadrupedWaist",
        ["四足腿"] = "QuadrupedThigh",
        ["四足膣内精液"] = "QuadrupedInternalSemen",
        ["四足膣基"] = "QuadrupedVaginaBase",
        ["四足足"] = "QuadrupedFoot",
        ["四足飛沫"] = "QuadrupedSplash",
    };

    static void Main(string[] args)
    {
        Console.WriteLine("SlaveMatrix Asset Extractor");
        Console.WriteLine("=================================\n");

        OutputDir = args.Length > 0 && args[0] == "--output" && args.Length > 1
            ? Path.GetFullPath(args[1])
            : Path.GetFullPath(AssetsDir);

        var partsDir = Path.Combine(OutputDir, "Parts");
        var jsonDir = Path.Combine(OutputDir, "..", "..", "extracted");
        Directory.CreateDirectory(partsDir);
        Directory.CreateDirectory(jsonDir);

        var resources = new (string Name, byte[] Data)[]
        {
            ("胴体", Resources.胴体),
            ("肩左", Resources.肩左),
            ("腕左", Resources.腕左),
            ("脚左", Resources.脚左),
            ("尻尾", Resources.尻尾),
            ("半身", Resources.半身),
            ("肢左", Resources.肢左),
            ("肢中", Resources.肢中),
            ("性器", Resources.性器),
            ("性器付", Resources.性器付),
            ("スタンプ", Resources.スタンプ),
            ("カーソル", Resources.カーソル),
            ("その他", Resources.その他),
        };

        var catalog = new JObject();
        catalog["parts"] = new JArray();
        var catalogParts = (JArray)catalog["parts"];
        HashSet<string> usedEngKeys = new HashSet<string>();

        foreach (var (name, data) in resources)
        {
            Console.Write($"Loading {name}... ");
            BodyTemplate? obj;
            try
            {
                obj = data.ObjLoadRaw();
                if (obj == null) { Console.WriteLine("FAILED: null"); continue; }
                Console.WriteLine($"OK ({obj.Difss.Count} keys)");
            }
            catch (Exception ex) { Console.WriteLine($"FAILED: {ex.Message}"); continue; }

            Console.Write("  Applying MigrateKeys... ");
            // Capture original keys before migration for original_key tracking
            var origKeys = obj.Difss.Keys.Cast<string>().ToList();
            obj.MigrateKeys();
            Console.WriteLine("OK");

            var jsonObj = ExportObj(obj);
            var jsonPath = Path.Combine(jsonDir, $"{name}.json");
            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(jsonObj, Formatting.Indented));

            var keys = obj.Difss.Keys.Cast<string>().ToList();

            foreach (var key in keys)
            {
                // Use extraction EnglishNameMap for directory naming
                var engKey = EnglishNameMap.TryGetValue(key, out var mapped) ? mapped : key;
                // Handle key collisions across resources by appending resource name
                if (!usedEngKeys.Add(engKey))
                {
                    var disambig = SanitizeName($"{engKey}_{name}");
                    Console.WriteLine($"    Warning: key '{key}' collides with existing '{engKey}'. Renaming to '{disambig}'.");
                    engKey = disambig;
                }
                var difs = obj.Difss[key];
                var partDir = Path.Combine(partsDir, SanitizeName(engKey));
                Directory.CreateDirectory(partDir);

                var foundJoints = new List<string>();
                // original_key: the pre-migration Japanese key
                var originalKey = origKeys.Contains(key) ? key : origKeys.FirstOrDefault(ok => EnglishNameMap.GetValueOrDefault(ok, ok) == engKey) ?? key;

                var partEntry = new JObject
                {
                    ["id"] = engKey,
                    ["original_key"] = originalKey,
                    ["resource"] = name,
                    ["morph_x"] = difs.GetCountX(),
                    ["morph_y"] = difs.GetCountY(),
                    ["variants"] = new JArray(),
                    ["fields"] = new JArray()
                };

                var variants = (JArray)partEntry["variants"];

                for (int x = 0; x < difs.GetCountX(); x++)
                {
                    var dif = difs[x];
                    for (int y = 0; y < dif.Count; y++)
                    {
                        var pars = dif[y];
                        var svgName = $"x{x}y{y}.svg";
                        var svgContent = ExportParsToSvg(pars, foundJoints);

                        variants.Add(new JObject
                        {
                            ["x"] = x,
                            ["y"] = y,
                            ["file"] = svgName
                        });

                        File.WriteAllText(Path.Combine(partDir, svgName), svgContent);
                    }
                }

                foreach (string childKey in difs[0][0].pars.Keys)
                {
                    ((JArray)partEntry["fields"]).Add(new JObject { ["name"] = childKey });
                }

                if (foundJoints.Count > 0)
                {
                    var joints = new JArray();
                    foreach (var j in foundJoints.Distinct())
                    {
                        var parts = j.Split(',');
                        joints.Add(new JObject
                        {
                            ["position"] = new JArray
                            {
                                double.Parse(parts[0], CultureInfo.InvariantCulture),
                                double.Parse(parts[1], CultureInfo.InvariantCulture)
                            }
                        });
                    }
                    partEntry["joints"] = joints;
                }

                var yaml = ToYaml((JObject)partEntry);
                File.WriteAllText(Path.Combine(partDir, "part.yaml"), yaml);

                catalogParts.Add(new JObject
                {
                    ["id"] = engKey,
                    ["path"] = $"Parts/{SanitizeName(engKey)}/"
                });
            }

            Console.WriteLine($"    -> {keys.Count} parts exported");
        }

        var catalogYaml = ToYaml(catalog);
        var catalogPath = Path.Combine(OutputDir, "Catalog.yaml");
        File.WriteAllText(catalogPath, catalogYaml);
        Console.WriteLine($"\nCatalog: {catalogPath}");
        Console.WriteLine($"Total: {((JArray)catalog["parts"]).Count} parts\n");
    }

    static string ToYaml(JObject obj, int indent = 0)
    {
        var prefix = new string(' ', indent);
        var sb = new StringBuilder();
        foreach (var prop in obj.Properties())
        {
            if (prop.Value is JObject nested)
            {
                sb.AppendLine($"{prefix}{prop.Name}:");
                sb.Append(ToYaml(nested, indent + 2));
            }
            else if (prop.Value is JArray arr)
            {
                if (arr.Count == 0)
                {
                    sb.AppendLine($"{prefix}{prop.Name}: []");
                    continue;
                }

                if (arr[0] is JObject)
                {
                    sb.AppendLine($"{prefix}{prop.Name}:");
                    foreach (var item in arr)
                    {
                        var objItem = (JObject)item;
                        sb.Append($"{prefix}- ");
                        var first = true;
                        foreach (var p in objItem.Properties())
                        {
                            if (first)
                            {
                                sb.AppendLine($"{p.Name}: {FormatYamlValue(p.Value)}");
                                first = false;
                            }
                            else
                            {
                                sb.AppendLine($"{prefix}  {p.Name}: {FormatYamlValue(p.Value)}");
                            }
                        }
                    }
                }
                else
                {
                    sb.AppendLine($"{prefix}{prop.Name}:");
                    foreach (var item in arr)
                        sb.AppendLine($"{prefix}- {FormatYamlValue(item)}");
                }
            }
            else
            {
                sb.AppendLine($"{prefix}{prop.Name}: {FormatYamlValue(prop.Value)}");
            }
        }
        return sb.ToString();
    }

    static string FormatYamlValue(JToken token)
    {
        if (token.Type == JTokenType.String)
        {
            var s = token.Value<string>();
            if (s.Contains(':') || s.Contains('#') || s.Contains('\n'))
                return $"\"{s}\"";
            return s;
        }
        if (token.Type == JTokenType.Float)
            return ((double)token).ToString("G", CultureInfo.InvariantCulture);
        if (token.Type == JTokenType.Integer)
            return ((long)token).ToString(CultureInfo.InvariantCulture);
        return token.ToString();
    }

    static string ExportParsToSvg(PartGroup PartGroup, List<string> foundJoints)
    {
        var sb = new StringBuilder();
        sb.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
        sb.AppendLine("<svg xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 1 1\">");
        ExportParsToSvgInner(PartGroup, sb, foundJoints);
        sb.AppendLine("</svg>");
        return sb.ToString();
    }

    static void ExportParsToSvgInner(PartGroup PartGroup, StringBuilder sb, List<string> foundJoints)
    {
        foreach (string key in PartGroup.pars.Keys)
        {
            var val = PartGroup[key];
            if (val is PartGroup childPars)
            {
                sb.AppendLine($"<g id=\"{EscapeXml(key)}\">");
                ExportParsToSvgInner(childPars, sb, foundJoints);
                sb.AppendLine("</g>");
            }
            else if (val is ShapePart par)
            {
                ExportParToSvg(par, key, sb, foundJoints);
            }
        }
    }

    static void ExportParToSvg(ShapePart ShapePart, string name, StringBuilder sb, List<string> foundJoints)
    {
        if (!ShapePart.Dra) return;

        var bx = ShapePart.GetBasePoint().X;
        var by = ShapePart.GetBasePoint().Y;
        var px = ShapePart.GetPosition().X;
        var py = ShapePart.GetPosition().Y;
        var angle = ShapePart.GetAngle();
        var sx = ShapePart.GetSize() * ShapePart.GetSizeX();
        var sy = ShapePart.GetSize() * ShapePart.GetSizeY();

        var hasTransform = System.Math.Abs(bx) > 0.001 || System.Math.Abs(by) > 0.001
            || System.Math.Abs(px) > 0.001 || System.Math.Abs(py) > 0.001
            || System.Math.Abs(angle) > 0.001 || System.Math.Abs(sx - 1) > 0.001 || System.Math.Abs(sy - 1) > 0.001;

        if (hasTransform)
            sb.Append($"<g transform=\"translate({F(px)},{F(py)}) rotate({F(angle)}) scale({F(sx)},{F(sy)}) translate({F(-bx)},{F(-by)})\">");

        var curves = ShapePart.GetOP().Where(c => c.ps.Count >= 2).ToList();
        if (curves.Count > 0)
        {
            var fillSegments = new List<string>();
            var strokeSegments = new List<(string d, float sw)>();
            foreach (var outObj in curves)
            {
                var d = BuildSvgPath(outObj.ps, outObj.Tension, ShapePart.IsClosed);
                fillSegments.Add(d);
                if (outObj.Outline)
                {
                    float sw_val = (float)System.Math.Max(ShapePart.GetPenWidth(), 0.001);
                    strokeSegments.Add((d, sw_val));
                }
            }

            // Merge all curves into one continuous fill path
            var fillD = new StringBuilder();
            fillD.Append(fillSegments[0]);
            for (int i = 1; i < fillSegments.Count; i++)
            {
                var d = fillSegments[i];
                // Strip leading "M x y" (curves connect end-to-start)
                int idx = 2;
                while (idx < d.Length && d[idx] != ' ') idx++; idx++;
                while (idx < d.Length && d[idx] != ' ') idx++; idx++;
                // Strip trailing Z if present
                if (d.EndsWith(" Z")) d = d.Substring(0, d.Length - 2);
                fillD.Append(' ');
                fillD.Append(d.Substring(idx));
            }
            var combined = fillD.ToString();
            if (combined.EndsWith(" Z")) combined = combined.Substring(0, combined.Length - 2);
            if (ShapePart.IsClosed) combined += " Z";
            sb.AppendLine($"<path d=\"{combined}\" fill=\"#cccccc\" stroke=\"none\" stroke-width=\"0\"/>");

            // Emit individual stroke paths for Outline=true curves
            foreach (var (d, sw) in strokeSegments)
            {
                sb.AppendLine($"<path d=\"{d}\" fill=\"none\" stroke=\"#000000\" stroke-width=\"{F(sw)}\"/>");
            }
        }

        if (hasTransform)
            sb.Append("</g>");

        foreach (var joi in ShapePart.GetJP())
        {
            foundJoints.Add($"{F(joi.Joint.X)},{F(joi.Joint.Y)}");
        }
    }

    static string BuildSvgPath(List<Vector2D> points, float tension, bool closed)
    {
        int n = points.Count;
        if (n < 2) return "";

        var sb = new StringBuilder();
        sb.Append($"M {F(points[0].X)} {F(points[0].Y)}");

        if (n == 2)
        {
            sb.Append($" L {F(points[1].X)} {F(points[1].Y)}");
            if (closed) sb.Append(" Z");
            return sb.ToString();
        }

        double tensionFactor = 1.0 - tension;
        if (tensionFactor < 0.0) tensionFactor = 0.0;
        int segmentCount = closed ? n : n - 1;

        for (int i = 0; i < segmentCount; i++)
        {
            int p0, p1, p2, p3;

            if (closed)
            {
                p0 = (i - 1 + n) % n;
                p1 = i;
                p2 = (i + 1) % n;
                p3 = (i + 2) % n;
            }
            else
            {
                p0 = System.Math.Max(i - 1, 0);
                p1 = i;
                p2 = i + 1;
                p3 = System.Math.Min(i + 2, n - 1);
            }

            var ci1x = tensionFactor * 0.5 * (points[p2].X - points[p0].X);
            var ci1y = tensionFactor * 0.5 * (points[p2].Y - points[p0].Y);
            var ci2x = tensionFactor * 0.5 * (points[p3].X - points[p1].X);
            var ci2y = tensionFactor * 0.5 * (points[p3].Y - points[p1].Y);

            var c1x = F(points[p1].X + ci1x / 3);
            var c1y = F(points[p1].Y + ci1y / 3);
            var c2x = F(points[p2].X - ci2x / 3);
            var c2y = F(points[p2].Y - ci2y / 3);
            var ex = F(points[p2].X);
            var ey = F(points[p2].Y);

            sb.Append($" C {c1x} {c1y} {c2x} {c2y} {ex} {ey}");
        }

        if (closed) sb.Append(" Z");
        return sb.ToString();
    }

    static string F(double v) => v.ToString("G", CultureInfo.InvariantCulture);

    static string EscapeXml(string s) => s.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;");

    static string SanitizeName(string name)
    {
        var invalid = Path.GetInvalidFileNameChars();
        var result = name;
        foreach (var c in invalid)
            result = result.Replace(c, '_');
        return result;
    }

    static JObject ExportObj(BodyTemplate BodyTemplate)
    {
        var keys = BodyTemplate.Difss.Keys.Cast<string>().ToList();
        var result = new JObject
        {
            ["Tag"] = BodyTemplate.Tag ?? "",
            ["KeyCount"] = keys.Count,
            ["Keys"] = JArray.FromObject(keys),
            ["Difss"] = new JObject()
        };

        foreach (var key in keys)
        {
            result["Difss"][key] = ExportDifs(BodyTemplate.Difss[key]);
        }

        return result;
    }

    static JObject ExportDifs(VariantGrid VariantGrid)
    {
        int xCount = VariantGrid.GetCountX();
        int yCount = VariantGrid.GetCountY();

        var result = new JObject
        {
            ["Tag"] = VariantGrid.Tag ?? "",
            ["ValueX"] = VariantGrid.ValueX,
            ["ValueY"] = VariantGrid.ValueY,
            ["GetCountX()"] = xCount,
            ["CountY"] = yCount,
            ["VariantGrid"] = new JArray()
        };

        for (int x = 0; x < xCount; x++)
        {
            var dif = VariantGrid[x];
            var difArr = new JArray();

            for (int y = 0; y < dif.Count; y++)
            {
                difArr.Add(ExportPars(dif[y]));
            }

            ((JArray)result["VariantGrid"]).Add(difArr);
        }

        return result;
    }

    static JObject ExportPars(PartGroup PartGroup)
    {
        var result = new JObject
        {
            ["Tag"] = PartGroup.Tag ?? "",
            ["Children"] = new JObject()
        };

        foreach (string key in PartGroup.pars.Keys)
        {
            var val = PartGroup[key];
            if (val is PartGroup childPars)
                result["Children"][key] = ExportPars(childPars);
            else if (val is ShapePartT parT)
                result["Children"][key] = ExportParT(parT);
            else if (val is ShapePart par)
                result["Children"][key] = ExportPar(par);
            else
                result["Children"][key] = val?.ToString() ?? "null";
        }

        return result;
    }

    static JObject ExportPar(ShapePart ShapePart)
    {
        var result = new JObject
        {
            ["Tag"] = ShapePart.Tag ?? "",
            ["Dra"] = ShapePart.Dra,
            ["PenWidth"] = ShapePart.GetPenWidth(),
            ["Closed"] = ShapePart.IsClosed,
            ["BasePoint"] = ExportVec(ShapePart.GetBasePoint()),
            ["Position"] = ExportVec(ShapePart.GetPosition()),
            ["Angle"] = ShapePart.GetAngle(),
            ["Size"] = ShapePart.GetSize(),
            ["SizeX"] = ShapePart.GetSizeX(),
            ["SizeY"] = ShapePart.GetSizeY(),
            ["CurveOutline"] = new JArray()
        };

        foreach (var outObj in ShapePart.GetOP())
        {
            var outJ = new JObject
            {
                ["Tension"] = outObj.Tension,
                ["Outline"] = outObj.Outline,
                ["Points"] = new JArray()
            };
            foreach (var pt in outObj.ps)
                ((JArray)outJ["Points"]).Add(ExportVec(pt));
            ((JArray)result["CurveOutline"]).Add(outJ);
        }

        if (ShapePart.GetJP().Count > 0)
        {
            result["Joints"] = new JArray();
            foreach (var joi in ShapePart.GetJP())
                ((JArray)result["Joints"]).Add(ExportVec(joi.Joint));
        }

        return result;
    }

    static JObject ExportParT(ShapePartT ShapePartT)
    {
        var result = ExportPar(ShapePartT);
        result["Text"] = ShapePartT.Text ?? "";
        result["FontSize"] = ShapePartT.GetFontSize();
        return result;
    }

    static JObject ExportVec(Vector2D v) => new JObject { ["X"] = v.X, ["Y"] = v.Y };
}