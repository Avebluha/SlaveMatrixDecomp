using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2DGAMELIB
{
    public class AreM : RenderArea
    {
    	private double strength;

    	private double unitS;

    	public AreM(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag, double Strength)
    	{
            SetXYRatio(XRatio, YRatio);
            base.Size = Size;
            unitScale = Unit;
            strength = Strength;
            displayUnitScale = Unit * DisMag;
            double num = 1.0 - Strength;
            unitS = displayUnitScale * num;


            WH.Width = (int)(base.LocalWidth * Unit);
            WH.Height = (int)(base.LocalHeight * Unit);
            WHA.Width = (int)(base.LocalWidth * displayUnitScale);
            WHA.Height = (int)(base.LocalHeight * displayUnitScale);
            DisplayLayer = new Bitmap((int)((double)WH.Width * DisMag * num), (int)((double)WH.Height * DisMag * num));
            displayGraphics = Graphics.FromImage(DisplayLayer);
            displayGraphics.SmoothingMode = SmoothingMode.None;
            displayGraphics.PixelOffsetMode = PixelOffsetMode.None;


            hitUnitScale = Unit * HitMag;
            WHH.Width = (int)(base.LocalWidth * hitUnitScale);
            WHH.Height = (int)(base.LocalHeight * hitUnitScale);
            HitLayer = new Bitmap(WHH.Width, WHH.Height);
            hitGraphics = Graphics.FromImage(HitLayer);
            hitGraphics.SmoothingMode = SmoothingMode.None;
            hitGraphics.PixelOffsetMode = PixelOffsetMode.None;
        }

    	public new void Draw(Pars Pars)
    	{
    		Pars.Draw(unitS, displayGraphics);
    		if (hitGraphics != null)
    		{
    			Pars.DrawH(hitUnitScale, hitGraphics);
    		}
    	}
    }
}
