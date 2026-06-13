using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class Onomatopoeia
    {
    	private Motions ms = new Motions();

    	private List<string> del = new List<string>();

    	public void Sound(RenderArea Are, Vector2D p, string s, Font f, Color c, double d, bool b)
    	{
    		ParT pt = new ParT
    		{
    			Text = s,
    			Hit = false
    		};

			pt.SetFont(f); 
    		pt.SetTextColor(c);
    		pt.SetFontSize(0.07);
			pt.SetSizeBase(0.5 * d);
    		pt.SetClosed(true);
    		pt.SetPen(null);
    		pt.SetBrush(null);
    		pt.SetPositionBase(p);
    		pt.SetStringRectOutline(Are.UnitScale, Are.DisplayGraphics);
    		pt.SetBasePointBase(pt.GetOP().GetCenter());

    		Motion mot = new Motion(0.0, 1.0);
    		string n = mot.GetHashCode().ToString();
    		TextRenderingHint tr = Are.DisplayGraphics.TextRenderingHint;
    		mot.BaseSpeed = 0.1;
    		mot.OnUpdate = delegate(Motion m)
    		{
    			if (b)
    			{
    				pt.SetPositionCont(Oth.GetRandomVector() * 0.0025 * d);
    			}
    			pt.SetTextColor(Color.FromArgb((int)((double)(int)pt.GetTextColor().A * m.Value.Inverse()), pt.GetTextColor()));
    			Are.DisplayGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
    			Are.Draw(pt);
    			Are.DisplayGraphics.TextRenderingHint = tr;
    		};
    		mot.OnReach = delegate(Motion m)
    		{
    			m.End();
    		};
    		mot.OnEnd = delegate
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
    		foreach (KeyValuePair<string, Motion> m in ms.ms)
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
    		foreach (Motion value in ms.ms.Values)
    		{
    			value.End();
    		}
    	}
    }
}
