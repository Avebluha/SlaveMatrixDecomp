using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class パールD : EleD
    {
    	public bool 軸_表示 = true;

    	public bool 玉境界_表示 = true;

    	public bool 玉1_表示 = true;

    	public bool 玉2_表示 = true;

    	public bool 玉3_表示 = true;

    	public bool 玉4_表示 = true;

    	public bool 玉5_表示 = true;

    	public bool 玉6_表示 = true;

    	public bool 玉7_表示 = true;

    	public bool 輪上_表示 = true;

    	public bool 輪下_表示 = true;

    	public bool 玉_表示 = true;

    	public bool 輪上境界_表示 = true;

    	public パールD()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new パール(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
