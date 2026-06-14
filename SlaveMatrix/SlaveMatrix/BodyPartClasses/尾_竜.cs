using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 尾_竜 : 尾
    {
    	public ShapePart X0Y0_尾17;

    	public ShapePart X0Y0_針;

    	public ShapePart X0Y0_輪2_革;

    	public ShapePart X0Y0_輪2_金具1;

    	public ShapePart X0Y0_輪2_金具2;

    	public ShapePart X0Y0_輪2_金具3;

    	public ShapePart X0Y0_輪2_金具左;

    	public ShapePart X0Y0_輪2_金具右;

    	public ShapePart X0Y0_尾16;

    	public ShapePart X0Y0_尾15;

    	public ShapePart X0Y0_尾14;

    	public ShapePart X0Y0_尾13;

    	public ShapePart X0Y0_尾12;

    	public ShapePart X0Y0_尾11;

    	public ShapePart X0Y0_尾10;

    	public ShapePart X0Y0_尾9;

    	public ShapePart X0Y0_尾8;

    	public ShapePart X0Y0_尾7;

    	public ShapePart X0Y0_輪1_革;

    	public ShapePart X0Y0_輪1_金具1;

    	public ShapePart X0Y0_輪1_金具2;

    	public ShapePart X0Y0_輪1_金具3;

    	public ShapePart X0Y0_輪1_金具左;

    	public ShapePart X0Y0_輪1_金具右;

    	public ShapePart X0Y0_尾6;

    	public ShapePart X0Y0_尾5;

    	public ShapePart X0Y0_尾4;

    	public ShapePart X0Y0_尾3;

    	public ShapePart X0Y0_尾2;

    	public ShapePart X0Y0_尾1;

    	public ShapePart X0Y0_尾0;

    	public ColorD 尾17CD;

    	public ColorD 針CD;

    	public ColorD 尾16CD;

    	public ColorD 尾15CD;

    	public ColorD 尾14CD;

    	public ColorD 尾13CD;

    	public ColorD 尾12CD;

    	public ColorD 尾11CD;

    	public ColorD 尾10CD;

    	public ColorD 尾9CD;

    	public ColorD 尾8CD;

    	public ColorD 尾7CD;

    	public ColorD 尾6CD;

    	public ColorD 尾5CD;

    	public ColorD 尾4CD;

    	public ColorD 尾3CD;

    	public ColorD 尾2CD;

    	public ColorD 尾1CD;

    	public ColorD 尾0CD;

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

    	public ColorP X0Y0_尾17CP;

    	public ColorP X0Y0_針CP;

    	public ColorP X0Y0_輪2_革CP;

    	public ColorP X0Y0_輪2_金具1CP;

    	public ColorP X0Y0_輪2_金具2CP;

    	public ColorP X0Y0_輪2_金具3CP;

    	public ColorP X0Y0_輪2_金具左CP;

    	public ColorP X0Y0_輪2_金具右CP;

    	public ColorP X0Y0_尾16CP;

    	public ColorP X0Y0_尾15CP;

    	public ColorP X0Y0_尾14CP;

    	public ColorP X0Y0_尾13CP;

    	public ColorP X0Y0_尾12CP;

    	public ColorP X0Y0_尾11CP;

    	public ColorP X0Y0_尾10CP;

    	public ColorP X0Y0_尾9CP;

    	public ColorP X0Y0_尾8CP;

    	public ColorP X0Y0_尾7CP;

    	public ColorP X0Y0_輪1_革CP;

    	public ColorP X0Y0_輪1_金具1CP;

    	public ColorP X0Y0_輪1_金具2CP;

    	public ColorP X0Y0_輪1_金具3CP;

    	public ColorP X0Y0_輪1_金具左CP;

    	public ColorP X0Y0_輪1_金具右CP;

    	public ColorP X0Y0_尾6CP;

    	public ColorP X0Y0_尾5CP;

    	public ColorP X0Y0_尾4CP;

    	public ColorP X0Y0_尾3CP;

    	public ColorP X0Y0_尾2CP;

    	public ColorP X0Y0_尾1CP;

    	public ColorP X0Y0_尾0CP;

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

    	public bool 針_表示
    	{
    		get
    		{
    			return X0Y0_針.Dra;
    		}
    		set
    		{
    			X0Y0_針.Dra = value;
    			X0Y0_針.Hit = value;
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
    			return 尾17_表示;
    		}
    		set
    		{
    			尾17_表示 = value;
    			針_表示 = value;
    			輪2_革_表示 = value;
    			輪2_金具1_表示 = value;
    			輪2_金具2_表示 = value;
    			輪2_金具3_表示 = value;
    			輪2_金具左_表示 = value;
    			輪2_金具右_表示 = value;
    			尾16_表示 = value;
    			尾15_表示 = value;
    			尾14_表示 = value;
    			尾13_表示 = value;
    			尾12_表示 = value;
    			尾11_表示 = value;
    			尾10_表示 = value;
    			尾9_表示 = value;
    			尾8_表示 = value;
    			尾7_表示 = value;
    			輪1_革_表示 = value;
    			輪1_金具1_表示 = value;
    			輪1_金具2_表示 = value;
    			輪1_金具3_表示 = value;
    			輪1_金具左_表示 = value;
    			輪1_金具右_表示 = value;
    			尾6_表示 = value;
    			尾5_表示 = value;
    			尾4_表示 = value;
    			尾3_表示 = value;
    			尾2_表示 = value;
    			尾1_表示 = value;
    			尾0_表示 = value;
    			鎖1.表示 = value;
    			鎖2.表示 = value;
    			鎖3.表示 = value;
    			鎖4.表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 尾17CD.不透明度;
    		}
    		set
    		{
    			尾17CD.不透明度 = value;
    			針CD.不透明度 = value;
    			尾16CD.不透明度 = value;
    			尾15CD.不透明度 = value;
    			尾14CD.不透明度 = value;
    			尾13CD.不透明度 = value;
    			尾12CD.不透明度 = value;
    			尾11CD.不透明度 = value;
    			尾10CD.不透明度 = value;
    			尾9CD.不透明度 = value;
    			尾8CD.不透明度 = value;
    			尾7CD.不透明度 = value;
    			尾6CD.不透明度 = value;
    			尾5CD.不透明度 = value;
    			尾4CD.不透明度 = value;
    			尾3CD.不透明度 = value;
    			尾2CD.不透明度 = value;
    			尾1CD.不透明度 = value;
    			尾0CD.不透明度 = value;
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

    	public JointS 鎖1_接続点 => new JointS(Body, X0Y0_輪1_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(Body, X0Y0_輪1_金具右, 0);

    	public JointS 鎖3_接続点 => new JointS(Body, X0Y0_輪2_金具左, 0);

    	public JointS 鎖4_接続点 => new JointS(Body, X0Y0_輪2_金具右, 0);

    	public 尾_竜(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 尾_竜D e)
    	{
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant();
    		morphVariant.Tag = "竜尾";
    		morphVariant.Add(new PartGroup(GlobalState.尻尾["尾"][0][6]));
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_尾17 = partGroup["尾17"].ToPar();
    		X0Y0_針 = partGroup["針"].ToPar();
    		PartGroup pars2 = partGroup["輪2"].ToPars();
    		X0Y0_輪2_革 = pars2["革"].ToPar();
    		X0Y0_輪2_金具1 = pars2["金具1"].ToPar();
    		X0Y0_輪2_金具2 = pars2["金具2"].ToPar();
    		X0Y0_輪2_金具3 = pars2["金具3"].ToPar();
    		X0Y0_輪2_金具左 = pars2["金具左"].ToPar();
    		X0Y0_輪2_金具右 = pars2["金具右"].ToPar();
    		X0Y0_尾16 = partGroup["尾16"].ToPar();
    		X0Y0_尾15 = partGroup["尾15"].ToPar();
    		X0Y0_尾14 = partGroup["尾14"].ToPar();
    		X0Y0_尾13 = partGroup["尾13"].ToPar();
    		X0Y0_尾12 = partGroup["尾12"].ToPar();
    		X0Y0_尾11 = partGroup["尾11"].ToPar();
    		X0Y0_尾10 = partGroup["尾10"].ToPar();
    		X0Y0_尾9 = partGroup["尾9"].ToPar();
    		X0Y0_尾8 = partGroup["尾8"].ToPar();
    		X0Y0_尾7 = partGroup["尾7"].ToPar();
    		pars2 = partGroup["輪1"].ToPars();
    		X0Y0_輪1_革 = pars2["革"].ToPar();
    		X0Y0_輪1_金具1 = pars2["金具1"].ToPar();
    		X0Y0_輪1_金具2 = pars2["金具2"].ToPar();
    		X0Y0_輪1_金具3 = pars2["金具3"].ToPar();
    		X0Y0_輪1_金具左 = pars2["金具左"].ToPar();
    		X0Y0_輪1_金具右 = pars2["金具右"].ToPar();
    		X0Y0_尾6 = partGroup["尾6"].ToPar();
    		X0Y0_尾5 = partGroup["尾5"].ToPar();
    		X0Y0_尾4 = partGroup["尾4"].ToPar();
    		X0Y0_尾3 = partGroup["尾3"].ToPar();
    		X0Y0_尾2 = partGroup["尾2"].ToPar();
    		X0Y0_尾1 = partGroup["尾1"].ToPar();
    		X0Y0_尾0 = partGroup["尾0"].ToPar();
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
    		尾17_表示 = e.尾17_表示;
    		針_表示 = e.針_表示;
    		輪2_革_表示 = e.輪2_革_表示;
    		輪2_金具1_表示 = e.輪2_金具1_表示;
    		輪2_金具2_表示 = e.輪2_金具2_表示;
    		輪2_金具3_表示 = e.輪2_金具3_表示;
    		輪2_金具左_表示 = e.輪2_金具左_表示;
    		輪2_金具右_表示 = e.輪2_金具右_表示;
    		尾16_表示 = e.尾16_表示;
    		尾15_表示 = e.尾15_表示;
    		尾14_表示 = e.尾14_表示;
    		尾13_表示 = e.尾13_表示;
    		尾12_表示 = e.尾12_表示;
    		尾11_表示 = e.尾11_表示;
    		尾10_表示 = e.尾10_表示;
    		尾9_表示 = e.尾9_表示;
    		尾8_表示 = e.尾8_表示;
    		尾7_表示 = e.尾7_表示;
    		輪1_革_表示 = e.輪1_革_表示;
    		輪1_金具1_表示 = e.輪1_金具1_表示;
    		輪1_金具2_表示 = e.輪1_金具2_表示;
    		輪1_金具3_表示 = e.輪1_金具3_表示;
    		輪1_金具左_表示 = e.輪1_金具左_表示;
    		輪1_金具右_表示 = e.輪1_金具右_表示;
    		尾6_表示 = e.尾6_表示;
    		尾5_表示 = e.尾5_表示;
    		尾4_表示 = e.尾4_表示;
    		尾3_表示 = e.尾3_表示;
    		尾2_表示 = e.尾2_表示;
    		尾1_表示 = e.尾1_表示;
    		尾0_表示 = e.尾0_表示;
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
    		X0Y0_尾17CP = new ColorP(X0Y0_尾17, 尾17CD, DisUnit, abj: true);
    		X0Y0_針CP = new ColorP(X0Y0_針, 針CD, DisUnit, abj: true);
    		X0Y0_輪2_革CP = new ColorP(X0Y0_輪2_革, 輪2_革CD, DisUnit, abj: true);
    		X0Y0_輪2_金具1CP = new ColorP(X0Y0_輪2_金具1, 輪2_金具1CD, DisUnit, abj: true);
    		X0Y0_輪2_金具2CP = new ColorP(X0Y0_輪2_金具2, 輪2_金具2CD, DisUnit, abj: true);
    		X0Y0_輪2_金具3CP = new ColorP(X0Y0_輪2_金具3, 輪2_金具3CD, DisUnit, abj: true);
    		X0Y0_輪2_金具左CP = new ColorP(X0Y0_輪2_金具左, 輪2_金具左CD, DisUnit, abj: true);
    		X0Y0_輪2_金具右CP = new ColorP(X0Y0_輪2_金具右, 輪2_金具右CD, DisUnit, abj: true);
    		X0Y0_尾16CP = new ColorP(X0Y0_尾16, 尾16CD, DisUnit, abj: true);
    		X0Y0_尾15CP = new ColorP(X0Y0_尾15, 尾15CD, DisUnit, abj: true);
    		X0Y0_尾14CP = new ColorP(X0Y0_尾14, 尾14CD, DisUnit, abj: true);
    		X0Y0_尾13CP = new ColorP(X0Y0_尾13, 尾13CD, DisUnit, abj: true);
    		X0Y0_尾12CP = new ColorP(X0Y0_尾12, 尾12CD, DisUnit, abj: true);
    		X0Y0_尾11CP = new ColorP(X0Y0_尾11, 尾11CD, DisUnit, abj: true);
    		X0Y0_尾10CP = new ColorP(X0Y0_尾10, 尾10CD, DisUnit, abj: true);
    		X0Y0_尾9CP = new ColorP(X0Y0_尾9, 尾9CD, DisUnit, abj: true);
    		X0Y0_尾8CP = new ColorP(X0Y0_尾8, 尾8CD, DisUnit, abj: true);
    		X0Y0_尾7CP = new ColorP(X0Y0_尾7, 尾7CD, DisUnit, abj: true);
    		X0Y0_輪1_革CP = new ColorP(X0Y0_輪1_革, 輪1_革CD, DisUnit, abj: true);
    		X0Y0_輪1_金具1CP = new ColorP(X0Y0_輪1_金具1, 輪1_金具1CD, DisUnit, abj: true);
    		X0Y0_輪1_金具2CP = new ColorP(X0Y0_輪1_金具2, 輪1_金具2CD, DisUnit, abj: true);
    		X0Y0_輪1_金具3CP = new ColorP(X0Y0_輪1_金具3, 輪1_金具3CD, DisUnit, abj: true);
    		X0Y0_輪1_金具左CP = new ColorP(X0Y0_輪1_金具左, 輪1_金具左CD, DisUnit, abj: true);
    		X0Y0_輪1_金具右CP = new ColorP(X0Y0_輪1_金具右, 輪1_金具右CD, DisUnit, abj: true);
    		X0Y0_尾6CP = new ColorP(X0Y0_尾6, 尾6CD, DisUnit, abj: true);
    		X0Y0_尾5CP = new ColorP(X0Y0_尾5, 尾5CD, DisUnit, abj: true);
    		X0Y0_尾4CP = new ColorP(X0Y0_尾4, 尾4CD, DisUnit, abj: true);
    		X0Y0_尾3CP = new ColorP(X0Y0_尾3, 尾3CD, DisUnit, abj: true);
    		X0Y0_尾2CP = new ColorP(X0Y0_尾2, 尾2CD, DisUnit, abj: true);
    		X0Y0_尾1CP = new ColorP(X0Y0_尾1, 尾1CD, DisUnit, abj: true);
    		X0Y0_尾0CP = new ColorP(X0Y0_尾0, 尾0CD, DisUnit, abj: true);
    		Intensity = e.濃度;
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
    		Are.Draw(X0Y0_尾17);
    		Are.Draw(X0Y0_針);
    		Are.Draw(X0Y0_輪2_革);
    		Are.Draw(X0Y0_輪2_金具1);
    		Are.Draw(X0Y0_輪2_金具2);
    		Are.Draw(X0Y0_輪2_金具3);
    		Are.Draw(X0Y0_輪2_金具左);
    		Are.Draw(X0Y0_輪2_金具右);
    		鎖1.描画0(Are);
    		鎖2.描画0(Are);
    		Are.Draw(X0Y0_尾16);
    		Are.Draw(X0Y0_尾15);
    		Are.Draw(X0Y0_尾14);
    		Are.Draw(X0Y0_尾13);
    		Are.Draw(X0Y0_尾12);
    		Are.Draw(X0Y0_尾11);
    		Are.Draw(X0Y0_尾10);
    		Are.Draw(X0Y0_尾9);
    		Are.Draw(X0Y0_尾8);
    		Are.Draw(X0Y0_尾7);
    		Are.Draw(X0Y0_輪1_革);
    		Are.Draw(X0Y0_輪1_金具1);
    		Are.Draw(X0Y0_輪1_金具2);
    		Are.Draw(X0Y0_輪1_金具3);
    		Are.Draw(X0Y0_輪1_金具左);
    		Are.Draw(X0Y0_輪1_金具右);
    		鎖3.描画0(Are);
    		鎖4.描画0(Are);
    		Are.Draw(X0Y0_尾6);
    		Are.Draw(X0Y0_尾5);
    		Are.Draw(X0Y0_尾4);
    		Are.Draw(X0Y0_尾3);
    		Are.Draw(X0Y0_尾2);
    		Are.Draw(X0Y0_尾1);
    		Are.Draw(X0Y0_尾0);
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
    		X0Y0_尾17.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾16.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾15.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾14.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾13.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾12.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾11.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾10.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾9.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾8.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾7.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾6.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾5.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾4.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾3.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾2.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾1.SetAngleBase(maxAngle.GetRanAngle());
    		X0Y0_尾0.SetAngleBase(maxAngle.GetRanAngle());
    		Body.JoinPAall();
    	}

    	public override bool Is革(ShapePart p)
    	{
    		if (p != X0Y0_輪2_革 && p != X0Y0_輪2_金具1 && p != X0Y0_輪2_金具2 && p != X0Y0_輪2_金具3 && p != X0Y0_輪2_金具左 && p != X0Y0_輪2_金具右 && p != X0Y0_輪1_革 && p != X0Y0_輪1_金具1 && p != X0Y0_輪1_金具2 && p != X0Y0_輪1_金具3 && p != X0Y0_輪1_金具左)
    		{
    			return p == X0Y0_輪1_金具右;
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
    	}

    	public override void 色更新()
    	{
    		X0Y0_尾17CP.Update();
    		X0Y0_針CP.Update();
    		X0Y0_輪2_革CP.Update();
    		X0Y0_輪2_金具1CP.Update();
    		X0Y0_輪2_金具2CP.Update();
    		X0Y0_輪2_金具3CP.Update();
    		X0Y0_輪2_金具左CP.Update();
    		X0Y0_輪2_金具右CP.Update();
    		X0Y0_尾16CP.Update();
    		X0Y0_尾15CP.Update();
    		X0Y0_尾14CP.Update();
    		X0Y0_尾13CP.Update();
    		X0Y0_尾12CP.Update();
    		X0Y0_尾11CP.Update();
    		X0Y0_尾10CP.Update();
    		X0Y0_尾9CP.Update();
    		X0Y0_尾8CP.Update();
    		X0Y0_尾7CP.Update();
    		X0Y0_輪1_革CP.Update();
    		X0Y0_輪1_金具1CP.Update();
    		X0Y0_輪1_金具2CP.Update();
    		X0Y0_輪1_金具3CP.Update();
    		X0Y0_輪1_金具左CP.Update();
    		X0Y0_輪1_金具右CP.Update();
    		X0Y0_尾6CP.Update();
    		X0Y0_尾5CP.Update();
    		X0Y0_尾4CP.Update();
    		X0Y0_尾3CP.Update();
    		X0Y0_尾2CP.Update();
    		X0Y0_尾1CP.Update();
    		X0Y0_尾0CP.Update();
    		鎖1.接続PA();
    		鎖2.接続PA();
    		鎖3.接続PA();
    		鎖4.接続PA();
    		鎖1.色更新();
    		鎖2.色更新();
    		鎖3.色更新();
    		鎖4.色更新();
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
    		尾17CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		針CD = new ColorD(ref ColorHelper.Black, ref 体配色.体0O);
    		尾16CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾15CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾14CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾13CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾12CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾11CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾10CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾9CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾8CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾7CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾6CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾5CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
    		尾0CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0R);
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

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		this.配色T(0, "尾", ref 体配色.鱗0R, ref 体配色.刺青R);
    		針CD = new ColorD(ref ColorHelper.Black, ref 体配色.体0O);
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

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		this.配色T(1, "尾", ref 体配色.鱗0R, ref 体配色.刺青R);
    		針CD = new ColorD(ref ColorHelper.Black, ref 体配色.体0O);
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
