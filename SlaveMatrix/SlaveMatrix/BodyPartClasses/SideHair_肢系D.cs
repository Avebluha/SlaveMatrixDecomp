using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class SideHair_肢系D : SideHairD
    {
    	public bool 髪_表示 = true;

    	public List<ElementData> 肢_接続 = new List<ElementData>();

    	public SideHair_肢系D()
    	{
    		ThisType = GetType();
    	}

    	public void 肢接続(ElementData e)
    	{
    		肢_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.SideHair_肢系_肢_接続;
    	}

    	public ElementData SetRandom()
    	{
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new SideHair_肢系(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
