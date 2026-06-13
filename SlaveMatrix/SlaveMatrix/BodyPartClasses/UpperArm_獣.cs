using _2DGAMELIB;
using System.Linq;

namespace SlaveMatrix
{
    public class UpperArm_獣 : 獣UpperArm
    {
    	public ShapePart X0Y0_筋肉上;

    	public ShapePart X0Y0_UpperArm;

    	public ShapePart X0Y0_筋肉下;

    	public ShapePart X0Y0_虎柄_虎1;

    	public ShapePart X0Y0_虎柄_虎2;

    	public ShapePart X0Y0_竜性_鱗4;

    	public ShapePart X0Y0_竜性_鱗3;

    	public ShapePart X0Y0_竜性_鱗2;

    	public ShapePart X0Y0_竜性_鱗1;

    	public ColorD 筋肉上CD;

    	public ColorD UpperArmCD;

    	public ColorD 筋肉下CD;

    	public ColorD 虎柄_虎1CD;

    	public ColorD 虎柄_虎2CD;

    	public ColorD 竜性_鱗4CD;

    	public ColorD 竜性_鱗3CD;

    	public ColorD 竜性_鱗2CD;

    	public ColorD 竜性_鱗1CD;

    	public ColorP X0Y0_筋肉上CP;

    	public ColorP X0Y0_UpperArmCP;

    	public ColorP X0Y0_筋肉下CP;

    	public ColorP X0Y0_虎柄_虎1CP;

    	public ColorP X0Y0_虎柄_虎2CP;

    	public ColorP X0Y0_竜性_鱗4CP;

    	public ColorP X0Y0_竜性_鱗3CP;

    	public ColorP X0Y0_竜性_鱗2CP;

    	public ColorP X0Y0_竜性_鱗1CP;

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
    			筋肉上_表示 = 筋肉_;
    			筋肉下_表示 = 筋肉_;
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

    	public bool 筋肉上_表示
    	{
    		get
    		{
    			return X0Y0_筋肉上.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉上.Dra = value;
    			X0Y0_筋肉上.Hit = value;
    		}
    	}

    	public bool UpperArm_表示
    	{
    		get
    		{
    			return X0Y0_UpperArm.Dra;
    		}
    		set
    		{
    			X0Y0_UpperArm.Dra = value;
    			X0Y0_UpperArm.Hit = value;
    		}
    	}

    	public bool 筋肉下_表示
    	{
    		get
    		{
    			return X0Y0_筋肉下.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉下.Dra = value;
    			X0Y0_筋肉下.Hit = value;
    		}
    	}

    	public bool 虎柄_虎1_表示
    	{
    		get
    		{
    			return X0Y0_虎柄_虎1.Dra;
    		}
    		set
    		{
    			X0Y0_虎柄_虎1.Dra = value;
    			X0Y0_虎柄_虎1.Hit = value;
    		}
    	}

