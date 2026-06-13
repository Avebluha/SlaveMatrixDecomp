using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 羽箒処理 : 処理B
    {
    	public bool Is擽り;

    	private Motion 擽りモーション;

    	private ハンド ハンド右;

    	private readonly double xc;

    	private string 擽り時()
    	{
    		return "LUp:" + GameText.やめる + "\r\nWh:" + GameText.強さL + 強さ + "\r\nRCl:" + GameText.放す;
    	}

    	private string 待機時()
    	{
    		return (調教UI.Bod.IsHit(調教UI.羽根箒先端hc) ? ("LDo:" + GameText.擽り + "\r\n") : "") + "Wh:" + GameText.強さL + 強さ + "\r\nRCl:" + GameText.放す;
    	}

    	private void 移動時()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			if (Is擽り)
    			{
    				ip.SubInfoIm = 擽り時();
    			}
    			else
    			{
    				ip.SubInfoIm = 待機時();
    			}
    		}
    	}

    	public void Move(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus != 対象)
    		{
    			return;
    		}
    		if (Is擽り)
    		{
    			Color HitColor = 調教UI.羽根箒先端hc;
    			if (調教UI.Bod.IsHit(HitColor))
    			{
    				if (!調教UI.押し状態)
    				{
    					調教UI.押し(ref cd);
    					調教UI.Action(Cha.GetContact(ref HitColor).c, ActionType.Contact, CurrentState.Start, ToolType.羽根箒, 0, 1, 機械: false, 射精: false);
    					Player.奴体力消費小();
    					Player.主精力消費小();
    				}
    				擽りモーション.Start();
    				調教UI.Action(Cha.GetContact(ref HitColor).c, ActionType.Contact, CurrentState.Continue, ToolType.羽根箒, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			}
    			else if (調教UI.押し状態)
    			{
    				調教UI.Action(Cha.GetContact(ref HitColor).c, ActionType.Contact, CurrentState.End, ToolType.羽根箒, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    				擽りモーション.End();
    				調教UI.放し();
    			}
    		}
    		if (!対象.Element.右 && cp.X < xc)
    		{
    			対象.Element.右 = !対象.Element.右;
    			対象.Element.Body.JoinPA();
    			ハンド右.X11Y0_小指.ReverseX();
    			ハンド右.X11Y0_薬指.ReverseX();
    			ハンド右.X11Y0_中指.ReverseX();
    			ハンド右.X11Y0_人指.ReverseX();
    			ハンド右.X11Y0_手.ReverseX();
    			ハンド右.X11Y0_親指.ReverseX();
    			ハンド右.X11Y0_呪印_輪1_輪外.ReverseX();
    			ハンド右.X11Y0_呪印_輪1_輪内.ReverseX();
    			ハンド右.X11Y0_呪印_輪2_輪外.ReverseX();
    			ハンド右.X11Y0_呪印_輪2_輪内.ReverseX();
    			ハンド右.X11Y0_呪印_輪3_輪外.ReverseX();
    			ハンド右.X11Y0_呪印_輪3_輪内.ReverseX();
    			ハンド右.X11Y0_呪印_鎖1.ReverseX();
    			ハンド右.X11Y0_呪印_鎖3.ReverseX();
    			ハンド右.Body.JoinPA();
    		}
    		else if (対象.Element.右 && cp.X > xc)
    		{
    			対象.Element.右 = !対象.Element.右;
    			対象.Element.Body.JoinPA();
    			ハンド右.X11Y0_小指.ReverseX();
    			ハンド右.X11Y0_薬指.ReverseX();
    			ハンド右.X11Y0_中指.ReverseX();
    			ハンド右.X11Y0_人指.ReverseX();
    			ハンド右.X11Y0_手.ReverseX();
    			ハンド右.X11Y0_親指.ReverseX();
    			ハンド右.X11Y0_呪印_輪1_輪外.ReverseX();
    			ハンド右.X11Y0_呪印_輪1_輪内.ReverseX();
    			ハンド右.X11Y0_呪印_輪2_輪外.ReverseX();
    			ハンド右.X11Y0_呪印_輪2_輪内.ReverseX();
    			ハンド右.X11Y0_呪印_輪3_輪外.ReverseX();
    			ハンド右.X11Y0_呪印_輪3_輪内.ReverseX();
    			ハンド右.X11Y0_呪印_鎖1.ReverseX();
    			ハンド右.X11Y0_呪印_鎖3.ReverseX();
    			ハンド右.Body.JoinPA();
    		}
    		移動時();
    	}

    	public void Down(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus != 対象)
    		{
    			return;
    		}
    		if (!選択)
    		{
    			選択 = true;
    			return;
    		}
    		Color HitColor = 調教UI.羽根箒先端hc;
    		if (mb == MouseButtons.Left && 調教UI.Bod.IsHit(HitColor))
    		{
    			調教UI.押し(ref cd);
    			擽りモーション.Start();
    			Is擽り = true;
    			if (Sta.GameData.ガイド)
    			{
    				ip.SubInfoIm = 擽り時();
    			}
    			調教UI.Action(Cha.GetContact(ref HitColor).c, ActionType.Contact, CurrentState.Start, ToolType.羽根箒, 0, 1, 機械: false, 射精: false);
    			Player.奴体力消費小();
    			Player.主精力消費小();
    		}
    		else if (mb == MouseButtons.Right && !Is擽り)
    		{
    			Is擽り = false;
    			擽りモーション.End();
    			if (対象.Element.右)
    			{
    				ハンド右.X11Y0_小指.ReverseX();
    				ハンド右.X11Y0_薬指.ReverseX();
    				ハンド右.X11Y0_中指.ReverseX();
    				ハンド右.X11Y0_人指.ReverseX();
    				ハンド右.X11Y0_手.ReverseX();
    				ハンド右.X11Y0_親指.ReverseX();
    				ハンド右.X11Y0_呪印_輪1_輪外.ReverseX();
    				ハンド右.X11Y0_呪印_輪1_輪内.ReverseX();
    				ハンド右.X11Y0_呪印_輪2_輪外.ReverseX();
    				ハンド右.X11Y0_呪印_輪2_輪内.ReverseX();
    				ハンド右.X11Y0_呪印_輪3_輪外.ReverseX();
    				ハンド右.X11Y0_呪印_輪3_輪内.ReverseX();
    				ハンド右.X11Y0_呪印_鎖1.ReverseX();
    				ハンド右.X11Y0_呪印_鎖3.ReverseX();
    				ハンド右.Body.JoinPA();
    			}
    			調教UI.通常放し();
    			if (Sta.GameData.ガイド)
    			{
    				ip.SubInfoIm = " ";
    			}
    		}
    	}

    	public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus == 対象 && mb == MouseButtons.Left && Is擽り)
    		{
    			Color HitColor = 調教UI.羽根箒先端hc;
    			調教UI.Action(Cha.GetContact(ref HitColor).c, ActionType.Contact, CurrentState.End, ToolType.羽根箒, 0, 1, 機械: false, 射精: false);
    			Player.奴体力消費小();
    			Player.主精力消費小();
    			擽りモーション.End();
    			調教UI.放し();
    			Is擽り = false;
    			if (Sta.GameData.ガイド)
    			{
    				ip.SubInfoIm = 待機時();
    			}
    		}
    	}

    	public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
    	{
    	}

    	public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus == 対象)
    		{
    			強さ = (強さ + dt.Sign()).Clamp(1, 3);
    			擽りモーション.BaseSpeed = 10.0 * base.強度;
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

    	public 羽箒処理(TrainingUI 調教UI, CM 羽根箒)
    		: base(調教UI, 羽根箒)
    	{
    		羽箒処理 羽箒処理2 = this;
    		ハンド右 = 調教UI.ハンド右;
    		xc = Med.Base.LocalCenter.X;
    		Color hc;
    		擽りモーション = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 16.0 * base.強度,
    			OnStart = delegate
    			{
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				羽根箒.Element.角度C = 10.0 * m.Value;
    				hc = 調教UI.羽根箒先端hc;
    				調教UI.Action(羽箒処理2.Cha.GetContact(ref hc).c, ActionType.Tickle, CurrentState.Continue, ToolType.羽根箒, 0, 羽箒処理2.強さ, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate(Motion m)
    			{
    				m.ResetValue();
    				羽根箒.Element.角度C = 0.0;
    			}
    		};
    		調教UI.Mots.Add(擽りモーション.GetHashCode().ToString(), 擽りモーション);
    	}

    	public void SetCha(Character Cha)
    	{
    		base.Cha = Cha;
    		Bod = Cha.Body;
    	}

    	public new void Reset()
    	{
    		base.Reset();
    		Is擽り = false;
    		擽りモーション?.End();
    	}
    }
}
