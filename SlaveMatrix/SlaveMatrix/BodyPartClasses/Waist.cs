using _2DGAMELIB;
using SlaveMatrix.GameClasses;
using System.Linq;

namespace SlaveMatrix
{
    public class Waist : Element
    {
    	public ShapePart X0Y0_Waist;

    	public ShapePart X0Y0_股;

    	public ShapePart X0Y0_下腹;

    	public ShapePart X0Y0_腰皺;

    	public ShapePart X0Y0_筋肉_筋肉下;

    	public ShapePart X0Y0_筋肉_筋肉左;

    	public ShapePart X0Y0_筋肉_筋肉右;

    	public ShapePart X0Y0_筋肉_筋上左;

    	public ShapePart X0Y0_筋肉_筋上右;

    	public ShapePart X0Y0_筋肉_筋下左;

    	public ShapePart X0Y0_筋肉_筋下右;

    	public ShapePart X0Y0_ハイライト;

    	public ShapePart X0Y0_臍;

    	public ShapePart X0Y0_悪タトゥ_渦_タトゥ1左;

    	public ShapePart X0Y0_悪タトゥ_渦_タトゥ1右;

    	public ShapePart X0Y0_悪タトゥ_渦_タトゥ2左;

    	public ShapePart X0Y0_悪タトゥ_渦_タトゥ2右;

    	public ShapePart X0Y0_淫タトゥ_ハート_タトゥ1左;

    	public ShapePart X0Y0_淫タトゥ_ハート_タトゥ1右;

    	public ShapePart X0Y0_淫タトゥ_ハート_タトゥ2左;

    	public ShapePart X0Y0_淫タトゥ_ハート_タトゥ2右;

    	public ShapePart X0Y0_傷X左;

    	public ShapePart X0Y0_傷X右;

    	public ShapePart X0Y0_傷I左;

    	public ShapePart X0Y0_傷I右;

    	public ShapePart X0Y0_紋柄_紋左_紋1;

    	public ShapePart X0Y0_紋柄_紋左_紋2;

    	public ShapePart X0Y0_紋柄_紋左_紋3;

    	public ShapePart X0Y0_紋柄_紋右_紋1;

    	public ShapePart X0Y0_紋柄_紋右_紋2;

    	public ShapePart X0Y0_紋柄_紋右_紋3;

    	public ShapePart X0Y0_獣性_獣毛左;

    	public ShapePart X0Y0_獣性_獣毛右;

    	public ShapePart X0Y0_虫性_甲殻2;

    	public ShapePart X0Y0_虫性_甲殻1;

    	public ShapePart X0Y0_竜性_左_鱗1;

    	public ShapePart X0Y0_竜性_左_鱗2;

    	public ShapePart X0Y0_竜性_右_鱗1;

    	public ShapePart X0Y0_竜性_右_鱗2;

    	public ShapePart X0Y0_ハイライト上左;

    	public ShapePart X0Y0_ハイライト上右;

    	public ShapePart X0Y0_ハイライト下左;

    	public ShapePart X0Y0_ハイライト下右;

    	public ShapePart X0Y1_Waist;

    	public ShapePart X0Y1_股;

    	public ShapePart X0Y1_下腹;

    	public ShapePart X0Y1_腰皺;

    	public ShapePart X0Y1_筋肉_筋肉下;

    	public ShapePart X0Y1_筋肉_筋肉左;

    	public ShapePart X0Y1_筋肉_筋肉右;

    	public ShapePart X0Y1_筋肉_筋上左;

    	public ShapePart X0Y1_筋肉_筋上右;

    	public ShapePart X0Y1_筋肉_筋下左;

    	public ShapePart X0Y1_筋肉_筋下右;

    	public ShapePart X0Y1_ハイライト;

    	public ShapePart X0Y1_臍;

    	public ShapePart X0Y1_悪タトゥ_渦_タトゥ1左;

    	public ShapePart X0Y1_悪タトゥ_渦_タトゥ1右;

    	public ShapePart X0Y1_悪タトゥ_渦_タトゥ2左;

    	public ShapePart X0Y1_悪タトゥ_渦_タトゥ2右;

    	public ShapePart X0Y1_淫タトゥ_ハート_タトゥ1左;

    	public ShapePart X0Y1_淫タトゥ_ハート_タトゥ1右;

    	public ShapePart X0Y1_淫タトゥ_ハート_タトゥ2左;

    	public ShapePart X0Y1_淫タトゥ_ハート_タトゥ2右;

    	public ShapePart X0Y1_傷X左;

    	public ShapePart X0Y1_傷X右;

    	public ShapePart X0Y1_傷I左;

    	public ShapePart X0Y1_傷I右;

    	public ShapePart X0Y1_紋柄_紋左_紋1;

    	public ShapePart X0Y1_紋柄_紋左_紋2;

    	public ShapePart X0Y1_紋柄_紋左_紋3;

    	public ShapePart X0Y1_紋柄_紋右_紋1;

    	public ShapePart X0Y1_紋柄_紋右_紋2;

    	public ShapePart X0Y1_紋柄_紋右_紋3;

    	public ShapePart X0Y1_獣性_獣毛左;

    	public ShapePart X0Y1_獣性_獣毛右;

    	public ShapePart X0Y1_虫性_甲殻2;

    	public ShapePart X0Y1_虫性_甲殻1;

    	public ShapePart X0Y1_竜性_左_鱗1;

    	public ShapePart X0Y1_竜性_左_鱗2;

    	public ShapePart X0Y1_竜性_右_鱗1;

    	public ShapePart X0Y1_竜性_右_鱗2;

    	public ShapePart X0Y1_ハイライト上左;

    	public ShapePart X0Y1_ハイライト上右;

    	public ShapePart X0Y1_ハイライト下左;

    	public ShapePart X0Y1_ハイライト下右;

    	public ShapePart X0Y2_Waist;

    	public ShapePart X0Y2_股;

    	public ShapePart X0Y2_下腹;

    	public ShapePart X0Y2_腰皺;

    	public ShapePart X0Y2_筋肉_筋肉下;

    	public ShapePart X0Y2_筋肉_筋肉左;

    	public ShapePart X0Y2_筋肉_筋肉右;

    	public ShapePart X0Y2_筋肉_筋上左;

    	public ShapePart X0Y2_筋肉_筋上右;

    	public ShapePart X0Y2_筋肉_筋下左;

    	public ShapePart X0Y2_筋肉_筋下右;

    	public ShapePart X0Y2_ハイライト;

    	public ShapePart X0Y2_臍;

    	public ShapePart X0Y2_悪タトゥ_渦_タトゥ1左;

    	public ShapePart X0Y2_悪タトゥ_渦_タトゥ1右;

    	public ShapePart X0Y2_悪タトゥ_渦_タトゥ2左;

    	public ShapePart X0Y2_悪タトゥ_渦_タトゥ2右;

    	public ShapePart X0Y2_淫タトゥ_ハート_タトゥ1左;

    	public ShapePart X0Y2_淫タトゥ_ハート_タトゥ1右;

    	public ShapePart X0Y2_淫タトゥ_ハート_タトゥ2左;

    	public ShapePart X0Y2_淫タトゥ_ハート_タトゥ2右;

    	public ShapePart X0Y2_傷X左;

    	public ShapePart X0Y2_傷X右;

    	public ShapePart X0Y2_傷I左;

    	public ShapePart X0Y2_傷I右;

    	public ShapePart X0Y2_紋柄_紋左_紋1;

    	public ShapePart X0Y2_紋柄_紋左_紋2;

    	public ShapePart X0Y2_紋柄_紋左_紋3;

    	public ShapePart X0Y2_紋柄_紋右_紋1;

    	public ShapePart X0Y2_紋柄_紋右_紋2;

    	public ShapePart X0Y2_紋柄_紋右_紋3;

    	public ShapePart X0Y2_獣性_獣毛左;

    	public ShapePart X0Y2_獣性_獣毛右;

    	public ShapePart X0Y2_虫性_甲殻2;

    	public ShapePart X0Y2_虫性_甲殻1;

    	public ShapePart X0Y2_竜性_左_鱗1;

    	public ShapePart X0Y2_竜性_左_鱗2;

    	public ShapePart X0Y2_竜性_右_鱗1;

    	public ShapePart X0Y2_竜性_右_鱗2;

    	public ShapePart X0Y2_ハイライト上左;

    	public ShapePart X0Y2_ハイライト上右;

    	public ShapePart X0Y2_ハイライト下左;

    	public ShapePart X0Y2_ハイライト下右;

    	public ShapePart X0Y3_Waist;

    	public ShapePart X0Y3_股;

    	public ShapePart X0Y3_下腹;

    	public ShapePart X0Y3_腰皺;

    	public ShapePart X0Y3_筋肉_筋肉下;

    	public ShapePart X0Y3_筋肉_筋肉左;

    	public ShapePart X0Y3_筋肉_筋肉右;

    	public ShapePart X0Y3_筋肉_筋上左;

    	public ShapePart X0Y3_筋肉_筋上右;

    	public ShapePart X0Y3_筋肉_筋下左;

    	public ShapePart X0Y3_筋肉_筋下右;

    	public ShapePart X0Y3_ハイライト;

    	public ShapePart X0Y3_臍;

    	public ShapePart X0Y3_悪タトゥ_渦_タトゥ1左;

    	public ShapePart X0Y3_悪タトゥ_渦_タトゥ1右;

    	public ShapePart X0Y3_悪タトゥ_渦_タトゥ2左;

    	public ShapePart X0Y3_悪タトゥ_渦_タトゥ2右;

    	public ShapePart X0Y3_淫タトゥ_ハート_タトゥ1左;

    	public ShapePart X0Y3_淫タトゥ_ハート_タトゥ1右;

    	public ShapePart X0Y3_淫タトゥ_ハート_タトゥ2左;

    	public ShapePart X0Y3_淫タトゥ_ハート_タトゥ2右;

    	public ShapePart X0Y3_傷X左;

    	public ShapePart X0Y3_傷X右;

    	public ShapePart X0Y3_傷I左;

    	public ShapePart X0Y3_傷I右;

    	public ShapePart X0Y3_紋柄_紋左_紋1;

    	public ShapePart X0Y3_紋柄_紋左_紋2;

    	public ShapePart X0Y3_紋柄_紋左_紋3;

    	public ShapePart X0Y3_紋柄_紋右_紋1;

    	public ShapePart X0Y3_紋柄_紋右_紋2;

    	public ShapePart X0Y3_紋柄_紋右_紋3;

    	public ShapePart X0Y3_獣性_獣毛左;

    	public ShapePart X0Y3_獣性_獣毛右;

    	public ShapePart X0Y3_虫性_甲殻2;

    	public ShapePart X0Y3_虫性_甲殻1;

    	public ShapePart X0Y3_竜性_左_鱗1;

    	public ShapePart X0Y3_竜性_左_鱗2;

    	public ShapePart X0Y3_竜性_右_鱗1;

    	public ShapePart X0Y3_竜性_右_鱗2;

    	public ShapePart X0Y3_ハイライト上左;

    	public ShapePart X0Y3_ハイライト上右;

    	public ShapePart X0Y3_ハイライト下左;

    	public ShapePart X0Y3_ハイライト下右;

    	public ShapePart X0Y4_Waist;

    	public ShapePart X0Y4_股;

    	public ShapePart X0Y4_下腹;

    	public ShapePart X0Y4_腰皺;

    	public ShapePart X0Y4_筋肉_筋肉下;

    	public ShapePart X0Y4_筋肉_筋肉左;

    	public ShapePart X0Y4_筋肉_筋肉右;

    	public ShapePart X0Y4_筋肉_筋上左;

    	public ShapePart X0Y4_筋肉_筋上右;

    	public ShapePart X0Y4_筋肉_筋下左;

    	public ShapePart X0Y4_筋肉_筋下右;

    	public ShapePart X0Y4_ハイライト;

    	public ShapePart X0Y4_臍;

    	public ShapePart X0Y4_悪タトゥ_渦_タトゥ1左;

    	public ShapePart X0Y4_悪タトゥ_渦_タトゥ1右;

    	public ShapePart X0Y4_悪タトゥ_渦_タトゥ2左;

    	public ShapePart X0Y4_悪タトゥ_渦_タトゥ2右;

    	public ShapePart X0Y4_淫タトゥ_ハート_タトゥ1左;

    	public ShapePart X0Y4_淫タトゥ_ハート_タトゥ1右;

    	public ShapePart X0Y4_淫タトゥ_ハート_タトゥ2左;

    	public ShapePart X0Y4_淫タトゥ_ハート_タトゥ2右;

    	public ShapePart X0Y4_傷X左;

    	public ShapePart X0Y4_傷X右;

    	public ShapePart X0Y4_傷I左;

    	public ShapePart X0Y4_傷I右;

    	public ShapePart X0Y4_紋柄_紋左_紋1;

    	public ShapePart X0Y4_紋柄_紋左_紋2;

    	public ShapePart X0Y4_紋柄_紋左_紋3;

    	public ShapePart X0Y4_紋柄_紋右_紋1;

    	public ShapePart X0Y4_紋柄_紋右_紋2;

    	public ShapePart X0Y4_紋柄_紋右_紋3;

    	public ShapePart X0Y4_獣性_獣毛左;

    	public ShapePart X0Y4_獣性_獣毛右;

    	public ShapePart X0Y4_虫性_甲殻2;

    	public ShapePart X0Y4_虫性_甲殻1;

    	public ShapePart X0Y4_竜性_左_鱗1;

    	public ShapePart X0Y4_竜性_左_鱗2;

    	public ShapePart X0Y4_竜性_右_鱗1;

    	public ShapePart X0Y4_竜性_右_鱗2;

    	public ShapePart X0Y4_ハイライト上左;

    	public ShapePart X0Y4_ハイライト上右;

    	public ShapePart X0Y4_ハイライト下左;

    	public ShapePart X0Y4_ハイライト下右;

    	public ColorD WaistCD;

    	public ColorD 股CD;

    	public ColorD 下腹CD;

    	public ColorD 腰皺CD;

    	public ColorD 筋肉_筋肉下CD;

    	public ColorD 筋肉_筋肉左CD;

    	public ColorD 筋肉_筋肉右CD;

    	public ColorD 筋肉_筋上左CD;

    	public ColorD 筋肉_筋上右CD;

    	public ColorD 筋肉_筋下左CD;

    	public ColorD 筋肉_筋下右CD;

    	public ColorD ハイライトCD;

    	public ColorD 臍CD;

    	public ColorD 悪タトゥ_渦_タトゥ1左CD;

    	public ColorD 悪タトゥ_渦_タトゥ1右CD;

    	public ColorD 悪タトゥ_渦_タトゥ2左CD;

    	public ColorD 悪タトゥ_渦_タトゥ2右CD;

    	public ColorD 淫タトゥ_ハート_タトゥ1左CD;

    	public ColorD 淫タトゥ_ハート_タトゥ1右CD;

    	public ColorD 淫タトゥ_ハート_タトゥ2左CD;

    	public ColorD 淫タトゥ_ハート_タトゥ2右CD;

    	public ColorD 傷X左CD;

    	public ColorD 傷X右CD;

    	public ColorD 傷I左CD;

    	public ColorD 傷I右CD;

    	public ColorD 紋柄_紋左_紋1CD;

    	public ColorD 紋柄_紋左_紋2CD;

    	public ColorD 紋柄_紋左_紋3CD;

    	public ColorD 紋柄_紋右_紋1CD;

    	public ColorD 紋柄_紋右_紋2CD;

    	public ColorD 紋柄_紋右_紋3CD;

    	public ColorD 獣性_獣毛左CD;

    	public ColorD 獣性_獣毛右CD;

    	public ColorD 虫性_甲殻2CD;

    	public ColorD 虫性_甲殻1CD;

    	public ColorD 竜性_左_鱗1CD;

    	public ColorD 竜性_左_鱗2CD;

    	public ColorD 竜性_右_鱗1CD;

    	public ColorD 竜性_右_鱗2CD;

    	public ColorD ハイライト上左CD;

    	public ColorD ハイライト上右CD;

    	public ColorD ハイライト下左CD;

    	public ColorD ハイライト下右CD;

    	public ColorP X0Y0_WaistCP;

    	public ColorP X0Y0_股CP;

    	public ColorP X0Y0_下腹CP;

    	public ColorP X0Y0_腰皺CP;

    	public ColorP X0Y0_筋肉_筋肉下CP;

    	public ColorP X0Y0_筋肉_筋肉左CP;

    	public ColorP X0Y0_筋肉_筋肉右CP;

    	public ColorP X0Y0_筋肉_筋上左CP;

    	public ColorP X0Y0_筋肉_筋上右CP;

    	public ColorP X0Y0_筋肉_筋下左CP;

    	public ColorP X0Y0_筋肉_筋下右CP;

    	public ColorP X0Y0_ハイライトCP;

    	public ColorP X0Y0_臍CP;

    	public ColorP X0Y0_悪タトゥ_渦_タトゥ1左CP;

    	public ColorP X0Y0_悪タトゥ_渦_タトゥ1右CP;

    	public ColorP X0Y0_悪タトゥ_渦_タトゥ2左CP;

    	public ColorP X0Y0_悪タトゥ_渦_タトゥ2右CP;

    	public ColorP X0Y0_淫タトゥ_ハート_タトゥ1左CP;

    	public ColorP X0Y0_淫タトゥ_ハート_タトゥ1右CP;

    	public ColorP X0Y0_淫タトゥ_ハート_タトゥ2左CP;

    	public ColorP X0Y0_淫タトゥ_ハート_タトゥ2右CP;

    	public ColorP X0Y0_傷X左CP;

    	public ColorP X0Y0_傷X右CP;

    	public ColorP X0Y0_傷I左CP;

    	public ColorP X0Y0_傷I右CP;

    	public ColorP X0Y0_紋柄_紋左_紋1CP;

    	public ColorP X0Y0_紋柄_紋左_紋2CP;

    	public ColorP X0Y0_紋柄_紋左_紋3CP;

    	public ColorP X0Y0_紋柄_紋右_紋1CP;

    	public ColorP X0Y0_紋柄_紋右_紋2CP;

    	public ColorP X0Y0_紋柄_紋右_紋3CP;

    	public ColorP X0Y0_獣性_獣毛左CP;

    	public ColorP X0Y0_獣性_獣毛右CP;

    	public ColorP X0Y0_虫性_甲殻2CP;

    	public ColorP X0Y0_虫性_甲殻1CP;

    	public ColorP X0Y0_竜性_左_鱗1CP;

    	public ColorP X0Y0_竜性_左_鱗2CP;

    	public ColorP X0Y0_竜性_右_鱗1CP;

    	public ColorP X0Y0_竜性_右_鱗2CP;

    	public ColorP X0Y0_ハイライト上左CP;

    	public ColorP X0Y0_ハイライト上右CP;

    	public ColorP X0Y0_ハイライト下左CP;

    	public ColorP X0Y0_ハイライト下右CP;

    	public ColorP X0Y1_WaistCP;

    	public ColorP X0Y1_股CP;

    	public ColorP X0Y1_下腹CP;

    	public ColorP X0Y1_腰皺CP;

    	public ColorP X0Y1_筋肉_筋肉下CP;

    	public ColorP X0Y1_筋肉_筋肉左CP;

    	public ColorP X0Y1_筋肉_筋肉右CP;

    	public ColorP X0Y1_筋肉_筋上左CP;

    	public ColorP X0Y1_筋肉_筋上右CP;

    	public ColorP X0Y1_筋肉_筋下左CP;

    	public ColorP X0Y1_筋肉_筋下右CP;

    	public ColorP X0Y1_ハイライトCP;

    	public ColorP X0Y1_臍CP;

    	public ColorP X0Y1_悪タトゥ_渦_タトゥ1左CP;

    	public ColorP X0Y1_悪タトゥ_渦_タトゥ1右CP;

    	public ColorP X0Y1_悪タトゥ_渦_タトゥ2左CP;

    	public ColorP X0Y1_悪タトゥ_渦_タトゥ2右CP;

    	public ColorP X0Y1_淫タトゥ_ハート_タトゥ1左CP;

    	public ColorP X0Y1_淫タトゥ_ハート_タトゥ1右CP;

