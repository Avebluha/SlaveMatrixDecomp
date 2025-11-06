using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 上腕_人 : 上腕
    {
    	public Par X0Y0_筋肉上;

    	public Par X0Y0_上腕;

    	public Par X0Y0_筋肉下;

    	public Par X0Y0_虫性_虫腕;

    	public Par X0Y0_虫性_筋肉下;

    	public Par X0Y0_紋柄_紋1;

    	public Par X0Y0_紋柄_紋2;

    	public Par X0Y0_紋柄_紋3;

    	public Par X0Y0_紋柄_紋4;

    	public Par X0Y0_獣性_獣毛1;

    	public Par X0Y0_獣性_獣毛2;

    	public Par X0Y0_竜性_鱗4;

    	public Par X0Y0_竜性_鱗3;

    	public Par X0Y0_竜性_鱗2;

    	public Par X0Y0_竜性_鱗1;

    	public Par X0Y0_竜性_鱗5;

    	public Par X0Y0_淫タトゥ_ハート_タトゥ左;

    	public Par X0Y0_淫タトゥ_ハート_タトゥ右;

    	public Par X0Y0_淫タトゥ_タトゥ1;

    	public Par X0Y0_淫タトゥ_タトゥ2;

    	public Par X0Y0_淫タトゥ_タトゥ3;

    	public Par X0Y0_淫タトゥ_タトゥ4;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字a_枠;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字b_枠;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字c_枠;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字d_枠;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字e_枠;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字a_枠;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字b_枠;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字c_枠;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字d_枠;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字e_枠;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3;

    	public Par X0Y0_悪タトゥ_通常_タトゥ1;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字a_枠;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字b_枠;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字c_枠;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字d_枠;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字e_枠;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字a_枠;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字b_枠;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字c_枠;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字d_枠;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字e_枠;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2;

    	public Par X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3;

    	public Par X0Y0_悪タトゥ_筋肉_タトゥ1;

    	public Par X0Y0_悪タトゥ_タトゥ2;

    	public Par X0Y0_植タトゥ_タトゥ;

    	public Par X0Y0_植性_通常_葉3;

    	public Par X0Y0_植性_通常_葉2;

    	public Par X0Y0_植性_通常_葉1;

    	public Par X0Y0_植性_欠損_葉3;

    	public Par X0Y0_植性_欠損_葉2;

    	public Par X0Y0_植性_欠損_葉1;

    	public Par X0Y0_傷X;

    	public Par X0Y0_ハイライト_ハイライト1;

    	public Par X0Y0_ハイライト_ハイライト2;

    	public Par X0Y0_グローブ_通常_グローブ;

    	public Par X0Y0_グローブ_通常_縁;

    	public Par X0Y0_グローブ_筋肉_グローブ;

    	public Par X0Y0_グローブ_筋肉_縁;

    	public Par X0Y0_シャツ_袖1;

    	public Par X0Y0_シャツ_袖2;

    	public Par X0Y0_シャツ_縁;

    	public Par X0Y0_ナース_袖1;

    	public Par X0Y0_ナース_袖2;

    	public Par X0Y0_ナース_縁;

    	public Par X0Y0_鎧_ベルト_ベルト1;

    	public Par X0Y0_鎧_ベルト_ベルト2;

    	public Par X0Y0_鎧_鎧_鎧1;

    	public Par X0Y0_鎧_鎧_鎧2;

    	public ColorD 筋肉上CD;

    	public ColorD 上腕CD;

    	public ColorD 筋肉下CD;

    	public ColorD 虫性_虫腕CD;

    	public ColorD 虫性_筋肉下CD;

    	public ColorD 紋柄_紋1CD;

    	public ColorD 紋柄_紋2CD;

    	public ColorD 紋柄_紋3CD;

    	public ColorD 紋柄_紋4CD;

    	public ColorD 獣性_獣毛1CD;

    	public ColorD 獣性_獣毛2CD;

    	public ColorD 竜性_鱗4CD;

    	public ColorD 竜性_鱗3CD;

    	public ColorD 竜性_鱗2CD;

    	public ColorD 竜性_鱗1CD;

    	public ColorD 竜性_鱗5CD;

    	public ColorD 淫タトゥ_ハート_タトゥ左CD;

    	public ColorD 淫タトゥ_ハート_タトゥ右CD;

    	public ColorD 淫タトゥ_タトゥ1CD;

    	public ColorD 淫タトゥ_タトゥ2CD;

    	public ColorD 淫タトゥ_タトゥ3CD;

    	public ColorD 淫タトゥ_タトゥ4CD;

    	public ColorD 悪タトゥ_文字1_文字a_枠CD;

    	public ColorD 悪タトゥ_文字1_文字a_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字1_文字a_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字1_文字b_枠CD;

    	public ColorD 悪タトゥ_文字1_文字b_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字1_文字b_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字1_文字c_枠CD;

    	public ColorD 悪タトゥ_文字1_文字c_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字1_文字c_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字1_文字d_枠CD;

    	public ColorD 悪タトゥ_文字1_文字d_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字1_文字d_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字1_文字e_枠CD;

    	public ColorD 悪タトゥ_文字1_文字e_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字1_文字e_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字1_文字e_文字タトゥ3CD;

    	public ColorD 悪タトゥ_文字2_文字a_枠CD;

    	public ColorD 悪タトゥ_文字2_文字a_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字2_文字a_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字2_文字b_枠CD;

    	public ColorD 悪タトゥ_文字2_文字b_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字2_文字b_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字2_文字c_枠CD;

    	public ColorD 悪タトゥ_文字2_文字c_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字2_文字c_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字2_文字d_枠CD;

    	public ColorD 悪タトゥ_文字2_文字d_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字2_文字d_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字2_文字e_枠CD;

    	public ColorD 悪タトゥ_文字2_文字e_文字タトゥ1CD;

    	public ColorD 悪タトゥ_文字2_文字e_文字タトゥ2CD;

    	public ColorD 悪タトゥ_文字2_文字e_文字タトゥ3CD;

    	public ColorD 悪タトゥ_タトゥ1CD;

    	public ColorD 悪タトゥ_タトゥ2CD;

    	public ColorD 植タトゥ_タトゥCD;

    	public ColorD 植性_葉3CD;

    	public ColorD 植性_葉2CD;

    	public ColorD 植性_葉1CD;

    	public ColorD 傷XCD;

    	public ColorD ハイライト_ハイライト1CD;

    	public ColorD ハイライト_ハイライト2CD;

    	public ColorD グローブ_グローブCD;

    	public ColorD グローブ_縁CD;

    	public ColorD シャツ_袖1CD;

    	public ColorD シャツ_袖2CD;

    	public ColorD シャツ_縁CD;

    	public ColorD ナース_袖1CD;

    	public ColorD ナース_袖2CD;

    	public ColorD ナース_縁CD;

    	public ColorD 鎧_ベルト_ベルト1CD;

    	public ColorD 鎧_ベルト_ベルト2CD;

    	public ColorD 鎧_鎧_鎧1CD;

    	public ColorD 鎧_鎧_鎧2CD;

    	public ColorP X0Y0_筋肉上CP;

    	public ColorP X0Y0_上腕CP;

    	public ColorP X0Y0_筋肉下CP;

    	public ColorP X0Y0_虫性_虫腕CP;

    	public ColorP X0Y0_虫性_筋肉下CP;

    	public ColorP X0Y0_紋柄_紋1CP;

    	public ColorP X0Y0_紋柄_紋2CP;

    	public ColorP X0Y0_紋柄_紋3CP;

    	public ColorP X0Y0_紋柄_紋4CP;

    	public ColorP X0Y0_獣性_獣毛1CP;

    	public ColorP X0Y0_獣性_獣毛2CP;

    	public ColorP X0Y0_鱗_鱗4CP;

    	public ColorP X0Y0_鱗_鱗3CP;

    	public ColorP X0Y0_鱗_鱗2CP;

    	public ColorP X0Y0_鱗_鱗1CP;

    	public ColorP X0Y0_鱗_鱗5CP;

    	public ColorP X0Y0_淫タトゥ_ハート_タトゥ左CP;

    	public ColorP X0Y0_淫タトゥ_ハート_タトゥ右CP;

    	public ColorP X0Y0_淫タトゥ_タトゥ1CP;

    	public ColorP X0Y0_淫タトゥ_タトゥ2CP;

    	public ColorP X0Y0_淫タトゥ_タトゥ3CP;

    	public ColorP X0Y0_淫タトゥ_タトゥ4CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字a_枠CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字b_枠CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字c_枠CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字d_枠CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字e_枠CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字a_枠CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字b_枠CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字c_枠CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字d_枠CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字e_枠CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3CP;

    	public ColorP X0Y0_悪タトゥ_通常_タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字a_枠CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字b_枠CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字c_枠CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字d_枠CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字e_枠CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字a_枠CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字b_枠CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字c_枠CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字d_枠CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字e_枠CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ_タトゥ2CP;

    	public ColorP X0Y0_植タトゥ_タトゥCP;

    	public ColorP X0Y0_植性_通常_葉3CP;

    	public ColorP X0Y0_植性_通常_葉2CP;

    	public ColorP X0Y0_植性_通常_葉1CP;

    	public ColorP X0Y0_植性_欠損_葉3CP;

    	public ColorP X0Y0_植性_欠損_葉2CP;

    	public ColorP X0Y0_植性_欠損_葉1CP;

    	public ColorP X0Y0_傷XCP;

    	public ColorP X0Y0_ハイライト_ハイライト1CP;

    	public ColorP X0Y0_ハイライト_ハイライト2CP;

    	public ColorP X0Y0_グローブ_通常_グローブCP;

    	public ColorP X0Y0_グローブ_通常_縁CP;

    	public ColorP X0Y0_グローブ_筋肉_グローブCP;

    	public ColorP X0Y0_グローブ_筋肉_縁CP;

    	public ColorP X0Y0_シャツ_袖1CP;

    	public ColorP X0Y0_シャツ_袖2CP;

    	public ColorP X0Y0_シャツ_縁CP;

    	public ColorP X0Y0_ナース_袖1CP;

    	public ColorP X0Y0_ナース_袖2CP;

    	public ColorP X0Y0_ナース_縁CP;

    	public ColorP X0Y0_鎧_ベルト_ベルト1CP;

    	public ColorP X0Y0_鎧_ベルト_ベルト2CP;

    	public ColorP X0Y0_鎧_鎧_鎧1CP;

    	public ColorP X0Y0_鎧_鎧_鎧2CP;

    	public スタンプK キスマーク;

    	public スタンプW 鞭痕;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    			植性_葉3_表示 = 植性_葉3_表示;
    			植性_葉2_表示 = 植性_葉2_表示;
    			植性_葉1_表示 = 植性_葉1_表示;
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
    			筋肉上_表示 = 筋肉_;
    			筋肉下_表示 = 筋肉_;
    			虫性_筋肉下_表示 = 虫性_虫腕_表示 && 筋肉_;
    			悪タトゥ_文字1_文字a_枠_表示 = 悪タトゥ_文字1_文字a_枠_表示;
    			悪タトゥ_文字1_文字a_文字タトゥ1_表示 = 悪タトゥ_文字1_文字a_文字タトゥ1_表示;
    			悪タトゥ_文字1_文字a_文字タトゥ2_表示 = 悪タトゥ_文字1_文字a_文字タトゥ2_表示;
    			悪タトゥ_文字1_文字b_枠_表示 = 悪タトゥ_文字1_文字b_枠_表示;
    			悪タトゥ_文字1_文字b_文字タトゥ1_表示 = 悪タトゥ_文字1_文字b_文字タトゥ1_表示;
    			悪タトゥ_文字1_文字b_文字タトゥ2_表示 = 悪タトゥ_文字1_文字b_文字タトゥ2_表示;
    			悪タトゥ_文字1_文字c_枠_表示 = 悪タトゥ_文字1_文字c_枠_表示;
    			悪タトゥ_文字1_文字c_文字タトゥ1_表示 = 悪タトゥ_文字1_文字c_文字タトゥ1_表示;
    			悪タトゥ_文字1_文字c_文字タトゥ2_表示 = 悪タトゥ_文字1_文字c_文字タトゥ2_表示;
    			悪タトゥ_文字1_文字d_枠_表示 = 悪タトゥ_文字1_文字d_枠_表示;
    			悪タトゥ_文字1_文字d_文字タトゥ1_表示 = 悪タトゥ_文字1_文字d_文字タトゥ1_表示;
    			悪タトゥ_文字1_文字d_文字タトゥ2_表示 = 悪タトゥ_文字1_文字d_文字タトゥ2_表示;
    			悪タトゥ_文字1_文字e_枠_表示 = 悪タトゥ_文字1_文字e_枠_表示;
    			悪タトゥ_文字1_文字e_文字タトゥ1_表示 = 悪タトゥ_文字1_文字e_文字タトゥ1_表示;
    			悪タトゥ_文字1_文字e_文字タトゥ2_表示 = 悪タトゥ_文字1_文字e_文字タトゥ2_表示;
    			悪タトゥ_文字1_文字e_文字タトゥ3_表示 = 悪タトゥ_文字1_文字e_文字タトゥ3_表示;
    			悪タトゥ_文字2_文字a_枠_表示 = 悪タトゥ_文字2_文字a_枠_表示;
    			悪タトゥ_文字2_文字a_文字タトゥ1_表示 = 悪タトゥ_文字2_文字a_文字タトゥ1_表示;
    			悪タトゥ_文字2_文字a_文字タトゥ2_表示 = 悪タトゥ_文字2_文字a_文字タトゥ2_表示;
    			悪タトゥ_文字2_文字b_枠_表示 = 悪タトゥ_文字2_文字b_枠_表示;
    			悪タトゥ_文字2_文字b_文字タトゥ1_表示 = 悪タトゥ_文字2_文字b_文字タトゥ1_表示;
    			悪タトゥ_文字2_文字b_文字タトゥ2_表示 = 悪タトゥ_文字2_文字b_文字タトゥ2_表示;
    			悪タトゥ_文字2_文字c_枠_表示 = 悪タトゥ_文字2_文字c_枠_表示;
    			悪タトゥ_文字2_文字c_文字タトゥ1_表示 = 悪タトゥ_文字2_文字c_文字タトゥ1_表示;
    			悪タトゥ_文字2_文字c_文字タトゥ2_表示 = 悪タトゥ_文字2_文字c_文字タトゥ2_表示;
    			悪タトゥ_文字2_文字d_枠_表示 = 悪タトゥ_文字2_文字d_枠_表示;
    			悪タトゥ_文字2_文字d_文字タトゥ1_表示 = 悪タトゥ_文字2_文字d_文字タトゥ1_表示;
    			悪タトゥ_文字2_文字d_文字タトゥ2_表示 = 悪タトゥ_文字2_文字d_文字タトゥ2_表示;
    			悪タトゥ_文字2_文字e_枠_表示 = 悪タトゥ_文字2_文字e_枠_表示;
    			悪タトゥ_文字2_文字e_文字タトゥ1_表示 = 悪タトゥ_文字2_文字e_文字タトゥ1_表示;
    			悪タトゥ_文字2_文字e_文字タトゥ2_表示 = 悪タトゥ_文字2_文字e_文字タトゥ2_表示;
    			悪タトゥ_文字2_文字e_文字タトゥ3_表示 = 悪タトゥ_文字2_文字e_文字タトゥ3_表示;
    			悪タトゥ_タトゥ1_表示 = 悪タトゥ_タトゥ1_表示;
    			グローブ_グローブ_表示 = グローブ_グローブ_表示;
    			グローブ_縁_表示 = グローブ_縁_表示;
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

    	public bool 筋肉上_表示
    	{
    		get
    		{
    			return X0Y0_筋肉上.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉上.Dra = value;
    			X0Y0_筋肉上.Hit = value;
    		}
    	}

    	public bool 上腕_表示
    	{
    		get
    		{
    			return X0Y0_上腕.Dra;
    		}
    		set
    		{
    			X0Y0_上腕.Dra = value;
    			X0Y0_上腕.Hit = value;
    		}
    	}

    	public bool 虫性_虫腕_表示
    	{
    		get
    		{
    			return X0Y0_虫性_虫腕.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_虫腕.Dra = value;
    			X0Y0_虫性_筋肉下.Dra = 筋肉フラグ && value;
    			X0Y0_虫性_虫腕.Hit = value;
    			X0Y0_虫性_筋肉下.Hit = 筋肉フラグ && value;
    		}
    	}

    	public bool 虫性_筋肉下_表示
    	{
    		get
    		{
    			return X0Y0_虫性_筋肉下.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_筋肉下.Dra = value;
    			X0Y0_虫性_筋肉下.Hit = value;
    		}
    	}

    	public bool 筋肉下_表示
    	{
    		get
    		{
    			return X0Y0_筋肉下.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉下.Dra = value;
    			X0Y0_筋肉下.Hit = value;
    		}
    	}

    	public bool 紋柄_紋1_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋1.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋1.Dra = value;
    			X0Y0_紋柄_紋1.Hit = value;
    		}
    	}

    	public bool 紋柄_紋2_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋2.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋2.Dra = value;
    			X0Y0_紋柄_紋2.Hit = value;
    		}
    	}

    	public bool 紋柄_紋3_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋3.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋3.Dra = value;
    			X0Y0_紋柄_紋3.Hit = value;
    		}
    	}

    	public bool 紋柄_紋4_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋4.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋4.Dra = value;
    			X0Y0_紋柄_紋4.Hit = value;
    		}
    	}

    	public bool 獣性_獣毛1_表示
    	{
    		get
    		{
    			return X0Y0_獣性_獣毛1.Dra;
    		}
    		set
    		{
    			X0Y0_獣性_獣毛1.Dra = value;
    			X0Y0_獣性_獣毛1.Hit = value;
    		}
    	}

    	public bool 獣性_獣毛2_表示
    	{
    		get
    		{
    			return X0Y0_獣性_獣毛2.Dra;
    		}
    		set
    		{
    			X0Y0_獣性_獣毛2.Dra = value;
    			X0Y0_獣性_獣毛2.Hit = value;
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

    	public bool 淫タトゥ_タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_タトゥ1.Dra = value;
    			X0Y0_淫タトゥ_タトゥ1.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_タトゥ2.Dra = value;
    			X0Y0_淫タトゥ_タトゥ2.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_タトゥ3_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_タトゥ3.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_タトゥ3.Dra = value;
    			X0Y0_淫タトゥ_タトゥ3.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_タトゥ4_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_タトゥ4.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_タトゥ4.Dra = value;
    			X0Y0_淫タトゥ_タトゥ4.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字a_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字a_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字a_枠.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字a_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字b_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字b_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字b_枠.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字b_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字c_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字c_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字c_枠.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字c_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字d_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字d_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字d_枠.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字d_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字e_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字e_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字e_枠.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字e_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3.Dra = value;
    			X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字a_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字a_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字a_枠.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字a_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字b_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字b_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字b_枠.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字b_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字c_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字c_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字c_枠.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字c_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字d_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字d_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字d_枠.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字d_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字e_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字e_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字e_枠.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字e_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3.Dra = value;
    			X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_通常_タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字a_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字a_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字a_枠.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字a_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字b_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字b_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字b_枠.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字b_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字c_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字c_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字c_枠.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字c_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字d_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字d_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字d_枠.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字d_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字e_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字e_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字e_枠.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字e_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字a_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字a_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字a_枠.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字a_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字b_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字b_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字b_枠.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字b_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字c_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字c_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字c_枠.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字c_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字d_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字d_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字d_枠.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字d_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字e_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字e_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字e_枠.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字e_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3.Dra = value;
    			X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_タトゥ1.Dra = value;
    			X0Y0_悪タトゥ_筋肉_タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_タトゥ2.Hit = value;
    		}
    	}

    	public bool 植タトゥ_タトゥ_表示
    	{
    		get
    		{
    			return X0Y0_植タトゥ_タトゥ.Dra;
    		}
    		set
    		{
    			X0Y0_植タトゥ_タトゥ.Dra = value;
    			X0Y0_植タトゥ_タトゥ.Hit = value;
    		}
    	}

    	public bool 植性_通常_葉3_表示
    	{
    		get
    		{
    			return X0Y0_植性_通常_葉3.Dra;
    		}
    		set
    		{
    			X0Y0_植性_通常_葉3.Dra = value;
    			X0Y0_植性_通常_葉3.Hit = value;
    		}
    	}

    	public bool 植性_通常_葉2_表示
    	{
    		get
    		{
    			return X0Y0_植性_通常_葉2.Dra;
    		}
    		set
    		{
    			X0Y0_植性_通常_葉2.Dra = value;
    			X0Y0_植性_通常_葉2.Hit = value;
    		}
    	}

    	public bool 植性_通常_葉1_表示
    	{
    		get
    		{
    			return X0Y0_植性_通常_葉1.Dra;
    		}
    		set
    		{
    			X0Y0_植性_通常_葉1.Dra = value;
    			X0Y0_植性_通常_葉1.Hit = value;
    		}
    	}

    	public bool 植性_欠損_葉3_表示
    	{
    		get
    		{
    			return X0Y0_植性_欠損_葉3.Dra;
    		}
    		set
    		{
    			X0Y0_植性_欠損_葉3.Dra = value;
    			X0Y0_植性_欠損_葉3.Hit = value;
    		}
    	}

    	public bool 植性_欠損_葉2_表示
    	{
    		get
    		{
    			return X0Y0_植性_欠損_葉2.Dra;
    		}
    		set
    		{
    			X0Y0_植性_欠損_葉2.Dra = value;
    			X0Y0_植性_欠損_葉2.Hit = value;
    		}
    	}

    	public bool 植性_欠損_葉1_表示
    	{
    		get
    		{
    			return X0Y0_植性_欠損_葉1.Dra;
    		}
    		set
    		{
    			X0Y0_植性_欠損_葉1.Dra = value;
    			X0Y0_植性_欠損_葉1.Hit = value;
    		}
    	}

    	public bool 傷X_表示
    	{
    		get
    		{
    			return X0Y0_傷X.Dra;
    		}
    		set
    		{
    			X0Y0_傷X.Dra = value;
    			X0Y0_傷X.Hit = value;
    		}
    	}

    	public bool ハイライト_ハイライト1_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト_ハイライト1.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト_ハイライト1.Dra = value;
    			X0Y0_ハイライト_ハイライト1.Hit = value;
    		}
    	}

    	public bool ハイライト_ハイライト2_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト_ハイライト2.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト_ハイライト2.Dra = value;
    			X0Y0_ハイライト_ハイライト2.Hit = value;
    		}
    	}

    	public bool グローブ_通常_グローブ_表示
    	{
    		get
    		{
    			return X0Y0_グローブ_通常_グローブ.Dra;
    		}
    		set
    		{
    			X0Y0_グローブ_通常_グローブ.Dra = value;
    			X0Y0_グローブ_通常_グローブ.Hit = value;
    		}
    	}

    	public bool グローブ_通常_縁_表示
    	{
    		get
    		{
    			return X0Y0_グローブ_通常_縁.Dra;
    		}
    		set
    		{
    			X0Y0_グローブ_通常_縁.Dra = value;
    			X0Y0_グローブ_通常_縁.Hit = value;
    		}
    	}

    	public bool グローブ_筋肉_グローブ_表示
    	{
    		get
    		{
    			return X0Y0_グローブ_筋肉_グローブ.Dra;
    		}
    		set
    		{
    			X0Y0_グローブ_筋肉_グローブ.Dra = value;
    			X0Y0_グローブ_筋肉_グローブ.Hit = value;
    		}
    	}

    	public bool グローブ_筋肉_縁_表示
    	{
    		get
    		{
    			return X0Y0_グローブ_筋肉_縁.Dra;
    		}
    		set
    		{
    			X0Y0_グローブ_筋肉_縁.Dra = value;
    			X0Y0_グローブ_筋肉_縁.Hit = value;
    		}
    	}

    	public bool シャツ_袖1_表示
    	{
    		get
    		{
    			return X0Y0_シャツ_袖1.Dra;
    		}
    		set
    		{
    			X0Y0_シャツ_袖1.Dra = value;
    			X0Y0_シャツ_袖1.Hit = value;
    		}
    	}

    	public bool シャツ_袖2_表示
    	{
    		get
    		{
    			return X0Y0_シャツ_袖2.Dra;
    		}
    		set
    		{
    			X0Y0_シャツ_袖2.Dra = value;
    			X0Y0_シャツ_袖2.Hit = value;
    		}
    	}

    	public bool シャツ_縁_表示
    	{
    		get
    		{
    			return X0Y0_シャツ_縁.Dra;
    		}
    		set
    		{
    			X0Y0_シャツ_縁.Dra = value;
    			X0Y0_シャツ_縁.Hit = value;
    		}
    	}

    	public bool ナース_袖1_表示
    	{
    		get
    		{
    			return X0Y0_ナース_袖1.Dra;
    		}
    		set
    		{
    			X0Y0_ナース_袖1.Dra = value;
    			X0Y0_ナース_袖1.Hit = value;
    		}
    	}

    	public bool ナース_袖2_表示
    	{
    		get
    		{
    			return X0Y0_ナース_袖2.Dra;
    		}
    		set
    		{
    			X0Y0_ナース_袖2.Dra = value;
    			X0Y0_ナース_袖2.Hit = value;
    		}
    	}

    	public bool ナース_縁_表示
    	{
    		get
    		{
    			return X0Y0_ナース_縁.Dra;
    		}
    		set
    		{
    			X0Y0_ナース_縁.Dra = value;
    			X0Y0_ナース_縁.Hit = value;
    		}
    	}

    	public bool 鎧_ベルト_ベルト1_表示
    	{
    		get
    		{
    			return X0Y0_鎧_ベルト_ベルト1.Dra;
    		}
    		set
    		{
    			X0Y0_鎧_ベルト_ベルト1.Dra = value;
    			X0Y0_鎧_ベルト_ベルト1.Hit = value;
    		}
    	}

    	public bool 鎧_ベルト_ベルト2_表示
    	{
    		get
    		{
    			return X0Y0_鎧_ベルト_ベルト2.Dra;
    		}
    		set
    		{
    			X0Y0_鎧_ベルト_ベルト2.Dra = value;
    			X0Y0_鎧_ベルト_ベルト2.Hit = value;
    		}
    	}

    	public bool 鎧_鎧_鎧1_表示
    	{
    		get
    		{
    			return X0Y0_鎧_鎧_鎧1.Dra;
    		}
    		set
    		{
    			X0Y0_鎧_鎧_鎧1.Dra = value;
    			X0Y0_鎧_鎧_鎧1.Hit = value;
    		}
    	}

    	public bool 鎧_鎧_鎧2_表示
    	{
    		get
    		{
    			return X0Y0_鎧_鎧_鎧2.Dra;
    		}
    		set
    		{
    			X0Y0_鎧_鎧_鎧2.Dra = value;
    			X0Y0_鎧_鎧_鎧2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_文字1_文字a_枠_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字a_枠_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字a_枠_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字a_枠_表示 = false;
    				悪タトゥ_筋肉_文字1_文字a_枠_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字a_枠_表示 = value;
    				悪タトゥ_筋肉_文字1_文字a_枠_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字a_文字タトゥ1_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示 = false;
    				悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示 = value;
    				悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字a_文字タトゥ2_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示 = false;
    				悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示 = value;
    				悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字b_枠_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字b_枠_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字b_枠_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字b_枠_表示 = false;
    				悪タトゥ_筋肉_文字1_文字b_枠_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字b_枠_表示 = value;
    				悪タトゥ_筋肉_文字1_文字b_枠_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字b_文字タトゥ1_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示 = false;
    				悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示 = value;
    				悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字b_文字タトゥ2_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示 = false;
    				悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示 = value;
    				悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字c_枠_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字c_枠_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字c_枠_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字c_枠_表示 = false;
    				悪タトゥ_筋肉_文字1_文字c_枠_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字c_枠_表示 = value;
    				悪タトゥ_筋肉_文字1_文字c_枠_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字c_文字タトゥ1_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示 = false;
    				悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示 = value;
    				悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字c_文字タトゥ2_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示 = false;
    				悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示 = value;
    				悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字d_枠_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字d_枠_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字d_枠_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字d_枠_表示 = false;
    				悪タトゥ_筋肉_文字1_文字d_枠_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字d_枠_表示 = value;
    				悪タトゥ_筋肉_文字1_文字d_枠_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字d_文字タトゥ1_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示 = false;
    				悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示 = value;
    				悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字d_文字タトゥ2_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示 = false;
    				悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示 = value;
    				悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字e_枠_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字e_枠_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字e_枠_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字e_枠_表示 = false;
    				悪タトゥ_筋肉_文字1_文字e_枠_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字e_枠_表示 = value;
    				悪タトゥ_筋肉_文字1_文字e_枠_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字e_文字タトゥ1_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示 = false;
    				悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示 = value;
    				悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字e_文字タトゥ2_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示 = false;
    				悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示 = value;
    				悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字1_文字e_文字タトゥ3_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示)
    			{
    				return 悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示 = false;
    				悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示 = value;
    				悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字a_枠_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字a_枠_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字a_枠_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字a_枠_表示 = false;
    				悪タトゥ_筋肉_文字2_文字a_枠_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字a_枠_表示 = value;
    				悪タトゥ_筋肉_文字2_文字a_枠_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字a_文字タトゥ1_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示 = false;
    				悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示 = value;
    				悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字a_文字タトゥ2_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示 = false;
    				悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示 = value;
    				悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字b_枠_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字b_枠_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字b_枠_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字b_枠_表示 = false;
    				悪タトゥ_筋肉_文字2_文字b_枠_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字b_枠_表示 = value;
    				悪タトゥ_筋肉_文字2_文字b_枠_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字b_文字タトゥ1_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示 = false;
    				悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示 = value;
    				悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字b_文字タトゥ2_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示 = false;
    				悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示 = value;
    				悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字c_枠_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字c_枠_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字c_枠_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字c_枠_表示 = false;
    				悪タトゥ_筋肉_文字2_文字c_枠_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字c_枠_表示 = value;
    				悪タトゥ_筋肉_文字2_文字c_枠_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字c_文字タトゥ1_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示 = false;
    				悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示 = value;
    				悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字c_文字タトゥ2_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示 = false;
    				悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示 = value;
    				悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字d_枠_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字d_枠_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字d_枠_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字d_枠_表示 = false;
    				悪タトゥ_筋肉_文字2_文字d_枠_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字d_枠_表示 = value;
    				悪タトゥ_筋肉_文字2_文字d_枠_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字d_文字タトゥ1_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示 = false;
    				悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示 = value;
    				悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字d_文字タトゥ2_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示 = false;
    				悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示 = value;
    				悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字e_枠_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字e_枠_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字e_枠_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字e_枠_表示 = false;
    				悪タトゥ_筋肉_文字2_文字e_枠_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字e_枠_表示 = value;
    				悪タトゥ_筋肉_文字2_文字e_枠_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字e_文字タトゥ1_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示 = false;
    				悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示 = value;
    				悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字e_文字タトゥ2_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示 = false;
    				悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示 = value;
    				悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_文字2_文字e_文字タトゥ3_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示)
    			{
    				return 悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示 = false;
    				悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示 = value;
    				悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_タトゥ1_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_タトゥ1_表示)
    			{
    				return 悪タトゥ_筋肉_タトゥ1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_タトゥ1_表示 = false;
    				悪タトゥ_筋肉_タトゥ1_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_タトゥ1_表示 = value;
    				悪タトゥ_筋肉_タトゥ1_表示 = false;
    			}
    		}
    	}

    	public bool 植性_葉3_表示
    	{
    		get
    		{
    			if (!植性_通常_葉3_表示)
    			{
    				return 植性_欠損_葉3_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				植性_通常_葉3_表示 = false;
    				植性_欠損_葉3_表示 = value;
    			}
    			else
    			{
    				植性_通常_葉3_表示 = value;
    				植性_欠損_葉3_表示 = false;
    			}
    		}
    	}

    	public bool 植性_葉2_表示
    	{
    		get
    		{
    			if (!植性_通常_葉2_表示)
    			{
    				return 植性_欠損_葉2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				植性_通常_葉2_表示 = false;
    				植性_欠損_葉2_表示 = value;
    			}
    			else
    			{
    				植性_通常_葉2_表示 = value;
    				植性_欠損_葉2_表示 = false;
    			}
    		}
    	}

    	public bool 植性_葉1_表示
    	{
    		get
    		{
    			if (!植性_通常_葉1_表示)
    			{
    				return 植性_欠損_葉1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				植性_通常_葉1_表示 = false;
    				植性_欠損_葉1_表示 = value;
    			}
    			else
    			{
    				植性_通常_葉1_表示 = value;
    				植性_欠損_葉1_表示 = false;
    			}
    		}
    	}

    	public bool グローブ_グローブ_表示
    	{
    		get
    		{
    			if (!グローブ_通常_グローブ_表示)
    			{
    				return グローブ_筋肉_グローブ_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				グローブ_通常_グローブ_表示 = false;
    				グローブ_筋肉_グローブ_表示 = value;
    			}
    			else
    			{
    				グローブ_通常_グローブ_表示 = value;
    				グローブ_筋肉_グローブ_表示 = false;
    			}
    		}
    	}

    	public bool グローブ_縁_表示
    	{
    		get
    		{
    			if (!グローブ_通常_縁_表示)
    			{
    				return グローブ_筋肉_縁_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				グローブ_通常_縁_表示 = false;
    				グローブ_筋肉_縁_表示 = value;
    			}
    			else
    			{
    				グローブ_通常_縁_表示 = value;
    				グローブ_筋肉_縁_表示 = false;
    			}
    		}
    	}

    	private bool 筋肉フラグ
    	{
    		get
    		{
    			if (!筋肉_ && !筋肉上_表示 && !筋肉下_表示)
    			{
    				return 虫性_筋肉下_表示;
    			}
    			return true;
    		}
    	}

    	public bool ハイライト表示
    	{
    		get
    		{
    			return ハイライト_ハイライト1_表示;
    		}
    		set
    		{
    			ハイライト_ハイライト1_表示 = value;
    			ハイライト_ハイライト2_表示 = value;
    		}
    	}

    	public double 傷X濃度
    	{
    		get
    		{
    			return 傷XCD.不透明度;
    		}
    		set
    		{
    			傷XCD.不透明度 = value;
    		}
    	}

    	public double ハイライト濃度
    	{
    		get
    		{
    			return ハイライト_ハイライト1CD.不透明度;
    		}
    		set
    		{
    			ハイライト_ハイライト1CD.不透明度 = value;
    			ハイライト_ハイライト2CD.不透明度 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 筋肉上_表示;
    		}
    		set
    		{
    			筋肉上_表示 = value;
    			上腕_表示 = value;
    			虫性_虫腕_表示 = value;
    			虫性_筋肉下_表示 = value;
    			筋肉下_表示 = value;
    			紋柄_紋1_表示 = value;
    			紋柄_紋2_表示 = value;
    			紋柄_紋3_表示 = value;
    			紋柄_紋4_表示 = value;
    			獣性_獣毛1_表示 = value;
    			獣性_獣毛2_表示 = value;
    			竜性_鱗4_表示 = value;
    			竜性_鱗3_表示 = value;
    			竜性_鱗2_表示 = value;
    			竜性_鱗1_表示 = value;
    			竜性_鱗5_表示 = value;
    			淫タトゥ_ハート_タトゥ左_表示 = value;
    			淫タトゥ_ハート_タトゥ右_表示 = value;
    			淫タトゥ_タトゥ1_表示 = value;
    			淫タトゥ_タトゥ2_表示 = value;
    			淫タトゥ_タトゥ3_表示 = value;
    			淫タトゥ_タトゥ4_表示 = value;
    			悪タトゥ_通常_文字1_文字a_枠_表示 = value;
    			悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示 = value;
    			悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示 = value;
    			悪タトゥ_通常_文字1_文字b_枠_表示 = value;
    			悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示 = value;
    			悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示 = value;
    			悪タトゥ_通常_文字1_文字c_枠_表示 = value;
    			悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示 = value;
    			悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示 = value;
    			悪タトゥ_通常_文字1_文字d_枠_表示 = value;
    			悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示 = value;
    			悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示 = value;
    			悪タトゥ_通常_文字1_文字e_枠_表示 = value;
    			悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示 = value;
    			悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示 = value;
    			悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示 = value;
    			悪タトゥ_通常_文字2_文字a_枠_表示 = value;
    			悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示 = value;
    			悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示 = value;
    			悪タトゥ_通常_文字2_文字b_枠_表示 = value;
    			悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示 = value;
    			悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示 = value;
    			悪タトゥ_通常_文字2_文字c_枠_表示 = value;
    			悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示 = value;
    			悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示 = value;
    			悪タトゥ_通常_文字2_文字d_枠_表示 = value;
    			悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示 = value;
    			悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示 = value;
    			悪タトゥ_通常_文字2_文字e_枠_表示 = value;
    			悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示 = value;
    			悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示 = value;
    			悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示 = value;
    			悪タトゥ_通常_タトゥ1_表示 = value;
    			悪タトゥ_筋肉_文字1_文字a_枠_表示 = value;
    			悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示 = value;
    			悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示 = value;
    			悪タトゥ_筋肉_文字1_文字b_枠_表示 = value;
    			悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示 = value;
    			悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示 = value;
    			悪タトゥ_筋肉_文字1_文字c_枠_表示 = value;
    			悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示 = value;
    			悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示 = value;
    			悪タトゥ_筋肉_文字1_文字d_枠_表示 = value;
    			悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示 = value;
    			悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示 = value;
    			悪タトゥ_筋肉_文字1_文字e_枠_表示 = value;
    			悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示 = value;
    			悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示 = value;
    			悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示 = value;
    			悪タトゥ_筋肉_文字2_文字a_枠_表示 = value;
    			悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示 = value;
    			悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示 = value;
    			悪タトゥ_筋肉_文字2_文字b_枠_表示 = value;
    			悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示 = value;
    			悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示 = value;
    			悪タトゥ_筋肉_文字2_文字c_枠_表示 = value;
    			悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示 = value;
    			悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示 = value;
    			悪タトゥ_筋肉_文字2_文字d_枠_表示 = value;
    			悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示 = value;
    			悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示 = value;
    			悪タトゥ_筋肉_文字2_文字e_枠_表示 = value;
    			悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示 = value;
    			悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示 = value;
    			悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示 = value;
    			悪タトゥ_筋肉_タトゥ1_表示 = value;
    			悪タトゥ_タトゥ2_表示 = value;
    			植タトゥ_タトゥ_表示 = value;
    			植性_通常_葉3_表示 = value;
    			植性_通常_葉2_表示 = value;
    			植性_通常_葉1_表示 = value;
    			植性_欠損_葉3_表示 = value;
    			植性_欠損_葉2_表示 = value;
    			植性_欠損_葉1_表示 = value;
    			傷X_表示 = value;
    			ハイライト_ハイライト1_表示 = value;
    			ハイライト_ハイライト2_表示 = value;
    			グローブ_通常_グローブ_表示 = value;
    			グローブ_通常_縁_表示 = value;
    			グローブ_筋肉_グローブ_表示 = value;
    			グローブ_筋肉_縁_表示 = value;
    			シャツ_袖1_表示 = value;
    			シャツ_袖2_表示 = value;
    			シャツ_縁_表示 = value;
    			ナース_袖1_表示 = value;
    			ナース_袖2_表示 = value;
    			ナース_縁_表示 = value;
    			鎧_ベルト_ベルト1_表示 = value;
    			鎧_ベルト_ベルト2_表示 = value;
    			鎧_鎧_鎧1_表示 = value;
    			鎧_鎧_鎧2_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 筋肉上CD.不透明度;
    		}
    		set
    		{
    			筋肉上CD.不透明度 = value;
    			上腕CD.不透明度 = value;
    			虫性_虫腕CD.不透明度 = value;
    			虫性_筋肉下CD.不透明度 = value;
    			筋肉下CD.不透明度 = value;
    			紋柄_紋1CD.不透明度 = value;
    			紋柄_紋2CD.不透明度 = value;
    			紋柄_紋3CD.不透明度 = value;
    			紋柄_紋4CD.不透明度 = value;
    			獣性_獣毛1CD.不透明度 = value;
    			獣性_獣毛2CD.不透明度 = value;
    			竜性_鱗4CD.不透明度 = value;
    			竜性_鱗3CD.不透明度 = value;
    			竜性_鱗2CD.不透明度 = value;
    			竜性_鱗1CD.不透明度 = value;
    			竜性_鱗5CD.不透明度 = value;
    			淫タトゥ_ハート_タトゥ左CD.不透明度 = value;
    			淫タトゥ_ハート_タトゥ右CD.不透明度 = value;
    			淫タトゥ_タトゥ1CD.不透明度 = value;
    			淫タトゥ_タトゥ2CD.不透明度 = value;
    			淫タトゥ_タトゥ3CD.不透明度 = value;
    			淫タトゥ_タトゥ4CD.不透明度 = value;
    			悪タトゥ_文字1_文字a_枠CD.不透明度 = value;
    			悪タトゥ_文字1_文字a_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字1_文字a_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字1_文字b_枠CD.不透明度 = value;
    			悪タトゥ_文字1_文字b_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字1_文字b_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字1_文字c_枠CD.不透明度 = value;
    			悪タトゥ_文字1_文字c_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字1_文字c_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字1_文字d_枠CD.不透明度 = value;
    			悪タトゥ_文字1_文字d_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字1_文字d_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字1_文字e_枠CD.不透明度 = value;
    			悪タトゥ_文字1_文字e_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字1_文字e_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字1_文字e_文字タトゥ3CD.不透明度 = value;
    			悪タトゥ_文字2_文字a_枠CD.不透明度 = value;
    			悪タトゥ_文字2_文字a_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字2_文字a_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字2_文字b_枠CD.不透明度 = value;
    			悪タトゥ_文字2_文字b_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字2_文字b_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字2_文字c_枠CD.不透明度 = value;
    			悪タトゥ_文字2_文字c_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字2_文字c_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字2_文字d_枠CD.不透明度 = value;
    			悪タトゥ_文字2_文字d_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字2_文字d_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字2_文字e_枠CD.不透明度 = value;
    			悪タトゥ_文字2_文字e_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ_文字2_文字e_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ_文字2_文字e_文字タトゥ3CD.不透明度 = value;
    			悪タトゥ_タトゥ1CD.不透明度 = value;
    			悪タトゥ_タトゥ2CD.不透明度 = value;
    			植タトゥ_タトゥCD.不透明度 = value;
    			植性_葉3CD.不透明度 = value;
    			植性_葉2CD.不透明度 = value;
    			植性_葉1CD.不透明度 = value;
    			傷XCD.不透明度 = value;
    			ハイライト_ハイライト1CD.不透明度 = value;
    			ハイライト_ハイライト2CD.不透明度 = value;
    			グローブ_グローブCD.不透明度 = value;
    			グローブ_縁CD.不透明度 = value;
    			シャツ_袖1CD.不透明度 = value;
    			シャツ_袖2CD.不透明度 = value;
    			シャツ_縁CD.不透明度 = value;
    			ナース_袖1CD.不透明度 = value;
    			ナース_袖2CD.不透明度 = value;
    			ナース_縁CD.不透明度 = value;
    			鎧_ベルト_ベルト1CD.不透明度 = value;
    			鎧_ベルト_ベルト2CD.不透明度 = value;
    			鎧_鎧_鎧1CD.不透明度 = value;
    			鎧_鎧_鎧2CD.不透明度 = value;
    		}
    	}

    	public bool 肘部_外線
    	{
    		get
    		{
    			return X0Y0_上腕.OP[(!右) ? 1 : 2].Outline;
    		}
    		set
    		{
    			X0Y0_上腕.OP[(!右) ? 1 : 2].Outline = value;
    			X0Y0_虫性_虫腕.OP[右 ? 1 : 4].Outline = value;
    			X0Y0_獣性_獣毛1.OP[右 ? 3 : 7].Outline = value;
    			X0Y0_グローブ_通常_グローブ.OP[(!右) ? 1 : 2].Outline = value;
    			X0Y0_グローブ_筋肉_グローブ.OP[(!右) ? 1 : 2].Outline = value;
    		}
    	}

    	public bool グローブ表示
    	{
    		get
    		{
    			return グローブ_グローブ_表示;
    		}
    		set
    		{
    			グローブ_グローブ_表示 = value;
    			グローブ_縁_表示 = value;
    		}
    	}

    	public bool シャツ表示
    	{
    		get
    		{
    			return シャツ_袖1_表示;
    		}
    		set
    		{
    			シャツ_袖1_表示 = value;
    			シャツ_袖2_表示 = value;
    			シャツ_縁_表示 = value;
    		}
    	}

    	public bool ナース表示
    	{
    		get
    		{
    			return ナース_袖1_表示;
    		}
    		set
    		{
    			ナース_袖1_表示 = value;
    			ナース_袖2_表示 = value;
    			ナース_縁_表示 = value;
    		}
    	}

    	public bool メイル表示
    	{
    		get
    		{
    			return 鎧_ベルト_ベルト1_表示;
    		}
    		set
    		{
    			鎧_ベルト_ベルト1_表示 = value;
    			鎧_ベルト_ベルト2_表示 = value;
    			鎧_鎧_鎧1_表示 = value;
    			鎧_鎧_鎧2_表示 = value;
    		}
    	}

    	public JointS 下腕_接続点 => new JointS(本体, X0Y0_上腕, 1);

    	public 上腕_人(double DisUnit, 配色指定 配色指定, 体配色 体配色, ModeEventDispatcher Med, 上腕_人D e)
    	{
    		上腕_人 上腕_人2 = this;
    		ThisType = GetType();
    		本体 = new Difs(Sta.腕左["上腕"]);
    		Pars pars = 本体[0][0];
    		X0Y0_筋肉上 = pars["筋肉上"].ToPar();
    		X0Y0_上腕 = pars["上腕"].ToPar();
    		X0Y0_筋肉下 = pars["筋肉下"].ToPar();
    		Pars pars2 = pars["虫性"].ToPars();
    		X0Y0_虫性_虫腕 = pars2["虫腕"].ToPar();
    		X0Y0_虫性_筋肉下 = pars2["筋肉下"].ToPar();
    		pars2 = pars["紋柄"].ToPars();
    		X0Y0_紋柄_紋1 = pars2["紋1"].ToPar();
    		X0Y0_紋柄_紋2 = pars2["紋2"].ToPar();
    		X0Y0_紋柄_紋3 = pars2["紋3"].ToPar();
    		X0Y0_紋柄_紋4 = pars2["紋4"].ToPar();
    		pars2 = pars["獣性"].ToPars();
    		X0Y0_獣性_獣毛1 = pars2["獣毛1"].ToPar();
    		X0Y0_獣性_獣毛2 = pars2["獣毛2"].ToPar();
    		pars2 = pars["鱗"].ToPars();
    		X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
    		X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
    		X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
    		X0Y0_竜性_鱗5 = pars2["鱗5"].ToPar();
    		pars2 = pars["淫タトゥ"].ToPars();
    		Pars pars3 = pars2["ハート"].ToPars();
    		X0Y0_淫タトゥ_ハート_タトゥ左 = pars3["タトゥ左"].ToPar();
    		X0Y0_淫タトゥ_ハート_タトゥ右 = pars3["タトゥ右"].ToPar();
    		X0Y0_淫タトゥ_タトゥ1 = pars2["タトゥ1"].ToPar();
    		X0Y0_淫タトゥ_タトゥ2 = pars2["タトゥ2"].ToPar();
    		X0Y0_淫タトゥ_タトゥ3 = pars2["タトゥ3"].ToPar();
    		X0Y0_淫タトゥ_タトゥ4 = pars2["タトゥ4"].ToPar();
    		pars2 = pars["悪タトゥ"].ToPars();
    		pars3 = pars2["通常"].ToPars();
    		Pars pars4 = pars3["文字1"].ToPars();
    		Pars pars5 = pars4["文字a"].ToPars();
    		X0Y0_悪タトゥ_通常_文字1_文字a_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字b"].ToPars();
    		X0Y0_悪タトゥ_通常_文字1_文字b_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字c"].ToPars();
    		X0Y0_悪タトゥ_通常_文字1_文字c_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字d"].ToPars();
    		X0Y0_悪タトゥ_通常_文字1_文字d_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字e"].ToPars();
    		X0Y0_悪タトゥ_通常_文字1_文字e_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
    		Pars pars6 = pars3["文字2"].ToPars();
    		pars5 = pars6["文字a"].ToPars();
    		X0Y0_悪タトゥ_通常_文字2_文字a_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars6["文字b"].ToPars();
    		X0Y0_悪タトゥ_通常_文字2_文字b_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars6["文字c"].ToPars();
    		X0Y0_悪タトゥ_通常_文字2_文字c_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars6["文字d"].ToPars();
    		X0Y0_悪タトゥ_通常_文字2_文字d_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars6["文字e"].ToPars();
    		X0Y0_悪タトゥ_通常_文字2_文字e_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
    		X0Y0_悪タトゥ_通常_タトゥ1 = pars3["タトゥ1"].ToPar();
    		pars3 = pars2["筋肉"].ToPars();
    		Pars pars7 = pars3["文字1"].ToPars();
    		pars5 = pars7["文字a"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字1_文字a_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars7["文字b"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字1_文字b_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars7["文字c"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字1_文字c_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars7["文字d"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字1_文字d_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars7["文字e"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
    		Pars pars8 = pars3["文字2"].ToPars();
    		pars5 = pars8["文字a"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字2_文字a_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars8["文字b"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字2_文字b_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars8["文字c"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字2_文字c_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars8["文字d"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字2_文字d_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars8["文字e"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
    		X0Y0_悪タトゥ_筋肉_タトゥ1 = pars3["タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_タトゥ2 = pars2["タトゥ2"].ToPar();
    		pars2 = pars["植タトゥ"].ToPars();
    		X0Y0_植タトゥ_タトゥ = pars2["タトゥ"].ToPar();
    		pars2 = pars["植性"].ToPars();
    		pars3 = pars2["通常"].ToPars();
    		X0Y0_植性_通常_葉3 = pars3["葉3"].ToPar();
    		X0Y0_植性_通常_葉2 = pars3["葉2"].ToPar();
    		X0Y0_植性_通常_葉1 = pars3["葉1"].ToPar();
    		pars3 = pars2["欠損"].ToPars();
    		X0Y0_植性_欠損_葉3 = pars3["葉3"].ToPar();
    		X0Y0_植性_欠損_葉2 = pars3["葉2"].ToPar();
    		X0Y0_植性_欠損_葉1 = pars3["葉1"].ToPar();
    		X0Y0_傷X = pars["傷X"].ToPar();
    		pars2 = pars["ハイライト"].ToPars();
    		X0Y0_ハイライト_ハイライト1 = pars2["ハイライト1"].ToPar();
    		X0Y0_ハイライト_ハイライト2 = pars2["ハイライト2"].ToPar();
    		pars2 = pars["グローブ"].ToPars();
    		pars3 = pars2["通常"].ToPars();
    		X0Y0_グローブ_通常_グローブ = pars3["グローブ"].ToPar();
    		X0Y0_グローブ_通常_縁 = pars3["縁"].ToPar();
    		pars3 = pars2["筋肉"].ToPars();
    		X0Y0_グローブ_筋肉_グローブ = pars3["グローブ"].ToPar();
    		X0Y0_グローブ_筋肉_縁 = pars3["縁"].ToPar();
    		pars2 = pars["シャツ"].ToPars();
    		X0Y0_シャツ_袖1 = pars2["袖1"].ToPar();
    		X0Y0_シャツ_袖2 = pars2["袖2"].ToPar();
    		X0Y0_シャツ_縁 = pars2["縁"].ToPar();
    		pars2 = pars["ナース"].ToPars();
    		X0Y0_ナース_袖1 = pars2["袖1"].ToPar();
    		X0Y0_ナース_袖2 = pars2["袖2"].ToPar();
    		X0Y0_ナース_縁 = pars2["縁"].ToPar();
    		pars2 = pars["鎧"].ToPars();
    		pars3 = pars2["ベルト"].ToPars();
    		X0Y0_鎧_ベルト_ベルト1 = pars3["ベルト1"].ToPar();
    		X0Y0_鎧_ベルト_ベルト2 = pars3["ベルト2"].ToPar();
    		pars3 = pars2["鎧"].ToPars();
    		X0Y0_鎧_鎧_鎧1 = pars3["鎧1"].ToPar();
    		X0Y0_鎧_鎧_鎧2 = pars3["鎧2"].ToPar();
    		Xasix = false;
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
    		筋肉上_表示 = e.筋肉上_表示;
    		上腕_表示 = e.上腕_表示;
    		虫性_虫腕_表示 = e.虫性_虫腕_表示;
    		虫性_筋肉下_表示 = e.虫性_筋肉下_表示;
    		筋肉下_表示 = e.筋肉下_表示;
    		紋柄_紋1_表示 = e.紋柄_紋1_表示;
    		紋柄_紋2_表示 = e.紋柄_紋2_表示;
    		紋柄_紋3_表示 = e.紋柄_紋3_表示;
    		紋柄_紋4_表示 = e.紋柄_紋4_表示;
    		獣性_獣毛1_表示 = e.獣性_獣毛1_表示;
    		獣性_獣毛2_表示 = e.獣性_獣毛2_表示;
    		竜性_鱗4_表示 = e.竜性_鱗4_表示;
    		竜性_鱗3_表示 = e.竜性_鱗3_表示;
    		竜性_鱗2_表示 = e.竜性_鱗2_表示;
    		竜性_鱗1_表示 = e.竜性_鱗1_表示;
    		竜性_鱗5_表示 = e.竜性_鱗5_表示;
    		淫タトゥ_ハート_タトゥ左_表示 = e.淫タトゥ_ハート_タトゥ左_表示;
    		淫タトゥ_ハート_タトゥ右_表示 = e.淫タトゥ_ハート_タトゥ右_表示;
    		淫タトゥ_タトゥ1_表示 = e.淫タトゥ_タトゥ1_表示;
    		淫タトゥ_タトゥ2_表示 = e.淫タトゥ_タトゥ2_表示;
    		淫タトゥ_タトゥ3_表示 = e.淫タトゥ_タトゥ3_表示;
    		淫タトゥ_タトゥ4_表示 = e.淫タトゥ_タトゥ4_表示;
    		悪タトゥ_通常_文字1_文字a_枠_表示 = e.悪タトゥ_通常_文字1_文字a_枠_表示;
    		悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示 = e.悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示;
    		悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示 = e.悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示;
    		悪タトゥ_通常_文字1_文字b_枠_表示 = e.悪タトゥ_通常_文字1_文字b_枠_表示;
    		悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示 = e.悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示;
    		悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示 = e.悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示;
    		悪タトゥ_通常_文字1_文字c_枠_表示 = e.悪タトゥ_通常_文字1_文字c_枠_表示;
    		悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示 = e.悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示;
    		悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示 = e.悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示;
    		悪タトゥ_通常_文字1_文字d_枠_表示 = e.悪タトゥ_通常_文字1_文字d_枠_表示;
    		悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示 = e.悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示;
    		悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示 = e.悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示;
    		悪タトゥ_通常_文字1_文字e_枠_表示 = e.悪タトゥ_通常_文字1_文字e_枠_表示;
    		悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示 = e.悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示;
    		悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示 = e.悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示;
    		悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示 = e.悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示;
    		悪タトゥ_通常_文字2_文字a_枠_表示 = e.悪タトゥ_通常_文字2_文字a_枠_表示;
    		悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示 = e.悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示;
    		悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示 = e.悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示;
    		悪タトゥ_通常_文字2_文字b_枠_表示 = e.悪タトゥ_通常_文字2_文字b_枠_表示;
    		悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示 = e.悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示;
    		悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示 = e.悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示;
    		悪タトゥ_通常_文字2_文字c_枠_表示 = e.悪タトゥ_通常_文字2_文字c_枠_表示;
    		悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示 = e.悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示;
    		悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示 = e.悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示;
    		悪タトゥ_通常_文字2_文字d_枠_表示 = e.悪タトゥ_通常_文字2_文字d_枠_表示;
    		悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示 = e.悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示;
    		悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示 = e.悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示;
    		悪タトゥ_通常_文字2_文字e_枠_表示 = e.悪タトゥ_通常_文字2_文字e_枠_表示;
    		悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示 = e.悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示;
    		悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示 = e.悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示;
    		悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示 = e.悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示;
    		悪タトゥ_通常_タトゥ1_表示 = e.悪タトゥ_通常_タトゥ1_表示;
    		悪タトゥ_筋肉_文字1_文字a_枠_表示 = e.悪タトゥ_筋肉_文字1_文字a_枠_表示;
    		悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示;
    		悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示;
    		悪タトゥ_筋肉_文字1_文字b_枠_表示 = e.悪タトゥ_筋肉_文字1_文字b_枠_表示;
    		悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示;
    		悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示;
    		悪タトゥ_筋肉_文字1_文字c_枠_表示 = e.悪タトゥ_筋肉_文字1_文字c_枠_表示;
    		悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示;
    		悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示;
    		悪タトゥ_筋肉_文字1_文字d_枠_表示 = e.悪タトゥ_筋肉_文字1_文字d_枠_表示;
    		悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示;
    		悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示;
    		悪タトゥ_筋肉_文字1_文字e_枠_表示 = e.悪タトゥ_筋肉_文字1_文字e_枠_表示;
    		悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示;
    		悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示;
    		悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示 = e.悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示;
    		悪タトゥ_筋肉_文字2_文字a_枠_表示 = e.悪タトゥ_筋肉_文字2_文字a_枠_表示;
    		悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示;
    		悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示;
    		悪タトゥ_筋肉_文字2_文字b_枠_表示 = e.悪タトゥ_筋肉_文字2_文字b_枠_表示;
    		悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示;
    		悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示;
    		悪タトゥ_筋肉_文字2_文字c_枠_表示 = e.悪タトゥ_筋肉_文字2_文字c_枠_表示;
    		悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示;
    		悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示;
    		悪タトゥ_筋肉_文字2_文字d_枠_表示 = e.悪タトゥ_筋肉_文字2_文字d_枠_表示;
    		悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示;
    		悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示;
    		悪タトゥ_筋肉_文字2_文字e_枠_表示 = e.悪タトゥ_筋肉_文字2_文字e_枠_表示;
    		悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示;
    		悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示;
    		悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示 = e.悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示;
    		悪タトゥ_筋肉_タトゥ1_表示 = e.悪タトゥ_筋肉_タトゥ1_表示;
    		悪タトゥ_タトゥ2_表示 = e.悪タトゥ_タトゥ2_表示;
    		植タトゥ_タトゥ_表示 = e.植タトゥ_タトゥ_表示;
    		植性_通常_葉3_表示 = e.植性_通常_葉3_表示;
    		植性_通常_葉2_表示 = e.植性_通常_葉2_表示;
    		植性_通常_葉1_表示 = e.植性_通常_葉1_表示;
    		植性_欠損_葉3_表示 = e.植性_欠損_葉3_表示;
    		植性_欠損_葉2_表示 = e.植性_欠損_葉2_表示;
    		植性_欠損_葉1_表示 = e.植性_欠損_葉1_表示;
    		傷X_表示 = e.傷X_表示;
    		ハイライト_ハイライト1_表示 = e.ハイライト_ハイライト1_表示;
    		ハイライト_ハイライト2_表示 = e.ハイライト_ハイライト2_表示;
    		グローブ_通常_グローブ_表示 = e.グローブ_通常_グローブ_表示;
    		グローブ_通常_縁_表示 = e.グローブ_通常_縁_表示;
    		グローブ_筋肉_グローブ_表示 = e.グローブ_筋肉_グローブ_表示;
    		グローブ_筋肉_縁_表示 = e.グローブ_筋肉_縁_表示;
    		シャツ_袖1_表示 = e.シャツ_袖1_表示;
    		シャツ_袖2_表示 = e.シャツ_袖2_表示;
    		シャツ_縁_表示 = e.シャツ_縁_表示;
    		ナース_袖1_表示 = e.ナース_袖1_表示;
    		ナース_袖2_表示 = e.ナース_袖2_表示;
    		ナース_縁_表示 = e.ナース_縁_表示;
    		鎧_ベルト_ベルト1_表示 = e.鎧_ベルト_ベルト1_表示;
    		鎧_ベルト_ベルト2_表示 = e.鎧_ベルト_ベルト2_表示;
    		鎧_鎧_鎧1_表示 = e.鎧_鎧_鎧1_表示;
    		鎧_鎧_鎧2_表示 = e.鎧_鎧_鎧2_表示;
    		悪タトゥ_文字1_文字a_枠_表示 = e.悪タトゥ_文字1_文字a_枠_表示;
    		悪タトゥ_文字1_文字a_文字タトゥ1_表示 = e.悪タトゥ_文字1_文字a_文字タトゥ1_表示;
    		悪タトゥ_文字1_文字a_文字タトゥ2_表示 = e.悪タトゥ_文字1_文字a_文字タトゥ2_表示;
    		悪タトゥ_文字1_文字b_枠_表示 = e.悪タトゥ_文字1_文字b_枠_表示;
    		悪タトゥ_文字1_文字b_文字タトゥ1_表示 = e.悪タトゥ_文字1_文字b_文字タトゥ1_表示;
    		悪タトゥ_文字1_文字b_文字タトゥ2_表示 = e.悪タトゥ_文字1_文字b_文字タトゥ2_表示;
    		悪タトゥ_文字1_文字c_枠_表示 = e.悪タトゥ_文字1_文字c_枠_表示;
    		悪タトゥ_文字1_文字c_文字タトゥ1_表示 = e.悪タトゥ_文字1_文字c_文字タトゥ1_表示;
    		悪タトゥ_文字1_文字c_文字タトゥ2_表示 = e.悪タトゥ_文字1_文字c_文字タトゥ2_表示;
    		悪タトゥ_文字1_文字d_枠_表示 = e.悪タトゥ_文字1_文字d_枠_表示;
    		悪タトゥ_文字1_文字d_文字タトゥ1_表示 = e.悪タトゥ_文字1_文字d_文字タトゥ1_表示;
    		悪タトゥ_文字1_文字d_文字タトゥ2_表示 = e.悪タトゥ_文字1_文字d_文字タトゥ2_表示;
    		悪タトゥ_文字1_文字e_枠_表示 = e.悪タトゥ_文字1_文字e_枠_表示;
    		悪タトゥ_文字1_文字e_文字タトゥ1_表示 = e.悪タトゥ_文字1_文字e_文字タトゥ1_表示;
    		悪タトゥ_文字1_文字e_文字タトゥ2_表示 = e.悪タトゥ_文字1_文字e_文字タトゥ2_表示;
    		悪タトゥ_文字1_文字e_文字タトゥ3_表示 = e.悪タトゥ_文字1_文字e_文字タトゥ3_表示;
    		悪タトゥ_文字2_文字a_枠_表示 = e.悪タトゥ_文字2_文字a_枠_表示;
    		悪タトゥ_文字2_文字a_文字タトゥ1_表示 = e.悪タトゥ_文字2_文字a_文字タトゥ1_表示;
    		悪タトゥ_文字2_文字a_文字タトゥ2_表示 = e.悪タトゥ_文字2_文字a_文字タトゥ2_表示;
    		悪タトゥ_文字2_文字b_枠_表示 = e.悪タトゥ_文字2_文字b_枠_表示;
    		悪タトゥ_文字2_文字b_文字タトゥ1_表示 = e.悪タトゥ_文字2_文字b_文字タトゥ1_表示;
    		悪タトゥ_文字2_文字b_文字タトゥ2_表示 = e.悪タトゥ_文字2_文字b_文字タトゥ2_表示;
    		悪タトゥ_文字2_文字c_枠_表示 = e.悪タトゥ_文字2_文字c_枠_表示;
    		悪タトゥ_文字2_文字c_文字タトゥ1_表示 = e.悪タトゥ_文字2_文字c_文字タトゥ1_表示;
    		悪タトゥ_文字2_文字c_文字タトゥ2_表示 = e.悪タトゥ_文字2_文字c_文字タトゥ2_表示;
    		悪タトゥ_文字2_文字d_枠_表示 = e.悪タトゥ_文字2_文字d_枠_表示;
    		悪タトゥ_文字2_文字d_文字タトゥ1_表示 = e.悪タトゥ_文字2_文字d_文字タトゥ1_表示;
    		悪タトゥ_文字2_文字d_文字タトゥ2_表示 = e.悪タトゥ_文字2_文字d_文字タトゥ2_表示;
    		悪タトゥ_文字2_文字e_枠_表示 = e.悪タトゥ_文字2_文字e_枠_表示;
    		悪タトゥ_文字2_文字e_文字タトゥ1_表示 = e.悪タトゥ_文字2_文字e_文字タトゥ1_表示;
    		悪タトゥ_文字2_文字e_文字タトゥ2_表示 = e.悪タトゥ_文字2_文字e_文字タトゥ2_表示;
    		悪タトゥ_文字2_文字e_文字タトゥ3_表示 = e.悪タトゥ_文字2_文字e_文字タトゥ3_表示;
    		悪タトゥ_タトゥ1_表示 = e.悪タトゥ_タトゥ1_表示;
    		植性_葉3_表示 = e.植性_葉3_表示;
    		植性_葉2_表示 = e.植性_葉2_表示;
    		植性_葉1_表示 = e.植性_葉1_表示;
    		グローブ_グローブ_表示 = e.グローブ_グローブ_表示;
    		グローブ_縁_表示 = e.グローブ_縁_表示;
    		ハイライト表示 = e.ハイライト表示;
    		肘部_外線 = e.肘部_外線;
    		グローブ表示 = e.グローブ表示;
    		シャツ表示 = e.シャツ表示;
    		ナース表示 = e.ナース表示;
    		メイル表示 = e.メイル表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.下腕_接続.Count > 0)
    		{
    			Ele f;
    			下腕_接続 = e.下腕_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 上腕_人2;
    				f.ConnectionType = ConnectionInfo.上腕_人_下腕_接続;
    				f.接続(上腕_人2.下腕_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_筋肉上CP = new ColorP(X0Y0_筋肉上, 筋肉上CD, DisUnit, abj: false);
    		X0Y0_上腕CP = new ColorP(X0Y0_上腕, 上腕CD, DisUnit, abj: true);
    		X0Y0_筋肉下CP = new ColorP(X0Y0_筋肉下, 筋肉下CD, DisUnit, abj: false);
    		X0Y0_虫性_虫腕CP = new ColorP(X0Y0_虫性_虫腕, 虫性_虫腕CD, DisUnit, abj: true);
    		X0Y0_虫性_筋肉下CP = new ColorP(X0Y0_虫性_筋肉下, 虫性_筋肉下CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋1CP = new ColorP(X0Y0_紋柄_紋1, 紋柄_紋1CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋2CP = new ColorP(X0Y0_紋柄_紋2, 紋柄_紋2CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋3CP = new ColorP(X0Y0_紋柄_紋3, 紋柄_紋3CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋4CP = new ColorP(X0Y0_紋柄_紋4, 紋柄_紋4CD, DisUnit, abj: true);
    		X0Y0_獣性_獣毛1CP = new ColorP(X0Y0_獣性_獣毛1, 獣性_獣毛1CD, DisUnit, abj: true);
    		X0Y0_獣性_獣毛2CP = new ColorP(X0Y0_獣性_獣毛2, 獣性_獣毛2CD, DisUnit, abj: true);
    		X0Y0_鱗_鱗4CP = new ColorP(X0Y0_竜性_鱗4, 竜性_鱗4CD, DisUnit, abj: true);
    		X0Y0_鱗_鱗3CP = new ColorP(X0Y0_竜性_鱗3, 竜性_鱗3CD, DisUnit, abj: true);
    		X0Y0_鱗_鱗2CP = new ColorP(X0Y0_竜性_鱗2, 竜性_鱗2CD, DisUnit, abj: true);
    		X0Y0_鱗_鱗1CP = new ColorP(X0Y0_竜性_鱗1, 竜性_鱗1CD, DisUnit, abj: true);
    		X0Y0_鱗_鱗5CP = new ColorP(X0Y0_竜性_鱗5, 竜性_鱗5CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_ハート_タトゥ左CP = new ColorP(X0Y0_淫タトゥ_ハート_タトゥ左, 淫タトゥ_ハート_タトゥ左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_ハート_タトゥ右CP = new ColorP(X0Y0_淫タトゥ_ハート_タトゥ右, 淫タトゥ_ハート_タトゥ右CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_タトゥ1CP = new ColorP(X0Y0_淫タトゥ_タトゥ1, 淫タトゥ_タトゥ1CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_タトゥ2CP = new ColorP(X0Y0_淫タトゥ_タトゥ2, 淫タトゥ_タトゥ2CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_タトゥ3CP = new ColorP(X0Y0_淫タトゥ_タトゥ3, 淫タトゥ_タトゥ3CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_タトゥ4CP = new ColorP(X0Y0_淫タトゥ_タトゥ4, 淫タトゥ_タトゥ4CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字a_枠CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字a_枠, 悪タトゥ_文字1_文字a_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1, 悪タトゥ_文字1_文字a_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2, 悪タトゥ_文字1_文字a_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字b_枠CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字b_枠, 悪タトゥ_文字1_文字b_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1, 悪タトゥ_文字1_文字b_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2, 悪タトゥ_文字1_文字b_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字c_枠CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字c_枠, 悪タトゥ_文字1_文字c_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1, 悪タトゥ_文字1_文字c_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2, 悪タトゥ_文字1_文字c_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字d_枠CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字d_枠, 悪タトゥ_文字1_文字d_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1, 悪タトゥ_文字1_文字d_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2, 悪タトゥ_文字1_文字d_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字e_枠CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字e_枠, 悪タトゥ_文字1_文字e_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1, 悪タトゥ_文字1_文字e_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2, 悪タトゥ_文字1_文字e_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3CP = new ColorP(X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3, 悪タトゥ_文字1_文字e_文字タトゥ3CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字a_枠CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字a_枠, 悪タトゥ_文字2_文字a_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1, 悪タトゥ_文字2_文字a_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2, 悪タトゥ_文字2_文字a_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字b_枠CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字b_枠, 悪タトゥ_文字2_文字b_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1, 悪タトゥ_文字2_文字b_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2, 悪タトゥ_文字2_文字b_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字c_枠CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字c_枠, 悪タトゥ_文字2_文字c_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1, 悪タトゥ_文字2_文字c_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2, 悪タトゥ_文字2_文字c_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字d_枠CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字d_枠, 悪タトゥ_文字2_文字d_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1, 悪タトゥ_文字2_文字d_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2, 悪タトゥ_文字2_文字d_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字e_枠CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字e_枠, 悪タトゥ_文字2_文字e_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1, 悪タトゥ_文字2_文字e_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2, 悪タトゥ_文字2_文字e_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3CP = new ColorP(X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3, 悪タトゥ_文字2_文字e_文字タトゥ3CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_タトゥ1CP = new ColorP(X0Y0_悪タトゥ_通常_タトゥ1, 悪タトゥ_タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字a_枠CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字a_枠, 悪タトゥ_文字1_文字a_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1, 悪タトゥ_文字1_文字a_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2, 悪タトゥ_文字1_文字a_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字b_枠CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字b_枠, 悪タトゥ_文字1_文字b_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1, 悪タトゥ_文字1_文字b_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2, 悪タトゥ_文字1_文字b_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字c_枠CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字c_枠, 悪タトゥ_文字1_文字c_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1, 悪タトゥ_文字1_文字c_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2, 悪タトゥ_文字1_文字c_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字d_枠CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字d_枠, 悪タトゥ_文字1_文字d_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1, 悪タトゥ_文字1_文字d_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2, 悪タトゥ_文字1_文字d_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_枠CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字e_枠, 悪タトゥ_文字1_文字e_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1, 悪タトゥ_文字1_文字e_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2, 悪タトゥ_文字1_文字e_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3, 悪タトゥ_文字1_文字e_文字タトゥ3CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字a_枠CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字a_枠, 悪タトゥ_文字2_文字a_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1, 悪タトゥ_文字2_文字a_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2, 悪タトゥ_文字2_文字a_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字b_枠CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字b_枠, 悪タトゥ_文字2_文字b_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1, 悪タトゥ_文字2_文字b_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2, 悪タトゥ_文字2_文字b_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字c_枠CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字c_枠, 悪タトゥ_文字2_文字c_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1, 悪タトゥ_文字2_文字c_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2, 悪タトゥ_文字2_文字c_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字d_枠CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字d_枠, 悪タトゥ_文字2_文字d_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1, 悪タトゥ_文字2_文字d_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2, 悪タトゥ_文字2_文字d_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_枠CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字e_枠, 悪タトゥ_文字2_文字e_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1, 悪タトゥ_文字2_文字e_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2, 悪タトゥ_文字2_文字e_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3CP = new ColorP(X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3, 悪タトゥ_文字2_文字e_文字タトゥ3CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_タトゥ1CP = new ColorP(X0Y0_悪タトゥ_筋肉_タトゥ1, 悪タトゥ_タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_タトゥ2CP = new ColorP(X0Y0_悪タトゥ_タトゥ2, 悪タトゥ_タトゥ2CD, DisUnit, abj: true);
    		X0Y0_植タトゥ_タトゥCP = new ColorP(X0Y0_植タトゥ_タトゥ, 植タトゥ_タトゥCD, DisUnit, abj: true);
    		X0Y0_植性_通常_葉3CP = new ColorP(X0Y0_植性_通常_葉3, 植性_葉3CD, DisUnit, abj: true);
    		X0Y0_植性_通常_葉2CP = new ColorP(X0Y0_植性_通常_葉2, 植性_葉2CD, DisUnit, abj: true);
    		X0Y0_植性_通常_葉1CP = new ColorP(X0Y0_植性_通常_葉1, 植性_葉1CD, DisUnit, abj: true);
    		X0Y0_植性_欠損_葉3CP = new ColorP(X0Y0_植性_欠損_葉3, 植性_葉3CD, DisUnit, abj: true);
    		X0Y0_植性_欠損_葉2CP = new ColorP(X0Y0_植性_欠損_葉2, 植性_葉2CD, DisUnit, abj: true);
    		X0Y0_植性_欠損_葉1CP = new ColorP(X0Y0_植性_欠損_葉1, 植性_葉1CD, DisUnit, abj: true);
    		X0Y0_傷XCP = new ColorP(X0Y0_傷X, 傷XCD, DisUnit, abj: true);
    		X0Y0_ハイライト_ハイライト1CP = new ColorP(X0Y0_ハイライト_ハイライト1, ハイライト_ハイライト1CD, DisUnit, abj: true);
    		X0Y0_ハイライト_ハイライト2CP = new ColorP(X0Y0_ハイライト_ハイライト2, ハイライト_ハイライト2CD, DisUnit, abj: true);
    		X0Y0_グローブ_通常_グローブCP = new ColorP(X0Y0_グローブ_通常_グローブ, グローブ_グローブCD, DisUnit, abj: true);
    		X0Y0_グローブ_通常_縁CP = new ColorP(X0Y0_グローブ_通常_縁, グローブ_縁CD, DisUnit, abj: true);
    		X0Y0_グローブ_筋肉_グローブCP = new ColorP(X0Y0_グローブ_筋肉_グローブ, グローブ_グローブCD, DisUnit, abj: true);
    		X0Y0_グローブ_筋肉_縁CP = new ColorP(X0Y0_グローブ_筋肉_縁, グローブ_縁CD, DisUnit, abj: true);
    		X0Y0_シャツ_袖1CP = new ColorP(X0Y0_シャツ_袖1, シャツ_袖1CD, DisUnit, abj: true);
    		X0Y0_シャツ_袖2CP = new ColorP(X0Y0_シャツ_袖2, シャツ_袖2CD, DisUnit, abj: true);
    		X0Y0_シャツ_縁CP = new ColorP(X0Y0_シャツ_縁, シャツ_縁CD, DisUnit, abj: true);
    		X0Y0_ナース_袖1CP = new ColorP(X0Y0_ナース_袖1, ナース_袖1CD, DisUnit, abj: true);
    		X0Y0_ナース_袖2CP = new ColorP(X0Y0_ナース_袖2, ナース_袖2CD, DisUnit, abj: true);
    		X0Y0_ナース_縁CP = new ColorP(X0Y0_ナース_縁, ナース_縁CD, DisUnit, abj: true);
    		X0Y0_鎧_ベルト_ベルト1CP = new ColorP(X0Y0_鎧_ベルト_ベルト1, 鎧_ベルト_ベルト1CD, DisUnit, abj: true);
    		X0Y0_鎧_ベルト_ベルト2CP = new ColorP(X0Y0_鎧_ベルト_ベルト2, 鎧_ベルト_ベルト2CD, DisUnit, abj: true);
    		X0Y0_鎧_鎧_鎧1CP = new ColorP(X0Y0_鎧_鎧_鎧1, 鎧_鎧_鎧1CD, DisUnit, abj: true);
    		X0Y0_鎧_鎧_鎧2CP = new ColorP(X0Y0_鎧_鎧_鎧2, 鎧_鎧_鎧2CD, DisUnit, abj: true);
    		傷X濃度 = e.傷X濃度;
    		ハイライト濃度 = e.ハイライト濃度;
    		濃度 = e.濃度;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_筋肉上);
    		Are.Draw(X0Y0_上腕);
    		Are.Draw(X0Y0_筋肉下);
    		Are.Draw(X0Y0_紋柄_紋1);
    		Are.Draw(X0Y0_紋柄_紋2);
    		Are.Draw(X0Y0_紋柄_紋3);
    		Are.Draw(X0Y0_紋柄_紋4);
    		Are.Draw(X0Y0_虫性_虫腕);
    		Are.Draw(X0Y0_虫性_筋肉下);
    		Are.Draw(X0Y0_淫タトゥ_ハート_タトゥ左);
    		Are.Draw(X0Y0_淫タトゥ_ハート_タトゥ右);
    		Are.Draw(X0Y0_淫タトゥ_タトゥ1);
    		Are.Draw(X0Y0_淫タトゥ_タトゥ2);
    		Are.Draw(X0Y0_淫タトゥ_タトゥ3);
    		Are.Draw(X0Y0_淫タトゥ_タトゥ4);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字a_枠);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字b_枠);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字c_枠);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字d_枠);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字e_枠);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字a_枠);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字b_枠);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字c_枠);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字d_枠);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字e_枠);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3);
    		Are.Draw(X0Y0_悪タトゥ_通常_タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字a_枠);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字b_枠);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字c_枠);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字d_枠);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字e_枠);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字a_枠);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字b_枠);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字c_枠);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字d_枠);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字e_枠);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_タトゥ1);
    		Are.Draw(X0Y0_悪タトゥ_タトゥ2);
    		Are.Draw(X0Y0_植タトゥ_タトゥ);
    		Are.Draw(X0Y0_獣性_獣毛1);
    		Are.Draw(X0Y0_獣性_獣毛2);
    		Are.Draw(X0Y0_傷X);
    		キスマーク.Draw(Are);
    		鞭痕.Draw(Are);
    		Are.Draw(X0Y0_竜性_鱗4);
    		Are.Draw(X0Y0_竜性_鱗3);
    		Are.Draw(X0Y0_竜性_鱗2);
    		Are.Draw(X0Y0_竜性_鱗1);
    		Are.Draw(X0Y0_竜性_鱗5);
    		Are.Draw(X0Y0_ハイライト_ハイライト1);
    		Are.Draw(X0Y0_ハイライト_ハイライト2);
    		Are.Draw(X0Y0_植性_通常_葉3);
    		Are.Draw(X0Y0_植性_通常_葉2);
    		Are.Draw(X0Y0_植性_通常_葉1);
    		Are.Draw(X0Y0_植性_欠損_葉3);
    		Are.Draw(X0Y0_植性_欠損_葉2);
    		Are.Draw(X0Y0_植性_欠損_葉1);
    	}

    	public void 鎧描画(RenderArea Are)
    	{
    		Are.Draw(X0Y0_鎧_ベルト_ベルト1);
    		Are.Draw(X0Y0_鎧_ベルト_ベルト2);
    		Are.Draw(X0Y0_鎧_鎧_鎧1);
    		Are.Draw(X0Y0_鎧_鎧_鎧2);
    	}

    	public override void SetRestraintAngle()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_上腕.AngleBase = num * -30.0;
    		尺度XC = 0.95;
    		本体.JoinPAall();
    	}

    	public override bool Is布(Par p)
    	{
    		if (p != X0Y0_グローブ_通常_グローブ && p != X0Y0_グローブ_通常_縁 && p != X0Y0_グローブ_筋肉_グローブ && p != X0Y0_グローブ_筋肉_縁 && p != X0Y0_シャツ_袖1 && p != X0Y0_シャツ_袖2 && p != X0Y0_シャツ_縁 && p != X0Y0_ナース_袖1 && p != X0Y0_ナース_袖2)
    		{
    			return p == X0Y0_ナース_縁;
    		}
    		return true;
    	}

    	public override bool Is鉄(Par p)
    	{
    		if (p != X0Y0_鎧_ベルト_ベルト1 && p != X0Y0_鎧_ベルト_ベルト2 && p != X0Y0_鎧_鎧_鎧1)
    		{
    			return p == X0Y0_鎧_鎧_鎧2;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_筋肉上CP.Update();
    		X0Y0_上腕CP.Update();
    		X0Y0_虫性_虫腕CP.Update();
    		X0Y0_虫性_筋肉下CP.Update();
    		X0Y0_筋肉下CP.Update();
    		X0Y0_紋柄_紋1CP.Update();
    		X0Y0_紋柄_紋2CP.Update();
    		X0Y0_紋柄_紋3CP.Update();
    		X0Y0_紋柄_紋4CP.Update();
    		X0Y0_獣性_獣毛1CP.Update();
    		X0Y0_獣性_獣毛2CP.Update();
    		X0Y0_鱗_鱗4CP.Update();
    		X0Y0_鱗_鱗3CP.Update();
    		X0Y0_鱗_鱗2CP.Update();
    		X0Y0_鱗_鱗1CP.Update();
    		X0Y0_鱗_鱗5CP.Update();
    		X0Y0_淫タトゥ_ハート_タトゥ左CP.Update();
    		X0Y0_淫タトゥ_ハート_タトゥ右CP.Update();
    		X0Y0_淫タトゥ_タトゥ1CP.Update();
    		X0Y0_淫タトゥ_タトゥ2CP.Update();
    		X0Y0_淫タトゥ_タトゥ3CP.Update();
    		X0Y0_淫タトゥ_タトゥ4CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字a_枠CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字b_枠CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字c_枠CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字d_枠CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字e_枠CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字a_枠CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字b_枠CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字c_枠CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字d_枠CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字e_枠CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3CP.Update();
    		X0Y0_悪タトゥ_通常_タトゥ1CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字a_枠CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字b_枠CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字c_枠CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字d_枠CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_枠CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字a_枠CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字b_枠CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字c_枠CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字d_枠CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_枠CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2CP.Update();
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3CP.Update();
    		X0Y0_悪タトゥ_筋肉_タトゥ1CP.Update();
    		X0Y0_悪タトゥ_タトゥ2CP.Update();
    		X0Y0_植タトゥ_タトゥCP.Update();
    		X0Y0_植性_通常_葉3CP.Update();
    		X0Y0_植性_通常_葉2CP.Update();
    		X0Y0_植性_通常_葉1CP.Update();
    		X0Y0_植性_欠損_葉3CP.Update();
    		X0Y0_植性_欠損_葉2CP.Update();
    		X0Y0_植性_欠損_葉1CP.Update();
    		X0Y0_傷XCP.Update();
    		X0Y0_ハイライト_ハイライト1CP.Update();
    		X0Y0_ハイライト_ハイライト2CP.Update();
    		X0Y0_グローブ_通常_グローブCP.Update();
    		X0Y0_グローブ_通常_縁CP.Update();
    		X0Y0_グローブ_筋肉_グローブCP.Update();
    		X0Y0_グローブ_筋肉_縁CP.Update();
    		X0Y0_シャツ_袖1CP.Update();
    		X0Y0_シャツ_袖2CP.Update();
    		X0Y0_シャツ_縁CP.Update();
    		X0Y0_ナース_袖1CP.Update();
    		X0Y0_ナース_袖2CP.Update();
    		X0Y0_ナース_縁CP.Update();
    		X0Y0_鎧_ベルト_ベルト1CP.Update();
    		X0Y0_鎧_ベルト_ベルト2CP.Update();
    		X0Y0_鎧_鎧_鎧1CP.Update();
    		X0Y0_鎧_鎧_鎧2CP.Update();
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
    		筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		上腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		虫性_虫腕CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性_筋肉下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		獣性_獣毛1CD = new ColorD();
    		獣性_獣毛1CD.c = Col.Black;
    		獣性_獣毛1CD.c2.Col1 = 体配色.毛0O.Col1;
    		獣性_獣毛1CD.c2.Col2 = 体配色.毛0O.Col1;
    		獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		淫タトゥ_ハート_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ4CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植性_葉3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性_葉2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性_葉1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		ハイライト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		ハイライト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		グローブ_グローブCD = new ColorD();
    		グローブ_縁CD = new ColorD();
    		シャツ_袖1CD = new ColorD();
    		シャツ_袖2CD = new ColorD();
    		シャツ_縁CD = new ColorD();
    		ナース_袖1CD = new ColorD();
    		ナース_袖2CD = new ColorD();
    		ナース_縁CD = new ColorD();
    		鎧_ベルト_ベルト1CD = new ColorD();
    		鎧_ベルト_ベルト2CD = new ColorD();
    		鎧_鎧_鎧1CD = new ColorD();
    		鎧_鎧_鎧2CD = new ColorD();
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		上腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		虫性_虫腕CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性_筋肉下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		獣性_獣毛1CD = new ColorD();
    		獣性_獣毛1CD.c = Col.Black;
    		獣性_獣毛1CD.c2.Col1 = 体配色.毛0O.Col1;
    		獣性_獣毛1CD.c2.Col2 = 体配色.毛0O.Col1;
    		獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		淫タトゥ_ハート_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ4CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植性_葉3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		植性_葉2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性_葉1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		ハイライト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		ハイライト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		グローブ_グローブCD = new ColorD();
    		グローブ_縁CD = new ColorD();
    		シャツ_袖1CD = new ColorD();
    		シャツ_袖2CD = new ColorD();
    		シャツ_縁CD = new ColorD();
    		ナース_袖1CD = new ColorD();
    		ナース_袖2CD = new ColorD();
    		ナース_縁CD = new ColorD();
    		鎧_ベルト_ベルト1CD = new ColorD();
    		鎧_ベルト_ベルト2CD = new ColorD();
    		鎧_鎧_鎧1CD = new ColorD();
    		鎧_鎧_鎧2CD = new ColorD();
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		上腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		虫性_虫腕CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性_筋肉下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		獣性_獣毛1CD = new ColorD();
    		獣性_獣毛1CD.c = Col.Black;
    		獣性_獣毛1CD.c2.Col1 = 体配色.毛0O.Col1;
    		獣性_獣毛1CD.c2.Col2 = 体配色.毛0O.Col1;
    		獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		淫タトゥ_ハート_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ4CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植タトゥ_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植性_葉3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性_葉2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		植性_葉1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		ハイライト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		ハイライト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		グローブ_グローブCD = new ColorD();
    		グローブ_縁CD = new ColorD();
    		シャツ_袖1CD = new ColorD();
    		シャツ_袖2CD = new ColorD();
    		シャツ_縁CD = new ColorD();
    		ナース_袖1CD = new ColorD();
    		ナース_袖2CD = new ColorD();
    		ナース_縁CD = new ColorD();
    		鎧_ベルト_ベルト1CD = new ColorD();
    		鎧_ベルト_ベルト2CD = new ColorD();
    		鎧_鎧_鎧1CD = new ColorD();
    		鎧_鎧_鎧2CD = new ColorD();
    	}
    }
}
