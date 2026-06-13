using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 潮吹_大_獣D : 潮吹_大D
    {
    	public bool 潮吹基_表示;

    	public bool 雫1_表示;

    	public bool 雫2_表示;

    	public bool 雫3_表示;

    	public bool 雫4_表示;

    	public bool 雫5_表示;

    	public bool 雫6_表示;

    	public bool 雫7_表示;

    	public bool 雫8_表示;

    	public bool 雫9_表示;

    	public bool 雫10_表示;

    	public bool 雫11_表示;

    	public bool 雫12_表示;

    	public bool 雫13_表示;

    	public bool 雫14_表示;

    	public bool 雫15_表示;

    	public bool 雫16_表示;

    	public bool 雫17_表示;

    	public bool 雫18_表示;

    	public bool 雫19_表示;

    	public bool 雫20_表示;

    	public 潮吹_大_獣D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 潮吹_大_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
