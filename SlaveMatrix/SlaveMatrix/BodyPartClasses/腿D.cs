using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class 腿D : ElementData
    {
    	public List<ElementData> Leg_接続 = new List<ElementData>();

    	public virtual void Leg接続(ElementData e)
    	{
    	}
    }
}
