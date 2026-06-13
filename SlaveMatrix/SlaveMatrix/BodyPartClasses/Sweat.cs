using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public struct ryps
    {
        public ShapePart r;

        public Vector2D c;

        public Vector2D[] ps;
    }


    public class Sweat
    {
    	private HashSet<string> 汗対象 = new HashSet<string>
    	{
    		GlobalState.ChestType.ToString(),
    		GlobalState.TorsoType.ToString(),
    		GlobalState.ShoulderType.ToString(),
    		GlobalState.WaistType.ToString()
    	};

    	private ryps[] 対象;

    	private List<Element> 全体 = new List<Element>();

    	private List<double> 位置 = new List<double>();

    	public Motion 汗かき;

    	private Motion 汗ひき;

    	private bool 汗だし = true;

    	private int i;

    	private Element 汗;

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
    				if (汗.Intensity != 0.0)
    				{
    					tp = ryps2.r.ToGlobal(local);
    					汗.Body.CurJoinRoot.PositionBase = tp + (ryps2.r.ToGlobal(ryps2.c) - tp) * 位置[this.i];
    					汗.Body.JoinPA();
    					汗.色更新();
    					汗.Body.Draw(Are);
    				}
    				this.i++;
    			}
    		}
    	}

    	public Sweat(ModeEventDispatcher Med, RenderArea Are, Character Cha, Motions Mots)
    	{
    		Element[] es = null;
    		Element n = null;
    		bool re = false;
    		汗かき = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    				if (汗だし)
    				{
    					es = 全体.Where((Element e) => e.Intensity != 0.0).ToArray();
    					Element[] array5 = es;
    					for (int num3 = 0; num3 < array5.Length; num3++)
    					{
    						array5[num3].Intensity = 0.0;
    					}
    				}
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (汗だし)
    				{
    					Element[] array4 = es;
    					for (int num2 = 0; num2 < array4.Length; num2++)
    					{
    						array4[num2].Intensity = m.Value;
    					}
    				}
    				else if (!re)
    				{
    					n.Yv = m.Value;
    				}
    				else
    				{
    					n.Intensity = m.Value;
    				}
    			},
    			OnReach = delegate(Motion m)
    			{
    				if (汗だし)
    				{
    					Element[] array3 = es;
    					for (int l = 0; l < array3.Length; l++)
    					{
    						array3[l].Intensity = 1.0;
    					}
    					m.ResetValue();
    					汗だし = false;
    					es = 全体.Where((Element e) => e.Intensity != 0.0).ToArray();
    					n = es[Rng.XS.Next(es.Length)];
    				}
    				else
    				{
    					re = true;
    				}
    			},
    			OnLoop = delegate(Motion m)
    			{
    				if (!汗だし)
    				{
    					n.Yv = 0.0;
    					n.Intensity = 0.0;
    					es = 全体.Where((Element e) => e.Intensity != 0.0).ToArray();
    					if (es.Length != 0)
    					{
    						n = es[Rng.XS.Next(es.Length)];
    					}
    					es = 全体.Where((Element e) => e.Intensity == 0.0).ToArray();
    					if (es.Length != 0)
    					{
    						es[Rng.XS.Next(es.Length)].Intensity = 1.0;
    					}
    					re = false;
    					m.ResetValue();
    				}
    			},
    			OnEnd = delegate(Motion m)
    			{
    				if (!汗だし)
    				{
    					n.Yv = 0.0;
    					n.Intensity = 0.0;
    					es = 全体.Where((Element e) => e.Intensity != 0.0).ToArray();
    					n = es[Rng.XS.Next(es.Length)];
    					es = 全体.Where((Element e) => e.Intensity == 0.0).ToArray();
    					es[Rng.XS.Next(es.Length)].Intensity = 1.0;
    					re = false;
    					m.ResetValue();
    					汗ひき.Start();
    				}
    			}
    		};
    		Mots.Add(汗かき.GetHashCode().ToString(), 汗かき);
    		汗ひき = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    				es = 全体.Where((Element e) => e.Intensity != 0.0).ToArray();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				Element[] array2 = es;
    				for (int k = 0; k < array2.Length; k++)
    				{
    					array2[k].Intensity = m.Value.Inverse();
    				}
    			},
    			OnReach = delegate(Motion m)
    			{
    				m.End();
    				m.ResetValue();
    				Element[] array = es;
    				for (int j = 0; j < array.Length; j++)
    				{
    					array[j].Intensity = 1.0;
    				}
    				汗だし = true;
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    			}
    		};
    		Mots.Add(汗ひき.GetHashCode().ToString(), 汗ひき);
    		List<ryps> list = new List<ryps>();
    		int num = 0;
    		汗D e2 = new 汗D();
    		ryps ryps;
    		foreach (Element item in Cha.Body.Elements.Where((Element e) => 汗対象.Contains(e.GetType().ToString())))
    		{
    			ryps = default(ryps);
    			ryps.r = item.Body.CurJoinRoot;
    			ryps.c = ryps.r.OP.GetCenter();
    			ryps.ps = (from p in ryps.r.OP.EnumPoints()
    				where ryps.c.Y > p.Y
    				select p).ToArray();
    			list.Add(ryps);
    			Vector2D[] ps = ryps.ps;
    			for (int i = 0; i < ps.Length; i++)
    			{
    				_ = ref ps[i];
    				汗 = new 汗(Are.DisplayUnitScale, 配色指定.N0, Cha.ColorSet, Med, e2);
    				汗.SetHitFalse();
    				汗.Intensity = ((Rng.XS.NextDouble() < 0.2) ? 1.0 : 0.0);
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
    		foreach (Element item in 全体)
    		{
    			item.Dispose();
    		}
    	}
    }
}
