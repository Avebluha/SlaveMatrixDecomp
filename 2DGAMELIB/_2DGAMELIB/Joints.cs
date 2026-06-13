using System;
using System.Collections.Generic;

namespace _2DGAMELIB
{
    [Serializable]
    public class Joints
    {
    	public List<Joint> Joins = new List<Joint>();

    	public void JoinP()
    	{
    		foreach (Joint join in Joins)
    		{
    			join.JoinP();
    		}
    	}

    	public void JoinPA()
    	{
    		foreach (Joint join in Joins)
    		{
    			join.JoinPA();
    		}
    	}
    }
    [Serializable]
    public class JointS
    {
    	public Difs Difs;

    	public List<int> Path;

    	public int Index;

    	public JointS(Difs Difs, ShapePart ShapePart, int Index)
    	{
    		this.Difs = Difs;
    		Path = ShapePart.GetPath();
    		this.Index = Index;
    	}
    }
}
