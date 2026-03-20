using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 鼻水D : EleD
    {
    	public bool 鼻水_表示;

    	public 鼻水D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 鼻水(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
