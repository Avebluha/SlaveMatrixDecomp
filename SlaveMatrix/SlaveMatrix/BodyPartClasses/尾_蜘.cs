using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class 尾_蜘 : 尾
    {
    	public Par X0Y0_尾0;

    	public Par X0Y0_柄0;

    	public Par X0Y0_柄左1;

    	public Par X0Y0_柄左2;

    	public Par X0Y0_柄右1;

    	public Par X0Y0_柄右2;

    	public Par X0Y0_出糸突起後_出糸突起基;

    	public Par X0Y0_出糸突起後_出糸突起中;

    	public Par X0Y0_出糸突起後_出糸突起左;

    	public Par X0Y0_出糸突起後_出糸突起右;

    	public Par X0Y0_出糸突起左_出糸突起1;

    	public Par X0Y0_出糸突起左_出糸突起2;

    	public Par X0Y0_出糸突起右_出糸突起1;

    	public Par X0Y0_出糸突起右_出糸突起2;

    	public Par X0Y0_出糸突起前_出糸突起左;

    	public Par X0Y0_出糸突起前_出糸突起右;

    	public Par X0Y0_付根線;

    	public ColorD 尾0CD;

    	public ColorD 柄0CD;

    	public ColorD 柄左1CD;

    	public ColorD 柄左2CD;

    	public ColorD 柄右1CD;

    	public ColorD 柄右2CD;

    	public ColorD 出糸突起後_出糸突起基CD;

    	public ColorD 出糸突起後_出糸突起中CD;

    	public ColorD 出糸突起後_出糸突起左CD;

    	public ColorD 出糸突起後_出糸突起右CD;

    	public ColorD 出糸突起左_出糸突起1CD;

    	public ColorD 出糸突起左_出糸突起2CD;

    	public ColorD 出糸突起右_出糸突起1CD;

    	public ColorD 出糸突起右_出糸突起2CD;

    	public ColorD 出糸突起前_出糸突起左CD;

    	public ColorD 出糸突起前_出糸突起右CD;

    	public ColorD 付根線CD;

    	public ColorP X0Y0_尾0CP;

    	public ColorP X0Y0_柄0CP;

    	public ColorP X0Y0_柄左1CP;

    	public ColorP X0Y0_柄左2CP;

    	public ColorP X0Y0_柄右1CP;

    	public ColorP X0Y0_柄右2CP;

    	public ColorP X0Y0_出糸突起後_出糸突起基CP;

    	public ColorP X0Y0_出糸突起後_出糸突起中CP;

    	public ColorP X0Y0_出糸突起後_出糸突起左CP;

    	public ColorP X0Y0_出糸突起後_出糸突起右CP;

    	public ColorP X0Y0_出糸突起左_出糸突起1CP;

    	public ColorP X0Y0_出糸突起左_出糸突起2CP;

    	public ColorP X0Y0_出糸突起右_出糸突起1CP;

    	public ColorP X0Y0_出糸突起右_出糸突起2CP;

    	public ColorP X0Y0_出糸突起前_出糸突起左CP;

    	public ColorP X0Y0_出糸突起前_出糸突起右CP;

    	public ColorP X0Y0_付根線CP;

    	private bool 出糸_;

    	public Ele[] 出糸_接続;

    	private Vector2D[] mm;

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

    	public bool 尾0_表示
    	{
    		get
    		{
    			return X0Y0_尾0.Dra;
    		}
    		set
    		{
    			X0Y0_尾0.Dra = value;
    			X0Y0_尾0.Hit = value;
    		}
    	}

    	public bool 柄0_表示
    	{
    		get
    		{
    			return X0Y0_柄0.Dra;
    		}
    		set
    		{
    			X0Y0_柄0.Dra = value;
    			X0Y0_柄0.Hit = value;
    		}
    	}

    	public bool 柄左1_表示
    	{
    		get
    		{
    			return X0Y0_柄左1.Dra;
    		}
    		set
    		{
    			X0Y0_柄左1.Dra = value;
    			X0Y0_柄左1.Hit = value;
    		}
    	}

    	public bool 柄左2_表示
    	{
    		get
    		{
    			return X0Y0_柄左2.Dra;
    		}
    		set
    		{
    			X0Y0_柄左2.Dra = value;
    			X0Y0_柄左2.Hit = value;
    		}
    	}

    	public bool 柄右1_表示
    	{
    		get
    		{
    			return X0Y0_柄右1.Dra;
    		}
    		set
    		{
    			X0Y0_柄右1.Dra = value;
    			X0Y0_柄右1.Hit = value;
    		}
    	}

    	public bool 柄右2_表示
    	{
    		get
    		{
    			return X0Y0_柄右2.Dra;
    		}
    		set
    		{
    			X0Y0_柄右2.Dra = value;
    			X0Y0_柄右2.Hit = value;
    		}
    	}

    	public bool 出糸突起後_出糸突起基_表示
    	{
    		get
    		{
    			return X0Y0_出糸突起後_出糸突起基.Dra;
    		}
    		set
    		{
    			X0Y0_出糸突起後_出糸突起基.Dra = value;
    			X0Y0_出糸突起後_出糸突起基.Hit = value;
    		}
    	}

    	public bool 出糸突起後_出糸突起中_表示
    	{
    		get
    		{
    			return X0Y0_出糸突起後_出糸突起中.Dra;
    		}
    		set
    		{
    			X0Y0_出糸突起後_出糸突起中.Dra = value;
    			X0Y0_出糸突起後_出糸突起中.Hit = value;
    		}
    	}

    	public bool 出糸突起後_出糸突起左_表示
    	{
    		get
    		{
    			return X0Y0_出糸突起後_出糸突起左.Dra;
    		}
    		set
    		{
    			X0Y0_出糸突起後_出糸突起左.Dra = value;
    			X0Y0_出糸突起後_出糸突起左.Hit = value;
    		}
    	}

    	public bool 出糸突起後_出糸突起右_表示
    	{
    		get
    		{
    			return X0Y0_出糸突起後_出糸突起右.Dra;
    		}
    		set
    		{
    			X0Y0_出糸突起後_出糸突起右.Dra = value;
    			X0Y0_出糸突起後_出糸突起右.Hit = value;
    		}
    	}

    	public bool 出糸突起左_出糸突起1_表示
    	{
    		get
    		{
    			return X0Y0_出糸突起左_出糸突起1.Dra;
    		}
    		set
    		{
    			X0Y0_出糸突起左_出糸突起1.Dra = value;
    			X0Y0_出糸突起左_出糸突起1.Hit = value;
    		}
    	}

    	public bool 出糸突起左_出糸突起2_表示
    	{
    		get
    		{
    			return X0Y0_出糸突起左_出糸突起2.Dra;
    		}
    		set
    		{
    			X0Y0_出糸突起左_出糸突起2.Dra = value;
    			X0Y0_出糸突起左_出糸突起2.Hit = value;
    		}
    	}

    	public bool 出糸突起右_出糸突起1_表示
    	{
    		get
    		{
    			return X0Y0_出糸突起右_出糸突起1.Dra;
    		}
    		set
    		{
    			X0Y0_出糸突起右_出糸突起1.Dra = value;
    			X0Y0_出糸突起右_出糸突起1.Hit = value;
    		}
    	}

    	public bool 出糸突起右_出糸突起2_表示
    	{
    		get
    		{
    			return X0Y0_出糸突起右_出糸突起2.Dra;
    		}
    		set
    		{
    			X0Y0_出糸突起右_出糸突起2.Dra = value;
    			X0Y0_出糸突起右_出糸突起2.Hit = value;
    		}
    	}

    	public bool 出糸突起前_出糸突起左_表示
    	{
    		get
    		{
    			return X0Y0_出糸突起前_出糸突起左.Dra;
    		}
    		set
    		{
    			X0Y0_出糸突起前_出糸突起左.Dra = value;
    			X0Y0_出糸突起前_出糸突起左.Hit = value;
    		}
    	}

    	public bool 出糸突起前_出糸突起右_表示
    	{
    		get
    		{
    			return X0Y0_出糸突起前_出糸突起右.Dra;
    		}
    		set
    		{
    			X0Y0_出糸突起前_出糸突起右.Dra = value;
    			X0Y0_出糸突起前_出糸突起右.Hit = value;
    		}
    	}

    	public bool 付根線_表示
    	{
    		get
    		{
    			return X0Y0_付根線.Dra;
    		}
    		set
    		{
    			X0Y0_付根線.Dra = value;
    			X0Y0_付根線.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 尾0_表示;
    		}
    		set
    		{
    			尾0_表示 = value;
    			柄0_表示 = value;
    			柄左1_表示 = value;
    			柄左2_表示 = value;
    			柄右1_表示 = value;
    			柄右2_表示 = value;
    			出糸突起後_出糸突起基_表示 = value;
    			出糸突起後_出糸突起中_表示 = value;
    			出糸突起後_出糸突起左_表示 = value;
    			出糸突起後_出糸突起右_表示 = value;
    			出糸突起左_出糸突起1_表示 = value;
    			出糸突起左_出糸突起2_表示 = value;
    			出糸突起右_出糸突起1_表示 = value;
    			出糸突起右_出糸突起2_表示 = value;
    			出糸突起前_出糸突起左_表示 = value;
    			出糸突起前_出糸突起右_表示 = value;
    			付根線_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 尾0CD.不透明度;
    		}
    		set
    		{
    			尾0CD.不透明度 = value;
    			柄0CD.不透明度 = value;
    			柄左1CD.不透明度 = value;
    			柄左2CD.不透明度 = value;
    			柄右1CD.不透明度 = value;
    			柄右2CD.不透明度 = value;
    			出糸突起後_出糸突起基CD.不透明度 = value;
    			出糸突起後_出糸突起中CD.不透明度 = value;
    			出糸突起後_出糸突起左CD.不透明度 = value;
    			出糸突起後_出糸突起右CD.不透明度 = value;
    			出糸突起左_出糸突起1CD.不透明度 = value;
    			出糸突起左_出糸突起2CD.不透明度 = value;
    			出糸突起右_出糸突起1CD.不透明度 = value;
    			出糸突起右_出糸突起2CD.不透明度 = value;
    			出糸突起前_出糸突起左CD.不透明度 = value;
    			出糸突起前_出糸突起右CD.不透明度 = value;
    			付根線CD.不透明度 = value;
    		}
    	}

    	public bool 出糸
    	{
    		get
    		{
    			return 出糸_;
    		}
    		set
    		{
    			出糸_ = value;
    			出糸突起後_出糸突起左_表示 = !出糸_;
    			出糸突起後_出糸突起右_表示 = !出糸_;
    			出糸突起左_出糸突起1_表示 = 出糸_;
    			出糸突起左_出糸突起2_表示 = 出糸_;
    			出糸突起右_出糸突起1_表示 = 出糸_;
    			出糸突起右_出糸突起2_表示 = 出糸_;
    		}
    	}

    	public JointS 出糸_接続点 => new JointS(Body, X0Y0_尾0, 0);

    	public 尾_蜘(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 尾_蜘D e)
    	{
    		尾_蜘 尾_蜘2 = this;
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "蜘尾";
    		dif.Add(new Pars(Sta.尻尾["尾"][0][11]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_尾0 = pars["尾0"].ToPar();
    		X0Y0_柄0 = pars["柄0"].ToPar();
    		X0Y0_柄左1 = pars["柄左1"].ToPar();
    		X0Y0_柄左2 = pars["柄左2"].ToPar();
    		X0Y0_柄右1 = pars["柄右1"].ToPar();
    		X0Y0_柄右2 = pars["柄右2"].ToPar();
    		Pars pars2 = pars["出糸突起後"].ToPars();
    		X0Y0_出糸突起後_出糸突起基 = pars2["出糸突起基"].ToPar();
    		X0Y0_出糸突起後_出糸突起中 = pars2["出糸突起中"].ToPar();
    		X0Y0_出糸突起後_出糸突起左 = pars2["出糸突起左"].ToPar();
    		X0Y0_出糸突起後_出糸突起右 = pars2["出糸突起右"].ToPar();
    		pars2 = pars["出糸突起左"].ToPars();
    		X0Y0_出糸突起左_出糸突起1 = pars2["出糸突起1"].ToPar();
    		X0Y0_出糸突起左_出糸突起2 = pars2["出糸突起2"].ToPar();
    		pars2 = pars["出糸突起右"].ToPars();
    		X0Y0_出糸突起右_出糸突起1 = pars2["出糸突起1"].ToPar();
    		X0Y0_出糸突起右_出糸突起2 = pars2["出糸突起2"].ToPar();
    		pars2 = pars["出糸突起前"].ToPars();
    		X0Y0_出糸突起前_出糸突起左 = pars2["出糸突起左"].ToPar();
    		X0Y0_出糸突起前_出糸突起右 = pars2["出糸突起右"].ToPar();
    		X0Y0_付根線 = pars["付根線"].ToPar();
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
    		尾0_表示 = e.尾0_表示;
    		柄0_表示 = e.柄0_表示;
    		柄左1_表示 = e.柄左1_表示;
    		柄左2_表示 = e.柄左2_表示;
    		柄右1_表示 = e.柄右1_表示;
    		柄右2_表示 = e.柄右2_表示;
    		出糸突起後_出糸突起基_表示 = e.出糸突起後_出糸突起基_表示;
    		出糸突起後_出糸突起中_表示 = e.出糸突起後_出糸突起中_表示;
    		出糸突起後_出糸突起左_表示 = e.出糸突起後_出糸突起左_表示;
    		出糸突起後_出糸突起右_表示 = e.出糸突起後_出糸突起右_表示;
    		出糸突起左_出糸突起1_表示 = e.出糸突起左_出糸突起1_表示;
    		出糸突起左_出糸突起2_表示 = e.出糸突起左_出糸突起2_表示;
    		出糸突起右_出糸突起1_表示 = e.出糸突起右_出糸突起1_表示;
    		出糸突起右_出糸突起2_表示 = e.出糸突起右_出糸突起2_表示;
    		出糸突起前_出糸突起左_表示 = e.出糸突起前_出糸突起左_表示;
    		出糸突起前_出糸突起右_表示 = e.出糸突起前_出糸突起右_表示;
    		付根線_表示 = e.付根線_表示;
    		出糸 = e.出糸;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.出糸_接続.Count > 0)
    		{
    			Ele f;
    			出糸_接続 = e.出糸_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 尾_蜘2;
    				f.ConnectionType = ConnectionInfo.尾_蜘_出糸_接続;
    				f.接続(尾_蜘2.出糸_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_尾0CP = new ColorP(X0Y0_尾0, 尾0CD, DisUnit, abj: true);
    		X0Y0_柄0CP = new ColorP(X0Y0_柄0, 柄0CD, DisUnit, abj: true);
    		X0Y0_柄左1CP = new ColorP(X0Y0_柄左1, 柄左1CD, DisUnit, abj: true);
    		X0Y0_柄左2CP = new ColorP(X0Y0_柄左2, 柄左2CD, DisUnit, abj: true);
    		X0Y0_柄右1CP = new ColorP(X0Y0_柄右1, 柄右1CD, DisUnit, abj: true);
    		X0Y0_柄右2CP = new ColorP(X0Y0_柄右2, 柄右2CD, DisUnit, abj: true);
    		X0Y0_出糸突起後_出糸突起基CP = new ColorP(X0Y0_出糸突起後_出糸突起基, 出糸突起後_出糸突起基CD, DisUnit, abj: true);
    		X0Y0_出糸突起後_出糸突起中CP = new ColorP(X0Y0_出糸突起後_出糸突起中, 出糸突起後_出糸突起中CD, DisUnit, abj: true);
    		X0Y0_出糸突起後_出糸突起左CP = new ColorP(X0Y0_出糸突起後_出糸突起左, 出糸突起後_出糸突起左CD, DisUnit, abj: true);
    		X0Y0_出糸突起後_出糸突起右CP = new ColorP(X0Y0_出糸突起後_出糸突起右, 出糸突起後_出糸突起右CD, DisUnit, abj: true);
    		X0Y0_出糸突起左_出糸突起1CP = new ColorP(X0Y0_出糸突起左_出糸突起1, 出糸突起左_出糸突起1CD, DisUnit, abj: true);
    		X0Y0_出糸突起左_出糸突起2CP = new ColorP(X0Y0_出糸突起左_出糸突起2, 出糸突起左_出糸突起2CD, DisUnit, abj: true);
    		X0Y0_出糸突起右_出糸突起1CP = new ColorP(X0Y0_出糸突起右_出糸突起1, 出糸突起右_出糸突起1CD, DisUnit, abj: true);
    		X0Y0_出糸突起右_出糸突起2CP = new ColorP(X0Y0_出糸突起右_出糸突起2, 出糸突起右_出糸突起2CD, DisUnit, abj: true);
    		X0Y0_出糸突起前_出糸突起左CP = new ColorP(X0Y0_出糸突起前_出糸突起左, 出糸突起前_出糸突起左CD, DisUnit, abj: true);
    		X0Y0_出糸突起前_出糸突起右CP = new ColorP(X0Y0_出糸突起前_出糸突起右, 出糸突起前_出糸突起右CD, DisUnit, abj: true);
    		X0Y0_付根線CP = new ColorP(X0Y0_付根線, 付根線CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		_ = 右;
    		Body.JoinPAall();
    	}

    	public override IEnumerable<Par> Enum軸()
    	{
    		yield return X0Y0_尾0;
    	}

    	public override void 色更新()
    	{
    		X0Y0_尾0CP.Update();
    		X0Y0_柄0CP.Par.GetMiY_MaY(out mm);
    		X0Y0_柄0CP.Update(mm);
    		X0Y0_柄左1CP.Update(mm);
    		X0Y0_柄左2CP.Update(mm);
    		X0Y0_柄右1CP.Update(mm);
    		X0Y0_柄右2CP.Update(mm);
    		X0Y0_出糸突起後_出糸突起基CP.Update();
    		X0Y0_出糸突起後_出糸突起中CP.Update();
    		X0Y0_出糸突起後_出糸突起左CP.Update();
    		X0Y0_出糸突起後_出糸突起右CP.Update();
    		X0Y0_出糸突起左_出糸突起1CP.Update();
    		X0Y0_出糸突起左_出糸突起2CP.Update();
    		X0Y0_出糸突起右_出糸突起1CP.Update();
    		X0Y0_出糸突起右_出糸突起2CP.Update();
    		X0Y0_出糸突起前_出糸突起左CP.Update();
    		X0Y0_出糸突起前_出糸突起右CP.Update();
    		X0Y0_付根線CP.Update();
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
    		尾0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		柄0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		柄左1CD = new ColorD(ref Col.Black, ref 体配色.柄O);
    		柄左2CD = new ColorD(ref Col.Black, ref 体配色.柄O);
    		柄右1CD = new ColorD(ref Col.Black, ref 体配色.柄O);
    		柄右2CD = new ColorD(ref Col.Black, ref 体配色.柄O);
    		出糸突起後_出糸突起基CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		出糸突起後_出糸突起中CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		出糸突起後_出糸突起左CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		出糸突起後_出糸突起右CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		出糸突起左_出糸突起1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		出糸突起左_出糸突起2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		出糸突起右_出糸突起1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		出糸突起右_出糸突起2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		出糸突起前_出糸突起左CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		出糸突起前_出糸突起右CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		付根線CD = new ColorD(ref Col.Black, ref Color2.Empty);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		尾0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		柄0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		柄左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		柄左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		柄右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		柄右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		出糸突起後_出糸突起基CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		出糸突起後_出糸突起中CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		出糸突起後_出糸突起左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		出糸突起後_出糸突起右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		出糸突起左_出糸突起1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		出糸突起左_出糸突起2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		出糸突起右_出糸突起1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		出糸突起右_出糸突起2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		出糸突起前_出糸突起左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		出糸突起前_出糸突起右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		付根線CD = new ColorD(ref Col.Black, ref Color2.Empty);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		尾0CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		柄0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		柄左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		柄左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		柄右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		柄右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		出糸突起後_出糸突起基CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		出糸突起後_出糸突起中CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		出糸突起後_出糸突起左CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		出糸突起後_出糸突起右CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		出糸突起左_出糸突起1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		出糸突起左_出糸突起2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		出糸突起右_出糸突起1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		出糸突起右_出糸突起2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		出糸突起前_出糸突起左CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		出糸突起前_出糸突起右CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		付根線CD = new ColorD(ref Col.Black, ref Color2.Empty);
    	}
    }
}
