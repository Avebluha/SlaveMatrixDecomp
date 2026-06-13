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

        foreach (var (name, data) in resources)
        {
            Console.Write($"Loading {name}... ");
            Obj? obj;
            try
            {
                obj = data.ObjLoadRaw();
                if (obj == null) { Console.WriteLine("FAILED: null"); continue; }
                Console.WriteLine($"OK ({obj.Difss.Count} keys)");
            }
            catch (Exception ex) { Console.WriteLine($"FAILED: {ex.Message}"); continue; }

            Console.Write("  Applying MigrateKeys... ");
            obj.MigrateKeys();
            Console.WriteLine("OK");

            var jsonObj = ExportObj(obj);
            var jsonPath = Path.Combine(jsonDir, $"{name}.json");
            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(jsonObj, Formatting.Indented));

            var keys = obj.Difss.Keys.Cast<string>().ToList();

            foreach (var key in keys)
            {
                var difs = obj.Difss[key];
                var partDir = Path.Combine(partsDir, SanitizeName(key));
                Directory.CreateDirectory(partDir);

                var foundJoints = new List<string>();
                var originalTag = jsonObj["Difss"]?[key]?["Tag"]?.ToString() ?? key;

                var partEntry = new JObject
                {
                    ["id"] = key,
                    ["original_key"] = originalTag,
                    ["resource"] = name,
                    ["morph_x"] = difs.CountX,
                    ["morph_y"] = difs.CountY,
                    ["variants"] = new JArray(),
                    ["fields"] = new JArray()
                };

                var variants = (JArray)partEntry["variants"];

                for (int x = 0; x < difs.CountX; x++)
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

                foreach (string childKey in difs[0][0].Keys)
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
                    ["id"] = key,
                    ["path"] = $"Parts/{SanitizeName(key)}/"
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

    static string ExportParsToSvg(Pars pars, List<string> foundJoints)
    {
        var sb = new StringBuilder();
        sb.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
        sb.AppendLine("<svg xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 1 1\">");
        ExportParsToSvgInner(pars, sb, foundJoints);
        sb.AppendLine("</svg>");
        return sb.ToString();
    }

    static void ExportParsToSvgInner(Pars pars, StringBuilder sb, List<string> foundJoints)
    {
        foreach (string key in pars.Keys)
        {
            var val = pars[key];
            if (val is Pars childPars)
            {
                sb.AppendLine($"<g id=\"{EscapeXml(key)}\">");
                ExportParsToSvgInner(childPars, sb, foundJoints);
                sb.AppendLine("</g>");
            }
            else if (val is Par par)
            {
                ExportParToSvg(par, key, sb, foundJoints);
            }
        }
    }

    static void ExportParToSvg(Par par, string name, StringBuilder sb, List<string> foundJoints)
    {
        if (!par.Dra) return;

        var bx = par.BasePoint.X;
        var by = par.BasePoint.Y;
        var px = par.Position.X;
        var py = par.Position.Y;
        var angle = par.Angle;
        var sx = par.Size * par.SizeX;
        var sy = par.Size * par.SizeY;

        var hasTransform = System.Math.Abs(bx) > 0.001 || System.Math.Abs(by) > 0.001
            || System.Math.Abs(px) > 0.001 || System.Math.Abs(py) > 0.001
            || System.Math.Abs(angle) > 0.001 || System.Math.Abs(sx - 1) > 0.001 || System.Math.Abs(sy - 1) > 0.001;

        if (hasTransform)
            sb.Append($"<g transform=\"translate({F(px)},{F(py)}) rotate({F(angle)}) scale({F(sx)},{F(sy)}) translate({F(-bx)},{F(-by)})\">");

        foreach (var outObj in par.OP)
        {
            var points = outObj.ps;
            if (points.Count < 2) continue;

            var d = BuildSvgPath(points, outObj.Tension, par.Closed);
            var fill = par.Closed ? "#cccccc" : "none";
            var stroke = outObj.Outline ? "#000000" : "none";
            var sw_val = outObj.Outline ? System.Math.Max(par.PenWidth, 0.001) : 0.0;
            sb.AppendLine($"<path d=\"{d}\" fill=\"{fill}\" stroke=\"{stroke}\" stroke-width=\"{F(sw_val)}\"/>");
        }

        if (hasTransform)
            sb.Append("</g>");

        foreach (var joi in par.JP)
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
            var c2x = F(points[p2].X + ci2x / 3);
            var c2y = F(points[p2].Y + ci2y / 3);
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

    static JObject ExportObj(Obj obj)
    {
        var keys = obj.Difss.Keys.Cast<string>().ToList();
        var result = new JObject
        {
            ["Tag"] = obj.Tag ?? "",
            ["KeyCount"] = keys.Count,
            ["Keys"] = JArray.FromObject(keys),
            ["Difss"] = new JObject()
        };

        foreach (var key in keys)
        {
            result["Difss"][key] = ExportDifs(obj.Difss[key]);
        }

        return result;
    }

    static JObject ExportDifs(Difs difs)
    {
        int xCount = difs.CountX;
        int yCount = difs.CountY;

        var result = new JObject
        {
            ["Tag"] = difs.Tag ?? "",
            ["ValueX"] = difs.ValueX,
            ["ValueY"] = difs.ValueY,
            ["CountX"] = xCount,
            ["CountY"] = yCount,
            ["Difs"] = new JArray()
        };

        for (int x = 0; x < xCount; x++)
        {
            var dif = difs[x];
            var difArr = new JArray();

            for (int y = 0; y < dif.Count; y++)
            {
                difArr.Add(ExportPars(dif[y]));
            }

            ((JArray)result["Difs"]).Add(difArr);
        }

        return result;
    }

    static JObject ExportPars(Pars pars)
    {
        var result = new JObject
        {
            ["Tag"] = pars.Tag ?? "",
            ["Children"] = new JObject()
        };

        foreach (string key in pars.Keys)
        {
            var val = pars[key];
            if (val is Pars childPars)
                result["Children"][key] = ExportPars(childPars);
            else if (val is ParT parT)
                result["Children"][key] = ExportParT(parT);
            else if (val is Par par)
                result["Children"][key] = ExportPar(par);
            else
                result["Children"][key] = val?.ToString() ?? "null";
        }

        return result;
    }

    static JObject ExportPar(Par par)
    {
        var result = new JObject
        {
            ["Tag"] = par.Tag ?? "",
            ["Dra"] = par.Dra,
            ["PenWidth"] = par.PenWidth,
            ["Closed"] = par.Closed,
            ["BasePoint"] = ExportVec(par.BasePoint),
            ["Position"] = ExportVec(par.Position),
            ["Angle"] = par.Angle,
            ["Size"] = par.Size,
            ["SizeX"] = par.SizeX,
            ["SizeY"] = par.SizeY,
            ["Out"] = new JArray()
        };

        foreach (var outObj in par.OP)
        {
            var outJ = new JObject
            {
                ["Tension"] = outObj.Tension,
                ["Outline"] = outObj.Outline,
                ["Points"] = new JArray()
            };
            foreach (var pt in outObj.ps)
                ((JArray)outJ["Points"]).Add(ExportVec(pt));
            ((JArray)result["Out"]).Add(outJ);
        }

        if (par.JP.Count > 0)
        {
            result["Joints"] = new JArray();
            foreach (var joi in par.JP)
                ((JArray)result["Joints"]).Add(ExportVec(joi.Joint));
        }

        return result;
    }

    static JObject ExportParT(ParT parT)
    {
        var result = ExportPar(parT);
        result["Text"] = parT.Text ?? "";
        result["FontSize"] = parT.FontSize;
        return result;
    }

    static JObject ExportVec(Vector2D v) => new JObject { ["X"] = v.X, ["Y"] = v.Y };
}