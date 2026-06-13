using System;
using System.Drawing;

namespace _2DGAMELIB
{
    public class But
    {
    	private bool dra = true;

    	private Color hc = Color.Transparent;

    	protected PartGroup partGroup;

    	protected Action<But> Over = delegate
    	{
    	};

    	protected Action<But> Push = delegate
    	{
    	};

    	protected Action<But> Release = delegate
    	{
    	};

    	protected Action<But> Out = delegate
    	{
    	};

    	public Action<But> Action = delegate
    	{
    	};

    	private bool f1;

    	private bool f2;

    	public bool Dra
    	{
    		get
    		{
    			return dra;
    		}
    		set
    		{
    			Move(ref hc);
    			dra = value;
    		}
    	}

    	public PartGroup PartGroup => partGroup;

    	public But(ShapePartT ShapePartT, Action<But> Action)
    	{
		    partGroup = new PartGroup(ShapePartT);
    		this.Action = Action;
    	}

    	public bool Move(ref Color HitColor)
    	{
    		if (Dra && !f2 && partGroup.IsHit(ref HitColor))
    		{
    			f2 = true;
    			Over(this);
    			return true;
    		}
    		if (Dra && f2 && !partGroup.IsHit(ref HitColor))
    		{
    			f1 = false;
    			f2 = false;
    			Out(this);
    			return true;
    		}
    		return false;
    	}

    	public bool Leave()
    	{
    		if (Dra && f2)
    		{
    			f1 = false;
    			f2 = false;
    			Out(this);
    			return true;
    		}
    		return false;
    	}

    	public bool Down(ref Color HitColor)
    	{
    		if (Dra && !f1 && partGroup.IsHit(ref HitColor))
    		{
    			f1 = true;
    			Push(this);
    			return true;
    		}
    		return false;
    	}

    	public bool Up(ref Color HitColor)
    	{
    		if (Dra && f1 && partGroup.IsHit(ref HitColor))
    		{
    			f1 = false;
    			Release(this);
    			Action(this);
    			return true;
    		}
    		return false;
    	}

    	public void Draw(RenderArea Are)
    	{
    		if (dra)
    		{
    			Are.Draw(partGroup);
    		}
    	}

    	public void SetHitColor(ModeEventDispatcher Med)
    	{
    		foreach (ShapePart item in partGroup.EnumAllPar())
    		{
    			if (item.HitColor != Color.Transparent)
    			{
    				Med.RemUniqueColor(item.HitColor);
    			}
    			item.HitColor = Med.GetUniqueColor();
    		}
    	}

    	public void Dispose()
    	{
		    partGroup.Dispose();
    	}
    }
}
