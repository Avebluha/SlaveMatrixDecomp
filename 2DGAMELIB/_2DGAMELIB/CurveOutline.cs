using System;
using System.Collections.Generic;

namespace _2DGAMELIB
{

    //outline/path/line basically represents a curve :3
    [Serializable]
    public class CurveOutline
    {
    	public List<Vector2D> ps = new List<Vector2D>();

    	public float Tension = 0.5f;
        public bool Outline = true;

    	public CurveOutline()
    	{
    	}

    	public CurveOutline(CurveOutline CurveOutline)
    	{
    		ps = new List<Vector2D>(CurveOutline.ps);
    		Tension = CurveOutline.Tension;
    		Outline = CurveOutline.Outline;
    	}
    }
}
