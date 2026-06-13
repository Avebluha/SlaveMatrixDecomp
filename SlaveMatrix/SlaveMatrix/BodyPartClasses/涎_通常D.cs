using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 涎_通常D : 涎D
    {
    	public bool 涎_表示;

    	public 涎_通常D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 涎_通常(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
