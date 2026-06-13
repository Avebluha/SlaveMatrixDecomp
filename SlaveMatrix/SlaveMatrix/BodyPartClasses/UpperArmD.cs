using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class UpperArmD : ElementData
    {
    	public List<ElementData> LowerArm_接続 = new List<ElementData>();

    	public virtual void LowerArm接続(ElementData e)
    	{
    	}
    }
}
