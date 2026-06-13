using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 眉 : Ele
    {
    	public ShapePart X0Y0_眉;

    	public ShapePart X0Y1_眉;

    	public ShapePart X0Y1_眉間;

    	public ShapePart X0Y2_眉;

    	public ShapePart X0Y2_眉間;

    	public ColorD 眉CD;

    	public ColorD 眉間CD;

    	public ColorP X0Y0_眉CP;

    	public ColorP X0Y1_眉CP;

    	public ColorP X0Y1_眉間CP;

    	public ColorP X0Y2_眉CP;

    	public ColorP X0Y2_眉間CP;

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

    	public bool 眉_表示
    	{
    		get
    		{
    			return X0Y0_眉.Dra;
    		}
    		set
    		{
    			X0Y0_眉.Dra = value;
    			X0Y1_眉.Dra = value;
    			X0Y2_眉.Dra = value;
    			X0Y0_眉.Hit = value;
    			X0Y1_眉.Hit = value;
    			X0Y2_眉.Hit = value;
    		}
    	}

    	public bool 眉間_表示
    	{
    		get
    		{
    			return X0Y1_眉間.Dra;
    		}
    		set
    		{
    			X0Y1_眉間.Dra = value;
    			X0Y2_眉間.Dra = value;
    			X0Y1_眉間.Hit = value;
    			X0Y2_眉間.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 眉_表示;
    		}
    		set
    		{
    			眉_表示 = value;
    			眉間_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 眉CD.不透明度;
    		}
    		set
    		{
    			眉CD.不透明度 = value;
    			眉間CD.不透明度 = value;
    		}
    	}

    	public override double サイズY
    	{
    		get
    		{
    			return サイズY_;
    		}
    		set
    		{
    			尺度YB = 0.5 + 1.1 * value;
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

    	public 眉(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 眉D e)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.胴体["眉左"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_眉 = partGroup["眉"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_眉 = partGroup["眉"].ToPar();
    		X0Y1_眉間 = partGroup["眉間"].ToPar();
    		partGroup = Body[0][2];
    		X0Y2_眉 = partGroup["眉"].ToPar();
    		X0Y2_眉間 = partGroup["眉間"].ToPar();
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
    		眉_表示 = e.眉_表示;
    		眉間_表示 = e.眉間_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_眉CP = new ColorP(X0Y0_眉, 眉CD, DisUnit, abj: true);
    		X0Y1_眉CP = new ColorP(X0Y1_眉, 眉CD, DisUnit, abj: true);
    		X0Y1_眉間CP = new ColorP(X0Y1_眉間, 眉間CD, DisUnit, abj: false);
    		X0Y2_眉CP = new ColorP(X0Y2_眉, 眉CD, DisUnit, abj: true);
    		X0Y2_眉間CP = new ColorP(X0Y2_眉間, 眉間CD, DisUnit, abj: false);
    		Intensity = e.濃度;
    		int num = (右 ? 1 : (-1));
    		X0Y0_眉.BasePointBase = X0Y0_眉.BasePointBase.AddX((double)num * 0.0009);
    		X0Y1_眉.BasePointBase = X0Y1_眉.BasePointBase.AddX((double)num * 0.0009);
    		X0Y2_眉.BasePointBase = X0Y2_眉.BasePointBase.AddX((double)num * 0.0009);
    	}

    	public override void 色更新()
    	{
    		switch (Body.IndexY)
    		{
    		case 0:
    			X0Y0_眉CP.Update();
    			break;
    		case 1:
    			X0Y1_眉CP.Update();
    			X0Y1_眉間CP.Update();
    			break;
    		default:
    			X0Y2_眉CP.Update();
    			X0Y2_眉間CP.Update();
    			break;
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		眉CD = new ColorD(ref Col.Black, ref 体配色.眉O);
    		眉間CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    	}
    }
}
