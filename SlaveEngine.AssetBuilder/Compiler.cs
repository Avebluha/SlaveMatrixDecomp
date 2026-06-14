using System.Text.RegularExpressions;
using SlaveEngine.AssetBuilder.Models;
using SlaveEngine.Assets;
using SlaveEngine.Assets.Models;
using SlaveEngine.Assets.Primitives;
using Spectre.Console;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace SlaveEngine.AssetBuilder;

public class Compiler {
    private readonly string _inputDir;
    private readonly string _outputDir;
    private readonly IDeserializer _yaml;

    public Compiler(string inputDir, string outputDir) {
        _inputDir = inputDir;
        _outputDir = outputDir;

        _yaml = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .IgnoreUnmatchedProperties()
            .Build();
    }

    private T LoadYaml<T>(string path) {
        var text = File.ReadAllText(path);
        text = NormalizeFlowArrays(text);
        return _yaml.Deserialize<T>(text);
    }

    private static string NormalizeFlowArrays(string yaml) {
        return Regex.Replace(yaml,
            @"(position:\s*)\[([\s\S]*?)\]",
            m => {
                var prefix = m.Groups[1].Value.TrimEnd();
                var values = m.Groups[2].Value
                    .Replace('\n', ' ')
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(v => v.Trim())
                    .Where(v => v.Length > 0)
                    .ToList();
                if (values.Count == 0) return prefix + " []";
                return prefix + "\n" +
                       string.Join("\n", values.Select(v => $"  - {v}"));
            });
    }

    public int Run() {
        AnsiConsole.Write(new Rule("[yellow]SlaveEngine Asset Builder[/]") { Justification = Justify.Left });
        AnsiConsole.MarkupLine("  [bold]Input:[/]  {0}", _inputDir);
        AnsiConsole.MarkupLine("  [bold]Output:[/] {0}", _outputDir);
        AnsiConsole.WriteLine();

        Directory.CreateDirectory(_outputDir);

        var parts = DiscoverParts();
        if (parts.Count == 0) {
            AnsiConsole.MarkupLine("[red]No parts found.[/]");
            return 1;
        }

        var success = 0;

        AnsiConsole.Progress()
            .Columns(new TaskDescriptionColumn(), new ProgressBarColumn(), new PercentageColumn(), new ElapsedTimeColumn())
            .Start(ctx => {
                var task = ctx.AddTask("Compiling parts");
                task.MaxValue = parts.Count;

                foreach (var (id, partDir) in parts) {
                    var (ok, msg) = CompilePart(partDir);
                    if (ok)
                        AnsiConsole.MarkupLine("[green]{0}[/]", msg);
                    else
                        AnsiConsole.MarkupLine("[red]{0}[/]", msg);
                    if (ok) success++;
                    task.Increment(1);
                }
            });

        if (success == parts.Count)
            AnsiConsole.MarkupLine("[green]Done. {0}/{1} compiled.[/]", success, parts.Count);
        else if (success > 0)
            AnsiConsole.MarkupLine("[yellow]Done. {0}/{1} compiled.[/]", success, parts.Count);
        else
            AnsiConsole.MarkupLine("[red]Done. {0}/{1} compiled.[/]", success, parts.Count);

        return success == parts.Count ? 0 : 1;
    }

    private List<(string id, string dir)> DiscoverParts() {
        var parts = new List<(string id, string dir)>();

        var catalogPath = Path.Combine(_inputDir, "Catalog.yaml");
        if (File.Exists(catalogPath)) {
            AnsiConsole.MarkupLine("[dim]Using catalog:[/] {0}", catalogPath);
            var catalog = LoadYaml<CatalogYaml>(catalogPath);
            if (catalog?.Parts != null) {
                foreach (var entry in catalog.Parts) {
                    var partDir = Path.GetFullPath(Path.Combine(_inputDir, entry.Path));
                    if (Directory.Exists(partDir))
                        parts.Add((entry.Id, partDir));
                    else
                        AnsiConsole.MarkupLine("[yellow]  Warning:[/] directory not found: {0}", partDir);
                }
                return parts;
            }
        }

        var scanDir = Path.Combine(_inputDir, "Parts");
        if (!Directory.Exists(scanDir)) return parts;

        AnsiConsole.MarkupLine("[dim]Scanning:[/] {0}", scanDir);
        foreach (var dir in Directory.GetDirectories(scanDir)) {
            var yamlPath = Path.Combine(dir, "part.yaml");
            if (!File.Exists(yamlPath)) continue;
            try {
                var partYaml = LoadYaml<PartYaml>(yamlPath);
                if (partYaml != null && !string.IsNullOrEmpty(partYaml.Id))
                    parts.Add((partYaml.Id, dir));
            } catch (Exception ex) {
                AnsiConsole.MarkupLine("[yellow]  Warning:[/] failed to parse {0}: {1}", yamlPath, ex.Message);
            }
        }

        return parts;
    }

    private (bool success, string message) CompilePart(string partDir) {
        var yamlPath = Path.Combine(partDir, "part.yaml");
        if (!File.Exists(yamlPath))
            return (false, $"Skipping (no part.yaml): {partDir}");

        PartYaml partYaml;
        try {
            partYaml = LoadYaml<PartYaml>(yamlPath);
        } catch (Exception ex) {
            return (false, $"Failed to parse {yamlPath}: {ex.Message}");
        }

        if (partYaml == null)
            return (false, $"Empty YAML: {yamlPath}");

        try {
            var variantList = partYaml.Variants ?? new List<VariantYaml>();
            var variants = new VariantAsset[variantList.Count];
            for (var i = 0; i < variantList.Count; i++) {
                var v = variantList[i];
                var svgPath = Path.Combine(partDir, v.File);
                if (!File.Exists(svgPath)) {
                    variants[i] = new VariantAsset { X = v.X, Y = v.Y, Groups = Array.Empty<PathGroup>() };
                    continue;
                }
                var groups = SvgParser.Parse(svgPath);
                variants[i] = new VariantAsset { X = v.X, Y = v.Y, Groups = groups };
            }

            var fieldList = partYaml.Fields ?? new List<FieldYaml>();
            var jointList = partYaml.Joints ?? new List<JointYaml>();

            var asset = new PartAsset {
                Guid = Guid.NewGuid(),
                FileInfo = new AssetFileInfo { Filename = partYaml.Id, FilePath = "" },
                Id = partYaml.Id,
                OriginalKey = partYaml.OriginalKey ?? "",
                Resource = partYaml.Resource ?? "",
                MorphX = partYaml.MorphX,
                MorphY = partYaml.MorphY,
                Fields = fieldList.Select(f => f.Name ?? "").ToArray(),
                Joints = jointList.Select(j => new Joint {
                    X = j.Position != null && j.Position.Count > 0 ? j.Position[0] : 0,
                    Y = j.Position != null && j.Position.Count > 1 ? j.Position[1] : 0
                }).ToArray(),
                Variants = variants
            };

            var outputPath = Path.Combine(_outputDir, $"{partYaml.Id}.spart");
            SparWriter.Write(asset, outputPath);

            return (true, $"  {partYaml.Id}... OK ({variants.Length} variants)");
        } catch (Exception ex) {
            return (false, $"  {partYaml.Id}... FAILED: {ex.Message}");
        }
    }
}
