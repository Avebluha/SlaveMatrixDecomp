using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 多足_蜘D : 半身D
    {
    	public bool 胴_表示 = true;

    	public bool 胸版_表示 = true;

    	public bool 柄_表示 = true;

    	public List<EleD> 触肢左_接続 = new List<EleD>();

    	public List<EleD> 触肢右_接続 = new List<EleD>();

    	public List<EleD> 節足左1_接続 = new List<EleD>();

    	public List<EleD> 節足左2_接続 = new List<EleD>();

    	public List<EleD> 節足左3_接続 = new List<EleD>();

    	public List<EleD> 節足左4_接続 = new List<EleD>();

    	public List<EleD> 節足右1_接続 = new List<EleD>();

    	public List<EleD> 節足右2_接続 = new List<EleD>();

    	public List<EleD> 節足右3_接続 = new List<EleD>();

    	public List<EleD> 節足右4_接続 = new List<EleD>();

    	public List<EleD> 尾_接続 = new List<EleD>();

    	public 多足_蜘D()
    	{
    		ThisType = GetType();
    	}

    	public void 触肢左接続(EleD e)
    	{
    		触肢左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蜘_触肢左_接続;
    	}

    	public void 触肢右接続(EleD e)
    	{
    		触肢右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蜘_触肢右_接続;
    	}

    	public void 節足左1接続(EleD e)
    	{
    		節足左1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蜘_節足左1_接続;
    	}

    	public void 節足左2接続(EleD e)
    	{
    		節足左2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蜘_節足左2_接続;
    	}

    	public void 節足左3接続(EleD e)
    	{
    		節足左3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蜘_節足左3_接続;
    	}

    	public void 節足左4接続(EleD e)
    	{
    		節足左4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蜘_節足左4_接続;
    	}

    	public void 節足右1接続(EleD e)
    	{
    		節足右1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蜘_節足右1_接続;
    	}

    	public void 節足右2接続(EleD e)
    	{
    		節足右2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蜘_節足右2_接続;
    	}

    	public void 節足右3接続(EleD e)
    	{
    		節足右3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蜘_節足右3_接続;
    	}

    	public void 節足右4接続(EleD e)
    	{
    		節足右4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蜘_節足右4_接続;
    	}

    	public void 尾接続(EleD e)
    	{
    		尾_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蜘_尾_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 1.0;
    		}
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 多足_蜘(DisUnit, 配色指定, 体配色, Med, this);
    	}

    	public override IEnumerable<EleD> EnumEleD()
    	{
    		yield return this;
    		if (尾_接続 != null)
    		{
    			foreach (EleD item in 尾_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item;
    			}
    		}
    		if (節足左4_接続 != null)
    		{
    			foreach (EleD item2 in 節足左4_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item2;
    			}
    		}
    		if (節足右4_接続 != null)
    		{
    			foreach (EleD item3 in 節足右4_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item3;
    			}
    		}
    		if (節足左3_接続 != null)
    		{
    			foreach (EleD item4 in 節足左3_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item4;
    			}
    		}
    		if (節足右3_接続 != null)
    		{
    			foreach (EleD item5 in 節足右3_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item5;
    			}
    		}
    		if (節足左2_接続 != null)
    		{
    			foreach (EleD item6 in 節足左2_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item6;
    			}
    		}
    		if (節足右2_接続 != null)
    		{
    			foreach (EleD item7 in 節足右2_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item7;
    			}
    		}
    		if (節足左1_接続 != null)
    		{
    			foreach (EleD item8 in 節足左1_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item8;
    			}
    		}
    		if (節足右1_接続 != null)
    		{
    			foreach (EleD item9 in 節足右1_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item9;
    			}
    		}
    		if (触肢左_接続 != null)
    		{
    			foreach (EleD item10 in 触肢左_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item10;
    			}
    		}
    		if (触肢右_接続 == null)
    		{
    			yield break;
    		}
    		foreach (EleD item11 in 触肢右_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    		{
    			yield return item11;
    		}
    	}
    }
}
