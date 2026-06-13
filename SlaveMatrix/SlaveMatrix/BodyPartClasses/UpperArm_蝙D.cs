using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class UpperArm_蝙D : 翼UpperArmD
    {
    	public bool 獣翼UpperArm_表示 = true;

    	public bool 竜性_鱗1_表示;

    	public bool 竜性_鱗2_表示;

    	public bool 竜性_鱗3_表示;

    	public bool 竜性_鱗4_表示;

    	public bool 竜性_鱗5_表示;

    	public bool 竜性_鱗6_表示;

    	public bool 飛膜_表示 = true;

    	public double 展開;

    	public bool 下部_外線;

    	public bool 接部_外線;

    	public UpperArm_蝙D()
    	{
    		ThisType = GetType();
    	}

    	public override void LowerArm接続(EleD e)
    	{
    		LowerArm_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.UpperArm_蝙_LowerArm_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new UpperArm_蝙(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
