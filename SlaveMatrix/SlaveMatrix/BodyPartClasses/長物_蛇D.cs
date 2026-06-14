using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 長物_蛇D : 半身D
    {
    	public bool Torso1_表示 = true;

    	public bool Torso1_鱗2_表示 = true;

    	public bool Torso1_鱗右_表示 = true;

    	public bool Torso1_鱗左_表示 = true;

    	public bool Torso1_鱗1_表示 = true;

    	public bool Torso1_鱗左2_表示 = true;

    	public bool Torso1_鱗右2_表示 = true;

    	public bool Torso1_鱗左1_表示 = true;

    	public bool Torso1_鱗右1_表示 = true;

    	public double くぱぁ;

    	public bool ガード = true;

    	public List<ElementData> 左_接続 = new List<ElementData>();

    	public List<ElementData> 右_接続 = new List<ElementData>();

    	public List<ElementData> Torso_接続 = new List<ElementData>();

    	public 長物_蛇D()
    	{
    		ThisType = GetType();
    	}

    	public void 左接続(ElementData e)
    	{
    		左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_蛇_左_接続;
    	}

    	public void 右接続(ElementData e)
    	{
    		右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_蛇_右_接続;
    	}

    	public void 胴接続(ElementData e)
    	{
    		Torso_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_蛇_Torso_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 長物_蛇(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
