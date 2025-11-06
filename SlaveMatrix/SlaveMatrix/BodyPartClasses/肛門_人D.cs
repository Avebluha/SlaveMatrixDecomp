using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 肛門_人D : 肛門D
    {
    	public bool 肛門3_表示 = true;

    	public bool 肛門2_表示 = true;

    	public bool 肛門1_表示 = true;

    	public List<EleD> 肛門精液_接続 = new List<EleD>();

    	public 肛門_人D()
    	{
    		ThisType = GetType();
    	}

    	public void 肛門精液接続(EleD e)
    	{
    		肛門精液_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.肛門_人_肛門精液_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 肛門_人(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
