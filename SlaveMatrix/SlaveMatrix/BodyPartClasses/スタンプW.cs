using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class スタンプW : Stamp
    {
    	private Element Par;

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
    				p = stum.Element.Body.Current.GetPar(stum.Path);
    				stum.Sta.角度B = p.AngleBase - stum.ShapePart.AngleBase;
    				stum.Sta.位置B = p.ToGlobal(stum.Pos);
    				stum.Sta.色更新();
    				stum.Sta.Body.Draw(Are);
    			}
    		}
    		catch
    		{
    		}
    	}

    	public bool Add(Vector2D cp, Color hc, Element he)
    	{
    		if (チェック2(he) && he == Par)
    		{
    			p = he.Body.GetHitPar_(hc);
    			c2 = he.GetParOfColorP(p).ColorD.色;
    			if (c2.Col1 == Cha.ColorSet.人肌O.Col1 || c2.Col2 == Cha.ColorSet.人肌O.Col1)
    			{
    				if (sta.Count >= 33)
    				{
    					sep = sta[0];
    					sta.RemoveAt(0);
    					sep.Sta.Dispose();
    				}
    				sep = default(sep);
    				sep.Sta = ElementData.GetEle(Are.DisplayUnitScale, Med, Cha.ColorSet);
    				sep.Sta.SetHitFalse();
    				sep.Sta.角度C = 45.0 * (double)(Rng.XS.NextBool() ? 1 : (-1)) * Rng.XS.NextDouble();
    				sep.Element = he;
    				sep.ShapePart = p;
    				sep.Path = sep.ShapePart.GetPath();
    				sep.Pos = sep.ShapePart.ToLocal(cp + (he.位置 - cp).newNormalize() * 0.01);
    				sta.Add(sep);
    			}
    			return true;
    		}
    		return false;
    	}

    	public スタンプW(ModeEventDispatcher Med, RenderArea Are, Character Cha, Body Bod, ElementData ElementData, Element Par)
    		: base(Med, Are, Cha, Bod, ElementData)
    	{
    		this.Par = Par;
    		ElementData.尺度B = 0.9;
    	}
    }
}
