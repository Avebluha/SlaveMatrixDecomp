using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 紅潮D : EleD
    {
    	public bool 紅潮0_表示 = true;

    	public bool 紅潮1_表示 = true;

    	public bool 紅潮右_表示 = true;

    	public bool 紅潮左_表示 = true;

    	public bool 紅潮線左_表示 = true;

    	public bool 紅潮線右_表示 = true;

    	public bool 紅潮弱左_表示 = true;

    	public bool 紅潮弱右_表示 = true;

    	public bool 紅潮線弱左_表示 = true;

    	public bool 紅潮線弱右_表示 = true;

    	public bool 紅潮表示 = true;

    	public bool 紅潮左右表示 = true;

    	public bool 紅潮線左右表示 = true;

    	public bool 紅潮弱左右表示 = true;

    	public bool 紅潮線弱左右表示 = true;

    	public double 紅潮濃度;

    	public double 紅潮左右濃度;

    	public double 紅潮線左右濃度;

    	public double 紅潮弱左右濃度;

    	public double 紅潮線弱左右濃度;

    	public 紅潮D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 紅潮(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
