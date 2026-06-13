using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class 鼻D : ElementData
    {
    	public List<ElementData> 鼻水左_接続 = new List<ElementData>();

    	public List<ElementData> 鼻水右_接続 = new List<ElementData>();

    	public virtual void 鼻水左接続(ElementData e)
    	{
    	}

    	public virtual void 鼻水右接続(ElementData e)
    	{
    	}
    }
}
