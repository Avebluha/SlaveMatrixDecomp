using _2DGAMELIB;
using System.Linq;

namespace SlaveMatrix
{
    public class 長物_蛇 : 半身
    {
    	public Par X0Y0_Torso1_Torso;

    	public Par X0Y0_Torso1_鱗2;

    	public Par X0Y0_Torso1_鱗右;

    	public Par X0Y0_Torso1_鱗左;

    	public Par X0Y0_Torso1_鱗1;

    	public Par X0Y0_Torso1_鱗左2;

    	public Par X0Y0_Torso1_鱗右2;

    	public Par X0Y0_Torso1_鱗左1;

    	public Par X0Y0_Torso1_鱗右1;

    	public ColorD Torso1_TorsoCD;

    	public ColorD Torso1_鱗2CD;

    	public ColorD Torso1_鱗右CD;

    	public ColorD Torso1_鱗左CD;

    	public ColorD Torso1_鱗1CD;

    	public ColorD Torso1_鱗左2CD;

    	public ColorD Torso1_鱗右2CD;

    	public ColorD Torso1_鱗左1CD;

    	public ColorD Torso1_鱗右1CD;

    	public ColorP X0Y0_Torso1_TorsoCP;

    	public ColorP X0Y0_Torso1_鱗2CP;

    	public ColorP X0Y0_Torso1_鱗右CP;

    	public ColorP X0Y0_Torso1_鱗左CP;

    	public ColorP X0Y0_Torso1_鱗1CP;

    	public ColorP X0Y0_Torso1_鱗左2CP;

    	public ColorP X0Y0_Torso1_鱗右2CP;

    	public ColorP X0Y0_Torso1_鱗左1CP;

    	public ColorP X0Y0_Torso1_鱗右1CP;

    	private double くぱぁ_;

    	private double sb;

