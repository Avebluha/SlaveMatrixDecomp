using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;

namespace _2DGAMELIB
{
    [Serializable]
    public class Difs
    {
    	public string Tag = "";

    	public double ValueX;

    	public double ValueY;

    	private List<Dif> difs = new List<Dif>();

    	public Dictionary<Pars, Joints> pj;

    	public Dictionary<Pars, Par> pr;

        public int GetCountX()
        {
            return difs.Count;
        }

        public int GetCountY()
        {
            if (difs.Count > 0)
            {
                return difs[GetIndexX()].Count;
            }
            return 0;
        }

        public int GetIndexX()
        {
            if (!(ValueX >= 1.0))
            {
                return (int)((double)GetCountX() * ValueX);
            }
            return GetCountX() - 1;
        }

        public void SetIndexX(int value)
        {
            ValueX = (double)value / (double)GetCountX();
        }

        public int GetIndexY()
        {
            if (!(ValueY >= 1.0))
            {
                return (int)((double)GetCountY() * ValueY);
            }
            return GetCountY() - 1;
        }

        public void SetIndexY(int value)
        {
            ValueY = (double)value / (double)GetCountY();
        }

        public Dif this[int Index]
    	{
    		get
    		{
    			return difs[Index];
    		}
    		set
    		{
    			difs[Index] = value;
    		}
    	}

        public Pars GetCurrent()
        {
            return difs[GetIndexX()][GetIndexY()];
        }

        public void SetAngleBase(double value)
        {
            foreach (Dif dif in difs)
            {
                dif.SetAngleBase(value);
            }
        }

        public void SetSizeBase(double value)
        {
            foreach (Dif dif in difs)
            {
                dif.SetSizeBase(value);
            }
        }

        public void SetSizeYCont(double value)
        {
            foreach (Dif dif in difs)
            {
                dif.SetSizeYCont(value);
            }
        }

        public Par GetCurJoinRoot()
        {
            Pars current = GetCurrent();
            if (pr.ContainsKey(current))
            {
                return pr[current];
            }
            return null;
        }

        [JsonIgnore]
    	public IEnumerable<Par> EnumJoinRoot => pr.Values;
    	public IEnumerable<Par> EnumAllPar()
    	{
    		foreach (Dif dif in difs)
    		{
    			foreach (Par item in dif.EnumAllPar())
    			{
    				yield return item;
    			}
    		}
    	}

    	public IEnumerable<Pars> EnumAllPars()
    	{
    		foreach (Dif dif in difs)
    		{
    			foreach (Pars item in dif.Parss)
    			{
    				yield return item;
    			}
    		}
    	}

    	public void SetDefault()
    	{
    		foreach (Dif dif in difs)
    		{
    			dif.SetDefault();
    		}
    	}

    	public Difs()
    	{
    	}

    	public Difs(Difs Difs)
    	{
    		Copy(Difs);
    	}

    	private void Copy(Difs Difs)
    	{
    		Tag = Difs.Tag;
    		ValueX = Difs.ValueX;
    		ValueY = Difs.ValueY;
    		foreach (Dif dif in Difs.difs)
    		{
    			difs.Add(new Dif(dif));
    		}
    	}

    	public void Add(Dif Dif)
    	{
    		difs.Add(Dif);
    	}


    	public void Draw(RenderArea Are)
    	{
    		Are.Draw(GetCurrent());
    	}
    	public void Draw(AreM AreM)
    	{
    		AreM.Draw(GetCurrent());
    	}

    	private Par GetJoinRoot(Pars ps)
    	{
    		Par[] array = ps.EnumAllPar().ToArray();
    		if (array.Length <= 1)
    		{
    			return array.FirstOrDefault();
    		}
    		Par[] array2 = array;
    		foreach (Par p0 in array2)
    		{
    			Vector2D p = p0.GetPosition();
    			if (array.All((Par p1) => p0 == p1 || p1.GetJP().All((Joi j) => !(p1.ToGlobal(j.Joint).DistanceSquared(p) <= Join.IdentityDistance))))
    			{
    				return p0;
    			}
    		}
    		Par par = array.FirstOrDefault((Par e) => e.GetJP().Count > 0);
    		if (par != null)
    		{
    			return par;
    		}
    		return array.First();
    	}

    	public void SetJoints()
    	{
    		pj = new Dictionary<Pars, Joints>();
    		pr = new Dictionary<Pars, Par>();
    		foreach (Pars item in EnumAllPars())
    		{
    			Par joinRoot = GetJoinRoot(item);
    			if (joinRoot != null)
    			{
    				pj.Add(item, joinRoot.GetJoints(item.EnumAllPar()));
    				pr.Add(item, joinRoot);
    			}
    		}
    	}

    	public void JoinP()
    	{
    		pj[GetCurrent()].JoinP();
    	}

    	public void JoinPA()
    	{
    		pj[GetCurrent()].JoinPA();
    	}

    	public void JoinPAall()
    	{
    		foreach (Joints value in pj.Values)
    		{
    			value.JoinPA();
    		}
    	}

    	public Par GetHitPar_(Color HitColor)
    	{
    		return difs.FirstOrDefault((Dif d) => d.IsHit(ref HitColor)).Parss.FirstOrDefault((Pars ps) => ps.IsHit(ref HitColor)).EnumAllPar().FirstOrDefault((Par e) => e.GetHitColor() == HitColor);
    	}

    	public bool IsHit(ref Color HitColor)
    	{
    		foreach (Dif dif in difs)
    		{
    			if (dif.IsHit(ref HitColor))
    			{
    				return true;
    			}
    		}
    		return false;
    	}

    	public void ReverseX()
    	{
    		SetJoints();
    		foreach (Dif dif in difs)
    		{
    			dif.ReverseX();
    		}
    		JoinP();
    	}

    	public void ReverseY()
    	{
    		SetJoints();
    		foreach (Dif dif in difs)
    		{
    			dif.ReverseY();
    		}
    		JoinP();
    	}

    	public void Dispose()
    	{
    		foreach (Dif dif in difs)
    		{
    			dif.Dispose();
    		}
    	}
    }
}
