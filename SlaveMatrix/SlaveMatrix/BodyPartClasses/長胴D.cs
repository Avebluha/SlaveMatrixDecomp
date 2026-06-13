using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class 長胴D : ElementData
    {
    	public List<ElementData> 左_接続 = new List<ElementData>();

    	public List<ElementData> 右_接続 = new List<ElementData>();

    	public List<ElementData> Torso_接続 = new List<ElementData>();

    	public virtual void 左接続(ElementData e)
    	{
    	}

    	public virtual void 右接続(ElementData e)
    	{
    	}

    	public virtual void Torso接続(ElementData e)
    	{
    	}
    }
}
