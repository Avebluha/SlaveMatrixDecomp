using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 下着トップ_マイクロ : 下着トップ
    {
    	public Par X0Y0_紐;

    	public Par X0Y0_カップ左_紐;

    	public Par X0Y0_カップ左_カップ;

    	public Par X0Y0_カップ左_縁_縁1;

    	public Par X0Y0_カップ左_縁_縁2;

    	public Par X0Y0_カップ左_縁_縁3;

    	public Par X0Y0_カップ左_縁_縁4;

    	public Par X0Y0_カップ右_紐;

    	public Par X0Y0_カップ右_カップ;

    	public Par X0Y0_カップ右_縁_縁1;

    	public Par X0Y0_カップ右_縁_縁2;

    	public Par X0Y0_カップ右_縁_縁3;

    	public Par X0Y0_カップ右_縁_縁4;

    	public ColorD 紐CD;

    	public ColorD カップ左_紐CD;

    	public ColorD カップ左_カップCD;

    	public ColorD カップ左_縁_縁1CD;

    	public ColorD カップ左_縁_縁2CD;

    	public ColorD カップ左_縁_縁3CD;

    	public ColorD カップ左_縁_縁4CD;

    	public ColorD カップ右_紐CD;

    	public ColorD カップ右_カップCD;

    	public ColorD カップ右_縁_縁1CD;

    	public ColorD カップ右_縁_縁2CD;

    	public ColorD カップ右_縁_縁3CD;

    	public ColorD カップ右_縁_縁4CD;

    	public ColorP X0Y0_紐CP;

    	public ColorP X0Y0_カップ左_紐CP;

    	public ColorP X0Y0_カップ左_カップCP;

    	public ColorP X0Y0_カップ左_縁_縁1CP;

    	public ColorP X0Y0_カップ左_縁_縁2CP;

    	public ColorP X0Y0_カップ左_縁_縁3CP;

    	public ColorP X0Y0_カップ左_縁_縁4CP;

    	public ColorP X0Y0_カップ右_紐CP;

    	public ColorP X0Y0_カップ右_カップCP;

    	public ColorP X0Y0_カップ右_縁_縁1CP;

    	public ColorP X0Y0_カップ右_縁_縁2CP;

    	public ColorP X0Y0_カップ右_縁_縁3CP;

    	public ColorP X0Y0_カップ右_縁_縁4CP;

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

    	public bool 紐_表示
    	{
    		get
    		{
    			return X0Y0_紐.Dra;
    		}
    		set
    		{
    			X0Y0_紐.Dra = value;
    			X0Y0_紐.Hit = false;
    		}
    	}

    	public bool カップ左_紐_表示
    	{
    		get
    		{
    			return X0Y0_カップ左_紐.Dra;
    		}
    		set
    		{
    			X0Y0_カップ左_紐.Dra = value;
    			X0Y0_カップ左_紐.Hit = false;
    		}
    	}

    	public bool カップ左_カップ_表示
    	{
    		get
    		{
    			return X0Y0_カップ左_カップ.Dra;
    		}
    		set
    		{
    			X0Y0_カップ左_カップ.Dra = value;
    			X0Y0_カップ左_カップ.Hit = false;
    		}
    	}

    	public bool カップ左_縁_縁1_表示
    	{
    		get
    		{
    			return X0Y0_カップ左_縁_縁1.Dra;
    		}
    		set
    		{
    			X0Y0_カップ左_縁_縁1.Dra = value;
    			X0Y0_カップ左_縁_縁1.Hit = false;
    		}
    	}

    	public bool カップ左_縁_縁2_表示
    	{
    		get
    		{
    			return X0Y0_カップ左_縁_縁2.Dra;
    		}
    		set
    		{
    			X0Y0_カップ左_縁_縁2.Dra = value;
    			X0Y0_カップ左_縁_縁2.Hit = false;
    		}
    	}

    	public bool カップ左_縁_縁3_表示
    	{
    		get
    		{
    			return X0Y0_カップ左_縁_縁3.Dra;
    		}
    		set
    		{
    			X0Y0_カップ左_縁_縁3.Dra = value;
    			X0Y0_カップ左_縁_縁3.Hit = false;
    		}
    	}

    	public bool カップ左_縁_縁4_表示
    	{
    		get
    		{
    			return X0Y0_カップ左_縁_縁4.Dra;
    		}
    		set
    		{
    			X0Y0_カップ左_縁_縁4.Dra = value;
    			X0Y0_カップ左_縁_縁4.Hit = false;
    		}
    	}

    	public bool カップ右_紐_表示
    	{
    		get
    		{
    			return X0Y0_カップ右_紐.Dra;
    		}
    		set
    		{
    			X0Y0_カップ右_紐.Dra = value;
    			X0Y0_カップ右_紐.Hit = false;
    		}
    	}

    	public bool カップ右_カップ_表示
    	{
    		get
    		{
    			return X0Y0_カップ右_カップ.Dra;
    		}
    		set
    		{
    			X0Y0_カップ右_カップ.Dra = value;
    			X0Y0_カップ右_カップ.Hit = false;
    		}
    	}

    	public bool カップ右_縁_縁1_表示
    	{
    		get
    		{
    			return X0Y0_カップ右_縁_縁1.Dra;
    		}
    		set
    		{
    			X0Y0_カップ右_縁_縁1.Dra = value;
    			X0Y0_カップ右_縁_縁1.Hit = false;
    		}
    	}

    	public bool カップ右_縁_縁2_表示
    	{
    		get
    		{
    			return X0Y0_カップ右_縁_縁2.Dra;
    		}
    		set
    		{
    			X0Y0_カップ右_縁_縁2.Dra = value;
    			X0Y0_カップ右_縁_縁2.Hit = false;
    		}
    	}

    	public bool カップ右_縁_縁3_表示
    	{
    		get
    		{
    			return X0Y0_カップ右_縁_縁3.Dra;
    		}
    		set
    		{
    			X0Y0_カップ右_縁_縁3.Dra = value;
    			X0Y0_カップ右_縁_縁3.Hit = false;
    		}
    	}

    	public bool カップ右_縁_縁4_表示
    	{
    		get
    		{
    			return X0Y0_カップ右_縁_縁4.Dra;
    		}
    		set
    		{
    			X0Y0_カップ右_縁_縁4.Dra = value;
    			X0Y0_カップ右_縁_縁4.Hit = false;
    		}
    	}

    	public bool ベース表示
    	{
    		get
    		{
    			return 紐_表示;
    		}
    		set
    		{
    			紐_表示 = value;
    			カップ左_紐_表示 = value;
    			カップ左_カップ_表示 = value;
    			カップ右_紐_表示 = value;
    			カップ右_カップ_表示 = value;
    		}
    	}

    	public bool 縁1表示
    	{
    		get
    		{
    			return カップ左_縁_縁3_表示;
    		}
    		set
    		{
    			カップ左_縁_縁3_表示 = value;
    			カップ右_縁_縁3_表示 = value;
    		}
    	}

    	public bool 縁2表示
    	{
    		get
    		{
    			return カップ左_縁_縁2_表示;
    		}
    		set
    		{
    			カップ左_縁_縁2_表示 = value;
    			カップ右_縁_縁2_表示 = value;
    		}
    	}

    	public bool 縁3表示
    	{
    		get
    		{
    			return カップ左_縁_縁1_表示;
    		}
    		set
    		{
    			カップ左_縁_縁1_表示 = value;
    			カップ右_縁_縁1_表示 = value;
    		}
    	}

    	public bool 縁4表示
    	{
    		get
    		{
    			return カップ左_縁_縁4_表示;
    		}
    		set
    		{
    			カップ左_縁_縁4_表示 = value;
    			カップ右_縁_縁4_表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 紐_表示;
    		}
    		set
    		{
    			紐_表示 = value;
    			カップ左_紐_表示 = value;
    			カップ左_カップ_表示 = value;
    			カップ左_縁_縁1_表示 = value;
    			カップ左_縁_縁2_表示 = value;
    			カップ左_縁_縁3_表示 = value;
    			カップ左_縁_縁4_表示 = value;
    			カップ右_紐_表示 = value;
    			カップ右_カップ_表示 = value;
    			カップ右_縁_縁1_表示 = value;
    			カップ右_縁_縁2_表示 = value;
    			カップ右_縁_縁3_表示 = value;
    			カップ右_縁_縁4_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 紐CD.不透明度;
    		}
    		set
    		{
    			紐CD.不透明度 = value;
    			カップ左_紐CD.不透明度 = value;
    			カップ左_カップCD.不透明度 = value;
    			カップ左_縁_縁1CD.不透明度 = value;
    			カップ左_縁_縁2CD.不透明度 = value;
    			カップ左_縁_縁3CD.不透明度 = value;
    			カップ左_縁_縁4CD.不透明度 = value;
    			カップ右_紐CD.不透明度 = value;
    			カップ右_カップCD.不透明度 = value;
    			カップ右_縁_縁1CD.不透明度 = value;
    			カップ右_縁_縁2CD.不透明度 = value;
    			カップ右_縁_縁3CD.不透明度 = value;
    			カップ右_縁_縁4CD.不透明度 = value;
    		}
    	}

    	public double バスト
    	{
    		set
    		{
    			double sizeBase = sb * (0.9 + 0.25 * value);
    			X0Y0_カップ左_紐.SizeBase = sizeBase;
    			X0Y0_カップ左_カップ.SizeBase = sizeBase;
    			X0Y0_カップ左_縁_縁1.SizeBase = sizeBase;
    			X0Y0_カップ左_縁_縁2.SizeBase = sizeBase;
    			X0Y0_カップ左_縁_縁3.SizeBase = sizeBase;
    			X0Y0_カップ左_縁_縁4.SizeBase = sizeBase;
    			X0Y0_カップ右_紐.SizeBase = sizeBase;
    			X0Y0_カップ右_カップ.SizeBase = sizeBase;
    			X0Y0_カップ右_縁_縁1.SizeBase = sizeBase;
    			X0Y0_カップ右_縁_縁2.SizeBase = sizeBase;
    			X0Y0_カップ右_縁_縁3.SizeBase = sizeBase;
    			X0Y0_カップ右_縁_縁4.SizeBase = sizeBase;
    			sizeBase = syb * (1.0 + 0.05 * value);
    			X0Y0_カップ左_紐.SizeYBase = sizeBase;
    			X0Y0_カップ左_カップ.SizeYBase = sizeBase;
    			X0Y0_カップ左_縁_縁1.SizeYBase = sizeBase;
    			X0Y0_カップ左_縁_縁2.SizeYBase = sizeBase;
    			X0Y0_カップ左_縁_縁3.SizeYBase = sizeBase;
    			X0Y0_カップ左_縁_縁4.SizeYBase = sizeBase;
    			X0Y0_カップ右_紐.SizeYBase = sizeBase;
    			X0Y0_カップ右_カップ.SizeYBase = sizeBase;
    			X0Y0_カップ右_縁_縁1.SizeYBase = sizeBase;
    			X0Y0_カップ右_縁_縁2.SizeYBase = sizeBase;
    			X0Y0_カップ右_縁_縁3.SizeYBase = sizeBase;
    			X0Y0_カップ右_縁_縁4.SizeYBase = sizeBase;
    			sizeBase = 1.0 + (-0.5 * value + 0.0 * value.Inverse());
    			X0Y0_カップ左_紐.SizeYBase *= sizeBase;
    			X0Y0_カップ右_紐.SizeYBase *= sizeBase;
    			位置C = new Vector2D(位置C.X, -0.003 * 肥大 + -0.003 * value.Inverse());
    		}
    	}

    	public 下着トップ_マイクロ(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 下着トップ_マイクロD e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.胴体["下着トップ"][2]);
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_紐 = pars["紐"].ToPar();
    		Pars pars2 = pars["カップ左"].ToPars();
    		X0Y0_カップ左_紐 = pars2["紐"].ToPar();
    		X0Y0_カップ左_カップ = pars2["カップ"].ToPar();
    		Pars pars3 = pars2["縁"].ToPars();
    		X0Y0_カップ左_縁_縁1 = pars3["縁1"].ToPar();
    		X0Y0_カップ左_縁_縁2 = pars3["縁2"].ToPar();
    		X0Y0_カップ左_縁_縁3 = pars3["縁3"].ToPar();
    		X0Y0_カップ左_縁_縁4 = pars3["縁4"].ToPar();
    		pars2 = pars["カップ右"].ToPars();
    		X0Y0_カップ右_紐 = pars2["紐"].ToPar();
    		X0Y0_カップ右_カップ = pars2["カップ"].ToPar();
    		pars3 = pars2["縁"].ToPars();
    		X0Y0_カップ右_縁_縁1 = pars3["縁1"].ToPar();
    		X0Y0_カップ右_縁_縁2 = pars3["縁2"].ToPar();
    		X0Y0_カップ右_縁_縁3 = pars3["縁3"].ToPar();
    		X0Y0_カップ右_縁_縁4 = pars3["縁4"].ToPar();
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
    		紐_表示 = e.紐_表示;
    		カップ左_紐_表示 = e.カップ左_紐_表示;
    		カップ左_カップ_表示 = e.カップ左_カップ_表示;
    		カップ左_縁_縁1_表示 = e.カップ左_縁_縁1_表示;
    		カップ左_縁_縁2_表示 = e.カップ左_縁_縁2_表示;
    		カップ左_縁_縁3_表示 = e.カップ左_縁_縁3_表示;
    		カップ左_縁_縁4_表示 = e.カップ左_縁_縁4_表示;
    		カップ右_紐_表示 = e.カップ右_紐_表示;
    		カップ右_カップ_表示 = e.カップ右_カップ_表示;
    		カップ右_縁_縁1_表示 = e.カップ右_縁_縁1_表示;
    		カップ右_縁_縁2_表示 = e.カップ右_縁_縁2_表示;
    		カップ右_縁_縁3_表示 = e.カップ右_縁_縁3_表示;
    		カップ右_縁_縁4_表示 = e.カップ右_縁_縁4_表示;
    		ベース表示 = e.ベース表示;
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
    		X0Y0_紐CP = new ColorP(X0Y0_紐, 紐CD, DisUnit, abj: true);
    		X0Y0_カップ左_紐CP = new ColorP(X0Y0_カップ左_紐, カップ左_紐CD, DisUnit, abj: true);
    		X0Y0_カップ左_カップCP = new ColorP(X0Y0_カップ左_カップ, カップ左_カップCD, DisUnit, abj: true);
    		X0Y0_カップ左_縁_縁1CP = new ColorP(X0Y0_カップ左_縁_縁1, カップ左_縁_縁1CD, DisUnit, abj: true);
    		X0Y0_カップ左_縁_縁2CP = new ColorP(X0Y0_カップ左_縁_縁2, カップ左_縁_縁2CD, DisUnit, abj: true);
    		X0Y0_カップ左_縁_縁3CP = new ColorP(X0Y0_カップ左_縁_縁3, カップ左_縁_縁3CD, DisUnit, abj: true);
    		X0Y0_カップ左_縁_縁4CP = new ColorP(X0Y0_カップ左_縁_縁4, カップ左_縁_縁4CD, DisUnit, abj: true);
    		X0Y0_カップ右_紐CP = new ColorP(X0Y0_カップ右_紐, カップ右_紐CD, DisUnit, abj: true);
    		X0Y0_カップ右_カップCP = new ColorP(X0Y0_カップ右_カップ, カップ右_カップCD, DisUnit, abj: true);
    		X0Y0_カップ右_縁_縁1CP = new ColorP(X0Y0_カップ右_縁_縁1, カップ右_縁_縁1CD, DisUnit, abj: true);
    		X0Y0_カップ右_縁_縁2CP = new ColorP(X0Y0_カップ右_縁_縁2, カップ右_縁_縁2CD, DisUnit, abj: true);
    		X0Y0_カップ右_縁_縁3CP = new ColorP(X0Y0_カップ右_縁_縁3, カップ右_縁_縁3CD, DisUnit, abj: true);
    		X0Y0_カップ右_縁_縁4CP = new ColorP(X0Y0_カップ右_縁_縁4, カップ右_縁_縁4CD, DisUnit, abj: true);
    		尺度YB *= 1.1;
    		濃度 = e.濃度;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    	}

    	public override void 描画1(RenderArea Are)
    	{
    		Are.Draw(X0Y0_紐);
    		Are.Draw(X0Y0_カップ左_紐);
    		Are.Draw(X0Y0_カップ左_カップ);
    		Are.Draw(X0Y0_カップ左_縁_縁1);
    		Are.Draw(X0Y0_カップ左_縁_縁2);
    		Are.Draw(X0Y0_カップ左_縁_縁3);
    		Are.Draw(X0Y0_カップ左_縁_縁4);
    		Are.Draw(X0Y0_カップ右_紐);
    		Are.Draw(X0Y0_カップ右_カップ);
    		Are.Draw(X0Y0_カップ右_縁_縁1);
    		Are.Draw(X0Y0_カップ右_縁_縁2);
    		Are.Draw(X0Y0_カップ右_縁_縁3);
    		Are.Draw(X0Y0_カップ右_縁_縁4);
    	}

    	public override bool Is布(Par p)
    	{
    		if (p != X0Y0_紐 && p != X0Y0_カップ左_紐 && p != X0Y0_カップ左_カップ && p != X0Y0_カップ左_縁_縁1 && p != X0Y0_カップ左_縁_縁2 && p != X0Y0_カップ左_縁_縁3 && p != X0Y0_カップ左_縁_縁4 && p != X0Y0_カップ右_紐 && p != X0Y0_カップ右_カップ && p != X0Y0_カップ右_縁_縁1 && p != X0Y0_カップ右_縁_縁2 && p != X0Y0_カップ右_縁_縁3)
    		{
    			return p == X0Y0_カップ右_縁_縁4;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_紐CP.Update();
    		X0Y0_カップ左_紐CP.Update();
    		X0Y0_カップ左_カップCP.Update();
    		X0Y0_カップ左_縁_縁1CP.Update();
    		X0Y0_カップ左_縁_縁2CP.Update();
    		X0Y0_カップ左_縁_縁3CP.Update();
    		X0Y0_カップ左_縁_縁4CP.Update();
    		X0Y0_カップ右_紐CP.Update();
    		X0Y0_カップ右_カップCP.Update();
    		X0Y0_カップ右_縁_縁1CP.Update();
    		X0Y0_カップ右_縁_縁2CP.Update();
    		X0Y0_カップ右_縁_縁3CP.Update();
    		X0Y0_カップ右_縁_縁4CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		紐CD = new ColorD();
    		カップ左_紐CD = new ColorD();
    		カップ左_カップCD = new ColorD();
    		カップ左_縁_縁1CD = new ColorD();
    		カップ左_縁_縁2CD = new ColorD();
    		カップ左_縁_縁3CD = new ColorD();
    		カップ左_縁_縁4CD = new ColorD();
    		カップ右_紐CD = new ColorD();
    		カップ右_カップCD = new ColorD();
    		カップ右_縁_縁1CD = new ColorD();
    		カップ右_縁_縁2CD = new ColorD();
    		カップ右_縁_縁3CD = new ColorD();
    		カップ右_縁_縁4CD = new ColorD();
    	}

    	public void 配色(マイクロT色 配色)
    	{
    		紐CD.色 = 配色.紐色;
    		カップ左_紐CD.色 = 紐CD.色;
    		カップ左_カップCD.色 = 配色.生地色;
    		カップ左_縁_縁1CD.色 = 配色.縁色;
    		カップ左_縁_縁2CD.色 = カップ左_縁_縁1CD.色;
    		カップ左_縁_縁3CD.色 = カップ左_縁_縁1CD.色;
    		カップ左_縁_縁4CD.色 = カップ左_縁_縁1CD.色;
    		カップ右_紐CD.色 = 紐CD.色;
    		カップ右_カップCD.色 = カップ左_カップCD.色;
    		カップ右_縁_縁1CD.色 = カップ左_縁_縁1CD.色;
    		カップ右_縁_縁2CD.色 = カップ左_縁_縁1CD.色;
    		カップ右_縁_縁3CD.色 = カップ左_縁_縁1CD.色;
    		カップ右_縁_縁4CD.色 = カップ左_縁_縁1CD.色;
    	}
    }
}
