using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 眉D : ElementData
    {
    	public bool 眉_表示 = true;

    	public bool 眉間_表示;

    	public 眉D()
    	{
    		ThisType = GetType();
    	}

    	public 眉D SetRandom()
    	{
    		サイズY = RNG.XS.NextDouble();
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 眉(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
