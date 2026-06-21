using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class JacketBottom_前掛けD : JacketBottomD
    {
    	public bool 帯_表示;

    	public bool 巻_表示;

    	public bool 縁後_縁左_表示;

    	public bool 縁後_縁右_表示;

    	public bool 前掛_前掛1_表示;

    	public bool 前掛_前掛2_表示;

    	public bool 前掛_前掛3_表示;

    	public bool 縁前_縁左_表示;

    	public bool 縁前_縁右_表示;

    	public bool 縁前_縁中_表示;

    	public bool ベース表示;

    	public bool 縁表示;

    	public bool 巻縁表示;

    	public JacketBottom_前掛けD()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new JacketBottom_前掛け(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
