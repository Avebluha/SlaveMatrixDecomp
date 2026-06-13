using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 腿_竜 : 獣腿
    {
    	public ShapePart X0Y0_腿;

    	public ShapePart X0Y0_竜性_鱗下_鱗1;

    	public ShapePart X0Y0_竜性_鱗下_鱗2;

    	public ShapePart X0Y0_竜性_鱗下_鱗3;

    	public ShapePart X0Y0_竜性_鱗下_鱗4;

    	public ShapePart X0Y0_竜性_鱗下_鱗5;

    	public ShapePart X0Y0_竜性_鱗下_鱗6;

    	public ShapePart X0Y0_竜性_鱗上_鱗1;

    	public ShapePart X0Y0_竜性_鱗上_鱗2;

    	public ShapePart X0Y0_竜性_鱗上_鱗3;

    	public ShapePart X0Y0_竜性_鱗上_鱗4;

    	public ShapePart X0Y0_筋;

    	public ColorD 腿CD;

    	public ColorD 竜性_鱗下_鱗1CD;

    	public ColorD 竜性_鱗下_鱗2CD;

    	public ColorD 竜性_鱗下_鱗3CD;

    	public ColorD 竜性_鱗下_鱗4CD;

    	public ColorD 竜性_鱗下_鱗5CD;

    	public ColorD 竜性_鱗下_鱗6CD;

    	public ColorD 竜性_鱗上_鱗1CD;

    	public ColorD 竜性_鱗上_鱗2CD;

    	public ColorD 竜性_鱗上_鱗3CD;

    	public ColorD 竜性_鱗上_鱗4CD;

    	public ColorD 筋CD;

    	public ColorP X0Y0_腿CP;

    	public ColorP X0Y0_竜性_鱗下_鱗1CP;

    	public ColorP X0Y0_竜性_鱗下_鱗2CP;

    	public ColorP X0Y0_竜性_鱗下_鱗3CP;

    	public ColorP X0Y0_竜性_鱗下_鱗4CP;

    	public ColorP X0Y0_竜性_鱗下_鱗5CP;

    	public ColorP X0Y0_竜性_鱗下_鱗6CP;

    	public ColorP X0Y0_竜性_鱗上_鱗1CP;

    	public ColorP X0Y0_竜性_鱗上_鱗2CP;

    	public ColorP X0Y0_竜性_鱗上_鱗3CP;

    	public ColorP X0Y0_竜性_鱗上_鱗4CP;

    	public ColorP X0Y0_筋CP;

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
    			筋_表示 = 筋肉_;
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

    	public bool 腿_表示
    	{
    		get
    		{
    			return X0Y0_腿.Dra;
    		}
    		set
    		{
    			X0Y0_腿.Dra = value;
    			X0Y0_腿.Hit = value;
    		}
    	}

    	public bool 竜性_鱗下_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗下_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗下_鱗1.Dra = value;
    			X0Y0_竜性_鱗下_鱗1.Hit = value;
    		}
    	}

    	public bool 竜性_鱗下_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗下_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗下_鱗2.Dra = value;
    			X0Y0_竜性_鱗下_鱗2.Hit = value;
    		}
    	}

    	public bool 竜性_鱗下_鱗3_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗下_鱗3.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗下_鱗3.Dra = value;
    			X0Y0_竜性_鱗下_鱗3.Hit = value;
    		}
    	}

    	public bool 竜性_鱗下_鱗4_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗下_鱗4.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗下_鱗4.Dra = value;
    			X0Y0_竜性_鱗下_鱗4.Hit = value;
    		}
    	}

    	public bool 竜性_鱗下_鱗5_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗下_鱗5.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗下_鱗5.Dra = value;
    			X0Y0_竜性_鱗下_鱗5.Hit = value;
    		}
    	}

    	public bool 竜性_鱗下_鱗6_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗下_鱗6.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗下_鱗6.Dra = value;
    			X0Y0_竜性_鱗下_鱗6.Hit = value;
    		}
    	}

    	public bool 竜性_鱗上_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗上_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗上_鱗1.Dra = value;
    			X0Y0_竜性_鱗上_鱗1.Hit = value;
    		}
    	}

    	public bool 竜性_鱗上_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗上_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗上_鱗2.Dra = value;
    			X0Y0_竜性_鱗上_鱗2.Hit = value;
    		}
    	}

    	public bool 竜性_鱗上_鱗3_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗上_鱗3.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗上_鱗3.Dra = value;
    			X0Y0_竜性_鱗上_鱗3.Hit = value;
    		}
    	}

    	public bool 竜性_鱗上_鱗4_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗上_鱗4.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗上_鱗4.Dra = value;
    			X0Y0_竜性_鱗上_鱗4.Hit = value;
    		}
    	}

    	public bool 筋_表示
    	{
    		get
    		{
    			return X0Y0_筋.Dra;
    		}
    		set
    		{
    			X0Y0_筋.Dra = value;
    			X0Y0_筋.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 腿_表示;
    		}
    		set
    		{
    			腿_表示 = value;
    			竜性_鱗下_鱗1_表示 = value;
    			竜性_鱗下_鱗2_表示 = value;
    			竜性_鱗下_鱗3_表示 = value;
    			竜性_鱗下_鱗4_表示 = value;
    			竜性_鱗下_鱗5_表示 = value;
    			竜性_鱗下_鱗6_表示 = value;
    			竜性_鱗上_鱗1_表示 = value;
    			竜性_鱗上_鱗2_表示 = value;
    			竜性_鱗上_鱗3_表示 = value;
    			竜性_鱗上_鱗4_表示 = value;
    			筋_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 腿CD.不透明度;
    		}
    		set
    		{
    			腿CD.不透明度 = value;
    			竜性_鱗下_鱗1CD.不透明度 = value;
    			竜性_鱗下_鱗2CD.不透明度 = value;
    			竜性_鱗下_鱗3CD.不透明度 = value;
    			竜性_鱗下_鱗4CD.不透明度 = value;
    			竜性_鱗下_鱗5CD.不透明度 = value;
    			竜性_鱗下_鱗6CD.不透明度 = value;
    			竜性_鱗上_鱗1CD.不透明度 = value;
    			竜性_鱗上_鱗2CD.不透明度 = value;
    			竜性_鱗上_鱗3CD.不透明度 = value;
    			竜性_鱗上_鱗4CD.不透明度 = value;
    			筋CD.不透明度 = value;
    		}
    	}

    	public JointS 脚_接続点 => new JointS(Body, X0Y0_腿, 0);

    	public 腿_竜(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 腿_竜D e)
    	{
    		腿_竜 腿_竜2 = this;
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(Sta.脚左["四足腿"][3]);
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_腿 = partGroup["腿"].ToPar();
    		PartGroup pars2 = partGroup["鱗下"].ToPars();
    		X0Y0_竜性_鱗下_鱗1 = pars2["鱗1"].ToPar();
    		X0Y0_竜性_鱗下_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_竜性_鱗下_鱗3 = pars2["鱗3"].ToPar();
    		X0Y0_竜性_鱗下_鱗4 = pars2["鱗4"].ToPar();
    		X0Y0_竜性_鱗下_鱗5 = pars2["鱗5"].ToPar();
    		X0Y0_竜性_鱗下_鱗6 = pars2["鱗6"].ToPar();
    		pars2 = partGroup["鱗上"].ToPars();
    		X0Y0_竜性_鱗上_鱗1 = pars2["鱗1"].ToPar();
    		X0Y0_竜性_鱗上_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_竜性_鱗上_鱗3 = pars2["鱗3"].ToPar();
    		X0Y0_竜性_鱗上_鱗4 = pars2["鱗4"].ToPar();
    		X0Y0_筋 = partGroup["筋"].ToPar();
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
    		腿_表示 = e.腿_表示;
    		竜性_鱗下_鱗1_表示 = e.竜性_鱗下_鱗1_表示;
    		竜性_鱗下_鱗2_表示 = e.竜性_鱗下_鱗2_表示;
    		竜性_鱗下_鱗3_表示 = e.竜性_鱗下_鱗3_表示;
    		竜性_鱗下_鱗4_表示 = e.竜性_鱗下_鱗4_表示;
    		竜性_鱗下_鱗5_表示 = e.竜性_鱗下_鱗5_表示;
    		竜性_鱗下_鱗6_表示 = e.竜性_鱗下_鱗6_表示;
    		竜性_鱗上_鱗1_表示 = e.竜性_鱗上_鱗1_表示;
    		竜性_鱗上_鱗2_表示 = e.竜性_鱗上_鱗2_表示;
    		竜性_鱗上_鱗3_表示 = e.竜性_鱗上_鱗3_表示;
    		竜性_鱗上_鱗4_表示 = e.竜性_鱗上_鱗4_表示;
    		筋_表示 = e.筋_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.Leg_接続.Count > 0)
    		{
    			Element f;
    			Leg_接続 = e.Leg_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 腿_竜2;
    				f.ConnectionType = ConnectionInfo.腿_竜_Leg_接続;
    				f.接続(腿_竜2.脚_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_腿CP = new ColorP(X0Y0_腿, 腿CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗下_鱗1CP = new ColorP(X0Y0_竜性_鱗下_鱗1, 竜性_鱗下_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗下_鱗2CP = new ColorP(X0Y0_竜性_鱗下_鱗2, 竜性_鱗下_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗下_鱗3CP = new ColorP(X0Y0_竜性_鱗下_鱗3, 竜性_鱗下_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗下_鱗4CP = new ColorP(X0Y0_竜性_鱗下_鱗4, 竜性_鱗下_鱗4CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗下_鱗5CP = new ColorP(X0Y0_竜性_鱗下_鱗5, 竜性_鱗下_鱗5CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗下_鱗6CP = new ColorP(X0Y0_竜性_鱗下_鱗6, 竜性_鱗下_鱗6CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗上_鱗1CP = new ColorP(X0Y0_竜性_鱗上_鱗1, 竜性_鱗上_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗上_鱗2CP = new ColorP(X0Y0_竜性_鱗上_鱗2, 竜性_鱗上_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗上_鱗3CP = new ColorP(X0Y0_竜性_鱗上_鱗3, 竜性_鱗上_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗上_鱗4CP = new ColorP(X0Y0_竜性_鱗上_鱗4, 竜性_鱗上_鱗4CD, DisUnit, abj: true);
    		X0Y0_筋CP = new ColorP(X0Y0_筋, 筋CD, DisUnit, abj: false);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_腿.AngleBase = num * 144.0;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		X0Y0_腿CP.Update();
    		X0Y0_竜性_鱗下_鱗1CP.Update();
    		X0Y0_竜性_鱗下_鱗2CP.Update();
    		X0Y0_竜性_鱗下_鱗3CP.Update();
    		X0Y0_竜性_鱗下_鱗4CP.Update();
    		X0Y0_竜性_鱗下_鱗5CP.Update();
    		X0Y0_竜性_鱗下_鱗6CP.Update();
    		X0Y0_竜性_鱗上_鱗1CP.Update();
    		X0Y0_竜性_鱗上_鱗2CP.Update();
    		X0Y0_竜性_鱗上_鱗3CP.Update();
    		X0Y0_竜性_鱗上_鱗4CP.Update();
    		X0Y0_筋CP.Update();
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
    		腿CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		竜性_鱗下_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗5CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗6CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗上_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗上_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗上_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗上_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		腿CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		竜性_鱗下_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗5CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗6CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗上_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗上_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗上_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗上_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		腿CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		竜性_鱗下_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗5CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗下_鱗6CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗上_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗上_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗上_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗上_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    	}
    }
}
