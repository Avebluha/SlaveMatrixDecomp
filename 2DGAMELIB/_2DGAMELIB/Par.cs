using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace _2DGAMELIB
{
    //represents a whole or part of a body part :3
    [Serializable]
    public class Par
    {
    	private Pars parent;

    	public string Tag = "";

    	protected List<Out> op = new List<Out>();

    	protected List<Joi> jp = new List<Joi>();

    	protected Vector2D basePointBase = Dat.Vec2DZero;

        //cont short for contract?
        protected Vector2D basePointCont = Dat.Vec2DZero;

    	protected Vector2D positionBase = Dat.Vec2DZero;

    	protected Vector2D positionContO = Dat.Vec2DZero;

    	protected Vector2D positionCont = Dat.Vec2DZero;

    	protected double positionSize = 1.0;

    	protected Vector2D positionVector = Dat.Vec2DZero;

    	protected double anglePare;

    	protected double angleBase;

    	protected double angleCont;

    	protected double sizeBase = 1.0;

    	protected double sizeCont = 1.0;

    	protected double xSizeBase = 1.0;

    	protected double xSizeCont = 1.0;

    	protected double ySizeBase = 1.0;

    	protected double ySizeCont = 1.0;

    	public bool Dra = true;

    	private bool closed;

        [NonSerialized, JsonIgnore]
    	protected Pen pen = new Pen(Color.Black, 1f);

    	protected double penWidth;

    	private bool EditP = true;

        [NonSerialized, JsonIgnore]
    	protected Brush brush = new SolidBrush(Color.LightGray);

    	public bool Hit = true;

        [NonSerialized, JsonIgnore]
    	protected SolidBrush HitBrush = new SolidBrush(Color.Transparent);

    	private double us;

    	private double usx;

    	private double usy;

    	private Vector2D bp;

    	private Vector2D mv;

    	private double angle;

    	private double M11;

    	private double M12;


        [NonSerialized, JsonIgnore]
    	private GraphicsPath Path = new GraphicsPath();

        [NonSerialized, JsonIgnore]
    	private GraphicsPath OutlinePath = new GraphicsPath();

    	private Vector2D p;

    	private Vector2D v;

    	private PointF[] points;

    	protected bool Edit = true;

    	protected bool EditS = true;

    	protected bool EditPS = true;

    	private double ush;

    	private double usxh;

    	private double usyh;

    	private Vector2D bph;

    	private Vector2D mvh;

    	private double ah;

    	private double M11h;

    	private double M12h;

        [NonSerialized, JsonIgnore]
    	private GraphicsPath gph = new GraphicsPath();

    	private Vector2D ph;

    	private Vector2D vh;

    	private PointF[] psh;

    	private bool EditH = true;

    	public Pars Parent => parent;

    	public List<Out> OP
    	{
    		get
    		{
    			Edit = true;
    			EditH = true;
    			return op;
    		}
    		set
    		{
    			op = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public IEnumerable<Out> InitializeOP
    	{
    		set
    		{
    			op.Clear();
    			op.AddRange(value);
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public List<Joi> JP
    	{
    		get
    		{
    			return jp;
    		}
    		set
    		{
    			jp = value;
    		}
    	}

    	public IEnumerable<Joi> InitializeJP
    	{
    		set
    		{
    			jp.Clear();
    			jp.AddRange(value);
    		}
    	}

    	public Vector2D BasePointBase
    	{
    		get
    		{
    			return basePointBase;
    		}
    		set
    		{
    			basePointBase = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public Vector2D BasePointCont
    	{
    		get
    		{
    			return basePointCont;
    		}
    		set
    		{
    			basePointCont = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public Vector2D BasePoint => basePointBase + basePointCont;

    	public Vector2D PositionBase
    	{
    		get
    		{
    			return positionBase;
    		}
    		set
    		{
    			positionBase = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public Vector2D PositionCont
    	{
    		get
    		{
    			return positionContO;
    		}
    		set
    		{
    			positionContO = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public Vector2D Position
    	{
    		get
    		{
    			double d = System.Math.PI * AngleParent / 180.0;
    			double num = System.Math.Cos(d);
    			double num2 = System.Math.Sin(d);
    			positionCont.X = positionContO.X * num + positionContO.Y * (0.0 - num2);
    			positionCont.Y = positionContO.X * num2 + positionContO.Y * num;
    			return (positionBase + positionCont) * positionSize + positionVector;
    		}
    	}

    	public Vector2D Position_nc
    	{
    		get
    		{
    			double d = System.Math.PI * AngleParent / 180.0;
                System.Math.Cos(d);
                System.Math.Sin(d);
    			return positionBase * positionSize + positionVector;
    		}
    	}

    	public double PositionSize
    	{
    		get
    		{
    			return positionSize;
    		}
    		set
    		{
    			positionSize = value;
    			Edit = true;
    			EditH = true;
    			EditPS = true;
    		}
    	}

    	public Vector2D PositionVector
    	{
    		get
    		{
    			return positionVector;
    		}
    		set
    		{
    			positionVector = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public double AngleParent
    	{
    		get
    		{
    			return anglePare;
    		}
    		set
    		{
    			anglePare = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public double AngleBase
    	{
    		get
    		{
    			return angleBase;
    		}
    		set
    		{
    			angleBase = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public double AngleCont
    	{
    		get
    		{
    			return angleCont;
    		}
    		set
    		{
    			angleCont = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public double Angle => anglePare + angleBase + angleCont;

    	public double SizeBase
    	{
    		get
    		{
    			return sizeBase;
    		}
    		set
    		{
    			sizeBase = value;
    			Edit = true;
    			EditH = true;
    			EditS = true;
    		}
    	}

    	public double SizeCont
    	{
    		get
    		{
    			return sizeCont;
    		}
    		set
    		{
    			sizeCont = value;
    			Edit = true;
    			EditH = true;
    			EditS = true;
    		}
    	}

    	public double Size => sizeBase * sizeCont * positionSize;

    	public double SizeXBase
    	{
    		get
    		{
    			return xSizeBase;
    		}
    		set
    		{
    			xSizeBase = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public double SizeXCont
    	{
    		get
    		{
    			return xSizeCont;
    		}
    		set
    		{
    			xSizeCont = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public double SizeX => xSizeBase * xSizeCont;

    	public double SizeYBase
    	{
    		get
    		{
    			return ySizeBase;
    		}
    		set
    		{
    			ySizeBase = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public double SizeYCont
    	{
    		get
    		{
    			return ySizeCont;
    		}
    		set
    		{
    			ySizeCont = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	public double SizeY => ySizeBase * ySizeCont;

    	public bool Closed
    	{
    		get
    		{
    			return closed;
    		}
    		set
    		{
    			closed = value;
    			Edit = true;
    			EditH = true;
    		}
    	}

    	[JsonIgnore]
    	public Pen Pen
    	{
    		get
    		{
    			return pen;
    		}
    		set
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
    			EditP = true;
    		}
    	}

    	public double PenWidth
    	{
    		get
    		{
    			return penWidth;
    		}
    		set
    		{
    			penWidth = value;
    			EditP = true;
    		}
    	}

    	public Color PenColor
    	{
    		get
    		{
    			return pen.Color;
    		}
    		set
    		{
    			pen.Color = value;
    		}
    	}

        [JsonIgnore]
        public Brush Brush
    	{
    		get
    		{
    			return brush;
    		}
    		set
    		{
    			if (brush != value && brush != null)
    			{
    				brush.Dispose();
    			}
    			brush = value;
    		}
    	}

    	public Color BrushColor
    	{
    		get
    		{
    			return ((SolidBrush)brush).Color;
    		}
    		set
    		{
    			((SolidBrush)brush).Color = value;
    		}
    	}

    	public Color HitColor
    	{
    		get
    		{
    			return HitBrush.Color;
    		}
    		set
    		{
    			HitBrush.Color = value;
    		}
    	}
    	public void SetParent(Pars Parent)
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

    	public Par()
    	{
    		pen.StartCap = LineCap.Round;
    		pen.EndCap = LineCap.Round;
    	}

    	public Par(Par Par)
    	{
    		Copy(Par);
    	}

    	protected void Copy(Par Par)
    	{
    		Tag = Par.Tag;
    		op = new List<Out>(Par.op.Count);
    		for (int i = 0; i < Par.op.Count; i++)
    		{
    			op.Add(new Out(Par.op[i]));
    		}
    		jp = new List<Joi>(Par.jp.Count);
    		for (int j = 0; j < Par.jp.Count; j++)
    		{
    			jp.Add(new Joi(Par.jp[j]));
    		}
    		basePointBase = Par.basePointBase;
    		basePointCont = Par.basePointCont;
    		positionBase = Par.positionBase;
    		positionContO = Par.positionContO;
    		positionCont = Par.positionCont;
    		positionSize = Par.positionSize;
    		positionVector = Par.positionVector;
    		anglePare = Par.anglePare;
    		angleBase = Par.angleBase;
    		angleCont = Par.angleCont;
    		sizeBase = Par.sizeBase;
    		sizeCont = Par.sizeCont;
    		xSizeBase = Par.xSizeBase;
    		xSizeCont = Par.xSizeCont;
    		ySizeBase = Par.ySizeBase;
    		ySizeCont = Par.ySizeCont;
    		penWidth = Par.penWidth;
    		Dra = Par.Dra;
    		closed = Par.closed;
    		if (Par.pen != null)
    		{
    			Pen = Par.pen.Copy();
    		}
    		if (Par.brush != null)
    		{
    			Brush = Par.brush.Copy();
    		}
    		Hit = Par.Hit;
    		if (Par.HitBrush != null)
    		{
    			HitBrush = (SolidBrush)Par.HitBrush.Copy();
    		}
    	}

    	private void Calculation(double Unit)
    	{

            /*
    			things that affect where this part is drawn

    			Size, SizeX, SizeY, BasePoint, Position, Angle, Unit

    			Size = sizeBase * sizeCont * positionSize
    			SizeX = xSizeBase * xSizeCont
    			SizeY = ySizeBase * ySizeCont
    			BasePoint = basePointBase + basePointCont
    			Position (AnglePare, positionContO, positionBase, positionCont, positionSize, positionVector)
    			Angle = anglePare + angleBase + angleCont
    			AnglePare = anglePare

    			sizeBase, sizeCont, positionSize, xSizeBase, xSizeCont, ySizeBase, ySizeCont,
    			basePointBase, basePointCont, positionContO, positionBase, positionCont,
    			positionVector, anglePare, angleBase, angleCont
			
    		 */

    		us = Unit * Size;
    		usx = us * SizeX;
    		usy = us * SizeY;

    		bp = BasePoint;
    		bp.X *= usx;
    		bp.Y *= usy;

    		mv = Position * Unit - bp;

    		Path.Reset();
    		OutlinePath.Reset();
    		foreach (Out item in op)
    		{
    			points = new PointF[item.ps.Count];
    			for (int i = 0; i < item.ps.Count; i++)
    			{
    				p.X = item.ps[i].X * usx;
    				p.Y = item.ps[i].Y * usy;
    				p = Rotate(Angle, p) + mv;

    				points[i].X = (float)p.X;
    				points[i].Y = (float)p.Y;
    			}

    			if (Closed)
    				Path.AddClosedCurve(points, item.Tension);
    			else
    				Path.AddCurve(points, item.Tension);

    			if (item.Outline)
    			{
    				OutlinePath.StartFigure();

    				if (Closed)
    					OutlinePath.AddClosedCurve(points, item.Tension);
    				else
    					OutlinePath.AddCurve(points, item.Tension);
    			}
    		}
    	}

    	private Vector2D Rotate(double angle, Vector2D p)
    	{
            double M11 = System.Math.Cos(System.Math.PI * angle / 180.0);
            double M12 = System.Math.Sin(System.Math.PI * angle / 180.0);

            p.X -= bp.X;
    		p.Y -= bp.Y;

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
    			if (Edit)
    			{
    				Calculation(Unit);
    				Edit = false;
    			}
    			if (pen != null && (EditP || EditPS))
    			{
    				pen.Width = (float)(Unit * penWidth * positionSize);
    				EditP = false;
    				EditPS = false;
    			}
    			if (brush != null)
    			{
    				Graphics.FillPath(brush, Path);
    			}
    			if (pen != null)
    			{
    				Graphics.DrawPath(pen, OutlinePath);
    			}
    		}
    	}

    	private void CalculationH(double Unit)
    	{
    		ush = Unit * Size;
    		usxh = ush * SizeX;
    		usyh = ush * SizeY;

    		bph = BasePoint;
    		bph.X *= usxh;
    		bph.Y *= usyh;

    		mvh = Position;
    		mvh.X = mvh.X * Unit - bph.X;
    		mvh.Y = mvh.Y * Unit - bph.Y;
            ah = System.Math.PI * Angle / 180.0;
            M11h = System.Math.Cos(ah);
            M12h = System.Math.Sin(ah);
    		gph.Reset();
    		if (Closed)
    		{
    			foreach (Out item in op)
    			{
    				psh = new PointF[item.ps.Count];
    				for (int i = 0; i < item.ps.Count; i++)
    				{
    					ph.X = item.ps[i].X * usxh;
    					ph.Y = item.ps[i].Y * usyh;
    					RotateH(ref ph);
    					ph.X += mvh.X;
    					ph.Y += mvh.Y;
    					psh[i].X = (float)ph.X;
    					psh[i].Y = (float)ph.Y;
    				}
    				gph.AddClosedCurve(psh, item.Tension);
    			}
    			return;
    		}

    		foreach (Out item2 in op)
    		{
    			psh = new PointF[item2.ps.Count];
    			for (int j = 0; j < item2.ps.Count; j++)
    			{
    				ph.X = item2.ps[j].X * usxh;
    				ph.Y = item2.ps[j].Y * usyh;
    				RotateH(ref ph);
    				ph.X += mvh.X;
    				ph.Y += mvh.Y;
    				psh[j].X = (float)ph.X;
    				psh[j].Y = (float)ph.Y;
    			}
    			gph.AddCurve(psh, item2.Tension);
    		}
    	}

    	private void RotateH(ref Vector2D ph)
    	{
    		ph.X -= bph.X;
    		ph.Y -= bph.Y;

    		vh.X = ph.X * M11h + ph.Y * (0.0 - M12h);
    		vh.Y = ph.X * M12h + ph.Y * M11h;

    		ph.X = vh.X + bph.X;
    		ph.Y = vh.Y + bph.Y;
    	}

    	public void DrawH(double Unit, Graphics Graphics)
    	{
    		if (Hit)
    		{
    			if (EditH)
    			{
    				CalculationH(Unit);
    				EditH = false;
    			}
    			Graphics.FillPath(HitBrush, gph);
    		}
    	}

    	public void SetJointP(int Index, Par Par)
    	{
    		if (Index < jp.Count)
    		{
    			Par.PositionBase = ToGlobal(jp[Index].Joint);
    		}
    		Par.Edit = true;
    		Par.EditH = true;
    	}

    	public void SetJointPA(int Index, Par Par)
    	{
    		if (Index < jp.Count)
    		{
    			Par.PositionBase = ToGlobal(jp[Index].Joint);
    		}
    		Par.AngleParent = Angle;
    		Par.Edit = true;
    		Par.EditH = true;
    	}

    	public Vector2D ToGlobal(Vector2D Local)
    	{
    		double size = Size;
    		double xsz = size * SizeX;
    		double ysz = size * SizeY;
    		Vector2D basePoint = BasePoint;
    		basePoint.X *= xsz;
    		basePoint.Y *= ysz;
    		Vector2D position = Position;
    		position.X -= basePoint.X;
    		position.Y -= basePoint.Y;
    		double d = System.Math.PI * Angle / 180.0;
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
    		double size = Size;
    		double num = size * SizeX;
    		double num2 = size * SizeY;
    		Vector2D basePoint = BasePoint;
    		basePoint.X *= num;
    		basePoint.Y *= num2;
    		Vector2D position_nc = Position_nc;
    		position_nc.X -= basePoint.X;
    		position_nc.Y -= basePoint.Y;
    		double d = System.Math.PI * Angle / 180.0;
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
    		double size = Size;
    		double num = size * SizeX;
    		double num2 = size * SizeY;
    		Vector2D basePoint = BasePoint;
    		basePoint.X *= num;
    		basePoint.Y *= num2;
    		Vector2D position = Position;
    		position.X = basePoint.X - position.X;
    		position.Y = basePoint.Y - position.Y;
    		num = num.Reciprocal();
    		num2 = num2.Reciprocal();
    		double d = System.Math.PI * (0.0 - Angle) / 180.0;
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
    		return this is ParT;
    	}

    	public ParT ToParT()
    	{
    		return (ParT)this;
    	}

    	public List<int> GetPath()
    	{
    		List<int> list = new List<int> { parent.IndexOf(this) };
    		Pars pars2 = parent;
    		for (Pars pars3 = pars2.Parent; pars3 != null; pars3 = pars2.Parent)
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

    	public void ScalingXY(double Scale)
    	{
    		op.ScalingXY(ref basePointBase, Scale);
    		jp.ScalingXY(ref basePointBase, Scale);
    	}

    	public void ScalingX(double Scale)
    	{
    		op.ScalingX(ref basePointBase, Scale);
    		jp.ScalingX(ref basePointBase, Scale);
    	}

    	public void ScalingY(double Scale)
    	{
    		op.ScalingY(ref basePointBase, Scale);
    		jp.ScalingY(ref basePointBase, Scale);
    	}

    	public void ExpansionXY(double Rate)
    	{
    		op.ExpansionXY(ref basePointBase, Rate);
    		jp.ExpansionXY(ref basePointBase, Rate);
    	}

    	public void ExpansionX(double Rate)
    	{
    		op.ExpansionX(ref basePointBase, Rate);
    		jp.ExpansionX(ref basePointBase, Rate);
    	}

    	public void ExpansionY(double Rate)
    	{
    		op.ExpansionY(ref basePointBase, Rate);
    		jp.ExpansionY(ref basePointBase, Rate);
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
