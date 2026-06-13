using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 尾_蜘D : 尾D
    {
    	public bool 尾0_表示 = true;

    	public bool 柄0_表示 = true;

    	public bool 柄左1_表示;

    	public bool 柄左2_表示;

    	public bool 柄右1_表示;

    	public bool 柄右2_表示;

    	public bool 出糸突起後_出糸突起基_表示 = true;

    	public bool 出糸突起後_出糸突起中_表示 = true;

    	public bool 出糸突起後_出糸突起左_表示 = true;

    	public bool 出糸突起後_出糸突起右_表示 = true;

    	public bool 出糸突起左_出糸突起1_表示 = true;

    	public bool 出糸突起左_出糸突起2_表示 = true;

    	public bool 出糸突起右_出糸突起1_表示 = true;

    	public bool 出糸突起右_出糸突起2_表示 = true;

    	public bool 出糸突起前_出糸突起左_表示 = true;

    	public bool 出糸突起前_出糸突起右_表示 = true;

    	public bool 付根線_表示 = true;

    	public bool 出糸;

    	public List<EleD> 出糸_接続 = new List<EleD>();

    	public 尾_蜘D()
    	{
    		ThisType = GetType();
    	}

    	public void 出糸接続(EleD e)
    	{
    		出糸_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.尾_蜘_出糸_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 尾_蜘(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
