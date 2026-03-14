using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class LowerArm_獣D : 獣LowerArmD
    {
    	public bool LowerArm_表示 = true;

    	public bool 筋肉_筋肉下_表示;

    	public bool 筋肉_筋肉上_表示;

    	public bool 竜性_鱗1_表示;

    	public bool 竜性_鱗2_表示;

    	public bool 竜性_鱗3_表示;

    	public bool 竜性_鱗4_表示;

    	public bool 竜性_鱗5_表示;

    	public bool 竜性_鱗6_表示;

    	public bool 竜性_鱗7_表示;

    	public bool 腕輪_革_表示;

    	public bool 腕輪_金具1_表示;

    	public bool 腕輪_金具2_表示;

    	public bool 腕輪_金具3_表示;

    	public bool 腕輪_金具左_表示;

    	public bool 腕輪_金具右_表示;

    	public bool 腕輪表示;

    	public bool 鎖表示;

    	public LowerArm_獣D()
    	{
    		ThisType = GetType();
    	}

    	public override void 手接続(EleD e)
    	{
    		手_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.LowerArm_獣_手_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new LowerArm_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
