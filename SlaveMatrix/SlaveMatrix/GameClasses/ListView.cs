using System;
using System.Collections.Generic;
using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
    //Text Actions
    public struct TA
    {
        public string Text;

        public Action<But> act;

        public TA(string Text, Action<But> act)
        {
            this.Text = Text;
            this.act = act;
        }
    }


    //list of buttons
    public class ListView
    {
    	private RenderArea Are;

    	private ShapePartT[] pt;

    	public ButtonMap bs;

    	private double Space;

    	private double LocalHeight;

    	private Vector2D p;

    	public IEnumerable<TA> Acts
    	{
    		set
    		{
    			int num = 0;
    			foreach (TA item in value)
    			{
    				pt[num].Text = item.Text;
    				bs[num.ToString()].Action = item.act;
    				num++;
    			}
    		}
    	}

    	public Vector2D Position
    	{
    		get
    		{
    			return p;
    		}
    		set
    		{
    			p = value;
    			double num = 0.0;
    			double num2 = pt[0].OP[0].ps[3].Y * pt[0].SizeBase;
    			num2 += num2 * Space;
    			ShapePartT[] array = pt;
    			for (int i = 0; i < array.Length; i++)
    			{
    				array[i].PositionBase = p.AddY(num);
    				num += num2;
    			}
    		}
    	}

    	public ListView(RenderArea Are, Vector2D Position, double Space, Font Font, double TextSize, Color TextColor, Color ShadColor, Color BackColor, Color FramColor, params TA[] acts)
    	{
    		this.Are = Are;
    		this.Space = Space;
    		pt = new ShapePartT[acts.Length];
    		bs = new ButtonMap();
    		for (int i = 0; i < acts.Length; i++)
    		{
    			pt[i] = new ShapePartT();
    			pt[i].Text = acts[i].Text;
    			pt[i].SizeBase = 0.095;
    			pt[i].Font = Font;
    			pt[i].FontSize = TextSize;
    			pt[i].RectSize = new Vector2D(100.0, 100.0);
    			pt[i].SetStringRectOutline(Are.UnitScale, Are.DisplayGraphics);
    			pt[i].Closed = true;
    			pt[i].TextColor = TextColor;
    			if (!ShadColor.IsEmpty)
    			{
    				pt[i].ShadBrush = new SolidBrush(ShadColor);
    			}
    			pt[i].BrushColor = BackColor;
    			pt[i].PenColor = FramColor;
    			bs.Add(i.ToString(), new But1(pt[i], acts[i].act));
    		}
    		this.Position = Position;
    		LocalHeight = Are.LocalHeight;
    	}

    	public void SetHitColor(ModeEventDispatcher Med)
    	{
    		ShapePartT[] array = pt;
    		foreach (ShapePartT obj in array)
    		{
    			obj.HitColor = Med.GetUniqueColor();
    			obj.HitColor = Med.GetUniqueColor();
    		}
    	}

    	public void Down(ref Color HitColor)
    	{
    		bs.Down(ref HitColor);
    	}

    	public void Leave()
    	{
    		bs.Leave();
    	}

    	public void Move(ref Color HitColor)
    	{
    		bs.Move(ref HitColor);
    	}

    	public void Up(ref Color HitColor)
    	{
    		bs.Up(ref HitColor);
    	}

    	public void Draw(RenderArea Are)
    	{
    		bs.Draw(Are);
    	}

    	public void Dispose()
    	{
    		bs.Dispose();
    	}
    }
}
