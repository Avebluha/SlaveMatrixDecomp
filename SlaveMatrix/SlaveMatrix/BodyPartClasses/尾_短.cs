using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 尾_短 : 尾
    {
    	public ShapePart X0Y0_尾0;

    	public ShapePart X0Y0_尾1;

    	public ShapePart X0Y0_尾2;

    	public ShapePart X0Y0_尾3;

    	public ShapePart X0Y0_尾4;

    	public ShapePart X0Y0_尾5;

    	public ColorD 尾0CD;

    	public ColorD 尾1CD;

    	public ColorD 尾2CD;

    	public ColorD 尾3CD;

    	public ColorD 尾4CD;

    	public ColorD 尾5CD;

    	public ColorP X0Y0_尾0CP;

    	public ColorP X0Y0_尾1CP;

    	public ColorP X0Y0_尾2CP;

    	public ColorP X0Y0_尾3CP;

    	public ColorP X0Y0_尾4CP;

    	public ColorP X0Y0_尾5CP;

    	public ShapePart[] Pars;

    	private Vector2D[] mm;

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

    	public bool 尾0_表示
    	{
    		get
    		{
    			return X0Y0_尾0.Dra;
    		}
    		set
    		{
    			X0Y0_尾0.Dra = value;
    			X0Y0_尾0.Hit = value;
    		}
    	}

    	public bool 尾1_表示
    	{
    		get
    		{
    			return X0Y0_尾1.Dra;
    		}
    		set
    		{
    			X0Y0_尾1.Dra = value;
    			X0Y0_尾1.Hit = value;
    		}
    	}

    	public bool 尾2_表示
    	{
    		get
    		{
    			return X0Y0_尾2.Dra;
    		}
    		set
    		{
    			X0Y0_尾2.Dra = value;
    			X0Y0_尾2.Hit = value;
    		}
    	}

    	public bool 尾3_表示
    	{
    		get
    		{
    			return X0Y0_尾3.Dra;
    		}
    		set
    		{
    			X0Y0_尾3.Dra = value;
    			X0Y0_尾3.Hit = value;
    		}
    	}

    	public bool 尾4_表示
    	{
    		get
    		{
    			return X0Y0_尾4.Dra;
    		}
    		set
    		{
    			X0Y0_尾4.Dra = value;
    			X0Y0_尾4.Hit = value;
    		}
    	}

    	public bool 尾5_表示
    	{
    		get
    		{
    			return X0Y0_尾5.Dra;
    		}
    		set
    		{
    			X0Y0_尾5.Dra = value;
    			X0Y0_尾5.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 尾0_表示;
    		}
    		set
    		{
    			尾0_表示 = value;
    			尾1_表示 = value;
    			尾2_表示 = value;
    			尾3_表示 = value;
    			尾4_表示 = value;
    			尾5_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 尾0CD.不透明度;
    		}
    		set
    		{
    			尾0CD.不透明度 = value;
    			尾1CD.不透明度 = value;
    			尾2CD.不透明度 = value;
    			尾3CD.不透明度 = value;
    			尾4CD.不透明度 = value;
    			尾5CD.不透明度 = value;
    		}
    	}

    	public 尾_短(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 尾_短D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "短尾";
    		dif.Add(new Pars(Sta.尻尾["尾"][0][15]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_尾0 = pars["尾0"].ToPar();
    		X0Y0_尾1 = pars["尾1"].ToPar();
    		X0Y0_尾2 = pars["尾2"].ToPar();
    		X0Y0_尾3 = pars["尾3"].ToPar();
    		X0Y0_尾4 = pars["尾4"].ToPar();
    		X0Y0_尾5 = pars["尾5"].ToPar();
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
    		尾0_表示 = e.尾0_表示;
    		尾1_表示 = e.尾1_表示;
    		尾2_表示 = e.尾2_表示;
    		尾3_表示 = e.尾3_表示;
    		尾4_表示 = e.尾4_表示;
    		尾5_表示 = e.尾5_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		Pars = new ShapePart[6] { X0Y0_尾0, X0Y0_尾1, X0Y0_尾2, X0Y0_尾3, X0Y0_尾4, X0Y0_尾5 };
    		X0Y0_尾0CP = new ColorP(X0Y0_尾0, 尾0CD, DisUnit, abj: true);
    		X0Y0_尾1CP = new ColorP(X0Y0_尾1, 尾1CD, DisUnit, abj: true);
    		X0Y0_尾2CP = new ColorP(X0Y0_尾2, 尾2CD, DisUnit, abj: true);
    		X0Y0_尾3CP = new ColorP(X0Y0_尾3, 尾3CD, DisUnit, abj: true);
    		X0Y0_尾4CP = new ColorP(X0Y0_尾4, 尾4CD, DisUnit, abj: true);
    		X0Y0_尾5CP = new ColorP(X0Y0_尾5, 尾5CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		_ = 右;
    		double maxAngle = 20.0;
    		X0Y0_尾0.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾1.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾2.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾3.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾4.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾5.AngleBase = maxAngle.GetRanAngle();
    		Body.JoinPAall();
    	}

    	public override IEnumerable<ShapePart> Enum軸()
    	{
    		yield return X0Y0_尾0;
    		yield return X0Y0_尾1;
    		yield return X0Y0_尾2;
    		yield return X0Y0_尾3;
    		yield return X0Y0_尾4;
    		yield return X0Y0_尾5;
    	}

    	public override void 色更新()
    	{
    		Pars.GetMiY_MaY(out mm);
    		X0Y0_尾0CP.Update(mm);
    		X0Y0_尾1CP.Update(mm);
    		X0Y0_尾2CP.Update(mm);
    		X0Y0_尾3CP.Update(mm);
    		X0Y0_尾4CP.Update(mm);
    		X0Y0_尾5CP.Update(mm);
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
    		尾0CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾1CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾2CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾3CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾4CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾5CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		this.配色T(0, "尾", ref 体配色.体0O, ref 体配色.刺青O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		this.配色T(1, "尾", ref 体配色.体0O, ref 体配色.刺青O);
    	}
    }
}
