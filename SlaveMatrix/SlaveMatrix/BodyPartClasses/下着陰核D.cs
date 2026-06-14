using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 下着陰核D : ElementData
    {
    	public bool 陰核_表示 = true;

    	public 下着陰核D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 下着陰核(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
