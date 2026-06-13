using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 調教背景
    {
    	private const int X = 10;

    	private const int Y = 10;

    	private static int L = 100;

    	private const double s = 0.7;

    	private double[] Yv = new double[L];

    	private double[] An = new double[L];

    	private static int c = 0;

    	private static int x;

    	private static int y;

    	private static double r = 0.147;

    	private static Vector2D o = new Vector2D(0.053 - 0.055 * RNG.XS.NextDouble(), 0.07 - 0.0735 * RNG.XS.NextDouble());

    	public 調教背景()
    	{
    		Reset();
    	}

    	public void Reset()
    	{
    		for (int i = 0; i < L; i++)
    		{
    			Yv[i] = RNG.XS.NextDouble();
    			An[i] = (double)RNG.XS.Next(4) * 90.0;
    		}
    	}

    	public void Draw(RenderArea Are)
    	{
    		c = 0;
    		for (y = 0; y < 10; y++)
    		{
    			for (x = 0; x < 10; x++)
    			{
    				Sta.タイル.SizeBase = 0.7;
    				Sta.タイル.JoinRoot.ValueY = Yv[c];
    				Sta.タイル.AngleBase = An[c];
    				Sta.タイル.JoinRoot.GetCurJoinRoot().SetPositionBase(Are.GetPosition(new Vector2D(o.X + (double)x * r / Are.XRatio, o.Y + (double)y * r / Are.YRatio)));
    				Sta.タイル.JoinPA();
    				Sta.タイル.Draw(Are);
    				c++;
    			}
    		}
    	}
    }
}
