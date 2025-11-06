using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 尾_鳥D : 尾D
    {
    	public bool 尾0_表示 = true;

    	public bool 風切羽_左_羽1_表示 = true;

    	public bool 風切羽_左_羽2_表示 = true;

    	public bool 風切羽_左_羽3_表示 = true;

    	public bool 風切羽_左_羽4_表示 = true;

    	public bool 風切羽_左_羽5_表示 = true;

    	public bool 風切羽_左_羽6_表示 = true;

    	public bool 風切羽_右_羽1_表示 = true;

    	public bool 風切羽_右_羽2_表示 = true;

    	public bool 風切羽_右_羽3_表示 = true;

    	public bool 風切羽_右_羽4_表示 = true;

    	public bool 風切羽_右_羽5_表示 = true;

    	public bool 風切羽_右_羽6_表示 = true;

    	public bool 雨覆羽_左_羽1_表示 = true;

    	public bool 雨覆羽_左_羽2_表示 = true;

    	public bool 雨覆羽_左_羽3_表示 = true;

    	public bool 雨覆羽_左_羽4_表示 = true;

    	public bool 雨覆羽_左_羽5_表示 = true;

    	public bool 雨覆羽_右_羽1_表示 = true;

    	public bool 雨覆羽_右_羽2_表示 = true;

    	public bool 雨覆羽_右_羽3_表示 = true;

    	public bool 雨覆羽_右_羽4_表示 = true;

    	public bool 雨覆羽_右_羽5_表示 = true;

    	public bool 羽根_表示 = true;

    	public double 展開;

    	public 尾_鳥D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 尾_鳥(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
