using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 鰭_豚 : 鰭
    {
    	public ShapePart X0Y0_鰭;

    	public ColorD 鰭CD;

    	public ColorP X0Y0_鰭CP;

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

    	public bool 鰭_表示
    	{
    		get
    		{
    			return X0Y0_鰭.Dra;
    		}
    		set
    		{
    			X0Y0_鰭.Dra = value;
    			X0Y0_鰭.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 鰭_表示;
    		}
    		set
    		{
    			鰭_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 鰭CD.不透明度;
    		}
    		set
    		{
    			鰭CD.不透明度 = value;
    		}
    	}

    	public 鰭_豚(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 鰭_豚D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant();
    		morphVariant.Tag = "豚鰭";
    		morphVariant.Add(new PartGroup(Sta.肢左["鰭"][1][0]));
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_鰭 = partGroup["鰭"].ToPar();
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
    		鰭_表示 = e.鰭_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_鰭CP = new ColorP(X0Y0_鰭, 鰭CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_鰭.AngleBase = num * -20.0;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		X0Y0_鰭CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		鰭CD = new ColorD(ref ColorHelper.Black, ref 体配色.体0O);
    	}
    }
}
