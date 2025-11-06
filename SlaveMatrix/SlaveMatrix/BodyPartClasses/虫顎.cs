using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 虫顎 : Ele
    {
    	public Par X0Y0_顎;

    	public Par X0Y0_節;

    	public Par X0Y0_牙_牙1;

    	public Par X0Y0_牙_牙2;

    	public Par X0Y0_牙_牙0;

    	public ColorD 顎CD;

    	public ColorD 節CD;

    	public ColorD 牙_牙1CD;

    	public ColorD 牙_牙2CD;

    	public ColorD 牙_牙0CD;

    	public ColorP X0Y0_顎CP;

    	public ColorP X0Y0_節CP;

    	public ColorP X0Y0_牙_牙1CP;

    	public ColorP X0Y0_牙_牙2CP;

    	public ColorP X0Y0_牙_牙0CP;

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

    	public bool 顎_表示
    	{
    		get
    		{
    			return X0Y0_顎.Dra;
    		}
    		set
    		{
    			X0Y0_顎.Dra = value;
    			X0Y0_顎.Hit = value;
    		}
    	}

    	public bool 節_表示
    	{
    		get
    		{
    			return X0Y0_節.Dra;
    		}
    		set
    		{
    			X0Y0_節.Dra = value;
    			X0Y0_節.Hit = value;
    		}
    	}

    	public bool 牙_牙1_表示
    	{
    		get
    		{
    			return X0Y0_牙_牙1.Dra;
    		}
    		set
    		{
    			X0Y0_牙_牙1.Dra = value;
    			X0Y0_牙_牙1.Hit = value;
    		}
    	}

    	public bool 牙_牙2_表示
    	{
    		get
    		{
    			return X0Y0_牙_牙2.Dra;
    		}
    		set
    		{
    			X0Y0_牙_牙2.Dra = value;
    			X0Y0_牙_牙2.Hit = value;
    		}
    	}

    	public bool 牙_牙0_表示
    	{
    		get
    		{
    			return X0Y0_牙_牙0.Dra;
    		}
    		set
    		{
    			X0Y0_牙_牙0.Dra = value;
    			X0Y0_牙_牙0.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 顎_表示;
    		}
    		set
    		{
    			顎_表示 = value;
    			節_表示 = value;
    			牙_牙1_表示 = value;
    			牙_牙2_表示 = value;
    			牙_牙0_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 顎CD.不透明度;
    		}
    		set
    		{
    			顎CD.不透明度 = value;
    			節CD.不透明度 = value;
    			牙_牙1CD.不透明度 = value;
    			牙_牙2CD.不透明度 = value;
    			牙_牙0CD.不透明度 = value;
    		}
    	}

    	public 虫顎(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 虫顎D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.肢左["虫顎"][0]);
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars = 本体[0][0];
    		X0Y0_顎 = pars["顎"].ToPar();
    		X0Y0_節 = pars["節"].ToPar();
    		Pars pars2 = pars["牙"].ToPars();
    		X0Y0_牙_牙1 = pars2["牙1"].ToPar();
    		X0Y0_牙_牙2 = pars2["牙2"].ToPar();
    		X0Y0_牙_牙0 = pars2["牙0"].ToPar();
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
    		顎_表示 = e.顎_表示;
    		節_表示 = e.節_表示;
    		牙_牙1_表示 = e.牙_牙1_表示;
    		牙_牙2_表示 = e.牙_牙2_表示;
    		牙_牙0_表示 = e.牙_牙0_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_顎CP = new ColorP(X0Y0_顎, 顎CD, DisUnit, abj: true);
    		X0Y0_節CP = new ColorP(X0Y0_節, 節CD, DisUnit, abj: true);
    		X0Y0_牙_牙1CP = new ColorP(X0Y0_牙_牙1, 牙_牙1CD, DisUnit, abj: true);
    		X0Y0_牙_牙2CP = new ColorP(X0Y0_牙_牙2, 牙_牙2CD, DisUnit, abj: true);
    		X0Y0_牙_牙0CP = new ColorP(X0Y0_牙_牙0, 牙_牙0CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_顎.AngleBase = num * -53.0;
    		本体.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		X0Y0_顎CP.Update();
    		X0Y0_節CP.Update();
    		X0Y0_牙_牙1CP.Update();
    		X0Y0_牙_牙2CP.Update();
    		X0Y0_牙_牙0CP.Update();
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
    		顎CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		牙_牙1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		牙_牙2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		牙_牙0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		顎CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		牙_牙1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		牙_牙2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		牙_牙0CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		顎CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		牙_牙1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		牙_牙2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		牙_牙0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    	}
    }
}
