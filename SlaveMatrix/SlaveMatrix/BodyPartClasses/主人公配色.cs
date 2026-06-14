using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public class 主人公配色
    {
    	public Color2 肌色;

    	public Color2 血液;

    	public Color2 刺青;

    	public Color2 精液ぶっかけ;

    	public Color2 精液垂れ;

    	public Color2 粘膜;

    	public Color 肌線;

    	public Color 粘線;

    	public Color 精線;

    	public 主人公配色(主人公色 色)
    	{
    		ColorHelper.GetSkinGrad(ref 色.肌色, out 肌色);
    		ColorHelper.GetGrad(ref 色.血液, out 血液);
    		刺青 = new Color2(ref 色.刺青, ref ColorHelper.Empty);
    		精液ぶっかけ.Col1 = Color.FromArgb(125, 色.精液);
    		精液ぶっかけ.Col2 = ColorHelper.Empty;
    		精液垂れ.Col1 = Color.FromArgb(200, 色.精液);
    		精液垂れ.Col2 = ColorHelper.Empty;
    		ColorHelper.GetMucosaColor(ref 色.肌色, out var ret);
    		ColorHelper.GetGrad(ref ret, out 粘膜);
    		ColorHelper.GetSkinColor2(ref 色.肌色, out ret);
    		肌線 = Color.FromArgb(100, ret);
    		ColorHelper.GetMucosaColor(ref 色.肌色, out ret);
    		ColorHelper.Mul(ref ret, 1.0, 2.0, 0.5, out ret);
    		粘線 = Color.FromArgb(80, ret);
    		精線 = Color.FromArgb(80, ColorHelper.White);
    	}

    	public 主人公配色(主人公配色 s)
    	{
    		肌色 = new Color2(ref s.肌色.Col1, ref s.肌色.Col2);
    		血液 = new Color2(ref s.血液.Col1, ref s.血液.Col2);
    		刺青 = new Color2(ref s.刺青.Col1, ref s.刺青.Col2);
    		精液ぶっかけ = new Color2(ref s.精液ぶっかけ.Col1, ref s.精液ぶっかけ.Col2);
    		精液垂れ = new Color2(ref s.精液垂れ.Col1, ref s.精液垂れ.Col2);
    		粘膜 = new Color2(ref s.粘膜.Col1, ref s.粘膜.Col2);
    		肌線 = s.肌線;
    		粘線 = s.粘線;
    		精線 = s.精線;
    	}
    }
}
