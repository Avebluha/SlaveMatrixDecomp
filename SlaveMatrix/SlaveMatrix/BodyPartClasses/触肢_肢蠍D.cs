using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 触肢_肢蠍D : 触肢D
    {
    	public bool 爪2_表示 = true;

    	public bool 爪1_表示 = true;

    	public bool 輪2_革_表示 = true;

    	public bool 輪2_金具1_表示 = true;

    	public bool 輪2_金具2_表示 = true;

    	public bool 輪2_金具3_表示 = true;

    	public bool 輪2_金具左_表示 = true;

    	public bool 輪2_金具右_表示 = true;

    	public bool 転節_表示 = true;

    	public bool 腿節_表示 = true;

    	public bool 膝節_表示 = true;

    	public bool 輪1_革_表示 = true;

    	public bool 輪1_金具1_表示 = true;

    	public bool 輪1_金具2_表示 = true;

    	public bool 輪1_金具3_表示 = true;

    	public bool 輪1_金具左_表示 = true;

    	public bool 輪1_金具右_表示 = true;

    	public bool 輪1表示 = true;

    	public bool 輪2表示 = true;

    	public bool 鎖表示;

    	public 触肢_肢蠍D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 触肢_肢蠍(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
