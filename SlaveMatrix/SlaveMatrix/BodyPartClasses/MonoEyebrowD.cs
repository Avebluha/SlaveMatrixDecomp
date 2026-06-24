using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class MonoEyebrowD : ElementData
    {
    	public bool 眉_表示 = true;

    	public MonoEyebrowD()
    	{
    		ThisType = GetType();
    	}

    	public MonoEyebrowD SetRandom()
    	{
    		サイズY = Rng.XS.NextDouble();
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new MonoEyebrow(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
