using _2DGAMELIB;

namespace SlaveMatrix
{
    public class Tounge_長 : Tounge
    {
    	public ShapePart X0Y0_Tounge1;

    	public ShapePart X0Y0_Tounge2;

    	public ShapePart X0Y0_Tounge3;

    	public ShapePart X0Y0_Tounge4;

    	public ShapePart X0Y0_Tounge5;

    	public ShapePart X0Y0_舌股左_Tounge1;

    	public ShapePart X0Y0_舌股左_Tounge2;

    	public ShapePart X0Y0_舌股左_Tounge3;

    	public ShapePart X0Y0_舌股左_Tounge4;

    	public ShapePart X0Y0_舌股左_Tounge5;

    	public ShapePart X0Y0_舌股左_Tounge6;

    	public ShapePart X0Y0_舌股右_Tounge1;

    	public ShapePart X0Y0_舌股右_Tounge2;

    	public ShapePart X0Y0_舌股右_Tounge3;

    	public ShapePart X0Y0_舌股右_Tounge4;

    	public ShapePart X0Y0_舌股右_Tounge5;

    	public ShapePart X0Y0_舌股右_Tounge6;

    	public ColorD Tounge1CD;

    	public ColorD Tounge2CD;

    	public ColorD Tounge3CD;

    	public ColorD Tounge4CD;

    	public ColorD Tounge5CD;

    	public ColorD 舌股左_Tounge1CD;

    	public ColorD 舌股左_Tounge2CD;

    	public ColorD 舌股左_Tounge3CD;

    	public ColorD 舌股左_Tounge4CD;

    	public ColorD 舌股左_Tounge5CD;

    	public ColorD 舌股左_Tounge6CD;

    	public ColorD 舌股右_Tounge1CD;

    	public ColorD 舌股右_Tounge2CD;

    	public ColorD 舌股右_Tounge3CD;

    	public ColorD 舌股右_Tounge4CD;

    	public ColorD 舌股右_Tounge5CD;

    	public ColorD 舌股右_Tounge6CD;

    	public ColorP X0Y0_Tounge1CP;

    	public ColorP X0Y0_Tounge2CP;

    	public ColorP X0Y0_Tounge3CP;

    	public ColorP X0Y0_Tounge4CP;

    	public ColorP X0Y0_Tounge5CP;

    	public ColorP X0Y0_舌股左_Tounge1CP;

    	public ColorP X0Y0_舌股左_Tounge2CP;

    	public ColorP X0Y0_舌股左_Tounge3CP;

    	public ColorP X0Y0_舌股左_Tounge4CP;

    	public ColorP X0Y0_舌股左_Tounge5CP;

    	public ColorP X0Y0_舌股左_Tounge6CP;

    	public ColorP X0Y0_舌股右_Tounge1CP;

    	public ColorP X0Y0_舌股右_Tounge2CP;

    	public ColorP X0Y0_舌股右_Tounge3CP;

    	public ColorP X0Y0_舌股右_Tounge4CP;

    	public ColorP X0Y0_舌股右_Tounge5CP;

    	public ColorP X0Y0_舌股右_Tounge6CP;

    	public ShapePart[] Pars;

    	private Vector2D[] mm;

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

    	public bool Tounge1_表示
    	{
    		get
    		{
    			return X0Y0_Tounge1.Dra;
    		}
    		set
    		{
    			X0Y0_Tounge1.Dra = value;
    			X0Y0_Tounge1.Hit = value;
    		}
    	}

    	public bool Tounge2_表示
    	{
    		get
    		{
    			return X0Y0_Tounge2.Dra;
    		}
    		set
    		{
    			X0Y0_Tounge2.Dra = value;
    			X0Y0_Tounge2.Hit = value;
    		}
    	}

    	public bool Tounge3_表示
    	{
    		get
    		{
    			return X0Y0_Tounge3.Dra;
    		}
    		set
    		{
    			X0Y0_Tounge3.Dra = value;
    			X0Y0_Tounge3.Hit = value;
    		}
    	}

