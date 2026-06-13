using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 角2_牛2 : 角2
    {
    	public ShapePart X0Y0_根;

    	public ShapePart X0Y0_凹1;

    	public ShapePart X0Y0_凹2;

    	public ShapePart X0Y0_凹3;

    	public ShapePart X0Y0_凹4;

    	public ShapePart X0Y0_凹5;

    	public ShapePart X0Y0_凹6;

    	public ShapePart X0Y0_線;

    	public ShapePart X0Y1_根;

    	public ShapePart X0Y1_凹1;

    	public ShapePart X0Y1_凹2;

    	public ColorD 根CD;

    	public ColorD 凹1CD;

    	public ColorD 凹2CD;

    	public ColorD 凹3CD;

    	public ColorD 凹4CD;

    	public ColorD 凹5CD;

    	public ColorD 凹6CD;

    	public ColorD 線CD;

    	public ColorP X0Y0_根CP;

    	public ColorP X0Y0_凹1CP;

    	public ColorP X0Y0_凹2CP;

    	public ColorP X0Y0_凹3CP;

    	public ColorP X0Y0_凹4CP;

    	public ColorP X0Y0_凹5CP;

    	public ColorP X0Y0_凹6CP;

    	public ColorP X0Y0_線CP;

    	public ColorP X0Y1_根CP;

    	public ColorP X0Y1_凹1CP;

    	public ColorP X0Y1_凹2CP;

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

    	public bool 根_表示
    	{
    		get
    		{
    			return X0Y0_根.Dra;
    		}
    		set
    		{
    			X0Y0_根.Dra = value;
    			X0Y1_根.Dra = value;
    			X0Y0_根.Hit = value;
    			X0Y1_根.Hit = value;
    		}
    	}

    	public bool 凹1_表示
    	{
    		get
    		{
    			return X0Y0_凹1.Dra;
    		}
    		set
    		{
    			X0Y0_凹1.Dra = value;
    			X0Y1_凹1.Dra = value;
    			X0Y0_凹1.Hit = value;
    			X0Y1_凹1.Hit = value;
    		}
    	}

    	public bool 凹2_表示
    	{
    		get
    		{
    			return X0Y0_凹2.Dra;
    		}
    		set
    		{
    			X0Y0_凹2.Dra = value;
    			X0Y1_凹2.Dra = value;
    			X0Y0_凹2.Hit = value;
    			X0Y1_凹2.Hit = value;
    		}
    	}

    	public bool 凹3_表示
    	{
    		get
    		{
    			return X0Y0_凹3.Dra;
    		}
    		set
    		{
    			X0Y0_凹3.Dra = value;
    			X0Y0_凹3.Hit = value;
    		}
    	}

    	public bool 凹4_表示
    	{
    		get
    		{
    			return X0Y0_凹4.Dra;
    		}
    		set
    		{
    			X0Y0_凹4.Dra = value;
    			X0Y0_凹4.Hit = value;
    		}
    	}

    	public bool 凹5_表示
    	{
    		get
    		{
    			return X0Y0_凹5.Dra;
    		}
    		set
    		{
    			X0Y0_凹5.Dra = value;
    			X0Y0_凹5.Hit = value;
    		}
    	}

    	public bool 凹6_表示
    	{
    		get
    		{
    			return X0Y0_凹6.Dra;
    		}
    		set
    		{
    			X0Y0_凹6.Dra = value;
    			X0Y0_凹6.Hit = value;
    		}
    	}

    	public bool 線_表示
    	{
    		get
    		{
    			return X0Y0_線.Dra;
    		}
    		set
    		{
    			X0Y0_線.Dra = value;
    			X0Y0_線.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 根_表示;
    		}
    		set
    		{
    			根_表示 = value;
    			凹1_表示 = value;
    			凹2_表示 = value;
    			凹3_表示 = value;
    			凹4_表示 = value;
    			凹5_表示 = value;
    			凹6_表示 = value;
    			線_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 根CD.不透明度;
    		}
    		set
    		{
    			根CD.不透明度 = value;
    			凹1CD.不透明度 = value;
    			凹2CD.不透明度 = value;
    			凹3CD.不透明度 = value;
    			凹4CD.不透明度 = value;
    			凹5CD.不透明度 = value;
    			凹6CD.不透明度 = value;
    			線CD.不透明度 = value;
    		}
    	}

    	public 角2_牛2(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 角2_牛2D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(Sta.肢左["角"][5]);
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_根 = partGroup["根"].ToPar();
    		X0Y0_凹1 = partGroup["凹1"].ToPar();
    		X0Y0_凹2 = partGroup["凹2"].ToPar();
    		X0Y0_凹3 = partGroup["凹3"].ToPar();
    		X0Y0_凹4 = partGroup["凹4"].ToPar();
    		X0Y0_凹5 = partGroup["凹5"].ToPar();
    		X0Y0_凹6 = partGroup["凹6"].ToPar();
    		X0Y0_線 = partGroup["線"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_根 = partGroup["根"].ToPar();
    		X0Y1_凹1 = partGroup["凹1"].ToPar();
    		X0Y1_凹2 = partGroup["凹2"].ToPar();
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
    		根_表示 = e.根_表示;
    		凹1_表示 = e.凹1_表示;
    		凹2_表示 = e.凹2_表示;
    		凹3_表示 = e.凹3_表示;
    		凹4_表示 = e.凹4_表示;
    		凹5_表示 = e.凹5_表示;
    		凹6_表示 = e.凹6_表示;
    		線_表示 = e.線_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_根CP = new ColorP(X0Y0_根, 根CD, DisUnit, abj: true);
    		X0Y0_凹1CP = new ColorP(X0Y0_凹1, 凹1CD, DisUnit, abj: true);
    		X0Y0_凹2CP = new ColorP(X0Y0_凹2, 凹2CD, DisUnit, abj: true);
    		X0Y0_凹3CP = new ColorP(X0Y0_凹3, 凹3CD, DisUnit, abj: true);
    		X0Y0_凹4CP = new ColorP(X0Y0_凹4, 凹4CD, DisUnit, abj: true);
    		X0Y0_凹5CP = new ColorP(X0Y0_凹5, 凹5CD, DisUnit, abj: true);
    		X0Y0_凹6CP = new ColorP(X0Y0_凹6, 凹6CD, DisUnit, abj: true);
    		X0Y0_線CP = new ColorP(X0Y0_線, 線CD, DisUnit, abj: true);
    		X0Y1_根CP = new ColorP(X0Y1_根, 根CD, DisUnit, abj: true);
    		X0Y1_凹1CP = new ColorP(X0Y1_凹1, 凹1CD, DisUnit, abj: true);
    		X0Y1_凹2CP = new ColorP(X0Y1_凹2, 凹2CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_根.AngleBase = num * -342.0;
    		X0Y1_根.AngleBase = num * -342.0;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexY == 0)
    		{
    			X0Y0_根CP.Update();
    			X0Y0_凹1CP.Update();
    			X0Y0_凹2CP.Update();
    			X0Y0_凹3CP.Update();
    			X0Y0_凹4CP.Update();
    			X0Y0_凹5CP.Update();
    			X0Y0_凹6CP.Update();
    			X0Y0_線CP.Update();
    		}
    		else
    		{
    			X0Y1_根CP.Update();
    			X0Y1_凹1CP.Update();
    			X0Y1_凹2CP.Update();
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		switch (配色指定)
    		{
    		case 配色指定.N0:
    			配色N0(体配色);
    			break;
    		case 配色指定.T0:
    			配色T0(体配色);
    			break;
    		case 配色指定.T1:
    			配色T1(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		根CD = new ColorD(ref ColorHelper.Black, ref 体配色.角0O);
    		凹1CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		凹2CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		凹3CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		凹4CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		凹5CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		凹6CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		線CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		根CD = new ColorD(ref ColorHelper.Black, ref 体配色.角0O);
    		凹1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		凹2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		凹3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		凹4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		凹5CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		凹6CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		線CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		根CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		凹1CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		凹2CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		凹3CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		凹4CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		凹5CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		凹6CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		線CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}
    }
}
