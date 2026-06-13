using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2DGAMELIB
{
	//TODO: Find a better name...
    public class ManagedArea : RenderArea
    {
    	private double strength;

    	private double unitS;

    	public ManagedArea(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag, double Strength) : 
            base(Unit, XRatio, YRatio, Size, DisMag, HitMag)
    	{
            SetXYRatio(XRatio, YRatio);
            base.Size = Size;
            unitScale = Unit;
            strength = Strength;
            displayUnitScale = Unit * DisMag;
            double num = 1.0 - Strength;
            unitS = displayUnitScale * num;


            displayOutputSize.Width = (int)(base.LocalWidth * Unit);
            displayOutputSize.Height = (int)(base.LocalHeight * Unit);
            displayBufferSize.Width = (int)(base.LocalWidth * displayUnitScale);
            displayBufferSize.Height = (int)(base.LocalHeight * displayUnitScale);
            DisplayLayer = new Bitmap((int)((double)displayOutputSize.Width * DisMag * num), (int)((double)displayOutputSize.Height * DisMag * num));
            displayGraphics = Graphics.FromImage(DisplayLayer);
            displayGraphics.SmoothingMode = SmoothingMode.None;
            displayGraphics.PixelOffsetMode = PixelOffsetMode.None;


            hitUnitScale = Unit * HitMag;
            hitBufferSize.Width = (int)(base.LocalWidth * hitUnitScale);
            hitBufferSize.Height = (int)(base.LocalHeight * hitUnitScale);
            HitLayer = new Bitmap(hitBufferSize.Width, hitBufferSize.Height);
            hitGraphics = Graphics.FromImage(HitLayer);
            hitGraphics.SmoothingMode = SmoothingMode.None;
            hitGraphics.PixelOffsetMode = PixelOffsetMode.None;
        }

    	public new void Draw(PartGroup PartGroup)
    	{
    		PartGroup.Draw(unitS, displayGraphics);
    		if (hitGraphics != null)
    		{
    			PartGroup.DrawH(hitUnitScale, hitGraphics);
    		}
    	}
    }
}
