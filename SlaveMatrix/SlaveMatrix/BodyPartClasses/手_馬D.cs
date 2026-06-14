using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 手_馬D : 獣手D
    {
    	public bool 指0_表示 = true;

    	public bool 筋_表示;

    	public bool 蹄_表示 = true;

    	public bool 指1_表示 = true;

    	public bool 腕輪_革_表示;

    	public bool 腕輪_金具1_表示;

    	public bool 腕輪_金具2_表示;

    	public bool 腕輪_金具3_表示;

    	public bool 腕輪_金具左_表示;

    	public bool 腕輪_金具右_表示;

    	public bool 腕輪表示;

    	public bool 鎖表示;

    	public 手_馬D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 手_馬(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
