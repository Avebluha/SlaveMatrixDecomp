using System.Drawing;

namespace _2DGAMELIB
{
    public enum Range
    {
        ZeroOne = 1,
        MinusPlus
    }

    public enum Open
    {
        Top = 1,
        Bot,
        Lef,
        Rig
    }

    public class Gau
    {
    	private Pars pars;

    	private Par base_;

    	private Par frame1;

    	private Par frame2;

    	private Par gauge;

    	private Par knob;

    	private double val;

    	private Brush PlusBrush;

    	private Brush MinusBrush;

    	private Open Open;

    	private Range Range;

    	private double Max;

    	private bool Grip;

    	private Vector2D op;

    	private double Unit;

    	private Color PlusColor1;

    	private Color PlusColor2;

    	private Color MinusColor1;

    	private Color MinusColor2;

    	public Pars Pars => pars;

    	public Par Base => base_;

    	public Par Frame1 => frame1;

    	public Par Gauge => gauge;

    	public Par Knob => knob;

    	public double Value
    	{
    		get
    		{
    			return val;
    		}
    		set
    		{
    			val = value;
    			SetLimit();
    			SetColor();
    			SetValue();
    		}
    	}

    	private Vector2D TL1 => frame1.OP[0].ps[0];

    	private Vector2D TR1 => frame1.OP[0].ps[1];

    	private Vector2D BR1 => frame1.OP[0].ps[2];

    	private Vector2D BL1 => frame1.OP[0].ps[3];

    	private Vector2D TL2 => frame2.OP[0].ps[0];

    	private Vector2D TR2 => frame2.OP[0].ps[1];

    	private Vector2D BR2 => frame2.OP[0].ps[2];

    	private Vector2D BL2 => frame2.OP[0].ps[3];

    	private Vector2D TLG => gauge.OP[0].ps[0];

    	private Vector2D TRG => gauge.OP[0].ps[1];

    	private Vector2D BRG => gauge.OP[0].ps[2];

    	private Vector2D BLG => gauge.OP[0].ps[3];

    	private void SetLimit()
    	{
    		if (Range == Range.ZeroOne)
    		{
    			val = val.Clamp(0.0, 1.0);
    		}
    		else
    		{
    			val = val.Clamp(-1.0, 1.0);
    		}
    	}

    	private void SetColor()
    	{
    		if (val > 0.0)
    		{
    			gauge.SetBrush(PlusBrush);
    		}
    		else
    		{
    			gauge.SetBrush(MinusBrush);
    		}
    	}

    	private void SetValue()
    	{
    		if (Open == Open.Top || Open == Open.Bot)
    		{
    			gauge.SizeYCont = val;
    		}
    		else if (Open == Open.Lef || Open == Open.Rig)
    		{
    			gauge.SizeXCont = val;
    		}
    		if (knob != null)
    		{
    			knob.PositionBase = GetKnobPosition();
    		}
    	}

    	private Vector2D GetBasePoint1()
    	{
    		if (Range == Range.MinusPlus)
    		{
    			switch (Open)
    			{
    			case Open.Top:
    				return (BL1 + BR1) * 0.5;
    			case Open.Bot:
    				return (TL1 + TR1) * 0.5;
    			case Open.Rig:
    				return (TL1 + BL1) * 0.5;
    			case Open.Lef:
    				return (TR1 + BR1) * 0.5;
    			}
    		}
    		return frame1.OP.GetCenter();
    	}

    	private Vector2D GetBasePoint2()
    	{
    		if (Range == Range.MinusPlus)
    		{
    			switch (Open)
    			{
    			case Open.Top:
    				return (TL2 + TR2) * 0.5;
    			case Open.Bot:
    				return (BL2 + BR2) * 0.5;
    			case Open.Rig:
    				return (TR2 + BR2) * 0.5;
    			case Open.Lef:
    				return (TL2 + BL2) * 0.5;
    			}
    		}
    		return frame2.OP.GetCenter();
    	}

    	private Vector2D GetBasePoint()
    	{
    		if (Range == Range.ZeroOne)
    		{
    			switch (Open)
    			{
    			case Open.Top:
    				return (BLG + BRG) * 0.5;
    			case Open.Bot:
    				return (TLG + TRG) * 0.5;
    			case Open.Rig:
    				return (TLG + BLG) * 0.5;
    			case Open.Lef:
    				return (TRG + BRG) * 0.5;
    			}
    		}
    		return frame1.BasePoint;
    	}

