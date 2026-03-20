using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 手_獣D : 獣手D
    {
    	public bool 手_表示 = true;

    	public bool 親指_指_表示 = true;

    	public bool 親指_爪_表示 = true;

    	public bool 小指_指_表示 = true;

    	public bool 小指_爪_表示 = true;

    	public bool 薬指_指_表示 = true;

    	public bool 薬指_爪_表示 = true;

    	public bool 中指_指_表示 = true;

    	public bool 中指_爪_表示 = true;

    	public bool 人指_指_表示 = true;

    	public bool 人指_爪_表示 = true;

    	public bool 竜性_鱗3_表示;

    	public bool 竜性_鱗2_表示;

    	public bool 竜性_鱗1_表示;

    	public 手_獣D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 手_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
