using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{

    public enum GeneratorType
    {
        Bird,
        Snake,
        Beast,
        Aquatic,
        Insect,
        Humanoid,
        幻獣,
        魔獣,
        Dragon
    }


    //shop slave generator
    [Serializable]
    public class Generator
    {
    	public List<Unit> Buf = new List<Unit>();

    	private int i;

    	protected int Capacity;

    	protected GeneratorType 系統;

    	public int Count => Buf.Count;

    	public Generator(int Capacity, GeneratorType genType)
    	{
    		this.Capacity = Capacity;
    		this.系統 = genType;
    		Refresh();
    	}

        public Unit gen()
        {
            switch (系統)
            {
                case GeneratorType.Bird:
                    return GetBird();
                case GeneratorType.Snake:
                    return GetSnake();
                case GeneratorType.Beast:
                    return GetBeast();
                case GeneratorType.Aquatic:
                    return GetAquatic();
                case GeneratorType.Insect:
                    return GetInsect();
                case GeneratorType.Humanoid:
                    return GetHumanoid();
                case GeneratorType.幻獣:
                    return Get幻獣();
                case GeneratorType.魔獣:
                    return Get魔獣();
                case GeneratorType.Dragon:
                    return GetDragon();
            }

            return GetHumanoid();
        }

        private static Unit Generate(CharacterData ChaD1, CharacterData ChaD2, int 妊娠進行期間, string 種族)
    	{
    		妊娠進行期間 = (int)((double)妊娠進行期間 * 0.5).Clamp(0.0, 5.0);
    		Unit unit = GetUnit(ChaD1, 妊娠進行期間, 種族).Mix(GetUnit(ChaD2, 妊娠進行期間, 種族), 原種モード: true);
    		unit.Virgin = false;
    		if (種族 != GameText.バイコーン)
    		{
    			unit.Virgin = 種族 == GameText.ユニコーン || 種族 == GameText.モノケロス || 0.3.Lot();
    		}
    		if (!(種族 == GameText.スライム) && !(種族 == GameText.フェニックス) && !(種族 == GameText.ウロボロス))
    		{
    			unit.Scars = 0.05.Lot();
    		}
    		return unit;
    	}

    	private static Unit GetUnit(CharacterData ChaD, int 妊娠進行期間, string 種族)
    	{
    		Unit unit = new Unit();
    		unit.ChaD = ChaD;
    		unit.Race = 種族;
    		unit.Name = 種族;
    		unit.妊娠進行期間 = 妊娠進行期間;
    		RaceInformation 種族情報2 = RacialDefinitions.race_information[種族];
    		unit.種族情報 = new RaceInformation(種族情報2.希少, 種族情報2.需要, 種族情報2.危険, ((int)((double)(種族情報2.一般 + 1) * unit.ChaD.固有値)).Clamp(1, 9), ((int)((double)(種族情報2.娼婦 + 1) * unit.ChaD.固有値)).Clamp(1, 9));
    		unit.Set原種素質();
    		unit.Set種族特性();
    		unit.Set構成特性();
    		unit.Price = (ulong)((double)unit.GetPrice() * ((Sta.GameData.祝福 == Sta.GameData.ヴィオラ) ? 0.6 : 1.0));
    		return unit;
    	}

    	public static Unit 娼婦労働妊娠父方()
    	{
    		switch (GeometryUtils.GetRandomIndex(7.0, 5.0, 3.0, 1.0))
    		{
    		case 0:
    			return Generate(SpeciesDefaults.Getヒューマン(), SpeciesDefaults.Getヒューマン(), 2, GameText.ヒューマン);
    		case 1:
    		{
    			bool b = RNG.XS.NextBool();
    			return Generate(SpeciesDefaults.Getオーグリス(b), SpeciesDefaults.Getオーグリス(b), 2, GameText.オーグリス);
    		}
    		case 2:
    			return Generate(SpeciesDefaults.Getドワーフ(), SpeciesDefaults.Getドワーフ(), 2, GameText.ドワーフ);
    		case 3:
    			return Generate(SpeciesDefaults.Getサイクロプス(), SpeciesDefaults.Getサイクロプス(), 2, GameText.サイクロプス);
    		default:
    			return null;
    		}
    	}

    	public static Unit プレーヤー()
    	{
    		Unit unit = new Unit();
    		unit.ChaD = SpeciesDefaults.Getプレーヤー();
    		unit.Race = GameText.ヒューマン;
    		unit.Name = unit.Race;
    		unit.妊娠進行期間 = 2;
    		unit.種族情報 = RacialDefinitions.race_information[unit.Race];
    		腰肌D eleD = unit.ChaD.body_tree.肌_接続.GetEleD<腰肌D>();
    		unit.Hairless = (!eleD.陰毛_表示 && !eleD.獣性_獣毛_表示) || unit.ChaD.最陰毛濃度 == 0.0;
    		unit.Mother = unit;
    		unit.Father = unit;
    		return unit;
    	}

    	protected Unit GetBird()
    	{
    		return GeometryUtils.GetRandomIndex(GameText.ハーピー.GetRareWeight(), GameText.ハルピュイア.GetRareWeight(), GameText.フェニックス.GetRareWeight()) switch
    		{
    			0 => Generate(SpeciesDefaults.GetHarpy(), SpeciesDefaults.GetHarpy(), 2, GameText.ハーピー), 
    			1 => Generate(SpeciesDefaults.Getハルピュイア(), SpeciesDefaults.Getハルピュイア(), 2, GameText.ハルピュイア), 
    			2 => Generate(SpeciesDefaults.GetPhoenix(), SpeciesDefaults.GetPhoenix(), 4, GameText.フェニックス), 
    			_ => null, 
    		};
    	}

    	protected Unit GetSnake()
    	{
    		return GeometryUtils.GetRandomIndex(GameText.ラミア.GetRareWeight(), GameText.ヒュドラ.GetRareWeight(), GameText.エキドナ.GetRareWeight(), GameText.ウロボロス.GetRareWeight()) switch
    		{
    			0 => Generate(SpeciesDefaults.Getラミア(), SpeciesDefaults.Getラミア(), 2, GameText.ラミア), 
    			1 => Generate(SpeciesDefaults.Getヒュドラ(), SpeciesDefaults.Getヒュドラ(), 3, GameText.ヒュドラ), 
    			2 => Generate(SpeciesDefaults.Getエキドナ(), SpeciesDefaults.Getエキドナ(), 3, GameText.エキドナ), 
    			3 => Generate(SpeciesDefaults.Getウロボロス(), SpeciesDefaults.Getウロボロス(), 4, GameText.ウロボロス), 
    			_ => null, 
    		};
    	}

    	protected Unit GetBeast()
    	{
    		return GeometryUtils.GetRandomIndex(GameText.ウェアキャット.GetRareWeight(), GameText.ウェアウルフ.GetRareWeight(), GameText.ウェアフォックス.GetRareWeight(), GameText.ミノタウロス.GetRareWeight(), GameText.アフール.GetRareWeight(), GameText.オノケンタウレ.GetRareWeight(), GameText.ヒッポケンタウレ.GetRareWeight(), GameText.ブケンタウレ.GetRareWeight(), GameText.カプラケンタウレ.GetRareWeight(), GameText.レオントケンタウレ.GetRareWeight(), GameText.ティグリスケンタウレ.GetRareWeight(), GameText.パンテーラケンタウレ.GetRareWeight(), GameText.チータケンタウレ.GetRareWeight()) switch
    		{
    			0 => Generate(SpeciesDefaults.Getウェアキャット(), SpeciesDefaults.Getウェアキャット(), 2, GameText.ウェアキャット), 
    			1 => Generate(SpeciesDefaults.Getウェアウルフ(), SpeciesDefaults.Getウェアウルフ(), 2, GameText.ウェアウルフ), 
    			2 => Generate(SpeciesDefaults.Getウェアフォックス(), SpeciesDefaults.Getウェアフォックス(), 2, GameText.ウェアフォックス), 
    			3 => Generate(SpeciesDefaults.Getミノタウロス(), SpeciesDefaults.Getミノタウロス(), 2, GameText.ミノタウロス), 
    			4 => Generate(SpeciesDefaults.Getアフール(), SpeciesDefaults.Getアフール(), 2, GameText.アフール), 
    			5 => Generate(SpeciesDefaults.Getオノケンタウレ(), SpeciesDefaults.Getオノケンタウレ(), 2, GameText.オノケンタウレ), 
    			6 => Generate(SpeciesDefaults.Getヒッポケンタウレ(), SpeciesDefaults.Getヒッポケンタウレ(), 3, GameText.ヒッポケンタウレ), 
    			7 => Generate(SpeciesDefaults.Getブケンタウレ(), SpeciesDefaults.Getブケンタウレ(), 3, GameText.ブケンタウレ), 
    			8 => Generate(SpeciesDefaults.Getカプラケンタウレ(), SpeciesDefaults.Getカプラケンタウレ(), 3, GameText.カプラケンタウレ), 
    			9 => Generate(SpeciesDefaults.Getレオントケンタウレ(), SpeciesDefaults.Getレオントケンタウレ(), 3, GameText.レオントケンタウレ), 
    			10 => Generate(SpeciesDefaults.Getティグリスケンタウレ(), SpeciesDefaults.Getティグリスケンタウレ(), 3, GameText.ティグリスケンタウレ), 
    			11 => Generate(SpeciesDefaults.Getパンテーラケンタウレ(), SpeciesDefaults.Getパンテーラケンタウレ(), 3, GameText.パンテーラケンタウレ), 
    			12 => Generate(SpeciesDefaults.Getチータケンタウレ(), SpeciesDefaults.Getチータケンタウレ(), 3, GameText.チータケンタウレ), 
    			_ => null, 
    		};
    	}

    	protected Unit GetAquatic()
    	{
    		switch (GeometryUtils.GetRandomIndex(GameText.カッパ.GetRareWeight(), GameText.マーメイド.GetRareWeight(), GameText.オールドマーメイド.GetRareWeight(), GameText.ドルフィンマーメイド.GetRareWeight(), GameText.イクテュオケンタウレ.GetRareWeight(), GameText.デルピヌスケンタウレ.GetRareWeight(), GameText.シーラミア.GetRareWeight(), GameText.セイレーン.GetRareWeight(), GameText.スキュラ.GetRareWeight(), GameText.カリュブディス.GetRareWeight(), GameText.クラーケン.GetRareWeight(), GameText.オールドスキュラ.GetRareWeight()))
    		{
    		case 0:
    			return Generate(SpeciesDefaults.Getカッパ(), SpeciesDefaults.Getカッパ(), 2, GameText.カッパ);
    		case 1:
    			return Generate(SpeciesDefaults.Getマーメイド(), SpeciesDefaults.Getマーメイド(), 2, GameText.マーメイド);
    		case 2:
    			return Generate(SpeciesDefaults.Getオールドマーメイド(), SpeciesDefaults.Getオールドマーメイド(), 2, GameText.オールドマーメイド);
    		case 3:
    			return Generate(SpeciesDefaults.Getドルフィンマーメイド(), SpeciesDefaults.Getドルフィンマーメイド(), 2, GameText.ドルフィンマーメイド);
    		case 4:
    		{
    			bool b = RNG.XS.NextBool();
    			return Generate(SpeciesDefaults.Getイクテュオケンタウレ(b), SpeciesDefaults.Getイクテュオケンタウレ(b), 3, GameText.イクテュオケンタウレ);
    		}
    		case 5:
    			return Generate(SpeciesDefaults.Getデルピヌスケンタウレ(), SpeciesDefaults.Getデルピヌスケンタウレ(), 3, GameText.デルピヌスケンタウレ);
    		case 6:
    			return Generate(SpeciesDefaults.Getシーラミア(), SpeciesDefaults.Getシーラミア(), 2, GameText.シーラミア);
    		case 7:
    		{
    			int num = RNG.XS.Next(3);
    			return Generate(SpeciesDefaults.Getセイレーン(num), SpeciesDefaults.Getセイレーン(num), 2, GameText.セイレーン);
    		}
    		case 8:
    			return Generate(SpeciesDefaults.Getスキュラ(), SpeciesDefaults.Getスキュラ(), 2, GameText.スキュラ);
    		case 9:
    			return Generate(SpeciesDefaults.Getカリュブディス(), SpeciesDefaults.Getカリュブディス(), 3, GameText.カリュブディス);
    		case 10:
    			return Generate(SpeciesDefaults.Getクラーケン(), SpeciesDefaults.Getクラーケン(), 3, GameText.クラーケン);
    		case 11:
    		{
    			bool b = RNG.XS.NextBool();
    			return Generate(SpeciesDefaults.Getオールドスキュラ(b), SpeciesDefaults.Getオールドスキュラ(b), 4, GameText.オールドスキュラ);
    		}
    		default:
    			return null;
    		}
    	}

    	protected Unit GetInsect()
    	{
    		switch (GeometryUtils.GetRandomIndex(GameText.ウェアマンティス.GetRareWeight(), GameText.ウェアドラゴンフライ.GetRareWeight(), GameText.ウェアビートル.GetRareWeight(), GameText.ウェアスタッグビートル.GetRareWeight(), GameText.アラクネ.GetRareWeight(), GameText.ギルタブリル.GetRareWeight(), GameText.ギルタブルル.GetRareWeight(), GameText.ムカデジョウロウ.GetRareWeight(), GameText.サンドワーム.GetRareWeight(), GameText.フェアリー.GetRareWeight()))
    		{
    		case 0:
    			return Generate(SpeciesDefaults.Getウェアマンティス(), SpeciesDefaults.Getウェアマンティス(), 1, GameText.ウェアマンティス);
    		case 1:
    			return Generate(SpeciesDefaults.Getウェアドラゴンフライ(), SpeciesDefaults.Getウェアドラゴンフライ(), 1, GameText.ウェアドラゴンフライ);
    		case 2:
    			return Generate(SpeciesDefaults.Getウェアビートル(), SpeciesDefaults.Getウェアビートル(), 1, GameText.ウェアビートル);
    		case 3:
    			return Generate(SpeciesDefaults.Getウェアスタッグビートル(), SpeciesDefaults.Getウェアスタッグビートル(), 1, GameText.ウェアスタッグビートル);
    		case 4:
    		{
    			bool b = RNG.XS.NextBool();
    			return Generate(SpeciesDefaults.Getアラクネ(b), SpeciesDefaults.Getアラクネ(b), 2, GameText.アラクネ);
    		}
    		case 5:
    			return Generate(SpeciesDefaults.Getギルタブリル(), SpeciesDefaults.Getギルタブリル(), 2, GameText.ギルタブリル);
    		case 6:
    			return Generate(SpeciesDefaults.Getギルタブルル(), SpeciesDefaults.Getギルタブルル(), 2, GameText.ギルタブルル);
    		case 7:
    			return Generate(SpeciesDefaults.Getムカデジョウロウ(), SpeciesDefaults.Getムカデジョウロウ(), 2, GameText.ムカデジョウロウ);
    		case 8:
    			return Generate(SpeciesDefaults.Getサンドワーム(), SpeciesDefaults.Getサンドワーム(), 2, GameText.サンドワーム);
    		case 9:
    		{
    			bool b = RNG.XS.NextBool();
    			bool b2 = RNG.XS.NextBool();
    			return Generate(SpeciesDefaults.Getフェアリー(b, b2), SpeciesDefaults.Getフェアリー(b, b2), 1, GameText.フェアリー);
    		}
    		default:
    			return null;
    		}
    	}

    	protected Unit GetHumanoid()
    	{
    		switch (GeometryUtils.GetRandomIndex(GameText.リリン.GetRareWeight(), GameText.エルフ.GetRareWeight(), GameText.ドワーフ.GetRareWeight(), GameText.オーグリス.GetRareWeight(), GameText.サイクロプス.GetRareWeight(), GameText.デビル.GetRareWeight(), GameText.エンジェル.GetRareWeight(), GameText.サキュバス.GetRareWeight(), GameText.アルラウネ.GetRareWeight(), GameText.スライム.GetRareWeight(), GameText.エイリアン.GetRareWeight()))
    		{
    		case 0:
    			return Generate(SpeciesDefaults.Getリリン(), SpeciesDefaults.Getリリン(), 2, GameText.リリン);
    		case 1:
    			return Generate(SpeciesDefaults.Getエルフ(), SpeciesDefaults.Getエルフ(), 2, GameText.エルフ);
    		case 2:
    			return Generate(SpeciesDefaults.Getドワーフ(), SpeciesDefaults.Getドワーフ(), 2, GameText.ドワーフ);
    		case 3:
    		{
    			bool b = RNG.XS.NextBool();
    			return Generate(SpeciesDefaults.Getオーグリス(b), SpeciesDefaults.Getオーグリス(b), 2, GameText.オーグリス);
    		}
    		case 4:
    			return Generate(SpeciesDefaults.Getサイクロプス(), SpeciesDefaults.Getサイクロプス(), 2, GameText.サイクロプス);
    		case 5:
    			return Generate(SpeciesDefaults.Getデビル(), SpeciesDefaults.Getデビル(), 2, GameText.デビル);
    		case 6:
    		{
    			bool b = RNG.XS.NextBool();
    			return Generate(SpeciesDefaults.Getエンジェル(b), SpeciesDefaults.Getエンジェル(b), 2, GameText.エンジェル);
    		}
    		case 7:
    			return Generate(SpeciesDefaults.Getサキュバス(), SpeciesDefaults.Getサキュバス(), 2, GameText.サキュバス);
    		case 8:
    			return Generate(SpeciesDefaults.Getアルラウネ(), SpeciesDefaults.Getアルラウネ(), 2, GameText.アルラウネ);
    		case 9:
    			return Generate(SpeciesDefaults.Getスライム(), SpeciesDefaults.Getスライム(), 0, GameText.スライム);
    		case 10:
    			return Generate(SpeciesDefaults.Getエイリアン(), SpeciesDefaults.Getエイリアン(), 3, GameText.エイリアン);
    		default:
    			return null;
    		}
    	}

    	protected Unit Get幻獣()
    	{
    		return GeometryUtils.GetRandomIndex(GameText.カーバンクル.GetRareWeight(), GameText.ペガサス.GetRareWeight(), GameText.ユニコーン.GetRareWeight(), GameText.バイコーン.GetRareWeight(), GameText.アリコーン.GetRareWeight(), GameText.グリフォン.GetRareWeight(), GameText.モノケロス.GetRareWeight(), GameText.ヒッポグリフ.GetRareWeight()) switch
    		{
    			0 => Generate(SpeciesDefaults.Getカーバンクル(), SpeciesDefaults.Getカーバンクル(), 2, GameText.カーバンクル), 
    			1 => Generate(SpeciesDefaults.Getペガサス(), SpeciesDefaults.Getペガサス(), 3, GameText.ペガサス), 
    			2 => Generate(SpeciesDefaults.Getユニコーン(), SpeciesDefaults.Getユニコーン(), 3, GameText.ユニコーン), 
    			3 => Generate(SpeciesDefaults.Getバイコーン(), SpeciesDefaults.Getバイコーン(), 3, GameText.バイコーン), 
    			4 => Generate(SpeciesDefaults.Getアリコーン(), SpeciesDefaults.Getアリコーン(), 3, GameText.アリコーン), 
    			5 => Generate(SpeciesDefaults.Getグリフォン(), SpeciesDefaults.Getグリフォン(), 3, GameText.グリフォン), 
    			6 => Generate(SpeciesDefaults.Getモノケロス(), SpeciesDefaults.Getモノケロス(), 3, GameText.モノケロス), 
    			7 => Generate(SpeciesDefaults.Getヒッポグリフ(), SpeciesDefaults.Getヒッポグリフ(), 3, GameText.ヒッポグリフ), 
    			_ => null, 
    		};
    	}

    	protected Unit Get魔獣()
    	{
    		switch (GeometryUtils.GetRandomIndex(GameText.キマイラ.GetRareWeight(), GameText.スフィンクス.GetRareWeight(), GameText.カトブレパス.GetRareWeight(), GameText.バジリスク.GetRareWeight(), GameText.コカトリス.GetRareWeight(), GameText.ゴルゴン.GetRareWeight()))
    		{
    		case 0:
    			return Generate(SpeciesDefaults.Getキマイラ(), SpeciesDefaults.Getキマイラ(), 3, GameText.キマイラ);
    		case 1:
    		{
    			bool b = RNG.XS.NextBool();
    			return Generate(SpeciesDefaults.Getスフィンクス(b), SpeciesDefaults.Getスフィンクス(b), 3, GameText.スフィンクス);
    		}
    		case 2:
    			return Generate(SpeciesDefaults.Getカトブレパス(), SpeciesDefaults.Getカトブレパス(), 3, GameText.カトブレパス);
    		case 3:
    			return Generate(SpeciesDefaults.Getバジリスク(), SpeciesDefaults.Getバジリスク(), 3, GameText.バジリスク);
    		case 4:
    			return Generate(SpeciesDefaults.Getコカトリス(), SpeciesDefaults.Getコカトリス(), 3, GameText.コカトリス);
    		case 5:
    			return Generate(SpeciesDefaults.Getゴルゴン(), SpeciesDefaults.Getゴルゴン(), 3, GameText.ゴルゴン);
    		default:
    			return null;
    		}
    	}

    	protected Unit GetDragon()
    	{
    		return GeometryUtils.GetRandomIndex(GameText.リザードマン.GetRareWeight(), GameText.ドラゴニュート.GetRareWeight(), GameText.ワーム.GetRareWeight(), GameText.リュウ.GetRareWeight(), GameText.ワイバーン.GetRareWeight(), GameText.ドラコケンタウレ.GetRareWeight(), GameText.ドラゴン.GetRareWeight()) switch
    		{
    			0 => Generate(SpeciesDefaults.Getリザードマン(), SpeciesDefaults.Getリザードマン(), 2, GameText.リザードマン), 
    			1 => Generate(SpeciesDefaults.Getドラゴニュート(), SpeciesDefaults.Getドラゴニュート(), 3, GameText.ドラゴニュート), 
    			2 => Generate(SpeciesDefaults.Getワーム(), SpeciesDefaults.Getワーム(), 4, GameText.ワーム), 
    			3 => Generate(SpeciesDefaults.Getリュウ(), SpeciesDefaults.Getリュウ(), 5, GameText.リュウ), 
    			4 => Generate(SpeciesDefaults.Getワイバーン(), SpeciesDefaults.Getワイバーン(), 4, GameText.ワイバーン), 
    			5 => Generate(SpeciesDefaults.Getドラコケンタウレ(), SpeciesDefaults.Getドラコケンタウレ(), 4, GameText.ドラコケンタウレ), 
    			6 => Generate(SpeciesDefaults.Getドラゴン(), SpeciesDefaults.Getドラゴン(), 5, GameText.ドラゴン), 
    			_ => null, 
    		};
    	}

    	public void Refresh()
    	{
    		i = 0;
    		Buf.Clear();
    		Unit[] a = new Unit[Capacity];

    		for (int i = 0; i < Capacity; i++)
    			a[i] = gen();
    		/*
    		Parallel.For(0, Capacity, Sta.po3, delegate(int i)
    		{
    			a[i] = g();
    		});*/
    		Buf.AddRange(a);
    	}

    	public void Refresh(int Capacity)
    	{
    		this.Capacity = Capacity;
    		i = 0;
    		Buf.Clear();
    		Buf.Capacity = Capacity;
    		Unit[] a = new Unit[Capacity];
    		for (int i = 0; i < Capacity; i++)
    			a[i] = gen();
    		/*
    		Parallel.For(0, Capacity, Sta.po3, delegate(int i)
    		{
    			a[i] = g();
    		});*/
    		Buf.AddRange(a);
    	}

    	public void Rotation()
    	{
    		i++;
    	}

    	public Unit RefCharacter()
    	{
    		if (Buf.Count <= 0)
    		{
    			return null;
    		}
    		return Buf[i % Buf.Count];
    	}

    	public Unit GetCharacter()
    	{
    		if (Buf.Count > 0)
    		{
    			Unit unit = Buf[i % Buf.Count];
    			Buf.Remove(unit);
    			return unit;
    		}
    		return null;
    	}
    }
}