    	private double GetWidthMag()
    	{
    		if (Range == Range.MinusPlus && (Open == Open.Lef || Open == Open.Rig))
    		{
    			return 0.5;
    		}
    		return 1.0;
    	}

    	private double GetHeightMag()
    	{
    		if (Range == Range.MinusPlus && (Open == Open.Top || Open == Open.Bot))
    		{
    			return 0.5;
    		}
    		return 1.0;
    	}

    	private double GetGaugeWidthMag(double Margin)
    	{
    		if (Open == Open.Top || Open == Open.Bot)
    		{
    			return (Margin * 2.0).Inverse();
    		}
    		return 1.0;
    	}

    	private double GetGaugeHeightMag(double Margin)
    	{
    		if (Open == Open.Lef || Open == Open.Rig)
    		{
    			return (Margin * 2.0).Inverse();
    		}
    		return 1.0;
    	}

    	private double GetKnobWidthMag(double Width)
    	{
    		if (Open == Open.Top || Open == Open.Bot)
    		{
    			return Width;
    		}
    		return 0.1;
    	}

    	private double GetKnobHeightMag(double Height)
    	{
    		if (Open == Open.Lef || Open == Open.Rig)
    		{
    			return Height;
    		}
    		return 0.1;
    	}

    	private Vector2D GetGaugePosition()
    	{
    		return Open switch
    		{
    			Open.Top => frame1.ToGlobal((BL1 + BR1) * 0.5), 
    			Open.Bot => frame1.ToGlobal((TL1 + TR1) * 0.5), 
    			Open.Rig => frame1.ToGlobal((TL1 + BL1) * 0.5), 
    			Open.Lef => frame1.ToGlobal((TR1 + BR1) * 0.5), 
    			_ => Dat.Vec2DZero, 
    		};
    	}

    	private Vector2D GetKnobPosition()
    	{
    		return Open switch
    		{
    			Open.Top => gauge.ToGlobal((TLG + TRG) * 0.5), 
    			Open.Bot => gauge.ToGlobal((BLG + BRG) * 0.5), 
    			Open.Rig => gauge.ToGlobal((TRG + BRG) * 0.5), 
    			Open.Lef => gauge.ToGlobal((TLG + BLG) * 0.5), 
    			_ => Dat.Vec2DZero, 
    		};
    	}

    	private void ParSetting(string Name, ref Vector2D Position, double Size, double Width, double Height, double Margin, ref Color BackColor, bool knob)
    	{
    		pars = new Pars();
    		base_ = new Par
    		{
    			Tag = Name + "_ベース",
    			InitializeOP = new Out[1] { Shas.GetSquare() },
    			PositionBase = Position,
    			SizeBase = Size,
    			SizeXBase = Width,
    			SizeYBase = Height,
    			Closed = true,
    			Pen = null,
    			BrushColor = BackColor
    		};
    		base_.BasePointBase = base_.OP.GetCenter();
    		pars.Add(base_.Tag, base_);
    		frame1 = new Par
    		{
    			Tag = Name + "_フレーム1",
    			InitializeOP = new Out[1] { Shas.GetSquare() },
    			PositionBase = Position,
    			SizeBase = Size,
    			SizeXBase = Width * GetWidthMag(),
    			SizeYBase = Height * GetHeightMag(),
    			Closed = true,
    			Brush = null
    		};
    		frame1.BasePointBase = GetBasePoint1();
    		pars.Add(frame1.Tag, frame1);
    		if (Range == Range.MinusPlus)
    		{
    			frame2 = new Par
    			{
    				Tag = Name + "_フレーム2",
    				InitializeOP = new Out[1] { Shas.GetSquare() },
    				PositionBase = Position,
    				SizeBase = Size,
    				SizeXBase = Width * GetWidthMag(),
    				SizeYBase = Height * GetHeightMag(),
    				Closed = true,
    				Brush = null
    			};
    			frame2.BasePointBase = GetBasePoint2();
    			pars.Add(frame2.Tag, frame2);
    		}
    		gauge = new Par
    		{
    			Tag = Name + "_ゲージ",
    			InitializeOP = new Out[1] { Shas.GetSquare() },
    			PositionBase = GetGaugePosition(),
    			SizeBase = Size,
    			SizeXBase = Width * GetWidthMag() * GetGaugeWidthMag(Margin),
    			SizeYBase = Height * GetHeightMag() * GetGaugeHeightMag(Margin),
    			Closed = true
    		};
    		gauge.BasePointBase = GetBasePoint();
    		pars.Add(gauge.Tag, gauge);
    		if (knob)
    		{
    			this.knob = new Par
    			{
    				Tag = Name + "_ノブ",
    				InitializeOP = new Out[1] { Shas.GetSquare() },
    				SizeBase = Size,
    				SizeXBase = GetKnobWidthMag(Width),
    				SizeYBase = GetKnobHeightMag(Height),
    				Closed = true,
    				BrushColor = Color.FromArgb(128, Color.White)
    			};
    			this.knob.BasePointBase = this.knob.OP.GetCenter();
    			pars.Add(this.knob.Tag, this.knob);
    		}
    	}

