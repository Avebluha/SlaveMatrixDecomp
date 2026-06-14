using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;

namespace _2DGAMELIB
{
    [Serializable]
    public class BodyTemplate
    {
    	public OrderedDictionary<string, VariantGrid> Difss = new OrderedDictionary<string, VariantGrid>();

    	private VariantGrid r;

    	private JointsD jsd;

    	public IEnumerable<string> Keys => Difss.Keys;

    	public VariantGrid this[string Name]
    	{
    		get
    		{
    			return Difss[Name];
    		}
    		set
    		{
    			Difss[Name] = value;
    		}
    	}

    	public VariantGrid this[int Index]
    	{
    		get
    		{
    			return Difss[Index];
    		}
    		set
    		{
    			Difss[Index] = value;
    		}
    	}

    	public double AngleBase
    	{
    		set
    		{
    			foreach (VariantGrid value2 in Difss.Values)
    			{
    				value2.SetAngleBase(value);
    			}
    		}
    	}

    	public double SizeBase
    	{
    		set
    		{
    			foreach (VariantGrid value2 in Difss.Values)
    			{
    				value2.SetSizeBase(value);
    			}
    		}
    	}

    	public VariantGrid JoinRoot => r;
    	public IEnumerable<ShapePart> EnumAllPar()
    	{
    		foreach (VariantGrid value in Difss.Values)
    		{
    			foreach (ShapePart item in value.EnumAllPar())
    			{
    				yield return item;
    			}
    		}
    	}

    	public BodyTemplate SetDefaultR()
    	{
    		foreach (VariantGrid value in Difss.Values)
    		{
    			value.SetDefault();
    		}
    		return this;
    	}

    	public BodyTemplate()
    	{
    	}



    	public void Draw(RenderArea Are)
    	{
    		foreach (VariantGrid value in Difss.Values)
    		{
    			value.Draw(Are);
    		}
    	}


    	private VariantGrid GetJoinRootDifs()
    	{
    		VariantGrid[] array = Difss.Values.ToArray();
    		if (array.Length <= 1)
    		{
    			return array.FirstOrDefault();
    		}
    		ShapePart[] pa = EnumAllPar().ToArray();
    		VariantGrid[] array2 = array;
    		Vector2D p;
    		foreach (VariantGrid difs in array2)
    		{
    			if (difs.EnumJoinRoot.All(delegate(ShapePart p0)
    			{
    				p = p0.GetPosition();
    				return pa.All((ShapePart p1) => p0 == p1 || p1.GetJP().All((JointPoint j) => !(p1.ToGlobal(j.Joint).DistanceSquared(p) <= JointLink.IdentityDistance)));
    			}))
    			{
    				return difs;
    			}
    		}
    		return array.First();
    	}

    	public void SetJoints()
    	{
    		VariantGrid[] array = Difss.Values.ToArray();
    		VariantGrid[] array2 = array;
    		for (int i = 0; i < array2.Length; i++)
    		{
    			array2[i].SetJoints();
    		}
    		r = GetJoinRootDifs();
    		if (r != null)
    		{
    			jsd = r.GetJointsD(array);
    		}
    	}


    	public void JoinPA()
    	{
    		if (r != null)
    		{
    			r.JoinPA();
    			jsd.JoinPA();
    		}
    	}

 
    	public void Dispose()
    	{
    		foreach (VariantGrid value in Difss.Values)
    		{
    			value.Dispose();
    		}
    	}
    }
}
