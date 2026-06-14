using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class BackHair0_カルD : 下ろしD
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

    	public BackHair0_カルD()
    	{
    		ThisType = GetType();
    	}

    	public BackHair0_カルD SetRandom()
    	{
    		髪長0 = Rng.XS.NextDouble();
    		髪長1 = Rng.XS.NextDouble();
    		毛量 = Rng.XS.NextDouble();
    		広がり = Rng.XS.NextDouble();
    		右 = Rng.XS.NextBool();
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new BackHair0_カル(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
