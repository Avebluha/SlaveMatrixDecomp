using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 下着乳首 : Ele
    {
    	public Par X0Y0_乳首;

    	public Par X0Y0_染み2;

    	public Par X0Y0_染み1;

    	public ColorD 乳首CD;

    	public ColorD 染み2CD;

    	public ColorD 染み1CD;

    	public ColorP X0Y0_乳首CP;

    	public ColorP X0Y0_染み2CP;

    	public ColorP X0Y0_染み1CP;

    	private double sb;

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

    	public bool 乳首_表示
    	{
    		get
    		{
    			return X0Y0_乳首.Dra;
    		}
    		set
    		{
    			X0Y0_乳首.Dra = value;
    			X0Y0_乳首.Hit = false;
    		}
    	}

    	public bool 染み2_表示
    	{
    		get
    		{
    			return X0Y0_染み2.Dra;
    		}
    		set
    		{
    			X0Y0_染み2.Dra = value;
    			X0Y0_染み2.Hit = false;
    		}
    	}

    	public bool 染み1_表示
    	{
    		get
    		{
    			return X0Y0_染み1.Dra;
    		}
    		set
    		{
    			X0Y0_染み1.Dra = value;
    			X0Y0_染み1.Hit = false;
    		}
    	}

    	public bool 染み表示
    	{
    		get
    		{
    			return 染み2_表示;
    		}
    		set
    		{
    			染み2_表示 = value;
    			染み1_表示 = value;
    		}
    	}

    	public double 染み濃度
    	{
    		get
    		{
    			return 染み2CD.不透明度;
    		}
    		set
    		{
    			染み2CD.不透明度 = value;
    			染み1CD.不透明度 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 乳首_表示;
    		}
    		set
    		{
    			乳首_表示 = value;
    			染み2_表示 = value;
    			染み1_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 乳首CD.不透明度;
    		}
    		set
    		{
    			乳首CD.不透明度 = value;
    			染み2CD.不透明度 = value;
    			染み1CD.不透明度 = value;
    		}
    	}

    	public double バスト
    	{
    		set
    		{
    			尺度B_ = sb * (0.9 + 0.25 * value);
    		}
    	}

    	public virtual double 尺度B_
    	{
    		get
    		{
    			return Body.CurJoinRoot.SizeBase;
    		}
    		set
    		{
    			foreach (Par item in Body.EnumAllPar())
    			{
    				item.SizeBase = value;
    			}
    			Body.JoinP();
    		}
    	}

    	public 下着乳首(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 下着乳首D e)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.胴体["下着乳首左"]);
    		Pars pars = Body[0][0];
    		X0Y0_乳首 = pars["乳首"].ToPar();
    		X0Y0_染み2 = pars["染み2"].ToPar();
    		X0Y0_染み1 = pars["染み1"].ToPar();
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
    		sb = 尺度B;
    		肥大 = e.肥大;
    		身長 = e.身長;
    		Xv = e.Xv;
    		Yv = e.Yv;
    		Xi = e.Xi;
    		Yi = e.Yi;
    		サイズ = e.サイズ;
    		サイズX = e.サイズX;
    		サイズY = e.サイズY;
    		乳首_表示 = e.乳首_表示;
    		染み2_表示 = e.染み2_表示;
    		染み1_表示 = e.染み1_表示;
    		染み表示 = e.染み表示;
    		バスト = e.バスト;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_乳首CP = new ColorP(X0Y0_乳首, 乳首CD, DisUnit, abj: true);
    		X0Y0_染み2CP = new ColorP(X0Y0_染み2, 染み2CD, DisUnit, abj: true);
    		X0Y0_染み1CP = new ColorP(X0Y0_染み1, 染み1CD, DisUnit, abj: true);
    		染み濃度 = e.染み濃度;
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_乳首CP.Update();
    		X0Y0_染み2CP.Update();
    		X0Y0_染み1CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		乳首CD = new ColorD();
    		染み2CD = new ColorD(ref Col.Empty, ref 体配色.染み);
    		染み1CD = new ColorD(ref Col.Empty, ref 体配色.染み);
    	}

    	public void 配色(Color2 配色)
    	{
    		乳首CD.線 = Col.Black;
    		乳首CD.色 = 配色;
    		X0Y0_乳首CP.Setting();
    	}
    }
}
