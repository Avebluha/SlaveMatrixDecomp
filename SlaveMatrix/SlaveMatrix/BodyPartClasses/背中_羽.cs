using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 背中_羽 : 背中
    {
    	public Par X0Y0_羽毛1;

    	public Par X0Y0_羽毛2;

    	public ColorD 羽毛1CD;

    	public ColorD 羽毛2CD;

    	public ColorP X0Y0_羽毛1CP;

    	public ColorP X0Y0_羽毛2CP;

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

    	public bool 羽毛1_表示
    	{
    		get
    		{
    			return X0Y0_羽毛1.Dra;
    		}
    		set
    		{
    			X0Y0_羽毛1.Dra = value;
    			X0Y0_羽毛1.Hit = value;
    		}
    	}

    	public bool 羽毛2_表示
    	{
    		get
    		{
    			return X0Y0_羽毛2.Dra;
    		}
    		set
    		{
    			X0Y0_羽毛2.Dra = value;
    			X0Y0_羽毛2.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 羽毛1_表示;
    		}
    		set
    		{
    			羽毛1_表示 = value;
    			羽毛2_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 羽毛1CD.不透明度;
    		}
    		set
    		{
    			羽毛1CD.不透明度 = value;
    			羽毛2CD.不透明度 = value;
    		}
    	}

    	public 背中_羽(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 背中_羽D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "羽毛";
    		dif.Add(new Pars(Sta.肢中["背中"][0][0]));
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars = 本体[0][0];
    		X0Y0_羽毛1 = pars["羽毛1"].ToPar();
    		X0Y0_羽毛2 = pars["羽毛2"].ToPar();
    		本体.SetJoints();
    		接続根 = new JointD(本体);
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
    		羽毛1_表示 = e.羽毛1_表示;
    		羽毛2_表示 = e.羽毛2_表示;
    		if (e.毛)
    		{
    			毛();
    		}
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_羽毛1CP = new ColorP(X0Y0_羽毛1, 羽毛1CD, DisUnit, abj: true);
    		X0Y0_羽毛2CP = new ColorP(X0Y0_羽毛2, 羽毛2CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public void 毛()
    	{
    		X0Y0_羽毛1.OP.SetTension(0f);
    		X0Y0_羽毛2.OP.SetTension(0f);
    	}

    	public override void 色更新()
    	{
    		X0Y0_羽毛1CP.Update();
    		X0Y0_羽毛2CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		switch (配色指定)
    		{
    		case 配色指定.N0:
    			配色N0(体配色);
    			break;
    		case 配色指定.T0:
    			配色T0(体配色);
    			break;
    		case 配色指定.T1:
    			配色T1(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		羽毛1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		羽毛2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		羽毛1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		羽毛2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		羽毛1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		羽毛2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    	}
    }
}
