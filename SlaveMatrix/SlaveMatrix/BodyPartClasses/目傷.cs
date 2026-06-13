using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 目傷 : Element
    {
    	public ShapePart X0Y0_傷上;

    	public ShapePart X0Y0_傷下;

    	public ShapePart X0Y1_傷上;

    	public ShapePart X0Y1_傷下;

    	public ShapePart X0Y2_傷上;

    	public ShapePart X0Y2_傷下;

    	public ShapePart X0Y3_傷上;

    	public ShapePart X0Y3_傷下;

    	public ShapePart X0Y4_傷上;

    	public ShapePart X0Y4_傷下;

    	public ColorD 傷上CD;

    	public ColorD 傷下CD;

    	public ColorP X0Y0_傷上CP;

    	public ColorP X0Y0_傷下CP;

    	public ColorP X0Y1_傷上CP;

    	public ColorP X0Y1_傷下CP;

    	public ColorP X0Y2_傷上CP;

    	public ColorP X0Y2_傷下CP;

    	public ColorP X0Y3_傷上CP;

    	public ColorP X0Y3_傷下CP;

    	public ColorP X0Y4_傷上CP;

    	public ColorP X0Y4_傷下CP;

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

    	public bool 傷上_表示
    	{
    		get
    		{
    			return X0Y0_傷上.Dra;
    		}
    		set
    		{
    			X0Y0_傷上.Dra = value;
    			X0Y1_傷上.Dra = value;
    			X0Y2_傷上.Dra = value;
    			X0Y3_傷上.Dra = value;
    			X0Y4_傷上.Dra = value;
    			X0Y0_傷上.Hit = value;
    			X0Y1_傷上.Hit = value;
    			X0Y2_傷上.Hit = value;
    			X0Y3_傷上.Hit = value;
    			X0Y4_傷上.Hit = value;
    		}
    	}

    	public bool 傷下_表示
    	{
    		get
    		{
    			return X0Y0_傷下.Dra;
    		}
    		set
    		{
    			X0Y0_傷下.Dra = value;
    			X0Y1_傷下.Dra = value;
    			X0Y2_傷下.Dra = value;
    			X0Y3_傷下.Dra = value;
    			X0Y4_傷下.Dra = value;
    			X0Y0_傷下.Hit = value;
    			X0Y1_傷下.Hit = value;
    			X0Y2_傷下.Hit = value;
    			X0Y3_傷下.Hit = value;
    			X0Y4_傷下.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 傷上_表示;
    		}
    		set
    		{
    			傷上_表示 = value;
    			傷下_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 傷上CD.不透明度;
    		}
    		set
    		{
    			傷上CD.不透明度 = value;
    			傷下CD.不透明度 = value;
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

    	public 目傷(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 目傷D e)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid(GlobalState.胴体["目傷左"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_傷上 = partGroup["傷上"].ToPar();
    		X0Y0_傷下 = partGroup["傷下"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_傷上 = partGroup["傷上"].ToPar();
    		X0Y1_傷下 = partGroup["傷下"].ToPar();
    		partGroup = Body[0][2];
    		X0Y2_傷上 = partGroup["傷上"].ToPar();
    		X0Y2_傷下 = partGroup["傷下"].ToPar();
    		partGroup = Body[0][3];
    		X0Y3_傷上 = partGroup["傷上"].ToPar();
    		X0Y3_傷下 = partGroup["傷下"].ToPar();
    		partGroup = Body[0][4];
    		X0Y4_傷上 = partGroup["傷上"].ToPar();
    		X0Y4_傷下 = partGroup["傷下"].ToPar();
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
    		傷上_表示 = e.傷上_表示;
    		傷下_表示 = e.傷下_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_傷上CP = new ColorP(X0Y0_傷上, 傷上CD, DisUnit, abj: true);
    		X0Y0_傷下CP = new ColorP(X0Y0_傷下, 傷下CD, DisUnit, abj: true);
    		X0Y1_傷上CP = new ColorP(X0Y1_傷上, 傷上CD, DisUnit, abj: true);
    		X0Y1_傷下CP = new ColorP(X0Y1_傷下, 傷下CD, DisUnit, abj: true);
    		X0Y2_傷上CP = new ColorP(X0Y2_傷上, 傷上CD, DisUnit, abj: true);
    		X0Y2_傷下CP = new ColorP(X0Y2_傷下, 傷下CD, DisUnit, abj: true);
    		X0Y3_傷上CP = new ColorP(X0Y3_傷上, 傷上CD, DisUnit, abj: true);
    		X0Y3_傷下CP = new ColorP(X0Y3_傷下, 傷下CD, DisUnit, abj: true);
    		X0Y4_傷上CP = new ColorP(X0Y4_傷上, 傷上CD, DisUnit, abj: true);
    		X0Y4_傷下CP = new ColorP(X0Y4_傷下, 傷下CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		switch (Body.IndexY)
    		{
    		case 0:
    			X0Y0_傷上CP.Update();
    			X0Y0_傷下CP.Update();
    			break;
    		case 1:
    			X0Y1_傷上CP.Update();
    			X0Y1_傷下CP.Update();
    			break;
    		case 2:
    			X0Y2_傷上CP.Update();
    			X0Y2_傷下CP.Update();
    			break;
    		case 3:
    			X0Y3_傷上CP.Update();
    			X0Y3_傷下CP.Update();
    			break;
    		default:
    			X0Y4_傷上CP.Update();
    			X0Y4_傷下CP.Update();
    			break;
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		傷上CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷下CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    	}
    }
}
