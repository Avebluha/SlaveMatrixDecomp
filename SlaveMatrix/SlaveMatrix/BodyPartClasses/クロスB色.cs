using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct クロスB色
    {
    	public Color 生地1;

    	public Color 生地2;

    	public Color2 生地1色;

    	public Color2 生地2色;

    	public void SetDefault()
    	{
    		生地1 = Color.OldLace;
    		生地2 = Color.OldLace;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		ColorHelper.GetRandomClothesColor(out 生地1);
    		生地2 = 生地1;
    		SetColor2();
    	}

    	public void SetColor2()
    	{
    		ColorHelper.GetGrad(ref 生地1, out 生地1色);
    		ColorHelper.GetGrad(ref 生地2, out 生地2色);
    	}
    }
}
