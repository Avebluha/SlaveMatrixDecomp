using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2DGAMELIB
{
    // renders text
    [Serializable]
    public class ShapePartT : ShapePart
    {

    	private double fontSize = 1.0;

    	[NonSerialized, JsonIgnore]
    	private Font font = new Font("", 1f);

    	[NonSerialized, JsonIgnore]
    	private Brush brusht = new SolidBrush(Color.Black);

    	[NonSerialized, JsonIgnore]
    	private Brush brushs;

    	[NonSerialized, JsonIgnore]
    	private StringFormat stringformat = new StringFormat();

    	private Vector2D positionT = DataConsts.Vec2DZero;

    	private Vector2D rectSize = DataConsts.Vec2DOne;


    	public string Text = "";



    	private Vector2D bp;



    	private bool EditTS = true;
    	private bool EditF = true;



        public void SetFont(Font value)
        {
            if (font != value && font != null)
            {
                font.Dispose();
            }
            font = value;
            EditF = true;
        }

        public double GetFontSize()
        { return fontSize; }

        public void SetFontSize(double value)
        {
            fontSize = value;
            EditF = true;
        }

        public void SetTextBrush(Brush value)
        {
            if (brusht != value && brusht != null)
            {
                brusht.Dispose();
            }
            brusht = value;
        }

        public Color GetTextColor()
        { return ((SolidBrush)brusht).Color; }

        public void SetTextColor(Color value)
        { ((SolidBrush)brusht).Color = value; }

        public void SetShadBrush(Brush value)
        {
            if (brushs != value && brushs != null)
                brushs.Dispose();

            brushs = value;
        }

        public Color GetShadColor()
        { return ((SolidBrush)brushs).Color; }

        public void SetShadColor(Color value)
        { ((SolidBrush)brushs).Color = value; }

        public StringFormat GetStringFormat()
        { return stringformat; }

        public void SetStringFormat(StringFormat value)
        {
            if (stringformat != value && stringformat != null)
            {
                stringformat.Dispose();
            }
            stringformat = value;
        }

        public Vector2D GetRectSize()
        { return rectSize; }

        public void SetRectSize(Vector2D value)
        {
            rectSize = value;
        }

        public new void SetDefault()
    	{
            base.SetDefault();

            if (font != null)
                font.Dispose();

            if (brusht != null)
                brusht.Dispose();

            if (brushs != null)
                brushs.Dispose();

            if (stringformat != null)
                stringformat.Dispose();

            font = new Font("", 1f);
            brusht = new SolidBrush(Color.Black);
            brushs = null;
            stringformat = new StringFormat();

            EditF = true;
            EditTS = true;
        }

    	public ShapePartT()
    	{
    	}

    	public ShapePartT(ShapePartT ShapePartT)
    	{
    		CopyT(ShapePartT);
    	}

    	private void CopyT(ShapePartT ShapePartT)
    	{
    		Copy(ShapePartT);

    		fontSize = ShapePartT.fontSize;

    		if (ShapePartT.font != null)
                SetFont(ShapePartT.font.Copy());

    		if (ShapePartT.brusht != null)
                SetTextBrush(ShapePartT.brusht.Copy());

    		if (ShapePartT.brushs != null)
                SetShadBrush(ShapePartT.brushs.Copy());

    		if (ShapePartT.stringformat != null)
                SetStringFormat(ShapePartT.stringformat.Copy());

    		positionT = ShapePartT.positionT;
    		rectSize = ShapePartT.rectSize;
    		Text = ShapePartT.Text;
    	}

    	public new void Draw(double Unit, Graphics Graphics)
    	{
    		Calculation(Unit);

    		if (EditF || EditTS)
    		{
                RebuildFont((float)(Unit * base.GetSize() * fontSize));
    			EditF = false;
    			EditTS = false;
    		}

    		base.Draw(Unit, Graphics);
    		DrawString(Unit, Graphics);
    	}

    	private void Calculation(double Unit)
    	{
    		double us = Unit * base.GetSize();
    		double usx = us * base.GetSizeX();
    		double usy = us * base.GetSizeY();

    		bp = base.GetBasePoint();
    		bp.X *= usx;
    		bp.Y *= usy;

            double a1 = System.Math.PI * base.GetAngle() / 180.0;
            double M11 = System.Math.Cos(a1);
            double M12 = System.Math.Sin(a1);

			Vector2D v;
    		v.X = bp.X * M11 + bp.Y * (0.0 - M12);
    		v.Y = bp.X * M12 + bp.Y * M11;

    		Vector2D p = base.GetPosition();
    		bp.X = p.X * Unit - v.X;
    		bp.Y = p.Y * Unit - v.Y;
    	}

        private void RebuildFont(double scaledSize)
        {
            if (font == null)
                font = new Font("", 1f);

            Font oldFont = font;

            font = new Font(
                oldFont.FontFamily,
                (float)scaledSize,
                oldFont.Style,
                oldFont.Unit,
                oldFont.GdiCharSet,
                oldFont.GdiVerticalFont);

            oldFont.Dispose();

            EditF = true;
            EditTS = true;
        }

        private void DrawString(double Unit, Graphics Graphics)
    	{
			RectangleF rect = default(RectangleF);
    		rect.X = (float)(positionT.X * Unit * base.GetSize());
    		rect.Y = (float)(positionT.Y * Unit * base.GetSize());
    		rect.Width = (float)(rectSize.X * Unit * base.GetSize());
    		rect.Height = (float)(rectSize.Y * Unit * base.GetSize());

            if (brushs != null)
            {
                GraphicsState state = Graphics.Save();
                Graphics.TranslateTransform((float)(bp.X + 1.0), (float)(bp.Y + 1.0));
                Graphics.RotateTransform((float)base.GetAngle());
                Graphics.ScaleTransform((float)base.GetSizeX(), (float)base.GetSizeY());
                Graphics.DrawString(Text, font, brushs, rect, stringformat);
                Graphics.Restore(state);
            }

            {
                GraphicsState state = Graphics.Save();
                Graphics.TranslateTransform((float)bp.X, (float)bp.Y);
                Graphics.RotateTransform((float)base.GetAngle());
                Graphics.ScaleTransform((float)base.GetSizeX(), (float)base.GetSizeY());
                Graphics.DrawString(Text, font, brusht, rect, stringformat);
                Graphics.Restore(state);
            }
        }

    	public Vector2D_2 GetStringRect(double Unit, Graphics Graphics)
    	{
    		double num = Unit * base.GetSize();

    		if (EditF || EditTS)
    		{
                RebuildFont((float)(num * fontSize));
                EditF = false;
    			EditTS = false;
    		}

    		CharacterRange[] crr = new CharacterRange[]{
				new CharacterRange(0, Text.Length)
			};

    		stringformat.SetMeasurableCharacterRanges(crr);

            RectangleF layoutRect = new RectangleF(
                (float)(positionT.X * num),
                (float)(positionT.Y * num),
                (float)(rectSize.X * num),
                (float)(rectSize.X * num));

            RectangleF bounds = Graphics
                .MeasureCharacterRanges(Text ?? string.Empty,  font, layoutRect, stringformat)[0]
                .GetBounds(Graphics);

            return new Vector2D_2(
                new Vector2D(bounds.X / num, bounds.Y / num),
                new Vector2D(bounds.Width / num, bounds.Height / num));
        }

        public Vector2D[] GetStringRectPoints(double Unit, Graphics Graphics)
    	{
            Vector2D_2 stringRect = GetStringRect(Unit, Graphics);

            Vector2D pos = stringRect.v1;
            Vector2D size = stringRect.v2;

            size.X *= 1.07f;

            return new Vector2D[4]
            {
                pos,
                new Vector2D(pos.X + size.X, pos.Y),
                new Vector2D(pos.X + size.X, pos.Y + size.Y),
                new Vector2D(pos.X, pos.Y + size.Y)
            };
        }
        public void SetStringRectOutline(double Unit, Graphics Graphics)
    	{
    		Vector2D[] stringRectPoints = GetStringRectPoints(Unit, Graphics);

    		CurveOutline curveOutline = new CurveOutline { Tension = 0f };
    		Vector2D vector2D = DataConsts.Vec2DZero - stringRectPoints[0];

    		double x = 0.05;
    		double num = 0.025;

    		curveOutline.ps.Add(stringRectPoints[0].AddY(-num) + vector2D);
    		curveOutline.ps.Add(stringRectPoints[1].AddXY(x, -num) + vector2D);
    		curveOutline.ps.Add(stringRectPoints[2].AddXY(x, num) + vector2D);
    		curveOutline.ps.Add(stringRectPoints[3].AddY(num) + vector2D);

    		base.GetOP().Add(curveOutline);
    	}
		
    	public new void Dispose()
    	{
    		base.Dispose();

    		if (font != null)
    		{
    			font.Dispose();
                font = null;
    		}

    		if (brusht != null)
    		{
    			brusht.Dispose();
                brusht = null;
    		}

    		if (brushs != null)
    		{
    			brushs.Dispose();   
                brushs = null;
    		}

    		if (stringformat != null)
    		{
    			stringformat.Dispose(); 
                stringformat = null;
    		}
    	}
    }
}
