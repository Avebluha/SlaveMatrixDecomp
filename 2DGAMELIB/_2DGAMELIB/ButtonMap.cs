using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _2DGAMELIB
{
    public class ButtonMap
    {
    	private OrderedDictionary<string, ButtonBase> buts = new OrderedDictionary<string, ButtonBase>();

    	public ButtonBase this[string Name] => buts[Name];

    	public IEnumerable<ButtonBase> EnumBut => buts.Values;

    	public void Add(string Name, ButtonBase ButtonBase)
    	{
    		buts.Add(Name, ButtonBase);
    	}

    	public void Down(ref Color HitColor)
    	{
    		using IEnumerator<ButtonBase> enumerator = buts.Values.GetEnumerator();
    		while (enumerator.MoveNext() && !enumerator.Current.Down(ref HitColor))
    		{
    		}
    	}

    	public void Up(ref Color HitColor)
    	{
    		using IEnumerator<ButtonBase> enumerator = buts.Values.GetEnumerator();
    		while (enumerator.MoveNext() && !enumerator.Current.Up(ref HitColor))
    		{
    		}
    	}

    	public void Move(ref Color HitColor)
    	{
    		foreach (ButtonBase value in buts.Values)
    		{
    			value.Move(ref HitColor);
    		}
    	}

    	public void Leave()
    	{
    		using IEnumerator<ButtonBase> enumerator = buts.Values.GetEnumerator();
    		while (enumerator.MoveNext() && !enumerator.Current.Leave())
    		{
    		}
    	}

    	public void SetHitColor(ModeEventDispatcher Med)
    	{
    		foreach (ButtonBase item in EnumBut)
    		{
    			item.SetHitColor(Med);
    		}
    	}

    	public void Draw(RenderArea Are)
    	{
    		foreach (ButtonBase value in buts.Values)
    		{
    			value.Draw(Are);
    		}
    	}

    	public void Dispose()
    	{
    		foreach (ButtonBase value in buts.Values)
    		{
    			value.Dispose();
    		}
    	}
    }
}
