using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2DGAMELIB
{
    [Serializable]
    public class Pars
    {
    	private Pars parent;

    	public string Tag = "";

    	public OrderedDictionary<string, object> pars = new OrderedDictionary<string, object>();

    	public Pars Parent => parent;

    	public IEnumerable<object> Values => pars.Values;

        public void SetAngleBase(double value)
        {
            foreach (object value2 in pars.Values)
            {
                if (value2 is Pars)
                {
                    ((Pars)value2).SetAngleBase(value);
                }
                else if (value2 is Par)
                {
                    ((Par)value2).SetAngleBase(value);
                }
            }
        }

        public void SetSizeBase(double value)
        {
            foreach (object value2 in pars.Values)
            {
                if (value2 is Pars)
                {
                    ((Pars)value2).SetSizeBase(value);
                }
                else if (value2 is Par)
                {
                    ((Par)value2).SetSizeBase(value);
                }
            }
        }

        public void SetSizeYCont(double value)
        {
            foreach (object value2 in pars.Values)
            {
                if (value2 is Pars)
                {
                    ((Pars)value2).SetSizeYCont(value);
                }
                else if (value2 is Par)
                {
                    ((Par)value2).SetSizeYCont(value);
                }
            }
        }

        public object this[string Name]
    	{
    		get
    		{
    			return pars[Name];
    		}
    		set
    		{
    			pars[Name] = value;
    		}
    	}

    	public void SetParent(Pars Parent)
    	{
    		parent = Parent;
    	}

    	public int IndexOf(object obj)
    	{
    		return pars.IndexOf(obj);
    	}

    	public void Add(string Name, Par Par)
    	{
    		Par.SetParent(this);
    		pars.Add(Name, Par);
    	}

    	public void Add(string Name, ParT ParT)
    	{
    		ParT.SetParent(this);
    		pars.Add(Name, ParT);
    	}

    	public void Add(string Name, Pars Pars)
    	{
    		Pars.SetParent(this);
    		pars.Add(Name, Pars);
    	}

    	public void Add(Pars Pars)
    	{
    		Pars.SetParent(this);
    		pars.Add(Pars.Tag, Pars);
    	}

    	public void Remove(string Name)
    	{
    		object obj = pars[Name];
    		if (obj is Pars)
    		{
    			((Pars)obj).SetParent(null);
    		}
    		else if (obj is ParT)
    		{
    			((ParT)obj).SetParent(null);
    		}
    		else if (obj is Par)
    		{
    			((Par)obj).SetParent(null);
    		}
    		pars.Remove(Name);
    	}

    	public IEnumerable<Par> EnumAllPar()
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				foreach (Par item in ((Pars)value).EnumAllPar())
    				{
    					yield return item;
    				}
    			}
    			else if (value is Par)
    			{
    				yield return (Par)value;
    			}
    		}
    	}

    	public void SetDefault()
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				((Pars)value).SetDefault();
    			}
    			else if (value is ParT)
    			{
    				((ParT)value).SetDefault();
    			}
    			else if (value is Par)
    			{
    				((Par)value).SetDefault();
    			}
    		}
    	}

    	public Pars()
    	{
    	}

    	public Pars(ParT ParT)
    	{
    		Tag = ParT.Tag;
    		Add(ParT.Tag, ParT);
    	}

    	public Pars(Pars Pars)
    	{
    		Copy(Pars);
    	}

    	private void Copy(Pars Pars)
    	{
    		Tag = Pars.Tag;
    		foreach (string key in Pars.pars.Keys)
    		{
    			object obj = Pars.pars[key];
    			if (obj is Pars)
    			{
    				Add(key, ((Pars)obj).Clone());
    			}
    			else if (obj is ParT)
    			{
    				Add(key, new ParT((ParT)obj));
    			}
    			else if (obj is Par)
    			{
    				Add(key, new Par((Par)obj));
    			}
    		}
    	}

    	private Pars Clone()
    	{
    		Pars pars2 = new Pars();
    		pars2.Tag = Tag;
    		foreach (string key in pars.Keys)
    		{
    			object obj = pars[key];
    			if (obj is Pars)
    			{
    				pars2.Add(key, ((Pars)obj).Clone());
    			}
    			else if (obj is ParT)
    			{
    				pars2.Add(key, new ParT((ParT)obj));
    			}
    			else if (obj is Par)
    			{
    				pars2.Add(key, new Par((Par)obj));
    			}
    		}
    		return pars2;
    	}

    	public void Draw(double Unit, Graphics Graphics)
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				((Pars)value).Draw(Unit, Graphics);
    			}
    			else if (value is ParT)
    			{
    				((ParT)value).Draw(Unit, Graphics);
    			}
    			else if (value is Par)
    			{
    				((Par)value).Draw(Unit, Graphics);
    			}
    		}
    	}

    	public void DrawH(double Unit, Graphics Graphics)
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				((Pars)value).DrawH(Unit, Graphics);
    			}
    			else if (value is Par)
    			{
    				((Par)value).DrawH(Unit, Graphics);
    			}
    		}
    	}

    	public bool IsHit(ref Color HitColor)
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars && ((Pars)value).IsHit(ref HitColor))
    			{
    				return true;
    			}
    			if (value is Par && ((Par)value).GetHitColor() == HitColor)
    			{
    				return true;
    			}
    		}
    		return false;
    	}

    	public Par GetPar(List<int> Path)
    	{
    		return GetPar(0, Path);
    	}

    	private Par GetPar(int l, List<int> Path)
    	{
    		object obj = pars[Path[l]];
    		if (obj is Pars)
    		{
    			return ((Pars)obj).GetPar(l + 1, Path);
    		}
    		return (Par)obj;
    	}

    	public void ReverseX()
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				((Pars)value).ReverseX();
    			}
    			else if (value is Par)
    			{
    				((Par)value).ReverseX();
    			}
    		}
    	}

    	public void ReverseY()
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				((Pars)value).ReverseY();
    			}
    			else if (value is Par)
    			{
    				((Par)value).ReverseY();
    			}
    		}
    	}

    	public void Dispose()
    	{
    		foreach (object value in pars.Values)
    		{
    			if (value is Pars)
    			{
    				((Pars)value).Dispose();
    			}
    			else if (value is ParT)
    			{
    				((ParT)value).Dispose();
    			}
    			else if (value is Par)
    			{
    				((Par)value).Dispose();
    			}
    		}
    	}
    }
}
