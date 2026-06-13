using _2DGAMELIB;
using SlaveMatrix.GameClasses;
using System.Linq;

namespace SlaveMatrix
{
    public class Torso_蟲 : 長胴
    {
    	public Par X0Y0_Torso_背板;

    	public Par X0Y0_Torso_節;

    	public Par X0Y0_Torso_胸板;

    	public Par X0Y0_Torso_Torso;

    	public Par X0Y0_Torso_瘤左2;

    	public Par X0Y0_Torso_瘤左1;

    	public Par X0Y0_Torso_瘤右2;

    	public Par X0Y0_Torso_瘤右1;

    	public Par X0Y0_輪_革;

    	public Par X0Y0_輪_金具1;

    	public Par X0Y0_輪_金具2;

    	public Par X0Y0_輪_金具3;

    	public Par X0Y0_輪_金具左;

    	public Par X0Y0_輪_金具右;

    	public ColorD Torso_背板CD;

    	public ColorD Torso_節CD;

    	public ColorD Torso_胸板CD;

    	public ColorD Torso_TorsoCD;

    	public ColorD Torso_瘤左2CD;

    	public ColorD Torso_瘤左1CD;

    	public ColorD Torso_瘤右2CD;

    	public ColorD Torso_瘤右1CD;

    	public ColorD 輪_革CD;

    	public ColorD 輪_金具1CD;

    	public ColorD 輪_金具2CD;

    	public ColorD 輪_金具3CD;

    	public ColorD 輪_金具左CD;

    	public ColorD 輪_金具右CD;

    	public ColorP X0Y0_Torso_背板CP;

    	public ColorP X0Y0_Torso_節CP;

    	public ColorP X0Y0_Torso_胸板CP;

    	public ColorP X0Y0_Torso_TorsoCP;

    	public ColorP X0Y0_Torso_瘤左2CP;

    	public ColorP X0Y0_Torso_瘤左1CP;

    	public ColorP X0Y0_Torso_瘤右2CP;

    	public ColorP X0Y0_Torso_瘤右1CP;

    	public ColorP X0Y0_輪_革CP;

    	public ColorP X0Y0_輪_金具1CP;

    	public ColorP X0Y0_輪_金具2CP;

    	public ColorP X0Y0_輪_金具3CP;

    	public ColorP X0Y0_輪_金具左CP;

    	public ColorP X0Y0_輪_金具右CP;

    	public 拘束鎖 鎖1;

    	public 拘束鎖 鎖2;

    	public Ele[] 左_接続;

    	public Ele[] 右_接続;

