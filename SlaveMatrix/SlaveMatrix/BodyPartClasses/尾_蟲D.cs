using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 尾_蟲D : 尾D
    {
    	public bool 尾5_背板_表示 = true;

    	public bool 尾5_節_表示 = true;

    	public bool 尾5_胸板_表示 = true;

    	public bool 尾5_表示 = true;

    	public bool 尾5_瘤左2_表示 = true;

    	public bool 尾5_瘤左1_表示 = true;

    	public bool 尾5_瘤右2_表示 = true;

    	public bool 尾5_瘤右1_表示 = true;

    	public bool 尾4_背板_表示 = true;

    	public bool 尾4_節_表示 = true;

    	public bool 尾4_胸板_表示 = true;

    	public bool 尾4_表示 = true;

    	public bool 尾4_瘤左2_表示 = true;

    	public bool 尾4_瘤左1_表示 = true;

    	public bool 尾4_瘤右2_表示 = true;

    	public bool 尾4_瘤右1_表示 = true;

    	public bool 尾3_背板_表示 = true;

    	public bool 尾3_節_表示 = true;

    	public bool 尾3_胸板_表示 = true;

    	public bool 尾3_表示 = true;

    	public bool 尾3_瘤左2_表示 = true;

    	public bool 尾3_瘤左1_表示 = true;

    	public bool 尾3_瘤右2_表示 = true;

    	public bool 尾3_瘤右1_表示 = true;

    	public bool 輪2_革_表示 = true;

    	public bool 輪2_金具1_表示 = true;

    	public bool 輪2_金具2_表示 = true;

    	public bool 輪2_金具3_表示 = true;

    	public bool 輪2_金具左_表示 = true;

    	public bool 輪2_金具右_表示 = true;

    	public bool 尾2_背板_表示 = true;

    	public bool 尾2_節_表示 = true;

    	public bool 尾2_胸板_表示 = true;

    	public bool 尾2_表示 = true;

    	public bool 尾2_瘤左2_表示 = true;

    	public bool 尾2_瘤左1_表示 = true;

    	public bool 尾2_瘤右2_表示 = true;

    	public bool 尾2_瘤右1_表示 = true;

    	public bool 尾1_背板_表示 = true;

    	public bool 尾1_節_表示 = true;

    	public bool 尾1_胸板_表示 = true;

    	public bool 尾1_表示 = true;

    	public bool 尾1_瘤左2_表示 = true;

    	public bool 尾1_瘤左1_表示 = true;

    	public bool 尾1_瘤右2_表示 = true;

    	public bool 尾1_瘤右1_表示 = true;

    	public bool 尾0_背板_表示 = true;

    	public bool 尾0_節_表示 = true;

    	public bool 尾0_胸板_表示 = true;

    	public bool 尾0_表示 = true;

    	public bool 尾0_瘤左2_表示 = true;

    	public bool 尾0_瘤左1_表示 = true;

    	public bool 尾0_瘤右2_表示 = true;

    	public bool 尾0_瘤右1_表示 = true;

    	public bool 輪1_革_表示 = true;

    	public bool 輪1_金具1_表示 = true;

    	public bool 輪1_金具2_表示 = true;

    	public bool 輪1_金具3_表示 = true;

    	public bool 輪1_金具左_表示 = true;

    	public bool 輪1_金具右_表示 = true;

    	public bool 輪1表示 = true;

    	public bool 輪2表示 = true;

    	public bool 胸板 = true;

    	public bool 節 = true;

    	public bool 背板 = true;

    	public bool Torso = true;

    	public bool 瘤 = true;

    	public bool 鎖表示;

    	public List<ElementData> 左1_接続 = new List<ElementData>();

    	public List<ElementData> 右1_接続 = new List<ElementData>();

    	public List<ElementData> 左2_接続 = new List<ElementData>();

    	public List<ElementData> 右2_接続 = new List<ElementData>();

    	public List<ElementData> 左3_接続 = new List<ElementData>();

    	public List<ElementData> 右3_接続 = new List<ElementData>();

    	public List<ElementData> 左4_接続 = new List<ElementData>();

    	public List<ElementData> 右4_接続 = new List<ElementData>();

    	public List<ElementData> 左5_接続 = new List<ElementData>();

    	public List<ElementData> 右5_接続 = new List<ElementData>();

    	public List<ElementData> 尾左_接続 = new List<ElementData>();

    	public List<ElementData> 尾右_接続 = new List<ElementData>();

    	public 尾_蟲D()
    	{
    		ThisType = GetType();
    	}

    	public void 左1接続(ElementData e)
    	{
    		左1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.尾_蟲_左1_接続;
    	}

    	public void 右1接続(ElementData e)
    	{
    		右1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.尾_蟲_右1_接続;
    	}

    	public void 左2接続(ElementData e)
    	{
    		左2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.尾_蟲_左2_接続;
    	}

    	public void 右2接続(ElementData e)
    	{
    		右2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.尾_蟲_右2_接続;
    	}

    	public void 左3接続(ElementData e)
    	{
    		左3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.尾_蟲_左3_接続;
    	}

    	public void 右3接続(ElementData e)
    	{
    		右3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.尾_蟲_右3_接続;
    	}

    	public void 左4接続(ElementData e)
    	{
    		左4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.尾_蟲_左4_接続;
    	}

    	public void 右4接続(ElementData e)
    	{
    		右4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.尾_蟲_右4_接続;
    	}

    	public void 左5接続(ElementData e)
    	{
    		左5_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.尾_蟲_左5_接続;
    	}

    	public void 右5接続(ElementData e)
    	{
    		右5_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.尾_蟲_右5_接続;
    	}

    	public void 尾左接続(ElementData e)
    	{
    		尾左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.尾_蟲_尾左_接続;
    	}

    	public void 尾右接続(ElementData e)
    	{
    		尾右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.尾_蟲_尾右_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 尾_蟲(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
