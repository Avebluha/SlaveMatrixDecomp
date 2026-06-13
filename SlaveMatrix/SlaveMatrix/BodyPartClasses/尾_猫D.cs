using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 尾_猫D : 尾D
    {
    	public bool 尾0_表示 = true;

    	public bool 尾1_表示 = true;

    	public bool 尾2_表示 = true;

    	public bool 尾3_表示 = true;

    	public bool 尾4_表示 = true;

    	public bool 尾5_表示 = true;

    	public bool 尾6_表示 = true;

    	public bool 尾7_表示 = true;

    	public bool 尾8_表示 = true;

    	public bool 尾9_表示 = true;

    	public bool 尾10_表示 = true;

    	public bool 尾11_表示 = true;

    	public bool 尾12_表示 = true;

    	public bool 尾13_表示 = true;

    	public 尾_猫D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 尾_猫(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
