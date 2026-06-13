using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 単足_植D : 半身D
    {
    	public bool 幹上_表示 = true;

    	public bool 幹下_表示 = true;

    	public bool 葉左_表示 = true;

    	public bool 葉右_表示 = true;

    	public bool 脈上1_表示 = true;

    	public bool 脈上2_表示 = true;

    	public bool 脈下1_表示 = true;

    	public bool 脈下2_表示 = true;

    	public bool 虫食_左_虫食1_表示;

    	public bool 虫食_左_虫食2_表示;

    	public bool 虫食_左_虫食3_表示;

    	public bool 虫食_左_虫食4_表示;

    	public bool 虫食_左_虫食5_表示;

    	public bool 虫食_左_虫食6_表示;

    	public bool 虫食_左_虫食7_表示;

    	public bool 虫食_左_虫食8_表示;

    	public bool 虫食_左_虫食9_表示;

    	public bool 虫食_左_虫食10_表示;

    	public bool 虫食_左_虫食11_表示;

    	public bool 虫食_左_虫食12_表示;

    	public bool 虫食_右_虫食1_表示;

    	public bool 虫食_右_虫食2_表示;

    	public bool 虫食_右_虫食3_表示;

    	public bool 虫食_右_虫食4_表示;

    	public bool 虫食_右_虫食5_表示;

    	public bool 虫食_右_虫食6_表示;

    	public bool 虫食_右_虫食7_表示;

    	public bool 虫食_右_虫食8_表示;

    	public bool 虫食_右_虫食9_表示;

    	public bool 虫食_右_虫食10_表示;

    	public bool 虫食_右_虫食11_表示;

    	public bool 虫食_右_虫食12_表示;

    	public bool 脚輪_革_表示 = true;

    	public bool 脚輪_金具1_表示 = true;

    	public bool 脚輪_金具2_表示 = true;

    	public bool 脚輪_金具3_表示 = true;

    	public bool 脚輪_金具左_表示 = true;

    	public bool 脚輪_金具右_表示 = true;

    	public bool 脚輪表示 = true;

    	public bool 鎖表示;

    	public List<ElementData> 根外左_接続 = new List<ElementData>();

    	public List<ElementData> 根内左_接続 = new List<ElementData>();

    	public List<ElementData> 根中央_接続 = new List<ElementData>();

    	public List<ElementData> 根内右_接続 = new List<ElementData>();

    	public List<ElementData> 根外右_接続 = new List<ElementData>();

    	public 単足_植D()
    	{
    		ThisType = GetType();
    	}

    	public void 根外左接続(ElementData e)
    	{
    		根外左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.単足_植_根外左_接続;
    	}

    	public void 根内左接続(ElementData e)
    	{
    		根内左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.単足_植_根内左_接続;
    	}

    	public void 根中央接続(ElementData e)
    	{
    		根中央_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.単足_植_根中央_接続;
    	}

    	public void 根内右接続(ElementData e)
    	{
    		根内右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.単足_植_根内右_接続;
    	}

    	public void 根外右接続(ElementData e)
    	{
    		根外右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.単足_植_根外右_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 単足_植(DisUnit, 配色指定, 体配色, Med, this);
    	}

    	public override IEnumerable<ElementData> EnumEleD()
    	{
    		yield return this;
    		if (根外左_接続 != null)
    		{
    			foreach (ElementData item in 根外左_接続.Select((ElementData e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item;
    			}
    		}
    		if (根外右_接続 != null)
    		{
    			foreach (ElementData item2 in 根外右_接続.Select((ElementData e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item2;
    			}
    		}
    		if (根内左_接続 != null)
    		{
    			foreach (ElementData item3 in 根内左_接続.Select((ElementData e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item3;
    			}
    		}
    		if (根内右_接続 != null)
    		{
    			foreach (ElementData item4 in 根内右_接続.Select((ElementData e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item4;
    			}
    		}
    		if (根中央_接続 == null)
    		{
    			yield break;
    		}
    		foreach (ElementData item5 in 根中央_接続.Select((ElementData e) => e.EnumEleD()).JoinEnum())
    		{
    			yield return item5;
    		}
    	}
    }
}
