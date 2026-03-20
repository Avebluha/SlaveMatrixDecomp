using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 胴腹板 : Ele
    {
    	public Par X0Y0_虫性_腹板;

    	public Par X0Y0_虫性_縦線;

    	public ColorD 虫性_腹板CD;

    	public ColorD 虫性_縦線CD;

    	public ColorP X0Y0_虫性_腹板CP;

    	public ColorP X0Y0_虫性_縦線CP;

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

    	public bool 虫性_腹板_表示
    	{
    		get
    		{
    			return X0Y0_虫性_腹板.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_腹板.Dra = value;
    			X0Y0_虫性_腹板.Hit = value;
    		}
    	}

    	public bool 虫性_縦線_表示
    	{
    		get
    		{
    			return X0Y0_虫性_縦線.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_縦線.Dra = value;
    			X0Y0_虫性_縦線.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 虫性_腹板_表示;
    		}
    		set
    		{
    			虫性_腹板_表示 = value;
    			虫性_縦線_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 虫性_腹板CD.不透明度;
    		}
    		set
    		{
    			虫性_腹板CD.不透明度 = value;
    			虫性_縦線CD.不透明度 = value;
    		}
    	}

    	public 胴腹板(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 胴腹板D e)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.胴体["胴腹板"]);
    		Pars pars = Body[0][0];
    		X0Y0_虫性_腹板 = pars["腹板"].ToPar();
    		X0Y0_虫性_縦線 = pars["縦線"].ToPar();
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
    		虫性_腹板_表示 = e.虫性_腹板_表示;
    		虫性_縦線_表示 = e.虫性_縦線_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_虫性_腹板CP = new ColorP(X0Y0_虫性_腹板, 虫性_腹板CD, DisUnit, abj: true);
    		X0Y0_虫性_縦線CP = new ColorP(X0Y0_虫性_縦線, 虫性_縦線CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		尺度YB = 0.95;
    	}

    	public override void 色更新()
    	{
    		X0Y0_虫性_腹板CP.Update();
    		X0Y0_虫性_縦線CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		虫性_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫性_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    	}
    }
}
