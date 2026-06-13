using System;
using System.Collections.Generic;
using System.Linq;

namespace _2DGAMELIB
{
    public static class Join
    {
    	public static double IdentityDistance = System.Math.Pow(5E-05, 2.0);

    	public static Joints GetJoints(this Par JoinRoot, IEnumerable<Par> EnumPar)
    	{
    		Joints joints = new Joints();
    		int num = 0;
    		List<int> list = new List<int>();
    		List<Par> list2 = EnumPar.ToList();
    		foreach (Joi item in JoinRoot.GetJP())
    		{
    			Vector2D v = JoinRoot.ToGlobal(item.Joint);
    			int num2 = 0;
    			list.Clear();
    			foreach (Par item2 in list2)
    			{
    				if (JoinRoot != item2)
    				{
    					if (v.DistanceSquared(item2.GetPosition()) <= IdentityDistance)
    					{
    						joints.Joins.Add(new Joint(JoinRoot, num, item2));
    						if (!list.Contains(num2))
    						{
    							list.Add(num2);
    						}
    					}
    				}
    				else if (!list.Contains(num2))
    				{
    					list.Add(num2);
    				}
    				num2++;
    			}
    			for (int num3 = list.Count - 1; num3 > -1; num3--)
    			{
    				list2.RemoveAt(list[num3]);
    			}
    			num++;
    		}
    		GetJoints(list2, joints, list);
    		return joints;
    	}

    	private static void GetJoints(List<Par> pl, Joints js, List<int> del)
    	{
    		int num = -1;
    		int num2 = 0;
    		while (num != js.Joins.Count)
    		{
    			num = js.Joins.Count;
    			for (int i = num2; i < num; i++)
    			{
    				Par par = js.Joins[i].Par1;
    				int num3 = 0;
    				foreach (Joi item in par.GetJP())
    				{
    					Vector2D v = par.ToGlobal(item.Joint);
    					int num4 = 0;
    					del.Clear();
    					foreach (Par item2 in pl)
    					{
    						if (par != item2)
    						{
    							if (v.DistanceSquared(item2.GetPosition()) <= IdentityDistance)
    							{
    								js.Joins.Add(new Joint(par, num3, item2));
    								if (!del.Contains(num4))
    								{
    									del.Add(num4);
    								}
    							}
    						}
    						else if (!del.Contains(num4))
    						{
    							del.Add(num4);
    						}
    						num4++;
    					}
    					for (int num5 = del.Count - 1; num5 > -1; num5--)
    					{
    						pl.RemoveAt(del[num5]);
    					}
    					num3++;
    				}
    			}
    			num2 = num;
    		}
    	}

    	public static JointsD GetJointsD(this Difs JoinRoot, IEnumerable<Difs> EnumDifs)
    	{
    		JointsD jointsD = new JointsD();
    		List<int> list = new List<int>();
    		List<Difs> list2 = EnumDifs.ToList();
    		foreach (Par item in JoinRoot.EnumAllPar())
    		{
    			int num = 0;
    			list.Clear();
    			foreach (Difs item2 in list2)
    			{
    				if (JoinRoot != item2)
    				{
    					int num2 = 0;
    					foreach (Joi item3 in item.GetJP())
    					{
    						Vector2D v = item.ToGlobal(item3.Joint);
    						foreach (Par item4 in item2.EnumJoinRoot)
    						{
    							if (v.DistanceSquared(item4.GetPosition()) <= IdentityDistance)
    							{
    								jointsD.Joins.Add(new JointD(JoinRoot, item, num2, item2));
    								if (!list.Contains(num))
    								{
    									list.Add(num);
    								}
    								break;
    							}
    						}
    						num2++;
    					}
    				}
    				else if (!list.Contains(num))
    				{
    					list.Add(num);
    				}
    				num++;
    			}
    			for (int num3 = list.Count - 1; num3 > -1; num3--)
    			{
    				list2.RemoveAt(list[num3]);
    			}
    		}
    		GetJointsD(list2, jointsD, list);
    		return jointsD;
    	}

    	private static void GetJointsD(List<Difs> dl, JointsD jsd, List<int> del)
    	{
    		int num = -1;
    		int num2 = 0;
    		while (num != jsd.Joins.Count)
    		{
    			num = jsd.Joins.Count;
    			for (int i = num2; i < num; i++)
    			{
    				Difs difs = jsd.Joins[i].Difs1;
    				foreach (Par item in difs.EnumAllPar())
    				{
    					int num3 = 0;
    					del.Clear();
    					foreach (Difs item2 in dl)
    					{
    						if (difs != item2)
    						{
    							int num4 = 0;
    							foreach (Joi item3 in item.GetJP())
    							{
    								Vector2D v = item.ToGlobal(item3.Joint);
    								foreach (Par item4 in item2.EnumJoinRoot)
    								{
    									if (v.DistanceSquared(item4.GetPosition()) <= IdentityDistance)
    									{
    										jsd.Joins.Add(new JointD(difs, item, num4, item2));
    										if (!del.Contains(num3))
    										{
    											del.Add(num3);
    										}
    										break;
    									}
    								}
    								num4++;
    							}
    						}
    						else if (!del.Contains(num3))
    						{
    							del.Add(num3);
    						}
    						num3++;
    					}
    					for (int num5 = del.Count - 1; num5 > -1; num5--)
    					{
    						dl.RemoveAt(del[num5]);
    					}
    				}
    			}
    			num2 = num;
    		}
    	}
    }
}
