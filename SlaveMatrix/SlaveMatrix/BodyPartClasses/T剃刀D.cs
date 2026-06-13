using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class T剃刀D : ElementData
    {
    	public bool ヘッド_表示 = true;

    	public bool 刃_刃1_表示 = true;

    	public bool 刃_刃2_表示 = true;

    	public bool Neck_表示 = true;

    	public bool グリップ_グリップ0_表示 = true;

    	public bool グリップ_グリップ1_表示 = true;

    	public bool グリップ_グリップ2_表示 = true;

    	public bool グリップ_グリップ3_表示 = true;

    	public bool グリップ_グリップ4_表示 = true;

    	public bool グリップ_グリップ5_表示 = true;

    	public bool グリップ_グリップ6_表示 = true;

    	public bool グリップ_グリップ7_表示 = true;

    	public bool グリップ_グリップ8_表示 = true;

    	public bool グリップ_グリップ9_表示 = true;

    	public bool グリップ_グリップ10_表示 = true;

    	public bool グリップ_グリップ11_表示 = true;

    	public bool グリップ_グリップ12_表示 = true;

    	public bool グリップ_グリップ13_表示 = true;

    	public bool グリップ_グリップ14_表示 = true;

    	public bool グリップ_グリップ15_表示 = true;

    	public T剃刀D()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new T剃刀(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
