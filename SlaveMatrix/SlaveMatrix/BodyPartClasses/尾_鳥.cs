using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 尾_鳥 : 尾
    {
    	public ShapePart X0Y0_尾0;

    	public ShapePart X0Y0_風切羽_左_羽1;

    	public ShapePart X0Y0_風切羽_左_羽2;

    	public ShapePart X0Y0_風切羽_左_羽3;

    	public ShapePart X0Y0_風切羽_左_羽4;

    	public ShapePart X0Y0_風切羽_左_羽5;

    	public ShapePart X0Y0_風切羽_左_羽6;

    	public ShapePart X0Y0_風切羽_右_羽1;

    	public ShapePart X0Y0_風切羽_右_羽2;

    	public ShapePart X0Y0_風切羽_右_羽3;

    	public ShapePart X0Y0_風切羽_右_羽4;

    	public ShapePart X0Y0_風切羽_右_羽5;

    	public ShapePart X0Y0_風切羽_右_羽6;

    	public ShapePart X0Y0_雨覆羽_左_羽1;

    	public ShapePart X0Y0_雨覆羽_左_羽2;

    	public ShapePart X0Y0_雨覆羽_左_羽3;

    	public ShapePart X0Y0_雨覆羽_左_羽4;

    	public ShapePart X0Y0_雨覆羽_左_羽5;

    	public ShapePart X0Y0_雨覆羽_右_羽1;

    	public ShapePart X0Y0_雨覆羽_右_羽2;

    	public ShapePart X0Y0_雨覆羽_右_羽3;

    	public ShapePart X0Y0_雨覆羽_右_羽4;

    	public ShapePart X0Y0_雨覆羽_右_羽5;

    	public ShapePart X0Y0_羽根;

    	public ColorD 尾0CD;

    	public ColorD 風切羽_左_羽1CD;

    	public ColorD 風切羽_左_羽2CD;

    	public ColorD 風切羽_左_羽3CD;

    	public ColorD 風切羽_左_羽4CD;

    	public ColorD 風切羽_左_羽5CD;

    	public ColorD 風切羽_左_羽6CD;

    	public ColorD 風切羽_右_羽1CD;

    	public ColorD 風切羽_右_羽2CD;

    	public ColorD 風切羽_右_羽3CD;

    	public ColorD 風切羽_右_羽4CD;

    	public ColorD 風切羽_右_羽5CD;

    	public ColorD 風切羽_右_羽6CD;

    	public ColorD 雨覆羽_左_羽1CD;

    	public ColorD 雨覆羽_左_羽2CD;

    	public ColorD 雨覆羽_左_羽3CD;

    	public ColorD 雨覆羽_左_羽4CD;

    	public ColorD 雨覆羽_左_羽5CD;

    	public ColorD 雨覆羽_右_羽1CD;

    	public ColorD 雨覆羽_右_羽2CD;

    	public ColorD 雨覆羽_右_羽3CD;

    	public ColorD 雨覆羽_右_羽4CD;

    	public ColorD 雨覆羽_右_羽5CD;

    	public ColorD 羽根CD;

    	public ColorP X0Y0_尾0CP;

    	public ColorP X0Y0_風切羽_左_羽1CP;

    	public ColorP X0Y0_風切羽_左_羽2CP;

    	public ColorP X0Y0_風切羽_左_羽3CP;

    	public ColorP X0Y0_風切羽_左_羽4CP;

    	public ColorP X0Y0_風切羽_左_羽5CP;

    	public ColorP X0Y0_風切羽_左_羽6CP;

    	public ColorP X0Y0_風切羽_右_羽1CP;

    	public ColorP X0Y0_風切羽_右_羽2CP;

    	public ColorP X0Y0_風切羽_右_羽3CP;

    	public ColorP X0Y0_風切羽_右_羽4CP;

    	public ColorP X0Y0_風切羽_右_羽5CP;

    	public ColorP X0Y0_風切羽_右_羽6CP;

    	public ColorP X0Y0_雨覆羽_左_羽1CP;

    	public ColorP X0Y0_雨覆羽_左_羽2CP;

    	public ColorP X0Y0_雨覆羽_左_羽3CP;

    	public ColorP X0Y0_雨覆羽_左_羽4CP;

    	public ColorP X0Y0_雨覆羽_左_羽5CP;

    	public ColorP X0Y0_雨覆羽_右_羽1CP;

    	public ColorP X0Y0_雨覆羽_右_羽2CP;

    	public ColorP X0Y0_雨覆羽_右_羽3CP;

    	public ColorP X0Y0_雨覆羽_右_羽4CP;

    	public ColorP X0Y0_雨覆羽_右_羽5CP;

    	public ColorP X0Y0_羽根CP;

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

    	public bool 風切羽_左_羽1_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_左_羽1.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_左_羽1.Dra = value;
    			X0Y0_風切羽_左_羽1.Hit = value;
    		}
    	}

    	public bool 風切羽_左_羽2_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_左_羽2.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_左_羽2.Dra = value;
    			X0Y0_風切羽_左_羽2.Hit = value;
    		}
    	}

    	public bool 風切羽_左_羽3_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_左_羽3.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_左_羽3.Dra = value;
    			X0Y0_風切羽_左_羽3.Hit = value;
    		}
    	}

    	public bool 風切羽_左_羽4_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_左_羽4.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_左_羽4.Dra = value;
    			X0Y0_風切羽_左_羽4.Hit = value;
    		}
    	}

    	public bool 風切羽_左_羽5_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_左_羽5.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_左_羽5.Dra = value;
    			X0Y0_風切羽_左_羽5.Hit = value;
    		}
    	}

    	public bool 風切羽_左_羽6_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_左_羽6.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_左_羽6.Dra = value;
    			X0Y0_風切羽_左_羽6.Hit = value;
    		}
    	}

    	public bool 風切羽_右_羽1_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_右_羽1.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_右_羽1.Dra = value;
    			X0Y0_風切羽_右_羽1.Hit = value;
    		}
    	}

    	public bool 風切羽_右_羽2_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_右_羽2.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_右_羽2.Dra = value;
    			X0Y0_風切羽_右_羽2.Hit = value;
    		}
    	}

    	public bool 風切羽_右_羽3_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_右_羽3.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_右_羽3.Dra = value;
    			X0Y0_風切羽_右_羽3.Hit = value;
    		}
    	}

    	public bool 風切羽_右_羽4_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_右_羽4.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_右_羽4.Dra = value;
    			X0Y0_風切羽_右_羽4.Hit = value;
    		}
    	}

    	public bool 風切羽_右_羽5_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_右_羽5.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_右_羽5.Dra = value;
    			X0Y0_風切羽_右_羽5.Hit = value;
    		}
    	}

    	public bool 風切羽_右_羽6_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_右_羽6.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_右_羽6.Dra = value;
    			X0Y0_風切羽_右_羽6.Hit = value;
    		}
    	}

    	public bool 雨覆羽_左_羽1_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_左_羽1.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_左_羽1.Dra = value;
    			X0Y0_雨覆羽_左_羽1.Hit = value;
    		}
    	}

    	public bool 雨覆羽_左_羽2_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_左_羽2.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_左_羽2.Dra = value;
    			X0Y0_雨覆羽_左_羽2.Hit = value;
    		}
    	}

    	public bool 雨覆羽_左_羽3_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_左_羽3.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_左_羽3.Dra = value;
    			X0Y0_雨覆羽_左_羽3.Hit = value;
    		}
    	}

    	public bool 雨覆羽_左_羽4_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_左_羽4.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_左_羽4.Dra = value;
    			X0Y0_雨覆羽_左_羽4.Hit = value;
    		}
    	}

    	public bool 雨覆羽_左_羽5_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_左_羽5.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_左_羽5.Dra = value;
    			X0Y0_雨覆羽_左_羽5.Hit = value;
    		}
    	}

    	public bool 雨覆羽_右_羽1_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_右_羽1.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_右_羽1.Dra = value;
    			X0Y0_雨覆羽_右_羽1.Hit = value;
    		}
    	}

    	public bool 雨覆羽_右_羽2_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_右_羽2.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_右_羽2.Dra = value;
    			X0Y0_雨覆羽_右_羽2.Hit = value;
    		}
    	}

    	public bool 雨覆羽_右_羽3_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_右_羽3.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_右_羽3.Dra = value;
    			X0Y0_雨覆羽_右_羽3.Hit = value;
    		}
    	}

    	public bool 雨覆羽_右_羽4_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_右_羽4.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_右_羽4.Dra = value;
    			X0Y0_雨覆羽_右_羽4.Hit = value;
    		}
    	}

    	public bool 雨覆羽_右_羽5_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_右_羽5.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_右_羽5.Dra = value;
    			X0Y0_雨覆羽_右_羽5.Hit = value;
    		}
    	}

    	public bool 羽根_表示
    	{
    		get
    		{
    			return X0Y0_羽根.Dra;
    		}
    		set
    		{
    			X0Y0_羽根.Dra = value;
    			X0Y0_羽根.Hit = value;
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
    			風切羽_左_羽1_表示 = value;
    			風切羽_左_羽2_表示 = value;
    			風切羽_左_羽3_表示 = value;
    			風切羽_左_羽4_表示 = value;
    			風切羽_左_羽5_表示 = value;
    			風切羽_左_羽6_表示 = value;
    			風切羽_右_羽1_表示 = value;
    			風切羽_右_羽2_表示 = value;
    			風切羽_右_羽3_表示 = value;
    			風切羽_右_羽4_表示 = value;
    			風切羽_右_羽5_表示 = value;
    			風切羽_右_羽6_表示 = value;
    			雨覆羽_左_羽1_表示 = value;
    			雨覆羽_左_羽2_表示 = value;
    			雨覆羽_左_羽3_表示 = value;
    			雨覆羽_左_羽4_表示 = value;
    			雨覆羽_左_羽5_表示 = value;
    			雨覆羽_右_羽1_表示 = value;
    			雨覆羽_右_羽2_表示 = value;
    			雨覆羽_右_羽3_表示 = value;
    			雨覆羽_右_羽4_表示 = value;
    			雨覆羽_右_羽5_表示 = value;
    			羽根_表示 = value;
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
    			風切羽_左_羽1CD.不透明度 = value;
    			風切羽_左_羽2CD.不透明度 = value;
    			風切羽_左_羽3CD.不透明度 = value;
    			風切羽_左_羽4CD.不透明度 = value;
    			風切羽_左_羽5CD.不透明度 = value;
    			風切羽_左_羽6CD.不透明度 = value;
    			風切羽_右_羽1CD.不透明度 = value;
    			風切羽_右_羽2CD.不透明度 = value;
    			風切羽_右_羽3CD.不透明度 = value;
    			風切羽_右_羽4CD.不透明度 = value;
    			風切羽_右_羽5CD.不透明度 = value;
    			風切羽_右_羽6CD.不透明度 = value;
    			雨覆羽_左_羽1CD.不透明度 = value;
    			雨覆羽_左_羽2CD.不透明度 = value;
    			雨覆羽_左_羽3CD.不透明度 = value;
    			雨覆羽_左_羽4CD.不透明度 = value;
    			雨覆羽_左_羽5CD.不透明度 = value;
    			雨覆羽_右_羽1CD.不透明度 = value;
    			雨覆羽_右_羽2CD.不透明度 = value;
    			雨覆羽_右_羽3CD.不透明度 = value;
    			雨覆羽_右_羽4CD.不透明度 = value;
    			雨覆羽_右_羽5CD.不透明度 = value;
    			羽根CD.不透明度 = value;
    		}
    	}

    	public double 展開
    	{
    		set
    		{
    			double num = value.Inverse();
    			double num2 = (右 ? (-1.0) : 1.0);
    			X0Y0_風切羽_左_羽1.AngleCont = num2 * -12.0 * num;
    			X0Y0_風切羽_左_羽2.AngleCont = num2 * -22.0 * num;
    			X0Y0_風切羽_左_羽3.AngleCont = num2 * -32.0 * num;
    			X0Y0_風切羽_左_羽4.AngleCont = num2 * -42.0 * num;
    			X0Y0_風切羽_左_羽5.AngleCont = num2 * -52.0 * num;
    			X0Y0_風切羽_左_羽6.AngleCont = num2 * -62.0 * num;
    			X0Y0_風切羽_右_羽1.AngleCont = num2 * 12.0 * num;
    			X0Y0_風切羽_右_羽2.AngleCont = num2 * 22.0 * num;
    			X0Y0_風切羽_右_羽3.AngleCont = num2 * 32.0 * num;
    			X0Y0_風切羽_右_羽4.AngleCont = num2 * 42.0 * num;
    			X0Y0_風切羽_右_羽5.AngleCont = num2 * 52.0 * num;
    			X0Y0_風切羽_右_羽6.AngleCont = num2 * 62.0 * num;
    			X0Y0_雨覆羽_左_羽1.AngleCont = num2 * -12.0 * num;
    			X0Y0_雨覆羽_左_羽2.AngleCont = num2 * -32.0 * num;
    			X0Y0_雨覆羽_左_羽3.AngleCont = num2 * -42.0 * num;
    			X0Y0_雨覆羽_左_羽4.AngleCont = num2 * -52.0 * num;
    			X0Y0_雨覆羽_左_羽5.AngleCont = num2 * -62.0 * num;
    			X0Y0_雨覆羽_右_羽1.AngleCont = num2 * 12.0 * num;
    			X0Y0_雨覆羽_右_羽2.AngleCont = num2 * 32.0 * num;
    			X0Y0_雨覆羽_右_羽3.AngleCont = num2 * 42.0 * num;
    			X0Y0_雨覆羽_右_羽4.AngleCont = num2 * 52.0 * num;
    			X0Y0_雨覆羽_右_羽5.AngleCont = num2 * 62.0 * num;
    		}
    	}

    	public 尾_鳥(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 尾_鳥D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "鳥尾";
    		dif.Add(new PartGroup(Sta.尻尾["尾"][0][9]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_尾0 = partGroup["尾0"].ToPar();
    		PartGroup pars2 = partGroup["風切羽"].ToPars();
    		PartGroup pars3 = pars2["左"].ToPars();
    		X0Y0_風切羽_左_羽1 = pars3["羽1"].ToPar();
    		X0Y0_風切羽_左_羽2 = pars3["羽2"].ToPar();
    		X0Y0_風切羽_左_羽3 = pars3["羽3"].ToPar();
    		X0Y0_風切羽_左_羽4 = pars3["羽4"].ToPar();
    		X0Y0_風切羽_左_羽5 = pars3["羽5"].ToPar();
    		X0Y0_風切羽_左_羽6 = pars3["羽6"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y0_風切羽_右_羽1 = pars3["羽1"].ToPar();
    		X0Y0_風切羽_右_羽2 = pars3["羽2"].ToPar();
    		X0Y0_風切羽_右_羽3 = pars3["羽3"].ToPar();
    		X0Y0_風切羽_右_羽4 = pars3["羽4"].ToPar();
    		X0Y0_風切羽_右_羽5 = pars3["羽5"].ToPar();
    		X0Y0_風切羽_右_羽6 = pars3["羽6"].ToPar();
    		PartGroup pars4 = partGroup["雨覆羽"].ToPars();
    		pars3 = pars4["左"].ToPars();
    		X0Y0_雨覆羽_左_羽1 = pars3["羽1"].ToPar();
    		X0Y0_雨覆羽_左_羽2 = pars3["羽2"].ToPar();
    		X0Y0_雨覆羽_左_羽3 = pars3["羽3"].ToPar();
    		X0Y0_雨覆羽_左_羽4 = pars3["羽4"].ToPar();
    		X0Y0_雨覆羽_左_羽5 = pars3["羽5"].ToPar();
    		pars3 = pars4["右"].ToPars();
    		X0Y0_雨覆羽_右_羽1 = pars3["羽1"].ToPar();
    		X0Y0_雨覆羽_右_羽2 = pars3["羽2"].ToPar();
    		X0Y0_雨覆羽_右_羽3 = pars3["羽3"].ToPar();
    		X0Y0_雨覆羽_右_羽4 = pars3["羽4"].ToPar();
    		X0Y0_雨覆羽_右_羽5 = pars3["羽5"].ToPar();
    		X0Y0_羽根 = partGroup["羽根"].ToPar();
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
    		風切羽_左_羽1_表示 = e.風切羽_左_羽1_表示;
    		風切羽_左_羽2_表示 = e.風切羽_左_羽2_表示;
    		風切羽_左_羽3_表示 = e.風切羽_左_羽3_表示;
    		風切羽_左_羽4_表示 = e.風切羽_左_羽4_表示;
    		風切羽_左_羽5_表示 = e.風切羽_左_羽5_表示;
    		風切羽_左_羽6_表示 = e.風切羽_左_羽6_表示;
    		風切羽_右_羽1_表示 = e.風切羽_右_羽1_表示;
    		風切羽_右_羽2_表示 = e.風切羽_右_羽2_表示;
    		風切羽_右_羽3_表示 = e.風切羽_右_羽3_表示;
    		風切羽_右_羽4_表示 = e.風切羽_右_羽4_表示;
    		風切羽_右_羽5_表示 = e.風切羽_右_羽5_表示;
    		風切羽_右_羽6_表示 = e.風切羽_右_羽6_表示;
    		雨覆羽_左_羽1_表示 = e.雨覆羽_左_羽1_表示;
    		雨覆羽_左_羽2_表示 = e.雨覆羽_左_羽2_表示;
    		雨覆羽_左_羽3_表示 = e.雨覆羽_左_羽3_表示;
    		雨覆羽_左_羽4_表示 = e.雨覆羽_左_羽4_表示;
    		雨覆羽_左_羽5_表示 = e.雨覆羽_左_羽5_表示;
    		雨覆羽_右_羽1_表示 = e.雨覆羽_右_羽1_表示;
    		雨覆羽_右_羽2_表示 = e.雨覆羽_右_羽2_表示;
    		雨覆羽_右_羽3_表示 = e.雨覆羽_右_羽3_表示;
    		雨覆羽_右_羽4_表示 = e.雨覆羽_右_羽4_表示;
    		雨覆羽_右_羽5_表示 = e.雨覆羽_右_羽5_表示;
    		羽根_表示 = e.羽根_表示;
    		展開 = e.展開;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_尾0CP = new ColorP(X0Y0_尾0, 尾0CD, DisUnit, abj: true);
    		X0Y0_風切羽_左_羽1CP = new ColorP(X0Y0_風切羽_左_羽1, 風切羽_左_羽1CD, DisUnit, abj: true);
    		X0Y0_風切羽_左_羽2CP = new ColorP(X0Y0_風切羽_左_羽2, 風切羽_左_羽2CD, DisUnit, abj: true);
    		X0Y0_風切羽_左_羽3CP = new ColorP(X0Y0_風切羽_左_羽3, 風切羽_左_羽3CD, DisUnit, abj: true);
    		X0Y0_風切羽_左_羽4CP = new ColorP(X0Y0_風切羽_左_羽4, 風切羽_左_羽4CD, DisUnit, abj: true);
    		X0Y0_風切羽_左_羽5CP = new ColorP(X0Y0_風切羽_左_羽5, 風切羽_左_羽5CD, DisUnit, abj: true);
    		X0Y0_風切羽_左_羽6CP = new ColorP(X0Y0_風切羽_左_羽6, 風切羽_左_羽6CD, DisUnit, abj: true);
    		X0Y0_風切羽_右_羽1CP = new ColorP(X0Y0_風切羽_右_羽1, 風切羽_右_羽1CD, DisUnit, abj: true);
    		X0Y0_風切羽_右_羽2CP = new ColorP(X0Y0_風切羽_右_羽2, 風切羽_右_羽2CD, DisUnit, abj: true);
    		X0Y0_風切羽_右_羽3CP = new ColorP(X0Y0_風切羽_右_羽3, 風切羽_右_羽3CD, DisUnit, abj: true);
    		X0Y0_風切羽_右_羽4CP = new ColorP(X0Y0_風切羽_右_羽4, 風切羽_右_羽4CD, DisUnit, abj: true);
    		X0Y0_風切羽_右_羽5CP = new ColorP(X0Y0_風切羽_右_羽5, 風切羽_右_羽5CD, DisUnit, abj: true);
    		X0Y0_風切羽_右_羽6CP = new ColorP(X0Y0_風切羽_右_羽6, 風切羽_右_羽6CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_左_羽1CP = new ColorP(X0Y0_雨覆羽_左_羽1, 雨覆羽_左_羽1CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_左_羽2CP = new ColorP(X0Y0_雨覆羽_左_羽2, 雨覆羽_左_羽2CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_左_羽3CP = new ColorP(X0Y0_雨覆羽_左_羽3, 雨覆羽_左_羽3CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_左_羽4CP = new ColorP(X0Y0_雨覆羽_左_羽4, 雨覆羽_左_羽4CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_左_羽5CP = new ColorP(X0Y0_雨覆羽_左_羽5, 雨覆羽_左_羽5CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_右_羽1CP = new ColorP(X0Y0_雨覆羽_右_羽1, 雨覆羽_右_羽1CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_右_羽2CP = new ColorP(X0Y0_雨覆羽_右_羽2, 雨覆羽_右_羽2CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_右_羽3CP = new ColorP(X0Y0_雨覆羽_右_羽3, 雨覆羽_右_羽3CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_右_羽4CP = new ColorP(X0Y0_雨覆羽_右_羽4, 雨覆羽_右_羽4CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_右_羽5CP = new ColorP(X0Y0_雨覆羽_右_羽5, 雨覆羽_右_羽5CD, DisUnit, abj: true);
    		X0Y0_羽根CP = new ColorP(X0Y0_羽根, 羽根CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_風切羽_左_羽1.AngleBase = num * 12.0;
    		X0Y0_風切羽_左_羽2.AngleBase = num * 22.0;
    		X0Y0_風切羽_左_羽3.AngleBase = num * 32.0;
    		X0Y0_風切羽_左_羽4.AngleBase = num * 42.0;
    		X0Y0_風切羽_左_羽5.AngleBase = num * 52.0;
    		X0Y0_風切羽_左_羽6.AngleBase = num * 62.0;
    		X0Y0_風切羽_右_羽1.AngleBase = num * -12.0;
    		X0Y0_風切羽_右_羽2.AngleBase = num * -22.0;
    		X0Y0_風切羽_右_羽3.AngleBase = num * -32.0;
    		X0Y0_風切羽_右_羽4.AngleBase = num * -42.0;
    		X0Y0_風切羽_右_羽5.AngleBase = num * -52.0;
    		X0Y0_風切羽_右_羽6.AngleBase = num * -62.0;
    		X0Y0_雨覆羽_左_羽1.AngleBase = num * 0.0;
    		X0Y0_雨覆羽_左_羽2.AngleBase = num * 32.0;
    		X0Y0_雨覆羽_左_羽3.AngleBase = num * 42.0;
    		X0Y0_雨覆羽_左_羽4.AngleBase = num * 52.0;
    		X0Y0_雨覆羽_左_羽5.AngleBase = num * 62.0;
    		X0Y0_雨覆羽_右_羽1.AngleBase = num * 0.0;
    		X0Y0_雨覆羽_右_羽2.AngleBase = num * -32.0;
    		X0Y0_雨覆羽_右_羽3.AngleBase = num * -42.0;
    		X0Y0_雨覆羽_右_羽4.AngleBase = num * -52.0;
    		X0Y0_雨覆羽_右_羽5.AngleBase = num * -62.0;
    		Body.JoinPAall();
    	}

    	public override IEnumerable<ShapePart> Enum軸()
    	{
    		yield return X0Y0_尾0;
    	}

    	public override void 色更新()
    	{
    		X0Y0_尾0CP.Update();
    		X0Y0_風切羽_左_羽1CP.Update();
    		X0Y0_風切羽_左_羽2CP.Update();
    		X0Y0_風切羽_左_羽3CP.Update();
    		X0Y0_風切羽_左_羽4CP.Update();
    		X0Y0_風切羽_左_羽5CP.Update();
    		X0Y0_風切羽_左_羽6CP.Update();
    		X0Y0_風切羽_右_羽1CP.Update();
    		X0Y0_風切羽_右_羽2CP.Update();
    		X0Y0_風切羽_右_羽3CP.Update();
    		X0Y0_風切羽_右_羽4CP.Update();
    		X0Y0_風切羽_右_羽5CP.Update();
    		X0Y0_風切羽_右_羽6CP.Update();
    		X0Y0_雨覆羽_左_羽1CP.Update();
    		X0Y0_雨覆羽_左_羽2CP.Update();
    		X0Y0_雨覆羽_左_羽3CP.Update();
    		X0Y0_雨覆羽_左_羽4CP.Update();
    		X0Y0_雨覆羽_左_羽5CP.Update();
    		X0Y0_雨覆羽_右_羽1CP.Update();
    		X0Y0_雨覆羽_右_羽2CP.Update();
    		X0Y0_雨覆羽_右_羽3CP.Update();
    		X0Y0_雨覆羽_右_羽4CP.Update();
    		X0Y0_雨覆羽_右_羽5CP.Update();
    		X0Y0_羽根CP.Update();
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
    		風切羽_左_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_左_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_左_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_左_羽4CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_左_羽5CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_左_羽6CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_右_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_右_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_右_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_右_羽4CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_右_羽5CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_右_羽6CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		雨覆羽_左_羽1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_左_羽2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_左_羽3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_左_羽4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_左_羽5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_右_羽1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_右_羽2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_右_羽3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_右_羽4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_右_羽5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		羽根CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		尾0CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		風切羽_左_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		風切羽_左_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_左_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		風切羽_左_羽4CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_左_羽5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		風切羽_左_羽6CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_右_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		風切羽_右_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_右_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		風切羽_右_羽4CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_右_羽5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		風切羽_右_羽6CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		雨覆羽_左_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		雨覆羽_左_羽2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_左_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		雨覆羽_左_羽4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_左_羽5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		雨覆羽_右_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		雨覆羽_右_羽2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_右_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		雨覆羽_右_羽4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_右_羽5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		羽根CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		尾0CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		風切羽_左_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_左_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		風切羽_左_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_左_羽4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		風切羽_左_羽5CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_左_羽6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		風切羽_右_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_右_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		風切羽_右_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_右_羽4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		風切羽_右_羽5CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
    		風切羽_右_羽6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		雨覆羽_左_羽1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_左_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		雨覆羽_左_羽3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_左_羽4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		雨覆羽_左_羽5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_右_羽1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_右_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		雨覆羽_右_羽3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		雨覆羽_右_羽4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		雨覆羽_右_羽5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
    		羽根CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
    	}
    }
}
