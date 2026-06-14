using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class 顔面 : Element
    {
    	private double 展開;

    	public Element[] 触覚左_接続;

    	public Element[] 触覚右_接続;

    	public double 展開0
    	{
    		get
    		{
    			return 展開;
    		}
    		set
    		{
    			展開 = value;
    			位置C = new Vector2D(位置C.X, -0.013 * value);
    			尺度YC = 1.0 - 0.05 * value;
    		}
    	}

    	public virtual double 展開1 { get; set; }
    }
}
