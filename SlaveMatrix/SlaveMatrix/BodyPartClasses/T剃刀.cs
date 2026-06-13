using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class T剃刀 : Ele
    {
    	public Par X0Y0_ヘッド;

    	public Par X0Y0_刃_刃1;

    	public Par X0Y0_刃_刃2;

    	public Par X0Y0_Neck;

    	public Par X0Y0_グリップ_グリップ0;

    	public Par X0Y0_グリップ_グリップ1;

    	public Par X0Y0_グリップ_グリップ2;

    	public Par X0Y0_グリップ_グリップ3;

    	public Par X0Y0_グリップ_グリップ4;

    	public Par X0Y0_グリップ_グリップ5;

    	public Par X0Y0_グリップ_グリップ6;

    	public Par X0Y0_グリップ_グリップ7;

    	public Par X0Y0_グリップ_グリップ8;

    	public Par X0Y0_グリップ_グリップ9;

    	public Par X0Y0_グリップ_グリップ10;

    	public Par X0Y0_グリップ_グリップ11;

    	public Par X0Y0_グリップ_グリップ12;

    	public Par X0Y0_グリップ_グリップ13;

    	public Par X0Y0_グリップ_グリップ14;

    	public Par X0Y0_グリップ_グリップ15;

    	public ColorD ヘッドCD;

    	public ColorD 刃_刃1CD;

    	public ColorD 刃_刃2CD;

    	public ColorD NeckCD;

    	public ColorD グリップ_グリップ0CD;

    	public ColorD グリップ_グリップ1CD;

    	public ColorD グリップ_グリップ2CD;

    	public ColorD グリップ_グリップ3CD;

    	public ColorD グリップ_グリップ4CD;

    	public ColorD グリップ_グリップ5CD;

    	public ColorD グリップ_グリップ6CD;

    	public ColorD グリップ_グリップ7CD;

    	public ColorD グリップ_グリップ8CD;

    	public ColorD グリップ_グリップ9CD;

    	public ColorD グリップ_グリップ10CD;

    	public ColorD グリップ_グリップ11CD;

    	public ColorD グリップ_グリップ12CD;

    	public ColorD グリップ_グリップ13CD;

    	public ColorD グリップ_グリップ14CD;

    	public ColorD グリップ_グリップ15CD;

    	public ColorP X0Y0_ヘッドCP;

    	public ColorP X0Y0_刃_刃1CP;

    	public ColorP X0Y0_刃_刃2CP;

    	public ColorP X0Y0_NeckCP;

    	public ColorP X0Y0_グリップ_グリップ0CP;

    	public ColorP X0Y0_グリップ_グリップ1CP;

    	public ColorP X0Y0_グリップ_グリップ2CP;

    	public ColorP X0Y0_グリップ_グリップ3CP;

    	public ColorP X0Y0_グリップ_グリップ4CP;

    	public ColorP X0Y0_グリップ_グリップ5CP;

    	public ColorP X0Y0_グリップ_グリップ6CP;

    	public ColorP X0Y0_グリップ_グリップ7CP;

    	public ColorP X0Y0_グリップ_グリップ8CP;

    	public ColorP X0Y0_グリップ_グリップ9CP;

    	public ColorP X0Y0_グリップ_グリップ10CP;

    	public ColorP X0Y0_グリップ_グリップ11CP;

    	public ColorP X0Y0_グリップ_グリップ12CP;

    	public ColorP X0Y0_グリップ_グリップ13CP;

    	public ColorP X0Y0_グリップ_グリップ14CP;

    	public ColorP X0Y0_グリップ_グリップ15CP;

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

    	public bool ヘッド_表示
    	{
    		get
    		{
    			return X0Y0_ヘッド.Dra;
    		}
    		set
    		{
    			X0Y0_ヘッド.Dra = value;
    			X0Y0_ヘッド.Hit = value;
    		}
    	}

    	public bool 刃_刃1_表示
    	{
    		get
    		{
    			return X0Y0_刃_刃1.Dra;
    		}
    		set
    		{
    			X0Y0_刃_刃1.Dra = value;
    			X0Y0_刃_刃1.Hit = value;
    		}
    	}

    	public bool 刃_刃2_表示
    	{
    		get
    		{
    			return X0Y0_刃_刃2.Dra;
    		}
    		set
    		{
    			X0Y0_刃_刃2.Dra = value;
    			X0Y0_刃_刃2.Hit = value;
    		}
    	}

    	public bool Neck_表示
    	{
    		get
    		{
    			return X0Y0_Neck.Dra;
    		}
    		set
    		{
    			X0Y0_Neck.Dra = value;
    			X0Y0_Neck.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ0_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ0.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ0.Dra = value;
    			X0Y0_グリップ_グリップ0.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ1_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ1.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ1.Dra = value;
    			X0Y0_グリップ_グリップ1.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ2_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ2.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ2.Dra = value;
    			X0Y0_グリップ_グリップ2.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ3_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ3.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ3.Dra = value;
    			X0Y0_グリップ_グリップ3.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ4_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ4.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ4.Dra = value;
    			X0Y0_グリップ_グリップ4.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ5_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ5.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ5.Dra = value;
    			X0Y0_グリップ_グリップ5.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ6_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ6.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ6.Dra = value;
    			X0Y0_グリップ_グリップ6.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ7_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ7.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ7.Dra = value;
    			X0Y0_グリップ_グリップ7.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ8_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ8.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ8.Dra = value;
    			X0Y0_グリップ_グリップ8.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ9_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ9.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ9.Dra = value;
    			X0Y0_グリップ_グリップ9.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ10_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ10.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ10.Dra = value;
    			X0Y0_グリップ_グリップ10.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ11_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ11.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ11.Dra = value;
    			X0Y0_グリップ_グリップ11.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ12_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ12.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ12.Dra = value;
    			X0Y0_グリップ_グリップ12.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ13_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ13.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ13.Dra = value;
    			X0Y0_グリップ_グリップ13.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ14_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ14.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ14.Dra = value;
    			X0Y0_グリップ_グリップ14.Hit = value;
    		}
    	}

    	public bool グリップ_グリップ15_表示
    	{
    		get
    		{
    			return X0Y0_グリップ_グリップ15.Dra;
    		}
    		set
    		{
    			X0Y0_グリップ_グリップ15.Dra = value;
    			X0Y0_グリップ_グリップ15.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return ヘッド_表示;
    		}
    		set
    		{
    			ヘッド_表示 = value;
    			刃_刃1_表示 = value;
    			刃_刃2_表示 = value;
    			Neck_表示 = value;
    			グリップ_グリップ0_表示 = value;
    			グリップ_グリップ1_表示 = value;
    			グリップ_グリップ2_表示 = value;
    			グリップ_グリップ3_表示 = value;
    			グリップ_グリップ4_表示 = value;
    			グリップ_グリップ5_表示 = value;
    			グリップ_グリップ6_表示 = value;
    			グリップ_グリップ7_表示 = value;
    			グリップ_グリップ8_表示 = value;
    			グリップ_グリップ9_表示 = value;
    			グリップ_グリップ10_表示 = value;
    			グリップ_グリップ11_表示 = value;
    			グリップ_グリップ12_表示 = value;
    			グリップ_グリップ13_表示 = value;
    			グリップ_グリップ14_表示 = value;
    			グリップ_グリップ15_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return ヘッドCD.不透明度;
    		}
    		set
    		{
    			ヘッドCD.不透明度 = value;
    			刃_刃1CD.不透明度 = value;
    			刃_刃2CD.不透明度 = value;
    			NeckCD.不透明度 = value;
    			グリップ_グリップ0CD.不透明度 = value;
    			グリップ_グリップ1CD.不透明度 = value;
    			グリップ_グリップ2CD.不透明度 = value;
    			グリップ_グリップ3CD.不透明度 = value;
    			グリップ_グリップ4CD.不透明度 = value;
    			グリップ_グリップ5CD.不透明度 = value;
    			グリップ_グリップ6CD.不透明度 = value;
    			グリップ_グリップ7CD.不透明度 = value;
    			グリップ_グリップ8CD.不透明度 = value;
    			グリップ_グリップ9CD.不透明度 = value;
    			グリップ_グリップ10CD.不透明度 = value;
    			グリップ_グリップ11CD.不透明度 = value;
    			グリップ_グリップ12CD.不透明度 = value;
    			グリップ_グリップ13CD.不透明度 = value;
    			グリップ_グリップ14CD.不透明度 = value;
    			グリップ_グリップ15CD.不透明度 = value;
    		}
    	}

    	public T剃刀(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, T剃刀D e)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.カーソル["T字剃刀"]);
    		Pars pars = Body[0][0];
    		X0Y0_ヘッド = pars["ヘッド"].ToPar();
    		Pars pars2 = pars["刃"].ToPars();
    		X0Y0_刃_刃1 = pars2["刃1"].ToPar();
    		X0Y0_刃_刃2 = pars2["刃2"].ToPar();
    		X0Y0_Neck = pars["首"].ToPar();
    		pars2 = pars["グリップ"].ToPars();
    		X0Y0_グリップ_グリップ0 = pars2["グリップ0"].ToPar();
    		X0Y0_グリップ_グリップ1 = pars2["グリップ1"].ToPar();
    		X0Y0_グリップ_グリップ2 = pars2["グリップ2"].ToPar();
    		X0Y0_グリップ_グリップ3 = pars2["グリップ3"].ToPar();
    		X0Y0_グリップ_グリップ4 = pars2["グリップ4"].ToPar();
    		X0Y0_グリップ_グリップ5 = pars2["グリップ5"].ToPar();
    		X0Y0_グリップ_グリップ6 = pars2["グリップ6"].ToPar();
    		X0Y0_グリップ_グリップ7 = pars2["グリップ7"].ToPar();
    		X0Y0_グリップ_グリップ8 = pars2["グリップ8"].ToPar();
    		X0Y0_グリップ_グリップ9 = pars2["グリップ9"].ToPar();
    		X0Y0_グリップ_グリップ10 = pars2["グリップ10"].ToPar();
    		X0Y0_グリップ_グリップ11 = pars2["グリップ11"].ToPar();
    		X0Y0_グリップ_グリップ12 = pars2["グリップ12"].ToPar();
    		X0Y0_グリップ_グリップ13 = pars2["グリップ13"].ToPar();
    		X0Y0_グリップ_グリップ14 = pars2["グリップ14"].ToPar();
    		X0Y0_グリップ_グリップ15 = pars2["グリップ15"].ToPar();
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
    		ヘッド_表示 = e.ヘッド_表示;
    		刃_刃1_表示 = e.刃_刃1_表示;
    		刃_刃2_表示 = e.刃_刃2_表示;
    		Neck_表示 = e.Neck_表示;
    		グリップ_グリップ0_表示 = e.グリップ_グリップ0_表示;
    		グリップ_グリップ1_表示 = e.グリップ_グリップ1_表示;
    		グリップ_グリップ2_表示 = e.グリップ_グリップ2_表示;
    		グリップ_グリップ3_表示 = e.グリップ_グリップ3_表示;
    		グリップ_グリップ4_表示 = e.グリップ_グリップ4_表示;
    		グリップ_グリップ5_表示 = e.グリップ_グリップ5_表示;
    		グリップ_グリップ6_表示 = e.グリップ_グリップ6_表示;
    		グリップ_グリップ7_表示 = e.グリップ_グリップ7_表示;
    		グリップ_グリップ8_表示 = e.グリップ_グリップ8_表示;
    		グリップ_グリップ9_表示 = e.グリップ_グリップ9_表示;
    		グリップ_グリップ10_表示 = e.グリップ_グリップ10_表示;
    		グリップ_グリップ11_表示 = e.グリップ_グリップ11_表示;
    		グリップ_グリップ12_表示 = e.グリップ_グリップ12_表示;
    		グリップ_グリップ13_表示 = e.グリップ_グリップ13_表示;
    		グリップ_グリップ14_表示 = e.グリップ_グリップ14_表示;
    		グリップ_グリップ15_表示 = e.グリップ_グリップ15_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_ヘッドCP = new ColorP(X0Y0_ヘッド, ヘッドCD, DisUnit, abj: true);
    		X0Y0_刃_刃1CP = new ColorP(X0Y0_刃_刃1, 刃_刃1CD, DisUnit, abj: true);
    		X0Y0_刃_刃2CP = new ColorP(X0Y0_刃_刃2, 刃_刃2CD, DisUnit, abj: true);
    		X0Y0_NeckCP = new ColorP(X0Y0_Neck, NeckCD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ0CP = new ColorP(X0Y0_グリップ_グリップ0, グリップ_グリップ0CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ1CP = new ColorP(X0Y0_グリップ_グリップ1, グリップ_グリップ1CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ2CP = new ColorP(X0Y0_グリップ_グリップ2, グリップ_グリップ2CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ3CP = new ColorP(X0Y0_グリップ_グリップ3, グリップ_グリップ3CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ4CP = new ColorP(X0Y0_グリップ_グリップ4, グリップ_グリップ4CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ5CP = new ColorP(X0Y0_グリップ_グリップ5, グリップ_グリップ5CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ6CP = new ColorP(X0Y0_グリップ_グリップ6, グリップ_グリップ6CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ7CP = new ColorP(X0Y0_グリップ_グリップ7, グリップ_グリップ7CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ8CP = new ColorP(X0Y0_グリップ_グリップ8, グリップ_グリップ8CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ9CP = new ColorP(X0Y0_グリップ_グリップ9, グリップ_グリップ9CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ10CP = new ColorP(X0Y0_グリップ_グリップ10, グリップ_グリップ10CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ11CP = new ColorP(X0Y0_グリップ_グリップ11, グリップ_グリップ11CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ12CP = new ColorP(X0Y0_グリップ_グリップ12, グリップ_グリップ12CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ13CP = new ColorP(X0Y0_グリップ_グリップ13, グリップ_グリップ13CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ14CP = new ColorP(X0Y0_グリップ_グリップ14, グリップ_グリップ14CD, DisUnit, abj: true);
    		X0Y0_グリップ_グリップ15CP = new ColorP(X0Y0_グリップ_グリップ15, グリップ_グリップ15CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		Vector2D local = X0Y0_刃_刃1.GetOP()[0].ps[1];
    		foreach (Par item in Body.EnumJoinRoot)
    		{
    			item.SetBasePointBase(item.ToLocal(X0Y0_刃_刃1.ToGlobal(local)));
    		}
    		尺度B = 1.08;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		X0Y0_ヘッドCP.Update();
    		X0Y0_刃_刃1CP.Update();
    		X0Y0_刃_刃2CP.Update();
    		X0Y0_NeckCP.Update();
    		X0Y0_グリップ_グリップ0CP.Update();
    		X0Y0_グリップ_グリップ1CP.Update();
    		X0Y0_グリップ_グリップ2CP.Update();
    		X0Y0_グリップ_グリップ3CP.Update();
    		X0Y0_グリップ_グリップ4CP.Update();
    		X0Y0_グリップ_グリップ5CP.Update();
    		X0Y0_グリップ_グリップ6CP.Update();
    		X0Y0_グリップ_グリップ7CP.Update();
    		X0Y0_グリップ_グリップ8CP.Update();
    		X0Y0_グリップ_グリップ9CP.Update();
    		X0Y0_グリップ_グリップ10CP.Update();
    		X0Y0_グリップ_グリップ11CP.Update();
    		X0Y0_グリップ_グリップ12CP.Update();
    		X0Y0_グリップ_グリップ13CP.Update();
    		X0Y0_グリップ_グリップ14CP.Update();
    		X0Y0_グリップ_グリップ15CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		ヘッドCD = new ColorD();
    		ヘッドCD.線 = Col.Black;
    		ヘッドCD.色 = new Color2(ref Col.Black, ref Col.Empty);
    		Col.GetGrad(ref Col.DarkGray, out var ret);
    		刃_刃1CD = new ColorD(ref Col.Black, ref ret);
    		刃_刃2CD = new ColorD(ref Col.Black, ref ret);
    		NeckCD = new ColorD(ref Col.Black, ref ret);
    		ret = new Color2(ref Col.DimGray, ref Col.Black);
    		グリップ_グリップ0CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ1CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ2CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ3CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ4CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ5CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ6CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ7CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ8CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ9CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ10CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ11CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ12CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ13CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ14CD = new ColorD(ref Col.Black, ref ret);
    		グリップ_グリップ15CD = new ColorD(ref Col.Black, ref ret);
    	}
    }
}
