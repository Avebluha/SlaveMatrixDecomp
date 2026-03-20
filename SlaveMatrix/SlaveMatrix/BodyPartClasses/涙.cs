using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 涙 : Ele
    {
    	public Par X0Y0_涙0流れ0;

    	public Par X0Y0_涙0;

    	public Par X0Y0_涙1;

    	public Par X0Y0_涙ハイライト;

    	public Par X0Y1_涙0流れ0;

    	public Par X0Y1_涙0流れ1;

    	public Par X0Y1_涙0;

    	public Par X0Y1_涙1;

    	public Par X0Y1_涙ハイライト;

    	public Par X0Y2_涙0流れ0;

    	public Par X0Y2_涙0流れ1;

    	public Par X0Y2_涙0;

    	public Par X0Y2_涙1;

    	public Par X0Y2_涙ハイライト;

    	public Par X0Y3_涙0流れ0;

    	public Par X0Y3_涙0流れ1;

    	public Par X0Y3_涙0;

    	public Par X0Y3_涙1;

    	public Par X0Y3_涙ハイライト;

    	public Par X0Y4_涙0流れ0;

    	public Par X0Y4_涙0流れ1;

    	public Par X0Y4_涙0;

    	public Par X0Y4_涙1;

    	public Par X0Y4_涙ハイライト;

    	public Par X0Y5_涙0流れ0;

    	public Par X0Y5_涙0流れ1;

    	public Par X0Y5_涙0;

    	public Par X0Y5_涙1;

    	public Par X0Y5_涙ハイライト;

    	public ColorD 涙0流れ0CD;

    	public ColorD Tear0流れ1CD;

    	public ColorD 涙0CD;

    	public ColorD 涙1CD;

    	public ColorD 涙ハイライトCD;

    	public ColorP X0Y0_涙0流れ0CP;

    	public ColorP X0Y0_涙0CP;

    	public ColorP X0Y0_涙1CP;

    	public ColorP X0Y0_涙ハイライトCP;

    	public ColorP X0Y1_涙0流れ0CP;

    	public ColorP X0Y1_涙0流れ1CP;

    	public ColorP X0Y1_涙0CP;

    	public ColorP X0Y1_涙1CP;

    	public ColorP X0Y1_涙ハイライトCP;

    	public ColorP X0Y2_涙0流れ0CP;

    	public ColorP X0Y2_涙0流れ1CP;

    	public ColorP X0Y2_涙0CP;

    	public ColorP X0Y2_涙1CP;

    	public ColorP X0Y2_涙ハイライトCP;

    	public ColorP X0Y3_涙0流れ0CP;

    	public ColorP X0Y3_涙0流れ1CP;

    	public ColorP X0Y3_涙0CP;

    	public ColorP X0Y3_涙1CP;

    	public ColorP X0Y3_涙ハイライトCP;

    	public ColorP X0Y4_涙0流れ0CP;

    	public ColorP X0Y4_涙0流れ1CP;

    	public ColorP X0Y4_涙0CP;

    	public ColorP X0Y4_涙1CP;

    	public ColorP X0Y4_涙ハイライトCP;

    	public ColorP X0Y5_涙0流れ0CP;

    	public ColorP X0Y5_涙0流れ1CP;

    	public ColorP X0Y5_涙0CP;

    	public ColorP X0Y5_涙1CP;

    	public ColorP X0Y5_涙ハイライトCP;

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

    	public bool Tear0流れ0_表示
    	{
    		get
    		{
    			return X0Y0_涙0流れ0.Dra;
    		}
    		set
    		{
    			X0Y0_涙0流れ0.Dra = value;
    			X0Y1_涙0流れ0.Dra = value;
    			X0Y2_涙0流れ0.Dra = value;
    			X0Y3_涙0流れ0.Dra = value;
    			X0Y4_涙0流れ0.Dra = value;
    			X0Y5_涙0流れ0.Dra = value;
    			X0Y0_涙0流れ0.Hit = value;
    			X0Y1_涙0流れ0.Hit = value;
    			X0Y2_涙0流れ0.Hit = value;
    			X0Y3_涙0流れ0.Hit = value;
    			X0Y4_涙0流れ0.Hit = value;
    			X0Y5_涙0流れ0.Hit = value;
    		}
    	}

    	public bool Tear0_表示
    	{
    		get
    		{
    			return X0Y0_涙0.Dra;
    		}
    		set
    		{
    			X0Y0_涙0.Dra = value;
    			X0Y1_涙0.Dra = value;
    			X0Y2_涙0.Dra = value;
    			X0Y3_涙0.Dra = value;
    			X0Y4_涙0.Dra = value;
    			X0Y5_涙0.Dra = value;
    			X0Y0_涙0.Hit = value;
    			X0Y1_涙0.Hit = value;
    			X0Y2_涙0.Hit = value;
    			X0Y3_涙0.Hit = value;
    			X0Y4_涙0.Hit = value;
    			X0Y5_涙0.Hit = value;
    		}
    	}

    	public bool 涙1_表示
    	{
    		get
    		{
    			return X0Y0_涙1.Dra;
    		}
    		set
    		{
    			X0Y0_涙1.Dra = value;
    			X0Y1_涙1.Dra = value;
    			X0Y2_涙1.Dra = value;
    			X0Y3_涙1.Dra = value;
    			X0Y4_涙1.Dra = value;
    			X0Y5_涙1.Dra = value;
    			X0Y0_涙1.Hit = value;
    			X0Y1_涙1.Hit = value;
    			X0Y2_涙1.Hit = value;
    			X0Y3_涙1.Hit = value;
    			X0Y4_涙1.Hit = value;
    			X0Y5_涙1.Hit = value;
    		}
    	}

    	public bool Tearハイライト_表示
    	{
    		get
    		{
    			return X0Y0_涙ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_涙ハイライト.Dra = value;
    			X0Y1_涙ハイライト.Dra = value;
    			X0Y2_涙ハイライト.Dra = value;
    			X0Y3_涙ハイライト.Dra = value;
    			X0Y4_涙ハイライト.Dra = value;
    			X0Y5_涙ハイライト.Dra = value;
    			X0Y0_涙ハイライト.Hit = value;
    			X0Y1_涙ハイライト.Hit = value;
    			X0Y2_涙ハイライト.Hit = value;
    			X0Y3_涙ハイライト.Hit = value;
    			X0Y4_涙ハイライト.Hit = value;
    			X0Y5_涙ハイライト.Hit = value;
    		}
    	}

    	public bool Tear0流れ1_表示
    	{
    		get
    		{
    			return X0Y1_涙0流れ1.Dra;
    		}
    		set
    		{
    			X0Y1_涙0流れ1.Dra = value;
    			X0Y2_涙0流れ1.Dra = value;
    			X0Y3_涙0流れ1.Dra = value;
    			X0Y4_涙0流れ1.Dra = value;
    			X0Y5_涙0流れ1.Dra = value;
    			X0Y1_涙0流れ1.Hit = value;
    			X0Y2_涙0流れ1.Hit = value;
    			X0Y3_涙0流れ1.Hit = value;
    			X0Y4_涙0流れ1.Hit = value;
    			X0Y5_涙0流れ1.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return Tear0流れ0_表示;
    		}
    		set
    		{
    			Tear0流れ0_表示 = value;
    			Tear0_表示 = value;
    			涙1_表示 = value;
    			Tearハイライト_表示 = value;
    			Tear0流れ1_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 涙0流れ0CD.不透明度;
    		}
    		set
    		{
    			涙0流れ0CD.不透明度 = value;
    			Tear0流れ1CD.不透明度 = value;
    			涙0CD.不透明度 = value;
    			涙1CD.不透明度 = value;
    			涙ハイライトCD.不透明度 = value;
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

    	public 涙(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 涙D e)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.胴体["涙左"]);
    		Pars pars = Body[0][0];
    		X0Y0_涙0流れ0 = pars["涙0流れ0"].ToPar();
    		X0Y0_涙0 = pars["涙0"].ToPar();
    		X0Y0_涙1 = pars["涙1"].ToPar();
    		X0Y0_涙ハイライト = pars["涙ハイライト"].ToPar();
    		pars = Body[0][1];
    		X0Y1_涙0流れ0 = pars["涙0流れ0"].ToPar();
    		X0Y1_涙0流れ1 = pars["涙0流れ1"].ToPar();
    		X0Y1_涙0 = pars["涙0"].ToPar();
    		X0Y1_涙1 = pars["涙1"].ToPar();
    		X0Y1_涙ハイライト = pars["涙ハイライト"].ToPar();
    		pars = Body[0][2];
    		X0Y2_涙0流れ0 = pars["涙0流れ0"].ToPar();
    		X0Y2_涙0流れ1 = pars["涙0流れ1"].ToPar();
    		X0Y2_涙0 = pars["涙0"].ToPar();
    		X0Y2_涙1 = pars["涙1"].ToPar();
    		X0Y2_涙ハイライト = pars["涙ハイライト"].ToPar();
    		pars = Body[0][3];
    		X0Y3_涙0流れ0 = pars["涙0流れ0"].ToPar();
    		X0Y3_涙0流れ1 = pars["涙0流れ1"].ToPar();
    		X0Y3_涙0 = pars["涙0"].ToPar();
    		X0Y3_涙1 = pars["涙1"].ToPar();
    		X0Y3_涙ハイライト = pars["涙ハイライト"].ToPar();
    		pars = Body[0][4];
    		X0Y4_涙0流れ0 = pars["涙0流れ0"].ToPar();
    		X0Y4_涙0流れ1 = pars["涙0流れ1"].ToPar();
    		X0Y4_涙0 = pars["涙0"].ToPar();
    		X0Y4_涙1 = pars["涙1"].ToPar();
    		X0Y4_涙ハイライト = pars["涙ハイライト"].ToPar();
    		pars = Body[0][5];
    		X0Y5_涙0流れ0 = pars["涙0流れ0"].ToPar();
    		X0Y5_涙0流れ1 = pars["涙0流れ1"].ToPar();
    		X0Y5_涙0 = pars["涙0"].ToPar();
    		X0Y5_涙1 = pars["涙1"].ToPar();
    		X0Y5_涙ハイライト = pars["涙ハイライト"].ToPar();
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
    		Tear0流れ0_表示 = e.涙0流れ0_表示;
    		Tear0_表示 = e.涙0_表示;
    		涙1_表示 = e.涙1_表示;
    		Tearハイライト_表示 = e.涙ハイライト_表示;
    		Tear0流れ1_表示 = e.涙0流れ1_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_涙0流れ0CP = new ColorP(X0Y0_涙0流れ0, 涙0流れ0CD, DisUnit, abj: true);
    		X0Y0_涙0CP = new ColorP(X0Y0_涙0, 涙0CD, DisUnit, abj: true);
    		X0Y0_涙1CP = new ColorP(X0Y0_涙1, 涙1CD, DisUnit, abj: true);
    		X0Y0_涙ハイライトCP = new ColorP(X0Y0_涙ハイライト, 涙ハイライトCD, DisUnit, abj: true);
    		X0Y1_涙0流れ0CP = new ColorP(X0Y1_涙0流れ0, 涙0流れ0CD, DisUnit, abj: true);
    		X0Y1_涙0流れ1CP = new ColorP(X0Y1_涙0流れ1, Tear0流れ1CD, DisUnit, abj: true);
    		X0Y1_涙0CP = new ColorP(X0Y1_涙0, 涙0CD, DisUnit, abj: true);
    		X0Y1_涙1CP = new ColorP(X0Y1_涙1, 涙1CD, DisUnit, abj: true);
    		X0Y1_涙ハイライトCP = new ColorP(X0Y1_涙ハイライト, 涙ハイライトCD, DisUnit, abj: true);
    		X0Y2_涙0流れ0CP = new ColorP(X0Y2_涙0流れ0, 涙0流れ0CD, DisUnit, abj: true);
    		X0Y2_涙0流れ1CP = new ColorP(X0Y2_涙0流れ1, Tear0流れ1CD, DisUnit, abj: true);
    		X0Y2_涙0CP = new ColorP(X0Y2_涙0, 涙0CD, DisUnit, abj: true);
    		X0Y2_涙1CP = new ColorP(X0Y2_涙1, 涙1CD, DisUnit, abj: true);
    		X0Y2_涙ハイライトCP = new ColorP(X0Y2_涙ハイライト, 涙ハイライトCD, DisUnit, abj: true);
    		X0Y3_涙0流れ0CP = new ColorP(X0Y3_涙0流れ0, 涙0流れ0CD, DisUnit, abj: true);
    		X0Y3_涙0流れ1CP = new ColorP(X0Y3_涙0流れ1, Tear0流れ1CD, DisUnit, abj: true);
    		X0Y3_涙0CP = new ColorP(X0Y3_涙0, 涙0CD, DisUnit, abj: true);
    		X0Y3_涙1CP = new ColorP(X0Y3_涙1, 涙1CD, DisUnit, abj: true);
    		X0Y3_涙ハイライトCP = new ColorP(X0Y3_涙ハイライト, 涙ハイライトCD, DisUnit, abj: true);
    		X0Y4_涙0流れ0CP = new ColorP(X0Y4_涙0流れ0, 涙0流れ0CD, DisUnit, abj: true);
    		X0Y4_涙0流れ1CP = new ColorP(X0Y4_涙0流れ1, Tear0流れ1CD, DisUnit, abj: true);
    		X0Y4_涙0CP = new ColorP(X0Y4_涙0, 涙0CD, DisUnit, abj: true);
    		X0Y4_涙1CP = new ColorP(X0Y4_涙1, 涙1CD, DisUnit, abj: true);
    		X0Y4_涙ハイライトCP = new ColorP(X0Y4_涙ハイライト, 涙ハイライトCD, DisUnit, abj: true);
    		X0Y5_涙0流れ0CP = new ColorP(X0Y5_涙0流れ0, 涙0流れ0CD, DisUnit, abj: true);
    		X0Y5_涙0流れ1CP = new ColorP(X0Y5_涙0流れ1, Tear0流れ1CD, DisUnit, abj: true);
    		X0Y5_涙0CP = new ColorP(X0Y5_涙0, 涙0CD, DisUnit, abj: true);
    		X0Y5_涙1CP = new ColorP(X0Y5_涙1, 涙1CD, DisUnit, abj: true);
    		X0Y5_涙ハイライトCP = new ColorP(X0Y5_涙ハイライト, 涙ハイライトCD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		switch (Body.IndexY)
    		{
    		case 0:
    			X0Y0_涙0流れ0CP.Update();
    			X0Y0_涙0CP.Update();
    			X0Y0_涙1CP.Update();
    			X0Y0_涙ハイライトCP.Update();
    			break;
    		case 1:
    			X0Y1_涙0流れ0CP.Update();
    			X0Y1_涙0流れ1CP.Update();
    			X0Y1_涙0CP.Update();
    			X0Y1_涙1CP.Update();
    			X0Y1_涙ハイライトCP.Update();
    			break;
    		case 2:
    			X0Y2_涙0流れ0CP.Update();
    			X0Y2_涙0流れ1CP.Update();
    			X0Y2_涙0CP.Update();
    			X0Y2_涙1CP.Update();
    			X0Y2_涙ハイライトCP.Update();
    			break;
    		case 3:
    			X0Y3_涙0流れ0CP.Update();
    			X0Y3_涙0流れ1CP.Update();
    			X0Y3_涙0CP.Update();
    			X0Y3_涙1CP.Update();
    			X0Y3_涙ハイライトCP.Update();
    			break;
    		case 4:
    			X0Y4_涙0流れ0CP.Update();
    			X0Y4_涙0流れ1CP.Update();
    			X0Y4_涙0CP.Update();
    			X0Y4_涙1CP.Update();
    			X0Y4_涙ハイライトCP.Update();
    			break;
    		default:
    			X0Y5_涙0流れ0CP.Update();
    			X0Y5_涙0流れ1CP.Update();
    			X0Y5_涙0CP.Update();
    			X0Y5_涙1CP.Update();
    			X0Y5_涙ハイライトCP.Update();
    			break;
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		涙0流れ0CD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
    		Tear0流れ1CD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
    		涙0CD = new ColorD(ref 体配色.体液線, ref 体配色.人肌O);
    		涙1CD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
    		涙ハイライトCD = new ColorD(ref 体配色.ハイライト.Col1, ref 体配色.ハイライト);
    	}
    }
}
