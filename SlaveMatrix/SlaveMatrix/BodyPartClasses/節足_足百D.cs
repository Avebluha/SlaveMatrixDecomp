using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 節足_足百D : 節足D
    {
    	public bool 基節_表示 = true;

    	public bool 転節_表示 = true;

    	public bool 前腿節_表示 = true;

    	public bool 腿節_表示 = true;

    	public bool 脛節_表示 = true;

    	public bool 輪_革_表示 = true;

    	public bool 輪_金具1_表示 = true;

    	public bool 輪_金具2_表示 = true;

    	public bool 輪_金具3_表示 = true;

    	public bool 輪_金具左_表示 = true;

    	public bool 輪_金具右_表示 = true;

    	public bool 跗節1_表示 = true;

    	public bool 跗節2_表示 = true;

    	public bool 輪表示 = true;

    	public bool 鎖表示;

    	public 節足_足百D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 節足_足百(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
