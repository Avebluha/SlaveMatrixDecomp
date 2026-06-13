using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 上着ボトム_クロス : 上着ボトム
    {
    	public ShapePart X0Y0_中_下地;

    	public ShapePart X0Y0_中_皺1;

    	public ShapePart X0Y0_中_皺2;

    	public ShapePart X0Y0_左_下地;

    	public ShapePart X0Y0_左_皺1;

    	public ShapePart X0Y0_左_皺2;

    	public ShapePart X0Y0_左_皺3;

    	public ShapePart X0Y0_左_皺4;

    	public ShapePart X0Y0_左_皺5;

    	public ShapePart X0Y0_左_皺6;

    	public ShapePart X0Y0_右_下地;

    	public ShapePart X0Y0_右_皺1;

    	public ShapePart X0Y0_右_皺2;

    	public ShapePart X0Y0_右_皺3;

    	public ShapePart X0Y0_右_皺4;

    	public ShapePart X0Y0_右_皺5;

    	public ShapePart X0Y0_右_皺6;

    	public ShapePart X0Y1_中_下地;

    	public ShapePart X0Y1_中_皺1;

    	public ShapePart X0Y1_中_皺2;

    	public ShapePart X0Y1_左_下地;

    	public ShapePart X0Y1_左_皺1;

    	public ShapePart X0Y1_左_皺2;

    	public ShapePart X0Y1_左_皺3;

    	public ShapePart X0Y1_左_皺4;

    	public ShapePart X0Y1_左_皺5;

    	public ShapePart X0Y1_左_皺6;

    	public ShapePart X0Y1_右_下地;

    	public ShapePart X0Y1_右_皺1;

    	public ShapePart X0Y1_右_皺2;

    	public ShapePart X0Y1_右_皺3;

    	public ShapePart X0Y1_右_皺4;

    	public ShapePart X0Y1_右_皺5;

    	public ShapePart X0Y1_右_皺6;

    	public ColorD 中_下地CD;

    	public ColorD 中_皺1CD;

    	public ColorD 中_皺2CD;

    	public ColorD 左_下地CD;

    	public ColorD 左_皺1CD;

    	public ColorD 左_皺2CD;

    	public ColorD 左_皺3CD;

    	public ColorD 左_皺4CD;

    	public ColorD 左_皺5CD;

    	public ColorD 左_皺6CD;

    	public ColorD 右_下地CD;

    	public ColorD 右_皺1CD;

    	public ColorD 右_皺2CD;

    	public ColorD 右_皺3CD;

    	public ColorD 右_皺4CD;

    	public ColorD 右_皺5CD;

    	public ColorD 右_皺6CD;

    	public ColorP X0Y0_中_下地CP;

    	public ColorP X0Y0_中_皺1CP;

    	public ColorP X0Y0_中_皺2CP;

    	public ColorP X0Y0_左_下地CP;

    	public ColorP X0Y0_左_皺1CP;

    	public ColorP X0Y0_左_皺2CP;

    	public ColorP X0Y0_左_皺3CP;

    	public ColorP X0Y0_左_皺4CP;

    	public ColorP X0Y0_左_皺5CP;

    	public ColorP X0Y0_左_皺6CP;

    	public ColorP X0Y0_右_下地CP;

    	public ColorP X0Y0_右_皺1CP;

    	public ColorP X0Y0_右_皺2CP;

    	public ColorP X0Y0_右_皺3CP;

    	public ColorP X0Y0_右_皺4CP;

    	public ColorP X0Y0_右_皺5CP;

    	public ColorP X0Y0_右_皺6CP;

    	public ColorP X0Y1_中_下地CP;

    	public ColorP X0Y1_中_皺1CP;

    	public ColorP X0Y1_中_皺2CP;

    	public ColorP X0Y1_左_下地CP;

    	public ColorP X0Y1_左_皺1CP;

    	public ColorP X0Y1_左_皺2CP;

    	public ColorP X0Y1_左_皺3CP;

    	public ColorP X0Y1_左_皺4CP;

    	public ColorP X0Y1_左_皺5CP;

    	public ColorP X0Y1_左_皺6CP;

    	public ColorP X0Y1_右_下地CP;

    	public ColorP X0Y1_右_皺1CP;

    	public ColorP X0Y1_右_皺2CP;

    	public ColorP X0Y1_右_皺3CP;

    	public ColorP X0Y1_右_皺4CP;

    	public ColorP X0Y1_右_皺5CP;

    	public ColorP X0Y1_右_皺6CP;

    	public Element[] 上着ボトム後_接続;

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

    	public bool 中_下地_表示
    	{
    		get
    		{
    			return X0Y0_中_下地.Dra;
    		}
    		set
    		{
    			X0Y0_中_下地.Dra = value;
    			X0Y1_中_下地.Dra = value;
    			X0Y0_中_下地.Hit = false;
    			X0Y1_中_下地.Hit = false;
    		}
    	}

    	public bool 中_皺1_表示
    	{
    		get
    		{
    			return X0Y0_中_皺1.Dra;
    		}
    		set
    		{
    			X0Y0_中_皺1.Dra = value;
    			X0Y1_中_皺1.Dra = value;
    			X0Y0_中_皺1.Hit = false;
    			X0Y1_中_皺1.Hit = false;
    		}
    	}

    	public bool 中_皺2_表示
    	{
    		get
    		{
    			return X0Y0_中_皺2.Dra;
    		}
    		set
    		{
    			X0Y0_中_皺2.Dra = value;
    			X0Y1_中_皺2.Dra = value;
    			X0Y0_中_皺2.Hit = false;
    			X0Y1_中_皺2.Hit = false;
    		}
    	}

    	public bool 左_下地_表示
    	{
    		get
    		{
    			return X0Y0_左_下地.Dra;
    		}
    		set
    		{
    			X0Y0_左_下地.Dra = value;
    			X0Y1_左_下地.Dra = value;
    			X0Y0_左_下地.Hit = false;
    			X0Y1_左_下地.Hit = false;
    		}
    	}

    	public bool 左_皺1_表示
    	{
    		get
    		{
    			return X0Y0_左_皺1.Dra;
    		}
    		set
    		{
    			X0Y0_左_皺1.Dra = value;
    			X0Y1_左_皺1.Dra = value;
    			X0Y0_左_皺1.Hit = false;
    			X0Y1_左_皺1.Hit = false;
    		}
    	}

    	public bool 左_皺2_表示
    	{
    		get
    		{
    			return X0Y0_左_皺2.Dra;
    		}
    		set
    		{
    			X0Y0_左_皺2.Dra = value;
    			X0Y1_左_皺2.Dra = value;
    			X0Y0_左_皺2.Hit = false;
    			X0Y1_左_皺2.Hit = false;
    		}
    	}

    	public bool 左_皺3_表示
    	{
    		get
    		{
    			return X0Y0_左_皺3.Dra;
    		}
    		set
    		{
    			X0Y0_左_皺3.Dra = value;
    			X0Y1_左_皺3.Dra = value;
    			X0Y0_左_皺3.Hit = false;
    			X0Y1_左_皺3.Hit = false;
    		}
    	}

    	public bool 左_皺4_表示
    	{
    		get
    		{
    			return X0Y0_左_皺4.Dra;
    		}
    		set
    		{
    			X0Y0_左_皺4.Dra = value;
    			X0Y1_左_皺4.Dra = value;
    			X0Y0_左_皺4.Hit = false;
    			X0Y1_左_皺4.Hit = false;
    		}
    	}

    	public bool 左_皺5_表示
    	{
    		get
    		{
    			return X0Y0_左_皺5.Dra;
    		}
    		set
    		{
    			X0Y0_左_皺5.Dra = value;
    			X0Y1_左_皺5.Dra = value;
    			X0Y0_左_皺5.Hit = false;
    			X0Y1_左_皺5.Hit = false;
    		}
    	}

    	public bool 左_皺6_表示
    	{
    		get
    		{
    			return X0Y0_左_皺6.Dra;
    		}
    		set
    		{
    			X0Y0_左_皺6.Dra = value;
    			X0Y1_左_皺6.Dra = value;
    			X0Y0_左_皺6.Hit = false;
    			X0Y1_左_皺6.Hit = false;
    		}
    	}

    	public bool 右_下地_表示
    	{
    		get
    		{
    			return X0Y0_右_下地.Dra;
    		}
    		set
    		{
    			X0Y0_右_下地.Dra = value;
    			X0Y1_右_下地.Dra = value;
    			X0Y0_右_下地.Hit = false;
    			X0Y1_右_下地.Hit = false;
    		}
    	}

    	public bool 右_皺1_表示
    	{
    		get
    		{
    			return X0Y0_右_皺1.Dra;
    		}
    		set
    		{
    			X0Y0_右_皺1.Dra = value;
    			X0Y1_右_皺1.Dra = value;
    			X0Y0_右_皺1.Hit = false;
    			X0Y1_右_皺1.Hit = false;
    		}
    	}

    	public bool 右_皺2_表示
    	{
    		get
    		{
    			return X0Y0_右_皺2.Dra;
    		}
    		set
    		{
    			X0Y0_右_皺2.Dra = value;
    			X0Y1_右_皺2.Dra = value;
    			X0Y0_右_皺2.Hit = false;
    			X0Y1_右_皺2.Hit = false;
    		}
    	}

    	public bool 右_皺3_表示
    	{
    		get
    		{
    			return X0Y0_右_皺3.Dra;
    		}
    		set
    		{
    			X0Y0_右_皺3.Dra = value;
    			X0Y1_右_皺3.Dra = value;
    			X0Y0_右_皺3.Hit = false;
    			X0Y1_右_皺3.Hit = false;
    		}
    	}

    	public bool 右_皺4_表示
    	{
    		get
    		{
    			return X0Y0_右_皺4.Dra;
    		}
    		set
    		{
    			X0Y0_右_皺4.Dra = value;
    			X0Y1_右_皺4.Dra = value;
    			X0Y0_右_皺4.Hit = false;
    			X0Y1_右_皺4.Hit = false;
    		}
    	}

    	public bool 右_皺5_表示
    	{
    		get
    		{
    			return X0Y0_右_皺5.Dra;
    		}
    		set
    		{
    			X0Y0_右_皺5.Dra = value;
    			X0Y1_右_皺5.Dra = value;
    			X0Y0_右_皺5.Hit = false;
    			X0Y1_右_皺5.Hit = false;
    		}
    	}

    	public bool 右_皺6_表示
    	{
    		get
    		{
    			return X0Y0_右_皺6.Dra;
    		}
    		set
    		{
    			X0Y0_右_皺6.Dra = value;
    			X0Y1_右_皺6.Dra = value;
    			X0Y0_右_皺6.Hit = false;
    			X0Y1_右_皺6.Hit = false;
    		}
    	}

    	public bool ベース表示
    	{
    		get
    		{
    			return 左_下地_表示;
    		}
    		set
    		{
    			左_下地_表示 = value;
    			右_下地_表示 = value;
    			左_皺1_表示 = value;
    			右_皺1_表示 = value;
    		}
    	}

    	public bool ベース皺1表示
    	{
    		get
    		{
    			return 左_皺2_表示;
    		}
    		set
    		{
    			左_皺2_表示 = value;
    			右_皺2_表示 = value;
    		}
    	}

    	public bool ベース皺2表示
    	{
    		get
    		{
    			return 左_皺3_表示;
    		}
    		set
    		{
    			左_皺3_表示 = value;
    			右_皺3_表示 = value;
    		}
    	}

    	public bool ベース皺3表示
    	{
    		get
    		{
    			return 左_皺4_表示;
    		}
    		set
    		{
    			左_皺4_表示 = value;
    			右_皺4_表示 = value;
    		}
    	}

    	public bool ベース皺4表示
    	{
    		get
    		{
    			return 左_皺5_表示;
    		}
    		set
    		{
    			左_皺5_表示 = value;
    			右_皺5_表示 = value;
    		}
    	}

    	public bool ベース皺5表示
    	{
    		get
    		{
    			return 左_皺6_表示;
    		}
    		set
    		{
    			左_皺6_表示 = value;
    			右_皺6_表示 = value;
    		}
    	}

    	public bool 中表示
    	{
    		get
    		{
    			return 中_下地_表示;
    		}
    		set
    		{
    			中_下地_表示 = value;
    		}
    	}

    	public bool 中皺1表示
    	{
    		get
    		{
    			return 中_皺1_表示;
    		}
    		set
    		{
    			中_皺1_表示 = value;
    		}
    	}

    	public bool 中皺2表示
    	{
    		get
    		{
    			return 中_皺2_表示;
    		}
    		set
    		{
    			中_皺2_表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 中_下地_表示;
    		}
    		set
    		{
    			中_下地_表示 = value;
    			中_皺1_表示 = value;
    			中_皺2_表示 = value;
    			左_下地_表示 = value;
    			左_皺1_表示 = value;
    			左_皺2_表示 = value;
    			左_皺3_表示 = value;
    			左_皺4_表示 = value;
    			左_皺5_表示 = value;
    			左_皺6_表示 = value;
    			右_下地_表示 = value;
    			右_皺1_表示 = value;
    			右_皺2_表示 = value;
    			右_皺3_表示 = value;
    			右_皺4_表示 = value;
    			右_皺5_表示 = value;
    			右_皺6_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 中_下地CD.不透明度;
    		}
    		set
    		{
    			中_下地CD.不透明度 = value;
    			中_皺1CD.不透明度 = value;
    			中_皺2CD.不透明度 = value;
    			左_下地CD.不透明度 = value;
    			左_皺1CD.不透明度 = value;
    			左_皺2CD.不透明度 = value;
    			左_皺3CD.不透明度 = value;
    			左_皺4CD.不透明度 = value;
    			左_皺5CD.不透明度 = value;
    			左_皺6CD.不透明度 = value;
    			右_下地CD.不透明度 = value;
    			右_皺1CD.不透明度 = value;
    			右_皺2CD.不透明度 = value;
    			右_皺3CD.不透明度 = value;
    			右_皺4CD.不透明度 = value;
    			右_皺5CD.不透明度 = value;
    			右_皺6CD.不透明度 = value;
    		}
    	}

    	public JointS 上着ボトム後_接続点 => new JointS(Body, X0Y0_中_下地, 4);

    	public 上着ボトム_クロス(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 上着ボトム_クロスD e)
    	{
    		上着ボトム_クロス 上着ボトム_クロス2 = this;
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(GlobalState.胴体["上着ボトム前"][0]);
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		PartGroup pars2 = partGroup["中"].ToPars();
    		X0Y0_中_下地 = pars2["下地"].ToPar();
    		X0Y0_中_皺1 = pars2["皺1"].ToPar();
    		X0Y0_中_皺2 = pars2["皺2"].ToPar();
    		pars2 = partGroup["左"].ToPars();
    		X0Y0_左_下地 = pars2["下地"].ToPar();
    		X0Y0_左_皺1 = pars2["皺1"].ToPar();
    		X0Y0_左_皺2 = pars2["皺2"].ToPar();
    		X0Y0_左_皺3 = pars2["皺3"].ToPar();
    		X0Y0_左_皺4 = pars2["皺4"].ToPar();
    		X0Y0_左_皺5 = pars2["皺5"].ToPar();
    		X0Y0_左_皺6 = pars2["皺6"].ToPar();
    		pars2 = partGroup["右"].ToPars();
    		X0Y0_右_下地 = pars2["下地"].ToPar();
    		X0Y0_右_皺1 = pars2["皺1"].ToPar();
    		X0Y0_右_皺2 = pars2["皺2"].ToPar();
    		X0Y0_右_皺3 = pars2["皺3"].ToPar();
    		X0Y0_右_皺4 = pars2["皺4"].ToPar();
    		X0Y0_右_皺5 = pars2["皺5"].ToPar();
    		X0Y0_右_皺6 = pars2["皺6"].ToPar();
    		PartGroup pars3 = Body[0][1];
    		pars2 = pars3["中"].ToPars();
    		X0Y1_中_下地 = pars2["下地"].ToPar();
    		X0Y1_中_皺1 = pars2["皺1"].ToPar();
    		X0Y1_中_皺2 = pars2["皺2"].ToPar();
    		pars2 = pars3["左"].ToPars();
    		X0Y1_左_下地 = pars2["下地"].ToPar();
    		X0Y1_左_皺1 = pars2["皺1"].ToPar();
    		X0Y1_左_皺2 = pars2["皺2"].ToPar();
    		X0Y1_左_皺3 = pars2["皺3"].ToPar();
    		X0Y1_左_皺4 = pars2["皺4"].ToPar();
    		X0Y1_左_皺5 = pars2["皺5"].ToPar();
    		X0Y1_左_皺6 = pars2["皺6"].ToPar();
    		pars2 = pars3["右"].ToPars();
    		X0Y1_右_下地 = pars2["下地"].ToPar();
    		X0Y1_右_皺1 = pars2["皺1"].ToPar();
    		X0Y1_右_皺2 = pars2["皺2"].ToPar();
    		X0Y1_右_皺3 = pars2["皺3"].ToPar();
    		X0Y1_右_皺4 = pars2["皺4"].ToPar();
    		X0Y1_右_皺5 = pars2["皺5"].ToPar();
    		X0Y1_右_皺6 = pars2["皺6"].ToPar();
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
    		中_下地_表示 = e.中_下地_表示;
    		中_皺1_表示 = e.中_皺1_表示;
    		中_皺2_表示 = e.中_皺2_表示;
    		左_下地_表示 = e.左_下地_表示;
    		左_皺1_表示 = e.左_皺1_表示;
    		左_皺2_表示 = e.左_皺2_表示;
    		左_皺3_表示 = e.左_皺3_表示;
    		左_皺4_表示 = e.左_皺4_表示;
    		左_皺5_表示 = e.左_皺5_表示;
    		左_皺6_表示 = e.左_皺6_表示;
    		右_下地_表示 = e.右_下地_表示;
    		右_皺1_表示 = e.右_皺1_表示;
    		右_皺2_表示 = e.右_皺2_表示;
    		右_皺3_表示 = e.右_皺3_表示;
    		右_皺4_表示 = e.右_皺4_表示;
    		右_皺5_表示 = e.右_皺5_表示;
    		右_皺6_表示 = e.右_皺6_表示;
    		ベース表示 = e.ベース表示;
    		ベース皺1表示 = e.ベース皺1表示;
    		ベース皺2表示 = e.ベース皺2表示;
    		ベース皺3表示 = e.ベース皺3表示;
    		ベース皺4表示 = e.ベース皺4表示;
    		ベース皺5表示 = e.ベース皺5表示;
    		中表示 = e.中表示;
    		中皺1表示 = e.中皺1表示;
    		中皺2表示 = e.中皺2表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.上着ボトム後_接続.Count > 0)
    		{
    			Element f;
    			上着ボトム後_接続 = e.上着ボトム後_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 上着ボトム_クロス2;
    				f.ConnectionType = ConnectionInfo.上着ボトム_クロス_上着ボトム後_接続;
    				f.接続(上着ボトム_クロス2.上着ボトム後_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_中_下地CP = new ColorP(X0Y0_中_下地, 中_下地CD, DisUnit, abj: true);
    		X0Y0_中_皺1CP = new ColorP(X0Y0_中_皺1, 中_皺1CD, DisUnit, abj: true);
    		X0Y0_中_皺2CP = new ColorP(X0Y0_中_皺2, 中_皺2CD, DisUnit, abj: true);
    		X0Y0_左_下地CP = new ColorP(X0Y0_左_下地, 左_下地CD, DisUnit, abj: true);
    		X0Y0_左_皺1CP = new ColorP(X0Y0_左_皺1, 左_皺1CD, DisUnit, abj: true);
    		X0Y0_左_皺2CP = new ColorP(X0Y0_左_皺2, 左_皺2CD, DisUnit, abj: true);
    		X0Y0_左_皺3CP = new ColorP(X0Y0_左_皺3, 左_皺3CD, DisUnit, abj: true);
    		X0Y0_左_皺4CP = new ColorP(X0Y0_左_皺4, 左_皺4CD, DisUnit, abj: true);
    		X0Y0_左_皺5CP = new ColorP(X0Y0_左_皺5, 左_皺5CD, DisUnit, abj: true);
    		X0Y0_左_皺6CP = new ColorP(X0Y0_左_皺6, 左_皺6CD, DisUnit, abj: true);
    		X0Y0_右_下地CP = new ColorP(X0Y0_右_下地, 右_下地CD, DisUnit, abj: true);
    		X0Y0_右_皺1CP = new ColorP(X0Y0_右_皺1, 右_皺1CD, DisUnit, abj: true);
    		X0Y0_右_皺2CP = new ColorP(X0Y0_右_皺2, 右_皺2CD, DisUnit, abj: true);
    		X0Y0_右_皺3CP = new ColorP(X0Y0_右_皺3, 右_皺3CD, DisUnit, abj: true);
    		X0Y0_右_皺4CP = new ColorP(X0Y0_右_皺4, 右_皺4CD, DisUnit, abj: true);
    		X0Y0_右_皺5CP = new ColorP(X0Y0_右_皺5, 右_皺5CD, DisUnit, abj: true);
    		X0Y0_右_皺6CP = new ColorP(X0Y0_右_皺6, 右_皺6CD, DisUnit, abj: true);
    		X0Y1_中_下地CP = new ColorP(X0Y1_中_下地, 中_下地CD, DisUnit, abj: true);
    		X0Y1_中_皺1CP = new ColorP(X0Y1_中_皺1, 中_皺1CD, DisUnit, abj: true);
    		X0Y1_中_皺2CP = new ColorP(X0Y1_中_皺2, 中_皺2CD, DisUnit, abj: true);
    		X0Y1_左_下地CP = new ColorP(X0Y1_左_下地, 左_下地CD, DisUnit, abj: true);
    		X0Y1_左_皺1CP = new ColorP(X0Y1_左_皺1, 左_皺1CD, DisUnit, abj: true);
    		X0Y1_左_皺2CP = new ColorP(X0Y1_左_皺2, 左_皺2CD, DisUnit, abj: true);
    		X0Y1_左_皺3CP = new ColorP(X0Y1_左_皺3, 左_皺3CD, DisUnit, abj: true);
    		X0Y1_左_皺4CP = new ColorP(X0Y1_左_皺4, 左_皺4CD, DisUnit, abj: true);
    		X0Y1_左_皺5CP = new ColorP(X0Y1_左_皺5, 左_皺5CD, DisUnit, abj: true);
    		X0Y1_左_皺6CP = new ColorP(X0Y1_左_皺6, 左_皺6CD, DisUnit, abj: true);
    		X0Y1_右_下地CP = new ColorP(X0Y1_右_下地, 右_下地CD, DisUnit, abj: true);
    		X0Y1_右_皺1CP = new ColorP(X0Y1_右_皺1, 右_皺1CD, DisUnit, abj: true);
    		X0Y1_右_皺2CP = new ColorP(X0Y1_右_皺2, 右_皺2CD, DisUnit, abj: true);
    		X0Y1_右_皺3CP = new ColorP(X0Y1_右_皺3, 右_皺3CD, DisUnit, abj: true);
    		X0Y1_右_皺4CP = new ColorP(X0Y1_右_皺4, 右_皺4CD, DisUnit, abj: true);
    		X0Y1_右_皺5CP = new ColorP(X0Y1_右_皺5, 右_皺5CD, DisUnit, abj: true);
    		X0Y1_右_皺6CP = new ColorP(X0Y1_右_皺6, 右_皺6CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		尺度XB = 1.01;
    		尺度YB = 0.95;
    	}

    	public override bool Is布(ShapePart p)
    	{
    		if (p != X0Y0_中_下地 && p != X0Y0_中_皺1 && p != X0Y0_中_皺2 && p != X0Y0_左_下地 && p != X0Y0_左_皺1 && p != X0Y0_左_皺2 && p != X0Y0_左_皺3 && p != X0Y0_左_皺4 && p != X0Y0_左_皺5 && p != X0Y0_左_皺6 && p != X0Y0_右_下地 && p != X0Y0_右_皺1 && p != X0Y0_右_皺2 && p != X0Y0_右_皺3 && p != X0Y0_右_皺4 && p != X0Y0_右_皺5 && p != X0Y0_右_皺6 && p != X0Y1_中_下地 && p != X0Y1_中_皺1 && p != X0Y1_中_皺2 && p != X0Y1_左_下地 && p != X0Y1_左_皺1 && p != X0Y1_左_皺2 && p != X0Y1_左_皺3 && p != X0Y1_左_皺4 && p != X0Y1_左_皺5 && p != X0Y1_左_皺6 && p != X0Y1_右_下地 && p != X0Y1_右_皺1 && p != X0Y1_右_皺2 && p != X0Y1_右_皺3 && p != X0Y1_右_皺4 && p != X0Y1_右_皺5)
    		{
    			return p == X0Y1_右_皺6;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexY == 0)
    		{
    			X0Y0_中_下地CP.Update();
    			X0Y0_中_皺1CP.Update();
    			X0Y0_中_皺2CP.Update();
    			X0Y0_左_下地CP.Update();
    			X0Y0_左_皺1CP.Update();
    			X0Y0_左_皺2CP.Update();
    			X0Y0_左_皺3CP.Update();
    			X0Y0_左_皺4CP.Update();
    			X0Y0_左_皺5CP.Update();
    			X0Y0_左_皺6CP.Update();
    			X0Y0_右_下地CP.Update();
    			X0Y0_右_皺1CP.Update();
    			X0Y0_右_皺2CP.Update();
    			X0Y0_右_皺3CP.Update();
    			X0Y0_右_皺4CP.Update();
    			X0Y0_右_皺5CP.Update();
    			X0Y0_右_皺6CP.Update();
    		}
    		else
    		{
    			X0Y1_中_下地CP.Update();
    			X0Y1_中_皺1CP.Update();
    			X0Y1_中_皺2CP.Update();
    			X0Y1_左_下地CP.Update();
    			X0Y1_左_皺1CP.Update();
    			X0Y1_左_皺2CP.Update();
    			X0Y1_左_皺3CP.Update();
    			X0Y1_左_皺4CP.Update();
    			X0Y1_左_皺5CP.Update();
    			X0Y1_左_皺6CP.Update();
    			X0Y1_右_下地CP.Update();
    			X0Y1_右_皺1CP.Update();
    			X0Y1_右_皺2CP.Update();
    			X0Y1_右_皺3CP.Update();
    			X0Y1_右_皺4CP.Update();
    			X0Y1_右_皺5CP.Update();
    			X0Y1_右_皺6CP.Update();
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		中_下地CD = new ColorD();
    		中_皺1CD = new ColorD();
    		中_皺2CD = new ColorD();
    		左_下地CD = new ColorD();
    		左_皺1CD = new ColorD();
    		左_皺2CD = new ColorD();
    		左_皺3CD = new ColorD();
    		左_皺4CD = new ColorD();
    		左_皺5CD = new ColorD();
    		左_皺6CD = new ColorD();
    		右_下地CD = new ColorD();
    		右_皺1CD = new ColorD();
    		右_皺2CD = new ColorD();
    		右_皺3CD = new ColorD();
    		右_皺4CD = new ColorD();
    		右_皺5CD = new ColorD();
    		右_皺6CD = new ColorD();
    	}

    	public void 配色(クロスB色 配色)
    	{
    		中_下地CD.色 = 配色.生地2色;
    		中_皺1CD.色 = 中_下地CD.色;
    		中_皺2CD.色 = 中_下地CD.色;
    		左_下地CD.色 = 配色.生地1色;
    		左_皺1CD.色 = 左_下地CD.色;
    		左_皺2CD.色 = 左_下地CD.色;
    		左_皺3CD.色 = 左_下地CD.色;
    		左_皺4CD.色 = 左_下地CD.色;
    		左_皺5CD.色 = 左_下地CD.色;
    		左_皺6CD.色 = 左_下地CD.色;
    		右_下地CD.色 = 左_下地CD.色;
    		右_皺1CD.色 = 左_下地CD.色;
    		右_皺2CD.色 = 左_下地CD.色;
    		右_皺3CD.色 = 左_下地CD.色;
    		右_皺4CD.色 = 左_下地CD.色;
    		右_皺5CD.色 = 左_下地CD.色;
    		右_皺6CD.色 = 左_下地CD.色;
    	}
    }
}
