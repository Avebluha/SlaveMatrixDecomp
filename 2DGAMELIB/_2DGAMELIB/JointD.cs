using System;
using System.Collections.Generic;

namespace _2DGAMELIB
{
    [Serializable]
    public class JointD
    {
    	public VariantGrid Difs0;

    	public List<int> Path0;

    	public int Index;

    	public VariantGrid Difs1;

    	public JointD(VariantGrid Difs0, ShapePart Par0, int Index, VariantGrid Difs1)
    	{
    		this.Difs0 = Difs0;
    		Path0 = Par0.GetPath();
    		this.Index = Index;
    		this.Difs1 = Difs1;
    	}

    	public JointD(VariantGrid Difs1)
    	{
    		this.Difs1 = Difs1;
    	}

    	public void JoinP()
    	{
    		Difs0.GetCurrent().GetPar(Path0).SetJointP(Index, Difs1.GetCurJoinRoot());
    		Difs1.JoinPA();
    	}

    	public void JoinPA()
    	{
    		Difs0.GetCurrent().GetPar(Path0).SetJointPA(Index, Difs1.GetCurJoinRoot());
    		Difs1.JoinPA();
    	}

    	public void Set(JointS 接続元)
    	{
    		Difs0 = 接続元.VariantGrid;
    		Path0 = 接続元.Path;
    		Index = 接続元.Index;
    	}
    }
}
