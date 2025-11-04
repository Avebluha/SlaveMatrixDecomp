using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 胸毛D : EleD
    {
    	public bool 獣性_胸毛_表示;

    	public 胸毛D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 胸毛(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
