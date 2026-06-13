using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class ElementInstance : IDisposable
    {
    	public Vector2D Position = DataConsts.Vec2DZero;

    	public Vector2D PositionCont = DataConsts.Vec2DZero;

    	public RenderArea Lay;

    	public bool Updatef = true;

    	public Action<RenderArea> 描画処理;

    	public HashSet<Element> ElesH;


    	public void AddRange(IEnumerable<Element> es)
    	{
    		foreach (Element e in es)
    		{
    			ElesH.Add(e);
    		}
    	}

    	public bool IsUpdate(Element e)
    	{
    		if (Updatef)
    		{
    			return ElesH.Contains(e);
    		}
    		return false;
    	}

    	public ElementInstance(ModeEventDispatcher Med)
    	{
    		Lay = new RenderArea(Med.Unit, Med.Base.XRatio, Med.Base.YRatio, Med.Base.Size + 0.0025, Med.DisQuality, Med.HitAccuracy);
    		ElesH = new HashSet<Element>();
    	}

    	public void 描画(RenderArea Are)
    	{
    		VectorMath.Add(ref Position, ref PositionCont, out Lay.Position);
    		Are.Draw(Lay);
    	}

    	public void Update()
    	{
    		if (Updatef)
    		{
    			Lay.Clear();
    			描画処理(Lay);
    			Updatef = false;
    		}
    	}

    	public void Dispose()
    	{
    		Lay.Dispose();
    	}

    	public bool IsHeavy()
    	{
    		if (!ElesH.IsEle<触手>())
    		{
    			return ElesH.IsEle<尾>();
    		}
    		return true;
    	}
    }
}
