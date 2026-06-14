using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class キスマークD : ElementData
    {
    	public bool キスマーク_表示 = true;

    	public キスマークD()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new キスマーク(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
