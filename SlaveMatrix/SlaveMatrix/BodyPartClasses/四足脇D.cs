using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 四足脇D : ElementData
    {
    	public bool 脇_表示 = true;

    	public bool 筋肉_表示 = true;

    	public double 筋肉濃度 = 1.0;

    	public List<ElementData> UpperArm_接続 = new List<ElementData>();

    	public 四足脇D()
    	{
    		ThisType = GetType();
    	}

    	public void UpperArm接続(ElementData e)
    	{
    		UpperArm_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.四足脇_UpperArm_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 四足脇(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
