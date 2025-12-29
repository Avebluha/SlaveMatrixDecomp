using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 下腕_蝙 : 翼下腕
    {
    	public Par X0Y0_獣翼下腕;

    	public Par X0Y0_竜性_鱗1;

    	public Par X0Y0_竜性_鱗2;

    	public Par X0Y0_竜性_鱗3;

    	public Par X0Y0_竜性_鱗4;

    	public Par X0Y0_竜性_鱗5;

    	public Par X0Y0_竜性_鱗6;

    	public Par X0Y0_竜性_鱗7;

    	public Par X0Y0_竜性_鱗8;

    	public Par X0Y0_竜性_鱗9;

    	public Par X0Y0_竜性_鱗10;

    	public Par X0Y0_竜性_鱗11;

    	public Par X0Y0_竜性_鱗12;

    	public Par X0Y0_竜性_鱗13;

    	public Par X0Y0_腕輪_革;

    	public Par X0Y0_腕輪_金具1;

    	public Par X0Y0_腕輪_金具2;

    	public Par X0Y0_腕輪_金具3;

    	public Par X0Y0_腕輪_金具左;

    	public Par X0Y0_腕輪_金具右;

    	public ColorD 獣翼下腕CD;

    	public ColorD 竜性_鱗1CD;

    	public ColorD 竜性_鱗2CD;

    	public ColorD 竜性_鱗3CD;

    	public ColorD 竜性_鱗4CD;

    	public ColorD 竜性_鱗5CD;

    	public ColorD 竜性_鱗6CD;

    	public ColorD 竜性_鱗7CD;

    	public ColorD 竜性_鱗8CD;

    	public ColorD 竜性_鱗9CD;

    	public ColorD 竜性_鱗10CD;

    	public ColorD 竜性_鱗11CD;

    	public ColorD 竜性_鱗12CD;

    	public ColorD 竜性_鱗13CD;

    	public ColorD 腕輪_革CD;

    	public ColorD 腕輪_金具1CD;

    	public ColorD 腕輪_金具2CD;

    	public ColorD 腕輪_金具3CD;

    	public ColorD 腕輪_金具左CD;

    	public ColorD 腕輪_金具右CD;

    	public ColorP X0Y0_獣翼下腕CP;

    	public ColorP X0Y0_竜性_鱗1CP;

    	public ColorP X0Y0_竜性_鱗2CP;

    	public ColorP X0Y0_竜性_鱗3CP;

    	public ColorP X0Y0_竜性_鱗4CP;

    	public ColorP X0Y0_竜性_鱗5CP;

    	public ColorP X0Y0_竜性_鱗6CP;

    	public ColorP X0Y0_竜性_鱗7CP;

    	public ColorP X0Y0_竜性_鱗8CP;

    	public ColorP X0Y0_竜性_鱗9CP;

    	public ColorP X0Y0_竜性_鱗10CP;

    	public ColorP X0Y0_竜性_鱗11CP;

    	public ColorP X0Y0_竜性_鱗12CP;

    	public ColorP X0Y0_竜性_鱗13CP;

    	public ColorP X0Y0_腕輪_革CP;

    	public ColorP X0Y0_腕輪_金具1CP;

    	public ColorP X0Y0_腕輪_金具2CP;

    	public ColorP X0Y0_腕輪_金具3CP;

    	public ColorP X0Y0_腕輪_金具左CP;

    	public ColorP X0Y0_腕輪_金具右CP;

    	public 拘束鎖 鎖1;

    	public Ele[] 腕輪_接続;

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
    			腕輪表示 = 拘束_;
    		}
    	}

    	public bool 獣翼下腕_表示
    	{
    		get
    		{
    			return X0Y0_獣翼下腕.Dra;
    		}
    		set
    		{
    			X0Y0_獣翼下腕.Dra = value;
    			X0Y0_獣翼下腕.Hit = value;
    		}
    	}

    	public bool 竜性_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗1.Dra = value;
    			X0Y0_竜性_鱗1.Hit = value;
    		}
    	}

    	public bool 竜性_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗2.Dra = value;
    			X0Y0_竜性_鱗2.Hit = value;
    		}
    	}

    	public bool 竜性_鱗3_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗3.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗3.Dra = value;
    			X0Y0_竜性_鱗3.Hit = value;
    		}
    	}

    	public bool 竜性_鱗4_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗4.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗4.Dra = value;
    			X0Y0_竜性_鱗4.Hit = value;
    		}
    	}

    	public bool 竜性_鱗5_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗5.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗5.Dra = value;
    			X0Y0_竜性_鱗5.Hit = value;
    		}
    	}

    	public bool 竜性_鱗6_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗6.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗6.Dra = value;
    			X0Y0_竜性_鱗6.Hit = value;
    		}
    	}

    	public bool 竜性_鱗7_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗7.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗7.Dra = value;
    			X0Y0_竜性_鱗7.Hit = value;
    		}
    	}

    	public bool 竜性_鱗8_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗8.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗8.Dra = value;
    			X0Y0_竜性_鱗8.Hit = value;
    		}
    	}

    	public bool 竜性_鱗9_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗9.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗9.Dra = value;
    			X0Y0_竜性_鱗9.Hit = value;
    		}
    	}

    	public bool 竜性_鱗10_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗10.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗10.Dra = value;
    			X0Y0_竜性_鱗10.Hit = value;
    		}
    	}

    	public bool 竜性_鱗11_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗11.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗11.Dra = value;
    			X0Y0_竜性_鱗11.Hit = value;
    		}
    	}

    	public bool 竜性_鱗12_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗12.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗12.Dra = value;
    			X0Y0_竜性_鱗12.Hit = value;
    		}
    	}

    	public bool 竜性_鱗13_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗13.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗13.Dra = value;
    			X0Y0_竜性_鱗13.Hit = value;
    		}
    	}

    	public bool 腕輪_革_表示
    	{
    		get
    		{
    			return X0Y0_腕輪_革.Dra;
    		}
    		set
    		{
    			X0Y0_腕輪_革.Dra = value;
    			X0Y0_腕輪_革.Hit = value;
    		}
    	}

    	public bool 腕輪_金具1_表示
    	{
    		get
    		{
    			return X0Y0_腕輪_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_腕輪_金具1.Dra = value;
    			X0Y0_腕輪_金具1.Hit = value;
    		}
    	}

    	public bool 腕輪_金具2_表示
    	{
    		get
    		{
    			return X0Y0_腕輪_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_腕輪_金具2.Dra = value;
    			X0Y0_腕輪_金具2.Hit = value;
    		}
    	}

    	public bool 腕輪_金具3_表示
    	{
    		get
    		{
    			return X0Y0_腕輪_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_腕輪_金具3.Dra = value;
    			X0Y0_腕輪_金具3.Hit = value;
    		}
    	}

    	public bool 腕輪_金具左_表示
    	{
    		get
    		{
    			return X0Y0_腕輪_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_腕輪_金具左.Dra = value;
    			X0Y0_腕輪_金具左.Hit = value;
    		}
    	}

    	public bool 腕輪_金具右_表示
    	{
    		get
    		{
    			return X0Y0_腕輪_金具右.Dra;
    		}
    		set
    		{
    			X0Y0_腕輪_金具右.Dra = value;
    			X0Y0_腕輪_金具右.Hit = value;
    		}
    	}

    	public bool 腕輪表示
    	{
    		get
    		{
    			return 腕輪_革_表示;
    		}
    		set
    		{
    			腕輪_革_表示 = value;
    			腕輪_金具1_表示 = value;
    			腕輪_金具2_表示 = value;
    			腕輪_金具3_表示 = value;
    			腕輪_金具左_表示 = value;
    			腕輪_金具右_表示 = value;
    		}
    	}

    	public bool 鎖表示
    	{
    		get
    		{
    			return 鎖1.表示;
    		}
    		set
    		{
    			鎖1.表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 獣翼下腕_表示;
    		}
    		set
    		{
    			獣翼下腕_表示 = value;
    			竜性_鱗1_表示 = value;
    			竜性_鱗2_表示 = value;
    			竜性_鱗3_表示 = value;
    			竜性_鱗4_表示 = value;
    			竜性_鱗5_表示 = value;
    			竜性_鱗6_表示 = value;
    			竜性_鱗7_表示 = value;
    			竜性_鱗8_表示 = value;
    			竜性_鱗9_表示 = value;
    			竜性_鱗10_表示 = value;
    			竜性_鱗11_表示 = value;
    			竜性_鱗12_表示 = value;
    			竜性_鱗13_表示 = value;
    			腕輪_革_表示 = value;
    			腕輪_金具1_表示 = value;
    			腕輪_金具2_表示 = value;
    			腕輪_金具3_表示 = value;
    			腕輪_金具左_表示 = value;
    			腕輪_金具右_表示 = value;
    			鎖1.表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 獣翼下腕CD.不透明度;
    		}
    		set
    		{
    			獣翼下腕CD.不透明度 = value;
    			竜性_鱗1CD.不透明度 = value;
    			竜性_鱗2CD.不透明度 = value;
    			竜性_鱗3CD.不透明度 = value;
    			竜性_鱗4CD.不透明度 = value;
    			竜性_鱗5CD.不透明度 = value;
    			竜性_鱗6CD.不透明度 = value;
    			竜性_鱗7CD.不透明度 = value;
    			竜性_鱗8CD.不透明度 = value;
    			竜性_鱗9CD.不透明度 = value;
    			竜性_鱗10CD.不透明度 = value;
    			竜性_鱗11CD.不透明度 = value;
    			竜性_鱗12CD.不透明度 = value;
    			竜性_鱗13CD.不透明度 = value;
    			腕輪_革CD.不透明度 = value;
    			腕輪_金具1CD.不透明度 = value;
    			腕輪_金具2CD.不透明度 = value;
    			腕輪_金具3CD.不透明度 = value;
    			腕輪_金具左CD.不透明度 = value;
    			腕輪_金具右CD.不透明度 = value;
    		}
    	}

    	public override double 展開
    	{
    		set
    		{
    			double num = value.Inverse();
    			double num2 = (右 ? (-1.0) : 1.0);
    			X0Y0_獣翼下腕.AngleCont = num2 * 120.0 * num;
    		}
    	}

    	public bool 下部_外線
    	{
    		get
    		{
    			return X0Y0_獣翼下腕.OP[(!右) ? 1 : 2].Outline;
    		}
    		set
    		{
    			X0Y0_獣翼下腕.OP[(!右) ? 1 : 2].Outline = value;
    		}
    	}

    	public override bool 肘部_外線
    	{
    		get
    		{
    			return X0Y0_獣翼下腕.OP[右 ? 3 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_獣翼下腕.OP[右 ? 3 : 0].Outline = value;
    		}
    	}

    	public JointS 手_接続点 => new JointS(本体, X0Y0_獣翼下腕, 0);

    	public JointS 腕輪_接続点 => new JointS(本体, X0Y0_獣翼下腕, 2);

    	public JointS 鎖1_接続点 => new JointS(本体, X0Y0_腕輪_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(本体, X0Y0_腕輪_金具右, 0);

    	public 下腕_蝙(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 下腕_蝙D e)
    	{
    		下腕_蝙 下腕_蝙2 = this;
    		ThisType = GetType();
    		本体 = new Difs(Sta.腕左["獣翼下腕"]);
    		Pars pars = 本体[0][0];
    		X0Y0_獣翼下腕 = pars["獣翼下腕"].ToPar();
    		Pars pars2 = pars["鱗"].ToPars();
    		X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
    		X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
    		X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
    		X0Y0_竜性_鱗5 = pars2["鱗5"].ToPar();
    		X0Y0_竜性_鱗6 = pars2["鱗6"].ToPar();
    		X0Y0_竜性_鱗7 = pars2["鱗7"].ToPar();
    		X0Y0_竜性_鱗8 = pars2["鱗8"].ToPar();
    		X0Y0_竜性_鱗9 = pars2["鱗9"].ToPar();
    		X0Y0_竜性_鱗10 = pars2["鱗10"].ToPar();
    		X0Y0_竜性_鱗11 = pars2["鱗11"].ToPar();
    		X0Y0_竜性_鱗12 = pars2["鱗12"].ToPar();
    		X0Y0_竜性_鱗13 = pars2["鱗13"].ToPar();
    		pars2 = pars["腕輪"].ToPars();
    		X0Y0_腕輪_革 = pars2["革"].ToPar();
    		X0Y0_腕輪_金具1 = pars2["金具1"].ToPar();
    		X0Y0_腕輪_金具2 = pars2["金具2"].ToPar();
    		X0Y0_腕輪_金具3 = pars2["金具3"].ToPar();
    		X0Y0_腕輪_金具左 = pars2["金具左"].ToPar();
    		X0Y0_腕輪_金具右 = pars2["金具右"].ToPar();
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
    		獣翼下腕_表示 = e.獣翼下腕_表示;
    		竜性_鱗1_表示 = e.竜性_鱗1_表示;
    		竜性_鱗2_表示 = e.竜性_鱗2_表示;
    		竜性_鱗3_表示 = e.竜性_鱗3_表示;
    		竜性_鱗4_表示 = e.竜性_鱗4_表示;
    		竜性_鱗5_表示 = e.竜性_鱗5_表示;
    		竜性_鱗6_表示 = e.竜性_鱗6_表示;
    		竜性_鱗7_表示 = e.竜性_鱗7_表示;
    		竜性_鱗8_表示 = e.竜性_鱗8_表示;
    		竜性_鱗9_表示 = e.竜性_鱗9_表示;
    		竜性_鱗10_表示 = e.竜性_鱗10_表示;
    		竜性_鱗11_表示 = e.竜性_鱗11_表示;
    		竜性_鱗12_表示 = e.竜性_鱗12_表示;
    		竜性_鱗13_表示 = e.竜性_鱗13_表示;
    		腕輪_革_表示 = e.腕輪_革_表示;
    		腕輪_金具1_表示 = e.腕輪_金具1_表示;
    		腕輪_金具2_表示 = e.腕輪_金具2_表示;
    		腕輪_金具3_表示 = e.腕輪_金具3_表示;
    		腕輪_金具左_表示 = e.腕輪_金具左_表示;
    		腕輪_金具右_表示 = e.腕輪_金具右_表示;
    		腕輪表示 = e.腕輪表示;
    		展開 = e.展開;
    		下部_外線 = e.下部_外線;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Ele f;
    		if (e.手_接続.Count > 0)
    		{
    			手_接続 = e.手_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 下腕_蝙2;
    				f.ConnectionType = ConnectionInfo.下腕_蝙_手_接続;
    				f.接続(下腕_蝙2.手_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.腕輪_接続.Count > 0)
    		{
    			腕輪_接続 = e.腕輪_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 下腕_蝙2;
    				f.ConnectionType = ConnectionInfo.下腕_蝙_腕輪_接続;
    				f.接続(下腕_蝙2.腕輪_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_獣翼下腕CP = new ColorP(X0Y0_獣翼下腕, 獣翼下腕CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗1CP = new ColorP(X0Y0_竜性_鱗1, 竜性_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗2CP = new ColorP(X0Y0_竜性_鱗2, 竜性_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗3CP = new ColorP(X0Y0_竜性_鱗3, 竜性_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗4CP = new ColorP(X0Y0_竜性_鱗4, 竜性_鱗4CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗5CP = new ColorP(X0Y0_竜性_鱗5, 竜性_鱗5CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗6CP = new ColorP(X0Y0_竜性_鱗6, 竜性_鱗6CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗7CP = new ColorP(X0Y0_竜性_鱗7, 竜性_鱗7CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗8CP = new ColorP(X0Y0_竜性_鱗8, 竜性_鱗8CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗9CP = new ColorP(X0Y0_竜性_鱗9, 竜性_鱗9CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗10CP = new ColorP(X0Y0_竜性_鱗10, 竜性_鱗10CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗11CP = new ColorP(X0Y0_竜性_鱗11, 竜性_鱗11CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗12CP = new ColorP(X0Y0_竜性_鱗12, 竜性_鱗12CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗13CP = new ColorP(X0Y0_竜性_鱗13, 竜性_鱗13CD, DisUnit, abj: true);
    		X0Y0_腕輪_革CP = new ColorP(X0Y0_腕輪_革, 腕輪_革CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具1CP = new ColorP(X0Y0_腕輪_金具1, 腕輪_金具1CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具2CP = new ColorP(X0Y0_腕輪_金具2, 腕輪_金具2CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具3CP = new ColorP(X0Y0_腕輪_金具3, 腕輪_金具3CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具左CP = new ColorP(X0Y0_腕輪_金具左, 腕輪_金具左CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具右CP = new ColorP(X0Y0_腕輪_金具右, 腕輪_金具右CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    		尺度B = 1.02;
    		鎖1 = new 拘束鎖(DisUnit, 右: false, 配色指定, 体配色, Xasix);
    		鎖1.接続(鎖1_接続点);
    		鎖表示 = e.鎖表示;
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_獣翼下腕.AngleBase = num * -322.0;
    		本体.JoinPAall();
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_獣翼下腕);
    		Are.Draw(X0Y0_竜性_鱗1);
    		Are.Draw(X0Y0_竜性_鱗2);
    		Are.Draw(X0Y0_竜性_鱗3);
    		Are.Draw(X0Y0_竜性_鱗4);
    		Are.Draw(X0Y0_竜性_鱗5);
    		Are.Draw(X0Y0_竜性_鱗6);
    		Are.Draw(X0Y0_竜性_鱗7);
    		Are.Draw(X0Y0_竜性_鱗8);
    		Are.Draw(X0Y0_竜性_鱗9);
    		Are.Draw(X0Y0_竜性_鱗10);
    		Are.Draw(X0Y0_竜性_鱗11);
    		Are.Draw(X0Y0_竜性_鱗12);
    		Are.Draw(X0Y0_竜性_鱗13);
    	}

    	public void 腕輪描画(RenderArea Are)
    	{
    		Are.Draw(X0Y0_腕輪_革);
    		Are.Draw(X0Y0_腕輪_金具1);
    		Are.Draw(X0Y0_腕輪_金具2);
    		Are.Draw(X0Y0_腕輪_金具3);
    		Are.Draw(X0Y0_腕輪_金具左);
    		Are.Draw(X0Y0_腕輪_金具右);
    		鎖1.描画0(Are);
    	}

    	public override bool Is革(Par p)
    	{
    		if (p != X0Y0_腕輪_革 && p != X0Y0_腕輪_金具1 && p != X0Y0_腕輪_金具2 && p != X0Y0_腕輪_金具3 && p != X0Y0_腕輪_金具左)
    		{
    			return p == X0Y0_腕輪_金具右;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_獣翼下腕CP.Update();
    		X0Y0_竜性_鱗1CP.Update();
    		X0Y0_竜性_鱗2CP.Update();
    		X0Y0_竜性_鱗3CP.Update();
    		X0Y0_竜性_鱗4CP.Update();
    		X0Y0_竜性_鱗5CP.Update();
    		X0Y0_竜性_鱗6CP.Update();
    		X0Y0_竜性_鱗7CP.Update();
    		X0Y0_竜性_鱗8CP.Update();
    		X0Y0_竜性_鱗9CP.Update();
    		X0Y0_竜性_鱗10CP.Update();
    		X0Y0_竜性_鱗11CP.Update();
    		X0Y0_竜性_鱗12CP.Update();
    		X0Y0_竜性_鱗13CP.Update();
    		X0Y0_腕輪_革CP.Update();
    		X0Y0_腕輪_金具1CP.Update();
    		X0Y0_腕輪_金具2CP.Update();
    		X0Y0_腕輪_金具3CP.Update();
    		X0Y0_腕輪_金具左CP.Update();
    		X0Y0_腕輪_金具右CP.Update();
    		鎖1.接続PA();
    		鎖1.色更新();
    	}

    	private void 配色(体配色 体配色)
    	{
    		switch (配色指定)
    		{
    		case 配色指定.N0:
    			配色N0(体配色);
    			break;
    		case 配色指定.T0:
    			配色T0(体配色);
    			break;
    		case 配色指定.T1:
    			配色T1(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		獣翼下腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗10CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗11CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗12CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗13CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		獣翼下腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗10CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗11CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗12CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗13CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		獣翼下腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗10CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗11CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗12CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗13CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	public void 腕輪配色(拘束具色 配色)
    	{
    		腕輪_革CD.色 = 配色.革部色;
    		腕輪_金具1CD.色 = 配色.金具色;
    		腕輪_金具2CD.色 = 腕輪_金具1CD.色;
    		腕輪_金具3CD.色 = 腕輪_金具1CD.色;
    		腕輪_金具左CD.色 = 腕輪_金具1CD.色;
    		腕輪_金具右CD.色 = 腕輪_金具1CD.色;
    	}

    	public void 鎖配色(鎖色 配色)
    	{
    		鎖1.配色鎖(配色);
    	}
    }
}
