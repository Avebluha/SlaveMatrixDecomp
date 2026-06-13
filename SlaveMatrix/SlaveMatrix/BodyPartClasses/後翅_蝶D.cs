using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 後翅_蝶D : 後翅D
    {
    	public bool 後翅_後翅_表示 = true;

    	public bool 後翅_水青_柄_表示 = true;

    	public bool 後翅_水青_紋1_表示 = true;

    	public bool 後翅_水青_紋2_表示 = true;

    	public bool 後翅_水青_紋3_表示 = true;

    	public bool 後翅_揚羽_柄1_表示 = true;

    	public bool 後翅_揚羽_柄2_表示 = true;

    	public bool 後翅_揚羽_柄3_表示 = true;

    	public bool 後翅_揚羽_柄4_表示 = true;

    	public bool 後翅_揚羽_柄5_表示 = true;

    	public bool 後翅_揚羽_柄6_表示 = true;

    	public bool 後翅_揚羽_柄7_表示 = true;

    	public bool 後翅_揚羽_柄8_表示 = true;

    	public bool 後翅_揚羽_柄9_表示 = true;

    	public bool 後翅_揚羽_柄10_表示 = true;

    	public bool 後翅_揚羽_紋1_表示 = true;

    	public bool 後翅_揚羽_紋2_表示 = true;

    	public bool 後翅_揚羽_紋3_表示 = true;

    	public bool 後翅_揚羽_紋4_表示 = true;

    	public bool 後翅_揚羽_紋5_表示 = true;

    	public bool 後翅_揚羽_紋6_表示 = true;

    	public bool 水青;

    	public 後翅_蝶D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 後翅_蝶(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
