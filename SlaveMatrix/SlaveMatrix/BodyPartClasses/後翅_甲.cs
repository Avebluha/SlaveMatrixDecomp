using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 後翅_甲 : 後翅
    {
    	public ShapePart X0Y0_後翅_後翅根_後翅;

    	public ShapePart X0Y0_後翅_後翅根_翅脈1;

    	public ShapePart X0Y0_後翅_後翅根_翅脈2;

    	public ShapePart X0Y0_後翅_後翅根_翅脈3;

    	public ShapePart X0Y0_後翅_後翅根_翅脈4;

    	public ShapePart X0Y0_後翅_後翅先_後翅;

    	public ShapePart X0Y0_後翅_後翅先_翅脈1;

    	public ShapePart X0Y0_後翅_後翅先_翅脈2;

    	public ShapePart X0Y0_後翅_後翅先_翅脈3;

    	public ShapePart X0Y0_後翅_後翅先_翅脈4;

    	public ShapePart X0Y1_後翅_後翅根_後翅;

    	public ShapePart X0Y1_後翅_後翅根_翅脈1;

    	public ShapePart X0Y1_後翅_後翅根_翅脈2;

    	public ShapePart X0Y1_後翅_後翅根_翅脈3;

    	public ShapePart X0Y1_後翅_後翅根_翅脈4;

    	public ShapePart X0Y1_後翅_後翅先_後翅;

    	public ShapePart X0Y1_後翅_後翅先_翅脈1;

    	public ShapePart X0Y1_後翅_後翅先_翅脈2;

    	public ShapePart X0Y1_後翅_後翅先_翅脈3;

    	public ShapePart X0Y1_後翅_後翅先_翅脈4;

    	public ColorD 後翅_後翅根_後翅CD;

    	public ColorD 後翅_後翅根_翅脈1CD;

    	public ColorD 後翅_後翅根_翅脈2CD;

    	public ColorD 後翅_後翅根_翅脈3CD;

    	public ColorD 後翅_後翅根_翅脈4CD;

    	public ColorD 後翅_後翅先_後翅CD;

    	public ColorD 後翅_後翅先_翅脈1CD;

    	public ColorD 後翅_後翅先_翅脈2CD;

    	public ColorD 後翅_後翅先_翅脈3CD;

    	public ColorD 後翅_後翅先_翅脈4CD;

    	public ColorP X0Y0_後翅_後翅根_後翅CP;

    	public ColorP X0Y0_後翅_後翅根_翅脈1CP;

    	public ColorP X0Y0_後翅_後翅根_翅脈2CP;

    	public ColorP X0Y0_後翅_後翅根_翅脈3CP;

    	public ColorP X0Y0_後翅_後翅根_翅脈4CP;

    	public ColorP X0Y0_後翅_後翅先_後翅CP;

    	public ColorP X0Y0_後翅_後翅先_翅脈1CP;

    	public ColorP X0Y0_後翅_後翅先_翅脈2CP;

    	public ColorP X0Y0_後翅_後翅先_翅脈3CP;

    	public ColorP X0Y0_後翅_後翅先_翅脈4CP;

    	public ColorP X0Y1_後翅_後翅根_後翅CP;

    	public ColorP X0Y1_後翅_後翅根_翅脈1CP;

    	public ColorP X0Y1_後翅_後翅根_翅脈2CP;

    	public ColorP X0Y1_後翅_後翅根_翅脈3CP;

    	public ColorP X0Y1_後翅_後翅根_翅脈4CP;

    	public ColorP X0Y1_後翅_後翅先_後翅CP;

    	public ColorP X0Y1_後翅_後翅先_翅脈1CP;

    	public ColorP X0Y1_後翅_後翅先_翅脈2CP;

    	public ColorP X0Y1_後翅_後翅先_翅脈3CP;

    	public ColorP X0Y1_後翅_後翅先_翅脈4CP;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    			Body.IndexY = (欠損_ ? 1 : 0);
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

    	public bool 後翅_後翅根_後翅_表示
    	{
    		get
    		{
    			return X0Y0_後翅_後翅根_後翅.Dra;
    		}
    		set
    		{
    			X0Y0_後翅_後翅根_後翅.Dra = value;
    			X0Y1_後翅_後翅根_後翅.Dra = value;
    			X0Y0_後翅_後翅根_後翅.Hit = value;
    			X0Y1_後翅_後翅根_後翅.Hit = value;
    		}
    	}

    	public bool 後翅_後翅根_翅脈1_表示
    	{
    		get
    		{
    			return X0Y0_後翅_後翅根_翅脈1.Dra;
    		}
    		set
    		{
    			X0Y0_後翅_後翅根_翅脈1.Dra = value;
    			X0Y1_後翅_後翅根_翅脈1.Dra = value;
    			X0Y0_後翅_後翅根_翅脈1.Hit = value;
    			X0Y1_後翅_後翅根_翅脈1.Hit = value;
    		}
    	}

    	public bool 後翅_後翅根_翅脈2_表示
    	{
    		get
    		{
    			return X0Y0_後翅_後翅根_翅脈2.Dra;
    		}
    		set
    		{
    			X0Y0_後翅_後翅根_翅脈2.Dra = value;
    			X0Y1_後翅_後翅根_翅脈2.Dra = value;
    			X0Y0_後翅_後翅根_翅脈2.Hit = value;
    			X0Y1_後翅_後翅根_翅脈2.Hit = value;
    		}
    	}

    	public bool 後翅_後翅根_翅脈3_表示
    	{
    		get
    		{
    			return X0Y0_後翅_後翅根_翅脈3.Dra;
    		}
    		set
    		{
    			X0Y0_後翅_後翅根_翅脈3.Dra = value;
    			X0Y1_後翅_後翅根_翅脈3.Dra = value;
    			X0Y0_後翅_後翅根_翅脈3.Hit = value;
    			X0Y1_後翅_後翅根_翅脈3.Hit = value;
    		}
    	}

    	public bool 後翅_後翅根_翅脈4_表示
    	{
    		get
    		{
    			return X0Y0_後翅_後翅根_翅脈4.Dra;
    		}
    		set
    		{
    			X0Y0_後翅_後翅根_翅脈4.Dra = value;
    			X0Y1_後翅_後翅根_翅脈4.Dra = value;
    			X0Y0_後翅_後翅根_翅脈4.Hit = value;
    			X0Y1_後翅_後翅根_翅脈4.Hit = value;
    		}
    	}

    	public bool 後翅_後翅先_後翅_表示
    	{
    		get
    		{
    			return X0Y0_後翅_後翅先_後翅.Dra;
    		}
    		set
    		{
    			X0Y0_後翅_後翅先_後翅.Dra = value;
    			X0Y1_後翅_後翅先_後翅.Dra = value;
    			X0Y0_後翅_後翅先_後翅.Hit = value;
    			X0Y1_後翅_後翅先_後翅.Hit = value;
    		}
    	}

    	public bool 後翅_後翅先_翅脈1_表示
    	{
    		get
    		{
    			return X0Y0_後翅_後翅先_翅脈1.Dra;
    		}
    		set
    		{
    			X0Y0_後翅_後翅先_翅脈1.Dra = value;
    			X0Y1_後翅_後翅先_翅脈1.Dra = value;
    			X0Y0_後翅_後翅先_翅脈1.Hit = value;
    			X0Y1_後翅_後翅先_翅脈1.Hit = value;
    		}
    	}

    	public bool 後翅_後翅先_翅脈2_表示
    	{
    		get
    		{
    			return X0Y0_後翅_後翅先_翅脈2.Dra;
    		}
    		set
    		{
    			X0Y0_後翅_後翅先_翅脈2.Dra = value;
    			X0Y1_後翅_後翅先_翅脈2.Dra = value;
    			X0Y0_後翅_後翅先_翅脈2.Hit = value;
    			X0Y1_後翅_後翅先_翅脈2.Hit = value;
    		}
    	}

    	public bool 後翅_後翅先_翅脈3_表示
    	{
    		get
    		{
    			return X0Y0_後翅_後翅先_翅脈3.Dra;
    		}
    		set
    		{
    			X0Y0_後翅_後翅先_翅脈3.Dra = value;
    			X0Y1_後翅_後翅先_翅脈3.Dra = value;
    			X0Y0_後翅_後翅先_翅脈3.Hit = value;
    			X0Y1_後翅_後翅先_翅脈3.Hit = value;
    		}
    	}

    	public bool 後翅_後翅先_翅脈4_表示
    	{
    		get
    		{
    			return X0Y0_後翅_後翅先_翅脈4.Dra;
    		}
    		set
    		{
    			X0Y0_後翅_後翅先_翅脈4.Dra = value;
    			X0Y1_後翅_後翅先_翅脈4.Dra = value;
    			X0Y0_後翅_後翅先_翅脈4.Hit = value;
    			X0Y1_後翅_後翅先_翅脈4.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 後翅_後翅根_後翅_表示;
    		}
    		set
    		{
    			後翅_後翅根_後翅_表示 = value;
    			後翅_後翅根_翅脈1_表示 = value;
    			後翅_後翅根_翅脈2_表示 = value;
    			後翅_後翅根_翅脈3_表示 = value;
    			後翅_後翅根_翅脈4_表示 = value;
    			後翅_後翅先_後翅_表示 = value;
    			後翅_後翅先_翅脈1_表示 = value;
    			後翅_後翅先_翅脈2_表示 = value;
    			後翅_後翅先_翅脈3_表示 = value;
    			後翅_後翅先_翅脈4_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 後翅_後翅根_後翅CD.不透明度;
    		}
    		set
    		{
    			後翅_後翅根_後翅CD.不透明度 = value;
    			後翅_後翅根_翅脈1CD.不透明度 = value;
    			後翅_後翅根_翅脈2CD.不透明度 = value;
    			後翅_後翅根_翅脈3CD.不透明度 = value;
    			後翅_後翅根_翅脈4CD.不透明度 = value;
    			後翅_後翅先_後翅CD.不透明度 = value;
    			後翅_後翅先_翅脈1CD.不透明度 = value;
    			後翅_後翅先_翅脈2CD.不透明度 = value;
    			後翅_後翅先_翅脈3CD.不透明度 = value;
    			後翅_後翅先_翅脈4CD.不透明度 = value;
    		}
    	}

    	public double 展開
    	{
    		set
    		{
    			double num = value.Inverse();
    			double num2 = (右 ? (-1.0) : 1.0);
    			X0Y0_後翅_後翅根_後翅.AngleCont = num2 * -77.0 * num;
    			X0Y0_後翅_後翅先_後翅.AngleCont = num2 * -180.0 * num;
    			X0Y1_後翅_後翅根_後翅.AngleCont = num2 * -77.0 * num;
    			X0Y1_後翅_後翅先_後翅.AngleCont = num2 * -180.0 * num;
    			foreach (ShapePart item in Body.EnumAllPar())
    			{
    				item.SizeCont = 0.35 + 0.65 * value;
    			}
    		}
    	}

    	public 後翅_甲(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 後翅_甲D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.肢左["後翅"][0]);
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		PartGroup partGroup = Body[0][0]["後翅"].ToPars();
    		PartGroup pars2 = partGroup["後翅根"].ToPars();
    		X0Y0_後翅_後翅根_後翅 = pars2["後翅"].ToPar();
    		X0Y0_後翅_後翅根_翅脈1 = pars2["翅脈1"].ToPar();
    		X0Y0_後翅_後翅根_翅脈2 = pars2["翅脈2"].ToPar();
    		X0Y0_後翅_後翅根_翅脈3 = pars2["翅脈3"].ToPar();
    		X0Y0_後翅_後翅根_翅脈4 = pars2["翅脈4"].ToPar();
    		pars2 = partGroup["後翅先"].ToPars();
    		X0Y0_後翅_後翅先_後翅 = pars2["後翅"].ToPar();
    		X0Y0_後翅_後翅先_翅脈1 = pars2["翅脈1"].ToPar();
    		X0Y0_後翅_後翅先_翅脈2 = pars2["翅脈2"].ToPar();
    		X0Y0_後翅_後翅先_翅脈3 = pars2["翅脈3"].ToPar();
    		X0Y0_後翅_後翅先_翅脈4 = pars2["翅脈4"].ToPar();
    		PartGroup pars3 = Body[0][1]["後翅"].ToPars();
    		pars2 = pars3["後翅根"].ToPars();
    		X0Y1_後翅_後翅根_後翅 = pars2["後翅"].ToPar();
    		X0Y1_後翅_後翅根_翅脈1 = pars2["翅脈1"].ToPar();
    		X0Y1_後翅_後翅根_翅脈2 = pars2["翅脈2"].ToPar();
    		X0Y1_後翅_後翅根_翅脈3 = pars2["翅脈3"].ToPar();
    		X0Y1_後翅_後翅根_翅脈4 = pars2["翅脈4"].ToPar();
    		pars2 = pars3["後翅先"].ToPars();
    		X0Y1_後翅_後翅先_後翅 = pars2["後翅"].ToPar();
    		X0Y1_後翅_後翅先_翅脈1 = pars2["翅脈1"].ToPar();
    		X0Y1_後翅_後翅先_翅脈2 = pars2["翅脈2"].ToPar();
    		X0Y1_後翅_後翅先_翅脈3 = pars2["翅脈3"].ToPar();
    		X0Y1_後翅_後翅先_翅脈4 = pars2["翅脈4"].ToPar();
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
    		後翅_後翅根_後翅_表示 = e.後翅_後翅根_後翅_表示;
    		後翅_後翅根_翅脈1_表示 = e.後翅_後翅根_翅脈1_表示;
    		後翅_後翅根_翅脈2_表示 = e.後翅_後翅根_翅脈2_表示;
    		後翅_後翅根_翅脈3_表示 = e.後翅_後翅根_翅脈3_表示;
    		後翅_後翅根_翅脈4_表示 = e.後翅_後翅根_翅脈4_表示;
    		後翅_後翅先_後翅_表示 = e.後翅_後翅先_後翅_表示;
    		後翅_後翅先_翅脈1_表示 = e.後翅_後翅先_翅脈1_表示;
    		後翅_後翅先_翅脈2_表示 = e.後翅_後翅先_翅脈2_表示;
    		後翅_後翅先_翅脈3_表示 = e.後翅_後翅先_翅脈3_表示;
    		後翅_後翅先_翅脈4_表示 = e.後翅_後翅先_翅脈4_表示;
    		展開 = e.展開;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_後翅_後翅根_後翅CP = new ColorP(X0Y0_後翅_後翅根_後翅, 後翅_後翅根_後翅CD, DisUnit, abj: true);
    		X0Y0_後翅_後翅根_翅脈1CP = new ColorP(X0Y0_後翅_後翅根_翅脈1, 後翅_後翅根_翅脈1CD, DisUnit, abj: true);
    		X0Y0_後翅_後翅根_翅脈2CP = new ColorP(X0Y0_後翅_後翅根_翅脈2, 後翅_後翅根_翅脈2CD, DisUnit, abj: true);
    		X0Y0_後翅_後翅根_翅脈3CP = new ColorP(X0Y0_後翅_後翅根_翅脈3, 後翅_後翅根_翅脈3CD, DisUnit, abj: true);
    		X0Y0_後翅_後翅根_翅脈4CP = new ColorP(X0Y0_後翅_後翅根_翅脈4, 後翅_後翅根_翅脈4CD, DisUnit, abj: true);
    		X0Y0_後翅_後翅先_後翅CP = new ColorP(X0Y0_後翅_後翅先_後翅, 後翅_後翅先_後翅CD, DisUnit, abj: true);
    		X0Y0_後翅_後翅先_翅脈1CP = new ColorP(X0Y0_後翅_後翅先_翅脈1, 後翅_後翅先_翅脈1CD, DisUnit, abj: true);
    		X0Y0_後翅_後翅先_翅脈2CP = new ColorP(X0Y0_後翅_後翅先_翅脈2, 後翅_後翅先_翅脈2CD, DisUnit, abj: true);
    		X0Y0_後翅_後翅先_翅脈3CP = new ColorP(X0Y0_後翅_後翅先_翅脈3, 後翅_後翅先_翅脈3CD, DisUnit, abj: true);
    		X0Y0_後翅_後翅先_翅脈4CP = new ColorP(X0Y0_後翅_後翅先_翅脈4, 後翅_後翅先_翅脈4CD, DisUnit, abj: true);
    		X0Y1_後翅_後翅根_後翅CP = new ColorP(X0Y1_後翅_後翅根_後翅, 後翅_後翅根_後翅CD, DisUnit, abj: true);
    		X0Y1_後翅_後翅根_翅脈1CP = new ColorP(X0Y1_後翅_後翅根_翅脈1, 後翅_後翅根_翅脈1CD, DisUnit, abj: true);
    		X0Y1_後翅_後翅根_翅脈2CP = new ColorP(X0Y1_後翅_後翅根_翅脈2, 後翅_後翅根_翅脈2CD, DisUnit, abj: true);
    		X0Y1_後翅_後翅根_翅脈3CP = new ColorP(X0Y1_後翅_後翅根_翅脈3, 後翅_後翅根_翅脈3CD, DisUnit, abj: true);
    		X0Y1_後翅_後翅根_翅脈4CP = new ColorP(X0Y1_後翅_後翅根_翅脈4, 後翅_後翅根_翅脈4CD, DisUnit, abj: true);
    		X0Y1_後翅_後翅先_後翅CP = new ColorP(X0Y1_後翅_後翅先_後翅, 後翅_後翅先_後翅CD, DisUnit, abj: true);
    		X0Y1_後翅_後翅先_翅脈1CP = new ColorP(X0Y1_後翅_後翅先_翅脈1, 後翅_後翅先_翅脈1CD, DisUnit, abj: true);
    		X0Y1_後翅_後翅先_翅脈2CP = new ColorP(X0Y1_後翅_後翅先_翅脈2, 後翅_後翅先_翅脈2CD, DisUnit, abj: true);
    		X0Y1_後翅_後翅先_翅脈3CP = new ColorP(X0Y1_後翅_後翅先_翅脈3, 後翅_後翅先_翅脈3CD, DisUnit, abj: true);
    		X0Y1_後翅_後翅先_翅脈4CP = new ColorP(X0Y1_後翅_後翅先_翅脈4, 後翅_後翅先_翅脈4CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_後翅_後翅根_後翅.AngleBase = num * 0.0;
    		X0Y1_後翅_後翅根_後翅.AngleBase = num * 0.0;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexY == 0)
    		{
    			X0Y0_後翅_後翅根_後翅CP.Update();
    			X0Y0_後翅_後翅根_翅脈1CP.Update();
    			X0Y0_後翅_後翅根_翅脈2CP.Update();
    			X0Y0_後翅_後翅根_翅脈3CP.Update();
    			X0Y0_後翅_後翅根_翅脈4CP.Update();
    			X0Y0_後翅_後翅先_後翅CP.Update();
    			X0Y0_後翅_後翅先_翅脈1CP.Update();
    			X0Y0_後翅_後翅先_翅脈2CP.Update();
    			X0Y0_後翅_後翅先_翅脈3CP.Update();
    			X0Y0_後翅_後翅先_翅脈4CP.Update();
    		}
    		else
    		{
    			X0Y1_後翅_後翅根_後翅CP.Update();
    			X0Y1_後翅_後翅根_翅脈1CP.Update();
    			X0Y1_後翅_後翅根_翅脈2CP.Update();
    			X0Y1_後翅_後翅根_翅脈3CP.Update();
    			X0Y1_後翅_後翅根_翅脈4CP.Update();
    			X0Y1_後翅_後翅先_後翅CP.Update();
    			X0Y1_後翅_後翅先_翅脈1CP.Update();
    			X0Y1_後翅_後翅先_翅脈2CP.Update();
    			X0Y1_後翅_後翅先_翅脈3CP.Update();
    			X0Y1_後翅_後翅先_翅脈4CP.Update();
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		Col.Alpha(ref 体配色.甲1O, 128, out var ret);
    		後翅_後翅根_後翅CD = new ColorD(ref Col.Black, ref ret);
    		後翅_後翅根_翅脈1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		後翅_後翅根_翅脈2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		後翅_後翅根_翅脈3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		後翅_後翅根_翅脈4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		後翅_後翅先_後翅CD = new ColorD(ref Col.Black, ref 後翅_後翅根_後翅CD.c2);
    		後翅_後翅先_翅脈1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		後翅_後翅先_翅脈2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		後翅_後翅先_翅脈3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		後翅_後翅先_翅脈4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    	}
    }
}
