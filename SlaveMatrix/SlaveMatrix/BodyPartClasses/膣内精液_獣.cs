using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 膣内精液_獣 : 膣内精液
    {
    	public ShapePart X0Y0_精液;

    	public ShapePart X0Y0_血液1;

    	public ShapePart X0Y0_血液2;

    	public ColorD 精液CD;

    	public ColorD 血液1CD;

    	public ColorD 血液2CD;

    	public ColorP X0Y0_精液CP;

    	public ColorP X0Y0_血液1CP;

    	public ColorP X0Y0_血液2CP;

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

    	public override bool 精液_表示
    	{
    		get
    		{
    			return X0Y0_精液.Dra;
    		}
    		set
    		{
    			X0Y0_精液.Dra = value;
    			X0Y0_精液.Hit = value;
    		}
    	}

    	public override bool 血液1_表示
    	{
    		get
    		{
    			return X0Y0_血液1.Dra;
    		}
    		set
    		{
    			X0Y0_血液1.Dra = value;
    			X0Y0_血液1.Hit = value;
    		}
    	}

    	public override bool 血液2_表示
    	{
    		get
    		{
    			return X0Y0_血液2.Dra;
    		}
    		set
    		{
    			X0Y0_血液2.Dra = value;
    			X0Y0_血液2.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 精液_表示;
    		}
    		set
    		{
    			精液_表示 = value;
    			血液1_表示 = value;
    			血液2_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 精液CD.不透明度;
    		}
    		set
    		{
    			精液CD.不透明度 = value;
    			血液1CD.不透明度 = value;
    			血液2CD.不透明度 = value;
    		}
    	}

    	public override double 精液濃度
    	{
    		get
    		{
    			return 精液CD.不透明度;
    		}
    		set
    		{
    			精液CD.不透明度 = value;
    		}
    	}

    	public 膣内精液_獣(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 膣内精液_獣D e)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.半身["四足膣内精液"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_精液 = partGroup["精液"].ToPar();
    		X0Y0_血液1 = partGroup["血液1"].ToPar();
    		X0Y0_血液2 = partGroup["血液2"].ToPar();
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
    		精液_表示 = e.精液_表示;
    		血液1_表示 = e.血液1_表示;
    		血液2_表示 = e.血液2_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_精液CP = new ColorP(X0Y0_精液, 精液CD, DisUnit, abj: true);
    		X0Y0_血液1CP = new ColorP(X0Y0_血液1, 血液1CD, DisUnit, abj: true);
    		X0Y0_血液2CP = new ColorP(X0Y0_血液2, 血液2CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		精液濃度 = e.精液濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_精液CP.Update();
    		X0Y0_血液1CP.Update();
    		X0Y0_血液2CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		精液CD = new ColorD();
    		血液1CD = new ColorD(ref Col.Empty, ref 体配色.血液O);
    		血液2CD = new ColorD(ref Col.Empty, ref 体配色.血液O);
    	}

    	public void 精液配色(主人公配色 配色)
    	{
    		精液CD.線 = 配色.精線;
    		精液CD.色 = 配色.精液ぶっかけ;
    		X0Y0_精液CP.Setting();
    	}
    }
}
