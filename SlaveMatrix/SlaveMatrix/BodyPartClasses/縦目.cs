using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 縦目 : Ele
    {
    	public Par X0Y0_白目;

    	public Par X0Y0_黒目_黒目;

    	public Par X0Y0_黒目_瞳孔;

    	public Par X0Y0_黒目_ハート;

    	public Par X0Y0_黒目_ハイライト上;

    	public Par X0Y0_黒目_ハイライト下;

    	public ColorD 白目CD;

    	public ColorD 黒目_黒目CD;

    	public ColorD 黒目_瞳孔CD;

    	public ColorD 黒目_ハートCD;

    	public ColorD 黒目_ハイライト上CD;

    	public ColorD 黒目_ハイライト下CD;

    	public ColorP X0Y0_白目CP;

    	public ColorP X0Y0_黒目_黒目CP;

    	public ColorP X0Y0_黒目_瞳孔CP;

    	public ColorP X0Y0_黒目_ハートCP;

    	public ColorP X0Y0_黒目_ハイライト上CP;

    	public ColorP X0Y0_黒目_ハイライト下CP;

    	public Ele[] 瞼_接続;

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

    	public bool 白目_表示
    	{
    		get
    		{
    			return X0Y0_白目.Dra;
    		}
    		set
    		{
    			X0Y0_白目.Dra = value;
    			X0Y0_白目.Hit = value;
    		}
    	}

    	public bool 黒目_黒目_表示
    	{
    		get
    		{
    			return X0Y0_黒目_黒目.Dra;
    		}
    		set
    		{
    			X0Y0_黒目_黒目.Dra = value;
    			X0Y0_黒目_黒目.Hit = value;
    		}
    	}

    	public bool 黒目_瞳孔_表示
    	{
    		get
    		{
    			return X0Y0_黒目_瞳孔.Dra;
    		}
    		set
    		{
    			X0Y0_黒目_瞳孔.Dra = value;
    			X0Y0_黒目_瞳孔.Hit = value;
    		}
    	}

    	public bool 黒目_ハート_表示
    	{
    		get
    		{
    			return X0Y0_黒目_ハート.Dra;
    		}
    		set
    		{
    			X0Y0_黒目_ハート.Dra = value;
    			X0Y0_黒目_ハート.Hit = value;
    		}
    	}

    	public bool 黒目_ハイライト上_表示
    	{
    		get
    		{
    			return X0Y0_黒目_ハイライト上.Dra;
    		}
    		set
    		{
    			X0Y0_黒目_ハイライト上.Dra = value;
    			X0Y0_黒目_ハイライト上.Hit = value;
    		}
    	}

    	public bool 黒目_ハイライト下_表示
    	{
    		get
    		{
    			return X0Y0_黒目_ハイライト下.Dra;
    		}
    		set
    		{
    			X0Y0_黒目_ハイライト下.Dra = value;
    			X0Y0_黒目_ハイライト下.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 白目_表示;
    		}
    		set
    		{
    			白目_表示 = value;
    			黒目_黒目_表示 = value;
    			黒目_瞳孔_表示 = value;
    			黒目_ハート_表示 = value;
    			黒目_ハイライト上_表示 = value;
    			黒目_ハイライト下_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 白目CD.不透明度;
    		}
    		set
    		{
    			白目CD.不透明度 = value;
    			黒目_黒目CD.不透明度 = value;
    			黒目_瞳孔CD.不透明度 = value;
    			黒目_ハートCD.不透明度 = value;
    			黒目_ハイライト上CD.不透明度 = value;
    			黒目_ハイライト下CD.不透明度 = value;
    		}
    	}

    	public Vector2D 視線
    	{
    		get
    		{
    			return X0Y0_黒目_黒目.PositionCont;
    		}
    		set
    		{
    			X0Y0_黒目_黒目.PositionCont = value;
    			X0Y0_黒目_瞳孔.PositionCont = value;
    			X0Y0_黒目_ハート.PositionCont = value;
    		}
    	}

    	public override double 肥大
    	{
    		set
    		{
    		}
    	}

    	public override double 身長
    	{
    		set
    		{
    		}
    	}

    	public JointS 瞼_接続点 => new JointS(Body, X0Y0_白目, 0);

    	public 縦目(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 縦目D e)
    	{
    		縦目 縦目2 = this;
    		ThisType = GetType();
    		Body = new Difs(Sta.胴体["額目"]);
    		Pars pars = Body[0][0];
    		X0Y0_白目 = pars["白目"].ToPar();
    		Pars pars2 = pars["黒目"].ToPars();
    		X0Y0_黒目_黒目 = pars2["黒目"].ToPar();
    		X0Y0_黒目_瞳孔 = pars2["瞳孔"].ToPar();
    		X0Y0_黒目_ハート = pars2["ハート"].ToPar();
    		X0Y0_黒目_ハイライト上 = pars2["ハイライト上"].ToPar();
    		X0Y0_黒目_ハイライト下 = pars2["ハイライト下"].ToPar();
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
    		白目_表示 = e.白目_表示;
    		黒目_黒目_表示 = e.黒目_黒目_表示;
    		黒目_瞳孔_表示 = e.黒目_瞳孔_表示;
    		黒目_ハート_表示 = e.黒目_ハート_表示;
    		黒目_ハイライト上_表示 = e.黒目_ハイライト上_表示;
    		黒目_ハイライト下_表示 = e.黒目_ハイライト下_表示;
    		if (e.猫目)
    		{
    			猫目();
    		}
    		if (e.蛸目)
    		{
    			蛸目();
    		}
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.瞼_接続.Count > 0)
    		{
    			Ele f;
    			瞼_接続 = e.瞼_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 縦目2;
    				f.ConnectionType = ConnectionInfo.縦目_瞼_接続;
    				f.接続(縦目2.瞼_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_白目CP = new ColorP(X0Y0_白目, 白目CD, DisUnit, abj: true);
    		X0Y0_黒目_黒目CP = new ColorP(X0Y0_黒目_黒目, 黒目_黒目CD, DisUnit, abj: true);
    		X0Y0_黒目_瞳孔CP = new ColorP(X0Y0_黒目_瞳孔, 黒目_瞳孔CD, DisUnit, abj: true);
    		X0Y0_黒目_ハートCP = new ColorP(X0Y0_黒目_ハート, 黒目_ハートCD, DisUnit, abj: true);
    		X0Y0_黒目_ハイライト上CP = new ColorP(X0Y0_黒目_ハイライト上, 黒目_ハイライト上CD, DisUnit, abj: true);
    		X0Y0_黒目_ハイライト下CP = new ColorP(X0Y0_黒目_ハイライト下, 黒目_ハイライト下CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public void 猫目()
    	{
    		X0Y0_黒目_瞳孔.SizeXBase *= 0.25;
    		X0Y0_黒目_瞳孔.SizeYBase *= 1.5;
    	}

    	public void 蛸目()
    	{
    		X0Y0_黒目_瞳孔.SizeXBase *= 2.0;
    		X0Y0_黒目_瞳孔.SizeYBase *= 0.5;
    	}

    	public override void 色更新()
    	{
    		X0Y0_白目CP.Update();
    		X0Y0_黒目_黒目CP.Update();
    		X0Y0_黒目_瞳孔CP.Update();
    		X0Y0_黒目_ハートCP.Update();
    		X0Y0_黒目_ハイライト上CP.Update();
    		X0Y0_黒目_ハイライト下CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		白目CD = new ColorD(ref Col.Empty, ref 体配色.白部O);
    		黒目_黒目CD = new ColorD(ref Col.Black, ref 体配色.縦目O);
    		黒目_瞳孔CD = new ColorD(ref Col.Black, ref 体配色.瞳孔);
    		黒目_ハートCD = new ColorD(ref Col.Empty, ref 体配色.ハートO);
    		黒目_ハイライト上CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		黒目_ハイライト下CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    	}
    }
}
