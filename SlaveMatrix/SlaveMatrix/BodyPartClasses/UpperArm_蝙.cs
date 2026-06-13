using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class UpperArm_蝙 : 翼UpperArm
    {
    	public ShapePart X0Y0_獣翼UpperArm;

    	public ShapePart X0Y0_竜性_鱗1;

    	public ShapePart X0Y0_竜性_鱗2;

    	public ShapePart X0Y0_竜性_鱗3;

    	public ShapePart X0Y0_竜性_鱗4;

    	public ShapePart X0Y0_竜性_鱗5;

    	public ShapePart X0Y0_竜性_鱗6;

    	public 飛膜_根 飛膜;

    	public ColorD 獣翼UpperArmCD;

    	public ColorD 竜性_鱗1CD;

    	public ColorD 竜性_鱗2CD;

    	public ColorD 竜性_鱗3CD;

    	public ColorD 竜性_鱗4CD;

    	public ColorD 竜性_鱗5CD;

    	public ColorD 竜性_鱗6CD;

    	public ColorP X0Y0_獣翼UpperArmCP;

    	public ColorP X0Y0_竜性_鱗1CP;

    	public ColorP X0Y0_竜性_鱗2CP;

    	public ColorP X0Y0_竜性_鱗3CP;

    	public ColorP X0Y0_竜性_鱗4CP;

    	public ColorP X0Y0_竜性_鱗5CP;

    	public ColorP X0Y0_竜性_鱗6CP;

    	public Func<Vector2D> 接着;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    			飛膜.欠損 = value;
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
    			飛膜.筋肉 = value;
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
    			飛膜.筋肉 = value;
    		}
    	}

    	public bool 獣翼UpperArm_表示
    	{
    		get
    		{
    			return X0Y0_獣翼UpperArm.Dra;
    		}
    		set
    		{
    			X0Y0_獣翼UpperArm.Dra = value;
    			X0Y0_獣翼UpperArm.Hit = value;
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

    	public bool 飛膜_表示
    	{
    		get
    		{
    			return 飛膜.飛膜_表示;
    		}
    		set
    		{
    			飛膜.飛膜_表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 獣翼UpperArm_表示;
    		}
    		set
    		{
    			獣翼UpperArm_表示 = value;
    			竜性_鱗1_表示 = value;
    			竜性_鱗2_表示 = value;
    			竜性_鱗3_表示 = value;
    			竜性_鱗4_表示 = value;
    			竜性_鱗5_表示 = value;
    			竜性_鱗6_表示 = value;
    			飛膜_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 獣翼UpperArmCD.不透明度;
    		}
    		set
    		{
    			獣翼UpperArmCD.不透明度 = value;
    			竜性_鱗1CD.不透明度 = value;
    			竜性_鱗2CD.不透明度 = value;
    			竜性_鱗3CD.不透明度 = value;
    			竜性_鱗4CD.不透明度 = value;
    			竜性_鱗5CD.不透明度 = value;
    			竜性_鱗6CD.不透明度 = value;
    			飛膜.飛膜CD.不透明度 = value;
    		}
    	}

    	public override double 展開
    	{
    		set
    		{
    			double num = value.Inverse();
    			double num2 = (右 ? (-1.0) : 1.0);
    			X0Y0_獣翼UpperArm.AngleCont = num2 * -68.0 * num;
    		}
    	}

    	public bool 下部_外線
    	{
    		get
    		{
    			return X0Y0_獣翼UpperArm.OP[右 ? 3 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_獣翼UpperArm.OP[右 ? 3 : 0].Outline = value;
    			X0Y0_獣翼UpperArm.OP[(!右) ? 1 : 2].Outline = value;
    		}
    	}

    	public bool 接部_外線
    	{
    		get
    		{
    			return 飛膜.接部_外線;
    		}
    		set
    		{
    			飛膜.接部_外線 = value;
    		}
    	}

    	public override double 尺度B
    	{
    		get
    		{
    			return base.尺度B;
    		}
    		set
    		{
    			base.尺度B = value;
    			飛膜.尺度B = value;
    		}
    	}

    	public override double 尺度C
    	{
    		get
    		{
    			return base.尺度C;
    		}
    		set
    		{
    			base.尺度C = value;
    			飛膜.尺度C = value;
    		}
    	}

    	public override double 尺度XB
    	{
    		get
    		{
    			return base.尺度XB;
    		}
    		set
    		{
    			base.尺度XB = value;
    			飛膜.尺度XB = value;
    		}
    	}

    	public override double 尺度XC
    	{
    		get
    		{
    			return base.尺度XC;
    		}
    		set
    		{
    			base.尺度XC = value;
    			飛膜.尺度XC = value;
    		}
    	}

    	public override double 尺度YB
    	{
    		get
    		{
    			return base.尺度YB;
    		}
    		set
    		{
    			base.尺度YB = value;
    			飛膜.尺度YB = value;
    		}
    	}

    	public override double 尺度YC
    	{
    		get
    		{
    			return base.尺度YC;
    		}
    		set
    		{
    			base.尺度YC = value;
    			飛膜.尺度YC = value;
    		}
    	}

    	public override double 肥大
    	{
    		set
    		{
    			base.肥大 = value;
    			飛膜.肥大 = value;
    		}
    	}

    	public override double 身長
    	{
    		set
    		{
    			base.身長 = value;
    			飛膜.身長 = value;
    		}
    	}

    	public override bool 右
    	{
    		get
    		{
    			return base.右;
    		}
    		set
    		{
    			base.右 = value;
    			飛膜.右 = value;
    		}
    	}

    	public override bool 反転X
    	{
    		get
    		{
    			return base.反転X;
    		}
    		set
    		{
    			base.反転X = value;
    			飛膜.反転X = value;
    		}
    	}

    	public override bool 反転Y
    	{
    		get
    		{
    			return base.反転Y;
    		}
    		set
    		{
    			base.反転Y = value;
    			飛膜.反転Y = value;
    		}
    	}

    	public override double Xv
    	{
    		get
    		{
    			return base.Xv;
    		}
    		set
    		{
    			base.Xv = value;
    			飛膜.Xv = value;
    		}
    	}

    	public override double Yv
    	{
    		get
    		{
    			return base.Yv;
    		}
    		set
    		{
    			base.Yv = value;
    			飛膜.Yv = value;
    		}
    	}

    	public override int Xi
    	{
    		get
    		{
    			return base.Xi;
    		}
    		set
    		{
    			base.Xi = value;
    			飛膜.Xi = value;
    		}
    	}

    	public override int Yi
    	{
    		get
    		{
    			return base.Yi;
    		}
    		set
    		{
    			base.Yi = value;
    			飛膜.Yi = value;
    		}
    	}

    	public override double サイズ
    	{
    		get
    		{
    			return サイズ_;
    		}
    		set
    		{
    			base.サイズ = value;
    			飛膜.サイズ = value;
    		}
    	}

    	public override double サイズX
    	{
    		get
    		{
    			return サイズX_;
    		}
    		set
    		{
    			base.サイズX = value;
    			飛膜.サイズX = value;
    		}
    	}

    	public override double サイズY
    	{
    		get
    		{
    			return サイズY_;
    		}
    		set
    		{
    			base.サイズY = value;
    			飛膜.サイズY = value;
    		}
    	}

    	public bool 肘部_外線
    	{
    		get
    		{
    			return X0Y0_獣翼UpperArm.OP[(!右) ? 1 : 2].Outline;
    		}
    		set
    		{
    			X0Y0_獣翼UpperArm.OP[(!右) ? 1 : 2].Outline = value;
    		}
    	}

    	public JointS LowerArm_接続点 => new JointS(Body, X0Y0_獣翼UpperArm, 0);

    	public UpperArm_蝙(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, UpperArm_蝙D e)
    	{
    		UpperArm_蝙 UpperArm_蝙2 = this;
    		飛膜 = new 飛膜_根(DisUnit, 配色指定, 体配色);
    		飛膜.Par = this;
    		ThisType = GetType();
    		Body = new VariantGrid(Sta.腕左["獣翼UpperArm"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_獣翼UpperArm = partGroup["獣翼上腕"].ToPar();
    		PartGroup pars2 = partGroup["鱗"].ToPars();
    		X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
    		X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
    		X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
    		X0Y0_竜性_鱗5 = pars2["鱗5"].ToPar();
    		X0Y0_竜性_鱗6 = pars2["鱗6"].ToPar();
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
    		獣翼UpperArm_表示 = e.獣翼UpperArm_表示;
    		竜性_鱗1_表示 = e.竜性_鱗1_表示;
    		竜性_鱗2_表示 = e.竜性_鱗2_表示;
    		竜性_鱗3_表示 = e.竜性_鱗3_表示;
    		竜性_鱗4_表示 = e.竜性_鱗4_表示;
    		竜性_鱗5_表示 = e.竜性_鱗5_表示;
    		竜性_鱗6_表示 = e.竜性_鱗6_表示;
    		飛膜_表示 = e.飛膜_表示;
    		展開 = e.展開;
    		下部_外線 = e.下部_外線;
    		接部_外線 = e.接部_外線;
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
    				f.Par = UpperArm_蝙2;
    				f.ConnectionType = ConnectionInfo.UpperArm_蝙_LowerArm_接続;
    				f.接続(UpperArm_蝙2.LowerArm_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_獣翼UpperArmCP = new ColorP(X0Y0_獣翼UpperArm, 獣翼UpperArmCD, DisUnit, abj: true);
    		X0Y0_竜性_鱗1CP = new ColorP(X0Y0_竜性_鱗1, 竜性_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗2CP = new ColorP(X0Y0_竜性_鱗2, 竜性_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗3CP = new ColorP(X0Y0_竜性_鱗3, 竜性_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗4CP = new ColorP(X0Y0_竜性_鱗4, 竜性_鱗4CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗5CP = new ColorP(X0Y0_竜性_鱗5, 竜性_鱗5CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗6CP = new ColorP(X0Y0_竜性_鱗6, 竜性_鱗6CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		尺度B = 1.02;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_獣翼UpperArm.AngleBase = num * 0.0;
    		Body.JoinPAall();
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		飛膜.Dispose();
    	}

    	public void 接続(LowerArm_蝙 LowerArm, 手_蝙 手, Vector2D 接着点)
    	{
    		飛膜.接続(this, LowerArm, 手, 接着点);
    	}

    	public Vector2D Get飛膜接続点()
    	{
    		return X0Y0_獣翼UpperArm.ToGlobal(右 ? X0Y0_獣翼UpperArm.OP[0].ps[1] : X0Y0_獣翼UpperArm.OP[3].ps[4]);
    	}

    	public override void 色更新()
    	{
    		X0Y0_獣翼UpperArmCP.Update();
    		X0Y0_竜性_鱗1CP.Update();
    		X0Y0_竜性_鱗2CP.Update();
    		X0Y0_竜性_鱗3CP.Update();
    		X0Y0_竜性_鱗4CP.Update();
    		X0Y0_竜性_鱗5CP.Update();
    		X0Y0_竜性_鱗6CP.Update();
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
    		獣翼UpperArmCD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		獣翼UpperArmCD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		獣翼UpperArmCD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    	}
    }
}
