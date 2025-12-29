using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 触覚_蝶D : 触覚D
    {
    	public bool 節1_表示 = true;

    	public bool 節2_表示 = true;

    	public bool 節3_表示 = true;

    	public bool 節4_表示 = true;

    	public bool 節5_表示 = true;

    	public bool 節6_表示 = true;

    	public bool 節7_表示 = true;

    	public bool 節8_表示 = true;

    	public bool 節9_表示 = true;

    	public bool 節10_表示 = true;

    	public bool 節11_表示 = true;

    	public bool 節12_表示 = true;

    	public bool 節13_表示 = true;

    	public bool 節14_表示 = true;

    	public bool 節15_表示 = true;

    	public bool 節16_表示 = true;

    	public bool 節17_表示 = true;

    	public bool 節18_表示 = true;

    	public bool 節19_表示 = true;

    	public bool 節20_表示 = true;

    	public bool 節21_表示 = true;

    	public bool 節22_表示 = true;

    	public bool 節23_表示 = true;

    	public bool 節24_表示 = true;

    	public bool 節25_表示 = true;

    	public bool 節26_表示 = true;

    	public bool 節27_表示 = true;

    	public bool 節28_表示 = true;

    	public bool 節29_表示 = true;

    	public bool 節30_表示 = true;

    	public bool 節31_表示 = true;

    	public bool 節32_表示 = true;

    	public bool 節33_表示 = true;

    	public bool 節34_表示 = true;

    	public bool 節35_表示 = true;

    	public 触覚_蝶D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 触覚_蝶(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
