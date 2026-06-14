using GLFW;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace _2DGAMELIB
{
    public class ModeEventDispatcher
    {
        private GlImage baseControl;

        public double Unit = 1762.4;
        public double DisQuality = 1.0;
        public double HitAccuracy = 0.5;
        private double resMag = 1.0;
        private int WidthM;
        private int HeightM;

        public bool ShowFPS;
        public bool Drive = true;

        public Rectangle Base = new Rectangle(4.0, 3.0, 0.4);

        public Bitmap Display;
        public Graphics DisplayGraphics;

        public Bitmap Hit;
        public Graphics HitGraphics;

        public SceneFader SceneFader;
        public FpsCounter FPSF = new FpsCounter(60.0);

        private Size BaseSize = Size.Empty;
        private Vector2D resVector = DataConsts.Vec2DZero;

        public string UITitle;

        private string mode;
        public string Modeb;

        private Dictionary<string, Module> Modes;
        private Func<ModeEventDispatcher, Dictionary<string, Module>> GetModes;

        public HashSet<Color> HitColors = new HashSet<Color>
        {
            Color.Transparent,
            Color.Black
        };


        //public Control BaseControlC => baseControl;

        public string Mode
        {
            get
            {
                return mode;
            }
            set
            {
                Modes[mode].Up(MouseButtons.None, DataConsts.Vec2DZero, Color.Empty);
                Modes[mode].Move(MouseButtons.None, DataConsts.Vec2DZero, Color.Empty);
                Modeb = mode;
                mode = value;
                Modes[mode].Move(MouseButtons.None, DataConsts.Vec2DZero, Color.Empty);
                Modes[mode].Setting();
            }
        }

        public Vector2D CursorPosition{
            get {
                return ToBasePosition(baseControl.GetCursorPoint()); //ToBasePosition(baseControl.PointToClient(System.Windows.Forms.Cursor.Position));        
            }

            set {
                baseControl.SetCursorPoint(FromBasePosition(value));
            }
        }
    	public ModeEventDispatcher()
    	{
    	}

    	public void FadeIn(double Rate)
    	{
    		SceneFader.TransformAlpha(DisplayGraphics, Rate);
    	}

    	public void FadeOut(double Rate)
    	{
    		SceneFader.TransD(DisplayGraphics, Rate);
    	}

    	public void InitializeModes(string Mode, Func<ModeEventDispatcher, Dictionary<string, Module>> GetModes)
    	{
    		mode = Mode;
    		this.GetModes = GetModes;
    	}

    	public Size Setting(GlImage BaseControl)
    	{
    		baseControl = BaseControl;
    		BaseSize = new Size((int)(Base.LocalWidth * Unit), (int)(Base.LocalHeight * Unit));
    		Display = new Bitmap(BaseSize.Width, BaseSize.Height);
    		DisplayGraphics = Graphics.FromImage(Display);
    		//GD.InterpolationMode = InterpolationMode.HighQualityBilinear;
            DisplayGraphics.SmoothingMode = SmoothingMode.None;
            DisplayGraphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            DisplayGraphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            //needed for text or smthn
            DisplayGraphics.CompositingMode = CompositingMode.SourceOver;

            Hit = new Bitmap((int)(BaseSize.Width * HitAccuracy), (int)(BaseSize.Height * HitAccuracy));
    		HitGraphics = Graphics.FromImage(Hit);
    		//GH.InterpolationMode = InterpolationMode.Bilinear;
            HitGraphics.SmoothingMode = SmoothingMode.None;
            HitGraphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            HitGraphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            HitGraphics.CompositingMode = CompositingMode.SourceOver;

            WidthM = Hit.Width - 1;
    		HeightM = Hit.Height - 1;
    		SceneFader = new SceneFader(BaseSize.Width, BaseSize.Height);
    		Modes = GetModes(this);


            BaseControl.Click = delegate (IntPtr window, GLFW.MouseButton button, InputState state, GLFW.ModifierKeys modifiers)
            {
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

                double x, y;
                Glfw.GetCursorPosition(GlImage.PtrToWindow(window), out x, out y);
                Vector2D Position5 = new Vector2D(x, y);
                (state == InputState.Press ? Modes[mode].Down : Modes[mode].Up)
                    (arg2, ToBasePosition(Position5), GetHitColor(Position5));
    		};

    		BaseControl.Move = delegate (IntPtr window, double x, double y)
    		{
    			Vector2D Position3 = new Vector2D(x, y);
    			Modes[mode].Move(BaseControl.GetMouseButtons(), ToBasePosition(Position3), GetHitColor(Position3));
    		};

    		BaseControl.Leave = delegate (IntPtr window, bool entered)
    		{
    			if (!entered)
    			{
    				double x, y;
    				Glfw.GetCursorPosition(GlImage.PtrToWindow(window), out x, out y);
    				Vector2D Position2 = new Vector2D(x, y);
    				Modes[mode].Leave(BaseControl.GetMouseButtons(), ToBasePosition(Position2), GetHitColor(Position2));
    			}
    		};

    		BaseControl.Scroll = delegate (IntPtr window, double xo, double yo)
    		{
                double x, y;
                Glfw.GetCursorPosition(GlImage.PtrToWindow(window), out x, out y);
    			Vector2D Position = new Vector2D(x, y);
    			//Note: yo may be inverted
                Modes[mode].Wheel(BaseControl.GetMouseButtons(), ToBasePosition(Position), (int)yo, GetHitColor(Position));
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

                int fbW, fbH;

                Glfw.GetFramebufferSize(GlImage.PtrToWindow(window), out fbW, out fbH);

                uint vpW = (uint)(BaseSize.Width / resMag);
                uint vpH = (uint)(BaseSize.Height / resMag);
                int vpX = (int)(resVector.X);
                int vpY = (int)(fbH - resVector.Y - vpH);

                baseControl.SetViewport(vpW, vpH, vpX, vpY);
            };

    		return BaseSize;
    	}

    	public Vector2D ToBasePosition(Vector2D Position)
    	{
    		return new Vector2D(((double)Position.X - resVector.X) / Unit * resMag, ((double)Position.Y - resVector.Y) / Unit * resMag);
    	}

    	public Vector2D FromBasePosition(Vector2D Position)
    	{
    		return new Vector2D(Position.X / resMag * Unit + resVector.X, Position.Y / resMag * Unit + resVector.Y);
    	}

    	public Color GetHitColor(Vector2D Position)
    	{
    		double num = HitAccuracy * resMag;
    		Point point = ((Position - resVector) * num).ToPoint();
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
    		return Hit.GetPixel(point.X, point.Y);
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
    		return Hit.GetPixel(point.X, point.Y);
    	}

    	public void Drawing()
    	{
            baseControl.BitmapSetting(Display);

            baseControl.SetTitle(UITitle);
            Modes[mode].Setting();

            FrameTimeCounter FTC = new FrameTimeCounter();
            RealFpsCounter RFC = new RealFpsCounter();

            Action action = () =>
            {
                if (FPSF.Value > 1.0)
                    Modes[mode].Draw(FPSF);

                baseControl.SetBitmap(Display);

                FTC.Frame();
                RFC.Frame();

                if (ShowFPS)
                {
                    baseControl.SetTitle(
                        UITitle +
                        " - FPS: " + RFC.Value.ToString("F1") +
                        " | Frame: " + FTC.FrameMs.ToString("F2") + " ms"
                    );
                }
            };

    		while (Drive)
    		{
    			FPSF.FPSFixed(action);
    			baseControl.PollEvents();
    		}
    	}

    	public void Draw(RenderArea Are)
    	{
            //Note: this is terribly slow...
            //would be better to not copy the entire frame
    		Are.DrawTo(DisplayGraphics, HitGraphics);
    	}

        //TODO fix?
    	public void CursorHide()
    	{
            //TODO fix?
            Glfw.SetInputMode(baseControl.window, InputMode.Cursor, (int)CursorMode.Hidden);
        }

    	public void CursorShow()
    	{
            //TODO fix?
            Glfw.SetInputMode(baseControl.window, InputMode.Cursor, (int)CursorMode.Normal);
        }

        //hit color stuff
        public Color GetUniqueColor()
    	{
    		GeometryUtils.GetRandomColor(out var ret);
    		while (HitColors.Contains(ret))
    		{
    			GeometryUtils.GetRandomColor(out ret);
    		}
    		HitColors.Add(ret);
    		return ret;
    	}

    	public void GetUniqueColor(out Color c)
    	{
    		GeometryUtils.GetRandomColor(out c);
    		while (HitColors.Contains(c))
    		{
    			GeometryUtils.GetRandomColor(out c);
    		}
    		HitColors.Add(c);
    	}

    	public void SetUniqueColor(IEnumerable<ShapePart> ps)
    	{
    		foreach (ShapePart p in ps)
    		{
    			p.SetHitColor(GetUniqueColor());
    		}
    	}

    	public void RemUniqueColor(Color Color)
    	{
    		HitColors.Remove(Color);
    	}

    	public void RemUniqueColor(IEnumerable<ShapePart> ps)
    	{
    		foreach (ShapePart p in ps)
    		{
    			HitColors.Remove(p.GetHitColor());
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

    	static ModeEventDispatcher() {}
    }
}
