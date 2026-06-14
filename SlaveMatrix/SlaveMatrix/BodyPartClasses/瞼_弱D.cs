using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 瞼_弱D : 双瞼D
    {
    	public bool 瞼_表示 = true;

    	public bool 二重_表示 = true;

    	public bool 睫毛_睫毛3_表示 = true;

    	public bool 睫毛_睫毛1_表示 = true;

    	public bool 睫毛_睫毛2_表示 = true;

    	public double 外線;

    	public double 睫毛_睫毛3_長さ;

    	public double 睫毛_睫毛1_長さ;

    	public double 睫毛_睫毛2_長さ;

    	public 瞼_弱D()
    	{
    		ThisType = GetType();
    	}

    	public 瞼_弱D SetRandom()
    	{
    		サイズ = Rng.XS.NextDouble();
    		サイズX = Rng.XS.NextDouble();
    		サイズY = Rng.XS.NextDouble();
    		二重_表示 = Rng.XS.NextBool();
    		睫毛_睫毛3_表示 = Rng.XS.NextBool();
    		睫毛_睫毛1_表示 = Rng.XS.NextBool();
    		睫毛_睫毛2_表示 = Rng.XS.NextBool();
    		外線 = Rng.XS.NextDouble();
    		睫毛_睫毛3_長さ = Rng.XS.NextDouble();
    		睫毛_睫毛1_長さ = Rng.XS.NextDouble();
    		睫毛_睫毛2_長さ = Rng.XS.NextDouble();
    		傾き = Rng.XS.NextDouble();
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 瞼_弱(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
