using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 胴肌 : Ele
    {
    	public Par X0Y0_植タトゥ_タトゥ花左;

    	public Par X0Y0_植タトゥ_タトゥ花右;

    	public Par X0Y0_植タトゥ_タトゥ花;

    	public Par X0Y0_植タトゥ_タトゥ茎;

    	public Par X0Y0_植タトゥ_タトゥ葉左;

    	public Par X0Y0_植タトゥ_タトゥ葉右;

    	public ColorD 植タトゥ_タトゥ花左CD;

    	public ColorD 植タトゥ_タトゥ花右CD;

    	public ColorD 植タトゥ_タトゥ花CD;

    	public ColorD 植タトゥ_タトゥ茎CD;

    	public ColorD 植タトゥ_タトゥ葉左CD;

    	public ColorD 植タトゥ_タトゥ葉右CD;

    	public ColorP X0Y0_植タトゥ_タトゥ花左CP;

    	public ColorP X0Y0_植タトゥ_タトゥ花右CP;

    	public ColorP X0Y0_植タトゥ_タトゥ花CP;

    	public ColorP X0Y0_植タトゥ_タトゥ茎CP;

    	public ColorP X0Y0_植タトゥ_タトゥ葉左CP;

    	public ColorP X0Y0_植タトゥ_タトゥ葉右CP;

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

    	public bool 植タトゥ_タトゥ花左_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_タトゥ花左.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_タトゥ花左.Dra = value;
    			X0Y0_植タトゥ_タトゥ花左.Hit = value;
    		}
    	}

    	public bool 植タトゥ_タトゥ花右_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_タトゥ花右.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_タトゥ花右.Dra = value;
    			X0Y0_植タトゥ_タトゥ花右.Hit = value;
    		}
    	}

    	public bool 植タトゥ_タトゥ花_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_タトゥ花.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_タトゥ花.Dra = value;
    			X0Y0_植タトゥ_タトゥ花.Hit = value;
    		}
    	}

    	public bool 植タトゥ_タトゥ茎_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_タトゥ茎.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_タトゥ茎.Dra = value;
    			X0Y0_植タトゥ_タトゥ茎.Hit = value;
    		}
    	}

    	public bool 植タトゥ_タトゥ葉左_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_タトゥ葉左.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_タトゥ葉左.Dra = value;
    			X0Y0_植タトゥ_タトゥ葉左.Hit = value;
    		}
    	}

    	public bool 植タトゥ_タトゥ葉右_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_タトゥ葉右.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_タトゥ葉右.Dra = value;
    			X0Y0_植タトゥ_タトゥ葉右.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 植タトゥ_タトゥ花左_表示;
    		}
    		set
    		{
    			植タトゥ_タトゥ花左_表示 = value;
    			植タトゥ_タトゥ花右_表示 = value;
    			植タトゥ_タトゥ花_表示 = value;
    			植タトゥ_タトゥ茎_表示 = value;
    			植タトゥ_タトゥ葉左_表示 = value;
    			植タトゥ_タトゥ葉右_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 植タトゥ_タトゥ花左CD.不透明度;
    		}
    		set
    		{
    			植タトゥ_タトゥ花左CD.不透明度 = value;
    			植タトゥ_タトゥ花右CD.不透明度 = value;
    			植タトゥ_タトゥ花CD.不透明度 = value;
    			植タトゥ_タトゥ茎CD.不透明度 = value;
    			植タトゥ_タトゥ葉左CD.不透明度 = value;
    			植タトゥ_タトゥ葉右CD.不透明度 = value;
    		}
    	}

    	public 胴肌(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 胴肌D e)
    	{
    		ThisType = GetType();
    		本体 = new Difs(Sta.胴体["胴肌"]);
    		Pars pars = 本体[0][0]["植タトゥ"].ToPars();
    		X0Y0_植タトゥ_タトゥ花左 = pars["タトゥ花左"].ToPar();
    		X0Y0_植タトゥ_タトゥ花右 = pars["タトゥ花右"].ToPar();
    		X0Y0_植タトゥ_タトゥ花 = pars["タトゥ花"].ToPar();
    		X0Y0_植タトゥ_タトゥ茎 = pars["タトゥ茎"].ToPar();
    		X0Y0_植タトゥ_タトゥ葉左 = pars["タトゥ葉左"].ToPar();
    		X0Y0_植タトゥ_タトゥ葉右 = pars["タトゥ葉右"].ToPar();
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
    		肥大 = e.肥大;
    		身長 = e.身長;
    		Xv = e.Xv;
    		Yv = e.Yv;
    		Xi = e.Xi;
    		Yi = e.Yi;
    		サイズ = e.サイズ;
    		サイズX = e.サイズX;
    		サイズY = e.サイズY;
    		植タトゥ_タトゥ花左_表示 = e.植タトゥ_タトゥ花左_表示;
    		植タトゥ_タトゥ花右_表示 = e.植タトゥ_タトゥ花右_表示;
    		植タトゥ_タトゥ花_表示 = e.植タトゥ_タトゥ花_表示;
    		植タトゥ_タトゥ茎_表示 = e.植タトゥ_タトゥ茎_表示;
    		植タトゥ_タトゥ葉左_表示 = e.植タトゥ_タトゥ葉左_表示;
    		植タトゥ_タトゥ葉右_表示 = e.植タトゥ_タトゥ葉右_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_植タトゥ_タトゥ花左CP = new ColorP(X0Y0_植タトゥ_タトゥ花左, 植タトゥ_タトゥ花左CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_タトゥ花右CP = new ColorP(X0Y0_植タトゥ_タトゥ花右, 植タトゥ_タトゥ花右CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_タトゥ花CP = new ColorP(X0Y0_植タトゥ_タトゥ花, 植タトゥ_タトゥ花CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_タトゥ茎CP = new ColorP(X0Y0_植タトゥ_タトゥ茎, 植タトゥ_タトゥ茎CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_タトゥ葉左CP = new ColorP(X0Y0_植タトゥ_タトゥ葉左, 植タトゥ_タトゥ葉左CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_タトゥ葉右CP = new ColorP(X0Y0_植タトゥ_タトゥ葉右, 植タトゥ_タトゥ葉右CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    		尺度YB = 0.95;
    	}

    	public override void 色更新()
    	{
    		X0Y0_植タトゥ_タトゥ花左CP.Update();
    		X0Y0_植タトゥ_タトゥ花右CP.Update();
    		X0Y0_植タトゥ_タトゥ花CP.Update();
    		X0Y0_植タトゥ_タトゥ茎CP.Update();
    		X0Y0_植タトゥ_タトゥ葉左CP.Update();
    		X0Y0_植タトゥ_タトゥ葉右CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		植タトゥ_タトゥ花左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_タトゥ花右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_タトゥ花CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_タトゥ茎CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_タトゥ葉左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_タトゥ葉右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    	}
    }
}
