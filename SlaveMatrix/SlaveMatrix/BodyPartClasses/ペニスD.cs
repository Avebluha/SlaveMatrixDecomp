using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class ペニスD : ElementData
    {
    	public bool 陰嚢_表示 = true;

    	public bool 陰茎_表示 = true;

    	public bool 血管下_表示 = true;

    	public bool 血管上_表示 = true;

    	public bool 亀頭_表示 = true;

    	public List<ElementData> 尿道_接続 = new List<ElementData>();

    	public ペニスD()
    	{
    		ThisType = GetType();
    	}

    	public void 尿道接続(ElementData e)
    	{
    		尿道_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.ペニス_尿道_接続;
    	}
    }
}
