using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 手_蝙D : 翼手D
    {
    	public bool 獣翼手_表示 = true;

    	public bool 小指_指1_表示 = true;

    	public bool 小指_指2_表示 = true;

    	public bool 小指_指3_表示 = true;

    	public bool 薬指_指1_表示 = true;

    	public bool 薬指_指2_表示 = true;

    	public bool 薬指_指3_表示 = true;

    	public bool 中指_指1_表示 = true;

    	public bool 中指_指2_表示 = true;

    	public bool 中指_指3_表示 = true;

    	public bool 人指_指1_表示 = true;

    	public bool 人指_指2_表示 = true;

    	public bool 人指_指3_表示 = true;

    	public bool 親指_指1_表示 = true;

    	public bool 親指_指2_表示 = true;

    	public bool 親指_指3_表示 = true;

    	public bool 飛膜_表示 = true;

    	public double 展開;

    	public double シャープ;

    	public bool 下部_外線;

    	public bool 接部_外線;

    	public bool カーブ;

    	public 手_蝙D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 手_蝙(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
