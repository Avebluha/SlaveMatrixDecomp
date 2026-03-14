using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 鰭_魚D : 鰭D
    {
    	public bool 鰭2_鰭膜_表示 = true;

    	public bool 鰭2_鰭条_表示 = true;

    	public bool 鰭1_鰭膜_表示 = true;

    	public bool 鰭1_鰭条_表示 = true;

    	public 鰭_魚D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 鰭_魚(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
