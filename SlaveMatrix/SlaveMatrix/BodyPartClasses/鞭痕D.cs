using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 鞭痕D : ElementData
    {
    	public bool 鞭痕_表示 = true;

    	public 鞭痕D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 鞭痕(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