    	private bool ガード_;

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
    		}
    	}

    	public bool Torso1_表示
    	{
    		get
    		{
    			return X0Y0_Torso1_Torso.Dra;
    		}
    		set
    		{
    			X0Y0_Torso1_Torso.Dra = value;
    			X0Y0_Torso1_Torso.Hit = value;
    		}
    	}

    	public bool Torso1_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_Torso1_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_Torso1_鱗2.Dra = value;
    			X0Y0_Torso1_鱗2.Hit = value;
    		}
    	}

    	public bool Torso1_鱗右_表示
    	{
    		get
    		{
    			return X0Y0_Torso1_鱗右.Dra;
    		}
    		set
    		{
    			X0Y0_Torso1_鱗右.Dra = value;
    			X0Y0_Torso1_鱗右.Hit = value;
    		}
    	}

    	public bool Torso1_鱗左_表示
    	{
    		get
    		{
    			return X0Y0_Torso1_鱗左.Dra;
    		}
    		set
    		{
    			X0Y0_Torso1_鱗左.Dra = value;
    			X0Y0_Torso1_鱗左.Hit = value;
    		}
    	}

    	public bool Torso1_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_Torso1_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_Torso1_鱗1.Dra = value;
    			X0Y0_Torso1_鱗1.Hit = value;
    		}
    	}

    	public bool Torso1_鱗左2_表示
    	{
    		get
    		{
    			return X0Y0_Torso1_鱗左2.Dra;
    		}
    		set
    		{
    			X0Y0_Torso1_鱗左2.Dra = value;
    			X0Y0_Torso1_鱗左2.Hit = value;
    		}
    	}

    	public bool Torso1_鱗右2_表示
    	{
    		get
    		{
    			return X0Y0_Torso1_鱗右2.Dra;
    		}
    		set
    		{
    			X0Y0_Torso1_鱗右2.Dra = value;
    			X0Y0_Torso1_鱗右2.Hit = value;
    		}
    	}

    	public bool Torso1_鱗左1_表示
    	{
    		get
    		{
    			return X0Y0_Torso1_鱗左1.Dra;
    		}
    		set
    		{
    			X0Y0_Torso1_鱗左1.Dra = value;
    			X0Y0_Torso1_鱗左1.Hit = value;
    		}
    	}

    	public bool Torso1_鱗右1_表示
    	{
    		get
    		{
    			return X0Y0_Torso1_鱗右1.Dra;
    		}
    		set
    		{
    			X0Y0_Torso1_鱗右1.Dra = value;
    			X0Y0_Torso1_鱗右1.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return Torso1_表示;
    		}
    		set
    		{
    			Torso1_表示 = value;
    			Torso1_鱗2_表示 = value;
    			Torso1_鱗右_表示 = value;
    			Torso1_鱗左_表示 = value;
    			Torso1_鱗1_表示 = value;
    			Torso1_鱗左2_表示 = value;
    			Torso1_鱗右2_表示 = value;
    			Torso1_鱗左1_表示 = value;
    			Torso1_鱗右1_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return Torso1_TorsoCD.不透明度;
    		}
    		set
    		{
    			Torso1_TorsoCD.不透明度 = value;
    			Torso1_鱗2CD.不透明度 = value;
    			Torso1_鱗右CD.不透明度 = value;
    			Torso1_鱗左CD.不透明度 = value;
    			Torso1_鱗1CD.不透明度 = value;
    			Torso1_鱗左2CD.不透明度 = value;
    			Torso1_鱗右2CD.不透明度 = value;
    			Torso1_鱗左1CD.不透明度 = value;
    			Torso1_鱗右1CD.不透明度 = value;
    		}
    	}

    	public double くぱぁ
    	{
    		get
    		{
    			return くぱぁ_;
    		}
    		set
    		{
    			if (sb == 0.0)
    			{
    				sb = X0Y0_Torso1_鱗左.SizeXBase;
    			}
    			くぱぁ_ = value;
    			X0Y0_Torso1_鱗左.SizeXBase = sb * (1.0 - 0.35 * くぱぁ_);
    			X0Y0_Torso1_鱗右.SizeXBase = sb * (1.0 - 0.35 * くぱぁ_);
    		}
    	}

    	public bool ガード
    	{
    		get
    		{
    			return ガード_;
    		}
    		set
    		{
    			ガード_ = value;
    			Torso1_鱗1_表示 = ガード_;
    		}
    	}

    	public JointS 左_接続点 => new JointS(本体, X0Y0_Torso1_Torso, 2);

    	public JointS 右_接続点 => new JointS(本体, X0Y0_Torso1_Torso, 3);

    	public JointS Torso_接続点 => new JointS(本体, X0Y0_Torso1_Torso, 1);

    	public 長物_蛇(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 長物_蛇D e)
    	{
    		長物_蛇 長物_蛇2 = this;
    		ThisType = GetType();
    		Pars pars = new Pars();
    		pars.Tag = "蛇";
    		pars.Add(new Pars(Sta.半身["長物"][0][2]["胴1"].ToPars()));
    		Dif dif = new Dif();
    		dif.Tag = pars.Tag;
    		dif.Add(pars);
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars2 = 本体[0][0]["胴1"].ToPars();
    		X0Y0_Torso1_Torso = pars2["胴"].ToPar();
    		X0Y0_Torso1_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_Torso1_鱗右 = pars2["鱗右"].ToPar();
    		X0Y0_Torso1_鱗左 = pars2["鱗左"].ToPar();
    		X0Y0_Torso1_鱗1 = pars2["鱗1"].ToPar();
    		X0Y0_Torso1_鱗左2 = pars2["鱗左2"].ToPar();
    		X0Y0_Torso1_鱗右2 = pars2["鱗右2"].ToPar();
    		X0Y0_Torso1_鱗左1 = pars2["鱗左1"].ToPar();
    		X0Y0_Torso1_鱗右1 = pars2["鱗右1"].ToPar();
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
    		Torso1_表示 = e.Torso1_表示;
    		Torso1_鱗2_表示 = e.Torso1_鱗2_表示;
    		Torso1_鱗右_表示 = e.Torso1_鱗右_表示;
    		Torso1_鱗左_表示 = e.Torso1_鱗左_表示;
    		Torso1_鱗1_表示 = e.Torso1_鱗1_表示;
    		Torso1_鱗左2_表示 = e.Torso1_鱗左2_表示;
    		Torso1_鱗右2_表示 = e.Torso1_鱗右2_表示;
    		Torso1_鱗左1_表示 = e.Torso1_鱗左1_表示;
    		Torso1_鱗右1_表示 = e.Torso1_鱗右1_表示;
    		くぱぁ = e.くぱぁ;
    		ガード = e.ガード;
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
    				f.Par = 長物_蛇2;
    				f.ConnectionType = ConnectionInfo.長物_蛇_左_接続;
    				f.接続(長物_蛇2.左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右_接続.Count > 0)
    		{
    			右_接続 = e.右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_蛇2;
    				f.ConnectionType = ConnectionInfo.長物_蛇_右_接続;
    				f.接続(長物_蛇2.右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.Torso_接続.Count > 0)
    		{
    			Torso_接続 = e.Torso_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_蛇2;
    				f.ConnectionType = ConnectionInfo.長物_蛇_Torso_接続;
    				f.接続(長物_蛇2.Torso_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_Torso1_TorsoCP = new ColorP(X0Y0_Torso1_Torso, Torso1_TorsoCD, DisUnit, abj: true);
    		X0Y0_Torso1_鱗2CP = new ColorP(X0Y0_Torso1_鱗2, Torso1_鱗2CD, DisUnit, abj: true);
    		X0Y0_Torso1_鱗右CP = new ColorP(X0Y0_Torso1_鱗右, Torso1_鱗右CD, DisUnit, abj: true);
    		X0Y0_Torso1_鱗左CP = new ColorP(X0Y0_Torso1_鱗左, Torso1_鱗左CD, DisUnit, abj: true);
    		X0Y0_Torso1_鱗1CP = new ColorP(X0Y0_Torso1_鱗1, Torso1_鱗1CD, DisUnit, abj: true);
    		X0Y0_Torso1_鱗左2CP = new ColorP(X0Y0_Torso1_鱗左2, Torso1_鱗左2CD, DisUnit, abj: true);
    		X0Y0_Torso1_鱗右2CP = new ColorP(X0Y0_Torso1_鱗右2, Torso1_鱗右2CD, DisUnit, abj: true);
    		X0Y0_Torso1_鱗左1CP = new ColorP(X0Y0_Torso1_鱗左1, Torso1_鱗左1CD, DisUnit, abj: true);
    		X0Y0_Torso1_鱗右1CP = new ColorP(X0Y0_Torso1_鱗右1, Torso1_鱗右1CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_Torso1_鱗2);
    		Are.Draw(X0Y0_Torso1_鱗左2);
    		Are.Draw(X0Y0_Torso1_鱗右2);
    		if (Torso_接続 != null && Torso_接続[0].拘束 && Torso_接続[0] is Torso_蛇)
    		{
    			((Torso_蛇)Torso_接続[0]).拘束具描画(Are);
    		}
    		if (くぱぁ_ == 1.0)
    		{
    			Are.Draw(X0Y0_Torso1_鱗右);
    			Are.Draw(X0Y0_Torso1_鱗左);
    		}
    	}

    	public void 前描画(RenderArea Are)
    	{
    		if (くぱぁ_ != 1.0)
    		{
    			Are.Draw(X0Y0_Torso1_鱗右);
    			Are.Draw(X0Y0_Torso1_鱗左);
    		}
    		Are.Draw(X0Y0_Torso1_鱗1);
    		Are.Draw(X0Y0_Torso1_鱗左1);
    		Are.Draw(X0Y0_Torso1_鱗右1);
    	}

    	public override void 色更新()
    	{
    		X0Y0_Torso1_TorsoCP.Update();
    		X0Y0_Torso1_鱗2CP.Update();
    		X0Y0_Torso1_鱗右CP.Update();
    		X0Y0_Torso1_鱗左CP.Update();
    		X0Y0_Torso1_鱗1CP.Update();
    		X0Y0_Torso1_鱗左2CP.Update();
    		X0Y0_Torso1_鱗右2CP.Update();
    		X0Y0_Torso1_鱗左1CP.Update();
    		X0Y0_Torso1_鱗右1CP.Update();
    	}

    	private void 配色(体配色 体配色)
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
    		Torso1_TorsoCD = new ColorD(ref Col.Empty, ref Color2.Empty);
    		Torso1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		Torso1_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		Torso1_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		Torso1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		Torso1_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		Torso1_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		Torso1_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		Torso1_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		Torso1_TorsoCD = new ColorD(ref Col.Empty, ref Color2.Empty);
    		Torso1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		Torso1_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		Torso1_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		Torso1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		Torso1_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		Torso1_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		Torso1_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		Torso1_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		Torso1_TorsoCD = new ColorD(ref Col.Empty, ref Color2.Empty);
    		Torso1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		Torso1_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		Torso1_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		Torso1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		Torso1_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		Torso1_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		Torso1_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		Torso1_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}
    }
}
