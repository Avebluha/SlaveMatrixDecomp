using System.ComponentModel;
using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 挿入処理 : 処理B
    {
    	public const bool 口置き = true;

    	public ConstProp CP挿入 = new ConstProp();

    	public ConstProp CP振動 = new ConstProp();

    	private const double mi = 0.35;

    	private ContactType 挿入箇所;

    	private double くぱぁ;

    	private static int P断面人最大i;

    	private static int A断面人最大i;

    	private static int P断面獣最大i;

    	private static int A断面獣最大i;

    	private static double 性器単位v;

    	private static double A通常人最大v;

    	private static double P通常人最大v;

    	private static double A通常獣最大v;

    	private static double P通常獣最大v;

    	private static double 断面単位v;

    	private static double 断面単位v2;

    	private static double 断面単位v3;

    	public bool Is押付;

    	public bool Is挿入;

    	public bool 振動機能;

    	public bool 回転機能;

    	private bool 押し付け;

    	private Motion 振動モーション;

    	private Motion 回転モーション;

    	public Motion 抜け落ち;

    	public double 口排出度 = 1.0;

    	public double 膣排出度 = 1.0;

    	public double 肛排出度 = 1.0;

    	public double 糸排出度 = 1.0;

    	public Motion 挿抜モーション;

    	public bool 挿抜フラグ;

    	private double dv;

    	private int dy;

    	private Vector2D vr;

    	private Vector2D or;

    	private double xr;

    	private double yr;

    	private double a;

    	private double y0;

    	private ShapePart p0;

    	private ShapePart py;

    	private Vector2D bp;

    	private int psi;

    	private bool pn;

    	private double oi;

    	private ContactD cd;

    	private Vector2D v;

    	private Vector2D o;

    	private double x;

    	private double y;

    	public bool Is口 => 挿入箇所 == ContactType.Mouth;

    	public bool Is膣 => 挿入箇所 == ContactType.Vagina;

    	public bool Is肛 => 挿入箇所 == ContactType.Anal;

    	public bool Is糸 => 挿入箇所 == ContactType.Thread;

    	public bool Isモード
    	{
    		get
    		{
    			if (!Is押付)
    			{
    				return Is挿入;
    			}
    			return true;
    		}
    	}

    	public bool 振動
    	{
    		get
    		{
    			if (振動機能)
    			{
    				return 振動モーション.Run;
    			}
    			return false;
    		}
    		set
    		{
    			if (振動機能)
    			{
    				if (value)
    				{
    					振動モーション.Start();
    				}
    				else
    				{
    					振動モーション.End();
    				}
    			}
    		}
    	}

    	public bool 回転
    	{
    		get
    		{
    			if (回転機能)
    			{
    				return 回転モーション.Run;
    			}
    			return false;
    		}
    		set
    		{
    			if (回転機能)
    			{
    				if (value)
    				{
    					回転モーション.Start();
    				}
    				else
    				{
    					回転モーション.End();
    				}
    			}
    		}
    	}

    	private double 排出
    	{
    		get
    		{
    			if (Is口)
    			{
    				return 口排出度 * 2.0 * (振動 ? (2.0 * base.強度) : 1.0) * (回転 ? (0.9 * base.強度) : 1.0);
    			}
    			if (Is膣)
    			{
    				return 膣排出度 * 1.0 * (振動 ? (2.0 * base.強度) : 1.0) * (回転 ? (0.9 * base.強度) : 1.0);
    			}
    			if (Is肛)
    			{
    				return 肛排出度 * 1.0 * (振動 ? (2.0 * base.強度) : 1.0) * (回転 ? (0.9 * base.強度) : 1.0);
    			}
    			if (Is糸)
    			{
    				return 糸排出度 * 0.8 * (振動 ? (2.0 * base.強度) : 1.0) * (回転 ? (0.9 * base.強度) : 1.0);
    			}
    			return 0.0;
    		}
    	}

    	private double 口挿抜
    	{
    		set
    		{
    			if (対象.Element is バイブ_アナル)
    			{
    				対象.Element.Yv = (対象.Element.Yv + value).Clamp(0.0, Bod.Is獣 ? A通常獣最大v : A通常人最大v);
    			}
    			else if (対象.Element is パール)
    			{
    				対象.Element.Yv = (対象.Element.Yv + value).Clamp(0.0, Bod.Is獣 ? P通常獣最大v : P通常人最大v);
    			}
    			else
    			{
    				対象.Element.Yv = (対象.Element.Yv + value).Clamp(0.0, 1.0);
    			}
    		}
    	}

    	private double 膣挿抜
    	{
    		set
    		{
    			if (Bod.断面_表示)
    			{
    				dv = (dv + value).Clamp(0.0, 1.0);
    				dy = ((dv >= 1.0) ? (対象.Element.Body.CountY - 1) : ((int)((double)対象.Element.Body.CountY * dv)));
    				if (対象.Element is バイブ_アナル)
    				{
    					dy = dy.Limit(0, Bod.Is獣 ? A断面獣最大i : A断面人最大i);
    				}
    				else if (対象.Element is パール)
    				{
    					dy = dy.Limit(0, Bod.Is獣 ? P断面獣最大i : P断面人最大i);
    				}
    				if ((!(対象.Element is ハンド) || (対象.Element.Xi != 6 && 対象.Element.Xi != 7)) && !(対象.Element is マウス) && (!Bod.Is獣 || (!(対象.Element is パール) && !(対象.Element is ロータ))))
    				{
    					if (対象.Element is バイブ_デンマ)
    					{
    						Bod.断面.Yv = dv.Clamp(断面単位v, 断面単位v3);
    					}
    					else if (対象.Element is ロータ || 対象.Element is ハンド)
    					{
    						Bod.断面.Yv = dv.Clamp(0.0, 断面単位v2);
    					}
    					else
    					{
    						Bod.断面.Yv = dv.Clamp(0.0, 1.0);
    					}
    				}
    				if (!Bod.Is獣 && !(対象.Element is バイブ_デンマ) && !(対象.Element is ハンド) && !(対象.Element is マウス) && !(対象.Element is ロータ))
    				{
    					Bod.断面.膣サイズY = 1.0 + 0.2 * dv.Clamp(0.0, 1.0);
    					Bod.VaginalCumDrip.尺度YC = Bod.断面.膣サイズY;
    					Bod.膣基.尺度YC = Bod.断面.膣サイズY;
    				}
    				if (!(対象.Element is ハンド) || (対象.Element.Xi != 6 && 対象.Element.Xi != 7))
    				{
    					Bod.性器.Yv = dv.Clamp(性器単位v, 1.0);
    				}
    			}
    			else
    			{
    				if (対象.Element is バイブ_アナル)
    				{
    					対象.Element.Yv = (対象.Element.Yv + value).Clamp(0.0, Bod.Is獣 ? A通常獣最大v : A通常人最大v);
    				}
    				else if (対象.Element is パール)
    				{
    					対象.Element.Yv = (対象.Element.Yv + value).Clamp(0.0, Bod.Is獣 ? P通常獣最大v : P通常人最大v);
    				}
    				else
    				{
    					対象.Element.Yv = (対象.Element.Yv + value).Clamp(0.0, 1.0);
    				}
    				if (!(対象.Element is ハンド) || (対象.Element.Xi != 6 && 対象.Element.Xi != 7))
    				{
    					Bod.性器.Yv = 対象.Element.Yv.Clamp(性器単位v, 1.0);
    				}
    			}
    		}
    	}

    	private double 肛挿抜
    	{
    		set
    		{
    			対象.Element.Yv = (対象.Element.Yv + value).Clamp(0.0, 1.0);
    		}
    	}

    	private double 糸挿抜
    	{
    		set
    		{
    			if (対象.Element is バイブ_アナル)
    			{
    				対象.Element.Yv = (対象.Element.Yv + value).Clamp(0.0, A通常人最大v);
    			}
    			else if (対象.Element is パール)
    			{
    				対象.Element.Yv = (対象.Element.Yv + value).Clamp(0.0, P通常人最大v);
    			}
    			else
    			{
    				対象.Element.Yv = (対象.Element.Yv + value).Clamp(0.0, 1.0);
    			}
    		}
    	}

    	public double Insert
    	{
    		get
    		{
    			if (!Is膣 || !Bod.断面_表示)
    			{
    				return 対象.Element.Yv;
    			}
    			return dv;
    		}
    		set
    		{
    			if (Is口)
    			{
    				口挿抜 = value;
    			}
    			else if (Is膣)
    			{
    				膣挿抜 = value;
    			}
    			else if (Is肛)
    			{
    				肛挿抜 = value;
    			}
    			else if (Is糸)
    			{
    				糸挿抜 = value;
    			}
    		}
    	}

    	public ToolType アイテム情報
    	{
    		get
    		{
    			if (対象.Element is ハンド)
    			{
    				return ToolType.Hand;
    			}
    			if (対象.Element is マウス)
    			{
    				return ToolType.マウス;
    			}
    			if (対象.Element is ペニス)
    			{
    				return ToolType.Penis;
    			}
    			if (対象.Element is バイブ_ディル)
    			{
    				return ToolType.Dildo;
    			}
    			if (対象.Element is バイブ_コモン)
    			{
    				return ToolType.Vibrator;
    			}
    			if (対象.Element is バイブ_ドリル)
    			{
    				return ToolType.Drill;
    			}
    			if (対象.Element is バイブ_デンマ)
    			{
    				return ToolType.デンマ;
    			}
    			if (対象.Element is バイブ_アナル)
    			{
    				return ToolType.AnalVibrator;
    			}
    			if (対象.Element is ロータ)
    			{
    				return ToolType.ロータ;
    			}
    			if (対象.Element is パール)
    			{
    				return ToolType.パール;
    			}
    			return ToolType.none;
    		}
    	}

    	private static void sound口()
    	{
    		if ((0.1 * Player.口挿入度).Lot())
    		{
    			switch (Rng.XS.Next(2))
    			{
    			case 0:
    				//Sounds.挿抜口1.Play();
    				break;
    			case 1:
    				//Sounds.挿抜口2.Play();
    				break;
    			}
    		}
    	}

    	private static void sound膣()
    	{
    		if ((0.1 * Player.膣挿入度 * Player.Tension.Inverse()).Lot())
    		{
    			switch (Rng.XS.Next(2))
    			{
    			case 0:
    				//Sounds.挿抜前1.Play();
    				break;
    			case 1:
    				//Sounds.挿抜前2.Play();
    				break;
    			}
    		}
    	}

    	private static void sound肛()
    	{
    		if ((0.1 * Player.肛挿入度 * Player.Tension.Inverse()).Lot())
    		{
    			switch (GeometryUtils.GetRandomIndex(4.0, 4.0, 1.0, 1.0))
    			{
    			case 0:
    				//Sounds.挿抜前3.Play();
    				break;
    			case 1:
    				//Sounds.挿抜前4.Play();
    				break;
    			case 2:
    				//Sounds.挿抜後1.Play();
    				break;
    			case 3:
    				//Sounds.挿抜後2.Play();
    				break;
    			}
    		}
    	}

    	private static void sound糸()
    	{
    		if ((0.1 * Player.糸挿入度 * Player.Tension.Inverse()).Lot())
    		{
    			switch (Rng.XS.Next(2))
    			{
    			case 0:
    				//Sounds.挿抜糸1.Play();
    				break;
    			case 1:
    				//Sounds.挿抜糸2.Play();
    				break;
    			}
    		}
    	}

    	private double clip(double v)
    	{
    		return (v - 0.35) / 0.65;
    	}

    	public void 口開始()
    	{
    		if (Player.変化V_口 > 0.35)
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, Bod.口腔位置.GetAreaPoint(0.05), GlobalState.口挿.GetVal(clip(Player.変化V_口), Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.HotPink.S(Player.変化V_口.Clamp(0.5, 1.0)), 0.2 + 0.2 * Rng.XS.NextDouble() * Player.変化V_口, b: true);
    			});
    		}
    	}

    	public void 口継続()
    	{
    		if (Player.変化V_口 > 0.35 && CP挿入.GetFlag(0.1 + 0.1 * Player.変化V_口 * 0.8))
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, Bod.口腔位置.GetAreaPoint(0.05), GlobalState.口中.GetVal(clip(Player.変化V_口), Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.HotPink.S(Player.変化V_口.Clamp(0.5, 1.0)), 0.2 + 0.2 * Rng.XS.NextDouble() * Player.変化V_口, b: true);
    			});
    		}
    	}

    	public void 口終了()
    	{
    		if (Player.変化V_口 > 0.35)
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, Bod.口腔位置.GetAreaPoint(0.05), GlobalState.口抜.GetVal(clip(Player.変化V_口), Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.HotPink.S(Player.変化V_口.Clamp(0.5, 1.0)), 0.2 + 0.2 * Rng.XS.NextDouble() * Player.変化V_口, b: true);
    			});
    		}
    	}

    	public void 膣開始()
    	{
    		if (Player.変化V_膣 > 0.35)
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, Bod.膣口位置.GetAreaPoint(0.04), GlobalState.膣挿.GetVal(clip(Player.変化V_膣), Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.DeepPink.S(Player.変化V_膣.Clamp(0.5, 1.0)), 0.2 + 0.2 * Rng.XS.NextDouble() * Player.変化V_膣, b: true);
    			});
    		}
    	}

    	public void 膣継続()
    	{
    		if (Player.変化V_膣 > 0.35 && CP挿入.GetFlag(0.1 + 0.1 * Player.変化V_膣 * 0.8))
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, Bod.膣口位置.GetAreaPoint(0.04), GlobalState.膣中.GetVal(clip(Player.変化V_膣), Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.DeepPink.S(Player.変化V_膣.Clamp(0.5, 1.0)), 0.2 + 0.2 * Rng.XS.NextDouble() * Player.変化V_膣, b: true);
    			});
    		}
    	}

    	public void 膣終了()
    	{
    		if (Player.変化V_膣 > 0.35)
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, Bod.膣口位置.GetAreaPoint(0.04), GlobalState.膣抜.GetVal(clip(Player.変化V_膣), Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.DeepPink.S(Player.変化V_膣.Clamp(0.5, 1.0)), 0.2 + 0.2 * Rng.XS.NextDouble() * Player.変化V_膣, b: true);
    			});
    		}
    	}

    	public void 肛開始()
    	{
    		if (Player.変化V_肛 > 0.35)
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, Bod.肛門位置.GetAreaPoint(0.04), GlobalState.肛挿.GetVal(clip(Player.変化V_肛), Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.Coral.S(Player.変化V_肛.Clamp(0.5, 1.0)), 0.2 + 0.2 * Rng.XS.NextDouble() * Player.変化V_肛, b: true);
    			});
    		}
    	}

    	public void 肛継続()
    	{
    		if (Player.変化V_肛 > 0.35 && CP挿入.GetFlag(0.1 + 0.1 * Player.変化V_肛 * 0.8))
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, Bod.肛門位置.GetAreaPoint(0.04), GlobalState.肛中.GetVal(clip(Player.変化V_肛), Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.Coral.S(Player.変化V_肛.Clamp(0.5, 1.0)), 0.2 + 0.2 * Rng.XS.NextDouble() * Player.変化V_肛, b: true);
    			});
    		}
    	}

    	public void 肛終了()
    	{
    		if (Player.変化V_肛 > 0.35)
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, Bod.肛門位置.GetAreaPoint(0.04), GlobalState.肛抜.GetVal(clip(Player.変化V_肛), Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.Coral.S(Player.変化V_肛.Clamp(0.5, 1.0)), 0.2 + 0.2 * Rng.XS.NextDouble() * Player.変化V_肛, b: true);
    			});
    		}
    	}

    	public void 糸開始()
    	{
    		if (Player.変化V_糸 > 0.35)
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, Bod.出糸位置.GetAreaPoint(0.04), GlobalState.糸挿.GetVal(clip(Player.変化V_糸), Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.MediumOrchid.S(Player.変化V_糸.Clamp(0.5, 1.0)), 0.2 + 0.2 * Rng.XS.NextDouble() * Player.変化V_糸, b: true);
    			});
    		}
    	}

    	public void 糸継続()
    	{
    		if (Player.変化V_糸 > 0.35 && CP挿入.GetFlag(0.1 + 0.1 * Player.変化V_糸 * 0.8))
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, Bod.出糸位置.GetAreaPoint(0.04), GlobalState.糸中.GetVal(clip(Player.変化V_糸), Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.MediumOrchid.S(Player.変化V_糸.Clamp(0.5, 1.0)), 0.2 + 0.2 * Rng.XS.NextDouble() * Player.変化V_糸, b: true);
    			});
    		}
    	}

    	public void 糸終了()
    	{
    		if (Player.変化V_糸 > 0.35)
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, Bod.出糸位置.GetAreaPoint(0.04), GlobalState.糸抜.GetVal(clip(Player.変化V_糸), Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.MediumOrchid.S(Player.変化V_糸.Clamp(0.5, 1.0)), 0.2 + 0.2 * Rng.XS.NextDouble() * Player.変化V_糸, b: true);
    			});
    		}
    	}

    	public void 振動_()
    	{
    		if (CP振動.GetFlag(0.1 + 0.1 * base.強度))
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, 対象.Element.位置.GetAreaPoint(0.04), GlobalState.振動.GetVal(1.0, 1.0), new Font("MS Gothic", 1f), ColorHelper.Black, 0.1 + 0.1 * base.強度, b: true);
    			});
    		}
    	}

    	public void MoveR(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.SubFocus.Contains(this))
    		{
    			vr = cp;

                //TODO Check if this works?
                Vector2D px_diff = Med.FromBasePosition(or - vr);
    			xr = px_diff.X * -0.008;
    			yr = px_diff.Y * -0.008;
    			if (挿入箇所 == ContactType.Vagina)
    			{
    				膣挿抜 = yr * Player.膣挿入度;
    				調教UI.Action(ContactType.Vagina, ActionType.Insertion, CurrentState.Continue, アイテム情報, 対象.Element.Yi, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    				膣継続();
    			}
    			else if (挿入箇所 == ContactType.Anal)
    			{
    				肛挿抜 = yr * Player.肛挿入度;
    				調教UI.Action(ContactType.Anal, ActionType.Insertion, CurrentState.Continue, アイテム情報, 対象.Element.Yi, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    				肛継続();
    			}
    			対象.Element.角度C = (100.0 * xr).Clamp(-5.0, 5.0);
    			or = vr;
    		}
    	}

    	public void SetPosition()
    	{
    		if (!Is挿入)
    		{
    			return;
    		}
    		if (Is口)
    		{
    			a = 対象.Element.角度C;
    			調教UI.Set_口(対象.Element);
    			対象.Element.角度C = a;
    		}
    		else if (Is膣)
    		{
    			if (Bod.断面_表示)
    			{
    				Bod.性器.接続PA();
    				対象.Element.位置B = Bod.性器.Body.Current.EnumAllPar().First((ShapePart p_) => p_.Tag.Contains("膣口")).Position;
    				p0 = 対象.Element.Body.pr[対象.Element.Body[対象.Element.Body.IndexX][0]];
    				py = 対象.Element.Body.pr[対象.Element.Body[対象.Element.Body.IndexX][dy]];
    				if (pn)
    				{
    					bp = py.PositionBase;
    					py.PositionBase = 対象.Element.位置B;
    					y0 = py.ToGlobal(py.OP[0].ps[psi]).Y;
    					py.PositionBase = bp;
    				}
    				else
    				{
    					y0 = py.ToGlobal(py.OP[0].ps[psi]).Y;
    				}
    				対象.Element.位置B = 対象.Element.位置B.AddY(p0.BasePointBase.Y - py.BasePointBase.Y);
    				if (pn)
    				{
    					bp = p0.PositionBase;
    					p0.PositionBase = 対象.Element.位置B;
    					対象.Element.位置B = 対象.Element.位置B.AddY(y0 - p0.ToGlobal(p0.OP[0].ps[psi]).Y);
    					p0.PositionBase = bp;
    				}
    				else
    				{
    					対象.Element.位置B = 対象.Element.位置B.AddY(y0 - p0.ToGlobal(p0.OP[0].ps[psi]).Y);
    				}
    			}
    			else
    			{
    				a = 対象.Element.角度C;
    				調教UI.Set_膣口(対象.Element);
    				対象.Element.角度C = a;
    			}
    		}
    		else if (Is肛)
    		{
    			a = 対象.Element.角度C;
    			調教UI.Set_肛門(対象.Element);
    			対象.Element.角度C = a;
    		}
    		else if (Is糸)
    		{
    			a = 対象.Element.角度C;
    			調教UI.Set_出糸(対象.Element);
    			対象.Element.角度C = a;
    		}
    	}

    	public void 解除()
    	{
    		Is挿入 = false;
    		if (Is口)
    		{
    			Bod.口i = 9;
    		}
    		else if (Is膣)
    		{
    			Bod.性器.Xi = 1;
    			Bod.性器.Yi = 0;
    			if (!(対象.Element is ハンド) || 対象.Element.Xi != 7)
    			{
    				Bod.性器.くぱぁ = くぱぁ;
    			}
    			if (Bod.断面_表示)
    			{
    				Insert = 0.0;
    				Bod.断面.Yi = 0;
    				dv = 0.0;
    				dy = 0;
    			}
    			対象.Under = false;
    		}
    		else if (Is肛)
    		{
    			対象.Under = false;
    		}
    		else
    		{
    			_ = Is糸;
    		}
    		挿入箇所 = ContactType.none;
    		対象.Element.角度C = 0.0;
    		if (対象.Element is ペニス)
    		{
    			対象.Element.Xi = 0;
    		}
    		対象.Element.Yi = 0;
    		if (調教UI.挿入処理s != null)
    		{
    			調教UI.挿入処理s.対象.Element.角度C = 0.0;
    			調教UI.挿入処理s.Insert = 1.0;
    		}
    		調教UI.放し();
    	}

    	private string 挿入中0()
    	{
    		object[] obj = new object[8]
    		{
    			"\r\nMCl:",
    			振動 ? GameText.停止 : GameText.作動,
    			"\r\nWh:",
    			GameText.強さL,
    			強さ,
    			null,
    			null,
    			null
    		};
    		_ = Is口;
    		obj[5] = "\r\nRCl:" + GameText.放す;
    		obj[6] = "\r\nLUp&Mo↓:";
    		obj[7] = GameText.引抜く;
    		return string.Concat(obj);
    	}

    	private void 挿入中1(string str)
    	{
    		if (!GlobalState.GameData.ガイド)
    		{
    			return;
    		}
    		if (振動機能)
    		{
    			ip.SubInfoIm = str + 挿入中0();
    		}
    		else if (!挿抜モーション.Run)
    		{
    			InfoPanel obj = ip;
    			string[] obj2 = new string[6] { str, "\r\n", null, null, null, null };
    			object obj3;
    			if (対象 != 調教UI.ハンド右CM && 対象 != 調教UI.マウスCM && 対象 != 調教UI.ペニスCM)
    			{
    				_ = Is口;
    				obj3 = "RCl:" + GameText.放す + "\r\n";
    			}
    			else
    			{
    				obj3 = "";
    			}
    			obj2[2] = (string)obj3;
    			obj2[3] = "LUp&Mo↓:";
    			obj2[4] = GameText.引抜く;
    			obj2[5] = "\r\n";
    			obj.SubInfoIm = string.Concat(obj2);
    		}
    	}

    	private string 待機時0()
    	{
    		return "MCl:" + (振動 ? GameText.停止 : GameText.作動) + "\r\nWh:" + GameText.強さL + 強さ + "\r\nRCl:" + GameText.放す;
    	}

    	private void 待機時1()
    	{
    		if (GlobalState.GameData.ガイド)
    		{
    			if (振動機能)
    			{
    				ip.SubInfoIm = 待機時0();
    			}
    			else if (対象 == 調教UI.パールCM)
    			{
    				ip.SubInfoIm = "RCl:" + GameText.放す;
    			}
    			else
    			{
    				ip.SubInfoIm = "";
    			}
    		}
    	}

    	private void 押付時(ref ContactD cd)
    	{
    		if (GlobalState.GameData.ガイド)
    		{
    			if (振動機能)
    			{
    				ip.SubInfoIm = (Is押付 ? ("LUp:" + GameText.離す + "\r\n") : (調教UI.IsHitCha(ref cd) ? ("LDo:" + GameText.押付け + "\r\n") : "")) + 待機時0();
    			}
    			else if (対象 == 調教UI.ペニスCM)
    			{
    				ip.SubInfoIm = (Is押付 ? ("LUp:" + GameText.離す) : (調教UI.IsHitCha(ref cd) ? ("LDo:" + GameText.押付け) : ""));
    			}
    			else if (対象 == 調教UI.パールCM)
    			{
    				ip.SubInfoIm = "RCl:" + GameText.放す;
    			}
    			else
    			{
    				ip.SubInfoIm = "";
    			}
    		}
    	}

    	private void 挿入時(string str)
    	{
    		if (GlobalState.GameData.ガイド)
    		{
    			ip.SubInfoIm = str + "\r\nLDo&Mo↑:" + GameText.挿入;
    		}
    	}

    	public void 断面切替(double v)
    	{
    		if (Bod.断面_表示)
    		{
    			対象.Element.Yi = 0;
    			Bod.性器.Xi = 3;
    			dv = v;
    			dy = ((dv >= 1.0) ? (対象.Element.Body.CountY - 1) : ((int)((double)対象.Element.Body.CountY * dv)));
    			if (対象.Element is バイブ_アナル)
    			{
    				dy = dy.Limit(0, Bod.Is獣 ? A断面獣最大i : A断面人最大i);
    			}
    			else if (対象.Element is パール)
    			{
    				dy = dy.Limit(0, Bod.Is獣 ? P断面獣最大i : P断面人最大i);
    			}
    			if ((!(対象.Element is ハンド) || (対象.Element.Xi != 6 && 対象.Element.Xi != 7)) && !(対象.Element is マウス) && (!Bod.Is獣 || (!(対象.Element is パール) && !(対象.Element is ロータ))))
    			{
    				if (対象.Element is バイブ_デンマ)
    				{
    					Bod.断面.Yv = dv.Clamp(断面単位v, 断面単位v3);
    				}
    				else if (対象.Element is ロータ || 対象.Element is ハンド)
    				{
    					Bod.断面.Yv = dv.Clamp(0.0, 断面単位v2);
    				}
    				else
    				{
    					Bod.断面.Yv = dv.Clamp(0.0, 1.0);
    				}
    			}
    			if (!Bod.Is獣 && !(対象.Element is バイブ_デンマ) && !(対象.Element is ハンド) && !(対象.Element is マウス) && !(対象.Element is ロータ))
    			{
    				Bod.断面.膣サイズY = 1.0 + 0.2 * dv.Clamp(0.0, 1.0);
    				Bod.VaginalCumDrip.尺度YC = Bod.断面.膣サイズY;
    				Bod.膣基.尺度YC = Bod.断面.膣サイズY;
    			}
    			if (!(対象.Element is ハンド) || (対象.Element.Xi != 6 && 対象.Element.Xi != 7))
    			{
    				Bod.性器.Yv = dv.Clamp(性器単位v, 1.0);
    			}
    		}
    		else
    		{
    			Bod.性器.Xi = 2;
    			if (対象.Element is バイブ_アナル)
    			{
    				対象.Element.Yv = v.Clamp(0.0, Bod.Is獣 ? A通常獣最大v : A通常人最大v);
    			}
    			else if (対象.Element is パール)
    			{
    				対象.Element.Yv = v.Clamp(0.0, Bod.Is獣 ? P通常獣最大v : P通常人最大v);
    			}
    			else
    			{
    				対象.Element.Yv = v.Clamp(0.0, 1.0);
    			}
    			if (!(対象.Element is ハンド) || (対象.Element.Xi != 6 && 対象.Element.Xi != 7))
    			{
    				Bod.性器.Yv = 対象.Element.Yv.Clamp(性器単位v, 1.0);
    			}
    		}
    	}

    	public void 突き上げ()
    	{
    		if (対象.Element is ペニス && Insert > oi && Insert > 0.8)
    		{
    			Cha.BodySway.Start();
    		}
    		oi = Insert;
    	}

    	public void Move(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (!挿抜モーション.Run)
    		{
    			MoveO(ref mb, ref cp, ref hc, ref cd);
    		}
    	}

    	public void MoveO(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		this.cd = cd;
    		if (調教UI.Focus != 対象 && !調教UI.SubFocus.Contains(this) && !挿抜モーション.Run)
    		{
    			return;
    		}

            //~~TODO~~ fix?
            //v = (挿抜モーション.Run ? cp : _2DGAMELIB._Con.ToVector2D(Cursor.Position));
            v = (挿抜モーション.Run ? cp : Med.CursorPosition);
            System.Diagnostics.Debug.WriteLine("cursor pos: {0} {1}", Med.CursorPosition.X, Med.CursorPosition.Y);

            if (調教UI.Focus == 対象 || 挿抜モーション.Run)
    		{
    			if (Isモード)
    			{
                    Vector2D px_diff = Med.FromBasePosition(o - v);
    				x = px_diff.X * 0.008;
                    y = px_diff.Y * 0.008;

                    System.Diagnostics.Debug.WriteLine("x y diffs: {0} {1}", x, y);
                    if (Is挿入)
    				{
    					対象.Element.角度C = (100.0 * x).Clamp(-5.0, 5.0);
    					if (Is口)
    					{
    						挿入中1(GameText.口腔);
    						口挿抜 = y * Player.口挿入度;
    						調教UI.Action(ContactType.Mouth, ActionType.Insertion, CurrentState.Continue, アイテム情報, 対象.Element.Yi, 1, 機械: false, 射精: false);
    						Player.奴体力消費小();
    						Player.主精力消費小();
    						口継続();

                            //if (mb != MouseButtons.Left && 対象.Element.Yi == 0 && o.Y < v.Y && !挿抜モーション.Run)
                            if (mb != MouseButtons.Left && 対象.Element.Yi == 0 && o.Y > v.Y && !挿抜モーション.Run)
                            {
                                調教UI.Action(ContactType.Mouth, ActionType.Insertion, CurrentState.End, アイテム情報, 0, 1, 機械: false, 射精: false);
    							Player.奴体力消費小();
    							Player.主精力消費小();
    							口終了();
    							解除();

                                //~~TODO~~ fix?
                                //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(対象.Element.位置B));
                                Med.CursorPosition = Med.FromBasePosition(対象.Element.位置B);

    							待機時1();
    							if (調教UI.ペニス処理.フェラ.Run)
    							{
    								調教UI.ペニス処理.フェラ.End();
    							}
    							if (調教UI.ペニス処理.中出し)
    							{
    								if (Cha.CharacterData.SkillL > 0.5 * GlobalState.GameData.TrainingTarget.MaxSkillL && Cha.CharacterData.Affection > 0.6 && Cha.CharacterData.Lust > 0.5)
    								{
    									Cha.Swallow.Start();
    								}
    								else
    								{
    									Cha.MouthCumDrip.Start();
    								}
    								調教UI.ペニス処理.中出しCount = 0;
    								調教UI.ペニス処理.中出し = false;
    							}
    							挿抜モーション.End();
    						}
    						if (Player.Wetness > 0.5 && Player.挿入Lvn > Player.挿入Lvo)
    						{
    							sound口();
    						}
    					}
    					else if (Is肛)
    					{
    						挿入中1(GameText.肛門);
    						肛挿抜 = y * Player.肛挿入度;
    						調教UI.Action(ContactType.Anal, ActionType.Insertion, CurrentState.Continue, アイテム情報, 対象.Element.Yi, 1, 機械: false, 射精: false);
    						Player.奴体力消費小();
    						Player.主精力消費小();
    						肛継続();
                            //if (mb != MouseButtons.Left && 対象.Element.Yi == 0 && o.Y < v.Y && !挿抜モーション.Run)
                            if (mb != MouseButtons.Left && 対象.Element.Yi == 0 && o.Y > v.Y && !挿抜モーション.Run)
    						{
    							調教UI.Action(ContactType.Anal, ActionType.Insertion, CurrentState.End, アイテム情報, 0, 1, 機械: false, 射精: false);
    							Player.奴体力消費小();
    							Player.主精力消費小();
    							肛終了();
    							解除();

                                //~~TODO~~ fix?
                                //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(対象.Element.位置B));
                                Med.CursorPosition = Med.FromBasePosition(対象.Element.位置B);

    							待機時1();
    							if (調教UI.ペニス処理.中出し)
    							{
    								Cha.AnalCumDrip.Start();
    								調教UI.ペニス処理.中出しCount = 0;
    								調教UI.ペニス処理.中出し = false;
    							}
    							挿抜モーション.End();
    						}
    						if (Player.Wetness > 0.5 && Player.挿入Lvn > Player.挿入Lvo)
    						{
    							sound肛();
    						}
    						突き上げ();
    					}
    					else if (Is膣)
    					{
    						挿入中1(GameText.膣腔);
    						膣挿抜 = y * Player.膣挿入度;
    						調教UI.Action(ContactType.Vagina, ActionType.Insertion, CurrentState.Continue, アイテム情報, ((int)(Insert * 5.0)).Clamp(0, 4), 1, 機械: false, 射精: false);
    						Player.奴体力消費小();
    						Player.主精力消費小();
    						膣継続();

                            //if (mb != MouseButtons.Left && (Bod.断面_表示 ? (dy == 0) : (対象.Element.Yi == 0)) && o.Y < v.Y && !挿抜モーション.Run)
                            if (mb != MouseButtons.Left && (Bod.断面_表示 ? (dy == 0) : (対象.Element.Yi == 0)) && o.Y > v.Y && !挿抜モーション.Run)
    						{
    							調教UI.Action(ContactType.Vagina, ActionType.Insertion, CurrentState.End, アイテム情報, 0, 1, 機械: false, 射精: false);
    							Player.奴体力消費小();
    							Player.主精力消費小();
    							膣終了();
    							解除();

                                //~~TODO~~ fix?
                                //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(対象.Element.位置B));
                                Med.CursorPosition = Med.FromBasePosition(対象.Element.位置B);

    							待機時1();
    							if (調教UI.ペニス処理.中出し)
    							{
    								Cha.GenitalCumDrip.Start();
    								調教UI.ペニス処理.中出しCount = 0;
    								調教UI.ペニス処理.中出し = false;
    							}
    							挿抜モーション.End();
    						}
    						if (Player.Wetness > 0.5 && Player.挿入Lvn > Player.挿入Lvo)
    						{
    							sound膣();
    						}
    						突き上げ();
    					}
    					else if (Is糸)
    					{
    						挿入中1(GameText.出糸);
    						糸挿抜 = y * Player.糸挿入度;
    						調教UI.Action(ContactType.Thread, ActionType.Insertion, CurrentState.Continue, アイテム情報, 対象.Element.Yi, 1, 機械: false, 射精: false);
    						Player.奴体力消費小();
    						Player.主精力消費小();
    						糸継続();
                            //if (mb != MouseButtons.Left && 対象.Element.Yi == 0 && o.Y < v.Y && !挿抜モーション.Run)
                            if (mb != MouseButtons.Left && 対象.Element.Yi == 0 && o.Y > v.Y && !挿抜モーション.Run)
    						{
    							調教UI.Action(ContactType.Thread, ActionType.Insertion, CurrentState.End, アイテム情報, 0, 1, 機械: false, 射精: false);
    							Player.奴体力消費小();
    							Player.主精力消費小();
    							糸終了();
    							解除();
                                //~~TODO~~ fix?
                                //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(対象.Element.位置B));
                                Med.CursorPosition = Med.FromBasePosition(対象.Element.位置B);

    							待機時1();
    							if (調教UI.ペニス処理.中出し)
    							{
    								Cha.ThreadCumDrip.Start();
    								調教UI.ペニス処理.中出しCount = 0;
    								調教UI.ペニス処理.中出し = false;
    							}
    							挿抜モーション.End();
    						}
    						if (Player.Wetness > 0.5 && Player.挿入Lvn > Player.挿入Lvo)
    						{
    							sound糸();
    						}
    					}
    				}
    				else if (Is押付)
    				{
    					if (調教UI.IsHitCha(ref cd))
    					{
    						if (!調教UI.押し状態)
    						{
    							調教UI.押し(ref cd);
    							調教UI.Action(cd.c, ActionType.Contact, CurrentState.Start, アイテム情報, 0, 1, 機械: false, 射精: false);
    							Player.奴体力消費小();
    							Player.主精力消費小();
    						}
    						if (対象 == 調教UI.ペニスCM)
    						{
    							対象.Element.角度C = (100.0 * x).Clamp(-4.0, 4.0);
    						}
    						else
    						{
    							対象.Element.角度C = (100.0 * x).Clamp(-11.0, 11.0);
    						}
    						調教UI.Action(cd.c, ActionType.Contact, CurrentState.Continue, アイテム情報, 0, 1, 機械: false, 射精: false);
    						Player.奴体力消費小();
    						Player.主精力消費小();
    					}
    					else if (調教UI.押し状態)
    					{
    						調教UI.Action(cd.c, ActionType.Contact, CurrentState.End, アイテム情報, 0, 1, 機械: false, 射精: false);
    						Player.奴体力消費小();
    						Player.主精力消費小();
    						対象.Element.角度C = 0.0;
    						調教UI.放し();
    					}
    					押付時(ref cd);
    				}
    			}
    			else if (Player.フェラ1 && cd.c == ContactType.Mouth && !調教UI.SubFocus.Any((挿入処理 e) => e.Is口))
    			{
    				調教UI.Set_口(対象.Element);
    				挿入時(GameText.口腔);
    			}
    			else if (cd.c == ContactType.Anal && !調教UI.SubFocus.Any((挿入処理 e) => e.Is肛))
    			{
    				調教UI.Set_肛門(対象.Element);
    				挿入時(GameText.肛門);
    			}
    			else if (cd.c == ContactType.Vagina && !調教UI.SubFocus.Any((挿入処理 e) => e.Is膣))
    			{
    				調教UI.Set_膣口(対象.Element);
    				挿入時(GameText.膣腔);
    			}
    			else if (cd.c == ContactType.Thread && !調教UI.SubFocus.Any((挿入処理 e) => e.Is糸))
    			{
    				調教UI.Set_出糸(対象.Element);
    				挿入時(GameText.出糸);
    			}
    			else if (押し付け)
    			{
    				押付時(ref cd);
    			}
    			else
    			{
    				待機時1();
    			}
    		}
    		o = v;
    	}

    	private void 差し置き()
    	{
    		if (調教UI.Focus == 調教UI.ペニスCM || 調教UI.Focus == 調教UI.マウスCM)
    		{
    			調教UI.挿入放し();
    			対象.Element.角度C = 0.0;
    			if (調教UI.挿入処理s != null)
    			{
    				調教UI.挿入処理s.対象.Element.角度C = 0.0;
    				調教UI.挿入処理s.Insert = 1.0;
    			}
    			調教UI.放し();
    		}
    	}

    	public void Down(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus != 対象)
    		{
    			return;
    		}
    		if (mb == MouseButtons.Left)
    		{
    			if (!Isモード)
    			{
    				if (Player.フェラ1 && cd.c == ContactType.Mouth && !調教UI.SubFocus.Any((挿入処理 e) => e.Is口))
    				{
    					調教UI.押し(ref cd);
    					Is挿入 = true;
    					挿入箇所 = cd.c;
    					if (対象.Element is ペニス)
    					{
    						対象.Element.Xi = 1;
    					}
    					対象.Element.Yi = 0;
    					Bod.口i = 13;
    					if (Player.フェラ2)
    					{
    						調教UI.ペニス処理.フェラ.Start();
    					}
    					調教UI.Action(ContactType.Mouth, ActionType.Insertion, CurrentState.Start, アイテム情報, 0, 1, 機械: false, 射精: false);
    					Player.奴体力消費小();
    					Player.主精力消費小();
    					口開始();
    					調教UI.口腔演出();
    					調教UI.腕修正();
    					調教UI.大顎修正();
    				}
    				else if (cd.c == ContactType.Anal && !調教UI.SubFocus.Any((挿入処理 e) => e.Is肛))
    				{
    					調教UI.押し(ref cd);
    					Is挿入 = true;
    					挿入箇所 = cd.c;
    					if (対象.Element is ペニス)
    					{
    						対象.Element.Xi = 1;
    					}
    					対象.Element.Yi = 0;
    					対象.Under = true;
    					調教UI.Action(ContactType.Anal, ActionType.Insertion, CurrentState.Start, アイテム情報, 0, 1, 機械: false, 射精: false);
    					Player.奴体力消費小();
    					Player.主精力消費小();
    					肛開始();
    					調教UI.肛門演出();
    					調教UI.脚修正();
    				}
    				else if (cd.c == ContactType.Vagina && !調教UI.SubFocus.Any((挿入処理 e) => e.Is膣))
    				{
    					調教UI.押し(ref cd);
    					Is挿入 = true;
    					挿入箇所 = cd.c;
    					if (対象.Element is ペニス)
    					{
    						対象.Element.Xi = 1;
    					}
    					対象.Element.Yi = 0;
    					対象.Under = true;
    					if (Bod.断面_表示)
    					{
    						Bod.性器.Xi = 3;
    					}
    					else
    					{
    						Bod.性器.Xi = 2;
    					}
    					Bod.性器.Yi = 1;
    					if ((!(対象.Element is ハンド) || 対象.Element.Xi != 7) && !(対象.Element is マウス))
    					{
    						くぱぁ = Bod.性器.くぱぁ;
    						Bod.性器.くぱぁ = 1.0;
    					}
    					調教UI.Action(ContactType.Vagina, ActionType.Insertion, CurrentState.Start, アイテム情報, 0, 1, 機械: false, 射精: false);
    					Player.奴体力消費小();
    					Player.主精力消費小();
    					膣開始();
    					調教UI.膣腔演出();
    					調教UI.脚修正();
    				}
    				else if (cd.c == ContactType.Thread && !調教UI.SubFocus.Any((挿入処理 e) => e.Is糸))
    				{
    					調教UI.押し(ref cd);
    					Is挿入 = true;
    					挿入箇所 = cd.c;
    					if (対象.Element is ペニス)
    					{
    						対象.Element.Xi = 1;
    					}
    					対象.Element.Yi = 0;
    					調教UI.Action(ContactType.Thread, ActionType.Insertion, CurrentState.Start, アイテム情報, 0, 1, 機械: false, 射精: false);
    					Player.奴体力消費小();
    					Player.主精力消費小();
    					糸開始();
    					調教UI.出糸演出();
    					調教UI.脚修正();
    				}
    				else if (押し付け && !Is押付 && 調教UI.IsHitCha(ref cd))
    				{
    					調教UI.押し(ref cd);
    					Is押付 = true;
    					押付時(ref cd);
    					調教UI.Action(cd.c, ActionType.Contact, CurrentState.Start, アイテム情報, 0, 1, 機械: false, 射精: false);
    					Player.奴体力消費小();
    					Player.主精力消費小();
    					調教UI.肌体演出();
    				}
    			}
    			else if ((調教UI.Focus == 調教UI.マウスCM && Is口) || (調教UI.Focus != 調教UI.マウスCM && 調教UI.Focus != 調教UI.ハンド右CM))
    			{
    				if (挿抜フラグ)
    				{
    					挿抜フラグ = false;
    					return;
    				}
    				if (挿抜モーション.Run)
    				{
    					挿抜モーション.End();
    					return;
    				}
    				挿抜モーション.Start();
    				差し置き();
    			}
    		}
    		else if (mb == MouseButtons.Middle)
    		{
    			if (!振動機能)
    			{
    				return;
    			}
    			振動 = !振動;
    			if (回転機能)
    			{
    				回転 = !回転;
    			}
    			if (Is挿入)
    			{
    				if (GlobalState.GameData.ガイド)
    				{
    					if (Is口)
    					{
    						ip.SubInfoIm = GameText.口腔 + 挿入中0();
    					}
    					else if (Is肛)
    					{
    						ip.SubInfoIm = GameText.肛門 + 挿入中0();
    					}
    					else if (Is膣)
    					{
    						ip.SubInfoIm = GameText.膣腔 + 挿入中0();
    					}
    					else if (Is糸)
    					{
    						ip.SubInfoIm = GameText.出糸 + 挿入中0();
    					}
    				}
    			}
    			else
    			{
    				押付時(ref cd);
    			}
    		}
    		else
    		{
    			if (mb != MouseButtons.Right || 調教UI.コキ)
    			{
    				return;
    			}
    			_ = Is口;
    			if (Is挿入 && ((!Is膣 && 対象.Element.Yi > 0) || (Is膣 && Bod.断面_表示 && dy > 0) || (!Bod.断面_表示 && 対象.Element.Yi > 0)))
    			{
    				if (調教UI.Focus != 調教UI.ハンド右CM && 調教UI.Focus != 調教UI.マウスCM && 調教UI.Focus != 調教UI.ペニスCM)
    				{
    					挿抜モーション.End();
    					調教UI.挿入放し();
    					対象.Element.角度C = 0.0;
    					if (調教UI.挿入処理s != null)
    					{
    						調教UI.挿入処理s.対象.Element.角度C = 0.0;
    						調教UI.挿入処理s.Insert = 1.0;
    					}
    					調教UI.放し();
    				}
    			}
    			else if (調教UI.Focus != 調教UI.ハンド右CM && !Isモード)
    			{
    				解除();
                    //~~TODO~~ fix?
                    //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(対象.Element.位置B));
                    Med.CursorPosition = Med.FromBasePosition(対象.Element.位置B);
    				調教UI.通常放し();
    			}
    		}
    	}

    	public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus == 対象 && mb == MouseButtons.Left && 押し付け && Is押付)
    		{
    			調教UI.Action(cd.c, ActionType.Contact, CurrentState.End, アイテム情報, 0, 1, 機械: false, 射精: false);
    			Player.奴体力消費小();
    			Player.主精力消費小();
    			調教UI.放し();
    			対象.Element.角度C = 0.0;
    			Is押付 = false;
    			if (調教UI.IsHitCha(ref cd))
    			{
    				押付時(ref cd);
    			}
    			else
    			{
    				待機時1();
    			}
    		}
    	}

    	public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
    	{
    	}

    	public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus != 対象 || !振動機能)
    		{
    			return;
    		}
    		強さ = (強さ + dt.Sign()).Clamp(1, 3);
    		if (回転機能)
    		{
    			回転モーション.BaseSpeed = 10.0 * base.強度;
    		}
    		if (!GlobalState.GameData.ガイド)
    		{
    			ip.SubInfoIm = "Wh:" + GameText.強さL + 強さ;
    		}
    		else if (Is挿入)
    		{
    			if (GlobalState.GameData.ガイド)
    			{
    				if (挿入箇所 == ContactType.Mouth)
    				{
    					ip.SubInfoIm = GameText.口腔 + 挿入中0();
    				}
    				else if (挿入箇所 == ContactType.Anal)
    				{
    					ip.SubInfoIm = GameText.肛門 + 挿入中0();
    				}
    				else if (挿入箇所 == ContactType.Vagina)
    				{
    					ip.SubInfoIm = GameText.膣腔 + 挿入中0();
    				}
    				else if (挿入箇所 == ContactType.Thread)
    				{
    					ip.SubInfoIm = GameText.出糸 + 挿入中0();
    				}
    			}
    		}
    		else
    		{
    			押付時(ref cd);
    		}
    	}

    	public 挿入処理(TrainingUI 調教UI, CharacterElement 対象)
    		: base(調教UI, 対象)
    	{
    		挿入処理 挿入処理2 = this;
    		振動機能 = !(対象.Element is ペニス) && !(対象.Element is マウス) && !(対象.Element is ハンド) && !(対象.Element is パール);
    		if (振動機能)
    		{
    			double d = 0.0005;
    			if (対象.Element is ロータ)
    			{
    				d *= 1.0;
    			}
    			else if (対象.Element is バイブ_ディル)
    			{
    				d *= 1.1;
    			}
    			else if (対象.Element is バイブ_コモン)
    			{
    				d *= 1.2;
    			}
    			else if (対象.Element is バイブ_ドリル)
    			{
    				d *= 1.2;
    			}
    			else if (対象.Element is バイブ_アナル)
    			{
    				d *= 1.1;
    			}
    			else if (対象.Element is バイブ_デンマ)
    			{
    				d *= 1.5;
    			}
    			Vector2D p = DataConsts.Vec2DZero;
    			bool f = !(対象.Element is ロータ);
    			bool v = 対象.Element is バイブ_ディル || 対象.Element is バイブ_コモン || 対象.Element is バイブ_ドリル || 対象.Element is バイブ_アナル || 対象.Element is バイブ_デンマ;
    			振動モーション = new Motion(-1.0, 1.0)
    			{
    				BaseSpeed = double.MaxValue,
    				OnStart = delegate
    				{
    				},
    				OnUpdate = delegate(Motion m)
    				{
    					p.X = m.Value * d * 挿入処理2.強度;
    					if (v)
    					{
    						対象.Element.位置C = p.MulX(0.5);
    						対象.Element.Body.Current.EnumAllPar().First((ShapePart e) => e.Tag.Contains("ヘッド")).PositionCont = p;
    					}
    					else
    					{
    						対象.Element.位置C = p;
    					}
    					if (f && 挿入処理2.Is挿入)
    					{
    						if (挿入処理2.dy > 3)
    						{
    							p.X *= 0.5;
    							挿入処理2.Bod.断面.位置C = p;
    						}
    						else if (挿入処理2.dy > 2)
    						{
    							p.X *= 0.25;
    							挿入処理2.Bod.断面.位置C = p;
    						}
    					}
    					if (挿入処理2.Is挿入)
    					{
    						調教UI.Action(挿入処理2.挿入箇所, ActionType.Insertion, CurrentState.Continue, 挿入処理2.アイテム情報, 対象.Element.Yi, 挿入処理2.強さ, 機械: true, 射精: false);
    						Player.奴体力消費小();
    					}
    					else if (挿入処理2.Is押付 && 調教UI.押し状態)
    					{
    						調教UI.Action(挿入処理2.cd.c, ActionType.Tickle, CurrentState.Continue, 挿入処理2.アイテム情報, 0, 挿入処理2.強さ, 機械: true, 射精: false);
    						Player.奴体力消費小();
    					}
    					挿入処理2.振動_();
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
    					foreach (ShapePart item in 対象.Element.Body.EnumAllPar())
    					{
    						item.PositionCont = DataConsts.Vec2DZero;
    					}
    					挿入処理2.Bod.断面.位置C = DataConsts.Vec2DZero;
    				}
    			};
    			調教UI.Mots.Add(振動モーション.GetHashCode().ToString(), 振動モーション);
    		}
    		回転機能 = 対象.Element is バイブ_ドリル;
    		if (回転機能)
    		{
    			回転モーション = new Motion(0.0, 1.0)
    			{
    				BaseSpeed = 10.0 * base.強度,
    				OnStart = delegate
    				{
    					対象.Element.Xv = 0.0;
    				},
    				OnUpdate = delegate(Motion m)
    				{
    					対象.Element.Xv = m.Value;
    					対象.Element.Body.JoinPA();
    					if (挿入処理2.Is挿入)
    					{
    						調教UI.Action(挿入処理2.挿入箇所, ActionType.Insertion, CurrentState.Continue, 挿入処理2.アイテム情報, 対象.Element.Yi, 挿入処理2.強さ, 機械: true, 射精: false);
    						Player.奴体力消費小();
    					}
    					else if (挿入処理2.Is押付 && 調教UI.押し状態)
    					{
    						調教UI.Action(挿入処理2.cd.c, ActionType.Tickle, CurrentState.Continue, 挿入処理2.アイテム情報, 0, 挿入処理2.強さ, 機械: true, 射精: false);
    						Player.奴体力消費小();
    					}
    					挿入処理2.振動_();
    				},
    				OnReach = delegate(Motion m)
    				{
    					m.ResetValue();
    				},
    				OnLoop = delegate
    				{
    				},
    				OnEnd = delegate(Motion m)
    				{
    					m.ResetValue();
    					対象.Element.Xv = 0.0;
    				}
    			};
    			調教UI.Mots.Add(回転モーション.GetHashCode().ToString(), 回転モーション);
    		}
    		抜け落ち = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				挿入処理2.Insert = (-0.01 - 0.04 * 挿入処理2.Insert.Inverse()) * 挿入処理2.排出;
    				if (挿入処理2.Insert == 0.0)
    				{
    					調教UI.Action(挿入処理2.挿入箇所, ActionType.Insertion, CurrentState.End, 挿入処理2.アイテム情報, 0, 1, 機械: false, 射精: false);
    					Player.奴体力消費小();
    					switch (挿入処理2.挿入箇所)
    					{
    					case ContactType.Mouth:
    						挿入処理2.口終了();
    						break;
    					case ContactType.Vagina:
    						挿入処理2.膣終了();
    						break;
    					case ContactType.Anal:
    						挿入処理2.肛終了();
    						break;
    					case ContactType.Thread:
    						挿入処理2.糸終了();
    						break;
    					}
    					挿入処理2.解除();
    					対象.Element.Intensity = 0.5;
    					対象.StaShow = true;
    					対象.使用状態 = UsageStatus.Standby;
    					対象.Element.右 = false;
    					対象.Element.位置B = 対象.bp;
    					対象.Element.位置C = DataConsts.Vec2DZero;
    					対象.Element.角度B = 0.0;
    					対象.Element.角度C = 0.0;
    					対象.Element.Xi = 0;
    					対象.Element.Yi = 0;
    					if (挿入処理2.振動機能)
    					{
    						挿入処理2.振動 = false;
    					}
    					if (挿入処理2.回転機能)
    					{
    						挿入処理2.回転 = false;
    					}
    					挿入処理2.選択 = false;
    					対象.Element.尺度C = 1.09;
    					調教UI.SubFocus.Remove(挿入処理2);
    					m.End();
    				}
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
    			}
    		};
    		調教UI.Mots.Add(抜け落ち.GetHashCode().ToString(), 抜け落ち);
    		押し付け = 振動機能 || 対象.Element is ペニス;
    		A断面獣最大i = 5;
    		A断面人最大i = A断面獣最大i - 1;
    		double num = 1.0 / (double)調教UI.アナル.Body.CountY;
    		A通常獣最大v = num * (double)(A断面獣最大i - 1);
    		A通常人最大v = num * (double)(A断面人最大i - 1);
    		P断面獣最大i = 11;
    		P断面人最大i = P断面獣最大i - 1;
    		double num2 = 1.0 / (double)調教UI.パール.Body.CountY;
    		P通常獣最大v = num2 * (double)(P断面獣最大i - 1);
    		P通常人最大v = num2 * (double)(P断面人最大i - 1);
    		psi = ((対象.Element is ロータ) ? 2 : 0);
    		pn = 対象.Element is ペニス;
    		MouseButtons mb_ = MouseButtons.None;
    		Vector2D cp_ = default(Vector2D);
    		Color hc_ = default(Color);
    		挿抜モーション = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0 + 3.0 * Player.PlayerExcitement,
    			OnStart = delegate
    			{
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				m.BaseSpeed = 1.0 + 3.0 * Player.PlayerExcitement;
    				cp_ = new Vector2D(0.0, 100.0 * m.Value);
    				挿入処理2.MoveO(ref mb_, ref cp_, ref hc_, ref 挿入処理2.cd);
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    			}
    		};
    		調教UI.Mots.Add(挿抜モーション.GetHashCode().ToString(), 挿抜モーション);
    	}

    	public void SetCha(Character Cha)
    	{
    		base.Cha = Cha;
    		Bod = Cha.Body;
    		性器単位v = 1.0 / (double)Bod.性器.Body.CountY;
    		断面単位v = 1.0 / (double)Bod.断面.Body.CountY;
    		断面単位v2 = 断面単位v * 2.0;
    		断面単位v3 = 断面単位v * 3.0;
    	}

    	public new void Reset()
    	{
    		if (Is挿入)
    		{
    			switch (挿入箇所)
    			{
    			case ContactType.Mouth:
    				口終了();
    				break;
    			case ContactType.Vagina:
    				膣終了();
    				break;
    			case ContactType.Anal:
    				肛終了();
    				break;
    			case ContactType.Thread:
    				糸終了();
    				break;
    			}
    			解除();
    			対象.Element.Intensity = 0.5;
    			対象.StaShow = true;
    			対象.使用状態 = UsageStatus.Standby;
    			対象.Element.右 = false;
    			対象.Element.位置B = 対象.bp;
    			対象.Element.位置C = DataConsts.Vec2DZero;
    			対象.Element.角度B = 0.0;
    			対象.Element.角度C = 0.0;
    			対象.Element.Xi = 0;
    			対象.Element.Yi = 0;
    			if (振動機能)
    			{
    				振動 = false;
    			}
    			if (回転機能)
    			{
    				回転 = false;
    			}
    			選択 = false;
    			対象.Element.尺度C = 1.09;
    			調教UI.SubFocus.Remove(this);
    		}
    		base.Reset();
    		CP挿入.Reset();
    		CP振動.Reset();
    		挿入箇所 = ContactType.none;
    		くぱぁ = 0.0;
    		Is押付 = false;
    		Is挿入 = false;
    		振動モーション?.End();
    		振動 = false;
    		回転モーション?.End();
    		回転 = false;
    		抜け落ち?.End();
    		挿抜モーション?.End();
    		挿抜フラグ = false;
    		口排出度 = 1.0;
    		膣排出度 = 1.0;
    		肛排出度 = 1.0;
    		糸排出度 = 1.0;
    		dv = 0.0;
    		dy = 0;
    		口挿抜 = 0.0;
    		膣挿抜 = 0.0;
    		肛挿抜 = 0.0;
    		糸挿抜 = 0.0;
    		vr = default(Vector2D);
    		or = default(Vector2D);
    		xr = 0.0;
    		yr = 0.0;
    		a = 0.0;
    		y0 = 0.0;
    		p0 = null;
    		py = null;
    		bp = default(Vector2D);
    		解除();
    		oi = 0.0;
    		cd = default(ContactD);
    		v = default(Vector2D);
    		o = default(Vector2D);
    		x = 0.0;
    		y = 0.0;
    	}
    }
}
