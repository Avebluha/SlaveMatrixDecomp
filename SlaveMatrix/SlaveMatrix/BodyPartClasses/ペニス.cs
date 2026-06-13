using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class ペニス : Ele
    {
    	public ShapePart X0Y0_陰嚢;

    	public ShapePart X0Y0_陰茎;

    	public ShapePart X0Y0_血管下;

    	public ShapePart X0Y0_血管上;

    	public ShapePart X0Y0_亀頭;

    	public ShapePart X0Y1_陰嚢;

    	public ShapePart X0Y1_陰茎;

    	public ShapePart X0Y1_血管下;

    	public ShapePart X0Y1_血管上;

    	public ShapePart X0Y1_亀頭;

    	public ShapePart X0Y2_陰嚢;

    	public ShapePart X0Y2_陰茎;

    	public ShapePart X0Y2_血管下;

    	public ShapePart X0Y2_血管上;

    	public ShapePart X0Y2_亀頭;

    	public ShapePart X0Y3_陰嚢;

    	public ShapePart X0Y3_陰茎;

    	public ShapePart X0Y3_血管下;

    	public ShapePart X0Y3_血管上;

    	public ShapePart X0Y3_亀頭;

    	public ShapePart X0Y4_陰嚢;

    	public ShapePart X0Y4_陰茎;

    	public ShapePart X0Y4_血管下;

    	public ShapePart X0Y4_血管上;

    	public ShapePart X0Y4_亀頭;

    	public ShapePart X1Y0_陰嚢;

    	public ShapePart X1Y0_陰茎;

    	public ShapePart X1Y0_血管下;

    	public ShapePart X1Y0_血管上;

    	public ShapePart X1Y0_亀頭;

    	public ShapePart X1Y1_陰嚢;

    	public ShapePart X1Y1_陰茎;

    	public ShapePart X1Y1_血管下;

    	public ShapePart X1Y1_血管上;

    	public ShapePart X1Y1_亀頭;

    	public ShapePart X1Y2_陰嚢;

    	public ShapePart X1Y2_陰茎;

    	public ShapePart X1Y2_血管下;

    	public ShapePart X1Y2_血管上;

    	public ShapePart X1Y3_陰嚢;

    	public ShapePart X1Y3_陰茎;

    	public ShapePart X1Y3_血管下;

    	public ShapePart X1Y3_血管上;

    	public ShapePart X1Y4_陰嚢;

    	public ShapePart X1Y4_陰茎;

    	public ShapePart X1Y4_血管下;

    	public AreM AreM;

    	public ColorD 陰嚢CD;

    	public ColorD 陰茎CD;

    	public ColorD 血管下CD;

    	public ColorD 血管上CD;

    	public ColorD 亀頭CD;

    	public ColorP X0Y0_陰嚢CP;

    	public ColorP X0Y0_陰茎CP;

    	public ColorP X0Y0_血管下CP;

    	public ColorP X0Y0_血管上CP;

    	public ColorP X0Y0_亀頭CP;

    	public ColorP X0Y1_陰嚢CP;

    	public ColorP X0Y1_陰茎CP;

    	public ColorP X0Y1_血管下CP;

    	public ColorP X0Y1_血管上CP;

    	public ColorP X0Y1_亀頭CP;

    	public ColorP X0Y2_陰嚢CP;

    	public ColorP X0Y2_陰茎CP;

    	public ColorP X0Y2_血管下CP;

    	public ColorP X0Y2_血管上CP;

    	public ColorP X0Y2_亀頭CP;

    	public ColorP X0Y3_陰嚢CP;

    	public ColorP X0Y3_陰茎CP;

    	public ColorP X0Y3_血管下CP;

    	public ColorP X0Y3_血管上CP;

    	public ColorP X0Y3_亀頭CP;

    	public ColorP X0Y4_陰嚢CP;

    	public ColorP X0Y4_陰茎CP;

    	public ColorP X0Y4_血管下CP;

    	public ColorP X0Y4_血管上CP;

    	public ColorP X0Y4_亀頭CP;

    	public ColorP X1Y0_陰嚢CP;

    	public ColorP X1Y0_陰茎CP;

    	public ColorP X1Y0_血管下CP;

    	public ColorP X1Y0_血管上CP;

    	public ColorP X1Y0_亀頭CP;

    	public ColorP X1Y1_陰嚢CP;

    	public ColorP X1Y1_陰茎CP;

    	public ColorP X1Y1_血管下CP;

    	public ColorP X1Y1_血管上CP;

    	public ColorP X1Y1_亀頭CP;

    	public ColorP X1Y2_陰嚢CP;

    	public ColorP X1Y2_陰茎CP;

    	public ColorP X1Y2_血管下CP;

    	public ColorP X1Y2_血管上CP;

    	public ColorP X1Y3_陰嚢CP;

    	public ColorP X1Y3_陰茎CP;

    	public ColorP X1Y3_血管下CP;

    	public ColorP X1Y3_血管上CP;

    	public ColorP X1Y4_陰嚢CP;

    	public ColorP X1Y4_陰茎CP;

    	public ColorP X1Y4_血管下CP;

    	public Ele[] 尿道_接続;

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

    	public bool 陰嚢_表示
    	{
    		get
    		{
    			return X0Y0_陰嚢.Dra;
    		}
    		set
    		{
    			X0Y0_陰嚢.Dra = value;
    			X0Y1_陰嚢.Dra = value;
    			X0Y2_陰嚢.Dra = value;
    			X0Y3_陰嚢.Dra = value;
    			X0Y4_陰嚢.Dra = value;
    			X1Y0_陰嚢.Dra = value;
    			X1Y1_陰嚢.Dra = value;
    			X1Y2_陰嚢.Dra = value;
    			X1Y3_陰嚢.Dra = value;
    			X1Y4_陰嚢.Dra = value;
    			X0Y0_陰嚢.Hit = value;
    			X0Y1_陰嚢.Hit = value;
    			X0Y2_陰嚢.Hit = value;
    			X0Y3_陰嚢.Hit = value;
    			X0Y4_陰嚢.Hit = value;
    			X1Y0_陰嚢.Hit = value;
    			X1Y1_陰嚢.Hit = value;
    			X1Y2_陰嚢.Hit = value;
    			X1Y3_陰嚢.Hit = value;
    			X1Y4_陰嚢.Hit = value;
    		}
    	}

    	public bool 陰茎_表示
    	{
    		get
    		{
    			return X0Y0_陰茎.Dra;
    		}
    		set
    		{
    			X0Y0_陰茎.Dra = value;
    			X0Y1_陰茎.Dra = value;
    			X0Y2_陰茎.Dra = value;
    			X0Y3_陰茎.Dra = value;
    			X0Y4_陰茎.Dra = value;
    			X1Y0_陰茎.Dra = value;
    			X1Y1_陰茎.Dra = value;
    			X1Y2_陰茎.Dra = value;
    			X1Y3_陰茎.Dra = value;
    			X1Y4_陰茎.Dra = value;
    			X0Y0_陰茎.Hit = value;
    			X0Y1_陰茎.Hit = value;
    			X0Y2_陰茎.Hit = value;
    			X0Y3_陰茎.Hit = value;
    			X0Y4_陰茎.Hit = value;
    			X1Y0_陰茎.Hit = value;
    			X1Y1_陰茎.Hit = value;
    			X1Y2_陰茎.Hit = value;
    			X1Y3_陰茎.Hit = value;
    			X1Y4_陰茎.Hit = value;
    		}
    	}

    	public bool 血管下_表示
    	{
    		get
    		{
    			return X0Y0_血管下.Dra;
    		}
    		set
    		{
    			X0Y0_血管下.Dra = value;
    			X0Y1_血管下.Dra = value;
    			X0Y2_血管下.Dra = value;
    			X0Y3_血管下.Dra = value;
    			X0Y4_血管下.Dra = value;
    			X1Y0_血管下.Dra = value;
    			X1Y1_血管下.Dra = value;
    			X1Y2_血管下.Dra = value;
    			X1Y3_血管下.Dra = value;
    			X1Y4_血管下.Dra = value;
    			X0Y0_血管下.Hit = value;
    			X0Y1_血管下.Hit = value;
    			X0Y2_血管下.Hit = value;
    			X0Y3_血管下.Hit = value;
    			X0Y4_血管下.Hit = value;
    			X1Y0_血管下.Hit = value;
    			X1Y1_血管下.Hit = value;
    			X1Y2_血管下.Hit = value;
    			X1Y3_血管下.Hit = value;
    			X1Y4_血管下.Hit = value;
    		}
    	}

    	public bool 血管上_表示
    	{
    		get
    		{
    			return X0Y0_血管上.Dra;
    		}
    		set
    		{
    			X0Y0_血管上.Dra = value;
    			X0Y1_血管上.Dra = value;
    			X0Y2_血管上.Dra = value;
    			X0Y3_血管上.Dra = value;
    			X0Y4_血管上.Dra = value;
    			X1Y0_血管上.Dra = value;
    			X1Y1_血管上.Dra = value;
    			X1Y2_血管上.Dra = value;
    			X1Y3_血管上.Dra = value;
    			X0Y0_血管上.Hit = value;
    			X0Y1_血管上.Hit = value;
    			X0Y2_血管上.Hit = value;
    			X0Y3_血管上.Hit = value;
    			X0Y4_血管上.Hit = value;
    			X1Y0_血管上.Hit = value;
    			X1Y1_血管上.Hit = value;
    			X1Y2_血管上.Hit = value;
    			X1Y3_血管上.Hit = value;
    		}
    	}

    	public bool 亀頭_表示
    	{
    		get
    		{
    			return X0Y0_亀頭.Dra;
    		}
    		set
    		{
    			X0Y0_亀頭.Dra = value;
    			X0Y1_亀頭.Dra = value;
    			X0Y2_亀頭.Dra = value;
    			X0Y3_亀頭.Dra = value;
    			X0Y4_亀頭.Dra = value;
    			X1Y0_亀頭.Dra = value;
    			X1Y1_亀頭.Dra = value;
    			X0Y0_亀頭.Hit = value;
    			X0Y1_亀頭.Hit = value;
    			X0Y2_亀頭.Hit = value;
    			X0Y3_亀頭.Hit = value;
    			X0Y4_亀頭.Hit = value;
    			X1Y0_亀頭.Hit = value;
    			X1Y1_亀頭.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 陰嚢_表示;
    		}
    		set
    		{
    			陰嚢_表示 = value;
    			陰茎_表示 = value;
    			血管下_表示 = value;
    			血管上_表示 = value;
    			亀頭_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 陰嚢CD.不透明度;
    		}
    		set
    		{
    			陰嚢CD.不透明度 = value;
    			陰茎CD.不透明度 = value;
    			血管下CD.不透明度 = value;
    			血管上CD.不透明度 = value;
    			亀頭CD.不透明度 = value;
    		}
    	}

    	public override Vector2D 位置B
    	{
    		get
    		{
    			return AreM.Position;
    		}
    		set
    		{
    			AreM.Position = value;
    		}
    	}

    	public JointS 尿道_接続点 => new JointS(Body, X0Y0_陰茎, 3);

    	public ペニス(double DisUnit, 配色指定 配色指定, 主人公配色 体配色, ModeEventDispatcher Med, ペニスD e)
    	{
    		ペニス ペニス2 = this;
    		ThisType = GetType();
    		Body = new Difs(Sta.カーソル["ペニス"]);
    		Pars pars = Body[0][0];
    		X0Y0_陰嚢 = pars["陰嚢"].ToPar();
    		X0Y0_陰茎 = pars["陰茎"].ToPar();
    		X0Y0_血管下 = pars["血管下"].ToPar();
    		X0Y0_血管上 = pars["血管上"].ToPar();
    		X0Y0_亀頭 = pars["亀頭"].ToPar();
    		pars = Body[0][1];
    		X0Y1_陰嚢 = pars["陰嚢"].ToPar();
    		X0Y1_陰茎 = pars["陰茎"].ToPar();
    		X0Y1_血管下 = pars["血管下"].ToPar();
    		X0Y1_血管上 = pars["血管上"].ToPar();
    		X0Y1_亀頭 = pars["亀頭"].ToPar();
    		pars = Body[0][2];
    		X0Y2_陰嚢 = pars["陰嚢"].ToPar();
    		X0Y2_陰茎 = pars["陰茎"].ToPar();
    		X0Y2_血管下 = pars["血管下"].ToPar();
    		X0Y2_血管上 = pars["血管上"].ToPar();
    		X0Y2_亀頭 = pars["亀頭"].ToPar();
    		pars = Body[0][3];
    		X0Y3_陰嚢 = pars["陰嚢"].ToPar();
    		X0Y3_陰茎 = pars["陰茎"].ToPar();
    		X0Y3_血管下 = pars["血管下"].ToPar();
    		X0Y3_血管上 = pars["血管上"].ToPar();
    		X0Y3_亀頭 = pars["亀頭"].ToPar();
    		pars = Body[0][4];
    		X0Y4_陰嚢 = pars["陰嚢"].ToPar();
    		X0Y4_陰茎 = pars["陰茎"].ToPar();
    		X0Y4_血管下 = pars["血管下"].ToPar();
    		X0Y4_血管上 = pars["血管上"].ToPar();
    		X0Y4_亀頭 = pars["亀頭"].ToPar();
    		pars = Body[1][0];
    		X1Y0_陰嚢 = pars["陰嚢"].ToPar();
    		X1Y0_陰茎 = pars["陰茎"].ToPar();
    		X1Y0_血管下 = pars["血管下"].ToPar();
    		X1Y0_血管上 = pars["血管上"].ToPar();
    		X1Y0_亀頭 = pars["亀頭"].ToPar();
    		pars = Body[1][1];
    		X1Y1_陰嚢 = pars["陰嚢"].ToPar();
    		X1Y1_陰茎 = pars["陰茎"].ToPar();
    		X1Y1_血管下 = pars["血管下"].ToPar();
    		X1Y1_血管上 = pars["血管上"].ToPar();
    		X1Y1_亀頭 = pars["亀頭"].ToPar();
    		pars = Body[1][2];
    		X1Y2_陰嚢 = pars["陰嚢"].ToPar();
    		X1Y2_陰茎 = pars["陰茎"].ToPar();
    		X1Y2_血管下 = pars["血管下"].ToPar();
    		X1Y2_血管上 = pars["血管上"].ToPar();
    		pars = Body[1][3];
    		X1Y3_陰嚢 = pars["陰嚢"].ToPar();
    		X1Y3_陰茎 = pars["陰茎"].ToPar();
    		X1Y3_血管下 = pars["血管下"].ToPar();
    		X1Y3_血管上 = pars["血管上"].ToPar();
    		pars = Body[1][4];
    		X1Y4_陰嚢 = pars["陰嚢"].ToPar();
    		X1Y4_陰茎 = pars["陰茎"].ToPar();
    		X1Y4_血管下 = pars["血管下"].ToPar();
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
    		陰嚢_表示 = e.陰嚢_表示;
    		陰茎_表示 = e.陰茎_表示;
    		血管下_表示 = e.血管下_表示;
    		血管上_表示 = e.血管上_表示;
    		亀頭_表示 = e.亀頭_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.尿道_接続.Count > 0)
    		{
    			Ele f;
    			尿道_接続 = e.尿道_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = ペニス2;
    				f.ConnectionType = ConnectionInfo.ペニス_尿道_接続;
    				f.接続(ペニス2.尿道_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_陰嚢CP = new ColorP(X0Y0_陰嚢, 陰嚢CD, DisUnit, abj: true);
    		X0Y0_陰茎CP = new ColorP(X0Y0_陰茎, 陰茎CD, DisUnit, abj: true);
    		X0Y0_血管下CP = new ColorP(X0Y0_血管下, 血管下CD, DisUnit, abj: true);
    		X0Y0_血管上CP = new ColorP(X0Y0_血管上, 血管上CD, DisUnit, abj: true);
    		X0Y0_亀頭CP = new ColorP(X0Y0_亀頭, 亀頭CD, DisUnit, abj: true);
    		X0Y1_陰嚢CP = new ColorP(X0Y1_陰嚢, 陰嚢CD, DisUnit, abj: true);
    		X0Y1_陰茎CP = new ColorP(X0Y1_陰茎, 陰茎CD, DisUnit, abj: true);
    		X0Y1_血管下CP = new ColorP(X0Y1_血管下, 血管下CD, DisUnit, abj: true);
    		X0Y1_血管上CP = new ColorP(X0Y1_血管上, 血管上CD, DisUnit, abj: true);
    		X0Y1_亀頭CP = new ColorP(X0Y1_亀頭, 亀頭CD, DisUnit, abj: true);
    		X0Y2_陰嚢CP = new ColorP(X0Y2_陰嚢, 陰嚢CD, DisUnit, abj: true);
    		X0Y2_陰茎CP = new ColorP(X0Y2_陰茎, 陰茎CD, DisUnit, abj: true);
    		X0Y2_血管下CP = new ColorP(X0Y2_血管下, 血管下CD, DisUnit, abj: true);
    		X0Y2_血管上CP = new ColorP(X0Y2_血管上, 血管上CD, DisUnit, abj: true);
    		X0Y2_亀頭CP = new ColorP(X0Y2_亀頭, 亀頭CD, DisUnit, abj: true);
    		X0Y3_陰嚢CP = new ColorP(X0Y3_陰嚢, 陰嚢CD, DisUnit, abj: true);
    		X0Y3_陰茎CP = new ColorP(X0Y3_陰茎, 陰茎CD, DisUnit, abj: true);
    		X0Y3_血管下CP = new ColorP(X0Y3_血管下, 血管下CD, DisUnit, abj: true);
    		X0Y3_血管上CP = new ColorP(X0Y3_血管上, 血管上CD, DisUnit, abj: true);
    		X0Y3_亀頭CP = new ColorP(X0Y3_亀頭, 亀頭CD, DisUnit, abj: true);
    		X0Y4_陰嚢CP = new ColorP(X0Y4_陰嚢, 陰嚢CD, DisUnit, abj: true);
    		X0Y4_陰茎CP = new ColorP(X0Y4_陰茎, 陰茎CD, DisUnit, abj: true);
    		X0Y4_血管下CP = new ColorP(X0Y4_血管下, 血管下CD, DisUnit, abj: true);
    		X0Y4_血管上CP = new ColorP(X0Y4_血管上, 血管上CD, DisUnit, abj: true);
    		X0Y4_亀頭CP = new ColorP(X0Y4_亀頭, 亀頭CD, DisUnit, abj: true);
    		X1Y0_陰嚢CP = new ColorP(X1Y0_陰嚢, 陰嚢CD, DisUnit, abj: true);
    		X1Y0_陰茎CP = new ColorP(X1Y0_陰茎, 陰茎CD, DisUnit, abj: true);
    		X1Y0_血管下CP = new ColorP(X1Y0_血管下, 血管下CD, DisUnit, abj: true);
    		X1Y0_血管上CP = new ColorP(X1Y0_血管上, 血管上CD, DisUnit, abj: true);
    		X1Y0_亀頭CP = new ColorP(X1Y0_亀頭, 亀頭CD, DisUnit, abj: true);
    		X1Y1_陰嚢CP = new ColorP(X1Y1_陰嚢, 陰嚢CD, DisUnit, abj: true);
    		X1Y1_陰茎CP = new ColorP(X1Y1_陰茎, 陰茎CD, DisUnit, abj: true);
    		X1Y1_血管下CP = new ColorP(X1Y1_血管下, 血管下CD, DisUnit, abj: true);
    		X1Y1_血管上CP = new ColorP(X1Y1_血管上, 血管上CD, DisUnit, abj: true);
    		X1Y1_亀頭CP = new ColorP(X1Y1_亀頭, 亀頭CD, DisUnit, abj: true);
    		X1Y2_陰嚢CP = new ColorP(X1Y2_陰嚢, 陰嚢CD, DisUnit, abj: true);
    		X1Y2_陰茎CP = new ColorP(X1Y2_陰茎, 陰茎CD, DisUnit, abj: true);
    		X1Y2_血管下CP = new ColorP(X1Y2_血管下, 血管下CD, DisUnit, abj: true);
    		X1Y2_血管上CP = new ColorP(X1Y2_血管上, 血管上CD, DisUnit, abj: true);
    		X1Y3_陰嚢CP = new ColorP(X1Y3_陰嚢, 陰嚢CD, DisUnit, abj: true);
    		X1Y3_陰茎CP = new ColorP(X1Y3_陰茎, 陰茎CD, DisUnit, abj: true);
    		X1Y3_血管下CP = new ColorP(X1Y3_血管下, 血管下CD, DisUnit, abj: true);
    		X1Y3_血管上CP = new ColorP(X1Y3_血管上, 血管上CD, DisUnit, abj: true);
    		X1Y4_陰嚢CP = new ColorP(X1Y4_陰嚢, 陰嚢CD, DisUnit, abj: true);
    		X1Y4_陰茎CP = new ColorP(X1Y4_陰茎, 陰茎CD, DisUnit, abj: true);
    		X1Y4_血管下CP = new ColorP(X1Y4_血管下, 血管下CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		AreM = new AreM(Med.Unit, 3.0, 7.0, 0.07, Med.DisQuality, Med.HitAccuracy, 0.45);
    		AreM.BasePoint = new Vector2D(0.5, 0.1);
    		X0Y0_陰嚢.BasePointBase = X0Y0_陰嚢.ToLocal(X0Y0_陰茎.ToGlobal(X0Y0_陰茎.JP[3].Joint));
    		X0Y1_陰嚢.BasePointBase = X0Y1_陰嚢.ToLocal(X0Y1_陰茎.ToGlobal(X0Y1_陰茎.JP[3].Joint));
    		X0Y2_陰嚢.BasePointBase = X0Y2_陰嚢.ToLocal(X0Y2_陰茎.ToGlobal(X0Y2_陰茎.JP[3].Joint));
    		X0Y3_陰嚢.BasePointBase = X0Y3_陰嚢.ToLocal(X0Y3_陰茎.ToGlobal(X0Y3_陰茎.JP[3].Joint));
    		X0Y4_陰嚢.BasePointBase = X0Y4_陰嚢.ToLocal(X0Y4_陰茎.ToGlobal(X0Y4_陰茎.JP[3].Joint));
    		X1Y0_陰嚢.BasePointBase = X1Y0_陰嚢.ToLocal(X1Y0_陰茎.ToGlobal(X1Y0_陰茎.JP[3].Joint));
    		X1Y1_陰嚢.BasePointBase = X1Y1_陰嚢.ToLocal(X1Y1_陰茎.ToGlobal(X1Y1_陰茎.JP[3].Joint));
    		X1Y2_陰嚢.BasePointBase = X1Y2_陰嚢.ToLocal(X1Y2_陰茎.ToGlobal(X1Y2_陰茎.JP[2].Joint));
    		X1Y3_陰嚢.BasePointBase = X1Y3_陰嚢.ToLocal(X1Y3_陰茎.ToGlobal(X1Y3_陰茎.JP[2].Joint));
    		X1Y4_陰嚢.BasePointBase = X1Y4_陰嚢.ToLocal(X1Y4_陰茎.ToGlobal(X1Y4_陰茎.JP[2].Joint));
    		Vector2D position = AreM.GetPosition(ref AreM.BasePoint);
    		foreach (ShapePart item in Body.EnumJoinRoot)
    		{
    			item.PositionBase = position;
    		}
    		Body.JoinPAall();
    		尺度B *= 1.07;
    		尺度B = 1.08;
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		AreM.Dispose();
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		AreM.Clear();
    		Body.Draw(AreM);
    		Are.Draw(AreM);
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexX == 0)
    		{
    			switch (Body.IndexY)
    			{
    			case 0:
    				X0Y0_陰嚢CP.Update();
    				X0Y0_陰茎CP.Update();
    				X0Y0_血管下CP.Update();
    				X0Y0_血管上CP.Update();
    				X0Y0_亀頭CP.Update();
    				break;
    			case 1:
    				X0Y1_陰嚢CP.Update();
    				X0Y1_陰茎CP.Update();
    				X0Y1_血管下CP.Update();
    				X0Y1_血管上CP.Update();
    				X0Y1_亀頭CP.Update();
    				break;
    			case 2:
    				X0Y2_陰嚢CP.Update();
    				X0Y2_陰茎CP.Update();
    				X0Y2_血管下CP.Update();
    				X0Y2_血管上CP.Update();
    				X0Y2_亀頭CP.Update();
    				break;
    			case 3:
    				X0Y3_陰嚢CP.Update();
    				X0Y3_陰茎CP.Update();
    				X0Y3_血管下CP.Update();
    				X0Y3_血管上CP.Update();
    				X0Y3_亀頭CP.Update();
    				break;
    			default:
    				X0Y4_陰嚢CP.Update();
    				X0Y4_陰茎CP.Update();
    				X0Y4_血管下CP.Update();
    				X0Y4_血管上CP.Update();
    				X0Y4_亀頭CP.Update();
    				break;
    			}
    		}
    		else
    		{
    			switch (Body.IndexY)
    			{
    			case 0:
    				X1Y0_陰嚢CP.Update();
    				X1Y0_陰茎CP.Update();
    				X1Y0_血管下CP.Update();
    				X1Y0_血管上CP.Update();
    				X1Y0_亀頭CP.Update();
    				break;
    			case 1:
    				X1Y1_陰嚢CP.Update();
    				X1Y1_陰茎CP.Update();
    				X1Y1_血管下CP.Update();
    				X1Y1_血管上CP.Update();
    				X1Y1_亀頭CP.Update();
    				break;
    			case 2:
    				X1Y2_陰嚢CP.Update();
    				X1Y2_陰茎CP.Update();
    				X1Y2_血管下CP.Update();
    				X1Y2_血管上CP.Update();
    				break;
    			case 3:
    				X1Y3_陰嚢CP.Update();
    				X1Y3_陰茎CP.Update();
    				X1Y3_血管下CP.Update();
    				X1Y3_血管上CP.Update();
    				break;
    			default:
    				X1Y4_陰嚢CP.Update();
    				X1Y4_陰茎CP.Update();
    				X1Y4_血管下CP.Update();
    				break;
    			}
    		}
    	}

    	private void 配色(主人公配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(主人公配色 体配色)
    	{
    		陰嚢CD = new ColorD(ref 体配色.肌線, ref 体配色.肌色);
    		陰茎CD = new ColorD(ref 体配色.肌線, ref 体配色.肌色);
    		血管下CD = new ColorD(ref 体配色.肌線, ref 体配色.肌色);
    		血管上CD = new ColorD(ref 体配色.肌線, ref 体配色.肌色);
    		亀頭CD = new ColorD();
    		亀頭CD.線 = 体配色.粘線;
    		亀頭CD.色 = new Color2(ref 体配色.粘膜.Col2, ref Col.Empty);
    	}

    	public void 再配色(主人公配色 体配色)
    	{
    		陰嚢CD.線 = 体配色.粘線;
    		陰嚢CD.色 = 体配色.肌色;
    		陰茎CD.線 = 体配色.粘線;
    		陰茎CD.色 = 体配色.肌色;
    		血管下CD.線 = 体配色.粘線;
    		血管下CD.色 = 体配色.肌色;
    		血管上CD.線 = 体配色.粘線;
    		血管上CD.色 = 体配色.肌色;
    		亀頭CD.線 = 体配色.粘線;
    		亀頭CD.色 = new Color2(ref 体配色.粘膜.Col2, ref Col.Empty);
    	}
    }
}
