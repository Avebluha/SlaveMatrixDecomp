using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class BackHair1_編結D : アップD
    {
    	public bool 髪基_表示 = true;

    	public bool お下げ_編節1_髪節_表示 = true;

    	public bool お下げ_編節1_髪編目_表示 = true;

    	public bool お下げ_編節2_髪節_表示 = true;

    	public bool お下げ_編節2_髪編目_表示 = true;

    	public bool お下げ_編節3_髪節_表示 = true;

    	public bool お下げ_編節3_髪編目_表示 = true;

    	public bool お下げ_編節4_髪節_表示 = true;

    	public bool お下げ_編節4_髪編目_表示 = true;

    	public bool お下げ_編節5_髪節_表示 = true;

    	public bool お下げ_編節5_髪編目_表示 = true;

    	public bool お下げ_編節6_髪節_表示 = true;

    	public bool お下げ_編節6_髪編目_表示 = true;

    	public bool お下げ_編節7_髪節_表示 = true;

    	public bool お下げ_編節7_髪編目_表示 = true;

    	public double 毛量;

    	public double 高さ;

    	public BackHair1_編結D()
    	{
    		ThisType = GetType();
    	}

    	public BackHair1_編結D SetRandom()
    	{
    		毛量 = Rng.XS.NextDouble();
    		高さ = Rng.XS.NextDouble();
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new BackHair1_編結(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
