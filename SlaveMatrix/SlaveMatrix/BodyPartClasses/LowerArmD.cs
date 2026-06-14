using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class LowerArmD : ElementData
    {
    	public List<ElementData> 手_接続 = new List<ElementData>();

    	public virtual void 手接続(ElementData e)
    	{
    	}
    }
}
