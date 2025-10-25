using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 染み_人 : 染み
    {
    	public Par X0Y0_潮1;

    	public Par X0Y0_潮2;

    	public Par X0Y0_潮3;

    	public Par X0Y0_尿1;

    	public Par X0Y0_尿2;

    	public Par X0Y0_汗;

    	public Par X0Y0_湯気_湯気左1_湯気1;

    	public Par X0Y0_湯気_湯気左1_湯気2;

    	public Par X0Y0_湯気_湯気左2_湯気1;

    	public Par X0Y0_湯気_湯気左2_湯気2;

    	public Par X0Y0_湯気_湯気左3_湯気1;

    	public Par X0Y0_湯気_湯気左3_湯気2;

    	public Par X0Y0_湯気_湯気右1_湯気1;

    	public Par X0Y0_湯気_湯気右1_湯気2;

    	public Par X0Y0_湯気_湯気右2_湯気1;

    	public Par X0Y0_湯気_湯気右2_湯気2;

    	public Par X0Y0_湯気_湯気右3_湯気1;

    	public Par X0Y0_湯気_湯気右3_湯気2;

    	public ColorD 潮1CD;

    	public ColorD 潮2CD;

    	public ColorD 潮3CD;

    	public ColorD 尿1CD;

    	public ColorD 尿2CD;

    	public ColorD 汗CD;

    	public ColorD 湯気_湯気左1_湯気1CD;

    	public ColorD 湯気_湯気左1_湯気2CD;

    	public ColorD 湯気_湯気左2_湯気1CD;

    	public ColorD 湯気_湯気左2_湯気2CD;

    	public ColorD 湯気_湯気左3_湯気1CD;

    	public ColorD 湯気_湯気左3_湯気2CD;

    	public ColorD 湯気_湯気右1_湯気1CD;

    	public ColorD 湯気_湯気右1_湯気2CD;

    	public ColorD 湯気_湯気右2_湯気1CD;

    	public ColorD 湯気_湯気右2_湯気2CD;

    	public ColorD 湯気_湯気右3_湯気1CD;

    	public ColorD 湯気_湯気右3_湯気2CD;

    	public ColorP X0Y0_潮1CP;

    	public ColorP X0Y0_潮2CP;

    	public ColorP X0Y0_潮3CP;

    	public ColorP X0Y0_尿1CP;

    	public ColorP X0Y0_尿2CP;

    	public ColorP X0Y0_汗CP;

    	public ColorP X0Y0_湯気_湯気左1_湯気1CP;

    	public ColorP X0Y0_湯気_湯気左1_湯気2CP;

    	public ColorP X0Y0_湯気_湯気左2_湯気1CP;

    	public ColorP X0Y0_湯気_湯気左2_湯気2CP;

    	public ColorP X0Y0_湯気_湯気左3_湯気1CP;

    	public ColorP X0Y0_湯気_湯気左3_湯気2CP;

    	public ColorP X0Y0_湯気_湯気右1_湯気1CP;

    	public ColorP X0Y0_湯気_湯気右1_湯気2CP;

    	public ColorP X0Y0_湯気_湯気右2_湯気1CP;

    	public ColorP X0Y0_湯気_湯気右2_湯気2CP;

    	public ColorP X0Y0_湯気_湯気右3_湯気1CP;

    	public ColorP X0Y0_湯気_湯気右3_湯気2CP;

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

    	public bool 潮1_表示
    	{
    		get
    		{
    			return X0Y0_潮1.Dra;
    		}
    		set
    		{
    			X0Y0_潮1.Dra = value;
    			X0Y0_潮1.Hit = value;
    		}
    	}

    	public bool 潮2_表示
    	{
    		get
    		{
    			return X0Y0_潮2.Dra;
    		}
    		set
    		{
    			X0Y0_潮2.Dra = value;
    			X0Y0_潮2.Hit = value;
    		}
    	}

    	public bool 潮3_表示
    	{
    		get
    		{
    			return X0Y0_潮3.Dra;
    		}
    		set
    		{
    			X0Y0_潮3.Dra = value;
    			X0Y0_潮3.Hit = value;
    		}
    	}

    	public bool 尿1_表示
    	{
    		get
    		{
    			return X0Y0_尿1.Dra;
    		}
    		set
    		{
    			X0Y0_尿1.Dra = value;
    			X0Y0_尿1.Hit = value;
    		}
    	}

    	public bool 尿2_表示
    	{
    		get
    		{
    			return X0Y0_尿2.Dra;
    		}
    		set
    		{
    			X0Y0_尿2.Dra = value;
    			X0Y0_尿2.Hit = value;
    		}
    	}

    	public bool 汗_表示
    	{
    		get
    		{
    			return X0Y0_汗.Dra;
    		}
    		set
    		{
    			X0Y0_汗.Dra = value;
    			X0Y0_汗.Hit = value;
    		}
    	}

    	public bool 湯気_湯気左1_湯気1_表示
    	{
    		get
    		{
    			return X0Y0_湯気_湯気左1_湯気1.Dra;
    		}
    		set
    		{
    			X0Y0_湯気_湯気左1_湯気1.Dra = value;
    			X0Y0_湯気_湯気左1_湯気1.Hit = value;
    		}
    	}

    	public bool 湯気_湯気左1_湯気2_表示
    	{
    		get
    		{
    			return X0Y0_湯気_湯気左1_湯気2.Dra;
    		}
    		set
    		{
    			X0Y0_湯気_湯気左1_湯気2.Dra = value;
    			X0Y0_湯気_湯気左1_湯気2.Hit = value;
    		}
    	}

    	public bool 湯気_湯気左2_湯気1_表示
    	{
    		get
    		{
    			return X0Y0_湯気_湯気左2_湯気1.Dra;
    		}
    		set
    		{
    			X0Y0_湯気_湯気左2_湯気1.Dra = value;
    			X0Y0_湯気_湯気左2_湯気1.Hit = value;
    		}
    	}

    	public bool 湯気_湯気左2_湯気2_表示
    	{
    		get
    		{
    			return X0Y0_湯気_湯気左2_湯気2.Dra;
    		}
    		set
    		{
    			X0Y0_湯気_湯気左2_湯気2.Dra = value;
    			X0Y0_湯気_湯気左2_湯気2.Hit = value;
    		}
    	}

    	public bool 湯気_湯気左3_湯気1_表示
    	{
    		get
    		{
    			return X0Y0_湯気_湯気左3_湯気1.Dra;
    		}
    		set
    		{
    			X0Y0_湯気_湯気左3_湯気1.Dra = value;
    			X0Y0_湯気_湯気左3_湯気1.Hit = value;
    		}
    	}

    	public bool 湯気_湯気左3_湯気2_表示
    	{
    		get
    		{
    			return X0Y0_湯気_湯気左3_湯気2.Dra;
    		}
    		set
    		{
    			X0Y0_湯気_湯気左3_湯気2.Dra = value;
    			X0Y0_湯気_湯気左3_湯気2.Hit = value;
    		}
    	}

    	public bool 湯気_湯気右1_湯気1_表示
    	{
    		get
    		{
    			return X0Y0_湯気_湯気右1_湯気1.Dra;
    		}
    		set
    		{
    			X0Y0_湯気_湯気右1_湯気1.Dra = value;
    			X0Y0_湯気_湯気右1_湯気1.Hit = value;
    		}
    	}

    	public bool 湯気_湯気右1_湯気2_表示
    	{
    		get
    		{
    			return X0Y0_湯気_湯気右1_湯気2.Dra;
    		}
    		set
    		{
    			X0Y0_湯気_湯気右1_湯気2.Dra = value;
    			X0Y0_湯気_湯気右1_湯気2.Hit = value;
    		}
    	}

    	public bool 湯気_湯気右2_湯気1_表示
    	{
    		get
    		{
    			return X0Y0_湯気_湯気右2_湯気1.Dra;
    		}
    		set
    		{
    			X0Y0_湯気_湯気右2_湯気1.Dra = value;
    			X0Y0_湯気_湯気右2_湯気1.Hit = value;
    		}
    	}

    	public bool 湯気_湯気右2_湯気2_表示
    	{
    		get
    		{
    			return X0Y0_湯気_湯気右2_湯気2.Dra;
    		}
    		set
    		{
    			X0Y0_湯気_湯気右2_湯気2.Dra = value;
    			X0Y0_湯気_湯気右2_湯気2.Hit = value;
    		}
    	}

    	public bool 湯気_湯気右3_湯気1_表示
    	{
    		get
    		{
    			return X0Y0_湯気_湯気右3_湯気1.Dra;
    		}
    		set
    		{
    			X0Y0_湯気_湯気右3_湯気1.Dra = value;
    			X0Y0_湯気_湯気右3_湯気1.Hit = value;
    		}
    	}

    	public bool 湯気_湯気右3_湯気2_表示
    	{
    		get
    		{
    			return X0Y0_湯気_湯気右3_湯気2.Dra;
    		}
    		set
    		{
    			X0Y0_湯気_湯気右3_湯気2.Dra = value;
    			X0Y0_湯気_湯気右3_湯気2.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 潮1_表示;
    		}
    		set
    		{
    			潮1_表示 = value;
    			潮2_表示 = value;
    			潮3_表示 = value;
    			尿1_表示 = value;
    			尿2_表示 = value;
    			汗_表示 = value;
    			湯気_湯気左1_湯気1_表示 = value;
    			湯気_湯気左1_湯気2_表示 = value;
    			湯気_湯気左2_湯気1_表示 = value;
    			湯気_湯気左2_湯気2_表示 = value;
    			湯気_湯気左3_湯気1_表示 = value;
    			湯気_湯気左3_湯気2_表示 = value;
    			湯気_湯気右1_湯気1_表示 = value;
    			湯気_湯気右1_湯気2_表示 = value;
    			湯気_湯気右2_湯気1_表示 = value;
    			湯気_湯気右2_湯気2_表示 = value;
    			湯気_湯気右3_湯気1_表示 = value;
    			湯気_湯気右3_湯気2_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 潮1CD.不透明度;
    		}
    		set
    		{
    			潮1CD.不透明度 = value;
    			潮2CD.不透明度 = value;
    			潮3CD.不透明度 = value;
    			尿1CD.不透明度 = value;
    			尿2CD.不透明度 = value;
    			汗CD.不透明度 = value;
    			湯気_湯気左1_湯気1CD.不透明度 = value;
    			湯気_湯気左1_湯気2CD.不透明度 = value;
    			湯気_湯気左2_湯気1CD.不透明度 = value;
    			湯気_湯気左2_湯気2CD.不透明度 = value;
    			湯気_湯気左3_湯気1CD.不透明度 = value;
    			湯気_湯気左3_湯気2CD.不透明度 = value;
    			湯気_湯気右1_湯気1CD.不透明度 = value;
    			湯気_湯気右1_湯気2CD.不透明度 = value;
    			湯気_湯気右2_湯気1CD.不透明度 = value;
    			湯気_湯気右2_湯気2CD.不透明度 = value;
    			湯気_湯気右3_湯気1CD.不透明度 = value;
    			湯気_湯気右3_湯気2CD.不透明度 = value;
    		}
    	}

    	public 染み_人(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 染み_人D e)
    	{
    		ThisType = GetType();
    		本体 = new Difs(Sta.その他["染み"]);
    		Pars pars = 本体[0][0];
    		X0Y0_潮1 = pars["潮1"].ToPar();
    		X0Y0_潮2 = pars["潮2"].ToPar();
    		X0Y0_潮3 = pars["潮3"].ToPar();
    		X0Y0_尿1 = pars["尿1"].ToPar();
    		X0Y0_尿2 = pars["尿2"].ToPar();
    		X0Y0_汗 = pars["汗"].ToPar();
    		Pars pars2 = pars["湯気"].ToPars();
    		Pars pars3 = pars2["湯気左1"].ToPars();
    		X0Y0_湯気_湯気左1_湯気1 = pars3["湯気1"].ToPar();
    		X0Y0_湯気_湯気左1_湯気2 = pars3["湯気2"].ToPar();
    		pars3 = pars2["湯気左2"].ToPars();
    		X0Y0_湯気_湯気左2_湯気1 = pars3["湯気1"].ToPar();
    		X0Y0_湯気_湯気左2_湯気2 = pars3["湯気2"].ToPar();
    		pars3 = pars2["湯気左3"].ToPars();
    		X0Y0_湯気_湯気左3_湯気1 = pars3["湯気1"].ToPar();
    		X0Y0_湯気_湯気左3_湯気2 = pars3["湯気2"].ToPar();
    		pars3 = pars2["湯気右1"].ToPars();
    		X0Y0_湯気_湯気右1_湯気1 = pars3["湯気1"].ToPar();
    		X0Y0_湯気_湯気右1_湯気2 = pars3["湯気2"].ToPar();
    		pars3 = pars2["湯気右2"].ToPars();
    		X0Y0_湯気_湯気右2_湯気1 = pars3["湯気1"].ToPar();
    		X0Y0_湯気_湯気右2_湯気2 = pars3["湯気2"].ToPar();
    		pars3 = pars2["湯気右3"].ToPars();
    		X0Y0_湯気_湯気右3_湯気1 = pars3["湯気1"].ToPar();
    		X0Y0_湯気_湯気右3_湯気2 = pars3["湯気2"].ToPar();
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
    		潮1_表示 = e.潮1_表示;
    		潮2_表示 = e.潮2_表示;
    		潮3_表示 = e.潮3_表示;
    		尿1_表示 = e.尿1_表示;
    		尿2_表示 = e.尿2_表示;
    		汗_表示 = e.汗_表示;
    		湯気_湯気左1_湯気1_表示 = e.湯気_湯気左1_湯気1_表示;
    		湯気_湯気左1_湯気2_表示 = e.湯気_湯気左1_湯気2_表示;
    		湯気_湯気左2_湯気1_表示 = e.湯気_湯気左2_湯気1_表示;
    		湯気_湯気左2_湯気2_表示 = e.湯気_湯気左2_湯気2_表示;
    		湯気_湯気左3_湯気1_表示 = e.湯気_湯気左3_湯気1_表示;
    		湯気_湯気左3_湯気2_表示 = e.湯気_湯気左3_湯気2_表示;
    		湯気_湯気右1_湯気1_表示 = e.湯気_湯気右1_湯気1_表示;
    		湯気_湯気右1_湯気2_表示 = e.湯気_湯気右1_湯気2_表示;
    		湯気_湯気右2_湯気1_表示 = e.湯気_湯気右2_湯気1_表示;
    		湯気_湯気右2_湯気2_表示 = e.湯気_湯気右2_湯気2_表示;
    		湯気_湯気右3_湯気1_表示 = e.湯気_湯気右3_湯気1_表示;
    		湯気_湯気右3_湯気2_表示 = e.湯気_湯気右3_湯気2_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_潮1CP = new ColorP(X0Y0_潮1, 潮1CD, DisUnit, abj: true);
    		X0Y0_潮2CP = new ColorP(X0Y0_潮2, 潮2CD, DisUnit, abj: true);
    		X0Y0_潮3CP = new ColorP(X0Y0_潮3, 潮3CD, DisUnit, abj: true);
    		X0Y0_尿1CP = new ColorP(X0Y0_尿1, 尿1CD, DisUnit, abj: true);
    		X0Y0_尿2CP = new ColorP(X0Y0_尿2, 尿2CD, DisUnit, abj: true);
    		X0Y0_汗CP = new ColorP(X0Y0_汗, 汗CD, DisUnit, abj: true);
    		X0Y0_湯気_湯気左1_湯気1CP = new ColorP(X0Y0_湯気_湯気左1_湯気1, 湯気_湯気左1_湯気1CD, DisUnit, abj: true);
    		X0Y0_湯気_湯気左1_湯気2CP = new ColorP(X0Y0_湯気_湯気左1_湯気2, 湯気_湯気左1_湯気2CD, DisUnit, abj: true);
    		X0Y0_湯気_湯気左2_湯気1CP = new ColorP(X0Y0_湯気_湯気左2_湯気1, 湯気_湯気左2_湯気1CD, DisUnit, abj: true);
    		X0Y0_湯気_湯気左2_湯気2CP = new ColorP(X0Y0_湯気_湯気左2_湯気2, 湯気_湯気左2_湯気2CD, DisUnit, abj: true);
    		X0Y0_湯気_湯気左3_湯気1CP = new ColorP(X0Y0_湯気_湯気左3_湯気1, 湯気_湯気左3_湯気1CD, DisUnit, abj: true);
    		X0Y0_湯気_湯気左3_湯気2CP = new ColorP(X0Y0_湯気_湯気左3_湯気2, 湯気_湯気左3_湯気2CD, DisUnit, abj: true);
    		X0Y0_湯気_湯気右1_湯気1CP = new ColorP(X0Y0_湯気_湯気右1_湯気1, 湯気_湯気右1_湯気1CD, DisUnit, abj: true);
    		X0Y0_湯気_湯気右1_湯気2CP = new ColorP(X0Y0_湯気_湯気右1_湯気2, 湯気_湯気右1_湯気2CD, DisUnit, abj: true);
    		X0Y0_湯気_湯気右2_湯気1CP = new ColorP(X0Y0_湯気_湯気右2_湯気1, 湯気_湯気右2_湯気1CD, DisUnit, abj: true);
    		X0Y0_湯気_湯気右2_湯気2CP = new ColorP(X0Y0_湯気_湯気右2_湯気2, 湯気_湯気右2_湯気2CD, DisUnit, abj: true);
    		X0Y0_湯気_湯気右3_湯気1CP = new ColorP(X0Y0_湯気_湯気右3_湯気1, 湯気_湯気右3_湯気1CD, DisUnit, abj: true);
    		X0Y0_湯気_湯気右3_湯気2CP = new ColorP(X0Y0_湯気_湯気右3_湯気2, 湯気_湯気右3_湯気2CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_潮1);
    		Are.Draw(X0Y0_潮2);
    		Are.Draw(X0Y0_潮3);
    		Are.Draw(X0Y0_尿1);
    		Are.Draw(X0Y0_尿2);
    		Are.Draw(X0Y0_汗);
    	}

    	public void 湯気描画(RenderArea Are)
    	{
    		Are.Draw(X0Y0_湯気_湯気左1_湯気1);
    		Are.Draw(X0Y0_湯気_湯気左1_湯気2);
    		Are.Draw(X0Y0_湯気_湯気左2_湯気1);
    		Are.Draw(X0Y0_湯気_湯気左2_湯気2);
    		Are.Draw(X0Y0_湯気_湯気左3_湯気1);
    		Are.Draw(X0Y0_湯気_湯気左3_湯気2);
    		Are.Draw(X0Y0_湯気_湯気右1_湯気1);
    		Are.Draw(X0Y0_湯気_湯気右1_湯気2);
    		Are.Draw(X0Y0_湯気_湯気右2_湯気1);
    		Are.Draw(X0Y0_湯気_湯気右2_湯気2);
    		Are.Draw(X0Y0_湯気_湯気右3_湯気1);
    		Are.Draw(X0Y0_湯気_湯気右3_湯気2);
    	}

    	public override void 色更新()
    	{
    		X0Y0_潮1CP.Update();
    		X0Y0_潮2CP.Update();
    		X0Y0_潮3CP.Update();
    		X0Y0_尿1CP.Update();
    		X0Y0_尿2CP.Update();
    		X0Y0_汗CP.Update();
    		X0Y0_湯気_湯気左1_湯気1CP.Update();
    		X0Y0_湯気_湯気左1_湯気2CP.Update();
    		X0Y0_湯気_湯気左2_湯気1CP.Update();
    		X0Y0_湯気_湯気左2_湯気2CP.Update();
    		X0Y0_湯気_湯気左3_湯気1CP.Update();
    		X0Y0_湯気_湯気左3_湯気2CP.Update();
    		X0Y0_湯気_湯気右1_湯気1CP.Update();
    		X0Y0_湯気_湯気右1_湯気2CP.Update();
    		X0Y0_湯気_湯気右2_湯気1CP.Update();
    		X0Y0_湯気_湯気右2_湯気2CP.Update();
    		X0Y0_湯気_湯気右3_湯気1CP.Update();
    		X0Y0_湯気_湯気右3_湯気2CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		潮1CD = new ColorD(ref Col.Empty, ref 体配色.染み);
    		潮2CD = new ColorD(ref Col.Empty, ref 体配色.染み);
    		潮3CD = new ColorD(ref Col.Empty, ref 体配色.染み);
    		尿1CD = new ColorD(ref Col.Empty, ref 体配色.染み);
    		尿2CD = new ColorD(ref Col.Empty, ref 体配色.染み);
    		汗CD = new ColorD(ref Col.Empty, ref 体配色.染み);
    		湯気_湯気左1_湯気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
    		湯気_湯気左1_湯気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
    		湯気_湯気左2_湯気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
    		湯気_湯気左2_湯気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
    		湯気_湯気左3_湯気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
    		湯気_湯気左3_湯気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
    		湯気_湯気右1_湯気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
    		湯気_湯気右1_湯気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
    		湯気_湯気右2_湯気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
    		湯気_湯気右2_湯気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
    		湯気_湯気右3_湯気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
    		湯気_湯気右3_湯気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
    	}
    }
}
