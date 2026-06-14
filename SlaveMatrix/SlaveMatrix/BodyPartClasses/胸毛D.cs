using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 胸毛D : ElementData
    {
    	public bool 獣性_胸毛_表示;

    	public 胸毛D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 胸毛(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
