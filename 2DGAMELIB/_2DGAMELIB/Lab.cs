using System;
using System.Drawing;

namespace _2DGAMELIB
{
    public class Lab
    {
    	private ShapePartT _shapePartT;

    	private RenderArea Are;

    	private double Width;

    	private double Min;

    	public ShapePartT ShapePartT => _shapePartT;

    	public string Text
    	{
    		get
    		{
    			return _shapePartT.Text;
    		}
    		set
    		{
    			SetText(value);
    		}
    	}

    	private void SetText(string Text)
    	{
    		_shapePartT.Text = Text;
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

    		CurveOutline[] array = new CurveOutline[1] { Shas.GetSquare() };
    		if (FramColor == Color.Empty || FramColor == Color.Transparent)
    		{
    			array.OutlineFalse();
    		}


    		_shapePartT = new ShapePartT
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
    			_shapePartT.ShadBrush = new SolidBrush(ShadColor);
    		}


    		SetRect();
    		Min = _shapePartT.RectSize.Y;
    		SetText(Text);
    	}

    	public void SetHitColor(ModeEventDispatcher Med)
    	{
    		if (_shapePartT.HitColor != Color.Transparent)
    		{
    			Med.RemUniqueColor(_shapePartT.HitColor);
    		}
    		_shapePartT.HitColor = Med.GetUniqueColor();
    	}

    	private void SetRect()
    	{
    		if (!string.IsNullOrEmpty(_shapePartT.Text))
    		{
    			_shapePartT.RectSize = new Vector2D(Width, 10.0);
    			Vector2D_2 stringRect = _shapePartT.GetStringRect(Are.DisplayUnitScale, Are.DisplayGraphics);
    			double x = ((stringRect.v2.X > Min) ? stringRect.v2.X : Min) + 0.07;
    			_shapePartT.RectSize = new Vector2D(x, stringRect.v2.Y);
    		}
    		else
    		{
    			double x2 = Min + 0.07;
    			_shapePartT.RectSize = new Vector2D(x2, Min);
    		}


    		_shapePartT.OP[0].ps[0] = new Vector2D(0.0, 0.0);
    		_shapePartT.OP[0].ps[1] = new Vector2D(_shapePartT.RectSize.X, 0.0);
    		_shapePartT.OP[0].ps[2] = new Vector2D(_shapePartT.RectSize.X, _shapePartT.RectSize.Y);
    		_shapePartT.OP[0].ps[3] = new Vector2D(0.0, _shapePartT.RectSize.Y);
    	}

    	public void Dispose()
    	{
    		_shapePartT.Dispose();
    	}
    }
}
