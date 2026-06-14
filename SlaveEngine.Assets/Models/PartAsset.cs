using SlaveEngine.Assets.Primitives;

namespace SlaveEngine.Assets.Models;

public sealed class PartAsset : Asset {
    public required string Id { get; init; }
    public required string OriginalKey { get; init; }
    public required string Resource { get; init; }
    public int MorphX { get; init; }
    public int MorphY { get; init; }
    public required string[] Fields { get; init; }
    public required Joint[] Joints { get; init; }
    public required VariantAsset[] Variants { get; init; }
}
