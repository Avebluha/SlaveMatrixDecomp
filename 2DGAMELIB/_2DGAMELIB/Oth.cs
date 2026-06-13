using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace _2DGAMELIB
{
    public static class Oth
    {
    	private static double s1;

    	private static double s0;

    	public static Color Reverse(this Color c)
    	{
    		return Color.FromArgb(c.A, 255 - c.R, 255 - c.G, 255 - c.B);
    	}

    	public static void GetRandomColor(out Color ret)
    	{
    		ret = Color.FromArgb(255, RNG.XS.Next(256), RNG.XS.Next(256), RNG.XS.Next(256));
    	}

    	public static Color GetInter(ref Color c1, ref Color c2)
    	{
    		return Color.FromArgb((c1.A + c2.A) / 2, (c1.R + c2.R) / 2, (c1.G + c2.G) / 2, (c1.B + c2.B) / 2);
    	}

    	public static void GetInter(ref Color c1, ref Color c2, out Color ret)
    	{
    		ret = Color.FromArgb((c1.A + c2.A) / 2, (c1.R + c2.R) / 2, (c1.G + c2.G) / 2, (c1.B + c2.B) / 2);
    	}

    	public static Vector2D GetRandomVector()
    	{
    		return new Vector2D(RNG.XS.NextDouble() * (double)(RNG.XS.NextBool() ? 1 : (-1)), RNG.XS.NextDouble() * (double)(RNG.XS.NextBool() ? 1 : (-1)));
    	}

    	public static Color FuncHSV(this Color Color, Func<Hsv, Hsv> Func)
    	{
    		return Func(new Hsv(ref Color)).GetColor();
    	}

    	public static System.Drawing.Rectangle GetRect(this Bitmap Bmp)
    	{
    		return new System.Drawing.Rectangle(0, 0, Bmp.Width, Bmp.Height);
    	}

    	public static LinearGradientBrush GetLGB(double Unit, Vector2D[] MM, Color Color1, Color Color2)
    	{
    		return new LinearGradientBrush((MM[0] * Unit * s0).ToPointF(), (MM[1] * Unit * s1).ToPointF(), Color1, Color2)
    		{
    			GammaCorrection = true
    		};
    	}

    	public static LinearGradientBrush GetLGB(double Unit, Vector2D[] MM, ref Color Color1, ref Color Color2)
    	{
    		return new LinearGradientBrush((MM[0] * Unit * s0).ToPointF(), (MM[1] * Unit * s1).ToPointF(), Color1, Color2)
    		{
    			GammaCorrection = true
    		};
    	}

    	private static void GetMinMaxX(ShapePart ShapePart, ref double MinX, ref double MaxX)
    	{
    		foreach (CurveOutline item in ShapePart.OP)
    		{
    			foreach (Vector2D p in item.ps)
    			{
    				Vector2D vector2D = ShapePart.ToGlobal(p);
    				if (MinX > vector2D.X)
    				{
    					MinX = vector2D.X;
    				}
    				else if (MaxX < vector2D.X)
    				{
    					MaxX = vector2D.X;
    				}
    			}
    		}
    	}

    	private static void GetMinMaxY(ShapePart ShapePart, ref double MinY, ref double MaxY)
    	{
    		foreach (CurveOutline item in ShapePart.OP)
    		{
    			foreach (Vector2D p in item.ps)
    			{
    				Vector2D vector2D = ShapePart.ToGlobal(p);
    				if (MinY > vector2D.Y)
    				{
    					MinY = vector2D.Y;
    				}
    				else if (MaxY < vector2D.Y)
    				{
    					MaxY = vector2D.Y;
    				}
    			}
    		}
    	}

    	private static void GetMinMaxY(ShapePart[] Pars, ref double MinY, ref double MaxY)
    	{
    		for (int i = 0; i < Pars.Length; i++)
    		{
    			GetMinMaxY(Pars[i], ref MinY, ref MaxY);
    		}
    	}

    	public static void GetMiX_MaX(this ShapePart ShapePart, out Vector2D[] MM)
    	{
    		Vector2D vector2D = ShapePart.ToGlobal(ShapePart.OP.First().ps.First());
    		MM = new Vector2D[2];
    		MM[0].X = vector2D.X;
    		MM[1].X = vector2D.X;
    		GetMinMaxX(ShapePart, ref MM[0].X, ref MM[1].X);
    	}

    	public static void GetMaX_MiX(this ShapePart ShapePart, out Vector2D[] MM)
    	{
    		Vector2D vector2D = ShapePart.ToGlobal(ShapePart.OP.First().ps.First());
    		MM = new Vector2D[2];
    		MM[0].X = vector2D.X;
    		MM[1].X = vector2D.X;
    		GetMinMaxX(ShapePart, ref MM[1].X, ref MM[0].X);
    	}

    	public static void GetMiY_MaY(this ShapePart ShapePart, out Vector2D[] MM)
    	{
    		Vector2D vector2D = ShapePart.ToGlobal(ShapePart.OP.First().ps.First());
    		MM = new Vector2D[2];
    		MM[0].Y = vector2D.Y;
    		MM[1].Y = vector2D.Y;
    		GetMinMaxY(ShapePart, ref MM[0].Y, ref MM[1].Y);
    	}

    	public static void GetMiY_MaY(this ShapePart[] Pars, out Vector2D[] MM)
    	{
    		ShapePart shapePart = Pars.First();
    		Vector2D vector2D = shapePart.ToGlobal(shapePart.OP.First().ps.First());
    		MM = new Vector2D[2];
    		MM[0].Y = vector2D.Y;
    		MM[1].Y = vector2D.Y;
    		GetMinMaxY(Pars, ref MM[0].Y, ref MM[1].Y);
    	}

    	public static void GetMaY_MiY(this ShapePart ShapePart, out Vector2D[] MM)
    	{
    		Vector2D vector2D = ShapePart.ToGlobal(ShapePart.OP.First().ps.First());
    		MM = new Vector2D[2];
    		MM[0].Y = vector2D.Y;
    		MM[1].Y = vector2D.Y;
    		GetMinMaxY(ShapePart, ref MM[1].Y, ref MM[0].Y);
    	}

public static BodyTemplate ObjLoad(this byte[] bd)
        {
            return bd.Load<byte[]>().ToDeserialObject<BodyTemplate>().SetDefaultR();
        }

        public static BodyTemplate? ObjLoadRaw(this byte[] bd)
        {
            try
            {
                return bd.Load<byte[]>().ToDeserialObject<BodyTemplate>();
            }
            catch
            {
                return null;
            }
        }


        public static bool Lot(this double p)
    	{
    		return RNG.XS.NextDouble() < p;
    	}

    	public static int GetRandomIndex(params double[] WeightTable)
    	{
    		double les = WeightTable.Sum();
    		double num = RNG.XS.NextDouble(les);
    		int result = -1;
    		for (int i = 0; i < WeightTable.Length; i++)
    		{
    			if (WeightTable[i] >= num)
    			{
    				result = i;
    				break;
    			}
    			num -= WeightTable[i];
    		}
    		return result;
    	}

    	public static Encoding GetEncoding(this byte[] Bytes)
    	{
    		byte[] array = null;
    		if (Bytes.Length > 4000)
    		{
    			array = new byte[4000];
    			Array.Copy(Bytes, array, 4000);
    		}
    		else
    		{
    			array = Bytes;
    		}
    		int num = array.Length;
    		bool flag = false;
    		for (int i = 0; i < num; i++)
    		{
    			byte b = array[i];
    			if (b <= 6 || b == 127 || b == byte.MaxValue)
    			{
    				flag = true;
    				if (b == 0 && i < num - 1 && array[i + 1] <= 127)
    				{
    					return Encoding.Unicode;
    				}
    			}
    		}
    		if (flag)
    		{
    			return null;
    		}
    		bool flag2 = true;
    		byte[] array2 = array;
    		foreach (byte b2 in array2)
    		{
    			if (b2 == 27 || 128 <= b2)
    			{
    				flag2 = false;
    				break;
    			}
    		}
    		if (flag2)
    		{
    			return Encoding.ASCII;
    		}
    		for (int k = 0; k < num - 2; k++)
    		{
    			byte b = array[k];
    			byte b3 = array[k + 1];
    			byte b4 = array[k + 2];
    			if (b != 27)
    			{
    				continue;
    			}
    			if (b3 == 36 && b4 == 64)
    			{
    				return Encoding.GetEncoding(50220);
    			}
    			if (b3 == 36 && b4 == 66)
    			{
    				return Encoding.GetEncoding(50220);
    			}
    			if (b3 == 40 && (b4 == 66 || b4 == 74))
    			{
    				return Encoding.GetEncoding(50220);
    			}
    			if (b3 == 40 && b4 == 73)
    			{
    				return Encoding.GetEncoding(50220);
    			}
    			if (k < num - 3)
    			{
    				byte b5 = array[k + 3];
    				if (b3 == 36 && b4 == 40 && b5 == 68)
    				{
    					return Encoding.GetEncoding(50220);
    				}
    				if (k < num - 5 && b3 == 38 && b4 == 64 && b5 == 27 && array[k + 4] == 36 && array[k + 5] == 66)
    				{
    					return Encoding.GetEncoding(50220);
    				}
    			}
    		}
    		int num2 = 0;
    		int num3 = 0;
    		int num4 = 0;
    		for (int l = 0; l < num - 1; l++)
    		{
    			byte b = array[l];
    			byte b3 = array[l + 1];
    			if (((129 <= b && b <= 159) || (224 <= b && b <= 252)) && ((64 <= b3 && b3 <= 126) || (128 <= b3 && b3 <= 252)))
    			{
    				num2 += 2;
    				l++;
    			}
    		}
    		for (int m = 0; m < num - 1; m++)
    		{
    			byte b = array[m];
    			byte b3 = array[m + 1];
    			if ((161 <= b && b <= 254 && 161 <= b3 && b3 <= 254) || (b == 142 && 161 <= b3 && b3 <= 223))
    			{
    				num3 += 2;
    				m++;
    			}
    			else if (m < num - 2)
    			{
    				byte b4 = array[m + 2];
    				if (b == 143 && 161 <= b3 && b3 <= 254 && 161 <= b4 && b4 <= 254)
    				{
    					num3 += 3;
    					m += 2;
    				}
    			}
    		}
    		for (int n = 0; n < num - 1; n++)
    		{
    			byte b = array[n];
    			byte b3 = array[n + 1];
    			if (192 <= b && b <= 223 && 128 <= b3 && b3 <= 191)
    			{
    				num4 += 2;
    				n++;
    			}
    			else if (n < num - 2)
    			{
    				byte b4 = array[n + 2];
    				if (224 <= b && b <= 239 && 128 <= b3 && b3 <= 191 && 128 <= b4 && b4 <= 191)
    				{
    					num4 += 3;
    					n += 2;
    				}
    			}
    		}
    		if (num3 > num2 && num3 > num4)
    		{
    			return Encoding.GetEncoding(51932);
    		}
    		if (num2 > num3 && num2 > num4)
    		{
    			return Encoding.GetEncoding(932);
    		}
    		if (num4 > num3 && num4 > num2)
    		{
    			return Encoding.UTF8;
    		}
    		return null;
    	}

    	public static string Join(this IEnumerable<string> strs, string Separator)
    	{
    		return string.Join(Separator, strs);
    	}

    	static Oth()
    	{
    		s1 = 1.01;
    		s0 = s1.Reciprocal();
    	}

    	public static void SaveExMod<T>(this T Obj, string Path)
    	{
    		Obj.ToSerialBytes().Save(Path);
    	}

    	public static T LoadExMod<T>(this string Path)
    	{
    		return Path.Load<byte[]>().ToDeserialObject<T>();
    	}
    }
}
