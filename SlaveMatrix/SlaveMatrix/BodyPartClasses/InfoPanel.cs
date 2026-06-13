using System;
using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class InfoPanel
    {
    	public RenderArea Are;

    	private ModeEventDispatcher Med;

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

    	public InfoPanel(ModeEventDispatcher Med, RenderArea Are)
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
    		MaiB.SetBasePointBase(Dat.Vec2DZero);
    		MaiB.SetPositionBase(vector2D);
    		MaiB.SetSizeBase(num2);
    		MaiB.GetOP().AddRange(new Out[1] { Shas.GetSquare() });
    		MaiB.GetOP().ScalingX(MaiB.GetBasePointBase(), num3);
    		MaiB.GetOP().ScalingY(MaiB.GetBasePointBase(), num4);
    		MaiB.SetClosed(true);
    		MaiB.SetBrushColor(Color.FromArgb(160, Col.Black));
    		MaiB.Hit = false;
    		MaiB.GetJP().Add(new Joi(MaiB.GetOP().GetCenter()));
    		Mai = new Tex("Tex1", vector2D, num2, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), 0.08, 0, " ", Col.White, Col.Black, Color.Transparent, 19.0, Col.White, delegate(Tex sp)
    		{
    			sp.Text = sp.Text;
    		});
    		Mai.ParT.SetBasePointBase(Mai.ParT.GetOP().GetCenter().MulY(y));
    		Mai.Position = MaiB.ToGlobal(MaiB.GetJP()[0].Joint);
    		Mai.Feed.GetOP().OutlineFalse();
    		double num5 = num4 * 4.53;
    		Mai2B = new Par();
    		Mai2B.SetBasePointBase(Dat.Vec2DZero);
    		Mai2B.SetPositionBase(new Vector2D(vector2D.X, 0.01));
    		Mai2B.SetSizeBase(num2);
    		Mai2B.GetOP().AddRange(new Out[1] { Shas.GetSquare() });
    		Mai2B.GetOP().ScalingX(Mai2B.GetBasePointBase(), num3);
    		Mai2B.GetOP().ScalingY(Mai2B.GetBasePointBase(), num5);
    		Mai2B.SetClosed(true);
    		Mai2B.SetBrushColor(Color.FromArgb(160, Col.Black));
    		Mai2B.Hit = false;
    		Mai2B.GetJP().Add(new Joi(Mai2B.GetOP().GetCenter()));
    		Mai2 = new Tex("Tex3", vector2D, num2, num3 * 0.98, num5 * 0.97, new Font("MS Gothic", 1f), 0.08, 0, " ", Col.White, Col.Black, Color.Transparent, 19.0, Col.White, delegate(Tex sp)
    		{
    			sp.Text = sp.Text;
    		});
    		Mai2.ParT.SetBasePointBase(Mai2.ParT.GetOP().GetCenter().MulY(y));
    		Mai2.Position = Mai2B.ToGlobal(Mai2B.GetJP()[0].Joint);
    		Mai2.Feed.GetOP().OutlineFalse();
    		num3 = Are.LocalWidth * 0.19 / num2;
    		vector2D = Are.GetPosition(1.0 - (num3 * num2 / Are.LocalWidth + 0.005), 1.0 - num4 * num2 / Are.LocalHeight).AddY(0.0 - num);
    		SubB = new Par();
    		SubB.SetBasePointBase(Dat.Vec2DZero);
    		SubB.SetPositionBase(vector2D);
    		SubB.SetSizeBase(num2);
    		SubB.GetOP().AddRange(new Out[1] { Shas.GetSquare() });
    		SubB.GetOP().ScalingX(SubB.GetBasePointBase(), num3);
    		SubB.GetOP().ScalingY(SubB.GetBasePointBase(), num4);
    		SubB.SetClosed(true);
    		SubB.SetBrushColor(Color.FromArgb(160, Col.Black));
    		SubB.Hit = false;
    		SubB.GetJP().Add(new Joi(SubB.GetOP().GetCenter()));
    		Sub = new Tex("Tex4", vector2D, num2 * 1.01, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), 0.07, 0, " ", Col.White, Col.Black, Color.Transparent, 15.0);
    		Sub.ParT.SetBasePointBase(Sub.ParT.GetOP().GetCenter().MulY(y));
    		Sub.Position = SubB.ToGlobal(SubB.GetJP()[0].Joint);
    		SubInnfo_l = new Lab(Are, "SubInfo", vector2D, num2, 1.0, new Font("MS Gothic", 1f), 0.07, "Sub Info.", Col.White, Col.Black, Color.FromArgb(160, Col.Black), Col.Empty);
    		SubInnfo_l.ParT.SetPositionBase(SubInnfo_l.ParT.GetPositionBase().AddY((0.0 - SubInnfo_l.ParT.GetOP()[0].ps[3].Y) * SubInnfo_l.ParT.GetSizeBase()));
    		Sub2B = new Par();
    		Sub2B.SetBasePointBase(Dat.Vec2DZero);
    		Sub2B.SetPositionBase(new Vector2D(0.0025, vector2D.Y));
    		Sub2B.SetSizeBase(num2);
    		Sub2B.GetOP().AddRange(new Out[1] { Shas.GetSquare() });
    		Sub2B.GetOP().ScalingX(Sub2B.GetBasePointBase(), num3);
    		Sub2B.GetOP().ScalingY(Sub2B.GetBasePointBase(), num4);
    		Sub2B.SetClosed(true);
    		Sub2B.SetBrushColor(Color.FromArgb(160, Col.Black));
    		Sub2B.Hit = false;
    		Sub2B.GetJP().Add(new Joi(SubB.GetOP().GetCenter()));
    		Sub2 = new Tex("Tex3", Sub2B.GetPositionBase(), num2 * 1.01, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), 0.07, 0, "", Col.White, Col.Black, Color.Transparent, 15.0);
    		Sub2.ParT.SetBasePointBase(Sub2.ParT.GetOP().GetCenter().MulY(y));
    		Sub2.Position = Sub2B.ToGlobal(Sub2B.GetJP()[0].Joint);
    		yp = new ParT();
    		yp.Text = "・" + GameText.はい;
    		yp.SetSizeBase(Mai.ParT.GetSizeBase());
    		yp.SetFont(new Font("MS Gothic", 1f));
    		yp.SetFontSize(Mai.ParT.GetFontSize());
    		yp.SetStringRectOutline(Are.UnitScale, Are.DisplayGraphics);
    		yp.SetRectSize(new Vector2D(yp.GetOP()[0].ps[1].X, yp.GetOP()[0].ps[2].Y));
    		yp.GetOP().ScalingY(yp.GetBasePointBase(), 0.9);
    		yp.GetOP().OutlineFalse();
    		yp.SetClosed(true);
    		yp.SetTextColor(Col.White);
    		yp.SetBrushColor(Color.FromArgb(0, Col.Black));
    		yp.SetShadBrush(new SolidBrush(Col.Black));
    		yp.GetStringFormat().Alignment = StringAlignment.Center;
    		yp.GetStringFormat().LineAlignment = StringAlignment.Center;
    		yp.SetPositionBase(new Vector2D(MaiB.GetPosition().X + 0.001, MaiB.GetPosition().Y));
    		yp.Dra = false;
    		yb = new But1(yp, delegate
    		{
    		});
    		np = new ParT();
    		np.Text = "・" + GameText.いいえ;
    		np.SetSizeBase(Mai.ParT.GetSizeBase());
    		np.SetFont(new Font("MS Gothic", 1f));
    		np.SetFontSize(Mai.ParT.GetFontSize());
    		np.SetStringRectOutline(Are.UnitScale, Are.DisplayGraphics);
    		np.SetRectSize(new Vector2D(np.GetOP()[0].ps[1].X, np.GetOP()[0].ps[2].Y));
    		np.GetOP().ScalingY(np.GetBasePointBase(), 0.9);
    		np.GetOP().OutlineFalse();
    		np.SetClosed(true);
    		np.SetTextColor(Col.White);
    		np.SetBrushColor(Color.FromArgb(0, Col.Black));
    		np.SetShadBrush(new SolidBrush(Col.Black));
    		np.GetStringFormat().Alignment = StringAlignment.Center;
    		np.GetStringFormat().LineAlignment = StringAlignment.Center;
    		np.SetPositionBase(new Vector2D(MaiB.GetPosition().X + 0.001, MaiB.GetPosition().Y));
    		np.Dra = false;
    		nb = new But1(np, delegate
    		{
    		});
    	}

    	public void SetHitColor(ModeEventDispatcher Med)
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
    		yp.SetPositionBase(new Vector2D(yp.GetPositionBase().X, Mai.ParT.ToGlobal(Mai.ParT.GetStringRect(Are.UnitScale, Are.DisplayGraphics).v2).Y + 0.0025));
    		np.SetPositionBase(new Vector2D(np.GetPositionBase().X, yp.ToGlobal(yp.GetOP().Last().ps.Last()).Y + 0.0025));
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

    	public void Draw(RenderArea Are, FPS FPS)
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
