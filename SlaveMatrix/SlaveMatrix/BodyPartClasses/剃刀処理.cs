using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 剃刀処理 : 処理B
    {
    	public ConstProp CP = new ConstProp();

    	private bool Is剃り;

    	private Vector2D v;

    	private double a;

    	private Par p;

    	public void 剃り()
    	{
    		if (CP.GetFlag(0.1 * Cha.ChaD.現陰毛))
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, 対象.Ele.位置.GetAreaPoint(0.01), Sta.剃り.GetVal(Cha.ChaD.現陰毛, RNG.XS.NextDouble()), new Font("MS Gothic", 1f), Col.Black, 0.1 + 0.1 * RNG.XS.NextDouble(), b: true);
    			});
    		}
    	}

    	private void 待機時()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = "RCl:" + GameText.放す;
    		}
    	}

    	private void 押し当て時()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = "LUp:" + GameText.離す + "\r\nMo:" + GameText.剃る;
    		}
    	}

    	private void オーバー時()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = "LDo:" + GameText.当てる;
    		}
    	}

    	private void 移動時(ref Color hc)
    	{
    		p = null;
    		if (Bod.腰肌_人 != null && Bod.腰肌_人.本体.IsHit(ref hc))
    		{
    			p = Bod.腰肌_人.本体.GetHitPar_(hc);
    		}
    		if (p != null && (p.Tag == "獣毛" || p.Tag == "陰毛"))
    		{
    			オーバー時();
    		}
    		else
    		{
    			待機時();
    		}
    	}

    	public void Move(ref MouseButtons mb, ref Vector2D cp, ref Vector2D op, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus != 対象)
    		{
    			return;
    		}
    		if (mb == MouseButtons.Left && Is剃り)
    		{
    			if (調教UI.IsHitCha(ref cd))
    			{
    				調教UI.押し(ref cd);
    				v = op - cp;
    				a = 0.0 - v.Angle02π(-Dat.Vec2DUnitY).ToDegree();
    				if (!double.IsNaN(a))
    				{
    					対象.Ele.角度C = a;
    				}
    				調教UI.Action(cd.c, ActionType.Shaving, CurrentState.Continue, ToolType.Ｔ剃刀, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    				剃り();
    				Cha.ChaD.現陰毛 = (Cha.ChaD.現陰毛 - 0.01).Clamp(0.0, 1.0);
    				Cha.Bod.腰肌_人.陰毛CD.不透明度 = Cha.ChaD.現陰毛 * Cha.ChaD.最陰毛濃度;
    				Cha.Bod.腰肌_人.獣性_獣毛CD.不透明度 = Cha.ChaD.現陰毛;
    				Cha.Bod.腰肌_人.陰毛_ハートCD.不透明度 = Cha.ChaD.現陰毛.Inverse() * Cha.ChaD.最陰毛濃度;
    			}
    			else if (調教UI.押し状態)
    			{
    				調教UI.Action(cd.c, ActionType.Shaving, CurrentState.End, ToolType.Ｔ剃刀, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    				対象.Ele.角度C = 0.0;
    				調教UI.放し();
    			}
    			押し当て時();
    		}
    		else
    		{
    			移動時(ref hc);
    		}
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
    		p = null;
    		if (Bod.腰肌_人 != null && Bod.腰肌_人.本体.IsHit(ref hc))
    		{
    			p = Bod.腰肌_人.本体.GetHitPar_(hc);
    		}
    		if (mb == MouseButtons.Left && p != null && (p.Tag == "獣毛" || p.Tag == "陰毛"))
    		{
    			調教UI.押し(ref cd);
    			Is剃り = true;
    			押し当て時();
    			調教UI.Action(cd.c, ActionType.Shaving, CurrentState.Start, ToolType.Ｔ剃刀, 0, 1, 機械: false, 射精: false);
    			Player.奴体力消費小();
    			Player.主精力消費小();
    		}
    		else if (mb == MouseButtons.Right && !Is剃り)
    		{
    			Is剃り = false;
    			対象.Ele.角度C = 0.0;
    			調教UI.通常放し();
    		}
    	}

    	public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus == 対象 && mb == MouseButtons.Left && Is剃り)
    		{
    			調教UI.Action(cd.c, ActionType.Shaving, CurrentState.End, ToolType.Ｔ剃刀, 0, 1, 機械: false, 射精: false);
    			Player.奴体力消費小();
    			Player.主精力消費小();
    			調教UI.放し();
    			対象.Ele.角度C = 0.0;
    			Is剃り = false;
    			移動時(ref hc);
    		}
    	}

    	public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
    	{
    	}

    	public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc)
    	{
    	}

    	public 剃刀処理(TrainingUI 調教UI, CM T剃刀)
    		: base(調教UI, T剃刀)
    	{
    	}

    	public void SetCha(Cha Cha)
    	{
    		base.Cha = Cha;
    		Bod = Cha.Bod;
    	}

    	public new void Reset()
    	{
    		base.Reset();
    		CP.Reset();
    		Is剃り = false;
    		v = default(Vector2D);
    		a = 0.0;
    		p = null;
    	}
    }
}
