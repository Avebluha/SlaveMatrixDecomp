using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class Anus_人D : AnusD
    {
    	public bool Anus3_表示 = true;

    	public bool Anus2_表示 = true;

    	public bool Anus1_表示 = true;

    	public List<ElementData> 肛門精液_接続 = new List<ElementData>();

    	public Anus_人D()
    	{
    		ThisType = GetType();
    	}

    	public void 肛門精液接続(ElementData e)
    	{
    		肛門精液_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Anus_人_肛門精液_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new Anus_人(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
