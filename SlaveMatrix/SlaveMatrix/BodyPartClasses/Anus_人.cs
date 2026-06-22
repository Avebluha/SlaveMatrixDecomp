using System.Linq;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class Anus_人 : Anus
    {
    	public ShapePart X0Y0_Anus3;

    	public ShapePart X0Y0_Anus2;

    	public ShapePart X0Y0_Anus1;

    	public ColorD Anus3CD;

    	public ColorD Anus2CD;

    	public ColorD Anus1CD;

    	public ColorP X0Y0_Anus3CP;

    	public ColorP X0Y0_Anus2CP;

    	public ColorP X0Y0_Anus1CP;

    	public Element[] 肛門精液_接続;

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

    	public bool Anus3_表示
    	{
    		get
    		{
    			return X0Y0_Anus3.Dra;
    		}
    		set
    		{
    			X0Y0_Anus3.Dra = value;
    			X0Y0_Anus3.Hit = value;
    		}
    	}

    	public bool Anus2_表示
    	{
    		get
    		{
    			return X0Y0_Anus2.Dra;
    		}
    		set
    		{
    			X0Y0_Anus2.Dra = value;
    			X0Y0_Anus2.Hit = value;
    		}
    	}

    	public bool Anus1_表示
    	{
    		get
    		{
    			return X0Y0_Anus1.Dra;
    		}
    		set
    		{
    			X0Y0_Anus1.Dra = value;
    			X0Y0_Anus1.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return Anus3_表示;
    		}
    		set
    		{
    			Anus3_表示 = value;
    			Anus2_表示 = value;
    			Anus1_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return Anus3CD.不透明度;
    		}
    		set
    		{
    			Anus3CD.不透明度 = value;
    			Anus2CD.不透明度 = value;
    			Anus1CD.不透明度 = value;
    		}
    	}

    	public JointS 肛門精液_接続点 => new JointS(Body, X0Y0_Anus2, 0);

    	public Anus_人(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, Anus_人D e)
    	{
    		Anus_人 Anus_人2 = this;
    		ThisType = GetType();
    		Body = new VariantGrid(GlobalState.胴体["Anus"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_Anus3 = partGroup["肛門3"].ToPar();
    		X0Y0_Anus2 = partGroup["肛門2"].ToPar();
    		X0Y0_Anus1 = partGroup["肛門1"].ToPar();
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
    		Anus3_表示 = e.Anus3_表示;
    		Anus2_表示 = e.Anus2_表示;
    		Anus1_表示 = e.Anus1_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.肛門精液_接続.Count > 0)
    		{
    			Element f;
    			肛門精液_接続 = e.肛門精液_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Anus_人2;
    				f.ConnectionType = ConnectionInfo.Anus_人_肛門精液_接続;
    				f.接続(Anus_人2.肛門精液_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_Anus3CP = new ColorP(X0Y0_Anus3, Anus3CD, DisUnit, abj: true);
    		X0Y0_Anus2CP = new ColorP(X0Y0_Anus2, Anus2CD, DisUnit, abj: true);
    		X0Y0_Anus1CP = new ColorP(X0Y0_Anus1, Anus1CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_Anus3CP.Update();
    		X0Y0_Anus2CP.Update();
    		X0Y0_Anus1CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		Anus3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		Anus2CD = new ColorD(ref 体配色.粘膜線, ref 体配色.粘膜);
    		Anus1CD = new ColorD(ref 体配色.粘膜線, ref 体配色.粘膜穴);
    	}
    }
}
