using _2DGAMELIB;

namespace SlaveMatrix
{
    public class Cough : Ele
    {
    	public Par X0Y0_咳基;

    	public Par X0Y0_雫1;

    	public Par X0Y0_雫2;

    	public Par X0Y0_雫3;

    	public Par X0Y0_雫4;

    	public Par X0Y0_雫5;

    	public Par X0Y1_咳基;

    	public Par X0Y1_雫1;

    	public Par X0Y1_雫2;

    	public Par X0Y1_雫3;

    	public Par X0Y1_雫4;

    	public Par X0Y1_雫5;

    	public Par X0Y2_咳基;

    	public Par X0Y2_雫1;

    	public Par X0Y2_雫2;

    	public Par X0Y2_雫3;

    	public Par X0Y2_雫4;

    	public Par X0Y2_雫5;

    	public Par X0Y3_咳基;

    	public Par X0Y3_雫1;

    	public Par X0Y3_雫2;

    	public Par X0Y3_雫3;

    	public Par X0Y3_雫4;

    	public Par X0Y3_雫5;

    	public Par X0Y4_咳基;

    	public Par X0Y4_雫1;

    	public Par X0Y4_雫2;

    	public Par X0Y4_雫3;

    	public Par X0Y4_雫4;

    	public Par X0Y4_雫5;

    	public ColorD 咳基CD;

    	public ColorD 雫1CD;

    	public ColorD 雫2CD;

    	public ColorD 雫3CD;

    	public ColorD 雫4CD;

    	public ColorD 雫5CD;

    	public ColorP X0Y0_咳基CP;

    	public ColorP X0Y0_雫1CP;

    	public ColorP X0Y0_雫2CP;

    	public ColorP X0Y0_雫3CP;

    	public ColorP X0Y0_雫4CP;

    	public ColorP X0Y0_雫5CP;

    	public ColorP X0Y1_咳基CP;

    	public ColorP X0Y1_雫1CP;

    	public ColorP X0Y1_雫2CP;

    	public ColorP X0Y1_雫3CP;

    	public ColorP X0Y1_雫4CP;

    	public ColorP X0Y1_雫5CP;

    	public ColorP X0Y2_咳基CP;

    	public ColorP X0Y2_雫1CP;

    	public ColorP X0Y2_雫2CP;

    	public ColorP X0Y2_雫3CP;

    	public ColorP X0Y2_雫4CP;

    	public ColorP X0Y2_雫5CP;

    	public ColorP X0Y3_咳基CP;

    	public ColorP X0Y3_雫1CP;

    	public ColorP X0Y3_雫2CP;

    	public ColorP X0Y3_雫3CP;

    	public ColorP X0Y3_雫4CP;

    	public ColorP X0Y3_雫5CP;

    	public ColorP X0Y4_咳基CP;

    	public ColorP X0Y4_雫1CP;

    	public ColorP X0Y4_雫2CP;

    	public ColorP X0Y4_雫3CP;

    	public ColorP X0Y4_雫4CP;

    	public ColorP X0Y4_雫5CP;

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

    	public bool 咳基_表示
    	{
    		get
    		{
    			return X0Y0_咳基.Dra;
    		}
    		set
    		{
    			X0Y0_咳基.Dra = value;
    			X0Y1_咳基.Dra = value;
    			X0Y2_咳基.Dra = value;
    			X0Y3_咳基.Dra = value;
    			X0Y4_咳基.Dra = value;
    			X0Y0_咳基.Hit = value;
    			X0Y1_咳基.Hit = value;
    			X0Y2_咳基.Hit = value;
    			X0Y3_咳基.Hit = value;
    			X0Y4_咳基.Hit = value;
    		}
    	}

