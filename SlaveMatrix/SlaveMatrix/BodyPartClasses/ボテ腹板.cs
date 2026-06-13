using _2DGAMELIB;

namespace SlaveMatrix
{
    public class ボテ腹板 : Ele
    {
    	public ShapePart X0Y0_腹板4_腹板;

    	public ShapePart X0Y0_腹板4_縦線;

    	public ShapePart X0Y0_腹板3_腹板;

    	public ShapePart X0Y0_腹板3_縦線;

    	public ShapePart X0Y0_腹板2_腹板;

    	public ShapePart X0Y0_腹板2_縦線;

    	public ShapePart X0Y0_腹板1_腹板;

    	public ShapePart X0Y0_腹板1_縦線;

    	public ShapePart X0Y1_腹板4_腹板;

    	public ShapePart X0Y1_腹板4_縦線;

    	public ShapePart X0Y1_腹板3_腹板;

    	public ShapePart X0Y1_腹板3_縦線;

    	public ShapePart X0Y1_腹板2_腹板;

    	public ShapePart X0Y1_腹板2_縦線;

    	public ShapePart X0Y1_腹板1_腹板;

    	public ShapePart X0Y1_腹板1_縦線;

    	public ShapePart X0Y2_腹板4_腹板;

    	public ShapePart X0Y2_腹板4_縦線;

    	public ShapePart X0Y2_腹板3_腹板;

    	public ShapePart X0Y2_腹板3_縦線;

    	public ShapePart X0Y2_腹板2_腹板;

    	public ShapePart X0Y2_腹板2_縦線;

    	public ShapePart X0Y2_腹板1_腹板;

    	public ShapePart X0Y2_腹板1_縦線;

    	public ShapePart X0Y3_腹板4_腹板;

    	public ShapePart X0Y3_腹板4_縦線;

    	public ShapePart X0Y3_腹板3_腹板;

    	public ShapePart X0Y3_腹板3_縦線;

    	public ShapePart X0Y3_腹板2_腹板;

    	public ShapePart X0Y3_腹板2_縦線;

    	public ShapePart X0Y3_腹板1_腹板;

    	public ShapePart X0Y3_腹板1_縦線;

    	public ShapePart X0Y4_腹板4_腹板;

    	public ShapePart X0Y4_腹板4_縦線;

    	public ShapePart X0Y4_腹板3_腹板;

    	public ShapePart X0Y4_腹板3_縦線;

    	public ShapePart X0Y4_腹板2_腹板;

    	public ShapePart X0Y4_腹板2_縦線;

    	public ShapePart X0Y4_腹板1_腹板;

    	public ShapePart X0Y4_腹板1_縦線;

    	public ColorD 腹板4_腹板CD;

    	public ColorD 腹板4_縦線CD;

    	public ColorD 腹板3_腹板CD;

    	public ColorD 腹板3_縦線CD;

    	public ColorD 腹板2_腹板CD;

    	public ColorD 腹板2_縦線CD;

    	public ColorD 腹板1_腹板CD;

    	public ColorD 腹板1_縦線CD;

    	public ColorP X0Y0_腹板4_腹板CP;

    	public ColorP X0Y0_腹板4_縦線CP;

    	public ColorP X0Y0_腹板3_腹板CP;

    	public ColorP X0Y0_腹板3_縦線CP;

    	public ColorP X0Y0_腹板2_腹板CP;

    	public ColorP X0Y0_腹板2_縦線CP;

    	public ColorP X0Y0_腹板1_腹板CP;

    	public ColorP X0Y0_腹板1_縦線CP;

    	public ColorP X0Y1_腹板4_腹板CP;

    	public ColorP X0Y1_腹板4_縦線CP;

    	public ColorP X0Y1_腹板3_腹板CP;

    	public ColorP X0Y1_腹板3_縦線CP;

    	public ColorP X0Y1_腹板2_腹板CP;

    	public ColorP X0Y1_腹板2_縦線CP;

