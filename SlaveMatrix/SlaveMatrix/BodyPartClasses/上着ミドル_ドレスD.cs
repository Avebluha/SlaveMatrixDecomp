using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 上着ミドル_ドレスD : 上着ミドルD
    {
    	public bool 服_表示;

    	public bool 縁_縁左_表示;

    	public bool 縁_縁右_表示;

    	public bool 柄_柄左_柄1_表示;

    	public bool 柄_柄左_柄2_柄1_表示;

    	public bool 柄_柄左_柄2_柄2_表示;

    	public bool 柄_柄右_柄1_表示;

    	public bool 柄_柄右_柄2_柄1_表示;

    	public bool 柄_柄右_柄2_柄2_表示;

    	public bool ベース表示;

    	public bool 縁表示;

    	public bool 柄1表示;

    	public bool 柄2表示;

    	public bool 柄3表示;

    	public 上着ミドル_ドレスD()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 上着ミドル_ドレス(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
