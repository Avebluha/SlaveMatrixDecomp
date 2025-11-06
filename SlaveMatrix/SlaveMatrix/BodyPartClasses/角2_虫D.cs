using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 角2_虫D : 角2D
    {
    	public bool 根_表示 = true;

    	public bool 刺_棘1_表示;

    	public bool 刺_棘2_表示;

    	public bool 刺_棘3_表示;

    	public bool 輪_革_表示 = true;

    	public bool 輪_金具1_表示 = true;

    	public bool 輪_金具2_表示 = true;

    	public bool 輪_金具3_表示 = true;

    	public bool 輪_金具左_表示 = true;

    	public bool 輪_金具右_表示 = true;

    	public bool 折線_表示 = true;

    	public bool 輪表示 = true;

    	public bool 鎖表示;

    	public 角2_虫D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 角2_虫(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
