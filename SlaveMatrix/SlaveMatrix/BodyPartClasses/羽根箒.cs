using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 羽根箒 : Ele
    {
    	public Par X0Y0_羽根1;

    	public Par X0Y0_羽根2;

    	public Par X0Y0_羽根3;

    	public Par X0Y0_羽根4;

    	public Par X0Y0_羽根5;

    	public Par X0Y0_羽根;

    	public Par X0Y0_柄;

    	public ColorD 羽根1CD;

    	public ColorD 羽根2CD;

    	public ColorD 羽根3CD;

    	public ColorD 羽根4CD;

    	public ColorD 羽根5CD;

    	public ColorD 羽根CD;

    	public ColorD 柄CD;

    	public ColorP X0Y0_羽根1CP;

    	public ColorP X0Y0_羽根2CP;

    	public ColorP X0Y0_羽根3CP;

    	public ColorP X0Y0_羽根4CP;

    	public ColorP X0Y0_羽根5CP;

    	public ColorP X0Y0_羽根CP;

    	public ColorP X0Y0_柄CP;

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

    	public bool 羽根1_表示
    	{
    		get
    		{
    			return X0Y0_羽根1.Dra;
    		}
    		set
    		{
    			X0Y0_羽根1.Dra = value;
    			X0Y0_羽根1.Hit = value;
    		}
    	}

    	public bool 羽根2_表示
    	{
    		get
    		{
    			return X0Y0_羽根2.Dra;
    		}
    		set
    		{
    			X0Y0_羽根2.Dra = value;
    			X0Y0_羽根2.Hit = value;
    		}
    	}

    	public bool 羽根3_表示
    	{
    		get
    		{
    			return X0Y0_羽根3.Dra;
    		}
    		set
    		{
    			X0Y0_羽根3.Dra = value;
    			X0Y0_羽根3.Hit = value;
    		}
    	}

    	public bool 羽根4_表示
    	{
    		get
    		{
    			return X0Y0_羽根4.Dra;
    		}
    		set
    		{
    			X0Y0_羽根4.Dra = value;
    			X0Y0_羽根4.Hit = value;
    		}
    	}

    	public bool 羽根5_表示
    	{
    		get
    		{
    			return X0Y0_羽根5.Dra;
    		}
    		set
    		{
    			X0Y0_羽根5.Dra = value;
    			X0Y0_羽根5.Hit = value;
    		}
    	}

    	public bool 羽根_表示
    	{
    		get
    		{
    			return X0Y0_羽根.Dra;
    		}
    		set
    		{
    			X0Y0_羽根.Dra = value;
    			X0Y0_羽根.Hit = value;
    		}
    	}

    	public bool 柄_表示
    	{
    		get
    		{
    			return X0Y0_柄.Dra;
    		}
    		set
    		{
    			X0Y0_柄.Dra = value;
    			X0Y0_柄.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 羽根1_表示;
    		}
    		set
    		{
    			羽根1_表示 = value;
    			羽根2_表示 = value;
    			羽根3_表示 = value;
    			羽根4_表示 = value;
    			羽根5_表示 = value;
    			羽根_表示 = value;
    			柄_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 羽根1CD.不透明度;
    		}
    		set
    		{
    			羽根1CD.不透明度 = value;
    			羽根2CD.不透明度 = value;
    			羽根3CD.不透明度 = value;
    			羽根4CD.不透明度 = value;
    			羽根5CD.不透明度 = value;
    			羽根CD.不透明度 = value;
    			柄CD.不透明度 = value;
    		}
    	}

    	public 羽根箒(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 羽根箒D e)
    	{
    		ThisType = GetType();
    		本体 = new Difs(Sta.カーソル["羽根箒"]);
    		Pars pars = 本体[0][0];
    		X0Y0_羽根1 = pars["羽根1"].ToPar();
    		X0Y0_羽根2 = pars["羽根2"].ToPar();
    		X0Y0_羽根3 = pars["羽根3"].ToPar();
    		X0Y0_羽根4 = pars["羽根4"].ToPar();
    		X0Y0_羽根5 = pars["羽根5"].ToPar();
    		X0Y0_羽根 = pars["羽根"].ToPar();
    		X0Y0_柄 = pars["柄"].ToPar();
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
    		羽根1_表示 = e.羽根1_表示;
    		羽根2_表示 = e.羽根2_表示;
    		羽根3_表示 = e.羽根3_表示;
    		羽根4_表示 = e.羽根4_表示;
    		羽根5_表示 = e.羽根5_表示;
    		羽根_表示 = e.羽根_表示;
    		柄_表示 = e.柄_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_羽根1CP = new ColorP(X0Y0_羽根1, 羽根1CD, DisUnit, abj: true);
    		X0Y0_羽根2CP = new ColorP(X0Y0_羽根2, 羽根2CD, DisUnit, abj: true);
    		X0Y0_羽根3CP = new ColorP(X0Y0_羽根3, 羽根3CD, DisUnit, abj: true);
    		X0Y0_羽根4CP = new ColorP(X0Y0_羽根4, 羽根4CD, DisUnit, abj: true);
    		X0Y0_羽根5CP = new ColorP(X0Y0_羽根5, 羽根5CD, DisUnit, abj: true);
    		X0Y0_羽根CP = new ColorP(X0Y0_羽根, 羽根CD, DisUnit, abj: true);
    		X0Y0_柄CP = new ColorP(X0Y0_柄, 柄CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    		本体.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		X0Y0_羽根1CP.Update();
    		X0Y0_羽根2CP.Update();
    		X0Y0_羽根3CP.Update();
    		X0Y0_羽根4CP.Update();
    		X0Y0_羽根5CP.Update();
    		X0Y0_羽根CP.Update();
    		X0Y0_柄CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		Col.GetGrad(ref Col.White, out var ret);
    		羽根1CD = new ColorD(ref Col.Black, ref ret);
    		羽根2CD = new ColorD(ref Col.Black, ref ret);
    		羽根3CD = new ColorD(ref Col.Black, ref ret);
    		羽根4CD = new ColorD(ref Col.Black, ref ret);
    		羽根5CD = new ColorD(ref Col.Black, ref ret);
    		Col.GetGrad(ref Col.White, out ret);
    		羽根CD = new ColorD(ref Col.Black, ref ret);
    		柄CD = new ColorD();
    		柄CD.線 = Col.Black;
    		柄CD.色 = new Color2(ref Col.Black, ref Col.Empty);
    	}
    }
}
