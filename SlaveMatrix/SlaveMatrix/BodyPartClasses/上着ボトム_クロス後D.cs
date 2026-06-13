using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 上着ボトム_クロス後D : ElementData
    {
    	public bool 下地_表示;

    	public bool 染み_染み2_表示;

    	public bool 染み_染み1_表示;

    	public bool 染み表示;

    	public double 染み濃度 = 1.0;

    	public 上着ボトム_クロス後D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 上着ボトム_クロス後(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
