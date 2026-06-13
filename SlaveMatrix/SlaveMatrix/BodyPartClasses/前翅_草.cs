using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 前翅_草 : 前翅
    {
    	public Par X0Y0_前翅_前翅1;

    	public Par X0Y0_前翅_翅脈線1;

    	public Par X0Y0_前翅_翅脈線2;

    	public Par X0Y0_前翅_翅脈線3;

    	public Par X0Y0_前翅_翅脈線4;

    	public Par X0Y0_前翅_翅脈線5;

    	public Par X0Y0_前翅_翅脈線6;

    	public Par X0Y0_前翅_翅脈線7;

    	public Par X0Y0_前翅_翅脈線8;

    	public Par X0Y0_前翅_前翅2;

    	public Par X0Y0_前翅_紋1;

    	public Par X0Y0_前翅_紋2;

    	public Par X0Y1_前翅_前翅1;

    	public Par X0Y1_前翅_翅脈線1;

    	public Par X0Y1_前翅_翅脈線2;

    	public Par X0Y1_前翅_翅脈線3;

    	public Par X0Y1_前翅_翅脈線4;

    	public Par X0Y1_前翅_翅脈線5;

    	public Par X0Y1_前翅_翅脈線6;

    	public Par X0Y1_前翅_翅脈線7;

    	public Par X0Y1_前翅_翅脈線8;

    	public Par X0Y1_前翅_前翅2;

    	public Par X0Y1_前翅_紋1;

    	public Par X0Y1_前翅_紋2;

    	public ColorD 前翅_前翅1CD;

    	public ColorD 前翅_翅脈線1CD;

    	public ColorD 前翅_翅脈線2CD;

    	public ColorD 前翅_翅脈線3CD;

    	public ColorD 前翅_翅脈線4CD;

    	public ColorD 前翅_翅脈線5CD;

    	public ColorD 前翅_翅脈線6CD;

    	public ColorD 前翅_翅脈線7CD;

    	public ColorD 前翅_翅脈線8CD;

    	public ColorD 前翅_前翅2CD;

    	public ColorD 前翅_紋1CD;

    	public ColorD 前翅_紋2CD;

    	public ColorP X0Y0_前翅_前翅1CP;

    	public ColorP X0Y0_前翅_翅脈線1CP;

    	public ColorP X0Y0_前翅_翅脈線2CP;

    	public ColorP X0Y0_前翅_翅脈線3CP;

    	public ColorP X0Y0_前翅_翅脈線4CP;

    	public ColorP X0Y0_前翅_翅脈線5CP;

    	public ColorP X0Y0_前翅_翅脈線6CP;

    	public ColorP X0Y0_前翅_翅脈線7CP;

    	public ColorP X0Y0_前翅_翅脈線8CP;

    	public ColorP X0Y0_前翅_前翅2CP;

    	public ColorP X0Y0_前翅_紋1CP;

    	public ColorP X0Y0_前翅_紋2CP;

    	public ColorP X0Y1_前翅_前翅1CP;

    	public ColorP X0Y1_前翅_翅脈線1CP;

    	public ColorP X0Y1_前翅_翅脈線2CP;

    	public ColorP X0Y1_前翅_翅脈線3CP;

    	public ColorP X0Y1_前翅_翅脈線4CP;

    	public ColorP X0Y1_前翅_翅脈線5CP;

    	public ColorP X0Y1_前翅_翅脈線6CP;

    	public ColorP X0Y1_前翅_翅脈線7CP;

    	public ColorP X0Y1_前翅_翅脈線8CP;

    	public ColorP X0Y1_前翅_前翅2CP;

    	public ColorP X0Y1_前翅_紋1CP;

    	public ColorP X0Y1_前翅_紋2CP;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    			Body.SetIndexY((欠損_ ? 1 : 0));
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

    	public bool 前翅_前翅1_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅1.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅1.Dra = value;
    			X0Y1_前翅_前翅1.Dra = value;
    			X0Y0_前翅_前翅1.Hit = value;
    			X0Y1_前翅_前翅1.Hit = value;
    		}
    	}

    	public bool 前翅_翅脈線1_表示
    	{
    		get
    		{
    			return X0Y0_前翅_翅脈線1.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_翅脈線1.Dra = value;
    			X0Y1_前翅_翅脈線1.Dra = value;
    			X0Y0_前翅_翅脈線1.Hit = value;
    			X0Y1_前翅_翅脈線1.Hit = value;
    		}
    	}

    	public bool 前翅_翅脈線2_表示
    	{
    		get
    		{
    			return X0Y0_前翅_翅脈線2.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_翅脈線2.Dra = value;
    			X0Y1_前翅_翅脈線2.Dra = value;
    			X0Y0_前翅_翅脈線2.Hit = value;
    			X0Y1_前翅_翅脈線2.Hit = value;
    		}
    	}

    	public bool 前翅_翅脈線3_表示
    	{
    		get
    		{
    			return X0Y0_前翅_翅脈線3.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_翅脈線3.Dra = value;
    			X0Y1_前翅_翅脈線3.Dra = value;
    			X0Y0_前翅_翅脈線3.Hit = value;
    			X0Y1_前翅_翅脈線3.Hit = value;
    		}
    	}

    	public bool 前翅_翅脈線4_表示
    	{
    		get
    		{
    			return X0Y0_前翅_翅脈線4.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_翅脈線4.Dra = value;
    			X0Y1_前翅_翅脈線4.Dra = value;
    			X0Y0_前翅_翅脈線4.Hit = value;
    			X0Y1_前翅_翅脈線4.Hit = value;
    		}
    	}

    	public bool 前翅_翅脈線5_表示
    	{
    		get
    		{
    			return X0Y0_前翅_翅脈線5.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_翅脈線5.Dra = value;
    			X0Y1_前翅_翅脈線5.Dra = value;
    			X0Y0_前翅_翅脈線5.Hit = value;
    			X0Y1_前翅_翅脈線5.Hit = value;
    		}
    	}

    	public bool 前翅_翅脈線6_表示
    	{
    		get
    		{
    			return X0Y0_前翅_翅脈線6.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_翅脈線6.Dra = value;
    			X0Y1_前翅_翅脈線6.Dra = value;
    			X0Y0_前翅_翅脈線6.Hit = value;
    			X0Y1_前翅_翅脈線6.Hit = value;
    		}
    	}

    	public bool 前翅_翅脈線7_表示
    	{
    		get
    		{
    			return X0Y0_前翅_翅脈線7.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_翅脈線7.Dra = value;
    			X0Y1_前翅_翅脈線7.Dra = value;
    			X0Y0_前翅_翅脈線7.Hit = value;
    			X0Y1_前翅_翅脈線7.Hit = value;
    		}
    	}

    	public bool 前翅_翅脈線8_表示
    	{
    		get
    		{
    			return X0Y0_前翅_翅脈線8.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_翅脈線8.Dra = value;
    			X0Y1_前翅_翅脈線8.Dra = value;
    			X0Y0_前翅_翅脈線8.Hit = value;
    			X0Y1_前翅_翅脈線8.Hit = value;
    		}
    	}

    	public bool 前翅_前翅2_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅2.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅2.Dra = value;
    			X0Y1_前翅_前翅2.Dra = value;
    			X0Y0_前翅_前翅2.Hit = value;
    			X0Y1_前翅_前翅2.Hit = value;
    		}
    	}

    	public bool 前翅_紋1_表示
    	{
    		get
    		{
    			return X0Y0_前翅_紋1.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_紋1.Dra = value;
    			X0Y1_前翅_紋1.Dra = value;
    			X0Y0_前翅_紋1.Hit = value;
    			X0Y1_前翅_紋1.Hit = value;
    		}
    	}

    	public bool 前翅_紋2_表示
    	{
    		get
    		{
    			return X0Y0_前翅_紋2.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_紋2.Dra = value;
    			X0Y1_前翅_紋2.Dra = value;
    			X0Y0_前翅_紋2.Hit = value;
    			X0Y1_前翅_紋2.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 前翅_前翅1_表示;
    		}
    		set
    		{
    			前翅_前翅1_表示 = value;
    			前翅_翅脈線1_表示 = value;
    			前翅_翅脈線2_表示 = value;
    			前翅_翅脈線3_表示 = value;
    			前翅_翅脈線4_表示 = value;
    			前翅_翅脈線5_表示 = value;
    			前翅_翅脈線6_表示 = value;
    			前翅_翅脈線7_表示 = value;
    			前翅_翅脈線8_表示 = value;
    			前翅_前翅2_表示 = value;
    			前翅_紋1_表示 = value;
    			前翅_紋2_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 前翅_前翅1CD.不透明度;
    		}
    		set
    		{
    			前翅_前翅1CD.不透明度 = value;
    			前翅_翅脈線1CD.不透明度 = value;
    			前翅_翅脈線2CD.不透明度 = value;
    			前翅_翅脈線3CD.不透明度 = value;
    			前翅_翅脈線4CD.不透明度 = value;
    			前翅_翅脈線5CD.不透明度 = value;
    			前翅_翅脈線6CD.不透明度 = value;
    			前翅_翅脈線7CD.不透明度 = value;
    			前翅_翅脈線8CD.不透明度 = value;
    			前翅_前翅2CD.不透明度 = value;
    			前翅_紋1CD.不透明度 = value;
    			前翅_紋2CD.不透明度 = value;
    		}
    	}

    	public double 展開
    	{
    		set
    		{
    			double num = value.Inverse();
    			double num2 = (右 ? (-1.0) : 1.0);
    			X0Y0_前翅_前翅1.SetAngleCont(num2 * -102.15 * num);
    			X0Y1_前翅_前翅1.SetAngleCont(num2 * -102.15 * num);
    		}
    	}

    	public 前翅_草(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 前翅_草D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.肢左["前翅"][3]);
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0]["前翅"].ToPars();
    		X0Y0_前翅_前翅1 = pars["前翅1"].ToPar();
    		X0Y0_前翅_翅脈線1 = pars["翅脈線1"].ToPar();
    		X0Y0_前翅_翅脈線2 = pars["翅脈線2"].ToPar();
    		X0Y0_前翅_翅脈線3 = pars["翅脈線3"].ToPar();
    		X0Y0_前翅_翅脈線4 = pars["翅脈線4"].ToPar();
    		X0Y0_前翅_翅脈線5 = pars["翅脈線5"].ToPar();
    		X0Y0_前翅_翅脈線6 = pars["翅脈線6"].ToPar();
    		X0Y0_前翅_翅脈線7 = pars["翅脈線7"].ToPar();
    		X0Y0_前翅_翅脈線8 = pars["翅脈線8"].ToPar();
    		X0Y0_前翅_前翅2 = pars["前翅2"].ToPar();
    		X0Y0_前翅_紋1 = pars["紋1"].ToPar();
    		X0Y0_前翅_紋2 = pars["紋2"].ToPar();
    		pars = Body[0][1]["前翅"].ToPars();
    		X0Y1_前翅_前翅1 = pars["前翅1"].ToPar();
    		X0Y1_前翅_翅脈線1 = pars["翅脈線1"].ToPar();
    		X0Y1_前翅_翅脈線2 = pars["翅脈線2"].ToPar();
    		X0Y1_前翅_翅脈線3 = pars["翅脈線3"].ToPar();
    		X0Y1_前翅_翅脈線4 = pars["翅脈線4"].ToPar();
    		X0Y1_前翅_翅脈線5 = pars["翅脈線5"].ToPar();
    		X0Y1_前翅_翅脈線6 = pars["翅脈線6"].ToPar();
    		X0Y1_前翅_翅脈線7 = pars["翅脈線7"].ToPar();
    		X0Y1_前翅_翅脈線8 = pars["翅脈線8"].ToPar();
    		X0Y1_前翅_前翅2 = pars["前翅2"].ToPar();
    		X0Y1_前翅_紋1 = pars["紋1"].ToPar();
    		X0Y1_前翅_紋2 = pars["紋2"].ToPar();
    		Xasix = false;
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
    		前翅_前翅1_表示 = e.前翅_前翅1_表示;
    		前翅_翅脈線1_表示 = e.前翅_翅脈線1_表示;
    		前翅_翅脈線2_表示 = e.前翅_翅脈線2_表示;
    		前翅_翅脈線3_表示 = e.前翅_翅脈線3_表示;
    		前翅_翅脈線4_表示 = e.前翅_翅脈線4_表示;
    		前翅_翅脈線5_表示 = e.前翅_翅脈線5_表示;
    		前翅_翅脈線6_表示 = e.前翅_翅脈線6_表示;
    		前翅_翅脈線7_表示 = e.前翅_翅脈線7_表示;
    		前翅_翅脈線8_表示 = e.前翅_翅脈線8_表示;
    		前翅_前翅2_表示 = e.前翅_前翅2_表示;
    		前翅_紋1_表示 = e.前翅_紋1_表示;
    		前翅_紋2_表示 = e.前翅_紋2_表示;
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
    		X0Y0_前翅_前翅1CP = new ColorP(X0Y0_前翅_前翅1, 前翅_前翅1CD, DisUnit, abj: true);
    		X0Y0_前翅_翅脈線1CP = new ColorP(X0Y0_前翅_翅脈線1, 前翅_翅脈線1CD, DisUnit, abj: true);
    		X0Y0_前翅_翅脈線2CP = new ColorP(X0Y0_前翅_翅脈線2, 前翅_翅脈線2CD, DisUnit, abj: true);
    		X0Y0_前翅_翅脈線3CP = new ColorP(X0Y0_前翅_翅脈線3, 前翅_翅脈線3CD, DisUnit, abj: true);
    		X0Y0_前翅_翅脈線4CP = new ColorP(X0Y0_前翅_翅脈線4, 前翅_翅脈線4CD, DisUnit, abj: true);
    		X0Y0_前翅_翅脈線5CP = new ColorP(X0Y0_前翅_翅脈線5, 前翅_翅脈線5CD, DisUnit, abj: true);
    		X0Y0_前翅_翅脈線6CP = new ColorP(X0Y0_前翅_翅脈線6, 前翅_翅脈線6CD, DisUnit, abj: true);
    		X0Y0_前翅_翅脈線7CP = new ColorP(X0Y0_前翅_翅脈線7, 前翅_翅脈線7CD, DisUnit, abj: true);
    		X0Y0_前翅_翅脈線8CP = new ColorP(X0Y0_前翅_翅脈線8, 前翅_翅脈線8CD, DisUnit, abj: true);
    		X0Y0_前翅_前翅2CP = new ColorP(X0Y0_前翅_前翅2, 前翅_前翅2CD, DisUnit, abj: true);
    		X0Y0_前翅_紋1CP = new ColorP(X0Y0_前翅_紋1, 前翅_紋1CD, DisUnit, abj: true);
    		X0Y0_前翅_紋2CP = new ColorP(X0Y0_前翅_紋2, 前翅_紋2CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅1CP = new ColorP(X0Y1_前翅_前翅1, 前翅_前翅1CD, DisUnit, abj: true);
    		X0Y1_前翅_翅脈線1CP = new ColorP(X0Y1_前翅_翅脈線1, 前翅_翅脈線1CD, DisUnit, abj: true);
    		X0Y1_前翅_翅脈線2CP = new ColorP(X0Y1_前翅_翅脈線2, 前翅_翅脈線2CD, DisUnit, abj: true);
    		X0Y1_前翅_翅脈線3CP = new ColorP(X0Y1_前翅_翅脈線3, 前翅_翅脈線3CD, DisUnit, abj: true);
    		X0Y1_前翅_翅脈線4CP = new ColorP(X0Y1_前翅_翅脈線4, 前翅_翅脈線4CD, DisUnit, abj: true);
    		X0Y1_前翅_翅脈線5CP = new ColorP(X0Y1_前翅_翅脈線5, 前翅_翅脈線5CD, DisUnit, abj: true);
    		X0Y1_前翅_翅脈線6CP = new ColorP(X0Y1_前翅_翅脈線6, 前翅_翅脈線6CD, DisUnit, abj: true);
    		X0Y1_前翅_翅脈線7CP = new ColorP(X0Y1_前翅_翅脈線7, 前翅_翅脈線7CD, DisUnit, abj: true);
    		X0Y1_前翅_翅脈線8CP = new ColorP(X0Y1_前翅_翅脈線8, 前翅_翅脈線8CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅2CP = new ColorP(X0Y1_前翅_前翅2, 前翅_前翅2CD, DisUnit, abj: true);
    		X0Y1_前翅_紋1CP = new ColorP(X0Y1_前翅_紋1, 前翅_紋1CD, DisUnit, abj: true);
    		X0Y1_前翅_紋2CP = new ColorP(X0Y1_前翅_紋2, 前翅_紋2CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_前翅_前翅1.SetAngleBase(num * 10.0);
    		X0Y1_前翅_前翅1.SetAngleBase(num * 10.0);
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		if (Body.GetIndexY() == 0)
    		{
    			X0Y0_前翅_前翅1CP.Update();
    			X0Y0_前翅_翅脈線1CP.Update();
    			X0Y0_前翅_翅脈線2CP.Update();
    			X0Y0_前翅_翅脈線3CP.Update();
    			X0Y0_前翅_翅脈線4CP.Update();
    			X0Y0_前翅_翅脈線5CP.Update();
    			X0Y0_前翅_翅脈線6CP.Update();
    			X0Y0_前翅_翅脈線7CP.Update();
    			X0Y0_前翅_翅脈線8CP.Update();
    			X0Y0_前翅_前翅2CP.Update();
    			X0Y0_前翅_紋1CP.Update();
    			X0Y0_前翅_紋2CP.Update();
    		}
    		else
    		{
    			X0Y1_前翅_前翅1CP.Update();
    			X0Y1_前翅_翅脈線1CP.Update();
    			X0Y1_前翅_翅脈線2CP.Update();
    			X0Y1_前翅_翅脈線3CP.Update();
    			X0Y1_前翅_翅脈線4CP.Update();
    			X0Y1_前翅_翅脈線5CP.Update();
    			X0Y1_前翅_翅脈線6CP.Update();
    			X0Y1_前翅_翅脈線7CP.Update();
    			X0Y1_前翅_翅脈線8CP.Update();
    			X0Y1_前翅_前翅2CP.Update();
    			X0Y1_前翅_紋1CP.Update();
    			X0Y1_前翅_紋2CP.Update();
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		Col.Alpha(ref 体配色.体0O, 128, out var ret);
    		前翅_前翅1CD = new ColorD(ref Col.Black, ref ret);
    		前翅_翅脈線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
    		前翅_翅脈線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
    		前翅_翅脈線3CD = new ColorD(ref Col.Black, ref Color2.Empty);
    		前翅_翅脈線4CD = new ColorD(ref Col.Black, ref Color2.Empty);
    		前翅_翅脈線5CD = new ColorD(ref Col.Black, ref Color2.Empty);
    		前翅_翅脈線6CD = new ColorD(ref Col.Black, ref Color2.Empty);
    		前翅_翅脈線7CD = new ColorD(ref Col.Black, ref Color2.Empty);
    		前翅_翅脈線8CD = new ColorD(ref Col.Black, ref Color2.Empty);
    		前翅_前翅2CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		前翅_紋1CD = new ColorD(ref Col.Black, ref 体配色.紋R);
    		前翅_紋2CD = new ColorD(ref Col.Black, ref 体配色.紋R);
    	}
    }
}
