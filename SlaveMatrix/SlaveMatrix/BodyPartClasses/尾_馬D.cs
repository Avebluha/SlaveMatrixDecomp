using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 尾_馬D : 尾D
    {
    	public bool 尾0_表示 = true;

    	public bool 尾1_表示 = true;

    	public bool 尾2_表示 = true;

    	public bool 尾3_表示 = true;

    	public bool 尾4_表示 = true;

    	public bool 中央_尾0_表示 = true;

    	public bool 中央_尾1_表示 = true;

    	public bool 中央_尾2_表示 = true;

    	public bool 中央_尾3_表示 = true;

    	public bool 中央_尾4_表示 = true;

    	public bool 中央_尾5_表示 = true;

    	public bool 中央_尾6_表示 = true;

    	public bool 左2_尾0_表示 = true;

    	public bool 左2_尾1_表示 = true;

    	public bool 左2_尾2_表示 = true;

    	public bool 左2_尾3_表示 = true;

    	public bool 左2_尾4_表示 = true;

    	public bool 左2_尾5_表示 = true;

    	public bool 左2_尾6_表示 = true;

    	public bool 左1_尾0_表示 = true;

    	public bool 左1_尾1_表示 = true;

    	public bool 左1_尾2_表示 = true;

    	public bool 左1_尾3_表示 = true;

    	public bool 左1_尾4_表示 = true;

    	public bool 左1_尾5_表示 = true;

    	public bool 左1_尾6_表示 = true;

    	public bool 右2_尾0_表示 = true;

    	public bool 右2_尾1_表示 = true;

    	public bool 右2_尾2_表示 = true;

    	public bool 右2_尾3_表示 = true;

    	public bool 右2_尾4_表示 = true;

    	public bool 右2_尾5_表示 = true;

    	public bool 右2_尾6_表示 = true;

    	public bool 右1_尾0_表示 = true;

    	public bool 右1_尾1_表示 = true;

    	public bool 右1_尾2_表示 = true;

    	public bool 右1_尾3_表示 = true;

    	public bool 右1_尾4_表示 = true;

    	public bool 右1_尾5_表示 = true;

    	public bool 右1_尾6_表示 = true;

    	public 尾_馬D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 尾_馬(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
