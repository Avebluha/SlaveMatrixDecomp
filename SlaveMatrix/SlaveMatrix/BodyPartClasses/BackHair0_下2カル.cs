using _2DGAMELIB;

namespace SlaveMatrix
{
    public class BackHair0_下2カル : お下げ2
    {
    	public ShapePart X0Y0_髪基;

    	public ShapePart X0Y0_お下げ左_髪縛1;

    	public ShapePart X0Y0_お下げ左_髪縛2;

    	public ShapePart X0Y0_お下げ左_髪左;

    	public ShapePart X0Y0_お下げ左_髪右;

    	public ShapePart X0Y0_お下げ左_髪根;

    	public ShapePart X0Y0_お下げ右_髪縛1;

    	public ShapePart X0Y0_お下げ右_髪縛2;

    	public ShapePart X0Y0_お下げ右_髪右;

    	public ShapePart X0Y0_お下げ右_髪左;

    	public ShapePart X0Y0_お下げ右_髪根;

    	public ColorD 髪基CD;

    	public ColorD お下げ左_髪縛1CD;

    	public ColorD お下げ左_髪縛2CD;

    	public ColorD お下げ左_髪左CD;

    	public ColorD お下げ左_髪右CD;

    	public ColorD お下げ左_髪根CD;

    	public ColorD お下げ右_髪縛1CD;

    	public ColorD お下げ右_髪縛2CD;

    	public ColorD お下げ右_髪右CD;

    	public ColorD お下げ右_髪左CD;

    	public ColorD お下げ右_髪根CD;

    	public ColorP X0Y0_髪基CP;

    	public ColorP X0Y0_お下げ左_髪縛1CP;

    	public ColorP X0Y0_お下げ左_髪縛2CP;

    	public ColorP X0Y0_お下げ左_髪左CP;

    	public ColorP X0Y0_お下げ左_髪右CP;

    	public ColorP X0Y0_お下げ左_髪根CP;

    	public ColorP X0Y0_お下げ右_髪縛1CP;

    	public ColorP X0Y0_お下げ右_髪縛2CP;

    	public ColorP X0Y0_お下げ右_髪右CP;

    	public ColorP X0Y0_お下げ右_髪左CP;

    	public ColorP X0Y0_お下げ右_髪根CP;

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

    	public bool 髪基_表示
    	{
    		get
    		{
    			return X0Y0_髪基.Dra;
    		}
    		set
    		{
    			X0Y0_髪基.Dra = value;
    			X0Y0_髪基.Hit = value;
    		}
    	}

    	public override bool お下げ左_髪縛1_表示
    	{
    		get
    		{
    			return X0Y0_お下げ左_髪縛1.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ左_髪縛1.Dra = value;
    			X0Y0_お下げ左_髪縛1.Hit = value;
    		}
    	}

    	public override bool お下げ左_髪縛2_表示
    	{
    		get
    		{
    			return X0Y0_お下げ左_髪縛2.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ左_髪縛2.Dra = value;
    			X0Y0_お下げ左_髪縛2.Hit = value;
    		}
    	}

    	public bool お下げ左_髪左_表示
    	{
    		get
    		{
    			return X0Y0_お下げ左_髪左.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ左_髪左.Dra = value;
    			X0Y0_お下げ左_髪左.Hit = value;
    		}
    	}

    	public bool お下げ左_髪右_表示
    	{
    		get
    		{
    			return X0Y0_お下げ左_髪右.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ左_髪右.Dra = value;
    			X0Y0_お下げ左_髪右.Hit = value;
    		}
    	}

    	public bool お下げ左_髪根_表示
    	{
    		get
    		{
    			return X0Y0_お下げ左_髪根.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ左_髪根.Dra = value;
    			X0Y0_お下げ左_髪根.Hit = value;
    		}
    	}

    	public override bool お下げ右_髪縛1_表示
    	{
    		get
    		{
    			return X0Y0_お下げ右_髪縛1.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ右_髪縛1.Dra = value;
    			X0Y0_お下げ右_髪縛1.Hit = value;
    		}
    	}

    	public override bool お下げ右_髪縛2_表示
    	{
    		get
    		{
    			return X0Y0_お下げ右_髪縛2.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ右_髪縛2.Dra = value;
    			X0Y0_お下げ右_髪縛2.Hit = value;
    		}
    	}

    	public bool お下げ右_髪右_表示
    	{
    		get
    		{
    			return X0Y0_お下げ右_髪右.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ右_髪右.Dra = value;
    			X0Y0_お下げ右_髪右.Hit = value;
    		}
    	}

