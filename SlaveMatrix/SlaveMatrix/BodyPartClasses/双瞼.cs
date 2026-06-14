using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class 双瞼 : Element
    {
    	public override double 肥大
    	{
    		set
    		{
    		}
    	}

    	public override double 身長
    	{
    		set
    		{
    		}
    	}

    	public double 傾き
    	{
    		set
    		{
    			double num = (右 ? (-1.0) : 1.0);
    			double num2 = -10.0 + 18.5 * value;
    			角度B = num * num2;
    		}
    	}
    }
}
