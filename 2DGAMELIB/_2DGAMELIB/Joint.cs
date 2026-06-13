using System;

namespace _2DGAMELIB
{
    [Serializable]
    public class Joint
    {
    	public ShapePart Par0;

    	public int Index;

    	public ShapePart Par1;

    	public Joint(ShapePart Par0, int Index, ShapePart Par1)
    	{
    		this.Par0 = Par0;
    		this.Index = Index;
    		this.Par1 = Par1;
    	}

    	public void JoinP()
    	{
    		Par0.SetJointP(Index, Par1);
    	}

    	public void JoinPA()
    	{
    		Par0.SetJointPA(Index, Par1);
    	}
    }
}
