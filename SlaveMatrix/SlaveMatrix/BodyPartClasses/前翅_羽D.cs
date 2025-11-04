using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 前翅_羽D : 前翅D
    {
    	public bool 前翅_前翅_表示 = true;

    	public bool 前翅_翅脈1_表示 = true;

    	public bool 前翅_翅脈2_表示 = true;

    	public bool 前翅_翅脈線1_表示 = true;

    	public bool 前翅_翅脈線2_表示 = true;

    	public bool 前翅_翅脈線3_表示 = true;

    	public bool 前翅_翅脈線4_表示 = true;

    	public bool 前翅_翅脈線5_表示 = true;

    	public bool 前翅_翅脈縦線1_表示 = true;

    	public bool 前翅_翅脈縦線2_表示 = true;

    	public bool 前翅_翅脈縦線3_表示 = true;

    	public bool 前翅_翅脈縦線4_表示 = true;

    	public bool 前翅_翅脈縦線5_表示 = true;

    	public bool 前翅_翅脈縦線6_表示 = true;

    	public bool 前翅_翅脈縦線7_表示 = true;

    	public bool 前翅_翅脈縦線8_表示 = true;

    	public bool 前翅_翅脈縦線9_表示 = true;

    	public bool 前翅_翅脈縦線10_表示 = true;

    	public bool 前翅_翅脈縦線11_表示 = true;

    	public bool 前翅_翅脈縦線12_表示 = true;

    	public bool 前翅_翅脈縦線13_表示 = true;

    	public bool 前翅_翅脈縦線14_表示 = true;

    	public bool 前翅_翅脈縦線15_表示 = true;

    	public bool 前翅_翅脈縦線16_表示 = true;

    	public bool 前翅_翅脈縦線17_表示 = true;

    	public bool 前翅_翅脈網1_翅脈網線1_表示 = true;

    	public bool 前翅_翅脈網1_翅脈網線2_表示 = true;

    	public bool 前翅_翅脈網1_翅脈網線3_表示 = true;

    	public bool 前翅_翅脈網2_翅脈網線1_表示 = true;

    	public bool 前翅_翅脈網2_翅脈網線2_表示 = true;

    	public bool 前翅_翅脈網2_翅脈網線3_表示 = true;

    	public 前翅_羽D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 前翅_羽(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