    	public bool お下げ右_髪左_表示
    	{
    		get
    		{
    			return X0Y0_お下げ右_髪左.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ右_髪左.Dra = value;
    			X0Y0_お下げ右_髪左.Hit = value;
    		}
    	}

    	public bool お下げ右_髪根_表示
    	{
    		get
    		{
    			return X0Y0_お下げ右_髪根.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ右_髪根.Dra = value;
    			X0Y0_お下げ右_髪根.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 髪基_表示;
    		}
    		set
    		{
    			髪基_表示 = value;
    			お下げ左_髪縛1_表示 = value;
    			お下げ左_髪縛2_表示 = value;
    			お下げ左_髪左_表示 = value;
    			お下げ左_髪右_表示 = value;
    			お下げ左_髪根_表示 = value;
    			お下げ右_髪縛1_表示 = value;
    			お下げ右_髪縛2_表示 = value;
    			お下げ右_髪右_表示 = value;
    			お下げ右_髪左_表示 = value;
    			お下げ右_髪根_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 髪基CD.不透明度;
    		}
    		set
    		{
    			髪基CD.不透明度 = value;
    			お下げ左_髪縛1CD.不透明度 = value;
    			お下げ左_髪縛2CD.不透明度 = value;
    			お下げ左_髪左CD.不透明度 = value;
    			お下げ左_髪右CD.不透明度 = value;
    			お下げ左_髪根CD.不透明度 = value;
    			お下げ右_髪縛1CD.不透明度 = value;
    			お下げ右_髪縛2CD.不透明度 = value;
    			お下げ右_髪右CD.不透明度 = value;
    			お下げ右_髪左CD.不透明度 = value;
    			お下げ右_髪根CD.不透明度 = value;
    		}
    	}

    	public double 髪長0
    	{
    		set
    		{
    			double num = 0.7 + 0.3 * value;
    			X0Y0_髪基.SizeYBase *= num;
    		}
    	}

    	public double 髪長1
    	{
    		set
    		{
    			double num = 0.5 + 0.9 * value;
    			X0Y0_お下げ左_髪左.SizeYBase *= num;
    			X0Y0_お下げ左_髪右.SizeYBase *= num;
    			X0Y0_お下げ左_髪根.SizeYBase *= num;
    			X0Y0_お下げ右_髪右.SizeYBase *= num;
    			X0Y0_お下げ右_髪左.SizeYBase *= num;
    			X0Y0_お下げ右_髪根.SizeYBase *= num;
    		}
    	}

    	public double 毛量
    	{
    		set
    		{
    			double num = 1.0 + 0.5 * value;
    			X0Y0_お下げ左_髪縛1.SizeBase *= num;
    			X0Y0_お下げ左_髪縛2.SizeBase *= num;
    			X0Y0_お下げ左_髪左.SizeXBase *= num;
    			X0Y0_お下げ左_髪右.SizeXBase *= num;
    			X0Y0_お下げ左_髪根.SizeXBase *= num;
    			X0Y0_お下げ右_髪縛1.SizeBase *= num;
    			X0Y0_お下げ右_髪縛2.SizeBase *= num;
    			X0Y0_お下げ右_髪右.SizeXBase *= num;
    			X0Y0_お下げ右_髪左.SizeXBase *= num;
    			X0Y0_お下げ右_髪根.SizeXBase *= num;
    		}
    	}

    	public double 広がり
    	{
    		set
    		{
    			X0Y0_お下げ左_髪左.AngleBase = 3.0 * value;
    			X0Y0_お下げ左_髪右.AngleBase = -3.0 * value;
    			X0Y0_お下げ右_髪右.AngleBase = -3.0 * value;
    			X0Y0_お下げ右_髪左.AngleBase = 3.0 * value;
    		}
    	}

