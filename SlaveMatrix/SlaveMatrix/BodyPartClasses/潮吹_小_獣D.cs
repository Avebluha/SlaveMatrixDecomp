using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 潮吹_小_獣D : 潮吹_小D
    {
    	public bool 雫_表示;

    	public 潮吹_小_獣D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 潮吹_小_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
