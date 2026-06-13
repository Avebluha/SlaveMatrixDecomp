using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 節尾_鋏D : 節尾D
    {
    	public bool 牙_表示 = true;

    	public bool 輪_革_表示 = true;

    	public bool 輪_金具1_表示 = true;

    	public bool 輪_金具2_表示 = true;

    	public bool 輪_金具3_表示 = true;

    	public bool 輪_金具左_表示 = true;

    	public bool 輪_金具右_表示 = true;

    	public bool 刺1_表示 = true;

    	public bool 刺2_表示 = true;

    	public bool 刺3_表示 = true;

    	public bool 輪表示 = true;

    	public bool 鎖表示;

    	public 節尾_鋏D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 節尾_鋏(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
