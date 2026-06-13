using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 耳_羽 : 耳
    {
    	public ShapePart X0Y0_羽2;

    	public ShapePart X0Y0_羽1;

    	public ShapePart X0Y0_耳;

    	public ShapePart X0Y0_耳線1;

    	public ShapePart X0Y0_耳線2;

    	public ShapePart X0Y1_羽2;

    	public ShapePart X0Y1_羽1;

    	public ShapePart X0Y1_耳;

    	public ShapePart X0Y1_耳線1;

    	public ShapePart X0Y1_耳線2;

    	public ShapePart X0Y2_羽2;

    	public ShapePart X0Y2_羽1;

    	public ShapePart X0Y2_耳;

    	public ShapePart X0Y2_耳線1;

    	public ShapePart X0Y2_耳線2;

    	public ShapePart X1Y0_羽2;

    	public ShapePart X1Y0_羽1;

    	public ShapePart X1Y0_耳;

    	public ShapePart X1Y0_耳線1;

    	public ShapePart X1Y0_耳線2;

    	public ShapePart X1Y1_羽2;

    	public ShapePart X1Y1_羽1;

    	public ShapePart X1Y1_耳;

    	public ShapePart X1Y1_耳線1;

    	public ShapePart X1Y1_耳線2;

    	public ShapePart X1Y2_羽2;

    	public ShapePart X1Y2_羽1;

    	public ShapePart X1Y2_耳;

    	public ShapePart X1Y2_耳線1;

    	public ShapePart X1Y2_耳線2;

    	public ColorD 羽2CD;

    	public ColorD 羽1CD;

    	public ColorD 耳CD;

    	public ColorD 耳線1CD;

    	public ColorD 耳線2CD;

    	public ColorP X0Y0_羽2CP;

    	public ColorP X0Y0_羽1CP;

    	public ColorP X0Y0_耳CP;

    	public ColorP X0Y0_耳線1CP;

    	public ColorP X0Y0_耳線2CP;

    	public ColorP X0Y1_羽2CP;

    	public ColorP X0Y1_羽1CP;

    	public ColorP X0Y1_耳CP;

    	public ColorP X0Y1_耳線1CP;

    	public ColorP X0Y1_耳線2CP;

    	public ColorP X0Y2_羽2CP;

    	public ColorP X0Y2_羽1CP;

    	public ColorP X0Y2_耳CP;

    	public ColorP X0Y2_耳線1CP;

    	public ColorP X0Y2_耳線2CP;

    	public ColorP X1Y0_羽2CP;

    	public ColorP X1Y0_羽1CP;

    	public ColorP X1Y0_耳CP;

    	public ColorP X1Y0_耳線1CP;

    	public ColorP X1Y0_耳線2CP;

    	public ColorP X1Y1_羽2CP;

    	public ColorP X1Y1_羽1CP;

    	public ColorP X1Y1_耳CP;

    	public ColorP X1Y1_耳線1CP;

    	public ColorP X1Y1_耳線2CP;

    	public ColorP X1Y2_羽2CP;

    	public ColorP X1Y2_羽1CP;

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

    	public bool 羽2_表示
    	{
    		get
    		{
    			return X0Y0_羽2.Dra;
    		}
    		set
    		{
    			X0Y0_羽2.Dra = value;
    			X0Y1_羽2.Dra = value;
    			X0Y2_羽2.Dra = value;
    			X1Y0_羽2.Dra = value;
    			X1Y1_羽2.Dra = value;
    			X1Y2_羽2.Dra = value;
    			X0Y0_羽2.Hit = value;
    			X0Y1_羽2.Hit = value;
    			X0Y2_羽2.Hit = value;
    			X1Y0_羽2.Hit = value;
    			X1Y1_羽2.Hit = value;
    			X1Y2_羽2.Hit = value;
    		}
    	}

    	public bool 羽1_表示
    	{
    		get
    		{
    			return X0Y0_羽1.Dra;
    		}
    		set
    		{
    			X0Y0_羽1.Dra = value;
    			X0Y1_羽1.Dra = value;
    			X0Y2_羽1.Dra = value;
    			X1Y0_羽1.Dra = value;
    			X1Y1_羽1.Dra = value;
    			X1Y2_羽1.Dra = value;
    			X0Y0_羽1.Hit = value;
    			X0Y1_羽1.Hit = value;
    			X0Y2_羽1.Hit = value;
    			X1Y0_羽1.Hit = value;
    			X1Y1_羽1.Hit = value;
    			X1Y2_羽1.Hit = value;
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
    			return 羽2_表示;
    		}
    		set
    		{
    			羽2_表示 = value;
    			羽1_表示 = value;
    			耳_表示 = value;
    			耳線1_表示 = value;
    			耳線2_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 羽2CD.不透明度;
    		}
    		set
    		{
    			羽2CD.不透明度 = value;
    			羽1CD.不透明度 = value;
    			耳CD.不透明度 = value;
    			耳線1CD.不透明度 = value;
    			耳線2CD.不透明度 = value;
    		}
    	}

    	public 耳_羽(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 耳_羽D e)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid();
    		Body.Tag = "羽";
    		Body.Add(new MorphVariant(GlobalState.肢左["耳"][8]));
    		Body.Add(new MorphVariant(GlobalState.肢左["耳"][9]));
    		PartGroup partGroup = Body[0][0];
    		X0Y0_羽2 = partGroup["羽2"].ToPar();
    		X0Y0_羽1 = partGroup["羽1"].ToPar();
    		X0Y0_耳 = partGroup["耳"].ToPar();
    		X0Y0_耳線1 = partGroup["耳線1"].ToPar();
    		X0Y0_耳線2 = partGroup["耳線2"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_羽2 = partGroup["羽2"].ToPar();
    		X0Y1_羽1 = partGroup["羽1"].ToPar();
    		X0Y1_耳 = partGroup["耳"].ToPar();
    		X0Y1_耳線1 = partGroup["耳線1"].ToPar();
    		X0Y1_耳線2 = partGroup["耳線2"].ToPar();
    		partGroup = Body[0][2];
    		X0Y2_羽2 = partGroup["羽2"].ToPar();
    		X0Y2_羽1 = partGroup["羽1"].ToPar();
    		X0Y2_耳 = partGroup["耳"].ToPar();
    		X0Y2_耳線1 = partGroup["耳線1"].ToPar();
    		X0Y2_耳線2 = partGroup["耳線2"].ToPar();
    		partGroup = Body[1][0];
    		X1Y0_羽2 = partGroup["羽2"].ToPar();
    		X1Y0_羽1 = partGroup["羽1"].ToPar();
    		X1Y0_耳 = partGroup["耳"].ToPar();
    		X1Y0_耳線1 = partGroup["耳線1"].ToPar();
    		X1Y0_耳線2 = partGroup["耳線2"].ToPar();
    		partGroup = Body[1][1];
    		X1Y1_羽2 = partGroup["羽2"].ToPar();
    		X1Y1_羽1 = partGroup["羽1"].ToPar();
    		X1Y1_耳 = partGroup["耳"].ToPar();
    		X1Y1_耳線1 = partGroup["耳線1"].ToPar();
    		X1Y1_耳線2 = partGroup["耳線2"].ToPar();
    		partGroup = Body[1][2];
    		X1Y2_羽2 = partGroup["羽2"].ToPar();
    		X1Y2_羽1 = partGroup["羽1"].ToPar();
    		X1Y2_耳 = partGroup["耳"].ToPar();
    		X1Y2_耳線1 = partGroup["耳線1"].ToPar();
    		X1Y2_耳線2 = partGroup["耳線2"].ToPar();
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
    		羽2_表示 = e.羽2_表示;
    		羽1_表示 = e.羽1_表示;
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
    		X0Y0_羽2CP = new ColorP(X0Y0_羽2, 羽2CD, DisUnit, abj: true);
    		X0Y0_羽1CP = new ColorP(X0Y0_羽1, 羽1CD, DisUnit, abj: true);
    		X0Y0_耳CP = new ColorP(X0Y0_耳, 耳CD, DisUnit, abj: true);
    		X0Y0_耳線1CP = new ColorP(X0Y0_耳線1, 耳線1CD, DisUnit, abj: true);
    		X0Y0_耳線2CP = new ColorP(X0Y0_耳線2, 耳線2CD, DisUnit, abj: true);
    		X0Y1_羽2CP = new ColorP(X0Y1_羽2, 羽2CD, DisUnit, abj: true);
    		X0Y1_羽1CP = new ColorP(X0Y1_羽1, 羽1CD, DisUnit, abj: true);
    		X0Y1_耳CP = new ColorP(X0Y1_耳, 耳CD, DisUnit, abj: true);
    		X0Y1_耳線1CP = new ColorP(X0Y1_耳線1, 耳線1CD, DisUnit, abj: true);
    		X0Y1_耳線2CP = new ColorP(X0Y1_耳線2, 耳線2CD, DisUnit, abj: true);
    		X0Y2_羽2CP = new ColorP(X0Y2_羽2, 羽2CD, DisUnit, abj: true);
    		X0Y2_羽1CP = new ColorP(X0Y2_羽1, 羽1CD, DisUnit, abj: true);
    		X0Y2_耳CP = new ColorP(X0Y2_耳, 耳CD, DisUnit, abj: true);
    		X0Y2_耳線1CP = new ColorP(X0Y2_耳線1, 耳線1CD, DisUnit, abj: true);
    		X0Y2_耳線2CP = new ColorP(X0Y2_耳線2, 耳線2CD, DisUnit, abj: true);
    		X1Y0_羽2CP = new ColorP(X1Y0_羽2, 羽2CD, DisUnit, abj: true);
    		X1Y0_羽1CP = new ColorP(X1Y0_羽1, 羽1CD, DisUnit, abj: true);
    		X1Y0_耳CP = new ColorP(X1Y0_耳, 耳CD, DisUnit, abj: true);
    		X1Y0_耳線1CP = new ColorP(X1Y0_耳線1, 耳線1CD, DisUnit, abj: true);
    		X1Y0_耳線2CP = new ColorP(X1Y0_耳線2, 耳線2CD, DisUnit, abj: true);
    		X1Y1_羽2CP = new ColorP(X1Y1_羽2, 羽2CD, DisUnit, abj: true);
    		X1Y1_羽1CP = new ColorP(X1Y1_羽1, 羽1CD, DisUnit, abj: true);
    		X1Y1_耳CP = new ColorP(X1Y1_耳, 耳CD, DisUnit, abj: true);
    		X1Y1_耳線1CP = new ColorP(X1Y1_耳線1, 耳線1CD, DisUnit, abj: true);
    		X1Y1_耳線2CP = new ColorP(X1Y1_耳線2, 耳線2CD, DisUnit, abj: true);
    		X1Y2_羽2CP = new ColorP(X1Y2_羽2, 羽2CD, DisUnit, abj: true);
    		X1Y2_羽1CP = new ColorP(X1Y2_羽1, 羽1CD, DisUnit, abj: true);
    		X1Y2_耳CP = new ColorP(X1Y2_耳, 耳CD, DisUnit, abj: true);
    		X1Y2_耳線1CP = new ColorP(X1Y2_耳線1, 耳線1CD, DisUnit, abj: true);
    		X1Y2_耳線2CP = new ColorP(X1Y2_耳線2, 耳線2CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_耳.AngleBase = num * -314.0;
    		X0Y0_羽1.AngleBase = num * -31.0;
    		X0Y0_羽2.AngleBase = num * 291.0;
    		X0Y1_耳.AngleBase = num * -333.0;
    		X0Y1_羽1.AngleBase = num * -20.9999999999999;
    		X0Y1_羽2.AngleBase = num * 313.0;
    		X0Y2_耳.AngleBase = num * 0.0;
    		X0Y2_羽1.AngleBase = num * -2.49999999999986;
    		X0Y2_羽2.AngleBase = num * -16.0000000000001;
    		X1Y0_耳.AngleBase = num * -314.0;
    		X1Y0_羽1.AngleBase = num * -31.0;
    		X1Y0_羽2.AngleBase = num * 291.0;
    		X1Y1_耳.AngleBase = num * -333.0;
    		X1Y1_羽1.AngleBase = num * -20.9999999999999;
    		X1Y1_羽2.AngleBase = num * 313.0;
    		X1Y2_耳.AngleBase = num * 0.0;
    		X1Y2_羽1.AngleBase = num * -2.49999999999986;
    		X1Y2_羽2.AngleBase = num * -16.0000000000001;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexX == 0)
    		{
    			switch (Body.IndexY)
    			{
    			case 0:
    				X0Y0_羽2CP.Update();
    				X0Y0_羽1CP.Update();
    				X0Y0_耳CP.Update();
    				X0Y0_耳線1CP.Update();
    				X0Y0_耳線2CP.Update();
    				break;
    			case 1:
    				X0Y1_羽2CP.Update();
    				X0Y1_羽1CP.Update();
    				X0Y1_耳CP.Update();
    				X0Y1_耳線1CP.Update();
    				X0Y1_耳線2CP.Update();
    				break;
    			default:
    				X0Y2_羽2CP.Update();
    				X0Y2_羽1CP.Update();
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
    				X1Y0_羽2CP.Update();
    				X1Y0_羽1CP.Update();
    				X1Y0_耳CP.Update();
    				X1Y0_耳線1CP.Update();
    				X1Y0_耳線2CP.Update();
    				break;
    			case 1:
    				X1Y1_羽2CP.Update();
    				X1Y1_羽1CP.Update();
    				X1Y1_耳CP.Update();
    				X1Y1_耳線1CP.Update();
    				X1Y1_耳線2CP.Update();
    				break;
    			default:
    				X1Y2_羽2CP.Update();
    				X1Y2_羽1CP.Update();
    				X1Y2_耳CP.Update();
    				X1Y2_耳線1CP.Update();
    				X1Y2_耳線2CP.Update();
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
    		羽2CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽0O);
    		羽1CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽0O);
    		耳CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽0O);
    		耳線1CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		耳線2CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		羽2CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽0O);
    		羽1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		耳CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽0O);
    		耳線1CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		耳線2CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		羽2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		羽1CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽0O);
    		耳CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		耳線1CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		耳線2CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}
    }
}
