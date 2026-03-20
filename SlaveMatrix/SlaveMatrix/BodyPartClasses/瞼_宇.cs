using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 瞼_宇 : 双瞼
    {
    	public Par X0Y0_目;

    	public Par X0Y0_ハイライト;

    	public Par X0Y0_瞬膜;

    	public Par X0Y1_目;

    	public Par X0Y1_ハイライト;

    	public Par X0Y1_瞬膜;

    	public Par X0Y2_目;

    	public Par X0Y2_ハイライト;

    	public Par X0Y2_瞬膜;

    	public Par X0Y3_目;

    	public Par X0Y3_ハイライト;

    	public Par X0Y3_瞬膜;

    	public Par X0Y4_目;

    	public Par X0Y4_ハイライト;

    	public Par X0Y4_瞬膜;

    	public ColorD 目CD;

    	public ColorD ハイライトCD;

    	public ColorD 瞬膜CD;

    	public ColorP X0Y0_目CP;

    	public ColorP X0Y0_ハイライトCP;

    	public ColorP X0Y0_瞬膜CP;

    	public ColorP X0Y1_目CP;

    	public ColorP X0Y1_ハイライトCP;

    	public ColorP X0Y1_瞬膜CP;

    	public ColorP X0Y2_目CP;

    	public ColorP X0Y2_ハイライトCP;

    	public ColorP X0Y2_瞬膜CP;

    	public ColorP X0Y3_目CP;

    	public ColorP X0Y3_ハイライトCP;

    	public ColorP X0Y3_瞬膜CP;

    	public ColorP X0Y4_目CP;

    	public ColorP X0Y4_ハイライトCP;

    	public ColorP X0Y4_瞬膜CP;

    	public Ele[] 涙_接続;

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

    	public bool 目_表示
    	{
    		get
    		{
    			return X0Y0_目.Dra;
    		}
    		set
    		{
    			X0Y0_目.Dra = value;
    			X0Y1_目.Dra = value;
    			X0Y2_目.Dra = value;
    			X0Y3_目.Dra = value;
    			X0Y4_目.Dra = value;
    			X0Y0_目.Hit = value;
    			X0Y1_目.Hit = value;
    			X0Y2_目.Hit = value;
    			X0Y3_目.Hit = value;
    			X0Y4_目.Hit = value;
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

    	public bool 瞬膜_表示
    	{
    		get
    		{
    			return X0Y0_瞬膜.Dra;
    		}
    		set
    		{
    			X0Y0_瞬膜.Dra = value;
    			X0Y1_瞬膜.Dra = value;
    			X0Y2_瞬膜.Dra = value;
    			X0Y3_瞬膜.Dra = value;
    			X0Y4_瞬膜.Dra = value;
    			X0Y0_瞬膜.Hit = value;
    			X0Y1_瞬膜.Hit = value;
    			X0Y2_瞬膜.Hit = value;
    			X0Y3_瞬膜.Hit = value;
    			X0Y4_瞬膜.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 目_表示;
    		}
    		set
    		{
    			目_表示 = value;
    			ハイライト_表示 = value;
    			瞬膜_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 目CD.不透明度;
    		}
    		set
    		{
    			目CD.不透明度 = value;
    			ハイライトCD.不透明度 = value;
    			瞬膜CD.不透明度 = value;
    		}
    	}

    	public JointS 涙_接続点 => new JointS(Body, X0Y0_目, 2);

    	public 瞼_宇(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 瞼_宇D e)
    	{
    		瞼_宇 瞼_宇2 = this;
    		ThisType = GetType();
    		Body = new Difs(Sta.胴体["エイリアン目左"]);
    		Pars pars = Body[0][0];
    		X0Y0_目 = pars["目"].ToPar();
    		X0Y0_ハイライト = pars["ハイライト"].ToPar();
    		X0Y0_瞬膜 = pars["瞬膜"].ToPar();
    		pars = Body[0][1];
    		X0Y1_目 = pars["目"].ToPar();
    		X0Y1_ハイライト = pars["ハイライト"].ToPar();
    		X0Y1_瞬膜 = pars["瞬膜"].ToPar();
    		pars = Body[0][2];
    		X0Y2_目 = pars["目"].ToPar();
    		X0Y2_ハイライト = pars["ハイライト"].ToPar();
    		X0Y2_瞬膜 = pars["瞬膜"].ToPar();
    		pars = Body[0][3];
    		X0Y3_目 = pars["目"].ToPar();
    		X0Y3_ハイライト = pars["ハイライト"].ToPar();
    		X0Y3_瞬膜 = pars["瞬膜"].ToPar();
    		pars = Body[0][4];
    		X0Y4_目 = pars["目"].ToPar();
    		X0Y4_ハイライト = pars["ハイライト"].ToPar();
    		X0Y4_瞬膜 = pars["瞬膜"].ToPar();
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
    		目_表示 = e.目_表示;
    		ハイライト_表示 = e.ハイライト_表示;
    		瞬膜_表示 = e.瞬膜_表示;
    		base.傾き = e.傾き;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.涙_接続.Count > 0)
    		{
    			Ele f;
    			涙_接続 = e.涙_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 瞼_宇2;
    				f.ConnectionType = ConnectionInfo.瞼_宇_涙_接続;
    				f.接続(瞼_宇2.涙_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_目CP = new ColorP(X0Y0_目, 目CD, DisUnit, abj: true);
    		X0Y0_ハイライトCP = new ColorP(X0Y0_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y0_瞬膜CP = new ColorP(X0Y0_瞬膜, 瞬膜CD, DisUnit, abj: true);
    		X0Y1_目CP = new ColorP(X0Y1_目, 目CD, DisUnit, abj: true);
    		X0Y1_ハイライトCP = new ColorP(X0Y1_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y1_瞬膜CP = new ColorP(X0Y1_瞬膜, 瞬膜CD, DisUnit, abj: true);
    		X0Y2_目CP = new ColorP(X0Y2_目, 目CD, DisUnit, abj: true);
    		X0Y2_ハイライトCP = new ColorP(X0Y2_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y2_瞬膜CP = new ColorP(X0Y2_瞬膜, 瞬膜CD, DisUnit, abj: true);
    		X0Y3_目CP = new ColorP(X0Y3_目, 目CD, DisUnit, abj: true);
    		X0Y3_ハイライトCP = new ColorP(X0Y3_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y3_瞬膜CP = new ColorP(X0Y3_瞬膜, 瞬膜CD, DisUnit, abj: true);
    		X0Y4_目CP = new ColorP(X0Y4_目, 目CD, DisUnit, abj: true);
    		X0Y4_ハイライトCP = new ColorP(X0Y4_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y4_瞬膜CP = new ColorP(X0Y4_瞬膜, 瞬膜CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		switch (Body.IndexY)
    		{
    		case 0:
    			X0Y0_目CP.Update();
    			X0Y0_ハイライトCP.Update();
    			X0Y0_瞬膜CP.Update();
    			break;
    		case 1:
    			X0Y1_目CP.Update();
    			X0Y1_ハイライトCP.Update();
    			X0Y1_瞬膜CP.Update();
    			break;
    		case 2:
    			X0Y2_目CP.Update();
    			X0Y2_ハイライトCP.Update();
    			X0Y2_瞬膜CP.Update();
    			break;
    		case 3:
    			X0Y3_目CP.Update();
    			X0Y3_ハイライトCP.Update();
    			X0Y3_瞬膜CP.Update();
    			break;
    		default:
    			X0Y4_目CP.Update();
    			X0Y4_ハイライトCP.Update();
    			X0Y4_瞬膜CP.Update();
    			break;
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		目CD = new ColorD(ref Col.Black, ref 体配色.目左O);
    		ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		瞬膜CD = new ColorD(ref Col.Black, ref 体配色.白部O);
    	}
    }
}
