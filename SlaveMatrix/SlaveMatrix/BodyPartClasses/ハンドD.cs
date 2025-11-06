using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class ハンドD : EleD
    {
    	public bool 親指_表示 = true;

    	public bool 手_表示 = true;

    	public bool 小指_表示 = true;

    	public bool 薬指_表示 = true;

    	public bool 中指_表示 = true;

    	public bool 人指_表示 = true;

    	public bool 呪印_輪1_輪外_表示 = true;

    	public bool 呪印_輪1_輪内_表示 = true;

    	public bool 呪印_輪2_輪外_表示 = true;

    	public bool 呪印_輪2_輪内_表示 = true;

    	public bool 呪印_輪3_輪外_表示 = true;

    	public bool 呪印_輪3_輪内_表示 = true;

    	public bool 呪印_鎖1_表示 = true;

    	public bool 呪印_鎖2_表示 = true;

    	public bool 呪印_鎖3_表示 = true;

    	public ハンドD()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 主人公配色 体配色)
    	{
    		return new ハンド(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
