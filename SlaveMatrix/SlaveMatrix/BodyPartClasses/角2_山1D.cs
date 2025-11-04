using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 角2_山1D : 角2D
    {
    	public bool 根_表示 = true;

    	public bool 凸1_表示 = true;

    	public bool 凸2_表示 = true;

    	public bool 凸3_表示 = true;

    	public bool 凸4_表示 = true;

    	public bool 凸5_表示 = true;

    	public bool 凸6_表示 = true;

    	public bool 凸7_表示 = true;

    	public bool 折線_表示 = true;

    	public 角2_山1D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 角2_山1(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
