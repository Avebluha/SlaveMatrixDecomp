using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class ボテ腹_人 : ボテ腹
    {
    	public ShapePart X0Y0_腹;

    	public ShapePart X0Y0_ハイライト;

    	public ShapePart X0Y0_臍;

    	public ShapePart X0Y0_ハイライト左1;

    	public ShapePart X0Y0_ハイライト左2;

    	public ShapePart X0Y0_ハイライト右1;

    	public ShapePart X0Y0_ハイライト右2;

    	public ShapePart X0Y1_腹;

    	public ShapePart X0Y1_ハイライト;

    	public ShapePart X0Y1_臍;

    	public ShapePart X0Y1_ハイライト左1;

    	public ShapePart X0Y1_ハイライト左2;

    	public ShapePart X0Y1_ハイライト右1;

    	public ShapePart X0Y1_ハイライト右2;

    	public ShapePart X0Y2_腹;

    	public ShapePart X0Y2_ハイライト;

    	public ShapePart X0Y2_臍;

    	public ShapePart X0Y2_ハイライト左1;

    	public ShapePart X0Y2_ハイライト左2;

    	public ShapePart X0Y2_ハイライト右1;

    	public ShapePart X0Y2_ハイライト右2;

    	public ShapePart X0Y3_腹;

    	public ShapePart X0Y3_ハイライト;

    	public ShapePart X0Y3_臍;

    	public ShapePart X0Y3_ハイライト左1;

    	public ShapePart X0Y3_ハイライト左2;

    	public ShapePart X0Y3_ハイライト右1;

    	public ShapePart X0Y3_ハイライト右2;

    	public ShapePart X0Y4_腹;

    	public ShapePart X0Y4_ハイライト;

    	public ShapePart X0Y4_臍;

    	public ShapePart X0Y4_ハイライト左1;

    	public ShapePart X0Y4_ハイライト左2;

    	public ShapePart X0Y4_ハイライト右1;

    	public ShapePart X0Y4_ハイライト右2;

    	public ColorD 腹CD;

    	public ColorD ハイライトCD;

    	public ColorD 臍CD;

    	public ColorD ハイライト左1CD;

    	public ColorD ハイライト左2CD;

    	public ColorD ハイライト右1CD;

    	public ColorD ハイライト右2CD;

    	public ColorP X0Y0_腹CP;

    	public ColorP X0Y0_ハイライトCP;

    	public ColorP X0Y0_臍CP;

    	public ColorP X0Y0_ハイライト左1CP;

    	public ColorP X0Y0_ハイライト左2CP;

    	public ColorP X0Y0_ハイライト右1CP;

    	public ColorP X0Y0_ハイライト右2CP;

    	public ColorP X0Y1_腹CP;

    	public ColorP X0Y1_ハイライトCP;

    	public ColorP X0Y1_臍CP;

    	public ColorP X0Y1_ハイライト左1CP;

    	public ColorP X0Y1_ハイライト左2CP;

    	public ColorP X0Y1_ハイライト右1CP;

    	public ColorP X0Y1_ハイライト右2CP;

    	public ColorP X0Y2_腹CP;

    	public ColorP X0Y2_ハイライトCP;

    	public ColorP X0Y2_臍CP;

    	public ColorP X0Y2_ハイライト左1CP;

    	public ColorP X0Y2_ハイライト左2CP;

    	public ColorP X0Y2_ハイライト右1CP;

    	public ColorP X0Y2_ハイライト右2CP;

    	public ColorP X0Y3_腹CP;

    	public ColorP X0Y3_ハイライトCP;

    	public ColorP X0Y3_臍CP;

    	public ColorP X0Y3_ハイライト左1CP;

    	public ColorP X0Y3_ハイライト左2CP;

    	public ColorP X0Y3_ハイライト右1CP;

    	public ColorP X0Y3_ハイライト右2CP;

    	public ColorP X0Y4_腹CP;

    	public ColorP X0Y4_ハイライトCP;

    	public ColorP X0Y4_臍CP;

    	public ColorP X0Y4_ハイライト左1CP;

    	public ColorP X0Y4_ハイライト左2CP;

    	public ColorP X0Y4_ハイライト右1CP;

    	public ColorP X0Y4_ハイライト右2CP;

    	public スタンプK キスマーク;

    	public スタンプW 鞭痕;

    	public Ele[] 腹板_接続;

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

    	public bool 腹_表示
    	{
    		get
    		{
    			return X0Y0_腹.Dra;
    		}
    		set
    		{
    			X0Y0_腹.Dra = value;
    			X0Y1_腹.Dra = value;
    			X0Y2_腹.Dra = value;
    			X0Y3_腹.Dra = value;
    			X0Y4_腹.Dra = value;
    			X0Y0_腹.Hit = value;
    			X0Y1_腹.Hit = value;
    			X0Y2_腹.Hit = value;
    			X0Y3_腹.Hit = value;
    			X0Y4_腹.Hit = value;
    		}
    	}

    	public bool ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト.Dra = value;
    			X0Y1_ハイライト.Dra = value;
    			X0Y2_ハイライト.Dra = value;
    			X0Y3_ハイライト.Dra = value;
    			X0Y4_ハイライト.Dra = value;
    			X0Y0_ハイライト.Hit = value;
    			X0Y1_ハイライト.Hit = value;
    			X0Y2_ハイライト.Hit = value;
    			X0Y3_ハイライト.Hit = value;
    			X0Y4_ハイライト.Hit = value;
    		}
    	}

    	public bool 臍_表示
    	{
    		get
    		{
    			return X0Y0_臍.Dra;
    		}
    		set
    		{
    			X0Y0_臍.Dra = value;
    			X0Y1_臍.Dra = value;
    			X0Y2_臍.Dra = value;
    			X0Y3_臍.Dra = value;
    			X0Y4_臍.Dra = value;
    			X0Y0_臍.Hit = value;
    			X0Y1_臍.Hit = value;
    			X0Y2_臍.Hit = value;
    			X0Y3_臍.Hit = value;
    			X0Y4_臍.Hit = value;
    		}
    	}

    	public bool ハイライト左1_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト左1.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト左1.Dra = value;
    			X0Y1_ハイライト左1.Dra = value;
    			X0Y2_ハイライト左1.Dra = value;
    			X0Y3_ハイライト左1.Dra = value;
    			X0Y4_ハイライト左1.Dra = value;
    			X0Y0_ハイライト左1.Hit = value;
    			X0Y1_ハイライト左1.Hit = value;
    			X0Y2_ハイライト左1.Hit = value;
    			X0Y3_ハイライト左1.Hit = value;
    			X0Y4_ハイライト左1.Hit = value;
    		}
    	}

    	public bool ハイライト左2_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト左2.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト左2.Dra = value;
    			X0Y1_ハイライト左2.Dra = value;
    			X0Y2_ハイライト左2.Dra = value;
    			X0Y3_ハイライト左2.Dra = value;
    			X0Y4_ハイライト左2.Dra = value;
    			X0Y0_ハイライト左2.Hit = value;
    			X0Y1_ハイライト左2.Hit = value;
    			X0Y2_ハイライト左2.Hit = value;
    			X0Y3_ハイライト左2.Hit = value;
    			X0Y4_ハイライト左2.Hit = value;
    		}
    	}

    	public bool ハイライト右1_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト右1.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト右1.Dra = value;
    			X0Y1_ハイライト右1.Dra = value;
    			X0Y2_ハイライト右1.Dra = value;
    			X0Y3_ハイライト右1.Dra = value;
    			X0Y4_ハイライト右1.Dra = value;
    			X0Y0_ハイライト右1.Hit = value;
    			X0Y1_ハイライト右1.Hit = value;
    			X0Y2_ハイライト右1.Hit = value;
    			X0Y3_ハイライト右1.Hit = value;
    			X0Y4_ハイライト右1.Hit = value;
    		}
    	}

    	public bool ハイライト右2_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト右2.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト右2.Dra = value;
    			X0Y1_ハイライト右2.Dra = value;
    			X0Y2_ハイライト右2.Dra = value;
    			X0Y3_ハイライト右2.Dra = value;
    			X0Y4_ハイライト右2.Dra = value;
    			X0Y0_ハイライト右2.Hit = value;
    			X0Y1_ハイライト右2.Hit = value;
    			X0Y2_ハイライト右2.Hit = value;
    			X0Y3_ハイライト右2.Hit = value;
    			X0Y4_ハイライト右2.Hit = value;
    		}
    	}

    	public bool ハイライト表示
    	{
    		get
    		{
    			return ハイライト_表示;
    		}
    		set
    		{
    			ハイライト_表示 = value;
    			ハイライト左1_表示 = value;
    			ハイライト左2_表示 = value;
    			ハイライト右1_表示 = value;
    			ハイライト右2_表示 = value;
    		}
    	}

    	public double ハイライト濃度
    	{
    		get
    		{
    			return ハイライトCD.不透明度;
    		}
    		set
    		{
    			ハイライトCD.不透明度 = value;
    			ハイライト左1CD.不透明度 = value;
    			ハイライト左2CD.不透明度 = value;
    			ハイライト右1CD.不透明度 = value;
    			ハイライト右2CD.不透明度 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 腹_表示;
    		}
    		set
    		{
    			腹_表示 = value;
    			ハイライト_表示 = value;
    			臍_表示 = value;
    			ハイライト左1_表示 = value;
    			ハイライト左2_表示 = value;
    			ハイライト右1_表示 = value;
    			ハイライト右2_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 腹CD.不透明度;
    		}
    		set
    		{
    			腹CD.不透明度 = value;
    			ハイライトCD.不透明度 = value;
    			臍CD.不透明度 = value;
    			ハイライト左1CD.不透明度 = value;
    			ハイライト左2CD.不透明度 = value;
    			ハイライト右1CD.不透明度 = value;
    			ハイライト右2CD.不透明度 = value;
    		}
    	}

    	public JointS 腹板_接続点 => new JointS(Body, X0Y0_腹, 0);

    	public ボテ腹_人(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, ボテ腹_人D e)
    	{
    		ボテ腹_人 ボテ腹_人2 = this;
    		ThisType = GetType();
    		Body = new Difs(Sta.胴体["ボテ腹"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_腹 = partGroup["腹"].ToPar();
    		X0Y0_ハイライト = partGroup["ハイライト"].ToPar();
    		X0Y0_臍 = partGroup["臍"].ToPar();
    		X0Y0_ハイライト左1 = partGroup["ハイライト左1"].ToPar();
    		X0Y0_ハイライト左2 = partGroup["ハイライト左2"].ToPar();
    		X0Y0_ハイライト右1 = partGroup["ハイライト右1"].ToPar();
    		X0Y0_ハイライト右2 = partGroup["ハイライト右2"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_腹 = partGroup["腹"].ToPar();
    		X0Y1_ハイライト = partGroup["ハイライト"].ToPar();
    		X0Y1_臍 = partGroup["臍"].ToPar();
    		X0Y1_ハイライト左1 = partGroup["ハイライト左1"].ToPar();
    		X0Y1_ハイライト左2 = partGroup["ハイライト左2"].ToPar();
    		X0Y1_ハイライト右1 = partGroup["ハイライト右1"].ToPar();
    		X0Y1_ハイライト右2 = partGroup["ハイライト右2"].ToPar();
    		partGroup = Body[0][2];
    		X0Y2_腹 = partGroup["腹"].ToPar();
    		X0Y2_ハイライト = partGroup["ハイライト"].ToPar();
    		X0Y2_臍 = partGroup["臍"].ToPar();
    		X0Y2_ハイライト左1 = partGroup["ハイライト左1"].ToPar();
    		X0Y2_ハイライト左2 = partGroup["ハイライト左2"].ToPar();
    		X0Y2_ハイライト右1 = partGroup["ハイライト右1"].ToPar();
    		X0Y2_ハイライト右2 = partGroup["ハイライト右2"].ToPar();
    		partGroup = Body[0][3];
    		X0Y3_腹 = partGroup["腹"].ToPar();
    		X0Y3_ハイライト = partGroup["ハイライト"].ToPar();
    		X0Y3_臍 = partGroup["臍"].ToPar();
    		X0Y3_ハイライト左1 = partGroup["ハイライト左1"].ToPar();
    		X0Y3_ハイライト左2 = partGroup["ハイライト左2"].ToPar();
    		X0Y3_ハイライト右1 = partGroup["ハイライト右1"].ToPar();
    		X0Y3_ハイライト右2 = partGroup["ハイライト右2"].ToPar();
    		partGroup = Body[0][4];
    		X0Y4_腹 = partGroup["腹"].ToPar();
    		X0Y4_ハイライト = partGroup["ハイライト"].ToPar();
    		X0Y4_臍 = partGroup["臍"].ToPar();
    		X0Y4_ハイライト左1 = partGroup["ハイライト左1"].ToPar();
    		X0Y4_ハイライト左2 = partGroup["ハイライト左2"].ToPar();
    		X0Y4_ハイライト右1 = partGroup["ハイライト右1"].ToPar();
    		X0Y4_ハイライト右2 = partGroup["ハイライト右2"].ToPar();
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
    		腹_表示 = e.腹_表示;
    		ハイライト_表示 = e.ハイライト_表示;
    		臍_表示 = e.臍_表示;
    		ハイライト左1_表示 = e.ハイライト左1_表示;
    		ハイライト左2_表示 = e.ハイライト左2_表示;
    		ハイライト右1_表示 = e.ハイライト右1_表示;
    		ハイライト右2_表示 = e.ハイライト右2_表示;
    		ハイライト表示 = e.ハイライト表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.腹板_接続.Count > 0)
    		{
    			Ele f;
    			腹板_接続 = e.腹板_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = ボテ腹_人2;
    				f.ConnectionType = ConnectionInfo.ボテ腹_人_腹板_接続;
    				f.接続(ボテ腹_人2.腹板_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_腹CP = new ColorP(X0Y0_腹, 腹CD, DisUnit, abj: true);
    		X0Y0_ハイライトCP = new ColorP(X0Y0_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y0_臍CP = new ColorP(X0Y0_臍, 臍CD, DisUnit, abj: false);
    		X0Y0_ハイライト左1CP = new ColorP(X0Y0_ハイライト左1, ハイライト左1CD, DisUnit, abj: true);
    		X0Y0_ハイライト左2CP = new ColorP(X0Y0_ハイライト左2, ハイライト左2CD, DisUnit, abj: true);
    		X0Y0_ハイライト右1CP = new ColorP(X0Y0_ハイライト右1, ハイライト右1CD, DisUnit, abj: true);
    		X0Y0_ハイライト右2CP = new ColorP(X0Y0_ハイライト右2, ハイライト右2CD, DisUnit, abj: true);
    		X0Y1_腹CP = new ColorP(X0Y1_腹, 腹CD, DisUnit, abj: true);
    		X0Y1_ハイライトCP = new ColorP(X0Y1_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y1_臍CP = new ColorP(X0Y1_臍, 臍CD, DisUnit, abj: false);
    		X0Y1_ハイライト左1CP = new ColorP(X0Y1_ハイライト左1, ハイライト左1CD, DisUnit, abj: true);
    		X0Y1_ハイライト左2CP = new ColorP(X0Y1_ハイライト左2, ハイライト左2CD, DisUnit, abj: true);
    		X0Y1_ハイライト右1CP = new ColorP(X0Y1_ハイライト右1, ハイライト右1CD, DisUnit, abj: true);
    		X0Y1_ハイライト右2CP = new ColorP(X0Y1_ハイライト右2, ハイライト右2CD, DisUnit, abj: true);
    		X0Y2_腹CP = new ColorP(X0Y2_腹, 腹CD, DisUnit, abj: true);
    		X0Y2_ハイライトCP = new ColorP(X0Y2_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y2_臍CP = new ColorP(X0Y2_臍, 臍CD, DisUnit, abj: false);
    		X0Y2_ハイライト左1CP = new ColorP(X0Y2_ハイライト左1, ハイライト左1CD, DisUnit, abj: true);
    		X0Y2_ハイライト左2CP = new ColorP(X0Y2_ハイライト左2, ハイライト左2CD, DisUnit, abj: true);
    		X0Y2_ハイライト右1CP = new ColorP(X0Y2_ハイライト右1, ハイライト右1CD, DisUnit, abj: true);
    		X0Y2_ハイライト右2CP = new ColorP(X0Y2_ハイライト右2, ハイライト右2CD, DisUnit, abj: true);
    		X0Y3_腹CP = new ColorP(X0Y3_腹, 腹CD, DisUnit, abj: true);
    		X0Y3_ハイライトCP = new ColorP(X0Y3_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y3_臍CP = new ColorP(X0Y3_臍, 臍CD, DisUnit, abj: false);
    		X0Y3_ハイライト左1CP = new ColorP(X0Y3_ハイライト左1, ハイライト左1CD, DisUnit, abj: true);
    		X0Y3_ハイライト左2CP = new ColorP(X0Y3_ハイライト左2, ハイライト左2CD, DisUnit, abj: true);
    		X0Y3_ハイライト右1CP = new ColorP(X0Y3_ハイライト右1, ハイライト右1CD, DisUnit, abj: true);
    		X0Y3_ハイライト右2CP = new ColorP(X0Y3_ハイライト右2, ハイライト右2CD, DisUnit, abj: true);
    		X0Y4_腹CP = new ColorP(X0Y4_腹, 腹CD, DisUnit, abj: true);
    		X0Y4_ハイライトCP = new ColorP(X0Y4_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y4_臍CP = new ColorP(X0Y4_臍, 臍CD, DisUnit, abj: false);
    		X0Y4_ハイライト左1CP = new ColorP(X0Y4_ハイライト左1, ハイライト左1CD, DisUnit, abj: true);
    		X0Y4_ハイライト左2CP = new ColorP(X0Y4_ハイライト左2, ハイライト左2CD, DisUnit, abj: true);
    		X0Y4_ハイライト右1CP = new ColorP(X0Y4_ハイライト右1, ハイライト右1CD, DisUnit, abj: true);
    		X0Y4_ハイライト右2CP = new ColorP(X0Y4_ハイライト右2, ハイライト右2CD, DisUnit, abj: true);
    		ハイライト濃度 = e.ハイライト濃度;
    		Intensity = e.濃度;
    		尺度YB = 0.95;
    		double num = 1.0;
    		X0Y0_臍.BasePointBase = new Vector2D(X0Y0_臍.BasePointBase.X, 0.363449439772374);
    		X0Y1_臍.BasePointBase = new Vector2D(X0Y1_臍.BasePointBase.X, 0.363808225004133);
    		X0Y2_臍.BasePointBase = new Vector2D(X0Y2_臍.BasePointBase.X, 0.364167010235893);
    		X0Y3_臍.BasePointBase = new Vector2D(X0Y3_臍.BasePointBase.X, 0.364525795467652);
    		X0Y4_臍.BasePointBase = new Vector2D(X0Y4_臍.BasePointBase.X, 0.364884580699412);
    		X0Y0_ハイライト.BasePointBase = new Vector2D(X0Y0_ハイライト.BasePointBase.X, 0.0219448899681257);
    		X0Y1_ハイライト.BasePointBase = new Vector2D(X0Y1_ハイライト.BasePointBase.X, 0.0223873272658702);
    		X0Y2_ハイライト.BasePointBase = new Vector2D(X0Y2_ハイライト.BasePointBase.X, 0.0228297645636147);
    		X0Y3_ハイライト.BasePointBase = new Vector2D(X0Y3_ハイライト.BasePointBase.X, 0.0232722018613592);
    		X0Y4_ハイライト.BasePointBase = new Vector2D(X0Y4_ハイライト.BasePointBase.X, 0.0237146391591036);
    		num = 1.5;
    		X0Y0_臍.SizeBase *= num;
    		X0Y1_臍.SizeBase *= num;
    		X0Y2_臍.SizeBase *= num;
    		X0Y3_臍.SizeBase *= num;
    		X0Y4_臍.SizeBase *= num;
    		X0Y0_ハイライト.SizeBase *= num;
    		X0Y1_ハイライト.SizeBase *= num;
    		X0Y2_ハイライト.SizeBase *= num;
    		X0Y3_ハイライト.SizeBase *= num;
    		X0Y4_ハイライト.SizeBase *= num;
    		num = 0.6;
    		X0Y0_臍.SizeXBase *= num;
    		X0Y1_臍.SizeXBase *= num;
    		X0Y2_臍.SizeXBase *= num;
    		X0Y3_臍.SizeXBase *= num;
    		X0Y4_臍.SizeXBase *= num;
    		X0Y0_ハイライト.SizeXBase *= num;
    		X0Y1_ハイライト.SizeXBase *= num;
    		X0Y2_ハイライト.SizeXBase *= num;
    		X0Y3_ハイライト.SizeXBase *= num;
    		X0Y4_ハイライト.SizeXBase *= num;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Body.Draw(Are);
    		キスマーク.Draw(Are);
    		鞭痕.Draw(Are);
    	}

    	public override void 色更新()
    	{
    		switch (Body.IndexY)
    		{
    		case 0:
    			X0Y0_腹CP.Update();
    			X0Y0_ハイライトCP.Update();
    			X0Y0_臍CP.Update();
    			X0Y0_ハイライト左1CP.Update();
    			X0Y0_ハイライト左2CP.Update();
    			X0Y0_ハイライト右1CP.Update();
    			X0Y0_ハイライト右2CP.Update();
    			break;
    		case 1:
    			X0Y1_腹CP.Update();
    			X0Y1_ハイライトCP.Update();
    			X0Y1_臍CP.Update();
    			X0Y1_ハイライト左1CP.Update();
    			X0Y1_ハイライト左2CP.Update();
    			X0Y1_ハイライト右1CP.Update();
    			X0Y1_ハイライト右2CP.Update();
    			break;
    		case 2:
    			X0Y2_腹CP.Update();
    			X0Y2_ハイライトCP.Update();
    			X0Y2_臍CP.Update();
    			X0Y2_ハイライト左1CP.Update();
    			X0Y2_ハイライト左2CP.Update();
    			X0Y2_ハイライト右1CP.Update();
    			X0Y2_ハイライト右2CP.Update();
    			break;
    		case 3:
    			X0Y3_腹CP.Update();
    			X0Y3_ハイライトCP.Update();
    			X0Y3_臍CP.Update();
    			X0Y3_ハイライト左1CP.Update();
    			X0Y3_ハイライト左2CP.Update();
    			X0Y3_ハイライト右1CP.Update();
    			X0Y3_ハイライト右2CP.Update();
    			break;
    		default:
    			X0Y4_腹CP.Update();
    			X0Y4_ハイライトCP.Update();
    			X0Y4_臍CP.Update();
    			X0Y4_ハイライト左1CP.Update();
    			X0Y4_ハイライト左2CP.Update();
    			X0Y4_ハイライト右1CP.Update();
    			X0Y4_ハイライト右2CP.Update();
    			break;
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		腹CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		臍CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		ハイライト左1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		ハイライト左2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
    		ハイライト右1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		ハイライト右2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
    	}
    }
}
