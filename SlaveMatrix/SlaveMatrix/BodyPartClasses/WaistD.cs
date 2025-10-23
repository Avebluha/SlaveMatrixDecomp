using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class WaistD : EleD
    {
    	public bool 腰_表示 = true;

    	public bool 股_表示 = true;

    	public bool 下腹_表示 = true;

    	public bool 腰皺_表示 = true;

    	public bool 筋肉_筋肉下_表示;

    	public bool 筋肉_筋肉左_表示;

    	public bool 筋肉_筋肉右_表示;

    	public bool 筋肉_筋上左_表示;

    	public bool 筋肉_筋上右_表示;

    	public bool 筋肉_筋下左_表示;

    	public bool 筋肉_筋下右_表示;

    	public bool ハイライト_表示;

    	public bool 臍_表示 = true;

    	public bool 悪タトゥ_渦_タトゥ1左_表示;

    	public bool 悪タトゥ_渦_タトゥ1右_表示;

    	public bool 悪タトゥ_渦_タトゥ2左_表示;

    	public bool 悪タトゥ_渦_タトゥ2右_表示;

    	public bool 淫タトゥ_ハート_タトゥ1左_表示;

    	public bool 淫タトゥ_ハート_タトゥ1右_表示;

    	public bool 淫タトゥ_ハート_タトゥ2左_表示;

    	public bool 淫タトゥ_ハート_タトゥ2右_表示;

    	public bool 傷X左_表示;

    	public bool 傷X右_表示;

    	public bool 傷I左_表示;

    	public bool 傷I右_表示;

    	public bool 紋柄_紋左_紋1_表示;

    	public bool 紋柄_紋左_紋2_表示;

    	public bool 紋柄_紋左_紋3_表示;

    	public bool 紋柄_紋右_紋1_表示;

    	public bool 紋柄_紋右_紋2_表示;

    	public bool 紋柄_紋右_紋3_表示;

    	public bool 獣性_獣毛左_表示;

    	public bool 獣性_獣毛右_表示;

    	public bool 虫性_甲殻2_表示;

    	public bool 虫性_甲殻1_表示;

    	public bool 竜性_左_鱗1_表示;

    	public bool 竜性_左_鱗2_表示;

    	public bool 竜性_右_鱗1_表示;

    	public bool 竜性_右_鱗2_表示;

    	public bool ハイライト上左_表示;

    	public bool ハイライト上右_表示;

    	public bool ハイライト下左_表示;

    	public bool ハイライト下右_表示;

    	public bool ハイライト表示;

    	public double 筋肉濃度 = 1.0;

    	public double 傷X左濃度 = 1.0;

    	public double 傷X右濃度 = 1.0;

    	public double 傷I左濃度 = 1.0;

    	public double 傷I右濃度 = 1.0;

    	public double ハイライト濃度 = 1.0;

    	public bool スライム;

    	public List<EleD> 胴_接続 = new List<EleD>();

    	public List<EleD> 腿左_接続 = new List<EleD>();

    	public List<EleD> 腿右_接続 = new List<EleD>();

    	public List<EleD> 膣基_接続 = new List<EleD>();

    	public List<EleD> 肛門_接続 = new List<EleD>();

    	public List<EleD> 尾_接続 = new List<EleD>();

    	public List<EleD> 半身_接続 = new List<EleD>();

    	public List<EleD> 上着_接続 = new List<EleD>();

    	public List<EleD> 肌_接続 = new List<EleD>();

    	public List<EleD> 翼左_接続 = new List<EleD>();

    	public List<EleD> 翼右_接続 = new List<EleD>();

    	public WaistD()
    	{
    		ThisType = GetType();
    	}

    	public void 胴接続(EleD e)
    	{
    		胴_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Waist_胴_接続;
    	}

    	public void 腿左接続(EleD e)
    	{
    		腿左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Waist_腿左_接続;
    		if (!(e is 獣腿D))
    		{
    			return;
    		}
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 0.9;
    		}
    	}

    	public void 腿右接続(EleD e)
    	{
    		腿右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Waist_腿右_接続;
    		if (!(e is 獣腿D))
    		{
    			return;
    		}
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 0.9;
    		}
    	}

    	public void 膣基接続(EleD e)
    	{
    		膣基_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Waist_膣基_接続;
    	}

    	public void 肛門接続(EleD e)
    	{
    		肛門_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Waist_肛門_接続;
    	}

    	public void 尾接続(EleD e)
    	{
    		尾_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Waist_尾_接続;
    		if (e is 尾_ヘD || e is 尾_ウD || e is 尾_ガD || e is 尾_蟲D)
    		{
    			foreach (EleD item in e.EnumEleD())
    			{
    				item.尺度B = 0.6;
    			}
    			return;
    		}
    		foreach (EleD item2 in e.EnumEleD())
    		{
    			item2.尺度B = 1.0;
    		}
    	}

    	public void 半身接続(EleD e)
    	{
    		半身_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Waist_半身_接続;
    	}

    	public void 上着接続(EleD e)
    	{
    		上着_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Waist_上着_接続;
    	}

    	public void 肌接続(EleD e)
    	{
    		肌_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Waist_肌_接続;
    	}

    	public void 翼左接続(EleD e)
    	{
    		翼左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Waist_翼左_接続;
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
    		e.接続情報 = ConnectionInfo.Waist_翼右_接続;
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
    		return new Waist(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
