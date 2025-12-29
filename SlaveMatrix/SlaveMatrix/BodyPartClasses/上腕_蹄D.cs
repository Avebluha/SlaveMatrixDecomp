using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 上腕_蹄D : 獣上腕D
    {
    	public bool 筋肉上_表示;

    	public bool 上腕_表示 = true;

    	public bool 筋肉下_表示;

    	public 上腕_蹄D()
    	{
    		ThisType = GetType();
    	}

    	public override void 下腕接続(EleD e)
    	{
    		下腕_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.上腕_蹄_下腕_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 上腕_蹄(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
