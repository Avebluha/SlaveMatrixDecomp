using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 胸肌D : EleD
    {
    	public bool 虫性_甲殻2_表示;

    	public bool 虫性_甲殻1_虫性_表示;

    	public bool 虫性_甲殻1_甲殻左_表示;

    	public bool 虫性_甲殻1_甲殻右_表示;

    	public bool 淫タトゥ_ハート_タトゥ左1_表示;

    	public bool 淫タトゥ_ハート_タトゥ右1_表示;

    	public bool 淫タトゥ_ハート_タトゥ左2_表示;

    	public bool 淫タトゥ_ハート_タトゥ右2_表示;

    	public bool 淫タトゥ_タトゥ左_表示;

    	public bool 淫タトゥ_タトゥ右_表示;

    	public bool 悪タトゥ_逆十字_逆十字1_表示;

    	public bool 悪タトゥ_逆十字_逆十字2_表示;

    	public bool 植タトゥ_タトゥ_表示;

    	public bool 隈取_タトゥ左_表示;

    	public bool 隈取_タトゥ右_表示;

    	public bool 蜘蛛_眼左1_基_表示;

    	public bool 蜘蛛_眼左1_眼_表示;

    	public bool 蜘蛛_眼左1_ハイライト_表示;

    	public bool 蜘蛛_眼左2_基_表示;

    	public bool 蜘蛛_眼左2_眼_表示;

    	public bool 蜘蛛_眼左2_ハイライト_表示;

    	public bool 蜘蛛_眼右1_基_表示;

    	public bool 蜘蛛_眼右1_眼_表示;

    	public bool 蜘蛛_眼右1_ハイライト_表示;

    	public bool 蜘蛛_眼右2_基_表示;

    	public bool 蜘蛛_眼右2_眼_表示;

    	public bool 蜘蛛_眼右2_ハイライト_表示;

    	public bool 竜性_鱗1_表示;

    	public bool 竜性_鱗2_表示;

    	public bool 竜性_鱗3_表示;

    	public bool コア_コア2_基_表示;

    	public bool コア_コア2_コア_表示;

    	public bool コア_コア2_ハイライト_表示;

    	public bool コア_コア1_基_表示;

    	public bool コア_コア1_コア_表示;

    	public bool コア_コア1_ハイライト_表示;

    	public 胸肌D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 胸肌(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
