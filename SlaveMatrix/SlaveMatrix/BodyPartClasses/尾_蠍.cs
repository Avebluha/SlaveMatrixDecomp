using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 尾_蠍 : 尾
    {
    	public Par X0Y0_節1_尾;

    	public Par X0Y0_節1_線;

    	public Par X0Y0_節1_瘤左;

    	public Par X0Y0_節1_瘤右;

    	public Par X0Y0_節2_尾;

    	public Par X0Y0_節2_線;

    	public Par X0Y0_節2_瘤左;

    	public Par X0Y0_節2_瘤右;

    	public Par X0Y0_節3_尾;

    	public Par X0Y0_節3_線;

    	public Par X0Y0_節3_瘤左;

    	public Par X0Y0_節3_瘤右;

    	public Par X0Y0_輪1_革;

    	public Par X0Y0_輪1_金具1;

    	public Par X0Y0_輪1_金具2;

    	public Par X0Y0_輪1_金具3;

    	public Par X0Y0_輪1_金具左;

    	public Par X0Y0_輪1_金具右;

    	public Par X0Y0_節4_尾;

    	public Par X0Y0_節4_線;

    	public Par X0Y0_節4_瘤左;

    	public Par X0Y0_節4_瘤右;

    	public Par X0Y0_節5_尾;

    	public Par X0Y0_節5_線;

    	public Par X0Y0_節5_瘤左;

    	public Par X0Y0_節5_瘤右;

    	public Par X0Y0_針_尾針;

    	public Par X0Y0_針_線1;

    	public Par X0Y0_針_線2;

    	public Par X0Y0_輪2_革;

    	public Par X0Y0_輪2_金具1;

    	public Par X0Y0_輪2_金具2;

    	public Par X0Y0_輪2_金具3;

    	public Par X0Y0_輪2_金具左;

    	public Par X0Y0_輪2_金具右;

    	public ColorD 節1_尾CD;

    	public ColorD 節1_線CD;

    	public ColorD 節1_瘤左CD;

    	public ColorD 節1_瘤右CD;

    	public ColorD 節2_尾CD;

    	public ColorD 節2_線CD;

    	public ColorD 節2_瘤左CD;

    	public ColorD 節2_瘤右CD;

    	public ColorD 節3_尾CD;

    	public ColorD 節3_線CD;

    	public ColorD 節3_瘤左CD;

    	public ColorD 節3_瘤右CD;

    	public ColorD 節4_尾CD;

    	public ColorD 節4_線CD;

    	public ColorD 節4_瘤左CD;

    	public ColorD 節4_瘤右CD;

    	public ColorD 節5_尾CD;

    	public ColorD 節5_線CD;

    	public ColorD 節5_瘤左CD;

    	public ColorD 節5_瘤右CD;

    	public ColorD 針_尾針CD;

    	public ColorD 針_線1CD;

    	public ColorD 針_線2CD;

    	public ColorD 輪1_革CD;

    	public ColorD 輪1_金具1CD;

    	public ColorD 輪1_金具2CD;

    	public ColorD 輪1_金具3CD;

    	public ColorD 輪1_金具左CD;

    	public ColorD 輪1_金具右CD;

    	public ColorD 輪2_革CD;

    	public ColorD 輪2_金具1CD;

    	public ColorD 輪2_金具2CD;

    	public ColorD 輪2_金具3CD;

    	public ColorD 輪2_金具左CD;

    	public ColorD 輪2_金具右CD;

    	public ColorP X0Y0_節1_尾CP;

    	public ColorP X0Y0_節1_線CP;

    	public ColorP X0Y0_節1_瘤左CP;

    	public ColorP X0Y0_節1_瘤右CP;

    	public ColorP X0Y0_節2_尾CP;

    	public ColorP X0Y0_節2_線CP;

    	public ColorP X0Y0_節2_瘤左CP;

    	public ColorP X0Y0_節2_瘤右CP;

    	public ColorP X0Y0_節3_尾CP;

    	public ColorP X0Y0_節3_線CP;

    	public ColorP X0Y0_節3_瘤左CP;

    	public ColorP X0Y0_節3_瘤右CP;

    	public ColorP X0Y0_輪1_革CP;

    	public ColorP X0Y0_輪1_金具1CP;

    	public ColorP X0Y0_輪1_金具2CP;

    	public ColorP X0Y0_輪1_金具3CP;

    	public ColorP X0Y0_輪1_金具左CP;

    	public ColorP X0Y0_輪1_金具右CP;

    	public ColorP X0Y0_節4_尾CP;

    	public ColorP X0Y0_節4_線CP;

    	public ColorP X0Y0_節4_瘤左CP;

    	public ColorP X0Y0_節4_瘤右CP;

    	public ColorP X0Y0_節5_尾CP;

    	public ColorP X0Y0_節5_線CP;

    	public ColorP X0Y0_節5_瘤左CP;

    	public ColorP X0Y0_節5_瘤右CP;

    	public ColorP X0Y0_針_尾針CP;

    	public ColorP X0Y0_針_線1CP;

    	public ColorP X0Y0_針_線2CP;

    	public ColorP X0Y0_輪2_革CP;

    	public ColorP X0Y0_輪2_金具1CP;

    	public ColorP X0Y0_輪2_金具2CP;

    	public ColorP X0Y0_輪2_金具3CP;

    	public ColorP X0Y0_輪2_金具左CP;

    	public ColorP X0Y0_輪2_金具右CP;

    	public 拘束鎖 鎖1;

    	public 拘束鎖 鎖2;

    	public 拘束鎖 鎖3;

    	public 拘束鎖 鎖4;

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
    			輪1表示 = 拘束_;
    			輪2表示 = 拘束_;
    		}
    	}

    	public bool 節1_尾_表示
    	{
    		get
    		{
    			return X0Y0_節1_尾.Dra;
    		}
    		set
    		{
    			X0Y0_節1_尾.Dra = value;
    			X0Y0_節1_尾.Hit = value;
    		}
    	}

    	public bool 節1_線_表示
    	{
    		get
    		{
    			return X0Y0_節1_線.Dra;
    		}
    		set
    		{
    			X0Y0_節1_線.Dra = value;
    			X0Y0_節1_線.Hit = value;
    		}
    	}

    	public bool 節1_瘤左_表示
    	{
    		get
    		{
    			return X0Y0_節1_瘤左.Dra;
    		}
    		set
    		{
    			X0Y0_節1_瘤左.Dra = value;
    			X0Y0_節1_瘤左.Hit = value;
    		}
    	}

    	public bool 節1_瘤右_表示
    	{
    		get
    		{
    			return X0Y0_節1_瘤右.Dra;
    		}
    		set
    		{
    			X0Y0_節1_瘤右.Dra = value;
    			X0Y0_節1_瘤右.Hit = value;
    		}
    	}

    	public bool 節2_尾_表示
    	{
    		get
    		{
    			return X0Y0_節2_尾.Dra;
    		}
    		set
    		{
    			X0Y0_節2_尾.Dra = value;
    			X0Y0_節2_尾.Hit = value;
    		}
    	}

    	public bool 節2_線_表示
    	{
    		get
    		{
    			return X0Y0_節2_線.Dra;
    		}
    		set
    		{
    			X0Y0_節2_線.Dra = value;
    			X0Y0_節2_線.Hit = value;
    		}
    	}

    	public bool 節2_瘤左_表示
    	{
    		get
    		{
    			return X0Y0_節2_瘤左.Dra;
    		}
    		set
    		{
    			X0Y0_節2_瘤左.Dra = value;
    			X0Y0_節2_瘤左.Hit = value;
    		}
    	}

    	public bool 節2_瘤右_表示
    	{
    		get
    		{
    			return X0Y0_節2_瘤右.Dra;
    		}
    		set
    		{
    			X0Y0_節2_瘤右.Dra = value;
    			X0Y0_節2_瘤右.Hit = value;
    		}
    	}

    	public bool 節3_尾_表示
    	{
    		get
    		{
    			return X0Y0_節3_尾.Dra;
    		}
    		set
    		{
    			X0Y0_節3_尾.Dra = value;
    			X0Y0_節3_尾.Hit = value;
    		}
    	}

    	public bool 節3_線_表示
    	{
    		get
    		{
    			return X0Y0_節3_線.Dra;
    		}
    		set
    		{
    			X0Y0_節3_線.Dra = value;
    			X0Y0_節3_線.Hit = value;
    		}
    	}

    	public bool 節3_瘤左_表示
    	{
    		get
    		{
    			return X0Y0_節3_瘤左.Dra;
    		}
    		set
    		{
    			X0Y0_節3_瘤左.Dra = value;
    			X0Y0_節3_瘤左.Hit = value;
    		}
    	}

    	public bool 節3_瘤右_表示
    	{
    		get
    		{
    			return X0Y0_節3_瘤右.Dra;
    		}
    		set
    		{
    			X0Y0_節3_瘤右.Dra = value;
    			X0Y0_節3_瘤右.Hit = value;
    		}
    	}

    	public bool 輪1_革_表示
    	{
    		get
    		{
    			return X0Y0_輪1_革.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_革.Dra = value;
    			X0Y0_輪1_革.Hit = value;
    		}
    	}

    	public bool 輪1_金具1_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具1.Dra = value;
    			X0Y0_輪1_金具1.Hit = value;
    		}
    	}

    	public bool 輪1_金具2_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具2.Dra = value;
    			X0Y0_輪1_金具2.Hit = value;
    		}
    	}

    	public bool 輪1_金具3_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具3.Dra = value;
    			X0Y0_輪1_金具3.Hit = value;
    		}
    	}

    	public bool 輪1_金具左_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具左.Dra = value;
    			X0Y0_輪1_金具左.Hit = value;
    		}
    	}

    	public bool 輪1_金具右_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具右.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具右.Dra = value;
    			X0Y0_輪1_金具右.Hit = value;
    		}
    	}

    	public bool 節4_尾_表示
    	{
    		get
    		{
    			return X0Y0_節4_尾.Dra;
    		}
    		set
    		{
    			X0Y0_節4_尾.Dra = value;
    			X0Y0_節4_尾.Hit = value;
    		}
    	}

    	public bool 節4_線_表示
    	{
    		get
    		{
    			return X0Y0_節4_線.Dra;
    		}
    		set
    		{
    			X0Y0_節4_線.Dra = value;
    			X0Y0_節4_線.Hit = value;
    		}
    	}

    	public bool 節4_瘤左_表示
    	{
    		get
    		{
    			return X0Y0_節4_瘤左.Dra;
    		}
    		set
    		{
    			X0Y0_節4_瘤左.Dra = value;
    			X0Y0_節4_瘤左.Hit = value;
    		}
    	}

    	public bool 節4_瘤右_表示
    	{
    		get
    		{
    			return X0Y0_節4_瘤右.Dra;
    		}
    		set
    		{
    			X0Y0_節4_瘤右.Dra = value;
    			X0Y0_節4_瘤右.Hit = value;
    		}
    	}

    	public bool 節5_尾_表示
    	{
    		get
    		{
    			return X0Y0_節5_尾.Dra;
    		}
    		set
    		{
    			X0Y0_節5_尾.Dra = value;
    			X0Y0_節5_尾.Hit = value;
    		}
    	}

    	public bool 節5_線_表示
    	{
    		get
    		{
    			return X0Y0_節5_線.Dra;
    		}
    		set
    		{
    			X0Y0_節5_線.Dra = value;
    			X0Y0_節5_線.Hit = value;
    		}
    	}

    	public bool 節5_瘤左_表示
    	{
    		get
    		{
    			return X0Y0_節5_瘤左.Dra;
    		}
    		set
    		{
    			X0Y0_節5_瘤左.Dra = value;
    			X0Y0_節5_瘤左.Hit = value;
    		}
    	}

    	public bool 節5_瘤右_表示
    	{
    		get
    		{
    			return X0Y0_節5_瘤右.Dra;
    		}
    		set
    		{
    			X0Y0_節5_瘤右.Dra = value;
    			X0Y0_節5_瘤右.Hit = value;
    		}
    	}

    	public bool 針_尾針_表示
    	{
    		get
    		{
    			return X0Y0_針_尾針.Dra;
    		}
    		set
    		{
    			X0Y0_針_尾針.Dra = value;
    			X0Y0_針_尾針.Hit = value;
    		}
    	}

    	public bool 針_線1_表示
    	{
    		get
    		{
    			return X0Y0_針_線1.Dra;
    		}
    		set
    		{
    			X0Y0_針_線1.Dra = value;
    			X0Y0_針_線1.Hit = value;
    		}
    	}

    	public bool 針_線2_表示
    	{
    		get
    		{
    			return X0Y0_針_線2.Dra;
    		}
    		set
    		{
    			X0Y0_針_線2.Dra = value;
    			X0Y0_針_線2.Hit = value;
    		}
    	}

    	public bool 輪2_革_表示
    	{
    		get
    		{
    			return X0Y0_輪2_革.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_革.Dra = value;
    			X0Y0_輪2_革.Hit = value;
    		}
    	}

    	public bool 輪2_金具1_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具1.Dra = value;
    			X0Y0_輪2_金具1.Hit = value;
    		}
    	}

    	public bool 輪2_金具2_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具2.Dra = value;
    			X0Y0_輪2_金具2.Hit = value;
    		}
    	}

    	public bool 輪2_金具3_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具3.Dra = value;
    			X0Y0_輪2_金具3.Hit = value;
    		}
    	}

    	public bool 輪2_金具左_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具左.Dra = value;
    			X0Y0_輪2_金具左.Hit = value;
    		}
    	}

    	public bool 輪2_金具右_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具右.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具右.Dra = value;
    			X0Y0_輪2_金具右.Hit = value;
    		}
    	}

    	public bool 輪1表示
    	{
    		get
    		{
    			return 輪1_革_表示;
    		}
    		set
    		{
    			輪1_革_表示 = value;
    			輪1_金具1_表示 = value;
    			輪1_金具2_表示 = value;
    			輪1_金具3_表示 = value;
    			輪1_金具左_表示 = value;
    			輪1_金具右_表示 = value;
    		}
    	}

    	public bool 輪2表示
    	{
    		get
    		{
    			return 輪2_革_表示;
    		}
    		set
    		{
    			輪2_革_表示 = value;
    			輪2_金具1_表示 = value;
    			輪2_金具2_表示 = value;
    			輪2_金具3_表示 = value;
    			輪2_金具左_表示 = value;
    			輪2_金具右_表示 = value;
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
    			鎖2.表示 = value;
    			鎖3.表示 = value;
    			鎖4.表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 節1_尾_表示;
    		}
    		set
    		{
    			節1_尾_表示 = value;
    			節1_線_表示 = value;
    			節1_瘤左_表示 = value;
    			節1_瘤右_表示 = value;
    			節2_尾_表示 = value;
    			節2_線_表示 = value;
    			節2_瘤左_表示 = value;
    			節2_瘤右_表示 = value;
    			節3_尾_表示 = value;
    			節3_線_表示 = value;
    			節3_瘤左_表示 = value;
    			節3_瘤右_表示 = value;
    			輪1_革_表示 = value;
    			輪1_金具1_表示 = value;
    			輪1_金具2_表示 = value;
    			輪1_金具3_表示 = value;
    			輪1_金具左_表示 = value;
    			輪1_金具右_表示 = value;
    			節4_尾_表示 = value;
    			節4_線_表示 = value;
    			節4_瘤左_表示 = value;
    			節4_瘤右_表示 = value;
    			節5_尾_表示 = value;
    			節5_線_表示 = value;
    			節5_瘤左_表示 = value;
    			節5_瘤右_表示 = value;
    			針_尾針_表示 = value;
    			針_線1_表示 = value;
    			針_線2_表示 = value;
    			輪2_革_表示 = value;
    			輪2_金具1_表示 = value;
    			輪2_金具2_表示 = value;
    			輪2_金具3_表示 = value;
    			輪2_金具左_表示 = value;
    			輪2_金具右_表示 = value;
    			鎖1.表示 = value;
    			鎖2.表示 = value;
    			鎖3.表示 = value;
    			鎖4.表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 節1_尾CD.不透明度;
    		}
    		set
    		{
    			節1_尾CD.不透明度 = value;
    			節1_線CD.不透明度 = value;
    			節1_瘤左CD.不透明度 = value;
    			節1_瘤右CD.不透明度 = value;
    			節2_尾CD.不透明度 = value;
    			節2_線CD.不透明度 = value;
    			節2_瘤左CD.不透明度 = value;
    			節2_瘤右CD.不透明度 = value;
    			節3_尾CD.不透明度 = value;
    			節3_線CD.不透明度 = value;
    			節3_瘤左CD.不透明度 = value;
    			節3_瘤右CD.不透明度 = value;
    			節4_尾CD.不透明度 = value;
    			節4_線CD.不透明度 = value;
    			節4_瘤左CD.不透明度 = value;
    			節4_瘤右CD.不透明度 = value;
    			節5_尾CD.不透明度 = value;
    			節5_線CD.不透明度 = value;
    			節5_瘤左CD.不透明度 = value;
    			節5_瘤右CD.不透明度 = value;
    			針_尾針CD.不透明度 = value;
    			針_線1CD.不透明度 = value;
    			針_線2CD.不透明度 = value;
    			輪1_革CD.不透明度 = value;
    			輪1_金具1CD.不透明度 = value;
    			輪1_金具2CD.不透明度 = value;
    			輪1_金具3CD.不透明度 = value;
    			輪1_金具左CD.不透明度 = value;
    			輪1_金具右CD.不透明度 = value;
    			輪2_革CD.不透明度 = value;
    			輪2_金具1CD.不透明度 = value;
    			輪2_金具2CD.不透明度 = value;
    			輪2_金具3CD.不透明度 = value;
    			輪2_金具左CD.不透明度 = value;
    			輪2_金具右CD.不透明度 = value;
    		}
    	}

    	public JointS 鎖1_接続点 => new JointS(本体, X0Y0_輪1_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(本体, X0Y0_輪1_金具右, 0);

    	public JointS 鎖3_接続点 => new JointS(本体, X0Y0_輪2_金具左, 0);

    	public JointS 鎖4_接続点 => new JointS(本体, X0Y0_輪2_金具右, 0);

    	public 尾_蠍(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 尾_蠍D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "蠍尾";
    		dif.Add(new Pars(Sta.尻尾["尾"][0][12]));
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars = 本体[0][0];
    		Pars pars2 = pars["節1"].ToPars();
    		X0Y0_節1_尾 = pars2["尾"].ToPar();
    		X0Y0_節1_線 = pars2["線"].ToPar();
    		X0Y0_節1_瘤左 = pars2["瘤左"].ToPar();
    		X0Y0_節1_瘤右 = pars2["瘤右"].ToPar();
    		pars2 = pars["節2"].ToPars();
    		X0Y0_節2_尾 = pars2["尾"].ToPar();
    		X0Y0_節2_線 = pars2["線"].ToPar();
    		X0Y0_節2_瘤左 = pars2["瘤左"].ToPar();
    		X0Y0_節2_瘤右 = pars2["瘤右"].ToPar();
    		pars2 = pars["節3"].ToPars();
    		X0Y0_節3_尾 = pars2["尾"].ToPar();
    		X0Y0_節3_線 = pars2["線"].ToPar();
    		X0Y0_節3_瘤左 = pars2["瘤左"].ToPar();
    		X0Y0_節3_瘤右 = pars2["瘤右"].ToPar();
    		pars2 = pars["輪1"].ToPars();
    		X0Y0_輪1_革 = pars2["革"].ToPar();
    		X0Y0_輪1_金具1 = pars2["金具1"].ToPar();
    		X0Y0_輪1_金具2 = pars2["金具2"].ToPar();
    		X0Y0_輪1_金具3 = pars2["金具3"].ToPar();
    		X0Y0_輪1_金具左 = pars2["金具左"].ToPar();
    		X0Y0_輪1_金具右 = pars2["金具右"].ToPar();
    		pars2 = pars["節4"].ToPars();
    		X0Y0_節4_尾 = pars2["尾"].ToPar();
    		X0Y0_節4_線 = pars2["線"].ToPar();
    		X0Y0_節4_瘤左 = pars2["瘤左"].ToPar();
    		X0Y0_節4_瘤右 = pars2["瘤右"].ToPar();
    		pars2 = pars["節5"].ToPars();
    		X0Y0_節5_尾 = pars2["尾"].ToPar();
    		X0Y0_節5_線 = pars2["線"].ToPar();
    		X0Y0_節5_瘤左 = pars2["瘤左"].ToPar();
    		X0Y0_節5_瘤右 = pars2["瘤右"].ToPar();
    		pars2 = pars["針"].ToPars();
    		X0Y0_針_尾針 = pars2["尾針"].ToPar();
    		X0Y0_針_線1 = pars2["線1"].ToPar();
    		X0Y0_針_線2 = pars2["線2"].ToPar();
    		pars2 = pars["輪2"].ToPars();
    		X0Y0_輪2_革 = pars2["革"].ToPar();
    		X0Y0_輪2_金具1 = pars2["金具1"].ToPar();
    		X0Y0_輪2_金具2 = pars2["金具2"].ToPar();
    		X0Y0_輪2_金具3 = pars2["金具3"].ToPar();
    		X0Y0_輪2_金具左 = pars2["金具左"].ToPar();
    		X0Y0_輪2_金具右 = pars2["金具右"].ToPar();
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
    		節1_尾_表示 = e.節1_尾_表示;
    		節1_線_表示 = e.節1_線_表示;
    		節1_瘤左_表示 = e.節1_瘤左_表示;
    		節1_瘤右_表示 = e.節1_瘤右_表示;
    		節2_尾_表示 = e.節2_尾_表示;
    		節2_線_表示 = e.節2_線_表示;
    		節2_瘤左_表示 = e.節2_瘤左_表示;
    		節2_瘤右_表示 = e.節2_瘤右_表示;
    		節3_尾_表示 = e.節3_尾_表示;
    		節3_線_表示 = e.節3_線_表示;
    		節3_瘤左_表示 = e.節3_瘤左_表示;
    		節3_瘤右_表示 = e.節3_瘤右_表示;
    		輪1_革_表示 = e.輪1_革_表示;
    		輪1_金具1_表示 = e.輪1_金具1_表示;
    		輪1_金具2_表示 = e.輪1_金具2_表示;
    		輪1_金具3_表示 = e.輪1_金具3_表示;
    		輪1_金具左_表示 = e.輪1_金具左_表示;
    		輪1_金具右_表示 = e.輪1_金具右_表示;
    		節4_尾_表示 = e.節4_尾_表示;
    		節4_線_表示 = e.節4_線_表示;
    		節4_瘤左_表示 = e.節4_瘤左_表示;
    		節4_瘤右_表示 = e.節4_瘤右_表示;
    		節5_尾_表示 = e.節5_尾_表示;
    		節5_線_表示 = e.節5_線_表示;
    		節5_瘤左_表示 = e.節5_瘤左_表示;
    		節5_瘤右_表示 = e.節5_瘤右_表示;
    		針_尾針_表示 = e.針_尾針_表示;
    		針_線1_表示 = e.針_線1_表示;
    		針_線2_表示 = e.針_線2_表示;
    		輪2_革_表示 = e.輪2_革_表示;
    		輪2_金具1_表示 = e.輪2_金具1_表示;
    		輪2_金具2_表示 = e.輪2_金具2_表示;
    		輪2_金具3_表示 = e.輪2_金具3_表示;
    		輪2_金具左_表示 = e.輪2_金具左_表示;
    		輪2_金具右_表示 = e.輪2_金具右_表示;
    		輪1表示 = e.輪1表示;
    		輪2表示 = e.輪2表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_節1_尾CP = new ColorP(X0Y0_節1_尾, 節1_尾CD, DisUnit, abj: true);
    		X0Y0_節1_線CP = new ColorP(X0Y0_節1_線, 節1_線CD, DisUnit, abj: true);
    		X0Y0_節1_瘤左CP = new ColorP(X0Y0_節1_瘤左, 節1_瘤左CD, DisUnit, abj: true);
    		X0Y0_節1_瘤右CP = new ColorP(X0Y0_節1_瘤右, 節1_瘤右CD, DisUnit, abj: true);
    		X0Y0_節2_尾CP = new ColorP(X0Y0_節2_尾, 節2_尾CD, DisUnit, abj: true);
    		X0Y0_節2_線CP = new ColorP(X0Y0_節2_線, 節2_線CD, DisUnit, abj: true);
    		X0Y0_節2_瘤左CP = new ColorP(X0Y0_節2_瘤左, 節2_瘤左CD, DisUnit, abj: true);
    		X0Y0_節2_瘤右CP = new ColorP(X0Y0_節2_瘤右, 節2_瘤右CD, DisUnit, abj: true);
    		X0Y0_節3_尾CP = new ColorP(X0Y0_節3_尾, 節3_尾CD, DisUnit, abj: true);
    		X0Y0_節3_線CP = new ColorP(X0Y0_節3_線, 節3_線CD, DisUnit, abj: true);
    		X0Y0_節3_瘤左CP = new ColorP(X0Y0_節3_瘤左, 節3_瘤左CD, DisUnit, abj: true);
    		X0Y0_節3_瘤右CP = new ColorP(X0Y0_節3_瘤右, 節3_瘤右CD, DisUnit, abj: true);
    		X0Y0_輪1_革CP = new ColorP(X0Y0_輪1_革, 輪1_革CD, DisUnit, abj: true);
    		X0Y0_輪1_金具1CP = new ColorP(X0Y0_輪1_金具1, 輪1_金具1CD, DisUnit, abj: true);
    		X0Y0_輪1_金具2CP = new ColorP(X0Y0_輪1_金具2, 輪1_金具2CD, DisUnit, abj: true);
    		X0Y0_輪1_金具3CP = new ColorP(X0Y0_輪1_金具3, 輪1_金具3CD, DisUnit, abj: true);
    		X0Y0_輪1_金具左CP = new ColorP(X0Y0_輪1_金具左, 輪1_金具左CD, DisUnit, abj: true);
    		X0Y0_輪1_金具右CP = new ColorP(X0Y0_輪1_金具右, 輪1_金具右CD, DisUnit, abj: true);
    		X0Y0_節4_尾CP = new ColorP(X0Y0_節4_尾, 節4_尾CD, DisUnit, abj: true);
    		X0Y0_節4_線CP = new ColorP(X0Y0_節4_線, 節4_線CD, DisUnit, abj: true);
    		X0Y0_節4_瘤左CP = new ColorP(X0Y0_節4_瘤左, 節4_瘤左CD, DisUnit, abj: true);
    		X0Y0_節4_瘤右CP = new ColorP(X0Y0_節4_瘤右, 節4_瘤右CD, DisUnit, abj: true);
    		X0Y0_節5_尾CP = new ColorP(X0Y0_節5_尾, 節5_尾CD, DisUnit, abj: true);
    		X0Y0_節5_線CP = new ColorP(X0Y0_節5_線, 節5_線CD, DisUnit, abj: true);
    		X0Y0_節5_瘤左CP = new ColorP(X0Y0_節5_瘤左, 節5_瘤左CD, DisUnit, abj: true);
    		X0Y0_節5_瘤右CP = new ColorP(X0Y0_節5_瘤右, 節5_瘤右CD, DisUnit, abj: true);
    		X0Y0_針_尾針CP = new ColorP(X0Y0_針_尾針, 針_尾針CD, DisUnit, abj: true);
    		X0Y0_針_線1CP = new ColorP(X0Y0_針_線1, 針_線1CD, DisUnit, abj: true);
    		X0Y0_針_線2CP = new ColorP(X0Y0_針_線2, 針_線2CD, DisUnit, abj: true);
    		X0Y0_輪2_革CP = new ColorP(X0Y0_輪2_革, 輪2_革CD, DisUnit, abj: true);
    		X0Y0_輪2_金具1CP = new ColorP(X0Y0_輪2_金具1, 輪2_金具1CD, DisUnit, abj: true);
    		X0Y0_輪2_金具2CP = new ColorP(X0Y0_輪2_金具2, 輪2_金具2CD, DisUnit, abj: true);
    		X0Y0_輪2_金具3CP = new ColorP(X0Y0_輪2_金具3, 輪2_金具3CD, DisUnit, abj: true);
    		X0Y0_輪2_金具左CP = new ColorP(X0Y0_輪2_金具左, 輪2_金具左CD, DisUnit, abj: true);
    		X0Y0_輪2_金具右CP = new ColorP(X0Y0_輪2_金具右, 輪2_金具右CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    		鎖1 = new 拘束鎖(DisUnit, 右, 配色指定, 体配色, Xasix);
    		鎖2 = new 拘束鎖(DisUnit, !右, 配色指定, 体配色, Xasix);
    		鎖3 = new 拘束鎖(DisUnit, 右, 配色指定, 体配色, Xasix);
    		鎖4 = new 拘束鎖(DisUnit, !右, 配色指定, 体配色, Xasix);
    		鎖1.接続(鎖1_接続点);
    		鎖2.接続(鎖2_接続点);
    		鎖3.接続(鎖3_接続点);
    		鎖4.接続(鎖4_接続点);
    		int num = (右 ? (-10) : 10);
    		鎖1.角度B -= num;
    		鎖2.角度B += num;
    		鎖3.角度B -= num;
    		鎖4.角度B += num;
    		鎖表示 = e.鎖表示;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_節1_尾);
    		Are.Draw(X0Y0_節1_線);
    		Are.Draw(X0Y0_節1_瘤左);
    		Are.Draw(X0Y0_節1_瘤右);
    		Are.Draw(X0Y0_節2_尾);
    		Are.Draw(X0Y0_節2_線);
    		Are.Draw(X0Y0_節2_瘤左);
    		Are.Draw(X0Y0_節2_瘤右);
    		Are.Draw(X0Y0_節3_尾);
    		Are.Draw(X0Y0_節3_線);
    		Are.Draw(X0Y0_節3_瘤左);
    		Are.Draw(X0Y0_節3_瘤右);
    		Are.Draw(X0Y0_輪1_革);
    		Are.Draw(X0Y0_輪1_金具1);
    		Are.Draw(X0Y0_輪1_金具2);
    		Are.Draw(X0Y0_輪1_金具3);
    		Are.Draw(X0Y0_輪1_金具左);
    		Are.Draw(X0Y0_輪1_金具右);
    		鎖1.描画0(Are);
    		鎖2.描画0(Are);
    		Are.Draw(X0Y0_節4_尾);
    		Are.Draw(X0Y0_節4_線);
    		Are.Draw(X0Y0_節4_瘤左);
    		Are.Draw(X0Y0_節4_瘤右);
    		Are.Draw(X0Y0_節5_尾);
    		Are.Draw(X0Y0_節5_線);
    		Are.Draw(X0Y0_節5_瘤左);
    		Are.Draw(X0Y0_節5_瘤右);
    		Are.Draw(X0Y0_針_尾針);
    		Are.Draw(X0Y0_針_線1);
    		Are.Draw(X0Y0_針_線2);
    		Are.Draw(X0Y0_輪2_革);
    		Are.Draw(X0Y0_輪2_金具1);
    		Are.Draw(X0Y0_輪2_金具2);
    		Are.Draw(X0Y0_輪2_金具3);
    		Are.Draw(X0Y0_輪2_金具左);
    		Are.Draw(X0Y0_輪2_金具右);
    		鎖3.描画0(Are);
    		鎖4.描画0(Are);
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    		鎖2.Dispose();
    		鎖3.Dispose();
    		鎖4.Dispose();
    	}

    	public override void SetAngle0()
    	{
    		_ = 右;
    		double maxAngle = 20.0;
    		X0Y0_節1_尾.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_節2_尾.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_節3_尾.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_節4_尾.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_節5_尾.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_針_尾針.AngleBase = maxAngle.GetRanAngle();
    		本体.JoinPAall();
    	}

    	public override bool Is革(Par p)
    	{
    		if (p != X0Y0_輪1_革 && p != X0Y0_輪1_金具1 && p != X0Y0_輪1_金具2 && p != X0Y0_輪1_金具3 && p != X0Y0_輪1_金具左 && p != X0Y0_輪1_金具右 && p != X0Y0_輪2_革 && p != X0Y0_輪2_金具1 && p != X0Y0_輪2_金具2 && p != X0Y0_輪2_金具3 && p != X0Y0_輪2_金具左)
    		{
    			return p == X0Y0_輪2_金具右;
    		}
    		return true;
    	}

    	public override IEnumerable<Par> Enum軸()
    	{
    		yield return X0Y0_節1_尾;
    		yield return X0Y0_節2_尾;
    		yield return X0Y0_節3_尾;
    		yield return X0Y0_節4_尾;
    		yield return X0Y0_節5_尾;
    		yield return X0Y0_針_尾針;
    	}

    	public override void 色更新()
    	{
    		X0Y0_節1_尾CP.Update();
    		X0Y0_節1_線CP.Update();
    		X0Y0_節1_瘤左CP.Update();
    		X0Y0_節1_瘤右CP.Update();
    		X0Y0_節2_尾CP.Update();
    		X0Y0_節2_線CP.Update();
    		X0Y0_節2_瘤左CP.Update();
    		X0Y0_節2_瘤右CP.Update();
    		X0Y0_節3_尾CP.Update();
    		X0Y0_節3_線CP.Update();
    		X0Y0_節3_瘤左CP.Update();
    		X0Y0_節3_瘤右CP.Update();
    		X0Y0_輪1_革CP.Update();
    		X0Y0_輪1_金具1CP.Update();
    		X0Y0_輪1_金具2CP.Update();
    		X0Y0_輪1_金具3CP.Update();
    		X0Y0_輪1_金具左CP.Update();
    		X0Y0_輪1_金具右CP.Update();
    		X0Y0_節4_尾CP.Update();
    		X0Y0_節4_線CP.Update();
    		X0Y0_節4_瘤左CP.Update();
    		X0Y0_節4_瘤右CP.Update();
    		X0Y0_節5_尾CP.Update();
    		X0Y0_節5_線CP.Update();
    		X0Y0_節5_瘤左CP.Update();
    		X0Y0_節5_瘤右CP.Update();
    		X0Y0_針_尾針CP.Update();
    		X0Y0_針_線1CP.Update();
    		X0Y0_針_線2CP.Update();
    		X0Y0_輪2_革CP.Update();
    		X0Y0_輪2_金具1CP.Update();
    		X0Y0_輪2_金具2CP.Update();
    		X0Y0_輪2_金具3CP.Update();
    		X0Y0_輪2_金具左CP.Update();
    		X0Y0_輪2_金具右CP.Update();
    		鎖1.接続PA();
    		鎖2.接続PA();
    		鎖3.接続PA();
    		鎖4.接続PA();
    		鎖1.色更新();
    		鎖2.色更新();
    		鎖3.色更新();
    		鎖4.色更新();
    	}

    	private void 配色(体配色 体配色)
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

    	private void 配色N0(体配色 体配色)
    	{
    		節1_尾CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節1_線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		節1_瘤左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節1_瘤右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節2_尾CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節2_線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		節2_瘤左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節2_瘤右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節3_尾CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節3_線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		節3_瘤左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節3_瘤右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節4_尾CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節4_線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		節4_瘤左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節4_瘤右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節5_尾CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節5_線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		節5_瘤左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節5_瘤右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		針_尾針CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		針_線1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		針_線2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		輪1_革CD = new ColorD();
    		輪1_金具1CD = new ColorD();
    		輪1_金具2CD = new ColorD();
    		輪1_金具3CD = new ColorD();
    		輪1_金具左CD = new ColorD();
    		輪1_金具右CD = new ColorD();
    		輪2_革CD = new ColorD();
    		輪2_金具1CD = new ColorD();
    		輪2_金具2CD = new ColorD();
    		輪2_金具3CD = new ColorD();
    		輪2_金具左CD = new ColorD();
    		輪2_金具右CD = new ColorD();
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		節1_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節1_線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		節1_瘤左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節1_瘤右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節2_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節2_線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		節2_瘤左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節2_瘤右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節3_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節3_線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		節3_瘤左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節3_瘤右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節4_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節4_線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		節4_瘤左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節4_瘤右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節5_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節5_線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		節5_瘤左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節5_瘤右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		針_尾針CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		針_線1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		針_線2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		輪1_革CD = new ColorD();
    		輪1_金具1CD = new ColorD();
    		輪1_金具2CD = new ColorD();
    		輪1_金具3CD = new ColorD();
    		輪1_金具左CD = new ColorD();
    		輪1_金具右CD = new ColorD();
    		輪2_革CD = new ColorD();
    		輪2_金具1CD = new ColorD();
    		輪2_金具2CD = new ColorD();
    		輪2_金具3CD = new ColorD();
    		輪2_金具左CD = new ColorD();
    		輪2_金具右CD = new ColorD();
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		節1_尾CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節1_線CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節1_瘤左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節1_瘤右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節2_尾CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節2_線CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節2_瘤左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節2_瘤右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節3_尾CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節3_線CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節3_瘤左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節3_瘤右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節4_尾CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節4_線CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節4_瘤左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節4_瘤右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節5_尾CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		節5_線CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節5_瘤左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		節5_瘤右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		針_尾針CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		針_線1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		針_線2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		輪1_革CD = new ColorD();
    		輪1_金具1CD = new ColorD();
    		輪1_金具2CD = new ColorD();
    		輪1_金具3CD = new ColorD();
    		輪1_金具左CD = new ColorD();
    		輪1_金具右CD = new ColorD();
    		輪2_革CD = new ColorD();
    		輪2_金具1CD = new ColorD();
    		輪2_金具2CD = new ColorD();
    		輪2_金具3CD = new ColorD();
    		輪2_金具左CD = new ColorD();
    		輪2_金具右CD = new ColorD();
    	}

    	public void 輪1配色(拘束具色 配色)
    	{
    		輪1_革CD.色 = 配色.革部色;
    		輪1_金具1CD.色 = 配色.金具色;
    		輪1_金具2CD.色 = 輪1_金具1CD.色;
    		輪1_金具3CD.色 = 輪1_金具1CD.色;
    		輪1_金具左CD.色 = 輪1_金具1CD.色;
    		輪1_金具右CD.色 = 輪1_金具1CD.色;
    	}

    	public void 輪2配色(拘束具色 配色)
    	{
    		輪2_革CD.色 = 配色.革部色;
    		輪2_金具1CD.色 = 配色.金具色;
    		輪2_金具2CD.色 = 輪2_金具1CD.色;
    		輪2_金具3CD.色 = 輪2_金具1CD.色;
    		輪2_金具左CD.色 = 輪2_金具1CD.色;
    		輪2_金具右CD.色 = 輪2_金具1CD.色;
    	}

    	public void 鎖配色(鎖色 配色)
    	{
    		鎖1.配色鎖(配色);
    		鎖2.配色鎖(配色);
    		鎖3.配色鎖(配色);
    		鎖4.配色鎖(配色);
    	}
    }
}
