using System.Drawing;
using System.Linq;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class 腿_人 : 腿
    {
    	public ShapePart X0Y0_腿;

    	public ShapePart X0Y0_筋;

    	public ShapePart X0Y0_獣性_獣毛1;

    	public ShapePart X0Y0_獣性_獣毛2;

    	public ShapePart X0Y0_淫タトゥ_ハート_タトゥ左;

    	public ShapePart X0Y0_淫タトゥ_ハート_タトゥ右;

    	public ShapePart X0Y0_淫タトゥ_タトゥ左1;

    	public ShapePart X0Y0_淫タトゥ_タトゥ右1;

    	public ShapePart X0Y0_淫タトゥ_タトゥ左2;

    	public ShapePart X0Y0_淫タトゥ_タトゥ右2;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字a_枠;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字b_枠;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字c_枠;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字d_枠;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字e_枠;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2;

    	public ShapePart X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3;

    	public ShapePart X0Y0_悪タトゥ1_タトゥ1;

    	public ShapePart X0Y0_悪タトゥ1_タトゥ2;

    	public ShapePart X0Y0_悪タトゥ2_逆十字_逆十字1;

    	public ShapePart X0Y0_悪タトゥ2_逆十字_逆十字2;

    	public ShapePart X0Y0_竜性_鱗1;

    	public ShapePart X0Y0_竜性_鱗2;

    	public ShapePart X0Y0_竜性_鱗3;

    	public ShapePart X0Y0_竜性_鱗4;

    	public ShapePart X0Y0_紋柄_紋1;

    	public ShapePart X0Y0_紋柄_紋2;

    	public ShapePart X0Y0_紋柄_紋3;

    	public ShapePart X0Y0_紋柄_紋4;

    	public ShapePart X0Y0_植性_通常_葉3;

    	public ShapePart X0Y0_植性_通常_葉2;

    	public ShapePart X0Y0_植性_通常_葉1;

    	public ShapePart X0Y0_植性_欠損_葉3;

    	public ShapePart X0Y0_植性_欠損_葉2;

    	public ShapePart X0Y0_植性_欠損_葉1;

    	public ShapePart X0Y0_虫性_器官1;

    	public ShapePart X0Y0_虫性_器官2;

    	public ShapePart X0Y0_傷I1;

    	public ShapePart X0Y0_傷I2;

    	public ShapePart X0Y0_傷I3;

    	public ShapePart X0Y0_傷I4;

    	public ShapePart X0Y0_傷X;

    	public ShapePart X0Y0_ハイライト1;

    	public ShapePart X0Y0_ハイライト2;

    	public ShapePart X0Y0_パンスト;

    	public ShapePart X0Y0_パンスト_ハイライト;

    	public ShapePart X0Y0_ニーハイ_ニーハイ1;

    	public ShapePart X0Y0_ニーハイ_ニーハイ2;

    	public ShapePart X0Y0_ニーハイ_ハイライト;

    	public ShapePart X0Y1_腿;

    	public ShapePart X0Y1_筋;

    	public ShapePart X0Y1_獣性_獣毛1;

    	public ShapePart X0Y1_獣性_獣毛2;

    	public ShapePart X0Y1_淫タトゥ_ハート_タトゥ左;

    	public ShapePart X0Y1_淫タトゥ_ハート_タトゥ右;

    	public ShapePart X0Y1_淫タトゥ_タトゥ左1;

    	public ShapePart X0Y1_淫タトゥ_タトゥ右1;

    	public ShapePart X0Y1_淫タトゥ_タトゥ左2;

    	public ShapePart X0Y1_淫タトゥ_タトゥ右2;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字a_枠;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字b_枠;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字c_枠;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字d_枠;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字e_枠;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2;

    	public ShapePart X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3;

    	public ShapePart X0Y1_悪タトゥ1_タトゥ1;

    	public ShapePart X0Y1_悪タトゥ1_タトゥ2;

    	public ShapePart X0Y1_悪タトゥ2_逆十字_逆十字1;

    	public ShapePart X0Y1_悪タトゥ2_逆十字_逆十字2;

    	public ShapePart X0Y1_鱗_鱗1;

    	public ShapePart X0Y1_鱗_鱗2;

    	public ShapePart X0Y1_鱗_鱗3;

    	public ShapePart X0Y1_鱗_鱗4;

    	public ShapePart X0Y1_紋柄_紋1;

    	public ShapePart X0Y1_紋柄_紋2;

    	public ShapePart X0Y1_紋柄_紋3;

    	public ShapePart X0Y1_紋柄_紋4;

    	public ShapePart X0Y1_植性_通常_葉3;

    	public ShapePart X0Y1_植性_通常_葉2;

    	public ShapePart X0Y1_植性_通常_葉1;

    	public ShapePart X0Y1_植性_欠損_葉3;

    	public ShapePart X0Y1_植性_欠損_葉2;

    	public ShapePart X0Y1_植性_欠損_葉1;

    	public ShapePart X0Y1_虫性_器官1;

    	public ShapePart X0Y1_虫性_器官2;

    	public ShapePart X0Y1_傷I1;

    	public ShapePart X0Y1_傷I2;

    	public ShapePart X0Y1_傷I3;

    	public ShapePart X0Y1_傷I4;

    	public ShapePart X0Y1_傷X;

    	public ShapePart X0Y1_ハイライト1;

    	public ShapePart X0Y1_ハイライト2;

    	public ShapePart X0Y1_パンスト;

    	public ShapePart X0Y1_パンスト_ハイライト;

    	public ShapePart X0Y1_ニーハイ_ニーハイ1;

    	public ShapePart X0Y1_ニーハイ_ニーハイ2;

    	public ShapePart X0Y1_ニーハイ_ハイライト;

    	public ShapePart X0Y2_腿;

    	public ShapePart X0Y2_筋;

    	public ShapePart X0Y2_獣性_獣毛1;

    	public ShapePart X0Y2_獣性_獣毛2;

    	public ShapePart X0Y2_淫タトゥ_ハート_タトゥ左;

    	public ShapePart X0Y2_淫タトゥ_ハート_タトゥ右;

    	public ShapePart X0Y2_淫タトゥ_タトゥ右1;

    	public ShapePart X0Y2_淫タトゥ_タトゥ右2;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字b_枠;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字c_枠;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字d_枠;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字e_枠;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字a_枠;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1;

    	public ShapePart X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2;

    	public ShapePart X0Y2_悪タトゥ1_タトゥ1;

    	public ShapePart X0Y2_悪タトゥ1_タトゥ2;

    	public ShapePart X0Y2_悪タトゥ2_逆十字_逆十字1;

    	public ShapePart X0Y2_悪タトゥ2_逆十字_逆十字2;

    	public ShapePart X0Y2_植性_通常_葉3;

    	public ShapePart X0Y2_植性_通常_葉2;

    	public ShapePart X0Y2_植性_通常_葉1;

    	public ShapePart X0Y2_植性_欠損_葉3;

    	public ShapePart X0Y2_植性_欠損_葉2;

    	public ShapePart X0Y2_植性_欠損_葉1;

    	public ShapePart X0Y2_傷I1;

    	public ShapePart X0Y2_傷I2;

    	public ShapePart X0Y2_傷I3;

    	public ShapePart X0Y2_ハイライト1;

    	public ShapePart X0Y2_ハイライト2;

    	public ShapePart X0Y2_パンスト;

    	public ShapePart X0Y2_パンスト_ハイライト;

    	public ShapePart X0Y2_ニーハイ_ニーハイ1;

    	public ShapePart X0Y2_ニーハイ_ニーハイ2;

    	public ShapePart X0Y2_ニーハイ_ハイライト;

    	public ShapePart X0Y3_腿;

    	public ShapePart X0Y3_筋;

    	public ShapePart X0Y3_獣性_獣毛1;

    	public ShapePart X0Y3_獣性_獣毛2;

    	public ShapePart X0Y3_淫タトゥ_タトゥ左1;

    	public ShapePart X0Y3_淫タトゥ_タトゥ右1;

    	public ShapePart X0Y3_淫タトゥ_タトゥ左2;

    	public ShapePart X0Y3_淫タトゥ_タトゥ右2;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字c_枠;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字d_枠;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字e_枠;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字a_枠;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字b_枠;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1;

    	public ShapePart X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2;

    	public ShapePart X0Y3_悪タトゥ1_タトゥ1;

    	public ShapePart X0Y3_悪タトゥ1_タトゥ2;

    	public ShapePart X0Y3_悪タトゥ2_逆十字_逆十字1;

    	public ShapePart X0Y3_悪タトゥ2_逆十字_逆十字2;

    	public ShapePart X0Y3_鱗_鱗1;

    	public ShapePart X0Y3_鱗_鱗2;

    	public ShapePart X0Y3_鱗_鱗3;

    	public ShapePart X0Y3_鱗_鱗4;

    	public ShapePart X0Y3_紋柄_紋1;

    	public ShapePart X0Y3_紋柄_紋2;

    	public ShapePart X0Y3_紋柄_紋3;

    	public ShapePart X0Y3_紋柄_紋4;

    	public ShapePart X0Y3_植性_通常_葉3;

    	public ShapePart X0Y3_植性_通常_葉2;

    	public ShapePart X0Y3_植性_通常_葉1;

    	public ShapePart X0Y3_植性_欠損_葉3;

    	public ShapePart X0Y3_植性_欠損_葉2;

    	public ShapePart X0Y3_植性_欠損_葉1;

    	public ShapePart X0Y3_傷I1;

    	public ShapePart X0Y3_傷I2;

    	public ShapePart X0Y3_傷I3;

    	public ShapePart X0Y3_傷X;

    	public ShapePart X0Y3_ハイライト1;

    	public ShapePart X0Y3_ハイライト2;

    	public ShapePart X0Y3_パンスト;

    	public ShapePart X0Y3_パンスト_ハイライト;

    	public ShapePart X0Y3_ニーハイ_ニーハイ1;

    	public ShapePart X0Y3_ニーハイ_ニーハイ2;

    	public ShapePart X0Y3_ニーハイ_ハイライト;

    	public ShapePart X0Y4_腿;

    	public ShapePart X0Y4_筋;

    	public ShapePart X0Y4_獣性_獣毛1;

    	public ShapePart X0Y4_獣性_獣毛2;

    	public ShapePart X0Y4_淫タトゥ_タトゥ左1;

    	public ShapePart X0Y4_淫タトゥ_タトゥ右1;

    	public ShapePart X0Y4_淫タトゥ_タトゥ左2;

    	public ShapePart X0Y4_淫タトゥ_タトゥ右2;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字d_枠;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字e_枠;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字a_枠;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字b_枠;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字c_枠;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1;

    	public ShapePart X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2;

    	public ShapePart X0Y4_悪タトゥ1_タトゥ1;

    	public ShapePart X0Y4_悪タトゥ1_タトゥ2;

    	public ShapePart X0Y4_鱗_鱗1;

    	public ShapePart X0Y4_鱗_鱗2;

    	public ShapePart X0Y4_鱗_鱗3;

    	public ShapePart X0Y4_鱗_鱗4;

    	public ShapePart X0Y4_紋柄_紋1;

    	public ShapePart X0Y4_紋柄_紋2;

    	public ShapePart X0Y4_紋柄_紋3;

    	public ShapePart X0Y4_紋柄_紋4;

    	public ShapePart X0Y4_植性_通常_葉3;

    	public ShapePart X0Y4_植性_通常_葉2;

    	public ShapePart X0Y4_植性_通常_葉1;

    	public ShapePart X0Y4_植性_欠損_葉3;

    	public ShapePart X0Y4_植性_欠損_葉2;

    	public ShapePart X0Y4_植性_欠損_葉1;

    	public ShapePart X0Y4_傷I1;

    	public ShapePart X0Y4_傷X;

    	public ShapePart X0Y4_ハイライト1;

    	public ShapePart X0Y4_ハイライト2;

    	public ShapePart X0Y4_パンスト;

    	public ShapePart X0Y4_パンスト_ハイライト;

    	public ShapePart X0Y4_ニーハイ_ニーハイ1;

    	public ShapePart X0Y4_ニーハイ_ニーハイ2;

    	public ShapePart X0Y4_ニーハイ_ハイライト;

    	public ColorD 腿0CD;

    	public ColorD 腿1CD;

    	public ColorD 腿2CD;

    	public ColorD 腿3CD;

    	public ColorD 腿4CD;

    	public ColorD 筋CD;

    	public ColorD 獣性_獣毛1_0CD;

    	public ColorD 獣性_獣毛2_0CD;

    	public ColorD 獣性_獣毛1_1CD;

    	public ColorD 獣性_獣毛2_1CD;

    	public ColorD 獣性_獣毛1_2CD;

    	public ColorD 獣性_獣毛2_2CD;

    	public ColorD 獣性_獣毛1_3CD;

    	public ColorD 獣性_獣毛2_3CD;

    	public ColorD 獣性_獣毛1_4CD;

    	public ColorD 獣性_獣毛2_4CD;

    	public ColorD 淫タトゥ_ハート_タトゥ左CD;

    	public ColorD 淫タトゥ_ハート_タトゥ右CD;

    	public ColorD 淫タトゥ_タトゥ左1CD;

    	public ColorD 淫タトゥ_タトゥ右1CD;

    	public ColorD 淫タトゥ_タトゥ左2CD;

    	public ColorD 淫タトゥ_タトゥ右2CD;

    	public ColorD 悪タトゥ1_文字_文字a_枠CD;

    	public ColorD 悪タトゥ1_文字_文字a_文字タトゥ1CD;

    	public ColorD 悪タトゥ1_文字_文字a_文字タトゥ2CD;

    	public ColorD 悪タトゥ1_文字_文字b_枠CD;

    	public ColorD 悪タトゥ1_文字_文字b_文字タトゥ1CD;

    	public ColorD 悪タトゥ1_文字_文字b_文字タトゥ2CD;

    	public ColorD 悪タトゥ1_文字_文字c_枠CD;

    	public ColorD 悪タトゥ1_文字_文字c_文字タトゥ1CD;

    	public ColorD 悪タトゥ1_文字_文字c_文字タトゥ2CD;

    	public ColorD 悪タトゥ1_文字_文字d_枠CD;

    	public ColorD 悪タトゥ1_文字_文字d_文字タトゥ1CD;

    	public ColorD 悪タトゥ1_文字_文字d_文字タトゥ2CD;

    	public ColorD 悪タトゥ1_文字_文字e_枠CD;

    	public ColorD 悪タトゥ1_文字_文字e_文字タトゥ1CD;

    	public ColorD 悪タトゥ1_文字_文字e_文字タトゥ2CD;

    	public ColorD 悪タトゥ1_文字_文字e_文字タトゥ3CD;

    	public ColorD 悪タトゥ1_タトゥ1CD;

    	public ColorD 悪タトゥ1_タトゥ2CD;

    	public ColorD 悪タトゥ2_逆十字_逆十字1CD;

    	public ColorD 悪タトゥ2_逆十字_逆十字2CD;

    	public ColorD 竜性_鱗1CD;

    	public ColorD 竜性_鱗2CD;

    	public ColorD 竜性_鱗3CD;

    	public ColorD 竜性_鱗4CD;

    	public ColorD 紋柄_紋1CD;

    	public ColorD 紋柄_紋2CD;

    	public ColorD 紋柄_紋3CD;

    	public ColorD 紋柄_紋4CD;

    	public ColorD 植性_葉3_0CD;

    	public ColorD 植性_葉2_0CD;

    	public ColorD 植性_葉1_0CD;

    	public ColorD 植性_葉3_1CD;

    	public ColorD 植性_葉2_1CD;

    	public ColorD 植性_葉1_1CD;

    	public ColorD 植性_葉3_2CD;

    	public ColorD 植性_葉2_2CD;

    	public ColorD 植性_葉1_2CD;

    	public ColorD 植性_葉3_3CD;

    	public ColorD 植性_葉2_3CD;

    	public ColorD 植性_葉1_3CD;

    	public ColorD 植性_葉3_4CD;

    	public ColorD 植性_葉2_4CD;

    	public ColorD 植性_葉1_4CD;

    	public ColorD 虫性_器官1CD;

    	public ColorD 虫性_器官2CD;

    	public ColorD 傷I1CD;

    	public ColorD 傷I2CD;

    	public ColorD 傷I3CD;

    	public ColorD 傷I4CD;

    	public ColorD 傷XCD;

    	public ColorD ハイライト1CD;

    	public ColorD ハイライト2CD;

    	public ColorD パンストCD;

    	public ColorD パンスト_ハイライトCD;

    	public ColorD ニーハイ_ニーハイ1CD;

    	public ColorD ニーハイ_ニーハイ2CD;

    	public ColorD ニーハイ_ハイライトCD;

    	public ColorP X0Y0_腿CP;

    	public ColorP X0Y0_筋CP;

    	public ColorP X0Y0_獣性_獣毛1CP;

    	public ColorP X0Y0_獣性_獣毛2CP;

    	public ColorP X0Y0_淫タトゥ_ハート_タトゥ左CP;

    	public ColorP X0Y0_淫タトゥ_ハート_タトゥ右CP;

    	public ColorP X0Y0_淫タトゥ_タトゥ左1CP;

    	public ColorP X0Y0_淫タトゥ_タトゥ右1CP;

    	public ColorP X0Y0_淫タトゥ_タトゥ左2CP;

    	public ColorP X0Y0_淫タトゥ_タトゥ右2CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字a_枠CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字b_枠CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字c_枠CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字d_枠CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字e_枠CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3CP;

    	public ColorP X0Y0_悪タトゥ1_タトゥ1CP;

    	public ColorP X0Y0_悪タトゥ1_タトゥ2CP;

    	public ColorP X0Y0_悪タトゥ2_逆十字_逆十字1CP;

    	public ColorP X0Y0_悪タトゥ2_逆十字_逆十字2CP;

    	public ColorP X0Y0_竜性_鱗1CP;

    	public ColorP X0Y0_竜性_鱗2CP;

    	public ColorP X0Y0_竜性_鱗3CP;

    	public ColorP X0Y0_竜性_鱗4CP;

    	public ColorP X0Y0_紋柄_紋1CP;

    	public ColorP X0Y0_紋柄_紋2CP;

    	public ColorP X0Y0_紋柄_紋3CP;

    	public ColorP X0Y0_紋柄_紋4CP;

    	public ColorP X0Y0_植性_通常_葉3CP;

    	public ColorP X0Y0_植性_通常_葉2CP;

    	public ColorP X0Y0_植性_通常_葉1CP;

    	public ColorP X0Y0_植性_欠損_葉3CP;

    	public ColorP X0Y0_植性_欠損_葉2CP;

    	public ColorP X0Y0_植性_欠損_葉1CP;

    	public ColorP X0Y0_虫性_器官1CP;

    	public ColorP X0Y0_虫性_器官2CP;

    	public ColorP X0Y0_傷I1CP;

    	public ColorP X0Y0_傷I2CP;

    	public ColorP X0Y0_傷I3CP;

    	public ColorP X0Y0_傷I4CP;

    	public ColorP X0Y0_傷XCP;

    	public ColorP X0Y0_ハイライト1CP;

    	public ColorP X0Y0_ハイライト2CP;

    	public ColorP X0Y0_パンストCP;

    	public ColorP X0Y0_パンスト_ハイライトCP;

    	public ColorP X0Y0_ニーハイ_ニーハイ1CP;

    	public ColorP X0Y0_ニーハイ_ニーハイ2CP;

    	public ColorP X0Y0_ニーハイ_ハイライトCP;

    	public ColorP X0Y1_腿CP;

    	public ColorP X0Y1_筋CP;

    	public ColorP X0Y1_獣性_獣毛1CP;

    	public ColorP X0Y1_獣性_獣毛2CP;

    	public ColorP X0Y1_淫タトゥ_ハート_タトゥ左CP;

    	public ColorP X0Y1_淫タトゥ_ハート_タトゥ右CP;

    	public ColorP X0Y1_淫タトゥ_タトゥ左1CP;

    	public ColorP X0Y1_淫タトゥ_タトゥ右1CP;

    	public ColorP X0Y1_淫タトゥ_タトゥ左2CP;

    	public ColorP X0Y1_淫タトゥ_タトゥ右2CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字a_枠CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字b_枠CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字c_枠CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字d_枠CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字e_枠CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2CP;

    	public ColorP X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3CP;

    	public ColorP X0Y1_悪タトゥ1_タトゥ1CP;

    	public ColorP X0Y1_悪タトゥ1_タトゥ2CP;

    	public ColorP X0Y1_悪タトゥ2_逆十字_逆十字1CP;

    	public ColorP X0Y1_悪タトゥ2_逆十字_逆十字2CP;

    	public ColorP X0Y1_鱗_鱗1CP;

    	public ColorP X0Y1_鱗_鱗2CP;

    	public ColorP X0Y1_鱗_鱗3CP;

    	public ColorP X0Y1_鱗_鱗4CP;

    	public ColorP X0Y1_紋柄_紋1CP;

    	public ColorP X0Y1_紋柄_紋2CP;

    	public ColorP X0Y1_紋柄_紋3CP;

    	public ColorP X0Y1_紋柄_紋4CP;

    	public ColorP X0Y1_植性_通常_葉3CP;

    	public ColorP X0Y1_植性_通常_葉2CP;

    	public ColorP X0Y1_植性_通常_葉1CP;

    	public ColorP X0Y1_植性_欠損_葉3CP;

    	public ColorP X0Y1_植性_欠損_葉2CP;

    	public ColorP X0Y1_植性_欠損_葉1CP;

    	public ColorP X0Y1_虫性_器官1CP;

    	public ColorP X0Y1_虫性_器官2CP;

    	public ColorP X0Y1_傷I1CP;

    	public ColorP X0Y1_傷I2CP;

    	public ColorP X0Y1_傷I3CP;

    	public ColorP X0Y1_傷I4CP;

    	public ColorP X0Y1_傷XCP;

    	public ColorP X0Y1_ハイライト1CP;

    	public ColorP X0Y1_ハイライト2CP;

    	public ColorP X0Y1_パンストCP;

    	public ColorP X0Y1_パンスト_ハイライトCP;

    	public ColorP X0Y1_ニーハイ_ニーハイ1CP;

    	public ColorP X0Y1_ニーハイ_ニーハイ2CP;

    	public ColorP X0Y1_ニーハイ_ハイライトCP;

    	public ColorP X0Y2_腿CP;

    	public ColorP X0Y2_筋CP;

    	public ColorP X0Y2_獣性_獣毛1CP;

    	public ColorP X0Y2_獣性_獣毛2CP;

    	public ColorP X0Y2_淫タトゥ_ハート_タトゥ左CP;

    	public ColorP X0Y2_淫タトゥ_ハート_タトゥ右CP;

    	public ColorP X0Y2_淫タトゥ_タトゥ右1CP;

    	public ColorP X0Y2_淫タトゥ_タトゥ右2CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字b_枠CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字c_枠CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字d_枠CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字e_枠CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字a_枠CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1CP;

    	public ColorP X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2CP;

    	public ColorP X0Y2_悪タトゥ1_タトゥ1CP;

    	public ColorP X0Y2_悪タトゥ1_タトゥ2CP;

    	public ColorP X0Y2_悪タトゥ2_逆十字_逆十字1CP;

    	public ColorP X0Y2_悪タトゥ2_逆十字_逆十字2CP;

    	public ColorP X0Y2_植性_通常_葉3CP;

    	public ColorP X0Y2_植性_通常_葉2CP;

    	public ColorP X0Y2_植性_通常_葉1CP;

    	public ColorP X0Y2_植性_欠損_葉3CP;

    	public ColorP X0Y2_植性_欠損_葉2CP;

    	public ColorP X0Y2_植性_欠損_葉1CP;

    	public ColorP X0Y2_傷I1CP;

    	public ColorP X0Y2_傷I2CP;

    	public ColorP X0Y2_傷I3CP;

    	public ColorP X0Y2_ハイライト1CP;

    	public ColorP X0Y2_ハイライト2CP;

    	public ColorP X0Y2_パンストCP;

    	public ColorP X0Y2_パンスト_ハイライトCP;

    	public ColorP X0Y2_ニーハイ_ニーハイ1CP;

    	public ColorP X0Y2_ニーハイ_ニーハイ2CP;

    	public ColorP X0Y2_ニーハイ_ハイライトCP;

    	public ColorP X0Y3_腿CP;

    	public ColorP X0Y3_筋CP;

    	public ColorP X0Y3_獣性_獣毛1CP;

    	public ColorP X0Y3_獣性_獣毛2CP;

    	public ColorP X0Y3_淫タトゥ_タトゥ左1CP;

    	public ColorP X0Y3_淫タトゥ_タトゥ右1CP;

    	public ColorP X0Y3_淫タトゥ_タトゥ左2CP;

    	public ColorP X0Y3_淫タトゥ_タトゥ右2CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字c_枠CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字d_枠CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字e_枠CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字a_枠CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字b_枠CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1CP;

    	public ColorP X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2CP;

    	public ColorP X0Y3_悪タトゥ1_タトゥ1CP;

    	public ColorP X0Y3_悪タトゥ1_タトゥ2CP;

    	public ColorP X0Y3_悪タトゥ2_逆十字_逆十字1CP;

    	public ColorP X0Y3_悪タトゥ2_逆十字_逆十字2CP;

    	public ColorP X0Y3_鱗_鱗1CP;

    	public ColorP X0Y3_鱗_鱗2CP;

    	public ColorP X0Y3_鱗_鱗3CP;

    	public ColorP X0Y3_鱗_鱗4CP;

    	public ColorP X0Y3_紋柄_紋1CP;

    	public ColorP X0Y3_紋柄_紋2CP;

    	public ColorP X0Y3_紋柄_紋3CP;

    	public ColorP X0Y3_紋柄_紋4CP;

    	public ColorP X0Y3_植性_通常_葉3CP;

    	public ColorP X0Y3_植性_通常_葉2CP;

    	public ColorP X0Y3_植性_通常_葉1CP;

    	public ColorP X0Y3_植性_欠損_葉3CP;

    	public ColorP X0Y3_植性_欠損_葉2CP;

    	public ColorP X0Y3_植性_欠損_葉1CP;

    	public ColorP X0Y3_傷I1CP;

    	public ColorP X0Y3_傷I2CP;

    	public ColorP X0Y3_傷I3CP;

    	public ColorP X0Y3_傷XCP;

    	public ColorP X0Y3_ハイライト1CP;

    	public ColorP X0Y3_ハイライト2CP;

    	public ColorP X0Y3_パンストCP;

    	public ColorP X0Y3_パンスト_ハイライトCP;

    	public ColorP X0Y3_ニーハイ_ニーハイ1CP;

    	public ColorP X0Y3_ニーハイ_ニーハイ2CP;

    	public ColorP X0Y3_ニーハイ_ハイライトCP;

    	public ColorP X0Y4_腿CP;

    	public ColorP X0Y4_筋CP;

    	public ColorP X0Y4_獣性_獣毛1CP;

    	public ColorP X0Y4_獣性_獣毛2CP;

    	public ColorP X0Y4_淫タトゥ_タトゥ左1CP;

    	public ColorP X0Y4_淫タトゥ_タトゥ右1CP;

    	public ColorP X0Y4_淫タトゥ_タトゥ左2CP;

    	public ColorP X0Y4_淫タトゥ_タトゥ右2CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字d_枠CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字e_枠CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字a_枠CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字b_枠CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字c_枠CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1CP;

    	public ColorP X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2CP;

    	public ColorP X0Y4_悪タトゥ1_タトゥ1CP;

    	public ColorP X0Y4_悪タトゥ1_タトゥ2CP;

    	public ColorP X0Y4_鱗_鱗1CP;

    	public ColorP X0Y4_鱗_鱗2CP;

    	public ColorP X0Y4_鱗_鱗3CP;

    	public ColorP X0Y4_鱗_鱗4CP;

    	public ColorP X0Y4_紋柄_紋1CP;

    	public ColorP X0Y4_紋柄_紋2CP;

    	public ColorP X0Y4_紋柄_紋3CP;

    	public ColorP X0Y4_紋柄_紋4CP;

    	public ColorP X0Y4_植性_通常_葉3CP;

    	public ColorP X0Y4_植性_通常_葉2CP;

    	public ColorP X0Y4_植性_通常_葉1CP;

    	public ColorP X0Y4_植性_欠損_葉3CP;

    	public ColorP X0Y4_植性_欠損_葉2CP;

    	public ColorP X0Y4_植性_欠損_葉1CP;

    	public ColorP X0Y4_傷I1CP;

    	public ColorP X0Y4_傷XCP;

    	public ColorP X0Y4_ハイライト1CP;

    	public ColorP X0Y4_ハイライト2CP;

    	public ColorP X0Y4_パンストCP;

    	public ColorP X0Y4_パンスト_ハイライトCP;

    	public ColorP X0Y4_ニーハイ_ニーハイ1CP;

    	public ColorP X0Y4_ニーハイ_ニーハイ2CP;

    	public ColorP X0Y4_ニーハイ_ハイライトCP;

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
    			筋_表示 = 筋肉_;
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

    	public bool 腿_表示
    	{
    		get
    		{
    			return X0Y0_腿.Dra;
    		}
    		set
    		{
    			X0Y0_腿.Dra = value;
    			X0Y1_腿.Dra = value;
    			X0Y2_腿.Dra = value;
    			X0Y3_腿.Dra = value;
    			X0Y4_腿.Dra = value;
    			X0Y0_腿.Hit = value;
    			X0Y1_腿.Hit = value;
    			X0Y2_腿.Hit = value;
    			X0Y3_腿.Hit = value;
    			X0Y4_腿.Hit = value;
    		}
    	}

    	public bool 筋_表示
    	{
    		get
    		{
    			return X0Y0_筋.Dra;
    		}
    		set
    		{
    			X0Y0_筋.Dra = value;
    			X0Y1_筋.Dra = value;
    			X0Y2_筋.Dra = value;
    			X0Y3_筋.Dra = value;
    			X0Y4_筋.Dra = value;
    			X0Y0_筋.Hit = value;
    			X0Y1_筋.Hit = value;
    			X0Y2_筋.Hit = value;
    			X0Y3_筋.Hit = value;
    			X0Y4_筋.Hit = value;
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
    			X0Y1_獣性_獣毛1.Dra = value;
    			X0Y2_獣性_獣毛1.Dra = value;
    			X0Y3_獣性_獣毛1.Dra = value;
    			X0Y4_獣性_獣毛1.Dra = value;
    			X0Y0_獣性_獣毛1.Hit = value;
    			X0Y1_獣性_獣毛1.Hit = value;
    			X0Y2_獣性_獣毛1.Hit = value;
    			X0Y3_獣性_獣毛1.Hit = value;
    			X0Y4_獣性_獣毛1.Hit = value;
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
    			X0Y1_獣性_獣毛2.Dra = value;
    			X0Y2_獣性_獣毛2.Dra = value;
    			X0Y3_獣性_獣毛2.Dra = value;
    			X0Y4_獣性_獣毛2.Dra = value;
    			X0Y0_獣性_獣毛2.Hit = value;
    			X0Y1_獣性_獣毛2.Hit = value;
    			X0Y2_獣性_獣毛2.Hit = value;
    			X0Y3_獣性_獣毛2.Hit = value;
    			X0Y4_獣性_獣毛2.Hit = value;
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
    			X0Y1_淫タトゥ_ハート_タトゥ左.Dra = value;
    			X0Y2_淫タトゥ_ハート_タトゥ左.Dra = value;
    			X0Y0_淫タトゥ_ハート_タトゥ左.Hit = value;
    			X0Y1_淫タトゥ_ハート_タトゥ左.Hit = value;
    			X0Y2_淫タトゥ_ハート_タトゥ左.Hit = value;
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
    			X0Y1_淫タトゥ_ハート_タトゥ右.Dra = value;
    			X0Y2_淫タトゥ_ハート_タトゥ右.Dra = value;
    			X0Y0_淫タトゥ_ハート_タトゥ右.Hit = value;
    			X0Y1_淫タトゥ_ハート_タトゥ右.Hit = value;
    			X0Y2_淫タトゥ_ハート_タトゥ右.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_タトゥ左1_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_タトゥ左1.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_タトゥ左1.Dra = value;
    			X0Y1_淫タトゥ_タトゥ左1.Dra = value;
    			X0Y3_淫タトゥ_タトゥ左1.Dra = value;
    			X0Y4_淫タトゥ_タトゥ左1.Dra = value;
    			X0Y0_淫タトゥ_タトゥ左1.Hit = value;
    			X0Y1_淫タトゥ_タトゥ左1.Hit = value;
    			X0Y3_淫タトゥ_タトゥ左1.Hit = value;
    			X0Y4_淫タトゥ_タトゥ左1.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_タトゥ右1_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_タトゥ右1.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_タトゥ右1.Dra = value;
    			X0Y1_淫タトゥ_タトゥ右1.Dra = value;
    			X0Y2_淫タトゥ_タトゥ右1.Dra = value;
    			X0Y3_淫タトゥ_タトゥ右1.Dra = value;
    			X0Y4_淫タトゥ_タトゥ右1.Dra = value;
    			X0Y0_淫タトゥ_タトゥ右1.Hit = value;
    			X0Y1_淫タトゥ_タトゥ右1.Hit = value;
    			X0Y2_淫タトゥ_タトゥ右1.Hit = value;
    			X0Y3_淫タトゥ_タトゥ右1.Hit = value;
    			X0Y4_淫タトゥ_タトゥ右1.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_タトゥ左2_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_タトゥ左2.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_タトゥ左2.Dra = value;
    			X0Y1_淫タトゥ_タトゥ左2.Dra = value;
    			X0Y3_淫タトゥ_タトゥ左2.Dra = value;
    			X0Y4_淫タトゥ_タトゥ左2.Dra = value;
    			X0Y0_淫タトゥ_タトゥ左2.Hit = value;
    			X0Y1_淫タトゥ_タトゥ左2.Hit = value;
    			X0Y3_淫タトゥ_タトゥ左2.Hit = value;
    			X0Y4_淫タトゥ_タトゥ左2.Hit = value;
    		}
    	}

    	public bool 淫タトゥ_タトゥ右2_表示
    	{
    		get
    		{
    			return X0Y0_淫タトゥ_タトゥ右2.Dra;
    		}
    		set
    		{
    			X0Y0_淫タトゥ_タトゥ右2.Dra = value;
    			X0Y1_淫タトゥ_タトゥ右2.Dra = value;
    			X0Y2_淫タトゥ_タトゥ右2.Dra = value;
    			X0Y3_淫タトゥ_タトゥ右2.Dra = value;
    			X0Y4_淫タトゥ_タトゥ右2.Dra = value;
    			X0Y0_淫タトゥ_タトゥ右2.Hit = value;
    			X0Y1_淫タトゥ_タトゥ右2.Hit = value;
    			X0Y2_淫タトゥ_タトゥ右2.Hit = value;
    			X0Y3_淫タトゥ_タトゥ右2.Hit = value;
    			X0Y4_淫タトゥ_タトゥ右2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字a_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字a_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字a_枠.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字a_枠.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字a_枠.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字a_枠.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字a_枠.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字a_枠.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字a_枠.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字a_枠.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字a_枠.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字a_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字a_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字a_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字b_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字b_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字b_枠.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字b_枠.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字b_枠.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字b_枠.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字b_枠.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字b_枠.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字b_枠.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字b_枠.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字b_枠.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字b_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字b_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字b_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字c_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字c_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字c_枠.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字c_枠.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字c_枠.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字c_枠.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字c_枠.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字c_枠.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字c_枠.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字c_枠.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字c_枠.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字c_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字c_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字c_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字d_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字d_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字d_枠.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字d_枠.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字d_枠.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字d_枠.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字d_枠.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字d_枠.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字d_枠.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字d_枠.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字d_枠.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字d_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字d_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字d_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字e_枠_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字e_枠.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字e_枠.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字e_枠.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字e_枠.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字e_枠.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字e_枠.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字e_枠.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字e_枠.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字e_枠.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字e_枠.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字e_枠.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字e_文字タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字e_文字タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_文字_文字e_文字タトゥ3_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3.Dra = value;
    			X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3.Dra = value;
    			X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3.Dra = value;
    			X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3.Dra = value;
    			X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3.Dra = value;
    			X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3.Hit = value;
    			X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3.Hit = value;
    			X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3.Hit = value;
    			X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3.Hit = value;
    			X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_タトゥ1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_タトゥ1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_タトゥ1.Dra = value;
    			X0Y1_悪タトゥ1_タトゥ1.Dra = value;
    			X0Y2_悪タトゥ1_タトゥ1.Dra = value;
    			X0Y3_悪タトゥ1_タトゥ1.Dra = value;
    			X0Y4_悪タトゥ1_タトゥ1.Dra = value;
    			X0Y0_悪タトゥ1_タトゥ1.Hit = value;
    			X0Y1_悪タトゥ1_タトゥ1.Hit = value;
    			X0Y2_悪タトゥ1_タトゥ1.Hit = value;
    			X0Y3_悪タトゥ1_タトゥ1.Hit = value;
    			X0Y4_悪タトゥ1_タトゥ1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ1_タトゥ2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ1_タトゥ2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ1_タトゥ2.Dra = value;
    			X0Y1_悪タトゥ1_タトゥ2.Dra = value;
    			X0Y2_悪タトゥ1_タトゥ2.Dra = value;
    			X0Y3_悪タトゥ1_タトゥ2.Dra = value;
    			X0Y4_悪タトゥ1_タトゥ2.Dra = value;
    			X0Y0_悪タトゥ1_タトゥ2.Hit = value;
    			X0Y1_悪タトゥ1_タトゥ2.Hit = value;
    			X0Y2_悪タトゥ1_タトゥ2.Hit = value;
    			X0Y3_悪タトゥ1_タトゥ2.Hit = value;
    			X0Y4_悪タトゥ1_タトゥ2.Hit = value;
    		}
    	}

    	public bool 悪タトゥ2_逆十字_逆十字1_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ2_逆十字_逆十字1.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ2_逆十字_逆十字1.Dra = value;
    			X0Y1_悪タトゥ2_逆十字_逆十字1.Dra = value;
    			X0Y2_悪タトゥ2_逆十字_逆十字1.Dra = value;
    			X0Y3_悪タトゥ2_逆十字_逆十字1.Dra = value;
    			X0Y0_悪タトゥ2_逆十字_逆十字1.Hit = value;
    			X0Y1_悪タトゥ2_逆十字_逆十字1.Hit = value;
    			X0Y2_悪タトゥ2_逆十字_逆十字1.Hit = value;
    			X0Y3_悪タトゥ2_逆十字_逆十字1.Hit = value;
    		}
    	}

    	public bool 悪タトゥ2_逆十字_逆十字2_表示
    	{
    		get
    		{
    			return X0Y0_悪タトゥ2_逆十字_逆十字2.Dra;
    		}
    		set
    		{
    			X0Y0_悪タトゥ2_逆十字_逆十字2.Dra = value;
    			X0Y1_悪タトゥ2_逆十字_逆十字2.Dra = value;
    			X0Y2_悪タトゥ2_逆十字_逆十字2.Dra = value;
    			X0Y3_悪タトゥ2_逆十字_逆十字2.Dra = value;
    			X0Y0_悪タトゥ2_逆十字_逆十字2.Hit = value;
    			X0Y1_悪タトゥ2_逆十字_逆十字2.Hit = value;
    			X0Y2_悪タトゥ2_逆十字_逆十字2.Hit = value;
    			X0Y3_悪タトゥ2_逆十字_逆十字2.Hit = value;
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
    			X0Y1_鱗_鱗1.Dra = value;
    			X0Y3_鱗_鱗1.Dra = value;
    			X0Y4_鱗_鱗1.Dra = value;
    			X0Y0_竜性_鱗1.Hit = value;
    			X0Y1_鱗_鱗1.Hit = value;
    			X0Y3_鱗_鱗1.Hit = value;
    			X0Y4_鱗_鱗1.Hit = value;
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
    			X0Y1_鱗_鱗2.Dra = value;
    			X0Y3_鱗_鱗2.Dra = value;
    			X0Y4_鱗_鱗2.Dra = value;
    			X0Y0_竜性_鱗2.Hit = value;
    			X0Y1_鱗_鱗2.Hit = value;
    			X0Y3_鱗_鱗2.Hit = value;
    			X0Y4_鱗_鱗2.Hit = value;
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
    			X0Y1_鱗_鱗3.Dra = value;
    			X0Y3_鱗_鱗3.Dra = value;
    			X0Y4_鱗_鱗3.Dra = value;
    			X0Y0_竜性_鱗3.Hit = value;
    			X0Y1_鱗_鱗3.Hit = value;
    			X0Y3_鱗_鱗3.Hit = value;
    			X0Y4_鱗_鱗3.Hit = value;
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
    			X0Y1_鱗_鱗4.Dra = value;
    			X0Y3_鱗_鱗4.Dra = value;
    			X0Y4_鱗_鱗4.Dra = value;
    			X0Y0_竜性_鱗4.Hit = value;
    			X0Y1_鱗_鱗4.Hit = value;
    			X0Y3_鱗_鱗4.Hit = value;
    			X0Y4_鱗_鱗4.Hit = value;
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
    			X0Y1_紋柄_紋1.Dra = value;
    			X0Y3_紋柄_紋1.Dra = value;
    			X0Y4_紋柄_紋1.Dra = value;
    			X0Y0_紋柄_紋1.Hit = value;
    			X0Y1_紋柄_紋1.Hit = value;
    			X0Y3_紋柄_紋1.Hit = value;
    			X0Y4_紋柄_紋1.Hit = value;
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
    			X0Y1_紋柄_紋2.Dra = value;
    			X0Y3_紋柄_紋2.Dra = value;
    			X0Y4_紋柄_紋2.Dra = value;
    			X0Y0_紋柄_紋2.Hit = value;
    			X0Y1_紋柄_紋2.Hit = value;
    			X0Y3_紋柄_紋2.Hit = value;
    			X0Y4_紋柄_紋2.Hit = value;
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
    			X0Y1_紋柄_紋3.Dra = value;
    			X0Y3_紋柄_紋3.Dra = value;
    			X0Y4_紋柄_紋3.Dra = value;
    			X0Y0_紋柄_紋3.Hit = value;
    			X0Y1_紋柄_紋3.Hit = value;
    			X0Y3_紋柄_紋3.Hit = value;
    			X0Y4_紋柄_紋3.Hit = value;
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
    			X0Y1_紋柄_紋4.Dra = value;
    			X0Y3_紋柄_紋4.Dra = value;
    			X0Y4_紋柄_紋4.Dra = value;
    			X0Y0_紋柄_紋4.Hit = value;
    			X0Y1_紋柄_紋4.Hit = value;
    			X0Y3_紋柄_紋4.Hit = value;
    			X0Y4_紋柄_紋4.Hit = value;
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
    			X0Y1_植性_通常_葉3.Dra = value;
    			X0Y2_植性_通常_葉3.Dra = value;
    			X0Y3_植性_通常_葉3.Dra = value;
    			X0Y4_植性_通常_葉3.Dra = value;
    			X0Y0_植性_通常_葉3.Hit = value;
    			X0Y1_植性_通常_葉3.Hit = value;
    			X0Y2_植性_通常_葉3.Hit = value;
    			X0Y3_植性_通常_葉3.Hit = value;
    			X0Y4_植性_通常_葉3.Hit = value;
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
    			X0Y1_植性_通常_葉2.Dra = value;
    			X0Y2_植性_通常_葉2.Dra = value;
    			X0Y3_植性_通常_葉2.Dra = value;
    			X0Y4_植性_通常_葉2.Dra = value;
    			X0Y0_植性_通常_葉2.Hit = value;
    			X0Y1_植性_通常_葉2.Hit = value;
    			X0Y2_植性_通常_葉2.Hit = value;
    			X0Y3_植性_通常_葉2.Hit = value;
    			X0Y4_植性_通常_葉2.Hit = value;
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
    			X0Y1_植性_通常_葉1.Dra = value;
    			X0Y2_植性_通常_葉1.Dra = value;
    			X0Y3_植性_通常_葉1.Dra = value;
    			X0Y4_植性_通常_葉1.Dra = value;
    			X0Y0_植性_通常_葉1.Hit = value;
    			X0Y1_植性_通常_葉1.Hit = value;
    			X0Y2_植性_通常_葉1.Hit = value;
    			X0Y3_植性_通常_葉1.Hit = value;
    			X0Y4_植性_通常_葉1.Hit = value;
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
    			X0Y1_植性_欠損_葉3.Dra = value;
    			X0Y2_植性_欠損_葉3.Dra = value;
    			X0Y3_植性_欠損_葉3.Dra = value;
    			X0Y4_植性_欠損_葉3.Dra = value;
    			X0Y0_植性_欠損_葉3.Hit = value;
    			X0Y1_植性_欠損_葉3.Hit = value;
    			X0Y2_植性_欠損_葉3.Hit = value;
    			X0Y3_植性_欠損_葉3.Hit = value;
    			X0Y4_植性_欠損_葉3.Hit = value;
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
    			X0Y1_植性_欠損_葉2.Dra = value;
    			X0Y2_植性_欠損_葉2.Dra = value;
    			X0Y3_植性_欠損_葉2.Dra = value;
    			X0Y4_植性_欠損_葉2.Dra = value;
    			X0Y0_植性_欠損_葉2.Hit = value;
    			X0Y1_植性_欠損_葉2.Hit = value;
    			X0Y2_植性_欠損_葉2.Hit = value;
    			X0Y3_植性_欠損_葉2.Hit = value;
    			X0Y4_植性_欠損_葉2.Hit = value;
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
    			X0Y1_植性_欠損_葉1.Dra = value;
    			X0Y2_植性_欠損_葉1.Dra = value;
    			X0Y3_植性_欠損_葉1.Dra = value;
    			X0Y4_植性_欠損_葉1.Dra = value;
    			X0Y0_植性_欠損_葉1.Hit = value;
    			X0Y1_植性_欠損_葉1.Hit = value;
    			X0Y2_植性_欠損_葉1.Hit = value;
    			X0Y3_植性_欠損_葉1.Hit = value;
    			X0Y4_植性_欠損_葉1.Hit = value;
    		}
    	}

    	public bool 虫性_器官1_表示
    	{
    		get
    		{
    			return X0Y0_虫性_器官1.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_器官1.Dra = value;
    			X0Y1_虫性_器官1.Dra = value;
    			X0Y0_虫性_器官1.Hit = value;
    			X0Y1_虫性_器官1.Hit = value;
    		}
    	}

    	public bool 虫性_器官2_表示
    	{
    		get
    		{
    			return X0Y0_虫性_器官2.Dra;
    		}
    		set
    		{
    			X0Y0_虫性_器官2.Dra = value;
    			X0Y1_虫性_器官2.Dra = value;
    			X0Y0_虫性_器官2.Hit = value;
    			X0Y1_虫性_器官2.Hit = value;
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
    			X0Y1_傷I1.Dra = value;
    			X0Y2_傷I1.Dra = value;
    			X0Y3_傷I1.Dra = value;
    			X0Y4_傷I1.Dra = value;
    			X0Y0_傷I1.Hit = value;
    			X0Y1_傷I1.Hit = value;
    			X0Y2_傷I1.Hit = value;
    			X0Y3_傷I1.Hit = value;
    			X0Y4_傷I1.Hit = value;
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
    			X0Y1_傷I2.Dra = value;
    			X0Y2_傷I2.Dra = value;
    			X0Y3_傷I2.Dra = value;
    			X0Y0_傷I2.Hit = value;
    			X0Y1_傷I2.Hit = value;
    			X0Y2_傷I2.Hit = value;
    			X0Y3_傷I2.Hit = value;
    		}
    	}

    	public bool 傷I3_表示
    	{
    		get
    		{
    			return X0Y0_傷I3.Dra;
    		}
    		set
    		{
    			X0Y0_傷I3.Dra = value;
    			X0Y1_傷I3.Dra = value;
    			X0Y2_傷I3.Dra = value;
    			X0Y3_傷I3.Dra = value;
    			X0Y0_傷I3.Hit = value;
    			X0Y1_傷I3.Hit = value;
    			X0Y2_傷I3.Hit = value;
    			X0Y3_傷I3.Hit = value;
    		}
    	}

    	public bool 傷I4_表示
    	{
    		get
    		{
    			return X0Y0_傷I4.Dra;
    		}
    		set
    		{
    			X0Y0_傷I4.Dra = value;
    			X0Y1_傷I4.Dra = value;
    			X0Y0_傷I4.Hit = value;
    			X0Y1_傷I4.Hit = value;
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
    			X0Y1_傷X.Dra = value;
    			X0Y3_傷X.Dra = value;
    			X0Y4_傷X.Dra = value;
    			X0Y0_傷X.Hit = value;
    			X0Y1_傷X.Hit = value;
    			X0Y3_傷X.Hit = value;
    			X0Y4_傷X.Hit = value;
    		}
    	}

    	public bool ハイライト1_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト1.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト1.Dra = value;
    			X0Y1_ハイライト1.Dra = value;
    			X0Y2_ハイライト1.Dra = value;
    			X0Y3_ハイライト1.Dra = value;
    			X0Y4_ハイライト1.Dra = value;
    			X0Y0_ハイライト1.Hit = value;
    			X0Y1_ハイライト1.Hit = value;
    			X0Y2_ハイライト1.Hit = value;
    			X0Y3_ハイライト1.Hit = value;
    			X0Y4_ハイライト1.Hit = value;
    		}
    	}

    	public bool ハイライト2_表示
    	{
    		get
    		{
    			return X0Y0_ハイライト2.Dra;
    		}
    		set
    		{
    			X0Y0_ハイライト2.Dra = value;
    			X0Y1_ハイライト2.Dra = value;
    			X0Y2_ハイライト2.Dra = value;
    			X0Y3_ハイライト2.Dra = value;
    			X0Y4_ハイライト2.Dra = value;
    			X0Y0_ハイライト2.Hit = value;
    			X0Y1_ハイライト2.Hit = value;
    			X0Y2_ハイライト2.Hit = value;
    			X0Y3_ハイライト2.Hit = value;
    			X0Y4_ハイライト2.Hit = value;
    		}
    	}

    	public bool パンスト_表示
    	{
    		get
    		{
    			return X0Y0_パンスト.Dra;
    		}
    		set
    		{
    			X0Y0_パンスト.Dra = value;
    			X0Y1_パンスト.Dra = value;
    			X0Y2_パンスト.Dra = value;
    			X0Y3_パンスト.Dra = value;
    			X0Y4_パンスト.Dra = value;
    			X0Y0_パンスト.Hit = value;
    			X0Y1_パンスト.Hit = value;
    			X0Y2_パンスト.Hit = value;
    			X0Y3_パンスト.Hit = value;
    			X0Y4_パンスト.Hit = value;
    		}
    	}

    	public bool パンスト_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_パンスト_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_パンスト_ハイライト.Dra = value;
    			X0Y1_パンスト_ハイライト.Dra = value;
    			X0Y2_パンスト_ハイライト.Dra = value;
    			X0Y3_パンスト_ハイライト.Dra = value;
    			X0Y4_パンスト_ハイライト.Dra = value;
    			X0Y0_パンスト_ハイライト.Hit = value;
    			X0Y1_パンスト_ハイライト.Hit = value;
    			X0Y2_パンスト_ハイライト.Hit = value;
    			X0Y3_パンスト_ハイライト.Hit = value;
    			X0Y4_パンスト_ハイライト.Hit = value;
    		}
    	}

    	public bool ニーハイ_ニーハイ1_表示
    	{
    		get
    		{
    			return X0Y0_ニーハイ_ニーハイ1.Dra;
    		}
    		set
    		{
    			X0Y0_ニーハイ_ニーハイ1.Dra = value;
    			X0Y1_ニーハイ_ニーハイ1.Dra = value;
    			X0Y2_ニーハイ_ニーハイ1.Dra = value;
    			X0Y3_ニーハイ_ニーハイ1.Dra = value;
    			X0Y4_ニーハイ_ニーハイ1.Dra = value;
    			X0Y0_ニーハイ_ニーハイ1.Hit = value;
    			X0Y1_ニーハイ_ニーハイ1.Hit = value;
    			X0Y2_ニーハイ_ニーハイ1.Hit = value;
    			X0Y3_ニーハイ_ニーハイ1.Hit = value;
    			X0Y4_ニーハイ_ニーハイ1.Hit = value;
    		}
    	}

    	public bool ニーハイ_ニーハイ2_表示
    	{
    		get
    		{
    			return X0Y0_ニーハイ_ニーハイ2.Dra;
    		}
    		set
    		{
    			X0Y0_ニーハイ_ニーハイ2.Dra = value;
    			X0Y1_ニーハイ_ニーハイ2.Dra = value;
    			X0Y2_ニーハイ_ニーハイ2.Dra = value;
    			X0Y3_ニーハイ_ニーハイ2.Dra = value;
    			X0Y4_ニーハイ_ニーハイ2.Dra = value;
    			X0Y0_ニーハイ_ニーハイ2.Hit = value;
    			X0Y1_ニーハイ_ニーハイ2.Hit = value;
    			X0Y2_ニーハイ_ニーハイ2.Hit = value;
    			X0Y3_ニーハイ_ニーハイ2.Hit = value;
    			X0Y4_ニーハイ_ニーハイ2.Hit = value;
    		}
    	}

    	public bool ニーハイ_ハイライト_表示
    	{
    		get
    		{
    			return X0Y0_ニーハイ_ハイライト.Dra;
    		}
    		set
    		{
    			X0Y0_ニーハイ_ハイライト.Dra = value;
    			X0Y1_ニーハイ_ハイライト.Dra = value;
    			X0Y2_ニーハイ_ハイライト.Dra = value;
    			X0Y3_ニーハイ_ハイライト.Dra = value;
    			X0Y4_ニーハイ_ハイライト.Dra = value;
    			X0Y0_ニーハイ_ハイライト.Hit = value;
    			X0Y1_ニーハイ_ハイライト.Hit = value;
    			X0Y2_ニーハイ_ハイライト.Hit = value;
    			X0Y3_ニーハイ_ハイライト.Hit = value;
    			X0Y4_ニーハイ_ハイライト.Hit = value;
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
    				植性_通常_葉3_表示 = false;
    				植性_通常_葉3_表示 = false;
    				植性_通常_葉3_表示 = false;
    				植性_通常_葉3_表示 = false;
    				植性_欠損_葉3_表示 = value;
    				植性_欠損_葉3_表示 = value;
    				植性_欠損_葉3_表示 = value;
    				植性_欠損_葉3_表示 = value;
    				植性_欠損_葉3_表示 = value;
    			}
    			else
    			{
    				植性_通常_葉3_表示 = value;
    				植性_通常_葉3_表示 = value;
    				植性_通常_葉3_表示 = value;
    				植性_通常_葉3_表示 = value;
    				植性_通常_葉3_表示 = value;
    				植性_欠損_葉3_表示 = false;
    				植性_欠損_葉3_表示 = false;
    				植性_欠損_葉3_表示 = false;
    				植性_欠損_葉3_表示 = false;
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
    				植性_通常_葉2_表示 = false;
    				植性_通常_葉2_表示 = false;
    				植性_通常_葉2_表示 = false;
    				植性_通常_葉2_表示 = false;
    				植性_欠損_葉2_表示 = value;
    				植性_欠損_葉2_表示 = value;
    				植性_欠損_葉2_表示 = value;
    				植性_欠損_葉2_表示 = value;
    				植性_欠損_葉2_表示 = value;
    			}
    			else
    			{
    				植性_通常_葉2_表示 = value;
    				植性_通常_葉2_表示 = value;
    				植性_通常_葉2_表示 = value;
    				植性_通常_葉2_表示 = value;
    				植性_通常_葉2_表示 = value;
    				植性_欠損_葉2_表示 = false;
    				植性_欠損_葉2_表示 = false;
    				植性_欠損_葉2_表示 = false;
    				植性_欠損_葉2_表示 = false;
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
    				植性_通常_葉1_表示 = false;
    				植性_通常_葉1_表示 = false;
    				植性_通常_葉1_表示 = false;
    				植性_通常_葉1_表示 = false;
    				植性_欠損_葉1_表示 = value;
    				植性_欠損_葉1_表示 = value;
    				植性_欠損_葉1_表示 = value;
    				植性_欠損_葉1_表示 = value;
    				植性_欠損_葉1_表示 = value;
    			}
    			else
    			{
    				植性_通常_葉1_表示 = value;
    				植性_通常_葉1_表示 = value;
    				植性_通常_葉1_表示 = value;
    				植性_通常_葉1_表示 = value;
    				植性_通常_葉1_表示 = value;
    				植性_欠損_葉1_表示 = false;
    				植性_欠損_葉1_表示 = false;
    				植性_欠損_葉1_表示 = false;
    				植性_欠損_葉1_表示 = false;
    				植性_欠損_葉1_表示 = false;
    			}
    		}
    	}

    	public bool ハイライト表示
    	{
    		get
    		{
    			return ハイライト1_表示;
    		}
    		set
    		{
    			ハイライト1_表示 = value;
    			ハイライト2_表示 = value;
    		}
    	}

    	public double 筋肉濃度
    	{
    		get
    		{
    			return 筋CD.不透明度;
    		}
    		set
    		{
    			筋CD.不透明度 = value;
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

    	public double 傷I3濃度
    	{
    		get
    		{
    			return 傷I3CD.不透明度;
    		}
    		set
    		{
    			傷I3CD.不透明度 = value;
    		}
    	}

    	public double 傷I4濃度
    	{
    		get
    		{
    			return 傷I4CD.不透明度;
    		}
    		set
    		{
    			傷I4CD.不透明度 = value;
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
    			return ハイライト1CD.不透明度;
    		}
    		set
    		{
    			ハイライト1CD.不透明度 = value;
    			ハイライト2CD.不透明度 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 腿_表示;
    		}
    		set
    		{
    			腿_表示 = value;
    			筋_表示 = value;
    			獣性_獣毛1_表示 = value;
    			獣性_獣毛2_表示 = value;
    			淫タトゥ_ハート_タトゥ左_表示 = value;
    			淫タトゥ_ハート_タトゥ右_表示 = value;
    			淫タトゥ_タトゥ左1_表示 = value;
    			淫タトゥ_タトゥ右1_表示 = value;
    			淫タトゥ_タトゥ左2_表示 = value;
    			淫タトゥ_タトゥ右2_表示 = value;
    			悪タトゥ1_文字_文字a_枠_表示 = value;
    			悪タトゥ1_文字_文字a_文字タトゥ1_表示 = value;
    			悪タトゥ1_文字_文字a_文字タトゥ2_表示 = value;
    			悪タトゥ1_文字_文字b_枠_表示 = value;
    			悪タトゥ1_文字_文字b_文字タトゥ1_表示 = value;
    			悪タトゥ1_文字_文字b_文字タトゥ2_表示 = value;
    			悪タトゥ1_文字_文字c_枠_表示 = value;
    			悪タトゥ1_文字_文字c_文字タトゥ1_表示 = value;
    			悪タトゥ1_文字_文字c_文字タトゥ2_表示 = value;
    			悪タトゥ1_文字_文字d_枠_表示 = value;
    			悪タトゥ1_文字_文字d_文字タトゥ1_表示 = value;
    			悪タトゥ1_文字_文字d_文字タトゥ2_表示 = value;
    			悪タトゥ1_文字_文字e_枠_表示 = value;
    			悪タトゥ1_文字_文字e_文字タトゥ1_表示 = value;
    			悪タトゥ1_文字_文字e_文字タトゥ2_表示 = value;
    			悪タトゥ1_文字_文字e_文字タトゥ3_表示 = value;
    			悪タトゥ1_タトゥ1_表示 = value;
    			悪タトゥ1_タトゥ2_表示 = value;
    			悪タトゥ2_逆十字_逆十字1_表示 = value;
    			悪タトゥ2_逆十字_逆十字2_表示 = value;
    			竜性_鱗1_表示 = value;
    			竜性_鱗2_表示 = value;
    			竜性_鱗3_表示 = value;
    			竜性_鱗4_表示 = value;
    			紋柄_紋1_表示 = value;
    			紋柄_紋2_表示 = value;
    			紋柄_紋3_表示 = value;
    			紋柄_紋4_表示 = value;
    			植性_通常_葉3_表示 = value;
    			植性_通常_葉2_表示 = value;
    			植性_通常_葉1_表示 = value;
    			植性_欠損_葉3_表示 = value;
    			植性_欠損_葉2_表示 = value;
    			植性_欠損_葉1_表示 = value;
    			虫性_器官1_表示 = value;
    			虫性_器官2_表示 = value;
    			傷I1_表示 = value;
    			傷I2_表示 = value;
    			傷I3_表示 = value;
    			傷I4_表示 = value;
    			傷X_表示 = value;
    			ハイライト1_表示 = value;
    			ハイライト2_表示 = value;
    			パンスト_表示 = value;
    			ニーハイ_ニーハイ1_表示 = value;
    			ニーハイ_ニーハイ2_表示 = value;
    			ニーハイ_ハイライト_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 腿0CD.不透明度;
    		}
    		set
    		{
    			腿0CD.不透明度 = value;
    			腿1CD.不透明度 = value;
    			腿2CD.不透明度 = value;
    			腿3CD.不透明度 = value;
    			腿4CD.不透明度 = value;
    			筋CD.不透明度 = value;
    			獣性_獣毛1_0CD.不透明度 = value;
    			獣性_獣毛2_0CD.不透明度 = value;
    			獣性_獣毛1_1CD.不透明度 = value;
    			獣性_獣毛2_1CD.不透明度 = value;
    			獣性_獣毛1_2CD.不透明度 = value;
    			獣性_獣毛2_2CD.不透明度 = value;
    			獣性_獣毛1_3CD.不透明度 = value;
    			獣性_獣毛2_3CD.不透明度 = value;
    			獣性_獣毛1_4CD.不透明度 = value;
    			獣性_獣毛2_4CD.不透明度 = value;
    			淫タトゥ_ハート_タトゥ左CD.不透明度 = value;
    			淫タトゥ_ハート_タトゥ右CD.不透明度 = value;
    			淫タトゥ_タトゥ左1CD.不透明度 = value;
    			淫タトゥ_タトゥ右1CD.不透明度 = value;
    			淫タトゥ_タトゥ左2CD.不透明度 = value;
    			淫タトゥ_タトゥ右2CD.不透明度 = value;
    			悪タトゥ1_文字_文字a_枠CD.不透明度 = value;
    			悪タトゥ1_文字_文字a_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ1_文字_文字a_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ1_文字_文字b_枠CD.不透明度 = value;
    			悪タトゥ1_文字_文字b_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ1_文字_文字b_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ1_文字_文字c_枠CD.不透明度 = value;
    			悪タトゥ1_文字_文字c_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ1_文字_文字c_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ1_文字_文字d_枠CD.不透明度 = value;
    			悪タトゥ1_文字_文字d_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ1_文字_文字d_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ1_文字_文字e_枠CD.不透明度 = value;
    			悪タトゥ1_文字_文字e_文字タトゥ1CD.不透明度 = value;
    			悪タトゥ1_文字_文字e_文字タトゥ2CD.不透明度 = value;
    			悪タトゥ1_文字_文字e_文字タトゥ3CD.不透明度 = value;
    			悪タトゥ1_タトゥ1CD.不透明度 = value;
    			悪タトゥ1_タトゥ2CD.不透明度 = value;
    			悪タトゥ2_逆十字_逆十字1CD.不透明度 = value;
    			悪タトゥ2_逆十字_逆十字2CD.不透明度 = value;
    			竜性_鱗1CD.不透明度 = value;
    			竜性_鱗2CD.不透明度 = value;
    			竜性_鱗3CD.不透明度 = value;
    			竜性_鱗4CD.不透明度 = value;
    			紋柄_紋1CD.不透明度 = value;
    			紋柄_紋2CD.不透明度 = value;
    			紋柄_紋3CD.不透明度 = value;
    			紋柄_紋4CD.不透明度 = value;
    			植性_葉3_0CD.不透明度 = value;
    			植性_葉2_0CD.不透明度 = value;
    			植性_葉1_0CD.不透明度 = value;
    			植性_葉3_1CD.不透明度 = value;
    			植性_葉2_1CD.不透明度 = value;
    			植性_葉1_1CD.不透明度 = value;
    			植性_葉3_2CD.不透明度 = value;
    			植性_葉2_2CD.不透明度 = value;
    			植性_葉1_2CD.不透明度 = value;
    			植性_葉3_3CD.不透明度 = value;
    			植性_葉2_3CD.不透明度 = value;
    			植性_葉1_3CD.不透明度 = value;
    			植性_葉3_4CD.不透明度 = value;
    			植性_葉2_4CD.不透明度 = value;
    			植性_葉1_4CD.不透明度 = value;
    			虫性_器官1CD.不透明度 = value;
    			虫性_器官2CD.不透明度 = value;
    			傷I1CD.不透明度 = value;
    			傷I2CD.不透明度 = value;
    			傷I3CD.不透明度 = value;
    			傷I4CD.不透明度 = value;
    			傷XCD.不透明度 = value;
    			ハイライト1CD.不透明度 = value;
    			ハイライト2CD.不透明度 = value;
    			パンストCD.不透明度 = value;
    			ニーハイ_ニーハイ1CD.不透明度 = value;
    			ニーハイ_ニーハイ2CD.不透明度 = value;
    			ニーハイ_ハイライトCD.不透明度 = value;
    		}
    	}

    	public bool パンスト表示
    	{
    		get
    		{
    			return パンスト_表示;
    		}
    		set
    		{
    			パンスト_表示 = value;
    			パンスト_ハイライト_表示 = value;
    		}
    	}

    	public bool ニーハイ表示
    	{
    		get
    		{
    			return ニーハイ_ニーハイ1_表示;
    		}
    		set
    		{
    			ニーハイ_ニーハイ1_表示 = value;
    			ニーハイ_ニーハイ2_表示 = value;
    			ニーハイ_ハイライト_表示 = value;
    		}
    	}

    	public JointS 脚_接続点 => new JointS(Body, X0Y0_腿, 0);

    	public 腿_人(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 腿_人D e)
    	{
    		腿_人 腿_人2 = this;
    		ThisType = GetType();
    		Body = new VariantGrid(GlobalState.脚左["腿"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_腿 = partGroup["腿"].ToPar();
    		X0Y0_筋 = partGroup["筋"].ToPar();
    		PartGroup pars2 = partGroup["獣性"].ToPars();
    		X0Y0_獣性_獣毛1 = pars2["獣毛1"].ToPar();
    		X0Y0_獣性_獣毛2 = pars2["獣毛2"].ToPar();
    		pars2 = partGroup["淫タトゥ"].ToPars();
    		PartGroup pars3 = pars2["ハート"].ToPars();
    		X0Y0_淫タトゥ_ハート_タトゥ左 = pars3["タトゥ左"].ToPar();
    		X0Y0_淫タトゥ_ハート_タトゥ右 = pars3["タトゥ右"].ToPar();
    		X0Y0_淫タトゥ_タトゥ左1 = pars2["タトゥ左1"].ToPar();
    		X0Y0_淫タトゥ_タトゥ右1 = pars2["タトゥ右1"].ToPar();
    		X0Y0_淫タトゥ_タトゥ左2 = pars2["タトゥ左2"].ToPar();
    		X0Y0_淫タトゥ_タトゥ右2 = pars2["タトゥ右2"].ToPar();
    		pars2 = partGroup["悪タトゥ1"].ToPars();
    		pars3 = pars2["文字"].ToPars();
    		PartGroup pars4 = pars3["文字a"].ToPars();
    		X0Y0_悪タトゥ1_文字_文字a_枠 = pars4["枠"].ToPar();
    		X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字b"].ToPars();
    		X0Y0_悪タトゥ1_文字_文字b_枠 = pars4["枠"].ToPar();
    		X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字c"].ToPars();
    		X0Y0_悪タトゥ1_文字_文字c_枠 = pars4["枠"].ToPar();
    		X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字d"].ToPars();
    		X0Y0_悪タトゥ1_文字_文字d_枠 = pars4["枠"].ToPar();
    		X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字e"].ToPars();
    		X0Y0_悪タトゥ1_文字_文字e_枠 = pars4["枠"].ToPar();
    		X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
    		X0Y0_悪タトゥ1_タトゥ1 = pars2["タトゥ1"].ToPar();
    		X0Y0_悪タトゥ1_タトゥ2 = pars2["タトゥ2"].ToPar();
    		pars2 = partGroup["悪タトゥ2"].ToPars();
    		pars3 = pars2["逆十字"].ToPars();
    		X0Y0_悪タトゥ2_逆十字_逆十字1 = pars3["逆十字1"].ToPar();
    		X0Y0_悪タトゥ2_逆十字_逆十字2 = pars3["逆十字2"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
    		X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
    		X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
    		X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
    		pars2 = partGroup["紋柄"].ToPars();
    		X0Y0_紋柄_紋1 = pars2["紋1"].ToPar();
    		X0Y0_紋柄_紋2 = pars2["紋2"].ToPar();
    		X0Y0_紋柄_紋3 = pars2["紋3"].ToPar();
    		X0Y0_紋柄_紋4 = pars2["紋4"].ToPar();
    		pars2 = partGroup["植性"].ToPars();
    		pars3 = pars2["通常"].ToPars();
    		X0Y0_植性_通常_葉3 = pars3["葉3"].ToPar();
    		X0Y0_植性_通常_葉2 = pars3["葉2"].ToPar();
    		X0Y0_植性_通常_葉1 = pars3["葉1"].ToPar();
    		pars3 = pars2["欠損"].ToPars();
    		X0Y0_植性_欠損_葉3 = pars3["葉3"].ToPar();
    		X0Y0_植性_欠損_葉2 = pars3["葉2"].ToPar();
    		X0Y0_植性_欠損_葉1 = pars3["葉1"].ToPar();
    		pars2 = partGroup["虫性"].ToPars();
    		X0Y0_虫性_器官1 = pars2["器官1"].ToPar();
    		X0Y0_虫性_器官2 = pars2["器官2"].ToPar();
    		X0Y0_傷I1 = partGroup["傷I1"].ToPar();
    		X0Y0_傷I2 = partGroup["傷I2"].ToPar();
    		X0Y0_傷I3 = partGroup["傷I3"].ToPar();
    		X0Y0_傷I4 = partGroup["傷I4"].ToPar();
    		X0Y0_傷X = partGroup["傷X"].ToPar();
    		X0Y0_ハイライト1 = partGroup["ハイライト1"].ToPar();
    		X0Y0_ハイライト2 = partGroup["ハイライト2"].ToPar();
    		pars2 = partGroup["パンスト"].ToPars();
    		X0Y0_パンスト = pars2["パンスト"].ToPar();
    		X0Y0_パンスト_ハイライト = pars2["ハイライト"].ToPar();
    		pars2 = partGroup["ニーハイ"].ToPars();
    		X0Y0_ニーハイ_ニーハイ1 = pars2["ニーハイ1"].ToPar();
    		X0Y0_ニーハイ_ニーハイ2 = pars2["ニーハイ2"].ToPar();
    		X0Y0_ニーハイ_ハイライト = pars2["ハイライト"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_腿 = partGroup["腿"].ToPar();
    		X0Y1_筋 = partGroup["筋"].ToPar();
    		pars2 = partGroup["獣性"].ToPars();
    		X0Y1_獣性_獣毛1 = pars2["獣毛1"].ToPar();
    		X0Y1_獣性_獣毛2 = pars2["獣毛2"].ToPar();
    		pars2 = partGroup["淫タトゥ"].ToPars();
    		pars3 = pars2["ハート"].ToPars();
    		X0Y1_淫タトゥ_ハート_タトゥ左 = pars3["タトゥ左"].ToPar();
    		X0Y1_淫タトゥ_ハート_タトゥ右 = pars3["タトゥ右"].ToPar();
    		X0Y1_淫タトゥ_タトゥ左1 = pars2["タトゥ左1"].ToPar();
    		X0Y1_淫タトゥ_タトゥ右1 = pars2["タトゥ右1"].ToPar();
    		X0Y1_淫タトゥ_タトゥ左2 = pars2["タトゥ左2"].ToPar();
    		X0Y1_淫タトゥ_タトゥ右2 = pars2["タトゥ右2"].ToPar();
    		pars2 = partGroup["悪タトゥ1"].ToPars();
    		pars3 = pars2["文字"].ToPars();
    		pars4 = pars3["文字a"].ToPars();
    		X0Y1_悪タトゥ1_文字_文字a_枠 = pars4["枠"].ToPar();
    		X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字b"].ToPars();
    		X0Y1_悪タトゥ1_文字_文字b_枠 = pars4["枠"].ToPar();
    		X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字c"].ToPars();
    		X0Y1_悪タトゥ1_文字_文字c_枠 = pars4["枠"].ToPar();
    		X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字d"].ToPars();
    		X0Y1_悪タトゥ1_文字_文字d_枠 = pars4["枠"].ToPar();
    		X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字e"].ToPars();
    		X0Y1_悪タトゥ1_文字_文字e_枠 = pars4["枠"].ToPar();
    		X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
    		X0Y1_悪タトゥ1_タトゥ1 = pars2["タトゥ1"].ToPar();
    		X0Y1_悪タトゥ1_タトゥ2 = pars2["タトゥ2"].ToPar();
    		pars2 = partGroup["悪タトゥ2"].ToPars();
    		pars3 = pars2["逆十字"].ToPars();
    		X0Y1_悪タトゥ2_逆十字_逆十字1 = pars3["逆十字1"].ToPar();
    		X0Y1_悪タトゥ2_逆十字_逆十字2 = pars3["逆十字2"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		X0Y1_鱗_鱗1 = pars2["鱗1"].ToPar();
    		X0Y1_鱗_鱗2 = pars2["鱗2"].ToPar();
    		X0Y1_鱗_鱗3 = pars2["鱗3"].ToPar();
    		X0Y1_鱗_鱗4 = pars2["鱗4"].ToPar();
    		pars2 = partGroup["紋柄"].ToPars();
    		X0Y1_紋柄_紋1 = pars2["紋1"].ToPar();
    		X0Y1_紋柄_紋2 = pars2["紋2"].ToPar();
    		X0Y1_紋柄_紋3 = pars2["紋3"].ToPar();
    		X0Y1_紋柄_紋4 = pars2["紋4"].ToPar();
    		pars2 = partGroup["植性"].ToPars();
    		pars3 = pars2["通常"].ToPars();
    		X0Y1_植性_通常_葉3 = pars3["葉3"].ToPar();
    		X0Y1_植性_通常_葉2 = pars3["葉2"].ToPar();
    		X0Y1_植性_通常_葉1 = pars3["葉1"].ToPar();
    		pars3 = pars2["欠損"].ToPars();
    		X0Y1_植性_欠損_葉3 = pars3["葉3"].ToPar();
    		X0Y1_植性_欠損_葉2 = pars3["葉2"].ToPar();
    		X0Y1_植性_欠損_葉1 = pars3["葉1"].ToPar();
    		pars2 = partGroup["虫性"].ToPars();
    		X0Y1_虫性_器官1 = pars2["器官1"].ToPar();
    		X0Y1_虫性_器官2 = pars2["器官2"].ToPar();
    		X0Y1_傷I1 = partGroup["傷I1"].ToPar();
    		X0Y1_傷I2 = partGroup["傷I2"].ToPar();
    		X0Y1_傷I3 = partGroup["傷I3"].ToPar();
    		X0Y1_傷I4 = partGroup["傷I4"].ToPar();
    		X0Y1_傷X = partGroup["傷X"].ToPar();
    		X0Y1_ハイライト1 = partGroup["ハイライト1"].ToPar();
    		X0Y1_ハイライト2 = partGroup["ハイライト2"].ToPar();
    		pars2 = partGroup["パンスト"].ToPars();
    		X0Y1_パンスト = pars2["パンスト"].ToPar();
    		X0Y1_パンスト_ハイライト = pars2["ハイライト"].ToPar();
    		pars2 = partGroup["ニーハイ"].ToPars();
    		X0Y1_ニーハイ_ニーハイ1 = pars2["ニーハイ1"].ToPar();
    		X0Y1_ニーハイ_ニーハイ2 = pars2["ニーハイ2"].ToPar();
    		X0Y1_ニーハイ_ハイライト = pars2["ハイライト"].ToPar();
    		partGroup = Body[0][2];
    		X0Y2_腿 = partGroup["腿"].ToPar();
    		X0Y2_筋 = partGroup["筋"].ToPar();
    		pars2 = partGroup["獣性"].ToPars();
    		X0Y2_獣性_獣毛1 = pars2["獣毛1"].ToPar();
    		X0Y2_獣性_獣毛2 = pars2["獣毛2"].ToPar();
    		pars2 = partGroup["淫タトゥ"].ToPars();
    		pars3 = pars2["ハート"].ToPars();
    		X0Y2_淫タトゥ_ハート_タトゥ左 = pars3["タトゥ左"].ToPar();
    		X0Y2_淫タトゥ_ハート_タトゥ右 = pars3["タトゥ右"].ToPar();
    		X0Y2_淫タトゥ_タトゥ右1 = pars2["タトゥ右1"].ToPar();
    		X0Y2_淫タトゥ_タトゥ右2 = pars2["タトゥ右2"].ToPar();
    		pars2 = partGroup["悪タトゥ1"].ToPars();
    		pars3 = pars2["文字"].ToPars();
    		pars4 = pars3["文字b"].ToPars();
    		X0Y2_悪タトゥ1_文字_文字b_枠 = pars4["枠"].ToPar();
    		X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字c"].ToPars();
    		X0Y2_悪タトゥ1_文字_文字c_枠 = pars4["枠"].ToPar();
    		X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字d"].ToPars();
    		X0Y2_悪タトゥ1_文字_文字d_枠 = pars4["枠"].ToPar();
    		X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字e"].ToPars();
    		X0Y2_悪タトゥ1_文字_文字e_枠 = pars4["枠"].ToPar();
    		X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
    		pars4 = pars3["文字a"].ToPars();
    		X0Y2_悪タトゥ1_文字_文字a_枠 = pars4["枠"].ToPar();
    		X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		X0Y2_悪タトゥ1_タトゥ1 = pars2["タトゥ1"].ToPar();
    		X0Y2_悪タトゥ1_タトゥ2 = pars2["タトゥ2"].ToPar();
    		pars2 = partGroup["悪タトゥ2"].ToPars();
    		pars3 = pars2["逆十字"].ToPars();
    		X0Y2_悪タトゥ2_逆十字_逆十字1 = pars3["逆十字1"].ToPar();
    		X0Y2_悪タトゥ2_逆十字_逆十字2 = pars3["逆十字2"].ToPar();
    		pars2 = partGroup["植性"].ToPars();
    		pars3 = pars2["通常"].ToPars();
    		X0Y2_植性_通常_葉3 = pars3["葉3"].ToPar();
    		X0Y2_植性_通常_葉2 = pars3["葉2"].ToPar();
    		X0Y2_植性_通常_葉1 = pars3["葉1"].ToPar();
    		pars3 = pars2["欠損"].ToPars();
    		X0Y2_植性_欠損_葉3 = pars3["葉3"].ToPar();
    		X0Y2_植性_欠損_葉2 = pars3["葉2"].ToPar();
    		X0Y2_植性_欠損_葉1 = pars3["葉1"].ToPar();
    		X0Y2_傷I1 = partGroup["傷I1"].ToPar();
    		X0Y2_傷I2 = partGroup["傷I2"].ToPar();
    		X0Y2_傷I3 = partGroup["傷I3"].ToPar();
    		X0Y2_ハイライト1 = partGroup["ハイライト1"].ToPar();
    		X0Y2_ハイライト2 = partGroup["ハイライト2"].ToPar();
    		pars2 = partGroup["パンスト"].ToPars();
    		X0Y2_パンスト = pars2["パンスト"].ToPar();
    		X0Y2_パンスト_ハイライト = pars2["ハイライト"].ToPar();
    		pars2 = partGroup["ニーハイ"].ToPars();
    		X0Y2_ニーハイ_ニーハイ1 = pars2["ニーハイ1"].ToPar();
    		X0Y2_ニーハイ_ニーハイ2 = pars2["ニーハイ2"].ToPar();
    		X0Y2_ニーハイ_ハイライト = pars2["ハイライト"].ToPar();
    		partGroup = Body[0][3];
    		X0Y3_腿 = partGroup["腿"].ToPar();
    		X0Y3_筋 = partGroup["筋"].ToPar();
    		pars2 = partGroup["獣性"].ToPars();
    		X0Y3_獣性_獣毛1 = pars2["獣毛1"].ToPar();
    		X0Y3_獣性_獣毛2 = pars2["獣毛2"].ToPar();
    		pars2 = partGroup["淫タトゥ"].ToPars();
    		X0Y3_淫タトゥ_タトゥ左1 = pars2["タトゥ左1"].ToPar();
    		X0Y3_淫タトゥ_タトゥ右1 = pars2["タトゥ右1"].ToPar();
    		X0Y3_淫タトゥ_タトゥ左2 = pars2["タトゥ左2"].ToPar();
    		X0Y3_淫タトゥ_タトゥ右2 = pars2["タトゥ右2"].ToPar();
    		pars2 = partGroup["悪タトゥ1"].ToPars();
    		pars3 = pars2["文字"].ToPars();
    		pars4 = pars3["文字c"].ToPars();
    		X0Y3_悪タトゥ1_文字_文字c_枠 = pars4["枠"].ToPar();
    		X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字d"].ToPars();
    		X0Y3_悪タトゥ1_文字_文字d_枠 = pars4["枠"].ToPar();
    		X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字e"].ToPars();
    		X0Y3_悪タトゥ1_文字_文字e_枠 = pars4["枠"].ToPar();
    		X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
    		pars4 = pars3["文字a"].ToPars();
    		X0Y3_悪タトゥ1_文字_文字a_枠 = pars4["枠"].ToPar();
    		X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字b"].ToPars();
    		X0Y3_悪タトゥ1_文字_文字b_枠 = pars4["枠"].ToPar();
    		X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		X0Y3_悪タトゥ1_タトゥ1 = pars2["タトゥ1"].ToPar();
    		X0Y3_悪タトゥ1_タトゥ2 = pars2["タトゥ2"].ToPar();
    		pars2 = partGroup["悪タトゥ2"].ToPars();
    		pars3 = pars2["逆十字"].ToPars();
    		X0Y3_悪タトゥ2_逆十字_逆十字1 = pars3["逆十字1"].ToPar();
    		X0Y3_悪タトゥ2_逆十字_逆十字2 = pars3["逆十字2"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		X0Y3_鱗_鱗1 = pars2["鱗1"].ToPar();
    		X0Y3_鱗_鱗2 = pars2["鱗2"].ToPar();
    		X0Y3_鱗_鱗3 = pars2["鱗3"].ToPar();
    		X0Y3_鱗_鱗4 = pars2["鱗4"].ToPar();
    		pars2 = partGroup["紋柄"].ToPars();
    		X0Y3_紋柄_紋1 = pars2["紋1"].ToPar();
    		X0Y3_紋柄_紋2 = pars2["紋2"].ToPar();
    		X0Y3_紋柄_紋3 = pars2["紋3"].ToPar();
    		X0Y3_紋柄_紋4 = pars2["紋4"].ToPar();
    		pars2 = partGroup["植性"].ToPars();
    		pars3 = pars2["通常"].ToPars();
    		X0Y3_植性_通常_葉3 = pars3["葉3"].ToPar();
    		X0Y3_植性_通常_葉2 = pars3["葉2"].ToPar();
    		X0Y3_植性_通常_葉1 = pars3["葉1"].ToPar();
    		pars3 = pars2["欠損"].ToPars();
    		X0Y3_植性_欠損_葉3 = pars3["葉3"].ToPar();
    		X0Y3_植性_欠損_葉2 = pars3["葉2"].ToPar();
    		X0Y3_植性_欠損_葉1 = pars3["葉1"].ToPar();
    		X0Y3_傷I1 = partGroup["傷I1"].ToPar();
    		X0Y3_傷I2 = partGroup["傷I2"].ToPar();
    		X0Y3_傷I3 = partGroup["傷I3"].ToPar();
    		X0Y3_傷X = partGroup["傷X"].ToPar();
    		X0Y3_ハイライト1 = partGroup["ハイライト1"].ToPar();
    		X0Y3_ハイライト2 = partGroup["ハイライト2"].ToPar();
    		pars2 = partGroup["パンスト"].ToPars();
    		X0Y3_パンスト = pars2["パンスト"].ToPar();
    		X0Y3_パンスト_ハイライト = pars2["ハイライト"].ToPar();
    		pars2 = partGroup["ニーハイ"].ToPars();
    		X0Y3_ニーハイ_ニーハイ1 = pars2["ニーハイ1"].ToPar();
    		X0Y3_ニーハイ_ニーハイ2 = pars2["ニーハイ2"].ToPar();
    		X0Y3_ニーハイ_ハイライト = pars2["ハイライト"].ToPar();
    		partGroup = Body[0][4];
    		X0Y4_腿 = partGroup["腿"].ToPar();
    		X0Y4_筋 = partGroup["筋"].ToPar();
    		pars2 = partGroup["獣性"].ToPars();
    		X0Y4_獣性_獣毛1 = pars2["獣毛1"].ToPar();
    		X0Y4_獣性_獣毛2 = pars2["獣毛2"].ToPar();
    		pars2 = partGroup["淫タトゥ"].ToPars();
    		X0Y4_淫タトゥ_タトゥ左1 = pars2["タトゥ左1"].ToPar();
    		X0Y4_淫タトゥ_タトゥ右1 = pars2["タトゥ右1"].ToPar();
    		X0Y4_淫タトゥ_タトゥ左2 = pars2["タトゥ左2"].ToPar();
    		X0Y4_淫タトゥ_タトゥ右2 = pars2["タトゥ右2"].ToPar();
    		pars2 = partGroup["悪タトゥ1"].ToPars();
    		pars3 = pars2["文字"].ToPars();
    		pars4 = pars3["文字d"].ToPars();
    		X0Y4_悪タトゥ1_文字_文字d_枠 = pars4["枠"].ToPar();
    		X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字e"].ToPars();
    		X0Y4_悪タトゥ1_文字_文字e_枠 = pars4["枠"].ToPar();
    		X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
    		pars4 = pars3["文字a"].ToPars();
    		X0Y4_悪タトゥ1_文字_文字a_枠 = pars4["枠"].ToPar();
    		X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字b"].ToPars();
    		X0Y4_悪タトゥ1_文字_文字b_枠 = pars4["枠"].ToPar();
    		X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		pars4 = pars3["文字c"].ToPars();
    		X0Y4_悪タトゥ1_文字_文字c_枠 = pars4["枠"].ToPar();
    		X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
    		X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
    		X0Y4_悪タトゥ1_タトゥ1 = pars2["タトゥ1"].ToPar();
    		X0Y4_悪タトゥ1_タトゥ2 = pars2["タトゥ2"].ToPar();
    		pars2 = partGroup["鱗"].ToPars();
    		X0Y4_鱗_鱗1 = pars2["鱗1"].ToPar();
    		X0Y4_鱗_鱗2 = pars2["鱗2"].ToPar();
    		X0Y4_鱗_鱗3 = pars2["鱗3"].ToPar();
    		X0Y4_鱗_鱗4 = pars2["鱗4"].ToPar();
    		pars2 = partGroup["紋柄"].ToPars();
    		X0Y4_紋柄_紋1 = pars2["紋1"].ToPar();
    		X0Y4_紋柄_紋2 = pars2["紋2"].ToPar();
    		X0Y4_紋柄_紋3 = pars2["紋3"].ToPar();
    		X0Y4_紋柄_紋4 = pars2["紋4"].ToPar();
    		pars2 = partGroup["植性"].ToPars();
    		pars3 = pars2["通常"].ToPars();
    		X0Y4_植性_通常_葉3 = pars3["葉3"].ToPar();
    		X0Y4_植性_通常_葉2 = pars3["葉2"].ToPar();
    		X0Y4_植性_通常_葉1 = pars3["葉1"].ToPar();
    		pars3 = pars2["欠損"].ToPars();
    		X0Y4_植性_欠損_葉3 = pars3["葉3"].ToPar();
    		X0Y4_植性_欠損_葉2 = pars3["葉2"].ToPar();
    		X0Y4_植性_欠損_葉1 = pars3["葉1"].ToPar();
    		X0Y4_傷I1 = partGroup["傷I1"].ToPar();
    		X0Y4_傷X = partGroup["傷X"].ToPar();
    		X0Y4_ハイライト1 = partGroup["ハイライト1"].ToPar();
    		X0Y4_ハイライト2 = partGroup["ハイライト2"].ToPar();
    		pars2 = partGroup["パンスト"].ToPars();
    		X0Y4_パンスト = pars2["パンスト"].ToPar();
    		X0Y4_パンスト_ハイライト = pars2["ハイライト"].ToPar();
    		pars2 = partGroup["ニーハイ"].ToPars();
    		X0Y4_ニーハイ_ニーハイ1 = pars2["ニーハイ1"].ToPar();
    		X0Y4_ニーハイ_ニーハイ2 = pars2["ニーハイ2"].ToPar();
    		X0Y4_ニーハイ_ハイライト = pars2["ハイライト"].ToPar();
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
    		腿_表示 = e.腿_表示;
    		筋_表示 = e.筋_表示;
    		獣性_獣毛1_表示 = e.獣性_獣毛1_表示;
    		獣性_獣毛2_表示 = e.獣性_獣毛2_表示;
    		淫タトゥ_ハート_タトゥ左_表示 = e.淫タトゥ_ハート_タトゥ左_表示;
    		淫タトゥ_ハート_タトゥ右_表示 = e.淫タトゥ_ハート_タトゥ右_表示;
    		淫タトゥ_タトゥ左1_表示 = e.淫タトゥ_タトゥ左1_表示;
    		淫タトゥ_タトゥ右1_表示 = e.淫タトゥ_タトゥ右1_表示;
    		淫タトゥ_タトゥ左2_表示 = e.淫タトゥ_タトゥ左2_表示;
    		淫タトゥ_タトゥ右2_表示 = e.淫タトゥ_タトゥ右2_表示;
    		悪タトゥ1_文字_文字a_枠_表示 = e.悪タトゥ1_文字_文字a_枠_表示;
    		悪タトゥ1_文字_文字a_文字タトゥ1_表示 = e.悪タトゥ1_文字_文字a_文字タトゥ1_表示;
    		悪タトゥ1_文字_文字a_文字タトゥ2_表示 = e.悪タトゥ1_文字_文字a_文字タトゥ2_表示;
    		悪タトゥ1_文字_文字b_枠_表示 = e.悪タトゥ1_文字_文字b_枠_表示;
    		悪タトゥ1_文字_文字b_文字タトゥ1_表示 = e.悪タトゥ1_文字_文字b_文字タトゥ1_表示;
    		悪タトゥ1_文字_文字b_文字タトゥ2_表示 = e.悪タトゥ1_文字_文字b_文字タトゥ2_表示;
    		悪タトゥ1_文字_文字c_枠_表示 = e.悪タトゥ1_文字_文字c_枠_表示;
    		悪タトゥ1_文字_文字c_文字タトゥ1_表示 = e.悪タトゥ1_文字_文字c_文字タトゥ1_表示;
    		悪タトゥ1_文字_文字c_文字タトゥ2_表示 = e.悪タトゥ1_文字_文字c_文字タトゥ2_表示;
    		悪タトゥ1_文字_文字d_枠_表示 = e.悪タトゥ1_文字_文字d_枠_表示;
    		悪タトゥ1_文字_文字d_文字タトゥ1_表示 = e.悪タトゥ1_文字_文字d_文字タトゥ1_表示;
    		悪タトゥ1_文字_文字d_文字タトゥ2_表示 = e.悪タトゥ1_文字_文字d_文字タトゥ2_表示;
    		悪タトゥ1_文字_文字e_枠_表示 = e.悪タトゥ1_文字_文字e_枠_表示;
    		悪タトゥ1_文字_文字e_文字タトゥ1_表示 = e.悪タトゥ1_文字_文字e_文字タトゥ1_表示;
    		悪タトゥ1_文字_文字e_文字タトゥ2_表示 = e.悪タトゥ1_文字_文字e_文字タトゥ2_表示;
    		悪タトゥ1_文字_文字e_文字タトゥ3_表示 = e.悪タトゥ1_文字_文字e_文字タトゥ3_表示;
    		悪タトゥ1_タトゥ1_表示 = e.悪タトゥ1_タトゥ1_表示;
    		悪タトゥ1_タトゥ2_表示 = e.悪タトゥ1_タトゥ2_表示;
    		悪タトゥ2_逆十字_逆十字1_表示 = e.悪タトゥ2_逆十字_逆十字1_表示;
    		悪タトゥ2_逆十字_逆十字2_表示 = e.悪タトゥ2_逆十字_逆十字2_表示;
    		竜性_鱗1_表示 = e.竜性_鱗1_表示;
    		竜性_鱗2_表示 = e.竜性_鱗2_表示;
    		竜性_鱗3_表示 = e.竜性_鱗3_表示;
    		竜性_鱗4_表示 = e.竜性_鱗4_表示;
    		紋柄_紋1_表示 = e.紋柄_紋1_表示;
    		紋柄_紋2_表示 = e.紋柄_紋2_表示;
    		紋柄_紋3_表示 = e.紋柄_紋3_表示;
    		紋柄_紋4_表示 = e.紋柄_紋4_表示;
    		植性_通常_葉3_表示 = e.植性_通常_葉3_表示;
    		植性_通常_葉2_表示 = e.植性_通常_葉2_表示;
    		植性_通常_葉1_表示 = e.植性_通常_葉1_表示;
    		植性_欠損_葉3_表示 = e.植性_欠損_葉3_表示;
    		植性_欠損_葉2_表示 = e.植性_欠損_葉2_表示;
    		植性_欠損_葉1_表示 = e.植性_欠損_葉1_表示;
    		虫性_器官1_表示 = e.虫性_器官1_表示;
    		虫性_器官2_表示 = e.虫性_器官2_表示;
    		傷I1_表示 = e.傷I1_表示;
    		傷I2_表示 = e.傷I2_表示;
    		傷I3_表示 = e.傷I3_表示;
    		傷I4_表示 = e.傷I4_表示;
    		傷X_表示 = e.傷X_表示;
    		ハイライト1_表示 = e.ハイライト1_表示;
    		ハイライト2_表示 = e.ハイライト2_表示;
    		パンスト_表示 = e.パンスト_表示;
    		ニーハイ_ニーハイ1_表示 = e.ニーハイ_ニーハイ1_表示;
    		ニーハイ_ニーハイ2_表示 = e.ニーハイ_ニーハイ2_表示;
    		ニーハイ_ハイライト_表示 = e.ニーハイ_ハイライト_表示;
    		植性_葉3_表示 = e.植性_葉3_表示;
    		植性_葉2_表示 = e.植性_葉2_表示;
    		植性_葉1_表示 = e.植性_葉1_表示;
    		ハイライト表示 = e.ハイライト表示;
    		if (e.虫性)
    		{
    			虫性();
    		}
    		パンスト表示 = e.パンスト表示;
    		ニーハイ表示 = e.ニーハイ表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.Leg_接続.Count > 0)
    		{
    			Element f;
    			Leg_接続 = e.Leg_接続.Select(delegate(ElementData g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 腿_人2;
    				f.ConnectionType = ConnectionInfo.腿_人_Leg_接続;
    				f.接続(腿_人2.脚_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_腿CP = new ColorP(X0Y0_腿, 腿0CD, DisUnit, abj: true);
    		X0Y0_筋CP = new ColorP(X0Y0_筋, 筋CD, DisUnit, abj: false);
    		X0Y0_獣性_獣毛1CP = new ColorP(X0Y0_獣性_獣毛1, 獣性_獣毛1_0CD, DisUnit, abj: true);
    		X0Y0_獣性_獣毛2CP = new ColorP(X0Y0_獣性_獣毛2, 獣性_獣毛2_0CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_ハート_タトゥ左CP = new ColorP(X0Y0_淫タトゥ_ハート_タトゥ左, 淫タトゥ_ハート_タトゥ左CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_ハート_タトゥ右CP = new ColorP(X0Y0_淫タトゥ_ハート_タトゥ右, 淫タトゥ_ハート_タトゥ右CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_タトゥ左1CP = new ColorP(X0Y0_淫タトゥ_タトゥ左1, 淫タトゥ_タトゥ左1CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_タトゥ右1CP = new ColorP(X0Y0_淫タトゥ_タトゥ右1, 淫タトゥ_タトゥ右1CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_タトゥ左2CP = new ColorP(X0Y0_淫タトゥ_タトゥ左2, 淫タトゥ_タトゥ左2CD, DisUnit, abj: true);
    		X0Y0_淫タトゥ_タトゥ右2CP = new ColorP(X0Y0_淫タトゥ_タトゥ右2, 淫タトゥ_タトゥ右2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字a_枠CP = new ColorP(X0Y0_悪タトゥ1_文字_文字a_枠, 悪タトゥ1_文字_文字a_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1, 悪タトゥ1_文字_文字a_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2, 悪タトゥ1_文字_文字a_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字b_枠CP = new ColorP(X0Y0_悪タトゥ1_文字_文字b_枠, 悪タトゥ1_文字_文字b_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1, 悪タトゥ1_文字_文字b_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2, 悪タトゥ1_文字_文字b_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字c_枠CP = new ColorP(X0Y0_悪タトゥ1_文字_文字c_枠, 悪タトゥ1_文字_文字c_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1, 悪タトゥ1_文字_文字c_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2, 悪タトゥ1_文字_文字c_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字d_枠CP = new ColorP(X0Y0_悪タトゥ1_文字_文字d_枠, 悪タトゥ1_文字_文字d_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1, 悪タトゥ1_文字_文字d_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2, 悪タトゥ1_文字_文字d_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字e_枠CP = new ColorP(X0Y0_悪タトゥ1_文字_文字e_枠, 悪タトゥ1_文字_文字e_枠CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1CP = new ColorP(X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1, 悪タトゥ1_文字_文字e_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2CP = new ColorP(X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2, 悪タトゥ1_文字_文字e_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3CP = new ColorP(X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3, 悪タトゥ1_文字_文字e_文字タトゥ3CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_タトゥ1CP = new ColorP(X0Y0_悪タトゥ1_タトゥ1, 悪タトゥ1_タトゥ1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ1_タトゥ2CP = new ColorP(X0Y0_悪タトゥ1_タトゥ2, 悪タトゥ1_タトゥ2CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ2_逆十字_逆十字1CP = new ColorP(X0Y0_悪タトゥ2_逆十字_逆十字1, 悪タトゥ2_逆十字_逆十字1CD, DisUnit, abj: true);
    		X0Y0_悪タトゥ2_逆十字_逆十字2CP = new ColorP(X0Y0_悪タトゥ2_逆十字_逆十字2, 悪タトゥ2_逆十字_逆十字2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗1CP = new ColorP(X0Y0_竜性_鱗1, 竜性_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗2CP = new ColorP(X0Y0_竜性_鱗2, 竜性_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗3CP = new ColorP(X0Y0_竜性_鱗3, 竜性_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性_鱗4CP = new ColorP(X0Y0_竜性_鱗4, 竜性_鱗4CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋1CP = new ColorP(X0Y0_紋柄_紋1, 紋柄_紋1CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋2CP = new ColorP(X0Y0_紋柄_紋2, 紋柄_紋2CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋3CP = new ColorP(X0Y0_紋柄_紋3, 紋柄_紋3CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋4CP = new ColorP(X0Y0_紋柄_紋4, 紋柄_紋4CD, DisUnit, abj: true);
    		X0Y0_植性_通常_葉3CP = new ColorP(X0Y0_植性_通常_葉3, 植性_葉3_0CD, DisUnit, abj: true);
    		X0Y0_植性_通常_葉2CP = new ColorP(X0Y0_植性_通常_葉2, 植性_葉2_0CD, DisUnit, abj: true);
    		X0Y0_植性_通常_葉1CP = new ColorP(X0Y0_植性_通常_葉1, 植性_葉1_0CD, DisUnit, abj: true);
    		X0Y0_植性_欠損_葉3CP = new ColorP(X0Y0_植性_欠損_葉3, 植性_葉3_0CD, DisUnit, abj: true);
    		X0Y0_植性_欠損_葉2CP = new ColorP(X0Y0_植性_欠損_葉2, 植性_葉2_0CD, DisUnit, abj: true);
    		X0Y0_植性_欠損_葉1CP = new ColorP(X0Y0_植性_欠損_葉1, 植性_葉1_0CD, DisUnit, abj: true);
    		X0Y0_虫性_器官1CP = new ColorP(X0Y0_虫性_器官1, 虫性_器官1CD, DisUnit, abj: true);
    		X0Y0_虫性_器官2CP = new ColorP(X0Y0_虫性_器官2, 虫性_器官2CD, DisUnit, abj: true);
    		X0Y0_傷I1CP = new ColorP(X0Y0_傷I1, 傷I1CD, DisUnit, abj: true);
    		X0Y0_傷I2CP = new ColorP(X0Y0_傷I2, 傷I2CD, DisUnit, abj: true);
    		X0Y0_傷I3CP = new ColorP(X0Y0_傷I3, 傷I3CD, DisUnit, abj: true);
    		X0Y0_傷I4CP = new ColorP(X0Y0_傷I4, 傷I4CD, DisUnit, abj: true);
    		X0Y0_傷XCP = new ColorP(X0Y0_傷X, 傷XCD, DisUnit, abj: true);
    		X0Y0_ハイライト1CP = new ColorP(X0Y0_ハイライト1, ハイライト1CD, DisUnit, abj: true);
    		X0Y0_ハイライト2CP = new ColorP(X0Y0_ハイライト2, ハイライト2CD, DisUnit, abj: true);
    		X0Y0_パンストCP = new ColorP(X0Y0_パンスト, パンストCD, DisUnit, abj: false);
    		X0Y0_パンスト_ハイライトCP = new ColorP(X0Y0_パンスト_ハイライト, パンスト_ハイライトCD, DisUnit, abj: true);
    		X0Y0_ニーハイ_ニーハイ1CP = new ColorP(X0Y0_ニーハイ_ニーハイ1, ニーハイ_ニーハイ1CD, DisUnit, abj: true);
    		X0Y0_ニーハイ_ニーハイ2CP = new ColorP(X0Y0_ニーハイ_ニーハイ2, ニーハイ_ニーハイ2CD, DisUnit, abj: true);
    		X0Y0_ニーハイ_ハイライトCP = new ColorP(X0Y0_ニーハイ_ハイライト, ニーハイ_ハイライトCD, DisUnit, abj: true);
    		X0Y1_腿CP = new ColorP(X0Y1_腿, 腿1CD, DisUnit, abj: true);
    		X0Y1_筋CP = new ColorP(X0Y1_筋, 筋CD, DisUnit, abj: false);
    		X0Y1_獣性_獣毛1CP = new ColorP(X0Y1_獣性_獣毛1, 獣性_獣毛1_1CD, DisUnit, abj: true);
    		X0Y1_獣性_獣毛2CP = new ColorP(X0Y1_獣性_獣毛2, 獣性_獣毛2_1CD, DisUnit, abj: true);
    		X0Y1_淫タトゥ_ハート_タトゥ左CP = new ColorP(X0Y1_淫タトゥ_ハート_タトゥ左, 淫タトゥ_ハート_タトゥ左CD, DisUnit, abj: true);
    		X0Y1_淫タトゥ_ハート_タトゥ右CP = new ColorP(X0Y1_淫タトゥ_ハート_タトゥ右, 淫タトゥ_ハート_タトゥ右CD, DisUnit, abj: true);
    		X0Y1_淫タトゥ_タトゥ左1CP = new ColorP(X0Y1_淫タトゥ_タトゥ左1, 淫タトゥ_タトゥ左1CD, DisUnit, abj: true);
    		X0Y1_淫タトゥ_タトゥ右1CP = new ColorP(X0Y1_淫タトゥ_タトゥ右1, 淫タトゥ_タトゥ右1CD, DisUnit, abj: true);
    		X0Y1_淫タトゥ_タトゥ左2CP = new ColorP(X0Y1_淫タトゥ_タトゥ左2, 淫タトゥ_タトゥ左2CD, DisUnit, abj: true);
    		X0Y1_淫タトゥ_タトゥ右2CP = new ColorP(X0Y1_淫タトゥ_タトゥ右2, 淫タトゥ_タトゥ右2CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字a_枠CP = new ColorP(X0Y1_悪タトゥ1_文字_文字a_枠, 悪タトゥ1_文字_文字a_枠CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1CP = new ColorP(X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1, 悪タトゥ1_文字_文字a_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2CP = new ColorP(X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2, 悪タトゥ1_文字_文字a_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字b_枠CP = new ColorP(X0Y1_悪タトゥ1_文字_文字b_枠, 悪タトゥ1_文字_文字b_枠CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1CP = new ColorP(X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1, 悪タトゥ1_文字_文字b_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2CP = new ColorP(X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2, 悪タトゥ1_文字_文字b_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字c_枠CP = new ColorP(X0Y1_悪タトゥ1_文字_文字c_枠, 悪タトゥ1_文字_文字c_枠CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1CP = new ColorP(X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1, 悪タトゥ1_文字_文字c_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2CP = new ColorP(X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2, 悪タトゥ1_文字_文字c_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字d_枠CP = new ColorP(X0Y1_悪タトゥ1_文字_文字d_枠, 悪タトゥ1_文字_文字d_枠CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1CP = new ColorP(X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1, 悪タトゥ1_文字_文字d_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2CP = new ColorP(X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2, 悪タトゥ1_文字_文字d_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字e_枠CP = new ColorP(X0Y1_悪タトゥ1_文字_文字e_枠, 悪タトゥ1_文字_文字e_枠CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1CP = new ColorP(X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1, 悪タトゥ1_文字_文字e_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2CP = new ColorP(X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2, 悪タトゥ1_文字_文字e_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3CP = new ColorP(X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3, 悪タトゥ1_文字_文字e_文字タトゥ3CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_タトゥ1CP = new ColorP(X0Y1_悪タトゥ1_タトゥ1, 悪タトゥ1_タトゥ1CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ1_タトゥ2CP = new ColorP(X0Y1_悪タトゥ1_タトゥ2, 悪タトゥ1_タトゥ2CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ2_逆十字_逆十字1CP = new ColorP(X0Y1_悪タトゥ2_逆十字_逆十字1, 悪タトゥ2_逆十字_逆十字1CD, DisUnit, abj: true);
    		X0Y1_悪タトゥ2_逆十字_逆十字2CP = new ColorP(X0Y1_悪タトゥ2_逆十字_逆十字2, 悪タトゥ2_逆十字_逆十字2CD, DisUnit, abj: true);
    		X0Y1_鱗_鱗1CP = new ColorP(X0Y1_鱗_鱗1, 竜性_鱗1CD, DisUnit, abj: true);
    		X0Y1_鱗_鱗2CP = new ColorP(X0Y1_鱗_鱗2, 竜性_鱗2CD, DisUnit, abj: true);
    		X0Y1_鱗_鱗3CP = new ColorP(X0Y1_鱗_鱗3, 竜性_鱗3CD, DisUnit, abj: true);
    		X0Y1_鱗_鱗4CP = new ColorP(X0Y1_鱗_鱗4, 竜性_鱗4CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋1CP = new ColorP(X0Y1_紋柄_紋1, 紋柄_紋1CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋2CP = new ColorP(X0Y1_紋柄_紋2, 紋柄_紋2CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋3CP = new ColorP(X0Y1_紋柄_紋3, 紋柄_紋3CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋4CP = new ColorP(X0Y1_紋柄_紋4, 紋柄_紋4CD, DisUnit, abj: true);
    		X0Y1_植性_通常_葉3CP = new ColorP(X0Y1_植性_通常_葉3, 植性_葉3_1CD, DisUnit, abj: true);
    		X0Y1_植性_通常_葉2CP = new ColorP(X0Y1_植性_通常_葉2, 植性_葉2_1CD, DisUnit, abj: true);
    		X0Y1_植性_通常_葉1CP = new ColorP(X0Y1_植性_通常_葉1, 植性_葉1_1CD, DisUnit, abj: true);
    		X0Y1_植性_欠損_葉3CP = new ColorP(X0Y1_植性_欠損_葉3, 植性_葉3_1CD, DisUnit, abj: true);
    		X0Y1_植性_欠損_葉2CP = new ColorP(X0Y1_植性_欠損_葉2, 植性_葉2_1CD, DisUnit, abj: true);
    		X0Y1_植性_欠損_葉1CP = new ColorP(X0Y1_植性_欠損_葉1, 植性_葉1_1CD, DisUnit, abj: true);
    		X0Y1_虫性_器官1CP = new ColorP(X0Y1_虫性_器官1, 虫性_器官1CD, DisUnit, abj: true);
    		X0Y1_虫性_器官2CP = new ColorP(X0Y1_虫性_器官2, 虫性_器官2CD, DisUnit, abj: true);
    		X0Y1_傷I1CP = new ColorP(X0Y1_傷I1, 傷I1CD, DisUnit, abj: true);
    		X0Y1_傷I2CP = new ColorP(X0Y1_傷I2, 傷I2CD, DisUnit, abj: true);
    		X0Y1_傷I3CP = new ColorP(X0Y1_傷I3, 傷I3CD, DisUnit, abj: true);
    		X0Y1_傷I4CP = new ColorP(X0Y1_傷I4, 傷I4CD, DisUnit, abj: true);
    		X0Y1_傷XCP = new ColorP(X0Y1_傷X, 傷XCD, DisUnit, abj: true);
    		X0Y1_ハイライト1CP = new ColorP(X0Y1_ハイライト1, ハイライト1CD, DisUnit, abj: true);
    		X0Y1_ハイライト2CP = new ColorP(X0Y1_ハイライト2, ハイライト2CD, DisUnit, abj: true);
    		X0Y1_パンストCP = new ColorP(X0Y1_パンスト, パンストCD, DisUnit, abj: false);
    		X0Y1_パンスト_ハイライトCP = new ColorP(X0Y1_パンスト_ハイライト, パンスト_ハイライトCD, DisUnit, abj: true);
    		X0Y1_ニーハイ_ニーハイ1CP = new ColorP(X0Y1_ニーハイ_ニーハイ1, ニーハイ_ニーハイ1CD, DisUnit, abj: true);
    		X0Y1_ニーハイ_ニーハイ2CP = new ColorP(X0Y1_ニーハイ_ニーハイ2, ニーハイ_ニーハイ2CD, DisUnit, abj: true);
    		X0Y1_ニーハイ_ハイライトCP = new ColorP(X0Y1_ニーハイ_ハイライト, ニーハイ_ハイライトCD, DisUnit, abj: true);
    		X0Y2_腿CP = new ColorP(X0Y2_腿, 腿2CD, DisUnit, abj: true);
    		X0Y2_筋CP = new ColorP(X0Y2_筋, 筋CD, DisUnit, abj: false);
    		X0Y2_獣性_獣毛1CP = new ColorP(X0Y2_獣性_獣毛1, 獣性_獣毛1_2CD, DisUnit, abj: true);
    		X0Y2_獣性_獣毛2CP = new ColorP(X0Y2_獣性_獣毛2, 獣性_獣毛2_2CD, DisUnit, abj: true);
    		X0Y2_淫タトゥ_ハート_タトゥ左CP = new ColorP(X0Y2_淫タトゥ_ハート_タトゥ左, 淫タトゥ_ハート_タトゥ左CD, DisUnit, abj: true);
    		X0Y2_淫タトゥ_ハート_タトゥ右CP = new ColorP(X0Y2_淫タトゥ_ハート_タトゥ右, 淫タトゥ_ハート_タトゥ右CD, DisUnit, abj: true);
    		X0Y2_淫タトゥ_タトゥ右1CP = new ColorP(X0Y2_淫タトゥ_タトゥ右1, 淫タトゥ_タトゥ右1CD, DisUnit, abj: true);
    		X0Y2_淫タトゥ_タトゥ右2CP = new ColorP(X0Y2_淫タトゥ_タトゥ右2, 淫タトゥ_タトゥ右2CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字b_枠CP = new ColorP(X0Y2_悪タトゥ1_文字_文字b_枠, 悪タトゥ1_文字_文字b_枠CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1CP = new ColorP(X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1, 悪タトゥ1_文字_文字b_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2CP = new ColorP(X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2, 悪タトゥ1_文字_文字b_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字c_枠CP = new ColorP(X0Y2_悪タトゥ1_文字_文字c_枠, 悪タトゥ1_文字_文字c_枠CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1CP = new ColorP(X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1, 悪タトゥ1_文字_文字c_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2CP = new ColorP(X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2, 悪タトゥ1_文字_文字c_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字d_枠CP = new ColorP(X0Y2_悪タトゥ1_文字_文字d_枠, 悪タトゥ1_文字_文字d_枠CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1CP = new ColorP(X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1, 悪タトゥ1_文字_文字d_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2CP = new ColorP(X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2, 悪タトゥ1_文字_文字d_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字e_枠CP = new ColorP(X0Y2_悪タトゥ1_文字_文字e_枠, 悪タトゥ1_文字_文字e_枠CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1CP = new ColorP(X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1, 悪タトゥ1_文字_文字e_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2CP = new ColorP(X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2, 悪タトゥ1_文字_文字e_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3CP = new ColorP(X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3, 悪タトゥ1_文字_文字e_文字タトゥ3CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字a_枠CP = new ColorP(X0Y2_悪タトゥ1_文字_文字a_枠, 悪タトゥ1_文字_文字a_枠CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1CP = new ColorP(X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1, 悪タトゥ1_文字_文字a_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2CP = new ColorP(X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2, 悪タトゥ1_文字_文字a_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_タトゥ1CP = new ColorP(X0Y2_悪タトゥ1_タトゥ1, 悪タトゥ1_タトゥ1CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ1_タトゥ2CP = new ColorP(X0Y2_悪タトゥ1_タトゥ2, 悪タトゥ1_タトゥ2CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ2_逆十字_逆十字1CP = new ColorP(X0Y2_悪タトゥ2_逆十字_逆十字1, 悪タトゥ2_逆十字_逆十字1CD, DisUnit, abj: true);
    		X0Y2_悪タトゥ2_逆十字_逆十字2CP = new ColorP(X0Y2_悪タトゥ2_逆十字_逆十字2, 悪タトゥ2_逆十字_逆十字2CD, DisUnit, abj: true);
    		X0Y2_植性_通常_葉3CP = new ColorP(X0Y2_植性_通常_葉3, 植性_葉3_2CD, DisUnit, abj: true);
    		X0Y2_植性_通常_葉2CP = new ColorP(X0Y2_植性_通常_葉2, 植性_葉2_2CD, DisUnit, abj: true);
    		X0Y2_植性_通常_葉1CP = new ColorP(X0Y2_植性_通常_葉1, 植性_葉1_2CD, DisUnit, abj: true);
    		X0Y2_植性_欠損_葉3CP = new ColorP(X0Y2_植性_欠損_葉3, 植性_葉3_2CD, DisUnit, abj: true);
    		X0Y2_植性_欠損_葉2CP = new ColorP(X0Y2_植性_欠損_葉2, 植性_葉2_2CD, DisUnit, abj: true);
    		X0Y2_植性_欠損_葉1CP = new ColorP(X0Y2_植性_欠損_葉1, 植性_葉1_2CD, DisUnit, abj: true);
    		X0Y2_傷I1CP = new ColorP(X0Y2_傷I1, 傷I1CD, DisUnit, abj: true);
    		X0Y2_傷I2CP = new ColorP(X0Y2_傷I2, 傷I2CD, DisUnit, abj: true);
    		X0Y2_傷I3CP = new ColorP(X0Y2_傷I3, 傷I3CD, DisUnit, abj: true);
    		X0Y2_ハイライト1CP = new ColorP(X0Y2_ハイライト1, ハイライト1CD, DisUnit, abj: true);
    		X0Y2_ハイライト2CP = new ColorP(X0Y2_ハイライト2, ハイライト2CD, DisUnit, abj: true);
    		X0Y2_パンストCP = new ColorP(X0Y2_パンスト, パンストCD, DisUnit, abj: false);
    		X0Y2_パンスト_ハイライトCP = new ColorP(X0Y2_パンスト_ハイライト, パンスト_ハイライトCD, DisUnit, abj: true);
    		X0Y2_ニーハイ_ニーハイ1CP = new ColorP(X0Y2_ニーハイ_ニーハイ1, ニーハイ_ニーハイ1CD, DisUnit, abj: true);
    		X0Y2_ニーハイ_ニーハイ2CP = new ColorP(X0Y2_ニーハイ_ニーハイ2, ニーハイ_ニーハイ2CD, DisUnit, abj: true);
    		X0Y2_ニーハイ_ハイライトCP = new ColorP(X0Y2_ニーハイ_ハイライト, ニーハイ_ハイライトCD, DisUnit, abj: true);
    		X0Y3_腿CP = new ColorP(X0Y3_腿, 腿3CD, DisUnit, abj: true);
    		X0Y3_筋CP = new ColorP(X0Y3_筋, 筋CD, DisUnit, abj: false);
    		X0Y3_獣性_獣毛1CP = new ColorP(X0Y3_獣性_獣毛1, 獣性_獣毛1_3CD, DisUnit, abj: true);
    		X0Y3_獣性_獣毛2CP = new ColorP(X0Y3_獣性_獣毛2, 獣性_獣毛2_3CD, DisUnit, abj: true);
    		X0Y3_淫タトゥ_タトゥ左1CP = new ColorP(X0Y3_淫タトゥ_タトゥ左1, 淫タトゥ_タトゥ左1CD, DisUnit, abj: true);
    		X0Y3_淫タトゥ_タトゥ右1CP = new ColorP(X0Y3_淫タトゥ_タトゥ右1, 淫タトゥ_タトゥ右1CD, DisUnit, abj: true);
    		X0Y3_淫タトゥ_タトゥ左2CP = new ColorP(X0Y3_淫タトゥ_タトゥ左2, 淫タトゥ_タトゥ左2CD, DisUnit, abj: true);
    		X0Y3_淫タトゥ_タトゥ右2CP = new ColorP(X0Y3_淫タトゥ_タトゥ右2, 淫タトゥ_タトゥ右2CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字c_枠CP = new ColorP(X0Y3_悪タトゥ1_文字_文字c_枠, 悪タトゥ1_文字_文字c_枠CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1CP = new ColorP(X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1, 悪タトゥ1_文字_文字c_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2CP = new ColorP(X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2, 悪タトゥ1_文字_文字c_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字d_枠CP = new ColorP(X0Y3_悪タトゥ1_文字_文字d_枠, 悪タトゥ1_文字_文字d_枠CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1CP = new ColorP(X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1, 悪タトゥ1_文字_文字d_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2CP = new ColorP(X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2, 悪タトゥ1_文字_文字d_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字e_枠CP = new ColorP(X0Y3_悪タトゥ1_文字_文字e_枠, 悪タトゥ1_文字_文字e_枠CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1CP = new ColorP(X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1, 悪タトゥ1_文字_文字e_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2CP = new ColorP(X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2, 悪タトゥ1_文字_文字e_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3CP = new ColorP(X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3, 悪タトゥ1_文字_文字e_文字タトゥ3CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字a_枠CP = new ColorP(X0Y3_悪タトゥ1_文字_文字a_枠, 悪タトゥ1_文字_文字a_枠CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1CP = new ColorP(X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1, 悪タトゥ1_文字_文字a_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2CP = new ColorP(X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2, 悪タトゥ1_文字_文字a_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字b_枠CP = new ColorP(X0Y3_悪タトゥ1_文字_文字b_枠, 悪タトゥ1_文字_文字b_枠CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1CP = new ColorP(X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1, 悪タトゥ1_文字_文字b_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2CP = new ColorP(X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2, 悪タトゥ1_文字_文字b_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_タトゥ1CP = new ColorP(X0Y3_悪タトゥ1_タトゥ1, 悪タトゥ1_タトゥ1CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ1_タトゥ2CP = new ColorP(X0Y3_悪タトゥ1_タトゥ2, 悪タトゥ1_タトゥ2CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ2_逆十字_逆十字1CP = new ColorP(X0Y3_悪タトゥ2_逆十字_逆十字1, 悪タトゥ2_逆十字_逆十字1CD, DisUnit, abj: true);
    		X0Y3_悪タトゥ2_逆十字_逆十字2CP = new ColorP(X0Y3_悪タトゥ2_逆十字_逆十字2, 悪タトゥ2_逆十字_逆十字2CD, DisUnit, abj: true);
    		X0Y3_鱗_鱗1CP = new ColorP(X0Y3_鱗_鱗1, 竜性_鱗1CD, DisUnit, abj: true);
    		X0Y3_鱗_鱗2CP = new ColorP(X0Y3_鱗_鱗2, 竜性_鱗2CD, DisUnit, abj: true);
    		X0Y3_鱗_鱗3CP = new ColorP(X0Y3_鱗_鱗3, 竜性_鱗3CD, DisUnit, abj: true);
    		X0Y3_鱗_鱗4CP = new ColorP(X0Y3_鱗_鱗4, 竜性_鱗4CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋1CP = new ColorP(X0Y3_紋柄_紋1, 紋柄_紋1CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋2CP = new ColorP(X0Y3_紋柄_紋2, 紋柄_紋2CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋3CP = new ColorP(X0Y3_紋柄_紋3, 紋柄_紋3CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋4CP = new ColorP(X0Y3_紋柄_紋4, 紋柄_紋4CD, DisUnit, abj: true);
    		X0Y3_植性_通常_葉3CP = new ColorP(X0Y3_植性_通常_葉3, 植性_葉3_3CD, DisUnit, abj: true);
    		X0Y3_植性_通常_葉2CP = new ColorP(X0Y3_植性_通常_葉2, 植性_葉2_3CD, DisUnit, abj: true);
    		X0Y3_植性_通常_葉1CP = new ColorP(X0Y3_植性_通常_葉1, 植性_葉1_3CD, DisUnit, abj: true);
    		X0Y3_植性_欠損_葉3CP = new ColorP(X0Y3_植性_欠損_葉3, 植性_葉3_3CD, DisUnit, abj: true);
    		X0Y3_植性_欠損_葉2CP = new ColorP(X0Y3_植性_欠損_葉2, 植性_葉2_3CD, DisUnit, abj: true);
    		X0Y3_植性_欠損_葉1CP = new ColorP(X0Y3_植性_欠損_葉1, 植性_葉1_3CD, DisUnit, abj: true);
    		X0Y3_傷I1CP = new ColorP(X0Y3_傷I1, 傷I1CD, DisUnit, abj: true);
    		X0Y3_傷I2CP = new ColorP(X0Y3_傷I2, 傷I2CD, DisUnit, abj: true);
    		X0Y3_傷I3CP = new ColorP(X0Y3_傷I3, 傷I3CD, DisUnit, abj: true);
    		X0Y3_傷XCP = new ColorP(X0Y3_傷X, 傷XCD, DisUnit, abj: true);
    		X0Y3_ハイライト1CP = new ColorP(X0Y3_ハイライト1, ハイライト1CD, DisUnit, abj: true);
    		X0Y3_ハイライト2CP = new ColorP(X0Y3_ハイライト2, ハイライト2CD, DisUnit, abj: true);
    		X0Y3_パンストCP = new ColorP(X0Y3_パンスト, パンストCD, DisUnit, abj: false);
    		X0Y3_パンスト_ハイライトCP = new ColorP(X0Y3_パンスト_ハイライト, パンスト_ハイライトCD, DisUnit, abj: true);
    		X0Y3_ニーハイ_ニーハイ1CP = new ColorP(X0Y3_ニーハイ_ニーハイ1, ニーハイ_ニーハイ1CD, DisUnit, abj: true);
    		X0Y3_ニーハイ_ニーハイ2CP = new ColorP(X0Y3_ニーハイ_ニーハイ2, ニーハイ_ニーハイ2CD, DisUnit, abj: true);
    		X0Y3_ニーハイ_ハイライトCP = new ColorP(X0Y3_ニーハイ_ハイライト, ニーハイ_ハイライトCD, DisUnit, abj: true);
    		X0Y4_腿CP = new ColorP(X0Y4_腿, 腿4CD, DisUnit, abj: true);
    		X0Y4_筋CP = new ColorP(X0Y4_筋, 筋CD, DisUnit, abj: false);
    		X0Y4_獣性_獣毛1CP = new ColorP(X0Y4_獣性_獣毛1, 獣性_獣毛1_4CD, DisUnit, abj: true);
    		X0Y4_獣性_獣毛2CP = new ColorP(X0Y4_獣性_獣毛2, 獣性_獣毛2_4CD, DisUnit, abj: true);
    		X0Y4_淫タトゥ_タトゥ左1CP = new ColorP(X0Y4_淫タトゥ_タトゥ左1, 淫タトゥ_タトゥ左1CD, DisUnit, abj: true);
    		X0Y4_淫タトゥ_タトゥ右1CP = new ColorP(X0Y4_淫タトゥ_タトゥ右1, 淫タトゥ_タトゥ右1CD, DisUnit, abj: true);
    		X0Y4_淫タトゥ_タトゥ左2CP = new ColorP(X0Y4_淫タトゥ_タトゥ左2, 淫タトゥ_タトゥ左2CD, DisUnit, abj: true);
    		X0Y4_淫タトゥ_タトゥ右2CP = new ColorP(X0Y4_淫タトゥ_タトゥ右2, 淫タトゥ_タトゥ右2CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字d_枠CP = new ColorP(X0Y4_悪タトゥ1_文字_文字d_枠, 悪タトゥ1_文字_文字d_枠CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1CP = new ColorP(X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1, 悪タトゥ1_文字_文字d_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2CP = new ColorP(X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2, 悪タトゥ1_文字_文字d_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字e_枠CP = new ColorP(X0Y4_悪タトゥ1_文字_文字e_枠, 悪タトゥ1_文字_文字e_枠CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1CP = new ColorP(X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1, 悪タトゥ1_文字_文字e_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2CP = new ColorP(X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2, 悪タトゥ1_文字_文字e_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3CP = new ColorP(X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3, 悪タトゥ1_文字_文字e_文字タトゥ3CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字a_枠CP = new ColorP(X0Y4_悪タトゥ1_文字_文字a_枠, 悪タトゥ1_文字_文字a_枠CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1CP = new ColorP(X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1, 悪タトゥ1_文字_文字a_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2CP = new ColorP(X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2, 悪タトゥ1_文字_文字a_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字b_枠CP = new ColorP(X0Y4_悪タトゥ1_文字_文字b_枠, 悪タトゥ1_文字_文字b_枠CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1CP = new ColorP(X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1, 悪タトゥ1_文字_文字b_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2CP = new ColorP(X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2, 悪タトゥ1_文字_文字b_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字c_枠CP = new ColorP(X0Y4_悪タトゥ1_文字_文字c_枠, 悪タトゥ1_文字_文字c_枠CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1CP = new ColorP(X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1, 悪タトゥ1_文字_文字c_文字タトゥ1CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2CP = new ColorP(X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2, 悪タトゥ1_文字_文字c_文字タトゥ2CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_タトゥ1CP = new ColorP(X0Y4_悪タトゥ1_タトゥ1, 悪タトゥ1_タトゥ1CD, DisUnit, abj: true);
    		X0Y4_悪タトゥ1_タトゥ2CP = new ColorP(X0Y4_悪タトゥ1_タトゥ2, 悪タトゥ1_タトゥ2CD, DisUnit, abj: true);
    		X0Y4_鱗_鱗1CP = new ColorP(X0Y4_鱗_鱗1, 竜性_鱗1CD, DisUnit, abj: true);
    		X0Y4_鱗_鱗2CP = new ColorP(X0Y4_鱗_鱗2, 竜性_鱗2CD, DisUnit, abj: true);
    		X0Y4_鱗_鱗3CP = new ColorP(X0Y4_鱗_鱗3, 竜性_鱗3CD, DisUnit, abj: true);
    		X0Y4_鱗_鱗4CP = new ColorP(X0Y4_鱗_鱗4, 竜性_鱗4CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋1CP = new ColorP(X0Y4_紋柄_紋1, 紋柄_紋1CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋2CP = new ColorP(X0Y4_紋柄_紋2, 紋柄_紋2CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋3CP = new ColorP(X0Y4_紋柄_紋3, 紋柄_紋3CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋4CP = new ColorP(X0Y4_紋柄_紋4, 紋柄_紋4CD, DisUnit, abj: true);
    		X0Y4_植性_通常_葉3CP = new ColorP(X0Y4_植性_通常_葉3, 植性_葉3_4CD, DisUnit, abj: true);
    		X0Y4_植性_通常_葉2CP = new ColorP(X0Y4_植性_通常_葉2, 植性_葉2_4CD, DisUnit, abj: true);
    		X0Y4_植性_通常_葉1CP = new ColorP(X0Y4_植性_通常_葉1, 植性_葉1_4CD, DisUnit, abj: true);
    		X0Y4_植性_欠損_葉3CP = new ColorP(X0Y4_植性_欠損_葉3, 植性_葉3_4CD, DisUnit, abj: true);
    		X0Y4_植性_欠損_葉2CP = new ColorP(X0Y4_植性_欠損_葉2, 植性_葉2_4CD, DisUnit, abj: true);
    		X0Y4_植性_欠損_葉1CP = new ColorP(X0Y4_植性_欠損_葉1, 植性_葉1_4CD, DisUnit, abj: true);
    		X0Y4_傷I1CP = new ColorP(X0Y4_傷I1, 傷I1CD, DisUnit, abj: true);
    		X0Y4_傷XCP = new ColorP(X0Y4_傷X, 傷XCD, DisUnit, abj: true);
    		X0Y4_ハイライト1CP = new ColorP(X0Y4_ハイライト1, ハイライト1CD, DisUnit, abj: true);
    		X0Y4_ハイライト2CP = new ColorP(X0Y4_ハイライト2, ハイライト2CD, DisUnit, abj: true);
    		X0Y4_パンストCP = new ColorP(X0Y4_パンスト, パンストCD, DisUnit, abj: false);
    		X0Y4_パンスト_ハイライトCP = new ColorP(X0Y4_パンスト_ハイライト, パンスト_ハイライトCD, DisUnit, abj: true);
    		X0Y4_ニーハイ_ニーハイ1CP = new ColorP(X0Y4_ニーハイ_ニーハイ1, ニーハイ_ニーハイ1CD, DisUnit, abj: true);
    		X0Y4_ニーハイ_ニーハイ2CP = new ColorP(X0Y4_ニーハイ_ニーハイ2, ニーハイ_ニーハイ2CD, DisUnit, abj: true);
    		X0Y4_ニーハイ_ハイライトCP = new ColorP(X0Y4_ニーハイ_ハイライト, ニーハイ_ハイライトCD, DisUnit, abj: true);
    		if (e.スライム)
    		{
    			スライム();
    		}
    		筋肉濃度 = e.筋肉濃度;
    		傷I1濃度 = e.傷I1濃度;
    		傷I2濃度 = e.傷I2濃度;
    		傷I3濃度 = e.傷I3濃度;
    		傷I4濃度 = e.傷I4濃度;
    		傷X濃度 = e.傷X濃度;
    		ハイライト濃度 = e.ハイライト濃度;
    		Intensity = e.濃度;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		switch (Body.GetIndexY())
    		{
    		case 0:
    			Are.Draw(X0Y0_腿);
    			Are.Draw(X0Y0_筋);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字a_枠);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字b_枠);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字c_枠);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字d_枠);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字e_枠);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2);
    			Are.Draw(X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3);
    			Are.Draw(X0Y0_悪タトゥ1_タトゥ1);
    			Are.Draw(X0Y0_悪タトゥ1_タトゥ2);
    			Are.Draw(X0Y0_獣性_獣毛1);
    			Are.Draw(X0Y0_獣性_獣毛2);
    			Are.Draw(X0Y0_淫タトゥ_ハート_タトゥ左);
    			Are.Draw(X0Y0_淫タトゥ_ハート_タトゥ右);
    			Are.Draw(X0Y0_淫タトゥ_タトゥ左1);
    			Are.Draw(X0Y0_淫タトゥ_タトゥ右1);
    			Are.Draw(X0Y0_淫タトゥ_タトゥ左2);
    			Are.Draw(X0Y0_淫タトゥ_タトゥ右2);
    			Are.Draw(X0Y0_悪タトゥ2_逆十字_逆十字1);
    			Are.Draw(X0Y0_悪タトゥ2_逆十字_逆十字2);
    			Are.Draw(X0Y0_植性_通常_葉3);
    			Are.Draw(X0Y0_植性_欠損_葉3);
    			Are.Draw(X0Y0_植性_通常_葉2);
    			Are.Draw(X0Y0_植性_欠損_葉2);
    			Are.Draw(X0Y0_竜性_鱗1);
    			Are.Draw(X0Y0_竜性_鱗2);
    			Are.Draw(X0Y0_竜性_鱗3);
    			Are.Draw(X0Y0_竜性_鱗4);
    			Are.Draw(X0Y0_紋柄_紋1);
    			Are.Draw(X0Y0_紋柄_紋2);
    			Are.Draw(X0Y0_紋柄_紋3);
    			Are.Draw(X0Y0_紋柄_紋4);
    			Are.Draw(X0Y0_植性_通常_葉1);
    			Are.Draw(X0Y0_植性_欠損_葉1);
    			Are.Draw(X0Y0_虫性_器官1);
    			Are.Draw(X0Y0_虫性_器官2);
    			Are.Draw(X0Y0_傷I1);
    			Are.Draw(X0Y0_傷I2);
    			Are.Draw(X0Y0_傷I3);
    			Are.Draw(X0Y0_傷I4);
    			Are.Draw(X0Y0_傷X);
    			キスマーク.Draw(Are);
    			鞭痕.Draw(Are);
    			Are.Draw(X0Y0_ハイライト1);
    			Are.Draw(X0Y0_ハイライト2);
    			Are.Draw(X0Y0_パンスト);
    			Are.Draw(X0Y0_パンスト_ハイライト);
    			Are.Draw(X0Y0_ニーハイ_ニーハイ1);
    			Are.Draw(X0Y0_ニーハイ_ニーハイ2);
    			Are.Draw(X0Y0_ニーハイ_ハイライト);
    			break;
    		case 1:
    			Are.Draw(X0Y1_腿);
    			Are.Draw(X0Y1_筋);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字a_枠);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字b_枠);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字c_枠);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字d_枠);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字e_枠);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2);
    			Are.Draw(X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3);
    			Are.Draw(X0Y1_悪タトゥ1_タトゥ1);
    			Are.Draw(X0Y1_悪タトゥ1_タトゥ2);
    			Are.Draw(X0Y1_獣性_獣毛1);
    			Are.Draw(X0Y1_獣性_獣毛2);
    			Are.Draw(X0Y1_淫タトゥ_ハート_タトゥ左);
    			Are.Draw(X0Y1_淫タトゥ_ハート_タトゥ右);
    			Are.Draw(X0Y1_淫タトゥ_タトゥ左1);
    			Are.Draw(X0Y1_淫タトゥ_タトゥ右1);
    			Are.Draw(X0Y1_淫タトゥ_タトゥ左2);
    			Are.Draw(X0Y1_淫タトゥ_タトゥ右2);
    			Are.Draw(X0Y1_悪タトゥ2_逆十字_逆十字1);
    			Are.Draw(X0Y1_悪タトゥ2_逆十字_逆十字2);
    			Are.Draw(X0Y1_植性_通常_葉3);
    			Are.Draw(X0Y1_植性_欠損_葉3);
    			Are.Draw(X0Y1_植性_通常_葉2);
    			Are.Draw(X0Y1_植性_欠損_葉2);
    			Are.Draw(X0Y1_鱗_鱗1);
    			Are.Draw(X0Y1_鱗_鱗2);
    			Are.Draw(X0Y1_鱗_鱗3);
    			Are.Draw(X0Y1_鱗_鱗4);
    			Are.Draw(X0Y1_紋柄_紋1);
    			Are.Draw(X0Y1_紋柄_紋2);
    			Are.Draw(X0Y1_紋柄_紋3);
    			Are.Draw(X0Y1_紋柄_紋4);
    			Are.Draw(X0Y1_植性_通常_葉1);
    			Are.Draw(X0Y1_植性_欠損_葉1);
    			Are.Draw(X0Y1_虫性_器官1);
    			Are.Draw(X0Y1_虫性_器官2);
    			Are.Draw(X0Y1_傷I1);
    			Are.Draw(X0Y1_傷I2);
    			Are.Draw(X0Y1_傷I3);
    			Are.Draw(X0Y1_傷I4);
    			Are.Draw(X0Y1_傷X);
    			キスマーク.Draw(Are);
    			鞭痕.Draw(Are);
    			Are.Draw(X0Y1_ハイライト1);
    			Are.Draw(X0Y1_ハイライト2);
    			Are.Draw(X0Y1_パンスト);
    			Are.Draw(X0Y1_パンスト_ハイライト);
    			Are.Draw(X0Y1_ニーハイ_ニーハイ1);
    			Are.Draw(X0Y1_ニーハイ_ニーハイ2);
    			Are.Draw(X0Y1_ニーハイ_ハイライト);
    			break;
    		case 2:
    			Are.Draw(X0Y2_腿);
    			Are.Draw(X0Y2_筋);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字b_枠);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字c_枠);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字d_枠);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字e_枠);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字a_枠);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1);
    			Are.Draw(X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2);
    			Are.Draw(X0Y2_悪タトゥ1_タトゥ1);
    			Are.Draw(X0Y2_悪タトゥ1_タトゥ2);
    			Are.Draw(X0Y2_獣性_獣毛1);
    			Are.Draw(X0Y2_獣性_獣毛2);
    			Are.Draw(X0Y2_淫タトゥ_ハート_タトゥ左);
    			Are.Draw(X0Y2_淫タトゥ_ハート_タトゥ右);
    			Are.Draw(X0Y2_淫タトゥ_タトゥ右1);
    			Are.Draw(X0Y2_淫タトゥ_タトゥ右2);
    			Are.Draw(X0Y2_悪タトゥ2_逆十字_逆十字1);
    			Are.Draw(X0Y2_悪タトゥ2_逆十字_逆十字2);
    			Are.Draw(X0Y2_植性_通常_葉3);
    			Are.Draw(X0Y2_植性_欠損_葉3);
    			Are.Draw(X0Y2_植性_通常_葉2);
    			Are.Draw(X0Y2_植性_欠損_葉2);
    			Are.Draw(X0Y2_植性_通常_葉1);
    			Are.Draw(X0Y2_植性_欠損_葉1);
    			Are.Draw(X0Y2_傷I1);
    			Are.Draw(X0Y2_傷I2);
    			Are.Draw(X0Y2_傷I3);
    			キスマーク.Draw(Are);
    			鞭痕.Draw(Are);
    			Are.Draw(X0Y2_ハイライト1);
    			Are.Draw(X0Y2_ハイライト2);
    			Are.Draw(X0Y2_パンスト);
    			Are.Draw(X0Y2_パンスト_ハイライト);
    			Are.Draw(X0Y2_ニーハイ_ニーハイ1);
    			Are.Draw(X0Y2_ニーハイ_ニーハイ2);
    			Are.Draw(X0Y2_ニーハイ_ハイライト);
    			break;
    		case 3:
    			Are.Draw(X0Y3_腿);
    			Are.Draw(X0Y3_筋);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字c_枠);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字d_枠);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字e_枠);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字a_枠);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字b_枠);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1);
    			Are.Draw(X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2);
    			Are.Draw(X0Y3_悪タトゥ1_タトゥ1);
    			Are.Draw(X0Y3_悪タトゥ1_タトゥ2);
    			Are.Draw(X0Y3_獣性_獣毛1);
    			Are.Draw(X0Y3_獣性_獣毛2);
    			Are.Draw(X0Y3_淫タトゥ_タトゥ左1);
    			Are.Draw(X0Y3_淫タトゥ_タトゥ右1);
    			Are.Draw(X0Y3_淫タトゥ_タトゥ左2);
    			Are.Draw(X0Y3_淫タトゥ_タトゥ右2);
    			Are.Draw(X0Y3_悪タトゥ2_逆十字_逆十字1);
    			Are.Draw(X0Y3_悪タトゥ2_逆十字_逆十字2);
    			Are.Draw(X0Y3_植性_通常_葉3);
    			Are.Draw(X0Y3_植性_欠損_葉3);
    			Are.Draw(X0Y3_植性_通常_葉2);
    			Are.Draw(X0Y3_植性_欠損_葉2);
    			Are.Draw(X0Y3_鱗_鱗1);
    			Are.Draw(X0Y3_鱗_鱗2);
    			Are.Draw(X0Y3_鱗_鱗3);
    			Are.Draw(X0Y3_鱗_鱗4);
    			Are.Draw(X0Y3_紋柄_紋1);
    			Are.Draw(X0Y3_紋柄_紋2);
    			Are.Draw(X0Y3_紋柄_紋3);
    			Are.Draw(X0Y3_紋柄_紋4);
    			Are.Draw(X0Y3_植性_通常_葉1);
    			Are.Draw(X0Y3_植性_欠損_葉1);
    			Are.Draw(X0Y3_傷I1);
    			Are.Draw(X0Y3_傷I2);
    			Are.Draw(X0Y3_傷I3);
    			Are.Draw(X0Y3_傷X);
    			キスマーク.Draw(Are);
    			鞭痕.Draw(Are);
    			Are.Draw(X0Y3_ハイライト1);
    			Are.Draw(X0Y3_ハイライト2);
    			Are.Draw(X0Y3_パンスト);
    			Are.Draw(X0Y3_パンスト_ハイライト);
    			Are.Draw(X0Y3_ニーハイ_ニーハイ1);
    			Are.Draw(X0Y3_ニーハイ_ニーハイ2);
    			Are.Draw(X0Y3_ニーハイ_ハイライト);
    			break;
    		default:
    			Are.Draw(X0Y4_腿);
    			Are.Draw(X0Y4_筋);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字d_枠);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字e_枠);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字a_枠);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字b_枠);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字c_枠);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1);
    			Are.Draw(X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2);
    			Are.Draw(X0Y4_悪タトゥ1_タトゥ1);
    			Are.Draw(X0Y4_悪タトゥ1_タトゥ2);
    			Are.Draw(X0Y4_獣性_獣毛1);
    			Are.Draw(X0Y4_獣性_獣毛2);
    			Are.Draw(X0Y4_淫タトゥ_タトゥ左1);
    			Are.Draw(X0Y4_淫タトゥ_タトゥ右1);
    			Are.Draw(X0Y4_淫タトゥ_タトゥ左2);
    			Are.Draw(X0Y4_淫タトゥ_タトゥ右2);
    			Are.Draw(X0Y4_植性_通常_葉3);
    			Are.Draw(X0Y4_植性_欠損_葉3);
    			Are.Draw(X0Y4_植性_通常_葉2);
    			Are.Draw(X0Y4_植性_欠損_葉2);
    			Are.Draw(X0Y4_鱗_鱗1);
    			Are.Draw(X0Y4_鱗_鱗2);
    			Are.Draw(X0Y4_鱗_鱗3);
    			Are.Draw(X0Y4_鱗_鱗4);
    			Are.Draw(X0Y4_紋柄_紋1);
    			Are.Draw(X0Y4_紋柄_紋2);
    			Are.Draw(X0Y4_紋柄_紋3);
    			Are.Draw(X0Y4_紋柄_紋4);
    			Are.Draw(X0Y4_植性_通常_葉1);
    			Are.Draw(X0Y4_植性_欠損_葉1);
    			Are.Draw(X0Y4_傷I1);
    			Are.Draw(X0Y4_傷X);
    			キスマーク.Draw(Are);
    			鞭痕.Draw(Are);
    			Are.Draw(X0Y4_ハイライト1);
    			Are.Draw(X0Y4_ハイライト2);
    			Are.Draw(X0Y4_パンスト);
    			Are.Draw(X0Y4_パンスト_ハイライト);
    			Are.Draw(X0Y4_ニーハイ_ニーハイ1);
    			Are.Draw(X0Y4_ニーハイ_ニーハイ2);
    			Are.Draw(X0Y4_ニーハイ_ハイライト);
    			break;
    		}
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_腿.SetAngleBase(num * -8.53773646251594E-07);
    		X0Y1_腿.SetAngleBase(num * -313.0);
    		X0Y2_腿.SetAngleBase(num * -271.0);
    		X0Y3_腿.SetAngleBase(num * -222.0);
    		X0Y4_腿.SetAngleBase(num * -182.0);
    		Body.JoinPAall();
    	}

    	public void 虫性()
    	{
    		X0Y0_腿.GetOP()[(!右) ? 4 : 0].Outline = true;
    		X0Y1_腿.GetOP()[(!右) ? 4 : 0].Outline = true;
    		X0Y2_腿.GetOP()[右 ? 4 : 0].Outline = true;
    		X0Y3_腿.GetOP()[(!右) ? 4 : 0].Outline = true;
    		X0Y4_腿.GetOP()[右 ? 4 : 0].Outline = true;
    	}

    	public void スライム()
    	{
    		X0Y0_腿.GetOP()[右 ? 4 : 0].Outline = false;
    		X0Y0_腿.GetOP()[(!右) ? 1 : 3].Outline = false;
    		X0Y0_腿.GetOP()[右 ? 2 : 2].Outline = false;
    		X0Y0_腿.GetOP()[右 ? 1 : 3].Outline = false;
    		X0Y1_腿.GetOP()[右 ? 4 : 0].Outline = false;
    		X0Y1_腿.GetOP()[(!右) ? 1 : 3].Outline = false;
    		X0Y1_腿.GetOP()[右 ? 2 : 2].Outline = false;
    		X0Y1_腿.GetOP()[右 ? 1 : 3].Outline = false;
    		X0Y2_腿.GetOP()[(!右) ? 1 : 3].Outline = false;
    		X0Y2_腿.GetOP()[右 ? 2 : 2].Outline = false;
    		X0Y2_腿.GetOP()[右 ? 1 : 3].Outline = false;
    		X0Y2_腿.GetOP()[(!右) ? 4 : 0].Outline = false;
    		X0Y3_腿.GetOP()[右 ? 4 : 0].Outline = false;
    		X0Y3_腿.GetOP()[(!右) ? 1 : 3].Outline = false;
    		X0Y3_腿.GetOP()[右 ? 2 : 2].Outline = false;
    		X0Y3_腿.GetOP()[右 ? 1 : 3].Outline = false;
    		X0Y4_腿.GetOP()[(!右) ? 1 : 3].Outline = false;
    		X0Y4_腿.GetOP()[右 ? 2 : 2].Outline = false;
    		X0Y4_腿.GetOP()[右 ? 1 : 3].Outline = false;
    		X0Y4_腿.GetOP()[(!右) ? 4 : 0].Outline = false;
    		Color Col = Color.FromArgb(128, 腿0CD.c2.Col2);
    		腿0CD.色 = new Color2(ref 腿0CD.c2.Col1, ref Col);
    		腿1CD.色 = new Color2(ref 腿1CD.c2.Col1, ref Col);
    		腿2CD.色 = new Color2(ref 腿2CD.c2.Col1, ref Col);
    		腿3CD.色 = new Color2(ref 腿3CD.c2.Col1, ref Col);
    		腿4CD.色 = new Color2(ref 腿4CD.c2.Col1, ref Col);
    	}

    	public override bool Is布(ShapePart p)
    	{
    		if (p != X0Y0_パンスト && p != X0Y0_パンスト_ハイライト && p != X0Y0_ニーハイ_ニーハイ1 && p != X0Y0_ニーハイ_ニーハイ2 && p != X0Y0_ニーハイ_ハイライト && p != X0Y1_パンスト && p != X0Y1_パンスト_ハイライト && p != X0Y1_ニーハイ_ニーハイ1 && p != X0Y1_ニーハイ_ニーハイ2 && p != X0Y1_ニーハイ_ハイライト && p != X0Y2_パンスト && p != X0Y2_パンスト_ハイライト && p != X0Y2_ニーハイ_ニーハイ1 && p != X0Y2_ニーハイ_ニーハイ2 && p != X0Y2_ニーハイ_ハイライト && p != X0Y3_パンスト && p != X0Y3_パンスト_ハイライト && p != X0Y3_ニーハイ_ニーハイ1 && p != X0Y3_ニーハイ_ニーハイ2 && p != X0Y3_ニーハイ_ハイライト && p != X0Y4_パンスト && p != X0Y4_パンスト_ハイライト && p != X0Y4_ニーハイ_ニーハイ1 && p != X0Y4_ニーハイ_ニーハイ2)
    		{
    			return p == X0Y4_ニーハイ_ハイライト;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		switch (Body.GetIndexY())
    		{
    		case 0:
    			X0Y0_腿CP.Update();
    			X0Y0_筋CP.Update();
    			X0Y0_獣性_獣毛1CP.Update();
    			X0Y0_獣性_獣毛2CP.Update();
    			X0Y0_淫タトゥ_ハート_タトゥ左CP.Update();
    			X0Y0_淫タトゥ_ハート_タトゥ右CP.Update();
    			X0Y0_淫タトゥ_タトゥ左1CP.Update();
    			X0Y0_淫タトゥ_タトゥ右1CP.Update();
    			X0Y0_淫タトゥ_タトゥ左2CP.Update();
    			X0Y0_淫タトゥ_タトゥ右2CP.Update();
    			X0Y0_悪タトゥ1_文字_文字a_枠CP.Update();
    			X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1CP.Update();
    			X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2CP.Update();
    			X0Y0_悪タトゥ1_文字_文字b_枠CP.Update();
    			X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1CP.Update();
    			X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2CP.Update();
    			X0Y0_悪タトゥ1_文字_文字c_枠CP.Update();
    			X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1CP.Update();
    			X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2CP.Update();
    			X0Y0_悪タトゥ1_文字_文字d_枠CP.Update();
    			X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1CP.Update();
    			X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2CP.Update();
    			X0Y0_悪タトゥ1_文字_文字e_枠CP.Update();
    			X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1CP.Update();
    			X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2CP.Update();
    			X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3CP.Update();
    			X0Y0_悪タトゥ1_タトゥ1CP.Update();
    			X0Y0_悪タトゥ1_タトゥ2CP.Update();
    			X0Y0_悪タトゥ2_逆十字_逆十字1CP.Update();
    			X0Y0_悪タトゥ2_逆十字_逆十字2CP.Update();
    			X0Y0_竜性_鱗1CP.Update();
    			X0Y0_竜性_鱗2CP.Update();
    			X0Y0_竜性_鱗3CP.Update();
    			X0Y0_竜性_鱗4CP.Update();
    			X0Y0_紋柄_紋1CP.Update();
    			X0Y0_紋柄_紋2CP.Update();
    			X0Y0_紋柄_紋3CP.Update();
    			X0Y0_紋柄_紋4CP.Update();
    			X0Y0_植性_通常_葉3CP.Update();
    			X0Y0_植性_通常_葉2CP.Update();
    			X0Y0_植性_通常_葉1CP.Update();
    			X0Y0_植性_欠損_葉3CP.Update();
    			X0Y0_植性_欠損_葉2CP.Update();
    			X0Y0_植性_欠損_葉1CP.Update();
    			X0Y0_虫性_器官1CP.Update();
    			X0Y0_虫性_器官2CP.Update();
    			X0Y0_傷I1CP.Update();
    			X0Y0_傷I2CP.Update();
    			X0Y0_傷I3CP.Update();
    			X0Y0_傷I4CP.Update();
    			X0Y0_傷XCP.Update();
    			X0Y0_ハイライト1CP.Update();
    			X0Y0_ハイライト2CP.Update();
    			X0Y0_パンストCP.Update();
    			X0Y0_パンスト_ハイライトCP.Update();
    			X0Y0_ニーハイ_ニーハイ1CP.Update();
    			X0Y0_ニーハイ_ニーハイ2CP.Update();
    			X0Y0_ニーハイ_ハイライトCP.Update();
    			break;
    		case 1:
    			X0Y1_腿CP.Update();
    			X0Y1_筋CP.Update();
    			X0Y1_獣性_獣毛1CP.Update();
    			X0Y1_獣性_獣毛2CP.Update();
    			X0Y1_淫タトゥ_ハート_タトゥ左CP.Update();
    			X0Y1_淫タトゥ_ハート_タトゥ右CP.Update();
    			X0Y1_淫タトゥ_タトゥ左1CP.Update();
    			X0Y1_淫タトゥ_タトゥ右1CP.Update();
    			X0Y1_淫タトゥ_タトゥ左2CP.Update();
    			X0Y1_淫タトゥ_タトゥ右2CP.Update();
    			X0Y1_悪タトゥ1_文字_文字a_枠CP.Update();
    			X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1CP.Update();
    			X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2CP.Update();
    			X0Y1_悪タトゥ1_文字_文字b_枠CP.Update();
    			X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1CP.Update();
    			X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2CP.Update();
    			X0Y1_悪タトゥ1_文字_文字c_枠CP.Update();
    			X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1CP.Update();
    			X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2CP.Update();
    			X0Y1_悪タトゥ1_文字_文字d_枠CP.Update();
    			X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1CP.Update();
    			X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2CP.Update();
    			X0Y1_悪タトゥ1_文字_文字e_枠CP.Update();
    			X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1CP.Update();
    			X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2CP.Update();
    			X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3CP.Update();
    			X0Y1_悪タトゥ1_タトゥ1CP.Update();
    			X0Y1_悪タトゥ1_タトゥ2CP.Update();
    			X0Y1_悪タトゥ2_逆十字_逆十字1CP.Update();
    			X0Y1_悪タトゥ2_逆十字_逆十字2CP.Update();
    			X0Y1_鱗_鱗1CP.Update();
    			X0Y1_鱗_鱗2CP.Update();
    			X0Y1_鱗_鱗3CP.Update();
    			X0Y1_鱗_鱗4CP.Update();
    			X0Y1_紋柄_紋1CP.Update();
    			X0Y1_紋柄_紋2CP.Update();
    			X0Y1_紋柄_紋3CP.Update();
    			X0Y1_紋柄_紋4CP.Update();
    			X0Y1_植性_通常_葉3CP.Update();
    			X0Y1_植性_通常_葉2CP.Update();
    			X0Y1_植性_通常_葉1CP.Update();
    			X0Y1_植性_欠損_葉3CP.Update();
    			X0Y1_植性_欠損_葉2CP.Update();
    			X0Y1_植性_欠損_葉1CP.Update();
    			X0Y1_虫性_器官1CP.Update();
    			X0Y1_虫性_器官2CP.Update();
    			X0Y1_傷I1CP.Update();
    			X0Y1_傷I2CP.Update();
    			X0Y1_傷I3CP.Update();
    			X0Y1_傷I4CP.Update();
    			X0Y1_傷XCP.Update();
    			X0Y1_ハイライト1CP.Update();
    			X0Y1_ハイライト2CP.Update();
    			X0Y1_パンストCP.Update();
    			X0Y1_パンスト_ハイライトCP.Update();
    			X0Y1_ニーハイ_ニーハイ1CP.Update();
    			X0Y1_ニーハイ_ニーハイ2CP.Update();
    			X0Y1_ニーハイ_ハイライトCP.Update();
    			break;
    		case 2:
    			X0Y2_腿CP.Update();
    			X0Y2_筋CP.Update();
    			X0Y2_獣性_獣毛1CP.Update();
    			X0Y2_獣性_獣毛2CP.Update();
    			X0Y2_淫タトゥ_ハート_タトゥ左CP.Update();
    			X0Y2_淫タトゥ_ハート_タトゥ右CP.Update();
    			X0Y2_淫タトゥ_タトゥ右1CP.Update();
    			X0Y2_淫タトゥ_タトゥ右2CP.Update();
    			X0Y2_悪タトゥ1_文字_文字b_枠CP.Update();
    			X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1CP.Update();
    			X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2CP.Update();
    			X0Y2_悪タトゥ1_文字_文字c_枠CP.Update();
    			X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1CP.Update();
    			X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2CP.Update();
    			X0Y2_悪タトゥ1_文字_文字d_枠CP.Update();
    			X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1CP.Update();
    			X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2CP.Update();
    			X0Y2_悪タトゥ1_文字_文字e_枠CP.Update();
    			X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1CP.Update();
    			X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2CP.Update();
    			X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3CP.Update();
    			X0Y2_悪タトゥ1_文字_文字a_枠CP.Update();
    			X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1CP.Update();
    			X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2CP.Update();
    			X0Y2_悪タトゥ1_タトゥ1CP.Update();
    			X0Y2_悪タトゥ1_タトゥ2CP.Update();
    			X0Y2_悪タトゥ2_逆十字_逆十字1CP.Update();
    			X0Y2_悪タトゥ2_逆十字_逆十字2CP.Update();
    			X0Y2_植性_通常_葉3CP.Update();
    			X0Y2_植性_通常_葉2CP.Update();
    			X0Y2_植性_通常_葉1CP.Update();
    			X0Y2_植性_欠損_葉3CP.Update();
    			X0Y2_植性_欠損_葉2CP.Update();
    			X0Y2_植性_欠損_葉1CP.Update();
    			X0Y2_傷I1CP.Update();
    			X0Y2_傷I2CP.Update();
    			X0Y2_傷I3CP.Update();
    			X0Y2_ハイライト1CP.Update();
    			X0Y2_ハイライト2CP.Update();
    			X0Y2_パンストCP.Update();
    			X0Y2_パンスト_ハイライトCP.Update();
    			X0Y2_ニーハイ_ニーハイ1CP.Update();
    			X0Y2_ニーハイ_ニーハイ2CP.Update();
    			X0Y2_ニーハイ_ハイライトCP.Update();
    			break;
    		case 3:
    			X0Y3_腿CP.Update();
    			X0Y3_筋CP.Update();
    			X0Y3_獣性_獣毛1CP.Update();
    			X0Y3_獣性_獣毛2CP.Update();
    			X0Y3_淫タトゥ_タトゥ左1CP.Update();
    			X0Y3_淫タトゥ_タトゥ右1CP.Update();
    			X0Y3_淫タトゥ_タトゥ左2CP.Update();
    			X0Y3_淫タトゥ_タトゥ右2CP.Update();
    			X0Y3_悪タトゥ1_文字_文字c_枠CP.Update();
    			X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1CP.Update();
    			X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2CP.Update();
    			X0Y3_悪タトゥ1_文字_文字d_枠CP.Update();
    			X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1CP.Update();
    			X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2CP.Update();
    			X0Y3_悪タトゥ1_文字_文字e_枠CP.Update();
    			X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1CP.Update();
    			X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2CP.Update();
    			X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3CP.Update();
    			X0Y3_悪タトゥ1_文字_文字a_枠CP.Update();
    			X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1CP.Update();
    			X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2CP.Update();
    			X0Y3_悪タトゥ1_文字_文字b_枠CP.Update();
    			X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1CP.Update();
    			X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2CP.Update();
    			X0Y3_悪タトゥ1_タトゥ1CP.Update();
    			X0Y3_悪タトゥ1_タトゥ2CP.Update();
    			X0Y3_悪タトゥ2_逆十字_逆十字1CP.Update();
    			X0Y3_悪タトゥ2_逆十字_逆十字2CP.Update();
    			X0Y3_鱗_鱗1CP.Update();
    			X0Y3_鱗_鱗2CP.Update();
    			X0Y3_鱗_鱗3CP.Update();
    			X0Y3_鱗_鱗4CP.Update();
    			X0Y3_紋柄_紋1CP.Update();
    			X0Y3_紋柄_紋2CP.Update();
    			X0Y3_紋柄_紋3CP.Update();
    			X0Y3_紋柄_紋4CP.Update();
    			X0Y3_植性_通常_葉3CP.Update();
    			X0Y3_植性_通常_葉2CP.Update();
    			X0Y3_植性_通常_葉1CP.Update();
    			X0Y3_植性_欠損_葉3CP.Update();
    			X0Y3_植性_欠損_葉2CP.Update();
    			X0Y3_植性_欠損_葉1CP.Update();
    			X0Y3_傷I1CP.Update();
    			X0Y3_傷I2CP.Update();
    			X0Y3_傷I3CP.Update();
    			X0Y3_傷XCP.Update();
    			X0Y3_ハイライト1CP.Update();
    			X0Y3_ハイライト2CP.Update();
    			X0Y3_パンストCP.Update();
    			X0Y3_パンスト_ハイライトCP.Update();
    			X0Y3_ニーハイ_ニーハイ1CP.Update();
    			X0Y3_ニーハイ_ニーハイ2CP.Update();
    			X0Y3_ニーハイ_ハイライトCP.Update();
    			break;
    		default:
    			X0Y4_腿CP.Update();
    			X0Y4_筋CP.Update();
    			X0Y4_獣性_獣毛1CP.Update();
    			X0Y4_獣性_獣毛2CP.Update();
    			X0Y4_淫タトゥ_タトゥ左1CP.Update();
    			X0Y4_淫タトゥ_タトゥ右1CP.Update();
    			X0Y4_淫タトゥ_タトゥ左2CP.Update();
    			X0Y4_淫タトゥ_タトゥ右2CP.Update();
    			X0Y4_悪タトゥ1_文字_文字d_枠CP.Update();
    			X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1CP.Update();
    			X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2CP.Update();
    			X0Y4_悪タトゥ1_文字_文字e_枠CP.Update();
    			X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1CP.Update();
    			X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2CP.Update();
    			X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3CP.Update();
    			X0Y4_悪タトゥ1_文字_文字a_枠CP.Update();
    			X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1CP.Update();
    			X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2CP.Update();
    			X0Y4_悪タトゥ1_文字_文字b_枠CP.Update();
    			X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1CP.Update();
    			X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2CP.Update();
    			X0Y4_悪タトゥ1_文字_文字c_枠CP.Update();
    			X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1CP.Update();
    			X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2CP.Update();
    			X0Y4_悪タトゥ1_タトゥ1CP.Update();
    			X0Y4_悪タトゥ1_タトゥ2CP.Update();
    			X0Y4_鱗_鱗1CP.Update();
    			X0Y4_鱗_鱗2CP.Update();
    			X0Y4_鱗_鱗3CP.Update();
    			X0Y4_鱗_鱗4CP.Update();
    			X0Y4_紋柄_紋1CP.Update();
    			X0Y4_紋柄_紋2CP.Update();
    			X0Y4_紋柄_紋3CP.Update();
    			X0Y4_紋柄_紋4CP.Update();
    			X0Y4_植性_通常_葉3CP.Update();
    			X0Y4_植性_通常_葉2CP.Update();
    			X0Y4_植性_通常_葉1CP.Update();
    			X0Y4_植性_欠損_葉3CP.Update();
    			X0Y4_植性_欠損_葉2CP.Update();
    			X0Y4_植性_欠損_葉1CP.Update();
    			X0Y4_傷I1CP.Update();
    			X0Y4_傷XCP.Update();
    			X0Y4_ハイライト1CP.Update();
    			X0Y4_ハイライト2CP.Update();
    			X0Y4_パンストCP.Update();
    			X0Y4_パンスト_ハイライトCP.Update();
    			X0Y4_ニーハイ_ニーハイ1CP.Update();
    			X0Y4_ニーハイ_ニーハイ2CP.Update();
    			X0Y4_ニーハイ_ハイライトCP.Update();
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
    		case 配色指定.T1:
    			配色T1(体配色);
    			break;
    		case 配色指定.T0:
    			配色T0(体配色);
    			break;
    		case 配色指定.C0:
    			配色C0(体配色);
    			break;
    		case 配色指定.CT1:
    			配色CT1(体配色);
    			break;
    		case 配色指定.CT0:
    			配色CT0(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		腿0CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌R);
    		腿1CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌R);
    		腿2CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		腿3CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		腿4CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
    		獣性_獣毛1_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛2_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛1_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛2_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛1_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛1_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛1_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		淫タトゥ_ハート_タトゥ左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ左1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ左2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ1_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_タトゥ1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ1_タトゥ2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ2_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ2_逆十字_逆十字2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		竜性_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		紋柄_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		植性_葉3_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉2_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉1_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉3_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉2_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉1_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉3_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉2_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉1_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉3_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉2_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉1_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉3_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉2_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉1_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		虫性_器官1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		虫性_器官2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		傷I1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷XCD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		ハイライト1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2R);
    		パンストCD = new ColorD();
    		パンスト_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ニーハイ_ニーハイ1CD = new ColorD();
    		ニーハイ_ニーハイ2CD = new ColorD();
    		ニーハイ_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		腿0CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌R);
    		腿1CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌R);
    		腿2CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		腿3CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		腿4CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
    		獣性_獣毛1_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛2_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛1_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛2_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛1_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛1_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛1_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		淫タトゥ_ハート_タトゥ左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ左1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ左2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ1_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_タトゥ1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ1_タトゥ2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ2_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ2_逆十字_逆十字2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		竜性_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		紋柄_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		植性_葉3_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉2_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		植性_葉1_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉3_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉2_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		植性_葉1_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉3_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉2_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉1_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉3_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉2_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉1_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉3_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉2_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉1_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		虫性_器官1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		虫性_器官2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		傷I1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷XCD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		ハイライト1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2R);
    		パンストCD = new ColorD();
    		パンスト_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ニーハイ_ニーハイ1CD = new ColorD();
    		ニーハイ_ニーハイ2CD = new ColorD();
    		ニーハイ_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		腿0CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌R);
    		腿1CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌R);
    		腿2CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		腿3CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		腿4CD = new ColorD(ref ColorHelper.Black, ref 体配色.人肌O);
    		筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
    		獣性_獣毛1_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛2_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛1_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛2_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛1_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛1_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛1_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		淫タトゥ_ハート_タトゥ左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ左1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ左2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ1_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_タトゥ1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ1_タトゥ2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ2_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ2_逆十字_逆十字2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		竜性_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		紋柄_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		植性_葉3_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		植性_葉2_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉1_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		植性_葉3_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		植性_葉2_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉1_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		植性_葉3_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉2_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉1_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉3_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉2_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉1_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉3_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉2_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉1_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		虫性_器官1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		虫性_器官2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		傷I1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷XCD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		ハイライト1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2R);
    		パンストCD = new ColorD();
    		パンスト_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ニーハイ_ニーハイ1CD = new ColorD();
    		ニーハイ_ニーハイ2CD = new ColorD();
    		ニーハイ_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    	}

    	private void 配色C0(BodyColorSet 体配色)
    	{
    		腿0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0R);
    		腿1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0R);
    		腿2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		腿3CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		腿4CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
    		獣性_獣毛1_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛2_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛1_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛2_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛1_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛1_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛1_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		淫タトゥ_ハート_タトゥ左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ左1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ左2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ1_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_タトゥ1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ1_タトゥ2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ2_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ2_逆十字_逆十字2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		竜性_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		紋柄_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		植性_葉3_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉2_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉1_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉3_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉2_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉1_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉3_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉2_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉1_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉3_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉2_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉1_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉3_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉2_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉1_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		虫性_器官1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		虫性_器官2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		傷I1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷XCD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		ハイライト1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2R);
    		パンストCD = new ColorD();
    		パンスト_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ニーハイ_ニーハイ1CD = new ColorD();
    		ニーハイ_ニーハイ2CD = new ColorD();
    		ニーハイ_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    	}

    	private void 配色CT1(BodyColorSet 体配色)
    	{
    		腿0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0R);
    		腿1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0R);
    		腿2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		腿3CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		腿4CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
    		獣性_獣毛1_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛2_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛1_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛2_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛1_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛1_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛1_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		淫タトゥ_ハート_タトゥ左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ左1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ左2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ1_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_タトゥ1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ1_タトゥ2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ2_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ2_逆十字_逆十字2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		竜性_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		紋柄_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		植性_葉3_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉2_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		植性_葉1_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉3_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉2_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		植性_葉1_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉3_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉2_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉1_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉3_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉2_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉1_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉3_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉2_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉1_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		虫性_器官1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		虫性_器官2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		傷I1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷XCD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		ハイライト1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2R);
    		パンストCD = new ColorD();
    		パンスト_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ニーハイ_ニーハイ1CD = new ColorD();
    		ニーハイ_ニーハイ2CD = new ColorD();
    		ニーハイ_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    	}

    	private void 配色CT0(BodyColorSet 体配色)
    	{
    		腿0CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0R);
    		腿1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0R);
    		腿2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		腿3CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		腿4CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲0O);
    		筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
    		獣性_獣毛1_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛2_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛1_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛2_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0R);
    		獣性_獣毛1_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛1_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛1_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		獣性_獣毛2_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.毛0O);
    		淫タトゥ_ハート_タトゥ左CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_ハート_タトゥ右CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ左1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ左2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		淫タトゥ_タトゥ右2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ1_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ1_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
    		悪タトゥ1_タトゥ1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ1_タトゥ2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		悪タトゥ2_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
    		悪タトゥ2_逆十字_逆十字2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青);
    		竜性_鱗1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗2CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		竜性_鱗3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		竜性_鱗4CD = new ColorD(ref ColorHelper.Black, ref 体配色.鱗0O);
    		紋柄_紋1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		紋柄_紋4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.紋O);
    		植性_葉3_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		植性_葉2_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉1_0CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		植性_葉3_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		植性_葉2_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1R);
    		植性_葉1_1CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青R);
    		植性_葉3_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉2_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉1_2CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉3_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉2_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉1_3CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉3_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		植性_葉2_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.植1O);
    		植性_葉1_4CD = new ColorD(ref ColorHelper.Black, ref 体配色.刺青O);
    		虫性_器官1CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		虫性_器官2CD = new ColorD(ref ColorHelper.Black, ref 体配色.甲1R);
    		傷I1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I3CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷I4CD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		傷XCD = new ColorD(ref ColorHelper.Empty, ref 体配色.粘膜);
    		ハイライト1CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ハイライト2CD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2R);
    		パンストCD = new ColorD();
    		パンスト_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    		ニーハイ_ニーハイ1CD = new ColorD();
    		ニーハイ_ニーハイ2CD = new ColorD();
    		ニーハイ_ハイライトCD = new ColorD(ref ColorHelper.Empty, ref 体配色.ハイライト2O);
    	}
    }
}
