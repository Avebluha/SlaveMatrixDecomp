using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct 玉口枷色
    {
    	public Color 革部;

    	public Color 金具;

    	public Color 玉部;

    	public Color2 革部色;

    	public Color2 金具色;

    	public Color2 玉部色;

    	public void SetDefault()
    	{
    		革部 = ColorHelper.Black;
    		金具 = Color.Gray;
    		玉部 = Color.DeepPink;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		ColorHelper.GetRandomClothesColor(out 革部);
    		ColorHelper.GetRandomClothesColor(out 金具);
    		ColorHelper.GetRandomClothesColor(out 玉部);
    		SetColor2();
    	}

    	public void SetColor2()
    	{
    		ColorHelper.GetGrad(ref 革部, out 革部色);
    		ColorHelper.GetMetal(ref 金具, out 金具色);
    		ColorHelper.GetGrad(ref 玉部, out 玉部色);
    	}
    }
}
