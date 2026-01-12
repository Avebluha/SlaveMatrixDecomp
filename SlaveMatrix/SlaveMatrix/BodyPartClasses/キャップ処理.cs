using System.Collections.Generic;
using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class キャップ処理 : 処理B
    {
    	public ConstProp CP中 = new ConstProp();

    	public ConstProp CP左 = new ConstProp();

    	public ConstProp CP右 = new ConstProp();

    	public CM キャップ1;

    	public CM キャップ2;

    	public CM キャップ3;

    	private Dictionary<Ele, CM> キャップ = new Dictionary<Ele, CM>();

    	private キャップ情報 キャップ着;

    	private キャップ情報 キャップ脱;

    	public bool キャップ中着;

    	public bool キャップ左着;

    	public bool キャップ右着;

    	private bool ハンドf;

    	private Mot キャップ振動;

    	private bool キャップ中_;

    	private bool キャップ左_;

    	private bool キャップ右_;

    	public bool Is仮着
    	{
    		get
    		{
    			if ((キャップ中着 || !Isキャップ1着()) && (キャップ左着 || !Isキャップ2左着()))
    			{
    				if (!キャップ右着)
    				{
    					return Isキャップ2右着();
    				}
    				return false;
    			}
    			return true;
    		}
    	}

    	public bool キャップ中
    	{
    		get
    		{
    			return キャップ中_;
    		}
    		set
    		{
    			キャップ中_ = value;
    			if (!キャップ中_)
    			{
    				Bod.キャップ1.位置C = Dat.Vec2DZero;
    			}
    			if (キャップ中_ || キャップ左_ || キャップ右_)
    			{
    				キャップ振動.Start();
    			}
    			else
    			{
    				キャップ振動.End();
    			}
    		}
    	}

    	public bool キャップ左
    	{
    		get
    		{
    			return キャップ左_;
    		}
    		set
    		{
    			キャップ左_ = value;
    			if (!キャップ左_)
    			{
    				Bod.キャップ1.位置C = Dat.Vec2DZero;
    			}
    			if (キャップ中_ || キャップ左_ || キャップ右_)
    			{
    				キャップ振動.Start();
    			}
    			else
    			{
    				キャップ振動.End();
    			}
    		}
    	}

    	public bool キャップ右
    	{
    		get
    		{
    			return キャップ右_;
    		}
    		set
    		{
    			キャップ右_ = value;
    			if (!キャップ右_)
    			{
    				Bod.キャップ1.位置C = Dat.Vec2DZero;
    			}
    			if (キャップ中_ || キャップ左_ || キャップ右_)
    			{
    				キャップ振動.Start();
    			}
    			else
    			{
    				キャップ振動.End();
    			}
    		}
    	}

    	public void 吸着(Ele 対象)
    	{
    		調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    		{
    			調教UI.擬音.Sound(a, 対象.位置.GetAreaPoint(0.01), Sta.吸着.GetVal(1.0, 1.0), new Font("MS Gothic", 1f), Col.Black, 0.2, b: true);
    		});
    	}

    	public void 吸脱(Ele 対象)
    	{
    		調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    		{
    			調教UI.擬音.Sound(a, 対象.位置.GetAreaPoint(0.01), Sta.吸脱.GetVal(1.0, 1.0), new Font("MS Gothic", 1f), Col.Black, 0.2, b: true);
    		});
    	}

    	public void 振動(Ele 対象)
    	{
    		if ((対象 is キャップ1 && CP中.GetFlag(0.2)) || (対象 is キャップ2 && !対象.右 && CP左.GetFlag(0.2)) || (対象 is キャップ2 && 対象.右 && CP右.GetFlag(0.2)))
    		{
    			調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    			{
    				調教UI.擬音.Sound(a, 対象.位置.GetAreaPoint(0.02), Sta.振動.GetVal(1.0, 1.0), new Font("MS Gothic", 1f), Col.Black, 0.15, b: true);
    			});
    		}
    	}

    	public bool Isキャップ1着()
    	{
    		return Bod.Setキャップ1.Equals(キャップ着);
    	}

    	public bool Isキャップ2左着()
    	{
    		return Bod.Setキャップ2左.Equals(キャップ着);
    	}

    	public bool Isキャップ2右着()
    	{
    		return Bod.Setキャップ2右.Equals(キャップ着);
    	}

    	private void 切替時(bool 対象)
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = "MCl:" + (対象 ? GameText.停止 : GameText.作動) + "\r\nLCl:" + GameText.外す;
    		}
    	}

    	private void 装着時()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = "LCl:" + GameText.装着;
    		}
    	}

    	private void 待機時()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			if (ハンドf)
    			{
    				ip.SubInfoIm = "";
    			}
    			else
    			{
    				ip.SubInfoIm = "RCl:" + GameText.放す;
    			}
    		}
    	}

    	private void SetFocus(Vector2D p)
    	{
    		if (調教UI.Focus == キャップ1)
    		{
    			if (キャップ2.Show)
    			{
    				調教UI.Focus = キャップ2;
    			}
    			else if (キャップ3.Show)
    			{
    				調教UI.Focus = キャップ3;
    			}
    			else
    			{
    				ハンドf = true;
    			}
    			キャップ1.Show = false;
    			キャップ1.使用状態 = UsageStatus.Attach;
    		}
    		else if (調教UI.Focus == キャップ2)
    		{
    			if (キャップ1.Show)
    			{
    				調教UI.Focus = キャップ1;
    			}
    			else if (キャップ3.Show)
    			{
    				調教UI.Focus = キャップ3;
    			}
    			else
    			{
    				ハンドf = true;
    			}
    			キャップ2.Show = false;
    			キャップ2.使用状態 = UsageStatus.Attach;
    		}
    		else if (調教UI.Focus == キャップ3)
    		{
    			if (キャップ1.Show)
    			{
    				調教UI.Focus = キャップ1;
    			}
    			else if (キャップ2.Show)
    			{
    				調教UI.Focus = キャップ2;
    			}
    			else
    			{
    				ハンドf = true;
    			}
    			キャップ3.Show = false;
    			キャップ3.使用状態 = UsageStatus.Attach;
    		}
    		調教UI.Focus.Ele.位置B = p;
    		if (!ハンドf)
    		{
    			調教UI.Set持ち手();
    		}
    	}

    	public void キャップ中外し()
    	{
    		if (キャップ中着)
    		{
    			キャップ中 = false;
    			Bod.Setキャップ1 = キャップ脱;
    			if (キャップ.ContainsKey(Bod.キャップ1))
    			{
    				キャップ[Bod.キャップ1].Show = true;
    				キャップ[Bod.キャップ1].DraShow = true;
    				キャップ[Bod.キャップ1].StaShow = true;
    				キャップ[Bod.キャップ1].描画Show = true;
    				キャップ[Bod.キャップ1].Ele.濃度 = 0.5;
    				キャップ[Bod.キャップ1].使用状態 = UsageStatus.Standby;
    				キャップ.Remove(Bod.キャップ1);
    			}
    			キャップ中着 = false;
    		}
    	}

    	public void Move(ref MouseButtons mb, ref Vector2D cp, ref Vector2D op, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus == 調教UI.ハンド右CM)
    		{
    			if (!調教UI.ハンド処理.Isモード)
    			{
    				if (キャップ中着 && (cd.e is キャップ1 || cd.c == ContactType.Nucleus))
    				{
    					調教UI.ハンド右.Body.IndexX = 5;
    					調教UI.Set_キャップ中(調教UI.ハンド右);
    					切替時(キャップ中);
    				}
    				else if (キャップ左着 && (cd.e is キャップ2 || cd.c == ContactType.Milk) && !cd.e.右)
    				{
    					調教UI.ハンド右CM.Show = false;
    					調教UI.ハンド左表示 = true;
    					調教UI.ハンド左.位置B = cp;
    					調教UI.ハンド左.Body.IndexX = 5;
    					調教UI.Set_キャップ左(調教UI.ハンド左);
    					切替時(キャップ左);
    				}
    				else if (キャップ右着 && (cd.e is キャップ2 || cd.c == ContactType.Milk) && cd.e.右)
    				{
    					調教UI.ハンド右.Body.IndexX = 5;
    					調教UI.Set_キャップ右(調教UI.ハンド右);
    					切替時(キャップ右);
    				}
    				else if (cd.c != ContactType.Milk && (キャップ中着 || キャップ左着 || キャップ右着) && (調教UI.ハンド右.Body.IndexX == 5 || 調教UI.ハンド左.Body.IndexX == 5))
    				{
    					調教UI.ハンド左表示 = false;
    					調教UI.ハンド右CM.Show = true;
    					調教UI.ハンド右.Body.IndexX = 0;
    					調教UI.ハンド左.Body.IndexX = 0;
    				}
    			}
    		}
    		else if (調教UI.Focus == キャップ1 || 調教UI.Focus == キャップ2 || 調教UI.Focus == キャップ3)
    		{
    			if (!キャップ中着 && (cd.e is キャップ1 || cd.c == ContactType.Nucleus) && (Cha.ChaD.股施術 || (!Cha.Bod.Is蠍 && (!Cha.Bod.Is蛇 || !Cha.Bod.蛇.ガード))))
    			{
    				調教UI.押し(ref cd);
    				調教UI.Focus.DraShow = false;
    				Bod.Setキャップ1 = キャップ着;
    				調教UI.Set_キャップ中(調教UI.ハンド右);
    				装着時();
    			}
    			else if (!キャップ左着 && (cd.e is キャップ2 || cd.c == ContactType.Milk) && !cd.e.右)
    			{
    				調教UI.押し(ref cd);
    				調教UI.Focus.DraShow = false;
    				Bod.Setキャップ2左 = キャップ着;
    				調教UI.Set_キャップ左(調教UI.ハンド右);
    				装着時();
    			}
    			else if (!キャップ右着 && (cd.e is キャップ2 || cd.c == ContactType.Milk) && cd.e.右)
    			{
    				調教UI.押し(ref cd);
    				調教UI.Focus.DraShow = false;
    				Bod.Setキャップ2右 = キャップ着;
    				調教UI.Set_キャップ右(調教UI.ハンド右);
    				装着時();
    			}
    			else
    			{
    				if (!キャップ中着 && Isキャップ1着())
    				{
    					Bod.Setキャップ1 = キャップ脱;
    					調教UI.Focus.DraShow = true;
    					調教UI.放し();
    				}
    				else if (!キャップ左着 && Isキャップ2左着())
    				{
    					Bod.Setキャップ2左 = キャップ脱;
    					調教UI.Focus.DraShow = true;
    					調教UI.放し();
    				}
    				else if (!キャップ右着 && Isキャップ2右着())
    				{
    					Bod.Setキャップ2右 = キャップ脱;
    					調教UI.Focus.DraShow = true;
    					調教UI.放し();
    				}
    				待機時();
    			}
    		}
    		if (ハンドf)
    		{
    			調教UI.Focus = 調教UI.ハンド右CM;
    			調教UI.Set持ち手();
    			ハンドf = false;
    		}
    	}

    	public void Down(ref MouseButtons mb, ref Vector2D cp, ref Vector2D op, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus.Ele.濃度 == 1.0)
    		{
    			if (ハンドf)
    			{
    				調教UI.Focus = 調教UI.ハンド右CM;
    				ハンドf = false;
    			}
    			if (調教UI.Focus == 調教UI.ハンド右CM)
    			{
    				if (キャップ中着 && (cd.e is キャップ1 || cd.c == ContactType.Nucleus))
    				{
    					調教UI.押し(ref cd);
    					if (mb == MouseButtons.Middle)
    					{
    						調教UI.Set_キャップ中(調教UI.ハンド右);
    						キャップ中 = !キャップ中;
    						切替時(キャップ中);
    						if (キャップ中)
    						{
    							調教UI.Action(ContactType.Nucleus, ActionType.核捏, CurrentState.Start, ToolType.キャプ, 0, 1, 機械: false, 射精: false);
    							Player.奴体力消費小();
    							Player.主精力消費小();
    						}
    						else
    						{
    							調教UI.Action(ContactType.Nucleus, ActionType.核捏, CurrentState.End, ToolType.キャプ, 0, 1, 機械: false, 射精: false);
    							Player.奴体力消費小();
    							Player.主精力消費小();
    						}
    					}
    					else if (!調教UI.ハンド処理.Is乳繰り && mb == MouseButtons.Left)
    					{
    						調教UI.Action(ContactType.Nucleus, ActionType.吸引, CurrentState.End, ToolType.キャプ, 0, 1, 機械: false, 射精: false);
    						Player.奴体力消費小();
    						Player.主精力消費小();
    						吸脱(Bod.キャップ1);
    						切替時(キャップ中);
    						キャップ中 = false;
    						Bod.Setキャップ1 = キャップ脱;
    						キャップ[Bod.キャップ1].Show = true;
    						キャップ[Bod.キャップ1].DraShow = true;
    						キャップ[Bod.キャップ1].StaShow = true;
    						キャップ[Bod.キャップ1].描画Show = true;
    						キャップ[Bod.キャップ1].Ele.濃度 = 0.5;
    						キャップ[Bod.キャップ1].使用状態 = UsageStatus.Standby;
    						キャップ.Remove(Bod.キャップ1);
    						キャップ中着 = false;
    					}
    				}
    				else if (キャップ左着 && (cd.e is キャップ2 || cd.c == ContactType.Milk) && !cd.e.右)
    				{
    					調教UI.押し(ref cd);
    					if (mb == MouseButtons.Middle)
    					{
    						調教UI.Set_キャップ左(調教UI.ハンド左);
    						キャップ左 = !キャップ左;
    						切替時(キャップ左);
    						if (キャップ左)
    						{
    							調教UI.Action(ContactType.Milk, ActionType.Milk, CurrentState.Start, ToolType.キャプ, 0, 1, 機械: false, 射精: false);
    							Player.奴体力消費小();
    							Player.主精力消費小();
    						}
    						else
    						{
    							調教UI.Action(ContactType.Milk, ActionType.Milk, CurrentState.End, ToolType.キャプ, 0, 1, 機械: false, 射精: false);
    							Player.奴体力消費小();
    							Player.主精力消費小();
    						}
    					}
    					else if (!調教UI.ハンド処理.Is乳繰り && mb == MouseButtons.Left)
    					{
    						調教UI.Action(ContactType.Milk, ActionType.吸引, CurrentState.End, ToolType.キャプ, 0, 1, 機械: false, 射精: false);
    						Player.奴体力消費小();
    						Player.主精力消費小();
    						吸脱(Bod.キャップ2左);
    						切替時(キャップ左);
    						キャップ左 = false;
    						Bod.Setキャップ2左 = キャップ脱;
    						キャップ[Bod.キャップ2左].Show = true;
    						キャップ[Bod.キャップ2左].DraShow = true;
    						キャップ[Bod.キャップ2左].StaShow = true;
    						キャップ[Bod.キャップ2左].描画Show = true;
    						キャップ[Bod.キャップ2左].Ele.濃度 = 0.5;
    						キャップ[Bod.キャップ2左].使用状態 = UsageStatus.Standby;
    						キャップ.Remove(Bod.キャップ2左);
    						キャップ左着 = false;
    					}
    				}
    				else
    				{
    					if (!キャップ右着 || (!(cd.e is キャップ2) && cd.c != ContactType.Milk) || !cd.e.右)
    					{
    						return;
    					}
    					調教UI.押し(ref cd);
    					if (mb == MouseButtons.Middle)
    					{
    						調教UI.Set_キャップ右(調教UI.ハンド右);
    						キャップ右 = !キャップ右;
    						切替時(キャップ右);
    						if (キャップ右)
    						{
    							調教UI.Action(ContactType.Milk, ActionType.Milk, CurrentState.Start, ToolType.キャプ, 0, 1, 機械: false, 射精: false);
    							Player.奴体力消費小();
    							Player.主精力消費小();
    						}
    						else
    						{
    							調教UI.Action(ContactType.Milk, ActionType.Milk, CurrentState.End, ToolType.キャプ, 0, 1, 機械: false, 射精: false);
    							Player.奴体力消費小();
    							Player.主精力消費小();
    						}
    					}
    					else if (!調教UI.ハンド処理.Is乳繰り && mb == MouseButtons.Left)
    					{
    						調教UI.Action(ContactType.Milk, ActionType.吸引, CurrentState.End, ToolType.キャプ, 0, 1, 機械: false, 射精: false);
    						Player.奴体力消費小();
    						Player.主精力消費小();
    						吸脱(Bod.キャップ2右);
    						切替時(キャップ右);
    						キャップ右 = false;
    						Bod.Setキャップ2右 = キャップ脱;
    						キャップ[Bod.キャップ2右].Show = true;
    						キャップ[Bod.キャップ2右].DraShow = true;
    						キャップ[Bod.キャップ2右].StaShow = true;
    						キャップ[Bod.キャップ2右].描画Show = true;
    						キャップ[Bod.キャップ2右].Ele.濃度 = 0.5;
    						キャップ[Bod.キャップ2右].使用状態 = UsageStatus.Standby;
    						キャップ.Remove(Bod.キャップ2右);
    						キャップ右着 = false;
    					}
    				}
    			}
    			else
    			{
    				if (調教UI.Focus != キャップ1 && 調教UI.Focus != キャップ2 && 調教UI.Focus != キャップ3)
    				{
    					return;
    				}
    				if (mb == MouseButtons.Left)
    				{
    					if (!キャップ中着 && (cd.c == ContactType.Nucleus || cd.e == Bod.キャップ1) && (Cha.ChaD.股施術 || (!Cha.Bod.Is蠍 && (!Cha.Bod.Is蛇 || !Cha.Bod.蛇.ガード))))
    					{
    						Bod.Setキャップ1 = キャップ着;
    						キャップ.Add(Bod.キャップ1, 調教UI.Focus);
    						キャップ中着 = true;
    						SetFocus(Bod.キャップ1.位置);
    						調教UI.Action(ContactType.Nucleus, ActionType.吸引, CurrentState.Start, ToolType.キャプ, 0, 1, 機械: false, 射精: false);
    						Player.奴体力消費小();
    						Player.主精力消費小();
    						吸着(Bod.キャップ1);
    					}
    					else if (!キャップ左着 && (cd.c == ContactType.Milk || cd.e == Bod.キャップ2左) && !cd.e.右)
    					{
    						Bod.Setキャップ2左 = キャップ着;
    						キャップ.Add(Bod.キャップ2左, 調教UI.Focus);
    						キャップ左着 = true;
    						SetFocus(Bod.キャップ2左.位置);
    						調教UI.Action(ContactType.Milk, ActionType.吸引, CurrentState.Start, ToolType.キャプ, 0, 1, 機械: false, 射精: false);
    						Player.奴体力消費小();
    						Player.主精力消費小();
    						吸着(Bod.キャップ2左);
    					}
    					else if (!キャップ右着 && (cd.c == ContactType.Milk || cd.e == Bod.キャップ2右) && cd.e.右)
    					{
    						Bod.Setキャップ2右 = キャップ着;
    						キャップ.Add(Bod.キャップ2右, 調教UI.Focus);
    						キャップ右着 = true;
    						SetFocus(Bod.キャップ2右.位置);
    						調教UI.Action(ContactType.Milk, ActionType.吸引, CurrentState.Start, ToolType.キャプ, 0, 1, 機械: false, 射精: false);
    						Player.奴体力消費小();
    						Player.主精力消費小();
    						吸着(Bod.キャップ2右);
    					}
    				}
    				else if (mb == MouseButtons.Right && !Is仮着)
    				{
    					調教UI.通常放し();
    				}
    				待機時();
    			}
    		}
    		else if ((調教UI.Focus == キャップ1 || 調教UI.Focus == キャップ2 || 調教UI.Focus == キャップ3) && mb == MouseButtons.Right)
    		{
    			調教UI.通常放し();
    		}
    	}

    	public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
    	{
    		if (調教UI.Focus == 調教UI.ハンド右CM)
    		{
    			調教UI.放し();
    		}
    	}

    	public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
    	{
    	}

    	public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc)
    	{
    	}

    	public キャップ処理(TrainingUI 調教UI)
    		: base(調教UI)
    	{
    		キャップ処理 キャップ処理2 = this;
    		double disUnit = 調教UI.Are.DisplayUnitScale;
    		キャップ着.SetDefault();
    		キャップ1D e = new キャップ1D();
    		e.SetValuesD("表示", true);
    		キャップ1 = new CM(Med, 調教UI, 調教UI.キャップ1 = new キャップ1(disUnit, 配色指定.N0, null, Med, e));
    		キャップ2 = new CM(Med, 調教UI, 調教UI.キャップ2 = new キャップ1(disUnit, 配色指定.N0, null, Med, e));
    		キャップ3 = new CM(Med, 調教UI, 調教UI.キャップ3 = new キャップ1(disUnit, 配色指定.N0, null, Med, e));
    		キャップ色 配色 = default(キャップ色);
    		配色.SetDefault();
    		調教UI.キャップ1.配色(配色);
    		調教UI.キャップ2.配色(配色);
    		調教UI.キャップ3.配色(配色);
    		調教UI.キャップ1.濃度 = 0.5;
    		調教UI.キャップ2.濃度 = 0.5;
    		調教UI.キャップ3.濃度 = 0.5;
    		調教UI.キャップ1CM = キャップ1;
    		調教UI.キャップ2CM = キャップ2;
    		調教UI.キャップ3CM = キャップ3;
    		double d = 0.0005;
    		Vector2D p = Dat.Vec2DZero;
    		キャップ振動 = new Mot(-1.0, 1.0)
    		{
    			BaseSpeed = double.MaxValue,
    			Staing = delegate
    			{
    			},
    			Runing = delegate(Mot m)
    			{
    				if (キャップ処理2.キャップ左_)
    				{
    					p.X = m.Value * d;
    					p.Y = 0.0 - p.X;
    					キャップ処理2.Bod.キャップ2左.位置C = p;
    					調教UI.Action(ContactType.Milk, ActionType.Milk, CurrentState.Continue, ToolType.キャプ, 0, 1, 機械: true, 射精: false);
    					Player.奴体力消費小();
    					キャップ処理2.振動(キャップ処理2.Bod.キャップ2左);
    				}
    				if (キャップ処理2.キャップ右_)
    				{
    					p.X = (0.0 - m.Value) * d;
    					p.Y = p.X;
    					キャップ処理2.Bod.キャップ2右.位置C = p;
    					調教UI.Action(ContactType.Milk, ActionType.Milk, CurrentState.Continue, ToolType.キャプ, 0, 1, 機械: true, 射精: false);
    					Player.奴体力消費小();
    					キャップ処理2.振動(キャップ処理2.Bod.キャップ2右);
    				}
    				if (キャップ処理2.キャップ中_)
    				{
    					p.X = m.Value * d * 1.44;
    					p.Y = 0.0;
    					キャップ処理2.Bod.キャップ1.位置C = p;
    					調教UI.Action(ContactType.Nucleus, ActionType.核捏, CurrentState.Continue, ToolType.キャプ, 0, 1, 機械: true, 射精: false);
    					Player.奴体力消費小();
    					キャップ処理2.振動(キャップ処理2.Bod.キャップ1);
    				}
    			},
    			Reaing = delegate
    			{
    			},
    			Rouing = delegate
    			{
    			},
    			Ending = delegate(Mot m)
    			{
    				m.ResetValue();
    				キャップ処理2.Bod.キャップ2左.位置C = Dat.Vec2DZero;
    				キャップ処理2.Bod.キャップ2右.位置C = Dat.Vec2DZero;
    				キャップ処理2.Bod.キャップ1.位置C = Dat.Vec2DZero;
    			}
    		};
    		調教UI.Mots.Add(キャップ振動.GetHashCode().ToString(), キャップ振動);
    	}

    	public void SetCha(Cha Cha)
    	{
    		base.Cha = Cha;
    		Bod = Cha.Bod;
    	}

    	public new void Reset()
    	{
    		if (キャップ中着)
    		{
    			キャップ中 = false;
    			Bod.Setキャップ1 = キャップ脱;
    			if (キャップ.ContainsKey(Bod.キャップ1))
    			{
    				キャップ.Remove(Bod.キャップ1);
    			}
    			キャップ中着 = false;
    		}
    		if (キャップ左着)
    		{
    			キャップ左 = false;
    			Bod.Setキャップ2左 = キャップ脱;
    			if (キャップ.ContainsKey(Bod.キャップ2左))
    			{
    				キャップ.Remove(Bod.キャップ2左);
    			}
    			キャップ左着 = false;
    		}
    		if (キャップ右着)
    		{
    			キャップ右 = false;
    			Bod.Setキャップ2右 = キャップ脱;
    			if (キャップ.ContainsKey(Bod.キャップ2右))
    			{
    				キャップ.Remove(Bod.キャップ2右);
    			}
    			キャップ右着 = false;
    		}
    		キャップ1.Show = true;
    		キャップ1.DraShow = true;
    		キャップ1.StaShow = true;
    		キャップ1.描画Show = true;
    		キャップ1.Ele.濃度 = 0.5;
    		キャップ1.使用状態 = UsageStatus.Standby;
    		キャップ2.Show = true;
    		キャップ2.DraShow = true;
    		キャップ2.StaShow = true;
    		キャップ2.描画Show = true;
    		キャップ2.Ele.濃度 = 0.5;
    		キャップ2.使用状態 = UsageStatus.Standby;
    		キャップ3.Show = true;
    		キャップ3.DraShow = true;
    		キャップ3.StaShow = true;
    		キャップ3.描画Show = true;
    		キャップ3.Ele.濃度 = 0.5;
    		キャップ3.使用状態 = UsageStatus.Standby;
    		base.Reset();
    		CP中.Reset();
    		CP左.Reset();
    		CP右.Reset();
    		キャップ.Clear();
    		キャップ着 = default(キャップ情報);
    		キャップ脱 = default(キャップ情報);
    		キャップ中着 = false;
    		キャップ左着 = false;
    		キャップ右着 = false;
    		ハンドf = false;
    		キャップ振動?.End();
    		キャップ中_ = false;
    		キャップ左_ = false;
    		キャップ右_ = false;
    		キャップ中 = false;
    		キャップ左 = false;
    		キャップ右 = false;
    		キャップ着.SetDefault();
    		調教UI.キャップ1.濃度 = 0.5;
    		調教UI.キャップ2.濃度 = 0.5;
    		調教UI.キャップ3.濃度 = 0.5;
    	}
    }
}
