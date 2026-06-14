using System;

namespace _2DGAMELIB
{
    public class Motion : MotionBase
    {
    	public Action<Motion> OnStart;

    	public Action<Motion> OnUpdate;

    	public Action<Motion> OnReach;

    	public Action<Motion> OnLoop;

    	public Action<Motion> OnEnd;

    	private bool run; //OnUpdate

    	private bool rou; //OnLoop

    	public bool Run => run;

    	public Motion(double Min, double Max)
    		: base(Min, Max)
    	{
    	}

    	public new void GetValue(FpsCounter FPS)
    	{
    		if (!run)
    		{
    			return;
    		}
    		base.GetValue(FPS);
    		if (OnUpdate != null)
    		{
    			OnUpdate(this);
    		}
    		if (Value == min)
    		{
    			if (rou && OnLoop != null)
    			{
    				OnLoop(this);
    			}
    			rou = false;
    		}
    		else if (Value == max)
    		{
    			if (OnReach != null)
    			{
    				OnReach(this);
    			}
    			rou = true;
    		}
    	}

    	public void Start()
    	{
    		if (OnStart != null)
    		{
    			OnStart(this);
    		}
    		run = true;
    	}

    	public void End()
    	{
    		run = false;
    		if (OnEnd != null)
    		{
    			OnEnd(this);
    		}
    		ResetValue();
    		rou = false;
    	}
    }
}