    	public bool 雫1_表示
    	{
    		get
    		{
    			return X0Y0_雫1.Dra;
    		}
    		set
    		{
    			X0Y0_雫1.Dra = value;
    			X0Y1_雫1.Dra = value;
    			X0Y2_雫1.Dra = value;
    			X0Y3_雫1.Dra = value;
    			X0Y4_雫1.Dra = value;
    			X0Y0_雫1.Hit = value;
    			X0Y1_雫1.Hit = value;
    			X0Y2_雫1.Hit = value;
    			X0Y3_雫1.Hit = value;
    			X0Y4_雫1.Hit = value;
    		}
    	}

    	public bool 雫2_表示
    	{
    		get
    		{
    			return X0Y0_雫2.Dra;
    		}
    		set
    		{
    			X0Y0_雫2.Dra = value;
    			X0Y1_雫2.Dra = value;
    			X0Y2_雫2.Dra = value;
    			X0Y3_雫2.Dra = value;
    			X0Y4_雫2.Dra = value;
    			X0Y0_雫2.Hit = value;
    			X0Y1_雫2.Hit = value;
    			X0Y2_雫2.Hit = value;
    			X0Y3_雫2.Hit = value;
    			X0Y4_雫2.Hit = value;
    		}
    	}

    	public bool 雫3_表示
    	{
    		get
    		{
    			return X0Y0_雫3.Dra;
    		}
    		set
    		{
    			X0Y0_雫3.Dra = value;
    			X0Y1_雫3.Dra = value;
    			X0Y2_雫3.Dra = value;
    			X0Y3_雫3.Dra = value;
    			X0Y4_雫3.Dra = value;
    			X0Y0_雫3.Hit = value;
    			X0Y1_雫3.Hit = value;
    			X0Y2_雫3.Hit = value;
    			X0Y3_雫3.Hit = value;
    			X0Y4_雫3.Hit = value;
    		}
    	}

    	public bool 雫4_表示
    	{
    		get
    		{
    			return X0Y0_雫4.Dra;
    		}
    		set
    		{
    			X0Y0_雫4.Dra = value;
    			X0Y1_雫4.Dra = value;
    			X0Y2_雫4.Dra = value;
    			X0Y3_雫4.Dra = value;
    			X0Y4_雫4.Dra = value;
    			X0Y0_雫4.Hit = value;
    			X0Y1_雫4.Hit = value;
    			X0Y2_雫4.Hit = value;
    			X0Y3_雫4.Hit = value;
    			X0Y4_雫4.Hit = value;
    		}
    	}

    	public bool 雫5_表示
    	{
    		get
    		{
    			return X0Y0_雫5.Dra;
    		}
    		set
    		{
    			X0Y0_雫5.Dra = value;
    			X0Y1_雫5.Dra = value;
    			X0Y2_雫5.Dra = value;
    			X0Y3_雫5.Dra = value;
    			X0Y4_雫5.Dra = value;
    			X0Y0_雫5.Hit = value;
    			X0Y1_雫5.Hit = value;
    			X0Y2_雫5.Hit = value;
    			X0Y3_雫5.Hit = value;
    			X0Y4_雫5.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 咳基_表示;
    		}
    		set
    		{
    			咳基_表示 = value;
    			雫1_表示 = value;
    			雫2_表示 = value;
    			雫3_表示 = value;
    			雫4_表示 = value;
    			雫5_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 咳基CD.不透明度;
    		}
    		set
    		{
    			咳基CD.不透明度 = value;
    			雫1CD.不透明度 = value;
    			雫2CD.不透明度 = value;
    			雫3CD.不透明度 = value;
    			雫4CD.不透明度 = value;
    			雫5CD.不透明度 = value;
    		}
    	}

    	public override double 肥大
    	{
    		set
    		{
    		}
    	}

    	public override double 身長
    	{
    		set
    		{
    		}
    	}

