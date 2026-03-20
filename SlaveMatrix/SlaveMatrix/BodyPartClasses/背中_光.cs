using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 背中_光 : 背中
    {
    	public Par X0Y0_後光左;

    	public Par X0Y0_後光右;

    	public ColorD 後光CD;

    	public ColorP X0Y0_後光左CP;

    	public ColorP X0Y0_後光右CP;

    	private Par[] Pars;

    	private Vector2D[] mm;

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

    	public bool 後光左_表示
    	{
    		get
    		{
    			return X0Y0_後光左.Dra;
    		}
    		set
    		{
    			X0Y0_後光左.Dra = value;
    			X0Y0_後光左.Hit = value;
    		}
    	}

    	public bool 後光右_表示
    	{
    		get
    		{
    			return X0Y0_後光右.Dra;
    		}
    		set
    		{
    			X0Y0_後光右.Dra = value;
    			X0Y0_後光右.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 後光左_表示;
    		}
    		set
    		{
    			後光左_表示 = value;
    			後光右_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 後光CD.不透明度;
    		}
    		set
    		{
    			後光CD.不透明度 = value;
    		}
    	}

    	public 背中_光(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 背中_光D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "後光";
    		dif.Add(new Pars(Sta.肢中["背中"][0][2]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_後光左 = pars["後光左"].ToPar();
    		X0Y0_後光右 = pars["後光右"].ToPar();
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
    		後光左_表示 = e.後光左_表示;
    		後光右_表示 = e.後光右_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		Pars = new Par[2] { X0Y0_後光左, X0Y0_後光右 };
    		X0Y0_後光左CP = new ColorP(X0Y0_後光左, 後光CD, DisUnit, abj: true);
    		X0Y0_後光右CP = new ColorP(X0Y0_後光右, 後光CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		Pars.GetMiY_MaY(out mm);
    		X0Y0_後光左CP.Update(mm);
    		X0Y0_後光右CP.Update(mm);
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		後光CD = new ColorD(ref Col.Empty, ref 体配色.後光O);
    	}
    }
}
