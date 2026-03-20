using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 鼻肌D : EleD
    {
    	public bool 紋柄_紋左_紋1_表示;

    	public bool 紋柄_紋左_紋2_表示;

    	public bool 紋柄_紋左_紋3_表示;

    	public bool 紋柄_紋左_紋4_表示;

    	public bool 紋柄_紋左_紋5_表示;

    	public bool 紋柄_紋右_紋1_表示;

    	public bool 紋柄_紋右_紋2_表示;

    	public bool 紋柄_紋右_紋3_表示;

    	public bool 紋柄_紋右_紋4_表示;

    	public bool 紋柄_紋右_紋5_表示;

    	public bool 傷I_表示;

    	public double 傷I右濃度 = 1.0;

    	public 鼻肌D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 鼻肌(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
