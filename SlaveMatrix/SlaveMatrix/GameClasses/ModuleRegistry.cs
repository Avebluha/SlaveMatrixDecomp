using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;
using _2DGAMELIB;
using SlaveMatrix.Properties;

namespace SlaveMatrix
{
    public static class MyUI
    {
        //normal rectangular buttons
        public static Button Button(ModeEventDispatcher med, RenderArea buffer, string text, Vector2D pos, Action<ButtonBase> on_click) {

            ShapePartT shapePartT = new ShapePartT();
            shapePartT.SetFont(new Font("MS Gothic", 0.1f));
            shapePartT.SetPositionBase(buffer.GetPosition(pos));
            shapePartT.Text = text;
            shapePartT.SetFontSize(0.14);
            shapePartT.SetSizeBase(0.05);
            shapePartT.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
            shapePartT.GetOP().ScalingXY(shapePartT.GetOP().GetCenter(), 0.87, 0.23);
            shapePartT.SetClosed(true);
            shapePartT.SetTextColor(ColorHelper.White);
            shapePartT.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
            shapePartT.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
            shapePartT.SetHitColor(med.GetUniqueColor());
            shapePartT.GetStringFormat().Alignment = StringAlignment.Center;
            shapePartT.GetStringFormat().LineAlignment = StringAlignment.Center;

            /*
            ShapePartT shapePartT = new ShapePartT();
            shapePartT.Font = new Font("MS Gothic", 0.1f);
            shapePartT.PositionBase = DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + 0.72));
            shapePartT.Text = GameText.完了;
            shapePartT.FontSize = 0.15;
            shapePartT.SizeBase = 0.05;
            shapePartT.OP.AddRange(new CurveOutline[1] { ShapeHelper.Get正方形() });
            shapePartT.OP.ScalingY(shapePartT.OP.GetCenter(), 0.47);
            shapePartT.Closed = true;
            shapePartT.TextColor = ColorHelper.White;
            shapePartT.BrushColor = Color.FromArgb(160, ColorHelper.Black);
            shapePartT.ShadBrush = new SolidBrush(Color.FromArgb(64, ColorHelper.Black));
            shapePartT.HitColor = Med.GetUniqueColor(); //still not sure what this is for...
            shapePartT.StringFormat.Alignment = StringAlignment.Center;
            shapePartT.StringFormat.LineAlignment = StringAlignment.Center;
            */

            /*
            ShapePartT shapePartT4 = new ShapePartT();
            shapePartT4.Font = new Font("MS Gothic", 0.1f);
            shapePartT4.PositionBase = DrawBuffer.GetPosition(x, y);
            shapePartT4.Text = "Load";
            shapePartT4.FontSize = 0.14;
            shapePartT4.SizeBase = 0.05;
            shapePartT4.OP.AddRange(new CurveOutline[1] { ShapeHelper.Get正方形() });
            shapePartT4.OP.ScalingXY(shapePartT4.OP.GetCenter(), 0.87, 0.23);
            shapePartT4.Closed = true;
            shapePartT4.TextColor = ColorHelper.White; 
            shapePartT4.BrushColor = Color.FromArgb(160, ColorHelper.Black);
            shapePartT4.ShadBrush = new SolidBrush(Color.FromArgb(64, ColorHelper.Black));
            shapePartT4.HitColor = Med.GetUniqueColor(); // what are you for?
            shapePartT4.StringFormat.Alignment = StringAlignment.Center;
            shapePartT4.StringFormat.LineAlignment = StringAlignment.Center;
            */

            return new Button(shapePartT, on_click);
        }

        //rhombus shaped buttons
        public static Button Button2(ModeEventDispatcher med, RenderArea buffer, string text, Vector2D pos, Action<ButtonBase> on_click) {
            ShapePartT shapePartT = new ShapePartT();
            shapePartT.SetFont(new Font("MS Gothic", 0.1f));
            shapePartT.SetPositionBase(buffer.GetPosition(pos));
            shapePartT.Text = text;
            shapePartT.SetFontSize(0.15);
            shapePartT.SetSizeBase(0.05);
            shapePartT.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
            shapePartT.GetOP().ScalingY(shapePartT.GetOP().GetCenter(), 0.47);
            shapePartT.GetOP().Rotation(shapePartT.GetOP().GetCenter(), -26.0);
            shapePartT.SetClosed(true);
            shapePartT.SetTextColor(ColorHelper.White);
            shapePartT.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
            shapePartT.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
            shapePartT.SetHitColor(med.GetUniqueColor());
            shapePartT.GetStringFormat().Alignment = StringAlignment.Center;
            shapePartT.GetStringFormat().LineAlignment = StringAlignment.Center;

            return new Button(shapePartT, on_click);
        }

        public static ListView Select(RenderArea buffer, Vector2D pos, params TextAction[] acts) {
            return new ListView(
                buffer,
                buffer.GetPosition(pos),
                0.25,
                new Font("MS Gothic", 1f),
                0.09,
                ColorHelper.White,
                ColorHelper.Empty,
                ColorHelper.Empty,
                ColorHelper.Empty,
                acts
            );
        }

        public static Lab Label(ModeEventDispatcher med, RenderArea buffer, string text, Vector2D pos) {
            return new Lab(
                    buffer,
                    "",
                    buffer.GetPosition(pos),
                    0.2,
                    1.0,
                    new Font("", 1f),
                    0.07,
                    text,
                    ColorHelper.White,
                    ColorHelper.Empty,
                    ColorHelper.Empty,
                    ColorHelper.Empty
            );
        }
    }

    public static class ModuleRegistry
    {


        //misc elements
    	private static SubInfo si;
    	private static ListView SaveData;
    	private static InfoPanel ip;
    	private static ButtonMap dbs;
        private static Lab npl;
        public static TextBubble ViolaTextBubble;
        public static TextBubble SlaveTextBubble;


        //misc character stuff
        private static Character TrainingTarget;
    	private static Character Viola; 
        public static ViolaText ViolaText;
        public static SlaveText SlaveText;


        //buffers
    	public static RenderArea DrawBuffer;
    	public static RenderArea BlackBackground;
    	public static RenderArea BasementBackground;
    	public static RenderArea OfficeBackground;
    	public static RenderArea drawArea;


    	private static Action<RenderArea, FpsCounter> メインフォーム描画;
    	private static Action<RenderArea, FpsCounter> 調教描画;
    	public static Action<RenderArea, FpsCounter> 撮影描画;
    	private static Action<RenderArea, FpsCounter> 対象描画;
    	private static Action<RenderArea, FpsCounter> DrawBlessing;
    	private static Action<RenderArea, FpsCounter> DrawOffice;
    	private static Action<RenderArea, FpsCounter> DrawDebt;
    	private static Action<RenderArea, FpsCounter> DrawSlaveShop;
    	private static Action<RenderArea, FpsCounter> DrawToolShop;
    	private static Action<RenderArea, FpsCounter> 中継描画;
    	private static Action<RenderArea, FpsCounter> DrawOP0;
    	private static Action<RenderArea, FpsCounter> DrawOP1;
    	private static Action<RenderArea, FpsCounter> 説明描画;
    	private static Action<RenderArea, FpsCounter> 初事務所描画;
    	private static Action<RenderArea, FpsCounter> 返済イベント描画;
    	private static Action<RenderArea, FpsCounter> 日数進行描画;
    	private static Action<RenderArea, FpsCounter> PlayerInformationSliders;
        private static Action 対象UI初期化;
        private static Action 奴隷UI初期化;



        //misc game state
    	public static ulong 単位返済段階額;
        public static double DemandMax;

    	private static string[] DayEndLog;
    	public static ulong 労働利益;
    	public static ulong 日利益額;
    	public static ulong 日利子額;


        //misc flags
        //TODO remove
        private static bool start;
    	private static bool TrainingTargetTrained;
        public static bool SDShow;
        public static bool save;
        public static bool title;


        public static int MaxRoomNumber => 135;

    	public static Dictionary<string, Module> GetMods(ModeEventDispatcher Med)
    	{
    		GlobalState.LoadConfig();
    		GlobalState.タイル準備();
    		GlobalState.Set擬音();
    		GlobalState.Set喘ぎ();

            //setup buffers
    		drawArea = new RenderArea(Med, Hit: false);
    		DrawBuffer = new RenderArea(Med, Hit: true);

    		BlackBackground = new RenderArea(Med, Hit: true);
    		BlackBackground.Clear(ColorHelper.Black);

    		BasementBackground = new RenderArea(Med, Hit: true);
    		BasementBackground.DisplayGraphics.DrawImage(new Bitmap(new MemoryStream(Resources.dangeon01_ex2)), BasementBackground.DisplayLayer.GetRect());
    		
    		OfficeBackground = new RenderArea(Med, Hit: true);
            OfficeBackground.DisplayGraphics.DrawImage(new Bitmap(new MemoryStream(Resources.li_room10a_c_ex2)), OfficeBackground.DisplayLayer.GetRect());
    		
            SaveData = new ListView(
                DrawBuffer, 
                DataConsts.Vec2DZero.AddY(0.0025), 
                0.25, 
                new Font("MS Gothic", 1f), 
                0.11, 
                ColorHelper.White,
                ColorHelper.Empty, 
                ColorHelper.Black,
                ColorHelper.Empty,
                Enumerable.Repeat(new TextAction(new string('A', 15), delegate{}), 10).ToArray()
            );
    		SaveData.SetHitColor(Med);


    		dbs = new ButtonMap();



    		double y = 0.9075;
    		if (GlobalState.BigWindow)
    		{
    			y = 0.932;
    		}
            
            double x = 0.699;
            if (GlobalState.BigWindow)
            {
                x = 0.77;
            }


            dbs.Add("プレイヤー", MyUI.Button(Med, DrawBuffer, "Player", new Vector2D(-0.001, y), delegate
    		{
    			if (GlobalState.GameData.所持金 < 10000000)
    			{
    				ip.SubInfoIm = GameText.所持金が足りません;
    			}
    			else
    			{
                    //TODO fix?
                    //Sounds.精算.Play();
    				GlobalState.GameData.所持金 -= 10000000uL;
    				ip.UpdateSub2();

    				//note: removed 50ms timeout -- could add back with mot...
    				Med.SwitchMode("PlayerInformation", DrawBuffer, PlayerInformationSliders);
    			}
    		}));
    		dbs.Add("タイトル", MyUI.Button(Med, DrawBuffer, "Title", new Vector2D(x, y), delegate
    		{
                //TODO fix?
                //Sounds.操作.Play();
    			string tb = ((ip.TextIm == "") ? " " : ip.TextIm);
    			bool sb = ip.MaiShow;
    			ip.MaiShow = true;
    			ip.TextIm = GameText.タイトル画面に戻りますか;
    			ip.選択yAct = delegate
    			{
                    //TODO fix?
                    //Sounds.操作.Play();
    				Med.Mode = "Title";
    				Color HitColor4 = ColorHelper.Empty;
    				dbs.Move(ref HitColor4);
    				ip.選択肢表示 = false;
    			};
    			ip.選択nAct = delegate
    			{
                    //TODO fix?
                    //Sounds.操作.Play();
    				ip.TextIm = tb;
    				ip.MaiShow = sb;
    				Color HitColor3 = ColorHelper.Empty;
    				dbs.Move(ref HitColor3);
    				ip.選択肢表示 = false;
    			};
    			ip.選択肢表示 = true;
    		}));


            x = 0.895;
            if (GlobalState.BigWindow)
            {
                x = 0.92;
            }

    		dbs.Add("セーブ", MyUI.Button(Med, DrawBuffer, "Save", new Vector2D(x, y), delegate
    		{
                //TODO fix?
                //Sounds.操作.Play();
    			SaveData.bs["0"].Dra = false;
    			save = true;
    			SetSLlv(Med);
    			Color HitColor2 = ColorHelper.Empty;
    			SaveData.Move(ref HitColor2);
    			SDShow = true;
    			ip.SubInfoIm = "RCl:" + GameText.戻る;
    		}));


            x = 0.797;
            if (GlobalState.BigWindow)
            {
                x = 0.845;
            }

    		dbs.Add("ロード", MyUI.Button(Med, DrawBuffer, "Load", new Vector2D(x, y), delegate
    		{
    			//Sounds.操作.Play();
    			SaveData.bs["0"].Dra = true;
    			save = false;
    			title = false;
    			SetSLlv(Med);
    			Color HitColor = ColorHelper.Empty;
    			SaveData.Move(ref HitColor);
    			SDShow = true;
    			ip.SubInfoIm = "RCl:" + GameText.戻る;
    		}));
    		NewButtons(Med);
    		dbs.SetHitColor(Med);

    		ip = new InfoPanel(Med, DrawBuffer);
    		ip.SetHitColor(Med);


    		ViolaTextBubble = new TextBubble(
                DrawBuffer, 
                右: false, 
                new Font("MS Gothic", 1f), 
                0.08, 
                " ", 
                ColorHelper.White, 
                ColorHelper.Black, 
                Color.FromArgb(160, ColorHelper.Black), 
                19.0, 
                Dis: false, 
                ColorHelper.White, 
                delegate{}
            );
    		ViolaTextBubble.SetHitColor(Med);


    		SlaveTextBubble = new TextBubble(
                DrawBuffer, 
                右: false, 
                new Font("MS Gothic", 1f), 
                0.08, 
                " ", 
                ColorHelper.White, 
                ColorHelper.Black, 
                Color.FromArgb(160, ColorHelper.Black), 
                19.0, 
                Dis: true
            );
    		SlaveTextBubble.SetHitColor(Med);

    		si = new SubInfo(Med, ip);
    		ViolaText = new ViolaText(Med, ViolaTextBubble);
    		SlaveText = new SlaveText(Med, SlaveTextBubble);
    		npl = new Lab(
                DrawBuffer, 
                "ラベル1", 
                new Vector2D(ip.MaiB.GetPosition().X, 0.026), 
                0.1, 
                1.5, 
                new Font("MS Gothic", 1f), 
                0.085, 
                "No Slave", 
                ColorHelper.White, 
                ColorHelper.Black, 
                ip.MaiB.GetBrushColor(), 
                ColorHelper.Black
            );

            return new Dictionary<string, Module>
    		{
    			{
    				"Start",
    				Start(Med)
    			},
    			{
    				"Credit",
    				Credit(Med)
    			},
    			{
    				"Title",
    				Title(Med)
    			},
    			{
    				"メインフォーム",
    				MainForm(Med)
    			},
    			{
    				"対象",
    				対象(Med)
    			},
    			{
    				"Training",
    				Training(Med)
    			},
    			{
    				"Blessing",
    				Blessing(Med)
    			},
    			{
    				"Office",
    				Office(Med)
    			},
    			{
    				"Debt",
    				Debt(Med)
    			},
    			{
    				"SlaveShop",
    				SlaveShop(Med)
    			},
    			{
    				"ToolShop",
    				ToolShop(Med)
    			},
    			{
    				"調教中継行",
    				調教中継行(Med)
    			},
    			{
    				"調教中継帰",
    				調教中継帰(Med)
    			},
    			{
    				"StartOfDay",
    				StartOfDay(Med)
    			},
    			{
    				"PlayerInformation",
    				PlayerInformation(Med)
    			},
    			{
    				"OP0",
    				OP0(Med)
    			},
    			{
    				"OP1",
    				OP1(Med)
    			},
    			{
    				"説明",
    				説明(Med)
    			},
    			{
    				"初事務所",
    				初事務所(Med)
    			},
    			{
    				"RepaymentEvent1",
    				RepaymentEvent1(Med)
    			},
    			{
    				"RepaymentEvent2",
    				RepaymentEvent2(Med)
    			},
    			{
    				"RepaymentEvent3",
    				RepaymentEvent3(Med)
    			},
    			{
    				"ViolaBlessing",
    				ViolaBlessing(Med)
    			}
    		};
    	}

    	public static void Dispose()
    	{
    		drawArea.Dispose();
    		DrawBuffer.Dispose();
    		BlackBackground.Dispose();
    		BasementBackground.Dispose();
    		OfficeBackground.Dispose();
    		if (TrainingTarget != null)
    		{
    			TrainingTarget.Dispose();
    		}
    		SlaveTextBubble.Dispose();
    		if (Viola != null)
    		{
    			Viola.Dispose();
    		}
    		ViolaTextBubble.Dispose();
    		SaveData.Dispose();
    		ip.Dispose();
    		dbs.Dispose();
    		npl.Dispose();
    	}




        //would really prefer not to have these here...
        private static bool fade_in;
        static MotionBase mv = new MotionBase(0.0, 1.0)
        {
            BaseSpeed = 2.0
        };
        static double v = 0.0;

        private static void SwitchMode(ModeEventDispatcher Med, RenderArea Are, FpsCounter FPS, Action<RenderArea, FpsCounter> 描画)
    	{
            if (fade_in)
    		{
    			if (v < mv.Max)
    			{
    				mv.GetValue(FPS);
    				v = mv.Value;
    				if (fade_in)
    				{
    					Med.FadeIn(v);
    				}
    			}
    			else
    			{
    				fade_in = false;
    				v = 0.0;
    				mv.ResetValue();
    			}
    		}
    		else
    		{
    			描画(Are, FPS);
    		}
    	}

    	public static void SwitchMode(this ModeEventDispatcher Med, string Mode, RenderArea Are, Action<RenderArea, FpsCounter> 描画)
    	{
    		Med.Mode = Mode;
    		描画(drawArea, Med.FPSF);
    		Med.SceneFader.DrawStart(Are);
    		Med.SceneFader.DrawEnd(drawArea);
    		fade_in = true;
    	}

        public static void flash(this ModeEventDispatcher Med)
        {
            調教描画(drawArea, Med.FPSF);
            Color col = Color.FromArgb(128, Color.White);
            Med.SceneFader.ClearStart(ref col);
            Med.SceneFader.DrawEnd(drawArea);
            fade_in = true;
        }



        public static void SetDemandMaximum()
    	{
    		if (GlobalState.GameData.RepaymentStage == 0)
    		{
    			DemandMax = 88.0;
    		}
    		else if (GlobalState.GameData.RepaymentStage == 1)
    		{
    			DemandMax = 99.0;
    		}
    		else if (GlobalState.GameData.RepaymentStage == 2)
    		{
    			DemandMax = 110.0;
    		}
    		else
    		{
    			DemandMax = 111.0;
    		}
    	}



        //  save/load handling
        //TODO: fix
    	public static void SetSLlv(ModeEventDispatcher Med)
    	{
    		SaveData.Acts = sllv(Med);
    	}

    	private static IEnumerable<TextAction> sllv(ModeEventDispatcher Med)
    	{
    		int j = 0;
    		string[] array = GlobalState.SDPaths();
    		foreach (string text in array)
    		{
    			string path = text;
    			int i = j;
    			bool f = path == null;
    			yield return new TextAction(f ? (i + ": No data") : Path.GetFileNameWithoutExtension(path).Replace("：", ":").Replace("_", "/"), delegate
    			{
    				//////Sounds.操作.Play();
    				if (save)
    				{
    					Save(path, i, Med);
    				}
    				else if (!f)
    				{
    					Load(path, i, Med);
    				}
    			});
    			j++;
    		}
    	}

    	private static void AutoSave()
    	{
    		string s = Path.Combine(GlobalState.SavePath, "0： ");
    		foreach (string item in from e in Directory.EnumerateFiles(GlobalState.SavePath)
    			where e.StartsWith(s)
    			select e)
            {
                System.IO.File.Delete(item);
            }
    		GlobalState.GDSave(0);
    	}

    	private static void Save(string Path, int i, ModeEventDispatcher Med)
    	{
    		ip.SubInfoIm = GameText.セーブ中です + "\r\n" + GameText.しばらくお待ちください;

    		if (Path != null)
    		{
                System.IO.File.Delete(Path);
    		}
    		GlobalState.GDSave(i);
    		SetSLlv(Med);
    		SDShow = false;
    		ip.SubInfoIm = i + ": " + GlobalState.GameData.GetSaveDateString() + "\r\n" + GameText.セーブしました;
    		//Med.InvokeL(Sounds.完了.Play);
    	}

    	private static void Load(string Path, int i, ModeEventDispatcher Med)
    	{
    		ip.SubInfoIm = GameText.ロード中です + "\r\n" + GameText.しばらくお待ちください;
		
    		GlobalState.GameData = Path.LoadExMod<GameState>();
    		Character d = Viola;
    		Viola = new Character(Med, DrawBuffer, GlobalState.GameData.ヴィオラ.ChaD);
    		Viola.Set衣装(GlobalState.GameData.ヴィオラ.着衣);
    		ViolaTextBubble.接続(Viola.Body.頭.口_接続点);
    		
    		Initialize();
    		if (d != null)
    		{
    			d.Dispose();
    		}
    		if (TrainingTarget != null)
    		{
    			TrainingTarget.Dispose();
    			TrainingTarget = null;
    		}
    		SDShow = false;
    		if (title)
    		{
    			Med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
    		}
    		else
    		{
    			Med.Mode = "メインフォーム";
    			ip.SubInfoIm = i + ": " + GlobalState.GameData.GetSaveDateString() + "\r\n" + GameText.ロードしました;
    		}
    		SetDemandMaximum();
    		if (GlobalState.GameData.Slaves.Length < MaxRoomNumber)
    		{
    			Unit[] array = new Unit[MaxRoomNumber];
    			Array.Copy(GlobalState.GameData.Slaves, array, GlobalState.GameData.Slaves.Length);
    			GlobalState.GameData.Slaves = array;
    		}
    		//Med.InvokeL(Sounds.完了.Play);
    		
    	}

        public static void SetJSLlv(ModeEventDispatcher med)
        {
            SaveData.Acts = jsllv(med);
        }

        private static IEnumerable<TextAction> jsllv(ModeEventDispatcher med)
        {
            int k = 0;
            string[] array = GlobalState.JSDPaths();
            foreach (string text in array)
            {
                string path = text;
                int i = k;
                bool f = path == null;
                yield return new TextAction(f ? (i + ": No data") : Path.GetFileNameWithoutExtension(path).Replace("：", ":").Replace("_", "/"), delegate
                {
                    //Sounds.操作.Play();
                    if (save)
                    {
                        JsonSave(path, i, med);
                    }
                    else if (!f)
                    {
                        JsonLoad(path, i, med);
                    }
                });
                k++;
            }
        }

        private static void JsonSave(string Path, int i, ModeEventDispatcher med)
        {
            ip.SubInfoIm = GameText.セーブ中です + "\r\n" + GameText.しばらくお待ちください;

            if (Path != null)
            {
                System.IO.File.Delete(Path);
            }
            GlobalState.GDSaveJson(i);
            SetJSLlv(med);
            SDShow = false;
            ip.SubInfoIm = i + ": " + GlobalState.GameData.GetSaveDateString() + "\r\n" + GameText.セーブしました;
            //Sounds.完了.Play();
        }
        private static void JsonLoad(string Path, int i, ModeEventDispatcher med)
        {
            ip.SubInfoIm = GameText.ロード中です + "\r\n" + GameText.しばらくお待ちください;

            GlobalState.DontScar = true;
            if (GlobalState.TranslateJson)
            {
                string text = GlobalState.CurrentDirectory + "temp.json";
                string contents = GlobalState.Translate(Path, 1);
                File.WriteAllText(text, contents);
                GlobalState.GameData = Serializer.UnJson<GameState>(text);
                System.IO.File.Delete(text);
            }
            else
            {
                GlobalState.GameData = Serializer.UnJson<GameState>(Path);
            }
            GlobalState.DontScar = false;
            Character d = Viola;
            Viola = new Character(med, DrawBuffer, GlobalState.GameData.ヴィオラ.ChaD);
            Viola.Set衣装(GlobalState.GameData.ヴィオラ.着衣);
            ViolaTextBubble.接続(Viola.Body.頭.口_接続点);
            
            Initialize();
            if (d != null)
            {
                d.Dispose();
            }
            if (TrainingTarget != null)
            {
                TrainingTarget.Dispose();
                TrainingTarget = null;
            }
            SDShow = false;
            if (title)
            {
                med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
            }
            else
            {
                med.Mode = "メインフォーム";
                ip.SubInfoIm = i + ": " + GlobalState.GameData.GetSaveDateString() + "\r\n" + GameText.ロードしました;
            }
            SetDemandMaximum();
            if (GlobalState.GameData.Slaves.Length < MaxRoomNumber)
            {
                Unit[] array = new Unit[MaxRoomNumber];
                Array.Copy(GlobalState.GameData.Slaves, array, GlobalState.GameData.Slaves.Length);
                GlobalState.GameData.Slaves = array;
            }
            GlobalState.GameData.Gen = new Generator[9];
            GlobalState.GameData.GenInstance();
            //Sounds.完了.Play();
        }

        private static void Initialize()
    	{
            GlobalState.GameData.Refresh = false;
            対象UI初期化();
    		奴隷UI初期化();
    	}

    	private static void DayLog(string s, int i)
    	{
    		ref string reference = ref DayEndLog[i];
    		reference = reference + s + "\r\n";
    	}
        public static void Setnpl(Unit u)
        {
            npl.Text = GameText.収容番号 + u.Number + "\r\n" + (GlobalState.AlwaysUseName ? u.Name : (u.Trained ? u.Name : u.Race));
        }

        public static void EndDay()
    	{
    		Player.RecoverPlayerStamina();
    		GlobalState.GameData.日借金額 = 0uL;
    		労働利益 = 0uL;
    		日利益額 = 0uL;
    		日利子額 = GlobalState.GameData.利子額;
    		DayEndLog = new string[MaxRoomNumber];
    		int num = 0;
    		Unit[] Slaves = GlobalState.GameData.Slaves;
    		foreach (Unit unit in Slaves)
    		{
    			if (unit != null)
    			{
    				unit.RecoverStamina();
    				unit.RecoverStamina();
    				unit.ChaD.現陰毛 = (unit.ChaD.現陰毛 + 0.05).Clamp(0.0, 1.0);
    				int num2 = ((unit.妊娠進行期間 <= 0) ? 1 : unit.妊娠進行期間);
    				bool flag = GlobalState.GameData.日数 % (ulong)(num2 * 2) == 0;
    				if (unit.発情フラグ && flag && !unit.ChaD.タトゥ)
    				{
    					unit.発情フラグ = false;
    				}
    				else if (flag)
    				{
    					unit.発情フラグ = true;
    				}
    				checked
    				{
    					if (unit.Pregnant)
    					{
    						if (unit.非妊娠)
    						{
    							DayLog(GameText.収容番号 + unit.Number + "/" + unit.Name + GameText.が妊娠しました + ((unit.Laboror || unit.Prostitute) ? ("\r\n" + GameText.労働が解除されます) : ""), num);
    							unit.非妊娠 = false;
    						}
    						if (unchecked(GlobalState.GameData.日数 % (ulong)num2) == 0L)
    						{
    							if (unit.妊娠状態変数 == 4)
    							{
    								unit.体力消費();
    								unit.体力消費();
    								unit.体力消費();
    								DayLog(GameText.収容番号 + unit.Number + "/" + unit.Name + GameText.が出産しました, num);
    								if (GlobalState.GameData.Is地下室一杯())
    								{
    									ulong price = unit.Child.GetPrice();
    									DayLog(GameText.収容できないので子は売却されます + "+" + price.ToString("#,0"), num);
    									try
    									{
    										日利益額 += price;
    									}
    									catch
    									{
    										日利益額 = 9999999999999uL;
    									}
    								}
    								else
    								{
    									DayLog(GameText.子を奴隷として収容します, num);
    									GlobalState.GameData.Add地下室(unit.Child);
    								}
    								unit.Child = null;
    								unit.妊娠状態変数 = -1;
    								unit.ChaD.現乳房 = 0.0;
    								unit.Pregnant = false;
    								unit.非妊娠 = true;
    							}
    							else
    							{
    								unchecked
    								{
    									unit.妊娠状態変数++;
    									unit.ChaD.現乳房 += 0.2;
    								}
    							}
    						}
    					}
    					else if (unit.Trained && unit.Is増殖可 && unit.ChaD.Stamina == 1.0 && 0.3.Lot())
    					{
    						unit.体力消費();
    						unit.体力消費();
    						unit.体力消費();
    						DayLog(GameText.収容番号 + unit.Number + "/" + unit.Name + GameText.が増殖しました, num);
    						if (GlobalState.GameData.Is地下室一杯())
    						{
    							ulong price2 = unit.GetPrice();
    							DayLog(GameText.収容できないので子は売却されます + "+" + price2.ToString("#,0"), num);
    							try
    							{
    								日利益額 += price2;
    							}
    							catch
    							{
    								日利益額 = 9999999999999uL;
    							}
    						}
    						else
    						{
    							DayLog(GameText.子を奴隷として収容します, num);
    							GlobalState.GameData.Add地下室(unit.DeepCopy().増殖時Reset());
    						}
    					}
    					if (unit.非妊娠)
    					{
    						try
    						{
    							if (unit.Laboror)
    							{
    								労働利益 += (ulong)(500000.0 * ((double)unit.種族情報.一般 / 9.0) * (double)unit.LaborCount * unit.一般労働倍率()).RoundDown(0);
    							}
    							else if (unit.Prostitute)
    							{
    								労働利益 += (ulong)((double)unit.GetPrice() * 0.012 * ((double)unit.種族情報.娼婦 / 9.0 + unit.ChaD.Lust + unit.ChaD.Affection + unit.ChaD.Taming + unit.ChaD.SkillL) * (double)unit.ProstituteCount * unit.娼婦労働倍率() * (unit.Virgin ? 0.4 : 1.0)).RoundDown(0);
    							}
    						}
    						catch
    						{
    							労働利益 = 9999999999999uL;
    						}
    					}
    					unit.LaborCount = 0;
    					unit.ProstituteCount = 0;
    				}
    			}
    			num++;
    		}
    		checked
    		{
    			try
    			{
    				日利益額 += 労働利益;
    			}
    			catch
    			{
    				日利益額 = 9999999999999uL;
    			}
    			GlobalState.GameData.新日 = true;
    		}
    	}
    	public static bool PassTime(ModeEventDispatcher Med)
    	{
    		bool flag = GlobalState.GameData.時間帯 == GameText.夜;
            Player.RecoverPlayerStamina();

            foreach (Unit u in GlobalState.GameData.Slaves)
            {
                if (u != null)
                {
                    if (u.非妊娠 && u.Laboror && u.ChaD.Stamina > 0.333)
                    {
                        u.LaborCount++;
                        u.体力消費();
                        u.種族情報.一般成長(u.一般最大加算値);
                    }
                    else if (u.非妊娠 && u.Prostitute && u.ChaD.Stamina > 0.333)
                    {
                        u.ProstituteCount++;
                        u.体力消費();
                        u.種族情報.娼婦成長(u.娼婦最大加算値);
                        u.ChaD.娼婦調教(u.MaxSkillL);
                        if (!u.Pregnant && (0.002 * (u.発情フラグ ? 1.5 : 1.0) * ((u.Race == GameText.エキドナ) ? 2.0 : 1.0)).Lot())
                        {
                            u.Virgin = false;
                            u.娼婦妊娠();
                        }
                    }
                    else
                    {
                        u.RecoverStamina();
                    }
                }
            }
            if (flag)
    		{
    			GlobalState.GameData.Refresh = false;

                EndDay();
                AutoSave();

                Med.SwitchMode("StartOfDay", DrawBuffer, 日数進行描画);
    		}
    		else
    		{
    			GlobalState.GameData.時間進行();
    		}
    		return flag;
    	}        
        public static void PassDay(ModeEventDispatcher Med)
    	{
    		while (!PassTime(Med))
    		{
    		}
    	}



