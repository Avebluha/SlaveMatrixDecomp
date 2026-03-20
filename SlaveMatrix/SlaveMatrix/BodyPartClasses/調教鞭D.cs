using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 調教鞭D : EleD
    {
    	public bool 先_表示 = true;

    	public bool 柄_表示 = true;

    	public bool 線1_表示 = true;

    	public bool 線2_表示 = true;

    	public bool 線3_表示 = true;

    	public bool 線4_表示 = true;

    	public bool 線5_表示 = true;

    	public bool 線6_表示 = true;

    	public bool 線7_表示 = true;

    	public bool 線8_表示 = true;

    	public bool 紐_表示 = true;

    	public bool 鞭撃エフェクト1_表示 = true;

    	public bool 鞭撃エフェクト2_表示 = true;

    	public 調教鞭D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 調教鞭(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
