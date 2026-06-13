using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 尾鰭_鯨D : 尾鰭D
    {
    	public bool 鰭_表示 = true;

    	public bool 尾_表示 = true;

    	public 尾鰭_鯨D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 尾鰭_鯨(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
