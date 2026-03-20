using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class キャップ1D : EleD
    {
    	public bool 根本_表示;

    	public bool 先端_表示;

    	public キャップ1D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new キャップ1(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
