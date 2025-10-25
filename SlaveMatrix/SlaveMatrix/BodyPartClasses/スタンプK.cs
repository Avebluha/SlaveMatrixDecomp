using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class スタンプK : Stamp
    {
    	private Ele Par;

    	public override void Draw(RenderArea Are)
    	{
    		try
    		{
    			if (sta.Count <= 0)
    			{
    				return;
    			}
    			foreach (sep stum in sta)
    			{
    				p = stum.Ele.本体.Current.GetPar(stum.Path);
    				stum.Sta.角度B = p.AngleBase - stum.Par.AngleBase;
    				stum.Sta.位置B = p.ToGlobal(stum.Pos);
    				stum.Sta.色更新();
    				stum.Sta.本体.Draw(Are);
    			}
    		}
    		catch
    		{
    		}
    	}

    	public キスマーク Add(Vector2D cp, Color hc, Ele he)
    	{
    		if (チェック1(he) && he == Par)
    		{
    			p = he.本体.GetHitPar_(hc);
    			c2 = he.GetParOfColorP(p).ColorD.色;
    			if (c2.Col1 == Cha.配色.人肌O.Col1 || c2.Col2 == Cha.配色.人肌O.Col1)
    			{
    				if (sta.Count >= 33)
    				{
    					sep = sta[0];
    					sta.RemoveAt(0);
    					sep.Sta.Dispose();
    				}
    				sep = default(sep);
    				sep.Sta = EleD.GetEle(Are.DisplayUnitScale, Med, Cha.配色);
    				sep.Sta.SetHitFalse();
    				sep.Ele = he;
    				sep.Par = p;
    				sep.Path = sep.Par.GetPath();
    				sep.Pos = sep.Par.ToLocal(cp);
    				sta.Add(sep);
    			}
    			return (キスマーク)sep.Sta;
    		}
    		return null;
    	}

    	public スタンプK(Med Med, RenderArea Are, Cha Cha, Bod Bod, EleD EleD, Ele Par)
    		: base(Med, Are, Cha, Bod, EleD)
    	{
    		this.Par = Par;
    	}
    }
}
