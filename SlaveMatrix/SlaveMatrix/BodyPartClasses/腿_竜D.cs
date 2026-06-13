using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 腿_竜D : 獣腿D
    {
    	public bool 腿_表示 = true;

    	public bool 竜性_鱗下_鱗1_表示;

    	public bool 竜性_鱗下_鱗2_表示;

    	public bool 竜性_鱗下_鱗3_表示;

    	public bool 竜性_鱗下_鱗4_表示;

    	public bool 竜性_鱗下_鱗5_表示;

    	public bool 竜性_鱗下_鱗6_表示;

    	public bool 竜性_鱗上_鱗1_表示;

    	public bool 竜性_鱗上_鱗2_表示;

    	public bool 竜性_鱗上_鱗3_表示;

    	public bool 竜性_鱗上_鱗4_表示;

    	public bool 筋_表示;

    	public 腿_竜D()
    	{
    		ThisType = GetType();
    	}

    	public override void Leg接続(ElementData e)
    	{
    		Leg_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.腿_竜_Leg_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 腿_竜(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
