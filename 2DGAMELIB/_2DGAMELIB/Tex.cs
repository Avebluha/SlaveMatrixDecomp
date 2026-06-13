using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace _2DGAMELIB
{
    public class Tex
    {
    	private Pars pars;

    	private ParT parT;

    	private Par feed;

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

    	public Pars Pars => pars;

    	public ParT ParT => parT;

    	public Par Feed => feed;

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
    			if (parT != null)
    			{
    				parT.Text = text;
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
    			return parT.GetPositionBase();
    		}
    		set
    		{
    			parT.SetPositionBase(value);
    			if (feed != null)
    			{
    				feed.SetPositionBase(parT.ToGlobal(parT.GetOP()[0].ps[2] * 0.95));
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
    		pars = new Pars();
    		Out[] array = new Out[1] { Shas.GetSquare() };
    		array.OutlineFalse();
    		parT = new ParT
    		{
    			Tag = Name,
    			Text = Text
    		};

			parT.SetFont(Font);
    		parT.SetFontSize(TextSize);
    		parT.SetTextColor(TextColor);
    		parT.SetRectSize(new Vector2D(Width, Height));
			parT.SetInitializeOP(array);
    		parT.SetPositionBase(Position);
    		parT.SetSizeBase(Size);
    		parT.SetClosed(true);
    		parT.SetBrushColor(BackColor);
    		ParT.GetOP().ScalingX(ParT.GetBasePointBase(), Width);
    		ParT.GetOP().ScalingY(ParT.GetBasePointBase(), Height);
    		if (ShadColor != Color.Empty)
    		{
    			parT.SetShadBrush(new SolidBrush(ShadColor));
    		}
    		pars.Add(parT.Tag, parT);
    	}

    	private void SetFeed(string Name, double Size, ref Color FeedColor)
    	{
    		Out[] array = new Out[1] { Shas.GetTriangle() };
    		feed = new Par
    		{
    			Tag = Name + "_Feed",
    			Hit = false
    		};
    		feed.SetInitializeOP(array);
    		feed.SetBasePointBase(array.GetCenter());
    		feed.SetPositionBase(parT.ToGlobal(parT.GetOP()[0].ps[2] * 0.96));
    		feed.SetSizeBase(Size * 0.07);
    		feed.SetSizeYBase(0.9);
    		feed.SetClosed(true);
    		feed.SetPenColor(Color.FromArgb(0, Color.Black));
    		feed.SetBrushColor(Color.FromArgb(0, FeedColor));

    		feed.GetOP().ReverseY(feed.GetBasePointBase());
    		pars.Add(feed.Tag, feed);
    	}

    	public void SetHitColor(ModeEventDispatcher Med)
    	{
    		if (parT.GetHitColor() != Color.Transparent)
    		{
    			Med.RemUniqueColor(parT.GetHitColor());
    		}
    		parT.SetHitColor(Med.GetUniqueColor());
    	}

    	public void Progression(FPS FPS)
    	{
    		if (!f1)
    		{
    			Count += Speed / FPS.Value;
    			int num = (int)Count;
    			if (num <= Max)
    			{
    				parT.Text = text.Substring(0, num);
    				return;
    			}
    			parT.Text = text;
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
    		if (parT.GetHitColor() == HitColor)
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
    		if (f1 && f2 && parT.GetHitColor() == HitColor && Speed == speed)
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
    		pars.Dispose();
    	}
    }
}
