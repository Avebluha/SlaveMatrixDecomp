using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class Cha
    {
    	public ModeEventDispatcher Med;

    	public RenderArea Are;

    	public Bod Bod;

    	public ChaD ChaD;

    	public 体配色 配色;

    	public double FPS;

    	public Vector2D CP;

    	private Mot 呼吸;

    	private double 呼吸速度_;

    	private Mot 涙流し;

    	private Mot 涙ひき;

    	private bool 泣き_;

    	private Mot 瞬き1;

    	private Mot 瞬き2;

    	public Mot 汗かき;

    	public Mot 口腔精液垂れ;

    	public Mot 性器精液垂れ;

    	public Mot 肛門精液垂れ;

    	public Mot 出糸精液垂れ;

    	public Mot 潮吹小;

    	public Mot 潮吹大;

    	public Mot 飛沫;

    	public Mot 唾散;

    	public Mot 放尿;

    	public Action 放尿強制終了_ = delegate
    	{
    	};

    	public Func<bool> Is放尿 = () => false;

    	public Mot 噴乳;

    	public double 噴乳染み;

    	public Mot 鼻水;

    	public Mot 涎;

    	public Mot EyeTracking;

    	public bool 目逸し;

    	public double 絶頂激しさ;

    	public double 絶頂時間;

    	public Mot 絶頂終了;

    	public Mot 絶頂;

    	public Mot 肛ヒク;

    	public Mot 膣ヒク;

    	public Mot 糸ヒク;

    	public Mot 顔面展開;

    	public Mot 体揺れ;

    	public Mot Coughing;

    	public Mot ごっくん;

    	private Sweat 汗掻き;

    	public double 瞼基準単;

    	public double 瞼基準左;

    	public double 瞼基準右;

    	public double 瞼基準額;

    	public double 瞼基準頬左;

    	public double 瞼基準頬右;

    	public Action 潮吹擬音;

    	public Action 放尿擬音;

    	private double 呼吸_;

    	private double y;

    	private bool 重髪;

    	private bool 重耳;

    	private bool 重胸;

    	private bool 重Waist;

    	private bool 重腕前;

    	private bool 重半後;

    	private bool 重半中1;

    	private bool 重半中2;

    	private bool 重半前;

    	private bool 重腿;

    	private Vector2D p = Dat.Vec2DZero;

    	public Mots Mots = new Mots();

    	public double 呼吸速度
    	{
    		get
    		{
    			return 呼吸速度_;
    		}
    		set
    		{
    			呼吸速度_ = value;
    			呼吸.BaseSpeed = 6.0 * 呼吸速度_;
    		}
    	}

    	public bool Crying
    	{
    		get
    		{
    			return 泣き_;
    		}
    		set
    		{
    			泣き_ = value;
    			if (!泣き_)
    			{
    				涙ひき.Start();
    			}
    		}
    	}

    	public double 呼吸値
    	{
    		get
    		{
    			return 呼吸_;
    		}
    		set
    		{
    			呼吸_ = value;
    			Bod.Chest.尺度C = 0.99 + 0.02 * 呼吸_;
    			Bod.胸肌_人.尺度C = Bod.Chest.尺度C;
    			p.Y = y * 呼吸_ * 0.5;
    			if (Bod.Is髪)
    			{
    				Bod.EI髪.Position = p;
    			}
    			if (Bod.Is腕前)
    			{
    				Bod.EI腕前.Position = p;
    			}
    			p.Y = y * 呼吸_ * 0.28;
    			if (Bod.IsChest)
    			{
    				Bod.EIChest.Position = p;
    			}
    			p.Y = 0.0 - p.Y;
    			Bod.Waist.位置C = p;
    			if (Bod.IsWaist)
    			{
    				Bod.EIWaist.Position = p;
    			}
    			if (Bod.Is半後)
    			{
    				Bod.EI半後.Position = p;
    			}
    			if (Bod.Is半中1)
    			{
    				Bod.EI半中1.Position = p;
    			}
    			if (Bod.Is半中2)
    			{
    				Bod.EI半中2.Position = p;
    			}
    			if (Bod.Is半前)
    			{
    				Bod.EI半前.Position = p;
    			}
    			if (Bod.Is腿)
    			{
    				Bod.EI腿.Position = p;
    			}
    		}
    	}

    	public double 中出度
    	{
    		get
    		{
    			if (Bod.カーソル != null)
    			{
    				return (1.0 / (double)(Bod.カーソル.ペニス処理.中出しCount + 1)).Inverse();
    			}
    			return 0.0;
    		}
    	}

    	public void 放尿強制終了()
    	{
    		放尿強制終了_();
    	}

    	public Cha(ModeEventDispatcher Med, RenderArea Are, ChaD ChaD)
    	{
    		Cha cha = this;
    		this.Med = Med;
    		this.Are = Are;
    		this.ChaD = ChaD;
    		配色 = new 体配色(ChaD.body_color);
    		_ = Are.DisplayUnitScale;
    		Bod = new Bod(Med, Are, this);
    		重髪 = Bod.Is髪 && Bod.EI髪.IsHeavy();
    		重胸 = Bod.IsChest && Bod.EIChest.IsHeavy();
    		重Waist = Bod.IsWaist && Bod.EIWaist.IsHeavy();
    		重腕前 = Bod.Is腕前 && Bod.EI腕前.IsHeavy();
    		重半後 = Bod.Is半後 && Bod.EI半後.IsHeavy();
    		重半中1 = Bod.Is半中1 && Bod.EI半中1.IsHeavy();
    		重半中2 = Bod.Is半中2 && Bod.EI半中2.IsHeavy();
    		重半前 = Bod.Is半前 && Bod.EI半前.IsHeavy();
    		重腿 = Bod.Is腿 && Bod.EI腿.IsHeavy();
    		double 尺度C = Bod.Chest.尺度C;
    		Bod.Chest.尺度C = 0.99;
    		double num = Bod.Chest.X0Y0_胸郭.ToGlobal(Bod.Chest.X0Y0_胸郭.JP[0].Joint).Y;
    		Bod.Chest.尺度C = 1.01;
    		double num2 = Bod.Chest.X0Y0_胸郭.ToGlobal(Bod.Chest.X0Y0_胸郭.JP[0].Joint).Y;
    		Bod.Chest.尺度C = 尺度C;
    		y = num2 - num;
    		呼吸 = new Mot(0.0, 1.0)
    		{
    			LowestIncrease = 0.25,
    			BaseSpeed = 6.0 * 呼吸速度_,
    			Staing = delegate
    			{
    				cha.Bod.呼気.濃度 = 0.0;
    				cha.Bod.呼気.表示 = true;
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.Bod.呼気.濃度 = m.Value.Inverse() * cha.呼吸速度_;
    				cha.呼吸値 = m.Value;
    			},
    			Reaing = delegate
    			{
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				cha.Bod.呼気.表示 = false;
    				cha.Bod.呼気.濃度 = 1.0;
    				cha.呼吸値 = 0.0;
    			}
    		};
    		Mots.Add(呼吸.GetHashCode().ToString(), 呼吸);
    		呼吸速度 = 0.2;
    		呼吸.Start();
    		bool go = true;
    		bool 涙左 = Bod.涙左 != null;
    		bool 涙右 = Bod.涙右 != null;
    		涙流し = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 3.0,
    			Staing = delegate
    			{
    				go = true;
    				if (涙左)
    				{
    					if (cha.Bod.Is双眼)
    					{
    						cha.Bod.目左.黒目_ハイライト下_表示 = true;
    					}
    					if (cha.Bod.Is頬眼)
    					{
    						cha.Bod.頬目左.黒目_ハイライト下_表示 = true;
    					}
    					if (cha.Bod.Is単眼)
    					{
    						cha.Bod.単眼目.黒目_ハイライト下_表示 = true;
    					}
    					if (cha.Bod.Is額眼)
    					{
    						cha.Bod.額目.黒目_ハイライト下_表示 = true;
    					}
    					cha.Bod.涙左.涙0流れ0_表示 = cha.Bod.涙左.涙0流れ1_表示 || cha.Bod.涙左.涙0_表示;
    					cha.Bod.涙左.涙0流れ1_表示 = cha.Bod.涙左.涙0_表示;
    					cha.Bod.涙左.涙0_表示 = !cha.Bod.涙左.涙0_表示;
    					cha.Bod.涙左.涙ハイライト_表示 = cha.Bod.涙左.涙0_表示;
    					cha.Bod.涙左.Yv = 0.0;
    					cha.Bod.涙左.涙0流れ1CD.不透明度 = 1.0;
    				}
    				if (涙右)
    				{
    					if (cha.Bod.Is双眼)
    					{
    						cha.Bod.目右.黒目_ハイライト下_表示 = true;
    					}
    					if (cha.Bod.Is頬眼)
    					{
    						cha.Bod.頬目右.黒目_ハイライト下_表示 = true;
    					}
    					cha.Bod.涙右.涙0流れ0_表示 = cha.Bod.涙右.涙0流れ1_表示 || cha.Bod.涙右.涙0_表示;
    					cha.Bod.涙右.涙0流れ1_表示 = cha.Bod.涙右.涙0_表示;
    					cha.Bod.涙右.涙0_表示 = !cha.Bod.涙右.涙0_表示;
    					cha.Bod.涙右.涙ハイライト_表示 = cha.Bod.涙右.涙0_表示;
    					cha.Bod.涙右.Yv = 0.0;
    					cha.Bod.涙右.涙0流れ1CD.不透明度 = 1.0;
    				}
    			},
    			Runing = delegate(Mot m)
    			{
    				if (go)
    				{
    					if (涙左)
    					{
    						cha.Bod.涙左.Yv = m.Value;
    					}
    					if (涙右)
    					{
    						cha.Bod.涙右.Yv = m.Value;
    					}
    				}
    				else
    				{
    					if (涙左)
    					{
    						cha.Bod.涙左.涙0流れ1CD.不透明度 = m.Value;
    					}
    					if (涙右)
    					{
    						cha.Bod.涙右.涙0流れ1CD.不透明度 = m.Value;
    					}
    				}
    			},
    			Reaing = delegate
    			{
    				go = false;
    				if (涙左)
    				{
    					cha.Bod.涙左.Yv = 1.0;
    				}
    				if (涙右)
    				{
    					cha.Bod.涙右.Yv = 1.0;
    				}
    			},
    			Rouing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(涙流し.GetHashCode().ToString(), 涙流し);
    		double vi;
    		涙ひき = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			Staing = delegate
    			{
    			},
    			Runing = delegate(Mot m)
    			{
    				vi = m.Value.Inverse();
    				if (涙左)
    				{
    					cha.Bod.涙左.濃度 *= vi;
    					if (cha.Bod.Is双眼)
    					{
    						cha.Bod.目左.黒目_ハイライト下CD.不透明度 *= vi;
    					}
    					if (cha.Bod.Is頬眼)
    					{
    						cha.Bod.頬目左.黒目_ハイライト下CD.不透明度 *= vi;
    					}
    					if (cha.Bod.Is単眼)
    					{
    						cha.Bod.単眼目.黒目_ハイライト下CD.不透明度 *= vi;
    					}
    					if (cha.Bod.Is額眼)
    					{
    						cha.Bod.額目.黒目_ハイライト下CD.不透明度 *= vi;
    					}
    				}
    				if (涙右)
    				{
    					cha.Bod.涙右.濃度 *= vi;
    					if (cha.Bod.Is双眼)
    					{
    						cha.Bod.目右.黒目_ハイライト下CD.不透明度 *= vi;
    					}
    					if (cha.Bod.Is頬眼)
    					{
    						cha.Bod.頬目右.黒目_ハイライト下CD.不透明度 *= vi;
    					}
    				}
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    				m.ResetValue();
    				if (涙左)
    				{
    					cha.Bod.涙左.表示 = false;
    					cha.Bod.涙左.濃度 = 1.0;
    					if (cha.Bod.Is双眼)
    					{
    						cha.Bod.目左.黒目_ハイライト下_表示 = false;
    						cha.Bod.目左.黒目_ハイライト下CD.不透明度 = 1.0;
    					}
    					if (cha.Bod.Is頬眼)
    					{
    						cha.Bod.頬目左.黒目_ハイライト下_表示 = false;
    						cha.Bod.頬目左.黒目_ハイライト下CD.不透明度 = 1.0;
    					}
    					if (cha.Bod.Is単眼)
    					{
    						cha.Bod.単眼目.黒目_ハイライト下_表示 = false;
    						cha.Bod.単眼目.黒目_ハイライト下CD.不透明度 = 1.0;
    					}
    					if (cha.Bod.Is額眼)
    					{
    						cha.Bod.額目.黒目_ハイライト下_表示 = false;
    						cha.Bod.額目.黒目_ハイライト下CD.不透明度 = 1.0;
    					}
    				}
    				if (涙右)
    				{
    					cha.Bod.涙右.表示 = false;
    					cha.Bod.涙右.濃度 = 1.0;
    					if (cha.Bod.Is双眼)
    					{
    						cha.Bod.目右.黒目_ハイライト下_表示 = false;
    						cha.Bod.目右.黒目_ハイライト下CD.不透明度 = 1.0;
    					}
    					if (cha.Bod.Is頬眼)
    					{
    						cha.Bod.頬目右.黒目_ハイライト下_表示 = false;
    						cha.Bod.頬目右.黒目_ハイライト下CD.不透明度 = 1.0;
    					}
    				}
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(涙ひき.GetHashCode().ToString(), 涙ひき);
    		if (Bod.Is双眼 || Bod.Is単眼)
    		{
    			瞬き1 = new Mot(0.0, 1.0)
    			{
    				BaseSpeed = 10.0,
    				GotoSpeed = 8.0,
    				RetuSpeed = 0.5,
    				LowestIncrease = 1.0,
    				Interval = 1000.0,
    				Staing = delegate
    				{
    				},
    				Runing = delegate(Mot m)
    				{
    					if (cha.Bod.Is双眼)
    					{
    						cha.Bod.瞼左v = m.Value.Clamp(cha.Bod.Is瞼宇 ? 0.0 : cha.瞼基準左, 1.0);
    						cha.Bod.瞼右v = m.Value.Clamp(cha.Bod.Is瞼宇 ? 0.0 : cha.瞼基準右, 1.0);
    					}
    					if (cha.Bod.Is単眼)
    					{
    						cha.Bod.単眼瞼.Yv = m.Value.Clamp(cha.Bod.Is瞼宇 ? 0.0 : cha.瞼基準単, 1.0);
    					}
    				},
    				Reaing = delegate
    				{
    					if (cha.泣き_)
    					{
    						cha.涙流し.Start();
    					}
    				},
    				Rouing = delegate(Mot m)
    				{
    					m.Interval = 5000.0 * RNG.XS.NextDouble();
    				},
    				Ending = delegate
    				{
    				}
    			};
    			Mots.Add(瞬き1.GetHashCode().ToString(), 瞬き1);
    			瞬き1.Start();
    		}
    		if (Bod.Is頬眼 || Bod.Is額眼)
    		{
    			瞬き2 = new Mot(0.0, 1.0)
    			{
    				BaseSpeed = 10.0,
    				GotoSpeed = 8.0,
    				RetuSpeed = 0.5,
    				LowestIncrease = 1.0,
    				Interval = 1000.0,
    				Staing = delegate
    				{
    				},
    				Runing = delegate(Mot m)
    				{
    					if (cha.Bod.Is頬眼)
    					{
    						cha.Bod.頬瞼左.Yv = m.Value.Clamp(cha.瞼基準頬左, 1.0);
    						cha.Bod.頬瞼右.Yv = m.Value.Clamp(cha.瞼基準頬右, 1.0);
    					}
    					if (cha.Bod.Is額眼)
    					{
    						cha.Bod.額瞼.Yv = m.Value.Clamp(cha.瞼基準額, 1.0);
    					}
    				},
    				Reaing = delegate
    				{
    				},
    				Rouing = delegate(Mot m)
    				{
    					m.Interval = 5000.0 * RNG.XS.NextDouble();
    				},
    				Ending = delegate
    				{
    				}
    			};
    			Mots.Add(瞬き2.GetHashCode().ToString(), 瞬き2);
    			瞬き2.Start();
    		}
    		bool o = false;
    		double ov = 0.0;
    		口腔精液垂れ = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 0.8,
    			Staing = delegate
    			{
    				cha.Bod.口精液.Yi = 0;
    				ov = cha.中出度;
    				cha.Bod.口精液.濃度 = 1.0 * ov;
    				cha.Bod.口精液.精液_表示 = true;
    				o = true;
    				cha.Bod.口精液.右 = RNG.XS.NextBool();
    			},
    			Runing = delegate(Mot m)
    			{
    				if (o)
    				{
    					cha.Bod.口精液.Yv = m.Value;
    				}
    				else
    				{
    					cha.Bod.口精液.濃度 = m.Value * ov;
    				}
    			},
    			Reaing = delegate
    			{
    				o = false;
    			},
    			Rouing = delegate(Mot m)
    			{
    				cha.Bod.口精液.表示 = false;
    				m.End();
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(口腔精液垂れ.GetHashCode().ToString(), 口腔精液垂れ);
    		bool v = false;
    		double vv = 0.0;
    		double zd = Bod.膣内精液.精液濃度;
    		性器精液垂れ = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 0.8,
    			Staing = delegate
    			{
    				cha.Bod.性器精液.Yi = 0;
    				vv = cha.中出度;
    				cha.Bod.性器精液.濃度 = 1.0 * vv;
    				cha.Bod.性器精液.精液_表示 = true;
    				v = true;
    				zd = cha.Bod.膣内精液.精液濃度;
    				cha.Bod.性器精液.右 = RNG.XS.NextBool();
    			},
    			Runing = delegate(Mot m)
    			{
    				if (v)
    				{
    					cha.Bod.性器精液.Yv = m.Value;
    					cha.Bod.膣内精液.精液濃度 = zd * m.Value.Inverse();
    				}
    				else
    				{
    					cha.Bod.性器精液.濃度 = m.Value * vv;
    				}
    			},
    			Reaing = delegate
    			{
    				v = false;
    			},
    			Rouing = delegate(Mot m)
    			{
    				cha.Bod.性器精液.表示 = false;
    				m.End();
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(性器精液垂れ.GetHashCode().ToString(), 性器精液垂れ);
    		bool a = false;
    		double av = 0.0;
    		肛門精液垂れ = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 0.8,
    			Staing = delegate
    			{
    				cha.Bod.肛門精液.Yi = 0;
    				av = cha.中出度;
    				cha.Bod.肛門精液.濃度 = 1.0 * av;
    				cha.Bod.肛門精液.精液_表示 = true;
    				a = true;
    				cha.Bod.肛門精液.右 = RNG.XS.NextBool();
    			},
    			Runing = delegate(Mot m)
    			{
    				if (a)
    				{
    					cha.Bod.肛門精液.Yv = m.Value;
    				}
    				else
    				{
    					cha.Bod.肛門精液.濃度 = m.Value * av;
    				}
    			},
    			Reaing = delegate
    			{
    				a = false;
    			},
    			Rouing = delegate(Mot m)
    			{
    				cha.Bod.肛門精液.表示 = false;
    				m.End();
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(肛門精液垂れ.GetHashCode().ToString(), 肛門精液垂れ);
    		bool z = false;
    		double zv = 0.0;
    		出糸精液垂れ = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 0.8,
    			Staing = delegate
    			{
    				cha.Bod.出糸精液.Yi = 0;
    				zv = cha.中出度;
    				cha.Bod.出糸精液.濃度 = 1.0 * zv;
    				cha.Bod.出糸精液.精液_表示 = true;
    				z = true;
    				cha.Bod.出糸精液.右 = RNG.XS.NextBool();
    			},
    			Runing = delegate(Mot m)
    			{
    				if (z)
    				{
    					cha.Bod.出糸精液.Yv = m.Value;
    				}
    				else
    				{
    					cha.Bod.出糸精液.濃度 = m.Value * zv;
    				}
    			},
    			Reaing = delegate
    			{
    				z = false;
    			},
    			Rouing = delegate(Mot m)
    			{
    				cha.Bod.出糸精液.表示 = false;
    				m.End();
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(出糸精液垂れ.GetHashCode().ToString(), 出糸精液垂れ);
    		潮吹小 = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 4.0,
    			Staing = delegate
    			{
    				cha.Bod.潮吹_小.Yv = 0.0;
    				cha.Bod.潮吹_小.表示 = true;
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.Bod.潮吹_小.Yv = m.Value;
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				cha.Bod.潮吹_小.表示 = false;
    				cha.Bod.飛沫濃度 = (cha.Bod.飛沫濃度 + 0.01).Clamp(0.0, 1.0);
    			}
    		};
    		Mots.Add(潮吹小.GetHashCode().ToString(), 潮吹小);
    		潮吹大 = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 4.0,
    			Staing = delegate
    			{
    				cha.Bod.潮吹_大.Yv = 0.0;
    				cha.Bod.潮吹_大.表示 = true;
    				cha.Bod.潮吹_大.右 = RNG.XS.NextBool();
    				if (cha.潮吹擬音 != null)
    				{
    					cha.潮吹擬音();
    				}
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.Bod.潮吹_大.Yv = m.Value;
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				cha.Bod.潮吹_大.表示 = false;
    				cha.Bod.潮染み濃度 = (cha.Bod.潮染み濃度 + 0.2).Clamp(0.0, 1.0);
    			}
    		};
    		Mots.Add(潮吹大.GetHashCode().ToString(), 潮吹大);
    		飛沫 = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 4.0,
    			Staing = delegate
    			{
    				cha.Bod.飛沫.Yv = 0.0;
    				cha.Bod.飛沫.表示 = true;
    				cha.Bod.飛沫.右 = RNG.XS.NextBool();
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.Bod.飛沫.Yv = m.Value;
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				cha.Bod.飛沫.表示 = false;
    				cha.Bod.飛沫濃度 = (cha.Bod.飛沫濃度 + 0.03).Clamp(0.0, 1.0);
    			}
    		};
    		Mots.Add(飛沫.GetHashCode().ToString(), 飛沫);
    		唾散 = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 3.0,
    			Staing = delegate
    			{
    				cha.Bod.咳.Yv = 0.0;
    				cha.Bod.咳.表示 = true;
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.Bod.咳.Yv = m.Value;
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				cha.Bod.咳.表示 = false;
    			}
    		};
    		Mots.Add(唾散.GetHashCode().ToString(), 唾散);
    		Mot 染み = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 0.1,
    			Staing = delegate
    			{
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.Bod.尿染み濃度 = m.Value;
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(染み.GetHashCode().ToString(), 染み);
    		Mot 放尿1 = null;
    		Mot 放尿2 = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			Staing = delegate
    			{
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.Bod.放尿.濃度 = m.Value.Inverse();
    				ChaD.Shyness = (ChaD.Shyness + 0.002).Clamp(0.0, 1.0);
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				cha.Bod.放尿.表示 = false;
    				cha.Bod.放尿.濃度 = 1.0;
    				放尿1.End();
    			}
    		};
    		Mots.Add(放尿2.GetHashCode().ToString(), 放尿2);
    		Stopwatch sw = new Stopwatch();
    		放尿1 = new Mot(8.0, 10.0)
    		{
    			BaseSpeed = 10.0,
    			Staing = delegate
    			{
    				cha.Bod.放尿.Yi = 8;
    				sw.Start();
    			},
    			Runing = delegate(Mot m)
    			{
    				if (sw.ElapsedMilliseconds > 4000)
    				{
    					放尿2.Start();
    				}
    				else if (cha.放尿擬音 != null)
    				{
    					cha.放尿擬音();
    				}
    				cha.Bod.放尿.Yi = (int)m.Value;
    				ChaD.Shyness = (ChaD.Shyness + 0.002).Clamp(0.0, 1.0);
    			},
    			Reaing = delegate
    			{
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				sw.Reset();
    			}
    		};
    		Mots.Add(放尿1.GetHashCode().ToString(), 放尿1);
    		Mot 湯気 = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 0.2,
    			Staing = delegate
    			{
    				cha.Bod.湯気左濃度 = 0.0;
    				cha.Bod.湯気右濃度 = 0.0;
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.Bod.湯気左濃度 = m.Value;
    				cha.Bod.湯気右濃度 = m.Value;
    			},
    			Reaing = delegate
    			{
    			},
    			Rouing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(湯気.GetHashCode().ToString(), 湯気);
    		放尿 = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 0.6,
    			Staing = delegate
    			{
    				cha.Bod.放尿.Yv = 0.0;
    				cha.Bod.放尿.表示 = true;
    				if (cha.Bod.尿染み濃度 != 1.0)
    				{
    					染み.Start();
    				}
    				//Sounds.放尿.Play();
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.Bod.放尿.Yv = m.Value;
    				if (cha.放尿擬音 != null)
    				{
    					cha.放尿擬音();
    				}
    				ChaD.Shyness = (ChaD.Shyness + 0.002).Clamp(0.0, 1.0);
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				放尿1.Start();
    				湯気.Start();
    			}
    		};
    		Mots.Add(放尿.GetHashCode().ToString(), 放尿);
    		放尿強制終了_ = delegate
    		{
    			cha.放尿.End();
    			放尿1.End();
    			湯気.End();
    			放尿2.End();
    			染み.End();
    		};
    		Is放尿 = () => cha.放尿.Run || 放尿1.Run || 放尿2.Run;
    		噴乳 = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 2.0,
    			Staing = delegate
    			{
    				cha.Bod.噴乳左.Yi = 0;
    				cha.Bod.噴乳右.Yi = 0;
    				cha.Bod.噴乳左.母乳1_表示 = true;
    				cha.Bod.噴乳左.母乳2_表示 = true;
    				cha.Bod.噴乳左.母乳3_表示 = true;
    				cha.Bod.噴乳左.母乳4_表示 = true;
    				cha.Bod.噴乳右.母乳1_表示 = true;
    				cha.Bod.噴乳右.母乳2_表示 = true;
    				cha.Bod.噴乳右.母乳3_表示 = true;
    				cha.Bod.噴乳右.母乳4_表示 = true;
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.Bod.噴乳左.Yv = m.Value;
    				cha.Bod.噴乳右.Yv = m.Value;
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				cha.Bod.噴乳左.母乳1_表示 = false;
    				cha.Bod.噴乳左.母乳2_表示 = false;
    				cha.Bod.噴乳左.母乳3_表示 = false;
    				cha.Bod.噴乳左.母乳4_表示 = false;
    				cha.Bod.噴乳左.母乳垂れ1_表示 = true;
    				cha.Bod.噴乳左.母乳垂れ2_表示 = true;
    				cha.Bod.噴乳右.母乳1_表示 = false;
    				cha.Bod.噴乳右.母乳2_表示 = false;
    				cha.Bod.噴乳右.母乳3_表示 = false;
    				cha.Bod.噴乳右.母乳4_表示 = false;
    				cha.Bod.噴乳右.母乳垂れ1_表示 = true;
    				cha.Bod.噴乳右.母乳垂れ2_表示 = true;
    				cha.噴乳染み = (cha.噴乳染み + 0.03).Clamp(0.0, 1.0);
    			}
    		};
    		Mots.Add(噴乳.GetHashCode().ToString(), 噴乳);
    		bool hm = false;
    		bool 鼻水左 = Bod.鼻水左 != null;
    		bool 鼻水右 = Bod.鼻水右 != null;
    		鼻水 = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 3.0,
    			Staing = delegate
    			{
    				hm = RNG.XS.NextBool();
    				if (鼻水左 && hm && cha.Bod.鼻水左.Yv != 1.0 && cha.Bod.鼻水右.Yv != 1.0)
    				{
    					cha.Bod.鼻水左.Yv = 0.0;
    					cha.Bod.鼻水左.表示 = true;
    				}
    				if (鼻水右 && !hm && cha.Bod.鼻水左.Yv != 1.0 && cha.Bod.鼻水右.Yv != 1.0)
    				{
    					cha.Bod.鼻水右.Yv = 0.0;
    					cha.Bod.鼻水右.表示 = true;
    				}
    			},
    			Runing = delegate(Mot m)
    			{
    				if (鼻水左 && hm && cha.Bod.鼻水左.Yv != 1.0 && cha.Bod.鼻水右.Yv != 1.0)
    				{
    					cha.Bod.鼻水左.Yv = m.Value;
    				}
    				if (鼻水右 && !hm && cha.Bod.鼻水左.Yv != 1.0 && cha.Bod.鼻水右.Yv != 1.0)
    				{
    					cha.Bod.鼻水右.Yv = m.Value;
    				}
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(鼻水.GetHashCode().ToString(), 鼻水);
    		bool yb = false;
    		bool 涎左 = Bod.涎左 != null;
    		bool 涎右 = Bod.涎右 != null;
    		涎 = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 3.0,
    			Staing = delegate
    			{
    				yb = RNG.XS.NextBool();
    				if (涎左 && yb && cha.Bod.涎左.Yv != 1.0 && cha.Bod.涎右.Yv != 1.0)
    				{
    					cha.Bod.涎左.Yv = 0.0;
    					cha.Bod.涎左.表示 = true;
    				}
    				if (涎右 && !yb && cha.Bod.涎左.Yv != 1.0 && cha.Bod.涎右.Yv != 1.0)
    				{
    					cha.Bod.涎右.Yv = 0.0;
    					cha.Bod.涎右.表示 = true;
    				}
    			},
    			Runing = delegate(Mot m)
    			{
    				if (涎左 && yb && cha.Bod.涎左.Yv != 1.0 && cha.Bod.涎右.Yv != 1.0)
    				{
    					cha.Bod.涎左.Yv = m.Value;
    				}
    				if (涎右 && !yb && cha.Bod.涎左.Yv != 1.0 && cha.Bod.涎右.Yv != 1.0)
    				{
    					cha.Bod.涎右.Yv = m.Value;
    				}
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(涎.GetHashCode().ToString(), 涎);
    		int s;
    		Vector2D ev;
    		EyeTracking = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 0.1,
    			Staing = delegate
    			{
    			},
    			Runing = delegate
    			{
    				s = ((!cha.目逸し) ? 1 : (-1));
    				if (cha.目逸し)
    				{
    					if (cha.Bod.Is双眼)
    					{
    						ev = s * (cha.CP - (cha.Bod.目左.位置 + cha.Bod.目右.位置) * 0.5).newNormalize() * 0.002;
    						cha.Bod.目左.視線 = ev;
    						cha.Bod.目右.視線 = ev;
    					}
    					if (cha.Bod.Is頬眼)
    					{
    						ev = s * (cha.CP - (cha.Bod.頬目左.位置 + cha.Bod.頬目右.位置) * 0.5).newNormalize() * 0.00089;
    						cha.Bod.頬目左.視線 = ev;
    						cha.Bod.頬目右.視線 = ev;
    					}
    					if (cha.Bod.Is額眼)
    					{
    						ev = s * (cha.CP - cha.Bod.額目.位置).newNormalize() * 0.00089;
    						cha.Bod.額目.視線 = ev;
    					}
    					if (cha.Bod.Is単眼)
    					{
    						ev = s * (cha.CP - cha.Bod.単眼目.位置).newNormalize() * 0.003;
    						cha.Bod.単眼目.視線 = ev;
    					}
    				}
    				else
    				{
    					if (cha.Bod.Is双眼)
    					{
    						cha.Bod.目左.視線 = s * (cha.CP - cha.Bod.目左.位置).newNormalize() * 0.002;
    						cha.Bod.目右.視線 = s * (cha.CP - cha.Bod.目右.位置).newNormalize() * 0.002;
    					}
    					if (cha.Bod.Is頬眼)
    					{
    						cha.Bod.頬目左.視線 = s * (cha.CP - cha.Bod.頬目左.位置).newNormalize() * 0.00089;
    						cha.Bod.頬目右.視線 = s * (cha.CP - cha.Bod.頬目右.位置).newNormalize() * 0.00089;
    					}
    					if (cha.Bod.Is額眼)
    					{
    						cha.Bod.額目.視線 = s * (cha.CP - cha.Bod.額目.位置).newNormalize() * 0.00089;
    					}
    					if (cha.Bod.Is単眼)
    					{
    						cha.Bod.単眼目.視線 = s * (cha.CP - cha.Bod.単眼目.位置).newNormalize() * 0.003;
    					}
    				}
    			},
    			Reaing = delegate
    			{
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(EyeTracking.GetHashCode().ToString(), EyeTracking);
    		double l = 1.0;
    		絶頂終了 = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 0.2 - 0.15 * 絶頂時間,
    			Staing = delegate(Mot m)
    			{
    				m.BaseSpeed = 0.2 - 0.15 * cha.絶頂時間;
    				l = 1.0;
    			},
    			Runing = delegate(Mot m)
    			{
    				l = m.Value.Inverse();
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				cha.絶頂.End();
    				Player.絶頂終了処理();
    			}
    		};
    		Mots.Add(絶頂終了.GetHashCode().ToString(), 絶頂終了);
    		double kv = 0.0;
    		Par pa = Bod.Waist.Body.CurJoinRoot;
    		Par pb = null;
    		Vector2D vec = Dat.Vec2DZero;
    		Action 腰接続 = delegate
    		{
    			pb = cha.Bod.Waist.Body.CurJoinRoot;
    			vec = pb.ToGlobal(pb.JP[5].Joint) - pa.ToGlobal(pa.JP[5].Joint);
    			if (cha.Bod.IsWaist)
    			{
    				if (cha.重Waist)
    				{
    					cha.Bod.EIWaist.PositionCont = vec;
    				}
    				else
    				{
    					cha.Bod.EIWaist.Updatef = true;
    				}
    			}
    			if (cha.Bod.Is半後)
    			{
    				if (cha.重半後)
    				{
    					cha.Bod.EI半後.PositionCont = vec;
    				}
    				else
    				{
    					cha.Bod.EI半後.Updatef = true;
    				}
    			}
    			if (cha.Bod.Is半中1)
    			{
    				if (cha.重半中1)
    				{
    					cha.Bod.EI半中1.PositionCont = vec;
    				}
    				else
    				{
    					cha.Bod.EI半中1.Updatef = true;
    				}
    			}
    			if (cha.Bod.Is半中2)
    			{
    				if (cha.重半中2)
    				{
    					cha.Bod.EI半中2.PositionCont = vec;
    				}
    				else
    				{
    					cha.Bod.EI半中2.Updatef = true;
    				}
    			}
    			if (cha.Bod.Is半前)
    			{
    				if (cha.重半前)
    				{
    					cha.Bod.EI半前.PositionCont = vec;
    				}
    				else
    				{
    					cha.Bod.EI半前.Updatef = true;
    				}
    			}
    			if (cha.Bod.Is腿)
    			{
    				if (cha.重腿)
    				{
    					cha.Bod.EI腿.PositionCont = vec;
    				}
    				else
    				{
    					cha.Bod.EI腿.Updatef = true;
    				}
    			}
    		};
    		double d;
    		絶頂 = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 20.0,
    			Staing = delegate
    			{
    				kv = cha.Bod.Waist.Yv;
    				cha.絶頂終了.Start();
    			},
    			Runing = delegate(Mot m)
    			{
    				d = 5.0 * (0.15 + cha.絶頂激しさ) * m.Value.Sin() * RNG.XS.NextDouble() * l;
    				if (cha.Bod.Arm人n > 0)
    				{
    					cha.腕人絶頂(d);
    				}
    				if (cha.Bod.腕翼鳥n > 0)
    				{
    					cha.腕翼鳥絶頂(d);
    				}
    				if (cha.Bod.腕翼獣n > 0)
    				{
    					cha.腕翼獣絶頂(d);
    				}
    				if (cha.Bod.腕獣n > 0)
    				{
    					cha.腕獣絶頂(d);
    				}
    				if (cha.Bod.Is触覚他)
    				{
    					cha.触覚絶頂(d);
    				}
    				if (cha.Bod.Is触覚甲)
    				{
    					cha.触覚甲絶頂(d);
    				}
    				if (cha.Bod.大顎n > 0)
    				{
    					cha.大顎絶頂(d);
    				}
    				if (cha.Bod.虫顎n > 0)
    				{
    					cha.虫顎絶頂(d);
    				}
    				if (cha.Bod.鰭n > 0)
    				{
    					cha.鰭絶頂(d);
    				}
    				if (cha.Bod.葉n > 0)
    				{
    					cha.葉絶頂(d);
    				}
    				if (cha.Bod.前翅1n > 0)
    				{
    					cha.前翅絶頂(d);
    				}
    				if (cha.Bod.後翅1n > 0)
    				{
    					cha.後翅絶頂(d);
    				}
    				if (cha.Bod.触肢蜘n > 0)
    				{
    					cha.触肢蜘絶頂(d);
    				}
    				if (cha.Bod.触肢蠍n > 0)
    				{
    					cha.触肢蠍絶頂(d);
    				}
    				if (cha.Bod.節足蜘n > 0)
    				{
    					cha.節足蜘絶頂(d);
    				}
    				if (cha.Bod.節足蠍n > 0)
    				{
    					cha.節足蠍絶頂(d);
    				}
    				if (cha.Bod.節足百n > 0)
    				{
    					cha.節足百絶頂(d);
    				}
    				if (cha.Bod.節尾曳n > 0)
    				{
    					cha.節尾曳絶頂(d);
    				}
    				if (cha.Bod.節尾鋏n > 0)
    				{
    					cha.節尾鋏絶頂(d);
    				}
    				if (cha.Bod.虫鎌n > 0)
    				{
    					cha.虫鎌絶頂(d);
    				}
    				if (cha.Bod.触手n > 0)
    				{
    					cha.触手絶頂(d);
    				}
    				if (cha.Bod.触手犬n > 0)
    				{
    					cha.触手犬絶頂(d);
    				}
    				if (cha.Bod.尾n > 0)
    				{
    					cha.尾絶頂(d);
    				}
    				if (cha.Bod.Is植)
    				{
    					cha.植絶頂(d);
    				}
    				if (cha.Bod.脚人n > 0)
    				{
    					cha.脚人絶頂(d);
    				}
    				if (cha.Bod.脚獣n > 0)
    				{
    					cha.脚獣絶頂(d);
    				}
    				cha.Bod.腰振りv = d * RNG.XS.NextDouble();
    				cha.Bod.Waist.位置C = new Vector2D(0.0, 0.0005 * d);
    				cha.Bod.乳房左.位置C = cha.Bod.Waist.位置C;
    				cha.Bod.乳房右.位置C = cha.Bod.Waist.位置C;
    				if (cha.Bod.Is腕前)
    				{
    					cha.Bod.EI腕前.Updatef = true;
    				}
    				腰接続();
    				Player.絶頂中処理();
    				if (0.3.Lot())
    				{
    					Player.奴体力消費中();
    				}
    			},
    			Reaing = delegate
    			{
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				cha.Bod.腰振り_人v = kv;
    				cha.Bod.Waist.位置C = Dat.Vec2DZero;
    				if (!cha.Bod.乳房左.着衣)
    				{
    					cha.Bod.乳房左.位置C = Dat.Vec2DZero;
    					cha.Bod.乳房右.位置C = Dat.Vec2DZero;
    				}
    				if (cha.Bod.IsWaist)
    				{
    					cha.Bod.EIWaist.PositionCont = Dat.Vec2DZero;
    				}
    				if (cha.Bod.Is半後)
    				{
    					cha.Bod.EI半後.PositionCont = Dat.Vec2DZero;
    				}
    				if (cha.Bod.Is半中1)
    				{
    					cha.Bod.EI半中1.PositionCont = Dat.Vec2DZero;
    				}
    				if (cha.Bod.Is半中2)
    				{
    					cha.Bod.EI半中2.PositionCont = Dat.Vec2DZero;
    				}
    				if (cha.Bod.Is半前)
    				{
    					cha.Bod.EI半前.PositionCont = Dat.Vec2DZero;
    				}
    				if (cha.Bod.Is腿)
    				{
    					cha.Bod.EI腿.PositionCont = Dat.Vec2DZero;
    				}
    			}
    		};
    		Mots.Add(絶頂.GetHashCode().ToString(), 絶頂);
    		Stopwatch 肛sw = new Stopwatch();
    		肛ヒク = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			Staing = delegate
    			{
    				肛sw.Restart();
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.Bod.肛門C = 0.5 + m.Value.Sin() * RNG.XS.NextDouble() * 0.5;
    				if (肛sw.ElapsedMilliseconds > 5000)
    				{
    					m.End();
    				}
    			},
    			Reaing = delegate
    			{
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				肛sw.Stop();
    				cha.Bod.肛門C = 1.0;
    			}
    		};
    		Mots.Add(肛ヒク.GetHashCode().ToString(), 肛ヒク);
    		Stopwatch 膣sw = new Stopwatch();
    		膣ヒク = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			Staing = delegate
    			{
    				膣sw.Restart();
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.Bod.膣腔C = 1.0 + m.Value.Sin() * RNG.XS.NextDouble() * 0.5;
    				if (膣sw.ElapsedMilliseconds > 5000)
    				{
    					m.End();
    				}
    			},
    			Reaing = delegate
    			{
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				膣sw.Stop();
    				cha.Bod.膣腔C = 1.0;
    			}
    		};
    		Mots.Add(膣ヒク.GetHashCode().ToString(), 膣ヒク);
    		Stopwatch 糸sw = new Stopwatch();
    		糸ヒク = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 0.1,
    			Staing = delegate
    			{
    				糸sw.Restart();
    			},
    			Runing = delegate(Mot m)
    			{
    				if (cha.Bod.Is蜘尾)
    				{
    					cha.Bod.出糸C = m.Value.Sin() * 30.0;
    				}
    				if (糸sw.ElapsedMilliseconds > 5000)
    				{
    					m.End();
    				}
    			},
    			Reaing = delegate
    			{
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    				糸sw.Stop();
    				if (cha.Bod.Is蜘尾)
    				{
    					cha.Bod.出糸C = 0.0;
    				}
    			}
    		};
    		Mots.Add(糸ヒク.GetHashCode().ToString(), 糸ヒク);
    		bool 顔面開き = false;
    		bool Is展開 = Bod.Is顔面 || Bod.Is大顎基;
    		顔面 顔面 = Bod.顔面;
    		大顎基 大顎 = Bod.頭.大顎基_接続.GetEle<大顎基>();
    		角1_虫 虫角 = Bod.頭.額_接続.GetEle<角1_虫>();
    		double o_ = 0.0;
    		顔面展開 = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 5.0,
    			Staing = delegate
    			{
    				if (Is展開)
    				{
    					顔面開き = o_ == 1.0;
    				}
    			},
    			Runing = delegate(Mot m)
    			{
    				if (Is展開)
    				{
    					if (顔面開き)
    					{
    						o_ = m.Value.Inverse();
    					}
    					else
    					{
    						o_ = m.Value;
    					}
    					if (cha.Bod.Is顔面)
    					{
    						顔面.展開0 = o_;
    						顔面.展開1 = o_;
    					}
    					if (cha.Bod.Is大顎基)
    					{
    						大顎.展開 = o_;
    					}
    					if (cha.Bod.Is虫角)
    					{
    						虫角.展開 = o_;
    					}
    				}
    			},
    			Reaing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate
    			{
    			}
    		};
    		Mots.Add(顔面展開.GetHashCode().ToString(), 顔面展開);
    		Vector2D p_ = Dat.Vec2DZero;
    		double d_;
    		体揺れ = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 7.0,
    			Staing = delegate
    			{
    			},
    			Runing = delegate(Mot m)
    			{
    				d_ = 2.0 * m.Value;
    				if (cha.Bod.Arm人n > 0)
    				{
    					cha.腕人絶頂(d_);
    				}
    				if (cha.Bod.腕翼鳥n > 0)
    				{
    					cha.腕翼鳥絶頂(d_);
    				}
    				if (cha.Bod.腕翼獣n > 0)
    				{
    					cha.腕翼獣絶頂(d_);
    				}
    				if (cha.Bod.腕獣n > 0)
    				{
    					cha.腕獣絶頂(d_);
    				}
    				if (cha.Bod.Is触覚他)
    				{
    					cha.触覚絶頂(d_);
    				}
    				if (cha.Bod.Is触覚甲)
    				{
    					cha.触覚甲絶頂(d_);
    				}
    				if (cha.Bod.大顎n > 0)
    				{
    					cha.大顎絶頂(d_);
    				}
    				if (cha.Bod.虫顎n > 0)
    				{
    					cha.虫顎絶頂(d_);
    				}
    				if (cha.Bod.鰭n > 0)
    				{
    					cha.鰭絶頂(d_);
    				}
    				if (cha.Bod.葉n > 0)
    				{
    					cha.葉絶頂(d_);
    				}
    				if (cha.Bod.前翅1n > 0)
    				{
    					cha.前翅絶頂(0.0 - d_);
    				}
    				if (cha.Bod.後翅1n > 0)
    				{
    					cha.後翅絶頂(0.0 - d_);
    				}
    				if (cha.Bod.触肢蜘n > 0)
    				{
    					cha.触肢蜘絶頂(d_);
    				}
    				if (cha.Bod.触肢蠍n > 0)
    				{
    					cha.触肢蠍絶頂(d_);
    				}
    				if (cha.Bod.節足蜘n > 0)
    				{
    					cha.節足蜘絶頂(d_);
    				}
    				if (cha.Bod.節足蠍n > 0)
    				{
    					cha.節足蠍絶頂(d_);
    				}
    				if (cha.Bod.節足百n > 0)
    				{
    					cha.節足百絶頂(d_);
    				}
    				if (cha.Bod.節尾曳n > 0)
    				{
    					cha.節尾曳絶頂(d_);
    				}
    				if (cha.Bod.節尾鋏n > 0)
    				{
    					cha.節尾鋏絶頂(d_);
    				}
    				if (cha.Bod.虫鎌n > 0)
    				{
    					cha.虫鎌絶頂(d_);
    				}
    				if (cha.Bod.触手n > 0)
    				{
    					cha.触手絶頂(d_);
    				}
    				if (cha.Bod.触手犬n > 0)
    				{
    					cha.触手犬絶頂(d_);
    				}
    				if (cha.Bod.尾n > 0)
    				{
    					cha.尾絶頂(d_);
    				}
    				if (cha.Bod.Is植)
    				{
    					cha.植絶頂(d_);
    				}
    				if (cha.Bod.脚人n > 0)
    				{
    					cha.脚人絶頂(d_);
    				}
    				if (cha.Bod.脚獣n > 0)
    				{
    					cha.脚獣絶頂(d_);
    				}
    				p_.Y = -0.001 * m.Value;
    				cha.Bod.Waist.位置C = p_;
    				cha.Bod.乳房左.位置C = cha.Bod.Waist.位置C;
    				cha.Bod.乳房右.位置C = cha.Bod.Waist.位置C;
    				if (cha.Bod.Is髪)
    				{
    					if (cha.重髪)
    					{
    						cha.Bod.EI髪.Position = p_;
    					}
    					else
    					{
    						cha.Bod.EI髪.Updatef = true;
    					}
    				}
    				if (cha.Bod.IsChest)
    				{
    					if (cha.重胸)
    					{
    						cha.Bod.EIChest.Position = p_;
    					}
    					else
    					{
    						cha.Bod.EIChest.Updatef = true;
    					}
    				}
    				if (cha.Bod.IsWaist)
    				{
    					if (cha.重Waist)
    					{
    						cha.Bod.EIWaist.Position = p_;
    					}
    					else
    					{
    						cha.Bod.EIWaist.Updatef = true;
    					}
    				}
    				if (cha.Bod.Is腕前)
    				{
    					if (cha.重腕前)
    					{
    						cha.Bod.EI腕前.Position = p_;
    					}
    					else
    					{
    						cha.Bod.EI腕前.Updatef = true;
    					}
    				}
    				if (cha.Bod.Is半後)
    				{
    					if (cha.重半後)
    					{
    						cha.Bod.EI半後.Position = p_;
    					}
    					else
    					{
    						cha.Bod.EI半後.Updatef = true;
    					}
    				}
    				if (cha.Bod.Is半中1)
    				{
    					if (cha.重半中1)
    					{
    						cha.Bod.EI半中1.Position = p_;
    					}
    					else
    					{
    						cha.Bod.EI半中1.Updatef = true;
    					}
    				}
    				if (cha.Bod.Is半中2)
    				{
    					if (cha.重半中2)
    					{
    						cha.Bod.EI半中2.Position = p_;
    					}
    					else
    					{
    						cha.Bod.EI半中2.Updatef = true;
    					}
    				}
    				if (cha.Bod.Is半前)
    				{
    					if (cha.重半前)
    					{
    						cha.Bod.EI半前.Position = p_;
    					}
    					else
    					{
    						cha.Bod.EI半前.Updatef = true;
    					}
    				}
    				if (cha.Bod.Is腿)
    				{
    					if (cha.重腿)
    					{
    						cha.Bod.EI腿.Position = p_;
    					}
    					else
    					{
    						cha.Bod.EI腿.Updatef = true;
    					}
    				}
    			},
    			Reaing = delegate
    			{
    			},
    			Rouing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Ending = delegate
    			{
    				cha.Bod.Waist.位置C = Dat.Vec2DZero;
    				if (!cha.Bod.乳房左.着衣)
    				{
    					cha.Bod.乳房左.位置C = Dat.Vec2DZero;
    					cha.Bod.乳房右.位置C = Dat.Vec2DZero;
    				}
    				if (cha.Bod.Is髪)
    				{
    					cha.Bod.EI髪.Position = Dat.Vec2DZero;
    				}
    				if (cha.Bod.IsChest)
    				{
    					cha.Bod.EIChest.Position = Dat.Vec2DZero;
    				}
    				if (cha.Bod.IsWaist)
    				{
    					cha.Bod.EIWaist.Position = Dat.Vec2DZero;
    				}
    				if (cha.Bod.Is腕前)
    				{
    					cha.Bod.EI腕前.Position = Dat.Vec2DZero;
    				}
    				if (cha.Bod.Is半後)
    				{
    					cha.Bod.EI半後.Position = Dat.Vec2DZero;
    				}
    				if (cha.Bod.Is半中1)
    				{
    					cha.Bod.EI半中1.Position = Dat.Vec2DZero;
    				}
    				if (cha.Bod.Is半中2)
    				{
    					cha.Bod.EI半中2.Position = Dat.Vec2DZero;
    				}
    				if (cha.Bod.Is半前)
    				{
    					cha.Bod.EI半前.Position = Dat.Vec2DZero;
    				}
    				if (cha.Bod.Is腿)
    				{
    					cha.Bod.EI腿.Position = Dat.Vec2DZero;
    				}
    			}
    		};
    		Mots.Add(体揺れ.GetHashCode().ToString(), 体揺れ);
    		int c_ = 0;
    		int 咳込み数 = 1;
    		Coughing = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 10.0,
    			GotoSpeed = 0.5,
    			RetuSpeed = 2.0,
    			Staing = delegate
    			{
    				cha.UpdateExpression();
    				if (cha.Bod.Is双眼)
    				{
    					cha.両瞼_1(RNG.XS.Next(1, 4), RNG.XS.Next(1, 4));
    				}
    				else if (cha.Bod.Is単眼)
    				{
    					cha.単瞼_1(RNG.XS.Next(1, 4));
    				}
    				if (cha.Bod.Is頬眼)
    				{
    					cha.両頬瞼_1(RNG.XS.Next(1, 4), RNG.XS.Next(1, 4));
    				}
    				if (cha.Bod.Is額眼)
    				{
    					cha.額瞼_1(RNG.XS.Next(1, 4));
    				}
    				c_ = 0;
    				咳込み数 = RNG.XS.NextM(1, 2) + Player.UI.ペニス処理.中出しCount / 2;
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.呼吸値 = m.Value;
    			},
    			Reaing = delegate
    			{
    				cha.唾散.Start();
    				if ((Player.UI.ペニス処理.中出し || cha.Crying) && 0.18.Lot())
    				{
    					cha.鼻水.Start();
    				}
    				if (Player.UI.ペニス処理.中出し && 0.25.Lot())
    				{
    					cha.涎.Start();
    				}
    			},
    			Rouing = delegate(Mot m)
    			{
    				c_++;
    				if (c_ >= 咳込み数)
    				{
    					m.End();
    				}
    			},
    			Ending = delegate
    			{
    				cha.SetInitialExpression();
    				cha.口();
    			}
    		};
    		Mots.Add(Coughing.GetHashCode().ToString(), Coughing);
    		double 中出度_ = 0.0;
    		ごっくん = new Mot(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			Staing = delegate
    			{
    				cha.UpdateExpression();
    				cha.口_紡ぎ();
    				中出度_ = cha.中出度;
    			},
    			Runing = delegate(Mot m)
    			{
    				cha.呼吸値 = m.Value;
    			},
    			Reaing = delegate
    			{
    			},
    			Rouing = delegate(Mot m)
    			{
    				m.End();
    			},
    			Ending = delegate
    			{
    				if (RNG.XS.NextBool())
    				{
    					//Sounds.挿抜口1.Play();
    				}
    				else
    				{
    					//Sounds.挿抜口2.Play();
    				}
    				ChaD.Stamina = (ChaD.Stamina + 0.3 * 中出度_).Clamp(0.0, 1.0);
    			}
    		};
    		Mots.Add(ごっくん.GetHashCode().ToString(), ごっくん);
    		Mots.Drive(Med.FPSF);
    		Med.SetUniqueColor(Bod.Elements.Select((Ele e) => e.Body.EnumAllPar()).JoinEnum());
    		汗掻き = new Sweat(Med, Are, this, Mots);
    		汗かき = 汗掻き.汗かき;
    		Bod.汗掻き = 汗掻き;
    		this.SetInitialAngle();
    	}

    	public void Draw(RenderArea Are, FPS FPS)
    	{
    		this.FPS = FPS.Value;
    		Mots.Drive(FPS);
    		Bod.描画(Are);
    	}

    	public void Dispose()
    	{
    		Bod.Dispose();
    		汗掻き.Dispose();
    		Med.RemUniqueColor(Bod.Elements.Select((Ele e) => e.Body.EnumAllPar()).JoinEnum());
    	}

    	public void Set衣装(IEnumerable<object> 衣装)
    	{
    		Bod.脱衣();
    		Dictionary<Type, int> dictionary = new Dictionary<Type, int>();
    		Dictionary<Type, PropertyInfo[]> dictionary2 = new Dictionary<Type, PropertyInfo[]>();
    		string ts;
    		foreach (object item in 衣装)
    		{
    			Type type = item.GetType();
    			ts = type.ToString();
    			if (dictionary.ContainsKey(type))
    			{
    				dictionary2[type][dictionary[type]].SetValue(Bod, item, null);
    				dictionary[type]++;
    				continue;
    			}
    			dictionary.Add(type, 0);
    			dictionary2.Add(type, (from e in Sta.Bodt.GetProperties()
    				where e.PropertyType.ToString() == ts
    				select e).ToArray());
    			dictionary2[type][dictionary[type]].SetValue(Bod, item, null);
    			dictionary[type]++;
    		}
    		if (!ChaD.股施術 && Bod.Is股防御())
    		{
    			Bod.Setピアス = Sta.ピアス初期化;
    		}
    		if (!ChaD.胸施術 && Bod.Is胸甲殻())
    		{
    			Bod.Setピアス左 = Sta.ピアス初期化;
    			Bod.Setピアス右 = Sta.ピアス初期化;
    		}
    	}

        public ContactD GetContact(ref Color HitColor)
        {
            ContactD result = default(ContactD);
            result.e = this.Bod.GetHitEle(HitColor);
            if (result.e != null)
            {
                result.p = result.e.Body.GetHitPar_(HitColor);
                bool flag = false;
                bool flag2 = result.e is Shoulder || result.e is UpperArm || result.e is LowerArm || result.e is 手 || result.e is 四足脇 || result.e is 腿 || result.e is Leg || result.e is 足 || result.e is 鰭 || result.e is 葉 || result.e is 前翅 || result.e is 後翅 || result.e is 触肢 || result.e is 節足 || result.e is 節尾 || result.e is 大顎 || result.e is 虫顎 || result.e is 虫鎌 || result.e is 触手;
                if (result.e is 前髪 || result.e is 頭頂)
                {
                    result.c = ContactType.Head;
                }
                else if (result.e is 耳 || result.e is 獣耳)
                {
                    result.c = ContactType.Ear;
                }
                else if (this.Bod.Is口腔())
                {
                    result.c = ContactType.Mouth;
                }
                else if (result.e is Head)
                {
                    result.c = ContactType.Face;
                }
                else if (result.e is SideHair || result.e is BackHair0 || result.e is BackHair1 || result.e is 基髪)
                {
                    result.c = ContactType.Hair;
                }
                else if (result.e is Neck)
                {
                    result.c = ContactType.Neck;
                }
                else if (result.e is Shoulder)
                {
                    result.c = ContactType.Shoulder;
                }
                else if (!flag2 && !this.Bod.乳房左.虫性_甲殻_表示 && !(result.p.Tag == "乳房") && this.Bod.Is乳首())
                {
                    result.c = ContactType.Milk;
                }
                else if (result.e is 乳房)
                {
                    result.c = ContactType.Chest;
                }
                else if (result.e is Chest)
                {
                    result.c = ContactType.Side;
                }
                else if (((result.e is Waist || result.e is 四足腰) && result.p != null && result.p.Tag == "下腹") || result.e is ボテ腹)
                {
                    result.c = ContactType.Stomache;
                }
                else if ((flag = !flag2 && this.Bod.Isくぱぁ()) && result.e is 肛門)
                {
                    result.c = ContactType.Anal;
                }
                else if (flag && this.Bod.Is陰核())
                {
                    result.c = ContactType.Nucleus;
                }
                else if (flag && this.Bod.Is膣口())
                {
                    result.c = ContactType.Vagina;
                }
                else if (flag && result.e is 性器)
                {
                    result.c = ContactType.Sex;
                }
                else if (flag && this.Bod.Is局部())
                {
                    result.c = ContactType.Crotch;
                }
                else if (result.e is 尾_蜘 && (result.p.Tag.Contains("出糸突起左") || result.p.Tag.Contains("出糸突起中") || result.p.Tag.Contains("出糸突起右")))
                {
                    result.c = ContactType.Thread;
                }
                else if (result.e.ConnectionType.ToString().Contains("腿") && !result.e.ConnectionType.Is左右無し())
                {
                    result.c = ContactType.Thigh;
                }
                else if (result.e is 足_人)
                {
                    result.c = ContactType.Feet;
                }
                else if (result.e is 手_人)
                {
                    result.c = ContactType.Hand;
                }
                else if (result.e is 触覚)
                {
                    result.c = ContactType.Awareness;
                }
                else if (result.e is 触手)
                {
                    result.c = ContactType.Touch;
                }
                else if (result.e.ConnectionType.ToString().Contains("尾"))
                {
                    result.c = ContactType.Tail;
                }
                else if (result.e is 前翅 || result.e is 後翅 || result.e is UpperArm_鳥 || result.e is LowerArm_鳥 || result.e is 手_鳥 || result.e is UpperArm_蝙 || result.e is LowerArm_蝙 || result.e is 手_蝙)
                {
                    result.c = ContactType.Wing;
                }
                else if (result.e is 鰭)
                {
                    result.c = ContactType.Fin;
                }
                else
                {
                    result.c = ContactType.Other;
                }
            }
            return result;
        }
    }
}
