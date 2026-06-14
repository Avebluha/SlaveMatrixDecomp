using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 尾_狐 : 尾
    {
    	public ShapePart X0Y0_尾0;

    	public ShapePart X0Y0_尾1;

    	public ShapePart X0Y0_尾2;

    	public ShapePart X0Y0_尾3;

    	public ShapePart X0Y0_尾4;

    	public ShapePart X0Y0_尾5;

    	public ShapePart X0Y0_尾6;

    	public ShapePart X0Y0_尾7;

    	public ShapePart X0Y0_尾8;

    	public ShapePart X0Y0_尾9;

    	public ShapePart X0Y0_尾10;

    	public ShapePart X0Y0_尾11;

    	public ColorD 尾0CD;

    	public ColorD 尾1CD;

    	public ColorD 尾2CD;

    	public ColorD 尾3CD;

    	public ColorD 尾4CD;

    	public ColorD 尾5CD;

    	public ColorD 尾6CD;

    	public ColorD 尾7CD;

    	public ColorD 尾8CD;

    	public ColorD 尾9CD;

    	public ColorD 尾10CD;

    	public ColorD 尾11CD;

    	public ColorP X0Y0_尾0CP;

    	public ColorP X0Y0_尾1CP;

    	public ColorP X0Y0_尾2CP;

    	public ColorP X0Y0_尾3CP;

    	public ColorP X0Y0_尾4CP;

    	public ColorP X0Y0_尾5CP;

    	public ColorP X0Y0_尾6CP;

    	public ColorP X0Y0_尾7CP;

    	public ColorP X0Y0_尾8CP;

    	public ColorP X0Y0_尾9CP;

    	public ColorP X0Y0_尾10CP;

    	public ColorP X0Y0_尾11CP;

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

    	public bool 尾6_表示
    	{
    		get
    		{
    			return X0Y0_尾6.Dra;
    		}
    		set
    		{
    			X0Y0_尾6.Dra = value;
    			X0Y0_尾6.Hit = value;
    		}
    	}

    	public bool 尾7_表示
    	{
    		get
    		{
    			return X0Y0_尾7.Dra;
    		}
    		set
    		{
    			X0Y0_尾7.Dra = value;
    			X0Y0_尾7.Hit = value;
    		}
    	}

    	public bool 尾8_表示
    	{
    		get
    		{
    			return X0Y0_尾8.Dra;
    		}
    		set
    		{
    			X0Y0_尾8.Dra = value;
    			X0Y0_尾8.Hit = value;
    		}
    	}

    	public bool 尾9_表示
    	{
    		get
    		{
    			return X0Y0_尾9.Dra;
    		}
    		set
    		{
    			X0Y0_尾9.Dra = value;
    			X0Y0_尾9.Hit = value;
    		}
    	}

    	public bool 尾10_表示
    	{
    		get
    		{
    			return X0Y0_尾10.Dra;
    		}
    		set
    		{
    			X0Y0_尾10.Dra = value;
    			X0Y0_尾10.Hit = value;
    		}
    	}

    	public bool 尾11_表示
    	{
    		get
    		{
    			return X0Y0_尾11.Dra;
    		}
    		set
    		{
    			X0Y0_尾11.Dra = value;
    			X0Y0_尾11.Hit = value;
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
    			尾6_表示 = value;
    			尾7_表示 = value;
    			尾8_表示 = value;
    			尾9_表示 = value;
    			尾10_表示 = value;
    			尾11_表示 = value;
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
    			尾6CD.不透明度 = value;
    			尾7CD.不透明度 = value;
    			尾8CD.不透明度 = value;
    			尾9CD.不透明度 = value;
    			尾10CD.不透明度 = value;
    			尾11CD.不透明度 = value;
    		}
    	}

    	public 尾_狐(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 尾_狐D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant();
    		morphVariant.Tag = "狐尾";
    		morphVariant.Add(new PartGroup(GlobalState.尻尾["尾"][0][2]));
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_尾0 = partGroup["尾0"].ToPar();
    		X0Y0_尾1 = partGroup["尾1"].ToPar();
    		X0Y0_尾2 = partGroup["尾2"].ToPar();
    		X0Y0_尾3 = partGroup["尾3"].ToPar();
    		X0Y0_尾4 = partGroup["尾4"].ToPar();
    		X0Y0_尾5 = partGroup["尾5"].ToPar();
    		X0Y0_尾6 = partGroup["尾6"].ToPar();
    		X0Y0_尾7 = partGroup["尾7"].ToPar();
    		X0Y0_尾8 = partGroup["尾8"].ToPar();
    		X0Y0_尾9 = partGroup["尾9"].ToPar();
    		X0Y0_尾10 = partGroup["尾10"].ToPar();
    		X0Y0_尾11 = partGroup["尾11"].ToPar();
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
    		尾6_表示 = e.尾6_表示;
    		尾7_表示 = e.尾7_表示;
    		尾8_表示 = e.尾8_表示;
    		尾9_表示 = e.尾9_表示;
    		尾10_表示 = e.尾10_表示;
    		尾11_表示 = e.尾11_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		Pars = new ShapePart[12]
    		{
    			X0Y0_尾0, X0Y0_尾1, X0Y0_尾2, X0Y0_尾3, X0Y0_尾4, X0Y0_尾5, X0Y0_尾6, X0Y0_尾7, X0Y0_尾8, X0Y0_尾9,
    			X0Y0_尾10, X0Y0_尾11
    		};
    		X0Y0_尾0CP = new ColorP(X0Y0_尾0, 尾0CD, DisUnit, abj: true);
    		X0Y0_尾1CP = new ColorP(X0Y0_尾1, 尾1CD, DisUnit, abj: true);
    		X0Y0_尾2CP = new ColorP(X0Y0_尾2, 尾2CD, DisUnit, abj: true);
    		X0Y0_尾3CP = new ColorP(X0Y0_尾3, 尾3CD, DisUnit, abj: true);
    		X0Y0_尾4CP = new ColorP(X0Y0_尾4, 尾4CD, DisUnit, abj: true);
    		X0Y0_尾5CP = new ColorP(X0Y0_尾5, 尾5CD, DisUnit, abj: true);
    		X0Y0_尾6CP = new ColorP(X0Y0_尾6, 尾6CD, DisUnit, abj: true);
    		X0Y0_尾7CP = new ColorP(X0Y0_尾7, 尾7CD, DisUnit, abj: true);
    		X0Y0_尾8CP = new ColorP(X0Y0_尾8, 尾8CD, DisUnit, abj: true);
    		X0Y0_尾9CP = new ColorP(X0Y0_尾9, 尾9CD, DisUnit, abj: true);
    		X0Y0_尾10CP = new ColorP(X0Y0_尾10, 尾10CD, DisUnit, abj: true);
    		X0Y0_尾11CP = new ColorP(X0Y0_尾11, 尾11CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		_ = 右;
    		double maxAngle = 20.0;
    		X0Y0_尾0.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾1.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾2.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾3.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾4.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾5.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾6.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾7.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾8.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾9.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾10.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾11.SetAngleBase(maxAngle.GetRanAngle());
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
    		yield return X0Y0_尾6;
    		yield return X0Y0_尾7;
    		yield return X0Y0_尾8;
    		yield return X0Y0_尾9;
    		yield return X0Y0_尾10;
    		yield return X0Y0_尾11;
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
    		X0Y0_尾6CP.Update(mm);
    		X0Y0_尾7CP.Update(mm);
    		X0Y0_尾8CP.Update(mm);
    		X0Y0_尾9CP.Update(mm);
    		X0Y0_尾10CP.Update(mm);
    		X0Y0_尾11CP.Update(mm);
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
    		尾0CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		尾1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		尾2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		尾3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		尾4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		尾5CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		尾6CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		尾7CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		尾8CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		尾9CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		尾10CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		尾11CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		this.配色T(0, "尾", ref 体配色.毛0O, ref 体配色.刺青O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		this.配色T(1, "尾", ref 体配色.毛0O, ref 体配色.刺青O);
    	}
    }
}
