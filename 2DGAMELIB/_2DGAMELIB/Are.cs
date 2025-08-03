using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace _2DGAMELIB
{
    public class Are : Rect
    {
    	public Bitmap Dis;

    	protected Graphics gd;

    	protected Bitmap Hit;

    	protected Graphics gh;

    	protected double unit;

    	protected double disUnit;

    	protected double hitUnit;

    	protected Size WH = System.Drawing.Size.Empty;

    	protected Size WHH = System.Drawing.Size.Empty;

    	protected Size WHA = System.Drawing.Size.Empty;

    	private Color ClearColor = Color.Transparent;

    	public Vector2D BasePoint = Dat.Vec2DZero;

    	public Vector2D Position = Dat.Vec2DZero;

    	protected Vector2D p;

    	protected Rectangle r;

    	protected ColorMatrix cm = new ColorMatrix();

    	protected ImageAttributes ia = new ImageAttributes();

    	protected InterpolationMode im;

    	public Graphics GD => gd;

    	public Graphics GH => gh;

    	public double Unit => unit;

    	public double DisUnit => disUnit;

    	public Are() { }
    	public Are(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag)
    	{
    		Setting(Unit, XRatio, YRatio, Size, DisMag, HitMag);
    	}

    	public Are(Med Med, bool Hit)
    	{
    		if (Hit)
    		{
    			Setting(Med.Unit, Med.Base.XRatio, Med.Base.YRatio, Med.Base.Size, Med.DisQuality, Med.HitAccuracy);
    		}
    		else
    		{
    			Setting(Med.Unit, Med.Base.XRatio, Med.Base.YRatio, Med.Base.Size, Med.DisQuality);
    		}
    	}
        private void Setting(double Unit, double XRatio, double YRatio, double Size, double DisMag)
        {
            SetXYRatio(XRatio, YRatio);
            base.Size = Size;
            unit = Unit;
            disUnit = Unit * DisMag;
            WH.Width = (int)(base.LocalWidth * Unit);
            WH.Height = (int)(base.LocalHeight * Unit);
            WHA.Width = (int)(base.LocalWidth * disUnit);
            WHA.Height = (int)(base.LocalHeight * disUnit);
            Dis = new Bitmap((int)((double)WH.Width * DisMag), (int)((double)WH.Height * DisMag));
            gd = Graphics.FromImage(Dis);


            gd.SmoothingMode = SmoothingMode.None;
    		gd.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            gd.InterpolationMode = InterpolationMode.NearestNeighbor;
    		//needed for text or smthn
    		gd.CompositingMode = CompositingMode.SourceOver;
        }
        private void Setting(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag)
    	{
    		Setting(Unit, XRatio, YRatio, Size, DisMag);

    		hitUnit = Unit * HitMag;
    		WHH.Width = (int)(base.LocalWidth * hitUnit);
    		WHH.Height = (int)(base.LocalHeight * hitUnit);
    		Hit = new Bitmap(WHH.Width, WHH.Height);
    		gh = Graphics.FromImage(Hit);


    		gh.SmoothingMode = SmoothingMode.None;
    		gh.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            gh.InterpolationMode = InterpolationMode.NearestNeighbor;
            gh.CompositingMode = CompositingMode.SourceOver;
        }

    	public Vector2D GetPosition()
    	{
    		return new Vector2D(Position.X - BasePoint.X * XRatio * Size, Position.Y - BasePoint.Y * YRatio * Size);
    	}





    	public void Draw(Par Par)
    	{
    		Par.Draw(disUnit, gd);
    		if (gh != null)
    		{
    			Par.DrawH(hitUnit, gh);
    		}
    	}

    	public void Draw(ParT ParT)
    	{
    		ParT.Draw(disUnit, gd);
    		if (gh != null)
    		{
    			ParT.DrawH(hitUnit, gh);
    		}
    	}

    	public void Draw(Pars Pars)
    	{
    		Pars.Draw(disUnit, gd);
    		if (gh != null)
    		{
    			Pars.DrawH(hitUnit, gh);
    		}
    	}

    	public void Draw(Graphics GD)
    	{
    		p = GetPosition();
    		GD.DrawImage(Dis, (int)(p.X * unit), (int)(p.Y * unit), WH.Width, WH.Height);
    	}

    	public void Draw(Graphics GD, Graphics GH)
    	{
    		p = GetPosition();
    		GD.DrawImage(Dis, (int)(p.X * unit), (int)(p.Y * unit), WH.Width, WH.Height);
    		if (gh != null)
    		{
    			GH.DrawImage(Hit, (int)(p.X * hitUnit), (int)(p.Y * hitUnit), WHH.Width, WHH.Height);
    		}
    	}

    	public void Draw(Are Are)
    	{
            p = Are.GetPosition();
    		GD.DrawImage(Are.Dis, (float)(p.X * Are.disUnit), (float)(p.Y * Are.disUnit), Are.WHA.Width, Are.WHA.Height);
    		if (Are.gh != null && GH != null)
    		{
    			GH.DrawImage(Are.Hit, (int)(p.X * Are.hitUnit), (int)(p.Y * Are.hitUnit), Are.WHH.Width, Are.WHH.Height);
    		}
        }





    	public void Clear()
    	{
    		gd.Clear(ClearColor);
    		if (gh != null)
    		{
    			gh.Clear(ClearColor);
    		}
    	}

    	public void Clear(Color Color)
    	{
    		gd.Clear(Color);
    		if (gh != null)
    		{
    			gh.Clear(ClearColor);
    		}
    	}

    	public void Dispose()
    	{
    		Dis.Dispose();
    		gd.Dispose();
    		if (Hit != null)
    		{
    			Hit.Dispose();
    			gh.Dispose();
    		}
    	}
    }
}
