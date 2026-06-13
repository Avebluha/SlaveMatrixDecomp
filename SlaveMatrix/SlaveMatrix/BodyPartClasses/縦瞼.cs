using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 縦瞼 : Ele
    {
    	public ShapePart X0Y0_瞼左_瞼;

    	public ShapePart X0Y0_瞼左_睫毛1;

    	public ShapePart X0Y0_瞼左_睫毛2;

    	public ShapePart X0Y0_瞼右_瞼;

    	public ShapePart X0Y0_瞼右_睫毛1;

    	public ShapePart X0Y0_瞼右_睫毛2;

    	public ShapePart X0Y1_瞼左_瞼;

    	public ShapePart X0Y1_瞼左_睫毛1;

    	public ShapePart X0Y1_瞼左_睫毛2;

    	public ShapePart X0Y1_瞼右_瞼;

    	public ShapePart X0Y1_瞼右_睫毛1;

    	public ShapePart X0Y1_瞼右_睫毛2;

    	public ShapePart X0Y2_瞼左_瞼;

    	public ShapePart X0Y2_瞼左_睫毛1;

    	public ShapePart X0Y2_瞼左_睫毛2;

    	public ShapePart X0Y2_瞼右_瞼;

    	public ShapePart X0Y2_瞼右_睫毛1;

    	public ShapePart X0Y2_瞼右_睫毛2;

    	public ShapePart X0Y3_瞼左_瞼;

    	public ShapePart X0Y3_瞼左_睫毛1;

    	public ShapePart X0Y3_瞼左_睫毛2;

    	public ShapePart X0Y3_瞼右_瞼;

    	public ShapePart X0Y3_瞼右_睫毛1;

    	public ShapePart X0Y3_瞼右_睫毛2;

    	public ShapePart X0Y4_瞼左_瞼;

    	public ShapePart X0Y4_瞼左_睫毛1;

    	public ShapePart X0Y4_瞼左_睫毛2;

    	public ShapePart X0Y4_瞼右_瞼;

    	public ShapePart X0Y4_瞼右_睫毛1;

    	public ShapePart X0Y4_瞼右_睫毛2;

    	public ColorD 瞼左_瞼CD;

    	public ColorD 瞼左_睫毛1CD;

    	public ColorD 瞼左_睫毛2CD;

    	public ColorD 瞼右_瞼CD;

    	public ColorD 瞼右_睫毛1CD;

    	public ColorD 瞼右_睫毛2CD;

    	public ColorP X0Y0_瞼左_瞼CP;

    	public ColorP X0Y0_瞼左_睫毛1CP;

    	public ColorP X0Y0_瞼左_睫毛2CP;

    	public ColorP X0Y0_瞼右_瞼CP;

    	public ColorP X0Y0_瞼右_睫毛1CP;

    	public ColorP X0Y0_瞼右_睫毛2CP;

    	public ColorP X0Y1_瞼左_瞼CP;

    	public ColorP X0Y1_瞼左_睫毛1CP;

    	public ColorP X0Y1_瞼左_睫毛2CP;

    	public ColorP X0Y1_瞼右_瞼CP;

    	public ColorP X0Y1_瞼右_睫毛1CP;

    	public ColorP X0Y1_瞼右_睫毛2CP;

    	public ColorP X0Y2_瞼左_瞼CP;

    	public ColorP X0Y2_瞼左_睫毛1CP;

    	public ColorP X0Y2_瞼左_睫毛2CP;

    	public ColorP X0Y2_瞼右_瞼CP;

    	public ColorP X0Y2_瞼右_睫毛1CP;

    	public ColorP X0Y2_瞼右_睫毛2CP;

    	public ColorP X0Y3_瞼左_瞼CP;

    	public ColorP X0Y3_瞼左_睫毛1CP;

    	public ColorP X0Y3_瞼左_睫毛2CP;

    	public ColorP X0Y3_瞼右_瞼CP;

    	public ColorP X0Y3_瞼右_睫毛1CP;

    	public ColorP X0Y3_瞼右_睫毛2CP;

    	public ColorP X0Y4_瞼左_瞼CP;

    	public ColorP X0Y4_瞼左_睫毛1CP;

    	public ColorP X0Y4_瞼左_睫毛2CP;

    	public ColorP X0Y4_瞼右_瞼CP;

    	public ColorP X0Y4_瞼右_睫毛1CP;

    	public ColorP X0Y4_瞼右_睫毛2CP;

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

    	public bool 瞼左_瞼_表示
    	{
    		get
    		{
    			return X0Y0_瞼左_瞼.Dra;
    		}
    		set
    		{
    			X0Y0_瞼左_瞼.Dra = value;
    			X0Y1_瞼左_瞼.Dra = value;
    			X0Y2_瞼左_瞼.Dra = value;
    			X0Y3_瞼左_瞼.Dra = value;
    			X0Y4_瞼左_瞼.Dra = value;
    			X0Y0_瞼左_瞼.Hit = value;
    			X0Y1_瞼左_瞼.Hit = value;
    			X0Y2_瞼左_瞼.Hit = value;
    			X0Y3_瞼左_瞼.Hit = value;
    			X0Y4_瞼左_瞼.Hit = value;
    		}
    	}

    	public bool 瞼左_睫毛1_表示
    	{
    		get
    		{
    			return X0Y0_瞼左_睫毛1.Dra;
    		}
    		set
    		{
    			X0Y0_瞼左_睫毛1.Dra = value;
    			X0Y1_瞼左_睫毛1.Dra = value;
    			X0Y2_瞼左_睫毛1.Dra = value;
    			X0Y3_瞼左_睫毛1.Dra = value;
    			X0Y4_瞼左_睫毛1.Dra = value;
    			X0Y0_瞼左_睫毛1.Hit = value;
    			X0Y1_瞼左_睫毛1.Hit = value;
    			X0Y2_瞼左_睫毛1.Hit = value;
    			X0Y3_瞼左_睫毛1.Hit = value;
    			X0Y4_瞼左_睫毛1.Hit = value;
    		}
    	}

    	public bool 瞼左_睫毛2_表示
    	{
    		get
    		{
    			return X0Y0_瞼左_睫毛2.Dra;
    		}
    		set
    		{
    			X0Y0_瞼左_睫毛2.Dra = value;
    			X0Y1_瞼左_睫毛2.Dra = value;
    			X0Y2_瞼左_睫毛2.Dra = value;
    			X0Y3_瞼左_睫毛2.Dra = value;
    			X0Y4_瞼左_睫毛2.Dra = value;
    			X0Y0_瞼左_睫毛2.Hit = value;
    			X0Y1_瞼左_睫毛2.Hit = value;
    			X0Y2_瞼左_睫毛2.Hit = value;
    			X0Y3_瞼左_睫毛2.Hit = value;
    			X0Y4_瞼左_睫毛2.Hit = value;
    		}
    	}

    	public bool 瞼右_瞼_表示
    	{
    		get
    		{
    			return X0Y0_瞼右_瞼.Dra;
    		}
    		set
    		{
    			X0Y0_瞼右_瞼.Dra = value;
    			X0Y1_瞼右_瞼.Dra = value;
    			X0Y2_瞼右_瞼.Dra = value;
    			X0Y3_瞼右_瞼.Dra = value;
    			X0Y4_瞼右_瞼.Dra = value;
    			X0Y0_瞼右_瞼.Hit = value;
    			X0Y1_瞼右_瞼.Hit = value;
    			X0Y2_瞼右_瞼.Hit = value;
    			X0Y3_瞼右_瞼.Hit = value;
    			X0Y4_瞼右_瞼.Hit = value;
    		}
    	}

    	public bool 瞼右_睫毛1_表示
    	{
    		get
    		{
    			return X0Y0_瞼右_睫毛1.Dra;
    		}
    		set
    		{
    			X0Y0_瞼右_睫毛1.Dra = value;
    			X0Y1_瞼右_睫毛1.Dra = value;
    			X0Y2_瞼右_睫毛1.Dra = value;
    			X0Y3_瞼右_睫毛1.Dra = value;
    			X0Y4_瞼右_睫毛1.Dra = value;
    			X0Y0_瞼右_睫毛1.Hit = value;
    			X0Y1_瞼右_睫毛1.Hit = value;
    			X0Y2_瞼右_睫毛1.Hit = value;
    			X0Y3_瞼右_睫毛1.Hit = value;
    			X0Y4_瞼右_睫毛1.Hit = value;
    		}
    	}

    	public bool 瞼右_睫毛2_表示
    	{
    		get
    		{
    			return X0Y0_瞼右_睫毛2.Dra;
    		}
    		set
    		{
    			X0Y0_瞼右_睫毛2.Dra = value;
    			X0Y1_瞼右_睫毛2.Dra = value;
    			X0Y2_瞼右_睫毛2.Dra = value;
    			X0Y3_瞼右_睫毛2.Dra = value;
    			X0Y4_瞼右_睫毛2.Dra = value;
    			X0Y0_瞼右_睫毛2.Hit = value;
    			X0Y1_瞼右_睫毛2.Hit = value;
    			X0Y2_瞼右_睫毛2.Hit = value;
    			X0Y3_瞼右_睫毛2.Hit = value;
    			X0Y4_瞼右_睫毛2.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 瞼左_瞼_表示;
    		}
    		set
    		{
    			瞼左_瞼_表示 = value;
    			瞼左_睫毛1_表示 = value;
    			瞼左_睫毛2_表示 = value;
    			瞼右_瞼_表示 = value;
    			瞼右_睫毛1_表示 = value;
    			瞼右_睫毛2_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 瞼左_瞼CD.不透明度;
    		}
    		set
    		{
    			瞼左_瞼CD.不透明度 = value;
    			瞼左_睫毛1CD.不透明度 = value;
    			瞼左_睫毛2CD.不透明度 = value;
    			瞼右_瞼CD.不透明度 = value;
    			瞼右_睫毛1CD.不透明度 = value;
    			瞼右_睫毛2CD.不透明度 = value;
    		}
    	}

    	public double 外線
    	{
    		set
    		{
    			double num = 0.9 + 0.55 * value;
    			X0Y0_瞼左_瞼.PenWidth *= num;
    			X0Y0_瞼右_瞼.PenWidth *= num;
    			X0Y1_瞼左_瞼.PenWidth *= num;
    			X0Y1_瞼右_瞼.PenWidth *= num;
    			X0Y2_瞼左_瞼.PenWidth *= num;
    			X0Y2_瞼右_瞼.PenWidth *= num;
    			X0Y3_瞼左_瞼.PenWidth *= num;
    			X0Y3_瞼右_瞼.PenWidth *= num;
    			X0Y4_瞼左_瞼.PenWidth *= num;
    			X0Y4_瞼右_瞼.PenWidth *= num;
    		}
    	}

    	public double 瞼左_睫毛1_長さ
    	{
    		set
    		{
    			睫毛長さ(X0Y0_瞼左_睫毛1, value);
    			睫毛長さ(X0Y1_瞼左_睫毛1, value);
    			睫毛長さ(X0Y2_瞼左_睫毛1, value);
    			睫毛長さ(X0Y3_瞼左_睫毛1, value);
    			睫毛長さ(X0Y4_瞼左_睫毛1, value);
    		}
    	}

    	public double 瞼左_睫毛2_長さ
    	{
    		set
    		{
    			睫毛長さ(X0Y0_瞼左_睫毛2, value);
    			睫毛長さ(X0Y1_瞼左_睫毛2, value);
    			睫毛長さ(X0Y2_瞼左_睫毛2, value);
    			睫毛長さ(X0Y3_瞼左_睫毛2, value);
    			睫毛長さ(X0Y4_瞼左_睫毛2, value);
    		}
    	}

    	public double 瞼右_睫毛1_長さ
    	{
    		set
    		{
    			睫毛長さ(X0Y0_瞼右_睫毛1, value);
    			睫毛長さ(X0Y1_瞼右_睫毛1, value);
    			睫毛長さ(X0Y2_瞼右_睫毛1, value);
    			睫毛長さ(X0Y3_瞼右_睫毛1, value);
    			睫毛長さ(X0Y4_瞼右_睫毛1, value);
    		}
    	}

    	public double 瞼右_睫毛2_長さ
    	{
    		set
    		{
    			睫毛長さ(X0Y0_瞼右_睫毛2, value);
    			睫毛長さ(X0Y1_瞼右_睫毛2, value);
    			睫毛長さ(X0Y2_瞼右_睫毛2, value);
    			睫毛長さ(X0Y3_瞼右_睫毛2, value);
    			睫毛長さ(X0Y4_瞼右_睫毛2, value);
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

    	public 縦瞼(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 縦瞼D e)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.胴体["額瞼"]);
    		PartGroup partGroup = Body[0][0];
    		PartGroup pars2 = partGroup["瞼左"].ToPars();
    		X0Y0_瞼左_瞼 = pars2["瞼"].ToPar();
    		X0Y0_瞼左_睫毛1 = pars2["睫毛1"].ToPar();
    		X0Y0_瞼左_睫毛2 = pars2["睫毛2"].ToPar();
    		pars2 = partGroup["瞼右"].ToPars();
    		X0Y0_瞼右_瞼 = pars2["瞼"].ToPar();
    		X0Y0_瞼右_睫毛1 = pars2["睫毛1"].ToPar();
    		X0Y0_瞼右_睫毛2 = pars2["睫毛2"].ToPar();
    		PartGroup pars3 = Body[0][1];
    		pars2 = pars3["瞼左"].ToPars();
    		X0Y1_瞼左_瞼 = pars2["瞼"].ToPar();
    		X0Y1_瞼左_睫毛1 = pars2["睫毛1"].ToPar();
    		X0Y1_瞼左_睫毛2 = pars2["睫毛2"].ToPar();
    		pars2 = pars3["瞼右"].ToPars();
    		X0Y1_瞼右_瞼 = pars2["瞼"].ToPar();
    		X0Y1_瞼右_睫毛1 = pars2["睫毛1"].ToPar();
    		X0Y1_瞼右_睫毛2 = pars2["睫毛2"].ToPar();
    		PartGroup pars4 = Body[0][2];
    		pars2 = pars4["瞼左"].ToPars();
    		X0Y2_瞼左_瞼 = pars2["瞼"].ToPar();
    		X0Y2_瞼左_睫毛1 = pars2["睫毛1"].ToPar();
    		X0Y2_瞼左_睫毛2 = pars2["睫毛2"].ToPar();
    		pars2 = pars4["瞼右"].ToPars();
    		X0Y2_瞼右_瞼 = pars2["瞼"].ToPar();
    		X0Y2_瞼右_睫毛1 = pars2["睫毛1"].ToPar();
    		X0Y2_瞼右_睫毛2 = pars2["睫毛2"].ToPar();
    		PartGroup pars5 = Body[0][3];
    		pars2 = pars5["瞼左"].ToPars();
    		X0Y3_瞼左_瞼 = pars2["瞼"].ToPar();
    		X0Y3_瞼左_睫毛1 = pars2["睫毛1"].ToPar();
    		X0Y3_瞼左_睫毛2 = pars2["睫毛2"].ToPar();
    		pars2 = pars5["瞼右"].ToPars();
    		X0Y3_瞼右_瞼 = pars2["瞼"].ToPar();
    		X0Y3_瞼右_睫毛1 = pars2["睫毛1"].ToPar();
    		X0Y3_瞼右_睫毛2 = pars2["睫毛2"].ToPar();
    		PartGroup pars6 = Body[0][4];
    		pars2 = pars6["瞼左"].ToPars();
    		X0Y4_瞼左_瞼 = pars2["瞼"].ToPar();
    		X0Y4_瞼左_睫毛1 = pars2["睫毛1"].ToPar();
    		X0Y4_瞼左_睫毛2 = pars2["睫毛2"].ToPar();
    		pars2 = pars6["瞼右"].ToPars();
    		X0Y4_瞼右_瞼 = pars2["瞼"].ToPar();
    		X0Y4_瞼右_睫毛1 = pars2["睫毛1"].ToPar();
    		X0Y4_瞼右_睫毛2 = pars2["睫毛2"].ToPar();
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
    		瞼左_瞼_表示 = e.瞼左_瞼_表示;
    		瞼左_睫毛1_表示 = e.瞼左_睫毛1_表示;
    		瞼左_睫毛2_表示 = e.瞼左_睫毛2_表示;
    		瞼右_瞼_表示 = e.瞼右_瞼_表示;
    		瞼右_睫毛1_表示 = e.瞼右_睫毛1_表示;
    		瞼右_睫毛2_表示 = e.瞼右_睫毛2_表示;
    		外線 = e.外線;
    		瞼左_睫毛1_長さ = e.瞼左_睫毛1_長さ;
    		瞼左_睫毛2_長さ = e.瞼左_睫毛2_長さ;
    		瞼右_睫毛1_長さ = e.瞼右_睫毛1_長さ;
    		瞼右_睫毛2_長さ = e.瞼右_睫毛2_長さ;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_瞼左_瞼CP = new ColorP(X0Y0_瞼左_瞼, 瞼左_瞼CD, DisUnit, abj: true);
    		X0Y0_瞼左_睫毛1CP = new ColorP(X0Y0_瞼左_睫毛1, 瞼左_睫毛1CD, DisUnit, abj: true);
    		X0Y0_瞼左_睫毛2CP = new ColorP(X0Y0_瞼左_睫毛2, 瞼左_睫毛2CD, DisUnit, abj: true);
    		X0Y0_瞼右_瞼CP = new ColorP(X0Y0_瞼右_瞼, 瞼右_瞼CD, DisUnit, abj: true);
    		X0Y0_瞼右_睫毛1CP = new ColorP(X0Y0_瞼右_睫毛1, 瞼右_睫毛1CD, DisUnit, abj: true);
    		X0Y0_瞼右_睫毛2CP = new ColorP(X0Y0_瞼右_睫毛2, 瞼右_睫毛2CD, DisUnit, abj: true);
    		X0Y1_瞼左_瞼CP = new ColorP(X0Y1_瞼左_瞼, 瞼左_瞼CD, DisUnit, abj: true);
    		X0Y1_瞼左_睫毛1CP = new ColorP(X0Y1_瞼左_睫毛1, 瞼左_睫毛1CD, DisUnit, abj: true);
    		X0Y1_瞼左_睫毛2CP = new ColorP(X0Y1_瞼左_睫毛2, 瞼左_睫毛2CD, DisUnit, abj: true);
    		X0Y1_瞼右_瞼CP = new ColorP(X0Y1_瞼右_瞼, 瞼右_瞼CD, DisUnit, abj: true);
    		X0Y1_瞼右_睫毛1CP = new ColorP(X0Y1_瞼右_睫毛1, 瞼右_睫毛1CD, DisUnit, abj: true);
    		X0Y1_瞼右_睫毛2CP = new ColorP(X0Y1_瞼右_睫毛2, 瞼右_睫毛2CD, DisUnit, abj: true);
    		X0Y2_瞼左_瞼CP = new ColorP(X0Y2_瞼左_瞼, 瞼左_瞼CD, DisUnit, abj: true);
    		X0Y2_瞼左_睫毛1CP = new ColorP(X0Y2_瞼左_睫毛1, 瞼左_睫毛1CD, DisUnit, abj: true);
    		X0Y2_瞼左_睫毛2CP = new ColorP(X0Y2_瞼左_睫毛2, 瞼左_睫毛2CD, DisUnit, abj: true);
    		X0Y2_瞼右_瞼CP = new ColorP(X0Y2_瞼右_瞼, 瞼右_瞼CD, DisUnit, abj: true);
    		X0Y2_瞼右_睫毛1CP = new ColorP(X0Y2_瞼右_睫毛1, 瞼右_睫毛1CD, DisUnit, abj: true);
    		X0Y2_瞼右_睫毛2CP = new ColorP(X0Y2_瞼右_睫毛2, 瞼右_睫毛2CD, DisUnit, abj: true);
    		X0Y3_瞼左_瞼CP = new ColorP(X0Y3_瞼左_瞼, 瞼左_瞼CD, DisUnit, abj: true);
    		X0Y3_瞼左_睫毛1CP = new ColorP(X0Y3_瞼左_睫毛1, 瞼左_睫毛1CD, DisUnit, abj: true);
    		X0Y3_瞼左_睫毛2CP = new ColorP(X0Y3_瞼左_睫毛2, 瞼左_睫毛2CD, DisUnit, abj: true);
    		X0Y3_瞼右_瞼CP = new ColorP(X0Y3_瞼右_瞼, 瞼右_瞼CD, DisUnit, abj: true);
    		X0Y3_瞼右_睫毛1CP = new ColorP(X0Y3_瞼右_睫毛1, 瞼右_睫毛1CD, DisUnit, abj: true);
    		X0Y3_瞼右_睫毛2CP = new ColorP(X0Y3_瞼右_睫毛2, 瞼右_睫毛2CD, DisUnit, abj: true);
    		X0Y4_瞼左_瞼CP = new ColorP(X0Y4_瞼左_瞼, 瞼左_瞼CD, DisUnit, abj: true);
    		X0Y4_瞼左_睫毛1CP = new ColorP(X0Y4_瞼左_睫毛1, 瞼左_睫毛1CD, DisUnit, abj: true);
    		X0Y4_瞼左_睫毛2CP = new ColorP(X0Y4_瞼左_睫毛2, 瞼左_睫毛2CD, DisUnit, abj: true);
    		X0Y4_瞼右_瞼CP = new ColorP(X0Y4_瞼右_瞼, 瞼右_瞼CD, DisUnit, abj: true);
    		X0Y4_瞼右_睫毛1CP = new ColorP(X0Y4_瞼右_睫毛1, 瞼右_睫毛1CD, DisUnit, abj: true);
    		X0Y4_瞼右_睫毛2CP = new ColorP(X0Y4_瞼右_睫毛2, 瞼右_睫毛2CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	private void 睫毛長さ(ShapePart p, double d)
    	{
    		double num = 0.0;
    		double num2 = 2.0;
    		Vector2D value = p.BasePointBase + (p.OP[0].ps[0] - p.BasePointBase) * (num + (num2 - num) * d);
    		p.OP[2].ps[2] = value;
    		p.OP[0].ps[0] = value;
    	}

    	public override void 色更新()
    	{
    		switch (Body.IndexY)
    		{
    		case 0:
    			X0Y0_瞼左_瞼CP.Update();
    			X0Y0_瞼左_睫毛1CP.Update();
    			X0Y0_瞼左_睫毛2CP.Update();
    			X0Y0_瞼右_瞼CP.Update();
    			X0Y0_瞼右_睫毛1CP.Update();
    			X0Y0_瞼右_睫毛2CP.Update();
    			break;
    		case 1:
    			X0Y1_瞼左_瞼CP.Update();
    			X0Y1_瞼左_睫毛1CP.Update();
    			X0Y1_瞼左_睫毛2CP.Update();
    			X0Y1_瞼右_瞼CP.Update();
    			X0Y1_瞼右_睫毛1CP.Update();
    			X0Y1_瞼右_睫毛2CP.Update();
    			break;
    		case 2:
    			X0Y2_瞼左_瞼CP.Update();
    			X0Y2_瞼左_睫毛1CP.Update();
    			X0Y2_瞼左_睫毛2CP.Update();
    			X0Y2_瞼右_瞼CP.Update();
    			X0Y2_瞼右_睫毛1CP.Update();
    			X0Y2_瞼右_睫毛2CP.Update();
    			break;
    		case 3:
    			X0Y3_瞼左_瞼CP.Update();
    			X0Y3_瞼左_睫毛1CP.Update();
    			X0Y3_瞼左_睫毛2CP.Update();
    			X0Y3_瞼右_瞼CP.Update();
    			X0Y3_瞼右_睫毛1CP.Update();
    			X0Y3_瞼右_睫毛2CP.Update();
    			break;
    		default:
    			X0Y4_瞼左_瞼CP.Update();
    			X0Y4_瞼左_睫毛1CP.Update();
    			X0Y4_瞼左_睫毛2CP.Update();
    			X0Y4_瞼右_瞼CP.Update();
    			X0Y4_瞼右_睫毛1CP.Update();
    			X0Y4_瞼右_睫毛2CP.Update();
    			break;
    		}
    	}

    	public override void 色更新(Vector2D[] mm)
    	{
    		switch (Body.IndexY)
    		{
    		case 0:
    			X0Y0_瞼左_瞼CP.Update(mm);
    			X0Y0_瞼左_睫毛1CP.Update();
    			X0Y0_瞼左_睫毛2CP.Update();
    			X0Y0_瞼右_瞼CP.Update(mm);
    			X0Y0_瞼右_睫毛1CP.Update();
    			X0Y0_瞼右_睫毛2CP.Update();
    			break;
    		case 1:
    			X0Y1_瞼左_瞼CP.Update(mm);
    			X0Y1_瞼左_睫毛1CP.Update();
    			X0Y1_瞼左_睫毛2CP.Update();
    			X0Y1_瞼右_瞼CP.Update(mm);
    			X0Y1_瞼右_睫毛1CP.Update();
    			X0Y1_瞼右_睫毛2CP.Update();
    			break;
    		case 2:
    			X0Y2_瞼左_瞼CP.Update(mm);
    			X0Y2_瞼左_睫毛1CP.Update();
    			X0Y2_瞼左_睫毛2CP.Update();
    			X0Y2_瞼右_瞼CP.Update(mm);
    			X0Y2_瞼右_睫毛1CP.Update();
    			X0Y2_瞼右_睫毛2CP.Update();
    			break;
    		case 3:
    			X0Y3_瞼左_瞼CP.Update(mm);
    			X0Y3_瞼左_睫毛1CP.Update();
    			X0Y3_瞼左_睫毛2CP.Update();
    			X0Y3_瞼右_瞼CP.Update(mm);
    			X0Y3_瞼右_睫毛1CP.Update();
    			X0Y3_瞼右_睫毛2CP.Update();
    			break;
    		default:
    			X0Y4_瞼左_瞼CP.Update(mm);
    			X0Y4_瞼左_睫毛1CP.Update();
    			X0Y4_瞼左_睫毛2CP.Update();
    			X0Y4_瞼右_瞼CP.Update(mm);
    			X0Y4_瞼右_睫毛1CP.Update();
    			X0Y4_瞼右_睫毛2CP.Update();
    			break;
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		瞼左_瞼CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.人肌O);
    		瞼左_睫毛1CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
    		瞼左_睫毛2CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
    		瞼右_瞼CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.人肌O);
    		瞼右_睫毛1CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
    		瞼右_睫毛2CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
    	}
    }
}
