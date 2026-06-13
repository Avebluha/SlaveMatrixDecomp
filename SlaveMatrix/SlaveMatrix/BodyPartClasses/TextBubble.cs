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

    	public TextBlock TextBlock;

    	public bool Dis;

    	public Motion 消失;

    	public Color GetHitColor => TextBlock.ShapePartT.HitColor;

    	public string Text
    	{
    		get
    		{
    			return TextBlock.Text;
    		}
    		set
    		{
    			表示 = true;
    			if (Dis)
    			{
    				TextBlock.Done = delegate
    				{
                        消失.Max = TextBlock.Text.Length * 0.125 + 1.0;
                        消失.Start();
                    };
    			}
    			TextBlock.Text = value;
    		}
    	}

    	public TextBubble(RenderArea Are, bool 右, Font Font, double TextSize, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed, bool Dis, Color FeedColor, Action<TextBlock> Action)
    	{
    		吹出し = new 吹出し(Are.DisplayUnitScale);
    		吹出し.SetHitFalse();
    		吹出し.右 = 右;
    		吹出し.吹出しCD.色 = new Color2(ref BackColor, ref ColorHelper.Empty);
    		吹出し.X0Y0_吹出しCP.Setting();
    		double num = 1.35;
    		double num2 = 0.75;
    		吹出し.位置C = DataConsts.Vec2DUnitY * 0.005;
    		吹出し.尺度B = num * 1.1;
    		吹出し.尺度YB = num2;
    		TextBlock = new TextBlock("TextBlock", DataConsts.Vec2DZero, 0.1, 吹出し.尺度B, 0.63 * num * num2, Font, TextSize, 25, Text, TextColor, ShadColor, Color.Transparent, Speed, FeedColor, Action);
    		TextBlock.Feed.OP.OutlineFalse();
    		TextBlock.ShapePartT.BasePointBase = TextBlock.ShapePartT.OP.GetCenter().AddY(0.04);
    		this.Dis = Dis;
    		if (Dis)
    		{
    			表示 = false;
    			int pa = 吹出し.X0Y0_吹出し.PenColor.A;
    			int ba = 吹出し.X0Y0_吹出し.BrushColor.A;
    			int ta = TextColor.A;
    			int sa = ShadColor.A;
    			double v;

    			消失 = new Motion(0.0, 1.0)
    			{
    				BaseSpeed = 1.0,
    				OnStart = delegate
    				{
                    },
    				OnUpdate = delegate(Motion m)
    				{
    					if (m.Value < m.Max - 1)
    						return;
    					v = (1 + m.Value - m.Max).Inverse();
    					吹出し.X0Y0_吹出し.PenColor = Color.FromArgb((int)((double)pa * v), 吹出し.X0Y0_吹出し.PenColor);
    					吹出し.X0Y0_吹出し.BrushColor = Color.FromArgb((int)((double)ba * v), 吹出し.X0Y0_吹出し.BrushColor);
    					TextBlock.ShapePartT.TextColor = Color.FromArgb((int)((double)ta * v), TextBlock.ShapePartT.TextColor);
    					TextBlock.ShapePartT.ShadColor = Color.FromArgb((int)((double)sa * v), TextBlock.ShapePartT.ShadColor);
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
    					表示 = false;
    					吹出し.X0Y0_吹出し.PenColor = Color.FromArgb(pa, 吹出し.X0Y0_吹出し.PenColor);
    					吹出し.X0Y0_吹出し.BrushColor = Color.FromArgb(ba, 吹出し.X0Y0_吹出し.BrushColor);
    					TextBlock.ShapePartT.TextColor = Color.FromArgb(ta, TextBlock.ShapePartT.TextColor);
    					TextBlock.ShapePartT.ShadColor = Color.FromArgb(sa, TextBlock.ShapePartT.ShadColor);
    				}
    			};
    		}
    	}

    	public TextBubble(RenderArea Are, bool 右, Font Font, double TextSize, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed, bool Dis)
    	{
    		吹出し = new 吹出し(Are.DisplayUnitScale);
    		吹出し.SetHitFalse();
    		吹出し.右 = 右;
    		吹出し.吹出しCD.色 = new Color2(ref BackColor, ref ColorHelper.Empty);
    		吹出し.X0Y0_吹出しCP.Setting();
    		double num = 1.35;
    		double num2 = 0.75;
    		吹出し.位置C = DataConsts.Vec2DUnitY * 0.005;
    		吹出し.尺度B = num * 1.1;
    		吹出し.尺度YB = num2;
    		TextBlock = new TextBlock("TextBlock", DataConsts.Vec2DZero, 0.1, 吹出し.尺度B, 0.63 * num * num2, Font, TextSize, 25, Text, TextColor, ShadColor, Color.Transparent, Speed);
    		TextBlock.ShapePartT.BasePointBase = TextBlock.ShapePartT.OP.GetCenter().AddY(0.04);
    		this.Dis = Dis;
    		if (Dis)
    		{
    			表示 = false;
    			int pa = 吹出し.X0Y0_吹出し.PenColor.A;
    			int ba = 吹出し.X0Y0_吹出し.BrushColor.A;
    			int ta = TextColor.A;
    			int sa = ShadColor.A;
    			double v;
    			消失 = new Motion(0.0, 1.0)
    			{
    				BaseSpeed = 1.0,
    				OnStart = delegate
    				{
    				},
    				OnUpdate = delegate(Motion m)
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
    					TextBlock.ShapePartT.TextColor = Color.FromArgb(correctTextAlpha, TextBlock.ShapePartT.TextColor);
    					TextBlock.ShapePartT.ShadColor = Color.FromArgb(correctShadeAlpha, TextBlock.ShapePartT.ShadColor);
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
    					表示 = false;
    					吹出し.X0Y0_吹出し.PenColor = Color.FromArgb(pa, 吹出し.X0Y0_吹出し.PenColor);
    					吹出し.X0Y0_吹出し.BrushColor = Color.FromArgb(ba, 吹出し.X0Y0_吹出し.BrushColor);
    					TextBlock.ShapePartT.TextColor = Color.FromArgb(ta, TextBlock.ShapePartT.TextColor);
    					TextBlock.ShapePartT.ShadColor = Color.FromArgb(sa, TextBlock.ShapePartT.ShadColor);
    				}
    			};
    		}
    	}

    	public void SetHitColor(ModeEventDispatcher Med)
    	{
    		TextBlock.SetHitColor(Med);
    	}

    	public void 接続(JointS 接続元)
    	{
    		吹出し.接続(接続元);
    		接続();
    	}

    	public void Down(Color HitColor)
    	{
    		TextBlock.Down(ref HitColor);
    	}

    	public void Up(Color HitColor)
    	{
    		TextBlock.Up(ref HitColor);
    	}

    	public void 接続()
    	{
    		吹出し.接続P();
    		TextBlock.Position = 吹出し.X0Y0_吹出し.ToGlobal(吹出し.X0Y0_吹出し.JP[0].Joint);
    	}

    	public void Draw(RenderArea Are, FpsCounter FPS)
    	{
    		TextBlock.Progression(FPS);
    		if (Dis)
    		{
    			消失.GetValue(FPS);
    		}
    		if (表示)
    		{
    			吹出し.Body.Draw(Are);
    			Are.Draw(TextBlock.PartGroup);
    		}
    	}

    	public void Dispose()
    	{
    		吹出し.Dispose();
    		TextBlock.Dispose();
    	}
    }
}
