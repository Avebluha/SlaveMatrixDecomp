using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class JacketBottom_クロスD : JacketBottomD
    {
    	public bool 中_下地_表示;

    	public bool 中_皺1_表示;

    	public bool 中_皺2_表示;

    	public bool 左_下地_表示;

    	public bool 左_皺1_表示;

    	public bool 左_皺2_表示;

    	public bool 左_皺3_表示;

    	public bool 左_皺4_表示;

    	public bool 左_皺5_表示;

    	public bool 左_皺6_表示;

    	public bool 右_下地_表示;

    	public bool 右_皺1_表示;

    	public bool 右_皺2_表示;

    	public bool 右_皺3_表示;

    	public bool 右_皺4_表示;

    	public bool 右_皺5_表示;

    	public bool 右_皺6_表示;

    	public bool ベース表示;

    	public bool ベース皺1表示;

    	public bool ベース皺2表示;

    	public bool ベース皺3表示;

    	public bool ベース皺4表示;

    	public bool ベース皺5表示;

    	public bool 中表示;

    	public bool 中皺1表示;

    	public bool 中皺2表示;

    	public List<ElementData> JacketBottomRear_接続 = new List<ElementData>();

    	public JacketBottom_クロスD()
    	{
    		ThisType = GetType();
    	}

    	public void JacketBottomRear接続(ElementData e)
    	{
    		JacketBottomRear_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.JacketBottom_クロス_JacketBottomRear_接続;
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new JacketBottom_クロス(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
