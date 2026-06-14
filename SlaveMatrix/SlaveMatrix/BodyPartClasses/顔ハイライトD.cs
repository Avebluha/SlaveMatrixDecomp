using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 顔ハイライトD : ElementData
    {
    	public bool ハイライト1_表示;

    	public bool ハイライト2_表示;

    	public 顔ハイライトD()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 顔ハイライト(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
