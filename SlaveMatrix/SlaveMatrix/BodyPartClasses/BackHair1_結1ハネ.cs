using _2DGAMELIB;

namespace SlaveMatrix
{
    public class BackHair1_結1ハネ : アップ
    {
    	public ShapePart X0Y0_髪基;

    	public ShapePart X0Y0_お下げ_髪根;

    	public ShapePart X0Y0_お下げ_髪左1;

    	public ShapePart X0Y0_お下げ_髪左2;

    	public ShapePart X0Y0_お下げ_髪左3;

    	public ShapePart X0Y0_お下げ_髪右1;

    	public ShapePart X0Y0_お下げ_髪右2;

    	public ShapePart X0Y0_お下げ_髪右3;

    	public ColorD 髪基CD;

    	public ColorD お下げ_髪根CD;

    	public ColorD お下げ_髪左1CD;

    	public ColorD お下げ_髪左2CD;

    	public ColorD お下げ_髪左3CD;

    	public ColorD お下げ_髪右1CD;

    	public ColorD お下げ_髪右2CD;

    	public ColorD お下げ_髪右3CD;

    	public ColorP X0Y0_髪基CP;

    	public ColorP X0Y0_お下げ_髪根CP;

    	public ColorP X0Y0_お下げ_髪左1CP;

    	public ColorP X0Y0_お下げ_髪左2CP;

    	public ColorP X0Y0_お下げ_髪左3CP;

    	public ColorP X0Y0_お下げ_髪右1CP;

    	public ColorP X0Y0_お下げ_髪右2CP;

    	public ColorP X0Y0_お下げ_髪右3CP;

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

