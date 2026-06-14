using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 尾鰭_魚D : 尾鰭D
    {
    	public bool 鰭左2_鰭膜_表示 = true;

    	public bool 鰭左2_鰭条_表示 = true;

    	public bool 鰭右2_鰭膜_表示 = true;

    	public bool 鰭右2_鰭条_表示 = true;

    	public bool 鰭左1_鰭膜_表示 = true;

    	public bool 鰭左1_鰭条_表示 = true;

    	public bool 鰭右1_鰭膜_表示 = true;

    	public bool 鰭右1_鰭条_表示 = true;

    	public bool 尾_尾_表示 = true;

    	public bool 尾_鱗右3_表示 = true;

    	public bool 尾_鱗左3_表示 = true;

    	public bool 尾_鱗右2_表示 = true;

    	public bool 尾_鱗左2_表示 = true;

    	public bool 尾_鱗右1_表示 = true;

    	public bool 尾_鱗左1_表示 = true;

    	public double 展開;

    	public 尾鰭_魚D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 尾鰭_魚(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
