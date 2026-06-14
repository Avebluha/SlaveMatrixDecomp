using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace _2DGAMELIB
{
    public class TextBlock
    {
    	private PartGroup _partGroup;

    	private ShapePartT _shapePartT;

    	private ShapePart feed;

    	public int Space;

    	private string text;

    	private double speed = 1.0;

    	private Action<TextBlock> Action = delegate
    	{
    	};

    	private MotionBase mv;

    	private bool f1;

    	private bool f2;

    	private double Count;

    	private int Max;

    	public Action<TextBlock> Done;

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
    				a0 = feed.GetBrushColor().A;
    				a1 = feed.GetPenColor().A;
    				feed.SetBrushColor(Color.FromArgb(0, feed.GetBrushColor()));
    				feed.SetPenColor(Color.FromArgb(0, feed.GetPenColor()));
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
    				a0 = feed.GetBrushColor().A;
    				a1 = feed.GetPenColor().A;
    				feed.SetBrushColor(Color.FromArgb(0, feed.GetBrushColor()));
    				feed.SetPenColor(Color.FromArgb(0, feed.GetPenColor()));
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
    			return _shapePartT.GetPositionBase();
    		}
    		set
    		{
    			_shapePartT.SetPositionBase(value);
    			if (feed != null)
    			{
    				feed.SetPositionBase(_shapePartT.ToGlobal(_shapePartT.GetOP()[0].ps[2] * 0.95));
    			}
    		}
    	}

    	public bool IsPlaying => !f1;

    	public TextBlock(string Name, Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, int Space, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed, Color FeedColor, Action<TextBlock> Action)
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
    		mv = new MotionBase(0.0, 255.0);
    		mv.BaseSpeed = 2.0;
    	}

    	public TextBlock(string Name, Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, int Space, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed)
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
    			Text = Text
    		};

			_shapePartT.SetFont(Font);
    		_shapePartT.SetFontSize(TextSize);
    		_shapePartT.SetTextColor(TextColor);
    		_shapePartT.SetRectSize(new Vector2D(Width, Height));
			_shapePartT.SetInitializeOP(array);
    		_shapePartT.SetPositionBase(Position);
    		_shapePartT.SetSizeBase(Size);
    		_shapePartT.SetClosed(true);
    		_shapePartT.SetBrushColor(BackColor);
    		_shapePartT.GetOP().ScalingX(_shapePartT.GetBasePointBase(), Width);
    		_shapePartT.GetOP().ScalingY(_shapePartT.GetBasePointBase(), Height);
    		if (ShadColor != Color.Empty)
    		{
    			_shapePartT.SetShadBrush(new SolidBrush(ShadColor));
    		}
    		_partGroup.Add(_shapePartT.Tag, _shapePartT);
    	}

    	private void SetFeed(string Name, double Size, ref Color FeedColor)
    	{
    		CurveOutline[] array = new CurveOutline[1] { ShapeHelper.GetTriangle() };
    		feed = new ShapePart
    		{
    			Tag = Name + "_Feed",
    			Hit = false
    		};
    		feed.SetInitializeOP(array);
    		feed.SetBasePointBase(array.GetCenter());
    		feed.SetPositionBase(feed.ToGlobal(feed.GetOP()[0].ps[2] * 0.96));
    		feed.SetSizeBase(Size * 0.07);
    		feed.SetSizeYBase(0.9);
    		feed.SetClosed(true);
    		feed.SetPenColor(Color.FromArgb(0, Color.Black));
    		feed.SetBrushColor(Color.FromArgb(0, FeedColor));

    		feed.GetOP().ReverseY(feed.GetBasePointBase());
    		_partGroup.Add(feed.Tag, feed);
    	}

    	public void SetHitColor(ModeEventDispatcher Med)
    	{
    		if (_shapePartT.GetHitColor() != Color.Transparent)
    		{
    			Med.RemUniqueColor(_shapePartT.GetHitColor());
    		}
    		_shapePartT.SetHitColor(Med.GetUniqueColor());
    	}

    	public void Progression(FpsCounter FPS)
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
    				feed.SetBrushColor(Color.FromArgb(a0, feed.GetBrushColor()));
    				feed.SetPenColor(Color.FromArgb(a1, feed.GetPenColor()));
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
    			feed.SetBrushColor(Color.FromArgb((int)mv.Value, feed.GetBrushColor()));
    			feed.SetPenColor(Color.FromArgb(feed.GetBrushColor().A, feed.GetPenColor()));
    		}
    	}

    	public bool Down(ref Color HitColor)
    	{
    		if (_shapePartT.GetHitColor() == HitColor)
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
    		if (f1 && f2 && _shapePartT.GetHitColor() == HitColor && Speed == speed)
    		{
    			f1 = false;
    			f2 = false;
    			if (feed != null)
    			{
    				feed.SetBrushColor(Color.FromArgb(0, feed.GetBrushColor()));
    				feed.SetPenColor(Color.FromArgb(feed.GetBrushColor().A, feed.GetPenColor()));
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
