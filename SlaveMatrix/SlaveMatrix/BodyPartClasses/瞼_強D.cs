using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 瞼_強D : 双瞼D
    {
    	public bool 瞼_表示 = true;

    	public bool 二重_表示 = true;

    	public bool 睫毛_睫毛3_表示 = true;

    	public bool 睫毛_睫毛4_表示 = true;

    	public bool 睫毛_睫毛1_表示 = true;

    	public bool 睫毛_睫毛2_表示 = true;

    	public double 外線;

    	public double 睫毛_睫毛3_長さ;

    	public double 睫毛_睫毛4_長さ;

    	public double 睫毛_睫毛1_長さ;

    	public double 睫毛_睫毛2_長さ;

    	public 瞼_強D()
    	{
    		ThisType = GetType();
    	}

    	public 瞼_強D SetRandom()
    	{
    		サイズ = RNG.XS.NextDouble();
    		サイズX = RNG.XS.NextDouble();
    		サイズY = RNG.XS.NextDouble();
    		二重_表示 = RNG.XS.NextBool();
    		睫毛_睫毛3_表示 = RNG.XS.NextBool();
    		睫毛_睫毛4_表示 = RNG.XS.NextBool();
    		睫毛_睫毛1_表示 = RNG.XS.NextBool();
    		睫毛_睫毛2_表示 = RNG.XS.NextBool();
    		外線 = RNG.XS.NextDouble();
    		睫毛_睫毛3_長さ = RNG.XS.NextDouble();
    		睫毛_睫毛4_長さ = RNG.XS.NextDouble();
    		睫毛_睫毛1_長さ = RNG.XS.NextDouble();
    		睫毛_睫毛2_長さ = RNG.XS.NextDouble();
    		傾き = RNG.XS.NextDouble();
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 瞼_強(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
