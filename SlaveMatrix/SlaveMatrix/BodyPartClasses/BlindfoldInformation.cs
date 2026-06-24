using System;

namespace SlaveMatrix
{
    [Serializable]
    public struct BlindfoldInformation
    {
    	public bool 革_表示;

    	public bool 丸金具上中_表示;

    	public bool 丸金具上左1_表示;

    	public bool 丸金具上左2_表示;

    	public bool 丸金具上左3_表示;

    	public bool 丸金具上左4_表示;

    	public bool 丸金具上左5_表示;

    	public bool 丸金具上右1_表示;

    	public bool 丸金具上右2_表示;

    	public bool 丸金具上右3_表示;

    	public bool 丸金具上右4_表示;

    	public bool 丸金具上右5_表示;

    	public bool 丸金具下左1_表示;

    	public bool 丸金具下左2_表示;

    	public bool 丸金具下左3_表示;

    	public bool 丸金具下左4_表示;

    	public bool 丸金具下左5_表示;

    	public bool 丸金具下右1_表示;

    	public bool 丸金具下右2_表示;

    	public bool 丸金具下右3_表示;

    	public bool 丸金具下右4_表示;

    	public bool 丸金具下右5_表示;

    	public 拘束具色 色;

    	public void SetDefault()
    	{
    		革_表示 = true;
    		丸金具上中_表示 = true;
    		丸金具上左1_表示 = true;
    		丸金具上左2_表示 = true;
    		丸金具上左3_表示 = true;
    		丸金具上左4_表示 = true;
    		丸金具上左5_表示 = true;
    		丸金具上右1_表示 = true;
    		丸金具上右2_表示 = true;
    		丸金具上右3_表示 = true;
    		丸金具上右4_表示 = true;
    		丸金具上右5_表示 = true;
    		丸金具下左1_表示 = true;
    		丸金具下左2_表示 = true;
    		丸金具下左3_表示 = true;
    		丸金具下左4_表示 = true;
    		丸金具下左5_表示 = true;
    		丸金具下右1_表示 = true;
    		丸金具下右2_表示 = true;
    		丸金具下右3_表示 = true;
    		丸金具下右4_表示 = true;
    		丸金具下右5_表示 = true;
    		色.SetDefault();
    	}

    	public static BlindfoldInformation GetDefault()
    	{
    		BlindfoldInformation result = default(BlindfoldInformation);
    		result.SetDefault();
    		return result;
    	}
    }
}
