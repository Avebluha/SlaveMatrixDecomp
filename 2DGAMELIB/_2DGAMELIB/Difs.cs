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

    	public List<Dif> Difss => difs;

    	public int CountX => difs.Count;

    	public int CountY
    	{
    		get
    		{
    			if (difs.Count > 0)
    			{
    				return difs[IndexX].Count;
    			}
    			return 0;
    		}
    	}

    	public int IndexX
    	{
    		get
    		{
    			if (!(ValueX >= 1.0))
    			{
    				return (int)((double)CountX * ValueX);
    			}
    			return CountX - 1;
    		}
    		set
    		{
    			ValueX = (double)value / (double)CountX;
    		}
    	}

    	public int IndexY
    	{
    		get
    		{
    			if (!(ValueY >= 1.0))
    			{
    				return (int)((double)CountY * ValueY);
    			}
    			return CountY - 1;
    		}
    		set
    		{
    			ValueY = (double)value / (double)CountY;
    		}
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

    	public Pars Current => difs[IndexX][IndexY];

    	public double PositionSize
    	{
    		set
    		{
    			foreach (Dif dif in difs)
    			{
    				dif.PositionSize = value;
    			}
    		}
    	}

    	public Vector2D PositionVector
    	{
    		set
    		{
    			foreach (Dif dif in difs)
    			{
    				dif.PositionVector = value;
    			}
    		}
    	}

    	public double AngleBase
    	{
    		set
    		{
    			foreach (Dif dif in difs)
    			{
    				dif.AngleBase = value;
    			}
    		}
    	}

    	public double AngleCont
    	{
    		set
    		{
    			foreach (Dif dif in difs)
    			{
    				dif.AngleCont = value;
    			}
    		}
    	}

    	public double SizeBase
    	{
    		set
    		{
    			foreach (Dif dif in difs)
    			{
    				dif.SizeBase = value;
    			}
    		}
    	}

    	public double SizeCont
    	{
    		set
    		{
    			foreach (Dif dif in difs)
    			{
    				dif.SizeCont = value;
    			}
    		}
    	}

    	public double SizeXBase
    	{
    		set
    		{
    			foreach (Dif dif in difs)
    			{
    				dif.SizeXBase = value;
    			}
    		}
    	}

    	public double SizeXCont
    	{
    		set
    		{
    			foreach (Dif dif in difs)
    			{
    				dif.SizeXCont = value;
    			}
    		}
    	}

    	public double SizeYBase
    	{
    		set
    		{
    			foreach (Dif dif in difs)
    			{
    				dif.SizeYBase = value;
    			}
    		}
    	}

    	public double SizeYCont
    	{
    		set
    		{
    			foreach (Dif dif in difs)
    			{
    				dif.SizeYCont = value;
    			}
    		}
    	}

    	public bool Dra
    	{
    		set
    		{
    			foreach (Dif dif in difs)
    			{
    				dif.Dra = value;
    			}
    		}
    	}

    	public bool Hit
    	{
    		set
    		{
    			foreach (Dif dif in difs)
    			{
    				dif.Hit = value;
    			}
    		}
    	}

    	[JsonIgnore]
    	public Par CurJoinRoot
    	{
    		get
    		{
    			Pars current = Current;
    			if (pr.ContainsKey(current))
    			{
    				return pr[current];
    			}
    			return null;
    		}
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


    	public void Draw(Are Are)
    	{
    		Are.Draw(Current);
    	}
    	public void Draw(AreM AreM)
    	{
    		AreM.Draw(Current);
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
    			Vector2D p = p0.Position;
    			if (array.All((Par p1) => p0 == p1 || p1.JP.All((Joi j) => !(p1.ToGlobal(j.Joint).DistanceSquared(p) <= Join.IdentityDistance))))
    			{
    				return p0;
    			}
    		}
    		Par par = array.FirstOrDefault((Par e) => e.JP.Count > 0);
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
    		pj[Current].JoinP();
    	}

    	public void JoinPA()
    	{
    		pj[Current].JoinPA();
    	}

    	public void JoinPAall()
    	{
    		foreach (Joints value in pj.Values)
    		{
    			value.JoinPA();
    		}
    	}

    	public void JoinPA(Pars ps)
    	{
    		if (pj.ContainsKey(ps))
    		{
    			pj[ps].JoinPA();
    		}
    	}

    	public Par GetHitPar_(Color HitColor)
    	{
    		return difs.FirstOrDefault((Dif d) => d.IsHit(ref HitColor)).Parss.FirstOrDefault((Pars ps) => ps.IsHit(ref HitColor)).EnumAllPar().FirstOrDefault((Par e) => e.HitColor == HitColor);
    	}

    	public List<string> GetHitTags(ref Color HitColor)
    	{
    		List<string> list = new List<string>();
    		foreach (Dif dif in difs)
    		{
    			list.AddRange(dif.GetHitTags(ref HitColor));
    		}
    		return list;
    	}

    	public List<Par> GetHitPars(ref Color HitColor)
    	{
    		List<Par> list = new List<Par>();
    		foreach (Dif dif in difs)
    		{
    			list.AddRange(dif.GetHitPars(ref HitColor));
    		}
    		return list;
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
