using System.Text;
using SlaveEngine.Assets.Models;
using SlaveEngine.Assets.Primitives;

namespace SlaveEngine.Assets.Processors;

[AssetProcessor(typeof(PartAsset), managedExtensions: [".spart"])]
public sealed class PartProcessor : AssetProcessor {
    public override Asset Process(AssetFileInfo fileInfo, byte[] data) {
        using var stream = new MemoryStream(data);
        using var reader = new BinaryReader(stream);

        var magic = reader.ReadBytes(4);
        if (magic[0] != 'S' || magic[1] != 'P' || magic[2] != 'R' || magic[3] != 'T')
            throw new InvalidDataException("Invalid .spart file magic");

        var version = reader.ReadInt32();
        if (version != 1)
            throw new InvalidDataException($"Unsupported .spart version: {version}");

        var id = ReadString(reader);
        var originalKey = ReadString(reader);
        var resource = ReadString(reader);
        var morphX = reader.ReadInt32();
        var morphY = reader.ReadInt32();

        var fieldCount = reader.ReadInt32();
        var fields = new string[fieldCount];
        for (var i = 0; i < fieldCount; i++)
            fields[i] = ReadString(reader);

        var jointCount = reader.ReadInt32();
        var joints = new Joint[jointCount];
        for (var i = 0; i < jointCount; i++)
            joints[i] = new Joint { X = reader.ReadSingle(), Y = reader.ReadSingle() };

        var variantCount = reader.ReadInt32();
        var variants = new VariantAsset[variantCount];
        for (var v = 0; v < variantCount; v++) {
            var vx = reader.ReadInt32();
            var vy = reader.ReadInt32();

            var groupCount = reader.ReadInt32();
            var groups = new PathGroup[groupCount];
            for (var g = 0; g < groupCount; g++) {
                var groupName = ReadString(reader);
                var hasTransform = reader.ReadBoolean();
                float tx = 0, ty = 0, angle = 0, sx = 1, sy = 1, bx = 0, by = 0;
                if (hasTransform) {
                    tx = reader.ReadSingle();
                    ty = reader.ReadSingle();
                    angle = reader.ReadSingle();
                    sx = reader.ReadSingle();
                    sy = reader.ReadSingle();
                    bx = reader.ReadSingle();
                    by = reader.ReadSingle();
                }

                var pathCount = reader.ReadInt32();
                var paths = new PathData[pathCount];
                for (var p = 0; p < pathCount; p++) {
                    var fill = ReadString(reader);
                    var stroke = ReadString(reader);
                    var strokeWidth = reader.ReadSingle();
                    var isClosed = reader.ReadBoolean();

                    var cmdCount = reader.ReadInt32();
                    var cmds = new BezierCommand[cmdCount];
                    for (var c = 0; c < cmdCount; c++) {
                        var cmdType = (CommandType)reader.ReadByte();
                        var argCount = reader.ReadInt32();
                        var args = new float[argCount];
                        for (var a = 0; a < argCount; a++)
                            args[a] = reader.ReadSingle();
                        cmds[c] = new BezierCommand { Type = cmdType, Args = args };
                    }

                    paths[p] = new PathData {
                        Fill = fill,
                        Stroke = stroke,
                        StrokeWidth = strokeWidth,
                        IsClosed = isClosed,
                        Commands = cmds
                    };
                }

                groups[g] = new PathGroup {
                    Name = groupName,
                    HasTransform = hasTransform,
                    Tx = tx, Ty = ty, Angle = angle,
                    Sx = sx, Sy = sy, Bx = bx, By = by,
                    Paths = paths
                };
            }

            variants[v] = new VariantAsset {
                X = vx, Y = vy, Groups = groups
            };
        }

        return new PartAsset {
            Guid = Guid.NewGuid(),
            FileInfo = fileInfo,
            Id = id,
            OriginalKey = originalKey,
            Resource = resource,
            MorphX = morphX,
            MorphY = morphY,
            Fields = fields,
            Joints = joints,
            Variants = variants
        };
    }

    private static string ReadString(BinaryReader reader) {
        var len = reader.ReadInt32();
        var bytes = reader.ReadBytes(len);
        return Encoding.UTF8.GetString(bytes);
    }
}
