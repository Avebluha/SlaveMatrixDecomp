using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 汗 : Ele
    {
    	public Par X0Y0_汗0;

    	public Par X0Y0_汗1;

    	public Par X0Y0_汗ハイライト;

    	public Par X0Y1_汗0流れ;

    	public Par X0Y2_汗0流れ;

    	public Par X0Y3_汗0流れ;

    	public Par X0Y4_汗0流れ;

    	public ColorD 汗0流れCD;

    	public ColorD 汗0CD;

    	public ColorD 汗1CD;

    	public ColorD 汗ハイライトCD;

    	public ColorP X0Y0_汗0CP;

    	public ColorP X0Y0_汗1CP;

    	public ColorP X0Y0_汗ハイライトCP;

    	public ColorP X0Y1_汗0流れCP;

    	public ColorP X0Y2_汗0流れCP;

    	public ColorP X0Y3_汗0流れCP;

    	public ColorP X0Y4_汗0流れCP;

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

    	public bool 汗0_表示
    	{
    		get
    		{
    			return X0Y0_汗0.Dra;
    		}
    		set
    		{
    			X0Y0_汗0.Dra = value;
    			X0Y0_汗0.Hit = value;
    		}
    	}

    	public bool 汗1_表示
    	{
    		get
    		{
    			return X0Y0_汗1.Dra;
    		}
    		set
    		{
    			X0Y0_汗1.Dra = value;
    			X0Y0_汗1.Hit = value;
    		}
    	}

    	public bool 汗ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_汗ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_汗ハイライト.Dra = value;
    			X0Y0_汗ハイライト.Hit = value;
    		}
    	}

    	public bool 汗0流れ_表示
    	{
    		get
    		{
    			return X0Y1_汗0流れ.Dra;
    		}
    		set
    		{
    			X0Y1_汗0流れ.Dra = value;
    			X0Y2_汗0流れ.Dra = value;
    			X0Y3_汗0流れ.Dra = value;
    			X0Y4_汗0流れ.Dra = value;
    			X0Y1_汗0流れ.Hit = value;
    			X0Y2_汗0流れ.Hit = value;
    			X0Y3_汗0流れ.Hit = value;
    			X0Y4_汗0流れ.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 汗0_表示;
    		}
    		set
    		{
    			汗0_表示 = value;
    			汗1_表示 = value;
    			汗ハイライト_表示 = value;
    			汗0流れ_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 汗0流れCD.不透明度;
    		}
    		set
    		{
    			汗0流れCD.不透明度 = value;
    			汗0CD.不透明度 = value;
    			汗1CD.不透明度 = value;
    			汗ハイライトCD.不透明度 = value;
    		}
    	}

    	public 汗(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 汗D e)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.スタンプ["汗"]);
    		Pars pars = Body[0][0];
    		X0Y0_汗0 = pars["汗0"].ToPar();
    		X0Y0_汗1 = pars["汗1"].ToPar();
    		X0Y0_汗ハイライト = pars["汗ハイライト"].ToPar();
    		pars = Body[0][1];
    		X0Y1_汗0流れ = pars["汗0流れ"].ToPar();
    		pars = Body[0][2];
    		X0Y2_汗0流れ = pars["汗0流れ"].ToPar();
    		pars = Body[0][3];
    		X0Y3_汗0流れ = pars["汗0流れ"].ToPar();
    		pars = Body[0][4];
    		X0Y4_汗0流れ = pars["汗0流れ"].ToPar();
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
    		汗0_表示 = e.汗0_表示;
    		汗1_表示 = e.汗1_表示;
    		汗ハイライト_表示 = e.汗ハイライト_表示;
    		汗0流れ_表示 = e.汗0流れ_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_汗0CP = new ColorP(X0Y0_汗0, 汗0CD, DisUnit, abj: true);
    		X0Y0_汗1CP = new ColorP(X0Y0_汗1, 汗1CD, DisUnit, abj: true);
    		X0Y0_汗ハイライトCP = new ColorP(X0Y0_汗ハイライト, 汗ハイライトCD, DisUnit, abj: true);
    		X0Y1_汗0流れCP = new ColorP(X0Y1_汗0流れ, 汗0流れCD, DisUnit, abj: true);
    		X0Y2_汗0流れCP = new ColorP(X0Y2_汗0流れ, 汗0流れCD, DisUnit, abj: true);
    		X0Y3_汗0流れCP = new ColorP(X0Y3_汗0流れ, 汗0流れCD, DisUnit, abj: true);
    		X0Y4_汗0流れCP = new ColorP(X0Y4_汗0流れ, 汗0流れCD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		switch (Body.IndexY)
    		{
    		case 0:
    			X0Y0_汗0CP.Update();
    			X0Y0_汗1CP.Update();
    			X0Y0_汗ハイライトCP.Update();
    			break;
    		case 1:
    			X0Y1_汗0流れCP.Update();
    			break;
    		case 2:
    			X0Y2_汗0流れCP.Update();
    			break;
    		case 3:
    			X0Y3_汗0流れCP.Update();
    			break;
    		default:
    			X0Y4_汗0流れCP.Update();
    			break;
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		汗0流れCD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
    		汗0CD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
    		汗1CD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
    		汗ハイライトCD = new ColorD(ref 体配色.ハイライト.Col1, ref 体配色.ハイライト);
    	}
    }
}
