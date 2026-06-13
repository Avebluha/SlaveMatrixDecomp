using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 吹出し : Element
    {
    	public ShapePart X0Y0_吹出し;

    	public ColorD 吹出しCD;

    	public ColorP X0Y0_吹出しCP;

    	public Element[] 吹出し_接続;

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

    	public bool 吹出し_表示
    	{
    		get
    		{
    			return X0Y0_吹出し.Dra;
    		}
    		set
    		{
    			X0Y0_吹出し.Dra = value;
    			X0Y0_吹出し.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 吹出し_表示;
    		}
    		set
    		{
    			吹出し_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 吹出しCD.不透明度;
    		}
    		set
    		{
    			吹出しCD.不透明度 = value;
    		}
    	}

    	public JointS 吹出し_接続点 => new JointS(Body, X0Y0_吹出し, 0);

    	public 吹出し(double DisUnit)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid(Sta.胴体["吹出し"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_吹出し = partGroup["吹出し"].ToPar();
    		Body.SetJoints();
    		接続根 = new JointD(Body);
    		吹出しCD = new ColorD();
    		吹出しCD.線 = ColorHelper.Black;
    		吹出しCD.色 = new Color2(ref ColorHelper.White, ref ColorHelper.Empty);
    		X0Y0_吹出しCP = new ColorP(X0Y0_吹出し, 吹出しCD, DisUnit, abj: true);
    		X0Y0_吹出し.BasePointBase = X0Y0_吹出し.BasePointBase.AddX(-0.015);
    	}

    	public override void 色更新()
    	{
    		X0Y0_吹出しCP.Update();
    	}
    }
}
