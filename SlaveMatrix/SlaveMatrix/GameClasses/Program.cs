using System;
using System.Reflection;
using _2DGAMELIB;

namespace SlaveMatrix.GameClasses
{
    internal static class Program
    {
        static Program()
        {
            AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);
            RemappedTypeBinder.RegisterMapping("SlaveMatrix.Ele", typeof(Element));
            RemappedTypeBinder.RegisterMapping("SlaveMatrix.EleD", typeof(ElementData));
            RemappedTypeBinder.RegisterMapping("SlaveMatrix.EleI", typeof(ElementInstance));
        }

    	[STAThread]
    	private static void Main(string[] A_0)
    	{
            GlobalState.LoadConfig();

            double percent = 35.0;
            if (GlobalState.BigWindow)
            {
                percent = 47.0;
            }

            ModeEventDispatcher med = new ModeEventDispatcher
    		{
    			UITitle = GameText.SlaveMatrix, //sureibumatorikusu
    			Unit = GlobalState.HighQuality ? 2203.0 : 1101.5,
    			ShowFPS = GlobalState.ShowFPS,
    			Base = new Rectangle(4.0, 3.0, percent / 100.0),
                DisQuality = 1.0,
    			HitAccuracy = 0.3
            };

    		med.InitializeModes("Start", ModuleRegistry.GetMods);
    		UI uI = new UI(med);

    		//main loop
    		med.Drawing();
    	}
    }
}
