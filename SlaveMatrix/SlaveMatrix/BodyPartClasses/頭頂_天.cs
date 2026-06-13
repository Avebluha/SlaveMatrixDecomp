using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 頭頂_天 : 頭頂
    {
    	public ShapePart X0Y0_天輪上;

    	public ShapePart X0Y0_天輪下;

    	public ColorD 天輪CD;

    	public ColorP X0Y0_天輪上CP;

    	public ColorP X0Y0_天輪下CP;

    	private ShapePart[] Pars;

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

    	public bool 天輪上_表示
    	{
    		get
    		{
    			return X0Y0_天輪上.Dra;
    		}
    		set
    		{
    			X0Y0_天輪上.Dra = value;
    			X0Y0_天輪上.Hit = value;
    		}
    	}

    	public bool 天輪下_表示
    	{
    		get
    		{
    			return X0Y0_天輪下.Dra;
    		}
    		set
    		{
    			X0Y0_天輪下.Dra = value;
    			X0Y0_天輪下.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 天輪上_表示;
    		}
    		set
    		{
    			天輪上_表示 = value;
    			天輪下_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 天輪CD.不透明度;
    		}
    		set
    		{
    			天輪CD.不透明度 = value;
    		}
    	}

    	public 頭頂_天(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 頭頂_天D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant();
    		morphVariant.Tag = "天輪";
    		morphVariant.Add(new PartGroup(Sta.肢中["頭部前"][0][2]));
    		Body = new Difs();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_天輪上 = partGroup["天輪上"].ToPar();
    		X0Y0_天輪下 = partGroup["天輪下"].ToPar();
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
    		天輪上_表示 = e.天輪上_表示;
    		天輪下_表示 = e.天輪下_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		Pars = new ShapePart[2] { X0Y0_天輪上, X0Y0_天輪下 };
    		X0Y0_天輪上CP = new ColorP(X0Y0_天輪上, 天輪CD, DisUnit, abj: true);
    		X0Y0_天輪下CP = new ColorP(X0Y0_天輪下, 天輪CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		Pars.GetMiY_MaY(out mm);
    		X0Y0_天輪上CP.Update(mm);
    		X0Y0_天輪下CP.Update(mm);
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		天輪CD = new ColorD(ref Col.Empty, ref 体配色.後光O);
    	}
    }
}
