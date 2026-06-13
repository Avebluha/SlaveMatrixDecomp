using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class BackHair1_結2ジグD : サイドD
    {
    	public bool 髪基_表示 = true;

    	public bool お下げ左_髪左根_表示 = true;

    	public bool お下げ左_髪左1_表示 = true;

    	public bool お下げ左_髪左2_表示 = true;

    	public bool お下げ右_髪右根_表示 = true;

    	public bool お下げ右_髪右1_表示 = true;

    	public bool お下げ右_髪右2_表示 = true;

    	public double 髪長;

    	public double 毛量;

    	public double 広がり;

    	public double 高さ;

    	public BackHair1_結2ジグD()
    	{
    		ThisType = GetType();
    	}

    	public BackHair1_結2ジグD SetRandom()
    	{
    		髪長 = RNG.XS.NextDouble();
    		毛量 = RNG.XS.NextDouble();
    		広がり = RNG.XS.NextDouble();
    		高さ = RNG.XS.NextDouble();
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new BackHair1_結2ジグ(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
