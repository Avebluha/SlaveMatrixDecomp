using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class LegD : ElementData
    {
    	public List<ElementData> 足_接続 = new List<ElementData>();

    	public virtual void 足接続(ElementData e)
    	{
    	}
    }
}
