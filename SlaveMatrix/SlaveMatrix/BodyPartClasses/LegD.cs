using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class LegD : EleD
    {
    	public List<EleD> 足_接続 = new List<EleD>();

    	public virtual void 足接続(EleD e)
    	{
    	}
    }
}
