using System;
using System.Collections.Generic;
using System.Drawing;
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
    }

    public static class Math
    {
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

    }
}
