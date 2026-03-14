using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 尾鰭_魚 : 尾鰭
    {
    	public Par X0Y0_鰭左2_鰭膜;

    	public Par X0Y0_鰭左2_鰭条;

    	public Par X0Y0_鰭右2_鰭膜;

    	public Par X0Y0_鰭右2_鰭条;

    	public Par X0Y0_鰭左1_鰭膜;

    	public Par X0Y0_鰭左1_鰭条;

    	public Par X0Y0_鰭右1_鰭膜;

    	public Par X0Y0_鰭右1_鰭条;

    	public Par X0Y0_尾_尾;

    	public Par X0Y0_尾_鱗右3;

    	public Par X0Y0_尾_鱗左3;

    	public Par X0Y0_尾_鱗右2;

    	public Par X0Y0_尾_鱗左2;

    	public Par X0Y0_尾_鱗右1;

    	public Par X0Y0_尾_鱗左1;

    	public Par X0Y1_鰭左2_鰭膜;

    	public Par X0Y1_鰭左2_鰭条;

    	public Par X0Y1_鰭右2_鰭膜;

    	public Par X0Y1_鰭右2_鰭条;

    	public Par X0Y1_鰭左1_鰭膜;

    	public Par X0Y1_鰭左1_鰭条;

    	public Par X0Y1_鰭右1_鰭膜;

    	public Par X0Y1_鰭右1_鰭条;

    	public Par X0Y1_尾_尾;

    	public Par X0Y1_尾_鱗右3;

    	public Par X0Y1_尾_鱗左3;

    	public Par X0Y1_尾_鱗右2;

    	public Par X0Y1_尾_鱗左2;

    	public Par X0Y1_尾_鱗右1;

    	public Par X0Y1_尾_鱗左1;

    	public ColorD 鰭左2_鰭膜CD;

    	public ColorD 鰭左2_鰭条CD;

    	public ColorD 鰭右2_鰭膜CD;

    	public ColorD 鰭右2_鰭条CD;

    	public ColorD 鰭左1_鰭膜CD;

    	public ColorD 鰭左1_鰭条CD;

    	public ColorD 鰭右1_鰭膜CD;

    	public ColorD 鰭右1_鰭条CD;

    	public ColorD 尾_尾CD;

    	public ColorD 尾_鱗右3CD;

    	public ColorD 尾_鱗左3CD;

    	public ColorD 尾_鱗右2CD;

    	public ColorD 尾_鱗左2CD;

    	public ColorD 尾_鱗右1CD;

    	public ColorD 尾_鱗左1CD;

    	public ColorP X0Y0_鰭左2_鰭膜CP;

    	public ColorP X0Y0_鰭左2_鰭条CP;

    	public ColorP X0Y0_鰭右2_鰭膜CP;

    	public ColorP X0Y0_鰭右2_鰭条CP;

    	public ColorP X0Y0_鰭左1_鰭膜CP;

    	public ColorP X0Y0_鰭左1_鰭条CP;

    	public ColorP X0Y0_鰭右1_鰭膜CP;

    	public ColorP X0Y0_鰭右1_鰭条CP;

    	public ColorP X0Y0_尾_尾CP;

    	public ColorP X0Y0_尾_鱗右3CP;

    	public ColorP X0Y0_尾_鱗左3CP;

    	public ColorP X0Y0_尾_鱗右2CP;

    	public ColorP X0Y0_尾_鱗左2CP;

    	public ColorP X0Y0_尾_鱗右1CP;

    	public ColorP X0Y0_尾_鱗左1CP;

    	public ColorP X0Y1_鰭左2_鰭膜CP;

    	public ColorP X0Y1_鰭左2_鰭条CP;

    	public ColorP X0Y1_鰭右2_鰭膜CP;

    	public ColorP X0Y1_鰭右2_鰭条CP;

    	public ColorP X0Y1_鰭左1_鰭膜CP;

    	public ColorP X0Y1_鰭左1_鰭条CP;

    	public ColorP X0Y1_鰭右1_鰭膜CP;

    	public ColorP X0Y1_鰭右1_鰭条CP;

    	public ColorP X0Y1_尾_尾CP;

    	public ColorP X0Y1_尾_鱗右3CP;

    	public ColorP X0Y1_尾_鱗左3CP;

    	public ColorP X0Y1_尾_鱗右2CP;

    	public ColorP X0Y1_尾_鱗左2CP;

    	public ColorP X0Y1_尾_鱗右1CP;

    	public ColorP X0Y1_尾_鱗左1CP;

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

    	public bool 鰭左2_鰭膜_表示
    	{
    		get
    		{
    			return X0Y0_鰭左2_鰭膜.Dra;
    		}
    		set
    		{
    			X0Y0_鰭左2_鰭膜.Dra = value;
    			X0Y1_鰭左2_鰭膜.Dra = value;
    			X0Y0_鰭左2_鰭膜.Hit = value;
    			X0Y1_鰭左2_鰭膜.Hit = value;
    		}
    	}

    	public bool 鰭左2_鰭条_表示
    	{
    		get
    		{
    			return X0Y0_鰭左2_鰭条.Dra;
    		}
    		set
    		{
    			X0Y0_鰭左2_鰭条.Dra = value;
    			X0Y1_鰭左2_鰭条.Dra = value;
    			X0Y0_鰭左2_鰭条.Hit = value;
    			X0Y1_鰭左2_鰭条.Hit = value;
    		}
    	}

    	public bool 鰭右2_鰭膜_表示
    	{
    		get
    		{
    			return X0Y0_鰭右2_鰭膜.Dra;
    		}
    		set
    		{
    			X0Y0_鰭右2_鰭膜.Dra = value;
    			X0Y1_鰭右2_鰭膜.Dra = value;
    			X0Y0_鰭右2_鰭膜.Hit = value;
    			X0Y1_鰭右2_鰭膜.Hit = value;
    		}
    	}

    	public bool 鰭右2_鰭条_表示
    	{
    		get
    		{
    			return X0Y0_鰭右2_鰭条.Dra;
    		}
    		set
    		{
    			X0Y0_鰭右2_鰭条.Dra = value;
    			X0Y1_鰭右2_鰭条.Dra = value;
    			X0Y0_鰭右2_鰭条.Hit = value;
    			X0Y1_鰭右2_鰭条.Hit = value;
    		}
    	}

    	public bool 鰭左1_鰭膜_表示
    	{
    		get
    		{
    			return X0Y0_鰭左1_鰭膜.Dra;
    		}
    		set
    		{
    			X0Y0_鰭左1_鰭膜.Dra = value;
    			X0Y1_鰭左1_鰭膜.Dra = value;
    			X0Y0_鰭左1_鰭膜.Hit = value;
    			X0Y1_鰭左1_鰭膜.Hit = value;
    		}
    	}

    	public bool 鰭左1_鰭条_表示
    	{
    		get
    		{
    			return X0Y0_鰭左1_鰭条.Dra;
    		}
    		set
    		{
    			X0Y0_鰭左1_鰭条.Dra = value;
    			X0Y1_鰭左1_鰭条.Dra = value;
    			X0Y0_鰭左1_鰭条.Hit = value;
    			X0Y1_鰭左1_鰭条.Hit = value;
    		}
    	}

    	public bool 鰭右1_鰭膜_表示
    	{
    		get
    		{
    			return X0Y0_鰭右1_鰭膜.Dra;
    		}
    		set
    		{
    			X0Y0_鰭右1_鰭膜.Dra = value;
    			X0Y1_鰭右1_鰭膜.Dra = value;
    			X0Y0_鰭右1_鰭膜.Hit = value;
    			X0Y1_鰭右1_鰭膜.Hit = value;
    		}
    	}

    	public bool 鰭右1_鰭条_表示
    	{
    		get
    		{
    			return X0Y0_鰭右1_鰭条.Dra;
    		}
    		set
    		{
    			X0Y0_鰭右1_鰭条.Dra = value;
    			X0Y1_鰭右1_鰭条.Dra = value;
    			X0Y0_鰭右1_鰭条.Hit = value;
    			X0Y1_鰭右1_鰭条.Hit = value;
    		}
    	}

    	public bool 尾_尾_表示
    	{
    		get
    		{
    			return X0Y0_尾_尾.Dra;
    		}
    		set
    		{
    			X0Y0_尾_尾.Dra = value;
    			X0Y1_尾_尾.Dra = value;
    			X0Y0_尾_尾.Hit = value;
    			X0Y1_尾_尾.Hit = value;
    		}
    	}

    	public bool 尾_鱗右3_表示
    	{
    		get
    		{
    			return X0Y0_尾_鱗右3.Dra;
    		}
    		set
    		{
    			X0Y0_尾_鱗右3.Dra = value;
    			X0Y1_尾_鱗右3.Dra = value;
    			X0Y0_尾_鱗右3.Hit = value;
    			X0Y1_尾_鱗右3.Hit = value;
    		}
    	}

    	public bool 尾_鱗左3_表示
    	{
    		get
    		{
    			return X0Y0_尾_鱗左3.Dra;
    		}
    		set
    		{
    			X0Y0_尾_鱗左3.Dra = value;
    			X0Y1_尾_鱗左3.Dra = value;
    			X0Y0_尾_鱗左3.Hit = value;
    			X0Y1_尾_鱗左3.Hit = value;
    		}
    	}

    	public bool 尾_鱗右2_表示
    	{
    		get
    		{
    			return X0Y0_尾_鱗右2.Dra;
    		}
    		set
    		{
    			X0Y0_尾_鱗右2.Dra = value;
    			X0Y1_尾_鱗右2.Dra = value;
    			X0Y0_尾_鱗右2.Hit = value;
    			X0Y1_尾_鱗右2.Hit = value;
    		}
    	}

    	public bool 尾_鱗左2_表示
    	{
    		get
    		{
    			return X0Y0_尾_鱗左2.Dra;
    		}
    		set
    		{
    			X0Y0_尾_鱗左2.Dra = value;
    			X0Y1_尾_鱗左2.Dra = value;
    			X0Y0_尾_鱗左2.Hit = value;
    			X0Y1_尾_鱗左2.Hit = value;
    		}
    	}

    	public bool 尾_鱗右1_表示
    	{
    		get
    		{
    			return X0Y0_尾_鱗右1.Dra;
    		}
    		set
    		{
    			X0Y0_尾_鱗右1.Dra = value;
    			X0Y1_尾_鱗右1.Dra = value;
    			X0Y0_尾_鱗右1.Hit = value;
    			X0Y1_尾_鱗右1.Hit = value;
    		}
    	}

    	public bool 尾_鱗左1_表示
    	{
    		get
    		{
    			return X0Y0_尾_鱗左1.Dra;
    		}
    		set
    		{
    			X0Y0_尾_鱗左1.Dra = value;
    			X0Y1_尾_鱗左1.Dra = value;
    			X0Y0_尾_鱗左1.Hit = value;
    			X0Y1_尾_鱗左1.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 鰭左2_鰭膜_表示;
    		}
    		set
    		{
    			鰭左2_鰭膜_表示 = value;
    			鰭左2_鰭条_表示 = value;
    			鰭右2_鰭膜_表示 = value;
    			鰭右2_鰭条_表示 = value;
    			鰭左1_鰭膜_表示 = value;
    			鰭左1_鰭条_表示 = value;
    			鰭右1_鰭膜_表示 = value;
    			鰭右1_鰭条_表示 = value;
    			尾_尾_表示 = value;
    			尾_鱗右3_表示 = value;
    			尾_鱗左3_表示 = value;
    			尾_鱗右2_表示 = value;
    			尾_鱗左2_表示 = value;
    			尾_鱗右1_表示 = value;
    			尾_鱗左1_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 鰭左2_鰭膜CD.不透明度;
    		}
    		set
    		{
    			鰭左2_鰭膜CD.不透明度 = value;
    			鰭左2_鰭条CD.不透明度 = value;
    			鰭右2_鰭膜CD.不透明度 = value;
    			鰭右2_鰭条CD.不透明度 = value;
    			鰭左1_鰭膜CD.不透明度 = value;
    			鰭左1_鰭条CD.不透明度 = value;
    			鰭右1_鰭膜CD.不透明度 = value;
    			鰭右1_鰭条CD.不透明度 = value;
    			尾_尾CD.不透明度 = value;
    			尾_鱗右3CD.不透明度 = value;
    			尾_鱗左3CD.不透明度 = value;
    			尾_鱗右2CD.不透明度 = value;
    			尾_鱗左2CD.不透明度 = value;
    			尾_鱗右1CD.不透明度 = value;
    			尾_鱗左1CD.不透明度 = value;
    		}
    	}

    	public double 展開
    	{
    		set
    		{
    			double num = value.Inverse();
    			double num2 = (右 ? (-1.0) : 1.0);
    			X0Y0_鰭左2_鰭膜.AngleCont = num2 * -35.0 * num;
    			X0Y0_鰭右2_鰭膜.AngleCont = num2 * 35.0 * num;
    			X0Y0_鰭左1_鰭膜.AngleCont = num2 * -15.0 * num;
    			X0Y0_鰭右1_鰭膜.AngleCont = num2 * 15.0 * num;
    			X0Y1_鰭左2_鰭膜.AngleCont = num2 * -35.0 * num;
    			X0Y1_鰭右2_鰭膜.AngleCont = num2 * 35.0 * num;
    			X0Y1_鰭左1_鰭膜.AngleCont = num2 * -15.0 * num;
    			X0Y1_鰭右1_鰭膜.AngleCont = num2 * 15.0 * num;
    		}
    	}

    	public 尾鰭_魚(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 尾鰭_魚D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.肢中["尾"][0]);
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		Pars pars2 = pars["鰭左2"].ToPars();
    		X0Y0_鰭左2_鰭膜 = pars2["鰭膜"].ToPar();
    		X0Y0_鰭左2_鰭条 = pars2["鰭条"].ToPar();
    		pars2 = pars["鰭右2"].ToPars();
    		X0Y0_鰭右2_鰭膜 = pars2["鰭膜"].ToPar();
    		X0Y0_鰭右2_鰭条 = pars2["鰭条"].ToPar();
    		pars2 = pars["鰭左1"].ToPars();
    		X0Y0_鰭左1_鰭膜 = pars2["鰭膜"].ToPar();
    		X0Y0_鰭左1_鰭条 = pars2["鰭条"].ToPar();
    		pars2 = pars["鰭右1"].ToPars();
    		X0Y0_鰭右1_鰭膜 = pars2["鰭膜"].ToPar();
    		X0Y0_鰭右1_鰭条 = pars2["鰭条"].ToPar();
    		pars2 = pars["尾"].ToPars();
    		X0Y0_尾_尾 = pars2["尾"].ToPar();
    		X0Y0_尾_鱗右3 = pars2["鱗右3"].ToPar();
    		X0Y0_尾_鱗左3 = pars2["鱗左3"].ToPar();
    		X0Y0_尾_鱗右2 = pars2["鱗右2"].ToPar();
    		X0Y0_尾_鱗左2 = pars2["鱗左2"].ToPar();
    		X0Y0_尾_鱗右1 = pars2["鱗右1"].ToPar();
    		X0Y0_尾_鱗左1 = pars2["鱗左1"].ToPar();
    		Pars pars3 = Body[0][1];
    		pars2 = pars3["鰭左2"].ToPars();
    		X0Y1_鰭左2_鰭膜 = pars2["鰭膜"].ToPar();
    		X0Y1_鰭左2_鰭条 = pars2["鰭条"].ToPar();
    		pars2 = pars3["鰭右2"].ToPars();
    		X0Y1_鰭右2_鰭膜 = pars2["鰭膜"].ToPar();
    		X0Y1_鰭右2_鰭条 = pars2["鰭条"].ToPar();
    		pars2 = pars3["鰭左1"].ToPars();
    		X0Y1_鰭左1_鰭膜 = pars2["鰭膜"].ToPar();
    		X0Y1_鰭左1_鰭条 = pars2["鰭条"].ToPar();
    		pars2 = pars3["鰭右1"].ToPars();
    		X0Y1_鰭右1_鰭膜 = pars2["鰭膜"].ToPar();
    		X0Y1_鰭右1_鰭条 = pars2["鰭条"].ToPar();
    		pars2 = pars3["尾"].ToPars();
    		X0Y1_尾_尾 = pars2["尾"].ToPar();
    		X0Y1_尾_鱗右3 = pars2["鱗右3"].ToPar();
    		X0Y1_尾_鱗左3 = pars2["鱗左3"].ToPar();
    		X0Y1_尾_鱗右2 = pars2["鱗右2"].ToPar();
    		X0Y1_尾_鱗左2 = pars2["鱗左2"].ToPar();
    		X0Y1_尾_鱗右1 = pars2["鱗右1"].ToPar();
    		X0Y1_尾_鱗左1 = pars2["鱗左1"].ToPar();
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
    		鰭左2_鰭膜_表示 = e.鰭左2_鰭膜_表示;
    		鰭左2_鰭条_表示 = e.鰭左2_鰭条_表示;
    		鰭右2_鰭膜_表示 = e.鰭右2_鰭膜_表示;
    		鰭右2_鰭条_表示 = e.鰭右2_鰭条_表示;
    		鰭左1_鰭膜_表示 = e.鰭左1_鰭膜_表示;
    		鰭左1_鰭条_表示 = e.鰭左1_鰭条_表示;
    		鰭右1_鰭膜_表示 = e.鰭右1_鰭膜_表示;
    		鰭右1_鰭条_表示 = e.鰭右1_鰭条_表示;
    		尾_尾_表示 = e.尾_尾_表示;
    		尾_鱗右3_表示 = e.尾_鱗右3_表示;
    		尾_鱗左3_表示 = e.尾_鱗左3_表示;
    		尾_鱗右2_表示 = e.尾_鱗右2_表示;
    		尾_鱗左2_表示 = e.尾_鱗左2_表示;
    		尾_鱗右1_表示 = e.尾_鱗右1_表示;
    		尾_鱗左1_表示 = e.尾_鱗左1_表示;
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
    		X0Y0_鰭左2_鰭膜CP = new ColorP(X0Y0_鰭左2_鰭膜, 鰭左2_鰭膜CD, DisUnit, abj: true);
    		X0Y0_鰭左2_鰭条CP = new ColorP(X0Y0_鰭左2_鰭条, 鰭左2_鰭条CD, DisUnit, abj: true);
    		X0Y0_鰭右2_鰭膜CP = new ColorP(X0Y0_鰭右2_鰭膜, 鰭右2_鰭膜CD, DisUnit, abj: true);
    		X0Y0_鰭右2_鰭条CP = new ColorP(X0Y0_鰭右2_鰭条, 鰭右2_鰭条CD, DisUnit, abj: true);
    		X0Y0_鰭左1_鰭膜CP = new ColorP(X0Y0_鰭左1_鰭膜, 鰭左1_鰭膜CD, DisUnit, abj: true);
    		X0Y0_鰭左1_鰭条CP = new ColorP(X0Y0_鰭左1_鰭条, 鰭左1_鰭条CD, DisUnit, abj: true);
    		X0Y0_鰭右1_鰭膜CP = new ColorP(X0Y0_鰭右1_鰭膜, 鰭右1_鰭膜CD, DisUnit, abj: true);
    		X0Y0_鰭右1_鰭条CP = new ColorP(X0Y0_鰭右1_鰭条, 鰭右1_鰭条CD, DisUnit, abj: true);
    		X0Y0_尾_尾CP = new ColorP(X0Y0_尾_尾, 尾_尾CD, DisUnit, abj: true);
    		X0Y0_尾_鱗右3CP = new ColorP(X0Y0_尾_鱗右3, 尾_鱗右3CD, DisUnit, abj: true);
    		X0Y0_尾_鱗左3CP = new ColorP(X0Y0_尾_鱗左3, 尾_鱗左3CD, DisUnit, abj: true);
    		X0Y0_尾_鱗右2CP = new ColorP(X0Y0_尾_鱗右2, 尾_鱗右2CD, DisUnit, abj: true);
    		X0Y0_尾_鱗左2CP = new ColorP(X0Y0_尾_鱗左2, 尾_鱗左2CD, DisUnit, abj: true);
    		X0Y0_尾_鱗右1CP = new ColorP(X0Y0_尾_鱗右1, 尾_鱗右1CD, DisUnit, abj: true);
    		X0Y0_尾_鱗左1CP = new ColorP(X0Y0_尾_鱗左1, 尾_鱗左1CD, DisUnit, abj: true);
    		X0Y1_鰭左2_鰭膜CP = new ColorP(X0Y1_鰭左2_鰭膜, 鰭左2_鰭膜CD, DisUnit, abj: true);
    		X0Y1_鰭左2_鰭条CP = new ColorP(X0Y1_鰭左2_鰭条, 鰭左2_鰭条CD, DisUnit, abj: true);
    		X0Y1_鰭右2_鰭膜CP = new ColorP(X0Y1_鰭右2_鰭膜, 鰭右2_鰭膜CD, DisUnit, abj: true);
    		X0Y1_鰭右2_鰭条CP = new ColorP(X0Y1_鰭右2_鰭条, 鰭右2_鰭条CD, DisUnit, abj: true);
    		X0Y1_鰭左1_鰭膜CP = new ColorP(X0Y1_鰭左1_鰭膜, 鰭左1_鰭膜CD, DisUnit, abj: true);
    		X0Y1_鰭左1_鰭条CP = new ColorP(X0Y1_鰭左1_鰭条, 鰭左1_鰭条CD, DisUnit, abj: true);
    		X0Y1_鰭右1_鰭膜CP = new ColorP(X0Y1_鰭右1_鰭膜, 鰭右1_鰭膜CD, DisUnit, abj: true);
    		X0Y1_鰭右1_鰭条CP = new ColorP(X0Y1_鰭右1_鰭条, 鰭右1_鰭条CD, DisUnit, abj: true);
    		X0Y1_尾_尾CP = new ColorP(X0Y1_尾_尾, 尾_尾CD, DisUnit, abj: true);
    		X0Y1_尾_鱗右3CP = new ColorP(X0Y1_尾_鱗右3, 尾_鱗右3CD, DisUnit, abj: true);
    		X0Y1_尾_鱗左3CP = new ColorP(X0Y1_尾_鱗左3, 尾_鱗左3CD, DisUnit, abj: true);
    		X0Y1_尾_鱗右2CP = new ColorP(X0Y1_尾_鱗右2, 尾_鱗右2CD, DisUnit, abj: true);
    		X0Y1_尾_鱗左2CP = new ColorP(X0Y1_尾_鱗左2, 尾_鱗左2CD, DisUnit, abj: true);
    		X0Y1_尾_鱗右1CP = new ColorP(X0Y1_尾_鱗右1, 尾_鱗右1CD, DisUnit, abj: true);
    		X0Y1_尾_鱗左1CP = new ColorP(X0Y1_尾_鱗左1, 尾_鱗左1CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_鰭左2_鰭膜.AngleBase = num * 35.0;
    		X0Y0_鰭右2_鰭膜.AngleBase = num * -35.0;
    		X0Y0_鰭左1_鰭膜.AngleBase = num * 9.0;
    		X0Y0_鰭右1_鰭膜.AngleBase = num * -9.0;
    		X0Y1_鰭左2_鰭膜.AngleBase = num * 35.0;
    		X0Y1_鰭右2_鰭膜.AngleBase = num * -35.0;
    		X0Y1_鰭左1_鰭膜.AngleBase = num * 9.0;
    		X0Y1_鰭右1_鰭膜.AngleBase = num * -9.0;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexY == 0)
    		{
    			X0Y0_鰭左2_鰭膜CP.Update();
    			X0Y0_鰭左2_鰭条CP.Update();
    			X0Y0_鰭右2_鰭膜CP.Update();
    			X0Y0_鰭右2_鰭条CP.Update();
    			X0Y0_鰭左1_鰭膜CP.Update();
    			X0Y0_鰭左1_鰭条CP.Update();
    			X0Y0_鰭右1_鰭膜CP.Update();
    			X0Y0_鰭右1_鰭条CP.Update();
    			X0Y0_尾_尾CP.Update();
    			X0Y0_尾_鱗右3CP.Update();
    			X0Y0_尾_鱗左3CP.Update();
    			X0Y0_尾_鱗右2CP.Update();
    			X0Y0_尾_鱗左2CP.Update();
    			X0Y0_尾_鱗右1CP.Update();
    			X0Y0_尾_鱗左1CP.Update();
    		}
    		else
    		{
    			X0Y1_鰭左2_鰭膜CP.Update();
    			X0Y1_鰭左2_鰭条CP.Update();
    			X0Y1_鰭右2_鰭膜CP.Update();
    			X0Y1_鰭右2_鰭条CP.Update();
    			X0Y1_鰭左1_鰭膜CP.Update();
    			X0Y1_鰭左1_鰭条CP.Update();
    			X0Y1_鰭右1_鰭膜CP.Update();
    			X0Y1_鰭右1_鰭条CP.Update();
    			X0Y1_尾_尾CP.Update();
    			X0Y1_尾_鱗右3CP.Update();
    			X0Y1_尾_鱗左3CP.Update();
    			X0Y1_尾_鱗右2CP.Update();
    			X0Y1_尾_鱗左2CP.Update();
    			X0Y1_尾_鱗右1CP.Update();
    			X0Y1_尾_鱗左1CP.Update();
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		鰭左2_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
    		鰭左2_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		鰭右2_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
    		鰭右2_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		鰭左1_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
    		鰭左1_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		鰭右1_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
    		鰭右1_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		尾_尾CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		尾_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		尾_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		尾_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		尾_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		尾_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		尾_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}
    }
}
