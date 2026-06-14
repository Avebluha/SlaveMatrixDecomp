using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 触覚_蠍D : 触覚D
    {
    	public bool 櫛状版1_櫛状版1_表示 = true;

    	public bool 櫛状版1_櫛状版2_表示 = true;

    	public bool 櫛状版1_櫛状版3_表示 = true;

    	public bool 櫛状版1_櫛状版4_表示 = true;

    	public bool 櫛状版1_櫛状版5_表示 = true;

    	public bool 櫛状版1_櫛状版6_表示 = true;

    	public bool 歯1_表示 = true;

    	public bool 歯2_表示 = true;

    	public bool 歯3_表示 = true;

    	public bool 歯4_表示 = true;

    	public bool 歯5_表示 = true;

    	public bool 歯6_表示 = true;

    	public bool 歯7_表示 = true;

    	public bool 歯8_表示 = true;

    	public bool 歯9_表示 = true;

    	public bool 歯10_表示 = true;

    	public bool 歯11_表示 = true;

    	public bool 歯12_表示 = true;

    	public bool 歯13_表示 = true;

    	public bool 櫛状板2_表示 = true;

    	public 触覚_蠍D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 触覚_蠍(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
