using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 大顎上 : Element
    {
    	public ShapePart X0Y0_甲殻;

    	public ShapePart X0Y0_線左;

    	public ShapePart X0Y0_線右;

    	public ShapePart X0Y0_棘左;

    	public ShapePart X0Y0_棘右;

    	public ColorD 甲殻CD;

    	public ColorD 線左CD;

    	public ColorD 線右CD;

    	public ColorD 刺左CD;

    	public ColorD 刺右CD;

    	public ColorP X0Y0_甲殻CP;

    	public ColorP X0Y0_線左CP;

    	public ColorP X0Y0_線右CP;

    	public ColorP X0Y0_棘左CP;

    	public ColorP X0Y0_棘右CP;

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

    	public bool 甲殻_表示
    	{
    		get
    		{
    			return X0Y0_甲殻.Dra;
    		}
    		set
    		{
    			X0Y0_甲殻.Dra = value;
    			X0Y0_甲殻.Hit = value;
    		}
    	}

    	public bool 線左_表示
    	{
    		get
    		{
    			return X0Y0_線左.Dra;
    		}
    		set
    		{
    			X0Y0_線左.Dra = value;
    			X0Y0_線左.Hit = value;
    		}
    	}

    	public bool 線右_表示
    	{
    		get
    		{
    			return X0Y0_線右.Dra;
    		}
    		set
    		{
    			X0Y0_線右.Dra = value;
    			X0Y0_線右.Hit = value;
    		}
    	}

    	public bool 刺左_表示
    	{
    		get
    		{
    			return X0Y0_棘左.Dra;
    		}
    		set
    		{
    			X0Y0_棘左.Dra = value;
    			X0Y0_棘左.Hit = value;
    		}
    	}

    	public bool 刺右_表示
    	{
    		get
    		{
    			return X0Y0_棘右.Dra;
    		}
    		set
    		{
    			X0Y0_棘右.Dra = value;
    			X0Y0_棘右.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 甲殻_表示;
    		}
    		set
    		{
    			甲殻_表示 = value;
    			線左_表示 = value;
    			線右_表示 = value;
    			刺左_表示 = value;
    			刺右_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 甲殻CD.不透明度;
    		}
    		set
    		{
    			甲殻CD.不透明度 = value;
    			線左CD.不透明度 = value;
    			線右CD.不透明度 = value;
    			刺左CD.不透明度 = value;
    			刺右CD.不透明度 = value;
    		}
    	}

    	public 大顎上(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid(Sta.肢中["大顎上"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_甲殻 = partGroup["甲殻"].ToPar();
    		X0Y0_線左 = partGroup["線左"].ToPar();
    		X0Y0_線右 = partGroup["線右"].ToPar();
    		X0Y0_棘左 = partGroup["刺左"].ToPar();
    		X0Y0_棘右 = partGroup["刺右"].ToPar();
    		Body.SetJoints();
    		接続根 = new JointD(Body);
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_甲殻CP = new ColorP(X0Y0_甲殻, 甲殻CD, DisUnit, abj: true);
    		X0Y0_線左CP = new ColorP(X0Y0_線左, 線左CD, DisUnit, abj: true);
    		X0Y0_線右CP = new ColorP(X0Y0_線右, 線右CD, DisUnit, abj: true);
    		X0Y0_棘左CP = new ColorP(X0Y0_棘左, 刺左CD, DisUnit, abj: true);
    		X0Y0_棘右CP = new ColorP(X0Y0_棘右, 刺右CD, DisUnit, abj: true);
    	}

    	public override void 色更新()
    	{
    		X0Y0_甲殻CP.Update();
    		X0Y0_線左CP.Update();
    		X0Y0_線右CP.Update();
    		X0Y0_棘左CP.Update();
    		X0Y0_棘右CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		線左CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		線右CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		刺左CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		刺右CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    	}
    }
}
