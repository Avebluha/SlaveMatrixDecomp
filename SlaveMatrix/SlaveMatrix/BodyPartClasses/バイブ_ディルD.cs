using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class バイブ_ディルD : EleD
    {
    	public bool ヘッド_表示 = true;

    	public bool 血管1_表示 = true;

    	public bool 血管2_表示 = true;

    	public bool 亀頭_表示 = true;

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

    	public bool 血管_表示 = true;

    	public バイブ_ディルD()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new バイブ_ディル(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
