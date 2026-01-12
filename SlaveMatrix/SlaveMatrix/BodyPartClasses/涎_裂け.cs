using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 涎_裂け : 涎
    {
    	public Par X0Y0_涎;

    	public Par X0Y1_涎;

    	public Par X0Y2_涎;

    	public Par X0Y3_涎;

    	public Par X0Y4_涎;

    	public ColorD 涎CD;

    	public ColorP X0Y0_涎CP;

    	public ColorP X0Y1_涎CP;

    	public ColorP X0Y2_涎CP;

    	public ColorP X0Y3_涎CP;

    	public ColorP X0Y4_涎CP;

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

    	public bool 涎_表示
    	{
    		get
    		{
    			return X0Y0_涎.Dra;
    		}
    		set
    		{
    			X0Y0_涎.Dra = value;
    			X0Y1_涎.Dra = value;
    			X0Y2_涎.Dra = value;
    			X0Y3_涎.Dra = value;
    			X0Y4_涎.Dra = value;
    			X0Y0_涎.Hit = value;
    			X0Y1_涎.Hit = value;
    			X0Y2_涎.Hit = value;
    			X0Y3_涎.Hit = value;
    			X0Y4_涎.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 涎_表示;
    		}
    		set
    		{
    			涎_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 涎CD.不透明度;
    		}
    		set
    		{
    			涎CD.不透明度 = value;
    		}
    	}

    	public 涎_裂け(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 涎_裂けD e)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.胴体["涎口裂け左"]);
    		Pars pars = Body[0][0];
    		X0Y0_涎 = pars["涎"].ToPar();
    		pars = Body[0][1];
    		X0Y1_涎 = pars["涎"].ToPar();
    		pars = Body[0][2];
    		X0Y2_涎 = pars["涎"].ToPar();
    		pars = Body[0][3];
    		X0Y3_涎 = pars["涎"].ToPar();
    		pars = Body[0][4];
    		X0Y4_涎 = pars["涎"].ToPar();
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
    		涎_表示 = e.涎_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_涎CP = new ColorP(X0Y0_涎, 涎CD, DisUnit, abj: false);
    		X0Y1_涎CP = new ColorP(X0Y1_涎, 涎CD, DisUnit, abj: false);
    		X0Y2_涎CP = new ColorP(X0Y2_涎, 涎CD, DisUnit, abj: false);
    		X0Y3_涎CP = new ColorP(X0Y3_涎, 涎CD, DisUnit, abj: false);
    		X0Y4_涎CP = new ColorP(X0Y4_涎, 涎CD, DisUnit, abj: false);
    		濃度 = e.濃度;
    	}

    	public override void 色更新()
    	{
    		switch (Body.IndexY)
    		{
    		case 0:
    			X0Y0_涎CP.Update();
    			break;
    		case 1:
    			X0Y1_涎CP.Update();
    			break;
    		case 2:
    			X0Y2_涎CP.Update();
    			break;
    		case 3:
    			X0Y3_涎CP.Update();
    			break;
    		default:
    			X0Y4_涎CP.Update();
    			break;
    		}
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		涎CD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
    	}
    }
}
