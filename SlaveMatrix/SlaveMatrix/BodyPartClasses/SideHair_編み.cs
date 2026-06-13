using _2DGAMELIB;

namespace SlaveMatrix
{
    public class SideHair_編み : SideHair
    {
    	public Par X0Y0_髪;

    	public Par X0Y0_編節1_髪節;

    	public Par X0Y0_編節1_髪編目;

    	public Par X0Y0_編節2_髪節;

    	public Par X0Y0_編節2_髪編目;

    	public Par X0Y0_編節3_髪節;

    	public Par X0Y0_編節3_髪編目;

    	public Par X0Y0_編節4_髪節;

    	public Par X0Y0_編節4_髪編目;

    	public Par X0Y0_髪縛1;

    	public Par X0Y0_髪縛2;

    	public Par X0Y0_髪左;

    	public Par X0Y0_髪右;

    	public Par X0Y0_髪根;

    	public ColorD 髪CD;

    	public ColorD 編節1_髪節CD;

    	public ColorD 編節1_髪編目CD;

    	public ColorD 編節2_髪節CD;

    	public ColorD 編節2_髪編目CD;

    	public ColorD 編節3_髪節CD;

    	public ColorD 編節3_髪編目CD;

    	public ColorD 編節4_髪節CD;

    	public ColorD 編節4_髪編目CD;

    	public ColorD 髪縛1CD;

    	public ColorD 髪縛2CD;

    	public ColorD 髪左CD;

    	public ColorD 髪右CD;

    	public ColorD 髪根CD;

    	public ColorP X0Y0_髪CP;

    	public ColorP X0Y0_編節1_髪節CP;

    	public ColorP X0Y0_編節1_髪編目CP;

    	public ColorP X0Y0_編節2_髪節CP;

    	public ColorP X0Y0_編節2_髪編目CP;

    	public ColorP X0Y0_編節3_髪節CP;

    	public ColorP X0Y0_編節3_髪編目CP;

    	public ColorP X0Y0_編節4_髪節CP;

    	public ColorP X0Y0_編節4_髪編目CP;

    	public ColorP X0Y0_髪縛1CP;

    	public ColorP X0Y0_髪縛2CP;

    	public ColorP X0Y0_髪左CP;

    	public ColorP X0Y0_髪右CP;

    	public ColorP X0Y0_髪根CP;

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

    	public bool 髪_表示
    	{
    		get
    		{
    			return X0Y0_髪.Dra;
    		}
    		set
    		{
    			X0Y0_髪.Dra = value;
    			X0Y0_髪.Hit = value;
    		}
    	}

    	public bool 編節1_髪節_表示
    	{
    		get
    		{
    			return X0Y0_編節1_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_編節1_髪節.Dra = value;
    			X0Y0_編節1_髪節.Hit = value;
    		}
    	}

