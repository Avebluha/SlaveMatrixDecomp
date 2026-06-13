using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 上着トップ_ドレス : 上着トップ
    {
    	public ShapePart X0Y0_服基;

    	public ShapePart X0Y0_紐_紐1_紐下_紐;

    	public ShapePart X0Y0_紐_紐1_紐上_紐;

    	public ShapePart X0Y0_紐_紐2_紐下_紐;

    	public ShapePart X0Y0_紐_紐2_紐上_紐;

    	public ShapePart X0Y0_紐_紐3_紐下_紐;

    	public ShapePart X0Y0_紐_紐3_紐上_紐;

    	public ShapePart X0Y0_紐_紐4_紐下_紐;

    	public ShapePart X0Y0_紐_紐4_紐上_紐;

    	public ShapePart X0Y0_紐_紐5_紐下_紐;

    	public ShapePart X0Y0_紐_紐5_紐上_紐;

    	public ShapePart X0Y0_紐_紐6_紐下_紐;

    	public ShapePart X0Y0_紐_紐6_紐上_紐;

    	public ShapePart X0Y0_左_服;

    	public ShapePart X0Y0_左_柄_柄1;

    	public ShapePart X0Y0_左_柄_柄2;

    	public ShapePart X0Y0_左_バスト;

    	public ShapePart X0Y0_左_縁;

    	public ShapePart X0Y0_右_服;

    	public ShapePart X0Y0_右_柄_柄1;

    	public ShapePart X0Y0_右_柄_柄2;

    	public ShapePart X0Y0_右_バスト;

    	public ShapePart X0Y0_右_縁;

    	public ColorD 服基CD = new ColorD(ref Col.Empty, ref Color2.Empty);

    	public ColorD 紐_紐1_紐下_紐CD;

    	public ColorD 紐_紐1_紐上_紐CD;

    	public ColorD 紐_紐2_紐下_紐CD;

    	public ColorD 紐_紐2_紐上_紐CD;

    	public ColorD 紐_紐3_紐下_紐CD;

    	public ColorD 紐_紐3_紐上_紐CD;

    	public ColorD 紐_紐4_紐下_紐CD;

    	public ColorD 紐_紐4_紐上_紐CD;

    	public ColorD 紐_紐5_紐下_紐CD;

    	public ColorD 紐_紐5_紐上_紐CD;

    	public ColorD 紐_紐6_紐下_紐CD;

    	public ColorD 紐_紐6_紐上_紐CD;

    	public ColorD 左_服CD;

    	public ColorD 左_柄_柄1CD;

    	public ColorD 左_柄_柄2CD;

    	public ColorD 左_バストCD;

    	public ColorD 左_縁CD;

    	public ColorD 右_服CD;

    	public ColorD 右_柄_柄1CD;

    	public ColorD 右_柄_柄2CD;

    	public ColorD 右_バストCD;

    	public ColorD 右_縁CD;

    	public ColorP X0Y0_服基CP;

    	public ColorP X0Y0_紐_紐1_紐下_紐CP;

    	public ColorP X0Y0_紐_紐1_紐上_紐CP;

    	public ColorP X0Y0_紐_紐2_紐下_紐CP;

    	public ColorP X0Y0_紐_紐2_紐上_紐CP;

    	public ColorP X0Y0_紐_紐3_紐下_紐CP;

    	public ColorP X0Y0_紐_紐3_紐上_紐CP;

    	public ColorP X0Y0_紐_紐4_紐下_紐CP;

    	public ColorP X0Y0_紐_紐4_紐上_紐CP;

    	public ColorP X0Y0_紐_紐5_紐下_紐CP;

    	public ColorP X0Y0_紐_紐5_紐上_紐CP;

    	public ColorP X0Y0_紐_紐6_紐下_紐CP;

    	public ColorP X0Y0_紐_紐6_紐上_紐CP;

    	public ColorP X0Y0_左_服CP;

    	public ColorP X0Y0_左_柄_柄1CP;

    	public ColorP X0Y0_左_柄_柄2CP;

    	public ColorP X0Y0_左_バストCP;

    	public ColorP X0Y0_左_縁CP;

    	public ColorP X0Y0_右_服CP;

    	public ColorP X0Y0_右_柄_柄1CP;

    	public ColorP X0Y0_右_柄_柄2CP;

    	public ColorP X0Y0_右_バストCP;

    	public ColorP X0Y0_右_縁CP;

    	private double sb;

    	private double syb;

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

    	public bool 服基_表示
    	{
    		get
    		{
    			return X0Y0_服基.Dra;
    		}
    		set
    		{
    			X0Y0_服基.Dra = value;
    			X0Y0_服基.Hit = false;
    		}
    	}

    	public bool 紐_紐1_紐下_紐_表示
    	{
    		get
    		{
    			return X0Y0_紐_紐1_紐下_紐.Dra;
    		}
    		set
    		{
    			X0Y0_紐_紐1_紐下_紐.Dra = value;
    			X0Y0_紐_紐1_紐下_紐.Hit = false;
    		}
    	}

    	public bool 紐_紐1_紐上_紐_表示
    	{
    		get
    		{
    			return X0Y0_紐_紐1_紐上_紐.Dra;
    		}
    		set
    		{
    			X0Y0_紐_紐1_紐上_紐.Dra = value;
    			X0Y0_紐_紐1_紐上_紐.Hit = false;
    		}
    	}

    	public bool 紐_紐2_紐下_紐_表示
    	{
    		get
    		{
    			return X0Y0_紐_紐2_紐下_紐.Dra;
    		}
    		set
    		{
    			X0Y0_紐_紐2_紐下_紐.Dra = value;
    			X0Y0_紐_紐2_紐下_紐.Hit = false;
    		}
    	}

    	public bool 紐_紐2_紐上_紐_表示
    	{
    		get
    		{
    			return X0Y0_紐_紐2_紐上_紐.Dra;
    		}
    		set
    		{
    			X0Y0_紐_紐2_紐上_紐.Dra = value;
    			X0Y0_紐_紐2_紐上_紐.Hit = false;
    		}
    	}

    	public bool 紐_紐3_紐下_紐_表示
    	{
    		get
    		{
    			return X0Y0_紐_紐3_紐下_紐.Dra;
    		}
    		set
    		{
    			X0Y0_紐_紐3_紐下_紐.Dra = value;
    			X0Y0_紐_紐3_紐下_紐.Hit = false;
    		}
    	}

    	public bool 紐_紐3_紐上_紐_表示
    	{
    		get
    		{
    			return X0Y0_紐_紐3_紐上_紐.Dra;
    		}
    		set
    		{
    			X0Y0_紐_紐3_紐上_紐.Dra = value;
    			X0Y0_紐_紐3_紐上_紐.Hit = false;
    		}
    	}

    	public bool 紐_紐4_紐下_紐_表示
    	{
    		get
    		{
    			return X0Y0_紐_紐4_紐下_紐.Dra;
    		}
    		set
    		{
    			X0Y0_紐_紐4_紐下_紐.Dra = value;
    			X0Y0_紐_紐4_紐下_紐.Hit = false;
    		}
    	}

    	public bool 紐_紐4_紐上_紐_表示
    	{
    		get
    		{
    			return X0Y0_紐_紐4_紐上_紐.Dra;
    		}
    		set
    		{
    			X0Y0_紐_紐4_紐上_紐.Dra = value;
    			X0Y0_紐_紐4_紐上_紐.Hit = false;
    		}
    	}

    	public bool 紐_紐5_紐下_紐_表示
    	{
    		get
    		{
    			return X0Y0_紐_紐5_紐下_紐.Dra;
    		}
    		set
    		{
    			X0Y0_紐_紐5_紐下_紐.Dra = value;
    			X0Y0_紐_紐5_紐下_紐.Hit = false;
    		}
    	}

    	public bool 紐_紐5_紐上_紐_表示
    	{
    		get
    		{
    			return X0Y0_紐_紐5_紐上_紐.Dra;
    		}
    		set
    		{
    			X0Y0_紐_紐5_紐上_紐.Dra = value;
    			X0Y0_紐_紐5_紐上_紐.Hit = false;
    		}
    	}

    	public bool 紐_紐6_紐下_紐_表示
    	{
    		get
    		{
    			return X0Y0_紐_紐6_紐下_紐.Dra;
    		}
    		set
    		{
    			X0Y0_紐_紐6_紐下_紐.Dra = value;
    			X0Y0_紐_紐6_紐下_紐.Hit = false;
    		}
    	}

    	public bool 紐_紐6_紐上_紐_表示
    	{
    		get
    		{
    			return X0Y0_紐_紐6_紐上_紐.Dra;
    		}
    		set
    		{
    			X0Y0_紐_紐6_紐上_紐.Dra = value;
    			X0Y0_紐_紐6_紐上_紐.Hit = false;
    		}
    	}

    	public bool 左_服_表示
    	{
    		get
    		{
    			return X0Y0_左_服.Dra;
    		}
    		set
    		{
    			X0Y0_左_服.Dra = value;
    			X0Y0_左_服.Hit = false;
    		}
    	}

    	public bool 左_柄_柄1_表示
    	{
    		get
    		{
    			return X0Y0_左_柄_柄1.Dra;
    		}
    		set
    		{
    			X0Y0_左_柄_柄1.Dra = value;
    			X0Y0_左_柄_柄1.Hit = false;
    		}
    	}

    	public bool 左_柄_柄2_表示
    	{
    		get
    		{
    			return X0Y0_左_柄_柄2.Dra;
    		}
    		set
    		{
    			X0Y0_左_柄_柄2.Dra = value;
    			X0Y0_左_柄_柄2.Hit = false;
    		}
    	}

    	public bool 左_バスト_表示
    	{
    		get
    		{
    			return X0Y0_左_バスト.Dra;
    		}
    		set
    		{
    			X0Y0_左_バスト.Dra = value;
    			X0Y0_左_バスト.Hit = false;
    		}
    	}

    	public bool 左_縁_表示
    	{
    		get
    		{
    			return X0Y0_左_縁.Dra;
    		}
    		set
    		{
    			X0Y0_左_縁.Dra = value;
    			X0Y0_左_縁.Hit = false;
    		}
    	}

    	public bool 右_服_表示
    	{
    		get
    		{
    			return X0Y0_右_服.Dra;
    		}
    		set
    		{
    			X0Y0_右_服.Dra = value;
    			X0Y0_右_服.Hit = false;
    		}
    	}

    	public bool 右_柄_柄1_表示
    	{
    		get
    		{
    			return X0Y0_右_柄_柄1.Dra;
    		}
    		set
    		{
    			X0Y0_右_柄_柄1.Dra = value;
    			X0Y0_右_柄_柄1.Hit = false;
    		}
    	}

    	public bool 右_柄_柄2_表示
    	{
    		get
    		{
    			return X0Y0_右_柄_柄2.Dra;
    		}
    		set
    		{
    			X0Y0_右_柄_柄2.Dra = value;
    			X0Y0_右_柄_柄2.Hit = false;
    		}
    	}

    	public bool 右_バスト_表示
    	{
    		get
    		{
    			return X0Y0_右_バスト.Dra;
    		}
    		set
    		{
    			X0Y0_右_バスト.Dra = value;
    			X0Y0_右_バスト.Hit = false;
    		}
    	}

    	public bool 右_縁_表示
    	{
    		get
    		{
    			return X0Y0_右_縁.Dra;
    		}
    		set
    		{
    			X0Y0_右_縁.Dra = value;
    			X0Y0_右_縁.Hit = false;
    		}
    	}

    	public bool ベース表示
    	{
    		get
    		{
    			return 左_服_表示;
    		}
    		set
    		{
    			左_服_表示 = value;
    			左_バスト_表示 = value;
    			右_服_表示 = value;
    			右_バスト_表示 = value;
    		}
    	}

    	public bool 紐1表示
    	{
    		get
    		{
    			return 紐_紐1_紐下_紐_表示;
    		}
    		set
    		{
    			紐_紐1_紐下_紐_表示 = value;
    			紐_紐1_紐上_紐_表示 = value;
    		}
    	}

    	public bool 紐2表示
    	{
    		get
    		{
    			return 紐_紐2_紐下_紐_表示;
    		}
    		set
    		{
    			紐_紐2_紐下_紐_表示 = value;
    			紐_紐2_紐上_紐_表示 = value;
    		}
    	}

    	public bool 紐3表示
    	{
    		get
    		{
    			return 紐_紐3_紐下_紐_表示;
    		}
    		set
    		{
    			紐_紐3_紐下_紐_表示 = value;
    			紐_紐3_紐上_紐_表示 = value;
    		}
    	}

    	public bool 紐4表示
    	{
    		get
    		{
    			return 紐_紐4_紐下_紐_表示;
    		}
    		set
    		{
    			紐_紐4_紐下_紐_表示 = value;
    			紐_紐4_紐上_紐_表示 = value;
    		}
    	}

    	public bool 紐5表示
    	{
    		get
    		{
    			return 紐_紐5_紐下_紐_表示;
    		}
    		set
    		{
    			紐_紐5_紐下_紐_表示 = value;
    			紐_紐5_紐上_紐_表示 = value;
    		}
    	}

    	public bool 紐6表示
    	{
    		get
    		{
    			return 紐_紐6_紐下_紐_表示;
    		}
    		set
    		{
    			紐_紐6_紐下_紐_表示 = value;
    			紐_紐6_紐上_紐_表示 = value;
    		}
    	}

    	public bool 縁表示
    	{
    		get
    		{
    			return 左_縁_表示;
    		}
    		set
    		{
    			左_縁_表示 = value;
    			右_縁_表示 = value;
    		}
    	}

    	public bool 柄1表示
    	{
    		get
    		{
    			return 左_柄_柄1_表示;
    		}
    		set
    		{
    			左_柄_柄1_表示 = value;
    			右_柄_柄1_表示 = value;
    		}
    	}

    	public bool 柄2表示
    	{
    		get
    		{
    			return 左_柄_柄2_表示;
    		}
    		set
    		{
    			左_柄_柄2_表示 = value;
    			右_柄_柄2_表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 服基_表示;
    		}
    		set
    		{
    			服基_表示 = value;
    			紐_紐1_紐下_紐_表示 = value;
    			紐_紐1_紐上_紐_表示 = value;
    			紐_紐2_紐下_紐_表示 = value;
    			紐_紐2_紐上_紐_表示 = value;
    			紐_紐3_紐下_紐_表示 = value;
    			紐_紐3_紐上_紐_表示 = value;
    			紐_紐4_紐下_紐_表示 = value;
    			紐_紐4_紐上_紐_表示 = value;
    			紐_紐5_紐下_紐_表示 = value;
    			紐_紐5_紐上_紐_表示 = value;
    			紐_紐6_紐下_紐_表示 = value;
    			紐_紐6_紐上_紐_表示 = value;
    			左_服_表示 = value;
    			左_柄_柄1_表示 = value;
    			左_柄_柄2_表示 = value;
    			左_バスト_表示 = value;
    			左_縁_表示 = value;
    			右_服_表示 = value;
    			右_柄_柄1_表示 = value;
    			右_柄_柄2_表示 = value;
    			右_バスト_表示 = value;
    			右_縁_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 服基CD.不透明度;
    		}
    		set
    		{
    			服基CD.不透明度 = value;
    			紐_紐1_紐下_紐CD.不透明度 = value;
    			紐_紐1_紐上_紐CD.不透明度 = value;
    			紐_紐2_紐下_紐CD.不透明度 = value;
    			紐_紐2_紐上_紐CD.不透明度 = value;
    			紐_紐3_紐下_紐CD.不透明度 = value;
    			紐_紐3_紐上_紐CD.不透明度 = value;
    			紐_紐4_紐下_紐CD.不透明度 = value;
    			紐_紐4_紐上_紐CD.不透明度 = value;
    			紐_紐5_紐下_紐CD.不透明度 = value;
    			紐_紐5_紐上_紐CD.不透明度 = value;
    			紐_紐6_紐下_紐CD.不透明度 = value;
    			紐_紐6_紐上_紐CD.不透明度 = value;
    			左_服CD.不透明度 = value;
    			左_柄_柄1CD.不透明度 = value;
    			左_柄_柄2CD.不透明度 = value;
    			左_バストCD.不透明度 = value;
    			左_縁CD.不透明度 = value;
    			右_服CD.不透明度 = value;
    			右_柄_柄1CD.不透明度 = value;
    			右_柄_柄2CD.不透明度 = value;
    			右_バストCD.不透明度 = value;
    			右_縁CD.不透明度 = value;
    		}
    	}

    	public double バスト
    	{
    		set
    		{
    			double sizeBase = sb * (0.9 + 0.25 * value);
    			X0Y0_左_バスト.SizeBase = sizeBase;
    			X0Y0_右_バスト.SizeBase = sizeBase;
    			sizeBase = syb * (1.0 + 0.05 * value);
    			X0Y0_左_バスト.SizeYBase = sizeBase;
    			X0Y0_右_バスト.SizeYBase = sizeBase;
    		}
    	}

    	public 上着トップ_ドレス(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 上着トップ_ドレスD e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.胴体["上着トップ"][2]);
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_服基 = partGroup["服基"].ToPar();
    		PartGroup pars2 = partGroup["紐"].ToPars();
    		PartGroup pars3 = pars2["紐1"].ToPars();
    		PartGroup pars4 = pars3["紐下"].ToPars();
    		X0Y0_紐_紐1_紐下_紐 = pars4["紐"].ToPar();
    		pars4 = pars3["紐上"].ToPars();
    		X0Y0_紐_紐1_紐上_紐 = pars4["紐"].ToPar();
    		pars3 = pars2["紐2"].ToPars();
    		pars4 = pars3["紐下"].ToPars();
    		X0Y0_紐_紐2_紐下_紐 = pars4["紐"].ToPar();
    		pars4 = pars3["紐上"].ToPars();
    		X0Y0_紐_紐2_紐上_紐 = pars4["紐"].ToPar();
    		pars3 = pars2["紐3"].ToPars();
    		pars4 = pars3["紐下"].ToPars();
    		X0Y0_紐_紐3_紐下_紐 = pars4["紐"].ToPar();
    		pars4 = pars3["紐上"].ToPars();
    		X0Y0_紐_紐3_紐上_紐 = pars4["紐"].ToPar();
    		pars3 = pars2["紐4"].ToPars();
    		pars4 = pars3["紐下"].ToPars();
    		X0Y0_紐_紐4_紐下_紐 = pars4["紐"].ToPar();
    		pars4 = pars3["紐上"].ToPars();
    		X0Y0_紐_紐4_紐上_紐 = pars4["紐"].ToPar();
    		pars3 = pars2["紐5"].ToPars();
    		pars4 = pars3["紐下"].ToPars();
    		X0Y0_紐_紐5_紐下_紐 = pars4["紐"].ToPar();
    		pars4 = pars3["紐上"].ToPars();
    		X0Y0_紐_紐5_紐上_紐 = pars4["紐"].ToPar();
    		pars3 = pars2["紐6"].ToPars();
    		pars4 = pars3["紐下"].ToPars();
    		X0Y0_紐_紐6_紐下_紐 = pars4["紐"].ToPar();
    		pars4 = pars3["紐上"].ToPars();
    		X0Y0_紐_紐6_紐上_紐 = pars4["紐"].ToPar();
    		pars2 = partGroup["左"].ToPars();
    		X0Y0_左_服 = pars2["服"].ToPar();
    		pars3 = pars2["柄"].ToPars();
    		X0Y0_左_柄_柄1 = pars3["柄1"].ToPar();
    		X0Y0_左_柄_柄2 = pars3["柄2"].ToPar();
    		X0Y0_左_バスト = pars2["バスト"].ToPar();
    		X0Y0_左_縁 = pars2["縁"].ToPar();
    		pars2 = partGroup["右"].ToPars();
    		X0Y0_右_服 = pars2["服"].ToPar();
    		pars3 = pars2["柄"].ToPars();
    		X0Y0_右_柄_柄1 = pars3["柄1"].ToPar();
    		X0Y0_右_柄_柄2 = pars3["柄2"].ToPar();
    		X0Y0_右_バスト = pars2["バスト"].ToPar();
    		X0Y0_右_縁 = pars2["縁"].ToPar();
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
    		尺度YB = 0.95;
    		sb = 尺度B;
    		syb = 尺度YB;
    		肥大 = e.肥大;
    		身長 = e.身長;
    		Xv = e.Xv;
    		Yv = e.Yv;
    		Xi = e.Xi;
    		Yi = e.Yi;
    		サイズ = e.サイズ;
    		サイズX = e.サイズX;
    		サイズY = e.サイズY;
    		服基_表示 = e.服基_表示;
    		紐_紐1_紐下_紐_表示 = e.紐_紐1_紐下_紐_表示;
    		紐_紐1_紐上_紐_表示 = e.紐_紐1_紐上_紐_表示;
    		紐_紐2_紐下_紐_表示 = e.紐_紐2_紐下_紐_表示;
    		紐_紐2_紐上_紐_表示 = e.紐_紐2_紐上_紐_表示;
    		紐_紐3_紐下_紐_表示 = e.紐_紐3_紐下_紐_表示;
    		紐_紐3_紐上_紐_表示 = e.紐_紐3_紐上_紐_表示;
    		紐_紐4_紐下_紐_表示 = e.紐_紐4_紐下_紐_表示;
    		紐_紐4_紐上_紐_表示 = e.紐_紐4_紐上_紐_表示;
    		紐_紐5_紐下_紐_表示 = e.紐_紐5_紐下_紐_表示;
    		紐_紐5_紐上_紐_表示 = e.紐_紐5_紐上_紐_表示;
    		紐_紐6_紐下_紐_表示 = e.紐_紐6_紐下_紐_表示;
    		紐_紐6_紐上_紐_表示 = e.紐_紐6_紐上_紐_表示;
    		左_服_表示 = e.左_服_表示;
    		左_柄_柄1_表示 = e.左_柄_柄1_表示;
    		左_柄_柄2_表示 = e.左_柄_柄2_表示;
    		左_バスト_表示 = e.左_バスト_表示;
    		左_縁_表示 = e.左_縁_表示;
    		右_服_表示 = e.右_服_表示;
    		右_柄_柄1_表示 = e.右_柄_柄1_表示;
    		右_柄_柄2_表示 = e.右_柄_柄2_表示;
    		右_バスト_表示 = e.右_バスト_表示;
    		右_縁_表示 = e.右_縁_表示;
    		ベース表示 = e.ベース表示;
    		紐1表示 = e.紐1表示;
    		紐2表示 = e.紐2表示;
    		紐3表示 = e.紐3表示;
    		紐4表示 = e.紐4表示;
    		紐5表示 = e.紐5表示;
    		紐6表示 = e.紐6表示;
    		縁表示 = e.縁表示;
    		柄1表示 = e.柄1表示;
    		柄2表示 = e.柄2表示;
    		バスト = e.バスト;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_服基CP = new ColorP(X0Y0_服基, 服基CD, DisUnit, abj: true);
    		X0Y0_紐_紐1_紐下_紐CP = new ColorP(X0Y0_紐_紐1_紐下_紐, 紐_紐1_紐下_紐CD, DisUnit, abj: true);
    		X0Y0_紐_紐1_紐上_紐CP = new ColorP(X0Y0_紐_紐1_紐上_紐, 紐_紐1_紐上_紐CD, DisUnit, abj: true);
    		X0Y0_紐_紐2_紐下_紐CP = new ColorP(X0Y0_紐_紐2_紐下_紐, 紐_紐2_紐下_紐CD, DisUnit, abj: true);
    		X0Y0_紐_紐2_紐上_紐CP = new ColorP(X0Y0_紐_紐2_紐上_紐, 紐_紐2_紐上_紐CD, DisUnit, abj: true);
    		X0Y0_紐_紐3_紐下_紐CP = new ColorP(X0Y0_紐_紐3_紐下_紐, 紐_紐3_紐下_紐CD, DisUnit, abj: true);
    		X0Y0_紐_紐3_紐上_紐CP = new ColorP(X0Y0_紐_紐3_紐上_紐, 紐_紐3_紐上_紐CD, DisUnit, abj: true);
    		X0Y0_紐_紐4_紐下_紐CP = new ColorP(X0Y0_紐_紐4_紐下_紐, 紐_紐4_紐下_紐CD, DisUnit, abj: true);
    		X0Y0_紐_紐4_紐上_紐CP = new ColorP(X0Y0_紐_紐4_紐上_紐, 紐_紐4_紐上_紐CD, DisUnit, abj: true);
    		X0Y0_紐_紐5_紐下_紐CP = new ColorP(X0Y0_紐_紐5_紐下_紐, 紐_紐5_紐下_紐CD, DisUnit, abj: true);
    		X0Y0_紐_紐5_紐上_紐CP = new ColorP(X0Y0_紐_紐5_紐上_紐, 紐_紐5_紐上_紐CD, DisUnit, abj: true);
    		X0Y0_紐_紐6_紐下_紐CP = new ColorP(X0Y0_紐_紐6_紐下_紐, 紐_紐6_紐下_紐CD, DisUnit, abj: true);
    		X0Y0_紐_紐6_紐上_紐CP = new ColorP(X0Y0_紐_紐6_紐上_紐, 紐_紐6_紐上_紐CD, DisUnit, abj: true);
    		X0Y0_左_服CP = new ColorP(X0Y0_左_服, 左_服CD, DisUnit, abj: true);
    		X0Y0_左_柄_柄1CP = new ColorP(X0Y0_左_柄_柄1, 左_柄_柄1CD, DisUnit, abj: true);
    		X0Y0_左_柄_柄2CP = new ColorP(X0Y0_左_柄_柄2, 左_柄_柄2CD, DisUnit, abj: true);
    		X0Y0_左_バストCP = new ColorP(X0Y0_左_バスト, 左_バストCD, DisUnit, abj: true);
    		X0Y0_左_縁CP = new ColorP(X0Y0_左_縁, 左_縁CD, DisUnit, abj: true);
    		X0Y0_右_服CP = new ColorP(X0Y0_右_服, 右_服CD, DisUnit, abj: true);
    		X0Y0_右_柄_柄1CP = new ColorP(X0Y0_右_柄_柄1, 右_柄_柄1CD, DisUnit, abj: true);
    		X0Y0_右_柄_柄2CP = new ColorP(X0Y0_右_柄_柄2, 右_柄_柄2CD, DisUnit, abj: true);
    		X0Y0_右_バストCP = new ColorP(X0Y0_右_バスト, 右_バストCD, DisUnit, abj: true);
    		X0Y0_右_縁CP = new ColorP(X0Y0_右_縁, 右_縁CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override bool Is革(ShapePart p)
    	{
    		if (p != X0Y0_服基 && p != X0Y0_紐_紐1_紐下_紐 && p != X0Y0_紐_紐1_紐上_紐 && p != X0Y0_紐_紐2_紐下_紐 && p != X0Y0_紐_紐2_紐上_紐 && p != X0Y0_紐_紐3_紐下_紐 && p != X0Y0_紐_紐3_紐上_紐 && p != X0Y0_紐_紐4_紐下_紐 && p != X0Y0_紐_紐4_紐上_紐 && p != X0Y0_紐_紐5_紐下_紐 && p != X0Y0_紐_紐5_紐上_紐 && p != X0Y0_紐_紐6_紐下_紐 && p != X0Y0_紐_紐6_紐上_紐 && p != X0Y0_左_服 && p != X0Y0_左_柄_柄1 && p != X0Y0_左_柄_柄2 && p != X0Y0_左_バスト && p != X0Y0_左_縁 && p != X0Y0_右_服 && p != X0Y0_右_柄_柄1 && p != X0Y0_右_柄_柄2 && p != X0Y0_右_バスト)
    		{
    			return p == X0Y0_右_縁;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_服基CP.Update();
    		X0Y0_紐_紐1_紐下_紐CP.Update();
    		X0Y0_紐_紐1_紐上_紐CP.Update();
    		X0Y0_紐_紐2_紐下_紐CP.Update();
    		X0Y0_紐_紐2_紐上_紐CP.Update();
    		X0Y0_紐_紐3_紐下_紐CP.Update();
    		X0Y0_紐_紐3_紐上_紐CP.Update();
    		X0Y0_紐_紐4_紐下_紐CP.Update();
    		X0Y0_紐_紐4_紐上_紐CP.Update();
    		X0Y0_紐_紐5_紐下_紐CP.Update();
    		X0Y0_紐_紐5_紐上_紐CP.Update();
    		X0Y0_紐_紐6_紐下_紐CP.Update();
    		X0Y0_紐_紐6_紐上_紐CP.Update();
    		X0Y0_左_服CP.Update();
    		X0Y0_左_バストCP.Update();
    		X0Y0_右_服CP.Update();
    		X0Y0_右_バストCP.Update();
    		X0Y0_左_柄_柄1CP.Update();
    		X0Y0_左_柄_柄2CP.Update();
    		X0Y0_右_柄_柄1CP.Update();
    		X0Y0_右_柄_柄2CP.Update();
    		X0Y0_左_縁CP.Update();
    		X0Y0_右_縁CP.Update();
    	}

    	public void 色更新(Vector2D[] ドレス, Vector2D[] 縁左, Vector2D[] 縁右)
    	{
    		X0Y0_服基CP.Update();
    		X0Y0_紐_紐1_紐下_紐CP.Update();
    		X0Y0_紐_紐1_紐上_紐CP.Update();
    		X0Y0_紐_紐2_紐下_紐CP.Update();
    		X0Y0_紐_紐2_紐上_紐CP.Update();
    		X0Y0_紐_紐3_紐下_紐CP.Update();
    		X0Y0_紐_紐3_紐上_紐CP.Update();
    		X0Y0_紐_紐4_紐下_紐CP.Update();
    		X0Y0_紐_紐4_紐上_紐CP.Update();
    		X0Y0_紐_紐5_紐下_紐CP.Update();
    		X0Y0_紐_紐5_紐上_紐CP.Update();
    		X0Y0_紐_紐6_紐下_紐CP.Update();
    		X0Y0_紐_紐6_紐上_紐CP.Update();
    		X0Y0_左_服CP.Update(ドレス);
    		X0Y0_左_バストCP.Update(ドレス);
    		X0Y0_右_服CP.Update(ドレス);
    		X0Y0_右_バストCP.Update(ドレス);
    		X0Y0_左_柄_柄1CP.Update();
    		X0Y0_左_柄_柄2CP.Update();
    		X0Y0_右_柄_柄1CP.Update();
    		X0Y0_右_柄_柄2CP.Update();
    		X0Y0_左_縁CP.Update(縁左);
    		X0Y0_右_縁CP.Update(縁右);
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		服基CD = new ColorD(ref Col.Empty, ref Color2.Empty);
    		紐_紐1_紐下_紐CD = new ColorD();
    		紐_紐1_紐上_紐CD = new ColorD();
    		紐_紐2_紐下_紐CD = new ColorD();
    		紐_紐2_紐上_紐CD = new ColorD();
    		紐_紐3_紐下_紐CD = new ColorD();
    		紐_紐3_紐上_紐CD = new ColorD();
    		紐_紐4_紐下_紐CD = new ColorD();
    		紐_紐4_紐上_紐CD = new ColorD();
    		紐_紐5_紐下_紐CD = new ColorD();
    		紐_紐5_紐上_紐CD = new ColorD();
    		紐_紐6_紐下_紐CD = new ColorD();
    		紐_紐6_紐上_紐CD = new ColorD();
    		左_服CD = new ColorD();
    		左_柄_柄1CD = new ColorD();
    		左_柄_柄2CD = new ColorD();
    		左_バストCD = new ColorD();
    		左_縁CD = new ColorD();
    		右_服CD = new ColorD();
    		右_柄_柄1CD = new ColorD();
    		右_柄_柄2CD = new ColorD();
    		右_バストCD = new ColorD();
    		右_縁CD = new ColorD();
    	}

    	public void 配色(ドレス色 配色)
    	{
    		紐_紐1_紐下_紐CD.色 = 配色.紐色;
    		紐_紐1_紐上_紐CD.色 = 紐_紐1_紐下_紐CD.色;
    		紐_紐2_紐下_紐CD.色 = 紐_紐1_紐下_紐CD.色;
    		紐_紐2_紐上_紐CD.色 = 紐_紐1_紐下_紐CD.色;
    		紐_紐3_紐下_紐CD.色 = 紐_紐1_紐下_紐CD.色;
    		紐_紐3_紐上_紐CD.色 = 紐_紐1_紐下_紐CD.色;
    		紐_紐4_紐下_紐CD.色 = 紐_紐1_紐下_紐CD.色;
    		紐_紐4_紐上_紐CD.色 = 紐_紐1_紐下_紐CD.色;
    		紐_紐5_紐下_紐CD.色 = 紐_紐1_紐下_紐CD.色;
    		紐_紐5_紐上_紐CD.色 = 紐_紐1_紐下_紐CD.色;
    		紐_紐6_紐下_紐CD.色 = 紐_紐1_紐下_紐CD.色;
    		紐_紐6_紐上_紐CD.色 = 紐_紐1_紐下_紐CD.色;
    		左_服CD.色 = 配色.生地色;
    		左_柄_柄1CD.色 = 配色.柄色;
    		左_柄_柄2CD.色 = 左_柄_柄1CD.色;
    		左_バストCD.色 = 左_服CD.色;
    		左_縁CD.色 = 配色.縁色;
    		右_服CD.色 = 左_服CD.色;
    		右_柄_柄1CD.色 = 左_柄_柄1CD.色;
    		右_柄_柄2CD.色 = 左_柄_柄1CD.色;
    		右_バストCD.色 = 左_服CD.色;
    		右_縁CD.色 = 左_縁CD.色;
    	}
    }
}
