using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct キャップ色
    {
    	public Color 根本;

    	public Color 先端;

    	public Color2 根本色;

    	public Color2 先端色;

    	public void SetDefault()
    	{
    		根本 = Color.HotPink;
    		先端 = Color.HotPink;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		ColorHelper.GetRandomClothesColor(out 根本);
    		先端 = 根本;
    		SetColor2();
    	}

    	public void SetColor2()
    	{
    		ColorHelper.GetGrad(ref 根本, out 根本色);
    		ColorHelper.GetGrad(ref 先端, out 先端色);
    	}
    }
}
