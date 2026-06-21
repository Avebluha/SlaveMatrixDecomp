using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class Tounge_長D : ToungeD
    {
    	public bool Tounge1_表示 = true;

    	public bool Tounge2_表示 = true;

    	public bool Tounge3_表示 = true;

    	public bool Tounge4_表示 = true;

    	public bool Tounge5_表示 = true;

    	public bool 舌股左_Tounge1_表示;

    	public bool 舌股左_Tounge2_表示;

    	public bool 舌股左_Tounge3_表示;

    	public bool 舌股左_Tounge4_表示;

    	public bool 舌股左_Tounge5_表示;

    	public bool 舌股左_Tounge6_表示;

    	public bool 舌股右_Tounge1_表示;

    	public bool 舌股右_Tounge2_表示;

    	public bool 舌股右_Tounge3_表示;

    	public bool 舌股右_Tounge4_表示;

    	public bool 舌股右_Tounge5_表示;

    	public bool 舌股右_Tounge6_表示;

    	public bool 股舌表示;

    	public Tounge_長D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new Tounge_長(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
