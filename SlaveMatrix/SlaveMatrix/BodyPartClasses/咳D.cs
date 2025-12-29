using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 咳D : EleD
    {
    	public bool 咳基_表示;

    	public bool 雫1_表示;

    	public bool 雫2_表示;

    	public bool 雫3_表示;

    	public bool 雫4_表示;

    	public bool 雫5_表示;

    	public 咳D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new Cough(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
