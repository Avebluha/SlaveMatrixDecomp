using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 尾_悪 : 尾
    {
    	public ShapePart X0Y0_尾0;

    	public ShapePart X0Y0_尾1;

    	public ShapePart X0Y0_尾2;

    	public ShapePart X0Y0_尾3;

    	public ShapePart X0Y0_尾4;

    	public ShapePart X0Y0_尾5;

    	public ShapePart X0Y0_尾6;

    	public ShapePart X0Y0_尾7;

    	public ShapePart X0Y0_尾8;

    	public ShapePart X0Y0_輪_革;

    	public ShapePart X0Y0_輪_金具1;

    	public ShapePart X0Y0_輪_金具2;

    	public ShapePart X0Y0_輪_金具3;

    	public ShapePart X0Y0_輪_金具左;

    	public ShapePart X0Y0_輪_金具右;

    	public ShapePart X0Y0_尾9;

    	public ShapePart X0Y0_尾10;

    	public ShapePart X0Y0_尾11;

    	public ShapePart X0Y0_尾12;

    	public ShapePart X0Y0_尾13;

    	public ShapePart X0Y0_尾14;

    	public ShapePart X0Y0_尾15;

    	public ShapePart X0Y0_尾16;

    	public ShapePart X0Y0_尾17;

    	public ShapePart X0Y0_先端_先;

    	public ShapePart X0Y0_先端_尾;

    	public ColorD 尾0CD;

    	public ColorD 尾1CD;

    	public ColorD 尾2CD;

    	public ColorD 尾3CD;

    	public ColorD 尾4CD;

    	public ColorD 尾5CD;

    	public ColorD 尾6CD;

    	public ColorD 尾7CD;

    	public ColorD 尾8CD;

    	public ColorD 尾9CD;

    	public ColorD 尾10CD;

    	public ColorD 尾11CD;

    	public ColorD 尾12CD;

    	public ColorD 尾13CD;

    	public ColorD 尾14CD;

    	public ColorD 尾15CD;

    	public ColorD 尾16CD;

    	public ColorD 尾17CD;

    	public ColorD 先端_先CD;

    	public ColorD 先端_尾CD;

    	public ColorD 輪_革CD;

    	public ColorD 輪_金具1CD;

    	public ColorD 輪_金具2CD;

    	public ColorD 輪_金具3CD;

    	public ColorD 輪_金具左CD;

    	public ColorD 輪_金具右CD;

    	public ColorP X0Y0_尾0CP;

    	public ColorP X0Y0_尾1CP;

    	public ColorP X0Y0_尾2CP;

    	public ColorP X0Y0_尾3CP;

    	public ColorP X0Y0_尾4CP;

    	public ColorP X0Y0_尾5CP;

    	public ColorP X0Y0_尾6CP;

    	public ColorP X0Y0_尾7CP;

    	public ColorP X0Y0_尾8CP;

    	public ColorP X0Y0_輪_革CP;

    	public ColorP X0Y0_輪_金具1CP;

    	public ColorP X0Y0_輪_金具2CP;

    	public ColorP X0Y0_輪_金具3CP;

    	public ColorP X0Y0_輪_金具左CP;

    	public ColorP X0Y0_輪_金具右CP;

    	public ColorP X0Y0_尾9CP;

    	public ColorP X0Y0_尾10CP;

    	public ColorP X0Y0_尾11CP;

    	public ColorP X0Y0_尾12CP;

    	public ColorP X0Y0_尾13CP;

    	public ColorP X0Y0_尾14CP;

    	public ColorP X0Y0_尾15CP;

    	public ColorP X0Y0_尾16CP;

    	public ColorP X0Y0_尾17CP;

    	public ColorP X0Y0_先端_先CP;

    	public ColorP X0Y0_先端_尾CP;

    	public 拘束鎖 鎖1;

    	public 拘束鎖 鎖2;

    	public ShapePart[] Pars;

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
    			輪表示 = 拘束_;
    		}
    	}

    	public bool 尾0_表示
    	{
    		get
    		{
    			return X0Y0_尾0.Dra;
    		}
    		set
    		{
    			X0Y0_尾0.Dra = value;
    			X0Y0_尾0.Hit = value;
    		}
    	}

    	public bool 尾1_表示
    	{
    		get
    		{
    			return X0Y0_尾1.Dra;
    		}
    		set
    		{
    			X0Y0_尾1.Dra = value;
    			X0Y0_尾1.Hit = value;
    		}
    	}

    	public bool 尾2_表示
    	{
    		get
    		{
    			return X0Y0_尾2.Dra;
    		}
    		set
    		{
    			X0Y0_尾2.Dra = value;
    			X0Y0_尾2.Hit = value;
    		}
    	}

    	public bool 尾3_表示
    	{
    		get
    		{
    			return X0Y0_尾3.Dra;
    		}
    		set
    		{
    			X0Y0_尾3.Dra = value;
    			X0Y0_尾3.Hit = value;
    		}
    	}

    	public bool 尾4_表示
    	{
    		get
    		{
    			return X0Y0_尾4.Dra;
    		}
    		set
    		{
    			X0Y0_尾4.Dra = value;
    			X0Y0_尾4.Hit = value;
    		}
    	}

    	public bool 尾5_表示
    	{
    		get
    		{
    			return X0Y0_尾5.Dra;
    		}
    		set
    		{
    			X0Y0_尾5.Dra = value;
    			X0Y0_尾5.Hit = value;
    		}
    	}

    	public bool 尾6_表示
    	{
    		get
    		{
    			return X0Y0_尾6.Dra;
    		}
    		set
    		{
    			X0Y0_尾6.Dra = value;
    			X0Y0_尾6.Hit = value;
    		}
    	}

    	public bool 尾7_表示
    	{
    		get
    		{
    			return X0Y0_尾7.Dra;
    		}
    		set
    		{
    			X0Y0_尾7.Dra = value;
    			X0Y0_尾7.Hit = value;
    		}
    	}

    	public bool 尾8_表示
    	{
    		get
    		{
    			return X0Y0_尾8.Dra;
    		}
    		set
    		{
    			X0Y0_尾8.Dra = value;
    			X0Y0_尾8.Hit = value;
    		}
    	}

    	public bool 輪_革_表示
    	{
    		get
    		{
    			return X0Y0_輪_革.Dra;
    		}
    		set
    		{
    			X0Y0_輪_革.Dra = value;
    			X0Y0_輪_革.Hit = value;
    		}
    	}

    	public bool 輪_金具1_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具1.Dra = value;
    			X0Y0_輪_金具1.Hit = value;
    		}
    	}

    	public bool 輪_金具2_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具2.Dra = value;
    			X0Y0_輪_金具2.Hit = value;
    		}
    	}

    	public bool 輪_金具3_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具3.Dra = value;
    			X0Y0_輪_金具3.Hit = value;
    		}
    	}

    	public bool 輪_金具左_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具左.Dra = value;
    			X0Y0_輪_金具左.Hit = value;
    		}
    	}

    	public bool 輪_金具右_表示
    	{
    		get
    		{
    			return X0Y0_輪_金具右.Dra;
    		}
    		set
    		{
    			X0Y0_輪_金具右.Dra = value;
    			X0Y0_輪_金具右.Hit = value;
    		}
    	}

    	public bool 尾9_表示
    	{
    		get
    		{
    			return X0Y0_尾9.Dra;
    		}
    		set
    		{
    			X0Y0_尾9.Dra = value;
    			X0Y0_尾9.Hit = value;
    		}
    	}

    	public bool 尾10_表示
    	{
    		get
    		{
    			return X0Y0_尾10.Dra;
    		}
    		set
    		{
    			X0Y0_尾10.Dra = value;
    			X0Y0_尾10.Hit = value;
    		}
    	}

    	public bool 尾11_表示
    	{
    		get
    		{
    			return X0Y0_尾11.Dra;
    		}
    		set
    		{
    			X0Y0_尾11.Dra = value;
    			X0Y0_尾11.Hit = value;
    		}
    	}

    	public bool 尾12_表示
    	{
    		get
    		{
    			return X0Y0_尾12.Dra;
    		}
    		set
    		{
    			X0Y0_尾12.Dra = value;
    			X0Y0_尾12.Hit = value;
    		}
    	}

    	public bool 尾13_表示
    	{
    		get
    		{
    			return X0Y0_尾13.Dra;
    		}
    		set
    		{
    			X0Y0_尾13.Dra = value;
    			X0Y0_尾13.Hit = value;
    		}
    	}

    	public bool 尾14_表示
    	{
    		get
    		{
    			return X0Y0_尾14.Dra;
    		}
    		set
    		{
    			X0Y0_尾14.Dra = value;
    			X0Y0_尾14.Hit = value;
    		}
    	}

    	public bool 尾15_表示
    	{
    		get
    		{
    			return X0Y0_尾15.Dra;
    		}
    		set
    		{
    			X0Y0_尾15.Dra = value;
    			X0Y0_尾15.Hit = value;
    		}
    	}

    	public bool 尾16_表示
    	{
    		get
    		{
    			return X0Y0_尾16.Dra;
    		}
    		set
    		{
    			X0Y0_尾16.Dra = value;
    			X0Y0_尾16.Hit = value;
    		}
    	}

    	public bool 尾17_表示
    	{
    		get
    		{
    			return X0Y0_尾17.Dra;
    		}
    		set
    		{
    			X0Y0_尾17.Dra = value;
    			X0Y0_尾17.Hit = value;
    		}
    	}

    	public bool 先端_先_表示
    	{
    		get
    		{
    			return X0Y0_先端_先.Dra;
    		}
    		set
    		{
    			X0Y0_先端_先.Dra = value;
    			X0Y0_先端_先.Hit = value;
    		}
    	}

    	public bool 先端_尾_表示
    	{
    		get
    		{
    			return X0Y0_先端_尾.Dra;
    		}
    		set
    		{
    			X0Y0_先端_尾.Dra = value;
    			X0Y0_先端_尾.Hit = value;
    		}
    	}

    	public bool 輪表示
    	{
    		get
    		{
    			return 輪_革_表示;
    		}
    		set
    		{
    			輪_革_表示 = value;
    			輪_金具1_表示 = value;
    			輪_金具2_表示 = value;
    			輪_金具3_表示 = value;
    			輪_金具左_表示 = value;
    			輪_金具右_表示 = value;
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
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 尾0_表示;
    		}
    		set
    		{
    			尾0_表示 = value;
    			尾1_表示 = value;
    			尾2_表示 = value;
    			尾3_表示 = value;
    			尾4_表示 = value;
    			尾5_表示 = value;
    			尾6_表示 = value;
    			尾7_表示 = value;
    			尾8_表示 = value;
    			輪_革_表示 = value;
    			輪_金具1_表示 = value;
    			輪_金具2_表示 = value;
    			輪_金具3_表示 = value;
    			輪_金具左_表示 = value;
    			輪_金具右_表示 = value;
    			尾9_表示 = value;
    			尾10_表示 = value;
    			尾11_表示 = value;
    			尾12_表示 = value;
    			尾13_表示 = value;
    			尾14_表示 = value;
    			尾15_表示 = value;
    			尾16_表示 = value;
    			尾17_表示 = value;
    			先端_先_表示 = value;
    			先端_尾_表示 = value;
    			鎖1.表示 = value;
    			鎖2.表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 尾0CD.不透明度;
    		}
    		set
    		{
    			尾0CD.不透明度 = value;
    			尾1CD.不透明度 = value;
    			尾2CD.不透明度 = value;
    			尾3CD.不透明度 = value;
    			尾4CD.不透明度 = value;
    			尾5CD.不透明度 = value;
    			尾6CD.不透明度 = value;
    			尾7CD.不透明度 = value;
    			尾8CD.不透明度 = value;
    			尾9CD.不透明度 = value;
    			尾10CD.不透明度 = value;
    			尾11CD.不透明度 = value;
    			尾12CD.不透明度 = value;
    			尾13CD.不透明度 = value;
    			尾14CD.不透明度 = value;
    			尾15CD.不透明度 = value;
    			尾16CD.不透明度 = value;
    			尾17CD.不透明度 = value;
    			先端_先CD.不透明度 = value;
    			先端_尾CD.不透明度 = value;
    			輪_革CD.不透明度 = value;
    			輪_金具1CD.不透明度 = value;
    			輪_金具2CD.不透明度 = value;
    			輪_金具3CD.不透明度 = value;
    			輪_金具左CD.不透明度 = value;
    			輪_金具右CD.不透明度 = value;
    		}
    	}

    	public JointS 鎖1_接続点 => new JointS(Body, X0Y0_輪_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(Body, X0Y0_輪_金具右, 0);

    	public 尾_悪(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 尾_悪D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant();
    		morphVariant.Tag = "悪尾";
    		morphVariant.Add(new PartGroup(Sta.尻尾["尾"][0][7]));
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_尾0 = partGroup["尾0"].ToPar();
    		X0Y0_尾1 = partGroup["尾1"].ToPar();
    		X0Y0_尾2 = partGroup["尾2"].ToPar();
    		X0Y0_尾3 = partGroup["尾3"].ToPar();
    		X0Y0_尾4 = partGroup["尾4"].ToPar();
    		X0Y0_尾5 = partGroup["尾5"].ToPar();
    		X0Y0_尾6 = partGroup["尾6"].ToPar();
    		X0Y0_尾7 = partGroup["尾7"].ToPar();
    		X0Y0_尾8 = partGroup["尾8"].ToPar();
    		PartGroup pars2 = partGroup["輪"].ToPars();
    		X0Y0_輪_革 = pars2["革"].ToPar();
    		X0Y0_輪_金具1 = pars2["金具1"].ToPar();
    		X0Y0_輪_金具2 = pars2["金具2"].ToPar();
    		X0Y0_輪_金具3 = pars2["金具3"].ToPar();
    		X0Y0_輪_金具左 = pars2["金具左"].ToPar();
    		X0Y0_輪_金具右 = pars2["金具右"].ToPar();
    		X0Y0_尾9 = partGroup["尾9"].ToPar();
    		X0Y0_尾10 = partGroup["尾10"].ToPar();
    		X0Y0_尾11 = partGroup["尾11"].ToPar();
    		X0Y0_尾12 = partGroup["尾12"].ToPar();
    		X0Y0_尾13 = partGroup["尾13"].ToPar();
    		X0Y0_尾14 = partGroup["尾14"].ToPar();
    		X0Y0_尾15 = partGroup["尾15"].ToPar();
    		X0Y0_尾16 = partGroup["尾16"].ToPar();
    		X0Y0_尾17 = partGroup["尾17"].ToPar();
    		pars2 = partGroup["先端"].ToPars();
    		X0Y0_先端_先 = pars2["先"].ToPar();
    		X0Y0_先端_尾 = pars2["尾"].ToPar();
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
    		尾0_表示 = e.尾0_表示;
    		尾1_表示 = e.尾1_表示;
    		尾2_表示 = e.尾2_表示;
    		尾3_表示 = e.尾3_表示;
    		尾4_表示 = e.尾4_表示;
    		尾5_表示 = e.尾5_表示;
    		尾6_表示 = e.尾6_表示;
    		尾7_表示 = e.尾7_表示;
    		尾8_表示 = e.尾8_表示;
    		輪_革_表示 = e.輪_革_表示;
    		輪_金具1_表示 = e.輪_金具1_表示;
    		輪_金具2_表示 = e.輪_金具2_表示;
    		輪_金具3_表示 = e.輪_金具3_表示;
    		輪_金具左_表示 = e.輪_金具左_表示;
    		輪_金具右_表示 = e.輪_金具右_表示;
    		尾9_表示 = e.尾9_表示;
    		尾10_表示 = e.尾10_表示;
    		尾11_表示 = e.尾11_表示;
    		尾12_表示 = e.尾12_表示;
    		尾13_表示 = e.尾13_表示;
    		尾14_表示 = e.尾14_表示;
    		尾15_表示 = e.尾15_表示;
    		尾16_表示 = e.尾16_表示;
    		尾17_表示 = e.尾17_表示;
    		先端_先_表示 = e.先端_先_表示;
    		先端_尾_表示 = e.先端_尾_表示;
    		輪表示 = e.輪表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		Pars = new ShapePart[26]
    		{
    			X0Y0_尾0, X0Y0_尾1, X0Y0_尾2, X0Y0_尾3, X0Y0_尾4, X0Y0_尾5, X0Y0_尾6, X0Y0_尾7, X0Y0_尾8, X0Y0_輪_革,
    			X0Y0_輪_金具1, X0Y0_輪_金具2, X0Y0_輪_金具3, X0Y0_輪_金具左, X0Y0_輪_金具右, X0Y0_尾9, X0Y0_尾10, X0Y0_尾11, X0Y0_尾12, X0Y0_尾13,
    			X0Y0_尾14, X0Y0_尾15, X0Y0_尾16, X0Y0_尾17, X0Y0_先端_先, X0Y0_先端_尾
    		};
    		X0Y0_尾0CP = new ColorP(X0Y0_尾0, 尾0CD, DisUnit, abj: true);
    		X0Y0_尾1CP = new ColorP(X0Y0_尾1, 尾1CD, DisUnit, abj: true);
    		X0Y0_尾2CP = new ColorP(X0Y0_尾2, 尾2CD, DisUnit, abj: true);
    		X0Y0_尾3CP = new ColorP(X0Y0_尾3, 尾3CD, DisUnit, abj: true);
    		X0Y0_尾4CP = new ColorP(X0Y0_尾4, 尾4CD, DisUnit, abj: true);
    		X0Y0_尾5CP = new ColorP(X0Y0_尾5, 尾5CD, DisUnit, abj: true);
    		X0Y0_尾6CP = new ColorP(X0Y0_尾6, 尾6CD, DisUnit, abj: true);
    		X0Y0_尾7CP = new ColorP(X0Y0_尾7, 尾7CD, DisUnit, abj: true);
    		X0Y0_尾8CP = new ColorP(X0Y0_尾8, 尾8CD, DisUnit, abj: true);
    		X0Y0_輪_革CP = new ColorP(X0Y0_輪_革, 輪_革CD, DisUnit, abj: true);
    		X0Y0_輪_金具1CP = new ColorP(X0Y0_輪_金具1, 輪_金具1CD, DisUnit, abj: true);
    		X0Y0_輪_金具2CP = new ColorP(X0Y0_輪_金具2, 輪_金具2CD, DisUnit, abj: true);
    		X0Y0_輪_金具3CP = new ColorP(X0Y0_輪_金具3, 輪_金具3CD, DisUnit, abj: true);
    		X0Y0_輪_金具左CP = new ColorP(X0Y0_輪_金具左, 輪_金具左CD, DisUnit, abj: true);
    		X0Y0_輪_金具右CP = new ColorP(X0Y0_輪_金具右, 輪_金具右CD, DisUnit, abj: true);
    		X0Y0_尾9CP = new ColorP(X0Y0_尾9, 尾9CD, DisUnit, abj: true);
    		X0Y0_尾10CP = new ColorP(X0Y0_尾10, 尾10CD, DisUnit, abj: true);
    		X0Y0_尾11CP = new ColorP(X0Y0_尾11, 尾11CD, DisUnit, abj: true);
    		X0Y0_尾12CP = new ColorP(X0Y0_尾12, 尾12CD, DisUnit, abj: true);
    		X0Y0_尾13CP = new ColorP(X0Y0_尾13, 尾13CD, DisUnit, abj: true);
    		X0Y0_尾14CP = new ColorP(X0Y0_尾14, 尾14CD, DisUnit, abj: true);
    		X0Y0_尾15CP = new ColorP(X0Y0_尾15, 尾15CD, DisUnit, abj: true);
    		X0Y0_尾16CP = new ColorP(X0Y0_尾16, 尾16CD, DisUnit, abj: true);
    		X0Y0_尾17CP = new ColorP(X0Y0_尾17, 尾17CD, DisUnit, abj: true);
    		X0Y0_先端_先CP = new ColorP(X0Y0_先端_先, 先端_先CD, DisUnit, abj: true);
    		X0Y0_先端_尾CP = new ColorP(X0Y0_先端_尾, 先端_尾CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		鎖1 = new 拘束鎖(DisUnit, 右, 配色指定, 体配色, Xasix);
    		鎖2 = new 拘束鎖(DisUnit, !右, 配色指定, 体配色, Xasix);
    		鎖1.接続(鎖1_接続点);
    		鎖2.接続(鎖2_接続点);
    		int num = (右 ? (-10) : 10);
    		鎖1.角度B -= num;
    		鎖2.角度B += num;
    		鎖表示 = e.鎖表示;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_尾0);
    		Are.Draw(X0Y0_尾1);
    		Are.Draw(X0Y0_尾2);
    		Are.Draw(X0Y0_尾3);
    		Are.Draw(X0Y0_尾4);
    		Are.Draw(X0Y0_尾5);
    		Are.Draw(X0Y0_尾6);
    		Are.Draw(X0Y0_尾7);
    		Are.Draw(X0Y0_尾8);
    		Are.Draw(X0Y0_輪_革);
    		Are.Draw(X0Y0_輪_金具1);
    		Are.Draw(X0Y0_輪_金具2);
    		Are.Draw(X0Y0_輪_金具3);
    		Are.Draw(X0Y0_輪_金具左);
    		Are.Draw(X0Y0_輪_金具右);
    		鎖1.描画0(Are);
    		鎖2.描画0(Are);
    		Are.Draw(X0Y0_尾9);
    		Are.Draw(X0Y0_尾10);
    		Are.Draw(X0Y0_尾11);
    		Are.Draw(X0Y0_尾12);
    		Are.Draw(X0Y0_尾13);
    		Are.Draw(X0Y0_尾14);
    		Are.Draw(X0Y0_尾15);
    		Are.Draw(X0Y0_尾16);
    		Are.Draw(X0Y0_尾17);
    		Are.Draw(X0Y0_先端_先);
    		Are.Draw(X0Y0_先端_尾);
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    		鎖2.Dispose();
    	}

    	public override void SetAngle0()
    	{
    		_ = 右;
    		double maxAngle = 20.0;
    		X0Y0_尾0.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾1.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾2.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾3.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾4.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾5.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾6.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾7.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾8.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾9.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾10.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾11.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾12.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾13.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾14.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾15.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾16.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾17.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_先端_尾.AngleBase = maxAngle.GetRanAngle();
    		Body.JoinPAall();
    	}

    	public override bool Is革(ShapePart p)
    	{
    		if (p != X0Y0_輪_革 && p != X0Y0_輪_金具1 && p != X0Y0_輪_金具2 && p != X0Y0_輪_金具3 && p != X0Y0_輪_金具左)
    		{
    			return p == X0Y0_輪_金具右;
    		}
    		return true;
    	}

    	public override IEnumerable<ShapePart> Enum軸()
    	{
    		yield return X0Y0_尾0;
    		yield return X0Y0_尾1;
    		yield return X0Y0_尾2;
    		yield return X0Y0_尾3;
    		yield return X0Y0_尾4;
    		yield return X0Y0_尾5;
    		yield return X0Y0_尾6;
    		yield return X0Y0_尾7;
    		yield return X0Y0_尾8;
    		yield return X0Y0_尾9;
    		yield return X0Y0_尾10;
    		yield return X0Y0_尾11;
    		yield return X0Y0_尾12;
    		yield return X0Y0_尾13;
    		yield return X0Y0_尾14;
    		yield return X0Y0_尾15;
    		yield return X0Y0_尾16;
    		yield return X0Y0_尾17;
    		yield return X0Y0_先端_尾;
    	}

    	public override void 色更新()
    	{
    		Pars.GetMiY_MaY(out mm);
    		X0Y0_尾0CP.Update(mm);
    		X0Y0_尾1CP.Update(mm);
    		X0Y0_尾2CP.Update(mm);
    		X0Y0_尾3CP.Update(mm);
    		X0Y0_尾4CP.Update(mm);
    		X0Y0_尾5CP.Update(mm);
    		X0Y0_尾6CP.Update(mm);
    		X0Y0_尾7CP.Update(mm);
    		X0Y0_尾8CP.Update(mm);
    		X0Y0_輪_革CP.Update();
    		X0Y0_輪_金具1CP.Update();
    		X0Y0_輪_金具2CP.Update();
    		X0Y0_輪_金具3CP.Update();
    		X0Y0_輪_金具左CP.Update();
    		X0Y0_輪_金具右CP.Update();
    		X0Y0_尾9CP.Update(mm);
    		X0Y0_尾10CP.Update(mm);
    		X0Y0_尾11CP.Update(mm);
    		X0Y0_尾12CP.Update(mm);
    		X0Y0_尾13CP.Update(mm);
    		X0Y0_尾14CP.Update(mm);
    		X0Y0_尾15CP.Update(mm);
    		X0Y0_尾16CP.Update(mm);
    		X0Y0_尾17CP.Update(mm);
    		X0Y0_先端_先CP.Update(mm);
    		X0Y0_先端_尾CP.Update(mm);
    		鎖1.接続PA();
    		鎖2.接続PA();
    		鎖1.色更新();
    		鎖2.色更新();
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
    		尾0CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾1CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾2CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾3CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾4CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾5CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾6CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾7CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾8CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾9CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾10CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾11CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾12CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾13CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾14CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾15CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾16CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		尾17CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		先端_先CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		先端_尾CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		this.配色T(0, "尾", ref 体配色.体0O, ref 体配色.刺青O);
    		先端_先CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		this.配色T(1, "尾", ref 体配色.体0O, ref 体配色.刺青O);
    		先端_先CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		輪_革CD = new ColorD();
    		輪_金具1CD = new ColorD();
    		輪_金具2CD = new ColorD();
    		輪_金具3CD = new ColorD();
    		輪_金具左CD = new ColorD();
    		輪_金具右CD = new ColorD();
    	}

    	public void 輪配色(拘束具色 配色)
    	{
    		輪_革CD.色 = 配色.革部色;
    		輪_金具1CD.色 = 配色.金具色;
    		輪_金具2CD.色 = 輪_金具1CD.色;
    		輪_金具3CD.色 = 輪_金具1CD.色;
    		輪_金具左CD.色 = 輪_金具1CD.色;
    		輪_金具右CD.色 = 輪_金具1CD.色;
    	}

    	public void 鎖配色(鎖色 配色)
    	{
    		鎖1.配色鎖(配色);
    		鎖2.配色鎖(配色);
    	}
    }
}
