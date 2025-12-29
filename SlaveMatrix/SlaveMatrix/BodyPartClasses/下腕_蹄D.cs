using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 下腕_蹄D : 獣下腕D
    {
    	public bool 下腕_表示 = true;

    	public bool 筋肉_筋肉下_表示;

    	public bool 筋肉_筋肉上_表示;

    	public 下腕_蹄D()
    	{
    		ThisType = GetType();
    	}

    	public override void 手接続(EleD e)
    	{
    		手_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.下腕_蹄_手_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 下腕_蹄(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
