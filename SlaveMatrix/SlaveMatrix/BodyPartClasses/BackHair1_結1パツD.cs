using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class BackHair1_結1パツD : アップD
    {
    	public bool 髪基_表示 = true;

    	public bool お下げ_髪根_表示 = true;

    	public bool お下げ_髪左1_表示 = true;

    	public bool お下げ_髪左2_表示 = true;

    	public bool お下げ_髪左3_表示 = true;

    	public bool お下げ_髪右1_表示 = true;

    	public bool お下げ_髪右2_表示 = true;

    	public bool お下げ_髪右3_表示 = true;

    	public double 髪長;

    	public double 毛量;

    	public double 広がり;

    	public double 高さ;

    	public BackHair1_結1パツD()
    	{
    		ThisType = GetType();
    	}

    	public BackHair1_結1パツD SetRandom()
    	{
    		髪長 = RNG.XS.NextDouble();
    		毛量 = RNG.XS.NextDouble();
    		広がり = RNG.XS.NextDouble();
    		高さ = RNG.XS.NextDouble();
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new BackHair1_結1パツ(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