    	public bool 虎柄_虎2_表示
    	{
    		get
    		{
    			return X0Y0_虎柄_虎2.Dra;
    		}
    		set
    		{
    			X0Y0_虎柄_虎2.Dra = value;
    			X0Y0_虎柄_虎2.Hit = value;
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

    	public override bool 表示
    	{
    		get
    		{
    			return 筋肉上_表示;
    		}
    		set
    		{
    			筋肉上_表示 = value;
    			UpperArm_表示 = value;
    			筋肉下_表示 = value;
    			虎柄_虎1_表示 = value;
    			虎柄_虎2_表示 = value;
    			竜性_鱗4_表示 = value;
    			竜性_鱗3_表示 = value;
    			竜性_鱗2_表示 = value;
    			竜性_鱗1_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 筋肉上CD.不透明度;
    		}
    		set
    		{
    			筋肉上CD.不透明度 = value;
    			UpperArmCD.不透明度 = value;
    			筋肉下CD.不透明度 = value;
    			虎柄_虎1CD.不透明度 = value;
    			虎柄_虎2CD.不透明度 = value;
    			竜性_鱗4CD.不透明度 = value;
    			竜性_鱗3CD.不透明度 = value;
    			竜性_鱗2CD.不透明度 = value;
    			竜性_鱗1CD.不透明度 = value;
    		}
    	}

    	public bool 肘部_外線
    	{
    		get
    		{
    			return X0Y0_UpperArm.OP[(!右) ? 1 : 6].Outline;
    		}
    		set
    		{
    			X0Y0_UpperArm.OP[(!右) ? 1 : 6].Outline = value;
    		}
    	}

    	public JointS LowerArm_接続点 => new JointS(Body, X0Y0_UpperArm, 1);

    	public UpperArm_獣(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, UpperArm_獣D e)
    	{
    		UpperArm_獣 UpperArm_獣2 = this;
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.腕左["四足UpperArm"][0]);
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_筋肉上 = partGroup["筋肉上"].ToPar();
    		X0Y0_UpperArm = partGroup["上腕"].ToPar();
    		X0Y0_筋肉下 = partGroup["筋肉下"].ToPar();
    		PartGroup pars2 = partGroup["虎柄"].ToPars();
    		X0Y0_虎柄_虎1 = pars2["虎1"].ToPar();
    		X0Y0_虎柄_虎2 = pars2["虎2"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
    		X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
    		X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
    		Xasix = false;
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
    		筋肉上_表示 = e.筋肉上_表示;
    		UpperArm_表示 = e.UpperArm_表示;
    		筋肉下_表示 = e.筋肉下_表示;
    		虎柄_虎1_表示 = e.虎柄_虎1_表示;
    		虎柄_虎2_表示 = e.虎柄_虎2_表示;
    		竜性_鱗4_表示 = e.竜性_鱗4_表示;
    		竜性_鱗3_表示 = e.竜性_鱗3_表示;
    		竜性_鱗2_表示 = e.竜性_鱗2_表示;
    		竜性_鱗1_表示 = e.竜性_鱗1_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.LowerArm_接続.Count > 0)
    		{
    			Ele f;
    			LowerArm_接続 = e.LowerArm_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = UpperArm_獣2;
    				f.ConnectionType = ConnectionInfo.UpperArm_獣_LowerArm_接続;
    				f.接続(UpperArm_獣2.LowerArm_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_筋肉上CP = new ColorP(X0Y0_筋肉上, 筋肉上CD, DisUnit, abj: false);
    		X0Y0_UpperArmCP = new ColorP(X0Y0_UpperArm, UpperArmCD, DisUnit, abj: true);
    		X0Y0_筋肉下CP = new ColorP(X0Y0_筋肉下, 筋肉下CD, DisUnit, abj: false);
    		X0Y0_虎柄_虎1CP = new ColorP(X0Y0_虎柄_虎1, 虎柄_虎1CD, DisUnit, abj: true);
    		X0Y0_虎柄_虎2CP = new ColorP(X0Y0_虎柄_虎2, 虎柄_虎2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗4CP = new ColorP(X0Y0_竜性_鱗4, 竜性_鱗4CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗3CP = new ColorP(X0Y0_竜性_鱗3, 竜性_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗2CP = new ColorP(X0Y0_竜性_鱗2, 竜性_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗1CP = new ColorP(X0Y0_竜性_鱗1, 竜性_鱗1CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_UpperArm.AngleBase = num * -65.0;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		X0Y0_筋肉上CP.Update();
    		X0Y0_UpperArmCP.Update();
    		X0Y0_筋肉下CP.Update();
    		X0Y0_虎柄_虎1CP.Update();
    		X0Y0_虎柄_虎2CP.Update();
    		X0Y0_竜性_鱗4CP.Update();
    		X0Y0_竜性_鱗3CP.Update();
    		X0Y0_竜性_鱗2CP.Update();
    		X0Y0_竜性_鱗1CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
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

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		UpperArmCD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		虎柄_虎1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		虎柄_虎2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		UpperArmCD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		虎柄_虎1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		虎柄_虎2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		UpperArmCD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		虎柄_虎1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		虎柄_虎2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    	}
    }
}
