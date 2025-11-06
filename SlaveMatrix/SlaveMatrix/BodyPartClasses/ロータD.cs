using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class ロータD : EleD
    {
    	public bool ロータ_表示 = true;

    	public bool ロータ線_表示 = true;

    	public bool コード_表示 = true;

    	public ロータD()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new ロータ(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
