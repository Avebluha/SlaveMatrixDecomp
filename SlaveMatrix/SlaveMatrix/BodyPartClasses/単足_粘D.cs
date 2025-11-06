using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 単足_粘D : 半身D
    {
    	public bool 粘液0_表示 = true;

    	public bool 粘液1_表示 = true;

    	public bool 粘液2_粘液_表示 = true;

    	public bool 粘液2_ハイライト左_表示 = true;

    	public bool 粘液2_ハイライト右_表示 = true;

    	public bool 粘液2_ハイライト下1_表示 = true;

    	public bool 粘液2_ハイライト下2_表示 = true;

    	public bool 粘液3_粘液_表示 = true;

    	public bool 粘液3_ハイライト左上_表示 = true;

    	public bool 粘液3_ハイライト右上_表示 = true;

    	public bool 粘液3_ハイライト左下1_表示 = true;

    	public bool 粘液3_ハイライト左下2_表示 = true;

    	public bool 粘液3_ハイライト右下1_表示 = true;

    	public bool 粘液3_ハイライト右下2_表示 = true;

    	public bool 粘液3_ハイライト下1_表示 = true;

    	public bool 粘液3_ハイライト下2_表示 = true;

    	public bool 粘液4_粘液_表示 = true;

    	public bool 粘液4_ハイライト上1_表示 = true;

    	public bool 粘液4_ハイライト上2_表示 = true;

    	public bool 粘液4_ハイライト下1_表示 = true;

    	public bool 粘液4_ハイライト下2_表示 = true;

    	public bool 粘液下左_粘液_表示 = true;

    	public bool 粘液下左_ハイライト1_表示 = true;

    	public bool 粘液下左_ハイライト2_表示 = true;

    	public bool 粘液下右_粘液_表示 = true;

    	public bool 粘液下右_ハイライト1_表示 = true;

    	public bool 粘液下右_ハイライト2_表示 = true;

    	public bool 粘液上左_粘液_表示 = true;

    	public bool 粘液上左_ハイライト_表示 = true;

    	public bool 粘液上右_粘液_表示 = true;

    	public bool 粘液上右_ハイライト_表示 = true;

    	public bool ハイライト_表示 = true;

    	public bool ハイライト表示 = true;

    	public double ハイライト濃度 = 1.0;

    	public 単足_粘D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 単足_粘(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
