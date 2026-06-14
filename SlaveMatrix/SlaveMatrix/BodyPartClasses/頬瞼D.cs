using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 頬瞼D : ElementData
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

    	public double 傾き;

    	public 頬瞼D()
    	{
    		ThisType = GetType();
    	}

    	public 頬瞼D SetRandom()
    	{
    		サイズY = Rng.XS.NextDouble();
    		瞼左_睫毛1_表示 = Rng.XS.NextBool();
    		瞼左_睫毛2_表示 = Rng.XS.NextBool();
    		瞼右_睫毛1_表示 = Rng.XS.NextBool();
    		瞼右_睫毛2_表示 = Rng.XS.NextBool();
    		外線 = Rng.XS.NextDouble();
    		瞼左_睫毛1_長さ = Rng.XS.NextDouble();
    		瞼左_睫毛2_長さ = Rng.XS.NextDouble();
    		瞼右_睫毛1_長さ = Rng.XS.NextDouble();
    		瞼右_睫毛2_長さ = Rng.XS.NextDouble();
    		傾き = Rng.XS.NextDouble();
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 頬瞼(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
