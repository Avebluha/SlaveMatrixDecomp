using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 処理B
    {
    	public TrainingUI 調教UI;

    	public ModeEventDispatcher Med;

    	public RenderArea Are;

    	public Character Cha;

    	public Body Bod;

    	public InfoPanel ip;

    	public CharacterElement 対象;

    	public const int MaxLv = 3;

    	public int 強さ = 1;

    	public bool 選択;

    	public double 強度 => (double)強さ / 3.0;

    	public 処理B(TrainingUI 調教UI)
    	{
    		this.調教UI = 調教UI;
    		Med = 調教UI.Med;
    		Are = 調教UI.Are;
    		ip = 調教UI.ip;
    	}

    	public 処理B(TrainingUI 調教UI, CharacterElement 対象)
    	{
    		this.調教UI = 調教UI;
    		Med = 調教UI.Med;
    		Are = 調教UI.Are;
    		ip = 調教UI.ip;
    		this.対象 = 対象;
    	}

    	public void Reset()
    	{
    		強さ = 1;
    		選択 = false;
    	}
    }
}