    	public ColorP X0Y1_腹板1_腹板CP;

    	public ColorP X0Y1_腹板1_縦線CP;

    	public ColorP X0Y2_腹板4_腹板CP;

    	public ColorP X0Y2_腹板4_縦線CP;

    	public ColorP X0Y2_腹板3_腹板CP;

    	public ColorP X0Y2_腹板3_縦線CP;

    	public ColorP X0Y2_腹板2_腹板CP;

    	public ColorP X0Y2_腹板2_縦線CP;

    	public ColorP X0Y2_腹板1_腹板CP;

    	public ColorP X0Y2_腹板1_縦線CP;

    	public ColorP X0Y3_腹板4_腹板CP;

    	public ColorP X0Y3_腹板4_縦線CP;

    	public ColorP X0Y3_腹板3_腹板CP;

    	public ColorP X0Y3_腹板3_縦線CP;

    	public ColorP X0Y3_腹板2_腹板CP;

    	public ColorP X0Y3_腹板2_縦線CP;

    	public ColorP X0Y3_腹板1_腹板CP;

    	public ColorP X0Y3_腹板1_縦線CP;

    	public ColorP X0Y4_腹板4_腹板CP;

    	public ColorP X0Y4_腹板4_縦線CP;

    	public ColorP X0Y4_腹板3_腹板CP;

    	public ColorP X0Y4_腹板3_縦線CP;

    	public ColorP X0Y4_腹板2_腹板CP;

    	public ColorP X0Y4_腹板2_縦線CP;

    	public ColorP X0Y4_腹板1_腹板CP;

    	public ColorP X0Y4_腹板1_縦線CP;

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

    	public bool 腹板4_腹板_表示
    	{
    		get
    		{
    			return X0Y0_腹板4_腹板.Dra;
    		}
    		set
    		{
    			X0Y0_腹板4_腹板.Dra = value;
    			X0Y1_腹板4_腹板.Dra = value;
    			X0Y2_腹板4_腹板.Dra = value;
    			X0Y3_腹板4_腹板.Dra = value;
    			X0Y4_腹板4_腹板.Dra = value;
    			X0Y0_腹板4_腹板.Hit = value;
    			X0Y1_腹板4_腹板.Hit = value;
    			X0Y2_腹板4_腹板.Hit = value;
    			X0Y3_腹板4_腹板.Hit = value;
    			X0Y4_腹板4_腹板.Hit = value;
    		}
    	}

    	public bool 腹板4_縦線_表示
    	{
    		get
    		{
    			return X0Y0_腹板4_縦線.Dra;
    		}
    		set
    		{
    			X0Y0_腹板4_縦線.Dra = value;
    			X0Y1_腹板4_縦線.Dra = value;
    			X0Y2_腹板4_縦線.Dra = value;
    			X0Y3_腹板4_縦線.Dra = value;
    			X0Y4_腹板4_縦線.Dra = value;
    			X0Y0_腹板4_縦線.Hit = value;
    			X0Y1_腹板4_縦線.Hit = value;
    			X0Y2_腹板4_縦線.Hit = value;
    			X0Y3_腹板4_縦線.Hit = value;
    			X0Y4_腹板4_縦線.Hit = value;
    		}
    	}

    	public bool 腹板3_腹板_表示
    	{
    		get
    		{
    			return X0Y0_腹板3_腹板.Dra;
    		}
    		set
    		{
    			X0Y0_腹板3_腹板.Dra = value;
    			X0Y1_腹板3_腹板.Dra = value;
    			X0Y2_腹板3_腹板.Dra = value;
    			X0Y3_腹板3_腹板.Dra = value;
    			X0Y4_腹板3_腹板.Dra = value;
    			X0Y0_腹板3_腹板.Hit = value;
    			X0Y1_腹板3_腹板.Hit = value;
    			X0Y2_腹板3_腹板.Hit = value;
    			X0Y3_腹板3_腹板.Hit = value;
    			X0Y4_腹板3_腹板.Hit = value;
    		}
    	}

