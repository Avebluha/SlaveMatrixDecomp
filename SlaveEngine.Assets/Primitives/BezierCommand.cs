namespace SlaveEngine.Assets.Primitives;

public readonly struct BezierCommand {
    public CommandType Type { get; init; }
    public float[] Args { get; init; }
}
