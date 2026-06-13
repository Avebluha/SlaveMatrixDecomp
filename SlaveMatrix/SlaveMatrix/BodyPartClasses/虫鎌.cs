using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 虫鎌 : Ele
    {
    	public ShapePart X0Y0_虫鎌節;

    	public ShapePart X0Y0_虫棘1;

    	public ShapePart X0Y0_虫棘2;

    	public ShapePart X0Y0_虫棘3;

    	public ShapePart X0Y0_虫棘4;

    	public ShapePart X0Y0_虫鎌1;

    	public ShapePart X0Y0_虫鎌2;

    	public ShapePart X0Y0_虫鎌3;

    	public ShapePart X0Y0_虫孔1;

    	public ShapePart X0Y0_虫孔2;

    	public ShapePart X0Y0_輪_革;

    	public ShapePart X0Y0_輪_金具1;

    	public ShapePart X0Y0_輪_金具2;

    	public ShapePart X0Y0_輪_金具3;

    	public ShapePart X0Y0_輪_金具左;

    	public ShapePart X0Y0_輪_金具右;

    	public ColorD 虫鎌節CD;

    	public ColorD 虫棘1CD;

    	public ColorD 虫棘2CD;

    	public ColorD 虫棘3CD;

    	public ColorD 虫棘4CD;

    	public ColorD 虫鎌1CD;

    	public ColorD 虫鎌2CD;

    	public ColorD 虫鎌3CD;

    	public ColorD 虫孔1CD;

    	public ColorD 虫孔2CD;

    	public ColorD 輪_革CD;

    	public ColorD 輪_金具1CD;

    	public ColorD 輪_金具2CD;

    	public ColorD 輪_金具3CD;

    	public ColorD 輪_金具左CD;

    	public ColorD 輪_金具右CD;

    	public ColorP X0Y0_虫鎌節CP;

    	public ColorP X0Y0_虫棘1CP;

    	public ColorP X0Y0_虫棘2CP;

    	public ColorP X0Y0_虫棘3CP;

    	public ColorP X0Y0_虫棘4CP;

    	public ColorP X0Y0_虫鎌1CP;

    	public ColorP X0Y0_虫鎌2CP;

    	public ColorP X0Y0_虫鎌3CP;

    	public ColorP X0Y0_虫孔1CP;

    	public ColorP X0Y0_虫孔2CP;

    	public ColorP X0Y0_輪_革CP;

    	public ColorP X0Y0_輪_金具1CP;

    	public ColorP X0Y0_輪_金具2CP;

    	public ColorP X0Y0_輪_金具3CP;

    	public ColorP X0Y0_輪_金具左CP;

    	public ColorP X0Y0_輪_金具右CP;

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

    	public bool 虫鎌節_表示
    	{
    		get
    		{
    			return X0Y0_虫鎌節.Dra;
    		}
    		set
    		{
    			X0Y0_虫鎌節.Dra = value;
    			X0Y0_虫鎌節.Hit = value;
    		}
    	}

    	public bool 虫棘1_表示
    	{
    		get
    		{
    			return X0Y0_虫棘1.Dra;
    		}
    		set
    		{
    			X0Y0_虫棘1.Dra = value;
    			X0Y0_虫棘1.Hit = value;
    		}
    	}

    	public bool 虫棘2_表示
    	{
    		get
    		{
    			return X0Y0_虫棘2.Dra;
    		}
    		set
    		{
    			X0Y0_虫棘2.Dra = value;
    			X0Y0_虫棘2.Hit = value;
    		}
    	}

    	public bool 虫棘3_表示
    	{
    		get
    		{
    			return X0Y0_虫棘3.Dra;
    		}
    		set
    		{
    			X0Y0_虫棘3.Dra = value;
    			X0Y0_虫棘3.Hit = value;
    		}
    	}

    	public bool 虫棘4_表示
    	{
    		get
    		{
    			return X0Y0_虫棘4.Dra;
    		}
    		set
    		{
    			X0Y0_虫棘4.Dra = value;
    			X0Y0_虫棘4.Hit = value;
    		}
    	}

    	public bool 虫鎌1_表示
    	{
    		get
    		{
    			return X0Y0_虫鎌1.Dra;
    		}
    		set
    		{
    			X0Y0_虫鎌1.Dra = value;
    			X0Y0_虫鎌1.Hit = value;
    		}
    	}

    	public bool 虫鎌2_表示
    	{
    		get
    		{
    			return X0Y0_虫鎌2.Dra;
    		}
    		set
    		{
    			X0Y0_虫鎌2.Dra = value;
    			X0Y0_虫鎌2.Hit = value;
    		}
    	}

    	public bool 虫鎌3_表示
    	{
    		get
    		{
    			return X0Y0_虫鎌3.Dra;
    		}
    		set
    		{
    			X0Y0_虫鎌3.Dra = value;
    			X0Y0_虫鎌3.Hit = value;
    		}
    	}

    	public bool 虫孔1_表示
    	{
    		get
    		{
    			return X0Y0_虫孔1.Dra;
    		}
    		set
    		{
    			X0Y0_虫孔1.Dra = value;
    			X0Y0_虫孔1.Hit = value;
    		}
    	}

    	public bool 虫孔2_表示
    	{
    		get
    		{
    			return X0Y0_虫孔2.Dra;
    		}
    		set
    		{
    			X0Y0_虫孔2.Dra = value;
    			X0Y0_虫孔2.Hit = value;
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

    	public override bool 表示
    	{
    		get
    		{
    			return 虫鎌節_表示;
    		}
    		set
    		{
    			虫鎌節_表示 = value;
    			虫棘1_表示 = value;
    			虫棘2_表示 = value;
    			虫棘3_表示 = value;
    			虫棘4_表示 = value;
    			虫鎌1_表示 = value;
    			虫鎌2_表示 = value;
    			虫鎌3_表示 = value;
    			虫孔1_表示 = value;
    			虫孔2_表示 = value;
    			輪_革_表示 = value;
    			輪_金具1_表示 = value;
    			輪_金具2_表示 = value;
    			輪_金具3_表示 = value;
    			輪_金具左_表示 = value;
    			輪_金具右_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 虫鎌節CD.不透明度;
    		}
    		set
    		{
    			虫鎌節CD.不透明度 = value;
    			虫棘1CD.不透明度 = value;
    			虫棘2CD.不透明度 = value;
    			虫棘3CD.不透明度 = value;
    			虫棘4CD.不透明度 = value;
    			虫鎌1CD.不透明度 = value;
    			虫鎌2CD.不透明度 = value;
    			虫鎌3CD.不透明度 = value;
    			虫孔1CD.不透明度 = value;
    			虫孔2CD.不透明度 = value;
    			輪_革CD.不透明度 = value;
    			輪_金具1CD.不透明度 = value;
    			輪_金具2CD.不透明度 = value;
    			輪_金具3CD.不透明度 = value;
    			輪_金具左CD.不透明度 = value;
    			輪_金具右CD.不透明度 = value;
    		}
    	}

    	public override bool 反転Y
    	{
    		get
    		{
    			return 反転Y_;
    		}
    		set
    		{
    			if (反転Y_ != value)
    			{
    				Body.JoinPAall();
    				Body.ReverseY();
    				X0Y0_輪_革.ReverseY();
    				X0Y0_輪_金具1.ReverseY();
    				X0Y0_輪_金具2.ReverseY();
    				X0Y0_輪_金具3.ReverseY();
    				X0Y0_輪_金具左.ReverseY();
    				X0Y0_輪_金具右.ReverseY();
    				Body.JoinP();
    			}
    			反転Y_ = value;
    		}
    	}

    	public 虫鎌(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 虫鎌D e)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid(Sta.肢左["虫鎌"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_虫鎌節 = partGroup["虫鎌節"].ToPar();
    		X0Y0_虫棘1 = partGroup["虫棘1"].ToPar();
    		X0Y0_虫棘2 = partGroup["虫棘2"].ToPar();
    		X0Y0_虫棘3 = partGroup["虫棘3"].ToPar();
    		X0Y0_虫棘4 = partGroup["虫棘4"].ToPar();
    		X0Y0_虫鎌1 = partGroup["虫鎌1"].ToPar();
    		X0Y0_虫鎌2 = partGroup["虫鎌2"].ToPar();
    		X0Y0_虫鎌3 = partGroup["虫鎌3"].ToPar();
    		X0Y0_虫孔1 = partGroup["虫孔1"].ToPar();
    		X0Y0_虫孔2 = partGroup["虫孔2"].ToPar();
    		PartGroup pars2 = partGroup["輪"].ToPars();
    		X0Y0_輪_革 = pars2["革"].ToPar();
    		X0Y0_輪_金具1 = pars2["金具1"].ToPar();
    		X0Y0_輪_金具2 = pars2["金具2"].ToPar();
    		X0Y0_輪_金具3 = pars2["金具3"].ToPar();
    		X0Y0_輪_金具左 = pars2["金具左"].ToPar();
    		X0Y0_輪_金具右 = pars2["金具右"].ToPar();
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
    		虫鎌節_表示 = e.虫鎌節_表示;
    		虫棘1_表示 = e.虫棘1_表示;
    		虫棘2_表示 = e.虫棘2_表示;
    		虫棘3_表示 = e.虫棘3_表示;
    		虫棘4_表示 = e.虫棘4_表示;
    		虫鎌1_表示 = e.虫鎌1_表示;
    		虫鎌2_表示 = e.虫鎌2_表示;
    		虫鎌3_表示 = e.虫鎌3_表示;
    		虫孔1_表示 = e.虫孔1_表示;
    		虫孔2_表示 = e.虫孔2_表示;
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
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_虫鎌節CP = new ColorP(X0Y0_虫鎌節, 虫鎌節CD, DisUnit, abj: true);
    		X0Y0_虫棘1CP = new ColorP(X0Y0_虫棘1, 虫棘1CD, DisUnit, abj: true);
    		X0Y0_虫棘2CP = new ColorP(X0Y0_虫棘2, 虫棘2CD, DisUnit, abj: true);
    		X0Y0_虫棘3CP = new ColorP(X0Y0_虫棘3, 虫棘3CD, DisUnit, abj: true);
    		X0Y0_虫棘4CP = new ColorP(X0Y0_虫棘4, 虫棘4CD, DisUnit, abj: true);
    		X0Y0_虫鎌1CP = new ColorP(X0Y0_虫鎌1, 虫鎌1CD, DisUnit, abj: true);
    		X0Y0_虫鎌2CP = new ColorP(X0Y0_虫鎌2, 虫鎌2CD, DisUnit, abj: true);
    		X0Y0_虫鎌3CP = new ColorP(X0Y0_虫鎌3, 虫鎌3CD, DisUnit, abj: true);
    		X0Y0_虫孔1CP = new ColorP(X0Y0_虫孔1, 虫孔1CD, DisUnit, abj: true);
    		X0Y0_虫孔2CP = new ColorP(X0Y0_虫孔2, 虫孔2CD, DisUnit, abj: true);
    		X0Y0_輪_革CP = new ColorP(X0Y0_輪_革, 輪_革CD, DisUnit, abj: true);
    		X0Y0_輪_金具1CP = new ColorP(X0Y0_輪_金具1, 輪_金具1CD, DisUnit, abj: true);
    		X0Y0_輪_金具2CP = new ColorP(X0Y0_輪_金具2, 輪_金具2CD, DisUnit, abj: true);
    		X0Y0_輪_金具3CP = new ColorP(X0Y0_輪_金具3, 輪_金具3CD, DisUnit, abj: true);
    		X0Y0_輪_金具左CP = new ColorP(X0Y0_輪_金具左, 輪_金具左CD, DisUnit, abj: true);
    		X0Y0_輪_金具右CP = new ColorP(X0Y0_輪_金具右, 輪_金具右CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		num *= (反転Y ? (-1.0) : 1.0);
    		X0Y0_虫鎌1.AngleBase = num * -14.0;
    		Body.JoinPAall();
    	}

    	public override bool Is革(ShapePart p)
    	{
    		if (p != X0Y0_輪_革 && p != X0Y0_輪_金具1 && p != X0Y0_輪_金具2 && p != X0Y0_輪_金具3 && p != X0Y0_輪_金具左)
    		{
    			return p == X0Y0_輪_金具右;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_虫鎌節CP.Update();
    		X0Y0_虫棘1CP.Update();
    		X0Y0_虫棘2CP.Update();
    		X0Y0_虫棘3CP.Update();
    		X0Y0_虫棘4CP.Update();
    		X0Y0_虫鎌1CP.Update();
    		X0Y0_虫鎌2CP.Update();
    		X0Y0_虫鎌3CP.Update();
    		X0Y0_虫孔1CP.Update();
    		X0Y0_虫孔2CP.Update();
    		X0Y0_輪_革CP.Update();
    		X0Y0_輪_金具1CP.Update();
    		X0Y0_輪_金具2CP.Update();
    		X0Y0_輪_金具3CP.Update();
    		X0Y0_輪_金具左CP.Update();
    		X0Y0_輪_金具右CP.Update();
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
    		虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫鎌1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫鎌2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫鎌3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫孔1CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
    		虫孔2CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫鎌1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫鎌2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫鎌3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫孔1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫孔2CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫鎌1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫鎌2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫鎌3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫孔1CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
    		虫孔2CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
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
    }
}
