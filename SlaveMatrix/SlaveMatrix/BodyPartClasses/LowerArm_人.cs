using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class LowerArm_人 : LowerArm
    {
    	public ShapePart X0Y0_LowerArm;

    	public ShapePart X0Y0_筋肉_筋肉下;

    	public ShapePart X0Y0_筋肉_筋肉上;

    	public ShapePart X0Y0_植性1_通常_花弁_花弁;

    	public ShapePart X0Y0_植性1_通常_花弁_影_花弁影1;

    	public ShapePart X0Y0_植性1_通常_花弁_影_花弁影2;

    	public ShapePart X0Y0_植性1_通常_花弁_影_花弁影3;

    	public ShapePart X0Y0_植性1_通常_花弁_影_花弁影4;

    	public ShapePart X0Y0_植性1_通常_花弁_影_花弁影5;

    	public ShapePart X0Y0_植性1_欠損_花弁_花弁;

    	public ShapePart X0Y0_植性1_欠損_花弁_影_花弁影1;

    	public ShapePart X0Y0_植性1_欠損_花弁_影_花弁影2;

    	public ShapePart X0Y0_植性1_欠損_花弁_影_花弁影3;

    	public ShapePart X0Y0_植性1_欠損_花弁_影_花弁影4;

    	public ShapePart X0Y0_植性1_欠損_花弁_影_花弁影5;

    	public ShapePart X0Y0_獣性1_獣腕;

    	public ShapePart X0Y0_竜性1_肘_肘1;

    	public ShapePart X0Y0_竜性1_肘_肘2;

    	public ShapePart X0Y0_竜性1_鱗_鱗5;

    	public ShapePart X0Y0_竜性1_鱗_鱗4;

    	public ShapePart X0Y0_竜性1_鱗_鱗3;

    	public ShapePart X0Y0_竜性1_鱗_鱗2;

    	public ShapePart X0Y0_竜性1_鱗_鱗1;

    	public ShapePart X0Y0_竜性1_手首_鱗3;

    	public ShapePart X0Y0_竜性1_手首_鱗2;

    	public ShapePart X0Y0_竜性1_手首_鱗1;

    	public ShapePart X0Y0_虫性1_虫肘;

    	public ShapePart X0Y0_虫性1_虫腕上;

    	public ShapePart X0Y0_淫タトゥ_手首_タトゥ;

    	public ShapePart X0Y0_淫タトゥ_手首_ハート1_タトゥ左;

    	public ShapePart X0Y0_淫タトゥ_手首_ハート1_タトゥ右;

    	public ShapePart X0Y0_淫タトゥ_手首_ハート3_タトゥ左;

    	public ShapePart X0Y0_淫タトゥ_手首_ハート3_タトゥ右;

    	public ShapePart X0Y0_淫タトゥ_手首_ハート2_タトゥ左;

    	public ShapePart X0Y0_淫タトゥ_手首_ハート2_タトゥ右;

    	public ShapePart X0Y0_淫タトゥ_通常_ハート1_タトゥ左;

    	public ShapePart X0Y0_淫タトゥ_通常_ハート1_タトゥ右;

    	public ShapePart X0Y0_淫タトゥ_通常_ハート2_タトゥ左;

    	public ShapePart X0Y0_淫タトゥ_通常_ハート2_タトゥ右;

    	public ShapePart X0Y0_淫タトゥ_筋肉_ハート1_タトゥ左;

    	public ShapePart X0Y0_淫タトゥ_筋肉_ハート1_タトゥ右;

    	public ShapePart X0Y0_淫タトゥ_筋肉_ハート2_タトゥ左;

    	public ShapePart X0Y0_淫タトゥ_筋肉_ハート2_タトゥ右;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字a_枠;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字b_枠;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字c_枠;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字d_枠;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字e_枠;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字a_枠;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字b_枠;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字c_枠;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字d_枠;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字e_枠;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3;

    	public ShapePart X0Y0_悪タトゥ_通常_タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_通常_タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_通常_逆十字_逆十字1;

    	public ShapePart X0Y0_悪タトゥ_通常_逆十字_逆十字2;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字a_枠;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字b_枠;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字c_枠;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字d_枠;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字e_枠;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字a_枠;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字b_枠;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字c_枠;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字d_枠;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字e_枠;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3;

    	public ShapePart X0Y0_悪タトゥ_筋肉_タトゥ1;

    	public ShapePart X0Y0_悪タトゥ_筋肉_タトゥ2;

    	public ShapePart X0Y0_悪タトゥ_筋肉_逆十字_逆十字1;

    	public ShapePart X0Y0_悪タトゥ_筋肉_逆十字_逆十字2;

    	public ShapePart X0Y0_植性2_通常_萼_萼上;

    	public ShapePart X0Y0_植性2_通常_萼_萼下;

    	public ShapePart X0Y0_植性2_通常_萼_萼中;

    	public ShapePart X0Y0_植性2_欠損_萼_萼上;

    	public ShapePart X0Y0_植性2_欠損_萼_萼下;

    	public ShapePart X0Y0_植性2_欠損_萼_萼中;

    	public ShapePart X0Y0_獣性2_獣毛;

    	public ShapePart X0Y0_竜性2_棘_棘5;

    	public ShapePart X0Y0_竜性2_棘_棘4;

    	public ShapePart X0Y0_竜性2_棘_棘3;

    	public ShapePart X0Y0_竜性2_棘_棘2;

    	public ShapePart X0Y0_竜性2_棘_棘1;

    	public ShapePart X0Y0_虫性2_虫腕下;

    	public ShapePart X0Y0_虫性2_虫棘1;

    	public ShapePart X0Y0_虫性2_虫棘2;

    	public ShapePart X0Y0_虫性2_虫棘3;

    	public ShapePart X0Y0_虫性2_虫棘4;

    	public ShapePart X0Y0_虫性2_虫鎌節;

    	public ShapePart X0Y0_傷X1;

    	public ShapePart X0Y0_傷I1;

    	public ShapePart X0Y0_傷I2;

    	public ShapePart X0Y0_ハイライト;

    	public ShapePart X0Y0_グローブ_通常_グローブ;

    	public ShapePart X0Y0_グローブ_通常_縁;

    	public ShapePart X0Y0_グローブ_筋肉_グローブ;

    	public ShapePart X0Y0_グローブ_筋肉_縁;

    	public ShapePart X0Y0_鎧_ベルト_ベルト1;

    	public ShapePart X0Y0_鎧_ベルト_通常_ベルト2;

    	public ShapePart X0Y0_鎧_ベルト_筋肉_ベルト2;

    	public ShapePart X0Y0_鎧_鎧_鎧2;

    	public ShapePart X0Y0_鎧_鎧_鎧1;

    	public ShapePart X0Y0_腕輪_革;

    	public ShapePart X0Y0_腕輪_金具1;

    	public ShapePart X0Y0_腕輪_金具2;

    	public ShapePart X0Y0_腕輪_金具3;

    	public ShapePart X0Y0_腕輪_金具左;

    	public ShapePart X0Y0_腕輪_金具右;

    	public ColorD LowerArmCD;

    	public ColorD 筋肉_筋肉下CD;

    	public ColorD 筋肉_筋肉上CD;

    	public ColorD 植性1_花弁_花弁CD;

    	public ColorD 植性1_花弁_影_花弁影1CD;

    	public ColorD 植性1_花弁_影_花弁影2CD;

    	public ColorD 植性1_花弁_影_花弁影3CD;

    	public ColorD 植性1_花弁_影_花弁影4CD;

    	public ColorD 植性1_花弁_影_花弁影5CD;

    	public ColorD 獣性1_獣腕CD;

    	public ColorD 竜性1_肘_肘1CD;

    	public ColorD 竜性1_肘_肘2CD;

    	public ColorD 竜性1_鱗_鱗5CD;

    	public ColorD 竜性1_鱗_鱗4CD;

    	public ColorD 竜性1_鱗_鱗3CD;

    	public ColorD 竜性1_鱗_鱗2CD;

    	public ColorD 竜性1_鱗_鱗1CD;

    	public ColorD 竜性1_手首_鱗3CD;

    	public ColorD 竜性1_手首_鱗2CD;

    	public ColorD 竜性1_手首_鱗1CD;

    	public ColorD 虫性1_虫肘CD;

    	public ColorD 虫性1_虫腕上CD;

    	public ColorD 淫タトゥ_手首_タトゥCD;

    	public ColorD 淫タトゥ_手首_ハート1_タトゥ左CD;

    	public ColorD 淫タトゥ_手首_ハート1_タトゥ右CD;

    	public ColorD 淫タトゥ_手首_ハート3_タトゥ左CD;

    	public ColorD 淫タトゥ_手首_ハート3_タトゥ右CD;

    	public ColorD 淫タトゥ_手首_ハート2_タトゥ左CD;

    	public ColorD 淫タトゥ_手首_ハート2_タトゥ右CD;

    	public ColorD 淫タトゥ_ハート1_タトゥ左CD;

    	public ColorD 淫タトゥ_ハート1_タトゥ右CD;

    	public ColorD 淫タトゥ_ハート2_タトゥ左CD;

    	public ColorD 淫タトゥ_ハート2_タトゥ右CD;

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

    	public ColorD 悪タトゥ_逆十字_逆十字1CD;

    	public ColorD 悪タトゥ_逆十字_逆十字2CD;

    	public ColorD 植性2_萼_萼上CD;

    	public ColorD 植性2_萼_萼下CD;

    	public ColorD 植性2_萼_萼中CD;

    	public ColorD 獣性2_獣毛CD;

    	public ColorD 竜性2_棘_棘5CD;

    	public ColorD 竜性2_棘_棘4CD;

    	public ColorD 竜性2_棘_棘3CD;

    	public ColorD 竜性2_棘_棘2CD;

    	public ColorD 竜性2_棘_棘1CD;

    	public ColorD 虫性2_虫腕下CD;

    	public ColorD 虫性2_虫棘1CD;

    	public ColorD 虫性2_虫棘2CD;

    	public ColorD 虫性2_虫棘3CD;

    	public ColorD 虫性2_虫棘4CD;

    	public ColorD 虫性2_虫鎌節CD;

    	public ColorD 傷X1CD;

    	public ColorD 傷I1CD;

    	public ColorD 傷I2CD;

    	public ColorD ハイライトCD;

    	public ColorD グローブ_グローブCD;

    	public ColorD グローブ_縁CD;

    	public ColorD 鎧_ベルト_ベルト1CD;

    	public ColorD 鎧_ベルト_ベルト2CD;

    	public ColorD 鎧_鎧_鎧2CD;

    	public ColorD 鎧_鎧_鎧1CD;

    	public ColorD 腕輪_革CD;

    	public ColorD 腕輪_金具1CD;

    	public ColorD 腕輪_金具2CD;

    	public ColorD 腕輪_金具3CD;

    	public ColorD 腕輪_金具左CD;

    	public ColorD 腕輪_金具右CD;

    	public ColorP X0Y0_LowerArmCP;

    	public ColorP X0Y0_筋肉_筋肉下CP;

    	public ColorP X0Y0_筋肉_筋肉上CP;

    	public ColorP X0Y0_植性1_通常_花弁_花弁CP;

    	public ColorP X0Y0_植性1_通常_花弁_影_花弁影1CP;

    	public ColorP X0Y0_植性1_通常_花弁_影_花弁影2CP;

    	public ColorP X0Y0_植性1_通常_花弁_影_花弁影3CP;

    	public ColorP X0Y0_植性1_通常_花弁_影_花弁影4CP;

    	public ColorP X0Y0_植性1_通常_花弁_影_花弁影5CP;

    	public ColorP X0Y0_植性1_欠損_花弁_花弁CP;

    	public ColorP X0Y0_植性1_欠損_花弁_影_花弁影1CP;

    	public ColorP X0Y0_植性1_欠損_花弁_影_花弁影2CP;

    	public ColorP X0Y0_植性1_欠損_花弁_影_花弁影3CP;

    	public ColorP X0Y0_植性1_欠損_花弁_影_花弁影4CP;

    	public ColorP X0Y0_植性1_欠損_花弁_影_花弁影5CP;

    	public ColorP X0Y0_獣性1_獣腕CP;

    	public ColorP X0Y0_竜性1_肘_肘1CP;

    	public ColorP X0Y0_竜性1_肘_肘2CP;

    	public ColorP X0Y0_竜性1_鱗_鱗5CP;

    	public ColorP X0Y0_竜性1_鱗_鱗4CP;

    	public ColorP X0Y0_竜性1_鱗_鱗3CP;

    	public ColorP X0Y0_竜性1_鱗_鱗2CP;

    	public ColorP X0Y0_竜性1_鱗_鱗1CP;

    	public ColorP X0Y0_竜性1_手首_鱗3CP;

    	public ColorP X0Y0_竜性1_手首_鱗2CP;

    	public ColorP X0Y0_竜性1_手首_鱗1CP;

    	public ColorP X0Y0_虫性1_虫肘CP;

    	public ColorP X0Y0_虫性1_虫腕上CP;

    	public ColorP X0Y0_淫タトゥ_手首_タトゥCP;

    	public ColorP X0Y0_淫タトゥ_手首_ハート1_タトゥ左CP;

    	public ColorP X0Y0_淫タトゥ_手首_ハート1_タトゥ右CP;

    	public ColorP X0Y0_淫タトゥ_手首_ハート3_タトゥ左CP;

    	public ColorP X0Y0_淫タトゥ_手首_ハート3_タトゥ右CP;

    	public ColorP X0Y0_淫タトゥ_手首_ハート2_タトゥ左CP;

    	public ColorP X0Y0_淫タトゥ_手首_ハート2_タトゥ右CP;

    	public ColorP X0Y0_淫タトゥ_通常_ハート1_タトゥ左CP;

    	public ColorP X0Y0_淫タトゥ_通常_ハート1_タトゥ右CP;

    	public ColorP X0Y0_淫タトゥ_通常_ハート2_タトゥ左CP;

    	public ColorP X0Y0_淫タトゥ_通常_ハート2_タトゥ右CP;

    	public ColorP X0Y0_淫タトゥ_筋肉_ハート1_タトゥ左CP;

    	public ColorP X0Y0_淫タトゥ_筋肉_ハート1_タトゥ右CP;

    	public ColorP X0Y0_淫タトゥ_筋肉_ハート2_タトゥ左CP;

    	public ColorP X0Y0_淫タトゥ_筋肉_ハート2_タトゥ右CP;

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

    	public ColorP X0Y0_悪タトゥ_通常_タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_通常_逆十字_逆十字1CP;

    	public ColorP X0Y0_悪タトゥ_通常_逆十字_逆十字2CP;

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

    	public ColorP X0Y0_悪タトゥ_筋肉_タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_逆十字_逆十字1CP;

    	public ColorP X0Y0_悪タトゥ_筋肉_逆十字_逆十字2CP;

    	public ColorP X0Y0_植性2_通常_萼_萼上CP;

    	public ColorP X0Y0_植性2_通常_萼_萼下CP;

    	public ColorP X0Y0_植性2_通常_萼_萼中CP;

    	public ColorP X0Y0_植性2_欠損_萼_萼上CP;

    	public ColorP X0Y0_植性2_欠損_萼_萼下CP;

    	public ColorP X0Y0_植性2_欠損_萼_萼中CP;

    	public ColorP X0Y0_獣性2_獣毛CP;

    	public ColorP X0Y0_竜性2_棘_棘5CP;

    	public ColorP X0Y0_竜性2_棘_棘4CP;

    	public ColorP X0Y0_竜性2_棘_棘3CP;

    	public ColorP X0Y0_竜性2_棘_棘2CP;

    	public ColorP X0Y0_竜性2_棘_棘1CP;

    	public ColorP X0Y0_虫性2_虫腕下CP;

    	public ColorP X0Y0_虫性2_虫棘1CP;

    	public ColorP X0Y0_虫性2_虫棘2CP;

    	public ColorP X0Y0_虫性2_虫棘3CP;

    	public ColorP X0Y0_虫性2_虫棘4CP;

    	public ColorP X0Y0_虫性2_虫鎌節CP;

    	public ColorP X0Y0_傷X1CP;

    	public ColorP X0Y0_傷I1CP;

    	public ColorP X0Y0_傷I2CP;

    	public ColorP X0Y0_ハイライトCP;

    	public ColorP X0Y0_グローブ_通常_グローブCP;

    	public ColorP X0Y0_グローブ_通常_縁CP;

    	public ColorP X0Y0_グローブ_筋肉_グローブCP;

    	public ColorP X0Y0_グローブ_筋肉_縁CP;

    	public ColorP X0Y0_鎧_ベルト_ベルト1CP;

    	public ColorP X0Y0_鎧_ベルト_通常_ベルト2CP;

    	public ColorP X0Y0_鎧_ベルト_筋肉_ベルト2CP;

    	public ColorP X0Y0_鎧_鎧_鎧2CP;

    	public ColorP X0Y0_鎧_鎧_鎧1CP;

    	public ColorP X0Y0_腕輪_革CP;

    	public ColorP X0Y0_腕輪_金具1CP;

    	public ColorP X0Y0_腕輪_金具2CP;

    	public ColorP X0Y0_腕輪_金具3CP;

    	public ColorP X0Y0_腕輪_金具左CP;

    	public ColorP X0Y0_腕輪_金具右CP;

    	public 拘束鎖 鎖1;

    	public スタンプK キスマーク;

    	public スタンプW 鞭痕;

    	public Element[] 外腕_接続;

    	public Element[] 虫鎌_接続;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    			植性1_花弁_花弁_表示 = 植性1_花弁_花弁_表示;
    			植性1_花弁_影_花弁影1_表示 = 植性1_花弁_影_花弁影1_表示;
    			植性1_花弁_影_花弁影2_表示 = 植性1_花弁_影_花弁影2_表示;
    			植性1_花弁_影_花弁影3_表示 = 植性1_花弁_影_花弁影3_表示;
    			植性1_花弁_影_花弁影4_表示 = 植性1_花弁_影_花弁影4_表示;
    			植性1_花弁_影_花弁影5_表示 = 植性1_花弁_影_花弁影5_表示;
    			植性2_萼_萼上_表示 = 植性2_萼_萼上_表示;
    			植性2_萼_萼下_表示 = 植性2_萼_萼下_表示;
    			植性2_萼_萼中_表示 = 植性2_萼_萼中_表示;
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
    			筋肉_筋肉下_表示 = 筋肉_;
    			筋肉_筋肉上_表示 = 筋肉_;
    			淫タトゥ_ハート1_タトゥ左_表示 = 淫タトゥ_ハート1_タトゥ左_表示;
    			淫タトゥ_ハート1_タトゥ右_表示 = 淫タトゥ_ハート1_タトゥ右_表示;
    			淫タトゥ_ハート2_タトゥ左_表示 = 淫タトゥ_ハート2_タトゥ左_表示;
    			淫タトゥ_ハート2_タトゥ右_表示 = 淫タトゥ_ハート2_タトゥ右_表示;
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
    			悪タトゥ_タトゥ2_表示 = 悪タトゥ_タトゥ2_表示;
    			悪タトゥ_逆十字_逆十字1_表示 = 悪タトゥ_逆十字_逆十字1_表示;
    			悪タトゥ_逆十字_逆十字2_表示 = 悪タトゥ_逆十字_逆十字2_表示;
    			グローブ_グローブ_表示 = グローブ_グローブ_表示;
    			グローブ_縁_表示 = グローブ_縁_表示;
    			鎧_ベルト_ベルト2_表示 = 鎧_ベルト_ベルト2_表示;
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

    	public bool LowerArm_表示
    	{
    		get
    		{
    			return X0Y0_LowerArm.Dra;
    		}
    		set
    		{
    			X0Y0_LowerArm.Dra = value;
    			X0Y0_LowerArm.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉下_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉下.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉下.Dra = value;
    			X0Y0_筋肉_筋肉下.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉上_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉上.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉上.Dra = value;
    			X0Y0_筋肉_筋肉上.Hit = value;
    		}
    	}

    	public bool 植性1_通常_花弁_花弁_表示
    	{
    		get
    		{
    			return X0Y0_植性1_通常_花弁_花弁.Dra;
    		}
    		set
    		{
    			X0Y0_植性1_通常_花弁_花弁.Dra = value;
    			X0Y0_植性1_通常_花弁_花弁.Hit = value;
    		}
    	}

    	public bool 植性1_通常_花弁_影_花弁影1_表示
    	{
    		get
    		{
    			return X0Y0_植性1_通常_花弁_影_花弁影1.Dra;
    		}
    		set
    		{
    			X0Y0_植性1_通常_花弁_影_花弁影1.Dra = value;
    			X0Y0_植性1_通常_花弁_影_花弁影1.Hit = value;
    		}
    	}

    	public bool 植性1_通常_花弁_影_花弁影2_表示
    	{
    		get
    		{
    			return X0Y0_植性1_通常_花弁_影_花弁影2.Dra;
    		}
    		set
    		{
    			X0Y0_植性1_通常_花弁_影_花弁影2.Dra = value;
    			X0Y0_植性1_通常_花弁_影_花弁影2.Hit = value;
    		}
    	}

    	public bool 植性1_通常_花弁_影_花弁影3_表示
    	{
    		get
    		{
    			return X0Y0_植性1_通常_花弁_影_花弁影3.Dra;
    		}
    		set
    		{
    			X0Y0_植性1_通常_花弁_影_花弁影3.Dra = value;
    			X0Y0_植性1_通常_花弁_影_花弁影3.Hit = value;
    		}
    	}

    	public bool 植性1_通常_花弁_影_花弁影4_表示
    	{
    		get
    		{
    			return X0Y0_植性1_通常_花弁_影_花弁影4.Dra;
    		}
    		set
    		{
    			X0Y0_植性1_通常_花弁_影_花弁影4.Dra = value;
    			X0Y0_植性1_通常_花弁_影_花弁影4.Hit = value;
    		}
    	}

    	public bool 植性1_通常_花弁_影_花弁影5_表示
    	{
    		get
    		{
    			return X0Y0_植性1_通常_花弁_影_花弁影5.Dra;
    		}
    		set
    		{
    			X0Y0_植性1_通常_花弁_影_花弁影5.Dra = value;
    			X0Y0_植性1_通常_花弁_影_花弁影5.Hit = value;
    		}
    	}

    	public bool 植性1_欠損_花弁_花弁_表示
    	{
    		get
    		{
    			return X0Y0_植性1_欠損_花弁_花弁.Dra;
    		}
    		set
    		{
    			X0Y0_植性1_欠損_花弁_花弁.Dra = value;
    			X0Y0_植性1_欠損_花弁_花弁.Hit = value;
    		}
    	}

    	public bool 植性1_欠損_花弁_影_花弁影1_表示
    	{
    		get
    		{
    			return X0Y0_植性1_欠損_花弁_影_花弁影1.Dra;
    		}
    		set
    		{
    			X0Y0_植性1_欠損_花弁_影_花弁影1.Dra = value;
    			X0Y0_植性1_欠損_花弁_影_花弁影1.Hit = value;
    		}
    	}

    	public bool 植性1_欠損_花弁_影_花弁影2_表示
    	{
    		get
    		{
    			return X0Y0_植性1_欠損_花弁_影_花弁影2.Dra;
    		}
    		set
    		{
    			X0Y0_植性1_欠損_花弁_影_花弁影2.Dra = value;
    			X0Y0_植性1_欠損_花弁_影_花弁影2.Hit = value;
    		}
    	}

    	public bool 植性1_欠損_花弁_影_花弁影3_表示
    	{
    		get
    		{
    			return X0Y0_植性1_欠損_花弁_影_花弁影3.Dra;
    		}
    		set
    		{
    			X0Y0_植性1_欠損_花弁_影_花弁影3.Dra = value;
    			X0Y0_植性1_欠損_花弁_影_花弁影3.Hit = value;
    		}
    	}

    	public bool 植性1_欠損_花弁_影_花弁影4_表示
    	{
    		get
    		{
    			return X0Y0_植性1_欠損_花弁_影_花弁影4.Dra;
    		}
    		set
    		{
    			X0Y0_植性1_欠損_花弁_影_花弁影4.Dra = value;
    			X0Y0_植性1_欠損_花弁_影_花弁影4.Hit = value;
    		}
    	}

    	public bool 植性1_欠損_花弁_影_花弁影5_表示
    	{
    		get
    		{
    			return X0Y0_植性1_欠損_花弁_影_花弁影5.Dra;
    		}
    		set
    		{
    			X0Y0_植性1_欠損_花弁_影_花弁影5.Dra = value;
    			X0Y0_植性1_欠損_花弁_影_花弁影5.Hit = value;
    		}
    	}

    	public bool 獣性1_獣腕_表示
    	{
    		get
    		{
    			return X0Y0_獣性1_獣腕.Dra;
    		}
    		set
    		{
    			X0Y0_獣性1_獣腕.Dra = value;
    			X0Y0_獣性1_獣腕.Hit = value;
    		}
    	}

    	public bool 竜性1_肘_肘1_表示
    	{
    		get
    		{
    			return X0Y0_竜性1_肘_肘1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性1_肘_肘1.Dra = value;
    			X0Y0_竜性1_肘_肘1.Hit = value;
    		}
    	}

    	public bool 竜性1_肘_肘2_表示
    	{
    		get
    		{
    			return X0Y0_竜性1_肘_肘2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性1_肘_肘2.Dra = value;
    			X0Y0_竜性1_肘_肘2.Hit = value;
    		}
    	}

    	public bool 竜性1_鱗_鱗5_表示
    	{
    		get
    		{
    			return X0Y0_竜性1_鱗_鱗5.Dra;
    		}
    		set
    		{
    			X0Y0_竜性1_鱗_鱗5.Dra = value;
    			X0Y0_竜性1_鱗_鱗5.Hit = value;
    		}
    	}

    	public bool 竜性1_鱗_鱗4_表示
    	{
    		get
    		{
    			return X0Y0_竜性1_鱗_鱗4.Dra;
    		}
    		set
    		{
    			X0Y0_竜性1_鱗_鱗4.Dra = value;
    			X0Y0_竜性1_鱗_鱗4.Hit = value;
    		}
    	}

    	public bool 竜性1_鱗_鱗3_表示
    	{
    		get
    		{
    			return X0Y0_竜性1_鱗_鱗3.Dra;
    		}
    		set
    		{
    			X0Y0_竜性1_鱗_鱗3.Dra = value;
    			X0Y0_竜性1_鱗_鱗3.Hit = value;
    		}
    	}

    	public bool 竜性1_鱗_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性1_鱗_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性1_鱗_鱗2.Dra = value;
    			X0Y0_竜性1_鱗_鱗2.Hit = value;
    		}
    	}

    	public bool 竜性1_鱗_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性1_鱗_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性1_鱗_鱗1.Dra = value;
    			X0Y0_竜性1_鱗_鱗1.Hit = value;
    		}
    	}

    	public bool 竜性1_手首_鱗3_表示
    	{
    		get
    		{
    			return X0Y0_竜性1_手首_鱗3.Dra;
    		}
    		set
    		{
    			X0Y0_竜性1_手首_鱗3.Dra = value;
    			X0Y0_竜性1_手首_鱗3.Hit = value;
    		}
    	}

    	public bool 竜性1_手首_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性1_手首_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性1_手首_鱗2.Dra = value;
    			X0Y0_竜性1_手首_鱗2.Hit = value;
    		}
    	}

    	public bool 竜性1_手首_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性1_手首_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性1_手首_鱗1.Dra = value;
    			X0Y0_竜性1_手首_鱗1.Hit = value;
    		}
    	}

    	public bool 虫性1_虫肘_表示
    	{
    		get
    		{
    			return X0Y0_虫性1_虫肘.Dra;
    		}
    		set
    		{
    			X0Y0_虫性1_虫肘.Dra = value;
    			X0Y0_虫性1_虫肘.Hit = value;
    		}
    	}

    	public bool 虫性1_虫腕上_表示
    	{
    		get
    		{
    			return X0Y0_虫性1_虫腕上.Dra;
    		}
    		set
    		{
    			X0Y0_虫性1_虫腕上.Dra = value;
    			X0Y0_虫性1_虫腕上.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_手首_タトゥ_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_手首_タトゥ.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_手首_タトゥ.Dra = value;
    			X0Y0_淫タトゥ_手首_タトゥ.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_手首_ハート1_タトゥ左_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_手首_ハート1_タトゥ左.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_手首_ハート1_タトゥ左.Dra = value;
    			X0Y0_淫タトゥ_手首_ハート1_タトゥ左.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_手首_ハート1_タトゥ右_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_手首_ハート1_タトゥ右.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_手首_ハート1_タトゥ右.Dra = value;
    			X0Y0_淫タトゥ_手首_ハート1_タトゥ右.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_手首_ハート3_タトゥ左_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_手首_ハート3_タトゥ左.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_手首_ハート3_タトゥ左.Dra = value;
    			X0Y0_淫タトゥ_手首_ハート3_タトゥ左.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_手首_ハート3_タトゥ右_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_手首_ハート3_タトゥ右.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_手首_ハート3_タトゥ右.Dra = value;
    			X0Y0_淫タトゥ_手首_ハート3_タトゥ右.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_手首_ハート2_タトゥ左_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_手首_ハート2_タトゥ左.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_手首_ハート2_タトゥ左.Dra = value;
    			X0Y0_淫タトゥ_手首_ハート2_タトゥ左.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_手首_ハート2_タトゥ右_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_手首_ハート2_タトゥ右.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_手首_ハート2_タトゥ右.Dra = value;
    			X0Y0_淫タトゥ_手首_ハート2_タトゥ右.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_通常_ハート1_タトゥ左_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_通常_ハート1_タトゥ左.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_通常_ハート1_タトゥ左.Dra = value;
    			X0Y0_淫タトゥ_通常_ハート1_タトゥ左.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_通常_ハート1_タトゥ右_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_通常_ハート1_タトゥ右.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_通常_ハート1_タトゥ右.Dra = value;
    			X0Y0_淫タトゥ_通常_ハート1_タトゥ右.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_通常_ハート2_タトゥ左_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_通常_ハート2_タトゥ左.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_通常_ハート2_タトゥ左.Dra = value;
    			X0Y0_淫タトゥ_通常_ハート2_タトゥ左.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_通常_ハート2_タトゥ右_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_通常_ハート2_タトゥ右.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_通常_ハート2_タトゥ右.Dra = value;
    			X0Y0_淫タトゥ_通常_ハート2_タトゥ右.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_筋肉_ハート1_タトゥ左_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_筋肉_ハート1_タトゥ左.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_筋肉_ハート1_タトゥ左.Dra = value;
    			X0Y0_淫タトゥ_筋肉_ハート1_タトゥ左.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_筋肉_ハート1_タトゥ右_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_筋肉_ハート1_タトゥ右.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_筋肉_ハート1_タトゥ右.Dra = value;
    			X0Y0_淫タトゥ_筋肉_ハート1_タトゥ右.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_筋肉_ハート2_タトゥ左_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_筋肉_ハート2_タトゥ左.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_筋肉_ハート2_タトゥ左.Dra = value;
    			X0Y0_淫タトゥ_筋肉_ハート2_タトゥ左.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_筋肉_ハート2_タトゥ右_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_筋肉_ハート2_タトゥ右.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_筋肉_ハート2_タトゥ右.Dra = value;
    			X0Y0_淫タトゥ_筋肉_ハート2_タトゥ右.Hit = value;
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

    	public bool 悪タトゥ_通常_タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_通常_タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_逆十字_逆十字1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_逆十字_逆十字1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_逆十字_逆十字1.Dra = value;
    			X0Y0_悪タトゥ_通常_逆十字_逆十字1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_通常_逆十字_逆十字2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_通常_逆十字_逆十字2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_通常_逆十字_逆十字2.Dra = value;
    			X0Y0_悪タトゥ_通常_逆十字_逆十字2.Hit = value;
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

    	public bool 悪タトゥ_筋肉_タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_タトゥ2.Dra = value;
    			X0Y0_悪タトゥ_筋肉_タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_逆十字_逆十字1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_逆十字_逆十字1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_逆十字_逆十字1.Dra = value;
    			X0Y0_悪タトゥ_筋肉_逆十字_逆十字1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_筋肉_逆十字_逆十字2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_筋肉_逆十字_逆十字2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_筋肉_逆十字_逆十字2.Dra = value;
    			X0Y0_悪タトゥ_筋肉_逆十字_逆十字2.Hit = value;
    		}
    	}

    	public bool 植性2_通常_萼_萼上_表示
    	{
    		get
    		{
    			return X0Y0_植性2_通常_萼_萼上.Dra;
    		}
    		set
    		{
    			X0Y0_植性2_通常_萼_萼上.Dra = value;
    			X0Y0_植性2_通常_萼_萼上.Hit = value;
    		}
    	}

    	public bool 植性2_通常_萼_萼下_表示
    	{
    		get
    		{
    			return X0Y0_植性2_通常_萼_萼下.Dra;
    		}
    		set
    		{
    			X0Y0_植性2_通常_萼_萼下.Dra = value;
    			X0Y0_植性2_通常_萼_萼下.Hit = value;
    		}
    	}

    	public bool 植性2_通常_萼_萼中_表示
    	{
    		get
    		{
    			return X0Y0_植性2_通常_萼_萼中.Dra;
    		}
    		set
    		{
    			X0Y0_植性2_通常_萼_萼中.Dra = value;
    			X0Y0_植性2_通常_萼_萼中.Hit = value;
    		}
    	}

    	public bool 植性2_欠損_萼_萼上_表示
    	{
    		get
    		{
    			return X0Y0_植性2_欠損_萼_萼上.Dra;
    		}
    		set
    		{
    			X0Y0_植性2_欠損_萼_萼上.Dra = value;
    			X0Y0_植性2_欠損_萼_萼上.Hit = value;
    		}
    	}

    	public bool 植性2_欠損_萼_萼下_表示
    	{
    		get
    		{
    			return X0Y0_植性2_欠損_萼_萼下.Dra;
    		}
    		set
    		{
    			X0Y0_植性2_欠損_萼_萼下.Dra = value;
    			X0Y0_植性2_欠損_萼_萼下.Hit = value;
    		}
    	}

    	public bool 植性2_欠損_萼_萼中_表示
    	{
    		get
    		{
    			return X0Y0_植性2_欠損_萼_萼中.Dra;
    		}
    		set
    		{
    			X0Y0_植性2_欠損_萼_萼中.Dra = value;
    			X0Y0_植性2_欠損_萼_萼中.Hit = value;
    		}
    	}

    	public bool 獣性2_獣毛_表示
    	{
    		get
    		{
    			return X0Y0_獣性2_獣毛.Dra;
    		}
    		set
    		{
    			X0Y0_獣性2_獣毛.Dra = value;
    			X0Y0_獣性2_獣毛.Hit = value;
    		}
    	}

    	public bool 竜性2_棘_棘5_表示
    	{
    		get
    		{
    			return X0Y0_竜性2_棘_棘5.Dra;
    		}
    		set
    		{
    			X0Y0_竜性2_棘_棘5.Dra = value;
    			X0Y0_竜性2_棘_棘5.Hit = value;
    		}
    	}

    	public bool 竜性2_棘_棘4_表示
    	{
    		get
    		{
    			return X0Y0_竜性2_棘_棘4.Dra;
    		}
    		set
    		{
    			X0Y0_竜性2_棘_棘4.Dra = value;
    			X0Y0_竜性2_棘_棘4.Hit = value;
    		}
    	}

    	public bool 竜性2_棘_棘3_表示
    	{
    		get
    		{
    			return X0Y0_竜性2_棘_棘3.Dra;
    		}
    		set
    		{
    			X0Y0_竜性2_棘_棘3.Dra = value;
    			X0Y0_竜性2_棘_棘3.Hit = value;
    		}
    	}

    	public bool 竜性2_棘_棘2_表示
    	{
    		get
    		{
    			return X0Y0_竜性2_棘_棘2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性2_棘_棘2.Dra = value;
    			X0Y0_竜性2_棘_棘2.Hit = value;
    		}
    	}

    	public bool 竜性2_棘_棘1_表示
    	{
    		get
    		{
    			return X0Y0_竜性2_棘_棘1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性2_棘_棘1.Dra = value;
    			X0Y0_竜性2_棘_棘1.Hit = value;
    		}
    	}

    	public bool 虫性2_虫腕下_表示
    	{
    		get
    		{
    			return X0Y0_虫性2_虫腕下.Dra;
    		}
    		set
    		{
    			X0Y0_虫性2_虫腕下.Dra = value;
    			X0Y0_虫性2_虫腕下.Hit = value;
    		}
    	}

    	public bool 虫性2_虫棘1_表示
    	{
    		get
    		{
    			return X0Y0_虫性2_虫棘1.Dra;
    		}
    		set
    		{
    			X0Y0_虫性2_虫棘1.Dra = value;
    			X0Y0_虫性2_虫棘1.Hit = value;
    		}
    	}

    	public bool 虫性2_虫棘2_表示
    	{
    		get
    		{
    			return X0Y0_虫性2_虫棘2.Dra;
    		}
    		set
    		{
    			X0Y0_虫性2_虫棘2.Dra = value;
    			X0Y0_虫性2_虫棘2.Hit = value;
    		}
    	}

    	public bool 虫性2_虫棘3_表示
    	{
    		get
    		{
    			return X0Y0_虫性2_虫棘3.Dra;
    		}
    		set
    		{
    			X0Y0_虫性2_虫棘3.Dra = value;
    			X0Y0_虫性2_虫棘3.Hit = value;
    		}
    	}

    	public bool 虫性2_虫棘4_表示
    	{
    		get
    		{
    			return X0Y0_虫性2_虫棘4.Dra;
    		}
    		set
    		{
    			X0Y0_虫性2_虫棘4.Dra = value;
    			X0Y0_虫性2_虫棘4.Hit = value;
    		}
    	}

    	public bool 虫性2_虫鎌節_表示
    	{
    		get
    		{
    			return X0Y0_虫性2_虫鎌節.Dra;
    		}
    		set
    		{
    			X0Y0_虫性2_虫鎌節.Dra = value;
    			X0Y0_虫性2_虫鎌節.Hit = value;
    		}
    	}

    	public bool 傷X1_表示
    	{
    		get
    		{
    			return X0Y0_傷X1.Dra;
    		}
    		set
    		{
    			X0Y0_傷X1.Dra = value;
    			X0Y0_傷X1.Hit = value;
    		}
    	}

    	public bool 傷I1_表示
    	{
    		get
    		{
    			return X0Y0_傷I1.Dra;
    		}
    		set
    		{
    			X0Y0_傷I1.Dra = value;
    			X0Y0_傷I1.Hit = value;
    		}
    	}

    	public bool 傷I2_表示
    	{
    		get
    		{
    			return X0Y0_傷I2.Dra;
    		}
    		set
    		{
    			X0Y0_傷I2.Dra = value;
    			X0Y0_傷I2.Hit = value;
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

    	public bool 鎧_ベルト_通常_ベルト2_表示
    	{
    		get
    		{
    			return X0Y0_鎧_ベルト_通常_ベルト2.Dra;
    		}
    		set
    		{
    			X0Y0_鎧_ベルト_通常_ベルト2.Dra = value;
    			X0Y0_鎧_ベルト_通常_ベルト2.Hit = value;
    		}
    	}

    	public bool 鎧_ベルト_筋肉_ベルト2_表示
    	{
    		get
    		{
    			return X0Y0_鎧_ベルト_筋肉_ベルト2.Dra;
    		}
    		set
    		{
    			X0Y0_鎧_ベルト_筋肉_ベルト2.Dra = value;
    			X0Y0_鎧_ベルト_筋肉_ベルト2.Hit = value;
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
    			X0Y0_腕輪_金具右.Dra = value;
    			X0Y0_腕輪_金具右.Hit = value;
    		}
    	}

    	public bool 植性1_花弁_花弁_表示
    	{
    		get
    		{
    			if (!植性1_通常_花弁_花弁_表示)
    			{
    				return 植性1_欠損_花弁_花弁_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				植性1_通常_花弁_花弁_表示 = false;
    				植性1_欠損_花弁_花弁_表示 = value;
    			}
    			else
    			{
    				植性1_通常_花弁_花弁_表示 = value;
    				植性1_欠損_花弁_花弁_表示 = false;
    			}
    		}
    	}

    	public bool 植性1_花弁_影_花弁影1_表示
    	{
    		get
    		{
    			if (!植性1_通常_花弁_影_花弁影1_表示)
    			{
    				return 植性1_欠損_花弁_影_花弁影1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				植性1_通常_花弁_影_花弁影1_表示 = false;
    				植性1_欠損_花弁_影_花弁影1_表示 = value;
    			}
    			else
    			{
    				植性1_通常_花弁_影_花弁影1_表示 = value;
    				植性1_欠損_花弁_影_花弁影1_表示 = false;
    			}
    		}
    	}

    	public bool 植性1_花弁_影_花弁影2_表示
    	{
    		get
    		{
    			if (!植性1_通常_花弁_影_花弁影2_表示)
    			{
    				return 植性1_欠損_花弁_影_花弁影2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				植性1_通常_花弁_影_花弁影2_表示 = false;
    				植性1_欠損_花弁_影_花弁影2_表示 = value;
    			}
    			else
    			{
    				植性1_通常_花弁_影_花弁影2_表示 = value;
    				植性1_欠損_花弁_影_花弁影2_表示 = false;
    			}
    		}
    	}

    	public bool 植性1_花弁_影_花弁影3_表示
    	{
    		get
    		{
    			if (!植性1_通常_花弁_影_花弁影3_表示)
    			{
    				return 植性1_欠損_花弁_影_花弁影3_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				植性1_通常_花弁_影_花弁影3_表示 = false;
    				植性1_欠損_花弁_影_花弁影3_表示 = value;
    			}
    			else
    			{
    				植性1_通常_花弁_影_花弁影3_表示 = value;
    				植性1_欠損_花弁_影_花弁影3_表示 = false;
    			}
    		}
    	}

    	public bool 植性1_花弁_影_花弁影4_表示
    	{
    		get
    		{
    			if (!植性1_通常_花弁_影_花弁影4_表示)
    			{
    				return 植性1_欠損_花弁_影_花弁影4_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				植性1_通常_花弁_影_花弁影4_表示 = false;
    				植性1_欠損_花弁_影_花弁影4_表示 = value;
    			}
    			else
    			{
    				植性1_通常_花弁_影_花弁影4_表示 = value;
    				植性1_欠損_花弁_影_花弁影4_表示 = false;
    			}
    		}
    	}

    	public bool 植性1_花弁_影_花弁影5_表示
    	{
    		get
    		{
    			if (!植性1_通常_花弁_影_花弁影5_表示)
    			{
    				return 植性1_欠損_花弁_影_花弁影5_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				植性1_通常_花弁_影_花弁影5_表示 = false;
    				植性1_欠損_花弁_影_花弁影5_表示 = value;
    			}
    			else
    			{
    				植性1_通常_花弁_影_花弁影5_表示 = value;
    				植性1_欠損_花弁_影_花弁影5_表示 = false;
    			}
    		}
    	}

    	public bool 淫タトゥ_ハート1_タトゥ左_表示
    	{
    		get
    		{
    			if (!淫タトゥ_通常_ハート1_タトゥ左_表示)
    			{
    				return 淫タトゥ_筋肉_ハート1_タトゥ左_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				淫タトゥ_通常_ハート1_タトゥ左_表示 = false;
    				淫タトゥ_筋肉_ハート1_タトゥ左_表示 = value;
    			}
    			else
    			{
    				淫タトゥ_通常_ハート1_タトゥ左_表示 = value;
    				淫タトゥ_筋肉_ハート1_タトゥ左_表示 = false;
    			}
    		}
    	}

    	public bool 淫タトゥ_ハート1_タトゥ右_表示
    	{
    		get
    		{
    			if (!淫タトゥ_通常_ハート1_タトゥ右_表示)
    			{
    				return 淫タトゥ_筋肉_ハート1_タトゥ右_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				淫タトゥ_通常_ハート1_タトゥ右_表示 = false;
    				淫タトゥ_筋肉_ハート1_タトゥ右_表示 = value;
    			}
    			else
    			{
    				淫タトゥ_通常_ハート1_タトゥ右_表示 = value;
    				淫タトゥ_筋肉_ハート1_タトゥ右_表示 = false;
    			}
    		}
    	}

    	public bool 淫タトゥ_ハート2_タトゥ左_表示
    	{
    		get
    		{
    			if (!淫タトゥ_通常_ハート2_タトゥ左_表示)
    			{
    				return 淫タトゥ_筋肉_ハート2_タトゥ左_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				淫タトゥ_通常_ハート2_タトゥ左_表示 = false;
    				淫タトゥ_筋肉_ハート2_タトゥ左_表示 = value;
    			}
    			else
    			{
    				淫タトゥ_通常_ハート2_タトゥ左_表示 = value;
    				淫タトゥ_筋肉_ハート2_タトゥ左_表示 = false;
    			}
    		}
    	}

    	public bool 淫タトゥ_ハート2_タトゥ右_表示
    	{
    		get
    		{
    			if (!淫タトゥ_通常_ハート2_タトゥ右_表示)
    			{
    				return 淫タトゥ_筋肉_ハート2_タトゥ右_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				淫タトゥ_通常_ハート2_タトゥ右_表示 = false;
    				淫タトゥ_筋肉_ハート2_タトゥ右_表示 = value;
    			}
    			else
    			{
    				淫タトゥ_通常_ハート2_タトゥ右_表示 = value;
    				淫タトゥ_筋肉_ハート2_タトゥ右_表示 = false;
    			}
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

    	public bool 悪タトゥ_タトゥ2_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_タトゥ2_表示)
    			{
    				return 悪タトゥ_筋肉_タトゥ2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_タトゥ2_表示 = false;
    				悪タトゥ_筋肉_タトゥ2_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_タトゥ2_表示 = value;
    				悪タトゥ_筋肉_タトゥ2_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_逆十字_逆十字1_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_逆十字_逆十字1_表示)
    			{
    				return 悪タトゥ_筋肉_逆十字_逆十字1_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_逆十字_逆十字1_表示 = false;
    				悪タトゥ_筋肉_逆十字_逆十字1_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_逆十字_逆十字1_表示 = value;
    				悪タトゥ_筋肉_逆十字_逆十字1_表示 = false;
    			}
    		}
    	}

    	public bool 悪タトゥ_逆十字_逆十字2_表示
    	{
    		get
    		{
    			if (!悪タトゥ_通常_逆十字_逆十字2_表示)
    			{
    				return 悪タトゥ_筋肉_逆十字_逆十字2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				悪タトゥ_通常_逆十字_逆十字2_表示 = false;
    				悪タトゥ_筋肉_逆十字_逆十字2_表示 = value;
    			}
    			else
    			{
    				悪タトゥ_通常_逆十字_逆十字2_表示 = value;
    				悪タトゥ_筋肉_逆十字_逆十字2_表示 = false;
    			}
    		}
    	}

    	public bool 植性2_萼_萼上_表示
    	{
    		get
    		{
    			if (!植性2_通常_萼_萼上_表示)
    			{
    				return 植性2_欠損_萼_萼上_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				植性2_通常_萼_萼上_表示 = false;
    				植性2_欠損_萼_萼上_表示 = value;
    			}
    			else
    			{
    				植性2_通常_萼_萼上_表示 = value;
    				植性2_欠損_萼_萼上_表示 = false;
    			}
    		}
    	}

    	public bool 植性2_萼_萼下_表示
    	{
    		get
    		{
    			if (!植性2_通常_萼_萼下_表示)
    			{
    				return 植性2_欠損_萼_萼下_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				植性2_通常_萼_萼下_表示 = false;
    				植性2_欠損_萼_萼下_表示 = value;
    			}
    			else
    			{
    				植性2_通常_萼_萼下_表示 = value;
    				植性2_欠損_萼_萼下_表示 = false;
    			}
    		}
    	}

    	public bool 植性2_萼_萼中_表示
    	{
    		get
    		{
    			if (!植性2_通常_萼_萼中_表示)
    			{
    				return 植性2_欠損_萼_萼中_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (欠損_)
    			{
    				植性2_通常_萼_萼中_表示 = false;
    				植性2_欠損_萼_萼中_表示 = value;
    			}
    			else
    			{
    				植性2_通常_萼_萼中_表示 = value;
    				植性2_欠損_萼_萼中_表示 = false;
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

    	public bool 鎧_ベルト_ベルト2_表示
    	{
    		get
    		{
    			if (!鎧_ベルト_通常_ベルト2_表示)
    			{
    				return 鎧_ベルト_筋肉_ベルト2_表示;
    			}
    			return true;
    		}
    		set
    		{
    			if (筋肉フラグ)
    			{
    				鎧_ベルト_通常_ベルト2_表示 = false;
    				鎧_ベルト_筋肉_ベルト2_表示 = value;
    			}
    			else
    			{
    				鎧_ベルト_通常_ベルト2_表示 = value;
    				鎧_ベルト_筋肉_ベルト2_表示 = false;
    			}
    		}
    	}

    	private bool 筋肉フラグ
    	{
    		get
    		{
    			if (!筋肉_ && !筋肉_筋肉下_表示 && !筋肉_筋肉上_表示 && !竜性1_肘_肘1_表示 && !竜性1_肘_肘2_表示 && !竜性1_鱗_鱗5_表示 && !竜性1_鱗_鱗4_表示 && !竜性1_鱗_鱗3_表示 && !竜性1_鱗_鱗2_表示 && !竜性1_鱗_鱗1_表示 && !竜性2_棘_棘5_表示 && !竜性2_棘_棘4_表示 && !竜性2_棘_棘3_表示 && !竜性2_棘_棘2_表示 && !竜性2_棘_棘1_表示 && !竜性1_手首_鱗3_表示 && !竜性1_手首_鱗2_表示 && !竜性1_手首_鱗1_表示 && !虫性1_虫肘_表示 && !虫性2_虫腕下_表示 && !虫性1_虫腕上_表示 && !虫性2_虫棘1_表示 && !虫性2_虫棘2_表示 && !虫性2_虫棘3_表示 && !虫性2_虫棘4_表示)
    			{
    				return 虫性2_虫鎌節_表示;
    			}
    			return true;
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

    	public double 傷X1濃度
    	{
    		get
    		{
    			return 傷X1CD.不透明度;
    		}
    		set
    		{
    			傷X1CD.不透明度 = value;
    		}
    	}

    	public double 傷I1濃度
    	{
    		get
    		{
    			return 傷I1CD.不透明度;
    		}
    		set
    		{
    			傷I1CD.不透明度 = value;
    		}
    	}

    	public double 傷I2濃度
    	{
    		get
    		{
    			return 傷I2CD.不透明度;
    		}
    		set
    		{
    			傷I2CD.不透明度 = value;
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
    			return LowerArm_表示;
    		}
    		set
    		{
    			LowerArm_表示 = value;
    			筋肉_筋肉下_表示 = value;
    			筋肉_筋肉上_表示 = value;
    			植性1_通常_花弁_花弁_表示 = value;
    			植性1_通常_花弁_影_花弁影1_表示 = value;
    			植性1_通常_花弁_影_花弁影2_表示 = value;
    			植性1_通常_花弁_影_花弁影3_表示 = value;
    			植性1_通常_花弁_影_花弁影4_表示 = value;
    			植性1_通常_花弁_影_花弁影5_表示 = value;
    			植性1_欠損_花弁_花弁_表示 = value;
    			植性1_欠損_花弁_影_花弁影1_表示 = value;
    			植性1_欠損_花弁_影_花弁影2_表示 = value;
    			植性1_欠損_花弁_影_花弁影3_表示 = value;
    			植性1_欠損_花弁_影_花弁影4_表示 = value;
    			植性1_欠損_花弁_影_花弁影5_表示 = value;
    			獣性1_獣腕_表示 = value;
    			竜性1_肘_肘1_表示 = value;
    			竜性1_肘_肘2_表示 = value;
    			竜性1_鱗_鱗5_表示 = value;
    			竜性1_鱗_鱗4_表示 = value;
    			竜性1_鱗_鱗3_表示 = value;
    			竜性1_鱗_鱗2_表示 = value;
    			竜性1_鱗_鱗1_表示 = value;
    			竜性1_手首_鱗3_表示 = value;
    			竜性1_手首_鱗2_表示 = value;
    			竜性1_手首_鱗1_表示 = value;
    			虫性1_虫肘_表示 = value;
    			虫性1_虫腕上_表示 = value;
    			淫タトゥ_手首_タトゥ_表示 = value;
    			淫タトゥ_手首_ハート1_タトゥ左_表示 = value;
    			淫タトゥ_手首_ハート1_タトゥ右_表示 = value;
    			淫タトゥ_手首_ハート3_タトゥ左_表示 = value;
    			淫タトゥ_手首_ハート3_タトゥ右_表示 = value;
    			淫タトゥ_手首_ハート2_タトゥ左_表示 = value;
    			淫タトゥ_手首_ハート2_タトゥ右_表示 = value;
    			淫タトゥ_通常_ハート1_タトゥ左_表示 = value;
    			淫タトゥ_通常_ハート1_タトゥ右_表示 = value;
    			淫タトゥ_通常_ハート2_タトゥ左_表示 = value;
    			淫タトゥ_通常_ハート2_タトゥ右_表示 = value;
    			淫タトゥ_筋肉_ハート1_タトゥ左_表示 = value;
    			淫タトゥ_筋肉_ハート1_タトゥ右_表示 = value;
    			淫タトゥ_筋肉_ハート2_タトゥ左_表示 = value;
    			淫タトゥ_筋肉_ハート2_タトゥ右_表示 = value;
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
    			悪タトゥ_通常_タトゥ2_表示 = value;
    			悪タトゥ_通常_逆十字_逆十字1_表示 = value;
    			悪タトゥ_通常_逆十字_逆十字2_表示 = value;
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
    			悪タトゥ_筋肉_タトゥ2_表示 = value;
    			悪タトゥ_筋肉_逆十字_逆十字1_表示 = value;
    			悪タトゥ_筋肉_逆十字_逆十字2_表示 = value;
    			植性2_通常_萼_萼上_表示 = value;
    			植性2_通常_萼_萼下_表示 = value;
    			植性2_通常_萼_萼中_表示 = value;
    			植性2_欠損_萼_萼上_表示 = value;
    			植性2_欠損_萼_萼下_表示 = value;
    			植性2_欠損_萼_萼中_表示 = value;
    			獣性2_獣毛_表示 = value;
    			竜性2_棘_棘5_表示 = value;
    			竜性2_棘_棘4_表示 = value;
    			竜性2_棘_棘3_表示 = value;
    			竜性2_棘_棘2_表示 = value;
    			竜性2_棘_棘1_表示 = value;
    			虫性2_虫腕下_表示 = value;
    			虫性2_虫棘1_表示 = value;
    			虫性2_虫棘2_表示 = value;
    			虫性2_虫棘3_表示 = value;
    			虫性2_虫棘4_表示 = value;
    			虫性2_虫鎌節_表示 = value;
    			傷X1_表示 = value;
    			傷I1_表示 = value;
    			傷I2_表示 = value;
    			ハイライト_表示 = value;
    			グローブ_通常_グローブ_表示 = value;
    			グローブ_通常_縁_表示 = value;
    			グローブ_筋肉_グローブ_表示 = value;
    			グローブ_筋肉_縁_表示 = value;
    			鎧_ベルト_ベルト1_表示 = value;
    			鎧_ベルト_通常_ベルト2_表示 = value;
    			鎧_ベルト_筋肉_ベルト2_表示 = value;
    			鎧_鎧_鎧2_表示 = value;
    			鎧_鎧_鎧1_表示 = value;
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
    			return LowerArmCD.不透明度;
    		}
    		set
    		{
    			LowerArmCD.不透明度 = value;
    			筋肉_筋肉下CD.不透明度 = value;
    			筋肉_筋肉上CD.不透明度 = value;
    			植性1_花弁_花弁CD.不透明度 = value;
    			植性1_花弁_影_花弁影1CD.不透明度 = value;
    			植性1_花弁_影_花弁影2CD.不透明度 = value;
    			植性1_花弁_影_花弁影3CD.不透明度 = value;
    			植性1_花弁_影_花弁影4CD.不透明度 = value;
    			植性1_花弁_影_花弁影5CD.不透明度 = value;
    			獣性1_獣腕CD.不透明度 = value;
    			竜性1_肘_肘1CD.不透明度 = value;
    			竜性1_肘_肘2CD.不透明度 = value;
    			竜性1_鱗_鱗5CD.不透明度 = value;
    			竜性1_鱗_鱗4CD.不透明度 = value;
    			竜性1_鱗_鱗3CD.不透明度 = value;
    			竜性1_鱗_鱗2CD.不透明度 = value;
    			竜性1_鱗_鱗1CD.不透明度 = value;
    			竜性1_手首_鱗3CD.不透明度 = value;
    			竜性1_手首_鱗2CD.不透明度 = value;
    			竜性1_手首_鱗1CD.不透明度 = value;
    			虫性1_虫肘CD.不透明度 = value;
    			虫性1_虫腕上CD.不透明度 = value;
    			淫タトゥ_手首_タトゥCD.不透明度 = value;
    			淫タトゥ_手首_ハート1_タトゥ左CD.不透明度 = value;
    			淫タトゥ_手首_ハート1_タトゥ右CD.不透明度 = value;
    			淫タトゥ_手首_ハート3_タトゥ左CD.不透明度 = value;
    			淫タトゥ_手首_ハート3_タトゥ右CD.不透明度 = value;
    			淫タトゥ_手首_ハート2_タトゥ左CD.不透明度 = value;
    			淫タトゥ_手首_ハート2_タトゥ右CD.不透明度 = value;
    			淫タトゥ_ハート1_タトゥ左CD.不透明度 = value;
    			淫タトゥ_ハート1_タトゥ右CD.不透明度 = value;
    			淫タトゥ_ハート2_タトゥ左CD.不透明度 = value;
    			淫タトゥ_ハート2_タトゥ右CD.不透明度 = value;
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
    			悪タトゥ_逆十字_逆十字1CD.不透明度 = value;
    			悪タトゥ_逆十字_逆十字2CD.不透明度 = value;
    			植性2_萼_萼上CD.不透明度 = value;
    			植性2_萼_萼下CD.不透明度 = value;
    			植性2_萼_萼中CD.不透明度 = value;
    			獣性2_獣毛CD.不透明度 = value;
    			竜性2_棘_棘5CD.不透明度 = value;
    			竜性2_棘_棘4CD.不透明度 = value;
    			竜性2_棘_棘3CD.不透明度 = value;
    			竜性2_棘_棘2CD.不透明度 = value;
    			竜性2_棘_棘1CD.不透明度 = value;
    			虫性2_虫腕下CD.不透明度 = value;
    			虫性2_虫棘1CD.不透明度 = value;
    			虫性2_虫棘2CD.不透明度 = value;
    			虫性2_虫棘3CD.不透明度 = value;
    			虫性2_虫棘4CD.不透明度 = value;
    			虫性2_虫鎌節CD.不透明度 = value;
    			傷X1CD.不透明度 = value;
    			傷I1CD.不透明度 = value;
    			傷I2CD.不透明度 = value;
    			ハイライトCD.不透明度 = value;
    			グローブ_グローブCD.不透明度 = value;
    			グローブ_縁CD.不透明度 = value;
    			グローブ_グローブCD.不透明度 = value;
    			グローブ_縁CD.不透明度 = value;
    			鎧_ベルト_ベルト1CD.不透明度 = value;
    			鎧_ベルト_ベルト2CD.不透明度 = value;
    			鎧_ベルト_ベルト2CD.不透明度 = value;
    			鎧_鎧_鎧2CD.不透明度 = value;
    			鎧_鎧_鎧1CD.不透明度 = value;
    			腕輪_革CD.不透明度 = value;
    			腕輪_金具1CD.不透明度 = value;
    			腕輪_金具2CD.不透明度 = value;
    			腕輪_金具3CD.不透明度 = value;
    			腕輪_金具左CD.不透明度 = value;
    			腕輪_金具右CD.不透明度 = value;
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
    			鎧_鎧_鎧2_表示 = value;
    			鎧_鎧_鎧1_表示 = value;
    		}
    	}

    	public override bool 肘部_外線
    	{
    		get
    		{
    			return X0Y0_LowerArm.OP[右 ? 3 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_LowerArm.OP[右 ? 3 : 0].Outline = value;
    			X0Y0_獣性1_獣腕.OP[右 ? 3 : 2].Outline = value;
    			X0Y0_グローブ_通常_グローブ.OP[右 ? 3 : 0].Outline = value;
    			X0Y0_グローブ_筋肉_グローブ.OP[右 ? 3 : 0].Outline = value;
    		}
    	}

    	public JointS 外腕_接続点 => new JointS(Body, X0Y0_LowerArm, 0);

    	public JointS 手_接続点 => new JointS(Body, X0Y0_LowerArm, 3);

    	public JointS 虫鎌_接続点 => new JointS(Body, X0Y0_LowerArm, 2);

    	public JointS 鎖1_接続点 => new JointS(Body, X0Y0_腕輪_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(Body, X0Y0_腕輪_金具右, 0);

    	public LowerArm_人(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, LowerArm_人D e)
    	{
    		LowerArm_人 LowerArm_人2 = this;
    		ThisType = GetType();
    		Body = new VariantGrid(Sta.腕左["LowerArm"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_LowerArm = partGroup["下腕"].ToPar();
    		PartGroup pars2 = partGroup["筋肉"].ToPars();
    		X0Y0_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
    		X0Y0_筋肉_筋肉上 = pars2["筋肉上"].ToPar();
    		pars2 = partGroup["植性1"].ToPars();
    		PartGroup pars3 = pars2["通常"].ToPars();
    		PartGroup pars4 = pars3["花弁"].ToPars();
    		X0Y0_植性1_通常_花弁_花弁 = pars4["花弁"].ToPar();
    		PartGroup pars5 = pars4["影"].ToPars();
    		X0Y0_植性1_通常_花弁_影_花弁影1 = pars5["花弁影1"].ToPar();
    		X0Y0_植性1_通常_花弁_影_花弁影2 = pars5["花弁影2"].ToPar();
    		X0Y0_植性1_通常_花弁_影_花弁影3 = pars5["花弁影3"].ToPar();
    		X0Y0_植性1_通常_花弁_影_花弁影4 = pars5["花弁影4"].ToPar();
    		X0Y0_植性1_通常_花弁_影_花弁影5 = pars5["花弁影5"].ToPar();
    		pars3 = pars2["欠損"].ToPars();
    		pars4 = pars3["花弁"].ToPars();
    		X0Y0_植性1_欠損_花弁_花弁 = pars4["花弁"].ToPar();
    		pars5 = pars4["影"].ToPars();
    		X0Y0_植性1_欠損_花弁_影_花弁影1 = pars5["花弁影1"].ToPar();
    		X0Y0_植性1_欠損_花弁_影_花弁影2 = pars5["花弁影2"].ToPar();
    		X0Y0_植性1_欠損_花弁_影_花弁影3 = pars5["花弁影3"].ToPar();
    		X0Y0_植性1_欠損_花弁_影_花弁影4 = pars5["花弁影4"].ToPar();
    		X0Y0_植性1_欠損_花弁_影_花弁影5 = pars5["花弁影5"].ToPar();
    		pars2 = partGroup["獣性1"].ToPars();
    		X0Y0_獣性1_獣腕 = pars2["獣腕"].ToPar();
    		pars2 = partGroup["竜性1"].ToPars();
    		pars3 = pars2["肘"].ToPars();
    		X0Y0_竜性1_肘_肘1 = pars3["肘1"].ToPar();
    		X0Y0_竜性1_肘_肘2 = pars3["肘2"].ToPar();
    		pars3 = pars2["鱗"].ToPars();
    		X0Y0_竜性1_鱗_鱗5 = pars3["鱗5"].ToPar();
    		X0Y0_竜性1_鱗_鱗4 = pars3["鱗4"].ToPar();
    		X0Y0_竜性1_鱗_鱗3 = pars3["鱗3"].ToPar();
    		X0Y0_竜性1_鱗_鱗2 = pars3["鱗2"].ToPar();
    		X0Y0_竜性1_鱗_鱗1 = pars3["鱗1"].ToPar();
    		pars3 = pars2["手首"].ToPars();
    		X0Y0_竜性1_手首_鱗3 = pars3["鱗3"].ToPar();
    		X0Y0_竜性1_手首_鱗2 = pars3["鱗2"].ToPar();
    		X0Y0_竜性1_手首_鱗1 = pars3["鱗1"].ToPar();
    		pars2 = partGroup["虫性1"].ToPars();
    		X0Y0_虫性1_虫肘 = pars2["虫肘"].ToPar();
    		X0Y0_虫性1_虫腕上 = pars2["虫腕上"].ToPar();
    		pars2 = partGroup["淫タトゥ"].ToPars();
    		pars3 = pars2["手首"].ToPars();
    		X0Y0_淫タトゥ_手首_タトゥ = pars3["タトゥ"].ToPar();
    		pars4 = pars3["ハート1"].ToPars();
    		X0Y0_淫タトゥ_手首_ハート1_タトゥ左 = pars4["タトゥ左"].ToPar();
    		X0Y0_淫タトゥ_手首_ハート1_タトゥ右 = pars4["タトゥ右"].ToPar();
    		pars4 = pars3["ハート3"].ToPars();
    		X0Y0_淫タトゥ_手首_ハート3_タトゥ左 = pars4["タトゥ左"].ToPar();
    		X0Y0_淫タトゥ_手首_ハート3_タトゥ右 = pars4["タトゥ右"].ToPar();
    		pars4 = pars3["ハート2"].ToPars();
    		X0Y0_淫タトゥ_手首_ハート2_タトゥ左 = pars4["タトゥ左"].ToPar();
    		X0Y0_淫タトゥ_手首_ハート2_タトゥ右 = pars4["タトゥ右"].ToPar();
    		pars3 = pars2["通常"].ToPars();
    		pars4 = pars3["ハート1"].ToPars();
    		X0Y0_淫タトゥ_通常_ハート1_タトゥ左 = pars4["タトゥ左"].ToPar();
    		X0Y0_淫タトゥ_通常_ハート1_タトゥ右 = pars4["タトゥ右"].ToPar();
    		pars4 = pars3["ハート2"].ToPars();
    		X0Y0_淫タトゥ_通常_ハート2_タトゥ左 = pars4["タトゥ左"].ToPar();
    		X0Y0_淫タトゥ_通常_ハート2_タトゥ右 = pars4["タトゥ右"].ToPar();
    		pars3 = pars2["筋肉"].ToPars();
    		pars4 = pars3["ハート1"].ToPars();
    		X0Y0_淫タトゥ_筋肉_ハート1_タトゥ左 = pars4["タトゥ左"].ToPar();
    		X0Y0_淫タトゥ_筋肉_ハート1_タトゥ右 = pars4["タトゥ右"].ToPar();
    		pars4 = pars3["ハート2"].ToPars();
    		X0Y0_淫タトゥ_筋肉_ハート2_タトゥ左 = pars4["タトゥ左"].ToPar();
    		X0Y0_淫タトゥ_筋肉_ハート2_タトゥ右 = pars4["タトゥ右"].ToPar();
    		pars2 = partGroup["悪タトゥ"].ToPars();
    		pars3 = pars2["通常"].ToPars();
    		pars4 = pars3["文字1"].ToPars();
    		pars5 = pars4["文字a"].ToPars();
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
    		pars4 = pars3["文字2"].ToPars();
    		pars5 = pars4["文字a"].ToPars();
    		X0Y0_悪タトゥ_通常_文字2_文字a_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字b"].ToPars();
    		X0Y0_悪タトゥ_通常_文字2_文字b_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字c"].ToPars();
    		X0Y0_悪タトゥ_通常_文字2_文字c_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字d"].ToPars();
    		X0Y0_悪タトゥ_通常_文字2_文字d_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字e"].ToPars();
    		X0Y0_悪タトゥ_通常_文字2_文字e_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
    		X0Y0_悪タトゥ_通常_タトゥ1 = pars3["タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_通常_タトゥ2 = pars3["タトゥ2"].ToPar();
    		pars4 = pars3["逆十字"].ToPars();
    		X0Y0_悪タトゥ_通常_逆十字_逆十字1 = pars4["逆十字1"].ToPar();
    		X0Y0_悪タトゥ_通常_逆十字_逆十字2 = pars4["逆十字2"].ToPar();
    		pars3 = pars2["筋肉"].ToPars();
    		pars4 = pars3["文字1"].ToPars();
    		pars5 = pars4["文字a"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字1_文字a_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字b"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字1_文字b_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字c"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字1_文字c_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字d"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字1_文字d_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字e"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
    		pars4 = pars3["文字2"].ToPars();
    		pars5 = pars4["文字a"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字2_文字a_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字b"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字2_文字b_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字c"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字2_文字c_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字d"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字2_文字d_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		pars5 = pars4["文字e"].ToPars();
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_枠 = pars5["枠"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
    		X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
    		X0Y0_悪タトゥ_筋肉_タトゥ1 = pars3["タトゥ1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_タトゥ2 = pars3["タトゥ2"].ToPar();
    		pars4 = pars3["逆十字"].ToPars();
    		X0Y0_悪タトゥ_筋肉_逆十字_逆十字1 = pars4["逆十字1"].ToPar();
    		X0Y0_悪タトゥ_筋肉_逆十字_逆十字2 = pars4["逆十字2"].ToPar();
    		pars2 = partGroup["植性2"].ToPars();
    		pars3 = pars2["通常"].ToPars();
    		pars4 = pars3["萼"].ToPars();
    		X0Y0_植性2_通常_萼_萼上 = pars4["萼上"].ToPar();
    		X0Y0_植性2_通常_萼_萼下 = pars4["萼下"].ToPar();
    		X0Y0_植性2_通常_萼_萼中 = pars4["萼中"].ToPar();
    		pars3 = pars2["欠損"].ToPars();
    		pars4 = pars3["萼"].ToPars();
    		X0Y0_植性2_欠損_萼_萼上 = pars4["萼上"].ToPar();
    		X0Y0_植性2_欠損_萼_萼下 = pars4["萼下"].ToPar();
    		X0Y0_植性2_欠損_萼_萼中 = pars4["萼中"].ToPar();
    		pars2 = partGroup["獣性2"].ToPars();
    		X0Y0_獣性2_獣毛 = pars2["獣毛"].ToPar();
    		pars2 = partGroup["竜性2"].ToPars();
    		pars3 = pars2["刺"].ToPars();
    		X0Y0_竜性2_棘_棘5 = pars3["刺5"].ToPar();
    		X0Y0_竜性2_棘_棘4 = pars3["刺4"].ToPar();
    		X0Y0_竜性2_棘_棘3 = pars3["刺3"].ToPar();
    		X0Y0_竜性2_棘_棘2 = pars3["刺2"].ToPar();
    		X0Y0_竜性2_棘_棘1 = pars3["刺1"].ToPar();
    		pars2 = partGroup["虫性2"].ToPars();
    		X0Y0_虫性2_虫腕下 = pars2["虫腕下"].ToPar();
    		X0Y0_虫性2_虫棘1 = pars2["虫棘1"].ToPar();
    		X0Y0_虫性2_虫棘2 = pars2["虫棘2"].ToPar();
    		X0Y0_虫性2_虫棘3 = pars2["虫棘3"].ToPar();
    		X0Y0_虫性2_虫棘4 = pars2["虫棘4"].ToPar();
    		X0Y0_虫性2_虫鎌節 = pars2["虫鎌節"].ToPar();
    		X0Y0_傷X1 = partGroup["傷X1"].ToPar();
    		X0Y0_傷I1 = partGroup["傷I1"].ToPar();
    		X0Y0_傷I2 = partGroup["傷I2"].ToPar();
    		X0Y0_ハイライト = partGroup["ハイライト"].ToPar();
    		pars2 = partGroup["グローブ"].ToPars();
    		pars3 = pars2["通常"].ToPars();
    		X0Y0_グローブ_通常_グローブ = pars3["グローブ"].ToPar();
    		X0Y0_グローブ_通常_縁 = pars3["縁"].ToPar();
    		pars3 = pars2["筋肉"].ToPars();
    		X0Y0_グローブ_筋肉_グローブ = pars3["グローブ"].ToPar();
    		X0Y0_グローブ_筋肉_縁 = pars3["縁"].ToPar();
    		pars2 = partGroup["鎧"].ToPars();
    		pars3 = pars2["ベルト"].ToPars();
    		X0Y0_鎧_ベルト_ベルト1 = pars3["ベルト1"].ToPar();
    		pars4 = pars3["通常"].ToPars();
    		X0Y0_鎧_ベルト_通常_ベルト2 = pars4["ベルト2"].ToPar();
    		pars4 = pars3["筋肉"].ToPars();
    		X0Y0_鎧_ベルト_筋肉_ベルト2 = pars4["ベルト2"].ToPar();
    		pars3 = pars2["鎧"].ToPars();
    		X0Y0_鎧_鎧_鎧2 = pars3["鎧2"].ToPar();
    		X0Y0_鎧_鎧_鎧1 = pars3["鎧1"].ToPar();
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
    		LowerArm_表示 = e.LowerArm_表示;
    		筋肉_筋肉下_表示 = e.筋肉_筋肉下_表示;
    		筋肉_筋肉上_表示 = e.筋肉_筋肉上_表示;
    		植性1_通常_花弁_花弁_表示 = e.植性1_通常_花弁_花弁_表示;
    		植性1_通常_花弁_影_花弁影1_表示 = e.植性1_通常_花弁_影_花弁影1_表示;
    		植性1_通常_花弁_影_花弁影2_表示 = e.植性1_通常_花弁_影_花弁影2_表示;
    		植性1_通常_花弁_影_花弁影3_表示 = e.植性1_通常_花弁_影_花弁影3_表示;
    		植性1_通常_花弁_影_花弁影4_表示 = e.植性1_通常_花弁_影_花弁影4_表示;
    		植性1_通常_花弁_影_花弁影5_表示 = e.植性1_通常_花弁_影_花弁影5_表示;
    		植性1_欠損_花弁_花弁_表示 = e.植性1_欠損_花弁_花弁_表示;
    		植性1_欠損_花弁_影_花弁影1_表示 = e.植性1_欠損_花弁_影_花弁影1_表示;
    		植性1_欠損_花弁_影_花弁影2_表示 = e.植性1_欠損_花弁_影_花弁影2_表示;
    		植性1_欠損_花弁_影_花弁影3_表示 = e.植性1_欠損_花弁_影_花弁影3_表示;
    		植性1_欠損_花弁_影_花弁影4_表示 = e.植性1_欠損_花弁_影_花弁影4_表示;
    		植性1_欠損_花弁_影_花弁影5_表示 = e.植性1_欠損_花弁_影_花弁影5_表示;
    		獣性1_獣腕_表示 = e.獣性1_獣腕_表示;
    		竜性1_肘_肘1_表示 = e.竜性1_肘_肘1_表示;
    		竜性1_肘_肘2_表示 = e.竜性1_肘_肘2_表示;
    		竜性1_鱗_鱗5_表示 = e.竜性1_鱗_鱗5_表示;
    		竜性1_鱗_鱗4_表示 = e.竜性1_鱗_鱗4_表示;
    		竜性1_鱗_鱗3_表示 = e.竜性1_鱗_鱗3_表示;
    		竜性1_鱗_鱗2_表示 = e.竜性1_鱗_鱗2_表示;
    		竜性1_鱗_鱗1_表示 = e.竜性1_鱗_鱗1_表示;
    		竜性1_手首_鱗3_表示 = e.竜性1_手首_鱗3_表示;
    		竜性1_手首_鱗2_表示 = e.竜性1_手首_鱗2_表示;
    		竜性1_手首_鱗1_表示 = e.竜性1_手首_鱗1_表示;
    		虫性1_虫肘_表示 = e.虫性1_虫肘_表示;
    		虫性1_虫腕上_表示 = e.虫性1_虫腕上_表示;
    		淫タトゥ_手首_タトゥ_表示 = e.淫タトゥ_手首_タトゥ_表示;
    		淫タトゥ_手首_ハート1_タトゥ左_表示 = e.淫タトゥ_手首_ハート1_タトゥ左_表示;
    		淫タトゥ_手首_ハート1_タトゥ右_表示 = e.淫タトゥ_手首_ハート1_タトゥ右_表示;
    		淫タトゥ_手首_ハート3_タトゥ左_表示 = e.淫タトゥ_手首_ハート3_タトゥ左_表示;
    		淫タトゥ_手首_ハート3_タトゥ右_表示 = e.淫タトゥ_手首_ハート3_タトゥ右_表示;
    		淫タトゥ_手首_ハート2_タトゥ左_表示 = e.淫タトゥ_手首_ハート2_タトゥ左_表示;
    		淫タトゥ_手首_ハート2_タトゥ右_表示 = e.淫タトゥ_手首_ハート2_タトゥ右_表示;
    		淫タトゥ_通常_ハート1_タトゥ左_表示 = e.淫タトゥ_通常_ハート1_タトゥ左_表示;
    		淫タトゥ_通常_ハート1_タトゥ右_表示 = e.淫タトゥ_通常_ハート1_タトゥ右_表示;
    		淫タトゥ_通常_ハート2_タトゥ左_表示 = e.淫タトゥ_通常_ハート2_タトゥ左_表示;
    		淫タトゥ_通常_ハート2_タトゥ右_表示 = e.淫タトゥ_通常_ハート2_タトゥ右_表示;
    		淫タトゥ_筋肉_ハート1_タトゥ左_表示 = e.淫タトゥ_筋肉_ハート1_タトゥ左_表示;
    		淫タトゥ_筋肉_ハート1_タトゥ右_表示 = e.淫タトゥ_筋肉_ハート1_タトゥ右_表示;
    		淫タトゥ_筋肉_ハート2_タトゥ左_表示 = e.淫タトゥ_筋肉_ハート2_タトゥ左_表示;
    		淫タトゥ_筋肉_ハート2_タトゥ右_表示 = e.淫タトゥ_筋肉_ハート2_タトゥ右_表示;
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
    		悪タトゥ_通常_タトゥ2_表示 = e.悪タトゥ_通常_タトゥ2_表示;
    		悪タトゥ_通常_逆十字_逆十字1_表示 = e.悪タトゥ_通常_逆十字_逆十字1_表示;
    		悪タトゥ_通常_逆十字_逆十字2_表示 = e.悪タトゥ_通常_逆十字_逆十字2_表示;
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
    		悪タトゥ_筋肉_タトゥ2_表示 = e.悪タトゥ_筋肉_タトゥ2_表示;
    		悪タトゥ_筋肉_逆十字_逆十字1_表示 = e.悪タトゥ_筋肉_逆十字_逆十字1_表示;
    		悪タトゥ_筋肉_逆十字_逆十字2_表示 = e.悪タトゥ_筋肉_逆十字_逆十字2_表示;
    		植性2_通常_萼_萼上_表示 = e.植性2_通常_萼_萼上_表示;
    		植性2_通常_萼_萼下_表示 = e.植性2_通常_萼_萼下_表示;
    		植性2_通常_萼_萼中_表示 = e.植性2_通常_萼_萼中_表示;
    		植性2_欠損_萼_萼上_表示 = e.植性2_欠損_萼_萼上_表示;
    		植性2_欠損_萼_萼下_表示 = e.植性2_欠損_萼_萼下_表示;
    		植性2_欠損_萼_萼中_表示 = e.植性2_欠損_萼_萼中_表示;
    		獣性2_獣毛_表示 = e.獣性2_獣毛_表示;
    		竜性2_棘_棘5_表示 = e.竜性2_棘_棘5_表示;
    		竜性2_棘_棘4_表示 = e.竜性2_棘_棘4_表示;
    		竜性2_棘_棘3_表示 = e.竜性2_棘_棘3_表示;
    		竜性2_棘_棘2_表示 = e.竜性2_棘_棘2_表示;
    		竜性2_棘_棘1_表示 = e.竜性2_棘_棘1_表示;
    		虫性2_虫腕下_表示 = e.虫性2_虫腕下_表示;
    		虫性2_虫棘1_表示 = e.虫性2_虫棘1_表示;
    		虫性2_虫棘2_表示 = e.虫性2_虫棘2_表示;
    		虫性2_虫棘3_表示 = e.虫性2_虫棘3_表示;
    		虫性2_虫棘4_表示 = e.虫性2_虫棘4_表示;
    		虫性2_虫鎌節_表示 = e.虫性2_虫鎌節_表示;
    		傷X1_表示 = e.傷X1_表示;
    		傷I1_表示 = e.傷I1_表示;
    		傷I2_表示 = e.傷I2_表示;
    		ハイライト_表示 = e.ハイライト_表示;
    		グローブ_通常_グローブ_表示 = e.グローブ_通常_グローブ_表示;
    		グローブ_通常_縁_表示 = e.グローブ_通常_縁_表示;
    		グローブ_筋肉_グローブ_表示 = e.グローブ_筋肉_グローブ_表示;
    		グローブ_筋肉_縁_表示 = e.グローブ_筋肉_縁_表示;
    		鎧_ベルト_ベルト1_表示 = e.鎧_ベルト_ベルト1_表示;
    		鎧_ベルト_通常_ベルト2_表示 = e.鎧_ベルト_通常_ベルト2_表示;
    		鎧_ベルト_筋肉_ベルト2_表示 = e.鎧_ベルト_筋肉_ベルト2_表示;
    		鎧_鎧_鎧2_表示 = e.鎧_鎧_鎧2_表示;
    		鎧_鎧_鎧1_表示 = e.鎧_鎧_鎧1_表示;
    		腕輪_革_表示 = e.腕輪_革_表示;
    		腕輪_金具1_表示 = e.腕輪_金具1_表示;
    		腕輪_金具2_表示 = e.腕輪_金具2_表示;
    		腕輪_金具3_表示 = e.腕輪_金具3_表示;
    		腕輪_金具左_表示 = e.腕輪_金具左_表示;
    		腕輪_金具右_表示 = e.腕輪_金具右_表示;
    		植性1_花弁_花弁_表示 = e.植性1_花弁_花弁_表示;
    		植性1_花弁_影_花弁影1_表示 = e.植性1_花弁_影_花弁影1_表示;
    		植性1_花弁_影_花弁影2_表示 = e.植性1_花弁_影_花弁影2_表示;
    		植性1_花弁_影_花弁影3_表示 = e.植性1_花弁_影_花弁影3_表示;
    		植性1_花弁_影_花弁影4_表示 = e.植性1_花弁_影_花弁影4_表示;
    		植性1_花弁_影_花弁影5_表示 = e.植性1_花弁_影_花弁影5_表示;
    		淫タトゥ_ハート1_タトゥ左_表示 = e.淫タトゥ_ハート1_タトゥ左_表示;
    		淫タトゥ_ハート1_タトゥ右_表示 = e.淫タトゥ_ハート1_タトゥ右_表示;
    		淫タトゥ_ハート2_タトゥ左_表示 = e.淫タトゥ_ハート2_タトゥ左_表示;
    		淫タトゥ_ハート2_タトゥ右_表示 = e.淫タトゥ_ハート2_タトゥ右_表示;
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
    		悪タトゥ_タトゥ2_表示 = e.悪タトゥ_タトゥ2_表示;
    		悪タトゥ_逆十字_逆十字1_表示 = e.悪タトゥ_逆十字_逆十字1_表示;
    		悪タトゥ_逆十字_逆十字2_表示 = e.悪タトゥ_逆十字_逆十字2_表示;
    		植性2_萼_萼上_表示 = e.植性2_萼_萼上_表示;
    		植性2_萼_萼下_表示 = e.植性2_萼_萼下_表示;
    		植性2_萼_萼中_表示 = e.植性2_萼_萼中_表示;
    		グローブ_グローブ_表示 = e.グローブ_グローブ_表示;
    		グローブ_縁_表示 = e.グローブ_縁_表示;
    		鎧_ベルト_ベルト2_表示 = e.鎧_ベルト_ベルト2_表示;
    		ハイライト表示 = e.ハイライト表示;
    		腕輪表示 = e.腕輪表示;
    		グローブ表示 = e.グローブ表示;
    		メイル表示 = e.メイル表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Element f;
    		if (e.OuterArm_接続.Count > 0)
    		{
    			外腕_接続 = e.OuterArm_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = LowerArm_人2;
    				f.ConnectionType = ConnectionInfo.LowerArm_人_OuterArm_接続;
    				f.接続(LowerArm_人2.外腕_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.手_接続.Count > 0)
    		{
    			手_接続 = e.手_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = LowerArm_人2;
    				f.ConnectionType = ConnectionInfo.LowerArm_人_手_接続;
    				f.接続(LowerArm_人2.手_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.虫鎌_接続.Count > 0)
    		{
    			虫鎌_接続 = e.虫鎌_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = LowerArm_人2;
    				f.ConnectionType = ConnectionInfo.LowerArm_人_虫鎌_接続;
    				f.接続(LowerArm_人2.虫鎌_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_LowerArmCP = new ColorP(X0Y0_LowerArm, LowerArmCD, DisUnit, abj: true);
    		X0Y0_筋肉_筋肉下CP = new ColorP(X0Y0_筋肉_筋肉下, 筋肉_筋肉下CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉上CP = new ColorP(X0Y0_筋肉_筋肉上, 筋肉_筋肉上CD, DisUnit, abj: false);
    		X0Y0_植性1_通常_花弁_花弁CP = new ColorP(X0Y0_植性1_通常_花弁_花弁, 植性1_花弁_花弁CD, DisUnit, abj: true);
    		X0Y0_植性1_通常_花弁_影_花弁影1CP = new ColorP(X0Y0_植性1_通常_花弁_影_花弁影1, 植性1_花弁_影_花弁影1CD, DisUnit, abj: true);
    		X0Y0_植性1_通常_花弁_影_花弁影2CP = new ColorP(X0Y0_植性1_通常_花弁_影_花弁影2, 植性1_花弁_影_花弁影2CD, DisUnit, abj: true);
    		X0Y0_植性1_通常_花弁_影_花弁影3CP = new ColorP(X0Y0_植性1_通常_花弁_影_花弁影3, 植性1_花弁_影_花弁影3CD, DisUnit, abj: true);
    		X0Y0_植性1_通常_花弁_影_花弁影4CP = new ColorP(X0Y0_植性1_通常_花弁_影_花弁影4, 植性1_花弁_影_花弁影4CD, DisUnit, abj: true);
    		X0Y0_植性1_通常_花弁_影_花弁影5CP = new ColorP(X0Y0_植性1_通常_花弁_影_花弁影5, 植性1_花弁_影_花弁影5CD, DisUnit, abj: true);
    		X0Y0_植性1_欠損_花弁_花弁CP = new ColorP(X0Y0_植性1_欠損_花弁_花弁, 植性1_花弁_花弁CD, DisUnit, abj: true);
    		X0Y0_植性1_欠損_花弁_影_花弁影1CP = new ColorP(X0Y0_植性1_欠損_花弁_影_花弁影1, 植性1_花弁_影_花弁影1CD, DisUnit, abj: true);
    		X0Y0_植性1_欠損_花弁_影_花弁影2CP = new ColorP(X0Y0_植性1_欠損_花弁_影_花弁影2, 植性1_花弁_影_花弁影2CD, DisUnit, abj: true);
    		X0Y0_植性1_欠損_花弁_影_花弁影3CP = new ColorP(X0Y0_植性1_欠損_花弁_影_花弁影3, 植性1_花弁_影_花弁影3CD, DisUnit, abj: true);
    		X0Y0_植性1_欠損_花弁_影_花弁影4CP = new ColorP(X0Y0_植性1_欠損_花弁_影_花弁影4, 植性1_花弁_影_花弁影4CD, DisUnit, abj: true);
    		X0Y0_植性1_欠損_花弁_影_花弁影5CP = new ColorP(X0Y0_植性1_欠損_花弁_影_花弁影5, 植性1_花弁_影_花弁影5CD, DisUnit, abj: true);
    		X0Y0_獣性1_獣腕CP = new ColorP(X0Y0_獣性1_獣腕, 獣性1_獣腕CD, DisUnit, abj: true);
    		X0Y0_竜性1_肘_肘1CP = new ColorP(X0Y0_竜性1_肘_肘1, 竜性1_肘_肘1CD, DisUnit, abj: true);
    		X0Y0_竜性1_肘_肘2CP = new ColorP(X0Y0_竜性1_肘_肘2, 竜性1_肘_肘2CD, DisUnit, abj: true);
    		X0Y0_竜性1_鱗_鱗5CP = new ColorP(X0Y0_竜性1_鱗_鱗5, 竜性1_鱗_鱗5CD, DisUnit, abj: true);
    		X0Y0_竜性1_鱗_鱗4CP = new ColorP(X0Y0_竜性1_鱗_鱗4, 竜性1_鱗_鱗4CD, DisUnit, abj: true);
    		X0Y0_竜性1_鱗_鱗3CP = new ColorP(X0Y0_竜性1_鱗_鱗3, 竜性1_鱗_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性1_鱗_鱗2CP = new ColorP(X0Y0_竜性1_鱗_鱗2, 竜性1_鱗_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性1_鱗_鱗1CP = new ColorP(X0Y0_竜性1_鱗_鱗1, 竜性1_鱗_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性1_手首_鱗3CP = new ColorP(X0Y0_竜性1_手首_鱗3, 竜性1_手首_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性1_手首_鱗2CP = new ColorP(X0Y0_竜性1_手首_鱗2, 竜性1_手首_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性1_手首_鱗1CP = new ColorP(X0Y0_竜性1_手首_鱗1, 竜性1_手首_鱗1CD, DisUnit, abj: true);
    		X0Y0_虫性1_虫肘CP = new ColorP(X0Y0_虫性1_虫肘, 虫性1_虫肘CD, DisUnit, abj: true);
    		X0Y0_虫性1_虫腕上CP = new ColorP(X0Y0_虫性1_虫腕上, 虫性1_虫腕上CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_手首_タトゥCP = new ColorP(X0Y0_淫タトゥ_手首_タトゥ, 淫タトゥ_手首_タトゥCD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_手首_ハート1_タトゥ左CP = new ColorP(X0Y0_淫タトゥ_手首_ハート1_タトゥ左, 淫タトゥ_手首_ハート1_タトゥ左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_手首_ハート1_タトゥ右CP = new ColorP(X0Y0_淫タトゥ_手首_ハート1_タトゥ右, 淫タトゥ_手首_ハート1_タトゥ右CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_手首_ハート3_タトゥ左CP = new ColorP(X0Y0_淫タトゥ_手首_ハート3_タトゥ左, 淫タトゥ_手首_ハート3_タトゥ左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_手首_ハート3_タトゥ右CP = new ColorP(X0Y0_淫タトゥ_手首_ハート3_タトゥ右, 淫タトゥ_手首_ハート3_タトゥ右CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_手首_ハート2_タトゥ左CP = new ColorP(X0Y0_淫タトゥ_手首_ハート2_タトゥ左, 淫タトゥ_手首_ハート2_タトゥ左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_手首_ハート2_タトゥ右CP = new ColorP(X0Y0_淫タトゥ_手首_ハート2_タトゥ右, 淫タトゥ_手首_ハート2_タトゥ右CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_通常_ハート1_タトゥ左CP = new ColorP(X0Y0_淫タトゥ_通常_ハート1_タトゥ左, 淫タトゥ_ハート1_タトゥ左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_通常_ハート1_タトゥ右CP = new ColorP(X0Y0_淫タトゥ_通常_ハート1_タトゥ右, 淫タトゥ_ハート1_タトゥ右CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_通常_ハート2_タトゥ左CP = new ColorP(X0Y0_淫タトゥ_通常_ハート2_タトゥ左, 淫タトゥ_ハート2_タトゥ左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_通常_ハート2_タトゥ右CP = new ColorP(X0Y0_淫タトゥ_通常_ハート2_タトゥ右, 淫タトゥ_ハート2_タトゥ右CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_筋肉_ハート1_タトゥ左CP = new ColorP(X0Y0_淫タトゥ_筋肉_ハート1_タトゥ左, 淫タトゥ_ハート1_タトゥ左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_筋肉_ハート1_タトゥ右CP = new ColorP(X0Y0_淫タトゥ_筋肉_ハート1_タトゥ右, 淫タトゥ_ハート1_タトゥ右CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_筋肉_ハート2_タトゥ左CP = new ColorP(X0Y0_淫タトゥ_筋肉_ハート2_タトゥ左, 淫タトゥ_ハート2_タトゥ左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_筋肉_ハート2_タトゥ右CP = new ColorP(X0Y0_淫タトゥ_筋肉_ハート2_タトゥ右, 淫タトゥ_ハート2_タトゥ右CD, DisUnit, abj: true);
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
    		X0Y0_悪タトゥ_通常_タトゥ2CP = new ColorP(X0Y0_悪タトゥ_通常_タトゥ2, 悪タトゥ_タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_逆十字_逆十字1CP = new ColorP(X0Y0_悪タトゥ_通常_逆十字_逆十字1, 悪タトゥ_逆十字_逆十字1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_通常_逆十字_逆十字2CP = new ColorP(X0Y0_悪タトゥ_通常_逆十字_逆十字2, 悪タトゥ_逆十字_逆十字2CD, DisUnit, abj: true);
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
    		X0Y0_悪タトゥ_筋肉_タトゥ2CP = new ColorP(X0Y0_悪タトゥ_筋肉_タトゥ2, 悪タトゥ_タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_逆十字_逆十字1CP = new ColorP(X0Y0_悪タトゥ_筋肉_逆十字_逆十字1, 悪タトゥ_逆十字_逆十字1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_筋肉_逆十字_逆十字2CP = new ColorP(X0Y0_悪タトゥ_筋肉_逆十字_逆十字2, 悪タトゥ_逆十字_逆十字2CD, DisUnit, abj: true);
    		X0Y0_植性2_通常_萼_萼上CP = new ColorP(X0Y0_植性2_通常_萼_萼上, 植性2_萼_萼上CD, DisUnit, abj: true);
    		X0Y0_植性2_通常_萼_萼下CP = new ColorP(X0Y0_植性2_通常_萼_萼下, 植性2_萼_萼下CD, DisUnit, abj: true);
    		X0Y0_植性2_通常_萼_萼中CP = new ColorP(X0Y0_植性2_通常_萼_萼中, 植性2_萼_萼中CD, DisUnit, abj: true);
    		X0Y0_植性2_欠損_萼_萼上CP = new ColorP(X0Y0_植性2_欠損_萼_萼上, 植性2_萼_萼上CD, DisUnit, abj: true);
    		X0Y0_植性2_欠損_萼_萼下CP = new ColorP(X0Y0_植性2_欠損_萼_萼下, 植性2_萼_萼下CD, DisUnit, abj: true);
    		X0Y0_植性2_欠損_萼_萼中CP = new ColorP(X0Y0_植性2_欠損_萼_萼中, 植性2_萼_萼中CD, DisUnit, abj: true);
    		X0Y0_獣性2_獣毛CP = new ColorP(X0Y0_獣性2_獣毛, 獣性2_獣毛CD, DisUnit, abj: true);
    		X0Y0_竜性2_棘_棘5CP = new ColorP(X0Y0_竜性2_棘_棘5, 竜性2_棘_棘5CD, DisUnit, abj: true);
    		X0Y0_竜性2_棘_棘4CP = new ColorP(X0Y0_竜性2_棘_棘4, 竜性2_棘_棘4CD, DisUnit, abj: true);
    		X0Y0_竜性2_棘_棘3CP = new ColorP(X0Y0_竜性2_棘_棘3, 竜性2_棘_棘3CD, DisUnit, abj: true);
    		X0Y0_竜性2_棘_棘2CP = new ColorP(X0Y0_竜性2_棘_棘2, 竜性2_棘_棘2CD, DisUnit, abj: true);
    		X0Y0_竜性2_棘_棘1CP = new ColorP(X0Y0_竜性2_棘_棘1, 竜性2_棘_棘1CD, DisUnit, abj: true);
    		X0Y0_虫性2_虫腕下CP = new ColorP(X0Y0_虫性2_虫腕下, 虫性2_虫腕下CD, DisUnit, abj: true);
    		X0Y0_虫性2_虫棘1CP = new ColorP(X0Y0_虫性2_虫棘1, 虫性2_虫棘1CD, DisUnit, abj: true);
    		X0Y0_虫性2_虫棘2CP = new ColorP(X0Y0_虫性2_虫棘2, 虫性2_虫棘2CD, DisUnit, abj: true);
    		X0Y0_虫性2_虫棘3CP = new ColorP(X0Y0_虫性2_虫棘3, 虫性2_虫棘3CD, DisUnit, abj: true);
    		X0Y0_虫性2_虫棘4CP = new ColorP(X0Y0_虫性2_虫棘4, 虫性2_虫棘4CD, DisUnit, abj: true);
    		X0Y0_虫性2_虫鎌節CP = new ColorP(X0Y0_虫性2_虫鎌節, 虫性2_虫鎌節CD, DisUnit, abj: true);
    		X0Y0_傷X1CP = new ColorP(X0Y0_傷X1, 傷X1CD, DisUnit, abj: true);
    		X0Y0_傷I1CP = new ColorP(X0Y0_傷I1, 傷I1CD, DisUnit, abj: true);
    		X0Y0_傷I2CP = new ColorP(X0Y0_傷I2, 傷I2CD, DisUnit, abj: true);
    		X0Y0_ハイライトCP = new ColorP(X0Y0_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y0_グローブ_通常_グローブCP = new ColorP(X0Y0_グローブ_通常_グローブ, グローブ_グローブCD, DisUnit, abj: true);
    		X0Y0_グローブ_通常_縁CP = new ColorP(X0Y0_グローブ_通常_縁, グローブ_縁CD, DisUnit, abj: true);
    		X0Y0_グローブ_筋肉_グローブCP = new ColorP(X0Y0_グローブ_筋肉_グローブ, グローブ_グローブCD, DisUnit, abj: true);
    		X0Y0_グローブ_筋肉_縁CP = new ColorP(X0Y0_グローブ_筋肉_縁, グローブ_縁CD, DisUnit, abj: true);
    		X0Y0_鎧_ベルト_ベルト1CP = new ColorP(X0Y0_鎧_ベルト_ベルト1, 鎧_ベルト_ベルト1CD, DisUnit, abj: true);
    		X0Y0_鎧_ベルト_通常_ベルト2CP = new ColorP(X0Y0_鎧_ベルト_通常_ベルト2, 鎧_ベルト_ベルト2CD, DisUnit, abj: true);
    		X0Y0_鎧_ベルト_筋肉_ベルト2CP = new ColorP(X0Y0_鎧_ベルト_筋肉_ベルト2, 鎧_ベルト_ベルト2CD, DisUnit, abj: true);
    		X0Y0_鎧_鎧_鎧2CP = new ColorP(X0Y0_鎧_鎧_鎧2, 鎧_鎧_鎧2CD, DisUnit, abj: true);
    		X0Y0_鎧_鎧_鎧1CP = new ColorP(X0Y0_鎧_鎧_鎧1, 鎧_鎧_鎧1CD, DisUnit, abj: true);
    		X0Y0_腕輪_革CP = new ColorP(X0Y0_腕輪_革, 腕輪_革CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具1CP = new ColorP(X0Y0_腕輪_金具1, 腕輪_金具1CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具2CP = new ColorP(X0Y0_腕輪_金具2, 腕輪_金具2CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具3CP = new ColorP(X0Y0_腕輪_金具3, 腕輪_金具3CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具左CP = new ColorP(X0Y0_腕輪_金具左, 腕輪_金具左CD, DisUnit, abj: true);
    		X0Y0_腕輪_金具右CP = new ColorP(X0Y0_腕輪_金具右, 腕輪_金具右CD, DisUnit, abj: true);
    		傷X1濃度 = e.傷X1濃度;
    		傷I1濃度 = e.傷I1濃度;
    		傷I2濃度 = e.傷I2濃度;
    		ハイライト濃度 = e.ハイライト濃度;
    		Intensity = e.濃度;
    		鎖1 = new 拘束鎖(DisUnit, 右: false, 配色指定, 体配色, Xasix);
    		鎖1.接続(鎖1_接続点);
    		鎖表示 = e.鎖表示;
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_LowerArm);
    		Are.Draw(X0Y0_筋肉_筋肉下);
    		Are.Draw(X0Y0_筋肉_筋肉上);
    		キスマーク.Draw(Are);
    		Are.Draw(X0Y0_獣性1_獣腕);
    		鞭痕.Draw(Are);
    		Are.Draw(X0Y0_竜性1_肘_肘1);
    		Are.Draw(X0Y0_竜性1_肘_肘2);
    		Are.Draw(X0Y0_竜性1_鱗_鱗5);
    		Are.Draw(X0Y0_竜性1_鱗_鱗4);
    		Are.Draw(X0Y0_竜性1_鱗_鱗3);
    		Are.Draw(X0Y0_竜性1_鱗_鱗2);
    		Are.Draw(X0Y0_竜性1_鱗_鱗1);
    		Are.Draw(X0Y0_竜性1_手首_鱗3);
    		Are.Draw(X0Y0_竜性1_手首_鱗2);
    		Are.Draw(X0Y0_竜性1_手首_鱗1);
    	}

    	public void 外腕描画(RenderArea Are)
    	{
    		Are.Draw(X0Y0_植性1_通常_花弁_花弁);
    		Are.Draw(X0Y0_植性1_通常_花弁_影_花弁影1);
    		Are.Draw(X0Y0_植性1_通常_花弁_影_花弁影2);
    		Are.Draw(X0Y0_植性1_通常_花弁_影_花弁影3);
    		Are.Draw(X0Y0_植性1_通常_花弁_影_花弁影4);
    		Are.Draw(X0Y0_植性1_通常_花弁_影_花弁影5);
    		Are.Draw(X0Y0_植性1_欠損_花弁_花弁);
    		Are.Draw(X0Y0_植性1_欠損_花弁_影_花弁影1);
    		Are.Draw(X0Y0_植性1_欠損_花弁_影_花弁影2);
    		Are.Draw(X0Y0_植性1_欠損_花弁_影_花弁影3);
    		Are.Draw(X0Y0_植性1_欠損_花弁_影_花弁影4);
    		Are.Draw(X0Y0_植性1_欠損_花弁_影_花弁影5);
    		Are.Draw(X0Y0_虫性1_虫肘);
    		Are.Draw(X0Y0_虫性1_虫腕上);
    		Are.Draw(X0Y0_淫タトゥ_手首_タトゥ);
    		Are.Draw(X0Y0_淫タトゥ_手首_ハート1_タトゥ左);
    		Are.Draw(X0Y0_淫タトゥ_手首_ハート1_タトゥ右);
    		Are.Draw(X0Y0_淫タトゥ_手首_ハート3_タトゥ左);
    		Are.Draw(X0Y0_淫タトゥ_手首_ハート3_タトゥ右);
    		Are.Draw(X0Y0_淫タトゥ_手首_ハート2_タトゥ左);
    		Are.Draw(X0Y0_淫タトゥ_手首_ハート2_タトゥ右);
    		Are.Draw(X0Y0_淫タトゥ_通常_ハート1_タトゥ左);
    		Are.Draw(X0Y0_淫タトゥ_通常_ハート1_タトゥ右);
    		Are.Draw(X0Y0_淫タトゥ_通常_ハート2_タトゥ左);
    		Are.Draw(X0Y0_淫タトゥ_通常_ハート2_タトゥ右);
    		Are.Draw(X0Y0_淫タトゥ_筋肉_ハート1_タトゥ左);
    		Are.Draw(X0Y0_淫タトゥ_筋肉_ハート1_タトゥ右);
    		Are.Draw(X0Y0_淫タトゥ_筋肉_ハート2_タトゥ左);
    		Are.Draw(X0Y0_淫タトゥ_筋肉_ハート2_タトゥ右);
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
    		Are.Draw(X0Y0_悪タトゥ_通常_タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_通常_逆十字_逆十字1);
    		Are.Draw(X0Y0_悪タトゥ_通常_逆十字_逆十字2);
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
    		Are.Draw(X0Y0_悪タトゥ_筋肉_タトゥ2);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_逆十字_逆十字1);
    		Are.Draw(X0Y0_悪タトゥ_筋肉_逆十字_逆十字2);
    		Are.Draw(X0Y0_植性2_通常_萼_萼上);
    		Are.Draw(X0Y0_植性2_通常_萼_萼下);
    		Are.Draw(X0Y0_植性2_通常_萼_萼中);
    		Are.Draw(X0Y0_植性2_欠損_萼_萼上);
    		Are.Draw(X0Y0_植性2_欠損_萼_萼下);
    		Are.Draw(X0Y0_植性2_欠損_萼_萼中);
    		Are.Draw(X0Y0_獣性2_獣毛);
    		Are.Draw(X0Y0_竜性2_棘_棘5);
    		Are.Draw(X0Y0_竜性2_棘_棘4);
    		Are.Draw(X0Y0_竜性2_棘_棘3);
    		Are.Draw(X0Y0_竜性2_棘_棘2);
    		Are.Draw(X0Y0_竜性2_棘_棘1);
    		Are.Draw(X0Y0_虫性2_虫腕下);
    		Are.Draw(X0Y0_虫性2_虫棘1);
    		Are.Draw(X0Y0_虫性2_虫棘2);
    		Are.Draw(X0Y0_虫性2_虫棘3);
    		Are.Draw(X0Y0_虫性2_虫棘4);
    		Are.Draw(X0Y0_虫性2_虫鎌節);
    		Are.Draw(X0Y0_傷X1);
    		Are.Draw(X0Y0_傷I1);
    		Are.Draw(X0Y0_傷I2);
    		Are.Draw(X0Y0_ハイライト);
    		Are.Draw(X0Y0_グローブ_通常_グローブ);
    		Are.Draw(X0Y0_グローブ_通常_縁);
    		Are.Draw(X0Y0_グローブ_筋肉_グローブ);
    		Are.Draw(X0Y0_グローブ_筋肉_縁);
    		Are.Draw(X0Y0_鎧_ベルト_ベルト1);
    		Are.Draw(X0Y0_鎧_ベルト_通常_ベルト2);
    		Are.Draw(X0Y0_鎧_ベルト_筋肉_ベルト2);
    		Are.Draw(X0Y0_鎧_鎧_鎧2);
    		Are.Draw(X0Y0_鎧_鎧_鎧1);
    		Are.Draw(X0Y0_腕輪_革);
    		Are.Draw(X0Y0_腕輪_金具1);
    		Are.Draw(X0Y0_腕輪_金具2);
    		Are.Draw(X0Y0_腕輪_金具3);
    		Are.Draw(X0Y0_腕輪_金具左);
    		Are.Draw(X0Y0_腕輪_金具右);
    		鎖1.描画0(Are);
    	}

    	public override void SetRestraintAngle()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_LowerArm.AngleBase = num * 130.0;
    		Body.JoinPAall();
    	}

    	public void 腕輪尺度修正()
    	{
    		if (獣性1_獣腕_表示)
    		{
    			double num = 1.7;
    			X0Y0_腕輪_革.SizeBase *= num;
    			X0Y0_腕輪_金具1.SizeBase *= num;
    			X0Y0_腕輪_金具2.SizeBase *= num;
    			X0Y0_腕輪_金具3.SizeBase *= num;
    			X0Y0_腕輪_金具左.SizeBase *= num;
    			X0Y0_腕輪_金具右.SizeBase *= num;
    		}
    	}

    	public override bool Is布(ShapePart p)
    	{
    		if (p != X0Y0_グローブ_通常_グローブ && p != X0Y0_グローブ_通常_縁 && p != X0Y0_グローブ_筋肉_グローブ)
    		{
    			return p == X0Y0_グローブ_筋肉_縁;
    		}
    		return true;
    	}

    	public override bool Is革(ShapePart p)
    	{
    		if (p != X0Y0_腕輪_革 && p != X0Y0_腕輪_金具1 && p != X0Y0_腕輪_金具2 && p != X0Y0_腕輪_金具3 && p != X0Y0_腕輪_金具左)
    		{
    			return p == X0Y0_腕輪_金具右;
    		}
    		return true;
    	}

    	public override bool Is鉄(ShapePart p)
    	{
    		if (p != X0Y0_鎧_ベルト_ベルト1 && p != X0Y0_鎧_ベルト_通常_ベルト2 && p != X0Y0_鎧_ベルト_筋肉_ベルト2 && p != X0Y0_鎧_鎧_鎧2)
    		{
    			return p == X0Y0_鎧_鎧_鎧1;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_LowerArmCP.Update();
    		X0Y0_筋肉_筋肉下CP.Update();
    		X0Y0_筋肉_筋肉上CP.Update();
    		X0Y0_植性1_通常_花弁_花弁CP.Update();
    		X0Y0_植性1_通常_花弁_影_花弁影1CP.Update();
    		X0Y0_植性1_通常_花弁_影_花弁影2CP.Update();
    		X0Y0_植性1_通常_花弁_影_花弁影3CP.Update();
    		X0Y0_植性1_通常_花弁_影_花弁影4CP.Update();
    		X0Y0_植性1_通常_花弁_影_花弁影5CP.Update();
    		X0Y0_植性1_欠損_花弁_花弁CP.Update();
    		X0Y0_植性1_欠損_花弁_影_花弁影1CP.Update();
    		X0Y0_植性1_欠損_花弁_影_花弁影2CP.Update();
    		X0Y0_植性1_欠損_花弁_影_花弁影3CP.Update();
    		X0Y0_植性1_欠損_花弁_影_花弁影4CP.Update();
    		X0Y0_植性1_欠損_花弁_影_花弁影5CP.Update();
    		X0Y0_獣性1_獣腕CP.Update();
    		X0Y0_竜性1_肘_肘1CP.Update();
    		X0Y0_竜性1_肘_肘2CP.Update();
    		X0Y0_竜性1_鱗_鱗5CP.Update();
    		X0Y0_竜性1_鱗_鱗4CP.Update();
    		X0Y0_竜性1_鱗_鱗3CP.Update();
    		X0Y0_竜性1_鱗_鱗2CP.Update();
    		X0Y0_竜性1_鱗_鱗1CP.Update();
    		X0Y0_竜性1_手首_鱗3CP.Update();
    		X0Y0_竜性1_手首_鱗2CP.Update();
    		X0Y0_竜性1_手首_鱗1CP.Update();
    		X0Y0_虫性1_虫肘CP.Update();
    		X0Y0_虫性1_虫腕上CP.Update();
    		X0Y0_淫タトゥ_手首_タトゥCP.Update();
    		X0Y0_淫タトゥ_手首_ハート1_タトゥ左CP.Update();
    		X0Y0_淫タトゥ_手首_ハート1_タトゥ右CP.Update();
    		X0Y0_淫タトゥ_手首_ハート3_タトゥ左CP.Update();
    		X0Y0_淫タトゥ_手首_ハート3_タトゥ右CP.Update();
    		X0Y0_淫タトゥ_手首_ハート2_タトゥ左CP.Update();
    		X0Y0_淫タトゥ_手首_ハート2_タトゥ右CP.Update();
    		X0Y0_淫タトゥ_通常_ハート1_タトゥ左CP.Update();
    		X0Y0_淫タトゥ_通常_ハート1_タトゥ右CP.Update();
    		X0Y0_淫タトゥ_通常_ハート2_タトゥ左CP.Update();
    		X0Y0_淫タトゥ_通常_ハート2_タトゥ右CP.Update();
    		X0Y0_淫タトゥ_筋肉_ハート1_タトゥ左CP.Update();
    		X0Y0_淫タトゥ_筋肉_ハート1_タトゥ右CP.Update();
    		X0Y0_淫タトゥ_筋肉_ハート2_タトゥ左CP.Update();
    		X0Y0_淫タトゥ_筋肉_ハート2_タトゥ右CP.Update();
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
    		X0Y0_悪タトゥ_通常_タトゥ2CP.Update();
    		X0Y0_悪タトゥ_通常_逆十字_逆十字1CP.Update();
    		X0Y0_悪タトゥ_通常_逆十字_逆十字2CP.Update();
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
    		X0Y0_悪タトゥ_筋肉_タトゥ2CP.Update();
    		X0Y0_悪タトゥ_筋肉_逆十字_逆十字1CP.Update();
    		X0Y0_悪タトゥ_筋肉_逆十字_逆十字2CP.Update();
    		X0Y0_植性2_通常_萼_萼上CP.Update();
    		X0Y0_植性2_通常_萼_萼下CP.Update();
    		X0Y0_植性2_通常_萼_萼中CP.Update();
    		X0Y0_植性2_欠損_萼_萼上CP.Update();
    		X0Y0_植性2_欠損_萼_萼下CP.Update();
    		X0Y0_植性2_欠損_萼_萼中CP.Update();
    		X0Y0_獣性2_獣毛CP.Update();
    		X0Y0_竜性2_棘_棘5CP.Update();
    		X0Y0_竜性2_棘_棘4CP.Update();
    		X0Y0_竜性2_棘_棘3CP.Update();
    		X0Y0_竜性2_棘_棘2CP.Update();
    		X0Y0_竜性2_棘_棘1CP.Update();
    		X0Y0_虫性2_虫腕下CP.Update();
    		X0Y0_虫性2_虫棘1CP.Update();
    		X0Y0_虫性2_虫棘2CP.Update();
    		X0Y0_虫性2_虫棘3CP.Update();
    		X0Y0_虫性2_虫棘4CP.Update();
    		X0Y0_虫性2_虫鎌節CP.Update();
    		X0Y0_傷X1CP.Update();
    		X0Y0_傷I1CP.Update();
    		X0Y0_傷I2CP.Update();
    		X0Y0_ハイライトCP.Update();
    		X0Y0_グローブ_通常_グローブCP.Update();
    		X0Y0_グローブ_通常_縁CP.Update();
    		X0Y0_グローブ_筋肉_グローブCP.Update();
    		X0Y0_グローブ_筋肉_縁CP.Update();
    		X0Y0_鎧_ベルト_ベルト1CP.Update();
    		X0Y0_鎧_ベルト_通常_ベルト2CP.Update();
    		X0Y0_鎧_ベルト_筋肉_ベルト2CP.Update();
    		X0Y0_鎧_鎧_鎧2CP.Update();
    		X0Y0_鎧_鎧_鎧1CP.Update();
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
    		case 配色指定.B0:
    			配色B0(体配色);
    			break;
    		case 配色指定.BT0:
    			配色BT0(体配色);
    			break;
    		case 配色指定.BT1:
    			配色BT1(体配色);
    			break;
    		case 配色指定.L0:
    			配色L0(体配色);
    			break;
    		case 配色指定.LT0:
    			配色LT0(体配色);
    			break;
    		case 配色指定.LT1:
    			配色LT1(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		LowerArmCD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
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
    		悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		グローブ_グローブCD = new ColorD();
    		グローブ_縁CD = new ColorD();
    		鎧_ベルト_ベルト1CD = new ColorD();
    		鎧_ベルト_ベルト2CD = new ColorD();
    		鎧_鎧_鎧2CD = new ColorD();
    		鎧_鎧_鎧1CD = new ColorD();
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		LowerArmCD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
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
    		悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		グローブ_グローブCD = new ColorD();
    		グローブ_縁CD = new ColorD();
    		鎧_ベルト_ベルト1CD = new ColorD();
    		鎧_ベルト_ベルト2CD = new ColorD();
    		鎧_鎧_鎧2CD = new ColorD();
    		鎧_鎧_鎧1CD = new ColorD();
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		LowerArmCD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
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
    		悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		グローブ_グローブCD = new ColorD();
    		グローブ_縁CD = new ColorD();
    		鎧_ベルト_ベルト1CD = new ColorD();
    		鎧_ベルト_ベルト2CD = new ColorD();
    		鎧_鎧_鎧2CD = new ColorD();
    		鎧_鎧_鎧1CD = new ColorD();
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色B0(BodyColorSet 体配色)
    	{
    		LowerArmCD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
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
    		悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		グローブ_グローブCD = new ColorD();
    		グローブ_縁CD = new ColorD();
    		鎧_ベルト_ベルト1CD = new ColorD();
    		鎧_ベルト_ベルト2CD = new ColorD();
    		鎧_鎧_鎧2CD = new ColorD();
    		鎧_鎧_鎧1CD = new ColorD();
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色BT0(BodyColorSet 体配色)
    	{
    		LowerArmCD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
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
    		悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		グローブ_グローブCD = new ColorD();
    		グローブ_縁CD = new ColorD();
    		鎧_ベルト_ベルト1CD = new ColorD();
    		鎧_ベルト_ベルト2CD = new ColorD();
    		鎧_鎧_鎧2CD = new ColorD();
    		鎧_鎧_鎧1CD = new ColorD();
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色BT1(BodyColorSet 体配色)
    	{
    		LowerArmCD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
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
    		悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		グローブ_グローブCD = new ColorD();
    		グローブ_縁CD = new ColorD();
    		鎧_ベルト_ベルト1CD = new ColorD();
    		鎧_ベルト_ベルト2CD = new ColorD();
    		鎧_鎧_鎧2CD = new ColorD();
    		鎧_鎧_鎧1CD = new ColorD();
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色L0(BodyColorSet 体配色)
    	{
    		LowerArmCD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
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
    		悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		グローブ_グローブCD = new ColorD();
    		グローブ_縁CD = new ColorD();
    		鎧_ベルト_ベルト1CD = new ColorD();
    		鎧_ベルト_ベルト2CD = new ColorD();
    		鎧_鎧_鎧2CD = new ColorD();
    		鎧_鎧_鎧1CD = new ColorD();
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色LT0(BodyColorSet 体配色)
    	{
    		LowerArmCD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
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
    		悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		グローブ_グローブCD = new ColorD();
    		グローブ_縁CD = new ColorD();
    		鎧_ベルト_ベルト1CD = new ColorD();
    		鎧_ベルト_ベルト2CD = new ColorD();
    		鎧_鎧_鎧2CD = new ColorD();
    		鎧_鎧_鎧1CD = new ColorD();
    		腕輪_革CD = new ColorD();
    		腕輪_金具1CD = new ColorD();
    		腕輪_金具2CD = new ColorD();
    		腕輪_金具3CD = new ColorD();
    		腕輪_金具左CD = new ColorD();
    		腕輪_金具右CD = new ColorD();
    	}

    	private void 配色LT1(BodyColorSet 体配色)
    	{
    		LowerArmCD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
    		竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_手首_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		淫タトゥ_ハート2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
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
    		悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.植1O);
    		獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
    		ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
    		グローブ_グローブCD = new ColorD();
    		グローブ_縁CD = new ColorD();
    		鎧_ベルト_ベルト1CD = new ColorD();
    		鎧_ベルト_ベルト2CD = new ColorD();
    		鎧_鎧_鎧2CD = new ColorD();
    		鎧_鎧_鎧1CD = new ColorD();
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
