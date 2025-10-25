using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class Torso : Ele
    {
    	public Par X0Y0_胴;

    	public Par X0Y0_筋肉_筋肉左;

    	public Par X0Y0_筋肉_筋肉右;

    	public Par X0Y0_獣性_獣毛左;

    	public Par X0Y0_獣性_獣毛右;

    	public Par X0Y0_植タトゥ_左_タトゥ2;

    	public Par X0Y0_植タトゥ_左_タトゥ1;

    	public Par X0Y0_植タトゥ_右_タトゥ2;

    	public Par X0Y0_植タトゥ_右_タトゥ1;

    	public ColorD 胴CD;

    	public ColorD 筋肉_筋肉左CD;

    	public ColorD 筋肉_筋肉右CD;

    	public ColorD 獣性_獣毛左CD;

    	public ColorD 獣性_獣毛右CD;

    	public ColorD 植タトゥ_左_タトゥ2CD;

    	public ColorD 植タトゥ_左_タトゥ1CD;

    	public ColorD 植タトゥ_右_タトゥ2CD;

    	public ColorD 植タトゥ_右_タトゥ1CD;

    	public ColorP X0Y0_胴CP;

    	public ColorP X0Y0_筋肉_筋肉左CP;

    	public ColorP X0Y0_筋肉_筋肉右CP;

    	public ColorP X0Y0_獣性_獣毛左CP;

    	public ColorP X0Y0_獣性_獣毛右CP;

    	public ColorP X0Y0_植タトゥ_左_タトゥ2CP;

    	public ColorP X0Y0_植タトゥ_左_タトゥ1CP;

    	public ColorP X0Y0_植タトゥ_右_タトゥ2CP;

    	public ColorP X0Y0_植タトゥ_右_タトゥ1CP;

    	public スタンプK キスマーク;

    	public スタンプW 鞭痕;

    	public Ele[] 胸_接続;

    	public Ele[] 肌_接続;

    	public Ele[] 翼左_接続;

    	public Ele[] 翼右_接続;

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
    			筋肉_筋肉左_表示 = 筋肉_;
    			筋肉_筋肉右_表示 = 筋肉_;
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

    	public bool 胴_表示
    	{
    		get
    		{
    			return X0Y0_胴.Dra;
    		}
    		set
    		{
    			X0Y0_胴.Dra = value;
    			X0Y0_胴.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉左_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉左.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉左.Dra = value;
    			X0Y0_筋肉_筋肉左.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉右_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉右.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉右.Dra = value;
    			X0Y0_筋肉_筋肉右.Hit = value;
    		}
    	}

    	public bool 獣性_獣毛左_表示
    	{
    		get
    		{
    			return X0Y0_獣性_獣毛左.Dra;
    		}
    		set
    		{
    			X0Y0_獣性_獣毛左.Dra = value;
    			X0Y0_獣性_獣毛左.Hit = value;
    		}
    	}

    	public bool 獣性_獣毛右_表示
    	{
    		get
    		{
    			return X0Y0_獣性_獣毛右.Dra;
    		}
    		set
    		{
    			X0Y0_獣性_獣毛右.Dra = value;
    			X0Y0_獣性_獣毛右.Hit = value;
    		}
    	}

    	public bool 植タトゥ_左_タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_左_タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_左_タトゥ2.Dra = value;
    			X0Y0_植タトゥ_左_タトゥ2.Hit = value;
    		}
    	}

    	public bool 植タトゥ_左_タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_左_タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_左_タトゥ1.Dra = value;
    			X0Y0_植タトゥ_左_タトゥ1.Hit = value;
    		}
    	}

    	public bool 植タトゥ_右_タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_右_タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_右_タトゥ2.Dra = value;
    			X0Y0_植タトゥ_右_タトゥ2.Hit = value;
    		}
    	}

    	public bool 植タトゥ_右_タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_右_タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_右_タトゥ1.Dra = value;
    			X0Y0_植タトゥ_右_タトゥ1.Hit = value;
    		}
    	}

    	public double 筋肉濃度
    	{
    		get
    		{
    			return 筋肉_筋肉左CD.不透明度;
    		}
    		set
    		{
    			筋肉_筋肉左CD.不透明度 = value;
    			筋肉_筋肉右CD.不透明度 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 胴_表示;
    		}
    		set
    		{
    			胴_表示 = value;
    			筋肉_筋肉左_表示 = value;
    			筋肉_筋肉右_表示 = value;
    			獣性_獣毛左_表示 = value;
    			獣性_獣毛右_表示 = value;
    			植タトゥ_左_タトゥ2_表示 = value;
    			植タトゥ_左_タトゥ1_表示 = value;
    			植タトゥ_右_タトゥ2_表示 = value;
    			植タトゥ_右_タトゥ1_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 胴CD.不透明度;
    		}
    		set
    		{
    			胴CD.不透明度 = value;
    			筋肉_筋肉左CD.不透明度 = value;
    			筋肉_筋肉右CD.不透明度 = value;
    			獣性_獣毛左CD.不透明度 = value;
    			獣性_獣毛右CD.不透明度 = value;
    			植タトゥ_左_タトゥ2CD.不透明度 = value;
    			植タトゥ_左_タトゥ1CD.不透明度 = value;
    			植タトゥ_右_タトゥ2CD.不透明度 = value;
    			植タトゥ_右_タトゥ1CD.不透明度 = value;
    		}
    	}

    	public JointS 胸_接続点 => new JointS(本体, X0Y0_胴, 0);

    	public JointS 肌_接続点 => new JointS(本体, X0Y0_胴, 5);

    	public JointS 翼左_接続点 => new JointS(本体, X0Y0_胴, 1);

    	public JointS 翼右_接続点 => new JointS(本体, X0Y0_胴, 2);

    	public Torso(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, TorsoD e)
    	{
    		Torso 胴2 = this;
    		ThisType = GetType();
            //This had no Torso (胴体)
            本体 = new Difs(Sta.胴体["Torso"]);
    		Pars pars = 本体[0][0];
    		X0Y0_胴 = pars["Torso"].ToPar();
    		Pars pars2 = pars["筋肉"].ToPars();
    		X0Y0_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
    		X0Y0_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
    		pars2 = pars["獣性"].ToPars();
    		X0Y0_獣性_獣毛左 = pars2["獣毛左"].ToPar();
    		X0Y0_獣性_獣毛右 = pars2["獣毛右"].ToPar();
    		pars2 = pars["植タトゥ"].ToPars();
    		Pars pars3 = pars2["左"].ToPars();
    		X0Y0_植タトゥ_左_タトゥ2 = pars3["タトゥ2"].ToPar();
    		X0Y0_植タトゥ_左_タトゥ1 = pars3["タトゥ1"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y0_植タトゥ_右_タトゥ2 = pars3["タトゥ2"].ToPar();
    		X0Y0_植タトゥ_右_タトゥ1 = pars3["タトゥ1"].ToPar();
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
    		胴_表示 = e.胴_表示;
    		筋肉_筋肉左_表示 = e.筋肉_筋肉左_表示;
    		筋肉_筋肉右_表示 = e.筋肉_筋肉右_表示;
    		獣性_獣毛左_表示 = e.獣性_獣毛左_表示;
    		獣性_獣毛右_表示 = e.獣性_獣毛右_表示;
    		植タトゥ_左_タトゥ2_表示 = e.植タトゥ_左_タトゥ2_表示;
    		植タトゥ_左_タトゥ1_表示 = e.植タトゥ_左_タトゥ1_表示;
    		植タトゥ_右_タトゥ2_表示 = e.植タトゥ_右_タトゥ2_表示;
    		植タトゥ_右_タトゥ1_表示 = e.植タトゥ_右_タトゥ1_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Ele f;
    		if (e.胸_接続.Count > 0)
    		{
    			胸_接続 = e.胸_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 胴2;
    				f.ConnectionType = ConnectionInfo.Torso_胸_接続;
    				f.接続(胴2.胸_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.肌_接続.Count > 0)
    		{
    			肌_接続 = e.肌_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 胴2;
    				f.ConnectionType = ConnectionInfo.Torso_肌_接続;
    				f.接続(胴2.肌_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼左_接続.Count > 0)
    		{
    			翼左_接続 = e.翼左_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 胴2;
    				f.ConnectionType = ConnectionInfo.Torso_翼左_接続;
    				f.接続(胴2.翼左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼右_接続.Count > 0)
    		{
    			翼右_接続 = e.翼右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 胴2;
    				f.ConnectionType = ConnectionInfo.Torso_翼右_接続;
    				f.接続(胴2.翼右_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_胴CP = new ColorP(X0Y0_胴, 胴CD, DisUnit, abj: true);
    		X0Y0_筋肉_筋肉左CP = new ColorP(X0Y0_筋肉_筋肉左, 筋肉_筋肉左CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉右CP = new ColorP(X0Y0_筋肉_筋肉右, 筋肉_筋肉右CD, DisUnit, abj: false);
    		X0Y0_獣性_獣毛左CP = new ColorP(X0Y0_獣性_獣毛左, 獣性_獣毛左CD, DisUnit, abj: true);
    		X0Y0_獣性_獣毛右CP = new ColorP(X0Y0_獣性_獣毛右, 獣性_獣毛右CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_左_タトゥ2CP = new ColorP(X0Y0_植タトゥ_左_タトゥ2, 植タトゥ_左_タトゥ2CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_左_タトゥ1CP = new ColorP(X0Y0_植タトゥ_左_タトゥ1, 植タトゥ_左_タトゥ1CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_右_タトゥ2CP = new ColorP(X0Y0_植タトゥ_右_タトゥ2, 植タトゥ_右_タトゥ2CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_右_タトゥ1CP = new ColorP(X0Y0_植タトゥ_右_タトゥ1, 植タトゥ_右_タトゥ1CD, DisUnit, abj: true);
    		筋肉濃度 = e.筋肉濃度;
    		濃度 = e.濃度;
    		尺度YB = 0.9;
    	}

    	public override void 描画0(Are Are)
    	{
    		本体.Draw(Are);
    		キスマーク.Draw(Are);
    		鞭痕.Draw(Are);
    	}

    	public override void 色更新()
    	{
    		X0Y0_胴CP.Update();
    		X0Y0_筋肉_筋肉左CP.Update();
    		X0Y0_筋肉_筋肉右CP.Update();
    		X0Y0_獣性_獣毛左CP.Update();
    		X0Y0_獣性_獣毛右CP.Update();
    		X0Y0_植タトゥ_左_タトゥ2CP.Update();
    		X0Y0_植タトゥ_左_タトゥ1CP.Update();
    		X0Y0_植タトゥ_右_タトゥ2CP.Update();
    		X0Y0_植タトゥ_右_タトゥ1CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		胴CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
    		筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		獣性_獣毛左CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		獣性_獣毛右CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		植タトゥ_左_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_左_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_右_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_右_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    	}
    }
}
