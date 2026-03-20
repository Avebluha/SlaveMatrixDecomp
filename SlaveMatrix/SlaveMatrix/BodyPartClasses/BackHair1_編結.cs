using _2DGAMELIB;

namespace SlaveMatrix
{
    public class BackHair1_編結 : アップ
    {
    	public Par X0Y0_髪基;

    	public Par X0Y0_お下げ_編節1_髪節;

    	public Par X0Y0_お下げ_編節1_髪編目;

    	public Par X0Y0_お下げ_編節2_髪節;

    	public Par X0Y0_お下げ_編節2_髪編目;

    	public Par X0Y0_お下げ_編節3_髪節;

    	public Par X0Y0_お下げ_編節3_髪編目;

    	public Par X0Y0_お下げ_編節4_髪節;

    	public Par X0Y0_お下げ_編節4_髪編目;

    	public Par X0Y0_お下げ_編節5_髪節;

    	public Par X0Y0_お下げ_編節5_髪編目;

    	public Par X0Y0_お下げ_編節6_髪節;

    	public Par X0Y0_お下げ_編節6_髪編目;

    	public Par X0Y0_お下げ_編節7_髪節;

    	public Par X0Y0_お下げ_編節7_髪編目;

    	public ColorD 髪基CD;

    	public ColorD お下げ_編節1_髪節CD;

    	public ColorD お下げ_編節1_髪編目CD;

    	public ColorD お下げ_編節2_髪節CD;

    	public ColorD お下げ_編節2_髪編目CD;

    	public ColorD お下げ_編節3_髪節CD;

    	public ColorD お下げ_編節3_髪編目CD;

    	public ColorD お下げ_編節4_髪節CD;

    	public ColorD お下げ_編節4_髪編目CD;

    	public ColorD お下げ_編節5_髪節CD;

    	public ColorD お下げ_編節5_髪編目CD;

    	public ColorD お下げ_編節6_髪節CD;

    	public ColorD お下げ_編節6_髪編目CD;

    	public ColorD お下げ_編節7_髪節CD;

    	public ColorD お下げ_編節7_髪編目CD;

    	public ColorP X0Y0_髪基CP;

    	public ColorP X0Y0_お下げ_編節1_髪節CP;

    	public ColorP X0Y0_お下げ_編節1_髪編目CP;

    	public ColorP X0Y0_お下げ_編節2_髪節CP;

    	public ColorP X0Y0_お下げ_編節2_髪編目CP;

    	public ColorP X0Y0_お下げ_編節3_髪節CP;

    	public ColorP X0Y0_お下げ_編節3_髪編目CP;

    	public ColorP X0Y0_お下げ_編節4_髪節CP;

    	public ColorP X0Y0_お下げ_編節4_髪編目CP;

    	public ColorP X0Y0_お下げ_編節5_髪節CP;

    	public ColorP X0Y0_お下げ_編節5_髪編目CP;

    	public ColorP X0Y0_お下げ_編節6_髪節CP;

    	public ColorP X0Y0_お下げ_編節6_髪編目CP;

    	public ColorP X0Y0_お下げ_編節7_髪節CP;

    	public ColorP X0Y0_お下げ_編節7_髪編目CP;

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

    	public bool 髪基_表示
    	{
    		get
    		{
    			return X0Y0_髪基.Dra;
    		}
    		set
    		{
    			X0Y0_髪基.Dra = value;
    			X0Y0_髪基.Hit = value;
    		}
    	}

