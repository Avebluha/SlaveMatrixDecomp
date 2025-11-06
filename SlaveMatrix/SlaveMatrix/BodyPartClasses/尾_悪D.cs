using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 尾_悪D : 尾D
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

    	public bool 輪_革_表示 = true;

    	public bool 輪_金具1_表示 = true;

    	public bool 輪_金具2_表示 = true;

    	public bool 輪_金具3_表示 = true;

    	public bool 輪_金具左_表示 = true;

    	public bool 輪_金具右_表示 = true;

    	public bool 尾9_表示 = true;

    	public bool 尾10_表示 = true;

    	public bool 尾11_表示 = true;

    	public bool 尾12_表示 = true;

    	public bool 尾13_表示 = true;

    	public bool 尾14_表示 = true;

    	public bool 尾15_表示 = true;

    	public bool 尾16_表示 = true;

    	public bool 尾17_表示 = true;

    	public bool 先端_先_表示 = true;

    	public bool 先端_尾_表示 = true;

    	public bool 輪表示 = true;

    	public bool 鎖表示;

    	public 尾_悪D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 尾_悪(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
