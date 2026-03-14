using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 羽根箒D : EleD
    {
    	public bool 羽根1_表示 = true;

    	public bool 羽根2_表示 = true;

    	public bool 羽根3_表示 = true;

    	public bool 羽根4_表示 = true;

    	public bool 羽根5_表示 = true;

    	public bool 羽根_表示 = true;

    	public bool 柄_表示 = true;

    	public 羽根箒D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 羽根箒(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
