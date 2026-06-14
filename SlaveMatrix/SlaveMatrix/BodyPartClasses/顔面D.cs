using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class 顔面D : ElementData
    {
    	public double 展開0;

    	public List<ElementData> 触覚左_接続 = new List<ElementData>();

    	public List<ElementData> 触覚右_接続 = new List<ElementData>();

    	public virtual void 触覚左接続(ElementData e)
    	{
    	}

    	public virtual void 触覚右接続(ElementData e)
    	{
    	}
    }
}
