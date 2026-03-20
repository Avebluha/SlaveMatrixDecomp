using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 下着陰核D : EleD
    {
    	public bool 陰核_表示 = true;

    	public 下着陰核D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 下着陰核(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
