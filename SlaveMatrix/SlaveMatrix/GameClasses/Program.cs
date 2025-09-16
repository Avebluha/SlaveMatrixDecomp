using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    internal static class Program
    {

    	[STAThread]
    	private static void Main(string[] A_0)
    	{

            Sta.LoadConfig();

            double percent = 35.0;
            if (Sta.BigWindow)
            {
                percent = 47.0;
            }

            Med med = new Med
    		{
    			UITitle = GameText.スレイブマトリクス,
    			Unit = Sta.HighQuality ? 2203.0 : 1101.5,
    			ShowFPS = Sta.ShowFPS,
    			Base = new Rect(4.0, 3.0, percent / 100.0),
                DisQuality = 1.0,
    			HitAccuracy = 0.3
            };

    		med.InitializeModes("Start", Mods.GetMods);
    		UI uI = new UI(med);

    		//main loop
    		med.Drawing();
    	}
    }
}
