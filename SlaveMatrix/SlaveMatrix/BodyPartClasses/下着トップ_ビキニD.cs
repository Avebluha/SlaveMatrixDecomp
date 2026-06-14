using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 下着トップ_ビキニD : 下着トップD
    {
    	public bool 紐_表示;

    	public bool カップ左_紐_表示;

    	public bool カップ左_カップ_表示;

    	public bool カップ左_縁_縁1_表示;

    	public bool カップ左_縁_縁2_表示;

    	public bool カップ左_縁_縁3_表示;

    	public bool カップ左_縁_縁4_表示;

    	public bool カップ右_紐_表示;

    	public bool カップ右_カップ_表示;

    	public bool カップ右_縁_縁1_表示;

    	public bool カップ右_縁_縁2_表示;

    	public bool カップ右_縁_縁3_表示;

    	public bool カップ右_縁_縁4_表示;

    	public bool ベース表示;

    	public bool 縁1表示;

    	public bool 縁2表示;

    	public bool 縁3表示;

    	public bool 縁4表示;

    	public double バスト;

    	public 下着トップ_ビキニD()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 下着トップ_ビキニ(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
