using System;
using System.Diagnostics;

namespace _2DGAMELIB
{
    public class FpsCounter
    {
    	public Stopwatch sw = new Stopwatch();

    	private long last_frame;
    	public double Value;

    	private double ticks_per_frame;
    	public FpsCounter(double FPS)
    	{
    		Value = FPS;
    		ticks_per_frame = (double)Stopwatch.Frequency / FPS;
    		sw.Start();
    		last_frame = sw.ElapsedTicks;
    	}

    	public void FPSFixed(Action Action)
    	{
    		long current_time = sw.ElapsedTicks;

    		if (current_time - last_frame >= ticks_per_frame)
    		{
    			Action();

                Value = (9 * Value + ((double)Stopwatch.Frequency / (sw.ElapsedTicks - last_frame)))/10;

                last_frame = current_time;
    		}

    	}
    }
}
