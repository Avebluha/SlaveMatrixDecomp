using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 基髪 : Element
    {
    	public ShapePart X0Y0_髪;

    	public ColorD 髪CD;

    	public ColorP X0Y0_髪CP;

    	public Element[] 頭頂左_接続;

    	public Element[] 頭頂右_接続;

    	public Element[] 横髪左_接続;

    	public Element[] 横髪右_接続;

    	public Element[] 前髪_接続;

    	public Element[] 後髪_接続;

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

    	public bool 髪_表示
    	{
    		get
    		{
    			return X0Y0_髪.Dra;
    		}
    		set
    		{
    			X0Y0_髪.Dra = value;
    			X0Y0_髪.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 髪_表示;
    		}
    		set
    		{
    			髪_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 髪CD.不透明度;
    		}
    		set
    		{
    			髪CD.不透明度 = value;
    		}
    	}

    	public override double 肥大
    	{
    		set
    		{
    		}
    	}

    	public override double 身長
    	{
    		set
    		{
    		}
    	}

    	public JointS 頭頂左_接続点 => new JointS(Body, X0Y0_髪, 0);

    	public JointS 頭頂右_接続点 => new JointS(Body, X0Y0_髪, 1);

    	public JointS 横髪左_接続点 => new JointS(Body, X0Y0_髪, 0);

    	public JointS 横髪右_接続点 => new JointS(Body, X0Y0_髪, 1);

    	public JointS 前髪_接続点 => new JointS(Body, X0Y0_髪, 2);

    	public JointS 後髪_接続点 => new JointS(Body, X0Y0_髪, 3);

    	public 基髪(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 基髪D e)
    	{
    		基髪 基髪2 = this;
    		ThisType = GetType();
    		Body = new VariantGrid(GlobalState.胴体["基髪"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_髪 = partGroup["髪"].ToPar();
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
    		髪_表示 = e.髪_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Element f;
    		if (e.頭頂左_接続.Count > 0)
    		{
    			頭頂左_接続 = e.頭頂左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 基髪2;
    				f.ConnectionType = ConnectionInfo.基髪_頭頂左_接続;
    				f.接続(基髪2.頭頂左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.頭頂右_接続.Count > 0)
    		{
    			頭頂右_接続 = e.頭頂右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 基髪2;
    				f.ConnectionType = ConnectionInfo.基髪_頭頂右_接続;
    				f.接続(基髪2.頭頂右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.横髪左_接続.Count > 0)
    		{
    			横髪左_接続 = e.横髪左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 基髪2;
    				f.ConnectionType = ConnectionInfo.基髪_横髪左_接続;
    				f.接続(基髪2.横髪左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.横髪右_接続.Count > 0)
    		{
    			横髪右_接続 = e.横髪右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 基髪2;
    				f.ConnectionType = ConnectionInfo.基髪_横髪右_接続;
    				f.接続(基髪2.横髪右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.前髪_接続.Count > 0)
    		{
    			前髪_接続 = e.前髪_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 基髪2;
    				f.ConnectionType = ConnectionInfo.基髪_前髪_接続;
    				f.接続(基髪2.前髪_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.後髪_接続.Count > 0)
    		{
    			後髪_接続 = e.後髪_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 基髪2;
    				f.ConnectionType = ConnectionInfo.基髪_後髪_接続;
    				f.接続(基髪2.後髪_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_髪CP = new ColorP(X0Y0_髪, 髪CD, DisUnit, abj: false);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_髪CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		髪CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    	}
    }
}
