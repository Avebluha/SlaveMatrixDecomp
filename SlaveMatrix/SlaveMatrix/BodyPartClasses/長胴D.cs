using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class 長胴D : EleD
    {
    	public List<EleD> 左_接続 = new List<EleD>();

    	public List<EleD> 右_接続 = new List<EleD>();

    	public List<EleD> Torso_接続 = new List<EleD>();

    	public virtual void 左接続(EleD e)
    	{
    	}

    	public virtual void 右接続(EleD e)
    	{
    	}

    	public virtual void Torso接続(EleD e)
    	{
    	}
    }
}
