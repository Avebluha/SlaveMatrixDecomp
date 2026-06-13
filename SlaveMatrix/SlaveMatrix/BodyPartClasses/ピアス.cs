using _2DGAMELIB;

namespace SlaveMatrix
{
    public class ピアス : Ele
    {
    	public ShapePart X0Y0_ピアス;

    	public ColorD ピアスCD;

    	public ColorP X0Y0_ピアスCP;

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

    	public bool ピアス_表示
    	{
    		get
    		{
    			return X0Y0_ピアス.Dra;
    		}
    		set
    		{
    			X0Y0_ピアス.Dra = value;
    			X0Y0_ピアス.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return ピアス_表示;
    		}
    		set
    		{
    			ピアス_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return ピアスCD.不透明度;
    		}
    		set
    		{
    			ピアスCD.不透明度 = value;
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

    	public ピアス(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, ピアスD e)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid(Sta.性器付["ピアス"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_ピアス = partGroup["ピアス"].ToPar();
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
    		ピアス_表示 = e.ピアス_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_ピアスCP = new ColorP(X0Y0_ピアス, ピアスCD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_ピアスCP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		ピアスCD = new ColorD();
    	}

    	public void 配色(ピアス色 配色)
    	{
    		ピアスCD.色 = 配色.金具色;
    	}
    }
}
