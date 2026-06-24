using System.Linq;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class 四足胸 : 半身
    {
    	public ShapePart X0Y0_RibCage;

    	public ShapePart X0Y0_筋肉_筋肉左;

    	public ShapePart X0Y0_筋肉_筋肉右;

    	public ShapePart X0Y0_筋肉_筋肉中;

    	public ShapePart X0Y0_筋肉_筋肉左下;

    	public ShapePart X0Y0_筋肉_筋肉左中;

    	public ShapePart X0Y0_筋肉_筋肉左上;

    	public ShapePart X0Y0_筋肉_筋肉右下;

    	public ShapePart X0Y0_筋肉_筋肉右中;

    	public ShapePart X0Y0_筋肉_筋肉右上;

    	public ShapePart X0Y0_紋柄_紋左_紋1;

    	public ShapePart X0Y0_紋柄_紋左_紋2;

    	public ShapePart X0Y0_紋柄_紋左_紋3;

    	public ShapePart X0Y0_紋柄_紋左_紋4;

    	public ShapePart X0Y0_紋柄_紋右_紋1;

    	public ShapePart X0Y0_紋柄_紋右_紋2;

    	public ShapePart X0Y0_紋柄_紋右_紋3;

    	public ShapePart X0Y0_紋柄_紋右_紋4;

    	public ShapePart X0Y0_虎柄_虎左_虎1;

    	public ShapePart X0Y0_虎柄_虎左_虎2;

    	public ShapePart X0Y0_虎柄_虎右_虎1;

    	public ShapePart X0Y0_虎柄_虎右_虎2;

    	public ShapePart X0Y0_竜性_中_鱗左;

    	public ShapePart X0Y0_竜性_中_鱗右;

    	public ShapePart X0Y0_竜性_中_鱗1;

    	public ShapePart X0Y0_竜性_中_鱗2;

    	public ShapePart X0Y0_竜性_左_鱗1;

    	public ShapePart X0Y0_竜性_左_鱗2;

    	public ShapePart X0Y0_竜性_左_鱗3;

    	public ShapePart X0Y0_竜性_右_鱗1;

    	public ShapePart X0Y0_竜性_右_鱗2;

    	public ShapePart X0Y0_竜性_右_鱗3;

    	public ColorD RibCageCD;

    	public ColorD 筋肉_筋肉左CD;

    	public ColorD 筋肉_筋肉右CD;

    	public ColorD 筋肉_筋肉中CD;

    	public ColorD 筋肉_筋肉左下CD;

    	public ColorD 筋肉_筋肉左中CD;

    	public ColorD 筋肉_筋肉左上CD;

    	public ColorD 筋肉_筋肉右下CD;

    	public ColorD 筋肉_筋肉右中CD;

    	public ColorD 筋肉_筋肉右上CD;

    	public ColorD 紋柄_紋左_紋1CD;

    	public ColorD 紋柄_紋左_紋2CD;

    	public ColorD 紋柄_紋左_紋3CD;

    	public ColorD 紋柄_紋左_紋4CD;

    	public ColorD 紋柄_紋右_紋1CD;

    	public ColorD 紋柄_紋右_紋2CD;

    	public ColorD 紋柄_紋右_紋3CD;

    	public ColorD 紋柄_紋右_紋4CD;

    	public ColorD 虎柄_虎左_虎1CD;

    	public ColorD 虎柄_虎左_虎2CD;

    	public ColorD 虎柄_虎右_虎1CD;

    	public ColorD 虎柄_虎右_虎2CD;

    	public ColorD 竜性_中_鱗左CD;

    	public ColorD 竜性_中_鱗右CD;

    	public ColorD 竜性_中_鱗1CD;

    	public ColorD 竜性_中_鱗2CD;

    	public ColorD 竜性_左_鱗1CD;

    	public ColorD 竜性_左_鱗2CD;

    	public ColorD 竜性_左_鱗3CD;

    	public ColorD 竜性_右_鱗1CD;

    	public ColorD 竜性_右_鱗2CD;

    	public ColorD 竜性_右_鱗3CD;

    	public ColorP X0Y0_RibCageCP;

    	public ColorP X0Y0_筋肉_筋肉左CP;

    	public ColorP X0Y0_筋肉_筋肉右CP;

    	public ColorP X0Y0_筋肉_筋肉中CP;

    	public ColorP X0Y0_筋肉_筋肉左下CP;

    	public ColorP X0Y0_筋肉_筋肉左中CP;

    	public ColorP X0Y0_筋肉_筋肉左上CP;

    	public ColorP X0Y0_筋肉_筋肉右下CP;

    	public ColorP X0Y0_筋肉_筋肉右中CP;

    	public ColorP X0Y0_筋肉_筋肉右上CP;

    	public ColorP X0Y0_紋柄_紋左_紋1CP;

    	public ColorP X0Y0_紋柄_紋左_紋2CP;

    	public ColorP X0Y0_紋柄_紋左_紋3CP;

    	public ColorP X0Y0_紋柄_紋左_紋4CP;

    	public ColorP X0Y0_紋柄_紋右_紋1CP;

    	public ColorP X0Y0_紋柄_紋右_紋2CP;

    	public ColorP X0Y0_紋柄_紋右_紋3CP;

    	public ColorP X0Y0_紋柄_紋右_紋4CP;

    	public ColorP X0Y0_虎柄_虎左_虎1CP;

    	public ColorP X0Y0_虎柄_虎左_虎2CP;

    	public ColorP X0Y0_虎柄_虎右_虎1CP;

    	public ColorP X0Y0_虎柄_虎右_虎2CP;

    	public ColorP X0Y0_竜性_中_鱗左CP;

    	public ColorP X0Y0_竜性_中_鱗右CP;

    	public ColorP X0Y0_竜性_中_鱗1CP;

    	public ColorP X0Y0_竜性_中_鱗2CP;

    	public ColorP X0Y0_竜性_左_鱗1CP;

    	public ColorP X0Y0_竜性_左_鱗2CP;

    	public ColorP X0Y0_竜性_左_鱗3CP;

    	public ColorP X0Y0_竜性_右_鱗1CP;

    	public ColorP X0Y0_竜性_右_鱗2CP;

    	public ColorP X0Y0_竜性_右_鱗3CP;

    	public Element[] 脇左_接続;

    	public Element[] 脇右_接続;

    	public Element[] Torso_接続;

    	public Element[] LeftBreast_接続;

    	public Element[] 胸右_接続;

    	public Element[] 肌_接続;

    	public Element[] 翼上左_接続;

    	public Element[] 翼上右_接続;

    	public Element[] 翼下左_接続;

    	public Element[] 翼下右_接続;

    	public Element[] 背中_接続;

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
    			筋肉_筋肉左_表示 = 筋肉_;
    			筋肉_筋肉右_表示 = 筋肉_;
    			筋肉_筋肉中_表示 = 筋肉_;
    			筋肉_筋肉左下_表示 = 筋肉_;
    			筋肉_筋肉左中_表示 = 筋肉_;
    			筋肉_筋肉左上_表示 = 筋肉_;
    			筋肉_筋肉右下_表示 = 筋肉_;
    			筋肉_筋肉右中_表示 = 筋肉_;
    			筋肉_筋肉右上_表示 = 筋肉_;
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

    	public bool RibCage_表示
    	{
    		get
    		{
    			return X0Y0_RibCage.Dra;
    		}
    		set
    		{
    			X0Y0_RibCage.Dra = value;
    			X0Y0_RibCage.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉左_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉左.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉左.Dra = value;
    			X0Y0_筋肉_筋肉左.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉右_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉右.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉右.Dra = value;
    			X0Y0_筋肉_筋肉右.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉中_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉中.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉中.Dra = value;
    			X0Y0_筋肉_筋肉中.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉左下_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉左下.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉左下.Dra = value;
    			X0Y0_筋肉_筋肉左下.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉左中_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉左中.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉左中.Dra = value;
    			X0Y0_筋肉_筋肉左中.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉左上_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉左上.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉左上.Dra = value;
    			X0Y0_筋肉_筋肉左上.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉右下_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉右下.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉右下.Dra = value;
    			X0Y0_筋肉_筋肉右下.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉右中_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉右中.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉右中.Dra = value;
    			X0Y0_筋肉_筋肉右中.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉右上_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉右上.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉右上.Dra = value;
    			X0Y0_筋肉_筋肉右上.Hit = value;
    		}
    	}

    	public bool 紋柄_紋左_紋1_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋左_紋1.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋左_紋1.Dra = value;
    			X0Y0_紋柄_紋左_紋1.Hit = value;
    		}
    	}

    	public bool 紋柄_紋左_紋2_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋左_紋2.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋左_紋2.Dra = value;
    			X0Y0_紋柄_紋左_紋2.Hit = value;
    		}
    	}

    	public bool 紋柄_紋左_紋3_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋左_紋3.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋左_紋3.Dra = value;
    			X0Y0_紋柄_紋左_紋3.Hit = value;
    		}
    	}

    	public bool 紋柄_紋左_紋4_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋左_紋4.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋左_紋4.Dra = value;
    			X0Y0_紋柄_紋左_紋4.Hit = value;
    		}
    	}

    	public bool 紋柄_紋右_紋1_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋右_紋1.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋右_紋1.Dra = value;
    			X0Y0_紋柄_紋右_紋1.Hit = value;
    		}
    	}

    	public bool 紋柄_紋右_紋2_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋右_紋2.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋右_紋2.Dra = value;
    			X0Y0_紋柄_紋右_紋2.Hit = value;
    		}
    	}

    	public bool 紋柄_紋右_紋3_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋右_紋3.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋右_紋3.Dra = value;
    			X0Y0_紋柄_紋右_紋3.Hit = value;
    		}
    	}

    	public bool 紋柄_紋右_紋4_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋右_紋4.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋右_紋4.Dra = value;
    			X0Y0_紋柄_紋右_紋4.Hit = value;
    		}
    	}

    	public bool 虎柄_虎左_虎1_表示
    	{
    		get
    		{
    			return X0Y0_虎柄_虎左_虎1.Dra;
    		}
    		set
    		{
    			X0Y0_虎柄_虎左_虎1.Dra = value;
    			X0Y0_虎柄_虎左_虎1.Hit = value;
    		}
    	}

    	public bool 虎柄_虎左_虎2_表示
    	{
    		get
    		{
    			return X0Y0_虎柄_虎左_虎2.Dra;
    		}
    		set
    		{
    			X0Y0_虎柄_虎左_虎2.Dra = value;
    			X0Y0_虎柄_虎左_虎2.Hit = value;
    		}
    	}

    	public bool 虎柄_虎右_虎1_表示
    	{
    		get
    		{
    			return X0Y0_虎柄_虎右_虎1.Dra;
    		}
    		set
    		{
    			X0Y0_虎柄_虎右_虎1.Dra = value;
    			X0Y0_虎柄_虎右_虎1.Hit = value;
    		}
    	}

    	public bool 虎柄_虎右_虎2_表示
    	{
    		get
    		{
    			return X0Y0_虎柄_虎右_虎2.Dra;
    		}
    		set
    		{
    			X0Y0_虎柄_虎右_虎2.Dra = value;
    			X0Y0_虎柄_虎右_虎2.Hit = value;
    		}
    	}

    	public bool 竜性_中_鱗左_表示
    	{
    		get
    		{
    			return X0Y0_竜性_中_鱗左.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_中_鱗左.Dra = value;
    			X0Y0_竜性_中_鱗左.Hit = value;
    		}
    	}

    	public bool 竜性_中_鱗右_表示
    	{
    		get
    		{
    			return X0Y0_竜性_中_鱗右.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_中_鱗右.Dra = value;
    			X0Y0_竜性_中_鱗右.Hit = value;
    		}
    	}

    	public bool 竜性_中_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性_中_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_中_鱗1.Dra = value;
    			X0Y0_竜性_中_鱗1.Hit = value;
    		}
    	}

    	public bool 竜性_中_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性_中_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_中_鱗2.Dra = value;
    			X0Y0_竜性_中_鱗2.Hit = value;
    		}
    	}

    	public bool 竜性_左_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性_左_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_左_鱗1.Dra = value;
    			X0Y0_竜性_左_鱗1.Hit = value;
    		}
    	}

    	public bool 竜性_左_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性_左_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_左_鱗2.Dra = value;
    			X0Y0_竜性_左_鱗2.Hit = value;
    		}
    	}

    	public bool 竜性_左_鱗3_表示
    	{
    		get
    		{
    			return X0Y0_竜性_左_鱗3.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_左_鱗3.Dra = value;
    			X0Y0_竜性_左_鱗3.Hit = value;
    		}
    	}

    	public bool 竜性_右_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性_右_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_右_鱗1.Dra = value;
    			X0Y0_竜性_右_鱗1.Hit = value;
    		}
    	}

    	public bool 竜性_右_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性_右_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_右_鱗2.Dra = value;
    			X0Y0_竜性_右_鱗2.Hit = value;
    		}
    	}

    	public bool 竜性_右_鱗3_表示
    	{
    		get
    		{
    			return X0Y0_竜性_右_鱗3.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_右_鱗3.Dra = value;
    			X0Y0_竜性_右_鱗3.Hit = value;
    		}
    	}

    	public double 筋肉濃度
    	{
    		get
    		{
    			return 筋肉_筋肉左CD.不透明度;
    		}
    		set
    		{
    			筋肉_筋肉左CD.不透明度 = value;
    			筋肉_筋肉右CD.不透明度 = value;
    			筋肉_筋肉中CD.不透明度 = value;
    			筋肉_筋肉左下CD.不透明度 = value;
    			筋肉_筋肉左中CD.不透明度 = value;
    			筋肉_筋肉左上CD.不透明度 = value;
    			筋肉_筋肉右下CD.不透明度 = value;
    			筋肉_筋肉右中CD.不透明度 = value;
    			筋肉_筋肉右上CD.不透明度 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return RibCage_表示;
    		}
    		set
    		{
    			RibCage_表示 = value;
    			筋肉_筋肉左_表示 = value;
    			筋肉_筋肉右_表示 = value;
    			筋肉_筋肉中_表示 = value;
    			筋肉_筋肉左下_表示 = value;
    			筋肉_筋肉左中_表示 = value;
    			筋肉_筋肉左上_表示 = value;
    			筋肉_筋肉右下_表示 = value;
    			筋肉_筋肉右中_表示 = value;
    			筋肉_筋肉右上_表示 = value;
    			紋柄_紋左_紋1_表示 = value;
    			紋柄_紋左_紋2_表示 = value;
    			紋柄_紋左_紋3_表示 = value;
    			紋柄_紋左_紋4_表示 = value;
    			紋柄_紋右_紋1_表示 = value;
    			紋柄_紋右_紋2_表示 = value;
    			紋柄_紋右_紋3_表示 = value;
    			紋柄_紋右_紋4_表示 = value;
    			虎柄_虎左_虎1_表示 = value;
    			虎柄_虎左_虎2_表示 = value;
    			虎柄_虎右_虎1_表示 = value;
    			虎柄_虎右_虎2_表示 = value;
    			竜性_中_鱗左_表示 = value;
    			竜性_中_鱗右_表示 = value;
    			竜性_中_鱗1_表示 = value;
    			竜性_中_鱗2_表示 = value;
    			竜性_左_鱗1_表示 = value;
    			竜性_左_鱗2_表示 = value;
    			竜性_左_鱗3_表示 = value;
    			竜性_右_鱗1_表示 = value;
    			竜性_右_鱗2_表示 = value;
    			竜性_右_鱗3_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return RibCageCD.不透明度;
    		}
    		set
    		{
    			RibCageCD.不透明度 = value;
    			筋肉_筋肉左CD.不透明度 = value;
    			筋肉_筋肉右CD.不透明度 = value;
    			筋肉_筋肉中CD.不透明度 = value;
    			筋肉_筋肉左下CD.不透明度 = value;
    			筋肉_筋肉左中CD.不透明度 = value;
    			筋肉_筋肉左上CD.不透明度 = value;
    			筋肉_筋肉右下CD.不透明度 = value;
    			筋肉_筋肉右中CD.不透明度 = value;
    			筋肉_筋肉右上CD.不透明度 = value;
    			紋柄_紋左_紋1CD.不透明度 = value;
    			紋柄_紋左_紋2CD.不透明度 = value;
    			紋柄_紋左_紋3CD.不透明度 = value;
    			紋柄_紋左_紋4CD.不透明度 = value;
    			紋柄_紋右_紋1CD.不透明度 = value;
    			紋柄_紋右_紋2CD.不透明度 = value;
    			紋柄_紋右_紋3CD.不透明度 = value;
    			紋柄_紋右_紋4CD.不透明度 = value;
    			虎柄_虎左_虎1CD.不透明度 = value;
    			虎柄_虎左_虎2CD.不透明度 = value;
    			虎柄_虎右_虎1CD.不透明度 = value;
    			虎柄_虎右_虎2CD.不透明度 = value;
    			竜性_中_鱗左CD.不透明度 = value;
    			竜性_中_鱗右CD.不透明度 = value;
    			竜性_中_鱗1CD.不透明度 = value;
    			竜性_中_鱗2CD.不透明度 = value;
    			竜性_左_鱗1CD.不透明度 = value;
    			竜性_左_鱗2CD.不透明度 = value;
    			竜性_左_鱗3CD.不透明度 = value;
    			竜性_右_鱗1CD.不透明度 = value;
    			竜性_右_鱗2CD.不透明度 = value;
    			竜性_右_鱗3CD.不透明度 = value;
    		}
    	}

    	public JointS 脇左_接続点 => new JointS(Body, X0Y0_RibCage, 0);

    	public JointS 脇右_接続点 => new JointS(Body, X0Y0_RibCage, 1);

    	public JointS Torso_接続点 => new JointS(Body, X0Y0_RibCage, 9);

    	public JointS LeftBreast_接続点 => new JointS(Body, X0Y0_RibCage, 2);

    	public JointS 胸右_接続点 => new JointS(Body, X0Y0_RibCage, 3);

    	public JointS 肌_接続点 => new JointS(Body, X0Y0_RibCage, 10);

    	public JointS 翼上左_接続点 => new JointS(Body, X0Y0_RibCage, 7);

    	public JointS 翼上右_接続点 => new JointS(Body, X0Y0_RibCage, 8);

    	public JointS 翼下左_接続点 => new JointS(Body, X0Y0_RibCage, 11);

    	public JointS 翼下右_接続点 => new JointS(Body, X0Y0_RibCage, 12);

    	public JointS 背中_接続点 => new JointS(Body, X0Y0_RibCage, 10);

    	public 四足胸(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 四足胸D e)
    	{
    		四足胸 四足胸2 = this;
    		ThisType = GetType();
    		Body = new VariantGrid(GlobalState.半身["四足胸郭"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_RibCage = partGroup["胸郭"].ToPar();
    		PartGroup pars2 = partGroup["筋肉"].ToPars();
    		X0Y0_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
    		X0Y0_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
    		X0Y0_筋肉_筋肉中 = pars2["筋肉中"].ToPar();
    		X0Y0_筋肉_筋肉左下 = pars2["筋肉左下"].ToPar();
    		X0Y0_筋肉_筋肉左中 = pars2["筋肉左中"].ToPar();
    		X0Y0_筋肉_筋肉左上 = pars2["筋肉左上"].ToPar();
    		X0Y0_筋肉_筋肉右下 = pars2["筋肉右下"].ToPar();
    		X0Y0_筋肉_筋肉右中 = pars2["筋肉右中"].ToPar();
    		X0Y0_筋肉_筋肉右上 = pars2["筋肉右上"].ToPar();
    		pars2 = partGroup["紋柄"].ToPars();
    		PartGroup pars3 = pars2["紋左"].ToPars();
    		X0Y0_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
    		X0Y0_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
    		X0Y0_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
    		X0Y0_紋柄_紋左_紋4 = pars3["紋4"].ToPar();
    		pars3 = pars2["紋右"].ToPars();
    		X0Y0_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
    		X0Y0_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
    		X0Y0_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
    		X0Y0_紋柄_紋右_紋4 = pars3["紋4"].ToPar();
    		pars2 = partGroup["虎柄"].ToPars();
    		pars3 = pars2["虎左"].ToPars();
    		X0Y0_虎柄_虎左_虎1 = pars3["虎1"].ToPar();
    		X0Y0_虎柄_虎左_虎2 = pars3["虎2"].ToPar();
    		pars3 = pars2["虎右"].ToPars();
    		X0Y0_虎柄_虎右_虎1 = pars3["虎1"].ToPar();
    		X0Y0_虎柄_虎右_虎2 = pars3["虎2"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		pars3 = pars2["中"].ToPars();
    		X0Y0_竜性_中_鱗左 = pars3["鱗左"].ToPar();
    		X0Y0_竜性_中_鱗右 = pars3["鱗右"].ToPar();
    		X0Y0_竜性_中_鱗1 = pars3["鱗1"].ToPar();
    		X0Y0_竜性_中_鱗2 = pars3["鱗2"].ToPar();
    		pars3 = pars2["左"].ToPars();
    		X0Y0_竜性_左_鱗1 = pars3["鱗1"].ToPar();
    		X0Y0_竜性_左_鱗2 = pars3["鱗2"].ToPar();
    		X0Y0_竜性_左_鱗3 = pars3["鱗3"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y0_竜性_右_鱗1 = pars3["鱗1"].ToPar();
    		X0Y0_竜性_右_鱗2 = pars3["鱗2"].ToPar();
    		X0Y0_竜性_右_鱗3 = pars3["鱗3"].ToPar();
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
    		RibCage_表示 = e.RibCage_表示;
    		筋肉_筋肉左_表示 = e.筋肉_筋肉左_表示;
    		筋肉_筋肉右_表示 = e.筋肉_筋肉右_表示;
    		筋肉_筋肉中_表示 = e.筋肉_筋肉中_表示;
    		筋肉_筋肉左下_表示 = e.筋肉_筋肉左下_表示;
    		筋肉_筋肉左中_表示 = e.筋肉_筋肉左中_表示;
    		筋肉_筋肉左上_表示 = e.筋肉_筋肉左上_表示;
    		筋肉_筋肉右下_表示 = e.筋肉_筋肉右下_表示;
    		筋肉_筋肉右中_表示 = e.筋肉_筋肉右中_表示;
    		筋肉_筋肉右上_表示 = e.筋肉_筋肉右上_表示;
    		紋柄_紋左_紋1_表示 = e.紋柄_紋左_紋1_表示;
    		紋柄_紋左_紋2_表示 = e.紋柄_紋左_紋2_表示;
    		紋柄_紋左_紋3_表示 = e.紋柄_紋左_紋3_表示;
    		紋柄_紋左_紋4_表示 = e.紋柄_紋左_紋4_表示;
    		紋柄_紋右_紋1_表示 = e.紋柄_紋右_紋1_表示;
    		紋柄_紋右_紋2_表示 = e.紋柄_紋右_紋2_表示;
    		紋柄_紋右_紋3_表示 = e.紋柄_紋右_紋3_表示;
    		紋柄_紋右_紋4_表示 = e.紋柄_紋右_紋4_表示;
    		虎柄_虎左_虎1_表示 = e.虎柄_虎左_虎1_表示;
    		虎柄_虎左_虎2_表示 = e.虎柄_虎左_虎2_表示;
    		虎柄_虎右_虎1_表示 = e.虎柄_虎右_虎1_表示;
    		虎柄_虎右_虎2_表示 = e.虎柄_虎右_虎2_表示;
    		竜性_中_鱗左_表示 = e.竜性_中_鱗左_表示;
    		竜性_中_鱗右_表示 = e.竜性_中_鱗右_表示;
    		竜性_中_鱗1_表示 = e.竜性_中_鱗1_表示;
    		竜性_中_鱗2_表示 = e.竜性_中_鱗2_表示;
    		竜性_左_鱗1_表示 = e.竜性_左_鱗1_表示;
    		竜性_左_鱗2_表示 = e.竜性_左_鱗2_表示;
    		竜性_左_鱗3_表示 = e.竜性_左_鱗3_表示;
    		竜性_右_鱗1_表示 = e.竜性_右_鱗1_表示;
    		竜性_右_鱗2_表示 = e.竜性_右_鱗2_表示;
    		竜性_右_鱗3_表示 = e.竜性_右_鱗3_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Element f;
    		if (e.脇左_接続.Count > 0)
    		{
    			脇左_接続 = e.脇左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胸2;
    				f.ConnectionType = ConnectionInfo.四足胸_脇左_接続;
    				f.接続(四足胸2.脇左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.脇右_接続.Count > 0)
    		{
    			脇右_接続 = e.脇右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胸2;
    				f.ConnectionType = ConnectionInfo.四足胸_脇右_接続;
    				f.接続(四足胸2.脇右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.Torso_接続.Count > 0)
    		{
    			Torso_接続 = e.Torso_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胸2;
    				f.ConnectionType = ConnectionInfo.四足胸_Torso_接続;
    				f.接続(四足胸2.Torso_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.LeftBreast_接続.Count > 0)
    		{
    			LeftBreast_接続 = e.LeftBreast_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胸2;
    				f.ConnectionType = ConnectionInfo.四足胸_LeftBreast_接続;
    				f.接続(四足胸2.LeftBreast_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.胸右_接続.Count > 0)
    		{
    			胸右_接続 = e.胸右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胸2;
    				f.ConnectionType = ConnectionInfo.四足胸_胸右_接続;
    				f.接続(四足胸2.胸右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.肌_接続.Count > 0)
    		{
    			肌_接続 = e.肌_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胸2;
    				f.ConnectionType = ConnectionInfo.四足胸_肌_接続;
    				f.接続(四足胸2.肌_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼上左_接続.Count > 0)
    		{
    			翼上左_接続 = e.翼上左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胸2;
    				f.ConnectionType = ConnectionInfo.四足胸_翼上左_接続;
    				f.接続(四足胸2.翼上左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼上右_接続.Count > 0)
    		{
    			翼上右_接続 = e.翼上右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胸2;
    				f.ConnectionType = ConnectionInfo.四足胸_翼上右_接続;
    				f.接続(四足胸2.翼上右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼下左_接続.Count > 0)
    		{
    			翼下左_接続 = e.翼下左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胸2;
    				f.ConnectionType = ConnectionInfo.四足胸_翼下左_接続;
    				f.接続(四足胸2.翼下左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼下右_接続.Count > 0)
    		{
    			翼下右_接続 = e.翼下右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胸2;
    				f.ConnectionType = ConnectionInfo.四足胸_翼下右_接続;
    				f.接続(四足胸2.翼下右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.背中_接続.Count > 0)
    		{
    			背中_接続 = e.背中_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足胸2;
    				f.ConnectionType = ConnectionInfo.四足胸_背中_接続;
    				f.接続(四足胸2.背中_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_RibCageCP = new ColorP(X0Y0_RibCage, RibCageCD, DisUnit, abj: true);
    		X0Y0_筋肉_筋肉左CP = new ColorP(X0Y0_筋肉_筋肉左, 筋肉_筋肉左CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉右CP = new ColorP(X0Y0_筋肉_筋肉右, 筋肉_筋肉右CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉中CP = new ColorP(X0Y0_筋肉_筋肉中, 筋肉_筋肉中CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉左下CP = new ColorP(X0Y0_筋肉_筋肉左下, 筋肉_筋肉左下CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉左中CP = new ColorP(X0Y0_筋肉_筋肉左中, 筋肉_筋肉左中CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉左上CP = new ColorP(X0Y0_筋肉_筋肉左上, 筋肉_筋肉左上CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉右下CP = new ColorP(X0Y0_筋肉_筋肉右下, 筋肉_筋肉右下CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉右中CP = new ColorP(X0Y0_筋肉_筋肉右中, 筋肉_筋肉右中CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉右上CP = new ColorP(X0Y0_筋肉_筋肉右上, 筋肉_筋肉右上CD, DisUnit, abj: false);
    		X0Y0_紋柄_紋左_紋1CP = new ColorP(X0Y0_紋柄_紋左_紋1, 紋柄_紋左_紋1CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋左_紋2CP = new ColorP(X0Y0_紋柄_紋左_紋2, 紋柄_紋左_紋2CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋左_紋3CP = new ColorP(X0Y0_紋柄_紋左_紋3, 紋柄_紋左_紋3CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋左_紋4CP = new ColorP(X0Y0_紋柄_紋左_紋4, 紋柄_紋左_紋4CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋右_紋1CP = new ColorP(X0Y0_紋柄_紋右_紋1, 紋柄_紋右_紋1CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋右_紋2CP = new ColorP(X0Y0_紋柄_紋右_紋2, 紋柄_紋右_紋2CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋右_紋3CP = new ColorP(X0Y0_紋柄_紋右_紋3, 紋柄_紋右_紋3CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋右_紋4CP = new ColorP(X0Y0_紋柄_紋右_紋4, 紋柄_紋右_紋4CD, DisUnit, abj: true);
    		X0Y0_虎柄_虎左_虎1CP = new ColorP(X0Y0_虎柄_虎左_虎1, 虎柄_虎左_虎1CD, DisUnit, abj: true);
    		X0Y0_虎柄_虎左_虎2CP = new ColorP(X0Y0_虎柄_虎左_虎2, 虎柄_虎左_虎2CD, DisUnit, abj: true);
    		X0Y0_虎柄_虎右_虎1CP = new ColorP(X0Y0_虎柄_虎右_虎1, 虎柄_虎右_虎1CD, DisUnit, abj: true);
    		X0Y0_虎柄_虎右_虎2CP = new ColorP(X0Y0_虎柄_虎右_虎2, 虎柄_虎右_虎2CD, DisUnit, abj: true);
    		X0Y0_竜性_中_鱗左CP = new ColorP(X0Y0_竜性_中_鱗左, 竜性_中_鱗左CD, DisUnit, abj: true);
    		X0Y0_竜性_中_鱗右CP = new ColorP(X0Y0_竜性_中_鱗右, 竜性_中_鱗右CD, DisUnit, abj: true);
    		X0Y0_竜性_中_鱗1CP = new ColorP(X0Y0_竜性_中_鱗1, 竜性_中_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_中_鱗2CP = new ColorP(X0Y0_竜性_中_鱗2, 竜性_中_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_左_鱗1CP = new ColorP(X0Y0_竜性_左_鱗1, 竜性_左_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_左_鱗2CP = new ColorP(X0Y0_竜性_左_鱗2, 竜性_左_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_左_鱗3CP = new ColorP(X0Y0_竜性_左_鱗3, 竜性_左_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性_右_鱗1CP = new ColorP(X0Y0_竜性_右_鱗1, 竜性_右_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_右_鱗2CP = new ColorP(X0Y0_竜性_右_鱗2, 竜性_右_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_右_鱗3CP = new ColorP(X0Y0_竜性_右_鱗3, 竜性_右_鱗3CD, DisUnit, abj: true);
    		筋肉濃度 = e.筋肉濃度;
    		Intensity = e.濃度;
    		尺度YB = 0.96;
    	}

    	public void 胸描画(RenderArea Are)
    	{
    		Are.Draw(X0Y0_RibCage);
    		Are.Draw(X0Y0_筋肉_筋肉左);
    		Are.Draw(X0Y0_筋肉_筋肉右);
    		Are.Draw(X0Y0_筋肉_筋肉中);
    		Are.Draw(X0Y0_筋肉_筋肉左下);
    		Are.Draw(X0Y0_筋肉_筋肉左中);
    		Are.Draw(X0Y0_筋肉_筋肉左上);
    		Are.Draw(X0Y0_筋肉_筋肉右下);
    		Are.Draw(X0Y0_筋肉_筋肉右中);
    		Are.Draw(X0Y0_筋肉_筋肉右上);
    		Are.Draw(X0Y0_竜性_中_鱗左);
    		Are.Draw(X0Y0_竜性_中_鱗右);
    		Are.Draw(X0Y0_竜性_中_鱗1);
    		Are.Draw(X0Y0_竜性_中_鱗2);
    	}

    	public void 肌描画(RenderArea Are)
    	{
    		Are.Draw(X0Y0_紋柄_紋左_紋1);
    		Are.Draw(X0Y0_紋柄_紋左_紋2);
    		Are.Draw(X0Y0_紋柄_紋左_紋3);
    		Are.Draw(X0Y0_紋柄_紋左_紋4);
    		Are.Draw(X0Y0_紋柄_紋右_紋1);
    		Are.Draw(X0Y0_紋柄_紋右_紋2);
    		Are.Draw(X0Y0_紋柄_紋右_紋3);
    		Are.Draw(X0Y0_紋柄_紋右_紋4);
    		Are.Draw(X0Y0_虎柄_虎左_虎1);
    		Are.Draw(X0Y0_虎柄_虎左_虎2);
    		Are.Draw(X0Y0_虎柄_虎右_虎1);
    		Are.Draw(X0Y0_虎柄_虎右_虎2);
    		Are.Draw(X0Y0_竜性_左_鱗1);
    		Are.Draw(X0Y0_竜性_左_鱗2);
    		Are.Draw(X0Y0_竜性_左_鱗3);
    		Are.Draw(X0Y0_竜性_右_鱗1);
    		Are.Draw(X0Y0_竜性_右_鱗2);
    		Are.Draw(X0Y0_竜性_右_鱗3);
    	}

    	public override void 色更新()
    	{
    		X0Y0_RibCageCP.Update();
    		X0Y0_筋肉_筋肉左CP.Update();
    		X0Y0_筋肉_筋肉右CP.Update();
    		X0Y0_筋肉_筋肉中CP.Update();
    		X0Y0_筋肉_筋肉左下CP.Update();
    		X0Y0_筋肉_筋肉左中CP.Update();
    		X0Y0_筋肉_筋肉左上CP.Update();
    		X0Y0_筋肉_筋肉右下CP.Update();
    		X0Y0_筋肉_筋肉右中CP.Update();
    		X0Y0_筋肉_筋肉右上CP.Update();
    		X0Y0_紋柄_紋左_紋1CP.Update();
    		X0Y0_紋柄_紋左_紋2CP.Update();
    		X0Y0_紋柄_紋左_紋3CP.Update();
    		X0Y0_紋柄_紋左_紋4CP.Update();
    		X0Y0_紋柄_紋右_紋1CP.Update();
    		X0Y0_紋柄_紋右_紋2CP.Update();
    		X0Y0_紋柄_紋右_紋3CP.Update();
    		X0Y0_紋柄_紋右_紋4CP.Update();
    		X0Y0_虎柄_虎左_虎1CP.Update();
    		X0Y0_虎柄_虎左_虎2CP.Update();
    		X0Y0_虎柄_虎右_虎1CP.Update();
    		X0Y0_虎柄_虎右_虎2CP.Update();
    		X0Y0_竜性_中_鱗左CP.Update();
    		X0Y0_竜性_中_鱗右CP.Update();
    		X0Y0_竜性_中_鱗1CP.Update();
    		X0Y0_竜性_中_鱗2CP.Update();
    		X0Y0_竜性_左_鱗1CP.Update();
    		X0Y0_竜性_左_鱗2CP.Update();
    		X0Y0_竜性_左_鱗3CP.Update();
    		X0Y0_竜性_右_鱗1CP.Update();
    		X0Y0_竜性_右_鱗2CP.Update();
    		X0Y0_竜性_右_鱗3CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		RibCageCD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉中CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉左下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉左中CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉左上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉右下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉右中CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉右上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		紋柄_紋左_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		虎柄_虎左_虎1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		虎柄_虎左_虎2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		虎柄_虎右_虎1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		虎柄_虎右_虎2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		竜性_中_鱗左CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_中_鱗右CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_中_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_中_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_左_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_左_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_左_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_右_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_右_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_右_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    	}
    }
}
