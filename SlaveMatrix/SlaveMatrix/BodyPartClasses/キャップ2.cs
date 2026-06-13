using _2DGAMELIB;

namespace SlaveMatrix
{
    public class キャップ2 : Ele
    {
    	public ShapePart X0Y0_根本;

    	public ShapePart X0Y0_先端;

    	public ColorD 根本CD;

    	public ColorD 先端CD;

    	public ColorP X0Y0_根本CP;

    	public ColorP X0Y0_先端CP;

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

    	public bool 根本_表示
    	{
    		get
    		{
    			return X0Y0_根本.Dra;
    		}
    		set
    		{
    			X0Y0_根本.Dra = value;
    			X0Y0_根本.Hit = value;
    		}
    	}

    	public bool 先端_表示
    	{
    		get
    		{
    			return X0Y0_先端.Dra;
    		}
    		set
    		{
    			X0Y0_先端.Dra = value;
    			X0Y0_先端.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 根本_表示;
    		}
    		set
    		{
    			根本_表示 = value;
    			先端_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 根本CD.不透明度;
    		}
    		set
    		{
    			根本CD.不透明度 = value;
    			先端CD.不透明度 = value;
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

    	public キャップ2(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, キャップ2D e)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.胴体["キャップ左"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_根本 = partGroup["根本"].ToPar();
    		X0Y0_先端 = partGroup["先端"].ToPar();
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
    		根本_表示 = e.根本_表示;
    		先端_表示 = e.先端_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_根本CP = new ColorP(X0Y0_根本, 根本CD, DisUnit, abj: true);
    		X0Y0_先端CP = new ColorP(X0Y0_先端, 先端CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_根本CP.Update();
    		X0Y0_先端CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		根本CD = new ColorD();
    		先端CD = new ColorD();
    	}

    	public void 配色(キャップ色 配色)
    	{
    		根本CD.色 = 配色.根本色;
    		先端CD.色 = 配色.先端色;
    	}
    }
}
