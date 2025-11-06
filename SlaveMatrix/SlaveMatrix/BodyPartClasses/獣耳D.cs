using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 獣耳D : EleD
    {
    	public bool 獣耳外_表示 = true;

    	public bool 獣耳内_表示 = true;

    	public bool 耳毛_表示 = true;

    	public 獣耳D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 獣耳(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
