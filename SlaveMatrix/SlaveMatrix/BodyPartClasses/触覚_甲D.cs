using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 触覚_甲D : 触覚D
    {
    	public bool 節0_表示 = true;

    	public bool 節1_表示 = true;

    	public bool 節2_表示 = true;

    	public bool 節3_表示 = true;

    	public bool 節4_表示 = true;

    	public bool 節5_表示 = true;

    	public bool 節6_表示 = true;

    	public bool 節7_表示 = true;

    	public bool 節8_表示 = true;

    	public bool 節9_表示 = true;

    	public bool 節10_表示 = true;

    	public 触覚_甲D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 触覚_甲(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
