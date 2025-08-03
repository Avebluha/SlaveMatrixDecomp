using System.Drawing;

namespace _2DGAMELIB
{
    public static class HSV
    {
    	public static void ToHSV(int r, int g, int b, out int h, out int s, out int v)
    	{
    		v = GetMax(r, g, b);
    		int num = v - GetMin(r, g, b);
    		if (num == 0)
    		{
    			s = 0;
    		}
    		else
    		{
    			s = (int)((double)(num * 255) / (double)v);
    		}
    		if (s == 0)
    		{
    			h = 0;
    			return;
    		}
    		double num2 = num;
    		if (r == v)
    		{
    			h = v - (int)((double)(b * 60) / num2) - (v - (int)((double)(g * 60) / num2));
    		}
    		else if (g == v)
    		{
    			h = 120 + (v - (int)((double)(r * 60) / num2)) - (v - (int)((double)(b * 60) / num2));
    		}
    		else
    		{
    			h = 240 + (v - (int)((double)(g * 60) / num2)) - (v - (int)((double)(r * 60) / num2));
    		}
    		if (h < 0)
    		{
    			h += 360;
    		}
    	}

    	public static void ToRGB(int h, int s, int v, out int r, out int g, out int b)
    	{
    		if (s == 0)
    		{
    			r = (g = (b = v));
    			return;
    		}
    		int num = h * 6;
    		switch (num / 360)
    		{
    		case 0:
    			r = v;
    			g = (int)((double)(v * (255 - (int)((double)(s * (360 - num % 360)) / 360.0))) / 255.0);
    			b = (int)((double)(v * (255 - s)) / 255.0);
    			break;
    		case 1:
    			r = (int)((double)(v * (255 - (int)((double)(s * (num % 360)) / 360.0))) / 255.0);
    			g = v;
    			b = (int)((double)(v * (255 - s)) / 255.0);
    			break;
    		case 2:
    			r = (int)((double)(v * (255 - s)) / 255.0);
    			g = v;
    			b = (int)((double)(v * (255 - (int)((double)(s * (360 - num % 360)) / 360.0))) / 255.0);
    			break;
    		case 3:
    			r = (int)((double)(v * (255 - s)) / 255.0);
    			g = (int)((double)(v * (255 - (int)((double)(s * (num % 360)) / 360.0))) / 255.0);
    			b = v;
    			break;
    		case 4:
    			r = (int)((double)(v * (255 - (int)((double)(s * (360 - num % 360)) / 360.0))) / 255.0);
    			g = (int)((double)(v * (255 - s)) / 255.0);
    			b = v;
    			break;
    		default:
    			r = v;
    			g = (int)((double)(v * (255 - s)) / 255.0);
    			b = (int)((double)(v * (255 - (int)((double)(s * (num % 360)) / 360.0))) / 255.0);
    			break;
    		}
    	}

    	public static void ToRGB(int h, int s, int v, out Color ret)
    	{
    		ToRGB(h, s, v, out var r, out var g, out var b);
    		ret = Color.FromArgb(r, g, b);
    	}

    	public static void ToRGB(int h, int s, int v, int a, out Color ret)
    	{
    		ToRGB(h, s, v, out var r, out var g, out var b);
    		ret = Color.FromArgb(a, r, g, b);
    	}

    	public static Hsv ToHSV(ref Color col)
    	{
    		Hsv result = default(Hsv);
    		ToHSV(col.R, col.G, col.B, out result.H, out result.S, out result.V);
    		return result;
    	}

    	private static int GetMax(int x, int y, int z)
    	{
    		if (x < y)
    		{
    			if (z >= y)
    			{
    				return z;
    			}
    			return y;
    		}
    		if (z < x)
    		{
    			return x;
    		}
    		return z;
    	}

    	private static int GetMin(int x, int y, int z)
    	{
    		if (x > y)
    		{
    			if (z <= y)
    			{
    				return z;
    			}
    			return y;
    		}
    		if (z > x)
    		{
    			return x;
    		}
    		return z;
    	}
    }
    public struct Hsv
    {
    	public int H;

    	public int S;

    	public int V;

    	public int Hue
    	{
    		get
    		{
    			return H;
    		}
    		set
    		{
    			H = value;
    			HueLimit();
    		}
    	}

    	public int Sat
    	{
    		get
    		{
    			return S;
    		}
    		set
    		{
    			S = value;
    			SatLimit();
    		}
    	}

    	public int Val
    	{
    		get
    		{
    			return V;
    		}
    		set
    		{
    			V = value;
    			ValLimit();
    		}
    	}

    	public Hsv(ref Color Color)
    	{
    		HSV.ToHSV(Color.R, Color.G, Color.B, out H, out S, out V);
    	}

    	private void HueLimit()
    	{
    		H %= 360;
    	}

    	private void SatLimit()
    	{
    		if (S > 255)
    		{
    			S = 255;
    		}
    		else if (S < 0)
    		{
    			S = 0;
    		}
    	}

    	private void ValLimit()
    	{
    		if (V > 255)
    		{
    			V = 255;
    		}
    		else if (V < 0)
    		{
    			V = 0;
    		}
    	}

    	public Color GetColor()
    	{
    		HSV.ToRGB(H, S, V, out var r, out var g, out var b);
    		return Color.FromArgb(r, g, b);
    	}

    	public Color GetColor(int a)
    	{
    		HSV.ToRGB(H, S, V, out var r, out var g, out var b);
    		return Color.FromArgb(a, r, g, b);
    	}

    	public void GetColor(out Color ret)
    	{
    		HSV.ToRGB(H, S, V, out var r, out var g, out var b);
    		ret = Color.FromArgb(r, g, b);
    	}

    	public void GetColor(int a, out Color ret)
    	{
    		HSV.ToRGB(H, S, V, out var r, out var g, out var b);
    		ret = Color.FromArgb(a, r, g, b);
    	}

    	public override string ToString()
    	{
    		return "H : " + H + " S : " + S + " V : " + V;
    	}
    }
}
