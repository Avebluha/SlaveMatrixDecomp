using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class ChestHairData : ElementData
    {
    	public bool 獣性_ChestHair_表示;

    	public ChestHairData()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new ChestHair(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
