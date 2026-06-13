using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct マイクロT色
    {
    	public Color 生地;

    	public Color 縁;

    	public Color 紐;

    	public Color2 生地色;

    	public Color2 縁色;

    	public Color2 紐色;

    	public void SetDefault()
    	{
    		生地 = Color.DarkRed;
    		縁 = ColorHelper.White;
    		紐 = ColorHelper.White;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		ColorHelper.GetRandomClothesColor(out 生地);
    		ColorHelper.GetRandomClothesColor(out 縁);
    		紐 = 縁;
    		SetColor2();
    	}

    	public void SetColor2()
    	{
    		ColorHelper.GetGrad(ref 生地, out 生地色);
    		ColorHelper.GetGrad(ref 縁, out 縁色);
    		ColorHelper.GetGrad(ref 紐, out 紐色);
    	}
    }
}
