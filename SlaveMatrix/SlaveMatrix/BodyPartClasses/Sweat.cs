using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public struct ryps
    {
        public Par r;

        public Vector2D c;

        public Vector2D[] ps;
    }


    public class Sweat
    {
    	private HashSet<string> 汗対象 = new HashSet<string>
    	{
    		Sta.胸t.ToString(),
    		Sta.胴t.ToString(),
    		Sta.肩t.ToString(),
    		Sta.腰t.ToString()
    	};

    	private ryps[] 対象;

    	private List<Ele> 全体 = new List<Ele>();

    	private List<double> 位置 = new List<double>();

    	public Mot 汗かき;

    	private Mot 汗ひき;

    	private bool 汗だし = true;

    	private int i;

    	private Ele 汗;

    	private Vector2D tp;

    	public void Draw(RenderArea Are)
    	{
    		if (!汗かき.Run && !汗ひき.Run)
    		{
    			return;
    		}
    		this.i = 0;
    		ryps[] array = 対象;
    		for (int i = 0; i < array.Length; i++)
    		{
    			ryps ryps2 = array[i];
    			Vector2D[] ps = ryps2.ps;
    			foreach (Vector2D local in ps)
    			{
    				汗 = 全体[this.i];
    				if (汗.濃度 != 0.0)
    				{
    					tp = ryps2.r.ToGlobal(local);
    					汗.本体.CurJoinRoot.PositionBase = tp + (ryps2.r.ToGlobal(ryps2.c) - tp) * 位置[this.i];
    					汗.本体.JoinPA();
    					汗.色更新();
    					汗.本体.Draw(Are);
    				}
    				this.i++;
    			}
    		}
    	}

    	public Sweat(Med Med, RenderArea Are, Cha Cha, Mots Mots)
    	{
    		Ele[] es = null;
    		Ele n = null;
    		bool re = false;
    		汗かき = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			Staing = delegate
    			{
    				if (汗だし)
    				{
    					es = 全体.Where((Ele e) => e.濃度 != 0.0).ToArray();
    					Ele[] array5 = es;
    					for (int num3 = 0; num3 < array5.Length; num3++)
    					{
    						array5[num3].濃度 = 0.0;
    					}
    				}
    			},
    			Runing = delegate(Mot m)
    			{
    				if (汗だし)
    				{
    					Ele[] array4 = es;
    					for (int num2 = 0; num2 < array4.Length; num2++)
    					{
    						array4[num2].濃度 = m.Value;
    					}
    				}
    				else if (!re)
    				{
    					n.Yv = m.Value;
    				}
    				else
    				{
    					n.濃度 = m.Value;
    				}
    			},
    			Reaing = delegate(Mot m)
    			{
    				if (汗だし)
    				{
    					Ele[] array3 = es;
    					for (int l = 0; l < array3.Length; l++)
    					{
    						array3[l].濃度 = 1.0;
    					}
    					m.ResetValue();
    					汗だし = false;
    					es = 全体.Where((Ele e) => e.濃度 != 0.0).ToArray();
    					n = es[RNG.XS.Next(es.Length)];
    				}
    				else
    				{
    					re = true;
    				}
    			},
    			Rouing = delegate(Mot m)
    			{
    				if (!汗だし)
    				{
    					n.Yv = 0.0;
    					n.濃度 = 0.0;
    					es = 全体.Where((Ele e) => e.濃度 != 0.0).ToArray();
    					if (es.Length != 0)
    					{
    						n = es[RNG.XS.Next(es.Length)];
    					}
    					es = 全体.Where((Ele e) => e.濃度 == 0.0).ToArray();
    					if (es.Length != 0)
    					{
    						es[RNG.XS.Next(es.Length)].濃度 = 1.0;
    					}
    					re = false;
    					m.ResetValue();
    				}
    			},
    			Ending = delegate(Mot m)
    			{
    				if (!汗だし)
    				{
    					n.Yv = 0.0;
    					n.濃度 = 0.0;
    					es = 全体.Where((Ele e) => e.濃度 != 0.0).ToArray();
    					n = es[RNG.XS.Next(es.Length)];
    					es = 全体.Where((Ele e) => e.濃度 == 0.0).ToArray();
    					es[RNG.XS.Next(es.Length)].濃度 = 1.0;
    					re = false;
    					m.ResetValue();
    					汗ひき.Start();
    				}
    			}
    		};
    		Mots.Add(汗かき.GetHashCode().ToString(), 汗かき);
    		汗ひき = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			Staing = delegate
    			{
    				es = 全体.Where((Ele e) => e.濃度 != 0.0).ToArray();
    			},
    			Runing = delegate(Mot m)
    			{
    				Ele[] array2 = es;
    				for (int k = 0; k < array2.Length; k++)
    				{
    					array2[k].濃度 = m.Value.Inverse();
    				}
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    				m.ResetValue();
    				Ele[] array = es;
    				for (int j = 0; j < array.Length; j++)
    				{
    					array[j].濃度 = 1.0;
    				}
    				汗だし = true;
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(汗ひき.GetHashCode().ToString(), 汗ひき);
    		List<ryps> list = new List<ryps>();
    		int num = 0;
    		汗D e2 = new 汗D();
    		ryps ryps;
    		foreach (Ele item in Cha.Bod.Elements.Where((Ele e) => 汗対象.Contains(e.GetType().ToString())))
    		{
    			ryps = default(ryps);
    			ryps.r = item.本体.CurJoinRoot;
    			ryps.c = ryps.r.OP.GetCenter();
    			ryps.ps = (from p in ryps.r.OP.EnumPoints()
    				where ryps.c.Y > p.Y
    				select p).ToArray();
    			list.Add(ryps);
    			Vector2D[] ps = ryps.ps;
    			for (int i = 0; i < ps.Length; i++)
    			{
    				_ = ref ps[i];
    				汗 = new 汗(Are.DisplayUnitScale, 配色指定.N0, Cha.配色, Med, e2);
    				汗.SetHitFalse();
    				汗.濃度 = ((RNG.XS.NextDouble() < 0.2) ? 1.0 : 0.0);
    				位置.Add(num switch
    				{
    					1 => 0.5, 
    					0 => 0.7, 
    					_ => 0.3, 
    				});
    				全体.Add(汗);
    				num = ((num != 2) ? (num + 1) : 0);
    			}
    		}
    		対象 = list.ToArray();
    	}

    	public void Dispose()
    	{
    		foreach (Ele item in 全体)
    		{
    			item.Dispose();
    		}
    	}
    }
}
