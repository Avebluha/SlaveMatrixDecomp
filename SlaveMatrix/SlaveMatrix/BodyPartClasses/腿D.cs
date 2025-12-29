using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class 腿D : EleD
    {
    	public List<EleD> Leg_接続 = new List<EleD>();

    	public virtual void Leg接続(EleD e)
    	{
    	}
    }
}
