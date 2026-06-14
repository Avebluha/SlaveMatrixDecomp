using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Diagnostics;
using System.Numerics;

namespace _2DGAMELIB
{
    //represents a whole or part of a body part :3
    [Serializable]
    public class ShapePart
    {
        private PartGroup parent;

    	public string Tag = "";

    	protected List<CurveOutline> op = new List<CurveOutline>();

    	protected List<JointPoint> jp = new List<JointPoint>();

    	protected Vector2D basePointBase = DataConsts.Vec2DZero;

        protected Vector2D basePointCont = DataConsts.Vec2DZero;

    	protected Vector2D positionBase = DataConsts.Vec2DZero;

    	protected Vector2D positionContO = DataConsts.Vec2DZero;

    	protected Vector2D positionCont = DataConsts.Vec2DZero;

    	protected double positionSize = 1.0;

    	protected Vector2D positionVector = DataConsts.Vec2DZero;

    	protected double anglePare;

    	protected double angleBase;

    	protected double angleCont;

    	protected double sizeBase = 1.0;

    	protected double sizeCont = 1.0;

    	protected double xSizeBase = 1.0;

    	protected double xSizeCont = 1.0;

    	protected double ySizeBase = 1.0;

    	protected double ySizeCont = 1.0;

    	protected double penWidth;

		
        [NonSerialized, JsonIgnore]
    	protected Pen pen = new Pen(Color.Black, 1f);

        [NonSerialized, JsonIgnore]
    	protected Brush brush = new SolidBrush(Color.LightGray);

        [NonSerialized, JsonIgnore]
    	protected SolidBrush HitBrush = new SolidBrush(Color.Transparent);

        [NonSerialized, JsonIgnore]
    	private GraphicsPath Path = new GraphicsPath();

        [NonSerialized, JsonIgnore]
    	private GraphicsPath OutlinePath = new GraphicsPath();

        [NonSerialized, JsonIgnore]
    	private GraphicsPath gph = new GraphicsPath();


    	public bool Dra = true;
    	public bool Hit = true;
    	private bool closed;
	    public bool IsClosed => closed;

        public PartGroup GetParent()
        {
            return parent;
        }

        public List<CurveOutline> GetOP()
        {
            return op;
        }

        public void SetInitializeOP(IEnumerable<CurveOutline> value)
        {
            op.Clear();
            op.AddRange(value);
        }

        public List<JointPoint> GetJP()
        {
            return jp;
        }

        public Vector2D GetBasePointBase()
        {
            return basePointBase;
        }

        public void SetBasePointBase(Vector2D value)
        {
            basePointBase = value;
        }

        public Vector2D GetBasePointCont()
        {
            return basePointCont;
        }

        public void SetBasePointCont(Vector2D value)
        {
            basePointCont = value;
        }

        public Vector2D GetBasePoint()
        {
            return basePointBase + basePointCont;
        }

        public Vector2D GetPositionBase()
        {
            return positionBase;
        }

        public void SetPositionBase(Vector2D value)
        {
            positionBase = value;
        }

        public Vector2D GetPositionCont()
        {
            return positionCont;
        }

        public void SetPositionCont(Vector2D value)
        {
            positionCont = value;
        }

        public Vector2D GetPosition()
        {
            double d = System.Math.PI * anglePare / 180.0;
            double num = System.Math.Cos(d);
            double num2 = System.Math.Sin(d);
			Vector2D positionCont;
            positionCont.X = this.positionCont.X * num - this.positionCont.Y * num2;
            positionCont.Y = this.positionCont.X * num2 + this.positionCont.Y * num;
            return (positionBase + positionCont) * positionSize;
        }

        public void SetAngleParent(double value)
        {
            anglePare = value;
        }

        public double GetAngleBase()
        {
            return angleBase;
        }

        public void SetAngleBase(double value)
        {
            angleBase = value;
        }

        public double GetAngleCont()
        {
            return angleCont;
        }

        public void SetAngleCont(double value)
        {
            angleCont = value;
        }

        public double GetAngle()
        {
            return anglePare + angleBase + angleCont;
        }

        public double GetSizeBase()
        {
            return sizeBase;
        }

        public void SetSizeBase(double value)
        {
            sizeBase = value;
        }

