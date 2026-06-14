using System;
using System.Linq;
using System.Threading.Tasks;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    //basically represents a slave
    [Serializable]
    public class Unit
    {
    	public int 階層位置;

    	public int RoomNumber;

    	public string Number = "";

    	public string Name = "";

    	private Unit mother;

    	private Unit father;

    	public Unit Child;

    	private CharacterData cd;

    	public ulong Price;

    	public string Race = "";

    	public bool 保守;

    	public bool Laboror;

    	public bool Prostitute;

    	public int LaborCount;

    	public int ProstituteCount;

    	public int 妊娠状態変数 = -1;

    	public int 妊娠進行期間 = 2;

    	public bool 非妊娠 = true;

    	private bool 無毛;

    	private bool 処女;

    	private bool 発情;

    	private bool 妊娠;

    	private bool 強靭;

    	private bool 傷物;

    	private bool 調教済;

    	public int 着衣番号;

    	public object[] 着衣;

    	public RaceInformation 種族情報;

    	public double MaxSkillL;

    	public int 一般最大加算値;

    	public int 娼婦最大加算値;

    	public double 消耗乗算値;

    	public double 回復値;

    	public bool Is増殖可;

    	public Unit Mother
    	{
    		get
    		{
    			return mother;
    		}
    		set
    		{
    			mother = value.DeepCopy();
    			mother.mother = null;
    			mother.father = null;
    		}
    	}

    	public Unit Father
    	{
    		get
    		{
    			return father;
    		}
    		set
    		{
    			father = value.DeepCopy();
    			father.mother = null;
    			father.father = null;
    		}
    	}

    	public CharacterData ChaD
    	{
    		get
    		{
    			return cd;
    		}
    		set
    		{
    			cd = value;
    			cd.Parent = this;
    		}
    	}

    	public bool Hairless
    	{
    		get
    		{
    			return 無毛;
    		}
    		set
    		{
    			無毛 = value;
    			if (value)
    			{
    				if (!ChaD.body_color.血統.Contains(GameText.無毛))
    				{
    					ChaD.body_color.血統.Add(GameText.無毛);
    				}
    			}
    			else if (ChaD.body_color.血統.Contains(GameText.無毛))
    			{
    				ChaD.body_color.血統.Remove(GameText.無毛);
    			}
    		}
    	}

    	public bool Virgin
    	{
    		get
    		{
    			return 処女;
    		}
    		set
    		{
    			処女 = value;
    			if (value)
    			{
    				if (!ChaD.body_color.血統.Contains(GameText.処女))
    				{
    					ChaD.body_color.血統.Add(GameText.処女);
    				}
    			}
    			else if (ChaD.body_color.血統.Contains(GameText.処女))
    			{
    				ChaD.body_color.血統.Remove(GameText.処女);
    			}
    		}
    	}

    	public bool 発情フラグ
    	{
    		get
    		{
    			return 発情;
    		}
    		set
    		{
    			発情 = value;
    			if (value)
    			{
    				if (!ChaD.body_color.血統.Contains(GameText.発情))
    				{
    					ChaD.body_color.血統.Add(GameText.発情);
    				}
    			}
    			else if (ChaD.body_color.血統.Contains(GameText.発情))
    			{
    				ChaD.body_color.血統.Remove(GameText.発情);
    			}
    		}
    	}

    	public bool Pregnant
    	{
    		get
    		{
    			return 妊娠;
    		}
    		set
    		{
    			妊娠 = value;
    			if (value)
    			{
    				if (!ChaD.body_color.血統.Contains(GameText.妊娠))
    				{
    					ChaD.body_color.血統.Add(GameText.妊娠);
    				}

    				Unit unit = ((GlobalState.GameData.祝福 == null || GlobalState.GameData.祝福 == this) ? GlobalState.GameData.プレーヤー : GlobalState.GameData.祝福);
    				if (GlobalState.SimpleMating)
    				{
    					Child = this.Mix(unit, 原種モード(this, unit));
    				}
    				else
    				{
    					Unit unit2 = Mother.Mix(Father, 原種モード(Mother, Father));
    					Unit unit3 = unit.Mother.Mix(unit.Father, 原種モード(unit.Mother, unit.Father));
    					Child = unit2.Mix(unit3, 原種モード(unit2, unit3));
    					Child.Mother = this;
    					Child.Father = unit;
    				}

    			}
    			else
    			{
    				if (ChaD.body_color.血統.Contains(GameText.妊娠))
    				{
    					ChaD.body_color.血統.Remove(GameText.妊娠);
    				}
    				Child = null;
    			}
    		}
    	}

    	public bool Muscular
    	{
    		get
    		{
    			return 強靭;
    		}
    		set
    		{
    			強靭 = value;
    			if (value)
    			{
    				if (!ChaD.body_color.血統.Contains(GameText.強靭))
    				{
    					ChaD.body_color.血統.Add(GameText.強靭);
    				}
    				ChaD.body_tree.EnumEleD().SetValuesD("筋肉", true);
    			}
    			else
    			{
    				if (ChaD.body_color.血統.Contains(GameText.強靭))
    				{
    					ChaD.body_color.血統.Remove(GameText.強靭);
    				}
    				ChaD.body_tree.EnumEleD().SetValuesD("筋肉", false);
    			}
    		}
    	}

    	public bool Scars
    	{
    		get
    		{
    			return 傷物;
    		}
    		set
    		{
    			if (GlobalState.DontScar)
    			{
    				傷物 = value;
    				if (value && !ChaD.body_color.血統.Contains(GameText.傷物))
    				{
    					ChaD.body_color.血統.Add(GameText.傷物);
    				}
    				else if (!value && ChaD.body_color.血統.Contains(GameText.傷物))
    				{
    					ChaD.body_color.血統.Remove(GameText.傷物);
    				}
    				return;
    			}
    			傷物 = value;
    			if (value)
    			{
    				if (!ChaD.body_color.血統.Contains(GameText.傷物))
    				{
    					ChaD.body_color.血統.Add(GameText.傷物);
    				}
    				bool flag = false;
    				while (!flag)
    				{
    					foreach (ElementData item in ChaD.body_tree.EnumEleD())
    					{
    						flag |= item.傷物処理();
    					}
    				}
    				{
    					foreach (ElementData item2 in ChaD.body_tree.EnumEleD())
    					{
    						item2.欠損 = 0.3.Lot();
    					}
    					return;
    				}
    			}
    			if (ChaD.body_color.血統.Contains(GameText.傷物))
    			{
    				ChaD.body_color.血統.Remove(GameText.傷物);
    			}
    			foreach (ElementData item3 in ChaD.body_tree.EnumEleD())
    			{
    				item3.SetValuesD("傷", false);
    				item3.欠損 = false;
    			}
    		}
    	}

    	public bool Trained
    	{
    		get
    		{
    			return 調教済;
    		}
    		set
    		{
    			調教済 = value;
    			if (value)
    			{
    				if (!ChaD.body_color.血統.Contains(GameText.調教済))
    				{
    					ChaD.body_color.血統.Add(GameText.調教済);
    				}
    			}
    			else if (ChaD.body_color.血統.Contains(GameText.調教済))
    			{
    				ChaD.body_color.血統.Remove(GameText.調教済);
    			}
    		}
    	}

    	public string GetStatus()
    	{
    		return GameText.種族 + "/ " + Race + " " + GameText.価格 + "/ " + GetPrice().ToString("#,0") + "\r\n" + GameText.抵抗値 + "/" + ChaD.Pride.Numf1() + " " + GameText.魔力濃度 + "/" + ChaD.魔力濃度.Numf1() + "\r\n" + GameText.欲望度 + "/" + ChaD.Lust.Numf1() + " " + GameText.情愛度 + "/" + ChaD.Affection.Numf1() + "\r\n" + GameText.卑屈度 + "/" + ChaD.Taming.Numf1() + " " + GameText.技巧度 + "/" + ChaD.SkillL.Numf1() + "\r\n" + string.Join("", ChaD.body_color.血統.Select((string e) => "[" + e + "]").Reverse());
    	}

    	public string GetPriceInfo()
    	{
    		string text;
    		string[] obj = new string[69]
    		{
    			"(\r\n(1,000,000 * (1 - ",
    			GameText.抵抗値,
    			"[",
    			$"{ChaD.Pride:0.00}",
    			"])) +\r\n(1,000,000 * (",
    			GameText.欲望度,
    			"[",
    			$"{ChaD.Lust:0.00}",
    			"])) +\r\n(1,000,000 * (",
    			GameText.情愛度,
    			"[",
    			$"{ChaD.Affection:0.00}",
    			"] * 0.5)) +\r\n(1,000,000 * (",
    			GameText.卑屈度,
    			"[",
    			$"{ChaD.Taming:0.00}",
    			"])) +\r\n(1,000,000 * (",
    			GameText.技巧度,
    			"[",
    			$"{ChaD.SkillL:0.00}",
    			"] * 4)) +\r\n(  100,000 * (",
    			GameText.部位感度合計,
    			"[",
    			$"{ChaD.Sesnsitivities.Values.Sum():0.00}",
    			"]) +\r\n(1,000,000 * (",
    			GameText.バストサイズ,
    			"[",
    			$"{ChaD.body_tree.EnumEleD().GetEleD<乳房D>().バスト:0.00}",
    			"])\r\n(1,000,000 * (",
    			GameText.一般労働,
    			"[",
    			$"{(double)種族情報.一般 / 9.0:0.00}",
    			"])) +\r\n(1,000,000 * (",
    			GameText.娼婦労働,
    			"[",
    			$"{(double)種族情報.娼婦 / 9.0:0.00}",
    			"])) +\r\n) *\r\n\r\n",
    			GameText.種族,
    			"[",
    			$"{種族情報.GetPriceWeight():0.00}",
    			"] *\r\n",
    			GameText.需給,
    			"[",
    			$"{GlobalState.GameData.需給[Race]:0.00}",
    			"]",
    			ChaD.body_color.血統.Contains(GameText.調教済) ? (" *\r\n" + GameText.調教済 + "[1.6]") : "",
    			ChaD.body_color.血統.Contains(GameText.無毛) ? (" *\r\n" + GameText.無毛 + "[2]") : "",
    			ChaD.body_color.血統.Contains(GameText.処女) ? (" *\r\n" + GameText.処女 + "[1.5]") : "",
    			ChaD.body_color.血統.Contains(GameText.発情) ? (" *\r\n" + GameText.発情 + "[1.2]") : "",
    			ChaD.body_color.血統.Contains(GameText.妊娠) ? (" *\r\n" + GameText.妊娠 + "[1.5]") : "",
    			ChaD.body_color.血統.Contains(GameText.強靭) ? (" *\r\n" + GameText.強靭 + "[1.4]") : "",
    			ChaD.body_color.血統.Contains(GameText.傷物) ? (" *\r\n" + GameText.傷物 + "[0.1]") : "",
    			ChaD.body_color.血統.Contains(GameText.オッドアイ) ? (" *\r\n" + GameText.オッドアイ + "[5]") : "",
    			((text = ChaD.body_color.血統.FirstOrDefault((string e) => e.StartsWith(GameText.ルチノー))) != null) ? (" *\r\n" + text + "[" + text.GetRutinohWeight() + "]") : "",
    			ChaD.body_color.血統.Contains(GameText.メラニス) ? (" *\r\n" + GameText.メラニス + "[30]") : "",
    			ChaD.body_color.血統.Contains(GameText.アルビノ) ? (" *\r\n" + GameText.アルビノ + "[50]") : "",
    			"\r\n\r\n= ",
    			GameText.売値,
    			"[",
    			null,
    			null,
    			null,
    			null,
    			null,
    			null,
    			null,
    			null,
    			null,
    			null
    		};
    		ulong price;
    		ulong num = (price = GetPrice());
    		obj[59] = num.ToString("#,0");
    		obj[60] = "] - ";
    		obj[61] = GameText.買値;
    		obj[62] = "[";
    		obj[63] = Price.ToString("#,0");
    		obj[64] = "]\r\n\r\n= ";
    		obj[65] = GameText.利益;
    		obj[66] = "[";
    		obj[67] = ((price >= Price) ? (price - Price).ToString("#,0") : ("-" + (Price - price).ToString("#,0")));
    		obj[68] = "]";
    		return string.Concat(obj);
    	}

    	public ulong GetPrice()
    	{
    		try
    		{
    			return checked((ulong)((1000000.0 * ChaD.Pride.Inverse() + 1000000.0 * ChaD.Lust + 1000000.0 * (ChaD.Affection * 0.5) + 1000000.0 * ChaD.Taming + 1000000.0 * (ChaD.SkillL * 4.0) + 100000.0 * ChaD.Sesnsitivities.Values.Sum() + 1000000.0 * ChaD.body_tree.EnumEleD().GetEleD<乳房D>().バスト + 1000000.0 * ((double)種族情報.一般 / 9.0) + 1000000.0 * ((double)種族情報.娼婦 / 9.0)) * 種族情報.GetPriceWeight() * GlobalState.GameData.需給[Race] * (ChaD.body_color.血統.Contains(GameText.調教済) ? 1.6 : 1.0) * (ChaD.body_color.血統.Contains(GameText.無毛) ? 2.0 : 1.0) * (ChaD.body_color.血統.Contains(GameText.処女) ? 1.5 : 1.0) * (ChaD.body_color.血統.Contains(GameText.発情) ? 1.2 : 1.0) * (ChaD.body_color.血統.Contains(GameText.妊娠) ? 1.5 : 1.0) * (ChaD.body_color.血統.Contains(GameText.強靭) ? 1.4 : 1.0) * (ChaD.body_color.血統.Contains(GameText.傷物) ? 0.1 : 1.0) * (ChaD.body_color.血統.Contains(GameText.オッドアイ) ? 5.0 : 1.0) * ChaD.body_color.血統.FirstOrDefault((string e) => e.StartsWith(GameText.ルチノー)).GetRutinohWeight() * (ChaD.body_color.血統.Contains(GameText.メラニス) ? 30.0 : 1.0) * (ChaD.body_color.血統.Contains(GameText.アルビノ) ? 50.0 : 1.0)));
    		}
    		catch
    		{
    			return 9999999999999uL;
    		}
    	}

    	public void 娼婦妊娠()
    	{
    		妊娠 = true;
    		if (!ChaD.body_color.血統.Contains(GameText.妊娠))
    		{
    			ChaD.body_color.血統.Add(GameText.妊娠);
    		}
    		Unit unit = Generator.娼婦労働妊娠父方();
    		if (GlobalState.SimpleMating)
    		{
    			Child = this.Mix(unit, 原種モード(this, unit));
    			return;
    		}
    		Unit unit2 = Mother.Mix(Father, 原種モード(Mother, Father));
    		Unit unit3 = unit.Mother.Mix(unit.Father, 原種モード(unit.Mother, unit.Father));
    		Child = unit2.Mix(unit3, 原種モード(unit2, unit3));
    		Child.Mother = this;
    		Child.Father = unit;
    	}

    	private bool 原種モード(Unit 母方, Unit 父方)
    	{
    		if (母方.Race != GameText.ミックス && 父方.Race != GameText.ミックス)
    		{
    			return 母方.Race == 父方.Race;
    		}
    		return false;
    	}

    	public bool IsTrained()
    	{
    		if (調教済)
    		{
    			return false;
    		}
    		if (ChaD.Pride == 0.0 && ChaD.Lust + ChaD.Affection + ChaD.Taming > 1.5 && ChaD.SkillL > 0.2)
    		{
    			Trained = true;
    			return true;
    		}
    		return false;
    	}

    	public void Set原種素質()
    	{
    		半身D eleD = ChaD.body_tree.半身_接続.GetEleD<半身D>();
    		腰肌D eleD2 = ChaD.body_tree.肌_接続.GetEleD<腰肌D>();
    		Hairless = !(eleD is 単足_粘D) && !(eleD is 四足胸D) && (!(eleD is 長物_蛇D) || !((長物_蛇D)eleD).ガード) && !ChaD.body_tree.虫性_甲殻1_表示 && !ChaD.body_tree.虫性_甲殻2_表示 && !eleD2.竜性_鱗1_表示 && !eleD2.竜性_鱗2_表示 && !eleD2.竜性_鱗3_表示 && !eleD2.竜性_鱗4_表示 && ((!eleD2.陰毛_表示 && !eleD2.獣性_獣毛_表示) || ChaD.最陰毛濃度 == 0.0);
    		if (!(Race == GameText.スライム) && !(Race == GameText.フェニックス) && !(Race == GameText.ウロボロス))
    		{
    			Scars = 0.05.Lot();
    		}
    		if (Race == GameText.ウェアウルフ)
    		{
    			Muscular = 0.03.Lot();
    		}
    		else if (Race == GameText.リザードマン)
    		{
    			Muscular = 0.03.Lot();
    		}
    		else if (Race == GameText.サイクロプス)
    		{
    			Muscular = 0.03.Lot();
    		}
    		else if (Race == GameText.ワーム)
    		{
    			Muscular = 0.1.Lot();
    		}
    		else if (Race == GameText.ワイバーン)
    		{
    			Muscular = 0.1.Lot();
    		}
    		else if (Race == GameText.ドラコケンタウレ)
    		{
    			Muscular = 0.1.Lot();
    		}
    		else if (Race == GameText.ドラゴン)
    		{
    			Muscular = 0.1.Lot();
    		}
    		else if (Race == GameText.リュウ)
    		{
    			Muscular = 0.1.Lot();
    		}
    		else if (Race == GameText.ドラゴニュート)
    		{
    			Muscular = 0.1.Lot();
    		}
    		else if (Race == GameText.ドワーフ)
    		{
    			Muscular = 0.8.Lot();
    		}
    		else if (Race == GameText.オーグリス)
    		{
    			Muscular = 0.9.Lot();
    		}
    		else if (Race == GameText.ミノタウロス)
    		{
    			Muscular = 0.9.Lot();
    		}
    		else if (Race == GameText.カトブレパス)
    		{
    			Muscular = 1.0.Lot();
    		}
    		else
    		{
    			Muscular = 0.005.Lot();
    		}
    	}

    	public void Set交配素質()
    	{
    		半身D eleD = ChaD.body_tree.半身_接続.GetEleD<半身D>();
    		腰肌D eleD2 = ChaD.body_tree.肌_接続.GetEleD<腰肌D>();
    		Hairless = !(eleD is 単足_粘D) && !(eleD is 四足胸D) && (!(eleD is 長物_蛇D) || !((長物_蛇D)eleD).ガード) && !ChaD.body_tree.虫性_甲殻1_表示 && !ChaD.body_tree.虫性_甲殻2_表示 && !eleD2.竜性_鱗1_表示 && !eleD2.竜性_鱗2_表示 && !eleD2.竜性_鱗3_表示 && !eleD2.竜性_鱗4_表示 && ((!eleD2.陰毛_表示 && !eleD2.獣性_獣毛_表示) || ChaD.最陰毛濃度 == 0.0);
    		Virgin = true;
    		Muscular = ChaD.body_tree.筋肉;
    	}

    	public void SetViola(ModeEventDispatcher Med, RenderArea Are)
    	{
    		階層位置 = 0;
    		RoomNumber = 0;
    		Number = "000";
    		Name = GameText.ヴィオランテ;
    		Child = null;
    		ChaD = SpeciesDefaults.GetViola();
    		Race = GameText.ヴィオランテ;
    		保守 = false;
    		Laboror = false;
    		Prostitute = false;
    		LaborCount = 0;
    		ProstituteCount = 0;
    		妊娠状態変数 = -1;
    		妊娠進行期間 = 4;
    		非妊娠 = true;
    		Hairless = false;
    		Virgin = false;
    		発情フラグ = false;
    		Pregnant = false;
    		Muscular = false;
    		Scars = false;
    		Trained = false;
    		着衣番号 = 8;
    		着衣 = 衣装.Getヴィオラ服0(ChaD).ToArray();
    		RaceInformation 種族情報2 = RacialDefinitions.race_information[Race];
    		種族情報 = new RaceInformation(種族情報2.希少, 種族情報2.需要, 種族情報2.危険, ((int)((double)(種族情報2.一般 + 1) * ChaD.固有値)).Clamp(1, 9), ((int)((double)(種族情報2.娼婦 + 1) * ChaD.固有値)).Clamp(1, 9));
    		Set種族特性();
    		Set構成特性();
    		Price = GetPrice();
    		Mother = this;
    		Father = this;
    	}

    	public Unit 増殖時Reset()
    	{
    		Price = 0uL;
    		保守 = false;
    		Laboror = false;
    		Prostitute = false;
    		LaborCount = 0;
    		ProstituteCount = 0;
    		非妊娠 = true;
    		this.Set衣装();
    		return this;
    	}

    	public void Set種族特性()
    	{
    		if (Race == GameText.ハーピー)
    		{
    			ChaD.欲望補正();
    		}
    		else if (Race == GameText.ハルピュイア)
    		{
    			ChaD.欲望補正();
    		}
    		else if (Race == GameText.フェニックス)
    		{
    			ChaD.情愛補正();
    		}
    		else if (Race == GameText.ラミア)
    		{
    			ChaD.欲望補正();
    		}
    		else
    		{
    			if (Race == GameText.ヒュドラ)
    			{
    				return;
    			}
    			if (Race == GameText.エキドナ)
    			{
    				ChaD.欲望補正();
    				ChaD.情愛補正();
    			}
    			else
    			{
    				if (Race == GameText.ウロボロス)
    				{
    					return;
    				}
    				if (Race == GameText.ウェアキャット)
    				{
    					ChaD.情愛補正();
    				}
    				else if (Race == GameText.ウェアウルフ)
    				{
    					ChaD.卑屈補正();
    				}
    				else
    				{
    					if (Race == GameText.アフール)
    					{
    						return;
    					}
    					if (Race == GameText.ウェアフォックス)
    					{
    						ChaD.情愛補正();
    						ChaD.卑屈補正();
    					}
    					else if (Race == GameText.カプラケンタウレ)
    					{
    						ChaD.欲望補正();
    						ChaD.卑屈補正();
    					}
    					else if (Race == GameText.オノケンタウレ)
    					{
    						ChaD.卑屈補正();
    					}
    					else if (Race == GameText.ミノタウロス)
    					{
    						ChaD.欲望補正();
    						ChaD.情愛補正();
    					}
    					else if (Race == GameText.ヒッポケンタウレ)
    					{
    						ChaD.欲望補正();
    					}
    					else if (Race == GameText.ブケンタウレ)
    					{
    						ChaD.欲望補正();
    						ChaD.情愛補正();
    					}
    					else if (Race == GameText.レオントケンタウレ)
    					{
    						ChaD.情愛補正();
    					}
    					else if (Race == GameText.ティグリスケンタウレ)
    					{
    						ChaD.欲望補正();
    						ChaD.情愛補正();
    					}
    					else if (Race == GameText.パンテーラケンタウレ)
    					{
    						ChaD.情愛補正();
    					}
    					else if (Race == GameText.チータケンタウレ)
    					{
    						ChaD.情愛補正();
    					}
    					else if (Race == GameText.シーラミア)
    					{
    						ChaD.欲望補正();
    						ChaD.情愛補正();
    					}
    					else if (Race == GameText.マーメイド)
    					{
    						ChaD.情愛補正();
    						ChaD.卑屈補正();
    					}
    					else if (Race == GameText.セイレーン)
    					{
    						ChaD.欲望補正();
    					}
    					else if (Race == GameText.ドルフィンマーメイド)
    					{
    						ChaD.欲望補正();
    						ChaD.情愛補正();
    					}
    					else if (Race == GameText.イクテュオケンタウレ)
    					{
    						ChaD.欲望補正();
    					}
    					else if (Race == GameText.デルピヌスケンタウレ)
    					{
    						ChaD.情愛補正();
    					}
    					else if (Race == GameText.カッパ)
    					{
    						ChaD.欲望補正();
    						ChaD.情愛補正();
    					}
    					else if (Race == GameText.クラーケン)
    					{
    						ChaD.欲望補正();
    					}
    					else
    					{
    						if (Race == GameText.スキュラ)
    						{
    							return;
    						}
    						if (Race == GameText.オールドマーメイド)
    						{
    							ChaD.情愛補正();
    						}
    						else if (Race == GameText.カリュブディス)
    						{
    							ChaD.欲望補正();
    						}
    						else
    						{
    							if (Race == GameText.オールドスキュラ)
    							{
    								return;
    							}
    							if (Race == GameText.ウェアマンティス)
    							{
    								ChaD.欲望補正();
    							}
    							else if (Race == GameText.ウェアドラゴンフライ)
    							{
    								ChaD.欲望補正();
    							}
    							else
    							{
    								if (Race == GameText.ウェアビートル || Race == GameText.ウェアスタッグビートル)
    								{
    									return;
    								}
    								if (Race == GameText.アラクネ)
    								{
    									ChaD.技巧補正();
    								}
    								else if (Race == GameText.サンドワーム)
    								{
    									ChaD.欲望補正();
    								}
    								else if (Race == GameText.ムカデジョウロウ)
    								{
    									ChaD.欲望補正();
    									ChaD.情愛補正();
    								}
    								else if (Race == GameText.ギルタブリル)
    								{
    									ChaD.欲望補正();
    									ChaD.情愛補正();
    								}
    								else
    								{
    									if (Race == GameText.ギルタブルル)
    									{
    										return;
    									}
    									if (Race == GameText.フェアリー)
    									{
    										ChaD.情愛補正();
    									}
    									else if (Race == GameText.スライム)
    									{
    										ChaD.欲望補正();
    									}
    									else if (Race == GameText.リリン)
    									{
    										ChaD.魔力濃度 *= 0.5;
    									}
    									else if (Race == GameText.ドワーフ)
    									{
    										ChaD.技巧補正();
    									}
    									else if (Race == GameText.エルフ)
    									{
    										ChaD.情愛補正();
    									}
    									else if (Race == GameText.オーグリス)
    									{
    										ChaD.欲望補正();
    									}
    									else if (Race == GameText.デビル)
    									{
    										ChaD.欲望補正();
    									}
    									else if (Race == GameText.アルラウネ)
    									{
    										ChaD.欲望補正();
    										ChaD.情愛補正();
    									}
    									else if (Race == GameText.サイクロプス)
    									{
    										ChaD.技巧補正();
    									}
    									else if (Race == GameText.エンジェル)
    									{
    										ChaD.情愛補正();
    									}
    									else if (Race == GameText.サキュバス)
    									{
    										ChaD.欲望補正();
    										ChaD.技巧補正();
    									}
    									else if (Race == GameText.エイリアン)
    									{
    										ChaD.技巧補正();
    									}
    									else if (Race == GameText.カーバンクル)
    									{
    										ChaD.卑屈補正();
    										ChaD.情愛補正();
    									}
    									else
    									{
    										if (Race == GameText.ペガサス)
    										{
    											return;
    										}
    										if (Race == GameText.ユニコーン)
    										{
    											ChaD.情愛補正();
    										}
    										else if (Race == GameText.バイコーン)
    										{
    											ChaD.欲望補正();
    										}
    										else if (Race == GameText.アリコーン)
    										{
    											ChaD.情愛補正();
    										}
    										else if (Race == GameText.グリフォン)
    										{
    											ChaD.情愛補正();
    										}
    										else if (Race == GameText.ヒッポグリフ)
    										{
    											ChaD.欲望補正();
    										}
    										else if (Race == GameText.モノケロス)
    										{
    											ChaD.欲望補正();
    											ChaD.情愛補正();
    										}
    										else if (Race == GameText.キマイラ)
    										{
    											ChaD.欲望補正();
    											ChaD.情愛補正();
    										}
    										else if (Race == GameText.スフィンクス)
    										{
    											ChaD.情愛補正();
    										}
    										else
    										{
    											if (Race == GameText.カトブレパス)
    											{
    												return;
    											}
    											if (Race == GameText.バジリスク)
    											{
    												ChaD.欲望補正();
    											}
    											else if (!(Race == GameText.コカトリス))
    											{
    												if (Race == GameText.ゴルゴン)
    												{
    													ChaD.欲望補正();
    													ChaD.情愛補正();
    													ChaD.卑屈補正();
    												}
    												else if (Race == GameText.リザードマン)
    												{
    													ChaD.欲望補正();
    													ChaD.情愛補正();
    												}
    												else if (Race == GameText.ワーム)
    												{
    													ChaD.欲望補正();
    												}
    												else if (Race == GameText.ドラコケンタウレ)
    												{
    													ChaD.欲望補正();
    												}
    												else if (Race == GameText.ワイバーン)
    												{
    													ChaD.欲望補正();
    												}
    												else if (Race == GameText.ドラゴニュート)
    												{
    													ChaD.情愛補正();
    												}
    												else if (!(Race == GameText.ドラゴン) && !(Race == GameText.リュウ) && !(Race == GameText.ヴィオランテ) && Race == GameText.ヒューマン)
    												{
    													ChaD.魔力濃度 *= 0.2;
    												}
    											}
    										}
    									}
    								}
    							}
    						}
    					}
    				}
    			}
    		}
    	}

    	public void Set構成特性()
    	{
    		ElementData[] array = ChaD.body_tree.EnumEleD().ToArray();
    		int num = 0;
    		int num2 = 0;
    		int num3 = 0;
    		int num4 = 0;
    		一般最大加算値 = 0;
    		娼婦最大加算値 = 0;
    		胸肌D 胸肌D2 = null;
    		胸肌D 胸肌D3 = null;
    		Is増殖可 = false;
    		ElementData[] array2 = array;
    		foreach (ElementData eleD in array2)
    		{
    			if (eleD is 手_人D)
    			{
    				if (!((手_人D)eleD).虫性)
    				{
    					num++;
    				}
    				if (((手_人D)eleD).虫性)
    				{
    					num2++;
    				}
    			}
    			if (eleD is 手_鳥D || eleD is 手_蝙D || eleD is 手_獣D || eleD is 手_牛D || eleD is 手_馬D || eleD is 触手_犬D)
    			{
    				一般最大加算値++;
    			}
    			if (!(eleD is 触手_犬D) && eleD is 触手D)
    			{
    				娼婦最大加算値++;
    			}
    			if (eleD is 尾D)
    			{
    				num3++;
    			}
    			if (eleD is 鳳凰D)
    			{
    				num4++;
    			}
    			if (eleD is 胸肌D)
    			{
    				if (eleD.接続情報 == ConnectionInfo.Chest_肌_接続)
    				{
    					胸肌D2 = (胸肌D)eleD;
    				}
    				else if (eleD.接続情報 == ConnectionInfo.四足胸_肌_接続)
    				{
    					胸肌D3 = (胸肌D)eleD;
    				}
    			}
    			if (!Is増殖可 && eleD is 単足_粘D)
    			{
    				Is増殖可 = true;
    			}
    		}
    		MaxSkillL = 0.5 + (double)(num / 2) + (double)(num2 / 2) * 0.5;
    		一般最大加算値 /= 2;
    		娼婦最大加算値 /= 2;
    		消耗乗算値 = 1.0 - ((double)num3 * 0.002 + ((Race == GameText.ワーム) ? 0.004 : 0.0) + ((Race == GameText.ドラコケンタウレ) ? 0.004 : 0.0) + ((Race == GameText.ワイバーン) ? 0.003 : 0.0) + ((Race == GameText.ドラゴニュート) ? 0.003 : 0.0) + ((Race == GameText.ドラゴン) ? 0.006 : 0.0) + ((Race == GameText.リュウ) ? 0.005 : 0.0));
    		bool flag = 胸肌D2 != null;
    		bool flag2 = 胸肌D3 != null;
    		回復値 = 3.5E-05 * (double)(((flag && 胸肌D2.コア_コア1_コア_表示) ? 1 : 0) + ((flag && 胸肌D2.コア_コア2_コア_表示) ? 1 : 0) + ((flag2 && 胸肌D3.コア_コア1_コア_表示) ? 1 : 0) + ((flag2 && 胸肌D3.コア_コア2_コア_表示) ? 1 : 0) + num4 + ((Race == GameText.ヒュドラ) ? 1 : 0));
    		ChaD.SkillL = ChaD.SkillL.Clamp(0.0, MaxSkillL);
    	}
    }
}
