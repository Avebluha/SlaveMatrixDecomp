using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 四足胸D : 半身D
    {
    	public bool 胸郭_表示 = true;

    	public bool 筋肉_筋肉左_表示 = true;

    	public bool 筋肉_筋肉右_表示 = true;

    	public bool 筋肉_筋肉中_表示 = true;

    	public bool 筋肉_筋肉左下_表示 = true;

    	public bool 筋肉_筋肉左中_表示 = true;

    	public bool 筋肉_筋肉左上_表示 = true;

    	public bool 筋肉_筋肉右下_表示 = true;

    	public bool 筋肉_筋肉右中_表示 = true;

    	public bool 筋肉_筋肉右上_表示 = true;

    	public bool 紋柄_紋左_紋1_表示;

    	public bool 紋柄_紋左_紋2_表示;

    	public bool 紋柄_紋左_紋3_表示;

    	public bool 紋柄_紋左_紋4_表示;

    	public bool 紋柄_紋右_紋1_表示;

    	public bool 紋柄_紋右_紋2_表示;

    	public bool 紋柄_紋右_紋3_表示;

    	public bool 紋柄_紋右_紋4_表示;

    	public bool 虎柄_虎左_虎1_表示;

    	public bool 虎柄_虎左_虎2_表示;

    	public bool 虎柄_虎右_虎1_表示;

    	public bool 虎柄_虎右_虎2_表示;

    	public bool 竜性_中_鱗左_表示;

    	public bool 竜性_中_鱗右_表示;

    	public bool 竜性_中_鱗1_表示;

    	public bool 竜性_中_鱗2_表示;

    	public bool 竜性_左_鱗1_表示;

    	public bool 竜性_左_鱗2_表示;

    	public bool 竜性_左_鱗3_表示;

    	public bool 竜性_右_鱗1_表示;

    	public bool 竜性_右_鱗2_表示;

    	public bool 竜性_右_鱗3_表示;

    	public double 筋肉濃度 = 1.0;

    	public List<EleD> 脇左_接続 = new List<EleD>();

    	public List<EleD> 脇右_接続 = new List<EleD>();

    	public List<EleD> Torso_接続 = new List<EleD>();

    	public List<EleD> 胸左_接続 = new List<EleD>();

    	public List<EleD> 胸右_接続 = new List<EleD>();

    	public List<EleD> 肌_接続 = new List<EleD>();

    	public List<EleD> 翼上左_接続 = new List<EleD>();

    	public List<EleD> 翼上右_接続 = new List<EleD>();

    	public List<EleD> 翼下左_接続 = new List<EleD>();

    	public List<EleD> 翼下右_接続 = new List<EleD>();

    	public List<EleD> 背中_接続 = new List<EleD>();

    	public 四足胸D()
    	{
    		ThisType = GetType();
    	}

    	public void 脇左接続(EleD e)
    	{
    		脇左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胸_脇左_接続;
    	}

    	public void 脇右接続(EleD e)
    	{
    		脇右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胸_脇右_接続;
    	}

    	public void 胴接続(EleD e)
    	{
    		Torso_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胸_Torso_接続;
    	}

    	public void 胸左接続(EleD e)
    	{
    		胸左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胸_胸左_接続;
    	}

    	public void 胸右接続(EleD e)
    	{
    		胸右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胸_胸右_接続;
    	}

    	public void 肌接続(EleD e)
    	{
    		肌_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胸_肌_接続;
    	}

    	public void 翼上左接続(EleD e)
    	{
    		翼上左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胸_翼上左_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 1.1;
    		}
    	}

    	public void 翼上右接続(EleD e)
    	{
    		翼上右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胸_翼上右_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 1.1;
    		}
    	}

    	public void 翼下左接続(EleD e)
    	{
    		翼下左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胸_翼下左_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 1.1;
    		}
    	}

    	public void 翼下右接続(EleD e)
    	{
    		翼下右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胸_翼下右_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 1.1;
    		}
    	}

    	public void 背中接続(EleD e)
    	{
    		背中_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足胸_背中_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 1.1;
    		}
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 四足胸(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
