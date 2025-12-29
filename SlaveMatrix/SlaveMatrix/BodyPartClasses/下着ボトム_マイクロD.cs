using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 下着ボトム_マイクロD : 下着ボトムD
    {
    	public bool 紐左_表示;

    	public bool 紐右_表示;

    	public bool 下地_表示;

    	public bool 線_表示;

    	public bool ライン_ライン上_表示;

    	public bool ライン_ライン左_表示;

    	public bool ライン_ライン右_表示;

    	public bool ライン_ライン左下_表示;

    	public bool ライン_ライン右下_表示;

    	public bool ライン_ライン下左_表示;

    	public bool ライン_ライン下右_表示;

    	public bool 結び紐左_紐1_表示;

    	public bool 結び紐左_紐2_表示;

    	public bool 結び紐左_輪1_紐後_表示;

    	public bool 結び紐左_輪1_紐前_表示;

    	public bool 結び紐左_輪2_紐後_表示;

    	public bool 結び紐左_輪2_紐前_表示;

    	public bool 結び紐左_結び目_表示;

    	public bool 結び紐右_紐1_表示;

    	public bool 結び紐右_紐2_表示;

    	public bool 結び紐右_輪1_紐後_表示;

    	public bool 結び紐右_輪1_紐前_表示;

    	public bool 結び紐右_輪2_紐後_表示;

    	public bool 結び紐右_輪2_紐前_表示;

    	public bool 結び紐右_結び目_表示;

    	public bool ヴィオラ_紐左_表示;

    	public bool ヴィオラ_紐右_表示;

    	public bool ヴィオラ_丸金具左_表示;

    	public bool ヴィオラ_丸金具右_表示;

    	public bool ヴィオラ_金具左_金具1_表示;

    	public bool ヴィオラ_金具左_金具2_表示;

    	public bool ヴィオラ_金具右_金具1_表示;

    	public bool ヴィオラ_金具右_金具2_表示;

    	public bool 染み_染み2_表示;

    	public bool 染み_染み1_表示;

    	public bool ベース表示;

    	public bool 紐輪表示;

    	public bool 紐表示;

    	public bool 縁1表示;

    	public bool 縁2表示;

    	public bool 縁3表示;

    	public bool 縁4表示;

    	public bool ヴィオラ表示;

    	public bool 染み表示;

    	public double 染み濃度 = 1.0;

    	public 下着ボトム_マイクロD()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 下着ボトム_マイクロ(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
