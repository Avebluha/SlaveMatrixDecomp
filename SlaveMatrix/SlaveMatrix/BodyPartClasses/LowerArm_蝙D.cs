using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class LowerArm_蝙D : 翼LowerArmD
    {
    	public bool 獣翼LowerArm_表示 = true;

    	public bool 竜性_鱗1_表示;

    	public bool 竜性_鱗2_表示;

    	public bool 竜性_鱗3_表示;

    	public bool 竜性_鱗4_表示;

    	public bool 竜性_鱗5_表示;

    	public bool 竜性_鱗6_表示;

    	public bool 竜性_鱗7_表示;

    	public bool 竜性_鱗8_表示;

    	public bool 竜性_鱗9_表示;

    	public bool 竜性_鱗10_表示;

    	public bool 竜性_鱗11_表示;

    	public bool 竜性_鱗12_表示;

    	public bool 竜性_鱗13_表示;

    	public bool 腕輪_革_表示;

    	public bool 腕輪_金具1_表示;

    	public bool 腕輪_金具2_表示;

    	public bool 腕輪_金具3_表示;

    	public bool 腕輪_金具左_表示;

    	public bool 腕輪_金具右_表示;

    	public bool 腕輪表示;

    	public double 展開;

    	public bool 下部_外線;

    	public bool 鎖表示;

    	public List<EleD> 腕輪_接続 = new List<EleD>();

    	public LowerArm_蝙D()
    	{
    		ThisType = GetType();
    	}

    	public override void 手接続(EleD e)
    	{
    		手_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.LowerArm_蝙_手_接続;
    	}

    	public void 腕輪接続(EleD e)
    	{
    		腕輪_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.LowerArm_蝙_腕輪_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new LowerArm_蝙(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
