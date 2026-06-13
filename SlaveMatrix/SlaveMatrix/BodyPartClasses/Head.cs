using _2DGAMELIB;
using System.Linq;

namespace SlaveMatrix
{
    public class Head : Element
    {
    	public ShapePart X0Y0_Head;

    	public ShapePart X0Y0_悪タトゥ_逆十字_逆十字1;

    	public ShapePart X0Y0_悪タトゥ_逆十字_逆十字2;

    	public ShapePart X0Y0_隈取_タトゥ;

    	public ShapePart X0Y0_隈取_タトゥ左;

    	public ShapePart X0Y0_隈取_タトゥ右;

    	public ShapePart X0Y0_秘石_基;

    	public ShapePart X0Y0_秘石_秘石;

    	public ShapePart X0Y0_秘石_ハイライト;

    	public ShapePart X0Y0_蜘蛛_眼左1_基;

    	public ShapePart X0Y0_蜘蛛_眼左1_眼;

    	public ShapePart X0Y0_蜘蛛_眼左1_ハイライト;

    	public ShapePart X0Y0_蜘蛛_眼左2_基;

    	public ShapePart X0Y0_蜘蛛_眼左2_眼;

    	public ShapePart X0Y0_蜘蛛_眼左2_ハイライト;

    	public ShapePart X0Y0_蜘蛛_眼右1_基;

    	public ShapePart X0Y0_蜘蛛_眼右1_眼;

    	public ShapePart X0Y0_蜘蛛_眼右1_ハイライト;

    	public ShapePart X0Y0_蜘蛛_眼右2_基;

    	public ShapePart X0Y0_蜘蛛_眼右2_眼;

    	public ShapePart X0Y0_蜘蛛_眼右2_ハイライト;

    	public ShapePart X0Y0_羽虫_眼中_基;

    	public ShapePart X0Y0_羽虫_眼中_眼;

    	public ShapePart X0Y0_羽虫_眼中_ハイライト;

    	public ShapePart X0Y0_羽虫_眼左_基;

    	public ShapePart X0Y0_羽虫_眼左_眼;

    	public ShapePart X0Y0_羽虫_眼左_ハイライト;

    	public ShapePart X0Y0_羽虫_眼右_基;

    	public ShapePart X0Y0_羽虫_眼右_眼;

    	public ShapePart X0Y0_羽虫_眼右_ハイライト;

    	public ShapePart X0Y0_紋柄_紋;

    	public ShapePart X0Y0_紋柄_紋左1;

    	public ShapePart X0Y0_紋柄_紋右1;

    	public ShapePart X0Y0_紋柄_紋左2;

    	public ShapePart X0Y0_紋柄_紋右2;

    	public ShapePart X0Y0_竜性_鱗1;

    	public ShapePart X0Y0_竜性_鱗2;

    	public ShapePart X0Y0_竜性_鱗3;

    	public ShapePart X0Y0_馬柄_馬柄;

    	public ShapePart X0Y0_虫性_顎下;

    	public ColorD HeadCD;

    	public ColorD 悪タトゥ_逆十字_逆十字1CD;

    	public ColorD 悪タトゥ_逆十字_逆十字2CD;

    	public ColorD 隈取_タトゥCD;

    	public ColorD 隈取_タトゥ左CD;

    	public ColorD 隈取_タトゥ右CD;

    	public ColorD 秘石_基CD;

    	public ColorD 秘石_秘石CD;

    	public ColorD 秘石_ハイライトCD;

    	public ColorD 蜘蛛_眼左1_基CD;

    	public ColorD 蜘蛛_眼左1_眼CD;

    	public ColorD 蜘蛛_眼左1_ハイライトCD;

    	public ColorD 蜘蛛_眼左2_基CD;

    	public ColorD 蜘蛛_眼左2_眼CD;

    	public ColorD 蜘蛛_眼左2_ハイライトCD;

    	public ColorD 蜘蛛_眼右1_基CD;

    	public ColorD 蜘蛛_眼右1_眼CD;

    	public ColorD 蜘蛛_眼右1_ハイライトCD;

    	public ColorD 蜘蛛_眼右2_基CD;

    	public ColorD 蜘蛛_眼右2_眼CD;

    	public ColorD 蜘蛛_眼右2_ハイライトCD;

    	public ColorD 羽虫_眼中_基CD;

    	public ColorD 羽虫_眼中_眼CD;

    	public ColorD 羽虫_眼中_ハイライトCD;

    	public ColorD 羽虫_眼左_基CD;

    	public ColorD 羽虫_眼左_眼CD;

    	public ColorD 羽虫_眼左_ハイライトCD;

    	public ColorD 羽虫_眼右_基CD;

    	public ColorD 羽虫_眼右_眼CD;

    	public ColorD 羽虫_眼右_ハイライトCD;

    	public ColorD 紋柄_紋CD;

    	public ColorD 紋柄_紋左1CD;

    	public ColorD 紋柄_紋右1CD;

    	public ColorD 紋柄_紋左2CD;

    	public ColorD 紋柄_紋右2CD;

    	public ColorD 竜性_鱗1CD;

    	public ColorD 竜性_鱗2CD;

    	public ColorD 竜性_鱗3CD;

    	public ColorD 馬柄_馬柄CD;

    	public ColorD 虫性_顎下CD;

    	public ColorP X0Y0_HeadCP;

    	public ColorP X0Y0_悪タトゥ_逆十字_逆十字1CP;

    	public ColorP X0Y0_悪タトゥ_逆十字_逆十字2CP;

    	public ColorP X0Y0_隈取_タトゥCP;

    	public ColorP X0Y0_隈取_タトゥ左CP;

    	public ColorP X0Y0_隈取_タトゥ右CP;

    	public ColorP X0Y0_秘石_基CP;

    	public ColorP X0Y0_秘石_秘石CP;

    	public ColorP X0Y0_秘石_ハイライトCP;

    	public ColorP X0Y0_蜘蛛_眼左1_基CP;

    	public ColorP X0Y0_蜘蛛_眼左1_眼CP;

    	public ColorP X0Y0_蜘蛛_眼左1_ハイライトCP;

    	public ColorP X0Y0_蜘蛛_眼左2_基CP;

    	public ColorP X0Y0_蜘蛛_眼左2_眼CP;

    	public ColorP X0Y0_蜘蛛_眼左2_ハイライトCP;

    	public ColorP X0Y0_蜘蛛_眼右1_基CP;

    	public ColorP X0Y0_蜘蛛_眼右1_眼CP;

    	public ColorP X0Y0_蜘蛛_眼右1_ハイライトCP;

    	public ColorP X0Y0_蜘蛛_眼右2_基CP;

    	public ColorP X0Y0_蜘蛛_眼右2_眼CP;

    	public ColorP X0Y0_蜘蛛_眼右2_ハイライトCP;

    	public ColorP X0Y0_羽虫_眼中_基CP;

    	public ColorP X0Y0_羽虫_眼中_眼CP;

    	public ColorP X0Y0_羽虫_眼中_ハイライトCP;

    	public ColorP X0Y0_羽虫_眼左_基CP;

    	public ColorP X0Y0_羽虫_眼左_眼CP;

    	public ColorP X0Y0_羽虫_眼左_ハイライトCP;

    	public ColorP X0Y0_羽虫_眼右_基CP;

    	public ColorP X0Y0_羽虫_眼右_眼CP;

