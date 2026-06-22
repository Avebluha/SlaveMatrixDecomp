using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 四足腰D : ElementData
    {
    	public bool Waist_表示 = true;

    	public bool 股_表示 = true;

    	public bool 下腹_表示 = true;

    	public bool 腰皺_表示 = true;

    	public bool 筋肉_筋肉下_表示 = true;

    	public bool 筋肉_筋肉左_表示 = true;

    	public bool 筋肉_筋肉右_表示 = true;

    	public bool 筋肉_筋上左_表示 = true;

    	public bool 筋肉_筋上右_表示 = true;

    	public bool 筋肉_筋下左_表示 = true;

    	public bool 筋肉_筋下右_表示 = true;

    	public bool 臍_表示 = true;

    	public bool 紋柄_紋左_紋1_表示;

    	public bool 紋柄_紋左_紋2_表示;

    	public bool 紋柄_紋左_紋3_表示;

    	public bool 紋柄_紋右_紋1_表示;

    	public bool 紋柄_紋右_紋2_表示;

    	public bool 紋柄_紋右_紋3_表示;

    	public bool 虎柄_虎左_表示;

    	public bool 虎柄_虎右_表示;

    	public bool 竜性_中_鱗1_表示;

    	public bool 竜性_中_鱗2_表示;

    	public bool 竜性_中_鱗3_表示;

    	public bool 竜性_中_鱗4_表示;

    	public bool 竜性_左_鱗1_表示;

    	public bool 竜性_左_鱗2_表示;

    	public bool 竜性_右_鱗1_表示;

    	public bool 竜性_右_鱗2_表示;

    	public double 筋肉濃度 = 1.0;

    	public List<ElementData> 腿左_接続 = new List<ElementData>();

    	public List<ElementData> 腿右_接続 = new List<ElementData>();

    	public List<ElementData> VaginaOrigin_接続 = new List<ElementData>();

    	public List<ElementData> Anus_接続 = new List<ElementData>();

    	public List<ElementData> 尾_接続 = new List<ElementData>();

    	public List<ElementData> 半身_接続 = new List<ElementData>();

    	public List<ElementData> 上着_接続 = new List<ElementData>();

    	public List<ElementData> 肌_接続 = new List<ElementData>();

    	public List<ElementData> 翼左_接続 = new List<ElementData>();

    	public List<ElementData> 翼右_接続 = new List<ElementData>();

    	public 四足腰D()
    	{
    		ThisType = GetType();
    	}

    	public void 腿左接続(ElementData e)
    	{
    		腿左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足腰_腿左_接続;
    		if (e is 獣腿D)
    		{
    			e.尺度B = 1.0;
    		}
    	}

    	public void 腿右接続(ElementData e)
    	{
    		腿右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足腰_腿右_接続;
    		if (e is 獣腿D)
    		{
    			e.尺度B = 1.0;
    		}
    	}

    	public void 膣基接続(ElementData e)
    	{
    		VaginaOrigin_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足腰_VaginaOrigin_接続;
    	}

    	public void 肛門接続(ElementData e)
    	{
    		Anus_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足腰_Anus_接続;
    	}

    	public void 尾接続(ElementData e)
    	{
    		尾_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足腰_尾_接続;
    		if (e is 尾_ヘD || e is 尾_ウD || e is 尾_ガD || e is 尾_蟲D)
    		{
    			foreach (ElementData item in e.EnumEleD())
    			{
    				item.尺度B = 0.7;
    			}
    			return;
    		}
    		foreach (ElementData item2 in e.EnumEleD())
    		{
    			item2.尺度B = 1.1;
    		}
    	}

    	public void 半身接続(ElementData e)
    	{
    		半身_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足腰_半身_接続;
    	}

    	public void 上着接続(ElementData e)
    	{
    		上着_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足腰_上着_接続;
    	}

    	public void 肌接続(ElementData e)
    	{
    		肌_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足腰_肌_接続;
    	}

    	public void 翼左接続(ElementData e)
    	{
    		翼左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足腰_翼左_接続;
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度B = 1.1;
    		}
    	}

    	public void 翼右接続(ElementData e)
    	{
    		翼右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足腰_翼右_接続;
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度B = 1.1;
    		}
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 四足腰(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
