using System.Collections.Generic;
using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class ハンド処理 : 処理B
    {
    	public bool Is乳繰り;

    	public bool Is乳摘み;

    	public bool Is乳捏ね;

    	public bool Is核捏ね;

    	public bool Isくぱぁ;

    	public bool Is体撫で;

    	public Motion バスト初期化;

    	public Motion くぱぁ中;

    	private bool 核捏ね初;

    	private double くぱぁ;

    	private ContactType 箇所;

    	private Vector2D vs;

    	private List<Vector2D> vl = new List<Vector2D>();

    	private double u = 72.0;

    	private double x;

    	private Vector2D v;

    	private Vector2D o;

    	private int yi;

    	public bool 切り替え;

    	public bool Isモード
    	{
    		get
    		{
    			if (!Is乳繰り && !Is乳摘み && !Is乳捏ね && !Is核捏ね && !Isくぱぁ && !Is体撫で)
    			{
    				return 調教UI.ハンド挿入.Is挿入;
    			}
    			return true;
    		}
    	}

    	public void くぱ()
    	{
    		調教UI.擬音キュー.Enqueue(delegate(RenderArea a)
    		{
    			調教UI.擬音.Sound(a, Bod.膣口位置.GetAreaPoint(0.01), Sta.くぱ.GetVal(Player.変化V_膣, Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.DeepPink.S(Player.変化V_膣.Clamp(0.5, 1.0)), 0.2 + 0.2 * RNG.XS.NextDouble() * Player.変化V_膣, b: true);
    		});
    	}

    	private void 乳繰りモード(ref ContactD cd)
    	{
    		Is乳繰り = true;
    		箇所 = cd.c;
    		調教UI.ハンド右CM.Show = true;
    		調教UI.Set_乳首(調教UI.ハンド右, 右: true);
    		調教UI.Set_乳首(調教UI.ハンド左, 右: false);
    		乳繰りsi();
    	}

    	private void 乳繰り解除()
    	{
    		Is乳繰り = false;
    		調教UI.ハンド右.Yi = 0;
    		調教UI.ハンド左.Yi = 0;
    	}

    	private void 乳繰りsi()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = GameText.乳首 + "\r\nLDo:" + GameText.摘む + "\r\nWh:" + GameText.繰る;
    		}
    	}

    	private void 乳摘みモード(ref ContactD cd)
    	{
    		調教UI.ハンド右.Xi = 5;
    		調教UI.ハンド右.Yi = 0;
    		調教UI.ハンド左.Xi = 5;
    		調教UI.ハンド左.Yi = 0;
    		Is乳摘み = true;
    		箇所 = cd.c;
    		調教UI.ハンド右CM.Show = true;
    		調教UI.Set_乳首(調教UI.ハンド右, 右: true);
    		調教UI.Set_乳首(調教UI.ハンド左, 右: false);
    		Vector2D 位置 = 調教UI.ハンド右.位置;
    		Addvl(ref 位置);
    		乳摘みsi();
    	}

    	private void 乳摘み解除()
    	{
    		Is乳摘み = false;
    		vl.Clear();
    		調教UI.ハンド右.Yi = 0;
    		調教UI.ハンド左.Yi = 0;
    		Bod.乳房右.尺度XC = 1.0;
    		Bod.乳房左.尺度XC = 1.0;
    		調教UI.ハンド右.角度C = 0.0;
    		調教UI.ハンド左.角度C = 0.0;
    		if (Med.Mode == "Training")
    		{
                //~~TODO~~ fix?
                //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(対象.Ele.位置B));
                Med.CursorPosition = Med.FromBasePosition(対象.Ele.位置B);

            }
    		バスト初期化.Start();
    		if (調教UI.ハンド右.Xi == 5)
    		{
    			乳繰りsi();
    		}
    	}

    	private void 乳摘みsi()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = GameText.乳首 + "\r\nMo:" + GameText.動かす + "\r\nLUp:" + GameText.放す;
    		}
    	}

    	private void 乳捏ねモード(ref ContactD cd)
    	{
    		調教UI.ハンド右.Xi = 2;
    		調教UI.ハンド右.Yi = 0;
    		調教UI.ハンド左.Xi = 2;
    		調教UI.ハンド左.Yi = 0;
    		Is乳捏ね = true;
    		箇所 = cd.c;
    		調教UI.ハンド右CM.Show = true;
    		調教UI.Set_乳房(調教UI.ハンド右, 右: true);
    		調教UI.Set_乳房(調教UI.ハンド左, 右: false);
    		Vector2D 位置 = 調教UI.ハンド右.位置;
    		Addvl(ref 位置);
    		乳捏ねsi2();
    	}

    	private void 乳捏ね解除()
    	{
    		Is乳捏ね = false;
    		vl.Clear();
    		調教UI.ハンド右.Yi = 0;
    		調教UI.ハンド左.Yi = 0;
    		Bod.乳房右.尺度XC = 1.0;
    		Bod.乳房左.尺度XC = 1.0;
    		Bod.乳房右.尺度C = 1.0;
    		Bod.乳房左.尺度C = 1.0;
    		調教UI.ハンド右.角度C = 0.0;
    		調教UI.ハンド左.角度C = 0.0;
    		if (Med.Mode == "Training")
    		{
                //~~TODO~~ fix?
                //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(対象.Ele.位置B));
                Med.CursorPosition = Med.FromBasePosition(対象.Ele.位置B);

            }
    		バスト初期化.Start();
    		if (調教UI.ハンド右.Xi == 2)
    		{
    			乳捏ねsi1();
    		}
    	}

    	private void 乳捏ねsi1()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = GameText.乳房 + "\r\nLDo:" + GameText.掴む;
    		}
    	}

    	private void 乳捏ねsi2()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = GameText.乳房 + "\r\nMo:" + GameText.捏ねる + "\r\nLUp:" + GameText.放す;
    		}
    	}

    	private void 核捏ねモード(ref ContactD cd)
    	{
    		調教UI.ハンド右.Xi = 6;
    		調教UI.ハンド右.Yi = 0;
    		Is核捏ね = true;
    		箇所 = cd.c;
    		Vector2D 陰核位置 = Bod.陰核位置;
    		Vector2D 位置B = 陰核位置 + Dat.Vec2DUnitY * 0.0015;
    		調教UI.ハンド右.位置B = 位置B;
    		Addvl(ref 陰核位置);
    		核捏ね初 = true;
            //~~TODO~~ fix?
            //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(対象.Ele.位置B));
            Med.CursorPosition = Med.FromBasePosition(対象.Ele.位置B);


            核捏ねsi2();
    	}

    	private void 核捏ね解除()
    	{
    		Is核捏ね = false;
    		vl.Clear();
    		調教UI.ハンド右.Yi = 0;
    		調教UI.ハンド右.角度C = 0.0;
    		Bod.ピアス.位置C = Dat.Vec2DZero;
    		if (Med.Mode == "Training")
    		{
                //~~TODO~~ fix?
                //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(対象.Ele.位置B));
                Med.CursorPosition = Med.FromBasePosition(対象.Ele.位置B);

            }
    	}

    	private void 核捏ねsi1()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = GameText.陰核 + "\r\nLDo:" + GameText.触れる;
    		}
    	}

    	private void 核捏ねsi2()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = GameText.陰核 + "\r\nMo:" + GameText.捏ねる + "\r\nLUp:" + GameText.離す;
    		}
    	}

    	private void くぱぁモード(ref ContactD cd)
    	{
    		調教UI.ハンド右.Xi = 1;
    		調教UI.ハンド右.Yi = 0;
    		調教UI.ハンド左.Xi = 1;
    		調教UI.ハンド左.Yi = 0;
    		Isくぱぁ = true;
    		箇所 = cd.c;
    		調教UI.ハンド右CM.Show = true;
    		調教UI.Set_くぱぁ(調教UI.ハンド右, 右: true);
    		調教UI.Set_くぱぁ(調教UI.ハンド左, 右: false);
    		くぱぁ = Bod.性器.くぱぁ;
    		Bod.性器.くぱぁ = 1.0;
    		くぱぁsi2();
    	}

    	private void くぱぁ解除(ref ContactD cd)
    	{
    		Bod.性器.くぱぁ = くぱぁ;
    		Isくぱぁ = false;
    		if (Med.Mode == "Training")
    		{
                //~~TODO~~ fix?
                //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(対象.Ele.位置B));
                Med.CursorPosition = Med.FromBasePosition(対象.Ele.位置B);

            }
    		if (cd.c == ContactType.Crotch)
    		{
    			くぱぁsi1();
    		}
    	}

    	private void くぱぁsi1()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = GameText.陰唇 + "\r\nLDo:" + GameText.広げる;
    		}
    	}

    	private void くぱぁsi2()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = GameText.陰唇 + "\r\nLUp:" + GameText.やめる;
    		}
    	}

    	private void 体撫でモード(ref ContactD cd)
    	{
    		Is体撫で = true;
    		箇所 = cd.c;
    		体撫でsi2();
    	}

    	private void 体撫で解除()
    	{
    		Is体撫で = false;
    		調教UI.ハンド右.角度C = 0.0;
    		if (調教UI.ハンド右.Xi == 3)
    		{
    			体撫でsi1();
    		}
    	}

    	private void 体撫でsi1()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = "LDo:" + GameText.触れる;
    		}
    	}

    	private void 体撫でsi2()
    	{
    		if (Sta.GameData.ガイド)
    		{
    			ip.SubInfoIm = "Mo:" + GameText.撫でる + "\r\nLUp:" + GameText.離す;
    		}
    	}

    	private string si()
    	{
    		if (!Isモード)
    		{
    			return (調教UI.マウス挿入.挿抜モーション.Run ? "" : ("MCl:" + GameText.マウス切替 + "\r\n")) + (調教UI.ペニス挿入.挿抜モーション.Run ? "" : ("RCl:" + GameText.ペニス切替));
    		}
    		return "";
    	}

    	private void 乳捏ね(ref Vector2D cp)
    	{
    		double num = (調教UI.ハンド右.位置B - GetCenter()).Angle02π(Dat.Vec2DUnitY).ToDegree();
    		if (!double.IsNaN(num))
    		{
    			Bod.乳房右.Yi = (int)((360.0 - num) / u);
    			Bod.乳房左.Yi = Bod.乳房右.Yi;
    			if (Bod.乳房右.Yi == 1 || Bod.乳房右.Yi == 2)
    			{
    				Bod.乳房右.尺度XC = 0.95 + 0.05 * Bod.乳房右.バスト.Inverse();
    				Bod.乳房左.尺度XC = Bod.乳房右.尺度XC;
    			}
    			else
    			{
    				Bod.乳房右.尺度XC = 1.0;
    				Bod.乳房左.尺度XC = 1.0;
    			}
    		}
    	}

    	private void 核捏ね(ref Vector2D cp)
    	{
    		double num = (o.X - v.X) * 0.008;
    		Vector2D 陰核位置 = Bod.陰核位置;
    		Vector2D coord = 陰核位置 + Dat.Vec2DUnitY * 0.0015;
    		double num2 = Dat.Vec2DUnitY.Angle02π(調教UI.ハンド右.位置B - GetCenter());
    		if (!double.IsNaN(num2))
    		{
    			調教UI.ハンド右.位置B = coord.TransformCoordinateBP(陰核位置, num2.RotationZ());
    			Bod.ピアス.位置C = (調教UI.ハンド右.位置B - Bod.ピアス.位置B) * 0.3;
    		}
    		対象.Ele.角度C = (100.0 * num).Clamp(-5.0, 5.0);
    	}

    	private bool Is撫で()
    	{
    		if (箇所 != ContactType.Head && 箇所 != ContactType.Face && 箇所 != ContactType.Ear && 箇所 != ContactType.Hair && 箇所 != ContactType.Neck && 箇所 != ContactType.Shoulder && 箇所 != ContactType.Side && 箇所 != ContactType.Stomache && 箇所 != ContactType.Thigh && 箇所 != ContactType.Feet && 箇所 != ContactType.Hand && 箇所 != ContactType.Awareness && 箇所 != ContactType.Touch && 箇所 != ContactType.Tail && 箇所 != ContactType.Wing && 箇所 != ContactType.Fin)
    		{
    			return 箇所 == ContactType.Other;
    		}
    		return true;
    	}

    	private bool Is撫で(ref ContactD cd)
    	{
    		if (cd.c != ContactType.Head && cd.c != ContactType.Face && cd.c != ContactType.Ear && cd.c != ContactType.Hair && cd.c != ContactType.Neck && cd.c != ContactType.Shoulder && cd.c != ContactType.Side && cd.c != ContactType.Stomache && cd.c != ContactType.Thigh && cd.c != ContactType.Feet && cd.c != ContactType.Hand && cd.c != ContactType.Awareness && cd.c != ContactType.Touch && cd.c != ContactType.Tail && cd.c != ContactType.Wing && cd.c != ContactType.Fin)
    		{
    			return cd.c == ContactType.Other;
    		}
    		return true;
    	}

    	private void Addvl(ref Vector2D v)
    	{
    		vl.Add(v);
    		if (vl.Count > 16)
    		{
    			vl.RemoveAt(0);
    		}
    	}

    	private Vector2D GetCenter()
    	{
    		vs = Dat.Vec2DZero;
    		foreach (Vector2D item in vl)
    		{
    			vs += item;
    		}
    		return vs / vl.Count;
    	}

    	public void Move(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus != 対象 || バスト初期化.Run)
    		{
    			return;
    		}

    		v = cp;
    		x = (o.X - v.X) * 0.008;
    		if (Isモード)
    		{
    			if (Is乳摘み)
    			{
    				yi = Bod.乳房左.Yi;
    				乳捏ね(ref cp);
    				調教UI.Set_乳首(調教UI.ハンド右, 右: true);
    				調教UI.Set_乳首(調教UI.ハンド左, 右: false);
    				Addvl(ref cp);
    				調教UI.ハンド右.角度C = (100.0 * x).Clamp(-15.0, 5.0);
    				調教UI.ハンド左.角度C = (-100.0 * x).Clamp(-5.0, 15.0);
    				if (yi != Bod.乳房左.Yi && Bod.乳房左.Yi == 1)
    				{
    					Bod.胸左右前後 = !Bod.胸左右前後;
    				}
    				調教UI.Action(ContactType.Milk, ActionType.Grope, CurrentState.Continue, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			}
    			else if (Is乳繰り)
    			{
    				調教UI.Set_乳首(調教UI.ハンド右, 右: true);
    				調教UI.Set_乳首(調教UI.ハンド左, 右: false);
    				if (cd.c != ContactType.Milk && cd.c != ContactType.Chest)
    				{
    					乳繰り解除();
    					調教UI.放し();
    					調教UI.Action(ContactType.Milk, ActionType.Milk, CurrentState.End, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    					Player.奴体力消費小();
    					Player.主精力消費小();
    				}
    			}
    			else if (Is乳捏ね)
    			{
    				yi = Bod.乳房左.Yi;
    				乳捏ね(ref cp);
    				調教UI.Set_乳房(調教UI.ハンド右, 右: true);
    				調教UI.Set_乳房(調教UI.ハンド左, 右: false);
    				Addvl(ref cp);
    				調教UI.ハンド右.角度C = (100.0 * x).Clamp(-15.0, 5.0);
    				調教UI.ハンド左.角度C = (-100.0 * x).Clamp(-5.0, 15.0);
    				if (yi != Bod.乳房左.Yi && Bod.乳房左.Yi == 1)
    				{
    					Bod.胸左右前後 = !Bod.胸左右前後;
    				}
    				調教UI.Action(ContactType.Chest, ActionType.乳捏, CurrentState.Continue, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			}
    			else if (Is核捏ね)
    			{
    				if (核捏ね初)
    				{
    					核捏ね初 = false;
    				}
    				else
    				{
    					核捏ね(ref cp);
    					Addvl(ref cp);
    					調教UI.Action(ContactType.Nucleus, ActionType.核捏, CurrentState.Continue, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    					Player.奴体力消費小();
    					Player.主精力消費小();
    				}
    			}
    			else if (Isくぱぁ)
    			{
    				調教UI.Set_くぱぁ(調教UI.ハンド右, 右: true);
    				調教UI.Set_くぱぁ(調教UI.ハンド左, 右: false);
    			}
    			else if (Is体撫で)
    			{
    				調教UI.ハンド右CM.Show = true;
    				調教UI.ハンド左表示 = false;
    				調教UI.ハンド右.Xi = 3;
    				調教UI.ハンド右.Yi = 0;
    				if (調教UI.IsHitCha(ref cd))
    				{
    					調教UI.押し(ref cd);
    					対象.Ele.角度C = (100.0 * x).Clamp(-45.0, 45.0);
    					調教UI.Action(cd.c, ActionType.Contact, CurrentState.Continue, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    					Player.奴体力消費小();
    					Player.主精力消費小();
    				}
    				else if (調教UI.押し状態)
    				{
    					調教UI.Action(cd.c, ActionType.Contact, CurrentState.Continue, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    					Player.奴体力消費小();
    					Player.主精力消費小();
    					対象.Ele.角度C = 0.0;
    					調教UI.放し();
    				}
    				体撫でsi2();
    			}
    			else
    			{
    				調教UI.ハンド挿入.Move(ref mb, ref cp, ref hc, ref cd);
    			}
    		}
    		else if (cd.c == ContactType.Milk)
    		{
    			調教UI.ハンド右CM.Show = cd.e.右;
    			調教UI.ハンド左表示 = !cd.e.右;
    			if (調教UI.ハンド左表示)
    			{
    				調教UI.ハンド左.位置B = cp;
    			}
    			調教UI.ハンド右.Xi = 5;
    			調教UI.ハンド右.Yi = 0;
    			調教UI.ハンド左.Xi = 5;
    			調教UI.ハンド左.Yi = 0;
    			調教UI.Set_乳首(調教UI.ハンド右, 右: true);
    			調教UI.Set_乳首(調教UI.ハンド左, 右: false);
    			乳繰りsi();
    		}
    		else if (cd.c == ContactType.Chest)
    		{
    			調教UI.ハンド右CM.Show = cd.e.右;
    			調教UI.ハンド左表示 = !cd.e.右;
    			if (調教UI.ハンド左表示)
    			{
    				調教UI.ハンド左.位置B = cp;
    			}
    			調教UI.ハンド右.Xi = 2;
    			調教UI.ハンド右.Yi = 0;
    			調教UI.ハンド左.Xi = 2;
    			調教UI.ハンド左.Yi = 0;
    			乳捏ねsi1();
    		}
    		else if (cd.c == ContactType.Nucleus)
    		{
    			調教UI.ハンド右CM.Show = true;
    			調教UI.ハンド左表示 = false;
    			調教UI.ハンド右.Xi = 6;
    			調教UI.ハンド右.Yi = 0;
    			調教UI.Set_陰核(調教UI.ハンド右);
    			核捏ねsi1();
    		}
    		else if ((Player.フェラ1 && cd.c == ContactType.Mouth && !調教UI.Is口挿入) || (cd.c == ContactType.Vagina && !調教UI.Is膣挿入) || (cd.c == ContactType.Anal && !調教UI.Is肛挿入) || (cd.c == ContactType.Thread && !調教UI.Is糸挿入))
    		{
    			調教UI.ハンド右CM.Show = true;
    			調教UI.ハンド左表示 = false;
    			switch (cd.c)
    			{
    			case ContactType.Mouth:
    				if (Player.手口)
    				{
    					調教UI.ハンド右.Xi = 8;
    				}
    				else
    				{
    					調教UI.ハンド右.Xi = 7;
    				}
    				break;
    			case ContactType.Vagina:
    				if (Player.手膣)
    				{
    					調教UI.ハンド右.Xi = 8;
    				}
    				else
    				{
    					調教UI.ハンド右.Xi = 7;
    				}
    				break;
    			case ContactType.Anal:
    				if (Player.手肛)
    				{
    					調教UI.ハンド右.Xi = 8;
    				}
    				else
    				{
    					調教UI.ハンド右.Xi = 7;
    				}
    				break;
    			case ContactType.Thread:
    				if (Player.手糸)
    				{
    					調教UI.ハンド右.Xi = 8;
    				}
    				else
    				{
    					調教UI.ハンド右.Xi = 7;
    				}
    				break;
    			}
    			調教UI.ハンド右.Yi = 0;
    			調教UI.ハンド挿入.Move(ref mb, ref cp, ref hc, ref cd);
    		}
    		else if (cd.c == ContactType.Crotch)
    		{
    			くぱぁsi1();
    		}
    		else if (Is撫で(ref cd))
    		{
    			調教UI.ハンド右CM.Show = true;
    			調教UI.ハンド左表示 = false;
    			調教UI.ハンド右.Xi = 3;
    			調教UI.ハンド右.Yi = 0;
    			体撫でsi1();
    		}
    		else if (調教UI.ハンド右CM.Ele.Xi == 2 || 調教UI.ハンド右CM.Ele.Xi == 3 || 調教UI.ハンド右CM.Ele.Xi == 5 || 調教UI.ハンド右CM.Ele.Xi == 6 || 調教UI.ハンド右CM.Ele.Xi == 7 || 調教UI.ハンド右CM.Ele.Xi == 8 || 調教UI.ハンド右CM.Ele.Xi == 10)
    		{
    			調教UI.ハンド左表示 = false;
    			調教UI.ハンド右CM.Show = true;
    			if (cd.e == null)
    			{
    				調教UI.ハンド右.Xi = 0;
    			}
    			調教UI.ハンド右.Yi = 0;
    			調教UI.ハンド左.Xi = 0;
    			調教UI.ハンド左.Yi = 0;
    			乳繰り解除();
    			if (Sta.GameData.ガイド)
    			{
    				ip.SubInfoIm = si();
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
    		if (mb == MouseButtons.Left)
    		{
    			if (cd.c == ContactType.Milk && ((!cd.e.右 && !調教UI.キャップ処理.キャップ左着) || (cd.e.右 && !調教UI.キャップ処理.キャップ右着)))
    			{
    				調教UI.押し(ref cd);
    				乳摘みモード(ref cd);
    				乳捏ね(ref cp);
    				調教UI.Action(ContactType.Milk, ActionType.Grope, CurrentState.Start, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    				調教UI.乳首演出();
    				調教UI.腕修正();
    				調教UI.脚修正();
    			}
    			else if (cd.c == ContactType.Chest)
    			{
    				調教UI.押し(ref cd);
    				乳捏ねモード(ref cd);
    				乳捏ね(ref cp);
    				調教UI.Action(ContactType.Chest, ActionType.乳捏, CurrentState.Start, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    				調教UI.乳房演出();
    				調教UI.腕修正();
    				調教UI.脚修正();
    			}
    			else if (cd.c == ContactType.Nucleus && !調教UI.キャップ処理.キャップ中着)
    			{
    				調教UI.押し(ref cd);
    				核捏ねモード(ref cd);
    				核捏ね(ref cp);
    				調教UI.Action(ContactType.Nucleus, ActionType.核捏, CurrentState.Start, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    				調教UI.陰核演出();
    				調教UI.腕修正();
    				調教UI.脚修正();
    			}
    			else if (cd.c == ContactType.Crotch && !Isモード)
    			{
    				調教UI.押し(ref cd);
    				くぱぁモード(ref cd);
    				調教UI.Action(ContactType.Crotch, ActionType.くぱ, CurrentState.Start, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    				くぱ();
    				if (RNG.XS.NextBool())
    				{
    					調教UI.陰核演出();
    				}
    				else
    				{
    					調教UI.膣腔演出();
    				}
    				くぱぁ中.Start();
    				調教UI.脚修正();
    			}
    			else if (!調教UI.ハンド挿入.Is挿入 && Is撫で(ref cd))
    			{
    				調教UI.押し(ref cd);
    				体撫でモード(ref cd);
    				調教UI.Action(cd.c, ActionType.Contact, CurrentState.Start, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    				調教UI.肌体演出();
    			}
    			else
    			{
    				箇所 = cd.c;
    				調教UI.ハンド挿入.Down(ref mb, ref cp, ref hc, ref cd);
    			}
    		}
    		else if (mb == MouseButtons.Right)
    		{
    			if (!Isモード && !調教UI.ペニス挿入.Is挿入)
    			{
    				調教UI.ハンド左表示 = false;
    				調教UI.ハンド右CM.Show = true;
    				調教UI.ハンド右.Xi = 0;
    				調教UI.ハンド右.Yi = 0;
    				調教UI.ハンド左.Xi = 0;
    				調教UI.ハンド左.Yi = 0;
    				乳繰り解除();
    				if (切り替え)
    				{
    					切り替え = false;
    					return;
    				}
    				調教UI.Focus.Ele.Intensity = 0.5;
    				調教UI.Focus = 調教UI.ペニスCM;
    				調教UI.ペニスCM.Ele.位置B = cp;
    				調教UI.ペニス処理.選択 = true;
    				調教UI.ペニス処理.Move(ref mb, ref cp, ref hc, ref cd);
    			}
    		}
    		else if (mb == MouseButtons.Middle && !Isモード && !調教UI.マウス挿入.Is挿入 && (!調教UI.ハンド右CM.Show || 調教UI.ハンド右.Xi != 5 || !調教UI.キャップ処理.キャップ右着) && (!調教UI.ハンド左表示 || 調教UI.ハンド左.Xi != 5 || !調教UI.キャップ処理.キャップ左着) && (!調教UI.ハンド右CM.Show || 調教UI.ハンド右.Xi != 5 || !調教UI.キャップ処理.キャップ中着))
    		{
    			調教UI.ハンド左表示 = false;
    			調教UI.ハンド右CM.Show = true;
    			調教UI.ハンド右.Xi = 0;
    			調教UI.ハンド右.Yi = 0;
    			調教UI.ハンド左.Xi = 0;
    			調教UI.ハンド左.Yi = 0;
    			乳繰り解除();
    			if (切り替え)
    			{
    				切り替え = false;
    				return;
    			}
    			調教UI.Focus.Ele.Intensity = 0.5;
    			調教UI.Focus = 調教UI.マウスCM;
    			調教UI.マウスCM.Ele.位置B = cp;
    			調教UI.マウス処理.Move(ref mb, ref cp, ref hc, ref cd);
    		}
    	}

    	public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus != 対象 || mb != MouseButtons.Left || !Isモード)
    		{
    			return;
    		}
    		if (箇所 == ContactType.Milk)
    		{
    			if (Is乳摘み)
    			{
    				調教UI.Action(ContactType.Milk, ActionType.Grope, CurrentState.End, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			}
    			if (Is乳繰り)
    			{
    				調教UI.Action(ContactType.Milk, ActionType.Milk, CurrentState.End, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			}
    			乳摘み解除();
    			乳繰り解除();
    			調教UI.ハンド左表示 = true;
    			調教UI.放し();
    		}
    		else if (箇所 == ContactType.Chest)
    		{
    			調教UI.Action(ContactType.Chest, ActionType.乳捏, CurrentState.End, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    			Player.奴体力消費小();
    			Player.主精力消費小();
    			乳捏ね解除();
    			調教UI.ハンド左表示 = true;
    			調教UI.放し();
    		}
    		else if (箇所 == ContactType.Nucleus)
    		{
    			調教UI.Action(ContactType.Nucleus, ActionType.核捏, CurrentState.End, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    			Player.奴体力消費小();
    			Player.主精力消費小();
    			核捏ね解除();
    			調教UI.放し();
    		}
    		else if (箇所 == ContactType.Crotch)
    		{
    			くぱぁ中.End();
    			調教UI.Action(ContactType.Crotch, ActionType.くぱ, CurrentState.End, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    			Player.奴体力消費小();
    			Player.主精力消費小();
    			くぱぁ解除(ref cd);
    			調教UI.ハンド左表示 = true;
    			調教UI.放し();
    		}
    		else if (Is撫で())
    		{
    			調教UI.Action(cd.c, ActionType.Contact, CurrentState.End, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    			Player.奴体力消費小();
    			Player.主精力消費小();
    			体撫で解除();
    			調教UI.放し();
    			if (Sta.GameData.ガイド)
    			{
    				if (調教UI.IsHitCha(ref cd))
    				{
    					体撫でsi1();
    				}
    				else
    				{
    					ip.SubInfoIm = si();
    				}
    			}
    		}
    		else
    		{
    			調教UI.ハンド挿入.Up(ref mb, ref cp, ref hc, ref cd);
    		}
    	}

    	public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
    	{
    	}

    	public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc, ref ContactD cd)
    	{
    		if (調教UI.Focus == 対象 && (cd.c == ContactType.Milk || cd.c == ContactType.Chest) && !Is乳摘み && (調教UI.ハンド右.Xi == 5 || 調教UI.ハンド左.Xi == 5))
    		{
    			if (!Is乳繰り)
    			{
    				調教UI.Action(ContactType.Milk, ActionType.Milk, CurrentState.Start, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			}
    			else
    			{
    				調教UI.Action(ContactType.Milk, ActionType.Milk, CurrentState.Continue, ToolType.Hand, 0, 1, 機械: false, 射精: false);
    				Player.奴体力消費小();
    				Player.主精力消費小();
    			}
    			調教UI.Set_乳首(調教UI.ハンド右, 右: true);
    			調教UI.Set_乳首(調教UI.ハンド左, 右: false);
    			調教UI.押し(ref cd);
    			乳繰りモード(ref cd);
    			調教UI.ハンド右.Yi = (調教UI.ハンド右.Yi + dt.Sign() * 2).Clamp(0, 調教UI.ハンド右.Body.GetCountY());
    			調教UI.ハンド左.Yi = (調教UI.ハンド左.Yi - dt.Sign() * 2).Clamp(0, 調教UI.ハンド左.Body.GetCountY());
    			乳繰りsi();
    			調教UI.乳首演出();
    		}
    	}

    	public ハンド処理(TrainingUI 調教UI, CM ハンド)
    		: base(調教UI, ハンド)
    	{
    		ハンド処理 ハンド処理2 = this;
    		double d = 1.0;
    		bool f = false;
    		バスト初期化 = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    				f = ハンド処理2.Bod.乳房右.Yi <= 2;
    				d = ハンド処理2.Bod.乳房右.Yv;
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (f)
    				{
    					d -= m.Value;
    					if (d < 0.0)
    					{
    						d = 0.0;
    					}
    					ハンド処理2.Bod.乳房右.Yv = d;
    					ハンド処理2.Bod.乳房左.Yv = d;
    					if (ハンド処理2.Bod.乳房右.Yi == 0)
    					{
    						d = 0.0;
    						m.End();
    					}
    				}
    				else
    				{
    					d += m.Value;
    					if (d > 1.0)
    					{
    						d = 0.0;
    					}
    					ハンド処理2.Bod.乳房右.Yv = d;
    					ハンド処理2.Bod.乳房左.Yv = d;
    					if (ハンド処理2.Bod.乳房右.Yi == 0)
    					{
    						d = 0.0;
    						m.End();
    					}
    				}
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
    				m.ResetValue();
    				ハンド処理2.Bod.乳房右.Yi = 0;
    				ハンド処理2.Bod.乳房左.Yi = 0;
    			}
    		};
    		調教UI.Mots.Add(バスト初期化.GetHashCode().ToString(), バスト初期化);
    		くぱぁ中 = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    			},
    			OnUpdate = delegate
    			{
    				調教UI.Action(ContactType.Crotch, ActionType.くぱ, CurrentState.Continue, ToolType.Hand, 0, 1, 機械: false, 射精: false);
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
    				m.ResetValue();
    			}
    		};
    		調教UI.Mots.Add(くぱぁ中.GetHashCode().ToString(), くぱぁ中);
    	}

    	public void SetCha(Character Cha)
    	{
    		base.Cha = Cha;
    		Bod = Cha.Body;
    	}

    	public new void Reset()
    	{
    		base.Reset();
    		Is乳繰り = false;
    		Is乳摘み = false;
    		Is乳捏ね = false;
    		Is核捏ね = false;
    		Isくぱぁ = false;
    		Is体撫で = false;
    		バスト初期化?.End();
    		くぱぁ中?.End();
    		乳繰り解除();
    		乳摘み解除();
    		乳捏ね解除();
    		核捏ね初 = false;
    		核捏ね解除();
    		ContactD cd = default(ContactD);
    		くぱぁ解除(ref cd);
    		体撫で解除();
    		箇所 = ContactType.none;
    		vs = default(Vector2D);
    		vl.Clear();
    		x = 0.0;
    		v = default(Vector2D);
    		o = default(Vector2D);
    		yi = 0;
    		切り替え = false;
    	}
    }
}
