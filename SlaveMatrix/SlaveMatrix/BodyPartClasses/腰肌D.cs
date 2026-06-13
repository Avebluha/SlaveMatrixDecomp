using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 腰肌D : EleD
    {
    	public bool 淫タトゥ_ハート_タトゥ左1_表示;

    	public bool 淫タトゥ_ハート_タトゥ右1_表示;

    	public bool 淫タトゥ_ハート_タトゥ左2_表示;

    	public bool 淫タトゥ_ハート_タトゥ右2_表示;

    	public bool 淫タトゥ_タトゥ1左_表示;

    	public bool 淫タトゥ_タトゥ1右_表示;

    	public bool 淫タトゥ_タトゥ2左_表示;

    	public bool 淫タトゥ_タトゥ2右_表示;

    	public bool 植タトゥ_タトゥ左_表示;

    	public bool 植タトゥ_タトゥ右_表示;

    	public bool 陰毛_ハート_表示;

    	public bool 獣性_獣毛_表示;

    	public bool 陰毛_表示;

    	public bool 竜性_鱗1_表示;

    	public bool 竜性_鱗2_表示;

    	public bool 竜性_鱗3_表示;

    	public bool 竜性_鱗4_表示;

    	public bool 虫性_腹板2_腹板_表示;

    	public bool 虫性_腹板2_縦線_表示;

    	public bool 虫性_腹板1_腹板_表示;

    	public bool 虫性_腹板1_縦線_表示;

    	public 腰肌D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 腰肌(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
