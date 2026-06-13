using System;
using System.Collections.Generic;
using System.Drawing;

namespace _2DGAMELIB
{
    [Serializable]
    public class Dif
    {
    	public string Tag = "";

    	private List<Pars> parss = new List<Pars>();

    	public List<Pars> Parss => parss;

    	public int Count => parss.Count;

    	public Pars this[int Index]
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

        public void SetAngleBase(double value)
        {
            foreach (Pars item in parss)
            {
                item.SetAngleBase(value);
            }
        }

        public void SetSizeBase(double value)
        {
            foreach (Pars item in parss)
            {
                item.SetSizeBase(value);
            }
        }

        public void SetSizeYCont(double value)
        {
            foreach (Pars item in parss)
            {
                item.SetSizeYCont(value);
            }
        }

        public IEnumerable<Par> EnumAllPar()
    	{
    		foreach (Pars item in parss)
    		{
    			foreach (Par item2 in item.EnumAllPar())
    			{
    				yield return item2;
    			}
    		}
    	}

    	public void SetDefault()
    	{
    		foreach (Pars item in parss)
    		{
    			item.SetDefault();
    		}
    	}

    	public Dif()
    	{
    	}

    	public Dif(Dif Dif)
    	{
    		Copy(Dif);
    	}

    	private void Copy(Dif Dif)
    	{
    		Tag = Dif.Tag;
    		foreach (Pars item in Dif.parss)
    		{
    			parss.Add(new Pars(item));
    		}
    	}

    	public void Add(Pars Pars)
    	{
    		parss.Add(Pars);
    	}

    	public bool IsHit(ref Color HitColor)
    	{
    		foreach (Pars item in parss)
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
    		foreach (Pars item in parss)
    		{
    			item.ReverseX();
    		}
    	}

    	public void ReverseY()
    	{
    		foreach (Pars item in parss)
    		{
    			item.ReverseY();
    		}
    	}

    	public void Dispose()
    	{
    		foreach (Pars item in parss)
    		{
    			item.Dispose();
    		}
    	}
    }
}
