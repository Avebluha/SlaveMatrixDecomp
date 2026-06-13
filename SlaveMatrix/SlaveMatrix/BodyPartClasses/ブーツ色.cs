using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct ブーツ色
    {
    	public Color 生地1;

    	public Color 生地2;

    	public Color 縁;

    	public Color 柄;

    	public Color 紐;

    	public Color 金具;

    	public Color 穴;

    	public Color 靴底;

    	public Color 踵;

    	public Color2 生地1色;

    	public Color2 生地2色;

    	public Color2 縁色;

    	public Color2 柄色;

    	public Color2 紐色;

    	public Color2 金具色;

    	public Color2 穴色;

    	public Color2 靴底色;

    	public Color2 踵色;

    	public void SetDefault()
    	{
    		ColorHelper.Add(ref ColorHelper.DarkGreen, 0, 0, -50, out 生地1);
    		ColorHelper.Add(ref ColorHelper.Indigo, 0, 0, -50, out 生地2);
    		縁 = Color.Gold;
    		柄 = Color.Gold;
    		紐 = ColorHelper.Black;
    		金具 = Color.Gray;
    		穴 = ColorHelper.Black;
    		靴底 = ColorHelper.Black;
    		踵 = ColorHelper.Black;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		ColorHelper.GetRandomClothesColor(out 生地1);
    		ColorHelper.GetRandomClothesColor(out 生地2);
    		ColorHelper.GetRandomClothesColor(out 縁);
    		柄 = 縁;
    		ColorHelper.GetRandomClothesColor(out 紐);
    		ColorHelper.GetRandomClothesColor(out 金具);
    		穴 = 紐;
    		靴底 = 紐;
    		踵 = 紐;
    		SetColor2();
    	}

    	public void SetColor2()
    	{
    		ColorHelper.GetGrad(ref 生地1, out 生地1色);
    		ColorHelper.GetGrad(ref 生地2, out 生地2色);
    		ColorHelper.GetGrad(ref 縁, out 縁色);
    		ColorHelper.GetGrad(ref 柄, out 柄色);
    		ColorHelper.GetGrad(ref 紐, out 紐色);
    		ColorHelper.GetMetal(ref 金具, out 金具色);
    		ColorHelper.GetGrad(ref 穴, out 穴色);
    		ColorHelper.GetGrad(ref 靴底, out 靴底色);
    		ColorHelper.GetGrad(ref 踵, out 踵色);
    	}
    }
}
