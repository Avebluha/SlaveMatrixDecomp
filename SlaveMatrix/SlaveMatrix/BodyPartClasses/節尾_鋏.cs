using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 節尾_鋏 : 節尾
    {
    	public ShapePart X0Y0_牙;

    	public ShapePart X0Y0_輪_革;

    	public ShapePart X0Y0_輪_金具1;

    	public ShapePart X0Y0_輪_金具2;

    	public ShapePart X0Y0_輪_金具3;

    	public ShapePart X0Y0_輪_金具左;

    	public ShapePart X0Y0_輪_金具右;

    	public ShapePart X0Y0_棘1;

    	public ShapePart X0Y0_棘2;

    	public ShapePart X0Y0_棘3;

    	public ColorD 牙CD;

    	public ColorD 刺1CD;

    	public ColorD 刺2CD;

    	public ColorD 刺3CD;

    	public ColorD 輪_革CD;

    	public ColorD 輪_金具1CD;

    	public ColorD 輪_金具2CD;

    	public ColorD 輪_金具3CD;

    	public ColorD 輪_金具左CD;

    	public ColorD 輪_金具右CD;

    	public ColorP X0Y0_牙CP;

    	public ColorP X0Y0_輪_革CP;

    	public ColorP X0Y0_輪_金具1CP;

    	public ColorP X0Y0_輪_金具2CP;

    	public ColorP X0Y0_輪_金具3CP;

    	public ColorP X0Y0_輪_金具左CP;

    	public ColorP X0Y0_輪_金具右CP;

    	public ColorP X0Y0_棘1CP;

    	public ColorP X0Y0_棘2CP;

    	public ColorP X0Y0_棘3CP;

    	public 拘束鎖 鎖1;

    	public 拘束鎖 鎖2;

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
    			輪表示 = 拘束_;
    		}
    	}

    	public bool 牙_表示
    	{
    		get
    		{
    			return X0Y0_牙.Dra;
    		}
    		set
    		{
    			X0Y0_牙.Dra = value;
    			X0Y0_牙.Hit = value;
    		}
    	}

    	public bool 輪_革_表示
    	{
    		get
    		{
    			return X0Y0_輪_革.Dra;
    		}
    		set
    		{
    			X0Y0_輪_革.Dra = value;
    			X0Y0_輪_革.Hit = value;
    		}
    	}

    	public bool 輪_金具1_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具1.Dra = value;
    			X0Y0_輪_金具1.Hit = value;
    		}
    	}

    	public bool 輪_金具2_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具2.Dra = value;
    			X0Y0_輪_金具2.Hit = value;
    		}
    	}

    	public bool 輪_金具3_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具3.Dra = value;
    			X0Y0_輪_金具3.Hit = value;
    		}
    	}

    	public bool 輪_金具左_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具左.Dra = value;
    			X0Y0_輪_金具左.Hit = value;
    		}
    	}

    	public bool 輪_金具右_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具右.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具右.Dra = value;
    			X0Y0_輪_金具右.Hit = value;
    		}
    	}

    	public bool 刺1_表示
    	{
    		get
    		{
    			return X0Y0_棘1.Dra;
    		}
    		set
    		{
    			X0Y0_棘1.Dra = value;
    			X0Y0_棘1.Hit = value;
    		}
    	}

    	public bool 刺2_表示
    	{
    		get
    		{
    			return X0Y0_棘2.Dra;
    		}
    		set
    		{
    			X0Y0_棘2.Dra = value;
    			X0Y0_棘2.Hit = value;
    		}
    	}

    	public bool 刺3_表示
    	{
    		get
    		{
    			return X0Y0_棘3.Dra;
    		}
    		set
    		{
    			X0Y0_棘3.Dra = value;
    			X0Y0_棘3.Hit = value;
    		}
    	}

    	public bool 輪表示
    	{
    		get
    		{
    			return 輪_革_表示;
    		}
    		set
    		{
    			輪_革_表示 = value;
    			輪_金具1_表示 = value;
    			輪_金具2_表示 = value;
    			輪_金具3_表示 = value;
    			輪_金具左_表示 = value;
    			輪_金具右_表示 = value;
    		}
    	}

    	public bool 鎖表示
    	{
    		get
    		{
    			return 鎖1.表示;
    		}
    		set
    		{
    			鎖1.表示 = value;
    			鎖2.表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 牙_表示;
    		}
    		set
    		{
    			牙_表示 = value;
    			輪_革_表示 = value;
    			輪_金具1_表示 = value;
    			輪_金具2_表示 = value;
    			輪_金具3_表示 = value;
    			輪_金具左_表示 = value;
    			輪_金具右_表示 = value;
    			刺1_表示 = value;
    			刺2_表示 = value;
    			刺3_表示 = value;
    			鎖1.表示 = value;
    			鎖2.表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 牙CD.不透明度;
    		}
    		set
    		{
    			牙CD.不透明度 = value;
    			刺1CD.不透明度 = value;
    			刺2CD.不透明度 = value;
    			刺3CD.不透明度 = value;
    			輪_革CD.不透明度 = value;
    			輪_金具1CD.不透明度 = value;
    			輪_金具2CD.不透明度 = value;
    			輪_金具3CD.不透明度 = value;
    			輪_金具左CD.不透明度 = value;
    			輪_金具右CD.不透明度 = value;
    		}
    	}

    	public JointS 鎖1_接続点 => new JointS(Body, X0Y0_輪_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(Body, X0Y0_輪_金具右, 0);

    	public 節尾_鋏(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 節尾_鋏D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "鋏";
    		dif.Add(new Pars(Sta.肢左["節足"][0][6]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_牙 = pars["牙"].ToPar();
    		Pars pars2 = pars["輪"].ToPars();
    		X0Y0_輪_革 = pars2["革"].ToPar();
    		X0Y0_輪_金具1 = pars2["金具1"].ToPar();
    		X0Y0_輪_金具2 = pars2["金具2"].ToPar();
    		X0Y0_輪_金具3 = pars2["金具3"].ToPar();
    		X0Y0_輪_金具左 = pars2["金具左"].ToPar();
    		X0Y0_輪_金具右 = pars2["金具右"].ToPar();
    		X0Y0_棘1 = pars["刺1"].ToPar();
    		X0Y0_棘2 = pars["刺2"].ToPar();
    		X0Y0_棘3 = pars["刺3"].ToPar();
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
    		牙_表示 = e.牙_表示;
    		輪_革_表示 = e.輪_革_表示;
    		輪_金具1_表示 = e.輪_金具1_表示;
    		輪_金具2_表示 = e.輪_金具2_表示;
    		輪_金具3_表示 = e.輪_金具3_表示;
    		輪_金具左_表示 = e.輪_金具左_表示;
    		輪_金具右_表示 = e.輪_金具右_表示;
    		刺1_表示 = e.刺1_表示;
    		刺2_表示 = e.刺2_表示;
    		刺3_表示 = e.刺3_表示;
    		輪表示 = e.輪表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_牙CP = new ColorP(X0Y0_牙, 牙CD, DisUnit, abj: true);
    		X0Y0_輪_革CP = new ColorP(X0Y0_輪_革, 輪_革CD, DisUnit, abj: true);
    		X0Y0_輪_金具1CP = new ColorP(X0Y0_輪_金具1, 輪_金具1CD, DisUnit, abj: true);
    		X0Y0_輪_金具2CP = new ColorP(X0Y0_輪_金具2, 輪_金具2CD, DisUnit, abj: true);
    		X0Y0_輪_金具3CP = new ColorP(X0Y0_輪_金具3, 輪_金具3CD, DisUnit, abj: true);
    		X0Y0_輪_金具左CP = new ColorP(X0Y0_輪_金具左, 輪_金具左CD, DisUnit, abj: true);
    		X0Y0_輪_金具右CP = new ColorP(X0Y0_輪_金具右, 輪_金具右CD, DisUnit, abj: true);
    		X0Y0_棘1CP = new ColorP(X0Y0_棘1, 刺1CD, DisUnit, abj: true);
    		X0Y0_棘2CP = new ColorP(X0Y0_棘2, 刺2CD, DisUnit, abj: true);
    		X0Y0_棘3CP = new ColorP(X0Y0_棘3, 刺3CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		鎖1 = new 拘束鎖(DisUnit, 右: false, 配色指定, 体配色, Xasix);
    		鎖2 = new 拘束鎖(DisUnit, 右: true, 配色指定, 体配色, Xasix);
    		鎖2.反転Y = true;
    		鎖1.接続(鎖1_接続点);
    		鎖2.接続(鎖2_接続点);
    		鎖1.表示 = false;
    		鎖表示 = e.鎖表示;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_牙);
    		Are.Draw(X0Y0_輪_革);
    		Are.Draw(X0Y0_輪_金具1);
    		Are.Draw(X0Y0_輪_金具2);
    		Are.Draw(X0Y0_輪_金具3);
    		Are.Draw(X0Y0_輪_金具左);
    		Are.Draw(X0Y0_輪_金具右);
    		鎖1.描画0(Are);
    		鎖2.描画0(Are);
    		Are.Draw(X0Y0_棘1);
    		Are.Draw(X0Y0_棘2);
    		Are.Draw(X0Y0_棘3);
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    		鎖2.Dispose();
    	}

    	public override bool Is革(ShapePart p)
    	{
    		if (p != X0Y0_輪_革 && p != X0Y0_輪_金具1 && p != X0Y0_輪_金具2 && p != X0Y0_輪_金具3 && p != X0Y0_輪_金具左)
    		{
    			return p == X0Y0_輪_金具右;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_牙CP.Update();
    		X0Y0_輪_革CP.Update();
    		X0Y0_輪_金具1CP.Update();
    		X0Y0_輪_金具2CP.Update();
    		X0Y0_輪_金具3CP.Update();
    		X0Y0_輪_金具左CP.Update();
    		X0Y0_輪_金具右CP.Update();
    		X0Y0_棘1CP.Update();
    		X0Y0_棘2CP.Update();
    		X0Y0_棘3CP.Update();
    		鎖1.接続PA();
    		鎖2.接続PA();
    		鎖1.色更新();
    		鎖2.色更新();
    	}

    	private void 配色(BodyColorSet 体配色)
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

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		牙CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		刺1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		刺2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		刺3CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		牙CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		刺1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		刺2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		刺3CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		牙CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		刺1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		刺2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		刺3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    	}

    	public void 輪配色(拘束具色 配色)
    	{
    		輪_革CD.色 = 配色.革部色;
    		輪_金具1CD.色 = 配色.金具色;
    		輪_金具2CD.色 = 輪_金具1CD.色;
    		輪_金具3CD.色 = 輪_金具1CD.色;
    		輪_金具左CD.色 = 輪_金具1CD.色;
    		輪_金具右CD.色 = 輪_金具1CD.色;
    	}

    	public void 鎖配色(鎖色 配色)
    	{
    		鎖1.配色鎖(配色);
    		鎖2.配色鎖(配色);
    	}
    }
}
