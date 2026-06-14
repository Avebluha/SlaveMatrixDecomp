using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 顔面_虫D : 顔面D
    {
    	public bool 面基_表示 = true;

    	public bool 複眼左_複眼1_表示 = true;

    	public bool 複眼左_複眼2_表示 = true;

    	public bool 複眼左_ハイライト_表示 = true;

    	public bool 複眼右_複眼1_表示 = true;

    	public bool 複眼右_複眼2_表示 = true;

    	public bool 複眼右_ハイライト_表示 = true;

    	public bool 面下_面_表示 = true;

    	public bool 面下_器官左上_表示 = true;

    	public bool 面下_器官左下_表示 = true;

    	public bool 面下_器官右上_表示 = true;

    	public bool 面下_器官右下_表示 = true;

    	public bool 面上_表示 = true;

    	public bool 付根左_付根1_表示 = true;

    	public bool 付根左_付根2_表示 = true;

    	public bool 付根右_付根1_表示 = true;

    	public bool 付根右_付根2_表示 = true;

    	public bool 単眼_眼中_基_表示 = true;

    	public bool 単眼_眼中_眼_表示 = true;

    	public bool 単眼_眼中_ハイライト_表示 = true;

    	public bool 単眼_眼左_基_表示 = true;

    	public bool 単眼_眼左_眼_表示 = true;

    	public bool 単眼_眼左_ハイライト_表示 = true;

    	public bool 単眼_眼右_基_表示 = true;

    	public bool 単眼_眼右_眼_表示 = true;

    	public bool 単眼_眼右_ハイライト_表示 = true;

    	public double 展開1;

    	public 顔面_虫D()
    	{
    		ThisType = GetType();
    	}

    	public override void 触覚左接続(ElementData e)
    	{
    		触覚左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.顔面_虫_触覚左_接続;
    	}

    	public override void 触覚右接続(ElementData e)
    	{
    		触覚右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.顔面_虫_触覚右_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 顔面_虫(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
