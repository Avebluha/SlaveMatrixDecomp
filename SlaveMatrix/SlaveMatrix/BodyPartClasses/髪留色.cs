using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct 髪留色
    {
    	public Color 髪留1;

    	public Color 髪留2;

    	public Color2 髪留1色;

    	public Color2 髪留2色;

    	public void SetDefault()
    	{
    		髪留1 = Color.DarkRed;
    		髪留2 = Color.DarkRed;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		ColorHelper.GetRandomClothesColor(out 髪留1);
    		髪留2 = 髪留1;
    		SetColor2();
    	}

    	public void SetColor2()
    	{
    		ColorHelper.GetGrad(ref 髪留1, out 髪留1色);
    		ColorHelper.GetGrad(ref 髪留2, out 髪留2色);
    	}
    }
}
