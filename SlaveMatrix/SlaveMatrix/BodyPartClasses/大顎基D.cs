using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 大顎基D : EleD
    {
    	public bool 甲殻下_表示 = true;

    	public bool 甲殻_表示 = true;

    	public bool 線左_表示 = true;

    	public bool 線右_表示 = true;

    	public bool 刺左_表示 = true;

    	public bool 刺右_表示 = true;

    	public List<EleD> 顎左_接続 = new List<EleD>();

    	public List<EleD> 顎右_接続 = new List<EleD>();

    	public 大顎基D()
    	{
    		ThisType = GetType();
    	}

    	public void 顎左接続(EleD e)
    	{
    		顎左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.大顎基_顎左_接続;
    	}

    	public void 顎右接続(EleD e)
    	{
    		顎右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.大顎基_顎右_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 大顎基(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
