using _2DGAMELIB;
using SlaveMatrix.GameClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace SlaveMatrix
{
    public class DrawableElement : Element
    {
        public Action<RenderArea> 描画;

        public DrawableElement(Element src, Action<RenderArea> 描画)
        {
            Par = src;
            Body = src.Body;
            this.描画 = 描画;
        }

        public override void 描画0(RenderArea Are)
        {
            描画(Are);
        }

        public override void 描画1(RenderArea Are)
        {
        }

        public override void 描画2(RenderArea Are)
        {
        }
    }

    public class Body
    {
    	public ModeEventDispatcher Med;

    	public Character Cha;

    	public Element[] Elements;

    	private List<蝙通常> 蝙通常;

    	private 頭色更新 頭色更新;

    	private ドレス色更新 ドレス色更新;

    	private IEnumerable<鯨色更新> 鯨色更新;

    	private IEnumerable<飛膜色更新> 飛膜色更新;

    	private IEnumerable<Element> 色更新;

    	public Waist Waist;

    	public Torso Torso;

    	public Chest Chest;

    	public Neck Neck;

    	public Head 頭;

    	public BaseHair BaseHair;

    	public 前髪 前髪;

    	public SideHair 横髪左;

    	public SideHair 横髪右;

    	public BackHair1 後髪1;

    	public BackHair0 後髪0;

    	public 単目 単眼目;

    	public 単瞼 単眼瞼;

    	public 双目 目左;

    	public 双目 目右;

    	public 双瞼 瞼左;

    	public 双瞼 瞼右;

    	public 縦目 額目;

    	public 縦瞼 額瞼;

    	public 頬目 頬目左;

    	public 頬目 頬目右;

    	public 頬瞼 頬瞼左;

    	public 頬瞼 頬瞼右;

    	public 涙 LeftTear;

    	public 涙 RightTear;

    	public 目隠帯 目隠帯;

    	public 鼻 鼻;

    	public 鼻水 LeftNoseDrip;

    	public 鼻水 RightNoseDrip;

    	public 口 口;

    	public Tounge Tounge;

    	public 涎 LeftDrool;

    	public 涎 RightDrool;

    	public 性器精液_人 MouthCum;

    	public Cough 咳;

    	public 呼気 呼気;

    	public 玉口枷 玉口枷;

    	public 単眼眉 単眼眉;

    	public 眉 眉左;

    	public 眉 眉右;

    	public 鼻肌 鼻肌;

    	public 頬肌 頬肌左;

    	public 頬肌 頬肌右;

    	public 目尻影 目尻影左;

    	public 目尻影 目尻影右;

    	public 紅潮 紅潮;

    	public 目傷 目傷左;

    	public 目傷 目傷右;

    	public 顔ハイライト 顔ハイライト左;

    	public 顔ハイライト 顔ハイライト右;

    	public 胸腹板 胸腹板_人;

    	public 胸肌 胸肌_人;

    	public 胸毛 胸毛_人;

    	public TorsoPlate TorsoPlate_人;

    	public TorsoSkin TorsoSkin_人;

    	public PregnantBelly_人 PregnantBelly_人;

    	public PregnantBellyPlate PregnantBellyPlate_人;

    	public WaistSkin WaistSkin_人;

    	public 乳房 乳房左;

    	public 乳房 乳房右;

    	public 噴乳 LeftMilkSpray;

    	public 噴乳 RightMilkSpary;

    	public ピアス ピアス左;

    	public ピアス ピアス右;

    	public キャップ2 キャップ2左;

    	public キャップ2 キャップ2右;

    	public VaginaOrigin_人 VaginaOrigin_人;

    	public InternalSemen_人 InternalSemen_人;

    	public XRay_人 XRay_人;

    	public 性器_人 性器_人;

    	public 性器精液_人 性器精液_人;

    	public 飛沫_人 飛沫_人;

    	public 潮吹_小_人 潮吹_小_人;

    	public 潮吹_大_人 潮吹_大_人;

    	public 放尿_人 放尿_人;

    	public ピアス ピアス;

    	public キャップ1 キャップ1;

    	public Anus_人 Anus_人;

    	public 肛門精液_人 肛門精液_人;

    	public 下着トップ_チューブ 下着T_チューブ;

    	public 下着トップ_クロス 下着T_クロス;

    	public 下着トップ_ビキニ 下着T_ビキニ;

    	public 下着トップ_マイクロ 下着T_マイクロ;

    	public 下着トップ_ブラ 下着T_ブラ;

    	public 下着乳首 下着乳首左;

    	public 下着乳首 下着乳首右;

    	public 下着ボトム_ノーマル 下着B_ノーマル;

    	public 下着ボトム_マイクロ 下着B_マイクロ;

    	public 下着陰核 下着陰核;

    	public 上着ミドル_ドレス 上着M_ドレス;

    	public 上着トップ_ドレス 上着T_ドレス;

    	public JacketBottom_クロス 上着B_クロス;

    	public JacketBottom_クロス後 上着B_クロス後;

    	public JacketBottom_前掛け 上着B_前掛け;

    	public 長物_魚 魚;

    	public 長物_鯨 鯨;

    	public 長物_蛇 蛇;

    	public DrawableElement 蛇前;

    	public 長物_蟲 蟲;

    	public 四足胸 Chest_獣;

    	public 四足胴 Torso_獣;

    	public 四足腰 Waist_獣;

    	public List<四足脇> 脇左_獣 = new List<四足脇>();

    	public List<四足脇> 脇右_獣 = new List<四足脇>();

    	public 胸肌 胸肌_獣;

    	public TorsoSkin TorsoSkin_獣;

    	public WaistSkin WaistSkin_獣;

    	public 胸毛 胸毛_獣;

    	public PregnantBelly_獣 PregnantBelly_獣;

    	public Anus_獣 Anus_獣;

    	public 肛門精液_獣 肛門精液_獣;

    	public VaginaOrigin_獣 VaginaOrigin_獣;

    	public InternalSemen_獣 InternalSemen_獣;

    	public XRay_獣 XRay_獣;

    	public 性器_獣 性器_獣;

    	public 性器精液_獣 性器精液_獣;

    	public 飛沫_獣 飛沫_獣;

    	public 潮吹_小_獣 潮吹_小_獣;

    	public 潮吹_大_獣 潮吹_大_獣;

    	public 放尿_獣 放尿_獣;

    	public 多足_蛸 蛸;

    	public 多足_蜘 蜘;

    	public 性器精液_人 ThreadCum;

    	public 多足_蠍 蠍;

    	public DrawableElement 蠍前;

    	public 単足_植 植;

    	public 単足_粘 粘;

    	private bool 涙描画;

    	private bool 鼻描画;

    	private List<Element> 後髪接続 = new List<Element>();

    	private List<Element> 額接続 = new List<Element>();

    	private List<Element> 耳左接続 = new List<Element>();

    	private List<Element> 耳右接続 = new List<Element>();

    	private List<Element> 頬左接続 = new List<Element>();

    	private List<Element> 頬右接続 = new List<Element>();

    	private List<Element> 頭頂左後接続 = new List<Element>();

    	private List<Element> 頭頂右後接続 = new List<Element>();

    	private List<角2> 角左接続 = new List<角2>();

    	private List<角2> 角右接続 = new List<角2>();

    	private List<Element> 植左接続 = new List<Element>();

    	private List<Element> 植右接続 = new List<Element>();

    	private List<Element> 触覚左接続 = new List<Element>();

    	private List<Element> 触覚右接続 = new List<Element>();

    	private List<Element> 顔触覚左接続 = new List<Element>();

    	private List<Element> 顔触覚右接続 = new List<Element>();

    	private List<Element> 大顎基接続 = new List<Element>();

    	private Shoulder[] 後脇左s = new Shoulder[0];

    	private Shoulder[] 後脇右s = new Shoulder[0];

    	public List<Element>[] 後腕左s = new List<Element>[0];

    	public List<Element>[] 後腕右s = new List<Element>[0];

    	private Shoulder 肩左;

    	private Shoulder 肩右;

    	private List<Element> 肩左飛膜 = new List<Element>();

    	private List<Element> 肩右飛膜 = new List<Element>();

    	private List<Element> 腕左 = new List<Element>();

    	private List<Element> 腕右 = new List<Element>();

    	private List<Element> LowerArm以降左 = new List<Element>();

    	private List<Element> LowerArm以降右 = new List<Element>();

    	private List<Element> 胸上左接続 = new List<Element>();

    	private List<Element> 胸上右接続 = new List<Element>();

    	private List<Element> 胸下左接続 = new List<Element>();

    	private List<Element> 胸下右接続 = new List<Element>();

    	private List<Element> 胴後左接続 = new List<Element>();

    	private List<Element> 胴後右接続 = new List<Element>();

    	private List<Element> 腰後左接続 = new List<Element>();

    	private List<Element> 腰後右接続 = new List<Element>();

    	private List<Element> 背中接続 = new List<Element>();

    	private List<Element> 腿左接続 = new List<Element>();

    	private List<Element> 腿右接続 = new List<Element>();

    	private List<Element> 尾接続 = new List<Element>();

    	private List<Element> 半身後接続 = new List<Element>();

    	private List<Element> 半身中1接続 = new List<Element>();

    	private List<Element> 半身中2接続 = new List<Element>();

    	private List<Element> 半身前接続 = new List<Element>();

    	public 顔面 顔面;

    	public 頭頂 頭頂;

    	public 頭頂後_宇 頭頂後;

    	public 耳 耳左;

    	public 耳 耳右;

    	public 獣耳 獣耳左;

    	public 獣耳 獣耳右;

    	public 触覚 触覚左;

    	public 触覚 触覚右;

    	public 触覚_甲 触覚甲左;

    	public 触覚_甲 触覚甲右;

    	public List<Arm人> Arm人左 = new List<Arm人>();

    	public List<Arm人> Arm人右 = new List<Arm人>();

    	public List<Arm翼鳥> 腕翼鳥左 = new List<Arm翼鳥>();

    	public List<Arm翼鳥> 腕翼鳥右 = new List<Arm翼鳥>();

    	public List<Arm翼獣> 腕翼獣左 = new List<Arm翼獣>();

    	public List<Arm翼獣> 腕翼獣右 = new List<Arm翼獣>();

    	public List<Arm獣> 腕獣左 = new List<Arm獣>();

    	public List<Arm獣> 腕獣右 = new List<Arm獣>();

    	public List<脚人> 脚人左 = new List<脚人>();

    	public List<脚人> 脚人右 = new List<脚人>();

    	public List<脚獣> 脚獣左 = new List<脚獣>();

    	public List<脚獣> 脚獣右 = new List<脚獣>();

    	public List<翼鳥> 翼鳥左 = new List<翼鳥>();

    	public List<翼鳥> 翼鳥右 = new List<翼鳥>();

    	public List<翼獣> 翼獣左 = new List<翼獣>();

    	public List<翼獣> 翼獣右 = new List<翼獣>();

    	public List<鰭> 鰭左 = new List<鰭>();

    	public List<鰭> 鰭右 = new List<鰭>();

    	public List<葉> 葉左 = new List<葉>();

    	public List<葉> 葉右 = new List<葉>();

    	public List<前翅> 前翅1左 = new List<前翅>();

    	public List<前翅> 前翅1右 = new List<前翅>();

    	public List<後翅> 後翅1左 = new List<後翅>();

    	public List<後翅> 後翅1右 = new List<後翅>();

    	public List<前翅> 前翅2左 = new List<前翅>();

    	public List<前翅> 前翅2右 = new List<前翅>();

    	public List<後翅> 後翅2左 = new List<後翅>();

    	public List<後翅> 後翅2右 = new List<後翅>();

    	public List<触肢_肢蜘> 触肢蜘左 = new List<触肢_肢蜘>();

    	public List<触肢_肢蜘> 触肢蜘右 = new List<触肢_肢蜘>();

    	public List<触肢_肢蠍> 触肢蠍左 = new List<触肢_肢蠍>();

    	public List<触肢_肢蠍> 触肢蠍右 = new List<触肢_肢蠍>();

    	public List<節足_足蜘> 節足蜘左 = new List<節足_足蜘>();

    	public List<節足_足蜘> 節足蜘右 = new List<節足_足蜘>();

    	public List<節足_足蠍> 節足蠍左 = new List<節足_足蠍>();

    	public List<節足_足蠍> 節足蠍右 = new List<節足_足蠍>();

    	public List<節足_足百> 節足百左 = new List<節足_足百>();

    	public List<節足_足百> 節足百右 = new List<節足_足百>();

    	public List<節尾_曳航> 節尾曳左 = new List<節尾_曳航>();

    	public List<節尾_曳航> 節尾曳右 = new List<節尾_曳航>();

    	public List<節尾_鋏> 節尾鋏左 = new List<節尾_鋏>();

    	public List<節尾_鋏> 節尾鋏右 = new List<節尾_鋏>();

    	public List<大顎> 大顎左 = new List<大顎>();

    	public List<大顎> 大顎右 = new List<大顎>();

    	public List<虫顎> 虫顎左 = new List<虫顎>();

    	public List<虫顎> 虫顎右 = new List<虫顎>();

    	public List<虫鎌> 虫鎌左 = new List<虫鎌>();

    	public List<虫鎌> 虫鎌右 = new List<虫鎌>();

    	public List<触手> 触手左 = new List<触手>();

    	public List<触手> 触手右 = new List<触手>();

    	public List<触手_犬> 触手犬左 = new List<触手_犬>();

    	public List<触手_犬> 触手犬右 = new List<触手_犬>();

    	public List<尾> 尾 = new List<尾>();

    	public List<長胴> 長胴 = new List<長胴>();

    	public スタンプK[] キスマーク;

    	public スタンプW[] 鞭痕;

    	public Sweat 汗掻き;

    	public スタンプB ぶっかけ小;

    	public スタンプB ぶっかけ大;

    	private Dictionary<Element, List<Element>> ぶっかけr = new Dictionary<Element, List<Element>>();

    	public TrainingUI カーソル;

    	private bool cb0;

    	private bool cb1;

    	private bool fi;

    	private double nsb1;

    	private double nsb2;

    	private double csb;

    	private double asb1;

    	private double asb2;

    	public ElementInstance EIChest;

    	public ElementInstance EI髪;

    	public ElementInstance EIWaist;

    	public ElementInstance EI半後;

    	public ElementInstance EI半中1;

    	public ElementInstance EI半中2;

    	public ElementInstance EI半前;

    	public ElementInstance EI腕前;

    	public ElementInstance EI腿;

    	public HashSet<ElementInstance> eis = new HashSet<ElementInstance>();

    	public bool Is髪;

    	public bool IsChest;

    	public bool IsWaist;

    	public bool Is腕前;

    	public bool Is半後;

    	public bool Is半中1;

    	public bool Is半中2;

    	public bool Is半前;

    	public bool Is腿;

    	public bool Is双眉;

    	public bool Is単眉;

    	public bool Is瞼宇;

    	public bool Is人耳;

    	public bool Is獣耳;

    	public bool Is頭頂_宇;

    	public bool Is虫角;

    	public bool Is虫角前;

    	public bool Is鬼角;

    	public bool Is貧乳;

    	public bool Is半身;

    	public bool Is獣;

    	public bool Is蛇;

    	public bool Is魚;

    	public bool Is鯨;

    	public bool Is蜘;

    	public bool Is蠍;

    	public bool Is蛸;

    	public bool Is蟲;

    	public bool Is植;

    	public bool Is粘;

    	public bool Is長物;

    	public bool Is海洋;

    	public bool Is多足;

    	public bool Is頭頂;

    	public bool Is顔面;

    	public bool Is大顎基;

    	public bool Is額角;

    	public bool Is触覚;

    	public bool Is触覚他;

    	public bool Is触覚甲;

    	public bool Is蜘尾;

    	public bool IsDualEyes;

    	public bool IsSingleEye;

    	public bool IsCheekEyes;

    	public bool IsForeheadEye;

    	public bool Is舌股;

    	public bool Is最前腕人;

    	public bool Is最前手人;

    	public bool Is腕人;

    	public bool Is腕鳥;

    	public bool Is腕蝙;

    	public bool Is腕獣;

    	public bool Is腕蠍;

    	public bool Is腿人;

    	public bool Is腿獣;

    	public bool Is腿魚;

    	public bool Is腿犬;

    	private Action<RenderArea> Draw = delegate
    	{
    	};

    	public bool 処女喪失;

    	public VaginaOrigin VaginaOrigin;

    	public InternalSemen VaginalCumDrip;

    	public XRay XRay;

    	public 性器 性器;

    	public 性器精液 GenetalCum;

    	public 飛沫 Splash;

    	public 潮吹_小 潮吹_小;

    	public 潮吹_大 潮吹_大;

    	public 放尿 Urination;

    	public Anus Anus;

    	public 肛門精液 AnalCum;

    	public 尾_蜘 蜘尾;

    	public 染み_人 染み_人;

    	public 染み_獣 染み_獣;

    	private double 体紅潮_;

    	private double 子宮下がり_;

    	private double Anusy;

    	private double Anusv;

    	private double 肛門開き_;

    	private double r8 = 0.004.Pow(2.0);

    	private double r10 = 0.005.Pow(2.0);

    	private double r17 = (7.0 / 800.0).Pow(2.0);

    	private double r35 = 0.0175.Pow(2.0);

    	public bool 腕左右前後;

    	private bool[] nsl;

    	private bool[] nsr;

    	private bool 腕左前後_;

    	private bool 腕右前後_;

    	public bool 胸左右前後;

    	public bool 腿左右前後;

    	private int Waist_人y;

    	private int Waist_獣y;

    	private 髪留2情報 後髪髪留i;

    	private 髪留2情報 横髪髪留i;

    	private 玉口枷情報 玉口枷i;

    	private 目隠帯情報 目隠帯i;

    	private 拘束具情報 拘束具i;

    	private ピアス情報 ピアスi;

    	private ピアス情報 ピアス左i;

    	private ピアス情報 ピアス右i;

    	private キャップ情報 キャップ1i;

    	private キャップ情報 キャップ2左i;

    	private キャップ情報 キャップ2右i;

    	private ドレス首情報 ドレス首i;

    	private 下着T_チューブ情報 下着T_チューブi;

    	private 下着T_クロス情報 下着T_クロスi;

    	private 下着T_ビキニ情報 下着T_ビキニi;

    	private 下着T_マイクロ情報 下着T_マイクロi;

    	private 下着T_ブラ情報 下着T_ブラi;

    	private 下着B_ノーマル情報 下着B_ノーマルi;

    	private 下着B_マイクロ情報 下着B_マイクロi;

    	private ドレス情報 ドレスi;

    	private 上着B_クロス情報 上着B_クロスi;

    	private 上着B_前掛け情報 上着B_前掛けi;

    	private ブーツ情報 ブーツi;

    	public int Arm人n;

    	public int 腕翼鳥n;

    	public int 腕翼獣n;

    	public int 腕獣n;

    	public int 脚人n;

    	public int 脚獣n;

    	public int 翼鳥n;

    	public int 翼獣n;

    	public int 鰭n;

    	public int 葉n;

    	public int 前翅1n;

    	public int 後翅1n;

    	public int 前翅2n;

    	public int 後翅2n;

    	public int 触肢蜘n;

    	public int 触肢蠍n;

    	public int 節足蜘n;

    	public int 節足蠍n;

    	public int 節足百n;

    	public int 節尾曳n;

    	public int 節尾鋏n;

    	public int 大顎n;

    	public int 虫顎n;

    	public int 虫鎌n;

    	public int 触手n;

    	public int 触手犬n;

    	public int 尾n;

    	public int 長胴n;

    	public bool Tounge_表示
    	{
    		get
    		{
    			return Tounge.表示;
    		}
    		set
    		{
    			Tounge.表示 = value;
    			Tounge.SetValues("股", value && Is舌股);
    		}
    	}

    	public bool XRay_表示
    	{
    		get
    		{
    			if (!VaginaOrigin.表示 && !VaginalCumDrip.表示)
    			{
    				return XRay.表示;
    			}
    			return true;
    		}
    		set
    		{
    			VaginaOrigin.表示 = value;
    			VaginalCumDrip.精液_表示 = value;
    			XRay.表示 = value;
    			if (処女喪失)
    			{
    				VaginalCumDrip.血液1_表示 = value;
    				VaginalCumDrip.血液2_表示 = value;
    			}
    			if (value)
    			{
    				if (Is獣)
    				{
    					XRay_獣.子宮_表示 = !PregnantBelly_表示;
    					XRay_獣.子宮口_表示 = !PregnantBelly_表示;
    					XRay_獣.子宮内_表示 = !PregnantBelly_表示;
    					XRay_獣.卵管左_表示 = !PregnantBelly_表示;
    					XRay_獣.卵巣左_表示 = !PregnantBelly_表示;
    					XRay_獣.卵管右_表示 = !PregnantBelly_表示;
    					XRay_獣.卵巣右_表示 = !PregnantBelly_表示;
    					XRay_獣.精液_表示 = !PregnantBelly_表示;
    				}
    				else
    				{
    					XRay_人.子宮_表示 = !PregnantBelly_表示;
    					XRay_人.子宮口_表示 = !PregnantBelly_表示;
    					XRay_人.子宮内_表示 = !PregnantBelly_表示;
    					XRay_人.卵管左_表示 = !PregnantBelly_表示;
    					XRay_人.卵巣左_表示 = !PregnantBelly_表示;
    					XRay_人.卵管右_表示 = !PregnantBelly_表示;
    					XRay_人.卵巣右_表示 = !PregnantBelly_表示;
    					XRay_人.精液_表示 = !PregnantBelly_表示;
    				}
    			}
    		}
    	}

    	public bool PregnantBelly_表示
    	{
    		get
    		{
    			if (!Is獣)
    			{
    				return PregnantBelly_人.表示;
    			}
    			return PregnantBelly_獣.表示;
    		}
    		set
    		{
    			if (Is獣)
    			{
    				PregnantBelly_獣.表示 = value;
    				return;
    			}
    			if (!PregnantBelly_人.表示 && value)
    			{
    				PregnantBellyPlate_人.腹板1_腹板_表示 = 胸腹板_人.虫性_腹板_表示;
    				PregnantBellyPlate_人.腹板1_縦線_表示 = 胸腹板_人.虫性_縦線_表示;
    				PregnantBellyPlate_人.腹板2_腹板_表示 = TorsoPlate_人.虫性_腹板_表示;
    				PregnantBellyPlate_人.腹板2_縦線_表示 = TorsoPlate_人.虫性_縦線_表示;
    				PregnantBellyPlate_人.腹板3_腹板_表示 = WaistSkin_人.虫性_腹板1_腹板_表示;
    				PregnantBellyPlate_人.腹板3_縦線_表示 = WaistSkin_人.虫性_腹板1_縦線_表示;
    				PregnantBellyPlate_人.腹板4_腹板_表示 = WaistSkin_人.虫性_腹板2_腹板_表示;
    				PregnantBellyPlate_人.腹板4_縦線_表示 = WaistSkin_人.虫性_腹板2_縦線_表示;
    				胸腹板_人.虫性_腹板_表示 = false;
    				胸腹板_人.虫性_縦線_表示 = false;
    				TorsoPlate_人.虫性_腹板_表示 = false;
    				TorsoPlate_人.虫性_縦線_表示 = false;
    				WaistSkin_人.虫性_腹板1_腹板_表示 = false;
    				WaistSkin_人.虫性_腹板1_縦線_表示 = false;
    				WaistSkin_人.虫性_腹板2_腹板_表示 = false;
    				WaistSkin_人.虫性_腹板2_縦線_表示 = false;
    			}
    			else if (PregnantBelly_人.表示 && !value)
    			{
    				胸腹板_人.虫性_腹板_表示 = PregnantBellyPlate_人.腹板1_腹板_表示;
    				胸腹板_人.虫性_縦線_表示 = PregnantBellyPlate_人.腹板1_縦線_表示;
    				TorsoPlate_人.虫性_腹板_表示 = PregnantBellyPlate_人.腹板2_腹板_表示;
    				TorsoPlate_人.虫性_縦線_表示 = PregnantBellyPlate_人.腹板2_縦線_表示;
    				WaistSkin_人.虫性_腹板1_腹板_表示 = PregnantBellyPlate_人.腹板3_腹板_表示;
    				WaistSkin_人.虫性_腹板1_縦線_表示 = PregnantBellyPlate_人.腹板3_縦線_表示;
    				WaistSkin_人.虫性_腹板2_腹板_表示 = PregnantBellyPlate_人.腹板4_腹板_表示;
    				WaistSkin_人.虫性_腹板2_縦線_表示 = PregnantBellyPlate_人.腹板4_縦線_表示;
    				PregnantBellyPlate_人.腹板1_腹板_表示 = false;
    				PregnantBellyPlate_人.腹板1_縦線_表示 = false;
    				PregnantBellyPlate_人.腹板2_腹板_表示 = false;
    				PregnantBellyPlate_人.腹板2_縦線_表示 = false;
    				PregnantBellyPlate_人.腹板3_腹板_表示 = false;
    				PregnantBellyPlate_人.腹板3_縦線_表示 = false;
    				PregnantBellyPlate_人.腹板4_腹板_表示 = false;
    				PregnantBellyPlate_人.腹板4_縦線_表示 = false;
    			}
    			PregnantBelly_人.表示 = value;
    		}
    	}

    	public Vector2D 胸部位置
    	{
    		get
    		{
    			Chest.接続P();
    			return Chest.X0Y0_RibCage.ToGlobal((Chest.X0Y0_RibCage.GetOP()[8].ps[2] + Chest.X0Y0_RibCage.GetOP()[2].ps[2]) * 0.5);
    		}
    	}

    	public Vector2D 局部位置
    	{
    		get
    		{
    			性器.接続P();
    			Anus.接続P();
    			return (性器.位置 + Anus.位置) * 0.5;
    		}
    	}

    	public Vector2D 口腔位置
    	{
    		get
    		{
    			口.接続P();
    			return 口.位置;
    		}
    	}

    	public Vector2D 陰核位置
    	{
    		get
    		{
    			ShapePart shapePart = 性器.Body.GetCurrent().EnumAllPar().First((ShapePart e) => e.Tag == "陰核");
    			性器.接続PA();
    			return shapePart.ToGlobal(shapePart.GetBasePointBase().AddY(-0.003));
    		}
    	}

    	public Vector2D 乳首左位置
    	{
    		get
    		{
    			ShapePart shapePart = 乳房左.Body.GetCurrent().EnumAllPar().First((ShapePart e) => e.Tag == "乳首");
    			乳房左.接続PA();
    			return shapePart.ToGlobal(shapePart.GetBasePointBase());
    		}
    	}

    	public Vector2D 乳首右位置
    	{
    		get
    		{
    			ShapePart shapePart = 乳房右.Body.GetCurrent().EnumAllPar().First((ShapePart e) => e.Tag == "乳首");
    			乳房右.接続PA();
    			return shapePart.ToGlobal(shapePart.GetBasePointBase());
    		}
    	}

    	public Vector2D 尿道位置
    	{
    		get
    		{
    			ShapePart shapePart = 性器.Body.GetCurrent().EnumAllPar().First((ShapePart e) => e.Tag == "尿道");
    			性器.接続PA();
    			return shapePart.ToGlobal(shapePart.GetBasePointBase());
    		}
    	}

    	public Vector2D 膣口位置
    	{
    		get
    		{
    			ShapePart shapePart = 性器.Body.GetCurrent().EnumAllPar().First((ShapePart e) => e.Tag == "膣口");
    			性器.接続PA();
    			return shapePart.GetPosition();
    		}
    	}

    	public Vector2D 肛門位置
    	{
    		get
    		{
    			Anus.接続PA();
    			return Anus.位置;
    		}
    	}

    	public Vector2D 出糸位置
    	{
    		get
    		{
    			蜘尾.接続PA();
    			return 蜘尾.X0Y0_出糸突起後_出糸突起基.GetPosition();
    		}
    	}

    	public double 頬濃度
    	{
    		get
    		{
    			if (!(口 is 口_通常))
    			{
    				return 0.0;
    			}
    			return ((口_通常)口).頬左CD.不透明度;
    		}
    		set
    		{
    			if (口 is 口_通常)
    			{
    				口_通常 obj = (口_通常)口;
    				obj.頬左CD.不透明度 = value;
    				obj.頬右CD.不透明度 = value;
    			}
    		}
    	}

    	public double 汗染み濃度
    	{
    		get
    		{
    			return 染み_人.汗CD.不透明度;
    		}
    		set
    		{
    			if (染み_人 != null)
    			{
    				染み_人.汗CD.不透明度 = value;
    			}
    			if (Is獣)
    			{
    				染み_獣.汗CD.不透明度 = value;
    			}
    		}
    	}

    	public double UrineStainIntensity
    	{
    		get
    		{
    			if (!Is獣)
    			{
    				return 染み_人.尿1CD.不透明度;
    			}
    			return 染み_獣.尿1CD.不透明度;
    		}
    		set
    		{
    			if (Is獣)
    			{
    				染み_獣.尿1CD.不透明度 = value;
    				染み_獣.尿2CD.不透明度 = value;
    			}
    			else
    			{
    				染み_人.尿1CD.不透明度 = value;
    				染み_人.尿2CD.不透明度 = value;
    			}
    		}
    	}

    	public double SquirtStainIntensity
    	{
    		get
    		{
    			if (!Is獣)
    			{
    				return 染み_人.潮3CD.不透明度;
    			}
    			return 染み_獣.潮3CD.不透明度;
    		}
    		set
    		{
    			if (Is獣)
    			{
    				染み_獣.潮3CD.不透明度 = value;
    			}
    			else
    			{
    				染み_人.潮3CD.不透明度 = value;
    			}
    		}
    	}

    	public double SplashIntencity
    	{
    		get
    		{
    			if (!Is獣)
    			{
    				return 染み_人.潮2CD.不透明度;
    			}
    			return 染み_獣.潮2CD.不透明度;
    		}
    		set
    		{
    			if (Is獣)
    			{
    				染み_獣.潮1CD.不透明度 = value;
    				染み_獣.潮2CD.不透明度 = value;
    			}
    			else
    			{
    				染み_人.潮1CD.不透明度 = value;
    				染み_人.潮2CD.不透明度 = value;
    			}
    		}
    	}

    	public double 湯気左濃度
    	{
    		get
    		{
    			if (!Is獣)
    			{
    				return 染み_人.湯気_湯気左1_湯気1CD.不透明度;
    			}
    			return 染み_獣.湯気_湯気左1_湯気1CD.不透明度;
    		}
    		set
    		{
    			if (Is獣)
    			{
    				染み_獣.湯気_湯気左1_湯気1CD.不透明度 = value;
    				染み_獣.湯気_湯気左1_湯気2CD.不透明度 = value;
    				染み_獣.湯気_湯気左2_湯気1CD.不透明度 = value;
    				染み_獣.湯気_湯気左2_湯気2CD.不透明度 = value;
    				染み_獣.湯気_湯気左3_湯気1CD.不透明度 = value;
    				染み_獣.湯気_湯気左3_湯気2CD.不透明度 = value;
    			}
    			else
    			{
    				染み_人.湯気_湯気左1_湯気1CD.不透明度 = value;
    				染み_人.湯気_湯気左1_湯気2CD.不透明度 = value;
    				染み_人.湯気_湯気左2_湯気1CD.不透明度 = value;
    				染み_人.湯気_湯気左2_湯気2CD.不透明度 = value;
    				染み_人.湯気_湯気左3_湯気1CD.不透明度 = value;
    				染み_人.湯気_湯気左3_湯気2CD.不透明度 = value;
    			}
    		}
    	}

    	public double 湯気右濃度
    	{
    		get
    		{
    			if (!Is獣)
    			{
    				return 染み_人.湯気_湯気右1_湯気1CD.不透明度;
    			}
    			return 染み_獣.湯気_湯気右1_湯気1CD.不透明度;
    		}
    		set
    		{
    			if (Is獣)
    			{
    				染み_獣.湯気_湯気右1_湯気1CD.不透明度 = value;
    				染み_獣.湯気_湯気右1_湯気2CD.不透明度 = value;
    				染み_獣.湯気_湯気右2_湯気1CD.不透明度 = value;
    				染み_獣.湯気_湯気右2_湯気2CD.不透明度 = value;
    				染み_獣.湯気_湯気右3_湯気1CD.不透明度 = value;
    				染み_獣.湯気_湯気右3_湯気2CD.不透明度 = value;
    			}
    			else
    			{
    				染み_人.湯気_湯気右1_湯気1CD.不透明度 = value;
    				染み_人.湯気_湯気右1_湯気2CD.不透明度 = value;
    				染み_人.湯気_湯気右2_湯気1CD.不透明度 = value;
    				染み_人.湯気_湯気右2_湯気2CD.不透明度 = value;
    				染み_人.湯気_湯気右3_湯気1CD.不透明度 = value;
    				染み_人.湯気_湯気右3_湯気2CD.不透明度 = value;
    			}
    		}
    	}

    	public double 下着B染み
    	{
    		get
    		{
    			return 下着B_ノーマル.染み濃度;
    		}
    		set
    		{
    			下着B_ノーマル.染み濃度 = value;
    			下着B_マイクロ.染み濃度 = value;
    		}
    	}

    	public double 下着T染み
    	{
    		get
    		{
    			return 下着乳首左.染み濃度;
    		}
    		set
    		{
    			下着乳首左.染み濃度 = value;
    			下着乳首右.染み濃度 = value;
    		}
    	}

    	public double 上着B染み
    	{
    		get
    		{
    			return 上着B_クロス後.染み濃度;
    		}
    		set
    		{
    			上着B_クロス後.染み濃度 = value;
    		}
    	}

    	public double 陰核勃起
    	{
    		get
    		{
    			return 下着陰核.Intensity;
    		}
    		set
    		{
    			下着陰核.Intensity = value;
    			double sizeCont = 1.0 + 0.1 * value;
    			if (Is獣)
    			{
    				性器_獣.X0Y0_陰核.SetSizeCont(sizeCont);
    				性器_獣.X0Y1_陰核.SetSizeCont(sizeCont);
    				性器_獣.X0Y2_陰核.SetSizeCont(sizeCont);
    				性器_獣.X0Y3_陰核.SetSizeCont(sizeCont);
    				性器_獣.X0Y4_陰核.SetSizeCont(sizeCont);
    			}
    			else
    			{
    				性器_人.X0Y0_陰核.SetSizeCont(sizeCont);
    				性器_人.X0Y1_陰核.SetSizeCont(sizeCont);
    				性器_人.X0Y2_陰核.SetSizeCont(sizeCont);
    				性器_人.X0Y3_陰核.SetSizeCont(sizeCont);
    				性器_人.X0Y4_陰核.SetSizeCont(sizeCont);
    			}
    		}
    	}

    	public double 乳首勃起
    	{
    		get
    		{
    			return 下着乳首左.乳首CD.不透明度;
    		}
    		set
    		{
    			下着乳首左.乳首CD.不透明度 = value;
    			下着乳首右.乳首CD.不透明度 = value;
    			double sizeCont = 1.0 + 0.1 * value;
    			乳房左.X0Y0_乳首.SetSizeCont(sizeCont);
    			乳房左.X0Y1_乳首.SetSizeCont(sizeCont);
    			乳房左.X0Y2_乳首.SetSizeCont(sizeCont);
    			乳房左.X0Y3_乳首.SetSizeCont(sizeCont);
    			乳房左.X0Y4_乳首.SetSizeCont(sizeCont);
    			乳房右.X0Y0_乳首.SetSizeCont(sizeCont);
    			乳房右.X0Y1_乳首.SetSizeCont(sizeCont);
    			乳房右.X0Y2_乳首.SetSizeCont(sizeCont);
    			乳房右.X0Y3_乳首.SetSizeCont(sizeCont);
    			乳房右.X0Y4_乳首.SetSizeCont(sizeCont);
    		}
    	}

    	public double 顔紅潮
    	{
    		get
    		{
    			return 紅潮.Intensity;
    		}
    		set
    		{
    			紅潮.Intensity = value;
    			if (頬瞼左 != null)
    			{
    				頬瞼左.瞼左_瞼CD.色 = Cha.CharacterData.body_color.人肌.BlendP1(Color.FromArgb((int)(128.0 * value), Cha.CharacterData.body_color.粘膜)).GetSkinGrad();
    				頬瞼左.瞼右_瞼CD.色 = Cha.CharacterData.body_color.人肌.BlendP1(Color.FromArgb((int)(128.0 * value), Cha.CharacterData.body_color.粘膜)).GetSkinGrad();
    			}
    			if (頬瞼右 != null)
    			{
    				頬瞼右.瞼左_瞼CD.色 = Cha.CharacterData.body_color.人肌.BlendP1(Color.FromArgb((int)(128.0 * value), Cha.CharacterData.body_color.粘膜)).GetSkinGrad();
    				頬瞼右.瞼右_瞼CD.色 = Cha.CharacterData.body_color.人肌.BlendP1(Color.FromArgb((int)(128.0 * value), Cha.CharacterData.body_color.粘膜)).GetSkinGrad();
    			}
    		}
    	}

    	public double 体紅潮
    	{
    		get
    		{
    			return 体紅潮_;
    		}
    		set
    		{
    			体紅潮_ = value;
    			ColorHelper.Alpha(ref Cha.CharacterData.body_color.粘膜, (int)(24.0 * 体紅潮_), out var ret);
    			Set人肌色(Cha.CharacterData.body_color.人肌.BlendP1(ret));
    		}
    	}

    	public double 子宮下がり
    	{
    		get
    		{
    			return 子宮下がり_;
    		}
    		set
    		{
    			子宮下がり_ = value;
    			double num = -0.003;
    			if (Is獣)
    			{
    				XRay_獣.X0Y0_子宮.SetBasePointCont(DataConsts.Vec2DUnitY * num * 子宮下がり_);
    				XRay_獣.X0Y1_子宮.SetBasePointCont(DataConsts.Vec2DUnitY * num * 子宮下がり_);
    				XRay_獣.X0Y2_子宮.SetBasePointCont(DataConsts.Vec2DUnitY * num * 子宮下がり_);
    				XRay_獣.X0Y3_子宮.SetBasePointCont(DataConsts.Vec2DUnitY * num * 子宮下がり_);
    				XRay_獣.X0Y4_子宮.SetBasePointCont(DataConsts.Vec2DUnitY * num * 子宮下がり_);
    			}
    			else
    			{
    				XRay_人.X0Y0_子宮.SetBasePointCont(DataConsts.Vec2DUnitY * num * 子宮下がり_);
    				XRay_人.X0Y1_子宮.SetBasePointCont(DataConsts.Vec2DUnitY * num * 子宮下がり_);
    				XRay_人.X0Y2_子宮.SetBasePointCont(DataConsts.Vec2DUnitY * num * 子宮下がり_);
    				XRay_人.X0Y3_子宮.SetBasePointCont(DataConsts.Vec2DUnitY * num * 子宮下がり_);
    				XRay_人.X0Y4_子宮.SetBasePointCont(DataConsts.Vec2DUnitY * num * 子宮下がり_);
    			}
    		}
    	}

    	public double 肛門開き
    	{
    		get
    		{
    			return 肛門開き_;
    		}
    		set
    		{
    			肛門開き_ = value;
    			double num = 2.0;
    			double num2 = 4.0;
    			double num3 = 2.0;
    			if (Is獣)
    			{
    				Anus_獣.X0Y0_Anus1.SetSizeYBase(Anusy + num * 肛門開き_);
    				Anus_獣.X0Y0_Anus1.SetSizeBase(Anusv + num2 * 肛門開き_);
    				Anus_獣.X0Y0_Anus2.SetSizeBase(Anusv + num3 * 肛門開き_);
    			}
    			else
    			{
    				Anus_人.X0Y0_Anus1.SetSizeYBase(Anusy + num * 肛門開き_);
    				Anus_人.X0Y0_Anus1.SetSizeBase(Anusv + num2 * 肛門開き_);
    				Anus_人.X0Y0_Anus2.SetSizeBase(Anusv + num3 * 肛門開き_);
    			}
    		}
    	}

    	public double AnusC
    	{
    		set
    		{
    			if (Is獣)
    			{
    				Anus_獣.X0Y0_Anus1.SetSizeCont(value);
    				Anus_獣.X0Y0_Anus1.SetSizeCont(value);
    			}
    			else
    			{
    				Anus_人.X0Y0_Anus1.SetSizeCont(value);
    				Anus_人.X0Y0_Anus1.SetSizeCont(value);
    			}
    		}
    	}

    	public double 膣腔C
    	{
    		set
    		{
    			if (Is獣)
    			{
    				性器_獣.X0Y0_膣口.SetSizeCont(value);
    			}
    			else
    			{
    				性器_人.X0Y0_膣口.SetSizeCont(value);
    			}
    		}
    	}

    	public double 出糸C
    	{
    		set
    		{
    			if (value != 0.0)
    			{
    				蜘尾.X0Y0_出糸突起後_出糸突起中.SetSizeYCont(0.8 + 0.2 * Rng.XS.NextDouble());
    			}
    			else
    			{
    				蜘尾.X0Y0_出糸突起後_出糸突起中.SetSizeYCont(1.0);
    			}
    			蜘尾.X0Y0_出糸突起後_出糸突起左.SetAngleCont(value * Rng.XS.NextDouble());
    			蜘尾.X0Y0_出糸突起後_出糸突起右.SetAngleCont((0.0 - value) * Rng.XS.NextDouble());
    			蜘尾.X0Y0_出糸突起左_出糸突起1.SetAngleCont(value * Rng.XS.NextDouble());
    			蜘尾.X0Y0_出糸突起右_出糸突起1.SetAngleCont((0.0 - value) * Rng.XS.NextDouble());
    			蜘尾.X0Y0_出糸突起前_出糸突起左.SetAngleCont(value * Rng.XS.NextDouble());
    			蜘尾.X0Y0_出糸突起前_出糸突起右.SetAngleCont((0.0 - value) * Rng.XS.NextDouble());
    			if (Is髪 && EI髪.ElesH.Contains(蜘尾))
    			{
    				EI髪.Updatef = true;
    			}
    			else if (IsChest && EIChest.ElesH.Contains(蜘尾))
    			{
    				EIChest.Updatef = true;
    			}
    			else if (IsWaist && EIWaist.ElesH.Contains(蜘尾))
    			{
    				EIWaist.Updatef = true;
    			}
    			else if (Is腕前 && EI腕前.ElesH.Contains(蜘尾))
    			{
    				EI腕前.Updatef = true;
    			}
    			else if (Is半後 && EI半後.ElesH.Contains(蜘尾))
    			{
    				EI半後.Updatef = true;
    			}
    			else if (Is半中1 && EI半中1.ElesH.Contains(蜘尾))
    			{
    				EI半中1.Updatef = true;
    			}
    			else if (Is半中2 && EI半中2.ElesH.Contains(蜘尾))
    			{
    				EI半中2.Updatef = true;
    			}
    			else if (Is半前 && EI半前.ElesH.Contains(蜘尾))
    			{
    				EI半前.Updatef = true;
    			}
    		}
    	}

    	public double くぱぁ0
    	{
    		get
    		{
    			return 性器.くぱぁ;
    		}
    		set
    		{
    			性器.くぱぁ = value;
    		}
    	}

    	public double くぱぁ1
    	{
    		get
    		{
    			if (!Is蛇)
    			{
    				if (!Is蠍)
    				{
    					return 0.0;
    				}
    				return 蠍.くぱぁ;
    			}
    			return 蛇.くぱぁ;
    		}
    		set
    		{
    			if (Is蛇)
    			{
    				蛇.くぱぁ = value;
    			}
    			else if (Is蠍)
    			{
    				蠍.くぱぁ = value;
    			}
    		}
    	}

    	public bool 捲り判定0
    	{
    		get
    		{
    			if (左腿開きi <= 0 && 右腿開きi <= 0 && !Is腿犬 && !Is腿魚 && !Is腿獣 && (!Is獣 || Chest_獣.脇左_接続 == null || Chest_獣.脇左_接続.Length == 0) && !Is蜘 && !Is蠍)
    			{
    				return Is蟲;
    			}
    			return true;
    		}
    	}

    	public bool 捲り判定1 => false;

    	public double HipMotion_人v
    	{
    		get
    		{
    			return Waist.Yv;
    		}
    		set
    		{
    			Waist.Yv = value;
    			WaistSkin_人.Yv = value;
    			下着B_ノーマル.Yv = value;
    			下着B_マイクロ.Yv = value;
    			性器_人.Body.SetSizeYCont(0.65 + Waist.Yv * 0.35);
    			foreach (ShapePart item in 性器_人.Body.EnumJoinRoot)
    			{
    				item.SetPositionCont(DataConsts.Vec2DUnitY * (Waist.Yv * 0.001 + 0.001));
    			}
    			Anus_人.Body.SetSizeYCont(0.65 + Waist.Yv * 0.35);
    			foreach (ShapePart item2 in 上着B_クロス.Body.EnumJoinRoot)
    			{
    				item2.SetPositionCont(DataConsts.Vec2DUnitY * (Waist.Yv * 0.003));
    			}
    			foreach (ShapePart item3 in 上着B_前掛け.Body.EnumJoinRoot)
    			{
    				item3.SetPositionCont(DataConsts.Vec2DUnitY * (Waist.Yv * 0.003));
    			}
    			腰振り_人();
    		}
    	}

    	public int 腰振り_人i
    	{
    		get
    		{
    			return Waist.Yi;
    		}
    		set
    		{
    			Waist.Yi = value;
    			WaistSkin_人.Yi = value;
    			下着B_ノーマル.Yi = value;
    			下着B_マイクロ.Yi = value;
    			性器_人.Body.SetSizeYCont(0.65 + Waist.Yv * 0.35);
    			foreach (ShapePart item in 性器_人.Body.EnumJoinRoot)
    			{
    				item.SetPositionCont(DataConsts.Vec2DUnitY * (Waist.Yv * 0.001 + 0.001));
    			}
    			Anus_人.Body.SetSizeYCont(0.65 + Waist.Yv * 0.35);
    			foreach (ShapePart item2 in 上着B_クロス.Body.EnumJoinRoot)
    			{
    				item2.SetPositionCont(DataConsts.Vec2DUnitY * (Waist.Yv * 0.003));
    			}
    			foreach (ShapePart item3 in 上着B_前掛け.Body.EnumJoinRoot)
    			{
    				item3.SetPositionCont(DataConsts.Vec2DUnitY * (Waist.Yv * 0.003));
    			}
    			腰振り_人();
    		}
    	}

    	public double 腰振り_獣v
    	{
    		get
    		{
    			return Waist_獣.Yv;
    		}
    		set
    		{
    			Waist_獣.Yv = value;
    			WaistSkin_獣.Yv = value;
    			性器_獣.Body.SetSizeYCont(0.65 + Waist_獣.Yv * 0.35);
    			foreach (ShapePart item in 性器_獣.Body.EnumJoinRoot)
    			{
    				item.SetPositionCont(DataConsts.Vec2DUnitY * (Waist_獣.Yv * 0.001 + 0.001));
    			}
    			Anus_獣.Body.SetSizeYCont(0.65 + Waist_獣.Yv * 0.35);
    			腰振り_獣();
    		}
    	}

    	public int 腰振り_獣i
    	{
    		get
    		{
    			return Waist_獣.Yi;
    		}
    		set
    		{
    			Waist_獣.Yi = value;
    			WaistSkin_獣.Yi = value;
    			性器_獣.Body.SetSizeYCont(0.65 + Waist_獣.Yv * 0.35);
    			foreach (ShapePart item in 性器_獣.Body.EnumJoinRoot)
    			{
    				item.SetPositionCont(DataConsts.Vec2DUnitY * (Waist_獣.Yv * 0.001 + 0.001));
    			}
    			Anus_獣.Body.SetSizeYCont(0.65 + Waist_獣.Yv * 0.35);
    			腰振り_獣();
    		}
    	}

    	public double HipMotionValue
    	{
    		get
    		{
    			if (!Is獣)
    			{
    				return HipMotion_人v;
    			}
    			return 腰振り_獣v;
    		}
    		set
    		{
    			if (Is獣)
    			{
    				腰振り_獣v = value;
    			}
    			else
    			{
    				HipMotion_人v = value;
    			}
    		}
    	}

    	public int 腰振りi
    	{
    		get
    		{
    			if (!Is獣)
    			{
    				return 腰振り_人i;
    			}
    			return 腰振り_獣i;
    		}
    		set
    		{
    			if (Is獣)
    			{
    				腰振り_獣i = value;
    			}
    			else
    			{
    				腰振り_人i = value;
    			}
    		}
    	}

    	public bool Is初期腰
    	{
    		get
    		{
    			if (Is獣)
    			{
    				return 腰振り_獣i != 0;
    			}
    			return 腰振り_人i != 0;
    		}
    	}

    	public double 腿開きv
    	{
    		get
    		{
    			if (脚人左.Count > 0)
    			{
    				return 脚人左[0].腿.Yv;
    			}
    			if (脚人右.Count > 0)
    			{
    				return 脚人右[0].腿.Yv;
    			}
    			return 0.0;
    		}
    		set
    		{
    			if (脚人左.Count > 0)
    			{
    				脚人 脚人2 = 脚人左[0];
    				脚人2.腿.Yv = value;
    				if (脚人2.Leg != null)
    				{
    					脚人2.Leg.開脚(脚人2.腿);
    				}
    				if (脚人2.足 != null)
    				{
    					脚人2.足.開脚(脚人2.腿);
    				}
    			}
    			if (脚人右.Count > 0)
    			{
    				脚人 脚人3 = 脚人右[0];
    				脚人3.腿.Yv = value;
    				if (脚人3.Leg != null)
    				{
    					脚人3.Leg.開脚(脚人3.腿);
    				}
    				if (脚人3.足 != null)
    				{
    					脚人3.足.開脚(脚人3.腿);
    				}
    			}
    			if (捲り判定0)
    			{
    				上着B_クロス.Yv = value;
    			}
    			if (捲り判定1)
    			{
    				上着B_前掛け.Yv = value;
    			}
    			if (EI腿 != null)
    			{
    				EI腿.Updatef = true;
    			}
    		}
    	}

    	public int 腿開きi
    	{
    		get
    		{
    			if (脚人左.Count > 0)
    			{
    				return 脚人左[0].腿.Yi;
    			}
    			if (脚人右.Count > 0)
    			{
    				return 脚人右[0].腿.Yi;
    			}
    			return 0;
    		}
    		set
    		{
    			if (脚人左.Count > 0)
    			{
    				脚人 脚人2 = 脚人左[0];
    				脚人2.腿.Yi = value;
    				if (脚人2.Leg != null)
    				{
    					脚人2.Leg.開脚(脚人2.腿);
    				}
    				if (脚人2.足 != null)
    				{
    					脚人2.足.開脚(脚人2.腿);
    				}
    			}
    			if (脚人右.Count > 0)
    			{
    				脚人 脚人3 = 脚人右[0];
    				脚人3.腿.Yi = value;
    				if (脚人3.Leg != null)
    				{
    					脚人3.Leg.開脚(脚人3.腿);
    				}
    				if (脚人3.足 != null)
    				{
    					脚人3.足.開脚(脚人3.腿);
    				}
    			}
    			if (捲り判定0)
    			{
    				上着B_クロス.Yi = value;
    			}
    			if (捲り判定1)
    			{
    				上着B_前掛け.Yi = value;
    			}
    			if (EI腿 != null)
    			{
    				EI腿.Updatef = true;
    			}
    		}
    	}

    	public double 左腿開きv
    	{
    		get
    		{
    			if (脚人左.Count > 0)
    			{
    				return 脚人左[0].腿.Yv;
    			}
    			return 0.0;
    		}
    		set
    		{
    			if (脚人左.Count > 0)
    			{
    				脚人 脚人2 = 脚人左[0];
    				脚人2.腿.Yv = value;
    				if (脚人2.Leg != null)
    				{
    					脚人2.Leg.開脚(脚人2.腿);
    				}
    				if (脚人2.足 != null)
    				{
    					脚人2.足.開脚(脚人2.腿);
    				}
    			}
    		}
    	}

    	public int 左腿開きi
    	{
    		get
    		{
    			if (脚人左.Count > 0)
    			{
    				return 脚人左[0].腿.Yi;
    			}
    			return 0;
    		}
    		set
    		{
    			if (脚人左.Count > 0)
    			{
    				脚人 脚人2 = 脚人左[0];
    				脚人2.腿.Yi = value;
    				脚人2.Leg.開脚(脚人2.腿);
    				脚人2.足.開脚(脚人2.腿);
    			}
    		}
    	}

    	public double 右腿開きv
    	{
    		get
    		{
    			if (脚人右.Count > 0)
    			{
    				return 脚人右[0].腿.Yv;
    			}
    			return 0.0;
    		}
    		set
    		{
    			if (脚人右.Count > 0)
    			{
    				脚人 脚人2 = 脚人右[0];
    				脚人2.腿.Yv = value;
    				if (脚人2.Leg != null)
    				{
    					脚人2.Leg.開脚(脚人2.腿);
    				}
    				if (脚人2.足 != null)
    				{
    					脚人2.足.開脚(脚人2.腿);
    				}
    			}
    		}
    	}

    	public int 右腿開きi
    	{
    		get
    		{
    			if (脚人右.Count > 0)
    			{
    				return 脚人右[0].腿.Yi;
    			}
    			return 0;
    		}
    		set
    		{
    			if (脚人右.Count > 0)
    			{
    				脚人 脚人2 = 脚人右[0];
    				脚人2.腿.Yi = value;
    				if (脚人2.Leg != null)
    				{
    					脚人2.Leg.開脚(脚人2.腿);
    				}
    				if (脚人2.足 != null)
    				{
    					脚人2.足.開脚(脚人2.腿);
    				}
    			}
    		}
    	}

    	public double 口v
    	{
    		get
    		{
    			if (口 != null)
    			{
    				return 口.Yv;
    			}
    			return 0.0;
    		}
    		set
    		{
    			if (口 != null)
    			{
    				口.Yv = value;
    				頭.開顎(口);
    			}
    		}
    	}

    	public int 口i
    	{
    		get
    		{
    			if (口 != null)
    			{
    				return 口.Yi;
    			}
    			return 0;
    		}
    		set
    		{
    			if (口 != null)
    			{
    				口.Yi = value;
    				頭.開顎(口);
    			}
    		}
    	}

    	public double PregnantBellyv
    	{
    		get
    		{
    			if (!Is獣)
    			{
    				return PregnantBelly_人.Yv;
    			}
    			return PregnantBelly_獣.Yv;
    		}
    		set
    		{
    			if (Is獣)
    			{
    				PregnantBelly_獣.Yv = value;
    			}
    			else
    			{
    				PregnantBelly_人.Yv = value;
    				PregnantBellyPlate_人.Yv = value;
    			}
    			上着B_前掛け.X0Y0_帯.SetSizeXCont(1.0 + 0.1 * PregnantBellyv);
    			上着B_前掛け.X0Y1_帯.SetSizeXCont(上着B_前掛け.X0Y0_帯.GetSizeXCont());
    		}
    	}

    	public int PregnantBellyi
    	{
    		get
    		{
    			if (!Is獣)
    			{
    				return PregnantBelly_人.Yi;
    			}
    			return PregnantBelly_獣.Yi;
    		}
    		set
    		{
    			if (Is獣)
    			{
    				PregnantBelly_獣.Yi = value;
    			}
    			else
    			{
    				PregnantBelly_人.Yi = value;
    				PregnantBellyPlate_人.Yi = value;
    			}
    			上着B_前掛け.X0Y0_帯.SetSizeXCont(1.0 + 0.1 * PregnantBellyv);
    			上着B_前掛け.X0Y1_帯.SetSizeXCont(上着B_前掛け.X0Y0_帯.GetSizeXCont());
    		}
    	}

    	public int 瞼左i
    	{
    		get
    		{
    			if (瞼左 == null)
    			{
    				return 0;
    			}
    			return 瞼左.Yi;
    		}
    		set
    		{
    			if (瞼左 != null)
    			{
    				瞼左.Yi = value;
    				目傷左.Yi = value;
    				目傷左.Yi = 目傷左.Yi.Limit(0, 2);
    			}
    		}
    	}

    	public double 瞼左v
    	{
    		get
    		{
    			if (瞼左 == null)
    			{
    				return 0.0;
    			}
    			return 瞼左.Yv;
    		}
    		set
    		{
    			if (瞼左 != null)
    			{
    				瞼左.Yv = value;
    				目傷左.Yv = value;
    				目傷左.Yi = 目傷左.Yi.Limit(0, 2);
    			}
    		}
    	}

    	public int 瞼右i
    	{
    		get
    		{
    			if (瞼右 == null)
    			{
    				return 0;
    			}
    			return 瞼右.Yi;
    		}
    		set
    		{
    			if (瞼右 != null)
    			{
    				瞼右.Yi = value;
    				目傷右.Yi = value;
    				目傷右.Yi = 目傷右.Yi.Limit(0, 2);
    			}
    		}
    	}

    	public double 瞼右v
    	{
    		get
    		{
    			if (瞼右 == null)
    			{
    				return 0.0;
    			}
    			return 瞼右.Yv;
    		}
    		set
    		{
    			if (瞼右 != null)
    			{
    				瞼右.Yv = value;
    				目傷右.Yv = value;
    				目傷右.Yi = 目傷右.Yi.Limit(0, 2);
    			}
    		}
    	}

    	public 髪留2情報 Set後髪髪留
    	{
    		get
    		{
    			return 後髪髪留i;
    		}
    		set
    		{
    			後髪髪留i = value;
    			if (後髪0 != null)
    			{
    				if (後髪0 is お下げ1)
    				{
    					お下げ1 obj = (お下げ1)後髪0;
    					obj.お下げ_髪縛1_表示 = value.髪留左.髪縛1_表示;
    					obj.お下げ_髪縛2_表示 = value.髪留左.髪縛2_表示;
    					obj.髪留配色(value.髪留左.色);
    				}
    				else if (後髪0 is お下げ2)
    				{
    					お下げ2 obj2 = (お下げ2)後髪0;
    					obj2.お下げ左_髪縛1_表示 = value.髪留左.髪縛1_表示;
    					obj2.お下げ左_髪縛2_表示 = value.髪留左.髪縛2_表示;
    					obj2.お下げ右_髪縛1_表示 = value.髪留右.髪縛1_表示;
    					obj2.お下げ右_髪縛2_表示 = value.髪留右.髪縛2_表示;
    					obj2.髪留配色(value.髪留左.色, value.髪留右.色);
    				}
    			}
    		}
    	}

    	public 髪留2情報 Set横髪髪留
    	{
    		get
    		{
    			return 横髪髪留i;
    		}
    		set
    		{
    			横髪髪留i = value;
    			if (横髪左 != null && 横髪左 is SideHair_編み)
    			{
    				SideHair_編み obj = (SideHair_編み)横髪左;
    				obj.髪縛1_表示 = value.髪留左.髪縛1_表示;
    				obj.髪縛2_表示 = value.髪留左.髪縛2_表示;
    				obj.髪留配色(value.髪留左.色);
    			}
    			if (横髪右 != null && 横髪右 is SideHair_編み)
    			{
    				SideHair_編み obj2 = (SideHair_編み)横髪右;
    				obj2.髪縛1_表示 = value.髪留右.髪縛1_表示;
    				obj2.髪縛2_表示 = value.髪留右.髪縛2_表示;
    				obj2.髪留配色(value.髪留右.色);
    			}
    		}
    	}

    	public 玉口枷情報 Set玉口枷
    	{
    		get
    		{
    			return 玉口枷i;
    		}
    		set
    		{
    			玉口枷i = value;
    			if (玉口枷 != null)
    			{
    				Set表示(玉口枷, 玉口枷i);
    				玉口枷.配色(玉口枷i.色);
    			}
    		}
    	}

    	public 目隠帯情報 Set目隠帯
    	{
    		get
    		{
    			return 目隠帯i;
    		}
    		set
    		{
    			目隠帯i = value;
    			if (目隠帯 != null)
    			{
    				Set表示(目隠帯, 目隠帯i);
    				目隠帯.配色(目隠帯i.色);
    			}
    		}
    	}

    	public 拘束具情報 Set拘束具
    	{
    		get
    		{
    			return 拘束具i;
    		}
    		set
    		{
    			拘束具i = value;
    			object[] array = new object[1];
    			Element[] array2 = Elements;
    			foreach (Element ele in array2)
    			{
    				MethodInfo[] methods = ele.GetType().GetMethods();
    				foreach (MethodInfo methodInfo in methods)
    				{
    					if (methodInfo.Name.Contains("輪") && methodInfo.Name.Contains("配色"))
    					{
    						ele.拘束 = 拘束具i.表示;
    						array[0] = 拘束具i.色;
    						methodInfo.Invoke(ele, array);
    					}
    				}
    			}
    			Elements.SetValues("鎖表示", 拘束具i.表示);
    			if (!拘束具i.表示)
    			{
    				return;
    			}
    			if (Is蛇)
    			{
    				int num = 0;
    				Torso_蛇 ele2 = 蛇.Torso_接続.GetEle<Torso_蛇>();
    				while (ele2 != null)
    				{
    					if (num % 4 != 0)
    					{
    						ele2.拘束 = false;
    						ele2.鎖表示 = false;
    					}
    					ele2 = ele2.Torso_接続.GetEle<Torso_蛇>();
    					num++;
    				}
    			}
    			if (Is蟲)
    			{
    				int num2 = 0;
    				Torso_蟲 ele3 = 蟲.Torso_接続.GetEle<Torso_蟲>();
    				while (ele3 != null)
    				{
    					if (num2 % 2 == 0)
    					{
    						ele3.拘束 = false;
    						ele3.鎖表示 = false;
    					}
    					ele3 = ele3.Torso_接続.GetEle<Torso_蟲>();
    					num2++;
    				}
    			}
    			array2 = Elements;
    			foreach (Element ele4 in array2)
    			{
    				if (ele4 is 触手_蔦)
    				{
    					触手_蔦 obj = (触手_蔦)ele4;
    					obj.X0Y0_先端_上顎_顎.SetAngleBase(0.0);
    					obj.X0Y0_先端_下顎_顎.SetAngleBase(0.0);
    				}
    				else if (ele4 is 触手_犬)
    				{
    					触手_犬 obj2 = (触手_犬)ele4;
    					obj2.X0Y0_頭_上顎_眼下_眼下.SetAngleBase(0.0);
    					obj2.X0Y0_頭_下顎_眼下_眼下.SetAngleBase(0.0);
    				}
    				else if (ele4 is 触肢_肢蠍)
    				{
    					((触肢_肢蠍)ele4).X0Y0_爪2.SetAngleBase(0.0);
    				}
    				else if (ele4 is 虫鎌)
    				{
    					((虫鎌)ele4).SetAngle0();
    				}
    			}
    		}
    	}

    	public ピアス情報 Setピアス
    	{
    		get
    		{
    			return ピアスi;
    		}
    		set
    		{
    			ピアスi = value;
    			if (ピアス != null)
    			{
    				Set表示(ピアス, ピアスi);
    				ピアス.配色(ピアスi.色);
    				ピアス.SetHitFalse();
    				WaistSkin_人.陰毛_ハート_表示 = (WaistSkin_人.陰毛_表示 || WaistSkin_人.獣性_獣毛_表示) && ピアス.表示;
    				WaistSkin_人.陰毛CD.不透明度 = Cha.CharacterData.現陰毛 * Cha.CharacterData.最陰毛濃度;
    				WaistSkin_人.獣性_獣毛CD.不透明度 = Cha.CharacterData.現陰毛;
    				WaistSkin_人.陰毛_ハートCD.不透明度 = Cha.CharacterData.現陰毛.Inverse() * Cha.CharacterData.最陰毛濃度;
    			}
    		}
    	}

    	public ピアス情報 Setピアス左
    	{
    		get
    		{
    			return ピアス左i;
    		}
    		set
    		{
    			ピアス左i = value;
    			if (ピアス左 != null)
    			{
    				Set表示(ピアス左, ピアス左i);
    				ピアス左.配色(ピアス左i.色);
    				ピアス左.SetHitFalse();
    			}
    		}
    	}

    	public ピアス情報 Setピアス右
    	{
    		get
    		{
    			return ピアス右i;
    		}
    		set
    		{
    			ピアス右i = value;
    			if (ピアス右 != null)
    			{
    				Set表示(ピアス右, ピアス右i);
    				ピアス右.配色(ピアス右i.色);
    				ピアス右.SetHitFalse();
    			}
    		}
    	}

    	public キャップ情報 Setキャップ1
    	{
    		get
    		{
    			return キャップ1i;
    		}
    		set
    		{
    			キャップ1i = value;
    			if (キャップ1 != null)
    			{
    				Set表示(キャップ1, キャップ1i);
    				キャップ1.配色(キャップ1i.色);
    			}
    		}
    	}

    	public キャップ情報 Setキャップ2左
    	{
    		get
    		{
    			return キャップ2左i;
    		}
    		set
    		{
    			キャップ2左i = value;
    			if (キャップ2左 != null)
    			{
    				Set表示(キャップ2左, キャップ2左i);
    				キャップ2左.配色(キャップ2左i.色);
    			}
    		}
    	}

    	public キャップ情報 Setキャップ2右
    	{
    		get
    		{
    			return キャップ2右i;
    		}
    		set
    		{
    			キャップ2右i = value;
    			if (キャップ2右 != null)
    			{
    				Set表示(キャップ2右, キャップ2右i);
    				キャップ2右.配色(キャップ2右i.色);
    			}
    		}
    	}

    	public ドレス首情報 Setドレス首
    	{
    		get
    		{
    			return ドレス首i;
    		}
    		set
    		{
    			ドレス首i = value;
    			if (Neck != null)
    			{
    				Set表示(Neck, ドレス首i);
    				Neck.ドレス配色(ドレス首i.色);
    			}
    		}
    	}

    	public 下着T_チューブ情報 Set下着T_チューブ
    	{
    		get
    		{
    			return 下着T_チューブi;
    		}
    		set
    		{
    			下着T_チューブi = value;
    			if (下着T_チューブ != null)
    			{
    				Set表示(下着T_チューブ, 下着T_チューブi);
    				下着T_チューブ.配色(下着T_チューブi.色);
    				bool isShow = 下着T_チューブi.IsShow;
    				乳房左.着衣 = isShow;
    				乳房右.着衣 = isShow;
    				下着T_チューブ.SetHitFalse();
    				下着乳首左.表示 = !乳房左.虫性_甲殻_表示 && isShow;
    				下着乳首右.表示 = !乳房右.虫性_甲殻_表示 && isShow;
    				下着乳首左.配色(下着T_チューブi.色.生地色);
    				下着乳首右.配色(下着T_チューブi.色.生地色);
    				乳首勃起 = 乳首勃起;
    				if (LeftMilkSpray.母乳垂れ1_表示)
    				{
    					下着T染み = Cha.MilkStain;
    				}
    				else
    				{
    					下着T染み = 0.0;
    				}
    			}
    		}
    	}

    	public 下着T_クロス情報 Set下着T_クロス
    	{
    		get
    		{
    			return 下着T_クロスi;
    		}
    		set
    		{
    			下着T_クロスi = value;
    			if (下着T_クロス != null)
    			{
    				Set表示(下着T_クロス, 下着T_クロスi);
    				下着T_クロス.配色(下着T_クロスi.色);
    				bool isShow = 下着T_クロスi.IsShow;
    				乳房左.着衣 = isShow;
    				乳房右.着衣 = isShow;
    				下着T_クロス.SetHitFalse();
    				下着乳首左.表示 = !乳房左.虫性_甲殻_表示 && isShow;
    				下着乳首右.表示 = !乳房右.虫性_甲殻_表示 && isShow;
    				下着乳首左.配色(下着T_クロスi.色.生地色);
    				下着乳首右.配色(下着T_クロスi.色.生地色);
    				乳首勃起 = 乳首勃起;
    				if (LeftMilkSpray.母乳垂れ1_表示)
    				{
    					下着T染み = Cha.MilkStain;
    				}
    				else
    				{
    					下着T染み = 0.0;
    				}
    			}
    		}
    	}

    	public 下着T_ビキニ情報 Set下着T_ビキニ
    	{
    		get
    		{
    			return 下着T_ビキニi;
    		}
    		set
    		{
    			下着T_ビキニi = value;
    			if (下着T_ビキニ != null)
    			{
    				Set表示(下着T_ビキニ, 下着T_ビキニi);
    				下着T_ビキニ.配色(下着T_ビキニi.色);
    				bool isShow = 下着T_ビキニi.IsShow;
    				乳房左.着衣 = isShow;
    				乳房右.着衣 = isShow;
    				下着T_ビキニ.SetHitFalse();
    				下着乳首左.表示 = !乳房左.虫性_甲殻_表示 && isShow;
    				下着乳首右.表示 = !乳房右.虫性_甲殻_表示 && isShow;
    				下着乳首左.配色(下着T_ビキニi.色.生地色);
    				下着乳首右.配色(下着T_ビキニi.色.生地色);
    				乳首勃起 = 乳首勃起;
    				if (LeftMilkSpray.母乳垂れ1_表示)
    				{
    					下着T染み = Cha.MilkStain;
    				}
    				else
    				{
    					下着T染み = 0.0;
    				}
    			}
    		}
    	}

    	public 下着T_マイクロ情報 Set下着T_マイクロ
    	{
    		get
    		{
    			return 下着T_マイクロi;
    		}
    		set
    		{
    			下着T_マイクロi = value;
    			if (下着T_マイクロ != null)
    			{
    				Set表示(下着T_マイクロ, 下着T_マイクロi);
    				下着T_マイクロ.配色(下着T_マイクロi.色);
    				bool isShow = 下着T_マイクロi.IsShow;
    				乳房左.着衣 = isShow;
    				乳房右.着衣 = isShow;
    				下着T_マイクロ.SetHitFalse();
    				下着乳首左.表示 = !乳房左.虫性_甲殻_表示 && isShow;
    				下着乳首右.表示 = !乳房右.虫性_甲殻_表示 && isShow;
    				下着乳首左.配色(下着T_マイクロi.色.生地色);
    				下着乳首右.配色(下着T_マイクロi.色.生地色);
    				乳首勃起 = 乳首勃起;
    				if (LeftMilkSpray.母乳垂れ1_表示)
    				{
    					下着T染み = Cha.MilkStain;
    				}
    				else
    				{
    					下着T染み = 0.0;
    				}
    			}
    		}
    	}

    	public 下着T_ブラ情報 Set下着T_ブラ
    	{
    		get
    		{
    			return 下着T_ブラi;
    		}
    		set
    		{
    			下着T_ブラi = value;
    			if (下着T_ブラ != null)
    			{
    				Set表示(下着T_ブラ, 下着T_ブラi);
    				下着T_ブラ.配色(下着T_ブラi.色);
    				bool isShow = 下着T_ブラi.IsShow;
    				乳房左.着衣 = isShow;
    				乳房右.着衣 = isShow;
    				下着T_ブラ.SetHitFalse();
    				下着乳首左.表示 = false;
    				下着乳首右.表示 = false;
    				if (LeftMilkSpray.母乳垂れ1_表示)
    				{
    					下着T染み = Cha.MilkStain;
    				}
    				else
    				{
    					下着T染み = 0.0;
    				}
    			}
    		}
    	}

    	public 下着B_ノーマル情報 Set下着B_ノーマル
    	{
    		get
    		{
    			return 下着B_ノーマルi;
    		}
    		set
    		{
    			下着B_ノーマルi = value;
    			if (下着B_ノーマル != null)
    			{
    				Set表示(下着B_ノーマル, 下着B_ノーマルi);
    				下着B_ノーマル.配色(下着B_ノーマルi.色);
    				下着B_ノーマル.SetHitFalse();
    				下着陰核.表示 = 下着B_ノーマルi.IsShow || 下着B_マイクロi.IsShow;
    				下着陰核.配色(下着B_ノーマルi.色.生地色);
    				陰核勃起 = 陰核勃起;
    			}
    		}
    	}

    	public 下着B_マイクロ情報 Set下着B_マイクロ
    	{
    		get
    		{
    			return 下着B_マイクロi;
    		}
    		set
    		{
    			下着B_マイクロi = value;
    			if (下着B_マイクロ != null)
    			{
    				Set表示(下着B_マイクロ, 下着B_マイクロi);
    				下着B_マイクロ.配色(下着B_マイクロi.色);
    				下着B_マイクロ.SetHitFalse();
    				下着陰核.表示 = 下着B_マイクロi.IsShow || 下着B_ノーマルi.IsShow;
    				下着陰核.配色(下着B_マイクロi.色.生地色);
    				陰核勃起 = 陰核勃起;
    			}
    		}
    	}

    	public ドレス情報 Setドレス
    	{
    		get
    		{
    			return ドレスi;
    		}
    		set
    		{
    			ドレスi = value;
    			bool isShow = ドレスi.T.IsShow;
    			if (乳房左 != null)
    			{
    				乳房左.着衣 = isShow;
    			}
    			if (乳房右 != null)
    			{
    				乳房右.着衣 = isShow;
    			}
    			if (上着T_ドレス != null)
    			{
    				Set表示(上着T_ドレス, ドレスi.T);
    				上着T_ドレス.配色(ドレスi.色);
    				上着T_ドレス.SetHitFalse();
    			}
    			if (上着M_ドレス != null)
    			{
    				Set表示(上着M_ドレス, ドレスi.M);
    				上着M_ドレス.配色(ドレスi.色);
    				上着M_ドレス.SetHitFalse();
    			}
    		}
    	}

    	public 上着B_クロス情報 Set上着B_クロス
    	{
    		get
    		{
    			return 上着B_クロスi;
    		}
    		set
    		{
    			上着B_クロスi = value;
    			if (上着B_クロス != null)
    			{
    				Set表示(上着B_クロス, 上着B_クロスi);
    				上着B_クロス.配色(上着B_クロスi.色);
    				上着B_クロス後.配色(上着B_クロスi.色);
    				上着B_クロス.JacketBottomRear_接続[0].表示 = 上着B_クロスi.IsShow;
    				上着B_クロス.SetHitFalse();
    				上着B_クロス.Yi = (捲り判定0 ? 1 : 0);
    				if (捲り判定0)
    				{
    					if (上着B_クロスi.IsShow)
    					{
    						上着B_クロス.左_皺1_表示 = false;
    						上着B_クロス.右_皺1_表示 = false;
    					}
    				}
    				else if (上着B_クロスi.IsShow)
    				{
    					上着B_クロス.左_皺1_表示 = true;
    					上着B_クロス.右_皺1_表示 = true;
    				}
    			}
    			下着B_ノーマルi.紐 = false;
    			下着B_マイクロi.紐 = false;
    			Set下着B_ノーマル = 下着B_ノーマルi;
    			Set下着B_マイクロ = 下着B_マイクロi;
    		}
    	}

    	public 上着B_前掛け情報 Set上着B_前掛け
    	{
    		get
    		{
    			return 上着B_前掛けi;
    		}
    		set
    		{
    			上着B_前掛けi = value;
    			if (上着B_前掛け != null)
    			{
    				Set表示(上着B_前掛け, 上着B_前掛けi);
    				上着B_前掛け.配色(上着B_前掛けi.色);
    				上着B_前掛け.SetHitFalse();
    				上着B_前掛け.Yi = (捲り判定1 ? 1 : 0);
    			}
    		}
    	}

    	public ブーツ情報 Setブーツ
    	{
    		get
    		{
    			return ブーツi;
    		}
    		set
    		{
    			ブーツi = value;
    			foreach (脚人 item in 脚人左)
    			{
    				if (item.Leg != null)
    				{
    					Set表示(item.Leg, ブーツi.Leg);
    					item.Leg.ブーツ配色(ブーツi.色);
    				}
    				if (item.足 != null)
    				{
    					Set表示(item.足, ブーツi.足);
    					item.足.ブーツ配色(ブーツi.色);
    				}
    			}
    			foreach (脚人 item2 in 脚人右)
    			{
    				if (item2.Leg != null)
    				{
    					Set表示(item2.Leg, ブーツi.Leg);
    					item2.Leg.ブーツ配色(ブーツi.色);
    				}
    				if (item2.足 != null)
    				{
    					Set表示(item2.足, ブーツi.足);
    					item2.足.ブーツ配色(ブーツi.色);
    				}
    			}
    		}
    	}

    	public bool Is下着T
    	{
    		get
    		{
    			if (!下着T_チューブi.IsShow && !下着T_クロスi.IsShow && !下着T_ビキニi.IsShow && !下着T_マイクロi.IsShow)
    			{
    				return 下着T_ブラi.IsShow;
    			}
    			return true;
    		}
    	}

    	public bool Is下着B
    	{
    		get
    		{
    			if (!下着B_ノーマルi.IsShow)
    			{
    				return 下着B_マイクロi.IsShow;
    			}
    			return true;
    		}
    	}

    	public bool Is上着T => ドレスi.IsShow;

    	public bool Is上着B
    	{
    		get
    		{
    			if (!上着B_クロスi.IsShow)
    			{
    				return 上着B_前掛けi.IsShow;
    			}
    			return true;
    		}
    	}

    	public bool Is拘束 => 拘束具i.表示;

    	public bool 拘束具_表示
    	{
    		get
    		{
    			return 拘束具i.表示;
    		}
    		set
    		{
    			if (value)
    			{
    				Set拘束具 = 拘束具情報.GetDefault();
    			}
    			else
    			{
    				Set拘束具 = GlobalState.拘束具初期化;
    			}
    		}
    	}

    	public bool 目隠帯_表示
    	{
    		get
    		{
    			return Set目隠帯.革_表示;
    		}
    		set
    		{
    			if (value)
    			{
    				Set目隠帯 = 目隠帯情報.GetDefault();
    				Cha.瞼();
    			}
    			else
    			{
    				Set目隠帯 = GlobalState.目隠帯初期化;
    			}
    		}
    	}

    	public bool 玉口枷_表示
    	{
    		get
    		{
    			return Set玉口枷.革_表示;
    		}
    		set
    		{
    			if (value)
    			{
    				口i = 9;
    				Cha.Tounge_無し();
    				Set玉口枷 = 玉口枷情報.GetDefault();
    			}
    			else
    			{
    				Set玉口枷 = GlobalState.玉口枷初期化;
    			}
    		}
    	}

    	public bool 首輪_表示
    	{
    		get
    		{
    			return Neck.拘束;
    		}
    		set
    		{
    			if (value)
    			{
    				拘束具情報 @default = 拘束具情報.GetDefault();
    				Neck.拘束 = @default.表示;
    				Neck.首輪配色(@default.色);
    			}
    			else
    			{
    				拘束具情報 拘束具初期化 = GlobalState.拘束具初期化;
    				Neck.拘束 = 拘束具初期化.表示;
    				Neck.首輪配色(拘束具初期化.色);
    			}
    		}
    	}

    	public void スタンプClear()
    	{
    		スタンプK[] array = キスマーク;
    		for (int i = 0; i < array.Length; i++)
    		{
    			array[i].Clear();
    		}
    		スタンプW[] array2 = 鞭痕;
    		for (int i = 0; i < array2.Length; i++)
    		{
    			array2[i].Clear();
    		}
    		ぶっかけ小.Clear();
    		ぶっかけ大.Clear();
    	}

    	public void Sort(IEnumerable<Element> ar, List<Element> li)
    	{
    		foreach (Element item in ar)
    		{
    			int num;
    			if ((num = li.IndexOf(item.Par)) > -1)
    			{
    				li.Insert(num + item.描画前後, item);
    			}
    			else
    			{
    				li.Add(item);
    			}
    		}
    	}

    	public Body(ModeEventDispatcher Med, RenderArea Are, Character Cha)
    	{
    		Body bod = this;
    		this.Med = Med;
    		this.Cha = Cha;
    		double disUnit = Are.DisplayUnitScale;
    		Waist = (Waist)Cha.CharacterData.body_tree.GetEle(disUnit, Med, Cha.ColorSet);
    		Elements = Waist.EnumEle().ToArray();
    		List<スタンプK> sk = new List<スタンプK>();
    		List<スタンプW> sw = new List<スタンプW>();
    		キスマークD kd = new キスマークD
    		{
    			濃度 = 0.0
    		};
    		鞭痕D wd = new 鞭痕D();
    		蝙通常 = new List<蝙通常>();
    		Shoulder 人肩;
    		Arm獣 腕獣;
    		腿_人 人腿;
    		脚人 脚人;
    		脚獣 脚獣;
    		Arm翼鳥 腕翼鳥;
    		Arm翼獣 腕翼獣;
    		Arm人 腕人;
    		翼鳥 翼鳥;
    		翼獣 翼獣;
    		Element p;
    		Element pp;
    		foreach (Element current_element in Elements.Reverse())
    		{
    			FieldInfo[] fields = current_element.ThisType.GetFields();
    			foreach (FieldInfo fieldInfo in fields)
    			{
    				if (fieldInfo.FieldType.ToString() == GlobalState.拘束鎖t)
    				{
    					((拘束鎖)fieldInfo.GetValue(current_element)).SetSize();
    				}
    			}
    			if (current_element is 角2_鬼 && current_element.ConnectionType != ConnectionInfo.BaseHair_頭頂左_接続 && current_element.ConnectionType != ConnectionInfo.BaseHair_頭頂右_接続)
    			{
    				((角2_鬼)current_element).SetBasePoint();
    			}
    			foreach (ShapePart item19 in current_element.Body.EnumAllPar())
    			{
    				if (item19.Tag.Contains("ハイライト"))
    				{
    					item19.Hit = false;
    				}
    			}
    			if (current_element.右)
    			{
    				if (current_element is Shoulder)
    				{
    					人肩 = (Shoulder)current_element;
    					人肩.キスマーク = new スタンプK(Med, Are, Cha, this, kd, 人肩);
    					sk.Add(人肩.キスマーク);
    					人肩.鞭痕 = new スタンプW(Med, Are, Cha, this, wd, 人肩);
    					sw.Add(人肩.鞭痕);
    				}
    				else if (current_element is 四足脇)
    				{
    					四足脇 四足脇2 = (四足脇)current_element;
    					if (腕獣右.Count > 0)
    					{
    						current_element.表示 = false;
    					}
    					腕獣 = default(Arm獣);
    					腕獣.Shoulder = 四足脇2;
    					四足脇2.UpperArm_接続.SetEle(delegate(獣UpperArm UpperArm)
    					{
    						腕獣.UpperArm = UpperArm;
    						UpperArm.LowerArm_接続.SetEle(delegate(獣LowerArm LowerArm)
    						{
    							腕獣.LowerArm = LowerArm;
    							LowerArm.手_接続.SetEle(delegate(獣手 手)
    							{
    								腕獣.手 = 手;
    							});
    						});
    					});
    					腕獣右.Add(腕獣);
    				}
    				else if (current_element is 腿_人)
    				{
    					人腿 = (腿_人)current_element;
    					人腿.キスマーク = new スタンプK(Med, Are, Cha, this, kd, 人腿);
    					sk.Add(人腿.キスマーク);
    					人腿.鞭痕 = new スタンプW(Med, Are, Cha, this, wd, 人腿);
    					sw.Add(人腿.鞭痕);
    					脚人 = default(脚人);
    					脚人.腿 = 人腿;
    					人腿.Leg_接続.SetEle(delegate(Leg_人 脚)
    					{
    						脚.キスマーク = new スタンプK(Med, Are, Cha, bod, kd, 脚);
    						sk.Add(脚.キスマーク);
    						脚.鞭痕 = new スタンプW(Med, Are, Cha, bod, wd, 脚);
    						sw.Add(脚.鞭痕);
    						if (!人腿.X0Y0_腿.GetOP()[0].Outline)
    						{
    							人腿.腿0CD.c2.Col2 = 脚.LegCD.c2.Col1;
    							人腿.腿1CD.c2.Col2 = 脚.LegCD.c2.Col1;
    							人腿.腿2CD.c2.Col1 = 脚.LegCD.c2.Col1;
    							人腿.腿3CD.c2.Col1 = 脚.LegCD.c2.Col1;
    							人腿.腿4CD.c2.Col1 = 脚.LegCD.c2.Col1;
    						}
    						脚人.Leg = 脚;
    						脚.足_接続.SetEle(delegate(足_人 足)
    						{
    							足.キスマーク = new スタンプK(Med, Are, Cha, bod, kd, 足);
    							sk.Add(足.キスマーク);
    							足.鞭痕 = new スタンプW(Med, Are, Cha, bod, wd, 足);
    							sw.Add(足.鞭痕);
    							脚人.足 = 足;
    						});
    					});
    					脚人右.Add(脚人);
    				}
    				else if (current_element is 獣腿)
    				{
    					獣腿 獣腿2 = (獣腿)current_element;
    					脚獣 = default(脚獣);
    					脚獣.腿 = 獣腿2;
    					獣腿2.Leg_接続.SetEle(delegate(獣脚 脚)
    					{
    						脚獣.Leg = 脚;
    						脚.足_接続.SetEle(delegate(獣足 足)
    						{
    							脚獣.足 = 足;
    						});
    					});
    					脚獣右.Add(脚獣);
    					if (獣腿2.ConnectionType == ConnectionInfo.Waist_腿右_接続)
    					{
    						if (current_element is 腿_獣)
    						{
    							腿_獣 obj = (腿_獣)獣腿2;
    							obj.腿CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    							obj.腿CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    							obj.筋CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    							obj.筋CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    						}
    						if (current_element is 腿_蹄)
    						{
    							腿_蹄 obj2 = (腿_蹄)獣腿2;
    							obj2.腿CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    							obj2.腿CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    							obj2.筋CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    							obj2.筋CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    						}
    						if (current_element is 腿_竜)
    						{
    							腿_竜 obj3 = (腿_竜)獣腿2;
    							obj3.腿CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    							obj3.腿CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    							obj3.筋CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    							obj3.筋CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    						}
    						if (current_element is 腿_鳥)
    						{
    							腿_鳥 obj4 = (腿_鳥)獣腿2;
    							obj4.腿CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    							obj4.腿CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    							obj4.筋CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    							obj4.筋CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    						}
    					}
    				}
    				else if (current_element is 獣脚 && current_element.Par is 四足脇)
    				{
    					脚獣 = default(脚獣);
    					脚獣.腿 = null;
    					脚獣.Leg = (獣脚)current_element;
    					脚獣.Leg.足_接続.SetEle(delegate(獣足 足)
    					{
    						脚獣.足 = 足;
    					});
    					脚獣右.Add(脚獣);
    				}
    				else if (current_element is UpperArm)
    				{
    					if (current_element.ConnectionType == ConnectionInfo.Shoulder_UpperArm_接続)
    					{
    						人肩 = (Shoulder)current_element.Par;
    						if (current_element is UpperArm_鳥)
    						{
    							腕翼鳥 = default(Arm翼鳥);
    							腕翼鳥.Shoulder = 人肩;
    							人肩.UpperArm_接続.SetEle(delegate(UpperArm_鳥 UpperArm)
    							{
    								UpperArm.キスマーク = new スタンプK(Med, Are, Cha, bod, kd, UpperArm);
    								sk.Add(UpperArm.キスマーク);
    								UpperArm.鞭痕 = new スタンプW(Med, Are, Cha, bod, wd, UpperArm);
    								sw.Add(UpperArm.鞭痕);
    								UpperArm.鳥翼UpperArmCD.c2.Col2 = UpperArm.小雨覆CD.c2.Col1;
    								腕翼鳥.UpperArm = UpperArm;
    								UpperArm.LowerArm_接続.SetEle(delegate(LowerArm_鳥 LowerArm)
    								{
    									腕翼鳥.LowerArm = LowerArm;
    									LowerArm.手_接続.SetEle(delegate(手_鳥 手)
    									{
    										腕翼鳥.手 = 手;
    									});
    								});
    							});
    							腕翼鳥右.Add(腕翼鳥);
    						}
    						else if (current_element is UpperArm_蝙)
    						{
    							腕翼獣 = default(Arm翼獣);
    							腕翼獣.Shoulder = 人肩;
    							人肩.UpperArm_接続.SetEle(delegate(UpperArm_蝙 UpperArm)
    							{
    								UpperArm.獣翼UpperArmCD.c2.Col1 = 人肩.Shoulder_ShoulderCD.c2.Col1;
    								腕翼獣.UpperArm = UpperArm;
    								UpperArm.LowerArm_接続.SetEle(delegate(LowerArm_蝙 LowerArm)
    								{
    									腕翼獣.LowerArm = LowerArm;
    									LowerArm.手_接続.SetEle(delegate(手_蝙 手)
    									{
    										腕翼獣.手 = 手;
    										UpperArm.接着 = () => bod.Waist.X0Y0_Waist.ToGlobal(bod.Waist.X0Y0_Waist.GetBasePointBase());
    										bod.蝙通常.Add(new 蝙通常(UpperArm, LowerArm, 手));
    									});
    								});
    							});
    							腕翼獣右.Add(腕翼獣);
    						}
    						else
    						{
    							腕人 = default(Arm人);
    							腕人.Shoulder = 人肩;
    							人肩.UpperArm_接続.SetEle(delegate(UpperArm_人 UpperArm)
    							{
    								UpperArm.キスマーク = new スタンプK(Med, Are, Cha, bod, kd, UpperArm);
    								sk.Add(UpperArm.キスマーク);
    								UpperArm.鞭痕 = new スタンプW(Med, Are, Cha, bod, wd, UpperArm);
    								sw.Add(UpperArm.鞭痕);
    								腕人.UpperArm = UpperArm;
    								UpperArm.LowerArm_接続.SetEle(delegate(LowerArm_人 LowerArm)
    								{
    									LowerArm.腕輪尺度修正();
    									LowerArm.キスマーク = new スタンプK(Med, Are, Cha, bod, kd, LowerArm);
    									sk.Add(LowerArm.キスマーク);
    									LowerArm.鞭痕 = new スタンプW(Med, Are, Cha, bod, wd, LowerArm);
    									sw.Add(LowerArm.鞭痕);
    									if (UpperArm.獣性_獣毛1_表示)
    									{
    										LowerArm.LowerArmCD.c2 = UpperArm.獣性_獣毛1CD.c2;
    										LowerArm.筋肉_筋肉上CD.c2 = UpperArm.獣性_獣毛1CD.c2;
    										LowerArm.筋肉_筋肉下CD.c2 = UpperArm.獣性_獣毛1CD.c2;
    									}
    									if (UpperArm.虫性_虫腕_表示 && (!LowerArm.虫性1_虫腕上_表示 || !LowerArm.虫性2_虫腕下_表示))
    									{
    										LowerArm.LowerArmCD.c2 = UpperArm.虫性_虫腕CD.c2;
    										LowerArm.筋肉_筋肉上CD.c2 = UpperArm.虫性_虫腕CD.c2;
    										LowerArm.筋肉_筋肉下CD.c2 = UpperArm.虫性_虫腕CD.c2;
    									}
    									if (LowerArm.植性2_萼_萼中_表示)
    									{
    										UpperArm.UpperArmCD.c2.Col2 = LowerArm.植性2_萼_萼中CD.c2.Col2;
    										UpperArm.筋肉上CD.c2.Col2 = LowerArm.植性2_萼_萼中CD.c2.Col2;
    										UpperArm.筋肉下CD.c2.Col2 = LowerArm.植性2_萼_萼中CD.c2.Col2;
    									}
    									else if (LowerArm.獣性1_獣腕_表示)
    									{
    										UpperArm.UpperArmCD.c2.Col2 = LowerArm.獣性1_獣腕CD.c2.Col1;
    										UpperArm.筋肉上CD.c2.Col2 = LowerArm.獣性1_獣腕CD.c2.Col1;
    										UpperArm.筋肉下CD.c2.Col2 = LowerArm.獣性1_獣腕CD.c2.Col1;
    									}
    									else
    									{
    										UpperArm.UpperArmCD.c2.Col2 = LowerArm.LowerArmCD.c2.Col1;
    										UpperArm.筋肉上CD.c2.Col2 = LowerArm.LowerArmCD.c2.Col1;
    										UpperArm.筋肉下CD.c2.Col2 = LowerArm.LowerArmCD.c2.Col1;
    									}
    									腕人.LowerArm = LowerArm;
    									LowerArm.手_接続.SetEle(delegate(手_人 手)
    									{
    										if (LowerArm.獣性1_獣腕_表示 || LowerArm.LowerArmCD.c2.Col1 == LowerArm.獣性1_獣腕CD.c2.Col1)
    										{
    											手.手CD.c2 = LowerArm.獣性1_獣腕CD.c2;
    											手.親指_親指1CD.c2 = 手.手CD.c2;
    										}
    										else if (手.X0Y0_手.GetOP()[6].Outline)
    										{
    											手.手CD.c2 = LowerArm.虫性1_虫腕上CD.c2;
    											手.親指_親指1CD.c2 = 手.手CD.c2;
    										}
    										腕人.手 = 手;
    									});
    								});
    								UpperArm.LowerArm_接続.SetEle(delegate(LowerArm_獣 LowerArm)
    								{
    									UpperArm.UpperArmCD.c2.Col2 = LowerArm.LowerArmCD.c2.Col1;
    									UpperArm.筋肉上CD.c2.Col2 = LowerArm.LowerArmCD.c2.Col1;
    									UpperArm.筋肉下CD.c2.Col2 = LowerArm.LowerArmCD.c2.Col1;
    									LowerArm.X0Y0_LowerArm.GetOP()[6].Outline = true;
    								});
    							});
    							Arm人右.Add(腕人);
    						}
    					}
    					else if (current_element is UpperArm_鳥)
    					{
    						翼鳥 = default(翼鳥);
    						翼鳥.UpperArm = (UpperArm_鳥)current_element;
    						翼鳥.UpperArm.鳥翼UpperArmCD.c2 = 翼鳥.UpperArm.小雨覆CD.c2;
    						翼鳥.UpperArm.キスマーク = new スタンプK(Med, Are, Cha, this, kd, 翼鳥.UpperArm);
    						sk.Add(翼鳥.UpperArm.キスマーク);
    						翼鳥.UpperArm.鞭痕 = new スタンプW(Med, Are, Cha, this, wd, 翼鳥.UpperArm);
    						sw.Add(翼鳥.UpperArm.鞭痕);
    						翼鳥.UpperArm.LowerArm_接続.SetEle(delegate(LowerArm_鳥 LowerArm)
    						{
    							翼鳥.LowerArm = LowerArm;
    							LowerArm.手_接続.SetEle(delegate(手_鳥 手)
    							{
    								翼鳥.手 = 手;
    							});
    						});
    						翼鳥右.Add(翼鳥);
    					}
    					else if (current_element is UpperArm_蝙)
    					{
    						翼獣 = default(翼獣);
    						翼獣.UpperArm = (UpperArm_蝙)current_element;
    						翼獣.UpperArm.LowerArm_接続.SetEle(delegate(LowerArm_蝙 LowerArm)
    						{
    							翼獣.LowerArm = LowerArm;
    							LowerArm.手_接続.SetEle(delegate(手_蝙 手)
    							{
    								翼獣.手 = 手;
    								p = 翼獣.UpperArm.Par;
    								pp = 翼獣.UpperArm.Par.Par;
    								if (p is BaseHair)
    								{
    									翼獣.UpperArm.接着 = () => bod.頭.X0Y0_Head.ToGlobal(bod.頭.X0Y0_Head.GetBasePointBase());
    								}
    								else if (p is Chest)
    								{
    									翼獣.UpperArm.接着 = () => bod.Torso.X0Y0_Torso.ToGlobal(bod.Torso.X0Y0_Torso.GetBasePointBase());
    								}
    								else if (p is Torso || p is Waist)
    								{
    									翼獣.UpperArm.接着 = () => bod.Waist.X0Y0_Waist.ToGlobal(bod.Waist.X0Y0_Waist.GetJP()[4].Joint);
    								}
    								else if (p is 四足胸)
    								{
    									翼獣.UpperArm.接着 = () => bod.Torso_獣.X0Y0_Torso.ToGlobal(bod.Torso_獣.X0Y0_Torso.GetBasePointBase());
    								}
    								else if ((p is 四足胴 || p is 四足腰) && (翼獣.UpperArm.ConnectionType == ConnectionInfo.四足腰_翼左_接続 || 翼獣.UpperArm.ConnectionType == ConnectionInfo.四足腰_翼右_接続))
    								{
    									翼獣.UpperArm.接着 = () => bod.Waist_獣.X0Y0_Waist.ToGlobal(bod.Waist.X0Y0_Waist.GetJP()[4].Joint);
    								}
    								else if (pp != null && pp is Chest)
    								{
    									翼獣.UpperArm.接着 = () => bod.Waist.X0Y0_Waist.ToGlobal(bod.Waist.X0Y0_Waist.GetBasePointBase());
    								}
    								else if (pp != null && pp is 四足胸)
    								{
    									翼獣.UpperArm.接着 = () => bod.Waist_獣.X0Y0_Waist.ToGlobal(bod.Waist_獣.X0Y0_Waist.GetBasePointBase());
    								}
    								else
    								{
    									翼獣.UpperArm.接着 = () => 翼獣.UpperArm.Get飛膜接続点();
    								}
    								bod.蝙通常.Add(new 蝙通常(翼獣.UpperArm, LowerArm, 手));
    							});
    						});
    						翼獣右.Add(翼獣);
    					}
    				}
    				else if (current_element is 鰭)
    				{
    					鰭右.Add((鰭)current_element);
    				}
    				else if (current_element is 葉)
    				{
    					葉右.Add((葉)current_element);
    				}
    				else if (current_element is 前翅_羽 || current_element is 前翅_蝶)
    				{
    					前翅1右.Add((前翅)current_element);
    				}
    				else if (current_element is 後翅_羽 || current_element is 後翅_蝶)
    				{
    					後翅1右.Add((後翅)current_element);
    				}
    				else if (current_element is 前翅_甲 || current_element is 前翅_草)
    				{
    					前翅2右.Add((前翅)current_element);
    				}
    				else if (current_element is 後翅_甲 || current_element is 後翅_草)
    				{
    					後翅2右.Add((後翅)current_element);
    				}
    				else if (current_element is 触肢_肢蜘)
    				{
    					触肢蜘右.Add((触肢_肢蜘)current_element);
    				}
    				else if (current_element is 触肢_肢蠍)
    				{
    					触肢蠍右.Add((触肢_肢蠍)current_element);
    				}
    				else if (current_element is 節足_足蜘)
    				{
    					節足蜘右.Add((節足_足蜘)current_element);
    				}
    				else if (current_element is 節足_足蠍)
    				{
    					節足蠍右.Add((節足_足蠍)current_element);
    				}
    				else if (current_element is 節足_足百)
    				{
    					節足百右.Add((節足_足百)current_element);
    				}
    				else if (current_element is 節尾_曳航)
    				{
    					節尾曳右.Add((節尾_曳航)current_element);
    				}
    				else if (current_element is 節尾_鋏)
    				{
    					節尾鋏右.Add((節尾_鋏)current_element);
    				}
    				else if (current_element is 大顎)
    				{
    					大顎右.Add((大顎)current_element);
    				}
    				else if (current_element is 虫顎)
    				{
    					虫顎右.Add((虫顎)current_element);
    				}
    				else if (current_element is 虫鎌)
    				{
    					虫鎌右.Add((虫鎌)current_element);
    				}
    				else if (current_element is 触手_犬)
    				{
    					触手犬右.Add((触手_犬)current_element);
    				}
    				else if (current_element is 触手)
    				{
    					触手右.Add((触手)current_element);
    				}
    			}
    			else if (current_element is Shoulder)
    			{
    				人肩 = (Shoulder)current_element;
    				人肩.キスマーク = new スタンプK(Med, Are, Cha, this, kd, 人肩);
    				sk.Add(人肩.キスマーク);
    				人肩.鞭痕 = new スタンプW(Med, Are, Cha, this, wd, 人肩);
    				sw.Add(人肩.鞭痕);
    			}
    			else if (current_element is 四足脇)
    			{
    				四足脇 四足脇2 = (四足脇)current_element;
    				if (腕獣左.Count > 0)
    				{
    					current_element.表示 = false;
    				}
    				腕獣 = default(Arm獣);
    				腕獣.Shoulder = 四足脇2;
    				四足脇2.UpperArm_接続.SetEle(delegate(獣UpperArm UpperArm)
    				{
    					腕獣.UpperArm = UpperArm;
    					UpperArm.LowerArm_接続.SetEle(delegate(獣LowerArm LowerArm)
    					{
    						腕獣.LowerArm = LowerArm;
    						LowerArm.手_接続.SetEle(delegate(獣手 手)
    						{
    							腕獣.手 = 手;
    						});
    					});
    				});
    				腕獣左.Add(腕獣);
    			}
    			else if (current_element is 腿_人)
    			{
    				人腿 = (腿_人)current_element;
    				人腿.キスマーク = new スタンプK(Med, Are, Cha, this, kd, 人腿);
    				sk.Add(人腿.キスマーク);
    				人腿.鞭痕 = new スタンプW(Med, Are, Cha, this, wd, 人腿);
    				sw.Add(人腿.鞭痕);
    				脚人 = default(脚人);
    				脚人.腿 = 人腿;
    				人腿.Leg_接続.SetEle(delegate(Leg_人 脚)
    				{
    					脚.キスマーク = new スタンプK(Med, Are, Cha, bod, kd, 脚);
    					sk.Add(脚.キスマーク);
    					脚.鞭痕 = new スタンプW(Med, Are, Cha, bod, wd, 脚);
    					sw.Add(脚.鞭痕);
    					if (!人腿.X0Y0_腿.GetOP()[4].Outline)
    					{
    						人腿.腿0CD.c2.Col2 = 脚.LegCD.c2.Col1;
    						人腿.腿1CD.c2.Col2 = 脚.LegCD.c2.Col1;
    						人腿.腿2CD.c2.Col1 = 脚.LegCD.c2.Col1;
    						人腿.腿3CD.c2.Col1 = 脚.LegCD.c2.Col1;
    						人腿.腿4CD.c2.Col1 = 脚.LegCD.c2.Col1;
    					}
    					脚人.Leg = 脚;
    					脚.足_接続.SetEle(delegate(足_人 足)
    					{
    						足.キスマーク = new スタンプK(Med, Are, Cha, bod, kd, 足);
    						sk.Add(足.キスマーク);
    						足.鞭痕 = new スタンプW(Med, Are, Cha, bod, wd, 足);
    						sw.Add(足.鞭痕);
    						脚人.足 = 足;
    					});
    				});
    				脚人左.Add(脚人);
    			}
    			else if (current_element is 獣腿)
    			{
    				獣腿 獣腿2 = (獣腿)current_element;
    				脚獣 = default(脚獣);
    				脚獣.腿 = 獣腿2;
    				獣腿2.Leg_接続.SetEle(delegate(獣脚 脚)
    				{
    					脚獣.Leg = 脚;
    					脚.足_接続.SetEle(delegate(獣足 足)
    					{
    						脚獣.足 = 足;
    					});
    				});
    				脚獣左.Add(脚獣);
    				if (獣腿2.ConnectionType == ConnectionInfo.Waist_腿左_接続)
    				{
    					if (current_element is 腿_獣)
    					{
    						腿_獣 obj5 = (腿_獣)獣腿2;
    						obj5.腿CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    						obj5.腿CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    						obj5.筋CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    						obj5.筋CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    					}
    					if (current_element is 腿_蹄)
    					{
    						腿_蹄 obj6 = (腿_蹄)獣腿2;
    						obj6.腿CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    						obj6.腿CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    						obj6.筋CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    						obj6.筋CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    					}
    					if (current_element is 腿_竜)
    					{
    						腿_竜 obj7 = (腿_竜)獣腿2;
    						obj7.腿CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    						obj7.腿CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    						obj7.筋CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    						obj7.筋CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    					}
    					if (current_element is 腿_鳥)
    					{
    						腿_鳥 obj8 = (腿_鳥)獣腿2;
    						obj8.腿CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    						obj8.腿CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    						obj8.筋CD.c2.Col1 = Cha.ColorSet.毛0O.Col1;
    						obj8.筋CD.c2.Col2 = Cha.ColorSet.人肌O.Col2;
    					}
    				}
    			}
    			else if (current_element is 獣脚 && current_element.Par is 四足脇)
    			{
    				脚獣 = default(脚獣);
    				脚獣.腿 = null;
    				脚獣.Leg = (獣脚)current_element;
    				脚獣.Leg.足_接続.SetEle(delegate(獣足 足)
    				{
    					脚獣.足 = 足;
    				});
    				脚獣左.Add(脚獣);
    			}
    			else if (current_element is UpperArm)
    			{
    				if (current_element.ConnectionType == ConnectionInfo.Shoulder_UpperArm_接続)
    				{
    					人肩 = (Shoulder)current_element.Par;
    					if (current_element is UpperArm_鳥)
    					{
    						腕翼鳥 = default(Arm翼鳥);
    						腕翼鳥.Shoulder = 人肩;
    						人肩.UpperArm_接続.SetEle(delegate(UpperArm_鳥 UpperArm)
    						{
    							UpperArm.キスマーク = new スタンプK(Med, Are, Cha, bod, kd, UpperArm);
    							sk.Add(UpperArm.キスマーク);
    							UpperArm.鞭痕 = new スタンプW(Med, Are, Cha, bod, wd, UpperArm);
    							sw.Add(UpperArm.鞭痕);
    							UpperArm.鳥翼UpperArmCD.c2.Col2 = UpperArm.小雨覆CD.c2.Col1;
    							腕翼鳥.UpperArm = UpperArm;
    							UpperArm.LowerArm_接続.SetEle(delegate(LowerArm_鳥 LowerArm)
    							{
    								腕翼鳥.LowerArm = LowerArm;
    								LowerArm.手_接続.SetEle(delegate(手_鳥 手)
    								{
    									腕翼鳥.手 = 手;
    								});
    							});
    						});
    						腕翼鳥左.Add(腕翼鳥);
    					}
    					else if (current_element is UpperArm_蝙)
    					{
    						腕翼獣 = default(Arm翼獣);
    						腕翼獣.Shoulder = 人肩;
    						人肩.UpperArm_接続.SetEle(delegate(UpperArm_蝙 UpperArm)
    						{
    							UpperArm.獣翼UpperArmCD.c2.Col1 = 人肩.Shoulder_ShoulderCD.c2.Col1;
    							腕翼獣.UpperArm = UpperArm;
    							UpperArm.LowerArm_接続.SetEle(delegate(LowerArm_蝙 LowerArm)
    							{
    								腕翼獣.LowerArm = LowerArm;
    								LowerArm.手_接続.SetEle(delegate(手_蝙 手)
    								{
    									腕翼獣.手 = 手;
    									UpperArm.接着 = () => bod.Waist.X0Y0_Waist.ToGlobal(bod.Waist.X0Y0_Waist.GetBasePointBase());
    									bod.蝙通常.Add(new 蝙通常(UpperArm, LowerArm, 手));
    								});
    							});
    						});
    						腕翼獣左.Add(腕翼獣);
    					}
    					else
    					{
    						腕人 = default(Arm人);
    						腕人.Shoulder = 人肩;
    						人肩.UpperArm_接続.SetEle(delegate(UpperArm_人 UpperArm)
    						{
    							UpperArm.キスマーク = new スタンプK(Med, Are, Cha, bod, kd, UpperArm);
    							sk.Add(UpperArm.キスマーク);
    							UpperArm.鞭痕 = new スタンプW(Med, Are, Cha, bod, wd, UpperArm);
    							sw.Add(UpperArm.鞭痕);
    							腕人.UpperArm = UpperArm;
    							UpperArm.LowerArm_接続.SetEle(delegate(LowerArm_人 LowerArm)
    							{
    								LowerArm.腕輪尺度修正();
    								LowerArm.キスマーク = new スタンプK(Med, Are, Cha, bod, kd, LowerArm);
    								sk.Add(LowerArm.キスマーク);
    								LowerArm.鞭痕 = new スタンプW(Med, Are, Cha, bod, wd, LowerArm);
    								sw.Add(LowerArm.鞭痕);
    								if (UpperArm.獣性_獣毛1_表示)
    								{
    									LowerArm.LowerArmCD.c2 = UpperArm.獣性_獣毛1CD.c2;
    									LowerArm.筋肉_筋肉上CD.c2 = UpperArm.獣性_獣毛1CD.c2;
    									LowerArm.筋肉_筋肉下CD.c2 = UpperArm.獣性_獣毛1CD.c2;
    								}
    								if (UpperArm.虫性_虫腕_表示 && (!LowerArm.虫性1_虫腕上_表示 || !LowerArm.虫性2_虫腕下_表示))
    								{
    									LowerArm.LowerArmCD.c2 = UpperArm.虫性_虫腕CD.c2;
    									LowerArm.筋肉_筋肉上CD.c2 = UpperArm.虫性_虫腕CD.c2;
    									LowerArm.筋肉_筋肉下CD.c2 = UpperArm.虫性_虫腕CD.c2;
    								}
    								if (LowerArm.植性2_萼_萼中_表示)
    								{
    									UpperArm.UpperArmCD.c2.Col2 = LowerArm.植性2_萼_萼中CD.c2.Col2;
    									UpperArm.筋肉上CD.c2.Col2 = LowerArm.植性2_萼_萼中CD.c2.Col2;
    									UpperArm.筋肉下CD.c2.Col2 = LowerArm.植性2_萼_萼中CD.c2.Col2;
    								}
    								else if (LowerArm.獣性1_獣腕_表示)
    								{
    									UpperArm.UpperArmCD.c2.Col2 = LowerArm.獣性1_獣腕CD.c2.Col1;
    									UpperArm.筋肉上CD.c2.Col2 = LowerArm.獣性1_獣腕CD.c2.Col1;
    									UpperArm.筋肉下CD.c2.Col2 = LowerArm.獣性1_獣腕CD.c2.Col1;
    								}
    								else
    								{
    									UpperArm.UpperArmCD.c2.Col2 = LowerArm.LowerArmCD.c2.Col1;
    									UpperArm.筋肉上CD.c2.Col2 = LowerArm.LowerArmCD.c2.Col1;
    									UpperArm.筋肉下CD.c2.Col2 = LowerArm.LowerArmCD.c2.Col1;
    								}
    								腕人.LowerArm = LowerArm;
    								LowerArm.手_接続.SetEle(delegate(手_人 手)
    								{
    									if (LowerArm.獣性1_獣腕_表示 || LowerArm.LowerArmCD.c2.Col1 == LowerArm.獣性1_獣腕CD.c2.Col1)
    									{
    										手.手CD.c2 = LowerArm.獣性1_獣腕CD.c2;
    										手.親指_親指1CD.c2 = 手.手CD.c2;
    									}
    									else if (手.X0Y0_手.GetOP()[0].Outline)
    									{
    										手.手CD.c2 = LowerArm.虫性1_虫腕上CD.c2;
    										手.親指_親指1CD.c2 = 手.手CD.c2;
    									}
    									腕人.手 = 手;
    								});
    							});
    							UpperArm.LowerArm_接続.SetEle(delegate(LowerArm_獣 LowerArm)
    							{
    								UpperArm.UpperArmCD.c2.Col2 = LowerArm.LowerArmCD.c2.Col1;
    								UpperArm.筋肉上CD.c2.Col2 = LowerArm.LowerArmCD.c2.Col1;
    								UpperArm.筋肉下CD.c2.Col2 = LowerArm.LowerArmCD.c2.Col1;
    								LowerArm.X0Y0_LowerArm.GetOP()[0].Outline = true;
    							});
    						});
    						Arm人左.Add(腕人);
    					}
    				}
    				else if (current_element is UpperArm_鳥)
    				{
    					翼鳥 = default(翼鳥);
    					翼鳥.UpperArm = (UpperArm_鳥)current_element;
    					翼鳥.UpperArm.鳥翼UpperArmCD.c2 = 翼鳥.UpperArm.小雨覆CD.c2;
    					翼鳥.UpperArm.キスマーク = new スタンプK(Med, Are, Cha, this, kd, 翼鳥.UpperArm);
    					sk.Add(翼鳥.UpperArm.キスマーク);
    					翼鳥.UpperArm.鞭痕 = new スタンプW(Med, Are, Cha, this, wd, 翼鳥.UpperArm);
    					sw.Add(翼鳥.UpperArm.鞭痕);
    					翼鳥.UpperArm.LowerArm_接続.SetEle(delegate(LowerArm_鳥 LowerArm)
    					{
    						翼鳥.LowerArm = LowerArm;
    						LowerArm.手_接続.SetEle(delegate(手_鳥 手)
    						{
    							翼鳥.手 = 手;
    						});
    					});
    					翼鳥左.Add(翼鳥);
    				}
    				else if (current_element is UpperArm_蝙)
    				{
    					翼獣 = default(翼獣);
    					翼獣.UpperArm = (UpperArm_蝙)current_element;
    					翼獣.UpperArm.LowerArm_接続.SetEle(delegate(LowerArm_蝙 LowerArm)
    					{
    						翼獣.LowerArm = LowerArm;
    						LowerArm.手_接続.SetEle(delegate(手_蝙 手)
    						{
    							翼獣.手 = 手;
    							p = 翼獣.UpperArm.Par;
    							pp = 翼獣.UpperArm.Par.Par;
    							if (p is BaseHair)
    							{
    								翼獣.UpperArm.接着 = () => bod.頭.X0Y0_Head.ToGlobal(bod.頭.X0Y0_Head.GetBasePointBase());
    							}
    							else if (p is Chest)
    							{
    								翼獣.UpperArm.接着 = () => bod.Torso.X0Y0_Torso.ToGlobal(bod.Torso.X0Y0_Torso.GetBasePointBase());
    							}
    							else if (p is Torso || p is Waist)
    							{
    								翼獣.UpperArm.接着 = () => bod.Waist.X0Y0_Waist.ToGlobal(bod.Waist.X0Y0_Waist.GetJP()[4].Joint);
    							}
    							else if (p is 四足胸)
    							{
    								翼獣.UpperArm.接着 = () => bod.Torso_獣.X0Y0_Torso.ToGlobal(bod.Torso_獣.X0Y0_Torso.GetBasePointBase());
    							}
    							else if ((p is 四足胴 || p is 四足腰) && (翼獣.UpperArm.ConnectionType == ConnectionInfo.四足腰_翼左_接続 || 翼獣.UpperArm.ConnectionType == ConnectionInfo.四足腰_翼右_接続))
    							{
    								翼獣.UpperArm.接着 = () => bod.Waist_獣.X0Y0_Waist.ToGlobal(bod.Waist.X0Y0_Waist.GetJP()[4].Joint);
    							}
    							else if (pp != null && pp is Chest)
    							{
    								翼獣.UpperArm.接着 = () => bod.Waist.X0Y0_Waist.ToGlobal(bod.Waist.X0Y0_Waist.GetBasePointBase());
    							}
    							else if (pp != null && pp is 四足胸)
    							{
    								翼獣.UpperArm.接着 = () => bod.Waist_獣.X0Y0_Waist.ToGlobal(bod.Waist_獣.X0Y0_Waist.GetBasePointBase());
    							}
    							else
    							{
    								翼獣.UpperArm.接着 = () => 翼獣.UpperArm.Get飛膜接続点();
    							}
    							bod.蝙通常.Add(new 蝙通常(翼獣.UpperArm, LowerArm, 手));
    						});
    					});
    					翼獣左.Add(翼獣);
    				}
    			}
    			else if (current_element is 鰭)
    			{
    				鰭左.Add((鰭)current_element);
    			}
    			else if (current_element is 葉)
    			{
    				葉左.Add((葉)current_element);
    			}
    			else if (current_element is 前翅_羽 || current_element is 前翅_蝶)
    			{
    				前翅1左.Add((前翅)current_element);
    			}
    			else if (current_element is 後翅_羽 || current_element is 後翅_蝶)
    			{
    				後翅1左.Add((後翅)current_element);
    			}
    			else if (current_element is 前翅_甲 || current_element is 前翅_草)
    			{
    				前翅2左.Add((前翅)current_element);
    			}
    			else if (current_element is 後翅_甲 || current_element is 後翅_草)
    			{
    				後翅2左.Add((後翅)current_element);
    			}
    			else if (current_element is 触肢_肢蜘)
    			{
    				触肢蜘左.Add((触肢_肢蜘)current_element);
    			}
    			else if (current_element is 触肢_肢蠍)
    			{
    				触肢蠍左.Add((触肢_肢蠍)current_element);
    			}
    			else if (current_element is 節足_足蜘)
    			{
    				節足蜘左.Add((節足_足蜘)current_element);
    			}
    			else if (current_element is 節足_足蠍)
    			{
    				節足蠍左.Add((節足_足蠍)current_element);
    			}
    			else if (current_element is 節足_足百)
    			{
    				節足百左.Add((節足_足百)current_element);
    			}
    			else if (current_element is 節尾_曳航)
    			{
    				節尾曳左.Add((節尾_曳航)current_element);
    			}
    			else if (current_element is 節尾_鋏)
    			{
    				節尾鋏左.Add((節尾_鋏)current_element);
    			}
    			else if (current_element is 大顎)
    			{
    				大顎左.Add((大顎)current_element);
    			}
    			else if (current_element is 虫顎)
    			{
    				虫顎左.Add((虫顎)current_element);
    			}
    			else if (current_element is 虫鎌)
    			{
    				虫鎌左.Add((虫鎌)current_element);
    			}
    			else if (current_element is 触手_犬)
    			{
    				触手犬左.Add((触手_犬)current_element);
    			}
    			else if (current_element is 触手)
    			{
    				触手左.Add((触手)current_element);
    			}
    			if (current_element is 尾)
    			{
    				尾.Add((尾)current_element);
    				if (!(current_element is 尾_魚) || current_element.Par is 長物_魚)
    				{
    					continue;
    				}
    				if (current_element.Par is Waist)
    				{
    					if (current_element.右)
    					{
    						((尾_魚)current_element).X0Y0_尾1_尾.GetOP()[5].Outline = false;
    					}
    					else
    					{
    						((尾_魚)current_element).X0Y0_尾1_尾.GetOP()[0].Outline = false;
    					}
    				}
    				else if (current_element.右)
    				{
    					((尾_魚)current_element).X0Y0_尾0_尾.GetOP()[5].Outline = false;
    				}
    				else
    				{
    					((尾_魚)current_element).X0Y0_尾0_尾.GetOP()[0].Outline = false;
    				}
    			}
    			else if (current_element is 長胴)
    			{
    				長胴.Add((長胴)current_element);
    			}
    		}
    		Arm人n = Arm人左.Count;
    		腕翼鳥n = 腕翼鳥左.Count;
    		腕翼獣n = 腕翼獣左.Count;
    		腕獣n = 腕獣左.Count;
    		脚人n = 脚人左.Count;
    		脚獣n = 脚獣左.Count;
    		翼鳥n = 翼鳥左.Count;
    		翼獣n = 翼獣左.Count;
    		鰭n = 鰭左.Count;
    		葉n = 葉左.Count;
    		前翅1n = 前翅1左.Count;
    		後翅1n = 後翅1左.Count;
    		前翅2n = 前翅2左.Count;
    		後翅2n = 後翅2左.Count;
    		触肢蜘n = 触肢蜘左.Count;
    		触肢蠍n = 触肢蠍左.Count;
    		節足蜘n = 節足蜘左.Count;
    		節足蠍n = 節足蠍左.Count;
    		節足百n = 節足百左.Count;
    		節尾曳n = 節尾曳左.Count;
    		節尾鋏n = 節尾鋏左.Count;
    		大顎n = 大顎左.Count;
    		虫顎n = 虫顎左.Count;
    		虫鎌n = 虫鎌左.Count;
    		触手n = 触手左.Count;
    		触手犬n = 触手犬左.Count;
    		尾n = 尾.Count;
    		長胴n = 長胴.Count;
    		if (Waist != null)
    		{
    			Torso = Waist.Torso_接続.GetEle<Torso>();
    			PregnantBelly_人 = Waist.肌_接続.GetEle<PregnantBelly_人>();
    			PregnantBellyPlate_人 = PregnantBelly_人.腹板_接続.GetEle<PregnantBellyPlate>();
    			PregnantBellyPlate_人.SetHitFalse();
    			WaistSkin_人 = Waist.肌_接続.GetEle<WaistSkin>();
    			WaistSkin_人.X0Y0_陰毛.Hit = true;
    			WaistSkin_人.X0Y0_陰毛_ハート.Hit = true;
    			WaistSkin_人.X0Y0_獣性_獣毛.Hit = true;
    			WaistSkin_人.X0Y1_陰毛.Hit = true;
    			WaistSkin_人.X0Y1_陰毛_ハート.Hit = true;
    			WaistSkin_人.X0Y1_獣性_獣毛.Hit = true;
    			WaistSkin_人.X0Y2_陰毛.Hit = true;
    			WaistSkin_人.X0Y2_陰毛_ハート.Hit = true;
    			WaistSkin_人.X0Y2_獣性_獣毛.Hit = true;
    			WaistSkin_人.X0Y3_陰毛.Hit = true;
    			WaistSkin_人.X0Y3_陰毛_ハート.Hit = true;
    			WaistSkin_人.X0Y3_獣性_獣毛.Hit = true;
    			WaistSkin_人.X0Y4_陰毛.Hit = true;
    			WaistSkin_人.X0Y4_陰毛_ハート.Hit = true;
    			WaistSkin_人.X0Y4_獣性_獣毛.Hit = true;
    			Anus_人 = Waist.Anus_接続.GetEle<Anus_人>();
    			肛門精液_人 = Anus_人.肛門精液_接続.GetEle<肛門精液_人>();
    			肛門精液_人.SetHitFalse();
    			VaginaOrigin_人 = Waist.VaginaOrigin_接続.GetEle<VaginaOrigin_人>();
    			InternalSemen_人 = Waist.VaginaOrigin_接続.GetEle<InternalSemen_人>();
    			XRay_人 = Waist.VaginaOrigin_接続.GetEle<XRay_人>();
    			VaginaOrigin_人.SetHitFalse();
    			InternalSemen_人.SetHitFalse();
    			XRay_人.SetHitFalse();
    			性器_人 = Waist.VaginaOrigin_接続.GetEle<性器_人>();
    			性器精液_人 = 性器_人.膣口_接続.GetEle<性器精液_人>();
    			飛沫_人 = 性器_人.膣口_接続.GetEle<飛沫_人>();
    			潮吹_小_人 = 性器_人.尿道_接続.GetEle<潮吹_小_人>();
    			潮吹_大_人 = 性器_人.尿道_接続.GetEle<潮吹_大_人>();
    			放尿_人 = 性器_人.尿道_接続.GetEle<放尿_人>();
    			ピアス = 性器_人.陰核_接続.GetEle<ピアス>();
    			キャップ1 = 性器_人.陰核_接続.GetEle<キャップ1>();
    			下着陰核 = 性器_人.陰核_接続.GetEle<下着陰核>();
    			性器精液_人.SetHitFalse();
    			飛沫_人.SetHitFalse();
    			潮吹_小_人.SetHitFalse();
    			潮吹_大_人.SetHitFalse();
    			放尿_人.SetHitFalse();
    			ピアス.SetHitFalse();
    			下着陰核.SetHitFalse();
    			下着B_ノーマル = Waist.肌_接続.GetEle<下着ボトム_ノーマル>();
    			下着B_マイクロ = Waist.肌_接続.GetEle<下着ボトム_マイクロ>();
    			下着B_ノーマル.SetHitFalse();
    			下着B_マイクロ.SetHitFalse();
    			上着B_クロス = Waist.上着_接続.GetEle<JacketBottom_クロス>();
    			上着B_クロス後 = (JacketBottom_クロス後)上着B_クロス.JacketBottomRear_接続[0];
    			上着B_前掛け = Waist.上着_接続.GetEle<JacketBottom_前掛け>();
    			上着B_クロス.SetHitFalse();
    			上着B_クロス後.SetHitFalse();
    			上着B_前掛け.SetHitFalse();
    		}
    		if (Torso != null)
    		{
    			Chest = Torso.Chest_接続.GetEle<Chest>();
    			TorsoPlate_人 = Torso.肌_接続.GetEle<TorsoPlate>();
    			TorsoSkin_人 = Torso.肌_接続.GetEle<TorsoSkin>();
    			TorsoPlate_人.SetHitFalse();
    			TorsoSkin_人.SetHitFalse();
    			上着M_ドレス = Torso.肌_接続.GetEle<上着ミドル_ドレス>();
    			上着M_ドレス.SetHitFalse();
    		}
    		if (Chest != null)
    		{
    			Neck = Chest.Neck_接続.GetEle<Neck>();
    			胸腹板_人 = Chest.肌_接続.GetEle<胸腹板>();
    			胸肌_人 = Chest.肌_接続.GetEle<胸肌>();
    			胸毛_人 = Chest.肌_接続.GetEle<胸毛>();
    			胸腹板_人.SetHitFalse();
    			胸肌_人.SetHitFalse();
    			乳房左 = Chest.胸左_接続.GetEle<乳房>();
    			LeftMilkSpray = 乳房左.噴乳_接続.GetEle<噴乳>();
    			ピアス左 = 乳房左.噴乳_接続.GetEle<ピアス>();
    			キャップ2左 = 乳房左.噴乳_接続.GetEle<キャップ2>();
    			下着乳首左 = 乳房左.噴乳_接続.GetEle<下着乳首>();
    			LeftMilkSpray.SetHitFalse();
    			ピアス左.SetHitFalse();
    			下着乳首左.SetHitFalse();
    			乳房右 = Chest.胸右_接続.GetEle<乳房>();
    			RightMilkSpary = 乳房右.噴乳_接続.GetEle<噴乳>();
    			ピアス右 = 乳房右.噴乳_接続.GetEle<ピアス>();
    			キャップ2右 = 乳房右.噴乳_接続.GetEle<キャップ2>();
    			下着乳首右 = 乳房右.噴乳_接続.GetEle<下着乳首>();
    			RightMilkSpary.SetHitFalse();
    			ピアス右.SetHitFalse();
    			下着乳首右.SetHitFalse();
    			下着T_チューブ = Chest.肌_接続.GetEle<下着トップ_チューブ>();
    			下着T_クロス = Chest.肌_接続.GetEle<下着トップ_クロス>();
    			下着T_ビキニ = Chest.肌_接続.GetEle<下着トップ_ビキニ>();
    			下着T_マイクロ = Chest.肌_接続.GetEle<下着トップ_マイクロ>();
    			下着T_ブラ = Chest.肌_接続.GetEle<下着トップ_ブラ>();
    			下着T_チューブ.SetHitFalse();
    			下着T_クロス.SetHitFalse();
    			下着T_ビキニ.SetHitFalse();
    			下着T_マイクロ.SetHitFalse();
    			下着T_ブラ.SetHitFalse();
    			上着T_ドレス = Chest.肌_接続.GetEle<上着トップ_ドレス>();
    			上着T_ドレス.SetHitFalse();
    		}
    		if (Neck != null)
    		{
    			頭 = Neck.Head_接続.GetEle<Head>();
    		}
    		if (頭 != null)
    		{
    			BaseHair = 頭.BaseHair_接続.GetEle<BaseHair>();
    			単眼目 = 頭.単眼目_接続.GetEle<単目>();
    			if (単眼目 != null)
    			{
    				単眼瞼 = 単眼目.瞼_接続.GetEle<単瞼>();
    				LeftTear = 単眼目.瞼_接続.GetEle<涙>(右: false);
    				RightTear = 単眼目.瞼_接続.GetEle<涙>(右: true);
    				単眼目.SetHitFalse();
    				単眼瞼.SetHitFalse();
    				LeftTear.SetHitFalse();
    				RightTear.SetHitFalse();
    			}
    			目左 = 頭.目左_接続.GetEle<双目>();
    			目右 = 頭.目右_接続.GetEle<双目>();
    			if (目左 != null)
    			{
    				瞼左 = 目左.瞼_接続.GetEle<双瞼>();
    				LeftTear = 目左.瞼_接続.GetEle<涙>();
    				目左.SetHitFalse();
    				瞼左.SetHitFalse();
    				LeftTear.SetHitFalse();
    			}
    			if (目右 != null)
    			{
    				瞼右 = 目右.瞼_接続.GetEle<双瞼>();
    				RightTear = 目右.瞼_接続.GetEle<涙>();
    				目右.SetHitFalse();
    				瞼右.SetHitFalse();
    				RightTear.SetHitFalse();
    			}
    			額目 = 頭.額_接続.GetEle<縦目>();
    			頬目左 = 頭.頬肌左_接続.GetEle<頬目>();
    			頬目右 = 頭.頬肌右_接続.GetEle<頬目>();
    			if (額目 != null)
    			{
    				額瞼 = 額目.瞼_接続.GetEle<縦瞼>();
    				額目.SetHitFalse();
    				額瞼.SetHitFalse();
    			}
    			if (頬目左 != null)
    			{
    				頬瞼左 = 頬目左.瞼_接続.GetEle<頬瞼>();
    				頬目左.SetHitFalse();
    				頬瞼左.SetHitFalse();
    			}
    			if (頬目右 != null)
    			{
    				頬瞼右 = 頬目右.瞼_接続.GetEle<頬瞼>();
    				頬目右.SetHitFalse();
    				頬瞼右.SetHitFalse();
    			}
    			目隠帯 = 頭.単眼目_接続.GetEle<目隠帯>();
    			鼻 = 頭.鼻_接続.GetEle<鼻>();
    			if (鼻 != null)
    			{
    				LeftNoseDrip = 鼻.鼻水左_接続.GetEle<鼻水>();
    				RightNoseDrip = 鼻.鼻水右_接続.GetEle<鼻水>();
    				鼻.SetHitFalse();
    				LeftNoseDrip.SetHitFalse();
    				RightNoseDrip.SetHitFalse();
    			}
    			口 = 頭.口_接続.GetEle<口>();
    			口.SetHitFalse();
    			Tounge = 頭.口_接続.GetEle<Tounge>();
    			Tounge.SetHitFalse();
    			LeftDrool = 頭.口_接続.GetEle<涎>(右: false);
    			RightDrool = 頭.口_接続.GetEle<涎>(右: true);
    			LeftDrool.SetHitFalse();
    			RightDrool.SetHitFalse();
    			MouthCum = 頭.口_接続.GetEle<性器精液_人>();
    			MouthCum.SetHitFalse();
    			咳 = 頭.口_接続.GetEle<Cough>();
    			咳.SetHitFalse();
    			呼気 = 頭.口_接続.GetEle<呼気>();
    			呼気.SetHitFalse();
    			玉口枷 = 頭.口_接続.GetEle<玉口枷>();
    			単眼眉 = 頭.単眼眉_接続.GetEle<単眼眉>();
    			if (単眼眉 != null)
    			{
    				単眼眉.SetHitFalse();
    			}
    			眉左 = 頭.眉左_接続.GetEle<眉>();
    			眉右 = 頭.眉右_接続.GetEle<眉>();
    			if (眉左 != null)
    			{
    				眉左.SetHitFalse();
    			}
    			if (眉右 != null)
    			{
    				眉右.SetHitFalse();
    			}
    			頬肌左 = 頭.頬肌左_接続.GetEle<頬肌>();
    			頬肌右 = 頭.頬肌右_接続.GetEle<頬肌>();
    			頬肌左.SetHitFalse();
    			頬肌右.SetHitFalse();
    			鼻肌 = 頭.鼻肌_接続.GetEle<鼻肌>();
    			鼻肌.SetHitFalse();
    			目尻影左 = 頭.目左_接続.GetEle<目尻影>();
    			目尻影右 = 頭.目右_接続.GetEle<目尻影>();
    			目尻影左.SetHitFalse();
    			目尻影右.SetHitFalse();
    			紅潮 = 頭.鼻肌_接続.GetEle<紅潮>();
    			紅潮.SetHitFalse();
    			目傷左 = 頭.目左_接続.GetEle<目傷>();
    			目傷右 = 頭.目右_接続.GetEle<目傷>();
    			目傷左.SetHitFalse();
    			目傷右.SetHitFalse();
    			顔ハイライト左 = 頭.頬左_接続.GetEle<顔ハイライト>();
    			顔ハイライト右 = 頭.頬右_接続.GetEle<顔ハイライト>();
    			顔ハイライト左.SetHitFalse();
    			顔ハイライト右.SetHitFalse();
    		}
    		if (BaseHair != null)
    		{
    			前髪 = BaseHair.前髪_接続.GetEle<前髪>();
    			横髪左 = BaseHair.横髪左_接続.GetEle<SideHair>();
    			横髪右 = BaseHair.横髪右_接続.GetEle<SideHair>();
    			後髪1 = BaseHair.後髪_接続.GetEle<BackHair1>();
    			後髪0 = BaseHair.後髪_接続.GetEle<BackHair0>();
    		}
    		Neck.キスマーク = new スタンプK(Med, Are, Cha, this, kd, Neck);
    		sk.Add(Neck.キスマーク);
    		Neck.鞭痕 = new スタンプW(Med, Are, Cha, this, wd, Neck);
    		sw.Add(Neck.鞭痕);
    		Chest.キスマーク = new スタンプK(Med, Are, Cha, this, kd, Chest);
    		sk.Add(Chest.キスマーク);
    		Chest.鞭痕 = new スタンプW(Med, Are, Cha, this, wd, Chest);
    		sw.Add(Chest.鞭痕);
    		Torso.キスマーク = new スタンプK(Med, Are, Cha, this, kd, Torso);
    		sk.Add(Torso.キスマーク);
    		Torso.鞭痕 = new スタンプW(Med, Are, Cha, this, wd, Torso);
    		sw.Add(Torso.鞭痕);
    		Waist.キスマーク = new スタンプK(Med, Are, Cha, this, kd, Waist);
    		sk.Add(Waist.キスマーク);
    		Waist.鞭痕 = new スタンプW(Med, Are, Cha, this, wd, Waist);
    		sw.Add(Waist.鞭痕);
    		PregnantBelly_人.キスマーク = new スタンプK(Med, Are, Cha, this, kd, PregnantBelly_人);
    		sk.Add(PregnantBelly_人.キスマーク);
    		PregnantBelly_人.鞭痕 = new スタンプW(Med, Are, Cha, this, wd, PregnantBelly_人);
    		sw.Add(PregnantBelly_人.鞭痕);
    		乳房左.キスマーク = new スタンプK(Med, Are, Cha, this, kd, 乳房左);
    		sk.Add(乳房左.キスマーク);
    		乳房左.鞭痕 = new スタンプW(Med, Are, Cha, this, wd, 乳房左);
    		sw.Add(乳房左.鞭痕);
    		乳房右.キスマーク = new スタンプK(Med, Are, Cha, this, kd, 乳房右);
    		sk.Add(乳房右.キスマーク);
    		乳房右.鞭痕 = new スタンプW(Med, Are, Cha, this, wd, 乳房右);
    		sw.Add(乳房右.鞭痕);
    		キスマーク = sk.ToArray();
    		鞭痕 = sw.ToArray();
    		ぶっかけ小 = new スタンプB(Med, Are, Cha, this, new ぶっかけ_小D(), Cha.Motions);
    		ぶっかけ大 = new スタンプB(Med, Are, Cha, this, new ぶっかけ_大D(), Cha.Motions);
    		Is瞼宇 = 瞼左 is 瞼_宇;
    		涙描画 = LeftTear != null;
    		鼻描画 = 鼻 != null;
    		if (後髪1 != null)
    		{
    			Sort(後髪1.EnumEle(), 後髪接続);
    		}
    		if (後髪0 != null)
    		{
    			Sort(後髪0.EnumEle(), 後髪接続);
    		}
    		if (頭.額_接続 != null)
    		{
    			Sort((from e in 頭.額_接続
    				where !(e is 縦目)
    				select e.EnumEle()).JoinEnum(), 額接続);
    		}
    		if (頭.耳左_接続 != null)
    		{
    			Sort(頭.耳左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 耳左接続);
    		}
    		if (頭.耳右_接続 != null)
    		{
    			Sort(頭.耳右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 耳右接続);
    		}
    		if (頭.触覚左_接続 != null)
    		{
    			Sort(頭.触覚左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 触覚左接続);
    		}
    		if (頭.触覚右_接続 != null)
    		{
    			Sort(頭.触覚右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 触覚右接続);
    		}
    		if (頭.頬左_接続 != null)
    		{
    			Sort(頭.頬左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 頬左接続);
    		}
    		if (頭.頬右_接続 != null)
    		{
    			Sort(頭.頬右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 頬右接続);
    		}
    		if (BaseHair.頭頂左_接続 != null)
    		{
    			角左接続.AddRange(BaseHair.頭頂左_接続.GetEles<角2>());
    			獣耳左 = BaseHair.頭頂左_接続.GetEle<獣耳>();
    			Sort((from e in BaseHair.頭頂左_接続.GetEles<植>()
    				select e.EnumEle()).JoinEnum(), 植左接続);
    			Sort((from e in BaseHair.頭頂左_接続
    				where !(e is 角2) && !(e is 獣耳) && !(e is 植) && !(e is SideHair)
    				select e.EnumEle()).JoinEnum(), 頭頂左後接続);
    		}
    		if (BaseHair.頭頂右_接続 != null)
    		{
    			角右接続.AddRange(BaseHair.頭頂右_接続.GetEles<角2>());
    			獣耳右 = BaseHair.頭頂右_接続.GetEle<獣耳>();
    			Sort((from e in BaseHair.頭頂右_接続.GetEles<植>()
    				select e.EnumEle()).JoinEnum(), 植右接続);
    			Sort((from e in BaseHair.頭頂右_接続
    				where !(e is 角2) && !(e is 獣耳) && !(e is 植) && !(e is SideHair)
    				select e.EnumEle()).JoinEnum(), 頭頂右後接続);
    		}
    		if (頭.顔面_接続 != null)
    		{
    			顔面 = 頭.顔面_接続.GetEle<顔面>();
    			if (顔面 != null)
    			{
    				if (顔面.触覚左_接続 != null)
    				{
    					Sort(顔面.触覚左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 顔触覚左接続);
    				}
    				if (顔面.触覚右_接続 != null)
    				{
    					Sort(顔面.触覚右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 顔触覚右接続);
    				}
    			}
    		}
    		if (頭.大顎基_接続 != null)
    		{
    			Sort(頭.大顎基_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 大顎基接続);
    		}
    		if (頭.頭頂_接続 != null)
    		{
    			頭頂 = 頭.頭頂_接続.GetEle<頭頂>();
    			if (Is頭頂_宇 = 頭頂 is 頭頂_宇)
    			{
    				頭頂後 = ((頭頂_宇)頭頂).頭部後_接続.GetEle<頭頂後_宇>();
    			}
    		}
    		if (Chest.肩左_接続 != null)
    		{
    			後脇左s = Chest.肩左_接続.GetEles<Shoulder>().ToArray();
    			肩左 = 後脇左s.LastOrDefault();
    			if (後脇左s.Length > 1)
    			{
    				後腕左s = new List<Element>[後脇左s.Length - 1];
    				for (int j = 0; j < 後腕左s.Length; j++)
    				{
    					後腕左s[j] = new List<Element>();
    					Sort(後脇左s[j].EnumEle(), 後腕左s[j]);
    				}
    				if (肩左.UpperArm_接続 != null)
    				{
    					Sort(肩左.UpperArm_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 腕左);
    				}
    			}
    			else if (後脇左s.Length == 1 && 肩左.UpperArm_接続 != null)
    			{
    				後腕左s = new List<Element>[肩左.UpperArm_接続.Length - 1];
    				for (int k = 0; k < 後腕左s.Length; k++)
    				{
    					後腕左s[k] = new List<Element>();
    					Sort(肩左.UpperArm_接続[k].EnumEle(), 後腕左s[k]);
    				}
    				Sort(肩左.UpperArm_接続.Last().EnumEle(), 腕左);
    			}
    			後脇左s = 後脇左s.Take(後脇左s.Length - 1).ToArray();
    		}
    		nsl = new bool[1 + ((後腕左s != null) ? 後腕左s.Length : 0)];
    		if (Chest.肩右_接続 != null)
    		{
    			後脇右s = Chest.肩右_接続.GetEles<Shoulder>().ToArray();
    			肩右 = 後脇右s.LastOrDefault();
    			if (後脇右s.Length > 1)
    			{
    				後腕右s = new List<Element>[後脇右s.Length - 1];
    				for (int l = 0; l < 後腕右s.Length; l++)
    				{
    					後腕右s[l] = new List<Element>();
    					Sort(後脇右s[l].EnumEle(), 後腕右s[l]);
    				}
    				if (肩右.UpperArm_接続 != null)
    				{
    					Sort(肩右.UpperArm_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 腕右);
    				}
    			}
    			else if (後脇右s.Length == 1 && 肩右.UpperArm_接続 != null)
    			{
    				後腕右s = new List<Element>[肩右.UpperArm_接続.Length - 1];
    				for (int m = 0; m < 後腕右s.Length; m++)
    				{
    					後腕右s[m] = new List<Element>();
    					Sort(肩右.UpperArm_接続[m].EnumEle(), 後腕右s[m]);
    				}
    				Sort(肩右.UpperArm_接続.Last().EnumEle(), 腕右);
    			}
    			後脇右s = 後脇右s.Take(後脇右s.Length - 1).ToArray();
    		}
    		nsr = new bool[1 + ((後腕右s != null) ? 後腕右s.Length : 0)];
    		if (Chest.翼上左_接続 != null)
    		{
    			Sort(Chest.翼上左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 胸上左接続);
    		}
    		if (Chest.翼下左_接続 != null)
    		{
    			Sort(Chest.翼下左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 胸下左接続);
    		}
    		if (Chest.翼上右_接続 != null)
    		{
    			Sort(Chest.翼上右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 胸上右接続);
    		}
    		if (Chest.翼下右_接続 != null)
    		{
    			Sort(Chest.翼下右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 胸下右接続);
    		}
    		if (Torso.翼左_接続 != null)
    		{
    			Sort(Torso.翼左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 胴後左接続);
    		}
    		if (Torso.翼右_接続 != null)
    		{
    			Sort(Torso.翼右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 胴後右接続);
    		}
    		if (Waist.翼左_接続 != null)
    		{
    			Sort(Waist.翼左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 腰後左接続);
    		}
    		if (Waist.翼右_接続 != null)
    		{
    			Sort(Waist.翼右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 腰後右接続);
    		}
    		if (Chest.背中_接続 != null)
    		{
    			Sort(Chest.背中_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 背中接続);
    		}
    		if (Waist.腿左_接続 != null)
    		{
    			Sort((from e in Waist.腿左_接続
    				where !(e is 腿)
    				select e.EnumEle()).JoinEnum(), 腿左接続);
    			Sort((from e in Waist.腿左_接続.GetEles<腿>()
    				select e.EnumEle()).JoinEnum(), 腿左接続);
    		}
    		if (Waist.腿右_接続 != null)
    		{
    			Sort((from e in Waist.腿右_接続
    				where !(e is 腿)
    				select e.EnumEle()).JoinEnum(), 腿右接続);
    			Sort((from e in Waist.腿右_接続.GetEles<腿>()
    				select e.EnumEle()).JoinEnum(), 腿右接続);
    		}
    		if (Waist.尾_接続 != null)
    		{
    			Sort(Waist.尾_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 尾接続);
    		}
    		if (Waist.半身_接続 != null)
    		{
    			半身 ele = Waist.半身_接続.GetEle<半身>();
    			if (ele is 長物_魚)
    			{
    				Is魚 = true;
    				魚 = (長物_魚)ele;
    				Waist.WaistCD.c2.Col2 = 魚.Torso1_Torso1CD.c2.Col1;
    				半身中1接続.Add(魚);
    				if (魚.尾_接続 != null)
    				{
    					Sort(魚.尾_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身後接続);
    				}
    				if (腕獣左.Count > 0 && 腕獣左.First().Shoulder.UpperArm_接続.IsEle<獣脚>())
    				{
    					Sort(from e in 魚.EnumEle().Skip(1)
    						where !bod.半身後接続.Contains(e)
    						select e, 半身前接続);
    				}
    				else
    				{
    					Sort(from e in 魚.EnumEle().Skip(1)
    						where !bod.半身後接続.Contains(e)
    						select e, 半身中2接続);
    					Element[] array = 腿左接続.Where((Element e) => !(e is 腿) && !(e.Par is 腿) && !((e.Par is Leg) | (e.Par is 足))).ToArray();
    					foreach (Element item in array)
    					{
    						腿左接続.Remove(item);
    						半身前接続.Add(item);
    					}
    					array = 腿右接続.Where((Element e) => !(e is 腿) && !(e.Par is 腿) && !((e.Par is Leg) | (e.Par is 足))).ToArray();
    					foreach (Element item2 in array)
    					{
    						腿右接続.Remove(item2);
    						半身前接続.Add(item2);
    					}
    				}
    			}
    			else if (ele is 長物_鯨)
    			{
    				Is鯨 = true;
    				鯨 = (長物_鯨)ele;
    				Waist.WaistCD.c2.Col2 = 鯨.Torso1_TorsoCD.c2.Col1;
    				半身中1接続.Add(鯨);
    				if (鯨.尾_接続 != null)
    				{
    					Sort(鯨.尾_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身後接続);
    				}
    				if (腕獣左.Count > 0 && 腕獣左.First().Shoulder.UpperArm_接続.IsEle<獣脚>())
    				{
    					Sort(from e in 鯨.EnumEle().Skip(1)
    						where !bod.半身後接続.Contains(e)
    						select e, 半身前接続);
    				}
    				else
    				{
    					Sort(from e in 鯨.EnumEle().Skip(1)
    						where !bod.半身後接続.Contains(e)
    						select e, 半身中2接続);
    					Element[] array = 腿左接続.Where((Element e) => !(e is 腿) && !(e.Par is 腿) && !((e.Par is Leg) | (e.Par is 足))).ToArray();
    					foreach (Element item3 in array)
    					{
    						腿左接続.Remove(item3);
    						半身前接続.Add(item3);
    					}
    					array = 腿右接続.Where((Element e) => !(e is 腿) && !(e.Par is 腿) && !((e.Par is Leg) | (e.Par is 足))).ToArray();
    					foreach (Element item4 in array)
    					{
    						腿右接続.Remove(item4);
    						半身前接続.Add(item4);
    					}
    				}
    			}
    			else if (ele is 長物_蛇)
    			{
    				Is蛇 = true;
    				蛇 = (長物_蛇)ele;
    				Waist.WaistCD.c2.Col2 = 蛇.Torso1_鱗1CD.c2.Col1;
    				半身中1接続.Add(ele);
    				if (蛇.Torso_接続 != null)
    				{
    					foreach (Torso_蛇 item20 in 蛇.EnumEle().GetEles<Torso_蛇>().Reverse())
    					{
    						if (item20.左_接続 != null)
    						{
    							Sort(item20.左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身中2接続);
    						}
    						if (item20.右_接続 != null)
    						{
    							Sort(item20.右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身中2接続);
    						}
    					}
    					Sort(from e in 蛇.Torso_接続.Select((Element e) => e.EnumEle()).JoinEnum()
    						where !bod.半身中2接続.Contains(e)
    						select e, 半身後接続);
    				}
    				蛇前 = new DrawableElement(蛇, 蛇.前描画);
    				if (蛇.左_接続 != null)
    				{
    					Sort(蛇.左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蛇.右_接続 != null)
    				{
    					Sort(蛇.右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				節足 ele2 = 半身中2接続.GetEle<節足>();
    				if (ele2 != null && (((ele2 is 節足_足蜘 || ele2 is 節足_足蠍) && !ele2.反転Y) || (ele2 is 節足_足百 && ele2.反転Y)))
    				{
    					半身中2接続.Reverse();
    				}
    				Element[] array = 腿左接続.Where((Element e) => !(e is 腿) && !(e.Par is 腿) && !((e.Par is Leg) | (e.Par is 足))).ToArray();
    				foreach (Element item5 in array)
    				{
    					腿左接続.Remove(item5);
    					半身前接続.Add(item5);
    				}
    				array = 腿右接続.Where((Element e) => !(e is 腿) && !(e.Par is 腿) && !((e.Par is Leg) | (e.Par is 足))).ToArray();
    				foreach (Element item6 in array)
    				{
    					腿右接続.Remove(item6);
    					半身前接続.Add(item6);
    				}
    			}
    			else if (ele is 長物_蟲)
    			{
    				Is蟲 = true;
    				蟲 = (長物_蟲)ele;
    				Waist.WaistCD.c2.Col2 = 蟲.Torso1_TorsoCD.c2.Col1;
    				半身中1接続.Add(ele);
    				if (蟲.Torso_接続 != null)
    				{
    					foreach (Torso_蟲 item21 in 蟲.EnumEle().GetEles<Torso_蟲>().Reverse())
    					{
    						if (item21.左_接続 != null)
    						{
    							Sort(item21.左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身中2接続);
    						}
    						if (item21.右_接続 != null)
    						{
    							Sort(item21.右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身中2接続);
    						}
    					}
    					Sort(from e in 蟲.Torso_接続.Select((Element e) => e.EnumEle()).JoinEnum()
    						where !bod.半身中2接続.Contains(e)
    						select e, 半身後接続);
    				}
    				if (蟲.左1_接続 != null)
    				{
    					Sort(蟲.左1_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蟲.右1_接続 != null)
    				{
    					Sort(蟲.右1_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蟲.左0_接続 != null)
    				{
    					Sort(蟲.左0_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蟲.右0_接続 != null)
    				{
    					Sort(蟲.右0_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				節足 ele3 = 半身中2接続.GetEle<節足>();
    				if (ele3 != null && (((ele3 is 節足_足蜘 || ele3 is 節足_足蠍) && !ele3.反転Y) || (ele3 is 節足_足百 && ele3.反転Y)))
    				{
    					半身中2接続.Reverse();
    				}
    			}
    			else if (ele is 四足胸)
    			{
    				Is獣 = true;
    				foreach (Element item22 in ele.EnumEle())
    				{
    					if (item22 is 四足胸)
    					{
    						Chest_獣 = (四足胸)item22;
    					}
    					else if (item22 is 四足胴)
    					{
    						Torso_獣 = (四足胴)item22;
    					}
    					else if (item22 is 四足腰)
    					{
    						Waist_獣 = (四足腰)item22;
    					}
    					else if (item22 is 四足脇)
    					{
    						if (item22.右)
    						{
    							脇右_獣.Add((四足脇)item22);
    						}
    						else
    						{
    							脇左_獣.Add((四足脇)item22);
    						}
    					}
    					else if (item22 is 胸肌)
    					{
    						胸肌_獣 = (胸肌)item22;
    					}
    					else if (item22 is TorsoSkin)
    					{
    						TorsoSkin_獣 = (TorsoSkin)item22;
    					}
    					else if (item22 is WaistSkin)
    					{
    						WaistSkin_獣 = (WaistSkin)item22;
    					}
    					else if (item22 is 胸毛)
    					{
    						胸毛_獣 = (胸毛)item22;
    					}
    					else if (item22 is PregnantBelly_獣)
    					{
    						PregnantBelly_獣 = (PregnantBelly_獣)item22;
    					}
    					else if (item22 is Anus_獣)
    					{
    						Anus_獣 = (Anus_獣)item22;
    					}
    					else if (item22 is 肛門精液_獣)
    					{
    						肛門精液_獣 = (肛門精液_獣)item22;
    					}
    					else if (item22 is VaginaOrigin_獣)
    					{
    						VaginaOrigin_獣 = (VaginaOrigin_獣)item22;
    					}
    					else if (item22 is InternalSemen_獣)
    					{
    						InternalSemen_獣 = (InternalSemen_獣)item22;
    					}
    					else if (item22 is XRay_獣)
    					{
    						XRay_獣 = (XRay_獣)item22;
    					}
    					else if (item22 is 性器_獣)
    					{
    						性器_獣 = (性器_獣)item22;
    					}
    					else if (item22 is 性器精液_獣)
    					{
    						性器精液_獣 = (性器精液_獣)item22;
    					}
    					else if (item22 is 飛沫_獣)
    					{
    						飛沫_獣 = (飛沫_獣)item22;
    					}
    					else if (item22 is 潮吹_小_獣)
    					{
    						潮吹_小_獣 = (潮吹_小_獣)item22;
    					}
    					else if (item22 is 潮吹_大_獣)
    					{
    						潮吹_大_獣 = (潮吹_大_獣)item22;
    					}
    					else if (item22 is 放尿_獣)
    					{
    						放尿_獣 = (放尿_獣)item22;
    					}
    					else if (item22 is ピアス)
    					{
    						ピアス = (ピアス)item22;
    					}
    					else if (item22 is キャップ1)
    					{
    						キャップ1 = (キャップ1)item22;
    					}
    				}
    				胸肌_獣.SetHitFalse();
    				TorsoSkin_獣.SetHitFalse();
    				WaistSkin_獣.SetHitFalse();
    				WaistSkin_獣.X0Y0_陰毛.Hit = true;
    				WaistSkin_獣.X0Y0_陰毛_ハート.Hit = true;
    				WaistSkin_獣.X0Y0_獣性_獣毛.Hit = true;
    				WaistSkin_獣.X0Y1_陰毛.Hit = true;
    				WaistSkin_獣.X0Y1_陰毛_ハート.Hit = true;
    				WaistSkin_獣.X0Y1_獣性_獣毛.Hit = true;
    				WaistSkin_獣.X0Y2_陰毛.Hit = true;
    				WaistSkin_獣.X0Y2_陰毛_ハート.Hit = true;
    				WaistSkin_獣.X0Y2_獣性_獣毛.Hit = true;
    				WaistSkin_獣.X0Y3_陰毛.Hit = true;
    				WaistSkin_獣.X0Y3_陰毛_ハート.Hit = true;
    				WaistSkin_獣.X0Y3_獣性_獣毛.Hit = true;
    				WaistSkin_獣.X0Y4_陰毛.Hit = true;
    				WaistSkin_獣.X0Y4_陰毛_ハート.Hit = true;
    				WaistSkin_獣.X0Y4_獣性_獣毛.Hit = true;
    				肛門精液_獣.SetHitFalse();
    				VaginaOrigin_獣.SetHitFalse();
    				InternalSemen_獣.SetHitFalse();
    				XRay_獣.SetHitFalse();
    				性器精液_獣.SetHitFalse();
    				飛沫_獣.SetHitFalse();
    				潮吹_小_獣.SetHitFalse();
    				潮吹_大_獣.SetHitFalse();
    				放尿_獣.SetHitFalse();
    				ピアス.SetHitFalse();
    				Waist.WaistCD.c2.Col2 = Chest_獣.RibCageCD.c2.Col1;
    				if (Waist_獣 != null)
    				{
    					半身中1接続.Add(Waist_獣);
    				}
    				if (Torso_獣 != null)
    				{
    					半身中1接続.Add(Torso_獣);
    				}
    				if (Chest_獣 != null)
    				{
    					半身中1接続.Add(new DrawableElement(Chest_獣, Chest_獣.胸描画));
    				}
    				if (Chest_獣 != null)
    				{
    					半身中1接続.Add(new DrawableElement(Chest_獣, Chest_獣.肌描画));
    				}
    				if (PregnantBelly_獣 != null)
    				{
    					半身中1接続.Add(PregnantBelly_獣);
    				}
    				if (WaistSkin_獣 != null)
    				{
    					半身中1接続.Add(WaistSkin_獣);
    				}
    				if (TorsoSkin_獣 != null)
    				{
    					半身中1接続.Add(TorsoSkin_獣);
    				}
    				if (胸肌_獣 != null)
    				{
    					半身中2接続.Add(胸肌_獣);
    				}
    				if (脇左_獣 != null)
    				{
    					Sort(脇左_獣.Select((四足脇 e) => e.EnumEle().Skip(1)).JoinEnum(), 半身前接続);
    				}
    				if (脇右_獣 != null)
    				{
    					Sort(脇右_獣.Select((四足脇 e) => e.EnumEle().Skip(1)).JoinEnum(), 半身前接続);
    				}
    				if (Waist_獣 != null)
    				{
    					if (Waist_獣.腿左_接続 != null)
    					{
    						Sort(Waist_獣.腿左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    					}
    					if (Waist_獣.腿右_接続 != null)
    					{
    						Sort(Waist_獣.腿右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    					}
    					if (Waist_獣.翼左_接続 != null)
    					{
    						Sort(Waist_獣.翼左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身後接続);
    					}
    					if (Waist_獣.翼右_接続 != null)
    					{
    						Sort(Waist_獣.翼右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身後接続);
    					}
    					if (Waist_獣.尾_接続 != null)
    					{
    						Sort(Waist_獣.尾_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身中1接続);
    					}
    					if (Waist_獣.半身_接続 != null)
    					{
    						Sort(Waist_獣.半身_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身中1接続);
    					}
    				}
    				if (Torso_獣 != null)
    				{
    					if (Torso_獣.翼左_接続 != null)
    					{
    						Sort(Torso_獣.翼左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身後接続);
    					}
    					if (Torso_獣.翼右_接続 != null)
    					{
    						Sort(Torso_獣.翼右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身後接続);
    					}
    				}
    				if (Chest_獣 != null)
    				{
    					if (Chest_獣.背中_接続 != null)
    					{
    						Sort(Chest_獣.背中_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身後接続);
    					}
    					if (Chest_獣.翼上左_接続 != null)
    					{
    						Sort(Chest_獣.翼上左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身後接続);
    					}
    					if (Chest_獣.翼下左_接続 != null)
    					{
    						Sort(Chest_獣.翼下左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身後接続);
    					}
    					if (Chest_獣.翼上右_接続 != null)
    					{
    						Sort(Chest_獣.翼上右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身後接続);
    					}
    					if (Chest_獣.翼下右_接続 != null)
    					{
    						Sort(Chest_獣.翼下右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身後接続);
    					}
    				}
    				if (胸毛_獣 != null)
    				{
    					if (捲り判定0)
    					{
    						半身前接続.Add(胸毛_獣);
    					}
    					else
    					{
    						半身中2接続.Add(胸毛_獣);
    					}
    				}
    				Sort(from e in ele.EnumEle().Skip(1)
    					where !bod.半身前接続.Contains(e) && !bod.半身中1接続.Contains(e) && !bod.半身後接続.Contains(e) && !(e is 四足脇) && e != bod.Anus_獣 && e != bod.肛門精液_獣 && e != bod.VaginaOrigin_獣 && e != bod.InternalSemen_獣 && e != bod.XRay_獣 && e != bod.性器_獣 && e != bod.性器精液_獣 && e != bod.飛沫_獣 && e != bod.潮吹_小_獣 && e != bod.潮吹_大_獣 && e != bod.放尿_獣 && e != bod.ピアス && e != bod.キャップ1
    					select e, 半身後接続);
    			}
    			else if (ele is 多足_蛸)
    			{
    				Is蛸 = true;
    				蛸 = (多足_蛸)ele;
    				Waist.WaistCD.c2.Col2 = 蛸.TorsoCD.c2.Col1;
    				半身中1接続.Add(蛸);
    				if (蛸.軟体内左_接続 != null)
    				{
    					Sort(蛸.軟体内左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身中2接続);
    				}
    				if (蛸.軟体内右_接続 != null)
    				{
    					Sort(蛸.軟体内右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身中2接続);
    				}
    				if (蛸.軟体外左_接続 != null)
    				{
    					Sort(蛸.軟体外左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身中2接続);
    				}
    				if (蛸.軟体外右_接続 != null)
    				{
    					Sort(蛸.軟体外右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身中2接続);
    				}
    				Element[] array = 腿左接続.Where((Element e) => !(e is 腿) && !(e.Par is 腿) && !((e.Par is Leg) | (e.Par is 足))).ToArray();
    				foreach (Element item7 in array)
    				{
    					腿左接続.Remove(item7);
    					半身前接続.Add(item7);
    				}
    				array = 腿右接続.Where((Element e) => !(e is 腿) && !(e.Par is 腿) && !((e.Par is Leg) | (e.Par is 足))).ToArray();
    				foreach (Element item8 in array)
    				{
    					腿右接続.Remove(item8);
    					半身前接続.Add(item8);
    				}
    			}
    			else if (ele is 多足_蜘)
    			{
    				Is蜘 = true;
    				蜘 = (多足_蜘)ele;
    				Waist.WaistCD.c2.Col2 = 蜘.柄CD.c2.Col2;
    				if (蜘.尾_接続 != null)
    				{
    					Sort(蜘.尾_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身後接続);
    				}
    				半身中1接続.Add(蜘);
    				if (蜘.触肢左_接続 != null)
    				{
    					Sort(蜘.触肢左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蜘.触肢右_接続 != null)
    				{
    					Sort(蜘.触肢右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蜘.節足左1_接続 != null)
    				{
    					Sort(蜘.節足左1_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蜘.節足右1_接続 != null)
    				{
    					Sort(蜘.節足右1_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蜘.節足左2_接続 != null)
    				{
    					Sort(蜘.節足左2_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蜘.節足右2_接続 != null)
    				{
    					Sort(蜘.節足右2_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蜘.節足左3_接続 != null && !蜘.節足左3_接続.IsEle<節足_足百>() && 蜘.節足左3_接続.Any((Element e_) => e_.反転Y))
    				{
    					if (蜘.節足左4_接続 != null)
    					{
    						Sort(蜘.節足左4_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    					}
    					if (蜘.節足右4_接続 != null)
    					{
    						Sort(蜘.節足右4_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    					}
    					if (蜘.節足左3_接続 != null)
    					{
    						Sort(蜘.節足左3_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    					}
    					if (蜘.節足右3_接続 != null)
    					{
    						Sort(蜘.節足右3_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    					}
    				}
    				else
    				{
    					if (蜘.節足左3_接続 != null)
    					{
    						Sort(蜘.節足左3_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    					}
    					if (蜘.節足右3_接続 != null)
    					{
    						Sort(蜘.節足右3_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    					}
    					if (蜘.節足左4_接続 != null)
    					{
    						Sort(蜘.節足左4_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    					}
    					if (蜘.節足右4_接続 != null)
    					{
    						Sort(蜘.節足右4_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    					}
    				}
    			}
    			else if (ele is 多足_蠍)
    			{
    				Is蠍 = true;
    				蠍 = (多足_蠍)ele;
    				Waist.WaistCD.c2.Col2 = 蠍.前腹_腹節3_節0CD.c2.Col1;
    				if (蠍.尾_接続 != null)
    				{
    					Sort(蠍.尾_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身後接続);
    				}
    				半身中1接続.Add(蠍);
    				蠍前 = new DrawableElement(蠍, 蠍.前描画);
    				if (蠍.触肢左_接続 != null)
    				{
    					Sort(蠍.触肢左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蠍.節足左1_接続 != null)
    				{
    					Sort(蠍.節足左1_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蠍.節足左2_接続 != null)
    				{
    					Sort(蠍.節足左2_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蠍.節足左3_接続 != null)
    				{
    					Sort(蠍.節足左3_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蠍.節足左4_接続 != null)
    				{
    					Sort(蠍.節足左4_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蠍.櫛状板左_接続 != null)
    				{
    					Sort(蠍.櫛状板左_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蠍.触肢右_接続 != null)
    				{
    					Sort(蠍.触肢右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蠍.節足右1_接続 != null)
    				{
    					Sort(蠍.節足右1_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蠍.節足右2_接続 != null)
    				{
    					Sort(蠍.節足右2_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蠍.節足右3_接続 != null)
    				{
    					Sort(蠍.節足右3_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蠍.節足右4_接続 != null)
    				{
    					Sort(蠍.節足右4_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    				if (蠍.櫛状板右_接続 != null)
    				{
    					Sort(蠍.櫛状板右_接続.Select((Element e) => e.EnumEle()).JoinEnum(), 半身前接続);
    				}
    			}
    			else if (ele is 単足_植)
    			{
    				Is植 = true;
    				植 = (単足_植)ele;
    				Sort(植.EnumEle(), 半身中1接続);
    				Element[] array = 腿左接続.Where((Element e) => !(e is 腿) && !(e.Par is 腿) && !((e.Par is Leg) | (e.Par is 足))).ToArray();
    				foreach (Element item9 in array)
    				{
    					腿左接続.Remove(item9);
    					半身前接続.Add(item9);
    				}
    				array = 腿右接続.Where((Element e) => !(e is 腿) && !(e.Par is 腿) && !((e.Par is Leg) | (e.Par is 足))).ToArray();
    				foreach (Element item10 in array)
    				{
    					腿右接続.Remove(item10);
    					半身前接続.Add(item10);
    				}
    			}
    			if (ele is 単足_粘)
    			{
    				Is粘 = true;
    				粘 = (単足_粘)ele;
    				Sort(粘.EnumEle(), 半身後接続);
    				Element[] array = 腿左接続.Where((Element e) => !(e is 腿) && !(e.Par is 腿) && !((e.Par is Leg) | (e.Par is 足))).ToArray();
    				foreach (Element item11 in array)
    				{
    					腿左接続.Remove(item11);
    					半身前接続.Add(item11);
    				}
    				array = 腿右接続.Where((Element e) => !(e is 腿) && !(e.Par is 腿) && !((e.Par is Leg) | (e.Par is 足))).ToArray();
    				foreach (Element item12 in array)
    				{
    					腿右接続.Remove(item12);
    					半身前接続.Add(item12);
    				}
    			}
    		}
    		foreach (蝙通常 item23 in 蝙通常)
    		{
    			Inserts(item23.UpperArm, 0, item23.UpperArm.飛膜);
    			Inserts(item23.手, -2, item23.手.飛膜);
    			Inserts(item23.手.飛膜, 1, new DrawableElement(item23.手, item23.手.指先描画));
    		}
    		大顎基 ele4 = 大顎基接続.GetEle<大顎基>();
    		if (ele4 != null)
    		{
    			Inserts(ele4, 1 + ((ele4.顎左_接続 != null) ? ele4.顎左_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0) + ((ele4.顎右_接続 != null) ? ele4.顎右_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0), ele4.大顎上);
    		}
    		foreach (Arm人 item24 in Arm人左)
    		{
    			if (item24.LowerArm != null)
    			{
    				Inserts(item24.LowerArm, 1 + ((item24.LowerArm.手_接続 != null) ? item24.LowerArm.手_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0) + ((item24.LowerArm.虫鎌_接続 != null) ? item24.LowerArm.虫鎌_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0), new DrawableElement(item24.LowerArm, item24.LowerArm.外腕描画));
    			}
    		}
    		foreach (Arm人 item25 in Arm人右)
    		{
    			if (item25.LowerArm != null)
    			{
    				Inserts(item25.LowerArm, 1 + ((item25.LowerArm.手_接続 != null) ? item25.LowerArm.手_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0) + ((item25.LowerArm.虫鎌_接続 != null) ? item25.LowerArm.虫鎌_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0), new DrawableElement(item25.LowerArm, item25.LowerArm.外腕描画));
    			}
    		}
    		foreach (Arm翼鳥 item26 in 腕翼鳥左)
    		{
    			if (item26.LowerArm != null)
    			{
    				Inserts(item26.LowerArm, 1 + ((item26.LowerArm.手_接続 != null) ? item26.LowerArm.手_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0), new DrawableElement(item26.LowerArm, item26.LowerArm.小雨覆描画));
    			}
    		}
    		foreach (翼鳥 item27 in 翼鳥左)
    		{
    			if (item27.LowerArm != null)
    			{
    				Inserts(item27.LowerArm, 1 + ((item27.LowerArm.手_接続 != null) ? item27.LowerArm.手_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0), new DrawableElement(item27.LowerArm, item27.LowerArm.小雨覆描画));
    			}
    		}
    		foreach (Arm翼鳥 item28 in 腕翼鳥右)
    		{
    			if (item28.LowerArm != null)
    			{
    				Inserts(item28.LowerArm, 1 + ((item28.LowerArm.手_接続 != null) ? item28.LowerArm.手_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0), new DrawableElement(item28.LowerArm, item28.LowerArm.小雨覆描画));
    			}
    		}
    		foreach (翼鳥 item29 in 翼鳥右)
    		{
    			if (item29.LowerArm != null)
    			{
    				Inserts(item29.LowerArm, 1 + ((item29.LowerArm.手_接続 != null) ? item29.LowerArm.手_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0), new DrawableElement(item29.LowerArm, item29.LowerArm.小雨覆描画));
    			}
    		}
    		foreach (Arm翼獣 item30 in 腕翼獣左)
    		{
    			if (item30.LowerArm != null)
    			{
    				Inserts(item30.LowerArm, 1 + ((item30.LowerArm.手_接続 != null) ? item30.LowerArm.手_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0), new DrawableElement(item30.LowerArm, item30.LowerArm.腕輪描画));
    			}
    		}
    		foreach (翼獣 item31 in 翼獣左)
    		{
    			if (item31.LowerArm != null)
    			{
    				Inserts(item31.LowerArm, 1 + ((item31.LowerArm.手_接続 != null) ? item31.LowerArm.手_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0), new DrawableElement(item31.LowerArm, item31.LowerArm.腕輪描画));
    			}
    		}
    		foreach (Arm翼獣 item32 in 腕翼獣右)
    		{
    			if (item32.LowerArm != null)
    			{
    				Inserts(item32.LowerArm, 1 + ((item32.LowerArm.手_接続 != null) ? item32.LowerArm.手_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0), new DrawableElement(item32.LowerArm, item32.LowerArm.腕輪描画));
    			}
    		}
    		foreach (翼獣 item33 in 翼獣右)
    		{
    			if (item33.LowerArm != null)
    			{
    				Inserts(item33.LowerArm, 1 + ((item33.LowerArm.手_接続 != null) ? item33.LowerArm.手_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0), new DrawableElement(item33.LowerArm, item33.LowerArm.腕輪描画));
    			}
    		}
    		foreach (脚人 item34 in 脚人左)
    		{
    			if (item34.Leg != null)
    			{
    				Inserts(item34.Leg, 1 + ((item34.Leg.足_接続 != null) ? item34.Leg.足_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0), new DrawableElement(item34.Leg, item34.Leg.外描画));
    			}
    		}
    		foreach (脚人 item35 in 脚人右)
    		{
    			if (item35.Leg != null)
    			{
    				Inserts(item35.Leg, 1 + ((item35.Leg.足_接続 != null) ? item35.Leg.足_接続.Select((Element f) => f.EnumEle()).JoinEnum().Count() : 0), new DrawableElement(item35.Leg, item35.Leg.外描画));
    			}
    		}
    		foreach (脚人 item36 in 脚人左)
    		{
    			if (item36.足 != null)
    			{
    				Inserts(item36.足, -1, new DrawableElement(item36.足, item36.足.底描画));
    				Inserts(item36.足, 2, new DrawableElement(item36.足, item36.足.靴描画));
    			}
    		}
    		foreach (脚人 item37 in 脚人右)
    		{
    			if (item37.足 != null)
    			{
    				Inserts(item37.足, -1, new DrawableElement(item37.足, item37.足.底描画));
    				Inserts(item37.足, 2, new DrawableElement(item37.足, item37.足.靴描画));
    			}
    		}
    		foreach (虫鎌 e in 虫鎌左)
    		{
    			if (e.ConnectionType == ConnectionInfo.LowerArm_人_虫鎌_接続)
    			{
    				int num = e.Par.EnumEle().Count((Element f) => f.Par == e.Par);
    				Inserts(e.Par, 2 + num, e)?.Remove(e);
    			}
    		}
    		foreach (虫鎌 e in 虫鎌右)
    		{
    			if (e.ConnectionType == ConnectionInfo.LowerArm_人_虫鎌_接続)
    			{
    				int num = e.Par.EnumEle().Count((Element f) => f.Par == e.Par);
    				Inserts(e.Par, 2 + num, e)?.Remove(e);
    			}
    		}
    		Element ele5 = 腕左.LastOrDefault((Element e) => e.Par != null && e.Par.Par != null && e.Par.Par.ConnectionType == ConnectionInfo.Chest_肩左_接続);
    		if (ele5 != null)
    		{
    			LowerArm以降左.Add(ele5);
    		}
    		HashSet<Element> hashSet = new HashSet<Element>();
    		foreach (蝙通常 item38 in 蝙通常.Where((蝙通常 e) => e.UpperArm.Par != null && e.UpperArm.Par.ConnectionType == ConnectionInfo.Chest_肩左_接続))
    		{
    			hashSet.Add(item38.UpperArm.飛膜);
    			hashSet.Add(item38.手.飛膜);
    		}
    		foreach (Element item39 in 腕左)
    		{
    			if (hashSet.Contains(item39) || (item39 is DrawableElement && ((DrawableElement)item39).Par is 手_蝙))
    			{
    				肩左飛膜.Add(item39);
    			}
    			else if (LowerArm以降左.Contains(item39.Par) || item39 is 大顎上 || item39 is 触肢_肢蠍)
    			{
    				LowerArm以降左.Add(item39);
    			}
    		}
    		foreach (Element item40 in LowerArm以降左)
    		{
    			腕左.Remove(item40);
    		}
    		foreach (Element item41 in 肩左飛膜)
    		{
    			腕左.Remove(item41);
    		}
    		ele5 = 腕右.LastOrDefault((Element e) => e.Par != null && e.Par.Par != null && e.Par.Par.ConnectionType == ConnectionInfo.Chest_肩右_接続);
    		if (ele5 != null)
    		{
    			LowerArm以降右.Add(ele5);
    		}
    		hashSet.Clear();
    		foreach (蝙通常 item42 in 蝙通常.Where((蝙通常 e) => e.UpperArm.Par != null && e.UpperArm.Par.ConnectionType == ConnectionInfo.Chest_肩右_接続))
    		{
    			hashSet.Add(item42.UpperArm.飛膜);
    			hashSet.Add(item42.手.飛膜);
    		}
    		foreach (Element item43 in 腕右)
    		{
    			if (hashSet.Contains(item43) || (item43 is DrawableElement && ((DrawableElement)item43).Par is 手_蝙))
    			{
    				肩右飛膜.Add(item43);
    			}
    			else if (LowerArm以降右.Contains(item43.Par) || item43 is 大顎上 || item43 is 触肢_肢蠍)
    			{
    				LowerArm以降右.Add(item43);
    			}
    		}
    		foreach (Element item44 in LowerArm以降右)
    		{
    			腕右.Remove(item44);
    		}
    		foreach (Element item45 in 肩右飛膜)
    		{
    			腕右.Remove(item45);
    		}
    		飛膜_根[] array2 = 腕左.GetEles<飛膜_根>().ToArray();
    		foreach (飛膜_根 item13 in array2)
    		{
    			肩左飛膜.Add(item13);
    			腕左.Remove(item13);
    		}
    		array2 = 腕右.GetEles<飛膜_根>().ToArray();
    		foreach (飛膜_根 item14 in array2)
    		{
    			肩右飛膜.Add(item14);
    			腕右.Remove(item14);
    		}
    		foreach (Element item46 in 腰後左接続.Where((Element e) => e.ConnectionType == ConnectionInfo.四足脇_UpperArm_接続 || bod.半身前接続.Contains(e.Par)))
    		{
    			半身前接続.Add(item46);
    		}
    		foreach (Element item47 in 腰後右接続.Where((Element e) => e.ConnectionType == ConnectionInfo.四足脇_UpperArm_接続 || bod.半身前接続.Contains(e.Par)))
    		{
    			半身前接続.Add(item47);
    		}
    		foreach (Element item48 in 半身前接続)
    		{
    			腰後左接続.Remove(item48);
    			腰後右接続.Remove(item48);
    		}
    		獣LowerArm LowerArm左l = ((腕獣左.Count > 0) ? 腕獣左[0].LowerArm : null);
    		獣LowerArm LowerArm右l = ((腕獣右.Count > 0) ? 腕獣右[0].LowerArm : null);
    		if (!Is蠍 && !Is蜘)
    		{
    			Element[] array = 半身前接続.Where((Element e) => (e is LowerArm && LowerArm左l != e && LowerArm右l != e) || e is UpperArm || e is 触肢 || (e.ConnectionType == ConnectionInfo.四足脇_UpperArm_接続 && e is Leg)).ToArray();
    			foreach (Element item15 in array)
    			{
    				半身前接続.Remove(item15);
    				半身中2接続.Add(item15);
    			}
    		}
    		if (Waist.腿左_接続 != null)
    		{
    			IEnumerable<触手_犬> eles = Waist.腿左_接続.GetEles<触手_犬>();
    			foreach (触手_犬 item49 in eles.Take(eles.Count() - 1))
    			{
    				item49.Torso_節1_Torso_表示 = false;
    				item49.Torso_節1_鱗1_表示 = false;
    				item49.Torso_節1_鱗2_表示 = false;
    				item49.Torso_節1_鱗3_表示 = false;
    			}
    		}
    		if (Waist.腿右_接続 != null)
    		{
    			IEnumerable<触手_犬> eles2 = Waist.腿右_接続.GetEles<触手_犬>();
    			foreach (触手_犬 item50 in eles2.Take(eles2.Count() - 1))
    			{
    				item50.Torso_節1_Torso_表示 = false;
    				item50.Torso_節1_鱗1_表示 = false;
    				item50.Torso_節1_鱗2_表示 = false;
    				item50.Torso_節1_鱗3_表示 = false;
    			}
    		}
    		四足脇[] array3 = 腰後右接続.GetEles<四足脇>().ToArray();
    		foreach (四足脇 item16 in array3)
    		{
    			腰後右接続.Remove(item16);
    			半身後接続.Insert(0, item16);
    		}
    		array3 = 腰後左接続.GetEles<四足脇>().ToArray();
    		foreach (四足脇 item17 in array3)
    		{
    			腰後左接続.Remove(item17);
    			半身後接続.Insert(0, item17);
    		}
    		if (Cha.CharacterData.固有値 > 0.5)
    		{
    			大顎 ele6 = 大顎基接続.GetEle<大顎>();
    			if (ele6 != null)
    			{
    				int num2 = 大顎基接続.IndexOf(ele6);
    				大顎基接続.Remove(ele6);
    				大顎基接続.Insert(num2 + 1, ele6);
    			}
    		}
    		耳左 = 頭.耳左_接続.GetEle<耳>();
    		耳右 = 頭.耳右_接続.GetEle<耳>();
    		IEnumerable<Element> src = 顔触覚左接続.Concat(触覚左接続);
    		IEnumerable<Element> src2 = 顔触覚右接続.Concat(触覚右接続);
    		触覚甲左 = src.GetEle<触覚_甲>();
    		触覚甲右 = src2.GetEle<触覚_甲>();
    		if (触覚甲左 == null)
    		{
    			触覚左 = src.GetEle<触覚>();
    			触覚右 = src2.GetEle<触覚>();
    		}
    		頭色更新 = new 頭色更新(頭, 単眼瞼, Is瞼宇 ? null : 瞼左, Is瞼宇 ? null : 瞼右, 額瞼, 頬瞼左, 頬瞼右);
    		ドレス色更新 = new ドレス色更新(上着T_ドレス, 上着M_ドレス);
    		鯨色更新 = from e in Elements
    			where e.Par != null && e.Par is 長物_鯨 && e is 尾_鯨
    			select new 鯨色更新((長物_鯨)e.Par, (尾_鯨)e);
    		飛膜色更新 = 蝙通常.Select((蝙通常 e) => new 飛膜色更新(e.UpperArm.飛膜, e.手.飛膜));
    		色更新 = Elements.Where((Element e) => !bod.頭色更新.Contains(e) && !bod.ドレス色更新.Contains(e) && !bod.鯨色更新.Any((鯨色更新 f) => f.Contains(e)));
    		Is双眉 = 眉左 != null;
    		Is単眉 = 単眼眉 != null;
    		Is人耳 = 耳左 != null;
    		Is獣耳 = 獣耳左 != null;
    		Is虫角 = 額接続.IsEle<角1_虫>();
    		Is虫角前 = Is虫角 && (顔面 is 顔面_甲 || 顔面 is 顔面_虫);
    		顔面_甲 顔面_甲2 = null;
    		if (頭.顔面_接続 != null)
    		{
    			顔面_甲2 = 頭.顔面_接続.GetEle<顔面_甲>();
    		}
    		if (顔面_甲2 != null)
    		{
    			顔面_甲2.面額_表示 = Is虫角前 || 額接続.Count == 0;
    		}
    		Is鬼角 = 角左接続.IsEle<角2_鬼>();
    		Is貧乳 = 乳房左.バスト <= 0.2;
    		Is海洋 = Is魚 || Is鯨;
    		Is長物 = Is蛇 || Is蟲;
    		Is多足 = Is蜘 || Is蠍;
    		Is半身 = Is獣 || Is海洋 || Is長物 || Is多足 || Is蛸 || Is植 || Is粘;
    		Is顔面 = 顔面 != null;
    		Is頭頂 = 頭頂 != null;
    		Is大顎基 = 大顎基接続.IsEle<大顎基>();
    		Is額角 = 額接続.IsEle<角1>();
    		Is触覚他 = 触覚左 != null;
    		Is触覚甲 = 触覚甲左 != null;
    		Is触覚 = Is触覚他 || Is触覚甲;
    		IsDualEyes = 目左 != null;
    		IsSingleEye = 単眼目 != null;
    		IsCheekEyes = 頬目左 != null;
    		IsForeheadEye = 額目 != null;
    		Is舌股 = Tounge is Tounge_長 && ((Tounge_長)Tounge).舌股右_Tounge1_表示;
    		Is最前腕人 = 肩左 != null && 肩左.UpperArm_接続.IsEle<UpperArm_人>();
    		Is最前手人 = 肩左 != null && 肩左.EnumEle().IsEle<手_人>();
    		Is腕人 = LowerArm以降左.IsEle<LowerArm_人>();
    		Is腕鳥 = LowerArm以降左.IsEle<LowerArm_鳥>();
    		Is腕蝙 = LowerArm以降左.IsEle<LowerArm_蝙>();
    		Is腕獣 = LowerArm以降左.IsEle<LowerArm_獣>();
    		Is腕蠍 = LowerArm以降左.IsEle<触肢_肢蠍>();
    		Is腿人 = Waist.腿左_接続.IsEle<腿_人>();
    		Is腿獣 = Waist.腿左_接続.IsEle<獣腿>();
    		Is腿魚 = Waist.腿左_接続.IsEle<尾_魚>();
    		Is腿犬 = Waist.腿左_接続.IsEle<触手_犬>();
    		紅潮.紅潮線左右表示 = false;
    		Tounge_表示 = false;
    		if (Is頭頂_宇)
    		{
    			foreach (Element item51 in 顔触覚左接続)
    			{
    				item51.接続(頭.触覚左_接続点);
    			}
    			foreach (Element item52 in 顔触覚右接続)
    			{
    				item52.接続(頭.触覚右_接続点);
    			}
    			耳左接続.SetEles(delegate(耳 e)
    			{
    				e.Yi = 1;
    			});
    			耳右接続.SetEles(delegate(耳 e)
    			{
    				e.Yi = 1;
    			});
    		}
    		if (IsSingleEye)
    		{
    			頭.X0Y0_Head.GetJP()[7] = new JointPoint(頭.X0Y0_Head.GetJP()[7].Joint.MulY(0.96));
    			頭.X0Y0_Head.GetJP()[17] = new JointPoint(頭.X0Y0_Head.GetJP()[17].Joint.MulY(0.96));
    			頭.X0Y0_Head.GetJP()[18] = new JointPoint(頭.X0Y0_Head.GetJP()[18].Joint.MulY(0.96));
    			紅潮.紅潮1_表示 = false;
    			紅潮.X0Y0_紅潮左.SetAngleBase(20.0);
    			紅潮.X0Y0_紅潮弱左.SetAngleBase(20.0);
    			紅潮.X0Y0_紅潮線左.SetAngleBase(20.0);
    			紅潮.X0Y0_紅潮右.SetAngleBase(-20.0);
    			紅潮.X0Y0_紅潮弱右.SetAngleBase(-20.0);
    			紅潮.X0Y0_紅潮線右.SetAngleBase(-20.0);
    		}
    		染み_人 = new 染み_人(disUnit, 配色指定.N0, Cha.ColorSet, Med, new 染み_人D());
    		染み_人.サイズ = Elements.Sum((Element e) => e.サイズ) / (double)Elements.Length;
    		染み_人.Intensity = 0.0;
    		Vector2D positionCont = DataConsts.Vec2DUnitY * -0.03;
    		Vector2D positionCont2 = DataConsts.Vec2DUnitY * 0.03;
    		染み_人.X0Y0_汗.SetPositionCont(positionCont);
    		染み_人.X0Y0_潮1.SetPositionCont(positionCont2);
    		if (Is獣)
    		{
    			InternalSemen_獣.Intensity = 0.0;
    			XRay_獣.精液CD.不透明度 = 0.0;
    			VaginaOrigin = VaginaOrigin_獣;
    			VaginalCumDrip = InternalSemen_獣;
    			XRay = XRay_獣;
    			性器 = 性器_獣;
    			GenetalCum = 性器精液_獣;
    			Splash = 飛沫_獣;
    			潮吹_小 = 潮吹_小_獣;
    			潮吹_大 = 潮吹_大_獣;
    			Urination = 放尿_獣;
    			Anus = Anus_獣;
    			AnalCum = 肛門精液_獣;
    			InternalSemen_獣.精液配色(GlobalState.GameData.配色);
    			InternalSemen_獣.精液濃度 = 0.0;
    			XRay_獣.精液配色(GlobalState.GameData.配色);
    			XRay_獣.精液濃度 = 0.0;
    			性器精液_獣.精液配色(GlobalState.GameData.配色);
    			肛門精液_獣.精液配色(GlobalState.GameData.配色);
    			染み_獣 = new 染み_獣(disUnit, 配色指定.N0, Cha.ColorSet, Med, new 染み_獣D());
    			染み_獣.サイズ = Elements.Sum((Element e) => e.サイズ) / (double)Elements.Length;
    			染み_獣.Intensity = 0.0;
    			if (Chest_獣.脇左_接続.IsEle<四足脇>())
    			{
    				Chest_獣.X0Y0_RibCage.GetOP()[0].Outline = false;
    				Chest_獣.X0Y0_RibCage.GetOP()[9].Outline = false;
    			}
    			Vector2D positionCont3 = new Vector2D(0.0, 0.006);
    			染み_獣.X0Y0_湯気_湯気左1_湯気2.SetPositionCont(positionCont3);
    			染み_獣.X0Y0_湯気_湯気左2_湯気2.SetPositionCont(positionCont3);
    			染み_獣.X0Y0_湯気_湯気左3_湯気2.SetPositionCont(positionCont3);
    			染み_獣.X0Y0_湯気_湯気右1_湯気2.SetPositionCont(positionCont3);
    			染み_獣.X0Y0_湯気_湯気右2_湯気2.SetPositionCont(positionCont3);
    			染み_獣.X0Y0_湯気_湯気右3_湯気2.SetPositionCont(positionCont3);
    			下着陰核.X0Y0_陰核.SetSizeBase(性器_獣.X0Y0_陰核.GetSizeBase());
    			csb = 性器_獣.X0Y0_陰核.GetSizeBase();
    			asb1 = Anus_獣.X0Y0_Anus2.GetSizeBase();
    			asb2 = Anus_獣.X0Y0_Anus3.GetSizeBase();
    			染み_獣.X0Y0_汗.SetPositionCont(positionCont);
    			染み_獣.X0Y0_潮1.SetPositionCont(positionCont2);
    		}
    		else
    		{
    			InternalSemen_人.Intensity = 0.0;
    			XRay_人.精液CD.不透明度 = 0.0;
    			VaginaOrigin = VaginaOrigin_人;
    			VaginalCumDrip = InternalSemen_人;
    			XRay = XRay_人;
    			性器 = 性器_人;
    			GenetalCum = 性器精液_人;
    			Splash = 飛沫_人;
    			潮吹_小 = 潮吹_小_人;
    			潮吹_大 = 潮吹_大_人;
    			Urination = 放尿_人;
    			Anus = Anus_人;
    			AnalCum = 肛門精液_人;
    			InternalSemen_人.精液配色(GlobalState.GameData.配色);
    			InternalSemen_人.精液濃度 = 0.0;
    			XRay_人.精液配色(GlobalState.GameData.配色);
    			XRay_人.精液濃度 = 0.0;
    			性器精液_人.精液配色(GlobalState.GameData.配色);
    			肛門精液_人.精液配色(GlobalState.GameData.配色);
    			Vector2D positionCont4 = new Vector2D(0.0, 0.006);
    			染み_人.X0Y0_湯気_湯気左1_湯気2.SetPositionCont(positionCont4);
    			染み_人.X0Y0_湯気_湯気左2_湯気2.SetPositionCont(positionCont4);
    			染み_人.X0Y0_湯気_湯気左3_湯気2.SetPositionCont(positionCont4);
    			染み_人.X0Y0_湯気_湯気右1_湯気2.SetPositionCont(positionCont4);
    			染み_人.X0Y0_湯気_湯気右2_湯気2.SetPositionCont(positionCont4);
    			染み_人.X0Y0_湯気_湯気右3_湯気2.SetPositionCont(positionCont4);
    			下着陰核.X0Y0_陰核.SetSizeBase(性器_人.X0Y0_陰核.GetSizeBase());
    			csb = 性器_人.X0Y0_陰核.GetSizeBase();
    			asb1 = Anus_人.X0Y0_Anus2.GetSizeBase();
    			asb2 = Anus_人.X0Y0_Anus3.GetSizeBase();
    			PregnantBelly_人.X0Y0_ハイライト.Dra = false;
    			PregnantBelly_人.X0Y0_ハイライト左1.Dra = false;
    			PregnantBelly_人.X0Y0_ハイライト左2.Dra = false;
    			PregnantBelly_人.X0Y0_ハイライト右1.Dra = false;
    			PregnantBelly_人.X0Y0_ハイライト右2.Dra = false;
    			PregnantBelly_人.X0Y1_ハイライト.Dra = false;
    			PregnantBelly_人.X0Y1_ハイライト左1.Dra = false;
    			PregnantBelly_人.X0Y1_ハイライト左2.Dra = false;
    			PregnantBelly_人.X0Y1_ハイライト右1.Dra = false;
    			PregnantBelly_人.X0Y1_ハイライト右2.Dra = false;
    		}
    		Anusy = Anus.尺度YB;
    		Anusv = Anus.尺度B;
    		口i = 0;
    		MouthCum.精液配色(GlobalState.GameData.配色);
    		頬濃度 = 0.3;
    		下着B_ノーマル.染み濃度 = 0.0;
    		下着B_マイクロ.染み濃度 = 0.0;
    		蜘尾 = Elements.GetEle<尾_蜘>();
    		if (Is蜘尾 = 蜘尾 != null)
    		{
    			ThreadCum = new 性器精液_人(disUnit, 配色指定.N0, Cha.ColorSet, Med, new 性器精液_人D());
    			ThreadCum.精液配色(GlobalState.GameData.配色);
    			ThreadCum.接続(蜘尾.出糸_接続点);
    		}
    		頬濃度 = 0.0;
    		汗染み濃度 = 0.0;
    		UrineStainIntensity = 0.0;
    		SplashIntencity = 0.0;
    		SquirtStainIntensity = 0.0;
    		湯気左濃度 = 0.0;
    		湯気右濃度 = 0.0;
    		下着B染み = 0.0;
    		下着T染み = 0.0;
    		上着B染み = 0.0;
    		陰核勃起 = 0.0;
    		乳首勃起 = 0.0;
    		顔紅潮 = 0.0;
    		体紅潮 = 0.0;
    		子宮下がり = 0.0;
    		肛門開き = 0.0;
    		AnusC = 1.0;
    		膣腔C = 1.0;
    		XRay_表示 = false;
    		if (Is粘 && Waist.腿左_接続 != null)
    		{
    			foreach (ShapePart item53 in (from e in Waist.腿左_接続.GetEles<腿>()
    				select e.Body.EnumAllPar()).Aggregate((IEnumerable<ShapePart> e1, IEnumerable<ShapePart> e2) => e1.Concat(e2)))
    			{
    				item53.GetOP().OutlineFalse();
    			}
    			foreach (ShapePart item54 in (from e in Waist.腿右_接続.GetEles<腿>()
    				select e.Body.EnumAllPar()).Aggregate((IEnumerable<ShapePart> e1, IEnumerable<ShapePart> e2) => e1.Concat(e2)))
    			{
    				item54.GetOP().OutlineFalse();
    			}
    		}
    		Elements.SetEle(delegate(Torso_蛇 e)
    		{
    			e.X0Y0_Torso_Torso.GetOP()[1].ps[3] = e.X0Y0_Torso_Torso.GetOP()[1].ps[3].AddY(0.04);
    			if (e.Torso_接続 != null)
    			{
    				e.Torso_接続.SetEle(delegate(Torso_蛇 f)
    				{
    					f.X0Y0_Torso_Torso.GetOP()[1].ps[3] = f.X0Y0_Torso_Torso.GetOP()[1].ps[3].AddY(0.04);
    				});
    			}
    		});
    		if (Is粘)
    		{
    			腿開きi = 1;
    			XRay_表示 = true;
    		}
    		下着乳首左.X0Y0_乳首.SetSizeBase(乳房左.X0Y0_乳首.GetSizeBase() * 1.1);
    		下着乳首右.X0Y0_乳首.SetSizeBase(乳房右.X0Y0_乳首.GetSizeBase() * 1.1);
    		if (Chest.肩左_接続 == null)
    		{
    			胸肌_人.淫タトゥ_タトゥ左_表示 = false;
    			胸肌_人.淫タトゥ_タトゥ右_表示 = false;
    		}
    		if (WaistSkin_人.竜性_鱗1_表示 || WaistSkin_人.竜性_鱗2_表示 || WaistSkin_人.竜性_鱗3_表示 || WaistSkin_人.竜性_鱗4_表示)
    		{
    			WaistSkin_人.陰毛_ハート_表示 = false;
    		}
    		尾_魚 ele7 = Waist.腿左_接続.GetEle<尾_魚>();
    		if (ele7 != null)
    		{
    			Waist.WaistCD.c2.Col2 = ele7.尾0_尾CD.c2.Col1;
    		}
    		nsb1 = 乳房左.X0Y0_乳首.GetSizeBase();
    		nsb2 = 乳房左.X0Y0_乳輪.GetSizeBase();
    		変動ステート更新();
    		Waist.位置B = Med.Base.GetPosition(new Vector2D(0.5, 0.5));
    		Join();
    		SetWaist();
    		if (背中接続.Count + 頭頂左後接続.Count + 頭頂右後接続.Count + 胸上左接続.Count + 胸上右接続.Count + 胸下左接続.Count + 胸下右接続.Count + 胴後左接続.Count + 胴後右接続.Count + 後腕左s.Length + 後腕右s.Length > 0)
    		{
    			EIChest = new ElementInstance(Med);
    			EIChest.AddRange(背中接続);
    			EIChest.AddRange(頭頂左後接続);
    			EIChest.AddRange(頭頂右後接続);
    			EIChest.AddRange(胸上左接続);
    			EIChest.AddRange(胸上右接続);
    			EIChest.AddRange(胸下左接続);
    			EIChest.AddRange(胸下右接続);
    			EIChest.AddRange(胴後左接続);
    			EIChest.AddRange(胴後右接続);
    			List<Element>[] array4 = 後腕左s;
    			foreach (List<Element> es in array4)
    			{
    				EIChest.AddRange(es);
    			}
    			array4 = 後腕右s;
    			foreach (List<Element> es2 in array4)
    			{
    				EIChest.AddRange(es2);
    			}
    			EIChest.描画処理 = delegate(RenderArea are)
    			{
    				bod.背中接続.描画0(are);
    				bod.背中接続.描画1(are);
    				bod.胸上左接続.描画0(are);
    				bod.胸上左接続.描画1(are);
    				bod.胸上右接続.描画0(are);
    				bod.胸上右接続.描画1(are);
    				bod.胸下左接続.描画0(are);
    				bod.胸下左接続.描画1(are);
    				bod.胸下右接続.描画0(are);
    				bod.胸下右接続.描画1(are);
    				bod.胴後左接続.描画0(are);
    				bod.胴後左接続.描画1(are);
    				bod.胴後右接続.描画0(are);
    				bod.胴後右接続.描画1(are);
    				bod.頭頂左後接続.描画0(are);
    				bod.頭頂左後接続.描画1(are);
    				bod.頭頂右後接続.描画0(are);
    				bod.頭頂右後接続.描画1(are);
    				Shoulder[] array5 = bod.後脇左s;
    				for (int n = 0; n < array5.Length; n++)
    				{
    					array5[n].脇描画(are);
    				}
    				array5 = bod.後脇右s;
    				for (int n = 0; n < array5.Length; n++)
    				{
    					array5[n].脇描画(are);
    				}
    				List<Element>[] array6 = bod.後腕左s;
    				foreach (List<Element> es3 in array6)
    				{
    					es3.描画0(are);
    					es3.描画1(are);
    				}
    				array6 = bod.後腕右s;
    				foreach (List<Element> es4 in array6)
    				{
    					es4.描画0(are);
    					es4.描画1(are);
    				}
    			};
    			EIChest.Update();
    			eis.Add(EIChest);
    		}
    		if (後髪接続.Count > 0)
    		{
    			EI髪 = new ElementInstance(Med);
    			EI髪.AddRange(後髪接続);
    			EI髪.描画処理 = delegate(RenderArea are)
    			{
    				bod.後髪接続.描画0(are);
    				bod.後髪接続.描画1(are);
    			};
    			EI髪.Update();
    			eis.Add(EI髪);
    		}
    		if (腰後左接続.Count + 腰後右接続.Count > 0)
    		{
    			EIWaist = new ElementInstance(Med);
    			EIWaist.AddRange(腰後左接続);
    			EIWaist.AddRange(腰後右接続);
    			EIWaist.描画処理 = delegate(RenderArea are)
    			{
    				bod.腰後左接続.描画0(are);
    				bod.腰後左接続.描画1(are);
    				bod.腰後右接続.描画0(are);
    				bod.腰後右接続.描画1(are);
    			};
    			EIWaist.Update();
    			eis.Add(EIWaist);
    		}
    		if (尾接続.Count + 半身後接続.Count > 0)
    		{
    			EI半後 = new ElementInstance(Med);
    			EI半後.AddRange(尾接続);
    			EI半後.AddRange(半身後接続);
    			EI半後.描画処理 = delegate(RenderArea are)
    			{
    				bod.尾接続.描画0(are);
    				bod.尾接続.描画1(are);
    				bod.半身後接続.描画0(are);
    				bod.半身後接続.描画1(are);
    			};
    			EI半後.Update();
    			eis.Add(EI半後);
    		}
    		if (半身中1接続.Count > 0)
    		{
    			EI半中1 = new ElementInstance(Med);
    			EI半中1.AddRange(半身中1接続);
    			EI半中1.描画処理 = delegate(RenderArea are)
    			{
    				bod.半身中1接続.描画0(are);
    				bod.半身中1接続.描画1(are);
    			};
    			EI半中1.Update();
    			eis.Add(EI半中1);
    		}
    		if (半身中2接続.Count > 0)
    		{
    			EI半中2 = new ElementInstance(Med);
    			EI半中2.AddRange(半身中2接続);
    			EI半中2.描画処理 = delegate(RenderArea are)
    			{
    				bod.半身中2接続.描画0(are);
    				bod.半身中2接続.描画1(are);
    			};
    			EI半中2.Update();
    			eis.Add(EI半中2);
    		}
    		if (半身前接続.Count > 0)
    		{
    			EI半前 = new ElementInstance(Med);
    			EI半前.AddRange(半身前接続);
    			EI半前.描画処理 = delegate(RenderArea are)
    			{
    				bod.半身前接続.描画0(are);
    				bod.半身前接続.描画1(are);
    			};
    			EI半前.Update();
    			eis.Add(EI半前);
    		}
    		if (LowerArm以降左.Count + LowerArm以降右.Count > 0)
    		{
    			EI腕前 = new ElementInstance(Med);
    			EI腕前.AddRange(LowerArm以降左);
    			EI腕前.AddRange(LowerArm以降右);
    			EI腕前.描画処理 = delegate(RenderArea are)
    			{
    				if (bod.腕左右前後)
    				{
    					if (!bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    					if (!bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    				}
    				else
    				{
    					if (!bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    					if (!bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    				}
    			};
    			EI腕前.Update();
    			eis.Add(EI腕前);
    		}
    		if (腿左接続.Count + 腿右接続.Count > 0)
    		{
    			EI腿 = new ElementInstance(Med);
    			EI腿.AddRange(腿左接続);
    			EI腿.AddRange(腿右接続);
    			EI腿.描画処理 = delegate(RenderArea are)
    			{
    				if (bod.腿左右前後)
    				{
    					bod.腿右接続.描画0(are);
    					bod.腿右接続.描画1(are);
    					bod.腿左接続.描画0(are);
    					bod.腿左接続.描画1(are);
    				}
    				else
    				{
    					bod.腿左接続.描画0(are);
    					bod.腿左接続.描画1(are);
    					bod.腿右接続.描画0(are);
    					bod.腿右接続.描画1(are);
    				}
    			};
    			EI腿.Update();
    			eis.Add(EI腿);
    		}
    		Is髪 = EI髪 != null;
    		IsChest = EIChest != null;
    		IsWaist = EIWaist != null;
    		Is腕前 = EI腕前 != null;
    		Is半後 = EI半後 != null;
    		Is半中1 = EI半中1 != null;
    		Is半中2 = EI半中2 != null;
    		Is半前 = EI半前 != null;
    		Is腿 = EI腿 != null;
    		Update();
    		if (Is海洋)
    		{
    			Draw = delegate(RenderArea are)
    			{
    				bod.染み_人.色更新();
    				bod.染み_人.描画0(are);
    				if (bod.IsChest)
    				{
    					bod.EIChest.描画(are);
    				}
    				if (bod.IsWaist)
    				{
    					bod.EIWaist.描画(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.頭頂後.描画0(are);
    				}
    				if (bod.Is髪)
    				{
    					bod.EI髪.描画(are);
    				}
    				if (bod.Is獣耳)
    				{
    					foreach (角2 item55 in bod.角左接続)
    					{
    						item55.根描画(are);
    					}
    					foreach (角2 item56 in bod.角右接続)
    					{
    						item56.根描画(are);
    					}
    				}
    				bod.肩左飛膜.描画0(are);
    				bod.肩右飛膜.描画0(are);
    				if (bod.腕左右前後)
    				{
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    				}
    				else
    				{
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    				}
    				bod.上着B_クロス後.描画0(are);
    				if (bod.Is半後)
    				{
    					bod.EI半後.描画(are);
    				}
    				if (bod.Is蜘尾)
    				{
    					bod.ThreadCum.描画0(are);
    				}
    				if (bod.cb0)
    				{
    					if (bod.カーソル.IsSub糸挿入)
    					{
    						bod.カーソル.描画糸(Are);
    					}
    					else if (bod.カーソル.Is糸挿入)
    					{
    						bod.カーソル.描画2(Are);
    					}
    				}
    				bod.耳左接続.描画0(are);
    				bod.耳右接続.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.脇描画(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.脇描画(are);
    				}
    				bod.Waist.描画0(are);
    				bod.Waist.描画1(are);
    				bod.Torso.描画0(are);
    				bod.Chest.描画0(are);
    				bod.Neck.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.描画0(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.描画0(are);
    				}
    				if (bod.Is半中1)
    				{
    					bod.EI半中1.描画(are);
    				}
    				bod.PregnantBelly_人.描画0(are);
    				bod.PregnantBellyPlate_人.描画0(are);
    				bod.WaistSkin_人.描画0(are);
    				bod.TorsoPlate_人.描画0(are);
    				bod.胸腹板_人.描画0(are);
    				bod.TorsoSkin_人.描画0(are);
    				bod.胸肌_人.描画0(are);
    				bod.下着T_チューブ.描画0(are);
    				bod.下着T_クロス.描画0(are);
    				bod.下着T_ビキニ.描画0(are);
    				bod.下着T_マイクロ.描画0(are);
    				bod.下着T_ブラ.描画0(are);
    				bod.腕左.描画0(are);
    				bod.腕右.描画0(are);
    				bod.腕左.描画1(are);
    				bod.腕右.描画1(are);
    				if (bod.胸左右前後)
    				{
    					bod.乳房右.描画0(are);
    					bod.乳房左.描画0(are);
    				}
    				else
    				{
    					bod.乳房左.描画0(are);
    					bod.乳房右.描画0(are);
    				}
    				bod.ピアス左.描画0(are);
    				bod.ピアス右.描画0(are);
    				bod.LeftMilkSpray.描画0(are);
    				bod.RightMilkSpary.描画0(are);
    				bod.キャップ2左.描画0(are);
    				bod.キャップ2右.描画0(are);
    				bod.胸肌_人.描画1(are);
    				if (bod.汗掻き != null)
    				{
    					bod.汗掻き.Draw(are);
    				}
    				bod.頭.描画0(are);
    				if (bod.IsDualEyes && !bod.Is瞼宇)
    				{
    					bod.目左.描画0(are);
    					bod.瞼左.描画0(are);
    					bod.目右.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.頭.描画1(are);
    				if (bod.IsSingleEye)
    				{
    					bod.単眼目.描画0(are);
    					bod.単眼瞼.描画0(are);
    				}
    				bod.紅潮.描画0(are);
    				bod.鼻肌.描画0(are);
    				bod.目尻影左.描画0(are);
    				bod.目尻影右.描画0(are);
    				bod.目傷左.描画0(are);
    				bod.目傷右.描画0(are);
    				bod.頬肌左.描画0(are);
    				bod.頬肌右.描画0(are);
    				if (bod.IsForeheadEye)
    				{
    					bod.額目.描画0(are);
    					bod.額瞼.描画0(are);
    				}
    				if (bod.IsCheekEyes)
    				{
    					bod.頬目左.描画0(are);
    					bod.頬目右.描画0(are);
    					bod.頬瞼左.描画0(are);
    					bod.頬瞼右.描画0(are);
    				}
    				if (bod.Is瞼宇)
    				{
    					bod.瞼左.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.LeftDrool.描画0(are);
    				bod.RightDrool.描画0(are);
    				bod.口.描画0(are);
    				if (bod.鼻描画)
    				{
    					bod.鼻.描画0(are);
    					bod.LeftNoseDrip.描画0(are);
    					bod.RightNoseDrip.描画0(are);
    				}
    				bod.頭.描画2(are);
    				bod.玉口枷.描画0(are);
    				bod.BaseHair.描画0(are);
    				bod.横髪左.描画0(are);
    				bod.横髪右.描画0(are);
    				bod.頬左接続.描画0(are);
    				bod.頬左接続.描画1(are);
    				bod.頬右接続.描画0(are);
    				bod.頬右接続.描画1(are);
    				bod.頬肌左.描画1(are);
    				bod.頬肌右.描画1(are);
    				if (bod.涙描画)
    				{
    					bod.LeftTear.描画0(are);
    					bod.RightTear.描画0(are);
    				}
    				if (!bod.Is頭頂_宇 && !bod.Is顔面 && !bod.Is額角 && !bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				if (bod.Is腕前 && !bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				if (bod.Is半中2)
    				{
    					bod.EI半中2.描画(are);
    				}
    				bod.Anus_人.描画0(are);
    				bod.肛門精液_人.描画0(are);
    				if (bod.cb1)
    				{
    					bod.カーソル.描画肛(are);
    				}
    				bod.VaginaOrigin_人.描画0(are);
    				if (bod.XRay_表示 && bod.cb1)
    				{
    					bod.カーソル.描画0(are);
    				}
    				bod.InternalSemen_人.描画0(are);
    				bod.XRay_人.描画0(are);
    				bod.性器_人.描画0(are);
    				if (!bod.XRay_表示 && bod.cb1)
    				{
    					bod.カーソル.描画0(are);
    				}
    				bod.ピアス.描画0(are);
    				bod.下着T_チューブ.描画1(are);
    				bod.下着T_クロス.描画1(are);
    				bod.下着T_ビキニ.描画1(are);
    				bod.下着T_マイクロ.描画1(are);
    				bod.下着T_ブラ.描画1(are);
    				bod.下着乳首左.描画0(are);
    				bod.下着乳首右.描画0(are);
    				bod.キャップ1.描画0(are);
    				bod.上着M_ドレス.描画0(are);
    				bod.上着T_ドレス.描画0(are);
    				bod.上着B_前掛け.描画0(are);
    				bod.上着B_クロス.描画0(are);
    				if (bod.胸毛_人 != null)
    				{
    					bod.胸毛_人.描画0(are);
    				}
    				bod.Tounge.描画0(are);
    				bod.MouthCum.描画0(are);
    				bod.咳.描画0(are);
    				bod.呼気.描画0(are);
    				if (bod.cb0 && bod.カーソル.コキ)
    				{
    					bod.カーソル.描画0(are);
    					bod.カーソル.描画1(are);
    				}
    				bod.前髪.描画0(are);
    				if (!bod.Is獣耳)
    				{
    					foreach (角2 item57 in bod.角左接続)
    					{
    						item57.根描画(are);
    					}
    					foreach (角2 item58 in bod.角右接続)
    					{
    						item58.根描画(are);
    					}
    				}
    				if (bod.Is単眉)
    				{
    					bod.単眼眉.描画0(are);
    				}
    				if (bod.Is双眉)
    				{
    					bod.眉左.描画0(are);
    					bod.眉右.描画0(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.大顎基接続.描画0(are);
    					bod.大顎基接続.描画1(are);
    					if (bod.Is顔面)
    					{
    						bod.顔面.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item59 in bod.角左接続)
    					{
    						item59.先描画(are);
    					}
    					foreach (角2 item60 in bod.角右接続)
    					{
    						item60.先描画(are);
    					}
    					bod.額接続.描画0(are);
    					bod.額接続.描画1(are);
    					bod.触覚左接続.描画0(are);
    					bod.触覚左接続.描画1(are);
    					bod.触覚右接続.描画0(are);
    					bod.触覚右接続.描画1(are);
    				}
    				else
    				{
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item61 in bod.角左接続)
    					{
    						item61.先描画(are);
    					}
    					foreach (角2 item62 in bod.角右接続)
    					{
    						item62.先描画(are);
    					}
    					if (bod.Is虫角前)
    					{
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    					}
    					else
    					{
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    					}
    				}
    				bod.顔触覚左接続.描画0(are);
    				bod.顔触覚左接続.描画1(are);
    				bod.顔触覚右接続.描画0(are);
    				bod.顔触覚右接続.描画1(are);
    				if (bod.Is頭頂_宇 || bod.Is顔面 || bod.Is額角 || bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				if (bod.cb0 && !(bod.fi = bod.カーソル.Isフォーカス膣肛挿入))
    				{
    					bod.性器精液_人.描画0(are);
    					bod.飛沫_人.描画0(are);
    					bod.潮吹_小_人.描画0(are);
    					bod.潮吹_大_人.描画0(are);
    					bod.放尿_人.描画0(are);
    				}
    				if (bod.Is腕前 && bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				if (bod.Is半前)
    				{
    					bod.EI半前.描画(are);
    				}
    				bod.染み_人.湯気描画(are);
    				if (bod.cb0 && bod.カーソル.Is乳弄り)
    				{
    					bod.カーソル.描画2(Are);
    				}
    				bod.上着B_前掛け.前(are);
    				bod.ぶっかけ大.Draw(are);
    				bod.ぶっかけ小.Draw(are);
    				if (bod.cb1)
    				{
    					bod.カーソル.描画1(are);
    				}
    				if (bod.cb0 && bod.fi)
    				{
    					bod.性器精液_人.描画0(are);
    					bod.飛沫_人.描画0(are);
    					bod.潮吹_小_人.描画0(are);
    					bod.潮吹_大_人.描画0(are);
    					bod.放尿_人.描画0(are);
    				}
    			};
    			return;
    		}
    		if (Is長物)
    		{
    			Draw = delegate(RenderArea are)
    			{
    				if (bod.Is蛇)
    				{
    					bod.蛇.X0Y0_Torso1_鱗右CP.Update();
    					bod.蛇.X0Y0_Torso1_鱗左CP.Update();
    					bod.蛇.X0Y0_Torso1_鱗1CP.Update();
    					bod.蛇.X0Y0_Torso1_鱗左1CP.Update();
    					bod.蛇.X0Y0_Torso1_鱗右1CP.Update();
    				}
    				bod.染み_人.色更新();
    				bod.染み_人.描画0(are);
    				if (bod.IsChest)
    				{
    					bod.EIChest.描画(are);
    				}
    				if (bod.IsWaist)
    				{
    					bod.EIWaist.描画(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.頭頂後.描画0(are);
    				}
    				if (bod.Is髪)
    				{
    					bod.EI髪.描画(are);
    				}
    				if (bod.Is獣耳)
    				{
    					foreach (角2 item63 in bod.角左接続)
    					{
    						item63.根描画(are);
    					}
    					foreach (角2 item64 in bod.角右接続)
    					{
    						item64.根描画(are);
    					}
    				}
    				bod.肩左飛膜.描画0(are);
    				bod.肩右飛膜.描画0(are);
    				if (bod.腕左右前後)
    				{
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    				}
    				else
    				{
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    				}
    				bod.上着B_クロス後.描画0(are);
    				if (bod.Is半後)
    				{
    					bod.EI半後.描画(are);
    				}
    				if (bod.Is蜘尾)
    				{
    					bod.ThreadCum.描画0(are);
    				}
    				if (bod.cb0)
    				{
    					if (bod.カーソル.IsSub糸挿入)
    					{
    						bod.カーソル.描画糸(Are);
    					}
    					else if (bod.カーソル.Is糸挿入)
    					{
    						bod.カーソル.描画2(Are);
    					}
    				}
    				bod.耳左接続.描画0(are);
    				bod.耳右接続.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.脇描画(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.脇描画(are);
    				}
    				bod.Waist.描画0(are);
    				bod.Waist.描画1(are);
    				bod.Torso.描画0(are);
    				bod.Chest.描画0(are);
    				bod.Neck.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.描画0(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.描画0(are);
    				}
    				if (bod.Is半中1)
    				{
    					bod.EI半中1.描画(are);
    				}
    				bod.PregnantBelly_人.描画0(are);
    				bod.PregnantBellyPlate_人.描画0(are);
    				bod.WaistSkin_人.描画0(are);
    				bod.TorsoPlate_人.描画0(are);
    				bod.胸腹板_人.描画0(are);
    				bod.TorsoSkin_人.描画0(are);
    				bod.胸肌_人.描画0(are);
    				bod.下着T_チューブ.描画0(are);
    				bod.下着T_クロス.描画0(are);
    				bod.下着T_ビキニ.描画0(are);
    				bod.下着T_マイクロ.描画0(are);
    				bod.下着T_ブラ.描画0(are);
    				bod.腕左.描画0(are);
    				bod.腕右.描画0(are);
    				bod.腕左.描画1(are);
    				bod.腕右.描画1(are);
    				if (bod.胸左右前後)
    				{
    					bod.乳房右.描画0(are);
    					bod.乳房左.描画0(are);
    				}
    				else
    				{
    					bod.乳房左.描画0(are);
    					bod.乳房右.描画0(are);
    				}
    				bod.ピアス左.描画0(are);
    				bod.ピアス右.描画0(are);
    				bod.LeftMilkSpray.描画0(are);
    				bod.RightMilkSpary.描画0(are);
    				bod.キャップ2左.描画0(are);
    				bod.キャップ2右.描画0(are);
    				bod.胸肌_人.描画1(are);
    				if (bod.汗掻き != null)
    				{
    					bod.汗掻き.Draw(are);
    				}
    				bod.頭.描画0(are);
    				if (bod.IsDualEyes && !bod.Is瞼宇)
    				{
    					bod.目左.描画0(are);
    					bod.瞼左.描画0(are);
    					bod.目右.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.頭.描画1(are);
    				if (bod.IsSingleEye)
    				{
    					bod.単眼目.描画0(are);
    					bod.単眼瞼.描画0(are);
    				}
    				bod.紅潮.描画0(are);
    				bod.鼻肌.描画0(are);
    				bod.目尻影左.描画0(are);
    				bod.目尻影右.描画0(are);
    				bod.目傷左.描画0(are);
    				bod.目傷右.描画0(are);
    				bod.頬肌左.描画0(are);
    				bod.頬肌右.描画0(are);
    				if (bod.IsForeheadEye)
    				{
    					bod.額目.描画0(are);
    					bod.額瞼.描画0(are);
    				}
    				if (bod.IsCheekEyes)
    				{
    					bod.頬目左.描画0(are);
    					bod.頬目右.描画0(are);
    					bod.頬瞼左.描画0(are);
    					bod.頬瞼右.描画0(are);
    				}
    				if (bod.Is瞼宇)
    				{
    					bod.瞼左.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.LeftDrool.描画0(are);
    				bod.RightDrool.描画0(are);
    				bod.口.描画0(are);
    				if (bod.鼻描画)
    				{
    					bod.鼻.描画0(are);
    					bod.LeftNoseDrip.描画0(are);
    					bod.RightNoseDrip.描画0(are);
    				}
    				bod.頭.描画2(are);
    				bod.玉口枷.描画0(are);
    				bod.BaseHair.描画0(are);
    				bod.横髪左.描画0(are);
    				bod.横髪右.描画0(are);
    				bod.頬左接続.描画0(are);
    				bod.頬左接続.描画1(are);
    				bod.頬右接続.描画0(are);
    				bod.頬右接続.描画1(are);
    				bod.頬肌左.描画1(are);
    				bod.頬肌右.描画1(are);
    				if (bod.涙描画)
    				{
    					bod.LeftTear.描画0(are);
    					bod.RightTear.描画0(are);
    				}
    				if (!bod.Is頭頂_宇 && !bod.Is顔面 && !bod.Is額角 && !bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				bod.Anus_人.描画0(are);
    				bod.肛門精液_人.描画0(are);
    				if (bod.cb1)
    				{
    					bod.カーソル.描画肛(are);
    				}
    				bod.VaginaOrigin_人.描画0(are);
    				if (bod.XRay_表示 && bod.cb1)
    				{
    					bod.カーソル.描画0(are);
    				}
    				bod.InternalSemen_人.描画0(are);
    				bod.XRay_人.描画0(are);
    				bod.性器_人.描画0(are);
    				if (!bod.XRay_表示 && bod.cb1)
    				{
    					bod.カーソル.描画0(are);
    				}
    				bod.ピアス.描画0(are);
    				if (bod.蛇前 != null)
    				{
    					bod.蛇前.描画0(are);
    				}
    				bod.下着T_チューブ.描画1(are);
    				bod.下着T_クロス.描画1(are);
    				bod.下着T_ビキニ.描画1(are);
    				bod.下着T_マイクロ.描画1(are);
    				bod.下着T_ブラ.描画1(are);
    				bod.下着乳首左.描画0(are);
    				bod.下着乳首右.描画0(are);
    				if (bod.Is腕前 && !bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				if (bod.Is半中2)
    				{
    					bod.EI半中2.描画(are);
    				}
    				bod.キャップ1.描画0(are);
    				bod.上着M_ドレス.描画0(are);
    				bod.上着T_ドレス.描画0(are);
    				bod.上着B_前掛け.描画0(are);
    				bod.上着B_クロス.描画0(are);
    				if (bod.胸毛_人 != null)
    				{
    					bod.胸毛_人.描画0(are);
    				}
    				bod.Tounge.描画0(are);
    				bod.MouthCum.描画0(are);
    				bod.咳.描画0(are);
    				bod.呼気.描画0(are);
    				if (bod.cb0 && bod.カーソル.コキ)
    				{
    					bod.カーソル.描画0(are);
    					bod.カーソル.描画1(are);
    				}
    				bod.前髪.描画0(are);
    				if (!bod.Is獣耳)
    				{
    					foreach (角2 item65 in bod.角左接続)
    					{
    						item65.根描画(are);
    					}
    					foreach (角2 item66 in bod.角右接続)
    					{
    						item66.根描画(are);
    					}
    				}
    				if (bod.Is単眉)
    				{
    					bod.単眼眉.描画0(are);
    				}
    				if (bod.Is双眉)
    				{
    					bod.眉左.描画0(are);
    					bod.眉右.描画0(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.大顎基接続.描画0(are);
    					bod.大顎基接続.描画1(are);
    					if (bod.Is顔面)
    					{
    						bod.顔面.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item67 in bod.角左接続)
    					{
    						item67.先描画(are);
    					}
    					foreach (角2 item68 in bod.角右接続)
    					{
    						item68.先描画(are);
    					}
    					bod.額接続.描画0(are);
    					bod.額接続.描画1(are);
    					bod.触覚左接続.描画0(are);
    					bod.触覚左接続.描画1(are);
    					bod.触覚右接続.描画0(are);
    					bod.触覚右接続.描画1(are);
    				}
    				else
    				{
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item69 in bod.角左接続)
    					{
    						item69.先描画(are);
    					}
    					foreach (角2 item70 in bod.角右接続)
    					{
    						item70.先描画(are);
    					}
    					if (bod.Is虫角前)
    					{
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    					}
    					else
    					{
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    					}
    				}
    				bod.顔触覚左接続.描画0(are);
    				bod.顔触覚左接続.描画1(are);
    				bod.顔触覚右接続.描画0(are);
    				bod.顔触覚右接続.描画1(are);
    				if (bod.Is頭頂_宇 || bod.Is顔面 || bod.Is額角 || bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				if (bod.cb0 && !(bod.fi = bod.カーソル.Isフォーカス膣肛挿入))
    				{
    					bod.性器精液_人.描画0(are);
    					bod.飛沫_人.描画0(are);
    					bod.潮吹_小_人.描画0(are);
    					bod.潮吹_大_人.描画0(are);
    					bod.放尿_人.描画0(are);
    				}
    				if (bod.Is腕前 && bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				if (bod.Is半前)
    				{
    					bod.EI半前.描画(are);
    				}
    				bod.染み_人.湯気描画(are);
    				if (bod.cb0 && bod.カーソル.Is乳弄り)
    				{
    					bod.カーソル.描画2(Are);
    				}
    				bod.上着B_前掛け.前(are);
    				bod.ぶっかけ大.Draw(are);
    				bod.ぶっかけ小.Draw(are);
    				if (bod.cb1)
    				{
    					bod.カーソル.描画1(are);
    				}
    				if (bod.cb0 && bod.fi)
    				{
    					bod.性器精液_人.描画0(are);
    					bod.飛沫_人.描画0(are);
    					bod.潮吹_小_人.描画0(are);
    					bod.潮吹_大_人.描画0(are);
    					bod.放尿_人.描画0(are);
    				}
    			};
    			return;
    		}
    		if (Is獣)
    		{
    			Draw = delegate(RenderArea are)
    			{
    				bod.染み_人.色更新();
    				bod.染み_人.描画0(are);
    				bod.染み_獣.色更新();
    				bod.染み_獣.描画0(are);
    				bod.上着B_クロス後.描画0(are);
    				if (bod.Is半後)
    				{
    					bod.EI半後.描画(are);
    				}
    				if (bod.Is蜘尾)
    				{
    					bod.ThreadCum.描画0(are);
    				}
    				if (bod.cb0)
    				{
    					if (bod.カーソル.IsSub糸挿入)
    					{
    						bod.カーソル.描画糸(Are);
    					}
    					else if (bod.カーソル.Is糸挿入)
    					{
    						bod.カーソル.描画2(Are);
    					}
    				}
    				if (bod.IsChest)
    				{
    					bod.EIChest.描画(are);
    				}
    				if (bod.IsWaist)
    				{
    					bod.EIWaist.描画(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.頭頂後.描画0(are);
    				}
    				if (bod.Is髪)
    				{
    					bod.EI髪.描画(are);
    				}
    				if (bod.Is獣耳)
    				{
    					foreach (角2 item71 in bod.角左接続)
    					{
    						item71.根描画(are);
    					}
    					foreach (角2 item72 in bod.角右接続)
    					{
    						item72.根描画(are);
    					}
    				}
    				bod.肩左飛膜.描画0(are);
    				bod.肩右飛膜.描画0(are);
    				if (bod.腕左右前後)
    				{
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    				}
    				else
    				{
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    				}
    				bod.脇左_獣.描画0(are);
    				bod.脇右_獣.描画0(are);
    				bod.耳左接続.描画0(are);
    				bod.耳右接続.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.脇描画(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.脇描画(are);
    				}
    				bod.Waist.描画0(are);
    				bod.Waist.描画1(are);
    				bod.Torso.描画0(are);
    				bod.Chest.描画0(are);
    				bod.Neck.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.描画0(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.描画0(are);
    				}
    				if (bod.Is半中1)
    				{
    					bod.EI半中1.描画(are);
    				}
    				bod.PregnantBelly_人.描画0(are);
    				bod.PregnantBellyPlate_人.描画0(are);
    				bod.WaistSkin_人.描画0(are);
    				bod.TorsoPlate_人.描画0(are);
    				bod.胸腹板_人.描画0(are);
    				bod.TorsoSkin_人.描画0(are);
    				bod.胸肌_人.描画0(are);
    				bod.下着T_チューブ.描画0(are);
    				bod.下着T_クロス.描画0(are);
    				bod.下着T_ビキニ.描画0(are);
    				bod.下着T_マイクロ.描画0(are);
    				bod.下着T_ブラ.描画0(are);
    				bod.腕左.描画0(are);
    				bod.腕右.描画0(are);
    				bod.腕左.描画1(are);
    				bod.腕右.描画1(are);
    				if (bod.胸左右前後)
    				{
    					bod.乳房右.描画0(are);
    					bod.乳房左.描画0(are);
    				}
    				else
    				{
    					bod.乳房左.描画0(are);
    					bod.乳房右.描画0(are);
    				}
    				bod.ピアス左.描画0(are);
    				bod.ピアス右.描画0(are);
    				bod.LeftMilkSpray.描画0(are);
    				bod.RightMilkSpary.描画0(are);
    				bod.キャップ2左.描画0(are);
    				bod.キャップ2右.描画0(are);
    				bod.胸肌_人.描画1(are);
    				if (bod.汗掻き != null)
    				{
    					bod.汗掻き.Draw(are);
    				}
    				bod.頭.描画0(are);
    				if (bod.IsDualEyes && !bod.Is瞼宇)
    				{
    					bod.目左.描画0(are);
    					bod.瞼左.描画0(are);
    					bod.目右.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.頭.描画1(are);
    				if (bod.IsSingleEye)
    				{
    					bod.単眼目.描画0(are);
    					bod.単眼瞼.描画0(are);
    				}
    				bod.紅潮.描画0(are);
    				bod.鼻肌.描画0(are);
    				bod.目尻影左.描画0(are);
    				bod.目尻影右.描画0(are);
    				bod.目傷左.描画0(are);
    				bod.目傷右.描画0(are);
    				bod.頬肌左.描画0(are);
    				bod.頬肌右.描画0(are);
    				if (bod.IsForeheadEye)
    				{
    					bod.額目.描画0(are);
    					bod.額瞼.描画0(are);
    				}
    				if (bod.IsCheekEyes)
    				{
    					bod.頬目左.描画0(are);
    					bod.頬目右.描画0(are);
    					bod.頬瞼左.描画0(are);
    					bod.頬瞼右.描画0(are);
    				}
    				if (bod.Is瞼宇)
    				{
    					bod.瞼左.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.LeftDrool.描画0(are);
    				bod.RightDrool.描画0(are);
    				bod.口.描画0(are);
    				if (bod.鼻描画)
    				{
    					bod.鼻.描画0(are);
    					bod.LeftNoseDrip.描画0(are);
    					bod.RightNoseDrip.描画0(are);
    				}
    				bod.頭.描画2(are);
    				bod.玉口枷.描画0(are);
    				bod.BaseHair.描画0(are);
    				bod.横髪左.描画0(are);
    				bod.横髪右.描画0(are);
    				bod.頬左接続.描画0(are);
    				bod.頬左接続.描画1(are);
    				bod.頬右接続.描画0(are);
    				bod.頬右接続.描画1(are);
    				bod.頬肌左.描画1(are);
    				bod.頬肌右.描画1(are);
    				if (bod.涙描画)
    				{
    					bod.LeftTear.描画0(are);
    					bod.RightTear.描画0(are);
    				}
    				if (!bod.Is頭頂_宇 && !bod.Is顔面 && !bod.Is額角 && !bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				if (bod.Is腕前 && !bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				bod.Anus_獣.描画0(are);
    				bod.肛門精液_獣.描画0(are);
    				if (bod.cb1)
    				{
    					bod.カーソル.描画肛(are);
    				}
    				bod.VaginaOrigin_獣.描画0(are);
    				if (bod.XRay_表示 && bod.cb1)
    				{
    					bod.カーソル.描画0(are);
    				}
    				bod.InternalSemen_獣.描画0(are);
    				bod.XRay_獣.描画0(are);
    				bod.性器_獣.描画0(are);
    				if (!bod.XRay_表示 && bod.cb1)
    				{
    					bod.カーソル.描画0(are);
    				}
    				bod.ピアス.描画0(are);
    				bod.下着T_チューブ.描画1(are);
    				bod.下着T_クロス.描画1(are);
    				bod.下着T_ビキニ.描画1(are);
    				bod.下着T_マイクロ.描画1(are);
    				bod.下着T_ブラ.描画1(are);
    				bod.下着乳首左.描画0(are);
    				bod.下着乳首右.描画0(are);
    				bod.キャップ1.描画0(are);
    				bod.上着M_ドレス.描画0(are);
    				bod.上着T_ドレス.描画0(are);
    				bod.上着B_前掛け.描画0(are);
    				if (bod.捲り判定0)
    				{
    					bod.上着B_クロス.描画0(are);
    				}
    				if (bod.Is半中2)
    				{
    					bod.EI半中2.描画(are);
    				}
    				if (!bod.捲り判定0)
    				{
    					bod.上着B_クロス.描画0(are);
    				}
    				if (bod.胸毛_人 != null)
    				{
    					bod.胸毛_人.描画0(are);
    				}
    				bod.Tounge.描画0(are);
    				bod.MouthCum.描画0(are);
    				bod.咳.描画0(are);
    				bod.呼気.描画0(are);
    				if (bod.cb0 && bod.カーソル.コキ)
    				{
    					bod.カーソル.描画0(are);
    					bod.カーソル.描画1(are);
    				}
    				bod.前髪.描画0(are);
    				if (!bod.Is獣耳)
    				{
    					foreach (角2 item73 in bod.角左接続)
    					{
    						item73.根描画(are);
    					}
    					foreach (角2 item74 in bod.角右接続)
    					{
    						item74.根描画(are);
    					}
    				}
    				if (bod.Is単眉)
    				{
    					bod.単眼眉.描画0(are);
    				}
    				if (bod.Is双眉)
    				{
    					bod.眉左.描画0(are);
    					bod.眉右.描画0(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.大顎基接続.描画0(are);
    					bod.大顎基接続.描画1(are);
    					if (bod.Is顔面)
    					{
    						bod.顔面.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item75 in bod.角左接続)
    					{
    						item75.先描画(are);
    					}
    					foreach (角2 item76 in bod.角右接続)
    					{
    						item76.先描画(are);
    					}
    					bod.額接続.描画0(are);
    					bod.額接続.描画1(are);
    					bod.触覚左接続.描画0(are);
    					bod.触覚左接続.描画1(are);
    					bod.触覚右接続.描画0(are);
    					bod.触覚右接続.描画1(are);
    				}
    				else
    				{
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item77 in bod.角左接続)
    					{
    						item77.先描画(are);
    					}
    					foreach (角2 item78 in bod.角右接続)
    					{
    						item78.先描画(are);
    					}
    					if (bod.Is虫角前)
    					{
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    					}
    					else
    					{
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    					}
    				}
    				bod.顔触覚左接続.描画0(are);
    				bod.顔触覚左接続.描画1(are);
    				bod.顔触覚右接続.描画0(are);
    				bod.顔触覚右接続.描画1(are);
    				if (bod.Is頭頂_宇 || bod.Is顔面 || bod.Is額角 || bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				if (bod.cb0 && !(bod.fi = bod.カーソル.Isフォーカス膣肛挿入))
    				{
    					bod.性器精液_獣.描画0(are);
    					bod.飛沫_獣.描画0(are);
    					bod.潮吹_小_獣.描画0(are);
    					bod.潮吹_大_獣.描画0(are);
    					bod.放尿_獣.描画0(are);
    				}
    				if (bod.Is腕前 && bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				if (bod.Is半前)
    				{
    					bod.EI半前.描画(are);
    				}
    				bod.染み_獣.湯気描画(are);
    				if (bod.cb0 && bod.カーソル.Is乳弄り)
    				{
    					bod.カーソル.描画2(Are);
    				}
    				bod.上着B_前掛け.前(are);
    				bod.ぶっかけ大.Draw(are);
    				bod.ぶっかけ小.Draw(are);
    				if (bod.cb1)
    				{
    					bod.カーソル.描画1(are);
    				}
    				if (bod.cb0 && bod.fi)
    				{
    					bod.性器精液_獣.描画0(are);
    					bod.飛沫_獣.描画0(are);
    					bod.潮吹_小_獣.描画0(are);
    					bod.潮吹_大_獣.描画0(are);
    					bod.放尿_獣.描画0(are);
    				}
    			};
    			return;
    		}
    		if (Is蛸)
    		{
    			Draw = delegate(RenderArea are)
    			{
    				bod.染み_人.色更新();
    				bod.染み_人.描画0(are);
    				if (bod.IsChest)
    				{
    					bod.EIChest.描画(are);
    				}
    				if (bod.IsWaist)
    				{
    					bod.EIWaist.描画(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.頭頂後.描画0(are);
    				}
    				if (bod.Is髪)
    				{
    					bod.EI髪.描画(are);
    				}
    				if (bod.Is獣耳)
    				{
    					foreach (角2 item79 in bod.角左接続)
    					{
    						item79.根描画(are);
    					}
    					foreach (角2 item80 in bod.角右接続)
    					{
    						item80.根描画(are);
    					}
    				}
    				bod.肩左飛膜.描画0(are);
    				bod.肩右飛膜.描画0(are);
    				if (bod.腕左右前後)
    				{
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    				}
    				else
    				{
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    				}
    				bod.上着B_クロス後.描画0(are);
    				if (bod.Is半後)
    				{
    					bod.EI半後.描画(are);
    				}
    				if (bod.Is蜘尾)
    				{
    					bod.ThreadCum.描画0(are);
    				}
    				if (bod.cb0)
    				{
    					if (bod.カーソル.IsSub糸挿入)
    					{
    						bod.カーソル.描画糸(Are);
    					}
    					else if (bod.カーソル.Is糸挿入)
    					{
    						bod.カーソル.描画2(Are);
    					}
    				}
    				bod.耳左接続.描画0(are);
    				bod.耳右接続.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.脇描画(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.脇描画(are);
    				}
    				bod.Waist.描画0(are);
    				bod.Waist.描画1(are);
    				bod.Torso.描画0(are);
    				bod.Chest.描画0(are);
    				bod.Neck.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.描画0(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.描画0(are);
    				}
    				if (bod.Is半中1)
    				{
    					bod.EI半中1.描画(are);
    				}
    				bod.下着T_チューブ.描画0(are);
    				bod.下着T_クロス.描画0(are);
    				bod.下着T_ビキニ.描画0(are);
    				bod.下着T_マイクロ.描画0(are);
    				bod.下着T_ブラ.描画0(are);
    				bod.腕左.描画0(are);
    				bod.腕右.描画0(are);
    				bod.腕左.描画1(are);
    				bod.腕右.描画1(are);
    				if (bod.Is半中2)
    				{
    					bod.EI半中2.描画(are);
    				}
    				bod.PregnantBelly_人.描画0(are);
    				bod.PregnantBellyPlate_人.描画0(are);
    				bod.WaistSkin_人.描画0(are);
    				bod.TorsoPlate_人.描画0(are);
    				bod.胸腹板_人.描画0(are);
    				bod.TorsoSkin_人.描画0(are);
    				bod.胸肌_人.描画0(are);
    				if (bod.胸左右前後)
    				{
    					bod.乳房右.描画0(are);
    					bod.乳房左.描画0(are);
    				}
    				else
    				{
    					bod.乳房左.描画0(are);
    					bod.乳房右.描画0(are);
    				}
    				bod.ピアス左.描画0(are);
    				bod.ピアス右.描画0(are);
    				bod.LeftMilkSpray.描画0(are);
    				bod.RightMilkSpary.描画0(are);
    				bod.キャップ2左.描画0(are);
    				bod.キャップ2右.描画0(are);
    				bod.胸肌_人.描画1(are);
    				if (bod.汗掻き != null)
    				{
    					bod.汗掻き.Draw(are);
    				}
    				bod.頭.描画0(are);
    				if (bod.IsDualEyes && !bod.Is瞼宇)
    				{
    					bod.目左.描画0(are);
    					bod.瞼左.描画0(are);
    					bod.目右.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.頭.描画1(are);
    				if (bod.IsSingleEye)
    				{
    					bod.単眼目.描画0(are);
    					bod.単眼瞼.描画0(are);
    				}
    				bod.紅潮.描画0(are);
    				bod.鼻肌.描画0(are);
    				bod.目尻影左.描画0(are);
    				bod.目尻影右.描画0(are);
    				bod.目傷左.描画0(are);
    				bod.目傷右.描画0(are);
    				bod.頬肌左.描画0(are);
    				bod.頬肌右.描画0(are);
    				if (bod.IsForeheadEye)
    				{
    					bod.額目.描画0(are);
    					bod.額瞼.描画0(are);
    				}
    				if (bod.IsCheekEyes)
    				{
    					bod.頬目左.描画0(are);
    					bod.頬目右.描画0(are);
    					bod.頬瞼左.描画0(are);
    					bod.頬瞼右.描画0(are);
    				}
    				if (bod.Is瞼宇)
    				{
    					bod.瞼左.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.LeftDrool.描画0(are);
    				bod.RightDrool.描画0(are);
    				bod.口.描画0(are);
    				if (bod.鼻描画)
    				{
    					bod.鼻.描画0(are);
    					bod.LeftNoseDrip.描画0(are);
    					bod.RightNoseDrip.描画0(are);
    				}
    				bod.頭.描画2(are);
    				bod.玉口枷.描画0(are);
    				bod.BaseHair.描画0(are);
    				bod.横髪左.描画0(are);
    				bod.横髪右.描画0(are);
    				bod.頬左接続.描画0(are);
    				bod.頬左接続.描画1(are);
    				bod.頬右接続.描画0(are);
    				bod.頬右接続.描画1(are);
    				bod.頬肌左.描画1(are);
    				bod.頬肌右.描画1(are);
    				if (bod.涙描画)
    				{
    					bod.LeftTear.描画0(are);
    					bod.RightTear.描画0(are);
    				}
    				if (!bod.Is頭頂_宇 && !bod.Is顔面 && !bod.Is額角 && !bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				if (bod.Is腕前 && !bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				bod.Anus_人.描画0(are);
    				bod.肛門精液_人.描画0(are);
    				if (bod.cb1)
    				{
    					bod.カーソル.描画肛(are);
    				}
    				bod.VaginaOrigin_人.描画0(are);
    				if (bod.XRay_表示 && bod.cb1)
    				{
    					bod.カーソル.描画0(are);
    				}
    				bod.InternalSemen_人.描画0(are);
    				bod.XRay_人.描画0(are);
    				bod.性器_人.描画0(are);
    				if (!bod.XRay_表示 && bod.cb1)
    				{
    					bod.カーソル.描画0(are);
    				}
    				bod.ピアス.描画0(are);
    				bod.下着T_チューブ.描画1(are);
    				bod.下着T_クロス.描画1(are);
    				bod.下着T_ビキニ.描画1(are);
    				bod.下着T_マイクロ.描画1(are);
    				bod.下着T_ブラ.描画1(are);
    				bod.下着乳首左.描画0(are);
    				bod.下着乳首右.描画0(are);
    				bod.キャップ1.描画0(are);
    				bod.上着M_ドレス.描画0(are);
    				bod.上着T_ドレス.描画0(are);
    				bod.上着B_前掛け.描画0(are);
    				bod.上着B_クロス.描画0(are);
    				if (bod.胸毛_人 != null)
    				{
    					bod.胸毛_人.描画0(are);
    				}
    				bod.Tounge.描画0(are);
    				bod.MouthCum.描画0(are);
    				bod.咳.描画0(are);
    				bod.呼気.描画0(are);
    				if (bod.cb0 && bod.カーソル.コキ)
    				{
    					bod.カーソル.描画0(are);
    					bod.カーソル.描画1(are);
    				}
    				bod.前髪.描画0(are);
    				if (!bod.Is獣耳)
    				{
    					foreach (角2 item81 in bod.角左接続)
    					{
    						item81.根描画(are);
    					}
    					foreach (角2 item82 in bod.角右接続)
    					{
    						item82.根描画(are);
    					}
    				}
    				if (bod.Is単眉)
    				{
    					bod.単眼眉.描画0(are);
    				}
    				if (bod.Is双眉)
    				{
    					bod.眉左.描画0(are);
    					bod.眉右.描画0(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.大顎基接続.描画0(are);
    					bod.大顎基接続.描画1(are);
    					if (bod.Is顔面)
    					{
    						bod.顔面.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item83 in bod.角左接続)
    					{
    						item83.先描画(are);
    					}
    					foreach (角2 item84 in bod.角右接続)
    					{
    						item84.先描画(are);
    					}
    					bod.額接続.描画0(are);
    					bod.額接続.描画1(are);
    					bod.触覚左接続.描画0(are);
    					bod.触覚左接続.描画1(are);
    					bod.触覚右接続.描画0(are);
    					bod.触覚右接続.描画1(are);
    				}
    				else
    				{
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item85 in bod.角左接続)
    					{
    						item85.先描画(are);
    					}
    					foreach (角2 item86 in bod.角右接続)
    					{
    						item86.先描画(are);
    					}
    					if (bod.Is虫角前)
    					{
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    					}
    					else
    					{
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    					}
    				}
    				bod.顔触覚左接続.描画0(are);
    				bod.顔触覚左接続.描画1(are);
    				bod.顔触覚右接続.描画0(are);
    				bod.顔触覚右接続.描画1(are);
    				if (bod.Is頭頂_宇 || bod.Is顔面 || bod.Is額角 || bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				if (bod.cb0 && !(bod.fi = bod.カーソル.Isフォーカス膣肛挿入))
    				{
    					bod.性器精液_人.描画0(are);
    					bod.飛沫_人.描画0(are);
    					bod.潮吹_小_人.描画0(are);
    					bod.潮吹_大_人.描画0(are);
    					bod.放尿_人.描画0(are);
    				}
    				if (bod.Is腕前 && bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				if (bod.Is半前)
    				{
    					bod.EI半前.描画(are);
    				}
    				bod.染み_人.湯気描画(are);
    				if (bod.cb0 && bod.カーソル.Is乳弄り)
    				{
    					bod.カーソル.描画2(Are);
    				}
    				bod.上着B_前掛け.前(are);
    				bod.ぶっかけ大.Draw(are);
    				bod.ぶっかけ小.Draw(are);
    				if (bod.cb1)
    				{
    					bod.カーソル.描画1(are);
    				}
    				if (bod.cb0 && bod.fi)
    				{
    					bod.性器精液_人.描画0(are);
    					bod.飛沫_人.描画0(are);
    					bod.潮吹_小_人.描画0(are);
    					bod.潮吹_大_人.描画0(are);
    					bod.放尿_人.描画0(are);
    				}
    			};
    			return;
    		}
    		if (Is多足)
    		{
    			Draw = delegate(RenderArea are)
    			{
    				if (bod.Is蠍)
    				{
    					bod.蠍.X0Y0_生殖口蓋左CP.Update();
    					bod.蠍.X0Y0_生殖口蓋右CP.Update();
    				}
    				bod.染み_人.色更新();
    				bod.染み_人.描画0(are);
    				if (bod.IsChest)
    				{
    					bod.EIChest.描画(are);
    				}
    				if (bod.IsWaist)
    				{
    					bod.EIWaist.描画(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.頭頂後.描画0(are);
    				}
    				if (bod.Is髪)
    				{
    					bod.EI髪.描画(are);
    				}
    				if (bod.Is獣耳)
    				{
    					foreach (角2 item87 in bod.角左接続)
    					{
    						item87.根描画(are);
    					}
    					foreach (角2 item88 in bod.角右接続)
    					{
    						item88.根描画(are);
    					}
    				}
    				bod.肩左飛膜.描画0(are);
    				bod.肩右飛膜.描画0(are);
    				if (bod.腕左右前後)
    				{
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    				}
    				else
    				{
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    				}
    				bod.上着B_クロス後.描画0(are);
    				if (bod.Is半後)
    				{
    					bod.EI半後.描画(are);
    				}
    				if (bod.Is蜘尾)
    				{
    					bod.ThreadCum.描画0(are);
    				}
    				if (bod.cb0)
    				{
    					if (bod.カーソル.IsSub糸挿入)
    					{
    						bod.カーソル.描画糸(Are);
    					}
    					else if (bod.カーソル.Is糸挿入)
    					{
    						bod.カーソル.描画2(Are);
    					}
    				}
    				bod.耳左接続.描画0(are);
    				bod.耳右接続.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.脇描画(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.脇描画(are);
    				}
    				bod.Waist.描画0(are);
    				bod.Waist.描画1(are);
    				bod.Torso.描画0(are);
    				bod.Chest.描画0(are);
    				bod.Neck.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.描画0(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.描画0(are);
    				}
    				if (bod.Is半中2)
    				{
    					bod.EI半中2.描画(are);
    				}
    				bod.PregnantBelly_人.描画0(are);
    				bod.PregnantBellyPlate_人.描画0(are);
    				bod.WaistSkin_人.描画0(are);
    				bod.TorsoPlate_人.描画0(are);
    				bod.胸腹板_人.描画0(are);
    				bod.TorsoSkin_人.描画0(are);
    				bod.胸肌_人.描画0(are);
    				bod.下着T_チューブ.描画0(are);
    				bod.下着T_クロス.描画0(are);
    				bod.下着T_ビキニ.描画0(are);
    				bod.下着T_マイクロ.描画0(are);
    				bod.下着T_ブラ.描画0(are);
    				bod.腕左.描画0(are);
    				bod.腕右.描画0(are);
    				bod.腕左.描画1(are);
    				bod.腕右.描画1(are);
    				if (bod.胸左右前後)
    				{
    					bod.乳房右.描画0(are);
    					bod.乳房左.描画0(are);
    				}
    				else
    				{
    					bod.乳房左.描画0(are);
    					bod.乳房右.描画0(are);
    				}
    				bod.ピアス左.描画0(are);
    				bod.ピアス右.描画0(are);
    				bod.LeftMilkSpray.描画0(are);
    				bod.RightMilkSpary.描画0(are);
    				bod.キャップ2左.描画0(are);
    				bod.キャップ2右.描画0(are);
    				bod.胸肌_人.描画1(are);
    				if (bod.汗掻き != null)
    				{
    					bod.汗掻き.Draw(are);
    				}
    				bod.頭.描画0(are);
    				if (bod.IsDualEyes && !bod.Is瞼宇)
    				{
    					bod.目左.描画0(are);
    					bod.瞼左.描画0(are);
    					bod.目右.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.頭.描画1(are);
    				if (bod.IsSingleEye)
    				{
    					bod.単眼目.描画0(are);
    					bod.単眼瞼.描画0(are);
    				}
    				bod.紅潮.描画0(are);
    				bod.鼻肌.描画0(are);
    				bod.目尻影左.描画0(are);
    				bod.目尻影右.描画0(are);
    				bod.目傷左.描画0(are);
    				bod.目傷右.描画0(are);
    				bod.頬肌左.描画0(are);
    				bod.頬肌右.描画0(are);
    				if (bod.IsForeheadEye)
    				{
    					bod.額目.描画0(are);
    					bod.額瞼.描画0(are);
    				}
    				if (bod.IsCheekEyes)
    				{
    					bod.頬目左.描画0(are);
    					bod.頬目右.描画0(are);
    					bod.頬瞼左.描画0(are);
    					bod.頬瞼右.描画0(are);
    				}
    				if (bod.Is瞼宇)
    				{
    					bod.瞼左.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.LeftDrool.描画0(are);
    				bod.RightDrool.描画0(are);
    				bod.口.描画0(are);
    				if (bod.鼻描画)
    				{
    					bod.鼻.描画0(are);
    					bod.LeftNoseDrip.描画0(are);
    					bod.RightNoseDrip.描画0(are);
    				}
    				bod.頭.描画2(are);
    				bod.玉口枷.描画0(are);
    				bod.BaseHair.描画0(are);
    				bod.横髪左.描画0(are);
    				bod.横髪右.描画0(are);
    				bod.頬左接続.描画0(are);
    				bod.頬左接続.描画1(are);
    				bod.頬右接続.描画0(are);
    				bod.頬右接続.描画1(are);
    				bod.頬肌左.描画1(are);
    				bod.頬肌右.描画1(are);
    				if (bod.涙描画)
    				{
    					bod.LeftTear.描画0(are);
    					bod.RightTear.描画0(are);
    				}
    				if (!bod.Is頭頂_宇 && !bod.Is顔面 && !bod.Is額角 && !bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				if (bod.Is腕前 && !bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				if (bod.Is半中1)
    				{
    					bod.EI半中1.描画(are);
    				}
    				bod.Anus_人.描画0(are);
    				bod.肛門精液_人.描画0(are);
    				if (bod.cb1)
    				{
    					bod.カーソル.描画肛(are);
    				}
    				bod.VaginaOrigin_人.描画0(are);
    				if (bod.XRay_表示 && bod.cb1)
    				{
    					bod.カーソル.描画0(are);
    				}
    				bod.InternalSemen_人.描画0(are);
    				bod.XRay_人.描画0(are);
    				bod.性器_人.描画0(are);
    				if (!bod.XRay_表示 && bod.cb1)
    				{
    					bod.カーソル.描画0(are);
    				}
    				bod.ピアス.描画0(are);
    				if (bod.蠍前 != null)
    				{
    					bod.蠍前.描画0(are);
    				}
    				bod.下着T_チューブ.描画1(are);
    				bod.下着T_クロス.描画1(are);
    				bod.下着T_ビキニ.描画1(are);
    				bod.下着T_マイクロ.描画1(are);
    				bod.下着T_ブラ.描画1(are);
    				bod.下着乳首左.描画0(are);
    				bod.下着乳首右.描画0(are);
    				bod.キャップ1.描画0(are);
    				bod.上着M_ドレス.描画0(are);
    				bod.上着T_ドレス.描画0(are);
    				bod.上着B_前掛け.描画0(are);
    				bod.上着B_クロス.描画0(are);
    				if (bod.胸毛_人 != null)
    				{
    					bod.胸毛_人.描画0(are);
    				}
    				bod.Tounge.描画0(are);
    				bod.MouthCum.描画0(are);
    				bod.咳.描画0(are);
    				bod.呼気.描画0(are);
    				if (bod.cb0 && bod.カーソル.コキ)
    				{
    					bod.カーソル.描画0(are);
    					bod.カーソル.描画1(are);
    				}
    				bod.前髪.描画0(are);
    				if (!bod.Is獣耳)
    				{
    					foreach (角2 item89 in bod.角左接続)
    					{
    						item89.根描画(are);
    					}
    					foreach (角2 item90 in bod.角右接続)
    					{
    						item90.根描画(are);
    					}
    				}
    				if (bod.Is単眉)
    				{
    					bod.単眼眉.描画0(are);
    				}
    				if (bod.Is双眉)
    				{
    					bod.眉左.描画0(are);
    					bod.眉右.描画0(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.大顎基接続.描画0(are);
    					bod.大顎基接続.描画1(are);
    					if (bod.Is顔面)
    					{
    						bod.顔面.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item91 in bod.角左接続)
    					{
    						item91.先描画(are);
    					}
    					foreach (角2 item92 in bod.角右接続)
    					{
    						item92.先描画(are);
    					}
    					bod.額接続.描画0(are);
    					bod.額接続.描画1(are);
    					bod.触覚左接続.描画0(are);
    					bod.触覚左接続.描画1(are);
    					bod.触覚右接続.描画0(are);
    					bod.触覚右接続.描画1(are);
    				}
    				else
    				{
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item93 in bod.角左接続)
    					{
    						item93.先描画(are);
    					}
    					foreach (角2 item94 in bod.角右接続)
    					{
    						item94.先描画(are);
    					}
    					if (bod.Is虫角前)
    					{
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    					}
    					else
    					{
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    					}
    				}
    				bod.顔触覚左接続.描画0(are);
    				bod.顔触覚左接続.描画1(are);
    				bod.顔触覚右接続.描画0(are);
    				bod.顔触覚右接続.描画1(are);
    				if (bod.Is頭頂_宇 || bod.Is顔面 || bod.Is額角 || bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				if (bod.cb0 && !(bod.fi = bod.カーソル.Isフォーカス膣肛挿入))
    				{
    					bod.性器精液_人.描画0(are);
    					bod.飛沫_人.描画0(are);
    					bod.潮吹_小_人.描画0(are);
    					bod.潮吹_大_人.描画0(are);
    					bod.放尿_人.描画0(are);
    				}
    				if (bod.Is腕前 && bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				if (bod.Is半前)
    				{
    					bod.EI半前.描画(are);
    				}
    				bod.染み_人.湯気描画(are);
    				if (bod.cb0 && bod.カーソル.Is乳弄り)
    				{
    					bod.カーソル.描画2(Are);
    				}
    				bod.上着B_前掛け.前(are);
    				bod.ぶっかけ大.Draw(are);
    				bod.ぶっかけ小.Draw(are);
    				if (bod.cb1)
    				{
    					bod.カーソル.描画1(are);
    				}
    				if (bod.cb0 && bod.fi)
    				{
    					bod.性器精液_人.描画0(are);
    					bod.飛沫_人.描画0(are);
    					bod.潮吹_小_人.描画0(are);
    					bod.潮吹_大_人.描画0(are);
    					bod.放尿_人.描画0(are);
    				}
    			};
    			return;
    		}
    		if (Is植)
    		{
    			Draw = delegate(RenderArea are)
    			{
    				bod.染み_人.色更新();
    				bod.染み_人.描画0(are);
    				if (bod.IsChest)
    				{
    					bod.EIChest.描画(are);
    				}
    				if (bod.IsWaist)
    				{
    					bod.EIWaist.描画(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.頭頂後.描画0(are);
    				}
    				if (bod.Is髪)
    				{
    					bod.EI髪.描画(are);
    				}
    				if (bod.Is獣耳)
    				{
    					foreach (角2 item95 in bod.角左接続)
    					{
    						item95.根描画(are);
    					}
    					foreach (角2 item96 in bod.角右接続)
    					{
    						item96.根描画(are);
    					}
    				}
    				bod.肩左飛膜.描画0(are);
    				bod.肩右飛膜.描画0(are);
    				if (bod.腕左右前後)
    				{
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    				}
    				else
    				{
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    				}
    				bod.上着B_クロス後.描画0(are);
    				if (bod.Is半後)
    				{
    					bod.EI半後.描画(are);
    				}
    				if (bod.Is蜘尾)
    				{
    					bod.ThreadCum.描画0(are);
    				}
    				if (bod.cb0)
    				{
    					if (bod.カーソル.IsSub糸挿入)
    					{
    						bod.カーソル.描画糸(Are);
    					}
    					else if (bod.カーソル.Is糸挿入)
    					{
    						bod.カーソル.描画2(Are);
    					}
    				}
    				bod.耳左接続.描画0(are);
    				bod.耳右接続.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.脇描画(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.脇描画(are);
    				}
    				bod.Waist.描画0(are);
    				bod.Waist.描画1(are);
    				bod.Torso.描画0(are);
    				bod.Chest.描画0(are);
    				bod.Neck.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.描画0(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.描画0(are);
    				}
    				if (bod.Is半中2)
    				{
    					bod.EI半中2.描画(are);
    				}
    				bod.PregnantBelly_人.描画0(are);
    				bod.PregnantBellyPlate_人.描画0(are);
    				bod.WaistSkin_人.描画0(are);
    				bod.TorsoPlate_人.描画0(are);
    				bod.胸腹板_人.描画0(are);
    				bod.TorsoSkin_人.描画0(are);
    				bod.胸肌_人.描画0(are);
    				bod.下着T_チューブ.描画0(are);
    				bod.下着T_クロス.描画0(are);
    				bod.下着T_ビキニ.描画0(are);
    				bod.下着T_マイクロ.描画0(are);
    				bod.下着T_ブラ.描画0(are);
    				bod.腕左.描画0(are);
    				bod.腕右.描画0(are);
    				bod.腕左.描画1(are);
    				bod.腕右.描画1(are);
    				if (bod.胸左右前後)
    				{
    					bod.乳房右.描画0(are);
    					bod.乳房左.描画0(are);
    				}
    				else
    				{
    					bod.乳房左.描画0(are);
    					bod.乳房右.描画0(are);
    				}
    				bod.ピアス左.描画0(are);
    				bod.ピアス右.描画0(are);
    				bod.LeftMilkSpray.描画0(are);
    				bod.RightMilkSpary.描画0(are);
    				bod.キャップ2左.描画0(are);
    				bod.キャップ2右.描画0(are);
    				bod.胸肌_人.描画1(are);
    				if (bod.汗掻き != null)
    				{
    					bod.汗掻き.Draw(are);
    				}
    				bod.頭.描画0(are);
    				if (bod.IsDualEyes && !bod.Is瞼宇)
    				{
    					bod.目左.描画0(are);
    					bod.瞼左.描画0(are);
    					bod.目右.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.頭.描画1(are);
    				if (bod.IsSingleEye)
    				{
    					bod.単眼目.描画0(are);
    					bod.単眼瞼.描画0(are);
    				}
    				bod.紅潮.描画0(are);
    				bod.鼻肌.描画0(are);
    				bod.目尻影左.描画0(are);
    				bod.目尻影右.描画0(are);
    				bod.目傷左.描画0(are);
    				bod.目傷右.描画0(are);
    				bod.頬肌左.描画0(are);
    				bod.頬肌右.描画0(are);
    				if (bod.IsForeheadEye)
    				{
    					bod.額目.描画0(are);
    					bod.額瞼.描画0(are);
    				}
    				if (bod.IsCheekEyes)
    				{
    					bod.頬目左.描画0(are);
    					bod.頬目右.描画0(are);
    					bod.頬瞼左.描画0(are);
    					bod.頬瞼右.描画0(are);
    				}
    				if (bod.Is瞼宇)
    				{
    					bod.瞼左.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.LeftDrool.描画0(are);
    				bod.RightDrool.描画0(are);
    				bod.口.描画0(are);
    				if (bod.鼻描画)
    				{
    					bod.鼻.描画0(are);
    					bod.LeftNoseDrip.描画0(are);
    					bod.RightNoseDrip.描画0(are);
    				}
    				bod.頭.描画2(are);
    				bod.玉口枷.描画0(are);
    				bod.BaseHair.描画0(are);
    				bod.横髪左.描画0(are);
    				bod.横髪右.描画0(are);
    				bod.頬左接続.描画0(are);
    				bod.頬左接続.描画1(are);
    				bod.頬右接続.描画0(are);
    				bod.頬右接続.描画1(are);
    				bod.頬肌左.描画1(are);
    				bod.頬肌右.描画1(are);
    				if (bod.涙描画)
    				{
    					bod.LeftTear.描画0(are);
    					bod.RightTear.描画0(are);
    				}
    				if (!bod.Is頭頂_宇 && !bod.Is顔面 && !bod.Is額角 && !bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				if (bod.Is腕前 && !bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				bod.Anus_人.描画0(are);
    				bod.肛門精液_人.描画0(are);
    				if (!bod.Is下着B)
    				{
    					bod.EI腿.描画(are);
    					if (bod.Is半中1)
    					{
    						bod.EI半中1.描画(are);
    					}
    				}
    				if (bod.cb1)
    				{
    					bod.カーソル.描画肛(are);
    				}
    				bod.VaginaOrigin_人.描画0(are);
    				if (bod.XRay_表示 && bod.cb1)
    				{
    					bod.カーソル.描画0(are);
    				}
    				bod.InternalSemen_人.描画0(are);
    				bod.XRay_人.描画0(are);
    				bod.性器_人.描画0(are);
    				if (!bod.XRay_表示 && bod.cb1)
    				{
    					bod.カーソル.描画0(are);
    				}
    				bod.ピアス.描画0(are);
    				bod.下着T_チューブ.描画1(are);
    				bod.下着T_クロス.描画1(are);
    				bod.下着T_ビキニ.描画1(are);
    				bod.下着T_マイクロ.描画1(are);
    				bod.下着T_ブラ.描画1(are);
    				bod.下着乳首左.描画0(are);
    				bod.下着乳首右.描画0(are);
    				bod.キャップ1.描画0(are);
    				bod.下着B_ノーマル.描画0(are);
    				bod.下着B_マイクロ.描画0(are);
    				bod.下着B_ノーマル.描画1(are);
    				bod.下着B_マイクロ.描画1(are);
    				bod.下着陰核.描画0(are);
    				bod.上着M_ドレス.描画0(are);
    				bod.上着T_ドレス.描画0(are);
    				if (bod.Is下着B)
    				{
    					bod.EI腿.描画(are);
    					if (bod.Is半中1)
    					{
    						bod.EI半中1.描画(are);
    					}
    				}
    				bod.上着B_前掛け.描画0(are);
    				bod.上着B_クロス.描画0(are);
    				if (bod.胸毛_人 != null)
    				{
    					bod.胸毛_人.描画0(are);
    				}
    				bod.Tounge.描画0(are);
    				bod.MouthCum.描画0(are);
    				bod.咳.描画0(are);
    				bod.呼気.描画0(are);
    				if (bod.cb0 && bod.カーソル.コキ)
    				{
    					bod.カーソル.描画0(are);
    					bod.カーソル.描画1(are);
    				}
    				bod.前髪.描画0(are);
    				if (!bod.Is獣耳)
    				{
    					foreach (角2 item97 in bod.角左接続)
    					{
    						item97.根描画(are);
    					}
    					foreach (角2 item98 in bod.角右接続)
    					{
    						item98.根描画(are);
    					}
    				}
    				if (bod.Is単眉)
    				{
    					bod.単眼眉.描画0(are);
    				}
    				if (bod.Is双眉)
    				{
    					bod.眉左.描画0(are);
    					bod.眉右.描画0(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.大顎基接続.描画0(are);
    					bod.大顎基接続.描画1(are);
    					if (bod.Is顔面)
    					{
    						bod.顔面.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item99 in bod.角左接続)
    					{
    						item99.先描画(are);
    					}
    					foreach (角2 item100 in bod.角右接続)
    					{
    						item100.先描画(are);
    					}
    					bod.額接続.描画0(are);
    					bod.額接続.描画1(are);
    					bod.触覚左接続.描画0(are);
    					bod.触覚左接続.描画1(are);
    					bod.触覚右接続.描画0(are);
    					bod.触覚右接続.描画1(are);
    				}
    				else
    				{
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item101 in bod.角左接続)
    					{
    						item101.先描画(are);
    					}
    					foreach (角2 item102 in bod.角右接続)
    					{
    						item102.先描画(are);
    					}
    					if (bod.Is虫角前)
    					{
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    					}
    					else
    					{
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    					}
    				}
    				bod.顔触覚左接続.描画0(are);
    				bod.顔触覚左接続.描画1(are);
    				bod.顔触覚右接続.描画0(are);
    				bod.顔触覚右接続.描画1(are);
    				if (bod.Is頭頂_宇 || bod.Is顔面 || bod.Is額角 || bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				if (bod.cb0 && !(bod.fi = bod.カーソル.Isフォーカス膣肛挿入))
    				{
    					bod.性器精液_人.描画0(are);
    					bod.飛沫_人.描画0(are);
    					bod.潮吹_小_人.描画0(are);
    					bod.潮吹_大_人.描画0(are);
    					bod.放尿_人.描画0(are);
    				}
    				if (bod.Is腕前 && bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				if (bod.Is半前)
    				{
    					bod.EI半前.描画(are);
    				}
    				bod.染み_人.湯気描画(are);
    				if (bod.cb0 && bod.カーソル.Is乳弄り)
    				{
    					bod.カーソル.描画2(Are);
    				}
    				bod.上着B_前掛け.前(are);
    				bod.ぶっかけ大.Draw(are);
    				bod.ぶっかけ小.Draw(are);
    				if (bod.cb1)
    				{
    					bod.カーソル.描画1(are);
    				}
    				if (bod.cb0 && bod.fi)
    				{
    					bod.性器精液_人.描画0(are);
    					bod.飛沫_人.描画0(are);
    					bod.潮吹_小_人.描画0(are);
    					bod.潮吹_大_人.描画0(are);
    					bod.放尿_人.描画0(are);
    				}
    			};
    			return;
    		}
    		if (Is粘)
    		{
    			Draw = delegate(RenderArea are)
    			{
    				bod.染み_人.色更新();
    				bod.染み_人.描画0(are);
    				if (bod.IsChest)
    				{
    					bod.EIChest.描画(are);
    				}
    				if (bod.IsWaist)
    				{
    					bod.EIWaist.描画(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.頭頂後.描画0(are);
    				}
    				if (bod.Is髪)
    				{
    					bod.EI髪.描画(are);
    				}
    				if (bod.Is獣耳)
    				{
    					foreach (角2 item103 in bod.角左接続)
    					{
    						item103.根描画(are);
    					}
    					foreach (角2 item104 in bod.角右接続)
    					{
    						item104.根描画(are);
    					}
    				}
    				bod.上着B_クロス後.描画0(are);
    				if (bod.Is半後)
    				{
    					bod.EI半後.描画(are);
    				}
    				if (bod.Is蜘尾)
    				{
    					bod.ThreadCum.描画0(are);
    				}
    				if (bod.cb0)
    				{
    					if (bod.カーソル.IsSub糸挿入)
    					{
    						bod.カーソル.描画糸(Are);
    					}
    					else if (bod.カーソル.Is糸挿入)
    					{
    						bod.カーソル.描画2(Are);
    					}
    				}
    				bod.肩左飛膜.描画0(are);
    				bod.肩右飛膜.描画0(are);
    				if (bod.腕左右前後)
    				{
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    				}
    				else
    				{
    					if (bod.腕左前後_)
    					{
    						bod.LowerArm以降左.描画0(are);
    						bod.LowerArm以降左.描画1(are);
    					}
    					if (bod.腕右前後_)
    					{
    						bod.LowerArm以降右.描画0(are);
    						bod.LowerArm以降右.描画1(are);
    					}
    				}
    				bod.耳左接続.描画0(are);
    				bod.耳右接続.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.脇描画(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.脇描画(are);
    				}
    				bod.Waist.描画0(are);
    				bod.Waist.描画1(are);
    				if (!GlobalState.GameData.XRay)
    				{
    					bod.Anus_人.描画0(are);
    					bod.肛門精液_人.描画0(are);
    					if (bod.cb1)
    					{
    						bod.カーソル.描画肛(are);
    					}
    					bod.VaginaOrigin_人.描画0(are);
    					if (bod.XRay_表示 && bod.cb1)
    					{
    						bod.カーソル.描画0(are);
    					}
    					bod.InternalSemen_人.描画0(are);
    					bod.XRay_人.描画0(are);
    				}
    				bod.Torso.描画0(are);
    				bod.Chest.描画0(are);
    				bod.Neck.描画0(are);
    				if (bod.肩左 != null)
    				{
    					bod.肩左.描画0(are);
    				}
    				if (bod.肩右 != null)
    				{
    					bod.肩右.描画0(are);
    				}
    				if (bod.Is半中1)
    				{
    					bod.EI半中1.描画(are);
    				}
    				if (bod.Is半中2)
    				{
    					bod.EI半中2.描画(are);
    				}
    				bod.PregnantBelly_人.描画0(are);
    				bod.PregnantBellyPlate_人.描画0(are);
    				bod.WaistSkin_人.描画0(are);
    				bod.TorsoPlate_人.描画0(are);
    				bod.胸腹板_人.描画0(are);
    				bod.TorsoSkin_人.描画0(are);
    				bod.胸肌_人.描画0(are);
    				bod.下着T_チューブ.描画0(are);
    				bod.下着T_クロス.描画0(are);
    				bod.下着T_ビキニ.描画0(are);
    				bod.下着T_マイクロ.描画0(are);
    				bod.下着T_ブラ.描画0(are);
    				bod.腕左.描画0(are);
    				bod.腕右.描画0(are);
    				bod.腕左.描画1(are);
    				bod.腕右.描画1(are);
    				if (bod.胸左右前後)
    				{
    					bod.乳房右.描画0(are);
    					bod.乳房左.描画0(are);
    				}
    				else
    				{
    					bod.乳房左.描画0(are);
    					bod.乳房右.描画0(are);
    				}
    				bod.ピアス左.描画0(are);
    				bod.ピアス右.描画0(are);
    				bod.LeftMilkSpray.描画0(are);
    				bod.RightMilkSpary.描画0(are);
    				bod.キャップ2左.描画0(are);
    				bod.キャップ2右.描画0(are);
    				bod.胸肌_人.描画1(are);
    				if (bod.汗掻き != null)
    				{
    					bod.汗掻き.Draw(are);
    				}
    				bod.頭.描画0(are);
    				if (bod.IsDualEyes && !bod.Is瞼宇)
    				{
    					bod.目左.描画0(are);
    					bod.瞼左.描画0(are);
    					bod.目右.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.頭.描画1(are);
    				if (bod.IsSingleEye)
    				{
    					bod.単眼目.描画0(are);
    					bod.単眼瞼.描画0(are);
    				}
    				bod.紅潮.描画0(are);
    				bod.鼻肌.描画0(are);
    				bod.目尻影左.描画0(are);
    				bod.目尻影右.描画0(are);
    				bod.目傷左.描画0(are);
    				bod.目傷右.描画0(are);
    				bod.頬肌左.描画0(are);
    				bod.頬肌右.描画0(are);
    				if (bod.IsForeheadEye)
    				{
    					bod.額目.描画0(are);
    					bod.額瞼.描画0(are);
    				}
    				if (bod.IsCheekEyes)
    				{
    					bod.頬目左.描画0(are);
    					bod.頬目右.描画0(are);
    					bod.頬瞼左.描画0(are);
    					bod.頬瞼右.描画0(are);
    				}
    				if (bod.Is瞼宇)
    				{
    					bod.瞼左.描画0(are);
    					bod.瞼右.描画0(are);
    				}
    				bod.LeftDrool.描画0(are);
    				bod.RightDrool.描画0(are);
    				bod.口.描画0(are);
    				if (bod.鼻描画)
    				{
    					bod.鼻.描画0(are);
    					bod.LeftNoseDrip.描画0(are);
    					bod.RightNoseDrip.描画0(are);
    				}
    				bod.頭.描画2(are);
    				bod.玉口枷.描画0(are);
    				bod.BaseHair.描画0(are);
    				bod.横髪左.描画0(are);
    				bod.横髪右.描画0(are);
    				bod.頬左接続.描画0(are);
    				bod.頬左接続.描画1(are);
    				bod.頬右接続.描画0(are);
    				bod.頬右接続.描画1(are);
    				bod.頬肌左.描画1(are);
    				bod.頬肌右.描画1(are);
    				if (bod.涙描画)
    				{
    					bod.LeftTear.描画0(are);
    					bod.RightTear.描画0(are);
    				}
    				if (!bod.Is頭頂_宇 && !bod.Is顔面 && !bod.Is額角 && !bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				if (bod.Is腕前 && !bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				if (GlobalState.GameData.XRay)
    				{
    					bod.Anus_人.描画0(are);
    					bod.肛門精液_人.描画0(are);
    					if (bod.cb1)
    					{
    						bod.カーソル.描画肛(are);
    					}
    					bod.VaginaOrigin_人.描画0(are);
    					if (bod.XRay_表示 && bod.cb1)
    					{
    						bod.カーソル.描画0(are);
    					}
    					bod.InternalSemen_人.描画0(are);
    					bod.XRay_人.描画0(are);
    				}
    				bod.性器_人.描画0(are);
    				if (!bod.XRay_表示 && bod.cb1)
    				{
    					bod.カーソル.描画0(are);
    				}
    				bod.ピアス.描画0(are);
    				bod.下着T_チューブ.描画1(are);
    				bod.下着T_クロス.描画1(are);
    				bod.下着T_ビキニ.描画1(are);
    				bod.下着T_マイクロ.描画1(are);
    				bod.下着T_ブラ.描画1(are);
    				bod.下着乳首左.描画0(are);
    				bod.下着乳首右.描画0(are);
    				bod.キャップ1.描画0(are);
    				bod.下着B_ノーマル.描画0(are);
    				bod.下着B_マイクロ.描画0(are);
    				bod.下着B_ノーマル.描画1(are);
    				bod.下着B_マイクロ.描画1(are);
    				bod.下着陰核.描画0(are);
    				bod.上着M_ドレス.描画0(are);
    				bod.上着T_ドレス.描画0(are);
    				bod.上着B_前掛け.描画0(are);
    				bod.EI腿.描画(are);
    				if (bod.胸毛_人 != null)
    				{
    					bod.胸毛_人.描画0(are);
    				}
    				bod.Tounge.描画0(are);
    				bod.MouthCum.描画0(are);
    				bod.咳.描画0(are);
    				bod.呼気.描画0(are);
    				if (bod.cb0 && bod.カーソル.コキ)
    				{
    					bod.カーソル.描画0(are);
    					bod.カーソル.描画1(are);
    				}
    				bod.前髪.描画0(are);
    				if (!bod.Is獣耳)
    				{
    					foreach (角2 item105 in bod.角左接続)
    					{
    						item105.根描画(are);
    					}
    					foreach (角2 item106 in bod.角右接続)
    					{
    						item106.根描画(are);
    					}
    				}
    				if (bod.Is単眉)
    				{
    					bod.単眼眉.描画0(are);
    				}
    				if (bod.Is双眉)
    				{
    					bod.眉左.描画0(are);
    					bod.眉右.描画0(are);
    				}
    				if (bod.Is頭頂_宇)
    				{
    					bod.大顎基接続.描画0(are);
    					bod.大顎基接続.描画1(are);
    					if (bod.Is顔面)
    					{
    						bod.顔面.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item107 in bod.角左接続)
    					{
    						item107.先描画(are);
    					}
    					foreach (角2 item108 in bod.角右接続)
    					{
    						item108.先描画(are);
    					}
    					bod.額接続.描画0(are);
    					bod.額接続.描画1(are);
    					bod.触覚左接続.描画0(are);
    					bod.触覚左接続.描画1(are);
    					bod.触覚右接続.描画0(are);
    					bod.触覚右接続.描画1(are);
    				}
    				else
    				{
    					if (bod.Is獣耳)
    					{
    						bod.獣耳左.描画0(are);
    						bod.獣耳右.描画0(are);
    					}
    					if (bod.Is頭頂)
    					{
    						bod.頭頂.描画0(are);
    					}
    					bod.植左接続.描画0(are);
    					bod.植右接続.描画0(are);
    					foreach (角2 item109 in bod.角左接続)
    					{
    						item109.先描画(are);
    					}
    					foreach (角2 item110 in bod.角右接続)
    					{
    						item110.先描画(are);
    					}
    					if (bod.Is虫角前)
    					{
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    					}
    					else
    					{
    						bod.額接続.描画0(are);
    						bod.額接続.描画1(are);
    						bod.触覚左接続.描画0(are);
    						bod.触覚左接続.描画1(are);
    						bod.触覚右接続.描画0(are);
    						bod.触覚右接続.描画1(are);
    						bod.大顎基接続.描画0(are);
    						bod.大顎基接続.描画1(are);
    						if (bod.Is顔面)
    						{
    							bod.顔面.描画0(are);
    						}
    					}
    				}
    				bod.顔触覚左接続.描画0(are);
    				bod.顔触覚左接続.描画1(are);
    				bod.顔触覚右接続.描画0(are);
    				bod.顔触覚右接続.描画1(are);
    				if (bod.Is頭頂_宇 || bod.Is顔面 || bod.Is額角 || bod.Is触覚)
    				{
    					bod.目隠帯.描画0(are);
    				}
    				if (bod.cb0 && !(bod.fi = bod.カーソル.Isフォーカス膣肛挿入))
    				{
    					bod.性器精液_人.描画0(are);
    					bod.飛沫_人.描画0(are);
    					bod.潮吹_小_人.描画0(are);
    					bod.潮吹_大_人.描画0(are);
    					bod.放尿_人.描画0(are);
    				}
    				if (bod.Is腕前 && bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    				{
    					bod.EI腕前.描画(are);
    				}
    				bod.上着B_クロス.描画0(are);
    				if (bod.Is半前)
    				{
    					bod.EI半前.描画(are);
    				}
    				bod.染み_人.湯気描画(are);
    				if (bod.cb0 && bod.カーソル.Is乳弄り)
    				{
    					bod.カーソル.描画2(Are);
    				}
    				bod.上着B_前掛け.前(are);
    				bod.ぶっかけ大.Draw(are);
    				bod.ぶっかけ小.Draw(are);
    				if (bod.cb1)
    				{
    					bod.カーソル.描画1(are);
    				}
    				if (bod.cb0 && bod.fi)
    				{
    					bod.性器精液_人.描画0(are);
    					bod.飛沫_人.描画0(are);
    					bod.潮吹_小_人.描画0(are);
    					bod.潮吹_大_人.描画0(are);
    					bod.放尿_人.描画0(are);
    				}
    			};
    			return;
    		}
    		Draw = delegate(RenderArea are)
    		{
    			bod.cb0 = bod.カーソル != null;
    			bod.cb1 = bod.cb0 && !bod.カーソル.コキ;
    			bod.染み_人.色更新();
    			bod.染み_人.描画0(are);
    			if (bod.IsChest)
    			{
    				bod.EIChest.描画(are);
    			}
    			if (bod.IsWaist)
    			{
    				bod.EIWaist.描画(are);
    			}
    			if (bod.Is頭頂_宇)
    			{
    				bod.頭頂後.描画0(are);
    			}
    			if (bod.Is髪)
    			{
    				bod.EI髪.描画(are);
    			}
    			if (bod.Is獣耳)
    			{
    				foreach (角2 item111 in bod.角左接続)
    				{
    					item111.根描画(are);
    				}
    				foreach (角2 item112 in bod.角右接続)
    				{
    					item112.根描画(are);
    				}
    			}
    			bod.肩左飛膜.描画0(are);
    			bod.肩右飛膜.描画0(are);
    			if (bod.腕左右前後)
    			{
    				if (bod.腕右前後_)
    				{
    					bod.LowerArm以降右.描画0(are);
    					bod.LowerArm以降右.描画1(are);
    				}
    				if (bod.腕左前後_)
    				{
    					bod.LowerArm以降左.描画0(are);
    					bod.LowerArm以降左.描画1(are);
    				}
    			}
    			else
    			{
    				if (bod.腕左前後_)
    				{
    					bod.LowerArm以降左.描画0(are);
    					bod.LowerArm以降左.描画1(are);
    				}
    				if (bod.腕右前後_)
    				{
    					bod.LowerArm以降右.描画0(are);
    					bod.LowerArm以降右.描画1(are);
    				}
    			}
    			bod.上着B_クロス後.描画0(are);
    			if (bod.Is半後)
    			{
    				bod.EI半後.描画(are);
    			}
    			if (bod.Is蜘尾)
    			{
    				bod.ThreadCum.描画0(are);
    			}
    			if (bod.cb0)
    			{
    				if (bod.カーソル.IsSub糸挿入)
    				{
    					bod.カーソル.描画糸(Are);
    				}
    				else if (bod.カーソル.Is糸挿入)
    				{
    					bod.カーソル.描画2(Are);
    				}
    			}
    			bod.耳左接続.描画0(are);
    			bod.耳右接続.描画0(are);
    			if (bod.肩左 != null)
    			{
    				bod.肩左.脇描画(are);
    			}
    			if (bod.肩右 != null)
    			{
    				bod.肩右.脇描画(are);
    			}
    			bod.Waist.描画0(are);
    			bod.Waist.描画1(are);
    			bod.Torso.描画0(are);
    			bod.Chest.描画0(are);
    			bod.Neck.描画0(are);
    			if (bod.肩左 != null)
    			{
    				bod.肩左.描画0(are);
    			}
    			if (bod.肩右 != null)
    			{
    				bod.肩右.描画0(are);
    			}
    			if (bod.Is半中1)
    			{
    				bod.EI半中1.描画(are);
    			}
    			if (bod.Is半中2)
    			{
    				bod.EI半中2.描画(are);
    			}
    			bod.PregnantBelly_人.描画0(are);
    			bod.PregnantBellyPlate_人.描画0(are);
    			bod.WaistSkin_人.描画0(are);
    			bod.TorsoPlate_人.描画0(are);
    			bod.胸腹板_人.描画0(are);
    			bod.TorsoSkin_人.描画0(are);
    			bod.胸肌_人.描画0(are);
    			bod.下着T_チューブ.描画0(are);
    			bod.下着T_クロス.描画0(are);
    			bod.下着T_ビキニ.描画0(are);
    			bod.下着T_マイクロ.描画0(are);
    			bod.下着T_ブラ.描画0(are);
    			bod.腕左.描画0(are);
    			bod.腕右.描画0(are);
    			bod.腕左.描画1(are);
    			bod.腕右.描画1(are);
    			if (bod.胸左右前後)
    			{
    				bod.乳房右.描画0(are);
    				bod.乳房左.描画0(are);
    			}
    			else
    			{
    				bod.乳房左.描画0(are);
    				bod.乳房右.描画0(are);
    			}
    			bod.ピアス左.描画0(are);
    			bod.ピアス右.描画0(are);
    			bod.LeftMilkSpray.描画0(are);
    			bod.RightMilkSpary.描画0(are);
    			bod.キャップ2左.描画0(are);
    			bod.キャップ2右.描画0(are);
    			bod.胸肌_人.描画1(are);
    			if (bod.汗掻き != null)
    			{
    				bod.汗掻き.Draw(are);
    			}
    			bod.頭.描画0(are);
    			if (bod.IsDualEyes && !bod.Is瞼宇)
    			{
    				bod.目左.描画0(are);
    				bod.瞼左.描画0(are);
    				bod.目右.描画0(are);
    				bod.瞼右.描画0(are);
    			}
    			bod.頭.描画1(are);
    			if (bod.IsSingleEye)
    			{
    				bod.単眼目.描画0(are);
    				bod.単眼瞼.描画0(are);
    			}
    			bod.紅潮.描画0(are);
    			bod.鼻肌.描画0(are);
    			bod.目尻影左.描画0(are);
    			bod.目尻影右.描画0(are);
    			bod.目傷左.描画0(are);
    			bod.目傷右.描画0(are);
    			bod.頬肌左.描画0(are);
    			bod.頬肌右.描画0(are);
    			if (bod.IsForeheadEye)
    			{
    				bod.額目.描画0(are);
    				bod.額瞼.描画0(are);
    			}
    			if (bod.IsCheekEyes)
    			{
    				bod.頬目左.描画0(are);
    				bod.頬目右.描画0(are);
    				bod.頬瞼左.描画0(are);
    				bod.頬瞼右.描画0(are);
    			}
    			if (bod.Is瞼宇)
    			{
    				bod.瞼左.描画0(are);
    				bod.瞼右.描画0(are);
    			}
    			bod.LeftDrool.描画0(are);
    			bod.RightDrool.描画0(are);
    			bod.口.描画0(are);
    			if (bod.鼻描画)
    			{
    				bod.鼻.描画0(are);
    				bod.LeftNoseDrip.描画0(are);
    				bod.RightNoseDrip.描画0(are);
    			}
    			bod.頭.描画2(are);
    			bod.玉口枷.描画0(are);
    			bod.BaseHair.描画0(are);
    			bod.横髪左.描画0(are);
    			bod.横髪右.描画0(are);
    			bod.頬左接続.描画0(are);
    			bod.頬左接続.描画1(are);
    			bod.頬右接続.描画0(are);
    			bod.頬右接続.描画1(are);
    			bod.頬肌左.描画1(are);
    			bod.頬肌右.描画1(are);
    			if (bod.涙描画)
    			{
    				bod.LeftTear.描画0(are);
    				bod.RightTear.描画0(are);
    			}
    			if (!bod.Is頭頂_宇 && !bod.Is顔面 && !bod.Is額角 && !bod.Is触覚)
    			{
    				bod.目隠帯.描画0(are);
    			}
    			if (bod.Is腕前 && !bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    			{
    				bod.EI腕前.描画(are);
    			}
    			if (bod.Is腿魚 && bod.Is腿)
    			{
    				bod.EI腿.描画(are);
    			}
    			bod.Anus_人.描画0(are);
    			bod.肛門精液_人.描画0(are);
    			if (bod.cb1)
    			{
    				bod.カーソル.描画肛(are);
    			}
    			bod.VaginaOrigin_人.描画0(are);
    			if (bod.XRay_表示 && bod.cb1)
    			{
    				bod.カーソル.描画0(are);
    			}
    			bod.InternalSemen_人.描画0(are);
    			bod.XRay_人.描画0(are);
    			bod.性器_人.描画0(are);
    			if (!bod.XRay_表示 && bod.cb1)
    			{
    				bod.カーソル.描画0(are);
    			}
    			bod.ピアス.描画0(are);
    			bod.下着T_チューブ.描画1(are);
    			bod.下着T_クロス.描画1(are);
    			bod.下着T_ビキニ.描画1(are);
    			bod.下着T_マイクロ.描画1(are);
    			bod.下着T_ブラ.描画1(are);
    			bod.下着乳首左.描画0(are);
    			bod.下着乳首右.描画0(are);
    			bod.キャップ1.描画0(are);
    			bod.下着B_ノーマル.描画0(are);
    			bod.下着B_マイクロ.描画0(are);
    			bod.下着B_ノーマル.描画1(are);
    			bod.下着B_マイクロ.描画1(are);
    			bod.下着陰核.描画0(are);
    			bod.上着M_ドレス.描画0(are);
    			bod.上着T_ドレス.描画0(are);
    			if (!bod.Is腿人)
    			{
    				bod.上着B_前掛け.描画0(are);
    				bod.上着B_クロス.描画0(are);
    			}
    			if (bod.Is腿人)
    			{
    				bod.上着B_前掛け.描画0(are);
    			}
    			if (bod.胸毛_人 != null)
    			{
    				bod.胸毛_人.描画0(are);
    			}
    			bod.Tounge.描画0(are);
    			bod.MouthCum.描画0(are);
    			bod.咳.描画0(are);
    			bod.呼気.描画0(are);
    			if (bod.cb0 && bod.カーソル.コキ)
    			{
    				bod.カーソル.描画0(are);
    				bod.カーソル.描画1(are);
    			}
    			bod.前髪.描画0(are);
    			if (!bod.Is獣耳)
    			{
    				foreach (角2 item113 in bod.角左接続)
    				{
    					item113.根描画(are);
    				}
    				foreach (角2 item114 in bod.角右接続)
    				{
    					item114.根描画(are);
    				}
    			}
    			if (bod.Is単眉)
    			{
    				bod.単眼眉.描画0(are);
    			}
    			if (bod.Is双眉)
    			{
    				bod.眉左.描画0(are);
    				bod.眉右.描画0(are);
    			}
    			if (bod.Is頭頂_宇)
    			{
    				bod.大顎基接続.描画0(are);
    				bod.大顎基接続.描画1(are);
    				if (bod.Is顔面)
    				{
    					bod.顔面.描画0(are);
    				}
    				if (bod.Is頭頂)
    				{
    					bod.頭頂.描画0(are);
    				}
    				if (bod.Is獣耳)
    				{
    					bod.獣耳左.描画0(are);
    					bod.獣耳右.描画0(are);
    				}
    				bod.植左接続.描画0(are);
    				bod.植右接続.描画0(are);
    				foreach (角2 item115 in bod.角左接続)
    				{
    					item115.先描画(are);
    				}
    				foreach (角2 item116 in bod.角右接続)
    				{
    					item116.先描画(are);
    				}
    				bod.額接続.描画0(are);
    				bod.額接続.描画1(are);
    				bod.触覚左接続.描画0(are);
    				bod.触覚左接続.描画1(are);
    				bod.触覚右接続.描画0(are);
    				bod.触覚右接続.描画1(are);
    			}
    			else
    			{
    				if (bod.Is獣耳)
    				{
    					bod.獣耳左.描画0(are);
    					bod.獣耳右.描画0(are);
    				}
    				if (bod.Is頭頂)
    				{
    					bod.頭頂.描画0(are);
    				}
    				bod.植左接続.描画0(are);
    				bod.植右接続.描画0(are);
    				foreach (角2 item117 in bod.角左接続)
    				{
    					item117.先描画(are);
    				}
    				foreach (角2 item118 in bod.角右接続)
    				{
    					item118.先描画(are);
    				}
    				if (bod.Is虫角前)
    				{
    					bod.触覚左接続.描画0(are);
    					bod.触覚左接続.描画1(are);
    					bod.触覚右接続.描画0(are);
    					bod.触覚右接続.描画1(are);
    					bod.大顎基接続.描画0(are);
    					bod.大顎基接続.描画1(are);
    					if (bod.Is顔面)
    					{
    						bod.顔面.描画0(are);
    					}
    					bod.額接続.描画0(are);
    					bod.額接続.描画1(are);
    				}
    				else
    				{
    					bod.額接続.描画0(are);
    					bod.額接続.描画1(are);
    					bod.触覚左接続.描画0(are);
    					bod.触覚左接続.描画1(are);
    					bod.触覚右接続.描画0(are);
    					bod.触覚右接続.描画1(are);
    					bod.大顎基接続.描画0(are);
    					bod.大顎基接続.描画1(are);
    					if (bod.Is顔面)
    					{
    						bod.顔面.描画0(are);
    					}
    				}
    			}
    			bod.顔触覚左接続.描画0(are);
    			bod.顔触覚左接続.描画1(are);
    			bod.顔触覚右接続.描画0(are);
    			bod.顔触覚右接続.描画1(are);
    			if (bod.Is頭頂_宇 || bod.Is顔面 || bod.Is額角 || bod.Is触覚)
    			{
    				bod.目隠帯.描画0(are);
    			}
    			if (!bod.Is腿魚 && bod.Is腿 && bod.腿開きi != 4)
    			{
    				bod.EI腿.描画(are);
    			}
    			if (bod.Is腕前 && bod.Is最前腕人 && (!bod.腕左前後_ || !bod.腕右前後_))
    			{
    				bod.EI腕前.描画(are);
    			}
    			if (!bod.Is腿魚 && bod.Is腿 && bod.腿開きi == 4)
    			{
    				bod.EI腿.描画(are);
    			}
    			if (bod.cb0 && !(bod.fi = bod.カーソル.Isフォーカス膣肛挿入))
    			{
    				bod.性器精液_人.描画0(are);
    				bod.飛沫_人.描画0(are);
    				bod.潮吹_小_人.描画0(are);
    				bod.潮吹_大_人.描画0(are);
    				bod.放尿_人.描画0(are);
    			}
    			if (bod.Is腿人)
    			{
    				bod.上着B_クロス.描画0(are);
    			}
    			if (bod.Is半前)
    			{
    				bod.EI半前.描画(are);
    			}
    			bod.染み_人.湯気描画(are);
    			if (bod.cb0 && bod.カーソル.Is乳弄り)
    			{
    				bod.カーソル.描画2(Are);
    			}
    			bod.上着B_前掛け.前(are);
    			bod.ぶっかけ大.Draw(are);
    			bod.ぶっかけ小.Draw(are);
    			if (bod.cb1)
    			{
    				bod.カーソル.描画1(are);
    			}
    			if (bod.cb0 && bod.fi)
    			{
    				bod.性器精液_人.描画0(are);
    				bod.飛沫_人.描画0(are);
    				bod.潮吹_小_人.描画0(are);
    				bod.潮吹_大_人.描画0(are);
    				bod.放尿_人.描画0(are);
    			}
    		};
    	}

    	public void 変動ステート更新()
    	{
    		Cha.CharacterData.現乳首 = Cha.CharacterData.Sesnsitivities[ContactType.Milk];
    		Cha.CharacterData.現陰核 = Cha.CharacterData.Sesnsitivities[ContactType.Nucleus];
    		Cha.CharacterData.現性器 = Cha.CharacterData.Sesnsitivities[ContactType.Vagina].Max(Cha.CharacterData.Sesnsitivities[ContactType.Sex]);
    		Cha.CharacterData.現肛門 = Cha.CharacterData.Sesnsitivities[ContactType.Anal];
    		double バスト = (Cha.CharacterData.最乳房 - 0.3 * Cha.CharacterData.現乳房.Inverse()).Clamp(0.0, 1.0);
    		乳房左.バスト = バスト;
    		乳房右.バスト = バスト;
    		下着乳首左.バスト = バスト;
    		下着乳首右.バスト = バスト;
    		下着T_チューブ.バスト = バスト;
    		下着T_クロス.バスト = バスト;
    		下着T_ビキニ.バスト = バスト;
    		下着T_マイクロ.バスト = バスト;
    		下着T_ブラ.バスト = バスト;
    		上着T_ドレス.バスト = バスト;
    		double num = 0.65 * Cha.CharacterData.最乳首 * Cha.CharacterData.現乳首;
    		乳房左.X0Y0_乳首.SetSizeBase(nsb1 + num);
    		乳房左.X0Y0_乳輪.SetSizeBase(nsb2 + num);
    		乳房左.X0Y1_乳首.SetSizeBase(nsb1 + num);
    		乳房左.X0Y1_乳輪.SetSizeBase(nsb2 + num);
    		乳房左.X0Y2_乳首.SetSizeBase(nsb1 + num);
    		乳房左.X0Y2_乳輪.SetSizeBase(nsb2 + num);
    		乳房左.X0Y3_乳首.SetSizeBase(nsb1 + num);
    		乳房左.X0Y3_乳輪.SetSizeBase(nsb2 + num);
    		乳房左.X0Y4_乳首.SetSizeBase(nsb1 + num);
    		乳房左.X0Y4_乳輪.SetSizeBase(nsb2 + num);
    		乳房右.X0Y0_乳首.SetSizeBase(nsb1 + num);
    		乳房右.X0Y0_乳輪.SetSizeBase(nsb2 + num);
    		乳房右.X0Y1_乳首.SetSizeBase(nsb1 + num);
    		乳房右.X0Y1_乳輪.SetSizeBase(nsb2 + num);
    		乳房右.X0Y2_乳首.SetSizeBase(nsb1 + num);
    		乳房右.X0Y2_乳輪.SetSizeBase(nsb2 + num);
    		乳房右.X0Y3_乳首.SetSizeBase(nsb1 + num);
    		乳房右.X0Y3_乳輪.SetSizeBase(nsb2 + num);
    		乳房右.X0Y4_乳首.SetSizeBase(nsb1 + num);
    		乳房右.X0Y4_乳輪.SetSizeBase(nsb2 + num);
    		乳房左.乳首CD.不透明度 = Cha.CharacterData.素乳首濃度 + Cha.CharacterData.最乳首濃度 * Cha.CharacterData.現乳首;
    		乳房左.乳輪CD.不透明度 = Cha.CharacterData.素乳首濃度 + Cha.CharacterData.最乳首濃度 * Cha.CharacterData.現乳首;
    		乳房右.乳首CD.不透明度 = Cha.CharacterData.素乳首濃度 + Cha.CharacterData.最乳首濃度 * Cha.CharacterData.現乳首;
    		乳房右.乳輪CD.不透明度 = Cha.CharacterData.素乳首濃度 + Cha.CharacterData.最乳首濃度 * Cha.CharacterData.現乳首;
    		num = 0.65 * Cha.CharacterData.最陰核 * Cha.CharacterData.現陰核;
    		if (Is獣)
    		{
    			性器_獣.X0Y0_陰核.SetSizeBase(csb + num);
    			性器_獣.X0Y1_陰核.SetSizeBase(csb + num);
    			性器_獣.X0Y2_陰核.SetSizeBase(csb + num);
    			性器_獣.X0Y3_陰核.SetSizeBase(csb + num);
    			性器_獣.X0Y4_陰核.SetSizeBase(csb + num);
    			性器_獣.小陰唇CD.不透明度 = Cha.CharacterData.素性器濃度 + Cha.CharacterData.最性器濃度 * Cha.CharacterData.現性器;
    			性器_獣.性器基CD.不透明度 = Cha.CharacterData.素性器濃度 + Cha.CharacterData.最性器濃度 * Cha.CharacterData.現性器;
    			Anus_獣.Anus3CD.不透明度 = Cha.CharacterData.素肛門濃度 + Cha.CharacterData.最肛門濃度 * Cha.CharacterData.現肛門;
    			num = 0.3 * Cha.CharacterData.現肛門;
    			Anus_獣.X0Y0_Anus2.SetSizeBase(asb1 + num);
    			Anus_獣.X0Y0_Anus3.SetSizeBase(asb2 + num);
    		}
    		else
    		{
    			性器_人.X0Y0_陰核.SetSizeBase(csb + num);
    			性器_人.X0Y1_陰核.SetSizeBase(csb + num);
    			性器_人.X0Y2_陰核.SetSizeBase(csb + num);
    			性器_人.X0Y3_陰核.SetSizeBase(csb + num);
    			性器_人.X0Y4_陰核.SetSizeBase(csb + num);
    			性器_人.小陰唇CD.不透明度 = Cha.CharacterData.素性器濃度 + Cha.CharacterData.最性器濃度 * Cha.CharacterData.現性器;
    			性器_人.性器基CD.不透明度 = Cha.CharacterData.素性器濃度 + Cha.CharacterData.最性器濃度 * Cha.CharacterData.現性器;
    			Anus_人.Anus3CD.不透明度 = Cha.CharacterData.素肛門濃度 + Cha.CharacterData.最肛門濃度 * Cha.CharacterData.現肛門;
    			num = 0.3 * Cha.CharacterData.現肛門;
    			Anus_人.X0Y0_Anus2.SetSizeBase(asb1 + num);
    			Anus_人.X0Y0_Anus3.SetSizeBase(asb2 + num);
    		}
    		WaistSkin_人.陰毛CD.不透明度 = Cha.CharacterData.現陰毛 * Cha.CharacterData.最陰毛濃度;
    		WaistSkin_人.獣性_獣毛CD.不透明度 = Cha.CharacterData.現陰毛;
    		WaistSkin_人.陰毛_ハートCD.不透明度 = Cha.CharacterData.現陰毛.Inverse() * Cha.CharacterData.最陰毛濃度;
    	}

    	public Element GetHitEle(Color hc)
    	{
    		return EnumAllEle().FirstOrDefault((Element e) => e.Body.IsHit(ref hc));
    	}

    	public bool IsHit(Color hc)
    	{
    		return EnumAllEle().Any((Element e) => e.Body.IsHit(ref hc));
    	}

    	public IEnumerable<Element> EnumAllEle()
    	{
    		return Elements.Concat(from e in Elements.GetEles<UpperArm_蝙>()
    			select e.飛膜).Concat(from e in Elements.GetEles<手_蝙>()
    			select e.飛膜).Concat(from e in Elements.GetEles<大顎基>()
    			select e.大顎上);
    	}

    	public void Join()
    	{
    		Element[] array = Elements;
    		for (int i = 0; i < array.Length; i++)
    		{
    			array[i].接続PA();
    		}
    		foreach (蝙通常 item in 蝙通常)
    		{
    			item.接続();
    		}
    		if (頭色更新 != null)
    		{
    			頭色更新.色更新();
    		}
    		if (ドレス色更新 != null)
    		{
    			ドレス色更新.色更新();
    		}
    		if (鯨色更新 != null)
    		{
    			foreach (鯨色更新 item2 in 鯨色更新)
    			{
    				item2.色更新();
    			}
    		}
    		if (飛膜色更新 != null)
    		{
    			foreach (飛膜色更新 item3 in 飛膜色更新)
    			{
    				item3.色更新();
    			}
    		}
    		if (色更新 != null)
    		{
    			foreach (Element item4 in 色更新)
    			{
    				item4.色更新();
    			}
    		}
    		染み_人.位置B = Waist.位置;
    		染み_人.Body.JoinP();
    		if (Is獣)
    		{
    			染み_獣.位置B = Waist_獣.位置;
    			染み_獣.Body.JoinP();
    		}
    		Waist_人y = Waist.Yi;
    		if (Is獣)
    		{
    			Waist_獣y = Waist_獣.Yi;
    		}
    	}

    	public void Update()
    	{
    		foreach (ElementInstance ei in eis)
    		{
    			ei.Updatef = true;
    		}
    	}

    	public bool Contains(Element e)
    	{
    		return eis.Any((ElementInstance f) => f.ElesH.Contains(e));
    	}

    	public bool IsUpdate(Element e)
    	{
    		return eis.Any((ElementInstance f) => f.IsUpdate(e));
    	}

    	public List<Element> Inserts(Element io, int i, Element e)
    	{
    		int num;
    		if ((num = 後髪接続.IndexOf(io)) > -1)
    		{
    			後髪接続.Insert((num + i).Clamp(0, 後髪接続.Count), e);
    			return 後髪接続;
    		}
    		if ((num = 額接続.IndexOf(io)) > -1)
    		{
    			額接続.Insert((num + i).Clamp(0, 額接続.Count), e);
    			return 額接続;
    		}
    		if ((num = 耳左接続.IndexOf(io)) > -1)
    		{
    			耳左接続.Insert((num + i).Clamp(0, 耳左接続.Count), e);
    			return 耳左接続;
    		}
    		if ((num = 耳右接続.IndexOf(io)) > -1)
    		{
    			耳右接続.Insert((num + i).Clamp(0, 耳右接続.Count), e);
    			return 耳右接続;
    		}
    		if ((num = 頬左接続.IndexOf(io)) > -1)
    		{
    			頬左接続.Insert((num + i).Clamp(0, 頬左接続.Count), e);
    			return 頬左接続;
    		}
    		if ((num = 頬右接続.IndexOf(io)) > -1)
    		{
    			頬右接続.Insert((num + i).Clamp(0, 頬右接続.Count), e);
    			return 頬右接続;
    		}
    		if ((num = 頭頂左後接続.IndexOf(io)) > -1)
    		{
    			頭頂左後接続.Insert((num + i).Clamp(0, 頭頂左後接続.Count), e);
    			return 頭頂左後接続;
    		}
    		if ((num = 頭頂右後接続.IndexOf(io)) > -1)
    		{
    			頭頂右後接続.Insert((num + i).Clamp(0, 頭頂右後接続.Count), e);
    			return 頭頂右後接続;
    		}
    		if ((num = 植左接続.IndexOf(io)) > -1)
    		{
    			植左接続.Insert((num + i).Clamp(0, 植左接続.Count), e);
    			return 植左接続;
    		}
    		if ((num = 植右接続.IndexOf(io)) > -1)
    		{
    			植右接続.Insert((num + i).Clamp(0, 植右接続.Count), e);
    			return 植右接続;
    		}
    		if ((num = 触覚左接続.IndexOf(io)) > -1)
    		{
    			触覚左接続.Insert((num + i).Clamp(0, 触覚左接続.Count), e);
    			return 触覚左接続;
    		}
    		if ((num = 触覚右接続.IndexOf(io)) > -1)
    		{
    			触覚右接続.Insert((num + i).Clamp(0, 触覚右接続.Count), e);
    			return 触覚右接続;
    		}
    		if ((num = 顔触覚左接続.IndexOf(io)) > -1)
    		{
    			顔触覚左接続.Insert((num + i).Clamp(0, 顔触覚左接続.Count), e);
    			return 顔触覚左接続;
    		}
    		if ((num = 顔触覚右接続.IndexOf(io)) > -1)
    		{
    			顔触覚右接続.Insert((num + i).Clamp(0, 顔触覚右接続.Count), e);
    			return 顔触覚右接続;
    		}
    		if ((num = 大顎基接続.IndexOf(io)) > -1)
    		{
    			大顎基接続.Insert((num + i).Clamp(0, 大顎基接続.Count), e);
    			return 大顎基接続;
    		}
    		if ((num = 腕左.IndexOf(io)) > -1)
    		{
    			腕左.Insert((num + i).Clamp(0, 腕左.Count), e);
    			return 腕左;
    		}
    		if ((num = 腕右.IndexOf(io)) > -1)
    		{
    			腕右.Insert((num + i).Clamp(0, 腕右.Count), e);
    			return 腕右;
    		}
    		if ((num = 胸上左接続.IndexOf(io)) > -1)
    		{
    			胸上左接続.Insert((num + i).Clamp(0, 胸上左接続.Count), e);
    			return 胸上左接続;
    		}
    		if ((num = 胸上右接続.IndexOf(io)) > -1)
    		{
    			胸上右接続.Insert((num + i).Clamp(0, 胸上右接続.Count), e);
    			return 胸上右接続;
    		}
    		if ((num = 胸下左接続.IndexOf(io)) > -1)
    		{
    			胸下左接続.Insert((num + i).Clamp(0, 胸下左接続.Count), e);
    			return 胸下左接続;
    		}
    		if ((num = 胸下右接続.IndexOf(io)) > -1)
    		{
    			胸下右接続.Insert((num + i).Clamp(0, 胸下右接続.Count), e);
    			return 胸下右接続;
    		}
    		if ((num = 胴後左接続.IndexOf(io)) > -1)
    		{
    			胴後左接続.Insert((num + i).Clamp(0, 胴後左接続.Count), e);
    			return 胴後左接続;
    		}
    		if ((num = 胴後右接続.IndexOf(io)) > -1)
    		{
    			胴後右接続.Insert((num + i).Clamp(0, 胴後右接続.Count), e);
    			return 胴後右接続;
    		}
    		if ((num = 腰後左接続.IndexOf(io)) > -1)
    		{
    			腰後左接続.Insert((num + i).Clamp(0, 腰後左接続.Count), e);
    			return 腰後左接続;
    		}
    		if ((num = 腰後右接続.IndexOf(io)) > -1)
    		{
    			腰後右接続.Insert((num + i).Clamp(0, 腰後右接続.Count), e);
    			return 腰後右接続;
    		}
    		if ((num = 背中接続.IndexOf(io)) > -1)
    		{
    			背中接続.Insert((num + i).Clamp(0, 背中接続.Count), e);
    			return 背中接続;
    		}
    		if ((num = 腿左接続.IndexOf(io)) > -1)
    		{
    			腿左接続.Insert((num + i).Clamp(0, 腿左接続.Count), e);
    			return 腿左接続;
    		}
    		if ((num = 腿右接続.IndexOf(io)) > -1)
    		{
    			腿右接続.Insert((num + i).Clamp(0, 腿右接続.Count), e);
    			return 腿右接続;
    		}
    		if ((num = 尾接続.IndexOf(io)) > -1)
    		{
    			尾接続.Insert((num + i).Clamp(0, 尾接続.Count), e);
    			return 尾接続;
    		}
    		if ((num = 半身後接続.IndexOf(io)) > -1)
    		{
    			半身後接続.Insert((num + i).Clamp(0, 半身後接続.Count), e);
    			return 半身後接続;
    		}
    		if ((num = 半身中1接続.IndexOf(io)) > -1)
    		{
    			半身中1接続.Insert((num + i).Clamp(0, 半身中1接続.Count), e);
    			return 半身中1接続;
    		}
    		if ((num = 半身前接続.IndexOf(io)) > -1)
    		{
    			半身前接続.Insert((num + i).Clamp(0, 半身前接続.Count), e);
    			return 半身前接続;
    		}
    		List<Element>[] array = 後腕左s;
    		foreach (List<Element> list in array)
    		{
    			if ((num = list.IndexOf(io)) > -1)
    			{
    				list.Insert((num + i).Clamp(0, list.Count), e);
    				return list;
    			}
    		}
    		array = 後腕右s;
    		foreach (List<Element> list2 in array)
    		{
    			if ((num = list2.IndexOf(io)) > -1)
    			{
    				list2.Insert((num + i).Clamp(0, list2.Count), e);
    				return list2;
    			}
    		}
    		return null;
    	}

    	public キスマーク Addキスマーク(Vector2D cp, Color hc)
    	{
    		Element he = GetHitEle(hc);
    		スタンプK[] array = キスマーク;
    		for (int i = 0; i < array.Length; i++)
    		{
    			キスマーク result;
    			if ((result = array[i].Add(cp, hc, he)) != null)
    			{
    				ElementInstance elementInstance = eis.FirstOrDefault((ElementInstance e) => e.ElesH.Contains(he));
    				if (elementInstance != null)
    				{
    					elementInstance.Updatef = true;
    				}
    				return result;
    			}
    		}
    		return null;
    	}

    	public void Add鞭痕(Vector2D cp, Color hc)
    	{
    		Element he = GetHitEle(hc);
    		if (he is LowerArm || he is Neck)
    		{
    			return;
    		}
    		スタンプW[] array = 鞭痕;
    		for (int i = 0; i < array.Length; i++)
    		{
    			if (array[i].Add(cp, hc, he))
    			{
    				ElementInstance elementInstance = eis.FirstOrDefault((ElementInstance e) => e.ElesH.Contains(he));
    				if (elementInstance != null)
    				{
    					elementInstance.Updatef = true;
    				}
    				break;
    			}
    		}
    	}

    	public void Addぶっかけ(Vector2D cp, Color hc)
    	{
    		if (Rng.XS.NextBool())
    		{
    			ぶっかけ小.Add(cp, hc, ぶっかけr);
    		}
    		else
    		{
    			ぶっかけ大.Add(cp, hc, ぶっかけr);
    		}
    	}

    	public void Dispose()
    	{
    		スタンプK[] array = キスマーク;
    		for (int i = 0; i < array.Length; i++)
    		{
    			array[i].Dispose();
    		}
    		スタンプW[] array2 = 鞭痕;
    		for (int i = 0; i < array2.Length; i++)
    		{
    			array2[i].Dispose();
    		}
    		Element[] array3 = Elements;
    		for (int i = 0; i < array3.Length; i++)
    		{
    			array3[i].Dispose();
    		}
    		foreach (ElementInstance ei in eis)
    		{
    			ei.Dispose();
    		}
    		if (汗掻き != null)
    		{
    			汗掻き.Dispose();
    		}
    		if (ぶっかけ小 != null)
    		{
    			ぶっかけ小.Dispose();
    		}
    		if (ぶっかけ大 != null)
    		{
    			ぶっかけ大.Dispose();
    		}
    		if (染み_人 != null)
    		{
    			染み_人.Dispose();
    		}
    		if (染み_獣 != null)
    		{
    			染み_獣.Dispose();
    		}
    	}

    	public void 描画(RenderArea Are)
    	{
    		cb0 = カーソル != null;
    		cb1 = cb0 && !カーソル.コキ;
    		Element[] array = Elements;
    		for (int i = 0; i < array.Length; i++)
    		{
    			array[i].接続PA();
    		}
    		foreach (蝙通常 item in 蝙通常)
    		{
    			if (!Contains(item.UpperArm) || IsUpdate(item.UpperArm))
    			{
    				item.接続();
    			}
    		}
    		if (Is蜘尾)
    		{
    			ThreadCum.接続P();
    		}
    		if (cb0)
    		{
    			カーソル.Set挿入Position();
    		}
    		頭色更新.色更新();
    		ドレス色更新.色更新();
    		foreach (鯨色更新 item2 in 鯨色更新)
    		{
    			if (!Contains(item2.長物) || IsUpdate(item2.長物))
    			{
    				item2.色更新();
    			}
    		}
    		foreach (飛膜色更新 item3 in 飛膜色更新)
    		{
    			if (!Contains(item3.根) || IsUpdate(item3.根))
    			{
    				item3.色更新();
    			}
    		}
    		foreach (Element item4 in 色更新)
    		{
    			if (!Contains(item4) || IsUpdate(item4))
    			{
    				item4.色更新();
    			}
    		}
    		foreach (ElementInstance ei in eis)
    		{
    			ei.Update();
    		}
    		Draw(Are);
    	}

    	private void Set人肌色(Color c)
    	{
    		Color col = 頭.HeadCD.色.Col1;
    		Color col2 = 頭.HeadCD.色.Col2;
    		ColorHelper.GetSkinGrad(ref c, out var ret);
    		ret.Col1 = col;
    		ret.GetRep(out var ret2);
    		foreach (Element item in EnumAllEle())
    		{
    			foreach (FieldInfo item2 in from f in item.GetType().GetFields()
    				where f.FieldType.ToString() == GlobalState.cdt
    				select f)
    			{
    				ColorD colorD = (ColorD)item2.GetValue(item);
    				if (colorD.色.Col1 == col && colorD.色.Col2 == col2)
    				{
    					colorD.色 = ret;
    				}
    				else if (colorD.色.Col1 == col2 && colorD.色.Col2 == col)
    				{
    					colorD.色 = ret2;
    				}
    			}
    		}
    	}

    	public bool Is口腔()
    	{
    		return 口腔位置.DistanceSquared(Cha.CursorPosition) < r17;
    	}

    	public bool Is陰核()
    	{
    		return 陰核位置.DistanceSquared(Cha.CursorPosition) < r10;
    	}

    	public bool Is乳首()
    	{
    		if (!(乳首左位置.DistanceSquared(Cha.CursorPosition) < r10))
    		{
    			return 乳首右位置.DistanceSquared(Cha.CursorPosition) < r10;
    		}
    		return true;
    	}

    	public bool Is膣口()
    	{
    		return 膣口位置.DistanceSquared(Cha.CursorPosition) < r10;
    	}

    	public bool Is胸部()
    	{
    		return 胸部位置.DistanceSquared(Cha.CursorPosition) < r17;
    	}

    	public bool Is局部()
    	{
    		return 局部位置.DistanceSquared(Cha.CursorPosition) < r35;
    	}

    	public bool Isくぱぁ()
    	{
    		if (Is蛇)
    		{
    			return 蛇.くぱぁ >= 0.5;
    		}
    		if (Is蠍)
    		{
    			return 蠍.くぱぁ >= 0.5;
    		}
    		return true;
    	}

    	public void 腕前後(bool 右, int n, bool value)
    	{
    		if (右)
    		{
    			腕右前後(n, value);
    		}
    		else
    		{
    			腕左前後(n, value);
    		}
    	}

    	private void 腕左前後(int n, bool value)
    	{
    		if (nsl[n] == value)
    		{
    			return;
    		}
    		nsl[n] = value;
    		if (value)
    		{
    			if (n == 0)
    			{
    				if (Is最前腕人)
    				{
    					腕左前後_ = value;
    				}
    			}
    			else if (後腕左s.Length != 0)
    			{
    				n = 後腕左s.Length - n;
    				Element item = 後腕左s[n][1];
    				後腕左s[n].RemoveAt(1);
    				後腕左s[n].Add(item);
    			}
    		}
    		else if (n == 0)
    		{
    			if (Is最前腕人)
    			{
    				腕左前後_ = value;
    			}
    		}
    		else if (後腕左s.Length != 0)
    		{
    			n = 後腕左s.Length - n;
    			Element item2 = 後腕左s[n].Last();
    			後腕左s[n].RemoveAt(後腕左s[n].Count - 1);
    			後腕左s[n].Insert(1, item2);
    		}
    	}

    	private void 腕右前後(int n, bool value)
    	{
    		if (nsr[n] == value)
    		{
    			return;
    		}
    		nsr[n] = value;
    		if (value)
    		{
    			if (n == 0)
    			{
    				if (Is最前腕人)
    				{
    					腕右前後_ = value;
    				}
    			}
    			else if (後腕右s.Length != 0)
    			{
    				n = 後腕左s.Length - n;
    				Element item = 後腕右s[n][1];
    				後腕右s[n].RemoveAt(1);
    				後腕右s[n].Add(item);
    			}
    		}
    		else if (n == 0)
    		{
    			if (Is最前腕人)
    			{
    				腕右前後_ = value;
    			}
    		}
    		else if (後腕右s.Length != 0)
    		{
    			n = 後腕左s.Length - n;
    			Element item2 = 後腕右s[n].Last();
    			後腕右s[n].RemoveAt(後腕右s[n].Count - 1);
    			後腕右s[n].Insert(1, item2);
    		}
    	}

    	private void 腰振り_人()
    	{
    		Torso.X0Y0_筋肉_筋肉左.SetPositionCont(DataConsts.Vec2DUnitY * (Waist.Yv * -0.004));
    		Torso.X0Y0_筋肉_筋肉右.SetPositionCont(DataConsts.Vec2DUnitY * (Waist.Yv * -0.004));
    		TorsoPlate_人.X0Y0_虫性_腹板.SetPositionCont(DataConsts.Vec2DUnitY * (Waist.Yv * -0.002));
    		TorsoSkin_人.Body.SetSizeYCont(0.85 + (1.0 - Waist.Yv) * 0.15);
    	}

    	private void 腰振り_獣()
    	{
    		Torso_獣.X0Y0_筋肉_筋肉左.SetPositionCont(DataConsts.Vec2DUnitY * (Waist_獣.Yv * -0.004));
    		Torso_獣.X0Y0_筋肉_筋肉右.SetPositionCont(DataConsts.Vec2DUnitY * (Waist_獣.Yv * -0.004));
    		TorsoSkin_獣.Body.SetSizeYCont(0.85 + (1.0 - Waist_獣.Yv) * 0.15);
    		if (EI半中1 != null)
    		{
    			EI半中1.Updatef = true;
    		}
    	}

    	public void SetWaist()
    	{
    		if (Is獣)
    		{
    			if (捲り判定0)
    			{
    				腰振り_人i = 4;
    			}
    			腰振り_獣i = 0;
    		}
    		else if (Is蜘 || Is蠍)
    		{
    			腰振り_人i = 4;
    		}
    		else
    		{
    			腰振り_人i = 0;
    		}
    	}

    	public void 腿Update()
    	{
    		int yi = ((左腿開きi > 0 || 右腿開きi > 0) ? 1 : 0);
    		if (捲り判定0)
    		{
    			上着B_クロス.Yi = yi;
    		}
    		if (捲り判定1)
    		{
    			上着B_前掛け.Yi = yi;
    		}
    		if (EI腿 != null)
    		{
    			EI腿.Updatef = true;
    		}
    	}

    	private void Set表示(object e, object i)
    	{
    		Type type = e.GetType();
    		foreach (FieldInfo item in from e_ in i.GetType().GetFields()
    			where e_.FieldType.ToString() == GlobalState.bt
    			select e_)
    		{
    			type.GetProperty(item.Name).SetValue(e, item.GetValue(i), null);
    		}
    	}

    	public void 脱衣()
    	{
    		Set後髪髪留 = GlobalState.髪留2初期化;
    		Set横髪髪留 = GlobalState.髪留2初期化;
    		Set玉口枷 = GlobalState.玉口枷初期化;
    		Set目隠帯 = GlobalState.目隠帯初期化;
    		Setピアス = GlobalState.ピアス初期化;
    		Setピアス左 = GlobalState.ピアス初期化;
    		Setピアス右 = GlobalState.ピアス初期化;
    		Setキャップ1 = GlobalState.キャップ初期化;
    		Setキャップ2左 = GlobalState.キャップ初期化;
    		Setキャップ2右 = GlobalState.キャップ初期化;
    		Setドレス首 = GlobalState.ドレス首初期化;
    		Set下着T_チューブ = GlobalState.下着T_チューブ初期化;
    		Set下着T_クロス = GlobalState.下着T_クロス初期化;
    		Set下着T_ビキニ = GlobalState.下着T_ビキニ初期化;
    		Set下着T_マイクロ = GlobalState.下着T_マイクロ初期化;
    		Set下着T_ブラ = GlobalState.下着T_ブラ初期化;
    		Set下着B_ノーマル = GlobalState.下着B_ノーマル初期化;
    		Set下着B_マイクロ = GlobalState.下着B_マイクロ初期化;
    		Setドレス = GlobalState.ドレス初期化;
    		Set上着B_クロス = GlobalState.上着B_クロス初期化;
    		Set上着B_前掛け = GlobalState.上着B_前掛け初期化;
    		Setブーツ = GlobalState.ブーツ初期化;
    	}

    	public void 胸施術()
    	{
    		乳房左.虫性_甲殻_表示 = false;
    		乳房右.虫性_甲殻_表示 = false;
    	}

    	public void 股施術()
    	{
    		if (Is蛇)
    		{
    			蛇.ガード = false;
    			蛇.くぱぁ = 1.0;
    			EI半中1.Updatef = true;
    		}
    		else if (Is蠍)
    		{
    			蠍.生殖口蓋左_表示 = false;
    			蠍.生殖口蓋右_表示 = false;
    			蠍.基節_肢内突起左_表示 = false;
    			蠍.基節_肢内突起右_表示 = false;
    			蠍.くぱぁ = 1.0;
    		}
    		else if (Is獣)
    		{
    			if (WaistSkin_獣 != null)
    			{
    				WaistSkin_獣.竜性_鱗1_表示 = false;
    				WaistSkin_獣.竜性_鱗2_表示 = false;
    				WaistSkin_獣.竜性_鱗3_表示 = false;
    				WaistSkin_獣.竜性_鱗4_表示 = false;
    			}
    		}
    		else
    		{
    			WaistSkin_人.竜性_鱗1_表示 = false;
    			WaistSkin_人.竜性_鱗2_表示 = false;
    			WaistSkin_人.竜性_鱗3_表示 = false;
    			WaistSkin_人.竜性_鱗4_表示 = false;
    		}
    	}

    	public void タトゥ()
    	{
    		if (Is獣)
    		{
    			WaistSkin_獣.淫タトゥ_タトゥ1右_表示 = true;
    			WaistSkin_獣.淫タトゥ_タトゥ1左_表示 = true;
    			WaistSkin_獣.淫タトゥ_タトゥ2右_表示 = true;
    			WaistSkin_獣.淫タトゥ_タトゥ2左_表示 = true;
    			WaistSkin_獣.淫タトゥ_ハート_タトゥ右1_表示 = true;
    			WaistSkin_獣.淫タトゥ_ハート_タトゥ右2_表示 = true;
    			WaistSkin_獣.淫タトゥ_ハート_タトゥ左1_表示 = true;
    			WaistSkin_獣.淫タトゥ_ハート_タトゥ左2_表示 = true;
    			WaistSkin_獣.植タトゥ_タトゥ左_表示 = false;
    			WaistSkin_獣.植タトゥ_タトゥ右_表示 = false;
    		}
    		else
    		{
    			WaistSkin_人.淫タトゥ_タトゥ1右_表示 = true;
    			WaistSkin_人.淫タトゥ_タトゥ1左_表示 = true;
    			WaistSkin_人.淫タトゥ_タトゥ2右_表示 = true;
    			WaistSkin_人.淫タトゥ_タトゥ2左_表示 = true;
    			WaistSkin_人.淫タトゥ_ハート_タトゥ右1_表示 = true;
    			WaistSkin_人.淫タトゥ_ハート_タトゥ右2_表示 = true;
    			WaistSkin_人.淫タトゥ_ハート_タトゥ左1_表示 = true;
    			WaistSkin_人.淫タトゥ_ハート_タトゥ左2_表示 = true;
    			WaistSkin_人.植タトゥ_タトゥ左_表示 = false;
    			WaistSkin_人.植タトゥ_タトゥ右_表示 = false;
    		}
    	}

    	public bool Is胸甲殻()
    	{
    		return 乳房左.虫性_甲殻_表示;
    	}

    	public bool Is股防御()
    	{
    		if (Is蛇)
    		{
    			return 蛇.ガード;
    		}
    		if (Is蠍)
    		{
    			return 蠍.生殖口蓋左_表示;
    		}
    		if (Is獣)
    		{
    			if (WaistSkin_獣 != null)
    			{
    				if (!WaistSkin_獣.竜性_鱗1_表示 && !WaistSkin_獣.竜性_鱗2_表示 && !WaistSkin_獣.竜性_鱗3_表示)
    				{
    					return WaistSkin_獣.竜性_鱗4_表示;
    				}
    				return true;
    			}
    			return false;
    		}
    		if (!WaistSkin_人.竜性_鱗1_表示 && !WaistSkin_人.竜性_鱗2_表示 && !WaistSkin_人.竜性_鱗3_表示)
    		{
    			return WaistSkin_人.竜性_鱗4_表示;
    		}
    		return true;
    	}
    }
}
