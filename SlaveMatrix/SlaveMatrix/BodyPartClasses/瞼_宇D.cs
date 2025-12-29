using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 瞼_宇D : 双瞼D
    {
    	public bool 目_表示 = true;

    	public bool ハイライト_表示 = true;

    	public bool 瞬膜_表示 = true;

    	public List<EleD> 涙_接続 = new List<EleD>();

    	public 瞼_宇D()
    	{
    		ThisType = GetType();
    	}

    	public void 涙接続(EleD e)
    	{
    		涙_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.瞼_宇_涙_接続;
    	}

    	public 瞼_宇D SetRandom()
    	{
    		サイズ = RNG.XS.NextDouble();
    		サイズX = RNG.XS.NextDouble();
    		サイズY = RNG.XS.NextDouble();
    		傾き = RNG.XS.NextDouble();
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 瞼_宇(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
