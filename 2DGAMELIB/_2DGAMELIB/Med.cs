using GLFW;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace _2DGAMELIB
{
    public class Med
    {
    	public static object obj;

    	private GlImage baseControl;

    	public double Unit = 1762.4;

    	public Rect Base = new Rect(4.0, 3.0, 0.4);

    	public double DisQuality = 1.0;

    	public double HitAccuracy = 0.5;

    	public Bitmap BD;

    	public Graphics GD;

    	public Bitmap BH;

    	public Graphics GH;

    	private Color ClearColor = Color.Transparent;

    	public bool Drive = true;

    	private Size BaseSize = Size.Empty;

    	private double resMag = 1.0;

    	private Vector2D resVector = Dat.Vec2DZero;

    	private Sce Sce;

    	private string mode;

    	public string Modeb;

    	private Dictionary<string, Module> Modes;

    	private Func<Med, Dictionary<string, Module>> GetModes;

    	private int WidthM;

    	private int HeightM;

    	public static double FPS;

    	public FPS FPSF = new FPS(FPS);

    	private bool cur = true;

    	public HashSet<Color> HitColors = new HashSet<Color>
    	{
    		Color.Transparent,
    		Color.Black
    	};

    	public static double DpiX;

    	public static double DpiY;

    	public string UITitle;

    	public bool ShowFPS;

    	//public Control BaseControlC => baseControl;

    	public string Mode
    	{
    		get
    		{
    			return mode;
    		}
    		set
    		{
    			Modes[mode].Up(MouseButtons.None, Dat.Vec2DZero, Color.Empty);
    			Modes[mode].Move(MouseButtons.None, Dat.Vec2DZero, Color.Empty);
    			Modeb = mode;
    			mode = value;
    			Modes[mode].Move(MouseButtons.None, Dat.Vec2DZero, Color.Empty);
    			Modes[mode].Setting();
    		}
    	}

    	public Vector2D CursorPosition => ToBasePosition(baseControl.GetCursorPoint()); //ToBasePosition(baseControl.PointToClient(System.Windows.Forms.Cursor.Position));

    	public Med()
    	{
            //Point dpi = GetDpi();
            //dpiX = dpi.X;
            //dpiY = dpi.Y;
            DpiX = 1.0; // 96.0 / dpiX;
            DpiY = 1.0; // 96.0 / dpiY;
    	}

    	public void FadeIn(double Rate)
    	{
    		Sce.TransformAlpha(GD, Rate);
    	}

    	public void FadeOut(double Rate)
    	{
    		Sce.TransD(GD, Rate);
    	}

    	public void DrawStart(Are Are)
    	{
    		Sce.DrawStart(Are);
    	}

    	public void DrawEnd(Are Are)
    	{
    		Sce.DrawEnd(Are);
    	}

    	public void ClearSta(Color ClearColor)
    	{
    		Sce.ClearStart(ref ClearColor);
    	}

    	public void InitializeModes(string Mode, Func<Med, Dictionary<string, Module>> GetModes)
    	{
    		mode = Mode;
    		this.GetModes = GetModes;
    	}

    	public Size Setting(GlImage BaseControl)
    	{
    		baseControl = BaseControl;
    		BaseSize = new Size((int)(Base.LocalWidth * Unit), (int)(Base.LocalHeight * Unit));
    		BD = new Bitmap(BaseSize.Width, BaseSize.Height);
    		GD = Graphics.FromImage(BD);
    		GD.InterpolationMode = InterpolationMode.HighQualityBilinear;
    		BH = new Bitmap((int)((double)BaseSize.Width * HitAccuracy), (int)((double)BaseSize.Height * HitAccuracy));
    		GH = Graphics.FromImage(BH);
    		GH.InterpolationMode = InterpolationMode.Bilinear;
    		WidthM = BH.Width - 1;
    		HeightM = BH.Height - 1;
    		Clear();
    		Sce = new Sce(BaseSize.Width, BaseSize.Height);
    		Modes = GetModes(this);


            BaseControl.Click = delegate (IntPtr window, GLFW.MouseButton button, InputState state, GLFW.ModifierKeys modifiers)
            {
    			double x, y;
    			Glfw.GetCursorPosition(GlImage.PtrToWindow(window), out x, out y);
                Point Position5 = new Point((int)x, (int)y);
                MouseButtons arg2 = MouseButtons.None;
                switch (button)
                {
                    case GLFW.MouseButton.Left:
                        arg2 = MouseButtons.Left;
                        break;
                    case GLFW.MouseButton.Middle:
                        arg2 = MouseButtons.Middle;
                        break;
                    case GLFW.MouseButton.Right:
                        arg2 = MouseButtons.Right;
                        break;
                    case GLFW.MouseButton.Button4:
                        arg2 = MouseButtons.Button4;
                        break;
                    case GLFW.MouseButton.Button5:
                        arg2 = MouseButtons.Button5;
                        break;
    			}


    			(state == InputState.Press ? Modes[mode].Down : Modes[mode].Up)(arg2, ToBasePosition(Position5), GetHitColor(ref Position5));
    		};

    		BaseControl.Move = delegate (IntPtr window, double x, double y)
    		{
    			Point Position3 = new Point((int)x, (int)y);
    			Modes[mode].Move(BaseControl.GetMouseButtons(), ToBasePosition(Position3), GetHitColor(ref Position3));
    		};

    		BaseControl.Leave = delegate (IntPtr window, bool entered)
    		{
    			if (!entered)
    			{
    				double x, y;
    				Glfw.GetCursorPosition(GlImage.PtrToWindow(window), out x, out y);
    				Point Position2 = new Point((int)x, (int)y);
    				Modes[mode].Leave(BaseControl.GetMouseButtons(), ToBasePosition(Position2), GetHitColor(ref Position2));
    			}
    		};

    		BaseControl.Scroll = delegate (IntPtr window, double xo, double yo)
    		{
                double x, y;
                Glfw.GetCursorPosition(GlImage.PtrToWindow(window), out x, out y);
    			Point Position = new Point((int)x, (int)y);
    			//Note: yo may be inverted
                Modes[mode].Wheel(BaseControl.GetMouseButtons(), ToBasePosition(Position), (int)yo, GetHitColor(ref Position));
            };

    		BaseControl.Resize = delegate (IntPtr window, int width, int height)
    		{
    			//TODO mess with viewport
                if (BaseSize.Width >= BaseSize.Height)
                {
                    double num = (double)BaseSize.Width / (double)BaseSize.Height;
                    if ((double)width / (double)height <= num)
                    {
                        resMag = (double)BaseSize.Width / (double)width;
                        resVector.X = 0.0;
                        resVector.Y = ((double)height - (double)BaseSize.Height / resMag) * 0.5;
                    }
                    else
                    {
                        resMag = (double)BaseSize.Height / (double)height;
                        resVector.X = ((double)width - (double)BaseSize.Width / resMag) * 0.5;
                        resVector.Y = 0.0;
                    }
                }
                else
                {
                    double num2 = (double)BaseSize.Height / (double)BaseSize.Width;
                    if ((double)height / (double)width <= num2)
                    {
                        resMag = (double)BaseSize.Height / (double)height;
                        resVector.X = ((double)width - (double)BaseSize.Width / resMag) * 0.5;
                        resVector.Y = 0.0;
                    }
                    else
                    {
                        resMag = (double)BaseSize.Width / (double)width;
                        resVector.X = 0.0;
                        resVector.Y = ((double)height - (double)BaseSize.Height / resMag) * 0.5;
                    }
                }
            };

    		return BaseSize;
    	}

    	public Vector2D ToBasePosition(Point Position)
    	{
    		return new Vector2D(((double)Position.X - resVector.X) / Unit * resMag, ((double)Position.Y - resVector.Y) / Unit * resMag);
    	}

    	public Point FromBasePosition(Vector2D Position)
    	{
    		return new Point((int)(Position.X / resMag * Unit + resVector.X), (int)(Position.Y / resMag * Unit + resVector.Y));
    	}

    	public Color GetHitColor(Point Position)
    	{
    		double num = HitAccuracy * resMag;
    		Point point = ((Position.ToVector2D() - resVector) * num).ToPoint();
    		if (point.X < 0)
    		{
    			point.X = 0;
    		}
    		if (point.Y < 0)
    		{
    			point.Y = 0;
    		}
    		if (point.X > WidthM)
    		{
    			point.X = WidthM;
    		}
    		if (point.Y > HeightM)
    		{
    			point.Y = HeightM;
    		}
    		return BH.GetPixel(point.X, point.Y);
    	}

    	public Color GetHitColor(ref Point Position)
    	{
    		double num = HitAccuracy * resMag;
    		Point point = ((Position.ToVector2D() - resVector) * num).ToPoint();
    		if (point.X < 0)
    		{
    			point.X = 0;
    		}
    		if (point.Y < 0)
    		{
    			point.Y = 0;
    		}
    		if (point.X > WidthM)
    		{
    			point.X = WidthM;
    		}
    		if (point.Y > HeightM)
    		{
    			point.Y = HeightM;
    		}
    		return BH.GetPixel(point.X, point.Y);
    	}

    	public void Drawing()
    	{
    		baseControl.BitmapSetting(BD);
    		Modes[mode].Setting();


    		Action action = delegate
    		{
    			if (FPSF.Value > 1.0)
    			{
    				Modes[mode].Draw(FPSF);

                    if (ShowFPS)
                    {
                        baseControl.SetTitle(UITitle + " - FPS: " + System.Math.Round(FPSF.Value, 2));
                    }
                }

                GD.DrawImage(BH, new Point(0, 0));
    			baseControl.SetBitmap(BD);
            };


    		while (Drive)
    		{
    			FPSF.FPSFixed(action);
    			baseControl.PollEvents();
    		}
    	}

    	public void Clear()
    	{
    		GD.Clear(ClearColor);
    		GH.Clear(ClearColor);
    	}

    	public void Draw(Are Are)
    	{
    		Are.Draw(GD, GH);
    	}

    	public void CursorHide()
    	{
    		if (cur)
    		{
    			//TODO fix?
    			//System.Windows.Forms.Cursor.Hide();
    			cur = false;
    		}
    	}

    	public void CursorShow()
    	{
    		if (!cur)
            {
                //TODO fix?
                //System.Windows.Forms.Cursor.Show();
                cur = true;
    		}
    	}

    	public void InvokeL(Action a)
    	{
    		//TODO this look right?
    		a();
    		//baseControl.Invoke(a);
    	}

    	public Color GetUniqueColor()
    	{
    		Oth.GetRandomColor(out var ret);
    		while (HitColors.Contains(ret))
    		{
    			Oth.GetRandomColor(out ret);
    		}
    		HitColors.Add(ret);
    		return ret;
    	}

    	public void GetUniqueColor(out Color c)
    	{
    		Oth.GetRandomColor(out c);
    		while (HitColors.Contains(c))
    		{
    			Oth.GetRandomColor(out c);
    		}
    		HitColors.Add(c);
    	}

    	public void SetUniqueColor(IEnumerable<Par> ps)
    	{
    		foreach (Par p in ps)
    		{
    			p.HitColor = GetUniqueColor();
    		}
    	}

    	public void RemUniqueColor(Color Color)
    	{
    		HitColors.Remove(Color);
    	}

    	public void RemUniqueColor(IEnumerable<Par> ps)
    	{
    		foreach (Par p in ps)
    		{
    			HitColors.Remove(p.HitColor);
    		}
    	}

    	//[DllImport("user32.dll")]
    	//private static extern bool SetProcessDPIAware();

    	//[DllImport("user32.dll")]
    	//private static extern IntPtr GetWindowDC(IntPtr hwnd);

    	//[DllImport("gdi32.dll")]
    	//private static extern int GetDeviceCaps(IntPtr hdc, int index);

    	//[DllImport("user32.dll")]
    	//private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        /*
    	public static Point GetDpi()
    	{
    		//SetProcessDPIAware();
    		//IntPtr windowDC = GetWindowDC(IntPtr.Zero);
    		//Point result = new Point(GetDeviceCaps(windowDC, 88), GetDeviceCaps(windowDC, 90));
    		//ReleaseDC(IntPtr.Zero, windowDC);
    		//return result;
    	}*/

    	static Med()
    	{
    		obj = new object();
    		FPS = 60.0;
    	}
    }
}