    	public bool 腹板3_縦線_表示
    	{
    		get
    		{
    			return X0Y0_腹板3_縦線.Dra;
    		}
    		set
    		{
    			X0Y0_腹板3_縦線.Dra = value;
    			X0Y1_腹板3_縦線.Dra = value;
    			X0Y2_腹板3_縦線.Dra = value;
    			X0Y3_腹板3_縦線.Dra = value;
    			X0Y4_腹板3_縦線.Dra = value;
    			X0Y0_腹板3_縦線.Hit = value;
    			X0Y1_腹板3_縦線.Hit = value;
    			X0Y2_腹板3_縦線.Hit = value;
    			X0Y3_腹板3_縦線.Hit = value;
    			X0Y4_腹板3_縦線.Hit = value;
    		}
    	}

    	public bool 腹板2_腹板_表示
    	{
    		get
    		{
    			return X0Y0_腹板2_腹板.Dra;
    		}
    		set
    		{
    			X0Y0_腹板2_腹板.Dra = value;
    			X0Y1_腹板2_腹板.Dra = value;
    			X0Y2_腹板2_腹板.Dra = value;
    			X0Y3_腹板2_腹板.Dra = value;
    			X0Y4_腹板2_腹板.Dra = value;
    			X0Y0_腹板2_腹板.Hit = value;
    			X0Y1_腹板2_腹板.Hit = value;
    			X0Y2_腹板2_腹板.Hit = value;
    			X0Y3_腹板2_腹板.Hit = value;
    			X0Y4_腹板2_腹板.Hit = value;
    		}
    	}

    	public bool 腹板2_縦線_表示
    	{
    		get
    		{
    			return X0Y0_腹板2_縦線.Dra;
    		}
    		set
    		{
    			X0Y0_腹板2_縦線.Dra = value;
    			X0Y1_腹板2_縦線.Dra = value;
    			X0Y2_腹板2_縦線.Dra = value;
    			X0Y3_腹板2_縦線.Dra = value;
    			X0Y4_腹板2_縦線.Dra = value;
    			X0Y0_腹板2_縦線.Hit = value;
    			X0Y1_腹板2_縦線.Hit = value;
    			X0Y2_腹板2_縦線.Hit = value;
    			X0Y3_腹板2_縦線.Hit = value;
    			X0Y4_腹板2_縦線.Hit = value;
    		}
    	}

    	public bool 腹板1_腹板_表示
    	{
    		get
    		{
    			return X0Y0_腹板1_腹板.Dra;
    		}
    		set
    		{
    			X0Y0_腹板1_腹板.Dra = value;
    			X0Y1_腹板1_腹板.Dra = value;
    			X0Y2_腹板1_腹板.Dra = value;
    			X0Y3_腹板1_腹板.Dra = value;
    			X0Y4_腹板1_腹板.Dra = value;
    			X0Y0_腹板1_腹板.Hit = value;
    			X0Y1_腹板1_腹板.Hit = value;
    			X0Y2_腹板1_腹板.Hit = value;
    			X0Y3_腹板1_腹板.Hit = value;
    			X0Y4_腹板1_腹板.Hit = value;
    		}
    	}

