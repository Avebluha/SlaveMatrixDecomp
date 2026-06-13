using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class Chest : Element
    {
    	public ShapePart X0Y0_胸郭;

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

    	public ShapePart X0Y0_淫タトゥ_タトゥ左;

    	public ShapePart X0Y0_淫タトゥ_タトゥ右;

    	public ShapePart X0Y0_悪タトゥ_タトゥ左1;

    	public ShapePart X0Y0_悪タトゥ_タトゥ左2;

    	public ShapePart X0Y0_悪タトゥ_タトゥ左3;

    	public ShapePart X0Y0_悪タトゥ_タトゥ右1;

    	public ShapePart X0Y0_悪タトゥ_タトゥ右2;

    	public ShapePart X0Y0_悪タトゥ_タトゥ右3;

    	public ShapePart X0Y0_植タトゥ_左_上_タトゥ1;

    	public ShapePart X0Y0_植タトゥ_左_上_タトゥ2;

    	public ShapePart X0Y0_植タトゥ_左_下_タトゥ1;

    	public ShapePart X0Y0_植タトゥ_左_下_タトゥ2;

    	public ShapePart X0Y0_植タトゥ_右_上_タトゥ1;

    	public ShapePart X0Y0_植タトゥ_右_上_タトゥ2;

    	public ShapePart X0Y0_植タトゥ_右_下_タトゥ1;

    	public ShapePart X0Y0_植タトゥ_右_下_タトゥ2;

    	public ShapePart X0Y0_獣性_獣毛左1;

    	public ShapePart X0Y0_獣性_獣毛左2;

    	public ShapePart X0Y0_獣性_獣毛右1;

    	public ShapePart X0Y0_獣性_獣毛右2;

    	public ShapePart X0Y0_竜性_左_鱗1;

    	public ShapePart X0Y0_竜性_左_鱗2;

    	public ShapePart X0Y0_竜性_左_鱗3;

    	public ShapePart X0Y0_竜性_右_鱗1;

    	public ShapePart X0Y0_竜性_右_鱗2;

    	public ShapePart X0Y0_竜性_右_鱗3;

    	public ShapePart X0Y0_虫性_甲殻左_甲殻2_甲殻;

    	public ShapePart X0Y0_虫性_甲殻左_甲殻2_器官;

    	public ShapePart X0Y0_虫性_甲殻左_甲殻1_甲殻;

    	public ShapePart X0Y0_虫性_甲殻左_甲殻1_器官;

    	public ShapePart X0Y0_虫性_甲殻右_甲殻2_甲殻;

    	public ShapePart X0Y0_虫性_甲殻右_甲殻2_器官;

    	public ShapePart X0Y0_虫性_甲殻右_甲殻1_甲殻;

    	public ShapePart X0Y0_虫性_甲殻右_甲殻1_器官;

    	public ShapePart X0Y0_傷X左;

    	public ShapePart X0Y0_傷X右;

    	public ShapePart X0Y0_ハイライト外左;

    	public ShapePart X0Y0_ハイライト外右;

    	public ShapePart X0Y0_ハイライト内左;

    	public ShapePart X0Y0_ハイライト内右;

    	public ColorD 胸郭CD;

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

    	public ColorD 淫タトゥ_タトゥ左CD;

    	public ColorD 淫タトゥ_タトゥ右CD;

    	public ColorD 悪タトゥ_タトゥ左1CD;

    	public ColorD 悪タトゥ_タトゥ左2CD;

    	public ColorD 悪タトゥ_タトゥ左3CD;

    	public ColorD 悪タトゥ_タトゥ右1CD;

    	public ColorD 悪タトゥ_タトゥ右2CD;

    	public ColorD 悪タトゥ_タトゥ右3CD;

    	public ColorD 植タトゥ_左_上_タトゥ1CD;

    	public ColorD 植タトゥ_左_上_タトゥ2CD;

    	public ColorD 植タトゥ_左_下_タトゥ1CD;

    	public ColorD 植タトゥ_左_下_タトゥ2CD;

    	public ColorD 植タトゥ_右_上_タトゥ1CD;

    	public ColorD 植タトゥ_右_上_タトゥ2CD;

    	public ColorD 植タトゥ_右_下_タトゥ1CD;

    	public ColorD 植タトゥ_右_下_タトゥ2CD;

    	public ColorD 獣性_獣毛左1CD;

    	public ColorD 獣性_獣毛左2CD;

    	public ColorD 獣性_獣毛右1CD;

    	public ColorD 獣性_獣毛右2CD;

    	public ColorD 竜性_左_鱗1CD;

    	public ColorD 竜性_左_鱗2CD;

    	public ColorD 竜性_左_鱗3CD;

    	public ColorD 竜性_右_鱗1CD;

    	public ColorD 竜性_右_鱗2CD;

    	public ColorD 竜性_右_鱗3CD;

    	public ColorD 虫性_甲殻左_甲殻2_甲殻CD;

    	public ColorD 虫性_甲殻左_甲殻2_器官CD;

    	public ColorD 虫性_甲殻左_甲殻1_甲殻CD;

    	public ColorD 虫性_甲殻左_甲殻1_器官CD;

    	public ColorD 虫性_甲殻右_甲殻2_甲殻CD;

    	public ColorD 虫性_甲殻右_甲殻2_器官CD;

    	public ColorD 虫性_甲殻右_甲殻1_甲殻CD;

    	public ColorD 虫性_甲殻右_甲殻1_器官CD;

    	public ColorD 傷X左CD;

    	public ColorD 傷X右CD;

    	public ColorD ハイライト外左CD;

    	public ColorD ハイライト外右CD;

    	public ColorD ハイライト内左CD;

    	public ColorD ハイライト内右CD;

    	public ColorP X0Y0_胸郭CP;

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

    	public ColorP X0Y0_淫タトゥ_タトゥ左CP;

    	public ColorP X0Y0_淫タトゥ_タトゥ右CP;

    	public ColorP X0Y0_悪タトゥ_タトゥ左1CP;

    	public ColorP X0Y0_悪タトゥ_タトゥ左2CP;

    	public ColorP X0Y0_悪タトゥ_タトゥ左3CP;

    	public ColorP X0Y0_悪タトゥ_タトゥ右1CP;

    	public ColorP X0Y0_悪タトゥ_タトゥ右2CP;

    	public ColorP X0Y0_悪タトゥ_タトゥ右3CP;

    	public ColorP X0Y0_植タトゥ_左_上_タトゥ1CP;

    	public ColorP X0Y0_植タトゥ_左_上_タトゥ2CP;

    	public ColorP X0Y0_植タトゥ_左_下_タトゥ1CP;

    	public ColorP X0Y0_植タトゥ_左_下_タトゥ2CP;

    	public ColorP X0Y0_植タトゥ_右_上_タトゥ1CP;

    	public ColorP X0Y0_植タトゥ_右_上_タトゥ2CP;

    	public ColorP X0Y0_植タトゥ_右_下_タトゥ1CP;

    	public ColorP X0Y0_植タトゥ_右_下_タトゥ2CP;

    	public ColorP X0Y0_獣性_獣毛左1CP;

    	public ColorP X0Y0_獣性_獣毛左2CP;

    	public ColorP X0Y0_獣性_獣毛右1CP;

    	public ColorP X0Y0_獣性_獣毛右2CP;

    	public ColorP X0Y0_竜性_左_鱗1CP;

    	public ColorP X0Y0_竜性_左_鱗2CP;

    	public ColorP X0Y0_竜性_左_鱗3CP;

    	public ColorP X0Y0_竜性_右_鱗1CP;

    	public ColorP X0Y0_竜性_右_鱗2CP;

    	public ColorP X0Y0_竜性_右_鱗3CP;

    	public ColorP X0Y0_虫性_甲殻左_甲殻2_甲殻CP;

    	public ColorP X0Y0_虫性_甲殻左_甲殻2_器官CP;

    	public ColorP X0Y0_虫性_甲殻左_甲殻1_甲殻CP;

    	public ColorP X0Y0_虫性_甲殻左_甲殻1_器官CP;

    	public ColorP X0Y0_虫性_甲殻右_甲殻2_甲殻CP;

    	public ColorP X0Y0_虫性_甲殻右_甲殻2_器官CP;

    	public ColorP X0Y0_虫性_甲殻右_甲殻1_甲殻CP;

    	public ColorP X0Y0_虫性_甲殻右_甲殻1_器官CP;

    	public ColorP X0Y0_傷X左CP;

    	public ColorP X0Y0_傷X右CP;

    	public ColorP X0Y0_ハイライト外左CP;

    	public ColorP X0Y0_ハイライト外右CP;

    	public ColorP X0Y0_ハイライト内左CP;

    	public ColorP X0Y0_ハイライト内右CP;

    	public スタンプK キスマーク;

    	public スタンプW 鞭痕;

    	public Element[] Neck_接続;

    	public Element[] 肩左_接続;

    	public Element[] 肩右_接続;

    	public Element[] 胸左_接続;

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

    	public bool 胸郭_表示
    	{
    		get
    		{
    			return X0Y0_胸郭.Dra;
    		}
    		set
    		{
    			X0Y0_胸郭.Dra = value;
    			X0Y0_胸郭.Hit = value;
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

    	public bool 淫タトゥ_タトゥ左_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_タトゥ左.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_タトゥ左.Dra = value;
    			X0Y0_淫タトゥ_タトゥ左.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_タトゥ右_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_タトゥ右.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_タトゥ右.Dra = value;
    			X0Y0_淫タトゥ_タトゥ右.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_タトゥ左1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_タトゥ左1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_タトゥ左1.Dra = value;
    			X0Y0_悪タトゥ_タトゥ左1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_タトゥ左2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_タトゥ左2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_タトゥ左2.Dra = value;
    			X0Y0_悪タトゥ_タトゥ左2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_タトゥ左3_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_タトゥ左3.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_タトゥ左3.Dra = value;
    			X0Y0_悪タトゥ_タトゥ左3.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_タトゥ右1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_タトゥ右1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_タトゥ右1.Dra = value;
    			X0Y0_悪タトゥ_タトゥ右1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_タトゥ右2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_タトゥ右2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_タトゥ右2.Dra = value;
    			X0Y0_悪タトゥ_タトゥ右2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_タトゥ右3_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_タトゥ右3.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_タトゥ右3.Dra = value;
    			X0Y0_悪タトゥ_タトゥ右3.Hit = value;
    		}
    	}

    	public bool 植タトゥ_左_上_タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_左_上_タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_左_上_タトゥ1.Dra = value;
    			X0Y0_植タトゥ_左_上_タトゥ1.Hit = value;
    		}
    	}

    	public bool 植タトゥ_左_上_タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_左_上_タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_左_上_タトゥ2.Dra = value;
    			X0Y0_植タトゥ_左_上_タトゥ2.Hit = value;
    		}
    	}

    	public bool 植タトゥ_左_下_タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_左_下_タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_左_下_タトゥ1.Dra = value;
    			X0Y0_植タトゥ_左_下_タトゥ1.Hit = value;
    		}
    	}

    	public bool 植タトゥ_左_下_タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_左_下_タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_左_下_タトゥ2.Dra = value;
    			X0Y0_植タトゥ_左_下_タトゥ2.Hit = value;
    		}
    	}

    	public bool 植タトゥ_右_上_タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_右_上_タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_右_上_タトゥ1.Dra = value;
    			X0Y0_植タトゥ_右_上_タトゥ1.Hit = value;
    		}
    	}

    	public bool 植タトゥ_右_上_タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_右_上_タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_右_上_タトゥ2.Dra = value;
    			X0Y0_植タトゥ_右_上_タトゥ2.Hit = value;
    		}
    	}

    	public bool 植タトゥ_右_下_タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_右_下_タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_右_下_タトゥ1.Dra = value;
    			X0Y0_植タトゥ_右_下_タトゥ1.Hit = value;
    		}
    	}

    	public bool 植タトゥ_右_下_タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_右_下_タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_右_下_タトゥ2.Dra = value;
    			X0Y0_植タトゥ_右_下_タトゥ2.Hit = value;
    		}
    	}

    	public bool 獣性_獣毛左1_表示
    	{
    		get
    		{
    			return X0Y0_獣性_獣毛左1.Dra;
    		}
    		set
    		{
    			X0Y0_獣性_獣毛左1.Dra = value;
    			X0Y0_獣性_獣毛左1.Hit = value;
    		}
    	}

    	public bool 獣性_獣毛左2_表示
    	{
    		get
    		{
    			return X0Y0_獣性_獣毛左2.Dra;
    		}
    		set
    		{
    			X0Y0_獣性_獣毛左2.Dra = value;
    			X0Y0_獣性_獣毛左2.Hit = value;
    		}
    	}

    	public bool 獣性_獣毛右1_表示
    	{
    		get
    		{
    			return X0Y0_獣性_獣毛右1.Dra;
    		}
    		set
    		{
    			X0Y0_獣性_獣毛右1.Dra = value;
    			X0Y0_獣性_獣毛右1.Hit = value;
    		}
    	}

    	public bool 獣性_獣毛右2_表示
    	{
    		get
    		{
    			return X0Y0_獣性_獣毛右2.Dra;
    		}
    		set
    		{
    			X0Y0_獣性_獣毛右2.Dra = value;
    			X0Y0_獣性_獣毛右2.Hit = value;
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

    	public bool 虫性_甲殻左_甲殻2_甲殻_表示
    	{
    		get
    		{
    			return X0Y0_虫性_甲殻左_甲殻2_甲殻.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_甲殻左_甲殻2_甲殻.Dra = value;
    			X0Y0_虫性_甲殻左_甲殻2_甲殻.Hit = value;
    		}
    	}

    	public bool 虫性_甲殻左_甲殻2_器官_表示
    	{
    		get
    		{
    			return X0Y0_虫性_甲殻左_甲殻2_器官.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_甲殻左_甲殻2_器官.Dra = value;
    			X0Y0_虫性_甲殻左_甲殻2_器官.Hit = value;
    		}
    	}

    	public bool 虫性_甲殻左_甲殻1_甲殻_表示
    	{
    		get
    		{
    			return X0Y0_虫性_甲殻左_甲殻1_甲殻.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_甲殻左_甲殻1_甲殻.Dra = value;
    			X0Y0_虫性_甲殻左_甲殻1_甲殻.Hit = value;
    		}
    	}

    	public bool 虫性_甲殻左_甲殻1_器官_表示
    	{
    		get
    		{
    			return X0Y0_虫性_甲殻左_甲殻1_器官.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_甲殻左_甲殻1_器官.Dra = value;
    			X0Y0_虫性_甲殻左_甲殻1_器官.Hit = value;
    		}
    	}

    	public bool 虫性_甲殻右_甲殻2_甲殻_表示
    	{
    		get
    		{
    			return X0Y0_虫性_甲殻右_甲殻2_甲殻.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_甲殻右_甲殻2_甲殻.Dra = value;
    			X0Y0_虫性_甲殻右_甲殻2_甲殻.Hit = value;
    		}
    	}

    	public bool 虫性_甲殻右_甲殻2_器官_表示
    	{
    		get
    		{
    			return X0Y0_虫性_甲殻右_甲殻2_器官.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_甲殻右_甲殻2_器官.Dra = value;
    			X0Y0_虫性_甲殻右_甲殻2_器官.Hit = value;
    		}
    	}

    	public bool 虫性_甲殻右_甲殻1_甲殻_表示
    	{
    		get
    		{
    			return X0Y0_虫性_甲殻右_甲殻1_甲殻.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_甲殻右_甲殻1_甲殻.Dra = value;
    			X0Y0_虫性_甲殻右_甲殻1_甲殻.Hit = value;
    		}
    	}

    	public bool 虫性_甲殻右_甲殻1_器官_表示
    	{
    		get
    		{
    			return X0Y0_虫性_甲殻右_甲殻1_器官.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_甲殻右_甲殻1_器官.Dra = value;
    			X0Y0_虫性_甲殻右_甲殻1_器官.Hit = value;
    		}
    	}

    	public bool 傷X左_表示
    	{
    		get
    		{
    			return X0Y0_傷X左.Dra;
    		}
    		set
    		{
    			X0Y0_傷X左.Dra = value;
    			X0Y0_傷X左.Hit = value;
    		}
    	}

    	public bool 傷X右_表示
    	{
    		get
    		{
    			return X0Y0_傷X右.Dra;
    		}
    		set
    		{
    			X0Y0_傷X右.Dra = value;
    			X0Y0_傷X右.Hit = value;
    		}
    	}

    	public bool ハイライト外左_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト外左.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト外左.Dra = value;
    			X0Y0_ハイライト外左.Hit = value;
    		}
    	}

    	public bool ハイライト外右_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト外右.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト外右.Dra = value;
    			X0Y0_ハイライト外右.Hit = value;
    		}
    	}

    	public bool ハイライト内左_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト内左.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト内左.Dra = value;
    			X0Y0_ハイライト内左.Hit = value;
    		}
    	}

    	public bool ハイライト内右_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト内右.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト内右.Dra = value;
    			X0Y0_ハイライト内右.Hit = value;
    		}
    	}

    	public bool ハイライト表示
    	{
    		get
    		{
    			return ハイライト外左_表示;
    		}
    		set
    		{
    			ハイライト外左_表示 = value;
    			ハイライト外右_表示 = value;
    			ハイライト内左_表示 = value;
    			ハイライト内右_表示 = value;
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

    	public double 傷X左濃度
    	{
    		get
    		{
    			return 傷X左CD.不透明度;
    		}
    		set
    		{
    			傷X左CD.不透明度 = value;
    		}
    	}

    	public double 傷X右濃度
    	{
    		get
    		{
    			return 傷X右CD.不透明度;
    		}
    		set
    		{
    			傷X右CD.不透明度 = value;
    		}
    	}

    	public double ハイライト濃度
    	{
    		get
    		{
    			return ハイライト外左CD.不透明度;
    		}
    		set
    		{
    			ハイライト外左CD.不透明度 = value;
    			ハイライト外右CD.不透明度 = value;
    			ハイライト内左CD.不透明度 = value;
    			ハイライト内右CD.不透明度 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 胸郭_表示;
    		}
    		set
    		{
    			胸郭_表示 = value;
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
    			淫タトゥ_タトゥ左_表示 = value;
    			淫タトゥ_タトゥ右_表示 = value;
    			悪タトゥ_タトゥ左1_表示 = value;
    			悪タトゥ_タトゥ左2_表示 = value;
    			悪タトゥ_タトゥ左3_表示 = value;
    			悪タトゥ_タトゥ右1_表示 = value;
    			悪タトゥ_タトゥ右2_表示 = value;
    			悪タトゥ_タトゥ右3_表示 = value;
    			植タトゥ_左_上_タトゥ1_表示 = value;
    			植タトゥ_左_上_タトゥ2_表示 = value;
    			植タトゥ_左_下_タトゥ1_表示 = value;
    			植タトゥ_左_下_タトゥ2_表示 = value;
    			植タトゥ_右_上_タトゥ1_表示 = value;
    			植タトゥ_右_上_タトゥ2_表示 = value;
    			植タトゥ_右_下_タトゥ1_表示 = value;
    			植タトゥ_右_下_タトゥ2_表示 = value;
    			獣性_獣毛左1_表示 = value;
    			獣性_獣毛左2_表示 = value;
    			獣性_獣毛右1_表示 = value;
    			獣性_獣毛右2_表示 = value;
    			竜性_左_鱗1_表示 = value;
    			竜性_左_鱗2_表示 = value;
    			竜性_左_鱗3_表示 = value;
    			竜性_右_鱗1_表示 = value;
    			竜性_右_鱗2_表示 = value;
    			竜性_右_鱗3_表示 = value;
    			虫性_甲殻左_甲殻2_甲殻_表示 = value;
    			虫性_甲殻左_甲殻2_器官_表示 = value;
    			虫性_甲殻左_甲殻1_甲殻_表示 = value;
    			虫性_甲殻左_甲殻1_器官_表示 = value;
    			虫性_甲殻右_甲殻2_甲殻_表示 = value;
    			虫性_甲殻右_甲殻2_器官_表示 = value;
    			虫性_甲殻右_甲殻1_甲殻_表示 = value;
    			虫性_甲殻右_甲殻1_器官_表示 = value;
    			傷X左_表示 = value;
    			傷X右_表示 = value;
    			ハイライト外左_表示 = value;
    			ハイライト外右_表示 = value;
    			ハイライト内左_表示 = value;
    			ハイライト内右_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 胸郭CD.不透明度;
    		}
    		set
    		{
    			胸郭CD.不透明度 = value;
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
    			淫タトゥ_タトゥ左CD.不透明度 = value;
    			淫タトゥ_タトゥ右CD.不透明度 = value;
    			悪タトゥ_タトゥ左1CD.不透明度 = value;
    			悪タトゥ_タトゥ左2CD.不透明度 = value;
    			悪タトゥ_タトゥ左3CD.不透明度 = value;
    			悪タトゥ_タトゥ右1CD.不透明度 = value;
    			悪タトゥ_タトゥ右2CD.不透明度 = value;
    			悪タトゥ_タトゥ右3CD.不透明度 = value;
    			植タトゥ_左_上_タトゥ1CD.不透明度 = value;
    			植タトゥ_左_上_タトゥ2CD.不透明度 = value;
    			植タトゥ_左_下_タトゥ1CD.不透明度 = value;
    			植タトゥ_左_下_タトゥ2CD.不透明度 = value;
    			植タトゥ_右_上_タトゥ1CD.不透明度 = value;
    			植タトゥ_右_上_タトゥ2CD.不透明度 = value;
    			植タトゥ_右_下_タトゥ1CD.不透明度 = value;
    			植タトゥ_右_下_タトゥ2CD.不透明度 = value;
    			獣性_獣毛左1CD.不透明度 = value;
    			獣性_獣毛左2CD.不透明度 = value;
    			獣性_獣毛右1CD.不透明度 = value;
    			獣性_獣毛右2CD.不透明度 = value;
    			竜性_左_鱗1CD.不透明度 = value;
    			竜性_左_鱗2CD.不透明度 = value;
    			竜性_左_鱗3CD.不透明度 = value;
    			竜性_右_鱗1CD.不透明度 = value;
    			竜性_右_鱗2CD.不透明度 = value;
    			竜性_右_鱗3CD.不透明度 = value;
    			虫性_甲殻左_甲殻2_甲殻CD.不透明度 = value;
    			虫性_甲殻左_甲殻2_器官CD.不透明度 = value;
    			虫性_甲殻左_甲殻1_甲殻CD.不透明度 = value;
    			虫性_甲殻左_甲殻1_器官CD.不透明度 = value;
    			虫性_甲殻右_甲殻2_甲殻CD.不透明度 = value;
    			虫性_甲殻右_甲殻2_器官CD.不透明度 = value;
    			虫性_甲殻右_甲殻1_甲殻CD.不透明度 = value;
    			虫性_甲殻右_甲殻1_器官CD.不透明度 = value;
    			傷X左CD.不透明度 = value;
    			傷X右CD.不透明度 = value;
    			ハイライト外左CD.不透明度 = value;
    			ハイライト外右CD.不透明度 = value;
    			ハイライト内左CD.不透明度 = value;
    			ハイライト内右CD.不透明度 = value;
    		}
    	}

    	public JointS Neck_接続点 => new JointS(Body, X0Y0_胸郭, 0);

    	public JointS 肩左_接続点 => new JointS(Body, X0Y0_胸郭, 1);

    	public JointS 肩右_接続点 => new JointS(Body, X0Y0_胸郭, 2);

    	public JointS 胸左_接続点 => new JointS(Body, X0Y0_胸郭, 3);

    	public JointS 胸右_接続点 => new JointS(Body, X0Y0_胸郭, 4);

    	public JointS 肌_接続点 => new JointS(Body, X0Y0_胸郭, 10);

    	public JointS 翼上左_接続点 => new JointS(Body, X0Y0_胸郭, 8);

    	public JointS 翼上右_接続点 => new JointS(Body, X0Y0_胸郭, 9);

    	public JointS 翼下左_接続点 => new JointS(Body, X0Y0_胸郭, 11);

    	public JointS 翼下右_接続点 => new JointS(Body, X0Y0_胸郭, 12);

    	public JointS 背中_接続点 => new JointS(Body, X0Y0_胸郭, 10);

    	public Chest(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, ChestD e)
    	{
    		Chest Chest2 = this;
    		ThisType = GetType();
    		Body = new VariantGrid(Sta.胴体["胸郭"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_胸郭 = partGroup["胸郭"].ToPar();
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
    		pars2 = partGroup["淫タトゥ"].ToPars();
    		X0Y0_淫タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
    		X0Y0_淫タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
    		pars2 = partGroup["悪タトゥ"].ToPars();
    		X0Y0_悪タトゥ_タトゥ左1 = pars2["タトゥ左1"].ToPar();
    		X0Y0_悪タトゥ_タトゥ左2 = pars2["タトゥ左2"].ToPar();
    		X0Y0_悪タトゥ_タトゥ左3 = pars2["タトゥ左3"].ToPar();
    		X0Y0_悪タトゥ_タトゥ右1 = pars2["タトゥ右1"].ToPar();
    		X0Y0_悪タトゥ_タトゥ右2 = pars2["タトゥ右2"].ToPar();
    		X0Y0_悪タトゥ_タトゥ右3 = pars2["タトゥ右3"].ToPar();
    		pars2 = partGroup["植タトゥ"].ToPars();
    		pars3 = pars2["左"].ToPars();
    		PartGroup pars4 = pars3["上"].ToPars();
    		X0Y0_植タトゥ_左_上_タトゥ1 = pars4["タトゥ1"].ToPar();
    		X0Y0_植タトゥ_左_上_タトゥ2 = pars4["タトゥ2"].ToPar();
    		pars4 = pars3["下"].ToPars();
    		X0Y0_植タトゥ_左_下_タトゥ1 = pars4["タトゥ1"].ToPar();
    		X0Y0_植タトゥ_左_下_タトゥ2 = pars4["タトゥ2"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		pars4 = pars3["上"].ToPars();
    		X0Y0_植タトゥ_右_上_タトゥ1 = pars4["タトゥ1"].ToPar();
    		X0Y0_植タトゥ_右_上_タトゥ2 = pars4["タトゥ2"].ToPar();
    		pars4 = pars3["下"].ToPars();
    		X0Y0_植タトゥ_右_下_タトゥ1 = pars4["タトゥ1"].ToPar();
    		X0Y0_植タトゥ_右_下_タトゥ2 = pars4["タトゥ2"].ToPar();
    		pars2 = partGroup["獣性"].ToPars();
    		X0Y0_獣性_獣毛左1 = pars2["獣毛左1"].ToPar();
    		X0Y0_獣性_獣毛左2 = pars2["獣毛左2"].ToPar();
    		X0Y0_獣性_獣毛右1 = pars2["獣毛右1"].ToPar();
    		X0Y0_獣性_獣毛右2 = pars2["獣毛右2"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		pars3 = pars2["左"].ToPars();
    		X0Y0_竜性_左_鱗1 = pars3["鱗1"].ToPar();
    		X0Y0_竜性_左_鱗2 = pars3["鱗2"].ToPar();
    		X0Y0_竜性_左_鱗3 = pars3["鱗3"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y0_竜性_右_鱗1 = pars3["鱗1"].ToPar();
    		X0Y0_竜性_右_鱗2 = pars3["鱗2"].ToPar();
    		X0Y0_竜性_右_鱗3 = pars3["鱗3"].ToPar();
    		pars2 = partGroup["虫性"].ToPars();
    		pars3 = pars2["甲殻左"].ToPars();
    		pars4 = pars3["甲殻2"].ToPars();
    		X0Y0_虫性_甲殻左_甲殻2_甲殻 = pars4["甲殻"].ToPar();
    		X0Y0_虫性_甲殻左_甲殻2_器官 = pars4["器官"].ToPar();
    		pars4 = pars3["甲殻1"].ToPars();
    		X0Y0_虫性_甲殻左_甲殻1_甲殻 = pars4["甲殻"].ToPar();
    		X0Y0_虫性_甲殻左_甲殻1_器官 = pars4["器官"].ToPar();
    		pars3 = pars2["甲殻右"].ToPars();
    		pars4 = pars3["甲殻2"].ToPars();
    		X0Y0_虫性_甲殻右_甲殻2_甲殻 = pars4["甲殻"].ToPar();
    		X0Y0_虫性_甲殻右_甲殻2_器官 = pars4["器官"].ToPar();
    		pars4 = pars3["甲殻1"].ToPars();
    		X0Y0_虫性_甲殻右_甲殻1_甲殻 = pars4["甲殻"].ToPar();
    		X0Y0_虫性_甲殻右_甲殻1_器官 = pars4["器官"].ToPar();
    		X0Y0_傷X左 = partGroup["傷X左"].ToPar();
    		X0Y0_傷X右 = partGroup["傷X右"].ToPar();
    		X0Y0_ハイライト外左 = partGroup["ハイライト外左"].ToPar();
    		X0Y0_ハイライト外右 = partGroup["ハイライト外右"].ToPar();
    		X0Y0_ハイライト内左 = partGroup["ハイライト内左"].ToPar();
    		X0Y0_ハイライト内右 = partGroup["ハイライト内右"].ToPar();
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
    		胸郭_表示 = e.胸郭_表示;
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
    		淫タトゥ_タトゥ左_表示 = e.淫タトゥ_タトゥ左_表示;
    		淫タトゥ_タトゥ右_表示 = e.淫タトゥ_タトゥ右_表示;
    		悪タトゥ_タトゥ左1_表示 = e.悪タトゥ_タトゥ左1_表示;
    		悪タトゥ_タトゥ左2_表示 = e.悪タトゥ_タトゥ左2_表示;
    		悪タトゥ_タトゥ左3_表示 = e.悪タトゥ_タトゥ左3_表示;
    		悪タトゥ_タトゥ右1_表示 = e.悪タトゥ_タトゥ右1_表示;
    		悪タトゥ_タトゥ右2_表示 = e.悪タトゥ_タトゥ右2_表示;
    		悪タトゥ_タトゥ右3_表示 = e.悪タトゥ_タトゥ右3_表示;
    		植タトゥ_左_上_タトゥ1_表示 = e.植タトゥ_左_上_タトゥ1_表示;
    		植タトゥ_左_上_タトゥ2_表示 = e.植タトゥ_左_上_タトゥ2_表示;
    		植タトゥ_左_下_タトゥ1_表示 = e.植タトゥ_左_下_タトゥ1_表示;
    		植タトゥ_左_下_タトゥ2_表示 = e.植タトゥ_左_下_タトゥ2_表示;
    		植タトゥ_右_上_タトゥ1_表示 = e.植タトゥ_右_上_タトゥ1_表示;
    		植タトゥ_右_上_タトゥ2_表示 = e.植タトゥ_右_上_タトゥ2_表示;
    		植タトゥ_右_下_タトゥ1_表示 = e.植タトゥ_右_下_タトゥ1_表示;
    		植タトゥ_右_下_タトゥ2_表示 = e.植タトゥ_右_下_タトゥ2_表示;
    		獣性_獣毛左1_表示 = e.獣性_獣毛左1_表示;
    		獣性_獣毛左2_表示 = e.獣性_獣毛左2_表示;
    		獣性_獣毛右1_表示 = e.獣性_獣毛右1_表示;
    		獣性_獣毛右2_表示 = e.獣性_獣毛右2_表示;
    		竜性_左_鱗1_表示 = e.竜性_左_鱗1_表示;
    		竜性_左_鱗2_表示 = e.竜性_左_鱗2_表示;
    		竜性_左_鱗3_表示 = e.竜性_左_鱗3_表示;
    		竜性_右_鱗1_表示 = e.竜性_右_鱗1_表示;
    		竜性_右_鱗2_表示 = e.竜性_右_鱗2_表示;
    		竜性_右_鱗3_表示 = e.竜性_右_鱗3_表示;
    		虫性_甲殻左_甲殻2_甲殻_表示 = e.虫性_甲殻左_甲殻2_甲殻_表示;
    		虫性_甲殻左_甲殻2_器官_表示 = e.虫性_甲殻左_甲殻2_器官_表示;
    		虫性_甲殻左_甲殻1_甲殻_表示 = e.虫性_甲殻左_甲殻1_甲殻_表示;
    		虫性_甲殻左_甲殻1_器官_表示 = e.虫性_甲殻左_甲殻1_器官_表示;
    		虫性_甲殻右_甲殻2_甲殻_表示 = e.虫性_甲殻右_甲殻2_甲殻_表示;
    		虫性_甲殻右_甲殻2_器官_表示 = e.虫性_甲殻右_甲殻2_器官_表示;
    		虫性_甲殻右_甲殻1_甲殻_表示 = e.虫性_甲殻右_甲殻1_甲殻_表示;
    		虫性_甲殻右_甲殻1_器官_表示 = e.虫性_甲殻右_甲殻1_器官_表示;
    		傷X左_表示 = e.傷X左_表示;
    		傷X右_表示 = e.傷X右_表示;
    		ハイライト外左_表示 = e.ハイライト外左_表示;
    		ハイライト外右_表示 = e.ハイライト外右_表示;
    		ハイライト内左_表示 = e.ハイライト内左_表示;
    		ハイライト内右_表示 = e.ハイライト内右_表示;
    		ハイライト表示 = e.ハイライト表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Element f;
    		if (e.Neck_接続.Count > 0)
    		{
    			Neck_接続 = e.Neck_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Chest2;
    				f.ConnectionType = ConnectionInfo.Chest_Neck_接続;
    				f.接続(Chest2.Neck_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.肩左_接続.Count > 0)
    		{
    			肩左_接続 = e.肩左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Chest2;
    				f.ConnectionType = ConnectionInfo.Chest_肩左_接続;
    				f.接続(Chest2.肩左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.肩右_接続.Count > 0)
    		{
    			肩右_接続 = e.肩右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Chest2;
    				f.ConnectionType = ConnectionInfo.Chest_肩右_接続;
    				f.接続(Chest2.肩右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.胸左_接続.Count > 0)
    		{
    			胸左_接続 = e.胸左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Chest2;
    				f.ConnectionType = ConnectionInfo.Chest_胸左_接続;
    				f.接続(Chest2.胸左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.胸右_接続.Count > 0)
    		{
    			胸右_接続 = e.胸右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Chest2;
    				f.ConnectionType = ConnectionInfo.Chest_胸右_接続;
    				f.接続(Chest2.胸右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.肌_接続.Count > 0)
    		{
    			肌_接続 = e.肌_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Chest2;
    				f.ConnectionType = ConnectionInfo.Chest_肌_接続;
    				f.接続(Chest2.肌_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼上左_接続.Count > 0)
    		{
    			翼上左_接続 = e.翼上左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Chest2;
    				f.ConnectionType = ConnectionInfo.Chest_翼上左_接続;
    				f.接続(Chest2.翼上左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼上右_接続.Count > 0)
    		{
    			翼上右_接続 = e.翼上右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Chest2;
    				f.ConnectionType = ConnectionInfo.Chest_翼上右_接続;
    				f.接続(Chest2.翼上右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼下左_接続.Count > 0)
    		{
    			翼下左_接続 = e.翼下左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Chest2;
    				f.ConnectionType = ConnectionInfo.Chest_翼下左_接続;
    				f.接続(Chest2.翼下左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼下右_接続.Count > 0)
    		{
    			翼下右_接続 = e.翼下右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Chest2;
    				f.ConnectionType = ConnectionInfo.Chest_翼下右_接続;
    				f.接続(Chest2.翼下右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.背中_接続.Count > 0)
    		{
    			背中_接続 = e.背中_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Chest2;
    				f.ConnectionType = ConnectionInfo.Chest_背中_接続;
    				f.接続(Chest2.背中_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_胸郭CP = new ColorP(X0Y0_胸郭, 胸郭CD, DisUnit, abj: true);
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
    		X0Y0_淫タトゥ_タトゥ左CP = new ColorP(X0Y0_淫タトゥ_タトゥ左, 淫タトゥ_タトゥ左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_タトゥ右CP = new ColorP(X0Y0_淫タトゥ_タトゥ右, 淫タトゥ_タトゥ右CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_タトゥ左1CP = new ColorP(X0Y0_悪タトゥ_タトゥ左1, 悪タトゥ_タトゥ左1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_タトゥ左2CP = new ColorP(X0Y0_悪タトゥ_タトゥ左2, 悪タトゥ_タトゥ左2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_タトゥ左3CP = new ColorP(X0Y0_悪タトゥ_タトゥ左3, 悪タトゥ_タトゥ左3CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_タトゥ右1CP = new ColorP(X0Y0_悪タトゥ_タトゥ右1, 悪タトゥ_タトゥ右1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_タトゥ右2CP = new ColorP(X0Y0_悪タトゥ_タトゥ右2, 悪タトゥ_タトゥ右2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_タトゥ右3CP = new ColorP(X0Y0_悪タトゥ_タトゥ右3, 悪タトゥ_タトゥ右3CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_左_上_タトゥ1CP = new ColorP(X0Y0_植タトゥ_左_上_タトゥ1, 植タトゥ_左_上_タトゥ1CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_左_上_タトゥ2CP = new ColorP(X0Y0_植タトゥ_左_上_タトゥ2, 植タトゥ_左_上_タトゥ2CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_左_下_タトゥ1CP = new ColorP(X0Y0_植タトゥ_左_下_タトゥ1, 植タトゥ_左_下_タトゥ1CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_左_下_タトゥ2CP = new ColorP(X0Y0_植タトゥ_左_下_タトゥ2, 植タトゥ_左_下_タトゥ2CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_右_上_タトゥ1CP = new ColorP(X0Y0_植タトゥ_右_上_タトゥ1, 植タトゥ_右_上_タトゥ1CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_右_上_タトゥ2CP = new ColorP(X0Y0_植タトゥ_右_上_タトゥ2, 植タトゥ_右_上_タトゥ2CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_右_下_タトゥ1CP = new ColorP(X0Y0_植タトゥ_右_下_タトゥ1, 植タトゥ_右_下_タトゥ1CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_右_下_タトゥ2CP = new ColorP(X0Y0_植タトゥ_右_下_タトゥ2, 植タトゥ_右_下_タトゥ2CD, DisUnit, abj: true);
    		X0Y0_獣性_獣毛左1CP = new ColorP(X0Y0_獣性_獣毛左1, 獣性_獣毛左1CD, DisUnit, abj: true);
    		X0Y0_獣性_獣毛左2CP = new ColorP(X0Y0_獣性_獣毛左2, 獣性_獣毛左2CD, DisUnit, abj: true);
    		X0Y0_獣性_獣毛右1CP = new ColorP(X0Y0_獣性_獣毛右1, 獣性_獣毛右1CD, DisUnit, abj: true);
    		X0Y0_獣性_獣毛右2CP = new ColorP(X0Y0_獣性_獣毛右2, 獣性_獣毛右2CD, DisUnit, abj: true);
    		X0Y0_竜性_左_鱗1CP = new ColorP(X0Y0_竜性_左_鱗1, 竜性_左_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_左_鱗2CP = new ColorP(X0Y0_竜性_左_鱗2, 竜性_左_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_左_鱗3CP = new ColorP(X0Y0_竜性_左_鱗3, 竜性_左_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性_右_鱗1CP = new ColorP(X0Y0_竜性_右_鱗1, 竜性_右_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_右_鱗2CP = new ColorP(X0Y0_竜性_右_鱗2, 竜性_右_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_右_鱗3CP = new ColorP(X0Y0_竜性_右_鱗3, 竜性_右_鱗3CD, DisUnit, abj: true);
    		X0Y0_虫性_甲殻左_甲殻2_甲殻CP = new ColorP(X0Y0_虫性_甲殻左_甲殻2_甲殻, 虫性_甲殻左_甲殻2_甲殻CD, DisUnit, abj: true);
    		X0Y0_虫性_甲殻左_甲殻2_器官CP = new ColorP(X0Y0_虫性_甲殻左_甲殻2_器官, 虫性_甲殻左_甲殻2_器官CD, DisUnit, abj: true);
    		X0Y0_虫性_甲殻左_甲殻1_甲殻CP = new ColorP(X0Y0_虫性_甲殻左_甲殻1_甲殻, 虫性_甲殻左_甲殻1_甲殻CD, DisUnit, abj: true);
    		X0Y0_虫性_甲殻左_甲殻1_器官CP = new ColorP(X0Y0_虫性_甲殻左_甲殻1_器官, 虫性_甲殻左_甲殻1_器官CD, DisUnit, abj: true);
    		X0Y0_虫性_甲殻右_甲殻2_甲殻CP = new ColorP(X0Y0_虫性_甲殻右_甲殻2_甲殻, 虫性_甲殻右_甲殻2_甲殻CD, DisUnit, abj: true);
    		X0Y0_虫性_甲殻右_甲殻2_器官CP = new ColorP(X0Y0_虫性_甲殻右_甲殻2_器官, 虫性_甲殻右_甲殻2_器官CD, DisUnit, abj: true);
    		X0Y0_虫性_甲殻右_甲殻1_甲殻CP = new ColorP(X0Y0_虫性_甲殻右_甲殻1_甲殻, 虫性_甲殻右_甲殻1_甲殻CD, DisUnit, abj: true);
    		X0Y0_虫性_甲殻右_甲殻1_器官CP = new ColorP(X0Y0_虫性_甲殻右_甲殻1_器官, 虫性_甲殻右_甲殻1_器官CD, DisUnit, abj: true);
    		X0Y0_傷X左CP = new ColorP(X0Y0_傷X左, 傷X左CD, DisUnit, abj: true);
    		X0Y0_傷X右CP = new ColorP(X0Y0_傷X右, 傷X右CD, DisUnit, abj: true);
    		X0Y0_ハイライト外左CP = new ColorP(X0Y0_ハイライト外左, ハイライト外左CD, DisUnit, abj: true);
    		X0Y0_ハイライト外右CP = new ColorP(X0Y0_ハイライト外右, ハイライト外右CD, DisUnit, abj: true);
    		X0Y0_ハイライト内左CP = new ColorP(X0Y0_ハイライト内左, ハイライト内左CD, DisUnit, abj: true);
    		X0Y0_ハイライト内右CP = new ColorP(X0Y0_ハイライト内右, ハイライト内右CD, DisUnit, abj: true);
    		筋肉濃度 = e.筋肉濃度;
    		傷X左濃度 = e.傷X左濃度;
    		傷X右濃度 = e.傷X右濃度;
    		ハイライト濃度 = e.ハイライト濃度;
    		Intensity = e.濃度;
    		尺度B = 0.99;
    		尺度YB = 0.99;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_胸郭);
    		Are.Draw(X0Y0_筋肉_筋肉左);
    		Are.Draw(X0Y0_筋肉_筋肉右);
    		Are.Draw(X0Y0_筋肉_筋肉中);
    		Are.Draw(X0Y0_筋肉_筋肉左下);
    		Are.Draw(X0Y0_筋肉_筋肉左中);
    		Are.Draw(X0Y0_筋肉_筋肉左上);
    		Are.Draw(X0Y0_筋肉_筋肉右下);
    		Are.Draw(X0Y0_筋肉_筋肉右中);
    		Are.Draw(X0Y0_筋肉_筋肉右上);
    		Are.Draw(X0Y0_紋柄_紋左_紋1);
    		Are.Draw(X0Y0_紋柄_紋左_紋2);
    		Are.Draw(X0Y0_紋柄_紋左_紋3);
    		Are.Draw(X0Y0_紋柄_紋左_紋4);
    		Are.Draw(X0Y0_紋柄_紋右_紋1);
    		Are.Draw(X0Y0_紋柄_紋右_紋2);
    		Are.Draw(X0Y0_紋柄_紋右_紋3);
    		Are.Draw(X0Y0_紋柄_紋右_紋4);
    		Are.Draw(X0Y0_淫タトゥ_タトゥ左);
    		Are.Draw(X0Y0_淫タトゥ_タトゥ右);
    		Are.Draw(X0Y0_悪タトゥ_タトゥ左1);
    		Are.Draw(X0Y0_悪タトゥ_タトゥ左2);
    		Are.Draw(X0Y0_悪タトゥ_タトゥ左3);
    		Are.Draw(X0Y0_悪タトゥ_タトゥ右1);
    		Are.Draw(X0Y0_悪タトゥ_タトゥ右2);
    		Are.Draw(X0Y0_悪タトゥ_タトゥ右3);
    		Are.Draw(X0Y0_植タトゥ_左_上_タトゥ1);
    		Are.Draw(X0Y0_植タトゥ_左_上_タトゥ2);
    		Are.Draw(X0Y0_植タトゥ_左_下_タトゥ1);
    		Are.Draw(X0Y0_植タトゥ_左_下_タトゥ2);
    		Are.Draw(X0Y0_植タトゥ_右_上_タトゥ1);
    		Are.Draw(X0Y0_植タトゥ_右_上_タトゥ2);
    		Are.Draw(X0Y0_植タトゥ_右_下_タトゥ1);
    		Are.Draw(X0Y0_植タトゥ_右_下_タトゥ2);
    		Are.Draw(X0Y0_獣性_獣毛左1);
    		Are.Draw(X0Y0_獣性_獣毛左2);
    		Are.Draw(X0Y0_獣性_獣毛右1);
    		Are.Draw(X0Y0_獣性_獣毛右2);
    		Are.Draw(X0Y0_竜性_左_鱗1);
    		Are.Draw(X0Y0_竜性_左_鱗2);
    		Are.Draw(X0Y0_竜性_左_鱗3);
    		Are.Draw(X0Y0_竜性_右_鱗1);
    		Are.Draw(X0Y0_竜性_右_鱗2);
    		Are.Draw(X0Y0_竜性_右_鱗3);
    		Are.Draw(X0Y0_傷X左);
    		Are.Draw(X0Y0_傷X右);
    		キスマーク.Draw(Are);
    		鞭痕.Draw(Are);
    		Are.Draw(X0Y0_虫性_甲殻左_甲殻2_甲殻);
    		Are.Draw(X0Y0_虫性_甲殻左_甲殻2_器官);
    		Are.Draw(X0Y0_虫性_甲殻左_甲殻1_甲殻);
    		Are.Draw(X0Y0_虫性_甲殻左_甲殻1_器官);
    		Are.Draw(X0Y0_虫性_甲殻右_甲殻2_甲殻);
    		Are.Draw(X0Y0_虫性_甲殻右_甲殻2_器官);
    		Are.Draw(X0Y0_虫性_甲殻右_甲殻1_甲殻);
    		Are.Draw(X0Y0_虫性_甲殻右_甲殻1_器官);
    		Are.Draw(X0Y0_ハイライト外左);
    		Are.Draw(X0Y0_ハイライト外右);
    		Are.Draw(X0Y0_ハイライト内左);
    		Are.Draw(X0Y0_ハイライト内右);
    	}

    	public override void 色更新()
    	{
    		X0Y0_胸郭CP.Update();
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
    		X0Y0_淫タトゥ_タトゥ左CP.Update();
    		X0Y0_淫タトゥ_タトゥ右CP.Update();
    		X0Y0_悪タトゥ_タトゥ左1CP.Update();
    		X0Y0_悪タトゥ_タトゥ左2CP.Update();
    		X0Y0_悪タトゥ_タトゥ左3CP.Update();
    		X0Y0_悪タトゥ_タトゥ右1CP.Update();
    		X0Y0_悪タトゥ_タトゥ右2CP.Update();
    		X0Y0_悪タトゥ_タトゥ右3CP.Update();
    		X0Y0_植タトゥ_左_上_タトゥ1CP.Update();
    		X0Y0_植タトゥ_左_上_タトゥ2CP.Update();
    		X0Y0_植タトゥ_左_下_タトゥ1CP.Update();
    		X0Y0_植タトゥ_左_下_タトゥ2CP.Update();
    		X0Y0_植タトゥ_右_上_タトゥ1CP.Update();
    		X0Y0_植タトゥ_右_上_タトゥ2CP.Update();
    		X0Y0_植タトゥ_右_下_タトゥ1CP.Update();
    		X0Y0_植タトゥ_右_下_タトゥ2CP.Update();
    		X0Y0_獣性_獣毛左1CP.Update();
    		X0Y0_獣性_獣毛左2CP.Update();
    		X0Y0_獣性_獣毛右1CP.Update();
    		X0Y0_獣性_獣毛右2CP.Update();
    		X0Y0_竜性_左_鱗1CP.Update();
    		X0Y0_竜性_左_鱗2CP.Update();
    		X0Y0_竜性_左_鱗3CP.Update();
    		X0Y0_竜性_右_鱗1CP.Update();
    		X0Y0_竜性_右_鱗2CP.Update();
    		X0Y0_竜性_右_鱗3CP.Update();
    		X0Y0_虫性_甲殻左_甲殻2_甲殻CP.Update();
    		X0Y0_虫性_甲殻左_甲殻2_器官CP.Update();
    		X0Y0_虫性_甲殻左_甲殻1_甲殻CP.Update();
    		X0Y0_虫性_甲殻左_甲殻1_器官CP.Update();
    		X0Y0_虫性_甲殻右_甲殻2_甲殻CP.Update();
    		X0Y0_虫性_甲殻右_甲殻2_器官CP.Update();
    		X0Y0_虫性_甲殻右_甲殻1_甲殻CP.Update();
    		X0Y0_虫性_甲殻右_甲殻1_器官CP.Update();
    		X0Y0_傷X左CP.Update();
    		X0Y0_傷X右CP.Update();
    		X0Y0_ハイライト外左CP.Update();
    		X0Y0_ハイライト外右CP.Update();
    		X0Y0_ハイライト内左CP.Update();
    		X0Y0_ハイライト内右CP.Update();
    	}

    	public override void 色更新(Vector2D[] mm)
    	{
    		X0Y0_胸郭CP.Update(mm);
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
    		X0Y0_淫タトゥ_タトゥ左CP.Update();
    		X0Y0_淫タトゥ_タトゥ右CP.Update();
    		X0Y0_悪タトゥ_タトゥ左1CP.Update();
    		X0Y0_悪タトゥ_タトゥ左2CP.Update();
    		X0Y0_悪タトゥ_タトゥ左3CP.Update();
    		X0Y0_悪タトゥ_タトゥ右1CP.Update();
    		X0Y0_悪タトゥ_タトゥ右2CP.Update();
    		X0Y0_悪タトゥ_タトゥ右3CP.Update();
    		X0Y0_植タトゥ_左_上_タトゥ1CP.Update();
    		X0Y0_植タトゥ_左_上_タトゥ2CP.Update();
    		X0Y0_植タトゥ_左_下_タトゥ1CP.Update();
    		X0Y0_植タトゥ_左_下_タトゥ2CP.Update();
    		X0Y0_植タトゥ_右_上_タトゥ1CP.Update();
    		X0Y0_植タトゥ_右_上_タトゥ2CP.Update();
    		X0Y0_植タトゥ_右_下_タトゥ1CP.Update();
    		X0Y0_植タトゥ_右_下_タトゥ2CP.Update();
    		X0Y0_獣性_獣毛左1CP.Update();
    		X0Y0_獣性_獣毛左2CP.Update();
    		X0Y0_獣性_獣毛右1CP.Update();
    		X0Y0_獣性_獣毛右2CP.Update();
    		X0Y0_竜性_左_鱗1CP.Update();
    		X0Y0_竜性_左_鱗2CP.Update();
    		X0Y0_竜性_左_鱗3CP.Update();
    		X0Y0_竜性_右_鱗1CP.Update();
    		X0Y0_竜性_右_鱗2CP.Update();
    		X0Y0_竜性_右_鱗3CP.Update();
    		X0Y0_虫性_甲殻左_甲殻2_甲殻CP.Update();
    		X0Y0_虫性_甲殻左_甲殻2_器官CP.Update();
    		X0Y0_虫性_甲殻左_甲殻1_甲殻CP.Update();
    		X0Y0_虫性_甲殻左_甲殻1_器官CP.Update();
    		X0Y0_虫性_甲殻右_甲殻2_甲殻CP.Update();
    		X0Y0_虫性_甲殻右_甲殻2_器官CP.Update();
    		X0Y0_虫性_甲殻右_甲殻1_甲殻CP.Update();
    		X0Y0_虫性_甲殻右_甲殻1_器官CP.Update();
    		X0Y0_傷X左CP.Update();
    		X0Y0_傷X右CP.Update();
    		X0Y0_ハイライト外左CP.Update();
    		X0Y0_ハイライト外右CP.Update();
    		X0Y0_ハイライト内左CP.Update();
    		X0Y0_ハイライト内右CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		胸郭CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉中CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉左下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉左中CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉左上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉右下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉右中CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉右上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		紋柄_紋左_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		悪タトゥ_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		悪タトゥ_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		悪タトゥ_タトゥ左3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		悪タトゥ_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		悪タトゥ_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		悪タトゥ_タトゥ右3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_左_上_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_左_上_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_左_下_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_左_下_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_右_上_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_右_上_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_右_下_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_右_下_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		獣性_獣毛左1CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
    		獣性_獣毛左2CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
    		獣性_獣毛右1CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
    		獣性_獣毛右2CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
    		竜性_左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		虫性_甲殻左_甲殻2_甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性_甲殻左_甲殻2_器官CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
    		虫性_甲殻左_甲殻1_甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性_甲殻左_甲殻1_器官CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
    		虫性_甲殻右_甲殻2_甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性_甲殻右_甲殻2_器官CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
    		虫性_甲殻右_甲殻1_甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性_甲殻右_甲殻1_器官CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
    		傷X左CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷X右CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		ハイライト外左CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		ハイライト外右CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		ハイライト内左CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		ハイライト内右CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    	}
    }
}
