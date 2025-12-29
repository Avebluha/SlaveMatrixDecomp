using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 背中_羽D : 背中D
    {
    	public bool 羽毛1_表示 = true;

    	public bool 羽毛2_表示 = true;

    	public bool 毛 = true;

    	public 背中_羽D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 背中_羽(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
