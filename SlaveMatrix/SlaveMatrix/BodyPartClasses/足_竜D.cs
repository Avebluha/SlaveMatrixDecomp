using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 足_竜D : 獣足D
    {
    	public bool 足_表示 = true;

    	public bool 竜性_鱗足_鱗6_表示;

    	public bool 竜性_鱗足_鱗5_表示;

    	public bool 竜性_鱗足_鱗4_表示;

    	public bool 竜性_鱗足_鱗3_表示;

    	public bool 竜性_鱗足_鱗2_表示;

    	public bool 竜性_鱗足_鱗1_表示;

    	public bool 竜性_鱗踵_鱗1_表示;

    	public bool 竜性_鱗踵_鱗2_表示;

    	public bool 竜性_鱗踵_鱗3_表示;

    	public bool 竜性_鱗甲_鱗11_表示;

    	public bool 竜性_鱗甲_鱗10_表示;

    	public bool 竜性_鱗甲_鱗9_表示;

    	public bool 竜性_鱗甲_鱗8_表示;

    	public bool 竜性_鱗甲_鱗7_表示;

    	public bool 竜性_鱗甲_鱗6_表示;

    	public bool 竜性_鱗甲_鱗5_表示;

    	public bool 竜性_鱗甲_鱗4_表示;

    	public bool 竜性_鱗甲_鱗3_表示;

    	public bool 竜性_鱗甲_鱗2_表示;

    	public bool 竜性_鱗甲_鱗1_表示;

    	public bool 薬指_指_表示 = true;

    	public bool 薬指_爪_表示 = true;

    	public bool 薬指_竜性_鱗_下_鱗1_表示;

    	public bool 薬指_竜性_鱗_下_鱗2_表示;

    	public bool 薬指_竜性_鱗_上_鱗1_表示;

    	public bool 薬指_竜性_鱗_上_鱗2_表示;

    	public bool 薬指_竜性_鱗_上_鱗3_表示;

    	public bool 中指_指_表示 = true;

    	public bool 中指_爪_表示 = true;

    	public bool 中指_竜性_鱗_下_鱗1_表示;

    	public bool 中指_竜性_鱗_下_鱗2_表示;

    	public bool 中指_竜性_鱗_上_鱗1_表示;

    	public bool 中指_竜性_鱗_上_鱗2_表示;

    	public bool 中指_竜性_鱗_上_鱗3_表示;

    	public bool 人指_指_表示 = true;

    	public bool 人指_爪_表示 = true;

    	public bool 人指_竜性_鱗_下_鱗1_表示;

    	public bool 人指_竜性_鱗_下_鱗2_表示;

    	public bool 人指_竜性_鱗_上_鱗1_表示;

    	public bool 人指_竜性_鱗_上_鱗2_表示;

    	public bool 人指_竜性_鱗_上_鱗3_表示;

    	public bool 親指_指_表示 = true;

    	public bool 親指_爪_表示 = true;

    	public bool 親指_竜性_鱗_下_鱗1_表示;

    	public bool 親指_竜性_鱗_下_鱗2_表示;

    	public bool 親指_竜性_鱗_上_鱗1_表示;

    	public bool 親指_竜性_鱗_上_鱗2_表示;

    	public bool 親指_竜性_鱗_上_鱗3_表示;

    	public bool 筋_表示;

    	public bool 脚輪_革_表示;

    	public bool 脚輪_金具1_表示;

    	public bool 脚輪_金具2_表示;

    	public bool 脚輪_金具3_表示;

    	public bool 脚輪_金具左_表示;

    	public bool 脚輪_金具右_表示;

    	public bool 脚輪表示;

    	public bool 鎖表示;

    	public 足_竜D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 足_竜(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
