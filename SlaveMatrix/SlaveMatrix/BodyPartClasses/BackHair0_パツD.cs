using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class BackHair0_パツD : 下ろしD
    {
    	public bool 髪基_表示 = true;

    	public bool 髪中_表示 = true;

    	public bool 髪左1_表示 = true;

    	public bool 髪左2_表示 = true;

    	public bool 髪左3_表示 = true;

    	public bool 髪左4_表示 = true;

    	public bool 髪左5_表示 = true;

    	public bool 髪右1_表示 = true;

    	public bool 髪右2_表示 = true;

    	public bool 髪右3_表示 = true;

    	public bool 髪右4_表示 = true;

    	public bool 髪右5_表示 = true;

    	public double 髪長0;

    	public double 髪長1;

    	public double 毛量;

    	public double 広がり;

    	public bool スライム;

    	public BackHair0_パツD()
    	{
    		ThisType = GetType();
    	}

    	public BackHair0_パツD SetRandom()
    	{
    		髪長0 = RNG.XS.NextDouble();
    		髪長1 = RNG.XS.NextDouble();
    		毛量 = RNG.XS.NextDouble();
    		広がり = RNG.XS.NextDouble();
    		右 = RNG.XS.NextBool();
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new BackHair0_パツ(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
