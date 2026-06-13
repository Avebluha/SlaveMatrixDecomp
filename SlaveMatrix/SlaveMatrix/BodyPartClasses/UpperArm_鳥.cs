using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class UpperArm_鳥 : 翼UpperArm
    {
    	public ShapePart X0Y0_風切羽_羽3;

    	public ShapePart X0Y0_風切羽_羽2;

    	public ShapePart X0Y0_風切羽_羽1;

    	public ShapePart X0Y0_羽毛;

    	public ShapePart X0Y0_鳥翼UpperArm;

    	public ShapePart X0Y0_小雨覆;

    	public ShapePart X0Y0_竜性_鱗1;

    	public ShapePart X0Y0_竜性_鱗2;

    	public ShapePart X0Y0_竜性_鱗3;

    	public ShapePart X0Y0_竜性_鱗4;

    	public ColorD 風切羽_羽3CD;

    	public ColorD 風切羽_羽2CD;

    	public ColorD 風切羽_羽1CD;

    	public ColorD 羽毛CD;

    	public ColorD 鳥翼UpperArmCD;

    	public ColorD 小雨覆CD;

    	public ColorD 竜性_鱗1CD;

    	public ColorD 竜性_鱗2CD;

    	public ColorD 竜性_鱗3CD;

    	public ColorD 竜性_鱗4CD;

    	public ColorP X0Y0_風切羽_羽3CP;

    	public ColorP X0Y0_風切羽_羽2CP;

    	public ColorP X0Y0_風切羽_羽1CP;

    	public ColorP X0Y0_羽毛CP;

    	public ColorP X0Y0_鳥翼UpperArmCP;

    	public ColorP X0Y0_小雨覆CP;

    	public ColorP X0Y0_竜性_鱗1CP;

    	public ColorP X0Y0_竜性_鱗2CP;

    	public ColorP X0Y0_竜性_鱗3CP;

    	public ColorP X0Y0_竜性_鱗4CP;

    	public スタンプK キスマーク;

    	public スタンプW 鞭痕;

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

    	public bool 風切羽_羽3_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽3.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽3.Dra = value;
    			X0Y0_風切羽_羽3.Hit = value;
    		}
    	}

    	public bool 風切羽_羽2_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽2.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽2.Dra = value;
    			X0Y0_風切羽_羽2.Hit = value;
    		}
    	}

    	public bool 風切羽_羽1_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽1.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽1.Dra = value;
    			X0Y0_風切羽_羽1.Hit = value;
    		}
    	}

    	public bool 羽毛_表示
    	{
    		get
    		{
    			return X0Y0_羽毛.Dra;
    		}
    		set
    		{
    			X0Y0_羽毛.Dra = value;
    			X0Y0_羽毛.Hit = value;
    		}
    	}

    	public bool 鳥翼UpperArm_表示
    	{
    		get
    		{
    			return X0Y0_鳥翼UpperArm.Dra;
    		}
    		set
    		{
    			X0Y0_鳥翼UpperArm.Dra = value;
    			X0Y0_鳥翼UpperArm.Hit = value;
    		}
    	}

    	public bool 小雨覆_表示
    	{
    		get
    		{
    			return X0Y0_小雨覆.Dra;
    		}
    		set
    		{
    			X0Y0_小雨覆.Dra = value;
    			X0Y0_小雨覆.Hit = value;
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

    	public override bool 表示
    	{
    		get
    		{
    			return 風切羽_羽3_表示;
    		}
    		set
    		{
    			風切羽_羽3_表示 = value;
    			風切羽_羽2_表示 = value;
    			風切羽_羽1_表示 = value;
    			羽毛_表示 = value;
    			鳥翼UpperArm_表示 = value;
    			小雨覆_表示 = value;
    			竜性_鱗1_表示 = value;
    			竜性_鱗2_表示 = value;
    			竜性_鱗3_表示 = value;
    			竜性_鱗4_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 風切羽_羽3CD.不透明度;
    		}
    		set
    		{
    			風切羽_羽3CD.不透明度 = value;
    			風切羽_羽2CD.不透明度 = value;
    			風切羽_羽1CD.不透明度 = value;
    			羽毛CD.不透明度 = value;
    			鳥翼UpperArmCD.不透明度 = value;
    			小雨覆CD.不透明度 = value;
    			竜性_鱗1CD.不透明度 = value;
    			竜性_鱗2CD.不透明度 = value;
    			竜性_鱗3CD.不透明度 = value;
    			竜性_鱗4CD.不透明度 = value;
    		}
    	}

    	public override double 展開
    	{
    		set
    		{
    			double num = value.Inverse();
    			double num2 = (右 ? (-1.0) : 1.0);
    			X0Y0_鳥翼UpperArm.AngleCont = num2 * -60.0 * num;
    			X0Y0_羽毛.AngleCont = num2 * 100.0 * num;
    			X0Y0_風切羽_羽1.AngleCont = num2 * 75.0 * num;
    			X0Y0_風切羽_羽2.AngleCont = num2 * 75.0 * num;
    			X0Y0_風切羽_羽3.AngleCont = num2 * 75.0 * num;
    		}
    	}

    	public double シャープ
    	{
    		set
    		{
    			double num = 0.05;
    			X0Y0_風切羽_羽3.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽2.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽1.SizeYBase *= 1.0 - num * value;
    		}
    	}

    	public bool UpperArm_外線
    	{
    		get
    		{
    			return X0Y0_鳥翼UpperArm.OP[右 ? 3 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_鳥翼UpperArm.OP[右 ? 3 : 0].Outline = value;
    			X0Y0_鳥翼UpperArm.OP[(!右) ? 1 : 2].Outline = value;
    		}
    	}

    	public bool 小雨覆_外線
    	{
    		get
    		{
    			return X0Y0_小雨覆.OP[右 ? 2 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_小雨覆.OP[右 ? 2 : 3].Outline = value;
    			X0Y0_小雨覆.OP[右 ? 1 : 4].Outline = value;
    			X0Y0_小雨覆.OP[(!右) ? 5 : 0].Outline = value;
    		}
    	}

    	public bool 羽毛_外線
    	{
    		get
    		{
    			return X0Y0_羽毛.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_羽毛.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_羽毛.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_羽毛.OP[右 ? 2 : 2].Outline = value;
    			X0Y0_羽毛.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_羽毛.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽1_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽1.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽1.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽1.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽1.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽2_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽2.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽2.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽2.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽2.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽3_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽3.OP[右 ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽3.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽3.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 肘部_外線
    	{
    		get
    		{
    			return X0Y0_鳥翼UpperArm.OP[(!右) ? 1 : 2].Outline;
    		}
    		set
    		{
    			X0Y0_鳥翼UpperArm.OP[(!右) ? 1 : 2].Outline = value;
    		}
    	}

    	public JointS LowerArm_接続点 => new JointS(Body, X0Y0_鳥翼UpperArm, 0);

    	public UpperArm_鳥(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, UpperArm_鳥D e)
    	{
    		UpperArm_鳥 UpperArm_鳥2 = this;
    		ThisType = GetType();
    		Body = new Difs(Sta.腕左["鳥翼UpperArm"]);
    		PartGroup partGroup = Body[0][0];
    		PartGroup pars2 = partGroup["風切羽"].ToPars();
    		X0Y0_風切羽_羽3 = pars2["羽3"].ToPar();
    		X0Y0_風切羽_羽2 = pars2["羽2"].ToPar();
    		X0Y0_風切羽_羽1 = pars2["羽1"].ToPar();
    		X0Y0_羽毛 = partGroup["羽毛"].ToPar();
    		X0Y0_鳥翼UpperArm = partGroup["鳥翼上腕"].ToPar();
    		X0Y0_小雨覆 = partGroup["小雨覆"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
    		X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
    		X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
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
    		風切羽_羽3_表示 = e.風切羽_羽3_表示;
    		風切羽_羽2_表示 = e.風切羽_羽2_表示;
    		風切羽_羽1_表示 = e.風切羽_羽1_表示;
    		羽毛_表示 = e.羽毛_表示;
    		鳥翼UpperArm_表示 = e.鳥翼UpperArm_表示;
    		小雨覆_表示 = e.小雨覆_表示;
    		竜性_鱗1_表示 = e.竜性_鱗1_表示;
    		竜性_鱗2_表示 = e.竜性_鱗2_表示;
    		竜性_鱗3_表示 = e.竜性_鱗3_表示;
    		竜性_鱗4_表示 = e.竜性_鱗4_表示;
    		展開 = e.展開;
    		シャープ = e.シャープ;
    		UpperArm_外線 = e.UpperArm_外線;
    		小雨覆_外線 = e.小雨覆_外線;
    		羽毛_外線 = e.羽毛_外線;
    		風切羽_羽1_外線 = e.風切羽_羽1_外線;
    		風切羽_羽2_外線 = e.風切羽_羽2_外線;
    		風切羽_羽3_外線 = e.風切羽_羽3_外線;
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
    				f.Par = UpperArm_鳥2;
    				f.ConnectionType = ConnectionInfo.UpperArm_鳥_LowerArm_接続;
    				f.接続(UpperArm_鳥2.LowerArm_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_風切羽_羽3CP = new ColorP(X0Y0_風切羽_羽3, 風切羽_羽3CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽2CP = new ColorP(X0Y0_風切羽_羽2, 風切羽_羽2CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽1CP = new ColorP(X0Y0_風切羽_羽1, 風切羽_羽1CD, DisUnit, abj: true);
    		X0Y0_羽毛CP = new ColorP(X0Y0_羽毛, 羽毛CD, DisUnit, abj: true);
    		X0Y0_鳥翼UpperArmCP = new ColorP(X0Y0_鳥翼UpperArm, 鳥翼UpperArmCD, DisUnit, abj: true);
    		X0Y0_小雨覆CP = new ColorP(X0Y0_小雨覆, 小雨覆CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗1CP = new ColorP(X0Y0_竜性_鱗1, 竜性_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗2CP = new ColorP(X0Y0_竜性_鱗2, 竜性_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗3CP = new ColorP(X0Y0_竜性_鱗3, 竜性_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗4CP = new ColorP(X0Y0_竜性_鱗4, 竜性_鱗4CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_鳥翼UpperArm.AngleBase = num * 0.0;
    		X0Y0_羽毛.AngleBase = num * -122.9677794835592;
    		X0Y0_風切羽_羽1.AngleBase = num * -100.129973503791;
    		X0Y0_風切羽_羽2.AngleBase = num * -102.129973503791;
    		X0Y0_風切羽_羽3.AngleBase = num * -103.129973503791;
    		Body.JoinPAall();
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_風切羽_羽3);
    		Are.Draw(X0Y0_風切羽_羽2);
    		Are.Draw(X0Y0_風切羽_羽1);
    		Are.Draw(X0Y0_羽毛);
    		Are.Draw(X0Y0_鳥翼UpperArm);
    		Are.Draw(X0Y0_小雨覆);
    		キスマーク.Draw(Are);
    		鞭痕.Draw(Are);
    		Are.Draw(X0Y0_竜性_鱗1);
    		Are.Draw(X0Y0_竜性_鱗2);
    		Are.Draw(X0Y0_竜性_鱗3);
    		Are.Draw(X0Y0_竜性_鱗4);
    	}

    	public override void 色更新()
    	{
    		X0Y0_風切羽_羽3CP.Update();
    		X0Y0_風切羽_羽2CP.Update();
    		X0Y0_風切羽_羽1CP.Update();
    		X0Y0_羽毛CP.Update();
    		X0Y0_鳥翼UpperArmCP.Update();
    		X0Y0_小雨覆CP.Update();
    		X0Y0_竜性_鱗1CP.Update();
    		X0Y0_竜性_鱗2CP.Update();
    		X0Y0_竜性_鱗3CP.Update();
    		X0Y0_竜性_鱗4CP.Update();
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
    		風切羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		羽毛CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		鳥翼UpperArmCD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		小雨覆CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		風切羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		風切羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		羽毛CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		鳥翼UpperArmCD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		小雨覆CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		風切羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		風切羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		羽毛CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		鳥翼UpperArmCD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		小雨覆CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    	}
    }
}
