using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 目隠帯D : ElementData
    {
    	public bool 革_表示;

    	public bool 丸金具上中_表示;

    	public bool 丸金具上左1_表示;

    	public bool 丸金具上左2_表示;

    	public bool 丸金具上左3_表示;

    	public bool 丸金具上左4_表示;

    	public bool 丸金具上左5_表示;

    	public bool 丸金具上右1_表示;

    	public bool 丸金具上右2_表示;

    	public bool 丸金具上右3_表示;

    	public bool 丸金具上右4_表示;

    	public bool 丸金具上右5_表示;

    	public bool 丸金具下左1_表示;

    	public bool 丸金具下左2_表示;

    	public bool 丸金具下左3_表示;

    	public bool 丸金具下左4_表示;

    	public bool 丸金具下左5_表示;

    	public bool 丸金具下右1_表示;

    	public bool 丸金具下右2_表示;

    	public bool 丸金具下右3_表示;

    	public bool 丸金具下右4_表示;

    	public bool 丸金具下右5_表示;

    	public 目隠帯D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 目隠帯(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
