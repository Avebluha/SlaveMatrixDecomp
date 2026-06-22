using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class CrimsonSquirtD : ElementData
    {
    	public bool CrimsonSquirt0_表示 = true;

    	public bool CrimsonSquirt1_表示 = true;

    	public bool CrimsonSquirtRight_表示 = true;

    	public bool CrimsonSquirtLeft_表示 = true;

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

    	public CrimsonSquirtD()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new CrimsonSquirt(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
