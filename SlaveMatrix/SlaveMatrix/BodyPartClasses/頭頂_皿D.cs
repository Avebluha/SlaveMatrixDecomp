using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 頭頂_皿D : 頭頂D
    {
    	public bool 皿1_表示 = true;

    	public bool 皿2_表示 = true;

    	public bool 甲殻_甲殻4_表示 = true;

    	public bool 甲殻_甲殻3_表示 = true;

    	public bool 甲殻_甲殻2_表示 = true;

    	public bool 甲殻_甲殻1_表示 = true;

    	public bool 甲殻;

    	public 頭頂_皿D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 頭頂_皿(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
