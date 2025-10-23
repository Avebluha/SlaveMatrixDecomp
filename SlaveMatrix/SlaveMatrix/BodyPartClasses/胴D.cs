using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 胴D : EleD
    {
    	public bool 胴_表示 = true;

    	public bool 筋肉_筋肉左_表示;

    	public bool 筋肉_筋肉右_表示;

    	public bool 獣性_獣毛左_表示;

    	public bool 獣性_獣毛右_表示;

    	public bool 植タトゥ_左_タトゥ2_表示;

    	public bool 植タトゥ_左_タトゥ1_表示;

    	public bool 植タトゥ_右_タトゥ2_表示;

    	public bool 植タトゥ_右_タトゥ1_表示;

    	public double 筋肉濃度 = 1.0;

    	public List<EleD> 胸_接続 = new List<EleD>();

    	public List<EleD> 肌_接続 = new List<EleD>();

    	public List<EleD> 翼左_接続 = new List<EleD>();

    	public List<EleD> 翼右_接続 = new List<EleD>();

    	public 胴D()
    	{
    		ThisType = GetType();
    	}

    	public void 胸接続(EleD e)
    	{
    		胸_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.胴_胸_接続;
    	}

    	public void 肌接続(EleD e)
    	{
    		肌_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.胴_肌_接続;
    	}

    	public void 翼左接続(EleD e)
    	{
    		翼左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.胴_翼左_接続;
    		if (!(e is 尾D))
    		{
    			return;
    		}
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 1.0;
    		}
    	}

    	public void 翼右接続(EleD e)
    	{
    		翼右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.胴_翼右_接続;
    		if (!(e is 尾D))
    		{
    			return;
    		}
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 1.0;
    		}
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new Torso(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
