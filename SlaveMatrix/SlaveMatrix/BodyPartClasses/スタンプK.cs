using System.Drawing;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class スタンプK : Stamp
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
    				p = stum.Element.Body.GetCurrent().GetPar(stum.Path);
    				stum.Sta.角度B = p.GetAngleBase() - stum.ShapePart.GetAngleBase();
    				stum.Sta.位置B = p.ToGlobal(stum.Pos);
    				stum.Sta.色更新();
    				stum.Sta.Body.Draw(Are);
    			}
    		}
    		catch
    		{
    		}
    	}

    	public キスマーク Add(Vector2D cp, Color hc, Element he)
    	{
    		if (チェック1(he) && he == Par)
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
    				sep.Element = he;
    				sep.ShapePart = p;
    				sep.Path = sep.ShapePart.GetPath();
    				sep.Pos = sep.ShapePart.ToLocal(cp);
    				sta.Add(sep);
    			}
    			return (キスマーク)sep.Sta;
    		}
    		return null;
    	}

    	public スタンプK(ModeEventDispatcher Med, RenderArea Are, Character Cha, Body Bod, ElementData ElementData, Element Par)
    		: base(Med, Are, Cha, Bod, ElementData)
    	{
    		this.Par = Par;
    	}
    }
}
