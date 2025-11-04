using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 涙D : EleD
    {
    	public bool 涙0流れ0_表示;

    	public bool 涙0_表示;

    	public bool 涙1_表示;

    	public bool 涙ハイライト_表示;

    	public bool 涙0流れ1_表示;

    	public 涙D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 涙(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