    	private void SetBrush(double Unit, ref Color PlusColor1, ref Color PlusColor2, ref Color MinusColor1, ref Color MinusColor2)
    	{
    		this.Unit = Unit;
    		this.PlusColor1 = PlusColor1;
    		this.PlusColor2 = PlusColor2;
    		this.MinusColor1 = MinusColor1;
    		this.MinusColor2 = MinusColor2;
    		switch (Open)
    		{
    		case Open.Top:
    		{
    			frame1.GetMiY_MaY(out var MM7);
    			PlusBrush = Oth.GetLGB(Unit, MM7, ref PlusColor2, ref PlusColor1);
    			if (Range == Range.MinusPlus)
    			{
    				frame2.GetMiY_MaY(out var MM8);
    				MinusBrush = Oth.GetLGB(Unit, MM8, ref MinusColor1, ref MinusColor2);
    			}
    			break;
    		}
    		case Open.Bot:
    		{
    			frame1.GetMaY_MiY(out var MM3);
    			PlusBrush = Oth.GetLGB(Unit, MM3, ref PlusColor2, ref PlusColor1);
    			if (Range == Range.MinusPlus)
    			{
    				frame2.GetMaY_MiY(out var MM4);
    				MinusBrush = Oth.GetLGB(Unit, MM4, ref MinusColor1, ref MinusColor2);
    			}
    			break;
    		}
    		case Open.Rig:
    		{
    			frame1.GetMaX_MiX(out var MM5);
    			PlusBrush = Oth.GetLGB(Unit, MM5, ref PlusColor2, ref PlusColor1);
    			if (Range == Range.MinusPlus)
    			{
    				frame2.GetMaX_MiX(out var MM6);
    				MinusBrush = Oth.GetLGB(Unit, MM6, ref MinusColor1, ref MinusColor2);
    			}
    			break;
    		}
    		case Open.Lef:
    		{
    			frame1.GetMiX_MaX(out var MM);
    			PlusBrush = Oth.GetLGB(Unit, MM, ref PlusColor2, ref PlusColor1);
    			if (Range == Range.MinusPlus)
    			{
    				frame2.GetMiX_MaX(out var MM2);
    				MinusBrush = Oth.GetLGB(Unit, MM2, ref MinusColor1, ref MinusColor2);
    			}
    			break;
    		}
    		}
    	}

