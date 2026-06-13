using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class バイブ_デンマD : ElementData
    {
    	public bool ヘッド_表示 = true;

    	public bool ヘッド線1_表示 = true;

    	public bool ヘッド線2_表示 = true;

    	public bool ヘッド線3_表示 = true;

    	public bool ヘッド線4_表示 = true;

    	public bool 拡張ユニット_表示 = true;

    	public bool 拡張ユニット色_表示 = true;

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

    	public bool ヘッド線_表示 = true;

    	public バイブ_デンマD()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new バイブ_デンマ(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