    	public Ele[] Torso_接続;

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
    			輪表示 = 拘束_;
    		}
    	}

    	public bool Torso_背板_表示
    	{
    		get
    		{
    			return X0Y0_Torso_背板.Dra;
    		}
    		set
    		{
    			X0Y0_Torso_背板.Dra = value;
    			X0Y0_Torso_背板.Hit = value;
    		}
    	}

    	public bool Torso_節_表示
    	{
    		get
    		{
    			return X0Y0_Torso_節.Dra;
    		}
    		set
    		{
    			X0Y0_Torso_節.Dra = value;
    			X0Y0_Torso_節.Hit = value;
    		}
    	}

    	public bool Torso_胸板_表示
    	{
    		get
    		{
    			return X0Y0_Torso_胸板.Dra;
    		}
    		set
    		{
    			X0Y0_Torso_胸板.Dra = value;
    			X0Y0_Torso_胸板.Hit = value;
    		}
    	}

    	public bool Torso_Torso_表示
    	{
    		get
    		{
    			return X0Y0_Torso_Torso.Dra;
    		}
    		set
    		{
    			X0Y0_Torso_Torso.Dra = value;
    			X0Y0_Torso_Torso.Hit = value;
    		}
    	}

    	public bool Torso_瘤左2_表示
    	{
    		get
    		{
    			return X0Y0_Torso_瘤左2.Dra;
    		}
    		set
    		{
    			X0Y0_Torso_瘤左2.Dra = value;
    			X0Y0_Torso_瘤左2.Hit = value;
    		}
    	}

    	public bool Torso_瘤左1_表示
    	{
    		get
    		{
    			return X0Y0_Torso_瘤左1.Dra;
    		}
    		set
    		{
    			X0Y0_Torso_瘤左1.Dra = value;
    			X0Y0_Torso_瘤左1.Hit = value;
    		}
    	}

    	public bool Torso_瘤右2_表示
    	{
    		get
    		{
    			return X0Y0_Torso_瘤右2.Dra;
    		}
    		set
    		{
    			X0Y0_Torso_瘤右2.Dra = value;
    			X0Y0_Torso_瘤右2.Hit = value;
    		}
    	}

    	public bool Torso_瘤右1_表示
    	{
    		get
    		{
    			return X0Y0_Torso_瘤右1.Dra;
    		}
    		set
    		{
    			X0Y0_Torso_瘤右1.Dra = value;
    			X0Y0_Torso_瘤右1.Hit = value;
    		}
    	}

    	public bool 輪_革_表示
    	{
    		get
    		{
    			return X0Y0_輪_革.Dra;
    		}
    		set
    		{
    			X0Y0_輪_革.Dra = value;
    			X0Y0_輪_革.Hit = value;
    		}
    	}

    	public bool 輪_金具1_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具1.Dra = value;
    			X0Y0_輪_金具1.Hit = value;
    		}
    	}

    	public bool 輪_金具2_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具2.Dra = value;
    			X0Y0_輪_金具2.Hit = value;
    		}
    	}

    	public bool 輪_金具3_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具3.Dra = value;
    			X0Y0_輪_金具3.Hit = value;
    		}
    	}

    	public bool 輪_金具左_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具左.Dra = value;
    			X0Y0_輪_金具左.Hit = value;
    		}
    	}

    	public bool 輪_金具右_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具右.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具右.Dra = value;
    			X0Y0_輪_金具右.Hit = value;
    		}
    	}

    	public bool 輪表示
    	{
    		get
    		{
    			return 輪_革_表示;
    		}
    		set
    		{
    			輪_革_表示 = value;
    			輪_金具1_表示 = value;
    			輪_金具2_表示 = value;
    			輪_金具3_表示 = value;
    			輪_金具左_表示 = value;
    			輪_金具右_表示 = value;
    		}
    	}

    	public bool 鎖表示
    	{
    		get
    		{
    			return 鎖1.表示;
    		}
    		set
    		{
    			鎖1.表示 = value;
    			鎖2.表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return Torso_背板_表示;
    		}
    		set
    		{
    			Torso_背板_表示 = value;
    			Torso_節_表示 = value;
    			Torso_胸板_表示 = value;
    			Torso_Torso_表示 = value;
    			Torso_瘤左2_表示 = value;
    			Torso_瘤左1_表示 = value;
    			Torso_瘤右2_表示 = value;
    			Torso_瘤右1_表示 = value;
    			輪_革_表示 = value;
    			輪_金具1_表示 = value;
    			輪_金具2_表示 = value;
    			輪_金具3_表示 = value;
    			輪_金具左_表示 = value;
    			輪_金具右_表示 = value;
    			鎖1.表示 = value;
    			鎖2.表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return Torso_背板CD.不透明度;
    		}
    		set
    		{
    			Torso_背板CD.不透明度 = value;
    			Torso_節CD.不透明度 = value;
    			Torso_胸板CD.不透明度 = value;
    			Torso_TorsoCD.不透明度 = value;
    			Torso_瘤左2CD.不透明度 = value;
    			Torso_瘤左1CD.不透明度 = value;
    			Torso_瘤右2CD.不透明度 = value;
    			Torso_瘤右1CD.不透明度 = value;
    			輪_革CD.不透明度 = value;
    			輪_金具1CD.不透明度 = value;
    			輪_金具2CD.不透明度 = value;
    			輪_金具3CD.不透明度 = value;
    			輪_金具左CD.不透明度 = value;
    			輪_金具右CD.不透明度 = value;
    		}
    	}

    	public bool 背板
    	{
    		get
    		{
    			return Torso_背板_表示;
    		}
    		set
    		{
    			Torso_背板_表示 = value;
    		}
    	}

    	public bool 節
    	{
    		get
    		{
    			return Torso_節_表示;
    		}
    		set
    		{
    			Torso_節_表示 = value;
    		}
    	}

    	public bool 胸板
    	{
    		get
    		{
    			return Torso_胸板_表示;
    		}
    		set
    		{
    			Torso_胸板_表示 = value;
    		}
    	}

    	public bool Torso
    	{
    		get
    		{
    			return Torso_Torso_表示;
    		}
    		set
    		{
    			Torso_Torso_表示 = value;
    		}
    	}

    	public bool 瘤
    	{
    		get
    		{
    			return Torso_瘤左2_表示;
    		}
    		set
    		{
    			Torso_瘤左2_表示 = value;
    			Torso_瘤左1_表示 = value;
    			Torso_瘤右2_表示 = value;
    			Torso_瘤右1_表示 = value;
    		}
    	}

    	public JointS 左_接続点 => new JointS(Body, X0Y0_Torso_Torso, 0);

    	public JointS 右_接続点 => new JointS(Body, X0Y0_Torso_Torso, 1);

    	public JointS Torso_接続点 => new JointS(Body, X0Y0_Torso_Torso, 3);

    	public JointS 鎖1_接続点 => new JointS(Body, X0Y0_輪_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(Body, X0Y0_輪_金具右, 0);

    	public Torso_蟲(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, Torso_蟲D e)
    	{
    		Torso_蟲 Torso_蟲2 = this;
    		ThisType = GetType();
    		Pars pars = new Pars();
    		pars.Tag = "蟲";
    		pars.Add(new Pars(Sta.半身["長物"][0][3]["胴4"].ToPars()));
    		pars.Add(new Pars(Sta.半身["長物"][0][3]["輪2"].ToPars()));
    		Dif dif = new Dif();
    		dif.Tag = pars.Tag;
    		dif.Add(pars);
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars2 = Body[0][0];
    		Pars pars3 = pars2["胴4"].ToPars();
    		X0Y0_Torso_背板 = pars3["背板"].ToPar();
    		X0Y0_Torso_節 = pars3["節"].ToPar();
    		X0Y0_Torso_胸板 = pars3["胸板"].ToPar();
    		X0Y0_Torso_Torso = pars3["Torso"].ToPar();
    		X0Y0_Torso_瘤左2 = pars3["瘤左2"].ToPar();
    		X0Y0_Torso_瘤左1 = pars3["瘤左1"].ToPar();
    		X0Y0_Torso_瘤右2 = pars3["瘤右2"].ToPar();
    		X0Y0_Torso_瘤右1 = pars3["瘤右1"].ToPar();
    		pars3 = pars2["輪2"].ToPars();
    		X0Y0_輪_革 = pars3["革"].ToPar();
    		X0Y0_輪_金具1 = pars3["金具1"].ToPar();
    		X0Y0_輪_金具2 = pars3["金具2"].ToPar();
    		X0Y0_輪_金具3 = pars3["金具3"].ToPar();
    		X0Y0_輪_金具左 = pars3["金具左"].ToPar();
    		X0Y0_輪_金具右 = pars3["金具右"].ToPar();
    		Body.SetJoints();
    		接続根 = new JointD(Body);
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
    		Torso_背板_表示 = e.Torso_背板_表示;
    		Torso_節_表示 = e.Torso_節_表示;
    		Torso_胸板_表示 = e.Torso_胸板_表示;
    		Torso_Torso_表示 = e.Torso_Torso_表示;
    		Torso_瘤左2_表示 = e.Torso_瘤左2_表示;
    		Torso_瘤左1_表示 = e.Torso_瘤左1_表示;
    		Torso_瘤右2_表示 = e.Torso_瘤右2_表示;
    		Torso_瘤右1_表示 = e.Torso_瘤右1_表示;
    		輪_革_表示 = e.輪_革_表示;
    		輪_金具1_表示 = e.輪_金具1_表示;
    		輪_金具2_表示 = e.輪_金具2_表示;
    		輪_金具3_表示 = e.輪_金具3_表示;
    		輪_金具左_表示 = e.輪_金具左_表示;
    		輪_金具右_表示 = e.輪_金具右_表示;
    		輪表示 = e.輪表示;
    		背板 = e.背板;
    		節 = e.節;
    		胸板 = e.胸板;
    		Torso = e.Torso;
    		瘤 = e.瘤;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Ele f;
    		if (e.左_接続.Count > 0)
    		{
    			左_接続 = e.左_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Torso_蟲2;
    				f.ConnectionType = ConnectionInfo.Torso_蟲_左_接続;
    				f.接続(Torso_蟲2.左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右_接続.Count > 0)
    		{
    			右_接続 = e.右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Torso_蟲2;
    				f.ConnectionType = ConnectionInfo.Torso_蟲_右_接続;
    				f.接続(Torso_蟲2.右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.Torso_接続.Count > 0)
    		{
    			Torso_接続 = e.Torso_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Torso_蟲2;
    				f.ConnectionType = ConnectionInfo.Torso_蟲_Torso_接続;
    				f.接続(Torso_蟲2.Torso_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_Torso_背板CP = new ColorP(X0Y0_Torso_背板, Torso_背板CD, DisUnit, abj: true);
    		X0Y0_Torso_節CP = new ColorP(X0Y0_Torso_節, Torso_節CD, DisUnit, abj: true);
    		X0Y0_Torso_胸板CP = new ColorP(X0Y0_Torso_胸板, Torso_胸板CD, DisUnit, abj: true);
    		X0Y0_Torso_TorsoCP = new ColorP(X0Y0_Torso_Torso, Torso_TorsoCD, DisUnit, abj: true);
    		X0Y0_Torso_瘤左2CP = new ColorP(X0Y0_Torso_瘤左2, Torso_瘤左2CD, DisUnit, abj: true);
    		X0Y0_Torso_瘤左1CP = new ColorP(X0Y0_Torso_瘤左1, Torso_瘤左1CD, DisUnit, abj: true);
    		X0Y0_Torso_瘤右2CP = new ColorP(X0Y0_Torso_瘤右2, Torso_瘤右2CD, DisUnit, abj: true);
    		X0Y0_Torso_瘤右1CP = new ColorP(X0Y0_Torso_瘤右1, Torso_瘤右1CD, DisUnit, abj: true);
    		X0Y0_輪_革CP = new ColorP(X0Y0_輪_革, 輪_革CD, DisUnit, abj: true);
    		X0Y0_輪_金具1CP = new ColorP(X0Y0_輪_金具1, 輪_金具1CD, DisUnit, abj: true);
    		X0Y0_輪_金具2CP = new ColorP(X0Y0_輪_金具2, 輪_金具2CD, DisUnit, abj: true);
    		X0Y0_輪_金具3CP = new ColorP(X0Y0_輪_金具3, 輪_金具3CD, DisUnit, abj: true);
    		X0Y0_輪_金具左CP = new ColorP(X0Y0_輪_金具左, 輪_金具左CD, DisUnit, abj: true);
    		X0Y0_輪_金具右CP = new ColorP(X0Y0_輪_金具右, 輪_金具右CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		鎖1 = new 拘束鎖(DisUnit, 右, 配色指定, 体配色, Xasix);
    		鎖2 = new 拘束鎖(DisUnit, !右, 配色指定, 体配色, Xasix);
    		鎖1.接続(鎖1_接続点);
    		鎖2.接続(鎖2_接続点);
    		int num = (右 ? (-10) : 10);
    		鎖1.角度B += num;
    		鎖2.角度B -= num;
    		鎖表示 = e.鎖表示;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Body.Draw(Are);
    		鎖1.描画0(Are);
    		鎖2.描画0(Are);
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    		鎖2.Dispose();
    	}

    	public override void SetAngle0()
    	{
    		_ = 右;
    		X0Y0_Torso_Torso.SetAngleBase(20.0.GetRanAngle());
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		X0Y0_Torso_背板CP.Update();
    		X0Y0_Torso_節CP.Update();
    		X0Y0_Torso_胸板CP.Update();
    		X0Y0_Torso_TorsoCP.Update();
    		X0Y0_Torso_瘤左2CP.Update();
    		X0Y0_Torso_瘤左1CP.Update();
    		X0Y0_Torso_瘤右2CP.Update();
    		X0Y0_Torso_瘤右1CP.Update();
    		X0Y0_輪_革CP.Update();
    		X0Y0_輪_金具1CP.Update();
    		X0Y0_輪_金具2CP.Update();
    		X0Y0_輪_金具3CP.Update();
    		X0Y0_輪_金具左CP.Update();
    		X0Y0_輪_金具右CP.Update();
    		鎖1.接続PA();
    		鎖2.接続PA();
    		鎖1.色更新();
    		鎖2.色更新();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		switch (配色指定)
    		{
    		case 配色指定.N0:
    			配色N0(体配色);
    			break;
    		case 配色指定.T0:
    			配色T0(体配色);
    			break;
    		case 配色指定.T1:
    			配色T1(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		Torso_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		Torso_節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		Torso_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		Torso_TorsoCD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		Torso_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		Torso_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		Torso_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		Torso_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		Torso_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		Torso_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		Torso_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		Torso_TorsoCD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		Torso_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		Torso_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		Torso_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		Torso_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		Torso_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		Torso_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		Torso_胸板CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		Torso_TorsoCD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		Torso_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		Torso_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		Torso_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		Torso_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    	}

    	public void 輪配色(拘束具色 配色)
    	{
    		輪_革CD.色 = 配色.革部色;
    		輪_金具1CD.色 = 配色.金具色;
    		輪_金具2CD.色 = 輪_金具1CD.色;
    		輪_金具3CD.色 = 輪_金具1CD.色;
    		輪_金具左CD.色 = 輪_金具1CD.色;
    		輪_金具右CD.色 = 輪_金具1CD.色;
    	}

    	public void 鎖配色(鎖色 配色)
    	{
    		鎖1.配色鎖(配色);
    		鎖2.配色鎖(配色);
    	}
    }
}
