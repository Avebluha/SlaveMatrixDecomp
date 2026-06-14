using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class SideHair_編みD : SideHairD
    {
    	public bool 髪_表示 = true;

    	public bool 編節1_髪節_表示 = true;

    	public bool 編節1_髪編目_表示 = true;

    	public bool 編節2_髪節_表示 = true;

    	public bool 編節2_髪編目_表示 = true;

    	public bool 編節3_髪節_表示 = true;

    	public bool 編節3_髪編目_表示 = true;

    	public bool 編節4_髪節_表示 = true;

    	public bool 編節4_髪編目_表示 = true;

    	public bool 髪縛1_表示 = true;

    	public bool 髪縛2_表示 = true;

    	public bool 髪左_表示 = true;

    	public bool 髪右_表示 = true;

    	public bool 髪根_表示 = true;

    	public double 髪長1;

    	public double 髪長2;

    	public double 毛量;

    	public double 広がり;

    	public SideHair_編みD()
    	{
    		ThisType = GetType();
    	}

    	public SideHair_編みD SetRandom()
    	{
    		髪長1 = Rng.XS.NextDouble();
    		髪長2 = Rng.XS.NextDouble();
    		毛量 = Rng.XS.NextDouble();
    		広がり = Rng.XS.NextDouble();
    		髪長1 = 1.0;
    		髪長2 = 1.0;
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new SideHair_編み(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
