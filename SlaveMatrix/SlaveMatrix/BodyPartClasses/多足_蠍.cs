using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 多足_蠍 : 半身
    {
    	public ShapePart X0Y0_前腹_腹節7_節0;

    	public ShapePart X0Y0_前腹_腹節7_節1;

    	public ShapePart X0Y0_前腹_腹節6_節0;

    	public ShapePart X0Y0_前腹_腹節6_節1;

    	public ShapePart X0Y0_前腹_腹節6_節線;

    	public ShapePart X0Y0_前腹_腹節6_気門左;

    	public ShapePart X0Y0_前腹_腹節6_気門右;

    	public ShapePart X0Y0_前腹_腹節5_節0;

    	public ShapePart X0Y0_前腹_腹節5_節1;

    	public ShapePart X0Y0_前腹_腹節5_節線;

    	public ShapePart X0Y0_前腹_腹節5_気門左;

    	public ShapePart X0Y0_前腹_腹節5_気門右;

    	public ShapePart X0Y0_前腹_腹節4_節0;

    	public ShapePart X0Y0_前腹_腹節4_節1;

    	public ShapePart X0Y0_前腹_腹節4_節線;

    	public ShapePart X0Y0_前腹_腹節4_気門左;

    	public ShapePart X0Y0_前腹_腹節4_気門右;

    	public ShapePart X0Y0_前腹_腹節3_節0;

    	public ShapePart X0Y0_前腹_腹節3_節1;

    	public ShapePart X0Y0_前腹_腹節3_節線;

    	public ShapePart X0Y0_前腹_腹節3_気門左;

    	public ShapePart X0Y0_前腹_腹節3_気門右;

    	public ShapePart X0Y0_前腹_腹節2_節0;

    	public ShapePart X0Y0_頭胸;

    	public ShapePart X0Y0_基節_基節左0;

    	public ShapePart X0Y0_基節_基節左1;

    	public ShapePart X0Y0_基節_肢内突起左;

    	public ShapePart X0Y0_基節_基節左2;

    	public ShapePart X0Y0_基節_基節左3;

    	public ShapePart X0Y0_基節_基節左4;

    	public ShapePart X0Y0_基節_基節右0;

    	public ShapePart X0Y0_基節_基節右1;

    	public ShapePart X0Y0_基節_肢内突起右;

    	public ShapePart X0Y0_基節_基節右2;

    	public ShapePart X0Y0_基節_基節右3;

    	public ShapePart X0Y0_基節_基節右4;

    	public ShapePart X0Y0_生殖口蓋左;

    	public ShapePart X0Y0_生殖口蓋右;

    	public ShapePart X0Y0_生殖口_生殖口0;

    	public ShapePart X0Y0_生殖口_生殖口1;

    	public ColorD 前腹_腹節7_節0CD;

    	public ColorD 前腹_腹節7_節1CD;

    	public ColorD 前腹_腹節6_節0CD;

    	public ColorD 前腹_腹節6_節1CD;

    	public ColorD 前腹_腹節6_節線CD;

    	public ColorD 前腹_腹節6_気門左CD;

    	public ColorD 前腹_腹節6_気門右CD;

    	public ColorD 前腹_腹節5_節0CD;

    	public ColorD 前腹_腹節5_節1CD;

    	public ColorD 前腹_腹節5_節線CD;

    	public ColorD 前腹_腹節5_気門左CD;

    	public ColorD 前腹_腹節5_気門右CD;

    	public ColorD 前腹_腹節4_節0CD;

    	public ColorD 前腹_腹節4_節1CD;

    	public ColorD 前腹_腹節4_節線CD;

    	public ColorD 前腹_腹節4_気門左CD;

    	public ColorD 前腹_腹節4_気門右CD;

    	public ColorD 前腹_腹節3_節0CD;

    	public ColorD 前腹_腹節3_節1CD;

    	public ColorD 前腹_腹節3_節線CD;

    	public ColorD 前腹_腹節3_気門左CD;

    	public ColorD 前腹_腹節3_気門右CD;

    	public ColorD 前腹_腹節2_節0CD;

    	public ColorD 頭胸CD;

    	public ColorD 基節_基節左0CD;

    	public ColorD 基節_基節左1CD;

    	public ColorD 基節_肢内突起左CD;

    	public ColorD 基節_基節左2CD;

    	public ColorD 基節_基節左3CD;

    	public ColorD 基節_基節左4CD;

    	public ColorD 基節_基節右0CD;

    	public ColorD 基節_基節右1CD;

    	public ColorD 基節_肢内突起右CD;

    	public ColorD 基節_基節右2CD;

    	public ColorD 基節_基節右3CD;

    	public ColorD 基節_基節右4CD;

    	public ColorD 生殖口蓋左CD;

    	public ColorD 生殖口蓋右CD;

    	public ColorD 生殖口_生殖口0CD;

    	public ColorD 生殖口_生殖口1CD;

    	public ColorP X0Y0_前腹_腹節7_節0CP;

    	public ColorP X0Y0_前腹_腹節7_節1CP;

    	public ColorP X0Y0_前腹_腹節6_節0CP;

    	public ColorP X0Y0_前腹_腹節6_節1CP;

    	public ColorP X0Y0_前腹_腹節6_節線CP;

    	public ColorP X0Y0_前腹_腹節6_気門左CP;

    	public ColorP X0Y0_前腹_腹節6_気門右CP;

    	public ColorP X0Y0_前腹_腹節5_節0CP;

    	public ColorP X0Y0_前腹_腹節5_節1CP;

    	public ColorP X0Y0_前腹_腹節5_節線CP;

    	public ColorP X0Y0_前腹_腹節5_気門左CP;

    	public ColorP X0Y0_前腹_腹節5_気門右CP;

    	public ColorP X0Y0_前腹_腹節4_節0CP;

    	public ColorP X0Y0_前腹_腹節4_節1CP;

    	public ColorP X0Y0_前腹_腹節4_節線CP;

    	public ColorP X0Y0_前腹_腹節4_気門左CP;

    	public ColorP X0Y0_前腹_腹節4_気門右CP;

    	public ColorP X0Y0_前腹_腹節3_節0CP;

    	public ColorP X0Y0_前腹_腹節3_節1CP;

    	public ColorP X0Y0_前腹_腹節3_節線CP;

    	public ColorP X0Y0_前腹_腹節3_気門左CP;

    	public ColorP X0Y0_前腹_腹節3_気門右CP;

    	public ColorP X0Y0_前腹_腹節2_節0CP;

    	public ColorP X0Y0_頭胸CP;

    	public ColorP X0Y0_基節_基節左0CP;

    	public ColorP X0Y0_基節_基節左1CP;

    	public ColorP X0Y0_基節_肢内突起左CP;

    	public ColorP X0Y0_基節_基節左2CP;

    	public ColorP X0Y0_基節_基節左3CP;

    	public ColorP X0Y0_基節_基節左4CP;

    	public ColorP X0Y0_基節_基節右0CP;

    	public ColorP X0Y0_基節_基節右1CP;

    	public ColorP X0Y0_基節_肢内突起右CP;

    	public ColorP X0Y0_基節_基節右2CP;

    	public ColorP X0Y0_基節_基節右3CP;

    	public ColorP X0Y0_基節_基節右4CP;

    	public ColorP X0Y0_生殖口蓋左CP;

    	public ColorP X0Y0_生殖口蓋右CP;

    	public ColorP X0Y0_生殖口_生殖口0CP;

    	public ColorP X0Y0_生殖口_生殖口1CP;

    	private double くぱぁ_;

    	public Element[] 触肢左_接続;

    	public Element[] 節足左1_接続;

    	public Element[] 節足左2_接続;

    	public Element[] 節足左3_接続;

    	public Element[] 節足左4_接続;

    	public Element[] 触肢右_接続;

    	public Element[] 節足右1_接続;

    	public Element[] 節足右2_接続;

    	public Element[] 節足右3_接続;

    	public Element[] 節足右4_接続;

    	public Element[] 櫛状板左_接続;

    	public Element[] 櫛状板右_接続;

    	public Element[] 尾_接続;

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

    	public bool 前腹_腹節7_節0_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節7_節0.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節7_節0.Dra = value;
    			X0Y0_前腹_腹節7_節0.Hit = value;
    		}
    	}

    	public bool 前腹_腹節7_節1_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節7_節1.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節7_節1.Dra = value;
    			X0Y0_前腹_腹節7_節1.Hit = value;
    		}
    	}

    	public bool 前腹_腹節6_節0_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節6_節0.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節6_節0.Dra = value;
    			X0Y0_前腹_腹節6_節0.Hit = value;
    		}
    	}

    	public bool 前腹_腹節6_節1_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節6_節1.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節6_節1.Dra = value;
    			X0Y0_前腹_腹節6_節1.Hit = value;
    		}
    	}

    	public bool 前腹_腹節6_節線_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節6_節線.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節6_節線.Dra = value;
    			X0Y0_前腹_腹節6_節線.Hit = value;
    		}
    	}

    	public bool 前腹_腹節6_気門左_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節6_気門左.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節6_気門左.Dra = value;
    			X0Y0_前腹_腹節6_気門左.Hit = value;
    		}
    	}

    	public bool 前腹_腹節6_気門右_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節6_気門右.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節6_気門右.Dra = value;
    			X0Y0_前腹_腹節6_気門右.Hit = value;
    		}
    	}

    	public bool 前腹_腹節5_節0_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節5_節0.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節5_節0.Dra = value;
    			X0Y0_前腹_腹節5_節0.Hit = value;
    		}
    	}

    	public bool 前腹_腹節5_節1_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節5_節1.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節5_節1.Dra = value;
    			X0Y0_前腹_腹節5_節1.Hit = value;
    		}
    	}

    	public bool 前腹_腹節5_節線_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節5_節線.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節5_節線.Dra = value;
    			X0Y0_前腹_腹節5_節線.Hit = value;
    		}
    	}

    	public bool 前腹_腹節5_気門左_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節5_気門左.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節5_気門左.Dra = value;
    			X0Y0_前腹_腹節5_気門左.Hit = value;
    		}
    	}

    	public bool 前腹_腹節5_気門右_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節5_気門右.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節5_気門右.Dra = value;
    			X0Y0_前腹_腹節5_気門右.Hit = value;
    		}
    	}

    	public bool 前腹_腹節4_節0_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節4_節0.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節4_節0.Dra = value;
    			X0Y0_前腹_腹節4_節0.Hit = value;
    		}
    	}

    	public bool 前腹_腹節4_節1_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節4_節1.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節4_節1.Dra = value;
    			X0Y0_前腹_腹節4_節1.Hit = value;
    		}
    	}

    	public bool 前腹_腹節4_節線_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節4_節線.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節4_節線.Dra = value;
    			X0Y0_前腹_腹節4_節線.Hit = value;
    		}
    	}

    	public bool 前腹_腹節4_気門左_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節4_気門左.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節4_気門左.Dra = value;
    			X0Y0_前腹_腹節4_気門左.Hit = value;
    		}
    	}

    	public bool 前腹_腹節4_気門右_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節4_気門右.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節4_気門右.Dra = value;
    			X0Y0_前腹_腹節4_気門右.Hit = value;
    		}
    	}

    	public bool 前腹_腹節3_節0_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節3_節0.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節3_節0.Dra = value;
    			X0Y0_前腹_腹節3_節0.Hit = value;
    		}
    	}

    	public bool 前腹_腹節3_節1_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節3_節1.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節3_節1.Dra = value;
    			X0Y0_前腹_腹節3_節1.Hit = value;
    		}
    	}

    	public bool 前腹_腹節3_節線_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節3_節線.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節3_節線.Dra = value;
    			X0Y0_前腹_腹節3_節線.Hit = value;
    		}
    	}

    	public bool 前腹_腹節3_気門左_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節3_気門左.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節3_気門左.Dra = value;
    			X0Y0_前腹_腹節3_気門左.Hit = value;
    		}
    	}

    	public bool 前腹_腹節3_気門右_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節3_気門右.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節3_気門右.Dra = value;
    			X0Y0_前腹_腹節3_気門右.Hit = value;
    		}
    	}

    	public bool 前腹_腹節2_節0_表示
    	{
    		get
    		{
    			return X0Y0_前腹_腹節2_節0.Dra;
    		}
    		set
    		{
    			X0Y0_前腹_腹節2_節0.Dra = value;
    			X0Y0_前腹_腹節2_節0.Hit = value;
    		}
    	}

    	public bool 頭胸_表示
    	{
    		get
    		{
    			return X0Y0_頭胸.Dra;
    		}
    		set
    		{
    			X0Y0_頭胸.Dra = value;
    			X0Y0_頭胸.Hit = value;
    		}
    	}

    	public bool 基節_基節左0_表示
    	{
    		get
    		{
    			return X0Y0_基節_基節左0.Dra;
    		}
    		set
    		{
    			X0Y0_基節_基節左0.Dra = value;
    			X0Y0_基節_基節左0.Hit = value;
    		}
    	}

    	public bool 基節_基節左1_表示
    	{
    		get
    		{
    			return X0Y0_基節_基節左1.Dra;
    		}
    		set
    		{
    			X0Y0_基節_基節左1.Dra = value;
    			X0Y0_基節_基節左1.Hit = value;
    		}
    	}

    	public bool 基節_肢内突起左_表示
    	{
    		get
    		{
    			return X0Y0_基節_肢内突起左.Dra;
    		}
    		set
    		{
    			X0Y0_基節_肢内突起左.Dra = value;
    			X0Y0_基節_肢内突起左.Hit = value;
    		}
    	}

    	public bool 基節_基節左2_表示
    	{
    		get
    		{
    			return X0Y0_基節_基節左2.Dra;
    		}
    		set
    		{
    			X0Y0_基節_基節左2.Dra = value;
    			X0Y0_基節_基節左2.Hit = value;
    		}
    	}

    	public bool 基節_基節左3_表示
    	{
    		get
    		{
    			return X0Y0_基節_基節左3.Dra;
    		}
    		set
    		{
    			X0Y0_基節_基節左3.Dra = value;
    			X0Y0_基節_基節左3.Hit = value;
    		}
    	}

    	public bool 基節_基節左4_表示
    	{
    		get
    		{
    			return X0Y0_基節_基節左4.Dra;
    		}
    		set
    		{
    			X0Y0_基節_基節左4.Dra = value;
    			X0Y0_基節_基節左4.Hit = value;
    		}
    	}

    	public bool 基節_基節右0_表示
    	{
    		get
    		{
    			return X0Y0_基節_基節右0.Dra;
    		}
    		set
    		{
    			X0Y0_基節_基節右0.Dra = value;
    			X0Y0_基節_基節右0.Hit = value;
    		}
    	}

    	public bool 基節_基節右1_表示
    	{
    		get
    		{
    			return X0Y0_基節_基節右1.Dra;
    		}
    		set
    		{
    			X0Y0_基節_基節右1.Dra = value;
    			X0Y0_基節_基節右1.Hit = value;
    		}
    	}

    	public bool 基節_肢内突起右_表示
    	{
    		get
    		{
    			return X0Y0_基節_肢内突起右.Dra;
    		}
    		set
    		{
    			X0Y0_基節_肢内突起右.Dra = value;
    			X0Y0_基節_肢内突起右.Hit = value;
    		}
    	}

    	public bool 基節_基節右2_表示
    	{
    		get
    		{
    			return X0Y0_基節_基節右2.Dra;
    		}
    		set
    		{
    			X0Y0_基節_基節右2.Dra = value;
    			X0Y0_基節_基節右2.Hit = value;
    		}
    	}

    	public bool 基節_基節右3_表示
    	{
    		get
    		{
    			return X0Y0_基節_基節右3.Dra;
    		}
    		set
    		{
    			X0Y0_基節_基節右3.Dra = value;
    			X0Y0_基節_基節右3.Hit = value;
    		}
    	}

    	public bool 基節_基節右4_表示
    	{
    		get
    		{
    			return X0Y0_基節_基節右4.Dra;
    		}
    		set
    		{
    			X0Y0_基節_基節右4.Dra = value;
    			X0Y0_基節_基節右4.Hit = value;
    		}
    	}

    	public bool 生殖口蓋左_表示
    	{
    		get
    		{
    			return X0Y0_生殖口蓋左.Dra;
    		}
    		set
    		{
    			X0Y0_生殖口蓋左.Dra = value;
    			X0Y0_生殖口蓋左.Hit = value;
    		}
    	}

    	public bool 生殖口蓋右_表示
    	{
    		get
    		{
    			return X0Y0_生殖口蓋右.Dra;
    		}
    		set
    		{
    			X0Y0_生殖口蓋右.Dra = value;
    			X0Y0_生殖口蓋右.Hit = value;
    		}
    	}

    	public bool 生殖口_生殖口0_表示
    	{
    		get
    		{
    			return X0Y0_生殖口_生殖口0.Dra;
    		}
    		set
    		{
    			X0Y0_生殖口_生殖口0.Dra = value;
    			X0Y0_生殖口_生殖口0.Hit = value;
    		}
    	}

    	public bool 生殖口_生殖口1_表示
    	{
    		get
    		{
    			return X0Y0_生殖口_生殖口1.Dra;
    		}
    		set
    		{
    			X0Y0_生殖口_生殖口1.Dra = value;
    			X0Y0_生殖口_生殖口1.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 前腹_腹節7_節0_表示;
    		}
    		set
    		{
    			前腹_腹節7_節0_表示 = value;
    			前腹_腹節7_節1_表示 = value;
    			前腹_腹節6_節0_表示 = value;
    			前腹_腹節6_節1_表示 = value;
    			前腹_腹節6_節線_表示 = value;
    			前腹_腹節6_気門左_表示 = value;
    			前腹_腹節6_気門右_表示 = value;
    			前腹_腹節5_節0_表示 = value;
    			前腹_腹節5_節1_表示 = value;
    			前腹_腹節5_節線_表示 = value;
    			前腹_腹節5_気門左_表示 = value;
    			前腹_腹節5_気門右_表示 = value;
    			前腹_腹節4_節0_表示 = value;
    			前腹_腹節4_節1_表示 = value;
    			前腹_腹節4_節線_表示 = value;
    			前腹_腹節4_気門左_表示 = value;
    			前腹_腹節4_気門右_表示 = value;
    			前腹_腹節3_節0_表示 = value;
    			前腹_腹節3_節1_表示 = value;
    			前腹_腹節3_節線_表示 = value;
    			前腹_腹節3_気門左_表示 = value;
    			前腹_腹節3_気門右_表示 = value;
    			前腹_腹節2_節0_表示 = value;
    			頭胸_表示 = value;
    			基節_基節左0_表示 = value;
    			基節_基節左1_表示 = value;
    			基節_肢内突起左_表示 = value;
    			基節_基節左2_表示 = value;
    			基節_基節左3_表示 = value;
    			基節_基節左4_表示 = value;
    			基節_基節右0_表示 = value;
    			基節_基節右1_表示 = value;
    			基節_肢内突起右_表示 = value;
    			基節_基節右2_表示 = value;
    			基節_基節右3_表示 = value;
    			基節_基節右4_表示 = value;
    			生殖口蓋左_表示 = value;
    			生殖口蓋右_表示 = value;
    			生殖口_生殖口0_表示 = value;
    			生殖口_生殖口1_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 前腹_腹節7_節0CD.不透明度;
    		}
    		set
    		{
    			前腹_腹節7_節0CD.不透明度 = value;
    			前腹_腹節7_節1CD.不透明度 = value;
    			前腹_腹節6_節0CD.不透明度 = value;
    			前腹_腹節6_節1CD.不透明度 = value;
    			前腹_腹節6_節線CD.不透明度 = value;
    			前腹_腹節6_気門左CD.不透明度 = value;
    			前腹_腹節6_気門右CD.不透明度 = value;
    			前腹_腹節5_節0CD.不透明度 = value;
    			前腹_腹節5_節1CD.不透明度 = value;
    			前腹_腹節5_節線CD.不透明度 = value;
    			前腹_腹節5_気門左CD.不透明度 = value;
    			前腹_腹節5_気門右CD.不透明度 = value;
    			前腹_腹節4_節0CD.不透明度 = value;
    			前腹_腹節4_節1CD.不透明度 = value;
    			前腹_腹節4_節線CD.不透明度 = value;
    			前腹_腹節4_気門左CD.不透明度 = value;
    			前腹_腹節4_気門右CD.不透明度 = value;
    			前腹_腹節3_節0CD.不透明度 = value;
    			前腹_腹節3_節1CD.不透明度 = value;
    			前腹_腹節3_節線CD.不透明度 = value;
    			前腹_腹節3_気門左CD.不透明度 = value;
    			前腹_腹節3_気門右CD.不透明度 = value;
    			前腹_腹節2_節0CD.不透明度 = value;
    			頭胸CD.不透明度 = value;
    			基節_基節左0CD.不透明度 = value;
    			基節_基節左1CD.不透明度 = value;
    			基節_肢内突起左CD.不透明度 = value;
    			基節_基節左2CD.不透明度 = value;
    			基節_基節左3CD.不透明度 = value;
    			基節_基節左4CD.不透明度 = value;
    			基節_基節右0CD.不透明度 = value;
    			基節_基節右1CD.不透明度 = value;
    			基節_肢内突起右CD.不透明度 = value;
    			基節_基節右2CD.不透明度 = value;
    			基節_基節右3CD.不透明度 = value;
    			基節_基節右4CD.不透明度 = value;
    			生殖口蓋左CD.不透明度 = value;
    			生殖口蓋右CD.不透明度 = value;
    			生殖口_生殖口0CD.不透明度 = value;
    			生殖口_生殖口1CD.不透明度 = value;
    		}
    	}

    	public double くぱぁ
    	{
    		get
    		{
    			return くぱぁ_;
    		}
    		set
    		{
    			くぱぁ_ = value;
    			X0Y0_生殖口蓋左.AngleBase = 18.0 * くぱぁ_;
    			X0Y0_生殖口蓋右.AngleBase = -18.0 * くぱぁ_;
    		}
    	}

    	public JointS 触肢左_接続点 => new JointS(Body, X0Y0_基節_基節左0, 0);

    	public JointS 節足左1_接続点 => new JointS(Body, X0Y0_基節_基節左1, 0);

    	public JointS 節足左2_接続点 => new JointS(Body, X0Y0_基節_基節左2, 0);

    	public JointS 節足左3_接続点 => new JointS(Body, X0Y0_基節_基節左3, 0);

    	public JointS 節足左4_接続点 => new JointS(Body, X0Y0_基節_基節左4, 0);

    	public JointS 触肢右_接続点 => new JointS(Body, X0Y0_基節_基節右0, 0);

    	public JointS 節足右1_接続点 => new JointS(Body, X0Y0_基節_基節右1, 0);

    	public JointS 節足右2_接続点 => new JointS(Body, X0Y0_基節_基節右2, 0);

    	public JointS 節足右3_接続点 => new JointS(Body, X0Y0_基節_基節右3, 0);

    	public JointS 節足右4_接続点 => new JointS(Body, X0Y0_基節_基節右4, 0);

    	public JointS 櫛状板左_接続点 => new JointS(Body, X0Y0_生殖口_生殖口1, 0);

    	public JointS 櫛状板右_接続点 => new JointS(Body, X0Y0_生殖口_生殖口1, 1);

    	public JointS 尾_接続点 => new JointS(Body, X0Y0_前腹_腹節7_節0, 2);

    	public 多足_蠍(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 多足_蠍D e)
    	{
    		多足_蠍 多足_蠍2 = this;
    		ThisType = GetType();
    		MorphVariant morphVariant = new MorphVariant();
    		morphVariant.Tag = "蠍";
    		morphVariant.Add(new PartGroup(Sta.半身["多足"][0][2]));
    		Body = new VariantGrid();
    		Body.Tag = morphVariant.Tag;
    		Body.Add(morphVariant);
    		PartGroup partGroup = Body[0][0];
    		PartGroup pars2 = partGroup["前腹"].ToPars();
    		PartGroup pars3 = pars2["腹節7"].ToPars();
    		X0Y0_前腹_腹節7_節0 = pars3["節0"].ToPar();
    		X0Y0_前腹_腹節7_節1 = pars3["節1"].ToPar();
    		pars3 = pars2["腹節6"].ToPars();
    		X0Y0_前腹_腹節6_節0 = pars3["節0"].ToPar();
    		X0Y0_前腹_腹節6_節1 = pars3["節1"].ToPar();
    		X0Y0_前腹_腹節6_節線 = pars3["節線"].ToPar();
    		X0Y0_前腹_腹節6_気門左 = pars3["気門左"].ToPar();
    		X0Y0_前腹_腹節6_気門右 = pars3["気門右"].ToPar();
    		pars3 = pars2["腹節5"].ToPars();
    		X0Y0_前腹_腹節5_節0 = pars3["節0"].ToPar();
    		X0Y0_前腹_腹節5_節1 = pars3["節1"].ToPar();
    		X0Y0_前腹_腹節5_節線 = pars3["節線"].ToPar();
    		X0Y0_前腹_腹節5_気門左 = pars3["気門左"].ToPar();
    		X0Y0_前腹_腹節5_気門右 = pars3["気門右"].ToPar();
    		pars3 = pars2["腹節4"].ToPars();
    		X0Y0_前腹_腹節4_節0 = pars3["節0"].ToPar();
    		X0Y0_前腹_腹節4_節1 = pars3["節1"].ToPar();
    		X0Y0_前腹_腹節4_節線 = pars3["節線"].ToPar();
    		X0Y0_前腹_腹節4_気門左 = pars3["気門左"].ToPar();
    		X0Y0_前腹_腹節4_気門右 = pars3["気門右"].ToPar();
    		pars3 = pars2["腹節3"].ToPars();
    		X0Y0_前腹_腹節3_節0 = pars3["節0"].ToPar();
    		X0Y0_前腹_腹節3_節1 = pars3["節1"].ToPar();
    		X0Y0_前腹_腹節3_節線 = pars3["節線"].ToPar();
    		X0Y0_前腹_腹節3_気門左 = pars3["気門左"].ToPar();
    		X0Y0_前腹_腹節3_気門右 = pars3["気門右"].ToPar();
    		pars3 = pars2["腹節2"].ToPars();
    		X0Y0_前腹_腹節2_節0 = pars3["節0"].ToPar();
    		X0Y0_頭胸 = partGroup["頭胸"].ToPar();
    		pars2 = partGroup["基節"].ToPars();
    		X0Y0_基節_基節左0 = pars2["基節左0"].ToPar();
    		X0Y0_基節_基節左1 = pars2["基節左1"].ToPar();
    		X0Y0_基節_肢内突起左 = pars2["肢内突起左"].ToPar();
    		X0Y0_基節_基節左2 = pars2["基節左2"].ToPar();
    		X0Y0_基節_基節左3 = pars2["基節左3"].ToPar();
    		X0Y0_基節_基節左4 = pars2["基節左4"].ToPar();
    		X0Y0_基節_基節右0 = pars2["基節右0"].ToPar();
    		X0Y0_基節_基節右1 = pars2["基節右1"].ToPar();
    		X0Y0_基節_肢内突起右 = pars2["肢内突起右"].ToPar();
    		X0Y0_基節_基節右2 = pars2["基節右2"].ToPar();
    		X0Y0_基節_基節右3 = pars2["基節右3"].ToPar();
    		X0Y0_基節_基節右4 = pars2["基節右4"].ToPar();
    		X0Y0_生殖口蓋左 = partGroup["生殖口蓋左"].ToPar();
    		X0Y0_生殖口蓋右 = partGroup["生殖口蓋右"].ToPar();
    		pars2 = partGroup["生殖口"].ToPars();
    		X0Y0_生殖口_生殖口0 = pars2["生殖口0"].ToPar();
    		X0Y0_生殖口_生殖口1 = pars2["生殖口1"].ToPar();
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
    		前腹_腹節7_節0_表示 = e.前腹_腹節7_節0_表示;
    		前腹_腹節7_節1_表示 = e.前腹_腹節7_節1_表示;
    		前腹_腹節6_節0_表示 = e.前腹_腹節6_節0_表示;
    		前腹_腹節6_節1_表示 = e.前腹_腹節6_節1_表示;
    		前腹_腹節6_節線_表示 = e.前腹_腹節6_節線_表示;
    		前腹_腹節6_気門左_表示 = e.前腹_腹節6_気門左_表示;
    		前腹_腹節6_気門右_表示 = e.前腹_腹節6_気門右_表示;
    		前腹_腹節5_節0_表示 = e.前腹_腹節5_節0_表示;
    		前腹_腹節5_節1_表示 = e.前腹_腹節5_節1_表示;
    		前腹_腹節5_節線_表示 = e.前腹_腹節5_節線_表示;
    		前腹_腹節5_気門左_表示 = e.前腹_腹節5_気門左_表示;
    		前腹_腹節5_気門右_表示 = e.前腹_腹節5_気門右_表示;
    		前腹_腹節4_節0_表示 = e.前腹_腹節4_節0_表示;
    		前腹_腹節4_節1_表示 = e.前腹_腹節4_節1_表示;
    		前腹_腹節4_節線_表示 = e.前腹_腹節4_節線_表示;
    		前腹_腹節4_気門左_表示 = e.前腹_腹節4_気門左_表示;
    		前腹_腹節4_気門右_表示 = e.前腹_腹節4_気門右_表示;
    		前腹_腹節3_節0_表示 = e.前腹_腹節3_節0_表示;
    		前腹_腹節3_節1_表示 = e.前腹_腹節3_節1_表示;
    		前腹_腹節3_節線_表示 = e.前腹_腹節3_節線_表示;
    		前腹_腹節3_気門左_表示 = e.前腹_腹節3_気門左_表示;
    		前腹_腹節3_気門右_表示 = e.前腹_腹節3_気門右_表示;
    		前腹_腹節2_節0_表示 = e.前腹_腹節2_節0_表示;
    		頭胸_表示 = e.頭胸_表示;
    		基節_基節左0_表示 = e.基節_基節左0_表示;
    		基節_基節左1_表示 = e.基節_基節左1_表示;
    		基節_肢内突起左_表示 = e.基節_肢内突起左_表示;
    		基節_基節左2_表示 = e.基節_基節左2_表示;
    		基節_基節左3_表示 = e.基節_基節左3_表示;
    		基節_基節左4_表示 = e.基節_基節左4_表示;
    		基節_基節右0_表示 = e.基節_基節右0_表示;
    		基節_基節右1_表示 = e.基節_基節右1_表示;
    		基節_肢内突起右_表示 = e.基節_肢内突起右_表示;
    		基節_基節右2_表示 = e.基節_基節右2_表示;
    		基節_基節右3_表示 = e.基節_基節右3_表示;
    		基節_基節右4_表示 = e.基節_基節右4_表示;
    		生殖口蓋左_表示 = e.生殖口蓋左_表示;
    		生殖口蓋右_表示 = e.生殖口蓋右_表示;
    		生殖口_生殖口0_表示 = e.生殖口_生殖口0_表示;
    		生殖口_生殖口1_表示 = e.生殖口_生殖口1_表示;
    		くぱぁ = e.くぱぁ;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Element f;
    		if (e.触肢左_接続.Count > 0)
    		{
    			触肢左_接続 = e.触肢左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蠍2;
    				f.ConnectionType = ConnectionInfo.多足_蠍_触肢左_接続;
    				f.接続(多足_蠍2.触肢左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足左1_接続.Count > 0)
    		{
    			節足左1_接続 = e.節足左1_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蠍2;
    				f.ConnectionType = ConnectionInfo.多足_蠍_節足左1_接続;
    				f.接続(多足_蠍2.節足左1_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足左2_接続.Count > 0)
    		{
    			節足左2_接続 = e.節足左2_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蠍2;
    				f.ConnectionType = ConnectionInfo.多足_蠍_節足左2_接続;
    				f.接続(多足_蠍2.節足左2_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足左3_接続.Count > 0)
    		{
    			節足左3_接続 = e.節足左3_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蠍2;
    				f.ConnectionType = ConnectionInfo.多足_蠍_節足左3_接続;
    				f.接続(多足_蠍2.節足左3_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足左4_接続.Count > 0)
    		{
    			節足左4_接続 = e.節足左4_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蠍2;
    				f.ConnectionType = ConnectionInfo.多足_蠍_節足左4_接続;
    				f.接続(多足_蠍2.節足左4_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.触肢右_接続.Count > 0)
    		{
    			触肢右_接続 = e.触肢右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蠍2;
    				f.ConnectionType = ConnectionInfo.多足_蠍_触肢右_接続;
    				f.接続(多足_蠍2.触肢右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足右1_接続.Count > 0)
    		{
    			節足右1_接続 = e.節足右1_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蠍2;
    				f.ConnectionType = ConnectionInfo.多足_蠍_節足右1_接続;
    				f.接続(多足_蠍2.節足右1_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足右2_接続.Count > 0)
    		{
    			節足右2_接続 = e.節足右2_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蠍2;
    				f.ConnectionType = ConnectionInfo.多足_蠍_節足右2_接続;
    				f.接続(多足_蠍2.節足右2_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足右3_接続.Count > 0)
    		{
    			節足右3_接続 = e.節足右3_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蠍2;
    				f.ConnectionType = ConnectionInfo.多足_蠍_節足右3_接続;
    				f.接続(多足_蠍2.節足右3_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足右4_接続.Count > 0)
    		{
    			節足右4_接続 = e.節足右4_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蠍2;
    				f.ConnectionType = ConnectionInfo.多足_蠍_節足右4_接続;
    				f.接続(多足_蠍2.節足右4_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.櫛状板左_接続.Count > 0)
    		{
    			櫛状板左_接続 = e.櫛状板左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蠍2;
    				f.ConnectionType = ConnectionInfo.多足_蠍_櫛状板左_接続;
    				f.接続(多足_蠍2.櫛状板左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.櫛状板右_接続.Count > 0)
    		{
    			櫛状板右_接続 = e.櫛状板右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蠍2;
    				f.ConnectionType = ConnectionInfo.多足_蠍_櫛状板右_接続;
    				f.接続(多足_蠍2.櫛状板右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.尾_接続.Count > 0)
    		{
    			尾_接続 = e.尾_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蠍2;
    				f.ConnectionType = ConnectionInfo.多足_蠍_尾_接続;
    				f.接続(多足_蠍2.尾_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_前腹_腹節7_節0CP = new ColorP(X0Y0_前腹_腹節7_節0, 前腹_腹節7_節0CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節7_節1CP = new ColorP(X0Y0_前腹_腹節7_節1, 前腹_腹節7_節1CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節6_節0CP = new ColorP(X0Y0_前腹_腹節6_節0, 前腹_腹節6_節0CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節6_節1CP = new ColorP(X0Y0_前腹_腹節6_節1, 前腹_腹節6_節1CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節6_節線CP = new ColorP(X0Y0_前腹_腹節6_節線, 前腹_腹節6_節線CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節6_気門左CP = new ColorP(X0Y0_前腹_腹節6_気門左, 前腹_腹節6_気門左CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節6_気門右CP = new ColorP(X0Y0_前腹_腹節6_気門右, 前腹_腹節6_気門右CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節5_節0CP = new ColorP(X0Y0_前腹_腹節5_節0, 前腹_腹節5_節0CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節5_節1CP = new ColorP(X0Y0_前腹_腹節5_節1, 前腹_腹節5_節1CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節5_節線CP = new ColorP(X0Y0_前腹_腹節5_節線, 前腹_腹節5_節線CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節5_気門左CP = new ColorP(X0Y0_前腹_腹節5_気門左, 前腹_腹節5_気門左CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節5_気門右CP = new ColorP(X0Y0_前腹_腹節5_気門右, 前腹_腹節5_気門右CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節4_節0CP = new ColorP(X0Y0_前腹_腹節4_節0, 前腹_腹節4_節0CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節4_節1CP = new ColorP(X0Y0_前腹_腹節4_節1, 前腹_腹節4_節1CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節4_節線CP = new ColorP(X0Y0_前腹_腹節4_節線, 前腹_腹節4_節線CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節4_気門左CP = new ColorP(X0Y0_前腹_腹節4_気門左, 前腹_腹節4_気門左CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節4_気門右CP = new ColorP(X0Y0_前腹_腹節4_気門右, 前腹_腹節4_気門右CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節3_節0CP = new ColorP(X0Y0_前腹_腹節3_節0, 前腹_腹節3_節0CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節3_節1CP = new ColorP(X0Y0_前腹_腹節3_節1, 前腹_腹節3_節1CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節3_節線CP = new ColorP(X0Y0_前腹_腹節3_節線, 前腹_腹節3_節線CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節3_気門左CP = new ColorP(X0Y0_前腹_腹節3_気門左, 前腹_腹節3_気門左CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節3_気門右CP = new ColorP(X0Y0_前腹_腹節3_気門右, 前腹_腹節3_気門右CD, DisUnit, abj: true);
    		X0Y0_前腹_腹節2_節0CP = new ColorP(X0Y0_前腹_腹節2_節0, 前腹_腹節2_節0CD, DisUnit, abj: true);
    		X0Y0_頭胸CP = new ColorP(X0Y0_頭胸, 頭胸CD, DisUnit, abj: true);
    		X0Y0_基節_基節左0CP = new ColorP(X0Y0_基節_基節左0, 基節_基節左0CD, DisUnit, abj: true);
    		X0Y0_基節_基節左1CP = new ColorP(X0Y0_基節_基節左1, 基節_基節左1CD, DisUnit, abj: true);
    		X0Y0_基節_肢内突起左CP = new ColorP(X0Y0_基節_肢内突起左, 基節_肢内突起左CD, DisUnit, abj: true);
    		X0Y0_基節_基節左2CP = new ColorP(X0Y0_基節_基節左2, 基節_基節左2CD, DisUnit, abj: true);
    		X0Y0_基節_基節左3CP = new ColorP(X0Y0_基節_基節左3, 基節_基節左3CD, DisUnit, abj: true);
    		X0Y0_基節_基節左4CP = new ColorP(X0Y0_基節_基節左4, 基節_基節左4CD, DisUnit, abj: true);
    		X0Y0_基節_基節右0CP = new ColorP(X0Y0_基節_基節右0, 基節_基節右0CD, DisUnit, abj: true);
    		X0Y0_基節_基節右1CP = new ColorP(X0Y0_基節_基節右1, 基節_基節右1CD, DisUnit, abj: true);
    		X0Y0_基節_肢内突起右CP = new ColorP(X0Y0_基節_肢内突起右, 基節_肢内突起右CD, DisUnit, abj: true);
    		X0Y0_基節_基節右2CP = new ColorP(X0Y0_基節_基節右2, 基節_基節右2CD, DisUnit, abj: true);
    		X0Y0_基節_基節右3CP = new ColorP(X0Y0_基節_基節右3, 基節_基節右3CD, DisUnit, abj: true);
    		X0Y0_基節_基節右4CP = new ColorP(X0Y0_基節_基節右4, 基節_基節右4CD, DisUnit, abj: true);
    		X0Y0_生殖口蓋左CP = new ColorP(X0Y0_生殖口蓋左, 生殖口蓋左CD, DisUnit, abj: true);
    		X0Y0_生殖口蓋右CP = new ColorP(X0Y0_生殖口蓋右, 生殖口蓋右CD, DisUnit, abj: true);
    		X0Y0_生殖口_生殖口0CP = new ColorP(X0Y0_生殖口_生殖口0, 生殖口_生殖口0CD, DisUnit, abj: true);
    		X0Y0_生殖口_生殖口1CP = new ColorP(X0Y0_生殖口_生殖口1, 生殖口_生殖口1CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_基節_基節左0.AngleBase = num * 39.0;
    		X0Y0_基節_基節左1.AngleBase = num * 22.0;
    		X0Y0_基節_基節左2.AngleBase = num * -11.0;
    		X0Y0_基節_基節左3.AngleBase = num * -36.0;
    		X0Y0_基節_基節左4.AngleBase = num * -45.0;
    		X0Y0_基節_基節右0.AngleBase = num * -39.0;
    		X0Y0_基節_基節右1.AngleBase = num * -22.0;
    		X0Y0_基節_基節右2.AngleBase = num * 11.0;
    		X0Y0_基節_基節右3.AngleBase = num * 36.0;
    		X0Y0_基節_基節右4.AngleBase = num * 45.0;
    		double maxAngle = 10.0;
    		X0Y0_前腹_腹節7_節0.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_前腹_腹節6_節0.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_前腹_腹節5_節0.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_前腹_腹節4_節0.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_前腹_腹節3_節0.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_前腹_腹節2_節0.AngleBase = maxAngle.GetRanAngle();
    		Body.JoinPAall();
    	}

    	public IEnumerable<ShapePart> 軸列挙()
    	{
    		yield return X0Y0_前腹_腹節2_節0;
    		yield return X0Y0_前腹_腹節3_節0;
    		yield return X0Y0_前腹_腹節4_節0;
    		yield return X0Y0_前腹_腹節5_節0;
    		yield return X0Y0_前腹_腹節6_節0;
    		yield return X0Y0_前腹_腹節7_節0;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_前腹_腹節7_節0);
    		Are.Draw(X0Y0_前腹_腹節7_節1);
    		Are.Draw(X0Y0_前腹_腹節6_節0);
    		Are.Draw(X0Y0_前腹_腹節6_節1);
    		Are.Draw(X0Y0_前腹_腹節6_節線);
    		Are.Draw(X0Y0_前腹_腹節6_気門左);
    		Are.Draw(X0Y0_前腹_腹節6_気門右);
    		Are.Draw(X0Y0_前腹_腹節5_節0);
    		Are.Draw(X0Y0_前腹_腹節5_節1);
    		Are.Draw(X0Y0_前腹_腹節5_節線);
    		Are.Draw(X0Y0_前腹_腹節5_気門左);
    		Are.Draw(X0Y0_前腹_腹節5_気門右);
    		Are.Draw(X0Y0_前腹_腹節4_節0);
    		Are.Draw(X0Y0_前腹_腹節4_節1);
    		Are.Draw(X0Y0_前腹_腹節4_節線);
    		Are.Draw(X0Y0_前腹_腹節4_気門左);
    		Are.Draw(X0Y0_前腹_腹節4_気門右);
    		Are.Draw(X0Y0_前腹_腹節3_節0);
    		Are.Draw(X0Y0_前腹_腹節3_節1);
    		Are.Draw(X0Y0_前腹_腹節3_節線);
    		Are.Draw(X0Y0_前腹_腹節3_気門左);
    		Are.Draw(X0Y0_前腹_腹節3_気門右);
    		Are.Draw(X0Y0_前腹_腹節2_節0);
    		Are.Draw(X0Y0_頭胸);
    		Are.Draw(X0Y0_基節_基節左0);
    		Are.Draw(X0Y0_基節_基節左1);
    		Are.Draw(X0Y0_基節_基節左2);
    		Are.Draw(X0Y0_基節_基節左3);
    		Are.Draw(X0Y0_基節_基節左4);
    		Are.Draw(X0Y0_基節_基節右0);
    		Are.Draw(X0Y0_基節_基節右1);
    		Are.Draw(X0Y0_基節_基節右2);
    		Are.Draw(X0Y0_基節_基節右3);
    		Are.Draw(X0Y0_基節_基節右4);
    		Are.Draw(X0Y0_生殖口_生殖口0);
    		Are.Draw(X0Y0_生殖口_生殖口1);
    	}

    	public void 前描画(RenderArea Are)
    	{
    		Are.Draw(X0Y0_基節_肢内突起左);
    		Are.Draw(X0Y0_基節_肢内突起右);
    		Are.Draw(X0Y0_生殖口蓋左);
    		Are.Draw(X0Y0_生殖口蓋右);
    	}

    	public override void 色更新()
    	{
    		X0Y0_前腹_腹節7_節0CP.Update();
    		X0Y0_前腹_腹節7_節1CP.Update();
    		X0Y0_前腹_腹節6_節0CP.Update();
    		X0Y0_前腹_腹節6_節1CP.Update();
    		X0Y0_前腹_腹節6_節線CP.Update();
    		X0Y0_前腹_腹節6_気門左CP.Update();
    		X0Y0_前腹_腹節6_気門右CP.Update();
    		X0Y0_前腹_腹節5_節0CP.Update();
    		X0Y0_前腹_腹節5_節1CP.Update();
    		X0Y0_前腹_腹節5_節線CP.Update();
    		X0Y0_前腹_腹節5_気門左CP.Update();
    		X0Y0_前腹_腹節5_気門右CP.Update();
    		X0Y0_前腹_腹節4_節0CP.Update();
    		X0Y0_前腹_腹節4_節1CP.Update();
    		X0Y0_前腹_腹節4_節線CP.Update();
    		X0Y0_前腹_腹節4_気門左CP.Update();
    		X0Y0_前腹_腹節4_気門右CP.Update();
    		X0Y0_前腹_腹節3_節0CP.Update();
    		X0Y0_前腹_腹節3_節1CP.Update();
    		X0Y0_前腹_腹節3_節線CP.Update();
    		X0Y0_前腹_腹節3_気門左CP.Update();
    		X0Y0_前腹_腹節3_気門右CP.Update();
    		X0Y0_前腹_腹節2_節0CP.Update();
    		X0Y0_頭胸CP.Update();
    		X0Y0_基節_基節左0CP.Update();
    		X0Y0_基節_基節左1CP.Update();
    		X0Y0_基節_肢内突起左CP.Update();
    		X0Y0_基節_基節左2CP.Update();
    		X0Y0_基節_基節左3CP.Update();
    		X0Y0_基節_基節左4CP.Update();
    		X0Y0_基節_基節右0CP.Update();
    		X0Y0_基節_基節右1CP.Update();
    		X0Y0_基節_肢内突起右CP.Update();
    		X0Y0_基節_基節右2CP.Update();
    		X0Y0_基節_基節右3CP.Update();
    		X0Y0_基節_基節右4CP.Update();
    		X0Y0_生殖口蓋左CP.Update();
    		X0Y0_生殖口蓋右CP.Update();
    		X0Y0_生殖口_生殖口0CP.Update();
    		X0Y0_生殖口_生殖口1CP.Update();
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
    		前腹_腹節7_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		前腹_腹節7_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節6_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		前腹_腹節6_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節6_節線CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節6_気門左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節6_気門右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節5_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		前腹_腹節5_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節5_節線CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節5_気門左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節5_気門右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節4_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		前腹_腹節4_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節4_節線CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節4_気門左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節4_気門右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節3_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		前腹_腹節3_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節3_節線CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節3_気門左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節3_気門右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節2_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		頭胸CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_肢内突起左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左3CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左4CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_肢内突起右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右3CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右4CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		生殖口蓋左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		生殖口蓋右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		生殖口_生殖口0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		生殖口_生殖口1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		前腹_腹節7_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節7_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節6_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節6_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節6_節線CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節6_気門左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		前腹_腹節6_気門右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		前腹_腹節5_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節5_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節5_節線CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節5_気門左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		前腹_腹節5_気門右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		前腹_腹節4_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節4_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節4_節線CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節4_気門左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		前腹_腹節4_気門右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		前腹_腹節3_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節3_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節3_節線CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節3_気門左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		前腹_腹節3_気門右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		前腹_腹節2_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		頭胸CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_肢内突起左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左3CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左4CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_肢内突起右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右3CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右4CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		生殖口蓋左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		生殖口蓋右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		生殖口_生殖口0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		生殖口_生殖口1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		前腹_腹節7_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		前腹_腹節7_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節6_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		前腹_腹節6_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節6_節線CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節6_気門左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節6_気門右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節5_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		前腹_腹節5_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節5_節線CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節5_気門左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節5_気門右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節4_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		前腹_腹節4_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節4_節線CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節4_気門左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節4_気門右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節3_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1O);
    		前腹_腹節3_節1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		前腹_腹節3_節線CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		前腹_腹節3_気門左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節3_気門右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		前腹_腹節2_節0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		頭胸CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		基節_基節左0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_肢内突起左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左3CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節左4CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_肢内突起右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右3CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		基節_基節右4CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		生殖口蓋左CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		生殖口蓋右CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		生殖口_生殖口0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		生殖口_生殖口1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    	}

    	public override IEnumerable<Element> EnumEle()
    	{
    		yield return this;
    		if (尾_接続 != null)
    		{
    			foreach (Element item in 尾_接続.Select((Element e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item;
    			}
    		}
    		if (櫛状板左_接続 != null)
    		{
    			foreach (Element item2 in 櫛状板左_接続.Select((Element e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item2;
    			}
    		}
    		if (櫛状板右_接続 != null)
    		{
    			foreach (Element item3 in 櫛状板右_接続.Select((Element e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item3;
    			}
    		}
    		if (節足左4_接続 != null)
    		{
    			foreach (Element item4 in 節足左4_接続.Select((Element e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item4;
    			}
    		}
    		if (節足右4_接続 != null)
    		{
    			foreach (Element item5 in 節足右4_接続.Select((Element e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item5;
    			}
    		}
    		if (節足左3_接続 != null)
    		{
    			foreach (Element item6 in 節足左3_接続.Select((Element e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item6;
    			}
    		}
    		if (節足右3_接続 != null)
    		{
    			foreach (Element item7 in 節足右3_接続.Select((Element e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item7;
    			}
    		}
    		if (節足左2_接続 != null)
    		{
    			foreach (Element item8 in 節足左2_接続.Select((Element e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item8;
    			}
    		}
    		if (節足右2_接続 != null)
    		{
    			foreach (Element item9 in 節足右2_接続.Select((Element e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item9;
    			}
    		}
    		if (節足左1_接続 != null)
    		{
    			foreach (Element item10 in 節足左1_接続.Select((Element e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item10;
    			}
    		}
    		if (節足右1_接続 != null)
    		{
    			foreach (Element item11 in 節足右1_接続.Select((Element e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item11;
    			}
    		}
    		if (触肢左_接続 != null)
    		{
    			foreach (Element item12 in 触肢左_接続.Select((Element e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item12;
    			}
    		}
    		if (触肢右_接続 == null)
    		{
    			yield break;
    		}
    		foreach (Element item13 in 触肢右_接続.Select((Element e) => e.EnumEle()).JoinEnum())
    		{
    			yield return item13;
    		}
    	}
    }
}
