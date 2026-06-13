using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 葉_披D : 葉D
    {
    	public int 欠損i;

    	public bool 葉_表示 = true;

    	public bool 葉脈_表示 = true;

    	public 葉_披D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 葉_披(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
