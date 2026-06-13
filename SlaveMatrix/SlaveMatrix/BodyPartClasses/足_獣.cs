using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 足_獣 : 獣足
    {
    	public ShapePart X0Y0_足;

    	public ShapePart X0Y0_筋;

    	public ShapePart X0Y0_小指_指;

    	public ShapePart X0Y0_小指_爪;

    	public ShapePart X0Y0_小指_肉球;

    	public ShapePart X0Y0_薬指_指;

    	public ShapePart X0Y0_薬指_爪;

    	public ShapePart X0Y0_薬指_肉球;

    	public ShapePart X0Y0_中指_指;

    	public ShapePart X0Y0_中指_爪;

    	public ShapePart X0Y0_中指_肉球;

    	public ShapePart X0Y0_人指_指;

    	public ShapePart X0Y0_人指_爪;

    	public ShapePart X0Y0_人指_肉球;

    	public ShapePart X0Y0_肉球_肉球左;

    	public ShapePart X0Y0_肉球_肉球中;

    	public ShapePart X0Y0_肉球_肉球右;

    	public ShapePart X0Y0_脚輪_革;

    	public ShapePart X0Y0_脚輪_金具1;

    	public ShapePart X0Y0_脚輪_金具2;

    	public ShapePart X0Y0_脚輪_金具3;

    	public ShapePart X0Y0_脚輪_金具左;

    	public ShapePart X0Y0_脚輪_金具右;

    	public ColorD 足CD;

    	public ColorD 筋CD;

    	public ColorD 小指_指CD;

    	public ColorD 小指_爪CD;

    	public ColorD 小指_肉球CD;

    	public ColorD 薬指_指CD;

    	public ColorD 薬指_爪CD;

    	public ColorD 薬指_肉球CD;

    	public ColorD 中指_指CD;

    	public ColorD 中指_爪CD;

    	public ColorD 中指_肉球CD;

    	public ColorD 人指_指CD;

    	public ColorD 人指_爪CD;

    	public ColorD 人指_肉球CD;

    	public ColorD 肉球_肉球左CD;

    	public ColorD 肉球_肉球中CD;

    	public ColorD 肉球_肉球右CD;

    	public ColorD 脚輪_革CD;

    	public ColorD 脚輪_金具1CD;

    	public ColorD 脚輪_金具2CD;

    	public ColorD 脚輪_金具3CD;

    	public ColorD 脚輪_金具左CD;

    	public ColorD 脚輪_金具右CD;

    	public ColorP X0Y0_足CP;

    	public ColorP X0Y0_筋CP;

    	public ColorP X0Y0_小指_指CP;

    	public ColorP X0Y0_小指_爪CP;

    	public ColorP X0Y0_小指_肉球CP;

    	public ColorP X0Y0_薬指_指CP;

    	public ColorP X0Y0_薬指_爪CP;

    	public ColorP X0Y0_薬指_肉球CP;

    	public ColorP X0Y0_中指_指CP;

    	public ColorP X0Y0_中指_爪CP;

    	public ColorP X0Y0_中指_肉球CP;

    	public ColorP X0Y0_人指_指CP;

    	public ColorP X0Y0_人指_爪CP;

    	public ColorP X0Y0_人指_肉球CP;

    	public ColorP X0Y0_肉球_肉球左CP;

    	public ColorP X0Y0_肉球_肉球中CP;

    	public ColorP X0Y0_肉球_肉球右CP;

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

    	public bool 足_表示
    	{
    		get
    		{
    			return X0Y0_足.Dra;
    		}
    		set
    		{
    			X0Y0_足.Dra = value;
    			X0Y0_足.Hit = value;
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

    	public bool 小指_指_表示
    	{
    		get
    		{
    			return X0Y0_小指_指.Dra;
    		}
    		set
    		{
    			X0Y0_小指_指.Dra = value;
    			X0Y0_小指_指.Hit = value;
    		}
    	}

    	public bool 小指_爪_表示
    	{
    		get
    		{
    			return X0Y0_小指_爪.Dra;
    		}
    		set
    		{
    			X0Y0_小指_爪.Dra = value;
    			X0Y0_小指_爪.Hit = value;
    		}
    	}

    	public bool 小指_肉球_表示
    	{
    		get
    		{
    			return X0Y0_小指_肉球.Dra;
    		}
    		set
    		{
    			X0Y0_小指_肉球.Dra = value;
    			X0Y0_小指_肉球.Hit = value;
    		}
    	}

    	public bool 薬指_指_表示
    	{
    		get
    		{
    			return X0Y0_薬指_指.Dra;
    		}
    		set
    		{
    			X0Y0_薬指_指.Dra = value;
    			X0Y0_薬指_指.Hit = value;
    		}
    	}

    	public bool 薬指_爪_表示
    	{
    		get
    		{
    			return X0Y0_薬指_爪.Dra;
    		}
    		set
    		{
    			X0Y0_薬指_爪.Dra = value;
    			X0Y0_薬指_爪.Hit = value;
    		}
    	}

    	public bool 薬指_肉球_表示
    	{
    		get
    		{
    			return X0Y0_薬指_肉球.Dra;
    		}
    		set
    		{
    			X0Y0_薬指_肉球.Dra = value;
    			X0Y0_薬指_肉球.Hit = value;
    		}
    	}

    	public bool 中指_指_表示
    	{
    		get
    		{
    			return X0Y0_中指_指.Dra;
    		}
    		set
    		{
    			X0Y0_中指_指.Dra = value;
    			X0Y0_中指_指.Hit = value;
    		}
    	}

    	public bool 中指_爪_表示
    	{
    		get
    		{
    			return X0Y0_中指_爪.Dra;
    		}
    		set
    		{
    			X0Y0_中指_爪.Dra = value;
    			X0Y0_中指_爪.Hit = value;
    		}
    	}

    	public bool 中指_肉球_表示
    	{
    		get
    		{
    			return X0Y0_中指_肉球.Dra;
    		}
    		set
    		{
    			X0Y0_中指_肉球.Dra = value;
    			X0Y0_中指_肉球.Hit = value;
    		}
    	}

    	public bool 人指_指_表示
    	{
    		get
    		{
    			return X0Y0_人指_指.Dra;
    		}
    		set
    		{
    			X0Y0_人指_指.Dra = value;
    			X0Y0_人指_指.Hit = value;
    		}
    	}

    	public bool 人指_爪_表示
    	{
    		get
    		{
    			return X0Y0_人指_爪.Dra;
    		}
    		set
    		{
    			X0Y0_人指_爪.Dra = value;
    			X0Y0_人指_爪.Hit = value;
    		}
    	}

    	public bool 人指_肉球_表示
    	{
    		get
    		{
    			return X0Y0_人指_肉球.Dra;
    		}
    		set
    		{
    			X0Y0_人指_肉球.Dra = value;
    			X0Y0_人指_肉球.Hit = value;
    		}
    	}

    	public bool 肉球_肉球左_表示
    	{
    		get
    		{
    			return X0Y0_肉球_肉球左.Dra;
    		}
    		set
    		{
    			X0Y0_肉球_肉球左.Dra = value;
    			X0Y0_肉球_肉球左.Hit = value;
    		}
    	}

    	public bool 肉球_肉球中_表示
    	{
    		get
    		{
    			return X0Y0_肉球_肉球中.Dra;
    		}
    		set
    		{
    			X0Y0_肉球_肉球中.Dra = value;
    			X0Y0_肉球_肉球中.Hit = value;
    		}
    	}

    	public bool 肉球_肉球右_表示
    	{
    		get
    		{
    			return X0Y0_肉球_肉球右.Dra;
    		}
    		set
    		{
    			X0Y0_肉球_肉球右.Dra = value;
    			X0Y0_肉球_肉球右.Hit = value;
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
    			return 足_表示;
    		}
    		set
    		{
    			足_表示 = value;
    			筋_表示 = value;
    			小指_指_表示 = value;
    			小指_爪_表示 = value;
    			小指_肉球_表示 = value;
    			薬指_指_表示 = value;
    			薬指_爪_表示 = value;
    			薬指_肉球_表示 = value;
    			中指_指_表示 = value;
    			中指_爪_表示 = value;
    			中指_肉球_表示 = value;
    			人指_指_表示 = value;
    			人指_爪_表示 = value;
    			人指_肉球_表示 = value;
    			肉球_肉球左_表示 = value;
    			肉球_肉球中_表示 = value;
    			肉球_肉球右_表示 = value;
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
    			return 足CD.不透明度;
    		}
    		set
    		{
    			足CD.不透明度 = value;
    			筋CD.不透明度 = value;
    			小指_指CD.不透明度 = value;
    			小指_爪CD.不透明度 = value;
    			小指_肉球CD.不透明度 = value;
    			薬指_指CD.不透明度 = value;
    			薬指_爪CD.不透明度 = value;
    			薬指_肉球CD.不透明度 = value;
    			中指_指CD.不透明度 = value;
    			中指_爪CD.不透明度 = value;
    			中指_肉球CD.不透明度 = value;
    			人指_指CD.不透明度 = value;
    			人指_爪CD.不透明度 = value;
    			人指_肉球CD.不透明度 = value;
    			肉球_肉球左CD.不透明度 = value;
    			肉球_肉球中CD.不透明度 = value;
    			肉球_肉球右CD.不透明度 = value;
    			脚輪_革CD.不透明度 = value;
    			脚輪_金具1CD.不透明度 = value;
    			脚輪_金具2CD.不透明度 = value;
    			脚輪_金具3CD.不透明度 = value;
    			脚輪_金具左CD.不透明度 = value;
    			脚輪_金具右CD.不透明度 = value;
    		}
    	}

    	public JointS 鎖1_接続点 => new JointS(Body, X0Y0_脚輪_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(Body, X0Y0_脚輪_金具右, 0);

    	public 足_獣(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 足_獣D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "獣";
    		dif.Add(new Pars(Sta.脚左["四足足"][0][0]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_足 = pars["足"].ToPar();
    		X0Y0_筋 = pars["筋"].ToPar();
    		Pars pars2 = pars["小指"].ToPars();
    		X0Y0_小指_指 = pars2["指"].ToPar();
    		X0Y0_小指_爪 = pars2["爪"].ToPar();
    		X0Y0_小指_肉球 = pars2["肉球"].ToPar();
    		pars2 = pars["薬指"].ToPars();
    		X0Y0_薬指_指 = pars2["指"].ToPar();
    		X0Y0_薬指_爪 = pars2["爪"].ToPar();
    		X0Y0_薬指_肉球 = pars2["肉球"].ToPar();
    		pars2 = pars["中指"].ToPars();
    		X0Y0_中指_指 = pars2["指"].ToPar();
    		X0Y0_中指_爪 = pars2["爪"].ToPar();
    		X0Y0_中指_肉球 = pars2["肉球"].ToPar();
    		pars2 = pars["人指"].ToPars();
    		X0Y0_人指_指 = pars2["指"].ToPar();
    		X0Y0_人指_爪 = pars2["爪"].ToPar();
    		X0Y0_人指_肉球 = pars2["肉球"].ToPar();
    		pars2 = pars["肉球"].ToPars();
    		X0Y0_肉球_肉球左 = pars2["肉球左"].ToPar();
    		X0Y0_肉球_肉球中 = pars2["肉球中"].ToPar();
    		X0Y0_肉球_肉球右 = pars2["肉球右"].ToPar();
    		pars2 = pars["脚輪"].ToPars();
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
    		足_表示 = e.足_表示;
    		筋_表示 = e.筋_表示;
    		小指_指_表示 = e.小指_指_表示;
    		小指_爪_表示 = e.小指_爪_表示;
    		小指_肉球_表示 = e.小指_肉球_表示;
    		薬指_指_表示 = e.薬指_指_表示;
    		薬指_爪_表示 = e.薬指_爪_表示;
    		薬指_肉球_表示 = e.薬指_肉球_表示;
    		中指_指_表示 = e.中指_指_表示;
    		中指_爪_表示 = e.中指_爪_表示;
    		中指_肉球_表示 = e.中指_肉球_表示;
    		人指_指_表示 = e.人指_指_表示;
    		人指_爪_表示 = e.人指_爪_表示;
    		人指_肉球_表示 = e.人指_肉球_表示;
    		肉球_肉球左_表示 = e.肉球_肉球左_表示;
    		肉球_肉球中_表示 = e.肉球_肉球中_表示;
    		肉球_肉球右_表示 = e.肉球_肉球右_表示;
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
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_足CP = new ColorP(X0Y0_足, 足CD, DisUnit, abj: true);
    		X0Y0_筋CP = new ColorP(X0Y0_筋, 筋CD, DisUnit, abj: false);
    		X0Y0_小指_指CP = new ColorP(X0Y0_小指_指, 小指_指CD, DisUnit, abj: true);
    		X0Y0_小指_爪CP = new ColorP(X0Y0_小指_爪, 小指_爪CD, DisUnit, abj: true);
    		X0Y0_小指_肉球CP = new ColorP(X0Y0_小指_肉球, 小指_肉球CD, DisUnit, abj: true);
    		X0Y0_薬指_指CP = new ColorP(X0Y0_薬指_指, 薬指_指CD, DisUnit, abj: true);
    		X0Y0_薬指_爪CP = new ColorP(X0Y0_薬指_爪, 薬指_爪CD, DisUnit, abj: true);
    		X0Y0_薬指_肉球CP = new ColorP(X0Y0_薬指_肉球, 薬指_肉球CD, DisUnit, abj: true);
    		X0Y0_中指_指CP = new ColorP(X0Y0_中指_指, 中指_指CD, DisUnit, abj: true);
    		X0Y0_中指_爪CP = new ColorP(X0Y0_中指_爪, 中指_爪CD, DisUnit, abj: true);
    		X0Y0_中指_肉球CP = new ColorP(X0Y0_中指_肉球, 中指_肉球CD, DisUnit, abj: true);
    		X0Y0_人指_指CP = new ColorP(X0Y0_人指_指, 人指_指CD, DisUnit, abj: true);
    		X0Y0_人指_爪CP = new ColorP(X0Y0_人指_爪, 人指_爪CD, DisUnit, abj: true);
    		X0Y0_人指_肉球CP = new ColorP(X0Y0_人指_肉球, 人指_肉球CD, DisUnit, abj: true);
    		X0Y0_肉球_肉球左CP = new ColorP(X0Y0_肉球_肉球左, 肉球_肉球左CD, DisUnit, abj: true);
    		X0Y0_肉球_肉球中CP = new ColorP(X0Y0_肉球_肉球中, 肉球_肉球中CD, DisUnit, abj: true);
    		X0Y0_肉球_肉球右CP = new ColorP(X0Y0_肉球_肉球右, 肉球_肉球右CD, DisUnit, abj: true);
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
    		X0Y0_足.AngleBase = num * -40.0;
    		X0Y0_小指_指.AngleBase = num * 22.0;
    		X0Y0_薬指_指.AngleBase = num * 22.0;
    		X0Y0_中指_指.AngleBase = num * 19.0;
    		X0Y0_人指_指.AngleBase = num * 14.0;
    		X0Y0_肉球_肉球中.AngleBase = num * 16.0;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		X0Y0_足CP.Update();
    		X0Y0_筋CP.Update();
    		X0Y0_小指_指CP.Update();
    		X0Y0_小指_爪CP.Update();
    		X0Y0_小指_肉球CP.Update();
    		X0Y0_薬指_指CP.Update();
    		X0Y0_薬指_爪CP.Update();
    		X0Y0_薬指_肉球CP.Update();
    		X0Y0_中指_指CP.Update();
    		X0Y0_中指_爪CP.Update();
    		X0Y0_中指_肉球CP.Update();
    		X0Y0_人指_指CP.Update();
    		X0Y0_人指_爪CP.Update();
    		X0Y0_人指_肉球CP.Update();
    		X0Y0_肉球_肉球左CP.Update();
    		X0Y0_肉球_肉球中CP.Update();
    		X0Y0_肉球_肉球右CP.Update();
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
    		足CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		小指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		小指_肉球CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		薬指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		薬指_肉球CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		中指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		中指_肉球CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		人指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		人指_肉球CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		肉球_肉球左CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		肉球_肉球中CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		肉球_肉球右CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
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
