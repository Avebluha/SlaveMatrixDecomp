using System.Linq;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class 顔面_甲 : 顔面
    {
    	public Par X0Y0_面額;

    	public Par X0Y0_面左下_面目;

    	public Par X0Y0_面左下_面;

    	public Par X0Y0_面右下_面目;

    	public Par X0Y0_面右下_面;

    	public Par X0Y0_面左外;

    	public Par X0Y0_面右外;

    	public Par X0Y0_面左上_面目;

    	public Par X0Y0_面左上_面;

    	public Par X0Y0_面右上_面目;

    	public Par X0Y0_面右上_面;

    	public Par X0Y0_面中0_面中;

    	public Par X0Y0_面中0_付根左_付根1;

    	public Par X0Y0_面中0_付根左_付根2;

    	public Par X0Y0_面中0_付根右_付根1;

    	public Par X0Y0_面中0_付根右_付根2;

    	public Par X0Y0_面中2_面中;

    	public Par X0Y0_面中2_面中下;

    	public Par X0Y0_面中1_面中;

    	public Par X0Y0_面中1_面中下;

    	public ColorD 面額CD;

    	public ColorD 面左下_面目CD;

    	public ColorD 面左下_面CD;

    	public ColorD 面右下_面目CD;

    	public ColorD 面右下_面CD;

    	public ColorD 面左外CD;

    	public ColorD 面右外CD;

    	public ColorD 面左上_面目CD;

    	public ColorD 面左上_面CD;

    	public ColorD 面右上_面目CD;

    	public ColorD 面右上_面CD;

    	public ColorD 面中0_面中CD;

    	public ColorD 面中0_付根左_付根1CD;

    	public ColorD 面中0_付根左_付根2CD;

    	public ColorD 面中0_付根右_付根1CD;

    	public ColorD 面中0_付根右_付根2CD;

    	public ColorD 面中2_面中CD;

    	public ColorD 面中2_面中下CD;

    	public ColorD 面中1_面中CD;

    	public ColorD 面中1_面中下CD;

    	public ColorP X0Y0_面額CP;

    	public ColorP X0Y0_面左下_面目CP;

    	public ColorP X0Y0_面左下_面CP;

    	public ColorP X0Y0_面右下_面目CP;

    	public ColorP X0Y0_面右下_面CP;

    	public ColorP X0Y0_面左外CP;

    	public ColorP X0Y0_面右外CP;

    	public ColorP X0Y0_面左上_面目CP;

    	public ColorP X0Y0_面左上_面CP;

    	public ColorP X0Y0_面右上_面目CP;

    	public ColorP X0Y0_面右上_面CP;

    	public ColorP X0Y0_面中0_面中CP;

    	public ColorP X0Y0_面中0_付根左_付根1CP;

    	public ColorP X0Y0_面中0_付根左_付根2CP;

    	public ColorP X0Y0_面中0_付根右_付根1CP;

    	public ColorP X0Y0_面中0_付根右_付根2CP;

    	public ColorP X0Y0_面中2_面中CP;

    	public ColorP X0Y0_面中2_面中下CP;

    	public ColorP X0Y0_面中1_面中CP;

    	public ColorP X0Y0_面中1_面中下CP;

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

    	public bool 面額_表示
    	{
    		get
    		{
    			return X0Y0_面額.Dra;
    		}
    		set
    		{
    			X0Y0_面額.Dra = value;
    			X0Y0_面額.Hit = value;
    		}
    	}

    	public bool 面左下_面目_表示
    	{
    		get
    		{
    			return X0Y0_面左下_面目.Dra;
    		}
    		set
    		{
    			X0Y0_面左下_面目.Dra = value;
    			X0Y0_面左下_面目.Hit = value;
    		}
    	}

    	public bool 面左下_面_表示
    	{
    		get
    		{
    			return X0Y0_面左下_面.Dra;
    		}
    		set
    		{
    			X0Y0_面左下_面.Dra = value;
    			X0Y0_面左下_面.Hit = value;
    		}
    	}

    	public bool 面右下_面目_表示
    	{
    		get
    		{
    			return X0Y0_面右下_面目.Dra;
    		}
    		set
    		{
    			X0Y0_面右下_面目.Dra = value;
    			X0Y0_面右下_面目.Hit = value;
    		}
    	}

    	public bool 面右下_面_表示
    	{
    		get
    		{
    			return X0Y0_面右下_面.Dra;
    		}
    		set
    		{
    			X0Y0_面右下_面.Dra = value;
    			X0Y0_面右下_面.Hit = value;
    		}
    	}

    	public bool 面左外_表示
    	{
    		get
    		{
    			return X0Y0_面左外.Dra;
    		}
    		set
    		{
    			X0Y0_面左外.Dra = value;
    			X0Y0_面左外.Hit = value;
    		}
    	}

    	public bool 面右外_表示
    	{
    		get
    		{
    			return X0Y0_面右外.Dra;
    		}
    		set
    		{
    			X0Y0_面右外.Dra = value;
    			X0Y0_面右外.Hit = value;
    		}
    	}

    	public bool 面左上_面目_表示
    	{
    		get
    		{
    			return X0Y0_面左上_面目.Dra;
    		}
    		set
    		{
    			X0Y0_面左上_面目.Dra = value;
    			X0Y0_面左上_面目.Hit = value;
    		}
    	}

    	public bool 面左上_面_表示
    	{
    		get
    		{
    			return X0Y0_面左上_面.Dra;
    		}
    		set
    		{
    			X0Y0_面左上_面.Dra = value;
    			X0Y0_面左上_面.Hit = value;
    		}
    	}

    	public bool 面右上_面目_表示
    	{
    		get
    		{
    			return X0Y0_面右上_面目.Dra;
    		}
    		set
    		{
    			X0Y0_面右上_面目.Dra = value;
    			X0Y0_面右上_面目.Hit = value;
    		}
    	}

    	public bool 面右上_面_表示
    	{
    		get
    		{
    			return X0Y0_面右上_面.Dra;
    		}
    		set
    		{
    			X0Y0_面右上_面.Dra = value;
    			X0Y0_面右上_面.Hit = value;
    		}
    	}

    	public bool 面中0_面中_表示
    	{
    		get
    		{
    			return X0Y0_面中0_面中.Dra;
    		}
    		set
    		{
    			X0Y0_面中0_面中.Dra = value;
    			X0Y0_面中0_面中.Hit = value;
    		}
    	}

    	public bool 面中0_付根左_付根1_表示
    	{
    		get
    		{
    			return X0Y0_面中0_付根左_付根1.Dra;
    		}
    		set
    		{
    			X0Y0_面中0_付根左_付根1.Dra = value;
    			X0Y0_面中0_付根左_付根1.Hit = value;
    		}
    	}

    	public bool 面中0_付根左_付根2_表示
    	{
    		get
    		{
    			return X0Y0_面中0_付根左_付根2.Dra;
    		}
    		set
    		{
    			X0Y0_面中0_付根左_付根2.Dra = value;
    			X0Y0_面中0_付根左_付根2.Hit = value;
    		}
    	}

    	public bool 面中0_付根右_付根1_表示
    	{
    		get
    		{
    			return X0Y0_面中0_付根右_付根1.Dra;
    		}
    		set
    		{
    			X0Y0_面中0_付根右_付根1.Dra = value;
    			X0Y0_面中0_付根右_付根1.Hit = value;
    		}
    	}

    	public bool 面中0_付根右_付根2_表示
    	{
    		get
    		{
    			return X0Y0_面中0_付根右_付根2.Dra;
    		}
    		set
    		{
    			X0Y0_面中0_付根右_付根2.Dra = value;
    			X0Y0_面中0_付根右_付根2.Hit = value;
    		}
    	}

    	public bool 面中2_面中_表示
    	{
    		get
    		{
    			return X0Y0_面中2_面中.Dra;
    		}
    		set
    		{
    			X0Y0_面中2_面中.Dra = value;
    			X0Y0_面中2_面中.Hit = value;
    		}
    	}

    	public bool 面中2_面中下_表示
    	{
    		get
    		{
    			return X0Y0_面中2_面中下.Dra;
    		}
    		set
    		{
    			X0Y0_面中2_面中下.Dra = value;
    			X0Y0_面中2_面中下.Hit = value;
    		}
    	}

    	public bool 面中1_面中_表示
    	{
    		get
    		{
    			return X0Y0_面中1_面中.Dra;
    		}
    		set
    		{
    			X0Y0_面中1_面中.Dra = value;
    			X0Y0_面中1_面中.Hit = value;
    		}
    	}

    	public bool 面中1_面中下_表示
    	{
    		get
    		{
    			return X0Y0_面中1_面中下.Dra;
    		}
    		set
    		{
    			X0Y0_面中1_面中下.Dra = value;
    			X0Y0_面中1_面中下.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 面額_表示;
    		}
    		set
    		{
    			面額_表示 = value;
    			面左下_面目_表示 = value;
    			面左下_面_表示 = value;
    			面右下_面目_表示 = value;
    			面右下_面_表示 = value;
    			面左外_表示 = value;
    			面右外_表示 = value;
    			面左上_面目_表示 = value;
    			面左上_面_表示 = value;
    			面右上_面目_表示 = value;
    			面右上_面_表示 = value;
    			面中0_面中_表示 = value;
    			面中0_付根左_付根1_表示 = value;
    			面中0_付根左_付根2_表示 = value;
    			面中0_付根右_付根1_表示 = value;
    			面中0_付根右_付根2_表示 = value;
    			面中2_面中_表示 = value;
    			面中2_面中下_表示 = value;
    			面中1_面中_表示 = value;
    			面中1_面中下_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 面額CD.不透明度;
    		}
    		set
    		{
    			面額CD.不透明度 = value;
    			面左下_面目CD.不透明度 = value;
    			面左下_面CD.不透明度 = value;
    			面右下_面目CD.不透明度 = value;
    			面右下_面CD.不透明度 = value;
    			面左外CD.不透明度 = value;
    			面右外CD.不透明度 = value;
    			面左上_面目CD.不透明度 = value;
    			面左上_面CD.不透明度 = value;
    			面右上_面目CD.不透明度 = value;
    			面右上_面CD.不透明度 = value;
    			面中0_面中CD.不透明度 = value;
    			面中0_付根左_付根1CD.不透明度 = value;
    			面中0_付根左_付根2CD.不透明度 = value;
    			面中0_付根右_付根1CD.不透明度 = value;
    			面中0_付根右_付根2CD.不透明度 = value;
    			面中2_面中CD.不透明度 = value;
    			面中2_面中下CD.不透明度 = value;
    			面中1_面中CD.不透明度 = value;
    			面中1_面中下CD.不透明度 = value;
    		}
    	}

    	public override double 展開1
    	{
    		set
    		{
    			Vector2D positionCont = (X0Y0_面左下_面.GetOP()[1].ps[2] - X0Y0_面左下_面.GetOP()[2].ps[2]) * value;
    			X0Y0_面左上_面目.SetPositionCont(positionCont);
    			X0Y0_面左下_面目.SetPositionCont(positionCont);
    			X0Y0_面左下_面.SetPositionCont(positionCont);
    			X0Y0_面左外.SetPositionCont(positionCont);
    			positionCont = (X0Y0_面右下_面.GetOP()[3].ps[2] - X0Y0_面右下_面.GetOP()[2].ps[2]) * value;
    			X0Y0_面右上_面目.SetPositionCont(positionCont);
    			X0Y0_面右下_面目.SetPositionCont(positionCont);
    			X0Y0_面右下_面.SetPositionCont(positionCont);
    			X0Y0_面右外.SetPositionCont(positionCont);
    			X0Y0_面中2_面中.SetPositionCont((X0Y0_面中2_面中.GetOP()[2].ps[1] - X0Y0_面中2_面中.GetOP()[0].ps[0]) * 0.35 * value);
    		}
    	}

    	public JointS 触覚左_接続点 => new JointS(Body, X0Y0_面中0_付根左_付根2, 0);

    	public JointS 触覚右_接続点 => new JointS(Body, X0Y0_面中0_付根右_付根2, 0);

    	public 顔面_甲(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 顔面_甲D e)
    	{
    		顔面_甲 顔面_甲2 = this;
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.肢中["顔面"][0]);
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_面額 = pars["面額"].ToPar();
    		Pars pars2 = pars["面左下"].ToPars();
    		X0Y0_面左下_面目 = pars2["面目"].ToPar();
    		X0Y0_面左下_面 = pars2["面"].ToPar();
    		pars2 = pars["面右下"].ToPars();
    		X0Y0_面右下_面目 = pars2["面目"].ToPar();
    		X0Y0_面右下_面 = pars2["面"].ToPar();
    		X0Y0_面左外 = pars["面左外"].ToPar();
    		X0Y0_面右外 = pars["面右外"].ToPar();
    		pars2 = pars["面左上"].ToPars();
    		X0Y0_面左上_面目 = pars2["面目"].ToPar();
    		X0Y0_面左上_面 = pars2["面"].ToPar();
    		pars2 = pars["面右上"].ToPars();
    		X0Y0_面右上_面目 = pars2["面目"].ToPar();
    		X0Y0_面右上_面 = pars2["面"].ToPar();
    		pars2 = pars["面中0"].ToPars();
    		X0Y0_面中0_面中 = pars2["面中"].ToPar();
    		Pars pars3 = pars2["付根左"].ToPars();
    		X0Y0_面中0_付根左_付根1 = pars3["付根1"].ToPar();
    		X0Y0_面中0_付根左_付根2 = pars3["付根2"].ToPar();
    		pars3 = pars2["付根右"].ToPars();
    		X0Y0_面中0_付根右_付根1 = pars3["付根1"].ToPar();
    		X0Y0_面中0_付根右_付根2 = pars3["付根2"].ToPar();
    		pars2 = pars["面中2"].ToPars();
    		X0Y0_面中2_面中 = pars2["面中"].ToPar();
    		X0Y0_面中2_面中下 = pars2["面中下"].ToPar();
    		pars2 = pars["面中1"].ToPars();
    		X0Y0_面中1_面中 = pars2["面中"].ToPar();
    		X0Y0_面中1_面中下 = pars2["面中下"].ToPar();
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
    		面額_表示 = e.面額_表示;
    		面左下_面目_表示 = e.面左下_面目_表示;
    		面左下_面_表示 = e.面左下_面_表示;
    		面右下_面目_表示 = e.面右下_面目_表示;
    		面右下_面_表示 = e.面右下_面_表示;
    		面左外_表示 = e.面左外_表示;
    		面右外_表示 = e.面右外_表示;
    		面左上_面目_表示 = e.面左上_面目_表示;
    		面左上_面_表示 = e.面左上_面_表示;
    		面右上_面目_表示 = e.面右上_面目_表示;
    		面右上_面_表示 = e.面右上_面_表示;
    		面中0_面中_表示 = e.面中0_面中_表示;
    		面中0_付根左_付根1_表示 = e.面中0_付根左_付根1_表示;
    		面中0_付根左_付根2_表示 = e.面中0_付根左_付根2_表示;
    		面中0_付根右_付根1_表示 = e.面中0_付根右_付根1_表示;
    		面中0_付根右_付根2_表示 = e.面中0_付根右_付根2_表示;
    		面中2_面中_表示 = e.面中2_面中_表示;
    		面中2_面中下_表示 = e.面中2_面中下_表示;
    		面中1_面中_表示 = e.面中1_面中_表示;
    		面中1_面中下_表示 = e.面中1_面中下_表示;
    		base.展開0 = e.展開0;
    		展開1 = e.展開1;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Ele f;
    		if (e.触覚左_接続.Count > 0)
    		{
    			触覚左_接続 = e.触覚左_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 顔面_甲2;
    				f.ConnectionType = ConnectionInfo.顔面_甲_触覚左_接続;
    				f.接続(顔面_甲2.触覚左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.触覚右_接続.Count > 0)
    		{
    			触覚右_接続 = e.触覚右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 顔面_甲2;
    				f.ConnectionType = ConnectionInfo.顔面_甲_触覚右_接続;
    				f.接続(顔面_甲2.触覚右_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_面額CP = new ColorP(X0Y0_面額, 面額CD, DisUnit, abj: true);
    		X0Y0_面左下_面目CP = new ColorP(X0Y0_面左下_面目, 面左下_面目CD, DisUnit, abj: true);
    		X0Y0_面左下_面CP = new ColorP(X0Y0_面左下_面, 面左下_面CD, DisUnit, abj: true);
    		X0Y0_面右下_面目CP = new ColorP(X0Y0_面右下_面目, 面右下_面目CD, DisUnit, abj: true);
    		X0Y0_面右下_面CP = new ColorP(X0Y0_面右下_面, 面右下_面CD, DisUnit, abj: true);
    		X0Y0_面左外CP = new ColorP(X0Y0_面左外, 面左外CD, DisUnit, abj: true);
    		X0Y0_面右外CP = new ColorP(X0Y0_面右外, 面右外CD, DisUnit, abj: true);
    		X0Y0_面左上_面目CP = new ColorP(X0Y0_面左上_面目, 面左上_面目CD, DisUnit, abj: true);
    		X0Y0_面左上_面CP = new ColorP(X0Y0_面左上_面, 面左上_面CD, DisUnit, abj: true);
    		X0Y0_面右上_面目CP = new ColorP(X0Y0_面右上_面目, 面右上_面目CD, DisUnit, abj: true);
    		X0Y0_面右上_面CP = new ColorP(X0Y0_面右上_面, 面右上_面CD, DisUnit, abj: true);
    		X0Y0_面中0_面中CP = new ColorP(X0Y0_面中0_面中, 面中0_面中CD, DisUnit, abj: true);
    		X0Y0_面中0_付根左_付根1CP = new ColorP(X0Y0_面中0_付根左_付根1, 面中0_付根左_付根1CD, DisUnit, abj: true);
    		X0Y0_面中0_付根左_付根2CP = new ColorP(X0Y0_面中0_付根左_付根2, 面中0_付根左_付根2CD, DisUnit, abj: true);
    		X0Y0_面中0_付根右_付根1CP = new ColorP(X0Y0_面中0_付根右_付根1, 面中0_付根右_付根1CD, DisUnit, abj: true);
    		X0Y0_面中0_付根右_付根2CP = new ColorP(X0Y0_面中0_付根右_付根2, 面中0_付根右_付根2CD, DisUnit, abj: true);
    		X0Y0_面中2_面中CP = new ColorP(X0Y0_面中2_面中, 面中2_面中CD, DisUnit, abj: true);
    		X0Y0_面中2_面中下CP = new ColorP(X0Y0_面中2_面中下, 面中2_面中下CD, DisUnit, abj: true);
    		X0Y0_面中1_面中CP = new ColorP(X0Y0_面中1_面中, 面中1_面中CD, DisUnit, abj: true);
    		X0Y0_面中1_面中下CP = new ColorP(X0Y0_面中1_面中下, 面中1_面中下CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_面額CP.Update();
    		X0Y0_面左下_面目CP.Update();
    		X0Y0_面左下_面CP.Update();
    		X0Y0_面右下_面目CP.Update();
    		X0Y0_面右下_面CP.Update();
    		X0Y0_面左外CP.Update();
    		X0Y0_面右外CP.Update();
    		X0Y0_面左上_面目CP.Update();
    		X0Y0_面左上_面CP.Update();
    		X0Y0_面右上_面目CP.Update();
    		X0Y0_面右上_面CP.Update();
    		X0Y0_面中0_面中CP.Update();
    		X0Y0_面中0_付根左_付根1CP.Update();
    		X0Y0_面中0_付根左_付根2CP.Update();
    		X0Y0_面中0_付根右_付根1CP.Update();
    		X0Y0_面中0_付根右_付根2CP.Update();
    		X0Y0_面中2_面中CP.Update();
    		X0Y0_面中2_面中下CP.Update();
    		X0Y0_面中1_面中CP.Update();
    		X0Y0_面中1_面中下CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		面額CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		面左下_面目CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		面左下_面CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		面右下_面目CD = 面左下_面目CD;
    		面右下_面CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		面左外CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		面右外CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		面左上_面目CD = 面左下_面目CD;
    		面左上_面CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		面右上_面目CD = 面左下_面目CD;
    		面右上_面CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		面中0_面中CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		面中0_付根左_付根1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		面中0_付根左_付根2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		面中0_付根右_付根1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		面中0_付根右_付根2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		面中2_面中CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		面中2_面中下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		面中1_面中CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		面中1_面中下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    	}
    }
}
