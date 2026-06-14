namespace SlaveEngine.Assets.Models;

public sealed class VariantAsset {
    public int X { get; init; }
    public int Y { get; init; }
    public required PathGroup[] Groups { get; init; }
}
