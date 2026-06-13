using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 四足胴D : ElementData
    {
    	public bool Torso_表示 = true;

    	public bool 筋肉_筋肉左_表示 = true;

    	public bool 筋肉_筋肉右_表示 = true;

    	public bool 獣性_獣毛左_表示;

    	public bool 獣性_獣毛右_表示;

    	public double 筋肉濃度 = 1.0;

    	public List<ElementData> Waist_接続 = new List<ElementData>();

    	public List<ElementData> 肌_接続 = new List<ElementData>();

    	public List<ElementData> 翼左_接続 = new List<ElementData>();

    	public List<ElementData> 翼右_接続 = new List<ElementData>();

    	public 四足胴D()
    	{
    		ThisType = GetType();
    	}

    	public void 腰接続(ElementData e)
    	{
    		Waist_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胴_Waist_接続;
    	}

    	public void 肌接続(ElementData e)
    	{
    		肌_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胴_肌_接続;
    	}

    	public void 翼左接続(ElementData e)
    	{
    		翼左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胴_翼左_接続;
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度B = 1.1;
    		}
    	}

    	public void 翼右接続(ElementData e)
    	{
    		翼右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胴_翼右_接続;
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度B = 1.1;
    		}
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 四足胴(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
