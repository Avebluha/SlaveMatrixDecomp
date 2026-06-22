using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class TorsoPlateD : ElementData
    {
    	public bool 虫性_腹板_表示;

    	public bool 虫性_縦線_表示;

    	public TorsoPlateD()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new TorsoPlate(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
