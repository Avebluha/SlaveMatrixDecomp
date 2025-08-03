using System;

namespace _2DGAMELIB
{
    public class MyRandom : Random
    {
    	protected uint x;

    	protected uint y;

    	protected uint z;

    	protected uint w;

    	private const double d_4294967296 = 2.3283064365386963E-10;

    	private const double d_9007199254740992 = 1.1102230246251565E-16;

    	protected uint InitMtSub(uint s, uint i)
    	{
    		return 1812433253 * (s ^ (s >> 30)) + i + 1;
    	}

    	public void Initialize(uint s)
    	{
    		x = InitMtSub(s, 0u);
    		y = InitMtSub(x, 1u);
    		z = InitMtSub(y, 2u);
    		w = InitMtSub(z, 3u);
    	}

    	public MyRandom(uint s)
    	{
    		Initialize(s);
    	}

    	public override int Next()
    	{
    		uint num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		return (int)(0.5 * (double)(w = w ^ (w >> 19) ^ num ^ (num >> 8)));
    	}

    	public override int Next(int les)
    	{
    		uint num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		return (int)((double)les * 2.3283064365386963E-10 * (double)(w = w ^ (w >> 19) ^ num ^ (num >> 8)));
    	}

    	public void Next(int les, out int o)
    	{
    		uint num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		o = (int)((double)les * 2.3283064365386963E-10 * (double)(w = w ^ (w >> 19) ^ num ^ (num >> 8)));
    	}

    	public override int Next(int sta, int les)
    	{
    		uint num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		return (int)((double)(les - sta) * 2.3283064365386963E-10 * (double)(w = w ^ (w >> 19) ^ num ^ (num >> 8))) + sta;
    	}

    	public int NextM(int max)
    	{
    		uint num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		return (int)((double)((long)max + 1L) * 2.3283064365386963E-10 * (double)(w = w ^ (w >> 19) ^ num ^ (num >> 8)));
    	}

    	public int NextM(int min, int max)
    	{
    		uint num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		return (int)((double)((long)(max - min) + 1L) * 2.3283064365386963E-10 * (double)(w = w ^ (w >> 19) ^ num ^ (num >> 8))) + min;
    	}

    	public override double NextDouble()
    	{
    		uint num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		uint num2 = (w = w ^ (w >> 19) ^ num ^ (num >> 8)) >> 11;
    		num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		return 1.1102230246251565E-16 * ((double)(w = w ^ (w >> 19) ^ num ^ (num >> 8)) * 2097152.0 + (double)num2);
    	}

    	public double NextDouble(double les)
    	{
    		uint num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		uint num2 = (w = w ^ (w >> 19) ^ num ^ (num >> 8)) >> 11;
    		num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		return les * 1.1102230246251565E-16 * ((double)(w = w ^ (w >> 19) ^ num ^ (num >> 8)) * 2097152.0 + (double)num2);
    	}

    	public double NextDouble(double sta, double les)
    	{
    		uint num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		uint num2 = (w = w ^ (w >> 19) ^ num ^ (num >> 8)) >> 11;
    		num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		return (les - sta) * 1.1102230246251565E-16 * ((double)(w = w ^ (w >> 19) ^ num ^ (num >> 8)) * 2097152.0 + (double)num2) + sta;
    	}

    	public bool NextBool()
    	{
    		uint num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		return (w = w ^ (w >> 19) ^ num ^ (num >> 8)) % 2 == 0;
    	}

    	public int NextSign()
    	{
    		uint num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		if ((w = w ^ (w >> 19) ^ num ^ (num >> 8)) % 2 != 0)
    		{
    			return -1;
    		}
    		return 1;
    	}

    	public double NextNorCos(double mu = 0.0, double sigma = 1.0)
    	{
    		uint num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		uint num2 = (w = w ^ (w >> 19) ^ num ^ (num >> 8)) >> 11;
    		num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		double d = 1.1102230246251565E-16 * ((double)(w = w ^ (w >> 19) ^ num ^ (num >> 8)) * 2097152.0 + (double)num2);
    		num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		num2 = (w = w ^ (w >> 19) ^ num ^ (num >> 8)) >> 11;
    		num = x ^ (x << 11);
    		x = y;
    		y = z;
    		z = w;
    		double num3 = 1.1102230246251565E-16 * ((double)(w = w ^ (w >> 19) ^ num ^ (num >> 8)) * 2097152.0 + (double)num2);
    		return System.Math.Sqrt(-2.0 * System.Math.Log(d)) * System.Math.Cos(System.Math.PI * 2.0 * num3) * sigma + mu;
    	}
    }
}
