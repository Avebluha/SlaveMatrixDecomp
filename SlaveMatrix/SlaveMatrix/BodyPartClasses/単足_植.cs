using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class 単足_植 : 半身
    {
    	public Par X0Y0_幹上;

    	public Par X0Y0_幹下;

    	public Par X0Y0_葉左;

    	public Par X0Y0_葉右;

    	public Par X0Y0_脈上1;

    	public Par X0Y0_脈上2;

    	public Par X0Y0_脈下1;

    	public Par X0Y0_脈下2;

    	public Par X0Y0_虫食_左_虫食1;

    	public Par X0Y0_虫食_左_虫食2;

    	public Par X0Y0_虫食_左_虫食3;

    	public Par X0Y0_虫食_左_虫食4;

    	public Par X0Y0_虫食_左_虫食5;

    	public Par X0Y0_虫食_左_虫食6;

    	public Par X0Y0_虫食_左_虫食7;

    	public Par X0Y0_虫食_左_虫食8;

    	public Par X0Y0_虫食_左_虫食9;

    	public Par X0Y0_虫食_左_虫食10;

    	public Par X0Y0_虫食_左_虫食11;

    	public Par X0Y0_虫食_左_虫食12;

    	public Par X0Y0_虫食_右_虫食1;

    	public Par X0Y0_虫食_右_虫食2;

    	public Par X0Y0_虫食_右_虫食3;

    	public Par X0Y0_虫食_右_虫食4;

    	public Par X0Y0_虫食_右_虫食5;

    	public Par X0Y0_虫食_右_虫食6;

    	public Par X0Y0_虫食_右_虫食7;

    	public Par X0Y0_虫食_右_虫食8;

    	public Par X0Y0_虫食_右_虫食9;

    	public Par X0Y0_虫食_右_虫食10;

    	public Par X0Y0_虫食_右_虫食11;

    	public Par X0Y0_虫食_右_虫食12;

    	public Par X0Y0_脚輪_革;

    	public Par X0Y0_脚輪_金具1;

    	public Par X0Y0_脚輪_金具2;

    	public Par X0Y0_脚輪_金具3;

    	public Par X0Y0_脚輪_金具左;

    	public Par X0Y0_脚輪_金具右;

    	public ColorD 幹上CD;

    	public ColorD 幹下CD;

    	public ColorD 葉左CD;

    	public ColorD 葉右CD;

    	public ColorD 脈上1CD;

    	public ColorD 脈上2CD;

    	public ColorD 脈下1CD;

    	public ColorD 脈下2CD;

    	public ColorD 虫食_左_虫食1CD;

    	public ColorD 虫食_左_虫食2CD;

    	public ColorD 虫食_左_虫食3CD;

    	public ColorD 虫食_左_虫食4CD;

    	public ColorD 虫食_左_虫食5CD;

    	public ColorD 虫食_左_虫食6CD;

    	public ColorD 虫食_左_虫食7CD;

    	public ColorD 虫食_左_虫食8CD;

    	public ColorD 虫食_左_虫食9CD;

    	public ColorD 虫食_左_虫食10CD;

    	public ColorD 虫食_左_虫食11CD;

    	public ColorD 虫食_左_虫食12CD;

    	public ColorD 虫食_右_虫食1CD;

    	public ColorD 虫食_右_虫食2CD;

    	public ColorD 虫食_右_虫食3CD;

    	public ColorD 虫食_右_虫食4CD;

    	public ColorD 虫食_右_虫食5CD;

    	public ColorD 虫食_右_虫食6CD;

    	public ColorD 虫食_右_虫食7CD;

    	public ColorD 虫食_右_虫食8CD;

    	public ColorD 虫食_右_虫食9CD;

    	public ColorD 虫食_右_虫食10CD;

    	public ColorD 虫食_右_虫食11CD;

    	public ColorD 虫食_右_虫食12CD;

    	public ColorD 脚輪_革CD;

    	public ColorD 脚輪_金具1CD;

    	public ColorD 脚輪_金具2CD;

    	public ColorD 脚輪_金具3CD;

    	public ColorD 脚輪_金具左CD;

    	public ColorD 脚輪_金具右CD;

    	public ColorP X0Y0_幹上CP;

    	public ColorP X0Y0_幹下CP;

    	public ColorP X0Y0_葉左CP;

    	public ColorP X0Y0_葉右CP;

    	public ColorP X0Y0_脈上1CP;

    	public ColorP X0Y0_脈上2CP;

    	public ColorP X0Y0_脈下1CP;

    	public ColorP X0Y0_脈下2CP;

    	public ColorP X0Y0_虫食_左_虫食1CP;

    	public ColorP X0Y0_虫食_左_虫食2CP;

    	public ColorP X0Y0_虫食_左_虫食3CP;

    	public ColorP X0Y0_虫食_左_虫食4CP;

    	public ColorP X0Y0_虫食_左_虫食5CP;

    	public ColorP X0Y0_虫食_左_虫食6CP;

    	public ColorP X0Y0_虫食_左_虫食7CP;

    	public ColorP X0Y0_虫食_左_虫食8CP;

    	public ColorP X0Y0_虫食_左_虫食9CP;

    	public ColorP X0Y0_虫食_左_虫食10CP;

    	public ColorP X0Y0_虫食_左_虫食11CP;

    	public ColorP X0Y0_虫食_左_虫食12CP;

    	public ColorP X0Y0_虫食_右_虫食1CP;

    	public ColorP X0Y0_虫食_右_虫食2CP;

    	public ColorP X0Y0_虫食_右_虫食3CP;

    	public ColorP X0Y0_虫食_右_虫食4CP;

    	public ColorP X0Y0_虫食_右_虫食5CP;

    	public ColorP X0Y0_虫食_右_虫食6CP;

    	public ColorP X0Y0_虫食_右_虫食7CP;

    	public ColorP X0Y0_虫食_右_虫食8CP;

    	public ColorP X0Y0_虫食_右_虫食9CP;

    	public ColorP X0Y0_虫食_右_虫食10CP;

    	public ColorP X0Y0_虫食_右_虫食11CP;

    	public ColorP X0Y0_虫食_右_虫食12CP;

    	public ColorP X0Y0_脚輪_革CP;

    	public ColorP X0Y0_脚輪_金具1CP;

    	public ColorP X0Y0_脚輪_金具2CP;

    	public ColorP X0Y0_脚輪_金具3CP;

    	public ColorP X0Y0_脚輪_金具左CP;

    	public ColorP X0Y0_脚輪_金具右CP;

    	public 拘束鎖 鎖1;

    	public 拘束鎖 鎖2;

    	public Ele[] 根外左_接続;

    	public Ele[] 根内左_接続;

    	public Ele[] 根中央_接続;

    	public Ele[] 根内右_接続;

    	public Ele[] 根外右_接続;

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
    			脚輪表示 = value;
    		}
    	}

    	public bool 幹上_表示
    	{
    		get
    		{
    			return X0Y0_幹上.Dra;
    		}
    		set
    		{
    			X0Y0_幹上.Dra = value;
    			X0Y0_幹上.Hit = value;
    		}
    	}

    	public bool 幹下_表示
    	{
    		get
    		{
    			return X0Y0_幹下.Dra;
    		}
    		set
    		{
    			X0Y0_幹下.Dra = value;
    			X0Y0_幹下.Hit = value;
    		}
    	}

    	public bool 葉左_表示
    	{
    		get
    		{
    			return X0Y0_葉左.Dra;
    		}
    		set
    		{
    			X0Y0_葉左.Dra = value;
    			X0Y0_葉左.Hit = value;
    		}
    	}

    	public bool 葉右_表示
    	{
    		get
    		{
    			return X0Y0_葉右.Dra;
    		}
    		set
    		{
    			X0Y0_葉右.Dra = value;
    			X0Y0_葉右.Hit = value;
    		}
    	}

    	public bool 脈上1_表示
    	{
    		get
    		{
    			return X0Y0_脈上1.Dra;
    		}
    		set
    		{
    			X0Y0_脈上1.Dra = value;
    			X0Y0_脈上1.Hit = value;
    		}
    	}

    	public bool 脈上2_表示
    	{
    		get
    		{
    			return X0Y0_脈上2.Dra;
    		}
    		set
    		{
    			X0Y0_脈上2.Dra = value;
    			X0Y0_脈上2.Hit = value;
    		}
    	}

    	public bool 脈下1_表示
    	{
    		get
    		{
    			return X0Y0_脈下1.Dra;
    		}
    		set
    		{
    			X0Y0_脈下1.Dra = value;
    			X0Y0_脈下1.Hit = value;
    		}
    	}

    	public bool 脈下2_表示
    	{
    		get
    		{
    			return X0Y0_脈下2.Dra;
    		}
    		set
    		{
    			X0Y0_脈下2.Dra = value;
    			X0Y0_脈下2.Hit = value;
    		}
    	}

    	public bool 虫食_左_虫食1_表示
    	{
    		get
    		{
    			return X0Y0_虫食_左_虫食1.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_左_虫食1.Dra = value;
    			X0Y0_虫食_左_虫食1.Hit = value;
    		}
    	}

    	public bool 虫食_左_虫食2_表示
    	{
    		get
    		{
    			return X0Y0_虫食_左_虫食2.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_左_虫食2.Dra = value;
    			X0Y0_虫食_左_虫食2.Hit = value;
    		}
    	}

    	public bool 虫食_左_虫食3_表示
    	{
    		get
    		{
    			return X0Y0_虫食_左_虫食3.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_左_虫食3.Dra = value;
    			X0Y0_虫食_左_虫食3.Hit = value;
    		}
    	}

    	public bool 虫食_左_虫食4_表示
    	{
    		get
    		{
    			return X0Y0_虫食_左_虫食4.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_左_虫食4.Dra = value;
    			X0Y0_虫食_左_虫食4.Hit = value;
    		}
    	}

    	public bool 虫食_左_虫食5_表示
    	{
    		get
    		{
    			return X0Y0_虫食_左_虫食5.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_左_虫食5.Dra = value;
    			X0Y0_虫食_左_虫食5.Hit = value;
    		}
    	}

    	public bool 虫食_左_虫食6_表示
    	{
    		get
    		{
    			return X0Y0_虫食_左_虫食6.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_左_虫食6.Dra = value;
    			X0Y0_虫食_左_虫食6.Hit = value;
    		}
    	}

    	public bool 虫食_左_虫食7_表示
    	{
    		get
    		{
    			return X0Y0_虫食_左_虫食7.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_左_虫食7.Dra = value;
    			X0Y0_虫食_左_虫食7.Hit = value;
    		}
    	}

    	public bool 虫食_左_虫食8_表示
    	{
    		get
    		{
    			return X0Y0_虫食_左_虫食8.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_左_虫食8.Dra = value;
    			X0Y0_虫食_左_虫食8.Hit = value;
    		}
    	}

    	public bool 虫食_左_虫食9_表示
    	{
    		get
    		{
    			return X0Y0_虫食_左_虫食9.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_左_虫食9.Dra = value;
    			X0Y0_虫食_左_虫食9.Hit = value;
    		}
    	}

    	public bool 虫食_左_虫食10_表示
    	{
    		get
    		{
    			return X0Y0_虫食_左_虫食10.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_左_虫食10.Dra = value;
    			X0Y0_虫食_左_虫食10.Hit = value;
    		}
    	}

    	public bool 虫食_左_虫食11_表示
    	{
    		get
    		{
    			return X0Y0_虫食_左_虫食11.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_左_虫食11.Dra = value;
    			X0Y0_虫食_左_虫食11.Hit = value;
    		}
    	}

    	public bool 虫食_左_虫食12_表示
    	{
    		get
    		{
    			return X0Y0_虫食_左_虫食12.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_左_虫食12.Dra = value;
    			X0Y0_虫食_左_虫食12.Hit = value;
    		}
    	}

    	public bool 虫食_右_虫食1_表示
    	{
    		get
    		{
    			return X0Y0_虫食_右_虫食1.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_右_虫食1.Dra = value;
    			X0Y0_虫食_右_虫食1.Hit = value;
    		}
    	}

    	public bool 虫食_右_虫食2_表示
    	{
    		get
    		{
    			return X0Y0_虫食_右_虫食2.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_右_虫食2.Dra = value;
    			X0Y0_虫食_右_虫食2.Hit = value;
    		}
    	}

    	public bool 虫食_右_虫食3_表示
    	{
    		get
    		{
    			return X0Y0_虫食_右_虫食3.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_右_虫食3.Dra = value;
    			X0Y0_虫食_右_虫食3.Hit = value;
    		}
    	}

    	public bool 虫食_右_虫食4_表示
    	{
    		get
    		{
    			return X0Y0_虫食_右_虫食4.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_右_虫食4.Dra = value;
    			X0Y0_虫食_右_虫食4.Hit = value;
    		}
    	}

    	public bool 虫食_右_虫食5_表示
    	{
    		get
    		{
    			return X0Y0_虫食_右_虫食5.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_右_虫食5.Dra = value;
    			X0Y0_虫食_右_虫食5.Hit = value;
    		}
    	}

    	public bool 虫食_右_虫食6_表示
    	{
    		get
    		{
    			return X0Y0_虫食_右_虫食6.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_右_虫食6.Dra = value;
    			X0Y0_虫食_右_虫食6.Hit = value;
    		}
    	}

    	public bool 虫食_右_虫食7_表示
    	{
    		get
    		{
    			return X0Y0_虫食_右_虫食7.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_右_虫食7.Dra = value;
    			X0Y0_虫食_右_虫食7.Hit = value;
    		}
    	}

    	public bool 虫食_右_虫食8_表示
    	{
    		get
    		{
    			return X0Y0_虫食_右_虫食8.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_右_虫食8.Dra = value;
    			X0Y0_虫食_右_虫食8.Hit = value;
    		}
    	}

    	public bool 虫食_右_虫食9_表示
    	{
    		get
    		{
    			return X0Y0_虫食_右_虫食9.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_右_虫食9.Dra = value;
    			X0Y0_虫食_右_虫食9.Hit = value;
    		}
    	}

    	public bool 虫食_右_虫食10_表示
    	{
    		get
    		{
    			return X0Y0_虫食_右_虫食10.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_右_虫食10.Dra = value;
    			X0Y0_虫食_右_虫食10.Hit = value;
    		}
    	}

    	public bool 虫食_右_虫食11_表示
    	{
    		get
    		{
    			return X0Y0_虫食_右_虫食11.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_右_虫食11.Dra = value;
    			X0Y0_虫食_右_虫食11.Hit = value;
    		}
    	}

    	public bool 虫食_右_虫食12_表示
    	{
    		get
    		{
    			return X0Y0_虫食_右_虫食12.Dra;
    		}
    		set
    		{
    			X0Y0_虫食_右_虫食12.Dra = value;
    			X0Y0_虫食_右_虫食12.Hit = value;
    		}
    	}

    	public bool 脚輪_革_表示
    	{
    		get
    		{
    			return X0Y0_脚輪_革.Dra;
    		}
    		set
    		{
    			X0Y0_脚輪_革.Dra = value;
    			X0Y0_脚輪_革.Hit = value;
    		}
    	}

    	public bool 脚輪_金具1_表示
    	{
    		get
    		{
    			return X0Y0_脚輪_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_脚輪_金具1.Dra = value;
    			X0Y0_脚輪_金具1.Hit = value;
    		}
    	}

    	public bool 脚輪_金具2_表示
    	{
    		get
    		{
    			return X0Y0_脚輪_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_脚輪_金具2.Dra = value;
    			X0Y0_脚輪_金具2.Hit = value;
    		}
    	}

    	public bool 脚輪_金具3_表示
    	{
    		get
    		{
    			return X0Y0_脚輪_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_脚輪_金具3.Dra = value;
    			X0Y0_脚輪_金具3.Hit = value;
    		}
    	}

    	public bool 脚輪_金具左_表示
    	{
    		get
    		{
    			return X0Y0_脚輪_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_脚輪_金具左.Dra = value;
    			X0Y0_脚輪_金具左.Hit = value;
    		}
    	}

    	public bool 脚輪_金具右_表示
    	{
    		get
    		{
    			return X0Y0_脚輪_金具右.Dra;
    		}
    		set
    		{
    			X0Y0_脚輪_金具右.Dra = value;
    			X0Y0_脚輪_金具右.Hit = value;
    		}
    	}

    	public bool 脚輪表示
    	{
    		get
    		{
    			return 脚輪_革_表示;
    		}
    		set
    		{
    			脚輪_革_表示 = value;
    			脚輪_金具1_表示 = value;
    			脚輪_金具2_表示 = value;
    			脚輪_金具3_表示 = value;
    			脚輪_金具左_表示 = value;
    			脚輪_金具右_表示 = value;
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
    			return 幹上_表示;
    		}
    		set
    		{
    			幹上_表示 = value;
    			幹下_表示 = value;
    			葉左_表示 = value;
    			葉右_表示 = value;
    			脈上1_表示 = value;
    			脈上2_表示 = value;
    			脈下1_表示 = value;
    			脈下2_表示 = value;
    			虫食_左_虫食1_表示 = value;
    			虫食_左_虫食2_表示 = value;
    			虫食_左_虫食3_表示 = value;
    			虫食_左_虫食4_表示 = value;
    			虫食_左_虫食5_表示 = value;
    			虫食_左_虫食6_表示 = value;
    			虫食_左_虫食7_表示 = value;
    			虫食_左_虫食8_表示 = value;
    			虫食_左_虫食9_表示 = value;
    			虫食_左_虫食10_表示 = value;
    			虫食_左_虫食11_表示 = value;
    			虫食_左_虫食12_表示 = value;
    			虫食_右_虫食1_表示 = value;
    			虫食_右_虫食2_表示 = value;
    			虫食_右_虫食3_表示 = value;
    			虫食_右_虫食4_表示 = value;
    			虫食_右_虫食5_表示 = value;
    			虫食_右_虫食6_表示 = value;
    			虫食_右_虫食7_表示 = value;
    			虫食_右_虫食8_表示 = value;
    			虫食_右_虫食9_表示 = value;
    			虫食_右_虫食10_表示 = value;
    			虫食_右_虫食11_表示 = value;
    			虫食_右_虫食12_表示 = value;
    			脚輪_革_表示 = value;
    			脚輪_金具1_表示 = value;
    			脚輪_金具2_表示 = value;
    			脚輪_金具3_表示 = value;
    			脚輪_金具左_表示 = value;
    			脚輪_金具右_表示 = value;
    			鎖1.表示 = value;
    			鎖2.表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 幹上CD.不透明度;
    		}
    		set
    		{
    			幹上CD.不透明度 = value;
    			幹下CD.不透明度 = value;
    			葉左CD.不透明度 = value;
    			葉右CD.不透明度 = value;
    			脈上1CD.不透明度 = value;
    			脈上2CD.不透明度 = value;
    			脈下1CD.不透明度 = value;
    			脈下2CD.不透明度 = value;
    			虫食_左_虫食1CD.不透明度 = value;
    			虫食_左_虫食2CD.不透明度 = value;
    			虫食_左_虫食3CD.不透明度 = value;
    			虫食_左_虫食4CD.不透明度 = value;
    			虫食_左_虫食5CD.不透明度 = value;
    			虫食_左_虫食6CD.不透明度 = value;
    			虫食_左_虫食7CD.不透明度 = value;
    			虫食_左_虫食8CD.不透明度 = value;
    			虫食_左_虫食9CD.不透明度 = value;
    			虫食_左_虫食10CD.不透明度 = value;
    			虫食_左_虫食11CD.不透明度 = value;
    			虫食_左_虫食12CD.不透明度 = value;
    			虫食_右_虫食1CD.不透明度 = value;
    			虫食_右_虫食2CD.不透明度 = value;
    			虫食_右_虫食3CD.不透明度 = value;
    			虫食_右_虫食4CD.不透明度 = value;
    			虫食_右_虫食5CD.不透明度 = value;
    			虫食_右_虫食6CD.不透明度 = value;
    			虫食_右_虫食7CD.不透明度 = value;
    			虫食_右_虫食8CD.不透明度 = value;
    			虫食_右_虫食9CD.不透明度 = value;
    			虫食_右_虫食10CD.不透明度 = value;
    			虫食_右_虫食11CD.不透明度 = value;
    			虫食_右_虫食12CD.不透明度 = value;
    			脚輪_革CD.不透明度 = value;
    			脚輪_金具1CD.不透明度 = value;
    			脚輪_金具2CD.不透明度 = value;
    			脚輪_金具3CD.不透明度 = value;
    			脚輪_金具左CD.不透明度 = value;
    			脚輪_金具右CD.不透明度 = value;
    		}
    	}

    	public JointS 根外左_接続点 => new JointS(Body, X0Y0_幹下, 0);

    	public JointS 根内左_接続点 => new JointS(Body, X0Y0_幹下, 1);

    	public JointS 根中央_接続点 => new JointS(Body, X0Y0_幹下, 2);

    	public JointS 根内右_接続点 => new JointS(Body, X0Y0_幹下, 3);

    	public JointS 根外右_接続点 => new JointS(Body, X0Y0_幹下, 4);

    	public JointS 鎖1_接続点 => new JointS(Body, X0Y0_脚輪_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(Body, X0Y0_脚輪_金具右, 0);

    	public 単足_植(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 単足_植D e)
    	{
    		単足_植 単足_植2 = this;
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "植";
    		dif.Add(new Pars(Sta.半身["単足"][0][0]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_幹上 = pars["幹上"].ToPar();
    		X0Y0_幹下 = pars["幹下"].ToPar();
    		X0Y0_葉左 = pars["葉左"].ToPar();
    		X0Y0_葉右 = pars["葉右"].ToPar();
    		X0Y0_脈上1 = pars["脈上1"].ToPar();
    		X0Y0_脈上2 = pars["脈上2"].ToPar();
    		X0Y0_脈下1 = pars["脈下1"].ToPar();
    		X0Y0_脈下2 = pars["脈下2"].ToPar();
    		Pars pars2 = pars["虫食"].ToPars();
    		Pars pars3 = pars2["左"].ToPars();
    		X0Y0_虫食_左_虫食1 = pars3["虫食1"].ToPar();
    		X0Y0_虫食_左_虫食2 = pars3["虫食2"].ToPar();
    		X0Y0_虫食_左_虫食3 = pars3["虫食3"].ToPar();
    		X0Y0_虫食_左_虫食4 = pars3["虫食4"].ToPar();
    		X0Y0_虫食_左_虫食5 = pars3["虫食5"].ToPar();
    		X0Y0_虫食_左_虫食6 = pars3["虫食6"].ToPar();
    		X0Y0_虫食_左_虫食7 = pars3["虫食7"].ToPar();
    		X0Y0_虫食_左_虫食8 = pars3["虫食8"].ToPar();
    		X0Y0_虫食_左_虫食9 = pars3["虫食9"].ToPar();
    		X0Y0_虫食_左_虫食10 = pars3["虫食10"].ToPar();
    		X0Y0_虫食_左_虫食11 = pars3["虫食11"].ToPar();
    		X0Y0_虫食_左_虫食12 = pars3["虫食12"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y0_虫食_右_虫食1 = pars3["虫食1"].ToPar();
    		X0Y0_虫食_右_虫食2 = pars3["虫食2"].ToPar();
    		X0Y0_虫食_右_虫食3 = pars3["虫食3"].ToPar();
    		X0Y0_虫食_右_虫食4 = pars3["虫食4"].ToPar();
    		X0Y0_虫食_右_虫食5 = pars3["虫食5"].ToPar();
    		X0Y0_虫食_右_虫食6 = pars3["虫食6"].ToPar();
    		X0Y0_虫食_右_虫食7 = pars3["虫食7"].ToPar();
    		X0Y0_虫食_右_虫食8 = pars3["虫食8"].ToPar();
    		X0Y0_虫食_右_虫食9 = pars3["虫食9"].ToPar();
    		X0Y0_虫食_右_虫食10 = pars3["虫食10"].ToPar();
    		X0Y0_虫食_右_虫食11 = pars3["虫食11"].ToPar();
    		X0Y0_虫食_右_虫食12 = pars3["虫食12"].ToPar();
    		pars2 = pars["脚輪"].ToPars();
    		X0Y0_脚輪_革 = pars2["革"].ToPar();
    		X0Y0_脚輪_金具1 = pars2["金具1"].ToPar();
    		X0Y0_脚輪_金具2 = pars2["金具2"].ToPar();
    		X0Y0_脚輪_金具3 = pars2["金具3"].ToPar();
    		X0Y0_脚輪_金具左 = pars2["金具左"].ToPar();
    		X0Y0_脚輪_金具右 = pars2["金具右"].ToPar();
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
    		幹上_表示 = e.幹上_表示;
    		幹下_表示 = e.幹下_表示;
    		葉左_表示 = e.葉左_表示;
    		葉右_表示 = e.葉右_表示;
    		脈上1_表示 = e.脈上1_表示;
    		脈上2_表示 = e.脈上2_表示;
    		脈下1_表示 = e.脈下1_表示;
    		脈下2_表示 = e.脈下2_表示;
    		虫食_左_虫食1_表示 = e.虫食_左_虫食1_表示;
    		虫食_左_虫食2_表示 = e.虫食_左_虫食2_表示;
    		虫食_左_虫食3_表示 = e.虫食_左_虫食3_表示;
    		虫食_左_虫食4_表示 = e.虫食_左_虫食4_表示;
    		虫食_左_虫食5_表示 = e.虫食_左_虫食5_表示;
    		虫食_左_虫食6_表示 = e.虫食_左_虫食6_表示;
    		虫食_左_虫食7_表示 = e.虫食_左_虫食7_表示;
    		虫食_左_虫食8_表示 = e.虫食_左_虫食8_表示;
    		虫食_左_虫食9_表示 = e.虫食_左_虫食9_表示;
    		虫食_左_虫食10_表示 = e.虫食_左_虫食10_表示;
    		虫食_左_虫食11_表示 = e.虫食_左_虫食11_表示;
    		虫食_左_虫食12_表示 = e.虫食_左_虫食12_表示;
    		虫食_右_虫食1_表示 = e.虫食_右_虫食1_表示;
    		虫食_右_虫食2_表示 = e.虫食_右_虫食2_表示;
    		虫食_右_虫食3_表示 = e.虫食_右_虫食3_表示;
    		虫食_右_虫食4_表示 = e.虫食_右_虫食4_表示;
    		虫食_右_虫食5_表示 = e.虫食_右_虫食5_表示;
    		虫食_右_虫食6_表示 = e.虫食_右_虫食6_表示;
    		虫食_右_虫食7_表示 = e.虫食_右_虫食7_表示;
    		虫食_右_虫食8_表示 = e.虫食_右_虫食8_表示;
    		虫食_右_虫食9_表示 = e.虫食_右_虫食9_表示;
    		虫食_右_虫食10_表示 = e.虫食_右_虫食10_表示;
    		虫食_右_虫食11_表示 = e.虫食_右_虫食11_表示;
    		虫食_右_虫食12_表示 = e.虫食_右_虫食12_表示;
    		脚輪_革_表示 = e.脚輪_革_表示;
    		脚輪_金具1_表示 = e.脚輪_金具1_表示;
    		脚輪_金具2_表示 = e.脚輪_金具2_表示;
    		脚輪_金具3_表示 = e.脚輪_金具3_表示;
    		脚輪_金具左_表示 = e.脚輪_金具左_表示;
    		脚輪_金具右_表示 = e.脚輪_金具右_表示;
    		脚輪表示 = e.脚輪表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Ele f;
    		if (e.根外左_接続.Count > 0)
    		{
    			根外左_接続 = e.根外左_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 単足_植2;
    				f.ConnectionType = ConnectionInfo.単足_植_根外左_接続;
    				f.接続(単足_植2.根外左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.根内左_接続.Count > 0)
    		{
    			根内左_接続 = e.根内左_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 単足_植2;
    				f.ConnectionType = ConnectionInfo.単足_植_根内左_接続;
    				f.接続(単足_植2.根内左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.根中央_接続.Count > 0)
    		{
    			根中央_接続 = e.根中央_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 単足_植2;
    				f.ConnectionType = ConnectionInfo.単足_植_根中央_接続;
    				f.接続(単足_植2.根中央_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.根内右_接続.Count > 0)
    		{
    			根内右_接続 = e.根内右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 単足_植2;
    				f.ConnectionType = ConnectionInfo.単足_植_根内右_接続;
    				f.接続(単足_植2.根内右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.根外右_接続.Count > 0)
    		{
    			根外右_接続 = e.根外右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 単足_植2;
    				f.ConnectionType = ConnectionInfo.単足_植_根外右_接続;
    				f.接続(単足_植2.根外右_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_幹上CP = new ColorP(X0Y0_幹上, 幹上CD, DisUnit, abj: true);
    		X0Y0_幹下CP = new ColorP(X0Y0_幹下, 幹下CD, DisUnit, abj: true);
    		X0Y0_葉左CP = new ColorP(X0Y0_葉左, 葉左CD, DisUnit, abj: true);
    		X0Y0_葉右CP = new ColorP(X0Y0_葉右, 葉右CD, DisUnit, abj: true);
    		X0Y0_脈上1CP = new ColorP(X0Y0_脈上1, 脈上1CD, DisUnit, abj: true);
    		X0Y0_脈上2CP = new ColorP(X0Y0_脈上2, 脈上2CD, DisUnit, abj: true);
    		X0Y0_脈下1CP = new ColorP(X0Y0_脈下1, 脈下1CD, DisUnit, abj: true);
    		X0Y0_脈下2CP = new ColorP(X0Y0_脈下2, 脈下2CD, DisUnit, abj: true);
    		X0Y0_虫食_左_虫食1CP = new ColorP(X0Y0_虫食_左_虫食1, 虫食_左_虫食1CD, DisUnit, abj: true);
    		X0Y0_虫食_左_虫食2CP = new ColorP(X0Y0_虫食_左_虫食2, 虫食_左_虫食2CD, DisUnit, abj: true);
    		X0Y0_虫食_左_虫食3CP = new ColorP(X0Y0_虫食_左_虫食3, 虫食_左_虫食3CD, DisUnit, abj: true);
    		X0Y0_虫食_左_虫食4CP = new ColorP(X0Y0_虫食_左_虫食4, 虫食_左_虫食4CD, DisUnit, abj: true);
    		X0Y0_虫食_左_虫食5CP = new ColorP(X0Y0_虫食_左_虫食5, 虫食_左_虫食5CD, DisUnit, abj: true);
    		X0Y0_虫食_左_虫食6CP = new ColorP(X0Y0_虫食_左_虫食6, 虫食_左_虫食6CD, DisUnit, abj: true);
    		X0Y0_虫食_左_虫食7CP = new ColorP(X0Y0_虫食_左_虫食7, 虫食_左_虫食7CD, DisUnit, abj: true);
    		X0Y0_虫食_左_虫食8CP = new ColorP(X0Y0_虫食_左_虫食8, 虫食_左_虫食8CD, DisUnit, abj: true);
    		X0Y0_虫食_左_虫食9CP = new ColorP(X0Y0_虫食_左_虫食9, 虫食_左_虫食9CD, DisUnit, abj: true);
    		X0Y0_虫食_左_虫食10CP = new ColorP(X0Y0_虫食_左_虫食10, 虫食_左_虫食10CD, DisUnit, abj: true);
    		X0Y0_虫食_左_虫食11CP = new ColorP(X0Y0_虫食_左_虫食11, 虫食_左_虫食11CD, DisUnit, abj: true);
    		X0Y0_虫食_左_虫食12CP = new ColorP(X0Y0_虫食_左_虫食12, 虫食_左_虫食12CD, DisUnit, abj: true);
    		X0Y0_虫食_右_虫食1CP = new ColorP(X0Y0_虫食_右_虫食1, 虫食_右_虫食1CD, DisUnit, abj: true);
    		X0Y0_虫食_右_虫食2CP = new ColorP(X0Y0_虫食_右_虫食2, 虫食_右_虫食2CD, DisUnit, abj: true);
    		X0Y0_虫食_右_虫食3CP = new ColorP(X0Y0_虫食_右_虫食3, 虫食_右_虫食3CD, DisUnit, abj: true);
    		X0Y0_虫食_右_虫食4CP = new ColorP(X0Y0_虫食_右_虫食4, 虫食_右_虫食4CD, DisUnit, abj: true);
    		X0Y0_虫食_右_虫食5CP = new ColorP(X0Y0_虫食_右_虫食5, 虫食_右_虫食5CD, DisUnit, abj: true);
    		X0Y0_虫食_右_虫食6CP = new ColorP(X0Y0_虫食_右_虫食6, 虫食_右_虫食6CD, DisUnit, abj: true);
    		X0Y0_虫食_右_虫食7CP = new ColorP(X0Y0_虫食_右_虫食7, 虫食_右_虫食7CD, DisUnit, abj: true);
    		X0Y0_虫食_右_虫食8CP = new ColorP(X0Y0_虫食_右_虫食8, 虫食_右_虫食8CD, DisUnit, abj: true);
    		X0Y0_虫食_右_虫食9CP = new ColorP(X0Y0_虫食_右_虫食9, 虫食_右_虫食9CD, DisUnit, abj: true);
    		X0Y0_虫食_右_虫食10CP = new ColorP(X0Y0_虫食_右_虫食10, 虫食_右_虫食10CD, DisUnit, abj: true);
    		X0Y0_虫食_右_虫食11CP = new ColorP(X0Y0_虫食_右_虫食11, 虫食_右_虫食11CD, DisUnit, abj: true);
    		X0Y0_虫食_右_虫食12CP = new ColorP(X0Y0_虫食_右_虫食12, 虫食_右_虫食12CD, DisUnit, abj: true);
    		X0Y0_脚輪_革CP = new ColorP(X0Y0_脚輪_革, 脚輪_革CD, DisUnit, abj: true);
    		X0Y0_脚輪_金具1CP = new ColorP(X0Y0_脚輪_金具1, 脚輪_金具1CD, DisUnit, abj: true);
    		X0Y0_脚輪_金具2CP = new ColorP(X0Y0_脚輪_金具2, 脚輪_金具2CD, DisUnit, abj: true);
    		X0Y0_脚輪_金具3CP = new ColorP(X0Y0_脚輪_金具3, 脚輪_金具3CD, DisUnit, abj: true);
    		X0Y0_脚輪_金具左CP = new ColorP(X0Y0_脚輪_金具左, 脚輪_金具左CD, DisUnit, abj: true);
    		X0Y0_脚輪_金具右CP = new ColorP(X0Y0_脚輪_金具右, 脚輪_金具右CD, DisUnit, abj: true);
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

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    		鎖2.Dispose();
    	}

    	public override void SetAngle0()
    	{
    		_ = 右;
    		X0Y0_幹下.SetAngleBase(10.0.GetRanAngle());
    		Body.JoinPAall();
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Body.Draw(Are);
    		鎖1.描画0(Are);
    		鎖2.描画0(Are);
    	}

    	public override bool Is革(Par p)
    	{
    		if (p != X0Y0_脚輪_革 && p != X0Y0_脚輪_金具1 && p != X0Y0_脚輪_金具2 && p != X0Y0_脚輪_金具3 && p != X0Y0_脚輪_金具左)
    		{
    			return p == X0Y0_脚輪_金具右;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_幹上CP.Update();
    		X0Y0_幹下CP.Update();
    		X0Y0_葉左CP.Update();
    		X0Y0_葉右CP.Update();
    		X0Y0_脈上1CP.Update();
    		X0Y0_脈上2CP.Update();
    		X0Y0_脈下1CP.Update();
    		X0Y0_脈下2CP.Update();
    		X0Y0_虫食_左_虫食1CP.Update();
    		X0Y0_虫食_左_虫食2CP.Update();
    		X0Y0_虫食_左_虫食3CP.Update();
    		X0Y0_虫食_左_虫食4CP.Update();
    		X0Y0_虫食_左_虫食5CP.Update();
    		X0Y0_虫食_左_虫食6CP.Update();
    		X0Y0_虫食_左_虫食7CP.Update();
    		X0Y0_虫食_左_虫食8CP.Update();
    		X0Y0_虫食_左_虫食9CP.Update();
    		X0Y0_虫食_左_虫食10CP.Update();
    		X0Y0_虫食_左_虫食11CP.Update();
    		X0Y0_虫食_左_虫食12CP.Update();
    		X0Y0_虫食_右_虫食1CP.Update();
    		X0Y0_虫食_右_虫食2CP.Update();
    		X0Y0_虫食_右_虫食3CP.Update();
    		X0Y0_虫食_右_虫食4CP.Update();
    		X0Y0_虫食_右_虫食5CP.Update();
    		X0Y0_虫食_右_虫食6CP.Update();
    		X0Y0_虫食_右_虫食7CP.Update();
    		X0Y0_虫食_右_虫食8CP.Update();
    		X0Y0_虫食_右_虫食9CP.Update();
    		X0Y0_虫食_右_虫食10CP.Update();
    		X0Y0_虫食_右_虫食11CP.Update();
    		X0Y0_虫食_右_虫食12CP.Update();
    		X0Y0_脚輪_革CP.Update();
    		X0Y0_脚輪_金具1CP.Update();
    		X0Y0_脚輪_金具2CP.Update();
    		X0Y0_脚輪_金具3CP.Update();
    		X0Y0_脚輪_金具左CP.Update();
    		X0Y0_脚輪_金具右CP.Update();
    		鎖1.接続P();
    		鎖2.接続P();
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
    		case 配色指定.T1:
    			配色T1(体配色);
    			break;
    		case 配色指定.T0:
    			配色T0(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		幹上CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		幹下CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		葉左CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		葉右CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		脈上1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		脈上2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		脈下1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		脈下2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		虫食_左_虫食1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_左_虫食2CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_左_虫食3CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_左_虫食4CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_左_虫食5CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_左_虫食6CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_左_虫食7CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_左_虫食8CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_左_虫食9CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_左_虫食10CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_左_虫食11CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_左_虫食12CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_右_虫食1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_右_虫食2CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_右_虫食3CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_右_虫食4CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_右_虫食5CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_右_虫食6CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_右_虫食7CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_右_虫食8CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_右_虫食9CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_右_虫食10CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_右_虫食11CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		虫食_右_虫食12CD = new ColorD(ref Col.Black, ref 体配色.植1R);
    		脚輪_革CD = new ColorD();
    		脚輪_金具1CD = new ColorD();
    		脚輪_金具2CD = new ColorD();
    		脚輪_金具3CD = new ColorD();
    		脚輪_金具左CD = new ColorD();
    		脚輪_金具右CD = new ColorD();
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		幹上CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		幹下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		葉左CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		葉右CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		脈上1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		脈上2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		脈下1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		脈下2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		虫食_左_虫食1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食2CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食3CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食4CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食5CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食6CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食7CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食8CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食9CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食10CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食11CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食12CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食2CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食3CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食4CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食5CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食6CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食7CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食8CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食9CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食10CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食11CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食12CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		脚輪_革CD = new ColorD();
    		脚輪_金具1CD = new ColorD();
    		脚輪_金具2CD = new ColorD();
    		脚輪_金具3CD = new ColorD();
    		脚輪_金具左CD = new ColorD();
    		脚輪_金具右CD = new ColorD();
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		幹上CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		幹下CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		葉左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		葉右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		脈上1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		脈上2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		脈下1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		脈下2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		虫食_左_虫食1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食2CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食3CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食4CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食5CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食6CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食7CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食8CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食9CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食10CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食11CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_左_虫食12CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食2CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食3CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食4CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食5CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食6CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食7CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食8CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食9CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食10CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食11CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		虫食_右_虫食12CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    		脚輪_革CD = new ColorD();
    		脚輪_金具1CD = new ColorD();
    		脚輪_金具2CD = new ColorD();
    		脚輪_金具3CD = new ColorD();
    		脚輪_金具左CD = new ColorD();
    		脚輪_金具右CD = new ColorD();
    	}

    	public void 脚輪配色(拘束具色 配色)
    	{
    		脚輪_革CD.色 = 配色.革部色;
    		脚輪_金具1CD.色 = 配色.金具色;
    		脚輪_金具2CD.色 = 脚輪_金具1CD.色;
    		脚輪_金具3CD.色 = 脚輪_金具1CD.色;
    		脚輪_金具左CD.色 = 脚輪_金具1CD.色;
    		脚輪_金具右CD.色 = 脚輪_金具1CD.色;
    	}

    	public void 鎖配色(鎖色 配色)
    	{
    		鎖1.配色鎖(配色);
    		鎖2.配色鎖(配色);
    	}

    	public override IEnumerable<Ele> EnumEle()
    	{
    		yield return this;
    		if (根外左_接続 != null)
    		{
    			foreach (Ele item in 根外左_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item;
    			}
    		}
    		if (根外右_接続 != null)
    		{
    			foreach (Ele item2 in 根外右_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item2;
    			}
    		}
    		if (根内左_接続 != null)
    		{
    			foreach (Ele item3 in 根内左_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item3;
    			}
    		}
    		if (根内右_接続 != null)
    		{
    			foreach (Ele item4 in 根内右_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item4;
    			}
    		}
    		if (根中央_接続 == null)
    		{
    			yield break;
    		}
    		foreach (Ele item5 in 根中央_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    		{
    			yield return item5;
    		}
    	}
    }
}
