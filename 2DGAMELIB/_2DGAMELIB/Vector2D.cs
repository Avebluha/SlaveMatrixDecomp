using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace _2DGAMELIB
{
    [Serializable]
    public struct Vector2D
    {
    	public double X;

    	public double Y;

    	public Vector2D(int x, int y)
    	{
    		X = x;
    		Y = y;
    	}

    	public Vector2D(double x, double y)
    	{
    		X = x;
    		Y = y;
    	}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
    	public double Length()
    	{
    		return System.Math.Sqrt(X * X + Y * Y);
    	}
	    
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
    	public double LengthSquared()
    	{
    		return X * X + Y * Y;
    	}
	    
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
    	public void Normalize()
    	{
    		double num = Length();
    		if (num != 0.0)
    		{
    			double num2 = 1.0 / num;
    			X *= num2;
    			Y *= num2;
    		}
    	}

		public static Vector2D Normalize(Vector2D vec){
			double num = vec.Length();
    		if (num != 0.0)
    		{
    			double num2 = 1.0 / num;
    			return vec * num2;
    		}

			return DataConsts.Vec2DZero;
		}

    	public static Vector2D operator +(Vector2D left, Vector2D right)
    	{
    		return new Vector2D(left.X + right.X, left.Y + right.Y);
    	}

    	public static Vector2D operator -(Vector2D left, Vector2D right)
    	{
    		return new Vector2D(left.X - right.X, left.Y - right.Y);
    	}

    	public static Vector2D operator -(Vector2D value)
    	{
    		return new Vector2D(0.0 - value.X, 0.0 - value.Y);
    	}

    	public static Vector2D operator *(Vector2D value, double scale)
    	{
    		return new Vector2D(value.X * scale, value.Y * scale);
    	}

    	public static Vector2D operator *(double scale, Vector2D value)
    	{
    		return new Vector2D(value.X * scale, value.Y * scale);
    	}

    	public static Vector2D operator /(Vector2D value, double scale)
    	{
    		return new Vector2D(value.X / scale, value.Y / scale);
    	}
    }
}
