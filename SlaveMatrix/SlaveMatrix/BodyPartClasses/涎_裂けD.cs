using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 涎_裂けD : 涎D
    {
    	public bool 涎_表示;

    	public 涎_裂けD()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 涎_裂け(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