    	public bool Tounge4_表示
    	{
    		get
    		{
    			return X0Y0_Tounge4.Dra;
    		}
    		set
    		{
    			X0Y0_Tounge4.Dra = value;
    			X0Y0_Tounge4.Hit = value;
    		}
    	}

    	public bool Tounge5_表示
    	{
    		get
    		{
    			return X0Y0_Tounge5.Dra;
    		}
    		set
    		{
    			X0Y0_Tounge5.Dra = value;
    			X0Y0_Tounge5.Hit = value;
    		}
    	}

    	public bool 舌股左_Tounge1_表示
    	{
    		get
    		{
    			return X0Y0_舌股左_Tounge1.Dra;
    		}
    		set
    		{
    			X0Y0_舌股左_Tounge1.Dra = value;
    			X0Y0_舌股左_Tounge1.Hit = value;
    		}
    	}

    	public bool 舌股左_Tounge2_表示
    	{
    		get
    		{
    			return X0Y0_舌股左_Tounge2.Dra;
    		}
    		set
    		{
    			X0Y0_舌股左_Tounge2.Dra = value;
    			X0Y0_舌股左_Tounge2.Hit = value;
    		}
    	}

    	public bool 舌股左_Tounge3_表示
    	{
    		get
    		{
    			return X0Y0_舌股左_Tounge3.Dra;
    		}
    		set
    		{
    			X0Y0_舌股左_Tounge3.Dra = value;
    			X0Y0_舌股左_Tounge3.Hit = value;
    		}
    	}

    	public bool 舌股左_Tounge4_表示
    	{
    		get
    		{
    			return X0Y0_舌股左_Tounge4.Dra;
    		}
    		set
    		{
    			X0Y0_舌股左_Tounge4.Dra = value;
    			X0Y0_舌股左_Tounge4.Hit = value;
    		}
    	}

    	public bool 舌股左_Tounge5_表示
    	{
    		get
    		{
    			return X0Y0_舌股左_Tounge5.Dra;
    		}
    		set
    		{
    			X0Y0_舌股左_Tounge5.Dra = value;
    			X0Y0_舌股左_Tounge5.Hit = value;
    		}
    	}

    	public bool 舌股左_Tounge6_表示
    	{
    		get
    		{
    			return X0Y0_舌股左_Tounge6.Dra;
    		}
    		set
    		{
    			X0Y0_舌股左_Tounge6.Dra = value;
    			X0Y0_舌股左_Tounge6.Hit = value;
    		}
    	}

    	public bool 舌股右_Tounge1_表示
    	{
    		get
    		{
    			return X0Y0_舌股右_Tounge1.Dra;
    		}
    		set
    		{
    			X0Y0_舌股右_Tounge1.Dra = value;
    			X0Y0_舌股右_Tounge1.Hit = value;
    		}
    	}

    	public bool 舌股右_Tounge2_表示
    	{
    		get
    		{
    			return X0Y0_舌股右_Tounge2.Dra;
    		}
    		set
    		{
    			X0Y0_舌股右_Tounge2.Dra = value;
    			X0Y0_舌股右_Tounge2.Hit = value;
    		}
    	}

    	public bool 舌股右_Tounge3_表示
    	{
    		get
    		{
    			return X0Y0_舌股右_Tounge3.Dra;
    		}
    		set
    		{
    			X0Y0_舌股右_Tounge3.Dra = value;
    			X0Y0_舌股右_Tounge3.Hit = value;
    		}
    	}

    	public bool 舌股右_Tounge4_表示
    	{
    		get
    		{
    			return X0Y0_舌股右_Tounge4.Dra;
    		}
    		set
    		{
    			X0Y0_舌股右_Tounge4.Dra = value;
    			X0Y0_舌股右_Tounge4.Hit = value;
    		}
    	}

