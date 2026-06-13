using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 背中_甲D : 背中D
    {
    	public bool 左_甲羅1_表示 = true;

    	public bool 左_甲羅2_表示 = true;

    	public bool 左_鱗_鱗12_表示 = true;

    	public bool 左_鱗_鱗11_表示 = true;

    	public bool 左_鱗_鱗10_表示 = true;

    	public bool 左_鱗_鱗9_表示 = true;

    	public bool 左_鱗_鱗8_表示 = true;

    	public bool 左_鱗_鱗7_表示 = true;

    	public bool 左_鱗_鱗6_表示 = true;

    	public bool 左_鱗_鱗5_表示 = true;

    	public bool 左_鱗_鱗4_表示 = true;

    	public bool 左_鱗_鱗3_表示 = true;

    	public bool 左_鱗_鱗2_表示 = true;

    	public bool 左_鱗_鱗1_表示 = true;

    	public bool 左_側甲_側甲4_表示 = true;

    	public bool 左_側甲_側甲3_表示 = true;

    	public bool 左_側甲_側甲2_表示 = true;

    	public bool 左_側甲_側甲1_表示 = true;

    	public bool 右_甲羅1_表示 = true;

    	public bool 右_甲羅2_表示 = true;

    	public bool 右_鱗_鱗12_表示 = true;

    	public bool 右_鱗_鱗11_表示 = true;

    	public bool 右_鱗_鱗10_表示 = true;

    	public bool 右_鱗_鱗9_表示 = true;

    	public bool 右_鱗_鱗8_表示 = true;

    	public bool 右_鱗_鱗7_表示 = true;

    	public bool 右_鱗_鱗6_表示 = true;

    	public bool 右_鱗_鱗5_表示 = true;

    	public bool 右_鱗_鱗4_表示 = true;

    	public bool 右_鱗_鱗3_表示 = true;

    	public bool 右_鱗_鱗2_表示 = true;

    	public bool 右_鱗_鱗1_表示 = true;

    	public bool 右_側甲_側甲4_表示 = true;

    	public bool 右_側甲_側甲3_表示 = true;

    	public bool 右_側甲_側甲2_表示 = true;

    	public bool 右_側甲_側甲1_表示 = true;

    	public double 縁側角;

    	public 背中_甲D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 背中_甲(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
