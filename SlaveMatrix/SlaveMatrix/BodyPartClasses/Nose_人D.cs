using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class Nose_人D : NoseD
    {
    	public bool Nose_表示 = true;

    	public Nose_人D()
    	{
    		ThisType = GetType();
    	}

    	public override void 鼻水左接続(ElementData e)
    	{
    		NoseDripLeft_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Nose_人_NoseDripLeft_接続;
    	}

    	public override void 鼻水右接続(ElementData e)
    	{
    		鼻水右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Nose_人_鼻水右_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new Nose_人(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
