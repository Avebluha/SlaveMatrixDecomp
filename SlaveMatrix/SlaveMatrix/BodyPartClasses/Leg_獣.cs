using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class Leg_獣 : 獣脚
    {
    	public ShapePart X0Y0_Leg;

    	public ShapePart X0Y0_筋;

    	public ShapePart X0Y0_脚輪_革;

    	public ShapePart X0Y0_脚輪_金具1;

    	public ShapePart X0Y0_脚輪_金具2;

    	public ShapePart X0Y0_脚輪_金具3;

    	public ShapePart X0Y0_脚輪_金具左;

    	public ShapePart X0Y0_脚輪_金具右;

    	public ColorD LegCD;

    	public ColorD 筋CD;

    	public ColorD 脚輪_革CD;

    	public ColorD 脚輪_金具1CD;

    	public ColorD 脚輪_金具2CD;

    	public ColorD 脚輪_金具3CD;

    	public ColorD 脚輪_金具左CD;

    	public ColorD 脚輪_金具右CD;

    	public ColorP X0Y0_LegCP;

    	public ColorP X0Y0_筋CP;

    	public ColorP X0Y0_脚輪_革CP;

    	public ColorP X0Y0_脚輪_金具1CP;

    	public ColorP X0Y0_脚輪_金具2CP;

    	public ColorP X0Y0_脚輪_金具3CP;

    	public ColorP X0Y0_脚輪_金具左CP;

    	public ColorP X0Y0_脚輪_金具右CP;

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
    			筋_表示 = 筋肉_;
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
    			脚輪表示 = 拘束_;
    		}
    	}

    	public bool Leg_表示
    	{
    		get
    		{
    			return X0Y0_Leg.Dra;
    		}
    		set
    		{
    			X0Y0_Leg.Dra = value;
    			X0Y0_Leg.Hit = value;
    		}
    	}

    	public bool 筋_表示
    	{
    		get
    		{
    			return X0Y0_筋.Dra;
    		}
    		set
    		{
    			X0Y0_筋.Dra = value;
    			X0Y0_筋.Hit = value;
    		}
    	}

    	public bool 脚輪_革_表示
    	{
    		get
    		{
    			return X0Y0_脚輪_革.Dra;
    		}
    		set
    		{
    			X0Y0_脚輪_革.Dra = value;
    			X0Y0_脚輪_革.Hit = value;
    		}
    	}

    	public bool 脚輪_金具1_表示
    	{
    		get
    		{
    			return X0Y0_脚輪_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_脚輪_金具1.Dra = value;
    			X0Y0_脚輪_金具1.Hit = value;
    		}
    	}

    	public bool 脚輪_金具2_表示
    	{
    		get
    		{
    			return X0Y0_脚輪_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_脚輪_金具2.Dra = value;
    			X0Y0_脚輪_金具2.Hit = value;
    		}
    	}

    	public bool 脚輪_金具3_表示
    	{
    		get
    		{
    			return X0Y0_脚輪_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_脚輪_金具3.Dra = value;
    			X0Y0_脚輪_金具3.Hit = value;
    		}
    	}

    	public bool 脚輪_金具左_表示
    	{
    		get
    		{
    			return X0Y0_脚輪_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_脚輪_金具左.Dra = value;
    			X0Y0_脚輪_金具左.Hit = value;
    		}
    	}

    	public bool 脚輪_金具右_表示
    	{
    		get
    		{
    			return X0Y0_脚輪_金具右.Dra;
    		}
    		set
    		{
    			X0Y0_脚輪_金具右.Dra = value;
    			X0Y0_脚輪_金具右.Hit = value;
    		}
    	}

    	public bool 脚輪表示
    	{
    		get
    		{
    			return 脚輪_革_表示;
    		}
    		set
    		{
    			脚輪_革_表示 = value;
    			脚輪_金具1_表示 = value;
    			脚輪_金具2_表示 = value;
    			脚輪_金具3_表示 = value;
    			脚輪_金具左_表示 = value;
    			脚輪_金具右_表示 = value;
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
    			return Leg_表示;
    		}
    		set
    		{
    			Leg_表示 = value;
    			筋_表示 = value;
    			脚輪_革_表示 = value;
    			脚輪_金具1_表示 = value;
    			脚輪_金具2_表示 = value;
    			脚輪_金具3_表示 = value;
    			脚輪_金具左_表示 = value;
    			脚輪_金具右_表示 = value;
    			鎖1.表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return LegCD.不透明度;
    		}
    		set
    		{
    			LegCD.不透明度 = value;
    			筋CD.不透明度 = value;
    			脚輪_革CD.不透明度 = value;
    			脚輪_金具1CD.不透明度 = value;
    			脚輪_金具2CD.不透明度 = value;
    			脚輪_金具3CD.不透明度 = value;
    			脚輪_金具左CD.不透明度 = value;
    			脚輪_金具右CD.不透明度 = value;
    		}
    	}

    	public JointS 足_接続点 => new JointS(Body, X0Y0_Leg, 0);

    	public JointS 鎖1_接続点 => new JointS(Body, X0Y0_脚輪_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(Body, X0Y0_脚輪_金具右, 0);

    	public Leg_獣(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, Leg_獣D e)
    	{
    		Leg_獣 Leg_獣2 = this;
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant(GlobalState.脚左["四足脚"][0]);
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_Leg = partGroup["脚"].ToPar();
    		X0Y0_筋 = partGroup["筋"].ToPar();
    		PartGroup pars2 = partGroup["脚輪"].ToPars();
    		X0Y0_脚輪_革 = pars2["革"].ToPar();
    		X0Y0_脚輪_金具1 = pars2["金具1"].ToPar();
    		X0Y0_脚輪_金具2 = pars2["金具2"].ToPar();
    		X0Y0_脚輪_金具3 = pars2["金具3"].ToPar();
    		X0Y0_脚輪_金具左 = pars2["金具左"].ToPar();
    		X0Y0_脚輪_金具右 = pars2["金具右"].ToPar();
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
    		Leg_表示 = e.Leg_表示;
    		筋_表示 = e.筋_表示;
    		脚輪_革_表示 = e.脚輪_革_表示;
    		脚輪_金具1_表示 = e.脚輪_金具1_表示;
    		脚輪_金具2_表示 = e.脚輪_金具2_表示;
    		脚輪_金具3_表示 = e.脚輪_金具3_表示;
    		脚輪_金具左_表示 = e.脚輪_金具左_表示;
    		脚輪_金具右_表示 = e.脚輪_金具右_表示;
    		脚輪表示 = e.脚輪表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.足_接続.Count > 0)
    		{
    			Element f;
    			足_接続 = e.足_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Leg_獣2;
    				f.ConnectionType = ConnectionInfo.Leg_獣_足_接続;
    				f.接続(Leg_獣2.足_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_LegCP = new ColorP(X0Y0_Leg, LegCD, DisUnit, abj: true);
    		X0Y0_筋CP = new ColorP(X0Y0_筋, 筋CD, DisUnit, abj: false);
    		X0Y0_脚輪_革CP = new ColorP(X0Y0_脚輪_革, 脚輪_革CD, DisUnit, abj: true);
    		X0Y0_脚輪_金具1CP = new ColorP(X0Y0_脚輪_金具1, 脚輪_金具1CD, DisUnit, abj: true);
    		X0Y0_脚輪_金具2CP = new ColorP(X0Y0_脚輪_金具2, 脚輪_金具2CD, DisUnit, abj: true);
    		X0Y0_脚輪_金具3CP = new ColorP(X0Y0_脚輪_金具3, 脚輪_金具3CD, DisUnit, abj: true);
    		X0Y0_脚輪_金具左CP = new ColorP(X0Y0_脚輪_金具左, 脚輪_金具左CD, DisUnit, abj: true);
    		X0Y0_脚輪_金具右CP = new ColorP(X0Y0_脚輪_金具右, 脚輪_金具右CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		鎖1 = new 拘束鎖(DisUnit, 右, 配色指定, 体配色, Xasix);
    		鎖1.接続(鎖1_接続点);
    		int num = (右 ? (-10) : 10);
    		鎖1.角度B -= num;
    		鎖表示 = e.鎖表示;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Body.Draw(Are);
    		鎖1.描画0(Are);
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_Leg.AngleBase = num * -136.0;
    		Body.JoinPAall();
    	}

    	public override bool Is革(ShapePart p)
    	{
    		if (p != X0Y0_脚輪_革 && p != X0Y0_脚輪_金具1 && p != X0Y0_脚輪_金具2 && p != X0Y0_脚輪_金具3 && p != X0Y0_脚輪_金具左)
    		{
    			return p == X0Y0_脚輪_金具右;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_LegCP.Update();
    		X0Y0_筋CP.Update();
    		X0Y0_脚輪_革CP.Update();
    		X0Y0_脚輪_金具1CP.Update();
    		X0Y0_脚輪_金具2CP.Update();
    		X0Y0_脚輪_金具3CP.Update();
    		X0Y0_脚輪_金具左CP.Update();
    		X0Y0_脚輪_金具右CP.Update();
    		鎖1.接続PA();
    		鎖1.色更新();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		LegCD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		脚輪_革CD = new ColorD();
    		脚輪_金具1CD = new ColorD();
    		脚輪_金具2CD = new ColorD();
    		脚輪_金具3CD = new ColorD();
    		脚輪_金具左CD = new ColorD();
    		脚輪_金具右CD = new ColorD();
    	}

    	public void 脚輪配色(拘束具色 配色)
    	{
    		脚輪_革CD.色 = 配色.革部色;
    		脚輪_金具1CD.色 = 配色.金具色;
    		脚輪_金具2CD.色 = 脚輪_金具1CD.色;
    		脚輪_金具3CD.色 = 脚輪_金具1CD.色;
    		脚輪_金具左CD.色 = 脚輪_金具1CD.色;
    		脚輪_金具右CD.色 = 脚輪_金具1CD.色;
    	}

    	public void 鎖配色(鎖色 配色)
    	{
    		鎖1.配色鎖(配色);
    	}
    }
}
