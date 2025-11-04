using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 頬目D : EleD
    {
    	public bool 白目_表示 = true;

    	public bool 黒目_黒目_表示 = true;

    	public bool 黒目_瞳孔_表示 = true;

    	public bool 黒目_ハート_表示;

    	public bool 黒目_ハイライト上_表示 = true;

    	public bool 黒目_ハイライト下_表示;

    	public bool 猫目;

    	public bool 蛸目;

    	public double 傾き;

    	public List<EleD> 瞼_接続 = new List<EleD>();

    	public 頬目D()
    	{
    		ThisType = GetType();
    	}

    	public void 瞼接続(EleD e)
    	{
    		瞼_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.頬目_瞼_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 頬目(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
