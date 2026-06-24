using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class ChestD : ElementData
    {
    	public bool RibCage_表示 = true;

    	public bool 筋肉_筋肉左_表示;

    	public bool 筋肉_筋肉右_表示;

    	public bool 筋肉_筋肉中_表示;

    	public bool 筋肉_筋肉左下_表示;

    	public bool 筋肉_筋肉左中_表示;

    	public bool 筋肉_筋肉左上_表示;

    	public bool 筋肉_筋肉右下_表示;

    	public bool 筋肉_筋肉右中_表示;

    	public bool 筋肉_筋肉右上_表示;

    	public bool 紋柄_紋左_紋1_表示;

    	public bool 紋柄_紋左_紋2_表示;

    	public bool 紋柄_紋左_紋3_表示;

    	public bool 紋柄_紋左_紋4_表示;

    	public bool 紋柄_紋右_紋1_表示;

    	public bool 紋柄_紋右_紋2_表示;

    	public bool 紋柄_紋右_紋3_表示;

    	public bool 紋柄_紋右_紋4_表示;

    	public bool 淫タトゥ_タトゥ左_表示;

    	public bool 淫タトゥ_タトゥ右_表示;

    	public bool 悪タトゥ_タトゥ左1_表示;

    	public bool 悪タトゥ_タトゥ左2_表示;

    	public bool 悪タトゥ_タトゥ左3_表示;

    	public bool 悪タトゥ_タトゥ右1_表示;

    	public bool 悪タトゥ_タトゥ右2_表示;

    	public bool 悪タトゥ_タトゥ右3_表示;

    	public bool 植タトゥ_左_上_タトゥ1_表示;

    	public bool 植タトゥ_左_上_タトゥ2_表示;

    	public bool 植タトゥ_左_下_タトゥ1_表示;

    	public bool 植タトゥ_左_下_タトゥ2_表示;

    	public bool 植タトゥ_右_上_タトゥ1_表示;

    	public bool 植タトゥ_右_上_タトゥ2_表示;

    	public bool 植タトゥ_右_下_タトゥ1_表示;

    	public bool 植タトゥ_右_下_タトゥ2_表示;

    	public bool 獣性_獣毛左1_表示;

    	public bool 獣性_獣毛左2_表示;

    	public bool 獣性_獣毛右1_表示;

    	public bool 獣性_獣毛右2_表示;

    	public bool 竜性_左_鱗1_表示;

    	public bool 竜性_左_鱗2_表示;

    	public bool 竜性_左_鱗3_表示;

    	public bool 竜性_右_鱗1_表示;

    	public bool 竜性_右_鱗2_表示;

    	public bool 竜性_右_鱗3_表示;

    	public bool 虫性_甲殻左_甲殻2_甲殻_表示;

    	public bool 虫性_甲殻左_甲殻2_器官_表示;

    	public bool 虫性_甲殻左_甲殻1_甲殻_表示;

    	public bool 虫性_甲殻左_甲殻1_器官_表示;

    	public bool 虫性_甲殻右_甲殻2_甲殻_表示;

    	public bool 虫性_甲殻右_甲殻2_器官_表示;

    	public bool 虫性_甲殻右_甲殻1_甲殻_表示;

    	public bool 虫性_甲殻右_甲殻1_器官_表示;

    	public bool 傷X左_表示;

    	public bool 傷X右_表示;

    	public bool ハイライト外左_表示;

    	public bool ハイライト外右_表示;

    	public bool ハイライト内左_表示;

    	public bool ハイライト内右_表示;

    	public bool ハイライト表示;

    	public double 筋肉濃度 = 1.0;

    	public double 傷X左濃度 = 1.0;

    	public double 傷X右濃度 = 1.0;

    	public double ハイライト濃度 = 1.0;

    	public List<ElementData> Neck_接続 = new List<ElementData>();

    	public List<ElementData> 肩左_接続 = new List<ElementData>();

    	public List<ElementData> 肩右_接続 = new List<ElementData>();

    	public List<ElementData> LeftBreast_接続 = new List<ElementData>();

    	public List<ElementData> 胸右_接続 = new List<ElementData>();

    	public List<ElementData> 肌_接続 = new List<ElementData>();

    	public List<ElementData> 翼上左_接続 = new List<ElementData>();

    	public List<ElementData> 翼上右_接続 = new List<ElementData>();

    	public List<ElementData> 翼下左_接続 = new List<ElementData>();

    	public List<ElementData> 翼下右_接続 = new List<ElementData>();

    	public List<ElementData> 背中_接続 = new List<ElementData>();

    	public ChestD()
    	{
    		ThisType = GetType();
    	}

    	public void 首接続(ElementData e)
    	{
    		Neck_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Chest_Neck_接続;
    	}

    	public void 肩左接続(ElementData e)
    	{
    		肩左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Chest_肩左_接続;
    	}

    	public void 肩右接続(ElementData e)
    	{
    		肩右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Chest_肩右_接続;
    	}

    	public void 胸左接続(ElementData e)
    	{
    		LeftBreast_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Chest_LeftBreast_接続;
    	}

    	public void 胸右接続(ElementData e)
    	{
    		胸右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Chest_胸右_接続;
    	}

    	public void 肌接続(ElementData e)
    	{
    		肌_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Chest_肌_接続;
    	}

    	public void 翼上左接続(ElementData e)
    	{
    		翼上左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Chest_翼上左_接続;
    		if (!(e is 尾D))
    		{
    			return;
    		}
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度B = 1.0;
    		}
    	}

    	public void 翼上右接続(ElementData e)
    	{
    		翼上右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Chest_翼上右_接続;
    		if (!(e is 尾D))
    		{
    			return;
    		}
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度B = 1.0;
    		}
    	}

    	public void 翼下左接続(ElementData e)
    	{
    		翼下左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Chest_翼下左_接続;
    		if (!(e is 尾D))
    		{
    			return;
    		}
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度B = 1.0;
    		}
    	}

    	public void 翼下右接続(ElementData e)
    	{
    		翼下右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Chest_翼下右_接続;
    		if (!(e is 尾D))
    		{
    			return;
    		}
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度B = 1.0;
    		}
    	}

    	public void 背中接続(ElementData e)
    	{
    		背中_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Chest_背中_接続;
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度B = 1.0;
    		}
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new Chest(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
