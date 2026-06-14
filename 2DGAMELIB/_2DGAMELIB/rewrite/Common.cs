using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;

namespace _2DGAMELIB
{
    public static class Common
    {
        public static Vector2D ToVector2D(this Point Point)
        {
            return new Vector2D(Point.X, Point.Y);
        }

        public static Point ToPoint(this Vector2D Vector)
        {
            return new Point((int)Vector.X, (int)Vector.Y);
        }

        public static PointF ToPointF(this Vector2D Vector)
        {
            return new PointF((float)Vector.X, (float)Vector.Y);
        }

        public static void ToText(this string str, string Path, Encoding Encoding)
        {
            using StreamWriter streamWriter = new StreamWriter(Path, append: false, Encoding);
            streamWriter.Write(str);
        }

        public static string FromText(this string Path)
        {
            using FileStream fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
            byte[] array = new byte[fileStream.Length];
            fileStream.Read(array, 0, array.Length);
            using StreamReader streamReader = new StreamReader(new MemoryStream(array), array.GetEncoding());
            return streamReader.ReadToEnd();
        }

        public static string[] ReadLines(this string Path)
        {
            return Path.FromText().Replace("\r", "").Split('\n');
        }
    }

    public static class Math
    {
        public static ulong overflow_add(this ulong u0, ulong u1)
        {
            checked
            {
                try
                {
                    if (u0 + u1 > 9999999999999L)
                    {
                        return 9999999999999uL;
                    }
                    return u0 + u1;
                }
                catch
                {
                    return 9999999999999uL;
                }
            }
        }
        public static ulong underflow_subtract(this ulong u0, ulong u1)
        {
            if (u0 < u1)
            {
                return 0uL;
            }
            return u0 - u1;
        }

        public static double RoundDown(this double Value, int Digits)
        {
            double num = System.Math.Pow(10.0, Digits);
            if (!(Value > 0.0))
            {
                return System.Math.Ceiling(Value * num) / num;
            }
            return System.Math.Floor(Value * num) / num;
        }

        public static double Inverse(this double Rate)
        {
            if (Rate == 0.0)
            {
                return 1.0;
            }
            return (double)System.Math.Sign(Rate) - Rate;
        }

        public static double Reciprocal(this double Rate)
        {
            if (Rate == 0.0)
            {
                return 1.0;
            }
            return 1.0 / Rate;
        }
        public static double ToRadian(this double Degree)
        {
            return System.Math.PI * Degree / 180.0;
        }
        public static double ToDegree(this double Radian)
        {
            return Radian * 180.0 / System.Math.PI;
        }
        public static double Pow(this double x, double n)
        {
            return System.Math.Pow(x, n);
        }

        public static double Sin(this double θ)
        {
            return System.Math.Sin(θ);
        }

        public static double Abs(this double x)
        {
            return System.Math.Abs(x);
        }

        public static int Abs(this int x)
        {
            return System.Math.Abs(x);
        }

        public static int Sign(this double x)
        {
            return System.Math.Sign(x);
        }

        public static int Sign(this int x)
        {
            return System.Math.Sign(x);
        }

        public static double Sqrt(this double x)
        {
            return System.Math.Sqrt(x);
        }

        public static double Max(this double a, double b)
        {
            return System.Math.Max(a, b);
        }

        public static int Clamp(this int Value, int Min, int Max)
        {
            return System.Math.Min(Max, System.Math.Max(Min, Value));
        }

        public static double Clamp(this double Value, double Min, double Max)
        {
            return System.Math.Min(Max, System.Math.Max(Min, Value));
        }

        public static int Limit(this int Value, int Sta, int Les)
        {
            return System.Math.Min(Les - 1, System.Math.Max(Sta, Value));
        }


        public static MatrixD RotationZ(this double angle)
        {
            MatrixD result = default(MatrixD);
            result.M11 = System.Math.Cos(angle);
            result.M12 = System.Math.Sin(angle);
            result.M13 = 0.0;
            result.M14 = 0.0;
            result.M21 = 0.0 - result.M12;
            result.M22 = result.M11;
            result.M23 = 0.0;
            result.M24 = 0.0;
            result.M31 = 0.0;
            result.M32 = 0.0;
            result.M33 = 1.0;
            result.M34 = 0.0;
            result.M41 = 0.0;
            result.M42 = 0.0;
            result.M43 = 0.0;
            result.M44 = 1.0;
            return result;
        }

