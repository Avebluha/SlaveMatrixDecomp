using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 前翅_甲D : 前翅D
    {
    	public bool 前翅_前翅軸_軸1_表示 = true;

    	public bool 前翅_前翅軸_軸2_表示 = true;

    	public bool 前翅_前翅軸_軸3_表示 = true;

    	public bool 前翅_前翅甲_甲2_表示 = true;

    	public bool 前翅_前翅甲_甲1_表示 = true;

    	public bool 前翅_前翅甲_紋1_表示 = true;

    	public bool 前翅_前翅甲_紋2_表示 = true;

    	public bool 前翅_前翅甲_紋3_表示 = true;

    	public bool 前翅_前翅甲_紋4_表示 = true;

    	public bool 前翅_前翅甲_紋5_表示 = true;

    	public bool 前翅_前翅甲_紋6_表示 = true;

    	public bool 前翅_前翅甲_紋7_表示 = true;

    	public bool 付根_付根0_表示 = true;

    	public bool 付根_付根1_表示 = true;

    	public bool 付根_付根2_表示 = true;

    	public bool 甲付根_表示 = true;

    	public bool 紋1_表示 = true;

    	public bool 紋2_表示 = true;

    	public bool 前翅_前翅軸_罅線_表示 = true;

    	public bool 前翅_前翅甲_罅線1_表示 = true;

    	public bool 前翅_前翅甲_罅線2_表示 = true;

    	public bool 欠け1_表示 = true;

    	public bool 欠け2_表示 = true;

    	public bool 欠け3_表示 = true;

    	public double 展開;

    	public List<ElementData> 軸1_接続 = new List<ElementData>();

    	public List<ElementData> 軸2_接続 = new List<ElementData>();

    	public List<ElementData> 軸3_接続 = new List<ElementData>();

    	public 前翅_甲D()
    	{
    		ThisType = GetType();
    	}

    	public void 軸1接続(ElementData e)
    	{
    		軸1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.前翅_甲_軸1_接続;
    	}

    	public void 軸2接続(ElementData e)
    	{
    		軸2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.前翅_甲_軸2_接続;
    	}

    	public void 軸3接続(ElementData e)
    	{
    		軸3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.前翅_甲_軸3_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 前翅_甲(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
