using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class SideHair_肢系 : SideHair
    {
    	public ShapePart X0Y0_髪;

    	public ColorD 髪CD;

    	public ColorP X0Y0_髪CP;

    	public Ele[] 肢_接続;

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

    	public JointS 肢_接続点 => new JointS(Body, X0Y0_髪, 0);

    	public SideHair_肢系(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, SideHair_肢系D e)
    	{
    		SideHair_肢系 横髪_肢系2 = this;
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "肢系";
    		dif.Add(new Pars(Sta.胴体["横髪左"][0][5]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_髪 = pars["髪"].ToPar();
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
    		if (e.肢_接続.Count > 0)
    		{
    			Ele f;
    			肢_接続 = e.肢_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 横髪_肢系2;
    				f.ConnectionType = ConnectionInfo.SideHair_肢系_肢_接続;
    				f.接続(横髪_肢系2.肢_接続点);
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
