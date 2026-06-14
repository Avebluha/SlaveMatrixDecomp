using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct Color2
    {
    	public Color Col1;

    	public Color Col2;

    	public static Color2 Empty = new Color2(ref ColorHelper.Empty, ref ColorHelper.Empty);

    	public Color2(ref Color Col1, ref Color Col2)
    	{
    		this.Col1 = Col1;
    		this.Col2 = Col2;
    	}

    	public void GetRep(out Color2 ret)
    	{
    		ret.Col1 = Col2;
    		ret.Col2 = Col1;
    	}
    }
}
