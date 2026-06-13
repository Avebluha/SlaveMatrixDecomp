using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 鳳凰D : 尾D
    {
    	public bool 羽_羽_表示 = true;

    	public bool 羽_紋1_表示 = true;

    	public bool 羽_紋2_表示 = true;

    	public bool 羽2_羽_表示 = true;

    	public bool 羽2_紋1_表示 = true;

    	public bool 羽2_紋2_表示 = true;

    	public bool 羽3_羽_表示 = true;

    	public bool 羽3_紋1_表示 = true;

    	public bool 羽3_紋2_表示 = true;

    	public bool 羽4_羽_表示 = true;

    	public bool 羽4_紋1_表示 = true;

    	public bool 羽4_紋2_表示 = true;

    	public bool 羽5_羽_表示 = true;

    	public bool 羽5_紋1_表示 = true;

    	public bool 羽5_紋2_表示 = true;

    	public bool 羽6_羽_表示 = true;

    	public bool 羽6_紋1_表示 = true;

    	public bool 羽6_紋2_表示 = true;

    	public bool 羽7_羽_表示 = true;

    	public bool 羽7_紋1_表示 = true;

    	public bool 羽7_紋2_表示 = true;

    	public bool 羽8_羽_表示 = true;

    	public bool 羽8_紋1_表示 = true;

    	public bool 羽8_紋2_表示 = true;

    	public bool 羽9_羽_表示 = true;

    	public bool 羽9_紋1_表示 = true;

    	public bool 羽9_紋2_表示 = true;

    	public bool 羽10_羽_表示 = true;

    	public bool 羽10_紋1_表示 = true;

    	public bool 羽10_紋2_表示 = true;

    	public bool 羽11_羽_表示 = true;

    	public bool 羽11_紋1_表示 = true;

    	public bool 羽11_紋2_表示 = true;

    	public bool 羽12_羽_表示 = true;

    	public bool 羽12_紋1_表示 = true;

    	public bool 羽12_紋2_表示 = true;

    	public bool 羽13_羽_表示 = true;

    	public bool 羽13_紋1_表示 = true;

    	public bool 羽13_紋2_表示 = true;

    	public bool 羽14_羽_表示 = true;

    	public bool 羽14_紋1_表示 = true;

    	public bool 羽14_紋2_表示 = true;

    	public bool 羽15_羽_表示 = true;

    	public bool 羽15_紋1_表示 = true;

    	public bool 羽15_紋2_表示 = true;

    	public bool 羽16_羽_表示 = true;

    	public bool 羽16_紋1_表示 = true;

    	public bool 羽16_紋2_表示 = true;

    	public bool 羽17_羽_表示 = true;

    	public bool 羽17_紋1_表示 = true;

    	public bool 羽17_紋2_表示 = true;

    	public bool 羽18_羽_表示 = true;

    	public bool 羽18_紋1_表示 = true;

    	public bool 羽18_紋2_表示 = true;

    	public bool 羽19_羽_表示 = true;

    	public bool 羽19_紋1_表示 = true;

    	public bool 羽19_紋2_表示 = true;

    	public bool 羽20_羽_表示 = true;

    	public bool 羽20_紋1_表示 = true;

    	public bool 羽20_紋2_表示 = true;

    	public bool 羽21_羽_表示 = true;

    	public bool 羽21_紋1_表示 = true;

    	public bool 羽21_紋2_表示 = true;

    	public 鳳凰D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 鳳凰(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
