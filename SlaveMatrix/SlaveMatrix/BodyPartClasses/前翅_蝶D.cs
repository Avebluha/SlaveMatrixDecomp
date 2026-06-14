using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 前翅_蝶D : 前翅D
    {
    	public bool 前翅_前翅_表示 = true;

    	public bool 前翅_水青_柄_表示 = true;

    	public bool 前翅_水青_縁柄_表示 = true;

    	public bool 前翅_水青_紋1_表示 = true;

    	public bool 前翅_水青_紋2_表示 = true;

    	public bool 前翅_揚羽_柄1_表示 = true;

    	public bool 前翅_揚羽_柄2_表示 = true;

    	public bool 前翅_揚羽_柄3_表示 = true;

    	public bool 前翅_揚羽_柄4_表示 = true;

    	public bool 前翅_揚羽_柄5_表示 = true;

    	public bool 前翅_揚羽_柄6_表示 = true;

    	public bool 前翅_揚羽_柄7_表示 = true;

    	public bool 前翅_揚羽_柄8_表示 = true;

    	public bool 前翅_揚羽_柄9_表示 = true;

    	public bool 前翅_揚羽_柄10_表示 = true;

    	public bool 前翅_揚羽_紋1_表示 = true;

    	public bool 前翅_揚羽_紋2_表示 = true;

    	public bool 前翅_揚羽_紋3_表示 = true;

    	public bool 前翅_揚羽_紋4_表示 = true;

    	public bool 前翅_揚羽_紋5_表示 = true;

    	public bool 前翅_揚羽_紋6_表示 = true;

    	public bool 水青;

    	public 前翅_蝶D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 前翅_蝶(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
