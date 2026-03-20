using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 顔面_蟲 : 顔面
    {
    	public Par X0Y0_面;

    	public Par X0Y0_眼左_眼1_基;

    	public Par X0Y0_眼左_眼1_眼;

    	public Par X0Y0_眼左_眼1_ハイライト;

    	public Par X0Y0_眼左_眼2_基;

    	public Par X0Y0_眼左_眼2_眼;

    	public Par X0Y0_眼左_眼2_ハイライト;

    	public Par X0Y0_眼左_眼3_基;

    	public Par X0Y0_眼左_眼3_眼;

    	public Par X0Y0_眼左_眼3_ハイライト;

    	public Par X0Y0_眼左_眼4_基;

    	public Par X0Y0_眼左_眼4_眼;

    	public Par X0Y0_眼左_眼4_ハイライト;

    	public Par X0Y0_眼左_眼5_基;

    	public Par X0Y0_眼左_眼5_眼;

    	public Par X0Y0_眼左_眼5_ハイライト;

    	public Par X0Y0_眼右_眼1_基;

    	public Par X0Y0_眼右_眼1_眼;

    	public Par X0Y0_眼右_眼1_ハイライト;

    	public Par X0Y0_眼右_眼2_基;

    	public Par X0Y0_眼右_眼2_眼;

    	public Par X0Y0_眼右_眼2_ハイライト;

    	public Par X0Y0_眼右_眼3_基;

    	public Par X0Y0_眼右_眼3_眼;

    	public Par X0Y0_眼右_眼3_ハイライト;

    	public Par X0Y0_眼右_眼4_基;

    	public Par X0Y0_眼右_眼4_眼;

    	public Par X0Y0_眼右_眼4_ハイライト;

    	public Par X0Y0_眼右_眼5_基;

    	public Par X0Y0_眼右_眼5_眼;

    	public Par X0Y0_眼右_眼5_ハイライト;

    	public Par X0Y0_角左_角左1;

    	public Par X0Y0_角左_角左2;

    	public Par X0Y0_角右_角右1;

    	public Par X0Y0_角右_角右2;

    	public ColorD 面CD;

    	public ColorD 眼左_眼1_基CD;

    	public ColorD 眼左_眼1_眼CD;

    	public ColorD 眼左_眼1_ハイライトCD;

    	public ColorD 眼左_眼2_基CD;

    	public ColorD 眼左_眼2_眼CD;

    	public ColorD 眼左_眼2_ハイライトCD;

    	public ColorD 眼左_眼3_基CD;

    	public ColorD 眼左_眼3_眼CD;

    	public ColorD 眼左_眼3_ハイライトCD;

    	public ColorD 眼左_眼4_基CD;

    	public ColorD 眼左_眼4_眼CD;

    	public ColorD 眼左_眼4_ハイライトCD;

    	public ColorD 眼左_眼5_基CD;

    	public ColorD 眼左_眼5_眼CD;

    	public ColorD 眼左_眼5_ハイライトCD;

    	public ColorD 眼右_眼1_基CD;

    	public ColorD 眼右_眼1_眼CD;

    	public ColorD 眼右_眼1_ハイライトCD;

    	public ColorD 眼右_眼2_基CD;

    	public ColorD 眼右_眼2_眼CD;

    	public ColorD 眼右_眼2_ハイライトCD;

    	public ColorD 眼右_眼3_基CD;

    	public ColorD 眼右_眼3_眼CD;

    	public ColorD 眼右_眼3_ハイライトCD;

    	public ColorD 眼右_眼4_基CD;

    	public ColorD 眼右_眼4_眼CD;

    	public ColorD 眼右_眼4_ハイライトCD;

    	public ColorD 眼右_眼5_基CD;

    	public ColorD 眼右_眼5_眼CD;

    	public ColorD 眼右_眼5_ハイライトCD;

    	public ColorD 角左_角左1CD;

    	public ColorD 角左_角左2CD;

    	public ColorD 角右_角右1CD;

    	public ColorD 角右_角右2CD;

    	public ColorP X0Y0_面CP;

    	public ColorP X0Y0_眼左_眼1_基CP;

    	public ColorP X0Y0_眼左_眼1_眼CP;

    	public ColorP X0Y0_眼左_眼1_ハイライトCP;

    	public ColorP X0Y0_眼左_眼2_基CP;

    	public ColorP X0Y0_眼左_眼2_眼CP;

    	public ColorP X0Y0_眼左_眼2_ハイライトCP;

    	public ColorP X0Y0_眼左_眼3_基CP;

    	public ColorP X0Y0_眼左_眼3_眼CP;

    	public ColorP X0Y0_眼左_眼3_ハイライトCP;

    	public ColorP X0Y0_眼左_眼4_基CP;

    	public ColorP X0Y0_眼左_眼4_眼CP;

    	public ColorP X0Y0_眼左_眼4_ハイライトCP;

    	public ColorP X0Y0_眼左_眼5_基CP;

    	public ColorP X0Y0_眼左_眼5_眼CP;

    	public ColorP X0Y0_眼左_眼5_ハイライトCP;

    	public ColorP X0Y0_眼右_眼1_基CP;

    	public ColorP X0Y0_眼右_眼1_眼CP;

    	public ColorP X0Y0_眼右_眼1_ハイライトCP;

    	public ColorP X0Y0_眼右_眼2_基CP;

    	public ColorP X0Y0_眼右_眼2_眼CP;

    	public ColorP X0Y0_眼右_眼2_ハイライトCP;

    	public ColorP X0Y0_眼右_眼3_基CP;

    	public ColorP X0Y0_眼右_眼3_眼CP;

    	public ColorP X0Y0_眼右_眼3_ハイライトCP;

    	public ColorP X0Y0_眼右_眼4_基CP;

    	public ColorP X0Y0_眼右_眼4_眼CP;

    	public ColorP X0Y0_眼右_眼4_ハイライトCP;

    	public ColorP X0Y0_眼右_眼5_基CP;

    	public ColorP X0Y0_眼右_眼5_眼CP;

    	public ColorP X0Y0_眼右_眼5_ハイライトCP;

    	public ColorP X0Y0_角左_角左1CP;

    	public ColorP X0Y0_角左_角左2CP;

    	public ColorP X0Y0_角右_角右1CP;

    	public ColorP X0Y0_角右_角右2CP;

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

    	public bool 面_表示
    	{
    		get
    		{
    			return X0Y0_面.Dra;
    		}
    		set
    		{
    			X0Y0_面.Dra = value;
    			X0Y0_面.Hit = value;
    		}
    	}

    	public bool 眼左_眼1_基_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼1_基.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼1_基.Dra = value;
    			X0Y0_眼左_眼1_基.Hit = value;
    		}
    	}

    	public bool 眼左_眼1_眼_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼1_眼.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼1_眼.Dra = value;
    			X0Y0_眼左_眼1_眼.Hit = value;
    		}
    	}

    	public bool 眼左_眼1_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼1_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼1_ハイライト.Dra = value;
    			X0Y0_眼左_眼1_ハイライト.Hit = value;
    		}
    	}

    	public bool 眼左_眼2_基_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼2_基.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼2_基.Dra = value;
    			X0Y0_眼左_眼2_基.Hit = value;
    		}
    	}

    	public bool 眼左_眼2_眼_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼2_眼.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼2_眼.Dra = value;
    			X0Y0_眼左_眼2_眼.Hit = value;
    		}
    	}

    	public bool 眼左_眼2_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼2_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼2_ハイライト.Dra = value;
    			X0Y0_眼左_眼2_ハイライト.Hit = value;
    		}
    	}

    	public bool 眼左_眼3_基_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼3_基.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼3_基.Dra = value;
    			X0Y0_眼左_眼3_基.Hit = value;
    		}
    	}

    	public bool 眼左_眼3_眼_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼3_眼.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼3_眼.Dra = value;
    			X0Y0_眼左_眼3_眼.Hit = value;
    		}
    	}

    	public bool 眼左_眼3_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼3_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼3_ハイライト.Dra = value;
    			X0Y0_眼左_眼3_ハイライト.Hit = value;
    		}
    	}

    	public bool 眼左_眼4_基_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼4_基.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼4_基.Dra = value;
    			X0Y0_眼左_眼4_基.Hit = value;
    		}
    	}

    	public bool 眼左_眼4_眼_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼4_眼.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼4_眼.Dra = value;
    			X0Y0_眼左_眼4_眼.Hit = value;
    		}
    	}

    	public bool 眼左_眼4_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼4_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼4_ハイライト.Dra = value;
    			X0Y0_眼左_眼4_ハイライト.Hit = value;
    		}
    	}

    	public bool 眼左_眼5_基_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼5_基.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼5_基.Dra = value;
    			X0Y0_眼左_眼5_基.Hit = value;
    		}
    	}

    	public bool 眼左_眼5_眼_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼5_眼.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼5_眼.Dra = value;
    			X0Y0_眼左_眼5_眼.Hit = value;
    		}
    	}

    	public bool 眼左_眼5_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_眼左_眼5_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_眼左_眼5_ハイライト.Dra = value;
    			X0Y0_眼左_眼5_ハイライト.Hit = value;
    		}
    	}

    	public bool 眼右_眼1_基_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼1_基.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼1_基.Dra = value;
    			X0Y0_眼右_眼1_基.Hit = value;
    		}
    	}

    	public bool 眼右_眼1_眼_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼1_眼.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼1_眼.Dra = value;
    			X0Y0_眼右_眼1_眼.Hit = value;
    		}
    	}

    	public bool 眼右_眼1_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼1_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼1_ハイライト.Dra = value;
    			X0Y0_眼右_眼1_ハイライト.Hit = value;
    		}
    	}

    	public bool 眼右_眼2_基_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼2_基.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼2_基.Dra = value;
    			X0Y0_眼右_眼2_基.Hit = value;
    		}
    	}

    	public bool 眼右_眼2_眼_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼2_眼.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼2_眼.Dra = value;
    			X0Y0_眼右_眼2_眼.Hit = value;
    		}
    	}

    	public bool 眼右_眼2_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼2_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼2_ハイライト.Dra = value;
    			X0Y0_眼右_眼2_ハイライト.Hit = value;
    		}
    	}

    	public bool 眼右_眼3_基_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼3_基.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼3_基.Dra = value;
    			X0Y0_眼右_眼3_基.Hit = value;
    		}
    	}

    	public bool 眼右_眼3_眼_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼3_眼.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼3_眼.Dra = value;
    			X0Y0_眼右_眼3_眼.Hit = value;
    		}
    	}

    	public bool 眼右_眼3_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼3_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼3_ハイライト.Dra = value;
    			X0Y0_眼右_眼3_ハイライト.Hit = value;
    		}
    	}

    	public bool 眼右_眼4_基_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼4_基.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼4_基.Dra = value;
    			X0Y0_眼右_眼4_基.Hit = value;
    		}
    	}

    	public bool 眼右_眼4_眼_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼4_眼.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼4_眼.Dra = value;
    			X0Y0_眼右_眼4_眼.Hit = value;
    		}
    	}

    	public bool 眼右_眼4_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼4_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼4_ハイライト.Dra = value;
    			X0Y0_眼右_眼4_ハイライト.Hit = value;
    		}
    	}

    	public bool 眼右_眼5_基_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼5_基.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼5_基.Dra = value;
    			X0Y0_眼右_眼5_基.Hit = value;
    		}
    	}

    	public bool 眼右_眼5_眼_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼5_眼.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼5_眼.Dra = value;
    			X0Y0_眼右_眼5_眼.Hit = value;
    		}
    	}

    	public bool 眼右_眼5_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_眼右_眼5_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_眼右_眼5_ハイライト.Dra = value;
    			X0Y0_眼右_眼5_ハイライト.Hit = value;
    		}
    	}

    	public bool 角左_角左1_表示
    	{
    		get
    		{
    			return X0Y0_角左_角左1.Dra;
    		}
    		set
    		{
    			X0Y0_角左_角左1.Dra = value;
    			X0Y0_角左_角左1.Hit = value;
    		}
    	}

    	public bool 角左_角左2_表示
    	{
    		get
    		{
    			return X0Y0_角左_角左2.Dra;
    		}
    		set
    		{
    			X0Y0_角左_角左2.Dra = value;
    			X0Y0_角左_角左2.Hit = value;
    		}
    	}

    	public bool 角右_角右1_表示
    	{
    		get
    		{
    			return X0Y0_角右_角右1.Dra;
    		}
    		set
    		{
    			X0Y0_角右_角右1.Dra = value;
    			X0Y0_角右_角右1.Hit = value;
    		}
    	}

    	public bool 角右_角右2_表示
    	{
    		get
    		{
    			return X0Y0_角右_角右2.Dra;
    		}
    		set
    		{
    			X0Y0_角右_角右2.Dra = value;
    			X0Y0_角右_角右2.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 面_表示;
    		}
    		set
    		{
    			面_表示 = value;
    			眼左_眼1_基_表示 = value;
    			眼左_眼1_眼_表示 = value;
    			眼左_眼1_ハイライト_表示 = value;
    			眼左_眼2_基_表示 = value;
    			眼左_眼2_眼_表示 = value;
    			眼左_眼2_ハイライト_表示 = value;
    			眼左_眼3_基_表示 = value;
    			眼左_眼3_眼_表示 = value;
    			眼左_眼3_ハイライト_表示 = value;
    			眼左_眼4_基_表示 = value;
    			眼左_眼4_眼_表示 = value;
    			眼左_眼4_ハイライト_表示 = value;
    			眼左_眼5_基_表示 = value;
    			眼左_眼5_眼_表示 = value;
    			眼左_眼5_ハイライト_表示 = value;
    			眼右_眼1_基_表示 = value;
    			眼右_眼1_眼_表示 = value;
    			眼右_眼1_ハイライト_表示 = value;
    			眼右_眼2_基_表示 = value;
    			眼右_眼2_眼_表示 = value;
    			眼右_眼2_ハイライト_表示 = value;
    			眼右_眼3_基_表示 = value;
    			眼右_眼3_眼_表示 = value;
    			眼右_眼3_ハイライト_表示 = value;
    			眼右_眼4_基_表示 = value;
    			眼右_眼4_眼_表示 = value;
    			眼右_眼4_ハイライト_表示 = value;
    			眼右_眼5_基_表示 = value;
    			眼右_眼5_眼_表示 = value;
    			眼右_眼5_ハイライト_表示 = value;
    			角左_角左1_表示 = value;
    			角左_角左2_表示 = value;
    			角右_角右1_表示 = value;
    			角右_角右2_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 面CD.不透明度;
    		}
    		set
    		{
    			面CD.不透明度 = value;
    			眼左_眼1_基CD.不透明度 = value;
    			眼左_眼1_眼CD.不透明度 = value;
    			眼左_眼1_ハイライトCD.不透明度 = value;
    			眼左_眼2_基CD.不透明度 = value;
    			眼左_眼2_眼CD.不透明度 = value;
    			眼左_眼2_ハイライトCD.不透明度 = value;
    			眼左_眼3_基CD.不透明度 = value;
    			眼左_眼3_眼CD.不透明度 = value;
    			眼左_眼3_ハイライトCD.不透明度 = value;
    			眼左_眼4_基CD.不透明度 = value;
    			眼左_眼4_眼CD.不透明度 = value;
    			眼左_眼4_ハイライトCD.不透明度 = value;
    			眼左_眼5_基CD.不透明度 = value;
    			眼左_眼5_眼CD.不透明度 = value;
    			眼左_眼5_ハイライトCD.不透明度 = value;
    			眼右_眼1_基CD.不透明度 = value;
    			眼右_眼1_眼CD.不透明度 = value;
    			眼右_眼1_ハイライトCD.不透明度 = value;
    			眼右_眼2_基CD.不透明度 = value;
    			眼右_眼2_眼CD.不透明度 = value;
    			眼右_眼2_ハイライトCD.不透明度 = value;
    			眼右_眼3_基CD.不透明度 = value;
    			眼右_眼3_眼CD.不透明度 = value;
    			眼右_眼3_ハイライトCD.不透明度 = value;
    			眼右_眼4_基CD.不透明度 = value;
    			眼右_眼4_眼CD.不透明度 = value;
    			眼右_眼4_ハイライトCD.不透明度 = value;
    			眼右_眼5_基CD.不透明度 = value;
    			眼右_眼5_眼CD.不透明度 = value;
    			眼右_眼5_ハイライトCD.不透明度 = value;
    			角左_角左1CD.不透明度 = value;
    			角左_角左2CD.不透明度 = value;
    			角右_角右1CD.不透明度 = value;
    			角右_角右2CD.不透明度 = value;
    		}
    	}

    	public bool 触覚部眼表示
    	{
    		get
    		{
    			return 眼左_眼1_基_表示;
    		}
    		set
    		{
    			眼左_眼1_基_表示 = value;
    			眼左_眼1_眼_表示 = value;
    			眼左_眼1_ハイライト_表示 = value;
    			眼右_眼1_基_表示 = value;
    			眼右_眼1_眼_表示 = value;
    			眼右_眼1_ハイライト_表示 = value;
    		}
    	}

    	public JointS 触覚左_接続点 => new JointS(Body, X0Y0_面, 0);

    	public JointS 触覚右_接続点 => new JointS(Body, X0Y0_面, 1);

    	public 顔面_蟲(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 顔面_蟲D e)
    	{
    		顔面_蟲 顔面_蟲2 = this;
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.肢中["顔面"][2]);
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_面 = pars["面"].ToPar();
    		Pars pars2 = pars["眼左"].ToPars();
    		Pars pars3 = pars2["眼1"].ToPars();
    		X0Y0_眼左_眼1_基 = pars3["基"].ToPar();
    		X0Y0_眼左_眼1_眼 = pars3["眼"].ToPar();
    		X0Y0_眼左_眼1_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼2"].ToPars();
    		X0Y0_眼左_眼2_基 = pars3["基"].ToPar();
    		X0Y0_眼左_眼2_眼 = pars3["眼"].ToPar();
    		X0Y0_眼左_眼2_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼3"].ToPars();
    		X0Y0_眼左_眼3_基 = pars3["基"].ToPar();
    		X0Y0_眼左_眼3_眼 = pars3["眼"].ToPar();
    		X0Y0_眼左_眼3_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼4"].ToPars();
    		X0Y0_眼左_眼4_基 = pars3["基"].ToPar();
    		X0Y0_眼左_眼4_眼 = pars3["眼"].ToPar();
    		X0Y0_眼左_眼4_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼5"].ToPars();
    		X0Y0_眼左_眼5_基 = pars3["基"].ToPar();
    		X0Y0_眼左_眼5_眼 = pars3["眼"].ToPar();
    		X0Y0_眼左_眼5_ハイライト = pars3["ハイライト"].ToPar();
    		pars2 = pars["眼右"].ToPars();
    		pars3 = pars2["眼1"].ToPars();
    		X0Y0_眼右_眼1_基 = pars3["基"].ToPar();
    		X0Y0_眼右_眼1_眼 = pars3["眼"].ToPar();
    		X0Y0_眼右_眼1_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼2"].ToPars();
    		X0Y0_眼右_眼2_基 = pars3["基"].ToPar();
    		X0Y0_眼右_眼2_眼 = pars3["眼"].ToPar();
    		X0Y0_眼右_眼2_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼3"].ToPars();
    		X0Y0_眼右_眼3_基 = pars3["基"].ToPar();
    		X0Y0_眼右_眼3_眼 = pars3["眼"].ToPar();
    		X0Y0_眼右_眼3_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼4"].ToPars();
    		X0Y0_眼右_眼4_基 = pars3["基"].ToPar();
    		X0Y0_眼右_眼4_眼 = pars3["眼"].ToPar();
    		X0Y0_眼右_眼4_ハイライト = pars3["ハイライト"].ToPar();
    		pars3 = pars2["眼5"].ToPars();
    		X0Y0_眼右_眼5_基 = pars3["基"].ToPar();
    		X0Y0_眼右_眼5_眼 = pars3["眼"].ToPar();
    		X0Y0_眼右_眼5_ハイライト = pars3["ハイライト"].ToPar();
    		pars2 = pars["角左"].ToPars();
    		X0Y0_角左_角左1 = pars2["角左1"].ToPar();
    		X0Y0_角左_角左2 = pars2["角左2"].ToPar();
    		pars2 = pars["角右"].ToPars();
    		X0Y0_角右_角右1 = pars2["角右1"].ToPar();
    		X0Y0_角右_角右2 = pars2["角右2"].ToPar();
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
    		面_表示 = e.面_表示;
    		眼左_眼1_基_表示 = e.眼左_眼1_基_表示;
    		眼左_眼1_眼_表示 = e.眼左_眼1_眼_表示;
    		眼左_眼1_ハイライト_表示 = e.眼左_眼1_ハイライト_表示;
    		眼左_眼2_基_表示 = e.眼左_眼2_基_表示;
    		眼左_眼2_眼_表示 = e.眼左_眼2_眼_表示;
    		眼左_眼2_ハイライト_表示 = e.眼左_眼2_ハイライト_表示;
    		眼左_眼3_基_表示 = e.眼左_眼3_基_表示;
    		眼左_眼3_眼_表示 = e.眼左_眼3_眼_表示;
    		眼左_眼3_ハイライト_表示 = e.眼左_眼3_ハイライト_表示;
    		眼左_眼4_基_表示 = e.眼左_眼4_基_表示;
    		眼左_眼4_眼_表示 = e.眼左_眼4_眼_表示;
    		眼左_眼4_ハイライト_表示 = e.眼左_眼4_ハイライト_表示;
    		眼左_眼5_基_表示 = e.眼左_眼5_基_表示;
    		眼左_眼5_眼_表示 = e.眼左_眼5_眼_表示;
    		眼左_眼5_ハイライト_表示 = e.眼左_眼5_ハイライト_表示;
    		眼右_眼1_基_表示 = e.眼右_眼1_基_表示;
    		眼右_眼1_眼_表示 = e.眼右_眼1_眼_表示;
    		眼右_眼1_ハイライト_表示 = e.眼右_眼1_ハイライト_表示;
    		眼右_眼2_基_表示 = e.眼右_眼2_基_表示;
    		眼右_眼2_眼_表示 = e.眼右_眼2_眼_表示;
    		眼右_眼2_ハイライト_表示 = e.眼右_眼2_ハイライト_表示;
    		眼右_眼3_基_表示 = e.眼右_眼3_基_表示;
    		眼右_眼3_眼_表示 = e.眼右_眼3_眼_表示;
    		眼右_眼3_ハイライト_表示 = e.眼右_眼3_ハイライト_表示;
    		眼右_眼4_基_表示 = e.眼右_眼4_基_表示;
    		眼右_眼4_眼_表示 = e.眼右_眼4_眼_表示;
    		眼右_眼4_ハイライト_表示 = e.眼右_眼4_ハイライト_表示;
    		眼右_眼5_基_表示 = e.眼右_眼5_基_表示;
    		眼右_眼5_眼_表示 = e.眼右_眼5_眼_表示;
    		眼右_眼5_ハイライト_表示 = e.眼右_眼5_ハイライト_表示;
    		角左_角左1_表示 = e.角左_角左1_表示;
    		角左_角左2_表示 = e.角左_角左2_表示;
    		角右_角右1_表示 = e.角右_角右1_表示;
    		角右_角右2_表示 = e.角右_角右2_表示;
    		base.展開0 = e.展開0;
    		触覚部眼表示 = e.触覚部眼表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Ele f;
    		if (e.触覚左_接続.Count > 0)
    		{
    			触覚左_接続 = e.触覚左_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 顔面_蟲2;
    				f.ConnectionType = ConnectionInfo.顔面_蟲_触覚左_接続;
    				f.接続(顔面_蟲2.触覚左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.触覚右_接続.Count > 0)
    		{
    			触覚右_接続 = e.触覚右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 顔面_蟲2;
    				f.ConnectionType = ConnectionInfo.顔面_蟲_触覚右_接続;
    				f.接続(顔面_蟲2.触覚右_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_面CP = new ColorP(X0Y0_面, 面CD, DisUnit, abj: true);
    		X0Y0_眼左_眼1_基CP = new ColorP(X0Y0_眼左_眼1_基, 眼左_眼1_基CD, DisUnit, abj: true);
    		X0Y0_眼左_眼1_眼CP = new ColorP(X0Y0_眼左_眼1_眼, 眼左_眼1_眼CD, DisUnit, abj: true);
    		X0Y0_眼左_眼1_ハイライトCP = new ColorP(X0Y0_眼左_眼1_ハイライト, 眼左_眼1_ハイライトCD, DisUnit, abj: true);
    		X0Y0_眼左_眼2_基CP = new ColorP(X0Y0_眼左_眼2_基, 眼左_眼2_基CD, DisUnit, abj: true);
    		X0Y0_眼左_眼2_眼CP = new ColorP(X0Y0_眼左_眼2_眼, 眼左_眼2_眼CD, DisUnit, abj: true);
    		X0Y0_眼左_眼2_ハイライトCP = new ColorP(X0Y0_眼左_眼2_ハイライト, 眼左_眼2_ハイライトCD, DisUnit, abj: true);
    		X0Y0_眼左_眼3_基CP = new ColorP(X0Y0_眼左_眼3_基, 眼左_眼3_基CD, DisUnit, abj: true);
    		X0Y0_眼左_眼3_眼CP = new ColorP(X0Y0_眼左_眼3_眼, 眼左_眼3_眼CD, DisUnit, abj: true);
    		X0Y0_眼左_眼3_ハイライトCP = new ColorP(X0Y0_眼左_眼3_ハイライト, 眼左_眼3_ハイライトCD, DisUnit, abj: true);
    		X0Y0_眼左_眼4_基CP = new ColorP(X0Y0_眼左_眼4_基, 眼左_眼4_基CD, DisUnit, abj: true);
    		X0Y0_眼左_眼4_眼CP = new ColorP(X0Y0_眼左_眼4_眼, 眼左_眼4_眼CD, DisUnit, abj: true);
    		X0Y0_眼左_眼4_ハイライトCP = new ColorP(X0Y0_眼左_眼4_ハイライト, 眼左_眼4_ハイライトCD, DisUnit, abj: true);
    		X0Y0_眼左_眼5_基CP = new ColorP(X0Y0_眼左_眼5_基, 眼左_眼5_基CD, DisUnit, abj: true);
    		X0Y0_眼左_眼5_眼CP = new ColorP(X0Y0_眼左_眼5_眼, 眼左_眼5_眼CD, DisUnit, abj: true);
    		X0Y0_眼左_眼5_ハイライトCP = new ColorP(X0Y0_眼左_眼5_ハイライト, 眼左_眼5_ハイライトCD, DisUnit, abj: true);
    		X0Y0_眼右_眼1_基CP = new ColorP(X0Y0_眼右_眼1_基, 眼右_眼1_基CD, DisUnit, abj: true);
    		X0Y0_眼右_眼1_眼CP = new ColorP(X0Y0_眼右_眼1_眼, 眼右_眼1_眼CD, DisUnit, abj: true);
    		X0Y0_眼右_眼1_ハイライトCP = new ColorP(X0Y0_眼右_眼1_ハイライト, 眼右_眼1_ハイライトCD, DisUnit, abj: true);
    		X0Y0_眼右_眼2_基CP = new ColorP(X0Y0_眼右_眼2_基, 眼右_眼2_基CD, DisUnit, abj: true);
    		X0Y0_眼右_眼2_眼CP = new ColorP(X0Y0_眼右_眼2_眼, 眼右_眼2_眼CD, DisUnit, abj: true);
    		X0Y0_眼右_眼2_ハイライトCP = new ColorP(X0Y0_眼右_眼2_ハイライト, 眼右_眼2_ハイライトCD, DisUnit, abj: true);
    		X0Y0_眼右_眼3_基CP = new ColorP(X0Y0_眼右_眼3_基, 眼右_眼3_基CD, DisUnit, abj: true);
    		X0Y0_眼右_眼3_眼CP = new ColorP(X0Y0_眼右_眼3_眼, 眼右_眼3_眼CD, DisUnit, abj: true);
    		X0Y0_眼右_眼3_ハイライトCP = new ColorP(X0Y0_眼右_眼3_ハイライト, 眼右_眼3_ハイライトCD, DisUnit, abj: true);
    		X0Y0_眼右_眼4_基CP = new ColorP(X0Y0_眼右_眼4_基, 眼右_眼4_基CD, DisUnit, abj: true);
    		X0Y0_眼右_眼4_眼CP = new ColorP(X0Y0_眼右_眼4_眼, 眼右_眼4_眼CD, DisUnit, abj: true);
    		X0Y0_眼右_眼4_ハイライトCP = new ColorP(X0Y0_眼右_眼4_ハイライト, 眼右_眼4_ハイライトCD, DisUnit, abj: true);
    		X0Y0_眼右_眼5_基CP = new ColorP(X0Y0_眼右_眼5_基, 眼右_眼5_基CD, DisUnit, abj: true);
    		X0Y0_眼右_眼5_眼CP = new ColorP(X0Y0_眼右_眼5_眼, 眼右_眼5_眼CD, DisUnit, abj: true);
    		X0Y0_眼右_眼5_ハイライトCP = new ColorP(X0Y0_眼右_眼5_ハイライト, 眼右_眼5_ハイライトCD, DisUnit, abj: true);
    		X0Y0_角左_角左1CP = new ColorP(X0Y0_角左_角左1, 角左_角左1CD, DisUnit, abj: true);
    		X0Y0_角左_角左2CP = new ColorP(X0Y0_角左_角左2, 角左_角左2CD, DisUnit, abj: true);
    		X0Y0_角右_角右1CP = new ColorP(X0Y0_角右_角右1, 角右_角右1CD, DisUnit, abj: true);
    		X0Y0_角右_角右2CP = new ColorP(X0Y0_角右_角右2, 角右_角右2CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_面CP.Update();
    		X0Y0_眼左_眼1_基CP.Update();
    		X0Y0_眼左_眼1_眼CP.Update();
    		X0Y0_眼左_眼1_ハイライトCP.Update();
    		X0Y0_眼左_眼2_基CP.Update();
    		X0Y0_眼左_眼2_眼CP.Update();
    		X0Y0_眼左_眼2_ハイライトCP.Update();
    		X0Y0_眼左_眼3_基CP.Update();
    		X0Y0_眼左_眼3_眼CP.Update();
    		X0Y0_眼左_眼3_ハイライトCP.Update();
    		X0Y0_眼左_眼4_基CP.Update();
    		X0Y0_眼左_眼4_眼CP.Update();
    		X0Y0_眼左_眼4_ハイライトCP.Update();
    		X0Y0_眼左_眼5_基CP.Update();
    		X0Y0_眼左_眼5_眼CP.Update();
    		X0Y0_眼左_眼5_ハイライトCP.Update();
    		X0Y0_眼右_眼1_基CP.Update();
    		X0Y0_眼右_眼1_眼CP.Update();
    		X0Y0_眼右_眼1_ハイライトCP.Update();
    		X0Y0_眼右_眼2_基CP.Update();
    		X0Y0_眼右_眼2_眼CP.Update();
    		X0Y0_眼右_眼2_ハイライトCP.Update();
    		X0Y0_眼右_眼3_基CP.Update();
    		X0Y0_眼右_眼3_眼CP.Update();
    		X0Y0_眼右_眼3_ハイライトCP.Update();
    		X0Y0_眼右_眼4_基CP.Update();
    		X0Y0_眼右_眼4_眼CP.Update();
    		X0Y0_眼右_眼4_ハイライトCP.Update();
    		X0Y0_眼右_眼5_基CP.Update();
    		X0Y0_眼右_眼5_眼CP.Update();
    		X0Y0_眼右_眼5_ハイライトCP.Update();
    		X0Y0_角左_角左1CP.Update();
    		X0Y0_角左_角左2CP.Update();
    		X0Y0_角右_角右1CP.Update();
    		X0Y0_角右_角右2CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		面CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		眼左_眼1_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼左_眼1_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼左_眼1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		眼左_眼2_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼左_眼2_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼左_眼2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		眼左_眼3_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼左_眼3_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼左_眼3_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		眼左_眼4_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼左_眼4_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼左_眼4_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		眼左_眼5_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼左_眼5_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼左_眼5_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		眼右_眼1_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼右_眼1_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼右_眼1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		眼右_眼2_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼右_眼2_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼右_眼2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		眼右_眼3_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼右_眼3_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼右_眼3_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		眼右_眼4_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼右_眼4_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼右_眼4_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		眼右_眼5_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼右_眼5_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
    		眼右_眼5_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
    		角左_角左1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		角左_角左2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		角右_角右1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		角右_角右2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    	}
    }
}