    	public static void 妊娠状態反映()
    	{
    		if (GlobalState.GameData.TrainingTarget.妊娠状態変数 > -1)
    		{
    			TrainingTarget.Body.PregnantBellyi = GlobalState.GameData.TrainingTarget.妊娠状態変数;
    			TrainingTarget.Body.PregnantBelly_表示 = true;
    			if (!TrainingTarget.Body.Is獣)
    			{
    				TrainingTarget.Body.PregnantBelly_人.ハイライト表示 = GlobalState.GameData.TrainingTarget.妊娠状態変数 > 2;
    			}
    		}
    		else
    		{
    			TrainingTarget.Body.PregnantBellyi = 0;
    			TrainingTarget.Body.PregnantBelly_表示 = false;
    		}
    		//TrainingTarget.Bod.断面_表示 = TrainingTarget.Bod.断面_表示;
    		TrainingTarget.Body.変動ステート更新();
    	}

    	public static void ResetTrainingTarget()
    	{
    		Player.Cha = TrainingTarget;
    		Player.SetState();
    		Player.表示ステート更新();
    		Player.ModBox();
    		Player.SensBox();
    		妊娠状態反映();
    		TrainingTarget.SetInitialExpression();
    		TrainingTarget.Emotion();
    		TrainingTarget.UpdateExpression();
    		TrainingTarget.口修正();
    		if (GlobalState.GameData.TrainingTarget.Trained)
    		{
    			TrainingTarget.Body.拘束具_表示 = false;
    			TrainingTarget.Body.首輪_表示 = true;
    			TrainingTarget.Set基本姿勢();
    		}
    		else
    		{
    			TrainingTarget.Body.拘束具_表示 = true;
    			TrainingTarget.Set拘束姿勢();
    		}
    		if (GlobalState.GameData.TrainingTarget.ChaD.胸施術)
    		{
    			TrainingTarget.Body.胸施術();
    		}
    		if (GlobalState.GameData.TrainingTarget.ChaD.股施術)
    		{
    			TrainingTarget.Body.股施術();
    		}
    		if (GlobalState.GameData.TrainingTarget.ChaD.タトゥ)
    		{
    			TrainingTarget.Body.タトゥ();
    		}
    		if (GlobalState.GameData.TrainingTarget.着衣 != null)
    		{
    			TrainingTarget.Set衣装(GlobalState.GameData.TrainingTarget.着衣);
    		}
    		TrainingTarget.Body.Join();
    		TrainingTarget.Body.Update();
    	}

    	public static void SetTrainingTarget(ModeEventDispatcher Med, Unit u)
    	{
    		GlobalState.GameData.TrainingTarget = u;
    		if (TrainingTarget != null)
    		{
    			TrainingTarget.Dispose();
    		}
    		TrainingTarget = new Character(Med, DrawBuffer, GlobalState.GameData.TrainingTarget.ChaD);
    		SlaveTextBubble.接続(TrainingTarget.Body.頭.口_接続点);
    		Setnpl(u);
    		double d = ((u.Trained && GlobalState.MoveInsectMask) ? 1.0 : 0.0);
    		if (TrainingTarget.Body.Is顔面)
    		{
    			TrainingTarget.Body.頭.顔面_接続.SetEle(delegate(顔面 顔面)
    			{
    				顔面.展開0 = d;
    				顔面.展開1 = d;
    			});
    			TrainingTarget.Body.頭.大顎基_接続.SetEle(delegate(大顎基 大顎)
    			{
    				大顎.展開 = d;
    			});
    			TrainingTarget.Body.頭.額_接続.SetEle(delegate(角1_虫 虫角)
    			{
    				虫角.展開 = d;
    			});
    		}
    		ResetTrainingTarget();
    	}

    	public static void InitializeTrainingTarget()
    	{
    		Player.SetState();
    		TrainingTarget.Crying = false;
    		if (TrainingTarget.Body.LeftNoseDrip != null)
    		{
    			TrainingTarget.Body.LeftNoseDrip.表示 = false;
    			TrainingTarget.Body.RightNoseDrip.表示 = false;
    		}
    		if (TrainingTarget.Body.LeftDrool != null)
    		{
    			TrainingTarget.Body.LeftDrool.表示 = false;
    			TrainingTarget.Body.RightDrool.表示 = false;
    		}
    		TrainingTarget.Body.LeftMilkSpray.表示 = false;
    		TrainingTarget.Body.RightMilkSpary.表示 = false;
    		TrainingTarget.MilkStain = 0.0;
    		TrainingTarget.Body.下着T染み = 0.0;
    		TrainingTarget.SetInitialExpression();
    		TrainingTarget.Emotion();
    		TrainingTarget.UpdateExpression();
    		if (GlobalState.GameData.TrainingTarget.Trained)
    		{
    			TrainingTarget.Set基本姿勢();
    		}
    		else
    		{
    			TrainingTarget.Set拘束姿勢();
    		}
    		Player.表示ステート更新();
    		Player.ModBox();
    		Player.SensBox();
    	}

