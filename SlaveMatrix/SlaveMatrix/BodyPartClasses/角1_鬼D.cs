using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 角1_鬼D : 角1D
    {
    	public bool 根_表示 = true;

    	public bool 線1_表示 = true;

    	public bool 線2_表示 = true;

    	public bool 線3_表示 = true;

    	public bool 線4_表示 = true;

    	public bool 線5_表示 = true;

    	public bool 折線1_表示 = true;

    	public bool 折線2_表示 = true;

    	public 角1_鬼D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 角1_鬼(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
