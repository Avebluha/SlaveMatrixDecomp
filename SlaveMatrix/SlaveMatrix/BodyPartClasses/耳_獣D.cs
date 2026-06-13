using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 耳_獣D : 耳D
    {
    	public bool 耳_表示 = true;

    	public bool 耳線1_表示 = true;

    	public bool 耳線2_表示 = true;

    	public 耳_獣D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 耳_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
