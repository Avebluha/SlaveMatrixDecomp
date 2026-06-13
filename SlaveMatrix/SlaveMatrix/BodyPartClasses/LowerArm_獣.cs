using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class LowerArm_獣 : 獣LowerArm
    {
    	public ShapePart X0Y0_LowerArm;

    	public ShapePart X0Y0_筋肉_筋肉下;

    	public ShapePart X0Y0_筋肉_筋肉上;

    	public ShapePart X0Y0_竜性_鱗1;

    	public ShapePart X0Y0_竜性_鱗2;

    	public ShapePart X0Y0_竜性_鱗3;

    	public ShapePart X0Y0_竜性_鱗4;

    	public ShapePart X0Y0_竜性_鱗5;

    	public ShapePart X0Y0_竜性_鱗6;

    	public ShapePart X0Y0_竜性_鱗7;

    	public ShapePart X0Y0_腕輪_革;

    	public ShapePart X0Y0_腕輪_金具1;

    	public ShapePart X0Y0_腕輪_金具2;

    	public ShapePart X0Y0_腕輪_金具3;

    	public ShapePart X0Y0_腕輪_金具左;

    	public ShapePart X0Y0_腕輪_金具右;

    	public ColorD LowerArmCD;

    	public ColorD 筋肉_筋肉下CD;

    	public ColorD 筋肉_筋肉上CD;

    	public ColorD 竜性_鱗1CD;

    	public ColorD 竜性_鱗2CD;

    	public ColorD 竜性_鱗3CD;

    	public ColorD 竜性_鱗4CD;

    	public ColorD 竜性_鱗5CD;

    	public ColorD 竜性_鱗6CD;

    	public ColorD 竜性_鱗7CD;

    	public ColorD 腕輪_革CD;

    	public ColorD 腕輪_金具1CD;

    	public ColorD 腕輪_金具2CD;

    	public ColorD 腕輪_金具3CD;

    	public ColorD 腕輪_金具左CD;

    	public ColorD 腕輪_金具右CD;

    	public ColorP X0Y0_LowerArmCP;

    	public ColorP X0Y0_筋肉_筋肉下CP;

    	public ColorP X0Y0_筋肉_筋肉上CP;

    	public ColorP X0Y0_竜性_鱗1CP;

    	public ColorP X0Y0_竜性_鱗2CP;

    	public ColorP X0Y0_竜性_鱗3CP;

    	public ColorP X0Y0_竜性_鱗4CP;

    	public ColorP X0Y0_竜性_鱗5CP;

    	public ColorP X0Y0_竜性_鱗6CP;

    	public ColorP X0Y0_竜性_鱗7CP;

    	public ColorP X0Y0_腕輪_革CP;

    	public ColorP X0Y0_腕輪_金具1CP;

    	public ColorP X0Y0_腕輪_金具2CP;

    	public ColorP X0Y0_腕輪_金具3CP;

    	public ColorP X0Y0_腕輪_金具左CP;

    	public ColorP X0Y0_腕輪_金具右CP;

    	public 拘束鎖 鎖1;

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
    			腕輪表示 = 拘束_;
    		}
    	}

    	public bool LowerArm_表示
    	{
    		get
    		{
    			return X0Y0_LowerArm.Dra;
    		}
    		set
    		{
    			X0Y0_LowerArm.Dra = value;
    			X0Y0_LowerArm.Hit = value;
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
    			return LowerArm_表示;
    		}
    		set
    		{
    			LowerArm_表示 = value;
    			筋肉_筋肉下_表示 = value;
    			筋肉_筋肉上_表示 = value;
    			竜性_鱗1_表示 = value;
    			竜性_鱗2_表示 = value;
    			竜性_鱗3_表示 = value;
    			竜性_鱗4_表示 = value;
    			竜性_鱗5_表示 = value;
    			竜性_鱗6_表示 = value;
    			竜性_鱗7_表示 = value;
    			腕輪_革_表示 = value;
    			腕輪_金具1_表示 = value;
    			腕輪_金具2_表示 = value;
    			腕輪_金具3_表示 = value;
    			腕輪_金具左_表示 = value;
    			腕輪_金具右_表示 = value;
    			鎖1.表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return LowerArmCD.不透明度;
    		}
    		set
    		{
    			LowerArmCD.不透明度 = value;
    			筋肉_筋肉下CD.不透明度 = value;
    			筋肉_筋肉上CD.不透明度 = value;
    			竜性_鱗1CD.不透明度 = value;
    			竜性_鱗2CD.不透明度 = value;
    			竜性_鱗3CD.不透明度 = value;
    			竜性_鱗4CD.不透明度 = value;
    			竜性_鱗5CD.不透明度 = value;
    			竜性_鱗6CD.不透明度 = value;
    			竜性_鱗7CD.不透明度 = value;
    			腕輪_革CD.不透明度 = value;
    			腕輪_金具1CD.不透明度 = value;
    			腕輪_金具2CD.不透明度 = value;
    			腕輪_金具3CD.不透明度 = value;
    			腕輪_金具左CD.不透明度 = value;
    			腕輪_金具右CD.不透明度 = value;
    		}
    	}

    	public override bool 肘部_外線
    	{
    		get
    		{
    			return X0Y0_LowerArm.OP[右 ? 6 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_LowerArm.OP[右 ? 6 : 0].Outline = value;
    		}
    	}

    	public JointS 手_接続点 => new JointS(Body, X0Y0_LowerArm, 2);

    	public JointS 鎖1_接続点 => new JointS(Body, X0Y0_腕輪_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(Body, X0Y0_腕輪_金具右, 0);

    	public LowerArm_獣(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, LowerArm_獣D e)
    	{
    		LowerArm_獣 LowerArm_獣2 = this;
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(GlobalState.腕左["四足LowerArm"][0]);
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_LowerArm = partGroup["下腕"].ToPar();
    		PartGroup pars2 = partGroup["筋肉"].ToPars();
    		X0Y0_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
    		X0Y0_筋肉_筋肉上 = pars2["筋肉上"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
    		X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
    		X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
    		X0Y0_竜性_鱗5 = pars2["鱗5"].ToPar();
    		X0Y0_竜性_鱗6 = pars2["鱗6"].ToPar();
    		X0Y0_竜性_鱗7 = pars2["鱗7"].ToPar();
    		pars2 = partGroup["腕輪"].ToPars();
    		X0Y0_腕輪_革 = pars2["革"].ToPar();
    		X0Y0_腕輪_金具1 = pars2["金具1"].ToPar();
    		X0Y0_腕輪_金具2 = pars2["金具2"].ToPar();
    		X0Y0_腕輪_金具3 = pars2["金具3"].ToPar();
    		X0Y0_腕輪_金具左 = pars2["金具左"].ToPar();
    		X0Y0_腕輪_金具右 = pars2["金具右"].ToPar();
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
    		LowerArm_表示 = e.LowerArm_表示;
    		筋肉_筋肉下_表示 = e.筋肉_筋肉下_表示;
    		筋肉_筋肉上_表示 = e.筋肉_筋肉上_表示;
    		竜性_鱗1_表示 = e.竜性_鱗1_表示;
    		竜性_鱗2_表示 = e.竜性_鱗2_表示;
    		竜性_鱗3_表示 = e.竜性_鱗3_表示;
    		竜性_鱗4_表示 = e.竜性_鱗4_表示;
    		竜性_鱗5_表示 = e.竜性_鱗5_表示;
    		竜性_鱗6_表示 = e.竜性_鱗6_表示;
    		竜性_鱗7_表示 = e.竜性_鱗7_表示;
    		腕輪_革_表示 = e.腕輪_革_表示;
    		腕輪_金具1_表示 = e.腕輪_金具1_表示;
    		腕輪_金具2_表示 = e.腕輪_金具2_表示;
    		腕輪_金具3_表示 = e.腕輪_金具3_表示;
    		腕輪_金具左_表示 = e.腕輪_金具左_表示;
    		腕輪_金具右_表示 = e.腕輪_金具右_表示;
    		腕輪表示 = e.腕輪表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.手_接続.Count > 0)
    		{
    			Element f;
    			手_接続 = e.手_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = LowerArm_獣2;
    				f.ConnectionType = ConnectionInfo.LowerArm_獣_手_接続;
    				f.接続(LowerArm_獣2.手_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_LowerArmCP = new ColorP(X0Y0_LowerArm, LowerArmCD, DisUnit, abj: true);
    		X0Y0_筋肉_筋肉下CP = new ColorP(X0Y0_筋肉_筋肉下, 筋肉_筋肉下CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉上CP = new ColorP(X0Y0_筋肉_筋肉上, 筋肉_筋肉上CD, DisUnit, abj: false);
    		X0Y0_竜性_鱗1CP = new ColorP(X0Y0_竜性_鱗1, 竜性_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗2CP = new ColorP(X0Y0_竜性_鱗2, 竜性_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗3CP = new ColorP(X0Y0_竜性_鱗3, 竜性_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗4CP = new ColorP(X0Y0_竜性_鱗4, 竜性_鱗4CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗5CP = new ColorP(X0Y0_竜性_鱗5, 竜性_鱗5CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗6CP = new ColorP(X0Y0_竜性_鱗6, 竜性_鱗6CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗7CP = new ColorP(X0Y0_竜性_鱗7, 竜性_鱗7CD, DisUnit, abj: true);
    		X0Y0_腕輪_革CP = new ColorP(X0Y0_腕輪_革, 腕輪_革CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具1CP = new ColorP(X0Y0_腕輪_金具1, 腕輪_金具1CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具2CP = new ColorP(X0Y0_腕輪_金具2, 腕輪_金具2CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具3CP = new ColorP(X0Y0_腕輪_金具3, 腕輪_金具3CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具左CP = new ColorP(X0Y0_腕輪_金具左, 腕輪_金具左CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具右CP = new ColorP(X0Y0_腕輪_金具右, 腕輪_金具右CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		鎖1 = new 拘束鎖(DisUnit, 右: false, 配色指定, 体配色, Xasix);
    		鎖1.接続(鎖1_接続点);
    		int num = (右 ? (-20) : 20);
    		鎖1.角度B += num;
    		鎖表示 = e.鎖表示;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Body.Draw(Are);
    		鎖1.描画0(Are);
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_LowerArm.AngleBase = num * 133.0;
    		Body.JoinPAall();
    	}

    	public override bool Is革(ShapePart p)
    	{
    		if (p != X0Y0_腕輪_革 && p != X0Y0_腕輪_金具1 && p != X0Y0_腕輪_金具2 && p != X0Y0_腕輪_金具3 && p != X0Y0_腕輪_金具左)
    		{
    			return p == X0Y0_腕輪_金具右;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_LowerArmCP.Update();
    		X0Y0_筋肉_筋肉下CP.Update();
    		X0Y0_筋肉_筋肉上CP.Update();
    		X0Y0_竜性_鱗1CP.Update();
    		X0Y0_竜性_鱗2CP.Update();
    		X0Y0_竜性_鱗3CP.Update();
    		X0Y0_竜性_鱗4CP.Update();
    		X0Y0_竜性_鱗5CP.Update();
    		X0Y0_竜性_鱗6CP.Update();
    		X0Y0_竜性_鱗7CP.Update();
    		X0Y0_腕輪_革CP.Update();
    		X0Y0_腕輪_金具1CP.Update();
    		X0Y0_腕輪_金具2CP.Update();
    		X0Y0_腕輪_金具3CP.Update();
    		X0Y0_腕輪_金具左CP.Update();
    		X0Y0_腕輪_金具右CP.Update();
    		鎖1.接続PA();
    		鎖1.色更新();
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
    		LowerArmCD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		竜性_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗5CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗6CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗7CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		LowerArmCD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		竜性_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗5CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗6CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗7CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		LowerArmCD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		竜性_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗5CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗6CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗7CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
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
