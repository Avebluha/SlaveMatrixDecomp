using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class Torso_蛇 : 長胴
    {
    	public Par X0Y0_胴_鱗;

    	public Par X0Y0_胴_鱗左;

    	public Par X0Y0_胴_鱗右;

    	public Par X0Y0_胴_胴;

    	public Par X0Y0_輪_革;

    	public Par X0Y0_輪_金具1;

    	public Par X0Y0_輪_金具2;

    	public Par X0Y0_輪_金具3;

    	public Par X0Y0_輪_金具左;

    	public Par X0Y0_輪_金具右;

    	public ColorD 胴_鱗CD;

    	public ColorD 胴_鱗左CD;

    	public ColorD 胴_鱗右CD;

    	public ColorD 胴_胴CD;

    	public ColorD 輪_革CD;

    	public ColorD 輪_金具1CD;

    	public ColorD 輪_金具2CD;

    	public ColorD 輪_金具3CD;

    	public ColorD 輪_金具左CD;

    	public ColorD 輪_金具右CD;

    	public ColorP X0Y0_胴_鱗CP;

    	public ColorP X0Y0_胴_鱗左CP;

    	public ColorP X0Y0_胴_鱗右CP;

    	public ColorP X0Y0_胴_胴CP;

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

    	public bool 胴_鱗_表示
    	{
    		get
    		{
    			return X0Y0_胴_鱗.Dra;
    		}
    		set
    		{
    			X0Y0_胴_鱗.Dra = value;
    			X0Y0_胴_鱗.Hit = value;
    		}
    	}

    	public bool 胴_鱗左_表示
    	{
    		get
    		{
    			return X0Y0_胴_鱗左.Dra;
    		}
    		set
    		{
    			X0Y0_胴_鱗左.Dra = value;
    			X0Y0_胴_鱗左.Hit = value;
    		}
    	}

    	public bool 胴_鱗右_表示
    	{
    		get
    		{
    			return X0Y0_胴_鱗右.Dra;
    		}
    		set
    		{
    			X0Y0_胴_鱗右.Dra = value;
    			X0Y0_胴_鱗右.Hit = value;
    		}
    	}

    	public bool 胴_表示
    	{
    		get
    		{
    			return X0Y0_胴_胴.Dra;
    		}
    		set
    		{
    			X0Y0_胴_胴.Dra = value;
    			X0Y0_胴_胴.Hit = value;
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
    			return 胴_鱗_表示;
    		}
    		set
    		{
    			胴_鱗_表示 = value;
    			胴_鱗左_表示 = value;
    			胴_鱗右_表示 = value;
    			胴_表示 = value;
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

    	public override double 濃度
    	{
    		get
    		{
    			return 胴_鱗CD.不透明度;
    		}
    		set
    		{
    			胴_鱗CD.不透明度 = value;
    			胴_鱗左CD.不透明度 = value;
    			胴_鱗右CD.不透明度 = value;
    			胴_胴CD.不透明度 = value;
    			輪_革CD.不透明度 = value;
    			輪_金具1CD.不透明度 = value;
    			輪_金具2CD.不透明度 = value;
    			輪_金具3CD.不透明度 = value;
    			輪_金具左CD.不透明度 = value;
    			輪_金具右CD.不透明度 = value;
    		}
    	}

    	public JointS 左_接続点 => new JointS(本体, X0Y0_胴_胴, 2);

    	public JointS 右_接続点 => new JointS(本体, X0Y0_胴_胴, 3);

    	public JointS 胴_接続点 => new JointS(本体, X0Y0_胴_胴, 1);

    	public JointS 鎖1_接続点 => new JointS(本体, X0Y0_輪_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(本体, X0Y0_輪_金具右, 0);

    	public Torso_蛇(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, Torso_蛇D e)
    	{
    		Torso_蛇 胴_蛇2 = this;
    		ThisType = GetType();
    		Pars pars = new Pars();
    		pars.Tag = "蛇";
    		pars.Add(new Pars(Sta.半身["長物"][0][2]["胴2"].ToPars()));
    		pars.Add(new Pars(Sta.半身["長物"][0][2]["輪1"].ToPars()));
    		Dif dif = new Dif();
    		dif.Tag = pars.Tag;
    		dif.Add(pars);
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars2 = 本体[0][0];
    		Pars pars3 = pars2["胴2"].ToPars();
    		X0Y0_胴_鱗 = pars3["鱗"].ToPar();
    		X0Y0_胴_鱗左 = pars3["鱗左"].ToPar();
    		X0Y0_胴_鱗右 = pars3["鱗右"].ToPar();
    		X0Y0_胴_胴 = pars3["Torso"].ToPar();
    		pars3 = pars2["輪1"].ToPars();
    		X0Y0_輪_革 = pars3["革"].ToPar();
    		X0Y0_輪_金具1 = pars3["金具1"].ToPar();
    		X0Y0_輪_金具2 = pars3["金具2"].ToPar();
    		X0Y0_輪_金具3 = pars3["金具3"].ToPar();
    		X0Y0_輪_金具左 = pars3["金具左"].ToPar();
    		X0Y0_輪_金具右 = pars3["金具右"].ToPar();
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
    		胴_鱗_表示 = e.胴_鱗_表示;
    		胴_鱗左_表示 = e.胴_鱗左_表示;
    		胴_鱗右_表示 = e.胴_鱗右_表示;
    		胴_表示 = e.胴_表示;
    		輪_革_表示 = e.輪_革_表示;
    		輪_金具1_表示 = e.輪_金具1_表示;
    		輪_金具2_表示 = e.輪_金具2_表示;
    		輪_金具3_表示 = e.輪_金具3_表示;
    		輪_金具左_表示 = e.輪_金具左_表示;
    		輪_金具右_表示 = e.輪_金具右_表示;
    		輪表示 = e.輪表示;
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
    				f.Par = 胴_蛇2;
    				f.ConnectionType = ConnectionInfo.Torso_蛇_左_接続;
    				f.接続(胴_蛇2.左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右_接続.Count > 0)
    		{
    			右_接続 = e.右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 胴_蛇2;
    				f.ConnectionType = ConnectionInfo.Torso_蛇_右_接続;
    				f.接続(胴_蛇2.右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.Torso_接続.Count > 0)
    		{
    			Torso_接続 = e.Torso_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 胴_蛇2;
    				f.ConnectionType = ConnectionInfo.Torso_蛇_Torso_接続;
    				f.接続(胴_蛇2.胴_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_胴_鱗CP = new ColorP(X0Y0_胴_鱗, 胴_鱗CD, DisUnit, abj: true);
    		X0Y0_胴_鱗左CP = new ColorP(X0Y0_胴_鱗左, 胴_鱗左CD, DisUnit, abj: true);
    		X0Y0_胴_鱗右CP = new ColorP(X0Y0_胴_鱗右, 胴_鱗右CD, DisUnit, abj: true);
    		X0Y0_胴_胴CP = new ColorP(X0Y0_胴_胴, 胴_胴CD, DisUnit, abj: true);
    		X0Y0_輪_革CP = new ColorP(X0Y0_輪_革, 輪_革CD, DisUnit, abj: true);
    		X0Y0_輪_金具1CP = new ColorP(X0Y0_輪_金具1, 輪_金具1CD, DisUnit, abj: true);
    		X0Y0_輪_金具2CP = new ColorP(X0Y0_輪_金具2, 輪_金具2CD, DisUnit, abj: true);
    		X0Y0_輪_金具3CP = new ColorP(X0Y0_輪_金具3, 輪_金具3CD, DisUnit, abj: true);
    		X0Y0_輪_金具左CP = new ColorP(X0Y0_輪_金具左, 輪_金具左CD, DisUnit, abj: true);
    		X0Y0_輪_金具右CP = new ColorP(X0Y0_輪_金具右, 輪_金具右CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    		鎖1 = new 拘束鎖(DisUnit, 右, 配色指定, 体配色, Xasix);
    		鎖2 = new 拘束鎖(DisUnit, !右, 配色指定, 体配色, Xasix);
    		鎖1.接続(鎖1_接続点);
    		鎖2.接続(鎖2_接続点);
    		int num = (右 ? (-10) : 10);
    		鎖1.角度B += num;
    		鎖2.角度B -= num;
    		鎖表示 = e.鎖表示;
    	}

    	public override void 描画0(Are Are)
    	{
    		Are.Draw(X0Y0_胴_鱗);
    		Are.Draw(X0Y0_胴_鱗左);
    		Are.Draw(X0Y0_胴_鱗右);
    		Are.Draw(X0Y0_胴_胴);
    		if (Torso_接続 != null && Torso_接続[0].拘束 && Torso_接続[0] is Torso_蛇)
    		{
    			((Torso_蛇)Torso_接続[0]).拘束具描画(Are);
    		}
    	}

    	public void 拘束具描画(Are Are)
    	{
    		Are.Draw(X0Y0_輪_革);
    		Are.Draw(X0Y0_輪_金具1);
    		Are.Draw(X0Y0_輪_金具2);
    		Are.Draw(X0Y0_輪_金具3);
    		Are.Draw(X0Y0_輪_金具左);
    		Are.Draw(X0Y0_輪_金具右);
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
    		if (Par != null && !(Par is 長物_蛇) && Par.Par != null && !(Par.Par is 長物_蛇))
    		{
    			_ = 右;
    			X0Y0_胴_胴.AngleBase = 20.0.GetRanAngle();
    			本体.JoinPAall();
    		}
    	}

    	public override bool Is革(Par p)
    	{
    		if (p != X0Y0_輪_革 && p != X0Y0_輪_金具1 && p != X0Y0_輪_金具2 && p != X0Y0_輪_金具3 && p != X0Y0_輪_金具左)
    		{
    			return p == X0Y0_輪_金具右;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_胴_鱗CP.Update();
    		X0Y0_胴_鱗左CP.Update();
    		X0Y0_胴_鱗右CP.Update();
    		X0Y0_胴_胴CP.Update();
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

    	public void 配色(体配色 体配色)
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

    	private void 配色N0(体配色 体配色)
    	{
    		胴_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		胴_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		胴_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		胴_胴CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		胴_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		胴_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		胴_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		胴_胴CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		胴_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		胴_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		胴_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		胴_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
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
