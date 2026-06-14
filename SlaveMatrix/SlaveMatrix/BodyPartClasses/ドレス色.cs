using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct ドレス色
    {
    	public Color 生地;

    	public Color 柄;

    	public Color 縁;

    	public Color 紐;

    	public Color2 生地色;

    	public Color2 柄色;

    	public Color2 縁色;

    	public Color2 紐色;

    	public void SetDefault()
    	{
    		ColorHelper.Add(ref ColorHelper.DarkGreen, 0, 0, -50, out 生地);
    		柄 = Color.Gold;
    		縁 = Color.Gold;
    		紐 = ColorHelper.Black;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		ColorHelper.GetRandomClothesColor(out 生地);
    		ColorHelper.GetRandomClothesColor(out 柄);
    		縁 = 柄;
    		ColorHelper.GetRandomClothesColor(out 紐);
    		SetColor2();
    	}

    	public void SetColor2()
    	{
    		ColorHelper.GetGrad(ref 生地, out 生地色);
    		ColorHelper.GetGrad(ref 柄, out 柄色);
    		ColorHelper.GetGrad(ref 縁, out 縁色);
    		ColorHelper.GetGrad(ref 紐, out 紐色);
    	}
    }
}
