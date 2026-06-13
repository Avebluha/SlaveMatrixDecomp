using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 前髪_横流し : 前髪
    {
    	public Par X0Y0_髪基;

    	public Par X0Y0_髪左1;

    	public Par X0Y0_髪左2;

    	public Par X0Y0_編み左_編節1_髪節;

    	public Par X0Y0_編み左_編節1_髪編目;

    	public Par X0Y0_編み左_編節2_髪節;

    	public Par X0Y0_編み左_編節2_髪編目;

    	public Par X0Y0_編み左_編節3_髪節;

    	public Par X0Y0_編み左_編節3_髪編目;

    	public Par X0Y0_髪ハネ左;

    	public Par X0Y0_髪右1;

    	public Par X0Y0_編み右_編節1_髪節;

    	public Par X0Y0_編み右_編節1_髪編目;

    	public Par X0Y0_編み右_編節2_髪節;

    	public Par X0Y0_編み右_編節2_髪編目;

    	public Par X0Y0_編み右_編節3_髪節;

    	public Par X0Y0_編み右_編節3_髪編目;

    	public Par X0Y0_髪ハネ右;

    	public Par X0Y0_髪右2;

    	public Par X0Y0_髪右3;

    	public Par X0Y0_髪右4;

    	public Par X0Y0_髪右5;

    	public Par X0Y0_髪左3;

    	public Par X0Y0_髪右6;

    	public Par X0Y0_ハイライト;

    	public Par X0Y0_髪頭頂横左1;

    	public Par X0Y0_髪頭頂横左2;

    	public Par X0Y0_髪頭頂横右1;

    	public Par X0Y0_髪頭頂横右2;

    	public ColorD 髪基CD;

    	public ColorD 髪左1CD;

    	public ColorD 髪左2CD;

    	public ColorD 編み左_編節1_髪節CD;

    	public ColorD 編み左_編節1_髪編目CD;

    	public ColorD 編み左_編節2_髪節CD;

    	public ColorD 編み左_編節2_髪編目CD;

    	public ColorD 編み左_編節3_髪節CD;

    	public ColorD 編み左_編節3_髪編目CD;

    	public ColorD 髪ハネ左CD;

    	public ColorD 髪右1CD;

    	public ColorD 編み右_編節1_髪節CD;

    	public ColorD 編み右_編節1_髪編目CD;

    	public ColorD 編み右_編節2_髪節CD;

    	public ColorD 編み右_編節2_髪編目CD;

    	public ColorD 編み右_編節3_髪節CD;

    	public ColorD 編み右_編節3_髪編目CD;

    	public ColorD 髪ハネ右CD;

    	public ColorD 髪右2CD;

    	public ColorD 髪右3CD;

    	public ColorD 髪右4CD;

    	public ColorD 髪右5CD;

    	public ColorD 髪左3CD;

    	public ColorD 髪右6CD;

    	public ColorD ハイライトCD;

    	public ColorD 髪頭頂横左1CD;

    	public ColorD 髪頭頂横左2CD;

    	public ColorD 髪頭頂横右1CD;

    	public ColorD 髪頭頂横右2CD;

    	public ColorP X0Y0_髪基CP;

    	public ColorP X0Y0_髪左1CP;

    	public ColorP X0Y0_髪左2CP;

    	public ColorP X0Y0_編み左_編節1_髪節CP;

    	public ColorP X0Y0_編み左_編節1_髪編目CP;

    	public ColorP X0Y0_編み左_編節2_髪節CP;

    	public ColorP X0Y0_編み左_編節2_髪編目CP;

    	public ColorP X0Y0_編み左_編節3_髪節CP;

    	public ColorP X0Y0_編み左_編節3_髪編目CP;

    	public ColorP X0Y0_髪ハネ左CP;

    	public ColorP X0Y0_髪右1CP;

    	public ColorP X0Y0_編み右_編節1_髪節CP;

    	public ColorP X0Y0_編み右_編節1_髪編目CP;

    	public ColorP X0Y0_編み右_編節2_髪節CP;

    	public ColorP X0Y0_編み右_編節2_髪編目CP;

    	public ColorP X0Y0_編み右_編節3_髪節CP;

    	public ColorP X0Y0_編み右_編節3_髪編目CP;

    	public ColorP X0Y0_髪ハネ右CP;

    	public ColorP X0Y0_髪右2CP;

    	public ColorP X0Y0_髪右3CP;

    	public ColorP X0Y0_髪右4CP;

    	public ColorP X0Y0_髪右5CP;

    	public ColorP X0Y0_髪左3CP;

    	public ColorP X0Y0_髪右6CP;

    	public ColorP X0Y0_ハイライトCP;

    	public ColorP X0Y0_髪頭頂横左1CP;

    	public ColorP X0Y0_髪頭頂横左2CP;

    	public ColorP X0Y0_髪頭頂横右1CP;

    	public ColorP X0Y0_髪頭頂横右2CP;

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

    	public bool 髪基_表示
    	{
    		get
    		{
    			return X0Y0_髪基.Dra;
    		}
    		set
    		{
    			X0Y0_髪基.Dra = value;
    			X0Y0_髪基.Hit = value;
    		}
    	}

    	public bool 髪左1_表示
    	{
    		get
    		{
    			return X0Y0_髪左1.Dra;
    		}
    		set
    		{
    			X0Y0_髪左1.Dra = value;
    			X0Y0_髪左1.Hit = value;
    		}
    	}

    	public bool 髪左2_表示
    	{
    		get
    		{
    			return X0Y0_髪左2.Dra;
    		}
    		set
    		{
    			X0Y0_髪左2.Dra = value;
    			X0Y0_髪左2.Hit = value;
    		}
    	}

    	public bool 編み左_編節1_髪節_表示
    	{
    		get
    		{
    			return X0Y0_編み左_編節1_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_編み左_編節1_髪節.Dra = value;
    			X0Y0_編み左_編節1_髪節.Hit = value;
    		}
    	}

    	public bool 編み左_編節1_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_編み左_編節1_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_編み左_編節1_髪編目.Dra = value;
    			X0Y0_編み左_編節1_髪編目.Hit = value;
    		}
    	}

    	public bool 編み左_編節2_髪節_表示
    	{
    		get
    		{
    			return X0Y0_編み左_編節2_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_編み左_編節2_髪節.Dra = value;
    			X0Y0_編み左_編節2_髪節.Hit = value;
    		}
    	}

    	public bool 編み左_編節2_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_編み左_編節2_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_編み左_編節2_髪編目.Dra = value;
    			X0Y0_編み左_編節2_髪編目.Hit = value;
    		}
    	}

    	public bool 編み左_編節3_髪節_表示
    	{
    		get
    		{
    			return X0Y0_編み左_編節3_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_編み左_編節3_髪節.Dra = value;
    			X0Y0_編み左_編節3_髪節.Hit = value;
    		}
    	}

    	public bool 編み左_編節3_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_編み左_編節3_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_編み左_編節3_髪編目.Dra = value;
    			X0Y0_編み左_編節3_髪編目.Hit = value;
    		}
    	}

    	public bool 髪ハネ左_表示
    	{
    		get
    		{
    			return X0Y0_髪ハネ左.Dra;
    		}
    		set
    		{
    			X0Y0_髪ハネ左.Dra = value;
    			X0Y0_髪ハネ左.Hit = value;
    		}
    	}

    	public bool 髪右1_表示
    	{
    		get
    		{
    			return X0Y0_髪右1.Dra;
    		}
    		set
    		{
    			X0Y0_髪右1.Dra = value;
    			X0Y0_髪右1.Hit = value;
    		}
    	}

    	public bool 編み右_編節1_髪節_表示
    	{
    		get
    		{
    			return X0Y0_編み右_編節1_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_編み右_編節1_髪節.Dra = value;
    			X0Y0_編み右_編節1_髪節.Hit = value;
    		}
    	}

    	public bool 編み右_編節1_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_編み右_編節1_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_編み右_編節1_髪編目.Dra = value;
    			X0Y0_編み右_編節1_髪編目.Hit = value;
    		}
    	}

    	public bool 編み右_編節2_髪節_表示
    	{
    		get
    		{
    			return X0Y0_編み右_編節2_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_編み右_編節2_髪節.Dra = value;
    			X0Y0_編み右_編節2_髪節.Hit = value;
    		}
    	}

    	public bool 編み右_編節2_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_編み右_編節2_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_編み右_編節2_髪編目.Dra = value;
    			X0Y0_編み右_編節2_髪編目.Hit = value;
    		}
    	}

    	public bool 編み右_編節3_髪節_表示
    	{
    		get
    		{
    			return X0Y0_編み右_編節3_髪節.Dra;
    		}
    		set
    		{
    			X0Y0_編み右_編節3_髪節.Dra = value;
    			X0Y0_編み右_編節3_髪節.Hit = value;
    		}
    	}

    	public bool 編み右_編節3_髪編目_表示
    	{
    		get
    		{
    			return X0Y0_編み右_編節3_髪編目.Dra;
    		}
    		set
    		{
    			X0Y0_編み右_編節3_髪編目.Dra = value;
    			X0Y0_編み右_編節3_髪編目.Hit = value;
    		}
    	}

    	public bool 髪ハネ右_表示
    	{
    		get
    		{
    			return X0Y0_髪ハネ右.Dra;
    		}
    		set
    		{
    			X0Y0_髪ハネ右.Dra = value;
    			X0Y0_髪ハネ右.Hit = value;
    		}
    	}

    	public bool 髪右2_表示
    	{
    		get
    		{
    			return X0Y0_髪右2.Dra;
    		}
    		set
    		{
    			X0Y0_髪右2.Dra = value;
    			X0Y0_髪右2.Hit = value;
    		}
    	}

    	public bool 髪右3_表示
    	{
    		get
    		{
    			return X0Y0_髪右3.Dra;
    		}
    		set
    		{
    			X0Y0_髪右3.Dra = value;
    			X0Y0_髪右3.Hit = value;
    		}
    	}

    	public bool 髪右4_表示
    	{
    		get
    		{
    			return X0Y0_髪右4.Dra;
    		}
    		set
    		{
    			X0Y0_髪右4.Dra = value;
    			X0Y0_髪右4.Hit = value;
    		}
    	}

    	public bool 髪右5_表示
    	{
    		get
    		{
    			return X0Y0_髪右5.Dra;
    		}
    		set
    		{
    			X0Y0_髪右5.Dra = value;
    			X0Y0_髪右5.Hit = value;
    		}
    	}

    	public bool 髪左3_表示
    	{
    		get
    		{
    			return X0Y0_髪左3.Dra;
    		}
    		set
    		{
    			X0Y0_髪左3.Dra = value;
    			X0Y0_髪左3.Hit = value;
    		}
    	}

    	public bool 髪右6_表示
    	{
    		get
    		{
    			return X0Y0_髪右6.Dra;
    		}
    		set
    		{
    			X0Y0_髪右6.Dra = value;
    			X0Y0_髪右6.Hit = value;
    		}
    	}

    	public bool ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト.Dra = value;
    			X0Y0_ハイライト.Hit = value;
    		}
    	}

    	public bool 髪頭頂横左1_表示
    	{
    		get
    		{
    			return X0Y0_髪頭頂横左1.Dra;
    		}
    		set
    		{
    			X0Y0_髪頭頂横左1.Dra = value;
    			X0Y0_髪頭頂横左1.Hit = value;
    		}
    	}

    	public bool 髪頭頂横左2_表示
    	{
    		get
    		{
    			return X0Y0_髪頭頂横左2.Dra;
    		}
    		set
    		{
    			X0Y0_髪頭頂横左2.Dra = value;
    			X0Y0_髪頭頂横左2.Hit = value;
    		}
    	}

    	public bool 髪頭頂横右1_表示
    	{
    		get
    		{
    			return X0Y0_髪頭頂横右1.Dra;
    		}
    		set
    		{
    			X0Y0_髪頭頂横右1.Dra = value;
    			X0Y0_髪頭頂横右1.Hit = value;
    		}
    	}

    	public bool 髪頭頂横右2_表示
    	{
    		get
    		{
    			return X0Y0_髪頭頂横右2.Dra;
    		}
    		set
    		{
    			X0Y0_髪頭頂横右2.Dra = value;
    			X0Y0_髪頭頂横右2.Hit = value;
    		}
    	}

    	public bool 編み左表示
    	{
    		get
    		{
    			return 編み左_編節1_髪節_表示;
    		}
    		set
    		{
    			編み左_編節1_髪節_表示 = value;
    			編み左_編節1_髪編目_表示 = value;
    			編み左_編節2_髪節_表示 = value;
    			編み左_編節2_髪編目_表示 = value;
    			編み左_編節3_髪節_表示 = value;
    			編み左_編節3_髪編目_表示 = value;
    		}
    	}

    	public bool 編み右表示
    	{
    		get
    		{
    			return 編み右_編節1_髪節_表示;
    		}
    		set
    		{
    			編み右_編節1_髪節_表示 = value;
    			編み右_編節1_髪編目_表示 = value;
    			編み右_編節2_髪節_表示 = value;
    			編み右_編節2_髪編目_表示 = value;
    			編み右_編節3_髪節_表示 = value;
    			編み右_編節3_髪編目_表示 = value;
    		}
    	}

    	public bool ハイライト表示
    	{
    		get
    		{
    			return ハイライト_表示;
    		}
    		set
    		{
    			ハイライト_表示 = value;
    		}
    	}

    	public double ハイライト濃度
    	{
    		get
    		{
    			return ハイライトCD.不透明度;
    		}
    		set
    		{
    			ハイライトCD.不透明度 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 髪基_表示;
    		}
    		set
    		{
    			髪基_表示 = value;
    			髪左1_表示 = value;
    			髪左2_表示 = value;
    			編み左_編節1_髪節_表示 = value;
    			編み左_編節1_髪編目_表示 = value;
    			編み左_編節2_髪節_表示 = value;
    			編み左_編節2_髪編目_表示 = value;
    			編み左_編節3_髪節_表示 = value;
    			編み左_編節3_髪編目_表示 = value;
    			髪ハネ左_表示 = value;
    			髪右1_表示 = value;
    			編み右_編節1_髪節_表示 = value;
    			編み右_編節1_髪編目_表示 = value;
    			編み右_編節2_髪節_表示 = value;
    			編み右_編節2_髪編目_表示 = value;
    			編み右_編節3_髪節_表示 = value;
    			編み右_編節3_髪編目_表示 = value;
    			髪ハネ右_表示 = value;
    			髪右2_表示 = value;
    			髪右3_表示 = value;
    			髪右4_表示 = value;
    			髪右5_表示 = value;
    			髪左3_表示 = value;
    			髪右6_表示 = value;
    			ハイライト_表示 = value;
    			髪頭頂横左1_表示 = value;
    			髪頭頂横左2_表示 = value;
    			髪頭頂横右1_表示 = value;
    			髪頭頂横右2_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 髪基CD.不透明度;
    		}
    		set
    		{
    			髪基CD.不透明度 = value;
    			髪左1CD.不透明度 = value;
    			髪左2CD.不透明度 = value;
    			編み左_編節1_髪節CD.不透明度 = value;
    			編み左_編節1_髪編目CD.不透明度 = value;
    			編み左_編節2_髪節CD.不透明度 = value;
    			編み左_編節2_髪編目CD.不透明度 = value;
    			編み左_編節3_髪節CD.不透明度 = value;
    			編み左_編節3_髪編目CD.不透明度 = value;
    			髪ハネ左CD.不透明度 = value;
    			髪右1CD.不透明度 = value;
    			編み右_編節1_髪節CD.不透明度 = value;
    			編み右_編節1_髪編目CD.不透明度 = value;
    			編み右_編節2_髪節CD.不透明度 = value;
    			編み右_編節2_髪編目CD.不透明度 = value;
    			編み右_編節3_髪節CD.不透明度 = value;
    			編み右_編節3_髪編目CD.不透明度 = value;
    			髪ハネ右CD.不透明度 = value;
    			髪右2CD.不透明度 = value;
    			髪右3CD.不透明度 = value;
    			髪右4CD.不透明度 = value;
    			髪右5CD.不透明度 = value;
    			髪左3CD.不透明度 = value;
    			髪右6CD.不透明度 = value;
    			ハイライトCD.不透明度 = value;
    			髪頭頂横左1CD.不透明度 = value;
    			髪頭頂横左2CD.不透明度 = value;
    			髪頭頂横右1CD.不透明度 = value;
    			髪頭頂横右2CD.不透明度 = value;
    		}
    	}

    	public double 髪長
    	{
    		set
    		{
    			double num = 0.9 + 0.2 * value;
    			X0Y0_髪基.SetSizeYBase(X0Y0_髪基.GetSizeYBase() * num);
    			X0Y0_髪左1.SetSizeYBase(X0Y0_髪左1.GetSizeYBase() * num);
    			X0Y0_髪左2.SetSizeYBase(X0Y0_髪左2.GetSizeYBase() * num);
    			X0Y0_編み左_編節1_髪節.SetSizeYBase(X0Y0_編み左_編節1_髪節.GetSizeYBase() * num);
    			X0Y0_編み左_編節1_髪編目.SetSizeYBase(X0Y0_編み左_編節1_髪編目.GetSizeYBase() * num);
    			X0Y0_編み左_編節2_髪節.SetSizeYBase(X0Y0_編み左_編節2_髪節.GetSizeYBase() * num);
    			X0Y0_編み左_編節2_髪編目.SetSizeYBase(X0Y0_編み左_編節2_髪編目.GetSizeYBase() * num);
    			X0Y0_編み左_編節3_髪節.SetSizeYBase(X0Y0_編み左_編節3_髪節.GetSizeYBase() * num);
    			X0Y0_編み左_編節3_髪編目.SetSizeYBase(X0Y0_編み左_編節3_髪編目.GetSizeYBase() * num);
    			X0Y0_髪ハネ左.SetSizeYBase(X0Y0_髪ハネ左.GetSizeYBase() * num);
    			X0Y0_髪右1.SetSizeYBase(X0Y0_髪右1.GetSizeYBase() * num);
    			X0Y0_編み右_編節1_髪節.SetSizeYBase(X0Y0_編み右_編節1_髪節.GetSizeYBase() * num);
    			X0Y0_編み右_編節1_髪編目.SetSizeYBase(X0Y0_編み右_編節1_髪編目.GetSizeYBase() * num);
    			X0Y0_編み右_編節2_髪節.SetSizeYBase(X0Y0_編み右_編節2_髪節.GetSizeYBase() * num);
    			X0Y0_編み右_編節2_髪編目.SetSizeYBase(X0Y0_編み右_編節2_髪編目.GetSizeYBase() * num);
    			X0Y0_編み右_編節3_髪節.SetSizeYBase(X0Y0_編み右_編節3_髪節.GetSizeYBase() * num);
    			X0Y0_編み右_編節3_髪編目.SetSizeYBase(X0Y0_編み右_編節3_髪編目.GetSizeYBase() * num);
    			X0Y0_髪ハネ右.SetSizeYBase(X0Y0_髪ハネ右.GetSizeYBase() * num);
    			X0Y0_髪右2.SetSizeYBase(X0Y0_髪右2.GetSizeYBase() * num);
    			X0Y0_髪右3.SetSizeYBase(X0Y0_髪右3.GetSizeYBase() * num);
    			X0Y0_髪右4.SetSizeYBase(X0Y0_髪右4.GetSizeYBase() * num);
    			X0Y0_髪右5.SetSizeYBase(X0Y0_髪右5.GetSizeYBase() * num);
    			X0Y0_髪左3.SetSizeYBase(X0Y0_髪左3.GetSizeYBase() * num);
    			X0Y0_髪右6.SetSizeYBase(X0Y0_髪右6.GetSizeYBase() * num);
    			X0Y0_ハイライト.SetSizeYBase(X0Y0_ハイライト.GetSizeYBase() * num);
    			X0Y0_髪頭頂横左1.SetSizeYBase(X0Y0_髪頭頂横左1.GetSizeYBase() * num);
    			X0Y0_髪頭頂横左2.SetSizeYBase(X0Y0_髪頭頂横左2.GetSizeYBase() * num);
    			X0Y0_髪頭頂横右1.SetSizeYBase(X0Y0_髪頭頂横右1.GetSizeYBase() * num);
    			X0Y0_髪頭頂横右2.SetSizeYBase(X0Y0_髪頭頂横右2.GetSizeYBase() * num);
    		}
    	}

    	public 前髪_横流し(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 前髪_横流しD e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "横流し";
    		dif.Add(new Pars(Sta.胴体["前髪"][0][5]));
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		Pars pars = Body[0][0];
    		X0Y0_髪基 = pars["髪基"].ToPar();
    		X0Y0_髪左1 = pars["髪左1"].ToPar();
    		X0Y0_髪左2 = pars["髪左2"].ToPar();
    		Pars pars2 = pars["編み左"].ToPars();
    		Pars pars3 = pars2["編節1"].ToPars();
    		X0Y0_編み左_編節1_髪節 = pars3["髪節"].ToPar();
    		X0Y0_編み左_編節1_髪編目 = pars3["髪編目"].ToPar();
    		pars3 = pars2["編節2"].ToPars();
    		X0Y0_編み左_編節2_髪節 = pars3["髪節"].ToPar();
    		X0Y0_編み左_編節2_髪編目 = pars3["髪編目"].ToPar();
    		pars3 = pars2["編節3"].ToPars();
    		X0Y0_編み左_編節3_髪節 = pars3["髪節"].ToPar();
    		X0Y0_編み左_編節3_髪編目 = pars3["髪編目"].ToPar();
    		X0Y0_髪ハネ左 = pars["髪ハネ左"].ToPar();
    		X0Y0_髪右1 = pars["髪右1"].ToPar();
    		Pars pars4 = pars["編み右"].ToPars();
    		pars3 = pars4["編節1"].ToPars();
    		X0Y0_編み右_編節1_髪節 = pars3["髪節"].ToPar();
    		X0Y0_編み右_編節1_髪編目 = pars3["髪編目"].ToPar();
    		pars3 = pars4["編節2"].ToPars();
    		X0Y0_編み右_編節2_髪節 = pars3["髪節"].ToPar();
    		X0Y0_編み右_編節2_髪編目 = pars3["髪編目"].ToPar();
    		pars3 = pars4["編節3"].ToPars();
    		X0Y0_編み右_編節3_髪節 = pars3["髪節"].ToPar();
    		X0Y0_編み右_編節3_髪編目 = pars3["髪編目"].ToPar();
    		X0Y0_髪ハネ右 = pars["髪ハネ右"].ToPar();
    		X0Y0_髪右2 = pars["髪右2"].ToPar();
    		X0Y0_髪右3 = pars["髪右3"].ToPar();
    		X0Y0_髪右4 = pars["髪右4"].ToPar();
    		X0Y0_髪右5 = pars["髪右5"].ToPar();
    		X0Y0_髪左3 = pars["髪左3"].ToPar();
    		X0Y0_髪右6 = pars["髪右6"].ToPar();
    		X0Y0_ハイライト = pars["ハイライト"].ToPar();
    		X0Y0_髪頭頂横左1 = pars["髪頭頂横左1"].ToPar();
    		X0Y0_髪頭頂横左2 = pars["髪頭頂横左2"].ToPar();
    		X0Y0_髪頭頂横右1 = pars["髪頭頂横右1"].ToPar();
    		X0Y0_髪頭頂横右2 = pars["髪頭頂横右2"].ToPar();
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
    		髪基_表示 = e.髪基_表示;
    		髪左1_表示 = e.髪左1_表示;
    		髪左2_表示 = e.髪左2_表示;
    		編み左_編節1_髪節_表示 = e.編み左_編節1_髪節_表示;
    		編み左_編節1_髪編目_表示 = e.編み左_編節1_髪編目_表示;
    		編み左_編節2_髪節_表示 = e.編み左_編節2_髪節_表示;
    		編み左_編節2_髪編目_表示 = e.編み左_編節2_髪編目_表示;
    		編み左_編節3_髪節_表示 = e.編み左_編節3_髪節_表示;
    		編み左_編節3_髪編目_表示 = e.編み左_編節3_髪編目_表示;
    		髪ハネ左_表示 = e.髪ハネ左_表示;
    		髪右1_表示 = e.髪右1_表示;
    		編み右_編節1_髪節_表示 = e.編み右_編節1_髪節_表示;
    		編み右_編節1_髪編目_表示 = e.編み右_編節1_髪編目_表示;
    		編み右_編節2_髪節_表示 = e.編み右_編節2_髪節_表示;
    		編み右_編節2_髪編目_表示 = e.編み右_編節2_髪編目_表示;
    		編み右_編節3_髪節_表示 = e.編み右_編節3_髪節_表示;
    		編み右_編節3_髪編目_表示 = e.編み右_編節3_髪編目_表示;
    		髪ハネ右_表示 = e.髪ハネ右_表示;
    		髪右2_表示 = e.髪右2_表示;
    		髪右3_表示 = e.髪右3_表示;
    		髪右4_表示 = e.髪右4_表示;
    		髪右5_表示 = e.髪右5_表示;
    		髪左3_表示 = e.髪左3_表示;
    		髪右6_表示 = e.髪右6_表示;
    		ハイライト_表示 = e.ハイライト_表示;
    		髪頭頂横左1_表示 = e.髪頭頂横左1_表示;
    		髪頭頂横左2_表示 = e.髪頭頂横左2_表示;
    		髪頭頂横右1_表示 = e.髪頭頂横右1_表示;
    		髪頭頂横右2_表示 = e.髪頭頂横右2_表示;
    		編み左表示 = e.編み左表示;
    		編み右表示 = e.編み右表示;
    		ハイライト表示 = e.ハイライト表示;
    		髪長 = e.髪長;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_髪基CP = new ColorP(X0Y0_髪基, 髪基CD, DisUnit, abj: false);
    		X0Y0_髪左1CP = new ColorP(X0Y0_髪左1, 髪左1CD, DisUnit, abj: false);
    		X0Y0_髪左2CP = new ColorP(X0Y0_髪左2, 髪左2CD, DisUnit, abj: false);
    		X0Y0_編み左_編節1_髪節CP = new ColorP(X0Y0_編み左_編節1_髪節, 編み左_編節1_髪節CD, DisUnit, abj: false);
    		X0Y0_編み左_編節1_髪編目CP = new ColorP(X0Y0_編み左_編節1_髪編目, 編み左_編節1_髪編目CD, DisUnit, abj: false);
    		X0Y0_編み左_編節2_髪節CP = new ColorP(X0Y0_編み左_編節2_髪節, 編み左_編節2_髪節CD, DisUnit, abj: false);
    		X0Y0_編み左_編節2_髪編目CP = new ColorP(X0Y0_編み左_編節2_髪編目, 編み左_編節2_髪編目CD, DisUnit, abj: false);
    		X0Y0_編み左_編節3_髪節CP = new ColorP(X0Y0_編み左_編節3_髪節, 編み左_編節3_髪節CD, DisUnit, abj: false);
    		X0Y0_編み左_編節3_髪編目CP = new ColorP(X0Y0_編み左_編節3_髪編目, 編み左_編節3_髪編目CD, DisUnit, abj: false);
    		X0Y0_髪ハネ左CP = new ColorP(X0Y0_髪ハネ左, 髪ハネ左CD, DisUnit, abj: false);
    		X0Y0_髪右1CP = new ColorP(X0Y0_髪右1, 髪右1CD, DisUnit, abj: false);
    		X0Y0_編み右_編節1_髪節CP = new ColorP(X0Y0_編み右_編節1_髪節, 編み右_編節1_髪節CD, DisUnit, abj: false);
    		X0Y0_編み右_編節1_髪編目CP = new ColorP(X0Y0_編み右_編節1_髪編目, 編み右_編節1_髪編目CD, DisUnit, abj: false);
    		X0Y0_編み右_編節2_髪節CP = new ColorP(X0Y0_編み右_編節2_髪節, 編み右_編節2_髪節CD, DisUnit, abj: false);
    		X0Y0_編み右_編節2_髪編目CP = new ColorP(X0Y0_編み右_編節2_髪編目, 編み右_編節2_髪編目CD, DisUnit, abj: false);
    		X0Y0_編み右_編節3_髪節CP = new ColorP(X0Y0_編み右_編節3_髪節, 編み右_編節3_髪節CD, DisUnit, abj: false);
    		X0Y0_編み右_編節3_髪編目CP = new ColorP(X0Y0_編み右_編節3_髪編目, 編み右_編節3_髪編目CD, DisUnit, abj: false);
    		X0Y0_髪ハネ右CP = new ColorP(X0Y0_髪ハネ右, 髪ハネ右CD, DisUnit, abj: false);
    		X0Y0_髪右2CP = new ColorP(X0Y0_髪右2, 髪右2CD, DisUnit, abj: false);
    		X0Y0_髪右3CP = new ColorP(X0Y0_髪右3, 髪右3CD, DisUnit, abj: false);
    		X0Y0_髪右4CP = new ColorP(X0Y0_髪右4, 髪右4CD, DisUnit, abj: false);
    		X0Y0_髪右5CP = new ColorP(X0Y0_髪右5, 髪右5CD, DisUnit, abj: false);
    		X0Y0_髪左3CP = new ColorP(X0Y0_髪左3, 髪左3CD, DisUnit, abj: false);
    		X0Y0_髪右6CP = new ColorP(X0Y0_髪右6, 髪右6CD, DisUnit, abj: false);
    		X0Y0_ハイライトCP = new ColorP(X0Y0_ハイライト, ハイライトCD, DisUnit, abj: false);
    		X0Y0_髪頭頂横左1CP = new ColorP(X0Y0_髪頭頂横左1, 髪頭頂横左1CD, DisUnit, abj: false);
    		X0Y0_髪頭頂横左2CP = new ColorP(X0Y0_髪頭頂横左2, 髪頭頂横左2CD, DisUnit, abj: false);
    		X0Y0_髪頭頂横右1CP = new ColorP(X0Y0_髪頭頂横右1, 髪頭頂横右1CD, DisUnit, abj: false);
    		X0Y0_髪頭頂横右2CP = new ColorP(X0Y0_髪頭頂横右2, 髪頭頂横右2CD, DisUnit, abj: false);
    		ハイライト濃度 = e.ハイライト濃度;
    		Intensity = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_髪基CP.Update();
    		X0Y0_髪左1CP.Update();
    		X0Y0_髪左2CP.Update();
    		X0Y0_編み左_編節1_髪節CP.Update();
    		X0Y0_編み左_編節1_髪編目CP.Update();
    		X0Y0_編み左_編節2_髪節CP.Update();
    		X0Y0_編み左_編節2_髪編目CP.Update();
    		X0Y0_編み左_編節3_髪節CP.Update();
    		X0Y0_編み左_編節3_髪編目CP.Update();
    		X0Y0_髪ハネ左CP.Update();
    		X0Y0_髪右1CP.Update();
    		X0Y0_編み右_編節1_髪節CP.Update();
    		X0Y0_編み右_編節1_髪編目CP.Update();
    		X0Y0_編み右_編節2_髪節CP.Update();
    		X0Y0_編み右_編節2_髪編目CP.Update();
    		X0Y0_編み右_編節3_髪節CP.Update();
    		X0Y0_編み右_編節3_髪編目CP.Update();
    		X0Y0_髪ハネ右CP.Update();
    		X0Y0_髪右2CP.Update();
    		X0Y0_髪右3CP.Update();
    		X0Y0_髪右4CP.Update();
    		X0Y0_髪右5CP.Update();
    		X0Y0_髪左3CP.Update();
    		X0Y0_髪右6CP.Update();
    		X0Y0_ハイライトCP.Update();
    		X0Y0_髪頭頂横左1CP.Update();
    		X0Y0_髪頭頂横左2CP.Update();
    		X0Y0_髪頭頂横右1CP.Update();
    		X0Y0_髪頭頂横右2CP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		髪基CD = new ColorD(ref Col.Empty, ref Color2.Empty);
    		髪左1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪左2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編み左_編節1_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編み左_編節1_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編み左_編節2_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編み左_編節2_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編み左_編節3_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編み左_編節3_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪ハネ左CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪右1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編み右_編節1_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編み右_編節1_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編み右_編節2_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編み右_編節2_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編み右_編節3_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		編み右_編節3_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪ハネ右CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪右2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪右3CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪右4CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪右5CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪左3CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪右6CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		髪頭頂横左1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪頭頂横左2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪頭頂横右1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    		髪頭頂横右2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
    	}
    }
}
