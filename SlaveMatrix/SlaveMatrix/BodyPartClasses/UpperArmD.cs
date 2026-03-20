using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class UpperArmD : EleD
    {
    	public List<EleD> LowerArm_接続 = new List<EleD>();

    	public virtual void LowerArm接続(EleD e)
    	{
    	}
    }
}
