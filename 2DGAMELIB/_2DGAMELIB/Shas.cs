using System.Collections.Generic;
using System.Linq;

namespace _2DGAMELIB
{
    public static class Shas
    {
        //rectangle coords

    	public static Vector2D MulX(this Vector2D Vector, double X)
    	{
    		Vector.X *= X;
    		return Vector;
    	}

    	public static Vector2D MulY(this Vector2D Vector, double Y)
    	{
    		Vector.Y *= Y;
    		return Vector;
    	}

    	public static Vector2D AddX(this Vector2D Point, double X)
    	{
    		Point.X += X;
    		return Point;
    	}

    	public static Vector2D AddY(this Vector2D Point, double Y)
    	{
    		Point.Y += Y;
    		return Point;
    	}

    	public static Vector2D AddXY(this Vector2D Point, double X, double Y)
    	{
    		Point.X += X;
    		Point.Y += Y;
    		return Point;
    	}

    	public static void SetTension(this IEnumerable<CurveOutline> Out, float Tension)
    	{
    		foreach (CurveOutline item in Out)
    		{
    			item.Tension = Tension;
    		}
    	}

    	public static void OutlineFalse(this IEnumerable<CurveOutline> Out)
    	{
    		foreach (CurveOutline item in Out)
    		{
    			item.Outline = false;
    		}
    	}

    	public static Vector2D GetCenter(this IEnumerable<CurveOutline> Out)
    	{
    		double num = 0.0;
    		Vector2D vec2DZero = DataConsts.Vec2DZero;
    		foreach (CurveOutline item in Out)
    		{
    			foreach (Vector2D p in item.ps)
    			{
    				vec2DZero += p;
    			}
    			num += (double)item.ps.Count;
    		}
    		return vec2DZero / num;
    	}

    	public static Vector2D GetCenter(this IEnumerable<Joi> Joi)
    	{
    		double num = 0.0;
    		Vector2D vec2DZero = DataConsts.Vec2DZero;
    		foreach (Joi item in Joi)
    		{
    			vec2DZero += item.Joint;
    			num += 1.0;
    		}
    		return vec2DZero / num;
    	}

