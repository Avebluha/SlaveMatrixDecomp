using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 性器_獣D : 性器D
    {
    	public bool 小陰唇_表示 = true;

    	public bool 性器基_表示 = true;

    	public bool 陰核_表示 = true;

    	public bool 尿道_表示 = true;

    	public bool 膣口_表示 = true;

    	public double くぱぁ;

    	public List<ElementData> 陰核_接続 = new List<ElementData>();

    	public List<ElementData> 尿道_接続 = new List<ElementData>();

    	public List<ElementData> 膣口_接続 = new List<ElementData>();

    	public 性器_獣D()
    	{
    		ThisType = GetType();
    	}

    	public void 陰核接続(ElementData e)
    	{
    		陰核_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.性器_獣_陰核_接続;
    	}

    	public void 尿道接続(ElementData e)
    	{
    		尿道_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.性器_獣_尿道_接続;
    	}

    	public void 膣口接続(ElementData e)
    	{
    		膣口_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.性器_獣_膣口_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 性器_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
