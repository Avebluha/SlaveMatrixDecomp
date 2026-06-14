using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class UpperArm_蹄D : 獣UpperArmD
    {
    	public bool 筋肉上_表示;

    	public bool UpperArm_表示 = true;

    	public bool 筋肉下_表示;

    	public UpperArm_蹄D()
    	{
    		ThisType = GetType();
    	}

    	public override void LowerArm接続(ElementData e)
    	{
    		LowerArm_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.UpperArm_蹄_LowerArm_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new UpperArm_蹄(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
