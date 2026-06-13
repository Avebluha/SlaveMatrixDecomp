using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 目傷D : ElementData
    {
    	public bool 傷上_表示;

    	public bool 傷下_表示;

    	public 目傷D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 目傷(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