    	public bool 腹板1_縦線_表示
    	{
    		get
    		{
    			return X0Y0_腹板1_縦線.Dra;
    		}
    		set
    		{
    			X0Y0_腹板1_縦線.Dra = value;
    			X0Y1_腹板1_縦線.Dra = value;
    			X0Y2_腹板1_縦線.Dra = value;
    			X0Y3_腹板1_縦線.Dra = value;
    			X0Y4_腹板1_縦線.Dra = value;
    			X0Y0_腹板1_縦線.Hit = value;
    			X0Y1_腹板1_縦線.Hit = value;
    			X0Y2_腹板1_縦線.Hit = value;
    			X0Y3_腹板1_縦線.Hit = value;
    			X0Y4_腹板1_縦線.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 腹板4_腹板_表示;
    		}
    		set
    		{
    			腹板4_腹板_表示 = value;
    			腹板4_縦線_表示 = value;
    			腹板3_腹板_表示 = value;
    			腹板3_縦線_表示 = value;
    			腹板2_腹板_表示 = value;
    			腹板2_縦線_表示 = value;
    			腹板1_腹板_表示 = value;
    			腹板1_縦線_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 腹板4_腹板CD.不透明度;
    		}
    		set
    		{
    			腹板4_腹板CD.不透明度 = value;
    			腹板4_縦線CD.不透明度 = value;
    			腹板3_腹板CD.不透明度 = value;
    			腹板3_縦線CD.不透明度 = value;
    			腹板2_腹板CD.不透明度 = value;
    			腹板2_縦線CD.不透明度 = value;
    			腹板1_腹板CD.不透明度 = value;
    			腹板1_縦線CD.不透明度 = value;
    		}
    	}

