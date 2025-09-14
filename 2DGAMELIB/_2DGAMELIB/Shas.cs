using System.Collections.Generic;
using System.Linq;

namespace _2DGAMELIB
{
    public static class Shas
    {
    	public static readonly double D3 = 1.0 / 3.0;

    	public static readonly double D3_2 = 2.0 / 3.0;

    	public static Vector2D 左端上端 = Dat.Vec2DZero;

    	public static Vector2D 中央上端 = new Vector2D(0.5, 0.0);

    	public static Vector2D 左寄上端 = new Vector2D(D3, 0.0);

    	public static Vector2D 右寄上端 = new Vector2D(D3_2, 0.0);

    	public static Vector2D 右端上端 = new Vector2D(1.0, 0.0);

    	public static Vector2D 左端中央 = new Vector2D(0.0, 0.5);

    	public static Vector2D 中央中央 = new Vector2D(0.5, 0.5);

    	public static Vector2D 左寄中央 = new Vector2D(D3, 0.5);

    	public static Vector2D 右寄中央 = new Vector2D(D3_2, 0.5);

    	public static Vector2D 右端中央 = new Vector2D(1.0, 0.5);

    	public static Vector2D 左端上寄 = new Vector2D(0.0, D3);

    	public static Vector2D 中央上寄 = new Vector2D(0.5, D3);

    	public static Vector2D 左寄上寄 = new Vector2D(D3, D3);

    	public static Vector2D 右寄上寄 = new Vector2D(D3_2, D3);

    	public static Vector2D 右端上寄 = new Vector2D(1.0, D3);

    	public static Vector2D 左端下寄 = new Vector2D(0.0, D3_2);

    	public static Vector2D 中央下寄 = new Vector2D(0.5, D3_2);

    	public static Vector2D 左寄下寄 = new Vector2D(D3, D3_2);

    	public static Vector2D 右寄下寄 = new Vector2D(D3_2, D3_2);

    	public static Vector2D 右端下寄 = new Vector2D(1.0, D3_2);

    	public static Vector2D 左端下端 = new Vector2D(0.0, 1.0);

    	public static Vector2D 中央下端 = new Vector2D(0.5, 1.0);

    	public static Vector2D 左寄下端 = new Vector2D(D3, 1.0);

    	public static Vector2D 右寄下端 = new Vector2D(D3_2, 1.0);

    	public static Vector2D 右端下端 = Dat.Vec2DOne;

    	private static MatrixD m120 = 120.0.ToRadian().RotationZ();

    	private static MatrixD m240 = 240.0.ToRadian().RotationZ();

    	public static Vector2D TP1 = 中央上端;

    	public static Vector2D TP2 = GetTP2();

    	public static Vector2D TP3 = GetTP3();

    	public static Vector2D TP1_2 = (TP1 + TP2) * 0.5;

    	public static Vector2D TP2_3 = (TP2 + TP3) * 0.5;

    	public static Vector2D TP3_1 = (TP3 + TP1) * 0.5;

    	private static Vector2D GetTP2()
    	{
    		return Math.TransformCoordinateBP(ref TP1, ref 中央中央, ref m120);
    	}

    	private static Vector2D GetTP3()
    	{
    		return Math.TransformCoordinateBP(ref TP1, ref 中央中央, ref m240);
    	}

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

    	public static Vector2D MulXY(this Vector2D Vector, double X, double Y)
    	{
    		Vector.X *= X;
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

    	public static void SetTension(this IEnumerable<Out> Out, float Tension)
    	{
    		foreach (Out item in Out)
    		{
    			item.Tension = Tension;
    		}
    	}

    	public static void OutlineFalse(this IEnumerable<Out> Out)
    	{
    		foreach (Out item in Out)
    		{
    			item.Outline = false;
    		}
    	}

    	public static Vector2D GetCenter(this IEnumerable<Out> Out)
    	{
    		double num = 0.0;
    		Vector2D vec2DZero = Dat.Vec2DZero;
    		foreach (Out item in Out)
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
    		Vector2D vec2DZero = Dat.Vec2DZero;
    		foreach (Joi item in Joi)
    		{
    			vec2DZero += item.Joint;
    			num += 1.0;
    		}
    		return vec2DZero / num;
    	}

    	public static void Rotation(this IEnumerable<Out> Out, Vector2D BP, double Angle)
    	{
    		MatrixD transform = Angle.ToRadian().RotationZ();
    		foreach (Out item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				item.ps[i] = item.ps[i].TransformCoordinateBP(BP, transform);
    			}
    		}
    	}

    	public static void ScalingX(this IEnumerable<Out> Out, Vector2D BP, double Rate)
    	{
    		double num = BP.X - BP.X * Rate;
    		foreach (Out item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.X = value.X * Rate + num;
    				item.ps[i] = value;
    			}
    		}
    	}

