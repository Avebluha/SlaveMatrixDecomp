using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class ピアスD : EleD
    {
    	public bool ピアス_表示;

    	public ピアスD()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new ピアス(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