    	public bool お下げ_髪根_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_髪根.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_髪根.Dra = value;
    			X0Y0_お下げ_髪根.Hit = value;
    		}
    	}

    	public bool お下げ_髪左1_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_髪左1.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_髪左1.Dra = value;
    			X0Y0_お下げ_髪左1.Hit = value;
    		}
    	}

    	public bool お下げ_髪左2_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_髪左2.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_髪左2.Dra = value;
    			X0Y0_お下げ_髪左2.Hit = value;
    		}
    	}

    	public bool お下げ_髪左3_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_髪左3.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_髪左3.Dra = value;
    			X0Y0_お下げ_髪左3.Hit = value;
    		}
    	}

    	public bool お下げ_髪右1_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_髪右1.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_髪右1.Dra = value;
    			X0Y0_お下げ_髪右1.Hit = value;
    		}
    	}

    	public bool お下げ_髪右2_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_髪右2.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_髪右2.Dra = value;
    			X0Y0_お下げ_髪右2.Hit = value;
    		}
    	}

    	public bool お下げ_髪右3_表示
    	{
    		get
    		{
    			return X0Y0_お下げ_髪右3.Dra;
    		}
    		set
    		{
    			X0Y0_お下げ_髪右3.Dra = value;
    			X0Y0_お下げ_髪右3.Hit = value;
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
    			お下げ_髪根_表示 = value;
    			お下げ_髪左1_表示 = value;
    			お下げ_髪左2_表示 = value;
    			お下げ_髪左3_表示 = value;
    			お下げ_髪右1_表示 = value;
    			お下げ_髪右2_表示 = value;
    			お下げ_髪右3_表示 = value;
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
    			お下げ_髪根CD.不透明度 = value;
    			お下げ_髪左1CD.不透明度 = value;
    			お下げ_髪左2CD.不透明度 = value;
    			お下げ_髪左3CD.不透明度 = value;
    			お下げ_髪右1CD.不透明度 = value;
    			お下げ_髪右2CD.不透明度 = value;
    			お下げ_髪右3CD.不透明度 = value;
    		}
    	}

    	public double 髪長
    	{
    		set
    		{
    			double num = 0.5 + 0.9 * value;
    			X0Y0_お下げ_髪根.SizeYBase *= num;
    			X0Y0_お下げ_髪左1.SizeYBase *= num;
    			X0Y0_お下げ_髪左2.SizeYBase *= num;
    			X0Y0_お下げ_髪左3.SizeYBase *= num;
    			X0Y0_お下げ_髪右1.SizeYBase *= num;
    			X0Y0_お下げ_髪右2.SizeYBase *= num;
    			X0Y0_お下げ_髪右3.SizeYBase *= num;
    		}
    	}

    	public double 毛量
    	{
    		set
    		{
    			double num = 1.0 + 0.5 * value;
    			X0Y0_お下げ_髪根.SizeXBase *= num;
    			X0Y0_お下げ_髪左1.SizeXBase *= num;
    			X0Y0_お下げ_髪左2.SizeXBase *= num;
    			X0Y0_お下げ_髪左3.SizeXBase *= num;
    			X0Y0_お下げ_髪右1.SizeXBase *= num;
    			X0Y0_お下げ_髪右2.SizeXBase *= num;
    			X0Y0_お下げ_髪右3.SizeXBase *= num;
    		}
    	}

    	public double 広がり
    	{
    		set
    		{
    			X0Y0_お下げ_髪左1.AngleBase = 1.5 * value;
    			X0Y0_お下げ_髪左2.AngleBase = 1.5 * value;
    			X0Y0_お下げ_髪左3.AngleBase = 1.5 * value;
    			X0Y0_お下げ_髪右1.AngleBase = -1.5 * value;
    			X0Y0_お下げ_髪右2.AngleBase = -1.5 * value;
    			X0Y0_お下げ_髪右3.AngleBase = -1.5 * value;
    		}
    	}

    	public double 高さ
    	{
    		set
    		{
    			X0Y0_お下げ_髪根.PositionCont = new Vector2D(X0Y0_お下げ_髪根.PositionCont.X, X0Y0_お下げ_髪根.PositionCont.Y + 0.02 * value.Inverse());
    		}
    	}

    	public BackHair1_結1ハネ(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, BackHair1_結1ハネD e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant();
    		morphVariant.Tag = "結い1ハネ";
    		morphVariant.Add(new PartGroup(GlobalState.胴体["BackHair1"][0][1]));
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_髪基 = partGroup["髪基"].ToPar();
    		PartGroup pars2 = partGroup["お下げ"].ToPars();
    		X0Y0_お下げ_髪根 = pars2["髪根"].ToPar();
    		X0Y0_お下げ_髪左1 = pars2["髪左1"].ToPar();
    		X0Y0_お下げ_髪左2 = pars2["髪左2"].ToPar();
    		X0Y0_お下げ_髪左3 = pars2["髪左3"].ToPar();
    		X0Y0_お下げ_髪右1 = pars2["髪右1"].ToPar();
    		X0Y0_お下げ_髪右2 = pars2["髪右2"].ToPar();
    		X0Y0_お下げ_髪右3 = pars2["髪右3"].ToPar();
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
    		お下げ_髪根_表示 = e.お下げ_髪根_表示;
    		お下げ_髪左1_表示 = e.お下げ_髪左1_表示;
    		お下げ_髪左2_表示 = e.お下げ_髪左2_表示;
    		お下げ_髪左3_表示 = e.お下げ_髪左3_表示;
    		お下げ_髪右1_表示 = e.お下げ_髪右1_表示;
    		お下げ_髪右2_表示 = e.お下げ_髪右2_表示;
    		お下げ_髪右3_表示 = e.お下げ_髪右3_表示;
    		髪長 = e.髪長;
    		毛量 = e.毛量;
    		広がり = e.広がり;
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
    		X0Y0_お下げ_髪根CP = new ColorP(X0Y0_お下げ_髪根, お下げ_髪根CD, DisUnit, abj: false);
    		X0Y0_お下げ_髪左1CP = new ColorP(X0Y0_お下げ_髪左1, お下げ_髪左1CD, DisUnit, abj: false);
    		X0Y0_お下げ_髪左2CP = new ColorP(X0Y0_お下げ_髪左2, お下げ_髪左2CD, DisUnit, abj: false);
    		X0Y0_お下げ_髪左3CP = new ColorP(X0Y0_お下げ_髪左3, お下げ_髪左3CD, DisUnit, abj: false);
    		X0Y0_お下げ_髪右1CP = new ColorP(X0Y0_お下げ_髪右1, お下げ_髪右1CD, DisUnit, abj: false);
    		X0Y0_お下げ_髪右2CP = new ColorP(X0Y0_お下げ_髪右2, お下げ_髪右2CD, DisUnit, abj: false);
    		X0Y0_お下げ_髪右3CP = new ColorP(X0Y0_お下げ_髪右3, お下げ_髪右3CD, DisUnit, abj: false);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_髪基CP.Update();
    		X0Y0_お下げ_髪根CP.Update();
    		X0Y0_お下げ_髪左1CP.Update();
    		X0Y0_お下げ_髪左2CP.Update();
    		X0Y0_お下げ_髪左3CP.Update();
    		X0Y0_お下げ_髪右1CP.Update();
    		X0Y0_お下げ_髪右2CP.Update();
    		X0Y0_お下げ_髪右3CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		髪基CD = new ColorD(ref ColorHelper.Empty, ref Color2.Empty);
    		お下げ_髪根CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_髪左1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_髪左2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_髪左3CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_髪右1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_髪右2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		お下げ_髪右3CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    	}
    }
}