    	public bool 舌股右_Tounge5_表示
    	{
    		get
    		{
    			return X0Y0_舌股右_Tounge5.Dra;
    		}
    		set
    		{
    			X0Y0_舌股右_Tounge5.Dra = value;
    			X0Y0_舌股右_Tounge5.Hit = value;
    		}
    	}

    	public bool 舌股右_Tounge6_表示
    	{
    		get
    		{
    			return X0Y0_舌股右_Tounge6.Dra;
    		}
    		set
    		{
    			X0Y0_舌股右_Tounge6.Dra = value;
    			X0Y0_舌股右_Tounge6.Hit = value;
    		}
    	}

    	public bool 股舌表示
    	{
    		get
    		{
    			return 舌股左_Tounge1_表示;
    		}
    		set
    		{
    			舌股左_Tounge1_表示 = value;
    			舌股左_Tounge2_表示 = value;
    			舌股左_Tounge3_表示 = value;
    			舌股左_Tounge4_表示 = value;
    			舌股左_Tounge5_表示 = value;
    			舌股左_Tounge6_表示 = value;
    			舌股右_Tounge1_表示 = value;
    			舌股右_Tounge2_表示 = value;
    			舌股右_Tounge3_表示 = value;
    			舌股右_Tounge4_表示 = value;
    			舌股右_Tounge5_表示 = value;
    			舌股右_Tounge6_表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return Tounge1_表示;
    		}
    		set
    		{
    			Tounge1_表示 = value;
    			Tounge2_表示 = value;
    			Tounge3_表示 = value;
    			Tounge4_表示 = value;
    			Tounge5_表示 = value;
    			舌股左_Tounge1_表示 = value;
    			舌股左_Tounge2_表示 = value;
    			舌股左_Tounge3_表示 = value;
    			舌股左_Tounge4_表示 = value;
    			舌股左_Tounge5_表示 = value;
    			舌股左_Tounge6_表示 = value;
    			舌股右_Tounge1_表示 = value;
    			舌股右_Tounge2_表示 = value;
    			舌股右_Tounge3_表示 = value;
    			舌股右_Tounge4_表示 = value;
    			舌股右_Tounge5_表示 = value;
    			舌股右_Tounge6_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return Tounge1CD.不透明度;
    		}
    		set
    		{
    			Tounge1CD.不透明度 = value;
    			Tounge2CD.不透明度 = value;
    			Tounge3CD.不透明度 = value;
    			Tounge4CD.不透明度 = value;
    			Tounge5CD.不透明度 = value;
    			舌股左_Tounge1CD.不透明度 = value;
    			舌股左_Tounge2CD.不透明度 = value;
    			舌股左_Tounge3CD.不透明度 = value;
    			舌股左_Tounge4CD.不透明度 = value;
    			舌股左_Tounge5CD.不透明度 = value;
    			舌股左_Tounge6CD.不透明度 = value;
    			舌股右_Tounge1CD.不透明度 = value;
    			舌股右_Tounge2CD.不透明度 = value;
    			舌股右_Tounge3CD.不透明度 = value;
    			舌股右_Tounge4CD.不透明度 = value;
    			舌股右_Tounge5CD.不透明度 = value;
    			舌股右_Tounge6CD.不透明度 = value;
    		}
    	}

