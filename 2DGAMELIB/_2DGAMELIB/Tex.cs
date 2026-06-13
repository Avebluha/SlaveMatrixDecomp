using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace _2DGAMELIB
{
    public class Tex
    {
    	private PartGroup _partGroup;

    	private ShapePartT _shapePartT;

    	private ShapePart feed;

    	public int Space;

    	private string text;

    	private double speed = 1.0;

    	private Action<Tex> Action = delegate
    	{
    	};

    	private MotV mv;

    	private bool f1;

    	private bool f2;

    	private double Count;

    	private int Max;

    	public Action<Tex> Done;

    	private byte a0;

    	private byte a1;

    	private string ConfigPath = Path.Combine(Directory.GetCurrentDirectory(), "Config.ini");

    	private bool FastText;

    	public PartGroup PartGroup => _partGroup;

    	public ShapePartT ShapePartT => _shapePartT;

    	public ShapePart Feed => feed;

    	public string TextIm
    	{
    		get
    		{
    			return text.Substring(Space, text.Length - Space);
    		}
    		set
    		{
    			if (feed != null)
    			{
    				a0 = feed.BrushColor.A;
    				a1 = feed.PenColor.A;
    				feed.BrushColor = Color.FromArgb(0, feed.BrushColor);
    				feed.PenColor = Color.FromArgb(0, feed.PenColor);
    			}
    			text = new string(' ', Space) + value;
    			Max = text.Length;
    			Count = Max;
    			f1 = false;
    			if (_shapePartT != null)
    			{
    				_shapePartT.Text = text;
    			}
    		}
    	}

    	public string Text
    	{
    		get
    		{
    			return text.Substring(Space, text.Length - Space);
    		}
    		set
    		{
    			if (feed != null)
    			{
    				a0 = feed.BrushColor.A;
    				a1 = feed.PenColor.A;
    				feed.BrushColor = Color.FromArgb(0, feed.BrushColor);
    				feed.PenColor = Color.FromArgb(0, feed.PenColor);
    			}
    			text = new string(' ', Space) + value;
    			Max = text.Length;
    			Count = Space;
    			f1 = false;
    		}
    	}

    	public double Speed
    	{
    		get
    		{
    			return speed;
    		}
    		set
    		{
    			speed = value;
    		}
    	}

    	public Vector2D Position
    	{
    		get
    		{
    			return _shapePartT.PositionBase;
    		}
    		set
    		{
    			_shapePartT.PositionBase = value;
    			if (feed != null)
    			{
    				feed.PositionBase = _shapePartT.ToGlobal(_shapePartT.OP[0].ps[2] * 0.95);
    			}
    		}
    	}

    	public bool IsPlaying => !f1;

    	public Tex(string Name, Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, int Space, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed, Color FeedColor, Action<Tex> Action)
    	{
    		try
    		{
    			if (!File.Exists(ConfigPath))
    			{
    				this.Speed = Speed;
    				speed = Speed;
    			}
    			else
    			{
    				string[] source = ConfigPath.ReadLines();
    				FastText = source.First((string s) => s.StartsWith("FastText:")).Last() == '1';
    			}
    		}
    		catch
    		{
    			this.Speed = Speed;
    			speed = Speed;
    		}
    		if (FastText)
    		{
    			this.Speed = 50.0;
    			speed = 50.0;
    		}
    		else
    		{
    			this.Speed = Speed;
    			speed = Speed;
    		}
    		this.Space = Space;
    		this.Text = Text;
    		this.Action = Action;
    		SetParT(Name, ref Position, Size, Width, Height, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor);
    		SetFeed(Name, Size, ref FeedColor);
    		mv = new MotV(0.0, 255.0);
    		mv.BaseSpeed = 2.0;
    	}

    	public Tex(string Name, Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, int Space, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed)
    	{
    		try
    		{
    			if (!File.Exists(ConfigPath))
    			{
    				this.Speed = Speed;
    				speed = Speed;
    			}
    			else
    			{
    				string[] source = ConfigPath.ReadLines();
    				FastText = source.First((string s) => s.StartsWith("FastText:")).Last() == '1';
    			}
    		}
    		catch
    		{
    			this.Speed = Speed;
    			speed = Speed;
    		}
    		if (FastText)
    		{
    			this.Speed = 50.0;
    			speed = 50.0;
    		}
    		else
    		{
    			this.Speed = Speed;
    			speed = Speed;
    		}
    		this.Space = Space;
    		this.Text = Text;
    		SetParT(Name, ref Position, Size, Width, Height, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor);
    	}

    	private void SetParT(string Name, ref Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, string Text, ref Color TextColor, ref Color ShadColor, ref Color BackColor)
    	{
    		_partGroup = new PartGroup();
    		CurveOutline[] array = new CurveOutline[1] { ShapeHelper.GetSquare() };
    		array.OutlineFalse();
    		_shapePartT = new ShapePartT
    		{
    			Tag = Name,
    			InitializeOP = array,
    			PositionBase = Position,
    			SizeBase = Size,
    			Closed = true,
    			BrushColor = BackColor,
    			Font = Font,
    			FontSize = TextSize,
    			TextColor = TextColor,
    			RectSize = new Vector2D(Width, Height),
    			Text = Text
    		};
    		ShapePartT.OP.ScalingX(ShapePartT.BasePointBase, Width);
    		ShapePartT.OP.ScalingY(ShapePartT.BasePointBase, Height);
    		if (ShadColor != Color.Empty)
    		{
    			_shapePartT.ShadBrush = new SolidBrush(ShadColor);
    		}
    		_partGroup.Add(_shapePartT.Tag, _shapePartT);
    	}

    	private void SetFeed(string Name, double Size, ref Color FeedColor)
    	{
    		CurveOutline[] array = new CurveOutline[1] { ShapeHelper.GetTriangle() };
    		feed = new ShapePart
    		{
    			Tag = Name + "_Feed",
    			InitializeOP = array,
    			BasePointBase = array.GetCenter(),
    			PositionBase = _shapePartT.ToGlobal(_shapePartT.OP[0].ps[2] * 0.96),
    			SizeBase = Size * 0.07,
    			SizeYBase = 0.9,
    			Closed = true,
    			PenColor = Color.FromArgb(0, Color.Black),
    			BrushColor = Color.FromArgb(0, FeedColor),
    			Hit = false
    		};
    		feed.OP.ReverseY(feed.BasePointBase);
    		_partGroup.Add(feed.Tag, feed);
    	}

    	public void SetHitColor(ModeEventDispatcher Med)
    	{
    		if (_shapePartT.HitColor != Color.Transparent)
    		{
    			Med.RemUniqueColor(_shapePartT.HitColor);
    		}
    		_shapePartT.HitColor = Med.GetUniqueColor();
    	}

    	public void Progression(FPS FPS)
    	{
    		if (!f1)
    		{
    			Count += Speed / FPS.Value;
    			int num = (int)Count;
    			if (num <= Max)
    			{
    				_shapePartT.Text = text.Substring(0, num);
    				return;
    			}
    			_shapePartT.Text = text;
    			f1 = true;
    			if (feed != null)
    			{
    				feed.BrushColor = Color.FromArgb(a0, feed.BrushColor);
    				feed.PenColor = Color.FromArgb(a1, feed.PenColor);
    			}
    			if (Done != null)
    			{
    				Done(this);
    				Done = null;
    			}
    		}
    		else if (feed != null && feed.Dra)
    		{
    			mv.GetValue(FPS);
    			feed.BrushColor = Color.FromArgb((int)mv.Value, feed.BrushColor);
    			feed.PenColor = Color.FromArgb(feed.BrushColor.A, feed.PenColor);
    		}
    	}

    	public bool Down(ref Color HitColor)
    	{
    		if (_shapePartT.HitColor == HitColor)
    		{
    			f2 = true;
    			if (!f1 && Speed == speed)
    			{
    				Speed *= 10.0;
    				return true;
    			}
    		}
    		return false;
    	}

    	public bool Up(ref Color HitColor)
    	{
    		if (f1 && f2 && _shapePartT.HitColor == HitColor && Speed == speed)
    		{
    			f1 = false;
    			f2 = false;
    			if (feed != null)
    			{
    				feed.BrushColor = Color.FromArgb(0, feed.BrushColor);
    				feed.PenColor = Color.FromArgb(feed.BrushColor.A, feed.PenColor);
    				mv.ResetValue();
    			}
    			Action(this);
    			return true;
    		}
    		Speed = speed;
    		f2 = false;
    		return false;
    	}

    	public void Dispose()
    	{
    		_partGroup.Dispose();
    	}
    }
}
