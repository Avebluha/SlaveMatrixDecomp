using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 下着乳首D : EleD
    {
    	public bool 乳首_表示 = true;

    	public bool 染み2_表示 = true;

    	public bool 染み1_表示 = true;

    	public bool 染み表示 = true;

    	public double 染み濃度 = 1.0;

    	public double バスト;

    	public 下着乳首D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 下着乳首(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
