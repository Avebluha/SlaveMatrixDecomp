using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 下着トップ_チューブ : 下着トップ
    {
    	public Par X0Y0_布_布左_布;

    	public Par X0Y0_布_布左_皺_皺1;

    	public Par X0Y0_布_布左_皺_皺2;

    	public Par X0Y0_布_布左_縁_縁1;

    	public Par X0Y0_布_布左_縁_縁2;

    	public Par X0Y0_布_布右_布;

    	public Par X0Y0_布_布右_皺_皺1;

    	public Par X0Y0_布_布右_皺_皺2;

    	public Par X0Y0_布_布右_縁_縁1;

    	public Par X0Y0_布_布右_縁_縁2;

    	public Par X0Y0_布_布;

    	public Par X0Y0_皺_皺1;

    	public Par X0Y0_皺_皺2;

    	public Par X0Y0_縁_縁1;

    	public Par X0Y0_縁_縁2;

    	public ColorD 布_布左_布CD;

    	public ColorD 布_布左_皺_皺1CD;

    	public ColorD 布_布左_皺_皺2CD;

    	public ColorD 布_布左_縁_縁1CD;

    	public ColorD 布_布左_縁_縁2CD;

    	public ColorD 布_布右_布CD;

    	public ColorD 布_布右_皺_皺1CD;

    	public ColorD 布_布右_皺_皺2CD;

    	public ColorD 布_布右_縁_縁1CD;

    	public ColorD 布_布右_縁_縁2CD;

    	public ColorD 布_布CD;

    	public ColorD 皺_皺1CD;

    	public ColorD 皺_皺2CD;

    	public ColorD 縁_縁1CD;

    	public ColorD 縁_縁2CD;

    	public ColorP X0Y0_布_布左_布CP;

    	public ColorP X0Y0_布_布左_皺_皺1CP;

    	public ColorP X0Y0_布_布左_皺_皺2CP;

    	public ColorP X0Y0_布_布左_縁_縁1CP;

    	public ColorP X0Y0_布_布左_縁_縁2CP;

    	public ColorP X0Y0_布_布右_布CP;

    	public ColorP X0Y0_布_布右_皺_皺1CP;

    	public ColorP X0Y0_布_布右_皺_皺2CP;

    	public ColorP X0Y0_布_布右_縁_縁1CP;

    	public ColorP X0Y0_布_布右_縁_縁2CP;

    	public ColorP X0Y0_布_布CP;

    	public ColorP X0Y0_皺_皺1CP;

    	public ColorP X0Y0_皺_皺2CP;

    	public ColorP X0Y0_縁_縁1CP;

    	public ColorP X0Y0_縁_縁2CP;

    	private double sb;

    	private double syb;

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

    	public bool 布_布左_布_表示
    	{
    		get
    		{
    			return X0Y0_布_布左_布.Dra;
    		}
    		set
    		{
    			X0Y0_布_布左_布.Dra = value;
    			X0Y0_布_布左_布.Hit = false;
    		}
    	}

    	public bool 布_布左_皺_皺1_表示
    	{
    		get
    		{
    			return X0Y0_布_布左_皺_皺1.Dra;
    		}
    		set
    		{
    			X0Y0_布_布左_皺_皺1.Dra = value;
    			X0Y0_布_布左_皺_皺1.Hit = false;
    		}
    	}

    	public bool 布_布左_皺_皺2_表示
    	{
    		get
    		{
    			return X0Y0_布_布左_皺_皺2.Dra;
    		}
    		set
    		{
    			X0Y0_布_布左_皺_皺2.Dra = value;
    			X0Y0_布_布左_皺_皺2.Hit = false;
    		}
    	}

    	public bool 布_布左_縁_縁1_表示
    	{
    		get
    		{
    			return X0Y0_布_布左_縁_縁1.Dra;
    		}
    		set
    		{
    			X0Y0_布_布左_縁_縁1.Dra = value;
    			X0Y0_布_布左_縁_縁1.Hit = false;
    		}
    	}

    	public bool 布_布左_縁_縁2_表示
    	{
    		get
    		{
    			return X0Y0_布_布左_縁_縁2.Dra;
    		}
    		set
    		{
    			X0Y0_布_布左_縁_縁2.Dra = value;
    			X0Y0_布_布左_縁_縁2.Hit = false;
    		}
    	}

    	public bool 布_布右_布_表示
    	{
    		get
    		{
    			return X0Y0_布_布右_布.Dra;
    		}
    		set
    		{
    			X0Y0_布_布右_布.Dra = value;
    			X0Y0_布_布右_布.Hit = false;
    		}
    	}

    	public bool 布_布右_皺_皺1_表示
    	{
    		get
    		{
    			return X0Y0_布_布右_皺_皺1.Dra;
    		}
    		set
    		{
    			X0Y0_布_布右_皺_皺1.Dra = value;
    			X0Y0_布_布右_皺_皺1.Hit = false;
    		}
    	}

    	public bool 布_布右_皺_皺2_表示
    	{
    		get
    		{
    			return X0Y0_布_布右_皺_皺2.Dra;
    		}
    		set
    		{
    			X0Y0_布_布右_皺_皺2.Dra = value;
    			X0Y0_布_布右_皺_皺2.Hit = false;
    		}
    	}

    	public bool 布_布右_縁_縁1_表示
    	{
    		get
    		{
    			return X0Y0_布_布右_縁_縁1.Dra;
    		}
    		set
    		{
    			X0Y0_布_布右_縁_縁1.Dra = value;
    			X0Y0_布_布右_縁_縁1.Hit = false;
    		}
    	}

    	public bool 布_布右_縁_縁2_表示
    	{
    		get
    		{
    			return X0Y0_布_布右_縁_縁2.Dra;
    		}
    		set
    		{
    			X0Y0_布_布右_縁_縁2.Dra = value;
    			X0Y0_布_布右_縁_縁2.Hit = false;
    		}
    	}

    	public bool 布_布_表示
    	{
    		get
    		{
    			return X0Y0_布_布.Dra;
    		}
    		set
    		{
    			X0Y0_布_布.Dra = value;
    			X0Y0_布_布.Hit = false;
    		}
    	}

    	public bool 皺_皺1_表示
    	{
    		get
    		{
    			return X0Y0_皺_皺1.Dra;
    		}
    		set
    		{
    			X0Y0_皺_皺1.Dra = value;
    			X0Y0_皺_皺1.Hit = false;
    		}
    	}

    	public bool 皺_皺2_表示
    	{
    		get
    		{
    			return X0Y0_皺_皺2.Dra;
    		}
    		set
    		{
    			X0Y0_皺_皺2.Dra = value;
    			X0Y0_皺_皺2.Hit = false;
    		}
    	}

    	public bool 縁_縁1_表示
    	{
    		get
    		{
    			return X0Y0_縁_縁1.Dra;
    		}
    		set
    		{
    			X0Y0_縁_縁1.Dra = value;
    			X0Y0_縁_縁1.Hit = false;
    		}
    	}

    	public bool 縁_縁2_表示
    	{
    		get
    		{
    			return X0Y0_縁_縁2.Dra;
    		}
    		set
    		{
    			X0Y0_縁_縁2.Dra = value;
    			X0Y0_縁_縁2.Hit = false;
    		}
    	}

    	public bool ベース表示
    	{
    		get
    		{
    			return 布_布左_布_表示;
    		}
    		set
    		{
    			布_布左_布_表示 = value;
    			布_布右_布_表示 = value;
    			布_布_表示 = value;
    		}
    	}

    	public bool 皺1表示
    	{
    		get
    		{
    			return 皺_皺1_表示;
    		}
    		set
    		{
    			皺_皺1_表示 = value;
    		}
    	}

    	public bool 皺2表示
    	{
    		get
    		{
    			return 皺_皺2_表示;
    		}
    		set
    		{
    			皺_皺2_表示 = value;
    		}
    	}

    	public bool 皺3表示
    	{
    		get
    		{
    			return 布_布左_皺_皺1_表示;
    		}
    		set
    		{
    			布_布左_皺_皺1_表示 = value;
    			布_布右_皺_皺1_表示 = value;
    		}
    	}

    	public bool 皺4表示
    	{
    		get
    		{
    			return 布_布左_皺_皺2_表示;
    		}
    		set
    		{
    			布_布左_皺_皺2_表示 = value;
    			布_布右_皺_皺2_表示 = value;
    		}
    	}

    	public bool 縁1表示
    	{
    		get
    		{
    			return 縁_縁1_表示;
    		}
    		set
    		{
    			縁_縁1_表示 = value;
    		}
    	}

    	public bool 縁2表示
    	{
    		get
    		{
    			return 布_布左_縁_縁1_表示;
    		}
    		set
    		{
    			布_布左_縁_縁1_表示 = value;
    			布_布右_縁_縁1_表示 = value;
    		}
    	}

    	public bool 縁3表示
    	{
    		get
    		{
    			return 縁_縁2_表示;
    		}
    		set
    		{
    			縁_縁2_表示 = value;
    		}
    	}

    	public bool 縁4表示
    	{
    		get
    		{
    			return 布_布左_縁_縁2_表示;
    		}
    		set
    		{
    			布_布左_縁_縁2_表示 = value;
    			布_布右_縁_縁2_表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 布_布左_布_表示;
    		}
    		set
    		{
    			布_布左_布_表示 = value;
    			布_布左_皺_皺1_表示 = value;
    			布_布左_皺_皺2_表示 = value;
    			布_布左_縁_縁1_表示 = value;
    			布_布左_縁_縁2_表示 = value;
    			布_布右_布_表示 = value;
    			布_布右_皺_皺1_表示 = value;
    			布_布右_皺_皺2_表示 = value;
    			布_布右_縁_縁1_表示 = value;
    			布_布右_縁_縁2_表示 = value;
    			布_布_表示 = value;
    			皺_皺1_表示 = value;
    			皺_皺2_表示 = value;
    			縁_縁1_表示 = value;
    			縁_縁2_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 布_布左_布CD.不透明度;
    		}
    		set
    		{
    			布_布左_布CD.不透明度 = value;
    			布_布左_皺_皺1CD.不透明度 = value;
    			布_布左_皺_皺2CD.不透明度 = value;
    			布_布左_縁_縁1CD.不透明度 = value;
    			布_布左_縁_縁2CD.不透明度 = value;
    			布_布右_布CD.不透明度 = value;
    			布_布右_皺_皺1CD.不透明度 = value;
    			布_布右_皺_皺2CD.不透明度 = value;
    			布_布右_縁_縁1CD.不透明度 = value;
    			布_布右_縁_縁2CD.不透明度 = value;
    			布_布CD.不透明度 = value;
    			皺_皺1CD.不透明度 = value;
    			皺_皺2CD.不透明度 = value;
    			縁_縁1CD.不透明度 = value;
    			縁_縁2CD.不透明度 = value;
    		}
    	}

    	public double バスト
    	{
    		set
    		{
    			double num = 0.9 + 0.24 * value;
    			double sizeBase = sb * num;
    			X0Y0_布_布.SizeBase = sizeBase;
    			X0Y0_皺_皺1.SizeBase = sizeBase;
    			X0Y0_皺_皺2.SizeBase = sizeBase;
    			X0Y0_縁_縁1.SizeBase = sizeBase;
    			X0Y0_縁_縁2.SizeBase = sizeBase;
    			double num2 = syb * num;
    			num = 1.0 + 0.05 * value;
    			sizeBase = syb * num;
    			if (num2 < 1.0)
    			{
    				num2 *= num;
    			}
    			X0Y0_布_布.SizeYBase = sizeBase;
    			X0Y0_皺_皺1.SizeYBase = sizeBase;
    			X0Y0_皺_皺2.SizeYBase = sizeBase;
    			X0Y0_縁_縁1.SizeYBase = sizeBase;
    			X0Y0_縁_縁2.SizeYBase = sizeBase;
    			X0Y0_布_布左_布.SizeYBase = num2;
    			X0Y0_布_布左_皺_皺1.SizeYBase = num2;
    			X0Y0_布_布左_皺_皺2.SizeYBase = num2;
    			X0Y0_布_布左_縁_縁1.SizeYBase = num2;
    			X0Y0_布_布左_縁_縁2.SizeYBase = num2;
    			X0Y0_布_布右_布.SizeYBase = num2;
    			X0Y0_布_布右_皺_皺1.SizeYBase = num2;
    			X0Y0_布_布右_皺_皺2.SizeYBase = num2;
    			X0Y0_布_布右_縁_縁1.SizeYBase = num2;
    			X0Y0_布_布右_縁_縁2.SizeYBase = num2;
    			位置C = new Vector2D(位置C.X, -0.001 * 肥大);
    		}
    	}

    	public 下着トップ_チューブ(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 下着トップ_チューブD e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.胴体["下着トップ"][3]);
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars = 本体[0][0];
    		Pars pars2 = pars["布"].ToPars();
    		Pars pars3 = pars2["布左"].ToPars();
    		X0Y0_布_布左_布 = pars3["布"].ToPar();
    		Pars pars4 = pars3["皺"].ToPars();
    		X0Y0_布_布左_皺_皺1 = pars4["皺1"].ToPar();
    		X0Y0_布_布左_皺_皺2 = pars4["皺2"].ToPar();
    		pars4 = pars3["縁"].ToPars();
    		X0Y0_布_布左_縁_縁1 = pars4["縁1"].ToPar();
    		X0Y0_布_布左_縁_縁2 = pars4["縁2"].ToPar();
    		pars3 = pars2["布右"].ToPars();
    		X0Y0_布_布右_布 = pars3["布"].ToPar();
    		pars4 = pars3["皺"].ToPars();
    		X0Y0_布_布右_皺_皺1 = pars4["皺1"].ToPar();
    		X0Y0_布_布右_皺_皺2 = pars4["皺2"].ToPar();
    		pars4 = pars3["縁"].ToPars();
    		X0Y0_布_布右_縁_縁1 = pars4["縁1"].ToPar();
    		X0Y0_布_布右_縁_縁2 = pars4["縁2"].ToPar();
    		X0Y0_布_布 = pars2["布"].ToPar();
    		pars2 = pars["皺"].ToPars();
    		X0Y0_皺_皺1 = pars2["皺1"].ToPar();
    		X0Y0_皺_皺2 = pars2["皺2"].ToPar();
    		pars2 = pars["縁"].ToPars();
    		X0Y0_縁_縁1 = pars2["縁1"].ToPar();
    		X0Y0_縁_縁2 = pars2["縁2"].ToPar();
    		本体.SetJoints();
    		接続根 = new JointD(本体);
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
    		sb = 尺度B;
    		syb = 尺度YB;
    		肥大 = e.肥大;
    		身長 = e.身長;
    		Xv = e.Xv;
    		Yv = e.Yv;
    		Xi = e.Xi;
    		Yi = e.Yi;
    		サイズ = e.サイズ;
    		サイズX = e.サイズX;
    		サイズY = e.サイズY;
    		布_布左_布_表示 = e.布_布左_布_表示;
    		布_布左_皺_皺1_表示 = e.布_布左_皺_皺1_表示;
    		布_布左_皺_皺2_表示 = e.布_布左_皺_皺2_表示;
    		布_布左_縁_縁1_表示 = e.布_布左_縁_縁1_表示;
    		布_布左_縁_縁2_表示 = e.布_布左_縁_縁2_表示;
    		布_布右_布_表示 = e.布_布右_布_表示;
    		布_布右_皺_皺1_表示 = e.布_布右_皺_皺1_表示;
    		布_布右_皺_皺2_表示 = e.布_布右_皺_皺2_表示;
    		布_布右_縁_縁1_表示 = e.布_布右_縁_縁1_表示;
    		布_布右_縁_縁2_表示 = e.布_布右_縁_縁2_表示;
    		布_布_表示 = e.布_布_表示;
    		皺_皺1_表示 = e.皺_皺1_表示;
    		皺_皺2_表示 = e.皺_皺2_表示;
    		縁_縁1_表示 = e.縁_縁1_表示;
    		縁_縁2_表示 = e.縁_縁2_表示;
    		ベース表示 = e.ベース表示;
    		皺1表示 = e.皺1表示;
    		皺2表示 = e.皺2表示;
    		皺3表示 = e.皺3表示;
    		皺4表示 = e.皺4表示;
    		縁1表示 = e.縁1表示;
    		縁2表示 = e.縁2表示;
    		縁3表示 = e.縁3表示;
    		縁4表示 = e.縁4表示;
    		バスト = e.バスト;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_布_布左_布CP = new ColorP(X0Y0_布_布左_布, 布_布左_布CD, DisUnit, abj: true);
    		X0Y0_布_布左_皺_皺1CP = new ColorP(X0Y0_布_布左_皺_皺1, 布_布左_皺_皺1CD, DisUnit, abj: true);
    		X0Y0_布_布左_皺_皺2CP = new ColorP(X0Y0_布_布左_皺_皺2, 布_布左_皺_皺2CD, DisUnit, abj: true);
    		X0Y0_布_布左_縁_縁1CP = new ColorP(X0Y0_布_布左_縁_縁1, 布_布左_縁_縁1CD, DisUnit, abj: true);
    		X0Y0_布_布左_縁_縁2CP = new ColorP(X0Y0_布_布左_縁_縁2, 布_布左_縁_縁2CD, DisUnit, abj: true);
    		X0Y0_布_布右_布CP = new ColorP(X0Y0_布_布右_布, 布_布右_布CD, DisUnit, abj: true);
    		X0Y0_布_布右_皺_皺1CP = new ColorP(X0Y0_布_布右_皺_皺1, 布_布右_皺_皺1CD, DisUnit, abj: true);
    		X0Y0_布_布右_皺_皺2CP = new ColorP(X0Y0_布_布右_皺_皺2, 布_布右_皺_皺2CD, DisUnit, abj: true);
    		X0Y0_布_布右_縁_縁1CP = new ColorP(X0Y0_布_布右_縁_縁1, 布_布右_縁_縁1CD, DisUnit, abj: true);
    		X0Y0_布_布右_縁_縁2CP = new ColorP(X0Y0_布_布右_縁_縁2, 布_布右_縁_縁2CD, DisUnit, abj: true);
    		X0Y0_布_布CP = new ColorP(X0Y0_布_布, 布_布CD, DisUnit, abj: true);
    		X0Y0_皺_皺1CP = new ColorP(X0Y0_皺_皺1, 皺_皺1CD, DisUnit, abj: true);
    		X0Y0_皺_皺2CP = new ColorP(X0Y0_皺_皺2, 皺_皺2CD, DisUnit, abj: true);
    		X0Y0_縁_縁1CP = new ColorP(X0Y0_縁_縁1, 縁_縁1CD, DisUnit, abj: true);
    		X0Y0_縁_縁2CP = new ColorP(X0Y0_縁_縁2, 縁_縁2CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_布_布左_布);
    		Are.Draw(X0Y0_布_布左_皺_皺1);
    		Are.Draw(X0Y0_布_布左_皺_皺2);
    		Are.Draw(X0Y0_布_布左_縁_縁1);
    		Are.Draw(X0Y0_布_布左_縁_縁2);
    		Are.Draw(X0Y0_布_布右_布);
    		Are.Draw(X0Y0_布_布右_皺_皺1);
    		Are.Draw(X0Y0_布_布右_皺_皺2);
    		Are.Draw(X0Y0_布_布右_縁_縁1);
    		Are.Draw(X0Y0_布_布右_縁_縁2);
    	}

    	public override void 描画1(RenderArea Are)
    	{
    		Are.Draw(X0Y0_布_布);
    		Are.Draw(X0Y0_皺_皺1);
    		Are.Draw(X0Y0_皺_皺2);
    		Are.Draw(X0Y0_縁_縁1);
    		Are.Draw(X0Y0_縁_縁2);
    	}

    	public override bool Is布(Par p)
    	{
    		if (p != X0Y0_布_布左_布 && p != X0Y0_布_布左_皺_皺1 && p != X0Y0_布_布左_皺_皺2 && p != X0Y0_布_布左_縁_縁1 && p != X0Y0_布_布左_縁_縁2 && p != X0Y0_布_布右_布 && p != X0Y0_布_布右_皺_皺1 && p != X0Y0_布_布右_皺_皺2 && p != X0Y0_布_布右_縁_縁1 && p != X0Y0_布_布右_縁_縁2 && p != X0Y0_布_布 && p != X0Y0_皺_皺1 && p != X0Y0_皺_皺2 && p != X0Y0_縁_縁1)
    		{
    			return p == X0Y0_縁_縁2;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_布_布左_布CP.Update();
    		X0Y0_布_布左_皺_皺1CP.Update();
    		X0Y0_布_布左_皺_皺2CP.Update();
    		X0Y0_布_布左_縁_縁1CP.Update();
    		X0Y0_布_布左_縁_縁2CP.Update();
    		X0Y0_布_布右_布CP.Update();
    		X0Y0_布_布右_皺_皺1CP.Update();
    		X0Y0_布_布右_皺_皺2CP.Update();
    		X0Y0_布_布右_縁_縁1CP.Update();
    		X0Y0_布_布右_縁_縁2CP.Update();
    		X0Y0_布_布CP.Update();
    		X0Y0_皺_皺1CP.Update();
    		X0Y0_皺_皺2CP.Update();
    		X0Y0_縁_縁1CP.Update();
    		X0Y0_縁_縁2CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		布_布左_布CD = new ColorD();
    		布_布左_皺_皺1CD = new ColorD();
    		布_布左_皺_皺2CD = new ColorD();
    		布_布左_縁_縁1CD = new ColorD();
    		布_布左_縁_縁2CD = new ColorD();
    		布_布右_布CD = new ColorD();
    		布_布右_皺_皺1CD = new ColorD();
    		布_布右_皺_皺2CD = new ColorD();
    		布_布右_縁_縁1CD = new ColorD();
    		布_布右_縁_縁2CD = new ColorD();
    		布_布CD = new ColorD();
    		皺_皺1CD = new ColorD();
    		皺_皺2CD = new ColorD();
    		縁_縁1CD = new ColorD();
    		縁_縁2CD = new ColorD();
    	}

    	public void 配色(チューブT色 配色)
    	{
    		布_布左_布CD.色 = 配色.生地色;
    		布_布左_皺_皺1CD.色 = 配色.生地色;
    		布_布左_皺_皺2CD.色 = 配色.生地色;
    		布_布左_縁_縁1CD.色 = 配色.縁色;
    		布_布左_縁_縁2CD.色 = 配色.縁色;
    		布_布右_布CD.色 = 配色.生地色;
    		布_布右_皺_皺1CD.色 = 配色.生地色;
    		布_布右_皺_皺2CD.色 = 配色.生地色;
    		布_布右_縁_縁1CD.色 = 配色.縁色;
    		布_布右_縁_縁2CD.色 = 配色.縁色;
    		布_布CD.色 = 配色.生地色;
    		皺_皺1CD.色 = 配色.生地色;
    		皺_皺2CD.色 = 配色.生地色;
    		縁_縁1CD.色 = 配色.縁色;
    		縁_縁2CD.色 = 配色.縁色;
    	}
    }
}
