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

    	public ShapePart MaiB;

    	public TextBlock Mai;

    	public ShapePart Mai2B;

    	public TextBlock Mai2;

    	public ShapePart SubB;

    	public TextBlock Sub;

    	public ShapePart Sub2B;

    	public TextBlock Sub2;

    	private Lab SubInnfo_l;

    	public bool MaiShow = true;

    	public bool Mai2Show = true;

    	public bool SubShow = true;

    	public bool Sub2Show = true;

    	private ShapePartT yp;

    	private ShapePartT np;

    	public Button yb;

    	public Button nb;

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

    	public Action<ButtonBase> 選択yAct
    	{
    		set
    		{
    			yb.Action = delegate(ButtonBase a)
    			{
    				value(a);
    			};
    		}
    	}

    	public Action<ButtonBase> 選択nAct
    	{
    		set
    		{
    			nb.Action = delegate(ButtonBase a)
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
    		MaiB = new ShapePart();
    		MaiB.SetBasePointBase(DataConsts.Vec2DZero);
    		MaiB.SetPositionBase(vector2D);
    		MaiB.SetSizeBase(num2);
    		MaiB.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		MaiB.GetOP().ScalingX(MaiB.GetBasePointBase(), num3);
    		MaiB.GetOP().ScalingY(MaiB.GetBasePointBase(), num4);
    		MaiB.SetClosed(true);
    		MaiB.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		MaiB.Hit = false;
    		MaiB.GetJP().Add(new JointPoint(MaiB.GetOP().GetCenter()));
    		Mai = new TextBlock("Tex1", vector2D, num2, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), 0.08, 0, " ", ColorHelper.White, ColorHelper.Black, Color.Transparent, 19.0, ColorHelper.White, delegate(TextBlock sp)
    		{
    			sp.Text = sp.Text;
    		});
    		Mai.ShapePartT.SetBasePointBase(Mai.ShapePartT.GetOP().GetCenter().MulY(y));
    		Mai.Position = MaiB.ToGlobal(MaiB.GetJP()[0].Joint);
    		Mai.Feed.GetOP().OutlineFalse();
    		double num5 = num4 * 4.53;
    		Mai2B = new ShapePart();
    		Mai2B.SetBasePointBase(DataConsts.Vec2DZero);
    		Mai2B.SetPositionBase(new Vector2D(vector2D.X, 0.01));
    		Mai2B.SetSizeBase(num2);
    		Mai2B.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		Mai2B.GetOP().ScalingX(Mai2B.GetBasePointBase(), num3);
    		Mai2B.GetOP().ScalingY(Mai2B.GetBasePointBase(), num5);
    		Mai2B.SetClosed(true);
    		Mai2B.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		Mai2B.Hit = false;
    		Mai2B.GetJP().Add(new JointPoint(Mai2B.GetOP().GetCenter()));
    		Mai2 = new TextBlock("Tex3", vector2D, num2, num3 * 0.98, num5 * 0.97, new Font("MS Gothic", 1f), 0.08, 0, " ", ColorHelper.White, ColorHelper.Black, Color.Transparent, 19.0, ColorHelper.White, delegate(TextBlock sp)
    		{
    			sp.Text = sp.Text;
    		});
    		Mai2.ShapePartT.SetBasePointBase(Mai2.ShapePartT.GetOP().GetCenter().MulY(y));
    		Mai2.Position = Mai2B.ToGlobal(Mai2B.GetJP()[0].Joint);
    		Mai2.Feed.GetOP().OutlineFalse();
    		num3 = Are.LocalWidth * 0.19 / num2;
    		vector2D = Are.GetPosition(1.0 - (num3 * num2 / Are.LocalWidth + 0.005), 1.0 - num4 * num2 / Are.LocalHeight).AddY(0.0 - num);
    		SubB = new ShapePart();
    		SubB.SetBasePointBase(DataConsts.Vec2DZero);
    		SubB.SetPositionBase(vector2D);
    		SubB.SetSizeBase(num2);
    		SubB.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		SubB.GetOP().ScalingX(SubB.GetBasePointBase(), num3);
    		SubB.GetOP().ScalingY(SubB.GetBasePointBase(), num4);
    		SubB.SetClosed(true);
    		SubB.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		SubB.Hit = false;
    		SubB.GetJP().Add(new JointPoint(SubB.GetOP().GetCenter()));
    		Sub = new TextBlock("Tex4", vector2D, num2 * 1.01, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), 0.07, 0, " ", ColorHelper.White, ColorHelper.Black, Color.Transparent, 15.0);
    		Sub.ShapePartT.SetBasePointBase(Sub.ShapePartT.GetOP().GetCenter().MulY(y));
    		Sub.Position = SubB.ToGlobal(SubB.GetJP()[0].Joint);
    		SubInnfo_l = new Lab(Are, "SubInfo", vector2D, num2, 1.0, new Font("MS Gothic", 1f), 0.07, "Sub Info.", ColorHelper.White, ColorHelper.Black, Color.FromArgb(160, ColorHelper.Black), ColorHelper.Empty);
    		SubInnfo_l.ShapePartT.SetPositionBase(SubInnfo_l.ShapePartT.GetPositionBase().AddY((0.0 - SubInnfo_l.ShapePartT.GetOP()[0].ps[3].Y) * SubInnfo_l.ShapePartT.GetSizeBase()));
    		Sub2B = new ShapePart();
    		Sub2B.SetBasePointBase(DataConsts.Vec2DZero);
    		Sub2B.SetPositionBase(new Vector2D(0.0025, vector2D.Y));
    		Sub2B.SetSizeBase(num2);
    		Sub2B.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		Sub2B.GetOP().ScalingX(Sub2B.GetBasePointBase(), num3);
    		Sub2B.GetOP().ScalingY(Sub2B.GetBasePointBase(), num4);
    		Sub2B.SetClosed(true);
    		Sub2B.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		Sub2B.Hit = false;
    		Sub2B.GetJP().Add(new JointPoint(SubB.GetOP().GetCenter()));
    		Sub2 = new TextBlock("Tex3", Sub2B.GetPositionBase(), num2 * 1.01, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), 0.07, 0, "", ColorHelper.White, ColorHelper.Black, Color.Transparent, 15.0);
    		Sub2.ShapePartT.SetBasePointBase(Sub2.ShapePartT.GetOP().GetCenter().MulY(y));
    		Sub2.Position = Sub2B.ToGlobal(Sub2B.GetJP()[0].Joint);
    		yp = new ShapePartT();
    		yp.Text = "・" + GameText.はい;
    		yp.SetSizeBase(Mai.ShapePartT.GetSizeBase());
    		yp.SetFont(new Font("MS Gothic", 1f));
    		yp.SetFontSize(Mai.ShapePartT.GetFontSize());
    		yp.SetStringRectOutline(Are.UnitScale, Are.DisplayGraphics);
    		yp.SetRectSize(new Vector2D(yp.GetOP()[0].ps[1].X, yp.GetOP()[0].ps[2].Y));
    		yp.GetOP().ScalingY(yp.GetBasePointBase(), 0.9);
    		yp.GetOP().OutlineFalse();
    		yp.SetClosed(true);
    		yp.SetTextColor(ColorHelper.White);
    		yp.SetBrushColor(Color.FromArgb(0, ColorHelper.Black));
    		yp.SetShadBrush(new SolidBrush(ColorHelper.Black));
    		yp.GetStringFormat().Alignment = StringAlignment.Center;
    		yp.GetStringFormat().LineAlignment = StringAlignment.Center;
    		yp.SetPositionBase(new Vector2D(MaiB.GetPosition().X + 0.001, MaiB.GetPosition().Y));
    		yp.Dra = false;
    		yb = new Button(yp, delegate
    		{
    		});
    		np = new ShapePartT();
    		np.Text = "・" + GameText.いいえ;
    		np.SetSizeBase(Mai.ShapePartT.GetSizeBase());
    		np.SetFont(new Font("MS Gothic", 1f));
    		np.SetFontSize(Mai.ShapePartT.GetFontSize());
    		np.SetStringRectOutline(Are.UnitScale, Are.DisplayGraphics);
    		np.SetRectSize(new Vector2D(np.GetOP()[0].ps[1].X, np.GetOP()[0].ps[2].Y));
    		np.GetOP().ScalingY(np.GetBasePointBase(), 0.9);
    		np.GetOP().OutlineFalse();
    		np.SetClosed(true);
    		np.SetTextColor(ColorHelper.White);
    		np.SetBrushColor(Color.FromArgb(0, ColorHelper.Black));
    		np.SetShadBrush(new SolidBrush(ColorHelper.Black));
    		np.GetStringFormat().Alignment = StringAlignment.Center;
    		np.GetStringFormat().LineAlignment = StringAlignment.Center;
    		np.SetPositionBase(new Vector2D(MaiB.GetPosition().X + 0.001, MaiB.GetPosition().Y));
    		np.Dra = false;
    		nb = new Button(np, delegate
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
    		Sub2.TextIm = GameText.所持金 + "\r\n" + GlobalState.GameData.所持金.ToString("#,0") + "\r\n" + GameText.借金 + "\r\n" + GlobalState.GameData.借金.ToString("#,0") + "\r\n" + GlobalState.GameData.日数 + GameText.日目 + "/" + GlobalState.GameData.時間帯;
    	}

    	private void SetButPos()
    	{
    		yp.SetPositionBase(new Vector2D(yp.GetPositionBase().X, Mai.ShapePartT.ToGlobal(Mai.ShapePartT.GetStringRect(Are.UnitScale, Are.DisplayGraphics).v2).Y + 0.0025));
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

    	public void Draw(RenderArea Are, FpsCounter FPS)
    	{
    		if (MaiShow)
    		{
    			Are.Draw(MaiB);
    			Mai.Progression(FPS);
    			Are.Draw(Mai.PartGroup);
    		}
    		if (Mai2Show)
    		{
    			Are.Draw(Mai2B);
    			Are.Draw(Mai2.PartGroup);
    		}
    		if (SubShow)
    		{
    			Are.Draw(SubB);
    			Sub.Progression(FPS);
    			Are.Draw(Sub.PartGroup);
    			Are.Draw(SubInnfo_l.ShapePartT);
    		}
    		if (Sub2Show)
    		{
    			Are.Draw(Sub2B);
    			Are.Draw(Sub2.PartGroup);
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
