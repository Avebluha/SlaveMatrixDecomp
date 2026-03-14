using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 大顎D : EleD
    {
    	public bool 刺_棘1_表示 = true;

    	public bool 刺_棘2_表示 = true;

    	public bool 刺_棘3_表示 = true;

    	public bool 牙_表示 = true;

    	public bool 線_表示 = true;

    	public bool 輪_革_表示 = true;

    	public bool 輪_金具1_表示 = true;

    	public bool 輪_金具2_表示 = true;

    	public bool 輪_金具3_表示 = true;

    	public bool 輪_金具左_表示 = true;

    	public bool 輪_金具右_表示 = true;

    	public bool 折線1_表示 = true;

    	public bool 折線2_表示 = true;

    	public bool 折線3_表示 = true;

    	public bool 穴_表示 = true;

    	public bool 輪表示 = true;

    	public bool 鎖表示;

    	public 大顎D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 大顎(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
