using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class ShoulderD : EleD
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

    	public List<EleD> UpperArm_接続 = new List<EleD>();

    	public ShoulderD()
    	{
    		ThisType = GetType();
    	}

    	public void UpperArm接続(EleD e)
    	{
    		UpperArm_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.Shoulder_UpperArm_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new Shoulder(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
