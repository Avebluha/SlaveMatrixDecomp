using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 後翅_草D : 後翅D
    {
    	public bool 後翅_後翅1_後翅_表示 = true;

    	public bool 後翅_後翅1_翅脈1_表示 = true;

    	public bool 後翅_後翅1_翅脈2_表示 = true;

    	public bool 後翅_後翅1_翅脈3_表示 = true;

    	public bool 後翅_後翅2_後翅_表示 = true;

    	public bool 後翅_後翅2_翅脈1_表示 = true;

    	public bool 後翅_後翅2_翅脈2_表示 = true;

    	public bool 後翅_後翅2_翅脈3_表示 = true;

    	public bool 後翅_後翅3_後翅_表示 = true;

    	public bool 後翅_後翅3_翅脈1_表示 = true;

    	public bool 後翅_後翅3_翅脈2_表示 = true;

    	public bool 後翅_後翅3_翅脈3_表示 = true;

    	public bool 後翅_後翅4_後翅_表示 = true;

    	public bool 後翅_後翅4_翅脈1_表示 = true;

    	public bool 後翅_後翅4_翅脈2_表示 = true;

    	public bool 後翅_後翅4_翅脈3_表示 = true;

    	public bool 後翅_後翅5_後翅_表示 = true;

    	public bool 後翅_後翅5_翅脈1_表示 = true;

    	public bool 後翅_後翅5_翅脈2_表示 = true;

    	public bool 後翅_後翅5_翅脈3_表示 = true;

    	public bool 後翅_後翅6_後翅_表示 = true;

    	public bool 後翅_後翅6_翅脈1_表示 = true;

    	public bool 後翅_後翅6_翅脈2_表示 = true;

    	public bool 後翅_後翅6_翅脈3_表示 = true;

    	public bool 後翅_後翅7_後翅_表示 = true;

    	public bool 後翅_後翅7_翅脈1_表示 = true;

    	public bool 後翅_後翅7_翅脈2_表示 = true;

    	public bool 後翅_後翅7_翅脈3_表示 = true;

    	public bool 後翅_後翅8_後翅_表示 = true;

    	public bool 後翅_後翅8_翅脈1_表示 = true;

    	public bool 後翅_後翅8_翅脈2_表示 = true;

    	public bool 後翅_後翅8_翅脈3_表示 = true;

    	public bool 後翅_後翅9_後翅_表示 = true;

    	public bool 後翅_後翅9_翅脈1_表示 = true;

    	public bool 後翅_後翅9_翅脈2_表示 = true;

    	public bool 後翅_後翅9_翅脈3_表示 = true;

    	public bool 後翅_後翅10_後翅_表示 = true;

    	public bool 後翅_後翅10_翅脈1_表示 = true;

    	public bool 後翅_後翅10_翅脈2_表示 = true;

    	public bool 後翅_後翅10_翅脈3_表示 = true;

    	public bool 後翅_後翅11_後翅_表示 = true;

    	public bool 後翅_後翅11_翅脈1_表示 = true;

    	public bool 後翅_後翅11_翅脈2_表示 = true;

    	public bool 後翅_後翅11_翅脈3_表示 = true;

    	public double 展開;

    	public 後翅_草D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 後翅_草(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
