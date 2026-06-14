using System.Text;
using SlaveEngine.Assets;
using SlaveEngine.Assets.Models;
using SlaveEngine.Assets.Primitives;

namespace SlaveEngine.AssetBuilder;

public static class SparWriter {
    public static void Write(PartAsset asset, string outputPath) {
        using var stream = File.Create(outputPath);
        using var writer = new BinaryWriter(stream);

        writer.Write(Encoding.UTF8.GetBytes("SPRT"));
        writer.Write(1); // version

        WriteString(writer, asset.Id);
        WriteString(writer, asset.OriginalKey);
        WriteString(writer, asset.Resource);
        writer.Write(asset.MorphX);
        writer.Write(asset.MorphY);

        writer.Write(asset.Fields.Length);
        foreach (var f in asset.Fields) WriteString(writer, f);

        writer.Write(asset.Joints.Length);
        foreach (var j in asset.Joints) {
            writer.Write(j.X);
            writer.Write(j.Y);
        }

        writer.Write(asset.Variants.Length);
        foreach (var variant in asset.Variants) {
            writer.Write(variant.X);
            writer.Write(variant.Y);

            writer.Write(variant.Groups.Length);
            foreach (var group in variant.Groups) {
                WriteString(writer, group.Name);
                writer.Write(group.HasTransform);
                if (group.HasTransform) {
                    writer.Write(group.Tx);
                    writer.Write(group.Ty);
                    writer.Write(group.Angle);
                    writer.Write(group.Sx);
                    writer.Write(group.Sy);
                    writer.Write(group.Bx);
                    writer.Write(group.By);
                }

                writer.Write(group.Paths.Length);
                foreach (var path in group.Paths) {
                    WriteString(writer, path.Fill);
                    WriteString(writer, path.Stroke);
                    writer.Write(path.StrokeWidth);
                    writer.Write(path.IsClosed);

                    writer.Write(path.Commands.Length);
                    foreach (var cmd in path.Commands) {
                        writer.Write((byte)cmd.Type);
                        writer.Write(cmd.Args.Length);
                        foreach (var arg in cmd.Args) writer.Write(arg);
                    }
                }
            }
        }
    }

    private static void WriteString(BinaryWriter writer, string s) {
        var bytes = Encoding.UTF8.GetBytes(s);
        writer.Write(bytes.Length);
        writer.Write(bytes);
    }
}
