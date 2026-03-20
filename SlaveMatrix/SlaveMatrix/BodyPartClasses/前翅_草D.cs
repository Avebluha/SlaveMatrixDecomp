using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 前翅_草D : 前翅D
    {
    	public bool 前翅_前翅1_表示 = true;

    	public bool 前翅_翅脈線1_表示 = true;

    	public bool 前翅_翅脈線2_表示 = true;

    	public bool 前翅_翅脈線3_表示 = true;

    	public bool 前翅_翅脈線4_表示 = true;

    	public bool 前翅_翅脈線5_表示 = true;

    	public bool 前翅_翅脈線6_表示 = true;

    	public bool 前翅_翅脈線7_表示 = true;

    	public bool 前翅_翅脈線8_表示 = true;

    	public bool 前翅_前翅2_表示 = true;

    	public bool 前翅_紋1_表示 = true;

    	public bool 前翅_紋2_表示 = true;

    	public double 展開;

    	public 前翅_草D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 前翅_草(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
