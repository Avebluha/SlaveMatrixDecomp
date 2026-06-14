using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 尾_蠍D : 尾D
    {
    	public bool 節1_尾_表示 = true;

    	public bool 節1_線_表示 = true;

    	public bool 節1_瘤左_表示 = true;

    	public bool 節1_瘤右_表示 = true;

    	public bool 節2_尾_表示 = true;

    	public bool 節2_線_表示 = true;

    	public bool 節2_瘤左_表示 = true;

    	public bool 節2_瘤右_表示 = true;

    	public bool 節3_尾_表示 = true;

    	public bool 節3_線_表示 = true;

    	public bool 節3_瘤左_表示 = true;

    	public bool 節3_瘤右_表示 = true;

    	public bool 輪1_革_表示 = true;

    	public bool 輪1_金具1_表示 = true;

    	public bool 輪1_金具2_表示 = true;

    	public bool 輪1_金具3_表示 = true;

    	public bool 輪1_金具左_表示 = true;

    	public bool 輪1_金具右_表示 = true;

    	public bool 節4_尾_表示 = true;

    	public bool 節4_線_表示 = true;

    	public bool 節4_瘤左_表示 = true;

    	public bool 節4_瘤右_表示 = true;

    	public bool 節5_尾_表示 = true;

    	public bool 節5_線_表示 = true;

    	public bool 節5_瘤左_表示 = true;

    	public bool 節5_瘤右_表示 = true;

    	public bool 針_尾針_表示 = true;

    	public bool 針_線1_表示 = true;

    	public bool 針_線2_表示 = true;

    	public bool 輪2_革_表示 = true;

    	public bool 輪2_金具1_表示 = true;

    	public bool 輪2_金具2_表示 = true;

    	public bool 輪2_金具3_表示 = true;

    	public bool 輪2_金具左_表示 = true;

    	public bool 輪2_金具右_表示 = true;

    	public bool 輪1表示 = true;

    	public bool 輪2表示 = true;

    	public bool 鎖表示;

    	public 尾_蠍D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 尾_蠍(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
