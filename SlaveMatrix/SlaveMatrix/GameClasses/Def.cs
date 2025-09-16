using System;
using System.Collections.Generic;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{

    //race weighting/value information
    public static class Def
    {
    	public static Dictionary<string, RaceInformation> race_information = new Dictionary<string, RaceInformation>
    	{
    		{
    			GameText.サキュバス,
    			new RaceInformation(5, 9, 4, 3, 9)
    		},
    		{
    			GameText.バイコーン,
    			new RaceInformation(7, 6, 5, 5, 8)
    		},
    		{
    			GameText.ドワーフ,
    			new RaceInformation(4, 6, 3, 4, 7)
    		},
    		{
    			GameText.アルラウネ,
    			new RaceInformation(4, 7, 5, 3, 7)
    		},
    		{
    			GameText.スキュラ,
    			new RaceInformation(6, 7, 6, 5, 7)
    		},
    		{
    			GameText.アラクネ,
    			new RaceInformation(4, 4, 6, 5, 7)
    		},
    		{
    			GameText.ユニコーン,
    			new RaceInformation(7, 8, 4, 5, 7)
    		},
    		{
    			GameText.エキドナ,
    			new RaceInformation(7, 4, 6, 6, 7)
    		},
    		{
    			GameText.ムカデジョウロウ,
    			new RaceInformation(4, 4, 7, 6, 7)
    		},
    		{
    			GameText.オールドスキュラ,
    			new RaceInformation(8, 6, 8, 7, 7)
    		},
    		{
    			GameText.ドラゴニュート,
    			new RaceInformation(7, 8, 7, 7, 7)
    		},
    		{
    			GameText.カッパ,
    			new RaceInformation(7, 6, 3, 4, 7)
    		},
    		{
    			GameText.エルフ,
    			new RaceInformation(4, 7, 3, 3, 6)
    		},
    		{
    			GameText.リザードマン,
    			new RaceInformation(4, 5, 5, 4, 6)
    		},
    		{
    			GameText.オーグリス,
    			new RaceInformation(4, 5, 5, 4, 6)
    		},
    		{
    			GameText.デビル,
    			new RaceInformation(4, 5, 4, 4, 6)
    		},
    		{
    			GameText.オールドマーメイド,
    			new RaceInformation(8, 6, 4, 4, 6)
    		},
    		{
    			GameText.ラミア,
    			new RaceInformation(2, 5, 4, 4, 6)
    		},
    		{
    			GameText.シーラミア,
    			new RaceInformation(4, 4, 5, 4, 6)
    		},
    		{
    			GameText.サイクロプス,
    			new RaceInformation(7, 6, 5, 5, 6)
    		},
    		{
    			GameText.ミノタウロス,
    			new RaceInformation(4, 7, 5, 5, 6)
    		},
    		{
    			GameText.エイリアン,
    			new RaceInformation(7, 6, 5, 6, 6)
    		},
    		{
    			GameText.ゴルゴン,
    			new RaceInformation(8, 4, 8, 6, 6)
    		},
    		{
    			GameText.ギルタブリル,
    			new RaceInformation(5, 4, 7, 6, 6)
    		},
    		{
    			GameText.ウロボロス,
    			new RaceInformation(8, 7, 6, 7, 6)
    		},
    		{
    			GameText.フェニックス,
    			new RaceInformation(8, 8, 6, 7, 6)
    		},
    		{
    			GameText.ドラゴン,
    			new RaceInformation(7, 6, 9, 8, 6)
    		},
    		{
    			GameText.リュウ,
    			new RaceInformation(9, 8, 9, 9, 6)
    		},
    		{
    			GameText.リリン,
    			new RaceInformation(3, 5, 3, 3, 5)
    		},
    		{
    			GameText.セイレーン,
    			new RaceInformation(4, 5, 4, 4, 5)
    		},
    		{
    			GameText.ハルピュイア,
    			new RaceInformation(6, 5, 4, 4, 5)
    		},
    		{
    			GameText.オノケンタウレ,
    			new RaceInformation(3, 5, 3, 4, 5)
    		},
    		{
    			GameText.カプラケンタウレ,
    			new RaceInformation(3, 5, 4, 4, 5)
    		},
    		{
    			GameText.チータケンタウレ,
    			new RaceInformation(5, 5, 5, 4, 5)
    		},
    		{
    			GameText.エンジェル,
    			new RaceInformation(6, 7, 4, 4, 5)
    		},
    		{
    			GameText.マーメイド,
    			new RaceInformation(4, 6, 3, 4, 5)
    		},
    		{
    			GameText.ドルフィンマーメイド,
    			new RaceInformation(5, 5, 3, 4, 5)
    		},
    		{
    			GameText.ウェアキャット,
    			new RaceInformation(2, 7, 3, 4, 5)
    		},
    		{
    			GameText.ウェアウルフ,
    			new RaceInformation(2, 7, 4, 4, 5)
    		},
    		{
    			GameText.ウェアフォックス,
    			new RaceInformation(3, 7, 3, 4, 5)
    		},
    		{
    			GameText.ヒュドラ,
    			new RaceInformation(6, 4, 6, 5, 5)
    		},
    		{
    			GameText.クラーケン,
    			new RaceInformation(4, 4, 6, 5, 5)
    		},
    		{
    			GameText.ヒッポケンタウレ,
    			new RaceInformation(4, 5, 5, 5, 5)
    		},
    		{
    			GameText.ブケンタウレ,
    			new RaceInformation(4, 6, 6, 5, 5)
    		},
    		{
    			GameText.レオントケンタウレ,
    			new RaceInformation(4, 6, 6, 5, 5)
    		},
    		{
    			GameText.ティグリスケンタウレ,
    			new RaceInformation(5, 6, 7, 5, 5)
    		},
    		{
    			GameText.パンテーラケンタウレ,
    			new RaceInformation(5, 5, 6, 5, 5)
    		},
    		{
    			GameText.イクテュオケンタウレ,
    			new RaceInformation(5, 5, 5, 5, 5)
    		},
    		{
    			GameText.デルピヌスケンタウレ,
    			new RaceInformation(5, 5, 5, 5, 5)
    		},
    		{
    			GameText.ギルタブルル,
    			new RaceInformation(8, 4, 7, 6, 5)
    		},
    		{
    			GameText.スフィンクス,
    			new RaceInformation(6, 6, 7, 6, 5)
    		},
    		{
    			GameText.ペガサス,
    			new RaceInformation(6, 6, 4, 6, 5)
    		},
    		{
    			GameText.アリコーン,
    			new RaceInformation(8, 6, 5, 6, 5)
    		},
    		{
    			GameText.キマイラ,
    			new RaceInformation(5, 5, 7, 6, 5)
    		},
    		{
    			GameText.グリフォン,
    			new RaceInformation(7, 6, 7, 6, 5)
    		},
    		{
    			GameText.ヒッポグリフ,
    			new RaceInformation(8, 5, 7, 6, 5)
    		},
    		{
    			GameText.モノケロス,
    			new RaceInformation(8, 6, 6, 6, 5)
    		},
    		{
    			GameText.カリュブディス,
    			new RaceInformation(7, 5, 6, 6, 5)
    		},
    		{
    			GameText.ドラコケンタウレ,
    			new RaceInformation(6, 5, 8, 7, 5)
    		},
    		{
    			GameText.カーバンクル,
    			new RaceInformation(9, 8, 1, 1, 4)
    		},
    		{
    			GameText.スライム,
    			new RaceInformation(1, 5, 3, 2, 4)
    		},
    		{
    			GameText.フェアリー,
    			new RaceInformation(7, 7, 2, 3, 4)
    		},
    		{
    			GameText.ハーピー,
    			new RaceInformation(2, 5, 3, 3, 4)
    		},
    		{
    			GameText.アフール,
    			new RaceInformation(3, 4, 3, 3, 4)
    		},
    		{
    			GameText.ウェアマンティス,
    			new RaceInformation(2, 3, 5, 4, 4)
    		},
    		{
    			GameText.ウェアドラゴンフライ,
    			new RaceInformation(2, 3, 5, 4, 4)
    		},
    		{
    			GameText.カトブレパス,
    			new RaceInformation(7, 4, 8, 6, 4)
    		},
    		{
    			GameText.バジリスク,
    			new RaceInformation(7, 4, 8, 6, 4)
    		},
    		{
    			GameText.コカトリス,
    			new RaceInformation(7, 4, 8, 6, 4)
    		},
    		{
    			GameText.ワーム,
    			new RaceInformation(5, 4, 7, 7, 4)
    		},
    		{
    			GameText.ワイバーン,
    			new RaceInformation(6, 5, 8, 7, 4)
    		},
    		{
    			GameText.ウェアビートル,
    			new RaceInformation(3, 3, 5, 5, 3)
    		},
    		{
    			GameText.ウェアスタッグビートル,
    			new RaceInformation(4, 3, 5, 5, 3)
    		},
    		{
    			GameText.サンドワーム,
    			new RaceInformation(3, 3, 7, 6, 3)
    		},
    		{
    			GameText.ヴィオランテ,
    			new RaceInformation(8, 8, 8, 8, 8)
    		},
    		{
    			GameText.ヒューマン,
    			new RaceInformation(3, 4, 3, 4, 4)
    		}
    	};

    	public static double GetRareWeight(this string 種族)
    	{
    		return 1.0 / Math.Pow(race_information[種族].希少 - ((Sta.GameData.祝福 != null && Sta.GameData.祝福.Race == GameText.カーバンクル) ? (race_information[種族].希少 / 2) : 0), 2.0);
    	}

    	public static double GetRutinohWeight(this string ルチノー)
    	{
    		if (string.IsNullOrWhiteSpace(ルチノー))
    		{
    			return 1.0;
    		}
    		if (ルチノー.Contains("000"))
    		{
    			return 10.0;
    		}
    		if (ルチノー.Contains("111"))
    		{
    			return 10.0;
    		}
    		if (ルチノー.Contains("001"))
    		{
    			return 9.0;
    		}
    		if (ルチノー.Contains("100"))
    		{
    			return 9.0;
    		}
    		if (ルチノー.Contains("110"))
    		{
    			return 9.0;
    		}
    		if (ルチノー.Contains("011"))
    		{
    			return 9.0;
    		}
    		if (ルチノー.Contains("010"))
    		{
    			return 9.0;
    		}
    		if (ルチノー.Contains("101"))
    		{
    			return 9.0;
    		}
    		if (ルチノー.Contains("002"))
    		{
    			return 8.0;
    		}
    		if (ルチノー.Contains("200"))
    		{
    			return 8.0;
    		}
    		if (ルチノー.Contains("112"))
    		{
    			return 8.0;
    		}
    		if (ルチノー.Contains("211"))
    		{
    			return 8.0;
    		}
    		if (ルチノー.Contains("020"))
    		{
    			return 8.0;
    		}
    		if (ルチノー.Contains("121"))
    		{
    			return 8.0;
    		}
    		if (ルチノー.Contains("021"))
    		{
    			return 7.0;
    		}
    		if (ルチノー.Contains("120"))
    		{
    			return 7.0;
    		}
    		if (ルチノー.Contains("102"))
    		{
    			return 7.0;
    		}
    		if (ルチノー.Contains("201"))
    		{
    			return 7.0;
    		}
    		if (ルチノー.Contains("012"))
    		{
    			return 7.0;
    		}
    		if (ルチノー.Contains("210"))
    		{
    			return 7.0;
    		}
    		if (ルチノー.Contains("022"))
    		{
    			return 6.0;
    		}
    		if (ルチノー.Contains("220"))
    		{
    			return 6.0;
    		}
    		if (ルチノー.Contains("122"))
    		{
    			return 6.0;
    		}
    		if (ルチノー.Contains("221"))
    		{
    			return 6.0;
    		}
    		if (ルチノー.Contains("202"))
    		{
    			return 6.0;
    		}
    		if (ルチノー.Contains("212"))
    		{
    			return 6.0;
    		}
    		return 1.0;
    	}
    }
}
