using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class VaginaOrigin_獣D : VaginaOriginD
    {
    	public bool VaginaOrigin_表示;

    	public VaginaOrigin_獣D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new VaginaOrigin_獣(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
