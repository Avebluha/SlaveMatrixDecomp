using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class UnderwearClitorisData : ElementData
    {
    	public bool 陰核_表示 = true;

    	public UnderwearClitorisData()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new UnderwearClitoris(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
