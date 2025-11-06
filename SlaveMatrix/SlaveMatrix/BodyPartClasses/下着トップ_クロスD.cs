using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 下着トップ_クロスD : 下着トップD
    {
    	public bool 布_布左_布_表示;

    	public bool 布_布左_皺_皺1_表示;

    	public bool 布_布左_皺_皺2_表示;

    	public bool 布_布左_縁_縁1_表示;

    	public bool 布_布左_縁_縁2_表示;

    	public bool 布_布右_布_表示;

    	public bool 布_布右_皺_皺1_表示;

    	public bool 布_布右_皺_皺2_表示;

    	public bool 布_布右_縁_縁1_表示;

    	public bool 布_布右_縁_縁2_表示;

    	public bool カップ右_布_表示;

    	public bool カップ右_皺_表示;

    	public bool カップ右_縁_縁1_表示;

    	public bool カップ右_縁_縁2_表示;

    	public bool カップ左_布_表示;

    	public bool カップ左_皺_表示;

    	public bool カップ左_縁_縁1_表示;

    	public bool カップ左_縁_縁2_表示;

    	public bool ベース表示;

    	public bool 皺1表示;

    	public bool 皺2表示;

    	public bool 皺3表示;

    	public bool 縁1表示;

    	public bool 縁2表示;

    	public bool 縁3表示;

    	public bool 縁4表示;

    	public double バスト;

    	public 下着トップ_クロスD()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 下着トップ_クロス(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
