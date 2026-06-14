using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class Leg_獣D : 獣脚D
    {
    	public bool Leg_表示 = true;

    	public bool 筋_表示;

    	public bool 脚輪_革_表示;

    	public bool 脚輪_金具1_表示;

    	public bool 脚輪_金具2_表示;

    	public bool 脚輪_金具3_表示;

    	public bool 脚輪_金具左_表示;

    	public bool 脚輪_金具右_表示;

    	public bool 脚輪表示;

    	public bool 鎖表示;

    	public Leg_獣D()
    	{
    		ThisType = GetType();
    	}

    	public override void 足接続(ElementData e)
    	{
    		足_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Leg_獣_足_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new Leg_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
