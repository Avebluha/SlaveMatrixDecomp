using _2DGAMELIB;

namespace SlaveMatrix
{
    public class BackHair0_ジグ : 下ろし
    {
    	public ShapePart X0Y0_髪基;

    	public ShapePart X0Y0_髪中;

    	public ShapePart X0Y0_髪左1;

    	public ShapePart X0Y0_髪左2;

    	public ShapePart X0Y0_髪左3;

    	public ShapePart X0Y0_髪左4;

    	public ShapePart X0Y0_髪左5;

    	public ShapePart X0Y0_髪右1;

    	public ShapePart X0Y0_髪右2;

    	public ShapePart X0Y0_髪右3;

    	public ShapePart X0Y0_髪右4;

    	public ShapePart X0Y0_髪右5;

    	public ColorD 髪基CD;

    	public ColorD 髪中CD;

    	public ColorD 髪左1CD;

    	public ColorD 髪左2CD;

    	public ColorD 髪左3CD;

    	public ColorD 髪左4CD;

    	public ColorD 髪左5CD;

    	public ColorD 髪右1CD;

    	public ColorD 髪右2CD;

    	public ColorD 髪右3CD;

    	public ColorD 髪右4CD;

    	public ColorD 髪右5CD;

    	public ColorP X0Y0_髪基CP;

    	public ColorP X0Y0_髪中CP;

    	public ColorP X0Y0_髪左1CP;

    	public ColorP X0Y0_髪左2CP;

    	public ColorP X0Y0_髪左3CP;

    	public ColorP X0Y0_髪左4CP;

    	public ColorP X0Y0_髪左5CP;

    	public ColorP X0Y0_髪右1CP;

    	public ColorP X0Y0_髪右2CP;

    	public ColorP X0Y0_髪右3CP;

    	public ColorP X0Y0_髪右4CP;

    	public ColorP X0Y0_髪右5CP;

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

    	public bool 髪中_表示
    	{
    		get
    		{
    			return X0Y0_髪中.Dra;
    		}
    		set
    		{
    			X0Y0_髪中.Dra = value;
    			X0Y0_髪中.Hit = value;
    		}
    	}

    	public bool 髪左1_表示
    	{
    		get
    		{
    			return X0Y0_髪左1.Dra;
    		}
    		set
    		{
    			X0Y0_髪左1.Dra = value;
    			X0Y0_髪左1.Hit = value;
    		}
    	}

    	public bool 髪左2_表示
    	{
    		get
    		{
    			return X0Y0_髪左2.Dra;
    		}
    		set
    		{
    			X0Y0_髪左2.Dra = value;
    			X0Y0_髪左2.Hit = value;
    		}
    	}

    	public bool 髪左3_表示
    	{
    		get
    		{
    			return X0Y0_髪左3.Dra;
    		}
    		set
    		{
    			X0Y0_髪左3.Dra = value;
    			X0Y0_髪左3.Hit = value;
    		}
    	}

    	public bool 髪左4_表示
    	{
    		get
    		{
    			return X0Y0_髪左4.Dra;
    		}
    		set
    		{
    			X0Y0_髪左4.Dra = value;
    			X0Y0_髪左4.Hit = value;
    		}
    	}

    	public bool 髪左5_表示
    	{
    		get
    		{
    			return X0Y0_髪左5.Dra;
    		}
    		set
    		{
    			X0Y0_髪左5.Dra = value;
    			X0Y0_髪左5.Hit = value;
    		}
    	}

    	public bool 髪右1_表示
    	{
    		get
    		{
    			return X0Y0_髪右1.Dra;
    		}
    		set
    		{
    			X0Y0_髪右1.Dra = value;
    			X0Y0_髪右1.Hit = value;
    		}
    	}

    	public bool 髪右2_表示
    	{
    		get
    		{
    			return X0Y0_髪右2.Dra;
    		}
    		set
    		{
    			X0Y0_髪右2.Dra = value;
    			X0Y0_髪右2.Hit = value;
    		}
    	}

