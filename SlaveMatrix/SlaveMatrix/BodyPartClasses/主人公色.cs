using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public class 主人公色
    {
    	public Color 肌色;

    	public Color 髪色 = ColorHelper.Black;

    	public Color 瞳色 = Color.FromArgb(57, 32, 0);

    	public Color 血液 = Color.Red;

    	public Color 刺青 = ColorHelper.Black;

    	public Color 精液 = Color.PapayaWhip;

    	public 主人公色()
    	{
    		肌色 = Color.FromArgb(255, 255, 207, 169);
    		ColorHelper.Add(ref 肌色, -10, -10, 0, out 肌色);
    	}
    }
}
