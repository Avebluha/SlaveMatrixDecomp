using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 長物_蟲D : 半身D
    {
    	public bool 胴1_背板_表示 = true;

    	public bool 胴1_胸板_表示 = true;

    	public bool 胴1_胴_表示 = true;

    	public bool 胴1_瘤左2_表示 = true;

    	public bool 胴1_瘤左1_表示 = true;

    	public bool 胴1_瘤右2_表示 = true;

    	public bool 胴1_瘤右1_表示 = true;

    	public bool 胴1_胴0_背板_表示 = true;

    	public bool 胴1_胴0_胸板_表示 = true;

    	public bool 胴1_胴0_胴_表示 = true;

    	public bool 輪1_革_表示 = true;

    	public bool 輪1_金具1_表示 = true;

    	public bool 輪1_金具2_表示 = true;

    	public bool 輪1_金具3_表示 = true;

    	public bool 輪1_金具左_表示 = true;

    	public bool 輪1_金具右_表示 = true;

    	public bool 輪1表示 = true;

    	public bool 背板 = true;

    	public bool 胸板 = true;

    	public bool 胴 = true;

    	public bool 瘤 = true;

    	public bool 鎖表示;

    	public List<EleD> 左0_接続 = new List<EleD>();

    	public List<EleD> 右0_接続 = new List<EleD>();

    	public List<EleD> 左1_接続 = new List<EleD>();

    	public List<EleD> 右1_接続 = new List<EleD>();

    	public List<EleD> Torso_接続 = new List<EleD>();

    	public 長物_蟲D()
    	{
    		ThisType = GetType();
    	}

    	public void 左0接続(EleD e)
    	{
    		左0_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_蟲_左0_接続;
    	}

    	public void 右0接続(EleD e)
    	{
    		右0_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_蟲_右0_接続;
    	}

    	public void 左1接続(EleD e)
    	{
    		左1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_蟲_左1_接続;
    	}

    	public void 右1接続(EleD e)
    	{
    		右1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_蟲_右1_接続;
    	}

    	public void 胴接続(EleD e)
    	{
    		Torso_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_蟲_Torso_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 長物_蟲(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