    	public bool 編節1_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_編節1_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_編節1_髪編目.Dra = value;
    			X0Y0_編節1_髪編目.Hit = value;
    		}
    	}

    	public bool 編節2_髪節_表示
    	{
    		get
    		{
    			return X0Y0_編節2_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_編節2_髪節.Dra = value;
    			X0Y0_編節2_髪節.Hit = value;
    		}
    	}

    	public bool 編節2_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_編節2_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_編節2_髪編目.Dra = value;
    			X0Y0_編節2_髪編目.Hit = value;
    		}
    	}

    	public bool 編節3_髪節_表示
    	{
    		get
    		{
    			return X0Y0_編節3_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_編節3_髪節.Dra = value;
    			X0Y0_編節3_髪節.Hit = value;
    		}
    	}

    	public bool 編節3_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_編節3_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_編節3_髪編目.Dra = value;
    			X0Y0_編節3_髪編目.Hit = value;
    		}
    	}

    	public bool 編節4_髪節_表示
    	{
    		get
    		{
    			return X0Y0_編節4_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_編節4_髪節.Dra = value;
    			X0Y0_編節4_髪節.Hit = value;
    		}
    	}

    	public bool 編節4_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_編節4_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_編節4_髪編目.Dra = value;
    			X0Y0_編節4_髪編目.Hit = value;
    		}
    	}

    	public bool 髪縛1_表示
    	{
    		get
    		{
    			return X0Y0_髪縛1.Dra;
    		}
    		set
    		{
    			X0Y0_髪縛1.Dra = value;
    			X0Y0_髪縛1.Hit = value;
    		}
    	}

    	public bool 髪縛2_表示
    	{
    		get
    		{
    			return X0Y0_髪縛2.Dra;
    		}
    		set
    		{
    			X0Y0_髪縛2.Dra = value;
    			X0Y0_髪縛2.Hit = value;
    		}
    	}

    	public bool 髪左_表示
    	{
    		get
    		{
    			return X0Y0_髪左.Dra;
    		}
    		set
    		{
    			X0Y0_髪左.Dra = value;
    			X0Y0_髪左.Hit = value;
    		}
    	}

    	public bool 髪右_表示
    	{
    		get
    		{
    			return X0Y0_髪右.Dra;
    		}
    		set
    		{
    			X0Y0_髪右.Dra = value;
    			X0Y0_髪右.Hit = value;
    		}
    	}

    	public bool 髪根_表示
    	{
    		get
    		{
    			return X0Y0_髪根.Dra;
    		}
    		set
    		{
    			X0Y0_髪根.Dra = value;
    			X0Y0_髪根.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 髪_表示;
    		}
    		set
    		{
    			髪_表示 = value;
    			編節1_髪節_表示 = value;
    			編節1_髪編目_表示 = value;
    			編節2_髪節_表示 = value;
    			編節2_髪編目_表示 = value;
    			編節3_髪節_表示 = value;
    			編節3_髪編目_表示 = value;
    			編節4_髪節_表示 = value;
    			編節4_髪編目_表示 = value;
    			髪縛1_表示 = value;
    			髪縛2_表示 = value;
    			髪左_表示 = value;
    			髪右_表示 = value;
    			髪根_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 髪CD.不透明度;
    		}
    		set
    		{
    			髪CD.不透明度 = value;
    			編節1_髪節CD.不透明度 = value;
    			編節1_髪編目CD.不透明度 = value;
    			編節2_髪節CD.不透明度 = value;
    			編節2_髪編目CD.不透明度 = value;
    			編節3_髪節CD.不透明度 = value;
    			編節3_髪編目CD.不透明度 = value;
    			編節4_髪節CD.不透明度 = value;
    			編節4_髪編目CD.不透明度 = value;
    			髪縛1CD.不透明度 = value;
    			髪縛2CD.不透明度 = value;
    			髪左CD.不透明度 = value;
    			髪右CD.不透明度 = value;
    			髪根CD.不透明度 = value;
    		}
    	}

    	public double 髪長1
    	{
    		set
    		{
    			double num = 0.8 + 0.3 * value;
    			X0Y0_編節1_髪節.SetSizeYBase(X0Y0_編節1_髪節.GetSizeYBase() * num);
    			X0Y0_編節1_髪編目.SetSizeYBase(X0Y0_編節1_髪編目.GetSizeYBase() * num);
    			X0Y0_編節2_髪節.SetSizeYBase(X0Y0_編節2_髪節.GetSizeYBase() * num);
    			X0Y0_編節2_髪編目.SetSizeYBase(X0Y0_編節2_髪編目.GetSizeYBase() * num);
    			X0Y0_編節3_髪節.SetSizeYBase(X0Y0_編節3_髪節.GetSizeYBase() * num);
    			X0Y0_編節3_髪編目.SetSizeYBase(X0Y0_編節3_髪編目.GetSizeYBase() * num);
    			X0Y0_編節4_髪節.SetSizeYBase(X0Y0_編節4_髪節.GetSizeYBase() * num);
    			X0Y0_編節4_髪編目.SetSizeYBase(X0Y0_編節4_髪編目.GetSizeYBase() * num);
    		}
    	}

    	public double 髪長2
    	{
    		set
    		{
    			double num = 0.8 + 0.3 * value;
    			X0Y0_髪左.SetSizeYBase(X0Y0_髪左.GetSizeYBase() * num);
    			X0Y0_髪右.SetSizeYBase(X0Y0_髪右.GetSizeYBase() * num);
    			X0Y0_髪根.SetSizeYBase(X0Y0_髪根.GetSizeYBase() * num);
    		}
    	}

    	public double 毛量
    	{
    		set
    		{
    			double num = 1.0 + 0.5 * value;
    			X0Y0_編節1_髪節.SetSizeXBase(X0Y0_編節1_髪節.GetSizeXBase() * num);
    			X0Y0_編節1_髪編目.SetSizeXBase(X0Y0_編節1_髪編目.GetSizeXBase() * num);
    			X0Y0_編節2_髪節.SetSizeXBase(X0Y0_編節2_髪節.GetSizeXBase() * num);
    			X0Y0_編節2_髪編目.SetSizeXBase(X0Y0_編節2_髪編目.GetSizeXBase() * num);
    			X0Y0_編節3_髪節.SetSizeXBase(X0Y0_編節3_髪節.GetSizeXBase() * num);
    			X0Y0_編節3_髪編目.SetSizeXBase(X0Y0_編節3_髪編目.GetSizeXBase() * num);
    			X0Y0_編節4_髪節.SetSizeXBase(X0Y0_編節4_髪節.GetSizeXBase() * num);
    			X0Y0_編節4_髪編目.SetSizeXBase(X0Y0_編節4_髪編目.GetSizeXBase() * num);
    			X0Y0_髪縛1.SetSizeXBase(X0Y0_髪縛1.GetSizeXBase() * num);
    			X0Y0_髪縛2.SetSizeXBase(X0Y0_髪縛2.GetSizeXBase() * num);
    			X0Y0_髪左.SetSizeXBase(X0Y0_髪左.GetSizeXBase() * num);
    			X0Y0_髪右.SetSizeXBase(X0Y0_髪右.GetSizeXBase() * num);
    			X0Y0_髪根.SetSizeXBase(X0Y0_髪根.GetSizeXBase() * num);
    		}
    	}

    	public double 広がり
    	{
    		set
    		{
    			double num = (右 ? (-1.0) : 1.0);
    			X0Y0_髪左.SetAngleBase(num * 3.0 * value);
    			X0Y0_髪右.SetAngleBase(num * -3.0 * value);
    		}
    	}

    	public SideHair_編み(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, SideHair_編みD e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "編み";
    		dif.Add(new Pars(Sta.胴体["横髪左"][0][4]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_髪 = pars["髪"].ToPar();
    		Pars pars2 = pars["編節1"].ToPars();
    		X0Y0_編節1_髪節 = pars2["髪節"].ToPar();
    		X0Y0_編節1_髪編目 = pars2["髪編目"].ToPar();
    		pars2 = pars["編節2"].ToPars();
    		X0Y0_編節2_髪節 = pars2["髪節"].ToPar();
    		X0Y0_編節2_髪編目 = pars2["髪編目"].ToPar();
    		pars2 = pars["編節3"].ToPars();
    		X0Y0_編節3_髪節 = pars2["髪節"].ToPar();
    		X0Y0_編節3_髪編目 = pars2["髪編目"].ToPar();
    		pars2 = pars["編節4"].ToPars();
    		X0Y0_編節4_髪節 = pars2["髪節"].ToPar();
    		X0Y0_編節4_髪編目 = pars2["髪編目"].ToPar();
    		X0Y0_髪縛1 = pars["髪縛1"].ToPar();
    		X0Y0_髪縛2 = pars["髪縛2"].ToPar();
    		X0Y0_髪左 = pars["髪左"].ToPar();
    		X0Y0_髪右 = pars["髪右"].ToPar();
    		X0Y0_髪根 = pars["髪根"].ToPar();
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
    		髪_表示 = e.髪_表示;
    		編節1_髪節_表示 = e.編節1_髪節_表示;
    		編節1_髪編目_表示 = e.編節1_髪編目_表示;
    		編節2_髪節_表示 = e.編節2_髪節_表示;
    		編節2_髪編目_表示 = e.編節2_髪編目_表示;
    		編節3_髪節_表示 = e.編節3_髪節_表示;
    		編節3_髪編目_表示 = e.編節3_髪編目_表示;
    		編節4_髪節_表示 = e.編節4_髪節_表示;
    		編節4_髪編目_表示 = e.編節4_髪編目_表示;
    		髪縛1_表示 = e.髪縛1_表示;
    		髪縛2_表示 = e.髪縛2_表示;
    		髪左_表示 = e.髪左_表示;
    		髪右_表示 = e.髪右_表示;
    		髪根_表示 = e.髪根_表示;
    		髪長1 = e.髪長1;
    		髪長2 = e.髪長2;
    		毛量 = e.毛量;
    		広がり = e.広がり;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_髪CP = new ColorP(X0Y0_髪, 髪CD, DisUnit, abj: false);
    		X0Y0_編節1_髪節CP = new ColorP(X0Y0_編節1_髪節, 編節1_髪節CD, DisUnit, abj: false);
    		X0Y0_編節1_髪編目CP = new ColorP(X0Y0_編節1_髪編目, 編節1_髪編目CD, DisUnit, abj: false);
    		X0Y0_編節2_髪節CP = new ColorP(X0Y0_編節2_髪節, 編節2_髪節CD, DisUnit, abj: false);
    		X0Y0_編節2_髪編目CP = new ColorP(X0Y0_編節2_髪編目, 編節2_髪編目CD, DisUnit, abj: false);
    		X0Y0_編節3_髪節CP = new ColorP(X0Y0_編節3_髪節, 編節3_髪節CD, DisUnit, abj: false);
    		X0Y0_編節3_髪編目CP = new ColorP(X0Y0_編節3_髪編目, 編節3_髪編目CD, DisUnit, abj: false);
    		X0Y0_編節4_髪節CP = new ColorP(X0Y0_編節4_髪節, 編節4_髪節CD, DisUnit, abj: false);
    		X0Y0_編節4_髪編目CP = new ColorP(X0Y0_編節4_髪編目, 編節4_髪編目CD, DisUnit, abj: false);
    		X0Y0_髪縛1CP = new ColorP(X0Y0_髪縛1, 髪縛1CD, DisUnit, abj: true);
    		X0Y0_髪縛2CP = new ColorP(X0Y0_髪縛2, 髪縛2CD, DisUnit, abj: true);
    		X0Y0_髪左CP = new ColorP(X0Y0_髪左, 髪左CD, DisUnit, abj: false);
    		X0Y0_髪右CP = new ColorP(X0Y0_髪右, 髪右CD, DisUnit, abj: false);
    		X0Y0_髪根CP = new ColorP(X0Y0_髪根, 髪根CD, DisUnit, abj: false);
    		Intensity = e.濃度;
    	}

    	public override bool Is布(Par p)
    	{
    		if (p != X0Y0_髪縛1)
    		{
    			return p == X0Y0_髪縛2;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_髪CP.Update();
    		X0Y0_編節1_髪節CP.Update();
    		X0Y0_編節1_髪編目CP.Update();
    		X0Y0_編節2_髪節CP.Update();
    		X0Y0_編節2_髪編目CP.Update();
    		X0Y0_編節3_髪節CP.Update();
    		X0Y0_編節3_髪編目CP.Update();
    		X0Y0_編節4_髪節CP.Update();
    		X0Y0_編節4_髪編目CP.Update();
    		X0Y0_髪縛1CP.Update();
    		X0Y0_髪縛2CP.Update();
    		X0Y0_髪左CP.Update();
    		X0Y0_髪右CP.Update();
    		X0Y0_髪根CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		髪CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編節1_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編節1_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編節2_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編節2_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編節3_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編節3_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編節4_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編節4_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪縛1CD = new ColorD();
    		髪縛2CD = new ColorD();
    		髪左CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪右CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪根CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    	}

    	public void 髪留配色(髪留色 配色)
    	{
    		髪縛1CD.色 = 配色.髪留1色;
    		髪縛2CD.色 = 配色.髪留2色;
    	}
    }
}
