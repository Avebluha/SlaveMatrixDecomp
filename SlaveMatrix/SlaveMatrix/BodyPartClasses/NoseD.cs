using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class NoseD : ElementData
    {
    	public List<ElementData> NoseDripLeft_接続 = new List<ElementData>();

    	public List<ElementData> 鼻水右_接続 = new List<ElementData>();

    	public virtual void 鼻水左接続(ElementData e)
    	{
    	}

    	public virtual void 鼻水右接続(ElementData e)
    	{
    	}
    }
}
