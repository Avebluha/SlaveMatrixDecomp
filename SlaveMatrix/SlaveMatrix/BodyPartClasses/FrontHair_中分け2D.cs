using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class FrontHair_中分け2D : FrontHairData
    {
    	public bool 髪基_表示 = true;

    	public bool 髪左1_表示 = true;

    	public bool 髪左2_表示 = true;

    	public bool 髪左3_表示 = true;

    	public bool 編み左_編節1_髪節_表示 = true;

    	public bool 編み左_編節1_髪編目_表示 = true;

    	public bool 編み左_編節2_髪節_表示 = true;

    	public bool 編み左_編節2_髪編目_表示 = true;

    	public bool 編み左_編節3_髪節_表示 = true;

    	public bool 編み左_編節3_髪編目_表示 = true;

    	public bool 髪ハネ左_表示 = true;

    	public bool ハイライト左_表示 = true;

    	public bool 髪左4_表示 = true;

    	public bool 髪右1_表示 = true;

    	public bool 髪右2_表示 = true;

    	public bool 髪右3_表示 = true;

    	public bool 編み右_編節1_髪節_表示 = true;

    	public bool 編み右_編節1_髪編目_表示 = true;

    	public bool 編み右_編節2_髪節_表示 = true;

    	public bool 編み右_編節2_髪編目_表示 = true;

    	public bool 編み右_編節3_髪節_表示 = true;

    	public bool 編み右_編節3_髪編目_表示 = true;

    	public bool 髪ハネ右_表示 = true;

    	public bool ハイライト右_表示 = true;

    	public bool 髪右4_表示 = true;

    	public bool 編み左表示 = true;

    	public bool 編み右表示 = true;

    	public bool ハイライト表示 = true;

    	public double ハイライト濃度 = 1.0;

    	public double 髪長;

    	public FrontHair_中分け2D()
    	{
    		ThisType = GetType();
    	}

    	public FrontHair_中分け2D SetRandom()
    	{
    		髪ハネ左_表示 = Rng.XS.NextBool();
    		髪ハネ右_表示 = 髪ハネ左_表示;
    		編み左表示 = Rng.XS.NextBool();
    		編み右表示 = 編み左表示;
    		髪長 = Rng.XS.NextDouble();
    		右 = Rng.XS.NextBool();
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new FrontHair_中分け2(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
