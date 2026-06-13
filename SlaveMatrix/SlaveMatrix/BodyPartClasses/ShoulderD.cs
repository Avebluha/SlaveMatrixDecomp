using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class ShoulderD : ElementData
    {
    	public bool 脇_脇_表示 = true;

    	public bool 脇_筋肉_表示;

    	public bool Shoulder_表示 = true;

    	public bool Shoulder_虫性_甲殻1_表示;

    	public bool Shoulder_虫性_甲殻2_表示;

    	public bool Shoulder_傷I1_表示;

    	public bool Shoulder_傷I2_表示;

    	public bool Shoulder_傷I3_表示;

    	public bool Shoulder_傷I4_表示;

    	public bool Shoulder_シャツ_表示;

    	public bool Shoulder_ナース_表示;

    	public List<ElementData> UpperArm_接続 = new List<ElementData>();

    	public ShoulderD()
    	{
    		ThisType = GetType();
    	}

    	public void UpperArm接続(ElementData e)
    	{
    		UpperArm_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Shoulder_UpperArm_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new Shoulder(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
