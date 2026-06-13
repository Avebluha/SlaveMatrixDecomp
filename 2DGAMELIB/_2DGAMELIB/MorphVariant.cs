using System;
using System.Collections.Generic;
using System.Drawing;

namespace _2DGAMELIB
{
    [Serializable]
    public class MorphVariant
    {
    	public string Tag = "";

    	private List<PartGroup> parss = new List<PartGroup>();

    	public List<PartGroup> Parss => parss;

    	public int Count => parss.Count;

    	public PartGroup this[int Index]
    	{
    		get
    		{
    			return parss[Index];
    		}
    		set
    		{
    			parss[Index] = value;
    		}
    	}

    	public double PositionSize
    	{
    		set
    		{
    			foreach (PartGroup item in parss)
    			{
    				item.PositionSize = value;
    			}
    		}
    	}

    	public Vector2D PositionVector
    	{
    		set
    		{
    			foreach (PartGroup item in parss)
    			{
    				item.PositionVector = value;
    			}
    		}
    	}

    	public double AngleBase
    	{
    		set
    		{
    			foreach (PartGroup item in parss)
    			{
    				item.AngleBase = value;
    			}
    		}
    	}

    	public double AngleCont
    	{
    		set
    		{
    			foreach (PartGroup item in parss)
    			{
    				item.AngleCont = value;
    			}
    		}
    	}

    	public double SizeBase
    	{
    		set
    		{
    			foreach (PartGroup item in parss)
    			{
    				item.SizeBase = value;
    			}
    		}
    	}

    	public double SizeCont
    	{
    		set
    		{
    			foreach (PartGroup item in parss)
    			{
    				item.SizeCont = value;
    			}
    		}
    	}

    	public double SizeXBase
    	{
    		set
    		{
    			foreach (PartGroup item in parss)
    			{
    				item.SizeXBase = value;
    			}
    		}
    	}

    	public double SizeXCont
    	{
    		set
    		{
    			foreach (PartGroup item in parss)
    			{
    				item.SizeXCont = value;
    			}
    		}
    	}

    	public double SizeYBase
    	{
    		set
    		{
    			foreach (PartGroup item in parss)
    			{
    				item.SizeYBase = value;
    			}
    		}
    	}

    	public double SizeYCont
    	{
    		set
    		{
    			foreach (PartGroup item in parss)
    			{
    				item.SizeYCont = value;
    			}
    		}
    	}

    	public bool Dra
    	{
    		set
    		{
    			foreach (PartGroup item in parss)
    			{
    				item.Dra = value;
    			}
    		}
    	}

    	public bool Hit
    	{
    		set
    		{
    			foreach (PartGroup item in parss)
    			{
    				item.Hit = value;
    			}
    		}
    	}

    	public IEnumerable<ShapePart> EnumAllPar()
    	{
    		foreach (PartGroup item in parss)
    		{
    			foreach (ShapePart item2 in item.EnumAllPar())
    			{
    				yield return item2;
    			}
    		}
    	}

    	public void SetDefault()
    	{
    		foreach (PartGroup item in parss)
    		{
    			item.SetDefault();
    		}
    	}

    	public MorphVariant()
    	{
    	}

    	public MorphVariant(MorphVariant MorphVariant)
    	{
    		Copy(MorphVariant);
    	}

    	private void Copy(MorphVariant MorphVariant)
    	{
    		Tag = MorphVariant.Tag;
    		foreach (PartGroup item in MorphVariant.parss)
    		{
    			parss.Add(new PartGroup(item));
    		}
    	}

    	public void Add(PartGroup PartGroup)
    	{
    		parss.Add(PartGroup);
    	}

    	public List<string> GetHitTags(ref Color HitColor)
    	{
    		List<string> list = new List<string>();
    		foreach (PartGroup item in parss)
    		{
    			list.AddRange(item.GetHitTags(ref HitColor));
    		}
    		return list;
    	}

    	public List<ShapePart> GetHitPars(ref Color HitColor)
    	{
    		List<ShapePart> list = new List<ShapePart>();
    		foreach (PartGroup item in parss)
    		{
    			list.AddRange(item.GetHitPars(ref HitColor));
    		}
    		return list;
    	}

    	public bool IsHit(ref Color HitColor)
    	{
    		foreach (PartGroup item in parss)
    		{
    			if (item.IsHit(ref HitColor))
    			{
    				return true;
    			}
    		}
    		return false;
    	}

    	public void ReverseX()
    	{
    		foreach (PartGroup item in parss)
    		{
    			item.ReverseX();
    		}
    	}

    	public void ReverseY()
    	{
    		foreach (PartGroup item in parss)
    		{
    			item.ReverseY();
    		}
    	}

    	public void Dispose()
    	{
    		foreach (PartGroup item in parss)
    		{
    			item.Dispose();
    		}
    	}
    }
}
