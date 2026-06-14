using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 舌_長D : 舌D
    {
    	public bool 舌1_表示 = true;

    	public bool 舌2_表示 = true;

    	public bool 舌3_表示 = true;

    	public bool 舌4_表示 = true;

    	public bool 舌5_表示 = true;

    	public bool 舌股左_舌1_表示;

    	public bool 舌股左_舌2_表示;

    	public bool 舌股左_舌3_表示;

    	public bool 舌股左_舌4_表示;

    	public bool 舌股左_舌5_表示;

    	public bool 舌股左_舌6_表示;

    	public bool 舌股右_舌1_表示;

    	public bool 舌股右_舌2_表示;

    	public bool 舌股右_舌3_表示;

    	public bool 舌股右_舌4_表示;

    	public bool 舌股右_舌5_表示;

    	public bool 舌股右_舌6_表示;

    	public bool 股舌表示;

    	public 舌_長D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 舌_長(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
