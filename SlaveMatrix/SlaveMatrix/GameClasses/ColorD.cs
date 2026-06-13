using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public class ColorD
    {
    	public Color c;

    	public Color2 c2;

    	private double Alpha = 1.0;

    	private int Alpha_c;

    	private int Alpha_c1;

    	private int Alpha_c2;

    	public Color 線
    	{
    		get
    		{
    			return c;
    		}
    		set
    		{
    			c = value;
    			Alpha_c = c.A;
    		}
    	}

    	public Color2 色
    	{
    		get
    		{
    			return c2;
    		}
    		set
    		{
    			c2 = value;
    			Alpha_c1 = c2.Col1.A;
    			Alpha_c2 = c2.Col2.A;
    		}
    	}

    	public double 不透明度
    	{
    		get
    		{
    			return Alpha;
    		}
    		set
    		{
    			Alpha = value;
    			if (Alpha_c > 0)
    			{
    				c = Color.FromArgb((int)((double)Alpha_c * Alpha), 線);
    			}
    			if (Alpha_c1 > 0)
    			{
    				c2.Col1 = Color.FromArgb((int)((double)Alpha_c1 * Alpha), c2.Col1);
    			}
    			if (Alpha_c2 > 0)
    			{
    				c2.Col2 = Color.FromArgb((int)((double)Alpha_c2 * Alpha), c2.Col2);
    			}
    		}
    	}

    	public ColorD(ref Color 線, ref Color2 色)
    	{
    		this.線 = 線;
    		this.色 = 色;
    	}

    	public ColorD()
    	{
    		線 = ColorHelper.Black;
    		色 = new Color2(ref ColorHelper.White, ref ColorHelper.DarkGray);
    	}
    }
}
