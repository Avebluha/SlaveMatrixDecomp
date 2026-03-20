using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 前髪_目隠れ2D : 前髪D
    {
    	public bool 髪基_表示 = true;

    	public bool 髪左1_表示 = true;

    	public bool 編み左_編節1_髪節_表示 = true;

    	public bool 編み左_編節1_髪編目_表示 = true;

    	public bool 編み左_編節2_髪節_表示 = true;

    	public bool 編み左_編節2_髪編目_表示 = true;

    	public bool 編み左_編節3_髪節_表示 = true;

    	public bool 編み左_編節3_髪編目_表示 = true;

    	public bool 髪ハネ左_表示 = true;

    	public bool 髪左2_表示 = true;

    	public bool 髪左3_表示 = true;

    	public bool 髪左4_表示 = true;

    	public bool 髪右1_表示 = true;

    	public bool 編み右_編節1_髪節_表示 = true;

    	public bool 編み右_編節1_髪編目_表示 = true;

    	public bool 編み右_編節2_髪節_表示 = true;

    	public bool 編み右_編節2_髪編目_表示 = true;

    	public bool 編み右_編節3_髪節_表示 = true;

    	public bool 編み右_編節3_髪編目_表示 = true;

    	public bool 髪ハネ右_表示 = true;

    	public bool 髪右2_表示 = true;

    	public bool 髪右3_表示 = true;

    	public bool 髪左5_表示 = true;

    	public bool ハイライト左_表示 = true;

    	public bool ハイライト右_表示 = true;

    	public bool 髪右根1_表示 = true;

    	public bool 髪右根2_表示 = true;

    	public bool 髪右4_表示 = true;

    	public bool 髪右5_表示 = true;

    	public bool 編み左表示 = true;

    	public bool 編み右表示 = true;

    	public bool ハイライト表示 = true;

    	public double ハイライト濃度 = 1.0;

    	public double 髪長;

    	public 前髪_目隠れ2D()
    	{
    		ThisType = GetType();
    	}

    	public 前髪_目隠れ2D SetRandom()
    	{
    		髪ハネ左_表示 = RNG.XS.NextBool();
    		髪ハネ右_表示 = 髪ハネ左_表示;
    		編み左表示 = RNG.XS.NextBool();
    		編み右表示 = 編み左表示;
    		髪長 = RNG.XS.NextDouble();
    		右 = RNG.XS.NextBool();
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 前髪_目隠れ2(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
