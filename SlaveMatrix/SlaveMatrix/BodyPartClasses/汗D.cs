using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 汗D : EleD
    {
    	public bool 汗0_表示 = true;

    	public bool 汗1_表示 = true;

    	public bool 汗ハイライト_表示 = true;

    	public bool 汗0流れ_表示 = true;

    	public 汗D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 汗(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
