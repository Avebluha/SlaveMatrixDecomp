using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 鞭痕D : EleD
    {
    	public bool 鞭痕_表示 = true;

    	public 鞭痕D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 鞭痕(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
