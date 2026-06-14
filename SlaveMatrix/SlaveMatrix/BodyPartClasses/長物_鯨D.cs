using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 長物_鯨D : 半身D
    {
    	public bool Torso6_表示 = true;

    	public bool Torso6_柄_表示 = true;

    	public bool Torso6_縦影_表示 = true;

    	public bool Torso5_表示 = true;

    	public bool Torso5_柄_表示 = true;

    	public bool Torso5_縦影_表示 = true;

    	public bool 輪2_革_表示 = true;

    	public bool 輪2_金具1_表示 = true;

    	public bool 輪2_金具2_表示 = true;

    	public bool 輪2_金具3_表示 = true;

    	public bool 輪2_金具左_表示 = true;

    	public bool 輪2_金具右_表示 = true;

    	public bool Torso4_表示 = true;

    	public bool Torso4_柄_表示 = true;

    	public bool Torso4_縦影_表示 = true;

    	public bool Torso3_表示 = true;

    	public bool Torso3_柄_表示 = true;

    	public bool Torso3_縦影_表示 = true;

    	public bool Torso2_表示 = true;

    	public bool Torso2_柄_表示 = true;

    	public bool Torso2_縦影_表示 = true;

    	public bool Torso1_表示 = true;

    	public bool Torso1_柄_表示 = true;

    	public bool Torso1_縦影_表示 = true;

    	public bool 輪1_革_表示 = true;

    	public bool 輪1_金具1_表示 = true;

    	public bool 輪1_金具2_表示 = true;

    	public bool 輪1_金具3_表示 = true;

    	public bool 輪1_金具左_表示 = true;

    	public bool 輪1_金具右_表示 = true;

    	public bool 輪1表示 = true;

    	public bool 輪2表示 = true;

    	public bool 柄 = true;

    	public bool 縦影 = true;

    	public bool 鎖表示;

    	public List<ElementData> 左0_接続 = new List<ElementData>();

    	public List<ElementData> 右0_接続 = new List<ElementData>();

    	public List<ElementData> 左1_接続 = new List<ElementData>();

    	public List<ElementData> 右1_接続 = new List<ElementData>();

    	public List<ElementData> 左2_接続 = new List<ElementData>();

    	public List<ElementData> 右2_接続 = new List<ElementData>();

    	public List<ElementData> 左3_接続 = new List<ElementData>();

    	public List<ElementData> 右3_接続 = new List<ElementData>();

    	public List<ElementData> 左4_接続 = new List<ElementData>();

    	public List<ElementData> 右4_接続 = new List<ElementData>();

    	public List<ElementData> 左5_接続 = new List<ElementData>();

    	public List<ElementData> 右5_接続 = new List<ElementData>();

    	public List<ElementData> 左6_接続 = new List<ElementData>();

    	public List<ElementData> 右6_接続 = new List<ElementData>();

    	public List<ElementData> 尾_接続 = new List<ElementData>();

    	public 長物_鯨D()
    	{
    		ThisType = GetType();
    	}

    	public void 左0接続(ElementData e)
    	{
    		左0_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左0_接続;
    	}

    	public void 右0接続(ElementData e)
    	{
    		右0_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右0_接続;
    	}

    	public void 左1接続(ElementData e)
    	{
    		左1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左1_接続;
    	}

    	public void 右1接続(ElementData e)
    	{
    		右1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右1_接続;
    	}

    	public void 左2接続(ElementData e)
    	{
    		左2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左2_接続;
    	}

    	public void 右2接続(ElementData e)
    	{
    		右2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右2_接続;
    	}

    	public void 左3接続(ElementData e)
    	{
    		左3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左3_接続;
    	}

    	public void 右3接続(ElementData e)
    	{
    		右3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右3_接続;
    	}

    	public void 左4接続(ElementData e)
    	{
    		左4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左4_接続;
    	}

    	public void 右4接続(ElementData e)
    	{
    		右4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右4_接続;
    	}

    	public void 左5接続(ElementData e)
    	{
    		左5_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左5_接続;
    	}

    	public void 右5接続(ElementData e)
    	{
    		右5_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右5_接続;
    	}

    	public void 左6接続(ElementData e)
    	{
    		左6_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左6_接続;
    	}

    	public void 右6接続(ElementData e)
    	{
    		右6_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右6_接続;
    	}

    	public void 尾接続(ElementData e)
    	{
    		尾_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_尾_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 長物_鯨(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
