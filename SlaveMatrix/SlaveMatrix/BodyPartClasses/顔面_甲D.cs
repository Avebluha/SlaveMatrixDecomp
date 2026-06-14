using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 顔面_甲D : 顔面D
    {
    	public bool 面額_表示 = true;

    	public bool 面左下_面目_表示 = true;

    	public bool 面左下_面_表示 = true;

    	public bool 面右下_面目_表示 = true;

    	public bool 面右下_面_表示 = true;

    	public bool 面左外_表示 = true;

    	public bool 面右外_表示 = true;

    	public bool 面左上_面目_表示 = true;

    	public bool 面左上_面_表示 = true;

    	public bool 面右上_面目_表示 = true;

    	public bool 面右上_面_表示 = true;

    	public bool 面中0_面中_表示 = true;

    	public bool 面中0_付根左_付根1_表示 = true;

    	public bool 面中0_付根左_付根2_表示 = true;

    	public bool 面中0_付根右_付根1_表示 = true;

    	public bool 面中0_付根右_付根2_表示 = true;

    	public bool 面中2_面中_表示 = true;

    	public bool 面中2_面中下_表示 = true;

    	public bool 面中1_面中_表示 = true;

    	public bool 面中1_面中下_表示 = true;

    	public double 展開1;

    	public 顔面_甲D()
    	{
    		ThisType = GetType();
    	}

    	public override void 触覚左接続(ElementData e)
    	{
    		触覚左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.顔面_甲_触覚左_接続;
    	}

    	public override void 触覚右接続(ElementData e)
    	{
    		触覚右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.顔面_甲_触覚右_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 顔面_甲(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