        public static void TransformCoordinate(ref Vector2D coord, ref MatrixD transform, out Vector2D result)
        {
            double num = 1.0 / (coord.X * transform.M14 + coord.Y * transform.M24 + transform.M44);
            result.X = (coord.X * transform.M11 + coord.Y * transform.M21 + transform.M41) * num;
            result.Y = (coord.X * transform.M12 + coord.Y * transform.M22 + transform.M42) * num;
        }

        public static Vector2D TransformCoordinateBP(this Vector2D coord, Vector2D BasePoint, MatrixD transform)
        {
            VectorMath.Subtract(ref coord, ref BasePoint, out coord);
            TransformCoordinate(ref coord, ref transform, out var result);
            VectorMath.Add(ref result, ref BasePoint, out result);
            return result;
        }

        public static Vector2D TransformCoordinateBP(ref Vector2D coord, ref Vector2D BasePoint, ref MatrixD transform)
        {
            VectorMath.Subtract(ref coord, ref BasePoint, out var r);
            TransformCoordinate(ref r, ref transform, out var result);
            VectorMath.Add(ref result, ref BasePoint, out result);
            return result;
        }





 /*
        public static PartGroup ToPars(this object obj)
    	{
    		return (PartGroup)obj;
    	}

    	public static ShapePartT ToParT(this object obj)
    	{
    		return (ShapePartT)obj;
    	}

    	public static ShapePart ToPar(this object obj)
    	{
    		return (ShapePart)obj;
    	}

    	public static Pen Copy(this Pen Pen)
    	{
    		return new Pen(Pen.Color, Pen.Width)
    		{
    			EndCap = Pen.EndCap,
    			StartCap = Pen.StartCap
    		};
    	}

    	public static Brush Copy(this Brush Brush)
    	{
    		if (Brush is SolidBrush)
    		{
    			return new SolidBrush(((SolidBrush)Brush).Color);
    		}
    		if (Brush is LinearGradientBrush)
    		{
    			LinearGradientBrush linearGradientBrush = (LinearGradientBrush)Brush;
    			LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(linearGradientBrush.Rectangle, Color.Black, Color.White, 0f);
    			linearGradientBrush2.Blend = linearGradientBrush.Blend;
    			linearGradientBrush2.GammaCorrection = linearGradientBrush.GammaCorrection;
    			linearGradientBrush2.InterpolationColors = linearGradientBrush.InterpolationColors;
    			linearGradientBrush2.LinearColors = new Color[linearGradientBrush.LinearColors.Length];
    			linearGradientBrush.LinearColors.CopyTo(linearGradientBrush2.LinearColors, 0);
    			linearGradientBrush2.Transform = linearGradientBrush.Transform;
    			linearGradientBrush2.WrapMode = linearGradientBrush.WrapMode;
    			return linearGradientBrush2;
    		}
    		if (Brush is PathGradientBrush)
    		{
    			PathGradientBrush pathGradientBrush = (PathGradientBrush)Brush;
    			PathGradientBrush pathGradientBrush2 = new PathGradientBrush(new GraphicsPath());
    			pathGradientBrush2.Blend = pathGradientBrush.Blend;
    			pathGradientBrush2.CenterColor = pathGradientBrush.CenterColor;
    			pathGradientBrush2.CenterPoint = pathGradientBrush.CenterPoint;
    			pathGradientBrush2.FocusScales = pathGradientBrush.FocusScales;
    			pathGradientBrush2.InterpolationColors = pathGradientBrush.InterpolationColors;
    			pathGradientBrush2.SurroundColors = new Color[pathGradientBrush.SurroundColors.Length];
    			pathGradientBrush.SurroundColors.CopyTo(pathGradientBrush2.SurroundColors, 0);
    			pathGradientBrush2.Transform = pathGradientBrush.Transform;
    			pathGradientBrush2.WrapMode = pathGradientBrush.WrapMode;
    			return pathGradientBrush2;
    		}
    		if (Brush is TextureBrush)
    		{
    			TextureBrush textureBrush = (TextureBrush)Brush;
    			return new TextureBrush(textureBrush.Image)
    			{
    				Transform = textureBrush.Transform,
    				WrapMode = textureBrush.WrapMode
    			};
    		}
    		if (Brush is HatchBrush)
    		{
    			HatchBrush hatchBrush = (HatchBrush)Brush;
    			return new HatchBrush(hatchBrush.HatchStyle, hatchBrush.ForegroundColor, hatchBrush.BackgroundColor);
    		}
    		return null;
    	}

    	public static Font Copy(this Font Font)
    	{
    		return new Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
    	}

    	public static StringFormat Copy(this StringFormat StringFormat)
    	{
    		return new StringFormat(StringFormat);
    	}

        */
    }
}
