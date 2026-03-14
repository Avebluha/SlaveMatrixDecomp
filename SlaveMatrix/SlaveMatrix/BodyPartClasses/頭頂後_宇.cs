using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 頭頂後_宇 : Ele
    {
    	public Par X0Y0_頭部;

    	public Par X0Y0_線_線左1;

    	public Par X0Y0_線_線左2;

    	public Par X0Y0_線_線左3;

    	public Par X0Y0_線_線右1;

    	public Par X0Y0_線_線右2;

    	public Par X0Y0_線_線右3;

    	public ColorD 頭部CD;

    	public ColorD 線_線左1CD;

    	public ColorD 線_線左2CD;

    	public ColorD 線_線左3CD;

    	public ColorD 線_線右1CD;

    	public ColorD 線_線右2CD;

    	public ColorD 線_線右3CD;

    	public ColorP X0Y0_頭部CP;

    	public ColorP X0Y0_線_線左1CP;

    	public ColorP X0Y0_線_線左2CP;

    	public ColorP X0Y0_線_線左3CP;

    	public ColorP X0Y0_線_線右1CP;

    	public ColorP X0Y0_線_線右2CP;

    	public ColorP X0Y0_線_線右3CP;

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

    	public bool 頭部_表示
    	{
    		get
    		{
    			return X0Y0_頭部.Dra;
    		}
    		set
    		{
    			X0Y0_頭部.Dra = value;
    			X0Y0_頭部.Hit = value;
    		}
    	}

    	public bool 線_線左1_表示
    	{
    		get
    		{
    			return X0Y0_線_線左1.Dra;
    		}
    		set
    		{
    			X0Y0_線_線左1.Dra = value;
    			X0Y0_線_線左1.Hit = value;
    		}
    	}

    	public bool 線_線左2_表示
    	{
    		get
    		{
    			return X0Y0_線_線左2.Dra;
    		}
    		set
    		{
    			X0Y0_線_線左2.Dra = value;
    			X0Y0_線_線左2.Hit = value;
    		}
    	}

    	public bool 線_線左3_表示
    	{
    		get
    		{
    			return X0Y0_線_線左3.Dra;
    		}
    		set
    		{
    			X0Y0_線_線左3.Dra = value;
    			X0Y0_線_線左3.Hit = value;
    		}
    	}

    	public bool 線_線右1_表示
    	{
    		get
    		{
    			return X0Y0_線_線右1.Dra;
    		}
    		set
    		{
    			X0Y0_線_線右1.Dra = value;
    			X0Y0_線_線右1.Hit = value;
    		}
    	}

    	public bool 線_線右2_表示
    	{
    		get
    		{
    			return X0Y0_線_線右2.Dra;
    		}
    		set
    		{
    			X0Y0_線_線右2.Dra = value;
    			X0Y0_線_線右2.Hit = value;
    		}
    	}

    	public bool 線_線右3_表示
    	{
    		get
    		{
    			return X0Y0_線_線右3.Dra;
    		}
    		set
    		{
    			X0Y0_線_線右3.Dra = value;
    			X0Y0_線_線右3.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 頭部_表示;
    		}
    		set
    		{
    			頭部_表示 = value;
    			線_線左1_表示 = value;
    			線_線左2_表示 = value;
    			線_線左3_表示 = value;
    			線_線右1_表示 = value;
    			線_線右2_表示 = value;
    			線_線右3_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 頭部CD.不透明度;
    		}
    		set
    		{
    			頭部CD.不透明度 = value;
    			線_線左1CD.不透明度 = value;
    			線_線左2CD.不透明度 = value;
    			線_線左3CD.不透明度 = value;
    			線_線右1CD.不透明度 = value;
    			線_線右2CD.不透明度 = value;
    			線_線右3CD.不透明度 = value;
    		}
    	}

    	public 頭頂後_宇(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 頭頂後_宇D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "エイリアン";
    		dif.Add(new Pars(Sta.肢中["頭部後"][0][0]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_頭部 = pars["頭部"].ToPar();
    		Pars pars2 = pars["線"].ToPars();
    		X0Y0_線_線左1 = pars2["線左1"].ToPar();
    		X0Y0_線_線左2 = pars2["線左2"].ToPar();
    		X0Y0_線_線左3 = pars2["線左3"].ToPar();
    		X0Y0_線_線右1 = pars2["線右1"].ToPar();
    		X0Y0_線_線右2 = pars2["線右2"].ToPar();
    		X0Y0_線_線右3 = pars2["線右3"].ToPar();
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
    		頭部_表示 = e.頭部_表示;
    		線_線左1_表示 = e.線_線左1_表示;
    		線_線左2_表示 = e.線_線左2_表示;
    		線_線左3_表示 = e.線_線左3_表示;
    		線_線右1_表示 = e.線_線右1_表示;
    		線_線右2_表示 = e.線_線右2_表示;
    		線_線右3_表示 = e.線_線右3_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_頭部CP = new ColorP(X0Y0_頭部, 頭部CD, DisUnit, abj: true);
    		X0Y0_線_線左1CP = new ColorP(X0Y0_線_線左1, 線_線左1CD, DisUnit, abj: true);
    		X0Y0_線_線左2CP = new ColorP(X0Y0_線_線左2, 線_線左2CD, DisUnit, abj: true);
    		X0Y0_線_線左3CP = new ColorP(X0Y0_線_線左3, 線_線左3CD, DisUnit, abj: true);
    		X0Y0_線_線右1CP = new ColorP(X0Y0_線_線右1, 線_線右1CD, DisUnit, abj: true);
    		X0Y0_線_線右2CP = new ColorP(X0Y0_線_線右2, 線_線右2CD, DisUnit, abj: true);
    		X0Y0_線_線右3CP = new ColorP(X0Y0_線_線右3, 線_線右3CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_頭部CP.Update();
    		X0Y0_線_線左1CP.Update();
    		X0Y0_線_線左2CP.Update();
    		X0Y0_線_線左3CP.Update();
    		X0Y0_線_線右1CP.Update();
    		X0Y0_線_線右2CP.Update();
    		X0Y0_線_線右3CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		頭部CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		線_線左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		線_線左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		線_線左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		線_線右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		線_線右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		線_線右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    	}
    }
}
