using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 口_通常D : 口D
    {
    	public bool 口_表示 = true;

    	public bool 口紅上_表示;

    	public bool 牙左_表示;

    	public bool 牙右_表示;

    	public bool 口紅下_口紅_表示;

    	public bool 口紅下_ハイライト_表示 = true;

    	public bool 歯_表示 = true;

    	public bool 頬左_表示 = true;

    	public bool 頬右_表示 = true;

    	public bool 口紅表示 = true;

    	public bool ハイライト表示 = true;

    	public double 口紅濃度 = 1.0;

    	public double ハイライト濃度 = 1.0;

    	public 口_通常D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 口_通常(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
