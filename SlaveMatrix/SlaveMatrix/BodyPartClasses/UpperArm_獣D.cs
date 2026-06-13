using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class UpperArm_獣D : 獣UpperArmD
    {
    	public bool 筋肉上_表示;

    	public bool UpperArm_表示 = true;

    	public bool 筋肉下_表示;

    	public bool 虎柄_虎1_表示;

    	public bool 虎柄_虎2_表示;

    	public bool 竜性_鱗4_表示;

    	public bool 竜性_鱗3_表示;

    	public bool 竜性_鱗2_表示;

    	public bool 竜性_鱗1_表示;

    	public UpperArm_獣D()
    	{
    		ThisType = GetType();
    	}

    	public override void LowerArm接続(ElementData e)
    	{
    		LowerArm_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.UpperArm_獣_LowerArm_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new UpperArm_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
