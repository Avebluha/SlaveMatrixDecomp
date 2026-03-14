using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 頬肌D : EleD
    {
    	public bool 淫タトゥ_ハート_タトゥ左_表示;

    	public bool 淫タトゥ_ハート_タトゥ右_表示;

    	public bool 隈取_タトゥ1_表示;

    	public bool 隈取_タトゥ2_表示;

    	public bool 紋柄_紋1_表示;

    	public bool 紋柄_紋2_表示;

    	public bool 紋柄_紋3_表示;

    	public bool 傷_傷X_表示;

    	public bool 傷_傷I1_表示;

    	public bool 傷_傷I2_表示;

    	public bool 傷_傷I3_表示;

    	public bool 蜘蛛_眼_基_表示;

    	public bool 蜘蛛_眼_眼_表示;

    	public bool 蜘蛛_眼_ハイライト_表示;

    	public bool 百足_眼1_基_表示;

    	public bool 百足_眼1_眼_表示;

    	public bool 百足_眼1_ハイライト_表示;

    	public bool 百足_眼2_基_表示;

    	public bool 百足_眼2_眼_表示;

    	public bool 百足_眼2_ハイライト_表示;

    	public bool 百足_眼3_基_表示;

    	public bool 百足_眼3_眼_表示;

    	public bool 百足_眼3_ハイライト_表示;

    	public bool 獣性_獣毛_表示;

    	public bool 獣性_髭1_表示;

    	public bool 獣性_髭2_表示;

    	public bool 獣性_髭3_表示;

    	public bool 竜性_鱗1_表示;

    	public bool 竜性_鱗2_表示;

    	public bool 竜性_鱗3_表示;

    	public bool 猟豹_タトゥ_表示;

    	public bool 牛柄_牛柄_表示;

    	public 頬肌D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 頬肌(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
