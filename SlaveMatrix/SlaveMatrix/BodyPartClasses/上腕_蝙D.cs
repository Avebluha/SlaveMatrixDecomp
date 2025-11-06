using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 上腕_蝙D : 翼上腕D
    {
    	public bool 獣翼上腕_表示 = true;

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

    	public 上腕_蝙D()
    	{
    		ThisType = GetType();
    	}

    	public override void 下腕接続(EleD e)
    	{
    		下腕_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.上腕_蝙_下腕_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 上腕_蝙(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
