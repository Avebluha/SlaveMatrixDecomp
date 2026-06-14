using SlaveEngine.Assets.Primitives;

namespace SlaveEngine.Assets.Models;

public sealed class PathData {
    public required string Fill { get; init; }
    public required string Stroke { get; init; }
    public float StrokeWidth { get; init; }
    public bool IsClosed { get; init; }
    public required BezierCommand[] Commands { get; init; }
}
