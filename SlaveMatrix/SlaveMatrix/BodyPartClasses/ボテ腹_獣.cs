using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class ボテ腹_獣 : ボテ腹
    {
    	public ShapePart X0Y0_腹;

    	public ShapePart X0Y0_臍;

    	public ShapePart X0Y1_腹;

    	public ShapePart X0Y1_臍;

    	public ShapePart X0Y2_腹;

    	public ShapePart X0Y2_臍;

    	public ShapePart X0Y3_腹;

    	public ShapePart X0Y3_臍;

    	public ShapePart X0Y4_腹;

    	public ShapePart X0Y4_臍;

    	public ColorD 腹CD;

    	public ColorD 臍CD;

    	public ColorP X0Y0_腹CP;

    	public ColorP X0Y0_臍CP;

    	public ColorP X0Y1_腹CP;

    	public ColorP X0Y1_臍CP;

    	public ColorP X0Y2_腹CP;

    	public ColorP X0Y2_臍CP;

    	public ColorP X0Y3_腹CP;

    	public ColorP X0Y3_臍CP;

    	public ColorP X0Y4_腹CP;

    	public ColorP X0Y4_臍CP;

    	public Element[] 腹板_接続;

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

    	public override bool 表示
    	{
    		get
    		{
    			return 腹_表示;
    		}
    		set
    		{
    			腹_表示 = value;
    			臍_表示 = value;
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
    			臍CD.不透明度 = value;
    		}
    	}

    	public JointS 腹板_接続点 => new JointS(Body, X0Y0_腹, 0);

    	public ボテ腹_獣(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, ボテ腹_獣D e)
    	{
    		ボテ腹_獣 ボテ腹_獣2 = this;
    		ThisType = GetType();
    		Body = new VariantGrid(Sta.半身["四足ボテ腹"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_腹 = partGroup["腹"].ToPar();
    		X0Y0_臍 = partGroup["臍"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_腹 = partGroup["腹"].ToPar();
    		X0Y1_臍 = partGroup["臍"].ToPar();
    		partGroup = Body[0][2];
    		X0Y2_腹 = partGroup["腹"].ToPar();
    		X0Y2_臍 = partGroup["臍"].ToPar();
    		partGroup = Body[0][3];
    		X0Y3_腹 = partGroup["腹"].ToPar();
    		X0Y3_臍 = partGroup["臍"].ToPar();
    		partGroup = Body[0][4];
    		X0Y4_腹 = partGroup["腹"].ToPar();
    		X0Y4_臍 = partGroup["臍"].ToPar();
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
    		臍_表示 = e.臍_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.腹板_接続.Count > 0)
    		{
    			Element f;
    			腹板_接続 = e.腹板_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = ボテ腹_獣2;
    				f.ConnectionType = ConnectionInfo.ボテ腹_獣_腹板_接続;
    				f.接続(ボテ腹_獣2.腹板_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_腹CP = new ColorP(X0Y0_腹, 腹CD, DisUnit, abj: true);
    		X0Y0_臍CP = new ColorP(X0Y0_臍, 臍CD, DisUnit, abj: false);
    		X0Y1_腹CP = new ColorP(X0Y1_腹, 腹CD, DisUnit, abj: true);
    		X0Y1_臍CP = new ColorP(X0Y1_臍, 臍CD, DisUnit, abj: false);
    		X0Y2_腹CP = new ColorP(X0Y2_腹, 腹CD, DisUnit, abj: true);
    		X0Y2_臍CP = new ColorP(X0Y2_臍, 臍CD, DisUnit, abj: false);
    		X0Y3_腹CP = new ColorP(X0Y3_腹, 腹CD, DisUnit, abj: true);
    		X0Y3_臍CP = new ColorP(X0Y3_臍, 臍CD, DisUnit, abj: false);
    		X0Y4_腹CP = new ColorP(X0Y4_腹, 腹CD, DisUnit, abj: true);
    		X0Y4_臍CP = new ColorP(X0Y4_臍, 臍CD, DisUnit, abj: false);
    		Intensity = e.濃度;
    		double num = 1.0;
    		X0Y0_臍.BasePointBase = new Vector2D(X0Y0_臍.BasePointBase.X, 0.360579157918298);
    		X0Y1_臍.BasePointBase = new Vector2D(X0Y1_臍.BasePointBase.X, 0.360579157918298);
    		X0Y2_臍.BasePointBase = new Vector2D(X0Y2_臍.BasePointBase.X, 0.360579157918298);
    		X0Y3_臍.BasePointBase = new Vector2D(X0Y3_臍.BasePointBase.X, 0.360579157918298);
    		X0Y4_臍.BasePointBase = new Vector2D(X0Y4_臍.BasePointBase.X, 0.360579157918298);
    		num = 1.5;
    		X0Y0_臍.SizeBase *= num;
    		X0Y1_臍.SizeBase *= num;
    		X0Y2_臍.SizeBase *= num;
    		X0Y3_臍.SizeBase *= num;
    		X0Y4_臍.SizeBase *= num;
    		num = 0.6;
    		X0Y0_臍.SizeXBase *= num;
    		X0Y1_臍.SizeXBase *= num;
    		X0Y2_臍.SizeXBase *= num;
    		X0Y3_臍.SizeXBase *= num;
    		X0Y4_臍.SizeXBase *= num;
    	}

    	public override void 色更新()
    	{
    		switch (Body.IndexY)
    		{
    		case 0:
    			X0Y0_腹CP.Update();
    			X0Y0_臍CP.Update();
    			break;
    		case 1:
    			X0Y1_腹CP.Update();
    			X0Y1_臍CP.Update();
    			break;
    		case 2:
    			X0Y2_腹CP.Update();
    			X0Y2_臍CP.Update();
    			break;
    		case 3:
    			X0Y3_腹CP.Update();
    			X0Y3_臍CP.Update();
    			break;
    		default:
    			X0Y4_腹CP.Update();
    			X0Y4_臍CP.Update();
    			break;
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		腹CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		臍CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    	}
    }
}
