using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;

namespace _2DGAMELIB
{
    [Serializable]
    public class VariantGrid
    {
    	public string Tag = "";

    	public double ValueX;

    	public double ValueY;

    	private List<MorphVariant> difs = new List<MorphVariant>();

    	public Dictionary<PartGroup, Joints> pj;

    	public Dictionary<PartGroup, ShapePart> pr;

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

        public MorphVariant this[int Index]
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

        public PartGroup GetCurrent()
        {
            return difs[GetIndexX()][GetIndexY()];
        }

        public void SetAngleBase(double value)
        {
            foreach (MorphVariant dif in difs)
            {
                dif.SetAngleBase(value);
            }
        }

        public void SetSizeBase(double value)
        {
            foreach (MorphVariant dif in difs)
            {
                dif.SetSizeBase(value);
            }
        }

        public void SetSizeYCont(double value)
        {
            foreach (MorphVariant dif in difs)
            {
                dif.SetSizeYCont(value);
            }
        }

        public ShapePart GetCurJoinRoot()
        {
            PartGroup current = GetCurrent();
            if (pr.ContainsKey(current))
            {
                return pr[current];
            }
            return null;
        }

        [JsonIgnore]
    	public IEnumerable<ShapePart> EnumJoinRoot => pr.Values;
    	public IEnumerable<ShapePart> EnumAllPar()
    	{
    		foreach (MorphVariant dif in difs)
    		{
    			foreach (ShapePart item in dif.EnumAllPar())
    			{
    				yield return item;
    			}
    		}
    	}

    	public IEnumerable<PartGroup> EnumAllPars()
    	{
    		foreach (MorphVariant dif in difs)
    		{
    			foreach (PartGroup item in dif.Parss)
    			{
    				yield return item;
    			}
    		}
    	}

    	public void SetDefault()
    	{
    		foreach (MorphVariant dif in difs)
    		{
    			dif.SetDefault();
    		}
    	}

    	public VariantGrid()
    	{
    	}

    	public VariantGrid(VariantGrid VariantGrid)
    	{
    		Copy(VariantGrid);
    	}

    	private void Copy(VariantGrid VariantGrid)
    	{
    		Tag = VariantGrid.Tag;
    		ValueX = VariantGrid.ValueX;
    		ValueY = VariantGrid.ValueY;
    		foreach (MorphVariant dif in VariantGrid.difs)
    		{
    			difs.Add(new MorphVariant(dif));
    		}
    	}

    	public void Add(MorphVariant MorphVariant)
    	{
    		difs.Add(MorphVariant);
    	}


    	public void Draw(RenderArea Are)
    	{
    		Are.Draw(GetCurrent());
    	}
    	public void Draw(ManagedArea ManagedArea)
    	{
    		ManagedArea.Draw(GetCurrent());
    	}

    	private ShapePart GetJoinRoot(PartGroup ps)
    	{
    		ShapePart[] array = ps.EnumAllPar().ToArray();
    		if (array.Length <= 1)
    		{
    			return array.FirstOrDefault();
    		}
    		ShapePart[] array2 = array;
    		foreach (ShapePart p0 in array2)
    		{
    			Vector2D p = p0.GetPosition();
    			if (array.All((ShapePart p1) => p0 == p1 || p1.GetJP().All((JointPoint j) => !(p1.ToGlobal(j.Joint).DistanceSquared(p) <= JointLink.IdentityDistance))))
    			{
    				return p0;
    			}
    		}
    		ShapePart par = array.FirstOrDefault((ShapePart e) => e.GetJP().Count > 0);
    		if (par != null)
    		{
    			return par;
    		}
    		return array.First();
    	}

    	public void SetJoints()
    	{
    		pj = new Dictionary<PartGroup, Joints>();
    		pr = new Dictionary<PartGroup, ShapePart>();
    		foreach (PartGroup item in EnumAllPars())
    		{
    			ShapePart joinRoot = GetJoinRoot(item);
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

    	public ShapePart GetHitPar_(Color HitColor)
    	{
    		return difs.FirstOrDefault((MorphVariant d) => d.IsHit(ref HitColor)).Parss.FirstOrDefault((PartGroup ps) => ps.IsHit(ref HitColor)).EnumAllPar().FirstOrDefault((ShapePart e) => e.GetHitColor() == HitColor);
    	}

    	public bool IsHit(ref Color HitColor)
    	{
    		foreach (MorphVariant dif in difs)
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
    		foreach (MorphVariant dif in difs)
    		{
    			dif.ReverseX();
    		}
    		JoinP();
    	}

    	public void ReverseY()
    	{
    		SetJoints();
    		foreach (MorphVariant dif in difs)
    		{
    			dif.ReverseY();
    		}
    		JoinP();
    	}

    	public void Dispose()
    	{
    		foreach (MorphVariant dif in difs)
    		{
    			dif.Dispose();
    		}
    	}
    }
}
