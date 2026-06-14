using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 尾_根D : 尾D
    {
    	public bool 尾0_尾_表示 = true;

    	public bool 尾0_線1_表示 = true;

    	public bool 尾0_線2_表示 = true;

    	public bool 尾1_尾_表示 = true;

    	public bool 尾1_線1_表示 = true;

    	public bool 尾1_線2_表示 = true;

    	public bool 尾2_尾_表示 = true;

    	public bool 尾2_線1_表示 = true;

    	public bool 尾2_線2_表示 = true;

    	public bool 尾3_尾_表示 = true;

    	public bool 尾3_線1_表示 = true;

    	public bool 尾3_線2_表示 = true;

    	public bool 尾4_尾_表示 = true;

    	public bool 尾4_線1_表示 = true;

    	public bool 尾4_線2_表示 = true;

    	public bool 尾5_尾_表示 = true;

    	public bool 尾5_線1_表示 = true;

    	public bool 尾5_線2_表示 = true;

    	public bool 尾6_尾_表示 = true;

    	public bool 尾6_線1_表示 = true;

    	public bool 尾6_線2_表示 = true;

    	public bool 尾7_尾_表示 = true;

    	public bool 尾7_線1_表示 = true;

    	public bool 尾7_線2_表示 = true;

    	public bool 輪_革_表示 = true;

    	public bool 輪_金具1_表示 = true;

    	public bool 輪_金具2_表示 = true;

    	public bool 輪_金具3_表示 = true;

    	public bool 輪_金具左_表示 = true;

    	public bool 輪_金具右_表示 = true;

    	public bool 尾8_尾_表示 = true;

    	public bool 尾8_線1_表示 = true;

    	public bool 尾8_線2_表示 = true;

    	public bool 尾9_尾_表示 = true;

    	public bool 尾9_線1_表示 = true;

    	public bool 尾9_線2_表示 = true;

    	public bool 尾10_尾_表示 = true;

    	public bool 尾10_線1_表示 = true;

    	public bool 尾10_線2_表示 = true;

    	public bool 尾11_尾_表示 = true;

    	public bool 尾11_線1_表示 = true;

    	public bool 尾11_線2_表示 = true;

    	public bool 尾12_尾_表示 = true;

    	public bool 尾12_線1_表示 = true;

    	public bool 尾12_線2_表示 = true;

    	public bool 尾13_尾_表示 = true;

    	public bool 尾13_線1_表示 = true;

    	public bool 尾13_線2_表示 = true;

    	public bool 尾14_尾_表示 = true;

    	public bool 尾14_線1_表示 = true;

    	public bool 尾14_線2_表示 = true;

    	public bool 尾15_尾_表示 = true;

    	public bool 尾15_線1_表示 = true;

    	public bool 尾15_線2_表示 = true;

    	public bool 尾16_尾_表示 = true;

    	public bool 尾16_線1_表示 = true;

    	public bool 尾16_線2_表示 = true;

    	public bool 尾17_尾_表示 = true;

    	public bool 尾17_線1_表示 = true;

    	public bool 尾17_線2_表示 = true;

    	public bool 尾18_表示 = true;

    	public bool 輪表示 = true;

    	public bool 鎖表示;

    	public 尾_根D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 尾_根(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
