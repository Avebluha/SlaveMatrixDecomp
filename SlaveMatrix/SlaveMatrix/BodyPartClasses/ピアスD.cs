using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class ピアスD : ElementData
    {
    	public bool ピアス_表示;

    	public ピアスD()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new ピアス(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
