using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 性器精液_獣D : 性器精液D
    {
    	public bool 精液_表示;

    	public bool 血液1_表示;

    	public bool 血液2_表示;

    	public 性器精液_獣D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 性器精液_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
