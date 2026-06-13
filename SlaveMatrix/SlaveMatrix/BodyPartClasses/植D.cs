using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 植D : ElementData
    {
    	public bool 披針葉4_通常_葉_表示 = true;

    	public bool 披針葉4_通常_葉脈_表示 = true;

    	public bool 披針葉4_欠損_葉_表示 = true;

    	public bool 披針葉4_欠損_葉脈_表示 = true;

    	public bool 心臓葉4_通常_葉_表示 = true;

    	public bool 心臓葉4_通常_葉脈_表示 = true;

    	public bool 心臓葉4_欠損_葉_表示 = true;

    	public bool 心臓葉4_欠損_葉脈_表示 = true;

    	public bool 茎_表示 = true;

    	public bool 根1_表示 = true;

    	public bool 根2_表示 = true;

    	public bool 披針葉1_通常_葉_表示 = true;

    	public bool 披針葉1_通常_葉脈_表示 = true;

    	public bool 披針葉1_欠損_葉_表示 = true;

    	public bool 披針葉1_欠損_葉脈_表示 = true;

    	public bool 披針葉2_通常_葉_表示 = true;

    	public bool 披針葉2_通常_葉脈_表示 = true;

    	public bool 披針葉2_欠損_葉_表示 = true;

    	public bool 披針葉2_欠損_葉脈_表示 = true;

    	public bool 披針葉3_通常_葉_表示 = true;

    	public bool 披針葉3_通常_葉脈_表示 = true;

    	public bool 披針葉3_欠損_葉_表示 = true;

    	public bool 披針葉3_欠損_葉脈_表示 = true;

    	public bool 心臓葉1_通常_葉_表示 = true;

    	public bool 心臓葉1_通常_葉脈_表示 = true;

    	public bool 心臓葉1_欠損_葉_表示 = true;

    	public bool 心臓葉1_欠損_葉脈_表示 = true;

    	public bool 心臓葉2_通常_葉_表示 = true;

    	public bool 心臓葉2_通常_葉脈_表示 = true;

    	public bool 心臓葉2_欠損_葉_表示 = true;

    	public bool 心臓葉2_欠損_葉脈_表示 = true;

    	public bool 心臓葉3_通常_葉_表示 = true;

    	public bool 心臓葉3_通常_葉脈_表示 = true;

    	public bool 心臓葉3_欠損_葉_表示 = true;

    	public bool 心臓葉3_欠損_葉脈_表示 = true;

    	public bool 披針葉4_葉_表示 = true;

    	public bool 披針葉4_葉脈_表示 = true;

    	public bool 心臓葉4_葉_表示 = true;

    	public bool 心臓葉4_葉脈_表示 = true;

    	public bool 披針葉1_葉_表示 = true;

    	public bool 披針葉1_葉脈_表示 = true;

    	public bool 披針葉2_葉_表示 = true;

    	public bool 披針葉2_葉脈_表示 = true;

    	public bool 披針葉3_葉_表示 = true;

    	public bool 披針葉3_葉脈_表示 = true;

    	public bool 心臓葉1_葉_表示 = true;

    	public bool 心臓葉1_葉脈_表示 = true;

    	public bool 心臓葉2_葉_表示 = true;

    	public bool 心臓葉2_葉脈_表示 = true;

    	public bool 心臓葉3_葉_表示 = true;

    	public bool 心臓葉3_葉脈_表示 = true;

    	public List<ElementData> 花_接続 = new List<ElementData>();

    	public 植D()
    	{
    		ThisType = GetType();
    	}

    	public void 花接続(ElementData e)
    	{
    		花_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.植_花_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 植(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