    	public ボテ腹板(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, ボテ腹板D e)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.胴体["ボテ腹板"]);
    		PartGroup partGroup = Body[0][0];
    		PartGroup pars2 = partGroup["腹板4"].ToPars();
    		X0Y0_腹板4_腹板 = pars2["腹板"].ToPar();
    		X0Y0_腹板4_縦線 = pars2["縦線"].ToPar();
    		pars2 = partGroup["腹板3"].ToPars();
    		X0Y0_腹板3_腹板 = pars2["腹板"].ToPar();
    		X0Y0_腹板3_縦線 = pars2["縦線"].ToPar();
    		pars2 = partGroup["腹板2"].ToPars();
    		X0Y0_腹板2_腹板 = pars2["腹板"].ToPar();
    		X0Y0_腹板2_縦線 = pars2["縦線"].ToPar();
    		pars2 = partGroup["腹板1"].ToPars();
    		X0Y0_腹板1_腹板 = pars2["腹板"].ToPar();
    		X0Y0_腹板1_縦線 = pars2["縦線"].ToPar();
    		PartGroup pars3 = Body[0][1];
    		pars2 = pars3["腹板4"].ToPars();
    		X0Y1_腹板4_腹板 = pars2["腹板"].ToPar();
    		X0Y1_腹板4_縦線 = pars2["縦線"].ToPar();
    		pars2 = pars3["腹板3"].ToPars();
    		X0Y1_腹板3_腹板 = pars2["腹板"].ToPar();
    		X0Y1_腹板3_縦線 = pars2["縦線"].ToPar();
    		pars2 = pars3["腹板2"].ToPars();
    		X0Y1_腹板2_腹板 = pars2["腹板"].ToPar();
    		X0Y1_腹板2_縦線 = pars2["縦線"].ToPar();
    		pars2 = pars3["腹板1"].ToPars();
    		X0Y1_腹板1_腹板 = pars2["腹板"].ToPar();
    		X0Y1_腹板1_縦線 = pars2["縦線"].ToPar();
    		PartGroup pars4 = Body[0][2];
    		pars2 = pars4["腹板4"].ToPars();
    		X0Y2_腹板4_腹板 = pars2["腹板"].ToPar();
    		X0Y2_腹板4_縦線 = pars2["縦線"].ToPar();
    		pars2 = pars4["腹板3"].ToPars();
    		X0Y2_腹板3_腹板 = pars2["腹板"].ToPar();
    		X0Y2_腹板3_縦線 = pars2["縦線"].ToPar();
    		pars2 = pars4["腹板2"].ToPars();
    		X0Y2_腹板2_腹板 = pars2["腹板"].ToPar();
    		X0Y2_腹板2_縦線 = pars2["縦線"].ToPar();
    		pars2 = pars4["腹板1"].ToPars();
    		X0Y2_腹板1_腹板 = pars2["腹板"].ToPar();
    		X0Y2_腹板1_縦線 = pars2["縦線"].ToPar();
    		PartGroup pars5 = Body[0][3];
    		pars2 = pars5["腹板4"].ToPars();
    		X0Y3_腹板4_腹板 = pars2["腹板"].ToPar();
    		X0Y3_腹板4_縦線 = pars2["縦線"].ToPar();
    		pars2 = pars5["腹板3"].ToPars();
    		X0Y3_腹板3_腹板 = pars2["腹板"].ToPar();
    		X0Y3_腹板3_縦線 = pars2["縦線"].ToPar();
    		pars2 = pars5["腹板2"].ToPars();
    		X0Y3_腹板2_腹板 = pars2["腹板"].ToPar();
    		X0Y3_腹板2_縦線 = pars2["縦線"].ToPar();
    		pars2 = pars5["腹板1"].ToPars();
    		X0Y3_腹板1_腹板 = pars2["腹板"].ToPar();
    		X0Y3_腹板1_縦線 = pars2["縦線"].ToPar();
    		PartGroup pars6 = Body[0][4];
    		pars2 = pars6["腹板4"].ToPars();
    		X0Y4_腹板4_腹板 = pars2["腹板"].ToPar();
    		X0Y4_腹板4_縦線 = pars2["縦線"].ToPar();
    		pars2 = pars6["腹板3"].ToPars();
    		X0Y4_腹板3_腹板 = pars2["腹板"].ToPar();
    		X0Y4_腹板3_縦線 = pars2["縦線"].ToPar();
    		pars2 = pars6["腹板2"].ToPars();
    		X0Y4_腹板2_腹板 = pars2["腹板"].ToPar();
    		X0Y4_腹板2_縦線 = pars2["縦線"].ToPar();
    		pars2 = pars6["腹板1"].ToPars();
    		X0Y4_腹板1_腹板 = pars2["腹板"].ToPar();
    		X0Y4_腹板1_縦線 = pars2["縦線"].ToPar();
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
    		腹板4_腹板_表示 = e.腹板4_腹板_表示;
    		腹板4_縦線_表示 = e.腹板4_縦線_表示;
    		腹板3_腹板_表示 = e.腹板3_腹板_表示;
    		腹板3_縦線_表示 = e.腹板3_縦線_表示;
    		腹板2_腹板_表示 = e.腹板2_腹板_表示;
    		腹板2_縦線_表示 = e.腹板2_縦線_表示;
    		腹板1_腹板_表示 = e.腹板1_腹板_表示;
    		腹板1_縦線_表示 = e.腹板1_縦線_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_腹板4_腹板CP = new ColorP(X0Y0_腹板4_腹板, 腹板4_腹板CD, DisUnit, abj: true);
    		X0Y0_腹板4_縦線CP = new ColorP(X0Y0_腹板4_縦線, 腹板4_縦線CD, DisUnit, abj: true);
    		X0Y0_腹板3_腹板CP = new ColorP(X0Y0_腹板3_腹板, 腹板3_腹板CD, DisUnit, abj: true);
    		X0Y0_腹板3_縦線CP = new ColorP(X0Y0_腹板3_縦線, 腹板3_縦線CD, DisUnit, abj: true);
    		X0Y0_腹板2_腹板CP = new ColorP(X0Y0_腹板2_腹板, 腹板2_腹板CD, DisUnit, abj: true);
    		X0Y0_腹板2_縦線CP = new ColorP(X0Y0_腹板2_縦線, 腹板2_縦線CD, DisUnit, abj: true);
    		X0Y0_腹板1_腹板CP = new ColorP(X0Y0_腹板1_腹板, 腹板1_腹板CD, DisUnit, abj: true);
    		X0Y0_腹板1_縦線CP = new ColorP(X0Y0_腹板1_縦線, 腹板1_縦線CD, DisUnit, abj: true);
    		X0Y1_腹板4_腹板CP = new ColorP(X0Y1_腹板4_腹板, 腹板4_腹板CD, DisUnit, abj: true);
    		X0Y1_腹板4_縦線CP = new ColorP(X0Y1_腹板4_縦線, 腹板4_縦線CD, DisUnit, abj: true);
    		X0Y1_腹板3_腹板CP = new ColorP(X0Y1_腹板3_腹板, 腹板3_腹板CD, DisUnit, abj: true);
    		X0Y1_腹板3_縦線CP = new ColorP(X0Y1_腹板3_縦線, 腹板3_縦線CD, DisUnit, abj: true);
    		X0Y1_腹板2_腹板CP = new ColorP(X0Y1_腹板2_腹板, 腹板2_腹板CD, DisUnit, abj: true);
    		X0Y1_腹板2_縦線CP = new ColorP(X0Y1_腹板2_縦線, 腹板2_縦線CD, DisUnit, abj: true);
    		X0Y1_腹板1_腹板CP = new ColorP(X0Y1_腹板1_腹板, 腹板1_腹板CD, DisUnit, abj: true);
    		X0Y1_腹板1_縦線CP = new ColorP(X0Y1_腹板1_縦線, 腹板1_縦線CD, DisUnit, abj: true);
    		X0Y2_腹板4_腹板CP = new ColorP(X0Y2_腹板4_腹板, 腹板4_腹板CD, DisUnit, abj: true);
    		X0Y2_腹板4_縦線CP = new ColorP(X0Y2_腹板4_縦線, 腹板4_縦線CD, DisUnit, abj: true);
    		X0Y2_腹板3_腹板CP = new ColorP(X0Y2_腹板3_腹板, 腹板3_腹板CD, DisUnit, abj: true);
    		X0Y2_腹板3_縦線CP = new ColorP(X0Y2_腹板3_縦線, 腹板3_縦線CD, DisUnit, abj: true);
    		X0Y2_腹板2_腹板CP = new ColorP(X0Y2_腹板2_腹板, 腹板2_腹板CD, DisUnit, abj: true);
    		X0Y2_腹板2_縦線CP = new ColorP(X0Y2_腹板2_縦線, 腹板2_縦線CD, DisUnit, abj: true);
    		X0Y2_腹板1_腹板CP = new ColorP(X0Y2_腹板1_腹板, 腹板1_腹板CD, DisUnit, abj: true);
    		X0Y2_腹板1_縦線CP = new ColorP(X0Y2_腹板1_縦線, 腹板1_縦線CD, DisUnit, abj: true);
    		X0Y3_腹板4_腹板CP = new ColorP(X0Y3_腹板4_腹板, 腹板4_腹板CD, DisUnit, abj: true);
    		X0Y3_腹板4_縦線CP = new ColorP(X0Y3_腹板4_縦線, 腹板4_縦線CD, DisUnit, abj: true);
    		X0Y3_腹板3_腹板CP = new ColorP(X0Y3_腹板3_腹板, 腹板3_腹板CD, DisUnit, abj: true);
    		X0Y3_腹板3_縦線CP = new ColorP(X0Y3_腹板3_縦線, 腹板3_縦線CD, DisUnit, abj: true);
    		X0Y3_腹板2_腹板CP = new ColorP(X0Y3_腹板2_腹板, 腹板2_腹板CD, DisUnit, abj: true);
    		X0Y3_腹板2_縦線CP = new ColorP(X0Y3_腹板2_縦線, 腹板2_縦線CD, DisUnit, abj: true);
    		X0Y3_腹板1_腹板CP = new ColorP(X0Y3_腹板1_腹板, 腹板1_腹板CD, DisUnit, abj: true);
    		X0Y3_腹板1_縦線CP = new ColorP(X0Y3_腹板1_縦線, 腹板1_縦線CD, DisUnit, abj: true);
    		X0Y4_腹板4_腹板CP = new ColorP(X0Y4_腹板4_腹板, 腹板4_腹板CD, DisUnit, abj: true);
    		X0Y4_腹板4_縦線CP = new ColorP(X0Y4_腹板4_縦線, 腹板4_縦線CD, DisUnit, abj: true);
    		X0Y4_腹板3_腹板CP = new ColorP(X0Y4_腹板3_腹板, 腹板3_腹板CD, DisUnit, abj: true);
    		X0Y4_腹板3_縦線CP = new ColorP(X0Y4_腹板3_縦線, 腹板3_縦線CD, DisUnit, abj: true);
    		X0Y4_腹板2_腹板CP = new ColorP(X0Y4_腹板2_腹板, 腹板2_腹板CD, DisUnit, abj: true);
    		X0Y4_腹板2_縦線CP = new ColorP(X0Y4_腹板2_縦線, 腹板2_縦線CD, DisUnit, abj: true);
    		X0Y4_腹板1_腹板CP = new ColorP(X0Y4_腹板1_腹板, 腹板1_腹板CD, DisUnit, abj: true);
    		X0Y4_腹板1_縦線CP = new ColorP(X0Y4_腹板1_縦線, 腹板1_縦線CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		尺度YB = 0.95;
    	}

