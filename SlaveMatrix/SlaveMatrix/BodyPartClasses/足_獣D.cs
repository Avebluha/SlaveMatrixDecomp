using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 足_獣D : 獣足D
    {
    	public bool 足_表示 = true;

    	public bool 筋_表示;

    	public bool 小指_指_表示 = true;

    	public bool 小指_爪_表示 = true;

    	public bool 小指_肉球_表示 = true;

    	public bool 薬指_指_表示 = true;

    	public bool 薬指_爪_表示 = true;

    	public bool 薬指_肉球_表示 = true;

    	public bool 中指_指_表示 = true;

    	public bool 中指_爪_表示 = true;

    	public bool 中指_肉球_表示 = true;

    	public bool 人指_指_表示 = true;

    	public bool 人指_爪_表示 = true;

    	public bool 人指_肉球_表示 = true;

    	public bool 肉球_肉球左_表示 = true;

    	public bool 肉球_肉球中_表示 = true;

    	public bool 肉球_肉球右_表示 = true;

    	public bool 脚輪_革_表示;

    	public bool 脚輪_金具1_表示;

    	public bool 脚輪_金具2_表示;

    	public bool 脚輪_金具3_表示;

    	public bool 脚輪_金具左_表示;

    	public bool 脚輪_金具右_表示;

    	public bool 脚輪表示;

    	public bool 鎖表示;

    	public 足_獣D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 足_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
