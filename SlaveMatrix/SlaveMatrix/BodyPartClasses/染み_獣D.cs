using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 染み_獣D : ElementData
    {
    	public bool 潮1_表示 = true;

    	public bool 潮2_表示 = true;

    	public bool 潮3_表示 = true;

    	public bool 尿1_表示 = true;

    	public bool 尿2_表示 = true;

    	public bool 汗_表示 = true;

    	public bool 湯気_湯気左1_湯気1_表示 = true;

    	public bool 湯気_湯気左1_湯気2_表示 = true;

    	public bool 湯気_湯気左2_湯気1_表示 = true;

    	public bool 湯気_湯気左2_湯気2_表示 = true;

    	public bool 湯気_湯気左3_湯気1_表示 = true;

    	public bool 湯気_湯気左3_湯気2_表示 = true;

    	public bool 湯気_湯気右1_湯気1_表示 = true;

    	public bool 湯気_湯気右1_湯気2_表示 = true;

    	public bool 湯気_湯気右2_湯気1_表示 = true;

    	public bool 湯気_湯気右2_湯気2_表示 = true;

    	public bool 湯気_湯気右3_湯気1_表示 = true;

    	public bool 湯気_湯気右3_湯気2_表示 = true;

    	public 染み_獣D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 染み_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
