using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 尾_龍D : 尾D
    {
    	public bool 尾40_表示 = true;

    	public bool 尾39_表示 = true;

    	public bool 尾38_表示 = true;

    	public bool 尾37_表示 = true;

    	public bool 尾36_表示 = true;

    	public bool 尾35_表示 = true;

    	public bool 尾34_表示 = true;

    	public bool 尾33_表示 = true;

    	public bool 尾32_表示 = true;

    	public bool 尾31_表示 = true;

    	public bool 尾30_表示 = true;

    	public bool 尾29_表示 = true;

    	public bool 尾28_表示 = true;

    	public bool 尾27_表示 = true;

    	public bool 尾26_表示 = true;

    	public bool 尾25_表示 = true;

    	public bool 尾24_表示 = true;

    	public bool 尾23_表示 = true;

    	public bool 尾22_表示 = true;

    	public bool 尾21_表示 = true;

    	public bool 尾20_表示 = true;

    	public bool 尾19_表示 = true;

    	public bool 尾18_表示 = true;

    	public bool 尾17_表示 = true;

    	public bool 尾16_表示 = true;

    	public bool 尾15_表示 = true;

    	public bool 輪2_革_表示 = true;

    	public bool 輪2_金具1_表示 = true;

    	public bool 輪2_金具2_表示 = true;

    	public bool 輪2_金具3_表示 = true;

    	public bool 輪2_金具左_表示 = true;

    	public bool 輪2_金具右_表示 = true;

    	public bool 尾14_表示 = true;

    	public bool 尾13_表示 = true;

    	public bool 尾12_表示 = true;

    	public bool 尾11_表示 = true;

    	public bool 尾10_表示 = true;

    	public bool 尾9_表示 = true;

    	public bool 尾8_表示 = true;

    	public bool 尾7_表示 = true;

    	public bool 尾6_表示 = true;

    	public bool 尾5_表示 = true;

    	public bool 尾4_表示 = true;

    	public bool 輪1_革_表示 = true;

    	public bool 輪1_金具1_表示 = true;

    	public bool 輪1_金具2_表示 = true;

    	public bool 輪1_金具3_表示 = true;

    	public bool 輪1_金具左_表示 = true;

    	public bool 輪1_金具右_表示 = true;

    	public bool 尾3_表示 = true;

    	public bool 尾2_表示 = true;

    	public bool 尾1_表示 = true;

    	public bool 尾0_表示 = true;

    	public bool 輪1表示 = true;

    	public bool 輪2表示 = true;

    	public bool 鎖表示;

    	public 尾_龍D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 尾_龍(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
