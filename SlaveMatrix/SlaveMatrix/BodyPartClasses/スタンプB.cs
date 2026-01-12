using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class スタンプB : Stamp
    {
    	private Mot ぶっかけ垂れ;

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
    				if (stum.Sta.表示)
    				{
    					p = stum.Ele.Body.Current.GetPar(stum.Path);
    					stum.Sta.位置B = p.ToGlobal(stum.Pos);
    					stum.Sta.色更新();
    					stum.Sta.Body.Draw(Are);
    				}
    			}
    		}
    		catch
    		{
    		}
    	}

    	public void Add(Vector2D cp, Color hc, Dictionary<Ele, List<Ele>> 参照)
    	{
    		he = Bod.GetHitEle(hc);
    		if (チェック2(he))
    		{
    			if (sta.Count >= 33)
    			{
    				sep = sta[0];
    				sta.RemoveAt(0);
    				sep.Sta.Dispose();
    			}
    			sep = default(sep);
    			sep.Sta = EleD.GetEle(Are.DisplayUnitScale, Med, Sta.GameData.配色);
    			sep.Sta.SetHitFalse();
    			sep.Sta.Xv = RNG.XS.NextDouble();
    			sep.Sta.右 = RNG.XS.NextBool();
    			sep.Ele = he;
    			sep.Par = he.Body.GetHitPar_(hc);
    			sep.Path = sep.Par.GetPath();
    			sep.Pos = sep.Par.ToLocal(cp);
    			if (参照.ContainsKey(he))
    			{
    				参照[he].Add(sep.Sta);
    			}
    			else
    			{
    				参照[he] = new List<Ele> { sep.Sta };
    			}
    			sta.Add(sep);
    			ぶっかけ垂れ.Start();
    		}
    	}

    	public スタンプB(ModeEventDispatcher Med, RenderArea Are, Cha Cha, Bod Bod, EleD EleD, Mots Mots)
    		: base(Med, Are, Cha, Bod, EleD)
    	{
    		Ele e = null;
    		ぶっかけ垂れ = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			Staing = delegate(Mot m)
    			{
    				e = sta.Last().Sta;
    				m.Max = RNG.XS.NextDouble();
    			},
    			Runing = delegate(Mot m)
    			{
    				e.Yv = m.Value;
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(EleD.GetHashCode().ToString(), ぶっかけ垂れ);
    	}
    }
}
