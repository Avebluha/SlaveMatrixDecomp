using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 角1_一 : 角1
    {
    	public ShapePart X0Y0_根;

    	public ShapePart X0Y0_線1;

    	public ShapePart X0Y0_線2;

    	public ShapePart X0Y0_線3;

    	public ShapePart X0Y0_線4;

    	public ShapePart X0Y0_線5;

    	public ShapePart X0Y0_線6;

    	public ShapePart X0Y0_線7;

    	public ShapePart X0Y0_線8;

    	public ShapePart X0Y0_線9;

    	public ShapePart X0Y0_線10;

    	public ShapePart X0Y1_根;

    	public ShapePart X0Y1_折線1;

    	public ShapePart X0Y1_折線2;

    	public ShapePart X0Y1_線1;

    	public ShapePart X0Y1_線2;

    	public ShapePart X0Y1_線3;

    	public ShapePart X0Y1_線4;

    	public ColorD 根CD;

    	public ColorD 線1CD;

    	public ColorD 線2CD;

    	public ColorD 線3CD;

    	public ColorD 線4CD;

    	public ColorD 線5CD;

    	public ColorD 線6CD;

    	public ColorD 線7CD;

    	public ColorD 線8CD;

    	public ColorD 線9CD;

    	public ColorD 線10CD;

    	public ColorD 折線1CD;

    	public ColorD 折線2CD;

    	public ColorP X0Y0_根CP;

    	public ColorP X0Y0_線1CP;

    	public ColorP X0Y0_線2CP;

    	public ColorP X0Y0_線3CP;

    	public ColorP X0Y0_線4CP;

    	public ColorP X0Y0_線5CP;

    	public ColorP X0Y0_線6CP;

    	public ColorP X0Y0_線7CP;

    	public ColorP X0Y0_線8CP;

    	public ColorP X0Y0_線9CP;

    	public ColorP X0Y0_線10CP;

    	public ColorP X0Y1_根CP;

    	public ColorP X0Y1_折線1CP;

    	public ColorP X0Y1_折線2CP;

    	public ColorP X0Y1_線1CP;

    	public ColorP X0Y1_線2CP;

    	public ColorP X0Y1_線3CP;

    	public ColorP X0Y1_線4CP;

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

    	public bool 線1_表示
    	{
    		get
    		{
    			return X0Y0_線1.Dra;
    		}
    		set
    		{
    			X0Y0_線1.Dra = value;
    			X0Y1_線1.Dra = value;
    			X0Y0_線1.Hit = value;
    			X0Y1_線1.Hit = value;
    		}
    	}

    	public bool 線2_表示
    	{
    		get
    		{
    			return X0Y0_線2.Dra;
    		}
    		set
    		{
    			X0Y0_線2.Dra = value;
    			X0Y1_線2.Dra = value;
    			X0Y0_線2.Hit = value;
    			X0Y1_線2.Hit = value;
    		}
    	}

    	public bool 線3_表示
    	{
    		get
    		{
    			return X0Y0_線3.Dra;
    		}
    		set
    		{
    			X0Y0_線3.Dra = value;
    			X0Y1_線3.Dra = value;
    			X0Y0_線3.Hit = value;
    			X0Y1_線3.Hit = value;
    		}
    	}

    	public bool 線4_表示
    	{
    		get
    		{
    			return X0Y0_線4.Dra;
    		}
    		set
    		{
    			X0Y0_線4.Dra = value;
    			X0Y1_線4.Dra = value;
    			X0Y0_線4.Hit = value;
    			X0Y1_線4.Hit = value;
    		}
    	}

    	public bool 線5_表示
    	{
    		get
    		{
    			return X0Y0_線5.Dra;
    		}
    		set
    		{
    			X0Y0_線5.Dra = value;
    			X0Y0_線5.Hit = value;
    		}
    	}

    	public bool 線6_表示
    	{
    		get
    		{
    			return X0Y0_線6.Dra;
    		}
    		set
    		{
    			X0Y0_線6.Dra = value;
    			X0Y0_線6.Hit = value;
    		}
    	}

    	public bool 線7_表示
    	{
    		get
    		{
    			return X0Y0_線7.Dra;
    		}
    		set
    		{
    			X0Y0_線7.Dra = value;
    			X0Y0_線7.Hit = value;
    		}
    	}

    	public bool 線8_表示
    	{
    		get
    		{
    			return X0Y0_線8.Dra;
    		}
    		set
    		{
    			X0Y0_線8.Dra = value;
    			X0Y0_線8.Hit = value;
    		}
    	}

    	public bool 線9_表示
    	{
    		get
    		{
    			return X0Y0_線9.Dra;
    		}
    		set
    		{
    			X0Y0_線9.Dra = value;
    			X0Y0_線9.Hit = value;
    		}
    	}

    	public bool 線10_表示
    	{
    		get
    		{
    			return X0Y0_線10.Dra;
    		}
    		set
    		{
    			X0Y0_線10.Dra = value;
    			X0Y0_線10.Hit = value;
    		}
    	}

    	public bool 折線1_表示
    	{
    		get
    		{
    			return X0Y1_折線1.Dra;
    		}
    		set
    		{
    			X0Y1_折線1.Dra = value;
    			X0Y1_折線1.Hit = value;
    		}
    	}

    	public bool 折線2_表示
    	{
    		get
    		{
    			return X0Y1_折線2.Dra;
    		}
    		set
    		{
    			X0Y1_折線2.Dra = value;
    			X0Y1_折線2.Hit = value;
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
    			線1_表示 = value;
    			線2_表示 = value;
    			線3_表示 = value;
    			線4_表示 = value;
    			線5_表示 = value;
    			線6_表示 = value;
    			線7_表示 = value;
    			線8_表示 = value;
    			線9_表示 = value;
    			線10_表示 = value;
    			折線1_表示 = value;
    			折線2_表示 = value;
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
    			線1CD.不透明度 = value;
    			線2CD.不透明度 = value;
    			線3CD.不透明度 = value;
    			線4CD.不透明度 = value;
    			線5CD.不透明度 = value;
    			線6CD.不透明度 = value;
    			線7CD.不透明度 = value;
    			線8CD.不透明度 = value;
    			線9CD.不透明度 = value;
    			線10CD.不透明度 = value;
    			折線1CD.不透明度 = value;
    			折線2CD.不透明度 = value;
    		}
    	}

    	public 角1_一(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 角1_一D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(GlobalState.肢中["角"][0]);
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_根 = partGroup["根"].ToPar();
    		X0Y0_線1 = partGroup["線1"].ToPar();
    		X0Y0_線2 = partGroup["線2"].ToPar();
    		X0Y0_線3 = partGroup["線3"].ToPar();
    		X0Y0_線4 = partGroup["線4"].ToPar();
    		X0Y0_線5 = partGroup["線5"].ToPar();
    		X0Y0_線6 = partGroup["線6"].ToPar();
    		X0Y0_線7 = partGroup["線7"].ToPar();
    		X0Y0_線8 = partGroup["線8"].ToPar();
    		X0Y0_線9 = partGroup["線9"].ToPar();
    		X0Y0_線10 = partGroup["線10"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_根 = partGroup["根"].ToPar();
    		X0Y1_折線1 = partGroup["折線1"].ToPar();
    		X0Y1_折線2 = partGroup["折線2"].ToPar();
    		X0Y1_線1 = partGroup["線1"].ToPar();
    		X0Y1_線2 = partGroup["線2"].ToPar();
    		X0Y1_線3 = partGroup["線3"].ToPar();
    		X0Y1_線4 = partGroup["線4"].ToPar();
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
    		線1_表示 = e.線1_表示;
    		線2_表示 = e.線2_表示;
    		線3_表示 = e.線3_表示;
    		線4_表示 = e.線4_表示;
    		線5_表示 = e.線5_表示;
    		線6_表示 = e.線6_表示;
    		線7_表示 = e.線7_表示;
    		線8_表示 = e.線8_表示;
    		線9_表示 = e.線9_表示;
    		線10_表示 = e.線10_表示;
    		折線1_表示 = e.折線1_表示;
    		折線2_表示 = e.折線2_表示;
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
    		X0Y0_線1CP = new ColorP(X0Y0_線1, 線1CD, DisUnit, abj: false);
    		X0Y0_線2CP = new ColorP(X0Y0_線2, 線2CD, DisUnit, abj: false);
    		X0Y0_線3CP = new ColorP(X0Y0_線3, 線3CD, DisUnit, abj: false);
    		X0Y0_線4CP = new ColorP(X0Y0_線4, 線4CD, DisUnit, abj: false);
    		X0Y0_線5CP = new ColorP(X0Y0_線5, 線5CD, DisUnit, abj: false);
    		X0Y0_線6CP = new ColorP(X0Y0_線6, 線6CD, DisUnit, abj: false);
    		X0Y0_線7CP = new ColorP(X0Y0_線7, 線7CD, DisUnit, abj: false);
    		X0Y0_線8CP = new ColorP(X0Y0_線8, 線8CD, DisUnit, abj: false);
    		X0Y0_線9CP = new ColorP(X0Y0_線9, 線9CD, DisUnit, abj: false);
    		X0Y0_線10CP = new ColorP(X0Y0_線10, 線10CD, DisUnit, abj: false);
    		X0Y1_根CP = new ColorP(X0Y1_根, 根CD, DisUnit, abj: true);
    		X0Y1_折線1CP = new ColorP(X0Y1_折線1, 折線1CD, DisUnit, abj: true);
    		X0Y1_折線2CP = new ColorP(X0Y1_折線2, 折線2CD, DisUnit, abj: true);
    		X0Y1_線1CP = new ColorP(X0Y1_線1, 線1CD, DisUnit, abj: false);
    		X0Y1_線2CP = new ColorP(X0Y1_線2, 線2CD, DisUnit, abj: false);
    		X0Y1_線3CP = new ColorP(X0Y1_線3, 線3CD, DisUnit, abj: false);
    		X0Y1_線4CP = new ColorP(X0Y1_線4, 線4CD, DisUnit, abj: false);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexY == 0)
    		{
    			X0Y0_根CP.Update();
    			X0Y0_線1CP.Update();
    			X0Y0_線2CP.Update();
    			X0Y0_線3CP.Update();
    			X0Y0_線4CP.Update();
    			X0Y0_線5CP.Update();
    			X0Y0_線6CP.Update();
    			X0Y0_線7CP.Update();
    			X0Y0_線8CP.Update();
    			X0Y0_線9CP.Update();
    			X0Y0_線10CP.Update();
    		}
    		else
    		{
    			X0Y1_根CP.Update();
    			X0Y1_折線1CP.Update();
    			X0Y1_折線2CP.Update();
    			X0Y1_線1CP.Update();
    			X0Y1_線2CP.Update();
    			X0Y1_線3CP.Update();
    			X0Y1_線4CP.Update();
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
    		線1CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線2CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線3CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線4CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線5CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線6CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線7CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線8CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線9CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線10CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		折線1CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		折線2CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		根CD = new ColorD(ref ColorHelper.Black, ref 体配色.角0O);
    		線1CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
    		線2CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
    		線3CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
    		線4CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
    		線5CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
    		線6CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
    		線7CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
    		線8CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
    		線9CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
    		線10CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
    		折線1CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		折線2CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		根CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		線1CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線2CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線3CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線4CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線5CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線6CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線7CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線8CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線9CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		線10CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
    		折線1CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		折線2CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}
    }
}
