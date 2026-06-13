using System.Diagnostics;
using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class マウス処理 : 処理B
    {
    	public bool Is吸付;

    	public bool Is舐め;

    	private Motion キスモーション;

    	private ContactD 箇所;

    	private double x;

    	private Vector2D v;

    	private Vector2D o;

    	public bool 切り替え;

    	public bool Isモード
    	{
    		get
    		{
    			if (!Is吸付 && !Is舐め)
    			{
    				return 調教UI.マウス挿入.Is挿入;
    			}
    			return true;
    		}
    	}

    	public void 吸引()
    	{
    		調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    		{
    			調教UI.擬音.Sound(a, 対象.Element.位置.GetAreaPoint(0.01), Sta.吸引.GetVal(1.0, RNG.XS.NextDouble()), new Font("MS Gothic", 1f), Col.Black, 0.2, b: true);
    		});
    	}

    	private void オーバー時(string str, ref ContactD cd)
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = (調教UI.IsHitCha(ref cd) ? (str + "LDo:" + GameText.吸引 + "\r\nWh:" + GameText.舐る + "\r\n") : si());
    		}
    	}

    	private void 吸引時(string str)
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = str + "LUp:" + GameText.開放;
    		}
    	}

    	private string si()
    	{
    		if (!Isモード)
    		{
    			return "MCl:" + GameText.ハンド切替 + "\r\n" + (調教UI.ペニス挿入.挿抜モーション.Run ? "" : ("RCl:" + GameText.ペニス切替));
    		}
    		return "";
    	}

    	public void 舐め解除(ref ContactD cd)
    	{
    		調教UI.Action(cd.c, ActionType.Licking, CurrentState.End, ToolType.マウス, 0, 1, 機械: false, 射精: false);
    		Player.奴体力消費小();
    		Player.主精力消費小();
    		Is舐め = false;
    		調教UI.放し();
    	}

    	public void Move(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus != 対象)
    		{
    			return;
    		}
    		v = cp;
    		x = (o.X - v.X) * 0.008;
    		if (Isモード)
    		{
    			if (Is吸付)
    			{
                    //~~TODO~~ fix?
                    //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(対象.Element.位置));
                    Med.CursorPosition = Med.FromBasePosition(対象.Element.位置);

                }
    			else if (Is舐め)
    			{
    				if (cd.e == null)
    				{
    					舐め解除(ref cd);
    				}
    				else if (Sta.GameData.ガイド)
    				{
    					ip.SubInfoIm = "Wh:" + GameText.舐る;
    				}
    			}
    			else
    			{
    				調教UI.マウス挿入.Move(ref mb, ref cp, ref hc, ref cd);
    			}
    		}
    		else if (cd.c == ContactType.Milk)
    		{
    			調教UI.マウス.Xi = 0;
    			調教UI.Set_乳首(対象.Element, cd.e.右);
    			箇所 = cd;
    			オーバー時(GameText.乳首 + "\r\n", ref cd);
    		}
    		else if (cd.c == ContactType.Nucleus)
    		{
    			調教UI.マウス.Xi = 0;
    			調教UI.Set_陰核(対象.Element);
    			箇所 = cd;
    			オーバー時(GameText.陰核 + "\r\n", ref cd);
    		}
    		else if (Player.フェラ1 && cd.c == ContactType.Mouth)
    		{
    			箇所 = cd;
    			対象.Element.Intensity = 0.5;
    			調教UI.マウス.Xi = 4;
    			調教UI.マウス挿入.Move(ref mb, ref cp, ref hc, ref cd);
    		}
    		else if (cd.c == ContactType.Vagina)
    		{
    			箇所 = cd;
    			調教UI.マウス.Xi = 4;
    			調教UI.マウス挿入.Move(ref mb, ref cp, ref hc, ref cd);
    		}
    		else if (cd.c == ContactType.Anal)
    		{
    			箇所 = cd;
    			調教UI.マウス.Xi = 4;
    			調教UI.マウス挿入.Move(ref mb, ref cp, ref hc, ref cd);
    		}
    		else if (cd.c == ContactType.Thread)
    		{
    			箇所 = cd;
    			調教UI.マウス.Xi = 4;
    			調教UI.マウス挿入.Move(ref mb, ref cp, ref hc, ref cd);
    		}
    		else
    		{
    			調教UI.マウス.Xi = 0;
    			調教UI.マウス.Yi = 0;
    			調教UI.放し();
    			if (!(調教UI.X < cp.X) || !(cp.Y < 調教UI.Y))
    			{
    				対象.Element.Intensity = 1.0;
    			}
    			オーバー時("", ref cd);
    		}
    		o = v;
    	}

    	public void Down(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus != 対象)
    		{
    			return;
    		}
    		if (mb == MouseButtons.Left)
    		{
    			if (!調教UI.マウス挿入.Is挿入 && 調教UI.マウス.Xi != 4 && 調教UI.IsHitCha(ref cd))
    			{
    				舐め解除(ref cd);
    				調教UI.マウス.Xi = 1;
    				Is吸付 = true;
    				箇所 = cd;
    				if (cd.c == ContactType.Milk)
    				{
    					調教UI.Set_乳首(対象.Element, cd.e.右);
    					吸引時(GameText.乳首 + "\r\n");
    					調教UI.乳首演出();
    				}
    				else if (cd.c == ContactType.Nucleus)
    				{
    					調教UI.Set_陰核(対象.Element);
    					吸引時(GameText.陰核 + "\r\n");
    					調教UI.陰核演出();
    				}
    				else if (cd.c == ContactType.Mouth)
    				{
    					対象.Element.Intensity = 0.5;
    					対象.Element.角度C = (double)RNG.XS.NextSign() * 45.0;
    					調教UI.Set_口(対象.Element);
    					吸引時(GameText.口腔 + "\r\n");
    					調教UI.口腔演出();
    				}
    				else if (cd.c == ContactType.Vagina)
    				{
    					調教UI.Set_膣口(対象.Element);
    					吸引時(GameText.膣腔 + "\r\n");
    					調教UI.膣腔演出();
    				}
    				else if (cd.c == ContactType.Anal)
    				{
    					調教UI.Set_肛門(対象.Element);
    					吸引時(GameText.肛門 + "\r\n");
    					調教UI.肛門演出();
    				}
    				else if (cd.c == ContactType.Thread)
    				{
    					調教UI.Set_出糸(対象.Element);
    					吸引時(GameText.出糸 + "\r\n");
    					調教UI.出糸演出();
    				}
    				else
    				{
    					吸引時("");
    				}
    				調教UI.Action(箇所.c, ActionType.吸引, CurrentState.Start, ToolType.マウス, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    				キスモーション.Start();
    			}
    			else
    			{
    				調教UI.マウス挿入.Down(ref mb, ref cp, ref hc, ref cd);
    			}
    		}
    		else if (mb == MouseButtons.Right)
    		{
    			if (!Isモード && !調教UI.ペニス挿入.Is挿入)
    			{
    				調教UI.Focus.Element.Intensity = 0.5;
    				調教UI.Focus = 調教UI.ペニスCM;
    				調教UI.ペニスCM.Element.位置B = cp;
    				調教UI.ペニス処理.選択 = true;
    				調教UI.ペニス処理.Move(ref mb, ref cp, ref hc, ref cd);
    			}
    		}
    		else if (mb == MouseButtons.Middle && !Isモード && !調教UI.ハンド挿入.Is挿入)
    		{
    			if (切り替え)
    			{
    				切り替え = false;
    				return;
    			}
    			調教UI.Focus.Element.Intensity = 0.5;
    			調教UI.Focus = 調教UI.ハンド右CM;
    			調教UI.ハンド右.位置B = cp;
    			調教UI.ハンド処理.切り替え = true;
    			調教UI.ハンド処理.Move(ref mb, ref cp, ref hc, ref cd);
    		}
    	}

    	public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus == 対象 && mb == MouseButtons.Left && Is吸付)
    		{
    			調教UI.Action(箇所.c, ActionType.吸引, CurrentState.End, ToolType.マウス, 0, 1, 機械: false, 射精: false);
    			Player.奴体力消費小();
    			Player.主精力消費小();
    			調教UI.マウス.Xi = 0;
    			Is吸付 = false;
    			キスモーション.End();
    			対象.Element.Intensity = 1.0;
    			対象.Element.角度C = 0.0;
    			調教UI.放し();
    			if (cd.c == ContactType.Mouth)
    			{
    				オーバー時(GameText.口腔 + "\r\n", ref cd);
    			}
    			else if (cd.c == ContactType.Milk)
    			{
    				オーバー時(GameText.乳首 + "\r\n", ref cd);
    			}
    			else if (cd.c == ContactType.Nucleus)
    			{
    				オーバー時(GameText.陰核 + "\r\n", ref cd);
    			}
    			else if (cd.c == ContactType.Vagina)
    			{
    				オーバー時(GameText.膣腔 + "\r\n", ref cd);
    			}
    			else if (cd.c == ContactType.Anal)
    			{
    				オーバー時(GameText.肛門 + "\r\n", ref cd);
    			}
    			else
    			{
    				オーバー時("", ref cd);
    			}
    		}
    	}

    	public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
    	{
    	}

    	public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus == 対象 && !Is吸付 && !調教UI.マウス挿入.Is挿入 && 調教UI.IsHitCha(ref cd))
    		{
    			if (!Is舐め)
    			{
    				調教UI.Action(cd.c, ActionType.Licking, CurrentState.Start, ToolType.マウス, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			}
    			else
    			{
    				調教UI.Action(cd.c, ActionType.Licking, CurrentState.Continue, ToolType.マウス, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			}
    			Is舐め = true;
    			if (調教UI.IsHitCha(ref cd))
    			{
    				調教UI.押し(ref cd);
    			}
    			調教UI.マウス.Xi = 3;
    			調教UI.マウス.Yi = (調教UI.マウス.Yi - dt.Sign() * 2).Clamp(0, 調教UI.マウス.Body.CountY);
    			if (cd.c == ContactType.Mouth)
    			{
    				対象.Element.Intensity = 0.5;
    			}
    		}
    	}

    	public マウス処理(TrainingUI 調教UI, CM マウス)
    		: base(調教UI, マウス)
    	{
    		マウス処理 マウス処理2 = this;
    		double d = 0.0;
    		double s = 0.0;
    		bool f = true;
    		Stopwatch sw = new Stopwatch();
    		キスマーク k = null;
    		Vector2D cp;
    		Color hc;
    		キスモーション = new Motion(0.0, 0.15)
    		{
    			BaseSpeed = 4.0,
    			OnStart = delegate
    			{
    				f = true;
    				sw.Restart();
    				s = 1.09.Reciprocal();
    				マウス処理2.吸引();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (マウス処理2.箇所.c == ContactType.Milk)
    				{
    					調教UI.Set_乳首(マウス処理2.対象.Element, マウス処理2.箇所.e.右);
    				}
    				else if (マウス処理2.箇所.c == ContactType.Nucleus)
    				{
    					調教UI.Set_陰核(マウス処理2.対象.Element);
    				}
    				if (f)
    				{
    					d = m.Value.Inverse();
    					マウス処理2.対象.Element.尺度C = s * d;
    				}
    				マウス処理2.対象.Element.位置C = Oth.GetRandomVector() * d * 0.0005;
    				調教UI.マウス.X2Y0_舌.PositionCont = Oth.GetRandomVector() * d * 0.001;
    				if (sw.IsRunning)
    				{
    					if (sw.ElapsedMilliseconds > 250)
    					{
    						cp = マウス処理2.対象.Element.位置B;
    						hc = マウス処理2.Med.GetHitColor(マウス処理2.Med.FromBasePosition(cp));
    						k = マウス処理2.Bod.Addキスマーク(cp, hc);
    						sw.Stop();
    					}
    				}
    				else if (k != null)
    				{
    					k.Intensity = (k.Intensity + 0.05).Clamp(0.0, 1.0);
    					if (マウス処理2.Bod.EIChest != null)
    					{
    						マウス処理2.Bod.EIChest.Updatef = true;
    					}
    					if (マウス処理2.Bod.EI腕前 != null)
    					{
    						マウス処理2.Bod.EI腕前.Updatef = true;
    					}
    					if (マウス処理2.Bod.EI腿 != null)
    					{
    						マウス処理2.Bod.EI腿.Updatef = true;
    					}
    				}
    				調教UI.Action(マウス処理2.箇所.c, ActionType.吸引, CurrentState.Continue, ToolType.マウス, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    				if (マウス処理2.Bod.LeftMilkSpray.母乳垂れ1_表示 && マウス処理2.箇所.c == ContactType.Milk && マウス処理2.Cha.MilkSpray.Run)
    				{
    					Sta.GameData.精力 = (Sta.GameData.精力 + 0.02 * RNG.XS.NextDouble()).Clamp(0.0, 1.0);
    				}
    			},
    			OnReach = delegate(Motion m)
    			{
    				f = false;
    				d = m.Value.Inverse();
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate(Motion m)
    			{
    				m.ResetValue();
    				マウス処理2.対象.Element.尺度C = 1.0;
    				マウス処理2.対象.Element.位置C = DataConsts.Vec2DZero;
    				調教UI.マウス.X2Y0_舌.PositionCont = DataConsts.Vec2DZero;
    			}
    		};
    		調教UI.Mots.Add(キスモーション.GetHashCode().ToString(), キスモーション);
    	}

    	public void SetCha(Character Cha)
    	{
    		base.Cha = Cha;
    		Bod = Cha.Body;
    	}

    	public new void Reset()
    	{
    		base.Reset();
    		Is吸付 = false;
    		Is舐め = false;
    		キスモーション?.End();
    		箇所 = default(ContactD);
    		x = 0.0;
    		v = default(Vector2D);
    		o = default(Vector2D);
    		切り替え = false;
    	}
    }
}
