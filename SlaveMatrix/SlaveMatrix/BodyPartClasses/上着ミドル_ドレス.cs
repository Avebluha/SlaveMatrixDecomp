using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 上着ミドル_ドレス : 上着ミドル
    {
    	public Par X0Y0_服;

    	public Par X0Y0_縁_縁左;

    	public Par X0Y0_縁_縁右;

    	public Par X0Y0_柄_柄左_柄1;

    	public Par X0Y0_柄_柄左_柄2_柄1;

    	public Par X0Y0_柄_柄左_柄2_柄2;

    	public Par X0Y0_柄_柄右_柄1;

    	public Par X0Y0_柄_柄右_柄2_柄1;

    	public Par X0Y0_柄_柄右_柄2_柄2;

    	public ColorD 服CD;

    	public ColorD 縁_縁左CD;

    	public ColorD 縁_縁右CD;

    	public ColorD 柄_柄左_柄1CD;

    	public ColorD 柄_柄左_柄2_柄1CD;

    	public ColorD 柄_柄左_柄2_柄2CD;

    	public ColorD 柄_柄右_柄1CD;

    	public ColorD 柄_柄右_柄2_柄1CD;

    	public ColorD 柄_柄右_柄2_柄2CD;

    	public ColorP X0Y0_服CP;

    	public ColorP X0Y0_縁_縁左CP;

    	public ColorP X0Y0_縁_縁右CP;

    	public ColorP X0Y0_柄_柄左_柄1CP;

    	public ColorP X0Y0_柄_柄左_柄2_柄1CP;

    	public ColorP X0Y0_柄_柄左_柄2_柄2CP;

    	public ColorP X0Y0_柄_柄右_柄1CP;

    	public ColorP X0Y0_柄_柄右_柄2_柄1CP;

    	public ColorP X0Y0_柄_柄右_柄2_柄2CP;

    	private Par[] 柄左;

    	private Par[] 柄右;

    	private Vector2D[] mm;

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

    	public bool 服_表示
    	{
    		get
    		{
    			return X0Y0_服.Dra;
    		}
    		set
    		{
    			X0Y0_服.Dra = value;
    			X0Y0_服.Hit = false;
    		}
    	}

    	public bool 縁_縁左_表示
    	{
    		get
    		{
    			return X0Y0_縁_縁左.Dra;
    		}
    		set
    		{
    			X0Y0_縁_縁左.Dra = value;
    			X0Y0_縁_縁左.Hit = false;
    		}
    	}

    	public bool 縁_縁右_表示
    	{
    		get
    		{
    			return X0Y0_縁_縁右.Dra;
    		}
    		set
    		{
    			X0Y0_縁_縁右.Dra = value;
    			X0Y0_縁_縁右.Hit = false;
    		}
    	}

    	public bool 柄_柄左_柄1_表示
    	{
    		get
    		{
    			return X0Y0_柄_柄左_柄1.Dra;
    		}
    		set
    		{
    			X0Y0_柄_柄左_柄1.Dra = value;
    			X0Y0_柄_柄左_柄1.Hit = false;
    		}
    	}

    	public bool 柄_柄左_柄2_柄1_表示
    	{
    		get
    		{
    			return X0Y0_柄_柄左_柄2_柄1.Dra;
    		}
    		set
    		{
    			X0Y0_柄_柄左_柄2_柄1.Dra = value;
    			X0Y0_柄_柄左_柄2_柄1.Hit = false;
    		}
    	}

    	public bool 柄_柄左_柄2_柄2_表示
    	{
    		get
    		{
    			return X0Y0_柄_柄左_柄2_柄2.Dra;
    		}
    		set
    		{
    			X0Y0_柄_柄左_柄2_柄2.Dra = value;
    			X0Y0_柄_柄左_柄2_柄2.Hit = false;
    		}
    	}

    	public bool 柄_柄右_柄1_表示
    	{
    		get
    		{
    			return X0Y0_柄_柄右_柄1.Dra;
    		}
    		set
    		{
    			X0Y0_柄_柄右_柄1.Dra = value;
    			X0Y0_柄_柄右_柄1.Hit = false;
    		}
    	}

    	public bool 柄_柄右_柄2_柄1_表示
    	{
    		get
    		{
    			return X0Y0_柄_柄右_柄2_柄1.Dra;
    		}
    		set
    		{
    			X0Y0_柄_柄右_柄2_柄1.Dra = value;
    			X0Y0_柄_柄右_柄2_柄1.Hit = false;
    		}
    	}

    	public bool 柄_柄右_柄2_柄2_表示
    	{
    		get
    		{
    			return X0Y0_柄_柄右_柄2_柄2.Dra;
    		}
    		set
    		{
    			X0Y0_柄_柄右_柄2_柄2.Dra = value;
    			X0Y0_柄_柄右_柄2_柄2.Hit = false;
    		}
    	}

    	public bool ベース表示
    	{
    		get
    		{
    			return 服_表示;
    		}
    		set
    		{
    			服_表示 = value;
    		}
    	}

    	public bool 縁表示
    	{
    		get
    		{
    			return 縁_縁左_表示;
    		}
    		set
    		{
    			縁_縁左_表示 = value;
    			縁_縁右_表示 = value;
    		}
    	}

    	public bool 柄1表示
    	{
    		get
    		{
    			return 柄_柄左_柄1_表示;
    		}
    		set
    		{
    			柄_柄左_柄1_表示 = value;
    			柄_柄右_柄1_表示 = value;
    		}
    	}

    	public bool 柄2表示
    	{
    		get
    		{
    			return 柄_柄左_柄2_柄1_表示;
    		}
    		set
    		{
    			柄_柄左_柄2_柄1_表示 = value;
    			柄_柄右_柄2_柄1_表示 = value;
    		}
    	}

    	public bool 柄3表示
    	{
    		get
    		{
    			return 柄_柄左_柄2_柄2_表示;
    		}
    		set
    		{
    			柄_柄左_柄2_柄2_表示 = value;
    			柄_柄右_柄2_柄2_表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 服_表示;
    		}
    		set
    		{
    			服_表示 = value;
    			縁_縁左_表示 = value;
    			縁_縁右_表示 = value;
    			柄_柄左_柄1_表示 = value;
    			柄_柄左_柄2_柄1_表示 = value;
    			柄_柄左_柄2_柄2_表示 = value;
    			柄_柄右_柄1_表示 = value;
    			柄_柄右_柄2_柄1_表示 = value;
    			柄_柄右_柄2_柄2_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 服CD.不透明度;
    		}
    		set
    		{
    			服CD.不透明度 = value;
    			縁_縁左CD.不透明度 = value;
    			縁_縁右CD.不透明度 = value;
    			柄_柄左_柄1CD.不透明度 = value;
    			柄_柄左_柄2_柄1CD.不透明度 = value;
    			柄_柄左_柄2_柄2CD.不透明度 = value;
    			柄_柄右_柄1CD.不透明度 = value;
    			柄_柄右_柄2_柄1CD.不透明度 = value;
    			柄_柄右_柄2_柄2CD.不透明度 = value;
    		}
    	}

    	public 上着ミドル_ドレス(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 上着ミドル_ドレスD e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.胴体["上着ミドル"][2]);
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_服 = pars["服"].ToPar();
    		Pars pars2 = pars["縁"].ToPars();
    		X0Y0_縁_縁左 = pars2["縁左"].ToPar();
    		X0Y0_縁_縁右 = pars2["縁右"].ToPar();
    		pars2 = pars["柄"].ToPars();
    		Pars pars3 = pars2["柄左"].ToPars();
    		X0Y0_柄_柄左_柄1 = pars3["柄1"].ToPar();
    		Pars pars4 = pars3["柄2"].ToPars();
    		X0Y0_柄_柄左_柄2_柄1 = pars4["柄1"].ToPar();
    		X0Y0_柄_柄左_柄2_柄2 = pars4["柄2"].ToPar();
    		pars3 = pars2["柄右"].ToPars();
    		X0Y0_柄_柄右_柄1 = pars3["柄1"].ToPar();
    		pars4 = pars3["柄2"].ToPars();
    		X0Y0_柄_柄右_柄2_柄1 = pars4["柄1"].ToPar();
    		X0Y0_柄_柄右_柄2_柄2 = pars4["柄2"].ToPar();
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
    		服_表示 = e.服_表示;
    		縁_縁左_表示 = e.縁_縁左_表示;
    		縁_縁右_表示 = e.縁_縁右_表示;
    		柄_柄左_柄1_表示 = e.柄_柄左_柄1_表示;
    		柄_柄左_柄2_柄1_表示 = e.柄_柄左_柄2_柄1_表示;
    		柄_柄左_柄2_柄2_表示 = e.柄_柄左_柄2_柄2_表示;
    		柄_柄右_柄1_表示 = e.柄_柄右_柄1_表示;
    		柄_柄右_柄2_柄1_表示 = e.柄_柄右_柄2_柄1_表示;
    		柄_柄右_柄2_柄2_表示 = e.柄_柄右_柄2_柄2_表示;
    		ベース表示 = e.ベース表示;
    		縁表示 = e.縁表示;
    		柄1表示 = e.柄1表示;
    		柄2表示 = e.柄2表示;
    		柄3表示 = e.柄3表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_服CP = new ColorP(X0Y0_服, 服CD, DisUnit, abj: true);
    		X0Y0_縁_縁左CP = new ColorP(X0Y0_縁_縁左, 縁_縁左CD, DisUnit, abj: true);
    		X0Y0_縁_縁右CP = new ColorP(X0Y0_縁_縁右, 縁_縁右CD, DisUnit, abj: true);
    		X0Y0_柄_柄左_柄1CP = new ColorP(X0Y0_柄_柄左_柄1, 柄_柄左_柄1CD, DisUnit, abj: true);
    		柄左 = new Par[2] { X0Y0_柄_柄左_柄2_柄1, X0Y0_柄_柄左_柄2_柄2 };
    		X0Y0_柄_柄左_柄2_柄1CP = new ColorP(X0Y0_柄_柄左_柄2_柄1, 柄_柄左_柄2_柄1CD, DisUnit, abj: true);
    		X0Y0_柄_柄左_柄2_柄2CP = new ColorP(X0Y0_柄_柄左_柄2_柄2, 柄_柄左_柄2_柄2CD, DisUnit, abj: true);
    		X0Y0_柄_柄右_柄1CP = new ColorP(X0Y0_柄_柄右_柄1, 柄_柄右_柄1CD, DisUnit, abj: true);
    		柄右 = new Par[2] { X0Y0_柄_柄右_柄2_柄1, X0Y0_柄_柄右_柄2_柄2 };
    		X0Y0_柄_柄右_柄2_柄1CP = new ColorP(X0Y0_柄_柄右_柄2_柄1, 柄_柄右_柄2_柄1CD, DisUnit, abj: true);
    		X0Y0_柄_柄右_柄2_柄2CP = new ColorP(X0Y0_柄_柄右_柄2_柄2, 柄_柄右_柄2_柄2CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    		尺度YB = 0.95;
    	}

    	public override bool Is革(Par p)
    	{
    		if (p != X0Y0_服 && p != X0Y0_縁_縁左 && p != X0Y0_縁_縁右 && p != X0Y0_柄_柄左_柄1 && p != X0Y0_柄_柄左_柄2_柄1 && p != X0Y0_柄_柄左_柄2_柄2 && p != X0Y0_柄_柄右_柄1 && p != X0Y0_柄_柄右_柄2_柄1)
    		{
    			return p == X0Y0_柄_柄右_柄2_柄2;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_服CP.Update();
    		X0Y0_縁_縁左CP.Update();
    		X0Y0_縁_縁右CP.Update();
    		X0Y0_柄_柄左_柄1CP.Update();
    		柄左.GetMiY_MaY(out mm);
    		X0Y0_柄_柄左_柄2_柄1CP.Update(mm);
    		X0Y0_柄_柄左_柄2_柄2CP.Update(mm);
    		X0Y0_柄_柄右_柄1CP.Update();
    		柄右.GetMiY_MaY(out mm);
    		X0Y0_柄_柄右_柄2_柄1CP.Update(mm);
    		X0Y0_柄_柄右_柄2_柄2CP.Update(mm);
    	}

    	public void 色更新(Vector2D[] ドレス, Vector2D[] 縁左, Vector2D[] 縁右)
    	{
    		X0Y0_服CP.Update(ドレス);
    		X0Y0_縁_縁左CP.Update(縁左);
    		X0Y0_縁_縁右CP.Update(縁右);
    		X0Y0_柄_柄左_柄1CP.Update();
    		柄左.GetMiY_MaY(out mm);
    		X0Y0_柄_柄左_柄2_柄1CP.Update(mm);
    		X0Y0_柄_柄左_柄2_柄2CP.Update(mm);
    		X0Y0_柄_柄右_柄1CP.Update();
    		柄右.GetMiY_MaY(out mm);
    		X0Y0_柄_柄右_柄2_柄1CP.Update(mm);
    		X0Y0_柄_柄右_柄2_柄2CP.Update(mm);
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		服CD = new ColorD();
    		縁_縁左CD = new ColorD();
    		縁_縁右CD = new ColorD();
    		柄_柄左_柄1CD = new ColorD();
    		柄_柄左_柄2_柄1CD = new ColorD();
    		柄_柄左_柄2_柄2CD = new ColorD();
    		柄_柄右_柄1CD = new ColorD();
    		柄_柄右_柄2_柄1CD = new ColorD();
    		柄_柄右_柄2_柄2CD = new ColorD();
    	}

    	public void 配色(ドレス色 配色)
    	{
    		服CD.色 = 配色.生地色;
    		縁_縁左CD.色 = 配色.縁色;
    		縁_縁右CD.色 = 縁_縁左CD.色;
    		柄_柄左_柄1CD.色 = 配色.柄色;
    		柄_柄左_柄2_柄1CD.色 = 柄_柄左_柄1CD.色;
    		柄_柄左_柄2_柄2CD.色 = 柄_柄左_柄1CD.色;
    		柄_柄右_柄1CD.色 = 柄_柄左_柄1CD.色;
    		柄_柄右_柄2_柄1CD.色 = 柄_柄左_柄1CD.色;
    		柄_柄右_柄2_柄2CD.色 = 柄_柄左_柄1CD.色;
    	}
    }
}
