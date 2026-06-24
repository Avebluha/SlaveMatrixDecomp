using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class GameState
    {
    	public Unit ヴィオラ;

    	public double 利子 = 0.002;

    	public ulong 日借金額;

    	public double 身長 = 0.5;

    	public double 体重 = 0.5;

    	public 主人公色 色 = new 主人公色();

    	public 主人公配色 配色;

    	public double 精力 = 1.0;

    	public double 射精;

    	public double 興奮;

    	public double 調教力;

    	public Unit プレーヤー;

    	public ulong 時間;

    	public ulong 所持金;

    	public ulong 借金;

    	public Dictionary<string, double> 需給;

    	public int RepaymentStage;

    	public Unit TrainingTarget;

    	public Unit[] Slaves = new Unit[ModuleRegistry.MaxRoomNumber];

    	public Unit 祝福;

    	public bool[] 系統開放 = new bool[9] { true, true, false, false, false, false, false, false, false };

    	public bool[] PurchasedTools = new bool[14];

    	public bool 初事務所フラグ = true;

    	private const int Capacity = 3;

    	public Generator[] Gen = new Generator[9];

    	public bool Refresh;

    	public int フロア数 = 1;

    	public bool 拘束具;

    	public bool Blindfold;

    	public bool BallGag;

    	public bool XRay;

    	public bool ガイド = true;

    	public bool 心眼;

    	public bool 媚薬;

    	public bool 施術;

    	public bool 淫紋;

    	public bool 衣装;

    	public bool ヴィオラ服;

    	public bool 新日;

    	public ulong 日借金可能額 => 50000000 - 日借金額;

    	public ulong 利子額 => (ulong)((double)借金 * 利子).RoundDown(0);

    	public string 時間帯
    	{
    		get
    		{
    			ulong num = 時間 % 3;
    			if (num <= 2)
    			{
    				switch (num)
    				{
    				case 0uL:
    					return GameText.朝;
    				case 1uL:
    					return GameText.昼;
    				case 2uL:
    					return GameText.夜;
    				}
    			}
    			return "";
    		}
    	}

    	public ulong 日数 => 時間 / 3;

    	public Generator 鳥系 => Gen[0];

    	public Generator 蛇系 => Gen[1];

    	public Generator 獣系 => Gen[2];

    	public Generator 水系 => Gen[3];

    	public Generator 虫系 => Gen[4];

    	public Generator 人型 => Gen[5];

    	public Generator 幻獣 => Gen[6];

    	public Generator 魔獣 => Gen[7];

    	public Generator 竜系 => Gen[8];

    	public void 時間進行()
    	{
    		時間++;
    	}

    	public string GetSaveDateString()
    	{
    		return 日数 + GameText.日目 + "/" + 時間帯;
    	}

    	public bool Is地下室一杯()
    	{
    		return !Slaves.Take(ModuleRegistry.MaxRoomNumber / 9 * フロア数).Any((Unit e) => e == null);
    	}

    	public void Add地下室(Unit Unit)
    	{
    		for (int i = 0; i < Slaves.Length; i++)
    		{
    			if (Slaves[i] == null)
    			{
    				Slaves[i] = Unit;
    				break;
    			}
    		}
    		if (GlobalState.AutoSort)
    		{
    			Array.Sort(Slaves, (Unit e1, Unit e2) => (e1 != null) ? ((e2 != null) ? e1.Race.CompareTo(e2.Race) : int.MinValue) : int.MaxValue);
    		}
    		for (int j = 0; j < Slaves.Length; j++)
    		{
    			if (Slaves[j] != null)
    			{
    				Unit unit = Slaves[j];
    				unit.階層位置 = j / 15;
    				unit.RoomNumber = j % 15;
    				unit.Number = (j + 1).ToString().PadLeft(3, '0');
    				Slaves[j] = unit;
    			}
    		}
    	}

    	public void GenRefresh()
    	{
    		Refresh = true;
    		/*
    		Parallel.ForEach(Gen, GlobalState.po3, delegate(Generator g)
    		{
    			g.Refresh(3);
    		});*/

    		foreach (Generator g in Gen)
    			g.Refresh(3);
    		Refresh = false;
    	}

    	public void GenInstance()
    	{
    		Refresh = true;
    		for (int i = 0; i < Gen.Length; i++)
    		{
    			Gen[i] = new Generator(3, (GeneratorType)i);
    		}
    		Refresh = false;
    	}

    	public string GetPriceInfo(out ulong s)
    	{
    		s = 0uL;
    		Unit[] array = Slaves;
    		foreach (Unit unit in array)
    		{
    			if (unit != null && !unit.保守)
    			{
    				s += unit.GetPrice();
    			}
    		}
    		return "\r\n" + GameText.合計売却額 + " +" + s.ToString("#,0");
    	}

    	public void 地下室詰め()
    	{
    		Unit[] array = Slaves.Where((Unit e) => e != null).ToArray();
    		for (int i = 0; i < ModuleRegistry.MaxRoomNumber; i++)
    		{
    			if (array.Length > i)
    			{
    				array[i].階層位置 = i / 15;
    				array[i].RoomNumber = i % 15;
    				array[i].Number = (i + 1).ToString().PadLeft(3, '0');
    				Slaves[i] = array[i];
    			}
    			else
    			{
    				Slaves[i] = null;
    			}
    		}
    	}

    	public GameState()
    	{
    		配色 = new 主人公配色(色);
    	}

    	public void SetDefault()
    	{
    		ヴィオラ = null;
    		利子 = 0.002;
    		日借金額 = 0uL;
    		身長 = 0.5;
    		体重 = 0.5;
    		色 = new 主人公色();
    		配色 = new 主人公配色(色);
    		精力 = 1.0;
    		射精 = 0.0;
    		興奮 = 0.0;
    		調教力 = 0.0;
    		時間 = 0uL;
    		所持金 = 0uL;
    		借金 = 0uL;
    		需給初期化();
    		RepaymentStage = 0;
    		TrainingTarget = null;
    		Slaves = new Unit[ModuleRegistry.MaxRoomNumber];
    		祝福 = null;
    		系統開放 = new bool[9] { true, true, false, false, false, false, false, false, false };
    		PurchasedTools = new bool[14];
    		初事務所フラグ = true;

    		GenInstance();

    		フロア数 = 1;
    		拘束具 = false;
    		Blindfold = false;
    		BallGag = false;
    		XRay = false;
    		ガイド = true;
    		心眼 = false;
    		媚薬 = false;
    		施術 = false;
    		淫紋 = false;
    		衣装 = false;
    		ヴィオラ服 = false;
    		新日 = false;
    	}

    	public void 需給初期化()
    	{
    		需給 = new Dictionary<string, double>
    		{
    			{
    				GameText.サキュバス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.バイコーン,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ドワーフ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.アルラウネ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.スキュラ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.アラクネ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ユニコーン,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.エキドナ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ムカデジョウロウ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.オールドスキュラ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ドラゴニュート,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.カッパ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.エルフ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.リザードマン,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.オーグリス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.デビル,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.オールドマーメイド,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ラミア,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.シーラミア,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.サイクロプス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ミノタウロス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.エイリアン,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ゴルゴン,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ギルタブリル,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ウロボロス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.フェニックス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ドラゴン,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.リュウ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.リリン,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.セイレーン,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ハルピュイア,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.オノケンタウレ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.カプラケンタウレ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.チータケンタウレ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.エンジェル,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.マーメイド,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ドルフィンマーメイド,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ウェアキャット,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ウェアウルフ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ウェアフォックス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ヒュドラ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.クラーケン,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ヒッポケンタウレ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ブケンタウレ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.レオントケンタウレ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ティグリスケンタウレ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.パンテーラケンタウレ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.イクテュオケンタウレ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.デルピヌスケンタウレ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ギルタブルル,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.スフィンクス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ペガサス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.アリコーン,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.キマイラ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.グリフォン,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ヒッポグリフ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.モノケロス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.カリュブディス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ドラコケンタウレ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.カーバンクル,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.スライム,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.フェアリー,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ハーピー,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.アフール,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ウェアマンティス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ウェアドラゴンフライ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.カトブレパス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.バジリスク,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.コカトリス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ワーム,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ワイバーン,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ウェアビートル,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ウェアスタッグビートル,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.サンドワーム,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ヴィオランテ,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ヒューマン,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			},
    			{
    				GameText.ミックス,
    				NextNormal(Rng.XS, ModuleRegistry.DemandMax)
    			}
    		};
    	}

    	public void 需給更新()
    	{
    		string[] array = GlobalState.GameData.需給.Keys.ToArray();
    		foreach (string key in array)
    		{
    			GlobalState.GameData.需給[key] = NextNormal(Rng.XS, ModuleRegistry.DemandMax);
    		}
    	}

    	private double NextNormal(MyRandom r, double mr)
    	{
    		double num = mr * 0.5 * r.NextNorCos();
    		if (!(num > 0.0))
    		{
    			if (!(num < 0.0))
    			{
    				return 1.0;
    			}
    			return 0.0 - 1.0 / num;
    		}
    		return num;
    	}
    }
}