    	public ColorP X0Y0_羽虫_眼右_ハイライトCP;

    	public ColorP X0Y0_紋柄_紋CP;

    	public ColorP X0Y0_紋柄_紋左1CP;

    	public ColorP X0Y0_紋柄_紋右1CP;

    	public ColorP X0Y0_紋柄_紋左2CP;

    	public ColorP X0Y0_紋柄_紋右2CP;

    	public ColorP X0Y0_竜性_鱗1CP;

    	public ColorP X0Y0_竜性_鱗2CP;

    	public ColorP X0Y0_竜性_鱗3CP;

    	public ColorP X0Y0_馬柄_馬柄CP;

    	public ColorP X0Y0_虫性_顎下CP;

    	public Element[] 基髪_接続;

    	public Element[] 目左_接続;

    	public Element[] 目右_接続;

    	public Element[] 鼻_接続;

    	public Element[] 口_接続;

    	public Element[] 頬左_接続;

    	public Element[] 頬右_接続;

    	public Element[] 額_接続;

    	public Element[] 眉左_接続;

    	public Element[] 眉右_接続;

    	public Element[] 耳左_接続;

    	public Element[] 耳右_接続;

    	public Element[] 鼻肌_接続;

    	public Element[] 単眼目_接続;

    	public Element[] 単眼眉_接続;

    	public Element[] 大顎基_接続;

    	public Element[] 顔面_接続;

    	public Element[] 頭頂_接続;

    	public Element[] 頬肌左_接続;

    	public Element[] 頬肌右_接続;

    	public Element[] 触覚左_接続;

    	public Element[] 触覚右_接続;

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

    	public bool Head_表示
    	{
    		get
    		{
    			return X0Y0_Head.Dra;
    		}
    		set
    		{
    			X0Y0_Head.Dra = value;
    			X0Y0_Head.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_逆十字_逆十字1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_逆十字_逆十字1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_逆十字_逆十字1.Dra = value;
    			X0Y0_悪タトゥ_逆十字_逆十字1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_逆十字_逆十字2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_逆十字_逆十字2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_逆十字_逆十字2.Dra = value;
    			X0Y0_悪タトゥ_逆十字_逆十字2.Hit = value;
    		}
    	}

    	public bool 隈取_タトゥ_表示
    	{
    		get
    		{
    			return X0Y0_隈取_タトゥ.Dra;
    		}
    		set
    		{
    			X0Y0_隈取_タトゥ.Dra = value;
    			X0Y0_隈取_タトゥ.Hit = value;
    		}
    	}

    	public bool 隈取_タトゥ左_表示
    	{
    		get
    		{
    			return X0Y0_隈取_タトゥ左.Dra;
    		}
    		set
    		{
    			X0Y0_隈取_タトゥ左.Dra = value;
    			X0Y0_隈取_タトゥ左.Hit = value;
    		}
    	}

    	public bool 隈取_タトゥ右_表示
    	{
    		get
    		{
    			return X0Y0_隈取_タトゥ右.Dra;
    		}
    		set
    		{
    			X0Y0_隈取_タトゥ右.Dra = value;
    			X0Y0_隈取_タトゥ右.Hit = value;
    		}
    	}

    	public bool 秘石_基_表示
    	{
    		get
    		{
    			return X0Y0_秘石_基.Dra;
    		}
    		set
    		{
    			X0Y0_秘石_基.Dra = value;
    			X0Y0_秘石_基.Hit = value;
    		}
    	}

    	public bool 秘石_秘石_表示
    	{
    		get
    		{
    			return X0Y0_秘石_秘石.Dra;
    		}
    		set
    		{
    			X0Y0_秘石_秘石.Dra = value;
    			X0Y0_秘石_秘石.Hit = value;
    		}
    	}

