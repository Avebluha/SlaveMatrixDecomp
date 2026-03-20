using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 乳房D : EleD
    {
    	public bool 乳房_表示 = true;

    	public bool 乳輪_表示 = true;

    	public bool 乳首_表示 = true;

    	public bool 淫タトゥ_タトゥ1_表示;

    	public bool 淫タトゥ_タトゥ2_表示;

    	public bool 淫タトゥ_タトゥ3_表示;

    	public bool 淫タトゥ_タトゥ4_表示;

    	public bool ハイライト1_表示 = true;

    	public bool ハイライト2_表示 = true;

    	public bool 傷X_表示;

    	public bool 傷I1_表示;

    	public bool 傷I2_表示;

    	public bool 虫性_甲殻_表示;

    	public bool ハイライト表示 = true;

    	public double 傷X濃度 = 1.0;

    	public double 傷I1濃度 = 1.0;

    	public double 傷I2濃度 = 1.0;

    	public double ハイライト濃度 = 1.0;

    	public double バスト;

    	public bool 着衣;

    	public List<EleD> 噴乳_接続 = new List<EleD>();

    	public 乳房D()
    	{
    		ThisType = GetType();
    	}

    	public void 噴乳接続(EleD e)
    	{
    		噴乳_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.乳房_噴乳_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 乳房(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
