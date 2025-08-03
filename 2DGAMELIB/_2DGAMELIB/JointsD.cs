using System;
using System.Collections.Generic;

namespace _2DGAMELIB
{
    [Serializable]
    public class JointsD
    {
    	public List<JointD> Joins = new List<JointD>();

    	public void JoinPA()
    	{
    		foreach (JointD join in Joins)
    		{
    			join.JoinPA();
    		}
    	}

    }
}
