using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 獣耳 : Ele
    {
    	public ShapePart X0Y0_獣耳外;

    	public ShapePart X0Y0_獣耳内;

    	public ShapePart X0Y0_耳毛;

    	public ShapePart X0Y1_獣耳外;

    	public ShapePart X0Y1_獣耳内;

    	public ShapePart X0Y1_耳毛;

    	public ShapePart X0Y2_獣耳外;

    	public ShapePart X0Y2_獣耳内;

    	public ShapePart X0Y2_耳毛;

    	public ShapePart X1Y0_獣耳外;

    	public ShapePart X1Y0_獣耳内;

    	public ShapePart X1Y0_耳毛;

    	public ShapePart X1Y1_獣耳外;

    	public ShapePart X1Y1_獣耳内;

    	public ShapePart X1Y1_耳毛;

    	public ShapePart X1Y2_獣耳外;

    	public ShapePart X1Y2_獣耳内;

    	public ShapePart X1Y2_耳毛;

    	public ColorD 獣耳外CD;

    	public ColorD 獣耳内CD;

    	public ColorD 耳毛CD;

    	public ColorP X0Y0_獣耳外CP;

    	public ColorP X0Y0_獣耳内CP;

    	public ColorP X0Y0_耳毛CP;

    	public ColorP X0Y1_獣耳外CP;

    	public ColorP X0Y1_獣耳内CP;

    	public ColorP X0Y1_耳毛CP;

    	public ColorP X0Y2_獣耳外CP;

    	public ColorP X0Y2_獣耳内CP;

    	public ColorP X0Y2_耳毛CP;

    	public ColorP X1Y0_獣耳外CP;

    	public ColorP X1Y0_獣耳内CP;

    	public ColorP X1Y0_耳毛CP;

    	public ColorP X1Y1_獣耳外CP;

    	public ColorP X1Y1_獣耳内CP;

    	public ColorP X1Y1_耳毛CP;

    	public ColorP X1Y2_獣耳外CP;

    	public ColorP X1Y2_獣耳内CP;

    	public ColorP X1Y2_耳毛CP;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    			Body.IndexX = (欠損_ ? 1 : 0);
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

    	public bool 獣耳外_表示
    	{
    		get
    		{
    			return X0Y0_獣耳外.Dra;
    		}
    		set
    		{
    			X0Y0_獣耳外.Dra = value;
    			X0Y1_獣耳外.Dra = value;
    			X0Y2_獣耳外.Dra = value;
    			X1Y0_獣耳外.Dra = value;
    			X1Y1_獣耳外.Dra = value;
    			X1Y2_獣耳外.Dra = value;
    			X0Y0_獣耳外.Hit = value;
    			X0Y1_獣耳外.Hit = value;
    			X0Y2_獣耳外.Hit = value;
    			X1Y0_獣耳外.Hit = value;
    			X1Y1_獣耳外.Hit = value;
    			X1Y2_獣耳外.Hit = value;
    		}
    	}

    	public bool 獣耳内_表示
    	{
    		get
    		{
    			return X0Y0_獣耳内.Dra;
    		}
    		set
    		{
    			X0Y0_獣耳内.Dra = value;
    			X0Y1_獣耳内.Dra = value;
    			X0Y2_獣耳内.Dra = value;
    			X1Y0_獣耳内.Dra = value;
    			X1Y1_獣耳内.Dra = value;
    			X1Y2_獣耳内.Dra = value;
    			X0Y0_獣耳内.Hit = value;
    			X0Y1_獣耳内.Hit = value;
    			X0Y2_獣耳内.Hit = value;
    			X1Y0_獣耳内.Hit = value;
    			X1Y1_獣耳内.Hit = value;
    			X1Y2_獣耳内.Hit = value;
    		}
    	}

    	public bool 耳毛_表示
    	{
    		get
    		{
    			return X0Y0_耳毛.Dra;
    		}
    		set
    		{
    			X0Y0_耳毛.Dra = value;
    			X0Y1_耳毛.Dra = value;
    			X0Y2_耳毛.Dra = value;
    			X1Y0_耳毛.Dra = value;
    			X1Y1_耳毛.Dra = value;
    			X1Y2_耳毛.Dra = value;
    			X0Y0_耳毛.Hit = value;
    			X0Y1_耳毛.Hit = value;
    			X0Y2_耳毛.Hit = value;
    			X1Y0_耳毛.Hit = value;
    			X1Y1_耳毛.Hit = value;
    			X1Y2_耳毛.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 獣耳外_表示;
    		}
    		set
    		{
    			獣耳外_表示 = value;
    			獣耳内_表示 = value;
    			耳毛_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 獣耳外CD.不透明度;
    		}
    		set
    		{
    			獣耳外CD.不透明度 = value;
    			獣耳内CD.不透明度 = value;
    			耳毛CD.不透明度 = value;
    		}
    	}

    	public 獣耳(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 獣耳D e)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.肢左["獣耳"]);
    		Pars pars = Body[0][0];
    		X0Y0_獣耳外 = pars["獣耳外"].ToPar();
    		X0Y0_獣耳内 = pars["獣耳内"].ToPar();
    		X0Y0_耳毛 = pars["耳毛"].ToPar();
    		pars = Body[0][1];
    		X0Y1_獣耳外 = pars["獣耳外"].ToPar();
    		X0Y1_獣耳内 = pars["獣耳内"].ToPar();
    		X0Y1_耳毛 = pars["耳毛"].ToPar();
    		pars = Body[0][2];
    		X0Y2_獣耳外 = pars["獣耳外"].ToPar();
    		X0Y2_獣耳内 = pars["獣耳内"].ToPar();
    		X0Y2_耳毛 = pars["耳毛"].ToPar();
    		pars = Body[1][0];
    		X1Y0_獣耳外 = pars["獣耳外"].ToPar();
    		X1Y0_獣耳内 = pars["獣耳内"].ToPar();
    		X1Y0_耳毛 = pars["耳毛"].ToPar();
    		pars = Body[1][1];
    		X1Y1_獣耳外 = pars["獣耳外"].ToPar();
    		X1Y1_獣耳内 = pars["獣耳内"].ToPar();
    		X1Y1_耳毛 = pars["耳毛"].ToPar();
    		pars = Body[1][2];
    		X1Y2_獣耳外 = pars["獣耳外"].ToPar();
    		X1Y2_獣耳内 = pars["獣耳内"].ToPar();
    		X1Y2_耳毛 = pars["耳毛"].ToPar();
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
    		獣耳外_表示 = e.獣耳外_表示;
    		獣耳内_表示 = e.獣耳内_表示;
    		耳毛_表示 = e.耳毛_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_獣耳外CP = new ColorP(X0Y0_獣耳外, 獣耳外CD, DisUnit, abj: true);
    		X0Y0_獣耳内CP = new ColorP(X0Y0_獣耳内, 獣耳内CD, DisUnit, abj: true);
    		X0Y0_耳毛CP = new ColorP(X0Y0_耳毛, 耳毛CD, DisUnit, abj: true);
    		X0Y1_獣耳外CP = new ColorP(X0Y1_獣耳外, 獣耳外CD, DisUnit, abj: true);
    		X0Y1_獣耳内CP = new ColorP(X0Y1_獣耳内, 獣耳内CD, DisUnit, abj: true);
    		X0Y1_耳毛CP = new ColorP(X0Y1_耳毛, 耳毛CD, DisUnit, abj: true);
    		X0Y2_獣耳外CP = new ColorP(X0Y2_獣耳外, 獣耳外CD, DisUnit, abj: true);
    		X0Y2_獣耳内CP = new ColorP(X0Y2_獣耳内, 獣耳内CD, DisUnit, abj: true);
    		X0Y2_耳毛CP = new ColorP(X0Y2_耳毛, 耳毛CD, DisUnit, abj: true);
    		X1Y0_獣耳外CP = new ColorP(X1Y0_獣耳外, 獣耳外CD, DisUnit, abj: true);
    		X1Y0_獣耳内CP = new ColorP(X1Y0_獣耳内, 獣耳内CD, DisUnit, abj: true);
    		X1Y0_耳毛CP = new ColorP(X1Y0_耳毛, 耳毛CD, DisUnit, abj: true);
    		X1Y1_獣耳外CP = new ColorP(X1Y1_獣耳外, 獣耳外CD, DisUnit, abj: true);
    		X1Y1_獣耳内CP = new ColorP(X1Y1_獣耳内, 獣耳内CD, DisUnit, abj: true);
    		X1Y1_耳毛CP = new ColorP(X1Y1_耳毛, 耳毛CD, DisUnit, abj: true);
    		X1Y2_獣耳外CP = new ColorP(X1Y2_獣耳外, 獣耳外CD, DisUnit, abj: true);
    		X1Y2_獣耳内CP = new ColorP(X1Y2_獣耳内, 獣耳内CD, DisUnit, abj: true);
    		X1Y2_耳毛CP = new ColorP(X1Y2_耳毛, 耳毛CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_獣耳外.AngleBase = num * -46.0;
    		X0Y1_獣耳外.AngleBase = num * -64.0;
    		X0Y2_獣耳外.AngleBase = num * -78.0;
    		X1Y0_獣耳外.AngleBase = num * -46.0;
    		X1Y1_獣耳外.AngleBase = num * -64.0;
    		X1Y2_獣耳外.AngleBase = num * -78.0;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexX == 0)
    		{
    			switch (Body.IndexY)
    			{
    			case 0:
    				X0Y0_獣耳外CP.Update();
    				X0Y0_獣耳内CP.Update();
    				X0Y0_耳毛CP.Update();
    				break;
    			case 1:
    				X0Y1_獣耳外CP.Update();
    				X0Y1_獣耳内CP.Update();
    				X0Y1_耳毛CP.Update();
    				break;
    			default:
    				X0Y2_獣耳外CP.Update();
    				X0Y2_獣耳内CP.Update();
    				X0Y2_耳毛CP.Update();
    				break;
    			}
    		}
    		else
    		{
    			switch (Body.IndexY)
    			{
    			case 0:
    				X1Y0_獣耳外CP.Update();
    				X1Y0_獣耳内CP.Update();
    				X1Y0_耳毛CP.Update();
    				break;
    			case 1:
    				X1Y1_獣耳外CP.Update();
    				X1Y1_獣耳内CP.Update();
    				X1Y1_耳毛CP.Update();
    				break;
    			default:
    				X1Y2_獣耳外CP.Update();
    				X1Y2_獣耳内CP.Update();
    				X1Y2_耳毛CP.Update();
    				break;
    			}
    		}
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
    		獣耳外CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		獣耳内CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
    		耳毛CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		獣耳外CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		獣耳内CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
    		耳毛CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		獣耳外CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		獣耳内CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
    		耳毛CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    	}
    }
}