    	public static void ScalingX(this IEnumerable<Out> Out, ref Vector2D BP, double Rate)
    	{
    		double num = BP.X - BP.X * Rate;
    		foreach (Out item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.X = value.X * Rate + num;
    				item.ps[i] = value;
    			}
    		}
    	}

    	public static void ScalingY(this IEnumerable<Out> Out, Vector2D BP, double Rate)
    	{
    		double num = BP.Y - BP.Y * Rate;
    		foreach (Out item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.Y = value.Y * Rate + num;
    				item.ps[i] = value;
    			}
    		}
    	}

    	public static void ScalingY(this IEnumerable<Out> Out, ref Vector2D BP, double Rate)
    	{
    		double num = BP.Y - BP.Y * Rate;
    		foreach (Out item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D value = item.ps[i];
    				value.Y = value.Y * Rate + num;
    				item.ps[i] = value;
    			}
    		}
    	}

    	public static void ScalingXY(this IEnumerable<Out> Out, Vector2D BP, double Rate)
    	{
    		Vector2D vector2D = default(Vector2D);
    		vector2D.X = BP.X - BP.X * Rate;
    		vector2D.Y = BP.Y - BP.Y * Rate;
    		foreach (Out item in Out)
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

    	public static void ScalingXY(this IEnumerable<Out> Out, ref Vector2D BP, double Rate)
    	{
    		Vector2D vector2D = default(Vector2D);
    		vector2D.X = BP.X - BP.X * Rate;
    		vector2D.Y = BP.Y - BP.Y * Rate;
    		foreach (Out item in Out)
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

    	public static void ScalingXY(this IEnumerable<Out> Out, Vector2D BP, double X, double Y)
    	{
    		Vector2D vector2D = default(Vector2D);
    		vector2D.X = BP.X - BP.X * X;
    		vector2D.Y = BP.Y - BP.Y * Y;
    		foreach (Out item in Out)
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

    	public static void ReverseX(this List<Out> Out, ref Vector2D BP)
    	{
    		double num = BP.X - (1.0 - BP.X);
    		foreach (Out item in Out)
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

    	public static void ReverseY(this List<Out> Out, Vector2D BP)
    	{
    		double num = BP.Y - (1.0 - BP.Y);
    		foreach (Out item in Out)
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

    	public static void ReverseY(this List<Out> Out, ref Vector2D BP)
    	{
    		double num = BP.Y - (1.0 - BP.Y);
    		foreach (Out item in Out)
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

    	public static void ExpansionX(this List<Out> Out, Vector2D BP, double Rate)
    	{
    		foreach (Out item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D vector2D = (item.ps[i] - BP).newNormalize();
    				vector2D.Y = 0.0;
    				item.ps[i] += vector2D * Rate;
    			}
    		}
    	}

    	public static void ExpansionX(this List<Out> Out, ref Vector2D BP, double Rate)
    	{
    		foreach (Out item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D vector2D = (item.ps[i] - BP).newNormalize();
    				vector2D.Y = 0.0;
    				item.ps[i] += vector2D * Rate;
    			}
    		}
    	}

    	public static void ExpansionY(this List<Out> Out, Vector2D BP, double Rate)
    	{
    		foreach (Out item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D vector2D = (item.ps[i] - BP).newNormalize();
    				vector2D.X = 0.0;
    				item.ps[i] += vector2D * Rate;
    			}
    		}
    	}

    	public static void ExpansionY(this List<Out> Out, ref Vector2D BP, double Rate)
    	{
    		foreach (Out item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				Vector2D vector2D = (item.ps[i] - BP).newNormalize();
    				vector2D.X = 0.0;
    				item.ps[i] += vector2D * Rate;
    			}
    		}
    	}

    	public static void ExpansionXY(this List<Out> Out, Vector2D BP, double Rate)
    	{
    		foreach (Out item in Out)
    		{
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				item.ps[i] += (item.ps[i] - BP).newNormalize() * Rate;
    			}
    		}
    	}

    	public static void ExpansionXY(this List<Out> Out, ref Vector2D BP, double Rate)
    	{
    		foreach (Out item in Out)
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

    	public static IEnumerable<Vector2D> EnumPoints(this IEnumerable<Out> Out)
    	{
    		HashSet<Vector2D> hs = new HashSet<Vector2D>();
    		foreach (Out item in Out)
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

    	public static Out Get三角形()
    	{
    		return new Out
    		{
    			Tension = 0f,
    			ps = { TP1, TP2, TP3 }
    		};
    	}

    	public static Out Get正方形()
    	{
    		return new Out
    		{
    			Tension = 0f,
    			ps = { 左端上端, 右端上端, 右端下端, 左端下端 }
    		};
    	}
    }
}
