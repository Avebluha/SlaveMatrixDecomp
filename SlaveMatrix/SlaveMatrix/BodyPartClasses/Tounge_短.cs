using _2DGAMELIB;

namespace SlaveMatrix
{
    public class Tounge_短 : Tounge
    {
    	public ShapePart X0Y0_Tounge1;

    	public ShapePart X0Y0_Tounge2;

    	public ShapePart X0Y0_Tounge3;

    	public ShapePart X0Y0_Tounge4;

    	public ShapePart X0Y0_Tounge5;

    	public ColorD Tounge1CD;

    	public ColorD Tounge2CD;

    	public ColorD Tounge3CD;

    	public ColorD Tounge4CD;

    	public ColorD Tounge5CD;

    	public ColorP X0Y0_Tounge1CP;

    	public ColorP X0Y0_Tounge2CP;

    	public ColorP X0Y0_Tounge3CP;

    	public ColorP X0Y0_Tounge4CP;

    	public ColorP X0Y0_Tounge5CP;

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
    		}
    	}

    	public Tounge_短(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, Tounge_短D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant();
    		morphVariant.Tag = "短";
    		morphVariant.Add(new PartGroup(GlobalState.胴体["Tounge"][0][0]));
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_Tounge1 = partGroup["舌1"].ToPar();
    		X0Y0_Tounge2 = partGroup["舌2"].ToPar();
    		X0Y0_Tounge3 = partGroup["舌3"].ToPar();
    		X0Y0_Tounge4 = partGroup["舌4"].ToPar();
    		X0Y0_Tounge5 = partGroup["舌5"].ToPar();
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
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		Pars = new ShapePart[5] { X0Y0_Tounge1, X0Y0_Tounge2, X0Y0_Tounge3, X0Y0_Tounge4, X0Y0_Tounge5 };
    		X0Y0_Tounge1CP = new ColorP(X0Y0_Tounge1, Tounge1CD, DisUnit, abj: true);
    		X0Y0_Tounge2CP = new ColorP(X0Y0_Tounge2, Tounge2CD, DisUnit, abj: true);
    		X0Y0_Tounge3CP = new ColorP(X0Y0_Tounge3, Tounge3CD, DisUnit, abj: true);
    		X0Y0_Tounge4CP = new ColorP(X0Y0_Tounge4, Tounge4CD, DisUnit, abj: true);
    		X0Y0_Tounge5CP = new ColorP(X0Y0_Tounge5, Tounge5CD, DisUnit, abj: true);
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
    	}
    }
}
