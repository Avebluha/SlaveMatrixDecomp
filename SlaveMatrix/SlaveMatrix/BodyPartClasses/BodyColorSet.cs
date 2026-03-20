using System.Drawing;

namespace SlaveMatrix
{
    public class BodyColorSet
    {
    	public Color2 髪O;

    	public Color2 髪R;

    	public Color2 眉O;

    	public Color2 眉R;

    	public Color2 髭O;

    	public Color2 髭R;

    	public Color2 膜O;

    	public Color2 膜R;

    	public Color2 目左O;

    	public Color2 目左R;

    	public Color2 目右O;

    	public Color2 目右R;

    	public Color2 縦目O;

    	public Color2 縦目R;

    	public Color2 頬目左O;

    	public Color2 頬目左R;

    	public Color2 頬目右O;

    	public Color2 頬目右R;

    	public Color2 人肌O;

    	public Color2 人肌R;

    	public Color2 白部O;

    	public Color2 白部R;

    	public Color2 爪O;

    	public Color2 爪R;

    	public Color2 角0O;

    	public Color2 角0R;

    	public Color2 角1O;

    	public Color2 角1R;

    	public Color2 体0O;

    	public Color2 体0R;

    	public Color2 体1O;

    	public Color2 体1R;

    	public Color2 毛0O;

    	public Color2 毛0R;

    	public Color2 毛1O;

    	public Color2 毛1R;

    	public Color2 羽0O;

    	public Color2 羽0R;

    	public Color2 羽1O;

    	public Color2 羽1R;

    	public Color2 鱗0O;

    	public Color2 鱗0R;

    	public Color2 鱗1O;

    	public Color2 鱗1R;

    	public Color2 甲0O;

    	public Color2 甲0R;

    	public Color2 甲1O;

    	public Color2 甲1R;

    	public Color2 植0O;

    	public Color2 植0R;

    	public Color2 植1O;

    	public Color2 植1R;

    	public Color2 薔O;

    	public Color2 薔R;

    	public Color2 百O;

    	public Color2 百R;

    	public Color2 柄O;

    	public Color2 柄R;

    	public Color2 紋O;

    	public Color2 紋R;

    	public Color2 眼0O;

    	public Color2 眼0R;

    	public Color2 眼1O;

    	public Color2 眼1R;

    	public Color2 眼2O;

    	public Color2 眼2R;

    	public Color2 コアO;

    	public Color2 コアR;

    	public Color2 秘石O;

    	public Color2 秘石R;

    	public Color2 後光O;

    	public Color2 後光R;

    	public Color2 血液O;

    	public Color2 血液R;

    	public Color2 ハートO;

    	public Color2 ハートR;

    	public Color2 影O;

    	public Color2 影R;

    	public Color2 ハイライト;

    	public Color2 ハイライト2O;

    	public Color2 ハイライト2R;

    	public Color2 睫毛;

    	public Color2 瞳孔;

    	public Color2 肌濃;

    	public Color2 毛濃;

    	public Color2 粘膜;

    	public Color2 粘膜穴;

    	public Color2 舌;

    	public Color2 紅潮;

    	public Color2 口紅;

    	public Color2 刺青;

    	public Color2 刺青O;

    	public Color2 刺青R;

    	public Color2 歯;

    	public Color2 体液;

    	public Color2 母乳;

    	public Color2 尿;

    	public Color2 呼気;

    	public Color2 湯気;

    	public Color2 染み;

    	public Color 紅潮線;

    	public Color 粘膜線;

    	public Color 髪線;

    	public Color 薄線;

    	public Color 体液線;

    	public Color 母乳線;

    	public Color 尿線;

