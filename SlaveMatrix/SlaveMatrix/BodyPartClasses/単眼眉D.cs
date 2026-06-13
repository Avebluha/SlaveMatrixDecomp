using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 単眼眉D : ElementData
    {
    	public bool 眉_表示 = true;

    	public 単眼眉D()
    	{
    		ThisType = GetType();
    	}

    	public 単眼眉D SetRandom()
    	{
    		サイズY = RNG.XS.NextDouble();
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 単眼眉(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
