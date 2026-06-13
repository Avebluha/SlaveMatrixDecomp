using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 単瞼D : ElementData
    {
    	public bool 瞼下_表示 = true;

    	public bool 瞼上_表示 = true;

    	public bool 二重_表示 = true;

    	public bool 睫毛上上左_表示 = true;

    	public bool 睫毛上中左_表示 = true;

    	public bool 睫毛上下左_表示 = true;

    	public bool 睫毛上上右_表示 = true;

    	public bool 睫毛上中右_表示 = true;

    	public bool 睫毛上下右_表示 = true;

    	public bool 睫毛下上左_表示 = true;

    	public bool 睫毛下下左_表示 = true;

    	public bool 睫毛下上右_表示 = true;

    	public bool 睫毛下下右_表示 = true;

    	public double 外線;

    	public double 睫毛上上左_長さ;

    	public double 睫毛上中左_長さ;

    	public double 睫毛上下左_長さ;

    	public double 睫毛上上右_長さ;

    	public double 睫毛上中右_長さ;

    	public double 睫毛上下右_長さ;

    	public double 睫毛下上左_長さ;

    	public double 睫毛下下左_長さ;

    	public double 睫毛下上右_長さ;

    	public double 睫毛下下右_長さ;

    	public 単瞼D()
    	{
    		ThisType = GetType();
    	}

    	public 単瞼D SetRandom()
    	{
    		サイズ = Rng.XS.NextDouble();
    		サイズX = Rng.XS.NextDouble();
    		サイズY = Rng.XS.NextDouble();
    		二重_表示 = Rng.XS.NextBool();
    		睫毛上上左_表示 = Rng.XS.NextBool();
    		睫毛上中左_表示 = Rng.XS.NextBool();
    		睫毛上下左_表示 = Rng.XS.NextBool();
    		睫毛上上右_表示 = 睫毛上上左_表示;
    		睫毛上中右_表示 = 睫毛上中左_表示;
    		睫毛上下右_表示 = 睫毛上下左_表示;
    		睫毛下上左_表示 = Rng.XS.NextBool();
    		睫毛下下左_表示 = Rng.XS.NextBool();
    		睫毛下上右_表示 = 睫毛下上左_表示;
    		睫毛下下右_表示 = 睫毛下下左_表示;
    		外線 = Rng.XS.NextDouble();
    		睫毛上上左_長さ = Rng.XS.NextDouble();
    		睫毛上中左_長さ = Rng.XS.NextDouble();
    		睫毛上下左_長さ = Rng.XS.NextDouble();
    		睫毛上上右_長さ = 睫毛上上左_長さ;
    		睫毛上中右_長さ = 睫毛上中左_長さ;
    		睫毛上下右_長さ = 睫毛上下左_長さ;
    		睫毛下上左_長さ = Rng.XS.NextDouble();
    		睫毛下下左_長さ = Rng.XS.NextDouble();
    		睫毛下上右_長さ = 睫毛下上左_長さ;
    		睫毛下下右_長さ = 睫毛下下左_長さ;
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 単瞼(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
