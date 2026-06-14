namespace _2DGAMELIB
{
    public class MotionBase
    {
    	public double Value;

    	protected double min = -1.0;

    	protected double max = 1.0;

    	private double Frame;

    	private double FrameHalf;

    	private double MinFrameHalf;

    	public double BaseSpeed = 1.0;

    	public double GotoSpeed = 1.0;

    	public double RetuSpeed = 1.0;

    	public double Interval;

    	private long st;

    	public double LowestIncrease = 1.0;

    	private int s = 1;

    	private double d;

    	private double m;

    	public double Min
    	{
    		get
    		{
    			return min;
    		}
    		set
    		{
    			min = value;
    			SetFrame();
    		}
    	}

    	public double Max
    	{
    		get
    		{
    			return max;
    		}
    		set
    		{
    			max = value;
    			SetFrame();
    		}
    	}

    	public MotionBase(double Min, double Max)
    	{
    		min = Min;
    		max = Max;
    		SetFrame();
    		ResetValue();
    	}

    	private void SetFrame()
    	{
    		Frame = max - min;
    		FrameHalf = Frame * 0.5;
    		MinFrameHalf = Min + FrameHalf;
    	}

    	public void ResetValue()
    	{
    		Value = min;
    	}

    	private void Count(FpsCounter FPS)
    	{
    		m = Frame / FPS.Value;
    		Value += (m * d + m * LowestIncrease) * BaseSpeed * ((s > 0) ? GotoSpeed : RetuSpeed) * (double)s;
    	}

    	public void GetValue(FpsCounter FPS)
    	{
    		if (!((double)(FPS.sw.ElapsedMilliseconds - st) < Interval) && FPS.Value > 0.0)
    		{
    			d = (MinFrameHalf - Value) / FrameHalf;
    			d *= d.Sign();
    			d = d.Inverse();
    			Count(FPS);
    			if (Value >= max)
    			{
    				Value = max;
    				s = -s;
    			}
    			else if (Value <= min)
    			{
    				Value = min;
    				s = -s;
    				st = FPS.sw.ElapsedMilliseconds;
    			}
    		}
    	}
    }
}
