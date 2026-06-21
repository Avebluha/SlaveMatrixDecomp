using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class Tounge_短D : ToungeD
    {
    	public bool Tounge1_表示 = true;

    	public bool Tounge2_表示 = true;

    	public bool Tounge3_表示 = true;

    	public bool Tounge4_表示 = true;

    	public bool Tounge5_表示 = true;

    	public Tounge_短D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new Tounge_短(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
