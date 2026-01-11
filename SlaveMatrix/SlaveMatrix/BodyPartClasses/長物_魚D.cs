using _2DGAMELIB;
using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class 長物_魚D : 半身D
    {
    	public bool Torso6_鱗左_鱗1_表示 = true;

    	public bool Torso6_鱗左_鱗2_表示 = true;

    	public bool Torso6_鱗左_鱗3_表示 = true;

    	public bool Torso6_鱗左_鱗4_表示 = true;

    	public bool Torso6_鱗右_鱗1_表示 = true;

    	public bool Torso6_鱗右_鱗2_表示 = true;

    	public bool Torso6_鱗右_鱗3_表示 = true;

    	public bool Torso6_鱗右_鱗4_表示 = true;

    	public bool Torso6_Torso_表示 = true;

    	public bool Torso5_鱗左_鱗1_表示 = true;

    	public bool Torso5_鱗左_鱗2_表示 = true;

    	public bool Torso5_鱗左_鱗3_表示 = true;

    	public bool Torso5_鱗左_鱗4_表示 = true;

    	public bool Torso5_鱗右_鱗1_表示 = true;

    	public bool Torso5_鱗右_鱗2_表示 = true;

    	public bool Torso5_鱗右_鱗3_表示 = true;

    	public bool Torso5_鱗右_鱗4_表示 = true;

    	public bool Torso5_Torso_表示 = true;

    	public bool 輪2_革_表示 = true;

    	public bool 輪2_金具1_表示 = true;

    	public bool 輪2_金具2_表示 = true;

    	public bool 輪2_金具3_表示 = true;

    	public bool 輪2_金具左_表示 = true;

    	public bool 輪2_金具右_表示 = true;

    	public bool Torso4_鱗左_鱗1_表示 = true;

    	public bool Torso4_鱗左_鱗2_表示 = true;

    	public bool Torso4_鱗左_鱗3_表示 = true;

    	public bool Torso4_鱗左_鱗4_表示 = true;

    	public bool Torso4_鱗右_鱗1_表示 = true;

    	public bool Torso4_鱗右_鱗2_表示 = true;

    	public bool Torso4_鱗右_鱗3_表示 = true;

    	public bool Torso4_鱗右_鱗4_表示 = true;

    	public bool Torso4_Torso_表示 = true;

    	public bool Torso3_鱗左_鱗1_表示 = true;

    	public bool Torso3_鱗左_鱗2_表示 = true;

    	public bool Torso3_鱗左_鱗3_表示 = true;

    	public bool Torso3_鱗左_鱗4_表示 = true;

    	public bool Torso3_鱗右_鱗1_表示 = true;

    	public bool Torso3_鱗右_鱗2_表示 = true;

    	public bool Torso3_鱗右_鱗3_表示 = true;

    	public bool Torso3_鱗右_鱗4_表示 = true;

    	public bool Torso3_Torso_表示 = true;

    	public bool Torso2_鱗左_鱗1_表示 = true;

    	public bool Torso2_鱗左_鱗2_表示 = true;

    	public bool Torso2_鱗左_鱗3_表示 = true;

    	public bool Torso2_鱗左_鱗4_表示 = true;

    	public bool Torso2_鱗右_鱗1_表示 = true;

    	public bool Torso2_鱗右_鱗2_表示 = true;

    	public bool Torso2_鱗右_鱗3_表示 = true;

    	public bool Torso2_鱗右_鱗4_表示 = true;

    	public bool Torso2_Torso_表示 = true;

    	public bool Torso1_鱗左2_鱗1_表示 = true;

    	public bool Torso1_鱗左2_鱗2_表示 = true;

    	public bool Torso1_鱗左2_鱗3_表示 = true;

    	public bool Torso1_鱗左2_鱗4_表示 = true;

    	public bool Torso1_鱗右2_鱗1_表示 = true;

    	public bool Torso1_鱗右2_鱗2_表示 = true;

    	public bool Torso1_鱗右2_鱗3_表示 = true;

    	public bool Torso1_鱗右2_鱗4_表示 = true;

    	public bool Torso1_Torso2_表示 = true;

    	public bool Torso1_Torso1_表示 = true;

    	public bool Torso1_鱗左1_鱗1_表示 = true;

    	public bool Torso1_鱗左1_鱗2_表示 = true;

    	public bool Torso1_鱗左1_鱗3_表示 = true;

    	public bool Torso1_鱗左1_鱗4_表示 = true;

    	public bool Torso1_鱗右1_鱗1_表示 = true;

    	public bool Torso1_鱗右1_鱗2_表示 = true;

    	public bool Torso1_鱗右1_鱗3_表示 = true;

    	public bool Torso1_鱗右1_鱗4_表示 = true;

    	public bool 輪1_革_表示 = true;

    	public bool 輪1_金具1_表示 = true;

    	public bool 輪1_金具2_表示 = true;

    	public bool 輪1_金具3_表示 = true;

    	public bool 輪1_金具左_表示 = true;

    	public bool 輪1_金具右_表示 = true;

    	public bool 輪1表示 = true;

    	public bool 輪2表示 = true;

    	public bool Torso_外線;

    	public bool Rパターン;

    	public bool 鱗1 = true;

    	public bool 鱗2 = true;

    	public bool 鱗3 = true;

    	public bool 鱗4 = true;

    	public bool 鎖表示;

    	public List<EleD> 左0_接続 = new List<EleD>();

    	public List<EleD> 右0_接続 = new List<EleD>();

    	public List<EleD> 左1_接続 = new List<EleD>();

    	public List<EleD> 右1_接続 = new List<EleD>();

    	public List<EleD> 左2_接続 = new List<EleD>();

    	public List<EleD> 右2_接続 = new List<EleD>();

    	public List<EleD> 左3_接続 = new List<EleD>();

    	public List<EleD> 右3_接続 = new List<EleD>();

    	public List<EleD> 左4_接続 = new List<EleD>();

    	public List<EleD> 右4_接続 = new List<EleD>();

    	public List<EleD> 左5_接続 = new List<EleD>();

    	public List<EleD> 右5_接続 = new List<EleD>();

    	public List<EleD> 左6_接続 = new List<EleD>();

    	public List<EleD> 右6_接続 = new List<EleD>();

    	public List<EleD> 尾_接続 = new List<EleD>();

    	public 長物_魚D()
    	{
    		ThisType = GetType();
    	}

    	public void 左0接続(EleD e)
    	{
    		左0_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_左0_接続;
    	}

    	public void 右0接続(EleD e)
    	{
    		右0_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_右0_接続;
    	}

    	public void 左1接続(EleD e)
    	{
    		左1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_左1_接続;
    	}

    	public void 右1接続(EleD e)
    	{
    		右1_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_右1_接続;
    	}

    	public void 左2接続(EleD e)
    	{
    		左2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_左2_接続;
    	}

    	public void 右2接続(EleD e)
    	{
    		右2_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_右2_接続;
    	}

    	public void 左3接続(EleD e)
    	{
    		左3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_左3_接続;
    	}

    	public void 右3接続(EleD e)
    	{
    		右3_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_右3_接続;
    	}

    	public void 左4接続(EleD e)
    	{
    		左4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_左4_接続;
    	}

    	public void 右4接続(EleD e)
    	{
    		右4_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_右4_接続;
    	}

    	public void 左5接続(EleD e)
    	{
    		左5_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_左5_接続;
    	}

    	public void 右5接続(EleD e)
    	{
    		右5_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_右5_接続;
    	}

    	public void 左6接続(EleD e)
    	{
    		左6_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_左6_接続;
    	}

    	public void 右6接続(EleD e)
    	{
    		右6_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_右6_接続;
    	}

    	public void 尾接続(EleD e)
    	{
    		尾_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.長物_魚_尾_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 長物_魚(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
