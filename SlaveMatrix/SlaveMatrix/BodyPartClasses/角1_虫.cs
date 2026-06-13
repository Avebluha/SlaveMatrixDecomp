using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 角1_虫 : 角1
    {
    	public ShapePart X0Y0_根;

    	public ShapePart X0Y0_器官左_器官1;

    	public ShapePart X0Y0_器官左_器官2;

    	public ShapePart X0Y0_器官右_器官1;

    	public ShapePart X0Y0_器官右_器官2;

    	public ShapePart X0Y0_線;

    	public ShapePart X0Y1_根;

    	public ShapePart X0Y1_器官左_器官1;

    	public ShapePart X0Y1_器官左_器官2;

    	public ShapePart X0Y1_器官右_器官1;

    	public ShapePart X0Y1_器官右_器官2;

    	public ShapePart X0Y1_線;

    	public ShapePart X0Y1_折線1;

    	public ShapePart X0Y1_折線2;

    	public ColorD 根CD;

    	public ColorD 器官左_器官1CD;

    	public ColorD 器官左_器官2CD;

    	public ColorD 器官右_器官1CD;

    	public ColorD 器官右_器官2CD;

    	public ColorD 線CD;

    	public ColorD 折線1CD;

    	public ColorD 折線2CD;

    	public ColorP X0Y0_根CP;

    	public ColorP X0Y0_器官左_器官1CP;

    	public ColorP X0Y0_器官左_器官2CP;

    	public ColorP X0Y0_器官右_器官1CP;

    	public ColorP X0Y0_器官右_器官2CP;

    	public ColorP X0Y0_線CP;

    	public ColorP X0Y1_根CP;

    	public ColorP X0Y1_器官左_器官1CP;

    	public ColorP X0Y1_器官左_器官2CP;

    	public ColorP X0Y1_器官右_器官1CP;

    	public ColorP X0Y1_器官右_器官2CP;

    	public ColorP X0Y1_線CP;

    	public ColorP X0Y1_折線1CP;

    	public ColorP X0Y1_折線2CP;

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

    	public bool 器官左_器官1_表示
    	{
    		get
    		{
    			return X0Y0_器官左_器官1.Dra;
    		}
    		set
    		{
    			X0Y0_器官左_器官1.Dra = value;
    			X0Y1_器官左_器官1.Dra = value;
    			X0Y0_器官左_器官1.Hit = value;
    			X0Y1_器官左_器官1.Hit = value;
    		}
    	}

    	public bool 器官左_器官2_表示
    	{
    		get
    		{
    			return X0Y0_器官左_器官2.Dra;
    		}
    		set
    		{
    			X0Y0_器官左_器官2.Dra = value;
    			X0Y1_器官左_器官2.Dra = value;
    			X0Y0_器官左_器官2.Hit = value;
    			X0Y1_器官左_器官2.Hit = value;
    		}
    	}

    	public bool 器官右_器官1_表示
    	{
    		get
    		{
    			return X0Y0_器官右_器官1.Dra;
    		}
    		set
    		{
    			X0Y0_器官右_器官1.Dra = value;
    			X0Y1_器官右_器官1.Dra = value;
    			X0Y0_器官右_器官1.Hit = value;
    			X0Y1_器官右_器官1.Hit = value;
    		}
    	}

    	public bool 器官右_器官2_表示
    	{
    		get
    		{
    			return X0Y0_器官右_器官2.Dra;
    		}
    		set
    		{
    			X0Y0_器官右_器官2.Dra = value;
    			X0Y1_器官右_器官2.Dra = value;
    			X0Y0_器官右_器官2.Hit = value;
    			X0Y1_器官右_器官2.Hit = value;
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
    			X0Y1_線.Dra = value;
    			X0Y0_線.Hit = value;
    			X0Y1_線.Hit = value;
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

    	public override double 展開
    	{
    		set
    		{
    			位置C = new Vector2D(位置C.X, -0.013 * value);
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
    			器官左_器官1_表示 = value;
    			器官左_器官2_表示 = value;
    			器官右_器官1_表示 = value;
    			器官右_器官2_表示 = value;
    			線_表示 = value;
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
    			器官左_器官1CD.不透明度 = value;
    			器官左_器官2CD.不透明度 = value;
    			器官右_器官1CD.不透明度 = value;
    			器官右_器官2CD.不透明度 = value;
    			線CD.不透明度 = value;
    			折線1CD.不透明度 = value;
    			折線2CD.不透明度 = value;
    		}
    	}

    	public 角1_虫(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 角1_虫D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(Sta.肢中["角"][2]);
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_根 = partGroup["根"].ToPar();
    		PartGroup pars2 = partGroup["器官左"].ToPars();
    		X0Y0_器官左_器官1 = pars2["器官1"].ToPar();
    		X0Y0_器官左_器官2 = pars2["器官2"].ToPar();
    		pars2 = partGroup["器官右"].ToPars();
    		X0Y0_器官右_器官1 = pars2["器官1"].ToPar();
    		X0Y0_器官右_器官2 = pars2["器官2"].ToPar();
    		X0Y0_線 = partGroup["線"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_根 = partGroup["根"].ToPar();
    		pars2 = partGroup["器官左"].ToPars();
    		X0Y1_器官左_器官1 = pars2["器官1"].ToPar();
    		X0Y1_器官左_器官2 = pars2["器官2"].ToPar();
    		pars2 = partGroup["器官右"].ToPars();
    		X0Y1_器官右_器官1 = pars2["器官1"].ToPar();
    		X0Y1_器官右_器官2 = pars2["器官2"].ToPar();
    		X0Y1_線 = partGroup["線"].ToPar();
    		X0Y1_折線1 = partGroup["折線1"].ToPar();
    		X0Y1_折線2 = partGroup["折線2"].ToPar();
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
    		器官左_器官1_表示 = e.器官左_器官1_表示;
    		器官左_器官2_表示 = e.器官左_器官2_表示;
    		器官右_器官1_表示 = e.器官右_器官1_表示;
    		器官右_器官2_表示 = e.器官右_器官2_表示;
    		線_表示 = e.線_表示;
    		折線1_表示 = e.折線1_表示;
    		折線2_表示 = e.折線2_表示;
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
    		X0Y0_根CP = new ColorP(X0Y0_根, 根CD, DisUnit, abj: true);
    		X0Y0_器官左_器官1CP = new ColorP(X0Y0_器官左_器官1, 器官左_器官1CD, DisUnit, abj: true);
    		X0Y0_器官左_器官2CP = new ColorP(X0Y0_器官左_器官2, 器官左_器官2CD, DisUnit, abj: true);
    		X0Y0_器官右_器官1CP = new ColorP(X0Y0_器官右_器官1, 器官右_器官1CD, DisUnit, abj: true);
    		X0Y0_器官右_器官2CP = new ColorP(X0Y0_器官右_器官2, 器官右_器官2CD, DisUnit, abj: true);
    		X0Y0_線CP = new ColorP(X0Y0_線, 線CD, DisUnit, abj: true);
    		X0Y1_根CP = new ColorP(X0Y1_根, 根CD, DisUnit, abj: true);
    		X0Y1_器官左_器官1CP = new ColorP(X0Y1_器官左_器官1, 器官左_器官1CD, DisUnit, abj: true);
    		X0Y1_器官左_器官2CP = new ColorP(X0Y1_器官左_器官2, 器官左_器官2CD, DisUnit, abj: true);
    		X0Y1_器官右_器官1CP = new ColorP(X0Y1_器官右_器官1, 器官右_器官1CD, DisUnit, abj: true);
    		X0Y1_器官右_器官2CP = new ColorP(X0Y1_器官右_器官2, 器官右_器官2CD, DisUnit, abj: true);
    		X0Y1_線CP = new ColorP(X0Y1_線, 線CD, DisUnit, abj: true);
    		X0Y1_折線1CP = new ColorP(X0Y1_折線1, 折線1CD, DisUnit, abj: true);
    		X0Y1_折線2CP = new ColorP(X0Y1_折線2, 折線2CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexY == 0)
    		{
    			X0Y0_根CP.Update();
    			X0Y0_器官左_器官1CP.Update();
    			X0Y0_器官左_器官2CP.Update();
    			X0Y0_器官右_器官1CP.Update();
    			X0Y0_器官右_器官2CP.Update();
    			X0Y0_線CP.Update();
    		}
    		else
    		{
    			X0Y1_根CP.Update();
    			X0Y1_器官左_器官1CP.Update();
    			X0Y1_器官左_器官2CP.Update();
    			X0Y1_器官右_器官1CP.Update();
    			X0Y1_器官右_器官2CP.Update();
    			X0Y1_線CP.Update();
    			X0Y1_折線1CP.Update();
    			X0Y1_折線2CP.Update();
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
    		根CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		器官左_器官1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		器官左_器官2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		器官右_器官1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		器官右_器官2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		線CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		折線1CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		折線2CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		根CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		器官左_器官1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		器官左_器官2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		器官右_器官1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		器官右_器官2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		線CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		折線1CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		折線2CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		根CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		器官左_器官1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		器官左_器官2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		器官右_器官1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		器官右_器官2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		線CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		折線1CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    		折線2CD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}
    }
}