    	public override void 色更新()
    	{
    		switch (Body.IndexY)
    		{
    		case 0:
    			X0Y0_腹板4_腹板CP.Update();
    			X0Y0_腹板4_縦線CP.Update();
    			X0Y0_腹板3_腹板CP.Update();
    			X0Y0_腹板3_縦線CP.Update();
    			X0Y0_腹板2_腹板CP.Update();
    			X0Y0_腹板2_縦線CP.Update();
    			X0Y0_腹板1_腹板CP.Update();
    			X0Y0_腹板1_縦線CP.Update();
    			break;
    		case 1:
    			X0Y1_腹板4_腹板CP.Update();
    			X0Y1_腹板4_縦線CP.Update();
    			X0Y1_腹板3_腹板CP.Update();
    			X0Y1_腹板3_縦線CP.Update();
    			X0Y1_腹板2_腹板CP.Update();
    			X0Y1_腹板2_縦線CP.Update();
    			X0Y1_腹板1_腹板CP.Update();
    			X0Y1_腹板1_縦線CP.Update();
    			break;
    		case 2:
    			X0Y2_腹板4_腹板CP.Update();
    			X0Y2_腹板4_縦線CP.Update();
    			X0Y2_腹板3_腹板CP.Update();
    			X0Y2_腹板3_縦線CP.Update();
    			X0Y2_腹板2_腹板CP.Update();
    			X0Y2_腹板2_縦線CP.Update();
    			X0Y2_腹板1_腹板CP.Update();
    			X0Y2_腹板1_縦線CP.Update();
    			break;
    		case 3:
    			X0Y3_腹板4_腹板CP.Update();
    			X0Y3_腹板4_縦線CP.Update();
    			X0Y3_腹板3_腹板CP.Update();
    			X0Y3_腹板3_縦線CP.Update();
    			X0Y3_腹板2_腹板CP.Update();
    			X0Y3_腹板2_縦線CP.Update();
    			X0Y3_腹板1_腹板CP.Update();
    			X0Y3_腹板1_縦線CP.Update();
    			break;
    		default:
    			X0Y4_腹板4_腹板CP.Update();
    			X0Y4_腹板4_縦線CP.Update();
    			X0Y4_腹板3_腹板CP.Update();
    			X0Y4_腹板3_縦線CP.Update();
    			X0Y4_腹板2_腹板CP.Update();
    			X0Y4_腹板2_縦線CP.Update();
    			X0Y4_腹板1_腹板CP.Update();
    			X0Y4_腹板1_縦線CP.Update();
    			break;
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		腹板4_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		腹板4_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		腹板3_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		腹板3_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		腹板2_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		腹板2_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		腹板1_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		腹板1_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    	}
    }
}
