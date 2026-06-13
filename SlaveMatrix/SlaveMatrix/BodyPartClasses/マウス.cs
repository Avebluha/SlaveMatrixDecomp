using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class マウス : Ele
    {
    	public Par X0Y0_上唇;

    	public Par X0Y0_下唇;

    	public Par X1Y0_上唇;

    	public Par X1Y0_下唇;

    	public Par X2Y0_舌;

    	public Par X2Y0_上唇;

    	public Par X2Y0_下唇;

    	public Par X3Y0_舌;

    	public Par X3Y0_上唇;

    	public Par X3Y0_下唇;

    	public Par X3Y1_舌;

    	public Par X3Y1_上唇;

    	public Par X3Y1_下唇;

    	public Par X3Y2_舌;

    	public Par X3Y2_上唇;

    	public Par X3Y2_下唇;

    	public Par X3Y3_舌;

    	public Par X3Y3_上唇;

    	public Par X3Y3_下唇;

    	public Par X3Y4_舌;

    	public Par X3Y4_上唇;

    	public Par X3Y4_下唇;

    	public Par X4Y0_舌;

    	public Par X4Y0_上唇;

    	public Par X4Y0_下唇;

    	public Par X4Y1_舌;

    	public Par X4Y1_上唇;

    	public Par X4Y1_下唇;

    	public Par X4Y2_舌;

    	public Par X4Y2_上唇;

    	public Par X4Y2_下唇;

    	public Par X4Y3_舌;

    	public Par X4Y3_上唇;

    	public Par X4Y3_下唇;

    	public Par X4Y4_舌;

    	public Par X4Y4_上唇;

    	public Par X4Y4_下唇;

    	public ColorD 舌CD;

    	public ColorD 上唇CD;

    	public ColorD 下唇CD;

    	public ColorP X0Y0_上唇CP;

    	public ColorP X0Y0_下唇CP;

    	public ColorP X1Y0_上唇CP;

    	public ColorP X1Y0_下唇CP;

    	public ColorP X2Y0_舌CP;

    	public ColorP X2Y0_上唇CP;

    	public ColorP X2Y0_下唇CP;

    	public ColorP X3Y0_舌CP;

    	public ColorP X3Y0_上唇CP;

    	public ColorP X3Y0_下唇CP;

    	public ColorP X3Y1_舌CP;

    	public ColorP X3Y1_上唇CP;

    	public ColorP X3Y1_下唇CP;

    	public ColorP X3Y2_舌CP;

    	public ColorP X3Y2_上唇CP;

    	public ColorP X3Y2_下唇CP;

    	public ColorP X3Y3_舌CP;

    	public ColorP X3Y3_上唇CP;

    	public ColorP X3Y3_下唇CP;

    	public ColorP X3Y4_舌CP;

    	public ColorP X3Y4_上唇CP;

    	public ColorP X3Y4_下唇CP;

    	public ColorP X4Y0_舌CP;

    	public ColorP X4Y0_上唇CP;

    	public ColorP X4Y0_下唇CP;

    	public ColorP X4Y1_舌CP;

    	public ColorP X4Y1_上唇CP;

    	public ColorP X4Y1_下唇CP;

    	public ColorP X4Y2_舌CP;

    	public ColorP X4Y2_上唇CP;

    	public ColorP X4Y2_下唇CP;

    	public ColorP X4Y3_舌CP;

    	public ColorP X4Y3_上唇CP;

    	public ColorP X4Y3_下唇CP;

    	public ColorP X4Y4_舌CP;

    	public ColorP X4Y4_上唇CP;

    	public ColorP X4Y4_下唇CP;

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

    	public bool 上唇_表示
    	{
    		get
    		{
    			return X0Y0_上唇.Dra;
    		}
    		set
    		{
    			X0Y0_上唇.Dra = value;
    			X1Y0_上唇.Dra = value;
    			X2Y0_上唇.Dra = value;
    			X3Y0_上唇.Dra = value;
    			X3Y1_上唇.Dra = value;
    			X3Y2_上唇.Dra = value;
    			X3Y3_上唇.Dra = value;
    			X3Y4_上唇.Dra = value;
    			X4Y0_上唇.Dra = value;
    			X4Y1_上唇.Dra = value;
    			X4Y2_上唇.Dra = value;
    			X4Y3_上唇.Dra = value;
    			X4Y4_上唇.Dra = value;
    			X0Y0_上唇.Hit = value;
    			X1Y0_上唇.Hit = value;
    			X2Y0_上唇.Hit = value;
    			X3Y0_上唇.Hit = value;
    			X3Y1_上唇.Hit = value;
    			X3Y2_上唇.Hit = value;
    			X3Y3_上唇.Hit = value;
    			X3Y4_上唇.Hit = value;
    			X4Y0_上唇.Hit = value;
    			X4Y1_上唇.Hit = value;
    			X4Y2_上唇.Hit = value;
    			X4Y3_上唇.Hit = value;
    			X4Y4_上唇.Hit = value;
    		}
    	}

    	public bool 下唇_表示
    	{
    		get
    		{
    			return X0Y0_下唇.Dra;
    		}
    		set
    		{
    			X0Y0_下唇.Dra = value;
    			X1Y0_下唇.Dra = value;
    			X2Y0_下唇.Dra = value;
    			X3Y0_下唇.Dra = value;
    			X3Y1_下唇.Dra = value;
    			X3Y2_下唇.Dra = value;
    			X3Y3_下唇.Dra = value;
    			X3Y4_下唇.Dra = value;
    			X4Y0_下唇.Dra = value;
    			X4Y1_下唇.Dra = value;
    			X4Y2_下唇.Dra = value;
    			X4Y3_下唇.Dra = value;
    			X4Y4_下唇.Dra = value;
    			X0Y0_下唇.Hit = value;
    			X1Y0_下唇.Hit = value;
    			X2Y0_下唇.Hit = value;
    			X3Y0_下唇.Hit = value;
    			X3Y1_下唇.Hit = value;
    			X3Y2_下唇.Hit = value;
    			X3Y3_下唇.Hit = value;
    			X3Y4_下唇.Hit = value;
    			X4Y0_下唇.Hit = value;
    			X4Y1_下唇.Hit = value;
    			X4Y2_下唇.Hit = value;
    			X4Y3_下唇.Hit = value;
    			X4Y4_下唇.Hit = value;
    		}
    	}

    	public bool 舌_表示
    	{
    		get
    		{
    			return X2Y0_舌.Dra;
    		}
    		set
    		{
    			X2Y0_舌.Dra = value;
    			X3Y0_舌.Dra = value;
    			X3Y1_舌.Dra = value;
    			X3Y2_舌.Dra = value;
    			X3Y3_舌.Dra = value;
    			X3Y4_舌.Dra = value;
    			X4Y0_舌.Dra = value;
    			X4Y1_舌.Dra = value;
    			X4Y2_舌.Dra = value;
    			X4Y3_舌.Dra = value;
    			X4Y4_舌.Dra = value;
    			X2Y0_舌.Hit = value;
    			X3Y0_舌.Hit = value;
    			X3Y1_舌.Hit = value;
    			X3Y2_舌.Hit = value;
    			X3Y3_舌.Hit = value;
    			X3Y4_舌.Hit = value;
    			X4Y0_舌.Hit = value;
    			X4Y1_舌.Hit = value;
    			X4Y2_舌.Hit = value;
    			X4Y3_舌.Hit = value;
    			X4Y4_舌.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 上唇_表示;
    		}
    		set
    		{
    			上唇_表示 = value;
    			下唇_表示 = value;
    			舌_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 舌CD.不透明度;
    		}
    		set
    		{
    			舌CD.不透明度 = value;
    			上唇CD.不透明度 = value;
    			下唇CD.不透明度 = value;
    		}
    	}

    	public マウス(double DisUnit, 配色指定 配色指定, 主人公配色 体配色, ModeEventDispatcher Med, マウスD e)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.カーソル["マウス"]);
    		Pars pars = Body[0][0];
    		X0Y0_上唇 = pars["上唇"].ToPar();
    		X0Y0_下唇 = pars["下唇"].ToPar();
    		pars = Body[1][0];
    		X1Y0_上唇 = pars["上唇"].ToPar();
    		X1Y0_下唇 = pars["下唇"].ToPar();
    		pars = Body[2][0];
    		X2Y0_舌 = pars["舌"].ToPar();
    		X2Y0_上唇 = pars["上唇"].ToPar();
    		X2Y0_下唇 = pars["下唇"].ToPar();
    		pars = Body[3][0];
    		X3Y0_舌 = pars["舌"].ToPar();
    		X3Y0_上唇 = pars["上唇"].ToPar();
    		X3Y0_下唇 = pars["下唇"].ToPar();
    		pars = Body[3][1];
    		X3Y1_舌 = pars["舌"].ToPar();
    		X3Y1_上唇 = pars["上唇"].ToPar();
    		X3Y1_下唇 = pars["下唇"].ToPar();
    		pars = Body[3][2];
    		X3Y2_舌 = pars["舌"].ToPar();
    		X3Y2_上唇 = pars["上唇"].ToPar();
    		X3Y2_下唇 = pars["下唇"].ToPar();
    		pars = Body[3][3];
    		X3Y3_舌 = pars["舌"].ToPar();
    		X3Y3_上唇 = pars["上唇"].ToPar();
    		X3Y3_下唇 = pars["下唇"].ToPar();
    		pars = Body[3][4];
    		X3Y4_舌 = pars["舌"].ToPar();
    		X3Y4_上唇 = pars["上唇"].ToPar();
    		X3Y4_下唇 = pars["下唇"].ToPar();
    		pars = Body[4][0];
    		X4Y0_舌 = pars["舌"].ToPar();
    		X4Y0_上唇 = pars["上唇"].ToPar();
    		X4Y0_下唇 = pars["下唇"].ToPar();
    		pars = Body[4][1];
    		X4Y1_舌 = pars["舌"].ToPar();
    		X4Y1_上唇 = pars["上唇"].ToPar();
    		X4Y1_下唇 = pars["下唇"].ToPar();
    		pars = Body[4][2];
    		X4Y2_舌 = pars["舌"].ToPar();
    		X4Y2_上唇 = pars["上唇"].ToPar();
    		X4Y2_下唇 = pars["下唇"].ToPar();
    		pars = Body[4][3];
    		X4Y3_舌 = pars["舌"].ToPar();
    		X4Y3_上唇 = pars["上唇"].ToPar();
    		X4Y3_下唇 = pars["下唇"].ToPar();
    		pars = Body[4][4];
    		X4Y4_舌 = pars["舌"].ToPar();
    		X4Y4_上唇 = pars["上唇"].ToPar();
    		X4Y4_下唇 = pars["下唇"].ToPar();
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
    		上唇_表示 = e.上唇_表示;
    		下唇_表示 = e.下唇_表示;
    		舌_表示 = e.舌_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_上唇CP = new ColorP(X0Y0_上唇, 上唇CD, DisUnit, abj: true);
    		X0Y0_下唇CP = new ColorP(X0Y0_下唇, 下唇CD, DisUnit, abj: true);
    		X1Y0_上唇CP = new ColorP(X1Y0_上唇, 上唇CD, DisUnit, abj: true);
    		X1Y0_下唇CP = new ColorP(X1Y0_下唇, 下唇CD, DisUnit, abj: true);
    		X2Y0_舌CP = new ColorP(X2Y0_舌, 舌CD, DisUnit, abj: true);
    		X2Y0_上唇CP = new ColorP(X2Y0_上唇, 上唇CD, DisUnit, abj: true);
    		X2Y0_下唇CP = new ColorP(X2Y0_下唇, 下唇CD, DisUnit, abj: true);
    		X3Y0_舌CP = new ColorP(X3Y0_舌, 舌CD, DisUnit, abj: true);
    		X3Y0_上唇CP = new ColorP(X3Y0_上唇, 上唇CD, DisUnit, abj: true);
    		X3Y0_下唇CP = new ColorP(X3Y0_下唇, 下唇CD, DisUnit, abj: true);
    		X3Y1_舌CP = new ColorP(X3Y1_舌, 舌CD, DisUnit, abj: true);
    		X3Y1_上唇CP = new ColorP(X3Y1_上唇, 上唇CD, DisUnit, abj: true);
    		X3Y1_下唇CP = new ColorP(X3Y1_下唇, 下唇CD, DisUnit, abj: true);
    		X3Y2_舌CP = new ColorP(X3Y2_舌, 舌CD, DisUnit, abj: true);
    		X3Y2_上唇CP = new ColorP(X3Y2_上唇, 上唇CD, DisUnit, abj: true);
    		X3Y2_下唇CP = new ColorP(X3Y2_下唇, 下唇CD, DisUnit, abj: true);
    		X3Y3_舌CP = new ColorP(X3Y3_舌, 舌CD, DisUnit, abj: true);
    		X3Y3_上唇CP = new ColorP(X3Y3_上唇, 上唇CD, DisUnit, abj: true);
    		X3Y3_下唇CP = new ColorP(X3Y3_下唇, 下唇CD, DisUnit, abj: true);
    		X3Y4_舌CP = new ColorP(X3Y4_舌, 舌CD, DisUnit, abj: true);
    		X3Y4_上唇CP = new ColorP(X3Y4_上唇, 上唇CD, DisUnit, abj: true);
    		X3Y4_下唇CP = new ColorP(X3Y4_下唇, 下唇CD, DisUnit, abj: true);
    		X4Y0_舌CP = new ColorP(X4Y0_舌, 舌CD, DisUnit, abj: true);
    		X4Y0_上唇CP = new ColorP(X4Y0_上唇, 上唇CD, DisUnit, abj: true);
    		X4Y0_下唇CP = new ColorP(X4Y0_下唇, 下唇CD, DisUnit, abj: true);
    		X4Y1_舌CP = new ColorP(X4Y1_舌, 舌CD, DisUnit, abj: true);
    		X4Y1_上唇CP = new ColorP(X4Y1_上唇, 上唇CD, DisUnit, abj: true);
    		X4Y1_下唇CP = new ColorP(X4Y1_下唇, 下唇CD, DisUnit, abj: true);
    		X4Y2_舌CP = new ColorP(X4Y2_舌, 舌CD, DisUnit, abj: true);
    		X4Y2_上唇CP = new ColorP(X4Y2_上唇, 上唇CD, DisUnit, abj: true);
    		X4Y2_下唇CP = new ColorP(X4Y2_下唇, 下唇CD, DisUnit, abj: true);
    		X4Y3_舌CP = new ColorP(X4Y3_舌, 舌CD, DisUnit, abj: true);
    		X4Y3_上唇CP = new ColorP(X4Y3_上唇, 上唇CD, DisUnit, abj: true);
    		X4Y3_下唇CP = new ColorP(X4Y3_下唇, 下唇CD, DisUnit, abj: true);
    		X4Y4_舌CP = new ColorP(X4Y4_舌, 舌CD, DisUnit, abj: true);
    		X4Y4_上唇CP = new ColorP(X4Y4_上唇, 上唇CD, DisUnit, abj: true);
    		X4Y4_下唇CP = new ColorP(X4Y4_下唇, 下唇CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		X4Y0_上唇.SetBasePointBase(X4Y0_上唇.ToLocal(X4Y0_舌.ToGlobal(X4Y0_舌.GetJP()[0].Joint)));
    		X4Y1_上唇.SetBasePointBase(X4Y1_上唇.ToLocal(X4Y1_舌.ToGlobal(X4Y1_舌.GetJP()[0].Joint)));
    		X4Y2_上唇.SetBasePointBase(X4Y2_上唇.ToLocal(X4Y2_舌.ToGlobal(X4Y2_舌.GetJP()[0].Joint)));
    		X4Y3_上唇.SetBasePointBase(X4Y3_上唇.ToLocal(X4Y3_舌.ToGlobal(X4Y3_舌.GetJP()[0].Joint)));
    		X4Y4_上唇.SetBasePointBase(X4Y4_上唇.ToLocal(X4Y4_舌.ToGlobal(X4Y4_舌.GetJP()[0].Joint)));
    		尺度B = 1.08;
    		Body.JoinPAall();
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		switch (Body.GetIndexX())
    		{
    		case 2:
    			Are.Draw(X2Y0_舌);
    			break;
    		case 3:
    			switch (Body.GetIndexY())
    			{
    			case 0:
    				Are.Draw(X3Y0_舌);
    				break;
    			case 1:
    				Are.Draw(X3Y1_舌);
    				break;
    			case 2:
    				Are.Draw(X3Y2_舌);
    				break;
    			case 3:
    				Are.Draw(X3Y3_舌);
    				break;
    			default:
    				Are.Draw(X3Y4_舌);
    				break;
    			}
    			break;
    		case 4:
    			switch (Body.GetIndexY())
    			{
    			case 0:
    				Are.Draw(X4Y0_舌);
    				break;
    			case 1:
    				Are.Draw(X4Y1_舌);
    				break;
    			case 2:
    				Are.Draw(X4Y2_舌);
    				break;
    			case 3:
    				Are.Draw(X4Y3_舌);
    				break;
    			default:
    				Are.Draw(X4Y4_舌);
    				break;
    			}
    			break;
    		}
    	}

    	public override void 描画1(RenderArea Are)
    	{
    		switch (Body.GetIndexX())
    		{
    		case 0:
    			Are.Draw(X0Y0_上唇);
    			Are.Draw(X0Y0_下唇);
    			break;
    		case 1:
    			Are.Draw(X1Y0_上唇);
    			Are.Draw(X1Y0_下唇);
    			break;
    		case 2:
    			Are.Draw(X2Y0_上唇);
    			Are.Draw(X2Y0_下唇);
    			break;
    		case 3:
    			switch (Body.GetIndexY())
    			{
    			case 0:
    				Are.Draw(X3Y0_上唇);
    				Are.Draw(X3Y0_下唇);
    				break;
    			case 1:
    				Are.Draw(X3Y1_上唇);
    				Are.Draw(X3Y1_下唇);
    				break;
    			case 2:
    				Are.Draw(X3Y2_上唇);
    				Are.Draw(X3Y2_下唇);
    				break;
    			case 3:
    				Are.Draw(X3Y3_上唇);
    				Are.Draw(X3Y3_下唇);
    				break;
    			default:
    				Are.Draw(X3Y4_上唇);
    				Are.Draw(X3Y4_下唇);
    				break;
    			}
    			break;
    		default:
    			switch (Body.GetIndexY())
    			{
    			case 0:
    				Are.Draw(X4Y0_上唇);
    				Are.Draw(X4Y0_下唇);
    				break;
    			case 1:
    				Are.Draw(X4Y1_上唇);
    				Are.Draw(X4Y1_下唇);
    				break;
    			case 2:
    				Are.Draw(X4Y2_上唇);
    				Are.Draw(X4Y2_下唇);
    				break;
    			case 3:
    				Are.Draw(X4Y3_上唇);
    				Are.Draw(X4Y3_下唇);
    				break;
    			default:
    				Are.Draw(X4Y4_上唇);
    				Are.Draw(X4Y4_下唇);
    				break;
    			}
    			break;
    		}
    	}

    	public override void 色更新()
    	{
    		switch (Body.GetIndexX())
    		{
    		case 0:
    			X0Y0_上唇CP.Update();
    			X0Y0_下唇CP.Update();
    			break;
    		case 1:
    			X1Y0_上唇CP.Update();
    			X1Y0_下唇CP.Update();
    			break;
    		case 2:
    			X2Y0_舌CP.Update();
    			X2Y0_上唇CP.Update();
    			X2Y0_下唇CP.Update();
    			break;
    		case 3:
    			switch (Body.GetIndexY())
    			{
    			case 0:
    				X3Y0_舌CP.Update();
    				X3Y0_上唇CP.Update();
    				X3Y0_下唇CP.Update();
    				break;
    			case 1:
    				X3Y1_舌CP.Update();
    				X3Y1_上唇CP.Update();
    				X3Y1_下唇CP.Update();
    				break;
    			case 2:
    				X3Y2_舌CP.Update();
    				X3Y2_上唇CP.Update();
    				X3Y2_下唇CP.Update();
    				break;
    			case 3:
    				X3Y3_舌CP.Update();
    				X3Y3_上唇CP.Update();
    				X3Y3_下唇CP.Update();
    				break;
    			default:
    				X3Y4_舌CP.Update();
    				X3Y4_上唇CP.Update();
    				X3Y4_下唇CP.Update();
    				break;
    			}
    			break;
    		default:
    			switch (Body.GetIndexY())
    			{
    			case 0:
    				X4Y0_舌CP.Update();
    				X4Y0_上唇CP.Update();
    				X4Y0_下唇CP.Update();
    				break;
    			case 1:
    				X4Y1_舌CP.Update();
    				X4Y1_上唇CP.Update();
    				X4Y1_下唇CP.Update();
    				break;
    			case 2:
    				X4Y2_舌CP.Update();
    				X4Y2_上唇CP.Update();
    				X4Y2_下唇CP.Update();
    				break;
    			case 3:
    				X4Y3_舌CP.Update();
    				X4Y3_上唇CP.Update();
    				X4Y3_下唇CP.Update();
    				break;
    			default:
    				X4Y4_舌CP.Update();
    				X4Y4_上唇CP.Update();
    				X4Y4_下唇CP.Update();
    				break;
    			}
    			break;
    		}
    	}

    	private void 配色(主人公配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(主人公配色 体配色)
    	{
    		舌CD = new ColorD(ref 体配色.粘線, ref 体配色.粘膜);
    		上唇CD = new ColorD(ref 体配色.粘線, ref 体配色.粘膜);
    		下唇CD = new ColorD(ref 体配色.粘線, ref 体配色.粘膜);
    	}

    	public void 再配色(主人公配色 体配色)
    	{
    		舌CD.線 = 体配色.粘線;
    		舌CD.色 = 体配色.粘膜;
    		上唇CD.線 = 体配色.粘線;
    		上唇CD.色 = 体配色.粘膜;
    		下唇CD.線 = 体配色.粘線;
    		下唇CD.色 = 体配色.粘膜;
    	}
    }
}
