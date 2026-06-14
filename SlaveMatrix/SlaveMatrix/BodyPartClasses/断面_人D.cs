using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 断面_人D : 断面D
    {
    	public bool 膣基_表示;

    	public bool 膣壁左_表示;

    	public bool 膣壁右_表示;

    	public bool 卵巣左_表示;

    	public bool 卵管左_表示;

    	public bool 卵巣右_表示;

    	public bool 卵管右_表示;

    	public bool 子宮_表示;

    	public bool 子宮内_表示;

    	public bool 子宮口_表示;

    	public bool 精液_表示;

    	public 断面_人D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 断面_人(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
