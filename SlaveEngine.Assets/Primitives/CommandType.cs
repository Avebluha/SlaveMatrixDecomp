namespace SlaveEngine.Assets.Primitives;

public enum CommandType : byte {
    MoveTo = 0,
    LineTo = 1,
    CubicBezierTo = 2,
    Close = 3
}
