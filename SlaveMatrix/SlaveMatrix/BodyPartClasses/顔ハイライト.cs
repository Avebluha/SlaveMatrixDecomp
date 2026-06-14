using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class 顔ハイライト : Element
    {
    	public ShapePart X0Y0_ハイライト1;

    	public ShapePart X0Y0_ハイライト2;

    	public ColorD ハイライト1CD;

    	public ColorD ハイライト2CD;

    	public ColorP X0Y0_ハイライト1CP;

    	public ColorP X0Y0_ハイライト2CP;

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

    	public bool ハイライト1_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト1.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト1.Dra = value;
    			X0Y0_ハイライト1.Hit = value;
    		}
    	}

    	public bool ハイライト2_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト2.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト2.Dra = value;
    			X0Y0_ハイライト2.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return ハイライト1_表示;
    		}
    		set
    		{
    			ハイライト1_表示 = value;
    			ハイライト2_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return ハイライト1CD.不透明度;
    		}
    		set
    		{
    			ハイライト1CD.不透明度 = value;
    			ハイライト2CD.不透明度 = value;
    		}
    	}

    	public 顔ハイライト(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 顔ハイライトD e)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid(GlobalState.胴体["顔ハイライト左"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_ハイライト1 = partGroup["ハイライト1"].ToPar();
    		X0Y0_ハイライト2 = partGroup["ハイライト2"].ToPar();
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
    		ハイライト1_表示 = e.ハイライト1_表示;
    		ハイライト2_表示 = e.ハイライト2_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_ハイライト1CP = new ColorP(X0Y0_ハイライト1, ハイライト1CD, DisUnit, abj: true);
    		X0Y0_ハイライト2CP = new ColorP(X0Y0_ハイライト2, ハイライト2CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_ハイライト1CP.Update();
    		X0Y0_ハイライト2CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		ハイライト1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2R);
    	}
    }
}
