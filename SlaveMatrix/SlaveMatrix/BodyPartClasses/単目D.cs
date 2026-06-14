using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 単目D : ElementData
    {
    	public bool 白目_表示 = true;

    	public bool 黒目_黒目_表示 = true;

    	public bool 黒目_瞳孔_表示 = true;

    	public bool 黒目_ハイライト上_表示 = true;

    	public bool 黒目_ハイライト下_表示;

    	public bool 黒目_ハート_表示;

    	public bool 猫目;

    	public bool 蛸目;

    	public List<ElementData> 瞼_接続 = new List<ElementData>();

    	public 単目D()
    	{
    		ThisType = GetType();
    	}

    	public void 瞼接続(ElementData e)
    	{
    		瞼_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.単目_瞼_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 単目(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
