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

    	protected Size displayOutputSize = System.Drawing.Size.Empty;
    	protected Size hitBufferSize = System.Drawing.Size.Empty;
    	protected Size displayBufferSize = System.Drawing.Size.Empty;

    	public Vector2D BasePoint = DataConsts.Vec2DZero;
    	public Vector2D Position = DataConsts.Vec2DZero;

    	public Graphics DisplayGraphics => displayGraphics;
    	public Graphics HitGraphics => hitGraphics;

    	public double UnitScale => unitScale;
    	public double DisplayUnitScale => displayUnitScale;

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
            displayOutputSize.Width = (int)(base.LocalWidth * Unit);
            displayOutputSize.Height = (int)(base.LocalHeight * Unit);
            displayBufferSize.Width = (int)(base.LocalWidth * displayUnitScale);
            displayBufferSize.Height = (int)(base.LocalHeight * displayUnitScale);
            DisplayLayer = new Bitmap(displayBufferSize.Width, displayBufferSize.Height);
            displayGraphics = Graphics.FromImage(DisplayLayer);


            displayGraphics.SmoothingMode = SmoothingMode.None;
    		displayGraphics.PixelOffsetMode = PixelOffsetMode.None;
            displayGraphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            //needed for text or smthn
            displayGraphics.CompositingMode = CompositingMode.SourceOver;
            displayGraphics.CompositingQuality = CompositingQuality.HighSpeed;
        }
        private void Setting(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag)
    	{
    		Setting(Unit, XRatio, YRatio, Size, DisMag);

    		hitUnitScale = Unit * HitMag;
    		hitBufferSize.Width = (int)(base.LocalWidth * hitUnitScale);
    		hitBufferSize.Height = (int)(base.LocalHeight * hitUnitScale);
    		HitLayer = new Bitmap(hitBufferSize.Width, hitBufferSize.Height);
    		hitGraphics = Graphics.FromImage(HitLayer);


    		hitGraphics.SmoothingMode = SmoothingMode.None;
    		hitGraphics.PixelOffsetMode = PixelOffsetMode.None;
            hitGraphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            hitGraphics.CompositingMode = CompositingMode.SourceOver;
            hitGraphics.CompositingQuality = CompositingQuality.HighSpeed;
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
            var p = Are.GetPosition();
            int x = (int)(p.X * Are.displayUnitScale);
            int y = (int)(p.Y * Are.displayUnitScale);

            if (Are.DisplayLayer.Width == Are.displayBufferSize.Width && Are.DisplayLayer.Height == Are.displayBufferSize.Height)
                DisplayGraphics.DrawImageUnscaled(Are.DisplayLayer, x, y);
            else
                DisplayGraphics.DrawImage(Are.DisplayLayer, x, y, Are.displayBufferSize.Width, Are.displayBufferSize.Height);

            if (Are.hitGraphics != null && HitGraphics != null)
            {
                HitGraphics.DrawImage(Are.HitLayer, (int)(p.X * Are.hitUnitScale), (int)(p.Y * Are.hitUnitScale), Are.hitBufferSize.Width, Are.hitBufferSize.Height);
            }
        }

        public void DrawTo(Graphics GD)
    	{
    		Vector2D p = GetPosition();
    		GD.DrawImage(DisplayLayer, (int)(p.X * unitScale), (int)(p.Y * unitScale), displayOutputSize.Width, displayOutputSize.Height);
        }

    	public void DrawTo(Graphics displayGraphics, Graphics hitGraphics)
    	{
            Vector2D p = GetPosition();
    		displayGraphics.DrawImage(DisplayLayer, (int)(p.X * unitScale), (int)(p.Y * unitScale), displayOutputSize.Width, displayOutputSize.Height);
    		if (this.hitGraphics != null && hitGraphics != null)
    		{
    			hitGraphics.DrawImage(HitLayer, (int)(p.X * hitUnitScale), (int)(p.Y * hitUnitScale), hitBufferSize.Width, hitBufferSize.Height);
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
