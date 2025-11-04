using _2DGAMELIB;

namespace SlaveMatrix
{
    public class SlaveText
    {
    	private ModeEventDispatcher Med;

    	private TextBubble hd;

    	public SlaveText(ModeEventDispatcher Med, TextBubble hd)
    	{
    		this.Med = Med;
    		this.hd = hd;
    	}

    	public void Set()
    	{
    		string text = "";
    		text = hd.Text;
    		hd.Text = text;
    	}

    	public void Set状態()
    	{
    		string 点6ハート = GameText.点6ハート;
    		hd.Text = 点6ハート;
    	}
    }
}
