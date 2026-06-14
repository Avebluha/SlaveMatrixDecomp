using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 膣基_獣D : 膣基D
    {
    	public bool 膣基_表示;

    	public 膣基_獣D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 膣基_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
