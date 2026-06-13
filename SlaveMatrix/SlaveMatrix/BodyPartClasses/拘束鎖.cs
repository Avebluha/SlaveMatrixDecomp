using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 拘束鎖 : Ele
    {
    	public Par X0Y0_鎖2;

    	public Par X0Y0_鎖1;

    	public Par X0Y0_鎖4;

    	public Par X0Y0_鎖3;

    	public Par X0Y0_鎖6;

    	public Par X0Y0_鎖5;

    	public Par X0Y0_鎖8;

    	public Par X0Y0_鎖7;

    	public Par X0Y0_鎖9;

    	public ColorD 鎖2CD;

    	public ColorD 鎖1CD;

    	public ColorD 鎖4CD;

    	public ColorD 鎖3CD;

    	public ColorD 鎖6CD;

    	public ColorD 鎖5CD;

    	public ColorD 鎖8CD;

    	public ColorD 鎖7CD;

    	public ColorD 鎖9CD;

    	public ColorP X0Y0_鎖2CP;

    	public ColorP X0Y0_鎖1CP;

    	public ColorP X0Y0_鎖4CP;

    	public ColorP X0Y0_鎖3CP;

    	public ColorP X0Y0_鎖6CP;

    	public ColorP X0Y0_鎖5CP;

    	public ColorP X0Y0_鎖8CP;

    	public ColorP X0Y0_鎖7CP;

    	public ColorP X0Y0_鎖9CP;

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

    	public bool 鎖2_表示
    	{
    		get
    		{
    			return X0Y0_鎖2.Dra;
    		}
    		set
    		{
    			X0Y0_鎖2.Dra = value;
    			X0Y0_鎖2.Hit = false;
    		}
    	}

    	public bool 鎖1_表示
    	{
    		get
    		{
    			return X0Y0_鎖1.Dra;
    		}
    		set
    		{
    			X0Y0_鎖1.Dra = value;
    			X0Y0_鎖1.Hit = false;
    		}
    	}

    	public bool 鎖4_表示
    	{
    		get
    		{
    			return X0Y0_鎖4.Dra;
    		}
    		set
    		{
    			X0Y0_鎖4.Dra = value;
    			X0Y0_鎖4.Hit = false;
    		}
    	}

    	public bool 鎖3_表示
    	{
    		get
    		{
    			return X0Y0_鎖3.Dra;
    		}
    		set
    		{
    			X0Y0_鎖3.Dra = value;
    			X0Y0_鎖3.Hit = false;
    		}
    	}

    	public bool 鎖6_表示
    	{
    		get
    		{
    			return X0Y0_鎖6.Dra;
    		}
    		set
    		{
    			X0Y0_鎖6.Dra = value;
    			X0Y0_鎖6.Hit = false;
    		}
    	}

    	public bool 鎖5_表示
    	{
    		get
    		{
    			return X0Y0_鎖5.Dra;
    		}
    		set
    		{
    			X0Y0_鎖5.Dra = value;
    			X0Y0_鎖5.Hit = false;
    		}
    	}

    	public bool 鎖8_表示
    	{
    		get
    		{
    			return X0Y0_鎖8.Dra;
    		}
    		set
    		{
    			X0Y0_鎖8.Dra = false;
    			X0Y0_鎖8.Hit = false;
    		}
    	}

    	public bool 鎖7_表示
    	{
    		get
    		{
    			return X0Y0_鎖7.Dra;
    		}
    		set
    		{
    			X0Y0_鎖7.Dra = value;
    			X0Y0_鎖7.Hit = false;
    		}
    	}

    	public bool 鎖9_表示
    	{
    		get
    		{
    			return X0Y0_鎖9.Dra;
    		}
    		set
    		{
    			X0Y0_鎖9.Dra = false;
    			X0Y0_鎖9.Hit = false;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 鎖2_表示;
    		}
    		set
    		{
    			鎖2_表示 = value;
    			鎖1_表示 = value;
    			鎖4_表示 = value;
    			鎖3_表示 = value;
    			鎖6_表示 = value;
    			鎖5_表示 = value;
    			鎖8_表示 = value;
    			鎖7_表示 = value;
    			鎖9_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 鎖2CD.不透明度;
    		}
    		set
    		{
    			鎖2CD.不透明度 = value;
    			鎖1CD.不透明度 = value;
    			鎖4CD.不透明度 = value;
    			鎖3CD.不透明度 = value;
    			鎖6CD.不透明度 = value;
    			鎖5CD.不透明度 = value;
    			鎖8CD.不透明度 = value;
    			鎖7CD.不透明度 = value;
    			鎖9CD.不透明度 = value;
    		}
    	}

    	public 拘束鎖(double DisUnit, bool 右, 配色指定 配色指定, BodyColorSet 体配色, bool Xasix)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.その他["拘束鎖"]);
    		Pars pars = Body[0][0];
    		X0Y0_鎖2 = pars["鎖2"].ToPar();
    		X0Y0_鎖1 = pars["鎖1"].ToPar();
    		X0Y0_鎖4 = pars["鎖4"].ToPar();
    		X0Y0_鎖3 = pars["鎖3"].ToPar();
    		X0Y0_鎖6 = pars["鎖6"].ToPar();
    		X0Y0_鎖5 = pars["鎖5"].ToPar();
    		X0Y0_鎖8 = pars["鎖8"].ToPar();
    		X0Y0_鎖7 = pars["鎖7"].ToPar();
    		X0Y0_鎖9 = pars["鎖9"].ToPar();
    		Body.SetJoints();
    		接続根 = new JointD(Body);
    		if (Xasix)
    		{
    			角度B = 90.0;
    		}
    		this.右 = 右;
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_鎖2CP = new ColorP(X0Y0_鎖2, 鎖2CD, DisUnit, abj: true);
    		X0Y0_鎖1CP = new ColorP(X0Y0_鎖1, 鎖1CD, DisUnit, abj: true);
    		X0Y0_鎖4CP = new ColorP(X0Y0_鎖4, 鎖4CD, DisUnit, abj: true);
    		X0Y0_鎖3CP = new ColorP(X0Y0_鎖3, 鎖3CD, DisUnit, abj: true);
    		X0Y0_鎖6CP = new ColorP(X0Y0_鎖6, 鎖6CD, DisUnit, abj: true);
    		X0Y0_鎖5CP = new ColorP(X0Y0_鎖5, 鎖5CD, DisUnit, abj: true);
    		X0Y0_鎖8CP = new ColorP(X0Y0_鎖8, 鎖8CD, DisUnit, abj: true);
    		X0Y0_鎖7CP = new ColorP(X0Y0_鎖7, 鎖7CD, DisUnit, abj: true);
    		X0Y0_鎖9CP = new ColorP(X0Y0_鎖9, 鎖9CD, DisUnit, abj: true);
    		鎖色 鎖色2 = default(鎖色);
    		鎖色2.SetDefault();
    		配色鎖(鎖色2);
    	}

    	public void SetSize()
    	{
    		Par par = 接続根.Difs0.Current.GetPar(接続根.Path0);
    		if (par.JP.Count <= 0)
    		{
    			return;
    		}
    		int num = 0;
    		Vector2D vec2DZero = DataConsts.Vec2DZero;
    		foreach (Out item in par.OP)
    		{
    			foreach (Vector2D item2 in item.ps.Skip(1).Take(item.ps.Count - 2))
    			{
    				vec2DZero += item2;
    				num++;
    			}
    		}
    		par.JP[0] = new Joi(vec2DZero / num);
    		接続P();
    		尺度B = (par.GetArea() / X0Y0_鎖1.GetArea()).Sqrt() * 1.2;
    	}

    	public override bool Is鉄(Par p)
    	{
    		if (X0Y0_鎖2 != p && X0Y0_鎖1 != p && X0Y0_鎖4 != p && X0Y0_鎖3 != p && X0Y0_鎖6 != p && X0Y0_鎖5 != p && X0Y0_鎖8 != p && X0Y0_鎖7 != p)
    		{
    			return X0Y0_鎖9 == p;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_鎖2CP.Update();
    		X0Y0_鎖1CP.Update();
    		X0Y0_鎖4CP.Update();
    		X0Y0_鎖3CP.Update();
    		X0Y0_鎖6CP.Update();
    		X0Y0_鎖5CP.Update();
    		X0Y0_鎖8CP.Update();
    		X0Y0_鎖7CP.Update();
    		X0Y0_鎖9CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		鎖2CD = new ColorD();
    		鎖1CD = new ColorD();
    		鎖4CD = new ColorD();
    		鎖3CD = new ColorD();
    		鎖6CD = new ColorD();
    		鎖5CD = new ColorD();
    		鎖8CD = new ColorD();
    		鎖7CD = new ColorD();
    		鎖9CD = new ColorD();
    		double num = 1.0;
    		double num2 = num / 7.0;
    		鎖1CD.不透明度 = num;
    		num -= num2;
    		鎖2CD.不透明度 = num;
    		num -= num2;
    		鎖3CD.不透明度 = num;
    		num -= num2;
    		鎖4CD.不透明度 = num;
    		num -= num2;
    		鎖5CD.不透明度 = num;
    		num -= num2;
    		鎖6CD.不透明度 = num;
    		num -= num2;
    		鎖7CD.不透明度 = num;
    	}

    	public void 配色鎖(鎖色 鎖色)
    	{
    		鎖1CD.色 = 鎖色.金属色;
    		鎖2CD.色 = 鎖色.金属色;
    		鎖3CD.色 = 鎖色.金属色;
    		鎖4CD.色 = 鎖色.金属色;
    		鎖5CD.色 = 鎖色.金属色;
    		鎖6CD.色 = 鎖色.金属色;
    		鎖7CD.色 = 鎖色.金属色;
    		鎖8CD.色 = 鎖色.金属色;
    		鎖9CD.色 = 鎖色.金属色;
    		double num = 1.0;
    		double num2 = num / 7.0;
    		鎖1CD.不透明度 = num;
    		num -= num2;
    		鎖2CD.不透明度 = num;
    		num -= num2;
    		鎖3CD.不透明度 = num;
    		num -= num2;
    		鎖4CD.不透明度 = num;
    		num -= num2;
    		鎖5CD.不透明度 = num;
    		num -= num2;
    		鎖6CD.不透明度 = num;
    		num -= num2;
    		鎖7CD.不透明度 = num;
    	}
    }
}