    	public static void Player説明(ref Color hc, Action Reset)
    	{
    		if (dbs["プレイヤー"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    		{
    			ip.SubInfoIm = GameText.プレイヤーの遺伝情報を設定します + "(-" + 10000000uL.ToString("#,0") + ")";
    		}
    		else if (ip.SubInfoIm == GameText.プレイヤーの遺伝情報を設定します + "(-" + 10000000uL.ToString("#,0") + ")")
    		{
    			Reset();
    		}
    	}

        //modules
    	public static Module Start(ModeEventDispatcher Med)
    	{
    		return new Module
    		{
    			Setting = delegate
    			{
                    Med.Mode = "Credit";
                }
    		};
    	}
    	public static Module Credit(ModeEventDispatcher Med) {
    		MotionBase mv = new MotionBase(0.0, 1.0){BaseSpeed = 0.5};

    		double v = 0.0;
    		bool fadeIn = true;
    		bool fadeOut = false;

            Lab label = MyUI.Label(Med, DrawBuffer, "Auto Eden Presents.", new Vector2D(0.4, 0.4));

            return new Module()
    		{
    			Setting = delegate
    			{
    				DrawBuffer.Clear(ColorHelper.Black);
    				DrawBuffer.Draw(label.ShapePartT);
    				Med.SceneFader.DrawStart(BlackBackground);
    				Med.SceneFader.DrawEnd(DrawBuffer);
    				v = 0.0;
    				fadeIn = true;
    				fadeOut = false;
    				mv.ResetValue();
    			},

    			Down = delegate
    			{
    				Med.Mode = "Title";
    			},

    			Draw = delegate (FpsCounter FPS)
    			{
    				if (fadeIn || fadeOut)
    				{
    					if (v < mv.Max)
    					{
    						mv.GetValue(FPS);
    						v = mv.Value;
    						if (fadeIn)
    						{
    							Med.FadeIn(v);
    						}
    						if (fadeOut)
    						{
    							Med.FadeOut(v);
    						}
    					}
    					else
    					{
    						if (fadeOut)
    						{
    							v = 0.0;
    							fadeOut = false;
    							mv.ResetValue();
    							Med.Draw(BlackBackground);
    						}
    						if (fadeIn)
    						{
    							v = 0.0;
    							fadeIn = false;
    							mv.ResetValue();
    							Med.Draw(DrawBuffer);
    							fadeOut = true;
    							Med.SceneFader.DrawStart(DrawBuffer);
    							Med.SceneFader.DrawEnd(BlackBackground);
    						}
    					}
    				}
    				else
    				{
    					Med.Draw(BlackBackground);
    					Med.Mode = "Title";
    				}
    			},

    			Dispose = delegate
    			{
    				label.Dispose();
    			}
    		};
    	}

    	public static Module Title(ModeEventDispatcher Med)
    	{
    		MotionBase mv = new MotionBase(0.0, 1.0)
    		{
    			BaseSpeed = 0.5
    		};

            bool ll = false;
            double v = 0.0;
    		bool b1 = true;

            Lab label = MyUI.Label(Med, DrawBuffer, "Slave Matrix", new Vector2D(0.4, 0.4));
            ListView listView = MyUI.Select(
                DrawBuffer,
                new Vector2D(0.45, 0.5),
    			new TextAction("Start", delegate
    			{
    				////Sounds.操作.Play();
    				GlobalState.GameData.SetDefault();

    				Viola?.Dispose();
    				TrainingTarget?.Dispose();
    				TrainingTarget = null;

    				Initialize();
    				start = true;
    				SetDemandMaximum();
    				Med.SwitchMode("PlayerInformation", DrawBuffer, PlayerInformationSliders);
    			}),
    			new TextAction("Load", delegate
    			{
    				////Sounds.操作.Play();
    				SaveData.bs["0"].Dra = true;
    				save = false;
    				title = true;
    				SetSLlv(Med);
    				ll = true;
    				ip.SubInfoIm = "RCl:" + GameText.戻る;
    			})
    		);


    		listView.SetHitColor(Med);

    		return new Module
    		{
                Setting = delegate
                {
                    ip.MaiShow = false;
                    ip.Mai2Show = false;
                    ip.SubShow = true;
                    ip.Sub2Show = false;
                    ll = false;
                    DrawBuffer.Clear(ColorHelper.Black);
                    DrawBuffer.Draw(label.ShapePartT);
                    Med.SceneFader.DrawStart(BlackBackground);
                    Med.SceneFader.DrawEnd(DrawBuffer);
                    v = 0.0;
                    b1 = true;
                    mv.ResetValue();
                    //Sounds.日常BGM.Stop();
                    //Sounds.OPBGM.Play();
                },
                Down = delegate (MouseButtons mb, Vector2D cp, Color hc)
    			{
    				if (mb == MouseButtons.Left)
    				{
    					if (ll)
    					{
    						SaveData.Down(ref hc);
    					}
    					else
    					{
    						listView.Down(ref hc);
    					}
    				}
    				else if (ll && mb == MouseButtons.Right)
    				{
    					ll = false;
    				}
    			},
    			Up = delegate (MouseButtons mb, Vector2D cp, Color hc)
    			{
    				if (ll)
    				{
    					SaveData.Up(ref hc);
    				}
    				else
    				{
    					listView.Up(ref hc);
    				}
    			},
    			Move = delegate (MouseButtons mb, Vector2D cp, Color hc)
    			{
    				SaveData.Move(ref hc);
    				listView.Move(ref hc);
    			},
    			Leave = delegate
    			{
    				if (ll)
    				{
    					SaveData.Leave();
    				}
    				else
    				{
    					listView.Leave();
    				}
    			},
    			Draw = delegate (FpsCounter FPS)
    			{
    				if (b1)
    				{
    					if (v < mv.Max)
    					{
    						mv.GetValue(FPS);
    						v = mv.Value;
    						if (b1)
    						{
    							Med.FadeIn(v);
    						}
    					}
    					else
    					{
    						v = 0.0;
    						b1 = false;
    						mv.ResetValue();
    						Med.Draw(DrawBuffer);
    					}
    				}
    				else
    				{
    					DrawBuffer.Draw(BlackBackground);
    					if (ll)
    					{
    						ip.Draw(DrawBuffer, FPS);
    						SaveData.Draw(DrawBuffer);
    					}
    					else
    					{
    						DrawBuffer.Draw(label.ShapePartT);
    						listView.Draw(DrawBuffer);
    					}
    					Med.Draw(DrawBuffer);
    				}
    			},

    			Dispose = delegate
    			{
    				label.Dispose();
    				listView.Dispose();
    			}
    		};
    	}

    	public static Module MainForm(ModeEventDispatcher Med)
    	{
    		ButtonMap bs = new ButtonMap();

    		bs.Add("ボタン1", MyUI.Button2(Med, DrawBuffer, GameText.事務所, new Vector2D(0.85, 0.02), delegate
    		{
    			////Sounds.操作.Play();
    			Med.SwitchMode("Office", DrawBuffer, DrawOffice);
    		}));
    		bs.Add("ボタン2", MyUI.Button2(Med, DrawBuffer, GameText.調教, new Vector2D(0.85, 0.1), delegate
    		{
    			////Sounds.操作.Play();
    			Med.SwitchMode("調教中継行", DrawBuffer, 中継描画);
    		}));
    		bs.Add("ボタン3", MyUI.Button2(Med, DrawBuffer, GameText.対象, new Vector2D(0.85, 0.18), delegate
    		{
    			////Sounds.操作.Play();
    			Med.Mode = "対象";
    		}));
    		bs.Add("ボタン4", MyUI.Button2(Med, DrawBuffer, GameText.休む, new Vector2D(0.85, 0.26), delegate
    		{
    			////Sounds.操作.Play();
    			si.Set(bre: true);
    			PassTime(Med);
    			ip.UpdateSub2();
    		}));
    		bs.Add("ボタン5", MyUI.Button2(Med, DrawBuffer, GameText.眠る, new Vector2D(0.85, 0.34), delegate
    		{
    			////Sounds.操作.Play();
    			PassDay(Med);
    		}));
    		bs.Add("ボタン6", MyUI.Button2(Med, DrawBuffer, GameText.祝福, new Vector2D(0.85, 0.42), delegate
    		{
    			////Sounds.操作.Play();
    			Med.Mode = "Blessing";
    		}));
    		bs.Add("ボタン7", MyUI.Button2(Med, DrawBuffer, GameText.チェンジ, new Vector2D(0.85, 0.58), delegate
    		{
    			Unit unit = null;
    			unit = ((GlobalState.GameData.TrainingTarget == null) ? (from e in GlobalState.GameData.Slaves
    				where e != null
    				orderby Rng.XS.Next()
    				select e).First() : (from e in GlobalState.GameData.Slaves
    				where e != null && e != GlobalState.GameData.TrainingTarget
    				orderby Rng.XS.Next()
    				select e).FirstOrDefault());
    			if (unit != null)
    			{
    				if (unit.Trained)
    				{
    					//Sounds.変更3.Play();
    				}
    				else
    				{
    					Sounds.変更Play();
    				}
    				SetTrainingTarget(Med, unit);
    				bs["ボタン2"].Dra = true;
    			}
    			else
    			{
    				////Sounds.操作.Play();
    				ip.SubInfoIm = GameText.他の奴隷がいません;
    			}
    		}));

            メインフォーム描画 = delegate (RenderArea a, FpsCounter FPS)
            {
                Med.HitGraphics.Clear(ColorHelper.Transparent);
                if (a.HitGraphics != null)
                {
                    a.HitGraphics.Clear(ColorHelper.Transparent);
                }
                a.Draw(BasementBackground);
                if (TrainingTarget != null)
                {
                    TrainingTarget.Draw(a, FPS);
                    Player.UI.DrawState(a);
                    a.Draw(npl.ShapePartT);
                }
                bs.Draw(a);
                dbs.Draw(a);
                ip.Draw(a, FPS);
                if (SDShow)
                {
                    SaveData.Draw(a);
                }
                Med.Draw(a);
            };

            bs.SetHitColor(Med);
            return new Module {
                Down = delegate (MouseButtons mb, Vector2D cp, Color hc)
                {
                    if (SDShow)
                    {
                        SaveData.Down(ref hc);
                        if (mb == MouseButtons.Right)
                        {
                            ////Sounds.操作.Play();
                            SDShow = false;
                            ip.Up(ref hc);
                            dbs.Move(ref hc);
                        }
                    }
                    else
                    {
                        switch (mb)
                        {
                            case MouseButtons.Left:
                                if (!ip.選択肢表示)
                                {
                                    dbs.Down(ref hc);
                                    bs.Down(ref hc);
                                }
                                ip.Down(ref hc);
                                break;
                            case MouseButtons.Right:
                                if (ip.TextIm == GameText.タイトル画面に戻りますか)
                                {
                                    ip.nb.Action(ip.nb);
                                }
                                break;
                        }
                    }
                },

                Up = delegate (MouseButtons mb, Vector2D cp, Color hc)
                {
                    if (SDShow)
                    {
                        SaveData.Up(ref hc);
                    }
                    else if (mb == MouseButtons.Left)
                    {
                        if (!ip.選択肢表示)
                        {
                            dbs.Up(ref hc);
                            bs.Up(ref hc);
                        }
                        ip.Up(ref hc);
                    }
                },
                
                Move = delegate (MouseButtons mb, Vector2D cp, Color hc)
                {
                    if (SDShow)
                    {
                        SaveData.Move(ref hc);
                    }
                    else
                    {
                        if (!ip.選択肢表示)
                        {
                            if (TrainingTarget != null)
                            {
                                TrainingTarget.CursorPosition = cp;
                            }
                            dbs.Move(ref hc);
                            bs.Move(ref hc);
                            if (bs["ボタン7"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
                            {
                                ip.SubInfoIm = GameText.奴隷をランダムに選択します;
                            }
                            else if (ip.SubInfoIm == GameText.奴隷をランダムに選択します)
                            {
                                si.Set(bre: false);
                            }
                            Player説明(ref hc, delegate
                            {
                                si.Set(bre: false);
                            });
                        }
                        ip.Move(ref hc);
                    }
                },
                
                Leave = delegate
                {
                    if (SDShow)
                    {
                        SaveData.Leave();
                    }
                    else if (!ip.選択肢表示)
                    {
                        dbs.Leave();
                        bs.Leave();
                    }
                },
                Setting = delegate
                {
                    if (Med.Modeb != "PlayerInformation")
                    {
                        ip.UpdateSub2();
                        ip.MaiShow = false;
                        ip.Mai.Feed.Dra = false;
                        ip.Mai2Show = false;
                        ip.SubShow = true;
                        ip.Sub2Show = true;
                        Player.UI.ステート描画 = GlobalState.GameData.心眼;
                        if (TrainingTarget == null && GlobalState.GameData.TrainingTarget != null)
                        {
                            SetTrainingTarget(Med, GlobalState.GameData.TrainingTarget);
                        }
                        bs["ボタン2"].Dra = GlobalState.GameData.TrainingTarget != null;
                        bs["ボタン3"].Dra = !GlobalState.GameData.初事務所フラグ && GlobalState.GameData.Slaves.Count((Unit e) => e != null) > 0;
                        bs["ボタン4"].Dra = !GlobalState.GameData.初事務所フラグ;
                        bs["ボタン5"].Dra = !GlobalState.GameData.初事務所フラグ;
                        bs["ボタン6"].Dra = !GlobalState.GameData.初事務所フラグ;
                        bs["ボタン7"].Dra = !GlobalState.GameData.初事務所フラグ && GlobalState.GameData.Slaves.Count((Unit e) => e != null) > 0;
                        si.Set(bre: false);
                        Color HitColor = ColorHelper.Empty;
                        ip.Up(ref HitColor);
                        //Sounds.OPBGM.Stop();
                        //Sounds.日常BGM.Play();
                        npl.ShapePartT.SetPositionBase(new Vector2D(Player.UI.ステート.Position.X, 0.026));
                    }
                },
                Draw = delegate (FpsCounter FPS)
                {
                    SwitchMode(Med, DrawBuffer, FPS, メインフォーム描画);
                },
                Dispose = delegate
                {
                    bs.Dispose();
                }
            };
    	}

    	public static Module Training(ModeEventDispatcher Med)
    	{
    		調教背景 BackgroundDrawing = new 調教背景();
    		RenderArea TrainingBackground = new RenderArea(Med, Hit: false);
    		TrainingBackground.DisplayGraphics.Clear(Color.Gray);

    		Player.UI = new TrainingUI(Med, DrawBuffer, ip);
    		Player.UI.調教終了.Action = delegate
    		{
    			////Sounds.操作.Play();
    			Med.SwitchMode("調教中継帰", DrawBuffer, 中継描画);
    		};
    		bool 調教完了 = false;
    		bool 調教済みチェック = true;
    		Action 調教完了表情 = delegate
    		{
    			if (TrainingTarget.EyeTracking.Run)
    			{
    				TrainingTarget.EyeTracking.End();
    			}
    			if (TrainingTarget.Body.Is双眉)
    			{
    				TrainingTarget.Body.眉左.眉間_表示 = false;
    				TrainingTarget.Body.眉右.眉間_表示 = false;
    			}
    			if (TrainingTarget.Body.IsDualEyes)
    			{
    				TrainingTarget.瞼_半1左();
    				TrainingTarget.瞼_半1右();
    				TrainingTarget.目_見つめ左();
    				TrainingTarget.目_見つめ右();
    			}
    			if (TrainingTarget.Body.IsCheekEyes)
    			{
    				TrainingTarget.頬瞼_半1左();
    				TrainingTarget.頬瞼_半1右();
    				TrainingTarget.頬目_見つめ左();
    				TrainingTarget.頬目_見つめ右();
    			}
    			if (TrainingTarget.Body.IsSingleEye)
    			{
    				TrainingTarget.単瞼_半1();
    				TrainingTarget.単目_見つめ();
    			}
    			if (TrainingTarget.Body.IsForeheadEye)
    			{
    				TrainingTarget.額瞼_半1();
    				TrainingTarget.額目_見つめ();
    			}
    			if (!TrainingTarget.Body.玉口枷_表示)
    			{
    				TrainingTarget.口_閉笑();
    			}
    		};

            ContactD cd = default(ContactD);
            Vector2D op = DataConsts.Vec2DZero;

            調教描画 = delegate (RenderArea a, FpsCounter FPS)
            {
                Player.UI.Mots.Drive(FPS);
                Med.HitGraphics.Clear(ColorHelper.Transparent);
                if (a.HitGraphics != null)
                {
                    a.HitGraphics.Clear(ColorHelper.Transparent);
                }
                a.Draw(TrainingBackground);
                TrainingTarget.Draw(a, FPS);
                SlaveTextBubble.Draw(a, FPS);
                Player.UI.StaDraw(a, FPS);
                ip.Draw(a, FPS);
                Med.Draw(a);
                if (調教済みチェック)
                {
                    if (調教完了)
                    {
                        調教完了表情();
                        SlaveText.Set状態();
                        if (TrainingTarget.Body.Is顔面)
                        {
                            Action<TextBlock> o_done = SlaveTextBubble.TextBlock.Done;
                            SlaveTextBubble.TextBlock.Done = delegate (TextBlock TextBlock)
                            {
                                o_done(TextBlock);
                                TrainingTarget.顔面展開.Start();
                            };
                        }
                    }
                    調教済みチェック = false;
                }
            };
            撮影描画 = delegate (RenderArea a, FpsCounter FPS)
            {
                a.Draw(TrainingBackground);
                TrainingTarget.Draw(a, FPS);
            };

            return new Module {
                Setting = delegate
                {
                    TrainingBackground.DisplayGraphics.Clear(Color.Gray);
                    BackgroundDrawing.Reset();
                    BackgroundDrawing.Draw(TrainingBackground);
                    ip.MaiShow = false;
                    ip.Mai.Feed.Dra = true;
                    ip.Mai2Show = false;
                    ip.SubShow = true;
                    ip.Sub2Show = false;
                    Med.CursorHide();
                    Player.UI.ディルCM.Show = GlobalState.GameData.PurchasedTools[0];
                    Player.UI.コモンCM.Show = GlobalState.GameData.PurchasedTools[1];
                    Player.UI.ドリルCM.Show = GlobalState.GameData.PurchasedTools[2];
                    Player.UI.デンマCM.Show = GlobalState.GameData.PurchasedTools[3];
                    Player.UI.アナルCM.Show = GlobalState.GameData.PurchasedTools[4];
                    Player.UI.調教鞭CM.Show = GlobalState.GameData.PurchasedTools[5];
                    Player.UI.羽根箒CM.Show = GlobalState.GameData.PurchasedTools[6];
                    Player.UI.T剃刀CM.Show = GlobalState.GameData.PurchasedTools[7];
                    Player.UI.キャップ1CharacterElement.Show = GlobalState.GameData.PurchasedTools[8];
                    Player.UI.キャップ2CharacterElement.Show = GlobalState.GameData.PurchasedTools[8];
                    Player.UI.キャップ3CharacterElement.Show = GlobalState.GameData.PurchasedTools[8];
                    Player.UI.ロータCM.Show = GlobalState.GameData.PurchasedTools[9];
                    Player.UI.パールCM.Show = GlobalState.GameData.PurchasedTools[10];
                    Player.UI.目隠帯.Dra = GlobalState.GameData.PurchasedTools[11];
                    Player.UI.玉口枷.Dra = GlobalState.GameData.PurchasedTools[12];
                    Player.UI.撮影.Dra = GlobalState.GameData.PurchasedTools[13];
                    Player.表示ステート更新();
                    Player.ModBox();
                    Player.SensBox();
                    if (TrainingTarget.Body.Is獣)
                    {
                        TrainingTarget.Body.Waist.位置B = Med.Base.GetPosition(new Vector2D(0.5, 0.5)).AddY(-0.03);
                    }
                    else if (TrainingTarget.Body.Is半身)
                    {
                        TrainingTarget.Body.Waist.位置B = Med.Base.GetPosition(new Vector2D(0.5, 0.5)).AddY(-0.02);
                    }
                    TrainingTarget.Body.Join();
                    TrainingTarget.Body.Update();
                    SlaveTextBubble.接続();
                    TrainingTarget.Body.汗染み濃度 = 1.0;
                    調教済みチェック = true;
                    TrainingTargetTrained = GlobalState.GameData.TrainingTarget.Trained;
                    if (調教完了 = GlobalState.GameData.TrainingTarget.IsTrained())
                    {
                        調教完了表情();
                    }
                },

                Down = delegate (MouseButtons mb, Vector2D cp, Color hc)
                {
                    Player.UI.Down(ref mb, ref cp, ref op, ref hc, ref cd);
                    ip.Down(ref hc);
                },
                Up = delegate (MouseButtons mb, Vector2D cp, Color hc)
                {
                    Player.UI.Up(ref mb, ref cp, ref hc, ref cd);
                    ip.Up(ref hc);
                },
                Move = delegate (MouseButtons mb, Vector2D cp, Color hc)
                {
                    TrainingTarget.CursorPosition = cp;
                    cd = TrainingTarget.GetContact(ref hc);
                    Player.UI.Move(ref mb, ref cp, ref op, ref hc, ref cd);
                    ip.Move(ref hc);
                    op = cp;
                },
                Leave = delegate (MouseButtons mb, Vector2D cp, Color hc)
                {
                    Player.UI.Leave(ref mb, ref cp, ref hc);
                },
                Wheel = delegate (MouseButtons mb, Vector2D cp, int dt, Color hc)
                {
                    Player.UI.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
                },
                Draw = delegate (FpsCounter FPS)
                {
                    SwitchMode(Med, DrawBuffer, FPS, 調教描画);
                },
                Dispose = delegate
                {
                    TrainingBackground.Dispose();
                    Player.UI.Dispose();
                }
            };
    	}

    	public static Module 調教中継行(ModeEventDispatcher Med)
    	{
    		中継描画 = delegate(RenderArea a, FpsCounter FPS)
    		{
    			Med.HitGraphics.Clear(ColorHelper.Transparent);
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(ColorHelper.Transparent);
    			}
    			a.Draw(BlackBackground);
    			ip.Draw(a, FPS);
    			Med.Draw(a);
    		};

            return new Module
            {
                Down = delegate
                {
                    Med.SwitchMode("Training", DrawBuffer, 調教描画);
                },
                Setting = delegate
                {
                    ip.MaiShow = true;
                    ip.Mai.Feed.Dra = true;
                    ip.Mai2Show = false;
                    ip.SubShow = true;
                    ip.Sub2Show = false;
                    ip.Text = GameText.点6;
                    if (!TrainingTarget.Body.Setピアス.ピアス_表示)
                    {
                        TrainingTarget.Body.脱衣();
                    }
                    Player.UI.SetTarget(GlobalState.GameData.TrainingTarget, TrainingTarget);
                    Player.SetStateTraining();
                    Player.表示ステート更新();
                    Player.ModBox();
                    Player.SensBox();
                    TrainingTarget.Body.首輪_表示 = true;
                    si.Set(bre: false);
                    Player.UI.Reset();
                    Player.UI.擬音キュー.Clear();
                    Player.UI.擬音.Clear();
                },
                Draw = delegate (FpsCounter FPS)
                {
                    SwitchMode(Med, DrawBuffer, FPS, 中継描画);
                }
            };
    	}

    	public static Module 調教中継帰(ModeEventDispatcher Med)
    	{
    		bool Result2 = false;
    		bool Result3 = false;
    		bool b1 = false;
    		bool b2 = false;
    		bool b3 = false;

            return new Module {
                Down = delegate
                {
                    if (!Result2)
                    {
                        Player.Result2();
                        Result2 = true;
                        b1 = GlobalState.GameData.TrainingTarget.Pregnant && GlobalState.GameData.TrainingTarget.非妊娠;
                        b2 = !TrainingTargetTrained && GlobalState.GameData.TrainingTarget.Trained;
                        b3 = GlobalState.GameData.TrainingTarget.Trained && GlobalState.GameData.祝福 == null;
                        Result3 = !(b1 || b2 || b3);
                    }
                    else if (!Result3)
                    {
                        ip.TextIm = "";
                        if (b1)
                        {
                            InfoPanel 情報パネル2 = ip;
                            情報パネル2.TextIm = 情報パネル2.TextIm + GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + "/" + GlobalState.GameData.TrainingTarget.Name + GameText.が妊娠しました + ((GlobalState.GameData.TrainingTarget.Laboror || GlobalState.GameData.TrainingTarget.Prostitute) ? ("\r\n" + GameText.労働が解除されます) : "") + "\r\n";
                            GlobalState.GameData.TrainingTarget.非妊娠 = false;
                        }
                        if (b2)
                        {
                            InfoPanel 情報パネル2 = ip;
                            情報パネル2.TextIm = 情報パネル2.TextIm + GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + "/" + GlobalState.GameData.TrainingTarget.Name + GameText.の調教が完了しました + "\r\n";
                        }
                        if (b3)
                        {
                            GlobalState.GameData.祝福 = GlobalState.GameData.TrainingTarget;
                            InfoPanel 情報パネル2 = ip;
                            情報パネル2.TextIm = 情報パネル2.TextIm + GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + "/" + GlobalState.GameData.TrainingTarget.Name + GameText.から祝福を受けました;
                            //Sounds.祝福.Play();
                        }
                        Result3 = true;
                    }
                    else if (!PassTime(Med))
                    {
                        Player.UI.Reset();
                        Med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
                    }
                },
                Setting = delegate
                {
                    ip.MaiShow = true;
                    ip.Mai.Feed.Dra = true;
                    ip.Mai2Show = false;
                    ip.SubShow = true;
                    ip.Sub2Show = false;
                    Med.CursorShow();
                    Color HitColor = ColorHelper.Empty;
                    Player.UI.調教終了.Up(ref HitColor);
                    Player.Result1();
                    if (Player.UI.強制拘束)
                    {
                        GlobalState.GameData.拘束具 = Player.UI.拘束bu;
                    }
                    GlobalState.GameData.TrainingTarget.発情フラグ = Player.UI.発情bu;
                    Player.調教終了時();
                    TrainingTarget.Climax.End();
                    TrainingTarget.BodySway.End();


                    TrainingTarget.放尿強制終了();



                    Player.絶頂終了処理_();
                    Player.射精終了処理_();
                    TrainingTarget.Body.VaginalCumDrip.精液濃度 = 0.0;
                    TrainingTarget.Body.XRay.精液濃度 = 0.0;
                    TrainingTarget.Body.スタンプClear();
                    TrainingTarget.Body.Waist.位置B = Med.Base.GetPosition(new Vector2D(0.5, 0.5));
                    TrainingTarget.Body.汗染み濃度 = 0.0;
                    TrainingTarget.Body.SplashIntencity = 0.0;
                    TrainingTarget.Body.SquirtStainIntensity = 0.0;
                    TrainingTarget.Body.UrineStainIntensity = 0.0;
                    if (!TrainingTarget.Body.Is粘)
                    {
                        TrainingTarget.Body.XRay_表示 = false;
                    }
                    TrainingTarget.EyeTracking.End();
                    TrainingTarget.MouthCumDrip.End();
                    TrainingTarget.GenitalCumDrip.End();
                    TrainingTarget.AnalCumDrip.End();
                    TrainingTarget.ThreadCumDrip.End();
                    TrainingTarget.Body.SetWaist();
                    if (GlobalState.GameData.TrainingTarget.Trained)
                    {
                        TrainingTarget.Body.拘束具_表示 = false;
                        TrainingTarget.Body.首輪_表示 = true;
                        TrainingTarget.Set基本姿勢();
                    }
                    else
                    {
                        TrainingTarget.Body.拘束具_表示 = true;
                        TrainingTarget.Set拘束姿勢();
                    }
                    TrainingTarget.Emotion();
                    TrainingTarget.SetInitialExpression();
                    TrainingTarget.口修正();
                    TrainingTarget.Tounge_無し();
                    TrainingTarget.Set衣装(GlobalState.GameData.TrainingTarget.着衣);
                    Player.SetState();
                    Player.表示ステート更新();
                    Player.ModBox();
                    Player.SensBox();
                    TrainingTarget.Body.カーソル = null;
                    TrainingTarget.Body.Join();
                    TrainingTarget.Body.Update();
                    SlaveTextBubble.接続();
                    SlaveTextBubble.消失.End();
                    Result2 = false;
                    Result3 = false;
                    si.Set(bre: false);
                    GlobalState.GameData.目隠帯 = false;
                    GlobalState.GameData.玉口枷 = false;
                    GlobalState.GameData.拘束具 = false;
                    GlobalState.GameData.XRay = false;
                },
                Draw = delegate (FpsCounter FPS)
                {
                    SwitchMode(Med, DrawBuffer, FPS, 中継描画);
                }
            };
    	}

    	public static Module 対象(ModeEventDispatcher Med)
    	{
    		try
    		{
    			uint 胸施術価格 = 10000000u;
    			uint 股施術価格 = 10000000u;
    			uint 淫紋価格 = 10000000u;
    			uint 衣装変更価格 = 10000000u;
    			bool d = false;
    			ButtonMap bs = new ButtonMap();
    			ScreenSwitch 保守sw = new ScreenSwitch(Color.DarkRed);
    			ScreenSwitch 一般sw = new ScreenSwitch(Color.DarkRed);
    			ScreenSwitch 娼婦sw = new ScreenSwitch(Color.DarkRed);
    			int i = 0;
    			int f = 0;

                ListView lv = MyUI.Select(DrawBuffer, new Vector2D(0.01, 0.08),
                    Enumerable.Repeat(new TextAction("No Slave".PadLeft(15, ' '), delegate { }), 15).ToArray()
                );

    			Color lv初期縁色 = ColorHelper.Black;
    			Action lv縁色初期化 = delegate
    			{
    				foreach (ButtonBase item in lv.bs.EnumBut)
    				{
    					item.PartGroup.Values.First().ToParT().SetPenColor(lv初期縁色);
    				}
    			};
    			Action<Unit> SetUI = delegate(Unit u)
    			{
    				if (u != null)
    				{
    					ip.TextIm = u.GetStatus();
    					bs["MoveRoomDown"].Dra = GlobalState.MoveButton;
    					bs["MoveRoomUp"].Dra = GlobalState.MoveButton;
    					bs["MoveFloorDown"].Dra = GlobalState.MoveButton;
    					bs["MoveFloorUp"].Dra = GlobalState.MoveButton;
    					bs["子"].Dra = true;
    					bs["親形質1"].Dra = true;
    					bs["親形質2"].Dra = true;
    					保守sw.SetFlag(bs["保守"], u.保守);
    					一般sw.SetFlag(bs["一般労働"], u.Laboror);
    					娼婦sw.SetFlag(bs["娼婦労働"], u.Prostitute);
    					bs["保守"].Dra = true;
    					bs["一般労働"].Dra = u.非妊娠 && u.Trained;
    					bs["娼婦労働"].Dra = u.非妊娠 && u.Trained;
    					bs["売却"].Dra = !u.保守;
    					bs["胸施術"].Dra = GlobalState.GameData.施術 && !u.ChaD.胸施術 && u.ChaD.Is胸甲殻();
    					bs["股施術"].Dra = GlobalState.GameData.施術 && !u.ChaD.股施術 && u.ChaD.Is股防御();
    					bs["淫紋"].Dra = GlobalState.GameData.淫紋 && u.Trained && !u.ChaD.タトゥ && !u.ChaD.Isタトゥ();
    					bs["衣装"].Dra = GlobalState.GameData.衣装 && u.Trained;
    				}
    				else
    				{
    					npl.Text = "No Slave";
    					ip.TextIm = " ";
    					bs["MoveRoomDown"].Dra = false;
    					bs["MoveRoomUp"].Dra = false;
    					bs["MoveFloorDown"].Dra = false;
    					bs["MoveFloorUp"].Dra = false;
    					bs["子"].Dra = false;
    					bs["親形質1"].Dra = false;
    					bs["親形質2"].Dra = false;
    					bs["保守"].Dra = false;
    					bs["一般労働"].Dra = false;
    					bs["娼婦労働"].Dra = false;
    					bs["売却"].Dra = false;
    					bs["胸施術"].Dra = false;
    					bs["股施術"].Dra = false;
    					bs["淫紋"].Dra = false;
    					bs["衣装"].Dra = false;
    				}
    			};
    			Action<int> set = delegate(int n)
    			{
    				i = 0;
    				lv.Acts = Enumerable.Repeat(new TextAction("", delegate
    				{
    				}), 15).Select(delegate(TextAction e)
    				{
    					Unit u = GlobalState.GameData.Slaves[n + i];
    					if (u == null)
    					{
    						e.Text = "No Slave";
    						e.act = delegate(ButtonBase b)
    						{
    							lv縁色初期化();
    							b.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    							GlobalState.GameData.TrainingTarget = null;
    							if (TrainingTarget != null)
    							{
    								TrainingTarget.Dispose();
    								TrainingTarget = null;
    							}
    							SetUI(null);
    						};
    					}
    					else
    					{
    						e.Text = GameText.収容番号 + u.Number;
    						e.act = delegate(ButtonBase b)
    						{
    							lv縁色初期化();
    							b.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    							GlobalState.GameData.TrainingTarget = u;
    							bs["子"].Action(bs["子"]);
    							if (ip.Mai2Show)
    							{
    								if (GlobalState.GameData.TrainingTarget == null)
    								{
    									ip.Mai2Im = " ";
    									ip.選択肢表示 = false;
    								}
    								else
    								{
    									d = false;
    									bs["売却"].Action(bs["売却"]);
    									d = true;
    								}
    							}
    						};
    					}
    					int num8 = i;
    					i = num8 + 1;
    					return e;
    				});
    			};
    			lv.SetHitColor(Med);

                Color bs初期縁色 = ColorHelper.Black;
                Action bs縁色初期化 = delegate
                {
                    foreach (ButtonBase item2 in bs.EnumBut.Skip(1).Take(3))
                    {
                        item2.PartGroup.Values.First().ToParT().SetPenColor(bs初期縁色);
                    }
                };
                Color f初期縁色 = ColorHelper.Black;
                Action f縁色初期化 = delegate
                {
                    foreach (ButtonBase item3 in bs.EnumBut.Skip(10))
                    {
                        item3.PartGroup.Values.First().ToParT().SetPenColor(f初期縁色);
                    }
                };
                Action<ButtonBase, int> 階層選択 = delegate (ButtonBase b, int o)
                {
                    f縁色初期化();
                    b.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
                    set(o);
                };
                Action 部屋選択 = delegate
                {
                    lv縁色初期化();
                    if (GlobalState.GameData.TrainingTarget != null && f == GlobalState.GameData.TrainingTarget.階層位置 * 15)
                    {
                        lv.bs[GlobalState.GameData.TrainingTarget.RoomNumber.ToString()].PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
                    }
                };

                Module mod = new Module
                {
                    Down = delegate (MouseButtons mb, Vector2D cp, Color hc)
                    {
                        if (SDShow)
                        {
                            SaveData.Down(ref hc);
                            if (mb == MouseButtons.Right)
                            {
                                //TODO fix?
                                //Sounds.操作.Play();
                                SDShow = false;
                                ip.Up(ref hc);
                                dbs.Move(ref hc);
                            }
                        }
                        else
                        {
                            switch (mb)
                            {
                                case MouseButtons.Left:
                                    if (!ip.Mai2Show)
                                    {
                                        dbs.Down(ref hc);
                                        bs.Down(ref hc);
                                    }
                                    lv.Down(ref hc);
                                    ip.Down(ref hc);
                                    break;
                                case MouseButtons.Right:
                                    if (!ip.Mai2Show)
                                    {
                                        bs["ボタン0"].Action(bs["ボタン0"]);
                                    }
                                    else
                                    {
                                        ip.nb.Action(ip.nb);
                                    }
                                    break;
                            }
                        }
                    },
                    Up = delegate (MouseButtons mb, Vector2D cp, Color hc)
                    {
                        if (SDShow)
                        {
                            SaveData.Up(ref hc);
                        }
                        else if (mb == MouseButtons.Left)
                        {
                            if (!ip.Mai2Show)
                            {
                                dbs.Up(ref hc);
                                bs.Up(ref hc);
                            }
                            lv.Up(ref hc);
                            ip.Up(ref hc);
                        }
                    },
                    Move = delegate (MouseButtons mb, Vector2D cp, Color hc)
                    {
                        if (SDShow)
                        {
                            SaveData.Move(ref hc);
                        }
                        else
                        {
                            if (!ip.Mai2Show)
                            {
                                dbs.Move(ref hc);
                                bs.Move(ref hc);
                                if (bs["胸施術"].PartGroup.Values.First().ToPar().GetHitColor() == hc && !(ip.SubInfoIm == GameText.胸の甲殻を切除しました) && !(ip.SubInfoIm == GameText.所持金が足りません))
                                {
                                    ip.SubInfoIm = GameText.胸の甲殻を切除します + "(-" + 胸施術価格.ToString("#,0") + ")";
                                }
                                else if (ip.SubInfoIm == GameText.胸の甲殻を切除します + "(-" + 胸施術価格.ToString("#,0") + ")")
                                {
                                    si.Set(bre: false);
                                }
                                if (TrainingTarget != null)
                                {
                                    if (bs["股施術"].PartGroup.Values.First().ToPar().GetHitColor() == hc && !(ip.SubInfoIm == GameText.股の + (TrainingTarget.Body.Is蛇 ? GameText.鱗 : GameText.甲殻) + GameText.を切除しました) && !(ip.SubInfoIm == GameText.所持金が足りません))
                                    {
                                        ip.SubInfoIm = GameText.股の + (TrainingTarget.Body.Is蛇 ? GameText.鱗 : GameText.甲殻) + GameText.を切除します + "(-" + 股施術価格.ToString("#,0") + ")";
                                    }
                                    else if (ip.SubInfoIm == GameText.股の + (TrainingTarget.Body.Is蛇 ? GameText.鱗 : GameText.甲殻) + GameText.を切除します + "(-" + 股施術価格.ToString("#,0") + ")")
                                    {
                                        si.Set(bre: false);
                                    }
                                }
                                if (bs["淫紋"].PartGroup.Values.First().ToPar().GetHitColor() == hc && !(ip.SubInfoIm == GameText.淫紋を刻みました) && !(ip.SubInfoIm == GameText.所持金が足りません))
                                {
                                    ip.SubInfoIm = GameText.淫紋を刻みます + "(-" + 淫紋価格.ToString("#,0") + ")";
                                }
                                else if (ip.SubInfoIm == GameText.淫紋を刻みます + "(-" + 淫紋価格.ToString("#,0") + ")")
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["衣装"].PartGroup.Values.First().ToPar().GetHitColor() == hc && !(ip.SubInfoIm == GameText.衣装を変更しました) && !(ip.SubInfoIm == GameText.所持金が足りません))
                                {
                                    ip.SubInfoIm = GameText.衣装を変更します + "(-" + 衣装変更価格.ToString("#,0") + ")";
                                }
                                else if (ip.SubInfoIm == GameText.衣装を変更します + "(-" + 衣装変更価格.ToString("#,0") + ")")
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["保守"].PartGroup.Values.First().ToPar().GetHitColor() == hc && !(ip.SubInfoIm == GameText.奴隷を保守対象に設定しました) && !(ip.SubInfoIm == GameText.奴隷の保守設定を解除しました))
                                {
                                    ip.SubInfoIm = GameText.奴隷の保守設定を切り替えます;
                                }
                                else if (ip.SubInfoIm == GameText.奴隷の保守設定を切り替えます)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["一般労働"].PartGroup.Values.First().ToPar().GetHitColor() == hc && !(ip.SubInfoIm == GameText.奴隷を一般労働に設定しました) && !(ip.SubInfoIm == GameText.奴隷の一般労働を解除しました))
                                {
                                    ip.SubInfoIm = GameText.奴隷の一般労働設定を切り替えます;
                                }
                                else if (ip.SubInfoIm == GameText.奴隷の一般労働設定を切り替えます)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["娼婦労働"].PartGroup.Values.First().ToPar().GetHitColor() == hc && !(ip.SubInfoIm == GameText.奴隷を娼婦労働に設定しました) && !(ip.SubInfoIm == GameText.奴隷の娼婦労働を解除しました))
                                {
                                    ip.SubInfoIm = GameText.奴隷の娼婦労働設定を切り替えます;
                                }
                                else if (ip.SubInfoIm == GameText.奴隷の娼婦労働設定を切り替えます)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["売却"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
                                {
                                    ip.SubInfoIm = GameText.奴隷を売却します;
                                }
                                else if (ip.SubInfoIm == GameText.奴隷を売却します)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["全一般"].PartGroup.Values.First().ToPar().GetHitColor() == hc && !(ip.SubInfoIm == GameText.労働可能な全ての奴隷に一般労働を設定しました))
                                {
                                    ip.SubInfoIm = GameText.労働可能な全ての奴隷を働かせます;
                                }
                                else if (ip.SubInfoIm == GameText.労働可能な全ての奴隷を働かせます)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["全娼婦"].PartGroup.Values.First().ToPar().GetHitColor() == hc && !(ip.SubInfoIm == GameText.労働可能な全ての奴隷に娼婦労働を設定しました))
                                {
                                    ip.SubInfoIm = GameText.労働可能な全ての奴隷を娼婦として働かせます;
                                }
                                else if (ip.SubInfoIm == GameText.労働可能な全ての奴隷を娼婦として働かせます)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["全解除"].PartGroup.Values.First().ToPar().GetHitColor() == hc && !(ip.SubInfoIm == GameText.労働中の全ての奴隷の労働を解除しました))
                                {
                                    ip.SubInfoIm = GameText.全ての奴隷の労働を解除します;
                                }
                                else if (ip.SubInfoIm == GameText.全ての奴隷の労働を解除します)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["全売却"].PartGroup.Values.First().ToPar().GetHitColor() == hc && !ip.SubInfoIm.StartsWith(GameText.保守以外の全ての奴隷を売却しました) && !(ip.SubInfoIm == GameText.全売却をキャンセルしました))
                                {
                                    ip.SubInfoIm = GameText.保守以外の全ての奴隷を売却します;
                                }
                                else if (ip.SubInfoIm == GameText.保守以外の全ての奴隷を売却します)
                                {
                                    si.Set(bre: false);
                                }
                                Player説明(ref hc, delegate
                                {
                                    si.Set(bre: false);
                                });
                            }
                            lv.Move(ref hc);
                            ip.Move(ref hc);
                        }
                    },
                    Leave = delegate
                    {
                        if (SDShow)
                        {
                            SaveData.Leave();
                        }
                        else
                        {
                            if (!ip.Mai2Show)
                            {
                                dbs.Leave();
                                bs.Leave();
                            }
                            lv.Leave();
                        }
                    },
                    Wheel = delegate (MouseButtons mb, Vector2D cp, int dt, Color hc)
                    {
                        int num2 = 0;
                        using (IEnumerator<ButtonBase> enumerator2 = bs.EnumBut.Skip(12).GetEnumerator())
                        {
                            while (enumerator2.MoveNext() && !(enumerator2.Current.PartGroup.Values.First().ToParT().GetPenColor() == Color.Red))
                            {
                                num2++;
                            }
                        }
                        int num3 = 0;
                        using (IEnumerator<ButtonBase> enumerator2 = lv.bs.EnumBut.GetEnumerator())
                        {
                            while (enumerator2.MoveNext() && !(enumerator2.Current.PartGroup.Values.First().ToParT().GetPenColor() == Color.Red))
                            {
                                num3++;
                            }
                        }
                        int num4 = num3 - dt.Sign();
                        d = false;
                        if (num4 < 0 && num2 > 0)
                        {
                            ButtonBase but3 = bs["ボタン" + num2];
                            but3.Action(but3);
                            num4 = 14;
                        }
                        else if (num4 > 14 && num2 < GlobalState.GameData.フロア数 - 1)
                        {
                            ButtonBase but4 = bs["ボタン" + (num2 + 2)];
                            but4.Action(but4);
                            num4 = 0;
                        }
                        d = true;
                        ButtonBase but5 = lv.bs[num4.Limit(0, 15).ToString()];
                        but5.Action(but5);
                        if (ip.Mai2Show)
                        {
                            if (GlobalState.GameData.TrainingTarget == null)
                            {
                                ip.Mai2Im = " ";
                                ip.選択肢表示 = false;
                            }
                            else
                            {
                                d = false;
                                bs["売却"].Action(bs["売却"]);
                                d = true;
                            }
                        }
                    },
                    Setting = delegate
                    {
                        if (Med.Modeb != "PlayerInformation")
                        {
                            for (int j = 1; j <= 9; j++)
                            {
                                bs["ボタン" + j].Dra = false;
                            }
                            for (int k = 1; k <= GlobalState.GameData.フロア数; k++)
                            {
                                bs["ボタン" + k].Dra = true;
                            }
                            ip.UpdateSub2();
                            ip.MaiShow = true;
                            ip.Mai.Feed.Dra = false;
                            ip.Mai2Show = false;
                            ip.SubShow = true;
                            ip.Sub2Show = true;
                            d = false;
                            Player.UI.ステート描画 = false;
                            if (GlobalState.GameData.TrainingTarget != null)
                            {
                                ButtonBase buttonBase = bs["ボタン" + (GlobalState.GameData.TrainingTarget.階層位置 + 1)];
                                buttonBase.Action(buttonBase);
                                lv縁色初期化();
                                lv.bs[GlobalState.GameData.TrainingTarget.RoomNumber.ToString()].PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
                                bs["子"].Action(bs["子"]);
                            }
                            else
                            {
                                ip.TextIm = GameText.対象が設定されていません;
                                階層選択(bs["ボタン" + (f / 15 + 1)], f);
                                SetUI(null);
                                int num = 0;
                                using (IEnumerator<ButtonBase> enumerator = lv.bs.EnumBut.GetEnumerator())
                                {
                                    while (enumerator.MoveNext() && !(enumerator.Current.PartGroup.Values.First().ToParT().GetPenColor() == Color.Red))
                                    {
                                        num++;
                                    }
                                }
                                ButtonBase but2 = lv.bs[num.Limit(0, 15).ToString()];
                                but2.Action(but2);
                            }
                            d = true;
                            si.Set(bre: false);
                            if (GlobalState.BigWindow)
                            {
                                npl.ShapePartT.SetPositionBase(new Vector2D(0.095, 0.035));
                            }
                            else
                            {
                                npl.ShapePartT.SetPositionBase(new Vector2D(ip.MaiB.GetPosition().X, 0.026));
                            }
                        }
                    },
                    Draw = delegate (FpsCounter FPS)
                    {
                        SwitchMode(Med, DrawBuffer, FPS, 対象描画);
                    },
                    Dispose = delegate
                    {
                        lv.Dispose();
                        bs.Dispose();
                    }
                };

                bs.Add("ボタン0", MyUI.Button2(Med, DrawBuffer, GameText.戻る, new Vector2D(0.85, 0.02), delegate
                {
                    ////Sounds.操作.Play();
                    if (GlobalState.GameData.TrainingTarget != null && bs["子"].PartGroup.Values.First().ToParT().GetPenColor() != Color.Red)
                    {
                        SetTrainingTarget(Med, GlobalState.GameData.TrainingTarget);
                        SetUI(GlobalState.GameData.TrainingTarget);
                    }
                    Med.Mode = "メインフォーム";
                }));

                //TODO colors?
                //shapePartT2.PenColor = Color.Red;
                bs.Add("子", MyUI.Button2(Med, DrawBuffer, GameText.子, new Vector2D(0.85, 0.1), delegate (ButtonBase b)
    			{
    				if (d)
    				{
    					////Sounds.操作.Play();
    				}
    				bs縁色初期化();
    				b.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    				if (GlobalState.GameData.TrainingTarget != null)
    				{
    					if (TrainingTarget == null || TrainingTarget.CharacterData != GlobalState.GameData.TrainingTarget.ChaD)
    					{
    						SetTrainingTarget(Med, GlobalState.GameData.TrainingTarget);
    					}
    					SetUI(GlobalState.GameData.TrainingTarget);
    					bs["胸施術"].Dra = GlobalState.GameData.施術 && !GlobalState.GameData.TrainingTarget.ChaD.胸施術 && GlobalState.GameData.TrainingTarget.ChaD.Is胸甲殻();
    					bs["股施術"].Dra = GlobalState.GameData.施術 && !GlobalState.GameData.TrainingTarget.ChaD.股施術 && GlobalState.GameData.TrainingTarget.ChaD.Is股防御();
    					bs["淫紋"].Dra = GlobalState.GameData.淫紋 && GlobalState.GameData.TrainingTarget.Trained && !GlobalState.GameData.TrainingTarget.ChaD.タトゥ && !GlobalState.GameData.TrainingTarget.ChaD.Isタトゥ();
    					bs["衣装"].Dra = GlobalState.GameData.衣装 && GlobalState.GameData.TrainingTarget.Trained;
    				}
    			}));

    			bs.Add("親形質1", MyUI.Button2(Med, DrawBuffer, GameText.親形質1, new Vector2D(0.85, 0.18), delegate(ButtonBase b)
    			{
    				////Sounds.操作.Play();
    				bs縁色初期化();
    				b.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    				if (GlobalState.GameData.TrainingTarget != null)
    				{
    					if (TrainingTarget != null)
    					{
    						TrainingTarget.Dispose();
    					}
    					TrainingTarget = new Character(Med, DrawBuffer, GlobalState.GameData.TrainingTarget.Mother.ChaD);
    					if (TrainingTarget.Body.IsDualEyes)
    					{
    						TrainingTarget.両目_見つめ();
    					}
    					if (TrainingTarget.Body.IsCheekEyes)
    					{
    						TrainingTarget.両頬目_見つめ();
    					}
    					if (TrainingTarget.Body.IsSingleEye)
    					{
    						TrainingTarget.単目_見つめ();
    					}
    					if (TrainingTarget.Body.IsForeheadEye)
    					{
    						TrainingTarget.額目_見つめ();
    					}
    					if (GlobalState.GameData.TrainingTarget.Mother.Race == GameText.ヴィオランテ)
    					{
    						TrainingTarget.両瞼_卑();
    						TrainingTarget.両瞼_半1();
    					}
    					TrainingTarget.口_閉笑();
    					TrainingTarget.Set基本姿勢();
    					npl.Text = GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + "\r\n" + GameText.親形質1;
    					ip.TextIm = GlobalState.GameData.TrainingTarget.Mother.GetStatus();
    					bs["胸施術"].Dra = false;
    					bs["股施術"].Dra = false;
    					bs["淫紋"].Dra = false;
    					bs["衣装"].Dra = false;
    				}
    			}));

    			bs.Add("親形質2", MyUI.Button2(Med, DrawBuffer, GameText.親形質2, new Vector2D(0.85, 0.26), delegate(ButtonBase b)
    			{
    				////Sounds.操作.Play();
    				bs縁色初期化();
    				b.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    				if (GlobalState.GameData.TrainingTarget != null)
    				{
    					if (TrainingTarget != null)
    					{
    						TrainingTarget.Dispose();
    					}
    					TrainingTarget = new Character(Med, DrawBuffer, GlobalState.GameData.TrainingTarget.Father.ChaD);
    					if (TrainingTarget.Body.IsDualEyes)
    					{
    						TrainingTarget.両目_見つめ();
    					}
    					if (TrainingTarget.Body.IsCheekEyes)
    					{
    						TrainingTarget.両頬目_見つめ();
    					}
    					if (TrainingTarget.Body.IsSingleEye)
    					{
    						TrainingTarget.単目_見つめ();
    					}
    					if (TrainingTarget.Body.IsForeheadEye)
    					{
    						TrainingTarget.額目_見つめ();
    					}
    					if (GlobalState.GameData.TrainingTarget.Father.Race == GameText.ヴィオランテ)
    					{
    						TrainingTarget.両瞼_卑();
    						TrainingTarget.両瞼_半1();
    					}
    					TrainingTarget.口_閉笑();
    					TrainingTarget.Set基本姿勢();
    					npl.Text = GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + "\r\n" + GameText.親形質2;
    					ip.TextIm = GlobalState.GameData.TrainingTarget.Father.GetStatus();
    					bs["胸施術"].Dra = false;
    					bs["股施術"].Dra = false;
    					bs["淫紋"].Dra = false;
    					bs["衣装"].Dra = false;
    				}
    			}));

    			bs.Add("保守", MyUI.Button2(Med, DrawBuffer, GameText.保守, new Vector2D(0.85, 0.34), delegate(ButtonBase b)
    			{
    				////Sounds.操作.Play();
    				if (GlobalState.GameData.TrainingTarget != null)
    				{
    					保守sw.OnOff(b);
    					GlobalState.GameData.TrainingTarget.保守 = 保守sw.Flag;
    					bs["売却"].Dra = !GlobalState.GameData.TrainingTarget.保守;
    					ip.SubInfoIm = (GlobalState.GameData.TrainingTarget.保守 ? GameText.奴隷を保守対象に設定しました : GameText.奴隷の保守設定を解除しました);
    				}
    			}));

    			bs.Add("一般労働", MyUI.Button2(Med, DrawBuffer, GameText.一般労働, new Vector2D(0.85, 0.42), delegate(ButtonBase b)
    			{
    				////Sounds.操作.Play();
    				if (GlobalState.GameData.TrainingTarget != null)
    				{
    					一般sw.OnOff(b);
    					GlobalState.GameData.TrainingTarget.Laboror = 一般sw.Flag;
    					if (一般sw.Flag && 娼婦sw.Flag)
    					{
    						娼婦sw.SetFlag(bs["娼婦労働"], On: false);
    					}
    					GlobalState.GameData.TrainingTarget.Prostitute = 娼婦sw.Flag;
    					ip.SubInfoIm = (GlobalState.GameData.TrainingTarget.Laboror ? GameText.奴隷を一般労働に設定しました : GameText.奴隷の一般労働を解除しました);
    				}
    			}));

    			bs.Add("娼婦労働", MyUI.Button2(Med, DrawBuffer, GameText.娼婦労働, new Vector2D(0.85, 0.5), delegate (ButtonBase b)
    			{
    				////Sounds.操作.Play();
    				if (GlobalState.GameData.TrainingTarget != null)
    				{
    					娼婦sw.OnOff(b);
    					GlobalState.GameData.TrainingTarget.Prostitute = 娼婦sw.Flag;
    					if (娼婦sw.Flag && 一般sw.Flag)
    					{
    						一般sw.SetFlag(bs["一般労働"], On: false);
    					}
    					GlobalState.GameData.TrainingTarget.Laboror = 一般sw.Flag;
    					ip.SubInfoIm = (GlobalState.GameData.TrainingTarget.Prostitute ? GameText.奴隷を娼婦労働に設定しました : GameText.奴隷の娼婦労働を解除しました);
    				}
    			}));
    			
                bs.Add("全一般", MyUI.Button2(Med, DrawBuffer, GameText.全一般, new Vector2D(0.75, 0.405), delegate
    			{
    				////Sounds.操作.Play();
    				if (GlobalState.GameData.TrainingTarget != null)
    				{
    					一般sw.SetFlag(bs["一般労働"], On: true);
    					娼婦sw.SetFlag(bs["娼婦労働"], On: false);
    				}
    				Unit[] 地下室3 = GlobalState.GameData.Slaves;
    				foreach (Unit unit3 in 地下室3)
    				{
    					if (unit3 != null && unit3.Trained && unit3.非妊娠)
    					{
    						unit3.Laboror = true;
    						unit3.Prostitute = false;
    					}
    				}
    				ip.SubInfoIm = GameText.労働可能な全ての奴隷に一般労働を設定しました;
    			}));

    			bs.Add("全娼婦", MyUI.Button2(Med, DrawBuffer, GameText.全娼婦, new Vector2D(0.75, 0.485), delegate
    			{
    				////Sounds.操作.Play();
    				if (GlobalState.GameData.TrainingTarget != null)
    				{
    					一般sw.SetFlag(bs["一般労働"], On: false);
    					娼婦sw.SetFlag(bs["娼婦労働"], On: true);
    				}
    				Unit[] 地下室2 = GlobalState.GameData.Slaves;
    				foreach (Unit unit2 in 地下室2)
    				{
    					if (unit2 != null && unit2.Trained && unit2.非妊娠)
    					{
    						unit2.Laboror = false;
    						unit2.Prostitute = true;
    					}
    				}
    				ip.SubInfoIm = GameText.労働可能な全ての奴隷に娼婦労働を設定しました;
    			}));

    			bs.Add("全解除", MyUI.Button2(Med, DrawBuffer, GameText.全解除, new Vector2D(0.75, 0.565), delegate
    			{
    				////Sounds.操作.Play();
    				if (GlobalState.GameData.TrainingTarget != null)
    				{
    					一般sw.SetFlag(bs["一般労働"], On: false);
    					娼婦sw.SetFlag(bs["娼婦労働"], On: false);
    				}
    				Unit[] 地下室 = GlobalState.GameData.Slaves;
    				foreach (Unit unit in 地下室)
    				{
    					if (unit != null && unit.Trained)
    					{
    						unit.Laboror = false;
    						unit.Prostitute = false;
    					}
    				}
    				ip.SubInfoIm = GameText.労働中の全ての奴隷の労働を解除しました;
    			}));

    			bs.Add("売却", MyUI.Button2(Med, DrawBuffer, GameText.売却, new Vector2D(0.85, 0.58), delegate
    			{
    				if (d)
    				{
                        //TODO fix?
                        ////Sounds.操作.Play();
    				}
    				ip.Mai2Im = GlobalState.GameData.TrainingTarget.GetPriceInfo();
    				ip.Mai2Show = true;
    				if (!GlobalState.GameData.TrainingTarget.保守)
    				{
    					ip.TextIm = GameText.売却しますか;
    				}
    				ip.選択yAct = delegate
    				{
    					Color HitColor4 = ColorHelper.Empty;
    					bs.Move(ref HitColor4);
    					ulong price = GlobalState.GameData.TrainingTarget.GetPrice();
    					GlobalState.GameData.所持金 = GlobalState.GameData.所持金.overflow_add(price);
    					//Sounds.精算.Play();
    					ip.UpdateSub2();
    					for (int m = 0; m < GlobalState.GameData.Slaves.Length; m++)
    					{
    						if (GlobalState.GameData.Slaves[m] == GlobalState.GameData.TrainingTarget)
    						{
    							GlobalState.GameData.Slaves[m] = null;
    							break;
    						}
    					}
    					GlobalState.GameData.地下室詰め();
    					set(f);
    					ip.SubInfoIm = GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + GameText.を売却しました + " \r\n+" + price.ToString("#,0");
    					d = false;
    					ButtonBase but8 = bs["ボタン" + (GlobalState.GameData.TrainingTarget.階層位置 + 1)];
    					but8.Action(but8);
    					ButtonBase but9 = lv.bs.EnumBut.ToArray()[GlobalState.GameData.TrainingTarget.RoomNumber];
    					but9.Action(but9);
    					if (GlobalState.GameData.TrainingTarget == null)
    					{
    						ip.Mai2Im = " ";
    						ip.選択肢表示 = false;
    					}
    					else
    					{
    						d = false;
    						bs["売却"].Action(bs["売却"]);
    					}
    					d = true;
    				};
    				ip.選択nAct = delegate
    				{
    					//Sounds.操作.Play();
    					Color HitColor3 = ColorHelper.Empty;
    					bs.Move(ref HitColor3);
    					ip.Mai2Show = false;
    					if (GlobalState.GameData.TrainingTarget == null)
    					{
    						ip.TextIm = " ";
    					}
    					else
    					{
    						ip.TextIm = GlobalState.GameData.TrainingTarget.GetStatus();
    					}
    					ip.SubInfoIm = GameText.売却をキャンセルしました;
    					ip.選択肢表示 = false;
    				};
    				ip.選択肢表示 = !GlobalState.GameData.TrainingTarget.保守;
    			}));

    			bs.Add("全売却", MyUI.Button2(Med, DrawBuffer, GameText.全売却, new Vector2D(0.75, 0.645), delegate
    			{
    				//Sounds.操作.Play();
    				string tb = ip.TextIm;
    				ip.Mai2Im = GlobalState.GameData.GetPriceInfo(out var p);
    				ip.Mai2Show = true;
    				ip.TextIm = GameText.保守以外の全ての奴隷を売却しますか;
    				ip.選択yAct = delegate
    				{
    					Color HitColor2 = ColorHelper.Empty;
    					bs.Move(ref HitColor2);
    					ip.Mai2Show = false;
    					GlobalState.GameData.所持金 = GlobalState.GameData.所持金.overflow_add(p);
                        //TODO fix?
                        ////Sounds.精算.Play();
    					ip.UpdateSub2();
    					for (int l = 0; l < GlobalState.GameData.Slaves.Length; l++)
    					{
    						if (GlobalState.GameData.Slaves[l] != null && !GlobalState.GameData.Slaves[l].保守)
    						{
    							GlobalState.GameData.Slaves[l] = null;
    						}
    					}
    					GlobalState.GameData.地下室詰め();
    					set(f);
    					d = false;
    					if (GlobalState.GameData.TrainingTarget != null)
    					{
    						if (!GlobalState.GameData.TrainingTarget.保守)
    						{
    							ButtonBase but6 = bs["ボタン" + (GlobalState.GameData.TrainingTarget.階層位置 + 1)];
    							but6.Action(but6);
    							ButtonBase but7 = lv.bs.EnumBut.ToArray()[GlobalState.GameData.TrainingTarget.RoomNumber];
    							but7.Action(but7);
    						}
    						else if (GlobalState.AlwaysUseName)
    						{
                                npl.Text = GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + "\r\n" + GlobalState.GameData.TrainingTarget.Name;
                            }
    						else
    						{
    							npl.Text = GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + (GlobalState.GameData.TrainingTarget.Trained ? ("\r\n" + GlobalState.GameData.TrainingTarget.Name) : GlobalState.GameData.TrainingTarget.Race);
    						}
    					}
    					ip.SubInfoIm = GameText.保守以外の全ての奴隷を売却しました + " \r\n+" + p.ToString("#,0");
    					ip.TextIm = " ";
    					d = true;
    					ip.選択肢表示 = false;
    				};
    				ip.選択nAct = delegate
    				{
    					//Sounds.操作.Play();
    					Color HitColor = ColorHelper.Empty;
    					bs.Move(ref HitColor);
    					ip.Mai2Show = false;
    					ip.TextIm = tb;
    					ip.SubInfoIm = GameText.全売却をキャンセルしました;
    					ip.選択肢表示 = false;
    				};
    				ip.選択肢表示 = true;
    			}));


    			ShapePartT shapePartT13 = new ShapePartT();
    			shapePartT13.SetFont(new Font("MS Gothic", 0.1f));
    			shapePartT13.SetPositionBase(DrawBuffer.GetPosition(0.03, 0.03));
    			shapePartT13.Text = "1F";
    			shapePartT13.SetFontSize(0.15);
    			shapePartT13.SetSizeBase(0.05);
    			shapePartT13.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    			shapePartT13.SetBasePointBase(shapePartT13.GetOP().GetCenter());
    			shapePartT13.GetOP().ScalingXY(shapePartT13.GetBasePointBase(), 0.3);
    			shapePartT13.SetClosed(true);
    			shapePartT13.SetTextColor(ColorHelper.White);
    			shapePartT13.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    			shapePartT13.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    			shapePartT13.GetStringFormat().Alignment = StringAlignment.Center;
    			shapePartT13.GetStringFormat().LineAlignment = StringAlignment.Center;
    			shapePartT13.SetPenColor(Color.Red);
    			bs.Add("ボタン1", new Button(shapePartT13, delegate(ButtonBase b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 0);
    				部屋選択();
    			}));


    			ShapePartT shapePartT14 = new ShapePartT();
    			shapePartT14.SetFont(new Font("MS Gothic", 0.1f));
    			shapePartT14.SetPositionBase(DrawBuffer.GetPosition(0.07, 0.03));
    			shapePartT14.Text = "2F";
    			shapePartT14.SetFontSize(0.15);
    			shapePartT14.SetSizeBase(0.05);
    			shapePartT14.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    			shapePartT14.SetBasePointBase(shapePartT14.GetOP().GetCenter());
    			shapePartT14.GetOP().ScalingXY(shapePartT14.GetBasePointBase(), 0.3);
    			shapePartT14.SetClosed(true);
    			shapePartT14.SetTextColor(ColorHelper.White);
    			shapePartT14.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    			shapePartT14.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    			shapePartT14.GetStringFormat().Alignment = StringAlignment.Center;
    			shapePartT14.GetStringFormat().LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン2", new Button(shapePartT14, delegate(ButtonBase b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 15);
    				部屋選択();
    			}));
    			ShapePartT shapePartT15 = new ShapePartT();
    			shapePartT15.SetFont(new Font("MS Gothic", 0.1f));
    			shapePartT15.SetPositionBase(DrawBuffer.GetPosition(0.11, 0.03));
    			shapePartT15.Text = "3F";
    			shapePartT15.SetFontSize(0.15);
    			shapePartT15.SetSizeBase(0.05);
    			shapePartT15.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    			shapePartT15.SetBasePointBase(shapePartT15.GetOP().GetCenter());
    			shapePartT15.GetOP().ScalingXY(shapePartT15.GetBasePointBase(), 0.3);
    			shapePartT15.SetClosed(true);
    			shapePartT15.SetTextColor(ColorHelper.White);
    			shapePartT15.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    			shapePartT15.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    			shapePartT15.GetStringFormat().Alignment = StringAlignment.Center;
    			shapePartT15.GetStringFormat().LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン3", new Button(shapePartT15, delegate(ButtonBase b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 30);
    				部屋選択();
    			}));
    			ShapePartT shapePartT16 = new ShapePartT();
    			shapePartT16.SetFont(new Font("MS Gothic", 0.1f));
    			shapePartT16.SetPositionBase(DrawBuffer.GetPosition(0.15, 0.03));
    			shapePartT16.Text = "4F";
    			shapePartT16.SetFontSize(0.15);
    			shapePartT16.SetSizeBase(0.05);
    			shapePartT16.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    			shapePartT16.SetBasePointBase(shapePartT16.GetOP().GetCenter());
    			shapePartT16.GetOP().ScalingXY(shapePartT16.GetBasePointBase(), 0.3);
    			shapePartT16.SetClosed(true);
    			shapePartT16.SetTextColor(ColorHelper.White);
    			shapePartT16.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    			shapePartT16.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    			shapePartT16.GetStringFormat().Alignment = StringAlignment.Center;
    			shapePartT16.GetStringFormat().LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン4", new Button(shapePartT16, delegate(ButtonBase b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 45);
    				部屋選択();
    			}));
    			ShapePartT shapePartT17 = new ShapePartT();
    			shapePartT17.SetFont(new Font("MS Gothic", 0.1f));
    			shapePartT17.SetPositionBase(DrawBuffer.GetPosition(0.19, 0.03));
    			shapePartT17.Text = "5F";
    			shapePartT17.SetFontSize(0.15);
    			shapePartT17.SetSizeBase(0.05);
    			shapePartT17.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    			shapePartT17.SetBasePointBase(shapePartT17.GetOP().GetCenter());
    			shapePartT17.GetOP().ScalingXY(shapePartT17.GetBasePointBase(), 0.3);
    			shapePartT17.SetClosed(true);
    			shapePartT17.SetTextColor(ColorHelper.White);
    			shapePartT17.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    			shapePartT17.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    			shapePartT17.GetStringFormat().Alignment = StringAlignment.Center;
    			shapePartT17.GetStringFormat().LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン5", new Button(shapePartT17, delegate(ButtonBase b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 60);
    				部屋選択();
    			}));
    			ShapePartT shapePartT18 = new ShapePartT();
    			shapePartT18.SetFont(new Font("MS Gothic", 0.1f));
    			shapePartT18.SetPositionBase(DrawBuffer.GetPosition(0.23, 0.03));
    			shapePartT18.Text = "6F";
    			shapePartT18.SetFontSize(0.15);
    			shapePartT18.SetSizeBase(0.05);
    			shapePartT18.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    			shapePartT18.SetBasePointBase(shapePartT18.GetOP().GetCenter());
    			shapePartT18.GetOP().ScalingXY(shapePartT18.GetBasePointBase(), 0.3);
    			shapePartT18.SetClosed(true);
    			shapePartT18.SetTextColor(ColorHelper.White);
    			shapePartT18.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    			shapePartT18.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    			shapePartT18.GetStringFormat().Alignment = StringAlignment.Center;
    			shapePartT18.GetStringFormat().LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン6", new Button(shapePartT18, delegate(ButtonBase b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 75);
    				部屋選択();
    			}));
    			ShapePartT shapePartT19 = new ShapePartT();
    			shapePartT19.SetFont(new Font("MS Gothic", 0.1f));
    			shapePartT19.SetPositionBase(DrawBuffer.GetPosition(0.27, 0.03));
    			shapePartT19.Text = "7F";
    			shapePartT19.SetFontSize(0.15);
    			shapePartT19.SetSizeBase(0.05);
    			shapePartT19.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    			shapePartT19.SetBasePointBase(shapePartT19.GetOP().GetCenter());
    			shapePartT19.GetOP().ScalingXY(shapePartT19.GetBasePointBase(), 0.3);
    			shapePartT19.SetClosed(true);
    			shapePartT19.SetTextColor(ColorHelper.White);
    			shapePartT19.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    			shapePartT19.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    			shapePartT19.GetStringFormat().Alignment = StringAlignment.Center;
    			shapePartT19.GetStringFormat().LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン7", new Button(shapePartT19, delegate(ButtonBase b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 90);
    				部屋選択();
    			}));
    			ShapePartT shapePartT20 = new ShapePartT();
    			shapePartT20.SetFont(new Font("MS Gothic", 0.1f));
    			shapePartT20.SetPositionBase(DrawBuffer.GetPosition(0.31, 0.03));
    			shapePartT20.Text = "8F";
    			shapePartT20.SetFontSize(0.15);
    			shapePartT20.SetSizeBase(0.05);
    			shapePartT20.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    			shapePartT20.SetBasePointBase(shapePartT20.GetOP().GetCenter());
    			shapePartT20.GetOP().ScalingXY(shapePartT20.GetBasePointBase(), 0.3);
    			shapePartT20.SetClosed(true);
    			shapePartT20.SetTextColor(ColorHelper.White);
    			shapePartT20.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    			shapePartT20.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    			shapePartT20.GetStringFormat().Alignment = StringAlignment.Center;
    			shapePartT20.GetStringFormat().LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン8", new Button(shapePartT20, delegate(ButtonBase b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 105);
    				部屋選択();
    			}));
    			ShapePartT shapePartT21 = new ShapePartT();
    			shapePartT21.SetFont(new Font("MS Gothic", 0.1f));
    			shapePartT21.SetPositionBase(DrawBuffer.GetPosition(0.35, 0.03));
    			shapePartT21.Text = "9F";
    			shapePartT21.SetFontSize(0.15);
    			shapePartT21.SetSizeBase(0.05);
    			shapePartT21.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    			shapePartT21.SetBasePointBase(shapePartT21.GetOP().GetCenter());
    			shapePartT21.GetOP().ScalingXY(shapePartT21.GetBasePointBase(), 0.3);
    			shapePartT21.SetClosed(true);
    			shapePartT21.SetTextColor(ColorHelper.White);
    			shapePartT21.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    			shapePartT21.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    			shapePartT21.GetStringFormat().Alignment = StringAlignment.Center;
    			shapePartT21.GetStringFormat().LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン9", new Button(shapePartT21, delegate(ButtonBase b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 120);
    				部屋選択();
    			}));


                //TODO figure out what this did
    			//parT22.OP.ScalingY(shapePartT8.OP.GetCenter(), 0.47);
    			//parT22.OP.Rotation(shapePartT8.OP.GetCenter(), -26.0);
    			bs.Add("胸施術", MyUI.Button2(Med, DrawBuffer, GameText.胸施術, new Vector2D(0.75, 0.085), delegate
    			{
    				if (GlobalState.GameData.所持金 < 胸施術価格)
    				{
    					//Sounds.操作.Play();
    					ip.SubInfoIm = GameText.所持金が足りません;
    				}
    				else
    				{
    					GlobalState.GameData.所持金 -= 胸施術価格;
                        //TODO fix?
                        ////Sounds.精算.Play();
    					ip.UpdateSub2();
    					GlobalState.GameData.TrainingTarget.ChaD.胸施術 = true;
    					TrainingTarget.Body.胸施術();
    					if (GlobalState.GameData.TrainingTarget.着衣 != null)
    					{
    						TrainingTarget.Set衣装(GlobalState.GameData.TrainingTarget.着衣);
    					}
    					GlobalState.GameData.TrainingTarget.体力消費();
    					bs["胸施術"].Dra = false;
    					ip.SubInfoIm = GameText.胸の甲殻を切除しました;
    					TrainingTarget.SetInitialExpression();
    					TrainingTarget.Emotion();
    					TrainingTarget.UpdateExpression();
    					if (GlobalState.GameData.TrainingTarget.Trained)
    					{
    						TrainingTarget.Body.拘束具_表示 = false;
    						TrainingTarget.Body.首輪_表示 = true;
    						TrainingTarget.Set基本姿勢();
    					}
    					else
    					{
    						TrainingTarget.Body.拘束具_表示 = true;
    						TrainingTarget.Set拘束姿勢();
    					}
    				}
    			}));


    			//parT23.OP.ScalingY(shapePartT8.OP.GetCenter(), 0.47);
    			//parT23.OP.Rotation(shapePartT8.OP.GetCenter(), -26.0);
    			bs.Add("股施術", MyUI.Button2(Med, DrawBuffer, GameText.股施術, new Vector2D(0.75, 0.165), delegate
    			{
    				if (GlobalState.GameData.所持金 < 股施術価格)
    				{
    					//Sounds.操作.Play();
    					ip.SubInfoIm = GameText.所持金が足りません;
    				}
    				else
    				{
    					GlobalState.GameData.所持金 -= 股施術価格;
    					//Sounds.精算.Play();
    					ip.UpdateSub2();
    					GlobalState.GameData.TrainingTarget.ChaD.股施術 = true;
    					TrainingTarget.Body.股施術();
    					if (GlobalState.GameData.TrainingTarget.着衣 != null)
    					{
    						TrainingTarget.Set衣装(GlobalState.GameData.TrainingTarget.着衣);
    					}
    					GlobalState.GameData.TrainingTarget.体力消費();
    					bs["股施術"].Dra = false;
    					ip.SubInfoIm = GameText.股の + (TrainingTarget.Body.Is蠍 ? GameText.甲殻 : GameText.鱗) + GameText.を切除しました;
    					TrainingTarget.SetInitialExpression();
    					TrainingTarget.Emotion();
    					TrainingTarget.UpdateExpression();
    					if (GlobalState.GameData.TrainingTarget.Trained)
    					{
    						TrainingTarget.Body.拘束具_表示 = false;
    						TrainingTarget.Body.首輪_表示 = true;
    						TrainingTarget.Set基本姿勢();
    					}
    					else
    					{
    						TrainingTarget.Body.拘束具_表示 = true;
    						TrainingTarget.Set拘束姿勢();
    					}
    				}
    			}));

    			//parT24.OP.ScalingY(shapePartT8.OP.GetCenter(), 0.47);
    			//parT24.OP.Rotation(shapePartT8.OP.GetCenter(), -26.0);
    			bs.Add("淫紋", MyUI.Button2(Med, DrawBuffer, GameText.淫紋, new Vector2D(0.75, 0.245), delegate
    			{
    				if (GlobalState.GameData.所持金 < 淫紋価格)
    				{
    					//Sounds.操作.Play();
    					ip.SubInfoIm = GameText.所持金が足りません;
    				}
    				else
    				{
    					GlobalState.GameData.所持金 -= 淫紋価格;
    					//Sounds.精算.Play();
    					ip.UpdateSub2();
    					GlobalState.GameData.TrainingTarget.ChaD.タトゥ = true;
    					TrainingTarget.Body.タトゥ();
    					GlobalState.GameData.TrainingTarget.発情フラグ = true;
    					GlobalState.GameData.TrainingTarget.体力消費();
    					bs["淫紋"].Dra = false;
    					ip.SubInfoIm = GameText.淫紋を刻みました;
    					TrainingTarget.SetInitialExpression();
    					TrainingTarget.Emotion();
    					TrainingTarget.UpdateExpression();
    					if (GlobalState.GameData.TrainingTarget.Trained)
    					{
    						TrainingTarget.Body.拘束具_表示 = false;
    						TrainingTarget.Body.首輪_表示 = true;
    						TrainingTarget.Set基本姿勢();
    					}
    					else
    					{
    						TrainingTarget.Body.拘束具_表示 = true;
    						TrainingTarget.Set拘束姿勢();
    					}
    					if (TrainingTarget.Body.Is獣)
    					{
    						TrainingTarget.Body.EI半中1.Updatef = true;
    					}
    				}
    			}));

    			//parT25.OP.ScalingY(shapePartT9.OP.GetCenter(), 0.47);
    			//parT25.OP.Rotation(shapePartT9.OP.GetCenter(), -26.0);
    			bs.Add("衣装", MyUI.Button2(Med, DrawBuffer, GameText.衣装, new Vector2D(0.75, 0.325), delegate
    			{
    				if (GlobalState.GameData.所持金 < 衣装変更価格)
    				{
                        //TODO fix?
                        ////Sounds.操作.Play();
    					ip.SubInfoIm = GameText.所持金が足りません;
    				}
    				else
    				{
    					GlobalState.GameData.所持金 -= 衣装変更価格;
                        //TODO fix?
                        ////Sounds.精算.Play();
    					ip.UpdateSub2();
    					GlobalState.GameData.TrainingTarget.Change衣装();
    					TrainingTarget.Set衣装(GlobalState.GameData.TrainingTarget.着衣);
    					ip.SubInfoIm = GameText.衣装を変更しました;
    					TrainingTarget.SetInitialExpression();
    					TrainingTarget.Emotion();
    					TrainingTarget.UpdateExpression();
    					if (GlobalState.GameData.TrainingTarget.Trained)
    					{
    						TrainingTarget.Body.拘束具_表示 = false;
    						TrainingTarget.Body.首輪_表示 = true;
    						TrainingTarget.Set基本姿勢();
    					}
    					else
    					{
    						TrainingTarget.Body.拘束具_表示 = true;
    						TrainingTarget.Set拘束姿勢();
    					}
    				}
    			}));

                bs.Add("MoveRoomDown", MyUI.Button(Med, DrawBuffer, "Room ▼", GlobalState.BigWindow ? new Vector2D(0.146, 0.14) : new Vector2D(0.195, 0.1625), delegate
                    {
                        //Sounds.操作.Play();
                        MoveRoomDown();
                        mod.Setting();
                        if (GlobalState.AlwaysUseName)
                        {
                            npl.Text = GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + "\r\n" + GlobalState.GameData.TrainingTarget.Name;
                        }
                        else
                        {
                            npl.Text = GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + (GlobalState.GameData.TrainingTarget.Trained ? ("\r\n" + GlobalState.GameData.TrainingTarget.Name) : ("\r\n" + GlobalState.GameData.TrainingTarget.Race));
                        }
                    }));

                bs.Add("MoveRoomUp", MyUI.Button(Med, DrawBuffer, "Room ▲", GlobalState.BigWindow ? new Vector2D(0.146, 0.11) : new Vector2D(0.195, 0.12), delegate
                    {
                        //Sounds.操作.Play();
                        MoveRoomUp();
                        mod.Setting();
                        if (GlobalState.AlwaysUseName)
                        {
                            npl.Text = GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + "\r\n" + GlobalState.GameData.TrainingTarget.Name;
                        }
                        else
                        {
                            npl.Text = GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + (GlobalState.GameData.TrainingTarget.Trained ? ("\r\n" + GlobalState.GameData.TrainingTarget.Name) : ("\r\n" + GlobalState.GameData.TrainingTarget.Race));
                        }
                    }));
                
                bs.Add("MoveFloorDown", MyUI.Button(Med, DrawBuffer, "Floor ▼", GlobalState.BigWindow ? new Vector2D(0.146, 0.2) : new Vector2D(0.195, 0.2475), delegate
                    {
                        //Sounds.操作.Play();
                        MoveFloorDown();
                        mod.Setting();
                        if (GlobalState.AlwaysUseName)
                        {
                            npl.Text = GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + "\r\n" + GlobalState.GameData.TrainingTarget.Name;
                        }
                        else
                        {
                            npl.Text = GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + (GlobalState.GameData.TrainingTarget.Trained ? ("\r\n" + GlobalState.GameData.TrainingTarget.Name) : ("\r\n" + GlobalState.GameData.TrainingTarget.Race));
                        }
                    }));

                bs.Add("MoveFloorUp", MyUI.Button(Med, DrawBuffer, "Floor ▲", GlobalState.BigWindow ? new Vector2D(0.146, 0.17) : new Vector2D(0.195, 0.205), delegate
                    {
                        //Sounds.操作.Play();
                        MoveFloorUp();
                        mod.Setting();
                        if (GlobalState.AlwaysUseName)
                        {
                            npl.Text = GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + "\r\n" + GlobalState.GameData.TrainingTarget.Name;
                        }
                        else
                        {
                            npl.Text = GameText.収容番号 + GlobalState.GameData.TrainingTarget.Number + (GlobalState.GameData.TrainingTarget.Trained ? ("\r\n" + GlobalState.GameData.TrainingTarget.Name) : ("\r\n" + GlobalState.GameData.TrainingTarget.Race));
                        }
                    }));

    			bs.SetHitColor(Med);

                対象描画 = delegate (RenderArea a, FpsCounter FPS)
                {
                    Med.HitGraphics.Clear(ColorHelper.Transparent);
                    if (a.HitGraphics != null)
                    {
                        a.HitGraphics.Clear(ColorHelper.Transparent);
                    }
                    a.Draw(BasementBackground);
                    if (TrainingTarget != null)
                    {
                        TrainingTarget.Draw(a, FPS);
                        Player.UI.DrawState(a);
                    }
                    a.Draw(npl.ShapePartT);
                    lv.Draw(a);
                    bs.Draw(a);
                    dbs.Draw(a);
                    ip.Draw(a, FPS);
                    if (SDShow)
                    {
                        SaveData.Draw(a);
                    }
                    Med.Draw(a);
                };
                対象UI初期化 = delegate
                {
                    f = 0;
                    npl.Text = "No Slave";
                    lv縁色初期化();
                };

                return mod;
    		}
    		catch (Exception)
    		{
    			return null;
    		}
    	}

    	public static Module Blessing(ModeEventDispatcher Med)
    	{
    		Character 祝福 = null;
    		bool d = false;
    		Lab l = new Lab(DrawBuffer, "ラベル1", new Vector2D(ip.MaiB.GetPosition().X, 0.026), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "No blessing", ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black);
    		ButtonMap bs = new ButtonMap();
    		Action 祝福なし = delegate
    		{
    			bs["子"].Dra = false;
    			bs["親形質1"].Dra = false;
    			bs["親形質2"].Dra = false;
    			bs["祝福解除"].Dra = false;
    			l.Text = "No blessing";
    			ip.MaiShow = false;
    			if (祝福 != null)
    			{
    				祝福.Dispose();
    				祝福 = null;
    			}
    		};

    		bs.Add("ボタン0", MyUI.Button2(Med, DrawBuffer, GameText.戻る, new Vector2D(0.85, 0.02), delegate
    		{
    			//Sounds.操作.Play();
    			Med.Mode = "メインフォーム";
    		}));
    		Action<ButtonMap> rs1 = delegate(ButtonMap bs_)
    		{
    			Color penColor = bs_["ボタン0"].PartGroup.Values.First().ToParT().GetPenColor();
    			foreach (ButtonBase item in bs_.EnumBut.Skip(1))
    			{
    				item.PartGroup.Values.First().ToParT().SetPenColor(penColor);
    			}
    		};

    		bs.Add("子", MyUI.Button2(Med, DrawBuffer, GameText.子, new Vector2D(0.85, 0.1), delegate(ButtonBase bu)
    		{
    			if (d)
    			{
    				//Sounds.操作.Play();
    			}
    			rs1(bs);
    			bu.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    			if (GlobalState.GameData.祝福 != null)
    			{
    				l.Text = GlobalState.GameData.祝福.Name;
    				ip.TextIm = GlobalState.GameData.祝福.GetStatus();
    				if (祝福 != null)
    				{
    					祝福.Dispose();
    				}
    				祝福 = new Character(Med, DrawBuffer, GlobalState.GameData.祝福.ChaD);
    				if (祝福.Body.IsDualEyes)
    				{
    					祝福.両目_見つめ();
    				}
    				if (祝福.Body.IsCheekEyes)
    				{
    					祝福.両頬目_見つめ();
    				}
    				if (祝福.Body.IsSingleEye)
    				{
    					祝福.単目_見つめ();
    				}
    				if (祝福.Body.IsForeheadEye)
    				{
    					祝福.額目_見つめ();
    				}
    				if (GlobalState.GameData.祝福.Race == GameText.ヴィオランテ)
    				{
    					祝福.両瞼_卑();
    					祝福.両瞼_半1();
    				}
    				祝福.口_閉笑();
    				祝福.Set基本姿勢();
    			}
    		}));

    		bs.Add("親形質1", MyUI.Button2(Med, DrawBuffer, GameText.親形質1, new Vector2D(0.85, 0.18), delegate(ButtonBase bu)
    		{
    			//Sounds.操作.Play();
    			rs1(bs);
    			bu.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    			if (GlobalState.GameData.祝福 != null)
    			{
    				l.Text = GameText.親形質1;
    				ip.TextIm = GlobalState.GameData.祝福.Mother.GetStatus();
    				if (祝福 != null)
    				{
    					祝福.Dispose();
    				}
    				祝福 = new Character(Med, DrawBuffer, GlobalState.GameData.祝福.Mother.ChaD);
    				if (祝福.Body.IsDualEyes)
    				{
    					祝福.両目_見つめ();
    				}
    				if (祝福.Body.IsCheekEyes)
    				{
    					祝福.両頬目_見つめ();
    				}
    				if (祝福.Body.IsSingleEye)
    				{
    					祝福.単目_見つめ();
    				}
    				if (祝福.Body.IsForeheadEye)
    				{
    					祝福.額目_見つめ();
    				}
    				if (GlobalState.GameData.祝福.Mother.Race == GameText.ヴィオランテ)
    				{
    					祝福.両瞼_卑();
    					祝福.両瞼_半1();
    				}
    				祝福.口_閉笑();
    				祝福.Set基本姿勢();
    			}
    		}));

    		bs.Add("親形質2", MyUI.Button2(Med, DrawBuffer, GameText.親形質2, new Vector2D(0.85, 0.26), delegate(ButtonBase bu)
    		{
    			//Sounds.操作.Play();
    			rs1(bs);
    			bu.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    			if (GlobalState.GameData.祝福 != null)
    			{
    				l.Text = GameText.親形質2;
    				ip.TextIm = GlobalState.GameData.祝福.Father.GetStatus();
    				if (祝福 != null)
    				{
    					祝福.Dispose();
    				}
    				祝福 = new Character(Med, DrawBuffer, GlobalState.GameData.祝福.Father.ChaD);
    				if (祝福.Body.IsDualEyes)
    				{
    					祝福.両目_見つめ();
    				}
    				if (祝福.Body.IsCheekEyes)
    				{
    					祝福.両頬目_見つめ();
    				}
    				if (祝福.Body.IsSingleEye)
    				{
    					祝福.単目_見つめ();
    				}
    				if (祝福.Body.IsForeheadEye)
    				{
    					祝福.額目_見つめ();
    				}
    				if (GlobalState.GameData.祝福.Father.Race == GameText.ヴィオランテ)
    				{
    					祝福.両瞼_卑();
    					祝福.両瞼_半1();
    				}
    				祝福.口_閉笑();
    				祝福.Set基本姿勢();
    			}
    		}));

    		bs.Add("祝福解除", MyUI.Button2(Med, DrawBuffer, GameText.祝福解除, new Vector2D(0.85, 0.34), delegate
    		{
                //TODO fix?
                //Sounds.解除.Play();
    			GlobalState.GameData.祝福 = null;
    			祝福なし();
    			ip.SubInfoIm = GameText.祝福を解除しました;
    		}));

    		bs.SetHitColor(Med);
    		Action subinfo = delegate
    		{
    			if (GlobalState.GameData.祝福 != null)
    			{
    				ip.SubInfoIm = GlobalState.GameData.祝福.Name + GameText.から祝福を受けています;
    			}
    			else
    			{
    				ip.SubInfoIm = GameText.祝福されていません;
    			}
    		};

            DrawBlessing = delegate (RenderArea a, FpsCounter FPS)
            {
                Med.HitGraphics.Clear(ColorHelper.Transparent);
                if (a.HitGraphics != null)
                {
                    a.HitGraphics.Clear(ColorHelper.Transparent);
                }
                a.Draw(BasementBackground);
                if (祝福 != null)
                {
                    祝福.Draw(a, FPS);
                }
                a.Draw(l.ShapePartT);
                bs.Draw(a);
                dbs.Draw(a);
                ip.Draw(a, FPS);
                if (SDShow)
                {
                    SaveData.Draw(a);
                }
                Med.Draw(a);
            };

            return new Module {
                Down = delegate (MouseButtons mb, Vector2D cp, Color hc)
                {
                    if (SDShow)
                    {
                        SaveData.Down(ref hc);
                        if (mb == MouseButtons.Right)
                        {
                            //Sounds.操作.Play();
                            SDShow = false;
                            ip.Up(ref hc);
                            dbs.Move(ref hc);
                        }
                    }
                    else
                    {
                        switch (mb)
                        {
                            case MouseButtons.Left:
                                if (!ip.選択肢表示)
                                {
                                    dbs.Down(ref hc);
                                    bs.Down(ref hc);
                                }
                                ip.Down(ref hc);
                                break;
                            case MouseButtons.Right:
                                if (!ip.選択肢表示)
                                {
                                    bs["ボタン0"].Action(bs["ボタン0"]);
                                }
                                else
                                {
                                    ip.nb.Action(ip.nb);
                                }
                                break;
                        }
                    }
                },
                Up = delegate (MouseButtons mb, Vector2D cp, Color hc)
                {
                    if (SDShow)
                    {
                        SaveData.Up(ref hc);
                    }
                    else if (mb == MouseButtons.Left)
                    {
                        if (!ip.選択肢表示)
                        {
                            dbs.Up(ref hc);
                            bs.Up(ref hc);
                        }
                        ip.Up(ref hc);
                    }
                },
                Move = delegate (MouseButtons mb, Vector2D cp, Color hc)
                {
                    if (SDShow)
                    {
                        SaveData.Move(ref hc);
                    }
                    else
                    {
                        if (!ip.選択肢表示)
                        {
                            dbs.Move(ref hc);
                            bs.Move(ref hc);
                            Player説明(ref hc, subinfo);
                        }
                        ip.Move(ref hc);
                    }
                },
                Leave = delegate
                {
                    if (SDShow)
                    {
                        SaveData.Leave();
                    }
                    else if (!ip.選択肢表示)
                    {
                        dbs.Leave();
                        bs.Leave();
                    }
                },
                Setting = delegate
                {
                    if (Med.Modeb != "PlayerInformation")
                    {
                        ip.UpdateSub2();
                        ip.MaiShow = true;
                        ip.Mai.Feed.Dra = false;
                        ip.Mai2Show = false;
                        ip.SubShow = true;
                        ip.Sub2Show = true;
                        if (GlobalState.GameData.祝福 != null)
                        {
                            bs["子"].Dra = true;
                            bs["親形質1"].Dra = true;
                            bs["親形質2"].Dra = true;
                            bs["祝福解除"].Dra = true;
                            ip.MaiShow = true;
                        }
                        else
                        {
                            祝福なし();
                        }
                        subinfo();
                        d = false;
                        bs["子"].Action(bs["子"]);
                        d = true;
                    }
                },
                Draw = delegate (FpsCounter FPS)
                {
                    SwitchMode(Med, DrawBuffer, FPS, DrawBlessing);
                },
                Dispose = delegate
                {
                    if (祝福 != null)
                    {
                        祝福.Dispose();
                    }
                    l.Dispose();
                    bs.Dispose();
                }
            };
    	}

    	public static Module Office(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		ButtonMap bs = new ButtonMap();
    		ShapePartT shapePartT = new ShapePartT();
    		shapePartT.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT.SetPositionBase(DrawBuffer.GetPosition(0.85, 0.02));
    		shapePartT.Text = GameText.戻る;
    		shapePartT.SetFontSize(0.15);
    		shapePartT.SetSizeBase(0.05);
    		shapePartT.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT.GetOP().ScalingY(shapePartT.GetOP().GetCenter(), 0.47);
    		shapePartT.GetOP().Rotation(shapePartT.GetOP().GetCenter(), -26.0);
    		shapePartT.SetClosed(true);
    		shapePartT.SetTextColor(ColorHelper.White);
    		shapePartT.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("ボタン0", new Button(shapePartT, delegate
    		{
    			//Sounds.操作.Play();
    			if (!PassTime(Med))
    			{
    				Med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
    			}
    		}));
    		ShapePartT shapePartT2 = new ShapePartT();
    		shapePartT2.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT2.SetPositionBase(DrawBuffer.GetPosition(0.85, 0.1));
    		shapePartT2.Text = GameText.借金;
    		shapePartT2.SetFontSize(0.15);
    		shapePartT2.SetSizeBase(0.05);
    		shapePartT2.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT2.GetOP().ScalingY(shapePartT2.GetOP().GetCenter(), 0.47);
    		shapePartT2.GetOP().Rotation(shapePartT2.GetOP().GetCenter(), -26.0);
    		shapePartT2.SetClosed(true);
    		shapePartT2.SetTextColor(ColorHelper.White);
    		shapePartT2.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT2.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT2.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT2.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("ボタン1", new Button(shapePartT2, delegate
    		{
    			//Sounds.操作.Play();
    			Med.Mode = "Debt";
    		}));
    		ShapePartT shapePartT3 = new ShapePartT();
    		shapePartT3.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT3.SetPositionBase(DrawBuffer.GetPosition(0.85, 0.18));
    		shapePartT3.Text = GameText.購入;
    		shapePartT3.SetFontSize(0.15);
    		shapePartT3.SetSizeBase(0.05);
    		shapePartT3.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT3.GetOP().ScalingY(shapePartT3.GetOP().GetCenter(), 0.47);
    		shapePartT3.GetOP().Rotation(shapePartT3.GetOP().GetCenter(), -26.0);
    		shapePartT3.SetClosed(true);
    		shapePartT3.SetTextColor(ColorHelper.White);
    		shapePartT3.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT3.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT3.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT3.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("ボタン2", new Button(shapePartT3, delegate
    		{
    			//Sounds.操作.Play();
    			Med.Mode = "SlaveShop";
    		}));
    		ShapePartT shapePartT4 = new ShapePartT();
    		shapePartT4.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT4.SetPositionBase(DrawBuffer.GetPosition(0.85, 0.58));
    		shapePartT4.Text = GameText.祝福;
    		shapePartT4.SetFontSize(0.15);
    		shapePartT4.SetSizeBase(0.05);
    		shapePartT4.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT4.GetOP().ScalingY(shapePartT4.GetOP().GetCenter(), 0.47);
    		shapePartT4.GetOP().Rotation(shapePartT4.GetOP().GetCenter(), -26.0);
    		shapePartT4.SetClosed(true);
    		shapePartT4.SetTextColor(ColorHelper.White);
    		shapePartT4.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT4.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT4.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT4.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("ボタン3", new Button(shapePartT4, delegate
    		{
    			//Sounds.操作.Play();
    			Med.SwitchMode("ViolaBlessing", DrawBuffer, 返済イベント描画);
    		}));
    		bs.SetHitColor(Med);
    		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (SDShow)
    			{
    				SaveData.Down(ref hc);
    				if (mb == MouseButtons.Right)
    				{
    					//Sounds.操作.Play();
    					SDShow = false;
    					ip.Up(ref hc);
    					dbs.Move(ref hc);
    				}
    			}
    			else
    			{
    				switch (mb)
    				{
    				case MouseButtons.Left:
    					if (!ip.選択肢表示)
    					{
    						dbs.Down(ref hc);
    						bs.Down(ref hc);
    					}
    					ip.Down(ref hc);
    					break;
    				case MouseButtons.Right:
    					if (!ip.選択肢表示)
    					{
    						bs["ボタン0"].Action(bs["ボタン0"]);
    					}
    					else
    					{
    						ip.nb.Action(ip.nb);
    					}
    					break;
    				}
    			}
    		};
    		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (SDShow)
    			{
    				SaveData.Up(ref hc);
    			}
    			else if (mb == MouseButtons.Left)
    			{
    				if (!ip.選択肢表示)
    				{
    					dbs.Up(ref hc);
    					bs.Up(ref hc);
    				}
    				ip.Up(ref hc);
    			}
    		};
    		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (SDShow)
    			{
    				SaveData.Move(ref hc);
    			}
    			else
    			{
    				if (!ip.選択肢表示)
    				{
    					dbs.Move(ref hc);
    					bs.Move(ref hc);
    					Player説明(ref hc, delegate
    					{
    						si.Set(bre: false);
    					});
    				}
    				ip.Move(ref hc);
    			}
    		};
    		mod.Leave = delegate
    		{
    			if (SDShow)
    			{
    				SaveData.Leave();
    			}
    			else if (!ip.選択肢表示)
    			{
    				dbs.Leave();
    				bs.Leave();
    			}
    		};
    		mod.Setting = delegate
    		{
    			if (Med.Modeb != "PlayerInformation")
    			{
    				ip.UpdateSub2();
    				ip.MaiShow = false;
    				ip.Mai.Feed.Dra = false;
    				ip.Mai2Show = false;
    				ip.SubShow = true;
    				ip.Sub2Show = true;
    				ViolaTextBubble.TextBlock.Feed.Dra = false;
    				bs["ボタン1"].Dra = !GlobalState.GameData.初事務所フラグ;
    				bs["ボタン3"].Dra = GlobalState.GameData.RepaymentStage == 3;
    				Viola.両目_見つめ();
    				Viola.表情_基本0();
    				Viola.Set基本姿勢();
    				if (GlobalState.GameData.初事務所フラグ)
    				{
    					Viola.表情_不敵1();
    					ViolaText.Set();
    				}
    				else
    				{
    					ViolaText.Set();
    				}
    				si.Set(bre: false);
    				if (GlobalState.GameData.RepaymentStage < 3)
    				{
    					if (GlobalState.GameData.RepaymentStage == 0 && GlobalState.GameData.借金 < 単位返済段階額 * 2)
    					{
    						GlobalState.GameData.RepaymentStage = 1;
    						GlobalState.GameData.系統開放[2] = true;
    						GlobalState.GameData.系統開放[3] = true;
    						GlobalState.GameData.心眼 = true;
    						Med.SwitchMode("RepaymentEvent1", DrawBuffer, 返済イベント描画);
    						SetDemandMaximum();
    					}
    					else if (GlobalState.GameData.RepaymentStage == 1 && GlobalState.GameData.借金 < 単位返済段階額)
    					{
    						GlobalState.GameData.RepaymentStage = 2;
    						GlobalState.GameData.系統開放[4] = true;
    						GlobalState.GameData.系統開放[5] = true;
    						GlobalState.GameData.媚薬 = true;
    						GlobalState.GameData.施術 = true;
    						GlobalState.GameData.淫紋 = true;
    						GlobalState.GameData.衣装 = true;
    						Med.SwitchMode("RepaymentEvent2", DrawBuffer, 返済イベント描画);
    						SetDemandMaximum();
    					}
    					else if (GlobalState.GameData.RepaymentStage == 2 && GlobalState.GameData.借金 == 0L)
    					{
    						GlobalState.GameData.RepaymentStage = 3;
    						GlobalState.GameData.系統開放[6] = true;
    						GlobalState.GameData.系統開放[7] = true;
    						GlobalState.GameData.系統開放[8] = true;
    						GlobalState.GameData.ヴィオラ服 = true;
    						Med.SwitchMode("RepaymentEvent3", DrawBuffer, 返済イベント描画);
    						SetDemandMaximum();
    					}
    				}
    			}
    		};
    		DrawOffice = delegate(RenderArea a, FpsCounter FPS)
    		{
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(ColorHelper.Transparent);
    			}
    			a.Draw(OfficeBackground);
    			Viola.Draw(a, FPS);
    			ViolaTextBubble.Draw(a, FPS);
    			bs.Draw(a);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			if (SDShow)
    			{
    				SaveData.Draw(a);
    			}
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, DrawOffice);
    		};
    		mod.Dispose = delegate
    		{
    			bs.Dispose();
    		};
    		return mod;
    	}

    	public static Module Debt(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		Vector2D position = DrawBuffer.GetPosition(0.15, 0.37);
    		ButtonMap bs = new ButtonMap();

    		bs.Add("ボタン0", MyUI.Button2(Med, DrawBuffer, GameText.戻る, new Vector2D(0.85, 0.02), delegate
    		{
    			//Sounds.操作.Play();
    			Med.Mode = "Office";
    		}));

    		ShapePartT shapePartT2 = new ShapePartT();
    		shapePartT2.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT2.SetPositionBase(position + DrawBuffer.GetPosition(0.0, 0.0));
    		shapePartT2.Text = "c";
    		shapePartT2.SetFontSize(0.15);
    		shapePartT2.SetSizeBase(0.07);
    		shapePartT2.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT2.GetOP().ScalingXY(shapePartT2.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT2.SetClosed(true);
    		shapePartT2.SetTextColor(ColorHelper.White);
    		shapePartT2.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT2.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT2.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT2.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("nc", new Button(shapePartT2, delegate
    		{
    			//Sounds.操作.Play();
    			ip.TextIm = "0";
    		}));

    		ShapePartT shapePartT3 = new ShapePartT();
    		shapePartT3.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT3.SetPositionBase(position + DrawBuffer.GetPosition(0.06, 0.0));
    		shapePartT3.Text = "m";
    		shapePartT3.SetFontSize(0.15);
    		shapePartT3.SetSizeBase(0.07);
    		shapePartT3.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT3.GetOP().ScalingXY(shapePartT3.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT3.SetClosed(true);
    		shapePartT3.SetTextColor(ColorHelper.White);
    		shapePartT3.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT3.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT3.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT3.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("nm", new Button(shapePartT3, delegate
    		{
    			//Sounds.操作.Play();
    			ip.TextIm = 9999999999999uL.ToString("#,0");
    		}));

    		Action<string> SetNum = delegate(string num)
    		{
    			if (ulong.Parse(ip.TextIm, NumberStyles.AllowThousands).ToString().Length < 9999999999999uL.ToString().Length)
    			{
    				ip.TextIm += num;
    				ip.TextIm = ulong.Parse(ip.TextIm, NumberStyles.AllowThousands).ToString("#,0");
    			}
    		};

    		ShapePartT shapePartT4 = new ShapePartT();
    		shapePartT4.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT4.SetPositionBase(position + DrawBuffer.GetPosition(0.0, 0.07));
    		shapePartT4.Text = "7";
    		shapePartT4.SetFontSize(0.15);
    		shapePartT4.SetSizeBase(0.07);
    		shapePartT4.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT4.GetOP().ScalingXY(shapePartT4.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT4.SetClosed(true);
    		shapePartT4.SetTextColor(ColorHelper.White);
    		shapePartT4.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT4.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT4.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT4.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("n7", new Button(shapePartT4, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("7");
    		}));

    		ShapePartT shapePartT5 = new ShapePartT();
    		shapePartT5.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT5.SetPositionBase(position + DrawBuffer.GetPosition(0.06, 0.07));
    		shapePartT5.Text = "8";
    		shapePartT5.SetFontSize(0.15);
    		shapePartT5.SetSizeBase(0.07);
    		shapePartT5.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT5.GetOP().ScalingXY(shapePartT5.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT5.SetClosed(true);
    		shapePartT5.SetTextColor(ColorHelper.White);
    		shapePartT5.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT5.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT5.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT5.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("n8", new Button(shapePartT5, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("8");
    		}));

    		ShapePartT shapePartT6 = new ShapePartT();
    		shapePartT6.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT6.SetPositionBase(position + DrawBuffer.GetPosition(0.12, 0.07));
    		shapePartT6.Text = "9";
    		shapePartT6.SetFontSize(0.15);
    		shapePartT6.SetSizeBase(0.07);
    		shapePartT6.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT6.GetOP().ScalingXY(shapePartT6.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT6.SetClosed(true);
    		shapePartT6.SetTextColor(ColorHelper.White);
    		shapePartT6.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT6.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT6.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT6.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("n9", new Button(shapePartT6, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("9");
    		}));

    		ShapePartT shapePartT7 = new ShapePartT();
    		shapePartT7.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT7.SetPositionBase(position + DrawBuffer.GetPosition(0.0, 0.14));
    		shapePartT7.Text = "4";
    		shapePartT7.SetFontSize(0.15);
    		shapePartT7.SetSizeBase(0.07);
    		shapePartT7.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT7.GetOP().ScalingXY(shapePartT7.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT7.SetClosed(true);
    		shapePartT7.SetTextColor(ColorHelper.White);
    		shapePartT7.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT7.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT7.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT7.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("n4", new Button(shapePartT7, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("4");
    		}));

    		ShapePartT shapePartT8 = new ShapePartT();
    		shapePartT8.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT8.SetPositionBase(position + DrawBuffer.GetPosition(0.06, 0.14));
    		shapePartT8.Text = "5";
    		shapePartT8.SetFontSize(0.15);
    		shapePartT8.SetSizeBase(0.07);
    		shapePartT8.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT8.GetOP().ScalingXY(shapePartT8.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT8.SetClosed(true);
    		shapePartT8.SetTextColor(ColorHelper.White);
    		shapePartT8.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT8.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT8.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT8.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("n5", new Button(shapePartT8, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("5");
    		}));

    		ShapePartT shapePartT9 = new ShapePartT();
    		shapePartT9.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT9.SetPositionBase(position + DrawBuffer.GetPosition(0.12, 0.14));
    		shapePartT9.Text = "6";
    		shapePartT9.SetFontSize(0.15);
    		shapePartT9.SetSizeBase(0.07);
    		shapePartT9.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT9.GetOP().ScalingXY(shapePartT9.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT9.SetClosed(true);
    		shapePartT9.SetTextColor(ColorHelper.White);
    		shapePartT9.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT9.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT9.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT9.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("n6", new Button(shapePartT9, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("6");
    		}));

    		ShapePartT shapePartT10 = new ShapePartT();
    		shapePartT10.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT10.SetPositionBase(position + DrawBuffer.GetPosition(0.0, 0.21));
    		shapePartT10.Text = "1";
    		shapePartT10.SetFontSize(0.15);
    		shapePartT10.SetSizeBase(0.07);
    		shapePartT10.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT10.GetOP().ScalingXY(shapePartT10.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT10.SetClosed(true);
    		shapePartT10.SetTextColor(ColorHelper.White);
    		shapePartT10.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT10.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT10.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT10.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("n1", new Button(shapePartT10, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("1");
    		}));

    		ShapePartT shapePartT11 = new ShapePartT();
    		shapePartT11.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT11.SetPositionBase(position + DrawBuffer.GetPosition(0.06, 0.21));
    		shapePartT11.Text = "2";
    		shapePartT11.SetFontSize(0.15);
    		shapePartT11.SetSizeBase(0.07);
    		shapePartT11.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT11.GetOP().ScalingXY(shapePartT11.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT11.SetClosed(true);
    		shapePartT11.SetTextColor(ColorHelper.White);
    		shapePartT11.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT11.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT11.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT11.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("n2", new Button(shapePartT11, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("2");
    		}));

    		ShapePartT shapePartT12 = new ShapePartT();
    		shapePartT12.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT12.SetPositionBase(position + DrawBuffer.GetPosition(0.12, 0.21));
    		shapePartT12.Text = "3";
    		shapePartT12.SetFontSize(0.15);
    		shapePartT12.SetSizeBase(0.07);
    		shapePartT12.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT12.GetOP().ScalingXY(shapePartT12.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT12.SetClosed(true);
    		shapePartT12.SetTextColor(ColorHelper.White);
    		shapePartT12.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT12.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT12.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT12.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("n3", new Button(shapePartT12, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("3");
    		}));

    		ShapePartT shapePartT13 = new ShapePartT();
    		shapePartT13.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT13.SetPositionBase(position + DrawBuffer.GetPosition(0.0, 0.28));
    		shapePartT13.Text = "0";
    		shapePartT13.SetFontSize(0.15);
    		shapePartT13.SetSizeBase(0.07);
    		shapePartT13.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT13.GetOP().ScalingXY(shapePartT13.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT13.SetClosed(true);
    		shapePartT13.SetTextColor(ColorHelper.White);
    		shapePartT13.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT13.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT13.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT13.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("n0", new Button(shapePartT13, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("0");
    		}));

    		ShapePartT shapePartT14 = new ShapePartT();
    		shapePartT14.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT14.SetPositionBase(position + DrawBuffer.GetPosition(0.12, 0.28));
    		shapePartT14.Text = GameText.借;
    		shapePartT14.SetFontSize(0.15);
    		shapePartT14.SetSizeBase(0.07);
    		shapePartT14.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT14.GetOP().ScalingXY(shapePartT14.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT14.SetClosed(true);
    		shapePartT14.SetTextColor(ColorHelper.White);
    		shapePartT14.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT14.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT14.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT14.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("nb", new Button(shapePartT14, delegate
    		{
    			if (GlobalState.GameData.日借金可能額 != 0)
    			{
    				ulong num3 = ulong.Parse(ip.Text, NumberStyles.AllowThousands);
    				if (num3 != 0)
    				{
    					if (num3 > GlobalState.GameData.日借金可能額)
    					{
    						num3 = GlobalState.GameData.日借金可能額;
    						ip.SubInfo = GameText.借金可能額以上は無視されます;
    					}
    					GlobalState.GameData.日借金額 += num3;
    					GlobalState.GameData.所持金 = GlobalState.GameData.所持金.overflow_add(num3);
    					GlobalState.GameData.借金 = GlobalState.GameData.借金.overflow_add(num3);
    					bs["nr"].Dra = GlobalState.GameData.借金 != 0;
    					ip.TextIm = "0";
    					//Sounds.精算.Play();
    					ip.UpdateSub2();
    					ViolaText.Set();
    				}
    				else
    				{
    					//Sounds.操作.Play();
    				}
    			}
    			else
    			{
    				//Sounds.操作.Play();
    				ip.SubInfo = GameText.今日はこれ以上借りることが出来ません;
    			}
    		}));

    		ShapePartT shapePartT15 = new ShapePartT();
    		shapePartT15.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT15.SetPositionBase(position + DrawBuffer.GetPosition(0.06, 0.28));
    		shapePartT15.Text = GameText.返;
    		shapePartT15.SetFontSize(0.15);
    		shapePartT15.SetSizeBase(0.07);
    		shapePartT15.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT15.GetOP().ScalingXY(shapePartT15.GetOP().GetCenter(), 0.3, 0.3);
    		shapePartT15.SetClosed(true);
    		shapePartT15.SetTextColor(ColorHelper.White);
    		shapePartT15.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT15.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT15.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT15.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("nr", new Button(shapePartT15, delegate
    		{
    			if (GlobalState.GameData.所持金 != 0)
    			{
    				ulong num2 = ulong.Parse(ip.Text, NumberStyles.AllowThousands);
    				if (num2 != 0)
    				{
    					if (num2 > GlobalState.GameData.所持金)
    					{
    						num2 = GlobalState.GameData.所持金;
    						ip.SubInfo = GameText.返済可能額以上は無視されます;
    					}
    					if (num2 > GlobalState.GameData.借金)
    					{
    						GlobalState.GameData.所持金 = GlobalState.GameData.所持金.underflow_subtract(GlobalState.GameData.借金);
    						GlobalState.GameData.借金 = 0uL;
    						ip.SubInfo = GameText.返済可能額以上は無視されます;
    					}
    					else
    					{
    						GlobalState.GameData.所持金 = GlobalState.GameData.所持金.underflow_subtract(num2);
    						GlobalState.GameData.借金 = GlobalState.GameData.借金.underflow_subtract(num2);
    					}
    					bs["nr"].Dra = GlobalState.GameData.借金 != 0;
    					ip.TextIm = "0";
    					//Sounds.精算.Play();
    					ip.UpdateSub2();
    				}
    				else
    				{
    					//Sounds.操作.Play();
    				}
    			}
    			else
    			{
    				//Sounds.操作.Play();
    				ip.SubInfo = GameText.所持金がありません;
    			}
    		}));

    		bs.SetHitColor(Med);
    		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (SDShow)
    			{
    				SaveData.Down(ref hc);
    				if (mb == MouseButtons.Right)
    				{
    					//Sounds.操作.Play();
    					SDShow = false;
    					ip.Up(ref hc);
    					dbs.Move(ref hc);
    				}
    			}
    			else
    			{
    				switch (mb)
    				{
    				case MouseButtons.Left:
    					if (!ip.選択肢表示)
    					{
    						ViolaTextBubble.Down(ViolaTextBubble.GetHitColor);
    						dbs.Down(ref hc);
    						bs.Down(ref hc);
    					}
    					ip.Down(ref hc);
    					break;
    				case MouseButtons.Right:
    					if (!ip.選択肢表示)
    					{
    						bs["ボタン0"].Action(bs["ボタン0"]);
    					}
    					else
    					{
    						ip.nb.Action(ip.nb);
    					}
    					break;
    				}
    			}
    		};
    		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (SDShow)
    			{
    				SaveData.Up(ref hc);
    			}
    			else if (mb == MouseButtons.Left)
    			{
    				if (!ip.選択肢表示)
    				{
    					ViolaTextBubble.Up(ViolaTextBubble.GetHitColor);
    					dbs.Up(ref hc);
    					bs.Up(ref hc);
    				}
    				ip.Up(ref hc);
    			}
    		};
    		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (SDShow)
    			{
    				SaveData.Move(ref hc);
    			}
    			else
    			{
    				if (!ip.選択肢表示)
    				{
    					dbs.Move(ref hc);
    					bs.Move(ref hc);
    					Player説明(ref hc, delegate
    					{
    						si.Set(bre: false);
    					});
    				}
    				ip.Move(ref hc);
    			}
    		};
    		mod.Leave = delegate
    		{
    			if (SDShow)
    			{
    				SaveData.Leave();
    			}
    			else if (!ip.選択肢表示)
    			{
    				dbs.Leave();
    				bs.Leave();
    			}
    		};
    		mod.Wheel = delegate
    		{
    		};
    		mod.Setting = delegate
    		{
    			if (Med.Modeb != "PlayerInformation")
    			{
    				ip.TextIm = "0";
    				ip.UpdateSub2();
    				ip.MaiShow = true;
    				ip.Mai.Feed.Dra = false;
    				ip.Mai2Show = false;
    				ip.SubShow = true;
    				ip.Sub2Show = true;
    				Viola.両目_見つめ();
    				Viola.両瞼_半1();
    				Viola.両瞼_卑();
    				Viola.口_薄笑();
    				Viola.両腕_人_腕下げ(0, 左右: false, 前後: false);
    				Viola.両触手_S字(0);
    				Viola.両触手_S字(1);
    				Viola.SetSymmetry();
    				ViolaText.Set();
    				si.Set(bre: false);
    				bs["nr"].Dra = GlobalState.GameData.借金 != 0;
    				//bs["nr"].Dra = GlobalState.GameData.借金 != 0;
    			}
    		};
    		DrawDebt = delegate(RenderArea a, FpsCounter FPS)
    		{
    			Med.HitGraphics.Clear(ColorHelper.Transparent);
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(ColorHelper.Transparent);
    			}
    			a.Draw(OfficeBackground);
    			Viola.Draw(a, FPS);
    			ViolaTextBubble.Draw(a, FPS);
    			bs.Draw(a);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			if (SDShow)
    			{
    				SaveData.Draw(a);
    			}
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, DrawDebt);
    		};
    		mod.Dispose = delegate
    		{
    			bs.Dispose();
    		};
    		return mod;
    	}

    	public static Module SlaveShop(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		Character PurchasTarget = null;
    		bool d = false;
    		Action Reload = null;
    		Unit u = null;
    		Generator g = null;
    		ButtonMap bs = new ButtonMap();
    		ShapePartT shapePartT = new ShapePartT();
    		shapePartT.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT.SetPositionBase(DrawBuffer.GetPosition(0.85, 0.02));
    		shapePartT.Text = GameText.戻る;
    		shapePartT.SetFontSize(0.15);
    		shapePartT.SetSizeBase(0.05);
    		shapePartT.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT.GetOP().ScalingY(shapePartT.GetOP().GetCenter(), 0.47);
    		shapePartT.GetOP().Rotation(shapePartT.GetOP().GetCenter(), -26.0);
    		shapePartT.SetClosed(true);
    		shapePartT.SetTextColor(ColorHelper.White);
    		shapePartT.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("ボタン0", new Button(shapePartT, delegate
    		{
    			//Sounds.操作.Play();
    			if (GlobalState.GameData.初事務所フラグ)
    			{
    				Med.SwitchMode("初事務所", DrawBuffer, 初事務所描画);
    			}
    			else
    			{
    				Med.Mode = "Office";
    			}
    		}));
    		ShapePartT shapePartT2 = new ShapePartT();
    		shapePartT2.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT2.SetPositionBase(DrawBuffer.GetPosition(0.85, 0.1));
    		shapePartT2.Text = GameText.奴隷;
    		shapePartT2.SetFontSize(0.15);
    		shapePartT2.SetSizeBase(0.05);
    		shapePartT2.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT2.GetOP().ScalingY(shapePartT2.GetOP().GetCenter(), 0.47);
    		shapePartT2.GetOP().Rotation(shapePartT2.GetOP().GetCenter(), -26.0);
    		shapePartT2.SetClosed(true);
    		shapePartT2.SetTextColor(ColorHelper.White);
    		shapePartT2.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT2.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT2.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT2.GetStringFormat().LineAlignment = StringAlignment.Center;
    		shapePartT2.SetPenColor(Color.Red);
    		bs.Add("ボタン1", new Button(shapePartT2, delegate
    		{
    			//Sounds.操作.Play();
    			Med.Mode = "SlaveShop";
    		}));
    		ShapePartT shapePartT3 = new ShapePartT();
    		shapePartT3.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT3.SetPositionBase(DrawBuffer.GetPosition(0.85, 0.18));
    		shapePartT3.Text = GameText.道具;
    		shapePartT3.SetFontSize(0.15);
    		shapePartT3.SetSizeBase(0.05);
    		shapePartT3.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT3.GetOP().ScalingY(shapePartT3.GetOP().GetCenter(), 0.47);
    		shapePartT3.GetOP().Rotation(shapePartT3.GetOP().GetCenter(), -26.0);
    		shapePartT3.SetClosed(true);
    		shapePartT3.SetTextColor(ColorHelper.White);
    		shapePartT3.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT3.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT3.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT3.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("ボタン2", new Button(shapePartT3, delegate
    		{
    			//Sounds.操作.Play();
    			Med.Mode = "ToolShop";
    		}));
    		Color bs初期縁色 = ColorHelper.Black;
    		Action bs縁色初期化 = delegate
    		{
    			foreach (ButtonBase item in bs.EnumBut.Skip(3).Take(10))
    			{
    				item.PartGroup.Values.First().ToParT().SetPenColor(bs初期縁色);
    			}
    		};
    		double num = 0.7;
    		double num2 = -0.03;
    		ShapePartT shapePartT4 = new ShapePartT();
    		shapePartT4.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT4.SetPositionBase(DrawBuffer.GetPosition(0.01, num2 + 0.02 * num));
    		shapePartT4.Text = GameText.ランダム;
    		shapePartT4.SetFontSize(0.15);
    		shapePartT4.SetSizeBase(0.05);
    		shapePartT4.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT4.GetOP().ScalingY(shapePartT4.GetOP().GetCenter(), 0.5 * num);
    		shapePartT4.SetClosed(true);
    		shapePartT4.SetTextColor(ColorHelper.White);
    		shapePartT4.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT4.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT4.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT4.GetStringFormat().LineAlignment = StringAlignment.Center;
    		shapePartT4.SetPenColor(Color.Red);
    		bs.Add("対象0", new Button(shapePartT4, delegate(ButtonBase bu)
    		{
    			if (d)
    			{
    				//Sounds.操作.Play();
    			}
    			d = true;
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    			Reload();
    		}));
    		ShapePartT shapePartT5 = new ShapePartT();
    		shapePartT5.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT5.SetPositionBase(DrawBuffer.GetPosition(0.01, num2 + 0.1 * num));
    		shapePartT5.Text = GameText.鳥系;
    		shapePartT5.SetFontSize(0.15);
    		shapePartT5.SetSizeBase(0.05);
    		shapePartT5.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT5.GetOP().ScalingY(shapePartT5.GetOP().GetCenter(), 0.5 * num);
    		shapePartT5.SetClosed(true);
    		shapePartT5.SetTextColor(ColorHelper.White);
    		shapePartT5.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT5.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT5.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT5.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("対象1", new Button(shapePartT5, delegate(ButtonBase bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    			Reload();
    		}));
    		ShapePartT shapePartT6 = new ShapePartT();
    		shapePartT6.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT6.SetPositionBase(DrawBuffer.GetPosition(0.01, num2 + 0.18 * num));
    		shapePartT6.Text = GameText.蛇系;
    		shapePartT6.SetFontSize(0.15);
    		shapePartT6.SetSizeBase(0.05);
    		shapePartT6.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT6.GetOP().ScalingY(shapePartT6.GetOP().GetCenter(), 0.5 * num);
    		shapePartT6.SetClosed(true);
    		shapePartT6.SetTextColor(ColorHelper.White);
    		shapePartT6.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT6.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT6.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT6.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("対象2", new Button(shapePartT6, delegate(ButtonBase bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    			Reload();
    		}));
    		ShapePartT shapePartT7 = new ShapePartT();
    		shapePartT7.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT7.SetPositionBase(DrawBuffer.GetPosition(0.01, num2 + 0.26 * num));
    		shapePartT7.Text = GameText.獣系;
    		shapePartT7.SetFontSize(0.15);
    		shapePartT7.SetSizeBase(0.05);
    		shapePartT7.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT7.GetOP().ScalingY(shapePartT7.GetOP().GetCenter(), 0.5 * num);
    		shapePartT7.SetClosed(true);
    		shapePartT7.SetTextColor(ColorHelper.White);
    		shapePartT7.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT7.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT7.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT7.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("対象3", new Button(shapePartT7, delegate(ButtonBase bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    			Reload();
    		}));
    		ShapePartT shapePartT8 = new ShapePartT();
    		shapePartT8.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT8.SetPositionBase(DrawBuffer.GetPosition(0.01, num2 + 0.34 * num));
    		shapePartT8.Text = GameText.水系;
    		shapePartT8.SetFontSize(0.15);
    		shapePartT8.SetSizeBase(0.05);
    		shapePartT8.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT8.GetOP().ScalingY(shapePartT8.GetOP().GetCenter(), 0.5 * num);
    		shapePartT8.SetClosed(true);
    		shapePartT8.SetTextColor(ColorHelper.White);
    		shapePartT8.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT8.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT8.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT8.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("対象4", new Button(shapePartT8, delegate(ButtonBase bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    			Reload();
    		}));
    		ShapePartT shapePartT9 = new ShapePartT();
    		shapePartT9.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT9.SetPositionBase(DrawBuffer.GetPosition(0.01, num2 + 0.42 * num));
    		shapePartT9.Text = GameText.虫系;
    		shapePartT9.SetFontSize(0.15);
    		shapePartT9.SetSizeBase(0.05);
    		shapePartT9.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT9.GetOP().ScalingY(shapePartT9.GetOP().GetCenter(), 0.5 * num);
    		shapePartT9.SetClosed(true);
    		shapePartT9.SetTextColor(ColorHelper.White);
    		shapePartT9.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT9.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT9.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT9.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("対象5", new Button(shapePartT9, delegate(ButtonBase bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    			Reload();
    		}));
    		ShapePartT shapePartT10 = new ShapePartT();
    		shapePartT10.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT10.SetPositionBase(DrawBuffer.GetPosition(0.01, num2 + 0.5 * num));
    		shapePartT10.Text = GameText.人型;
    		shapePartT10.SetFontSize(0.15);
    		shapePartT10.SetSizeBase(0.05);
    		shapePartT10.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT10.GetOP().ScalingY(shapePartT10.GetOP().GetCenter(), 0.5 * num);
    		shapePartT10.SetClosed(true);
    		shapePartT10.SetTextColor(ColorHelper.White);
    		shapePartT10.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT10.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT10.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT10.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("対象6", new Button(shapePartT10, delegate(ButtonBase bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    			Reload();
    		}));
    		ShapePartT shapePartT11 = new ShapePartT();
    		shapePartT11.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT11.SetPositionBase(DrawBuffer.GetPosition(0.01, num2 + 0.58 * num));
    		shapePartT11.Text = GameText.幻獣;
    		shapePartT11.SetFontSize(0.15);
    		shapePartT11.SetSizeBase(0.05);
    		shapePartT11.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT11.GetOP().ScalingY(shapePartT11.GetOP().GetCenter(), 0.5 * num);
    		shapePartT11.SetClosed(true);
    		shapePartT11.SetTextColor(ColorHelper.White);
    		shapePartT11.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT11.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT11.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT11.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("対象7", new Button(shapePartT11, delegate(ButtonBase bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    			Reload();
    		}));
    		ShapePartT shapePartT12 = new ShapePartT();
    		shapePartT12.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT12.SetPositionBase(DrawBuffer.GetPosition(0.01, num2 + 0.66 * num));
    		shapePartT12.Text = GameText.魔獣;
    		shapePartT12.SetFontSize(0.15);
    		shapePartT12.SetSizeBase(0.05);
    		shapePartT12.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT12.GetOP().ScalingY(shapePartT12.GetOP().GetCenter(), 0.5 * num);
    		shapePartT12.SetClosed(true);
    		shapePartT12.SetTextColor(ColorHelper.White);
    		shapePartT12.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT12.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT12.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT12.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("対象8", new Button(shapePartT12, delegate(ButtonBase bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    			Reload();
    		}));
    		ShapePartT shapePartT13 = new ShapePartT();
    		shapePartT13.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT13.SetPositionBase(DrawBuffer.GetPosition(0.01, num2 + 0.74 * num));
    		shapePartT13.Text = GameText.竜系;
    		shapePartT13.SetFontSize(0.15);
    		shapePartT13.SetSizeBase(0.05);
    		shapePartT13.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT13.GetOP().ScalingY(shapePartT13.GetOP().GetCenter(), 0.5 * num);
    		shapePartT13.SetClosed(true);
    		shapePartT13.SetTextColor(ColorHelper.White);
    		shapePartT13.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT13.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT13.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT13.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("対象9", new Button(shapePartT13, delegate(ButtonBase bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    			Reload();
    		}));
    		Action SetGen = delegate
    		{
    			if (bs["対象0"].PartGroup.Values.First().ToParT().GetPenColor() == Color.Red)
    			{
    				if ((GlobalState.GameData.鳥系.Count != 0 && GlobalState.GameData.系統開放[0]) || (GlobalState.GameData.蛇系.Count != 0 && GlobalState.GameData.系統開放[1]) || (GlobalState.GameData.獣系.Count != 0 && GlobalState.GameData.系統開放[2]) || (GlobalState.GameData.水系.Count != 0 && GlobalState.GameData.系統開放[3]) || (GlobalState.GameData.虫系.Count != 0 && GlobalState.GameData.系統開放[4]) || (GlobalState.GameData.人型.Count != 0 && GlobalState.GameData.系統開放[5]) || (GlobalState.GameData.幻獣.Count != 0 && GlobalState.GameData.系統開放[6]) || (GlobalState.GameData.魔獣.Count != 0 && GlobalState.GameData.系統開放[7]) || (GlobalState.GameData.竜系.Count != 0 && GlobalState.GameData.系統開放[8]))
    				{
    					do
    					{
    						switch (Rng.XS.Next(GlobalState.GameData.系統開放.Count((bool e) => e)))
    						{
    						case 0:
    							g = GlobalState.GameData.鳥系;
    							break;
    						case 1:
    							g = GlobalState.GameData.蛇系;
    							break;
    						case 2:
    							g = GlobalState.GameData.獣系;
    							break;
    						case 3:
    							g = GlobalState.GameData.水系;
    							break;
    						case 4:
    							g = GlobalState.GameData.虫系;
    							break;
    						case 5:
    							g = GlobalState.GameData.人型;
    							break;
    						case 6:
    							g = GlobalState.GameData.幻獣;
    							break;
    						case 7:
    							g = GlobalState.GameData.魔獣;
    							break;
    						case 8:
    							g = GlobalState.GameData.竜系;
    							break;
    						}
    					}
    					while (g.Count == 0);
    				}
    				else
    				{
    					switch (Rng.XS.Next(GlobalState.GameData.系統開放.Count((bool e) => e)))
    					{
    					case 0:
    						g = GlobalState.GameData.鳥系;
    						break;
    					case 1:
    						g = GlobalState.GameData.蛇系;
    						break;
    					case 2:
    						g = GlobalState.GameData.獣系;
    						break;
    					case 3:
    						g = GlobalState.GameData.水系;
    						break;
    					case 4:
    						g = GlobalState.GameData.虫系;
    						break;
    					case 5:
    						g = GlobalState.GameData.人型;
    						break;
    					case 6:
    						g = GlobalState.GameData.幻獣;
    						break;
    					case 7:
    						g = GlobalState.GameData.魔獣;
    						break;
    					case 8:
    						g = GlobalState.GameData.竜系;
    						break;
    					}
    				}
    			}
    			else if (bs["対象1"].PartGroup.Values.First().ToParT().GetPenColor() == Color.Red)
    			{
    				g = GlobalState.GameData.鳥系;
    			}
    			else if (bs["対象2"].PartGroup.Values.First().ToParT().GetPenColor() == Color.Red)
    			{
    				g = GlobalState.GameData.蛇系;
    			}
    			else if (bs["対象3"].PartGroup.Values.First().ToParT().GetPenColor() == Color.Red)
    			{
    				g = GlobalState.GameData.獣系;
    			}
    			else if (bs["対象4"].PartGroup.Values.First().ToParT().GetPenColor() == Color.Red)
    			{
    				g = GlobalState.GameData.水系;
    			}
    			else if (bs["対象5"].PartGroup.Values.First().ToParT().GetPenColor() == Color.Red)
    			{
    				g = GlobalState.GameData.虫系;
    			}
    			else if (bs["対象6"].PartGroup.Values.First().ToParT().GetPenColor() == Color.Red)
    			{
    				g = GlobalState.GameData.人型;
    			}
    			else if (bs["対象7"].PartGroup.Values.First().ToParT().GetPenColor() == Color.Red)
    			{
    				g = GlobalState.GameData.幻獣;
    			}
    			else if (bs["対象8"].PartGroup.Values.First().ToParT().GetPenColor() == Color.Red)
    			{
    				g = GlobalState.GameData.魔獣;
    			}
    			else if (bs["対象9"].PartGroup.Values.First().ToParT().GetPenColor() == Color.Red)
    			{
    				g = GlobalState.GameData.竜系;
    			}
    		};
    		Reload = delegate
    		{
    			SetGen();
    			g.Rotation();
    			u = g.RefCharacter();
    			if (u != null)
    			{
    				PurchasTarget?.Dispose();
    				PurchasTarget = new Character(Med, DrawBuffer, u.ChaD);

    				PurchasTarget.SetInitialExpression();
    				PurchasTarget.Emotion();
    				PurchasTarget.UpdateExpression();
    				PurchasTarget.Body.拘束具_表示 = true;
    				PurchasTarget.Set拘束姿勢();
    				PurchasTarget.Set衣装(u.着衣);
    				ip.TextIm = u.GetStatus();
    			}
    			else
    			{
    				ip.Mai.TextIm = GameText.売り切れです;
    			}
    		};
    		ShapePartT shapePartT14 = new ShapePartT();
    		shapePartT14.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT14.SetPositionBase(DrawBuffer.GetPosition(0.01, num2 + 0.9 * num));
    		shapePartT14.Text = GameText.チェンジ;
    		shapePartT14.SetFontSize(0.15);
    		shapePartT14.SetSizeBase(0.05);
    		shapePartT14.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT14.GetOP().ScalingY(shapePartT14.GetOP().GetCenter(), 0.5 * num);
    		shapePartT14.SetClosed(true);
    		shapePartT14.SetTextColor(ColorHelper.White);
    		shapePartT14.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT14.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT14.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT14.GetStringFormat().LineAlignment = StringAlignment.Center;
    		bs.Add("変更", new Button(shapePartT14, delegate
    		{
    			if (!ip.Mai.TextIm.StartsWith(GameText.売り切れです))
    			{
    				Sounds.変更Play();
    			}
    			else
    			{
    				//Sounds.操作.Play();
    			}
    			Reload();
    		}));
    		ShapePartT shapePartT15 = new ShapePartT();
    		shapePartT15.SetFont(new Font("MS Gothic", 0.1f));
    		shapePartT15.SetPositionBase(DrawBuffer.GetPosition(0.01, num2 + 0.98 * num));
    		shapePartT15.Text = GameText.購入;
    		shapePartT15.SetFontSize(0.15);
    		shapePartT15.SetSizeBase(0.05);
    		shapePartT15.GetOP().AddRange(new CurveOutline[1] { ShapeHelper.GetSquare() });
    		shapePartT15.GetOP().ScalingY(shapePartT15.GetOP().GetCenter(), 0.5 * num);
    		shapePartT15.SetClosed(true);
    		shapePartT15.SetTextColor(ColorHelper.White);
    		shapePartT15.SetBrushColor(Color.FromArgb(160, ColorHelper.Black));
    		shapePartT15.SetShadBrush(new SolidBrush(Color.FromArgb(64, ColorHelper.Black)));
    		shapePartT15.GetStringFormat().Alignment = StringAlignment.Center;
    		shapePartT15.GetStringFormat().LineAlignment = StringAlignment.Center;
    		ulong 買値;
    		bs.Add("購入", new Button(shapePartT15, delegate
    		{
    			if (GlobalState.GameData.Is地下室一杯())
    			{
                    //TODO fix?
                    //Sounds.操作.Play();
    				ip.SubInfoIm = GameText.これ以上奴隷を収容できません;
    			}
    			else if (u == null)
    			{
                    //TODO fix?
                    //Sounds.操作.Play();
    				ip.Mai.TextIm = GameText.売り切れです;
    			}
    			else if (GlobalState.GameData.所持金 < (買値 = (ulong)((double)u.GetPrice() * ((GlobalState.GameData.祝福 == GlobalState.GameData.ヴィオラ) ? 0.6 : 1.0))))
    			{
                    //TODO fix?
                    //Sounds.操作.Play();
    				ip.SubInfoIm = GameText.所持金が足りません;
    			}
    			else
    			{
    				u.Price = 買値;
    				GlobalState.GameData.所持金 -= 買値;
                    //TODO fix?
                    ////Sounds.精算.Play();
    				ip.UpdateSub2();
    				GlobalState.GameData.Add地下室(g.GetCharacter());
    				Reload();
    			}
    		}));
    		bs.SetHitColor(Med);
    		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (SDShow)
    			{
    				SaveData.Down(ref hc);
    				if (mb == MouseButtons.Right)
    				{
                        //TODO fix?
                        //Sounds.操作.Play();
    					SDShow = false;
    					ip.Up(ref hc);
    					dbs.Move(ref hc);
    				}
    			}
    			else
    			{
    				switch (mb)
    				{
    				case MouseButtons.Left:
    					if (!ip.選択肢表示)
    					{
    						dbs.Down(ref hc);
    						bs.Down(ref hc);
    					}
    					ip.Down(ref hc);
    					break;
    				case MouseButtons.Right:
    					if (!ip.選択肢表示)
    					{
    						bs["ボタン0"].Action(bs["ボタン0"]);
    					}
    					else
    					{
    						ip.nb.Action(ip.nb);
    					}
    					break;
    				}
    			}
    		};
    		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (SDShow)
    			{
    				SaveData.Up(ref hc);
    			}
    			else if (mb == MouseButtons.Left)
    			{
    				if (!ip.選択肢表示)
    				{
    					dbs.Up(ref hc);
    					bs.Up(ref hc);
    				}
    				ip.Up(ref hc);
    			}
    		};
    		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (SDShow)
    			{
    				SaveData.Move(ref hc);
    			}
    			else
    			{
    				if (!ip.選択肢表示)
    				{
    					dbs.Move(ref hc);
    					bs.Move(ref hc);
    					Player説明(ref hc, delegate
    					{
    						si.Set(bre: false);
    					});
    				}
    				ip.Move(ref hc);
    			}
    		};
    		mod.Leave = delegate
    		{
    			if (SDShow)
    			{
    				SaveData.Leave();
    			}
    			else if (!ip.選択肢表示)
    			{
    				dbs.Leave();
    				bs.Leave();
    			}
    		};
    		mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
    		{
    			int num3 = 0;
    			using (IEnumerator<ButtonBase> enumerator = bs.EnumBut.Skip(3).Take(10).GetEnumerator())
    			{
    				while (enumerator.MoveNext() && !(enumerator.Current.PartGroup.Values.First().ToParT().GetPenColor() == Color.Red))
    				{
    					num3++;
    				}
    			}
    			int num4 = GlobalState.GameData.系統開放.Count((bool e) => e) + 1;
    			int num5 = num3 - dt.Sign();
    			if (num5 < 0)
    			{
    				num5 = num4 - 1;
    			}
    			num5 %= num4;
    			ButtonBase buttonBase = bs["対象" + num5];
    			buttonBase.Action(buttonBase);
    		};
    		mod.Setting = delegate
    		{
    			if (Med.Modeb != "PlayerInformation")
    			{
    				ip.UpdateSub2();
    				ip.MaiShow = true;
    				ip.Mai.Feed.Dra = false;
    				ip.Mai2Show = false;
    				ip.SubShow = true;
    				ip.Sub2Show = true;
    				bs["対象1"].Dra = GlobalState.GameData.系統開放[0];
    				bs["対象2"].Dra = GlobalState.GameData.系統開放[1];
    				bs["対象3"].Dra = GlobalState.GameData.系統開放[2];
    				bs["対象4"].Dra = GlobalState.GameData.系統開放[3];
    				bs["対象5"].Dra = GlobalState.GameData.系統開放[4];
    				bs["対象6"].Dra = GlobalState.GameData.系統開放[5];
    				bs["対象7"].Dra = GlobalState.GameData.系統開放[6];
    				bs["対象8"].Dra = GlobalState.GameData.系統開放[7];
    				bs["対象9"].Dra = GlobalState.GameData.系統開放[8];
    				if (GlobalState.RefreshStoreEveryTime)
    				{
    					GlobalState.GameData.新日 = true;
    				}
    				if (GlobalState.GameData.新日)
    				{
    					GlobalState.GameData.GenRefresh();
    					GlobalState.GameData.新日 = false;
    				}
    				Reload();
    				si.Set(bre: false);
    			}
    		};
    		DrawSlaveShop = delegate(RenderArea a, FpsCounter FPS)
    		{
    			Med.HitGraphics.Clear(ColorHelper.Transparent);
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(ColorHelper.Transparent);
    			}
    			a.Draw(OfficeBackground);
    			if (u != null)
    			{
    				PurchasTarget.Draw(a, FPS);
    			}
    			bs.Draw(a);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			if (SDShow)
    			{
    				SaveData.Draw(a);
    			}
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, DrawSlaveShop);
    		};
    		mod.Dispose = delegate
    		{
    			if (PurchasTarget != null)
    			{
    				PurchasTarget.Dispose();
    			}
    			bs.Dispose();
    		};
    		奴隷UI初期化 = delegate
    		{
    			d = false;
    			bs縁色初期化();
    			bs["対象0"].PartGroup.Values.First().ToParT().SetPenColor(Color.Red);
    		};
    		return mod;
    	}

    	public static Module ToolShop(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		ButtonMap bs = new ButtonMap();

    		bs.Add("ボタン0", MyUI.Button2(Med, DrawBuffer, GameText.戻る, new Vector2D(0.85, 0.02), delegate
    		{
    			//Sounds.操作.Play();
    			if (GlobalState.GameData.初事務所フラグ)
    			{
    				Med.SwitchMode("初事務所", DrawBuffer, 初事務所描画);
    			}
    			else
    			{
    				Med.Mode = "Office";
    			}
    		}));

    		bs.Add("ボタン1", MyUI.Button2(Med, DrawBuffer, GameText.奴隷, new Vector2D(0.85, 0.1), delegate
    		{
    			//Sounds.操作.Play();
    			Med.Mode = "SlaveShop";
    		}));

            //TODO: fix
    		//shapePartT3.PenColor = Color.Red;
    		bs.Add("ボタン2", MyUI.Button2(Med, DrawBuffer, GameText.道具, new Vector2D(0.85, 0.1), delegate
    		{
    			//Sounds.操作.Play();
    			Med.Mode = "ToolShop";
    		}));
    		bs.SetHitColor(Med);

    		ListView lv = null;
    		Action<ButtonBase, int, ulong> buy = delegate(ButtonBase ButtonBase, int ind, ulong pri)
    		{
    			if (GlobalState.GameData.所持金 >= pri)
    			{
    				ButtonBase.Dra = false;
    				GlobalState.GameData.PurchasedTools[ind] = true;
    				GlobalState.GameData.所持金 -= pri;
    				//Sounds.精算.Play();
    				ip.UpdateSub2();
    				ip.TextIm = " ";
    				if (!lv.bs.EnumBut.Any((ButtonBase e) => e.Dra))
    				{
    					ip.SubInfo = GameText.買える物は何も無い;
    					ip.TextIm = GameText.売り切れです;
    				}
    			}
    			else
    			{
    				////Sounds.操作.Play();
    				ip.SubInfoIm = GameText.所持金が足りません;
    			}
    		};
    		
            
            lv = new ListView(DrawBuffer, DrawBuffer.GetPosition(0.01, 0.03), 0.5, new Font("MS Gothic", 1f), 0.07, ColorHelper.White, ColorHelper.Empty, Color.FromArgb(160, ColorHelper.Black), ColorHelper.Black, new TextAction(GameText.ﾃﾞｨﾙﾄﾞﾊﾞｲﾌﾞ + " 35,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 0, 35000000uL);
    		}), new TextAction(GameText.ﾉｰﾏﾙﾊﾞｲﾌﾞ + "   40,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 1, 40000000uL);
    		}), new TextAction(GameText.ﾄﾞﾘﾙﾊﾞｲﾌﾞ + "   60,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 2, 60000000uL);
    		}), new TextAction(GameText.ﾃﾞﾝﾏﾊﾞｲﾌﾞ + "   50,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 3, 50000000uL);
    		}), new TextAction(GameText.ｱﾅﾙﾊﾞｲﾌﾞ + "    45,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 4, 45000000uL);
    		}), new TextAction(GameText.調教鞭 + "      30,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 5, 30000000uL);
    		}), new TextAction(GameText.羽根箒 + "      20,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 6, 20000000uL);
    		}), new TextAction(GameText.T字剃刀 + "     20,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 7, 20000000uL);
    		}), new TextAction(GameText.振動ｷｬｯﾌﾟ + "   30,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 8, 30000000uL);
    		}), new TextAction(GameText.ﾋﾟﾝｸﾛｰﾀ + "     20,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 9, 20000000uL);
    		}), new TextAction(GameText.ｱﾅﾙﾊﾟｰﾙ + "     20,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 10, 20000000uL);
    		}), new TextAction(GameText.目隠帯 + "      25,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 11, 25000000uL);
    		}), new TextAction(GameText.玉口枷 + "      20,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 12, 20000000uL);
    		}), new TextAction(GameText.カメラ + "     100,000,000", delegate(ButtonBase b)
    		{
    			buy(b, 13, 100000000uL);
    		}), new TextAction(GameText.ﾌﾛｱ増設 + "    300,000,000", delegate(ButtonBase b)
    		{
    			ulong num = 300000000uL;
    			if (GlobalState.GameData.所持金 >= num)
    			{
    				GlobalState.GameData.フロア数++;
    				if (GlobalState.GameData.フロア数 == 9)
    				{
    					b.Dra = false;
    				}
    				GlobalState.GameData.所持金 -= num;
    				//Sounds.精算.Play();
    				ip.UpdateSub2();
    				ip.TextIm = " ";
    				if (!lv.bs.EnumBut.Any((ButtonBase e) => e.Dra))
    				{
    					ip.SubInfo = GameText.買える物は何も無い;
    					ip.TextIm = GameText.売り切れです;
    				}
    			}
    			else
    			{
    				//Sounds.操作.Play();
    				ip.SubInfoIm = GameText.所持金が足りません;
    			}
    		}));
    		lv.SetHitColor(Med);


    		Action subinfo = delegate
    		{
    			if (lv.bs.EnumBut.Any((ButtonBase e) => e.Dra))
    			{
    				ip.SubInfo = GameText.ふざけた値段だ;
    			}
    			else
    			{
    				ip.SubInfo = GameText.買える物は何も無い;
    			}
    		};
    		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (SDShow)
    			{
    				SaveData.Down(ref hc);
    				if (mb == MouseButtons.Right)
    				{
    					//Sounds.操作.Play();
    					SDShow = false;
    					ip.Up(ref hc);
    					dbs.Move(ref hc);
    				}
    			}
    			else
    			{
    				switch (mb)
    				{
    				case MouseButtons.Left:
    					if (!ip.選択肢表示)
    					{
    						dbs.Down(ref hc);
    						bs.Down(ref hc);
    						lv.Down(ref hc);
    					}
    					break;
    				case MouseButtons.Right:
    					if (!ip.選択肢表示)
    					{
    						bs["ボタン0"].Action(bs["ボタン0"]);
    					}
    					else
    					{
    						ip.nb.Action(ip.nb);
    					}
    					break;
    				}
    			}
    		};
    		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (SDShow)
    			{
    				SaveData.Up(ref hc);
    			}
    			else if (mb == MouseButtons.Left)
    			{
    				if (!ip.選択肢表示)
    				{
    					dbs.Up(ref hc);
    					bs.Up(ref hc);
    					lv.Up(ref hc);
    				}
    				ip.Up(ref hc);
    			}
    		};
    		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (SDShow)
    			{
    				SaveData.Move(ref hc);
    			}
    			else
    			{
    				if (!ip.選択肢表示)
    				{
    					dbs.Move(ref hc);
    					bs.Move(ref hc);
    					lv.Move(ref hc);
    					if (lv.bs["0"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.ペニスを模したバイブ + "\r\n" + GameText.刺激は控えめ;
    					}
    					if (lv.bs["1"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.一般的なバイブ + "\r\n" + GameText.ディルドバイブより刺激が強い;
    					}
    					if (lv.bs["2"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.振動と回転の2つの刺激をもたらすバイブ;
    					}
    					if (lv.bs["3"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.強力な振動のバイブ + "\r\n" + GameText.刺激が強い;
    					}
    					if (lv.bs["4"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.アナルの調教に適したバイブ;
    					}
    					if (lv.bs["5"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.痛みを与えるための道具;
    					}
    					if (lv.bs["6"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.緊張を解きほぐすために利用する;
    					}
    					if (lv.bs["7"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.陰毛を剃ることが出来る;
    					}
    					if (lv.bs["8"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.吸着振動するキャップ;
    					}
    					if (lv.bs["9"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.刺激の弱いバイブの一種;
    					}
    					if (lv.bs["10"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.アナルの調教に適した道具;
    					}
    					if (lv.bs["11"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.奴隷の視界を遮るための道具;
    					}
    					if (lv.bs["12"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.奴隷の口をふさぐための道具;
    					}
    					if (lv.bs["13"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.写真を撮影することが出来る;
    					}
    					if (lv.bs["14"].PartGroup.Values.First().ToPar().GetHitColor() == hc)
    					{
    						ip.TextIm = GameText.フロアを増設し収容できる奴隷の数を増やす;
    					}
    					Player説明(ref hc, subinfo);
    				}
    				ip.Move(ref hc);
    			}
    		};
    		mod.Leave = delegate
    		{
    			if (SDShow)
    			{
    				SaveData.Leave();
    			}
    			else if (!ip.選択肢表示)
    			{
    				dbs.Leave();
    				bs.Leave();
    				lv.Leave();
    			}
    		};
    		mod.Wheel = delegate
    		{
    		};
    		mod.Setting = delegate
    		{
    			if (Med.Modeb != "PlayerInformation")
    			{
    				ip.UpdateSub2();
    				ip.MaiShow = true;
    				ip.Mai.Feed.Dra = false;
    				ip.Mai2Show = false;
    				ip.SubShow = true;
    				ip.Sub2Show = true;
    				lv.bs["0"].Dra = !GlobalState.GameData.PurchasedTools[0];
    				lv.bs["1"].Dra = !GlobalState.GameData.PurchasedTools[1];
    				lv.bs["2"].Dra = !GlobalState.GameData.PurchasedTools[2];
    				lv.bs["3"].Dra = !GlobalState.GameData.PurchasedTools[3];
    				lv.bs["4"].Dra = !GlobalState.GameData.PurchasedTools[4];
    				lv.bs["5"].Dra = !GlobalState.GameData.PurchasedTools[5];
    				lv.bs["6"].Dra = !GlobalState.GameData.PurchasedTools[6];
    				lv.bs["7"].Dra = !GlobalState.GameData.PurchasedTools[7];
    				lv.bs["8"].Dra = !GlobalState.GameData.PurchasedTools[8];
    				lv.bs["9"].Dra = !GlobalState.GameData.PurchasedTools[9];
    				lv.bs["10"].Dra = !GlobalState.GameData.PurchasedTools[10];
    				lv.bs["11"].Dra = !GlobalState.GameData.PurchasedTools[11];
    				lv.bs["12"].Dra = !GlobalState.GameData.PurchasedTools[12];
    				lv.bs["13"].Dra = !GlobalState.GameData.PurchasedTools[13];
    				lv.bs["14"].Dra = GlobalState.GameData.フロア数 < 9;
    				if (GlobalState.GameData.PurchasedTools.All((bool e) => e) && GlobalState.GameData.フロア数 == 9)
    				{
    					ip.TextIm = GameText.売り切れです;
    				}
    				else
    				{
    					ip.TextIm = " ";
    				}
    				subinfo();
    			}
    		};
    		DrawToolShop = delegate(RenderArea a, FpsCounter FPS)
    		{
    			Med.HitGraphics.Clear(ColorHelper.Transparent);
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(ColorHelper.Transparent);
    			}
    			a.Draw(OfficeBackground);
    			lv.Draw(a);
    			bs.Draw(a);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			if (SDShow)
    			{
    				SaveData.Draw(a);
    			}
    			Med.Draw(DrawBuffer);
    		};
    		mod.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, DrawToolShop);
    		};
    		mod.Dispose = delegate
    		{
    			lv.Dispose();
    			bs.Dispose();
    		};
    		return mod;
    	}

    	public static Module StartOfDay(ModeEventDispatcher Med)
    	{
    		Module obj = new Module
    		{
    			Down = delegate
    			{
    				GlobalState.GameData.時間進行();
    				if (日利益額 != 0 || 日利子額 != 0)
    				{
    					if (日利益額 != 0)
    					{
    						GlobalState.GameData.所持金 = GlobalState.GameData.所持金.overflow_add(日利益額);
    					}
    					if (日利子額 != 0)
    					{
    						GlobalState.GameData.借金 = GlobalState.GameData.借金.overflow_add(日利子額);
    					}
    					//Sounds.精算.Play();
    					ip.UpdateSub2();
    				}
    				if (GlobalState.GameData.日数 >= 10)
    				{
    					GlobalState.GameData.利子 = 0.002;
    				}
    				GlobalState.GameData.需給更新();
    				Med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
    			},
    			Up = delegate
    			{
    			},
    			Move = delegate
    			{
    			},
    			Leave = delegate
    			{
    			},
    			Wheel = delegate
    			{
    			},
    			Setting = delegate
    			{
    				ip.UpdateSub2();
    				ip.MaiShow = true;
    				ip.Mai.Feed.Dra = true;
    				ip.Mai2Show = true;
    				ip.SubShow = true;
    				ip.Sub2Show = true;
    				ip.Mai2Im = (from e in DayEndLog
    					where !string.IsNullOrWhiteSpace(e)
    					select e.Substring(0, e.Length - 2)).Join("\r\n") + ((労働利益 != 0) ? ("\r\n" + GameText.労働利益 + " + " + 労働利益.ToString("#,0")) : "");
    				ip.TextIm = ((日利益額 != 0) ? (GameText.利益 + " + " + 日利益額.ToString("#,0") + "\r\n") : "") + ((日利子額 != 0) ? (GameText.利子 + " + " + 日利子額.ToString("#,0") + "\r\n") : "") + ">> Next days.";
    				if (TrainingTarget != null && GlobalState.GameData.TrainingTarget != null)
    				{
    					InitializeTrainingTarget();
    					妊娠状態反映();
    				}
    				si.Set(bre: false);
    			}
    		};
    		日数進行描画 = delegate(RenderArea a, FpsCounter FPS)
    		{
    			if (TrainingTarget != null)
    			{
    				TrainingTarget.Motions.Drive(FPS);
    			}
    			Med.HitGraphics.Clear(ColorHelper.Transparent);
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(ColorHelper.Transparent);
    			}
    			a.Draw(BlackBackground);
    			ip.Draw(a, FPS);
    			Med.Draw(a);
    		};
    		obj.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, 日数進行描画);
    		};
    		obj.Dispose = delegate
    		{
    		};
    		return obj;
    	}

    	public static Module PlayerInformation(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		double num = 0.2;
    		double num2 = 0.039;
    		double num3 = 0.15;
    		Button 完了 = MyUI.Button(Med, DrawBuffer, GameText.完了, new Vector2D(num2 + 0.19, num3 + 0.72), delegate
    		{
    			GlobalState.GameData.配色 = new 主人公配色(GlobalState.GameData.色);
    			Player.UI.ハンド右.再配色(GlobalState.GameData.配色);
    			Player.UI.ハンド左.再配色(GlobalState.GameData.配色);
    			Player.UI.ペニス.再配色(GlobalState.GameData.配色);
    			Player.UI.マウス.再配色(GlobalState.GameData.配色);
    			GlobalState.GameData.プレーヤー = Generator.プレーヤー();
    			//Sounds.完了.Play();
    			if (start)
    			{
    				start = false;
    				Med.SwitchMode("OP0", DrawBuffer, DrawOP0);
    			}
    			else
    			{
    				switch (Med.Modeb)
    				{
    				case "メインフォーム":
    					Med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
    					break;
    				case "対象":
    					Med.SwitchMode("対象", DrawBuffer, 対象描画);
    					break;
    				case "Blessing":
    					Med.SwitchMode("Blessing", DrawBuffer, DrawBlessing);
    					break;
    				case "Office":
    					Med.SwitchMode("Office", DrawBuffer, DrawOffice);
    					break;
    				case "Debt":
    					Med.SwitchMode("Debt", DrawBuffer, DrawDebt);
    					break;
    				case "SlaveShop":
    					Med.SwitchMode("SlaveShop", DrawBuffer, DrawSlaveShop);
    					break;
    				case "ToolShop":
    					Med.SwitchMode("ToolShop", DrawBuffer, DrawToolShop);
    					break;
    				}
    			}
    		});
    		LabelMap ls = new LabelMap(Med, DrawBuffer);
    		ls.Add("ラベル0", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 - 0.1)), 0.1, 2.5, new Font("MS Gothic", 1f), 0.085, " ", ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル1", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, GameText.肌の色, ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル2", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル3", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "S:", ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル4", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.127)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "V:", ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル5", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, GameText.髪の色, ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル6", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル7", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "S:", ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル8", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.127)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "V:", ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル9", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, GameText.瞳の色, ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル10", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル11", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "S:", ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル12", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.127)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "V:", ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル13", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 3.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, GameText.体格, ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル14", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 3.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ls.Add("ラベル15", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 3.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "W:", ColorHelper.White, ColorHelper.Black, ip.MaiB.GetBrushColor(), ColorHelper.Black, Input: false);
    		ProgressBar H肌 = new ProgressBar("H肌", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 0.0 + 0.06)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, ColorHelper.Black, Knob: true);
    		H肌.Gauge.SetPenColor(ColorHelper.White);
    		H肌.Frame1.SetPenColor(ColorHelper.White);
    		H肌.Knob.SetPenColor(ColorHelper.White);
    		H肌.Knob.SetHitColor(Med.GetUniqueColor());
    		ProgressBar S肌 = new ProgressBar("S肌", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 0.0 + 0.1)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, ColorHelper.Black, Knob: true);
    		S肌.Gauge.SetPenColor(ColorHelper.White);
    		S肌.Frame1.SetPenColor(ColorHelper.White);
    		S肌.Knob.SetPenColor(ColorHelper.White);
    		S肌.Knob.SetHitColor(Med.GetUniqueColor());
    		ProgressBar V肌 = new ProgressBar("V肌", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 0.0 + 0.14)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, ColorHelper.Black, Knob: true);
    		V肌.Gauge.SetPenColor(ColorHelper.White);
    		V肌.Frame1.SetPenColor(ColorHelper.White);
    		V肌.Knob.SetPenColor(ColorHelper.White);
    		V肌.Knob.SetHitColor(Med.GetUniqueColor());
    		ProgressBar H髪 = new ProgressBar("H髪", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 1.0 + 0.06)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, ColorHelper.Black, Knob: true);
    		H髪.Gauge.SetPenColor(ColorHelper.White);
    		H髪.Frame1.SetPenColor(ColorHelper.White);
    		H髪.Knob.SetPenColor(ColorHelper.White);
    		H髪.Knob.SetHitColor(Med.GetUniqueColor());
    		ProgressBar S髪 = new ProgressBar("S髪", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 1.0 + 0.1)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, ColorHelper.Black, Knob: true);
    		S髪.Gauge.SetPenColor(ColorHelper.White);
    		S髪.Frame1.SetPenColor(ColorHelper.White);
    		S髪.Knob.SetPenColor(ColorHelper.White);
    		S髪.Knob.SetHitColor(Med.GetUniqueColor());
    		ProgressBar V髪 = new ProgressBar("V髪", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 1.0 + 0.14)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, ColorHelper.Black, Knob: true);
    		V髪.Gauge.SetPenColor(ColorHelper.White);
    		V髪.Frame1.SetPenColor(ColorHelper.White);
    		V髪.Knob.SetPenColor(ColorHelper.White);
    		V髪.Knob.SetHitColor(Med.GetUniqueColor());
    		ProgressBar H瞳 = new ProgressBar("H瞳", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 2.0 + 0.06)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, ColorHelper.Black, Knob: true);
    		H瞳.Gauge.SetPenColor(ColorHelper.White);
    		H瞳.Frame1.SetPenColor(ColorHelper.White);
    		H瞳.Knob.SetPenColor(ColorHelper.White);
    		H瞳.Knob.SetHitColor(Med.GetUniqueColor());
    		ProgressBar S瞳 = new ProgressBar("S瞳", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 2.0 + 0.1)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, ColorHelper.Black, Knob: true);
    		S瞳.Gauge.SetPenColor(ColorHelper.White);
    		S瞳.Frame1.SetPenColor(ColorHelper.White);
    		S瞳.Knob.SetPenColor(ColorHelper.White);
    		S瞳.Knob.SetHitColor(Med.GetUniqueColor());
    		ProgressBar V瞳 = new ProgressBar("V瞳", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 2.0 + 0.14)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, ColorHelper.Black, Knob: true);
    		V瞳.Gauge.SetPenColor(ColorHelper.White);
    		V瞳.Frame1.SetPenColor(ColorHelper.White);
    		V瞳.Knob.SetPenColor(ColorHelper.White);
    		V瞳.Knob.SetHitColor(Med.GetUniqueColor());
    		ProgressBar 身長 = new ProgressBar("身長", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 3.0 + 0.06)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, ColorHelper.Black, Knob: true);
    		身長.Gauge.SetPenColor(ColorHelper.White);
    		身長.Frame1.SetPenColor(ColorHelper.White);
    		身長.Knob.SetPenColor(ColorHelper.White);
    		身長.Knob.SetHitColor(Med.GetUniqueColor());
    		ProgressBar 体重 = new ProgressBar("体重", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 3.0 + 0.1)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, ColorHelper.Black, Knob: true);
    		体重.Gauge.SetPenColor(ColorHelper.White);
    		体重.Frame1.SetPenColor(ColorHelper.White);
    		体重.Knob.SetPenColor(ColorHelper.White);
    		体重.Knob.SetHitColor(Med.GetUniqueColor());
    		Hsv hsv = HSV.ToHSV(ref GlobalState.GameData.色.肌色);
    		H肌.Value = (double)hsv.H / 360.0;
    		S肌.Value = (double)hsv.S / 255.0;
    		V肌.Value = (double)hsv.V / 255.0;
    		H肌.Base.SetBrushColor(GlobalState.GameData.色.肌色);
    		S肌.Base.SetBrushColor(GlobalState.GameData.色.肌色);
    		V肌.Base.SetBrushColor(GlobalState.GameData.色.肌色);
    		ls["ラベル2"].Text = "H:" + hsv.H;
    		ls["ラベル3"].Text = "S:" + hsv.S;
    		ls["ラベル4"].Text = "V:" + hsv.V;
    		hsv = HSV.ToHSV(ref GlobalState.GameData.色.髪色);
    		H髪.Value = (double)hsv.H / 360.0;
    		S髪.Value = (double)hsv.S / 255.0;
    		V髪.Value = (double)hsv.V / 255.0;
    		H髪.Base.SetBrushColor(GlobalState.GameData.色.髪色);
    		S髪.Base.SetBrushColor(GlobalState.GameData.色.髪色);
    		V髪.Base.SetBrushColor(GlobalState.GameData.色.髪色);
    		ls["ラベル6"].Text = "H:" + hsv.H;
    		ls["ラベル7"].Text = "S:" + hsv.S;
    		ls["ラベル8"].Text = "V:" + hsv.V;
    		hsv = HSV.ToHSV(ref GlobalState.GameData.色.瞳色);
    		H瞳.Value = (double)hsv.H / 360.0;
    		S瞳.Value = (double)hsv.S / 255.0;
    		V瞳.Value = (double)hsv.V / 255.0;
    		H瞳.Base.SetBrushColor(GlobalState.GameData.色.瞳色);
    		S瞳.Base.SetBrushColor(GlobalState.GameData.色.瞳色);
    		V瞳.Base.SetBrushColor(GlobalState.GameData.色.瞳色);
    		ls["ラベル10"].Text = "H:" + hsv.H;
    		ls["ラベル11"].Text = "S:" + hsv.S;
    		ls["ラベル12"].Text = "V:" + hsv.V;
    		身長.Value = GlobalState.GameData.身長;
    		体重.Value = GlobalState.GameData.体重;
    		ls["ラベル14"].Text = "H:" + $"{身長.Value:0.00}";
    		ls["ラベル15"].Text = "W:" + $"{体重.Value:0.00}";
    		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (mb == MouseButtons.Left)
    			{
    				H肌.Down(ref hc, ref cp);
    				S肌.Down(ref hc, ref cp);
    				V肌.Down(ref hc, ref cp);
    				H髪.Down(ref hc, ref cp);
    				S髪.Down(ref hc, ref cp);
    				V髪.Down(ref hc, ref cp);
    				H瞳.Down(ref hc, ref cp);
    				S瞳.Down(ref hc, ref cp);
    				V瞳.Down(ref hc, ref cp);
    				身長.Down(ref hc, ref cp);
    				体重.Down(ref hc, ref cp);
    				完了.Down(ref hc);
    			}
    		};
    		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (mb == MouseButtons.Left)
    			{
    				H肌.Up();
    				S肌.Up();
    				V肌.Up();
    				H髪.Up();
    				S髪.Up();
    				V髪.Up();
    				H瞳.Up();
    				S瞳.Up();
    				V瞳.Up();
    				身長.Up();
    				体重.Up();
    				完了.Up(ref hc);
    			}
    		};
    		int h;
    		int s;
    		int v;
    		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			if (mb == MouseButtons.Left)
    			{
    				H肌.Move(ref cp);
    				S肌.Move(ref cp);
    				V肌.Move(ref cp);
    				h = (int)(360.0 * H肌.Value);
    				s = (int)(255.0 * S肌.Value);
    				v = (int)(255.0 * V肌.Value);
    				HSV.ToRGB(h, s, v, out GlobalState.GameData.色.肌色);
    				H肌.Base.SetBrushColor(GlobalState.GameData.色.肌色);
    				S肌.Base.SetBrushColor(GlobalState.GameData.色.肌色);
    				V肌.Base.SetBrushColor(GlobalState.GameData.色.肌色);
    				ls["ラベル2"].Text = "H:" + h;
    				ls["ラベル3"].Text = "S:" + s;
    				ls["ラベル4"].Text = "V:" + v;
    				H髪.Move(ref cp);
    				S髪.Move(ref cp);
    				V髪.Move(ref cp);
    				h = (int)(360.0 * H髪.Value);
    				s = (int)(255.0 * S髪.Value);
    				v = (int)(255.0 * V髪.Value);
    				HSV.ToRGB(h, s, v, out GlobalState.GameData.色.髪色);
    				H髪.Base.SetBrushColor(GlobalState.GameData.色.髪色);
    				S髪.Base.SetBrushColor(GlobalState.GameData.色.髪色);
    				V髪.Base.SetBrushColor(GlobalState.GameData.色.髪色);
    				ls["ラベル6"].Text = "H:" + h;
    				ls["ラベル7"].Text = "S:" + s;
    				ls["ラベル8"].Text = "V:" + v;
    				H瞳.Move(ref cp);
    				S瞳.Move(ref cp);
    				V瞳.Move(ref cp);
    				h = (int)(360.0 * H瞳.Value);
    				s = (int)(255.0 * S瞳.Value);
    				v = (int)(255.0 * V瞳.Value);
    				HSV.ToRGB(h, s, v, out GlobalState.GameData.色.瞳色);
    				H瞳.Base.SetBrushColor(GlobalState.GameData.色.瞳色);
    				S瞳.Base.SetBrushColor(GlobalState.GameData.色.瞳色);
    				V瞳.Base.SetBrushColor(GlobalState.GameData.色.瞳色);
    				ls["ラベル10"].Text = "H:" + h;
    				ls["ラベル11"].Text = "S:" + s;
    				ls["ラベル12"].Text = "V:" + v;
    				身長.Move(ref cp);
    				体重.Move(ref cp);
    				ls["ラベル14"].Text = "H:" + $"{身長.Value:0.00}";
    				ls["ラベル15"].Text = "W:" + $"{体重.Value:0.00}";
    			}
    			完了.Move(ref hc);
    		};
    		mod.Leave = delegate
    		{
    			H肌.Leave();
    			S肌.Leave();
    			V肌.Leave();
    			H髪.Leave();
    			S髪.Leave();
    			V髪.Leave();
    			H瞳.Leave();
    			S瞳.Leave();
    			V瞳.Leave();
    			身長.Leave();
    			体重.Leave();
    			完了.Leave();
    		};
    		mod.Wheel = delegate
    		{
    		};
    		mod.Setting = delegate
    		{
    			ls["ラベル0"].Text = GameText.プレイヤーの遺伝情報を設定してください + (start ? ("(" + GameText.後から変更できます + ")") : "");
    			hsv = HSV.ToHSV(ref GlobalState.GameData.色.肌色);
    			H肌.Value = (double)hsv.H / 360.0;
    			S肌.Value = (double)hsv.S / 255.0;
    			V肌.Value = (double)hsv.V / 255.0;
    			H肌.Base.SetBrushColor(GlobalState.GameData.色.肌色);
    			S肌.Base.SetBrushColor(GlobalState.GameData.色.肌色);
    			V肌.Base.SetBrushColor(GlobalState.GameData.色.肌色);
    			ls["ラベル2"].Text = "H:" + hsv.H;
    			ls["ラベル3"].Text = "S:" + hsv.S;
    			ls["ラベル4"].Text = "V:" + hsv.V;
    			hsv = HSV.ToHSV(ref GlobalState.GameData.色.髪色);
    			H髪.Value = (double)hsv.H / 360.0;
    			S髪.Value = (double)hsv.S / 255.0;
    			V髪.Value = (double)hsv.V / 255.0;
    			H髪.Base.SetBrushColor(GlobalState.GameData.色.髪色);
    			S髪.Base.SetBrushColor(GlobalState.GameData.色.髪色);
    			V髪.Base.SetBrushColor(GlobalState.GameData.色.髪色);
    			ls["ラベル6"].Text = "H:" + hsv.H;
    			ls["ラベル7"].Text = "S:" + hsv.S;
    			ls["ラベル8"].Text = "V:" + hsv.V;
    			hsv = HSV.ToHSV(ref GlobalState.GameData.色.瞳色);
    			H瞳.Value = (double)hsv.H / 360.0;
    			S瞳.Value = (double)hsv.S / 255.0;
    			V瞳.Value = (double)hsv.V / 255.0;
    			H瞳.Base.SetBrushColor(GlobalState.GameData.色.瞳色);
    			S瞳.Base.SetBrushColor(GlobalState.GameData.色.瞳色);
    			V瞳.Base.SetBrushColor(GlobalState.GameData.色.瞳色);
    			ls["ラベル10"].Text = "H:" + hsv.H;
    			ls["ラベル11"].Text = "S:" + hsv.S;
    			ls["ラベル12"].Text = "V:" + hsv.V;
    			身長.Value = GlobalState.GameData.身長;
    			体重.Value = GlobalState.GameData.体重;
    			ls["ラベル14"].Text = "H:" + $"{身長.Value:0.00}";
    			ls["ラベル15"].Text = "W:" + $"{体重.Value:0.00}";
    		};
    		PlayerInformationSliders = delegate(RenderArea a, FpsCounter FPS)
    		{
    			Med.HitGraphics.Clear(ColorHelper.Transparent);
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(ColorHelper.Transparent);
    			}
    			a.Draw(BlackBackground);
    			ls.Draw(a);
    			a.Draw(H肌.PartGroup);
    			a.Draw(S肌.PartGroup);
    			a.Draw(V肌.PartGroup);
    			a.Draw(H髪.PartGroup);
    			a.Draw(S髪.PartGroup);
    			a.Draw(V髪.PartGroup);
    			a.Draw(H瞳.PartGroup);
    			a.Draw(S瞳.PartGroup);
    			a.Draw(V瞳.PartGroup);
    			a.Draw(身長.PartGroup);
    			a.Draw(体重.PartGroup);
    			完了.Draw(a);
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, PlayerInformationSliders);
    		};
    		mod.Dispose = delegate
    		{
    			ls.Dispose();
    			H肌.Dispose();
    			S肌.Dispose();
    			V肌.Dispose();
    			H髪.Dispose();
    			S髪.Dispose();
    			V髪.Dispose();
    			H瞳.Dispose();
    			S瞳.Dispose();
    			V瞳.Dispose();
    			身長.Dispose();
    			体重.Dispose();
    			完了.Dispose();
    		};
    		return mod;
    	}

    	public static Module OP0(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		int i = 0;
    		int wi = 0;
    		string[] tsp = new string[4]
    		{
    			GameText.点12,
    			GameText.点9,
    			GameText.点6,
    			GameText.点3
    		};
    		string[] sub = new string[4]
    		{
    			"",
    			GameText.闇が揺れる,
    			GameText.身体が現る,
    			GameText.意識が宿る
    		};
    		mod.Down = delegate
    		{
    			//TODO uncomment
    			if (!ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
    			{
    				i++;
    				wi = i;
    				if (i < tsp.Length)
    				{
    					ip.Text = tsp[i];
    					ip.SubInfo = sub[i];
    				}
    				else
    				{
    					Med.SwitchMode("OP1", DrawBuffer, DrawOP1);
    				}
    			}
    		};
    		mod.Setting = delegate
    		{
    			ip.UpdateSub2();
    			ip.MaiShow = true;
    			ip.Mai.Feed.Dra = true;
    			ip.Mai2Show = false;
    			ip.SubShow = true;
    			ip.Sub2Show = true;
    			//Sounds.OPBGM.Stop();
    			i = 0;
    			wi = 0;
    			ip.Text = tsp[i];
    			ip.SubInfo = sub[i];
    		};
    		DrawOP0 = delegate(RenderArea a, FpsCounter FPS)
    		{
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(ColorHelper.Transparent);
    			}
    			a.Draw(BlackBackground);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, DrawOP0);
    		};
    		mod.Dispose = delegate
    		{
    		};
    		return mod;
    	}

    	public static Module OP1(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		int i = 0;
    		int wi = 0;
    		Action[] sfc = new Action[15]
    		{
    			delegate
    			{
    				Viola.表情_基本0();
    			},
    			delegate
    			{
    				Viola.表情_基本1();
    			},
    			delegate
    			{
    				Viola.表情_困り顔0();
    			},
    			delegate
    			{
    				Viola.表情_困り顔1();
    			},
    			delegate
    			{
    				Viola.表情_不敵0();
    			},
    			delegate
    			{
    				Viola.表情_基本1();
    			},
    			delegate
    			{
    				Viola.表情_不敵1眉上();
    			},
    			delegate
    			{
    				Viola.表情_基本1();
    			},
    			delegate
    			{
    				Viola.表情_不敵0();
    			},
    			delegate
    			{
    				Viola.表情_不敵0眉上();
    			},
    			delegate
    			{
    				Viola.表情_基本1眉上();
    			},
    			delegate
    			{
    			},
    			delegate
    			{
    				Viola.表情_卑屈();
    			},
    			delegate
    			{
    				Viola.表情_基本1();
    			},
    			delegate
    			{
    				Viola.表情_不敵0();
    			}
    		};
    		string[] tsc = new string[15]
    		{
    			GameText.点6,
    			GameText.お目覚めかしら,
    			GameText.話の途中で眠ってしまうんですもの,
    			GameText.よっぽど疲れていたのね,
    			GameText.点3,
    			GameText.誰って顔をしているわね,
    			GameText.うふふ良いわ + "\r\n" + GameText.もう一度自己紹介をしてあげる,
    			GameText.私の名前はヴィオランテ + "  \r\n" + GameText.ここではヴィオラと呼ばれているわ,
    			GameText.点3,
    			GameText.それでは話の続きをしましょうか,
    			GameText.今あなたには全部で + 5000000000uL.ToString("#,0") + GameText.の借金が課せられているわ,
    			"",
    			GameText.でも心配しないで,
    			GameText.そんなあなたにぴったりなお仕事を紹介してあげる,
    			GameText.とっても儲かる素敵なお仕事をね
    		};
    		string[] tsp = new string[15]
    		{
    			GameText.点6ハテナ,
    			GameText.点6,
    			GameText.点9,
    			GameText.点6,
    			GameText.点9,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			"",
    			GameText.点9,
    			GameText.点6,
    			GameText.点9
    		};
    		string[] sub = new string[15]
    		{
    			GameText.光が射す,
    			GameText.目が眩む,
    			GameText.見慣れぬ女が立っている,
    			GameText.良い香りがする,
    			GameText.空気はぬるい,
    			GameText.女は語る,
    			GameText.女は続ける,
    			GameText.女は名乗る,
    			GameText.違和感を覚える,
    			GameText.知らない世界だ,
    			"",
    			"",
    			GameText.なんて日だ,
    			GameText.話が進む,
    			GameText.事は運ぶ
    		};
    		Action<TextBlock> d = delegate
    		{
    			ip.SubInfo = GameText.安い額ではない;
    			ip.選択yAct = delegate
    			{
    				//Sounds.操作.Play();
    				ViolaTextBubble.TextBlock.Done = delegate
    				{
    					//Sounds.精算.Play();
    					GlobalState.GameData.借金 = 5000000000uL;
    					ip.UpdateSub2();
    				};
    				Viola.表情_不敵0眉上();
    				ViolaTextBubble.Text = GameText.うふふそうよね;
    				ip.Text = GameText.点6;
    				ip.SubInfo = GameText.身に覚えはない;
    				if (i == 10)
    				{
    					i++;
    					wi = i;
    				}
    				if (wi == 10)
    				{
    					wi++;
    				}
    				ip.選択肢表示 = false;
    			};
    			ip.選択nAct = delegate
    			{
    				//Sounds.操作.Play();
    				ViolaTextBubble.TextBlock.Done = delegate
    				{
    					//Sounds.精算.Play();
    					GlobalState.GameData.借金 = 5000000000uL;
    					ip.UpdateSub2();
    				};
    				Viola.表情_素1();
    				ViolaTextBubble.Text = GameText.関係ないわここに書いてあるもの + "\r\n" + GameText.ほらねそうでしょう;
    				ip.Text = GameText.点6;
    				ip.SubInfo = GameText.身に覚えはない;
    				if (i == 10)
    				{
    					i++;
    					wi = i;
    				}
    				if (wi == 10)
    				{
    					wi++;
    				}
    				ip.選択肢表示 = false;
    			};
    			ip.選択肢表示 = true;
    		};
    		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.DownB(ref hc);
    			if (!ViolaTextBubble.TextBlock.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying)
    			{
    				if (wi == i && i != 10 && ViolaTextBubble.TextBlock.Done == null)
    				{
    					i++;
    					wi = i;
    					if (i < tsp.Length)
    					{
    						if (i == 10)
    						{
    							ViolaTextBubble.TextBlock.Done = d;
    						}
    						else
    						{
    							ViolaTextBubble.TextBlock.Done = null;
    						}
    						if (i != 11)
    						{
    							sfc[i]();
    							ViolaTextBubble.Text = tsc[i];
    							ip.Text = tsp[i];
    							ip.SubInfo = sub[i];
    						}
    					}
    					else
    					{
    						Med.SwitchMode("説明", DrawBuffer, 説明描画);
    					}
    				}
    				else if (wi == 12 && i == 11)
    				{
    					i += 2;
    					wi = i;
    					sfc[i]();
    					ViolaTextBubble.Text = tsc[i];
    					ip.Text = tsp[i];
    					ip.SubInfo = sub[i];
    				}
    			}
    		};
    		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Up(ref hc);
    		};
    		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Move(ref hc);
    		};
    		mod.Setting = delegate
    		{
    			ip.Mai.Feed.Dra = false;
    			//Sounds.日常BGM.Play();
    			GlobalState.GameData.ヴィオラ = new Unit();
    			GlobalState.GameData.ヴィオラ.SetViola(Med, DrawBuffer);
    			Viola = new Character(Med, DrawBuffer, GlobalState.GameData.ヴィオラ.ChaD);
    			Viola.Set衣装(GlobalState.GameData.ヴィオラ.着衣);
    			ViolaTextBubble.接続(Viola.Body.頭.口_接続点);
    			i = 0;
    			wi = 0;
    			sfc[i]();
    			ViolaTextBubble.Text = tsc[i];
    			ip.Text = tsp[i];
    			ip.SubInfo = sub[i];

    			Viola.両目_見つめ();
    			Viola.Set基本姿勢();
            };
    		DrawOP1 = delegate(RenderArea a, FpsCounter FPS)
    		{
    			a.Draw(OfficeBackground);
    			Viola.Draw(a, FPS);
    			ViolaTextBubble.Draw(a, FPS);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, DrawOP1);
    		};
    		mod.Dispose = delegate
    		{
    		};
    		return mod;
    	}

    	public static Module 説明(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		int i = 0;
    		int wi = 0;
    		Action[] sfc = new Action[11]
    		{
    			delegate
    			{
    				Viola.表情_基本0();
    			},
    			delegate
    			{
    				Viola.表情_基本1();
    			},
    			delegate
    			{
    				Viola.表情_不敵1();
    			},
    			delegate
    			{
    				Viola.表情_基本0();
    			},
    			delegate
    			{
    				Viola.表情_基本1();
    			},
    			delegate
    			{
    				Viola.表情_不敵0眉上();
    			},
    			delegate
    			{
    				Viola.表情_基本1眉上();
    			},
    			delegate
    			{
    				Viola.表情_不敵0眉上();
    			},
    			delegate
    			{
    				Viola.表情_基本1();
    			},
    			delegate
    			{
    				Viola.表情_不敵1眉上();
    			},
    			delegate
    			{
    				Viola.表情_不敵0眉上();
    			}
    		};
    		string[] tsc = new string[11]
    		{
    			GameText.点3,
    			GameText.ここは地下牢よ,
    			GameText.あなたにはこの場所で調教師として働いてもらうわ,
    			GameText.仕事の流れを説明するわね,
    			GameText.まず事務所で奴隷を仕入れて頂戴,
    			GameText.仕入れたら性奴として使えるようにあなたが躾けるの,
    			GameText.躾けた分だけ上乗せされた値段で売れるようになるわ,
    			GameText.それと従順になった奴隷に働いてもらうのもいいわね + "   \r\n" + GameText.あと奴隷の転売という手もあるわ,
    			GameText.まぁこんなところね簡単でしょう,
    			GameText.それでは頑張って頂戴,
    			GameText.期待しているわ
    		};
    		string[] tsp = new string[11]
    		{
    			GameText.点6,
    			GameText.点3,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6
    		};
    		string[] sub = new string[11]
    		{
    			GameText.冷めた空気が舞い上がる,
    			GameText.ヴィオラは語る,
    			GameText.仕事が決まる,
    			GameText.説明が始まる,
    			GameText.ヴィオラは語る,
    			GameText.ヴィオラは続ける,
    			GameText.説明が続く,
    			GameText.説明は続く,
    			GameText.説明が終わる,
    			GameText.奴隷母体の名の下に,
    			GameText.物語は動き出す
    		};
    		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.DownB(ref hc);
    			if (!ViolaTextBubble.TextBlock.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
    			{
    				i++;
    				wi = i;
    				if (i < tsp.Length)
    				{
    					sfc[i]();
    					ViolaTextBubble.Text = tsc[i];
    					ip.Text = tsp[i];
    					ip.SubInfo = sub[i];
    				}
    				else
    				{
    					Med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
    				}
    			}
    		};
    		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Up(ref hc);
    		};
    		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Move(ref hc);
    		};
    		mod.Setting = delegate
    		{
    			Viola.両目_見つめ();
    			Viola.表情_基本1();
    			Viola.Set基本姿勢();
    			i = 0;
    			wi = 0;
    			sfc[i]();
    			ViolaTextBubble.Text = tsc[i];
    			ip.Text = tsp[i];
    			ip.SubInfo = sub[i];
    		};
    		説明描画 = delegate(RenderArea a, FpsCounter FPS)
    		{
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(ColorHelper.Transparent);
    			}
    			a.Draw(BasementBackground);
    			Viola.Draw(a, FPS);
    			ViolaTextBubble.Draw(a, FPS);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, 説明描画);
    		};
    		mod.Dispose = delegate
    		{
    		};
    		return mod;
    	}

    	public static Module 初事務所(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		int i = 0;
    		int wi = 0;
    		Action[] sfc = new Action[11]
    		{
    			delegate
    			{
    				Viola.表情_基本0();
    			},
    			delegate
    			{
    				Viola.表情_不敵1();
    			},
    			delegate
    			{
    			},
    			delegate
    			{
    				Viola.表情_不敵1眉上();
    			},
    			delegate
    			{
    				Viola.表情_基本1();
    			},
    			delegate
    			{
    				Viola.表情_不敵1眉上();
    			},
    			delegate
    			{
    				Viola.表情_基本0();
    			},
    			delegate
    			{
    			},
    			delegate
    			{
    				Viola.表情_不敵0眉上();
    			},
    			delegate
    			{
    				Viola.表情_基本0();
    			},
    			delegate
    			{
    				Viola.表情_不敵0();
    			}
    		};
    		string[] tsc = new string[11]
    		{
    			GameText.点6,
    			GameText.どうかしたの,
    			"",
    			GameText.お金がなければ借りればいいじゃない,
    			GameText.借金と返済は事務所つまりここで出来るわ,
    			GameText.借金には1日 + GlobalState.GameData.利子 * 100.0 + GameText.の利子がつくわよ + "  \r\n" + GameText.良心的よねうふふ,
    			GameText.そうそう言い忘れていたけどあなたは調教師として必要な拘束術が使えるようになっているはずよ,
    			"",
    			GameText.点6,
    			GameText.私からは以上よ,
    			GameText.仕事に戻ると良いわ
    		};
    		string[] tsp = new string[11]
    		{
    			GameText.点6,
    			GameText.点3,
    			"",
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			"",
    			GameText.点6,
    			GameText.点6,
    			GameText.点6
    		};
    		string[] sub = new string[11]
    		{
    			GameText.ヴィオラは佇む,
    			GameText.ヴィオラは尋ねる,
    			"",
    			GameText.ヴィオラは返す,
    			GameText.説明が始まる,
    			GameText.ヴィオラは語る,
    			GameText.話は続く,
    			"",
    			GameText.危険な女だ,
    			GameText.話が終わる,
    			GameText.話は終わる
    		};
    		Action<TextBlock> d1 = delegate
    		{
    			ip.Mai.Done = delegate
    			{
    				ip.選択yAct = delegate
    				{
    					//Sounds.操作.Play();
    					Viola.表情_不敵0眉上();
    					ViolaTextBubble.Text = GameText.うふふそうよね;
    					ip.Text = GameText.点6;
    					ip.SubInfo = GameText.あなたは答える;
    					if (i == 1)
    					{
    						i++;
    						wi = i;
    					}
    					if (wi == 1)
    					{
    						wi++;
    					}
    					ip.選択肢表示 = false;
    				};
    				ip.選択nAct = delegate
    				{
    					//Sounds.操作.Play();
    					Viola.表情_困り顔1();
    					ViolaTextBubble.Text = GameText.嘘おっしゃい無いのは分かっているわ;
    					ip.Text = GameText.点6;
    					ip.SubInfo = GameText.あなたは答える;
    					if (i == 1)
    					{
    						i++;
    						wi = i;
    					}
    					if (wi == 1)
    					{
    						wi++;
    					}
    					ip.選択肢表示 = false;
    				};
    				ip.選択肢表示 = true;
    			};
    			ip.Text = GameText.金が無い;
    		};
    		Action<TextBlock> d2 = delegate
    		{
    			ip.Mai.Done = delegate
    			{
    				ip.選択yAct = delegate
    				{
    					//Sounds.操作.Play();
    					ip.Sub.Done = delegate
    					{
    						Viola.Body.拘束具_表示 = false;
    						Viola.両翼獣_全開(0);
    						Viola.両触手_S字(0);
    						Viola.両触手_S字(1);
    						Viola.SetSymmetry();
    						Viola.Body.Update();
    						Viola.表情_不敵1();
    						//Sounds.弾け.Play();
    						ip.Text = GameText.エクス2;
    						ip.SubInfo = GameText.あなたの鎖は弾け飛ぶ;
    						ViolaTextBubble.Text = GameText.あらあら今ので利子が上がってしまったわうふふ;
    						ViolaTextBubble.TextBlock.Feed.Dra = true;
    						GlobalState.GameData.利子 *= 2.0;
    					};
    					ViolaTextBubble.TextBlock.Feed.Dra = false;
    					Viola.Body.拘束具_表示 = true;
    					Viola.両翼獣_閉じ(0);
    					Viola.両触手_S字(0);
    					Viola.両触手_S字(1);
    					Viola.SetSymmetry();
    					Viola.Body.Update();
    					Viola.表情_素0眉上();
    					//Sounds.変更1.Play();
    					ViolaTextBubble.Text = GameText.っ点3;
    					ip.Text = GameText.エクス1;
    					ip.SubInfo = GameText.鋼の鎖がヴィオラを縛る + "        ";
    					if (i == 6)
    					{
    						i++;
    						wi = i;
    					}
    					if (wi == 6)
    					{
    						wi++;
    					}
    					ip.選択肢表示 = false;
    				};
    				ip.選択nAct = delegate
    				{
    					//Sounds.操作.Play();
    					Viola.表情_不敵0();
    					ViolaTextBubble.Text = GameText.点3うふふ + "\r\n" + GameText.慎重なのは良いことよ;
    					ip.Text = GameText.点6;
    					ip.SubInfo = GameText.ヴィオラは微笑む;
    					if (i == 6)
    					{
    						i++;
    						wi = i;
    					}
    					if (wi == 6)
    					{
    						wi++;
    					}
    					ip.選択肢表示 = false;
    				};
    				ip.選択肢表示 = true;
    			};
    			ip.Text = GameText.ヴィオラで試す;
    		};
    		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.DownB(ref hc);
    			if (!ViolaTextBubble.TextBlock.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying)
    			{
    				if (wi == i && i != 1 && i != 6 && ViolaTextBubble.TextBlock.Done == null)
    				{
    					i++;
    					wi = i;
    					if (i < tsp.Length)
    					{
    						if (i == 8)
    						{
    							Viola.両翼獣_半開き(0);
    							Viola.Body.Update();
    						}
    						if (i == 1)
    						{
    							ViolaTextBubble.TextBlock.Done = d1;
    						}
    						else if (i == 6)
    						{
    							ViolaTextBubble.TextBlock.Done = d2;
    						}
    						else
    						{
    							ViolaTextBubble.TextBlock.Done = null;
    						}
    						if (i != 2 && i != 7)
    						{
    							sfc[i]();
    							ViolaTextBubble.Text = tsc[i];
    							ip.Text = tsp[i];
    							ip.SubInfo = sub[i];
    						}
    					}
    					else
    					{
    						GlobalState.GameData.初事務所フラグ = false;
    						Med.SwitchMode("Office", DrawBuffer, DrawOffice);
    					}
    				}
    				else if ((wi == 3 && i == 2) || (wi == 8 && i == 7))
    				{
    					i += 2;
    					wi = i;
    					sfc[i]();
    					ViolaTextBubble.Text = tsc[i];
    					ip.Text = tsp[i];
    					ip.SubInfo = sub[i];
    				}
    			}
    		};
    		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Up(ref hc);
    		};
    		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Move(ref hc);
    		};
    		mod.Setting = delegate
    		{
    			ip.UpdateSub2();
    			ip.MaiShow = true;
    			ip.Mai.Feed.Dra = false;
    			ip.Mai2Show = false;
    			ip.SubShow = true;
    			ip.Sub2Show = true;
    			ViolaTextBubble.TextBlock.Feed.Dra = true;
    			Viola.両目_見つめ();
    			Viola.表情_基本0();
    			Viola.Set基本姿勢();
    			i = 0;
    			wi = 0;
    			sfc[i]();
    			ViolaTextBubble.Text = tsc[i];
    			ip.Text = tsp[i];
    			ip.SubInfo = sub[i];
    		};
    		初事務所描画 = delegate(RenderArea a, FpsCounter FPS)
    		{
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(ColorHelper.Transparent);
    			}
    			a.Draw(OfficeBackground);
    			Viola.Draw(a, FPS);
    			ViolaTextBubble.Draw(a, FPS);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, 初事務所描画);
    		};
    		mod.Dispose = delegate
    		{
    		};
    		return mod;
    	}

    	public static Module RepaymentEvent1(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		int i = 0;
    		int wi = 0;
    		Action[] sfc = new Action[3]
    		{
    			delegate
    			{
    				Viola.表情_不敵0();
    			},
    			delegate
    			{
    				Viola.表情_基本1();
    			},
    			delegate
    			{
    				Viola.表情_不敵1();
    			}
    		};
    		string[] tsc = new string[3]
    		{
    			GameText.仕事には慣れたかしら,
    			GameText.あなたが頑張っているおかげで奴隷の仕入元のハンターと話がまとまったの,
    			GameText.今後もこの調子で頑張って頂戴
    		};
    		string[] tsp = new string[3]
    		{
    			GameText.点3,
    			GameText.点6,
    			GameText.点6
    		};
    		string[] sub = new string[3]
    		{
    			GameText.ヴィオラが尋ねる,
    			GameText.ヴィオラは語る,
    			GameText.話が終わる
    		};
    		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.DownB(ref hc);
    			if (!ViolaTextBubble.TextBlock.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
    			{
    				i++;
    				wi = i;
    				if (i < tsp.Length)
    				{
    					sfc[i]();
    					ViolaTextBubble.Text = tsc[i];
    					ip.Text = tsp[i];
    					ip.SubInfo = sub[i];
    				}
    				else
    				{
    					Med.SwitchMode("Office", DrawBuffer, DrawOffice);
    				}
    			}
    		};
    		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Up(ref hc);
    		};
    		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Move(ref hc);
    		};
    		mod.Setting = delegate
    		{
    			ip.UpdateSub2();
    			ip.MaiShow = true;
    			ip.Mai.Feed.Dra = false;
    			ip.Mai2Show = false;
    			ip.SubShow = true;
    			ip.Sub2Show = true;
    			ViolaTextBubble.TextBlock.Feed.Dra = true;
    			Viola.両目_見つめ();
    			Viola.表情_基本0();
    			Viola.Set基本姿勢();
    			i = 0;
    			wi = 0;
    			sfc[i]();
    			ViolaTextBubble.Text = tsc[i];
    			ip.Text = tsp[i];
    			ip.SubInfo = sub[i];
    		};
    		返済イベント描画 = delegate(RenderArea a, FpsCounter FPS)
    		{
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(ColorHelper.Transparent);
    			}
    			a.Draw(OfficeBackground);
    			Viola.Draw(a, FPS);
    			ViolaTextBubble.Draw(a, FPS);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, 返済イベント描画);
    		};
    		mod.Dispose = delegate
    		{
    		};
    		return mod;
    	}

    	public static Module RepaymentEvent2(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		int i = 0;
    		int wi = 0;
    		Action[] sfc = new Action[3]
    		{
    			delegate
    			{
    				Viola.表情_不敵1();
    			},
    			delegate
    			{
    				Viola.表情_不敵0眉上();
    			},
    			delegate
    			{
    				Viola.表情_基本0();
    			}
    		};
    		string[] tsc = new string[3]
    		{
    			GameText.うふふ + "\r\n" + GameText.なかなか順調のようね,
    			GameText.そろそろ奴隷の身嗜みを考えてみてもいいんじゃないかしら,
    			GameText.身嗜みに手を加えられるように手配しておくわね
    		};
    		string[] tsp = new string[3]
    		{
    			GameText.点3,
    			GameText.点6,
    			GameText.点3
    		};
    		string[] sub = new string[3]
    		{
    			GameText.ヴィオラが語る,
    			GameText.ヴィオラは語る,
    			GameText.事は運ぶ
    		};
    		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.DownB(ref hc);
    			if (!ViolaTextBubble.TextBlock.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
    			{
    				i++;
    				wi = i;
    				if (i < tsp.Length)
    				{
    					sfc[i]();
    					ViolaTextBubble.Text = tsc[i];
    					ip.Text = tsp[i];
    					ip.SubInfo = sub[i];
    				}
    				else
    				{
    					Med.SwitchMode("Office", DrawBuffer, DrawOffice);
    				}
    			}
    		};
    		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Up(ref hc);
    		};
    		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Move(ref hc);
    		};
    		mod.Leave = delegate
    		{
    		};
    		mod.Wheel = delegate
    		{
    		};
    		mod.Setting = delegate
    		{
    			ip.UpdateSub2();
    			ip.MaiShow = true;
    			ip.Mai.Feed.Dra = false;
    			ip.Mai2Show = false;
    			ip.SubShow = true;
    			ip.Sub2Show = true;
    			ViolaTextBubble.TextBlock.Feed.Dra = true;
    			Viola.両目_見つめ();
    			Viola.表情_基本0();
    			Viola.Set基本姿勢();
    			i = 0;
    			wi = 0;
    			sfc[i]();
    			ViolaTextBubble.Text = tsc[i];
    			ip.Text = tsp[i];
    			ip.SubInfo = sub[i];
    		};
    		mod.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, 返済イベント描画);
    		};
    		mod.Dispose = delegate
    		{
    		};
    		return mod;
    	}

    	public static Module RepaymentEvent3(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		bool yes = false;
    		int i = 0;
    		int wi = 0;
    		Action[] sfc = new Action[4]
    		{
    			delegate
    			{
    				Viola.表情_不敵1眉上();
    			},
    			delegate
    			{
    				Viola.表情_不敵0();
    			},
    			delegate
    			{
    				Viola.表情_基本0();
    			},
    			delegate
    			{
    			}
    		};
    		Action[] sfcy = new Action[5]
    		{
    			delegate
    			{
    				Viola.表情_素0();
    			},
    			delegate
    			{
    				Viola.表情_不敵1眉上();
    			},
    			delegate
    			{
    				Viola.表情_困り顔0();
    			},
    			delegate
    			{
    				Viola.表情_困り顔1();
    			},
    			delegate
    			{
    				Viola.表情_不敵0眉上();
    			}
    		};
    		Action[] sfcn = new Action[5]
    		{
    			delegate
    			{
    				Viola.表情_不敵1();
    			},
    			delegate
    			{
    				Viola.表情_不敵0眉上();
    			},
    			delegate
    			{
    				Viola.表情_基本0();
    			},
    			delegate
    			{
    				Viola.表情_不敵1();
    			},
    			delegate
    			{
    				Viola.表情_不敵0();
    			}
    		};
    		string[] tsc = new string[4]
    		{
    			GameText.うふふ + "\r\n" + GameText.まさか本当に完済してくれるとは思わなかったわ,
    			GameText.もうあなたがここに縛られている理由は何もないわね,
    			GameText.だから好きになさい,
    			""
    		};
    		string[] tscy = new string[5]
    		{
    			GameText.点6,
    			GameText.そんなこと言わずにもっとゆっくりしていくといいわ,
    			GameText.別にあなたを帰すときのことを考えてなかったとかそういうことではないのよ,
    			GameText.点6,
    			GameText.とにかくご苦労様 + "\r\n" + GameText.そしてありがとう調教師
    		};
    		string[] tscn = new string[5]
    		{
    			GameText.あなたを手放すなんてありえないわ,
    			GameText.なんてったって + 5000000000uL.ToString("#,0") + GameText.もの稼ぎ手ですもの,
    			GameText.点3,
    			GameText.点6,
    			GameText.お勤めご苦労様 + "\r\n" + GameText.そしてありがとう調教師
    		};
    		string[] tsp = new string[9]
    		{
    			GameText.点3,
    			GameText.点6,
    			GameText.点6,
    			"",
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6,
    			GameText.点6
    		};
    		string[] sub = new string[4]
    		{
    			GameText.ヴィオラは語る,
    			GameText.ヴィオラは続ける,
    			GameText.あなたは自由だ,
    			""
    		};
    		string[] suby = new string[5]
    		{
    			GameText.ヴィオラは黙る,
    			GameText.ヴィオラは慌てる,
    			GameText.弁解は続く,
    			GameText.危険な女だ,
    			GameText.物語は終わった
    		};
    		string[] subn = new string[5]
    		{
    			GameText.ヴィオラは語る,
    			GameText.ヴィオラは続ける,
    			GameText.余韻が響く,
    			GameText.余韻に浸る,
    			GameText.物語は終わった
    		};
    		Action<TextBlock> d1 = delegate
    		{
    			ip.Mai.Done = delegate
    			{
    				ip.選択yAct = delegate
    				{
    					yes = true;
    					//Sounds.操作.Play();
    					Viola.表情_基本1眉上();
    					ViolaTextBubble.Text = GameText.え;
    					ip.Text = GameText.点6;
    					ip.SubInfo = GameText.あなたは答える;
    					if (i == 2)
    					{
    						i++;
    						wi = i;
    					}
    					if (wi == 2)
    					{
    						wi++;
    					}
    					ip.選択肢表示 = false;
    				};
    				ip.選択nAct = delegate
    				{
    					yes = false;
    					//Sounds.操作.Play();
    					Viola.表情_不敵0();
    					ViolaTextBubble.Text = GameText.うふふそうよね;
    					ip.Text = GameText.点6;
    					ip.SubInfo = GameText.あなたは答える;
    					if (i == 2)
    					{
    						i++;
    						wi = i;
    					}
    					if (wi == 2)
    					{
    						wi++;
    					}
    					ip.選択肢表示 = false;
    				};
    				ip.選択肢表示 = true;
    			};
    			ip.Text = GameText.家に帰る;
    		};
    		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.DownB(ref hc);
    			if (!ViolaTextBubble.TextBlock.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying)
    			{
    				if (wi == i && i != 2 && ViolaTextBubble.TextBlock.Done == null)
    				{
    					i++;
    					wi = i;
    					if (i < tsp.Length)
    					{
    						if (i == 2)
    						{
    							ViolaTextBubble.TextBlock.Done = d1;
    						}
    						else
    						{
    							ViolaTextBubble.TextBlock.Done = null;
    						}
    						if (i != 3)
    						{
    							if (i < 4)
    							{
    								sfc[i]();
    								ViolaTextBubble.Text = tsc[i];
    								ip.SubInfo = sub[i];
    							}
    							else if (yes)
    							{
    								sfcy[i - 4]();
    								ViolaTextBubble.Text = tscy[i - 4];
    								ip.SubInfo = suby[i - 4];
    							}
    							else
    							{
    								sfcn[i - 4]();
    								ViolaTextBubble.Text = tscn[i - 4];
    								ip.SubInfo = subn[i - 4];
    							}
    							ip.Text = tsp[i];
    						}
    					}
    					else
    					{
    						GlobalState.GameData.初事務所フラグ = false;
    						Med.SwitchMode("Office", DrawBuffer, DrawOffice);
    					}
    				}
    				else if (wi == 4 && i == 3)
    				{
    					i += 2;
    					wi = i;
    					if (i < 4)
    					{
    						sfc[i]();
    						ViolaTextBubble.Text = tsc[i];
    						ip.SubInfo = sub[i];
    					}
    					else if (yes)
    					{
    						sfcy[i - 4]();
    						ViolaTextBubble.Text = tscy[i - 4];
    						ip.SubInfo = suby[i - 4];
    					}
    					else
    					{
    						sfcn[i - 4]();
    						ViolaTextBubble.Text = tscn[i - 4];
    						ip.SubInfo = subn[i - 4];
    					}
    					ip.Text = tsp[i];
    				}
    			}
    		};
    		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Up(ref hc);
    		};
    		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Move(ref hc);
    		};
    		mod.Leave = delegate
    		{
    		};
    		mod.Wheel = delegate
    		{
    		};
    		mod.Setting = delegate
    		{
    			ip.UpdateSub2();
    			ip.MaiShow = true;
    			ip.Mai.Feed.Dra = false;
    			ip.Mai2Show = false;
    			ip.SubShow = true;
    			ip.Sub2Show = true;
    			ViolaTextBubble.TextBlock.Feed.Dra = true;
    			Viola.両目_見つめ();
    			Viola.表情_基本0();
    			Viola.Set基本姿勢();
    			i = 0;
    			wi = 0;
    			sfc[i]();
    			ViolaTextBubble.Text = tsc[i];
    			ip.Text = tsp[i];
    			ip.SubInfo = sub[i];
    		};
    		mod.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, 返済イベント描画);
    		};
    		mod.Dispose = delegate
    		{
    		};
    		return mod;
    	}

    	public static Module ViolaBlessing(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		int i = 0;
    		int wi = 0;
    		Action[] sfc = new Action[4]
    		{
    			delegate
    			{
    				Viola.表情_基本0();
    			},
    			delegate
    			{
    				Viola.表情_不敵1眉上();
    			},
    			delegate
    			{
    				Viola.表情_不敵0();
    			},
    			delegate
    			{
    				//Sounds.祝福.Play();
    				Viola.表情_不敵0眉上();
    			}
    		};
    		string[] tsc = new string[4]
    		{
    			GameText.祝福してほしいの,
    			GameText.そうよね + "\r\n" + GameText.あなたはがんばったもの,
    			GameText.ちゅっ,
    			GameText.うふふ
    		};
    		string[] tsp = new string[4]
    		{
    			GameText.点3,
    			GameText.点6,
    			GameText.エクス1,
    			GameText.点3
    		};
    		string[] sub = new string[4]
    		{
    			GameText.ヴィオラに頼む,
    			GameText.ヴィオラは微笑む,
    			GameText.キスされる,
    			GameText.ヴィオラに祝福された
    		};
    		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.DownB(ref hc);
    			if (!ViolaTextBubble.TextBlock.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
    			{
    				i++;
    				wi = i;
    				if (i < tsp.Length)
    				{
    					sfc[i]();
    					ViolaTextBubble.Text = tsc[i];
    					ip.Text = tsp[i];
    					ip.SubInfo = sub[i];
    				}
    				else
    				{
    					Med.SwitchMode("Office", DrawBuffer, DrawOffice);
    				}
    			}
    		};
    		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Up(ref hc);
    		};
    		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
    		{
    			ip.Move(ref hc);
    		};
    		mod.Leave = delegate
    		{
    		};
    		mod.Wheel = delegate
    		{
    		};
    		mod.Setting = delegate
    		{
    			ip.UpdateSub2();
    			ip.MaiShow = true;
    			ip.Mai.Feed.Dra = false;
    			ip.Mai2Show = false;
    			ip.SubShow = true;
    			ip.Sub2Show = true;
    			ViolaTextBubble.TextBlock.Feed.Dra = true;
    			Viola.両目_見つめ();
    			Viola.表情_基本0();
    			Viola.Set基本姿勢();
    			i = 0;
    			wi = 0;
    			sfc[i]();
    			ViolaTextBubble.Text = tsc[i];
    			ip.Text = tsp[i];
    			ip.SubInfo = sub[i];
    			GlobalState.GameData.祝福 = GlobalState.GameData.ヴィオラ;
    		};
    		mod.Draw = delegate(FpsCounter FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, 返済イベント描画);
    		};
    		mod.Dispose = delegate
    		{
    		};
    		return mod;
    	}

    	static ModuleRegistry()
    	{
    		TrainingTarget = null;
    		fade_in = false;
    		SDShow = false;
    		save = false;
    		title = false;
            start = false;


            単位返済段階額 = 1666666666uL;
            DemandMax = 8.0;
            DayEndLog = new string[MaxRoomNumber];
    		労働利益 = 0uL;
    		日利益額 = 0uL;
    		日利子額 = 0uL;
    	}

        //buttons added by the other guy
    	public static void NewButtons(ModeEventDispatcher med)
    	{
    		if (GlobalState.SensesButton)
    		{
                double x = 0.6;
                double y = 0.9075;
                if (GlobalState.BigWindow)
                {
                    x = 0.695;
                    y = 0.932;
                }

                dbs.Add("Senses", MyUI.Button(med, DrawBuffer, "Senses", new Vector2D(x, y), delegate
                {
                    //Sounds.操作.Play();
                    GlobalState.ShowSenses = !GlobalState.ShowSenses;
                }));
            }
    		if (GlobalState.JsonButton)
    		{
                {
                    double x = 0.6;
                    double y = 0.9075;
                    if (GlobalState.BigWindow)
                    {
                        x = 0.695;
                        y = 0.932;
                        if (GlobalState.SensesButton)
                        {
                            x = 0.62;
                        }
                    }
                    if (!GlobalState.BigWindow && GlobalState.SensesButton)
                    {
                        x = 0.5;
                    }

                    dbs.Add("SaveJSON", MyUI.Button(med, DrawBuffer, "SaveJSON", new Vector2D(x, y), delegate
                    {
                        //Sounds.操作.Play();
                        SaveData.bs["0"].Dra = false;
                        save = true;
                        SetJSLlv(med);
                        Color HitColor = ColorHelper.Empty;
                        SaveData.Move(ref HitColor);
                        SDShow = true;
                        ip.SubInfoIm = "RCl:" + GameText.戻る;
                    }));
                }

                {
                    double y = 0.9075;
                    double x = 0.5;
                    if (GlobalState.BigWindow)
                    {
                        x = 0.62;
                        y = 0.932;
                        if (GlobalState.SensesButton)
                        {
                            x = 0.545;
                        }
                    }
                    if (!GlobalState.BigWindow && GlobalState.SensesButton)
                    {
                        x = 0.4;
                    }

                    dbs.Add("LoadJSON", MyUI.Button(med, DrawBuffer, "LoadJSON", new Vector2D(x, y), delegate
                    {
                        //Sounds.操作.Play();
                        SaveData.bs["0"].Dra = true;
                        save = false;
                        title = false;
                        SetJSLlv(med);
                        Color HitColor = ColorHelper.Empty;
                        SaveData.Move(ref HitColor);
                        SDShow = true;
                        ip.SubInfoIm = "RCl:" + GameText.戻る;
                    }));
                }
    		}
    	}

        //room buttons or smthn?
    	public static void MoveRoomDown()
    	{
    		if (GlobalState.GameData.TrainingTarget != null)
    		{
    			int num = int.Parse(GlobalState.GameData.TrainingTarget.Number) - 1;
    			if (GlobalState.GameData.Slaves[num + 1] != null)
    			{
    				Unit unit = GlobalState.GameData.Slaves[num];
    				Unit unit2 = GlobalState.GameData.Slaves[num + 1];
    				int[] array = new int[3]
    				{
    					int.Parse(unit.Number),
    					unit.階層位置,
    					unit.RoomNumber
    				};
    				unit.Number = unit2.Number;
    				unit.階層位置 = unit2.階層位置;
    				unit.RoomNumber = unit2.RoomNumber;
    				unit2.Number = array[0].ToString().PadLeft(3, '0');
    				unit2.階層位置 = array[1];
    				unit2.RoomNumber = array[2];
    				GlobalState.GameData.Slaves[num] = unit2;
    				GlobalState.GameData.Slaves[num + 1] = unit;
    				GlobalState.GameData.TrainingTarget = GlobalState.GameData.Slaves[num + 1];
    			}
    		}
    	}

    	public static void MoveRoomUp()
    	{
    		if (GlobalState.GameData.TrainingTarget != null)
    		{
    			int num = int.Parse(GlobalState.GameData.TrainingTarget.Number) - 1;
    			if (num != 0 && GlobalState.GameData.Slaves[num - 1] != null)
    			{
    				Unit unit = GlobalState.GameData.Slaves[num];
    				Unit unit2 = GlobalState.GameData.Slaves[num - 1];
    				int[] array = new int[3]
    				{
    					int.Parse(unit.Number),
    					unit.階層位置,
    					unit.RoomNumber
    				};
    				unit.Number = unit2.Number;
    				unit.階層位置 = unit2.階層位置;
    				unit.RoomNumber = unit2.RoomNumber;
    				unit2.Number = array[0].ToString().PadLeft(3, '0');
    				unit2.階層位置 = array[1];
    				unit2.RoomNumber = array[2];
    				GlobalState.GameData.Slaves[num] = unit2;
    				GlobalState.GameData.Slaves[num - 1] = unit;
    				GlobalState.GameData.TrainingTarget = GlobalState.GameData.Slaves[num - 1];
    			}
    		}
    	}

    	public static void MoveFloorDown()
    	{
    		if (GlobalState.GameData.TrainingTarget == null)
    		{
    			return;
    		}
    		for (int i = 0; i < 15; i++)
    		{
    			int num = int.Parse(GlobalState.GameData.TrainingTarget.Number) - 1;
    			if (GlobalState.GameData.Slaves[num + 1] == null)
    			{
    				break;
    			}
    			Unit unit = GlobalState.GameData.Slaves[num];
    			Unit unit2 = GlobalState.GameData.Slaves[num + 1];
    			int[] array = new int[3]
    			{
    				int.Parse(unit.Number),
    				unit.階層位置,
    				unit.RoomNumber
    			};
    			unit.Number = unit2.Number;
    			unit.階層位置 = unit2.階層位置;
    			unit.RoomNumber = unit2.RoomNumber;
    			unit2.Number = array[0].ToString().PadLeft(3, '0');
    			unit2.階層位置 = array[1];
    			unit2.RoomNumber = array[2];
    			GlobalState.GameData.Slaves[num] = unit2;
    			GlobalState.GameData.Slaves[num + 1] = unit;
    			GlobalState.GameData.TrainingTarget = GlobalState.GameData.Slaves[num + 1];
    		}
    	}

    	public static void MoveFloorUp()
    	{
    		if (GlobalState.GameData.TrainingTarget == null)
    		{
    			return;
    		}
    		for (int i = 0; i < 15; i++)
    		{
    			int num = int.Parse(GlobalState.GameData.TrainingTarget.Number) - 1;
    			if (num == 0 || GlobalState.GameData.Slaves[num - 1] == null)
    			{
    				break;
    			}
    			Unit unit = GlobalState.GameData.Slaves[num];
    			Unit unit2 = GlobalState.GameData.Slaves[num - 1];
    			int[] array = new int[3]
    			{
    				int.Parse(unit.Number),
    				unit.階層位置,
    				unit.RoomNumber
    			};
    			unit.Number = unit2.Number;
    			unit.階層位置 = unit2.階層位置;
    			unit.RoomNumber = unit2.RoomNumber;
    			unit2.Number = array[0].ToString().PadLeft(3, '0');
    			unit2.階層位置 = array[1];
    			unit2.RoomNumber = array[2];
    			GlobalState.GameData.Slaves[num] = unit2;
    			GlobalState.GameData.Slaves[num - 1] = unit;
    			GlobalState.GameData.TrainingTarget = GlobalState.GameData.Slaves[num - 1];
    		}
    	}
    }
}
