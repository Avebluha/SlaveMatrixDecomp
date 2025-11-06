using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 長物_鯨D : 半身D
    {
    	public bool 胴6_表示 = true;

    	public bool 胴6_柄_表示 = true;

    	public bool 胴6_縦影_表示 = true;

    	public bool 胴5_表示 = true;

    	public bool 胴5_柄_表示 = true;

    	public bool 胴5_縦影_表示 = true;

    	public bool 輪2_革_表示 = true;

    	public bool 輪2_金具1_表示 = true;

    	public bool 輪2_金具2_表示 = true;

    	public bool 輪2_金具3_表示 = true;

    	public bool 輪2_金具左_表示 = true;

    	public bool 輪2_金具右_表示 = true;

    	public bool 胴4_表示 = true;

    	public bool 胴4_柄_表示 = true;

    	public bool 胴4_縦影_表示 = true;

    	public bool 胴3_表示 = true;

    	public bool 胴3_柄_表示 = true;

    	public bool 胴3_縦影_表示 = true;

    	public bool 胴2_表示 = true;

    	public bool 胴2_柄_表示 = true;

    	public bool 胴2_縦影_表示 = true;

    	public bool 胴1_表示 = true;

    	public bool 胴1_柄_表示 = true;

    	public bool 胴1_縦影_表示 = true;

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

    	public List<EleD> 左0_接続 = new List<EleD>();

    	public List<EleD> 右0_接続 = new List<EleD>();

    	public List<EleD> 左1_接続 = new List<EleD>();

    	public List<EleD> 右1_接続 = new List<EleD>();

    	public List<EleD> 左2_接続 = new List<EleD>();

    	public List<EleD> 右2_接続 = new List<EleD>();

    	public List<EleD> 左3_接続 = new List<EleD>();

    	public List<EleD> 右3_接続 = new List<EleD>();

    	public List<EleD> 左4_接続 = new List<EleD>();

    	public List<EleD> 右4_接続 = new List<EleD>();

    	public List<EleD> 左5_接続 = new List<EleD>();

    	public List<EleD> 右5_接続 = new List<EleD>();

    	public List<EleD> 左6_接続 = new List<EleD>();

    	public List<EleD> 右6_接続 = new List<EleD>();

    	public List<EleD> 尾_接続 = new List<EleD>();

    	public 長物_鯨D()
    	{
    		ThisType = GetType();
    	}

    	public void 左0接続(EleD e)
    	{
    		左0_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左0_接続;
    	}

    	public void 右0接続(EleD e)
    	{
    		右0_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右0_接続;
    	}

    	public void 左1接続(EleD e)
    	{
    		左1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左1_接続;
    	}

    	public void 右1接続(EleD e)
    	{
    		右1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右1_接続;
    	}

    	public void 左2接続(EleD e)
    	{
    		左2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左2_接続;
    	}

    	public void 右2接続(EleD e)
    	{
    		右2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右2_接続;
    	}

    	public void 左3接続(EleD e)
    	{
    		左3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左3_接続;
    	}

    	public void 右3接続(EleD e)
    	{
    		右3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右3_接続;
    	}

    	public void 左4接続(EleD e)
    	{
    		左4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左4_接続;
    	}

    	public void 右4接続(EleD e)
    	{
    		右4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右4_接続;
    	}

    	public void 左5接続(EleD e)
    	{
    		左5_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左5_接続;
    	}

    	public void 右5接続(EleD e)
    	{
    		右5_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右5_接続;
    	}

    	public void 左6接続(EleD e)
    	{
    		左6_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_左6_接続;
    	}

    	public void 右6接続(EleD e)
    	{
    		右6_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_右6_接続;
    	}

    	public void 尾接続(EleD e)
    	{
    		尾_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_鯨_尾_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 長物_鯨(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
