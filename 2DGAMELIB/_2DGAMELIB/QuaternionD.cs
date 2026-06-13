using System;
using System.Globalization;

namespace _2DGAMELIB
{
    public static class Quaternion
    {
        public static QuaternionD RotationZQ(this double angle)
        {
            double num = angle * 0.5;
            QuaternionD result = default(QuaternionD);
            result.X = 0.0;
            result.Y = 0.0;
            result.Z = System.Math.Sin(num);
            result.W = System.Math.Cos(num);
            return result;
        }

        public static void TransformCoordinate(ref Vector2D coord, ref QuaternionD rotation, out Vector2D result)
        {
            double num = rotation.Y + rotation.Y;
            double num2 = rotation.Z + rotation.Z;
            double num3 = rotation.W * num2;
            double num4 = rotation.X * num;
            double num5 = rotation.Z * num2;
            result.X = coord.X * (1.0 - rotation.Y * num - num5) + coord.Y * (num4 - num3);
            result.Y = coord.X * (num4 + num3) + coord.Y * (1.0 - rotation.X * (rotation.X + rotation.X) - num5);
        }

        public static Vector2D TransformCoordinateBP(this Vector2D coord, Vector2D BasePoint, QuaternionD rotation)
        {
            VectorMath.Subtract(ref coord, ref BasePoint, out coord);
            TransformCoordinate(ref coord, ref rotation, out var result);
            VectorMath.Add(ref result, ref BasePoint, out result);
            return result;
        }
    }
    
    //used in a total of 1 places
    [Serializable]
    public struct QuaternionD
    {
    	public double X;

    	public double Y;

    	public double Z;

    	public double W;
    }
}
