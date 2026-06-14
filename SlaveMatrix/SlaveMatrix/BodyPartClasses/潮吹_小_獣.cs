using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 潮吹_小_獣 : 潮吹_小
    {
    	public ShapePart X0Y0_雫;

    	public ShapePart X0Y1_雫;

    	public ShapePart X0Y2_雫;

    	public ShapePart X0Y3_雫;

    	public ShapePart X0Y4_雫;

    	public ShapePart X0Y5_雫;

    	public ShapePart X0Y6_雫;

    	public ShapePart X0Y7_雫;

    	public ShapePart X0Y8_雫;

    	public ColorD 雫CD;

    	public ColorP X0Y0_雫CP;

    	public ColorP X0Y1_雫CP;

    	public ColorP X0Y2_雫CP;

    	public ColorP X0Y3_雫CP;

    	public ColorP X0Y4_雫CP;

    	public ColorP X0Y5_雫CP;

    	public ColorP X0Y6_雫CP;

    	public ColorP X0Y7_雫CP;

    	public ColorP X0Y8_雫CP;

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

    	public bool 雫_表示
    	{
    		get
    		{
    			return X0Y0_雫.Dra;
    		}
    		set
    		{
    			X0Y0_雫.Dra = value;
    			X0Y1_雫.Dra = value;
    			X0Y2_雫.Dra = value;
    			X0Y3_雫.Dra = value;
    			X0Y4_雫.Dra = value;
    			X0Y5_雫.Dra = value;
    			X0Y6_雫.Dra = value;
    			X0Y7_雫.Dra = value;
    			X0Y8_雫.Dra = value;
    			X0Y0_雫.Hit = value;
    			X0Y1_雫.Hit = value;
    			X0Y2_雫.Hit = value;
    			X0Y3_雫.Hit = value;
    			X0Y4_雫.Hit = value;
    			X0Y5_雫.Hit = value;
    			X0Y6_雫.Hit = value;
    			X0Y7_雫.Hit = value;
    			X0Y8_雫.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 雫_表示;
    		}
    		set
    		{
    			雫_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 雫CD.不透明度;
    		}
    		set
    		{
    			雫CD.不透明度 = value;
    		}
    	}

    	public 潮吹_小_獣(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 潮吹_小_獣D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(GlobalState.性器付["四足潮吹"][0]);
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_雫 = partGroup["雫"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_雫 = partGroup["雫"].ToPar();
    		partGroup = Body[0][2];
    		X0Y2_雫 = partGroup["雫"].ToPar();
    		partGroup = Body[0][3];
    		X0Y3_雫 = partGroup["雫"].ToPar();
    		partGroup = Body[0][4];
    		X0Y4_雫 = partGroup["雫"].ToPar();
    		partGroup = Body[0][5];
    		X0Y5_雫 = partGroup["雫"].ToPar();
    		partGroup = Body[0][6];
    		X0Y6_雫 = partGroup["雫"].ToPar();
    		partGroup = Body[0][7];
    		X0Y7_雫 = partGroup["雫"].ToPar();
    		partGroup = Body[0][8];
    		X0Y8_雫 = partGroup["雫"].ToPar();
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
    		雫_表示 = e.雫_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_雫CP = new ColorP(X0Y0_雫, 雫CD, DisUnit, abj: true);
    		X0Y1_雫CP = new ColorP(X0Y1_雫, 雫CD, DisUnit, abj: true);
    		X0Y2_雫CP = new ColorP(X0Y2_雫, 雫CD, DisUnit, abj: true);
    		X0Y3_雫CP = new ColorP(X0Y3_雫, 雫CD, DisUnit, abj: true);
    		X0Y4_雫CP = new ColorP(X0Y4_雫, 雫CD, DisUnit, abj: true);
    		X0Y5_雫CP = new ColorP(X0Y5_雫, 雫CD, DisUnit, abj: true);
    		X0Y6_雫CP = new ColorP(X0Y6_雫, 雫CD, DisUnit, abj: true);
    		X0Y7_雫CP = new ColorP(X0Y7_雫, 雫CD, DisUnit, abj: true);
    		X0Y8_雫CP = new ColorP(X0Y8_雫, 雫CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		switch (Body.GetIndexY())
    		{
    		case 0:
    			X0Y0_雫CP.Update();
    			break;
    		case 1:
    			X0Y1_雫CP.Update();
    			break;
    		case 2:
    			X0Y2_雫CP.Update();
    			break;
    		case 3:
    			X0Y3_雫CP.Update();
    			break;
    		case 4:
    			X0Y4_雫CP.Update();
    			break;
    		case 5:
    			X0Y5_雫CP.Update();
    			break;
    		case 6:
    			X0Y6_雫CP.Update();
    			break;
    		case 7:
    			X0Y7_雫CP.Update();
    			break;
    		default:
    			X0Y8_雫CP.Update();
    			break;
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		雫CD = new ColorD(ref ColorHelper.Empty, ref 体配色.体液);
    	}
    }
}
