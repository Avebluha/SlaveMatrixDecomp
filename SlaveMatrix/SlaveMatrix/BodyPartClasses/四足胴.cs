using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 四足胴 : Element
    {
    	public ShapePart X0Y0_Torso;

    	public ShapePart X0Y0_筋肉_筋肉左;

    	public ShapePart X0Y0_筋肉_筋肉右;

    	public ShapePart X0Y0_獣性_獣毛左;

    	public ShapePart X0Y0_獣性_獣毛右;

    	public ColorD TorsoCD;

    	public ColorD 筋肉_筋肉左CD;

    	public ColorD 筋肉_筋肉右CD;

    	public ColorD 獣性_獣毛左CD;

    	public ColorD 獣性_獣毛右CD;

    	public ColorP X0Y0_TorsoCP;

    	public ColorP X0Y0_筋肉_筋肉左CP;

    	public ColorP X0Y0_筋肉_筋肉右CP;

    	public ColorP X0Y0_獣性_獣毛左CP;

    	public ColorP X0Y0_獣性_獣毛右CP;

    	public Element[] Waist_接続;

    	public Element[] 肌_接続;

    	public Element[] 翼左_接続;

    	public Element[] 翼右_接続;

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

    	public bool Torso_表示
    	{
    		get
    		{
    			return X0Y0_Torso.Dra;
    		}
    		set
    		{
    			X0Y0_Torso.Dra = value;
    			X0Y0_Torso.Hit = value;
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
    			return Torso_表示;
    		}
    		set
    		{
    			Torso_表示 = value;
    			筋肉_筋肉左_表示 = value;
    			筋肉_筋肉右_表示 = value;
    			獣性_獣毛左_表示 = value;
    			獣性_獣毛右_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return TorsoCD.不透明度;
    		}
    		set
    		{
    			TorsoCD.不透明度 = value;
    			筋肉_筋肉左CD.不透明度 = value;
    			筋肉_筋肉右CD.不透明度 = value;
    			獣性_獣毛左CD.不透明度 = value;
    			獣性_獣毛右CD.不透明度 = value;
    		}
    	}

    	public JointS Waist_接続点 => new JointS(Body, X0Y0_Torso, 4);

    	public JointS 肌_接続点 => new JointS(Body, X0Y0_Torso, 5);

    	public JointS 翼左_接続点 => new JointS(Body, X0Y0_Torso, 0);

    	public JointS 翼右_接続点 => new JointS(Body, X0Y0_Torso, 1);

    	public 四足胴(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 四足胴D e)
    	{
    		四足胴 四足胴2 = this;
    		ThisType = GetType();
    		Body = new VariantGrid(GlobalState.半身["四足胴"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_Torso = partGroup["胴"].ToPar();
    		PartGroup pars2 = partGroup["筋肉"].ToPars();
    		X0Y0_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
    		X0Y0_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
    		pars2 = partGroup["獣性"].ToPars();
    		X0Y0_獣性_獣毛左 = pars2["獣毛左"].ToPar();
    		X0Y0_獣性_獣毛右 = pars2["獣毛右"].ToPar();
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
    		Torso_表示 = e.Torso_表示;
    		筋肉_筋肉左_表示 = e.筋肉_筋肉左_表示;
    		筋肉_筋肉右_表示 = e.筋肉_筋肉右_表示;
    		獣性_獣毛左_表示 = e.獣性_獣毛左_表示;
    		獣性_獣毛右_表示 = e.獣性_獣毛右_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Element f;
    		if (e.Waist_接続.Count > 0)
    		{
    			Waist_接続 = e.Waist_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胴2;
    				f.ConnectionType = ConnectionInfo.四足胴_Waist_接続;
    				f.接続(四足胴2.Waist_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.肌_接続.Count > 0)
    		{
    			肌_接続 = e.肌_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胴2;
    				f.ConnectionType = ConnectionInfo.四足胴_肌_接続;
    				f.接続(四足胴2.肌_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼左_接続.Count > 0)
    		{
    			翼左_接続 = e.翼左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胴2;
    				f.ConnectionType = ConnectionInfo.四足胴_翼左_接続;
    				f.接続(四足胴2.翼左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼右_接続.Count > 0)
    		{
    			翼右_接続 = e.翼右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胴2;
    				f.ConnectionType = ConnectionInfo.四足胴_翼右_接続;
    				f.接続(四足胴2.翼右_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_TorsoCP = new ColorP(X0Y0_Torso, TorsoCD, DisUnit, abj: true);
    		X0Y0_筋肉_筋肉左CP = new ColorP(X0Y0_筋肉_筋肉左, 筋肉_筋肉左CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉右CP = new ColorP(X0Y0_筋肉_筋肉右, 筋肉_筋肉右CD, DisUnit, abj: false);
    		X0Y0_獣性_獣毛左CP = new ColorP(X0Y0_獣性_獣毛左, 獣性_獣毛左CD, DisUnit, abj: true);
    		X0Y0_獣性_獣毛右CP = new ColorP(X0Y0_獣性_獣毛右, 獣性_獣毛右CD, DisUnit, abj: true);
    		筋肉濃度 = e.筋肉濃度;
    		Intensity = e.濃度;
    		尺度YB = 0.96;
    	}

    	public override void 色更新()
    	{
    		X0Y0_TorsoCP.Update();
    		X0Y0_筋肉_筋肉左CP.Update();
    		X0Y0_筋肉_筋肉右CP.Update();
    		X0Y0_獣性_獣毛左CP.Update();
    		X0Y0_獣性_獣毛右CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		TorsoCD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		獣性_獣毛左CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛右CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    	}
    }
}
