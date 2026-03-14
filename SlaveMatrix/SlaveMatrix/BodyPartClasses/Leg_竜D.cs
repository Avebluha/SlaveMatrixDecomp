using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class Leg_竜D : 獣脚D
    {
    	public bool Leg_表示 = true;

    	public bool 竜性_鱗脹_鱗1_表示;

    	public bool 竜性_鱗脹_鱗2_表示;

    	public bool 竜性_鱗脹_鱗3_表示;

    	public bool 竜性_鱗脹_鱗4_表示;

    	public bool 竜性_鱗脹_鱗5_表示;

    	public bool 竜性_鱗脹_鱗6_表示;

    	public bool 竜性_鱗脹_鱗7_表示;

    	public bool 竜性_鱗脹_鱗8_表示;

    	public bool 竜性_鱗脛_鱗1_表示;

    	public bool 竜性_鱗脛_鱗2_表示;

    	public bool 竜性_鱗脛_鱗3_表示;

    	public bool 竜性_鱗脛_鱗4_表示;

    	public bool 竜性_鱗脛_鱗5_表示;

    	public bool 竜性_鱗脛_鱗6_表示;

    	public bool 竜性_鱗脛_鱗7_表示;

    	public bool 竜性_鱗脛_鱗8_表示;

    	public bool 竜性_鱗脛_鱗9_表示;

    	public bool 竜性_鱗脛_鱗10_表示;

    	public bool 筋_表示;

    	public bool 脚輪_革_表示;

    	public bool 脚輪_金具1_表示;

    	public bool 脚輪_金具2_表示;

    	public bool 脚輪_金具3_表示;

    	public bool 脚輪_金具左_表示;

    	public bool 脚輪_金具右_表示;

    	public bool 脚輪表示;

    	public bool 鎖表示;

    	public Leg_竜D()
    	{
    		ThisType = GetType();
    	}

    	public override void 足接続(EleD e)
    	{
    		足_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Leg_竜_足_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new Leg_竜(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
