using System.Collections.Generic;
using System.Drawing;

namespace _2DGAMELIB
{
    public class Labs
    {
    	private OrderedDictionary<string, Lab> labs = new OrderedDictionary<string, Lab>();

    	private Med Med;

    	private Are Are;

    	public Lab this[string Name] => labs[Name];

    	public Labs(Med Med, Are Are)
    	{
    		this.Med = Med;
    		this.Are = Are;
    	}

    	public void Add(string Name, Vector2D Position, double Size, double Width, Font Font, double TextSize, string Text, Color TextColor, Color ShadColor, Color BackColor, Color FramColor, bool Input)
    	{
    		labs.Add(Name, new Lab(Are, Name, ref Position, Size, Width, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor, ref FramColor));
    	}

    	public void Draw(Are Are)
    	{
    		foreach (Lab value in labs.Values)
    		{
    			Are.Draw(value.ParT);
    		}
    	}

    	public void Dispose()
    	{
    		foreach (Lab value in labs.Values)
    		{
    			value.Dispose();
    		}
    	}
    }
}
