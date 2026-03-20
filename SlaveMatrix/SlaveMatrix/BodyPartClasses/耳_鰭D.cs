using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 耳_鰭D : 耳D
    {
    	public bool 鰭耳3_鰭膜_表示 = true;

    	public bool 鰭耳3_鰭条_表示 = true;

    	public bool 鰭耳1_鰭膜_表示 = true;

    	public bool 鰭耳1_鰭条_表示 = true;

    	public bool 鰭耳2_鰭膜_表示 = true;

    	public bool 鰭耳2_鰭条_表示 = true;

    	public 耳_鰭D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 耳_鰭(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
