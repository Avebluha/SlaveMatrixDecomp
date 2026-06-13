using _2DGAMELIB;
using SlaveMatrix.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SlaveMatrix.Extract;

class Program
{
    static readonly string OutputDir = Path.Combine(Directory.GetCurrentDirectory(), "extracted");

    static void Main(string[] args)
    {
        Console.WriteLine("SlaveMatrix Resource Extractor");
        Console.WriteLine("=================================\n");

        Directory.CreateDirectory(OutputDir);

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

            var objDir = Path.Combine(OutputDir, name);
            Directory.CreateDirectory(objDir);

            Console.Write("  Exporting to JSON... ");
            try
            {
                var jobj = ExportObj(obj);
                var json = JsonConvert.SerializeObject(jobj, Formatting.Indented);
                File.WriteAllText(Path.Combine(objDir, $"{name}.json"), json);
                Console.WriteLine($"OK ({json.Length / 1024}KB)");
            }
            catch (Exception ex) { Console.WriteLine($"FAILED: {ex.Message}"); }

            Console.Write("  Validating... ");
            var keyCount = obj.Difss.Keys.Cast<string>().Count();
            File.WriteAllLines(Path.Combine(objDir, $"{name}_keys.txt"), obj.Difss.Keys.Cast<string>());
            Console.WriteLine($"OK ({keyCount} keys)");
        }

        Console.WriteLine("\nExtraction complete.");
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