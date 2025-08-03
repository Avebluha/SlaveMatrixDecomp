using System;
using System.Globalization;

namespace _2DGAMELIB
{
    [Serializable]
    public struct Vector2D
    {
    	public double X;

    	public double Y;

    	public double this[int index]
    	{
    		get
    		{
    			return index switch
    			{
    				0 => X, 
    				1 => Y, 
    				_ => throw new ArgumentOutOfRangeException("index", "Indices for Vector2D run from 0 to 1, inclusive."), 
    			};
    		}
    		set
    		{
    			switch (index)
    			{
    			case 0:
    				X = value;
    				break;
    			case 1:
    				Y = value;
    				break;
    			default:
    				throw new ArgumentOutOfRangeException("index", "Indices for Vector2D run from 0 to 1, inclusive.");
    			}
    		}
    	}

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

    	public double Length()
    	{
    		return System.Math.Sqrt(X * X + Y * Y);
    	}

    	public double LengthSquared()
    	{
    		return X * X + Y * Y;
    	}

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
