using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;

namespace _2DGAMELIB
{
    [Serializable]
    public class Obj
    {
    	public OrderedDictionary<string, Difs> Difss = new OrderedDictionary<string, Difs>();

    	private Difs r;

    	private JointsD jsd;

    	public IEnumerable<string> Keys => Difss.Keys;

    	public Difs this[string Name]
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

    	public double AngleBase
    	{
    		set
    		{
    			foreach (Difs value2 in Difss.Values)
    			{
    				value2.SetAngleBase(value);
    			}
    		}
    	}

    	public double SizeBase
    	{
    		set
    		{
    			foreach (Difs value2 in Difss.Values)
    			{
    				value2.SetSizeBase(value);
    			}
    		}
    	}

    	public Difs JoinRoot => r;
    	public IEnumerable<Par> EnumAllPar()
    	{
    		foreach (Difs value in Difss.Values)
    		{
    			foreach (Par item in value.EnumAllPar())
    			{
    				yield return item;
    			}
    		}
    	}

    	public Obj SetDefaultR()
    	{
    		foreach (Difs value in Difss.Values)
    		{
    			value.SetDefault();
    		}
    		return this;
    	}

    	public Obj()
    	{
    	}



    	public void Draw(RenderArea Are)
    	{
    		foreach (Difs value in Difss.Values)
    		{
    			value.Draw(Are);
    		}
    	}


    	private Difs GetJoinRootDifs()
    	{
    		Difs[] array = Difss.Values.ToArray();
    		if (array.Length <= 1)
    		{
    			return array.FirstOrDefault();
    		}
    		Par[] pa = EnumAllPar().ToArray();
    		Difs[] array2 = array;
    		Vector2D p;
    		foreach (Difs difs in array2)
    		{
    			if (difs.EnumJoinRoot.All(delegate(Par p0)
    			{
    				p = p0.GetPosition();
    				return pa.All((Par p1) => p0 == p1 || p1.GetJP().All((Joi j) => !(p1.ToGlobal(j.Joint).DistanceSquared(p) <= Join.IdentityDistance)));
    			}))
    			{
    				return difs;
    			}
    		}
    		return array.First();
    	}

    	public void SetJoints()
    	{
    		Difs[] array = Difss.Values.ToArray();
    		Difs[] array2 = array;
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
    		foreach (Difs value in Difss.Values)
    		{
    			value.Dispose();
    		}
    	}
    }
}
