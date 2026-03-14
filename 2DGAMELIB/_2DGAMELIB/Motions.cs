using System.Collections.Generic;

namespace _2DGAMELIB
{
    public class Motions
    {
    	public Dictionary<string, Motion> ms;

    	public Motion this[string Name]
    	{
    		get
    		{
    			return ms[Name];
    		}
    		set
    		{
    			ms[Name] = value;
    		}
    	}

    	public Motions()
    	{
    		ms = new Dictionary<string, Motion>();
    	}

    	public void Add(string Name, Motion Mot)
    	{
            //Broke some times here when adding existing keys
            //ms.Add(Name, Mot);
            ms.TryAdd(Name, Mot);
        }

    	public void Rem(string Name)
    	{
    		ms.Remove(Name);
    	}

    	public void Drive(FPS FPS)
    	{
    		foreach (Motion value in ms.Values)
    		{
    			value.GetValue(FPS);
    		}
    	}
    }
}
