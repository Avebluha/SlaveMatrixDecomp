using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct 前掛けB色
    {
    	public Color 生地;

    	public Color 縁;

    	public Color 紐;

    	public Color2 生地色;

    	public Color2 縁色;

    	public Color2 紐色;

    	public void SetDefault()
    	{
    		生地 = Color.OldLace;
    		縁 = Color.OldLace;
    		紐 = Color.OldLace;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		ColorHelper.GetRandomClothesColor(out 生地);
    		縁 = 生地;
    		紐 = 生地;
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
