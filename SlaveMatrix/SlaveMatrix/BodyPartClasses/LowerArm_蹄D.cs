using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class LowerArm_蹄D : 獣LowerArmD
    {
    	public bool LowerArm_表示 = true;

    	public bool 筋肉_筋肉下_表示;

    	public bool 筋肉_筋肉上_表示;

    	public LowerArm_蹄D()
    	{
    		ThisType = GetType();
    	}

    	public override void 手接続(EleD e)
    	{
    		手_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.LowerArm_蹄_手_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new LowerArm_蹄(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
