using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 多足_蠍D : 半身D
    {
    	public bool 前腹_腹節7_節0_表示 = true;

    	public bool 前腹_腹節7_節1_表示 = true;

    	public bool 前腹_腹節6_節0_表示 = true;

    	public bool 前腹_腹節6_節1_表示 = true;

    	public bool 前腹_腹節6_節線_表示;

    	public bool 前腹_腹節6_気門左_表示 = true;

    	public bool 前腹_腹節6_気門右_表示 = true;

    	public bool 前腹_腹節5_節0_表示 = true;

    	public bool 前腹_腹節5_節1_表示 = true;

    	public bool 前腹_腹節5_節線_表示;

    	public bool 前腹_腹節5_気門左_表示 = true;

    	public bool 前腹_腹節5_気門右_表示 = true;

    	public bool 前腹_腹節4_節0_表示 = true;

    	public bool 前腹_腹節4_節1_表示 = true;

    	public bool 前腹_腹節4_節線_表示;

    	public bool 前腹_腹節4_気門左_表示 = true;

    	public bool 前腹_腹節4_気門右_表示 = true;

    	public bool 前腹_腹節3_節0_表示 = true;

    	public bool 前腹_腹節3_節1_表示 = true;

    	public bool 前腹_腹節3_節線_表示;

    	public bool 前腹_腹節3_気門左_表示 = true;

    	public bool 前腹_腹節3_気門右_表示 = true;

    	public bool 前腹_腹節2_節0_表示 = true;

    	public bool 頭胸_表示 = true;

    	public bool 基節_基節左0_表示 = true;

    	public bool 基節_基節左1_表示 = true;

    	public bool 基節_肢内突起左_表示 = true;

    	public bool 基節_基節左2_表示 = true;

    	public bool 基節_基節左3_表示 = true;

    	public bool 基節_基節左4_表示 = true;

    	public bool 基節_基節右0_表示 = true;

    	public bool 基節_基節右1_表示 = true;

    	public bool 基節_肢内突起右_表示 = true;

    	public bool 基節_基節右2_表示 = true;

    	public bool 基節_基節右3_表示 = true;

    	public bool 基節_基節右4_表示 = true;

    	public bool 生殖口蓋左_表示 = true;

    	public bool 生殖口蓋右_表示 = true;

    	public bool 生殖口_生殖口0_表示 = true;

    	public bool 生殖口_生殖口1_表示 = true;

    	public double くぱぁ;

    	public List<ElementData> 触肢左_接続 = new List<ElementData>();

    	public List<ElementData> 節足左1_接続 = new List<ElementData>();

    	public List<ElementData> 節足左2_接続 = new List<ElementData>();

    	public List<ElementData> 節足左3_接続 = new List<ElementData>();

    	public List<ElementData> 節足左4_接続 = new List<ElementData>();

    	public List<ElementData> 触肢右_接続 = new List<ElementData>();

    	public List<ElementData> 節足右1_接続 = new List<ElementData>();

    	public List<ElementData> 節足右2_接続 = new List<ElementData>();

    	public List<ElementData> 節足右3_接続 = new List<ElementData>();

    	public List<ElementData> 節足右4_接続 = new List<ElementData>();

    	public List<ElementData> 櫛状板左_接続 = new List<ElementData>();

    	public List<ElementData> 櫛状板右_接続 = new List<ElementData>();

    	public List<ElementData> 尾_接続 = new List<ElementData>();

    	public 多足_蠍D()
    	{
    		ThisType = GetType();
    	}

    	public void 触肢左接続(ElementData e)
    	{
    		触肢左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蠍_触肢左_接続;
    	}

    	public void 節足左1接続(ElementData e)
    	{
    		節足左1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蠍_節足左1_接続;
    		if (!(e is 節足D))
    		{
    			return;
    		}
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度XB = 1.0;
    		}
    	}

    	public void 節足左2接続(ElementData e)
    	{
    		節足左2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蠍_節足左2_接続;
    		if (!(e is 節足D))
    		{
    			return;
    		}
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度XB = 1.05;
    		}
    	}

    	public void 節足左3接続(ElementData e)
    	{
    		節足左3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蠍_節足左3_接続;
    		if (!(e is 節足D))
    		{
    			return;
    		}
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度XB = 1.1;
    		}
    	}

    	public void 節足左4接続(ElementData e)
    	{
    		節足左4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蠍_節足左4_接続;
    		if (!(e is 節足D))
    		{
    			return;
    		}
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度XB = 1.15;
    		}
    	}

    	public void 触肢右接続(ElementData e)
    	{
    		触肢右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蠍_触肢右_接続;
    	}

    	public void 節足右1接続(ElementData e)
    	{
    		節足右1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蠍_節足右1_接続;
    		if (!(e is 節足D))
    		{
    			return;
    		}
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度XB = 1.0;
    		}
    	}

    	public void 節足右2接続(ElementData e)
    	{
    		節足右2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蠍_節足右2_接続;
    		if (!(e is 節足D))
    		{
    			return;
    		}
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度XB = 1.05;
    		}
    	}

    	public void 節足右3接続(ElementData e)
    	{
    		節足右3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蠍_節足右3_接続;
    		if (!(e is 節足D))
    		{
    			return;
    		}
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度XB = 1.1;
    		}
    	}

    	public void 節足右4接続(ElementData e)
    	{
    		節足右4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蠍_節足右4_接続;
    		if (!(e is 節足D))
    		{
    			return;
    		}
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度XB = 1.15;
    		}
    	}

    	public void 櫛状板左接続(ElementData e)
    	{
    		櫛状板左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蠍_櫛状板左_接続;
    	}

    	public void 櫛状板右接続(ElementData e)
    	{
    		櫛状板右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蠍_櫛状板右_接続;
    	}

    	public void 尾接続(ElementData e)
    	{
    		尾_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.多足_蠍_尾_接続;
    		foreach (ElementData item in e.EnumEleD())
    		{
    			item.尺度B = 1.3;
    		}
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 多足_蠍(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
