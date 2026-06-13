using System;
using System.Runtime.CompilerServices;

namespace _2DGAMELIB
{
    public static class VectorMath
    {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
    	public static void Add(ref Vector2D a, ref Vector2D b, out Vector2D result)
    	{
    		result.X = a.X + b.X;
    		result.Y = a.Y + b.Y;
    	}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
    	public static void Subtract(ref Vector2D a, ref Vector2D b, out Vector2D result)
    	{
    		result.X = a.X - b.X;
    		result.Y = a.Y - b.Y;
    	}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
    	public static double DistanceSquared(this Vector2D a, Vector2D b)
    	{
    		double num = a.X - b.X;
    		double num2 = a.Y - b.Y;
    		return num * num + num2 * num2;
    	}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
    	public static void Dot(ref Vector2D a, ref Vector2D b, out double result)
    	{
    		result = a.X * b.X + a.Y * b.Y;
    	}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
    	public static double Cross(ref Vector2D a, ref Vector2D b)
    	{
    		return a.X * b.Y - a.Y * b.X;
    	}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
    	public static Vector2D newNormalize(this Vector2D vector)
    	{
    		vector.Normalize();
    		return vector;
    	}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
    	public static double Angle(ref Vector2D a, ref Vector2D b)
    	{
    		Dot(ref a, ref b, out var r);
    		r /= a.Length() * b.Length();
    		if (r > 1.0)
    		{
    			r = 1.0;
    		}
    		else if (r < -1.0)
    		{
    			r = -1.0;
    		}
    		return System.Math.Acos(r);
    	}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
    	public static double Angle02π(this Vector2D a, Vector2D b)
    	{
    		double num = Angle(ref a, ref b);
    		if (Cross(ref a, ref b) < 0.0)
    		{
    			num = System.Math.PI * 2.0 - num;
    		}
    		return num;
    	}
    }
}
