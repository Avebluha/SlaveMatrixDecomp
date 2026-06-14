using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 体色
    {
    	public List<string> 血統 = new List<string>();

    	public Color 髪 = Color.Orange;

    	public Color 眉 = Color.Orange;

    	public Color 睫 = ColorHelper.Black;

    	public Color 髭 = ColorHelper.White;

    	public Color 体0 = Color.Orange;

    	public Color 体1 = Color.Yellow;

    	public Color 毛0 = Color.Orange;

    	public Color 毛1 = ColorHelper.White;

    	public Color 羽0 = Color.Orange;

    	public Color 羽1 = ColorHelper.White;

    	public Color 鱗0 = Color.OrangeRed;

    	public Color 鱗1 = Color.Yellow;

    	public Color 甲0 = Color.Orange;

    	public Color 甲1 = Color.Yellow;

    	public Color 植0 = Color.Orange;

    	public Color 植1 = Color.Yellow;

    	public Color 薔 = Color.Red;

    	public Color 百 = ColorHelper.White;

    	public Color 柄 = Color.Brown;

    	public Color 紋 = Color.OrangeRed;

    	public Color 人肌 = Color.FromArgb(255, 255, 207, 169);

    	public Color 粘膜 = ColorHelper.Empty;

    	public Color 目左 = Color.Yellow;

    	public Color 目右 = Color.Yellow;

    	public Color 縦目 = Color.Yellow;

    	public Color 頬目左 = Color.Yellow;

    	public Color 頬目右 = Color.Yellow;

    	public Color 白部 = ColorHelper.White;

    	public Color 歯 = ColorHelper.White;

    	public Color 爪 = ColorHelper.White;

    	public Color 角0 = ColorHelper.White;

    	public Color 角1 = ColorHelper.White;

    	public Color 膜 = Color.OrangeRed;

    	public Color 眼0 = Color.Red;

    	public Color 眼1 = Color.Red;

    	public Color 眼2 = Color.Red;

    	public Color コア = Color.Red;

    	public Color 秘石 = Color.Red;

    	public Color 後光 = Color.Yellow;

    	public Color 口紅 = ColorHelper.Empty;

    	public Color 刺青 = ColorHelper.Black;

    	public Color 尿 = Color.Gold;

    	public Color 体液 = ColorHelper.White;

    	public Color 母乳 = Color.PapayaWhip;

    	public Color 血 = Color.FromArgb(255, 184, 6, 18);

    	public static HashSet<string> 変異色 = new HashSet<string>(new string[40]
    	{
    		"髪", "眉", "睫", "髭", "体0", "体1", "毛0", "毛1", "羽0", "羽1",
    		"鱗0", "鱗1", "甲0", "甲1", "植0", "植1", "薔", "百", "柄", "紋",
    		"人肌", "粘膜", "目左", "目右", "縦目", "頬目左", "頬目右", "白部", "爪", "角0",
    		"角1", "膜", "眼0", "眼1", "眼2", "コア", "秘石", "後光", "口紅", "刺青"
    	});

    	public 体色()
    	{
    	}

    	public 体色(bool b0)
    	{
    		int num = Rng.XS.Next(360);
    		foreach (FieldInfo item in from e in GetType().GetFields()
    			where e.FieldType.ToString() == GlobalState.ct
    			select e)
    		{
    			HSV.ToRGB(num + Rng.XS.Next(5), Rng.XS.NextM(0, 223), Rng.XS.NextM(128, 255), out var ret);
    			item.SetValue(this, ret);
    		}
    		ColorHelper.GetRandomColor(out 目左);
    		目右 = 目左;
    		縦目 = 目左;
    		頬目左 = 目左;
    		頬目右 = 目左;
    		眉 = 髪;
    		毛0 = 眉;
    		睫 = ColorHelper.Black;
    		Hsv hsv;
    		if (b0)
    		{
    			ColorHelper.GetSkinColor(out 人肌);
    			血 = Color.FromArgb(255, 184, 6, 18);
    		}
    		else
    		{
    			ColorHelper.GetRandomSkinColor(out 人肌);
    			hsv = new Hsv(ref 人肌);
    			hsv.H = num;
    			hsv.GetColor(out 人肌);
    			血 = Color.Empty;
    		}
    		粘膜 = ColorHelper.Empty;
    		if (b0)
    		{
    			白部 = ColorHelper.White;
    		}
    		else if (0.1.Lot())
    		{
    			白部 = ColorHelper.Black;
    		}
    		else
    		{
    			白部 = ColorHelper.White;
    		}
    		歯 = Color.PapayaWhip;
    		爪 = (Rng.XS.NextBool() ? Color.PapayaWhip : ColorHelper.Black);
    		角0 = Color.LightGray;
    		角1 = ColorHelper.DarkGray;
    		口紅 = ColorHelper.Empty;
    		刺青 = Color.FromArgb(255 - 人肌.R, 255 - 人肌.G, 255 - 人肌.B);
    		hsv = new Hsv(ref 刺青);
    		hsv.S = 255;
    		hsv.GetColor(out 刺青);
    		後光 = Color.Yellow;
    		体液 = ColorHelper.White;
    		母乳 = Color.PapayaWhip;
    		尿 = Color.Gold;
    		紋 = 刺青;
    	}
    }
}
