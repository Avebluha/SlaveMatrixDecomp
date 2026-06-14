using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 角2_巻 : 角2
    {
    	public ShapePart X0Y0_根_根;

    	public ShapePart X0Y0_根_凸6;

    	public ShapePart X0Y0_根_凸5;

    	public ShapePart X0Y0_根_凸4;

    	public ShapePart X0Y0_根_凸3;

    	public ShapePart X0Y0_根_凸2;

    	public ShapePart X0Y0_根_凸1;

    	public ShapePart X0Y0_先_先;

    	public ShapePart X0Y0_先_凸1;

    	public ShapePart X0Y0_先_凸2;

    	public ShapePart X0Y0_先_凸3;

    	public ShapePart X0Y0_先_凸4;

    	public ShapePart X0Y0_先_凸5;

    	public ShapePart X0Y1_根_根;

    	public ShapePart X0Y1_根_折線1;

    	public ShapePart X0Y1_根_折線2;

    	public ShapePart X0Y1_根_凸6;

    	public ShapePart X0Y1_根_凸4;

    	public ShapePart X0Y1_根_凸3;

    	public ShapePart X0Y1_根_凸2;

    	public ShapePart X0Y1_根_凸1;

    	public ColorD 根_根CD;

    	public ColorD 根_凸6CD;

    	public ColorD 根_凸5CD;

    	public ColorD 根_凸4CD;

    	public ColorD 根_凸3CD;

    	public ColorD 根_凸2CD;

    	public ColorD 根_凸1CD;

    	public ColorD 先_先CD;

    	public ColorD 先_凸1CD;

    	public ColorD 先_凸2CD;

    	public ColorD 先_凸3CD;

    	public ColorD 先_凸4CD;

    	public ColorD 先_凸5CD;

    	public ColorD 根_折線1CD;

    	public ColorD 根_折線2CD;

    	public ColorP X0Y0_根_根CP;

    	public ColorP X0Y0_根_凸6CP;

    	public ColorP X0Y0_根_凸5CP;

    	public ColorP X0Y0_根_凸4CP;

    	public ColorP X0Y0_根_凸3CP;

    	public ColorP X0Y0_根_凸2CP;

    	public ColorP X0Y0_根_凸1CP;

    	public ColorP X0Y0_先_先CP;

    	public ColorP X0Y0_先_凸1CP;

    	public ColorP X0Y0_先_凸2CP;

    	public ColorP X0Y0_先_凸3CP;

    	public ColorP X0Y0_先_凸4CP;

    	public ColorP X0Y0_先_凸5CP;

    	public ColorP X0Y1_根_根CP;

    	public ColorP X0Y1_根_折線1CP;

    	public ColorP X0Y1_根_折線2CP;

    	public ColorP X0Y1_根_凸6CP;

    	public ColorP X0Y1_根_凸4CP;

    	public ColorP X0Y1_根_凸3CP;

    	public ColorP X0Y1_根_凸2CP;

    	public ColorP X0Y1_根_凸1CP;

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

    	public bool 根_根_表示
    	{
    		get
    		{
    			return X0Y0_根_根.Dra;
    		}
    		set
    		{
    			X0Y0_根_根.Dra = value;
    			X0Y1_根_根.Dra = value;
    			X0Y0_根_根.Hit = value;
    			X0Y1_根_根.Hit = value;
    		}
    	}

    	public bool 根_凸6_表示
    	{
    		get
    		{
    			return X0Y0_根_凸6.Dra;
    		}
    		set
    		{
    			X0Y0_根_凸6.Dra = value;
    			X0Y1_根_凸6.Dra = value;
    			X0Y0_根_凸6.Hit = value;
    			X0Y1_根_凸6.Hit = value;
    		}
    	}

    	public bool 根_凸5_表示
    	{
    		get
    		{
    			return X0Y0_根_凸5.Dra;
    		}
    		set
    		{
    			X0Y0_根_凸5.Dra = value;
    			X0Y0_根_凸5.Hit = value;
    		}
    	}

    	public bool 根_凸4_表示
    	{
    		get
    		{
    			return X0Y0_根_凸4.Dra;
    		}
    		set
    		{
    			X0Y0_根_凸4.Dra = value;
    			X0Y1_根_凸4.Dra = value;
    			X0Y0_根_凸4.Hit = value;
    			X0Y1_根_凸4.Hit = value;
    		}
    	}

    	public bool 根_凸3_表示
    	{
    		get
    		{
    			return X0Y0_根_凸3.Dra;
    		}
    		set
    		{
    			X0Y0_根_凸3.Dra = value;
    			X0Y1_根_凸3.Dra = value;
    			X0Y0_根_凸3.Hit = value;
    			X0Y1_根_凸3.Hit = value;
    		}
    	}

    	public bool 根_凸2_表示
    	{
    		get
    		{
    			return X0Y0_根_凸2.Dra;
    		}
    		set
    		{
    			X0Y0_根_凸2.Dra = value;
    			X0Y1_根_凸2.Dra = value;
    			X0Y0_根_凸2.Hit = value;
    			X0Y1_根_凸2.Hit = value;
    		}
    	}

    	public bool 根_凸1_表示
    	{
    		get
    		{
    			return X0Y0_根_凸1.Dra;
    		}
    		set
    		{
    			X0Y0_根_凸1.Dra = value;
    			X0Y1_根_凸1.Dra = value;
    			X0Y0_根_凸1.Hit = value;
    			X0Y1_根_凸1.Hit = value;
    		}
    	}

    	public bool 先_先_表示
    	{
    		get
    		{
    			return X0Y0_先_先.Dra;
    		}
    		set
    		{
    			X0Y0_先_先.Dra = value;
    			X0Y0_先_先.Hit = value;
    		}
    	}

    	public bool 先_凸1_表示
    	{
    		get
    		{
    			return X0Y0_先_凸1.Dra;
    		}
    		set
    		{
    			X0Y0_先_凸1.Dra = value;
    			X0Y0_先_凸1.Hit = value;
    		}
    	}

    	public bool 先_凸2_表示
    	{
    		get
    		{
    			return X0Y0_先_凸2.Dra;
    		}
    		set
    		{
    			X0Y0_先_凸2.Dra = value;
    			X0Y0_先_凸2.Hit = value;
    		}
    	}

    	public bool 先_凸3_表示
    	{
    		get
    		{
    			return X0Y0_先_凸3.Dra;
    		}
    		set
    		{
    			X0Y0_先_凸3.Dra = value;
    			X0Y0_先_凸3.Hit = value;
    		}
    	}

    	public bool 先_凸4_表示
    	{
    		get
    		{
    			return X0Y0_先_凸4.Dra;
    		}
    		set
    		{
    			X0Y0_先_凸4.Dra = value;
    			X0Y0_先_凸4.Hit = value;
    		}
    	}

    	public bool 先_凸5_表示
    	{
    		get
    		{
    			return X0Y0_先_凸5.Dra;
    		}
    		set
    		{
    			X0Y0_先_凸5.Dra = value;
    			X0Y0_先_凸5.Hit = value;
    		}
    	}

    	public bool 根_折線1_表示
    	{
    		get
    		{
    			return X0Y1_根_折線1.Dra;
    		}
    		set
    		{
    			X0Y1_根_折線1.Dra = value;
    			X0Y1_根_折線1.Hit = value;
    		}
    	}

    	public bool 根_折線2_表示
    	{
    		get
    		{
    			return X0Y1_根_折線2.Dra;
    		}
    		set
    		{
    			X0Y1_根_折線2.Dra = value;
    			X0Y1_根_折線2.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 根_根_表示;
    		}
    		set
    		{
    			根_根_表示 = value;
    			根_凸6_表示 = value;
    			根_凸5_表示 = value;
    			根_凸4_表示 = value;
    			根_凸3_表示 = value;
    			根_凸2_表示 = value;
    			根_凸1_表示 = value;
    			先_先_表示 = value;
    			先_凸1_表示 = value;
    			先_凸2_表示 = value;
    			先_凸3_表示 = value;
    			先_凸4_表示 = value;
    			先_凸5_表示 = value;
    			根_折線1_表示 = value;
    			根_折線2_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 根_根CD.不透明度;
    		}
    		set
    		{
    			根_根CD.不透明度 = value;
    			根_凸6CD.不透明度 = value;
    			根_凸5CD.不透明度 = value;
    			根_凸4CD.不透明度 = value;
    			根_凸3CD.不透明度 = value;
    			根_凸2CD.不透明度 = value;
    			根_凸1CD.不透明度 = value;
    			先_先CD.不透明度 = value;
    			先_凸1CD.不透明度 = value;
    			先_凸2CD.不透明度 = value;
    			先_凸3CD.不透明度 = value;
    			先_凸4CD.不透明度 = value;
    			先_凸5CD.不透明度 = value;
    			根_折線1CD.不透明度 = value;
    			根_折線2CD.不透明度 = value;
    		}
    	}

    	public 角2_巻(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 角2_巻D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(GlobalState.肢左["角"][3]);
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		PartGroup pars2 = partGroup["根"].ToPars();
    		X0Y0_根_根 = pars2["根"].ToPar();
    		X0Y0_根_凸6 = pars2["凸6"].ToPar();
    		X0Y0_根_凸5 = pars2["凸5"].ToPar();
    		X0Y0_根_凸4 = pars2["凸4"].ToPar();
    		X0Y0_根_凸3 = pars2["凸3"].ToPar();
    		X0Y0_根_凸2 = pars2["凸2"].ToPar();
    		X0Y0_根_凸1 = pars2["凸1"].ToPar();
    		pars2 = partGroup["先"].ToPars();
    		X0Y0_先_先 = pars2["先"].ToPar();
    		X0Y0_先_凸1 = pars2["凸1"].ToPar();
    		X0Y0_先_凸2 = pars2["凸2"].ToPar();
    		X0Y0_先_凸3 = pars2["凸3"].ToPar();
    		X0Y0_先_凸4 = pars2["凸4"].ToPar();
    		X0Y0_先_凸5 = pars2["凸5"].ToPar();
    		pars2 = Body[0][1]["根"].ToPars();
    		X0Y1_根_根 = pars2["根"].ToPar();
    		X0Y1_根_折線1 = pars2["折線1"].ToPar();
    		X0Y1_根_折線2 = pars2["折線2"].ToPar();
    		X0Y1_根_凸6 = pars2["凸6"].ToPar();
    		X0Y1_根_凸4 = pars2["凸4"].ToPar();
    		X0Y1_根_凸3 = pars2["凸3"].ToPar();
    		X0Y1_根_凸2 = pars2["凸2"].ToPar();
    		X0Y1_根_凸1 = pars2["凸1"].ToPar();
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
    		根_根_表示 = e.根_根_表示;
    		根_凸6_表示 = e.根_凸6_表示;
    		根_凸5_表示 = e.根_凸5_表示;
    		根_凸4_表示 = e.根_凸4_表示;
    		根_凸3_表示 = e.根_凸3_表示;
    		根_凸2_表示 = e.根_凸2_表示;
    		根_凸1_表示 = e.根_凸1_表示;
    		先_先_表示 = e.先_先_表示;
    		先_凸1_表示 = e.先_凸1_表示;
    		先_凸2_表示 = e.先_凸2_表示;
    		先_凸3_表示 = e.先_凸3_表示;
    		先_凸4_表示 = e.先_凸4_表示;
    		先_凸5_表示 = e.先_凸5_表示;
    		根_折線1_表示 = e.根_折線1_表示;
    		根_折線2_表示 = e.根_折線2_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_根_根CP = new ColorP(X0Y0_根_根, 根_根CD, DisUnit, abj: true);
    		X0Y0_根_凸6CP = new ColorP(X0Y0_根_凸6, 根_凸6CD, DisUnit, abj: true);
    		X0Y0_根_凸5CP = new ColorP(X0Y0_根_凸5, 根_凸5CD, DisUnit, abj: true);
    		X0Y0_根_凸4CP = new ColorP(X0Y0_根_凸4, 根_凸4CD, DisUnit, abj: true);
    		X0Y0_根_凸3CP = new ColorP(X0Y0_根_凸3, 根_凸3CD, DisUnit, abj: true);
    		X0Y0_根_凸2CP = new ColorP(X0Y0_根_凸2, 根_凸2CD, DisUnit, abj: true);
    		X0Y0_根_凸1CP = new ColorP(X0Y0_根_凸1, 根_凸1CD, DisUnit, abj: true);
    		X0Y0_先_先CP = new ColorP(X0Y0_先_先, 先_先CD, DisUnit, abj: true);
    		X0Y0_先_凸1CP = new ColorP(X0Y0_先_凸1, 先_凸1CD, DisUnit, abj: true);
    		X0Y0_先_凸2CP = new ColorP(X0Y0_先_凸2, 先_凸2CD, DisUnit, abj: true);
    		X0Y0_先_凸3CP = new ColorP(X0Y0_先_凸3, 先_凸3CD, DisUnit, abj: true);
    		X0Y0_先_凸4CP = new ColorP(X0Y0_先_凸4, 先_凸4CD, DisUnit, abj: true);
    		X0Y0_先_凸5CP = new ColorP(X0Y0_先_凸5, 先_凸5CD, DisUnit, abj: true);
    		X0Y1_根_根CP = new ColorP(X0Y1_根_根, 根_根CD, DisUnit, abj: true);
    		X0Y1_根_折線1CP = new ColorP(X0Y1_根_折線1, 根_折線1CD, DisUnit, abj: true);
    		X0Y1_根_折線2CP = new ColorP(X0Y1_根_折線2, 根_折線2CD, DisUnit, abj: true);
    		X0Y1_根_凸6CP = new ColorP(X0Y1_根_凸6, 根_凸6CD, DisUnit, abj: true);
    		X0Y1_根_凸4CP = new ColorP(X0Y1_根_凸4, 根_凸4CD, DisUnit, abj: true);
    		X0Y1_根_凸3CP = new ColorP(X0Y1_根_凸3, 根_凸3CD, DisUnit, abj: true);
    		X0Y1_根_凸2CP = new ColorP(X0Y1_根_凸2, 根_凸2CD, DisUnit, abj: true);
    		X0Y1_根_凸1CP = new ColorP(X0Y1_根_凸1, 根_凸1CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 根描画(RenderArea Are)
    	{
    		if (Body.GetIndexY() == 0)
    		{
    			Are.Draw(X0Y0_根_根);
    			Are.Draw(X0Y0_根_凸6);
    			Are.Draw(X0Y0_根_凸5);
    			Are.Draw(X0Y0_根_凸4);
    			Are.Draw(X0Y0_根_凸3);
    			Are.Draw(X0Y0_根_凸2);
    			Are.Draw(X0Y0_根_凸1);
    		}
    		else
    		{
    			Are.Draw(X0Y1_根_根);
    			Are.Draw(X0Y1_根_折線1);
    			Are.Draw(X0Y1_根_折線2);
    			Are.Draw(X0Y1_根_凸6);
    			Are.Draw(X0Y1_根_凸4);
    			Are.Draw(X0Y1_根_凸3);
    			Are.Draw(X0Y1_根_凸2);
    			Are.Draw(X0Y1_根_凸1);
    		}
    	}

    	public override void 先描画(RenderArea Are)
    	{
    		if (Body.GetIndexY() == 0)
    		{
    			Are.Draw(X0Y0_先_先);
    			Are.Draw(X0Y0_先_凸1);
    			Are.Draw(X0Y0_先_凸2);
    			Are.Draw(X0Y0_先_凸3);
    			Are.Draw(X0Y0_先_凸4);
    			Are.Draw(X0Y0_先_凸5);
    		}
    	}

    	public override void 色更新()
    	{
    		if (Body.GetIndexY() == 0)
    		{
    			X0Y0_根_根CP.Update();
    			X0Y0_根_凸6CP.Update();
    			X0Y0_根_凸5CP.Update();
    			X0Y0_根_凸4CP.Update();
    			X0Y0_根_凸3CP.Update();
    			X0Y0_根_凸2CP.Update();
    			X0Y0_根_凸1CP.Update();
    			X0Y0_先_先CP.Update();
    			X0Y0_先_凸1CP.Update();
    			X0Y0_先_凸2CP.Update();
    			X0Y0_先_凸3CP.Update();
    			X0Y0_先_凸4CP.Update();
    			X0Y0_先_凸5CP.Update();
    		}
    		else
    		{
    			X0Y1_根_根CP.Update();
    			X0Y1_根_折線1CP.Update();
    			X0Y1_根_折線2CP.Update();
    			X0Y1_根_凸6CP.Update();
    			X0Y1_根_凸4CP.Update();
    			X0Y1_根_凸3CP.Update();
    			X0Y1_根_凸2CP.Update();
    			X0Y1_根_凸1CP.Update();
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
    		根_根CD = new ColorD(ref ColorHelper.Black, ref 体配色.角0O);
    		根_凸6CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		根_凸5CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		根_凸4CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		根_凸3CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		根_凸2CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		根_凸1CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		先_先CD = new ColorD(ref ColorHelper.Black, ref 体配色.角0O);
    		先_凸1CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		先_凸2CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		先_凸3CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		先_凸4CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		先_凸5CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		根_折線1CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		根_折線2CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		根_根CD = new ColorD(ref ColorHelper.Black, ref 体配色.角0O);
    		根_凸6CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		根_凸5CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		根_凸4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		根_凸3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		根_凸2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		根_凸1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		先_先CD = new ColorD(ref ColorHelper.Black, ref 体配色.角0O);
    		先_凸1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		先_凸2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		先_凸3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		先_凸4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		先_凸5CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		根_折線1CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		根_折線2CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		根_根CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		根_凸6CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		根_凸5CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		根_凸4CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		根_凸3CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		根_凸2CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		根_凸1CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		先_先CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		先_凸1CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		先_凸2CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		先_凸3CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		先_凸4CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		先_凸5CD = new ColorD(ref ColorHelper.Black, ref 体配色.角1O);
    		根_折線1CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		根_折線2CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}
    }
}
