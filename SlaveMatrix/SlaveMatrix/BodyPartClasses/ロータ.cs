using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class ロータ : Element
    {
    	public ShapePart X0Y0_ロータ;

    	public ShapePart X0Y0_ロータ線;

    	public ShapePart X0Y0_コード;

    	public ShapePart X0Y1_ロータ;

    	public ShapePart X0Y1_ロータ線;

    	public ShapePart X0Y1_コード;

    	public ShapePart X0Y2_ロータ;

    	public ShapePart X0Y2_ロータ線;

    	public ShapePart X0Y2_コード;

    	public ShapePart X0Y3_ロータ;

    	public ShapePart X0Y3_コード;

    	public ShapePart X0Y4_ロータ;

    	public ShapePart X0Y4_コード;

    	public ColorD ロータCD;

    	public ColorD ロータ線CD;

    	public ColorD コードCD;

    	public ColorP X0Y0_ロータCP;

    	public ColorP X0Y0_ロータ線CP;

    	public ColorP X0Y0_コードCP;

    	public ColorP X0Y1_ロータCP;

    	public ColorP X0Y1_ロータ線CP;

    	public ColorP X0Y1_コードCP;

    	public ColorP X0Y2_ロータCP;

    	public ColorP X0Y2_ロータ線CP;

    	public ColorP X0Y2_コードCP;

    	public ColorP X0Y3_ロータCP;

    	public ColorP X0Y3_コードCP;

    	public ColorP X0Y4_ロータCP;

    	public ColorP X0Y4_コードCP;

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

    	public bool ロータ_表示
    	{
    		get
    		{
    			return X0Y0_ロータ.Dra;
    		}
    		set
    		{
    			X0Y0_ロータ.Dra = value;
    			X0Y1_ロータ.Dra = value;
    			X0Y2_ロータ.Dra = value;
    			X0Y3_ロータ.Dra = value;
    			X0Y4_ロータ.Dra = value;
    			X0Y0_ロータ.Hit = value;
    			X0Y1_ロータ.Hit = value;
    			X0Y2_ロータ.Hit = value;
    			X0Y3_ロータ.Hit = value;
    			X0Y4_ロータ.Hit = value;
    		}
    	}

    	public bool ロータ線_表示
    	{
    		get
    		{
    			return X0Y0_ロータ線.Dra;
    		}
    		set
    		{
    			X0Y0_ロータ線.Dra = value;
    			X0Y1_ロータ線.Dra = value;
    			X0Y2_ロータ線.Dra = value;
    			X0Y0_ロータ線.Hit = value;
    			X0Y1_ロータ線.Hit = value;
    			X0Y2_ロータ線.Hit = value;
    		}
    	}

    	public bool コード_表示
    	{
    		get
    		{
    			return X0Y0_コード.Dra;
    		}
    		set
    		{
    			X0Y0_コード.Dra = value;
    			X0Y1_コード.Dra = value;
    			X0Y2_コード.Dra = value;
    			X0Y3_コード.Dra = value;
    			X0Y4_コード.Dra = value;
    			X0Y0_コード.Hit = value;
    			X0Y1_コード.Hit = value;
    			X0Y2_コード.Hit = value;
    			X0Y3_コード.Hit = value;
    			X0Y4_コード.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return ロータ_表示;
    		}
    		set
    		{
    			ロータ_表示 = value;
    			ロータ線_表示 = value;
    			コード_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return ロータCD.不透明度;
    		}
    		set
    		{
    			ロータCD.不透明度 = value;
    			ロータ線CD.不透明度 = value;
    			コードCD.不透明度 = value;
    		}
    	}

    	public ロータ(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, ロータD e)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid(Sta.カーソル["ロータ"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_ロータ = partGroup["ロータ"].ToPar();
    		X0Y0_ロータ線 = partGroup["ロータ線"].ToPar();
    		X0Y0_コード = partGroup["コード"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_ロータ = partGroup["ロータ"].ToPar();
    		X0Y1_ロータ線 = partGroup["ロータ線"].ToPar();
    		X0Y1_コード = partGroup["コード"].ToPar();
    		partGroup = Body[0][2];
    		X0Y2_ロータ = partGroup["ロータ"].ToPar();
    		X0Y2_ロータ線 = partGroup["ロータ線"].ToPar();
    		X0Y2_コード = partGroup["コード"].ToPar();
    		partGroup = Body[0][3];
    		X0Y3_ロータ = partGroup["ロータ"].ToPar();
    		X0Y3_コード = partGroup["コード"].ToPar();
    		partGroup = Body[0][4];
    		X0Y4_ロータ = partGroup["ロータ"].ToPar();
    		X0Y4_コード = partGroup["コード"].ToPar();
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
    		ロータ_表示 = e.ロータ_表示;
    		ロータ線_表示 = e.ロータ線_表示;
    		コード_表示 = e.コード_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_ロータCP = new ColorP(X0Y0_ロータ, ロータCD, DisUnit, abj: true);
    		X0Y0_ロータ線CP = new ColorP(X0Y0_ロータ線, ロータ線CD, DisUnit, abj: true);
    		X0Y0_コードCP = new ColorP(X0Y0_コード, コードCD, DisUnit, abj: true);
    		X0Y1_ロータCP = new ColorP(X0Y1_ロータ, ロータCD, DisUnit, abj: true);
    		X0Y1_ロータ線CP = new ColorP(X0Y1_ロータ線, ロータ線CD, DisUnit, abj: true);
    		X0Y1_コードCP = new ColorP(X0Y1_コード, コードCD, DisUnit, abj: true);
    		X0Y2_ロータCP = new ColorP(X0Y2_ロータ, ロータCD, DisUnit, abj: true);
    		X0Y2_ロータ線CP = new ColorP(X0Y2_ロータ線, ロータ線CD, DisUnit, abj: true);
    		X0Y2_コードCP = new ColorP(X0Y2_コード, コードCD, DisUnit, abj: true);
    		X0Y3_ロータCP = new ColorP(X0Y3_ロータ, ロータCD, DisUnit, abj: true);
    		X0Y3_コードCP = new ColorP(X0Y3_コード, コードCD, DisUnit, abj: true);
    		X0Y4_ロータCP = new ColorP(X0Y4_ロータ, ロータCD, DisUnit, abj: true);
    		X0Y4_コードCP = new ColorP(X0Y4_コード, コードCD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		X0Y0_ロータ.BasePointBase = X0Y0_ロータ.ToLocal(X0Y0_ロータ.ToGlobal(X0Y0_ロータ.JP[2].Joint));
    		X0Y1_ロータ.BasePointBase = X0Y1_ロータ.ToLocal(X0Y1_ロータ.ToGlobal(X0Y1_ロータ.JP[2].Joint));
    		X0Y2_ロータ.BasePointBase = X0Y2_ロータ.ToLocal(X0Y2_ロータ.ToGlobal(X0Y2_ロータ.JP[2].Joint));
    		X0Y3_ロータ.BasePointBase = X0Y3_ロータ.ToLocal(X0Y3_ロータ.ToGlobal(X0Y3_ロータ.JP[1].Joint));
    		X0Y4_ロータ.BasePointBase = X0Y4_ロータ.ToLocal(X0Y4_ロータ.ToGlobal(X0Y4_ロータ.JP[1].Joint));
    		尺度B = 1.08;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		switch (Body.IndexY)
    		{
    		case 0:
    			X0Y0_ロータCP.Update();
    			X0Y0_ロータ線CP.Update();
    			X0Y0_コードCP.Update();
    			break;
    		case 1:
    			X0Y1_ロータCP.Update();
    			X0Y1_ロータ線CP.Update();
    			X0Y1_コードCP.Update();
    			break;
    		case 2:
    			X0Y2_ロータCP.Update();
    			X0Y2_ロータ線CP.Update();
    			X0Y2_コードCP.Update();
    			break;
    		case 3:
    			X0Y3_ロータCP.Update();
    			X0Y3_コードCP.Update();
    			break;
    		default:
    			X0Y4_ロータCP.Update();
    			X0Y4_コードCP.Update();
    			break;
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		ColorHelper.GetGrad(ref ColorHelper.Violet, out var ret);
    		ロータCD = new ColorD(ref ColorHelper.Black, ref ret);
    		ロータ線CD = new ColorD(ref ColorHelper.Black, ref ret);
    		ret.Col2 = Color.FromArgb(0, ret.Col2);
    		コードCD = new ColorD(ref ColorHelper.Black, ref ret);
    	}
    }
}
