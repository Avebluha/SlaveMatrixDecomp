using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class Torso_蟲D : 長胴D
    {
    	public bool 胴_背板_表示 = true;

    	public bool 胴_節_表示 = true;

    	public bool 胴_胸板_表示 = true;

    	public bool 胴_胴_表示 = true;

    	public bool 胴_瘤左2_表示 = true;

    	public bool 胴_瘤左1_表示 = true;

    	public bool 胴_瘤右2_表示 = true;

    	public bool 胴_瘤右1_表示 = true;

    	public bool 輪_革_表示 = true;

    	public bool 輪_金具1_表示 = true;

    	public bool 輪_金具2_表示 = true;

    	public bool 輪_金具3_表示 = true;

    	public bool 輪_金具左_表示 = true;

    	public bool 輪_金具右_表示 = true;

    	public bool 輪表示 = true;

    	public bool 背板 = true;

    	public bool 節 = true;

    	public bool 胸板 = true;

    	public bool 胴 = true;

    	public bool 瘤 = true;

    	public bool 鎖表示;

    	public Torso_蟲D()
    	{
    		ThisType = GetType();
    	}

    	public override void 左接続(EleD e)
    	{
    		左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Torso_蟲_左_接続;
    	}

    	public override void 右接続(EleD e)
    	{
    		右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Torso_蟲_右_接続;
    	}

    	public override void Torso接続(EleD e)
    	{
    		Torso_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Torso_蟲_Torso_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new Torso_蟲(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
