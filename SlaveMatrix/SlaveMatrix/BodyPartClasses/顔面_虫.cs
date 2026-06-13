using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 顔面_虫 : 顔面
    {
    	public ShapePart X0Y0_面基;

    	public ShapePart X0Y0_複眼左_複眼1;

    	public ShapePart X0Y0_複眼左_複眼2;

    	public ShapePart X0Y0_複眼左_ハイライト;

    	public ShapePart X0Y0_複眼右_複眼1;

    	public ShapePart X0Y0_複眼右_複眼2;

    	public ShapePart X0Y0_複眼右_ハイライト;

    	public ShapePart X0Y0_面下_面;

    	public ShapePart X0Y0_面下_器官左上;

    	public ShapePart X0Y0_面下_器官左下;

    	public ShapePart X0Y0_面下_器官右上;

    	public ShapePart X0Y0_面下_器官右下;

    	public ShapePart X0Y0_面上;

    	public ShapePart X0Y0_付根左_付根1;

    	public ShapePart X0Y0_付根左_付根2;

    	public ShapePart X0Y0_付根右_付根1;

    	public ShapePart X0Y0_付根右_付根2;

    	public ShapePart X0Y0_単眼_眼中_基;

    	public ShapePart X0Y0_単眼_眼中_眼;

    	public ShapePart X0Y0_単眼_眼中_ハイライト;

    	public ShapePart X0Y0_単眼_眼左_基;

    	public ShapePart X0Y0_単眼_眼左_眼;

    	public ShapePart X0Y0_単眼_眼左_ハイライト;

    	public ShapePart X0Y0_単眼_眼右_基;

    	public ShapePart X0Y0_単眼_眼右_眼;

    	public ShapePart X0Y0_単眼_眼右_ハイライト;

    	public ColorD 面基CD;

    	public ColorD 複眼左_複眼1CD;

    	public ColorD 複眼左_複眼2CD;

    	public ColorD 複眼左_ハイライトCD;

    	public ColorD 複眼右_複眼1CD;

    	public ColorD 複眼右_複眼2CD;

    	public ColorD 複眼右_ハイライトCD;

    	public ColorD 面下_面CD;

    	public ColorD 面下_器官左上CD;

    	public ColorD 面下_器官左下CD;

    	public ColorD 面下_器官右上CD;

    	public ColorD 面下_器官右下CD;

    	public ColorD 面上CD;

    	public ColorD 付根左_付根1CD;

    	public ColorD 付根左_付根2CD;

    	public ColorD 付根右_付根1CD;

    	public ColorD 付根右_付根2CD;

    	public ColorD 単眼_眼中_基CD;

    	public ColorD 単眼_眼中_眼CD;

    	public ColorD 単眼_眼中_ハイライトCD;

    	public ColorD 単眼_眼左_基CD;

    	public ColorD 単眼_眼左_眼CD;

    	public ColorD 単眼_眼左_ハイライトCD;

    	public ColorD 単眼_眼右_基CD;

    	public ColorD 単眼_眼右_眼CD;

    	public ColorD 単眼_眼右_ハイライトCD;

    	public ColorP X0Y0_面基CP;

    	public ColorP X0Y0_複眼左_複眼1CP;

    	public ColorP X0Y0_複眼左_複眼2CP;

    	public ColorP X0Y0_複眼左_ハイライトCP;

    	public ColorP X0Y0_複眼右_複眼1CP;

    	public ColorP X0Y0_複眼右_複眼2CP;

    	public ColorP X0Y0_複眼右_ハイライトCP;

    	public ColorP X0Y0_面下_面CP;

    	public ColorP X0Y0_面下_器官左上CP;

    	public ColorP X0Y0_面下_器官左下CP;

    	public ColorP X0Y0_面下_器官右上CP;

    	public ColorP X0Y0_面下_器官右下CP;

    	public ColorP X0Y0_面上CP;

    	public ColorP X0Y0_付根左_付根1CP;

    	public ColorP X0Y0_付根左_付根2CP;

    	public ColorP X0Y0_付根右_付根1CP;

    	public ColorP X0Y0_付根右_付根2CP;

    	public ColorP X0Y0_単眼_眼中_基CP;

    	public ColorP X0Y0_単眼_眼中_眼CP;

    	public ColorP X0Y0_単眼_眼中_ハイライトCP;

    	public ColorP X0Y0_単眼_眼左_基CP;

    	public ColorP X0Y0_単眼_眼左_眼CP;

    	public ColorP X0Y0_単眼_眼左_ハイライトCP;

    	public ColorP X0Y0_単眼_眼右_基CP;

    	public ColorP X0Y0_単眼_眼右_眼CP;

    	public ColorP X0Y0_単眼_眼右_ハイライトCP;

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

    	public bool 面基_表示
    	{
    		get
    		{
    			return X0Y0_面基.Dra;
    		}
    		set
    		{
    			X0Y0_面基.Dra = value;
    			X0Y0_面基.Hit = value;
    		}
    	}

    	public bool 複眼左_複眼1_表示
    	{
    		get
    		{
    			return X0Y0_複眼左_複眼1.Dra;
    		}
    		set
    		{
    			X0Y0_複眼左_複眼1.Dra = value;
    			X0Y0_複眼左_複眼1.Hit = value;
    		}
    	}

    	public bool 複眼左_複眼2_表示
    	{
    		get
    		{
    			return X0Y0_複眼左_複眼2.Dra;
    		}
    		set
    		{
    			X0Y0_複眼左_複眼2.Dra = value;
    			X0Y0_複眼左_複眼2.Hit = value;
    		}
    	}

    	public bool 複眼左_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_複眼左_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_複眼左_ハイライト.Dra = value;
    			X0Y0_複眼左_ハイライト.Hit = value;
    		}
    	}

    	public bool 複眼右_複眼1_表示
    	{
    		get
    		{
    			return X0Y0_複眼右_複眼1.Dra;
    		}
    		set
    		{
    			X0Y0_複眼右_複眼1.Dra = value;
    			X0Y0_複眼右_複眼1.Hit = value;
    		}
    	}

    	public bool 複眼右_複眼2_表示
    	{
    		get
    		{
    			return X0Y0_複眼右_複眼2.Dra;
    		}
    		set
    		{
    			X0Y0_複眼右_複眼2.Dra = value;
    			X0Y0_複眼右_複眼2.Hit = value;
    		}
    	}

    	public bool 複眼右_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_複眼右_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_複眼右_ハイライト.Dra = value;
    			X0Y0_複眼右_ハイライト.Hit = value;
    		}
    	}

    	public bool 面下_面_表示
    	{
    		get
    		{
    			return X0Y0_面下_面.Dra;
    		}
    		set
    		{
    			X0Y0_面下_面.Dra = value;
    			X0Y0_面下_面.Hit = value;
    		}
    	}

    	public bool 面下_器官左上_表示
    	{
    		get
    		{
    			return X0Y0_面下_器官左上.Dra;
    		}
    		set
    		{
    			X0Y0_面下_器官左上.Dra = value;
    			X0Y0_面下_器官左上.Hit = value;
    		}
    	}

    	public bool 面下_器官左下_表示
    	{
    		get
    		{
    			return X0Y0_面下_器官左下.Dra;
    		}
    		set
    		{
    			X0Y0_面下_器官左下.Dra = value;
    			X0Y0_面下_器官左下.Hit = value;
    		}
    	}

    	public bool 面下_器官右上_表示
    	{
    		get
    		{
    			return X0Y0_面下_器官右上.Dra;
    		}
    		set
    		{
    			X0Y0_面下_器官右上.Dra = value;
    			X0Y0_面下_器官右上.Hit = value;
    		}
    	}

    	public bool 面下_器官右下_表示
    	{
    		get
    		{
    			return X0Y0_面下_器官右下.Dra;
    		}
    		set
    		{
    			X0Y0_面下_器官右下.Dra = value;
    			X0Y0_面下_器官右下.Hit = value;
    		}
    	}

    	public bool 面上_表示
    	{
    		get
    		{
    			return X0Y0_面上.Dra;
    		}
    		set
    		{
    			X0Y0_面上.Dra = value;
    			X0Y0_面上.Hit = value;
    		}
    	}

    	public bool 付根左_付根1_表示
    	{
    		get
    		{
    			return X0Y0_付根左_付根1.Dra;
    		}
    		set
    		{
    			X0Y0_付根左_付根1.Dra = value;
    			X0Y0_付根左_付根1.Hit = value;
    		}
    	}

    	public bool 付根左_付根2_表示
    	{
    		get
    		{
    			return X0Y0_付根左_付根2.Dra;
    		}
    		set
    		{
    			X0Y0_付根左_付根2.Dra = value;
    			X0Y0_付根左_付根2.Hit = value;
    		}
    	}

    	public bool 付根右_付根1_表示
    	{
    		get
    		{
    			return X0Y0_付根右_付根1.Dra;
    		}
    		set
    		{
    			X0Y0_付根右_付根1.Dra = value;
    			X0Y0_付根右_付根1.Hit = value;
    		}
    	}

    	public bool 付根右_付根2_表示
    	{
    		get
    		{
    			return X0Y0_付根右_付根2.Dra;
    		}
    		set
    		{
    			X0Y0_付根右_付根2.Dra = value;
    			X0Y0_付根右_付根2.Hit = value;
    		}
    	}

    	public bool 単眼_眼中_基_表示
    	{
    		get
    		{
    			return X0Y0_単眼_眼中_基.Dra;
    		}
    		set
    		{
    			X0Y0_単眼_眼中_基.Dra = value;
    			X0Y0_単眼_眼中_基.Hit = value;
    		}
    	}

    	public bool 単眼_眼中_眼_表示
    	{
    		get
    		{
    			return X0Y0_単眼_眼中_眼.Dra;
    		}
    		set
    		{
    			X0Y0_単眼_眼中_眼.Dra = value;
    			X0Y0_単眼_眼中_眼.Hit = value;
    		}
    	}

    	public bool 単眼_眼中_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_単眼_眼中_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_単眼_眼中_ハイライト.Dra = value;
    			X0Y0_単眼_眼中_ハイライト.Hit = value;
    		}
    	}

    	public bool 単眼_眼左_基_表示
    	{
    		get
    		{
    			return X0Y0_単眼_眼左_基.Dra;
    		}
    		set
    		{
    			X0Y0_単眼_眼左_基.Dra = value;
    			X0Y0_単眼_眼左_基.Hit = value;
    		}
    	}

    	public bool 単眼_眼左_眼_表示
    	{
    		get
    		{
    			return X0Y0_単眼_眼左_眼.Dra;
    		}
    		set
    		{
    			X0Y0_単眼_眼左_眼.Dra = value;
    			X0Y0_単眼_眼左_眼.Hit = value;
    		}
    	}

    	public bool 単眼_眼左_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_単眼_眼左_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_単眼_眼左_ハイライト.Dra = value;
    			X0Y0_単眼_眼左_ハイライト.Hit = value;
    		}
    	}

    	public bool 単眼_眼右_基_表示
    	{
    		get
    		{
    			return X0Y0_単眼_眼右_基.Dra;
    		}
    		set
    		{
    			X0Y0_単眼_眼右_基.Dra = value;
    			X0Y0_単眼_眼右_基.Hit = value;
    		}
    	}

    	public bool 単眼_眼右_眼_表示
    	{
    		get
    		{
    			return X0Y0_単眼_眼右_眼.Dra;
    		}
    		set
    		{
    			X0Y0_単眼_眼右_眼.Dra = value;
    			X0Y0_単眼_眼右_眼.Hit = value;
    		}
    	}

    	public bool 単眼_眼右_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_単眼_眼右_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_単眼_眼右_ハイライト.Dra = value;
    			X0Y0_単眼_眼右_ハイライト.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 面基_表示;
    		}
    		set
    		{
    			面基_表示 = value;
    			複眼左_複眼1_表示 = value;
    			複眼左_複眼2_表示 = value;
    			複眼左_ハイライト_表示 = value;
    			複眼右_複眼1_表示 = value;
    			複眼右_複眼2_表示 = value;
    			複眼右_ハイライト_表示 = value;
    			面下_面_表示 = value;
    			面下_器官左上_表示 = value;
    			面下_器官左下_表示 = value;
    			面下_器官右上_表示 = value;
    			面下_器官右下_表示 = value;
    			面上_表示 = value;
    			付根左_付根1_表示 = value;
    			付根左_付根2_表示 = value;
    			付根右_付根1_表示 = value;
    			付根右_付根2_表示 = value;
    			単眼_眼中_基_表示 = value;
    			単眼_眼中_眼_表示 = value;
    			単眼_眼中_ハイライト_表示 = value;
    			単眼_眼左_基_表示 = value;
    			単眼_眼左_眼_表示 = value;
    			単眼_眼左_ハイライト_表示 = value;
    			単眼_眼右_基_表示 = value;
    			単眼_眼右_眼_表示 = value;
    			単眼_眼右_ハイライト_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 面基CD.不透明度;
    		}
    		set
    		{
    			面基CD.不透明度 = value;
    			複眼左_複眼1CD.不透明度 = value;
    			複眼左_複眼2CD.不透明度 = value;
    			複眼左_ハイライトCD.不透明度 = value;
    			複眼右_複眼1CD.不透明度 = value;
    			複眼右_複眼2CD.不透明度 = value;
    			複眼右_ハイライトCD.不透明度 = value;
    			面下_面CD.不透明度 = value;
    			面下_器官左上CD.不透明度 = value;
    			面下_器官左下CD.不透明度 = value;
    			面下_器官右上CD.不透明度 = value;
    			面下_器官右下CD.不透明度 = value;
    			面上CD.不透明度 = value;
    			付根左_付根1CD.不透明度 = value;
    			付根左_付根2CD.不透明度 = value;
    			付根右_付根1CD.不透明度 = value;
    			付根右_付根2CD.不透明度 = value;
    			単眼_眼中_基CD.不透明度 = value;
    			単眼_眼中_眼CD.不透明度 = value;
    			単眼_眼中_ハイライトCD.不透明度 = value;
    			単眼_眼左_基CD.不透明度 = value;
    			単眼_眼左_眼CD.不透明度 = value;
    			単眼_眼左_ハイライトCD.不透明度 = value;
    			単眼_眼右_基CD.不透明度 = value;
    			単眼_眼右_眼CD.不透明度 = value;
    			単眼_眼右_ハイライトCD.不透明度 = value;
    		}
    	}

    	public override double 展開1
    	{
    		set
    		{
    			double num = 15.0 * value;
    			X0Y0_複眼左_複眼1.AngleCont = num;
    			X0Y0_複眼左_複眼2.AngleCont = num;
    			X0Y0_複眼左_ハイライト.AngleCont = num;
    			X0Y0_複眼左_複眼1.PositionCont = new Vector2D(0.0, -0.0045 * value);
    			X0Y0_複眼左_複眼2.PositionCont = X0Y0_複眼左_複眼1.PositionCont;
    			X0Y0_複眼左_ハイライト.PositionCont = X0Y0_複眼左_複眼1.PositionCont;
    			num = 0.0 - num;
    			X0Y0_複眼右_複眼1.AngleCont = num;
    			X0Y0_複眼右_複眼2.AngleCont = num;
    			X0Y0_複眼右_ハイライト.AngleCont = num;
    			X0Y0_複眼右_複眼1.PositionCont = X0Y0_複眼左_複眼1.PositionCont;
    			X0Y0_複眼右_複眼2.PositionCont = X0Y0_複眼左_複眼1.PositionCont;
    			X0Y0_複眼右_ハイライト.PositionCont = X0Y0_複眼左_複眼1.PositionCont;
    			X0Y0_面下_面.PositionCont = (X0Y0_面下_面.OP[0].ps[0] - X0Y0_面下_面.OP[2].ps[2]) * 0.7 * value;
    		}
    	}

    	public JointS 触覚左_接続点 => new JointS(Body, X0Y0_付根左_付根2, 0);

    	public JointS 触覚右_接続点 => new JointS(Body, X0Y0_付根右_付根2, 0);

    	public 顔面_虫(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 顔面_虫D e)
    	{
    		顔面_虫 顔面_虫2 = this;
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(Sta.肢中["顔面"][1]);
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_面基 = partGroup["面基"].ToPar();
    		PartGroup pars2 = partGroup["複眼左"].ToPars();
    		X0Y0_複眼左_複眼1 = pars2["複眼1"].ToPar();
    		X0Y0_複眼左_複眼2 = pars2["複眼2"].ToPar();
    		X0Y0_複眼左_ハイライト = pars2["ハイライト"].ToPar();
    		pars2 = partGroup["複眼右"].ToPars();
    		X0Y0_複眼右_複眼1 = pars2["複眼1"].ToPar();
    		X0Y0_複眼右_複眼2 = pars2["複眼2"].ToPar();
    		X0Y0_複眼右_ハイライト = pars2["ハイライト"].ToPar();
    		pars2 = partGroup["面下"].ToPars();
    		X0Y0_面下_面 = pars2["面"].ToPar();
    		X0Y0_面下_器官左上 = pars2["器官左上"].ToPar();
    		X0Y0_面下_器官左下 = pars2["器官左下"].ToPar();
    		X0Y0_面下_器官右上 = pars2["器官右上"].ToPar();
    		X0Y0_面下_器官右下 = pars2["器官右下"].ToPar();
    		X0Y0_面上 = partGroup["面上"].ToPar();
    		pars2 = partGroup["付根左"].ToPars();
    		X0Y0_付根左_付根1 = pars2["付根1"].ToPar();
    		X0Y0_付根左_付根2 = pars2["付根2"].ToPar();
    		pars2 = partGroup["付根右"].ToPars();
    		X0Y0_付根右_付根1 = pars2["付根1"].ToPar();
    		X0Y0_付根右_付根2 = pars2["付根2"].ToPar();
    		pars2 = partGroup["単眼"].ToPars();
    		PartGroup pars3 = pars2["眼中"].ToPars();
    		X0Y0_単眼_眼中_基 = pars3["基"].ToPar();
    		X0Y0_単眼_眼中_眼 = pars3["眼"].ToPar();
    		X0Y0_単眼_眼中_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼左"].ToPars();
    		X0Y0_単眼_眼左_基 = pars3["基"].ToPar();
    		X0Y0_単眼_眼左_眼 = pars3["眼"].ToPar();
    		X0Y0_単眼_眼左_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼右"].ToPars();
    		X0Y0_単眼_眼右_基 = pars3["基"].ToPar();
    		X0Y0_単眼_眼右_眼 = pars3["眼"].ToPar();
    		X0Y0_単眼_眼右_ハイライト = pars3["ハイライト"].ToPar();
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
    		面基_表示 = e.面基_表示;
    		複眼左_複眼1_表示 = e.複眼左_複眼1_表示;
    		複眼左_複眼2_表示 = e.複眼左_複眼2_表示;
    		複眼左_ハイライト_表示 = e.複眼左_ハイライト_表示;
    		複眼右_複眼1_表示 = e.複眼右_複眼1_表示;
    		複眼右_複眼2_表示 = e.複眼右_複眼2_表示;
    		複眼右_ハイライト_表示 = e.複眼右_ハイライト_表示;
    		面下_面_表示 = e.面下_面_表示;
    		面下_器官左上_表示 = e.面下_器官左上_表示;
    		面下_器官左下_表示 = e.面下_器官左下_表示;
    		面下_器官右上_表示 = e.面下_器官右上_表示;
    		面下_器官右下_表示 = e.面下_器官右下_表示;
    		面上_表示 = e.面上_表示;
    		付根左_付根1_表示 = e.付根左_付根1_表示;
    		付根左_付根2_表示 = e.付根左_付根2_表示;
    		付根右_付根1_表示 = e.付根右_付根1_表示;
    		付根右_付根2_表示 = e.付根右_付根2_表示;
    		単眼_眼中_基_表示 = e.単眼_眼中_基_表示;
    		単眼_眼中_眼_表示 = e.単眼_眼中_眼_表示;
    		単眼_眼中_ハイライト_表示 = e.単眼_眼中_ハイライト_表示;
    		単眼_眼左_基_表示 = e.単眼_眼左_基_表示;
    		単眼_眼左_眼_表示 = e.単眼_眼左_眼_表示;
    		単眼_眼左_ハイライト_表示 = e.単眼_眼左_ハイライト_表示;
    		単眼_眼右_基_表示 = e.単眼_眼右_基_表示;
    		単眼_眼右_眼_表示 = e.単眼_眼右_眼_表示;
    		単眼_眼右_ハイライト_表示 = e.単眼_眼右_ハイライト_表示;
    		base.展開0 = e.展開0;
    		展開1 = e.展開1;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Ele f;
    		if (e.触覚左_接続.Count > 0)
    		{
    			触覚左_接続 = e.触覚左_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 顔面_虫2;
    				f.ConnectionType = ConnectionInfo.顔面_虫_触覚左_接続;
    				f.接続(顔面_虫2.触覚左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.触覚右_接続.Count > 0)
    		{
    			触覚右_接続 = e.触覚右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 顔面_虫2;
    				f.ConnectionType = ConnectionInfo.顔面_虫_触覚右_接続;
    				f.接続(顔面_虫2.触覚右_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_面基CP = new ColorP(X0Y0_面基, 面基CD, DisUnit, abj: true);
    		X0Y0_複眼左_複眼1CP = new ColorP(X0Y0_複眼左_複眼1, 複眼左_複眼1CD, DisUnit, abj: true);
    		X0Y0_複眼左_複眼2CP = new ColorP(X0Y0_複眼左_複眼2, 複眼左_複眼2CD, DisUnit, abj: true);
    		X0Y0_複眼左_ハイライトCP = new ColorP(X0Y0_複眼左_ハイライト, 複眼左_ハイライトCD, DisUnit, abj: true);
    		X0Y0_複眼右_複眼1CP = new ColorP(X0Y0_複眼右_複眼1, 複眼右_複眼1CD, DisUnit, abj: true);
    		X0Y0_複眼右_複眼2CP = new ColorP(X0Y0_複眼右_複眼2, 複眼右_複眼2CD, DisUnit, abj: true);
    		X0Y0_複眼右_ハイライトCP = new ColorP(X0Y0_複眼右_ハイライト, 複眼右_ハイライトCD, DisUnit, abj: true);
    		X0Y0_面下_面CP = new ColorP(X0Y0_面下_面, 面下_面CD, DisUnit, abj: true);
    		X0Y0_面下_器官左上CP = new ColorP(X0Y0_面下_器官左上, 面下_器官左上CD, DisUnit, abj: true);
    		X0Y0_面下_器官左下CP = new ColorP(X0Y0_面下_器官左下, 面下_器官左下CD, DisUnit, abj: true);
    		X0Y0_面下_器官右上CP = new ColorP(X0Y0_面下_器官右上, 面下_器官右上CD, DisUnit, abj: true);
    		X0Y0_面下_器官右下CP = new ColorP(X0Y0_面下_器官右下, 面下_器官右下CD, DisUnit, abj: true);
    		X0Y0_面上CP = new ColorP(X0Y0_面上, 面上CD, DisUnit, abj: true);
    		X0Y0_付根左_付根1CP = new ColorP(X0Y0_付根左_付根1, 付根左_付根1CD, DisUnit, abj: true);
    		X0Y0_付根左_付根2CP = new ColorP(X0Y0_付根左_付根2, 付根左_付根2CD, DisUnit, abj: true);
    		X0Y0_付根右_付根1CP = new ColorP(X0Y0_付根右_付根1, 付根右_付根1CD, DisUnit, abj: true);
    		X0Y0_付根右_付根2CP = new ColorP(X0Y0_付根右_付根2, 付根右_付根2CD, DisUnit, abj: true);
    		X0Y0_単眼_眼中_基CP = new ColorP(X0Y0_単眼_眼中_基, 単眼_眼中_基CD, DisUnit, abj: true);
    		X0Y0_単眼_眼中_眼CP = new ColorP(X0Y0_単眼_眼中_眼, 単眼_眼中_眼CD, DisUnit, abj: true);
    		X0Y0_単眼_眼中_ハイライトCP = new ColorP(X0Y0_単眼_眼中_ハイライト, 単眼_眼中_ハイライトCD, DisUnit, abj: true);
    		X0Y0_単眼_眼左_基CP = new ColorP(X0Y0_単眼_眼左_基, 単眼_眼左_基CD, DisUnit, abj: true);
    		X0Y0_単眼_眼左_眼CP = new ColorP(X0Y0_単眼_眼左_眼, 単眼_眼左_眼CD, DisUnit, abj: true);
    		X0Y0_単眼_眼左_ハイライトCP = new ColorP(X0Y0_単眼_眼左_ハイライト, 単眼_眼左_ハイライトCD, DisUnit, abj: true);
    		X0Y0_単眼_眼右_基CP = new ColorP(X0Y0_単眼_眼右_基, 単眼_眼右_基CD, DisUnit, abj: true);
    		X0Y0_単眼_眼右_眼CP = new ColorP(X0Y0_単眼_眼右_眼, 単眼_眼右_眼CD, DisUnit, abj: true);
    		X0Y0_単眼_眼右_ハイライトCP = new ColorP(X0Y0_単眼_眼右_ハイライト, 単眼_眼右_ハイライトCD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_面基CP.Update();
    		X0Y0_複眼左_複眼1CP.Update();
    		X0Y0_複眼左_複眼2CP.Update();
    		X0Y0_複眼左_ハイライトCP.Update();
    		X0Y0_複眼右_複眼1CP.Update();
    		X0Y0_複眼右_複眼2CP.Update();
    		X0Y0_複眼右_ハイライトCP.Update();
    		X0Y0_面下_面CP.Update();
    		X0Y0_面下_器官左上CP.Update();
    		X0Y0_面下_器官左下CP.Update();
    		X0Y0_面下_器官右上CP.Update();
    		X0Y0_面下_器官右下CP.Update();
    		X0Y0_面上CP.Update();
    		X0Y0_付根左_付根1CP.Update();
    		X0Y0_付根左_付根2CP.Update();
    		X0Y0_付根右_付根1CP.Update();
    		X0Y0_付根右_付根2CP.Update();
    		X0Y0_単眼_眼中_基CP.Update();
    		X0Y0_単眼_眼中_眼CP.Update();
    		X0Y0_単眼_眼中_ハイライトCP.Update();
    		X0Y0_単眼_眼左_基CP.Update();
    		X0Y0_単眼_眼左_眼CP.Update();
    		X0Y0_単眼_眼左_ハイライトCP.Update();
    		X0Y0_単眼_眼右_基CP.Update();
    		X0Y0_単眼_眼右_眼CP.Update();
    		X0Y0_単眼_眼右_ハイライトCP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		面基CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		複眼左_複眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		複眼左_複眼2CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		複眼左_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		複眼右_複眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		複眼右_複眼2CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		複眼右_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		面下_面CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		面下_器官左上CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		面下_器官左下CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		面下_器官右上CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		面下_器官右下CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		面上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		付根左_付根1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		付根左_付根2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		付根右_付根1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		付根右_付根2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		単眼_眼中_基CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
    		単眼_眼中_眼CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
    		単眼_眼中_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		単眼_眼左_基CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
    		単眼_眼左_眼CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
    		単眼_眼左_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		単眼_眼右_基CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
    		単眼_眼右_眼CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
    		単眼_眼右_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    	}
    }
}
