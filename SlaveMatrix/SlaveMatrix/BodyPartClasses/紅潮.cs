using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 紅潮 : Ele
    {
    	public Par X0Y0_紅潮0;

    	public Par X0Y0_紅潮1;

    	public Par X0Y0_紅潮右;

    	public Par X0Y0_紅潮左;

    	public Par X0Y0_紅潮線左;

    	public Par X0Y0_紅潮線右;

    	public Par X0Y0_紅潮弱左;

    	public Par X0Y0_紅潮弱右;

    	public Par X0Y0_紅潮線弱左;

    	public Par X0Y0_紅潮線弱右;

    	public ColorD 紅潮0CD;

    	public ColorD 紅潮1CD;

    	public ColorD 紅潮右CD;

    	public ColorD 紅潮左CD;

    	public ColorD 紅潮線左CD;

    	public ColorD 紅潮線右CD;

    	public ColorD 紅潮弱左CD;

    	public ColorD 紅潮弱右CD;

    	public ColorD 紅潮線弱左CD;

    	public ColorD 紅潮線弱右CD;

    	public ColorP X0Y0_紅潮0CP;

    	public ColorP X0Y0_紅潮1CP;

    	public ColorP X0Y0_紅潮右CP;

    	public ColorP X0Y0_紅潮左CP;

    	public ColorP X0Y0_紅潮線左CP;

    	public ColorP X0Y0_紅潮線右CP;

    	public ColorP X0Y0_紅潮弱左CP;

    	public ColorP X0Y0_紅潮弱右CP;

    	public ColorP X0Y0_紅潮線弱左CP;

    	public ColorP X0Y0_紅潮線弱右CP;

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

    	public bool 紅潮0_表示
    	{
    		get
    		{
    			return X0Y0_紅潮0.Dra;
    		}
    		set
    		{
    			X0Y0_紅潮0.Dra = value;
    			X0Y0_紅潮0.Hit = value;
    		}
    	}

    	public bool 紅潮1_表示
    	{
    		get
    		{
    			return X0Y0_紅潮1.Dra;
    		}
    		set
    		{
    			X0Y0_紅潮1.Dra = value;
    			X0Y0_紅潮1.Hit = value;
    		}
    	}

    	public bool 紅潮右_表示
    	{
    		get
    		{
    			return X0Y0_紅潮右.Dra;
    		}
    		set
    		{
    			X0Y0_紅潮右.Dra = value;
    			X0Y0_紅潮右.Hit = value;
    		}
    	}

    	public bool 紅潮左_表示
    	{
    		get
    		{
    			return X0Y0_紅潮左.Dra;
    		}
    		set
    		{
    			X0Y0_紅潮左.Dra = value;
    			X0Y0_紅潮左.Hit = value;
    		}
    	}

    	public bool 紅潮線左_表示
    	{
    		get
    		{
    			return X0Y0_紅潮線左.Dra;
    		}
    		set
    		{
    			X0Y0_紅潮線左.Dra = value;
    			X0Y0_紅潮線左.Hit = value;
    		}
    	}

    	public bool 紅潮線右_表示
    	{
    		get
    		{
    			return X0Y0_紅潮線右.Dra;
    		}
    		set
    		{
    			X0Y0_紅潮線右.Dra = value;
    			X0Y0_紅潮線右.Hit = value;
    		}
    	}

    	public bool 紅潮弱左_表示
    	{
    		get
    		{
    			return X0Y0_紅潮弱左.Dra;
    		}
    		set
    		{
    			X0Y0_紅潮弱左.Dra = value;
    			X0Y0_紅潮弱左.Hit = value;
    		}
    	}

    	public bool 紅潮弱右_表示
    	{
    		get
    		{
    			return X0Y0_紅潮弱右.Dra;
    		}
    		set
    		{
    			X0Y0_紅潮弱右.Dra = value;
    			X0Y0_紅潮弱右.Hit = value;
    		}
    	}

    	public bool 紅潮線弱左_表示
    	{
    		get
    		{
    			return X0Y0_紅潮線弱左.Dra;
    		}
    		set
    		{
    			X0Y0_紅潮線弱左.Dra = value;
    			X0Y0_紅潮線弱左.Hit = value;
    		}
    	}

    	public bool 紅潮線弱右_表示
    	{
    		get
    		{
    			return X0Y0_紅潮線弱右.Dra;
    		}
    		set
    		{
    			X0Y0_紅潮線弱右.Dra = value;
    			X0Y0_紅潮線弱右.Hit = value;
    		}
    	}

    	public bool 紅潮表示
    	{
    		get
    		{
    			return 紅潮0_表示;
    		}
    		set
    		{
    			紅潮0_表示 = value;
    			紅潮1_表示 = value;
    		}
    	}

    	public bool 紅潮左右表示
    	{
    		get
    		{
    			return 紅潮右_表示;
    		}
    		set
    		{
    			紅潮右_表示 = value;
    			紅潮左_表示 = value;
    		}
    	}

    	public bool 紅潮線左右表示
    	{
    		get
    		{
    			return 紅潮線左_表示;
    		}
    		set
    		{
    			紅潮線左_表示 = value;
    			紅潮線右_表示 = value;
    		}
    	}

    	public bool 紅潮弱左右表示
    	{
    		get
    		{
    			return 紅潮弱左_表示;
    		}
    		set
    		{
    			紅潮弱左_表示 = value;
    			紅潮弱右_表示 = value;
    		}
    	}

    	public bool 紅潮線弱左右表示
    	{
    		get
    		{
    			return 紅潮線弱左_表示;
    		}
    		set
    		{
    			紅潮線弱左_表示 = value;
    			紅潮線弱右_表示 = value;
    		}
    	}

    	public double 紅潮濃度
    	{
    		get
    		{
    			return 紅潮0CD.不透明度;
    		}
    		set
    		{
    			紅潮0CD.不透明度 = value;
    			紅潮1CD.不透明度 = value;
    		}
    	}

    	public double 紅潮左右濃度
    	{
    		get
    		{
    			return 紅潮右CD.不透明度;
    		}
    		set
    		{
    			紅潮右CD.不透明度 = value;
    			紅潮左CD.不透明度 = value;
    		}
    	}

    	public double 紅潮線左右濃度
    	{
    		get
    		{
    			return 紅潮線左CD.不透明度;
    		}
    		set
    		{
    			紅潮線左CD.不透明度 = value;
    			紅潮線右CD.不透明度 = value;
    		}
    	}

    	public double 紅潮弱左右濃度
    	{
    		get
    		{
    			return 紅潮弱左CD.不透明度;
    		}
    		set
    		{
    			紅潮弱左CD.不透明度 = value;
    			紅潮弱右CD.不透明度 = value;
    		}
    	}

    	public double 紅潮線弱左右濃度
    	{
    		get
    		{
    			return 紅潮線弱左CD.不透明度;
    		}
    		set
    		{
    			紅潮線弱左CD.不透明度 = value;
    			紅潮線弱右CD.不透明度 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 紅潮0_表示;
    		}
    		set
    		{
    			紅潮0_表示 = value;
    			紅潮1_表示 = value;
    			紅潮右_表示 = value;
    			紅潮左_表示 = value;
    			紅潮線左_表示 = value;
    			紅潮線右_表示 = value;
    			紅潮弱左_表示 = value;
    			紅潮弱右_表示 = value;
    			紅潮線弱左_表示 = value;
    			紅潮線弱右_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 紅潮0CD.不透明度;
    		}
    		set
    		{
    			紅潮0CD.不透明度 = value;
    			紅潮1CD.不透明度 = value;
    			紅潮右CD.不透明度 = value;
    			紅潮左CD.不透明度 = value;
    			紅潮線左CD.不透明度 = value;
    			紅潮線右CD.不透明度 = value;
    			紅潮弱左CD.不透明度 = value;
    			紅潮弱右CD.不透明度 = value;
    			紅潮線弱左CD.不透明度 = value;
    			紅潮線弱右CD.不透明度 = value;
    		}
    	}

    	public 紅潮(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 紅潮D e)
    	{
    		ThisType = GetType();
    		本体 = new Difs(Sta.胴体["紅潮"]);
    		Pars pars = 本体[0][0];
    		X0Y0_紅潮0 = pars["紅潮0"].ToPar();
    		X0Y0_紅潮1 = pars["紅潮1"].ToPar();
    		X0Y0_紅潮右 = pars["紅潮右"].ToPar();
    		X0Y0_紅潮左 = pars["紅潮左"].ToPar();
    		X0Y0_紅潮線左 = pars["紅潮線左"].ToPar();
    		X0Y0_紅潮線右 = pars["紅潮線右"].ToPar();
    		X0Y0_紅潮弱左 = pars["紅潮弱左"].ToPar();
    		X0Y0_紅潮弱右 = pars["紅潮弱右"].ToPar();
    		X0Y0_紅潮線弱左 = pars["紅潮線弱左"].ToPar();
    		X0Y0_紅潮線弱右 = pars["紅潮線弱右"].ToPar();
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
    		紅潮0_表示 = e.紅潮0_表示;
    		紅潮1_表示 = e.紅潮1_表示;
    		紅潮右_表示 = e.紅潮右_表示;
    		紅潮左_表示 = e.紅潮左_表示;
    		紅潮線左_表示 = e.紅潮線左_表示;
    		紅潮線右_表示 = e.紅潮線右_表示;
    		紅潮弱左_表示 = e.紅潮弱左_表示;
    		紅潮弱右_表示 = e.紅潮弱右_表示;
    		紅潮線弱左_表示 = e.紅潮線弱左_表示;
    		紅潮線弱右_表示 = e.紅潮線弱右_表示;
    		紅潮表示 = e.紅潮表示;
    		紅潮左右表示 = e.紅潮左右表示;
    		紅潮線左右表示 = e.紅潮線左右表示;
    		紅潮弱左右表示 = e.紅潮弱左右表示;
    		紅潮線弱左右表示 = e.紅潮線弱左右表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_紅潮0CP = new ColorP(X0Y0_紅潮0, 紅潮0CD, DisUnit, abj: true);
    		X0Y0_紅潮1CP = new ColorP(X0Y0_紅潮1, 紅潮1CD, DisUnit, abj: true);
    		X0Y0_紅潮右CP = new ColorP(X0Y0_紅潮右, 紅潮右CD, DisUnit, abj: true);
    		X0Y0_紅潮左CP = new ColorP(X0Y0_紅潮左, 紅潮左CD, DisUnit, abj: true);
    		X0Y0_紅潮線左CP = new ColorP(X0Y0_紅潮線左, 紅潮線左CD, DisUnit, abj: true);
    		X0Y0_紅潮線右CP = new ColorP(X0Y0_紅潮線右, 紅潮線右CD, DisUnit, abj: true);
    		X0Y0_紅潮弱左CP = new ColorP(X0Y0_紅潮弱左, 紅潮弱左CD, DisUnit, abj: true);
    		X0Y0_紅潮弱右CP = new ColorP(X0Y0_紅潮弱右, 紅潮弱右CD, DisUnit, abj: true);
    		X0Y0_紅潮線弱左CP = new ColorP(X0Y0_紅潮線弱左, 紅潮線弱左CD, DisUnit, abj: true);
    		X0Y0_紅潮線弱右CP = new ColorP(X0Y0_紅潮線弱右, 紅潮線弱右CD, DisUnit, abj: true);
    		紅潮濃度 = e.紅潮濃度;
    		紅潮左右濃度 = e.紅潮左右濃度;
    		紅潮線左右濃度 = e.紅潮線左右濃度;
    		紅潮弱左右濃度 = e.紅潮弱左右濃度;
    		紅潮線弱左右濃度 = e.紅潮線弱左右濃度;
    		濃度 = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_紅潮0CP.Update();
    		X0Y0_紅潮1CP.Update();
    		X0Y0_紅潮右CP.Update();
    		X0Y0_紅潮左CP.Update();
    		X0Y0_紅潮線左CP.Update();
    		X0Y0_紅潮線右CP.Update();
    		X0Y0_紅潮弱左CP.Update();
    		X0Y0_紅潮弱右CP.Update();
    		X0Y0_紅潮線弱左CP.Update();
    		X0Y0_紅潮線弱右CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		Color Col = Color.FromArgb((int)((double)(int)体配色.紅潮.Col1.A * 0.7), 体配色.紅潮.Col1);
    		紅潮0CD = new ColorD();
    		紅潮0CD.線 = SlaveMatrix.Col.Empty;
    		紅潮0CD.色 = new Color2(ref Col, ref SlaveMatrix.Col.Empty);
    		紅潮1CD = new ColorD(ref SlaveMatrix.Col.Empty, ref 体配色.紅潮);
    		紅潮右CD = new ColorD(ref SlaveMatrix.Col.Empty, ref 体配色.紅潮);
    		紅潮左CD = new ColorD(ref SlaveMatrix.Col.Empty, ref 体配色.紅潮);
    		紅潮線左CD = new ColorD(ref 体配色.紅潮線, ref 体配色.紅潮);
    		紅潮線右CD = new ColorD(ref 体配色.紅潮線, ref 体配色.紅潮);
    		紅潮弱左CD = new ColorD(ref SlaveMatrix.Col.Empty, ref 体配色.紅潮);
    		紅潮弱右CD = new ColorD(ref SlaveMatrix.Col.Empty, ref 体配色.紅潮);
    		紅潮線弱左CD = new ColorD(ref 体配色.紅潮線, ref 体配色.紅潮);
    		紅潮線弱右CD = new ColorD(ref 体配色.紅潮線, ref 体配色.紅潮);
    	}
    }
}
