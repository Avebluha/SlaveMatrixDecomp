using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class Onomatopoeia
    {
    	private Mots ms = new Mots();

    	private List<string> del = new List<string>();

    	public void Sound(RenderArea Are, Vector2D p, string s, Font f, Color c, double d, bool b)
    	{
    		ParT pt = new ParT
    		{
    			PositionBase = p,
    			Text = s,
    			Font = f,
    			TextColor = c,
    			SizeBase = 0.5 * d,
    			FontSize = 0.07,
    			Closed = true,
    			Pen = null,
    			Brush = null,
    			Hit = false
    		};
    		pt.SetStringRectOutline(Are.UnitScale, Are.DisplayGraphics);
    		pt.BasePointBase = pt.OP.GetCenter();
    		Mot mot = new Mot(0.0, 1.0);
    		string n = mot.GetHashCode().ToString();
    		TextRenderingHint tr = Are.DisplayGraphics.TextRenderingHint;
    		mot.BaseSpeed = 0.1;
    		mot.Runing = delegate(Mot m)
    		{
    			if (b)
    			{
    				pt.PositionCont = Oth.GetRandomVector() * 0.0025 * d;
    			}
    			pt.TextColor = Color.FromArgb((int)((double)(int)pt.TextColor.A * m.Value.Inverse()), pt.TextColor);
    			Are.DisplayGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
    			Are.Draw(pt);
    			Are.DisplayGraphics.TextRenderingHint = tr;
    		};
    		mot.Reaing = delegate(Mot m)
    		{
    			m.End();
    		};
    		mot.Ending = delegate
    		{
    			Are.DisplayGraphics.TextRenderingHint = tr;
    			pt.Dispose();
    			del.Add(n);
    		};
    		ms.Add(n, mot);
    		mot.Start();
    	}

    	public void Draw(FPS FPS)
    	{
    		ms.Drive(FPS);
    		foreach (string item in del)
    		{
    			ms.Rem(item);
    		}
    		del.Clear();
    	}

    	public void Clear()
    	{
    		foreach (KeyValuePair<string, Mot> m in ms.ms)
    		{
    			m.Value.End();
    		}
    		foreach (string item in del)
    		{
    			ms.Rem(item);
    		}
    		del.Clear();
    	}

    	public void Dispose()
    	{
    		foreach (Mot value in ms.ms.Values)
    		{
    			value.End();
    		}
    	}
    }
}
