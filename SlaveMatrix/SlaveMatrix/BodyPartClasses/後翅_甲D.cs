using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 後翅_甲D : 後翅D
    {
    	public bool 後翅_後翅根_後翅_表示 = true;

    	public bool 後翅_後翅根_翅脈1_表示 = true;

    	public bool 後翅_後翅根_翅脈2_表示 = true;

    	public bool 後翅_後翅根_翅脈3_表示 = true;

    	public bool 後翅_後翅根_翅脈4_表示 = true;

    	public bool 後翅_後翅先_後翅_表示 = true;

    	public bool 後翅_後翅先_翅脈1_表示 = true;

    	public bool 後翅_後翅先_翅脈2_表示 = true;

    	public bool 後翅_後翅先_翅脈3_表示 = true;

    	public bool 後翅_後翅先_翅脈4_表示 = true;

    	public double 展開;

    	public 後翅_甲D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 後翅_甲(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
