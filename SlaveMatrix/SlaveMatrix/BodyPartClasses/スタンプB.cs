using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class スタンプB : Stamp
    {
    	private Motion ぶっかけ垂れ;

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
    					p = stum.Element.Body.Current.GetPar(stum.Path);
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

    	public void Add(Vector2D cp, Color hc, Dictionary<Element, List<Element>> 参照)
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
    			sep.Sta = ElementData.GetEle(Are.DisplayUnitScale, Med, Sta.GameData.配色);
    			sep.Sta.SetHitFalse();
    			sep.Sta.Xv = RNG.XS.NextDouble();
    			sep.Sta.右 = RNG.XS.NextBool();
    			sep.Element = he;
    			sep.ShapePart = he.Body.GetHitPar_(hc);
    			sep.Path = sep.ShapePart.GetPath();
    			sep.Pos = sep.ShapePart.ToLocal(cp);
    			if (参照.ContainsKey(he))
    			{
    				参照[he].Add(sep.Sta);
    			}
    			else
    			{
    				参照[he] = new List<Element> { sep.Sta };
    			}
    			sta.Add(sep);
    			ぶっかけ垂れ.Start();
    		}
    	}

    	public スタンプB(ModeEventDispatcher Med, RenderArea Are, Character Cha, Body Bod, ElementData ElementData, Motions Mots)
    		: base(Med, Are, Cha, Bod, ElementData)
    	{
    		Element e = null;
    		ぶっかけ垂れ = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate(Motion m)
    			{
    				e = sta.Last().Sta;
    				m.Max = RNG.XS.NextDouble();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				e.Yv = m.Value;
    			},
    			OnReach = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    			}
    		};
    		Mots.Add(ElementData.GetHashCode().ToString(), ぶっかけ垂れ);
    	}
    }
}
