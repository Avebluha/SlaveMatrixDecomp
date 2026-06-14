using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 上着ボトム_前掛け : 上着ボトム
    {
    	public ShapePart X0Y0_帯;

    	public ShapePart X0Y0_巻;

    	public ShapePart X0Y0_縁後_縁左;

    	public ShapePart X0Y0_縁後_縁右;

    	public ShapePart X0Y0_前掛_前掛1;

    	public ShapePart X0Y0_前掛_前掛2;

    	public ShapePart X0Y0_前掛_前掛3;

    	public ShapePart X0Y0_縁前_縁左;

    	public ShapePart X0Y0_縁前_縁右;

    	public ShapePart X0Y0_縁前_縁中;

    	public ShapePart X0Y1_帯;

    	public ShapePart X0Y1_巻;

    	public ShapePart X0Y1_縁後_縁左;

    	public ShapePart X0Y1_縁後_縁右;

    	public ShapePart X0Y1_前掛_前掛1;

    	public ShapePart X0Y1_前掛_前掛2;

    	public ShapePart X0Y1_縁前_縁左;

    	public ShapePart X0Y1_縁前_縁右;

    	public ShapePart X0Y1_縁前_縁中;

    	public ColorD 帯CD;

    	public ColorD 巻CD;

    	public ColorD 縁後_縁左CD;

    	public ColorD 縁後_縁右CD;

    	public ColorD 前掛_前掛1CD;

    	public ColorD 前掛_前掛2CD;

    	public ColorD 前掛_前掛3CD;

    	public ColorD 縁前_縁左CD;

    	public ColorD 縁前_縁右CD;

    	public ColorD 縁前_縁中CD;

    	public ColorP X0Y0_帯CP;

    	public ColorP X0Y0_巻CP;

    	public ColorP X0Y0_縁後_縁左CP;

    	public ColorP X0Y0_縁後_縁右CP;

    	public ColorP X0Y0_前掛_前掛1CP;

    	public ColorP X0Y0_前掛_前掛2CP;

    	public ColorP X0Y0_前掛_前掛3CP;

    	public ColorP X0Y0_縁前_縁左CP;

    	public ColorP X0Y0_縁前_縁右CP;

    	public ColorP X0Y0_縁前_縁中CP;

    	public ColorP X0Y1_帯CP;

    	public ColorP X0Y1_巻CP;

    	public ColorP X0Y1_縁後_縁左CP;

    	public ColorP X0Y1_縁後_縁右CP;

    	public ColorP X0Y1_前掛_前掛1CP;

    	public ColorP X0Y1_前掛_前掛2CP;

    	public ColorP X0Y1_縁前_縁左CP;

    	public ColorP X0Y1_縁前_縁右CP;

    	public ColorP X0Y1_縁前_縁中CP;

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

    	public bool 帯_表示
    	{
    		get
    		{
    			return X0Y0_帯.Dra;
    		}
    		set
    		{
    			X0Y0_帯.Dra = value;
    			X0Y1_帯.Dra = value;
    			X0Y0_帯.Hit = false;
    			X0Y1_帯.Hit = false;
    		}
    	}

    	public bool 巻_表示
    	{
    		get
    		{
    			return X0Y0_巻.Dra;
    		}
    		set
    		{
    			X0Y0_巻.Dra = value;
    			X0Y1_巻.Dra = value;
    			X0Y0_巻.Hit = false;
    			X0Y1_巻.Hit = false;
    		}
    	}

    	public bool 縁後_縁左_表示
    	{
    		get
    		{
    			return X0Y0_縁後_縁左.Dra;
    		}
    		set
    		{
    			X0Y0_縁後_縁左.Dra = value;
    			X0Y1_縁後_縁左.Dra = value;
    			X0Y0_縁後_縁左.Hit = false;
    			X0Y1_縁後_縁左.Hit = false;
    		}
    	}

    	public bool 縁後_縁右_表示
    	{
    		get
    		{
    			return X0Y0_縁後_縁右.Dra;
    		}
    		set
    		{
    			X0Y0_縁後_縁右.Dra = value;
    			X0Y1_縁後_縁右.Dra = value;
    			X0Y0_縁後_縁右.Hit = false;
    			X0Y1_縁後_縁右.Hit = false;
    		}
    	}

    	public bool 前掛_前掛1_表示
    	{
    		get
    		{
    			return X0Y0_前掛_前掛1.Dra;
    		}
    		set
    		{
    			X0Y0_前掛_前掛1.Dra = value;
    			X0Y1_前掛_前掛1.Dra = value;
    			X0Y0_前掛_前掛1.Hit = false;
    			X0Y1_前掛_前掛1.Hit = false;
    		}
    	}

    	public bool 前掛_前掛2_表示
    	{
    		get
    		{
    			return X0Y0_前掛_前掛2.Dra;
    		}
    		set
    		{
    			X0Y0_前掛_前掛2.Dra = value;
    			X0Y1_前掛_前掛2.Dra = value;
    			X0Y0_前掛_前掛2.Hit = false;
    			X0Y1_前掛_前掛2.Hit = false;
    		}
    	}

    	public bool 前掛_前掛3_表示
    	{
    		get
    		{
    			return X0Y0_前掛_前掛3.Dra;
    		}
    		set
    		{
    			X0Y0_前掛_前掛3.Dra = value;
    			X0Y0_前掛_前掛3.Hit = false;
    		}
    	}

    	public bool 縁前_縁左_表示
    	{
    		get
    		{
    			return X0Y0_縁前_縁左.Dra;
    		}
    		set
    		{
    			X0Y0_縁前_縁左.Dra = value;
    			X0Y1_縁前_縁左.Dra = value;
    			X0Y0_縁前_縁左.Hit = false;
    			X0Y1_縁前_縁左.Hit = false;
    		}
    	}

    	public bool 縁前_縁右_表示
    	{
    		get
    		{
    			return X0Y0_縁前_縁右.Dra;
    		}
    		set
    		{
    			X0Y0_縁前_縁右.Dra = value;
    			X0Y1_縁前_縁右.Dra = value;
    			X0Y0_縁前_縁右.Hit = false;
    			X0Y1_縁前_縁右.Hit = false;
    		}
    	}

    	public bool 縁前_縁中_表示
    	{
    		get
    		{
    			return X0Y0_縁前_縁中.Dra;
    		}
    		set
    		{
    			X0Y0_縁前_縁中.Dra = value;
    			X0Y1_縁前_縁中.Dra = value;
    			X0Y0_縁前_縁中.Hit = false;
    			X0Y1_縁前_縁中.Hit = false;
    		}
    	}

    	public bool ベース表示
    	{
    		get
    		{
    			return 帯_表示;
    		}
    		set
    		{
    			帯_表示 = value;
    			巻_表示 = value;
    			前掛_前掛1_表示 = value;
    			前掛_前掛2_表示 = value;
    			前掛_前掛3_表示 = value;
    		}
    	}

    	public bool 縁表示
    	{
    		get
    		{
    			return 縁前_縁左_表示;
    		}
    		set
    		{
    			縁前_縁左_表示 = value;
    			縁前_縁右_表示 = value;
    			縁前_縁中_表示 = value;
    		}
    	}

    	public bool 巻縁表示
    	{
    		get
    		{
    			return 縁後_縁左_表示;
    		}
    		set
    		{
    			縁後_縁左_表示 = value;
    			縁後_縁右_表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 帯_表示;
    		}
    		set
    		{
    			帯_表示 = value;
    			巻_表示 = value;
    			縁後_縁左_表示 = value;
    			縁後_縁右_表示 = value;
    			前掛_前掛1_表示 = value;
    			前掛_前掛2_表示 = value;
    			前掛_前掛3_表示 = value;
    			縁前_縁左_表示 = value;
    			縁前_縁右_表示 = value;
    			縁前_縁中_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 帯CD.不透明度;
    		}
    		set
    		{
    			帯CD.不透明度 = value;
    			巻CD.不透明度 = value;
    			縁後_縁左CD.不透明度 = value;
    			縁後_縁右CD.不透明度 = value;
    			前掛_前掛1CD.不透明度 = value;
    			前掛_前掛2CD.不透明度 = value;
    			前掛_前掛3CD.不透明度 = value;
    			縁前_縁左CD.不透明度 = value;
    			縁前_縁右CD.不透明度 = value;
    			縁前_縁中CD.不透明度 = value;
    		}
    	}

    	public 上着ボトム_前掛け(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 上着ボトム_前掛けD e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(GlobalState.胴体["上着ボトム前"][1]);
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_帯 = partGroup["帯"].ToPar();
    		X0Y0_巻 = partGroup["巻"].ToPar();
    		PartGroup pars2 = partGroup["縁後"].ToPars();
    		X0Y0_縁後_縁左 = pars2["縁左"].ToPar();
    		X0Y0_縁後_縁右 = pars2["縁右"].ToPar();
    		pars2 = partGroup["前掛"].ToPars();
    		X0Y0_前掛_前掛1 = pars2["前掛1"].ToPar();
    		X0Y0_前掛_前掛2 = pars2["前掛2"].ToPar();
    		X0Y0_前掛_前掛3 = pars2["前掛3"].ToPar();
    		pars2 = partGroup["縁前"].ToPars();
    		X0Y0_縁前_縁左 = pars2["縁左"].ToPar();
    		X0Y0_縁前_縁右 = pars2["縁右"].ToPar();
    		X0Y0_縁前_縁中 = pars2["縁中"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_帯 = partGroup["帯"].ToPar();
    		X0Y1_巻 = partGroup["巻"].ToPar();
    		pars2 = partGroup["縁後"].ToPars();
    		X0Y1_縁後_縁左 = pars2["縁左"].ToPar();
    		X0Y1_縁後_縁右 = pars2["縁右"].ToPar();
    		pars2 = partGroup["前掛"].ToPars();
    		X0Y1_前掛_前掛1 = pars2["前掛1"].ToPar();
    		X0Y1_前掛_前掛2 = pars2["前掛2"].ToPar();
    		pars2 = partGroup["縁前"].ToPars();
    		X0Y1_縁前_縁左 = pars2["縁左"].ToPar();
    		X0Y1_縁前_縁右 = pars2["縁右"].ToPar();
    		X0Y1_縁前_縁中 = pars2["縁中"].ToPar();
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
    		帯_表示 = e.帯_表示;
    		巻_表示 = e.巻_表示;
    		縁後_縁左_表示 = e.縁後_縁左_表示;
    		縁後_縁右_表示 = e.縁後_縁右_表示;
    		前掛_前掛1_表示 = e.前掛_前掛1_表示;
    		前掛_前掛2_表示 = e.前掛_前掛2_表示;
    		前掛_前掛3_表示 = e.前掛_前掛3_表示;
    		縁前_縁左_表示 = e.縁前_縁左_表示;
    		縁前_縁右_表示 = e.縁前_縁右_表示;
    		縁前_縁中_表示 = e.縁前_縁中_表示;
    		ベース表示 = e.ベース表示;
    		縁表示 = e.縁表示;
    		巻縁表示 = e.巻縁表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_帯CP = new ColorP(X0Y0_帯, 帯CD, DisUnit, abj: true);
    		X0Y0_巻CP = new ColorP(X0Y0_巻, 巻CD, DisUnit, abj: true);
    		X0Y0_縁後_縁左CP = new ColorP(X0Y0_縁後_縁左, 縁後_縁左CD, DisUnit, abj: true);
    		X0Y0_縁後_縁右CP = new ColorP(X0Y0_縁後_縁右, 縁後_縁右CD, DisUnit, abj: true);
    		X0Y0_前掛_前掛1CP = new ColorP(X0Y0_前掛_前掛1, 前掛_前掛1CD, DisUnit, abj: true);
    		X0Y0_前掛_前掛2CP = new ColorP(X0Y0_前掛_前掛2, 前掛_前掛2CD, DisUnit, abj: true);
    		X0Y0_前掛_前掛3CP = new ColorP(X0Y0_前掛_前掛3, 前掛_前掛3CD, DisUnit, abj: true);
    		X0Y0_縁前_縁左CP = new ColorP(X0Y0_縁前_縁左, 縁前_縁左CD, DisUnit, abj: true);
    		X0Y0_縁前_縁右CP = new ColorP(X0Y0_縁前_縁右, 縁前_縁右CD, DisUnit, abj: true);
    		X0Y0_縁前_縁中CP = new ColorP(X0Y0_縁前_縁中, 縁前_縁中CD, DisUnit, abj: true);
    		X0Y1_帯CP = new ColorP(X0Y1_帯, 帯CD, DisUnit, abj: true);
    		X0Y1_巻CP = new ColorP(X0Y1_巻, 巻CD, DisUnit, abj: true);
    		X0Y1_縁後_縁左CP = new ColorP(X0Y1_縁後_縁左, 縁後_縁左CD, DisUnit, abj: true);
    		X0Y1_縁後_縁右CP = new ColorP(X0Y1_縁後_縁右, 縁後_縁右CD, DisUnit, abj: true);
    		X0Y1_前掛_前掛1CP = new ColorP(X0Y1_前掛_前掛1, 前掛_前掛1CD, DisUnit, abj: true);
    		X0Y1_前掛_前掛2CP = new ColorP(X0Y1_前掛_前掛2, 前掛_前掛2CD, DisUnit, abj: true);
    		X0Y1_縁前_縁左CP = new ColorP(X0Y1_縁前_縁左, 縁前_縁左CD, DisUnit, abj: true);
    		X0Y1_縁前_縁右CP = new ColorP(X0Y1_縁前_縁右, 縁前_縁右CD, DisUnit, abj: true);
    		X0Y1_縁前_縁中CP = new ColorP(X0Y1_縁前_縁中, 縁前_縁中CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		尺度YB = 0.95;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		if (Body.GetIndexY() == 0)
    		{
    			Are.Draw(X0Y0_帯);
    			Are.Draw(X0Y0_巻);
    			Are.Draw(X0Y0_縁後_縁左);
    			Are.Draw(X0Y0_縁後_縁右);
    			return;
    		}
    		Are.Draw(X0Y1_帯);
    		Are.Draw(X0Y1_巻);
    		Are.Draw(X0Y1_縁後_縁左);
    		Are.Draw(X0Y1_縁後_縁右);
    		Are.Draw(X0Y1_前掛_前掛1);
    		Are.Draw(X0Y1_前掛_前掛2);
    		Are.Draw(X0Y1_縁前_縁左);
    		Are.Draw(X0Y1_縁前_縁右);
    		Are.Draw(X0Y1_縁前_縁中);
    	}

    	public void 前(RenderArea Are)
    	{
    		if (Body.GetIndexY() == 0)
    		{
    			Are.Draw(X0Y0_前掛_前掛1);
    			Are.Draw(X0Y0_前掛_前掛2);
    			Are.Draw(X0Y0_前掛_前掛3);
    			Are.Draw(X0Y0_縁前_縁左);
    			Are.Draw(X0Y0_縁前_縁右);
    			Are.Draw(X0Y0_縁前_縁中);
    		}
    	}

    	public override bool Is布(ShapePart p)
    	{
    		if (p != X0Y0_帯 && p != X0Y0_巻 && p != X0Y0_縁後_縁左 && p != X0Y0_縁後_縁右 && p != X0Y0_前掛_前掛1 && p != X0Y0_前掛_前掛2 && p != X0Y0_前掛_前掛3 && p != X0Y0_縁前_縁左 && p != X0Y0_縁前_縁右 && p != X0Y0_縁前_縁中 && p != X0Y1_帯 && p != X0Y1_巻 && p != X0Y1_縁後_縁左 && p != X0Y1_縁後_縁右 && p != X0Y1_前掛_前掛1 && p != X0Y1_前掛_前掛2 && p != X0Y1_縁前_縁左 && p != X0Y1_縁前_縁右)
    		{
    			return p == X0Y1_縁前_縁中;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		if (Body.GetIndexY() == 0)
    		{
    			X0Y0_帯CP.Update();
    			X0Y0_巻CP.Update();
    			X0Y0_縁後_縁左CP.Update();
    			X0Y0_縁後_縁右CP.Update();
    			X0Y0_前掛_前掛1CP.Update();
    			X0Y0_前掛_前掛2CP.Update();
    			X0Y0_前掛_前掛3CP.Update();
    			X0Y0_縁前_縁左CP.Update();
    			X0Y0_縁前_縁右CP.Update();
    			X0Y0_縁前_縁中CP.Update();
    		}
    		else
    		{
    			X0Y1_帯CP.Update();
    			X0Y1_巻CP.Update();
    			X0Y1_縁後_縁左CP.Update();
    			X0Y1_縁後_縁右CP.Update();
    			X0Y1_前掛_前掛1CP.Update();
    			X0Y1_前掛_前掛2CP.Update();
    			X0Y1_縁前_縁左CP.Update();
    			X0Y1_縁前_縁右CP.Update();
    			X0Y1_縁前_縁中CP.Update();
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		帯CD = new ColorD();
    		巻CD = new ColorD();
    		縁後_縁左CD = new ColorD();
    		縁後_縁右CD = new ColorD();
    		前掛_前掛1CD = new ColorD();
    		前掛_前掛2CD = new ColorD();
    		前掛_前掛3CD = new ColorD();
    		縁前_縁左CD = new ColorD();
    		縁前_縁右CD = new ColorD();
    		縁前_縁中CD = new ColorD();
    	}

    	public void 配色(前掛けB色 配色)
    	{
    		帯CD.色 = 配色.紐色;
    		巻CD.色 = 配色.縁色;
    		縁後_縁左CD.色 = 巻CD.色;
    		縁後_縁右CD.色 = 巻CD.色;
    		前掛_前掛1CD.色 = 配色.生地色;
    		前掛_前掛2CD.色 = 前掛_前掛1CD.色;
    		前掛_前掛3CD.色 = 前掛_前掛1CD.色;
    		縁前_縁左CD.色 = 巻CD.色;
    		縁前_縁右CD.色 = 巻CD.色;
    		縁前_縁中CD.色 = 巻CD.色;
    	}
    }
}
