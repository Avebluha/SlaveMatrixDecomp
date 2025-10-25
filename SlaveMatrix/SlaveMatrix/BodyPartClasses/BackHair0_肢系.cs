using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class BackHair0_肢系 : 下ろし
    {
    	public Par X0Y0_髪基;

    	public ColorD 髪基CD;

    	public ColorP X0Y0_髪基CP;

    	public Ele[] 左5_接続;

    	public Ele[] 左4_接続;

    	public Ele[] 左3_接続;

    	public Ele[] 左2_接続;

    	public Ele[] 左1_接続;

    	public Ele[] 中央_接続;

    	public Ele[] 右1_接続;

    	public Ele[] 右2_接続;

    	public Ele[] 右3_接続;

    	public Ele[] 右4_接続;

    	public Ele[] 右5_接続;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    		}
    	}

    	public override bool 筋肉
    	{
    		get
    		{
    			return 筋肉_;
    		}
    		set
    		{
    			筋肉_ = value;
    		}
    	}

    	public override bool 拘束
    	{
    		get
    		{
    			return 拘束_;
    		}
    		set
    		{
    			拘束_ = value;
    		}
    	}

    	public bool 髪基_表示
    	{
    		get
    		{
    			return X0Y0_髪基.Dra;
    		}
    		set
    		{
    			X0Y0_髪基.Dra = value;
    			X0Y0_髪基.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 髪基_表示;
    		}
    		set
    		{
    			髪基_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 髪基CD.不透明度;
    		}
    		set
    		{
    			髪基CD.不透明度 = value;
    		}
    	}

    	public double 髪長0
    	{
    		set
    		{
    			double num = 0.7 + 0.3 * value;
    			X0Y0_髪基.SizeYBase *= num;
    		}
    	}

    	public JointS 左5_接続点 => new JointS(本体, X0Y0_髪基, 5);

    	public JointS 左4_接続点 => new JointS(本体, X0Y0_髪基, 1);

    	public JointS 左3_接続点 => new JointS(本体, X0Y0_髪基, 7);

    	public JointS 左2_接続点 => new JointS(本体, X0Y0_髪基, 3);

    	public JointS 左1_接続点 => new JointS(本体, X0Y0_髪基, 9);

    	public JointS 中央_接続点 => new JointS(本体, X0Y0_髪基, 0);

    	public JointS 右1_接続点 => new JointS(本体, X0Y0_髪基, 10);

    	public JointS 右2_接続点 => new JointS(本体, X0Y0_髪基, 4);

    	public JointS 右3_接続点 => new JointS(本体, X0Y0_髪基, 8);

    	public JointS 右4_接続点 => new JointS(本体, X0Y0_髪基, 2);

    	public JointS 右5_接続点 => new JointS(本体, X0Y0_髪基, 6);

    	public BackHair0_肢系(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, BackHair0_肢系D e)
    	{
    		BackHair0_肢系 後髪0_肢系2 = this;
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "肢系";
    		dif.Add(new Pars(Sta.胴体["BackHair0"][0][21]));
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars = 本体[0][0];
    		X0Y0_髪基 = pars["髪基"].ToPar();
    		本体.SetJoints();
    		接続根 = new JointD(本体);
    		右 = e.右;
    		反転X = e.反転X;
    		反転Y = e.反転Y;
    		基準C = e.基準C;
    		位置C = e.位置C;
    		角度B = e.角度B;
    		角度C = e.角度C;
    		尺度B = e.尺度B;
    		尺度C = e.尺度C;
    		尺度XB = e.尺度XB;
    		尺度XC = e.尺度XC;
    		尺度YB = e.尺度YB;
    		尺度YC = e.尺度YC;
    		肥大 = e.肥大;
    		身長 = e.身長;
    		Xv = e.Xv;
    		Yv = e.Yv;
    		Xi = e.Xi;
    		Yi = e.Yi;
    		サイズ = e.サイズ;
    		サイズX = e.サイズX;
    		サイズY = e.サイズY;
    		髪基_表示 = e.髪基_表示;
    		髪長0 = e.髪長0;
    		if (e.スライム)
    		{
    			スライム();
    		}
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Ele f;
    		if (e.左5_接続.Count > 0)
    		{
    			左5_接続 = e.左5_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 後髪0_肢系2;
    				f.ConnectionType = ConnectionInfo.BackHair0_肢系_左5_接続;
    				f.接続(後髪0_肢系2.左5_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.左4_接続.Count > 0)
    		{
    			左4_接続 = e.左4_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 後髪0_肢系2;
    				f.ConnectionType = ConnectionInfo.BackHair0_肢系_左4_接続;
    				f.接続(後髪0_肢系2.左4_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.左3_接続.Count > 0)
    		{
    			左3_接続 = e.左3_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 後髪0_肢系2;
    				f.ConnectionType = ConnectionInfo.BackHair0_肢系_左3_接続;
    				f.接続(後髪0_肢系2.左3_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.左2_接続.Count > 0)
    		{
    			左2_接続 = e.左2_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 後髪0_肢系2;
    				f.ConnectionType = ConnectionInfo.BackHair0_肢系_左2_接続;
    				f.接続(後髪0_肢系2.左2_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.左1_接続.Count > 0)
    		{
    			左1_接続 = e.左1_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 後髪0_肢系2;
    				f.ConnectionType = ConnectionInfo.BackHair0_肢系_左1_接続;
    				f.接続(後髪0_肢系2.左1_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.中央_接続.Count > 0)
    		{
    			中央_接続 = e.中央_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 後髪0_肢系2;
    				f.ConnectionType = ConnectionInfo.BackHair0_肢系_中央_接続;
    				f.接続(後髪0_肢系2.中央_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右1_接続.Count > 0)
    		{
    			右1_接続 = e.右1_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 後髪0_肢系2;
    				f.ConnectionType = ConnectionInfo.BackHair0_肢系_右1_接続;
    				f.接続(後髪0_肢系2.右1_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右2_接続.Count > 0)
    		{
    			右2_接続 = e.右2_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 後髪0_肢系2;
    				f.ConnectionType = ConnectionInfo.BackHair0_肢系_右2_接続;
    				f.接続(後髪0_肢系2.右2_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右3_接続.Count > 0)
    		{
    			右3_接続 = e.右3_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 後髪0_肢系2;
    				f.ConnectionType = ConnectionInfo.BackHair0_肢系_右3_接続;
    				f.接続(後髪0_肢系2.右3_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右4_接続.Count > 0)
    		{
    			右4_接続 = e.右4_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 後髪0_肢系2;
    				f.ConnectionType = ConnectionInfo.BackHair0_肢系_右4_接続;
    				f.接続(後髪0_肢系2.右4_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右5_接続.Count > 0)
    		{
    			右5_接続 = e.右5_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 後髪0_肢系2;
    				f.ConnectionType = ConnectionInfo.BackHair0_肢系_右5_接続;
    				f.接続(後髪0_肢系2.右5_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_髪基CP = new ColorP(X0Y0_髪基, 髪基CD, DisUnit, abj: false);
    		濃度 = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		_ = 右;
    		本体.JoinPAall();
    	}

    	public void スライム()
    	{
    		X0Y0_髪基.OP[右 ? 1 : 0].Outline = false;
    		X0Y0_髪基.OP[(!右) ? 1 : 0].Outline = false;
    	}

    	public override void 色更新()
    	{
    		X0Y0_髪基CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		髪基CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    	}

    	public override IEnumerable<Ele> EnumEle()
    	{
    		yield return this;
    		if (中央_接続 != null)
    		{
    			foreach (Ele item in 中央_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item;
    			}
    		}
    		if (左1_接続 != null)
    		{
    			foreach (Ele item2 in 左1_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item2;
    			}
    		}
    		if (右1_接続 != null)
    		{
    			foreach (Ele item3 in 右1_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item3;
    			}
    		}
    		if (左2_接続 != null)
    		{
    			foreach (Ele item4 in 左2_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item4;
    			}
    		}
    		if (右2_接続 != null)
    		{
    			foreach (Ele item5 in 右2_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item5;
    			}
    		}
    		if (左3_接続 != null)
    		{
    			foreach (Ele item6 in 左3_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item6;
    			}
    		}
    		if (右3_接続 != null)
    		{
    			foreach (Ele item7 in 右3_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item7;
    			}
    		}
    		if (左4_接続 != null)
    		{
    			foreach (Ele item8 in 左4_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item8;
    			}
    		}
    		if (右4_接続 != null)
    		{
    			foreach (Ele item9 in 右4_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item9;
    			}
    		}
    		if (左5_接続 != null)
    		{
    			foreach (Ele item10 in 左5_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item10;
    			}
    		}
    		if (右5_接続 == null)
    		{
    			yield break;
    		}
    		foreach (Ele item11 in 右5_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    		{
    			yield return item11;
    		}
    	}
    }
}