    	public bool 秘石_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_秘石_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_秘石_ハイライト.Dra = value;
    			X0Y0_秘石_ハイライト.Hit = value;
    		}
    	}

    	public bool 蜘蛛_眼左1_基_表示
    	{
    		get
    		{
    			return X0Y0_蜘蛛_眼左1_基.Dra;
    		}
    		set
    		{
    			X0Y0_蜘蛛_眼左1_基.Dra = value;
    			X0Y0_蜘蛛_眼左1_基.Hit = value;
    		}
    	}

    	public bool 蜘蛛_眼左1_眼_表示
    	{
    		get
    		{
    			return X0Y0_蜘蛛_眼左1_眼.Dra;
    		}
    		set
    		{
    			X0Y0_蜘蛛_眼左1_眼.Dra = value;
    			X0Y0_蜘蛛_眼左1_眼.Hit = value;
    		}
    	}

    	public bool 蜘蛛_眼左1_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_蜘蛛_眼左1_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_蜘蛛_眼左1_ハイライト.Dra = value;
    			X0Y0_蜘蛛_眼左1_ハイライト.Hit = value;
    		}
    	}

    	public bool 蜘蛛_眼左2_基_表示
    	{
    		get
    		{
    			return X0Y0_蜘蛛_眼左2_基.Dra;
    		}
    		set
    		{
    			X0Y0_蜘蛛_眼左2_基.Dra = value;
    			X0Y0_蜘蛛_眼左2_基.Hit = value;
    		}
    	}

    	public bool 蜘蛛_眼左2_眼_表示
    	{
    		get
    		{
    			return X0Y0_蜘蛛_眼左2_眼.Dra;
    		}
    		set
    		{
    			X0Y0_蜘蛛_眼左2_眼.Dra = value;
    			X0Y0_蜘蛛_眼左2_眼.Hit = value;
    		}
    	}

    	public bool 蜘蛛_眼左2_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_蜘蛛_眼左2_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_蜘蛛_眼左2_ハイライト.Dra = value;
    			X0Y0_蜘蛛_眼左2_ハイライト.Hit = value;
    		}
    	}

    	public bool 蜘蛛_眼右1_基_表示
    	{
    		get
    		{
    			return X0Y0_蜘蛛_眼右1_基.Dra;
    		}
    		set
    		{
    			X0Y0_蜘蛛_眼右1_基.Dra = value;
    			X0Y0_蜘蛛_眼右1_基.Hit = value;
    		}
    	}

    	public bool 蜘蛛_眼右1_眼_表示
    	{
    		get
    		{
    			return X0Y0_蜘蛛_眼右1_眼.Dra;
    		}
    		set
    		{
    			X0Y0_蜘蛛_眼右1_眼.Dra = value;
    			X0Y0_蜘蛛_眼右1_眼.Hit = value;
    		}
    	}

    	public bool 蜘蛛_眼右1_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_蜘蛛_眼右1_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_蜘蛛_眼右1_ハイライト.Dra = value;
    			X0Y0_蜘蛛_眼右1_ハイライト.Hit = value;
    		}
    	}

    	public bool 蜘蛛_眼右2_基_表示
    	{
    		get
    		{
    			return X0Y0_蜘蛛_眼右2_基.Dra;
    		}
    		set
    		{
    			X0Y0_蜘蛛_眼右2_基.Dra = value;
    			X0Y0_蜘蛛_眼右2_基.Hit = value;
    		}
    	}

    	public bool 蜘蛛_眼右2_眼_表示
    	{
    		get
    		{
    			return X0Y0_蜘蛛_眼右2_眼.Dra;
    		}
    		set
    		{
    			X0Y0_蜘蛛_眼右2_眼.Dra = value;
    			X0Y0_蜘蛛_眼右2_眼.Hit = value;
    		}
    	}

    	public bool 蜘蛛_眼右2_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_蜘蛛_眼右2_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_蜘蛛_眼右2_ハイライト.Dra = value;
    			X0Y0_蜘蛛_眼右2_ハイライト.Hit = value;
    		}
    	}

    	public bool 羽虫_眼中_基_表示
    	{
    		get
    		{
    			return X0Y0_羽虫_眼中_基.Dra;
    		}
    		set
    		{
    			X0Y0_羽虫_眼中_基.Dra = value;
    			X0Y0_羽虫_眼中_基.Hit = value;
    		}
    	}

    	public bool 羽虫_眼中_眼_表示
    	{
    		get
    		{
    			return X0Y0_羽虫_眼中_眼.Dra;
    		}
    		set
    		{
    			X0Y0_羽虫_眼中_眼.Dra = value;
    			X0Y0_羽虫_眼中_眼.Hit = value;
    		}
    	}

    	public bool 羽虫_眼中_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_羽虫_眼中_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_羽虫_眼中_ハイライト.Dra = value;
    			X0Y0_羽虫_眼中_ハイライト.Hit = value;
    		}
    	}

    	public bool 羽虫_眼左_基_表示
    	{
    		get
    		{
    			return X0Y0_羽虫_眼左_基.Dra;
    		}
    		set
    		{
    			X0Y0_羽虫_眼左_基.Dra = value;
    			X0Y0_羽虫_眼左_基.Hit = value;
    		}
    	}

    	public bool 羽虫_眼左_眼_表示
    	{
    		get
    		{
    			return X0Y0_羽虫_眼左_眼.Dra;
    		}
    		set
    		{
    			X0Y0_羽虫_眼左_眼.Dra = value;
    			X0Y0_羽虫_眼左_眼.Hit = value;
    		}
    	}

    	public bool 羽虫_眼左_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_羽虫_眼左_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_羽虫_眼左_ハイライト.Dra = value;
    			X0Y0_羽虫_眼左_ハイライト.Hit = value;
    		}
    	}

    	public bool 羽虫_眼右_基_表示
    	{
    		get
    		{
    			return X0Y0_羽虫_眼右_基.Dra;
    		}
    		set
    		{
    			X0Y0_羽虫_眼右_基.Dra = value;
    			X0Y0_羽虫_眼右_基.Hit = value;
    		}
    	}

    	public bool 羽虫_眼右_眼_表示
    	{
    		get
    		{
    			return X0Y0_羽虫_眼右_眼.Dra;
    		}
    		set
    		{
    			X0Y0_羽虫_眼右_眼.Dra = value;
    			X0Y0_羽虫_眼右_眼.Hit = value;
    		}
    	}

    	public bool 羽虫_眼右_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_羽虫_眼右_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_羽虫_眼右_ハイライト.Dra = value;
    			X0Y0_羽虫_眼右_ハイライト.Hit = value;
    		}
    	}

    	public bool 紋柄_紋_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋.Dra = value;
    			X0Y0_紋柄_紋.Hit = value;
    		}
    	}

    	public bool 紋柄_紋左1_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋左1.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋左1.Dra = value;
    			X0Y0_紋柄_紋左1.Hit = value;
    		}
    	}

    	public bool 紋柄_紋右1_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋右1.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋右1.Dra = value;
    			X0Y0_紋柄_紋右1.Hit = value;
    		}
    	}

    	public bool 紋柄_紋左2_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋左2.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋左2.Dra = value;
    			X0Y0_紋柄_紋左2.Hit = value;
    		}
    	}

    	public bool 紋柄_紋右2_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋右2.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋右2.Dra = value;
    			X0Y0_紋柄_紋右2.Hit = value;
    		}
    	}

    	public bool 竜性_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗1.Dra = value;
    			X0Y0_竜性_鱗1.Hit = value;
    		}
    	}

    	public bool 竜性_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗2.Dra = value;
    			X0Y0_竜性_鱗2.Hit = value;
    		}
    	}

    	public bool 竜性_鱗3_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗3.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗3.Dra = value;
    			X0Y0_竜性_鱗3.Hit = value;
    		}
    	}

    	public bool 馬柄_馬柄_表示
    	{
    		get
    		{
    			return X0Y0_馬柄_馬柄.Dra;
    		}
    		set
    		{
    			X0Y0_馬柄_馬柄.Dra = value;
    			X0Y0_馬柄_馬柄.Hit = value;
    		}
    	}

    	public bool 虫性_顎下_表示
    	{
    		get
    		{
    			return X0Y0_虫性_顎下.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_顎下.Dra = value;
    			X0Y0_虫性_顎下.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return Head_表示;
    		}
    		set
    		{
    			Head_表示 = value;
    			悪タトゥ_逆十字_逆十字1_表示 = value;
    			悪タトゥ_逆十字_逆十字2_表示 = value;
    			隈取_タトゥ_表示 = value;
    			隈取_タトゥ左_表示 = value;
    			隈取_タトゥ右_表示 = value;
    			秘石_基_表示 = value;
    			秘石_秘石_表示 = value;
    			秘石_ハイライト_表示 = value;
    			蜘蛛_眼左1_基_表示 = value;
    			蜘蛛_眼左1_眼_表示 = value;
    			蜘蛛_眼左1_ハイライト_表示 = value;
    			蜘蛛_眼左2_基_表示 = value;
    			蜘蛛_眼左2_眼_表示 = value;
    			蜘蛛_眼左2_ハイライト_表示 = value;
    			蜘蛛_眼右1_基_表示 = value;
    			蜘蛛_眼右1_眼_表示 = value;
    			蜘蛛_眼右1_ハイライト_表示 = value;
    			蜘蛛_眼右2_基_表示 = value;
    			蜘蛛_眼右2_眼_表示 = value;
    			蜘蛛_眼右2_ハイライト_表示 = value;
    			羽虫_眼中_基_表示 = value;
    			羽虫_眼中_眼_表示 = value;
    			羽虫_眼中_ハイライト_表示 = value;
    			羽虫_眼左_基_表示 = value;
    			羽虫_眼左_眼_表示 = value;
    			羽虫_眼左_ハイライト_表示 = value;
    			羽虫_眼右_基_表示 = value;
    			羽虫_眼右_眼_表示 = value;
    			羽虫_眼右_ハイライト_表示 = value;
    			紋柄_紋_表示 = value;
    			紋柄_紋左1_表示 = value;
    			紋柄_紋右1_表示 = value;
    			紋柄_紋左2_表示 = value;
    			紋柄_紋右2_表示 = value;
    			竜性_鱗1_表示 = value;
    			竜性_鱗2_表示 = value;
    			竜性_鱗3_表示 = value;
    			馬柄_馬柄_表示 = value;
    			虫性_顎下_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return HeadCD.不透明度;
    		}
    		set
    		{
    			HeadCD.不透明度 = value;
    			悪タトゥ_逆十字_逆十字1CD.不透明度 = value;
    			悪タトゥ_逆十字_逆十字2CD.不透明度 = value;
    			隈取_タトゥCD.不透明度 = value;
    			隈取_タトゥ左CD.不透明度 = value;
    			隈取_タトゥ右CD.不透明度 = value;
    			秘石_基CD.不透明度 = value;
    			秘石_秘石CD.不透明度 = value;
    			秘石_ハイライトCD.不透明度 = value;
    			蜘蛛_眼左1_基CD.不透明度 = value;
    			蜘蛛_眼左1_眼CD.不透明度 = value;
    			蜘蛛_眼左1_ハイライトCD.不透明度 = value;
    			蜘蛛_眼左2_基CD.不透明度 = value;
    			蜘蛛_眼左2_眼CD.不透明度 = value;
    			蜘蛛_眼左2_ハイライトCD.不透明度 = value;
    			蜘蛛_眼右1_基CD.不透明度 = value;
    			蜘蛛_眼右1_眼CD.不透明度 = value;
    			蜘蛛_眼右1_ハイライトCD.不透明度 = value;
    			蜘蛛_眼右2_基CD.不透明度 = value;
    			蜘蛛_眼右2_眼CD.不透明度 = value;
    			蜘蛛_眼右2_ハイライトCD.不透明度 = value;
    			羽虫_眼中_基CD.不透明度 = value;
    			羽虫_眼中_眼CD.不透明度 = value;
    			羽虫_眼中_ハイライトCD.不透明度 = value;
    			羽虫_眼左_基CD.不透明度 = value;
    			羽虫_眼左_眼CD.不透明度 = value;
    			羽虫_眼左_ハイライトCD.不透明度 = value;
    			羽虫_眼右_基CD.不透明度 = value;
    			羽虫_眼右_眼CD.不透明度 = value;
    			羽虫_眼右_ハイライトCD.不透明度 = value;
    			紋柄_紋CD.不透明度 = value;
    			紋柄_紋左1CD.不透明度 = value;
    			紋柄_紋右1CD.不透明度 = value;
    			紋柄_紋左2CD.不透明度 = value;
    			紋柄_紋右2CD.不透明度 = value;
    			竜性_鱗1CD.不透明度 = value;
    			竜性_鱗2CD.不透明度 = value;
    			竜性_鱗3CD.不透明度 = value;
    			馬柄_馬柄CD.不透明度 = value;
    			虫性_顎下CD.不透明度 = value;
    		}
    	}

    	public double 目高
    	{
    		set
    		{
    			double y = 0.9975 + 0.004 * value.Inverse();
    			X0Y0_Head.JP[0].Joint = X0Y0_Head.JP[0].Joint.MulY(y);
    			X0Y0_Head.JP[1].Joint = X0Y0_Head.JP[1].Joint.MulY(y);
    			X0Y0_Head.JP[2].Joint = X0Y0_Head.JP[2].Joint.MulY(y);
    			X0Y0_Head.JP[8].Joint = X0Y0_Head.JP[8].Joint.MulY(y);
    			X0Y0_Head.JP[9].Joint = X0Y0_Head.JP[9].Joint.MulY(y);
    			X0Y0_Head.JP[12].Joint = X0Y0_Head.JP[12].Joint.MulY(y);
    			X0Y0_Head.JP[13].Joint = X0Y0_Head.JP[13].Joint.MulY(y);
    			X0Y0_Head.JP[14].Joint = X0Y0_Head.JP[14].Joint.MulY(y);
    			X0Y0_Head.JP[10].Joint = X0Y0_Head.JP[10].Joint.MulY(y);
    			X0Y0_Head.JP[11].Joint = X0Y0_Head.JP[11].Joint.MulY(y);
    			X0Y0_Head.JP[15].Joint = X0Y0_Head.JP[15].Joint.MulY(y);
    			X0Y0_Head.JP[16].Joint = X0Y0_Head.JP[16].Joint.MulY(y);
    		}
    	}

    	public double 目間
    	{
    		set
    		{
    			double num = 0.0007 * value;
    			X0Y0_Head.JP[1].Joint = X0Y0_Head.JP[1].Joint.AddX(0.0 - num);
    			X0Y0_Head.JP[2].Joint = X0Y0_Head.JP[2].Joint.AddX(num);
    			X0Y0_Head.JP[15].Joint = X0Y0_Head.JP[15].Joint.AddX(0.0 - num);
    			X0Y0_Head.JP[16].Joint = X0Y0_Head.JP[16].Joint.AddX(num);
    		}
    	}

    	public double 眉間
    	{
    		set
    		{
    			double num = 0.001 * value;
    			X0Y0_Head.JP[8].Joint = X0Y0_Head.JP[8].Joint.AddX(0.0 - num);
    			X0Y0_Head.JP[9].Joint = X0Y0_Head.JP[9].Joint.AddX(num);
    		}
    	}

    	public JointS 基髪_接続点 => new JointS(Body, X0Y0_Head, 0);

    	public JointS 目左_接続点 => new JointS(Body, X0Y0_Head, 1);

    	public JointS 目右_接続点 => new JointS(Body, X0Y0_Head, 2);

    	public JointS 鼻_接続点 => new JointS(Body, X0Y0_Head, 3);

    	public JointS 口_接続点 => new JointS(Body, X0Y0_Head, 4);

    	public JointS 頬左_接続点 => new JointS(Body, X0Y0_Head, 5);

    	public JointS 頬右_接続点 => new JointS(Body, X0Y0_Head, 6);

    	public JointS 額_接続点 => new JointS(Body, X0Y0_Head, 7);

    	public JointS 眉左_接続点 => new JointS(Body, X0Y0_Head, 8);

    	public JointS 眉右_接続点 => new JointS(Body, X0Y0_Head, 9);

    	public JointS 耳左_接続点 => new JointS(Body, X0Y0_Head, 10);

    	public JointS 耳右_接続点 => new JointS(Body, X0Y0_Head, 11);

    	public JointS 鼻肌_接続点 => new JointS(Body, X0Y0_Head, 12);

    	public JointS 単眼目_接続点 => new JointS(Body, X0Y0_Head, 13);

    	public JointS 単眼眉_接続点 => new JointS(Body, X0Y0_Head, 14);

    	public JointS 大顎基_接続点 => new JointS(Body, X0Y0_Head, 14);

    	public JointS 顔面_接続点 => new JointS(Body, X0Y0_Head, 13);

    	public JointS 頭頂_接続点 => new JointS(Body, X0Y0_Head, 14);

    	public JointS 頬肌左_接続点 => new JointS(Body, X0Y0_Head, 15);

    	public JointS 頬肌右_接続点 => new JointS(Body, X0Y0_Head, 16);

    	public JointS 触覚左_接続点 => new JointS(Body, X0Y0_Head, 17);

    	public JointS 触覚右_接続点 => new JointS(Body, X0Y0_Head, 18);

    	public Head(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, HeadD e)
    	{
    		Head 頭2 = this;
    		ThisType = GetType();
    		Body = new VariantGrid(Sta.胴体["Head"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_Head = partGroup["頭"].ToPar();
    		PartGroup pars2 = partGroup["悪タトゥ"].ToPars();
    		PartGroup pars3 = pars2["逆十字"].ToPars();
    		X0Y0_悪タトゥ_逆十字_逆十字1 = pars3["逆十字1"].ToPar();
    		X0Y0_悪タトゥ_逆十字_逆十字2 = pars3["逆十字2"].ToPar();
    		pars2 = partGroup["隈取"].ToPars();
    		X0Y0_隈取_タトゥ = pars2["タトゥ"].ToPar();
    		X0Y0_隈取_タトゥ左 = pars2["タトゥ左"].ToPar();
    		X0Y0_隈取_タトゥ右 = pars2["タトゥ右"].ToPar();
    		pars2 = partGroup["秘石"].ToPars();
    		X0Y0_秘石_基 = pars2["基"].ToPar();
    		X0Y0_秘石_秘石 = pars2["秘石"].ToPar();
    		X0Y0_秘石_ハイライト = pars2["ハイライト"].ToPar();
    		pars2 = partGroup["蜘蛛"].ToPars();
    		pars3 = pars2["眼左1"].ToPars();
    		X0Y0_蜘蛛_眼左1_基 = pars3["基"].ToPar();
    		X0Y0_蜘蛛_眼左1_眼 = pars3["眼"].ToPar();
    		X0Y0_蜘蛛_眼左1_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼左2"].ToPars();
    		X0Y0_蜘蛛_眼左2_基 = pars3["基"].ToPar();
    		X0Y0_蜘蛛_眼左2_眼 = pars3["眼"].ToPar();
    		X0Y0_蜘蛛_眼左2_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼右1"].ToPars();
    		X0Y0_蜘蛛_眼右1_基 = pars3["基"].ToPar();
    		X0Y0_蜘蛛_眼右1_眼 = pars3["眼"].ToPar();
    		X0Y0_蜘蛛_眼右1_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼右2"].ToPars();
    		X0Y0_蜘蛛_眼右2_基 = pars3["基"].ToPar();
    		X0Y0_蜘蛛_眼右2_眼 = pars3["眼"].ToPar();
    		X0Y0_蜘蛛_眼右2_ハイライト = pars3["ハイライト"].ToPar();
    		pars2 = partGroup["羽虫"].ToPars();
    		pars3 = pars2["眼中"].ToPars();
    		X0Y0_羽虫_眼中_基 = pars3["基"].ToPar();
    		X0Y0_羽虫_眼中_眼 = pars3["眼"].ToPar();
    		X0Y0_羽虫_眼中_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼左"].ToPars();
    		X0Y0_羽虫_眼左_基 = pars3["基"].ToPar();
    		X0Y0_羽虫_眼左_眼 = pars3["眼"].ToPar();
    		X0Y0_羽虫_眼左_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼右"].ToPars();
    		X0Y0_羽虫_眼右_基 = pars3["基"].ToPar();
    		X0Y0_羽虫_眼右_眼 = pars3["眼"].ToPar();
    		X0Y0_羽虫_眼右_ハイライト = pars3["ハイライト"].ToPar();
    		pars2 = partGroup["紋柄"].ToPars();
    		X0Y0_紋柄_紋 = pars2["紋"].ToPar();
    		X0Y0_紋柄_紋左1 = pars2["紋左1"].ToPar();
    		X0Y0_紋柄_紋右1 = pars2["紋右1"].ToPar();
    		X0Y0_紋柄_紋左2 = pars2["紋左2"].ToPar();
    		X0Y0_紋柄_紋右2 = pars2["紋右2"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
    		X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
    		pars2 = partGroup["牛柄"].ToPars();
    		X0Y0_馬柄_馬柄 = pars2["牛柄"].ToPar();
    		pars2 = partGroup["虫顎"].ToPars();
    		X0Y0_虫性_顎下 = pars2["顎下"].ToPar();
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
    		Head_表示 = e.頭_表示;
    		悪タトゥ_逆十字_逆十字1_表示 = e.悪タトゥ_逆十字_逆十字1_表示;
    		悪タトゥ_逆十字_逆十字2_表示 = e.悪タトゥ_逆十字_逆十字2_表示;
    		隈取_タトゥ_表示 = e.隈取_タトゥ_表示;
    		隈取_タトゥ左_表示 = e.隈取_タトゥ左_表示;
    		隈取_タトゥ右_表示 = e.隈取_タトゥ右_表示;
    		秘石_基_表示 = e.秘石_基_表示;
    		秘石_秘石_表示 = e.秘石_秘石_表示;
    		秘石_ハイライト_表示 = e.秘石_ハイライト_表示;
    		蜘蛛_眼左1_基_表示 = e.蜘蛛_眼左1_基_表示;
    		蜘蛛_眼左1_眼_表示 = e.蜘蛛_眼左1_眼_表示;
    		蜘蛛_眼左1_ハイライト_表示 = e.蜘蛛_眼左1_ハイライト_表示;
    		蜘蛛_眼左2_基_表示 = e.蜘蛛_眼左2_基_表示;
    		蜘蛛_眼左2_眼_表示 = e.蜘蛛_眼左2_眼_表示;
    		蜘蛛_眼左2_ハイライト_表示 = e.蜘蛛_眼左2_ハイライト_表示;
    		蜘蛛_眼右1_基_表示 = e.蜘蛛_眼右1_基_表示;
    		蜘蛛_眼右1_眼_表示 = e.蜘蛛_眼右1_眼_表示;
    		蜘蛛_眼右1_ハイライト_表示 = e.蜘蛛_眼右1_ハイライト_表示;
    		蜘蛛_眼右2_基_表示 = e.蜘蛛_眼右2_基_表示;
    		蜘蛛_眼右2_眼_表示 = e.蜘蛛_眼右2_眼_表示;
    		蜘蛛_眼右2_ハイライト_表示 = e.蜘蛛_眼右2_ハイライト_表示;
    		羽虫_眼中_基_表示 = e.羽虫_眼中_基_表示;
    		羽虫_眼中_眼_表示 = e.羽虫_眼中_眼_表示;
    		羽虫_眼中_ハイライト_表示 = e.羽虫_眼中_ハイライト_表示;
    		羽虫_眼左_基_表示 = e.羽虫_眼左_基_表示;
    		羽虫_眼左_眼_表示 = e.羽虫_眼左_眼_表示;
    		羽虫_眼左_ハイライト_表示 = e.羽虫_眼左_ハイライト_表示;
    		羽虫_眼右_基_表示 = e.羽虫_眼右_基_表示;
    		羽虫_眼右_眼_表示 = e.羽虫_眼右_眼_表示;
    		羽虫_眼右_ハイライト_表示 = e.羽虫_眼右_ハイライト_表示;
    		紋柄_紋_表示 = e.紋柄_紋_表示;
    		紋柄_紋左1_表示 = e.紋柄_紋左1_表示;
    		紋柄_紋右1_表示 = e.紋柄_紋右1_表示;
    		紋柄_紋左2_表示 = e.紋柄_紋左2_表示;
    		紋柄_紋右2_表示 = e.紋柄_紋右2_表示;
    		竜性_鱗1_表示 = e.竜性_鱗1_表示;
    		竜性_鱗2_表示 = e.竜性_鱗2_表示;
    		竜性_鱗3_表示 = e.竜性_鱗3_表示;
    		馬柄_馬柄_表示 = e.馬柄_馬柄_表示;
    		虫性_顎下_表示 = e.虫性_顎下_表示;
    		目高 = e.目高;
    		目間 = e.目間;
    		眉間 = e.眉間;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Element f;
    		if (e.基髪_接続.Count > 0)
    		{
    			基髪_接続 = e.基髪_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_基髪_接続;
    				f.接続(頭2.基髪_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.目左_接続.Count > 0)
    		{
    			目左_接続 = e.目左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_目左_接続;
    				f.接続(頭2.目左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.目右_接続.Count > 0)
    		{
    			目右_接続 = e.目右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_目右_接続;
    				f.接続(頭2.目右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.鼻_接続.Count > 0)
    		{
    			鼻_接続 = e.鼻_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_鼻_接続;
    				f.接続(頭2.鼻_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.口_接続.Count > 0)
    		{
    			口_接続 = e.口_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_口_接続;
    				f.接続(頭2.口_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.頬左_接続.Count > 0)
    		{
    			頬左_接続 = e.頬左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_頬左_接続;
    				f.接続(頭2.頬左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.頬右_接続.Count > 0)
    		{
    			頬右_接続 = e.頬右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_頬右_接続;
    				f.接続(頭2.頬右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.額_接続.Count > 0)
    		{
    			額_接続 = e.額_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_額_接続;
    				f.接続(頭2.額_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.眉左_接続.Count > 0)
    		{
    			眉左_接続 = e.眉左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_眉左_接続;
    				f.接続(頭2.眉左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.眉右_接続.Count > 0)
    		{
    			眉右_接続 = e.眉右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_眉右_接続;
    				f.接続(頭2.眉右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.耳左_接続.Count > 0)
    		{
    			耳左_接続 = e.耳左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_耳左_接続;
    				f.接続(頭2.耳左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.耳右_接続.Count > 0)
    		{
    			耳右_接続 = e.耳右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_耳右_接続;
    				f.接続(頭2.耳右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.鼻肌_接続.Count > 0)
    		{
    			鼻肌_接続 = e.鼻肌_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_鼻肌_接続;
    				f.接続(頭2.鼻肌_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.単眼目_接続.Count > 0)
    		{
    			単眼目_接続 = e.単眼目_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_単眼目_接続;
    				f.接続(頭2.単眼目_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.単眼眉_接続.Count > 0)
    		{
    			単眼眉_接続 = e.単眼眉_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_単眼眉_接続;
    				f.接続(頭2.単眼眉_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.大顎基_接続.Count > 0)
    		{
    			大顎基_接続 = e.大顎基_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_大顎基_接続;
    				f.接続(頭2.大顎基_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.顔面_接続.Count > 0)
    		{
    			顔面_接続 = e.顔面_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_顔面_接続;
    				f.接続(頭2.顔面_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.頭頂_接続.Count > 0)
    		{
    			頭頂_接続 = e.頭頂_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_頭頂_接続;
    				f.接続(頭2.頭頂_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.頬肌左_接続.Count > 0)
    		{
    			頬肌左_接続 = e.頬肌左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_頬肌左_接続;
    				f.接続(頭2.頬肌左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.頬肌右_接続.Count > 0)
    		{
    			頬肌右_接続 = e.頬肌右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_頬肌右_接続;
    				f.接続(頭2.頬肌右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.触覚左_接続.Count > 0)
    		{
    			触覚左_接続 = e.触覚左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_触覚左_接続;
    				f.接続(頭2.触覚左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.触覚右_接続.Count > 0)
    		{
    			触覚右_接続 = e.触覚右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 頭2;
    				f.ConnectionType = ConnectionInfo.Head_触覚右_接続;
    				f.接続(頭2.触覚右_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_HeadCP = new ColorP(X0Y0_Head, HeadCD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_逆十字_逆十字1CP = new ColorP(X0Y0_悪タトゥ_逆十字_逆十字1, 悪タトゥ_逆十字_逆十字1CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_逆十字_逆十字2CP = new ColorP(X0Y0_悪タトゥ_逆十字_逆十字2, 悪タトゥ_逆十字_逆十字2CD, DisUnit, abj: true);
    		X0Y0_隈取_タトゥCP = new ColorP(X0Y0_隈取_タトゥ, 隈取_タトゥCD, DisUnit, abj: true);
    		X0Y0_隈取_タトゥ左CP = new ColorP(X0Y0_隈取_タトゥ左, 隈取_タトゥ左CD, DisUnit, abj: true);
    		X0Y0_隈取_タトゥ右CP = new ColorP(X0Y0_隈取_タトゥ右, 隈取_タトゥ右CD, DisUnit, abj: true);
    		X0Y0_秘石_基CP = new ColorP(X0Y0_秘石_基, 秘石_基CD, DisUnit, abj: true);
    		X0Y0_秘石_秘石CP = new ColorP(X0Y0_秘石_秘石, 秘石_秘石CD, DisUnit, abj: true);
    		X0Y0_秘石_ハイライトCP = new ColorP(X0Y0_秘石_ハイライト, 秘石_ハイライトCD, DisUnit, abj: true);
    		X0Y0_蜘蛛_眼左1_基CP = new ColorP(X0Y0_蜘蛛_眼左1_基, 蜘蛛_眼左1_基CD, DisUnit, abj: true);
    		X0Y0_蜘蛛_眼左1_眼CP = new ColorP(X0Y0_蜘蛛_眼左1_眼, 蜘蛛_眼左1_眼CD, DisUnit, abj: true);
    		X0Y0_蜘蛛_眼左1_ハイライトCP = new ColorP(X0Y0_蜘蛛_眼左1_ハイライト, 蜘蛛_眼左1_ハイライトCD, DisUnit, abj: true);
    		X0Y0_蜘蛛_眼左2_基CP = new ColorP(X0Y0_蜘蛛_眼左2_基, 蜘蛛_眼左2_基CD, DisUnit, abj: true);
    		X0Y0_蜘蛛_眼左2_眼CP = new ColorP(X0Y0_蜘蛛_眼左2_眼, 蜘蛛_眼左2_眼CD, DisUnit, abj: true);
    		X0Y0_蜘蛛_眼左2_ハイライトCP = new ColorP(X0Y0_蜘蛛_眼左2_ハイライト, 蜘蛛_眼左2_ハイライトCD, DisUnit, abj: true);
    		X0Y0_蜘蛛_眼右1_基CP = new ColorP(X0Y0_蜘蛛_眼右1_基, 蜘蛛_眼右1_基CD, DisUnit, abj: true);
    		X0Y0_蜘蛛_眼右1_眼CP = new ColorP(X0Y0_蜘蛛_眼右1_眼, 蜘蛛_眼右1_眼CD, DisUnit, abj: true);
    		X0Y0_蜘蛛_眼右1_ハイライトCP = new ColorP(X0Y0_蜘蛛_眼右1_ハイライト, 蜘蛛_眼右1_ハイライトCD, DisUnit, abj: true);
    		X0Y0_蜘蛛_眼右2_基CP = new ColorP(X0Y0_蜘蛛_眼右2_基, 蜘蛛_眼右2_基CD, DisUnit, abj: true);
    		X0Y0_蜘蛛_眼右2_眼CP = new ColorP(X0Y0_蜘蛛_眼右2_眼, 蜘蛛_眼右2_眼CD, DisUnit, abj: true);
    		X0Y0_蜘蛛_眼右2_ハイライトCP = new ColorP(X0Y0_蜘蛛_眼右2_ハイライト, 蜘蛛_眼右2_ハイライトCD, DisUnit, abj: true);
    		X0Y0_羽虫_眼中_基CP = new ColorP(X0Y0_羽虫_眼中_基, 羽虫_眼中_基CD, DisUnit, abj: true);
    		X0Y0_羽虫_眼中_眼CP = new ColorP(X0Y0_羽虫_眼中_眼, 羽虫_眼中_眼CD, DisUnit, abj: true);
    		X0Y0_羽虫_眼中_ハイライトCP = new ColorP(X0Y0_羽虫_眼中_ハイライト, 羽虫_眼中_ハイライトCD, DisUnit, abj: true);
    		X0Y0_羽虫_眼左_基CP = new ColorP(X0Y0_羽虫_眼左_基, 羽虫_眼左_基CD, DisUnit, abj: true);
    		X0Y0_羽虫_眼左_眼CP = new ColorP(X0Y0_羽虫_眼左_眼, 羽虫_眼左_眼CD, DisUnit, abj: true);
    		X0Y0_羽虫_眼左_ハイライトCP = new ColorP(X0Y0_羽虫_眼左_ハイライト, 羽虫_眼左_ハイライトCD, DisUnit, abj: true);
    		X0Y0_羽虫_眼右_基CP = new ColorP(X0Y0_羽虫_眼右_基, 羽虫_眼右_基CD, DisUnit, abj: true);
    		X0Y0_羽虫_眼右_眼CP = new ColorP(X0Y0_羽虫_眼右_眼, 羽虫_眼右_眼CD, DisUnit, abj: true);
    		X0Y0_羽虫_眼右_ハイライトCP = new ColorP(X0Y0_羽虫_眼右_ハイライト, 羽虫_眼右_ハイライトCD, DisUnit, abj: true);
    		X0Y0_紋柄_紋CP = new ColorP(X0Y0_紋柄_紋, 紋柄_紋CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋左1CP = new ColorP(X0Y0_紋柄_紋左1, 紋柄_紋左1CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋右1CP = new ColorP(X0Y0_紋柄_紋右1, 紋柄_紋右1CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋左2CP = new ColorP(X0Y0_紋柄_紋左2, 紋柄_紋左2CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋右2CP = new ColorP(X0Y0_紋柄_紋右2, 紋柄_紋右2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗1CP = new ColorP(X0Y0_竜性_鱗1, 竜性_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗2CP = new ColorP(X0Y0_竜性_鱗2, 竜性_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗3CP = new ColorP(X0Y0_竜性_鱗3, 竜性_鱗3CD, DisUnit, abj: true);
    		X0Y0_馬柄_馬柄CP = new ColorP(X0Y0_馬柄_馬柄, 馬柄_馬柄CD, DisUnit, abj: true);
    		X0Y0_虫性_顎下CP = new ColorP(X0Y0_虫性_顎下, 虫性_顎下CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		X0Y0_Head.JP[8].Joint = X0Y0_Head.JP[8].Joint.AddX(-0.00012);
    		X0Y0_Head.JP[9].Joint = X0Y0_Head.JP[9].Joint.AddX(0.00012);
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_Head);
    	}

    	public override void 描画1(RenderArea Are)
    	{
    		Are.Draw(X0Y0_悪タトゥ_逆十字_逆十字1);
    		Are.Draw(X0Y0_悪タトゥ_逆十字_逆十字2);
    		Are.Draw(X0Y0_隈取_タトゥ);
    		Are.Draw(X0Y0_隈取_タトゥ左);
    		Are.Draw(X0Y0_隈取_タトゥ右);
    		Are.Draw(X0Y0_馬柄_馬柄);
    		Are.Draw(X0Y0_紋柄_紋);
    		Are.Draw(X0Y0_紋柄_紋左1);
    		Are.Draw(X0Y0_紋柄_紋右1);
    		Are.Draw(X0Y0_紋柄_紋左2);
    		Are.Draw(X0Y0_紋柄_紋右2);
    		Are.Draw(X0Y0_竜性_鱗1);
    		Are.Draw(X0Y0_竜性_鱗2);
    		Are.Draw(X0Y0_竜性_鱗3);
    		Are.Draw(X0Y0_秘石_基);
    		Are.Draw(X0Y0_秘石_秘石);
    		Are.Draw(X0Y0_秘石_ハイライト);
    		Are.Draw(X0Y0_蜘蛛_眼左1_基);
    		Are.Draw(X0Y0_蜘蛛_眼左1_眼);
    		Are.Draw(X0Y0_蜘蛛_眼左1_ハイライト);
    		Are.Draw(X0Y0_蜘蛛_眼左2_基);
    		Are.Draw(X0Y0_蜘蛛_眼左2_眼);
    		Are.Draw(X0Y0_蜘蛛_眼左2_ハイライト);
    		Are.Draw(X0Y0_蜘蛛_眼右1_基);
    		Are.Draw(X0Y0_蜘蛛_眼右1_眼);
    		Are.Draw(X0Y0_蜘蛛_眼右1_ハイライト);
    		Are.Draw(X0Y0_蜘蛛_眼右2_基);
    		Are.Draw(X0Y0_蜘蛛_眼右2_眼);
    		Are.Draw(X0Y0_蜘蛛_眼右2_ハイライト);
    		Are.Draw(X0Y0_羽虫_眼中_基);
    		Are.Draw(X0Y0_羽虫_眼中_眼);
    		Are.Draw(X0Y0_羽虫_眼中_ハイライト);
    		Are.Draw(X0Y0_羽虫_眼左_基);
    		Are.Draw(X0Y0_羽虫_眼左_眼);
    		Are.Draw(X0Y0_羽虫_眼左_ハイライト);
    		Are.Draw(X0Y0_羽虫_眼右_基);
    		Are.Draw(X0Y0_羽虫_眼右_眼);
    		Are.Draw(X0Y0_羽虫_眼右_ハイライト);
    	}

    	public override void 描画2(RenderArea Are)
    	{
    		Are.Draw(X0Y0_虫性_顎下);
    	}

    	private void 開顎(double Rate)
    	{
    		double y = 0.0003 * Rate;
    		ShapePart shapePart = Sta.胴体["Head"][0][0]["頭"].ToPar();
    		ShapePart x0Y0_頭 = X0Y0_Head;
    		x0Y0_頭.OP[0].ps[3] = shapePart.OP[0].ps[3].AddY(y);
    		x0Y0_頭.OP[0].ps[4] = shapePart.OP[0].ps[4].AddY(y);
    		x0Y0_頭.OP[1].ps[0] = shapePart.OP[1].ps[0].AddY(y);
    		x0Y0_頭.OP[1].ps[1] = shapePart.OP[1].ps[1].AddY(y);
    		x0Y0_頭.OP[1].ps[2] = shapePart.OP[1].ps[2].AddY(y);
    		x0Y0_頭.OP[1].ps[3] = shapePart.OP[1].ps[3].AddY(y);
    		x0Y0_頭.OP[2].ps[0] = shapePart.OP[2].ps[0].AddY(y);
    		x0Y0_頭.OP[2].ps[1] = shapePart.OP[2].ps[1].AddY(y);
    	}

    	public void 開顎(口 口)
    	{
    		if (口.Yi == 0)
    		{
    			開顎(0.5);
    		}
    		else if (口.Yi == 1)
    		{
    			開顎(0.8);
    		}
    		else if (口.Yi == 2)
    		{
    			開顎(0.0);
    		}
    		else if (口.Yi == 3)
    		{
    			開顎(0.0);
    		}
    		else if (口.Yi == 4)
    		{
    			開顎(0.0);
    		}
    		else if (口.Yi == 5)
    		{
    			開顎(0.5);
    		}
    		else if (口.Yi == 6)
    		{
    			開顎(0.5);
    		}
    		else if (口.Yi == 7)
    		{
    			開顎(0.0);
    		}
    		else if (口.Yi == 8)
    		{
    			開顎(0.0);
    		}
    		else if (口.Yi == 9)
    		{
    			開顎(0.8);
    		}
    		else if (口.Yi == 10)
    		{
    			開顎(0.0);
    		}
    		else if (口.Yi == 11)
    		{
    			開顎(0.0);
    		}
    		else if (口.Yi == 12)
    		{
    			開顎(1.0);
    		}
    		else if (口.Yi == 13)
    		{
    			開顎(1.0);
    		}
    	}

    	public override void 色更新()
    	{
    		X0Y0_HeadCP.Update();
    		X0Y0_悪タトゥ_逆十字_逆十字1CP.Update();
    		X0Y0_悪タトゥ_逆十字_逆十字2CP.Update();
    		X0Y0_隈取_タトゥCP.Update();
    		X0Y0_隈取_タトゥ左CP.Update();
    		X0Y0_隈取_タトゥ右CP.Update();
    		X0Y0_秘石_基CP.Update();
    		X0Y0_秘石_秘石CP.Update();
    		X0Y0_秘石_ハイライトCP.Update();
    		X0Y0_蜘蛛_眼左1_基CP.Update();
    		X0Y0_蜘蛛_眼左1_眼CP.Update();
    		X0Y0_蜘蛛_眼左1_ハイライトCP.Update();
    		X0Y0_蜘蛛_眼左2_基CP.Update();
    		X0Y0_蜘蛛_眼左2_眼CP.Update();
    		X0Y0_蜘蛛_眼左2_ハイライトCP.Update();
    		X0Y0_蜘蛛_眼右1_基CP.Update();
    		X0Y0_蜘蛛_眼右1_眼CP.Update();
    		X0Y0_蜘蛛_眼右1_ハイライトCP.Update();
    		X0Y0_蜘蛛_眼右2_基CP.Update();
    		X0Y0_蜘蛛_眼右2_眼CP.Update();
    		X0Y0_蜘蛛_眼右2_ハイライトCP.Update();
    		X0Y0_羽虫_眼中_基CP.Update();
    		X0Y0_羽虫_眼中_眼CP.Update();
    		X0Y0_羽虫_眼中_ハイライトCP.Update();
    		X0Y0_羽虫_眼左_基CP.Update();
    		X0Y0_羽虫_眼左_眼CP.Update();
    		X0Y0_羽虫_眼左_ハイライトCP.Update();
    		X0Y0_羽虫_眼右_基CP.Update();
    		X0Y0_羽虫_眼右_眼CP.Update();
    		X0Y0_羽虫_眼右_ハイライトCP.Update();
    		X0Y0_紋柄_紋CP.Update();
    		X0Y0_紋柄_紋左1CP.Update();
    		X0Y0_紋柄_紋右1CP.Update();
    		X0Y0_紋柄_紋左2CP.Update();
    		X0Y0_紋柄_紋右2CP.Update();
    		X0Y0_竜性_鱗1CP.Update();
    		X0Y0_竜性_鱗2CP.Update();
    		X0Y0_竜性_鱗3CP.Update();
    		X0Y0_馬柄_馬柄CP.Update();
    		X0Y0_虫性_顎下CP.Update();
    	}

    	public override void 色更新(Vector2D[] mm)
    	{
    		X0Y0_HeadCP.Update(mm);
    		X0Y0_悪タトゥ_逆十字_逆十字1CP.Update();
    		X0Y0_悪タトゥ_逆十字_逆十字2CP.Update();
    		X0Y0_隈取_タトゥCP.Update();
    		X0Y0_隈取_タトゥ左CP.Update();
    		X0Y0_隈取_タトゥ右CP.Update();
    		X0Y0_秘石_基CP.Update();
    		X0Y0_秘石_秘石CP.Update();
    		X0Y0_秘石_ハイライトCP.Update();
    		X0Y0_蜘蛛_眼左1_基CP.Update();
    		X0Y0_蜘蛛_眼左1_眼CP.Update();
    		X0Y0_蜘蛛_眼左1_ハイライトCP.Update();
    		X0Y0_蜘蛛_眼左2_基CP.Update();
    		X0Y0_蜘蛛_眼左2_眼CP.Update();
    		X0Y0_蜘蛛_眼左2_ハイライトCP.Update();
    		X0Y0_蜘蛛_眼右1_基CP.Update();
    		X0Y0_蜘蛛_眼右1_眼CP.Update();
    		X0Y0_蜘蛛_眼右1_ハイライトCP.Update();
    		X0Y0_蜘蛛_眼右2_基CP.Update();
    		X0Y0_蜘蛛_眼右2_眼CP.Update();
    		X0Y0_蜘蛛_眼右2_ハイライトCP.Update();
    		X0Y0_羽虫_眼中_基CP.Update();
    		X0Y0_羽虫_眼中_眼CP.Update();
    		X0Y0_羽虫_眼中_ハイライトCP.Update();
    		X0Y0_羽虫_眼左_基CP.Update();
    		X0Y0_羽虫_眼左_眼CP.Update();
    		X0Y0_羽虫_眼左_ハイライトCP.Update();
    		X0Y0_羽虫_眼右_基CP.Update();
    		X0Y0_羽虫_眼右_眼CP.Update();
    		X0Y0_羽虫_眼右_ハイライトCP.Update();
    		X0Y0_紋柄_紋CP.Update();
    		X0Y0_紋柄_紋左1CP.Update();
    		X0Y0_紋柄_紋右1CP.Update();
    		X0Y0_紋柄_紋左2CP.Update();
    		X0Y0_紋柄_紋右2CP.Update();
    		X0Y0_竜性_鱗1CP.Update();
    		X0Y0_竜性_鱗2CP.Update();
    		X0Y0_竜性_鱗3CP.Update();
    		X0Y0_馬柄_馬柄CP.Update();
    		X0Y0_虫性_顎下CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		HeadCD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_逆十字_逆十字2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		隈取_タトゥCD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		隈取_タトゥ左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		隈取_タトゥ右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		秘石_基CD = new ColorD(ref ColorHelper.Black, ref 体配色.秘石O);
    		秘石_秘石CD = new ColorD(ref ColorHelper.Black, ref 体配色.秘石O);
    		秘石_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト);
    		蜘蛛_眼左1_基CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼2O);
    		蜘蛛_眼左1_眼CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼2O);
    		蜘蛛_眼左1_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト);
    		蜘蛛_眼左2_基CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼2O);
    		蜘蛛_眼左2_眼CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼2O);
    		蜘蛛_眼左2_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト);
    		蜘蛛_眼右1_基CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼2O);
    		蜘蛛_眼右1_眼CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼2O);
    		蜘蛛_眼右1_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト);
    		蜘蛛_眼右2_基CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼2O);
    		蜘蛛_眼右2_眼CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼2O);
    		蜘蛛_眼右2_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト);
    		羽虫_眼中_基CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼1O);
    		羽虫_眼中_眼CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼1O);
    		羽虫_眼中_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト);
    		羽虫_眼左_基CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼1O);
    		羽虫_眼左_眼CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼1O);
    		羽虫_眼左_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト);
    		羽虫_眼右_基CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼1O);
    		羽虫_眼右_眼CD = new ColorD(ref ColorHelper.Black, ref 体配色.眼1O);
    		羽虫_眼右_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト);
    		紋柄_紋CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋左1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋左2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		竜性_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		竜性_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗1O);
    		馬柄_馬柄CD = new ColorD(ref ColorHelper.Empty, ref 体配色.毛0O);
    		虫性_顎下CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    	}
    }
}
