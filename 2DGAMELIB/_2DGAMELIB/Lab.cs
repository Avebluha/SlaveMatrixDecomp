using System;
using System.Drawing;

namespace _2DGAMELIB
{
    public class Lab
    {
    	private ParT parT;

    	private RenderArea Are;

    	private double Width;

    	private double Min;

    	public ParT ParT => parT;

    	public string Text
    	{
    		get
    		{
    			return parT.Text;
    		}
    		set
    		{
    			SetText(value);
    		}
    	}

    	private void SetText(string Text)
    	{
    		parT.Text = Text;
    		SetRect();
    	}

    	public Lab(RenderArea Are, string Name, ref Vector2D Position, double Size, double Width, Font Font, double TextSize, string Text, ref Color TextColor, ref Color ShadColor, ref Color BackColor, ref Color FramColor)
    	{
    		Setting(Are, Name, ref Position, Size, Width, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor, ref FramColor);
    	}

    	public Lab(RenderArea Are, string Name, Vector2D Position, double Size, double Width, Font Font, double TextSize, string Text, Color TextColor, Color ShadColor, Color BackColor, Color FramColor)
    	{
    		Setting(Are, Name, ref Position, Size, Width, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor, ref FramColor);
    	}

    	private void Setting(RenderArea Are, string Name, ref Vector2D Position, double Size, double Width, Font Font, double TextSize, string Text, ref Color TextColor, ref Color ShadColor, ref Color BackColor, ref Color FramColor)
    	{
    		this.Are = Are;
    		this.Width = Width;

    		Out[] array = new Out[1] { Shas.GetSquare() };
    		if (FramColor == Color.Empty || FramColor == Color.Transparent)
    		{
    			array.OutlineFalse();
    		}


    		parT = new ParT
    		{
    			InitializeOP = array,
    			BasePointBase = array[0].ps[0],
    			PositionBase = Position,
    			SizeBase = Size,
    			Closed = true,


                Tag = Name,
                BrushColor = BackColor,
    			PenColor = FramColor,
    			Font = Font,
    			FontSize = TextSize,
    			TextColor = TextColor,
    			Text = "A"
    		};

    		if (ShadColor != Color.Empty)
    		{
    			parT.ShadBrush = new SolidBrush(ShadColor);
    		}


    		SetRect();
    		Min = parT.RectSize.Y;
    		SetText(Text);
    	}

    	public void SetHitColor(Med Med)
    	{
    		if (parT.HitColor != Color.Transparent)
    		{
    			Med.RemUniqueColor(parT.HitColor);
    		}
    		parT.HitColor = Med.GetUniqueColor();
    	}

    	private void SetRect()
    	{
    		if (!string.IsNullOrEmpty(parT.Text))
    		{
    			parT.RectSize = new Vector2D(Width, 10.0);
    			Vector2D_2 stringRect = parT.GetStringRect(Are.DisplayUnitScale, Are.DisplayGraphics);
    			double x = ((stringRect.v2.X > Min) ? stringRect.v2.X : Min) + 0.07;
    			parT.RectSize = new Vector2D(x, stringRect.v2.Y);
    		}
    		else
    		{
    			double x2 = Min + 0.07;
    			parT.RectSize = new Vector2D(x2, Min);
    		}


    		parT.OP[0].ps[0] = new Vector2D(0.0, 0.0);
    		parT.OP[0].ps[1] = new Vector2D(parT.RectSize.X, 0.0);
    		parT.OP[0].ps[2] = new Vector2D(parT.RectSize.X, parT.RectSize.Y);
    		parT.OP[0].ps[3] = new Vector2D(0.0, parT.RectSize.Y);
    	}

    	public void Dispose()
    	{
    		parT.Dispose();
    	}
    }
}
