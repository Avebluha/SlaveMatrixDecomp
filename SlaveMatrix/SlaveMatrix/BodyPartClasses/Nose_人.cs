using _2DGAMELIB;
using SlaveMatrix.GameClasses;
using System.Linq;

namespace SlaveMatrix
{
    public class Nose_人 : Nose
    {
    	public ShapePart X0Y0_Nose;

    	public ColorD NoseCD;

    	public ColorP X0Y0_NoseCP;

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

    	public bool Nose_表示
    	{
    		get
    		{
    			return X0Y0_Nose.Dra;
    		}
    		set
    		{
    			X0Y0_Nose.Dra = value;
    			X0Y0_Nose.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return Nose_表示;
    		}
    		set
    		{
    			Nose_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return NoseCD.不透明度;
    		}
    		set
    		{
    			NoseCD.不透明度 = value;
    		}
    	}

    	public JointS 鼻水左_接続点 => new JointS(Body, X0Y0_Nose, 0);

    	public JointS 鼻水右_接続点 => new JointS(Body, X0Y0_Nose, 1);

    	public Nose_人(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, Nose_人D e)
    	{
    		Nose_人 Nose_人2 = this;
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant();
    		morphVariant.Tag = "人";
    		morphVariant.Add(new PartGroup(GlobalState.胴体["Nose"][0][0]));
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_Nose = partGroup["鼻"].ToPar();
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
    		Nose_表示 = e.Nose_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Element f;
    		if (e.NoseDripLeft_接続.Count > 0)
    		{
    			NoseDripLeft_接続 = e.NoseDripLeft_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Nose_人2;
    				f.ConnectionType = ConnectionInfo.Nose_人_NoseDripLeft_接続;
    				f.接続(Nose_人2.鼻水左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.鼻水右_接続.Count > 0)
    		{
    			鼻水右_接続 = e.鼻水右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Nose_人2;
    				f.ConnectionType = ConnectionInfo.Nose_人_鼻水右_接続;
    				f.接続(Nose_人2.鼻水右_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_NoseCP = new ColorP(X0Y0_Nose, NoseCD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_NoseCP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		NoseCD = new ColorD(ref ColorHelper.Black, ref Color2.Empty);
    	}
    }
}
