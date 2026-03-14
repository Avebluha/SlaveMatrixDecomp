using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 節尾_曳航D : 節尾D
    {
    	public bool 前腿節_表示 = true;

    	public bool 腿節_表示 = true;

    	public bool 輪_革_表示 = true;

    	public bool 輪_金具1_表示 = true;

    	public bool 輪_金具2_表示 = true;

    	public bool 輪_金具3_表示 = true;

    	public bool 輪_金具左_表示 = true;

    	public bool 輪_金具右_表示 = true;

    	public bool 脛節_表示 = true;

    	public bool 付節1_表示 = true;

    	public bool 付節2_表示 = true;

    	public bool 輪表示 = true;

    	public bool 鎖表示;

    	public 節尾_曳航D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 節尾_曳航(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
