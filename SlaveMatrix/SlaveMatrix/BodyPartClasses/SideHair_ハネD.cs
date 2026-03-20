using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class SideHair_ハネD : SideHairD
    {
    	public bool 髪1_表示 = true;

    	public bool 髪2_表示 = true;

    	public double 髪長1;

    	public double 髪長2;

    	public double 毛量;

    	public double 広がり;

    	public SideHair_ハネD()
    	{
    		ThisType = GetType();
    	}

    	public SideHair_ハネD SetRandom()
    	{
    		髪長1 = RNG.XS.NextDouble();
    		髪長2 = RNG.XS.NextDouble();
    		毛量 = RNG.XS.NextDouble();
    		広がり = RNG.XS.NextDouble();
    		髪長1 = 1.0;
    		髪長2 = 1.0;
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new SideHair_ハネ(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
