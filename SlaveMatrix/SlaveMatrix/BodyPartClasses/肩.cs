using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 肩 : Ele
    {
    	public Par X0Y0_脇_脇;

    	public Par X0Y0_脇_筋肉;

    	public Par X0Y0_肩_肩;

    	public Par X0Y0_肩_虫性_甲殻1;

    	public Par X0Y0_肩_虫性_甲殻2;

    	public Par X0Y0_肩_傷I1;

    	public Par X0Y0_肩_傷I2;

    	public Par X0Y0_肩_傷I3;

    	public Par X0Y0_肩_傷I4;

    	public Par X0Y0_肩_シャツ;

    	public Par X0Y0_肩_ナース;

    	public ColorD 脇_脇CD;

    	public ColorD 脇_筋肉CD;

    	public ColorD 肩_肩CD;

    	public ColorD 肩_虫性_甲殻1CD;

    	public ColorD 肩_虫性_甲殻2CD;

    	public ColorD 肩_傷I1CD;

    	public ColorD 肩_傷I2CD;

    	public ColorD 肩_傷I3CD;

    	public ColorD 肩_傷I4CD;

    	public ColorD 肩_シャツCD;

    	public ColorD 肩_ナースCD;

    	public ColorP X0Y0_脇_脇CP;

    	public ColorP X0Y0_脇_筋肉CP;

    	public ColorP X0Y0_肩_肩CP;

    	public ColorP X0Y0_肩_虫性_甲殻1CP;

    	public ColorP X0Y0_肩_虫性_甲殻2CP;

    	public ColorP X0Y0_肩_傷I1CP;

    	public ColorP X0Y0_肩_傷I2CP;

    	public ColorP X0Y0_肩_傷I3CP;

    	public ColorP X0Y0_肩_傷I4CP;

    	public ColorP X0Y0_肩_シャツCP;

    	public ColorP X0Y0_肩_ナースCP;

    	public スタンプK キスマーク;

    	public スタンプW 鞭痕;

    	public Ele[] 上腕_接続;

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
    			脇_筋肉_表示 = 筋肉_;
    			X0Y0_脇_脇.OP.ExpansionXY(X0Y0_脇_脇.OP.GetCenter(), 0.0005);
    			X0Y0_脇_脇.JP.ExpansionXY(X0Y0_脇_脇.JP.GetCenter(), 0.0005);
    			X0Y0_肩_肩.OP.ExpansionXY(X0Y0_肩_肩.OP.GetCenter(), 0.0005);
    			X0Y0_肩_肩.JP.ExpansionXY(X0Y0_肩_肩.JP.GetCenter(), 0.0005);
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

    	public bool 脇_脇_表示
    	{
    		get
    		{
    			return X0Y0_脇_脇.Dra;
    		}
    		set
    		{
    			X0Y0_脇_脇.Dra = value;
    			X0Y0_脇_脇.Hit = value;
    		}
    	}

    	public bool 脇_筋肉_表示
    	{
    		get
    		{
    			return X0Y0_脇_筋肉.Dra;
    		}
    		set
    		{
    			X0Y0_脇_筋肉.Dra = value;
    			X0Y0_脇_筋肉.Hit = value;
    		}
    	}

    	public bool 肩_表示
    	{
    		get
    		{
    			return X0Y0_肩_肩.Dra;
    		}
    		set
    		{
    			X0Y0_肩_肩.Dra = value;
    			X0Y0_肩_肩.Hit = value;
    		}
    	}

    	public bool 肩_虫性_甲殻1_表示
    	{
    		get
    		{
    			return X0Y0_肩_虫性_甲殻1.Dra;
    		}
    		set
    		{
    			X0Y0_肩_虫性_甲殻1.Dra = value;
    			X0Y0_肩_虫性_甲殻1.Hit = value;
    		}
    	}

    	public bool 肩_虫性_甲殻2_表示
    	{
    		get
    		{
    			return X0Y0_肩_虫性_甲殻2.Dra;
    		}
    		set
    		{
    			X0Y0_肩_虫性_甲殻2.Dra = value;
    			X0Y0_肩_虫性_甲殻2.Hit = value;
    		}
    	}

    	public bool 肩_傷I1_表示
    	{
    		get
    		{
    			return X0Y0_肩_傷I1.Dra;
    		}
    		set
    		{
    			X0Y0_肩_傷I1.Dra = value;
    			X0Y0_肩_傷I1.Hit = value;
    		}
    	}

    	public bool 肩_傷I2_表示
    	{
    		get
    		{
    			return X0Y0_肩_傷I2.Dra;
    		}
    		set
    		{
    			X0Y0_肩_傷I2.Dra = value;
    			X0Y0_肩_傷I2.Hit = value;
    		}
    	}

    	public bool 肩_傷I3_表示
    	{
    		get
    		{
    			return X0Y0_肩_傷I3.Dra;
    		}
    		set
    		{
    			X0Y0_肩_傷I3.Dra = value;
    			X0Y0_肩_傷I3.Hit = value;
    		}
    	}

    	public bool 肩_傷I4_表示
    	{
    		get
    		{
    			return X0Y0_肩_傷I4.Dra;
    		}
    		set
    		{
    			X0Y0_肩_傷I4.Dra = value;
    			X0Y0_肩_傷I4.Hit = value;
    		}
    	}

    	public bool 肩_シャツ_表示
    	{
    		get
    		{
    			return X0Y0_肩_シャツ.Dra;
    		}
    		set
    		{
    			X0Y0_肩_シャツ.Dra = value;
    			X0Y0_肩_シャツ.Hit = value;
    		}
    	}

    	public bool 肩_ナース_表示
    	{
    		get
    		{
    			return X0Y0_肩_ナース.Dra;
    		}
    		set
    		{
    			X0Y0_肩_ナース.Dra = value;
    			X0Y0_肩_ナース.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 脇_脇_表示;
    		}
    		set
    		{
    			脇_脇_表示 = value;
    			脇_筋肉_表示 = value;
    			肩_表示 = value;
    			肩_虫性_甲殻1_表示 = value;
    			肩_虫性_甲殻2_表示 = value;
    			肩_傷I1_表示 = value;
    			肩_傷I2_表示 = value;
    			肩_傷I3_表示 = value;
    			肩_傷I4_表示 = value;
    			肩_シャツ_表示 = value;
    			肩_ナース_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 脇_脇CD.不透明度;
    		}
    		set
    		{
    			脇_脇CD.不透明度 = value;
    			脇_筋肉CD.不透明度 = value;
    			肩_肩CD.不透明度 = value;
    			肩_虫性_甲殻1CD.不透明度 = value;
    			肩_虫性_甲殻2CD.不透明度 = value;
    			肩_傷I1CD.不透明度 = value;
    			肩_傷I2CD.不透明度 = value;
    			肩_傷I3CD.不透明度 = value;
    			肩_傷I4CD.不透明度 = value;
    			肩_シャツCD.不透明度 = value;
    			肩_ナースCD.不透明度 = value;
    		}
    	}

    	public JointS 上腕_接続点 => new JointS(本体, X0Y0_肩_肩, 1);

    	public 肩(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 肩D e)
    	{
    		肩 肩2 = this;
    		ThisType = GetType();
    		本体 = new Difs(Sta.肩左["肩"]);
    		Pars pars = 本体[0][0];
    		Pars pars2 = pars["脇"].ToPars();
    		X0Y0_脇_脇 = pars2["脇"].ToPar();
    		X0Y0_脇_筋肉 = pars2["筋肉"].ToPar();
    		pars2 = pars["肩"].ToPars();
    		X0Y0_肩_肩 = pars2["肩"].ToPar();
    		Pars pars3 = pars2["虫性"].ToPars();
    		X0Y0_肩_虫性_甲殻1 = pars3["甲殻1"].ToPar();
    		X0Y0_肩_虫性_甲殻2 = pars3["甲殻2"].ToPar();
    		X0Y0_肩_傷I1 = pars2["傷I1"].ToPar();
    		X0Y0_肩_傷I2 = pars2["傷I2"].ToPar();
    		X0Y0_肩_傷I3 = pars2["傷I3"].ToPar();
    		X0Y0_肩_傷I4 = pars2["傷I4"].ToPar();
    		X0Y0_肩_シャツ = pars2["シャツ"].ToPar();
    		X0Y0_肩_ナース = pars2["ナース"].ToPar();
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
    		脇_脇_表示 = e.脇_脇_表示;
    		脇_筋肉_表示 = e.脇_筋肉_表示;
    		肩_表示 = e.肩_表示;
    		肩_虫性_甲殻1_表示 = e.肩_虫性_甲殻1_表示;
    		肩_虫性_甲殻2_表示 = e.肩_虫性_甲殻2_表示;
    		肩_傷I1_表示 = e.肩_傷I1_表示;
    		肩_傷I2_表示 = e.肩_傷I2_表示;
    		肩_傷I3_表示 = e.肩_傷I3_表示;
    		肩_傷I4_表示 = e.肩_傷I4_表示;
    		肩_シャツ_表示 = e.肩_シャツ_表示;
    		肩_ナース_表示 = e.肩_ナース_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.上腕_接続.Count > 0)
    		{
    			Ele f;
    			上腕_接続 = e.上腕_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 肩2;
    				f.ConnectionType = ConnectionInfo.肩_上腕_接続;
    				f.接続(肩2.上腕_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_脇_脇CP = new ColorP(X0Y0_脇_脇, 脇_脇CD, DisUnit, abj: true);
    		X0Y0_脇_筋肉CP = new ColorP(X0Y0_脇_筋肉, 脇_筋肉CD, DisUnit, abj: true);
    		X0Y0_肩_肩CP = new ColorP(X0Y0_肩_肩, 肩_肩CD, DisUnit, abj: true);
    		X0Y0_肩_虫性_甲殻1CP = new ColorP(X0Y0_肩_虫性_甲殻1, 肩_虫性_甲殻1CD, DisUnit, abj: true);
    		X0Y0_肩_虫性_甲殻2CP = new ColorP(X0Y0_肩_虫性_甲殻2, 肩_虫性_甲殻2CD, DisUnit, abj: true);
    		X0Y0_肩_傷I1CP = new ColorP(X0Y0_肩_傷I1, 肩_傷I1CD, DisUnit, abj: true);
    		X0Y0_肩_傷I2CP = new ColorP(X0Y0_肩_傷I2, 肩_傷I2CD, DisUnit, abj: true);
    		X0Y0_肩_傷I3CP = new ColorP(X0Y0_肩_傷I3, 肩_傷I3CD, DisUnit, abj: true);
    		X0Y0_肩_傷I4CP = new ColorP(X0Y0_肩_傷I4, 肩_傷I4CD, DisUnit, abj: true);
    		X0Y0_肩_シャツCP = new ColorP(X0Y0_肩_シャツ, 肩_シャツCD, DisUnit, abj: true);
    		X0Y0_肩_ナースCP = new ColorP(X0Y0_肩_ナース, 肩_ナースCD, DisUnit, abj: true);
    		濃度 = e.濃度;
    		X0Y0_脇_脇.BasePointBase = X0Y0_脇_脇.BasePointBase.AddY(-0.001);
    	}

    	public void 脇描画(RenderArea Are)
    	{
    		Are.Draw(X0Y0_脇_脇);
    		Are.Draw(X0Y0_脇_筋肉);
    	}

    	public void 服描画(RenderArea Are)
    	{
    		Are.Draw(X0Y0_肩_シャツ);
    		Are.Draw(X0Y0_肩_ナース);
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_肩_肩);
    		Are.Draw(X0Y0_肩_傷I1);
    		Are.Draw(X0Y0_肩_傷I2);
    		Are.Draw(X0Y0_肩_傷I3);
    		Are.Draw(X0Y0_肩_傷I4);
    		キスマーク.Draw(Are);
    		鞭痕.Draw(Are);
    		Are.Draw(X0Y0_肩_虫性_甲殻1);
    		Are.Draw(X0Y0_肩_虫性_甲殻2);
    	}

    	public override bool Is布(Par p)
    	{
    		if (p != X0Y0_肩_シャツ)
    		{
    			return p == X0Y0_肩_ナース;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_脇_脇CP.Update();
    		X0Y0_脇_筋肉CP.Update();
    		X0Y0_肩_肩CP.Update();
    		X0Y0_肩_虫性_甲殻1CP.Update();
    		X0Y0_肩_虫性_甲殻2CP.Update();
    		X0Y0_肩_傷I1CP.Update();
    		X0Y0_肩_傷I2CP.Update();
    		X0Y0_肩_傷I3CP.Update();
    		X0Y0_肩_傷I4CP.Update();
    	}

    	public void シャツ色更新(Vector2D[] シャツ)
    	{
    		X0Y0_肩_シャツCP.Update(シャツ);
    	}

    	public void ナース色更新(Vector2D[] ナース)
    	{
    		X0Y0_肩_ナースCP.Update(ナース);
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		脇_脇CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
    		脇_筋肉CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
    		肩_肩CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		肩_虫性_甲殻1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		肩_虫性_甲殻2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		肩_傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		肩_傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		肩_傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		肩_傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		肩_シャツCD = new ColorD();
    		肩_ナースCD = new ColorD();
    	}
    }
}
