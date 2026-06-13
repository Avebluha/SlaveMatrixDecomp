using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 顔面_蟲D : 顔面D
    {
    	public bool 面_表示 = true;

    	public bool 眼左_眼1_基_表示 = true;

    	public bool 眼左_眼1_眼_表示 = true;

    	public bool 眼左_眼1_ハイライト_表示 = true;

    	public bool 眼左_眼2_基_表示 = true;

    	public bool 眼左_眼2_眼_表示 = true;

    	public bool 眼左_眼2_ハイライト_表示 = true;

    	public bool 眼左_眼3_基_表示 = true;

    	public bool 眼左_眼3_眼_表示 = true;

    	public bool 眼左_眼3_ハイライト_表示 = true;

    	public bool 眼左_眼4_基_表示 = true;

    	public bool 眼左_眼4_眼_表示 = true;

    	public bool 眼左_眼4_ハイライト_表示 = true;

    	public bool 眼左_眼5_基_表示 = true;

    	public bool 眼左_眼5_眼_表示 = true;

    	public bool 眼左_眼5_ハイライト_表示 = true;

    	public bool 眼右_眼1_基_表示 = true;

    	public bool 眼右_眼1_眼_表示 = true;

    	public bool 眼右_眼1_ハイライト_表示 = true;

    	public bool 眼右_眼2_基_表示 = true;

    	public bool 眼右_眼2_眼_表示 = true;

    	public bool 眼右_眼2_ハイライト_表示 = true;

    	public bool 眼右_眼3_基_表示 = true;

    	public bool 眼右_眼3_眼_表示 = true;

    	public bool 眼右_眼3_ハイライト_表示 = true;

    	public bool 眼右_眼4_基_表示 = true;

    	public bool 眼右_眼4_眼_表示 = true;

    	public bool 眼右_眼4_ハイライト_表示 = true;

    	public bool 眼右_眼5_基_表示 = true;

    	public bool 眼右_眼5_眼_表示 = true;

    	public bool 眼右_眼5_ハイライト_表示 = true;

    	public bool 角左_角左1_表示 = true;

    	public bool 角左_角左2_表示 = true;

    	public bool 角右_角右1_表示 = true;

    	public bool 角右_角右2_表示 = true;

    	public bool 触覚部眼表示 = true;

    	public 顔面_蟲D()
    	{
    		ThisType = GetType();
    	}

    	public override void 触覚左接続(ElementData e)
    	{
    		触覚左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.顔面_蟲_触覚左_接続;
    	}

    	public override void 触覚右接続(ElementData e)
    	{
    		触覚右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.顔面_蟲_触覚右_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 顔面_蟲(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
