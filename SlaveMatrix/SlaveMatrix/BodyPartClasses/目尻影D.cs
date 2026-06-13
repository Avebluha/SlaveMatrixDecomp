using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 目尻影D : ElementData
    {
    	public bool 目尻影_表示;

    	public 目尻影D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 目尻影(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
