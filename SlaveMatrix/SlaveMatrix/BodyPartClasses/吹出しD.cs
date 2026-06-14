using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class 吹出しD : ElementData
    {
    	public bool 吹出し_表示;

    	public List<ElementData> 吹出し_接続 = new List<ElementData>();

    	public 吹出しD()
    	{
    		ThisType = GetType();
    	}

    	public void 吹出し接続(ElementData e)
    	{
    		吹出し_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.吹出し_吹出し_接続;
    	}
    }
}
