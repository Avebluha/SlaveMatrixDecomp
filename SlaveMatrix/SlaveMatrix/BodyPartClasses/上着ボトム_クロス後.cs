using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 上着ボトム_クロス後 : 上着ボトム
    {
    	public ShapePart X0Y0_下地;

    	public ShapePart X0Y0_染み_染み2;

    	public ShapePart X0Y0_染み_染み1;

    	public ShapePart X0Y1_下地;

    	public ShapePart X0Y1_染み_染み2;

    	public ShapePart X0Y1_染み_染み1;

    	public ColorD 下地CD;

    	public ColorD 染み_染み2CD;

    	public ColorD 染み_染み1CD;

    	public ColorP X0Y0_下地CP;

    	public ColorP X0Y0_染み_染み2CP;

    	public ColorP X0Y0_染み_染み1CP;

    	public ColorP X0Y1_下地CP;

    	public ColorP X0Y1_染み_染み2CP;

    	public ColorP X0Y1_染み_染み1CP;

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

    	public bool 下地_表示
    	{
    		get
    		{
    			return X0Y0_下地.Dra;
    		}
    		set
    		{
    			X0Y0_下地.Dra = value;
    			X0Y1_下地.Dra = value;
    			X0Y0_下地.Hit = false;
    			X0Y1_下地.Hit = false;
    		}
    	}

    	public bool 染み_染み2_表示
    	{
    		get
    		{
    			return X0Y0_染み_染み2.Dra;
    		}
    		set
    		{
    			X0Y0_染み_染み2.Dra = value;
    			X0Y1_染み_染み2.Dra = value;
    			X0Y0_染み_染み2.Hit = false;
    			X0Y1_染み_染み2.Hit = false;
    		}
    	}

    	public bool 染み_染み1_表示
    	{
    		get
    		{
    			return X0Y0_染み_染み1.Dra;
    		}
    		set
    		{
    			X0Y0_染み_染み1.Dra = value;
    			X0Y1_染み_染み1.Dra = value;
    			X0Y0_染み_染み1.Hit = false;
    			X0Y1_染み_染み1.Hit = false;
    		}
    	}

    	public bool 染み表示
    	{
    		get
    		{
    			return 染み_染み2_表示;
    		}
    		set
    		{
    			染み_染み2_表示 = value;
    			染み_染み1_表示 = value;
    		}
    	}

    	public double 染み濃度
    	{
    		get
    		{
    			return 染み_染み2CD.不透明度;
    		}
    		set
    		{
    			染み_染み2CD.不透明度 = value;
    			染み_染み1CD.不透明度 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 下地_表示;
    		}
    		set
    		{
    			下地_表示 = value;
    			染み_染み2_表示 = value;
    			染み_染み1_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 下地CD.不透明度;
    		}
    		set
    		{
    			下地CD.不透明度 = value;
    			染み_染み2CD.不透明度 = value;
    			染み_染み1CD.不透明度 = value;
    		}
    	}

    	public 上着ボトム_クロス後(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 上着ボトム_クロス後D e)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid(GlobalState.胴体["上着ボトム後"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_下地 = partGroup["下地"].ToPar();
    		PartGroup pars2 = partGroup["染み"].ToPars();
    		X0Y0_染み_染み2 = pars2["染み2"].ToPar();
    		X0Y0_染み_染み1 = pars2["染み1"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_下地 = partGroup["下地"].ToPar();
    		pars2 = partGroup["染み"].ToPars();
    		X0Y1_染み_染み2 = pars2["染み2"].ToPar();
    		X0Y1_染み_染み1 = pars2["染み1"].ToPar();
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
    		下地_表示 = e.下地_表示;
    		染み_染み2_表示 = e.染み_染み2_表示;
    		染み_染み1_表示 = e.染み_染み1_表示;
    		染み表示 = e.染み表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_下地CP = new ColorP(X0Y0_下地, 下地CD, DisUnit, abj: true);
    		X0Y0_染み_染み2CP = new ColorP(X0Y0_染み_染み2, 染み_染み2CD, DisUnit, abj: true);
    		X0Y0_染み_染み1CP = new ColorP(X0Y0_染み_染み1, 染み_染み1CD, DisUnit, abj: true);
    		X0Y1_下地CP = new ColorP(X0Y1_下地, 下地CD, DisUnit, abj: true);
    		X0Y1_染み_染み2CP = new ColorP(X0Y1_染み_染み2, 染み_染み2CD, DisUnit, abj: true);
    		X0Y1_染み_染み1CP = new ColorP(X0Y1_染み_染み1, 染み_染み1CD, DisUnit, abj: true);
    		染み濃度 = e.染み濃度;
    		Intensity = e.濃度;
    		尺度XB = 1.01;
    		尺度YB = 0.95;
    	}

    	public override bool Is布(ShapePart p)
    	{
    		if (p != X0Y0_下地 && p != X0Y0_染み_染み2 && p != X0Y0_染み_染み1 && p != X0Y1_下地 && p != X0Y1_染み_染み2)
    		{
    			return p == X0Y1_染み_染み1;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		if (Body.GetIndexY() == 0)
    		{
    			X0Y0_下地CP.Update();
    			X0Y0_染み_染み2CP.Update();
    			X0Y0_染み_染み1CP.Update();
    		}
    		else
    		{
    			X0Y1_下地CP.Update();
    			X0Y1_染み_染み2CP.Update();
    			X0Y1_染み_染み1CP.Update();
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		下地CD = new ColorD();
    		染み_染み2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.染み);
    		染み_染み1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.染み);
    	}

    	public void 配色(クロスB色 配色)
    	{
    		下地CD.色 = 配色.生地1色;
    	}
    }
}
