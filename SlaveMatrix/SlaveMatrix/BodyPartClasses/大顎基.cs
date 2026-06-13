using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 大顎基 : Element
    {
    	public ShapePart X0Y0_甲殻下;

    	public 大顎上 大顎上;

    	public ColorD 甲殻下CD;

    	public ColorP X0Y0_甲殻下CP;

    	public Element[] 顎左_接続;

    	public Element[] 顎右_接続;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    			大顎上.欠損 = value;
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
    			大顎上.筋肉 = value;
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
    			大顎上.拘束 = value;
    		}
    	}

    	public bool 甲殻下_表示
    	{
    		get
    		{
    			return X0Y0_甲殻下.Dra;
    		}
    		set
    		{
    			X0Y0_甲殻下.Dra = value;
    			X0Y0_甲殻下.Hit = value;
    		}
    	}

    	public bool 甲殻_表示
    	{
    		get
    		{
    			return 大顎上.X0Y0_甲殻.Dra;
    		}
    		set
    		{
    			大顎上.X0Y0_甲殻.Dra = value;
    			大顎上.X0Y0_甲殻.Hit = value;
    		}
    	}

    	public bool 線左_表示
    	{
    		get
    		{
    			return 大顎上.X0Y0_線左.Dra;
    		}
    		set
    		{
    			大顎上.X0Y0_線左.Dra = value;
    			大顎上.X0Y0_線左.Hit = value;
    		}
    	}

    	public bool 線右_表示
    	{
    		get
    		{
    			return 大顎上.X0Y0_線右.Dra;
    		}
    		set
    		{
    			大顎上.X0Y0_線右.Dra = value;
    			大顎上.X0Y0_線右.Hit = value;
    		}
    	}

    	public bool 刺左_表示
    	{
    		get
    		{
    			return 大顎上.X0Y0_棘左.Dra;
    		}
    		set
    		{
    			大顎上.X0Y0_棘左.Dra = value;
    			大顎上.X0Y0_棘左.Hit = value;
    		}
    	}

    	public bool 刺右_表示
    	{
    		get
    		{
    			return 大顎上.X0Y0_棘右.Dra;
    		}
    		set
    		{
    			大顎上.X0Y0_棘右.Dra = value;
    			大顎上.X0Y0_棘右.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 甲殻下_表示;
    		}
    		set
    		{
    			甲殻下_表示 = value;
    			大顎上.表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 甲殻下CD.不透明度;
    		}
    		set
    		{
    			甲殻下CD.不透明度 = value;
    			大顎上.Intensity = value;
    		}
    	}

    	public double 展開
    	{
    		set
    		{
    			位置C = new Vector2D(位置C.X, -0.013 * value);
    			foreach (Element item in EnumEle())
    			{
    				item.尺度YC = 1.0 - 0.05 * value;
    			}
    		}
    	}

    	public override double 尺度B
    	{
    		get
    		{
    			return base.尺度B;
    		}
    		set
    		{
    			base.尺度B = value;
    			大顎上.尺度B = value;
    		}
    	}

    	public override double 尺度C
    	{
    		get
    		{
    			return base.尺度C;
    		}
    		set
    		{
    			base.尺度C = value;
    			大顎上.尺度C = value;
    		}
    	}

    	public override double 尺度XB
    	{
    		get
    		{
    			return base.尺度XB;
    		}
    		set
    		{
    			base.尺度XB = value;
    			大顎上.尺度XB = value;
    		}
    	}

    	public override double 尺度XC
    	{
    		get
    		{
    			return base.尺度XC;
    		}
    		set
    		{
    			base.尺度XC = value;
    			大顎上.尺度XC = value;
    		}
    	}

    	public override double 尺度YB
    	{
    		get
    		{
    			return base.尺度YB;
    		}
    		set
    		{
    			base.尺度YB = value;
    			大顎上.尺度YB = value;
    		}
    	}

    	public override double 尺度YC
    	{
    		get
    		{
    			return base.尺度YC;
    		}
    		set
    		{
    			base.尺度YC = value;
    			大顎上.尺度YC = value;
    		}
    	}

    	public override double 肥大
    	{
    		set
    		{
    			base.肥大 = value;
    			大顎上.肥大 = value;
    		}
    	}

    	public override double 身長
    	{
    		set
    		{
    			base.身長 = value;
    			大顎上.身長 = value;
    		}
    	}

    	public override bool 右
    	{
    		get
    		{
    			return base.右;
    		}
    		set
    		{
    			base.右 = value;
    			大顎上.右 = value;
    		}
    	}

    	public override bool 反転X
    	{
    		get
    		{
    			return base.反転X;
    		}
    		set
    		{
    			base.反転X = value;
    			大顎上.反転X = value;
    		}
    	}

    	public override bool 反転Y
    	{
    		get
    		{
    			return base.反転Y;
    		}
    		set
    		{
    			base.反転Y = value;
    			大顎上.反転Y = value;
    		}
    	}

    	public override double Xv
    	{
    		get
    		{
    			return base.Xv;
    		}
    		set
    		{
    			base.Xv = value;
    			大顎上.Xv = value;
    		}
    	}

    	public override double Yv
    	{
    		get
    		{
    			return base.Yv;
    		}
    		set
    		{
    			base.Yv = value;
    			大顎上.Yv = value;
    		}
    	}

    	public override int Xi
    	{
    		get
    		{
    			return base.Xi;
    		}
    		set
    		{
    			base.Xi = value;
    			大顎上.Xi = value;
    		}
    	}

    	public override int Yi
    	{
    		get
    		{
    			return base.Yi;
    		}
    		set
    		{
    			base.Yi = value;
    			大顎上.Yi = value;
    		}
    	}

    	public override double サイズ
    	{
    		get
    		{
    			return サイズ_;
    		}
    		set
    		{
    			base.サイズ = value;
    			大顎上.サイズ = value;
    		}
    	}

    	public override double サイズX
    	{
    		get
    		{
    			return サイズX_;
    		}
    		set
    		{
    			base.サイズX = value;
    			大顎上.サイズX = value;
    		}
    	}

    	public override double サイズY
    	{
    		get
    		{
    			return サイズY_;
    		}
    		set
    		{
    			base.サイズY = value;
    			大顎上.サイズY = value;
    		}
    	}

    	public JointS 顎左_接続点 => new JointS(Body, X0Y0_甲殻下, 0);

    	public JointS 顎右_接続点 => new JointS(Body, X0Y0_甲殻下, 1);

    	public JointS 大顎上_接続点 => new JointS(Body, X0Y0_甲殻下, 2);

    	public 大顎基(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 大顎基D e)
    	{
    		大顎基 大顎基2 = this;
    		大顎上 = new 大顎上(DisUnit, 配色指定, 体配色);
    		大顎上.Par = this;
    		ThisType = GetType();
    		Body = new VariantGrid(Sta.肢中["大顎基"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_甲殻下 = partGroup["甲殻下"].ToPar();
    		大顎上.接続(大顎上_接続点);
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
    		甲殻下_表示 = e.甲殻下_表示;
    		甲殻_表示 = e.甲殻_表示;
    		線左_表示 = e.線左_表示;
    		線右_表示 = e.線右_表示;
    		刺左_表示 = e.刺左_表示;
    		刺右_表示 = e.刺右_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Element f;
    		if (e.顎左_接続.Count > 0)
    		{
    			顎左_接続 = e.顎左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 大顎基2;
    				f.ConnectionType = ConnectionInfo.大顎基_顎左_接続;
    				f.接続(大顎基2.顎左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.顎右_接続.Count > 0)
    		{
    			顎右_接続 = e.顎右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 大顎基2;
    				f.ConnectionType = ConnectionInfo.大顎基_顎右_接続;
    				f.接続(大顎基2.顎右_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_甲殻下CP = new ColorP(X0Y0_甲殻下, 甲殻下CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		大顎上.Dispose();
    	}

    	public override void 接続P()
    	{
    		接続根.JoinP();
    		大顎上.接続P();
    	}

    	public override void 接続PA()
    	{
    		接続根.JoinPA();
    		大顎上.接続PA();
    	}

    	public override void 色更新()
    	{
    		X0Y0_甲殻下CP.Update();
    		大顎上.色更新();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		甲殻下CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    	}
    }
}
