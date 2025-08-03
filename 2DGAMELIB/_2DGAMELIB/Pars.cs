using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2DGAMELIB
{
    [Serializable]
    public class Pars
    {
    	private Pars parent;

    	public string Tag = "";

    	public OrderedDictionary<string, object> pars = new OrderedDictionary<string, object>();

    	public Pars Parent => parent;

    	public IEnumerable<string> Keys => pars.Keys;

    	public IEnumerable<object> Values => pars.Values;

    	public double PositionSize
    	{
    		set
    		{
    			foreach (object value2 in pars.Values)
    			{
    				if (value2 is Pars)
    				{
    					((Pars)value2).PositionSize = value;
    				}
    				else if (value2 is Par)
    				{
    					((Par)value2).PositionSize = value;
    				}
    			}
    		}
    	}

    	public Vector2D PositionVector
    	{
    		set
    		{
    			foreach (object value2 in pars.Values)
    			{
    				if (value2 is Pars)
    				{
    					((Pars)value2).PositionVector = value;
    				}
    				else if (value2 is Par)
    				{
    					((Par)value2).PositionVector = value;
    				}
    			}
    		}
    	}

    	public double AngleBase
    	{
    		set
    		{
    			foreach (object value2 in pars.Values)
    			{
    				if (value2 is Pars)
    				{
    					((Pars)value2).AngleBase = value;
    				}
    				else if (value2 is Par)
    				{
    					((Par)value2).AngleBase = value;
    				}
    			}
    		}
    	}

    	public double AngleCont
    	{
    		set
    		{
    			foreach (object value2 in pars.Values)
    			{
    				if (value2 is Pars)
    				{
    					((Pars)value2).AngleCont = value;
    				}
    				else if (value2 is Par)
    				{
    					((Par)value2).AngleCont = value;
    				}
    			}
    		}
    	}

    	public double SizeBase
    	{
    		set
    		{
    			foreach (object value2 in pars.Values)
    			{
    				if (value2 is Pars)
    				{
    					((Pars)value2).SizeBase = value;
    				}
    				else if (value2 is Par)
    				{
    					((Par)value2).SizeBase = value;
    				}
    			}
    		}
    	}

    	public double SizeCont
    	{
    		set
    		{
    			foreach (object value2 in pars.Values)
    			{
    				if (value2 is Pars)
    				{
    					((Pars)value2).SizeCont = value;
    				}
    				else if (value2 is Par)
    				{
    					((Par)value2).SizeCont = value;
    				}
    			}
    		}
    	}

    	public double SizeXBase
    	{
    		set
    		{
    			foreach (object value2 in pars.Values)
    			{
    				if (value2 is Pars)
    				{
    					((Pars)value2).SizeXBase = value;
    				}
    				else if (value2 is Par)
    				{
    					((Par)value2).SizeXBase = value;
    				}
    			}
    		}
    	}

    	public double SizeXCont
    	{
    		set
    		{
    			foreach (object value2 in pars.Values)
    			{
    				if (value2 is Pars)
    				{
    					((Pars)value2).SizeXCont = value;
    				}
    				else if (value2 is Par)
    				{
    					((Par)value2).SizeXCont = value;
    				}
    			}
    		}
    	}

    	public double SizeYBase
    	{
    		set
    		{
    			foreach (object value2 in pars.Values)
    			{
    				if (value2 is Pars)
    				{
    					((Pars)value2).SizeYBase = value;
    				}
    				else if (value2 is Par)
    				{
    					((Par)value2).SizeYBase = value;
    				}
    			}
    		}
    	}

    	public double SizeYCont
    	{
    		set
    		{
    			foreach (object value2 in pars.Values)
    			{
    				if (value2 is Pars)
    				{
    					((Pars)value2).SizeYCont = value;
    				}
    				else if (value2 is Par)
    				{
    					((Par)value2).SizeYCont = value;
    				}
    			}
    		}
    	}

    	public bool Dra
    	{
    		set
    		{
    			foreach (object value2 in pars.Values)
    			{
    				if (value2 is Pars)
    				{
    					((Pars)value2).Dra = value;
    				}
    				else if (value2 is Par)
    				{
    					((Par)value2).Dra = value;
    				}
    			}
    		}
    	}

    	public bool Hit
    	{
    		set
    		{
    			foreach (object value2 in pars.Values)
    			{
    				if (value2 is Pars)
    				{
    					((Pars)value2).Hit = value;
    				}
    				else if (value2 is Par)
    				{
    					((Par)value2).Hit = value;
    				}
    			}
    		}
    	}

    	public object this[string Name]
    	{
    		get
    		{
    			return pars[Name];
    		}
    		set
    		{
    			pars[Name] = value;
    		}
    	}

    	public object this[int Index]
    	{
    		get
    		{
    			return pars[Index];
    		}
    		set
    		{
    			pars[Index] = value;
    		}
    	}

    	public void SetParent(Pars Parent)
    	{
    		parent = Parent;
    	}

    	public int IndexOf(object obj)
    	{
    		return pars.IndexOf(obj);
    	}

    	public void Add(string Name, Par Par)
    	{
    		Par.SetParent(this);
    		pars.Add(Name, Par);
    	}

    	public void Add(string Name, ParT ParT)
    	{
    		ParT.SetParent(this);
    		pars.Add(Name, ParT);
    	}

    	public void Add(string Name, Pars Pars)
    	{
    		Pars.SetParent(this);
    		pars.Add(Name, Pars);
    	}

    	public void Add(Pars Pars)
    	{
    		Pars.SetParent(this);
    		pars.Add(Pars.Tag, Pars);
    	}

    	public void Remove(string Name)
    	{
    		object obj = pars[Name];
    		if (obj is Pars)
    		{
    			((Pars)obj).SetParent(null);
    		}
    		else if (obj is ParT)
    		{
    			((ParT)obj).SetParent(null);
    		}
    		else if (obj is Par)
    		{
    			((Par)obj).SetParent(null);
    		}
    		pars.Remove(Name);
    	}

    	public IEnumerable<Par> EnumAllPar()
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				foreach (Par item in ((Pars)value).EnumAllPar())
    				{
    					yield return item;
    				}
    			}
    			else if (value is Par)
    			{
    				yield return (Par)value;
    			}
    		}
    	}

    	public void SetDefault()
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				((Pars)value).SetDefault();
    			}
    			else if (value is ParT)
    			{
    				((ParT)value).SetDefault();
    			}
    			else if (value is Par)
    			{
    				((Par)value).SetDefault();
    			}
    		}
    	}

    	public Pars()
    	{
    	}

    	public Pars(Par Par)
    	{
    		Tag = Par.Tag;
    		Add(Par.Tag, Par);
    	}

    	public Pars(ParT ParT)
    	{
    		Tag = ParT.Tag;
    		Add(ParT.Tag, ParT);
    	}

    	public Pars(Pars Pars)
    	{
    		Copy(Pars);
    	}

    	private void Copy(Pars Pars)
    	{
    		Tag = Pars.Tag;
    		foreach (string key in Pars.pars.Keys)
    		{
    			object obj = Pars.pars[key];
    			if (obj is Pars)
    			{
    				Add(key, ((Pars)obj).Clone());
    			}
    			else if (obj is ParT)
    			{
    				Add(key, new ParT((ParT)obj));
    			}
    			else if (obj is Par)
    			{
    				Add(key, new Par((Par)obj));
    			}
    		}
    	}

    	private Pars Clone()
    	{
    		Pars pars2 = new Pars();
    		pars2.Tag = Tag;
    		foreach (string key in pars.Keys)
    		{
    			object obj = pars[key];
    			if (obj is Pars)
    			{
    				pars2.Add(key, ((Pars)obj).Clone());
    			}
    			else if (obj is ParT)
    			{
    				pars2.Add(key, new ParT((ParT)obj));
    			}
    			else if (obj is Par)
    			{
    				pars2.Add(key, new Par((Par)obj));
    			}
    		}
    		return pars2;
    	}

    	public void Draw(double Unit, Graphics Graphics)
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				((Pars)value).Draw(Unit, Graphics);
    			}
    			else if (value is ParT)
    			{
    				((ParT)value).Draw(Unit, Graphics);
    			}
    			else if (value is Par)
    			{
    				((Par)value).Draw(Unit, Graphics);
    			}
    		}
    	}

    	public void DrawH(double Unit, Graphics Graphics)
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				((Pars)value).DrawH(Unit, Graphics);
    			}
    			else if (value is Par)
    			{
    				((Par)value).DrawH(Unit, Graphics);
    			}
    		}
    	}

    	public List<string> GetHitTags(ref Color HitColor)
    	{
    		List<string> list = new List<string>();
    		foreach (object value in pars.Values)
    		{
    			Par par;
    			if (value is Pars)
    			{
    				list.AddRange(((Pars)value).GetHitTags(ref HitColor));
    			}
    			else if (value is Par && (par = (Par)value).HitColor == HitColor)
    			{
    				list.Add(par.Tag);
    			}
    		}
    		return list;
    	}

    	public List<Par> GetHitPars(ref Color HitColor)
    	{
    		List<Par> list = new List<Par>();
    		foreach (object value in pars.Values)
    		{
    			Par item;
    			if (value is Pars)
    			{
    				list.AddRange(((Pars)value).GetHitPars(ref HitColor));
    			}
    			else if (value is Par && (item = (Par)value).HitColor == HitColor)
    			{
    				list.Add(item);
    			}
    		}
    		return list;
    	}

    	public bool IsHit(ref Color HitColor)
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars && ((Pars)value).IsHit(ref HitColor))
    			{
    				return true;
    			}
    			if (value is Par && ((Par)value).HitColor == HitColor)
    			{
    				return true;
    			}
    		}
    		return false;
    	}

    	public Par GetPar(List<int> Path)
    	{
    		return GetPar(0, Path);
    	}

    	private Par GetPar(int l, List<int> Path)
    	{
    		object obj = pars[Path[l]];
    		if (obj is Pars)
    		{
    			return ((Pars)obj).GetPar(l + 1, Path);
    		}
    		return (Par)obj;
    	}

    	public void ReverseX()
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				((Pars)value).ReverseX();
    			}
    			else if (value is Par)
    			{
    				((Par)value).ReverseX();
    			}
    		}
    	}

    	public void ReverseY()
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				((Pars)value).ReverseY();
    			}
    			else if (value is Par)
    			{
    				((Par)value).ReverseY();
    			}
    		}
    	}

    	public void Dispose()
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				((Pars)value).Dispose();
    			}
    			else if (value is ParT)
    			{
    				((ParT)value).Dispose();
    			}
    			else if (value is Par)
    			{
    				((Par)value).Dispose();
    			}
    		}
    	}
    }
    public static class pars
    {
    	public static Pars ToPars(this object obj)
    	{
    		return (Pars)obj;
    	}

    	public static ParT ToParT(this object obj)
    	{
    		return (ParT)obj;
    	}

    	public static Par ToPar(this object obj)
    	{
    		return (Par)obj;
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
    }
}
