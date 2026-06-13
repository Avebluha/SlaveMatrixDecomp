using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 節足_足蠍D : 節足D
    {
    	public bool 転節_表示 = true;

    	public bool 腿節_表示 = true;

    	public bool 柄1_表示;

    	public bool 膝節_表示 = true;

    	public bool 輪_革_表示 = true;

    	public bool 輪_金具1_表示 = true;

    	public bool 輪_金具2_表示 = true;

    	public bool 輪_金具3_表示 = true;

    	public bool 輪_金具左_表示 = true;

    	public bool 輪_金具右_表示 = true;

    	public bool 脛節_表示 = true;

    	public bool 蹠節_表示 = true;

    	public bool 跗節1_表示 = true;

    	public bool 跗節2_表示 = true;

    	public bool 爪_爪1_表示 = true;

    	public bool 爪_爪2_表示 = true;

    	public bool 輪表示 = true;

    	public bool 爪;

    	public bool 鎖表示;

    	public 節足_足蠍D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 節足_足蠍(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
