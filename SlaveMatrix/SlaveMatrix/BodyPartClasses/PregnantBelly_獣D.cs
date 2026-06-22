using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class PregnantBelly_獣D : PregnantBellyD
    {
    	public bool 腹_表示;

    	public bool 臍_表示;

    	public List<ElementData> 腹板_接続 = new List<ElementData>();

    	public PregnantBelly_獣D()
    	{
    		ThisType = GetType();
    	}

    	public void 腹板接続(ElementData e)
    	{
    		腹板_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.PregnantBelly_獣_腹板_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new PregnantBelly_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
