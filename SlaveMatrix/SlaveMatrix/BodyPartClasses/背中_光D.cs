using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 背中_光D : 背中D
    {
    	public bool 後光左_表示 = true;

    	public bool 後光右_表示 = true;

    	public 背中_光D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 背中_光(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
