using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 角1_虫D : 角1D
    {
    	public bool 根_表示 = true;

    	public bool 器官左_器官1_表示 = true;

    	public bool 器官左_器官2_表示 = true;

    	public bool 器官右_器官1_表示 = true;

    	public bool 器官右_器官2_表示 = true;

    	public bool 線_表示 = true;

    	public bool 折線1_表示 = true;

    	public bool 折線2_表示 = true;

    	public double 展開;

    	public 角1_虫D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 角1_虫(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
