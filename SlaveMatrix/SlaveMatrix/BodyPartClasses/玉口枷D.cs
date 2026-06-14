using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 玉口枷D : ElementData
    {
    	public bool 金具左上_表示;

    	public bool 金具左下_表示;

    	public bool 革左_表示;

    	public bool 金具右上_表示;

    	public bool 金具右下_表示;

    	public bool 革右_表示;

    	public bool 革_表示;

    	public bool 玉_表示;

    	public bool 穴中上_表示;

    	public bool 穴右_表示;

    	public bool 穴中下_表示;

    	public bool 穴左_表示;

    	public bool 穴上右上_表示;

    	public bool 穴上右下_表示;

    	public bool 穴下右上_表示;

    	public bool 穴下右下_表示;

    	public bool 穴下左下_表示;

    	public bool 穴下左上_表示;

    	public bool 穴上左下_表示;

    	public bool 穴上左上_表示;

    	public bool 丸金具左内_表示;

    	public bool 丸金具右内2_表示;

    	public bool 丸金具左外_表示;

    	public bool 丸金具右外_表示;

    	public 玉口枷D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 玉口枷(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
