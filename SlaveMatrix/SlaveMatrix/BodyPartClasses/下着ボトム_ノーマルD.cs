using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 下着ボトム_ノーマルD : 下着ボトムD
    {
    	public bool 紐左_表示;

    	public bool 紐右_表示;

    	public bool 下地_表示;

    	public bool 線_表示;

    	public bool セクシーランジェリー_ライン左_表示;

    	public bool セクシーランジェリー_ライン右_表示;

    	public bool セクシーランジェリー_柄左_柄1_柄1_表示;

    	public bool セクシーランジェリー_柄左_柄1_柄2_表示;

    	public bool セクシーランジェリー_柄左_柄2_柄1_表示;

    	public bool セクシーランジェリー_柄左_柄2_柄2_表示;

    	public bool セクシーランジェリー_柄左_柄3_柄1_表示;

    	public bool セクシーランジェリー_柄左_柄3_柄2_表示;

    	public bool セクシーランジェリー_柄左_柄4_柄1_表示;

    	public bool セクシーランジェリー_柄左_柄4_柄2_表示;

    	public bool セクシーランジェリー_柄左_柄5_柄1_表示;

    	public bool セクシーランジェリー_柄左_柄5_柄2_表示;

    	public bool セクシーランジェリー_柄右_柄1_柄1_表示;

    	public bool セクシーランジェリー_柄右_柄1_柄2_表示;

    	public bool セクシーランジェリー_柄右_柄2_柄1_表示;

    	public bool セクシーランジェリー_柄右_柄2_柄2_表示;

    	public bool セクシーランジェリー_柄右_柄3_柄1_表示;

    	public bool セクシーランジェリー_柄右_柄3_柄2_表示;

    	public bool セクシーランジェリー_柄右_柄4_柄1_表示;

    	public bool セクシーランジェリー_柄右_柄4_柄2_表示;

    	public bool セクシーランジェリー_柄右_柄5_柄1_表示;

    	public bool セクシーランジェリー_柄右_柄5_柄2_表示;

    	public bool セクシーランジェリー_ライン中_表示;

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

    	public bool リボン_リボン_表示;

    	public bool リボン_結び目_表示;

    	public bool 染み_染み2_表示;

    	public bool 染み_染み1_表示;

    	public bool ベース表示;

    	public bool 紐輪表示;

    	public bool 紐表示;

    	public bool 縁1表示;

    	public bool 縁2表示;

    	public bool 縁3表示;

    	public bool 縁4表示;

    	public bool リボン表示;

    	public bool リボン結び目表示;

    	public bool ライン中表示;

    	public bool ライン左右表示;

    	public bool 柄1表示;

    	public bool 柄2表示;

    	public bool 柄3表示;

    	public bool 柄4表示;

    	public bool 柄5表示;

    	public bool 柄6表示;

    	public bool 柄7表示;

    	public bool 柄8表示;

    	public bool 柄9表示;

    	public bool 柄10表示;

    	public bool 染み表示;

    	public double 染み濃度 = 1.0;

    	public 下着ボトム_ノーマルD()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 下着ボトム_ノーマル(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
