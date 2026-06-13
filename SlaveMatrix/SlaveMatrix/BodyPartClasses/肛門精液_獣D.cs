using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 肛門精液_獣D : 肛門精液D
    {
    	public bool 精液_表示;

    	public 肛門精液_獣D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 肛門精液_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