    	public bool 髪右3_表示
    	{
    		get
    		{
    			return X0Y0_髪右3.Dra;
    		}
    		set
    		{
    			X0Y0_髪右3.Dra = value;
    			X0Y0_髪右3.Hit = value;
    		}
    	}

    	public bool 髪右4_表示
    	{
    		get
    		{
    			return X0Y0_髪右4.Dra;
    		}
    		set
    		{
    			X0Y0_髪右4.Dra = value;
    			X0Y0_髪右4.Hit = value;
    		}
    	}

    	public bool 髪右5_表示
    	{
    		get
    		{
    			return X0Y0_髪右5.Dra;
    		}
    		set
    		{
    			X0Y0_髪右5.Dra = value;
    			X0Y0_髪右5.Hit = value;
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
    			髪中_表示 = value;
    			髪左1_表示 = value;
    			髪左2_表示 = value;
    			髪左3_表示 = value;
    			髪左4_表示 = value;
    			髪左5_表示 = value;
    			髪右1_表示 = value;
    			髪右2_表示 = value;
    			髪右3_表示 = value;
    			髪右4_表示 = value;
    			髪右5_表示 = value;
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
    			髪中CD.不透明度 = value;
    			髪左1CD.不透明度 = value;
    			髪左2CD.不透明度 = value;
    			髪左3CD.不透明度 = value;
    			髪左4CD.不透明度 = value;
    			髪左5CD.不透明度 = value;
    			髪右1CD.不透明度 = value;
    			髪右2CD.不透明度 = value;
    			髪右3CD.不透明度 = value;
    			髪右4CD.不透明度 = value;
    			髪右5CD.不透明度 = value;
    		}
    	}

    	public double 髪長0
    	{
    		set
    		{
    			double num = 0.7 + 0.3 * value;
    			X0Y0_髪基.SizeYBase *= num;
    		}
    	}

    	public double 髪長1
    	{
    		set
    		{
    			double num = 0.4 + 0.91 * value;
    			X0Y0_髪中.SizeYBase *= num;
    			X0Y0_髪左1.SizeYBase *= num;
    			X0Y0_髪左2.SizeYBase *= num;
    			X0Y0_髪左3.SizeYBase *= num;
    			X0Y0_髪左4.SizeYBase *= num;
    			X0Y0_髪左5.SizeYBase *= num;
    			X0Y0_髪右1.SizeYBase *= num;
    			X0Y0_髪右2.SizeYBase *= num;
    			X0Y0_髪右3.SizeYBase *= num;
    			X0Y0_髪右4.SizeYBase *= num;
    			X0Y0_髪右5.SizeYBase *= num;
    		}
    	}

    	public double 毛量
    	{
    		set
    		{
    			double num = 1.0 + 0.5 * value;
    			X0Y0_髪中.SizeXBase *= num;
    			X0Y0_髪左1.SizeXBase *= num;
    			X0Y0_髪左2.SizeXBase *= num;
    			X0Y0_髪左3.SizeXBase *= num;
    			X0Y0_髪左4.SizeXBase *= num;
    			X0Y0_髪左5.SizeXBase *= num;
    			X0Y0_髪右1.SizeXBase *= num;
    			X0Y0_髪右2.SizeXBase *= num;
    			X0Y0_髪右3.SizeXBase *= num;
    			X0Y0_髪右4.SizeXBase *= num;
    			X0Y0_髪右5.SizeXBase *= num;
    		}
    	}

    	public double 広がり
    	{
    		set
    		{
    			X0Y0_髪左1.AngleBase = 1.5 * value;
    			X0Y0_髪左2.AngleBase = 3.0 * value;
    			X0Y0_髪左3.AngleBase = 4.5 * value;
    			X0Y0_髪左4.AngleBase = 6.0 * value;
    			X0Y0_髪左5.AngleBase = 7.5 * value;
    			X0Y0_髪右1.AngleBase = -1.5 * value;
    			X0Y0_髪右2.AngleBase = -3.0 * value;
    			X0Y0_髪右3.AngleBase = -4.5 * value;
    			X0Y0_髪右4.AngleBase = -6.0 * value;
    			X0Y0_髪右5.AngleBase = -7.5 * value;
    		}
    	}

