using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public static class ColorHelper
    {
    	public static Color Empty = Color.Empty;

    	public static Color Black = Color.Black;

    	public static Color White = Color.White;

    	public static Color Gray = Color.Gray;

    	public static Color DarkGray = Color.DarkGray;

    	public static Color DimGray = Color.DimGray;

    	public static Color DarkGreen = Color.DarkGreen;

    	public static Color Green = Color.Green;

    	public static Color Indigo = Color.Indigo;

    	public static Color Yellow = Color.Yellow;

    	public static Color Red = Color.Red;

    	public static Color DeepPink = Color.DeepPink;

    	public static Color Silver = Color.Silver;

    	public static Color Pink = Color.Pink;

    	public static Color HotPink = Color.HotPink;

    	public static Color DarkMagenta = Color.DarkMagenta;

    	public static Color LightGreen = Color.LightGreen;

    	public static Color BlueViolet = Color.BlueViolet;

    	public static Color Violet = Color.Violet;

    	public static Color DarkGoldenrod = Color.DarkGoldenrod;

    	public static Color Transparent = Color.Transparent;

    	private const int min = 100;

    	private const int max = 160;

    	private static int abj = 60;

    	public static Color S(this Color c, double v)
    	{
    		Hsv hsv = new Hsv(ref c);
    		hsv.S = (int)((double)hsv.S * v);
    		return hsv.GetColor();
    	}

    	public static void Alpha(ref Color Color, int Alpha, out Color ret)
    	{
    		ret = Color.FromArgb(Alpha, Color);
    	}

    	public static void Alpha(ref Color2 Color2, int Alpha, out Color2 ret)
    	{
    		ret.Col1 = Color.FromArgb(Alpha, Color2.Col1);
    		ret.Col2 = Color.FromArgb(Alpha, Color2.Col2);
    	}

    	public static void GetAlpha(this ShapePart p, out int ret)
    	{
    		ret = (int)(100.0 + (double)abj * 255.0 * (p.GetArea() / Sta.MaxAre));
    		ret = ((ret > 160) ? 160 : ret);
    	}

    	public static Color Add(this Color Color, int h, int s, int v)
    	{
    		Hsv hsv = new Hsv(ref Color);
    		hsv.Hue += h;
    		hsv.Sat += s;
    		hsv.Val += v;
    		return hsv.GetColor(Color.A);
    	}

    	public static void Add(ref Color Color, int h, int s, int v, out Color ret)
    	{
    		Hsv hsv = new Hsv(ref Color);
    		hsv.Hue += h;
    		hsv.Sat += s;
    		hsv.Val += v;
    		hsv.GetColor(Color.A, out ret);
    	}

    	public static void Mul(ref Color Color, double h, double s, double v, out Color ret)
    	{
    		Hsv hsv = new Hsv(ref Color);
    		hsv.Hue = (int)((double)hsv.Hue * h);
    		hsv.Sat = (int)((double)hsv.Sat * s);
    		hsv.Val = (int)((double)hsv.Val * v);
    		hsv.GetColor(Color.A, out ret);
    	}

    	public static void GetGrad(ref Color Color, out Color2 ret)
    	{
    		double num = 1.3;
    		Mul(ref Color, 1.0, num.Reciprocal(), 2.0, out ret.Col1);
    		Mul(ref Color, 1.0, num, 0.9, out ret.Col2);
    	}

    	public static Color2 GetSkinGrad(this Color Color)
    	{
    		double num = 1.15;
    		Color2 result = default(Color2);
    		Mul(ref Color, 1.0, num.Reciprocal(), 1.0, out result.Col1);
    		Mul(ref Color, 1.0, num, 0.9, out result.Col2);
    		return result;
    	}

    	public static void GetSkinGrad(ref Color Color, out Color2 ret)
    	{
    		double num = 1.15;
    		Mul(ref Color, 1.0, num.Reciprocal(), 1.0, out ret.Col1);
    		Mul(ref Color, 1.0, num, 0.9, out ret.Col2);
    	}

    	public static void GetMetal(ref Color Color, out Color2 ret)
    	{
    		Mul(ref Color, 1.0, 1.0, 3.0, out ret.Col1);
    		ret.Col2 = Black;
    	}

    	public static void GetSkinColor2(ref Color Color, out Color ret)
    	{
    		Hsv hsv = new Hsv(ref Color);
    		hsv.S = 255;
    		hsv.V = 200;
    		hsv.GetColor(out ret);
    	}

    	public static void GetMucosaColor(ref Color Color, out Color ret)
    	{
    		Hsv hsv = new Hsv(ref Color);
    		hsv.S = 240;
    		hsv.GetColor(out ret);
    	}

    	public static void GetRandomColor(out Color ret)
    	{
    		HSV.ToRGB(RNG.XS.NextM(359), RNG.XS.NextM(0, 223), RNG.XS.NextM(128, 255), out ret);
    	}

    	public static void GetRandomSkinColor(out Color ret)
    	{
    		HSV.ToRGB(RNG.XS.NextM(359), 100, 200, out ret);
    	}

    	public static void GetRandomClothesColor(out Color ret)
    	{
    		HSV.ToRGB(RNG.XS.NextM(359), RNG.XS.NextM(0, 255), RNG.XS.NextM(0, 255), out ret);
    	}

    	public static void GetRandomClothesColor(int a, out Color ret)
    	{
    		HSV.ToRGB(RNG.XS.NextM(359), RNG.XS.NextM(0, 255), RNG.XS.NextM(0, 255), a, out ret);
    	}

    	public static void GetLimit(ref Color c, out Color ret)
    	{
    		Hsv hsv = new Hsv(ref c);
    		hsv.Sat = hsv.Sat.Clamp(0, 223);
    		hsv.Val = hsv.Val.Clamp(25, 200);
    		hsv.GetColor(c.A, out ret);
    	}

    	public static void GetLimitSkin(ref Color c, out Color ret)
    	{
    		Hsv hsv = new Hsv(ref c);
    		hsv.Sat = hsv.Sat.Clamp(20, 200);
    		hsv.Val = hsv.Val.Clamp(100, 255);
    		hsv.GetColor(c.A, out ret);
    	}

    	public static void GetSkinColor(out Color ret)
    	{
    		HSV.ToRGB(RNG.XS.Next(15, 40), RNG.XS.Next(34, 163), RNG.XS.Next(100, 247), out ret);
    	}
    }
}
