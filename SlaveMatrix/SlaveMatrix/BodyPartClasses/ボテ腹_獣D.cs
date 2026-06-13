using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class ボテ腹_獣D : ボテ腹D
    {
    	public bool 腹_表示;

    	public bool 臍_表示;

    	public List<ElementData> 腹板_接続 = new List<ElementData>();

    	public ボテ腹_獣D()
    	{
    		ThisType = GetType();
    	}

    	public void 腹板接続(ElementData e)
    	{
    		腹板_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.ボテ腹_獣_腹板_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new ボテ腹_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
