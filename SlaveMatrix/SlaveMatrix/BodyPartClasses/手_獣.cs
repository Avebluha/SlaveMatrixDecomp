using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 手_獣 : 獣手
    {
    	public ShapePart X0Y0_手;

    	public ShapePart X0Y0_親指_指;

    	public ShapePart X0Y0_親指_爪;

    	public ShapePart X0Y0_小指_指;

    	public ShapePart X0Y0_小指_爪;

    	public ShapePart X0Y0_薬指_指;

    	public ShapePart X0Y0_薬指_爪;

    	public ShapePart X0Y0_中指_指;

    	public ShapePart X0Y0_中指_爪;

    	public ShapePart X0Y0_人指_指;

    	public ShapePart X0Y0_人指_爪;

    	public ShapePart X0Y0_竜性_鱗3;

    	public ShapePart X0Y0_竜性_鱗2;

    	public ShapePart X0Y0_竜性_鱗1;

    	public ColorD 手CD;

    	public ColorD 親指_指CD;

    	public ColorD 親指_爪CD;

    	public ColorD 小指_指CD;

    	public ColorD 小指_爪CD;

    	public ColorD 薬指_指CD;

    	public ColorD 薬指_爪CD;

    	public ColorD 中指_指CD;

    	public ColorD 中指_爪CD;

    	public ColorD 人指_指CD;

    	public ColorD 人指_爪CD;

    	public ColorD 竜性_鱗3CD;

    	public ColorD 竜性_鱗2CD;

    	public ColorD 竜性_鱗1CD;

    	public ColorP X0Y0_手CP;

    	public ColorP X0Y0_親指_指CP;

    	public ColorP X0Y0_親指_爪CP;

    	public ColorP X0Y0_小指_指CP;

    	public ColorP X0Y0_小指_爪CP;

    	public ColorP X0Y0_薬指_指CP;

    	public ColorP X0Y0_薬指_爪CP;

    	public ColorP X0Y0_中指_指CP;

    	public ColorP X0Y0_中指_爪CP;

    	public ColorP X0Y0_人指_指CP;

    	public ColorP X0Y0_人指_爪CP;

    	public ColorP X0Y0_竜性_鱗3CP;

    	public ColorP X0Y0_竜性_鱗2CP;

    	public ColorP X0Y0_竜性_鱗1CP;

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

    	public bool 手_表示
    	{
    		get
    		{
    			return X0Y0_手.Dra;
    		}
    		set
    		{
    			X0Y0_手.Dra = value;
    			X0Y0_手.Hit = value;
    		}
    	}

    	public bool 親指_指_表示
    	{
    		get
    		{
    			return X0Y0_親指_指.Dra;
    		}
    		set
    		{
    			X0Y0_親指_指.Dra = value;
    			X0Y0_親指_指.Hit = value;
    		}
    	}

    	public bool 親指_爪_表示
    	{
    		get
    		{
    			return X0Y0_親指_爪.Dra;
    		}
    		set
    		{
    			X0Y0_親指_爪.Dra = value;
    			X0Y0_親指_爪.Hit = value;
    		}
    	}

    	public bool 小指_指_表示
    	{
    		get
    		{
    			return X0Y0_小指_指.Dra;
    		}
    		set
    		{
    			X0Y0_小指_指.Dra = value;
    			X0Y0_小指_指.Hit = value;
    		}
    	}

    	public bool 小指_爪_表示
    	{
    		get
    		{
    			return X0Y0_小指_爪.Dra;
    		}
    		set
    		{
    			X0Y0_小指_爪.Dra = value;
    			X0Y0_小指_爪.Hit = value;
    		}
    	}

    	public bool 薬指_指_表示
    	{
    		get
    		{
    			return X0Y0_薬指_指.Dra;
    		}
    		set
    		{
    			X0Y0_薬指_指.Dra = value;
    			X0Y0_薬指_指.Hit = value;
    		}
    	}

    	public bool 薬指_爪_表示
    	{
    		get
    		{
    			return X0Y0_薬指_爪.Dra;
    		}
    		set
    		{
    			X0Y0_薬指_爪.Dra = value;
    			X0Y0_薬指_爪.Hit = value;
    		}
    	}

    	public bool 中指_指_表示
    	{
    		get
    		{
    			return X0Y0_中指_指.Dra;
    		}
    		set
    		{
    			X0Y0_中指_指.Dra = value;
    			X0Y0_中指_指.Hit = value;
    		}
    	}

    	public bool 中指_爪_表示
    	{
    		get
    		{
    			return X0Y0_中指_爪.Dra;
    		}
    		set
    		{
    			X0Y0_中指_爪.Dra = value;
    			X0Y0_中指_爪.Hit = value;
    		}
    	}

    	public bool 人指_指_表示
    	{
    		get
    		{
    			return X0Y0_人指_指.Dra;
    		}
    		set
    		{
    			X0Y0_人指_指.Dra = value;
    			X0Y0_人指_指.Hit = value;
    		}
    	}

    	public bool 人指_爪_表示
    	{
    		get
    		{
    			return X0Y0_人指_爪.Dra;
    		}
    		set
    		{
    			X0Y0_人指_爪.Dra = value;
    			X0Y0_人指_爪.Hit = value;
    		}
    	}

    	public bool 竜性_鱗3_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗3.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗3.Dra = value;
    			X0Y0_竜性_鱗3.Hit = value;
    		}
    	}

    	public bool 竜性_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗2.Dra = value;
    			X0Y0_竜性_鱗2.Hit = value;
    		}
    	}

    	public bool 竜性_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗1.Dra = value;
    			X0Y0_竜性_鱗1.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 手_表示;
    		}
    		set
    		{
    			手_表示 = value;
    			親指_指_表示 = value;
    			親指_爪_表示 = value;
    			小指_指_表示 = value;
    			小指_爪_表示 = value;
    			薬指_指_表示 = value;
    			薬指_爪_表示 = value;
    			中指_指_表示 = value;
    			中指_爪_表示 = value;
    			人指_指_表示 = value;
    			人指_爪_表示 = value;
    			竜性_鱗3_表示 = value;
    			竜性_鱗2_表示 = value;
    			竜性_鱗1_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 手CD.不透明度;
    		}
    		set
    		{
    			手CD.不透明度 = value;
    			親指_指CD.不透明度 = value;
    			親指_爪CD.不透明度 = value;
    			小指_指CD.不透明度 = value;
    			小指_爪CD.不透明度 = value;
    			薬指_指CD.不透明度 = value;
    			薬指_爪CD.不透明度 = value;
    			中指_指CD.不透明度 = value;
    			中指_爪CD.不透明度 = value;
    			人指_指CD.不透明度 = value;
    			人指_爪CD.不透明度 = value;
    			竜性_鱗3CD.不透明度 = value;
    			竜性_鱗2CD.不透明度 = value;
    			竜性_鱗1CD.不透明度 = value;
    		}
    	}

    	public 手_獣(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 手_獣D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "獣";
    		dif.Add(new PartGroup(Sta.腕左["四足手"][0][0]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_手 = partGroup["手"].ToPar();
    		PartGroup pars2 = partGroup["親指"].ToPars();
    		X0Y0_親指_指 = pars2["指"].ToPar();
    		X0Y0_親指_爪 = pars2["爪"].ToPar();
    		pars2 = partGroup["小指"].ToPars();
    		X0Y0_小指_指 = pars2["指"].ToPar();
    		X0Y0_小指_爪 = pars2["爪"].ToPar();
    		pars2 = partGroup["薬指"].ToPars();
    		X0Y0_薬指_指 = pars2["指"].ToPar();
    		X0Y0_薬指_爪 = pars2["爪"].ToPar();
    		pars2 = partGroup["中指"].ToPars();
    		X0Y0_中指_指 = pars2["指"].ToPar();
    		X0Y0_中指_爪 = pars2["爪"].ToPar();
    		pars2 = partGroup["人指"].ToPars();
    		X0Y0_人指_指 = pars2["指"].ToPar();
    		X0Y0_人指_爪 = pars2["爪"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
    		X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
    		Xasix = false;
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
    		手_表示 = e.手_表示;
    		親指_指_表示 = e.親指_指_表示;
    		親指_爪_表示 = e.親指_爪_表示;
    		小指_指_表示 = e.小指_指_表示;
    		小指_爪_表示 = e.小指_爪_表示;
    		薬指_指_表示 = e.薬指_指_表示;
    		薬指_爪_表示 = e.薬指_爪_表示;
    		中指_指_表示 = e.中指_指_表示;
    		中指_爪_表示 = e.中指_爪_表示;
    		人指_指_表示 = e.人指_指_表示;
    		人指_爪_表示 = e.人指_爪_表示;
    		竜性_鱗3_表示 = e.竜性_鱗3_表示;
    		竜性_鱗2_表示 = e.竜性_鱗2_表示;
    		竜性_鱗1_表示 = e.竜性_鱗1_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_手CP = new ColorP(X0Y0_手, 手CD, DisUnit, abj: true);
    		X0Y0_親指_指CP = new ColorP(X0Y0_親指_指, 親指_指CD, DisUnit, abj: true);
    		X0Y0_親指_爪CP = new ColorP(X0Y0_親指_爪, 親指_爪CD, DisUnit, abj: true);
    		X0Y0_小指_指CP = new ColorP(X0Y0_小指_指, 小指_指CD, DisUnit, abj: true);
    		X0Y0_小指_爪CP = new ColorP(X0Y0_小指_爪, 小指_爪CD, DisUnit, abj: true);
    		X0Y0_薬指_指CP = new ColorP(X0Y0_薬指_指, 薬指_指CD, DisUnit, abj: true);
    		X0Y0_薬指_爪CP = new ColorP(X0Y0_薬指_爪, 薬指_爪CD, DisUnit, abj: true);
    		X0Y0_中指_指CP = new ColorP(X0Y0_中指_指, 中指_指CD, DisUnit, abj: true);
    		X0Y0_中指_爪CP = new ColorP(X0Y0_中指_爪, 中指_爪CD, DisUnit, abj: true);
    		X0Y0_人指_指CP = new ColorP(X0Y0_人指_指, 人指_指CD, DisUnit, abj: true);
    		X0Y0_人指_爪CP = new ColorP(X0Y0_人指_爪, 人指_爪CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗3CP = new ColorP(X0Y0_竜性_鱗3, 竜性_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗2CP = new ColorP(X0Y0_竜性_鱗2, 竜性_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗1CP = new ColorP(X0Y0_竜性_鱗1, 竜性_鱗1CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_手.AngleBase = num * 202.0;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		X0Y0_手CP.Update();
    		X0Y0_親指_指CP.Update();
    		X0Y0_親指_爪CP.Update();
    		X0Y0_小指_指CP.Update();
    		X0Y0_小指_爪CP.Update();
    		X0Y0_薬指_指CP.Update();
    		X0Y0_薬指_爪CP.Update();
    		X0Y0_中指_指CP.Update();
    		X0Y0_中指_爪CP.Update();
    		X0Y0_人指_指CP.Update();
    		X0Y0_人指_爪CP.Update();
    		X0Y0_竜性_鱗3CP.Update();
    		X0Y0_竜性_鱗2CP.Update();
    		X0Y0_竜性_鱗1CP.Update();
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
    		手CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		親指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		小指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		薬指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		中指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		人指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		手CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		親指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		小指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		薬指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		中指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		人指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		手CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		親指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		小指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		薬指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		中指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		人指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}
    }
}