    	public static void Rotation(this IEnumerable<CurveOutline> Out, Vector2D BP, double Angle)
    	{
    		MatrixD transform = Angle.ToRadian().RotationZ();
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				item.ps[i] = item.ps[i].TransformCoordinateBP(BP, transform);
    			}
    		}
    	}

    	public static void ScalingX(this IEnumerable<CurveOutline> Out, Vector2D BP, double Rate)
    	{
    		double num = BP.X - BP.X * Rate;
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.X = value.X * Rate + num;
    				item.ps[i] = value;
    			}
    		}
    	}

    	public static void ScalingX(this IEnumerable<CurveOutline> Out, ref Vector2D BP, double Rate)
    	{
    		double num = BP.X - BP.X * Rate;
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.X = value.X * Rate + num;
    				item.ps[i] = value;
    			}
    		}
    	}

    	public static void ScalingY(this IEnumerable<CurveOutline> Out, Vector2D BP, double Rate)
    	{
    		double num = BP.Y - BP.Y * Rate;
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.Y = value.Y * Rate + num;
    				item.ps[i] = value;
    			}
    		}
    	}

    	public static void ScalingY(this IEnumerable<CurveOutline> Out, ref Vector2D BP, double Rate)
    	{
    		double num = BP.Y - BP.Y * Rate;
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.Y = value.Y * Rate + num;
    				item.ps[i] = value;
    			}
    		}
    	}

    	public static void ScalingXY(this IEnumerable<CurveOutline> Out, Vector2D BP, double Rate)
    	{
    		Vector2D vector2D = default(Vector2D);
    		vector2D.X = BP.X - BP.X * Rate;
    		vector2D.Y = BP.Y - BP.Y * Rate;
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.X = value.X * Rate + vector2D.X;
    				value.Y = value.Y * Rate + vector2D.Y;
    				item.ps[i] = value;
    			}
    		}
    	}

    	public static void ScalingXY(this IEnumerable<CurveOutline> Out, ref Vector2D BP, double Rate)
    	{
    		Vector2D vector2D = default(Vector2D);
    		vector2D.X = BP.X - BP.X * Rate;
    		vector2D.Y = BP.Y - BP.Y * Rate;
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.X = value.X * Rate + vector2D.X;
    				value.Y = value.Y * Rate + vector2D.Y;
    				item.ps[i] = value;
    			}
    		}
    	}

    	public static void ScalingXY(this IEnumerable<CurveOutline> Out, Vector2D BP, double X, double Y)
    	{
    		Vector2D vector2D = default(Vector2D);
    		vector2D.X = BP.X - BP.X * X;
    		vector2D.Y = BP.Y - BP.Y * Y;
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.X = value.X * X + vector2D.X;
    				value.Y = value.Y * Y + vector2D.Y;
    				item.ps[i] = value;
    			}
    		}
    	}

    	public static void ScalingX(this IEnumerable<Joi> Joi, Vector2D BP, double Rate)
    	{
    		double num = BP.X - BP.X * Rate;
    		foreach (Joi item in Joi)
    		{
    			item.Joint.X = item.Joint.X * Rate + num;
    		}
    	}

    	public static void ScalingX(this IEnumerable<Joi> Joi, ref Vector2D BP, double Rate)
    	{
    		double num = BP.X - BP.X * Rate;
    		foreach (Joi item in Joi)
    		{
    			item.Joint.X = item.Joint.X * Rate + num;
    		}
    	}

    	public static void ScalingY(this IEnumerable<Joi> Joi, Vector2D BP, double Rate)
    	{
    		double num = BP.Y - BP.Y * Rate;
    		foreach (Joi item in Joi)
    		{
    			item.Joint.Y = item.Joint.Y * Rate + num;
    		}
    	}

    	public static void ScalingY(this IEnumerable<Joi> Joi, ref Vector2D BP, double Rate)
    	{
    		double num = BP.Y - BP.Y * Rate;
    		foreach (Joi item in Joi)
    		{
    			item.Joint.Y = item.Joint.Y * Rate + num;
    		}
    	}

    	public static void ScalingXY(this IEnumerable<Joi> Joi, Vector2D BP, double Rate)
    	{
    		Vector2D vector2D = default(Vector2D);
    		vector2D.X = BP.X - BP.X * Rate;
    		vector2D.Y = BP.Y - BP.Y * Rate;
    		foreach (Joi item in Joi)
    		{
    			item.Joint.X = item.Joint.X * Rate + vector2D.X;
    			item.Joint.Y = item.Joint.Y * Rate + vector2D.Y;
    		}
    	}

    	public static void ScalingXY(this IEnumerable<Joi> Joi, ref Vector2D BP, double Rate)
    	{
    		Vector2D vector2D = default(Vector2D);
    		vector2D.X = BP.X - BP.X * Rate;
    		vector2D.Y = BP.Y - BP.Y * Rate;
    		foreach (Joi item in Joi)
    		{
    			item.Joint.X = item.Joint.X * Rate + vector2D.X;
    			item.Joint.Y = item.Joint.Y * Rate + vector2D.Y;
    		}
    	}

    	public static void ReverseX(this List<CurveOutline> Out, ref Vector2D BP)
    	{
    		double num = BP.X - (1.0 - BP.X);
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.X = 1.0 - value.X + num;
    				item.ps[i] = value;
    			}
    			item.ps.Reverse();
    		}
    		Out.Reverse();
    	}

    	public static void ReverseY(this List<CurveOutline> Out, Vector2D BP)
    	{
    		double num = BP.Y - (1.0 - BP.Y);
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.Y = 1.0 - value.Y + num;
    				item.ps[i] = value;
    			}
    			item.ps.Reverse();
    		}
    		Out.Reverse();
    	}

    	public static void ReverseY(this List<CurveOutline> Out, ref Vector2D BP)
    	{
    		double num = BP.Y - (1.0 - BP.Y);
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.Y = 1.0 - value.Y + num;
    				item.ps[i] = value;
    			}
    			item.ps.Reverse();
    		}
    		Out.Reverse();
    	}

    	public static void ReverseX(this List<Joi> Joi, ref Vector2D BP)
    	{
    		double num = BP.X - (1.0 - BP.X);
    		foreach (Joi item in Joi)
    		{
    			item.Joint.X = 1.0 - item.Joint.X + num;
    		}
    	}

    	public static void ReverseY(this List<Joi> Joi, ref Vector2D BP)
    	{
    		double num = BP.Y - (1.0 - BP.Y);
    		foreach (Joi item in Joi)
    		{
    			item.Joint.Y = 1.0 - item.Joint.Y + num;
    		}
    	}

    	public static void ExpansionX(this List<CurveOutline> Out, Vector2D BP, double Rate)
    	{
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D vector2D = (item.ps[i] - BP).newNormalize();
    				vector2D.Y = 0.0;
    				item.ps[i] += vector2D * Rate;
    			}
    		}
    	}

    	public static void ExpansionX(this List<CurveOutline> Out, ref Vector2D BP, double Rate)
    	{
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D vector2D = (item.ps[i] - BP).newNormalize();
    				vector2D.Y = 0.0;
    				item.ps[i] += vector2D * Rate;
    			}
    		}
    	}

    	public static void ExpansionY(this List<CurveOutline> Out, Vector2D BP, double Rate)
    	{
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D vector2D = (item.ps[i] - BP).newNormalize();
    				vector2D.X = 0.0;
    				item.ps[i] += vector2D * Rate;
    			}
    		}
    	}

    	public static void ExpansionY(this List<CurveOutline> Out, ref Vector2D BP, double Rate)
    	{
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D vector2D = (item.ps[i] - BP).newNormalize();
    				vector2D.X = 0.0;
    				item.ps[i] += vector2D * Rate;
    			}
    		}
    	}

    	public static void ExpansionXY(this List<CurveOutline> Out, Vector2D BP, double Rate)
    	{
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				item.ps[i] += (item.ps[i] - BP).newNormalize() * Rate;
    			}
    		}
    	}

    	public static void ExpansionXY(this List<CurveOutline> Out, ref Vector2D BP, double Rate)
    	{
    		foreach (CurveOutline item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				item.ps[i] += (item.ps[i] - BP).newNormalize() * Rate;
    			}
    		}
    	}

    	public static void ExpansionX(this List<Joi> Joi, ref Vector2D BP, double Rate)
    	{
    		foreach (Joi item in Joi)
    		{
    			Vector2D vector2D = (item.Joint - BP).newNormalize();
    			vector2D.Y = 0.0;
    			item.Joint += vector2D * Rate;
    		}
    	}

    	public static void ExpansionY(this List<Joi> Joi, ref Vector2D BP, double Rate)
    	{
    		foreach (Joi item in Joi)
    		{
    			Vector2D vector2D = (item.Joint - BP).newNormalize();
    			vector2D.X = 0.0;
    			item.Joint += vector2D * Rate;
    		}
    	}

    	public static void ExpansionXY(this List<Joi> Joi, Vector2D BP, double Rate)
    	{
    		foreach (Joi item in Joi)
    		{
    			item.Joint += (item.Joint - BP).newNormalize() * Rate;
    		}
    	}

    	public static void ExpansionXY(this List<Joi> Joi, ref Vector2D BP, double Rate)
    	{
    		foreach (Joi item in Joi)
    		{
    			item.Joint += (item.Joint - BP).newNormalize() * Rate;
    		}
    	}

    	public static IEnumerable<Vector2D> EnumPoints(this IEnumerable<CurveOutline> Out)
    	{
    		HashSet<Vector2D> hs = new HashSet<Vector2D>();
    		foreach (CurveOutline item in Out)
    		{
    			foreach (Vector2D p in item.ps)
    			{
    				if (!hs.Contains(p))
    				{
    					yield return p;
    					hs.Add(p);
    				}
    			}
    		}
    	}

    	public static CurveOutline GetTriangle()
    	{

            MatrixD m120 = 120.0.ToRadian().RotationZ();
            MatrixD m240 = 240.0.ToRadian().RotationZ();


            Vector2D TP1 = new Vector2D(0.5, 0.0);
            Vector2D TP2 = Math.TransformCoordinateBP(TP1, new Vector2D(0.5, 0.5), m120);
            Vector2D TP3 = Math.TransformCoordinateBP(TP1, new Vector2D(0.5, 0.5), m240);


    		return new CurveOutline
    		{
    			Tension = 0f,
    			ps = { TP1, TP2, TP3 }
    		};
    	}

    	public static CurveOutline GetSquare()
    	{
    		return new CurveOutline
    		{
    			Tension = 0f,
    			ps = {
                    new Vector2D(0.0, 0.0), 
                    new Vector2D(1.0, 0.0),
                    new Vector2D(1.0, 1.0),
                    new Vector2D(0.0, 1.0)
                }
    		};
    	}
    }
}
