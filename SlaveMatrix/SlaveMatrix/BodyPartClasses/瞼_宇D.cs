using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 瞼_宇D : 双瞼D
    {
    	public bool 目_表示 = true;

    	public bool ハイライト_表示 = true;

    	public bool 瞬膜_表示 = true;

    	public List<ElementData> 涙_接続 = new List<ElementData>();

    	public 瞼_宇D()
    	{
    		ThisType = GetType();
    	}

    	public void 涙接続(ElementData e)
    	{
    		涙_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.瞼_宇_涙_接続;
    	}

    	public 瞼_宇D SetRandom()
    	{
    		サイズ = Rng.XS.NextDouble();
    		サイズX = Rng.XS.NextDouble();
    		サイズY = Rng.XS.NextDouble();
    		傾き = Rng.XS.NextDouble();
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 瞼_宇(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
