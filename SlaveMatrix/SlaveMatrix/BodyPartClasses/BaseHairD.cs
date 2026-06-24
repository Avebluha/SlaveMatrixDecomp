using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class BaseHairD : ElementData
    {
    	public bool 髪_表示 = true;

    	public List<ElementData> 頭頂左_接続 = new List<ElementData>();

    	public List<ElementData> 頭頂右_接続 = new List<ElementData>();

    	public List<ElementData> SideHairLeft_接続 = new List<ElementData>();

    	public List<ElementData> 横髪右_接続 = new List<ElementData>();

    	public List<ElementData> FrontHair_接続 = new List<ElementData>();

    	public List<ElementData> 後髪_接続 = new List<ElementData>();

    	public BaseHairD()
    	{
    		ThisType = GetType();
    	}

    	public void 頭頂左接続(ElementData e)
    	{
    		頭頂左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BaseHair_頭頂左_接続;
    	}

    	public void 頭頂右接続(ElementData e)
    	{
    		頭頂右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BaseHair_頭頂右_接続;
    	}

    	public void 横髪左接続(ElementData e)
    	{
    		SideHairLeft_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BaseHair_SideHairLeft_接続;
    	}

    	public void 横髪右接続(ElementData e)
    	{
    		横髪右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BaseHair_横髪右_接続;
    	}

    	public void 前髪接続(ElementData e)
    	{
    		FrontHair_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BaseHair_FrontHair_接続;
    	}

    	public void 後髪接続(ElementData e)
    	{
    		後髪_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.BaseHair_後髪_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new BaseHair(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
