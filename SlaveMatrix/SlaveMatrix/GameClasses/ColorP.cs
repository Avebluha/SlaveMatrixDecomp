using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class ColorP
    {
    	public ShapePart ShapePart;

    	public ColorD ColorD;

    	public double Unit;

    	public bool abj;

    	private Action p;

    	private Action b;

    	private LinearGradientBrush LGB;

    	private double u0;

    	private double u1;

    	private float f0;

    	private float f1;

    	public ColorP(ShapePart ShapePart, ColorD ColorD, double Unit, bool abj)
    	{
    		this.ShapePart = ShapePart;
    		this.ColorD = ColorD;
    		this.Unit = Unit;
    		this.abj = abj;
    		Setting();
    	}

    	public void Setting()
    	{
    		ShapePart.Brush = new SolidBrush(Color.LightGray);
    		u0 = Unit * 0.99009900990099;
    		u1 = Unit * 1.01;
    		if (ColorD.線 == ColorHelper.Empty)
    		{
    			ShapePart.Pen = null;
    			p = delegate
    			{
    			};
    		}
    		else
    		{
    			if (abj)
    			{
    				ShapePart.GetAlpha(out var ret);
    				ColorD.線 = Color.FromArgb(ret, ColorD.線);
    			}
    			p = delegate
    			{
    				ShapePart.PenColor = ColorD.線;
    			};
    			UpdateLine();
    		}
    		if (ColorD.色.Col1 == ColorHelper.Empty)
    		{
    			ShapePart.Brush = null;
    			b = delegate
    			{
    			};
    		}
    		else
    		{
    			if (ColorD.色.Col2 == ColorHelper.Empty)
    			{
    				b = delegate
    				{
    					ShapePart.BrushColor = ColorD.色.Col1;
    				};
    			}
    			else
    			{
    				Vector2D[] MM;
    				float f0;
    				float f1;
    				b = delegate
    				{
    					ShapePart.GetMiY_MaY(out MM);
    					f0 = (float)(MM[0].Y * u0);
    					f1 = (float)(MM[1].Y * u1);
    					if (f0 >= 0f || f1 >= 0f)
    					{
    						LGB = new LinearGradientBrush(new PointF(0f, f0), new PointF(0f, f1), ColorD.色.Col1, ColorD.色.Col2);
    						LGB.GammaCorrection = true;
    						ShapePart.Brush = LGB;
    					}
    				};
    			}
    			UpdateColor();
    		}
    		if (ShapePart.Pen == null && ShapePart.Brush == null)
    		{
    			ShapePart.Dra = false;
    			ShapePart.Hit = false;
    		}
    	}

    	public void UpdateLine()
    	{
    		p();
    	}

    	public void UpdateColor()
    	{
    		b();
    	}

    	public void Update()
    	{
    		if (ShapePart.Dra)
    		{
    			p();
    			b();
    		}
    	}

    	public void Update(Vector2D[] mm)
    	{
    		if (ShapePart.Dra)
    		{
    			p();
    			f0 = (float)(mm[0].Y * u0);
    			f1 = (float)(mm[1].Y * u1);
    			if (f0 >= 0f || f1 >= 0f)
    			{
    				LGB = new LinearGradientBrush(new PointF(0f, f0), new PointF(0f, f1), ColorD.色.Col1, ColorD.色.Col2);
    				LGB.GammaCorrection = true;
    				ShapePart.Brush = LGB;
    			}
    		}
    	}
    }
}
