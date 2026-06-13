using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 鼻_人D : 鼻D
    {
    	public bool 鼻_表示 = true;

    	public 鼻_人D()
    	{
    		ThisType = GetType();
    	}

    	public override void 鼻水左接続(ElementData e)
    	{
    		鼻水左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.鼻_人_鼻水左_接続;
    	}

    	public override void 鼻水右接続(ElementData e)
    	{
    		鼻水右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.鼻_人_鼻水右_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 鼻_人(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