        public double GetSizeCont()
        {
            return sizeCont;
        }

        public void SetSizeCont(double value)
        {
            sizeCont = value;
        }

        public double GetSize()
        {
            return sizeBase * sizeCont * positionSize;
        }

        public double GetSizeXBase()
        {
            return xSizeBase;
        }

        public void SetSizeXBase(double value)
        {
            xSizeBase = value;
        }

        public double GetSizeXCont()
        {
            return xSizeCont;
        }

        public void SetSizeXCont(double value)
        {
            xSizeCont = value;
        }

        public double GetSizeX()
        {
            return xSizeBase * xSizeCont;
        }

        public double GetSizeYBase()
        {
            return ySizeBase;
        }

        public void SetSizeYBase(double value)
        {
            ySizeBase = value;
        }

        public double GetSizeYCont()
        {
            return ySizeCont;
        }

        public void SetSizeYCont(double value)
        {
            ySizeCont = value;
        }

        public double GetSizeY()
        {
            return ySizeBase * ySizeCont;
        }

        public void SetClosed(bool value)
        {
            closed = value;
        }

        public Pen GetPen()
        {
            return pen;
        }

        public void SetPen(Pen value)
        {
            if (pen != value && pen != null)
            {
                pen.Dispose();
            }
            pen = value;
            if (pen != null)
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
            }
        }

        public double GetPenWidth()
        {
            return penWidth;
        }

        public void SetPenWidth(double value)
        {
            penWidth = value;
        }

        public Color GetPenColor()
        {
            return pen.Color;
        }

        public void SetPenColor(Color value)
        {
            pen.Color = value;
        }

        public Brush GetBrush1()
        {
            return brush;
        }

        public void SetBrush1(Brush value)
        {
            if (brush != value && brush != null)
            {
                brush.Dispose();
            }
            brush = value;
        }

        public Color GetBrushColor()
        {
            return ((SolidBrush)brush).Color;
        }

        public void SetBrushColor(Color value)
        {
            ((SolidBrush)brush).Color = value;
        }

        public Color GetHitColor()
        {
            return HitBrush.Color;
        }

        public void SetHitColor(Color value)
        {
            HitBrush.Color = value;
        }
        public void SetParent(PartGroup Parent)
    	{
    		parent = Parent;
    	}


    	public void SetBrush(Brush Brush)
    	{
    		brush = Brush;
    	}

    	public void SetDefault()
    	{
    		pen = new Pen(Color.Black, 1f);
    		pen.StartCap = LineCap.Round;
    		pen.EndCap = LineCap.Round;
    		brush = new SolidBrush(Color.LightGray);
    		HitBrush = new SolidBrush(Color.Transparent);
    		Path = new GraphicsPath();
    		OutlinePath = new GraphicsPath();
    		gph = new GraphicsPath();
    	}

    	public ShapePart()
    	{
    		pen.StartCap = LineCap.Round;
    		pen.EndCap = LineCap.Round;
    	}

    	public ShapePart(ShapePart ShapePart)
    	{
    		Copy(ShapePart);
    	}

    	protected void Copy(ShapePart ShapePart)
    	{
    		Tag = ShapePart.Tag;
    		op = new List<CurveOutline>(ShapePart.op.Count);
    		for (int i = 0; i < ShapePart.op.Count; i++)
    		{
    			op.Add(new CurveOutline(ShapePart.op[i]));
    		}
    		jp = new List<JointPoint>(ShapePart.jp.Count);
    		for (int j = 0; j < ShapePart.jp.Count; j++)
    		{
    			jp.Add(new JointPoint(ShapePart.jp[j]));
    		}
    		basePointBase = ShapePart.basePointBase;
    		basePointCont = ShapePart.basePointCont;
    		positionBase = ShapePart.positionBase;
    		positionContO = ShapePart.positionContO;
    		positionCont = ShapePart.positionCont;
    		positionVector = ShapePart.positionVector;
    		anglePare = ShapePart.anglePare;
    		angleBase = ShapePart.angleBase;
    		angleCont = ShapePart.angleCont;
    		sizeBase = ShapePart.sizeBase;
    		sizeCont = ShapePart.sizeCont;
    		xSizeBase = ShapePart.xSizeBase;
    		xSizeCont = ShapePart.xSizeCont;
    		ySizeBase = ShapePart.ySizeBase;
    		ySizeCont = ShapePart.ySizeCont;
    		penWidth = ShapePart.penWidth;
    		Dra = ShapePart.Dra;
    		closed = ShapePart.closed;
    		if (ShapePart.pen != null)
    		{
                SetPen(ShapePart.pen.Copy());
    		}
    		if (ShapePart.brush != null)
    		{
                SetBrush1(ShapePart.brush.Copy());
    		}
    		Hit = ShapePart.Hit;
    		if (ShapePart.HitBrush != null)
    		{
    			HitBrush = (SolidBrush)ShapePart.HitBrush.Copy();
    		}
    	}

