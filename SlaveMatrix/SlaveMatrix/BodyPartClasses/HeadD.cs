using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class HeadD : ElementData
    {
    	public bool 頭_表示 = true;

    	public bool 悪タトゥ_逆十字_逆十字1_表示;

    	public bool 悪タトゥ_逆十字_逆十字2_表示;

    	public bool 隈取_タトゥ_表示;

    	public bool 隈取_タトゥ左_表示;

    	public bool 隈取_タトゥ右_表示;

    	public bool 秘石_基_表示;

    	public bool 秘石_秘石_表示;

    	public bool 秘石_ハイライト_表示;

    	public bool 蜘蛛_眼左1_基_表示;

    	public bool 蜘蛛_眼左1_眼_表示;

    	public bool 蜘蛛_眼左1_ハイライト_表示;

    	public bool 蜘蛛_眼左2_基_表示;

    	public bool 蜘蛛_眼左2_眼_表示;

    	public bool 蜘蛛_眼左2_ハイライト_表示;

    	public bool 蜘蛛_眼右1_基_表示;

    	public bool 蜘蛛_眼右1_眼_表示;

    	public bool 蜘蛛_眼右1_ハイライト_表示;

    	public bool 蜘蛛_眼右2_基_表示;

    	public bool 蜘蛛_眼右2_眼_表示;

    	public bool 蜘蛛_眼右2_ハイライト_表示;

    	public bool 羽虫_眼中_基_表示;

    	public bool 羽虫_眼中_眼_表示;

    	public bool 羽虫_眼中_ハイライト_表示;

    	public bool 羽虫_眼左_基_表示;

    	public bool 羽虫_眼左_眼_表示;

    	public bool 羽虫_眼左_ハイライト_表示;

    	public bool 羽虫_眼右_基_表示;

    	public bool 羽虫_眼右_眼_表示;

    	public bool 羽虫_眼右_ハイライト_表示;

    	public bool 紋柄_紋_表示;

    	public bool 紋柄_紋左1_表示;

    	public bool 紋柄_紋右1_表示;

    	public bool 紋柄_紋左2_表示;

    	public bool 紋柄_紋右2_表示;

    	public bool 竜性_鱗1_表示;

    	public bool 竜性_鱗2_表示;

    	public bool 竜性_鱗3_表示;

    	public bool 馬柄_馬柄_表示;

    	public bool 虫性_顎下_表示;

    	public double 目高;

    	public double 目間;

    	public double 眉間;

    	public List<ElementData> BaseHair_接続 = new List<ElementData>();

    	public List<ElementData> 目左_接続 = new List<ElementData>();

    	public List<ElementData> 目右_接続 = new List<ElementData>();

    	public List<ElementData> 鼻_接続 = new List<ElementData>();

    	public List<ElementData> 口_接続 = new List<ElementData>();

    	public List<ElementData> 頬左_接続 = new List<ElementData>();

    	public List<ElementData> 頬右_接続 = new List<ElementData>();

    	public List<ElementData> 額_接続 = new List<ElementData>();

    	public List<ElementData> 眉左_接続 = new List<ElementData>();

    	public List<ElementData> 眉右_接続 = new List<ElementData>();

    	public List<ElementData> 耳左_接続 = new List<ElementData>();

    	public List<ElementData> 耳右_接続 = new List<ElementData>();

    	public List<ElementData> 鼻肌_接続 = new List<ElementData>();

    	public List<ElementData> MonoEye_接続 = new List<ElementData>();

    	public List<ElementData> 単眼眉_接続 = new List<ElementData>();

    	public List<ElementData> 大顎基_接続 = new List<ElementData>();

    	public List<ElementData> 顔面_接続 = new List<ElementData>();

    	public List<ElementData> 頭頂_接続 = new List<ElementData>();

    	public List<ElementData> 頬肌左_接続 = new List<ElementData>();

    	public List<ElementData> 頬肌右_接続 = new List<ElementData>();

    	public List<ElementData> 触覚左_接続 = new List<ElementData>();

    	public List<ElementData> 触覚右_接続 = new List<ElementData>();

    	public HeadD()
    	{
    		ThisType = GetType();
    	}

    	public void 基髪接続(ElementData e)
    	{
    		BaseHair_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_BaseHair_接続;
    	}

    	public void 目左接続(ElementData e)
    	{
    		目左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_目左_接続;
    	}

    	public void 目右接続(ElementData e)
    	{
    		目右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_目右_接続;
    	}

    	public void 鼻接続(ElementData e)
    	{
    		鼻_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_鼻_接続;
    	}

    	public void 口接続(ElementData e)
    	{
    		口_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_口_接続;
    	}

    	public void 頬左接続(ElementData e)
    	{
    		頬左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_頬左_接続;
    	}

    	public void 頬右接続(ElementData e)
    	{
    		頬右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_頬右_接続;
    	}

    	public void 額接続(ElementData e)
    	{
    		額_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_額_接続;
    	}

    	public void 眉左接続(ElementData e)
    	{
    		眉左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_眉左_接続;
    	}

    	public void 眉右接続(ElementData e)
    	{
    		眉右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_眉右_接続;
    	}

    	public void 耳左接続(ElementData e)
    	{
    		耳左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_耳左_接続;
    	}

    	public void 耳右接続(ElementData e)
    	{
    		耳右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_耳右_接続;
    	}

    	public void 鼻肌接続(ElementData e)
    	{
    		鼻肌_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_鼻肌_接続;
    	}

    	public void 単眼目接続(ElementData e)
    	{
    		MonoEye_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_MonoEye_接続;
    	}

    	public void 単眼眉接続(ElementData e)
    	{
    		単眼眉_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_単眼眉_接続;
    	}

    	public void 大顎基接続(ElementData e)
    	{
    		大顎基_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_大顎基_接続;
    	}

    	public void 顔面接続(ElementData e)
    	{
    		顔面_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_顔面_接続;
    	}

    	public void 頭頂接続(ElementData e)
    	{
    		頭頂_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_頭頂_接続;
    	}

    	public void 頬肌左接続(ElementData e)
    	{
    		頬肌左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_頬肌左_接続;
    	}

    	public void 頬肌右接続(ElementData e)
    	{
    		頬肌右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_頬肌右_接続;
    	}

    	public void 触覚左接続(ElementData e)
    	{
    		触覚左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_触覚左_接続;
    	}

    	public void 触覚右接続(ElementData e)
    	{
    		触覚右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Head_触覚右_接続;
    	}

    	public HeadD SetRandom()
    	{
    		目高 = Rng.XS.NextDouble();
    		return this;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new Head(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
