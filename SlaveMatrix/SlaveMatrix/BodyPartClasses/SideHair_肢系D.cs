using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class SideHair_肢系D : SideHairD
    {
    	public bool 髪_表示 = true;

    	public List<EleD> 肢_接続 = new List<EleD>();

    	public SideHair_肢系D()
    	{
    		ThisType = GetType();
    	}

    	public void 肢接続(EleD e)
    	{
    		肢_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.SideHair_肢系_肢_接続;
    	}

    	public EleD SetRandom()
    	{
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new SideHair_肢系(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
