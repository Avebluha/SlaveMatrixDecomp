using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 下腕_蹄 : 獣下腕
    {
    	public Par X0Y0_下腕;

    	public Par X0Y0_筋肉_筋肉下;

    	public Par X0Y0_筋肉_筋肉上;

    	public ColorD 下腕CD;

    	public ColorD 筋肉_筋肉下CD;

    	public ColorD 筋肉_筋肉上CD;

    	public ColorP X0Y0_下腕CP;

    	public ColorP X0Y0_筋肉_筋肉下CP;

    	public ColorP X0Y0_筋肉_筋肉上CP;

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
    			筋肉_筋肉下_表示 = 筋肉_;
    			筋肉_筋肉上_表示 = 筋肉_;
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

    	public bool 下腕_表示
    	{
    		get
    		{
    			return X0Y0_下腕.Dra;
    		}
    		set
    		{
    			X0Y0_下腕.Dra = value;
    			X0Y0_下腕.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉下_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉下.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉下.Dra = value;
    			X0Y0_筋肉_筋肉下.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉上_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉上.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉上.Dra = value;
    			X0Y0_筋肉_筋肉上.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 下腕_表示;
    		}
    		set
    		{
    			下腕_表示 = value;
    			筋肉_筋肉下_表示 = value;
    			筋肉_筋肉上_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 下腕CD.不透明度;
    		}
    		set
    		{
    			下腕CD.不透明度 = value;
    			筋肉_筋肉下CD.不透明度 = value;
    			筋肉_筋肉上CD.不透明度 = value;
    		}
    	}

    	public override bool 肘部_外線
    	{
    		get
    		{
    			return X0Y0_下腕.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_下腕.OP[右 ? 4 : 0].Outline = value;
    		}
    	}

    	public JointS 手_接続点 => new JointS(本体, X0Y0_下腕, 2);

    	public 下腕_蹄(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 下腕_蹄D e)
    	{
    		下腕_蹄 下腕_蹄2 = this;
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.腕左["四足下腕"][1]);
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars = 本体[0][0];
    		X0Y0_下腕 = pars["下腕"].ToPar();
    		Pars pars2 = pars["筋肉"].ToPars();
    		X0Y0_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
    		X0Y0_筋肉_筋肉上 = pars2["筋肉上"].ToPar();
    		Xasix = false;
    		本体.SetJoints();
    		接続根 = new JointD(本体);
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
    		下腕_表示 = e.下腕_表示;
    		筋肉_筋肉下_表示 = e.筋肉_筋肉下_表示;
    		筋肉_筋肉上_表示 = e.筋肉_筋肉上_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.手_接続.Count > 0)
    		{
    			Ele f;
    			手_接続 = e.手_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 下腕_蹄2;
    				f.ConnectionType = ConnectionInfo.下腕_蹄_手_接続;
    				f.接続(下腕_蹄2.手_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_下腕CP = new ColorP(X0Y0_下腕, 下腕CD, DisUnit, abj: true);
    		X0Y0_筋肉_筋肉下CP = new ColorP(X0Y0_筋肉_筋肉下, 筋肉_筋肉下CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉上CP = new ColorP(X0Y0_筋肉_筋肉上, 筋肉_筋肉上CD, DisUnit, abj: false);
    		濃度 = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_下腕.AngleBase = num * 160.0;
    		本体.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		X0Y0_下腕CP.Update();
    		X0Y0_筋肉_筋肉下CP.Update();
    		X0Y0_筋肉_筋肉上CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		下腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    	}
    }
}
