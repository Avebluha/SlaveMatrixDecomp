using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 耳_獣 : 耳
    {
    	public ShapePart X0Y0_耳;

    	public ShapePart X0Y0_耳線1;

    	public ShapePart X0Y0_耳線2;

    	public ShapePart X0Y1_耳;

    	public ShapePart X0Y1_耳線1;

    	public ShapePart X0Y1_耳線2;

    	public ShapePart X0Y2_耳;

    	public ShapePart X0Y2_耳線1;

    	public ShapePart X0Y2_耳線2;

    	public ShapePart X1Y0_耳;

    	public ShapePart X1Y0_耳線1;

    	public ShapePart X1Y0_耳線2;

    	public ShapePart X1Y1_耳;

    	public ShapePart X1Y1_耳線1;

    	public ShapePart X1Y1_耳線2;

    	public ShapePart X1Y2_耳;

    	public ShapePart X1Y2_耳線1;

    	public ShapePart X1Y2_耳線2;

    	public ColorD 耳CD;

    	public ColorD 耳線1CD;

    	public ColorD 耳線2CD;

    	public ColorP X0Y0_耳CP;

    	public ColorP X0Y0_耳線1CP;

    	public ColorP X0Y0_耳線2CP;

    	public ColorP X0Y1_耳CP;

    	public ColorP X0Y1_耳線1CP;

    	public ColorP X0Y1_耳線2CP;

    	public ColorP X0Y2_耳CP;

    	public ColorP X0Y2_耳線1CP;

    	public ColorP X0Y2_耳線2CP;

    	public ColorP X1Y0_耳CP;

    	public ColorP X1Y0_耳線1CP;

    	public ColorP X1Y0_耳線2CP;

    	public ColorP X1Y1_耳CP;

    	public ColorP X1Y1_耳線1CP;

    	public ColorP X1Y1_耳線2CP;

    	public ColorP X1Y2_耳CP;

    	public ColorP X1Y2_耳線1CP;

    	public ColorP X1Y2_耳線2CP;

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

    	public bool 耳_表示
    	{
    		get
    		{
    			return X0Y0_耳.Dra;
    		}
    		set
    		{
    			X0Y0_耳.Dra = value;
    			X0Y1_耳.Dra = value;
    			X0Y2_耳.Dra = value;
    			X1Y0_耳.Dra = value;
    			X1Y1_耳.Dra = value;
    			X1Y2_耳.Dra = value;
    			X0Y0_耳.Hit = value;
    			X0Y1_耳.Hit = value;
    			X0Y2_耳.Hit = value;
    			X1Y0_耳.Hit = value;
    			X1Y1_耳.Hit = value;
    			X1Y2_耳.Hit = value;
    		}
    	}

    	public bool 耳線1_表示
    	{
    		get
    		{
    			return X0Y0_耳線1.Dra;
    		}
    		set
    		{
    			X0Y0_耳線1.Dra = value;
    			X0Y1_耳線1.Dra = value;
    			X0Y2_耳線1.Dra = value;
    			X1Y0_耳線1.Dra = value;
    			X1Y1_耳線1.Dra = value;
    			X1Y2_耳線1.Dra = value;
    			X0Y0_耳線1.Hit = value;
    			X0Y1_耳線1.Hit = value;
    			X0Y2_耳線1.Hit = value;
    			X1Y0_耳線1.Hit = value;
    			X1Y1_耳線1.Hit = value;
    			X1Y2_耳線1.Hit = value;
    		}
    	}

    	public bool 耳線2_表示
    	{
    		get
    		{
    			return X0Y0_耳線2.Dra;
    		}
    		set
    		{
    			X0Y0_耳線2.Dra = value;
    			X0Y1_耳線2.Dra = value;
    			X0Y2_耳線2.Dra = value;
    			X1Y0_耳線2.Dra = value;
    			X1Y1_耳線2.Dra = value;
    			X1Y2_耳線2.Dra = value;
    			X0Y0_耳線2.Hit = value;
    			X0Y1_耳線2.Hit = value;
    			X0Y2_耳線2.Hit = value;
    			X1Y0_耳線2.Hit = value;
    			X1Y1_耳線2.Hit = value;
    			X1Y2_耳線2.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 耳_表示;
    		}
    		set
    		{
    			耳_表示 = value;
    			耳線1_表示 = value;
    			耳線2_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 耳CD.不透明度;
    		}
    		set
    		{
    			耳CD.不透明度 = value;
    			耳線1CD.不透明度 = value;
    			耳線2CD.不透明度 = value;
    		}
    	}

    	public 耳_獣(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 耳_獣D e)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid();
    		Body.Tag = "獣";
    		Body.Add(new MorphVariant(Sta.肢左["耳"][10]));
    		Body.Add(new MorphVariant(Sta.肢左["耳"][11]));
    		PartGroup partGroup = Body[0][0];
    		X0Y0_耳 = partGroup["耳"].ToPar();
    		X0Y0_耳線1 = partGroup["耳線1"].ToPar();
    		X0Y0_耳線2 = partGroup["耳線2"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_耳 = partGroup["耳"].ToPar();
    		X0Y1_耳線1 = partGroup["耳線1"].ToPar();
    		X0Y1_耳線2 = partGroup["耳線2"].ToPar();
    		partGroup = Body[0][2];
    		X0Y2_耳 = partGroup["耳"].ToPar();
    		X0Y2_耳線1 = partGroup["耳線1"].ToPar();
    		X0Y2_耳線2 = partGroup["耳線2"].ToPar();
    		partGroup = Body[1][0];
    		X1Y0_耳 = partGroup["耳"].ToPar();
    		X1Y0_耳線1 = partGroup["耳線1"].ToPar();
    		X1Y0_耳線2 = partGroup["耳線2"].ToPar();
    		partGroup = Body[1][1];
    		X1Y1_耳 = partGroup["耳"].ToPar();
    		X1Y1_耳線1 = partGroup["耳線1"].ToPar();
    		X1Y1_耳線2 = partGroup["耳線2"].ToPar();
    		partGroup = Body[1][2];
    		X1Y2_耳 = partGroup["耳"].ToPar();
    		X1Y2_耳線1 = partGroup["耳線1"].ToPar();
    		X1Y2_耳線2 = partGroup["耳線2"].ToPar();
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
    		耳_表示 = e.耳_表示;
    		耳線1_表示 = e.耳線1_表示;
    		耳線2_表示 = e.耳線2_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_耳CP = new ColorP(X0Y0_耳, 耳CD, DisUnit, abj: true);
    		X0Y0_耳線1CP = new ColorP(X0Y0_耳線1, 耳線1CD, DisUnit, abj: true);
    		X0Y0_耳線2CP = new ColorP(X0Y0_耳線2, 耳線2CD, DisUnit, abj: true);
    		X0Y1_耳CP = new ColorP(X0Y1_耳, 耳CD, DisUnit, abj: true);
    		X0Y1_耳線1CP = new ColorP(X0Y1_耳線1, 耳線1CD, DisUnit, abj: true);
    		X0Y1_耳線2CP = new ColorP(X0Y1_耳線2, 耳線2CD, DisUnit, abj: true);
    		X0Y2_耳CP = new ColorP(X0Y2_耳, 耳CD, DisUnit, abj: true);
    		X0Y2_耳線1CP = new ColorP(X0Y2_耳線1, 耳線1CD, DisUnit, abj: true);
    		X0Y2_耳線2CP = new ColorP(X0Y2_耳線2, 耳線2CD, DisUnit, abj: true);
    		X1Y0_耳CP = new ColorP(X1Y0_耳, 耳CD, DisUnit, abj: true);
    		X1Y0_耳線1CP = new ColorP(X1Y0_耳線1, 耳線1CD, DisUnit, abj: true);
    		X1Y0_耳線2CP = new ColorP(X1Y0_耳線2, 耳線2CD, DisUnit, abj: true);
    		X1Y1_耳CP = new ColorP(X1Y1_耳, 耳CD, DisUnit, abj: true);
    		X1Y1_耳線1CP = new ColorP(X1Y1_耳線1, 耳線1CD, DisUnit, abj: true);
    		X1Y1_耳線2CP = new ColorP(X1Y1_耳線2, 耳線2CD, DisUnit, abj: true);
    		X1Y2_耳CP = new ColorP(X1Y2_耳, 耳CD, DisUnit, abj: true);
    		X1Y2_耳線1CP = new ColorP(X1Y2_耳線1, 耳線1CD, DisUnit, abj: true);
    		X1Y2_耳線2CP = new ColorP(X1Y2_耳線2, 耳線2CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_耳.AngleBase = num * -342.0;
    		X0Y1_耳.AngleBase = num * -350.0;
    		X0Y2_耳.AngleBase = num * -357.0;
    		X1Y0_耳.AngleBase = num * -342.0;
    		X1Y1_耳.AngleBase = num * -350.0;
    		X1Y2_耳.AngleBase = num * -357.0;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexX == 0)
    		{
    			switch (Body.IndexY)
    			{
    			case 0:
    				X0Y0_耳CP.Update();
    				X0Y0_耳線1CP.Update();
    				X0Y0_耳線2CP.Update();
    				break;
    			case 1:
    				X0Y1_耳CP.Update();
    				X0Y1_耳線1CP.Update();
    				X0Y1_耳線2CP.Update();
    				break;
    			default:
    				X0Y2_耳CP.Update();
    				X0Y2_耳線1CP.Update();
    				X0Y2_耳線2CP.Update();
    				break;
    			}
    		}
    		else
    		{
    			switch (Body.IndexY)
    			{
    			case 0:
    				X1Y0_耳CP.Update();
    				X1Y0_耳線1CP.Update();
    				X1Y0_耳線2CP.Update();
    				break;
    			case 1:
    				X1Y1_耳CP.Update();
    				X1Y1_耳線1CP.Update();
    				X1Y1_耳線2CP.Update();
    				break;
    			default:
    				X1Y2_耳CP.Update();
    				X1Y2_耳線1CP.Update();
    				X1Y2_耳線2CP.Update();
    				break;
    			}
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		耳CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		耳線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
    		耳線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
    	}
    }
}
