using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class Neck : Ele
    {
    	public ShapePart X0Y0_植性_蔦;

    	public ShapePart X0Y0_植性_棘左上;

    	public ShapePart X0Y0_植性_棘左下;

    	public ShapePart X0Y0_植性_棘右上;

    	public ShapePart X0Y0_植性_棘右下;

    	public ShapePart X0Y0_Neck;

    	public ShapePart X0Y0_淫タトゥ_ハート_タトゥ左;

    	public ShapePart X0Y0_淫タトゥ_ハート_タトゥ右;

    	public ShapePart X0Y0_淫タトゥ_タトゥ左;

    	public ShapePart X0Y0_淫タトゥ_タトゥ右;

    	public ShapePart X0Y0_悪タトゥ_文字_文字a_枠;

    	public ShapePart X0Y0_悪タトゥ_文字_文字a_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_文字_文字a_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_文字_文字b_枠;

    	public ShapePart X0Y0_悪タトゥ_文字_文字b_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_文字_文字b_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_文字_文字c_枠;

    	public ShapePart X0Y0_悪タトゥ_文字_文字c_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_文字_文字c_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_文字_文字d_枠;

    	public ShapePart X0Y0_悪タトゥ_文字_文字d_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_文字_文字d_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_文字_文字e_枠;

    	public ShapePart X0Y0_悪タトゥ_文字_文字e_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_文字_文字e_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_文字_文字e_文字タトゥ3;

    	public ShapePart X0Y0_悪タトゥ_タトゥ;

    	public ShapePart X0Y0_竜性_鱗1;

    	public ShapePart X0Y0_竜性_鱗2;

    	public ShapePart X0Y0_竜性_鱗3;

    	public ShapePart X0Y0_竜性_鱗4;

    	public ShapePart X0Y0_竜性_鱗5;

    	public ShapePart X0Y0_竜性_鱗6;

    	public ShapePart X0Y0_虫性_蛇腹4;

    	public ShapePart X0Y0_虫性_蛇腹3;

    	public ShapePart X0Y0_虫性_蛇腹2;

    	public ShapePart X0Y0_虫性_蛇腹1;

    	public ShapePart X0Y0_ヴィオラ_左_襟;

    	public ShapePart X0Y0_ヴィオラ_左_縁1;

    	public ShapePart X0Y0_ヴィオラ_左_縁2;

    	public ShapePart X0Y0_ヴィオラ_右_襟;

    	public ShapePart X0Y0_ヴィオラ_右_縁1;

    	public ShapePart X0Y0_ヴィオラ_右_縁2;

    	public ShapePart X0Y0_首輪_革;

    	public ShapePart X0Y0_首輪_金具1;

    	public ShapePart X0Y0_首輪_金具2;

    	public ShapePart X0Y0_首輪_金具3;

    	public ShapePart X0Y0_首輪_金具左;

    	public ShapePart X0Y0_首輪_金具右;

    	public ColorD 植性_蔦CD;

    	public ColorD 植性_棘左上CD;

    	public ColorD 植性_棘左下CD;

    	public ColorD 植性_棘右上CD;

    	public ColorD 植性_棘右下CD;

    	public ColorD NeckCD;

    	public ColorD 淫タトゥ_ハート_タトゥ左CD;

    	public ColorD 淫タトゥ_ハート_タトゥ右CD;

    	public ColorD 淫タトゥ_タトゥ左CD;

    	public ColorD 淫タトゥ_タトゥ右CD;

    	public ColorD 悪タトゥ_文字_文字a_枠CD;

    	public ColorD 悪タトゥ_文字_文字a_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字_文字a_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字_文字b_枠CD;

    	public ColorD 悪タトゥ_文字_文字b_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字_文字b_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字_文字c_枠CD;

    	public ColorD 悪タトゥ_文字_文字c_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字_文字c_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字_文字d_枠CD;

    	public ColorD 悪タトゥ_文字_文字d_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字_文字d_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字_文字e_枠CD;

    	public ColorD 悪タトゥ_文字_文字e_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字_文字e_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字_文字e_文字タトゥ3CD;

    	public ColorD 悪タトゥ_タトゥCD;

    	public ColorD 竜性_鱗1CD;

    	public ColorD 竜性_鱗2CD;

    	public ColorD 竜性_鱗3CD;

    	public ColorD 竜性_鱗4CD;

    	public ColorD 竜性_鱗5CD;

    	public ColorD 竜性_鱗6CD;

    	public ColorD 虫性_蛇腹4CD;

    	public ColorD 虫性_蛇腹3CD;

    	public ColorD 虫性_蛇腹2CD;

    	public ColorD 虫性_蛇腹1CD;

    	public ColorD ヴィオラ_左_襟CD;

    	public ColorD ヴィオラ_左_縁1CD;

    	public ColorD ヴィオラ_左_縁2CD;

    	public ColorD ヴィオラ_右_襟CD;

    	public ColorD ヴィオラ_右_縁1CD;

    	public ColorD ヴィオラ_右_縁2CD;

    	public ColorD 首輪_革CD;

    	public ColorD 首輪_金具1CD;

    	public ColorD 首輪_金具2CD;

    	public ColorD 首輪_金具3CD;

    	public ColorD 首輪_金具左CD;

    	public ColorD 首輪_金具右CD;

    	public ColorP X0Y0_植性_蔦CP;

    	public ColorP X0Y0_植性_棘左上CP;

    	public ColorP X0Y0_植性_棘左下CP;

    	public ColorP X0Y0_植性_棘右上CP;

    	public ColorP X0Y0_植性_棘右下CP;

    	public ColorP X0Y0_NeckCP;

    	public ColorP X0Y0_淫タトゥ_ハート_タトゥ左CP;

    	public ColorP X0Y0_淫タトゥ_ハート_タトゥ右CP;

    	public ColorP X0Y0_淫タトゥ_タトゥ左CP;

    	public ColorP X0Y0_淫タトゥ_タトゥ右CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字a_枠CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字a_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字a_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字b_枠CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字b_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字b_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字c_枠CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字c_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字c_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字d_枠CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字d_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字d_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字e_枠CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字e_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字e_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_文字_文字e_文字タトゥ3CP;

    	public ColorP X0Y0_悪タトゥ_タトゥCP;

    	public ColorP X0Y0_竜性_鱗1CP;

    	public ColorP X0Y0_竜性_鱗2CP;

    	public ColorP X0Y0_竜性_鱗3CP;

    	public ColorP X0Y0_竜性_鱗4CP;

    	public ColorP X0Y0_竜性_鱗5CP;

    	public ColorP X0Y0_竜性_鱗6CP;

    	public ColorP X0Y0_虫性_蛇腹4CP;

    	public ColorP X0Y0_虫性_蛇腹3CP;

    	public ColorP X0Y0_虫性_蛇腹2CP;

    	public ColorP X0Y0_虫性_蛇腹1CP;

    	public ColorP X0Y0_ヴィオラ_左_襟CP;

    	public ColorP X0Y0_ヴィオラ_左_縁1CP;

    	public ColorP X0Y0_ヴィオラ_左_縁2CP;

    	public ColorP X0Y0_ヴィオラ_右_襟CP;

    	public ColorP X0Y0_ヴィオラ_右_縁1CP;

    	public ColorP X0Y0_ヴィオラ_右_縁2CP;

    	public ColorP X0Y0_首輪_革CP;

    	public ColorP X0Y0_首輪_金具1CP;

    	public ColorP X0Y0_首輪_金具2CP;

    	public ColorP X0Y0_首輪_金具3CP;

    	public ColorP X0Y0_首輪_金具左CP;

    	public ColorP X0Y0_首輪_金具右CP;

    	public 拘束鎖 鎖1;

    	public 拘束鎖 鎖2;

    	public スタンプK キスマーク;

    	public スタンプW 鞭痕;

    	public Ele[] Head_接続;

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
    			首輪表示 = 拘束_;
    		}
    	}

    	public bool 植性_蔦_表示
    	{
    		get
    		{
    			return X0Y0_植性_蔦.Dra;
    		}
    		set
    		{
    			X0Y0_植性_蔦.Dra = value;
    			X0Y0_植性_蔦.Hit = value;
    		}
    	}

    	public bool 植性_棘左上_表示
    	{
    		get
    		{
    			return X0Y0_植性_棘左上.Dra;
    		}
    		set
    		{
    			X0Y0_植性_棘左上.Dra = value;
    			X0Y0_植性_棘左上.Hit = value;
    		}
    	}

    	public bool 植性_棘左下_表示
    	{
    		get
    		{
    			return X0Y0_植性_棘左下.Dra;
    		}
    		set
    		{
    			X0Y0_植性_棘左下.Dra = value;
    			X0Y0_植性_棘左下.Hit = value;
    		}
    	}

    	public bool 植性_棘右上_表示
    	{
    		get
    		{
    			return X0Y0_植性_棘右上.Dra;
    		}
    		set
    		{
    			X0Y0_植性_棘右上.Dra = value;
    			X0Y0_植性_棘右上.Hit = value;
    		}
    	}

    	public bool 植性_棘右下_表示
    	{
    		get
    		{
    			return X0Y0_植性_棘右下.Dra;
    		}
    		set
    		{
    			X0Y0_植性_棘右下.Dra = value;
    			X0Y0_植性_棘右下.Hit = value;
    		}
    	}

    	public bool Neck_表示
    	{
    		get
    		{
    			return X0Y0_Neck.Dra;
    		}
    		set
    		{
    			X0Y0_Neck.Dra = value;
    			X0Y0_Neck.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_ハート_タトゥ左_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_ハート_タトゥ左.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_ハート_タトゥ左.Dra = value;
    			X0Y0_淫タトゥ_ハート_タトゥ左.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_ハート_タトゥ右_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_ハート_タトゥ右.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_ハート_タトゥ右.Dra = value;
    			X0Y0_淫タトゥ_ハート_タトゥ右.Hit = value;
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

    	public bool 悪タトゥ_文字_文字a_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字a_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字a_枠.Dra = value;
    			X0Y0_悪タトゥ_文字_文字a_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字a_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字a_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字a_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_文字_文字a_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字a_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字a_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字a_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_文字_文字a_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字b_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字b_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字b_枠.Dra = value;
    			X0Y0_悪タトゥ_文字_文字b_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字b_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字b_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字b_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_文字_文字b_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字b_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字b_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字b_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_文字_文字b_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字c_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字c_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字c_枠.Dra = value;
    			X0Y0_悪タトゥ_文字_文字c_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字c_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字c_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字c_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_文字_文字c_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字c_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字c_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字c_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_文字_文字c_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字d_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字d_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字d_枠.Dra = value;
    			X0Y0_悪タトゥ_文字_文字d_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字d_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字d_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字d_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_文字_文字d_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字d_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字d_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字d_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_文字_文字d_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字e_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字e_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字e_枠.Dra = value;
    			X0Y0_悪タトゥ_文字_文字e_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字e_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字e_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字e_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_文字_文字e_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字e_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字e_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字e_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_文字_文字e_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字_文字e_文字タトゥ3_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_文字_文字e_文字タトゥ3.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_文字_文字e_文字タトゥ3.Dra = value;
    			X0Y0_悪タトゥ_文字_文字e_文字タトゥ3.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_タトゥ_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_タトゥ.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_タトゥ.Dra = value;
    			X0Y0_悪タトゥ_タトゥ.Hit = value;
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

    	public bool 竜性_鱗4_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗4.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗4.Dra = value;
    			X0Y0_竜性_鱗4.Hit = value;
    		}
    	}

    	public bool 竜性_鱗5_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗5.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗5.Dra = value;
    			X0Y0_竜性_鱗5.Hit = value;
    		}
    	}

    	public bool 竜性_鱗6_表示
    	{
    		get
    		{
    			return X0Y0_竜性_鱗6.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_鱗6.Dra = value;
    			X0Y0_竜性_鱗6.Hit = value;
    		}
    	}

    	public bool 虫性_蛇腹4_表示
    	{
    		get
    		{
    			return X0Y0_虫性_蛇腹4.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_蛇腹4.Dra = value;
    			X0Y0_虫性_蛇腹4.Hit = value;
    		}
    	}

    	public bool 虫性_蛇腹3_表示
    	{
    		get
    		{
    			return X0Y0_虫性_蛇腹3.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_蛇腹3.Dra = value;
    			X0Y0_虫性_蛇腹3.Hit = value;
    		}
    	}

    	public bool 虫性_蛇腹2_表示
    	{
    		get
    		{
    			return X0Y0_虫性_蛇腹2.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_蛇腹2.Dra = value;
    			X0Y0_虫性_蛇腹2.Hit = value;
    		}
    	}

    	public bool 虫性_蛇腹1_表示
    	{
    		get
    		{
    			return X0Y0_虫性_蛇腹1.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_蛇腹1.Dra = value;
    			X0Y0_虫性_蛇腹1.Hit = value;
    		}
    	}

    	public bool ヴィオラ_左_襟_表示
    	{
    		get
    		{
    			return X0Y0_ヴィオラ_左_襟.Dra;
    		}
    		set
    		{
    			X0Y0_ヴィオラ_左_襟.Dra = value;
    			X0Y0_ヴィオラ_左_襟.Hit = value;
    		}
    	}

    	public bool ヴィオラ_左_縁1_表示
    	{
    		get
    		{
    			return X0Y0_ヴィオラ_左_縁1.Dra;
    		}
    		set
    		{
    			X0Y0_ヴィオラ_左_縁1.Dra = value;
    			X0Y0_ヴィオラ_左_縁1.Hit = value;
    		}
    	}

    	public bool ヴィオラ_左_縁2_表示
    	{
    		get
    		{
    			return X0Y0_ヴィオラ_左_縁2.Dra;
    		}
    		set
    		{
    			X0Y0_ヴィオラ_左_縁2.Dra = value;
    			X0Y0_ヴィオラ_左_縁2.Hit = value;
    		}
    	}

    	public bool ヴィオラ_右_襟_表示
    	{
    		get
    		{
    			return X0Y0_ヴィオラ_右_襟.Dra;
    		}
    		set
    		{
    			X0Y0_ヴィオラ_右_襟.Dra = value;
    			X0Y0_ヴィオラ_右_襟.Hit = value;
    		}
    	}

    	public bool ヴィオラ_右_縁1_表示
    	{
    		get
    		{
    			return X0Y0_ヴィオラ_右_縁1.Dra;
    		}
    		set
    		{
    			X0Y0_ヴィオラ_右_縁1.Dra = value;
    			X0Y0_ヴィオラ_右_縁1.Hit = value;
    		}
    	}

    	public bool ヴィオラ_右_縁2_表示
    	{
    		get
    		{
    			return X0Y0_ヴィオラ_右_縁2.Dra;
    		}
    		set
    		{
    			X0Y0_ヴィオラ_右_縁2.Dra = value;
    			X0Y0_ヴィオラ_右_縁2.Hit = value;
    		}
    	}

    	public bool 首輪_革_表示
    	{
    		get
    		{
    			return X0Y0_首輪_革.Dra;
    		}
    		set
    		{
    			X0Y0_首輪_革.Dra = value;
    			X0Y0_首輪_革.Hit = value;
    		}
    	}

    	public bool 首輪_金具1_表示
    	{
    		get
    		{
    			return X0Y0_首輪_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_首輪_金具1.Dra = value;
    			X0Y0_首輪_金具1.Hit = value;
    		}
    	}

    	public bool 首輪_金具2_表示
    	{
    		get
    		{
    			return X0Y0_首輪_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_首輪_金具2.Dra = value;
    			X0Y0_首輪_金具2.Hit = value;
    		}
    	}

    	public bool 首輪_金具3_表示
    	{
    		get
    		{
    			return X0Y0_首輪_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_首輪_金具3.Dra = value;
    			X0Y0_首輪_金具3.Hit = value;
    		}
    	}

    	public bool 首輪_金具左_表示
    	{
    		get
    		{
    			return X0Y0_首輪_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_首輪_金具左.Dra = value;
    			X0Y0_首輪_金具左.Hit = value;
    		}
    	}

    	public bool 首輪_金具右_表示
    	{
    		get
    		{
    			return X0Y0_首輪_金具右.Dra;
    		}
    		set
    		{
    			X0Y0_首輪_金具右.Dra = value;
    			X0Y0_首輪_金具右.Hit = value;
    		}
    	}

    	public bool 首輪表示
    	{
    		get
    		{
    			return 首輪_革_表示;
    		}
    		set
    		{
    			首輪_革_表示 = value;
    			首輪_金具1_表示 = value;
    			首輪_金具2_表示 = value;
    			首輪_金具3_表示 = value;
    			首輪_金具左_表示 = value;
    			首輪_金具右_表示 = value;
    		}
    	}

    	public bool ヴィオラ襟ベース表示
    	{
    		get
    		{
    			return ヴィオラ_左_襟_表示;
    		}
    		set
    		{
    			ヴィオラ_左_襟_表示 = value;
    			ヴィオラ_右_襟_表示 = value;
    		}
    	}

    	public bool ヴィオラ縁表示
    	{
    		get
    		{
    			return ヴィオラ_左_縁1_表示;
    		}
    		set
    		{
    			ヴィオラ_左_縁1_表示 = value;
    			ヴィオラ_左_縁2_表示 = value;
    			ヴィオラ_右_縁1_表示 = value;
    			ヴィオラ_右_縁2_表示 = value;
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
    			return 植性_蔦_表示;
    		}
    		set
    		{
    			植性_蔦_表示 = value;
    			植性_棘左上_表示 = value;
    			植性_棘左下_表示 = value;
    			植性_棘右上_表示 = value;
    			植性_棘右下_表示 = value;
    			Neck_表示 = value;
    			淫タトゥ_ハート_タトゥ左_表示 = value;
    			淫タトゥ_ハート_タトゥ右_表示 = value;
    			淫タトゥ_タトゥ左_表示 = value;
    			淫タトゥ_タトゥ右_表示 = value;
    			悪タトゥ_文字_文字a_枠_表示 = value;
    			悪タトゥ_文字_文字a_文字タトゥ1_表示 = value;
    			悪タトゥ_文字_文字a_文字タトゥ2_表示 = value;
    			悪タトゥ_文字_文字b_枠_表示 = value;
    			悪タトゥ_文字_文字b_文字タトゥ1_表示 = value;
    			悪タトゥ_文字_文字b_文字タトゥ2_表示 = value;
    			悪タトゥ_文字_文字c_枠_表示 = value;
    			悪タトゥ_文字_文字c_文字タトゥ1_表示 = value;
    			悪タトゥ_文字_文字c_文字タトゥ2_表示 = value;
    			悪タトゥ_文字_文字d_枠_表示 = value;
    			悪タトゥ_文字_文字d_文字タトゥ1_表示 = value;
    			悪タトゥ_文字_文字d_文字タトゥ2_表示 = value;
    			悪タトゥ_文字_文字e_枠_表示 = value;
    			悪タトゥ_文字_文字e_文字タトゥ1_表示 = value;
    			悪タトゥ_文字_文字e_文字タトゥ2_表示 = value;
    			悪タトゥ_文字_文字e_文字タトゥ3_表示 = value;
    			悪タトゥ_タトゥ_表示 = value;
    			竜性_鱗1_表示 = value;
    			竜性_鱗2_表示 = value;
    			竜性_鱗3_表示 = value;
    			竜性_鱗4_表示 = value;
    			竜性_鱗5_表示 = value;
    			竜性_鱗6_表示 = value;
    			虫性_蛇腹4_表示 = value;
    			虫性_蛇腹3_表示 = value;
    			虫性_蛇腹2_表示 = value;
    			虫性_蛇腹1_表示 = value;
    			ヴィオラ_左_襟_表示 = value;
    			ヴィオラ_左_縁1_表示 = value;
    			ヴィオラ_左_縁2_表示 = value;
    			ヴィオラ_右_襟_表示 = value;
    			ヴィオラ_右_縁1_表示 = value;
    			ヴィオラ_右_縁2_表示 = value;
    			首輪_革_表示 = value;
    			首輪_金具1_表示 = value;
    			首輪_金具2_表示 = value;
    			首輪_金具3_表示 = value;
    			首輪_金具左_表示 = value;
    			首輪_金具右_表示 = value;
    			鎖1.表示 = value;
    			鎖2.表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 植性_蔦CD.不透明度;
    		}
    		set
    		{
    			植性_蔦CD.不透明度 = value;
    			植性_棘左上CD.不透明度 = value;
    			植性_棘左下CD.不透明度 = value;
    			植性_棘右上CD.不透明度 = value;
    			植性_棘右下CD.不透明度 = value;
    			NeckCD.不透明度 = value;
    			淫タトゥ_ハート_タトゥ左CD.不透明度 = value;
    			淫タトゥ_ハート_タトゥ右CD.不透明度 = value;
    			淫タトゥ_タトゥ左CD.不透明度 = value;
    			淫タトゥ_タトゥ右CD.不透明度 = value;
    			悪タトゥ_文字_文字a_枠CD.不透明度 = value;
    			悪タトゥ_文字_文字a_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字_文字a_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字_文字b_枠CD.不透明度 = value;
    			悪タトゥ_文字_文字b_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字_文字b_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字_文字c_枠CD.不透明度 = value;
    			悪タトゥ_文字_文字c_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字_文字c_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字_文字d_枠CD.不透明度 = value;
    			悪タトゥ_文字_文字d_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字_文字d_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字_文字e_枠CD.不透明度 = value;
    			悪タトゥ_文字_文字e_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字_文字e_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字_文字e_文字タトゥ3CD.不透明度 = value;
    			悪タトゥ_タトゥCD.不透明度 = value;
    			竜性_鱗1CD.不透明度 = value;
    			竜性_鱗2CD.不透明度 = value;
    			竜性_鱗3CD.不透明度 = value;
    			竜性_鱗4CD.不透明度 = value;
    			竜性_鱗5CD.不透明度 = value;
    			竜性_鱗6CD.不透明度 = value;
    			虫性_蛇腹4CD.不透明度 = value;
    			虫性_蛇腹3CD.不透明度 = value;
    			虫性_蛇腹2CD.不透明度 = value;
    			虫性_蛇腹1CD.不透明度 = value;
    			ヴィオラ_左_襟CD.不透明度 = value;
    			ヴィオラ_左_縁1CD.不透明度 = value;
    			ヴィオラ_左_縁2CD.不透明度 = value;
    			ヴィオラ_右_襟CD.不透明度 = value;
    			ヴィオラ_右_縁1CD.不透明度 = value;
    			ヴィオラ_右_縁2CD.不透明度 = value;
    			首輪_革CD.不透明度 = value;
    			首輪_金具1CD.不透明度 = value;
    			首輪_金具2CD.不透明度 = value;
    			首輪_金具3CD.不透明度 = value;
    			首輪_金具左CD.不透明度 = value;
    			首輪_金具右CD.不透明度 = value;
    		}
    	}

    	public JointS Head_接続点 => new JointS(Body, X0Y0_Neck, 0);

    	public JointS 鎖1_接続点 => new JointS(Body, X0Y0_首輪_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(Body, X0Y0_首輪_金具右, 0);

    	public Neck(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, NeckD e)
    	{
    		Neck Neck2 = this;
    		ThisType = GetType();
    		Body = new Difs(Sta.胴体["Neck"]);
    		Pars pars = Body[0][0];
    		Pars pars2 = pars["植性"].ToPars();
    		X0Y0_植性_蔦 = pars2["蔦"].ToPar();
    		X0Y0_植性_棘左上 = pars2["刺左上"].ToPar();
    		X0Y0_植性_棘左下 = pars2["刺左下"].ToPar();
    		X0Y0_植性_棘右上 = pars2["刺右上"].ToPar();
    		X0Y0_植性_棘右下 = pars2["刺右下"].ToPar();
    		X0Y0_Neck = pars["首"].ToPar();
    		pars2 = pars["淫タトゥ"].ToPars();
    		Pars pars3 = pars2["ハート"].ToPars();
    		X0Y0_淫タトゥ_ハート_タトゥ左 = pars3["タトゥ左"].ToPar();
    		X0Y0_淫タトゥ_ハート_タトゥ右 = pars3["タトゥ右"].ToPar();
    		X0Y0_淫タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
    		X0Y0_淫タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
    		pars2 = pars["悪タトゥ"].ToPars();
    		pars3 = pars2["文字"].ToPars();
    		Pars pars4 = pars3["文字a"].ToPars();
    		X0Y0_悪タトゥ_文字_文字a_枠 = pars4["枠"].ToPar();
    		X0Y0_悪タトゥ_文字_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_文字_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字b"].ToPars();
    		X0Y0_悪タトゥ_文字_文字b_枠 = pars4["枠"].ToPar();
    		X0Y0_悪タトゥ_文字_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_文字_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字c"].ToPars();
    		X0Y0_悪タトゥ_文字_文字c_枠 = pars4["枠"].ToPar();
    		X0Y0_悪タトゥ_文字_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_文字_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字d"].ToPars();
    		X0Y0_悪タトゥ_文字_文字d_枠 = pars4["枠"].ToPar();
    		X0Y0_悪タトゥ_文字_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_文字_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字e"].ToPars();
    		X0Y0_悪タトゥ_文字_文字e_枠 = pars4["枠"].ToPar();
    		X0Y0_悪タトゥ_文字_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_文字_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		X0Y0_悪タトゥ_文字_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
    		X0Y0_悪タトゥ_タトゥ = pars2["タトゥ"].ToPar();
    		pars2 = pars["鱗"].ToPars();
    		X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
    		X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
    		X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
    		X0Y0_竜性_鱗5 = pars2["鱗5"].ToPar();
    		X0Y0_竜性_鱗6 = pars2["鱗6"].ToPar();
    		pars2 = pars["虫性"].ToPars();
    		X0Y0_虫性_蛇腹4 = pars2["蛇腹4"].ToPar();
    		X0Y0_虫性_蛇腹3 = pars2["蛇腹3"].ToPar();
    		X0Y0_虫性_蛇腹2 = pars2["蛇腹2"].ToPar();
    		X0Y0_虫性_蛇腹1 = pars2["蛇腹1"].ToPar();
    		pars2 = pars["ヴィオラ"].ToPars();
    		pars3 = pars2["左"].ToPars();
    		X0Y0_ヴィオラ_左_襟 = pars3["襟"].ToPar();
    		X0Y0_ヴィオラ_左_縁1 = pars3["縁1"].ToPar();
    		X0Y0_ヴィオラ_左_縁2 = pars3["縁2"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y0_ヴィオラ_右_襟 = pars3["襟"].ToPar();
    		X0Y0_ヴィオラ_右_縁1 = pars3["縁1"].ToPar();
    		X0Y0_ヴィオラ_右_縁2 = pars3["縁2"].ToPar();
    		pars2 = pars["首輪"].ToPars();
    		X0Y0_首輪_革 = pars2["革"].ToPar();
    		X0Y0_首輪_金具1 = pars2["金具1"].ToPar();
    		X0Y0_首輪_金具2 = pars2["金具2"].ToPar();
    		X0Y0_首輪_金具3 = pars2["金具3"].ToPar();
    		X0Y0_首輪_金具左 = pars2["金具左"].ToPar();
    		X0Y0_首輪_金具右 = pars2["金具右"].ToPar();
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
    		植性_蔦_表示 = e.植性_蔦_表示;
    		植性_棘左上_表示 = e.植性_棘左上_表示;
    		植性_棘左下_表示 = e.植性_棘左下_表示;
    		植性_棘右上_表示 = e.植性_棘右上_表示;
    		植性_棘右下_表示 = e.植性_棘右下_表示;
    		Neck_表示 = e.Neck_表示;
    		淫タトゥ_ハート_タトゥ左_表示 = e.淫タトゥ_ハート_タトゥ左_表示;
    		淫タトゥ_ハート_タトゥ右_表示 = e.淫タトゥ_ハート_タトゥ右_表示;
    		淫タトゥ_タトゥ左_表示 = e.淫タトゥ_タトゥ左_表示;
    		淫タトゥ_タトゥ右_表示 = e.淫タトゥ_タトゥ右_表示;
    		悪タトゥ_文字_文字a_枠_表示 = e.悪タトゥ_文字_文字a_枠_表示;
    		悪タトゥ_文字_文字a_文字タトゥ1_表示 = e.悪タトゥ_文字_文字a_文字タトゥ1_表示;
    		悪タトゥ_文字_文字a_文字タトゥ2_表示 = e.悪タトゥ_文字_文字a_文字タトゥ2_表示;
    		悪タトゥ_文字_文字b_枠_表示 = e.悪タトゥ_文字_文字b_枠_表示;
    		悪タトゥ_文字_文字b_文字タトゥ1_表示 = e.悪タトゥ_文字_文字b_文字タトゥ1_表示;
    		悪タトゥ_文字_文字b_文字タトゥ2_表示 = e.悪タトゥ_文字_文字b_文字タトゥ2_表示;
    		悪タトゥ_文字_文字c_枠_表示 = e.悪タトゥ_文字_文字c_枠_表示;
    		悪タトゥ_文字_文字c_文字タトゥ1_表示 = e.悪タトゥ_文字_文字c_文字タトゥ1_表示;
    		悪タトゥ_文字_文字c_文字タトゥ2_表示 = e.悪タトゥ_文字_文字c_文字タトゥ2_表示;
    		悪タトゥ_文字_文字d_枠_表示 = e.悪タトゥ_文字_文字d_枠_表示;
    		悪タトゥ_文字_文字d_文字タトゥ1_表示 = e.悪タトゥ_文字_文字d_文字タトゥ1_表示;
    		悪タトゥ_文字_文字d_文字タトゥ2_表示 = e.悪タトゥ_文字_文字d_文字タトゥ2_表示;
    		悪タトゥ_文字_文字e_枠_表示 = e.悪タトゥ_文字_文字e_枠_表示;
    		悪タトゥ_文字_文字e_文字タトゥ1_表示 = e.悪タトゥ_文字_文字e_文字タトゥ1_表示;
    		悪タトゥ_文字_文字e_文字タトゥ2_表示 = e.悪タトゥ_文字_文字e_文字タトゥ2_表示;
    		悪タトゥ_文字_文字e_文字タトゥ3_表示 = e.悪タトゥ_文字_文字e_文字タトゥ3_表示;
    		悪タトゥ_タトゥ_表示 = e.悪タトゥ_タトゥ_表示;
    		竜性_鱗1_表示 = e.竜性_鱗1_表示;
    		竜性_鱗2_表示 = e.竜性_鱗2_表示;
    		竜性_鱗3_表示 = e.竜性_鱗3_表示;
    		竜性_鱗4_表示 = e.竜性_鱗4_表示;
    		竜性_鱗5_表示 = e.竜性_鱗5_表示;
    		竜性_鱗6_表示 = e.竜性_鱗6_表示;
    		虫性_蛇腹4_表示 = e.虫性_蛇腹4_表示;
    		虫性_蛇腹3_表示 = e.虫性_蛇腹3_表示;
    		虫性_蛇腹2_表示 = e.虫性_蛇腹2_表示;
    		虫性_蛇腹1_表示 = e.虫性_蛇腹1_表示;
    		ヴィオラ_左_襟_表示 = e.ヴィオラ_左_襟_表示;
    		ヴィオラ_左_縁1_表示 = e.ヴィオラ_左_縁1_表示;
    		ヴィオラ_左_縁2_表示 = e.ヴィオラ_左_縁2_表示;
    		ヴィオラ_右_襟_表示 = e.ヴィオラ_右_襟_表示;
    		ヴィオラ_右_縁1_表示 = e.ヴィオラ_右_縁1_表示;
    		ヴィオラ_右_縁2_表示 = e.ヴィオラ_右_縁2_表示;
    		首輪_革_表示 = e.首輪_革_表示;
    		首輪_金具1_表示 = e.首輪_金具1_表示;
    		首輪_金具2_表示 = e.首輪_金具2_表示;
    		首輪_金具3_表示 = e.首輪_金具3_表示;
    		首輪_金具左_表示 = e.首輪_金具左_表示;
    		首輪_金具右_表示 = e.首輪_金具右_表示;
    		首輪表示 = e.首輪表示;
    		ヴィオラ襟ベース表示 = e.ヴィオラ襟ベース表示;
    		ヴィオラ縁表示 = e.ヴィオラ縁表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.Head_接続.Count > 0)
    		{
    			Ele f;
    			Head_接続 = e.Head_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Neck2;
    				f.ConnectionType = ConnectionInfo.Neck_Head_接続;
    				f.接続(Neck2.Head_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_植性_蔦CP = new ColorP(X0Y0_植性_蔦, 植性_蔦CD, DisUnit, abj: true);
    		X0Y0_植性_棘左上CP = new ColorP(X0Y0_植性_棘左上, 植性_棘左上CD, DisUnit, abj: true);
    		X0Y0_植性_棘左下CP = new ColorP(X0Y0_植性_棘左下, 植性_棘左下CD, DisUnit, abj: true);
    		X0Y0_植性_棘右上CP = new ColorP(X0Y0_植性_棘右上, 植性_棘右上CD, DisUnit, abj: true);
    		X0Y0_植性_棘右下CP = new ColorP(X0Y0_植性_棘右下, 植性_棘右下CD, DisUnit, abj: true);
    		X0Y0_NeckCP = new ColorP(X0Y0_Neck, NeckCD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_ハート_タトゥ左CP = new ColorP(X0Y0_淫タトゥ_ハート_タトゥ左, 淫タトゥ_ハート_タトゥ左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_ハート_タトゥ右CP = new ColorP(X0Y0_淫タトゥ_ハート_タトゥ右, 淫タトゥ_ハート_タトゥ右CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_タトゥ左CP = new ColorP(X0Y0_淫タトゥ_タトゥ左, 淫タトゥ_タトゥ左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_タトゥ右CP = new ColorP(X0Y0_淫タトゥ_タトゥ右, 淫タトゥ_タトゥ右CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_文字_文字a_枠CP = new ColorP(X0Y0_悪タトゥ_文字_文字a_枠, 悪タトゥ_文字_文字a_枠CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字a_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_文字_文字a_文字タトゥ1, 悪タトゥ_文字_文字a_文字タトゥ1CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字a_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_文字_文字a_文字タトゥ2, 悪タトゥ_文字_文字a_文字タトゥ2CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字b_枠CP = new ColorP(X0Y0_悪タトゥ_文字_文字b_枠, 悪タトゥ_文字_文字b_枠CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字b_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_文字_文字b_文字タトゥ1, 悪タトゥ_文字_文字b_文字タトゥ1CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字b_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_文字_文字b_文字タトゥ2, 悪タトゥ_文字_文字b_文字タトゥ2CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字c_枠CP = new ColorP(X0Y0_悪タトゥ_文字_文字c_枠, 悪タトゥ_文字_文字c_枠CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字c_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_文字_文字c_文字タトゥ1, 悪タトゥ_文字_文字c_文字タトゥ1CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字c_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_文字_文字c_文字タトゥ2, 悪タトゥ_文字_文字c_文字タトゥ2CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字d_枠CP = new ColorP(X0Y0_悪タトゥ_文字_文字d_枠, 悪タトゥ_文字_文字d_枠CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字d_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_文字_文字d_文字タトゥ1, 悪タトゥ_文字_文字d_文字タトゥ1CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字d_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_文字_文字d_文字タトゥ2, 悪タトゥ_文字_文字d_文字タトゥ2CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字e_枠CP = new ColorP(X0Y0_悪タトゥ_文字_文字e_枠, 悪タトゥ_文字_文字e_枠CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字e_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_文字_文字e_文字タトゥ1, 悪タトゥ_文字_文字e_文字タトゥ1CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字e_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_文字_文字e_文字タトゥ2, 悪タトゥ_文字_文字e_文字タトゥ2CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_文字_文字e_文字タトゥ3CP = new ColorP(X0Y0_悪タトゥ_文字_文字e_文字タトゥ3, 悪タトゥ_文字_文字e_文字タトゥ3CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_タトゥCP = new ColorP(X0Y0_悪タトゥ_タトゥ, 悪タトゥ_タトゥCD, DisUnit, abj: true);
    		X0Y0_竜性_鱗1CP = new ColorP(X0Y0_竜性_鱗1, 竜性_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗2CP = new ColorP(X0Y0_竜性_鱗2, 竜性_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗3CP = new ColorP(X0Y0_竜性_鱗3, 竜性_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗4CP = new ColorP(X0Y0_竜性_鱗4, 竜性_鱗4CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗5CP = new ColorP(X0Y0_竜性_鱗5, 竜性_鱗5CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗6CP = new ColorP(X0Y0_竜性_鱗6, 竜性_鱗6CD, DisUnit, abj: true);
    		X0Y0_虫性_蛇腹4CP = new ColorP(X0Y0_虫性_蛇腹4, 虫性_蛇腹4CD, DisUnit, abj: true);
    		X0Y0_虫性_蛇腹3CP = new ColorP(X0Y0_虫性_蛇腹3, 虫性_蛇腹3CD, DisUnit, abj: true);
    		X0Y0_虫性_蛇腹2CP = new ColorP(X0Y0_虫性_蛇腹2, 虫性_蛇腹2CD, DisUnit, abj: true);
    		X0Y0_虫性_蛇腹1CP = new ColorP(X0Y0_虫性_蛇腹1, 虫性_蛇腹1CD, DisUnit, abj: true);
    		X0Y0_ヴィオラ_左_襟CP = new ColorP(X0Y0_ヴィオラ_左_襟, ヴィオラ_左_襟CD, DisUnit, abj: true);
    		X0Y0_ヴィオラ_左_縁1CP = new ColorP(X0Y0_ヴィオラ_左_縁1, ヴィオラ_左_縁1CD, DisUnit, abj: true);
    		X0Y0_ヴィオラ_左_縁2CP = new ColorP(X0Y0_ヴィオラ_左_縁2, ヴィオラ_左_縁2CD, DisUnit, abj: true);
    		X0Y0_ヴィオラ_右_襟CP = new ColorP(X0Y0_ヴィオラ_右_襟, ヴィオラ_右_襟CD, DisUnit, abj: true);
    		X0Y0_ヴィオラ_右_縁1CP = new ColorP(X0Y0_ヴィオラ_右_縁1, ヴィオラ_右_縁1CD, DisUnit, abj: true);
    		X0Y0_ヴィオラ_右_縁2CP = new ColorP(X0Y0_ヴィオラ_右_縁2, ヴィオラ_右_縁2CD, DisUnit, abj: true);
    		X0Y0_首輪_革CP = new ColorP(X0Y0_首輪_革, 首輪_革CD, DisUnit, abj: true);
    		X0Y0_首輪_金具1CP = new ColorP(X0Y0_首輪_金具1, 首輪_金具1CD, DisUnit, abj: true);
    		X0Y0_首輪_金具2CP = new ColorP(X0Y0_首輪_金具2, 首輪_金具2CD, DisUnit, abj: true);
    		X0Y0_首輪_金具3CP = new ColorP(X0Y0_首輪_金具3, 首輪_金具3CD, DisUnit, abj: true);
    		X0Y0_首輪_金具左CP = new ColorP(X0Y0_首輪_金具左, 首輪_金具左CD, DisUnit, abj: true);
    		X0Y0_首輪_金具右CP = new ColorP(X0Y0_首輪_金具右, 首輪_金具右CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		鎖1 = new 拘束鎖(DisUnit, 右, 配色指定, 体配色, Xasix);
    		鎖2 = new 拘束鎖(DisUnit, !右, 配色指定, 体配色, Xasix);
    		鎖1.接続(鎖1_接続点);
    		鎖2.接続(鎖2_接続点);
    		int num = (右 ? (-10) : 10);
    		鎖1.角度B += num;
    		鎖2.角度B -= num;
    		鎖表示 = e.鎖表示;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_植性_蔦);
    		Are.Draw(X0Y0_植性_棘左上);
    		Are.Draw(X0Y0_植性_棘左下);
    		Are.Draw(X0Y0_植性_棘右上);
    		Are.Draw(X0Y0_植性_棘右下);
    		Are.Draw(X0Y0_Neck);
    		Are.Draw(X0Y0_虫性_蛇腹4);
    		Are.Draw(X0Y0_虫性_蛇腹3);
    		Are.Draw(X0Y0_虫性_蛇腹2);
    		Are.Draw(X0Y0_虫性_蛇腹1);
    		Are.Draw(X0Y0_竜性_鱗1);
    		Are.Draw(X0Y0_竜性_鱗2);
    		Are.Draw(X0Y0_竜性_鱗3);
    		Are.Draw(X0Y0_竜性_鱗4);
    		Are.Draw(X0Y0_竜性_鱗5);
    		Are.Draw(X0Y0_竜性_鱗6);
    		Are.Draw(X0Y0_淫タトゥ_ハート_タトゥ左);
    		Are.Draw(X0Y0_淫タトゥ_ハート_タトゥ右);
    		Are.Draw(X0Y0_淫タトゥ_タトゥ左);
    		Are.Draw(X0Y0_淫タトゥ_タトゥ右);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字a_枠);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字a_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字a_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字b_枠);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字b_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字b_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字c_枠);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字c_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字c_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字d_枠);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字d_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字d_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字e_枠);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字e_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字e_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_文字_文字e_文字タトゥ3);
    		Are.Draw(X0Y0_悪タトゥ_タトゥ);
    		キスマーク.Draw(Are);
    		鞭痕.Draw(Are);
    		Are.Draw(X0Y0_ヴィオラ_左_襟);
    		Are.Draw(X0Y0_ヴィオラ_左_縁1);
    		Are.Draw(X0Y0_ヴィオラ_左_縁2);
    		Are.Draw(X0Y0_ヴィオラ_右_襟);
    		Are.Draw(X0Y0_ヴィオラ_右_縁1);
    		Are.Draw(X0Y0_ヴィオラ_右_縁2);
    		Are.Draw(X0Y0_首輪_革);
    		Are.Draw(X0Y0_首輪_金具1);
    		Are.Draw(X0Y0_首輪_金具2);
    		Are.Draw(X0Y0_首輪_金具3);
    		Are.Draw(X0Y0_首輪_金具左);
    		Are.Draw(X0Y0_首輪_金具右);
    		鎖1.描画0(Are);
    		鎖2.描画0(Are);
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    		鎖2.Dispose();
    	}

    	public override bool Is布(ShapePart p)
    	{
    		if (p != X0Y0_ヴィオラ_左_襟 && p != X0Y0_ヴィオラ_左_縁1 && p != X0Y0_ヴィオラ_左_縁2 && p != X0Y0_ヴィオラ_右_襟 && p != X0Y0_ヴィオラ_右_縁1)
    		{
    			return p == X0Y0_ヴィオラ_右_縁2;
    		}
    		return true;
    	}

    	public override bool Is革(ShapePart p)
    	{
    		if (p != X0Y0_首輪_革 && p != X0Y0_首輪_金具1 && p != X0Y0_首輪_金具2 && p != X0Y0_首輪_金具3 && p != X0Y0_首輪_金具左)
    		{
    			return p == X0Y0_首輪_金具右;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_植性_蔦CP.Update();
    		X0Y0_植性_棘左上CP.Update();
    		X0Y0_植性_棘左下CP.Update();
    		X0Y0_植性_棘右上CP.Update();
    		X0Y0_植性_棘右下CP.Update();
    		X0Y0_NeckCP.Update();
    		X0Y0_淫タトゥ_ハート_タトゥ左CP.Update();
    		X0Y0_淫タトゥ_ハート_タトゥ右CP.Update();
    		X0Y0_淫タトゥ_タトゥ左CP.Update();
    		X0Y0_淫タトゥ_タトゥ右CP.Update();
    		X0Y0_悪タトゥ_文字_文字a_枠CP.Update();
    		X0Y0_悪タトゥ_文字_文字a_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_文字_文字a_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_文字_文字b_枠CP.Update();
    		X0Y0_悪タトゥ_文字_文字b_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_文字_文字b_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_文字_文字c_枠CP.Update();
    		X0Y0_悪タトゥ_文字_文字c_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_文字_文字c_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_文字_文字d_枠CP.Update();
    		X0Y0_悪タトゥ_文字_文字d_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_文字_文字d_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_文字_文字e_枠CP.Update();
    		X0Y0_悪タトゥ_文字_文字e_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_文字_文字e_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_文字_文字e_文字タトゥ3CP.Update();
    		X0Y0_悪タトゥ_タトゥCP.Update();
    		X0Y0_竜性_鱗1CP.Update();
    		X0Y0_竜性_鱗2CP.Update();
    		X0Y0_竜性_鱗3CP.Update();
    		X0Y0_竜性_鱗4CP.Update();
    		X0Y0_竜性_鱗5CP.Update();
    		X0Y0_竜性_鱗6CP.Update();
    		X0Y0_虫性_蛇腹4CP.Update();
    		X0Y0_虫性_蛇腹3CP.Update();
    		X0Y0_虫性_蛇腹2CP.Update();
    		X0Y0_虫性_蛇腹1CP.Update();
    		X0Y0_ヴィオラ_左_襟CP.Update();
    		X0Y0_ヴィオラ_左_縁1CP.Update();
    		X0Y0_ヴィオラ_左_縁2CP.Update();
    		X0Y0_ヴィオラ_右_襟CP.Update();
    		X0Y0_ヴィオラ_右_縁1CP.Update();
    		X0Y0_ヴィオラ_右_縁2CP.Update();
    		X0Y0_首輪_革CP.Update();
    		X0Y0_首輪_金具1CP.Update();
    		X0Y0_首輪_金具2CP.Update();
    		X0Y0_首輪_金具3CP.Update();
    		X0Y0_首輪_金具左CP.Update();
    		X0Y0_首輪_金具右CP.Update();
    		鎖1.接続PA();
    		鎖2.接続PA();
    		鎖1.色更新();
    		鎖2.色更新();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		植性_蔦CD = new ColorD(ref Col.Black, ref 体配色.植0O);
    		植性_棘左上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性_棘左下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性_棘右上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性_棘右下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		NeckCD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		淫タトゥ_ハート_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		悪タトゥ_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		虫性_蛇腹4CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫性_蛇腹3CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫性_蛇腹2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫性_蛇腹1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		ヴィオラ_左_襟CD = new ColorD();
    		ヴィオラ_左_縁1CD = new ColorD();
    		ヴィオラ_左_縁2CD = new ColorD();
    		ヴィオラ_右_襟CD = new ColorD();
    		ヴィオラ_右_縁1CD = new ColorD();
    		ヴィオラ_右_縁2CD = new ColorD();
    		首輪_革CD = new ColorD();
    		首輪_金具1CD = new ColorD();
    		首輪_金具2CD = new ColorD();
    		首輪_金具3CD = new ColorD();
    		首輪_金具左CD = new ColorD();
    		首輪_金具右CD = new ColorD();
    	}

    	public void ドレス配色(ドレス首色 配色)
    	{
    		ヴィオラ_左_襟CD.色 = 配色.生地色;
    		ヴィオラ_左_縁1CD.色 = 配色.縁色;
    		ヴィオラ_左_縁2CD.色 = ヴィオラ_左_縁1CD.色;
    		ヴィオラ_右_襟CD.色 = ヴィオラ_左_襟CD.色;
    		ヴィオラ_右_縁1CD.色 = ヴィオラ_左_縁1CD.色;
    		ヴィオラ_右_縁2CD.色 = ヴィオラ_左_縁1CD.色;
    	}

    	public void 首輪配色(拘束具色 配色)
    	{
    		首輪_革CD.色 = 配色.革部色;
    		首輪_金具1CD.色 = 配色.金具色;
    		首輪_金具2CD.色 = 首輪_金具1CD.色;
    		首輪_金具3CD.色 = 首輪_金具1CD.色;
    		首輪_金具左CD.色 = 首輪_金具1CD.色;
    		首輪_金具右CD.色 = 首輪_金具1CD.色;
    	}

    	public void 鎖配色(鎖色 配色)
    	{
    		鎖1.配色鎖(配色);
    		鎖2.配色鎖(配色);
    	}
    }
}