    	private void Calculation(double Unit)
    	{
			double us = Unit * (sizeBase * sizeCont * positionSize);
    		double usx = us * (xSizeBase * xSizeCont);
    		double usy = us * (ySizeBase * ySizeCont);

    		Vector2D bp = basePointBase + basePointCont;
    		bp.X *= usx;
    		bp.Y *= usy;

    		Vector2D mv = GetPosition() * Unit - bp;

            double a = System.Math.PI * (anglePare + angleBase + angleCont) / 180.0;

            Path.Reset();
    		OutlinePath.Reset();
    		foreach (CurveOutline item in op)
    		{
    			PointF[] points = new PointF[item.ps.Count];
    			for (int i = 0; i < item.ps.Count; i++)
    			{
					Vector2D p;
    				p.X = item.ps[i].X * usx;
    				p.Y = item.ps[i].Y * usy;
    				p = Rotate(ref p, bp, a) + mv;

    				points[i].X = (float)p.X;
    				points[i].Y = (float)p.Y;
    			}

    			if (closed)
    				Path.AddClosedCurve(points, item.Tension);
    			else
    				Path.AddCurve(points, item.Tension);

    			if (item.Outline)
    			{
    				OutlinePath.StartFigure();

    				if (closed)
    					OutlinePath.AddClosedCurve(points, item.Tension);
    				else
    					OutlinePath.AddCurve(points, item.Tension);
    			}
    		}
    	}

    	private Vector2D Rotate(ref Vector2D p, Vector2D bp, double a)
    	{
			double M11 = System.Math.Cos(a);
            double M12 = System.Math.Sin(a);

            p.X -= bp.X;
    		p.Y -= bp.Y;

			Vector2D v;
    		v.X = p.X * M11 + p.Y * (0.0 - M12);
    		v.Y = p.X * M12 + p.Y * M11;

    		p.X = v.X + bp.X;
    		p.Y = v.Y + bp.Y;

    		return p;
    	}

        public void Draw(double Unit, Graphics Graphics)
        {
            if (Dra)
            {
                Calculation(Unit);
                if (brush != null)
                {
                    Graphics.FillPath(brush, Path);
                }

                if (pen != null)
                {
					pen.Width = (float)(Unit * penWidth * positionSize);
                    Graphics.DrawPath(pen, OutlinePath);
                }
            }
        }

        private void CalculationH(double Unit)
    	{
    		double ush = Unit * (sizeBase * sizeCont * positionSize);
    		double usxh = ush * (xSizeBase * xSizeCont);
    		double usyh = ush * (ySizeBase * ySizeCont);

    		Vector2D bph = basePointBase + basePointCont;
    		bph.X *= usxh;
    		bph.Y *= usyh;

    		Vector2D mvh = GetPosition();
    		mvh.X = mvh.X * Unit - bph.X;
    		mvh.Y = mvh.Y * Unit - bph.Y;
            double ah = System.Math.PI * GetAngle() / 180.0;
    		gph.Reset();
    		if (closed)
    		{
    			foreach (CurveOutline item in op)
    			{
    				PointF[] psh = new PointF[item.ps.Count];
    				for (int i = 0; i < item.ps.Count; i++)
    				{
    					Vector2D ph;
						ph.X = item.ps[i].X * usxh;
    					ph.Y = item.ps[i].Y * usyh;
    					RotateH(ref ph, bph, ah);
    					ph.X += mvh.X;
    					ph.Y += mvh.Y;
    					psh[i].X = (float)ph.X;
    					psh[i].Y = (float)ph.Y;
    				}
    				gph.AddClosedCurve(psh, item.Tension);
    			}
    			return;
    		}

    		foreach (CurveOutline item2 in op)
    		{
    			PointF[] psh = new PointF[item2.ps.Count];
    			for (int j = 0; j < item2.ps.Count; j++)
    			{
    				Vector2D ph;
					ph.X = item2.ps[j].X * usxh;
    				ph.Y = item2.ps[j].Y * usyh;
    				RotateH(ref ph, bph, ah);
    				ph.X += mvh.X;
    				ph.Y += mvh.Y;
    				psh[j].X = (float)ph.X;
    				psh[j].Y = (float)ph.Y;
    			}
    			gph.AddCurve(psh, item2.Tension);
    		}
    	}

