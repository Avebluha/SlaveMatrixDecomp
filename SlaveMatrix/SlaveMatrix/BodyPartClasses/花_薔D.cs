using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 花_薔D : 花D
    {
    	public bool 花_バラ_通常_花弁2_表示 = true;

    	public bool 花_バラ_通常_花弁4_表示 = true;

    	public bool 花_バラ_通常_花弁3_表示 = true;

    	public bool 花_バラ_通常_花弁1_表示 = true;

    	public bool 花_バラ_通常_花弁5_表示 = true;

    	public bool 花_バラ_通常_花弁6_表示 = true;

    	public bool 花_バラ_通常_花弁8_表示 = true;

    	public bool 花_バラ_通常_花弁7_表示 = true;

    	public bool 花_バラ_通常_花弁9_表示 = true;

    	public bool 花_バラ_通常_花弁11_表示 = true;

    	public bool 花_バラ_通常_花弁10_表示 = true;

    	public bool 花_バラ_通常_花弁影_表示 = true;

    	public bool 花_バラ_欠損_花弁2_表示 = true;

    	public bool 花_バラ_欠損_花弁4_表示 = true;

    	public bool 花_バラ_欠損_花弁3_表示 = true;

    	public bool 花_バラ_欠損_花弁1_表示 = true;

    	public bool 花_バラ_欠損_花弁5_表示 = true;

    	public bool 花_バラ_欠損_花弁6_表示 = true;

    	public bool 花_バラ_欠損_花弁8_表示 = true;

    	public bool 花_バラ_欠損_花弁7_表示 = true;

    	public bool 花_バラ_欠損_花弁9_表示 = true;

    	public bool 花_バラ_欠損_花弁11_表示 = true;

    	public bool 花_バラ_欠損_花弁10_表示 = true;

    	public bool 花_バラ_欠損_花弁影_表示 = true;

    	public bool 萼_通常_萼_表示 = true;

    	public bool 萼_欠損_萼_表示 = true;

    	public bool 花_バラ_花弁2_表示 = true;

    	public bool 花_バラ_花弁4_表示 = true;

    	public bool 花_バラ_花弁3_表示 = true;

    	public bool 花_バラ_花弁1_表示 = true;

    	public bool 花_バラ_花弁5_表示 = true;

    	public bool 花_バラ_花弁6_表示 = true;

    	public bool 花_バラ_花弁8_表示 = true;

    	public bool 花_バラ_花弁7_表示 = true;

    	public bool 花_バラ_花弁9_表示 = true;

    	public bool 花_バラ_花弁11_表示 = true;

    	public bool 花_バラ_花弁10_表示 = true;

    	public bool 花_バラ_花弁影_表示 = true;

    	public bool 萼_萼_表示 = true;

    	public 花_薔D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 花_薔(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