    	public Cough(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 咳D e)
    	{
    		ThisType = GetType();
    		本体 = new Difs(Sta.胴体["Cough"]);
    		Pars pars = 本体[0][0];
    		X0Y0_咳基 = pars["咳基"].ToPar();
    		X0Y0_雫1 = pars["雫1"].ToPar();
    		X0Y0_雫2 = pars["雫2"].ToPar();
    		X0Y0_雫3 = pars["雫3"].ToPar();
    		X0Y0_雫4 = pars["雫4"].ToPar();
    		X0Y0_雫5 = pars["雫5"].ToPar();
    		pars = 本体[0][1];
    		X0Y1_咳基 = pars["咳基"].ToPar();
    		X0Y1_雫1 = pars["雫1"].ToPar();
    		X0Y1_雫2 = pars["雫2"].ToPar();
    		X0Y1_雫3 = pars["雫3"].ToPar();
    		X0Y1_雫4 = pars["雫4"].ToPar();
    		X0Y1_雫5 = pars["雫5"].ToPar();
    		pars = 本体[0][2];
    		X0Y2_咳基 = pars["咳基"].ToPar();
    		X0Y2_雫1 = pars["雫1"].ToPar();
    		X0Y2_雫2 = pars["雫2"].ToPar();
    		X0Y2_雫3 = pars["雫3"].ToPar();
    		X0Y2_雫4 = pars["雫4"].ToPar();
    		X0Y2_雫5 = pars["雫5"].ToPar();
    		pars = 本体[0][3];
    		X0Y3_咳基 = pars["咳基"].ToPar();
    		X0Y3_雫1 = pars["雫1"].ToPar();
    		X0Y3_雫2 = pars["雫2"].ToPar();
    		X0Y3_雫3 = pars["雫3"].ToPar();
    		X0Y3_雫4 = pars["雫4"].ToPar();
    		X0Y3_雫5 = pars["雫5"].ToPar();
    		pars = 本体[0][4];
    		X0Y4_咳基 = pars["咳基"].ToPar();
    		X0Y4_雫1 = pars["雫1"].ToPar();
    		X0Y4_雫2 = pars["雫2"].ToPar();
    		X0Y4_雫3 = pars["雫3"].ToPar();
    		X0Y4_雫4 = pars["雫4"].ToPar();
    		X0Y4_雫5 = pars["雫5"].ToPar();
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
    		咳基_表示 = e.咳基_表示;
    		雫1_表示 = e.雫1_表示;
    		雫2_表示 = e.雫2_表示;
    		雫3_表示 = e.雫3_表示;
    		雫4_表示 = e.雫4_表示;
    		雫5_表示 = e.雫5_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_咳基CP = new ColorP(X0Y0_咳基, 咳基CD, DisUnit, abj: true);
    		X0Y0_雫1CP = new ColorP(X0Y0_雫1, 雫1CD, DisUnit, abj: true);
    		X0Y0_雫2CP = new ColorP(X0Y0_雫2, 雫2CD, DisUnit, abj: true);
    		X0Y0_雫3CP = new ColorP(X0Y0_雫3, 雫3CD, DisUnit, abj: true);
    		X0Y0_雫4CP = new ColorP(X0Y0_雫4, 雫4CD, DisUnit, abj: true);
    		X0Y0_雫5CP = new ColorP(X0Y0_雫5, 雫5CD, DisUnit, abj: true);
    		X0Y1_咳基CP = new ColorP(X0Y1_咳基, 咳基CD, DisUnit, abj: true);
    		X0Y1_雫1CP = new ColorP(X0Y1_雫1, 雫1CD, DisUnit, abj: true);
    		X0Y1_雫2CP = new ColorP(X0Y1_雫2, 雫2CD, DisUnit, abj: true);
    		X0Y1_雫3CP = new ColorP(X0Y1_雫3, 雫3CD, DisUnit, abj: true);
    		X0Y1_雫4CP = new ColorP(X0Y1_雫4, 雫4CD, DisUnit, abj: true);
    		X0Y1_雫5CP = new ColorP(X0Y1_雫5, 雫5CD, DisUnit, abj: true);
    		X0Y2_咳基CP = new ColorP(X0Y2_咳基, 咳基CD, DisUnit, abj: true);
    		X0Y2_雫1CP = new ColorP(X0Y2_雫1, 雫1CD, DisUnit, abj: true);
    		X0Y2_雫2CP = new ColorP(X0Y2_雫2, 雫2CD, DisUnit, abj: true);
    		X0Y2_雫3CP = new ColorP(X0Y2_雫3, 雫3CD, DisUnit, abj: true);
    		X0Y2_雫4CP = new ColorP(X0Y2_雫4, 雫4CD, DisUnit, abj: true);
    		X0Y2_雫5CP = new ColorP(X0Y2_雫5, 雫5CD, DisUnit, abj: true);
    		X0Y3_咳基CP = new ColorP(X0Y3_咳基, 咳基CD, DisUnit, abj: true);
    		X0Y3_雫1CP = new ColorP(X0Y3_雫1, 雫1CD, DisUnit, abj: true);
    		X0Y3_雫2CP = new ColorP(X0Y3_雫2, 雫2CD, DisUnit, abj: true);
    		X0Y3_雫3CP = new ColorP(X0Y3_雫3, 雫3CD, DisUnit, abj: true);
    		X0Y3_雫4CP = new ColorP(X0Y3_雫4, 雫4CD, DisUnit, abj: true);
    		X0Y3_雫5CP = new ColorP(X0Y3_雫5, 雫5CD, DisUnit, abj: true);
    		X0Y4_咳基CP = new ColorP(X0Y4_咳基, 咳基CD, DisUnit, abj: true);
    		X0Y4_雫1CP = new ColorP(X0Y4_雫1, 雫1CD, DisUnit, abj: true);
    		X0Y4_雫2CP = new ColorP(X0Y4_雫2, 雫2CD, DisUnit, abj: true);
    		X0Y4_雫3CP = new ColorP(X0Y4_雫3, 雫3CD, DisUnit, abj: true);
    		X0Y4_雫4CP = new ColorP(X0Y4_雫4, 雫4CD, DisUnit, abj: true);
    		X0Y4_雫5CP = new ColorP(X0Y4_雫5, 雫5CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public override void 色更新()
    	{
    		switch (本体.IndexY)
    		{
    		case 0:
    			X0Y0_咳基CP.Update();
    			X0Y0_雫1CP.Update();
    			X0Y0_雫2CP.Update();
    			X0Y0_雫3CP.Update();
    			X0Y0_雫4CP.Update();
    			X0Y0_雫5CP.Update();
    			break;
    		case 1:
    			X0Y1_咳基CP.Update();
    			X0Y1_雫1CP.Update();
    			X0Y1_雫2CP.Update();
    			X0Y1_雫3CP.Update();
    			X0Y1_雫4CP.Update();
    			X0Y1_雫5CP.Update();
    			break;
    		case 2:
    			X0Y2_咳基CP.Update();
    			X0Y2_雫1CP.Update();
    			X0Y2_雫2CP.Update();
    			X0Y2_雫3CP.Update();
    			X0Y2_雫4CP.Update();
    			X0Y2_雫5CP.Update();
    			break;
    		case 3:
    			X0Y3_咳基CP.Update();
    			X0Y3_雫1CP.Update();
    			X0Y3_雫2CP.Update();
    			X0Y3_雫3CP.Update();
    			X0Y3_雫4CP.Update();
    			X0Y3_雫5CP.Update();
    			break;
    		default:
    			X0Y4_咳基CP.Update();
    			X0Y4_雫1CP.Update();
    			X0Y4_雫2CP.Update();
    			X0Y4_雫3CP.Update();
    			X0Y4_雫4CP.Update();
    			X0Y4_雫5CP.Update();
    			break;
    		}
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		咳基CD = new ColorD(ref Col.Empty, ref Color2.Empty);
    		雫1CD = new ColorD(ref Col.Empty, ref 体配色.体液);
    		雫2CD = new ColorD(ref Col.Empty, ref 体配色.体液);
    		雫3CD = new ColorD(ref Col.Empty, ref 体配色.体液);
    		雫4CD = new ColorD(ref Col.Empty, ref 体配色.体液);
    		雫5CD = new ColorD(ref Col.Empty, ref 体配色.体液);
    	}
    }
}
