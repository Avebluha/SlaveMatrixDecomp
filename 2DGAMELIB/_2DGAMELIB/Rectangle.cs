namespace _2DGAMELIB
{
    public class Rectangle
    {
    	public double XRatio = 1.0;

    	public double YRatio = 1.0;

    	public double Size = 1.0;

    	public double LocalWidth => XRatio * Size;

    	public double LocalHeight => YRatio * Size;

    	public Vector2D LocalCenter => new Vector2D(LocalWidth * 0.5, LocalHeight * 0.5);

    	public Rectangle(){}

    	public Rectangle(double XRatio, double YRatio, double Size)
    	{
    		SetXYRatio(XRatio, YRatio);
    		this.Size = Size;
    	}

    	public void SetXYRatio(double X, double Y)
    	{
    		XRatio = X / Y;
    		YRatio = 1.0;
    	}

    	public Vector2D GetPosition(double X, double Y)
    	{
    		return new Vector2D(LocalWidth * X, LocalHeight * Y);
    	}

    	public Vector2D GetPosition(Vector2D p)
    	{
    		return new Vector2D(LocalWidth * p.X, LocalHeight * p.Y);
    	}

    	public Vector2D GetPosition(ref Vector2D p)
    	{
    		return new Vector2D(LocalWidth * p.X, LocalHeight * p.Y);
    	}
    }
}