    	public BackHair0_下2カル(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, BackHair0_下2カルD e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "下げ2カル";
    		dif.Add(new Pars(Sta.胴体["BackHair0"][0][11]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_髪基 = pars["髪基"].ToPar();
    		Pars pars2 = pars["お下げ左"].ToPars();
    		X0Y0_お下げ左_髪縛1 = pars2["髪縛1"].ToPar();
    		X0Y0_お下げ左_髪縛2 = pars2["髪縛2"].ToPar();
    		X0Y0_お下げ左_髪左 = pars2["髪左"].ToPar();
    		X0Y0_お下げ左_髪右 = pars2["髪右"].ToPar();
    		X0Y0_お下げ左_髪根 = pars2["髪根"].ToPar();
    		pars2 = pars["お下げ右"].ToPars();
    		X0Y0_お下げ右_髪縛1 = pars2["髪縛1"].ToPar();
    		X0Y0_お下げ右_髪縛2 = pars2["髪縛2"].ToPar();
    		X0Y0_お下げ右_髪右 = pars2["髪右"].ToPar();
    		X0Y0_お下げ右_髪左 = pars2["髪左"].ToPar();
    		X0Y0_お下げ右_髪根 = pars2["髪根"].ToPar();
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
    		髪基_表示 = e.髪基_表示;
    		お下げ左_髪縛1_表示 = e.お下げ左_髪縛1_表示;
    		お下げ左_髪縛2_表示 = e.お下げ左_髪縛2_表示;
    		お下げ左_髪左_表示 = e.お下げ左_髪左_表示;
    		お下げ左_髪右_表示 = e.お下げ左_髪右_表示;
    		お下げ左_髪根_表示 = e.お下げ左_髪根_表示;
    		お下げ右_髪縛1_表示 = e.お下げ右_髪縛1_表示;
    		お下げ右_髪縛2_表示 = e.お下げ右_髪縛2_表示;
    		お下げ右_髪右_表示 = e.お下げ右_髪右_表示;
    		お下げ右_髪左_表示 = e.お下げ右_髪左_表示;
    		お下げ右_髪根_表示 = e.お下げ右_髪根_表示;
    		髪長0 = e.髪長0;
    		髪長1 = e.髪長1;
    		毛量 = e.毛量;
    		広がり = e.広がり;
    		if (e.スライム)
    		{
    			スライム();
    		}
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_髪基CP = new ColorP(X0Y0_髪基, 髪基CD, DisUnit, abj: false);
    		X0Y0_お下げ左_髪縛1CP = new ColorP(X0Y0_お下げ左_髪縛1, お下げ左_髪縛1CD, DisUnit, abj: true);
    		X0Y0_お下げ左_髪縛2CP = new ColorP(X0Y0_お下げ左_髪縛2, お下げ左_髪縛2CD, DisUnit, abj: true);
    		X0Y0_お下げ左_髪左CP = new ColorP(X0Y0_お下げ左_髪左, お下げ左_髪左CD, DisUnit, abj: false);
    		X0Y0_お下げ左_髪右CP = new ColorP(X0Y0_お下げ左_髪右, お下げ左_髪右CD, DisUnit, abj: false);
    		X0Y0_お下げ左_髪根CP = new ColorP(X0Y0_お下げ左_髪根, お下げ左_髪根CD, DisUnit, abj: false);
    		X0Y0_お下げ右_髪縛1CP = new ColorP(X0Y0_お下げ右_髪縛1, お下げ右_髪縛1CD, DisUnit, abj: true);
    		X0Y0_お下げ右_髪縛2CP = new ColorP(X0Y0_お下げ右_髪縛2, お下げ右_髪縛2CD, DisUnit, abj: true);
    		X0Y0_お下げ右_髪右CP = new ColorP(X0Y0_お下げ右_髪右, お下げ右_髪右CD, DisUnit, abj: false);
    		X0Y0_お下げ右_髪左CP = new ColorP(X0Y0_お下げ右_髪左, お下げ右_髪左CD, DisUnit, abj: false);
    		X0Y0_お下げ右_髪根CP = new ColorP(X0Y0_お下げ右_髪根, お下げ右_髪根CD, DisUnit, abj: false);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_お下げ左_髪根.AngleBase = num * 10.0;
    		X0Y0_お下げ右_髪根.AngleBase = num * -10.0;
    		Body.JoinPAall();
    	}

    	public void スライム()
    	{
    		X0Y0_髪基.OP[右 ? 1 : 0].Outline = false;
    		X0Y0_髪基.OP[(!右) ? 1 : 0].Outline = false;
    		X0Y0_お下げ左_髪縛1.OP[右 ? 0 : 0].Outline = false;
    		X0Y0_お下げ左_髪縛2.OP[右 ? 0 : 0].Outline = false;
    		X0Y0_お下げ左_髪左.OP[右 ? 12 : 0].Outline = false;
    		X0Y0_お下げ左_髪左.OP[(!右) ? 1 : 11].Outline = false;
    		X0Y0_お下げ左_髪左.OP[右 ? 10 : 2].Outline = false;
    		X0Y0_お下げ左_髪左.OP[右 ? 9 : 3].Outline = false;
    		X0Y0_お下げ左_髪左.OP[右 ? 8 : 4].Outline = false;
    		X0Y0_お下げ左_髪左.OP[右 ? 7 : 5].Outline = false;
    		X0Y0_お下げ左_髪左.OP[右 ? 6 : 6].Outline = false;
    		X0Y0_お下げ左_髪左.OP[右 ? 5 : 7].Outline = false;
    		X0Y0_お下げ左_髪左.OP[右 ? 4 : 8].Outline = false;
    		X0Y0_お下げ左_髪左.OP[右 ? 3 : 9].Outline = false;
    		X0Y0_お下げ左_髪左.OP[右 ? 2 : 10].Outline = false;
    		X0Y0_お下げ左_髪左.OP[右 ? 1 : 11].Outline = false;
    		X0Y0_お下げ左_髪左.OP[(!右) ? 12 : 0].Outline = false;
    		X0Y0_お下げ左_髪右.OP[右 ? 12 : 0].Outline = false;
    		X0Y0_お下げ左_髪右.OP[(!右) ? 1 : 11].Outline = false;
    		X0Y0_お下げ左_髪右.OP[右 ? 10 : 2].Outline = false;
    		X0Y0_お下げ左_髪右.OP[右 ? 9 : 3].Outline = false;
    		X0Y0_お下げ左_髪右.OP[右 ? 8 : 4].Outline = false;
    		X0Y0_お下げ左_髪右.OP[右 ? 7 : 5].Outline = false;
    		X0Y0_お下げ左_髪右.OP[右 ? 6 : 6].Outline = false;
    		X0Y0_お下げ左_髪右.OP[右 ? 5 : 7].Outline = false;
    		X0Y0_お下げ左_髪右.OP[右 ? 4 : 8].Outline = false;
    		X0Y0_お下げ左_髪右.OP[右 ? 3 : 9].Outline = false;
    		X0Y0_お下げ左_髪右.OP[右 ? 2 : 10].Outline = false;
    		X0Y0_お下げ左_髪右.OP[右 ? 1 : 11].Outline = false;
    		X0Y0_お下げ左_髪右.OP[(!右) ? 12 : 0].Outline = false;
    		X0Y0_お下げ左_髪根.OP[右 ? 12 : 0].Outline = false;
    		X0Y0_お下げ左_髪根.OP[(!右) ? 1 : 11].Outline = false;
    		X0Y0_お下げ左_髪根.OP[右 ? 10 : 2].Outline = false;
    		X0Y0_お下げ左_髪根.OP[右 ? 9 : 3].Outline = false;
    		X0Y0_お下げ左_髪根.OP[右 ? 8 : 4].Outline = false;
    		X0Y0_お下げ左_髪根.OP[右 ? 7 : 5].Outline = false;
    		X0Y0_お下げ左_髪根.OP[右 ? 6 : 6].Outline = false;
    		X0Y0_お下げ左_髪根.OP[右 ? 5 : 7].Outline = false;
    		X0Y0_お下げ左_髪根.OP[右 ? 4 : 8].Outline = false;
    		X0Y0_お下げ左_髪根.OP[右 ? 3 : 9].Outline = false;
    		X0Y0_お下げ左_髪根.OP[右 ? 2 : 10].Outline = false;
    		X0Y0_お下げ左_髪根.OP[右 ? 1 : 11].Outline = false;
    		X0Y0_お下げ左_髪根.OP[(!右) ? 12 : 0].Outline = false;
    		X0Y0_お下げ右_髪縛1.OP[右 ? 0 : 0].Outline = false;
    		X0Y0_お下げ右_髪縛2.OP[右 ? 0 : 0].Outline = false;
    		X0Y0_お下げ右_髪右.OP[右 ? 12 : 0].Outline = false;
    		X0Y0_お下げ右_髪右.OP[(!右) ? 1 : 11].Outline = false;
    		X0Y0_お下げ右_髪右.OP[右 ? 10 : 2].Outline = false;
    		X0Y0_お下げ右_髪右.OP[右 ? 9 : 3].Outline = false;
    		X0Y0_お下げ右_髪右.OP[右 ? 8 : 4].Outline = false;
    		X0Y0_お下げ右_髪右.OP[右 ? 7 : 5].Outline = false;
    		X0Y0_お下げ右_髪右.OP[右 ? 6 : 6].Outline = false;
    		X0Y0_お下げ右_髪右.OP[右 ? 5 : 7].Outline = false;
    		X0Y0_お下げ右_髪右.OP[右 ? 4 : 8].Outline = false;
    		X0Y0_お下げ右_髪右.OP[右 ? 3 : 9].Outline = false;
    		X0Y0_お下げ右_髪右.OP[右 ? 2 : 10].Outline = false;
    		X0Y0_お下げ右_髪右.OP[右 ? 1 : 11].Outline = false;
    		X0Y0_お下げ右_髪右.OP[(!右) ? 12 : 0].Outline = false;
    		X0Y0_お下げ右_髪左.OP[右 ? 12 : 0].Outline = false;
    		X0Y0_お下げ右_髪左.OP[(!右) ? 1 : 11].Outline = false;
    		X0Y0_お下げ右_髪左.OP[右 ? 10 : 2].Outline = false;
    		X0Y0_お下げ右_髪左.OP[右 ? 9 : 3].Outline = false;
    		X0Y0_お下げ右_髪左.OP[右 ? 8 : 4].Outline = false;
    		X0Y0_お下げ右_髪左.OP[右 ? 7 : 5].Outline = false;
    		X0Y0_お下げ右_髪左.OP[右 ? 6 : 6].Outline = false;
    		X0Y0_お下げ右_髪左.OP[右 ? 5 : 7].Outline = false;
    		X0Y0_お下げ右_髪左.OP[右 ? 4 : 8].Outline = false;
    		X0Y0_お下げ右_髪左.OP[右 ? 3 : 9].Outline = false;
    		X0Y0_お下げ右_髪左.OP[右 ? 2 : 10].Outline = false;
    		X0Y0_お下げ右_髪左.OP[右 ? 1 : 11].Outline = false;
    		X0Y0_お下げ右_髪左.OP[(!右) ? 12 : 0].Outline = false;
    		X0Y0_お下げ右_髪根.OP[右 ? 12 : 0].Outline = false;
    		X0Y0_お下げ右_髪根.OP[(!右) ? 1 : 11].Outline = false;
    		X0Y0_お下げ右_髪根.OP[右 ? 10 : 2].Outline = false;
    		X0Y0_お下げ右_髪根.OP[右 ? 9 : 3].Outline = false;
    		X0Y0_お下げ右_髪根.OP[右 ? 8 : 4].Outline = false;
    		X0Y0_お下げ右_髪根.OP[右 ? 7 : 5].Outline = false;
    		X0Y0_お下げ右_髪根.OP[右 ? 6 : 6].Outline = false;
    		X0Y0_お下げ右_髪根.OP[右 ? 5 : 7].Outline = false;
    		X0Y0_お下げ右_髪根.OP[右 ? 4 : 8].Outline = false;
    		X0Y0_お下げ右_髪根.OP[右 ? 3 : 9].Outline = false;
    		X0Y0_お下げ右_髪根.OP[右 ? 2 : 10].Outline = false;
    		X0Y0_お下げ右_髪根.OP[右 ? 1 : 11].Outline = false;
    		X0Y0_お下げ右_髪根.OP[(!右) ? 12 : 0].Outline = false;
    	}

    	public override bool Is布(ShapePart p)
    	{
    		if (p != X0Y0_お下げ左_髪縛1 && p != X0Y0_お下げ左_髪縛2 && p != X0Y0_お下げ右_髪縛1)
    		{
    			return p == X0Y0_お下げ右_髪縛2;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_髪基CP.Update();
    		X0Y0_お下げ左_髪縛1CP.Update();
    		X0Y0_お下げ左_髪縛2CP.Update();
    		X0Y0_お下げ左_髪左CP.Update();
    		X0Y0_お下げ左_髪右CP.Update();
    		X0Y0_お下げ左_髪根CP.Update();
    		X0Y0_お下げ右_髪縛1CP.Update();
    		X0Y0_お下げ右_髪縛2CP.Update();
    		X0Y0_お下げ右_髪右CP.Update();
    		X0Y0_お下げ右_髪左CP.Update();
    		X0Y0_お下げ右_髪根CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		髪基CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ左_髪縛1CD = new ColorD();
    		お下げ左_髪縛2CD = new ColorD();
    		お下げ左_髪左CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ左_髪右CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ左_髪根CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ右_髪縛1CD = new ColorD();
    		お下げ右_髪縛2CD = new ColorD();
    		お下げ右_髪右CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ右_髪左CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ右_髪根CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    	}

    	public override void 髪留配色(髪留色 配色左, 髪留色 配色右)
    	{
    		お下げ左_髪縛1CD.色 = 配色左.髪留1色;
    		お下げ左_髪縛2CD.色 = 配色左.髪留2色;
    		お下げ右_髪縛1CD.色 = 配色右.髪留1色;
    		お下げ右_髪縛2CD.色 = 配色右.髪留2色;
    	}
    }
}
