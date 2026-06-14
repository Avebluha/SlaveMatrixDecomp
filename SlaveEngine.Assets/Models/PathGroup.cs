namespace SlaveEngine.Assets.Models;

public sealed class PathGroup {
    public required string Name { get; init; }
    public bool HasTransform { get; init; }
    public float Tx { get; init; }
    public float Ty { get; init; }
    public float Angle { get; init; }
    public float Sx { get; init; }
    public float Sy { get; init; }
    public float Bx { get; init; }
    public float By { get; init; }
    public required PathData[] Paths { get; init; }
}
