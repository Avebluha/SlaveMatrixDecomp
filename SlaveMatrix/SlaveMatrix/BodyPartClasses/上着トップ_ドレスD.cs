using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 上着トップ_ドレスD : 上着トップD
    {
    	public bool 服基_表示;

    	public bool 紐_紐1_紐下_紐_表示;

    	public bool 紐_紐1_紐上_紐_表示;

    	public bool 紐_紐2_紐下_紐_表示;

    	public bool 紐_紐2_紐上_紐_表示;

    	public bool 紐_紐3_紐下_紐_表示;

    	public bool 紐_紐3_紐上_紐_表示;

    	public bool 紐_紐4_紐下_紐_表示;

    	public bool 紐_紐4_紐上_紐_表示;

    	public bool 紐_紐5_紐下_紐_表示;

    	public bool 紐_紐5_紐上_紐_表示;

    	public bool 紐_紐6_紐下_紐_表示;

    	public bool 紐_紐6_紐上_紐_表示;

    	public bool 左_服_表示;

    	public bool 左_柄_柄1_表示;

    	public bool 左_柄_柄2_表示;

    	public bool 左_バスト_表示;

    	public bool 左_縁_表示;

    	public bool 右_服_表示;

    	public bool 右_柄_柄1_表示;

    	public bool 右_柄_柄2_表示;

    	public bool 右_バスト_表示;

    	public bool 右_縁_表示;

    	public bool ベース表示;

    	public bool 紐1表示;

    	public bool 紐2表示;

    	public bool 紐3表示;

    	public bool 紐4表示;

    	public bool 紐5表示;

    	public bool 紐6表示;

    	public bool 縁表示;

    	public bool 柄1表示;

    	public bool 柄2表示;

    	public double バスト;

    	public 上着トップ_ドレスD()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 上着トップ_ドレス(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
