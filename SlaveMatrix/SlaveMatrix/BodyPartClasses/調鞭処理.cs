using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 調鞭処理 : 処理B
    {
    	public 衝撃 衝撃;

    	public Motion 鞭撃モーション;

    	private Motion 衝撃モーション;

    	private Vector2D v;

    	private Vector2D o;

    	private int x;

    	private MouseButtons mb;

    	private double 強さ_ => 0.35 + base.強度 * 0.65;

    	public void 振り()
    	{
    		調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    		{
    			調教UI.擬音.Sound(a, 対象.Element.位置.GetAreaPoint(0.05), Sta.鞭振.GetVal(強さ_, 1.0), new Font("MS Gothic", 1f), Col.White, 0.2 + 0.2 * 強さ_, b: true);
    		});
    	}

    	public void 打ち(Vector2D p)
    	{
    		調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    		{
    			調教UI.擬音.Sound(a, Sta.GetAreaPoint(ref p, 0.01), Sta.鞭打.GetVal(強さ_, RNG.XS.NextDouble()), new Font("MS Gothic", 1f), Color.Red.S(強さ_.Clamp(0.5, 1.0)), 0.2 + 0.1 * 強さ_, b: true);
    		});
    	}

    	private void 移動時()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = "LCl:" + GameText.左打 + "\r\nRCl:" + GameText.右打 + "\r\nWh:" + GameText.強さL + 強さ + "\r\nMCl:" + GameText.放す;
    		}
    	}

    	public void Move(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus == 対象)
    		{
    			調教UI.放し();
    			v = cp;
    			x = (o.X - v.X).Sign();
    			o = v;
    			対象.Element.角度C = 0.0;
    			対象.Element.Xi = 0;
    			対象.Element.Yi = (対象.Element.Yi + x).Limit(0, 対象.Element.Body.CountY);
    			対象.Element.Body.JoinPA();
    			移動時();
    		}
    	}

    	public void Down(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus == 対象)
    		{
    			if (!選択)
    			{
    				選択 = true;
    			}
    			else if (mb == MouseButtons.Left || mb == MouseButtons.Right)
    			{
    				調教UI.押し(ref cd);
    				this.mb = mb;
    				鞭撃モーション.Start();
    				移動時();
    			}
    			else if (mb == MouseButtons.Middle)
    			{
    				鞭撃モーション.End();
    				衝撃モーション.End();
    				調教UI.通常放し();
    			}
    		}
    	}

    	public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
    	{
    	}

    	public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
    	{
    	}

    	public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc)
    	{
    		if (調教UI.Focus == 対象)
    		{
    			強さ = (強さ + dt.Sign()).Clamp(1, 3);
    			鞭撃モーション.BaseSpeed = 10.0 * 強さ_;
    			if (!Sta.GameData.ガイド)
    			{
    				ip.SubInfoIm = "Wh:" + GameText.強さL + 強さ;
    			}
    			else
    			{
    				移動時();
    			}
    		}
    	}

    	public 調鞭処理(TrainingUI 調教UI, CharacterElement 調教鞭)
    		: base(調教UI, 調教鞭)
    	{
    		調鞭処理 調鞭処理2 = this;
    		調教鞭 鞭 = 調教UI.調教鞭;
    		bool l = false;
    		ShapePart p;
    		Vector2D cp;
    		Color hc;
    		鞭撃モーション = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 10.0 * 強さ_,
    			OnStart = delegate
    			{
    				l = 調鞭処理2.mb == MouseButtons.Left;
    				鞭.Xi = 1;
    				if (l)
    				{
    					鞭.Yi = 0;
    				}
    				else
    				{
    					鞭.Yi = 4;
    				}
    				鞭.鞭撃エフェクト1_表示 = true;
    				鞭.鞭撃エフェクト2_表示 = true;
    				鞭.鞭撃エフェクト1CD.不透明度 = 調鞭処理2.強度;
    				鞭.鞭撃エフェクト2CD.不透明度 = 調鞭処理2.強度;
    				調鞭処理2.振り();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (l)
    				{
    					鞭.角度C = 100.0 * m.Value;
    				}
    				else
    				{
    					鞭.角度C = -100.0 * m.Value;
    				}
    				p = 鞭.Body.Current.EnumAllPar().First((ShapePart e) => e.Tag.Contains("先"));
    				cp = p.ToGlobal(p.JP[0].Joint);
    				hc = 調鞭処理2.Med.GetHitColor(調鞭処理2.Med.FromBasePosition(cp));
    				if (調教UI.Bod.IsHit(hc))
    				{
    					調鞭処理2.衝撃.位置B = cp;
    					調鞭処理2.衝撃モーション.Start();
    					if (調鞭処理2.強度 > 0.5)
    					{
    						調鞭処理2.Bod.Add鞭痕(cp, hc);
    					}
    					調教UI.Action(調鞭処理2.Cha.GetContact(ref hc).c, ActionType.Whipping, CurrentState.Start, ToolType.調教鞭, 0, 調鞭処理2.強さ, 機械: false, 射精: false);
    					if (0.5.Lot())
    					{
    						Player.奴体力消費大();
    					}
    					調鞭処理2.打ち(cp);
    				}
    			},
    			OnReach = delegate(Motion m)
    			{
    				鞭.鞭撃エフェクト1_表示 = false;
    				鞭.鞭撃エフェクト2_表示 = false;
    				if (l)
    				{
    					鞭.Yi = 4;
    				}
    				else
    				{
    					鞭.Yi = 0;
    				}
    				鞭.Body.JoinPA();
    				m.End();
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate(Motion m)
    			{
    				m.ResetValue();
    			}
    		};
    		調教UI.Mots.Add(鞭撃モーション.GetHashCode().ToString(), 鞭撃モーション);
    		衝撃 = new 衝撃(Are.DisplayUnitScale, 配色指定.N0, null, Med, new 衝撃D
    		{
    			表示 = false
    		});
    		衝撃.尺度B = 1.2;
    		衝撃モーション = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 5.0,
    			OnStart = delegate
    			{
    				調鞭処理2.衝撃.表示 = true;
    				調鞭処理2.衝撃.角度C = 360.0 * RNG.XS.NextDouble();
    				調鞭処理2.衝撃.尺度C = 0.0;
    				//TODO fix?
    				//Sounds.鞭撃.Play();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				調鞭処理2.衝撃.尺度C = m.Value * 調鞭処理2.強さ_;
    			},
    			OnReach = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate(Motion m)
    			{
    				調鞭処理2.衝撃.表示 = false;
    				m.ResetValue();
    			}
    		};
    		調教UI.Mots.Add(衝撃モーション.GetHashCode().ToString(), 衝撃モーション);
    	}

    	public void SetCha(Character Cha)
    	{
    		base.Cha = Cha;
    		Bod = Cha.Body;
    	}

    	public new void Reset()
    	{
    		base.Reset();
    		鞭撃モーション?.End();
    		衝撃モーション?.End();
    		v = default(Vector2D);
    		o = default(Vector2D);
    		x = 0;
    		mb = MouseButtons.None;
    	}
    }
}
