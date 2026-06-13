using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 角2_山2 : 角2
    {
    	public ShapePart X0Y0_根;

    	public ShapePart X0Y0_凸1;

    	public ShapePart X0Y0_凸2;

    	public ShapePart X0Y0_凸3;

    	public ShapePart X0Y0_凸4;

    	public ShapePart X0Y0_凸5;

    	public ShapePart X0Y0_凸6;

    	public ShapePart X0Y0_凸7;

    	public ShapePart X0Y0_凸8;

    	public ShapePart X0Y0_凸9;

    	public ShapePart X0Y1_根;

    	public ShapePart X0Y1_折線;

    	public ShapePart X0Y1_凸1;

    	public ShapePart X0Y1_凸2;

    	public ShapePart X0Y1_凸3;

    	public ShapePart X0Y1_凸4;

    	public ShapePart X0Y1_凸5;

    	public ColorD 根CD;

    	public ColorD 凸1CD;

    	public ColorD 凸2CD;

    	public ColorD 凸3CD;

    	public ColorD 凸4CD;

    	public ColorD 凸5CD;

    	public ColorD 凸6CD;

    	public ColorD 凸7CD;

    	public ColorD 凸8CD;

    	public ColorD 凸9CD;

    	public ColorD 折線CD;

    	public ColorP X0Y0_根CP;

    	public ColorP X0Y0_凸1CP;

    	public ColorP X0Y0_凸2CP;

    	public ColorP X0Y0_凸3CP;

    	public ColorP X0Y0_凸4CP;

    	public ColorP X0Y0_凸5CP;

    	public ColorP X0Y0_凸6CP;

    	public ColorP X0Y0_凸7CP;

    	public ColorP X0Y0_凸8CP;

    	public ColorP X0Y0_凸9CP;

    	public ColorP X0Y1_根CP;

    	public ColorP X0Y1_折線CP;

    	public ColorP X0Y1_凸1CP;

    	public ColorP X0Y1_凸2CP;

    	public ColorP X0Y1_凸3CP;

    	public ColorP X0Y1_凸4CP;

    	public ColorP X0Y1_凸5CP;

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

    	public bool 凸1_表示
    	{
    		get
    		{
    			return X0Y0_凸1.Dra;
    		}
    		set
    		{
    			X0Y0_凸1.Dra = value;
    			X0Y1_凸1.Dra = value;
    			X0Y0_凸1.Hit = value;
    			X0Y1_凸1.Hit = value;
    		}
    	}

    	public bool 凸2_表示
    	{
    		get
    		{
    			return X0Y0_凸2.Dra;
    		}
    		set
    		{
    			X0Y0_凸2.Dra = value;
    			X0Y1_凸2.Dra = value;
    			X0Y0_凸2.Hit = value;
    			X0Y1_凸2.Hit = value;
    		}
    	}

    	public bool 凸3_表示
    	{
    		get
    		{
    			return X0Y0_凸3.Dra;
    		}
    		set
    		{
    			X0Y0_凸3.Dra = value;
    			X0Y1_凸3.Dra = value;
    			X0Y0_凸3.Hit = value;
    			X0Y1_凸3.Hit = value;
    		}
    	}

    	public bool 凸4_表示
    	{
    		get
    		{
    			return X0Y0_凸4.Dra;
    		}
    		set
    		{
    			X0Y0_凸4.Dra = value;
    			X0Y1_凸4.Dra = value;
    			X0Y0_凸4.Hit = value;
    			X0Y1_凸4.Hit = value;
    		}
    	}

    	public bool 凸5_表示
    	{
    		get
    		{
    			return X0Y0_凸5.Dra;
    		}
    		set
    		{
    			X0Y0_凸5.Dra = value;
    			X0Y1_凸5.Dra = value;
    			X0Y0_凸5.Hit = value;
    			X0Y1_凸5.Hit = value;
    		}
    	}

    	public bool 凸6_表示
    	{
    		get
    		{
    			return X0Y0_凸6.Dra;
    		}
    		set
    		{
    			X0Y0_凸6.Dra = value;
    			X0Y0_凸6.Hit = value;
    		}
    	}

    	public bool 凸7_表示
    	{
    		get
    		{
    			return X0Y0_凸7.Dra;
    		}
    		set
    		{
    			X0Y0_凸7.Dra = value;
    			X0Y0_凸7.Hit = value;
    		}
    	}

    	public bool 凸8_表示
    	{
    		get
    		{
    			return X0Y0_凸8.Dra;
    		}
    		set
    		{
    			X0Y0_凸8.Dra = value;
    			X0Y0_凸8.Hit = value;
    		}
    	}

    	public bool 凸9_表示
    	{
    		get
    		{
    			return X0Y0_凸9.Dra;
    		}
    		set
    		{
    			X0Y0_凸9.Dra = value;
    			X0Y0_凸9.Hit = value;
    		}
    	}

    	public bool 折線_表示
    	{
    		get
    		{
    			return X0Y1_折線.Dra;
    		}
    		set
    		{
    			X0Y1_折線.Dra = value;
    			X0Y1_折線.Hit = value;
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
    			凸1_表示 = value;
    			凸2_表示 = value;
    			凸3_表示 = value;
    			凸4_表示 = value;
    			凸5_表示 = value;
    			凸6_表示 = value;
    			凸7_表示 = value;
    			凸8_表示 = value;
    			凸9_表示 = value;
    			折線_表示 = value;
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
    			凸1CD.不透明度 = value;
    			凸2CD.不透明度 = value;
    			凸3CD.不透明度 = value;
    			凸4CD.不透明度 = value;
    			凸5CD.不透明度 = value;
    			凸6CD.不透明度 = value;
    			凸7CD.不透明度 = value;
    			凸8CD.不透明度 = value;
    			凸9CD.不透明度 = value;
    			折線CD.不透明度 = value;
    		}
    	}

    	public 角2_山2(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 角2_山2D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(Sta.肢左["角"][1]);
    		Body = new Difs();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_根 = partGroup["根"].ToPar();
    		X0Y0_凸1 = partGroup["凸1"].ToPar();
    		X0Y0_凸2 = partGroup["凸2"].ToPar();
    		X0Y0_凸3 = partGroup["凸3"].ToPar();
    		X0Y0_凸4 = partGroup["凸4"].ToPar();
    		X0Y0_凸5 = partGroup["凸5"].ToPar();
    		X0Y0_凸6 = partGroup["凸6"].ToPar();
    		X0Y0_凸7 = partGroup["凸7"].ToPar();
    		X0Y0_凸8 = partGroup["凸8"].ToPar();
    		X0Y0_凸9 = partGroup["凸9"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_根 = partGroup["根"].ToPar();
    		X0Y1_折線 = partGroup["折線"].ToPar();
    		X0Y1_凸1 = partGroup["凸1"].ToPar();
    		X0Y1_凸2 = partGroup["凸2"].ToPar();
    		X0Y1_凸3 = partGroup["凸3"].ToPar();
    		X0Y1_凸4 = partGroup["凸4"].ToPar();
    		X0Y1_凸5 = partGroup["凸5"].ToPar();
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
    		凸1_表示 = e.凸1_表示;
    		凸2_表示 = e.凸2_表示;
    		凸3_表示 = e.凸3_表示;
    		凸4_表示 = e.凸4_表示;
    		凸5_表示 = e.凸5_表示;
    		凸6_表示 = e.凸6_表示;
    		凸7_表示 = e.凸7_表示;
    		凸8_表示 = e.凸8_表示;
    		凸9_表示 = e.凸9_表示;
    		折線_表示 = e.折線_表示;
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
    		X0Y0_凸1CP = new ColorP(X0Y0_凸1, 凸1CD, DisUnit, abj: true);
    		X0Y0_凸2CP = new ColorP(X0Y0_凸2, 凸2CD, DisUnit, abj: true);
    		X0Y0_凸3CP = new ColorP(X0Y0_凸3, 凸3CD, DisUnit, abj: true);
    		X0Y0_凸4CP = new ColorP(X0Y0_凸4, 凸4CD, DisUnit, abj: true);
    		X0Y0_凸5CP = new ColorP(X0Y0_凸5, 凸5CD, DisUnit, abj: true);
    		X0Y0_凸6CP = new ColorP(X0Y0_凸6, 凸6CD, DisUnit, abj: true);
    		X0Y0_凸7CP = new ColorP(X0Y0_凸7, 凸7CD, DisUnit, abj: true);
    		X0Y0_凸8CP = new ColorP(X0Y0_凸8, 凸8CD, DisUnit, abj: true);
    		X0Y0_凸9CP = new ColorP(X0Y0_凸9, 凸9CD, DisUnit, abj: true);
    		X0Y1_根CP = new ColorP(X0Y1_根, 根CD, DisUnit, abj: true);
    		X0Y1_折線CP = new ColorP(X0Y1_折線, 折線CD, DisUnit, abj: true);
    		X0Y1_凸1CP = new ColorP(X0Y1_凸1, 凸1CD, DisUnit, abj: true);
    		X0Y1_凸2CP = new ColorP(X0Y1_凸2, 凸2CD, DisUnit, abj: true);
    		X0Y1_凸3CP = new ColorP(X0Y1_凸3, 凸3CD, DisUnit, abj: true);
    		X0Y1_凸4CP = new ColorP(X0Y1_凸4, 凸4CD, DisUnit, abj: true);
    		X0Y1_凸5CP = new ColorP(X0Y1_凸5, 凸5CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_根.AngleBase = num * -49.0000000000001;
    		X0Y1_根.AngleBase = num * -49.0000000000001;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexY == 0)
    		{
    			X0Y0_根CP.Update();
    			X0Y0_凸1CP.Update();
    			X0Y0_凸2CP.Update();
    			X0Y0_凸3CP.Update();
    			X0Y0_凸4CP.Update();
    			X0Y0_凸5CP.Update();
    			X0Y0_凸6CP.Update();
    			X0Y0_凸7CP.Update();
    			X0Y0_凸8CP.Update();
    			X0Y0_凸9CP.Update();
    		}
    		else
    		{
    			X0Y1_根CP.Update();
    			X0Y1_折線CP.Update();
    			X0Y1_凸1CP.Update();
    			X0Y1_凸2CP.Update();
    			X0Y1_凸3CP.Update();
    			X0Y1_凸4CP.Update();
    			X0Y1_凸5CP.Update();
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
    		根CD = new ColorD(ref Col.Black, ref 体配色.角0O);
    		凸1CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸2CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸3CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸4CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸5CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸6CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸7CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸8CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸9CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		折線CD = new ColorD(ref Col.Black, ref Color2.Empty);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		根CD = new ColorD(ref Col.Black, ref 体配色.角0O);
    		凸1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		凸2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		凸3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		凸4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		凸5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		凸6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		凸7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		凸8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		凸9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		折線CD = new ColorD(ref Col.Black, ref Color2.Empty);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		根CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		凸1CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸2CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸3CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸4CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸5CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸6CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸7CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸8CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		凸9CD = new ColorD(ref Col.Black, ref 体配色.角1O);
    		折線CD = new ColorD(ref Col.Black, ref Color2.Empty);
    	}
    }
}
