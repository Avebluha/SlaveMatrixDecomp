using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class TrainingUI : Ele
    {
    	private ulong 媚薬投与価格 = 10000000uL;

    	private ConstProp CP = new ConstProp();


    	public Med Med;

    	public Are Are; 
        private Are Film;

        public Cha Cha;

    	public Bod Bod;

    	public InfoPanel ip;


        //tools
    	public ペニス ペニス;
    	public マウス マウス;
    	public ハンド ハンド右;
    	public ハンド ハンド左;
    	public ロータ ロータ;
    	public バイブ_コモン コモン;
    	public バイブ_ディル ディル;
    	public バイブ_アナル アナル;
    	public バイブ_デンマ デンマ;
    	public バイブ_ドリル ドリル;
    	public パール パール;
    	public 羽根箒 羽根箒;
    	public 調教鞭 調教鞭;
    	public T剃刀 T剃刀;
    	public キャップ1 キャップ1;
    	public キャップ1 キャップ2;
    	public キャップ1 キャップ3;

    	public CM ペニスCM;
    	public CM マウスCM;
    	public CM ハンド右CM;
    	public CM ハンド左CM;
    	public CM ロータCM;
    	public CM コモンCM;
    	public CM ディルCM;
    	public CM アナルCM;
    	public CM デンマCM;
    	public CM ドリルCM;
    	public CM パールCM;
    	public CM 羽根箒CM;
    	public CM 調教鞭CM;
    	public CM T剃刀CM;
    	public CM キャップ1CM;
    	public CM キャップ2CM;
        public CM キャップ3CM;
        private CM focus;
        private CM hcm;

        //tool animations?
        public 挿入処理 ペニス挿入;
    	public 挿入処理 マウス挿入;
    	public 挿入処理 ハンド挿入;
    	public 挿入処理 ロータ挿入;
    	public 挿入処理 コモン挿入;
    	public 挿入処理 ディル挿入;
    	public 挿入処理 アナル挿入;
    	public 挿入処理 デンマ挿入;
    	public 挿入処理 ドリル挿入;
    	public 挿入処理 パール挿入;
    	public 羽箒処理 羽箒処理;
    	public 剃刀処理 剃刀処理;
    	public 調鞭処理 調鞭処理;
    	public ハンド処理 ハンド処理;
    	public マウス処理 マウス処理;
    	public ペニス処理 ペニス処理;
    	public キャップ処理 キャップ処理;
        private 挿入処理 挿入処理f;
        public 挿入処理 挿入処理s; 
        private 挿入処理 ef;



        //ui elements
        public But 調教終了;
    	public But 拘束具;
    	public But 目隠帯;
    	public But 玉口枷;
    	public But 断面;
    	public But 媚薬;
    	public But 撮影;
        public But SlaveStamina;
        public But PlayerStamina;

        private Swi 拘束具sw = new Swi(Color.OrangeRed);
    	private Swi 目隠帯sw = new Swi(Color.OrangeRed);
    	private Swi 玉口枷sw = new Swi(Color.OrangeRed);
    	private Swi 断面sw = new Swi(Color.OrangeRed);

    	public Gau 体力sゲージ;
    	public Gau 絶頂sゲージ;
    	public Gau 興奮sゲージ;
    	public Gau 精力mゲージ;
    	public Gau 射精mゲージ;
    	public Gau 興奮mゲージ;

    	public Tex ステート;
        public Tex InfoBox;
        public Tex SensitivityBox;



        //misc flags
        public bool ステート描画;
        public bool ハンド左表示;
        public bool コキ_; 
        private bool 持ち手_;
        public bool 膣i肛f;
        public bool 肛f;
        public bool 肛oh;
        public bool IsTB;
        public bool 押し状態;
        private bool IsTool;
        private bool sf = true;
        public bool 強制拘束;
        public bool 拘束bu;
        public bool 発情bu;



        public 射精 射精;

    	public Mot 絶頂ゲージ点滅;
    	public Mot 射精ゲージ点滅;
    	public Mots Mots = new Mots();


        //moan queue :skull:
    	public Onomatopoeia 擬音;
    	public Queue<Action<Are>> 擬音キュー = new Queue<Action<Are>>();

        //animation queue?
        public List<挿入処理> SubFocus = new List<挿入処理>();

        private MouseButtons HeldButton;

    	public double X;
    	public double Y;


    	public Color 羽根箒先端hc
    	{
    		get
    		{
    			Par x0Y0_羽根 = 羽根箒.X0Y0_羽根1;
    			return Med.GetHitColor(Med.FromBasePosition(x0Y0_羽根.ToGlobal(x0Y0_羽根.JP[1].Joint)));
    		}
    	}

    	public bool Is挿入
    	{
    		get
    		{
    			if ((focus != ペニスCM || !ペニス挿入.Is挿入) && (focus != マウスCM || !マウス挿入.Is挿入) && (focus != ハンド右CM || !ハンド挿入.Is挿入) && (focus != ロータCM || !ロータ挿入.Is挿入) && (focus != コモンCM || !コモン挿入.Is挿入) && (focus != ディルCM || !ディル挿入.Is挿入) && (focus != アナルCM || !アナル挿入.Is挿入) && (focus != デンマCM || !デンマ挿入.Is挿入) && (focus != ドリルCM || !ドリル挿入.Is挿入))
    			{
    				if (focus == パールCM)
    				{
    					return パール挿入.Is挿入;
    				}
    				return false;
    			}
    			return true;
    		}
    	}

    	public bool Is脚修正1
    	{
    		get
    		{
    			if (!ペニス挿入.Is膣 && !ペニス挿入.Is肛 && !ペニス挿入.Is糸 && !マウス挿入.Is膣 && !マウス挿入.Is肛 && !マウス挿入.Is糸 && !ハンド挿入.Is膣 && !ハンド挿入.Is肛 && !ハンド挿入.Is糸 && !ロータ挿入.Is膣 && !ロータ挿入.Is肛 && !ロータ挿入.Is糸 && !コモン挿入.Is膣 && !コモン挿入.Is肛 && !コモン挿入.Is糸 && !ディル挿入.Is膣 && !ディル挿入.Is肛 && !ディル挿入.Is糸 && !アナル挿入.Is膣 && !アナル挿入.Is肛 && !アナル挿入.Is糸 && !デンマ挿入.Is膣 && !デンマ挿入.Is肛 && !デンマ挿入.Is糸 && !ドリル挿入.Is膣 && !ドリル挿入.Is肛 && !ドリル挿入.Is糸 && !パール挿入.Is膣 && !パール挿入.Is肛 && !パール挿入.Is糸 && !ハンド処理.Isくぱぁ && !Player.Is性器接触)
    			{
    				return Cha.Is放尿();
    			}
    			return true;
    		}
    	}

    	public bool Is脚修正2
    	{
    		get
    		{
    			if (!ペニス処理.Isパイズリ && !ハンド処理.Is乳繰り && !ハンド処理.Is乳摘み && !ハンド処理.Is乳捏ね && !ペニス処理.手コキ.Run)
    			{
    				return Player.CurrentContactType == ContactType.Milk;
    			}
    			return true;
    		}
    	}

    	public bool Isモード
    	{
    		get
    		{
    			if (!Is挿入 && (focus != ハンド右CM || !ハンド処理.Isモード) && (focus != マウスCM || !マウス処理.Isモード) && (focus != ペニスCM || !ペニス処理.Isパイズリ))
    			{
    				return コキ;
    			}
    			return true;
    		}
    	}

    	public bool コキ
    	{
    		get
    		{
    			return コキ_;
    		}
    		set
    		{
    			コキ_ = value;
    			ペニスCM.Under = value;
    		}
    	}

    	public CM Focus
    	{
    		get
    		{
    			return focus;
    		}
    		set
    		{
    			FocusReset();
    			Focus_nr = value;
    			if (Med.Mode == "Training" && Cha != null && Cha.ChaD.Lust > 0.5 && RNG.XS.NextBool())
    			{
    				Cha.EyeTracking.Start();
    			}
    		}
    	}

    	public CM Focus_nr
    	{
    		get
    		{
    			return focus;
    		}
    		set
    		{
    			focus = value;
    			focus.StaShow = false;
    			focus.使用状態 = UsageStatus.InUse;
    			focus.Ele.濃度 = 1.0;
    			if (focus == 羽根箒CM)
    			{
    				羽根箒.角度B = -90.0;
    			}
    		}
    	}

    	public bool 持ち手
    	{
    		get
    		{
    			return 持ち手_;
    		}
    		set
    		{
    			持ち手_ = value;
    			if (持ち手_)
    			{
    				ハンド右.SetHitFalse();
    				ハンド右CM.使用状態 = UsageStatus.InUse;
    			}
    			else if (Focus != ハンド右CM)
    			{
    				ハンド右.SetHitTrue();
    				ハンド右CM.使用状態 = UsageStatus.Standby;
    			}
    		}
    	}

    	public bool Is乳弄り
    	{
    		get
    		{
    			if (!ハンド処理.Is乳捏ね && !ハンド処理.Is乳摘み && !ハンド処理.Is乳繰り && (!ペニス処理.Isパイズリ || ペニス処理.Isパイズリ他動) && !ハンド処理.Is核捏ね)
    			{
    				return ハンド挿入.Is膣;
    			}
    			return true;
    		}
    	}

    	public bool Is口挿入
    	{
    		get
    		{
    			if (!ペニス挿入.Is口 && !マウス挿入.Is口 && !ハンド挿入.Is口 && !ロータ挿入.Is口 && !コモン挿入.Is口 && !ディル挿入.Is口 && !アナル挿入.Is口 && !デンマ挿入.Is口 && !ドリル挿入.Is口)
    			{
    				return パール挿入.Is口;
    			}
    			return true;
    		}
    	}

    	public bool Is膣挿入
    	{
    		get
    		{
    			if (!ペニス挿入.Is膣 && !マウス挿入.Is膣 && !ハンド挿入.Is膣 && !ロータ挿入.Is膣 && !コモン挿入.Is膣 && !ディル挿入.Is膣 && !アナル挿入.Is膣 && !デンマ挿入.Is膣 && !ドリル挿入.Is膣)
    			{
    				return パール挿入.Is膣;
    			}
    			return true;
    		}
    	}

    	public bool Is肛挿入
    	{
    		get
    		{
    			if (!ペニス挿入.Is肛 && !マウス挿入.Is肛 && !ハンド挿入.Is肛 && !ロータ挿入.Is肛 && !コモン挿入.Is肛 && !ディル挿入.Is肛 && !アナル挿入.Is肛 && !デンマ挿入.Is肛 && !ドリル挿入.Is肛)
    			{
    				return パール挿入.Is肛;
    			}
    			return true;
    		}
    	}

    	public bool Is糸挿入
    	{
    		get
    		{
    			if (!ペニス挿入.Is糸 && !マウス挿入.Is糸 && !ハンド挿入.Is糸 && !ロータ挿入.Is糸 && !コモン挿入.Is糸 && !ディル挿入.Is糸 && !アナル挿入.Is糸 && !デンマ挿入.Is糸 && !ドリル挿入.Is糸)
    			{
    				return パール挿入.Is糸;
    			}
    			return true;
    		}
    	}

    	public bool Isフォーカス糸挿入
    	{
    		get
    		{
    			if ((focus != ペニスCM || !ペニス挿入.Is糸) && (focus != マウスCM || !マウス挿入.Is糸) && (focus != ハンド右CM || !ハンド挿入.Is糸) && (focus != ロータCM || !ロータ挿入.Is糸) && (focus != コモンCM || !コモン挿入.Is糸) && (focus != ディルCM || !ディル挿入.Is糸) && (focus != アナルCM || !アナル挿入.Is糸) && (focus != デンマCM || !デンマ挿入.Is糸) && (focus != ドリルCM || !ドリル挿入.Is糸))
    			{
    				if (focus == パールCM)
    				{
    					return パール挿入.Is糸;
    				}
    				return false;
    			}
    			return true;
    		}
    	}

    	public bool IsSub糸挿入 => SubFocus.Any((挿入処理 e) => e.Is糸);

    	public bool Isフォーカス膣肛挿入
    	{
    		get
    		{
    			if ((focus != ペニスCM || (!ペニス挿入.Is膣 && !ペニス挿入.Is肛)) && (focus != マウスCM || (!マウス挿入.Is膣 && !マウス挿入.Is肛)) && (focus != ハンド右CM || (!ハンド挿入.Is膣 && !ハンド挿入.Is肛)) && (focus != ロータCM || (!ロータ挿入.Is膣 && !ロータ挿入.Is肛)) && (focus != コモンCM || (!コモン挿入.Is膣 && !コモン挿入.Is肛)) && (focus != ディルCM || (!ディル挿入.Is膣 && !ディル挿入.Is肛)) && (focus != アナルCM || (!アナル挿入.Is膣 && !アナル挿入.Is肛)) && (focus != デンマCM || (!デンマ挿入.Is膣 && !デンマ挿入.Is肛)) && (focus != ドリルCM || (!ドリル挿入.Is膣 && !ドリル挿入.Is肛)))
    			{
    				if (focus == パールCM)
    				{
    					if (!パール挿入.Is膣)
    					{
    						return パール挿入.Is肛;
    					}
    					return true;
    				}
    				return false;
    			}
    			return true;
    		}
    	}



    	public void 発音(Vector2D p, string s, Color c, double d, bool b)
    	{
    		擬音キュー.Enqueue(delegate(Are a)
    		{
    			擬音.Sound(a, p, s, new Font("MS Gothic", 1f), c, d, b);
    		});
    	}

    	public void 潮吹()
    	{
    		擬音キュー.Enqueue(delegate(Are a)
    		{
    			擬音.Sound(a, Bod.尿道位置.GetAreaPoint(0.04), Sta.潮吹.GetVal(Player.変化V_潮吹, Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.Azure, 0.2 + 0.2 * RNG.XS.NextDouble() * Player.変化V_潮吹, b: true);
    		});
    	}

    	public void 放尿()
    	{
    		if (CP.GetFlag(0.1 + 0.1 * Player.変化V_放尿 * 0.8))
    		{
    			擬音キュー.Enqueue(delegate(Are a)
    			{
    				擬音.Sound(a, Bod.尿道位置.GetAreaPoint(0.04), Sta.放尿.GetVal(Player.変化V_放尿, Player.変化V_固有値乱数), new Font("MS Gothic", 1f), Col.Black, 0.2 + 0.2 * RNG.XS.NextDouble() * Player.変化V_放尿, b: true);
    			});
    		}
    	}

    	public void 口腔演出()
    	{
    	}

    	public void 肌体演出()
    	{
    	}

    	public void 乳房演出()
    	{
    	}

    	public void 乳首演出()
    	{
    	}

    	public void 陰核演出()
    	{
    	}

    	public void 膣腔演出()
    	{
    	}

    	public void 肛門演出()
    	{
    	}

    	public void 出糸演出()
    	{
    	}

    	public IEnumerable<CM> EnumCM()
    	{
    		yield return ペニスCM;
    		yield return マウスCM;
    		yield return ハンド右CM;
    		yield return ロータCM;
    		yield return コモンCM;
    		yield return ディルCM;
    		yield return アナルCM;
    		yield return デンマCM;
    		yield return ドリルCM;
    		yield return パールCM;
    		yield return 羽根箒CM;
    		yield return 調教鞭CM;
    		yield return T剃刀CM;
    		yield return キャップ1CM;
    		yield return キャップ2CM;
    		yield return キャップ3CM;
    	}

    	public void Set挿入Position()
    	{
    		ペニス挿入.SetPosition();
    		マウス挿入.SetPosition();
    		ハンド挿入.SetPosition();
    		ロータ挿入.SetPosition();
    		コモン挿入.SetPosition();
    		ディル挿入.SetPosition();
    		アナル挿入.SetPosition();
    		デンマ挿入.SetPosition();
    		ドリル挿入.SetPosition();
    		パール挿入.SetPosition();
    	}

    	private void Set_ペニス(Ele t)
    	{
    		t.位置B = ペニス.AreM.Position;
    	}

    	private void Set_ロータ(Ele t)
    	{
    		switch (ロータ.Yi)
    		{
    		case 0:
    			t.位置B = ロータ.X0Y0_ロータ.ToGlobal_nc(ロータ.X0Y0_ロータ.JP[1].Joint.AddY(0.004));
    			break;
    		case 1:
    			t.位置B = ロータ.X0Y1_ロータ.ToGlobal_nc(ロータ.X0Y1_ロータ.JP[1].Joint.AddY(0.004));
    			break;
    		case 2:
    			t.位置B = ロータ.X0Y2_ロータ.ToGlobal_nc(ロータ.X0Y2_ロータ.JP[1].Joint.AddY(0.004));
    			break;
    		case 3:
    			t.位置B = ロータ.X0Y3_ロータ.ToGlobal_nc(ロータ.X0Y3_ロータ.JP[0].Joint.AddY(0.004));
    			break;
    		default:
    			t.位置B = ロータ.X0Y4_ロータ.ToGlobal_nc(ロータ.X0Y4_ロータ.JP[0].Joint.AddY(0.004));
    			break;
    		}
    	}

    	private void Set_コモン(Ele t)
    	{
    		switch (コモン.Yi)
    		{
    		case 0:
    			t.位置B = コモン.X0Y0_ユニット_ユニット.ToGlobal_nc(コモン.X0Y0_ユニット_ユニット.JP[6].Joint);
    			break;
    		case 1:
    			t.位置B = コモン.X0Y1_ユニット_ユニット.ToGlobal_nc(コモン.X0Y1_ユニット_ユニット.JP[6].Joint);
    			break;
    		case 2:
    			t.位置B = コモン.X0Y2_ユニット_ユニット.ToGlobal_nc(コモン.X0Y2_ユニット_ユニット.JP[6].Joint);
    			break;
    		case 3:
    			t.位置B = コモン.X0Y3_ユニット_ユニット.ToGlobal_nc(コモン.X0Y3_ユニット_ユニット.JP[6].Joint);
    			break;
    		default:
    			t.位置B = コモン.X0Y4_ユニット_ユニット.ToGlobal_nc(コモン.X0Y4_ユニット_ユニット.JP[6].Joint);
    			break;
    		}
    	}

    	private void Set_ディル(Ele t)
    	{
    		switch (ディル.Yi)
    		{
    		case 0:
    			t.位置B = ディル.X0Y0_ユニット_ユニット.ToGlobal_nc(ディル.X0Y0_ユニット_ユニット.JP[6].Joint);
    			break;
    		case 1:
    			t.位置B = ディル.X0Y1_ユニット_ユニット.ToGlobal_nc(ディル.X0Y1_ユニット_ユニット.JP[6].Joint);
    			break;
    		case 2:
    			t.位置B = ディル.X0Y2_ユニット_ユニット.ToGlobal_nc(ディル.X0Y2_ユニット_ユニット.JP[6].Joint);
    			break;
    		case 3:
    			t.位置B = ディル.X0Y3_ユニット_ユニット.ToGlobal_nc(ディル.X0Y3_ユニット_ユニット.JP[6].Joint);
    			break;
    		default:
    			t.位置B = ディル.X0Y4_ユニット_ユニット.ToGlobal_nc(ディル.X0Y4_ユニット_ユニット.JP[6].Joint);
    			break;
    		}
    	}

    	private void Set_アナル(Ele t)
    	{
    		switch (アナル.Yi)
    		{
    		case 0:
    			t.位置B = アナル.X0Y0_ユニット_ユニット.ToGlobal_nc(アナル.X0Y0_ユニット_ユニット.JP[6].Joint);
    			break;
    		case 1:
    			t.位置B = アナル.X0Y1_ユニット_ユニット.ToGlobal_nc(アナル.X0Y1_ユニット_ユニット.JP[6].Joint);
    			break;
    		case 2:
    			t.位置B = アナル.X0Y2_ユニット_ユニット.ToGlobal_nc(アナル.X0Y2_ユニット_ユニット.JP[6].Joint);
    			break;
    		case 3:
    			t.位置B = アナル.X0Y3_ユニット_ユニット.ToGlobal_nc(アナル.X0Y3_ユニット_ユニット.JP[6].Joint);
    			break;
    		default:
    			t.位置B = アナル.X0Y4_ユニット_ユニット.ToGlobal_nc(アナル.X0Y4_ユニット_ユニット.JP[6].Joint);
    			break;
    		}
    	}

    	private void Set_デンマ(Ele t)
    	{
    		switch (デンマ.Yi)
    		{
    		case 0:
    			t.位置B = デンマ.X0Y0_ユニット_ユニット.ToGlobal_nc(デンマ.X0Y0_ユニット_ユニット.JP[6].Joint);
    			break;
    		case 1:
    			t.位置B = デンマ.X0Y1_ユニット_ユニット.ToGlobal_nc(デンマ.X0Y1_ユニット_ユニット.JP[6].Joint);
    			break;
    		case 2:
    			t.位置B = デンマ.X0Y2_ユニット_ユニット.ToGlobal_nc(デンマ.X0Y2_ユニット_ユニット.JP[6].Joint);
    			break;
    		case 3:
    			t.位置B = デンマ.X0Y3_ユニット_ユニット.ToGlobal_nc(デンマ.X0Y3_ユニット_ユニット.JP[6].Joint);
    			break;
    		default:
    			t.位置B = デンマ.X0Y4_ユニット_ユニット.ToGlobal_nc(デンマ.X0Y4_ユニット_ユニット.JP[6].Joint);
    			break;
    		}
    	}

    	private void Set_ドリル(Ele t)
    	{
    		switch (ドリル.Xi)
    		{
    		case 0:
    			switch (ドリル.Yi)
    			{
    			case 0:
    				t.位置B = ドリル.X0Y0_ユニット_ユニット.ToGlobal_nc(ドリル.X0Y0_ユニット_ユニット.JP[6].Joint);
    				break;
    			case 1:
    				t.位置B = ドリル.X0Y1_ユニット_ユニット.ToGlobal_nc(ドリル.X0Y1_ユニット_ユニット.JP[6].Joint);
    				break;
    			case 2:
    				t.位置B = ドリル.X0Y2_ユニット_ユニット.ToGlobal_nc(ドリル.X0Y2_ユニット_ユニット.JP[6].Joint);
    				break;
    			case 3:
    				t.位置B = ドリル.X0Y3_ユニット_ユニット.ToGlobal_nc(ドリル.X0Y3_ユニット_ユニット.JP[6].Joint);
    				break;
    			default:
    				t.位置B = ドリル.X0Y4_ユニット_ユニット.ToGlobal_nc(ドリル.X0Y4_ユニット_ユニット.JP[6].Joint);
    				break;
    			}
    			break;
    		case 1:
    			switch (ドリル.Yi)
    			{
    			case 0:
    				t.位置B = ドリル.X1Y0_ユニット_ユニット.ToGlobal_nc(ドリル.X1Y0_ユニット_ユニット.JP[6].Joint);
    				break;
    			case 1:
    				t.位置B = ドリル.X1Y1_ユニット_ユニット.ToGlobal_nc(ドリル.X1Y1_ユニット_ユニット.JP[6].Joint);
    				break;
    			case 2:
    				t.位置B = ドリル.X1Y2_ユニット_ユニット.ToGlobal_nc(ドリル.X1Y2_ユニット_ユニット.JP[6].Joint);
    				break;
    			case 3:
    				t.位置B = ドリル.X1Y3_ユニット_ユニット.ToGlobal_nc(ドリル.X1Y3_ユニット_ユニット.JP[6].Joint);
    				break;
    			default:
    				t.位置B = ドリル.X1Y4_ユニット_ユニット.ToGlobal_nc(ドリル.X1Y4_ユニット_ユニット.JP[6].Joint);
    				break;
    			}
    			break;
    		default:
    			switch (ドリル.Yi)
    			{
    			case 0:
    				t.位置B = ドリル.X2Y0_ユニット_ユニット.ToGlobal_nc(ドリル.X2Y0_ユニット_ユニット.JP[6].Joint);
    				break;
    			case 1:
    				t.位置B = ドリル.X2Y1_ユニット_ユニット.ToGlobal_nc(ドリル.X2Y1_ユニット_ユニット.JP[6].Joint);
    				break;
    			case 2:
    				t.位置B = ドリル.X2Y2_ユニット_ユニット.ToGlobal_nc(ドリル.X2Y2_ユニット_ユニット.JP[6].Joint);
    				break;
    			case 3:
    				t.位置B = ドリル.X2Y3_ユニット_ユニット.ToGlobal_nc(ドリル.X2Y3_ユニット_ユニット.JP[6].Joint);
    				break;
    			default:
    				t.位置B = ドリル.X2Y4_ユニット_ユニット.ToGlobal_nc(ドリル.X2Y4_ユニット_ユニット.JP[6].Joint);
    				break;
    			}
    			break;
    		}
    	}

    	private void Set_パール(Ele t)
    	{
    		switch (パール.Yi)
    		{
    		case 0:
    			t.位置B = パール.X0Y0_輪下.ToGlobal_nc(パール.X0Y0_輪下.JP[0].Joint);
    			break;
    		case 1:
    			t.位置B = パール.X0Y1_輪下.ToGlobal_nc(パール.X0Y1_輪下.JP[0].Joint);
    			break;
    		case 2:
    			t.位置B = パール.X0Y2_輪下.ToGlobal_nc(パール.X0Y2_輪下.JP[0].Joint);
    			break;
    		case 3:
    			t.位置B = パール.X0Y3_輪下.ToGlobal_nc(パール.X0Y3_輪下.JP[0].Joint);
    			break;
    		case 4:
    			t.位置B = パール.X0Y4_輪下.ToGlobal_nc(パール.X0Y4_輪下.JP[0].Joint);
    			break;
    		case 5:
    			t.位置B = パール.X0Y5_輪下.ToGlobal_nc(パール.X0Y5_輪下.JP[0].Joint);
    			break;
    		case 6:
    			t.位置B = パール.X0Y6_輪下.ToGlobal_nc(パール.X0Y6_輪下.JP[0].Joint);
    			break;
    		case 7:
    			t.位置B = パール.X0Y7_輪下.ToGlobal_nc(パール.X0Y7_輪下.JP[0].Joint);
    			break;
    		case 8:
    			t.位置B = パール.X0Y8_輪下.ToGlobal_nc(パール.X0Y8_輪下.JP[0].Joint);
    			break;
    		case 9:
    			t.位置B = パール.X0Y9_輪下.ToGlobal_nc(パール.X0Y9_輪下.JP[0].Joint);
    			break;
    		case 10:
    			t.位置B = パール.X0Y10_輪下.ToGlobal_nc(パール.X0Y10_輪下.JP[0].Joint);
    			break;
    		case 11:
    			t.位置B = パール.X0Y11_輪下.ToGlobal_nc(パール.X0Y11_輪下.JP[0].Joint);
    			break;
    		case 12:
    			t.位置B = パール.X0Y12_輪下.ToGlobal_nc(パール.X0Y12_輪下.JP[0].Joint);
    			break;
    		case 13:
    			t.位置B = パール.X0Y13_輪下.ToGlobal_nc(パール.X0Y13_輪下.JP[0].Joint);
    			break;
    		case 14:
    			t.位置B = パール.X0Y14_輪下.ToGlobal_nc(パール.X0Y14_輪下.JP[0].Joint);
    			break;
    		case 15:
    			t.位置B = パール.X0Y15_輪下.ToGlobal_nc(パール.X0Y15_輪下.JP[0].Joint);
    			break;
    		default:
    			t.位置B = パール.X0Y16_輪下.ToGlobal_nc(パール.X0Y16_輪下.JP[0].Joint);
    			break;
    		}
    	}

    	private void Set_羽根箒(Ele t)
    	{
    		t.位置B = 羽根箒.X0Y0_柄.ToGlobal_nc(羽根箒.X0Y0_柄.JP[1].Joint);
    		t.角度C = 羽根箒.X0Y0_柄.Angle;
    	}

    	private void Set_調教鞭(Ele t)
    	{
    		int num = -45;
    		if (調教鞭.Xi == 0)
    		{
    			switch (調教鞭.Yi)
    			{
    			case 0:
    				t.位置B = 調教鞭.X0Y0_柄.ToGlobal_nc(調教鞭.X0Y0_柄.JP[1].Joint);
    				t.角度C = 調教鞭.X0Y0_柄.Angle;
    				break;
    			case 1:
    				t.位置B = 調教鞭.X0Y1_柄.ToGlobal_nc(調教鞭.X0Y1_柄.JP[1].Joint);
    				t.角度C = 調教鞭.X0Y1_柄.Angle;
    				break;
    			case 2:
    				t.位置B = 調教鞭.X0Y2_柄.ToGlobal_nc(調教鞭.X0Y2_柄.JP[1].Joint);
    				t.角度C = 調教鞭.X0Y2_柄.Angle;
    				break;
    			case 3:
    				t.位置B = 調教鞭.X0Y3_柄.ToGlobal_nc(調教鞭.X0Y3_柄.JP[1].Joint);
    				t.角度C = 調教鞭.X0Y3_柄.Angle;
    				break;
    			default:
    				t.位置B = 調教鞭.X0Y4_柄.ToGlobal_nc(調教鞭.X0Y4_柄.JP[1].Joint);
    				t.角度C = 調教鞭.X0Y4_柄.Angle;
    				break;
    			}
    		}
    		else if (調教鞭.Yi == 0)
    		{
    			t.位置B = 調教鞭.X1Y0_柄.ToGlobal_nc(調教鞭.X1Y0_柄.JP[1].Joint);
    			t.角度C = (double)((調教鞭.Xi != 0) ? num : 0) + 調教鞭.X0Y0_柄.Angle;
    		}
    		else
    		{
    			t.位置B = 調教鞭.X1Y4_柄.ToGlobal_nc(調教鞭.X1Y4_柄.JP[1].Joint);
    			t.角度C = (double)((調教鞭.Xi != 0) ? (-num) : 0) + 調教鞭.X0Y4_柄.Angle;
    		}
    	}

    	private void Set_T剃刀(Ele t)
    	{
    		t.位置B = T剃刀.X0Y0_グリップ_グリップ4.ToGlobal_nc(T剃刀.X0Y0_グリップ_グリップ4.JP[0].Joint);
    		t.角度C = T剃刀.X0Y0_グリップ_グリップ4.Angle;
    	}

    	public void Set_キャップ1(Ele t)
    	{
    		t.位置B = キャップ1.X0Y0_先端.ToGlobal_nc(キャップ1.X0Y0_先端.JP[0].Joint);
    	}

    	public void Set_キャップ2(Ele t)
    	{
    		t.位置B = キャップ2.X0Y0_先端.ToGlobal_nc(キャップ2.X0Y0_先端.JP[0].Joint);
    	}

    	public void Set_キャップ3(Ele t)
    	{
    		t.位置B = キャップ3.X0Y0_先端.ToGlobal_nc(キャップ3.X0Y0_先端.JP[0].Joint);
    	}

    	public void Set_キャップ左(Ele t)
    	{
    		キャップ2 キャップ2左 = Bod.キャップ2左;
    		t.位置B = キャップ2左.X0Y0_先端.ToGlobal_nc(キャップ2左.X0Y0_先端.JP[0].Joint);
    	}

    	public void Set_キャップ右(Ele t)
    	{
    		キャップ2 キャップ2右 = Bod.キャップ2右;
    		t.位置B = キャップ2右.X0Y0_先端.ToGlobal_nc(キャップ2右.X0Y0_先端.JP[0].Joint);
    	}

    	public void Set_キャップ中(Ele t)
    	{
    		キャップ1 キャップ3 = Bod.キャップ1;
    		t.位置B = キャップ3.X0Y0_先端.ToGlobal_nc(キャップ3.X0Y0_先端.JP[0].Joint);
    	}

    	public void Set_口(Ele t)
    	{
    		Par par = Bod.口.本体.Current.EnumAllPar().First((Par e) => e.Tag == "口");
    		Bod.口.接続PA();
    		t.位置B = par.Position;
    	}

    	public void Set_乳首(Ele t, bool 右)
    	{
    		乳房 乳房2 = (右 ? Bod.乳房右 : Bod.乳房左);
    		乳房2.接続PA();
    		switch (乳房2.Yi)
    		{
    		case 0:
    			t.位置B = 乳房2.X0Y0_乳首.ToGlobal_nc(乳房2.X0Y0_乳首.JP[0].Joint);
    			break;
    		case 1:
    			t.位置B = 乳房2.X0Y1_乳首.ToGlobal_nc(乳房2.X0Y1_乳首.JP[0].Joint);
    			break;
    		case 2:
    			t.位置B = 乳房2.X0Y2_乳首.ToGlobal_nc(乳房2.X0Y2_乳首.JP[0].Joint);
    			break;
    		case 3:
    			t.位置B = 乳房2.X0Y3_乳首.ToGlobal_nc(乳房2.X0Y3_乳首.JP[0].Joint);
    			break;
    		default:
    			t.位置B = 乳房2.X0Y4_乳首.ToGlobal_nc(乳房2.X0Y4_乳首.JP[0].Joint);
    			break;
    		}
    	}

    	public void Set_乳房(Ele t, bool 右)
    	{
    		乳房 乳房2 = (右 ? Bod.乳房右 : Bod.乳房左);
    		乳房2.接続PA();
    		switch (乳房2.Yi)
    		{
    		case 0:
    			t.位置B = 乳房2.X0Y0_乳房.ToGlobal_nc(乳房2.X0Y0_乳房.OP.GetCenter());
    			break;
    		case 1:
    			t.位置B = 乳房2.X0Y1_乳房.ToGlobal_nc(乳房2.X0Y1_乳房.OP.GetCenter());
    			break;
    		case 2:
    			t.位置B = 乳房2.X0Y2_乳房.ToGlobal_nc(乳房2.X0Y2_乳房.OP.GetCenter());
    			break;
    		case 3:
    			t.位置B = 乳房2.X0Y3_乳房.ToGlobal_nc(乳房2.X0Y3_乳房.OP.GetCenter());
    			break;
    		default:
    			t.位置B = 乳房2.X0Y4_乳房.ToGlobal_nc(乳房2.X0Y4_乳房.OP.GetCenter());
    			break;
    		}
    	}

    	public void Set_陰核(Ele t)
    	{
    		Par par = Bod.性器.本体.Current.EnumAllPar().First((Par e) => e.Tag == "陰核");
    		Bod.性器.接続PA();
    		t.位置B = par.Position;
    	}

    	public void Set_膣口(Ele t)
    	{
    		Par par = Bod.性器.本体.Current.EnumAllPar().First((Par e) => e.Tag == "膣口");
    		Bod.性器.接続PA();
    		t.位置B = par.Position;
    	}

    	public void Set_肛門(Ele t)
    	{
    		Bod.肛門.接続PA();
    		t.位置B = Bod.肛門.位置;
    	}

    	public void Set_出糸(Ele t)
    	{
    		Bod.蜘尾.接続PA();
    		t.位置B = Bod.蜘尾.X0Y0_出糸突起後_出糸突起基.Position;
    	}

    	public void Set_くぱぁ(Ele t, bool 右)
    	{
    		Par par = (Bod.Is獣 ? Bod.腰_獣.本体.Current.EnumAllPar().First((Par e) => e.Tag == "股") : Bod.腰.本体.Current.EnumAllPar().First((Par e) => e.Tag == "股"));
    		Bod.腰.接続PA();
    		if (右)
    		{
    			t.位置B = par.Position.AddXY(0.018, 0.002);
    		}
    		else
    		{
    			t.位置B = par.Position.AddXY(-0.018, 0.002);
    		}
    	}

    	public bool IsHitCha(ref ContactD cd)
    	{
    		return cd.e != null;
    	}

    	public bool Isバイブ(CM cm)
    	{
    		if (コモンCM != cm && ディルCM != cm && アナルCM != cm && デンマCM != cm)
    		{
    			return ドリルCM == cm;
    		}
    		return true;
    	}

    	public 挿入処理 Get挿入処理()
    	{
    		if (Focus == ペニスCM)
    		{
    			return ペニス挿入;
    		}
    		if (Focus == マウスCM)
    		{
    			return マウス挿入;
    		}
    		if (Focus == ハンド右CM)
    		{
    			return ハンド挿入;
    		}
    		if (Focus == ロータCM)
    		{
    			return ロータ挿入;
    		}
    		if (Focus == コモンCM)
    		{
    			return コモン挿入;
    		}
    		if (Focus == ディルCM)
    		{
    			return ディル挿入;
    		}
    		if (Focus == アナルCM)
    		{
    			return アナル挿入;
    		}
    		if (Focus == デンマCM)
    		{
    			return デンマ挿入;
    		}
    		if (Focus == ドリルCM)
    		{
    			return ドリル挿入;
    		}
    		if (Focus == パールCM)
    		{
    			return パール挿入;
    		}
    		return null;
    	}

    	private 挿入処理 Get挿入処理(ref Color hc)
    	{
    		if (ペニス.本体.IsHit(ref hc))
    		{
    			return ペニス挿入;
    		}
    		if (マウス.本体.IsHit(ref hc))
    		{
    			return マウス挿入;
    		}
    		if (ハンド右.本体.IsHit(ref hc))
    		{
    			return ハンド挿入;
    		}
    		if (ロータ.本体.IsHit(ref hc))
    		{
    			return ロータ挿入;
    		}
    		if (コモン.本体.IsHit(ref hc))
    		{
    			return コモン挿入;
    		}
    		if (ディル.本体.IsHit(ref hc))
    		{
    			return ディル挿入;
    		}
    		if (アナル.本体.IsHit(ref hc))
    		{
    			return アナル挿入;
    		}
    		if (デンマ.本体.IsHit(ref hc))
    		{
    			return デンマ挿入;
    		}
    		if (ドリル.本体.IsHit(ref hc))
    		{
    			return ドリル挿入;
    		}
    		if (パール.本体.IsHit(ref hc))
    		{
    			return パール挿入;
    		}
    		return null;
    	}

    	public void FocusReset()
    	{
    		if (focus == ロータ挿入.対象)
    		{
    			ロータ挿入.振動 = false;
    		}
    		else if (focus == コモン挿入.対象)
    		{
    			コモン挿入.振動 = false;
    		}
    		else if (focus == ディル挿入.対象)
    		{
    			ディル挿入.振動 = false;
    		}
    		else if (focus == アナル挿入.対象)
    		{
    			アナル挿入.振動 = false;
    		}
    		else if (focus == デンマ挿入.対象)
    		{
    			デンマ挿入.振動 = false;
    		}
    		else if (focus == ドリル挿入.対象)
    		{
    			ドリル挿入.振動 = false;
    			ドリル挿入.回転 = false;
    		}
    		ペニス処理.選択 = false;
    		マウス処理.選択 = false;
    		ハンド処理.選択 = false;
    		ペニス挿入.選択 = false;
    		マウス挿入.選択 = false;
    		ハンド挿入.選択 = false;
    		ロータ挿入.選択 = false;
    		コモン挿入.選択 = false;
    		ディル挿入.選択 = false;
    		アナル挿入.選択 = false;
    		デンマ挿入.選択 = false;
    		ドリル挿入.選択 = false;
    		パール挿入.選択 = false;
    		キャップ処理.選択 = false;
    		羽箒処理.選択 = false;
    		剃刀処理.選択 = false;
    		調鞭処理.選択 = false;
    		放し();
    		focus.StaShow = true;
    		focus.使用状態 = UsageStatus.Standby;
    		focus.Ele.Xi = 0;
    		focus.Ele.Yi = 0;
    		focus.Ele.位置B = focus.bp;
    		focus.Ele.位置C = Dat.Vec2DZero;
    		focus.Ele.角度B = 0.0;
    		focus.Ele.角度C = 0.0;
    		focus.Ele.右 = false;
    		if (focus == 調教鞭CM)
    		{
    			調教鞭.Yi = 2;
    			focus.Ele.角度C = 0.0;
    		}
    		focus.Ele.本体.JoinPAall();
    	}

    	public void Set持ち手()
    	{
    		if (focus == ペニスCM || focus == マウスCM || focus == ハンド右CM)
    		{
    			持ち手 = false;
    			ハンド右.位置C = Dat.Vec2DZero;
    			ハンド右.角度B = 0.0;
    			ハンド右.角度C = 0.0;
    			ハンド右.Xi = 0;
    			ハンド右.Yi = 0;
    			ハンド右.本体.JoinPA();
    			return;
    		}
    		持ち手 = true;
    		ハンド右.位置C = Dat.Vec2DZero;
    		ハンド右.角度B = 0.0;
    		ハンド右.角度C = 0.0;
    		if (focus == コモンCM || focus == ディルCM || focus == アナルCM || focus == デンマCM || focus == ドリルCM)
    		{
    			ハンド右.Xi = 13;
    		}
    		else if (focus == ロータCM || focus == パールCM || focus == 羽根箒CM || focus == 調教鞭CM || focus == T剃刀CM)
    		{
    			ハンド右.Xi = 11;
    		}
    		else if (focus == キャップ1CM)
    		{
    			ハンド右.Xi = 5;
    			Set_キャップ1(ハンド右);
    		}
    		else if (focus == キャップ2CM)
    		{
    			ハンド右.Xi = 5;
    			Set_キャップ2(ハンド右);
    		}
    		else if (focus == キャップ3CM)
    		{
    			ハンド右.Xi = 5;
    			Set_キャップ3(ハンド右);
    		}
    		ハンド右.本体.JoinPA();
    	}

    	public void Joi持ち手()
    	{
    		if (持ち手)
    		{
    			if (focus == ペニスCM)
    			{
    				Set_ペニス(ハンド右);
    				ハンド右.角度C = 0.0 - ハンド右.角度C;
    			}
    			else if (focus == ロータCM)
    			{
    				Set_ロータ(ハンド右);
    			}
    			else if (focus == コモンCM)
    			{
    				Set_コモン(ハンド右);
    			}
    			else if (focus == ディルCM)
    			{
    				Set_ディル(ハンド右);
    			}
    			else if (focus == アナルCM)
    			{
    				Set_アナル(ハンド右);
    			}
    			else if (focus == デンマCM)
    			{
    				Set_デンマ(ハンド右);
    			}
    			else if (focus == ドリルCM)
    			{
    				Set_ドリル(ハンド右);
    			}
    			else if (focus == パールCM)
    			{
    				Set_パール(ハンド右);
    			}
    			else if (focus == 羽根箒CM)
    			{
    				Set_羽根箒(ハンド右);
    			}
    			else if (focus == 調教鞭CM)
    			{
    				Set_調教鞭(ハンド右);
    			}
    			else if (focus == T剃刀CM)
    			{
    				Set_T剃刀(ハンド右);
    			}
    			else if (Focus == キャップ1CM)
    			{
    				Set_キャップ1(ハンド右);
    			}
    			else if (Focus == キャップ2CM)
    			{
    				Set_キャップ2(ハンド右);
    			}
    			else if (Focus == キャップ3CM)
    			{
    				Set_キャップ3(ハンド右);
    			}
    		}
    	}

    	public void In持ち手()
    	{
    		if (持ち手)
    		{
    			ハンド右.濃度 = 0.2;
    		}
    	}

    	public void Out持ち手()
    	{
    		if (持ち手)
    		{
    			ハンド右.濃度 = 1.0;
    		}
    	}

    	public void 持ち手下描画()
    	{
    		if (持ち手)
    		{
    			Joi持ち手();
    			ハンド右.本体.JoinPA();
    			ハンド右.色更新();
    			if (ハンド右.Xi == 11)
    			{
    				Are.Draw(ハンド右.X11Y0_小指);
    				Are.Draw(ハンド右.X11Y0_薬指);
    				Are.Draw(ハンド右.X11Y0_中指);
    				Are.Draw(ハンド右.X11Y0_人指);
    			}
    		}
    	}

    	public void 持ち手上描画()
    	{
    		if (!持ち手)
    		{
    			return;
    		}
    		switch (ハンド右.Xi)
    		{
    		case 5:
    			switch (ハンド右.Yi)
    			{
    			case 0:
    				Are.Draw(ハンド右.X5Y0_親指);
    				Are.Draw(ハンド右.X5Y0_手);
    				Are.Draw(ハンド右.X5Y0_小指);
    				Are.Draw(ハンド右.X5Y0_薬指);
    				Are.Draw(ハンド右.X5Y0_中指);
    				Are.Draw(ハンド右.X5Y0_人指);
    				Are.Draw(ハンド右.X5Y0_呪印_輪1_輪外);
    				Are.Draw(ハンド右.X5Y0_呪印_輪1_輪内);
    				Are.Draw(ハンド右.X5Y0_呪印_輪2_輪外);
    				Are.Draw(ハンド右.X5Y0_呪印_輪2_輪内);
    				Are.Draw(ハンド右.X5Y0_呪印_輪3_輪外);
    				Are.Draw(ハンド右.X5Y0_呪印_輪3_輪内);
    				Are.Draw(ハンド右.X5Y0_呪印_鎖1);
    				Are.Draw(ハンド右.X5Y0_呪印_鎖2);
    				Are.Draw(ハンド右.X5Y0_呪印_鎖3);
    				break;
    			case 1:
    				Are.Draw(ハンド右.X5Y1_親指);
    				Are.Draw(ハンド右.X5Y1_手);
    				Are.Draw(ハンド右.X5Y1_小指);
    				Are.Draw(ハンド右.X5Y1_薬指);
    				Are.Draw(ハンド右.X5Y1_中指);
    				Are.Draw(ハンド右.X5Y1_人指);
    				Are.Draw(ハンド右.X5Y1_呪印_輪1_輪外);
    				Are.Draw(ハンド右.X5Y1_呪印_輪1_輪内);
    				Are.Draw(ハンド右.X5Y1_呪印_輪2_輪外);
    				Are.Draw(ハンド右.X5Y1_呪印_輪2_輪内);
    				Are.Draw(ハンド右.X5Y1_呪印_輪3_輪外);
    				Are.Draw(ハンド右.X5Y1_呪印_輪3_輪内);
    				Are.Draw(ハンド右.X5Y1_呪印_鎖1);
    				Are.Draw(ハンド右.X5Y1_呪印_鎖2);
    				Are.Draw(ハンド右.X5Y1_呪印_鎖3);
    				break;
    			case 2:
    				Are.Draw(ハンド右.X5Y2_親指);
    				Are.Draw(ハンド右.X5Y2_手);
    				Are.Draw(ハンド右.X5Y2_小指);
    				Are.Draw(ハンド右.X5Y2_薬指);
    				Are.Draw(ハンド右.X5Y2_中指);
    				Are.Draw(ハンド右.X5Y2_人指);
    				Are.Draw(ハンド右.X5Y2_呪印_輪1_輪外);
    				Are.Draw(ハンド右.X5Y2_呪印_輪1_輪内);
    				Are.Draw(ハンド右.X5Y2_呪印_輪2_輪外);
    				Are.Draw(ハンド右.X5Y2_呪印_輪2_輪内);
    				Are.Draw(ハンド右.X5Y2_呪印_輪3_輪外);
    				Are.Draw(ハンド右.X5Y2_呪印_輪3_輪内);
    				Are.Draw(ハンド右.X5Y2_呪印_鎖1);
    				Are.Draw(ハンド右.X5Y2_呪印_鎖2);
    				Are.Draw(ハンド右.X5Y2_呪印_鎖3);
    				break;
    			case 3:
    				Are.Draw(ハンド右.X5Y3_親指);
    				Are.Draw(ハンド右.X5Y3_手);
    				Are.Draw(ハンド右.X5Y3_小指);
    				Are.Draw(ハンド右.X5Y3_薬指);
    				Are.Draw(ハンド右.X5Y3_中指);
    				Are.Draw(ハンド右.X5Y3_人指);
    				Are.Draw(ハンド右.X5Y3_呪印_輪1_輪外);
    				Are.Draw(ハンド右.X5Y3_呪印_輪1_輪内);
    				Are.Draw(ハンド右.X5Y3_呪印_輪2_輪外);
    				Are.Draw(ハンド右.X5Y3_呪印_輪2_輪内);
    				Are.Draw(ハンド右.X5Y3_呪印_輪3_輪外);
    				Are.Draw(ハンド右.X5Y3_呪印_輪3_輪内);
    				Are.Draw(ハンド右.X5Y3_呪印_鎖1);
    				Are.Draw(ハンド右.X5Y3_呪印_鎖2);
    				Are.Draw(ハンド右.X5Y3_呪印_鎖3);
    				break;
    			default:
    				Are.Draw(ハンド右.X5Y4_親指);
    				Are.Draw(ハンド右.X5Y4_手);
    				Are.Draw(ハンド右.X5Y4_小指);
    				Are.Draw(ハンド右.X5Y4_薬指);
    				Are.Draw(ハンド右.X5Y4_中指);
    				Are.Draw(ハンド右.X5Y4_人指);
    				Are.Draw(ハンド右.X5Y4_呪印_輪1_輪外);
    				Are.Draw(ハンド右.X5Y4_呪印_輪1_輪内);
    				Are.Draw(ハンド右.X5Y4_呪印_輪2_輪外);
    				Are.Draw(ハンド右.X5Y4_呪印_輪2_輪内);
    				Are.Draw(ハンド右.X5Y4_呪印_輪3_輪外);
    				Are.Draw(ハンド右.X5Y4_呪印_輪3_輪内);
    				Are.Draw(ハンド右.X5Y4_呪印_鎖1);
    				Are.Draw(ハンド右.X5Y4_呪印_鎖2);
    				Are.Draw(ハンド右.X5Y4_呪印_鎖3);
    				break;
    			}
    			break;
    		case 11:
    			Are.Draw(ハンド右.X11Y0_手);
    			Are.Draw(ハンド右.X11Y0_親指);
    			Are.Draw(ハンド右.X11Y0_呪印_輪1_輪外);
    			Are.Draw(ハンド右.X11Y0_呪印_輪1_輪内);
    			Are.Draw(ハンド右.X11Y0_呪印_輪2_輪外);
    			Are.Draw(ハンド右.X11Y0_呪印_輪2_輪内);
    			Are.Draw(ハンド右.X11Y0_呪印_輪3_輪外);
    			Are.Draw(ハンド右.X11Y0_呪印_輪3_輪内);
    			Are.Draw(ハンド右.X11Y0_呪印_鎖1);
    			Are.Draw(ハンド右.X11Y0_呪印_鎖3);
    			break;
    		case 13:
    			Are.Draw(ハンド右.X13Y0_中指);
    			Are.Draw(ハンド右.X13Y0_人指);
    			Are.Draw(ハンド右.X13Y0_手);
    			Are.Draw(ハンド右.X13Y0_親指);
    			Are.Draw(ハンド右.X13Y0_呪印_輪1_輪外);
    			Are.Draw(ハンド右.X13Y0_呪印_輪1_輪内);
    			Are.Draw(ハンド右.X13Y0_呪印_輪2_輪外);
    			Are.Draw(ハンド右.X13Y0_呪印_輪2_輪内);
    			Are.Draw(ハンド右.X13Y0_呪印_輪3_輪外);
    			Are.Draw(ハンド右.X13Y0_呪印_輪3_輪内);
    			Are.Draw(ハンド右.X13Y0_呪印_鎖1);
    			Are.Draw(ハンド右.X13Y0_呪印_鎖3);
    			break;
    		}
    	}

    	public void 通常放し()
    	{
    		focus.Ele.濃度 = 0.5;
    		Focus = ハンド右CM;
    		if (Med.Mode == "Training")
    		{
                //TODO fix?
                //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(ハンド右.位置B));
    		}
    		Set持ち手();
    	}

    	public void 挿入放し()
    	{
    		sf = false;
    		if (膣i肛f)
    		{
    			if (Focus == ペニスCM)
    			{
    				SubFocus.Insert(0, ペニス挿入);
    				ペニスCM.使用状態 = UsageStatus.Attach;
    			}
    			else if (Focus == マウスCM)
    			{
    				SubFocus.Insert(0, マウス挿入);
    				マウスCM.使用状態 = UsageStatus.Attach;
    			}
    			else if (Focus == ハンド右CM)
    			{
    				SubFocus.Insert(0, ハンド挿入);
    				ハンド右CM.使用状態 = UsageStatus.Attach;
    			}
    			else if (Focus == ロータCM)
    			{
    				SubFocus.Insert(0, ロータ挿入);
    				ロータCM.使用状態 = UsageStatus.Attach;
    			}
    			else if (Focus == コモンCM)
    			{
    				SubFocus.Insert(0, コモン挿入);
    				コモンCM.使用状態 = UsageStatus.Attach;
    			}
    			else if (Focus == ディルCM)
    			{
    				SubFocus.Insert(0, ディル挿入);
    				ディルCM.使用状態 = UsageStatus.Attach;
    			}
    			else if (Focus == アナルCM)
    			{
    				SubFocus.Insert(0, アナル挿入);
    				アナルCM.使用状態 = UsageStatus.Attach;
    			}
    			else if (Focus == デンマCM)
    			{
    				SubFocus.Insert(0, デンマ挿入);
    				デンマCM.使用状態 = UsageStatus.Attach;
    			}
    			else if (Focus == ドリルCM)
    			{
    				SubFocus.Insert(0, ドリル挿入);
    				ドリルCM.使用状態 = UsageStatus.Attach;
    			}
    			else if (Focus == パールCM)
    			{
    				SubFocus.Insert(0, パール挿入);
    				パールCM.使用状態 = UsageStatus.Attach;
    			}
    		}
    		else if (Focus == ペニスCM)
    		{
    			SubFocus.Add(ペニス挿入);
    			ペニスCM.使用状態 = UsageStatus.Attach;
    		}
    		else if (Focus == マウスCM)
    		{
    			SubFocus.Add(マウス挿入);
    			マウスCM.使用状態 = UsageStatus.Attach;
    		}
    		else if (Focus == ハンド右CM)
    		{
    			SubFocus.Add(ハンド挿入);
    			ハンド右CM.使用状態 = UsageStatus.Attach;
    		}
    		else if (Focus == ロータCM)
    		{
    			SubFocus.Add(ロータ挿入);
    			ロータCM.使用状態 = UsageStatus.Attach;
    		}
    		else if (Focus == コモンCM)
    		{
    			SubFocus.Add(コモン挿入);
    			コモンCM.使用状態 = UsageStatus.Attach;
    		}
    		else if (Focus == ディルCM)
    		{
    			SubFocus.Add(ディル挿入);
    			ディルCM.使用状態 = UsageStatus.Attach;
    		}
    		else if (Focus == アナルCM)
    		{
    			SubFocus.Add(アナル挿入);
    			アナルCM.使用状態 = UsageStatus.Attach;
    		}
    		else if (Focus == デンマCM)
    		{
    			SubFocus.Add(デンマ挿入);
    			デンマCM.使用状態 = UsageStatus.Attach;
    		}
    		else if (Focus == ドリルCM)
    		{
    			SubFocus.Add(ドリル挿入);
    			ドリルCM.使用状態 = UsageStatus.Attach;
    		}
    		else if (Focus == パールCM)
    		{
    			SubFocus.Add(パール挿入);
    			パールCM.使用状態 = UsageStatus.Attach;
    		}
    		Focus.Ele.SetHitTrue();
    		Focus_nr = ハンド右CM;
            //TODO fix?
            //Cursor.Position = Med.BaseControlC.PointToScreen(Med.FromBasePosition(ハンド右.位置B));
    		Set持ち手();
    	}

    	private void SetIs膣i肛f()
    	{
    		肛f = Get挿入処理()?.Is肛 ?? false;
    		膣i肛f = 肛f && SubFocus.Any((挿入処理 e) => e.Is膣);
    	}

    	public void Setハンド左(挿入処理 i)
    	{
    		if (i == ロータ挿入)
    		{
    			Set_ロータ(ハンド左);
    		}
    		else if (i == コモン挿入)
    		{
    			Set_コモン(ハンド左);
    		}
    		else if (i == ディル挿入)
    		{
    			Set_ディル(ハンド左);
    		}
    		else if (i == アナル挿入)
    		{
    			Set_アナル(ハンド左);
    		}
    		else if (i == デンマ挿入)
    		{
    			Set_デンマ(ハンド左);
    		}
    		else if (i == ドリル挿入)
    		{
    			Set_ドリル(ハンド左);
    		}
    		else if (i == パール挿入)
    		{
    			Set_パール(ハンド左);
    		}
    		ハンド左CM.Draws(Are);
    	}

    	public void 押し(ref ContactD cd)
    	{
    		if (IsHitCha(ref cd) || focus == 羽根箒CM || focus == 調教鞭CM)
    		{
    			focus.Ele.尺度C = 1.0;
    			if (持ち手 || ペニス処理.Isパイズリ)
    			{
    				ハンド右.尺度C = 1.0;
    			}
    			ハンド左.尺度C = 1.0;
    			押し状態 = true;
    		}
    	}

    	public void 放し()
    	{
    		if (!Is挿入)
    		{
    			focus.Ele.尺度C = 1.09;
    			if (持ち手 || ペニス処理.Isパイズリ)
    			{
    				ハンド右.尺度C = 1.09;
    			}
    			ハンド左.尺度C = 1.09;
    			押し状態 = false;
    		}
    	}

    	public void くぱぁ閉じ時()
    	{
    		if (ペニス挿入.Is膣 || ペニス挿入.Is肛)
    		{
    			ペニス挿入.抜け落ち.Start();
    		}
    		if (マウス挿入.Is膣 || マウス挿入.Is肛)
    		{
    			マウス挿入.抜け落ち.Start();
    		}
    		if (ハンド挿入.Is膣 || ハンド挿入.Is肛)
    		{
    			ハンド挿入.抜け落ち.Start();
    		}
    		if (ロータ挿入.Is膣 || ロータ挿入.Is肛)
    		{
    			ロータ挿入.抜け落ち.Start();
    		}
    		if (コモン挿入.Is膣 || コモン挿入.Is肛)
    		{
    			コモン挿入.抜け落ち.Start();
    		}
    		if (ディル挿入.Is膣 || ディル挿入.Is肛)
    		{
    			ディル挿入.抜け落ち.Start();
    		}
    		if (アナル挿入.Is膣 || アナル挿入.Is肛)
    		{
    			アナル挿入.抜け落ち.Start();
    		}
    		if (デンマ挿入.Is膣 || デンマ挿入.Is肛)
    		{
    			デンマ挿入.抜け落ち.Start();
    		}
    		if (ドリル挿入.Is膣 || ドリル挿入.Is肛)
    		{
    			ドリル挿入.抜け落ち.Start();
    		}
    		if (パール挿入.Is膣 || パール挿入.Is肛)
    		{
    			パール挿入.抜け落ち.Start();
    		}
    	}

    	public void 脚修正()
    	{
    		if (!Bod.Is拘束 && Bod.脚人n > 0)
    		{
    			Cha.脚();
    			Cha.Bod.腿Update();
    		}
    	}

    	public void 腕修正()
    	{
    		if (!Bod.Is拘束 && Bod.腕人n > 0 && Bod.Is最前腕人)
    		{
    			Cha.腕();
    			Cha.Bod.EI腕前.Updatef = true;
    		}
    	}

    	public void 大顎修正()
    	{
    		if (!Bod.Is拘束 && Bod.大顎n > 0)
    		{
    			Cha.顎();
    		}
    	}

    	private void SubInfoSet(ref MouseButtons mb, ref Vector2D cp, ref Vector2D op, ref Color hc, ref ContactD cd)
    	{
    		ペニス処理.Move(ref mb, ref cp, ref hc, ref cd);
    		マウス処理.Move(ref mb, ref cp, ref hc, ref cd);
    		ハンド処理.Move(ref mb, ref cp, ref hc, ref cd);
    		ロータ挿入.Move(ref mb, ref cp, ref hc, ref cd);
    		コモン挿入.Move(ref mb, ref cp, ref hc, ref cd);
    		ディル挿入.Move(ref mb, ref cp, ref hc, ref cd);
    		アナル挿入.Move(ref mb, ref cp, ref hc, ref cd);
    		デンマ挿入.Move(ref mb, ref cp, ref hc, ref cd);
    		ドリル挿入.Move(ref mb, ref cp, ref hc, ref cd);
    		パール挿入.Move(ref mb, ref cp, ref hc, ref cd);
    		キャップ処理.Move(ref mb, ref cp, ref op, ref hc, ref cd);
    		羽箒処理.Move(ref mb, ref cp, ref hc, ref cd);
    		剃刀処理.Move(ref mb, ref cp, ref op, ref hc, ref cd);
    		調鞭処理.Move(ref mb, ref cp, ref hc, ref cd);
    	}

    	public void Move(ref MouseButtons mb, ref Vector2D cp, ref Vector2D op, ref Color hc, ref ContactD cd)
    	{
    		if (HeldButton != mb)
    		{
    			return;
    		}
    		if (!Is挿入 && !ペニス処理.Isパイズリ && !マウス処理.Is吸付 && !コキ)
    		{
    			Focus.Ele.位置B = cp;
    		}
    		if (IsTool = X < cp.X && cp.Y < Y && mb != MouseButtons.Left && !Isモード)
    		{
    			Med.CursorShow();
    			if (focus.Ele.濃度 == 1.0)
    			{
    				Focus.Ele.濃度 = 0.2;
    			}
    			In持ち手();
    			Color hc_ = hc;
    			hcm = (from e in EnumCM()
    				where e.使用状態 == UsageStatus.Standby
    				select e).FirstOrDefault((CM e) => e.Ele.本体.IsHit(ref hc_));
    			if (hcm != null)
    			{
    				foreach (CM item in from e in EnumCM()
    					where e.使用状態 == UsageStatus.Standby
    					select e)
    				{
    					item.Ele.濃度 = 0.5;
    				}
    				hcm.Ele.濃度 = 1.0;
    			}
    			else
    			{
    				foreach (CM item2 in from e in EnumCM()
    					where e.使用状態 == UsageStatus.Standby && e.Ele.濃度 == 1.0
    					select e)
    				{
    					item2.Ele.濃度 = 0.5;
    				}
    			}
    		}
    		else
    		{
    			if (ip.MaiShow)
    			{
    				Med.CursorShow();
    			}
    			else
    			{
    				Med.CursorHide();
    			}
    			if (focus.Ele.濃度 == 0.2)
    			{
    				Focus.Ele.濃度 = 1.0;
    			}
    			Out持ち手();
    			foreach (CM item3 in from e in EnumCM()
    				where e.使用状態 == UsageStatus.Standby && e.Ele.濃度 == 1.0
    				select e)
    			{
    				item3.Ele.濃度 = 0.5;
    			}
    			if (!Isモード)
    			{
    				調教終了.Move(ref hc);
    				拘束具.Move(ref hc);
    				目隠帯.Move(ref hc);
    				玉口枷.Move(ref hc);
    				断面.Move(ref hc);
    				媚薬.Move(ref hc);
    				撮影.Move(ref hc);
    				SlaveStamina.Move(ref hc);
    				PlayerStamina.Move(ref hc);
    				if (調教終了.Pars.IsHit(ref hc) || 拘束具.Pars.IsHit(ref hc) || 目隠帯.Pars.IsHit(ref hc) || 玉口枷.Pars.IsHit(ref hc) || 断面.Pars.IsHit(ref hc) || 媚薬.Pars.IsHit(ref hc) || 撮影.Pars.IsHit(ref hc))
    				{
    					Med.CursorShow();
    				}
    				else if (ip.MaiShow)
    				{
    					Med.CursorShow();
    				}
    				else if (SlaveStamina.Pars.IsHit(ref hc) || PlayerStamina.Pars.IsHit(ref hc))
    				{
    					Med.CursorShow();
    				}
    				else
    				{
    					Med.CursorHide();
    				}
    			}
    		}
    		肛oh = false;
    		ef = null;
    		if (sf && !ハンド処理.Isモード && Focus == ハンド右CM && SubFocus.Count > 0)
    		{
    			bool flag = true;
    			foreach (挿入処理 item4 in SubFocus)
    			{
    				if (flag = item4.対象.Ele.本体.IsHit(ref hc))
    				{
    					if (item4.対象 == ロータCM)
    					{
    						Set_ロータ(ハンド右);
    						ハンド右.Xi = 11;
    					}
    					else if (item4.対象 == コモンCM)
    					{
    						Set_コモン(ハンド右);
    						ハンド右.Xi = 13;
    					}
    					else if (item4.対象 == ディルCM)
    					{
    						Set_ディル(ハンド右);
    						ハンド右.Xi = 13;
    					}
    					else if (item4.対象 == アナルCM)
    					{
    						Set_アナル(ハンド右);
    						ハンド右.Xi = 13;
    					}
    					else if (item4.対象 == デンマCM)
    					{
    						Set_デンマ(ハンド右);
    						ハンド右.Xi = 13;
    					}
    					else if (item4.対象 == ドリルCM)
    					{
    						Set_ドリル(ハンド右);
    						ハンド右.Xi = 13;
    					}
    					else if (item4.対象 == パールCM)
    					{
    						Set_パール(ハンド右);
    						ハンド右.Xi = 11;
    					}
    					else if (item4.対象 == 羽根箒CM)
    					{
    						Set_羽根箒(ハンド右);
    						ハンド右.Xi = 11;
    					}
    					else if (item4.対象 == 調教鞭CM)
    					{
    						Set_調教鞭(ハンド右);
    						ハンド右.Xi = 11;
    					}
    					else if (item4.対象 == T剃刀CM)
    					{
    						Set_T剃刀(ハンド右);
    						ハンド右.Xi = 11;
    					}
    					ef = item4;
    					if (Sta.GameData.ガイド)
    					{
    						ip.SubInfoIm = ((item4.対象 == ペニスCM) ? ("LCl:" + GameText.選択) : ("LCl:" + GameText.持つ));
    					}
    					挿入処理 挿入処理2 = Get挿入処理(ref hc);
    					肛oh = 挿入処理2 != null && 挿入処理2.Is肛 && focus == ハンド右CM;
    					break;
    				}
    			}
    			if (!flag)
    			{
    				if (ハンド右.Xi == 11 || ハンド右.Xi == 13)
    				{
    					ハンド右.Xi = 0;
    				}
    				ef = null;
    			}
    		}
    		else
    		{
    			sf = true;
    		}
    		if (!ペニス処理.手コキ.Run && !ペニス処理.足コキ.Run)
    		{
    			ペニス処理.Move(ref mb, ref cp, ref hc, ref cd);
    			マウス処理.Move(ref mb, ref cp, ref hc, ref cd);
    			ハンド処理.Move(ref mb, ref cp, ref hc, ref cd);
    			ロータ挿入.Move(ref mb, ref cp, ref hc, ref cd);
    			コモン挿入.Move(ref mb, ref cp, ref hc, ref cd);
    			ディル挿入.Move(ref mb, ref cp, ref hc, ref cd);
    			アナル挿入.Move(ref mb, ref cp, ref hc, ref cd);
    			デンマ挿入.Move(ref mb, ref cp, ref hc, ref cd);
    			ドリル挿入.Move(ref mb, ref cp, ref hc, ref cd);
    			パール挿入.Move(ref mb, ref cp, ref hc, ref cd);
    			キャップ処理.Move(ref mb, ref cp, ref op, ref hc, ref cd);
    			羽箒処理.Move(ref mb, ref cp, ref hc, ref cd);
    			剃刀処理.Move(ref mb, ref cp, ref op, ref hc, ref cd);
    			調鞭処理.Move(ref mb, ref cp, ref hc, ref cd);
    		}
    		IsTB = false;
    		挿入処理f = Get挿入処理();
    		if (IsTB = Isバイブ(focus) && 挿入処理f != null && ((挿入処理f.Is膣 && SubFocus.Any((挿入処理 e) => e.Is肛 && Isバイブ(e.対象))) || (挿入処理f.Is肛 && SubFocus.Any((挿入処理 e) => e.Is膣 && Isバイブ(e.対象)))))
    		{
    			if (挿入処理f.Is膣)
    			{
    				(挿入処理s = SubFocus.First((挿入処理 e) => e.Is肛)).MoveR(ref mb, ref cp, ref hc, ref cd);
    			}
    			else if (挿入処理f.Is肛)
    			{
    				(挿入処理s = SubFocus.First((挿入処理 e) => e.Is膣)).MoveR(ref mb, ref cp, ref hc, ref cd);
    			}
    			挿入処理s.抜け落ち.End();
    			if (挿入処理s == ロータ挿入)
    			{
    				Set_ロータ(ハンド左);
    				ハンド左.Xi = 11;
    			}
    			else if (挿入処理s == コモン挿入)
    			{
    				Set_コモン(ハンド左);
    				ハンド左.Xi = 13;
    			}
    			else if (挿入処理s == ディル挿入)
    			{
    				Set_ディル(ハンド左);
    				ハンド左.Xi = 13;
    			}
    			else if (挿入処理s == アナル挿入)
    			{
    				Set_アナル(ハンド左);
    				ハンド左.Xi = 13;
    			}
    			else if (挿入処理s == デンマ挿入)
    			{
    				Set_デンマ(ハンド左);
    				ハンド左.Xi = 13;
    			}
    			else if (挿入処理s == ドリル挿入)
    			{
    				Set_ドリル(ハンド左);
    				ハンド左.Xi = 13;
    			}
    			else if (挿入処理s == パール挿入)
    			{
    				Set_パール(ハンド左);
    				ハンド左.Xi = 11;
    			}
    		}
    		SetIs膣i肛f();
    		if (Sta.GameData.ガイド && IsTool && hcm != null)
    		{
    			ip.SubInfoIm = ((hcm == ペニスCM || hcm == マウスCM || hcm == ハンド右CM) ? ("LCl:" + GameText.選択) : ("LCl:" + GameText.持つ));
    		}
    		if (拘束具.Pars.Values.First().ToPar().HitColor == hc)
    		{
    			ip.SubInfoIm = GameText.拘束状態を切換えます;
    		}
    		if (目隠帯.Pars.Values.First().ToPar().HitColor == hc)
    		{
    			ip.SubInfoIm = GameText.目隠状態を切換えます;
    		}
    		if (玉口枷.Pars.Values.First().ToPar().HitColor == hc)
    		{
    			ip.SubInfoIm = GameText.口枷状態を切換えます;
    		}
    		if (断面.Pars.Values.First().ToPar().HitColor == hc)
    		{
    			ip.SubInfoIm = GameText.断面表示を切換えます;
    		}
    		if (媚薬.Pars.Values.First().ToPar().HitColor == hc)
    		{
    			ip.SubInfoIm = GameText.発情状態になります + "(-" + 媚薬投与価格.ToString("#,0") + ")";
    		}
    		if (SlaveStamina.Pars.Values.First().ToPar().HitColor == hc)
    		{
    			ip.SubInfoIm = "Reset slave's stamina";
    		}
    		if (PlayerStamina.Pars.Values.First().ToPar().HitColor == hc)
    		{
    			ip.SubInfoIm = "Reset player's stamina";
    		}
    		if (撮影.Pars.Values.First().ToPar().HitColor == hc && ip.SubInfoIm != GameText.撮影しました + "\r\n" + GameText.写真はPhotoフォルダに保存されます)
    		{
    			ip.SubInfoIm = GameText.撮影を行います;
    		}
    	}

    	public void Down(ref MouseButtons mb, ref Vector2D cp, ref Vector2D op, ref Color hc, ref ContactD cd)
    	{
    		if (HeldButton != 0)
    		{
    			return;
    		}
    		if (Player.強制終了)
    		{
    			Player.強制終了 = false;
    			調教終了.Action(調教終了);
    			return;
    		}
    		if (X < cp.X && cp.Y < Y)
    		{
    			Color hc_ = hc;
    			CM cM = (from e in EnumCM()
    				where e.使用状態 == UsageStatus.Standby
    				select e).FirstOrDefault((CM e) => e.Ele.本体.IsHit(ref hc_));
    			if (cM != null)
    			{
    				Focus.Ele.濃度 = 0.5;
    				Focus = cM;
    				Focus.Ele.濃度 = 0.2;
    				Focus.Ele.位置B = Med.CursorPosition;
    				Set持ち手();
    				if (持ち手)
    				{
    					ハンド右.濃度 = 0.2;
    				}
    				else
    				{
    					ハンド右.位置B = ハンド右CM.bp;
    				}
    				SubInfoSet(ref mb, ref cp, ref op, ref hc, ref cd);
    			}
    		}
    		else
    		{
    			調教終了.Down(ref hc);
    			拘束具.Down(ref hc);
    			目隠帯.Down(ref hc);
    			玉口枷.Down(ref hc);
    			断面.Down(ref hc);
    			媚薬.Down(ref hc);
    			撮影.Down(ref hc);
    			SlaveStamina.Down(ref hc);
    			PlayerStamina.Down(ref hc);
    		}
    		if (Focus == ハンド右CM && SubFocus.Count > 0 && ef != null)
    		{
    			ef.抜け落ち.End();
    			SubFocus.Remove(ef);
    			Focus = ef.対象;
    			ef.挿抜モーション.End();
    			if (ef != ペニス挿入)
    			{
    				ef.挿抜フラグ = true;
    			}
    			ef = null;
    			Set持ち手();
    		}
    		ペニス処理.Down(ref mb, ref cp, ref hc, ref cd);
    		マウス処理.Down(ref mb, ref cp, ref hc, ref cd);
    		ハンド処理.Down(ref mb, ref cp, ref hc, ref cd);
    		ロータ挿入.Down(ref mb, ref cp, ref hc, ref cd);
    		コモン挿入.Down(ref mb, ref cp, ref hc, ref cd);
    		ディル挿入.Down(ref mb, ref cp, ref hc, ref cd);
    		アナル挿入.Down(ref mb, ref cp, ref hc, ref cd);
    		デンマ挿入.Down(ref mb, ref cp, ref hc, ref cd);
    		ドリル挿入.Down(ref mb, ref cp, ref hc, ref cd);
    		パール挿入.Down(ref mb, ref cp, ref hc, ref cd);
    		キャップ処理.Down(ref mb, ref cp, ref op, ref hc, ref cd);
    		羽箒処理.Down(ref mb, ref cp, ref hc, ref cd);
    		剃刀処理.Down(ref mb, ref cp, ref hc, ref cd);
    		調鞭処理.Down(ref mb, ref cp, ref hc, ref cd);
    		SetIs膣i肛f();
    		HeldButton = mb;
    	}

    	public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref ContactD cd)
    	{
    		if (HeldButton == mb)
    		{
    			調教終了.Up(ref hc);
    			拘束具.Up(ref hc);
    			目隠帯.Up(ref hc);
    			玉口枷.Up(ref hc);
    			断面.Up(ref hc);
    			媚薬.Up(ref hc);
    			撮影.Up(ref hc);
    			SlaveStamina.Up(ref hc);
    			PlayerStamina.Up(ref hc);
    			ペニス処理.Up(ref mb, ref cp, ref hc, ref cd);
    			マウス処理.Up(ref mb, ref cp, ref hc, ref cd);
    			ハンド処理.Up(ref mb, ref cp, ref hc, ref cd);
    			ロータ挿入.Up(ref mb, ref cp, ref hc, ref cd);
    			コモン挿入.Up(ref mb, ref cp, ref hc, ref cd);
    			ディル挿入.Up(ref mb, ref cp, ref hc, ref cd);
    			アナル挿入.Up(ref mb, ref cp, ref hc, ref cd);
    			デンマ挿入.Up(ref mb, ref cp, ref hc, ref cd);
    			ドリル挿入.Up(ref mb, ref cp, ref hc, ref cd);
    			パール挿入.Up(ref mb, ref cp, ref hc, ref cd);
    			キャップ処理.Up(ref mb, ref cp, ref hc);
    			羽箒処理.Up(ref mb, ref cp, ref hc, ref cd);
    			剃刀処理.Up(ref mb, ref cp, ref hc, ref cd);
    			HeldButton = MouseButtons.None;
    		}
    	}

    	public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc, ref ContactD cd)
    	{
    		ペニス処理.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
    		マウス処理.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
    		ハンド処理.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
    		ロータ挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
    		コモン挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
    		ディル挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
    		アナル挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
    		デンマ挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
    		ドリル挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
    		パール挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
    		羽箒処理.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
    		調鞭処理.Wheel(ref mb, ref cp, ref dt, ref hc);
    	}

    	public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
    	{
    		Med.CursorShow();
    		調教終了.Leave();
    		拘束具.Leave();
    		目隠帯.Leave();
    		玉口枷.Leave();
    		断面.Leave();
    		媚薬.Leave();
    		撮影.Leave();
    		SlaveStamina.Leave();
    		PlayerStamina.Leave();
    	}

    	public TrainingUI(Med Med, Are Are, InfoPanel ip)
    	{
    		TrainingUI 調教UI2 = this;
    		try
    		{
    			this.Med = Med;
    			this.Are = Are;
    			double disUnit = Are.DisUnit;
    			this.ip = ip;
    			ペニスCM = new CM(Med, this, ペニス = new ペニス(disUnit, 配色指定.N0, Sta.GameData.配色, Med, new ペニスD
    			{
    				濃度 = 0.5,
    				尺度C = 1.09
    			}));
    			マウスCM = new CM(Med, this, マウス = new マウス(disUnit, 配色指定.N0, Sta.GameData.配色, Med, new マウスD
    			{
    				濃度 = 0.5,
    				尺度C = 1.09
    			}));
    			ハンド右CM = new CM(Med, this, ハンド右 = new ハンド(disUnit, 配色指定.N0, Sta.GameData.配色, Med, new ハンドD
    			{
    				尺度C = 1.09,
    				呪印_輪1_輪外_表示 = false,
    				呪印_輪1_輪内_表示 = false,
    				呪印_輪2_輪外_表示 = false,
    				呪印_輪2_輪内_表示 = false,
    				呪印_輪3_輪外_表示 = false,
    				呪印_輪3_輪内_表示 = false,
    				呪印_鎖1_表示 = false,
    				呪印_鎖2_表示 = false,
    				呪印_鎖3_表示 = false
    			}));
    			ハンド左CM = new CM(Med, this, ハンド左 = new ハンド(disUnit, 配色指定.N0, Sta.GameData.配色, Med, new ハンドD
    			{
    				尺度C = 1.09,
    				呪印_輪1_輪外_表示 = false,
    				呪印_輪1_輪内_表示 = false,
    				呪印_輪2_輪外_表示 = false,
    				呪印_輪2_輪内_表示 = false,
    				呪印_輪3_輪外_表示 = false,
    				呪印_輪3_輪内_表示 = false,
    				呪印_鎖1_表示 = false,
    				呪印_鎖2_表示 = false,
    				呪印_鎖3_表示 = false,
    				右 = true
    			}));
    			ハンド左.SetHitFalse();
    			ロータCM = new CM(Med, this, ロータ = new ロータ(disUnit, 配色指定.N0, null, Med, new ロータD
    			{
    				濃度 = 0.5,
    				尺度C = 1.09
    			}));
    			コモンCM = new CM(Med, this, コモン = new バイブ_コモン(disUnit, 配色指定.N0, null, Med, new バイブ_コモンD
    			{
    				濃度 = 0.5,
    				尺度C = 1.09
    			}));
    			ディルCM = new CM(Med, this, ディル = new バイブ_ディル(disUnit, 配色指定.N0, null, Med, new バイブ_ディルD
    			{
    				濃度 = 0.5,
    				尺度C = 1.09
    			}));
    			アナルCM = new CM(Med, this, アナル = new バイブ_アナル(disUnit, 配色指定.N0, null, Med, new バイブ_アナルD
    			{
    				濃度 = 0.5,
    				尺度C = 1.09
    			}));
    			デンマCM = new CM(Med, this, デンマ = new バイブ_デンマ(disUnit, 配色指定.N0, null, Med, new バイブ_デンマD
    			{
    				濃度 = 0.5,
    				尺度C = 1.09
    			}));
    			ドリルCM = new CM(Med, this, ドリル = new バイブ_ドリル(disUnit, 配色指定.N0, null, Med, new バイブ_ドリルD
    			{
    				濃度 = 0.5,
    				尺度C = 1.09
    			}));
    			パールCM = new CM(Med, this, パール = new パール(disUnit, 配色指定.N0, null, Med, new パールD
    			{
    				濃度 = 0.5,
    				尺度C = 1.09
    			}));
    			羽根箒CM = new CM(Med, this, 羽根箒 = new 羽根箒(disUnit, 配色指定.N0, null, Med, new 羽根箒D
    			{
    				濃度 = 0.5,
    				尺度C = 1.09
    			}));
    			調教鞭CM = new CM(Med, this, 調教鞭 = new 調教鞭(disUnit, 配色指定.N0, null, Med, new 調教鞭D
    			{
    				濃度 = 0.5,
    				尺度C = 1.09,
    				Yi = 2
    			}));
    			T剃刀CM = new CM(Med, this, T剃刀 = new T剃刀(disUnit, 配色指定.N0, null, Med, new T剃刀D
    			{
    				濃度 = 0.5,
    				尺度C = 1.09
    			}));
    			ペニス挿入 = new 挿入処理(this, ペニスCM);
    			マウス挿入 = new 挿入処理(this, マウスCM);
    			ハンド挿入 = new 挿入処理(this, ハンド右CM);
    			ロータ挿入 = new 挿入処理(this, ロータCM);
    			コモン挿入 = new 挿入処理(this, コモンCM);
    			ディル挿入 = new 挿入処理(this, ディルCM);
    			アナル挿入 = new 挿入処理(this, アナルCM);
    			デンマ挿入 = new 挿入処理(this, デンマCM);
    			ドリル挿入 = new 挿入処理(this, ドリルCM);
    			パール挿入 = new 挿入処理(this, パールCM);
    			ペニス処理 = new ペニス処理(this, ペニスCM);
    			マウス処理 = new マウス処理(this, マウスCM);
    			ハンド処理 = new ハンド処理(this, ハンド右CM);
    			キャップ処理 = new キャップ処理(this);
    			羽箒処理 = new 羽箒処理(this, 羽根箒CM);
    			剃刀処理 = new 剃刀処理(this, T剃刀CM);
    			調鞭処理 = new 調鞭処理(this, 調教鞭CM);
    			射精 = new 射精(disUnit, 配色指定.N0, Sta.GameData.配色, Med, new 射精D
    			{
    				表示 = false,
    				位置C = new Vector2D(0.0, 0.001)
    			});
    			射精.SetHitFalse();
    			ParT parT = new ParT();
    			parT.Text = GameText.調教終了;
    			parT.SizeBase = 0.095;
    			parT.Font = new Font("MS Gothic", 1f);
    			parT.FontSize = 0.07;
    			parT.SetStringRectOutline(Are.Unit, Are.GD);
    			parT.RectSize = new Vector2D(parT.OP[0].ps[1].X, parT.OP[0].ps[2].Y);
    			parT.OP.ScalingY(parT.BasePointBase, 0.9);
    			parT.Closed = true;
    			parT.TextColor = Col.Black;
    			parT.BrushColor = Color.FromArgb(160, Col.Black);
    			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			parT.HitColor = Med.GetUniqueColor();
    			parT.StringFormat.Alignment = StringAlignment.Center;
    			parT.StringFormat.LineAlignment = StringAlignment.Center;
    			parT.PositionBase = Are.GetPosition(1.0 - (parT.OP[0].ps[1].X * parT.SizeBase / Are.LocalWidth + 0.005), 1.0 - parT.OP[0].ps[2].Y * parT.SizeBase / Are.LocalHeight).AddY(-0.001);
    			parT.PositionBase = new Vector2D(ip.SubB.PositionBase.X, parT.PositionBase.Y);
    			調教終了 = new But1(parT, null);
    			ParT parT2 = new ParT();
    			parT2.Text = GameText.拘束;
    			parT2.SizeBase = 0.095;
    			parT2.Font = new Font("MS Gothic", 1f);
    			parT2.FontSize = 0.07;
    			parT2.SetStringRectOutline(Are.Unit, Are.GD);
    			parT2.RectSize = new Vector2D(parT2.OP[0].ps[1].X, parT2.OP[0].ps[2].Y);
    			parT2.OP.ScalingY(parT2.BasePointBase, 0.9);
    			parT2.Closed = true;
    			parT2.TextColor = Col.Black;
    			parT2.BrushColor = Color.FromArgb(160, Col.Black);
    			parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			parT2.HitColor = Med.GetUniqueColor();
    			parT2.StringFormat.Alignment = StringAlignment.Center;
    			parT2.StringFormat.LineAlignment = StringAlignment.Center;
    			parT2.PositionBase = Are.GetPosition(0.08, 0.7);
    			拘束具 = new But1(parT2, delegate(But a)
    			{
    				if (調教UI2.拘束具sw.Flag)
    				{
    					//Sounds.変更2.Play();
    				}
    				else
    				{
    					//Sounds.変更1.Play();
    				}
    				調教UI2.拘束具sw.OnOff(a);
    				Sta.GameData.拘束具 = 調教UI2.拘束具sw.Flag;
    				調教UI2.Bod.拘束具_表示 = Sta.GameData.拘束具;
    				調教UI2.Bod.首輪_表示 = true;
    				Player.Reaction1();
    			});
    			ParT parT3 = new ParT();
    			parT3.Text = GameText.目隠;
    			parT3.SizeBase = 0.095;
    			parT3.Font = new Font("MS Gothic", 1f);
    			parT3.FontSize = 0.07;
    			parT3.SetStringRectOutline(Are.Unit, Are.GD);
    			parT3.RectSize = new Vector2D(parT3.OP[0].ps[1].X, parT3.OP[0].ps[2].Y);
    			parT3.OP.ScalingY(parT3.BasePointBase, 0.9);
    			parT3.Closed = true;
    			parT3.TextColor = Col.Black;
    			parT3.BrushColor = Color.FromArgb(160, Col.Black);
    			parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			parT3.HitColor = Med.GetUniqueColor();
    			parT3.StringFormat.Alignment = StringAlignment.Center;
    			parT3.StringFormat.LineAlignment = StringAlignment.Center;
    			parT3.PositionBase = parT2.PositionBase.AddY(0.015);
    			目隠帯 = new But1(parT3, delegate(But a)
    			{
    				調教UI2.目隠帯sw.OnOff(a);
    				Sta.GameData.目隠帯 = 調教UI2.目隠帯sw.Flag;
    				調教UI2.Bod.目隠帯_表示 = Sta.GameData.目隠帯;
    				Player.Reaction1();
    			});
    			ParT parT4 = new ParT();
    			parT4.Text = GameText.口枷;
    			parT4.SizeBase = 0.095;
    			parT4.Font = new Font("MS Gothic", 1f);
    			parT4.FontSize = 0.07;
    			parT4.SetStringRectOutline(Are.Unit, Are.GD);
    			parT4.RectSize = new Vector2D(parT4.OP[0].ps[1].X, parT4.OP[0].ps[2].Y);
    			parT4.OP.ScalingY(parT4.BasePointBase, 0.9);
    			parT4.Closed = true;
    			parT4.TextColor = Col.Black;
    			parT4.BrushColor = Color.FromArgb(160, Col.Black);
    			parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			parT4.HitColor = Med.GetUniqueColor();
    			parT4.StringFormat.Alignment = StringAlignment.Center;
    			parT4.StringFormat.LineAlignment = StringAlignment.Center;
    			parT4.PositionBase = parT3.PositionBase.AddY(0.015);
    			玉口枷 = new But1(parT4, delegate(But a)
    			{
    				調教UI2.玉口枷sw.OnOff(a);
    				Sta.GameData.玉口枷 = 調教UI2.玉口枷sw.Flag;
    				調教UI2.Bod.玉口枷_表示 = Sta.GameData.玉口枷;
    				Player.Reaction1();
    			});
    			ParT parT5 = new ParT();
    			parT5.Text = GameText.断面;
    			parT5.SizeBase = 0.095;
    			parT5.Font = new Font("MS Gothic", 1f);
    			parT5.FontSize = 0.07;
    			parT5.SetStringRectOutline(Are.Unit, Are.GD);
    			parT5.RectSize = new Vector2D(parT5.OP[0].ps[1].X, parT5.OP[0].ps[2].Y);
    			parT5.OP.ScalingY(parT5.BasePointBase, 0.9);
    			parT5.Closed = true;
    			parT5.TextColor = Col.Black;
    			parT5.BrushColor = Color.FromArgb(160, Col.Black);
    			parT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			parT5.HitColor = Med.GetUniqueColor();
    			parT5.StringFormat.Alignment = StringAlignment.Center;
    			parT5.StringFormat.LineAlignment = StringAlignment.Center;
    			parT5.PositionBase = parT4.PositionBase.AddY(0.015);
    			断面 = new But1(parT5, delegate(But a)
    			{
    				double v = 0.0;
    				if (調教UI2.ペニス挿入.Is膣)
    				{
    					v = 調教UI2.ペニス挿入.Insert;
    				}
    				if (調教UI2.マウス挿入.Is膣)
    				{
    					v = 調教UI2.マウス挿入.Insert;
    				}
    				if (調教UI2.ハンド挿入.Is膣)
    				{
    					v = 調教UI2.ハンド挿入.Insert;
    				}
    				if (調教UI2.ロータ挿入.Is膣)
    				{
    					v = 調教UI2.ロータ挿入.Insert;
    				}
    				if (調教UI2.コモン挿入.Is膣)
    				{
    					v = 調教UI2.コモン挿入.Insert;
    				}
    				if (調教UI2.ディル挿入.Is膣)
    				{
    					v = 調教UI2.ディル挿入.Insert;
    				}
    				if (調教UI2.アナル挿入.Is膣)
    				{
    					v = 調教UI2.アナル挿入.Insert;
    				}
    				if (調教UI2.デンマ挿入.Is膣)
    				{
    					v = 調教UI2.デンマ挿入.Insert;
    				}
    				if (調教UI2.ドリル挿入.Is膣)
    				{
    					v = 調教UI2.ドリル挿入.Insert;
    				}
    				if (調教UI2.パール挿入.Is膣)
    				{
    					v = 調教UI2.パール挿入.Insert;
    				}
    				調教UI2.断面sw.OnOff(a);
    				Sta.GameData.断面 = 調教UI2.断面sw.Flag;
    				if (!調教UI2.Bod.Is粘)
    				{
    					調教UI2.Bod.断面_表示 = Sta.GameData.断面;
    				}
    				if (調教UI2.ペニス挿入.Is膣)
    				{
    					調教UI2.ペニス挿入.断面切替(v);
    				}
    				if (調教UI2.マウス挿入.Is膣)
    				{
    					調教UI2.マウス挿入.断面切替(v);
    				}
    				if (調教UI2.ハンド挿入.Is膣)
    				{
    					調教UI2.ハンド挿入.断面切替(v);
    				}
    				if (調教UI2.ロータ挿入.Is膣)
    				{
    					調教UI2.ロータ挿入.断面切替(v);
    				}
    				if (調教UI2.コモン挿入.Is膣)
    				{
    					調教UI2.コモン挿入.断面切替(v);
    				}
    				if (調教UI2.ディル挿入.Is膣)
    				{
    					調教UI2.ディル挿入.断面切替(v);
    				}
    				if (調教UI2.アナル挿入.Is膣)
    				{
    					調教UI2.アナル挿入.断面切替(v);
    				}
    				if (調教UI2.デンマ挿入.Is膣)
    				{
    					調教UI2.デンマ挿入.断面切替(v);
    				}
    				if (調教UI2.ドリル挿入.Is膣)
    				{
    					調教UI2.ドリル挿入.断面切替(v);
    				}
    				if (調教UI2.パール挿入.Is膣)
    				{
    					調教UI2.パール挿入.断面切替(v);
    				}
    			});
    			ParT parT6 = new ParT();
    			parT6.Text = GameText.媚薬;
    			parT6.SizeBase = 0.095;
    			parT6.Font = new Font("MS Gothic", 1f);
    			parT6.FontSize = 0.07;
    			parT6.SetStringRectOutline(Are.Unit, Are.GD);
    			parT6.RectSize = new Vector2D(parT6.OP[0].ps[1].X, parT6.OP[0].ps[2].Y);
    			parT6.OP.ScalingY(parT6.BasePointBase, 0.9);
    			parT6.Closed = true;
    			parT6.TextColor = Col.Black;
    			parT6.BrushColor = Color.FromArgb(160, Col.Black);
    			parT6.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			parT6.HitColor = Med.GetUniqueColor();
    			parT6.StringFormat.Alignment = StringAlignment.Center;
    			parT6.StringFormat.LineAlignment = StringAlignment.Center;
    			parT6.PositionBase = parT5.PositionBase.AddY(0.015);
    			媚薬 = new But1(parT6, delegate
    			{
    				if (Sta.GameData.所持金 < 調教UI2.媚薬投与価格)
    				{
    					ip.SubInfoIm = GameText.所持金が足りません;
    				}
    				else
    				{
    					Sta.GameData.所持金 -= 調教UI2.媚薬投与価格;
                        //TODO fix?
                        //Sounds.精算.Play();
    					ip.UpdateSub2();
    					Sta.GameData.TrainingTarget.発情フラグ = true;
    					ip.SubInfoIm = GameText.媚薬を打ち込んだ;
    					Player.Reaction1();
    					調教UI2.媚薬.Dra = false;
    				}
    			});
    			StaminaButtons(Are, Med, ip);
    			ParT parT7 = new ParT();
    			parT7.Text = GameText.撮影;
    			parT7.SizeBase = 0.095;
    			parT7.Font = new Font("MS Gothic", 1f);
    			parT7.FontSize = 0.07;
    			parT7.SetStringRectOutline(Are.Unit, Are.GD);
    			parT7.RectSize = new Vector2D(parT7.OP[0].ps[1].X, parT7.OP[0].ps[2].Y);
    			parT7.OP.ScalingY(parT7.BasePointBase, 0.9);
    			parT7.Closed = true;
    			parT7.TextColor = Col.Black;
    			parT7.BrushColor = Color.FromArgb(160, Col.Black);
    			parT7.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			parT7.HitColor = Med.GetUniqueColor();
    			parT7.StringFormat.Alignment = StringAlignment.Center;
    			parT7.StringFormat.LineAlignment = StringAlignment.Center;
    			parT7.PositionBase = parT6.PositionBase.AddY(0.015);
    			string Path = "Photo";
    			Film = new Are(Med, Hit: false);
    			Film.Setting();
    			撮影 = new But1(parT7, delegate
    			{
    				//Sounds.撮影.Play();
    				Med.flash();
    				if (!Directory.Exists(Path))
    				{
    					Directory.CreateDirectory(Path);
    				}
    				DateTime now = DateTime.Now;
    				Mods.撮影描画(調教UI2.Film, Med.FPSF);
    				Font font = new Font("MS Gothic", (float)(10.0 * Med.DpiY));
    				float x = 350f;
    				float y = 365f;
    				if (Sta.BigWindow)
    				{
    					x = 525f;
    					y = 500f;
    				}
    				try
    				{
    					調教UI2.Film.GD.DrawString("Slave Matrix " + now.ToShortDateString().Replace("/", "."), font, Brushes.Coral, x, y);
    				}
    				finally
    				{
    					((IDisposable)font)?.Dispose();
    				}
    				調教UI2.Film.Dis.Save(Path + "\\" + now.ToString("yyyy_MM_dd_HH_mm_ss") + ".png", ImageFormat.Png);
    				ip.SubInfoIm = GameText.撮影しました + "\r\n" + GameText.写真はPhotoフォルダに保存されます;
    				if (Sta.GameData.TrainingTarget.Trained && !調教UI2.Cha.Bod.Is拘束 && 調教UI2.Cha.Bod.Is腕人 && !Sta.GameData.TrainingTarget.ChaD.撮影ピース経験)
    				{
    					ip.Text = GameText.愛想が悪い + "\r\n" + GameText.ダブルピースさせますか;
    					ip.Mai.Done = delegate
    					{
    						ip.選択yAct = delegate
    						{
    							//Sounds.操作.Play();
    							Sta.GameData.TrainingTarget.ChaD.撮影ピース経験 = true;
    							調教UI2.Cha.Setダブルピース();
    							調教UI2.Cha.Bod.Update();
    							ip.選択肢表示 = false;
    							ip.MaiShow = false;
    						};
    						ip.選択nAct = delegate
    						{
    							//Sounds.操作.Play();
    							ip.選択肢表示 = false;
    							ip.MaiShow = false;
    						};
    						ip.選択肢表示 = true;
    					};
    					ip.MaiShow = true;
    				}
    			});
    			int alpha = 200;
    			体力sゲージ = new Gau("体力", Are.GetPosition(new Vector2D(0.025, 0.5)), Are.Size, 0.025, Are.YRatio * 0.98, 0.02, Open.Top, _2DGAMELIB.Range.ZeroOne, disUnit, Color.FromArgb(alpha, Color.Red), Color.Yellow, Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Col.Black), Knob: false);
    			体力sゲージ.Frame1.Pen = null;
    			絶頂sゲージ = new Gau("絶頂", Are.GetPosition(new Vector2D(0.060000000000000005, 0.5)), Are.Size, 0.01, Are.YRatio * 0.98, 0.02, Open.Top, _2DGAMELIB.Range.ZeroOne, disUnit, Color.FromArgb(alpha, Color.DeepPink), Col.White, Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Color.Gray), Color.Transparent, Knob: false);
    			絶頂sゲージ.Frame1.Pen = null;
    			絶頂sゲージ.Gauge.Pen = null;
    			興奮sゲージ = new Gau("興奮", Are.GetPosition(new Vector2D(0.060000000000000005, 0.5)), Are.Size, 0.025, Are.YRatio * 0.98, 0.02, Open.Top, _2DGAMELIB.Range.ZeroOne, disUnit, Color.FromArgb(180, Col.White), Color.FromArgb(180, Color.Red), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Col.Black), Knob: false);
    			興奮sゲージ.Frame1.Pen = null;
    			興奮sゲージ.Gauge.Pen = null;
    			精力mゲージ = new Gau("精力", Are.GetPosition(new Vector2D(0.025.Inverse(), 0.5)), Are.Size, 0.025, Are.YRatio * 0.98, 0.02, Open.Top, _2DGAMELIB.Range.ZeroOne, disUnit, Color.FromArgb(alpha, Col.Yellow.Add(180, 0, 0)), Col.Red.Add(180, 0, 0), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Col.Black), Knob: false);
    			精力mゲージ.Frame1.Pen = null;
    			射精mゲージ = new Gau("射精", Are.GetPosition(new Vector2D(0.060000000000000005.Inverse(), 0.5)), Are.Size, 0.01, Are.YRatio * 0.98, 0.02, Open.Top, _2DGAMELIB.Range.ZeroOne, disUnit, Color.FromArgb(alpha, Col.DeepPink.Add(180, 0, 0)), Col.White.Add(180, 0, 0), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Color.Gray), Color.Transparent, Knob: false);
    			射精mゲージ.Frame1.Pen = null;
    			射精mゲージ.Gauge.Pen = null;
    			興奮mゲージ = new Gau("興奮", Are.GetPosition(new Vector2D(0.060000000000000005.Inverse(), 0.5)), Are.Size, 0.025, Are.YRatio * 0.98, 0.02, Open.Top, _2DGAMELIB.Range.ZeroOne, disUnit, Color.FromArgb(180, Col.White), Color.FromArgb(180, Color.Red), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Col.Black), Knob: false);
    			興奮mゲージ.Frame1.Pen = null;
    			興奮mゲージ.Gauge.Pen = null;
    			Color c = Med.GetUniqueColor();
    			foreach (Par item in 体力sゲージ.Pars.EnumAllPar())
    			{
    				item.HitColor = c;
    			}
    			Med.GetUniqueColor(out c);
    			foreach (Par item2 in 絶頂sゲージ.Pars.EnumAllPar())
    			{
    				item2.HitColor = c;
    			}
    			Med.GetUniqueColor(out c);
    			foreach (Par item3 in 興奮sゲージ.Pars.EnumAllPar())
    			{
    				item3.HitColor = c;
    			}
    			Med.GetUniqueColor(out c);
    			foreach (Par item4 in 精力mゲージ.Pars.EnumAllPar())
    			{
    				item4.HitColor = c;
    			}
    			Med.GetUniqueColor(out c);
    			foreach (Par item5 in 射精mゲージ.Pars.EnumAllPar())
    			{
    				item5.HitColor = c;
    			}
    			Med.GetUniqueColor(out c);
    			foreach (Par item6 in 興奮mゲージ.Pars.EnumAllPar())
    			{
    				item6.HitColor = c;
    			}
    			体力sゲージ.Value = 1.0;
    			絶頂sゲージ.Value = 0.0;
    			興奮sゲージ.Value = 0.0;
    			精力mゲージ.Value = 1.0;
    			射精mゲージ.Value = 0.0;
    			興奮mゲージ.Value = 0.0;
    			Vector2D vector2D = new Vector2D(Are.LocalWidth - 0.14, Are.LocalHeight - (Are.LocalHeight - 0.005));
    			アナル.位置B = (アナルCM.bp = vector2D + new Vector2D(0, 0));
    			デンマ.位置B = (デンマCM.bp = vector2D + new Vector2D(0.019133333333333, 0.0));
    			ドリル.位置B = (ドリルCM.bp = vector2D + new Vector2D(0.038266666666666, 0.0));
    			コモン.位置B = (コモンCM.bp = vector2D + new Vector2D(0.0574, 0.0));
    			ディル.位置B = (ディルCM.bp = vector2D + new Vector2D(0.076533333333333, 0.0));
    			パール.位置B = (パールCM.bp = vector2D + new Vector2D(0.0574, 0.14175));
    			ロータ.位置B = (ロータCM.bp = vector2D + new Vector2D(0.076533333333333, 0.17325));
    			キャップ1.位置B = (キャップ1CM.bp = vector2D + new Vector2D(0.095666666666666, 0.1667));
    			キャップ2.位置B = (キャップ2CM.bp = vector2D + new Vector2D(0.095666666666666, 0.1807));
    			キャップ3.位置B = (キャップ3CM.bp = vector2D + new Vector2D(0.095666666666666, 0.1947));
    			T剃刀.位置B = (T剃刀CM.bp = vector2D + new Vector2D(0.0574, 0.091));
    			羽根箒.位置B = (羽根箒CM.bp = vector2D + new Vector2D(0.076533333333333, 0.116));
    			調教鞭.位置B = (調教鞭CM.bp = vector2D + new Vector2D(0.095666666666666, 0.11025));
    			ハンド右.位置B = (ハンド右CM.bp = vector2D + new Vector2D(0.0574, 181.0 / 800.0));
    			マウス.位置B = (マウスCM.bp = vector2D + new Vector2D(0.076533333333333, 0.23675));
    			ペニス.位置B = (ペニスCM.bp = vector2D + new Vector2D(0.095666666666666, 167.0 / 800.0));
    			focus = ハンド右CM;
    			Focus = ハンド右CM;
    			Set持ち手();
    			X = アナル.位置B.X - 0.006;
    			Y = マウス.位置B.Y + 0.015;
    			Mots.Add(Player.ゲージ降下処理.GetHashCode().ToString(), Player.ゲージ降下処理);
    			Player.ゲージ降下処理.Start();
    			擬音 = new Onomatopoeia();
    			AddBoxes();
    			絶頂ゲージ点滅 = new Mot(0.0, 1.0)
    			{
    				BaseSpeed = 2.0,
    				Staing = delegate
    				{
    				},
    				Runing = delegate(Mot m)
    				{
    					調教UI2.絶頂sゲージ.SetAlphaG(m.Value);
    				},
    				Reaing = delegate
    				{
    				},
    				Rouing = delegate
    				{
    				},
    				Ending = delegate
    				{
    					調教UI2.絶頂sゲージ.SetAlphaG(1.0);
    				}
    			};
    			Mots.Add(絶頂ゲージ点滅.GetHashCode().ToString(), 絶頂ゲージ点滅);
    			射精ゲージ点滅 = new Mot(0.0, 1.0)
    			{
    				BaseSpeed = 2.0,
    				Staing = delegate
    				{
    				},
    				Runing = delegate(Mot m)
    				{
    					調教UI2.射精mゲージ.SetAlphaG(m.Value);
    				},
    				Reaing = delegate
    				{
    				},
    				Rouing = delegate
    				{
    				},
    				Ending = delegate
    				{
    					調教UI2.射精mゲージ.SetAlphaG(1.0);
    				}
    			};
    			Mots.Add(射精ゲージ点滅.GetHashCode().ToString(), 射精ゲージ点滅);
    		}
    		catch (Exception)
    		{
    		}
    	}

    	public void SetTarget(Unit Unit, Cha Cha)
    	{
    		if (this.Cha != null)
    		{
    			this.Cha.潮吹擬音 = null;
    			this.Cha.放尿擬音 = null;
    		}
    		this.Cha = Cha;
    		Bod = Cha.Bod;
    		Bod.カーソル = this;
    		ペニス挿入.SetCha(Cha);
    		マウス挿入.SetCha(Cha);
    		ハンド挿入.SetCha(Cha);
    		ロータ挿入.SetCha(Cha);
    		コモン挿入.SetCha(Cha);
    		ディル挿入.SetCha(Cha);
    		アナル挿入.SetCha(Cha);
    		デンマ挿入.SetCha(Cha);
    		ドリル挿入.SetCha(Cha);
    		パール挿入.SetCha(Cha);
    		羽箒処理.SetCha(Cha);
    		剃刀処理.SetCha(Cha);
    		調鞭処理.SetCha(Cha);
    		ハンド処理.SetCha(Cha);
    		マウス処理.SetCha(Cha);
    		ペニス処理.SetCha(Cha);
    		キャップ処理.SetCha(Cha);
    		this.Cha.潮吹擬音 = 潮吹;
    		this.Cha.放尿擬音 = 放尿;
    		CP.Reset();
    		ペニス挿入.CP挿入.Reset();
    		マウス挿入.CP挿入.Reset();
    		ハンド挿入.CP挿入.Reset();
    		ロータ挿入.CP挿入.Reset();
    		コモン挿入.CP挿入.Reset();
    		ディル挿入.CP挿入.Reset();
    		アナル挿入.CP挿入.Reset();
    		デンマ挿入.CP挿入.Reset();
    		ドリル挿入.CP挿入.Reset();
    		パール挿入.CP挿入.Reset();
    		ペニス挿入.CP振動.Reset();
    		マウス挿入.CP振動.Reset();
    		ハンド挿入.CP振動.Reset();
    		ロータ挿入.CP振動.Reset();
    		コモン挿入.CP振動.Reset();
    		ディル挿入.CP振動.Reset();
    		アナル挿入.CP振動.Reset();
    		デンマ挿入.CP振動.Reset();
    		ドリル挿入.CP振動.Reset();
    		パール挿入.CP振動.Reset();
    		キャップ処理.CP中.Reset();
    		キャップ処理.CP左.Reset();
    		キャップ処理.CP右.Reset();
    		発情bu = Sta.GameData.TrainingTarget.発情フラグ;
    		強制拘束 = false;
    		拘束bu = Sta.GameData.拘束具;
    		if (!Unit.Trained)
    		{
    			Sta.GameData.拘束具 = true;
    			強制拘束 = true;
    		}
    		拘束具sw.SetFlag(拘束具, Sta.GameData.拘束具);
    		Bod.拘束具_表示 = Sta.GameData.拘束具;
    		目隠帯sw.SetFlag(目隠帯, Sta.GameData.目隠帯);
    		Bod.目隠帯_表示 = Sta.GameData.目隠帯;
    		玉口枷sw.SetFlag(玉口枷, Sta.GameData.玉口枷);
    		Bod.玉口枷_表示 = Sta.GameData.玉口枷;
    		断面sw.SetFlag(断面, Sta.GameData.断面);
    		if (!Bod.Is粘)
    		{
    			Bod.断面_表示 = Sta.GameData.断面;
    		}
    		断面.Dra = Sta.GameData.心眼;
    		媚薬.Dra = Sta.GameData.媚薬 && !Cha.ChaD.タトゥ;
    		拘束具.Dra = Unit.Trained;
    		SlaveStamina.Dra = Sta.StaminaButton;
    		PlayerStamina.Dra = Sta.StaminaButton;
    	}

    	public void Reset()
    	{
    		foreach (Mot value in Mots.ms.Values)
    		{
    			if (value != Player.ゲージ降下処理)
    			{
    				value.End();
    			}
    		}
    		if (羽根箒.右)
    		{
    			ハンド右.X11Y0_小指.ReverseX();
    			ハンド右.X11Y0_薬指.ReverseX();
    			ハンド右.X11Y0_中指.ReverseX();
    			ハンド右.X11Y0_人指.ReverseX();
    			ハンド右.X11Y0_手.ReverseX();
    			ハンド右.X11Y0_親指.ReverseX();
    			ハンド右.X11Y0_呪印_輪1_輪外.ReverseX();
    			ハンド右.X11Y0_呪印_輪1_輪内.ReverseX();
    			ハンド右.X11Y0_呪印_輪2_輪外.ReverseX();
    			ハンド右.X11Y0_呪印_輪2_輪内.ReverseX();
    			ハンド右.X11Y0_呪印_輪3_輪外.ReverseX();
    			ハンド右.X11Y0_呪印_輪3_輪内.ReverseX();
    			ハンド右.X11Y0_呪印_鎖1.ReverseX();
    			ハンド右.X11Y0_呪印_鎖3.ReverseX();
    			ハンド右.本体.JoinPA();
    		}
    		Focus = ハンド右CM;
    		通常放し();
    		CP.Reset();
    		擬音キュー.Clear();
    		コキ_ = false;
    		ハンド左表示 = false;
    		持ち手 = false;
    		SubFocus.Clear();
    		膣i肛f = false;
    		肛f = false;
    		肛oh = false;
    		IsTB = false;
    		放し();
    		HeldButton = MouseButtons.None;
    		IsTool = false;
    		hcm = null;
    		ef = null;
    		sf = true;
    		ペニスCM.Reset();
    		マウスCM.Reset();
    		ハンド右CM.Reset();
    		ハンド左CM.Reset();
    		ハンド左.濃度 = 1.0;
    		ハンド左.SetHitFalse();
    		ロータCM.Reset();
    		コモンCM.Reset();
    		ディルCM.Reset();
    		アナルCM.Reset();
    		デンマCM.Reset();
    		ドリルCM.Reset();
    		パールCM.Reset();
    		羽根箒CM.Reset();
    		調教鞭CM.Reset();
    		調教鞭.Yi = 2;
    		T剃刀CM.Reset();
    		ペニス挿入.Reset();
    		マウス挿入.Reset();
    		ハンド挿入.Reset();
    		ロータ挿入.Reset();
    		コモン挿入.Reset();
    		ディル挿入.Reset();
    		アナル挿入.Reset();
    		デンマ挿入.Reset();
    		ドリル挿入.Reset();
    		パール挿入.Reset();
    		ペニス処理.Reset();
    		マウス処理.Reset();
    		ハンド処理.Reset();
    		キャップ処理.Reset();
    		羽箒処理.Reset();
    		剃刀処理.Reset();
    		調鞭処理.Reset();
    		射精.表示 = false;
    		射精.位置C = new Vector2D(0.0, 0.001);
    		射精.SetHitFalse();
    		Vector2D vector2D = new Vector2D(Are.LocalWidth - 0.14, Are.LocalHeight - (Are.LocalHeight - 0.005));
    		アナル.位置B = (アナルCM.bp = vector2D + new Vector2D(0, 0));
    		デンマ.位置B = (デンマCM.bp = vector2D + new Vector2D(0.019133333333333, 0.0));
    		ドリル.位置B = (ドリルCM.bp = vector2D + new Vector2D(0.038266666666666, 0.0));
    		コモン.位置B = (コモンCM.bp = vector2D + new Vector2D(0.0574, 0.0));
    		ディル.位置B = (ディルCM.bp = vector2D + new Vector2D(0.076533333333333, 0.0));
    		パール.位置B = (パールCM.bp = vector2D + new Vector2D(0.0574, 0.14175));
    		ロータ.位置B = (ロータCM.bp = vector2D + new Vector2D(0.076533333333333, 0.17325));
    		キャップ1.位置B = (キャップ1CM.bp = vector2D + new Vector2D(0.095666666666666, 0.1667));
    		キャップ2.位置B = (キャップ2CM.bp = vector2D + new Vector2D(0.095666666666666, 0.1807));
    		キャップ3.位置B = (キャップ3CM.bp = vector2D + new Vector2D(0.095666666666666, 0.1947));
    		T剃刀.位置B = (T剃刀CM.bp = vector2D + new Vector2D(0.0574, 0.091));
    		羽根箒.位置B = (羽根箒CM.bp = vector2D + new Vector2D(0.076533333333333, 0.116));
    		調教鞭.位置B = (調教鞭CM.bp = vector2D + new Vector2D(0.095666666666666, 0.11025));
    		ハンド右.位置B = (ハンド右CM.bp = vector2D + new Vector2D(0.0574, 181.0 / 800.0));
    		マウス.位置B = (マウスCM.bp = vector2D + new Vector2D(0.076533333333333, 0.23675));
    		ペニス.位置B = (ペニスCM.bp = vector2D + new Vector2D(0.095666666666666, 167.0 / 800.0));
    		focus = ハンド右CM;
    		Focus = ハンド右CM;
    		Set持ち手();
    		X = アナル.位置B.X - 0.006;
    		Y = マウス.位置B.Y + 0.015;
    		擬音.Clear();
    	}

    	public void 描画糸(Are Are)
    	{
    		foreach (挿入処理 item in SubFocus)
    		{
    			if (item.Is糸)
    			{
    				item.対象.Draws(Are);
    			}
    		}
    	}

    	public void 描画肛(Are Are)
    	{
    		if (膣i肛f)
    		{
    			focus.描画0(Are);
    			focus.描画1(Are);
    			if (!持ち手 || ((focus == キャップ1CM || focus == キャップ2CM || focus == キャップ3CM) && (キャップ処理.Isキャップ1着() || キャップ処理.Isキャップ2左着() || キャップ処理.Isキャップ2右着()) && !focus.DraShow))
    			{
    				ハンド右CM.待機描画(Are);
    			}
    		}
    		foreach (挿入処理 item in SubFocus)
    		{
    			if (item.Is肛)
    			{
    				item.対象.描画0s(Are);
    				if (item == マウス挿入)
    				{
    					item.対象.描画1s(Are);
    				}
    				if (肛oh)
    				{
    					focus.Draw(Are);
    				}
    				else if (!膣i肛f && IsTB)
    				{
    					Setハンド左(item);
    				}
    			}
    		}
    		if (!膣i肛f && 肛f)
    		{
    			focus.描画0(Are);
    		}
    	}

    	public override void 描画0(Are Are)
    	{
    		foreach (挿入処理 item in SubFocus)
    		{
    			if (!item.Is肛)
    			{
    				item.対象.描画0s(Are);
    				if (item == マウス挿入)
    				{
    					item.対象.描画1s(Are);
    				}
    			}
    		}
    		if (!膣i肛f && !肛f)
    		{
    			focus.描画0(Are);
    		}
    	}

    	public override void 描画1(Are Are)
    	{
    		if (ハンド挿入.Is膣)
    		{
    			return;
    		}
    		foreach (挿入処理 item in SubFocus)
    		{
    			if (item != マウス挿入)
    			{
    				item.対象.描画1s(Are);
    			}
    		}
    		if (!膣i肛f)
    		{
    			focus.描画1(Are);
    		}
    	}

    	public override void 描画2(Are Are)
    	{
    		if (射精.表示)
    		{
    			射精.位置B = ペニス.位置B;
    			射精.色更新();
    			射精.本体.Draw(Are);
    		}
    		foreach (挿入処理 item in SubFocus)
    		{
    			if (!item.Is糸)
    			{
    				item.対象.Draws(Are);
    			}
    		}
    		if (!膣i肛f)
    		{
    			if (!肛oh)
    			{
    				focus.Draw(Are);
    			}
    		}
    		else if (IsTB)
    		{
    			Setハンド左(挿入処理s);
    		}
    		if (ハンド左表示 || ハンド処理.Is乳繰り || ハンド処理.Is乳摘み || ハンド処理.Is乳捏ね || ハンド処理.Isくぱぁ)
    		{
    			ハンド左CM.Draws(Are);
    			if (Is乳弄り)
    			{
    				ハンド右CM.待機描画(Are);
    			}
    		}
    		if (!ハンド挿入.Is膣)
    		{
    			return;
    		}
    		foreach (挿入処理 item2 in SubFocus)
    		{
    			item2.対象.描画1s(Are);
    		}
    		if (!膣i肛f)
    		{
    			focus.描画1(Are);
    		}
    	}

    	public void StaDraw(Are Are, FPS FPS)
    	{
    		Player.表示ステート更新();
    		Player.ModBox();
    		Player.SensBox();
    		Are.Draw(体力sゲージ.Pars);
    		Are.Draw(興奮sゲージ.Pars);
    		Are.Draw(絶頂sゲージ.Pars);
    		Are.Draw(精力mゲージ.Pars);
    		Are.Draw(興奮mゲージ.Pars);
    		Are.Draw(射精mゲージ.Pars);
    		if (!Is乳弄り && !Isフォーカス糸挿入)
    		{
    			描画2(Are);
    		}
    		ペニスCM.待機描画(Are);
    		マウスCM.待機描画(Are);
    		if (!膣i肛f && !Is乳弄り && (!持ち手 || ((focus == キャップ1CM || focus == キャップ2CM || focus == キャップ3CM) && (キャップ処理.Isキャップ1着() || キャップ処理.Isキャップ2左着() || キャップ処理.Isキャップ2右着()) && !focus.DraShow)))
    		{
    			ハンド右CM.待機描画(Are);
    		}
    		ロータCM.待機描画(Are);
    		コモンCM.待機描画(Are);
    		ディルCM.待機描画(Are);
    		アナルCM.待機描画(Are);
    		デンマCM.待機描画(Are);
    		ドリルCM.待機描画(Are);
    		パールCM.待機描画(Are);
    		羽根箒CM.待機描画(Are);
    		調教鞭CM.待機描画(Are);
    		T剃刀CM.待機描画(Are);
    		キャップ1CM.待機描画(Are);
    		キャップ2CM.待機描画(Are);
    		キャップ3CM.待機描画(Are);
    		調教終了.Draw(Are);
    		拘束具.Draw(Are);
    		目隠帯.Draw(Are);
    		玉口枷.Draw(Are);
    		断面.Draw(Are);
    		媚薬.Draw(Are);
    		撮影.Draw(Are);
    		SlaveStamina.Draw(Are);
    		PlayerStamina.Draw(Are);
    		調鞭処理.衝撃.描画0(Are);
    		while (擬音キュー.Count > 0)
    		{
    			擬音キュー.Dequeue()(Are);
    		}
    		擬音.Draw(FPS);
    		if (ステート描画)
    		{
    			Are.Draw(ステート.Pars);
    		}
    		if (Sta.ShowSenses)
    		{
    			Are.Draw(InfoBox.Pars);
    			Are.Draw(SensitivityBox.Pars);
    		}
    	}

    	public void DrawState(Are Are)
    	{
    		Player.表示ステート更新();
    		Player.ModBox();
    		Player.SensBox();
    		Are.Draw(体力sゲージ.Pars);
    		Are.Draw(精力mゲージ.Pars);
    		if (ステート描画)
    		{
    			Are.Draw(ステート.Pars);
    		}
    		if (Sta.ShowSenses)
    		{
    			Are.Draw(InfoBox.Pars);
    			Are.Draw(SensitivityBox.Pars);
    		}
    	}

    	public override void Dispose()
    	{
    		射精.Dispose();
    		ペニス.Dispose();
    		マウス.Dispose();
    		ハンド右.Dispose();
    		ハンド左.Dispose();
    		ロータ.Dispose();
    		コモン.Dispose();
    		ディル.Dispose();
    		アナル.Dispose();
    		デンマ.Dispose();
    		ドリル.Dispose();
    		パール.Dispose();
    		羽根箒.Dispose();
    		調教鞭.Dispose();
    		T剃刀.Dispose();
    		キャップ1.Dispose();
    		キャップ2.Dispose();
    		キャップ3.Dispose();
    		調鞭処理.衝撃.Dispose();
    		調教終了.Dispose();
    		拘束具.Dispose();
    		目隠帯.Dispose();
    		玉口枷.Dispose();
    		断面.Dispose();
    		媚薬.Dispose();
    		撮影.Dispose();
    		体力sゲージ.Dispose();
    		絶頂sゲージ.Dispose();
    		興奮sゲージ.Dispose();
    		精力mゲージ.Dispose();
    		射精mゲージ.Dispose();
    		興奮mゲージ.Dispose();
    		擬音.Dispose();
    		ステート.Dispose();
    		Film.Dispose();
    		InfoBox.Dispose();
    		SensitivityBox.Dispose();
    		//((Tex)(object)SlaveStamina).Dispose();
    		//((Tex)(object)PlayerStamina).Dispose();
    	}

    	public void Action(ContactType 接触, ActionType アクション情報, CurrentState タイミング情報, ToolType アイテム情報, int 挿入Lv, int 強さ, bool 機械, bool 射精)
    	{
    		Player.アクション入力(接触, アクション情報, タイミング情報, アイテム情報, 挿入Lv, 強さ, 機械, 射精);
    	}

    	public void AddBoxes()
    	{
    		double num = 0.31;
    		double width = 0.7;
    		if (Sta.BigWindow)
    		{
    			num += 0.14;
    		}
    		if (Sta.FixInfo)
    		{
    			width = 0.75;
    		}
    		ステート = new Tex("Tex", new Vector2D(Are.GetPosition(0.08, 0.7).X, 0.1), 0.1, width, 1.15, new Font("MS Gothic", 1f), 0.07, 0, "", Col.White, Col.Black, Color.FromArgb(160, Col.Black), 15.0);
    		InfoBox = new Tex("Info", new Vector2D(num, 0.005), 0.1, 0.9, 0.85, new Font("MS Gothic", 1f), 0.07, 0, "", Col.White, Col.Transparent, Color.FromArgb(15, Col.DarkMagenta), 100.0);
    		SensitivityBox = new Tex("Sens", new Vector2D(num + 0.02, 0.08), 0.1, 0.6, 1.99, new Font("MS Gothic", 1f), 0.057, 0, "", Col.White, Col.Transparent, Color.FromArgb(5, Col.DarkMagenta), 100.0);
    	}

    	public void StaminaButtons(Are Are, Med Med, InfoPanel ip)
    	{
    		double x = 0.08;
    		double y = 0.1;
    		if (Sta.BigWindow)
    		{
    			x = 0.08;
    			y = 0.1;
    		}
    		ParT parT = new ParT();
    		parT.Text = "SlaveStamina";
    		parT.SizeBase = 0.095;
    		parT.Font = new Font("MS Gothic", 1f);
    		parT.FontSize = 0.07;
    		parT.SetStringRectOutline(Are.Unit, Are.GD);
    		parT.RectSize = new Vector2D(parT.OP[0].ps[1].X, parT.OP[0].ps[2].Y);
    		parT.OP.ScalingY(parT.BasePointBase, 0.9);
    		parT.Closed = true;
    		parT.TextColor = Col.Black;
    		parT.BrushColor = Color.FromArgb(160, Col.Black);
    		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		parT.HitColor = Med.GetUniqueColor();
    		parT.StringFormat.Alignment = StringAlignment.Center;
    		parT.StringFormat.LineAlignment = StringAlignment.Center;
    		parT.PositionBase = Are.GetPosition(x, y);
    		SlaveStamina = new But1(parT, delegate
    		{
    			//Sounds.操作.Play();
    			ip.UpdateSub2();
    			Sta.GameData.TrainingTarget.ChaD.Stamina = 1.0;
    		});
    		ParT parT2 = new ParT();
    		parT2.Text = "PlayerStamina";
    		parT2.SizeBase = 0.095;
    		parT2.Font = new Font("MS Gothic", 1f);
    		parT2.FontSize = 0.07;
    		parT2.SetStringRectOutline(Are.Unit, Are.GD);
    		parT2.RectSize = new Vector2D(parT2.OP[0].ps[1].X, parT2.OP[0].ps[2].Y);
    		parT2.OP.ScalingY(parT2.BasePointBase, 0.9);
    		parT2.Closed = true;
    		parT2.TextColor = Col.Black;
    		parT2.BrushColor = Color.FromArgb(160, Col.Black);
    		parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		parT2.HitColor = Med.GetUniqueColor();
    		parT2.StringFormat.Alignment = StringAlignment.Center;
    		parT2.StringFormat.LineAlignment = StringAlignment.Center;
    		parT2.PositionBase = parT.PositionBase.AddY(0.015);
    		PlayerStamina = new But1(parT2, delegate
    		{
    			//Sounds.操作.Play();
    			ip.UpdateSub2();
    			Sta.GameData.精力 = 1.0;
    		});
    	}
    }
}
