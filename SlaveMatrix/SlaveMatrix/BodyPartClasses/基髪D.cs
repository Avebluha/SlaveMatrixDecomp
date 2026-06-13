using System;
using System.Collections.Generic;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 基髪D : EleD
    {
    	public bool 髪_表示 = true;

    	public List<EleD> 頭頂左_接続 = new List<EleD>();

    	public List<EleD> 頭頂右_接続 = new List<EleD>();

    	public List<EleD> 横髪左_接続 = new List<EleD>();

    	public List<EleD> 横髪右_接続 = new List<EleD>();

    	public List<EleD> 前髪_接続 = new List<EleD>();

    	public List<EleD> 後髪_接続 = new List<EleD>();

    	public 基髪D()
    	{
    		ThisType = GetType();
    	}

    	public void 頭頂左接続(EleD e)
    	{
    		頭頂左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.基髪_頭頂左_接続;
    	}

    	public void 頭頂右接続(EleD e)
    	{
    		頭頂右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.基髪_頭頂右_接続;
    	}

    	public void 横髪左接続(EleD e)
    	{
    		横髪左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.基髪_横髪左_接続;
    	}

    	public void 横髪右接続(EleD e)
    	{
    		横髪右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.基髪_横髪右_接続;
    	}

    	public void 前髪接続(EleD e)
    	{
    		前髪_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.基髪_前髪_接続;
    	}

    	public void 後髪接続(EleD e)
    	{
    		後髪_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.基髪_後髪_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 基髪(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
