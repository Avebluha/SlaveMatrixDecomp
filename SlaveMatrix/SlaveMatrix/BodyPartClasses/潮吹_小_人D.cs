using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 潮吹_小_人D : 潮吹_小D
    {
    	public bool 雫_表示;

    	public 潮吹_小_人D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 潮吹_小_人(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
