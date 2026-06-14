using System;
using System.Drawing;

namespace _2DGAMELIB
{
    public class ButtonBase
    {
    	private bool dra = true;

    	private Color hc = Color.Transparent;

    	protected PartGroup partGroup;

    	protected Action<ButtonBase> Over = delegate
    	{
    	};

    	protected Action<ButtonBase> Push = delegate
    	{
    	};

    	protected Action<ButtonBase> Release = delegate
    	{
    	};

    	protected Action<ButtonBase> Out = delegate
    	{
    	};

    	public Action<ButtonBase> Action = delegate
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

    	public ButtonBase(ShapePartT ShapePartT, Action<ButtonBase> Action)
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
    			if (item.GetHitColor() != Color.Transparent)
    			{
    				Med.RemUniqueColor(item.GetHitColor());
    			}
    			item.SetHitColor(Med.GetUniqueColor());
    		}
    	}

    	public void Dispose()
    	{
		    partGroup.Dispose();
    	}
    }
}
