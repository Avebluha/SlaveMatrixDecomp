using System.Runtime.InteropServices;

namespace _2DGAMELIB
{
    [StructLayout(LayoutKind.Sequential, Size = 1)]
    public struct DataConsts
    {
    	public static MatrixD MatDZero = new MatrixD(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);

    	public static MatrixD MatDIdentity = new MatrixD(1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0);

    	public static Vector2D Vec2DZero = new Vector2D(0.0, 0.0);

    	public static Vector2D Vec2DOne = new Vector2D(1.0, 1.0);

    	public static Vector2D Vec2DUnitX = new Vector2D(1.0, 0.0);

    	public static Vector2D Vec2DUnitY = new Vector2D(0.0, 1.0);
    }
}
