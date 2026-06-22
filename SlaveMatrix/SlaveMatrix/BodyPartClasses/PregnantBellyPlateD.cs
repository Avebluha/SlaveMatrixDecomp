using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class PregnantBellyPlateD : ElementData
    {
    	public bool 腹板4_腹板_表示;

    	public bool 腹板4_縦線_表示;

    	public bool 腹板3_腹板_表示;

    	public bool 腹板3_縦線_表示;

    	public bool 腹板2_腹板_表示;

    	public bool 腹板2_縦線_表示;

    	public bool 腹板1_腹板_表示;

    	public bool 腹板1_縦線_表示;

    	public PregnantBellyPlateD()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new PregnantBellyPlate(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
