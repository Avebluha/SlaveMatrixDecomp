using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 足_牛D : 獣足D
    {
    	public bool 足_表示 = true;

    	public bool 筋_表示;

    	public bool 指_表示 = true;

    	public bool 蹄_蹄_表示 = true;

    	public bool 蹄_蹄線_表示 = true;

    	public bool 蹄_蹄左_表示 = true;

    	public bool 蹄_蹄右_表示 = true;

    	public bool 蹄_副蹄左_表示 = true;

    	public bool 蹄_副蹄右_表示 = true;

    	public bool 脚輪_革_表示;

    	public bool 脚輪_金具1_表示;

    	public bool 脚輪_金具2_表示;

    	public bool 脚輪_金具3_表示;

    	public bool 脚輪_金具左_表示;

    	public bool 脚輪_金具右_表示;

    	public bool 脚輪表示;

    	public bool 鎖表示;

    	public 足_牛D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 足_牛(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