    	public BackHair0_ジグ(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, BackHair0_ジグD e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "ジグ";
    		dif.Add(new PartGroup(Sta.胴体["BackHair0"][0][0]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_髪基 = partGroup["髪基"].ToPar();
    		X0Y0_髪中 = partGroup["髪中"].ToPar();
    		X0Y0_髪左1 = partGroup["髪左1"].ToPar();
    		X0Y0_髪左2 = partGroup["髪左2"].ToPar();
    		X0Y0_髪左3 = partGroup["髪左3"].ToPar();
    		X0Y0_髪左4 = partGroup["髪左4"].ToPar();
    		X0Y0_髪左5 = partGroup["髪左5"].ToPar();
    		X0Y0_髪右1 = partGroup["髪右1"].ToPar();
    		X0Y0_髪右2 = partGroup["髪右2"].ToPar();
    		X0Y0_髪右3 = partGroup["髪右3"].ToPar();
    		X0Y0_髪右4 = partGroup["髪右4"].ToPar();
    		X0Y0_髪右5 = partGroup["髪右5"].ToPar();
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
    		髪中_表示 = e.髪中_表示;
    		髪左1_表示 = e.髪左1_表示;
    		髪左2_表示 = e.髪左2_表示;
    		髪左3_表示 = e.髪左3_表示;
    		髪左4_表示 = e.髪左4_表示;
    		髪左5_表示 = e.髪左5_表示;
    		髪右1_表示 = e.髪右1_表示;
    		髪右2_表示 = e.髪右2_表示;
    		髪右3_表示 = e.髪右3_表示;
    		髪右4_表示 = e.髪右4_表示;
    		髪右5_表示 = e.髪右5_表示;
    		髪長0 = e.髪長0;
    		髪長1 = e.髪長1;
    		毛量 = e.毛量;
    		広がり = e.広がり;
    		if (e.スライム)
    		{
    			スライム();
    		}
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
    		X0Y0_髪中CP = new ColorP(X0Y0_髪中, 髪中CD, DisUnit, abj: false);
    		X0Y0_髪左1CP = new ColorP(X0Y0_髪左1, 髪左1CD, DisUnit, abj: false);
    		X0Y0_髪左2CP = new ColorP(X0Y0_髪左2, 髪左2CD, DisUnit, abj: false);
    		X0Y0_髪左3CP = new ColorP(X0Y0_髪左3, 髪左3CD, DisUnit, abj: false);
    		X0Y0_髪左4CP = new ColorP(X0Y0_髪左4, 髪左4CD, DisUnit, abj: false);
    		X0Y0_髪左5CP = new ColorP(X0Y0_髪左5, 髪左5CD, DisUnit, abj: false);
    		X0Y0_髪右1CP = new ColorP(X0Y0_髪右1, 髪右1CD, DisUnit, abj: false);
    		X0Y0_髪右2CP = new ColorP(X0Y0_髪右2, 髪右2CD, DisUnit, abj: false);
    		X0Y0_髪右3CP = new ColorP(X0Y0_髪右3, 髪右3CD, DisUnit, abj: false);
    		X0Y0_髪右4CP = new ColorP(X0Y0_髪右4, 髪右4CD, DisUnit, abj: false);
    		X0Y0_髪右5CP = new ColorP(X0Y0_髪右5, 髪右5CD, DisUnit, abj: false);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		_ = 右;
    		Body.JoinPAall();
    	}

    	public void スライム()
    	{
    		X0Y0_髪基.OP[右 ? 1 : 0].Outline = false;
    		X0Y0_髪基.OP[(!右) ? 1 : 0].Outline = false;
    		X0Y0_髪中.OP[右 ? 3 : 0].Outline = false;
    		X0Y0_髪中.OP[(!右) ? 1 : 2].Outline = false;
    		X0Y0_髪中.OP[右 ? 1 : 2].Outline = false;
    		X0Y0_髪中.OP[(!右) ? 3 : 0].Outline = false;
    		X0Y0_髪左1.OP[右 ? 3 : 0].Outline = false;
    		X0Y0_髪左1.OP[(!右) ? 1 : 2].Outline = false;
    		X0Y0_髪左1.OP[右 ? 1 : 2].Outline = false;
    		X0Y0_髪左1.OP[(!右) ? 3 : 0].Outline = false;
    		X0Y0_髪左2.OP[右 ? 3 : 0].Outline = false;
    		X0Y0_髪左2.OP[(!右) ? 1 : 2].Outline = false;
    		X0Y0_髪左2.OP[右 ? 1 : 2].Outline = false;
    		X0Y0_髪左2.OP[(!右) ? 3 : 0].Outline = false;
    		X0Y0_髪左3.OP[右 ? 3 : 0].Outline = false;
    		X0Y0_髪左3.OP[(!右) ? 1 : 2].Outline = false;
    		X0Y0_髪左3.OP[右 ? 1 : 2].Outline = false;
    		X0Y0_髪左3.OP[(!右) ? 3 : 0].Outline = false;
    		X0Y0_髪左4.OP[右 ? 3 : 0].Outline = false;
    		X0Y0_髪左4.OP[(!右) ? 1 : 2].Outline = false;
    		X0Y0_髪左4.OP[右 ? 1 : 2].Outline = false;
    		X0Y0_髪左4.OP[(!右) ? 3 : 0].Outline = false;
    		X0Y0_髪左5.OP[右 ? 3 : 0].Outline = false;
    		X0Y0_髪左5.OP[(!右) ? 1 : 2].Outline = false;
    		X0Y0_髪左5.OP[右 ? 1 : 2].Outline = false;
    		X0Y0_髪左5.OP[(!右) ? 3 : 0].Outline = false;
    		X0Y0_髪右1.OP[右 ? 3 : 0].Outline = false;
    		X0Y0_髪右1.OP[(!右) ? 1 : 2].Outline = false;
    		X0Y0_髪右1.OP[右 ? 1 : 2].Outline = false;
    		X0Y0_髪右1.OP[(!右) ? 3 : 0].Outline = false;
    		X0Y0_髪右2.OP[右 ? 3 : 0].Outline = false;
    		X0Y0_髪右2.OP[(!右) ? 1 : 2].Outline = false;
    		X0Y0_髪右2.OP[右 ? 1 : 2].Outline = false;
    		X0Y0_髪右2.OP[(!右) ? 3 : 0].Outline = false;
    		X0Y0_髪右3.OP[右 ? 3 : 0].Outline = false;
    		X0Y0_髪右3.OP[(!右) ? 1 : 2].Outline = false;
    		X0Y0_髪右3.OP[右 ? 1 : 2].Outline = false;
    		X0Y0_髪右3.OP[(!右) ? 3 : 0].Outline = false;
    		X0Y0_髪右4.OP[右 ? 3 : 0].Outline = false;
    		X0Y0_髪右4.OP[(!右) ? 1 : 2].Outline = false;
    		X0Y0_髪右4.OP[右 ? 1 : 2].Outline = false;
    		X0Y0_髪右4.OP[(!右) ? 3 : 0].Outline = false;
    		X0Y0_髪右5.OP[右 ? 3 : 0].Outline = false;
    		X0Y0_髪右5.OP[(!右) ? 1 : 2].Outline = false;
    		X0Y0_髪右5.OP[右 ? 1 : 2].Outline = false;
    		X0Y0_髪右5.OP[(!右) ? 3 : 0].Outline = false;
    	}

    	public override void 色更新()
    	{
    		X0Y0_髪基CP.Update();
    		X0Y0_髪中CP.Update();
    		X0Y0_髪左1CP.Update();
    		X0Y0_髪左2CP.Update();
    		X0Y0_髪左3CP.Update();
    		X0Y0_髪左4CP.Update();
    		X0Y0_髪左5CP.Update();
    		X0Y0_髪右1CP.Update();
    		X0Y0_髪右2CP.Update();
    		X0Y0_髪右3CP.Update();
    		X0Y0_髪右4CP.Update();
    		X0Y0_髪右5CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		髪基CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪中CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪左1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪左2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪左3CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪左4CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪左5CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪右1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪右2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪右3CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪右4CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪右5CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    	}
    }
}
