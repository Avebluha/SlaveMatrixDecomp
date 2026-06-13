using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class LowerArm_鳥 : 翼LowerArm
    {
    	public ShapePart X0Y0_鳥翼LowerArm;

    	public ShapePart X0Y0_風切羽_羽15;

    	public ShapePart X0Y0_風切羽_羽14;

    	public ShapePart X0Y0_風切羽_羽13;

    	public ShapePart X0Y0_風切羽_羽12;

    	public ShapePart X0Y0_風切羽_羽11;

    	public ShapePart X0Y0_風切羽_羽10;

    	public ShapePart X0Y0_風切羽_羽9;

    	public ShapePart X0Y0_風切羽_羽8;

    	public ShapePart X0Y0_風切羽_羽7;

    	public ShapePart X0Y0_風切羽_羽6;

    	public ShapePart X0Y0_風切羽_羽5;

    	public ShapePart X0Y0_風切羽_羽4;

    	public ShapePart X0Y0_風切羽_羽3;

    	public ShapePart X0Y0_風切羽_羽2;

    	public ShapePart X0Y0_風切羽_羽1;

    	public ShapePart X0Y0_雨覆羽_羽14;

    	public ShapePart X0Y0_雨覆羽_羽13;

    	public ShapePart X0Y0_雨覆羽_羽12;

    	public ShapePart X0Y0_雨覆羽_羽11;

    	public ShapePart X0Y0_雨覆羽_羽10;

    	public ShapePart X0Y0_雨覆羽_羽9;

    	public ShapePart X0Y0_雨覆羽_羽8;

    	public ShapePart X0Y0_雨覆羽_羽7;

    	public ShapePart X0Y0_雨覆羽_羽6;

    	public ShapePart X0Y0_雨覆羽_羽5;

    	public ShapePart X0Y0_雨覆羽_羽4;

    	public ShapePart X0Y0_雨覆羽_羽3;

    	public ShapePart X0Y0_雨覆羽_羽2;

    	public ShapePart X0Y0_雨覆羽_羽1;

    	public ShapePart X0Y0_中雨覆羽_羽13;

    	public ShapePart X0Y0_中雨覆羽_羽12;

    	public ShapePart X0Y0_中雨覆羽_羽11;

    	public ShapePart X0Y0_中雨覆羽_羽10;

    	public ShapePart X0Y0_中雨覆羽_羽9;

    	public ShapePart X0Y0_中雨覆羽_羽8;

    	public ShapePart X0Y0_中雨覆羽_羽7;

    	public ShapePart X0Y0_中雨覆羽_羽6;

    	public ShapePart X0Y0_中雨覆羽_羽5;

    	public ShapePart X0Y0_中雨覆羽_羽4;

    	public ShapePart X0Y0_中雨覆羽_羽3;

    	public ShapePart X0Y0_中雨覆羽_羽2;

    	public ShapePart X0Y0_中雨覆羽_羽1;

    	public ShapePart X0Y0_小雨覆_小雨覆;

    	public ShapePart X0Y0_小雨覆_竜性_鱗1;

    	public ShapePart X0Y0_小雨覆_竜性_鱗2;

    	public ShapePart X0Y0_小雨覆_竜性_鱗3;

    	public ShapePart X0Y0_小雨覆_竜性_鱗4;

    	public ShapePart X0Y0_小雨覆_竜性_鱗5;

    	public ShapePart X0Y0_小雨覆_竜性_鱗6;

    	public ShapePart X0Y0_小雨覆_竜性_鱗7;

    	public ShapePart X0Y0_小雨覆_竜性_鱗8;

    	public ShapePart X0Y0_小雨覆_竜性_鱗9;

    	public ShapePart X0Y0_腕輪_革;

    	public ShapePart X0Y0_腕輪_金具1;

    	public ShapePart X0Y0_腕輪_金具2;

    	public ShapePart X0Y0_腕輪_金具3;

    	public ShapePart X0Y0_腕輪_金具左;

    	public ShapePart X0Y0_腕輪_金具右;

    	public ColorD 鳥翼LowerArmCD;

    	public ColorD 風切羽_羽15CD;

    	public ColorD 風切羽_羽14CD;

    	public ColorD 風切羽_羽13CD;

    	public ColorD 風切羽_羽12CD;

    	public ColorD 風切羽_羽11CD;

    	public ColorD 風切羽_羽10CD;

    	public ColorD 風切羽_羽9CD;

    	public ColorD 風切羽_羽8CD;

    	public ColorD 風切羽_羽7CD;

    	public ColorD 風切羽_羽6CD;

    	public ColorD 風切羽_羽5CD;

    	public ColorD 風切羽_羽4CD;

    	public ColorD 風切羽_羽3CD;

    	public ColorD 風切羽_羽2CD;

    	public ColorD 風切羽_羽1CD;

    	public ColorD 雨覆羽_羽14CD;

    	public ColorD 雨覆羽_羽13CD;

    	public ColorD 雨覆羽_羽12CD;

    	public ColorD 雨覆羽_羽11CD;

    	public ColorD 雨覆羽_羽10CD;

    	public ColorD 雨覆羽_羽9CD;

    	public ColorD 雨覆羽_羽8CD;

    	public ColorD 雨覆羽_羽7CD;

    	public ColorD 雨覆羽_羽6CD;

    	public ColorD 雨覆羽_羽5CD;

    	public ColorD 雨覆羽_羽4CD;

    	public ColorD 雨覆羽_羽3CD;

    	public ColorD 雨覆羽_羽2CD;

    	public ColorD 雨覆羽_羽1CD;

    	public ColorD 中雨覆羽_羽13CD;

    	public ColorD 中雨覆羽_羽12CD;

    	public ColorD 中雨覆羽_羽11CD;

    	public ColorD 中雨覆羽_羽10CD;

    	public ColorD 中雨覆羽_羽9CD;

    	public ColorD 中雨覆羽_羽8CD;

    	public ColorD 中雨覆羽_羽7CD;

    	public ColorD 中雨覆羽_羽6CD;

    	public ColorD 中雨覆羽_羽5CD;

    	public ColorD 中雨覆羽_羽4CD;

    	public ColorD 中雨覆羽_羽3CD;

    	public ColorD 中雨覆羽_羽2CD;

    	public ColorD 中雨覆羽_羽1CD;

    	public ColorD 小雨覆_小雨覆CD;

    	public ColorD 小雨覆_竜性_鱗1CD;

    	public ColorD 小雨覆_竜性_鱗2CD;

    	public ColorD 小雨覆_竜性_鱗3CD;

    	public ColorD 小雨覆_竜性_鱗4CD;

    	public ColorD 小雨覆_竜性_鱗5CD;

    	public ColorD 小雨覆_竜性_鱗6CD;

    	public ColorD 小雨覆_竜性_鱗7CD;

    	public ColorD 小雨覆_竜性_鱗8CD;

    	public ColorD 小雨覆_竜性_鱗9CD;

    	public ColorD 腕輪_革CD;

    	public ColorD 腕輪_金具1CD;

    	public ColorD 腕輪_金具2CD;

    	public ColorD 腕輪_金具3CD;

    	public ColorD 腕輪_金具左CD;

    	public ColorD 腕輪_金具右CD;

    	public ColorP X0Y0_鳥翼LowerArmCP;

    	public ColorP X0Y0_風切羽_羽15CP;

    	public ColorP X0Y0_風切羽_羽14CP;

    	public ColorP X0Y0_風切羽_羽13CP;

    	public ColorP X0Y0_風切羽_羽12CP;

    	public ColorP X0Y0_風切羽_羽11CP;

    	public ColorP X0Y0_風切羽_羽10CP;

    	public ColorP X0Y0_風切羽_羽9CP;

    	public ColorP X0Y0_風切羽_羽8CP;

    	public ColorP X0Y0_風切羽_羽7CP;

    	public ColorP X0Y0_風切羽_羽6CP;

    	public ColorP X0Y0_風切羽_羽5CP;

    	public ColorP X0Y0_風切羽_羽4CP;

    	public ColorP X0Y0_風切羽_羽3CP;

    	public ColorP X0Y0_風切羽_羽2CP;

    	public ColorP X0Y0_風切羽_羽1CP;

    	public ColorP X0Y0_雨覆羽_羽14CP;

    	public ColorP X0Y0_雨覆羽_羽13CP;

    	public ColorP X0Y0_雨覆羽_羽12CP;

    	public ColorP X0Y0_雨覆羽_羽11CP;

    	public ColorP X0Y0_雨覆羽_羽10CP;

    	public ColorP X0Y0_雨覆羽_羽9CP;

    	public ColorP X0Y0_雨覆羽_羽8CP;

    	public ColorP X0Y0_雨覆羽_羽7CP;

    	public ColorP X0Y0_雨覆羽_羽6CP;

    	public ColorP X0Y0_雨覆羽_羽5CP;

    	public ColorP X0Y0_雨覆羽_羽4CP;

    	public ColorP X0Y0_雨覆羽_羽3CP;

    	public ColorP X0Y0_雨覆羽_羽2CP;

    	public ColorP X0Y0_雨覆羽_羽1CP;

    	public ColorP X0Y0_中雨覆羽_羽13CP;

    	public ColorP X0Y0_中雨覆羽_羽12CP;

    	public ColorP X0Y0_中雨覆羽_羽11CP;

    	public ColorP X0Y0_中雨覆羽_羽10CP;

    	public ColorP X0Y0_中雨覆羽_羽9CP;

    	public ColorP X0Y0_中雨覆羽_羽8CP;

    	public ColorP X0Y0_中雨覆羽_羽7CP;

    	public ColorP X0Y0_中雨覆羽_羽6CP;

    	public ColorP X0Y0_中雨覆羽_羽5CP;

    	public ColorP X0Y0_中雨覆羽_羽4CP;

    	public ColorP X0Y0_中雨覆羽_羽3CP;

    	public ColorP X0Y0_中雨覆羽_羽2CP;

    	public ColorP X0Y0_中雨覆羽_羽1CP;

    	public ColorP X0Y0_小雨覆_小雨覆CP;

    	public ColorP X0Y0_小雨覆_竜性_鱗1CP;

    	public ColorP X0Y0_小雨覆_竜性_鱗2CP;

    	public ColorP X0Y0_小雨覆_竜性_鱗3CP;

    	public ColorP X0Y0_小雨覆_竜性_鱗4CP;

    	public ColorP X0Y0_小雨覆_竜性_鱗5CP;

    	public ColorP X0Y0_小雨覆_竜性_鱗6CP;

    	public ColorP X0Y0_小雨覆_竜性_鱗7CP;

    	public ColorP X0Y0_小雨覆_竜性_鱗8CP;

    	public ColorP X0Y0_小雨覆_竜性_鱗9CP;

    	public ColorP X0Y0_腕輪_革CP;

    	public ColorP X0Y0_腕輪_金具1CP;

    	public ColorP X0Y0_腕輪_金具2CP;

    	public ColorP X0Y0_腕輪_金具3CP;

    	public ColorP X0Y0_腕輪_金具左CP;

    	public ColorP X0Y0_腕輪_金具右CP;

    	public 拘束鎖 鎖1;

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
    			腕輪表示 = 拘束_;
    		}
    	}

    	public bool 鳥翼LowerArm_表示
    	{
    		get
    		{
    			return X0Y0_鳥翼LowerArm.Dra;
    		}
    		set
    		{
    			X0Y0_鳥翼LowerArm.Dra = value;
    			X0Y0_鳥翼LowerArm.Hit = value;
    		}
    	}

    	public bool 風切羽_羽15_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽15.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽15.Dra = value;
    			X0Y0_風切羽_羽15.Hit = value;
    		}
    	}

    	public bool 風切羽_羽14_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽14.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽14.Dra = value;
    			X0Y0_風切羽_羽14.Hit = value;
    		}
    	}

    	public bool 風切羽_羽13_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽13.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽13.Dra = value;
    			X0Y0_風切羽_羽13.Hit = value;
    		}
    	}

    	public bool 風切羽_羽12_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽12.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽12.Dra = value;
    			X0Y0_風切羽_羽12.Hit = value;
    		}
    	}

    	public bool 風切羽_羽11_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽11.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽11.Dra = value;
    			X0Y0_風切羽_羽11.Hit = value;
    		}
    	}

    	public bool 風切羽_羽10_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽10.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽10.Dra = value;
    			X0Y0_風切羽_羽10.Hit = value;
    		}
    	}

    	public bool 風切羽_羽9_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽9.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽9.Dra = value;
    			X0Y0_風切羽_羽9.Hit = value;
    		}
    	}

    	public bool 風切羽_羽8_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽8.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽8.Dra = value;
    			X0Y0_風切羽_羽8.Hit = value;
    		}
    	}

    	public bool 風切羽_羽7_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽7.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽7.Dra = value;
    			X0Y0_風切羽_羽7.Hit = value;
    		}
    	}

    	public bool 風切羽_羽6_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽6.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽6.Dra = value;
    			X0Y0_風切羽_羽6.Hit = value;
    		}
    	}

    	public bool 風切羽_羽5_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽5.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽5.Dra = value;
    			X0Y0_風切羽_羽5.Hit = value;
    		}
    	}

    	public bool 風切羽_羽4_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽4.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽4.Dra = value;
    			X0Y0_風切羽_羽4.Hit = value;
    		}
    	}

    	public bool 風切羽_羽3_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽3.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽3.Dra = value;
    			X0Y0_風切羽_羽3.Hit = value;
    		}
    	}

    	public bool 風切羽_羽2_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽2.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽2.Dra = value;
    			X0Y0_風切羽_羽2.Hit = value;
    		}
    	}

    	public bool 風切羽_羽1_表示
    	{
    		get
    		{
    			return X0Y0_風切羽_羽1.Dra;
    		}
    		set
    		{
    			X0Y0_風切羽_羽1.Dra = value;
    			X0Y0_風切羽_羽1.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽14_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽14.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽14.Dra = value;
    			X0Y0_雨覆羽_羽14.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽13_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽13.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽13.Dra = value;
    			X0Y0_雨覆羽_羽13.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽12_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽12.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽12.Dra = value;
    			X0Y0_雨覆羽_羽12.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽11_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽11.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽11.Dra = value;
    			X0Y0_雨覆羽_羽11.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽10_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽10.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽10.Dra = value;
    			X0Y0_雨覆羽_羽10.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽9_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽9.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽9.Dra = value;
    			X0Y0_雨覆羽_羽9.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽8_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽8.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽8.Dra = value;
    			X0Y0_雨覆羽_羽8.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽7_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽7.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽7.Dra = value;
    			X0Y0_雨覆羽_羽7.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽6_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽6.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽6.Dra = value;
    			X0Y0_雨覆羽_羽6.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽5_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽5.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽5.Dra = value;
    			X0Y0_雨覆羽_羽5.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽4_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽4.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽4.Dra = value;
    			X0Y0_雨覆羽_羽4.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽3_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽3.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽3.Dra = value;
    			X0Y0_雨覆羽_羽3.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽2_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽2.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽2.Dra = value;
    			X0Y0_雨覆羽_羽2.Hit = value;
    		}
    	}

    	public bool 雨覆羽_羽1_表示
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽1.Dra;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽1.Dra = value;
    			X0Y0_雨覆羽_羽1.Hit = value;
    		}
    	}

    	public bool 中雨覆羽_羽13_表示
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽13.Dra;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽13.Dra = value;
    			X0Y0_中雨覆羽_羽13.Hit = value;
    		}
    	}

    	public bool 中雨覆羽_羽12_表示
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽12.Dra;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽12.Dra = value;
    			X0Y0_中雨覆羽_羽12.Hit = value;
    		}
    	}

    	public bool 中雨覆羽_羽11_表示
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽11.Dra;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽11.Dra = value;
    			X0Y0_中雨覆羽_羽11.Hit = value;
    		}
    	}

    	public bool 中雨覆羽_羽10_表示
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽10.Dra;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽10.Dra = value;
    			X0Y0_中雨覆羽_羽10.Hit = value;
    		}
    	}

    	public bool 中雨覆羽_羽9_表示
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽9.Dra;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽9.Dra = value;
    			X0Y0_中雨覆羽_羽9.Hit = value;
    		}
    	}

    	public bool 中雨覆羽_羽8_表示
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽8.Dra;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽8.Dra = value;
    			X0Y0_中雨覆羽_羽8.Hit = value;
    		}
    	}

    	public bool 中雨覆羽_羽7_表示
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽7.Dra;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽7.Dra = value;
    			X0Y0_中雨覆羽_羽7.Hit = value;
    		}
    	}

    	public bool 中雨覆羽_羽6_表示
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽6.Dra;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽6.Dra = value;
    			X0Y0_中雨覆羽_羽6.Hit = value;
    		}
    	}

    	public bool 中雨覆羽_羽5_表示
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽5.Dra;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽5.Dra = value;
    			X0Y0_中雨覆羽_羽5.Hit = value;
    		}
    	}

    	public bool 中雨覆羽_羽4_表示
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽4.Dra;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽4.Dra = value;
    			X0Y0_中雨覆羽_羽4.Hit = value;
    		}
    	}

    	public bool 中雨覆羽_羽3_表示
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽3.Dra;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽3.Dra = value;
    			X0Y0_中雨覆羽_羽3.Hit = value;
    		}
    	}

    	public bool 中雨覆羽_羽2_表示
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽2.Dra;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽2.Dra = value;
    			X0Y0_中雨覆羽_羽2.Hit = value;
    		}
    	}

    	public bool 中雨覆羽_羽1_表示
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽1.Dra;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽1.Dra = value;
    			X0Y0_中雨覆羽_羽1.Hit = value;
    		}
    	}

    	public bool 小雨覆_小雨覆_表示
    	{
    		get
    		{
    			return X0Y0_小雨覆_小雨覆.Dra;
    		}
    		set
    		{
    			X0Y0_小雨覆_小雨覆.Dra = value;
    			X0Y0_小雨覆_小雨覆.Hit = value;
    		}
    	}

    	public bool 小雨覆_竜性_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_小雨覆_竜性_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_小雨覆_竜性_鱗1.Dra = false;
    			X0Y0_小雨覆_竜性_鱗1.Hit = false;
    		}
    	}

    	public bool 小雨覆_竜性_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_小雨覆_竜性_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_小雨覆_竜性_鱗2.Dra = false;
    			X0Y0_小雨覆_竜性_鱗2.Hit = false;
    		}
    	}

    	public bool 小雨覆_竜性_鱗3_表示
    	{
    		get
    		{
    			return X0Y0_小雨覆_竜性_鱗3.Dra;
    		}
    		set
    		{
    			X0Y0_小雨覆_竜性_鱗3.Dra = value;
    			X0Y0_小雨覆_竜性_鱗3.Hit = value;
    		}
    	}

    	public bool 小雨覆_竜性_鱗4_表示
    	{
    		get
    		{
    			return X0Y0_小雨覆_竜性_鱗4.Dra;
    		}
    		set
    		{
    			X0Y0_小雨覆_竜性_鱗4.Dra = value;
    			X0Y0_小雨覆_竜性_鱗4.Hit = value;
    		}
    	}

    	public bool 小雨覆_竜性_鱗5_表示
    	{
    		get
    		{
    			return X0Y0_小雨覆_竜性_鱗5.Dra;
    		}
    		set
    		{
    			X0Y0_小雨覆_竜性_鱗5.Dra = value;
    			X0Y0_小雨覆_竜性_鱗5.Hit = value;
    		}
    	}

    	public bool 小雨覆_竜性_鱗6_表示
    	{
    		get
    		{
    			return X0Y0_小雨覆_竜性_鱗6.Dra;
    		}
    		set
    		{
    			X0Y0_小雨覆_竜性_鱗6.Dra = value;
    			X0Y0_小雨覆_竜性_鱗6.Hit = value;
    		}
    	}

    	public bool 小雨覆_竜性_鱗7_表示
    	{
    		get
    		{
    			return X0Y0_小雨覆_竜性_鱗7.Dra;
    		}
    		set
    		{
    			X0Y0_小雨覆_竜性_鱗7.Dra = value;
    			X0Y0_小雨覆_竜性_鱗7.Hit = value;
    		}
    	}

    	public bool 小雨覆_竜性_鱗8_表示
    	{
    		get
    		{
    			return X0Y0_小雨覆_竜性_鱗8.Dra;
    		}
    		set
    		{
    			X0Y0_小雨覆_竜性_鱗8.Dra = value;
    			X0Y0_小雨覆_竜性_鱗8.Hit = value;
    		}
    	}

    	public bool 小雨覆_竜性_鱗9_表示
    	{
    		get
    		{
    			return X0Y0_小雨覆_竜性_鱗9.Dra;
    		}
    		set
    		{
    			X0Y0_小雨覆_竜性_鱗9.Dra = value;
    			X0Y0_小雨覆_竜性_鱗9.Hit = value;
    		}
    	}

    	public bool 腕輪_革_表示
    	{
    		get
    		{
    			return X0Y0_腕輪_革.Dra;
    		}
    		set
    		{
    			X0Y0_腕輪_革.Dra = value;
    			X0Y0_腕輪_革.Hit = value;
    		}
    	}

    	public bool 腕輪_金具1_表示
    	{
    		get
    		{
    			return X0Y0_腕輪_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_腕輪_金具1.Dra = value;
    			X0Y0_腕輪_金具1.Hit = value;
    		}
    	}

    	public bool 腕輪_金具2_表示
    	{
    		get
    		{
    			return X0Y0_腕輪_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_腕輪_金具2.Dra = value;
    			X0Y0_腕輪_金具2.Hit = value;
    		}
    	}

    	public bool 腕輪_金具3_表示
    	{
    		get
    		{
    			return X0Y0_腕輪_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_腕輪_金具3.Dra = value;
    			X0Y0_腕輪_金具3.Hit = value;
    		}
    	}

    	public bool 腕輪_金具左_表示
    	{
    		get
    		{
    			return X0Y0_腕輪_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_腕輪_金具左.Dra = value;
    			X0Y0_腕輪_金具左.Hit = value;
    		}
    	}

    	public bool 腕輪_金具右_表示
    	{
    		get
    		{
    			return X0Y0_腕輪_金具右.Dra;
    		}
    		set
    		{
    			value = false;
    			X0Y0_腕輪_金具右.Dra = value;
    			X0Y0_腕輪_金具右.Hit = value;
    		}
    	}

    	public bool 腕輪表示
    	{
    		get
    		{
    			return 腕輪_革_表示;
    		}
    		set
    		{
    			腕輪_革_表示 = value;
    			腕輪_金具1_表示 = value;
    			腕輪_金具2_表示 = value;
    			腕輪_金具3_表示 = value;
    			腕輪_金具左_表示 = value;
    			腕輪_金具右_表示 = value;
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
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 鳥翼LowerArm_表示;
    		}
    		set
    		{
    			鳥翼LowerArm_表示 = value;
    			風切羽_羽15_表示 = value;
    			風切羽_羽14_表示 = value;
    			風切羽_羽13_表示 = value;
    			風切羽_羽12_表示 = value;
    			風切羽_羽11_表示 = value;
    			風切羽_羽10_表示 = value;
    			風切羽_羽9_表示 = value;
    			風切羽_羽8_表示 = value;
    			風切羽_羽7_表示 = value;
    			風切羽_羽6_表示 = value;
    			風切羽_羽5_表示 = value;
    			風切羽_羽4_表示 = value;
    			風切羽_羽3_表示 = value;
    			風切羽_羽2_表示 = value;
    			風切羽_羽1_表示 = value;
    			雨覆羽_羽14_表示 = value;
    			雨覆羽_羽13_表示 = value;
    			雨覆羽_羽12_表示 = value;
    			雨覆羽_羽11_表示 = value;
    			雨覆羽_羽10_表示 = value;
    			雨覆羽_羽9_表示 = value;
    			雨覆羽_羽8_表示 = value;
    			雨覆羽_羽7_表示 = value;
    			雨覆羽_羽6_表示 = value;
    			雨覆羽_羽5_表示 = value;
    			雨覆羽_羽4_表示 = value;
    			雨覆羽_羽3_表示 = value;
    			雨覆羽_羽2_表示 = value;
    			雨覆羽_羽1_表示 = value;
    			中雨覆羽_羽13_表示 = value;
    			中雨覆羽_羽12_表示 = value;
    			中雨覆羽_羽11_表示 = value;
    			中雨覆羽_羽10_表示 = value;
    			中雨覆羽_羽9_表示 = value;
    			中雨覆羽_羽8_表示 = value;
    			中雨覆羽_羽7_表示 = value;
    			中雨覆羽_羽6_表示 = value;
    			中雨覆羽_羽5_表示 = value;
    			中雨覆羽_羽4_表示 = value;
    			中雨覆羽_羽3_表示 = value;
    			中雨覆羽_羽2_表示 = value;
    			中雨覆羽_羽1_表示 = value;
    			小雨覆_小雨覆_表示 = value;
    			小雨覆_竜性_鱗1_表示 = value;
    			小雨覆_竜性_鱗2_表示 = value;
    			小雨覆_竜性_鱗3_表示 = value;
    			小雨覆_竜性_鱗4_表示 = value;
    			小雨覆_竜性_鱗5_表示 = value;
    			小雨覆_竜性_鱗6_表示 = value;
    			小雨覆_竜性_鱗7_表示 = value;
    			小雨覆_竜性_鱗8_表示 = value;
    			小雨覆_竜性_鱗9_表示 = value;
    			腕輪_革_表示 = value;
    			腕輪_金具1_表示 = value;
    			腕輪_金具2_表示 = value;
    			腕輪_金具3_表示 = value;
    			腕輪_金具左_表示 = value;
    			腕輪_金具右_表示 = value;
    			鎖1.表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 鳥翼LowerArmCD.不透明度;
    		}
    		set
    		{
    			鳥翼LowerArmCD.不透明度 = value;
    			風切羽_羽15CD.不透明度 = value;
    			風切羽_羽14CD.不透明度 = value;
    			風切羽_羽13CD.不透明度 = value;
    			風切羽_羽12CD.不透明度 = value;
    			風切羽_羽11CD.不透明度 = value;
    			風切羽_羽10CD.不透明度 = value;
    			風切羽_羽9CD.不透明度 = value;
    			風切羽_羽8CD.不透明度 = value;
    			風切羽_羽7CD.不透明度 = value;
    			風切羽_羽6CD.不透明度 = value;
    			風切羽_羽5CD.不透明度 = value;
    			風切羽_羽4CD.不透明度 = value;
    			風切羽_羽3CD.不透明度 = value;
    			風切羽_羽2CD.不透明度 = value;
    			風切羽_羽1CD.不透明度 = value;
    			雨覆羽_羽14CD.不透明度 = value;
    			雨覆羽_羽13CD.不透明度 = value;
    			雨覆羽_羽12CD.不透明度 = value;
    			雨覆羽_羽11CD.不透明度 = value;
    			雨覆羽_羽10CD.不透明度 = value;
    			雨覆羽_羽9CD.不透明度 = value;
    			雨覆羽_羽8CD.不透明度 = value;
    			雨覆羽_羽7CD.不透明度 = value;
    			雨覆羽_羽6CD.不透明度 = value;
    			雨覆羽_羽5CD.不透明度 = value;
    			雨覆羽_羽4CD.不透明度 = value;
    			雨覆羽_羽3CD.不透明度 = value;
    			雨覆羽_羽2CD.不透明度 = value;
    			雨覆羽_羽1CD.不透明度 = value;
    			中雨覆羽_羽13CD.不透明度 = value;
    			中雨覆羽_羽12CD.不透明度 = value;
    			中雨覆羽_羽11CD.不透明度 = value;
    			中雨覆羽_羽10CD.不透明度 = value;
    			中雨覆羽_羽9CD.不透明度 = value;
    			中雨覆羽_羽8CD.不透明度 = value;
    			中雨覆羽_羽7CD.不透明度 = value;
    			中雨覆羽_羽6CD.不透明度 = value;
    			中雨覆羽_羽5CD.不透明度 = value;
    			中雨覆羽_羽4CD.不透明度 = value;
    			中雨覆羽_羽3CD.不透明度 = value;
    			中雨覆羽_羽2CD.不透明度 = value;
    			中雨覆羽_羽1CD.不透明度 = value;
    			小雨覆_小雨覆CD.不透明度 = value;
    			小雨覆_竜性_鱗1CD.不透明度 = value;
    			小雨覆_竜性_鱗2CD.不透明度 = value;
    			小雨覆_竜性_鱗3CD.不透明度 = value;
    			小雨覆_竜性_鱗4CD.不透明度 = value;
    			小雨覆_竜性_鱗5CD.不透明度 = value;
    			小雨覆_竜性_鱗6CD.不透明度 = value;
    			小雨覆_竜性_鱗7CD.不透明度 = value;
    			小雨覆_竜性_鱗8CD.不透明度 = value;
    			小雨覆_竜性_鱗9CD.不透明度 = value;
    			腕輪_革CD.不透明度 = value;
    			腕輪_金具1CD.不透明度 = value;
    			腕輪_金具2CD.不透明度 = value;
    			腕輪_金具3CD.不透明度 = value;
    			腕輪_金具左CD.不透明度 = value;
    			腕輪_金具右CD.不透明度 = value;
    		}
    	}

    	public override double 展開
    	{
    		set
    		{
    			double num = value.Inverse();
    			double num2 = (右 ? (-1.0) : 1.0);
    			X0Y0_鳥翼LowerArm.AngleCont = num2 * 120.0 * num;
    			X0Y0_風切羽_羽1.AngleCont = num2 * -95.0 * num;
    			X0Y0_風切羽_羽2.AngleCont = num2 * -92.6666666666667 * num;
    			X0Y0_風切羽_羽3.AngleCont = num2 * -90.3333333333333 * num;
    			X0Y0_風切羽_羽4.AngleCont = num2 * -88.0 * num;
    			X0Y0_風切羽_羽5.AngleCont = num2 * -85.6666666666667 * num;
    			X0Y0_風切羽_羽6.AngleCont = num2 * -83.3333333333334 * num;
    			X0Y0_風切羽_羽7.AngleCont = num2 * -81.0 * num;
    			X0Y0_風切羽_羽8.AngleCont = num2 * -78.6666666666667 * num;
    			X0Y0_風切羽_羽9.AngleCont = num2 * -76.3333333333334 * num;
    			X0Y0_風切羽_羽10.AngleCont = num2 * -74.0 * num;
    			X0Y0_風切羽_羽11.AngleCont = num2 * -71.6666666666667 * num;
    			X0Y0_風切羽_羽12.AngleCont = num2 * -69.3333333333334 * num;
    			X0Y0_風切羽_羽13.AngleCont = num2 * -67.0000000000001 * num;
    			X0Y0_風切羽_羽14.AngleCont = num2 * -64.6666666666667 * num;
    			X0Y0_風切羽_羽15.AngleCont = num2 * -62.3333333333334 * num;
    			X0Y0_雨覆羽_羽1.AngleCont = num2 * -100.0 * num;
    			X0Y0_雨覆羽_羽2.AngleCont = num2 * -97.1428571428571 * num;
    			X0Y0_雨覆羽_羽3.AngleCont = num2 * -94.2857142857143 * num;
    			X0Y0_雨覆羽_羽4.AngleCont = num2 * -91.4285714285714 * num;
    			X0Y0_雨覆羽_羽5.AngleCont = num2 * -88.5714285714286 * num;
    			X0Y0_雨覆羽_羽6.AngleCont = num2 * -85.7142857142857 * num;
    			X0Y0_雨覆羽_羽7.AngleCont = num2 * -82.8571428571428 * num;
    			X0Y0_雨覆羽_羽8.AngleCont = num2 * -80.0 * num;
    			X0Y0_雨覆羽_羽9.AngleCont = num2 * -77.1428571428571 * num;
    			X0Y0_雨覆羽_羽10.AngleCont = num2 * -74.2857142857142 * num;
    			X0Y0_雨覆羽_羽11.AngleCont = num2 * -71.4285714285714 * num;
    			X0Y0_雨覆羽_羽12.AngleCont = num2 * -68.5714285714285 * num;
    			X0Y0_雨覆羽_羽13.AngleCont = num2 * -65.7142857142857 * num;
    			X0Y0_雨覆羽_羽14.AngleCont = num2 * -62.8571428571428 * num;
    			X0Y0_中雨覆羽_羽1.AngleCont = num2 * -110.0 * num;
    			X0Y0_中雨覆羽_羽2.AngleCont = num2 * -103.076923076923 * num;
    			X0Y0_中雨覆羽_羽3.AngleCont = num2 * -96.1538461538462 * num;
    			X0Y0_中雨覆羽_羽4.AngleCont = num2 * -89.2307692307692 * num;
    			X0Y0_中雨覆羽_羽5.AngleCont = num2 * -82.3076923076923 * num;
    			X0Y0_中雨覆羽_羽6.AngleCont = num2 * -75.3846153846154 * num;
    			X0Y0_中雨覆羽_羽7.AngleCont = num2 * -68.4615384615385 * num;
    			X0Y0_中雨覆羽_羽8.AngleCont = num2 * -61.5384615384616 * num;
    			X0Y0_中雨覆羽_羽9.AngleCont = num2 * -54.6153846153846 * num;
    			X0Y0_中雨覆羽_羽10.AngleCont = num2 * -47.6923076923077 * num;
    			X0Y0_中雨覆羽_羽11.AngleCont = num2 * -40.7692307692308 * num;
    			X0Y0_中雨覆羽_羽12.AngleCont = num2 * -33.8461538461539 * num;
    			X0Y0_中雨覆羽_羽13.AngleCont = num2 * -26.923076923077 * num;
    		}
    	}

    	public double シャープ
    	{
    		set
    		{
    			double num = 0.05;
    			X0Y0_風切羽_羽15.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽14.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽13.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽12.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽11.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽10.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽9.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽8.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽7.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽6.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽5.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽4.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽3.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽2.SizeYBase *= 1.0 - num * value;
    			X0Y0_風切羽_羽1.SizeYBase *= 1.0 - num * value;
    		}
    	}

    	public bool LowerArm_外線
    	{
    		get
    		{
    			return X0Y0_鳥翼LowerArm.OP[(!右) ? 1 : 2].Outline;
    		}
    		set
    		{
    			X0Y0_鳥翼LowerArm.OP[(!右) ? 1 : 2].Outline = value;
    			X0Y0_鳥翼LowerArm.OP[右 ? 1 : 2].Outline = value;
    			X0Y0_鳥翼LowerArm.OP[(!右) ? 3 : 0].Outline = value;
    		}
    	}

    	public bool 小雨覆_外線
    	{
    		get
    		{
    			return X0Y0_小雨覆_小雨覆.OP[右 ? 11 : 2].Outline;
    		}
    		set
    		{
    			X0Y0_小雨覆_小雨覆.OP[右 ? 11 : 2].Outline = value;
    			X0Y0_小雨覆_小雨覆.OP[右 ? 6 : 7].Outline = value;
    			X0Y0_小雨覆_小雨覆.OP[右 ? 4 : 9].Outline = value;
    			X0Y0_小雨覆_小雨覆.OP[右 ? 2 : 11].Outline = value;
    		}
    	}

    	public bool 中雨覆羽_羽1_外線
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽1.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽1.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_中雨覆羽_羽1.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽1.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽1.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 中雨覆羽_羽2_外線
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽2.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽2.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_中雨覆羽_羽2.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽2.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽2.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 中雨覆羽_羽3_外線
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽3.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽3.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_中雨覆羽_羽3.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽3.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽3.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 中雨覆羽_羽4_外線
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽4.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽4.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_中雨覆羽_羽4.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽4.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽4.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 中雨覆羽_羽5_外線
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽5.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽5.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_中雨覆羽_羽5.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽5.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽5.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 中雨覆羽_羽6_外線
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽6.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽6.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_中雨覆羽_羽6.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽6.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽6.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 中雨覆羽_羽7_外線
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽7.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽7.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_中雨覆羽_羽7.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽7.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽7.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 中雨覆羽_羽8_外線
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽8.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽8.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_中雨覆羽_羽8.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽8.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽8.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 中雨覆羽_羽9_外線
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽9.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽9.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_中雨覆羽_羽9.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽9.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽9.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 中雨覆羽_羽10_外線
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽10.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽10.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_中雨覆羽_羽10.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽10.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽10.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 中雨覆羽_羽11_外線
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽11.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽11.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_中雨覆羽_羽11.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽11.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽11.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 中雨覆羽_羽12_外線
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽12.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽12.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_中雨覆羽_羽12.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽12.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽12.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 中雨覆羽_羽13_外線
    	{
    		get
    		{
    			return X0Y0_中雨覆羽_羽13.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_中雨覆羽_羽13.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_中雨覆羽_羽13.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽13.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_中雨覆羽_羽13.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽1_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽1.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽1.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽1.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽1.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽1.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽2_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽2.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽2.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽2.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽2.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽2.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽3_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽3.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽3.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽3.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽3.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽3.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽4_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽4.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽4.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽4.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽4.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽4.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽5_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽5.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽5.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽5.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽5.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽5.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽6_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽6.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽6.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽6.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽6.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽6.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽7_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽7.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽7.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽7.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽7.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽7.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽8_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽8.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽8.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽8.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽8.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽8.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽9_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽9.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽9.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽9.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽9.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽9.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽10_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽10.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽10.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽10.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽10.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽10.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽11_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽11.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽11.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽11.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽11.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽11.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽12_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽12.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽12.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽12.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽12.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽12.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽13_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽13.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽13.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽13.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽13.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽13.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 雨覆羽_羽14_外線
    	{
    		get
    		{
    			return X0Y0_雨覆羽_羽14.OP[右 ? 4 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_雨覆羽_羽14.OP[右 ? 4 : 0].Outline = value;
    			X0Y0_雨覆羽_羽14.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽14.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_雨覆羽_羽14.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽1_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽1.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽1.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽1.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽1.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽2_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽2.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽2.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽2.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽2.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽3_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽3.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽3.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽3.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽3.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽4_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽4.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽4.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽4.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽4.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽5_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽5.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽5.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽5.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽5.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽6_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽6.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽6.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽6.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽6.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽7_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽7.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽7.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽7.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽7.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽8_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽8.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽8.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽8.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽8.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽9_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽9.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽9.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽9.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽9.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽10_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽10.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽10.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽10.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽10.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽11_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽11.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽11.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽11.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽11.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽12_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽12.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽12.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽12.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽12.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽13_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽13.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽13.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽13.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽13.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽14_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽14.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽14.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽14.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽14.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public bool 風切羽_羽15_外線
    	{
    		get
    		{
    			return X0Y0_風切羽_羽15.OP[(!右) ? 1 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_風切羽_羽15.OP[(!右) ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽15.OP[右 ? 1 : 3].Outline = value;
    			X0Y0_風切羽_羽15.OP[(!右) ? 4 : 0].Outline = value;
    		}
    	}

    	public override bool 肘部_外線
    	{
    		get
    		{
    			return X0Y0_鳥翼LowerArm.OP[右 ? 3 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_鳥翼LowerArm.OP[右 ? 3 : 0].Outline = value;
    		}
    	}

    	public JointS 手_接続点 => new JointS(Body, X0Y0_鳥翼LowerArm, 15);

    	public JointS 小雨覆_接続点 => new JointS(Body, X0Y0_鳥翼LowerArm, 29);

    	public JointS 鎖1_接続点 => new JointS(Body, X0Y0_腕輪_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(Body, X0Y0_腕輪_金具右, 0);

    	public LowerArm_鳥(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, LowerArm_鳥D e)
    	{
    		LowerArm_鳥 LowerArm_鳥2 = this;
    		ThisType = GetType();
    		Body = new VariantGrid(Sta.腕左["鳥翼LowerArm"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_鳥翼LowerArm = partGroup["鳥翼下腕"].ToPar();
    		PartGroup pars2 = partGroup["風切羽"].ToPars();
    		X0Y0_風切羽_羽15 = pars2["羽15"].ToPar();
    		X0Y0_風切羽_羽14 = pars2["羽14"].ToPar();
    		X0Y0_風切羽_羽13 = pars2["羽13"].ToPar();
    		X0Y0_風切羽_羽12 = pars2["羽12"].ToPar();
    		X0Y0_風切羽_羽11 = pars2["羽11"].ToPar();
    		X0Y0_風切羽_羽10 = pars2["羽10"].ToPar();
    		X0Y0_風切羽_羽9 = pars2["羽9"].ToPar();
    		X0Y0_風切羽_羽8 = pars2["羽8"].ToPar();
    		X0Y0_風切羽_羽7 = pars2["羽7"].ToPar();
    		X0Y0_風切羽_羽6 = pars2["羽6"].ToPar();
    		X0Y0_風切羽_羽5 = pars2["羽5"].ToPar();
    		X0Y0_風切羽_羽4 = pars2["羽4"].ToPar();
    		X0Y0_風切羽_羽3 = pars2["羽3"].ToPar();
    		X0Y0_風切羽_羽2 = pars2["羽2"].ToPar();
    		X0Y0_風切羽_羽1 = pars2["羽1"].ToPar();
    		pars2 = partGroup["雨覆羽"].ToPars();
    		X0Y0_雨覆羽_羽14 = pars2["羽14"].ToPar();
    		X0Y0_雨覆羽_羽13 = pars2["羽13"].ToPar();
    		X0Y0_雨覆羽_羽12 = pars2["羽12"].ToPar();
    		X0Y0_雨覆羽_羽11 = pars2["羽11"].ToPar();
    		X0Y0_雨覆羽_羽10 = pars2["羽10"].ToPar();
    		X0Y0_雨覆羽_羽9 = pars2["羽9"].ToPar();
    		X0Y0_雨覆羽_羽8 = pars2["羽8"].ToPar();
    		X0Y0_雨覆羽_羽7 = pars2["羽7"].ToPar();
    		X0Y0_雨覆羽_羽6 = pars2["羽6"].ToPar();
    		X0Y0_雨覆羽_羽5 = pars2["羽5"].ToPar();
    		X0Y0_雨覆羽_羽4 = pars2["羽4"].ToPar();
    		X0Y0_雨覆羽_羽3 = pars2["羽3"].ToPar();
    		X0Y0_雨覆羽_羽2 = pars2["羽2"].ToPar();
    		X0Y0_雨覆羽_羽1 = pars2["羽1"].ToPar();
    		pars2 = partGroup["中雨覆羽"].ToPars();
    		X0Y0_中雨覆羽_羽13 = pars2["羽13"].ToPar();
    		X0Y0_中雨覆羽_羽12 = pars2["羽12"].ToPar();
    		X0Y0_中雨覆羽_羽11 = pars2["羽11"].ToPar();
    		X0Y0_中雨覆羽_羽10 = pars2["羽10"].ToPar();
    		X0Y0_中雨覆羽_羽9 = pars2["羽9"].ToPar();
    		X0Y0_中雨覆羽_羽8 = pars2["羽8"].ToPar();
    		X0Y0_中雨覆羽_羽7 = pars2["羽7"].ToPar();
    		X0Y0_中雨覆羽_羽6 = pars2["羽6"].ToPar();
    		X0Y0_中雨覆羽_羽5 = pars2["羽5"].ToPar();
    		X0Y0_中雨覆羽_羽4 = pars2["羽4"].ToPar();
    		X0Y0_中雨覆羽_羽3 = pars2["羽3"].ToPar();
    		X0Y0_中雨覆羽_羽2 = pars2["羽2"].ToPar();
    		X0Y0_中雨覆羽_羽1 = pars2["羽1"].ToPar();
    		pars2 = partGroup["小雨覆"].ToPars();
    		X0Y0_小雨覆_小雨覆 = pars2["小雨覆"].ToPar();
    		pars2 = pars2["鱗"].ToPars();
    		X0Y0_小雨覆_竜性_鱗1 = pars2["鱗1"].ToPar();
    		X0Y0_小雨覆_竜性_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_小雨覆_竜性_鱗3 = pars2["鱗3"].ToPar();
    		X0Y0_小雨覆_竜性_鱗4 = pars2["鱗4"].ToPar();
    		X0Y0_小雨覆_竜性_鱗5 = pars2["鱗5"].ToPar();
    		X0Y0_小雨覆_竜性_鱗6 = pars2["鱗6"].ToPar();
    		X0Y0_小雨覆_竜性_鱗7 = pars2["鱗7"].ToPar();
    		X0Y0_小雨覆_竜性_鱗8 = pars2["鱗8"].ToPar();
    		X0Y0_小雨覆_竜性_鱗9 = pars2["鱗9"].ToPar();
    		pars2 = partGroup["腕輪"].ToPars();
    		X0Y0_腕輪_革 = pars2["革"].ToPar();
    		X0Y0_腕輪_金具1 = pars2["金具1"].ToPar();
    		X0Y0_腕輪_金具2 = pars2["金具2"].ToPar();
    		X0Y0_腕輪_金具3 = pars2["金具3"].ToPar();
    		X0Y0_腕輪_金具左 = pars2["金具左"].ToPar();
    		X0Y0_腕輪_金具右 = pars2["金具右"].ToPar();
    		Xasix = false;
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
    		鳥翼LowerArm_表示 = e.鳥翼LowerArm_表示;
    		風切羽_羽15_表示 = e.風切羽_羽15_表示;
    		風切羽_羽14_表示 = e.風切羽_羽14_表示;
    		風切羽_羽13_表示 = e.風切羽_羽13_表示;
    		風切羽_羽12_表示 = e.風切羽_羽12_表示;
    		風切羽_羽11_表示 = e.風切羽_羽11_表示;
    		風切羽_羽10_表示 = e.風切羽_羽10_表示;
    		風切羽_羽9_表示 = e.風切羽_羽9_表示;
    		風切羽_羽8_表示 = e.風切羽_羽8_表示;
    		風切羽_羽7_表示 = e.風切羽_羽7_表示;
    		風切羽_羽6_表示 = e.風切羽_羽6_表示;
    		風切羽_羽5_表示 = e.風切羽_羽5_表示;
    		風切羽_羽4_表示 = e.風切羽_羽4_表示;
    		風切羽_羽3_表示 = e.風切羽_羽3_表示;
    		風切羽_羽2_表示 = e.風切羽_羽2_表示;
    		風切羽_羽1_表示 = e.風切羽_羽1_表示;
    		雨覆羽_羽14_表示 = e.雨覆羽_羽14_表示;
    		雨覆羽_羽13_表示 = e.雨覆羽_羽13_表示;
    		雨覆羽_羽12_表示 = e.雨覆羽_羽12_表示;
    		雨覆羽_羽11_表示 = e.雨覆羽_羽11_表示;
    		雨覆羽_羽10_表示 = e.雨覆羽_羽10_表示;
    		雨覆羽_羽9_表示 = e.雨覆羽_羽9_表示;
    		雨覆羽_羽8_表示 = e.雨覆羽_羽8_表示;
    		雨覆羽_羽7_表示 = e.雨覆羽_羽7_表示;
    		雨覆羽_羽6_表示 = e.雨覆羽_羽6_表示;
    		雨覆羽_羽5_表示 = e.雨覆羽_羽5_表示;
    		雨覆羽_羽4_表示 = e.雨覆羽_羽4_表示;
    		雨覆羽_羽3_表示 = e.雨覆羽_羽3_表示;
    		雨覆羽_羽2_表示 = e.雨覆羽_羽2_表示;
    		雨覆羽_羽1_表示 = e.雨覆羽_羽1_表示;
    		中雨覆羽_羽13_表示 = e.中雨覆羽_羽13_表示;
    		中雨覆羽_羽12_表示 = e.中雨覆羽_羽12_表示;
    		中雨覆羽_羽11_表示 = e.中雨覆羽_羽11_表示;
    		中雨覆羽_羽10_表示 = e.中雨覆羽_羽10_表示;
    		中雨覆羽_羽9_表示 = e.中雨覆羽_羽9_表示;
    		中雨覆羽_羽8_表示 = e.中雨覆羽_羽8_表示;
    		中雨覆羽_羽7_表示 = e.中雨覆羽_羽7_表示;
    		中雨覆羽_羽6_表示 = e.中雨覆羽_羽6_表示;
    		中雨覆羽_羽5_表示 = e.中雨覆羽_羽5_表示;
    		中雨覆羽_羽4_表示 = e.中雨覆羽_羽4_表示;
    		中雨覆羽_羽3_表示 = e.中雨覆羽_羽3_表示;
    		中雨覆羽_羽2_表示 = e.中雨覆羽_羽2_表示;
    		中雨覆羽_羽1_表示 = e.中雨覆羽_羽1_表示;
    		小雨覆_小雨覆_表示 = e.小雨覆_小雨覆_表示;
    		小雨覆_竜性_鱗1_表示 = e.小雨覆_竜性_鱗1_表示;
    		小雨覆_竜性_鱗2_表示 = e.小雨覆_竜性_鱗2_表示;
    		小雨覆_竜性_鱗3_表示 = e.小雨覆_竜性_鱗3_表示;
    		小雨覆_竜性_鱗4_表示 = e.小雨覆_竜性_鱗4_表示;
    		小雨覆_竜性_鱗5_表示 = e.小雨覆_竜性_鱗5_表示;
    		小雨覆_竜性_鱗6_表示 = e.小雨覆_竜性_鱗6_表示;
    		小雨覆_竜性_鱗7_表示 = e.小雨覆_竜性_鱗7_表示;
    		小雨覆_竜性_鱗8_表示 = e.小雨覆_竜性_鱗8_表示;
    		小雨覆_竜性_鱗9_表示 = e.小雨覆_竜性_鱗9_表示;
    		腕輪_革_表示 = e.腕輪_革_表示;
    		腕輪_金具1_表示 = e.腕輪_金具1_表示;
    		腕輪_金具2_表示 = e.腕輪_金具2_表示;
    		腕輪_金具3_表示 = e.腕輪_金具3_表示;
    		腕輪_金具左_表示 = e.腕輪_金具左_表示;
    		腕輪_金具右_表示 = e.腕輪_金具右_表示;
    		腕輪表示 = e.腕輪表示;
    		展開 = e.展開;
    		シャープ = e.シャープ;
    		LowerArm_外線 = e.LowerArm_外線;
    		小雨覆_外線 = e.小雨覆_外線;
    		中雨覆羽_羽1_外線 = e.中雨覆羽_羽1_外線;
    		中雨覆羽_羽2_外線 = e.中雨覆羽_羽2_外線;
    		中雨覆羽_羽3_外線 = e.中雨覆羽_羽3_外線;
    		中雨覆羽_羽4_外線 = e.中雨覆羽_羽4_外線;
    		中雨覆羽_羽5_外線 = e.中雨覆羽_羽5_外線;
    		中雨覆羽_羽6_外線 = e.中雨覆羽_羽6_外線;
    		中雨覆羽_羽7_外線 = e.中雨覆羽_羽7_外線;
    		中雨覆羽_羽8_外線 = e.中雨覆羽_羽8_外線;
    		中雨覆羽_羽9_外線 = e.中雨覆羽_羽9_外線;
    		中雨覆羽_羽10_外線 = e.中雨覆羽_羽10_外線;
    		中雨覆羽_羽11_外線 = e.中雨覆羽_羽11_外線;
    		中雨覆羽_羽12_外線 = e.中雨覆羽_羽12_外線;
    		中雨覆羽_羽13_外線 = e.中雨覆羽_羽13_外線;
    		雨覆羽_羽1_外線 = e.雨覆羽_羽1_外線;
    		雨覆羽_羽2_外線 = e.雨覆羽_羽2_外線;
    		雨覆羽_羽3_外線 = e.雨覆羽_羽3_外線;
    		雨覆羽_羽4_外線 = e.雨覆羽_羽4_外線;
    		雨覆羽_羽5_外線 = e.雨覆羽_羽5_外線;
    		雨覆羽_羽6_外線 = e.雨覆羽_羽6_外線;
    		雨覆羽_羽7_外線 = e.雨覆羽_羽7_外線;
    		雨覆羽_羽8_外線 = e.雨覆羽_羽8_外線;
    		雨覆羽_羽9_外線 = e.雨覆羽_羽9_外線;
    		雨覆羽_羽10_外線 = e.雨覆羽_羽10_外線;
    		雨覆羽_羽11_外線 = e.雨覆羽_羽11_外線;
    		雨覆羽_羽12_外線 = e.雨覆羽_羽12_外線;
    		雨覆羽_羽13_外線 = e.雨覆羽_羽13_外線;
    		雨覆羽_羽14_外線 = e.雨覆羽_羽14_外線;
    		風切羽_羽1_外線 = e.風切羽_羽1_外線;
    		風切羽_羽2_外線 = e.風切羽_羽2_外線;
    		風切羽_羽3_外線 = e.風切羽_羽3_外線;
    		風切羽_羽4_外線 = e.風切羽_羽4_外線;
    		風切羽_羽5_外線 = e.風切羽_羽5_外線;
    		風切羽_羽6_外線 = e.風切羽_羽6_外線;
    		風切羽_羽7_外線 = e.風切羽_羽7_外線;
    		風切羽_羽8_外線 = e.風切羽_羽8_外線;
    		風切羽_羽9_外線 = e.風切羽_羽9_外線;
    		風切羽_羽10_外線 = e.風切羽_羽10_外線;
    		風切羽_羽11_外線 = e.風切羽_羽11_外線;
    		風切羽_羽12_外線 = e.風切羽_羽12_外線;
    		風切羽_羽13_外線 = e.風切羽_羽13_外線;
    		風切羽_羽14_外線 = e.風切羽_羽14_外線;
    		風切羽_羽15_外線 = e.風切羽_羽15_外線;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.手_接続.Count > 0)
    		{
    			Element f;
    			手_接続 = e.手_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = LowerArm_鳥2;
    				f.ConnectionType = ConnectionInfo.LowerArm_鳥_手_接続;
    				f.接続(LowerArm_鳥2.手_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_鳥翼LowerArmCP = new ColorP(X0Y0_鳥翼LowerArm, 鳥翼LowerArmCD, DisUnit, abj: true);
    		X0Y0_風切羽_羽15CP = new ColorP(X0Y0_風切羽_羽15, 風切羽_羽15CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽14CP = new ColorP(X0Y0_風切羽_羽14, 風切羽_羽14CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽13CP = new ColorP(X0Y0_風切羽_羽13, 風切羽_羽13CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽12CP = new ColorP(X0Y0_風切羽_羽12, 風切羽_羽12CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽11CP = new ColorP(X0Y0_風切羽_羽11, 風切羽_羽11CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽10CP = new ColorP(X0Y0_風切羽_羽10, 風切羽_羽10CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽9CP = new ColorP(X0Y0_風切羽_羽9, 風切羽_羽9CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽8CP = new ColorP(X0Y0_風切羽_羽8, 風切羽_羽8CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽7CP = new ColorP(X0Y0_風切羽_羽7, 風切羽_羽7CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽6CP = new ColorP(X0Y0_風切羽_羽6, 風切羽_羽6CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽5CP = new ColorP(X0Y0_風切羽_羽5, 風切羽_羽5CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽4CP = new ColorP(X0Y0_風切羽_羽4, 風切羽_羽4CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽3CP = new ColorP(X0Y0_風切羽_羽3, 風切羽_羽3CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽2CP = new ColorP(X0Y0_風切羽_羽2, 風切羽_羽2CD, DisUnit, abj: true);
    		X0Y0_風切羽_羽1CP = new ColorP(X0Y0_風切羽_羽1, 風切羽_羽1CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽14CP = new ColorP(X0Y0_雨覆羽_羽14, 雨覆羽_羽14CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽13CP = new ColorP(X0Y0_雨覆羽_羽13, 雨覆羽_羽13CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽12CP = new ColorP(X0Y0_雨覆羽_羽12, 雨覆羽_羽12CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽11CP = new ColorP(X0Y0_雨覆羽_羽11, 雨覆羽_羽11CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽10CP = new ColorP(X0Y0_雨覆羽_羽10, 雨覆羽_羽10CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽9CP = new ColorP(X0Y0_雨覆羽_羽9, 雨覆羽_羽9CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽8CP = new ColorP(X0Y0_雨覆羽_羽8, 雨覆羽_羽8CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽7CP = new ColorP(X0Y0_雨覆羽_羽7, 雨覆羽_羽7CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽6CP = new ColorP(X0Y0_雨覆羽_羽6, 雨覆羽_羽6CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽5CP = new ColorP(X0Y0_雨覆羽_羽5, 雨覆羽_羽5CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽4CP = new ColorP(X0Y0_雨覆羽_羽4, 雨覆羽_羽4CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽3CP = new ColorP(X0Y0_雨覆羽_羽3, 雨覆羽_羽3CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽2CP = new ColorP(X0Y0_雨覆羽_羽2, 雨覆羽_羽2CD, DisUnit, abj: true);
    		X0Y0_雨覆羽_羽1CP = new ColorP(X0Y0_雨覆羽_羽1, 雨覆羽_羽1CD, DisUnit, abj: true);
    		X0Y0_中雨覆羽_羽13CP = new ColorP(X0Y0_中雨覆羽_羽13, 中雨覆羽_羽13CD, DisUnit, abj: true);
    		X0Y0_中雨覆羽_羽12CP = new ColorP(X0Y0_中雨覆羽_羽12, 中雨覆羽_羽12CD, DisUnit, abj: true);
    		X0Y0_中雨覆羽_羽11CP = new ColorP(X0Y0_中雨覆羽_羽11, 中雨覆羽_羽11CD, DisUnit, abj: true);
    		X0Y0_中雨覆羽_羽10CP = new ColorP(X0Y0_中雨覆羽_羽10, 中雨覆羽_羽10CD, DisUnit, abj: true);
    		X0Y0_中雨覆羽_羽9CP = new ColorP(X0Y0_中雨覆羽_羽9, 中雨覆羽_羽9CD, DisUnit, abj: true);
    		X0Y0_中雨覆羽_羽8CP = new ColorP(X0Y0_中雨覆羽_羽8, 中雨覆羽_羽8CD, DisUnit, abj: true);
    		X0Y0_中雨覆羽_羽7CP = new ColorP(X0Y0_中雨覆羽_羽7, 中雨覆羽_羽7CD, DisUnit, abj: true);
    		X0Y0_中雨覆羽_羽6CP = new ColorP(X0Y0_中雨覆羽_羽6, 中雨覆羽_羽6CD, DisUnit, abj: true);
    		X0Y0_中雨覆羽_羽5CP = new ColorP(X0Y0_中雨覆羽_羽5, 中雨覆羽_羽5CD, DisUnit, abj: true);
    		X0Y0_中雨覆羽_羽4CP = new ColorP(X0Y0_中雨覆羽_羽4, 中雨覆羽_羽4CD, DisUnit, abj: true);
    		X0Y0_中雨覆羽_羽3CP = new ColorP(X0Y0_中雨覆羽_羽3, 中雨覆羽_羽3CD, DisUnit, abj: true);
    		X0Y0_中雨覆羽_羽2CP = new ColorP(X0Y0_中雨覆羽_羽2, 中雨覆羽_羽2CD, DisUnit, abj: true);
    		X0Y0_中雨覆羽_羽1CP = new ColorP(X0Y0_中雨覆羽_羽1, 中雨覆羽_羽1CD, DisUnit, abj: true);
    		X0Y0_小雨覆_小雨覆CP = new ColorP(X0Y0_小雨覆_小雨覆, 小雨覆_小雨覆CD, DisUnit, abj: false);
    		X0Y0_小雨覆_竜性_鱗1CP = new ColorP(X0Y0_小雨覆_竜性_鱗1, 小雨覆_竜性_鱗1CD, DisUnit, abj: true);
    		X0Y0_小雨覆_竜性_鱗2CP = new ColorP(X0Y0_小雨覆_竜性_鱗2, 小雨覆_竜性_鱗2CD, DisUnit, abj: true);
    		X0Y0_小雨覆_竜性_鱗3CP = new ColorP(X0Y0_小雨覆_竜性_鱗3, 小雨覆_竜性_鱗3CD, DisUnit, abj: true);
    		X0Y0_小雨覆_竜性_鱗4CP = new ColorP(X0Y0_小雨覆_竜性_鱗4, 小雨覆_竜性_鱗4CD, DisUnit, abj: true);
    		X0Y0_小雨覆_竜性_鱗5CP = new ColorP(X0Y0_小雨覆_竜性_鱗5, 小雨覆_竜性_鱗5CD, DisUnit, abj: true);
    		X0Y0_小雨覆_竜性_鱗6CP = new ColorP(X0Y0_小雨覆_竜性_鱗6, 小雨覆_竜性_鱗6CD, DisUnit, abj: true);
    		X0Y0_小雨覆_竜性_鱗7CP = new ColorP(X0Y0_小雨覆_竜性_鱗7, 小雨覆_竜性_鱗7CD, DisUnit, abj: true);
    		X0Y0_小雨覆_竜性_鱗8CP = new ColorP(X0Y0_小雨覆_竜性_鱗8, 小雨覆_竜性_鱗8CD, DisUnit, abj: true);
    		X0Y0_小雨覆_竜性_鱗9CP = new ColorP(X0Y0_小雨覆_竜性_鱗9, 小雨覆_竜性_鱗9CD, DisUnit, abj: true);
    		X0Y0_腕輪_革CP = new ColorP(X0Y0_腕輪_革, 腕輪_革CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具1CP = new ColorP(X0Y0_腕輪_金具1, 腕輪_金具1CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具2CP = new ColorP(X0Y0_腕輪_金具2, 腕輪_金具2CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具3CP = new ColorP(X0Y0_腕輪_金具3, 腕輪_金具3CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具左CP = new ColorP(X0Y0_腕輪_金具左, 腕輪_金具左CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具右CP = new ColorP(X0Y0_腕輪_金具右, 腕輪_金具右CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		鎖1 = new 拘束鎖(DisUnit, 右: false, 配色指定, 体配色, Xasix);
    		鎖1.接続(鎖1_接続点);
    		int num = (右 ? (-10) : 10);
    		鎖1.角度B += num;
    		鎖表示 = e.鎖表示;
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_鳥翼LowerArm.AngleBase = num * -341.0;
    		X0Y0_風切羽_羽1.AngleBase = num * -72.3455557531598;
    		X0Y0_風切羽_羽2.AngleBase = num * -76.3455557531598;
    		X0Y0_風切羽_羽3.AngleBase = num * -79.3455557531599;
    		X0Y0_風切羽_羽4.AngleBase = num * -82.34555575315983;
    		X0Y0_風切羽_羽5.AngleBase = num * -85.34555575315983;
    		X0Y0_風切羽_羽6.AngleBase = num * -88.34555575315994;
    		X0Y0_風切羽_羽7.AngleBase = num * -91.34555575315983;
    		X0Y0_風切羽_羽8.AngleBase = num * -94.34555575315994;
    		X0Y0_風切羽_羽9.AngleBase = num * -97.34555575315983;
    		X0Y0_風切羽_羽10.AngleBase = num * -100.3455557531598;
    		X0Y0_風切羽_羽11.AngleBase = num * -103.34555575316;
    		X0Y0_風切羽_羽12.AngleBase = num * -106.3455557531598;
    		X0Y0_風切羽_羽13.AngleBase = num * 250.654444246839;
    		X0Y0_風切羽_羽14.AngleBase = num * 247.65444424684;
    		X0Y0_風切羽_羽15.AngleBase = num * 244.65444424684;
    		X0Y0_雨覆羽_羽1.AngleBase = num * -61.6335605882607;
    		X0Y0_雨覆羽_羽2.AngleBase = num * -65.0211000072925;
    		X0Y0_雨覆羽_羽3.AngleBase = num * -68.6100025846698;
    		X0Y0_雨覆羽_羽4.AngleBase = num * -72.4094733624345;
    		X0Y0_雨覆羽_羽5.AngleBase = num * -76.4248591735387;
    		X0Y0_雨覆羽_羽6.AngleBase = num * -80.65615843821939;
    		X0Y0_雨覆羽_羽7.AngleBase = num * -85.09647453999872;
    		X0Y0_雨覆羽_羽8.AngleBase = num * -89.73063451433654;
    		X0Y0_雨覆羽_羽9.AngleBase = num * -94.53427462319013;
    		X0Y0_雨覆羽_羽10.AngleBase = num * -99.47372396003561;
    		X0Y0_雨覆羽_羽11.AngleBase = num * -104.5069529689633;
    		X0Y0_雨覆羽_羽12.AngleBase = num * 250.41432558095;
    		X0Y0_雨覆羽_羽13.AngleBase = num * 245.34158111747;
    		X0Y0_雨覆羽_羽14.AngleBase = num * 240.325859447711;
    		X0Y0_中雨覆羽_羽1.AngleBase = num * -49.1787166893964;
    		X0Y0_中雨覆羽_羽2.AngleBase = num * -57.1787166893962;
    		X0Y0_中雨覆羽_羽3.AngleBase = num * -65.1787166893963;
    		X0Y0_中雨覆羽_羽4.AngleBase = num * -73.1787166893963;
    		X0Y0_中雨覆羽_羽5.AngleBase = num * -81.17871668939631;
    		X0Y0_中雨覆羽_羽6.AngleBase = num * -89.17871668939688;
    		X0Y0_中雨覆羽_羽7.AngleBase = num * -97.17871668939625;
    		X0Y0_中雨覆羽_羽8.AngleBase = num * -105.1787166893964;
    		X0Y0_中雨覆羽_羽9.AngleBase = num * 246.821283310604;
    		X0Y0_中雨覆羽_羽10.AngleBase = num * 238.821283310604;
    		X0Y0_中雨覆羽_羽11.AngleBase = num * 230.821283310604;
    		X0Y0_中雨覆羽_羽12.AngleBase = num * 222.821283310604;
    		X0Y0_中雨覆羽_羽13.AngleBase = num * 214.821283310604;
    		Body.JoinPAall();
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_鳥翼LowerArm);
    		Are.Draw(X0Y0_風切羽_羽15);
    		Are.Draw(X0Y0_風切羽_羽14);
    		Are.Draw(X0Y0_風切羽_羽13);
    		Are.Draw(X0Y0_風切羽_羽12);
    		Are.Draw(X0Y0_風切羽_羽11);
    		Are.Draw(X0Y0_風切羽_羽10);
    		Are.Draw(X0Y0_風切羽_羽9);
    		Are.Draw(X0Y0_風切羽_羽8);
    		Are.Draw(X0Y0_風切羽_羽7);
    		Are.Draw(X0Y0_風切羽_羽6);
    		Are.Draw(X0Y0_風切羽_羽5);
    		Are.Draw(X0Y0_風切羽_羽4);
    		Are.Draw(X0Y0_風切羽_羽3);
    		Are.Draw(X0Y0_風切羽_羽2);
    		Are.Draw(X0Y0_風切羽_羽1);
    		Are.Draw(X0Y0_雨覆羽_羽14);
    		Are.Draw(X0Y0_雨覆羽_羽13);
    		Are.Draw(X0Y0_雨覆羽_羽12);
    		Are.Draw(X0Y0_雨覆羽_羽11);
    		Are.Draw(X0Y0_雨覆羽_羽10);
    		Are.Draw(X0Y0_雨覆羽_羽9);
    		Are.Draw(X0Y0_雨覆羽_羽8);
    		Are.Draw(X0Y0_雨覆羽_羽7);
    		Are.Draw(X0Y0_雨覆羽_羽6);
    		Are.Draw(X0Y0_雨覆羽_羽5);
    		Are.Draw(X0Y0_雨覆羽_羽4);
    		Are.Draw(X0Y0_雨覆羽_羽3);
    		Are.Draw(X0Y0_雨覆羽_羽2);
    		Are.Draw(X0Y0_雨覆羽_羽1);
    		Are.Draw(X0Y0_中雨覆羽_羽13);
    		Are.Draw(X0Y0_中雨覆羽_羽12);
    		Are.Draw(X0Y0_中雨覆羽_羽11);
    		Are.Draw(X0Y0_中雨覆羽_羽10);
    		Are.Draw(X0Y0_中雨覆羽_羽9);
    		Are.Draw(X0Y0_中雨覆羽_羽8);
    		Are.Draw(X0Y0_中雨覆羽_羽7);
    		Are.Draw(X0Y0_中雨覆羽_羽6);
    		Are.Draw(X0Y0_中雨覆羽_羽5);
    		Are.Draw(X0Y0_中雨覆羽_羽4);
    		Are.Draw(X0Y0_中雨覆羽_羽3);
    		Are.Draw(X0Y0_中雨覆羽_羽2);
    		Are.Draw(X0Y0_中雨覆羽_羽1);
    	}

    	public void 小雨覆描画(RenderArea Are)
    	{
    		Are.Draw(X0Y0_小雨覆_小雨覆);
    		Are.Draw(X0Y0_小雨覆_竜性_鱗1);
    		Are.Draw(X0Y0_小雨覆_竜性_鱗2);
    		Are.Draw(X0Y0_小雨覆_竜性_鱗3);
    		Are.Draw(X0Y0_小雨覆_竜性_鱗4);
    		Are.Draw(X0Y0_小雨覆_竜性_鱗5);
    		Are.Draw(X0Y0_小雨覆_竜性_鱗6);
    		Are.Draw(X0Y0_小雨覆_竜性_鱗7);
    		Are.Draw(X0Y0_小雨覆_竜性_鱗8);
    		Are.Draw(X0Y0_小雨覆_竜性_鱗9);
    		Are.Draw(X0Y0_腕輪_革);
    		Are.Draw(X0Y0_腕輪_金具1);
    		Are.Draw(X0Y0_腕輪_金具2);
    		Are.Draw(X0Y0_腕輪_金具3);
    		Are.Draw(X0Y0_腕輪_金具左);
    		Are.Draw(X0Y0_腕輪_金具右);
    		鎖1.描画0(Are);
    	}

    	public override bool Is革(ShapePart p)
    	{
    		if (p != X0Y0_腕輪_革 && p != X0Y0_腕輪_金具1 && p != X0Y0_腕輪_金具2 && p != X0Y0_腕輪_金具3 && p != X0Y0_腕輪_金具左)
    		{
    			return p == X0Y0_腕輪_金具右;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_鳥翼LowerArmCP.Update();
    		X0Y0_風切羽_羽15CP.Update();
    		X0Y0_風切羽_羽14CP.Update();
    		X0Y0_風切羽_羽13CP.Update();
    		X0Y0_風切羽_羽12CP.Update();
    		X0Y0_風切羽_羽11CP.Update();
    		X0Y0_風切羽_羽10CP.Update();
    		X0Y0_風切羽_羽9CP.Update();
    		X0Y0_風切羽_羽8CP.Update();
    		X0Y0_風切羽_羽7CP.Update();
    		X0Y0_風切羽_羽6CP.Update();
    		X0Y0_風切羽_羽5CP.Update();
    		X0Y0_風切羽_羽4CP.Update();
    		X0Y0_風切羽_羽3CP.Update();
    		X0Y0_風切羽_羽2CP.Update();
    		X0Y0_風切羽_羽1CP.Update();
    		X0Y0_雨覆羽_羽14CP.Update();
    		X0Y0_雨覆羽_羽13CP.Update();
    		X0Y0_雨覆羽_羽12CP.Update();
    		X0Y0_雨覆羽_羽11CP.Update();
    		X0Y0_雨覆羽_羽10CP.Update();
    		X0Y0_雨覆羽_羽9CP.Update();
    		X0Y0_雨覆羽_羽8CP.Update();
    		X0Y0_雨覆羽_羽7CP.Update();
    		X0Y0_雨覆羽_羽6CP.Update();
    		X0Y0_雨覆羽_羽5CP.Update();
    		X0Y0_雨覆羽_羽4CP.Update();
    		X0Y0_雨覆羽_羽3CP.Update();
    		X0Y0_雨覆羽_羽2CP.Update();
    		X0Y0_雨覆羽_羽1CP.Update();
    		X0Y0_中雨覆羽_羽13CP.Update();
    		X0Y0_中雨覆羽_羽12CP.Update();
    		X0Y0_中雨覆羽_羽11CP.Update();
    		X0Y0_中雨覆羽_羽10CP.Update();
    		X0Y0_中雨覆羽_羽9CP.Update();
    		X0Y0_中雨覆羽_羽8CP.Update();
    		X0Y0_中雨覆羽_羽7CP.Update();
    		X0Y0_中雨覆羽_羽6CP.Update();
    		X0Y0_中雨覆羽_羽5CP.Update();
    		X0Y0_中雨覆羽_羽4CP.Update();
    		X0Y0_中雨覆羽_羽3CP.Update();
    		X0Y0_中雨覆羽_羽2CP.Update();
    		X0Y0_中雨覆羽_羽1CP.Update();
    		X0Y0_小雨覆_小雨覆CP.Update();
    		X0Y0_小雨覆_竜性_鱗1CP.Update();
    		X0Y0_小雨覆_竜性_鱗2CP.Update();
    		X0Y0_小雨覆_竜性_鱗3CP.Update();
    		X0Y0_小雨覆_竜性_鱗4CP.Update();
    		X0Y0_小雨覆_竜性_鱗5CP.Update();
    		X0Y0_小雨覆_竜性_鱗6CP.Update();
    		X0Y0_小雨覆_竜性_鱗7CP.Update();
    		X0Y0_小雨覆_竜性_鱗8CP.Update();
    		X0Y0_小雨覆_竜性_鱗9CP.Update();
    		X0Y0_腕輪_革CP.Update();
    		X0Y0_腕輪_金具1CP.Update();
    		X0Y0_腕輪_金具2CP.Update();
    		X0Y0_腕輪_金具3CP.Update();
    		X0Y0_腕輪_金具左CP.Update();
    		X0Y0_腕輪_金具右CP.Update();
    		鎖1.接続PA();
    		鎖1.色更新();
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
    		鳥翼LowerArmCD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		風切羽_羽15CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽14CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽13CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽12CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽11CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽10CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽9CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽8CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽7CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽6CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽5CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽4CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽3CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽2CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽1CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		雨覆羽_羽14CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽13CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽12CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽11CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽10CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽9CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽8CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽7CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽6CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽5CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽13CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽12CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽11CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽10CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽9CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽8CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽7CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽6CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽5CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		小雨覆_小雨覆CD = new ColorD(ref 体配色.髪線, ref 体配色.羽0O);
    		小雨覆_竜性_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗5CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗6CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗7CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗8CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗9CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		鳥翼LowerArmCD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		風切羽_羽15CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽14CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽13CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽12CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽11CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽10CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽9CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽8CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽7CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽6CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽5CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽4CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽2CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽14CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽13CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽12CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽11CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽10CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽9CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽8CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽7CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽6CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽5CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		中雨覆羽_羽13CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽12CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		中雨覆羽_羽11CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽10CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		中雨覆羽_羽9CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽8CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		中雨覆羽_羽7CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽6CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		中雨覆羽_羽5CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		中雨覆羽_羽3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		中雨覆羽_羽1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		小雨覆_小雨覆CD = new ColorD(ref 体配色.髪線, ref 体配色.羽0O);
    		小雨覆_竜性_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		小雨覆_竜性_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		小雨覆_竜性_鱗5CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗6CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		小雨覆_竜性_鱗7CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗8CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		小雨覆_竜性_鱗9CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		鳥翼LowerArmCD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		風切羽_羽15CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽14CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽13CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽12CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽11CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽10CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽9CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽8CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽7CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽6CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽5CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽3CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		風切羽_羽2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		風切羽_羽1CD = new ColorD(ref ColorHelper.Black, ref 体配色.羽1O);
    		雨覆羽_羽14CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽13CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽12CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽11CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽10CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽9CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽8CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽7CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽6CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽5CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		雨覆羽_羽2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		雨覆羽_羽1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽13CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		中雨覆羽_羽12CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽11CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		中雨覆羽_羽10CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽9CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		中雨覆羽_羽8CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽7CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		中雨覆羽_羽6CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽5CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		中雨覆羽_羽4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		中雨覆羽_羽2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛1O);
    		中雨覆羽_羽1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		小雨覆_小雨覆CD = new ColorD(ref 体配色.髪線, ref 体配色.羽0O);
    		小雨覆_竜性_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		小雨覆_竜性_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		小雨覆_竜性_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗5CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		小雨覆_竜性_鱗6CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗7CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		小雨覆_竜性_鱗8CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		小雨覆_竜性_鱗9CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	public void 腕輪配色(拘束具色 配色)
    	{
    		腕輪_革CD.色 = 配色.革部色;
    		腕輪_金具1CD.色 = 配色.金具色;
    		腕輪_金具2CD.色 = 腕輪_金具1CD.色;
    		腕輪_金具3CD.色 = 腕輪_金具1CD.色;
    		腕輪_金具左CD.色 = 腕輪_金具1CD.色;
    		腕輪_金具右CD.色 = 腕輪_金具1CD.色;
    	}

    	public void 鎖配色(鎖色 配色)
    	{
    		鎖1.配色鎖(配色);
    	}
    }
}