    	public void SetAlphaG(double Alpha)
    	{
    		switch (Open)
    		{
    		case Open.Top:
    		{
    			PlusBrush.Dispose();
    			frame1.GetMiY_MaY(out var MM7);
    			PlusBrush = Oth.GetLGB(Unit, MM7, Color.FromArgb((int)(255.0 * Alpha), PlusColor2), Color.FromArgb((int)(255.0 * Alpha), PlusColor1));
    			if (Range == Range.MinusPlus)
    			{
    				MinusBrush.Dispose();
    				frame2.GetMiY_MaY(out var MM8);
    				MinusBrush = Oth.GetLGB(Unit, MM8, Color.FromArgb((int)(255.0 * Alpha), MinusColor1), Color.FromArgb((int)(255.0 * Alpha), MinusColor2));
    			}
    			break;
    		}
    		case Open.Bot:
    		{
    			PlusBrush.Dispose();
    			frame1.GetMaY_MiY(out var MM3);
    			PlusBrush = Oth.GetLGB(Unit, MM3, Color.FromArgb((int)(255.0 * Alpha), PlusColor2), Color.FromArgb((int)(255.0 * Alpha), PlusColor1));
    			if (Range == Range.MinusPlus)
    			{
    				MinusBrush.Dispose();
    				frame2.GetMaY_MiY(out var MM4);
    				MinusBrush = Oth.GetLGB(Unit, MM4, Color.FromArgb((int)(255.0 * Alpha), MinusColor1), Color.FromArgb((int)(255.0 * Alpha), MinusColor2));
    			}
    			break;
    		}
    		case Open.Rig:
    		{
    			PlusBrush.Dispose();
    			frame1.GetMaX_MiX(out var MM5);
    			PlusBrush = Oth.GetLGB(Unit, MM5, Color.FromArgb((int)(255.0 * Alpha), PlusColor2), Color.FromArgb((int)(255.0 * Alpha), PlusColor1));
    			if (Range == Range.MinusPlus)
    			{
    				MinusBrush.Dispose();
    				frame2.GetMaX_MiX(out var MM6);
    				MinusBrush = Oth.GetLGB(Unit, MM6, Color.FromArgb((int)(255.0 * Alpha), MinusColor1), Color.FromArgb((int)(255.0 * Alpha), MinusColor2));
    			}
    			break;
    		}
    		case Open.Lef:
    		{
    			PlusBrush.Dispose();
    			frame1.GetMiX_MaX(out var MM);
    			PlusBrush = Oth.GetLGB(Unit, MM, Color.FromArgb((int)(255.0 * Alpha), PlusColor2), Color.FromArgb((int)(255.0 * Alpha), PlusColor1));
    			if (Range == Range.MinusPlus)
    			{
    				MinusBrush.Dispose();
    				frame2.GetMiX_MaX(out var MM2);
    				MinusBrush = Oth.GetLGB(Unit, MM2, Color.FromArgb((int)(255.0 * Alpha), MinusColor1), Color.FromArgb((int)(255.0 * Alpha), MinusColor2));
    			}
    			break;
    		}
    		}
    	}

    	private double GetMax()
    	{
    		return Open switch
    		{
    			Open.Top => (0.0 - gauge.SizeY) * gauge.Size, 
    			Open.Bot => gauge.SizeY * gauge.Size, 
    			Open.Rig => gauge.SizeX * gauge.Size, 
    			Open.Lef => (0.0 - gauge.SizeX) * gauge.Size, 
    			_ => 0.0, 
    		};
    	}

    	private double GetDifference(ref Vector2D CursorPosition)
    	{
    		if (Open == Open.Top || Open == Open.Bot)
    		{
    			return CursorPosition.Y - op.Y;
    		}
    		if (Open == Open.Lef || Open == Open.Rig)
    		{
    			return CursorPosition.X - op.X;
    		}
    		return 0.0;
    	}

    	public Gau(string Name, Vector2D Position, double Size, double Width, double Height, double Margin, Open Open, Range Range, double DisUnit, Color PlusColor1, Color PlusColor2, Color MinusColor1, Color MinusColor2, Color BackColor, bool Knob)
    	{
    		this.Open = Open;
    		this.Range = Range;
    		ParSetting(Name, ref Position, Size, Width, Height, Margin, ref BackColor, Knob);
    		SetBrush(DisUnit, ref PlusColor1, ref PlusColor2, ref MinusColor1, ref MinusColor2);
    		Max = GetMax();
    		Value = 0.0;
    	}

    	public bool Down(ref Color HitColor, ref Vector2D CursorPosition)
    	{
    		if (knob != null && knob.HitColor == HitColor)
    		{
    			Grip = true;
    			op = CursorPosition;
    			return true;
    		}
    		return false;
    	}

    	public bool Up()
    	{
    		if (Grip)
    		{
    			Grip = false;
    			return true;
    		}
    		return false;
    	}

    	public bool Move(ref Vector2D CursorPosition)
    	{
    		if (Grip)
    		{
    			Value += GetDifference(ref CursorPosition) / Max;
    			op = CursorPosition;
    			return true;
    		}
    		return false;
    	}

    	public bool Leave()
    	{
    		if (Grip)
    		{
    			Grip = false;
    			return true;
    		}
    		return false;
    	}

    	public void Dispose()
    	{
    		pars.Dispose();
    		PlusBrush.Dispose();
    		if (MinusBrush != null)
    		{
    			MinusBrush.Dispose();
    		}
    	}
    }
}