    	private void RotateH(ref Vector2D ph, Vector2D bph, double ah)
    	{
			double M11h = System.Math.Cos(ah);
            double M12h = System.Math.Sin(ah);

    		ph.X -= bph.X;
    		ph.Y -= bph.Y;

			Vector2D vh;
    		vh.X = ph.X * M11h + ph.Y * (0.0 - M12h);
    		vh.Y = ph.X * M12h + ph.Y * M11h;

    		ph.X = vh.X + bph.X;
    		ph.Y = vh.Y + bph.Y;
    	}

        public void DrawH(double Unit, Graphics Graphics)
        {
            if (Hit)
            {
                CalculationH(Unit);
                Graphics.FillPath(HitBrush, gph);
            }
        }

        public void SetJointP(int Index, ShapePart ShapePart)
    	{
    		if (Index < jp.Count)
    		{
    			ShapePart.SetPositionBase(ToGlobal(jp[Index].Joint));
    		}
    	}

    	public void SetJointPA(int Index, ShapePart ShapePart)
    	{
    		if (Index < jp.Count)
    		{
    			ShapePart.SetPositionBase(ToGlobal(jp[Index].Joint));
    		}
    		ShapePart.SetAngleParent(anglePare + angleBase + angleCont);
    	}

    	public Vector2D ToGlobal(Vector2D Local)
    	{
    		double size = sizeBase * sizeCont * positionSize;
    		double xsz = size * (xSizeBase * xSizeCont);
    		double ysz = size * (ySizeBase * ySizeCont);
    		Vector2D basePoint = basePointBase + basePointCont;
    		basePoint.X *= xsz;
    		basePoint.Y *= ysz;
    		Vector2D position = GetPosition();
    		position.X -= basePoint.X;
    		position.Y -= basePoint.Y;
    		double d = System.Math.PI * GetAngle() / 180.0;
    		double num3 = System.Math.Cos(d);
    		double num4 = System.Math.Sin(d);
    		double num5 = 0.0 - num4;
    		double num6 = num3;
    		Local.X *= xsz;
    		Local.Y *= ysz;
    		Local.X -= basePoint.X;
    		Local.Y -= basePoint.Y;
    		Vector2D vector2D = default(Vector2D);
    		vector2D.X = Local.X * num3 + Local.Y * num5;
    		vector2D.Y = Local.X * num4 + Local.Y * num6;
    		Local.X = vector2D.X;
    		Local.Y = vector2D.Y;
    		Local.X += basePoint.X;
    		Local.Y += basePoint.Y;
    		Local.X += position.X;
    		Local.Y += position.Y;
    		return Local;
    	}

    	public Vector2D ToGlobal_nc(Vector2D Local)
    	{
    		double size = sizeBase * sizeCont * positionSize;
    		double num = size * (xSizeBase * xSizeCont);
    		double num2 = size * (ySizeBase * ySizeCont);
    		Vector2D basePoint = basePointBase + basePointCont;
    		basePoint.X *= num;
    		basePoint.Y *= num2;
    		Vector2D position_nc = positionBase * positionSize;
    		position_nc.X -= basePoint.X;
    		position_nc.Y -= basePoint.Y;
    		double d = System.Math.PI * (anglePare + angleBase + angleCont) / 180.0;
    		double num3 = System.Math.Cos(d);
    		double num4 = System.Math.Sin(d);
    		double num5 = 0.0 - num4;
    		double num6 = num3;
    		Local.X *= num;
    		Local.Y *= num2;
    		Local.X -= basePoint.X;
    		Local.Y -= basePoint.Y;
    		Vector2D vector2D = default(Vector2D);
    		vector2D.X = Local.X * num3 + Local.Y * num5;
    		vector2D.Y = Local.X * num4 + Local.Y * num6;
    		Local.X = vector2D.X;
    		Local.Y = vector2D.Y;
    		Local.X += basePoint.X;
    		Local.Y += basePoint.Y;
    		Local.X += position_nc.X;
    		Local.Y += position_nc.Y;
    		return Local;
    	}

