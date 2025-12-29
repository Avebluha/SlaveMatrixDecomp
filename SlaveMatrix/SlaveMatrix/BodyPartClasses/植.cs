using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 植 : Ele
    {
    	public Par X0Y0_披針葉4_通常_葉;

    	public Par X0Y0_披針葉4_通常_葉脈;

    	public Par X0Y0_披針葉4_欠損_葉;

    	public Par X0Y0_披針葉4_欠損_葉脈;

    	public Par X0Y0_心臓葉4_通常_葉;

    	public Par X0Y0_心臓葉4_通常_葉脈;

    	public Par X0Y0_心臓葉4_欠損_葉;

    	public Par X0Y0_心臓葉4_欠損_葉脈;

    	public Par X0Y0_茎;

    	public Par X0Y0_根1;

    	public Par X0Y0_根2;

    	public Par X0Y0_披針葉1_通常_葉;

    	public Par X0Y0_披針葉1_通常_葉脈;

    	public Par X0Y0_披針葉1_欠損_葉;

    	public Par X0Y0_披針葉1_欠損_葉脈;

    	public Par X0Y0_披針葉2_通常_葉;

    	public Par X0Y0_披針葉2_通常_葉脈;

    	public Par X0Y0_披針葉2_欠損_葉;

    	public Par X0Y0_披針葉2_欠損_葉脈;

    	public Par X0Y0_披針葉3_通常_葉;

    	public Par X0Y0_披針葉3_通常_葉脈;

    	public Par X0Y0_披針葉3_欠損_葉;

    	public Par X0Y0_披針葉3_欠損_葉脈;

    	public Par X0Y0_心臓葉1_通常_葉;

    	public Par X0Y0_心臓葉1_通常_葉脈;

    	public Par X0Y0_心臓葉1_欠損_葉;

    	public Par X0Y0_心臓葉1_欠損_葉脈;

    	public Par X0Y0_心臓葉2_通常_葉;

    	public Par X0Y0_心臓葉2_通常_葉脈;

    	public Par X0Y0_心臓葉2_欠損_葉;

    	public Par X0Y0_心臓葉2_欠損_葉脈;

    	public Par X0Y0_心臓葉3_通常_葉;

    	public Par X0Y0_心臓葉3_通常_葉脈;

    	public Par X0Y0_心臓葉3_欠損_葉;

    	public Par X0Y0_心臓葉3_欠損_葉脈;

    	public ColorD 葉4CD;

    	public ColorD 葉脈4CD;

    	public ColorD 茎CD;

    	public ColorD 根1CD;

    	public ColorD 根2CD;

    	public ColorD 葉1CD;

    	public ColorD 葉脈1CD;

    	public ColorD 葉2CD;

    	public ColorD 葉脈2CD;

    	public ColorD 葉3CD;

    	public ColorD 葉脈3CD;

    	public ColorP X0Y0_披針葉4_通常_葉CP;

    	public ColorP X0Y0_披針葉4_通常_葉脈CP;

    	public ColorP X0Y0_披針葉4_欠損_葉CP;

    	public ColorP X0Y0_披針葉4_欠損_葉脈CP;

    	public ColorP X0Y0_心臓葉4_通常_葉CP;

    	public ColorP X0Y0_心臓葉4_通常_葉脈CP;

    	public ColorP X0Y0_心臓葉4_欠損_葉CP;

    	public ColorP X0Y0_心臓葉4_欠損_葉脈CP;

    	public ColorP X0Y0_茎CP;

    	public ColorP X0Y0_根1CP;

    	public ColorP X0Y0_根2CP;

    	public ColorP X0Y0_披針葉1_通常_葉CP;

    	public ColorP X0Y0_披針葉1_通常_葉脈CP;

    	public ColorP X0Y0_披針葉1_欠損_葉CP;

    	public ColorP X0Y0_披針葉1_欠損_葉脈CP;

    	public ColorP X0Y0_披針葉2_通常_葉CP;

    	public ColorP X0Y0_披針葉2_通常_葉脈CP;

    	public ColorP X0Y0_披針葉2_欠損_葉CP;

    	public ColorP X0Y0_披針葉2_欠損_葉脈CP;

    	public ColorP X0Y0_披針葉3_通常_葉CP;

    	public ColorP X0Y0_披針葉3_通常_葉脈CP;

    	public ColorP X0Y0_披針葉3_欠損_葉CP;

    	public ColorP X0Y0_披針葉3_欠損_葉脈CP;

    	public ColorP X0Y0_心臓葉1_通常_葉CP;

    	public ColorP X0Y0_心臓葉1_通常_葉脈CP;

    	public ColorP X0Y0_心臓葉1_欠損_葉CP;

    	public ColorP X0Y0_心臓葉1_欠損_葉脈CP;

    	public ColorP X0Y0_心臓葉2_通常_葉CP;

    	public ColorP X0Y0_心臓葉2_通常_葉脈CP;

    	public ColorP X0Y0_心臓葉2_欠損_葉CP;

    	public ColorP X0Y0_心臓葉2_欠損_葉脈CP;

    	public ColorP X0Y0_心臓葉3_通常_葉CP;

    	public ColorP X0Y0_心臓葉3_通常_葉脈CP;

    	public ColorP X0Y0_心臓葉3_欠損_葉CP;

    	public ColorP X0Y0_心臓葉3_欠損_葉脈CP;

    	public Ele[] 花_接続;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    			披針葉4_葉_表示 = 披針葉4_葉_表示;
    			披針葉4_葉脈_表示 = 披針葉4_葉脈_表示;
    			心臓葉4_葉_表示 = 心臓葉4_葉_表示;
    			心臓葉4_葉脈_表示 = 心臓葉4_葉脈_表示;
    			披針葉1_葉_表示 = 披針葉1_葉_表示;
    			披針葉1_葉脈_表示 = 披針葉1_葉脈_表示;
    			披針葉2_葉_表示 = 披針葉2_葉_表示;
    			披針葉2_葉脈_表示 = 披針葉2_葉脈_表示;
    			披針葉3_葉_表示 = 披針葉3_葉_表示;
    			披針葉3_葉脈_表示 = 披針葉3_葉脈_表示;
    			心臓葉1_葉_表示 = 心臓葉1_葉_表示;
    			心臓葉1_葉脈_表示 = 心臓葉1_葉脈_表示;
    			心臓葉2_葉_表示 = 心臓葉2_葉_表示;
    			心臓葉2_葉脈_表示 = 心臓葉2_葉脈_表示;
    			心臓葉3_葉_表示 = 心臓葉3_葉_表示;
    			心臓葉3_葉脈_表示 = 心臓葉3_葉脈_表示;
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

    	public bool 披針葉4_通常_葉_表示
    	{
    		get
    		{
    			return X0Y0_披針葉4_通常_葉.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉4_通常_葉.Dra = value;
    			X0Y0_披針葉4_通常_葉.Hit = value;
    		}
    	}

    	public bool 披針葉4_通常_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_披針葉4_通常_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉4_通常_葉脈.Dra = value;
    			X0Y0_披針葉4_通常_葉脈.Hit = value;
    		}
    	}

    	public bool 披針葉4_欠損_葉_表示
    	{
    		get
    		{
    			return X0Y0_披針葉4_欠損_葉.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉4_欠損_葉.Dra = value;
    			X0Y0_披針葉4_欠損_葉.Hit = value;
    		}
    	}

    	public bool 披針葉4_欠損_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_披針葉4_欠損_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉4_欠損_葉脈.Dra = value;
    			X0Y0_披針葉4_欠損_葉脈.Hit = value;
    		}
    	}

    	public bool 心臓葉4_通常_葉_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉4_通常_葉.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉4_通常_葉.Dra = value;
    			X0Y0_心臓葉4_通常_葉.Hit = value;
    		}
    	}

    	public bool 心臓葉4_通常_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉4_通常_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉4_通常_葉脈.Dra = value;
    			X0Y0_心臓葉4_通常_葉脈.Hit = value;
    		}
    	}

    	public bool 心臓葉4_欠損_葉_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉4_欠損_葉.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉4_欠損_葉.Dra = value;
    			X0Y0_心臓葉4_欠損_葉.Hit = value;
    		}
    	}

    	public bool 心臓葉4_欠損_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉4_欠損_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉4_欠損_葉脈.Dra = value;
    			X0Y0_心臓葉4_欠損_葉脈.Hit = value;
    		}
    	}

    	public bool 茎_表示
    	{
    		get
    		{
    			return X0Y0_茎.Dra;
    		}
    		set
    		{
    			X0Y0_茎.Dra = value;
    			X0Y0_茎.Hit = value;
    		}
    	}

    	public bool 根1_表示
    	{
    		get
    		{
    			return X0Y0_根1.Dra;
    		}
    		set
    		{
    			X0Y0_根1.Dra = value;
    			X0Y0_根1.Hit = value;
    		}
    	}

    	public bool 根2_表示
    	{
    		get
    		{
    			return X0Y0_根2.Dra;
    		}
    		set
    		{
    			X0Y0_根2.Dra = value;
    			X0Y0_根2.Hit = value;
    		}
    	}

    	public bool 披針葉1_通常_葉_表示
    	{
    		get
    		{
    			return X0Y0_披針葉1_通常_葉.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉1_通常_葉.Dra = value;
    			X0Y0_披針葉1_通常_葉.Hit = value;
    		}
    	}

    	public bool 披針葉1_通常_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_披針葉1_通常_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉1_通常_葉脈.Dra = value;
    			X0Y0_披針葉1_通常_葉脈.Hit = value;
    		}
    	}

    	public bool 披針葉1_欠損_葉_表示
    	{
    		get
    		{
    			return X0Y0_披針葉1_欠損_葉.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉1_欠損_葉.Dra = value;
    			X0Y0_披針葉1_欠損_葉.Hit = value;
    		}
    	}

    	public bool 披針葉1_欠損_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_披針葉1_欠損_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉1_欠損_葉脈.Dra = value;
    			X0Y0_披針葉1_欠損_葉脈.Hit = value;
    		}
    	}

    	public bool 披針葉2_通常_葉_表示
    	{
    		get
    		{
    			return X0Y0_披針葉2_通常_葉.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉2_通常_葉.Dra = value;
    			X0Y0_披針葉2_通常_葉.Hit = value;
    		}
    	}

    	public bool 披針葉2_通常_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_披針葉2_通常_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉2_通常_葉脈.Dra = value;
    			X0Y0_披針葉2_通常_葉脈.Hit = value;
    		}
    	}

    	public bool 披針葉2_欠損_葉_表示
    	{
    		get
    		{
    			return X0Y0_披針葉2_欠損_葉.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉2_欠損_葉.Dra = value;
    			X0Y0_披針葉2_欠損_葉.Hit = value;
    		}
    	}

    	public bool 披針葉2_欠損_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_披針葉2_欠損_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉2_欠損_葉脈.Dra = value;
    			X0Y0_披針葉2_欠損_葉脈.Hit = value;
    		}
    	}

    	public bool 披針葉3_通常_葉_表示
    	{
    		get
    		{
    			return X0Y0_披針葉3_通常_葉.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉3_通常_葉.Dra = value;
    			X0Y0_披針葉3_通常_葉.Hit = value;
    		}
    	}

    	public bool 披針葉3_通常_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_披針葉3_通常_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉3_通常_葉脈.Dra = value;
    			X0Y0_披針葉3_通常_葉脈.Hit = value;
    		}
    	}

    	public bool 披針葉3_欠損_葉_表示
    	{
    		get
    		{
    			return X0Y0_披針葉3_欠損_葉.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉3_欠損_葉.Dra = value;
    			X0Y0_披針葉3_欠損_葉.Hit = value;
    		}
    	}

    	public bool 披針葉3_欠損_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_披針葉3_欠損_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_披針葉3_欠損_葉脈.Dra = value;
    			X0Y0_披針葉3_欠損_葉脈.Hit = value;
    		}
    	}

    	public bool 心臓葉1_通常_葉_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉1_通常_葉.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉1_通常_葉.Dra = value;
    			X0Y0_心臓葉1_通常_葉.Hit = value;
    		}
    	}

    	public bool 心臓葉1_通常_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉1_通常_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉1_通常_葉脈.Dra = value;
    			X0Y0_心臓葉1_通常_葉脈.Hit = value;
    		}
    	}

    	public bool 心臓葉1_欠損_葉_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉1_欠損_葉.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉1_欠損_葉.Dra = value;
    			X0Y0_心臓葉1_欠損_葉.Hit = value;
    		}
    	}

    	public bool 心臓葉1_欠損_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉1_欠損_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉1_欠損_葉脈.Dra = value;
    			X0Y0_心臓葉1_欠損_葉脈.Hit = value;
    		}
    	}

    	public bool 心臓葉2_通常_葉_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉2_通常_葉.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉2_通常_葉.Dra = value;
    			X0Y0_心臓葉2_通常_葉.Hit = value;
    		}
    	}

    	public bool 心臓葉2_通常_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉2_通常_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉2_通常_葉脈.Dra = value;
    			X0Y0_心臓葉2_通常_葉脈.Hit = value;
    		}
    	}

    	public bool 心臓葉2_欠損_葉_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉2_欠損_葉.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉2_欠損_葉.Dra = value;
    			X0Y0_心臓葉2_欠損_葉.Hit = value;
    		}
    	}

    	public bool 心臓葉2_欠損_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉2_欠損_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉2_欠損_葉脈.Dra = value;
    			X0Y0_心臓葉2_欠損_葉脈.Hit = value;
    		}
    	}

    	public bool 心臓葉3_通常_葉_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉3_通常_葉.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉3_通常_葉.Dra = value;
    			X0Y0_心臓葉3_通常_葉.Hit = value;
    		}
    	}

    	public bool 心臓葉3_通常_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉3_通常_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉3_通常_葉脈.Dra = value;
    			X0Y0_心臓葉3_通常_葉脈.Hit = value;
    		}
    	}

    	public bool 心臓葉3_欠損_葉_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉3_欠損_葉.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉3_欠損_葉.Dra = value;
    			X0Y0_心臓葉3_欠損_葉.Hit = value;
    		}
    	}

    	public bool 心臓葉3_欠損_葉脈_表示
    	{
    		get
    		{
    			return X0Y0_心臓葉3_欠損_葉脈.Dra;
    		}
    		set
    		{
    			X0Y0_心臓葉3_欠損_葉脈.Dra = value;
    			X0Y0_心臓葉3_欠損_葉脈.Hit = value;
    		}
    	}

    	public bool 披針葉4_葉_表示
    	{
    		get
    		{
    			if (!披針葉4_通常_葉_表示)
    			{
    				return 披針葉4_欠損_葉_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				披針葉4_通常_葉_表示 = false;
    				披針葉4_欠損_葉_表示 = value;
    			}
    			else
    			{
    				披針葉4_通常_葉_表示 = value;
    				披針葉4_欠損_葉_表示 = false;
    			}
    		}
    	}

    	public bool 披針葉4_葉脈_表示
    	{
    		get
    		{
    			if (!披針葉4_通常_葉脈_表示)
    			{
    				return 披針葉4_欠損_葉脈_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				披針葉4_通常_葉脈_表示 = false;
    				披針葉4_欠損_葉脈_表示 = value;
    			}
    			else
    			{
    				披針葉4_通常_葉脈_表示 = value;
    				披針葉4_欠損_葉脈_表示 = false;
    			}
    		}
    	}

    	public bool 心臓葉4_葉_表示
    	{
    		get
    		{
    			if (!心臓葉4_通常_葉_表示)
    			{
    				return 心臓葉4_欠損_葉_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				心臓葉4_通常_葉_表示 = false;
    				心臓葉4_欠損_葉_表示 = value;
    			}
    			else
    			{
    				心臓葉4_通常_葉_表示 = value;
    				心臓葉4_欠損_葉_表示 = false;
    			}
    		}
    	}

    	public bool 心臓葉4_葉脈_表示
    	{
    		get
    		{
    			if (!心臓葉4_通常_葉脈_表示)
    			{
    				return 心臓葉4_欠損_葉脈_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				心臓葉4_通常_葉脈_表示 = false;
    				心臓葉4_欠損_葉脈_表示 = value;
    			}
    			else
    			{
    				心臓葉4_通常_葉脈_表示 = value;
    				心臓葉4_欠損_葉脈_表示 = false;
    			}
    		}
    	}

    	public bool 披針葉1_葉_表示
    	{
    		get
    		{
    			if (!披針葉1_通常_葉_表示)
    			{
    				return 披針葉1_欠損_葉_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				披針葉1_通常_葉_表示 = false;
    				披針葉1_欠損_葉_表示 = value;
    			}
    			else
    			{
    				披針葉1_通常_葉_表示 = value;
    				披針葉1_欠損_葉_表示 = false;
    			}
    		}
    	}

    	public bool 披針葉1_葉脈_表示
    	{
    		get
    		{
    			if (!披針葉1_通常_葉脈_表示)
    			{
    				return 披針葉1_欠損_葉脈_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				披針葉1_通常_葉脈_表示 = false;
    				披針葉1_欠損_葉脈_表示 = value;
    			}
    			else
    			{
    				披針葉1_通常_葉脈_表示 = value;
    				披針葉1_欠損_葉脈_表示 = false;
    			}
    		}
    	}

    	public bool 披針葉2_葉_表示
    	{
    		get
    		{
    			if (!披針葉2_通常_葉_表示)
    			{
    				return 披針葉2_欠損_葉_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				披針葉2_通常_葉_表示 = false;
    				披針葉2_欠損_葉_表示 = value;
    			}
    			else
    			{
    				披針葉2_通常_葉_表示 = value;
    				披針葉2_欠損_葉_表示 = false;
    			}
    		}
    	}

    	public bool 披針葉2_葉脈_表示
    	{
    		get
    		{
    			if (!披針葉2_通常_葉脈_表示)
    			{
    				return 披針葉2_欠損_葉脈_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				披針葉2_通常_葉脈_表示 = false;
    				披針葉2_欠損_葉脈_表示 = value;
    			}
    			else
    			{
    				披針葉2_通常_葉脈_表示 = value;
    				披針葉2_欠損_葉脈_表示 = false;
    			}
    		}
    	}

    	public bool 披針葉3_葉_表示
    	{
    		get
    		{
    			if (!披針葉3_通常_葉_表示)
    			{
    				return 披針葉3_欠損_葉_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				披針葉3_通常_葉_表示 = false;
    				披針葉3_欠損_葉_表示 = value;
    			}
    			else
    			{
    				披針葉3_通常_葉_表示 = value;
    				披針葉3_欠損_葉_表示 = false;
    			}
    		}
    	}

    	public bool 披針葉3_葉脈_表示
    	{
    		get
    		{
    			if (!披針葉3_通常_葉脈_表示)
    			{
    				return 披針葉3_欠損_葉脈_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				披針葉3_通常_葉脈_表示 = false;
    				披針葉3_欠損_葉脈_表示 = value;
    			}
    			else
    			{
    				披針葉3_通常_葉脈_表示 = value;
    				披針葉3_欠損_葉脈_表示 = false;
    			}
    		}
    	}

    	public bool 心臓葉1_葉_表示
    	{
    		get
    		{
    			if (!心臓葉1_通常_葉_表示)
    			{
    				return 心臓葉1_欠損_葉_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				心臓葉1_通常_葉_表示 = false;
    				心臓葉1_欠損_葉_表示 = value;
    			}
    			else
    			{
    				心臓葉1_通常_葉_表示 = value;
    				心臓葉1_欠損_葉_表示 = false;
    			}
    		}
    	}

    	public bool 心臓葉1_葉脈_表示
    	{
    		get
    		{
    			if (!心臓葉1_通常_葉脈_表示)
    			{
    				return 心臓葉1_欠損_葉脈_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				心臓葉1_通常_葉脈_表示 = false;
    				心臓葉1_欠損_葉脈_表示 = value;
    			}
    			else
    			{
    				心臓葉1_通常_葉脈_表示 = value;
    				心臓葉1_欠損_葉脈_表示 = false;
    			}
    		}
    	}

    	public bool 心臓葉2_葉_表示
    	{
    		get
    		{
    			if (!心臓葉2_通常_葉_表示)
    			{
    				return 心臓葉2_欠損_葉_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				心臓葉2_通常_葉_表示 = false;
    				心臓葉2_欠損_葉_表示 = value;
    			}
    			else
    			{
    				心臓葉2_通常_葉_表示 = value;
    				心臓葉2_欠損_葉_表示 = false;
    			}
    		}
    	}

    	public bool 心臓葉2_葉脈_表示
    	{
    		get
    		{
    			if (!心臓葉2_通常_葉脈_表示)
    			{
    				return 心臓葉2_欠損_葉脈_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				心臓葉2_通常_葉脈_表示 = false;
    				心臓葉2_欠損_葉脈_表示 = value;
    			}
    			else
    			{
    				心臓葉2_通常_葉脈_表示 = value;
    				心臓葉2_欠損_葉脈_表示 = false;
    			}
    		}
    	}

    	public bool 心臓葉3_葉_表示
    	{
    		get
    		{
    			if (!心臓葉3_通常_葉_表示)
    			{
    				return 心臓葉3_欠損_葉_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				心臓葉3_通常_葉_表示 = false;
    				心臓葉3_欠損_葉_表示 = value;
    			}
    			else
    			{
    				心臓葉3_通常_葉_表示 = value;
    				心臓葉3_欠損_葉_表示 = false;
    			}
    		}
    	}

    	public bool 心臓葉3_葉脈_表示
    	{
    		get
    		{
    			if (!心臓葉3_通常_葉脈_表示)
    			{
    				return 心臓葉3_欠損_葉脈_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				心臓葉3_通常_葉脈_表示 = false;
    				心臓葉3_欠損_葉脈_表示 = value;
    			}
    			else
    			{
    				心臓葉3_通常_葉脈_表示 = value;
    				心臓葉3_欠損_葉脈_表示 = false;
    			}
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 披針葉4_通常_葉_表示;
    		}
    		set
    		{
    			披針葉4_通常_葉_表示 = value;
    			披針葉4_通常_葉脈_表示 = value;
    			披針葉4_欠損_葉_表示 = value;
    			披針葉4_欠損_葉脈_表示 = value;
    			心臓葉4_通常_葉_表示 = value;
    			心臓葉4_通常_葉脈_表示 = value;
    			心臓葉4_欠損_葉_表示 = value;
    			心臓葉4_欠損_葉脈_表示 = value;
    			茎_表示 = value;
    			根1_表示 = value;
    			根2_表示 = value;
    			披針葉1_通常_葉_表示 = value;
    			披針葉1_通常_葉脈_表示 = value;
    			披針葉1_欠損_葉_表示 = value;
    			披針葉1_欠損_葉脈_表示 = value;
    			披針葉2_通常_葉_表示 = value;
    			披針葉2_通常_葉脈_表示 = value;
    			披針葉2_欠損_葉_表示 = value;
    			披針葉2_欠損_葉脈_表示 = value;
    			披針葉3_通常_葉_表示 = value;
    			披針葉3_通常_葉脈_表示 = value;
    			披針葉3_欠損_葉_表示 = value;
    			披針葉3_欠損_葉脈_表示 = value;
    			心臓葉1_通常_葉_表示 = value;
    			心臓葉1_通常_葉脈_表示 = value;
    			心臓葉1_欠損_葉_表示 = value;
    			心臓葉1_欠損_葉脈_表示 = value;
    			心臓葉2_通常_葉_表示 = value;
    			心臓葉2_通常_葉脈_表示 = value;
    			心臓葉2_欠損_葉_表示 = value;
    			心臓葉2_欠損_葉脈_表示 = value;
    			心臓葉3_通常_葉_表示 = value;
    			心臓葉3_通常_葉脈_表示 = value;
    			心臓葉3_欠損_葉_表示 = value;
    			心臓葉3_欠損_葉脈_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 葉4CD.不透明度;
    		}
    		set
    		{
    			葉4CD.不透明度 = value;
    			葉脈4CD.不透明度 = value;
    			茎CD.不透明度 = value;
    			根1CD.不透明度 = value;
    			根2CD.不透明度 = value;
    			葉1CD.不透明度 = value;
    			葉脈1CD.不透明度 = value;
    			葉2CD.不透明度 = value;
    			葉脈2CD.不透明度 = value;
    			葉3CD.不透明度 = value;
    			葉脈3CD.不透明度 = value;
    		}
    	}

    	public override double 肥大
    	{
    		set
    		{
    		}
    	}

    	public override double 身長
    	{
    		set
    		{
    		}
    	}

    	public JointS 花_接続点 => new JointS(本体, X0Y0_茎, 6);

    	public 植(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 植D e)
    	{
    		植 植2 = this;
    		ThisType = GetType();
    		Pars pars = new Pars(Sta.肢左["植"][0][0]);
    		pars.Remove("花");
    		pars.Remove("萼");
    		Dif dif = new Dif();
    		dif.Tag = "植";
    		dif.Add(pars);
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars2 = 本体[0][0];
    		Pars pars3 = pars2["通常葉4"].ToPars();
    		Pars pars4 = pars3["通常"].ToPars();
    		X0Y0_披針葉4_通常_葉 = pars4["葉"].ToPar();
    		X0Y0_披針葉4_通常_葉脈 = pars4["葉脈"].ToPar();
    		pars4 = pars3["欠損"].ToPars();
    		X0Y0_披針葉4_欠損_葉 = pars4["葉"].ToPar();
    		X0Y0_披針葉4_欠損_葉脈 = pars4["葉脈"].ToPar();
    		Pars pars5 = pars2["ハート葉4"].ToPars();
    		pars4 = pars5["通常"].ToPars();
    		X0Y0_心臓葉4_通常_葉 = pars4["葉"].ToPar();
    		X0Y0_心臓葉4_通常_葉脈 = pars4["葉脈"].ToPar();
    		pars4 = pars5["欠損"].ToPars();
    		X0Y0_心臓葉4_欠損_葉 = pars4["葉"].ToPar();
    		X0Y0_心臓葉4_欠損_葉脈 = pars4["葉脈"].ToPar();
    		X0Y0_茎 = pars2["茎"].ToPar();
    		X0Y0_根1 = pars2["根1"].ToPar();
    		X0Y0_根2 = pars2["根2"].ToPar();
    		Pars pars6 = pars2["通常葉1"].ToPars();
    		pars4 = pars6["通常"].ToPars();
    		X0Y0_披針葉1_通常_葉 = pars4["葉"].ToPar();
    		X0Y0_披針葉1_通常_葉脈 = pars4["葉脈"].ToPar();
    		pars4 = pars6["欠損"].ToPars();
    		X0Y0_披針葉1_欠損_葉 = pars4["葉"].ToPar();
    		X0Y0_披針葉1_欠損_葉脈 = pars4["葉脈"].ToPar();
    		Pars pars7 = pars2["通常葉2"].ToPars();
    		pars4 = pars7["通常"].ToPars();
    		X0Y0_披針葉2_通常_葉 = pars4["葉"].ToPar();
    		X0Y0_披針葉2_通常_葉脈 = pars4["葉脈"].ToPar();
    		pars4 = pars7["欠損"].ToPars();
    		X0Y0_披針葉2_欠損_葉 = pars4["葉"].ToPar();
    		X0Y0_披針葉2_欠損_葉脈 = pars4["葉脈"].ToPar();
    		Pars pars8 = pars2["通常葉3"].ToPars();
    		pars4 = pars8["通常"].ToPars();
    		X0Y0_披針葉3_通常_葉 = pars4["葉"].ToPar();
    		X0Y0_披針葉3_通常_葉脈 = pars4["葉脈"].ToPar();
    		pars4 = pars8["欠損"].ToPars();
    		X0Y0_披針葉3_欠損_葉 = pars4["葉"].ToPar();
    		X0Y0_披針葉3_欠損_葉脈 = pars4["葉脈"].ToPar();
    		Pars pars9 = pars2["ハート葉1"].ToPars();
    		pars4 = pars9["通常"].ToPars();
    		X0Y0_心臓葉1_通常_葉 = pars4["葉"].ToPar();
    		X0Y0_心臓葉1_通常_葉脈 = pars4["葉脈"].ToPar();
    		pars4 = pars9["欠損"].ToPars();
    		X0Y0_心臓葉1_欠損_葉 = pars4["葉"].ToPar();
    		X0Y0_心臓葉1_欠損_葉脈 = pars4["葉脈"].ToPar();
    		Pars pars10 = pars2["ハート葉2"].ToPars();
    		pars4 = pars10["通常"].ToPars();
    		X0Y0_心臓葉2_通常_葉 = pars4["葉"].ToPar();
    		X0Y0_心臓葉2_通常_葉脈 = pars4["葉脈"].ToPar();
    		pars4 = pars10["欠損"].ToPars();
    		X0Y0_心臓葉2_欠損_葉 = pars4["葉"].ToPar();
    		X0Y0_心臓葉2_欠損_葉脈 = pars4["葉脈"].ToPar();
    		Pars pars11 = pars2["ハート葉3"].ToPars();
    		pars4 = pars11["通常"].ToPars();
    		X0Y0_心臓葉3_通常_葉 = pars4["葉"].ToPar();
    		X0Y0_心臓葉3_通常_葉脈 = pars4["葉脈"].ToPar();
    		pars4 = pars11["欠損"].ToPars();
    		X0Y0_心臓葉3_欠損_葉 = pars4["葉"].ToPar();
    		X0Y0_心臓葉3_欠損_葉脈 = pars4["葉脈"].ToPar();
    		本体.SetJoints();
    		接続根 = new JointD(本体);
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
    		披針葉4_通常_葉_表示 = e.披針葉4_通常_葉_表示;
    		披針葉4_通常_葉脈_表示 = e.披針葉4_通常_葉脈_表示;
    		披針葉4_欠損_葉_表示 = e.披針葉4_欠損_葉_表示;
    		披針葉4_欠損_葉脈_表示 = e.披針葉4_欠損_葉脈_表示;
    		心臓葉4_通常_葉_表示 = e.心臓葉4_通常_葉_表示;
    		心臓葉4_通常_葉脈_表示 = e.心臓葉4_通常_葉脈_表示;
    		心臓葉4_欠損_葉_表示 = e.心臓葉4_欠損_葉_表示;
    		心臓葉4_欠損_葉脈_表示 = e.心臓葉4_欠損_葉脈_表示;
    		茎_表示 = e.茎_表示;
    		根1_表示 = e.根1_表示;
    		根2_表示 = e.根2_表示;
    		披針葉1_通常_葉_表示 = e.披針葉1_通常_葉_表示;
    		披針葉1_通常_葉脈_表示 = e.披針葉1_通常_葉脈_表示;
    		披針葉1_欠損_葉_表示 = e.披針葉1_欠損_葉_表示;
    		披針葉1_欠損_葉脈_表示 = e.披針葉1_欠損_葉脈_表示;
    		披針葉2_通常_葉_表示 = e.披針葉2_通常_葉_表示;
    		披針葉2_通常_葉脈_表示 = e.披針葉2_通常_葉脈_表示;
    		披針葉2_欠損_葉_表示 = e.披針葉2_欠損_葉_表示;
    		披針葉2_欠損_葉脈_表示 = e.披針葉2_欠損_葉脈_表示;
    		披針葉3_通常_葉_表示 = e.披針葉3_通常_葉_表示;
    		披針葉3_通常_葉脈_表示 = e.披針葉3_通常_葉脈_表示;
    		披針葉3_欠損_葉_表示 = e.披針葉3_欠損_葉_表示;
    		披針葉3_欠損_葉脈_表示 = e.披針葉3_欠損_葉脈_表示;
    		心臓葉1_通常_葉_表示 = e.心臓葉1_通常_葉_表示;
    		心臓葉1_通常_葉脈_表示 = e.心臓葉1_通常_葉脈_表示;
    		心臓葉1_欠損_葉_表示 = e.心臓葉1_欠損_葉_表示;
    		心臓葉1_欠損_葉脈_表示 = e.心臓葉1_欠損_葉脈_表示;
    		心臓葉2_通常_葉_表示 = e.心臓葉2_通常_葉_表示;
    		心臓葉2_通常_葉脈_表示 = e.心臓葉2_通常_葉脈_表示;
    		心臓葉2_欠損_葉_表示 = e.心臓葉2_欠損_葉_表示;
    		心臓葉2_欠損_葉脈_表示 = e.心臓葉2_欠損_葉脈_表示;
    		心臓葉3_通常_葉_表示 = e.心臓葉3_通常_葉_表示;
    		心臓葉3_通常_葉脈_表示 = e.心臓葉3_通常_葉脈_表示;
    		心臓葉3_欠損_葉_表示 = e.心臓葉3_欠損_葉_表示;
    		心臓葉3_欠損_葉脈_表示 = e.心臓葉3_欠損_葉脈_表示;
    		披針葉4_葉_表示 = e.披針葉4_葉_表示;
    		披針葉4_葉脈_表示 = e.披針葉4_葉脈_表示;
    		心臓葉4_葉_表示 = e.心臓葉4_葉_表示;
    		心臓葉4_葉脈_表示 = e.心臓葉4_葉脈_表示;
    		披針葉1_葉_表示 = e.披針葉1_葉_表示;
    		披針葉1_葉脈_表示 = e.披針葉1_葉脈_表示;
    		披針葉2_葉_表示 = e.披針葉2_葉_表示;
    		披針葉2_葉脈_表示 = e.披針葉2_葉脈_表示;
    		披針葉3_葉_表示 = e.披針葉3_葉_表示;
    		披針葉3_葉脈_表示 = e.披針葉3_葉脈_表示;
    		心臓葉1_葉_表示 = e.心臓葉1_葉_表示;
    		心臓葉1_葉脈_表示 = e.心臓葉1_葉脈_表示;
    		心臓葉2_葉_表示 = e.心臓葉2_葉_表示;
    		心臓葉2_葉脈_表示 = e.心臓葉2_葉脈_表示;
    		心臓葉3_葉_表示 = e.心臓葉3_葉_表示;
    		心臓葉3_葉脈_表示 = e.心臓葉3_葉脈_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.花_接続.Count > 0)
    		{
    			Ele f;
    			花_接続 = e.花_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 植2;
    				f.ConnectionType = ConnectionInfo.植_花_接続;
    				f.接続(植2.花_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_披針葉4_通常_葉CP = new ColorP(X0Y0_披針葉4_通常_葉, 葉4CD, DisUnit, abj: true);
    		X0Y0_披針葉4_通常_葉脈CP = new ColorP(X0Y0_披針葉4_通常_葉脈, 葉脈4CD, DisUnit, abj: true);
    		X0Y0_披針葉4_欠損_葉CP = new ColorP(X0Y0_披針葉4_欠損_葉, 葉4CD, DisUnit, abj: true);
    		X0Y0_披針葉4_欠損_葉脈CP = new ColorP(X0Y0_披針葉4_欠損_葉脈, 葉脈4CD, DisUnit, abj: true);
    		X0Y0_心臓葉4_通常_葉CP = new ColorP(X0Y0_心臓葉4_通常_葉, 葉4CD, DisUnit, abj: true);
    		X0Y0_心臓葉4_通常_葉脈CP = new ColorP(X0Y0_心臓葉4_通常_葉脈, 葉脈4CD, DisUnit, abj: true);
    		X0Y0_心臓葉4_欠損_葉CP = new ColorP(X0Y0_心臓葉4_欠損_葉, 葉4CD, DisUnit, abj: true);
    		X0Y0_心臓葉4_欠損_葉脈CP = new ColorP(X0Y0_心臓葉4_欠損_葉脈, 葉脈4CD, DisUnit, abj: true);
    		X0Y0_茎CP = new ColorP(X0Y0_茎, 茎CD, DisUnit, abj: true);
    		X0Y0_根1CP = new ColorP(X0Y0_根1, 根1CD, DisUnit, abj: true);
    		X0Y0_根2CP = new ColorP(X0Y0_根2, 根2CD, DisUnit, abj: true);
    		X0Y0_披針葉1_通常_葉CP = new ColorP(X0Y0_披針葉1_通常_葉, 葉1CD, DisUnit, abj: true);
    		X0Y0_披針葉1_通常_葉脈CP = new ColorP(X0Y0_披針葉1_通常_葉脈, 葉脈1CD, DisUnit, abj: true);
    		X0Y0_披針葉1_欠損_葉CP = new ColorP(X0Y0_披針葉1_欠損_葉, 葉1CD, DisUnit, abj: true);
    		X0Y0_披針葉1_欠損_葉脈CP = new ColorP(X0Y0_披針葉1_欠損_葉脈, 葉脈1CD, DisUnit, abj: true);
    		X0Y0_披針葉2_通常_葉CP = new ColorP(X0Y0_披針葉2_通常_葉, 葉2CD, DisUnit, abj: true);
    		X0Y0_披針葉2_通常_葉脈CP = new ColorP(X0Y0_披針葉2_通常_葉脈, 葉脈2CD, DisUnit, abj: true);
    		X0Y0_披針葉2_欠損_葉CP = new ColorP(X0Y0_披針葉2_欠損_葉, 葉2CD, DisUnit, abj: true);
    		X0Y0_披針葉2_欠損_葉脈CP = new ColorP(X0Y0_披針葉2_欠損_葉脈, 葉脈2CD, DisUnit, abj: true);
    		X0Y0_披針葉3_通常_葉CP = new ColorP(X0Y0_披針葉3_通常_葉, 葉3CD, DisUnit, abj: true);
    		X0Y0_披針葉3_通常_葉脈CP = new ColorP(X0Y0_披針葉3_通常_葉脈, 葉脈3CD, DisUnit, abj: true);
    		X0Y0_披針葉3_欠損_葉CP = new ColorP(X0Y0_披針葉3_欠損_葉, 葉3CD, DisUnit, abj: true);
    		X0Y0_披針葉3_欠損_葉脈CP = new ColorP(X0Y0_披針葉3_欠損_葉脈, 葉脈3CD, DisUnit, abj: true);
    		X0Y0_心臓葉1_通常_葉CP = new ColorP(X0Y0_心臓葉1_通常_葉, 葉1CD, DisUnit, abj: true);
    		X0Y0_心臓葉1_通常_葉脈CP = new ColorP(X0Y0_心臓葉1_通常_葉脈, 葉脈1CD, DisUnit, abj: true);
    		X0Y0_心臓葉1_欠損_葉CP = new ColorP(X0Y0_心臓葉1_欠損_葉, 葉1CD, DisUnit, abj: true);
    		X0Y0_心臓葉1_欠損_葉脈CP = new ColorP(X0Y0_心臓葉1_欠損_葉脈, 葉脈1CD, DisUnit, abj: true);
    		X0Y0_心臓葉2_通常_葉CP = new ColorP(X0Y0_心臓葉2_通常_葉, 葉2CD, DisUnit, abj: true);
    		X0Y0_心臓葉2_通常_葉脈CP = new ColorP(X0Y0_心臓葉2_通常_葉脈, 葉脈2CD, DisUnit, abj: true);
    		X0Y0_心臓葉2_欠損_葉CP = new ColorP(X0Y0_心臓葉2_欠損_葉, 葉2CD, DisUnit, abj: true);
    		X0Y0_心臓葉2_欠損_葉脈CP = new ColorP(X0Y0_心臓葉2_欠損_葉脈, 葉脈2CD, DisUnit, abj: true);
    		X0Y0_心臓葉3_通常_葉CP = new ColorP(X0Y0_心臓葉3_通常_葉, 葉3CD, DisUnit, abj: true);
    		X0Y0_心臓葉3_通常_葉脈CP = new ColorP(X0Y0_心臓葉3_通常_葉脈, 葉脈3CD, DisUnit, abj: true);
    		X0Y0_心臓葉3_欠損_葉CP = new ColorP(X0Y0_心臓葉3_欠損_葉, 葉3CD, DisUnit, abj: true);
    		X0Y0_心臓葉3_欠損_葉脈CP = new ColorP(X0Y0_心臓葉3_欠損_葉脈, 葉脈3CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_茎.AngleBase = num * -4.99999999999999;
    		X0Y0_披針葉4_通常_葉脈.AngleBase = num * -52.0000000000001;
    		X0Y0_披針葉4_欠損_葉脈.AngleBase = num * -52.0000000000001;
    		X0Y0_心臓葉4_通常_葉脈.AngleBase = num * -60.9999999999999;
    		X0Y0_心臓葉4_欠損_葉脈.AngleBase = num * -60.9999999999999;
    		X0Y0_根1.AngleBase = num * -49.0;
    		X0Y0_根2.AngleBase = num * -38.0;
    		X0Y0_披針葉1_通常_葉脈.AngleBase = num * -24.0;
    		X0Y0_披針葉1_欠損_葉脈.AngleBase = num * -24.0;
    		X0Y0_披針葉2_通常_葉脈.AngleBase = num * -41.9999999999999;
    		X0Y0_披針葉2_欠損_葉脈.AngleBase = num * -41.9999999999999;
    		X0Y0_披針葉3_通常_葉脈.AngleBase = num * -66.0000000000002;
    		X0Y0_披針葉3_欠損_葉脈.AngleBase = num * -66.0000000000002;
    		X0Y0_心臓葉1_通常_葉脈.AngleBase = num * -23.0;
    		X0Y0_心臓葉1_欠損_葉脈.AngleBase = num * -23.0;
    		X0Y0_心臓葉2_通常_葉脈.AngleBase = num * -41.0;
    		X0Y0_心臓葉2_欠損_葉脈.AngleBase = num * -41.0;
    		X0Y0_心臓葉3_通常_葉脈.AngleBase = num * -64.9999999999998;
    		X0Y0_心臓葉3_欠損_葉脈.AngleBase = num * -64.9999999999998;
    		本体.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		X0Y0_披針葉4_通常_葉CP.Update();
    		X0Y0_披針葉4_通常_葉脈CP.Update();
    		X0Y0_披針葉4_欠損_葉CP.Update();
    		X0Y0_披針葉4_欠損_葉脈CP.Update();
    		X0Y0_心臓葉4_通常_葉CP.Update();
    		X0Y0_心臓葉4_通常_葉脈CP.Update();
    		X0Y0_心臓葉4_欠損_葉CP.Update();
    		X0Y0_心臓葉4_欠損_葉脈CP.Update();
    		X0Y0_茎CP.Update();
    		X0Y0_根1CP.Update();
    		X0Y0_根2CP.Update();
    		X0Y0_披針葉1_通常_葉CP.Update();
    		X0Y0_披針葉1_通常_葉脈CP.Update();
    		X0Y0_披針葉1_欠損_葉CP.Update();
    		X0Y0_披針葉1_欠損_葉脈CP.Update();
    		X0Y0_披針葉2_通常_葉CP.Update();
    		X0Y0_披針葉2_通常_葉脈CP.Update();
    		X0Y0_披針葉2_欠損_葉CP.Update();
    		X0Y0_披針葉2_欠損_葉脈CP.Update();
    		X0Y0_披針葉3_通常_葉CP.Update();
    		X0Y0_披針葉3_通常_葉脈CP.Update();
    		X0Y0_披針葉3_欠損_葉CP.Update();
    		X0Y0_披針葉3_欠損_葉脈CP.Update();
    		X0Y0_心臓葉1_通常_葉CP.Update();
    		X0Y0_心臓葉1_通常_葉脈CP.Update();
    		X0Y0_心臓葉1_欠損_葉CP.Update();
    		X0Y0_心臓葉1_欠損_葉脈CP.Update();
    		X0Y0_心臓葉2_通常_葉CP.Update();
    		X0Y0_心臓葉2_通常_葉脈CP.Update();
    		X0Y0_心臓葉2_欠損_葉CP.Update();
    		X0Y0_心臓葉2_欠損_葉脈CP.Update();
    		X0Y0_心臓葉3_通常_葉CP.Update();
    		X0Y0_心臓葉3_通常_葉脈CP.Update();
    		X0Y0_心臓葉3_欠損_葉CP.Update();
    		X0Y0_心臓葉3_欠損_葉脈CP.Update();
    	}

    	private void 配色(体配色 体配色)
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

    	private void 配色N0(体配色 体配色)
    	{
    		葉4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		葉脈4CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		茎CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		根1CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		根2CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		葉1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		葉脈1CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		葉2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		葉脈2CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		葉3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		葉脈3CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		葉4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		葉脈4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		茎CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		根1CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		根2CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		葉1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		葉脈1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		葉2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		葉脈2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		葉3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		葉脈3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		葉4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		葉脈4CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		茎CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		根1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		根2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		葉1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		葉脈1CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		葉2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		葉脈2CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		葉3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		葉脈3CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    	}
    }
}
