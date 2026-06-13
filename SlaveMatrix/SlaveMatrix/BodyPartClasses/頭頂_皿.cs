using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 頭頂_皿 : 頭頂
    {
    	public ShapePart X0Y0_皿1;

    	public ShapePart X0Y0_皿2;

    	public ShapePart X0Y0_甲殻_甲殻4;

    	public ShapePart X0Y0_甲殻_甲殻3;

    	public ShapePart X0Y0_甲殻_甲殻2;

    	public ShapePart X0Y0_甲殻_甲殻1;

    	public ColorD 皿1CD;

    	public ColorD 皿2CD;

    	public ColorD 甲殻_甲殻4CD;

    	public ColorD 甲殻_甲殻3CD;

    	public ColorD 甲殻_甲殻2CD;

    	public ColorD 甲殻_甲殻1CD;

    	public ColorP X0Y0_皿1CP;

    	public ColorP X0Y0_皿2CP;

    	public ColorP X0Y0_甲殻_甲殻4CP;

    	public ColorP X0Y0_甲殻_甲殻3CP;

    	public ColorP X0Y0_甲殻_甲殻2CP;

    	public ColorP X0Y0_甲殻_甲殻1CP;

    	private bool 甲殻_;

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

    	public bool 皿1_表示
    	{
    		get
    		{
    			return X0Y0_皿1.Dra;
    		}
    		set
    		{
    			X0Y0_皿1.Dra = value;
    			X0Y0_皿1.Hit = value;
    		}
    	}

    	public bool 皿2_表示
    	{
    		get
    		{
    			return X0Y0_皿2.Dra;
    		}
    		set
    		{
    			X0Y0_皿2.Dra = value;
    			X0Y0_皿2.Hit = value;
    		}
    	}

    	public bool 甲殻_甲殻4_表示
    	{
    		get
    		{
    			return X0Y0_甲殻_甲殻4.Dra;
    		}
    		set
    		{
    			X0Y0_甲殻_甲殻4.Dra = value;
    			X0Y0_甲殻_甲殻4.Hit = value;
    		}
    	}

    	public bool 甲殻_甲殻3_表示
    	{
    		get
    		{
    			return X0Y0_甲殻_甲殻3.Dra;
    		}
    		set
    		{
    			X0Y0_甲殻_甲殻3.Dra = value;
    			X0Y0_甲殻_甲殻3.Hit = value;
    		}
    	}

    	public bool 甲殻_甲殻2_表示
    	{
    		get
    		{
    			return X0Y0_甲殻_甲殻2.Dra;
    		}
    		set
    		{
    			X0Y0_甲殻_甲殻2.Dra = value;
    			X0Y0_甲殻_甲殻2.Hit = value;
    		}
    	}

    	public bool 甲殻_甲殻1_表示
    	{
    		get
    		{
    			return X0Y0_甲殻_甲殻1.Dra;
    		}
    		set
    		{
    			X0Y0_甲殻_甲殻1.Dra = value;
    			X0Y0_甲殻_甲殻1.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 皿1_表示;
    		}
    		set
    		{
    			皿1_表示 = value;
    			皿2_表示 = value;
    			甲殻_甲殻4_表示 = value;
    			甲殻_甲殻3_表示 = value;
    			甲殻_甲殻2_表示 = value;
    			甲殻_甲殻1_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 皿1CD.不透明度;
    		}
    		set
    		{
    			皿1CD.不透明度 = value;
    			皿2CD.不透明度 = value;
    			甲殻_甲殻4CD.不透明度 = value;
    			甲殻_甲殻3CD.不透明度 = value;
    			甲殻_甲殻2CD.不透明度 = value;
    			甲殻_甲殻1CD.不透明度 = value;
    		}
    	}

    	public bool 甲殻
    	{
    		get
    		{
    			return 甲殻_;
    		}
    		set
    		{
    			甲殻_ = value;
    			甲殻_甲殻4_表示 = 甲殻_;
    			甲殻_甲殻3_表示 = 甲殻_;
    			甲殻_甲殻2_表示 = 甲殻_;
    			甲殻_甲殻1_表示 = 甲殻_;
    		}
    	}

    	public 頭頂_皿(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 頭頂_皿D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant();
    		morphVariant.Tag = "皿";
    		morphVariant.Add(new PartGroup(Sta.肢中["頭部前"][0][1]));
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_皿1 = partGroup["皿1"].ToPar();
    		X0Y0_皿2 = partGroup["皿2"].ToPar();
    		PartGroup pars2 = partGroup["甲殻"].ToPars();
    		X0Y0_甲殻_甲殻4 = pars2["甲殻4"].ToPar();
    		X0Y0_甲殻_甲殻3 = pars2["甲殻3"].ToPar();
    		X0Y0_甲殻_甲殻2 = pars2["甲殻2"].ToPar();
    		X0Y0_甲殻_甲殻1 = pars2["甲殻1"].ToPar();
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
    		皿1_表示 = e.皿1_表示;
    		皿2_表示 = e.皿2_表示;
    		甲殻_甲殻4_表示 = e.甲殻_甲殻4_表示;
    		甲殻_甲殻3_表示 = e.甲殻_甲殻3_表示;
    		甲殻_甲殻2_表示 = e.甲殻_甲殻2_表示;
    		甲殻_甲殻1_表示 = e.甲殻_甲殻1_表示;
    		甲殻 = e.甲殻;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_皿1CP = new ColorP(X0Y0_皿1, 皿1CD, DisUnit, abj: true);
    		X0Y0_皿2CP = new ColorP(X0Y0_皿2, 皿2CD, DisUnit, abj: true);
    		X0Y0_甲殻_甲殻4CP = new ColorP(X0Y0_甲殻_甲殻4, 甲殻_甲殻4CD, DisUnit, abj: true);
    		X0Y0_甲殻_甲殻3CP = new ColorP(X0Y0_甲殻_甲殻3, 甲殻_甲殻3CD, DisUnit, abj: true);
    		X0Y0_甲殻_甲殻2CP = new ColorP(X0Y0_甲殻_甲殻2, 甲殻_甲殻2CD, DisUnit, abj: true);
    		X0Y0_甲殻_甲殻1CP = new ColorP(X0Y0_甲殻_甲殻1, 甲殻_甲殻1CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_皿1CP.Update();
    		X0Y0_皿2CP.Update();
    		X0Y0_甲殻_甲殻4CP.Update();
    		X0Y0_甲殻_甲殻3CP.Update();
    		X0Y0_甲殻_甲殻2CP.Update();
    		X0Y0_甲殻_甲殻1CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		皿1CD = new ColorD(ref ColorHelper.Black, ref 体配色.歯);
    		皿2CD = new ColorD(ref ColorHelper.Black, ref 体配色.爪O);
    		甲殻_甲殻4CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		甲殻_甲殻3CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		甲殻_甲殻2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		甲殻_甲殻1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    	}
    }
}