    	public bool お下げ_編節1_髪節_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節1_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節1_髪節.Dra = value;
    			X0Y0_お下げ_編節1_髪節.Hit = value;
    		}
    	}

    	public bool お下げ_編節1_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節1_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節1_髪編目.Dra = value;
    			X0Y0_お下げ_編節1_髪編目.Hit = value;
    		}
    	}

    	public bool お下げ_編節2_髪節_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節2_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節2_髪節.Dra = value;
    			X0Y0_お下げ_編節2_髪節.Hit = value;
    		}
    	}

    	public bool お下げ_編節2_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節2_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節2_髪編目.Dra = value;
    			X0Y0_お下げ_編節2_髪編目.Hit = value;
    		}
    	}

    	public bool お下げ_編節3_髪節_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節3_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節3_髪節.Dra = value;
    			X0Y0_お下げ_編節3_髪節.Hit = value;
    		}
    	}

    	public bool お下げ_編節3_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節3_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節3_髪編目.Dra = value;
    			X0Y0_お下げ_編節3_髪編目.Hit = value;
    		}
    	}

    	public bool お下げ_編節4_髪節_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節4_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節4_髪節.Dra = value;
    			X0Y0_お下げ_編節4_髪節.Hit = value;
    		}
    	}

    	public bool お下げ_編節4_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節4_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節4_髪編目.Dra = value;
    			X0Y0_お下げ_編節4_髪編目.Hit = value;
    		}
    	}

    	public bool お下げ_編節5_髪節_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節5_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節5_髪節.Dra = value;
    			X0Y0_お下げ_編節5_髪節.Hit = value;
    		}
    	}

    	public bool お下げ_編節5_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節5_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節5_髪編目.Dra = value;
    			X0Y0_お下げ_編節5_髪編目.Hit = value;
    		}
    	}

    	public bool お下げ_編節6_髪節_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節6_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節6_髪節.Dra = value;
    			X0Y0_お下げ_編節6_髪節.Hit = value;
    		}
    	}

    	public bool お下げ_編節6_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節6_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節6_髪編目.Dra = value;
    			X0Y0_お下げ_編節6_髪編目.Hit = value;
    		}
    	}

    	public bool お下げ_編節7_髪節_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節7_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節7_髪節.Dra = value;
    			X0Y0_お下げ_編節7_髪節.Hit = value;
    		}
    	}

    	public bool お下げ_編節7_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_編節7_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_編節7_髪編目.Dra = value;
    			X0Y0_お下げ_編節7_髪編目.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 髪基_表示;
    		}
    		set
    		{
    			髪基_表示 = value;
    			お下げ_編節1_髪節_表示 = value;
    			お下げ_編節1_髪編目_表示 = value;
    			お下げ_編節2_髪節_表示 = value;
    			お下げ_編節2_髪編目_表示 = value;
    			お下げ_編節3_髪節_表示 = value;
    			お下げ_編節3_髪編目_表示 = value;
    			お下げ_編節4_髪節_表示 = value;
    			お下げ_編節4_髪編目_表示 = value;
    			お下げ_編節5_髪節_表示 = value;
    			お下げ_編節5_髪編目_表示 = value;
    			お下げ_編節6_髪節_表示 = value;
    			お下げ_編節6_髪編目_表示 = value;
    			お下げ_編節7_髪節_表示 = value;
    			お下げ_編節7_髪編目_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 髪基CD.不透明度;
    		}
    		set
    		{
    			髪基CD.不透明度 = value;
    			お下げ_編節1_髪節CD.不透明度 = value;
    			お下げ_編節1_髪編目CD.不透明度 = value;
    			お下げ_編節2_髪節CD.不透明度 = value;
    			お下げ_編節2_髪編目CD.不透明度 = value;
    			お下げ_編節3_髪節CD.不透明度 = value;
    			お下げ_編節3_髪編目CD.不透明度 = value;
    			お下げ_編節4_髪節CD.不透明度 = value;
    			お下げ_編節4_髪編目CD.不透明度 = value;
    			お下げ_編節5_髪節CD.不透明度 = value;
    			お下げ_編節5_髪編目CD.不透明度 = value;
    			お下げ_編節6_髪節CD.不透明度 = value;
    			お下げ_編節6_髪編目CD.不透明度 = value;
    			お下げ_編節7_髪節CD.不透明度 = value;
    			お下げ_編節7_髪編目CD.不透明度 = value;
    		}
    	}

    	public double 毛量
    	{
    		set
    		{
    			double num = 0.8 + 0.4 * value;
    			X0Y0_髪基.SizeBase *= num;
    			X0Y0_お下げ_編節1_髪節.SizeBase *= num;
    			X0Y0_お下げ_編節1_髪編目.SizeBase *= num;
    			X0Y0_お下げ_編節2_髪節.SizeBase *= num;
    			X0Y0_お下げ_編節2_髪編目.SizeBase *= num;
    			X0Y0_お下げ_編節3_髪節.SizeBase *= num;
    			X0Y0_お下げ_編節3_髪編目.SizeBase *= num;
    			X0Y0_お下げ_編節4_髪節.SizeBase *= num;
    			X0Y0_お下げ_編節4_髪編目.SizeBase *= num;
    			X0Y0_お下げ_編節5_髪節.SizeBase *= num;
    			X0Y0_お下げ_編節5_髪編目.SizeBase *= num;
    			X0Y0_お下げ_編節6_髪節.SizeBase *= num;
    			X0Y0_お下げ_編節6_髪編目.SizeBase *= num;
    			X0Y0_お下げ_編節7_髪節.SizeBase *= num;
    			X0Y0_お下げ_編節7_髪編目.SizeBase *= num;
    		}
    	}

    	public double 高さ
    	{
    		set
    		{
    			X0Y0_髪基.PositionCont = new Vector2D(X0Y0_髪基.PositionCont.X, X0Y0_髪基.PositionCont.Y + 0.02 * value.Inverse());
    		}
    	}

    	public BackHair1_編結(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, BackHair1_編結D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "編結";
    		dif.Add(new Pars(Sta.胴体["BackHair0"][0][20]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_髪基 = pars["髪基"].ToPar();
    		Pars pars2 = pars["お下げ"].ToPars();
    		Pars pars3 = pars2["編節1"].ToPars();
    		X0Y0_お下げ_編節1_髪節 = pars3["髪節"].ToPar();
    		X0Y0_お下げ_編節1_髪編目 = pars3["髪編目"].ToPar();
    		pars3 = pars2["編節2"].ToPars();
    		X0Y0_お下げ_編節2_髪節 = pars3["髪節"].ToPar();
    		X0Y0_お下げ_編節2_髪編目 = pars3["髪編目"].ToPar();
    		pars3 = pars2["編節3"].ToPars();
    		X0Y0_お下げ_編節3_髪節 = pars3["髪節"].ToPar();
    		X0Y0_お下げ_編節3_髪編目 = pars3["髪編目"].ToPar();
    		pars3 = pars2["編節4"].ToPars();
    		X0Y0_お下げ_編節4_髪節 = pars3["髪節"].ToPar();
    		X0Y0_お下げ_編節4_髪編目 = pars3["髪編目"].ToPar();
    		pars3 = pars2["編節5"].ToPars();
    		X0Y0_お下げ_編節5_髪節 = pars3["髪節"].ToPar();
    		X0Y0_お下げ_編節5_髪編目 = pars3["髪編目"].ToPar();
    		pars3 = pars2["編節6"].ToPars();
    		X0Y0_お下げ_編節6_髪節 = pars3["髪節"].ToPar();
    		X0Y0_お下げ_編節6_髪編目 = pars3["髪編目"].ToPar();
    		pars3 = pars2["編節7"].ToPars();
    		X0Y0_お下げ_編節7_髪節 = pars3["髪節"].ToPar();
    		X0Y0_お下げ_編節7_髪編目 = pars3["髪編目"].ToPar();
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
    		髪基_表示 = e.髪基_表示;
    		お下げ_編節1_髪節_表示 = e.お下げ_編節1_髪節_表示;
    		お下げ_編節1_髪編目_表示 = e.お下げ_編節1_髪編目_表示;
    		お下げ_編節2_髪節_表示 = e.お下げ_編節2_髪節_表示;
    		お下げ_編節2_髪編目_表示 = e.お下げ_編節2_髪編目_表示;
    		お下げ_編節3_髪節_表示 = e.お下げ_編節3_髪節_表示;
    		お下げ_編節3_髪編目_表示 = e.お下げ_編節3_髪編目_表示;
    		お下げ_編節4_髪節_表示 = e.お下げ_編節4_髪節_表示;
    		お下げ_編節4_髪編目_表示 = e.お下げ_編節4_髪編目_表示;
    		お下げ_編節5_髪節_表示 = e.お下げ_編節5_髪節_表示;
    		お下げ_編節5_髪編目_表示 = e.お下げ_編節5_髪編目_表示;
    		お下げ_編節6_髪節_表示 = e.お下げ_編節6_髪節_表示;
    		お下げ_編節6_髪編目_表示 = e.お下げ_編節6_髪編目_表示;
    		お下げ_編節7_髪節_表示 = e.お下げ_編節7_髪節_表示;
    		お下げ_編節7_髪編目_表示 = e.お下げ_編節7_髪編目_表示;
    		毛量 = e.毛量;
    		高さ = e.高さ;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_髪基CP = new ColorP(X0Y0_髪基, 髪基CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節1_髪節CP = new ColorP(X0Y0_お下げ_編節1_髪節, お下げ_編節1_髪節CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節1_髪編目CP = new ColorP(X0Y0_お下げ_編節1_髪編目, お下げ_編節1_髪編目CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節2_髪節CP = new ColorP(X0Y0_お下げ_編節2_髪節, お下げ_編節2_髪節CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節2_髪編目CP = new ColorP(X0Y0_お下げ_編節2_髪編目, お下げ_編節2_髪編目CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節3_髪節CP = new ColorP(X0Y0_お下げ_編節3_髪節, お下げ_編節3_髪節CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節3_髪編目CP = new ColorP(X0Y0_お下げ_編節3_髪編目, お下げ_編節3_髪編目CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節4_髪節CP = new ColorP(X0Y0_お下げ_編節4_髪節, お下げ_編節4_髪節CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節4_髪編目CP = new ColorP(X0Y0_お下げ_編節4_髪編目, お下げ_編節4_髪編目CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節5_髪節CP = new ColorP(X0Y0_お下げ_編節5_髪節, お下げ_編節5_髪節CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節5_髪編目CP = new ColorP(X0Y0_お下げ_編節5_髪編目, お下げ_編節5_髪編目CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節6_髪節CP = new ColorP(X0Y0_お下げ_編節6_髪節, お下げ_編節6_髪節CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節6_髪編目CP = new ColorP(X0Y0_お下げ_編節6_髪編目, お下げ_編節6_髪編目CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節7_髪節CP = new ColorP(X0Y0_お下げ_編節7_髪節, お下げ_編節7_髪節CD, DisUnit, abj: false);
    		X0Y0_お下げ_編節7_髪編目CP = new ColorP(X0Y0_お下げ_編節7_髪編目, お下げ_編節7_髪編目CD, DisUnit, abj: false);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		_ = 右;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		X0Y0_髪基CP.Update();
    		X0Y0_お下げ_編節1_髪節CP.Update();
    		X0Y0_お下げ_編節1_髪編目CP.Update();
    		X0Y0_お下げ_編節2_髪節CP.Update();
    		X0Y0_お下げ_編節2_髪編目CP.Update();
    		X0Y0_お下げ_編節3_髪節CP.Update();
    		X0Y0_お下げ_編節3_髪編目CP.Update();
    		X0Y0_お下げ_編節4_髪節CP.Update();
    		X0Y0_お下げ_編節4_髪編目CP.Update();
    		X0Y0_お下げ_編節5_髪節CP.Update();
    		X0Y0_お下げ_編節5_髪編目CP.Update();
    		X0Y0_お下げ_編節6_髪節CP.Update();
    		X0Y0_お下げ_編節6_髪編目CP.Update();
    		X0Y0_お下げ_編節7_髪節CP.Update();
    		X0Y0_お下げ_編節7_髪編目CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		髪基CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節1_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節1_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節2_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節2_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節3_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節3_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節4_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節4_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節5_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節5_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節6_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節6_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節7_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_編節7_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    	}
    }
}
