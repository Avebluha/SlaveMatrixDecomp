using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 衝撃D : EleD
    {
    	public bool 衝撃_表示 = true;

    	public 衝撃D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 衝撃(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
