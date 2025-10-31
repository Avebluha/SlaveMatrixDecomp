using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class TextBubble
    {
    	public bool 表示 = true;

    	public 吹出し 吹出し;

    	public Tex Tex;

    	public bool Dis;

    	public Mot 消失;

    	public Color GetHitColor => Tex.ParT.HitColor;

    	public string Text
    	{
    		get
    		{
    			return Tex.Text;
    		}
    		set
    		{
    			表示 = true;
    			if (Dis)
    			{
    				Tex.Done = delegate
    				{
                        消失.Max = Tex.Text.Length * 0.125 + 1.0;
                        消失.Start();
                    };
    			}
    			Tex.Text = value;
    		}
    	}

    	public TextBubble(RenderArea Are, bool 右, Font Font, double TextSize, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed, bool Dis, Color FeedColor, Action<Tex> Action)
    	{
    		吹出し = new 吹出し(Are.DisplayUnitScale);
    		吹出し.SetHitFalse();
    		吹出し.右 = 右;
    		吹出し.吹出しCD.色 = new Color2(ref BackColor, ref Col.Empty);
    		吹出し.X0Y0_吹出しCP.Setting();
    		double num = 1.35;
    		double num2 = 0.75;
    		吹出し.位置C = Dat.Vec2DUnitY * 0.005;
    		吹出し.尺度B = num * 1.1;
    		吹出し.尺度YB = num2;
    		Tex = new Tex("Tex", Dat.Vec2DZero, 0.1, 吹出し.尺度B, 0.63 * num * num2, Font, TextSize, 25, Text, TextColor, ShadColor, Color.Transparent, Speed, FeedColor, Action);
    		Tex.Feed.OP.OutlineFalse();
    		Tex.ParT.BasePointBase = Tex.ParT.OP.GetCenter().AddY(0.04);
    		this.Dis = Dis;
    		if (Dis)
    		{
    			表示 = false;
    			int pa = 吹出し.X0Y0_吹出し.PenColor.A;
    			int ba = 吹出し.X0Y0_吹出し.BrushColor.A;
    			int ta = TextColor.A;
    			int sa = ShadColor.A;
    			double v;

    			消失 = new Mot(0.0, 1.0)
    			{
    				BaseSpeed = 1.0,
    				Staing = delegate
    				{
                    },
    				Runing = delegate(Mot m)
    				{
    					if (m.Value < m.Max - 1)
    						return;
    					v = (1 + m.Value - m.Max).Inverse();
    					吹出し.X0Y0_吹出し.PenColor = Color.FromArgb((int)((double)pa * v), 吹出し.X0Y0_吹出し.PenColor);
    					吹出し.X0Y0_吹出し.BrushColor = Color.FromArgb((int)((double)ba * v), 吹出し.X0Y0_吹出し.BrushColor);
    					Tex.ParT.TextColor = Color.FromArgb((int)((double)ta * v), Tex.ParT.TextColor);
    					Tex.ParT.ShadColor = Color.FromArgb((int)((double)sa * v), Tex.ParT.ShadColor);
    				},
    				Reaing = delegate(Mot m)
    				{
    					m.End();
    				},
    				Rouing = delegate
    				{
    				},
    				Ending = delegate
    				{
    					表示 = false;
    					吹出し.X0Y0_吹出し.PenColor = Color.FromArgb(pa, 吹出し.X0Y0_吹出し.PenColor);
    					吹出し.X0Y0_吹出し.BrushColor = Color.FromArgb(ba, 吹出し.X0Y0_吹出し.BrushColor);
    					Tex.ParT.TextColor = Color.FromArgb(ta, Tex.ParT.TextColor);
    					Tex.ParT.ShadColor = Color.FromArgb(sa, Tex.ParT.ShadColor);
    				}
    			};
    		}
    	}

    	public TextBubble(RenderArea Are, bool 右, Font Font, double TextSize, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed, bool Dis)
    	{
    		吹出し = new 吹出し(Are.DisplayUnitScale);
    		吹出し.SetHitFalse();
    		吹出し.右 = 右;
    		吹出し.吹出しCD.色 = new Color2(ref BackColor, ref Col.Empty);
    		吹出し.X0Y0_吹出しCP.Setting();
    		double num = 1.35;
    		double num2 = 0.75;
    		吹出し.位置C = Dat.Vec2DUnitY * 0.005;
    		吹出し.尺度B = num * 1.1;
    		吹出し.尺度YB = num2;
    		Tex = new Tex("Tex", Dat.Vec2DZero, 0.1, 吹出し.尺度B, 0.63 * num * num2, Font, TextSize, 25, Text, TextColor, ShadColor, Color.Transparent, Speed);
    		Tex.ParT.BasePointBase = Tex.ParT.OP.GetCenter().AddY(0.04);
    		this.Dis = Dis;
    		if (Dis)
    		{
    			表示 = false;
    			int pa = 吹出し.X0Y0_吹出し.PenColor.A;
    			int ba = 吹出し.X0Y0_吹出し.BrushColor.A;
    			int ta = TextColor.A;
    			int sa = ShadColor.A;
    			double v;
    			消失 = new Mot(0.0, 1.0)
    			{
    				BaseSpeed = 1.0,
    				Staing = delegate
    				{
    				},
    				Runing = delegate(Mot m)
    				{
                        //After full training slave if i tried to train again game crahes here :3
                        v = (m.Value >= 0) ? m.Value : m.Value.Inverse();

                        var penAlpha = (int)((double)pa * v);
                        var brushAlpha = (int)((double)ba * v);
                        var textAlpha = (int)((double)ta * v);
                        var shadeAlpha = (int)((double)sa * v);

                        var correctPenAlpha = (penAlpha > 255) ? 255 : penAlpha;
                        var correctBrushAlpha = (brushAlpha > 255) ? 255 : brushAlpha;
                        var correctTextAlpha = (textAlpha > 255) ? 255 : textAlpha;
                        var correctShadeAlpha = (shadeAlpha > 255) ? 255 : shadeAlpha; 

                        吹出し.X0Y0_吹出し.PenColor = Color.FromArgb(correctPenAlpha, 吹出し.X0Y0_吹出し.PenColor);
    					吹出し.X0Y0_吹出し.BrushColor = Color.FromArgb(correctBrushAlpha, 吹出し.X0Y0_吹出し.BrushColor);
    					Tex.ParT.TextColor = Color.FromArgb(correctTextAlpha, Tex.ParT.TextColor);
    					Tex.ParT.ShadColor = Color.FromArgb(correctShadeAlpha, Tex.ParT.ShadColor);
    				},
    				Reaing = delegate(Mot m)
    				{
    					m.End();
    				},
    				Rouing = delegate
    				{
    				},
    				Ending = delegate
    				{
    					表示 = false;
    					吹出し.X0Y0_吹出し.PenColor = Color.FromArgb(pa, 吹出し.X0Y0_吹出し.PenColor);
    					吹出し.X0Y0_吹出し.BrushColor = Color.FromArgb(ba, 吹出し.X0Y0_吹出し.BrushColor);
    					Tex.ParT.TextColor = Color.FromArgb(ta, Tex.ParT.TextColor);
    					Tex.ParT.ShadColor = Color.FromArgb(sa, Tex.ParT.ShadColor);
    				}
    			};
    		}
    	}

    	public void SetHitColor(Med Med)
    	{
    		Tex.SetHitColor(Med);
    	}

    	public void 接続(JointS 接続元)
    	{
    		吹出し.接続(接続元);
    		接続();
    	}

    	public void Down(Color HitColor)
    	{
    		Tex.Down(ref HitColor);
    	}

    	public void Up(Color HitColor)
    	{
    		Tex.Up(ref HitColor);
    	}

    	public void 接続()
    	{
    		吹出し.接続P();
    		Tex.Position = 吹出し.X0Y0_吹出し.ToGlobal(吹出し.X0Y0_吹出し.JP[0].Joint);
    	}

    	public void Draw(RenderArea Are, FPS FPS)
    	{
    		Tex.Progression(FPS);
    		if (Dis)
    		{
    			消失.GetValue(FPS);
    		}
    		if (表示)
    		{
    			吹出し.本体.Draw(Are);
    			Are.Draw(Tex.Pars);
    		}
    	}

    	public void Dispose()
    	{
    		吹出し.Dispose();
    		Tex.Dispose();
    	}
    }
}
