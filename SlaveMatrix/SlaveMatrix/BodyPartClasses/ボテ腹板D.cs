using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class ボテ腹板D : EleD
    {
    	public bool 腹板4_腹板_表示;

    	public bool 腹板4_縦線_表示;

    	public bool 腹板3_腹板_表示;

    	public bool 腹板3_縦線_表示;

    	public bool 腹板2_腹板_表示;

    	public bool 腹板2_縦線_表示;

    	public bool 腹板1_腹板_表示;

    	public bool 腹板1_縦線_表示;

    	public ボテ腹板D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new ボテ腹板(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
