using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 角2_牛1D : 角2D
    {
    	public bool 根_表示 = true;

    	public bool 凹1_表示 = true;

    	public bool 凹2_表示 = true;

    	public bool 凹3_表示 = true;

    	public bool 凹4_表示 = true;

    	public bool 凹5_表示 = true;

    	public bool 凹6_表示 = true;

    	public bool 凹7_表示 = true;

    	public bool 凹8_表示 = true;

    	public bool 線_表示 = true;

    	public 角2_牛1D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 角2_牛1(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
