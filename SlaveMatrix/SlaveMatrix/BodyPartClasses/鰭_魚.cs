using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 鰭_魚 : 鰭
    {
    	public Par X0Y0_鰭2_鰭膜;

    	public Par X0Y0_鰭2_鰭条;

    	public Par X0Y0_鰭1_鰭膜;

    	public Par X0Y0_鰭1_鰭条;

    	public Par X0Y1_鰭2_鰭膜;

    	public Par X0Y1_鰭2_鰭条;

    	public Par X0Y1_鰭1_鰭膜;

    	public Par X0Y1_鰭1_鰭条;

    	public ColorD 鰭2_鰭膜CD;

    	public ColorD 鰭2_鰭条CD;

    	public ColorD 鰭1_鰭膜CD;

    	public ColorD 鰭1_鰭条CD;

    	public ColorP X0Y0_鰭2_鰭膜CP;

    	public ColorP X0Y0_鰭2_鰭条CP;

    	public ColorP X0Y0_鰭1_鰭膜CP;

    	public ColorP X0Y0_鰭1_鰭条CP;

    	public ColorP X0Y1_鰭2_鰭膜CP;

    	public ColorP X0Y1_鰭2_鰭条CP;

    	public ColorP X0Y1_鰭1_鰭膜CP;

    	public ColorP X0Y1_鰭1_鰭条CP;

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

    	public bool 鰭2_鰭膜_表示
    	{
    		get
    		{
    			return X0Y0_鰭2_鰭膜.Dra;
    		}
    		set
    		{
    			X0Y0_鰭2_鰭膜.Dra = value;
    			X0Y1_鰭2_鰭膜.Dra = value;
    			X0Y0_鰭2_鰭膜.Hit = value;
    			X0Y1_鰭2_鰭膜.Hit = value;
    		}
    	}

    	public bool 鰭2_鰭条_表示
    	{
    		get
    		{
    			return X0Y0_鰭2_鰭条.Dra;
    		}
    		set
    		{
    			X0Y0_鰭2_鰭条.Dra = value;
    			X0Y1_鰭2_鰭条.Dra = value;
    			X0Y0_鰭2_鰭条.Hit = value;
    			X0Y1_鰭2_鰭条.Hit = value;
    		}
    	}

    	public bool 鰭1_鰭膜_表示
    	{
    		get
    		{
    			return X0Y0_鰭1_鰭膜.Dra;
    		}
    		set
    		{
    			X0Y0_鰭1_鰭膜.Dra = value;
    			X0Y1_鰭1_鰭膜.Dra = value;
    			X0Y0_鰭1_鰭膜.Hit = value;
    			X0Y1_鰭1_鰭膜.Hit = value;
    		}
    	}

    	public bool 鰭1_鰭条_表示
    	{
    		get
    		{
    			return X0Y0_鰭1_鰭条.Dra;
    		}
    		set
    		{
    			X0Y0_鰭1_鰭条.Dra = value;
    			X0Y1_鰭1_鰭条.Dra = value;
    			X0Y0_鰭1_鰭条.Hit = value;
    			X0Y1_鰭1_鰭条.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 鰭2_鰭膜_表示;
    		}
    		set
    		{
    			鰭2_鰭膜_表示 = value;
    			鰭2_鰭条_表示 = value;
    			鰭1_鰭膜_表示 = value;
    			鰭1_鰭条_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 鰭2_鰭膜CD.不透明度;
    		}
    		set
    		{
    			鰭2_鰭膜CD.不透明度 = value;
    			鰭2_鰭条CD.不透明度 = value;
    			鰭1_鰭膜CD.不透明度 = value;
    			鰭1_鰭条CD.不透明度 = value;
    		}
    	}

    	public 鰭_魚(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 鰭_魚D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.肢左["鰭"][0]);
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		Pars pars2 = pars["鰭2"].ToPars();
    		X0Y0_鰭2_鰭膜 = pars2["鰭膜"].ToPar();
    		X0Y0_鰭2_鰭条 = pars2["鰭条"].ToPar();
    		pars2 = pars["鰭1"].ToPars();
    		X0Y0_鰭1_鰭膜 = pars2["鰭膜"].ToPar();
    		X0Y0_鰭1_鰭条 = pars2["鰭条"].ToPar();
    		Pars pars3 = Body[0][1];
    		pars2 = pars3["鰭2"].ToPars();
    		X0Y1_鰭2_鰭膜 = pars2["鰭膜"].ToPar();
    		X0Y1_鰭2_鰭条 = pars2["鰭条"].ToPar();
    		pars2 = pars3["鰭1"].ToPars();
    		X0Y1_鰭1_鰭膜 = pars2["鰭膜"].ToPar();
    		X0Y1_鰭1_鰭条 = pars2["鰭条"].ToPar();
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
    		鰭2_鰭膜_表示 = e.鰭2_鰭膜_表示;
    		鰭2_鰭条_表示 = e.鰭2_鰭条_表示;
    		鰭1_鰭膜_表示 = e.鰭1_鰭膜_表示;
    		鰭1_鰭条_表示 = e.鰭1_鰭条_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_鰭2_鰭膜CP = new ColorP(X0Y0_鰭2_鰭膜, 鰭2_鰭膜CD, DisUnit, abj: true);
    		X0Y0_鰭2_鰭条CP = new ColorP(X0Y0_鰭2_鰭条, 鰭2_鰭条CD, DisUnit, abj: true);
    		X0Y0_鰭1_鰭膜CP = new ColorP(X0Y0_鰭1_鰭膜, 鰭1_鰭膜CD, DisUnit, abj: true);
    		X0Y0_鰭1_鰭条CP = new ColorP(X0Y0_鰭1_鰭条, 鰭1_鰭条CD, DisUnit, abj: true);
    		X0Y1_鰭2_鰭膜CP = new ColorP(X0Y1_鰭2_鰭膜, 鰭2_鰭膜CD, DisUnit, abj: true);
    		X0Y1_鰭2_鰭条CP = new ColorP(X0Y1_鰭2_鰭条, 鰭2_鰭条CD, DisUnit, abj: true);
    		X0Y1_鰭1_鰭膜CP = new ColorP(X0Y1_鰭1_鰭膜, 鰭1_鰭膜CD, DisUnit, abj: true);
    		X0Y1_鰭1_鰭条CP = new ColorP(X0Y1_鰭1_鰭条, 鰭1_鰭条CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_鰭2_鰭膜.AngleBase = num * -25.0;
    		X0Y0_鰭2_鰭条.AngleBase = 0.0;
    		X0Y0_鰭1_鰭膜.AngleBase = 0.0;
    		X0Y0_鰭1_鰭条.AngleBase = 0.0;
    		X0Y1_鰭2_鰭膜.AngleBase = num * -25.0;
    		X0Y1_鰭2_鰭条.AngleBase = 0.0;
    		X0Y1_鰭1_鰭膜.AngleBase = 0.0;
    		X0Y1_鰭1_鰭条.AngleBase = 0.0;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexY == 0)
    		{
    			X0Y0_鰭2_鰭膜CP.Update();
    			X0Y0_鰭2_鰭条CP.Update();
    			X0Y0_鰭1_鰭膜CP.Update();
    			X0Y0_鰭1_鰭条CP.Update();
    		}
    		else
    		{
    			X0Y1_鰭2_鰭膜CP.Update();
    			X0Y1_鰭2_鰭条CP.Update();
    			X0Y1_鰭1_鰭膜CP.Update();
    			X0Y1_鰭1_鰭条CP.Update();
    		}
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		鰭2_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
    		鰭2_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		鰭1_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
    		鰭1_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    	}
    }
}
