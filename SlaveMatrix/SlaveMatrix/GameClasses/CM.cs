using _2DGAMELIB;

namespace SlaveMatrix
{
    public class CM
    {
    	private TrainingUI 調教UI;

    	public Ele Ele;

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
    				Ele.SetHitFalse();
    			}
    			else
    			{
    				Ele.SetHitTrue();
    			}
    		}
    	}

    	public CM(ModeEventDispatcher Med, TrainingUI 調教UI, Ele Ele)
    	{
    		this.調教UI = 調教UI;
    		this.Ele = Ele;
    		foreach (Par item in Ele.Body.EnumAllPar())
    		{
    			item.HitColor = Med.GetUniqueColor();
    		}
    	}

    	public void Reset()
    	{
    		Ele.Xi = 0;
    		Ele.Yi = 0;
    		Ele.濃度 = 0.5;
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
    			Ele.Body.JoinPA();
    			Ele.色更新();
    			調教UI.持ち手下描画();
    			Ele.描画0(Are);
    		}
    	}

    	public void 描画1(RenderArea Are)
    	{
    		if (Show && Under && 描画Show)
    		{
    			Ele.描画1(Are);
    			調教UI.持ち手上描画();
    		}
    	}

    	public void 描画0s(RenderArea Are)
    	{
    		if (Show && Under && 描画Show)
    		{
    			Ele.Body.JoinPA();
    			Ele.色更新();
    			Ele.描画0(Are);
    		}
    	}

    	public void 描画1s(RenderArea Are)
    	{
    		if (Show && Under && 描画Show)
    		{
    			Ele.描画1(Are);
    		}
    	}

    	public void 待機描画(RenderArea Are)
    	{
    		if (Show && !Under && StaShow)
    		{
    			Ele.Body.JoinPA();
    			Ele.色更新();
    			Ele.描画0(Are);
    			Ele.描画1(Are);
    		}
    	}

    	public void Draw(RenderArea Are)
    	{
    		if (Show && !Under && DraShow)
    		{
    			調教UI.持ち手下描画();
    			Ele.Body.JoinPA();
    			Ele.色更新();
    			Ele.描画0(Are);
    			Ele.描画1(Are);
    			調教UI.持ち手上描画();
    		}
    	}

    	public void Draws(RenderArea Are)
    	{
    		if (Show && !Under && DraShow)
    		{
    			Ele.Body.JoinPA();
    			Ele.色更新();
    			Ele.描画0(Are);
    			Ele.描画1(Are);
    		}
    	}
    }
}
