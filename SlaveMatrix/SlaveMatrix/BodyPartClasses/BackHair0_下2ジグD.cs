using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class BackHair0_下2ジグD : お下げ2D
    {
    	public bool 髪基_表示 = true;

    	public bool お下げ左_髪縛1_表示 = true;

    	public bool お下げ左_髪縛2_表示 = true;

    	public bool お下げ左_髪左_表示 = true;

    	public bool お下げ左_髪右_表示 = true;

    	public bool お下げ左_髪根_表示 = true;

    	public bool お下げ右_髪縛1_表示 = true;

    	public bool お下げ右_髪縛2_表示 = true;

    	public bool お下げ右_髪右_表示 = true;

    	public bool お下げ右_髪左_表示 = true;

    	public bool お下げ右_髪根_表示 = true;

    	public double 髪長0;

    	public double 髪長1;

    	public double 毛量;

    	public double 広がり;

    	public bool スライム;

    	public BackHair0_下2ジグD()
    	{
    		ThisType = GetType();
    	}

    	public BackHair0_下2ジグD SetRandom()
    	{
    		髪長0 = RNG.XS.NextDouble();
    		髪長1 = RNG.XS.NextDouble();
    		毛量 = RNG.XS.NextDouble();
    		広がり = RNG.XS.NextDouble();
    		右 = RNG.XS.NextBool();
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new BackHair0_下2ジグ(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
