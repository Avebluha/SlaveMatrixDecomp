using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2DGAMELIB
{
    public class AreM : Are
    {
    	private double strength;

    	private double unitS;

    	public AreM(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag, double Strength)
    	{
            SetXYRatio(XRatio, YRatio);
            base.Size = Size;
            unit = Unit;
            strength = Strength;
            disUnit = Unit * DisMag;
            double num = 1.0 - Strength;
            unitS = disUnit * num;


            WH.Width = (int)(base.LocalWidth * Unit);
            WH.Height = (int)(base.LocalHeight * Unit);
            WHA.Width = (int)(base.LocalWidth * disUnit);
            WHA.Height = (int)(base.LocalHeight * disUnit);
            Dis = new Bitmap((int)((double)WH.Width * DisMag * num), (int)((double)WH.Height * DisMag * num));
            gd = Graphics.FromImage(Dis);
            gd.SmoothingMode = SmoothingMode.None;
            gd.PixelOffsetMode = PixelOffsetMode.None;


            hitUnit = Unit * HitMag;
            WHH.Width = (int)(base.LocalWidth * hitUnit);
            WHH.Height = (int)(base.LocalHeight * hitUnit);
            Hit = new Bitmap(WHH.Width, WHH.Height);
            gh = Graphics.FromImage(Hit);
            gh.SmoothingMode = SmoothingMode.None;
            gh.PixelOffsetMode = PixelOffsetMode.None;
        }

    	public new void Draw(Pars Pars)
    	{
    		Pars.Draw(unitS, gd);
    		if (gh != null)
    		{
    			Pars.DrawH(hitUnit, gh);
    		}
    	}

    }
}
