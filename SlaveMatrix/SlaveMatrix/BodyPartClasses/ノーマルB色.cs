using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct ノーマルB色
    {
    	public Color 生地;

    	public Color リボン;

    	public Color 柄;

    	public Color 縁;

    	public Color 紐;

    	public Color2 生地色;

    	public Color2 リボン色;

    	public Color2 柄色;

    	public Color2 縁色;

    	public Color2 紐色;

    	public void SetDefault()
    	{
    		生地 = Color.DarkRed;
    		リボン = ColorHelper.Black;
    		柄 = ColorHelper.Black;
    		縁 = Color.DarkRed;
    		紐 = ColorHelper.Black;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		ColorHelper.GetRandomClothesColor(out 生地);
    		ColorHelper.GetRandomClothesColor(out リボン);
    		柄 = リボン;
    		縁 = 生地;
    		紐 = リボン;
    		SetColor2();
    	}

    	public void SetColor2()
    	{
    		ColorHelper.GetGrad(ref 生地, out 生地色);
    		ColorHelper.GetGrad(ref リボン, out リボン色);
    		ColorHelper.GetGrad(ref 柄, out 柄色);
    		ColorHelper.GetGrad(ref 縁, out 縁色);
    		ColorHelper.GetGrad(ref 紐, out 紐色);
    	}

    	public void Setビキニ()
    	{
    		生地 = Color.DarkRed;
    		リボン = ColorHelper.White;
    		柄 = ColorHelper.White;
    		縁 = ColorHelper.White;
    		紐 = ColorHelper.White;
    		ColorHelper.GetGrad(ref 生地, out 生地色);
    		ColorHelper.GetGrad(ref リボン, out リボン色);
    		ColorHelper.GetGrad(ref 柄, out 柄色);
    		ColorHelper.GetGrad(ref 縁, out 縁色);
    		ColorHelper.GetGrad(ref 紐, out 紐色);
    	}
    }
}
