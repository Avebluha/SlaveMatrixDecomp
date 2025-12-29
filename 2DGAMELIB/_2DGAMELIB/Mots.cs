using System.Collections.Generic;

namespace _2DGAMELIB
{
    public class Mots
    {
    	public Dictionary<string, Mot> ms;

    	public Mot this[string Name]
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

    	public Mots()
    	{
    		ms = new Dictionary<string, Mot>();
    	}

    	public void Add(string Name, Mot Mot)
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
    		foreach (Mot value in ms.Values)
    		{
    			value.GetValue(FPS);
    		}
    	}
    }
}
