using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 触覚_甲 : 触覚
    {
    	public ShapePart X0Y0_節0;

    	public ShapePart X0Y0_節1;

    	public ShapePart X0Y0_節2;

    	public ShapePart X0Y0_節3;

    	public ShapePart X0Y0_節4;

    	public ShapePart X0Y0_節5;

    	public ShapePart X0Y0_節6;

    	public ShapePart X0Y0_節7;

    	public ShapePart X0Y0_節8;

    	public ShapePart X0Y0_節9;

    	public ShapePart X0Y0_節10;

    	public ColorD 節0CD;

    	public ColorD 節1CD;

    	public ColorD 節2CD;

    	public ColorD 節3CD;

    	public ColorD 節4CD;

    	public ColorD 節5CD;

    	public ColorD 節6CD;

    	public ColorD 節7CD;

    	public ColorD 節8CD;

    	public ColorD 節9CD;

    	public ColorD 節10CD;

    	public ColorP X0Y0_節0CP;

    	public ColorP X0Y0_節1CP;

    	public ColorP X0Y0_節2CP;

    	public ColorP X0Y0_節3CP;

    	public ColorP X0Y0_節4CP;

    	public ColorP X0Y0_節5CP;

    	public ColorP X0Y0_節6CP;

    	public ColorP X0Y0_節7CP;

    	public ColorP X0Y0_節8CP;

    	public ColorP X0Y0_節9CP;

    	public ColorP X0Y0_節10CP;

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

    	public bool 節0_表示
    	{
    		get
    		{
    			return X0Y0_節0.Dra;
    		}
    		set
    		{
    			X0Y0_節0.Dra = value;
    			X0Y0_節0.Hit = value;
    		}
    	}

    	public bool 節1_表示
    	{
    		get
    		{
    			return X0Y0_節1.Dra;
    		}
    		set
    		{
    			X0Y0_節1.Dra = value;
    			X0Y0_節1.Hit = value;
    		}
    	}

    	public bool 節2_表示
    	{
    		get
    		{
    			return X0Y0_節2.Dra;
    		}
    		set
    		{
    			X0Y0_節2.Dra = value;
    			X0Y0_節2.Hit = value;
    		}
    	}

    	public bool 節3_表示
    	{
    		get
    		{
    			return X0Y0_節3.Dra;
    		}
    		set
    		{
    			X0Y0_節3.Dra = value;
    			X0Y0_節3.Hit = value;
    		}
    	}

    	public bool 節4_表示
    	{
    		get
    		{
    			return X0Y0_節4.Dra;
    		}
    		set
    		{
    			X0Y0_節4.Dra = value;
    			X0Y0_節4.Hit = value;
    		}
    	}

    	public bool 節5_表示
    	{
    		get
    		{
    			return X0Y0_節5.Dra;
    		}
    		set
    		{
    			X0Y0_節5.Dra = value;
    			X0Y0_節5.Hit = value;
    		}
    	}

    	public bool 節6_表示
    	{
    		get
    		{
    			return X0Y0_節6.Dra;
    		}
    		set
    		{
    			X0Y0_節6.Dra = value;
    			X0Y0_節6.Hit = value;
    		}
    	}

    	public bool 節7_表示
    	{
    		get
    		{
    			return X0Y0_節7.Dra;
    		}
    		set
    		{
    			X0Y0_節7.Dra = value;
    			X0Y0_節7.Hit = value;
    		}
    	}

    	public bool 節8_表示
    	{
    		get
    		{
    			return X0Y0_節8.Dra;
    		}
    		set
    		{
    			X0Y0_節8.Dra = value;
    			X0Y0_節8.Hit = value;
    		}
    	}

    	public bool 節9_表示
    	{
    		get
    		{
    			return X0Y0_節9.Dra;
    		}
    		set
    		{
    			X0Y0_節9.Dra = value;
    			X0Y0_節9.Hit = value;
    		}
    	}

    	public bool 節10_表示
    	{
    		get
    		{
    			return X0Y0_節10.Dra;
    		}
    		set
    		{
    			X0Y0_節10.Dra = value;
    			X0Y0_節10.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 節0_表示;
    		}
    		set
    		{
    			節0_表示 = value;
    			節1_表示 = value;
    			節2_表示 = value;
    			節3_表示 = value;
    			節4_表示 = value;
    			節5_表示 = value;
    			節6_表示 = value;
    			節7_表示 = value;
    			節8_表示 = value;
    			節9_表示 = value;
    			節10_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 節0CD.不透明度;
    		}
    		set
    		{
    			節0CD.不透明度 = value;
    			節1CD.不透明度 = value;
    			節2CD.不透明度 = value;
    			節3CD.不透明度 = value;
    			節4CD.不透明度 = value;
    			節5CD.不透明度 = value;
    			節6CD.不透明度 = value;
    			節7CD.不透明度 = value;
    			節8CD.不透明度 = value;
    			節9CD.不透明度 = value;
    			節10CD.不透明度 = value;
    		}
    	}

    	public 触覚_甲(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 触覚_甲D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant();
    		morphVariant.Tag = "甲";
    		morphVariant.Add(new PartGroup(Sta.肢左["触覚"][0][2]));
    		Body = new Difs();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_節0 = partGroup["節0"].ToPar();
    		X0Y0_節1 = partGroup["節1"].ToPar();
    		X0Y0_節2 = partGroup["節2"].ToPar();
    		X0Y0_節3 = partGroup["節3"].ToPar();
    		X0Y0_節4 = partGroup["節4"].ToPar();
    		X0Y0_節5 = partGroup["節5"].ToPar();
    		X0Y0_節6 = partGroup["節6"].ToPar();
    		X0Y0_節7 = partGroup["節7"].ToPar();
    		X0Y0_節8 = partGroup["節8"].ToPar();
    		X0Y0_節9 = partGroup["節9"].ToPar();
    		X0Y0_節10 = partGroup["節10"].ToPar();
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
    		節0_表示 = e.節0_表示;
    		節1_表示 = e.節1_表示;
    		節2_表示 = e.節2_表示;
    		節3_表示 = e.節3_表示;
    		節4_表示 = e.節4_表示;
    		節5_表示 = e.節5_表示;
    		節6_表示 = e.節6_表示;
    		節7_表示 = e.節7_表示;
    		節8_表示 = e.節8_表示;
    		節9_表示 = e.節9_表示;
    		節10_表示 = e.節10_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_節0CP = new ColorP(X0Y0_節0, 節0CD, DisUnit, abj: true);
    		X0Y0_節1CP = new ColorP(X0Y0_節1, 節1CD, DisUnit, abj: true);
    		X0Y0_節2CP = new ColorP(X0Y0_節2, 節2CD, DisUnit, abj: true);
    		X0Y0_節3CP = new ColorP(X0Y0_節3, 節3CD, DisUnit, abj: true);
    		X0Y0_節4CP = new ColorP(X0Y0_節4, 節4CD, DisUnit, abj: true);
    		X0Y0_節5CP = new ColorP(X0Y0_節5, 節5CD, DisUnit, abj: true);
    		X0Y0_節6CP = new ColorP(X0Y0_節6, 節6CD, DisUnit, abj: true);
    		X0Y0_節7CP = new ColorP(X0Y0_節7, 節7CD, DisUnit, abj: true);
    		X0Y0_節8CP = new ColorP(X0Y0_節8, 節8CD, DisUnit, abj: true);
    		X0Y0_節9CP = new ColorP(X0Y0_節9, 節9CD, DisUnit, abj: true);
    		X0Y0_節10CP = new ColorP(X0Y0_節10, 節10CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		int num2 = -5;
    		double num3 = 1.0;
    		double num4 = 0.01;
    		X0Y0_節0.AngleBase = num * -55.0;
    		X0Y0_節1.AngleBase = num * 25.0;
    		X0Y0_節2.AngleBase = num * (double)num2 * num3;
    		num3 -= num4;
    		X0Y0_節3.AngleBase = num * (double)num2 * num3;
    		num3 -= num4;
    		X0Y0_節4.AngleBase = num * (double)num2 * num3;
    		num3 -= num4;
    		X0Y0_節5.AngleBase = num * (double)num2 * num3;
    		num3 -= num4;
    		X0Y0_節6.AngleBase = num * (double)num2 * num3;
    		num3 -= num4;
    		X0Y0_節7.AngleBase = num * (double)num2 * num3;
    		num3 -= num4;
    		X0Y0_節8.AngleBase = num * (double)num2 * num3;
    		num3 -= num4;
    		X0Y0_節9.AngleBase = num * (double)num2 * num3;
    		num3 -= num4;
    		X0Y0_節10.AngleBase = num * (double)num2 * num3;
    		Body.JoinPAall();
    	}

    	public override IEnumerable<ShapePart> Enum軸()
    	{
    		yield return X0Y0_節0;
    		yield return X0Y0_節1;
    		yield return X0Y0_節2;
    		yield return X0Y0_節3;
    		yield return X0Y0_節4;
    		yield return X0Y0_節5;
    		yield return X0Y0_節6;
    		yield return X0Y0_節7;
    		yield return X0Y0_節8;
    		yield return X0Y0_節9;
    		yield return X0Y0_節10;
    	}

    	public override void 色更新()
    	{
    		X0Y0_節0CP.Update();
    		X0Y0_節1CP.Update();
    		X0Y0_節2CP.Update();
    		X0Y0_節3CP.Update();
    		X0Y0_節4CP.Update();
    		X0Y0_節5CP.Update();
    		X0Y0_節6CP.Update();
    		X0Y0_節7CP.Update();
    		X0Y0_節8CP.Update();
    		X0Y0_節9CP.Update();
    		X0Y0_節10CP.Update();
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
    		節0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節5CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節6CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節7CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節8CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節9CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節10CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		this.配色T(0, "節", ref 体配色.甲0O, ref 体配色.刺青O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		this.配色T(1, "節", ref 体配色.甲0O, ref 体配色.刺青O);
    	}
    }
}
