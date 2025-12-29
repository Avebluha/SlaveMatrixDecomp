using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace _2DGAMELIB
{
    //Render Area
    public class RenderArea : Rectangle
    {
        //Display Layer
    	public Bitmap DisplayLayer;
        //Hit Layer
        public Bitmap HitLayer;

    	protected Graphics displayGraphics;
    	protected Graphics hitGraphics;

    	protected double unitScale;
    	protected double displayUnitScale;
    	protected double hitUnitScale;

    	protected Size WH = System.Drawing.Size.Empty;
    	protected Size WHH = System.Drawing.Size.Empty;
    	protected Size WHA = System.Drawing.Size.Empty;

    	public Vector2D BasePoint = Dat.Vec2DZero;
    	public Vector2D Position = Dat.Vec2DZero;

    	public Graphics DisplayGraphics => displayGraphics;
    	public Graphics HitGraphics => hitGraphics;

    	public double UnitScale => unitScale;
    	public double DisplayUnitScale => displayUnitScale;

    	public RenderArea() { }
    	public RenderArea(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag)
    	{
    		Setting(Unit, XRatio, YRatio, Size, DisMag, HitMag);
    	}

    	public RenderArea(ModeEventDispatcher Med, bool Hit)
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
            unitScale = Unit;
            displayUnitScale = Unit * DisMag;
            WH.Width = (int)(base.LocalWidth * Unit);
            WH.Height = (int)(base.LocalHeight * Unit);
            WHA.Width = (int)(base.LocalWidth * displayUnitScale);
            WHA.Height = (int)(base.LocalHeight * displayUnitScale);
            DisplayLayer = new Bitmap((int)((double)WH.Width * DisMag), (int)((double)WH.Height * DisMag));
            displayGraphics = Graphics.FromImage(DisplayLayer);


            displayGraphics.SmoothingMode = SmoothingMode.None;
    		displayGraphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            displayGraphics.InterpolationMode = InterpolationMode.NearestNeighbor;
    		//needed for text or smthn
    		displayGraphics.CompositingMode = CompositingMode.SourceOver;
        }
        private void Setting(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag)
    	{
    		Setting(Unit, XRatio, YRatio, Size, DisMag);

    		hitUnitScale = Unit * HitMag;
    		WHH.Width = (int)(base.LocalWidth * hitUnitScale);
    		WHH.Height = (int)(base.LocalHeight * hitUnitScale);
    		HitLayer = new Bitmap(WHH.Width, WHH.Height);
    		hitGraphics = Graphics.FromImage(HitLayer);


    		hitGraphics.SmoothingMode = SmoothingMode.None;
    		hitGraphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            hitGraphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            hitGraphics.CompositingMode = CompositingMode.SourceOver;
        }

    	public Vector2D GetPosition()
    	{
    		return new Vector2D(Position.X - BasePoint.X * XRatio * Size, Position.Y - BasePoint.Y * YRatio * Size);
    	}

    	public void Draw(Par Par)
    	{
    		Par.Draw(displayUnitScale, displayGraphics);
    		if (hitGraphics != null)
    		{
    			Par.DrawH(hitUnitScale, hitGraphics);
    		}
    	}

    	public void Draw(ParT ParT)
    	{
    		ParT.Draw(displayUnitScale, displayGraphics);
    		if (hitGraphics != null)
    		{
    			ParT.DrawH(hitUnitScale, hitGraphics);
    		}
    	}

    	public void Draw(Pars Pars)
    	{
    		Pars.Draw(displayUnitScale, displayGraphics);
    		if (hitGraphics != null)
    		{
    			Pars.DrawH(hitUnitScale, hitGraphics);
    		}
    	}

        public void Draw(RenderArea Are)
        {
            Vector2D p = Are.GetPosition();
            DisplayGraphics.DrawImage(Are.DisplayLayer, (float)(p.X * Are.displayUnitScale), (float)(p.Y * Are.displayUnitScale), Are.WHA.Width, Are.WHA.Height);
            if (Are.hitGraphics != null && HitGraphics != null)
            {
                HitGraphics.DrawImage(Are.HitLayer, (int)(p.X * Are.hitUnitScale), (int)(p.Y * Are.hitUnitScale), Are.WHH.Width, Are.WHH.Height);
            }
        }

        public void DrawTo(Graphics GD)
    	{
    		Vector2D p = GetPosition();
    		GD.DrawImage(DisplayLayer, (int)(p.X * unitScale), (int)(p.Y * unitScale), WH.Width, WH.Height);
    	}

    	public void DrawTo(Graphics displayGraphics, Graphics hitGraphics)
    	{
            Vector2D p = GetPosition();
    		displayGraphics.DrawImage(DisplayLayer, (int)(p.X * unitScale), (int)(p.Y * unitScale), WH.Width, WH.Height);
    		if (this.hitGraphics != null)
    		{
    			hitGraphics.DrawImage(HitLayer, (int)(p.X * hitUnitScale), (int)(p.Y * hitUnitScale), WHH.Width, WHH.Height);
    		}
    	}

    	public void Clear()
    	{
    		displayGraphics.Clear(Color.Transparent);
    		if (hitGraphics != null)
    		{
    			hitGraphics.Clear(Color.Transparent);
    		}
    	}

    	public void Clear(Color Color)
    	{
    		displayGraphics.Clear(Color);
    		if (hitGraphics != null)
    		{
    			hitGraphics.Clear(Color.Transparent);
    		}
    	}

    	public void Dispose()
    	{
    		DisplayLayer.Dispose();
    		displayGraphics.Dispose();
    		if (HitLayer != null)
    		{
    			HitLayer.Dispose();
    			hitGraphics.Dispose();
    		}
    	}
    }
}
