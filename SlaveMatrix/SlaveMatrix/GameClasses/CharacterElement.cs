using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class CharacterElement
    {
    	private TrainingUI 調教UI;

    	public Element Element;

    	private UsageStatus v;

    	public bool Under;

    	public bool 描画Show = true;

    	public bool StaShow = true;

    	public bool DraShow = true;

    	public bool Show = true;

    	public Vector2D bp;

    	public UsageStatus 使用状態
    	{
    		get
    		{
    			return v;
    		}
    		set
    		{
    			v = value;
    			if (v == UsageStatus.InUse)
    			{
    				Element.SetHitFalse();
    			}
    			else
    			{
    				Element.SetHitTrue();
    			}
    		}
    	}

    	public CharacterElement(ModeEventDispatcher Med, TrainingUI 調教UI, Element Element)
    	{
    		this.調教UI = 調教UI;
    		this.Element = Element;
    		foreach (ShapePart item in Element.Body.EnumAllPar())
    		{
    			item.SetHitColor(Med.GetUniqueColor());
    		}
    	}

    	public void Reset()
    	{
    		Element.Xi = 0;
    		Element.Yi = 0;
    		Element.Intensity = 0.5;
    		使用状態 = UsageStatus.Standby;
    		Under = false;
    		描画Show = true;
    		StaShow = true;
    		DraShow = true;
    		Show = true;
    		bp = default(Vector2D);
    	}

    	public void 描画0(RenderArea Are)
    	{
    		if (Show && Under && 描画Show)
    		{
    			Element.Body.JoinPA();
    			Element.色更新();
    			調教UI.持ち手下描画();
    			Element.描画0(Are);
    		}
    	}

    	public void 描画1(RenderArea Are)
    	{
    		if (Show && Under && 描画Show)
    		{
    			Element.描画1(Are);
    			調教UI.持ち手上描画();
    		}
    	}

    	public void 描画0s(RenderArea Are)
    	{
    		if (Show && Under && 描画Show)
    		{
    			Element.Body.JoinPA();
    			Element.色更新();
    			Element.描画0(Are);
    		}
    	}

    	public void 描画1s(RenderArea Are)
    	{
    		if (Show && Under && 描画Show)
    		{
    			Element.描画1(Are);
    		}
    	}

    	public void 待機描画(RenderArea Are)
    	{
    		if (Show && !Under && StaShow)
    		{
    			Element.Body.JoinPA();
    			Element.色更新();
    			Element.描画0(Are);
    			Element.描画1(Are);
    		}
    	}

    	public void Draw(RenderArea Are)
    	{
    		if (Show && !Under && DraShow)
    		{
    			調教UI.持ち手下描画();
    			Element.Body.JoinPA();
    			Element.色更新();
    			Element.描画0(Are);
    			Element.描画1(Are);
    			調教UI.持ち手上描画();
    		}
    	}

    	public void Draws(RenderArea Are)
    	{
    		if (Show && !Under && DraShow)
    		{
    			Element.Body.JoinPA();
    			Element.色更新();
    			Element.描画0(Are);
    			Element.描画1(Are);
    		}
    	}
    }
}