    	public BodyColorSet(体色 色)
    	{
    		if (色.粘膜 == Col.Empty)
    		{
    			Col.GetMucosaColor(ref 色.人肌, out 色.粘膜);
    		}
    		if (色.口紅 == Col.Empty)
    		{
    			色.口紅 = 色.粘膜;
    		}
    		Col.GetGrad(ref 色.髪, out 髪O);
    		髪O.GetRep(out 髪R);
    		Col.GetGrad(ref 色.眉, out 眉O);
    		眉O.GetRep(out 眉R);
    		Col.GetGrad(ref 色.髭, out 髭O);
    		髭O.GetRep(out 髭R);
    		Col.GetGrad(ref 色.膜, out 膜O);
    		膜O.GetRep(out 膜R);
    		目左O = new Color2(ref Col.Black, ref 色.目左);
    		目左O.GetRep(out 目左R);
    		目右O = new Color2(ref Col.Black, ref 色.目右);
    		目右O.GetRep(out 目右R);
    		縦目O = new Color2(ref Col.Black, ref 色.縦目);
    		縦目O.GetRep(out 縦目R);
    		頬目左O = new Color2(ref Col.Black, ref 色.頬目左);
    		頬目左O.GetRep(out 頬目左R);
    		頬目右O = new Color2(ref Col.Black, ref 色.頬目右);
    		頬目右O.GetRep(out 頬目右R);
    		Col.GetSkinGrad(ref 色.人肌, out 人肌O);
    		人肌O.GetRep(out 人肌R);
    		Col.GetGrad(ref 色.白部, out 白部O);
    		白部O.GetRep(out 白部R);
    		Col.GetGrad(ref 色.爪, out 爪O);
    		爪O.GetRep(out 爪R);
    		Col.GetGrad(ref 色.角0, out 角0O);
    		角0O.GetRep(out 角0R);
    		Col.GetGrad(ref 色.角1, out 角1O);
    		角1O.GetRep(out 角1R);
    		Col.GetGrad(ref 色.体0, out 体0O);
    		体0O.GetRep(out 体0R);
    		Col.GetGrad(ref 色.体1, out 体1O);
    		体1O.GetRep(out 体1R);
    		Col.GetGrad(ref 色.毛0, out 毛0O);
    		毛0O.GetRep(out 毛0R);
    		Col.GetGrad(ref 色.毛1, out 毛1O);
    		毛1O.GetRep(out 毛1R);
    		Col.GetGrad(ref 色.羽0, out 羽0O);
    		羽0O.GetRep(out 羽0R);
    		Col.GetGrad(ref 色.羽1, out 羽1O);
    		羽1O.GetRep(out 羽1R);
    		Col.GetGrad(ref 色.鱗0, out 鱗0O);
    		鱗0O.GetRep(out 鱗0R);
    		Col.GetGrad(ref 色.鱗1, out 鱗1O);
    		鱗1O.GetRep(out 鱗1R);
    		Col.GetGrad(ref 色.甲0, out 甲0O);
    		甲0O.GetRep(out 甲0R);
    		Col.GetGrad(ref 色.甲1, out 甲1O);
    		甲1O.GetRep(out 甲1R);
    		Col.GetGrad(ref 色.植0, out 植0O);
    		植0O.GetRep(out 植0R);
    		Col.GetGrad(ref 色.植1, out 植1O);
    		植1O.GetRep(out 植1R);
    		Col.GetGrad(ref 色.薔, out 薔O);
    		薔O.GetRep(out 薔R);
    		Col.GetGrad(ref 色.百, out 百O);
    		百O.GetRep(out 百R);
    		Col.GetGrad(ref 色.柄, out 柄O);
    		柄O.GetRep(out 柄R);
    		Col.GetGrad(ref 色.紋, out 紋O);
    		紋O.GetRep(out 紋R);
    		眼0O = new Color2(ref Col.Black, ref 色.眼0);
    		眼0O.GetRep(out 眼0R);
    		眼1O = new Color2(ref Col.Black, ref 色.眼1);
    		眼1O.GetRep(out 眼1R);
    		眼2O = new Color2(ref Col.Black, ref 色.眼2);
    		眼2O.GetRep(out 眼2R);
    		コアO = new Color2(ref Col.Black, ref 色.コア);
    		コアO.GetRep(out コアR);
    		秘石O = new Color2(ref Col.Black, ref 色.秘石);
    		秘石O.GetRep(out 秘石R);
    		後光O = new Color2(ref Col.White, ref 色.後光);
    		後光O.GetRep(out 後光R);
    		if (色.血 == Col.Empty)
    		{
    			Col.Add(ref 色.粘膜, 0, 255, -50, out 色.血);
    		}
    		Col.GetGrad(ref 色.血, out 血液O);
    		血液O.GetRep(out 血液R);
    		Col.GetGrad(ref 色.粘膜, out ハートO);
    		ハートO.GetRep(out ハートR);
    		影O = new Color2(ref Col.Gray, ref Col.DarkGray);
    		Col.Alpha(ref 影O, 50, out 影O);
    		影O.GetRep(out 影R);
    		ハイライト = new Color2(ref Col.White, ref Col.Empty);
    		ハイライト2O.Col1 = Col.White;
    		ハイライト2O.Col2 = Color.FromArgb(0, Col.White);
    		ハイライト2O.GetRep(out ハイライト2R);
    		睫毛 = new Color2(ref 色.睫, ref Col.Empty);
    		瞳孔 = new Color2(ref Col.Black, ref Col.Empty);
    		Col.GetSkinColor2(ref 色.人肌, out 肌濃.Col1);
    		肌濃.Col1 = Color.FromArgb(90, 肌濃.Col1);
    		肌濃.Col2 = Col.Empty;
    		Col.GetSkinColor2(ref 色.毛0, out 毛濃.Col1);
    		毛濃.Col1 = Color.FromArgb(90, 毛濃.Col1);
    		毛濃.Col2 = Col.Empty;
    		粘膜 = new Color2(ref 色.粘膜, ref Col.Empty);
    		粘膜穴.Col1 = Color.FromArgb(80, Col.Black);
    		粘膜穴.Col2 = 粘膜.Col2;
    		Col.GetGrad(ref 色.粘膜, out 舌);
    		紅潮.Col1 = Color.FromArgb(60, 色.粘膜);
    		紅潮.Col2 = Col.Empty;
    		口紅.Col1 = Color.FromArgb(100, 色.口紅);
    		口紅.Col2 = Col.Empty;
    		刺青 = new Color2(ref 色.刺青, ref Col.Empty);
    		刺青O = new Color2(ref 色.刺青, ref 色.刺青);
    		刺青R = new Color2(ref 色.刺青, ref 色.刺青);
    		歯 = new Color2(ref 色.歯, ref Col.Empty);
    		体液.Col1 = 色.体液;
    		体液.Col2 = Color.FromArgb(0, 色.体液);
    		母乳 = new Color2(ref 色.母乳, ref Col.Empty);
    		尿.Col1 = Color.FromArgb(160, 色.尿);
    		尿.Col2 = Col.Empty;
    		呼気.Col1 = Color.FromArgb(50, Col.White);
    		呼気.Col2 = Col.Empty;
    		湯気.Col1 = Color.FromArgb(50, Col.White);
    		湯気.Col2 = Col.Empty;
    		染み.Col1 = Color.FromArgb(50, Col.Black);
    		染み.Col2 = Col.Empty;
    		Col.Mul(ref 色.粘膜, 1.0, 2.0, 1.0, out 紅潮線);
    		紅潮線 = Color.FromArgb(180, 紅潮線);
    		Col.Mul(ref 色.粘膜, 1.0, 2.0, 0.5, out 粘膜線);
    		粘膜線 = Color.FromArgb(80, 粘膜線);
    		髪線 = Color.FromArgb(100, Col.Black);
    		薄線 = Color.FromArgb(45, Col.Black);
    		体液線 = Color.FromArgb(60, 色.体液);
    		母乳線 = Color.FromArgb(80, 色.母乳);
    		尿線 = Color.FromArgb(80, 色.尿);
    	}
    }
}