    	public Vector2D ToLocal(Vector2D Global)
    	{
    		double size = sizeBase * sizeCont * positionSize;
    		double num = size * (xSizeBase * xSizeCont);
    		double num2 = size * (ySizeBase * ySizeCont);
    		Vector2D basePoint = basePointBase + basePointCont;
    		basePoint.X *= num;
    		basePoint.Y *= num2;
    		Vector2D position = GetPosition();
    		position.X = basePoint.X - position.X;
    		position.Y = basePoint.Y - position.Y;
    		num = num.Reciprocal();
    		num2 = num2.Reciprocal();
    		double d = System.Math.PI * (0.0 - (anglePare + angleBase + angleCont)) / 180.0;
    		double num3 = System.Math.Cos(d);
    		double num4 = System.Math.Sin(d);
    		double num5 = 0.0 - num4;
    		double num6 = num3;
    		Global.X += position.X;
    		Global.Y += position.Y;
    		Global.X -= basePoint.X;
    		Global.Y -= basePoint.Y;
    		Vector2D vector2D = default(Vector2D);
    		vector2D.X = Global.X * num3 + Global.Y * num5;
    		vector2D.Y = Global.X * num4 + Global.Y * num6;
    		Global.X = vector2D.X;
    		Global.Y = vector2D.Y;
    		Global.X += basePoint.X;
    		Global.Y += basePoint.Y;
    		Global.X *= num;
    		Global.Y *= num2;
    		return Global;
    	}

    	public bool IsParT()
    	{
    		return this is ShapePartT;
    	}

    	public ShapePartT ToParT()
    	{
    		return (ShapePartT)this;
    	}

    	public List<int> GetPath()
    	{
    		List<int> list = new List<int> { parent.IndexOf(this) };
    		PartGroup pars2 = parent;
    		for (PartGroup pars3 = pars2.Parent; pars3 != null; pars3 = pars2.Parent)
    		{
    			list.Insert(0, pars3.IndexOf(pars2));
    			pars2 = pars3;
    		}
    		return list;
    	}

    	public override string ToString()
    	{
    		return Tag;
    	}

    	public void ReverseX()
    	{
    		op.ReverseX(ref basePointBase);
    		jp.ReverseX(ref basePointBase);
    		angleBase = 360.0 - angleBase;
    		angleCont = 360.0 - angleCont;
    	}

    	public void ReverseY()
    	{
    		op.ReverseY(ref basePointBase);
    		jp.ReverseY(ref basePointBase);
    		angleBase = 360.0 - angleBase;
    		angleCont = 360.0 - angleCont;
    	}

    	public double GetArea()
    	{
    		Vector2D[] array = op.EnumPoints().ToArray();
    		Vector2D vector2D = ToGlobal(array[0]);
    		Vector2D vector2D2 = vector2D;
    		double num = 0.0;
    		for (int i = 1; i < array.Length; i++)
    		{
    			Vector2D vector2D3 = ToGlobal(array[i]);
    			num += vector2D2.X * vector2D3.Y - vector2D3.X * vector2D2.Y;
    			vector2D2 = vector2D3;
    		}
    		num += vector2D2.X * vector2D.Y - vector2D.X * vector2D2.Y;
    		return System.Math.Abs(num * 0.5);
    	}

    	public void Dispose()
    	{
    		if (pen != null)
    		{
    			pen.Dispose();
    		}
    		if (brush != null)
    		{
    			brush.Dispose();
    		}
    		HitBrush.Dispose();
    		Path.Dispose();
    		OutlinePath.Dispose();
    		gph.Dispose();
    	}
    }
}
