using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class InternalSemen_人D : InternalSemenD
    {
    	public bool 精液_表示 = true;

    	public bool 血液1_表示;

    	public bool 血液2_表示;

    	public InternalSemen_人D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new InternalSemen_人(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
