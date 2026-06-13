using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 呼気 : Element
    {
    	public ShapePart X0Y0_呼気左1_呼気1;

    	public ShapePart X0Y0_呼気左1_呼気2;

    	public ShapePart X0Y0_呼気左2_呼気1;

    	public ShapePart X0Y0_呼気左2_呼気2;

    	public ShapePart X0Y0_呼気左3_呼気1;

    	public ShapePart X0Y0_呼気左3_呼気2;

    	public ShapePart X0Y0_呼気右1_呼気1;

    	public ShapePart X0Y0_呼気右1_呼気2;

    	public ShapePart X0Y0_呼気右2_呼気1;

    	public ShapePart X0Y0_呼気右2_呼気2;

    	public ShapePart X0Y0_呼気右3_呼気1;

    	public ShapePart X0Y0_呼気右3_呼気2;

    	public ShapePart X0Y1_呼気左1_呼気1;

    	public ShapePart X0Y1_呼気左1_呼気2;

    	public ShapePart X0Y1_呼気左2_呼気1;

    	public ShapePart X0Y1_呼気左2_呼気2;

    	public ShapePart X0Y1_呼気左3_呼気1;

    	public ShapePart X0Y1_呼気左3_呼気2;

    	public ShapePart X0Y1_呼気右1_呼気1;

    	public ShapePart X0Y1_呼気右1_呼気2;

    	public ShapePart X0Y1_呼気右2_呼気1;

    	public ShapePart X0Y1_呼気右2_呼気2;

    	public ShapePart X0Y1_呼気右3_呼気1;

    	public ShapePart X0Y1_呼気右3_呼気2;

    	public ColorD 呼気左1_呼気1CD;

    	public ColorD 呼気左1_呼気2CD;

    	public ColorD 呼気左2_呼気1CD;

    	public ColorD 呼気左2_呼気2CD;

    	public ColorD 呼気左3_呼気1CD;

    	public ColorD 呼気左3_呼気2CD;

    	public ColorD 呼気右1_呼気1CD;

    	public ColorD 呼気右1_呼気2CD;

    	public ColorD 呼気右2_呼気1CD;

    	public ColorD 呼気右2_呼気2CD;

    	public ColorD 呼気右3_呼気1CD;

    	public ColorD 呼気右3_呼気2CD;

    	public ColorP X0Y0_呼気左1_呼気1CP;

    	public ColorP X0Y0_呼気左1_呼気2CP;

    	public ColorP X0Y0_呼気左2_呼気1CP;

    	public ColorP X0Y0_呼気左2_呼気2CP;

    	public ColorP X0Y0_呼気左3_呼気1CP;

    	public ColorP X0Y0_呼気左3_呼気2CP;

    	public ColorP X0Y0_呼気右1_呼気1CP;

    	public ColorP X0Y0_呼気右1_呼気2CP;

    	public ColorP X0Y0_呼気右2_呼気1CP;

    	public ColorP X0Y0_呼気右2_呼気2CP;

    	public ColorP X0Y0_呼気右3_呼気1CP;

    	public ColorP X0Y0_呼気右3_呼気2CP;

    	public ColorP X0Y1_呼気左1_呼気1CP;

    	public ColorP X0Y1_呼気左1_呼気2CP;

    	public ColorP X0Y1_呼気左2_呼気1CP;

    	public ColorP X0Y1_呼気左2_呼気2CP;

    	public ColorP X0Y1_呼気左3_呼気1CP;

    	public ColorP X0Y1_呼気左3_呼気2CP;

    	public ColorP X0Y1_呼気右1_呼気1CP;

    	public ColorP X0Y1_呼気右1_呼気2CP;

    	public ColorP X0Y1_呼気右2_呼気1CP;

    	public ColorP X0Y1_呼気右2_呼気2CP;

    	public ColorP X0Y1_呼気右3_呼気1CP;

    	public ColorP X0Y1_呼気右3_呼気2CP;

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

    	public bool 呼気左1_呼気1_表示
    	{
    		get
    		{
    			return X0Y0_呼気左1_呼気1.Dra;
    		}
    		set
    		{
    			X0Y0_呼気左1_呼気1.Dra = value;
    			X0Y1_呼気左1_呼気1.Dra = value;
    			X0Y0_呼気左1_呼気1.Hit = value;
    			X0Y1_呼気左1_呼気1.Hit = value;
    		}
    	}

    	public bool 呼気左1_呼気2_表示
    	{
    		get
    		{
    			return X0Y0_呼気左1_呼気2.Dra;
    		}
    		set
    		{
    			X0Y0_呼気左1_呼気2.Dra = value;
    			X0Y1_呼気左1_呼気2.Dra = value;
    			X0Y0_呼気左1_呼気2.Hit = value;
    			X0Y1_呼気左1_呼気2.Hit = value;
    		}
    	}

    	public bool 呼気左2_呼気1_表示
    	{
    		get
    		{
    			return X0Y0_呼気左2_呼気1.Dra;
    		}
    		set
    		{
    			X0Y0_呼気左2_呼気1.Dra = value;
    			X0Y1_呼気左2_呼気1.Dra = value;
    			X0Y0_呼気左2_呼気1.Hit = value;
    			X0Y1_呼気左2_呼気1.Hit = value;
    		}
    	}

    	public bool 呼気左2_呼気2_表示
    	{
    		get
    		{
    			return X0Y0_呼気左2_呼気2.Dra;
    		}
    		set
    		{
    			X0Y0_呼気左2_呼気2.Dra = value;
    			X0Y1_呼気左2_呼気2.Dra = value;
    			X0Y0_呼気左2_呼気2.Hit = value;
    			X0Y1_呼気左2_呼気2.Hit = value;
    		}
    	}

    	public bool 呼気左3_呼気1_表示
    	{
    		get
    		{
    			return X0Y0_呼気左3_呼気1.Dra;
    		}
    		set
    		{
    			X0Y0_呼気左3_呼気1.Dra = value;
    			X0Y1_呼気左3_呼気1.Dra = value;
    			X0Y0_呼気左3_呼気1.Hit = value;
    			X0Y1_呼気左3_呼気1.Hit = value;
    		}
    	}

    	public bool 呼気左3_呼気2_表示
    	{
    		get
    		{
    			return X0Y0_呼気左3_呼気2.Dra;
    		}
    		set
    		{
    			X0Y0_呼気左3_呼気2.Dra = value;
    			X0Y1_呼気左3_呼気2.Dra = value;
    			X0Y0_呼気左3_呼気2.Hit = value;
    			X0Y1_呼気左3_呼気2.Hit = value;
    		}
    	}

    	public bool 呼気右1_呼気1_表示
    	{
    		get
    		{
    			return X0Y0_呼気右1_呼気1.Dra;
    		}
    		set
    		{
    			X0Y0_呼気右1_呼気1.Dra = value;
    			X0Y1_呼気右1_呼気1.Dra = value;
    			X0Y0_呼気右1_呼気1.Hit = value;
    			X0Y1_呼気右1_呼気1.Hit = value;
    		}
    	}

    	public bool 呼気右1_呼気2_表示
    	{
    		get
    		{
    			return X0Y0_呼気右1_呼気2.Dra;
    		}
    		set
    		{
    			X0Y0_呼気右1_呼気2.Dra = value;
    			X0Y1_呼気右1_呼気2.Dra = value;
    			X0Y0_呼気右1_呼気2.Hit = value;
    			X0Y1_呼気右1_呼気2.Hit = value;
    		}
    	}

    	public bool 呼気右2_呼気1_表示
    	{
    		get
    		{
    			return X0Y0_呼気右2_呼気1.Dra;
    		}
    		set
    		{
    			X0Y0_呼気右2_呼気1.Dra = value;
    			X0Y1_呼気右2_呼気1.Dra = value;
    			X0Y0_呼気右2_呼気1.Hit = value;
    			X0Y1_呼気右2_呼気1.Hit = value;
    		}
    	}

    	public bool 呼気右2_呼気2_表示
    	{
    		get
    		{
    			return X0Y0_呼気右2_呼気2.Dra;
    		}
    		set
    		{
    			X0Y0_呼気右2_呼気2.Dra = value;
    			X0Y1_呼気右2_呼気2.Dra = value;
    			X0Y0_呼気右2_呼気2.Hit = value;
    			X0Y1_呼気右2_呼気2.Hit = value;
    		}
    	}

    	public bool 呼気右3_呼気1_表示
    	{
    		get
    		{
    			return X0Y0_呼気右3_呼気1.Dra;
    		}
    		set
    		{
    			X0Y0_呼気右3_呼気1.Dra = value;
    			X0Y1_呼気右3_呼気1.Dra = value;
    			X0Y0_呼気右3_呼気1.Hit = value;
    			X0Y1_呼気右3_呼気1.Hit = value;
    		}
    	}

    	public bool 呼気右3_呼気2_表示
    	{
    		get
    		{
    			return X0Y0_呼気右3_呼気2.Dra;
    		}
    		set
    		{
    			X0Y0_呼気右3_呼気2.Dra = value;
    			X0Y1_呼気右3_呼気2.Dra = value;
    			X0Y0_呼気右3_呼気2.Hit = value;
    			X0Y1_呼気右3_呼気2.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 呼気左1_呼気1_表示;
    		}
    		set
    		{
    			呼気左1_呼気1_表示 = value;
    			呼気左1_呼気2_表示 = value;
    			呼気左2_呼気1_表示 = value;
    			呼気左2_呼気2_表示 = value;
    			呼気左3_呼気1_表示 = value;
    			呼気左3_呼気2_表示 = value;
    			呼気右1_呼気1_表示 = value;
    			呼気右1_呼気2_表示 = value;
    			呼気右2_呼気1_表示 = value;
    			呼気右2_呼気2_表示 = value;
    			呼気右3_呼気1_表示 = value;
    			呼気右3_呼気2_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 呼気左1_呼気1CD.不透明度;
    		}
    		set
    		{
    			呼気左1_呼気1CD.不透明度 = value;
    			呼気左1_呼気2CD.不透明度 = value;
    			呼気左2_呼気1CD.不透明度 = value;
    			呼気左2_呼気2CD.不透明度 = value;
    			呼気左3_呼気1CD.不透明度 = value;
    			呼気左3_呼気2CD.不透明度 = value;
    			呼気右1_呼気1CD.不透明度 = value;
    			呼気右1_呼気2CD.不透明度 = value;
    			呼気右2_呼気1CD.不透明度 = value;
    			呼気右2_呼気2CD.不透明度 = value;
    			呼気右3_呼気1CD.不透明度 = value;
    			呼気右3_呼気2CD.不透明度 = value;
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

    	public 呼気(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 呼気D e)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid(GlobalState.胴体["呼気"]);
    		PartGroup partGroup = Body[0][0];
    		PartGroup pars2 = partGroup["呼気左1"].ToPars();
    		X0Y0_呼気左1_呼気1 = pars2["呼気1"].ToPar();
    		X0Y0_呼気左1_呼気2 = pars2["呼気2"].ToPar();
    		pars2 = partGroup["呼気左2"].ToPars();
    		X0Y0_呼気左2_呼気1 = pars2["呼気1"].ToPar();
    		X0Y0_呼気左2_呼気2 = pars2["呼気2"].ToPar();
    		pars2 = partGroup["呼気左3"].ToPars();
    		X0Y0_呼気左3_呼気1 = pars2["呼気1"].ToPar();
    		X0Y0_呼気左3_呼気2 = pars2["呼気2"].ToPar();
    		pars2 = partGroup["呼気右1"].ToPars();
    		X0Y0_呼気右1_呼気1 = pars2["呼気1"].ToPar();
    		X0Y0_呼気右1_呼気2 = pars2["呼気2"].ToPar();
    		pars2 = partGroup["呼気右2"].ToPars();
    		X0Y0_呼気右2_呼気1 = pars2["呼気1"].ToPar();
    		X0Y0_呼気右2_呼気2 = pars2["呼気2"].ToPar();
    		pars2 = partGroup["呼気右3"].ToPars();
    		X0Y0_呼気右3_呼気1 = pars2["呼気1"].ToPar();
    		X0Y0_呼気右3_呼気2 = pars2["呼気2"].ToPar();
    		PartGroup pars3 = Body[0][1];
    		pars2 = pars3["呼気左1"].ToPars();
    		X0Y1_呼気左1_呼気1 = pars2["呼気1"].ToPar();
    		X0Y1_呼気左1_呼気2 = pars2["呼気2"].ToPar();
    		pars2 = pars3["呼気左2"].ToPars();
    		X0Y1_呼気左2_呼気1 = pars2["呼気1"].ToPar();
    		X0Y1_呼気左2_呼気2 = pars2["呼気2"].ToPar();
    		pars2 = pars3["呼気左3"].ToPars();
    		X0Y1_呼気左3_呼気1 = pars2["呼気1"].ToPar();
    		X0Y1_呼気左3_呼気2 = pars2["呼気2"].ToPar();
    		pars2 = pars3["呼気右1"].ToPars();
    		X0Y1_呼気右1_呼気1 = pars2["呼気1"].ToPar();
    		X0Y1_呼気右1_呼気2 = pars2["呼気2"].ToPar();
    		pars2 = pars3["呼気右2"].ToPars();
    		X0Y1_呼気右2_呼気1 = pars2["呼気1"].ToPar();
    		X0Y1_呼気右2_呼気2 = pars2["呼気2"].ToPar();
    		pars2 = pars3["呼気右3"].ToPars();
    		X0Y1_呼気右3_呼気1 = pars2["呼気1"].ToPar();
    		X0Y1_呼気右3_呼気2 = pars2["呼気2"].ToPar();
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
    		呼気左1_呼気1_表示 = e.呼気左1_呼気1_表示;
    		呼気左1_呼気2_表示 = e.呼気左1_呼気2_表示;
    		呼気左2_呼気1_表示 = e.呼気左2_呼気1_表示;
    		呼気左2_呼気2_表示 = e.呼気左2_呼気2_表示;
    		呼気左3_呼気1_表示 = e.呼気左3_呼気1_表示;
    		呼気左3_呼気2_表示 = e.呼気左3_呼気2_表示;
    		呼気右1_呼気1_表示 = e.呼気右1_呼気1_表示;
    		呼気右1_呼気2_表示 = e.呼気右1_呼気2_表示;
    		呼気右2_呼気1_表示 = e.呼気右2_呼気1_表示;
    		呼気右2_呼気2_表示 = e.呼気右2_呼気2_表示;
    		呼気右3_呼気1_表示 = e.呼気右3_呼気1_表示;
    		呼気右3_呼気2_表示 = e.呼気右3_呼気2_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_呼気左1_呼気1CP = new ColorP(X0Y0_呼気左1_呼気1, 呼気左1_呼気1CD, DisUnit, abj: true);
    		X0Y0_呼気左1_呼気2CP = new ColorP(X0Y0_呼気左1_呼気2, 呼気左1_呼気2CD, DisUnit, abj: true);
    		X0Y0_呼気左2_呼気1CP = new ColorP(X0Y0_呼気左2_呼気1, 呼気左2_呼気1CD, DisUnit, abj: true);
    		X0Y0_呼気左2_呼気2CP = new ColorP(X0Y0_呼気左2_呼気2, 呼気左2_呼気2CD, DisUnit, abj: true);
    		X0Y0_呼気左3_呼気1CP = new ColorP(X0Y0_呼気左3_呼気1, 呼気左3_呼気1CD, DisUnit, abj: true);
    		X0Y0_呼気左3_呼気2CP = new ColorP(X0Y0_呼気左3_呼気2, 呼気左3_呼気2CD, DisUnit, abj: true);
    		X0Y0_呼気右1_呼気1CP = new ColorP(X0Y0_呼気右1_呼気1, 呼気右1_呼気1CD, DisUnit, abj: true);
    		X0Y0_呼気右1_呼気2CP = new ColorP(X0Y0_呼気右1_呼気2, 呼気右1_呼気2CD, DisUnit, abj: true);
    		X0Y0_呼気右2_呼気1CP = new ColorP(X0Y0_呼気右2_呼気1, 呼気右2_呼気1CD, DisUnit, abj: true);
    		X0Y0_呼気右2_呼気2CP = new ColorP(X0Y0_呼気右2_呼気2, 呼気右2_呼気2CD, DisUnit, abj: true);
    		X0Y0_呼気右3_呼気1CP = new ColorP(X0Y0_呼気右3_呼気1, 呼気右3_呼気1CD, DisUnit, abj: true);
    		X0Y0_呼気右3_呼気2CP = new ColorP(X0Y0_呼気右3_呼気2, 呼気右3_呼気2CD, DisUnit, abj: true);
    		X0Y1_呼気左1_呼気1CP = new ColorP(X0Y1_呼気左1_呼気1, 呼気左1_呼気1CD, DisUnit, abj: true);
    		X0Y1_呼気左1_呼気2CP = new ColorP(X0Y1_呼気左1_呼気2, 呼気左1_呼気2CD, DisUnit, abj: true);
    		X0Y1_呼気左2_呼気1CP = new ColorP(X0Y1_呼気左2_呼気1, 呼気左2_呼気1CD, DisUnit, abj: true);
    		X0Y1_呼気左2_呼気2CP = new ColorP(X0Y1_呼気左2_呼気2, 呼気左2_呼気2CD, DisUnit, abj: true);
    		X0Y1_呼気左3_呼気1CP = new ColorP(X0Y1_呼気左3_呼気1, 呼気左3_呼気1CD, DisUnit, abj: true);
    		X0Y1_呼気左3_呼気2CP = new ColorP(X0Y1_呼気左3_呼気2, 呼気左3_呼気2CD, DisUnit, abj: true);
    		X0Y1_呼気右1_呼気1CP = new ColorP(X0Y1_呼気右1_呼気1, 呼気右1_呼気1CD, DisUnit, abj: true);
    		X0Y1_呼気右1_呼気2CP = new ColorP(X0Y1_呼気右1_呼気2, 呼気右1_呼気2CD, DisUnit, abj: true);
    		X0Y1_呼気右2_呼気1CP = new ColorP(X0Y1_呼気右2_呼気1, 呼気右2_呼気1CD, DisUnit, abj: true);
    		X0Y1_呼気右2_呼気2CP = new ColorP(X0Y1_呼気右2_呼気2, 呼気右2_呼気2CD, DisUnit, abj: true);
    		X0Y1_呼気右3_呼気1CP = new ColorP(X0Y1_呼気右3_呼気1, 呼気右3_呼気1CD, DisUnit, abj: true);
    		X0Y1_呼気右3_呼気2CP = new ColorP(X0Y1_呼気右3_呼気2, 呼気右3_呼気2CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexY == 0)
    		{
    			X0Y0_呼気左1_呼気1CP.Update();
    			X0Y0_呼気左1_呼気2CP.Update();
    			X0Y0_呼気左2_呼気1CP.Update();
    			X0Y0_呼気左2_呼気2CP.Update();
    			X0Y0_呼気左3_呼気1CP.Update();
    			X0Y0_呼気左3_呼気2CP.Update();
    			X0Y0_呼気右1_呼気1CP.Update();
    			X0Y0_呼気右1_呼気2CP.Update();
    			X0Y0_呼気右2_呼気1CP.Update();
    			X0Y0_呼気右2_呼気2CP.Update();
    			X0Y0_呼気右3_呼気1CP.Update();
    			X0Y0_呼気右3_呼気2CP.Update();
    		}
    		else
    		{
    			X0Y1_呼気左1_呼気1CP.Update();
    			X0Y1_呼気左1_呼気2CP.Update();
    			X0Y1_呼気左2_呼気1CP.Update();
    			X0Y1_呼気左2_呼気2CP.Update();
    			X0Y1_呼気左3_呼気1CP.Update();
    			X0Y1_呼気左3_呼気2CP.Update();
    			X0Y1_呼気右1_呼気1CP.Update();
    			X0Y1_呼気右1_呼気2CP.Update();
    			X0Y1_呼気右2_呼気1CP.Update();
    			X0Y1_呼気右2_呼気2CP.Update();
    			X0Y1_呼気右3_呼気1CP.Update();
    			X0Y1_呼気右3_呼気2CP.Update();
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		呼気左1_呼気1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.呼気);
    		呼気左1_呼気2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.呼気);
    		呼気左2_呼気1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.呼気);
    		呼気左2_呼気2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.呼気);
    		呼気左3_呼気1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.呼気);
    		呼気左3_呼気2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.呼気);
    		呼気右1_呼気1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.呼気);
    		呼気右1_呼気2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.呼気);
    		呼気右2_呼気1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.呼気);
    		呼気右2_呼気2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.呼気);
    		呼気右3_呼気1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.呼気);
    		呼気右3_呼気2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.呼気);
    	}
    }
}
