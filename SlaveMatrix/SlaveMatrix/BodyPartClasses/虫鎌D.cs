using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 虫鎌D : EleD
    {
    	public bool 虫鎌節_表示 = true;

    	public bool 虫棘1_表示 = true;

    	public bool 虫棘2_表示 = true;

    	public bool 虫棘3_表示 = true;

    	public bool 虫棘4_表示 = true;

    	public bool 虫鎌1_表示 = true;

    	public bool 虫鎌2_表示 = true;

    	public bool 虫鎌3_表示 = true;

    	public bool 虫孔1_表示 = true;

    	public bool 虫孔2_表示 = true;

    	public bool 輪_革_表示 = true;

    	public bool 輪_金具1_表示 = true;

    	public bool 輪_金具2_表示 = true;

    	public bool 輪_金具3_表示 = true;

    	public bool 輪_金具左_表示 = true;

    	public bool 輪_金具右_表示 = true;

    	public bool 輪表示 = true;

    	public 虫鎌D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 虫鎌(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
