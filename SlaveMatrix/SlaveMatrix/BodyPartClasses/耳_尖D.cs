using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 耳_尖D : 耳D
    {
    	public bool 耳_表示 = true;

    	public bool 耳線_表示 = true;

    	public 耳_尖D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 耳_尖(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
