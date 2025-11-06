using _2DGAMELIB;

namespace SlaveMatrix
{
    public class ViolaText
    {
    	private ModeEventDispatcher Med;

    	private TextBubble hd;

    	public ViolaText(ModeEventDispatcher Med, TextBubble hd)
    	{
    		this.Med = Med;
    		this.hd = hd;
    	}

    	public void Set()
    	{
    		string text = "";
    		string mode = Med.Mode;
    		if (mode == "Office")
    		{
    			text = ((!Sta.GameData.初事務所フラグ) ? GameText.今日はどうしたの : GameText.いらっしゃい待っていたわ);
    		}
    		else if (mode == "Debt")
    		{
    			text = GameText.今日借りれる金額はあと + Sta.GameData.日借金可能額.ToString("#,0") + GameText.よ;
    		}
    		hd.Text = text;
    	}
    }
}
