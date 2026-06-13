using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 虫顎D : EleD
    {
    	public bool 顎_表示 = true;

    	public bool 節_表示 = true;

    	public bool 牙_牙1_表示 = true;

    	public bool 牙_牙2_表示 = true;

    	public bool 牙_牙0_表示 = true;

    	public 虫顎D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 虫顎(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
