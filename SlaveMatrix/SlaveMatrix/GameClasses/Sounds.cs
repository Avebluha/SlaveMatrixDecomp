using System.IO;
using _2DGAMELIB;
using SlaveMatrix.Properties;

namespace SlaveMatrix
{
    public static class Sounds
    {
    	//TODO fix sound
    	//public static _2DGAMELIB.SoundPlayer 日常BGM = new _2DGAMELIB.SoundPlayer(GlobalState.CurrentDirectory + "\\bgm\\game_maoudamashii_5_town10.wav", Loop: true);

    	//public static _2DGAMELIB.SoundPlayer OPBGM = new _2DGAMELIB.SoundPlayer(GlobalState.CurrentDirectory + "\\bgm\\bgm_maoudamashii_neorock60.wav", Loop: true);

    	//public static System.Media.SoundPlayer 操作 = new System.Media.SoundPlayer(new MemoryStream(Resources.se_maoudamashii_system40));

    	//public static System.Media.SoundPlayer 精算 = new System.Media.SoundPlayer(new MemoryStream(Resources.tm2r_coin06));

    	//public static System.Media.SoundPlayer 完了 = new System.Media.SoundPlayer(new MemoryStream(Resources.se_maoudamashii_onepoint12));

    	//public static System.Media.SoundPlayer 鞭撃 = new System.Media.SoundPlayer(new MemoryStream(Resources.teasi_naguru_keru06));

    	//public static System.Media.SoundPlayer 弾け = new System.Media.SoundPlayer(new MemoryStream(Resources.tm2r_crash25r));

    	//public static System.Media.SoundPlayer 撮影 = new System.Media.SoundPlayer(new MemoryStream(Resources.camera_shutter03));

    	//public static System.Media.SoundPlayer 祝福 = new System.Media.SoundPlayer(new MemoryStream(Resources.se_maoudamashii_onepoint09));

    	//public static System.Media.SoundPlayer 解除 = new System.Media.SoundPlayer(new MemoryStream(Resources.se_maoudamashii_onepoint07));

    	//public static System.Media.SoundPlayer 変更1 = new System.Media.SoundPlayer(new MemoryStream(Resources.keyholder));

    	//public static System.Media.SoundPlayer 変更2 = new System.Media.SoundPlayer(new MemoryStream(Resources.keyholder_catchsuru));

    	//public static System.Media.SoundPlayer 変更3 = new System.Media.SoundPlayer(new MemoryStream(Resources.keyholder_nigiru));

    	//public static System.Media.SoundPlayer 射精 = new System.Media.SoundPlayer(new MemoryStream(Resources.sei_ge_nukarumu01));

    	//public static System.Media.SoundPlayer 放尿 = new System.Media.SoundPlayer(new MemoryStream(Resources.near_a_brook_ex));

    	//public static System.Media.SoundPlayer 挿抜口1 = new System.Media.SoundPlayer(new MemoryStream(Resources.hito_ge_goku01));

    	//public static System.Media.SoundPlayer 挿抜口2 = new System.Media.SoundPlayer(new MemoryStream(Resources.hito_ge_goku02));

    	//public static System.Media.SoundPlayer 挿抜前1 = new System.Media.SoundPlayer(new MemoryStream(Resources.nukarumi1));

    	//public static System.Media.SoundPlayer 挿抜前2 = new System.Media.SoundPlayer(new MemoryStream(Resources.nukarumi2));

    	//public static System.Media.SoundPlayer 挿抜前3 = new System.Media.SoundPlayer(new MemoryStream(Resources.nukarumi3));

    	//public static System.Media.SoundPlayer 挿抜前4 = new System.Media.SoundPlayer(new MemoryStream(Resources.nukarumi6));

    	//public static System.Media.SoundPlayer 挿抜後1 = new System.Media.SoundPlayer(new MemoryStream(Resources.hito_ge_onara01));

    	//public static System.Media.SoundPlayer 挿抜後2 = new System.Media.SoundPlayer(new MemoryStream(Resources.hito_ge_haramusi07));

    	//public static System.Media.SoundPlayer 挿抜糸1 = new System.Media.SoundPlayer(new MemoryStream(Resources.nukarumi4));

    	//public static System.Media.SoundPlayer 挿抜糸2 = new System.Media.SoundPlayer(new MemoryStream(Resources.nukarumi5));

    	private static int o = -1;

    	public static void 変更Play()
    	{
    		int num;
    		do
    		{
    			Rng.XS.Next(3, out num);
    		}
    		while (o == num);
    		o = num;
    		switch (num)
    		{
    		case 0:
    			//変更1.Play();
    			break;
    		case 1:
    			//変更2.Play();
    			break;
    		case 2:
    			//変更3.Play();
    			break;
    		}
    	}

    	public static void Close()
    	{
    		/*
    		日常BGM.Stop();
    		日常BGM.Close();
    		OPBGM.Stop();
    		OPBGM.Close();
    		操作.Stop();
    		操作.Dispose();
    		精算.Stop();
    		精算.Dispose();
    		完了.Stop();
    		完了.Dispose();
    		鞭撃.Stop();
    		鞭撃.Dispose();
    		弾け.Stop();
    		弾け.Dispose();
    		撮影.Stop();
    		撮影.Dispose();
    		祝福.Stop();
    		祝福.Dispose();
    		解除.Stop();
    		解除.Dispose();
    		変更1.Stop();
    		変更1.Dispose();
    		変更2.Stop();
    		変更2.Dispose();
    		変更3.Stop();
    		変更3.Dispose();
    		射精.Stop();
    		射精.Dispose();
    		放尿.Stop();
    		放尿.Dispose();
    		挿抜口1.Stop();
    		挿抜口1.Dispose();
    		挿抜口2.Stop();
    		挿抜口2.Dispose();
    		挿抜前1.Stop();
    		挿抜前1.Dispose();
    		挿抜前2.Stop();
    		挿抜前2.Dispose();
    		挿抜前3.Stop();
    		挿抜前3.Dispose();
    		挿抜前4.Stop();
    		挿抜前4.Dispose();
    		挿抜後1.Stop();
    		挿抜後1.Dispose();
    		挿抜後2.Stop();
    		挿抜後2.Dispose();
    		挿抜糸1.Stop();
    		挿抜糸1.Dispose();
    		挿抜糸2.Stop();
    		挿抜糸2.Dispose();
    		*/
    	}
    }
}
