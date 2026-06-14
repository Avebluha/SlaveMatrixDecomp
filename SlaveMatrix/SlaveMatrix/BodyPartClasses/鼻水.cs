using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class 鼻水 : Element
    {
    	public ShapePart X0Y0_鼻水;

    	public ShapePart X0Y1_鼻水;

    	public ShapePart X0Y2_鼻水;

    	public ShapePart X0Y3_鼻水;

    	public ShapePart X0Y4_鼻水;

    	public ColorD 鼻水CD;

    	public ColorP X0Y0_鼻水CP;

    	public ColorP X0Y1_鼻水CP;

    	public ColorP X0Y2_鼻水CP;

    	public ColorP X0Y3_鼻水CP;

    	public ColorP X0Y4_鼻水CP;

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

    	public bool 鼻水_表示
    	{
    		get
    		{
    			return X0Y0_鼻水.Dra;
    		}
    		set
    		{
    			X0Y0_鼻水.Dra = value;
    			X0Y1_鼻水.Dra = value;
    			X0Y2_鼻水.Dra = value;
    			X0Y3_鼻水.Dra = value;
    			X0Y4_鼻水.Dra = value;
    			X0Y0_鼻水.Hit = value;
    			X0Y1_鼻水.Hit = value;
    			X0Y2_鼻水.Hit = value;
    			X0Y3_鼻水.Hit = value;
    			X0Y4_鼻水.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 鼻水_表示;
    		}
    		set
    		{
    			鼻水_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 鼻水CD.不透明度;
    		}
    		set
    		{
    			鼻水CD.不透明度 = value;
    		}
    	}

    	public override double 肥大
    	{
    		set
    		{
    		}
    	}

    	public override double 身長
    	{
    		set
    		{
    		}
    	}

    	public 鼻水(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 鼻水D e)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid(GlobalState.胴体["鼻水左"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_鼻水 = partGroup["鼻水"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_鼻水 = partGroup["鼻水"].ToPar();
    		partGroup = Body[0][2];
    		X0Y2_鼻水 = partGroup["鼻水"].ToPar();
    		partGroup = Body[0][3];
    		X0Y3_鼻水 = partGroup["鼻水"].ToPar();
    		partGroup = Body[0][4];
    		X0Y4_鼻水 = partGroup["鼻水"].ToPar();
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
    		鼻水_表示 = e.鼻水_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_鼻水CP = new ColorP(X0Y0_鼻水, 鼻水CD, DisUnit, abj: false);
    		X0Y1_鼻水CP = new ColorP(X0Y1_鼻水, 鼻水CD, DisUnit, abj: false);
    		X0Y2_鼻水CP = new ColorP(X0Y2_鼻水, 鼻水CD, DisUnit, abj: false);
    		X0Y3_鼻水CP = new ColorP(X0Y3_鼻水, 鼻水CD, DisUnit, abj: false);
    		X0Y4_鼻水CP = new ColorP(X0Y4_鼻水, 鼻水CD, DisUnit, abj: false);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		switch (Body.GetIndexY())
    		{
    		case 0:
    			X0Y0_鼻水CP.Update();
    			break;
    		case 1:
    			X0Y1_鼻水CP.Update();
    			break;
    		case 2:
    			X0Y2_鼻水CP.Update();
    			break;
    		case 3:
    			X0Y3_鼻水CP.Update();
    			break;
    		default:
    			X0Y4_鼻水CP.Update();
    			break;
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		鼻水CD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
    	}
    }
}
