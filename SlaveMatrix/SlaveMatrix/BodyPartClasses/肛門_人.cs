using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 肛門_人 : 肛門
    {
    	public Par X0Y0_肛門3;

    	public Par X0Y0_肛門2;

    	public Par X0Y0_肛門1;

    	public ColorD 肛門3CD;

    	public ColorD 肛門2CD;

    	public ColorD 肛門1CD;

    	public ColorP X0Y0_肛門3CP;

    	public ColorP X0Y0_肛門2CP;

    	public ColorP X0Y0_肛門1CP;

    	public Ele[] 肛門精液_接続;

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

    	public bool 肛門3_表示
    	{
    		get
    		{
    			return X0Y0_肛門3.Dra;
    		}
    		set
    		{
    			X0Y0_肛門3.Dra = value;
    			X0Y0_肛門3.Hit = value;
    		}
    	}

    	public bool 肛門2_表示
    	{
    		get
    		{
    			return X0Y0_肛門2.Dra;
    		}
    		set
    		{
    			X0Y0_肛門2.Dra = value;
    			X0Y0_肛門2.Hit = value;
    		}
    	}

    	public bool 肛門1_表示
    	{
    		get
    		{
    			return X0Y0_肛門1.Dra;
    		}
    		set
    		{
    			X0Y0_肛門1.Dra = value;
    			X0Y0_肛門1.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 肛門3_表示;
    		}
    		set
    		{
    			肛門3_表示 = value;
    			肛門2_表示 = value;
    			肛門1_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 肛門3CD.不透明度;
    		}
    		set
    		{
    			肛門3CD.不透明度 = value;
    			肛門2CD.不透明度 = value;
    			肛門1CD.不透明度 = value;
    		}
    	}

    	public JointS 肛門精液_接続点 => new JointS(Body, X0Y0_肛門2, 0);

    	public 肛門_人(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 肛門_人D e)
    	{
    		肛門_人 肛門_人2 = this;
    		ThisType = GetType();
    		Body = new Difs(Sta.胴体["肛門"]);
    		Pars pars = Body[0][0];
    		X0Y0_肛門3 = pars["肛門3"].ToPar();
    		X0Y0_肛門2 = pars["肛門2"].ToPar();
    		X0Y0_肛門1 = pars["肛門1"].ToPar();
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
    		肛門3_表示 = e.肛門3_表示;
    		肛門2_表示 = e.肛門2_表示;
    		肛門1_表示 = e.肛門1_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.肛門精液_接続.Count > 0)
    		{
    			Ele f;
    			肛門精液_接続 = e.肛門精液_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 肛門_人2;
    				f.ConnectionType = ConnectionInfo.肛門_人_肛門精液_接続;
    				f.接続(肛門_人2.肛門精液_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_肛門3CP = new ColorP(X0Y0_肛門3, 肛門3CD, DisUnit, abj: true);
    		X0Y0_肛門2CP = new ColorP(X0Y0_肛門2, 肛門2CD, DisUnit, abj: true);
    		X0Y0_肛門1CP = new ColorP(X0Y0_肛門1, 肛門1CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_肛門3CP.Update();
    		X0Y0_肛門2CP.Update();
    		X0Y0_肛門1CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		肛門3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		肛門2CD = new ColorD(ref 体配色.粘膜線, ref 体配色.粘膜);
    		肛門1CD = new ColorD(ref 体配色.粘膜線, ref 体配色.粘膜穴);
    	}
    }
}
