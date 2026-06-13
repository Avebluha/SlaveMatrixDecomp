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
    		MaiB.BasePointBase = DataConsts.Vec2DZero;
    		MaiB.PositionBase = vector2D;
    		MaiB.SizeBase = num2;
    		MaiB.OP.AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		MaiB.OP.ScalingX(MaiB.BasePointBase, num3);
    		MaiB.OP.ScalingY(MaiB.BasePointBase, num4);
    		MaiB.Closed = true;
    		MaiB.BrushColor = Color.FromArgb(160, ColorHelper.Black);
    		MaiB.Hit = false;
    		MaiB.JP.Add(new JointPoint(MaiB.OP.GetCenter()));
    		Mai = new TextBlock("Tex1", vector2D, num2, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), 0.08, 0, " ", ColorHelper.White, ColorHelper.Black, Color.Transparent, 19.0, ColorHelper.White, delegate(TextBlock sp)
    		{
    			sp.Text = sp.Text;
    		});
    		Mai.ShapePartT.BasePointBase = Mai.ShapePartT.OP.GetCenter().MulY(y);
    		Mai.Position = MaiB.ToGlobal(MaiB.JP[0].Joint);
    		Mai.Feed.OP.OutlineFalse();
    		double num5 = num4 * 4.53;
    		Mai2B = new ShapePart();
    		Mai2B.BasePointBase = DataConsts.Vec2DZero;
    		Mai2B.PositionBase = new Vector2D(vector2D.X, 0.01);
    		Mai2B.SizeBase = num2;
    		Mai2B.OP.AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		Mai2B.OP.ScalingX(Mai2B.BasePointBase, num3);
    		Mai2B.OP.ScalingY(Mai2B.BasePointBase, num5);
    		Mai2B.Closed = true;
    		Mai2B.BrushColor = Color.FromArgb(160, ColorHelper.Black);
    		Mai2B.Hit = false;
    		Mai2B.JP.Add(new JointPoint(Mai2B.OP.GetCenter()));
    		Mai2 = new TextBlock("Tex3", vector2D, num2, num3 * 0.98, num5 * 0.97, new Font("MS Gothic", 1f), 0.08, 0, " ", ColorHelper.White, ColorHelper.Black, Color.Transparent, 19.0, ColorHelper.White, delegate(TextBlock sp)
    		{
    			sp.Text = sp.Text;
    		});
    		Mai2.ShapePartT.BasePointBase = Mai2.ShapePartT.OP.GetCenter().MulY(y);
    		Mai2.Position = Mai2B.ToGlobal(Mai2B.JP[0].Joint);
    		Mai2.Feed.OP.OutlineFalse();
    		num3 = Are.LocalWidth * 0.19 / num2;
    		vector2D = Are.GetPosition(1.0 - (num3 * num2 / Are.LocalWidth + 0.005), 1.0 - num4 * num2 / Are.LocalHeight).AddY(0.0 - num);
    		SubB = new ShapePart();
    		SubB.BasePointBase = DataConsts.Vec2DZero;
    		SubB.PositionBase = vector2D;
    		SubB.SizeBase = num2;
    		SubB.OP.AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		SubB.OP.ScalingX(SubB.BasePointBase, num3);
    		SubB.OP.ScalingY(SubB.BasePointBase, num4);
    		SubB.Closed = true;
    		SubB.BrushColor = Color.FromArgb(160, ColorHelper.Black);
    		SubB.Hit = false;
    		SubB.JP.Add(new JointPoint(SubB.OP.GetCenter()));
    		Sub = new TextBlock("Tex4", vector2D, num2 * 1.01, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), 0.07, 0, " ", ColorHelper.White, ColorHelper.Black, Color.Transparent, 15.0);
    		Sub.ShapePartT.BasePointBase = Sub.ShapePartT.OP.GetCenter().MulY(y);
    		Sub.Position = SubB.ToGlobal(SubB.JP[0].Joint);
    		SubInnfo_l = new Lab(Are, "SubInfo", vector2D, num2, 1.0, new Font("MS Gothic", 1f), 0.07, "Sub Info.", ColorHelper.White, ColorHelper.Black, Color.FromArgb(160, ColorHelper.Black), ColorHelper.Empty);
    		SubInnfo_l.ShapePartT.PositionBase = SubInnfo_l.ShapePartT.PositionBase.AddY((0.0 - SubInnfo_l.ShapePartT.OP[0].ps[3].Y) * SubInnfo_l.ShapePartT.SizeBase);
    		Sub2B = new ShapePart();
    		Sub2B.BasePointBase = DataConsts.Vec2DZero;
    		Sub2B.PositionBase = new Vector2D(0.0025, vector2D.Y);
    		Sub2B.SizeBase = num2;
    		Sub2B.OP.AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		Sub2B.OP.ScalingX(Sub2B.BasePointBase, num3);
    		Sub2B.OP.ScalingY(Sub2B.BasePointBase, num4);
    		Sub2B.Closed = true;
    		Sub2B.BrushColor = Color.FromArgb(160, ColorHelper.Black);
    		Sub2B.Hit = false;
    		Sub2B.JP.Add(new JointPoint(SubB.OP.GetCenter()));
    		Sub2 = new TextBlock("Tex3", Sub2B.PositionBase, num2 * 1.01, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), 0.07, 0, "", ColorHelper.White, ColorHelper.Black, Color.Transparent, 15.0);
    		Sub2.ShapePartT.BasePointBase = Sub2.ShapePartT.OP.GetCenter().MulY(y);
    		Sub2.Position = Sub2B.ToGlobal(Sub2B.JP[0].Joint);
    		yp = new ShapePartT();
    		yp.Text = "・" + GameText.はい;
    		yp.SizeBase = Mai.ShapePartT.SizeBase;
    		yp.Font = new Font("MS Gothic", 1f);
    		yp.FontSize = Mai.ShapePartT.FontSize;
    		yp.SetStringRectOutline(Are.UnitScale, Are.DisplayGraphics);
    		yp.RectSize = new Vector2D(yp.OP[0].ps[1].X, yp.OP[0].ps[2].Y);
    		yp.OP.ScalingY(yp.BasePointBase, 0.9);
    		yp.OP.OutlineFalse();
    		yp.Closed = true;
    		yp.TextColor = ColorHelper.White;
    		yp.BrushColor = Color.FromArgb(0, ColorHelper.Black);
    		yp.ShadBrush = new SolidBrush(ColorHelper.Black);
    		yp.StringFormat.Alignment = StringAlignment.Center;
    		yp.StringFormat.LineAlignment = StringAlignment.Center;
    		yp.PositionBase = new Vector2D(MaiB.Position.X + 0.001, MaiB.Position.Y);
    		yp.Dra = false;
    		yb = new Button(yp, delegate
    		{
    		});
    		np = new ShapePartT();
    		np.Text = "・" + GameText.いいえ;
    		np.SizeBase = Mai.ShapePartT.SizeBase;
    		np.Font = new Font("MS Gothic", 1f);
    		np.FontSize = Mai.ShapePartT.FontSize;
    		np.SetStringRectOutline(Are.UnitScale, Are.DisplayGraphics);
    		np.RectSize = new Vector2D(np.OP[0].ps[1].X, np.OP[0].ps[2].Y);
    		np.OP.ScalingY(np.BasePointBase, 0.9);
    		np.OP.OutlineFalse();
    		np.Closed = true;
    		np.TextColor = ColorHelper.White;
    		np.BrushColor = Color.FromArgb(0, ColorHelper.Black);
    		np.ShadBrush = new SolidBrush(ColorHelper.Black);
    		np.StringFormat.Alignment = StringAlignment.Center;
    		np.StringFormat.LineAlignment = StringAlignment.Center;
    		np.PositionBase = new Vector2D(MaiB.Position.X + 0.001, MaiB.Position.Y);
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
    		yp.PositionBase = new Vector2D(yp.PositionBase.X, Mai.ShapePartT.ToGlobal(Mai.ShapePartT.GetStringRect(Are.UnitScale, Are.DisplayGraphics).v2).Y + 0.0025);
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
