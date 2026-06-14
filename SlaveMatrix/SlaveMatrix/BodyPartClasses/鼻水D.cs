using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 鼻水D : ElementData
    {
    	public bool 鼻水_表示;

    	public 鼻水D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 鼻水(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
