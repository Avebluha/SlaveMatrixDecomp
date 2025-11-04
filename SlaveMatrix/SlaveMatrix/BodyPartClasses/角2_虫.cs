using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 角2_虫 : 角2
    {
    	public Par X0Y0_根;

    	public Par X0Y0_棘_棘1;

    	public Par X0Y0_棘_棘2;

    	public Par X0Y0_棘_棘3;

    	public Par X0Y0_輪_革;

    	public Par X0Y0_輪_金具1;

    	public Par X0Y0_輪_金具2;

    	public Par X0Y0_輪_金具3;

    	public Par X0Y0_輪_金具左;

    	public Par X0Y0_輪_金具右;

    	public Par X0Y1_根;

    	public Par X0Y1_棘_棘2;

    	public Par X0Y1_棘_棘3;

    	public Par X0Y1_折線;

    	public ColorD 根CD;

    	public ColorD 刺_棘1CD;

    	public ColorD 刺_棘2CD;

    	public ColorD 刺_棘3CD;

    	public ColorD 輪_革CD;

    	public ColorD 輪_金具1CD;

    	public ColorD 輪_金具2CD;

    	public ColorD 輪_金具3CD;

    	public ColorD 輪_金具左CD;

    	public ColorD 輪_金具右CD;

    	public ColorD 折線CD;

    	public ColorP X0Y0_根CP;

    	public ColorP X0Y0_棘_棘1CP;

    	public ColorP X0Y0_棘_棘2CP;

    	public ColorP X0Y0_棘_棘3CP;

    	public ColorP X0Y0_輪_革CP;

    	public ColorP X0Y0_輪_金具1CP;

    	public ColorP X0Y0_輪_金具2CP;

    	public ColorP X0Y0_輪_金具3CP;

    	public ColorP X0Y0_輪_金具左CP;

    	public ColorP X0Y0_輪_金具右CP;

    	public ColorP X0Y1_根CP;

    	public ColorP X0Y1_棘_棘2CP;

    	public ColorP X0Y1_棘_棘3CP;

    	public ColorP X0Y1_折線CP;

    	public 拘束鎖 鎖1;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    			本体.IndexY = (欠損_ ? 1 : 0);
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

    	public bool 根_表示
    	{
    		get
    		{
    			return X0Y0_根.Dra;
    		}
    		set
    		{
    			X0Y0_根.Dra = value;
    			X0Y1_根.Dra = value;
    			X0Y0_根.Hit = value;
    			X0Y1_根.Hit = value;
    		}
    	}

    	public bool 刺_棘1_表示
    	{
    		get
    		{
    			return X0Y0_棘_棘1.Dra;
    		}
    		set
    		{
    			X0Y0_棘_棘1.Dra = value;
    			X0Y0_棘_棘1.Hit = value;
    		}
    	}

    	public bool 刺_棘2_表示
    	{
    		get
    		{
    			return X0Y0_棘_棘2.Dra;
    		}
    		set
    		{
    			X0Y0_棘_棘2.Dra = value;
    			X0Y1_棘_棘2.Dra = value;
    			X0Y0_棘_棘2.Hit = value;
    			X0Y1_棘_棘2.Hit = value;
    		}
    	}

    	public bool 刺_棘3_表示
    	{
    		get
    		{
    			return X0Y0_棘_棘3.Dra;
    		}
    		set
    		{
    			X0Y0_棘_棘3.Dra = value;
    			X0Y1_棘_棘3.Dra = value;
    			X0Y0_棘_棘3.Hit = value;
    			X0Y1_棘_棘3.Hit = value;
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

    	public bool 折線_表示
    	{
    		get
    		{
    			return X0Y1_折線.Dra;
    		}
    		set
    		{
    			X0Y1_折線.Dra = value;
    			X0Y1_折線.Hit = value;
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
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 根_表示;
    		}
    		set
    		{
    			根_表示 = value;
    			刺_棘1_表示 = value;
    			刺_棘2_表示 = value;
    			刺_棘3_表示 = value;
    			輪_革_表示 = value;
    			輪_金具1_表示 = value;
    			輪_金具2_表示 = value;
    			輪_金具3_表示 = value;
    			輪_金具左_表示 = value;
    			輪_金具右_表示 = value;
    			折線_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 根CD.不透明度;
    		}
    		set
    		{
    			根CD.不透明度 = value;
    			刺_棘1CD.不透明度 = value;
    			刺_棘2CD.不透明度 = value;
    			刺_棘3CD.不透明度 = value;
    			輪_革CD.不透明度 = value;
    			輪_金具1CD.不透明度 = value;
    			輪_金具2CD.不透明度 = value;
    			輪_金具3CD.不透明度 = value;
    			輪_金具左CD.不透明度 = value;
    			輪_金具右CD.不透明度 = value;
    			折線CD.不透明度 = value;
    		}
    	}

    	public JointS 鎖1_接続点 => new JointS(本体, X0Y0_輪_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(本体, X0Y0_輪_金具右, 0);

    	public 角2_虫(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 角2_虫D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.肢左["角"][9]);
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars = 本体[0][0];
    		X0Y0_根 = pars["根"].ToPar();
    		Pars pars2 = pars["刺"].ToPars();
    		X0Y0_棘_棘1 = pars2["刺1"].ToPar();
    		X0Y0_棘_棘2 = pars2["刺2"].ToPar();
    		X0Y0_棘_棘3 = pars2["刺3"].ToPar();
    		pars2 = pars["輪"].ToPars();
    		X0Y0_輪_革 = pars2["革"].ToPar();
    		X0Y0_輪_金具1 = pars2["金具1"].ToPar();
    		X0Y0_輪_金具2 = pars2["金具2"].ToPar();
    		X0Y0_輪_金具3 = pars2["金具3"].ToPar();
    		X0Y0_輪_金具左 = pars2["金具左"].ToPar();
    		X0Y0_輪_金具右 = pars2["金具右"].ToPar();
    		pars = 本体[0][1];
    		X0Y1_根 = pars["根"].ToPar();
    		pars2 = pars["刺"].ToPars();
    		X0Y1_棘_棘2 = pars2["刺2"].ToPar();
    		X0Y1_棘_棘3 = pars2["刺3"].ToPar();
    		X0Y1_折線 = pars["折線"].ToPar();
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
    		根_表示 = e.根_表示;
    		刺_棘1_表示 = e.刺_棘1_表示;
    		刺_棘2_表示 = e.刺_棘2_表示;
    		刺_棘3_表示 = e.刺_棘3_表示;
    		輪_革_表示 = e.輪_革_表示;
    		輪_金具1_表示 = e.輪_金具1_表示;
    		輪_金具2_表示 = e.輪_金具2_表示;
    		輪_金具3_表示 = e.輪_金具3_表示;
    		輪_金具左_表示 = e.輪_金具左_表示;
    		輪_金具右_表示 = e.輪_金具右_表示;
    		折線_表示 = e.折線_表示;
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
    		X0Y0_根CP = new ColorP(X0Y0_根, 根CD, DisUnit, abj: true);
    		X0Y0_棘_棘1CP = new ColorP(X0Y0_棘_棘1, 刺_棘1CD, DisUnit, abj: true);
    		X0Y0_棘_棘2CP = new ColorP(X0Y0_棘_棘2, 刺_棘2CD, DisUnit, abj: true);
    		X0Y0_棘_棘3CP = new ColorP(X0Y0_棘_棘3, 刺_棘3CD, DisUnit, abj: true);
    		X0Y0_輪_革CP = new ColorP(X0Y0_輪_革, 輪_革CD, DisUnit, abj: true);
    		X0Y0_輪_金具1CP = new ColorP(X0Y0_輪_金具1, 輪_金具1CD, DisUnit, abj: true);
    		X0Y0_輪_金具2CP = new ColorP(X0Y0_輪_金具2, 輪_金具2CD, DisUnit, abj: true);
    		X0Y0_輪_金具3CP = new ColorP(X0Y0_輪_金具3, 輪_金具3CD, DisUnit, abj: true);
    		X0Y0_輪_金具左CP = new ColorP(X0Y0_輪_金具左, 輪_金具左CD, DisUnit, abj: true);
    		X0Y0_輪_金具右CP = new ColorP(X0Y0_輪_金具右, 輪_金具右CD, DisUnit, abj: true);
    		X0Y1_根CP = new ColorP(X0Y1_根, 根CD, DisUnit, abj: true);
    		X0Y1_棘_棘2CP = new ColorP(X0Y1_棘_棘2, 刺_棘2CD, DisUnit, abj: true);
    		X0Y1_棘_棘3CP = new ColorP(X0Y1_棘_棘3, 刺_棘3CD, DisUnit, abj: true);
    		X0Y1_折線CP = new ColorP(X0Y1_折線, 折線CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    		鎖1 = new 拘束鎖(DisUnit, 右, 配色指定, 体配色, Xasix);
    		鎖1.接続(鎖1_接続点);
    		int num = (右 ? (-10) : 10);
    		鎖1.角度B += num;
    		鎖表示 = e.鎖表示;
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    	}

    	public override void 根描画(RenderArea Are)
    	{
    		本体.Draw(Are);
    		if (!欠損_)
    		{
    			鎖1.描画0(Are);
    		}
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		本体.Draw(Are);
    		if (!欠損_)
    		{
    			鎖1.描画0(Are);
    		}
    	}

    	public override bool Is革(Par p)
    	{
    		if (p != X0Y0_輪_革 && p != X0Y0_輪_金具1 && p != X0Y0_輪_金具2 && p != X0Y0_輪_金具3 && p != X0Y0_輪_金具左)
    		{
    			return p == X0Y0_輪_金具右;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		if (本体.IndexY == 0)
    		{
    			X0Y0_根CP.Update();
    			X0Y0_棘_棘1CP.Update();
    			X0Y0_棘_棘2CP.Update();
    			X0Y0_棘_棘3CP.Update();
    			X0Y0_輪_革CP.Update();
    			X0Y0_輪_金具1CP.Update();
    			X0Y0_輪_金具2CP.Update();
    			X0Y0_輪_金具3CP.Update();
    			X0Y0_輪_金具左CP.Update();
    			X0Y0_輪_金具右CP.Update();
    			鎖1.接続PA();
    			鎖1.色更新();
    		}
    		else
    		{
    			X0Y1_根CP.Update();
    			X0Y1_棘_棘2CP.Update();
    			X0Y1_棘_棘3CP.Update();
    			X0Y1_折線CP.Update();
    		}
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
    		根CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		刺_棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		刺_棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		刺_棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    		折線CD = new ColorD(ref Col.Black, ref Color2.Empty);
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		根CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		刺_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		刺_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		刺_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    		折線CD = new ColorD(ref Col.Black, ref Color2.Empty);
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		根CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		刺_棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		刺_棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		刺_棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    		折線CD = new ColorD(ref Col.Black, ref Color2.Empty);
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
    	}
    }
}
