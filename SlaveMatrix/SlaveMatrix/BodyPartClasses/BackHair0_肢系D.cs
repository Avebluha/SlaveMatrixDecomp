using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class BackHair0_肢系D : 下ろしD
    {
    	public bool 髪基_表示 = true;

    	public double 髪長0;

    	public bool スライム;

    	public List<EleD> 左5_接続 = new List<EleD>();

    	public List<EleD> 左4_接続 = new List<EleD>();

    	public List<EleD> 左3_接続 = new List<EleD>();

    	public List<EleD> 左2_接続 = new List<EleD>();

    	public List<EleD> 左1_接続 = new List<EleD>();

    	public List<EleD> 中央_接続 = new List<EleD>();

    	public List<EleD> 右1_接続 = new List<EleD>();

    	public List<EleD> 右2_接続 = new List<EleD>();

    	public List<EleD> 右3_接続 = new List<EleD>();

    	public List<EleD> 右4_接続 = new List<EleD>();

    	public List<EleD> 右5_接続 = new List<EleD>();

    	public BackHair0_肢系D()
    	{
    		ThisType = GetType();
    	}

    	public void 左5接続(EleD e)
    	{
    		左5_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BackHair0_肢系_左5_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 0.6;
    		}
    	}

    	public void 左4接続(EleD e)
    	{
    		左4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BackHair0_肢系_左4_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 0.6;
    		}
    	}

    	public void 左3接続(EleD e)
    	{
    		左3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BackHair0_肢系_左3_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 0.6;
    		}
    	}

    	public void 左2接続(EleD e)
    	{
    		左2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BackHair0_肢系_左2_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 0.6;
    		}
    	}

    	public void 左1接続(EleD e)
    	{
    		左1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BackHair0_肢系_左1_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 0.6;
    		}
    	}

    	public void 中央接続(EleD e)
    	{
    		中央_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BackHair0_肢系_中央_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 0.6;
    		}
    	}

    	public void 右1接続(EleD e)
    	{
    		右1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BackHair0_肢系_右1_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 0.6;
    		}
    	}

    	public void 右2接続(EleD e)
    	{
    		右2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BackHair0_肢系_右2_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 0.6;
    		}
    	}

    	public void 右3接続(EleD e)
    	{
    		右3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BackHair0_肢系_右3_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 0.6;
    		}
    	}

    	public void 右4接続(EleD e)
    	{
    		右4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BackHair0_肢系_右4_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 0.6;
    		}
    	}

    	public void 右5接続(EleD e)
    	{
    		右5_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BackHair0_肢系_右5_接続;
    		foreach (EleD item in e.EnumEleD())
    		{
    			item.尺度B = 0.6;
    		}
    	}

    	public BackHair0_肢系D SetRandom()
    	{
    		髪長0 = RNG.XS.NextDouble();
    		右 = RNG.XS.NextBool();
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new BackHair0_肢系(DisUnit, 配色指定, 体配色, Med, this);
    	}

    	public override IEnumerable<EleD> EnumEleD()
    	{
    		yield return this;
    		if (中央_接続 != null)
    		{
    			foreach (EleD item in 中央_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item;
    			}
    		}
    		if (左1_接続 != null)
    		{
    			foreach (EleD item2 in 左1_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item2;
    			}
    		}
    		if (右1_接続 != null)
    		{
    			foreach (EleD item3 in 右1_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item3;
    			}
    		}
    		if (左2_接続 != null)
    		{
    			foreach (EleD item4 in 左2_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item4;
    			}
    		}
    		if (右2_接続 != null)
    		{
    			foreach (EleD item5 in 右2_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item5;
    			}
    		}
    		if (左3_接続 != null)
    		{
    			foreach (EleD item6 in 左3_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item6;
    			}
    		}
    		if (右3_接続 != null)
    		{
    			foreach (EleD item7 in 右3_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item7;
    			}
    		}
    		if (左4_接続 != null)
    		{
    			foreach (EleD item8 in 左4_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item8;
    			}
    		}
    		if (右4_接続 != null)
    		{
    			foreach (EleD item9 in 右4_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item9;
    			}
    		}
    		if (左5_接続 != null)
    		{
    			foreach (EleD item10 in 左5_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item10;
    			}
    		}
    		if (右5_接続 == null)
    		{
    			yield break;
    		}
    		foreach (EleD item11 in 右5_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    		{
    			yield return item11;
    		}
    	}
    }
}
