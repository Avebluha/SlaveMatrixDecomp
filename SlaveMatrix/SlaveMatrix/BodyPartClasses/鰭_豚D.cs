using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 鰭_豚D : 鰭D
    {
    	public bool 鰭_表示 = true;

    	public 鰭_豚D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 鰭_豚(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
