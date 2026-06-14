using System.Globalization;
using System.Xml.Linq;
using SlaveEngine.Assets.Models;
using SlaveEngine.Assets.Primitives;

namespace SlaveEngine.AssetBuilder;

public static class SvgParser {
    private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

    public static PathGroup[] Parse(string svgPath) {
        var doc = XDocument.Load(svgPath);
        var svg = doc.Root;
        if (svg == null) return Array.Empty<PathGroup>();

        var groups = new List<PathGroup>();
        CollectGroups(svg, groups, null);
        return groups.ToArray();
    }

    private static void CollectGroups(XElement parent, List<PathGroup> groups, string? inheritedName) {
        foreach (var child in parent.Elements()) {
            var name = child.Name.LocalName;
            if (name != "g" && name != "path") continue;
            var id = child.Attribute("id")?.Value ?? inheritedName ?? "";

            if (name == "g") {
                var transformAttr = child.Attribute("transform")?.Value;

                if (transformAttr != null) {
                    ParseTransform(transformAttr,
                        out var tx, out var ty, out var angle,
                        out var sx, out var sy, out var bx, out var by);

                    var paths = CollectPaths(child);
                    groups.Add(new PathGroup {
                        Name = id,
                        HasTransform = true,
                        Tx = tx, Ty = ty, Angle = angle,
                        Sx = sx, Sy = sy, Bx = bx, By = by,
                        Paths = paths
                    });
                } else {
                    CollectGroups(child, groups, id);
                }
            }
        }
    }

    private static PathData[] CollectPaths(XElement parent) {
        var paths = new List<PathData>();
        foreach (var elem in parent.Elements()) {
            var name = elem.Name.LocalName;
            if (name == "path") {
                var d = elem.Attribute("d")?.Value ?? "";
                var (commands, isClosed) = ParsePathData(d);
                paths.Add(new PathData {
                    Fill = elem.Attribute("fill")?.Value ?? "none",
                    Stroke = elem.Attribute("stroke")?.Value ?? "none",
                    StrokeWidth = float.Parse(
                        elem.Attribute("stroke-width")?.Value ?? "0", Inv),
                    IsClosed = isClosed,
                    Commands = commands
                });
            } else if (name == "g") {
                paths.AddRange(CollectPaths(elem));
            }
        }
        return paths.ToArray();
    }

    private static void ParseTransform(string t,
        out float tx, out float ty, out float angle,
        out float sx, out float sy, out float bx, out float by) {
        tx = ty = angle = 0;
        sx = sy = 1;
        bx = by = 0;

        if (string.IsNullOrWhiteSpace(t)) return;

        var parts = t.Split(')', StringSplitOptions.RemoveEmptyEntries);
        bool firstTranslate = true;

        foreach (var part in parts) {
            var trimmed = part.TrimStart();
            if (trimmed.StartsWith("translate(")) {
                var args = trimmed["translate(".Length..].Split(',');
                if (args.Length >= 2) {
                    float x = float.Parse(args[0].Trim(), Inv);
                    float y = float.Parse(args[1].Trim(), Inv);
                    if (firstTranslate) {
                        tx = x; ty = y;
                        firstTranslate = false;
                    } else {
                        bx = x; by = y;
                    }
                }
            } else if (trimmed.StartsWith("rotate(")) {
                var arg = trimmed["rotate(".Length..].Trim();
                angle = float.Parse(arg, Inv);
            } else if (trimmed.StartsWith("scale(")) {
                var args = trimmed["scale(".Length..].Split(',');
                if (args.Length >= 2) {
                    sx = float.Parse(args[0].Trim(), Inv);
                    sy = float.Parse(args[1].Trim(), Inv);
                }
            }
        }
    }

    internal static (BezierCommand[] commands, bool isClosed) ParsePathData(string d) {
        var commands = new List<BezierCommand>();
        var tokens = Tokenize(d);
        var i = 0;
        float cx = 0, cy = 0;

        while (i < tokens.Count) {
            var cmd = tokens[i][0];
            i++;

            switch (cmd) {
                case 'M': case 'm': {
                    var x = float.Parse(tokens[i++], Inv);
                    var y = float.Parse(tokens[i++], Inv);
                    if (cmd == 'm') { x += cx; y += cy; }
                    commands.Add(new BezierCommand { Type = CommandType.MoveTo, Args = new[] { x, y } });
                    cx = x; cy = y;
                    break;
                }
                case 'L': case 'l': {
                    var x = float.Parse(tokens[i++], Inv);
                    var y = float.Parse(tokens[i++], Inv);
                    if (cmd == 'l') { x += cx; y += cy; }
                    commands.Add(new BezierCommand { Type = CommandType.LineTo, Args = new[] { x, y } });
                    cx = x; cy = y;
                    break;
                }
                case 'C': case 'c': {
                    var c1x = float.Parse(tokens[i++], Inv);
                    var c1y = float.Parse(tokens[i++], Inv);
                    var c2x = float.Parse(tokens[i++], Inv);
                    var c2y = float.Parse(tokens[i++], Inv);
                    var ex = float.Parse(tokens[i++], Inv);
                    var ey = float.Parse(tokens[i++], Inv);
                    if (cmd == 'c') {
                        c1x += cx; c1y += cy;
                        c2x += cx; c2y += cy;
                        ex += cx; ey += cy;
                    }
                    commands.Add(new BezierCommand {
                        Type = CommandType.CubicBezierTo,
                        Args = new[] { c1x, c1y, c2x, c2y, ex, ey }
                    });
                    cx = ex; cy = ey;
                    break;
                }
                case 'Z': case 'z': {
                    commands.Add(new BezierCommand { Type = CommandType.Close, Args = Array.Empty<float>() });
                    break;
                }
            }
        }

        var closed = commands.Count > 0 && commands[^1].Type == CommandType.Close;
        return (commands.ToArray(), closed);
    }

    private static List<string> Tokenize(string d) {
        var tokens = new List<string>();
        var i = 0;
        while (i < d.Length) {
            var c = d[i];
            if (char.IsWhiteSpace(c) || c == ',') { i++; continue; }
            if (char.IsLetter(c)) {
                var upper = char.ToUpperInvariant(c);
                if (upper is 'M' or 'L' or 'C' or 'Z') {
                    tokens.Add(c.ToString());
                    i++;
                    continue;
                }
                i++;
                continue;
            }
            if (c is '-' or '+' or '.' || char.IsDigit(c)) {
                var start = i;
                if (c is '-' or '+') i++;
                while (i < d.Length && (char.IsDigit(d[i]) || d[i] == '.')) i++;
                if (i < d.Length && (d[i] is 'e' or 'E')) {
                    i++;
                    if (i < d.Length && (d[i] is '+' or '-')) i++;
                    while (i < d.Length && char.IsDigit(d[i])) i++;
                }
                tokens.Add(d[start..i]);
                continue;
            }
            i++;
        }
        return tokens;
    }
}
