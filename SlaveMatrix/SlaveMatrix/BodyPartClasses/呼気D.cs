using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 呼気D : EleD
    {
    	public bool 呼気左1_呼気1_表示;

    	public bool 呼気左1_呼気2_表示;

    	public bool 呼気左2_呼気1_表示;

    	public bool 呼気左2_呼気2_表示;

    	public bool 呼気左3_呼気1_表示;

    	public bool 呼気左3_呼気2_表示;

    	public bool 呼気右1_呼気1_表示;

    	public bool 呼気右1_呼気2_表示;

    	public bool 呼気右2_呼気1_表示;

    	public bool 呼気右2_呼気2_表示;

    	public bool 呼気右3_呼気1_表示;

    	public bool 呼気右3_呼気2_表示;

    	public 呼気D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 呼気(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
