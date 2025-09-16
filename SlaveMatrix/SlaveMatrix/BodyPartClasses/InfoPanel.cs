using System;
using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class InfoPanel
    {
    	public Are Are;

    	private Med Med;

    	public Par MaiB;

    	public Tex Mai;

    	public Par Mai2B;

    	public Tex Mai2;

    	public Par SubB;

    	public Tex Sub;

    	public Par Sub2B;

    	public Tex Sub2;

    	private Lab SubInnfo_l;

    	public bool MaiShow = true;

    	public bool Mai2Show = true;

    	public bool SubShow = true;

    	public bool Sub2Show = true;

    	private ParT yp;

    	private ParT np;

    	public But1 yb;

    	public But1 nb;

    	public string TextIm
    	{
    		get
    		{
    			return Mai.TextIm;
    		}
    		set
    		{
    			Mai.TextIm = value;
    		}
    	}

    	public string Text
    	{
    		get
    		{
    			return Mai.Text;
    		}
    		set
    		{
    			Mai.Text = value;
    		}
    	}

    	public string Mai2Im
    	{
    		get
    		{
    			return Mai2.TextIm;
    		}
    		set
    		{
    			Mai2.TextIm = value;
    		}
    	}

    	public string SubInfoIm
    	{
    		get
    		{
    			return Sub.TextIm;
    		}
    		set
    		{
    			Sub.TextIm = value;
    		}
    	}

    	public string SubInfo
    	{
    		get
    		{
    			return Sub.Text;
    		}
    		set
    		{
    			Sub.Text = value;
    		}
    	}

    	public bool 選択肢表示
    	{
    		get
    		{
    			return yp.Dra;
    		}
    		set
    		{
    			SetButPos();
    			yp.Dra = value;
    			np.Dra = value;
    		}
    	}

    	public Action<But> 選択yAct
    	{
    		set
    		{
    			yb.Action = delegate(But a)
    			{
    				value(a);
    			};
    		}
    	}

    	public Action<But> 選択nAct
    	{
    		set
    		{
    			nb.Action = delegate(But a)
    			{
    				value(a);
    			};
    		}
    	}

    	public InfoPanel(Med Med, Are Are)
    	{
    		this.Med = Med;
    		this.Are = Are;
    		double num = 0.015;
    		double num2 = 0.1;
    		double num3 = Are.LocalWidth * 0.6 / num2;
    		double num4 = Are.LocalHeight * (1.0 / 6.0) / num2;
    		Vector2D vector2D = Are.GetPosition(0.2, 1.0 - num4 * num2 / Are.LocalHeight).AddY(0.0 - num);
    		double y = 1.01;
    		MaiB = new Par();
    		MaiB.BasePointBase = Dat.Vec2DZero;
    		MaiB.PositionBase = vector2D;
    		MaiB.SizeBase = num2;
    		MaiB.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		MaiB.OP.ScalingX(MaiB.BasePointBase, num3);
    		MaiB.OP.ScalingY(MaiB.BasePointBase, num4);
    		MaiB.Closed = true;
    		MaiB.BrushColor = Color.FromArgb(160, Col.Black);
    		MaiB.Hit = false;
    		MaiB.JP.Add(new Joi(MaiB.OP.GetCenter()));
    		Mai = new Tex("Tex1", vector2D, num2, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), 0.08, 0, " ", Col.White, Col.Black, Color.Transparent, 19.0, Col.White, delegate(Tex sp)
    		{
    			sp.Text = sp.Text;
    		});
    		Mai.ParT.BasePointBase = Mai.ParT.OP.GetCenter().MulY(y);
    		Mai.Position = MaiB.ToGlobal(MaiB.JP[0].Joint);
    		Mai.Feed.OP.OutlineFalse();
    		double num5 = num4 * 4.53;
    		Mai2B = new Par();
    		Mai2B.BasePointBase = Dat.Vec2DZero;
    		Mai2B.PositionBase = new Vector2D(vector2D.X, 0.01);
    		Mai2B.SizeBase = num2;
    		Mai2B.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		Mai2B.OP.ScalingX(Mai2B.BasePointBase, num3);
    		Mai2B.OP.ScalingY(Mai2B.BasePointBase, num5);
    		Mai2B.Closed = true;
    		Mai2B.BrushColor = Color.FromArgb(160, Col.Black);
    		Mai2B.Hit = false;
    		Mai2B.JP.Add(new Joi(Mai2B.OP.GetCenter()));
    		Mai2 = new Tex("Tex3", vector2D, num2, num3 * 0.98, num5 * 0.97, new Font("MS Gothic", 1f), 0.08, 0, " ", Col.White, Col.Black, Color.Transparent, 19.0, Col.White, delegate(Tex sp)
    		{
    			sp.Text = sp.Text;
    		});
    		Mai2.ParT.BasePointBase = Mai2.ParT.OP.GetCenter().MulY(y);
    		Mai2.Position = Mai2B.ToGlobal(Mai2B.JP[0].Joint);
    		Mai2.Feed.OP.OutlineFalse();
    		num3 = Are.LocalWidth * 0.19 / num2;
    		vector2D = Are.GetPosition(1.0 - (num3 * num2 / Are.LocalWidth + 0.005), 1.0 - num4 * num2 / Are.LocalHeight).AddY(0.0 - num);
    		SubB = new Par();
    		SubB.BasePointBase = Dat.Vec2DZero;
    		SubB.PositionBase = vector2D;
    		SubB.SizeBase = num2;
    		SubB.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		SubB.OP.ScalingX(SubB.BasePointBase, num3);
    		SubB.OP.ScalingY(SubB.BasePointBase, num4);
    		SubB.Closed = true;
    		SubB.BrushColor = Color.FromArgb(160, Col.Black);
    		SubB.Hit = false;
    		SubB.JP.Add(new Joi(SubB.OP.GetCenter()));
    		Sub = new Tex("Tex4", vector2D, num2 * 1.01, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), 0.07, 0, " ", Col.White, Col.Black, Color.Transparent, 15.0);
    		Sub.ParT.BasePointBase = Sub.ParT.OP.GetCenter().MulY(y);
    		Sub.Position = SubB.ToGlobal(SubB.JP[0].Joint);
    		SubInnfo_l = new Lab(Are, "SubInfo", vector2D, num2, 1.0, new Font("MS Gothic", 1f), 0.07, "Sub Info.", Col.White, Col.Black, Color.FromArgb(160, Col.Black), Col.Empty);
    		SubInnfo_l.ParT.PositionBase = SubInnfo_l.ParT.PositionBase.AddY((0.0 - SubInnfo_l.ParT.OP[0].ps[3].Y) * SubInnfo_l.ParT.SizeBase);
    		Sub2B = new Par();
    		Sub2B.BasePointBase = Dat.Vec2DZero;
    		Sub2B.PositionBase = new Vector2D(0.0025, vector2D.Y);
    		Sub2B.SizeBase = num2;
    		Sub2B.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		Sub2B.OP.ScalingX(Sub2B.BasePointBase, num3);
    		Sub2B.OP.ScalingY(Sub2B.BasePointBase, num4);
    		Sub2B.Closed = true;
    		Sub2B.BrushColor = Color.FromArgb(160, Col.Black);
    		Sub2B.Hit = false;
    		Sub2B.JP.Add(new Joi(SubB.OP.GetCenter()));
    		Sub2 = new Tex("Tex3", Sub2B.PositionBase, num2 * 1.01, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), 0.07, 0, "", Col.White, Col.Black, Color.Transparent, 15.0);
    		Sub2.ParT.BasePointBase = Sub2.ParT.OP.GetCenter().MulY(y);
    		Sub2.Position = Sub2B.ToGlobal(Sub2B.JP[0].Joint);
    		yp = new ParT();
    		yp.Text = "・" + GameText.はい;
    		yp.SizeBase = Mai.ParT.SizeBase;
    		yp.Font = new Font("MS Gothic", 1f);
    		yp.FontSize = Mai.ParT.FontSize;
    		yp.SetStringRectOutline(Are.Unit, Are.GD);
    		yp.RectSize = new Vector2D(yp.OP[0].ps[1].X, yp.OP[0].ps[2].Y);
    		yp.OP.ScalingY(yp.BasePointBase, 0.9);
    		yp.OP.OutlineFalse();
    		yp.Closed = true;
    		yp.TextColor = Col.White;
    		yp.BrushColor = Color.FromArgb(0, Col.Black);
    		yp.ShadBrush = new SolidBrush(Col.Black);
    		yp.StringFormat.Alignment = StringAlignment.Center;
    		yp.StringFormat.LineAlignment = StringAlignment.Center;
    		yp.PositionBase = new Vector2D(MaiB.Position.X + 0.001, MaiB.Position.Y);
    		yp.Dra = false;
    		yb = new But1(yp, delegate
    		{
    		});
    		np = new ParT();
    		np.Text = "・" + GameText.いいえ;
    		np.SizeBase = Mai.ParT.SizeBase;
    		np.Font = new Font("MS Gothic", 1f);
    		np.FontSize = Mai.ParT.FontSize;
    		np.SetStringRectOutline(Are.Unit, Are.GD);
    		np.RectSize = new Vector2D(np.OP[0].ps[1].X, np.OP[0].ps[2].Y);
    		np.OP.ScalingY(np.BasePointBase, 0.9);
    		np.OP.OutlineFalse();
    		np.Closed = true;
    		np.TextColor = Col.White;
    		np.BrushColor = Color.FromArgb(0, Col.Black);
    		np.ShadBrush = new SolidBrush(Col.Black);
    		np.StringFormat.Alignment = StringAlignment.Center;
    		np.StringFormat.LineAlignment = StringAlignment.Center;
    		np.PositionBase = new Vector2D(MaiB.Position.X + 0.001, MaiB.Position.Y);
    		np.Dra = false;
    		nb = new But1(np, delegate
    		{
    		});
    	}

    	public void SetHitColor(Med Med)
    	{
    		Mai.SetHitColor(Med);
    		Sub.SetHitColor(Med);
    		SubInnfo_l.SetHitColor(Med);
    		Mai2.SetHitColor(Med);
    		Sub2.SetHitColor(Med);
    		yb.SetHitColor(Med);
    		nb.SetHitColor(Med);
    	}

    	public void UpdateSub2()
    	{
    		Sub2.TextIm = GameText.所持金 + "\r\n" + Sta.GameData.所持金.ToString("#,0") + "\r\n" + GameText.借金 + "\r\n" + Sta.GameData.借金.ToString("#,0") + "\r\n" + Sta.GameData.日数 + GameText.日目 + "/" + Sta.GameData.時間帯;
    	}

    	private void SetButPos()
    	{
    		yp.PositionBase = new Vector2D(yp.PositionBase.X, Mai.ParT.ToGlobal(Mai.ParT.GetStringRect(Are.Unit, Are.GD).v2).Y + 0.0025);
    		np.PositionBase = new Vector2D(np.PositionBase.X, yp.ToGlobal(yp.OP.Last().ps.Last()).Y + 0.0025);
    	}

    	public void Move(ref Color HitColor)
    	{
    		yb.Move(ref HitColor);
    		nb.Move(ref HitColor);
    	}

    	public void Down(ref Color HitColor)
    	{
    		Sub.Down(ref HitColor);
    		yb.Down(ref HitColor);
    		nb.Down(ref HitColor);
    	}

    	public void DownB(ref Color HitColor)
    	{
    		yb.Down(ref HitColor);
    		nb.Down(ref HitColor);
    	}

    	public void Up(ref Color HitColor)
    	{
    		Sub.Up(ref HitColor);
    		yb.Up(ref HitColor);
    		nb.Up(ref HitColor);
    	}

    	public void Draw(Are Are, FPS FPS)
    	{
    		if (MaiShow)
    		{
    			Are.Draw(MaiB);
    			Mai.Progression(FPS);
    			Are.Draw(Mai.Pars);
    		}
    		if (Mai2Show)
    		{
    			Are.Draw(Mai2B);
    			Are.Draw(Mai2.Pars);
    		}
    		if (SubShow)
    		{
    			Are.Draw(SubB);
    			Sub.Progression(FPS);
    			Are.Draw(Sub.Pars);
    			Are.Draw(SubInnfo_l.ParT);
    		}
    		if (Sub2Show)
    		{
    			Are.Draw(Sub2B);
    			Are.Draw(Sub2.Pars);
    		}
    		if (yp.Dra)
    		{
    			Are.Draw(yp);
    		}
    		if (np.Dra)
    		{
    			Are.Draw(np);
    		}
    	}

    	public void Dispose()
    	{
    		MaiB.Dispose();
    		Mai.Dispose();
    		Mai2B.Dispose();
    		Mai2.Dispose();
    		SubB.Dispose();
    		Sub.Dispose();
    		SubInnfo_l.Dispose();
    		Sub2B.Dispose();
    		Sub2.Dispose();
    	}
    }
}