    	public ColorP X0Y1_淫タトゥ_ハート_タトゥ2左CP;

    	public ColorP X0Y1_淫タトゥ_ハート_タトゥ2右CP;

    	public ColorP X0Y1_傷X左CP;

    	public ColorP X0Y1_傷X右CP;

    	public ColorP X0Y1_傷I左CP;

    	public ColorP X0Y1_傷I右CP;

    	public ColorP X0Y1_紋柄_紋左_紋1CP;

    	public ColorP X0Y1_紋柄_紋左_紋2CP;

    	public ColorP X0Y1_紋柄_紋左_紋3CP;

    	public ColorP X0Y1_紋柄_紋右_紋1CP;

    	public ColorP X0Y1_紋柄_紋右_紋2CP;

    	public ColorP X0Y1_紋柄_紋右_紋3CP;

    	public ColorP X0Y1_獣性_獣毛左CP;

    	public ColorP X0Y1_獣性_獣毛右CP;

    	public ColorP X0Y1_虫性_甲殻2CP;

    	public ColorP X0Y1_虫性_甲殻1CP;

    	public ColorP X0Y1_竜性_左_鱗1CP;

    	public ColorP X0Y1_竜性_左_鱗2CP;

    	public ColorP X0Y1_竜性_右_鱗1CP;

    	public ColorP X0Y1_竜性_右_鱗2CP;

    	public ColorP X0Y1_ハイライト上左CP;

    	public ColorP X0Y1_ハイライト上右CP;

    	public ColorP X0Y1_ハイライト下左CP;

    	public ColorP X0Y1_ハイライト下右CP;

    	public ColorP X0Y2_WaistCP;

    	public ColorP X0Y2_股CP;

    	public ColorP X0Y2_下腹CP;

    	public ColorP X0Y2_腰皺CP;

    	public ColorP X0Y2_筋肉_筋肉下CP;

    	public ColorP X0Y2_筋肉_筋肉左CP;

    	public ColorP X0Y2_筋肉_筋肉右CP;

    	public ColorP X0Y2_筋肉_筋上左CP;

    	public ColorP X0Y2_筋肉_筋上右CP;

    	public ColorP X0Y2_筋肉_筋下左CP;

    	public ColorP X0Y2_筋肉_筋下右CP;

    	public ColorP X0Y2_ハイライトCP;

    	public ColorP X0Y2_臍CP;

    	public ColorP X0Y2_悪タトゥ_渦_タトゥ1左CP;

    	public ColorP X0Y2_悪タトゥ_渦_タトゥ1右CP;

    	public ColorP X0Y2_悪タトゥ_渦_タトゥ2左CP;

    	public ColorP X0Y2_悪タトゥ_渦_タトゥ2右CP;

    	public ColorP X0Y2_淫タトゥ_ハート_タトゥ1左CP;

    	public ColorP X0Y2_淫タトゥ_ハート_タトゥ1右CP;

    	public ColorP X0Y2_淫タトゥ_ハート_タトゥ2左CP;

    	public ColorP X0Y2_淫タトゥ_ハート_タトゥ2右CP;

    	public ColorP X0Y2_傷X左CP;

    	public ColorP X0Y2_傷X右CP;

    	public ColorP X0Y2_傷I左CP;

    	public ColorP X0Y2_傷I右CP;

    	public ColorP X0Y2_紋柄_紋左_紋1CP;

    	public ColorP X0Y2_紋柄_紋左_紋2CP;

    	public ColorP X0Y2_紋柄_紋左_紋3CP;

    	public ColorP X0Y2_紋柄_紋右_紋1CP;

    	public ColorP X0Y2_紋柄_紋右_紋2CP;

    	public ColorP X0Y2_紋柄_紋右_紋3CP;

    	public ColorP X0Y2_獣性_獣毛左CP;

    	public ColorP X0Y2_獣性_獣毛右CP;

    	public ColorP X0Y2_虫性_甲殻2CP;

    	public ColorP X0Y2_虫性_甲殻1CP;

    	public ColorP X0Y2_竜性_左_鱗1CP;

    	public ColorP X0Y2_竜性_左_鱗2CP;

    	public ColorP X0Y2_竜性_右_鱗1CP;

    	public ColorP X0Y2_竜性_右_鱗2CP;

    	public ColorP X0Y2_ハイライト上左CP;

    	public ColorP X0Y2_ハイライト上右CP;

    	public ColorP X0Y2_ハイライト下左CP;

    	public ColorP X0Y2_ハイライト下右CP;

    	public ColorP X0Y3_WaistCP;

    	public ColorP X0Y3_股CP;

    	public ColorP X0Y3_下腹CP;

    	public ColorP X0Y3_腰皺CP;

    	public ColorP X0Y3_筋肉_筋肉下CP;

    	public ColorP X0Y3_筋肉_筋肉左CP;

    	public ColorP X0Y3_筋肉_筋肉右CP;

    	public ColorP X0Y3_筋肉_筋上左CP;

    	public ColorP X0Y3_筋肉_筋上右CP;

    	public ColorP X0Y3_筋肉_筋下左CP;

    	public ColorP X0Y3_筋肉_筋下右CP;

    	public ColorP X0Y3_ハイライトCP;

    	public ColorP X0Y3_臍CP;

    	public ColorP X0Y3_悪タトゥ_渦_タトゥ1左CP;

    	public ColorP X0Y3_悪タトゥ_渦_タトゥ1右CP;

    	public ColorP X0Y3_悪タトゥ_渦_タトゥ2左CP;

    	public ColorP X0Y3_悪タトゥ_渦_タトゥ2右CP;

    	public ColorP X0Y3_淫タトゥ_ハート_タトゥ1左CP;

    	public ColorP X0Y3_淫タトゥ_ハート_タトゥ1右CP;

    	public ColorP X0Y3_淫タトゥ_ハート_タトゥ2左CP;

    	public ColorP X0Y3_淫タトゥ_ハート_タトゥ2右CP;

    	public ColorP X0Y3_傷X左CP;

    	public ColorP X0Y3_傷X右CP;

    	public ColorP X0Y3_傷I左CP;

    	public ColorP X0Y3_傷I右CP;

    	public ColorP X0Y3_紋柄_紋左_紋1CP;

    	public ColorP X0Y3_紋柄_紋左_紋2CP;

    	public ColorP X0Y3_紋柄_紋左_紋3CP;

    	public ColorP X0Y3_紋柄_紋右_紋1CP;

    	public ColorP X0Y3_紋柄_紋右_紋2CP;

    	public ColorP X0Y3_紋柄_紋右_紋3CP;

    	public ColorP X0Y3_獣性_獣毛左CP;

    	public ColorP X0Y3_獣性_獣毛右CP;

    	public ColorP X0Y3_虫性_甲殻2CP;

    	public ColorP X0Y3_虫性_甲殻1CP;

    	public ColorP X0Y3_竜性_左_鱗1CP;

    	public ColorP X0Y3_竜性_左_鱗2CP;

    	public ColorP X0Y3_竜性_右_鱗1CP;

    	public ColorP X0Y3_竜性_右_鱗2CP;

    	public ColorP X0Y3_ハイライト上左CP;

    	public ColorP X0Y3_ハイライト上右CP;

    	public ColorP X0Y3_ハイライト下左CP;

    	public ColorP X0Y3_ハイライト下右CP;

    	public ColorP X0Y4_WaistCP;

    	public ColorP X0Y4_股CP;

    	public ColorP X0Y4_下腹CP;

    	public ColorP X0Y4_腰皺CP;

    	public ColorP X0Y4_筋肉_筋肉下CP;

    	public ColorP X0Y4_筋肉_筋肉左CP;

    	public ColorP X0Y4_筋肉_筋肉右CP;

    	public ColorP X0Y4_筋肉_筋上左CP;

    	public ColorP X0Y4_筋肉_筋上右CP;

    	public ColorP X0Y4_筋肉_筋下左CP;

    	public ColorP X0Y4_筋肉_筋下右CP;

    	public ColorP X0Y4_ハイライトCP;

    	public ColorP X0Y4_臍CP;

    	public ColorP X0Y4_悪タトゥ_渦_タトゥ1左CP;

    	public ColorP X0Y4_悪タトゥ_渦_タトゥ1右CP;

    	public ColorP X0Y4_悪タトゥ_渦_タトゥ2左CP;

    	public ColorP X0Y4_悪タトゥ_渦_タトゥ2右CP;

    	public ColorP X0Y4_淫タトゥ_ハート_タトゥ1左CP;

    	public ColorP X0Y4_淫タトゥ_ハート_タトゥ1右CP;

    	public ColorP X0Y4_淫タトゥ_ハート_タトゥ2左CP;

    	public ColorP X0Y4_淫タトゥ_ハート_タトゥ2右CP;

    	public ColorP X0Y4_傷X左CP;

    	public ColorP X0Y4_傷X右CP;

    	public ColorP X0Y4_傷I左CP;

    	public ColorP X0Y4_傷I右CP;

    	public ColorP X0Y4_紋柄_紋左_紋1CP;

    	public ColorP X0Y4_紋柄_紋左_紋2CP;

    	public ColorP X0Y4_紋柄_紋左_紋3CP;

    	public ColorP X0Y4_紋柄_紋右_紋1CP;

    	public ColorP X0Y4_紋柄_紋右_紋2CP;

    	public ColorP X0Y4_紋柄_紋右_紋3CP;

    	public ColorP X0Y4_獣性_獣毛左CP;

    	public ColorP X0Y4_獣性_獣毛右CP;

    	public ColorP X0Y4_虫性_甲殻2CP;

    	public ColorP X0Y4_虫性_甲殻1CP;

    	public ColorP X0Y4_竜性_左_鱗1CP;

    	public ColorP X0Y4_竜性_左_鱗2CP;

    	public ColorP X0Y4_竜性_右_鱗1CP;

    	public ColorP X0Y4_竜性_右_鱗2CP;

    	public ColorP X0Y4_ハイライト上左CP;

    	public ColorP X0Y4_ハイライト上右CP;

    	public ColorP X0Y4_ハイライト下左CP;

    	public ColorP X0Y4_ハイライト下右CP;

    	public スタンプK キスマーク;

    	public スタンプW 鞭痕;

    	public Element[] Torso_接続;

    	public Element[] 腿左_接続;

    	public Element[] 腿右_接続;

    	public Element[] 膣基_接続;

    	public Element[] 肛門_接続;

    	public Element[] 尾_接続;

    	public Element[] 半身_接続;

    	public Element[] 上着_接続;

    	public Element[] 肌_接続;

    	public Element[] 翼左_接続;

    	public Element[] 翼右_接続;

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
    			筋肉_筋肉下_表示 = 筋肉_;
    			筋肉_筋肉左_表示 = 筋肉_;
    			筋肉_筋肉右_表示 = 筋肉_;
    			筋肉_筋上左_表示 = 筋肉_;
    			筋肉_筋上右_表示 = 筋肉_;
    			筋肉_筋下左_表示 = 筋肉_;
    			筋肉_筋下右_表示 = 筋肉_;
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

    	public bool Waist_表示
    	{
    		get
    		{
    			return X0Y0_Waist.Dra;
    		}
    		set
    		{
    			X0Y0_Waist.Dra = value;
    			X0Y1_Waist.Dra = value;
    			X0Y2_Waist.Dra = value;
    			X0Y3_Waist.Dra = value;
    			X0Y4_Waist.Dra = value;
    			X0Y0_Waist.Hit = value;
    			X0Y1_Waist.Hit = value;
    			X0Y2_Waist.Hit = value;
    			X0Y3_Waist.Hit = value;
    			X0Y4_Waist.Hit = value;
    		}
    	}

    	public bool 股_表示
    	{
    		get
    		{
    			return X0Y0_股.Dra;
    		}
    		set
    		{
    			X0Y0_股.Dra = value;
    			X0Y1_股.Dra = value;
    			X0Y2_股.Dra = value;
    			X0Y3_股.Dra = value;
    			X0Y4_股.Dra = value;
    			X0Y0_股.Hit = value;
    			X0Y1_股.Hit = value;
    			X0Y2_股.Hit = value;
    			X0Y3_股.Hit = value;
    			X0Y4_股.Hit = value;
    		}
    	}

    	public bool 下腹_表示
    	{
    		get
    		{
    			return X0Y0_下腹.Dra;
    		}
    		set
    		{
    			X0Y0_下腹.Dra = value;
    			X0Y1_下腹.Dra = value;
    			X0Y2_下腹.Dra = value;
    			X0Y3_下腹.Dra = value;
    			X0Y4_下腹.Dra = value;
    			X0Y0_下腹.Hit = value;
    			X0Y1_下腹.Hit = value;
    			X0Y2_下腹.Hit = value;
    			X0Y3_下腹.Hit = value;
    			X0Y4_下腹.Hit = value;
    		}
    	}

    	public bool 腰皺_表示
    	{
    		get
    		{
    			return X0Y0_腰皺.Dra;
    		}
    		set
    		{
    			X0Y0_腰皺.Dra = value;
    			X0Y1_腰皺.Dra = value;
    			X0Y2_腰皺.Dra = value;
    			X0Y3_腰皺.Dra = value;
    			X0Y4_腰皺.Dra = value;
    			X0Y0_腰皺.Hit = value;
    			X0Y1_腰皺.Hit = value;
    			X0Y2_腰皺.Hit = value;
    			X0Y3_腰皺.Hit = value;
    			X0Y4_腰皺.Hit = value;
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
    			X0Y1_筋肉_筋肉下.Dra = value;
    			X0Y2_筋肉_筋肉下.Dra = value;
    			X0Y3_筋肉_筋肉下.Dra = value;
    			X0Y4_筋肉_筋肉下.Dra = value;
    			X0Y0_筋肉_筋肉下.Hit = value;
    			X0Y1_筋肉_筋肉下.Hit = value;
    			X0Y2_筋肉_筋肉下.Hit = value;
    			X0Y3_筋肉_筋肉下.Hit = value;
    			X0Y4_筋肉_筋肉下.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉左_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉左.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉左.Dra = value;
    			X0Y1_筋肉_筋肉左.Dra = value;
    			X0Y2_筋肉_筋肉左.Dra = value;
    			X0Y3_筋肉_筋肉左.Dra = value;
    			X0Y4_筋肉_筋肉左.Dra = value;
    			X0Y0_筋肉_筋肉左.Hit = value;
    			X0Y1_筋肉_筋肉左.Hit = value;
    			X0Y2_筋肉_筋肉左.Hit = value;
    			X0Y3_筋肉_筋肉左.Hit = value;
    			X0Y4_筋肉_筋肉左.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉右_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉右.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉右.Dra = value;
    			X0Y1_筋肉_筋肉右.Dra = value;
    			X0Y2_筋肉_筋肉右.Dra = value;
    			X0Y3_筋肉_筋肉右.Dra = value;
    			X0Y4_筋肉_筋肉右.Dra = value;
    			X0Y0_筋肉_筋肉右.Hit = value;
    			X0Y1_筋肉_筋肉右.Hit = value;
    			X0Y2_筋肉_筋肉右.Hit = value;
    			X0Y3_筋肉_筋肉右.Hit = value;
    			X0Y4_筋肉_筋肉右.Hit = value;
    		}
    	}

