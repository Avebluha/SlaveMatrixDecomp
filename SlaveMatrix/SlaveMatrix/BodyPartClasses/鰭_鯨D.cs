using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 鰭_鯨D : 鰭D
    {
    	public bool 鰭_表示 = true;

    	public 鰭_鯨D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 鰭_鯨(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
