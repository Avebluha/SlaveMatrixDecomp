using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class ペニス処理 : 処理B
    {
    	public bool Is手コキ;

    	public bool Is足コキ;

    	public bool Isパイズリ;

    	public bool 中出し;

    	public bool 手固定;

    	public bool 足固定;

    	public Motion チンピク;

    	public double 射精時間;

    	public Motion 射精終了;

    	public Motion 射精;

    	private Motion 放精;

    	public int 中出しCount;

    	public Motion 手コキ;

    	public bool 手コキ左;

    	public Motion フェラ;

    	public Motion パイズリ;

    	public bool Isパイズリ相互;

    	public bool Isパイズリ他動;

    	public Motion 足コキ;

    	private double 扱き = 1.0;

    	private int yi;

    	private double x;

    	private double y;

    	private double d;

    	private Vector2D v;

    	private Vector2D o;

    	private Vector2D vc = DataConsts.Vec2DZero;

    	private ContactType 挿入箇所;

    	private Shoulder Shoulder;

    	private Shoulder 肩左;

    	private Shoulder 肩右;

    	private UpperArm_人 UpperArm;

    	private UpperArm_人 UpperArm左;

    	private UpperArm_人 UpperArm右;

    	private LowerArm_人 LowerArm;

    	private LowerArm_人 LowerArm左;

    	private LowerArm_人 LowerArm右;

    	private 手_人 手;

    	private 手_人 手左;

    	private 手_人 手右;

    	private 腿_人 腿左;

    	private 腿_人 腿右;

    	private Leg_人 脚左;

    	private Leg_人 脚右;

    	private 足_人 足左;

    	private 足_人 足右;

    	public bool Isモード
    	{
    		get
    		{
    			if (!Is手コキ && !Is足コキ && !Isパイズリ && !調教UI.ペニス挿入.Is押付)
    			{
    				return 調教UI.ペニス挿入.Is挿入;
    			}
    			return true;
    		}
    	}

    	private bool 持ち手
    	{
    		get
    		{
    			return 調教UI.持ち手;
    		}
    		set
    		{
    			調教UI.持ち手 = value;
    			if (value)
    			{
    				調教UI.ハンド右.Xi = 13;
    				調教UI.ハンド右.Intensity = 調教UI.ペニス.Intensity;
    				調教UI.ハンド右.角度C = 0.0;
    			}
    			else
    			{
    				調教UI.Set持ち手();
    				調教UI.ハンド右.位置B = 調教UI.ハンド右CM.bp;
    				調教UI.ハンド右.Intensity = 0.5;
    				調教UI.ハンド右.位置C = DataConsts.Vec2DZero;
    				調教UI.放し();
    			}
    			調教UI.ハンド右.Intensity = 1.0;
    		}
    	}

    	public void 射精_()
    	{
    		調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    		{
    			調教UI.擬音.Sound(a, Sta.GetAreaPoint(ref 調教UI.ペニス.AreM.Position, 0.02), Sta.射精.GetVal(Player.変化V_射精, 1.0), new Font("MS Gothic", 1f), Color.White, 0.2 + 0.2 * RNG.XS.NextDouble() * Player.変化V_射精, b: true);
    		});
    	}

    	private void パイズリ時()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			if (Isパイズリ他動)
    			{
    				ip.SubInfoIm = "LDo:" + GameText.放す;
    			}
    			else
    			{
    				ip.SubInfoIm = "Mo↑↓:" + GameText.擦る + "\r\nLUp:" + GameText.放す;
    			}
    		}
    	}

    	private void 胸オーバー時()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			if (Isパイズリ他動)
    			{
    				ip.SubInfoIm = "LDo:" + GameText.挟ませる;
    			}
    			else
    			{
    				ip.SubInfoIm = "LDo:" + GameText.挟む;
    			}
    		}
    	}

    	private void コキ時()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = "LDo:" + GameText.やめさせる;
    		}
    	}

    	private void 手オーバー時()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = "LDo:" + GameText.手コキ;
    		}
    	}

    	private void 足オーバー時()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = "LDo:" + GameText.足コキ;
    		}
    	}

    	private void 扱き時()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			InfoPanel obj = ip;
    			obj.SubInfoIm = obj.SubInfoIm + "\r\nWh:" + GameText.扱く;
    		}
    	}

    	private string si()
    	{
    		if (!Isモード)
    		{
    			return (調教UI.マウス挿入.挿抜モーション.Run ? "" : ("MCl:" + GameText.マウス切替 + "\r\n")) + "RCl:" + GameText.ハンド切替;
    		}
    		return "";
    	}

    	public void Move(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus != 対象)
    		{
    			return;
    		}
    		v = cp;
    		x = (o.X - v.X) * 0.008;
    		y = (o.Y - v.Y) * 0.008;
    		if (Isモード)
    		{
    			if (調教UI.ペニス挿入.Is挿入)
    			{
    				持ち手 = false;
    			}
    			if (Isパイズリ)
    			{
    				if (Isパイズリ他動)
    				{
    					持ち手 = false;
    					調教UI.ハンド右.Intensity = 0.5;
    				}
    				else
    				{
    					Bod.乳房右.接続P();
    					Bod.乳房左.接続P();
    					調教UI.ハンド右.位置B = Bod.乳房右.位置;
    					調教UI.ハンド左.位置B = Bod.乳房左.位置;
    				}
    				yi = Bod.乳房左.Yi;
    				d = (d + y).Clamp(0.0, 1.0);
    				調教UI.ペニス.位置B = Bod.胸部位置.AddY(-0.03 * d);
    				Bod.乳房左.Yv = 0.2 + 0.4 * d;
    				Bod.乳房右.Yv = 0.2 + 0.4 * d;
    				vc.Y = -0.002 * d;
    				Bod.胸毛_人.位置C = vc;
    				対象.Element.角度C = (100.0 * x).Clamp(-5.0, 5.0);
    				if (yi != Bod.乳房左.Yi && Bod.乳房左.Yi == 1)
    				{
    					Bod.胸左右前後 = !Bod.胸左右前後;
    				}
    				パイズリ時();
    				調教UI.Action(ContactType.Chest, ActionType.パイ, CurrentState.Continue, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			}
    			else
    			{
    				調教UI.ペニス挿入.Move(ref mb, ref cp, ref hc, ref cd);
    				if (!調教UI.ペニス挿入.Is挿入)
    				{
    					挿入箇所 = ContactType.none;
    				}
    			}
    		}
    		else if (Bod.Is胸部())
    		{
    			Isパイズリ他動 = Player.パイズリ1;
    			胸オーバー時();
    		}
    		else if (Player.手コキ && cd.c == ContactType.Hand)
    		{
    			手オーバー時();
    		}
    		else if (Player.足コキ && cd.c == ContactType.Feet)
    		{
    			足オーバー時();
    		}
    		else
    		{
    			調教UI.ペニス挿入.Move(ref mb, ref cp, ref hc, ref cd);
    			if (Sta.GameData.ガイド)
    			{
    				if (string.IsNullOrWhiteSpace(ip.SubInfoIm))
    				{
    					ip.SubInfoIm += si();
    				}
    				else if (ip.SubInfoIm == "LDo:" + GameText.押付け)
    				{
    					扱き時();
    				}
    			}
    		}
    		o = v;
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
    		}
    		else if (mb == MouseButtons.Left)
    		{
    			if (Bod.Is胸部())
    			{
    				手コキ.End();
    				足コキ.End();
    				if (Player.パイズリ2)
    				{
    					パイズリ.Start();
    				}
    				Isパイズリ相互 = Player.パイズリ3 && RNG.XS.NextBool();
    				Isパイズリ = true;
    				調教UI.ペニス.位置B = Bod.胸部位置;
    				d = 0.0;
    				Bod.乳房左.Yi = 1;
    				Bod.乳房右.Yi = 1;
    				if (Isパイズリ他動)
    				{
    					持ち手 = true;
    					if (調教UI.押し状態)
    					{
    						調教UI.ハンド右.位置C = new Vector2D(0.0, 0.02);
    					}
    					else
    					{
    						調教UI.ハンド右.位置C = new Vector2D(0.0, 0.021800000000000003);
    					}
    					Cha.両腕_人_パイズリ(0, 左右: false, 前後: false);
    					if (Bod.Is腕前)
    					{
    						Bod.EI腕前.Updatef = true;
    					}
    				}
    				else
    				{
    					持ち手 = false;
    					Bod.乳房右.接続P();
    					Bod.乳房左.接続P();
    					調教UI.ハンド右.位置B = Bod.乳房右.位置;
    					調教UI.ハンド左.位置B = Bod.乳房左.位置;
    					調教UI.ハンド右.位置C = new Vector2D(0.011, 0.001);
    					調教UI.ハンド左.位置C = new Vector2D(-0.011, 0.001);
    					調教UI.ハンド右.Xi = 4;
    					調教UI.ハンド左.Xi = 4;
    					調教UI.ハンド右CM.使用状態 = UsageStatus.InUse;
    					調教UI.ハンド右.Intensity = 1.0;
    					調教UI.ハンド左表示 = true;
    					調教UI.押し(ref cd);
    					調教UI.腕修正();
    				}
    				パイズリ時();
    				調教UI.Action(ContactType.Chest, ActionType.パイ, CurrentState.Start, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    				調教UI.乳房演出();
    				調教UI.脚修正();
    				return;
    			}
    			if (!手コキ.Run && Player.手コキ && cd.c == ContactType.Hand)
    			{
    				パイズリ.End();
    				足コキ.End();
    				Is手コキ = true;
    				調教UI.腕修正();
    				手コキ左 = !cd.e.右;
    				手コキ.Start();
    				コキ時();
    				調教UI.脚修正();
    				return;
    			}
    			if (手コキ.Run)
    			{
    				手コキ.End();
    				Is手コキ = false;
    				return;
    			}
    			if (!足コキ.Run && Player.足コキ && cd.c == ContactType.Feet)
    			{
    				パイズリ.End();
    				手コキ.End();
    				Is足コキ = true;
    				足コキ.Start();
    				コキ時();
    				return;
    			}
    			if (足コキ.Run)
    			{
    				足コキ.End();
    				Is足コキ = false;
    				return;
    			}
    			if (!調教UI.ペニス挿入.Is挿入)
    			{
    				持ち手 = true;
    				if (調教UI.押し状態)
    				{
    					調教UI.ハンド右.位置C = new Vector2D(0.0, 0.02);
    				}
    				else
    				{
    					調教UI.ハンド右.位置C = new Vector2D(0.0, 0.021800000000000003);
    				}
    			}
    			調教UI.ペニス挿入.Down(ref mb, ref cp, ref hc, ref cd);
    			if (調教UI.ペニス挿入.Is口)
    			{
    				挿入箇所 = ContactType.Mouth;
    			}
    			else if (調教UI.ペニス挿入.Is膣)
    			{
    				挿入箇所 = ContactType.Vagina;
    			}
    			else if (調教UI.ペニス挿入.Is肛)
    			{
    				挿入箇所 = ContactType.Anal;
    			}
    			else if (調教UI.ペニス挿入.Is糸)
    			{
    				挿入箇所 = ContactType.Thread;
    			}
    		}
    		else if (mb == MouseButtons.Right && !手コキ.Run && !パイズリ.Run && !足コキ.Run)
    		{
    			if (!Isモード)
    			{
    				if (!調教UI.ハンド挿入.Is挿入)
    				{
    					持ち手 = false;
    					調教UI.Focus.Element.Intensity = 0.5;
    					調教UI.Focus = 調教UI.ハンド右CM;
    					調教UI.ハンド右.位置B = cp;
    					調教UI.ハンド処理.切り替え = true;
    					調教UI.ハンド処理.Move(ref mb, ref cp, ref hc, ref cd);
    				}
    			}
    			else if (調教UI.ペニス挿入.Is挿入)
    			{
    				調教UI.ペニス挿入.Down(ref mb, ref cp, ref hc, ref cd);
    			}
    		}
    		else if (mb == MouseButtons.Middle && !手コキ.Run && !パイズリ.Run && !足コキ.Run && !Isモード && !調教UI.マウス挿入.Is挿入)
    		{
    			持ち手 = false;
    			調教UI.Focus.Element.Intensity = 0.5;
    			調教UI.Focus = 調教UI.マウスCM;
    			調教UI.マウスCM.Element.位置B = cp;
    			調教UI.マウス処理.切り替え = true;
    			調教UI.マウス処理.Move(ref mb, ref cp, ref hc, ref cd);
    		}
    	}

    	public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus != 対象 || !Isモード)
    		{
    			return;
    		}
    		if (持ち手)
    		{
    			調教UI.ハンド右.位置C = new Vector2D(0.0, 0.021800000000000003);
    		}
    		if (Isパイズリ && mb == MouseButtons.Left)
    		{
    			調教UI.Action(ContactType.Chest, ActionType.パイ, CurrentState.End, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    			Player.奴体力消費小();
    			Player.主精力消費小();
    			if (パイズリ.Run)
    			{
    				パイズリ.End();
    			}
                //~~TODO~~ fix?
                //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(対象.Element.位置B));
                Med.CursorPosition = Med.FromBasePosition(対象.Element.位置B);


                調教UI.ハンド処理.バスト初期化.Start();
    			vc = DataConsts.Vec2DZero;
    			Bod.胸毛_人.位置C = vc;
    			調教UI.ハンド左表示 = false;
    			調教UI.ハンド右.位置C = DataConsts.Vec2DZero;
    			調教UI.ハンド左.位置C = DataConsts.Vec2DZero;
    			対象.Element.角度C = 0.0;
    			持ち手 = false;
    			Isパイズリ = false;
    			調教UI.放し();
    			胸オーバー時();
    			return;
    		}
    		調教UI.ペニス挿入.Up(ref mb, ref cp, ref hc, ref cd);
    		if (Sta.GameData.ガイド)
    		{
    			if (string.IsNullOrWhiteSpace(ip.SubInfoIm))
    			{
    				ip.SubInfoIm += si();
    			}
    			else if (ip.SubInfoIm == "LDo:" + GameText.押付け)
    			{
    				扱き時();
    			}
    		}
    	}

    	public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
    	{
    	}

    	public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus == 対象 && !Isモード && !調教UI.コキ)
    		{
    			if (!持ち手)
    			{
    				持ち手 = true;
    			}
    			扱き = (扱き + 0.5 * (double)(-dt.Sign())).Clamp(0.3, 1.0);
    			調教UI.ハンド右.位置C = new Vector2D(0.0, 0.02 * 扱き);
    			Player.自コキ処理();
    			Player.主精力消費小();
    		}
    	}

    	public void 精液発射()
    	{
    		if (!調教UI.ペニス挿入.Is挿入)
    		{
    			チンピク.Start();
    		}
    		射精.Start();
    	}

    	public ペニス処理(TrainingUI 調教UI, CharacterElement ペニス)
    		: base(調教UI, ペニス)
    	{
    		ペニス処理 ペニス処理2 = this;
    		double d = 調教UI.ペニス.X0Y4_陰嚢.BasePointBase.Y - 調教UI.ペニス.X0Y0_陰嚢.BasePointBase.Y;
    		Vector2D v = new Vector2D(対象.Element.位置C.X, d);
    		チンピク = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 4.0,
    			OnStart = delegate
    			{
    				ペニス処理2.対象.Element.Yi = 0;
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				ペニス処理2.対象.Element.Yv = m.Value;
    				v.Y = d * m.Value;
    				ペニス処理2.対象.Element.位置C = v;
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnEnd = delegate(Motion m)
    			{
    				m.ResetValue();
    				ペニス処理2.対象.Element.Yi = 0;
    				ペニス処理2.対象.Element.位置C = DataConsts.Vec2DZero;
    			}
    		};
    		調教UI.Mots.Add(チンピク.GetHashCode().ToString(), チンピク);
    		射精終了 = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 0.2 - 0.18 * 射精時間,
    			OnStart = delegate(Motion m)
    			{
    				m.BaseSpeed = 0.2 - 0.18 * ペニス処理2.射精時間;
    			},
    			OnUpdate = delegate
    			{
    				Player.射精処理();
    			},
    			OnReach = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				ペニス処理2.射精.End();
    				Player.射精終了処理();
    			}
    		};
    		調教UI.Mots.Add(射精終了.GetHashCode().ToString(), 射精終了);
    		double xc;
    		射精 = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 4.0,
    			OnStart = delegate
    			{
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				xc = 1.0 + 0.2 * m.Value;
    				foreach (ShapePart item in 調教UI.ペニス.Body.EnumAllPar())
    				{
    					if (item.Tag != "陰嚢")
    					{
    						item.SizeXCont = xc;
    					}
    				}
    				調教UI.ペニス.位置C = Oth.GetRandomVector() * 0.001;
    				調教UI.射精.位置C = 調教UI.ペニス.位置C;
    			},
    			OnReach = delegate(Motion m)
    			{
    				ペニス処理2.放精.Start();
    				ペニス処理2.中出し = 調教UI.ペニス挿入.Is挿入;
    				if (ペニス処理2.中出し)
    				{
    					ペニス処理2.中出しCount++;
    				}
    				Player.射精中処理();
    				Player.主精力消費大();
    				m.End();
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate(Motion m)
    			{
    				ペニス処理2.対象.Element.尺度XC = 1.0;
    				調教UI.ペニス.位置C = DataConsts.Vec2DZero;
    				調教UI.射精.位置C = DataConsts.Vec2DZero;
    				m.ResetValue();
    			}
    		};
    		調教UI.Mots.Add(射精.GetHashCode().ToString(), 射精);
    		bool 外出し = false;
    		bool 断面 = false;
    		ShapePart p;
    		Vector2D cp;
    		Color hc;
    		ContactType c;
    		放精 = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 3.0,
    			OnStart = delegate
    			{
    				//Sounds.射精.Play();
    				ペニス処理2.射精_();
    				if (外出し = !調教UI.ペニス挿入.Is挿入)
    				{
    					調教UI.射精.表示 = true;
    					調教UI.射精.Yi = 0;
    				}
    				else
    				{
    					断面 = ペニス処理2.Bod.断面_表示 && ペニス処理2.挿入箇所 == ContactType.Vagina;
    				}
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (外出し)
    				{
    					調教UI.射精.位置B = 調教UI.ペニス.位置B;
    					調教UI.射精.Yv = m.Value;
    					if (調教UI.射精.Yv >= 0.65 && 調教UI.Focus == ペニス)
    					{
    						p = 調教UI.射精.Body.Current.EnumAllPar().First();
    						cp = p.ToGlobal(p.OP.GetCenter() + Oth.GetRandomVector() * 0.0025);
    						hc = ペニス処理2.Med.GetHitColor(ペニス処理2.Med.FromBasePosition(cp));
    						ペニス処理2.Bod.Addぶっかけ(cp, hc);
    						調教UI.Action(c = ペニス処理2.Cha.GetContact(ref hc).c, ActionType.Contact, CurrentState.Start, ToolType.Penis, 0, 1, 機械: false, 射精: true);
    						if (c != 0)
    						{
    							Player.ぶっかけ処理();
    						}
    					}
    				}
    				else
    				{
    					if (断面 && ペニス処理2.挿入箇所 == ContactType.Vagina)
    					{
    						ペニス処理2.Bod.VaginalCumDrip.精液濃度 = (ペニス処理2.Bod.VaginalCumDrip.精液濃度 + 0.05).Clamp(0.0, 1.0);
    						ペニス処理2.Bod.断面.精液濃度 = (ペニス処理2.Bod.断面.精液濃度 + 0.025).Clamp(0.0, 1.0);
    					}
    					調教UI.Action(ペニス処理2.挿入箇所, ActionType.Insertion, CurrentState.Start, ToolType.Penis, 0, 1, 機械: false, 射精: true);
    					Player.中出し処理();
    				}
    			},
    			OnReach = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				if (外出し)
    				{
    					調教UI.射精.表示 = false;
    					調教UI.射精.Yi = 0;
    				}
    				else if (断面)
    				{
    					_ = ペニス処理2.挿入箇所;
    					_ = 14;
    				}
    			}
    		};
    		調教UI.Mots.Add(放精.GetHashCode().ToString(), 放精);
    		double LowerArmXC = 0.0;
    		double s = 1.0;
    		手コキ = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    				s = (ペニス処理2.手コキ左 ? 1.0 : (-1.0));
    				ペニス処理2.持ち手 = false;
    				調教UI.コキ = true;
    				if (ペニス処理2.手コキ左)
    				{
    					ペニス処理2.Cha.Arm_人_手コキ左(0, 0.0, 0.0, 0.0, 0.0);
    				}
    				else
    				{
    					ペニス処理2.Cha.Arm_人_手コキ右(0, 0.0, 0.0, 0.0, 0.0);
    				}
    				ペニス処理2.手固定 = true;
    				ペニス処理2.Shoulder = (ペニス処理2.手コキ左 ? ペニス処理2.肩左 : ペニス処理2.肩右);
    				ペニス処理2.UpperArm = (ペニス処理2.手コキ左 ? ペニス処理2.UpperArm左 : ペニス処理2.UpperArm右);
    				ペニス処理2.LowerArm = (ペニス処理2.手コキ左 ? ペニス処理2.LowerArm左 : ペニス処理2.LowerArm右);
    				ペニス処理2.手 = (ペニス処理2.手コキ左 ? ペニス処理2.手左 : ペニス処理2.手右);
    				if (ペニス処理2.LowerArm != null)
    				{
    					LowerArmXC = ペニス処理2.LowerArm.尺度XC;
    				}
    				調教UI.ペニス.位置B = ペニス処理2.Bod.Neck.位置.AddY(0.01);
    				調教UI.Action(ContactType.Hand, ActionType.手コ, CurrentState.Start, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.主精力消費小();
    				Player.奴体力消費小();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (ペニス処理2.Shoulder != null)
    				{
    					ペニス処理2.Shoulder.角度C = s * 5.0 * m.Value;
    				}
    				if (ペニス処理2.LowerArm != null)
    				{
    					ペニス処理2.LowerArm.角度C = s * 30.0 * m.Value;
    					ペニス処理2.LowerArm.尺度XC = LowerArmXC * (0.9 + 0.1 * m.Value.Inverse());
    					if (ペニス処理2.LowerArm.虫鎌_接続 != null)
    					{
    						Element[] 虫鎌_接続2 = ペニス処理2.LowerArm.虫鎌_接続;
    						for (int j = 0; j < 虫鎌_接続2.Length; j++)
    						{
    							虫鎌_接続2[j].尺度XC = ペニス処理2.LowerArm.尺度XC;
    						}
    					}
    				}
    				if (ペニス処理2.手 != null)
    				{
    					ペニス処理2.手.角度C = s * -30.0 * m.Value;
    				}
    				if (ペニス処理2.Bod.EI腕前 != null)
    				{
    					ペニス処理2.Bod.EI腕前.Updatef = true;
    				}
    				調教UI.Action(ContactType.Hand, ActionType.手コ, CurrentState.Continue, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.主精力消費小();
    				Player.奴体力消費小();
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				ペニス処理2.手固定 = false;
    				調教UI.コキ = false;
    				if (ペニス処理2.Shoulder != null)
    				{
    					ペニス処理2.Shoulder.角度C = 0.0;
    				}
    				if (ペニス処理2.LowerArm != null)
    				{
    					ペニス処理2.LowerArm.角度C = 0.0;
    				}
    				if (ペニス処理2.手 != null)
    				{
    					ペニス処理2.手.角度C = 0.0;
    				}
    				if (ペニス処理2.Bod.EI腕前 != null)
    				{
    					ペニス処理2.Bod.EI腕前.Updatef = true;
    				}
    				調教UI.Action(ContactType.Hand, ActionType.手コ, CurrentState.End, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.主精力消費小();
    				Player.奴体力消費小();
    			}
    		};
    		調教UI.Mots.Add(手コキ.GetHashCode().ToString(), 手コキ);
    		_ = DataConsts.Vec2DZero;
    		s = 0.0;
    		double t;
    		double d1;
    		double d2;
    		フェラ = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    				ペニス処理2.Bod.頬濃度 = 0.0;
    				ペニス処理2.Bod.口.Yi = 13;
    				ペニス処理2.Bod.舌_表示 = true;
    				s = RNG.XS.NextSign();
    				調教UI.Action(ContactType.Mouth, ActionType.Insertion, CurrentState.Start, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				t = ペニス処理2.Cha.CharacterData.SkillL / Sta.GameData.TrainingTarget.MaxSkillL * 0.4;
    				d1 = m.Value.Sin() * 調教UI.ペニス.Yv.Inverse() * t;
    				d2 = m.Value * 調教UI.ペニス.Yv * t;
    				ペニス処理2.Bod.頬濃度 = d1;
    				ペニス処理2.Bod.頭.角度C = s * 5.0 * d2;
    				ペニス処理2.Bod.舌.角度C = s * -60.0 * d2;
    				調教UI.Action(ContactType.Mouth, ActionType.Insertion, CurrentState.Continue, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate
    			{
    				s = RNG.XS.NextSign();
    			},
    			OnEnd = delegate(Motion m)
    			{
    				m.ResetValue();
    				ペニス処理2.Bod.舌_表示 = false;
    				ペニス処理2.Bod.頬濃度 = 0.0;
    				ペニス処理2.Bod.頭.角度C = 0.0;
    				ペニス処理2.Bod.舌.角度C = 0.0;
    				調教UI.Action(ContactType.Mouth, ActionType.Insertion, CurrentState.End, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			}
    		};
    		調教UI.Mots.Add(フェラ.GetHashCode().ToString(), フェラ);
    		s = 0.0;
    		LowerArmXC = 0.0;
    		Vector2D vc = DataConsts.Vec2DZero;
    		bool sb = false;
    		double vl;
    		double vr;
    		パイズリ = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    				ペニス処理2.Cha.両腕_人_パイズリ(0, 左右: false, 前後: false);
    				ペニス処理2.手固定 = true;
    				if (ペニス処理2.LowerArm左 != null)
    				{
    					LowerArmXC = ペニス処理2.LowerArm左.尺度XC;
    				}
    				vc = DataConsts.Vec2DZero;
    				sb = RNG.XS.NextBool();
    				s = (sb ? (-1.0) : 1.0);
    				調教UI.Action(ContactType.Chest, ActionType.パイ, CurrentState.Start, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.主精力消費小();
    				Player.奴体力消費小();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				vl = ((!ペニス処理2.Isパイズリ相互) ? m.Value : (sb ? m.Value : m.Value.Inverse()));
    				vr = ((!ペニス処理2.Isパイズリ相互) ? m.Value : (sb ? m.Value.Inverse() : m.Value));
    				if (ペニス処理2.肩左 != null)
    				{
    					ペニス処理2.肩左.角度C = 5.0 * vl;
    				}
    				if (ペニス処理2.LowerArm左 != null)
    				{
    					ペニス処理2.LowerArm左.角度C = -20.0 * vl;
    					ペニス処理2.LowerArm左.尺度XC = LowerArmXC + 0.2 * vl;
    					if (ペニス処理2.LowerArm左.虫鎌_接続 != null)
    					{
    						Element[] 虫鎌_接続 = ペニス処理2.LowerArm左.虫鎌_接続;
    						for (int i = 0; i < 虫鎌_接続.Length; i++)
    						{
    							虫鎌_接続[i].尺度XC = ペニス処理2.LowerArm左.尺度XC;
    						}
    					}
    				}
    				if (ペニス処理2.手左 != null)
    				{
    					ペニス処理2.手左.角度C = 30.0 * vl;
    				}
    				if (ペニス処理2.肩右 != null)
    				{
    					ペニス処理2.肩右.角度C = -5.0 * vr;
    				}
    				if (ペニス処理2.LowerArm右 != null)
    				{
    					ペニス処理2.LowerArm右.角度C = 20.0 * vr;
    					ペニス処理2.LowerArm右.尺度XC = LowerArmXC + 0.2 * vr;
    					if (ペニス処理2.LowerArm右.虫鎌_接続 != null)
    					{
    						Element[] 虫鎌_接続 = ペニス処理2.LowerArm右.虫鎌_接続;
    						for (int i = 0; i < 虫鎌_接続.Length; i++)
    						{
    							虫鎌_接続[i].尺度XC = ペニス処理2.LowerArm右.尺度XC;
    						}
    					}
    				}
    				if (ペニス処理2.手右 != null)
    				{
    					ペニス処理2.手右.角度C = -30.0 * vr;
    				}
    				ペニス処理2.Bod.乳房左.Yv = 0.2 + 0.5 * vl;
    				ペニス処理2.Bod.乳房右.Yv = 0.2 + 0.5 * vr;
    				if (ペニス処理2.Bod.胸毛_人 != null)
    				{
    					if (ペニス処理2.Isパイズリ相互)
    					{
    						ペニス処理2.Bod.胸毛_人.角度C = s * -2.5 + s * 5.0 * vl;
    					}
    					else
    					{
    						vc.Y = -0.002 * vl;
    						ペニス処理2.Bod.胸毛_人.位置C = vc;
    					}
    				}
    				if (ペニス処理2.Bod.EI腕前 != null)
    				{
    					ペニス処理2.Bod.EI腕前.Updatef = true;
    				}
    				調教UI.Action(ContactType.Chest, ActionType.パイ, CurrentState.Continue, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.主精力消費小();
    				Player.奴体力消費小();
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate(Motion m)
    			{
    				ペニス処理2.手固定 = false;
    				調教UI.ハンド処理.バスト初期化.Start();
    				ペニス処理2.Bod.胸毛_人.角度C = 0.0;
    				ペニス処理2.Bod.胸毛_人.位置C = DataConsts.Vec2DZero;
    				if (ペニス処理2.肩左 != null)
    				{
    					ペニス処理2.肩左.角度C = 0.0;
    				}
    				if (ペニス処理2.LowerArm左 != null)
    				{
    					ペニス処理2.LowerArm左.角度C = 0.0;
    				}
    				if (ペニス処理2.手左 != null)
    				{
    					ペニス処理2.手左.角度C = 0.0;
    				}
    				if (ペニス処理2.肩右 != null)
    				{
    					ペニス処理2.肩右.角度C = 0.0;
    				}
    				if (ペニス処理2.LowerArm右 != null)
    				{
    					ペニス処理2.LowerArm右.角度C = 0.0;
    				}
    				if (ペニス処理2.手右 != null)
    				{
    					ペニス処理2.手右.角度C = 0.0;
    				}
    				if (ペニス処理2.Bod.EI腕前 != null)
    				{
    					ペニス処理2.Bod.EI腕前.Updatef = true;
    				}
    				m.ResetValue();
    				調教UI.Action(ContactType.Chest, ActionType.パイ, CurrentState.End, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.主精力消費小();
    				Player.奴体力消費小();
    			}
    		};
    		調教UI.Mots.Add(パイズリ.GetHashCode().ToString(), パイズリ);
    		足コキ = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    				ペニス処理2.持ち手 = false;
    				調教UI.コキ = true;
    				ペニス処理2.Bod.HipMotion_人v = 1.0;
    				調教UI.ペニス.位置B = ペニス処理2.Bod.局部位置.AddY(0.035);
    				ペニス処理2.Cha.両脚_人_足コキ(0);
    				ペニス処理2.足固定 = true;
    				調教UI.Action(ContactType.Feet, ActionType.足コ, CurrentState.Start, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.主精力消費小();
    				Player.奴体力消費小();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (ペニス処理2.腿左 != null)
    				{
    					ペニス処理2.腿左.角度C = 11.0 * m.Value;
    				}
    				if (ペニス処理2.腿右 != null)
    				{
    					ペニス処理2.腿右.角度C = -11.0 * m.Value;
    				}
    				if (ペニス処理2.脚左 != null)
    				{
    					ペニス処理2.脚左.角度C = -15.0 * m.Value;
    				}
    				if (ペニス処理2.脚右 != null)
    				{
    					ペニス処理2.脚右.角度C = 15.0 * m.Value;
    				}
    				if (ペニス処理2.足左 != null)
    				{
    					ペニス処理2.足左.角度C = 5.0 * m.Value;
    				}
    				if (ペニス処理2.足右 != null)
    				{
    					ペニス処理2.足右.角度C = -5.0 * m.Value;
    				}
    				if (ペニス処理2.Bod.EI腿 != null)
    				{
    					ペニス処理2.Bod.EI腿.Updatef = true;
    				}
    				調教UI.Action(ContactType.Feet, ActionType.足コ, CurrentState.Continue, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.主精力消費小();
    				Player.奴体力消費小();
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				ペニス処理2.足固定 = false;
    				調教UI.コキ = false;
    				if (ペニス処理2.腿左 != null)
    				{
    					ペニス処理2.腿左.角度C = 0.0;
    				}
    				if (ペニス処理2.腿右 != null)
    				{
    					ペニス処理2.腿右.角度C = 0.0;
    				}
    				if (ペニス処理2.脚左 != null)
    				{
    					ペニス処理2.脚左.角度C = 0.0;
    				}
    				if (ペニス処理2.脚右 != null)
    				{
    					ペニス処理2.脚右.角度C = 0.0;
    				}
    				if (ペニス処理2.足左 != null)
    				{
    					ペニス処理2.足左.角度C = 0.0;
    				}
    				if (ペニス処理2.足右 != null)
    				{
    					ペニス処理2.足右.角度C = 0.0;
    				}
    				if (ペニス処理2.Bod.EI腿 != null)
    				{
    					ペニス処理2.Bod.EI腿.Updatef = true;
    				}
    				調教UI.Action(ContactType.Feet, ActionType.足コ, CurrentState.End, ToolType.Penis, 0, 1, 機械: false, 射精: false);
    				Player.主精力消費小();
    				Player.奴体力消費小();
    			}
    		};
    		調教UI.Mots.Add(足コキ.GetHashCode().ToString(), 足コキ);
    	}

    	public void SetCha(Character Cha)
    	{
    		base.Cha = Cha;
    		Bod = Cha.Body;
    		if (Bod.Arm人n > 0)
    		{
    			肩左 = Bod.Arm人左[0].Shoulder;
    			UpperArm左 = Bod.Arm人左[0].UpperArm;
    			LowerArm左 = Bod.Arm人左[0].LowerArm;
    			手左 = Bod.Arm人左[0].手;
    			肩右 = Bod.Arm人右[0].Shoulder;
    			UpperArm右 = Bod.Arm人右[0].UpperArm;
    			LowerArm右 = Bod.Arm人右[0].LowerArm;
    			手右 = Bod.Arm人右[0].手;
    		}
    		if (Bod.脚人n > 0)
    		{
    			腿左 = Bod.脚人左[0].腿;
    			脚左 = Bod.脚人左[0].Leg;
    			足左 = Bod.脚人左[0].足;
    			腿右 = Bod.脚人右[0].腿;
    			脚右 = Bod.脚人右[0].Leg;
    			足右 = Bod.脚人右[0].足;
    		}
    	}

    	public new void Reset()
    	{
    		base.Reset();
    		Is手コキ = false;
    		Is足コキ = false;
    		Isパイズリ = false;
    		中出し = false;
    		手固定 = false;
    		足固定 = false;
    		チンピク?.End();
    		射精時間 = 0.0;
    		射精終了?.End();
    		射精?.End();
    		放精?.End();
    		中出しCount = 0;
    		手コキ?.End();
    		手コキ左 = false;
    		フェラ?.End();
    		パイズリ?.End();
    		Isパイズリ相互 = false;
    		Isパイズリ他動 = false;
    		足コキ?.End();
    		持ち手 = false;
    		扱き = 1.0;
    		yi = 0;
    		x = 0.0;
    		y = 0.0;
    		d = 0.0;
    		v = default(Vector2D);
    		o = default(Vector2D);
    		vc = DataConsts.Vec2DZero;
    		挿入箇所 = ContactType.none;
    	}
    }
}
