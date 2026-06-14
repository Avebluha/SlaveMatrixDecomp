using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 手_人D : 手D
    {
    	public bool グローブ_グローブ_表示;

    	public bool グローブ_縁1_表示;

    	public bool グローブ_縁2_表示;

    	public bool 獣性_獣毛_表示;

    	public bool 手_表示 = true;

    	public bool 獣性_肉球_表示;

    	public bool 人指_人指1_表示 = true;

    	public bool 人指_人指3_表示 = true;

    	public bool 人指_人指2_表示 = true;

    	public bool 人指_水掻_表示;

    	public bool 中指_中指1_表示 = true;

    	public bool 中指_中指3_表示 = true;

    	public bool 中指_中指2_表示 = true;

    	public bool 中指_水掻_表示;

    	public bool 薬指_薬指1_表示 = true;

    	public bool 薬指_薬指3_表示 = true;

    	public bool 薬指_薬指2_表示 = true;

    	public bool 薬指_水掻_表示;

    	public bool 小指_小指1_表示 = true;

    	public bool 小指_小指3_表示 = true;

    	public bool 小指_小指2_表示 = true;

    	public bool 親指_水掻_表示;

    	public bool 親指_親指1_表示 = true;

    	public bool 親指_獣性_肉球_表示;

    	public bool 親指_親指2_表示 = true;

    	public bool 親指_親指3_表示 = true;

    	public bool 竜性_鱗1_表示;

    	public bool 竜性_鱗2_表示;

    	public bool 竜性_鱗3_表示;

    	public bool 悪タトゥ_五芒星_円1_表示;

    	public bool 悪タトゥ_五芒星_円2_表示;

    	public bool 悪タトゥ_五芒星_星_表示;

    	public bool 悪タトゥ_五芒星_五角形_表示;

    	public double 鋭爪;

    	public bool 虫性;

    	public bool 虫手;

    	public bool 宇手;

    	public bool 獣性;

    	public bool 竜性;

    	public bool グローブ表示;

    	public 手_人D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 手_人(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