    	public bool 筋肉_筋上左_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋上左.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋上左.Dra = value;
    			X0Y1_筋肉_筋上左.Dra = value;
    			X0Y2_筋肉_筋上左.Dra = value;
    			X0Y3_筋肉_筋上左.Dra = value;
    			X0Y4_筋肉_筋上左.Dra = value;
    			X0Y0_筋肉_筋上左.Hit = value;
    			X0Y1_筋肉_筋上左.Hit = value;
    			X0Y2_筋肉_筋上左.Hit = value;
    			X0Y3_筋肉_筋上左.Hit = value;
    			X0Y4_筋肉_筋上左.Hit = value;
    		}
    	}

    	public bool 筋肉_筋上右_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋上右.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋上右.Dra = value;
    			X0Y1_筋肉_筋上右.Dra = value;
    			X0Y2_筋肉_筋上右.Dra = value;
    			X0Y3_筋肉_筋上右.Dra = value;
    			X0Y4_筋肉_筋上右.Dra = value;
    			X0Y0_筋肉_筋上右.Hit = value;
    			X0Y1_筋肉_筋上右.Hit = value;
    			X0Y2_筋肉_筋上右.Hit = value;
    			X0Y3_筋肉_筋上右.Hit = value;
    			X0Y4_筋肉_筋上右.Hit = value;
    		}
    	}

    	public bool 筋肉_筋下左_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋下左.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋下左.Dra = value;
    			X0Y1_筋肉_筋下左.Dra = value;
    			X0Y2_筋肉_筋下左.Dra = value;
    			X0Y3_筋肉_筋下左.Dra = value;
    			X0Y4_筋肉_筋下左.Dra = value;
    			X0Y0_筋肉_筋下左.Hit = value;
    			X0Y1_筋肉_筋下左.Hit = value;
    			X0Y2_筋肉_筋下左.Hit = value;
    			X0Y3_筋肉_筋下左.Hit = value;
    			X0Y4_筋肉_筋下左.Hit = value;
    		}
    	}

    	public bool 筋肉_筋下右_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋下右.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋下右.Dra = value;
    			X0Y1_筋肉_筋下右.Dra = value;
    			X0Y2_筋肉_筋下右.Dra = value;
    			X0Y3_筋肉_筋下右.Dra = value;
    			X0Y4_筋肉_筋下右.Dra = value;
    			X0Y0_筋肉_筋下右.Hit = value;
    			X0Y1_筋肉_筋下右.Hit = value;
    			X0Y2_筋肉_筋下右.Hit = value;
    			X0Y3_筋肉_筋下右.Hit = value;
    			X0Y4_筋肉_筋下右.Hit = value;
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
    			X0Y1_ハイライト.Dra = value;
    			X0Y2_ハイライト.Dra = value;
    			X0Y3_ハイライト.Dra = value;
    			X0Y4_ハイライト.Dra = value;
    			X0Y0_ハイライト.Hit = value;
    			X0Y1_ハイライト.Hit = value;
    			X0Y2_ハイライト.Hit = value;
    			X0Y3_ハイライト.Hit = value;
    			X0Y4_ハイライト.Hit = value;
    		}
    	}

    	public bool 臍_表示
    	{
    		get
    		{
    			return X0Y0_臍.Dra;
    		}
    		set
    		{
    			X0Y0_臍.Dra = value;
    			X0Y1_臍.Dra = value;
    			X0Y2_臍.Dra = value;
    			X0Y3_臍.Dra = value;
    			X0Y4_臍.Dra = value;
    			X0Y0_臍.Hit = value;
    			X0Y1_臍.Hit = value;
    			X0Y2_臍.Hit = value;
    			X0Y3_臍.Hit = value;
    			X0Y4_臍.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_渦_タトゥ1左_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_渦_タトゥ1左.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_渦_タトゥ1左.Dra = value;
    			X0Y1_悪タトゥ_渦_タトゥ1左.Dra = value;
    			X0Y2_悪タトゥ_渦_タトゥ1左.Dra = value;
    			X0Y3_悪タトゥ_渦_タトゥ1左.Dra = value;
    			X0Y4_悪タトゥ_渦_タトゥ1左.Dra = value;
    			X0Y0_悪タトゥ_渦_タトゥ1左.Hit = value;
    			X0Y1_悪タトゥ_渦_タトゥ1左.Hit = value;
    			X0Y2_悪タトゥ_渦_タトゥ1左.Hit = value;
    			X0Y3_悪タトゥ_渦_タトゥ1左.Hit = value;
    			X0Y4_悪タトゥ_渦_タトゥ1左.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_渦_タトゥ1右_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_渦_タトゥ1右.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_渦_タトゥ1右.Dra = value;
    			X0Y1_悪タトゥ_渦_タトゥ1右.Dra = value;
    			X0Y2_悪タトゥ_渦_タトゥ1右.Dra = value;
    			X0Y3_悪タトゥ_渦_タトゥ1右.Dra = value;
    			X0Y4_悪タトゥ_渦_タトゥ1右.Dra = value;
    			X0Y0_悪タトゥ_渦_タトゥ1右.Hit = value;
    			X0Y1_悪タトゥ_渦_タトゥ1右.Hit = value;
    			X0Y2_悪タトゥ_渦_タトゥ1右.Hit = value;
    			X0Y3_悪タトゥ_渦_タトゥ1右.Hit = value;
    			X0Y4_悪タトゥ_渦_タトゥ1右.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_渦_タトゥ2左_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_渦_タトゥ2左.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_渦_タトゥ2左.Dra = value;
    			X0Y1_悪タトゥ_渦_タトゥ2左.Dra = value;
    			X0Y2_悪タトゥ_渦_タトゥ2左.Dra = value;
    			X0Y3_悪タトゥ_渦_タトゥ2左.Dra = value;
    			X0Y4_悪タトゥ_渦_タトゥ2左.Dra = value;
    			X0Y0_悪タトゥ_渦_タトゥ2左.Hit = value;
    			X0Y1_悪タトゥ_渦_タトゥ2左.Hit = value;
    			X0Y2_悪タトゥ_渦_タトゥ2左.Hit = value;
    			X0Y3_悪タトゥ_渦_タトゥ2左.Hit = value;
    			X0Y4_悪タトゥ_渦_タトゥ2左.Hit = value;
    		}
    	}

    	public bool 悪タトゥ_渦_タトゥ2右_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ_渦_タトゥ2右.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ_渦_タトゥ2右.Dra = value;
    			X0Y1_悪タトゥ_渦_タトゥ2右.Dra = value;
    			X0Y2_悪タトゥ_渦_タトゥ2右.Dra = value;
    			X0Y3_悪タトゥ_渦_タトゥ2右.Dra = value;
    			X0Y4_悪タトゥ_渦_タトゥ2右.Dra = value;
    			X0Y0_悪タトゥ_渦_タトゥ2右.Hit = value;
    			X0Y1_悪タトゥ_渦_タトゥ2右.Hit = value;
    			X0Y2_悪タトゥ_渦_タトゥ2右.Hit = value;
    			X0Y3_悪タトゥ_渦_タトゥ2右.Hit = value;
    			X0Y4_悪タトゥ_渦_タトゥ2右.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_ハート_タトゥ1左_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_ハート_タトゥ1左.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_ハート_タトゥ1左.Dra = value;
    			X0Y1_淫タトゥ_ハート_タトゥ1左.Dra = value;
    			X0Y2_淫タトゥ_ハート_タトゥ1左.Dra = value;
    			X0Y3_淫タトゥ_ハート_タトゥ1左.Dra = value;
    			X0Y4_淫タトゥ_ハート_タトゥ1左.Dra = value;
    			X0Y0_淫タトゥ_ハート_タトゥ1左.Hit = value;
    			X0Y1_淫タトゥ_ハート_タトゥ1左.Hit = value;
    			X0Y2_淫タトゥ_ハート_タトゥ1左.Hit = value;
    			X0Y3_淫タトゥ_ハート_タトゥ1左.Hit = value;
    			X0Y4_淫タトゥ_ハート_タトゥ1左.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_ハート_タトゥ1右_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_ハート_タトゥ1右.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_ハート_タトゥ1右.Dra = value;
    			X0Y1_淫タトゥ_ハート_タトゥ1右.Dra = value;
    			X0Y2_淫タトゥ_ハート_タトゥ1右.Dra = value;
    			X0Y3_淫タトゥ_ハート_タトゥ1右.Dra = value;
    			X0Y4_淫タトゥ_ハート_タトゥ1右.Dra = value;
    			X0Y0_淫タトゥ_ハート_タトゥ1右.Hit = value;
    			X0Y1_淫タトゥ_ハート_タトゥ1右.Hit = value;
    			X0Y2_淫タトゥ_ハート_タトゥ1右.Hit = value;
    			X0Y3_淫タトゥ_ハート_タトゥ1右.Hit = value;
    			X0Y4_淫タトゥ_ハート_タトゥ1右.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_ハート_タトゥ2左_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_ハート_タトゥ2左.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_ハート_タトゥ2左.Dra = value;
    			X0Y1_淫タトゥ_ハート_タトゥ2左.Dra = value;
    			X0Y2_淫タトゥ_ハート_タトゥ2左.Dra = value;
    			X0Y3_淫タトゥ_ハート_タトゥ2左.Dra = value;
    			X0Y4_淫タトゥ_ハート_タトゥ2左.Dra = value;
    			X0Y0_淫タトゥ_ハート_タトゥ2左.Hit = value;
    			X0Y1_淫タトゥ_ハート_タトゥ2左.Hit = value;
    			X0Y2_淫タトゥ_ハート_タトゥ2左.Hit = value;
    			X0Y3_淫タトゥ_ハート_タトゥ2左.Hit = value;
    			X0Y4_淫タトゥ_ハート_タトゥ2左.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_ハート_タトゥ2右_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_ハート_タトゥ2右.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_ハート_タトゥ2右.Dra = value;
    			X0Y1_淫タトゥ_ハート_タトゥ2右.Dra = value;
    			X0Y2_淫タトゥ_ハート_タトゥ2右.Dra = value;
    			X0Y3_淫タトゥ_ハート_タトゥ2右.Dra = value;
    			X0Y4_淫タトゥ_ハート_タトゥ2右.Dra = value;
    			X0Y0_淫タトゥ_ハート_タトゥ2右.Hit = value;
    			X0Y1_淫タトゥ_ハート_タトゥ2右.Hit = value;
    			X0Y2_淫タトゥ_ハート_タトゥ2右.Hit = value;
    			X0Y3_淫タトゥ_ハート_タトゥ2右.Hit = value;
    			X0Y4_淫タトゥ_ハート_タトゥ2右.Hit = value;
    		}
    	}

    	public bool 傷X左_表示
    	{
    		get
    		{
    			return X0Y0_傷X左.Dra;
    		}
    		set
    		{
    			X0Y0_傷X左.Dra = value;
    			X0Y1_傷X左.Dra = value;
    			X0Y2_傷X左.Dra = value;
    			X0Y3_傷X左.Dra = value;
    			X0Y4_傷X左.Dra = value;
    			X0Y0_傷X左.Hit = value;
    			X0Y1_傷X左.Hit = value;
    			X0Y2_傷X左.Hit = value;
    			X0Y3_傷X左.Hit = value;
    			X0Y4_傷X左.Hit = value;
    		}
    	}

    	public bool 傷X右_表示
    	{
    		get
    		{
    			return X0Y0_傷X右.Dra;
    		}
    		set
    		{
    			X0Y0_傷X右.Dra = value;
    			X0Y1_傷X右.Dra = value;
    			X0Y2_傷X右.Dra = value;
    			X0Y3_傷X右.Dra = value;
    			X0Y4_傷X右.Dra = value;
    			X0Y0_傷X右.Hit = value;
    			X0Y1_傷X右.Hit = value;
    			X0Y2_傷X右.Hit = value;
    			X0Y3_傷X右.Hit = value;
    			X0Y4_傷X右.Hit = value;
    		}
    	}

    	public bool 傷I左_表示
    	{
    		get
    		{
    			return X0Y0_傷I左.Dra;
    		}
    		set
    		{
    			X0Y0_傷I左.Dra = value;
    			X0Y1_傷I左.Dra = value;
    			X0Y2_傷I左.Dra = value;
    			X0Y3_傷I左.Dra = value;
    			X0Y4_傷I左.Dra = value;
    			X0Y0_傷I左.Hit = value;
    			X0Y1_傷I左.Hit = value;
    			X0Y2_傷I左.Hit = value;
    			X0Y3_傷I左.Hit = value;
    			X0Y4_傷I左.Hit = value;
    		}
    	}

    	public bool 傷I右_表示
    	{
    		get
    		{
    			return X0Y0_傷I右.Dra;
    		}
    		set
    		{
    			X0Y0_傷I右.Dra = value;
    			X0Y1_傷I右.Dra = value;
    			X0Y2_傷I右.Dra = value;
    			X0Y3_傷I右.Dra = value;
    			X0Y4_傷I右.Dra = value;
    			X0Y0_傷I右.Hit = value;
    			X0Y1_傷I右.Hit = value;
    			X0Y2_傷I右.Hit = value;
    			X0Y3_傷I右.Hit = value;
    			X0Y4_傷I右.Hit = value;
    		}
    	}

    	public bool 紋柄_紋左_紋1_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋左_紋1.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋左_紋1.Dra = value;
    			X0Y1_紋柄_紋左_紋1.Dra = value;
    			X0Y2_紋柄_紋左_紋1.Dra = value;
    			X0Y3_紋柄_紋左_紋1.Dra = value;
    			X0Y4_紋柄_紋左_紋1.Dra = value;
    			X0Y0_紋柄_紋左_紋1.Hit = value;
    			X0Y1_紋柄_紋左_紋1.Hit = value;
    			X0Y2_紋柄_紋左_紋1.Hit = value;
    			X0Y3_紋柄_紋左_紋1.Hit = value;
    			X0Y4_紋柄_紋左_紋1.Hit = value;
    		}
    	}

    	public bool 紋柄_紋左_紋2_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋左_紋2.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋左_紋2.Dra = value;
    			X0Y1_紋柄_紋左_紋2.Dra = value;
    			X0Y2_紋柄_紋左_紋2.Dra = value;
    			X0Y3_紋柄_紋左_紋2.Dra = value;
    			X0Y4_紋柄_紋左_紋2.Dra = value;
    			X0Y0_紋柄_紋左_紋2.Hit = value;
    			X0Y1_紋柄_紋左_紋2.Hit = value;
    			X0Y2_紋柄_紋左_紋2.Hit = value;
    			X0Y3_紋柄_紋左_紋2.Hit = value;
    			X0Y4_紋柄_紋左_紋2.Hit = value;
    		}
    	}

    	public bool 紋柄_紋左_紋3_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋左_紋3.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋左_紋3.Dra = value;
    			X0Y1_紋柄_紋左_紋3.Dra = value;
    			X0Y2_紋柄_紋左_紋3.Dra = value;
    			X0Y3_紋柄_紋左_紋3.Dra = value;
    			X0Y4_紋柄_紋左_紋3.Dra = value;
    			X0Y0_紋柄_紋左_紋3.Hit = value;
    			X0Y1_紋柄_紋左_紋3.Hit = value;
    			X0Y2_紋柄_紋左_紋3.Hit = value;
    			X0Y3_紋柄_紋左_紋3.Hit = value;
    			X0Y4_紋柄_紋左_紋3.Hit = value;
    		}
    	}

    	public bool 紋柄_紋右_紋1_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋右_紋1.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋右_紋1.Dra = value;
    			X0Y1_紋柄_紋右_紋1.Dra = value;
    			X0Y2_紋柄_紋右_紋1.Dra = value;
    			X0Y3_紋柄_紋右_紋1.Dra = value;
    			X0Y4_紋柄_紋右_紋1.Dra = value;
    			X0Y0_紋柄_紋右_紋1.Hit = value;
    			X0Y1_紋柄_紋右_紋1.Hit = value;
    			X0Y2_紋柄_紋右_紋1.Hit = value;
    			X0Y3_紋柄_紋右_紋1.Hit = value;
    			X0Y4_紋柄_紋右_紋1.Hit = value;
    		}
    	}

    	public bool 紋柄_紋右_紋2_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋右_紋2.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋右_紋2.Dra = value;
    			X0Y1_紋柄_紋右_紋2.Dra = value;
    			X0Y2_紋柄_紋右_紋2.Dra = value;
    			X0Y3_紋柄_紋右_紋2.Dra = value;
    			X0Y4_紋柄_紋右_紋2.Dra = value;
    			X0Y0_紋柄_紋右_紋2.Hit = value;
    			X0Y1_紋柄_紋右_紋2.Hit = value;
    			X0Y2_紋柄_紋右_紋2.Hit = value;
    			X0Y3_紋柄_紋右_紋2.Hit = value;
    			X0Y4_紋柄_紋右_紋2.Hit = value;
    		}
    	}

    	public bool 紋柄_紋右_紋3_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋右_紋3.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋右_紋3.Dra = value;
    			X0Y1_紋柄_紋右_紋3.Dra = value;
    			X0Y2_紋柄_紋右_紋3.Dra = value;
    			X0Y3_紋柄_紋右_紋3.Dra = value;
    			X0Y4_紋柄_紋右_紋3.Dra = value;
    			X0Y0_紋柄_紋右_紋3.Hit = value;
    			X0Y1_紋柄_紋右_紋3.Hit = value;
    			X0Y2_紋柄_紋右_紋3.Hit = value;
    			X0Y3_紋柄_紋右_紋3.Hit = value;
    			X0Y4_紋柄_紋右_紋3.Hit = value;
    		}
    	}

    	public bool 獣性_獣毛左_表示
    	{
    		get
    		{
    			return X0Y0_獣性_獣毛左.Dra;
    		}
    		set
    		{
    			X0Y0_獣性_獣毛左.Dra = value;
    			X0Y1_獣性_獣毛左.Dra = value;
    			X0Y2_獣性_獣毛左.Dra = value;
    			X0Y3_獣性_獣毛左.Dra = value;
    			X0Y4_獣性_獣毛左.Dra = value;
    			X0Y0_獣性_獣毛左.Hit = value;
    			X0Y1_獣性_獣毛左.Hit = value;
    			X0Y2_獣性_獣毛左.Hit = value;
    			X0Y3_獣性_獣毛左.Hit = value;
    			X0Y4_獣性_獣毛左.Hit = value;
    		}
    	}

    	public bool 獣性_獣毛右_表示
    	{
    		get
    		{
    			return X0Y0_獣性_獣毛右.Dra;
    		}
    		set
    		{
    			X0Y0_獣性_獣毛右.Dra = value;
    			X0Y1_獣性_獣毛右.Dra = value;
    			X0Y2_獣性_獣毛右.Dra = value;
    			X0Y3_獣性_獣毛右.Dra = value;
    			X0Y4_獣性_獣毛右.Dra = value;
    			X0Y0_獣性_獣毛右.Hit = value;
    			X0Y1_獣性_獣毛右.Hit = value;
    			X0Y2_獣性_獣毛右.Hit = value;
    			X0Y3_獣性_獣毛右.Hit = value;
    			X0Y4_獣性_獣毛右.Hit = value;
    		}
    	}

    	public bool 虫性_甲殻2_表示
    	{
    		get
    		{
    			return X0Y0_虫性_甲殻2.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_甲殻2.Dra = value;
    			X0Y1_虫性_甲殻2.Dra = value;
    			X0Y2_虫性_甲殻2.Dra = value;
    			X0Y3_虫性_甲殻2.Dra = value;
    			X0Y4_虫性_甲殻2.Dra = value;
    			X0Y0_虫性_甲殻2.Hit = value;
    			X0Y1_虫性_甲殻2.Hit = value;
    			X0Y2_虫性_甲殻2.Hit = value;
    			X0Y3_虫性_甲殻2.Hit = value;
    			X0Y4_虫性_甲殻2.Hit = value;
    		}
    	}

    	public bool 虫性_甲殻1_表示
    	{
    		get
    		{
    			return X0Y0_虫性_甲殻1.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_甲殻1.Dra = value;
    			X0Y1_虫性_甲殻1.Dra = value;
    			X0Y2_虫性_甲殻1.Dra = value;
    			X0Y3_虫性_甲殻1.Dra = value;
    			X0Y4_虫性_甲殻1.Dra = value;
    			X0Y0_虫性_甲殻1.Hit = value;
    			X0Y1_虫性_甲殻1.Hit = value;
    			X0Y2_虫性_甲殻1.Hit = value;
    			X0Y3_虫性_甲殻1.Hit = value;
    			X0Y4_虫性_甲殻1.Hit = value;
    		}
    	}

    	public bool 竜性_左_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性_左_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_左_鱗1.Dra = value;
    			X0Y1_竜性_左_鱗1.Dra = value;
    			X0Y2_竜性_左_鱗1.Dra = value;
    			X0Y3_竜性_左_鱗1.Dra = value;
    			X0Y4_竜性_左_鱗1.Dra = value;
    			X0Y0_竜性_左_鱗1.Hit = value;
    			X0Y1_竜性_左_鱗1.Hit = value;
    			X0Y2_竜性_左_鱗1.Hit = value;
    			X0Y3_竜性_左_鱗1.Hit = value;
    			X0Y4_竜性_左_鱗1.Hit = value;
    		}
    	}

    	public bool 竜性_左_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性_左_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_左_鱗2.Dra = value;
    			X0Y1_竜性_左_鱗2.Dra = value;
    			X0Y2_竜性_左_鱗2.Dra = value;
    			X0Y3_竜性_左_鱗2.Dra = value;
    			X0Y4_竜性_左_鱗2.Dra = value;
    			X0Y0_竜性_左_鱗2.Hit = value;
    			X0Y1_竜性_左_鱗2.Hit = value;
    			X0Y2_竜性_左_鱗2.Hit = value;
    			X0Y3_竜性_左_鱗2.Hit = value;
    			X0Y4_竜性_左_鱗2.Hit = value;
    		}
    	}

    	public bool 竜性_右_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性_右_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_右_鱗1.Dra = value;
    			X0Y1_竜性_右_鱗1.Dra = value;
    			X0Y2_竜性_右_鱗1.Dra = value;
    			X0Y3_竜性_右_鱗1.Dra = value;
    			X0Y4_竜性_右_鱗1.Dra = value;
    			X0Y0_竜性_右_鱗1.Hit = value;
    			X0Y1_竜性_右_鱗1.Hit = value;
    			X0Y2_竜性_右_鱗1.Hit = value;
    			X0Y3_竜性_右_鱗1.Hit = value;
    			X0Y4_竜性_右_鱗1.Hit = value;
    		}
    	}

    	public bool 竜性_右_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性_右_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_右_鱗2.Dra = value;
    			X0Y1_竜性_右_鱗2.Dra = value;
    			X0Y2_竜性_右_鱗2.Dra = value;
    			X0Y3_竜性_右_鱗2.Dra = value;
    			X0Y4_竜性_右_鱗2.Dra = value;
    			X0Y0_竜性_右_鱗2.Hit = value;
    			X0Y1_竜性_右_鱗2.Hit = value;
    			X0Y2_竜性_右_鱗2.Hit = value;
    			X0Y3_竜性_右_鱗2.Hit = value;
    			X0Y4_竜性_右_鱗2.Hit = value;
    		}
    	}

    	public bool ハイライト上左_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト上左.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト上左.Dra = value;
    			X0Y1_ハイライト上左.Dra = value;
    			X0Y2_ハイライト上左.Dra = value;
    			X0Y3_ハイライト上左.Dra = value;
    			X0Y4_ハイライト上左.Dra = value;
    			X0Y0_ハイライト上左.Hit = value;
    			X0Y1_ハイライト上左.Hit = value;
    			X0Y2_ハイライト上左.Hit = value;
    			X0Y3_ハイライト上左.Hit = value;
    			X0Y4_ハイライト上左.Hit = value;
    		}
    	}

    	public bool ハイライト上右_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト上右.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト上右.Dra = value;
    			X0Y1_ハイライト上右.Dra = value;
    			X0Y2_ハイライト上右.Dra = value;
    			X0Y3_ハイライト上右.Dra = value;
    			X0Y4_ハイライト上右.Dra = value;
    			X0Y0_ハイライト上右.Hit = value;
    			X0Y1_ハイライト上右.Hit = value;
    			X0Y2_ハイライト上右.Hit = value;
    			X0Y3_ハイライト上右.Hit = value;
    			X0Y4_ハイライト上右.Hit = value;
    		}
    	}

    	public bool ハイライト下左_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト下左.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト下左.Dra = value;
    			X0Y1_ハイライト下左.Dra = value;
    			X0Y2_ハイライト下左.Dra = value;
    			X0Y3_ハイライト下左.Dra = value;
    			X0Y4_ハイライト下左.Dra = value;
    			X0Y0_ハイライト下左.Hit = value;
    			X0Y1_ハイライト下左.Hit = value;
    			X0Y2_ハイライト下左.Hit = value;
    			X0Y3_ハイライト下左.Hit = value;
    			X0Y4_ハイライト下左.Hit = value;
    		}
    	}

    	public bool ハイライト下右_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト下右.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト下右.Dra = value;
    			X0Y1_ハイライト下右.Dra = value;
    			X0Y2_ハイライト下右.Dra = value;
    			X0Y3_ハイライト下右.Dra = value;
    			X0Y4_ハイライト下右.Dra = value;
    			X0Y0_ハイライト下右.Hit = value;
    			X0Y1_ハイライト下右.Hit = value;
    			X0Y2_ハイライト下右.Hit = value;
    			X0Y3_ハイライト下右.Hit = value;
    			X0Y4_ハイライト下右.Hit = value;
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
    			ハイライト上左_表示 = value;
    			ハイライト上右_表示 = value;
    			ハイライト下左_表示 = value;
    			ハイライト下右_表示 = value;
    		}
    	}

    	public double 筋肉濃度
    	{
    		get
    		{
    			return 筋肉_筋肉下CD.不透明度;
    		}
    		set
    		{
    			筋肉_筋肉下CD.不透明度 = value;
    			筋肉_筋肉左CD.不透明度 = value;
    			筋肉_筋肉右CD.不透明度 = value;
    			筋肉_筋上左CD.不透明度 = value;
    			筋肉_筋上右CD.不透明度 = value;
    			筋肉_筋下左CD.不透明度 = value;
    			筋肉_筋下右CD.不透明度 = value;
    		}
    	}

    	public double 傷X左濃度
    	{
    		get
    		{
    			return 傷X左CD.不透明度;
    		}
    		set
    		{
    			傷X左CD.不透明度 = value;
    		}
    	}

    	public double 傷X右濃度
    	{
    		get
    		{
    			return 傷X右CD.不透明度;
    		}
    		set
    		{
    			傷X右CD.不透明度 = value;
    		}
    	}

    	public double 傷I左濃度
    	{
    		get
    		{
    			return 傷I左CD.不透明度;
    		}
    		set
    		{
    			傷I左CD.不透明度 = value;
    		}
    	}

    	public double 傷I右濃度
    	{
    		get
    		{
    			return 傷I右CD.不透明度;
    		}
    		set
    		{
    			傷I右CD.不透明度 = value;
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
    			ハイライト上左CD.不透明度 = value;
    			ハイライト上右CD.不透明度 = value;
    			ハイライト下左CD.不透明度 = value;
    			ハイライト下右CD.不透明度 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return Waist_表示;
    		}
    		set
    		{
    			Waist_表示 = value;
    			股_表示 = value;
    			下腹_表示 = value;
    			腰皺_表示 = value;
    			筋肉_筋肉下_表示 = value;
    			筋肉_筋肉左_表示 = value;
    			筋肉_筋肉右_表示 = value;
    			筋肉_筋上左_表示 = value;
    			筋肉_筋上右_表示 = value;
    			筋肉_筋下左_表示 = value;
    			筋肉_筋下右_表示 = value;
    			ハイライト_表示 = value;
    			臍_表示 = value;
    			悪タトゥ_渦_タトゥ1左_表示 = value;
    			悪タトゥ_渦_タトゥ1右_表示 = value;
    			悪タトゥ_渦_タトゥ2左_表示 = value;
    			悪タトゥ_渦_タトゥ2右_表示 = value;
    			淫タトゥ_ハート_タトゥ1左_表示 = value;
    			淫タトゥ_ハート_タトゥ1右_表示 = value;
    			淫タトゥ_ハート_タトゥ2左_表示 = value;
    			淫タトゥ_ハート_タトゥ2右_表示 = value;
    			傷X左_表示 = value;
    			傷X右_表示 = value;
    			傷I左_表示 = value;
    			傷I右_表示 = value;
    			紋柄_紋左_紋1_表示 = value;
    			紋柄_紋左_紋2_表示 = value;
    			紋柄_紋左_紋3_表示 = value;
    			紋柄_紋右_紋1_表示 = value;
    			紋柄_紋右_紋2_表示 = value;
    			紋柄_紋右_紋3_表示 = value;
    			獣性_獣毛左_表示 = value;
    			獣性_獣毛右_表示 = value;
    			虫性_甲殻2_表示 = value;
    			虫性_甲殻1_表示 = value;
    			竜性_左_鱗1_表示 = value;
    			竜性_左_鱗2_表示 = value;
    			竜性_右_鱗1_表示 = value;
    			竜性_右_鱗2_表示 = value;
    			ハイライト上左_表示 = value;
    			ハイライト上右_表示 = value;
    			ハイライト下左_表示 = value;
    			ハイライト下右_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return WaistCD.不透明度;
    		}
    		set
    		{
    			WaistCD.不透明度 = value;
    			股CD.不透明度 = value;
    			下腹CD.不透明度 = value;
    			腰皺CD.不透明度 = value;
    			筋肉_筋肉下CD.不透明度 = value;
    			筋肉_筋肉左CD.不透明度 = value;
    			筋肉_筋肉右CD.不透明度 = value;
    			筋肉_筋上左CD.不透明度 = value;
    			筋肉_筋上右CD.不透明度 = value;
    			筋肉_筋下左CD.不透明度 = value;
    			筋肉_筋下右CD.不透明度 = value;
    			ハイライトCD.不透明度 = value;
    			臍CD.不透明度 = value;
    			悪タトゥ_渦_タトゥ1左CD.不透明度 = value;
    			悪タトゥ_渦_タトゥ1右CD.不透明度 = value;
    			悪タトゥ_渦_タトゥ2左CD.不透明度 = value;
    			悪タトゥ_渦_タトゥ2右CD.不透明度 = value;
    			淫タトゥ_ハート_タトゥ1左CD.不透明度 = value;
    			淫タトゥ_ハート_タトゥ1右CD.不透明度 = value;
    			淫タトゥ_ハート_タトゥ2左CD.不透明度 = value;
    			淫タトゥ_ハート_タトゥ2右CD.不透明度 = value;
    			傷X左CD.不透明度 = value;
    			傷X右CD.不透明度 = value;
    			傷I左CD.不透明度 = value;
    			傷I右CD.不透明度 = value;
    			紋柄_紋左_紋1CD.不透明度 = value;
    			紋柄_紋左_紋2CD.不透明度 = value;
    			紋柄_紋左_紋3CD.不透明度 = value;
    			紋柄_紋右_紋1CD.不透明度 = value;
    			紋柄_紋右_紋2CD.不透明度 = value;
    			紋柄_紋右_紋3CD.不透明度 = value;
    			獣性_獣毛左CD.不透明度 = value;
    			獣性_獣毛右CD.不透明度 = value;
    			虫性_甲殻2CD.不透明度 = value;
    			虫性_甲殻1CD.不透明度 = value;
    			竜性_左_鱗1CD.不透明度 = value;
    			竜性_左_鱗2CD.不透明度 = value;
    			竜性_右_鱗1CD.不透明度 = value;
    			竜性_右_鱗2CD.不透明度 = value;
    			ハイライト上左CD.不透明度 = value;
    			ハイライト上右CD.不透明度 = value;
    			ハイライト下左CD.不透明度 = value;
    			ハイライト下右CD.不透明度 = value;
    		}
    	}

    	public JointS Torso_接続点 => new JointS(Body, X0Y0_Waist, 0);

    	public JointS 腿左_接続点 => new JointS(Body, X0Y0_Waist, 1);

    	public JointS 腿右_接続点 => new JointS(Body, X0Y0_Waist, 2);

    	public JointS 膣基_接続点 => new JointS(Body, X0Y0_Waist, 4);

    	public JointS 肛門_接続点 => new JointS(Body, X0Y0_Waist, 5);

    	public JointS 尾_接続点 => new JointS(Body, X0Y0_Waist, 5);

    	public JointS 半身_接続点 => new JointS(Body, X0Y0_Waist, 5);

    	public JointS 上着_接続点 => new JointS(Body, X0Y0_Waist, 6);

    	public JointS 肌_接続点 => new JointS(Body, X0Y0_Waist, 7);

    	public JointS 翼左_接続点 => new JointS(Body, X0Y0_Waist, 8);

    	public JointS 翼右_接続点 => new JointS(Body, X0Y0_Waist, 9);

    	public Waist(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, WaistD e)
    	{
    		Waist Waist2 = this;
    		ThisType = GetType();
    		Body = new VariantGrid(GlobalState.胴体["Waist"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_Waist = partGroup["腰"].ToPar();
    		X0Y0_股 = partGroup["股"].ToPar();
    		X0Y0_下腹 = partGroup["下腹"].ToPar();
    		X0Y0_腰皺 = partGroup["腰皺"].ToPar();
    		PartGroup pars2 = partGroup["筋肉"].ToPars();
    		X0Y0_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
    		X0Y0_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
    		X0Y0_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
    		X0Y0_筋肉_筋上左 = pars2["筋上左"].ToPar();
    		X0Y0_筋肉_筋上右 = pars2["筋上右"].ToPar();
    		X0Y0_筋肉_筋下左 = pars2["筋下左"].ToPar();
    		X0Y0_筋肉_筋下右 = pars2["筋下右"].ToPar();
    		X0Y0_ハイライト = partGroup["ハイライト"].ToPar();
    		X0Y0_臍 = partGroup["臍"].ToPar();
    		pars2 = partGroup["淫タトゥ"].ToPars();
    		PartGroup pars3 = pars2["渦"].ToPars();
    		X0Y0_悪タトゥ_渦_タトゥ1左 = pars3["タトゥ1左"].ToPar();
    		X0Y0_悪タトゥ_渦_タトゥ1右 = pars3["タトゥ1右"].ToPar();
    		X0Y0_悪タトゥ_渦_タトゥ2左 = pars3["タトゥ2左"].ToPar();
    		X0Y0_悪タトゥ_渦_タトゥ2右 = pars3["タトゥ2右"].ToPar();
    		pars3 = pars2["ハート"].ToPars();
    		X0Y0_淫タトゥ_ハート_タトゥ1左 = pars3["タトゥ1左"].ToPar();
    		X0Y0_淫タトゥ_ハート_タトゥ1右 = pars3["タトゥ1右"].ToPar();
    		X0Y0_淫タトゥ_ハート_タトゥ2左 = pars3["タトゥ2左"].ToPar();
    		X0Y0_淫タトゥ_ハート_タトゥ2右 = pars3["タトゥ2右"].ToPar();
    		X0Y0_傷X左 = partGroup["傷X左"].ToPar();
    		X0Y0_傷X右 = partGroup["傷X右"].ToPar();
    		X0Y0_傷I左 = partGroup["傷I左"].ToPar();
    		X0Y0_傷I右 = partGroup["傷I右"].ToPar();
    		pars2 = partGroup["紋柄"].ToPars();
    		pars3 = pars2["紋左"].ToPars();
    		X0Y0_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
    		X0Y0_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
    		X0Y0_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
    		pars3 = pars2["紋右"].ToPars();
    		X0Y0_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
    		X0Y0_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
    		X0Y0_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
    		pars2 = partGroup["獣性"].ToPars();
    		X0Y0_獣性_獣毛左 = pars2["獣毛左"].ToPar();
    		X0Y0_獣性_獣毛右 = pars2["獣毛右"].ToPar();
    		pars2 = partGroup["虫性"].ToPars();
    		X0Y0_虫性_甲殻2 = pars2["甲殻2"].ToPar();
    		X0Y0_虫性_甲殻1 = pars2["甲殻1"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		pars3 = pars2["左"].ToPars();
    		X0Y0_竜性_左_鱗1 = pars3["鱗1"].ToPar();
    		X0Y0_竜性_左_鱗2 = pars3["鱗2"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y0_竜性_右_鱗1 = pars3["鱗1"].ToPar();
    		X0Y0_竜性_右_鱗2 = pars3["鱗2"].ToPar();
    		X0Y0_ハイライト上左 = partGroup["ハイライト上左"].ToPar();
    		X0Y0_ハイライト上右 = partGroup["ハイライト上右"].ToPar();
    		X0Y0_ハイライト下左 = partGroup["ハイライト下左"].ToPar();
    		X0Y0_ハイライト下右 = partGroup["ハイライト下右"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_Waist = partGroup["腰"].ToPar();
    		X0Y1_股 = partGroup["股"].ToPar();
    		X0Y1_下腹 = partGroup["下腹"].ToPar();
    		X0Y1_腰皺 = partGroup["腰皺"].ToPar();
    		pars2 = partGroup["筋肉"].ToPars();
    		X0Y1_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
    		X0Y1_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
    		X0Y1_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
    		X0Y1_筋肉_筋上左 = pars2["筋上左"].ToPar();
    		X0Y1_筋肉_筋上右 = pars2["筋上右"].ToPar();
    		X0Y1_筋肉_筋下左 = pars2["筋下左"].ToPar();
    		X0Y1_筋肉_筋下右 = pars2["筋下右"].ToPar();
    		X0Y1_ハイライト = partGroup["ハイライト"].ToPar();
    		X0Y1_臍 = partGroup["臍"].ToPar();
    		pars2 = partGroup["淫タトゥ"].ToPars();
    		pars3 = pars2["渦"].ToPars();
    		X0Y1_悪タトゥ_渦_タトゥ1左 = pars3["タトゥ1左"].ToPar();
    		X0Y1_悪タトゥ_渦_タトゥ1右 = pars3["タトゥ1右"].ToPar();
    		X0Y1_悪タトゥ_渦_タトゥ2左 = pars3["タトゥ2左"].ToPar();
    		X0Y1_悪タトゥ_渦_タトゥ2右 = pars3["タトゥ2右"].ToPar();
    		pars3 = pars2["ハート"].ToPars();
    		X0Y1_淫タトゥ_ハート_タトゥ1左 = pars3["タトゥ1左"].ToPar();
    		X0Y1_淫タトゥ_ハート_タトゥ1右 = pars3["タトゥ1右"].ToPar();
    		X0Y1_淫タトゥ_ハート_タトゥ2左 = pars3["タトゥ2左"].ToPar();
    		X0Y1_淫タトゥ_ハート_タトゥ2右 = pars3["タトゥ2右"].ToPar();
    		X0Y1_傷X左 = partGroup["傷X左"].ToPar();
    		X0Y1_傷X右 = partGroup["傷X右"].ToPar();
    		X0Y1_傷I左 = partGroup["傷I左"].ToPar();
    		X0Y1_傷I右 = partGroup["傷I右"].ToPar();
    		pars2 = partGroup["紋柄"].ToPars();
    		pars3 = pars2["紋左"].ToPars();
    		X0Y1_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
    		X0Y1_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
    		X0Y1_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
    		pars3 = pars2["紋右"].ToPars();
    		X0Y1_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
    		X0Y1_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
    		X0Y1_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
    		pars2 = partGroup["獣性"].ToPars();
    		X0Y1_獣性_獣毛左 = pars2["獣毛左"].ToPar();
    		X0Y1_獣性_獣毛右 = pars2["獣毛右"].ToPar();
    		pars2 = partGroup["虫性"].ToPars();
    		X0Y1_虫性_甲殻2 = pars2["甲殻2"].ToPar();
    		X0Y1_虫性_甲殻1 = pars2["甲殻1"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		pars3 = pars2["左"].ToPars();
    		X0Y1_竜性_左_鱗1 = pars3["鱗1"].ToPar();
    		X0Y1_竜性_左_鱗2 = pars3["鱗2"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y1_竜性_右_鱗1 = pars3["鱗1"].ToPar();
    		X0Y1_竜性_右_鱗2 = pars3["鱗2"].ToPar();
    		X0Y1_ハイライト上左 = partGroup["ハイライト上左"].ToPar();
    		X0Y1_ハイライト上右 = partGroup["ハイライト上右"].ToPar();
    		X0Y1_ハイライト下左 = partGroup["ハイライト下左"].ToPar();
    		X0Y1_ハイライト下右 = partGroup["ハイライト下右"].ToPar();
    		partGroup = Body[0][2];
    		X0Y2_Waist = partGroup["腰"].ToPar();
    		X0Y2_股 = partGroup["股"].ToPar();
    		X0Y2_下腹 = partGroup["下腹"].ToPar();
    		X0Y2_腰皺 = partGroup["腰皺"].ToPar();
    		pars2 = partGroup["筋肉"].ToPars();
    		X0Y2_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
    		X0Y2_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
    		X0Y2_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
    		X0Y2_筋肉_筋上左 = pars2["筋上左"].ToPar();
    		X0Y2_筋肉_筋上右 = pars2["筋上右"].ToPar();
    		X0Y2_筋肉_筋下左 = pars2["筋下左"].ToPar();
    		X0Y2_筋肉_筋下右 = pars2["筋下右"].ToPar();
    		X0Y2_ハイライト = partGroup["ハイライト"].ToPar();
    		X0Y2_臍 = partGroup["臍"].ToPar();
    		pars2 = partGroup["淫タトゥ"].ToPars();
    		pars3 = pars2["渦"].ToPars();
    		X0Y2_悪タトゥ_渦_タトゥ1左 = pars3["タトゥ1左"].ToPar();
    		X0Y2_悪タトゥ_渦_タトゥ1右 = pars3["タトゥ1右"].ToPar();
    		X0Y2_悪タトゥ_渦_タトゥ2左 = pars3["タトゥ2左"].ToPar();
    		X0Y2_悪タトゥ_渦_タトゥ2右 = pars3["タトゥ2右"].ToPar();
    		pars3 = pars2["ハート"].ToPars();
    		X0Y2_淫タトゥ_ハート_タトゥ1左 = pars3["タトゥ1左"].ToPar();
    		X0Y2_淫タトゥ_ハート_タトゥ1右 = pars3["タトゥ1右"].ToPar();
    		X0Y2_淫タトゥ_ハート_タトゥ2左 = pars3["タトゥ2左"].ToPar();
    		X0Y2_淫タトゥ_ハート_タトゥ2右 = pars3["タトゥ2右"].ToPar();
    		X0Y2_傷X左 = partGroup["傷X左"].ToPar();
    		X0Y2_傷X右 = partGroup["傷X右"].ToPar();
    		X0Y2_傷I左 = partGroup["傷I左"].ToPar();
    		X0Y2_傷I右 = partGroup["傷I右"].ToPar();
    		pars2 = partGroup["紋柄"].ToPars();
    		pars3 = pars2["紋左"].ToPars();
    		X0Y2_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
    		X0Y2_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
    		X0Y2_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
    		pars3 = pars2["紋右"].ToPars();
    		X0Y2_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
    		X0Y2_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
    		X0Y2_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
    		pars2 = partGroup["獣性"].ToPars();
    		X0Y2_獣性_獣毛左 = pars2["獣毛左"].ToPar();
    		X0Y2_獣性_獣毛右 = pars2["獣毛右"].ToPar();
    		pars2 = partGroup["虫性"].ToPars();
    		X0Y2_虫性_甲殻2 = pars2["甲殻2"].ToPar();
    		X0Y2_虫性_甲殻1 = pars2["甲殻1"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		pars3 = pars2["左"].ToPars();
    		X0Y2_竜性_左_鱗1 = pars3["鱗1"].ToPar();
    		X0Y2_竜性_左_鱗2 = pars3["鱗2"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y2_竜性_右_鱗1 = pars3["鱗1"].ToPar();
    		X0Y2_竜性_右_鱗2 = pars3["鱗2"].ToPar();
    		X0Y2_ハイライト上左 = partGroup["ハイライト上左"].ToPar();
    		X0Y2_ハイライト上右 = partGroup["ハイライト上右"].ToPar();
    		X0Y2_ハイライト下左 = partGroup["ハイライト下左"].ToPar();
    		X0Y2_ハイライト下右 = partGroup["ハイライト下右"].ToPar();
    		partGroup = Body[0][3];
    		X0Y3_Waist = partGroup["腰"].ToPar();
    		X0Y3_股 = partGroup["股"].ToPar();
    		X0Y3_下腹 = partGroup["下腹"].ToPar();
    		X0Y3_腰皺 = partGroup["腰皺"].ToPar();
    		pars2 = partGroup["筋肉"].ToPars();
    		X0Y3_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
    		X0Y3_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
    		X0Y3_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
    		X0Y3_筋肉_筋上左 = pars2["筋上左"].ToPar();
    		X0Y3_筋肉_筋上右 = pars2["筋上右"].ToPar();
    		X0Y3_筋肉_筋下左 = pars2["筋下左"].ToPar();
    		X0Y3_筋肉_筋下右 = pars2["筋下右"].ToPar();
    		X0Y3_ハイライト = partGroup["ハイライト"].ToPar();
    		X0Y3_臍 = partGroup["臍"].ToPar();
    		pars2 = partGroup["淫タトゥ"].ToPars();
    		pars3 = pars2["渦"].ToPars();
    		X0Y3_悪タトゥ_渦_タトゥ1左 = pars3["タトゥ1左"].ToPar();
    		X0Y3_悪タトゥ_渦_タトゥ1右 = pars3["タトゥ1右"].ToPar();
    		X0Y3_悪タトゥ_渦_タトゥ2左 = pars3["タトゥ2左"].ToPar();
    		X0Y3_悪タトゥ_渦_タトゥ2右 = pars3["タトゥ2右"].ToPar();
    		pars3 = pars2["ハート"].ToPars();
    		X0Y3_淫タトゥ_ハート_タトゥ1左 = pars3["タトゥ1左"].ToPar();
    		X0Y3_淫タトゥ_ハート_タトゥ1右 = pars3["タトゥ1右"].ToPar();
    		X0Y3_淫タトゥ_ハート_タトゥ2左 = pars3["タトゥ2左"].ToPar();
    		X0Y3_淫タトゥ_ハート_タトゥ2右 = pars3["タトゥ2右"].ToPar();
    		X0Y3_傷X左 = partGroup["傷X左"].ToPar();
    		X0Y3_傷X右 = partGroup["傷X右"].ToPar();
    		X0Y3_傷I左 = partGroup["傷I左"].ToPar();
    		X0Y3_傷I右 = partGroup["傷I右"].ToPar();
    		pars2 = partGroup["紋柄"].ToPars();
    		pars3 = pars2["紋左"].ToPars();
    		X0Y3_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
    		X0Y3_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
    		X0Y3_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
    		pars3 = pars2["紋右"].ToPars();
    		X0Y3_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
    		X0Y3_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
    		X0Y3_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
    		pars2 = partGroup["獣性"].ToPars();
    		X0Y3_獣性_獣毛左 = pars2["獣毛左"].ToPar();
    		X0Y3_獣性_獣毛右 = pars2["獣毛右"].ToPar();
    		pars2 = partGroup["虫性"].ToPars();
    		X0Y3_虫性_甲殻2 = pars2["甲殻2"].ToPar();
    		X0Y3_虫性_甲殻1 = pars2["甲殻1"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		pars3 = pars2["左"].ToPars();
    		X0Y3_竜性_左_鱗1 = pars3["鱗1"].ToPar();
    		X0Y3_竜性_左_鱗2 = pars3["鱗2"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y3_竜性_右_鱗1 = pars3["鱗1"].ToPar();
    		X0Y3_竜性_右_鱗2 = pars3["鱗2"].ToPar();
    		X0Y3_ハイライト上左 = partGroup["ハイライト上左"].ToPar();
    		X0Y3_ハイライト上右 = partGroup["ハイライト上右"].ToPar();
    		X0Y3_ハイライト下左 = partGroup["ハイライト下左"].ToPar();
    		X0Y3_ハイライト下右 = partGroup["ハイライト下右"].ToPar();
    		partGroup = Body[0][4];
    		X0Y4_Waist = partGroup["腰"].ToPar();
    		X0Y4_股 = partGroup["股"].ToPar();
    		X0Y4_下腹 = partGroup["下腹"].ToPar();
    		X0Y4_腰皺 = partGroup["腰皺"].ToPar();
    		pars2 = partGroup["筋肉"].ToPars();
    		X0Y4_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
    		X0Y4_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
    		X0Y4_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
    		X0Y4_筋肉_筋上左 = pars2["筋上左"].ToPar();
    		X0Y4_筋肉_筋上右 = pars2["筋上右"].ToPar();
    		X0Y4_筋肉_筋下左 = pars2["筋下左"].ToPar();
    		X0Y4_筋肉_筋下右 = pars2["筋下右"].ToPar();
    		X0Y4_ハイライト = partGroup["ハイライト"].ToPar();
    		X0Y4_臍 = partGroup["臍"].ToPar();
    		pars2 = partGroup["淫タトゥ"].ToPars();
    		pars3 = pars2["渦"].ToPars();
    		X0Y4_悪タトゥ_渦_タトゥ1左 = pars3["タトゥ1左"].ToPar();
    		X0Y4_悪タトゥ_渦_タトゥ1右 = pars3["タトゥ1右"].ToPar();
    		X0Y4_悪タトゥ_渦_タトゥ2左 = pars3["タトゥ2左"].ToPar();
    		X0Y4_悪タトゥ_渦_タトゥ2右 = pars3["タトゥ2右"].ToPar();
    		pars3 = pars2["ハート"].ToPars();
    		X0Y4_淫タトゥ_ハート_タトゥ1左 = pars3["タトゥ1左"].ToPar();
    		X0Y4_淫タトゥ_ハート_タトゥ1右 = pars3["タトゥ1右"].ToPar();
    		X0Y4_淫タトゥ_ハート_タトゥ2左 = pars3["タトゥ2左"].ToPar();
    		X0Y4_淫タトゥ_ハート_タトゥ2右 = pars3["タトゥ2右"].ToPar();
    		X0Y4_傷X左 = partGroup["傷X左"].ToPar();
    		X0Y4_傷X右 = partGroup["傷X右"].ToPar();
    		X0Y4_傷I左 = partGroup["傷I左"].ToPar();
    		X0Y4_傷I右 = partGroup["傷I右"].ToPar();
    		pars2 = partGroup["紋柄"].ToPars();
    		pars3 = pars2["紋左"].ToPars();
    		X0Y4_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
    		X0Y4_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
    		X0Y4_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
    		pars3 = pars2["紋右"].ToPars();
    		X0Y4_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
    		X0Y4_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
    		X0Y4_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
    		pars2 = partGroup["獣性"].ToPars();
    		X0Y4_獣性_獣毛左 = pars2["獣毛左"].ToPar();
    		X0Y4_獣性_獣毛右 = pars2["獣毛右"].ToPar();
    		pars2 = partGroup["虫性"].ToPars();
    		X0Y4_虫性_甲殻2 = pars2["甲殻2"].ToPar();
    		X0Y4_虫性_甲殻1 = pars2["甲殻1"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		pars3 = pars2["左"].ToPars();
    		X0Y4_竜性_左_鱗1 = pars3["鱗1"].ToPar();
    		X0Y4_竜性_左_鱗2 = pars3["鱗2"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y4_竜性_右_鱗1 = pars3["鱗1"].ToPar();
    		X0Y4_竜性_右_鱗2 = pars3["鱗2"].ToPar();
    		X0Y4_ハイライト上左 = partGroup["ハイライト上左"].ToPar();
    		X0Y4_ハイライト上右 = partGroup["ハイライト上右"].ToPar();
    		X0Y4_ハイライト下左 = partGroup["ハイライト下左"].ToPar();
    		X0Y4_ハイライト下右 = partGroup["ハイライト下右"].ToPar();
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
    		Waist_表示 = e.Waist_表示;
    		股_表示 = e.股_表示;
    		下腹_表示 = e.下腹_表示;
    		腰皺_表示 = e.腰皺_表示;
    		筋肉_筋肉下_表示 = e.筋肉_筋肉下_表示;
    		筋肉_筋肉左_表示 = e.筋肉_筋肉左_表示;
    		筋肉_筋肉右_表示 = e.筋肉_筋肉右_表示;
    		筋肉_筋上左_表示 = e.筋肉_筋上左_表示;
    		筋肉_筋上右_表示 = e.筋肉_筋上右_表示;
    		筋肉_筋下左_表示 = e.筋肉_筋下左_表示;
    		筋肉_筋下右_表示 = e.筋肉_筋下右_表示;
    		ハイライト_表示 = e.ハイライト_表示;
    		臍_表示 = e.臍_表示;
    		悪タトゥ_渦_タトゥ1左_表示 = e.悪タトゥ_渦_タトゥ1左_表示;
    		悪タトゥ_渦_タトゥ1右_表示 = e.悪タトゥ_渦_タトゥ1右_表示;
    		悪タトゥ_渦_タトゥ2左_表示 = e.悪タトゥ_渦_タトゥ2左_表示;
    		悪タトゥ_渦_タトゥ2右_表示 = e.悪タトゥ_渦_タトゥ2右_表示;
    		淫タトゥ_ハート_タトゥ1左_表示 = e.淫タトゥ_ハート_タトゥ1左_表示;
    		淫タトゥ_ハート_タトゥ1右_表示 = e.淫タトゥ_ハート_タトゥ1右_表示;
    		淫タトゥ_ハート_タトゥ2左_表示 = e.淫タトゥ_ハート_タトゥ2左_表示;
    		淫タトゥ_ハート_タトゥ2右_表示 = e.淫タトゥ_ハート_タトゥ2右_表示;
    		傷X左_表示 = e.傷X左_表示;
    		傷X右_表示 = e.傷X右_表示;
    		傷I左_表示 = e.傷I左_表示;
    		傷I右_表示 = e.傷I右_表示;
    		紋柄_紋左_紋1_表示 = e.紋柄_紋左_紋1_表示;
    		紋柄_紋左_紋2_表示 = e.紋柄_紋左_紋2_表示;
    		紋柄_紋左_紋3_表示 = e.紋柄_紋左_紋3_表示;
    		紋柄_紋右_紋1_表示 = e.紋柄_紋右_紋1_表示;
    		紋柄_紋右_紋2_表示 = e.紋柄_紋右_紋2_表示;
    		紋柄_紋右_紋3_表示 = e.紋柄_紋右_紋3_表示;
    		獣性_獣毛左_表示 = e.獣性_獣毛左_表示;
    		獣性_獣毛右_表示 = e.獣性_獣毛右_表示;
    		虫性_甲殻2_表示 = e.虫性_甲殻2_表示;
    		虫性_甲殻1_表示 = e.虫性_甲殻1_表示;
    		竜性_左_鱗1_表示 = e.竜性_左_鱗1_表示;
    		竜性_左_鱗2_表示 = e.竜性_左_鱗2_表示;
    		竜性_右_鱗1_表示 = e.竜性_右_鱗1_表示;
    		竜性_右_鱗2_表示 = e.竜性_右_鱗2_表示;
    		ハイライト上左_表示 = e.ハイライト上左_表示;
    		ハイライト上右_表示 = e.ハイライト上右_表示;
    		ハイライト下左_表示 = e.ハイライト下左_表示;
    		ハイライト下右_表示 = e.ハイライト下右_表示;
    		ハイライト表示 = e.ハイライト表示;
    		if (e.スライム)
    		{
    			スライム();
    		}
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Element f;
    		if (e.Torso_接続.Count > 0)
    		{
    			Torso_接続 = e.Torso_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Waist2;
    				f.ConnectionType = ConnectionInfo.Waist_Torso_接続;
    				f.接続(Waist2.Torso_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.腿左_接続.Count > 0)
    		{
    			腿左_接続 = e.腿左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Waist2;
    				f.ConnectionType = ConnectionInfo.Waist_腿左_接続;
    				f.接続(Waist2.腿左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.腿右_接続.Count > 0)
    		{
    			腿右_接続 = e.腿右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Waist2;
    				f.ConnectionType = ConnectionInfo.Waist_腿右_接続;
    				f.接続(Waist2.腿右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.膣基_接続.Count > 0)
    		{
    			膣基_接続 = e.膣基_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Waist2;
    				f.ConnectionType = ConnectionInfo.Waist_膣基_接続;
    				f.接続(Waist2.膣基_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.肛門_接続.Count > 0)
    		{
    			肛門_接続 = e.肛門_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Waist2;
    				f.ConnectionType = ConnectionInfo.Waist_肛門_接続;
    				f.接続(Waist2.肛門_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.尾_接続.Count > 0)
    		{
    			尾_接続 = e.尾_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Waist2;
    				f.ConnectionType = ConnectionInfo.Waist_尾_接続;
    				f.接続(Waist2.尾_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.半身_接続.Count > 0)
    		{
    			半身_接続 = e.半身_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Waist2;
    				f.ConnectionType = ConnectionInfo.Waist_半身_接続;
    				f.接続(Waist2.半身_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.上着_接続.Count > 0)
    		{
    			上着_接続 = e.上着_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Waist2;
    				f.ConnectionType = ConnectionInfo.Waist_上着_接続;
    				f.接続(Waist2.上着_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.肌_接続.Count > 0)
    		{
    			肌_接続 = e.肌_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Waist2;
    				f.ConnectionType = ConnectionInfo.Waist_肌_接続;
    				f.接続(Waist2.肌_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼左_接続.Count > 0)
    		{
    			翼左_接続 = e.翼左_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Waist2;
    				f.ConnectionType = ConnectionInfo.Waist_翼左_接続;
    				f.接続(Waist2.翼左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼右_接続.Count > 0)
    		{
    			翼右_接続 = e.翼右_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = Waist2;
    				f.ConnectionType = ConnectionInfo.Waist_翼右_接続;
    				f.接続(Waist2.翼右_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_WaistCP = new ColorP(X0Y0_Waist, WaistCD, DisUnit, abj: true);
    		X0Y0_股CP = new ColorP(X0Y0_股, 股CD, DisUnit, abj: false);
    		X0Y0_下腹CP = new ColorP(X0Y0_下腹, 下腹CD, DisUnit, abj: false);
    		X0Y0_腰皺CP = new ColorP(X0Y0_腰皺, 腰皺CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉下CP = new ColorP(X0Y0_筋肉_筋肉下, 筋肉_筋肉下CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉左CP = new ColorP(X0Y0_筋肉_筋肉左, 筋肉_筋肉左CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉右CP = new ColorP(X0Y0_筋肉_筋肉右, 筋肉_筋肉右CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋上左CP = new ColorP(X0Y0_筋肉_筋上左, 筋肉_筋上左CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋上右CP = new ColorP(X0Y0_筋肉_筋上右, 筋肉_筋上右CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋下左CP = new ColorP(X0Y0_筋肉_筋下左, 筋肉_筋下左CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋下右CP = new ColorP(X0Y0_筋肉_筋下右, 筋肉_筋下右CD, DisUnit, abj: false);
    		X0Y0_ハイライトCP = new ColorP(X0Y0_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y0_臍CP = new ColorP(X0Y0_臍, 臍CD, DisUnit, abj: false);
    		X0Y0_悪タトゥ_渦_タトゥ1左CP = new ColorP(X0Y0_悪タトゥ_渦_タトゥ1左, 悪タトゥ_渦_タトゥ1左CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_渦_タトゥ1右CP = new ColorP(X0Y0_悪タトゥ_渦_タトゥ1右, 悪タトゥ_渦_タトゥ1右CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_渦_タトゥ2左CP = new ColorP(X0Y0_悪タトゥ_渦_タトゥ2左, 悪タトゥ_渦_タトゥ2左CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ_渦_タトゥ2右CP = new ColorP(X0Y0_悪タトゥ_渦_タトゥ2右, 悪タトゥ_渦_タトゥ2右CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_ハート_タトゥ1左CP = new ColorP(X0Y0_淫タトゥ_ハート_タトゥ1左, 淫タトゥ_ハート_タトゥ1左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_ハート_タトゥ1右CP = new ColorP(X0Y0_淫タトゥ_ハート_タトゥ1右, 淫タトゥ_ハート_タトゥ1右CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_ハート_タトゥ2左CP = new ColorP(X0Y0_淫タトゥ_ハート_タトゥ2左, 淫タトゥ_ハート_タトゥ2左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_ハート_タトゥ2右CP = new ColorP(X0Y0_淫タトゥ_ハート_タトゥ2右, 淫タトゥ_ハート_タトゥ2右CD, DisUnit, abj: true);
    		X0Y0_傷X左CP = new ColorP(X0Y0_傷X左, 傷X左CD, DisUnit, abj: true);
    		X0Y0_傷X右CP = new ColorP(X0Y0_傷X右, 傷X右CD, DisUnit, abj: true);
    		X0Y0_傷I左CP = new ColorP(X0Y0_傷I左, 傷I左CD, DisUnit, abj: true);
    		X0Y0_傷I右CP = new ColorP(X0Y0_傷I右, 傷I右CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋左_紋1CP = new ColorP(X0Y0_紋柄_紋左_紋1, 紋柄_紋左_紋1CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋左_紋2CP = new ColorP(X0Y0_紋柄_紋左_紋2, 紋柄_紋左_紋2CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋左_紋3CP = new ColorP(X0Y0_紋柄_紋左_紋3, 紋柄_紋左_紋3CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋右_紋1CP = new ColorP(X0Y0_紋柄_紋右_紋1, 紋柄_紋右_紋1CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋右_紋2CP = new ColorP(X0Y0_紋柄_紋右_紋2, 紋柄_紋右_紋2CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋右_紋3CP = new ColorP(X0Y0_紋柄_紋右_紋3, 紋柄_紋右_紋3CD, DisUnit, abj: true);
    		X0Y0_獣性_獣毛左CP = new ColorP(X0Y0_獣性_獣毛左, 獣性_獣毛左CD, DisUnit, abj: true);
    		X0Y0_獣性_獣毛右CP = new ColorP(X0Y0_獣性_獣毛右, 獣性_獣毛右CD, DisUnit, abj: true);
    		X0Y0_虫性_甲殻2CP = new ColorP(X0Y0_虫性_甲殻2, 虫性_甲殻2CD, DisUnit, abj: true);
    		X0Y0_虫性_甲殻1CP = new ColorP(X0Y0_虫性_甲殻1, 虫性_甲殻1CD, DisUnit, abj: true);
    		X0Y0_竜性_左_鱗1CP = new ColorP(X0Y0_竜性_左_鱗1, 竜性_左_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_左_鱗2CP = new ColorP(X0Y0_竜性_左_鱗2, 竜性_左_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_右_鱗1CP = new ColorP(X0Y0_竜性_右_鱗1, 竜性_右_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_右_鱗2CP = new ColorP(X0Y0_竜性_右_鱗2, 竜性_右_鱗2CD, DisUnit, abj: true);
    		X0Y0_ハイライト上左CP = new ColorP(X0Y0_ハイライト上左, ハイライト上左CD, DisUnit, abj: true);
    		X0Y0_ハイライト上右CP = new ColorP(X0Y0_ハイライト上右, ハイライト上右CD, DisUnit, abj: true);
    		X0Y0_ハイライト下左CP = new ColorP(X0Y0_ハイライト下左, ハイライト下左CD, DisUnit, abj: true);
    		X0Y0_ハイライト下右CP = new ColorP(X0Y0_ハイライト下右, ハイライト下右CD, DisUnit, abj: true);
    		X0Y1_WaistCP = new ColorP(X0Y1_Waist, WaistCD, DisUnit, abj: true);
    		X0Y1_股CP = new ColorP(X0Y1_股, 股CD, DisUnit, abj: false);
    		X0Y1_下腹CP = new ColorP(X0Y1_下腹, 下腹CD, DisUnit, abj: false);
    		X0Y1_腰皺CP = new ColorP(X0Y1_腰皺, 腰皺CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋肉下CP = new ColorP(X0Y1_筋肉_筋肉下, 筋肉_筋肉下CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋肉左CP = new ColorP(X0Y1_筋肉_筋肉左, 筋肉_筋肉左CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋肉右CP = new ColorP(X0Y1_筋肉_筋肉右, 筋肉_筋肉右CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋上左CP = new ColorP(X0Y1_筋肉_筋上左, 筋肉_筋上左CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋上右CP = new ColorP(X0Y1_筋肉_筋上右, 筋肉_筋上右CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋下左CP = new ColorP(X0Y1_筋肉_筋下左, 筋肉_筋下左CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋下右CP = new ColorP(X0Y1_筋肉_筋下右, 筋肉_筋下右CD, DisUnit, abj: false);
    		X0Y1_ハイライトCP = new ColorP(X0Y1_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y1_臍CP = new ColorP(X0Y1_臍, 臍CD, DisUnit, abj: false);
    		X0Y1_悪タトゥ_渦_タトゥ1左CP = new ColorP(X0Y1_悪タトゥ_渦_タトゥ1左, 悪タトゥ_渦_タトゥ1左CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ_渦_タトゥ1右CP = new ColorP(X0Y1_悪タトゥ_渦_タトゥ1右, 悪タトゥ_渦_タトゥ1右CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ_渦_タトゥ2左CP = new ColorP(X0Y1_悪タトゥ_渦_タトゥ2左, 悪タトゥ_渦_タトゥ2左CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ_渦_タトゥ2右CP = new ColorP(X0Y1_悪タトゥ_渦_タトゥ2右, 悪タトゥ_渦_タトゥ2右CD, DisUnit, abj: true);
    		X0Y1_淫タトゥ_ハート_タトゥ1左CP = new ColorP(X0Y1_淫タトゥ_ハート_タトゥ1左, 淫タトゥ_ハート_タトゥ1左CD, DisUnit, abj: true);
    		X0Y1_淫タトゥ_ハート_タトゥ1右CP = new ColorP(X0Y1_淫タトゥ_ハート_タトゥ1右, 淫タトゥ_ハート_タトゥ1右CD, DisUnit, abj: true);
    		X0Y1_淫タトゥ_ハート_タトゥ2左CP = new ColorP(X0Y1_淫タトゥ_ハート_タトゥ2左, 淫タトゥ_ハート_タトゥ2左CD, DisUnit, abj: true);
    		X0Y1_淫タトゥ_ハート_タトゥ2右CP = new ColorP(X0Y1_淫タトゥ_ハート_タトゥ2右, 淫タトゥ_ハート_タトゥ2右CD, DisUnit, abj: true);
    		X0Y1_傷X左CP = new ColorP(X0Y1_傷X左, 傷X左CD, DisUnit, abj: true);
    		X0Y1_傷X右CP = new ColorP(X0Y1_傷X右, 傷X右CD, DisUnit, abj: true);
    		X0Y1_傷I左CP = new ColorP(X0Y1_傷I左, 傷I左CD, DisUnit, abj: true);
    		X0Y1_傷I右CP = new ColorP(X0Y1_傷I右, 傷I右CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋左_紋1CP = new ColorP(X0Y1_紋柄_紋左_紋1, 紋柄_紋左_紋1CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋左_紋2CP = new ColorP(X0Y1_紋柄_紋左_紋2, 紋柄_紋左_紋2CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋左_紋3CP = new ColorP(X0Y1_紋柄_紋左_紋3, 紋柄_紋左_紋3CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋右_紋1CP = new ColorP(X0Y1_紋柄_紋右_紋1, 紋柄_紋右_紋1CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋右_紋2CP = new ColorP(X0Y1_紋柄_紋右_紋2, 紋柄_紋右_紋2CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋右_紋3CP = new ColorP(X0Y1_紋柄_紋右_紋3, 紋柄_紋右_紋3CD, DisUnit, abj: true);
    		X0Y1_獣性_獣毛左CP = new ColorP(X0Y1_獣性_獣毛左, 獣性_獣毛左CD, DisUnit, abj: true);
    		X0Y1_獣性_獣毛右CP = new ColorP(X0Y1_獣性_獣毛右, 獣性_獣毛右CD, DisUnit, abj: true);
    		X0Y1_虫性_甲殻2CP = new ColorP(X0Y1_虫性_甲殻2, 虫性_甲殻2CD, DisUnit, abj: true);
    		X0Y1_虫性_甲殻1CP = new ColorP(X0Y1_虫性_甲殻1, 虫性_甲殻1CD, DisUnit, abj: true);
    		X0Y1_竜性_左_鱗1CP = new ColorP(X0Y1_竜性_左_鱗1, 竜性_左_鱗1CD, DisUnit, abj: true);
    		X0Y1_竜性_左_鱗2CP = new ColorP(X0Y1_竜性_左_鱗2, 竜性_左_鱗2CD, DisUnit, abj: true);
    		X0Y1_竜性_右_鱗1CP = new ColorP(X0Y1_竜性_右_鱗1, 竜性_右_鱗1CD, DisUnit, abj: true);
    		X0Y1_竜性_右_鱗2CP = new ColorP(X0Y1_竜性_右_鱗2, 竜性_右_鱗2CD, DisUnit, abj: true);
    		X0Y1_ハイライト上左CP = new ColorP(X0Y1_ハイライト上左, ハイライト上左CD, DisUnit, abj: true);
    		X0Y1_ハイライト上右CP = new ColorP(X0Y1_ハイライト上右, ハイライト上右CD, DisUnit, abj: true);
    		X0Y1_ハイライト下左CP = new ColorP(X0Y1_ハイライト下左, ハイライト下左CD, DisUnit, abj: true);
    		X0Y1_ハイライト下右CP = new ColorP(X0Y1_ハイライト下右, ハイライト下右CD, DisUnit, abj: true);
    		X0Y2_WaistCP = new ColorP(X0Y2_Waist, WaistCD, DisUnit, abj: true);
    		X0Y2_股CP = new ColorP(X0Y2_股, 股CD, DisUnit, abj: false);
    		X0Y2_下腹CP = new ColorP(X0Y2_下腹, 下腹CD, DisUnit, abj: false);
    		X0Y2_腰皺CP = new ColorP(X0Y2_腰皺, 腰皺CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋肉下CP = new ColorP(X0Y2_筋肉_筋肉下, 筋肉_筋肉下CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋肉左CP = new ColorP(X0Y2_筋肉_筋肉左, 筋肉_筋肉左CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋肉右CP = new ColorP(X0Y2_筋肉_筋肉右, 筋肉_筋肉右CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋上左CP = new ColorP(X0Y2_筋肉_筋上左, 筋肉_筋上左CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋上右CP = new ColorP(X0Y2_筋肉_筋上右, 筋肉_筋上右CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋下左CP = new ColorP(X0Y2_筋肉_筋下左, 筋肉_筋下左CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋下右CP = new ColorP(X0Y2_筋肉_筋下右, 筋肉_筋下右CD, DisUnit, abj: false);
    		X0Y2_ハイライトCP = new ColorP(X0Y2_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y2_臍CP = new ColorP(X0Y2_臍, 臍CD, DisUnit, abj: false);
    		X0Y2_悪タトゥ_渦_タトゥ1左CP = new ColorP(X0Y2_悪タトゥ_渦_タトゥ1左, 悪タトゥ_渦_タトゥ1左CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ_渦_タトゥ1右CP = new ColorP(X0Y2_悪タトゥ_渦_タトゥ1右, 悪タトゥ_渦_タトゥ1右CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ_渦_タトゥ2左CP = new ColorP(X0Y2_悪タトゥ_渦_タトゥ2左, 悪タトゥ_渦_タトゥ2左CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ_渦_タトゥ2右CP = new ColorP(X0Y2_悪タトゥ_渦_タトゥ2右, 悪タトゥ_渦_タトゥ2右CD, DisUnit, abj: true);
    		X0Y2_淫タトゥ_ハート_タトゥ1左CP = new ColorP(X0Y2_淫タトゥ_ハート_タトゥ1左, 淫タトゥ_ハート_タトゥ1左CD, DisUnit, abj: true);
    		X0Y2_淫タトゥ_ハート_タトゥ1右CP = new ColorP(X0Y2_淫タトゥ_ハート_タトゥ1右, 淫タトゥ_ハート_タトゥ1右CD, DisUnit, abj: true);
    		X0Y2_淫タトゥ_ハート_タトゥ2左CP = new ColorP(X0Y2_淫タトゥ_ハート_タトゥ2左, 淫タトゥ_ハート_タトゥ2左CD, DisUnit, abj: true);
    		X0Y2_淫タトゥ_ハート_タトゥ2右CP = new ColorP(X0Y2_淫タトゥ_ハート_タトゥ2右, 淫タトゥ_ハート_タトゥ2右CD, DisUnit, abj: true);
    		X0Y2_傷X左CP = new ColorP(X0Y2_傷X左, 傷X左CD, DisUnit, abj: true);
    		X0Y2_傷X右CP = new ColorP(X0Y2_傷X右, 傷X右CD, DisUnit, abj: true);
    		X0Y2_傷I左CP = new ColorP(X0Y2_傷I左, 傷I左CD, DisUnit, abj: true);
    		X0Y2_傷I右CP = new ColorP(X0Y2_傷I右, 傷I右CD, DisUnit, abj: true);
    		X0Y2_紋柄_紋左_紋1CP = new ColorP(X0Y2_紋柄_紋左_紋1, 紋柄_紋左_紋1CD, DisUnit, abj: true);
    		X0Y2_紋柄_紋左_紋2CP = new ColorP(X0Y2_紋柄_紋左_紋2, 紋柄_紋左_紋2CD, DisUnit, abj: true);
    		X0Y2_紋柄_紋左_紋3CP = new ColorP(X0Y2_紋柄_紋左_紋3, 紋柄_紋左_紋3CD, DisUnit, abj: true);
    		X0Y2_紋柄_紋右_紋1CP = new ColorP(X0Y2_紋柄_紋右_紋1, 紋柄_紋右_紋1CD, DisUnit, abj: true);
    		X0Y2_紋柄_紋右_紋2CP = new ColorP(X0Y2_紋柄_紋右_紋2, 紋柄_紋右_紋2CD, DisUnit, abj: true);
    		X0Y2_紋柄_紋右_紋3CP = new ColorP(X0Y2_紋柄_紋右_紋3, 紋柄_紋右_紋3CD, DisUnit, abj: true);
    		X0Y2_獣性_獣毛左CP = new ColorP(X0Y2_獣性_獣毛左, 獣性_獣毛左CD, DisUnit, abj: true);
    		X0Y2_獣性_獣毛右CP = new ColorP(X0Y2_獣性_獣毛右, 獣性_獣毛右CD, DisUnit, abj: true);
    		X0Y2_虫性_甲殻2CP = new ColorP(X0Y2_虫性_甲殻2, 虫性_甲殻2CD, DisUnit, abj: true);
    		X0Y2_虫性_甲殻1CP = new ColorP(X0Y2_虫性_甲殻1, 虫性_甲殻1CD, DisUnit, abj: true);
    		X0Y2_竜性_左_鱗1CP = new ColorP(X0Y2_竜性_左_鱗1, 竜性_左_鱗1CD, DisUnit, abj: true);
    		X0Y2_竜性_左_鱗2CP = new ColorP(X0Y2_竜性_左_鱗2, 竜性_左_鱗2CD, DisUnit, abj: true);
    		X0Y2_竜性_右_鱗1CP = new ColorP(X0Y2_竜性_右_鱗1, 竜性_右_鱗1CD, DisUnit, abj: true);
    		X0Y2_竜性_右_鱗2CP = new ColorP(X0Y2_竜性_右_鱗2, 竜性_右_鱗2CD, DisUnit, abj: true);
    		X0Y2_ハイライト上左CP = new ColorP(X0Y2_ハイライト上左, ハイライト上左CD, DisUnit, abj: true);
    		X0Y2_ハイライト上右CP = new ColorP(X0Y2_ハイライト上右, ハイライト上右CD, DisUnit, abj: true);
    		X0Y2_ハイライト下左CP = new ColorP(X0Y2_ハイライト下左, ハイライト下左CD, DisUnit, abj: true);
    		X0Y2_ハイライト下右CP = new ColorP(X0Y2_ハイライト下右, ハイライト下右CD, DisUnit, abj: true);
    		X0Y3_WaistCP = new ColorP(X0Y3_Waist, WaistCD, DisUnit, abj: true);
    		X0Y3_股CP = new ColorP(X0Y3_股, 股CD, DisUnit, abj: false);
    		X0Y3_下腹CP = new ColorP(X0Y3_下腹, 下腹CD, DisUnit, abj: false);
    		X0Y3_腰皺CP = new ColorP(X0Y3_腰皺, 腰皺CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋肉下CP = new ColorP(X0Y3_筋肉_筋肉下, 筋肉_筋肉下CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋肉左CP = new ColorP(X0Y3_筋肉_筋肉左, 筋肉_筋肉左CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋肉右CP = new ColorP(X0Y3_筋肉_筋肉右, 筋肉_筋肉右CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋上左CP = new ColorP(X0Y3_筋肉_筋上左, 筋肉_筋上左CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋上右CP = new ColorP(X0Y3_筋肉_筋上右, 筋肉_筋上右CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋下左CP = new ColorP(X0Y3_筋肉_筋下左, 筋肉_筋下左CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋下右CP = new ColorP(X0Y3_筋肉_筋下右, 筋肉_筋下右CD, DisUnit, abj: false);
    		X0Y3_ハイライトCP = new ColorP(X0Y3_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y3_臍CP = new ColorP(X0Y3_臍, 臍CD, DisUnit, abj: false);
    		X0Y3_悪タトゥ_渦_タトゥ1左CP = new ColorP(X0Y3_悪タトゥ_渦_タトゥ1左, 悪タトゥ_渦_タトゥ1左CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ_渦_タトゥ1右CP = new ColorP(X0Y3_悪タトゥ_渦_タトゥ1右, 悪タトゥ_渦_タトゥ1右CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ_渦_タトゥ2左CP = new ColorP(X0Y3_悪タトゥ_渦_タトゥ2左, 悪タトゥ_渦_タトゥ2左CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ_渦_タトゥ2右CP = new ColorP(X0Y3_悪タトゥ_渦_タトゥ2右, 悪タトゥ_渦_タトゥ2右CD, DisUnit, abj: true);
    		X0Y3_淫タトゥ_ハート_タトゥ1左CP = new ColorP(X0Y3_淫タトゥ_ハート_タトゥ1左, 淫タトゥ_ハート_タトゥ1左CD, DisUnit, abj: true);
    		X0Y3_淫タトゥ_ハート_タトゥ1右CP = new ColorP(X0Y3_淫タトゥ_ハート_タトゥ1右, 淫タトゥ_ハート_タトゥ1右CD, DisUnit, abj: true);
    		X0Y3_淫タトゥ_ハート_タトゥ2左CP = new ColorP(X0Y3_淫タトゥ_ハート_タトゥ2左, 淫タトゥ_ハート_タトゥ2左CD, DisUnit, abj: true);
    		X0Y3_淫タトゥ_ハート_タトゥ2右CP = new ColorP(X0Y3_淫タトゥ_ハート_タトゥ2右, 淫タトゥ_ハート_タトゥ2右CD, DisUnit, abj: true);
    		X0Y3_傷X左CP = new ColorP(X0Y3_傷X左, 傷X左CD, DisUnit, abj: true);
    		X0Y3_傷X右CP = new ColorP(X0Y3_傷X右, 傷X右CD, DisUnit, abj: true);
    		X0Y3_傷I左CP = new ColorP(X0Y3_傷I左, 傷I左CD, DisUnit, abj: true);
    		X0Y3_傷I右CP = new ColorP(X0Y3_傷I右, 傷I右CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋左_紋1CP = new ColorP(X0Y3_紋柄_紋左_紋1, 紋柄_紋左_紋1CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋左_紋2CP = new ColorP(X0Y3_紋柄_紋左_紋2, 紋柄_紋左_紋2CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋左_紋3CP = new ColorP(X0Y3_紋柄_紋左_紋3, 紋柄_紋左_紋3CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋右_紋1CP = new ColorP(X0Y3_紋柄_紋右_紋1, 紋柄_紋右_紋1CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋右_紋2CP = new ColorP(X0Y3_紋柄_紋右_紋2, 紋柄_紋右_紋2CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋右_紋3CP = new ColorP(X0Y3_紋柄_紋右_紋3, 紋柄_紋右_紋3CD, DisUnit, abj: true);
    		X0Y3_獣性_獣毛左CP = new ColorP(X0Y3_獣性_獣毛左, 獣性_獣毛左CD, DisUnit, abj: true);
    		X0Y3_獣性_獣毛右CP = new ColorP(X0Y3_獣性_獣毛右, 獣性_獣毛右CD, DisUnit, abj: true);
    		X0Y3_虫性_甲殻2CP = new ColorP(X0Y3_虫性_甲殻2, 虫性_甲殻2CD, DisUnit, abj: true);
    		X0Y3_虫性_甲殻1CP = new ColorP(X0Y3_虫性_甲殻1, 虫性_甲殻1CD, DisUnit, abj: true);
    		X0Y3_竜性_左_鱗1CP = new ColorP(X0Y3_竜性_左_鱗1, 竜性_左_鱗1CD, DisUnit, abj: true);
    		X0Y3_竜性_左_鱗2CP = new ColorP(X0Y3_竜性_左_鱗2, 竜性_左_鱗2CD, DisUnit, abj: true);
    		X0Y3_竜性_右_鱗1CP = new ColorP(X0Y3_竜性_右_鱗1, 竜性_右_鱗1CD, DisUnit, abj: true);
    		X0Y3_竜性_右_鱗2CP = new ColorP(X0Y3_竜性_右_鱗2, 竜性_右_鱗2CD, DisUnit, abj: true);
    		X0Y3_ハイライト上左CP = new ColorP(X0Y3_ハイライト上左, ハイライト上左CD, DisUnit, abj: true);
    		X0Y3_ハイライト上右CP = new ColorP(X0Y3_ハイライト上右, ハイライト上右CD, DisUnit, abj: true);
    		X0Y3_ハイライト下左CP = new ColorP(X0Y3_ハイライト下左, ハイライト下左CD, DisUnit, abj: true);
    		X0Y3_ハイライト下右CP = new ColorP(X0Y3_ハイライト下右, ハイライト下右CD, DisUnit, abj: true);
    		X0Y4_WaistCP = new ColorP(X0Y4_Waist, WaistCD, DisUnit, abj: true);
    		X0Y4_股CP = new ColorP(X0Y4_股, 股CD, DisUnit, abj: false);
    		X0Y4_下腹CP = new ColorP(X0Y4_下腹, 下腹CD, DisUnit, abj: false);
    		X0Y4_腰皺CP = new ColorP(X0Y4_腰皺, 腰皺CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋肉下CP = new ColorP(X0Y4_筋肉_筋肉下, 筋肉_筋肉下CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋肉左CP = new ColorP(X0Y4_筋肉_筋肉左, 筋肉_筋肉左CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋肉右CP = new ColorP(X0Y4_筋肉_筋肉右, 筋肉_筋肉右CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋上左CP = new ColorP(X0Y4_筋肉_筋上左, 筋肉_筋上左CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋上右CP = new ColorP(X0Y4_筋肉_筋上右, 筋肉_筋上右CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋下左CP = new ColorP(X0Y4_筋肉_筋下左, 筋肉_筋下左CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋下右CP = new ColorP(X0Y4_筋肉_筋下右, 筋肉_筋下右CD, DisUnit, abj: false);
    		X0Y4_ハイライトCP = new ColorP(X0Y4_ハイライト, ハイライトCD, DisUnit, abj: true);
    		X0Y4_臍CP = new ColorP(X0Y4_臍, 臍CD, DisUnit, abj: false);
    		X0Y4_悪タトゥ_渦_タトゥ1左CP = new ColorP(X0Y4_悪タトゥ_渦_タトゥ1左, 悪タトゥ_渦_タトゥ1左CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ_渦_タトゥ1右CP = new ColorP(X0Y4_悪タトゥ_渦_タトゥ1右, 悪タトゥ_渦_タトゥ1右CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ_渦_タトゥ2左CP = new ColorP(X0Y4_悪タトゥ_渦_タトゥ2左, 悪タトゥ_渦_タトゥ2左CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ_渦_タトゥ2右CP = new ColorP(X0Y4_悪タトゥ_渦_タトゥ2右, 悪タトゥ_渦_タトゥ2右CD, DisUnit, abj: true);
    		X0Y4_淫タトゥ_ハート_タトゥ1左CP = new ColorP(X0Y4_淫タトゥ_ハート_タトゥ1左, 淫タトゥ_ハート_タトゥ1左CD, DisUnit, abj: true);
    		X0Y4_淫タトゥ_ハート_タトゥ1右CP = new ColorP(X0Y4_淫タトゥ_ハート_タトゥ1右, 淫タトゥ_ハート_タトゥ1右CD, DisUnit, abj: true);
    		X0Y4_淫タトゥ_ハート_タトゥ2左CP = new ColorP(X0Y4_淫タトゥ_ハート_タトゥ2左, 淫タトゥ_ハート_タトゥ2左CD, DisUnit, abj: true);
    		X0Y4_淫タトゥ_ハート_タトゥ2右CP = new ColorP(X0Y4_淫タトゥ_ハート_タトゥ2右, 淫タトゥ_ハート_タトゥ2右CD, DisUnit, abj: true);
    		X0Y4_傷X左CP = new ColorP(X0Y4_傷X左, 傷X左CD, DisUnit, abj: true);
    		X0Y4_傷X右CP = new ColorP(X0Y4_傷X右, 傷X右CD, DisUnit, abj: true);
    		X0Y4_傷I左CP = new ColorP(X0Y4_傷I左, 傷I左CD, DisUnit, abj: true);
    		X0Y4_傷I右CP = new ColorP(X0Y4_傷I右, 傷I右CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋左_紋1CP = new ColorP(X0Y4_紋柄_紋左_紋1, 紋柄_紋左_紋1CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋左_紋2CP = new ColorP(X0Y4_紋柄_紋左_紋2, 紋柄_紋左_紋2CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋左_紋3CP = new ColorP(X0Y4_紋柄_紋左_紋3, 紋柄_紋左_紋3CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋右_紋1CP = new ColorP(X0Y4_紋柄_紋右_紋1, 紋柄_紋右_紋1CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋右_紋2CP = new ColorP(X0Y4_紋柄_紋右_紋2, 紋柄_紋右_紋2CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋右_紋3CP = new ColorP(X0Y4_紋柄_紋右_紋3, 紋柄_紋右_紋3CD, DisUnit, abj: true);
    		X0Y4_獣性_獣毛左CP = new ColorP(X0Y4_獣性_獣毛左, 獣性_獣毛左CD, DisUnit, abj: true);
    		X0Y4_獣性_獣毛右CP = new ColorP(X0Y4_獣性_獣毛右, 獣性_獣毛右CD, DisUnit, abj: true);
    		X0Y4_虫性_甲殻2CP = new ColorP(X0Y4_虫性_甲殻2, 虫性_甲殻2CD, DisUnit, abj: true);
    		X0Y4_虫性_甲殻1CP = new ColorP(X0Y4_虫性_甲殻1, 虫性_甲殻1CD, DisUnit, abj: true);
    		X0Y4_竜性_左_鱗1CP = new ColorP(X0Y4_竜性_左_鱗1, 竜性_左_鱗1CD, DisUnit, abj: true);
    		X0Y4_竜性_左_鱗2CP = new ColorP(X0Y4_竜性_左_鱗2, 竜性_左_鱗2CD, DisUnit, abj: true);
    		X0Y4_竜性_右_鱗1CP = new ColorP(X0Y4_竜性_右_鱗1, 竜性_右_鱗1CD, DisUnit, abj: true);
    		X0Y4_竜性_右_鱗2CP = new ColorP(X0Y4_竜性_右_鱗2, 竜性_右_鱗2CD, DisUnit, abj: true);
    		X0Y4_ハイライト上左CP = new ColorP(X0Y4_ハイライト上左, ハイライト上左CD, DisUnit, abj: true);
    		X0Y4_ハイライト上右CP = new ColorP(X0Y4_ハイライト上右, ハイライト上右CD, DisUnit, abj: true);
    		X0Y4_ハイライト下左CP = new ColorP(X0Y4_ハイライト下左, ハイライト下左CD, DisUnit, abj: true);
    		X0Y4_ハイライト下右CP = new ColorP(X0Y4_ハイライト下右, ハイライト下右CD, DisUnit, abj: true);
    		筋肉濃度 = e.筋肉濃度;
    		傷X左濃度 = e.傷X左濃度;
    		傷X右濃度 = e.傷X右濃度;
    		傷I左濃度 = e.傷I左濃度;
    		傷I右濃度 = e.傷I右濃度;
    		ハイライト濃度 = e.ハイライト濃度;
    		Intensity = e.濃度;
    		尺度YB = 0.95;
    		double num = 1.0025;
    		X0Y0_臍.SetBasePointBase(new Vector2D(X0Y0_臍.GetBasePointBase().X, 0.363998381176966));
    		X0Y1_臍.SetBasePointBase(new Vector2D(X0Y1_臍.GetBasePointBase().X, 0.363099175689868));
    		X0Y2_臍.SetBasePointBase(new Vector2D(X0Y2_臍.GetBasePointBase().X, 0.362199970202771));
    		X0Y3_臍.SetBasePointBase(new Vector2D(X0Y3_臍.GetBasePointBase().X, 0.361300764715674));
    		X0Y4_臍.SetBasePointBase(new Vector2D(X0Y4_臍.GetBasePointBase().X, 0.360401559228577));
    		X0Y0_ハイライト.SetBasePointBase(new Vector2D(X0Y0_ハイライト.GetBasePointBase().X, 0.0225674877335118));
    		X0Y1_ハイライト.SetBasePointBase(new Vector2D(X0Y1_ハイライト.GetBasePointBase().X, 0.0218134639688308));
    		X0Y2_ハイライト.SetBasePointBase(new Vector2D(X0Y2_ハイライト.GetBasePointBase().X, 0.0210594402041497));
    		X0Y3_ハイライト.SetBasePointBase(new Vector2D(X0Y3_ハイライト.GetBasePointBase().X, 0.0203054164394687));
    		X0Y4_ハイライト.SetBasePointBase(new Vector2D(X0Y4_ハイライト.GetBasePointBase().X, 0.0195513926747877));
    		num = 1.5;
    		X0Y0_臍.SetSizeBase(X0Y0_臍.GetSizeBase() * num);
    		X0Y1_臍.SetSizeBase(X0Y1_臍.GetSizeBase() * num);
    		X0Y2_臍.SetSizeBase(X0Y2_臍.GetSizeBase() * num);
    		X0Y3_臍.SetSizeBase(X0Y3_臍.GetSizeBase() * num);
    		X0Y4_臍.SetSizeBase(X0Y4_臍.GetSizeBase() * num);
    		X0Y0_ハイライト.SetSizeBase(X0Y0_ハイライト.GetSizeBase() * num);
    		X0Y1_ハイライト.SetSizeBase(X0Y1_ハイライト.GetSizeBase() * num);
    		X0Y2_ハイライト.SetSizeBase(X0Y2_ハイライト.GetSizeBase() * num);
    		X0Y3_ハイライト.SetSizeBase(X0Y3_ハイライト.GetSizeBase() * num);
    		X0Y4_ハイライト.SetSizeBase(X0Y4_ハイライト.GetSizeBase() * num);
    		num = 0.6;
    		X0Y0_臍.SetSizeXBase(X0Y0_臍.GetSizeXBase() * num);
    		X0Y1_臍.SetSizeXBase(X0Y1_臍.GetSizeXBase() * num);
    		X0Y2_臍.SetSizeXBase(X0Y2_臍.GetSizeXBase() * num);
    		X0Y3_臍.SetSizeXBase(X0Y3_臍.GetSizeXBase() * num);
    		X0Y4_臍.SetSizeXBase(X0Y4_臍.GetSizeXBase() * num);
    		X0Y0_ハイライト.SetSizeXBase(X0Y0_ハイライト.GetSizeXBase() * num);
    		X0Y1_ハイライト.SetSizeXBase(X0Y1_ハイライト.GetSizeXBase() * num);
    		X0Y2_ハイライト.SetSizeXBase(X0Y2_ハイライト.GetSizeXBase() * num);
    		X0Y3_ハイライト.SetSizeXBase(X0Y3_ハイライト.GetSizeXBase() * num);
    		X0Y4_ハイライト.SetSizeXBase(X0Y4_ハイライト.GetSizeXBase() * num);
    		num = 1.009;
    		X0Y0_Waist.SetBasePointBase(X0Y0_Waist.GetJP()[0].Joint.MulY(num));
    		X0Y1_Waist.SetBasePointBase(X0Y1_Waist.GetJP()[0].Joint.MulY(num));
    		X0Y2_Waist.SetBasePointBase(X0Y2_Waist.GetJP()[0].Joint.MulY(num));
    		X0Y3_Waist.SetBasePointBase(X0Y3_Waist.GetJP()[0].Joint.MulY(num));
    		X0Y4_Waist.SetBasePointBase(X0Y4_Waist.GetJP()[0].Joint.MulY(num));
    	}

    	public void スライム()
    	{
    		X0Y0_Waist.GetOP()[右 ? 3 : 3].Outline = false;
    		X0Y0_Waist.GetOP()[右 ? 2 : 4].Outline = false;
    		X0Y1_Waist.GetOP()[右 ? 3 : 3].Outline = false;
    		X0Y1_Waist.GetOP()[右 ? 2 : 4].Outline = false;
    		X0Y2_Waist.GetOP()[右 ? 3 : 3].Outline = false;
    		X0Y2_Waist.GetOP()[右 ? 2 : 4].Outline = false;
    		X0Y3_Waist.GetOP()[右 ? 3 : 3].Outline = false;
    		X0Y3_Waist.GetOP()[右 ? 2 : 4].Outline = false;
    		X0Y4_Waist.GetOP()[右 ? 3 : 3].Outline = false;
    		X0Y4_Waist.GetOP()[右 ? 2 : 4].Outline = false;
    		X0Y0_股.GetOP().OutlineFalse();
    		X0Y1_股.GetOP().OutlineFalse();
    		X0Y2_股.GetOP().OutlineFalse();
    		X0Y3_股.GetOP().OutlineFalse();
    		X0Y4_股.GetOP().OutlineFalse();
    		X0Y0_下腹.GetOP()[右 ? 3 : 2].Outline = false;
    		X0Y0_下腹.GetOP()[右 ? 1 : 4].Outline = false;
    		X0Y1_下腹.GetOP()[右 ? 3 : 2].Outline = false;
    		X0Y1_下腹.GetOP()[右 ? 1 : 4].Outline = false;
    		X0Y2_下腹.GetOP()[右 ? 3 : 2].Outline = false;
    		X0Y2_下腹.GetOP()[右 ? 1 : 4].Outline = false;
    		X0Y3_下腹.GetOP()[右 ? 3 : 2].Outline = false;
    		X0Y3_下腹.GetOP()[右 ? 1 : 4].Outline = false;
    		X0Y4_下腹.GetOP()[右 ? 3 : 2].Outline = false;
    		X0Y4_下腹.GetOP()[右 ? 1 : 4].Outline = false;
    	}

    	public override void 接続P()
    	{
    		Body.JoinP();
    	}

    	public override void 接続PA()
    	{
    		Body.JoinPA();
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		switch (Body.GetIndexY())
    		{
    		case 0:
    			Are.Draw(X0Y0_Waist);
    			Are.Draw(X0Y0_股);
    			Are.Draw(X0Y0_下腹);
    			Are.Draw(X0Y0_腰皺);
    			Are.Draw(X0Y0_筋肉_筋肉下);
    			Are.Draw(X0Y0_筋肉_筋肉左);
    			Are.Draw(X0Y0_筋肉_筋肉右);
    			Are.Draw(X0Y0_筋肉_筋上左);
    			Are.Draw(X0Y0_筋肉_筋上右);
    			Are.Draw(X0Y0_筋肉_筋下左);
    			Are.Draw(X0Y0_筋肉_筋下右);
    			break;
    		case 1:
    			Are.Draw(X0Y1_Waist);
    			Are.Draw(X0Y1_股);
    			Are.Draw(X0Y1_下腹);
    			Are.Draw(X0Y1_腰皺);
    			Are.Draw(X0Y1_筋肉_筋肉下);
    			Are.Draw(X0Y1_筋肉_筋肉左);
    			Are.Draw(X0Y1_筋肉_筋肉右);
    			Are.Draw(X0Y1_筋肉_筋上左);
    			Are.Draw(X0Y1_筋肉_筋上右);
    			Are.Draw(X0Y1_筋肉_筋下左);
    			Are.Draw(X0Y1_筋肉_筋下右);
    			break;
    		case 2:
    			Are.Draw(X0Y2_Waist);
    			Are.Draw(X0Y2_股);
    			Are.Draw(X0Y2_下腹);
    			Are.Draw(X0Y2_腰皺);
    			Are.Draw(X0Y2_筋肉_筋肉下);
    			Are.Draw(X0Y2_筋肉_筋肉左);
    			Are.Draw(X0Y2_筋肉_筋肉右);
    			Are.Draw(X0Y2_筋肉_筋上左);
    			Are.Draw(X0Y2_筋肉_筋上右);
    			Are.Draw(X0Y2_筋肉_筋下左);
    			Are.Draw(X0Y2_筋肉_筋下右);
    			break;
    		case 3:
    			Are.Draw(X0Y3_Waist);
    			Are.Draw(X0Y3_股);
    			Are.Draw(X0Y3_下腹);
    			Are.Draw(X0Y3_腰皺);
    			Are.Draw(X0Y3_筋肉_筋肉下);
    			Are.Draw(X0Y3_筋肉_筋肉左);
    			Are.Draw(X0Y3_筋肉_筋肉右);
    			Are.Draw(X0Y3_筋肉_筋上左);
    			Are.Draw(X0Y3_筋肉_筋上右);
    			Are.Draw(X0Y3_筋肉_筋下左);
    			Are.Draw(X0Y3_筋肉_筋下右);
    			break;
    		default:
    			Are.Draw(X0Y4_Waist);
    			Are.Draw(X0Y4_股);
    			Are.Draw(X0Y4_下腹);
    			Are.Draw(X0Y4_腰皺);
    			Are.Draw(X0Y4_筋肉_筋肉下);
    			Are.Draw(X0Y4_筋肉_筋肉左);
    			Are.Draw(X0Y4_筋肉_筋肉右);
    			Are.Draw(X0Y4_筋肉_筋上左);
    			Are.Draw(X0Y4_筋肉_筋上右);
    			Are.Draw(X0Y4_筋肉_筋下左);
    			Are.Draw(X0Y4_筋肉_筋下右);
    			break;
    		}
    	}

    	public override void 描画1(RenderArea Are)
    	{
    		switch (Body.GetIndexY())
    		{
    		case 0:
    			Are.Draw(X0Y0_ハイライト);
    			Are.Draw(X0Y0_臍);
    			Are.Draw(X0Y0_悪タトゥ_渦_タトゥ1左);
    			Are.Draw(X0Y0_悪タトゥ_渦_タトゥ1右);
    			Are.Draw(X0Y0_悪タトゥ_渦_タトゥ2左);
    			Are.Draw(X0Y0_悪タトゥ_渦_タトゥ2右);
    			Are.Draw(X0Y0_淫タトゥ_ハート_タトゥ1左);
    			Are.Draw(X0Y0_淫タトゥ_ハート_タトゥ1右);
    			Are.Draw(X0Y0_淫タトゥ_ハート_タトゥ2左);
    			Are.Draw(X0Y0_淫タトゥ_ハート_タトゥ2右);
    			Are.Draw(X0Y0_紋柄_紋左_紋1);
    			Are.Draw(X0Y0_紋柄_紋左_紋2);
    			Are.Draw(X0Y0_紋柄_紋左_紋3);
    			Are.Draw(X0Y0_紋柄_紋右_紋1);
    			Are.Draw(X0Y0_紋柄_紋右_紋2);
    			Are.Draw(X0Y0_紋柄_紋右_紋3);
    			Are.Draw(X0Y0_獣性_獣毛左);
    			Are.Draw(X0Y0_獣性_獣毛右);
    			Are.Draw(X0Y0_傷X左);
    			Are.Draw(X0Y0_傷X右);
    			Are.Draw(X0Y0_傷I左);
    			Are.Draw(X0Y0_傷I右);
    			キスマーク.Draw(Are);
    			鞭痕.Draw(Are);
    			Are.Draw(X0Y0_虫性_甲殻2);
    			Are.Draw(X0Y0_虫性_甲殻1);
    			Are.Draw(X0Y0_竜性_左_鱗1);
    			Are.Draw(X0Y0_竜性_左_鱗2);
    			Are.Draw(X0Y0_竜性_右_鱗1);
    			Are.Draw(X0Y0_竜性_右_鱗2);
    			Are.Draw(X0Y0_ハイライト上左);
    			Are.Draw(X0Y0_ハイライト上右);
    			Are.Draw(X0Y0_ハイライト下左);
    			Are.Draw(X0Y0_ハイライト下右);
    			break;
    		case 1:
    			Are.Draw(X0Y1_ハイライト);
    			Are.Draw(X0Y1_臍);
    			Are.Draw(X0Y1_悪タトゥ_渦_タトゥ1左);
    			Are.Draw(X0Y1_悪タトゥ_渦_タトゥ1右);
    			Are.Draw(X0Y1_悪タトゥ_渦_タトゥ2左);
    			Are.Draw(X0Y1_悪タトゥ_渦_タトゥ2右);
    			Are.Draw(X0Y1_淫タトゥ_ハート_タトゥ1左);
    			Are.Draw(X0Y1_淫タトゥ_ハート_タトゥ1右);
    			Are.Draw(X0Y1_淫タトゥ_ハート_タトゥ2左);
    			Are.Draw(X0Y1_淫タトゥ_ハート_タトゥ2右);
    			Are.Draw(X0Y1_紋柄_紋左_紋1);
    			Are.Draw(X0Y1_紋柄_紋左_紋2);
    			Are.Draw(X0Y1_紋柄_紋左_紋3);
    			Are.Draw(X0Y1_紋柄_紋右_紋1);
    			Are.Draw(X0Y1_紋柄_紋右_紋2);
    			Are.Draw(X0Y1_紋柄_紋右_紋3);
    			Are.Draw(X0Y1_獣性_獣毛左);
    			Are.Draw(X0Y1_獣性_獣毛右);
    			Are.Draw(X0Y1_傷X左);
    			Are.Draw(X0Y1_傷X右);
    			Are.Draw(X0Y1_傷I左);
    			Are.Draw(X0Y1_傷I右);
    			キスマーク.Draw(Are);
    			鞭痕.Draw(Are);
    			Are.Draw(X0Y1_虫性_甲殻2);
    			Are.Draw(X0Y1_虫性_甲殻1);
    			Are.Draw(X0Y1_竜性_左_鱗1);
    			Are.Draw(X0Y1_竜性_左_鱗2);
    			Are.Draw(X0Y1_竜性_右_鱗1);
    			Are.Draw(X0Y1_竜性_右_鱗2);
    			Are.Draw(X0Y1_ハイライト上左);
    			Are.Draw(X0Y1_ハイライト上右);
    			Are.Draw(X0Y1_ハイライト下左);
    			Are.Draw(X0Y1_ハイライト下右);
    			break;
    		case 2:
    			Are.Draw(X0Y2_ハイライト);
    			Are.Draw(X0Y2_臍);
    			Are.Draw(X0Y2_悪タトゥ_渦_タトゥ1左);
    			Are.Draw(X0Y2_悪タトゥ_渦_タトゥ1右);
    			Are.Draw(X0Y2_悪タトゥ_渦_タトゥ2左);
    			Are.Draw(X0Y2_悪タトゥ_渦_タトゥ2右);
    			Are.Draw(X0Y2_淫タトゥ_ハート_タトゥ1左);
    			Are.Draw(X0Y2_淫タトゥ_ハート_タトゥ1右);
    			Are.Draw(X0Y2_淫タトゥ_ハート_タトゥ2左);
    			Are.Draw(X0Y2_淫タトゥ_ハート_タトゥ2右);
    			Are.Draw(X0Y2_紋柄_紋左_紋1);
    			Are.Draw(X0Y2_紋柄_紋左_紋2);
    			Are.Draw(X0Y2_紋柄_紋左_紋3);
    			Are.Draw(X0Y2_紋柄_紋右_紋1);
    			Are.Draw(X0Y2_紋柄_紋右_紋2);
    			Are.Draw(X0Y2_紋柄_紋右_紋3);
    			Are.Draw(X0Y2_獣性_獣毛左);
    			Are.Draw(X0Y2_獣性_獣毛右);
    			Are.Draw(X0Y2_傷X左);
    			Are.Draw(X0Y2_傷X右);
    			Are.Draw(X0Y2_傷I左);
    			Are.Draw(X0Y2_傷I右);
    			キスマーク.Draw(Are);
    			鞭痕.Draw(Are);
    			Are.Draw(X0Y2_虫性_甲殻2);
    			Are.Draw(X0Y2_虫性_甲殻1);
    			Are.Draw(X0Y2_竜性_左_鱗1);
    			Are.Draw(X0Y2_竜性_左_鱗2);
    			Are.Draw(X0Y2_竜性_右_鱗1);
    			Are.Draw(X0Y2_竜性_右_鱗2);
    			Are.Draw(X0Y2_ハイライト上左);
    			Are.Draw(X0Y2_ハイライト上右);
    			Are.Draw(X0Y2_ハイライト下左);
    			Are.Draw(X0Y2_ハイライト下右);
    			break;
    		case 3:
    			Are.Draw(X0Y3_ハイライト);
    			Are.Draw(X0Y3_臍);
    			Are.Draw(X0Y3_悪タトゥ_渦_タトゥ1左);
    			Are.Draw(X0Y3_悪タトゥ_渦_タトゥ1右);
    			Are.Draw(X0Y3_悪タトゥ_渦_タトゥ2左);
    			Are.Draw(X0Y3_悪タトゥ_渦_タトゥ2右);
    			Are.Draw(X0Y3_淫タトゥ_ハート_タトゥ1左);
    			Are.Draw(X0Y3_淫タトゥ_ハート_タトゥ1右);
    			Are.Draw(X0Y3_淫タトゥ_ハート_タトゥ2左);
    			Are.Draw(X0Y3_淫タトゥ_ハート_タトゥ2右);
    			Are.Draw(X0Y3_紋柄_紋左_紋1);
    			Are.Draw(X0Y3_紋柄_紋左_紋2);
    			Are.Draw(X0Y3_紋柄_紋左_紋3);
    			Are.Draw(X0Y3_紋柄_紋右_紋1);
    			Are.Draw(X0Y3_紋柄_紋右_紋2);
    			Are.Draw(X0Y3_紋柄_紋右_紋3);
    			Are.Draw(X0Y3_獣性_獣毛左);
    			Are.Draw(X0Y3_獣性_獣毛右);
    			Are.Draw(X0Y3_傷X左);
    			Are.Draw(X0Y3_傷X右);
    			Are.Draw(X0Y3_傷I左);
    			Are.Draw(X0Y3_傷I右);
    			キスマーク.Draw(Are);
    			鞭痕.Draw(Are);
    			Are.Draw(X0Y3_虫性_甲殻2);
    			Are.Draw(X0Y3_虫性_甲殻1);
    			Are.Draw(X0Y3_竜性_左_鱗1);
    			Are.Draw(X0Y3_竜性_左_鱗2);
    			Are.Draw(X0Y3_竜性_右_鱗1);
    			Are.Draw(X0Y3_竜性_右_鱗2);
    			Are.Draw(X0Y3_ハイライト上左);
    			Are.Draw(X0Y3_ハイライト上右);
    			Are.Draw(X0Y3_ハイライト下左);
    			Are.Draw(X0Y3_ハイライト下右);
    			break;
    		default:
    			Are.Draw(X0Y4_ハイライト);
    			Are.Draw(X0Y4_臍);
    			Are.Draw(X0Y4_悪タトゥ_渦_タトゥ1左);
    			Are.Draw(X0Y4_悪タトゥ_渦_タトゥ1右);
    			Are.Draw(X0Y4_悪タトゥ_渦_タトゥ2左);
    			Are.Draw(X0Y4_悪タトゥ_渦_タトゥ2右);
    			Are.Draw(X0Y4_淫タトゥ_ハート_タトゥ1左);
    			Are.Draw(X0Y4_淫タトゥ_ハート_タトゥ1右);
    			Are.Draw(X0Y4_淫タトゥ_ハート_タトゥ2左);
    			Are.Draw(X0Y4_淫タトゥ_ハート_タトゥ2右);
    			Are.Draw(X0Y4_紋柄_紋左_紋1);
    			Are.Draw(X0Y4_紋柄_紋左_紋2);
    			Are.Draw(X0Y4_紋柄_紋左_紋3);
    			Are.Draw(X0Y4_紋柄_紋右_紋1);
    			Are.Draw(X0Y4_紋柄_紋右_紋2);
    			Are.Draw(X0Y4_紋柄_紋右_紋3);
    			Are.Draw(X0Y4_獣性_獣毛左);
    			Are.Draw(X0Y4_獣性_獣毛右);
    			Are.Draw(X0Y4_傷X左);
    			Are.Draw(X0Y4_傷X右);
    			Are.Draw(X0Y4_傷I左);
    			Are.Draw(X0Y4_傷I右);
    			キスマーク.Draw(Are);
    			鞭痕.Draw(Are);
    			Are.Draw(X0Y4_虫性_甲殻2);
    			Are.Draw(X0Y4_虫性_甲殻1);
    			Are.Draw(X0Y4_竜性_左_鱗1);
    			Are.Draw(X0Y4_竜性_左_鱗2);
    			Are.Draw(X0Y4_竜性_右_鱗1);
    			Are.Draw(X0Y4_竜性_右_鱗2);
    			Are.Draw(X0Y4_ハイライト上左);
    			Are.Draw(X0Y4_ハイライト上右);
    			Are.Draw(X0Y4_ハイライト下左);
    			Are.Draw(X0Y4_ハイライト下右);
    			break;
    		}
    	}

    	public override void 色更新()
    	{
    		switch (Body.GetIndexY())
    		{
    		case 0:
    			X0Y0_WaistCP.Update();
    			X0Y0_股CP.Update();
    			X0Y0_下腹CP.Update();
    			X0Y0_腰皺CP.Update();
    			X0Y0_筋肉_筋肉下CP.Update();
    			X0Y0_筋肉_筋肉左CP.Update();
    			X0Y0_筋肉_筋肉右CP.Update();
    			X0Y0_筋肉_筋上左CP.Update();
    			X0Y0_筋肉_筋上右CP.Update();
    			X0Y0_筋肉_筋下左CP.Update();
    			X0Y0_筋肉_筋下右CP.Update();
    			X0Y0_ハイライトCP.Update();
    			X0Y0_臍CP.Update();
    			X0Y0_悪タトゥ_渦_タトゥ1左CP.Update();
    			X0Y0_悪タトゥ_渦_タトゥ1右CP.Update();
    			X0Y0_悪タトゥ_渦_タトゥ2左CP.Update();
    			X0Y0_悪タトゥ_渦_タトゥ2右CP.Update();
    			X0Y0_淫タトゥ_ハート_タトゥ1左CP.Update();
    			X0Y0_淫タトゥ_ハート_タトゥ1右CP.Update();
    			X0Y0_淫タトゥ_ハート_タトゥ2左CP.Update();
    			X0Y0_淫タトゥ_ハート_タトゥ2右CP.Update();
    			X0Y0_傷X左CP.Update();
    			X0Y0_傷X右CP.Update();
    			X0Y0_傷I左CP.Update();
    			X0Y0_傷I右CP.Update();
    			X0Y0_紋柄_紋左_紋1CP.Update();
    			X0Y0_紋柄_紋左_紋2CP.Update();
    			X0Y0_紋柄_紋左_紋3CP.Update();
    			X0Y0_紋柄_紋右_紋1CP.Update();
    			X0Y0_紋柄_紋右_紋2CP.Update();
    			X0Y0_紋柄_紋右_紋3CP.Update();
    			X0Y0_獣性_獣毛左CP.Update();
    			X0Y0_獣性_獣毛右CP.Update();
    			X0Y0_虫性_甲殻2CP.Update();
    			X0Y0_虫性_甲殻1CP.Update();
    			X0Y0_竜性_左_鱗1CP.Update();
    			X0Y0_竜性_左_鱗2CP.Update();
    			X0Y0_竜性_右_鱗1CP.Update();
    			X0Y0_竜性_右_鱗2CP.Update();
    			X0Y0_ハイライト上左CP.Update();
    			X0Y0_ハイライト上右CP.Update();
    			X0Y0_ハイライト下左CP.Update();
    			X0Y0_ハイライト下右CP.Update();
    			break;
    		case 1:
    			X0Y1_WaistCP.Update();
    			X0Y1_股CP.Update();
    			X0Y1_下腹CP.Update();
    			X0Y1_腰皺CP.Update();
    			X0Y1_筋肉_筋肉下CP.Update();
    			X0Y1_筋肉_筋肉左CP.Update();
    			X0Y1_筋肉_筋肉右CP.Update();
    			X0Y1_筋肉_筋上左CP.Update();
    			X0Y1_筋肉_筋上右CP.Update();
    			X0Y1_筋肉_筋下左CP.Update();
    			X0Y1_筋肉_筋下右CP.Update();
    			X0Y1_ハイライトCP.Update();
    			X0Y1_臍CP.Update();
    			X0Y1_悪タトゥ_渦_タトゥ1左CP.Update();
    			X0Y1_悪タトゥ_渦_タトゥ1右CP.Update();
    			X0Y1_悪タトゥ_渦_タトゥ2左CP.Update();
    			X0Y1_悪タトゥ_渦_タトゥ2右CP.Update();
    			X0Y1_淫タトゥ_ハート_タトゥ1左CP.Update();
    			X0Y1_淫タトゥ_ハート_タトゥ1右CP.Update();
    			X0Y1_淫タトゥ_ハート_タトゥ2左CP.Update();
    			X0Y1_淫タトゥ_ハート_タトゥ2右CP.Update();
    			X0Y1_傷X左CP.Update();
    			X0Y1_傷X右CP.Update();
    			X0Y1_傷I左CP.Update();
    			X0Y1_傷I右CP.Update();
    			X0Y1_紋柄_紋左_紋1CP.Update();
    			X0Y1_紋柄_紋左_紋2CP.Update();
    			X0Y1_紋柄_紋左_紋3CP.Update();
    			X0Y1_紋柄_紋右_紋1CP.Update();
    			X0Y1_紋柄_紋右_紋2CP.Update();
    			X0Y1_紋柄_紋右_紋3CP.Update();
    			X0Y1_獣性_獣毛左CP.Update();
    			X0Y1_獣性_獣毛右CP.Update();
    			X0Y1_虫性_甲殻2CP.Update();
    			X0Y1_虫性_甲殻1CP.Update();
    			X0Y1_竜性_左_鱗1CP.Update();
    			X0Y1_竜性_左_鱗2CP.Update();
    			X0Y1_竜性_右_鱗1CP.Update();
    			X0Y1_竜性_右_鱗2CP.Update();
    			X0Y1_ハイライト上左CP.Update();
    			X0Y1_ハイライト上右CP.Update();
    			X0Y1_ハイライト下左CP.Update();
    			X0Y1_ハイライト下右CP.Update();
    			break;
    		case 2:
    			X0Y2_WaistCP.Update();
    			X0Y2_股CP.Update();
    			X0Y2_下腹CP.Update();
    			X0Y2_腰皺CP.Update();
    			X0Y2_筋肉_筋肉下CP.Update();
    			X0Y2_筋肉_筋肉左CP.Update();
    			X0Y2_筋肉_筋肉右CP.Update();
    			X0Y2_筋肉_筋上左CP.Update();
    			X0Y2_筋肉_筋上右CP.Update();
    			X0Y2_筋肉_筋下左CP.Update();
    			X0Y2_筋肉_筋下右CP.Update();
    			X0Y2_ハイライトCP.Update();
    			X0Y2_臍CP.Update();
    			X0Y2_悪タトゥ_渦_タトゥ1左CP.Update();
    			X0Y2_悪タトゥ_渦_タトゥ1右CP.Update();
    			X0Y2_悪タトゥ_渦_タトゥ2左CP.Update();
    			X0Y2_悪タトゥ_渦_タトゥ2右CP.Update();
    			X0Y2_淫タトゥ_ハート_タトゥ1左CP.Update();
    			X0Y2_淫タトゥ_ハート_タトゥ1右CP.Update();
    			X0Y2_淫タトゥ_ハート_タトゥ2左CP.Update();
    			X0Y2_淫タトゥ_ハート_タトゥ2右CP.Update();
    			X0Y2_傷X左CP.Update();
    			X0Y2_傷X右CP.Update();
    			X0Y2_傷I左CP.Update();
    			X0Y2_傷I右CP.Update();
    			X0Y2_紋柄_紋左_紋1CP.Update();
    			X0Y2_紋柄_紋左_紋2CP.Update();
    			X0Y2_紋柄_紋左_紋3CP.Update();
    			X0Y2_紋柄_紋右_紋1CP.Update();
    			X0Y2_紋柄_紋右_紋2CP.Update();
    			X0Y2_紋柄_紋右_紋3CP.Update();
    			X0Y2_獣性_獣毛左CP.Update();
    			X0Y2_獣性_獣毛右CP.Update();
    			X0Y2_虫性_甲殻2CP.Update();
    			X0Y2_虫性_甲殻1CP.Update();
    			X0Y2_竜性_左_鱗1CP.Update();
    			X0Y2_竜性_左_鱗2CP.Update();
    			X0Y2_竜性_右_鱗1CP.Update();
    			X0Y2_竜性_右_鱗2CP.Update();
    			X0Y2_ハイライト上左CP.Update();
    			X0Y2_ハイライト上右CP.Update();
    			X0Y2_ハイライト下左CP.Update();
    			X0Y2_ハイライト下右CP.Update();
    			break;
    		case 3:
    			X0Y3_WaistCP.Update();
    			X0Y3_股CP.Update();
    			X0Y3_下腹CP.Update();
    			X0Y3_腰皺CP.Update();
    			X0Y3_筋肉_筋肉下CP.Update();
    			X0Y3_筋肉_筋肉左CP.Update();
    			X0Y3_筋肉_筋肉右CP.Update();
    			X0Y3_筋肉_筋上左CP.Update();
    			X0Y3_筋肉_筋上右CP.Update();
    			X0Y3_筋肉_筋下左CP.Update();
    			X0Y3_筋肉_筋下右CP.Update();
    			X0Y3_ハイライトCP.Update();
    			X0Y3_臍CP.Update();
    			X0Y3_悪タトゥ_渦_タトゥ1左CP.Update();
    			X0Y3_悪タトゥ_渦_タトゥ1右CP.Update();
    			X0Y3_悪タトゥ_渦_タトゥ2左CP.Update();
    			X0Y3_悪タトゥ_渦_タトゥ2右CP.Update();
    			X0Y3_淫タトゥ_ハート_タトゥ1左CP.Update();
    			X0Y3_淫タトゥ_ハート_タトゥ1右CP.Update();
    			X0Y3_淫タトゥ_ハート_タトゥ2左CP.Update();
    			X0Y3_淫タトゥ_ハート_タトゥ2右CP.Update();
    			X0Y3_傷X左CP.Update();
    			X0Y3_傷X右CP.Update();
    			X0Y3_傷I左CP.Update();
    			X0Y3_傷I右CP.Update();
    			X0Y3_紋柄_紋左_紋1CP.Update();
    			X0Y3_紋柄_紋左_紋2CP.Update();
    			X0Y3_紋柄_紋左_紋3CP.Update();
    			X0Y3_紋柄_紋右_紋1CP.Update();
    			X0Y3_紋柄_紋右_紋2CP.Update();
    			X0Y3_紋柄_紋右_紋3CP.Update();
    			X0Y3_獣性_獣毛左CP.Update();
    			X0Y3_獣性_獣毛右CP.Update();
    			X0Y3_虫性_甲殻2CP.Update();
    			X0Y3_虫性_甲殻1CP.Update();
    			X0Y3_竜性_左_鱗1CP.Update();
    			X0Y3_竜性_左_鱗2CP.Update();
    			X0Y3_竜性_右_鱗1CP.Update();
    			X0Y3_竜性_右_鱗2CP.Update();
    			X0Y3_ハイライト上左CP.Update();
    			X0Y3_ハイライト上右CP.Update();
    			X0Y3_ハイライト下左CP.Update();
    			X0Y3_ハイライト下右CP.Update();
    			break;
    		default:
    			X0Y4_WaistCP.Update();
    			X0Y4_股CP.Update();
    			X0Y4_下腹CP.Update();
    			X0Y4_腰皺CP.Update();
    			X0Y4_筋肉_筋肉下CP.Update();
    			X0Y4_筋肉_筋肉左CP.Update();
    			X0Y4_筋肉_筋肉右CP.Update();
    			X0Y4_筋肉_筋上左CP.Update();
    			X0Y4_筋肉_筋上右CP.Update();
    			X0Y4_筋肉_筋下左CP.Update();
    			X0Y4_筋肉_筋下右CP.Update();
    			X0Y4_ハイライトCP.Update();
    			X0Y4_臍CP.Update();
    			X0Y4_悪タトゥ_渦_タトゥ1左CP.Update();
    			X0Y4_悪タトゥ_渦_タトゥ1右CP.Update();
    			X0Y4_悪タトゥ_渦_タトゥ2左CP.Update();
    			X0Y4_悪タトゥ_渦_タトゥ2右CP.Update();
    			X0Y4_淫タトゥ_ハート_タトゥ1左CP.Update();
    			X0Y4_淫タトゥ_ハート_タトゥ1右CP.Update();
    			X0Y4_淫タトゥ_ハート_タトゥ2左CP.Update();
    			X0Y4_淫タトゥ_ハート_タトゥ2右CP.Update();
    			X0Y4_傷X左CP.Update();
    			X0Y4_傷X右CP.Update();
    			X0Y4_傷I左CP.Update();
    			X0Y4_傷I右CP.Update();
    			X0Y4_紋柄_紋左_紋1CP.Update();
    			X0Y4_紋柄_紋左_紋2CP.Update();
    			X0Y4_紋柄_紋左_紋3CP.Update();
    			X0Y4_紋柄_紋右_紋1CP.Update();
    			X0Y4_紋柄_紋右_紋2CP.Update();
    			X0Y4_紋柄_紋右_紋3CP.Update();
    			X0Y4_獣性_獣毛左CP.Update();
    			X0Y4_獣性_獣毛右CP.Update();
    			X0Y4_虫性_甲殻2CP.Update();
    			X0Y4_虫性_甲殻1CP.Update();
    			X0Y4_竜性_左_鱗1CP.Update();
    			X0Y4_竜性_左_鱗2CP.Update();
    			X0Y4_竜性_右_鱗1CP.Update();
    			X0Y4_竜性_右_鱗2CP.Update();
    			X0Y4_ハイライト上左CP.Update();
    			X0Y4_ハイライト上右CP.Update();
    			X0Y4_ハイライト下左CP.Update();
    			X0Y4_ハイライト下右CP.Update();
    			break;
    		}
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
    		WaistCD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		股CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌R);
    		下腹CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		腰皺CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋上左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋上右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋下左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋下右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		臍CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		悪タトゥ_渦_タトゥ1左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ_渦_タトゥ1右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ_渦_タトゥ2左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ_渦_タトゥ2右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ1左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ1右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ2左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ2右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		傷X左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷X右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		紋柄_紋左_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		獣性_獣毛左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.毛0O);
    		獣性_獣毛右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.毛0O);
    		虫性_甲殻2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		虫性_甲殻1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		竜性_左_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_左_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_右_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_右_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		ハイライト上左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト上右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト下左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト下右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		WaistCD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		股CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌R);
    		下腹CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		腰皺CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋上左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋上右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋下左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋下右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		臍CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		悪タトゥ_渦_タトゥ1左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ_渦_タトゥ1右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ_渦_タトゥ2左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ_渦_タトゥ2右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ1左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ1右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ2左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ2右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		傷X左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷X右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		紋柄_紋左_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		獣性_獣毛左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.毛0O);
    		獣性_獣毛右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.毛0O);
    		虫性_甲殻2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		虫性_甲殻1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		竜性_左_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_左_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_右_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_右_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		ハイライト上左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト上右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト下左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト下右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		WaistCD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		股CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌R);
    		下腹CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		腰皺CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋上左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋上右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋下左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		筋肉_筋下右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		臍CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
    		悪タトゥ_渦_タトゥ1左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ_渦_タトゥ1右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ_渦_タトゥ2左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ_渦_タトゥ2右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ1左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ1右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ2左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ2右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		傷X左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷X右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		紋柄_紋左_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		獣性_獣毛左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.毛0O);
    		獣性_獣毛右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.毛0O);
    		虫性_甲殻2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		虫性_甲殻1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		竜性_左_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_左_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_右_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_右_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		ハイライト上左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト上右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト下左CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト下右CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    	}
    }
}