    	public Tounge_長(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, Tounge_長D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant();
    		morphVariant.Tag = "長";
    		morphVariant.Add(new PartGroup(GlobalState.胴体["Tounge"][0][1]));
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_Tounge1 = partGroup["舌1"].ToPar();
    		X0Y0_Tounge2 = partGroup["舌2"].ToPar();
    		X0Y0_Tounge3 = partGroup["舌3"].ToPar();
    		X0Y0_Tounge4 = partGroup["舌4"].ToPar();
    		X0Y0_Tounge5 = partGroup["舌5"].ToPar();
    		PartGroup pars2 = partGroup["舌股左"].ToPars();
    		X0Y0_舌股左_Tounge1 = pars2["舌1"].ToPar();
    		X0Y0_舌股左_Tounge2 = pars2["舌2"].ToPar();
    		X0Y0_舌股左_Tounge3 = pars2["舌3"].ToPar();
    		X0Y0_舌股左_Tounge4 = pars2["舌4"].ToPar();
    		X0Y0_舌股左_Tounge5 = pars2["舌5"].ToPar();
    		X0Y0_舌股左_Tounge6 = pars2["舌6"].ToPar();
    		pars2 = partGroup["舌股右"].ToPars();
    		X0Y0_舌股右_Tounge1 = pars2["舌1"].ToPar();
    		X0Y0_舌股右_Tounge2 = pars2["舌2"].ToPar();
    		X0Y0_舌股右_Tounge3 = pars2["舌3"].ToPar();
    		X0Y0_舌股右_Tounge4 = pars2["舌4"].ToPar();
    		X0Y0_舌股右_Tounge5 = pars2["舌5"].ToPar();
    		X0Y0_舌股右_Tounge6 = pars2["舌6"].ToPar();
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
    		Tounge1_表示 = e.Tounge1_表示;
    		Tounge2_表示 = e.Tounge2_表示;
    		Tounge3_表示 = e.Tounge3_表示;
    		Tounge4_表示 = e.Tounge4_表示;
    		Tounge5_表示 = e.Tounge5_表示;
    		舌股左_Tounge1_表示 = e.舌股左_Tounge1_表示;
    		舌股左_Tounge2_表示 = e.舌股左_Tounge2_表示;
    		舌股左_Tounge3_表示 = e.舌股左_Tounge3_表示;
    		舌股左_Tounge4_表示 = e.舌股左_Tounge4_表示;
    		舌股左_Tounge5_表示 = e.舌股左_Tounge5_表示;
    		舌股左_Tounge6_表示 = e.舌股左_Tounge6_表示;
    		舌股右_Tounge1_表示 = e.舌股右_Tounge1_表示;
    		舌股右_Tounge2_表示 = e.舌股右_Tounge2_表示;
    		舌股右_Tounge3_表示 = e.舌股右_Tounge3_表示;
    		舌股右_Tounge4_表示 = e.舌股右_Tounge4_表示;
    		舌股右_Tounge5_表示 = e.舌股右_Tounge5_表示;
    		舌股右_Tounge6_表示 = e.舌股右_Tounge6_表示;
    		股舌表示 = e.股舌表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		Pars = new ShapePart[17]
    		{
    			X0Y0_Tounge1, X0Y0_Tounge2, X0Y0_Tounge3, X0Y0_Tounge4, X0Y0_Tounge5, X0Y0_舌股左_Tounge1, X0Y0_舌股左_Tounge2, X0Y0_舌股左_Tounge3, X0Y0_舌股左_Tounge4, X0Y0_舌股左_Tounge5,
    			X0Y0_舌股左_Tounge6, X0Y0_舌股右_Tounge1, X0Y0_舌股右_Tounge2, X0Y0_舌股右_Tounge3, X0Y0_舌股右_Tounge4, X0Y0_舌股右_Tounge5, X0Y0_舌股右_Tounge6
    		};
    		X0Y0_Tounge1CP = new ColorP(X0Y0_Tounge1, Tounge1CD, DisUnit, abj: true);
    		X0Y0_Tounge2CP = new ColorP(X0Y0_Tounge2, Tounge2CD, DisUnit, abj: true);
    		X0Y0_Tounge3CP = new ColorP(X0Y0_Tounge3, Tounge3CD, DisUnit, abj: true);
    		X0Y0_Tounge4CP = new ColorP(X0Y0_Tounge4, Tounge4CD, DisUnit, abj: true);
    		X0Y0_Tounge5CP = new ColorP(X0Y0_Tounge5, Tounge5CD, DisUnit, abj: true);
    		X0Y0_舌股左_Tounge1CP = new ColorP(X0Y0_舌股左_Tounge1, 舌股左_Tounge1CD, DisUnit, abj: true);
    		X0Y0_舌股左_Tounge2CP = new ColorP(X0Y0_舌股左_Tounge2, 舌股左_Tounge2CD, DisUnit, abj: true);
    		X0Y0_舌股左_Tounge3CP = new ColorP(X0Y0_舌股左_Tounge3, 舌股左_Tounge3CD, DisUnit, abj: true);
    		X0Y0_舌股左_Tounge4CP = new ColorP(X0Y0_舌股左_Tounge4, 舌股左_Tounge4CD, DisUnit, abj: true);
    		X0Y0_舌股左_Tounge5CP = new ColorP(X0Y0_舌股左_Tounge5, 舌股左_Tounge5CD, DisUnit, abj: true);
    		X0Y0_舌股左_Tounge6CP = new ColorP(X0Y0_舌股左_Tounge6, 舌股左_Tounge6CD, DisUnit, abj: true);
    		X0Y0_舌股右_Tounge1CP = new ColorP(X0Y0_舌股右_Tounge1, 舌股右_Tounge1CD, DisUnit, abj: true);
    		X0Y0_舌股右_Tounge2CP = new ColorP(X0Y0_舌股右_Tounge2, 舌股右_Tounge2CD, DisUnit, abj: true);
    		X0Y0_舌股右_Tounge3CP = new ColorP(X0Y0_舌股右_Tounge3, 舌股右_Tounge3CD, DisUnit, abj: true);
    		X0Y0_舌股右_Tounge4CP = new ColorP(X0Y0_舌股右_Tounge4, 舌股右_Tounge4CD, DisUnit, abj: true);
    		X0Y0_舌股右_Tounge5CP = new ColorP(X0Y0_舌股右_Tounge5, 舌股右_Tounge5CD, DisUnit, abj: true);
    		X0Y0_舌股右_Tounge6CP = new ColorP(X0Y0_舌股右_Tounge6, 舌股右_Tounge6CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		Pars.GetMiY_MaY(out mm);
    		X0Y0_Tounge1CP.Update(mm);
    		X0Y0_Tounge2CP.Update(mm);
    		X0Y0_Tounge3CP.Update(mm);
    		X0Y0_Tounge4CP.Update(mm);
    		X0Y0_Tounge5CP.Update(mm);
    		X0Y0_舌股左_Tounge1CP.Update(mm);
    		X0Y0_舌股左_Tounge2CP.Update(mm);
    		X0Y0_舌股左_Tounge3CP.Update(mm);
    		X0Y0_舌股左_Tounge4CP.Update(mm);
    		X0Y0_舌股左_Tounge5CP.Update(mm);
    		X0Y0_舌股左_Tounge6CP.Update(mm);
    		X0Y0_舌股右_Tounge1CP.Update(mm);
    		X0Y0_舌股右_Tounge2CP.Update(mm);
    		X0Y0_舌股右_Tounge3CP.Update(mm);
    		X0Y0_舌股右_Tounge4CP.Update(mm);
    		X0Y0_舌股右_Tounge5CP.Update(mm);
    		X0Y0_舌股右_Tounge6CP.Update(mm);
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		Tounge1CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		Tounge2CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		Tounge3CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		Tounge4CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		Tounge5CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		舌股左_Tounge1CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		舌股左_Tounge2CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		舌股左_Tounge3CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		舌股左_Tounge4CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		舌股左_Tounge5CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		舌股左_Tounge6CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		舌股右_Tounge1CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		舌股右_Tounge2CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		舌股右_Tounge3CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		舌股右_Tounge4CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		舌股右_Tounge5CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    		舌股右_Tounge6CD = new ColorD(ref 体配色.粘膜線, ref 体配色.Tounge);
    	}
    }
}
