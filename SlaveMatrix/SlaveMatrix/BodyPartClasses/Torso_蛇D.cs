using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class Torso_蛇D : 長胴D
    {
    	public bool Torso_鱗_表示 = true;

    	public bool Torso_鱗左_表示 = true;

    	public bool Torso_鱗右_表示 = true;

    	public bool Torso_表示 = true;

    	public bool 輪_革_表示 = true;

    	public bool 輪_金具1_表示 = true;

    	public bool 輪_金具2_表示 = true;

    	public bool 輪_金具3_表示 = true;

    	public bool 輪_金具左_表示 = true;

    	public bool 輪_金具右_表示 = true;

    	public bool 輪表示 = true;

    	public bool 鎖表示;

    	public Torso_蛇D()
    	{
    		ThisType = GetType();
    	}

    	public override void 左接続(EleD e)
    	{
    		左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Torso_蛇_左_接続;
    	}

    	public override void 右接続(EleD e)
    	{
    		右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Torso_蛇_右_接続;
    	}

    	public override void Torso接続(EleD e)
    	{
    		Torso_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Torso_蛇_Torso_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new Torso_蛇(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
