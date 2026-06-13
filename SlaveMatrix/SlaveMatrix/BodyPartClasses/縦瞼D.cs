using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 縦瞼D : EleD
    {
    	public bool 瞼左_瞼_表示 = true;

    	public bool 瞼左_睫毛1_表示 = true;

    	public bool 瞼左_睫毛2_表示 = true;

    	public bool 瞼右_瞼_表示 = true;

    	public bool 瞼右_睫毛1_表示 = true;

    	public bool 瞼右_睫毛2_表示 = true;

    	public double 外線;

    	public double 瞼左_睫毛1_長さ;

    	public double 瞼左_睫毛2_長さ;

    	public double 瞼右_睫毛1_長さ;

    	public double 瞼右_睫毛2_長さ;

    	public 縦瞼D()
    	{
    		ThisType = GetType();
    	}

    	public 縦瞼D SetRandom()
    	{
    		サイズX = RNG.XS.NextDouble();
    		瞼左_睫毛1_表示 = RNG.XS.NextBool();
    		瞼左_睫毛2_表示 = RNG.XS.NextBool();
    		瞼右_睫毛1_表示 = 瞼左_睫毛1_表示;
    		瞼右_睫毛2_表示 = 瞼左_睫毛2_表示;
    		外線 = RNG.XS.NextDouble();
    		瞼左_睫毛1_長さ = RNG.XS.NextDouble();
    		瞼左_睫毛2_長さ = RNG.XS.NextDouble();
    		瞼右_睫毛1_長さ = 瞼左_睫毛1_長さ;
    		瞼右_睫毛2_長さ = 瞼左_睫毛2_長さ;
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 縦瞼(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
