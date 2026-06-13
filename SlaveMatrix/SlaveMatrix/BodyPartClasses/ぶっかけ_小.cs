using _2DGAMELIB;

namespace SlaveMatrix
{
    public class ぶっかけ_小 : Ele
    {
    	public ShapePart X0Y0_精液;

    	public ShapePart X0Y1_精液;

    	public ShapePart X0Y2_精液;

    	public ShapePart X0Y3_精液;

    	public ShapePart X0Y4_精液;

    	public ColorD 精液CD;

    	public ColorP X0Y0_精液CP;

    	public ColorP X0Y1_精液CP;

    	public ColorP X0Y2_精液CP;

    	public ColorP X0Y3_精液CP;

    	public ColorP X0Y4_精液CP;

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

    	public bool 精液_表示
    	{
    		get
    		{
    			return X0Y0_精液.Dra;
    		}
    		set
    		{
    			X0Y0_精液.Dra = value;
    			X0Y1_精液.Dra = value;
    			X0Y2_精液.Dra = value;
    			X0Y3_精液.Dra = value;
    			X0Y4_精液.Dra = value;
    			X0Y0_精液.Hit = value;
    			X0Y1_精液.Hit = value;
    			X0Y2_精液.Hit = value;
    			X0Y3_精液.Hit = value;
    			X0Y4_精液.Hit = value;
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
    		}
    	}

    	public ぶっかけ_小(double DisUnit, 配色指定 配色指定, 主人公配色 体配色, ModeEventDispatcher Med, ぶっかけ_小D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(Sta.スタンプ["ぶっかけ"][0]);
    		Body = new Difs();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_精液 = partGroup["精液"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_精液 = partGroup["精液"].ToPar();
    		partGroup = Body[0][2];
    		X0Y2_精液 = partGroup["精液"].ToPar();
    		partGroup = Body[0][3];
    		X0Y3_精液 = partGroup["精液"].ToPar();
    		partGroup = Body[0][4];
    		X0Y4_精液 = partGroup["精液"].ToPar();
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
    		X0Y1_精液CP = new ColorP(X0Y1_精液, 精液CD, DisUnit, abj: true);
    		X0Y2_精液CP = new ColorP(X0Y2_精液, 精液CD, DisUnit, abj: true);
    		X0Y3_精液CP = new ColorP(X0Y3_精液, 精液CD, DisUnit, abj: true);
    		X0Y4_精液CP = new ColorP(X0Y4_精液, 精液CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		switch (Body.IndexY)
    		{
    		case 0:
    			X0Y0_精液CP.Update();
    			break;
    		case 1:
    			X0Y1_精液CP.Update();
    			break;
    		case 2:
    			X0Y2_精液CP.Update();
    			break;
    		case 3:
    			X0Y3_精液CP.Update();
    			break;
    		default:
    			X0Y4_精液CP.Update();
    			break;
    		}
    	}

    	private void 配色(主人公配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(主人公配色 体配色)
    	{
    		精液CD = new ColorD(ref 体配色.精線, ref 体配色.精液ぶっかけ);
    	}
    }
}
