using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class バイブ_コモンD : ElementData
    {
    	public bool ヘッド_表示 = true;

    	public bool イボ1_表示 = true;

    	public bool イボ2_表示 = true;

    	public bool イボ3_表示 = true;

    	public bool イボ4_表示 = true;

    	public bool イボ5_表示 = true;

    	public bool イボ6_表示 = true;

    	public bool イボ7_表示 = true;

    	public bool イボ8_表示 = true;

    	public bool イボ9_表示 = true;

    	public bool イボ10_表示 = true;

    	public bool イボ11_表示 = true;

    	public bool イボ12_表示 = true;

    	public bool ユニット_ユニット_表示 = true;

    	public bool ユニット_ユニット線上_表示 = true;

    	public bool ユニット_ユニット線下_表示 = true;

    	public bool ユニット_ボタン上_表示 = true;

    	public bool ユニット_ボタン下_表示 = true;

    	public bool ユニット_パワー根_表示 = true;

    	public bool ユニット_パワー1_表示 = true;

    	public bool ユニット_パワー2_表示 = true;

    	public bool ユニット_パワー3_表示 = true;

    	public bool ユニット_パワー4_表示 = true;

    	public バイブ_コモンD()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new バイブ_コモン(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
