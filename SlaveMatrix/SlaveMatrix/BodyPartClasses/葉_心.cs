using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 葉_心 : 葉
    {
    	public ShapePart X0Y0_通常_葉;

    	public ShapePart X0Y0_通常_葉脈;

    	public ShapePart X0Y1_欠損1_葉;

    	public ShapePart X0Y1_欠損1_葉脈;

    	public ShapePart X0Y2_欠損2_葉;

    	public ShapePart X0Y2_欠損2_葉脈;

    	public ColorD 葉CD;

    	public ColorD 葉脈CD;

    	public ColorP X0Y0_通常_葉CP;

    	public ColorP X0Y0_通常_葉脈CP;

    	public ColorP X0Y1_欠損1_葉CP;

    	public ColorP X0Y1_欠損1_葉脈CP;

    	public ColorP X0Y2_欠損2_葉CP;

    	public ColorP X0Y2_欠損2_葉脈CP;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    			Body.SetIndexY((欠損_ ? Rng.XS.NextM(1, 2) : 0));
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

    	public int 欠損i
    	{
    		get
    		{
    			return Body.GetIndexY();
    		}
    		set
    		{
    			Body.SetIndexY(value);
    			欠損_ = Body.GetIndexY() > 0;
    		}
    	}

    	public bool 葉_表示
    	{
    		get
    		{
    			return X0Y0_通常_葉.Dra;
    		}
    		set
    		{
    			X0Y0_通常_葉.Dra = value;
    			X0Y1_欠損1_葉.Dra = value;
    			X0Y2_欠損2_葉.Dra = value;
    			X0Y0_通常_葉.Hit = value;
    			X0Y1_欠損1_葉.Hit = value;
    			X0Y2_欠損2_葉.Hit = value;
    		}
    	}

    	public bool 葉脈_表示
    	{
    		get
    		{
    			return X0Y0_通常_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_通常_葉脈.Dra = value;
    			X0Y1_欠損1_葉脈.Dra = value;
    			X0Y2_欠損2_葉脈.Dra = value;
    			X0Y0_通常_葉脈.Hit = value;
    			X0Y1_欠損1_葉脈.Hit = value;
    			X0Y2_欠損2_葉脈.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 葉_表示;
    		}
    		set
    		{
    			葉_表示 = value;
    			葉脈_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 葉CD.不透明度;
    		}
    		set
    		{
    			葉CD.不透明度 = value;
    			葉脈CD.不透明度 = value;
    		}
    	}

    	public 葉_心(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 葉_心D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(GlobalState.肢左["葉"][1]);
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_通常_葉 = partGroup["葉"].ToPar();
    		X0Y0_通常_葉脈 = partGroup["葉脈"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_欠損1_葉 = partGroup["葉"].ToPar();
    		X0Y1_欠損1_葉脈 = partGroup["葉脈"].ToPar();
    		partGroup = Body[0][2];
    		X0Y2_欠損2_葉 = partGroup["葉"].ToPar();
    		X0Y2_欠損2_葉脈 = partGroup["葉脈"].ToPar();
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
    		欠損i = e.欠損i;
    		葉_表示 = e.葉_表示;
    		葉脈_表示 = e.葉脈_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_通常_葉CP = new ColorP(X0Y0_通常_葉, 葉CD, DisUnit, abj: true);
    		X0Y0_通常_葉脈CP = new ColorP(X0Y0_通常_葉脈, 葉脈CD, DisUnit, abj: true);
    		X0Y1_欠損1_葉CP = new ColorP(X0Y1_欠損1_葉, 葉CD, DisUnit, abj: true);
    		X0Y1_欠損1_葉脈CP = new ColorP(X0Y1_欠損1_葉脈, 葉脈CD, DisUnit, abj: true);
    		X0Y2_欠損2_葉CP = new ColorP(X0Y2_欠損2_葉, 葉CD, DisUnit, abj: true);
    		X0Y2_欠損2_葉脈CP = new ColorP(X0Y2_欠損2_葉脈, 葉脈CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		if (Body.GetIndexY() == 0)
    		{
    			X0Y0_通常_葉CP.Update();
    			X0Y0_通常_葉脈CP.Update();
    		}
    		else if (Body.GetIndexY() == 1)
    		{
    			X0Y1_欠損1_葉CP.Update();
    			X0Y1_欠損1_葉脈CP.Update();
    		}
    		else
    		{
    			X0Y2_欠損2_葉CP.Update();
    			X0Y2_欠損2_葉脈CP.Update();
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		switch (配色指定)
    		{
    		case 配色指定.N0:
    			配色N0(体配色);
    			break;
    		case 配色指定.T1:
    			配色T1(体配色);
    			break;
    		case 配色指定.T0:
    			配色T0(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		葉CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		葉脈CD = new ColorD(ref ColorHelper.Black, ref 体配色.植0O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		葉CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		葉脈CD = new ColorD(ref ColorHelper.Black, ref 体配色.植0O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		葉CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		葉脈CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    	}
    }
}
