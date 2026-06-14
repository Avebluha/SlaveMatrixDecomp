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

    		CurveOutline[] array = new CurveOutline[1] { ShapeHelper.GetSquare() };
    		if (FramColor == Color.Empty || FramColor == Color.Transparent)
    		{
    			array.OutlineFalse();
    		}


    		_shapePartT = new ShapePartT
    		{
                Tag = Name,
    			Text = "A"
    		};

    		_shapePartT.SetFont(Font);
    		_shapePartT.SetFontSize(TextSize);
    		_shapePartT.SetTextColor(TextColor);
			_shapePartT.SetInitializeOP(array);
    		_shapePartT.SetBasePointBase(array[0].ps[0]);
    		_shapePartT.SetPositionBase(Position);
    		_shapePartT.SetSizeBase(Size);
    		_shapePartT.SetClosed(true);
            _shapePartT.SetBrushColor(BackColor);
    		_shapePartT.SetPenColor(FramColor);

    		if (ShadColor != Color.Empty)
    		{
    			_shapePartT.SetShadBrush(new SolidBrush(ShadColor));
    		}


    		SetRect();
    		Min = _shapePartT.GetRectSize().Y;
    		SetText(Text);
    	}

    	public void SetHitColor(ModeEventDispatcher Med)
    	{
    		if (_shapePartT.GetHitColor() != Color.Transparent)
    		{
    			Med.RemUniqueColor(_shapePartT.GetHitColor());
    		}
    		_shapePartT.SetHitColor(Med.GetUniqueColor());
    	}

    	private void SetRect()
    	{
    		if (!string.IsNullOrEmpty(_shapePartT.Text))
    		{
    			_shapePartT.SetRectSize(new Vector2D(Width, 10.0));
    			double[] stringRect = _shapePartT.GetStringRect(Are.DisplayUnitScale, Are.DisplayGraphics);
    			double x = ((stringRect[2] > Min) ? stringRect[2] : Min) + 0.07;
    			_shapePartT.SetRectSize(new Vector2D(x, stringRect[3]));
    		}
    		else
    		{
    			double x2 = Min + 0.07;
    			_shapePartT.SetRectSize(new Vector2D(x2, Min));
    		}

    		_shapePartT.GetOP()[0].ps[0] = new Vector2D(0.0, 0.0);
    		_shapePartT.GetOP()[0].ps[1] = new Vector2D(_shapePartT.GetRectSize().X, 0.0);
    		_shapePartT.GetOP()[0].ps[2] = new Vector2D(_shapePartT.GetRectSize().X, _shapePartT.GetRectSize().Y);
    		_shapePartT.GetOP()[0].ps[3] = new Vector2D(0.0, _shapePartT.GetRectSize().Y);
    	}

    	public void Dispose()
    	{
    		_shapePartT.Dispose();
    	}
    }
}
