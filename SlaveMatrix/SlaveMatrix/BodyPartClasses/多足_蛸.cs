using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 多足_蛸 : 半身
    {
    	public ShapePart X0Y0_Torso;

    	public ColorD TorsoCD;

    	public ColorP X0Y0_TorsoCP;

    	public Ele[] 軟体外左_接続;

    	public Ele[] 軟体外右_接続;

    	public Ele[] 軟体内左_接続;

    	public Ele[] 軟体内右_接続;

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

    	public override bool 表示
    	{
    		get
    		{
    			return Torso_表示;
    		}
    		set
    		{
    			Torso_表示 = value;
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
    		}
    	}

    	public JointS 軟体外左_接続点 => new JointS(Body, X0Y0_Torso, 0);

    	public JointS 軟体外右_接続点 => new JointS(Body, X0Y0_Torso, 3);

    	public JointS 軟体内左_接続点 => new JointS(Body, X0Y0_Torso, 1);

    	public JointS 軟体内右_接続点 => new JointS(Body, X0Y0_Torso, 2);

    	public 多足_蛸(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 多足_蛸D e)
    	{
    		多足_蛸 多足_蛸2 = this;
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant();
    		morphVariant.Tag = "蛸";
    		morphVariant.Add(new PartGroup(Sta.半身["多足"][0][0]));
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_Torso = partGroup["胴"].ToPar();
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
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Ele f;
    		if (e.軟体外左_接続.Count > 0)
    		{
    			軟体外左_接続 = e.軟体外左_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蛸2;
    				f.ConnectionType = ConnectionInfo.多足_蛸_軟体外左_接続;
    				f.接続(多足_蛸2.軟体外左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.軟体外右_接続.Count > 0)
    		{
    			軟体外右_接続 = e.軟体外右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蛸2;
    				f.ConnectionType = ConnectionInfo.多足_蛸_軟体外右_接続;
    				f.接続(多足_蛸2.軟体外右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.軟体内左_接続.Count > 0)
    		{
    			軟体内左_接続 = e.軟体内左_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蛸2;
    				f.ConnectionType = ConnectionInfo.多足_蛸_軟体内左_接続;
    				f.接続(多足_蛸2.軟体内左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.軟体内右_接続.Count > 0)
    		{
    			軟体内右_接続 = e.軟体内右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蛸2;
    				f.ConnectionType = ConnectionInfo.多足_蛸_軟体内右_接続;
    				f.接続(多足_蛸2.軟体内右_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_TorsoCP = new ColorP(X0Y0_Torso, TorsoCD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_TorsoCP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		switch (配色指定)
    		{
    		case 配色指定.N0:
    			配色N0(体配色);
    			break;
    		case 配色指定.T0:
    			配色T0(体配色);
    			break;
    		case 配色指定.T1:
    			配色T1(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		TorsoCD = new ColorD(ref Col.Black, ref 体配色.体0O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		TorsoCD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		TorsoCD = new ColorD(ref Col.Black, ref 体配色.体0O);
    	}
    }
}
