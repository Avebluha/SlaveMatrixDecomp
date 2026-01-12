using _2DGAMELIB;

namespace SlaveMatrix
{
    public class SideHair_ジグ : SideHair
    {
    	public Par X0Y0_髪1;

    	public Par X0Y0_髪2;

    	public ColorD 髪1CD;

    	public ColorD 髪2CD;

    	public ColorP X0Y0_髪1CP;

    	public ColorP X0Y0_髪2CP;

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

    	public bool 髪1_表示
    	{
    		get
    		{
    			return X0Y0_髪1.Dra;
    		}
    		set
    		{
    			X0Y0_髪1.Dra = value;
    			X0Y0_髪1.Hit = value;
    		}
    	}

    	public bool 髪2_表示
    	{
    		get
    		{
    			return X0Y0_髪2.Dra;
    		}
    		set
    		{
    			X0Y0_髪2.Dra = value;
    			X0Y0_髪2.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 髪1_表示;
    		}
    		set
    		{
    			髪1_表示 = value;
    			髪2_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 髪1CD.不透明度;
    		}
    		set
    		{
    			髪1CD.不透明度 = value;
    			髪2CD.不透明度 = value;
    		}
    	}

    	public double 髪長1
    	{
    		set
    		{
    			double num = 0.8 + 0.3 * value;
    			X0Y0_髪1.SizeYBase *= num;
    		}
    	}

    	public double 髪長2
    	{
    		set
    		{
    			double num = 0.8 + 0.3 * value;
    			X0Y0_髪2.SizeYBase *= num;
    		}
    	}

    	public double 毛量
    	{
    		set
    		{
    			double num = 1.0 + 0.1 * value;
    			X0Y0_髪1.SizeXBase *= num;
    			X0Y0_髪2.SizeXBase *= num;
    		}
    	}

    	public double 広がり
    	{
    		set
    		{
    			double num = (右 ? (-1.0) : 1.0);
    			X0Y0_髪2.AngleBase = num * 3.0 * value;
    		}
    	}

    	public SideHair_ジグ(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, SideHair_ジグD e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "ジグ";
    		dif.Add(new Pars(Sta.胴体["横髪左"][0][0]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_髪1 = pars["髪1"].ToPar();
    		X0Y0_髪2 = pars["髪2"].ToPar();
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
    		髪1_表示 = e.髪1_表示;
    		髪2_表示 = e.髪2_表示;
    		髪長1 = e.髪長1;
    		髪長2 = e.髪長2;
    		毛量 = e.毛量;
    		広がり = e.広がり;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_髪1CP = new ColorP(X0Y0_髪1, 髪1CD, DisUnit, abj: false);
    		X0Y0_髪2CP = new ColorP(X0Y0_髪2, 髪2CD, DisUnit, abj: false);
    		濃度 = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_髪1CP.Update();
    		X0Y0_髪2CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		髪1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    	}
    }
}
