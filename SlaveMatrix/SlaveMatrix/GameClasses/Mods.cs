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
        public static But1 Button(ModeEventDispatcher med, RenderArea buffer, string text, Vector2D pos, Action<But> on_click) {

            ShapePartT shapePartT = new ShapePartT();
            shapePartT.Font = new Font("MS Gothic", 0.1f);
            shapePartT.PositionBase = buffer.GetPosition(pos);
            shapePartT.Text = text;
            shapePartT.FontSize = 0.14;
            shapePartT.SizeBase = 0.05;
            shapePartT.OP.AddRange(new Out[1] { Shas.GetSquare() });
            shapePartT.OP.ScalingXY(shapePartT.OP.GetCenter(), 0.87, 0.23);
            shapePartT.Closed = true;
            shapePartT.TextColor = Col.White;
            shapePartT.BrushColor = Color.FromArgb(160, Col.Black);
            shapePartT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
            shapePartT.HitColor = med.GetUniqueColor();
            shapePartT.StringFormat.Alignment = StringAlignment.Center;
            shapePartT.StringFormat.LineAlignment = StringAlignment.Center;

            /*
            ShapePartT shapePartT = new ShapePartT();
            shapePartT.Font = new Font("MS Gothic", 0.1f);
            shapePartT.PositionBase = DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + 0.72));
            shapePartT.Text = GameText.完了;
            shapePartT.FontSize = 0.15;
            shapePartT.SizeBase = 0.05;
            shapePartT.OP.AddRange(new Out[1] { Shas.Get正方形() });
            shapePartT.OP.ScalingY(shapePartT.OP.GetCenter(), 0.47);
            shapePartT.Closed = true;
            shapePartT.TextColor = Col.White;
            shapePartT.BrushColor = Color.FromArgb(160, Col.Black);
            shapePartT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
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
            shapePartT4.OP.AddRange(new Out[1] { Shas.Get正方形() });
            shapePartT4.OP.ScalingXY(shapePartT4.OP.GetCenter(), 0.87, 0.23);
            shapePartT4.Closed = true;
            shapePartT4.TextColor = Col.White; 
            shapePartT4.BrushColor = Color.FromArgb(160, Col.Black);
            shapePartT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
            shapePartT4.HitColor = Med.GetUniqueColor(); // what are you for?
            shapePartT4.StringFormat.Alignment = StringAlignment.Center;
            shapePartT4.StringFormat.LineAlignment = StringAlignment.Center;
            */

            return new But1(shapePartT, on_click);
        }

        //rhombus shaped buttons
        public static But1 Button2(ModeEventDispatcher med, RenderArea buffer, string text, Vector2D pos, Action<But> on_click) {
            ShapePartT shapePartT = new ShapePartT();
            shapePartT.Font = new Font("MS Gothic", 0.1f);
            shapePartT.PositionBase = buffer.GetPosition(pos);
            shapePartT.Text = text;
            shapePartT.FontSize = 0.15;
            shapePartT.SizeBase = 0.05;
            shapePartT.OP.AddRange(new Out[1] { Shas.GetSquare() });
            shapePartT.OP.ScalingY(shapePartT.OP.GetCenter(), 0.47);
            shapePartT.OP.Rotation(shapePartT.OP.GetCenter(), -26.0);
            shapePartT.Closed = true;
            shapePartT.TextColor = Col.White;
            shapePartT.BrushColor = Color.FromArgb(160, Col.Black);
            shapePartT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
            shapePartT.HitColor = med.GetUniqueColor();
            shapePartT.StringFormat.Alignment = StringAlignment.Center;
            shapePartT.StringFormat.LineAlignment = StringAlignment.Center;

            return new But1(shapePartT, on_click);
        }

        public static ListView Select(RenderArea buffer, Vector2D pos, params TA[] acts) {
            return new ListView(
                buffer,
                buffer.GetPosition(pos),
                0.25,
                new Font("MS Gothic", 1f),
                0.09,
                Col.White,
                Col.Empty,
                Col.Empty,
                Col.Empty,
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
                    Col.White,
                    Col.Empty,
                    Col.Empty,
                    Col.Empty
            );
        }
    }

    public static class Mods
    {


        //misc elements
    	private static SubInfo si;
    	private static ListView SaveData;
    	private static InfoPanel ip;
    	private static Buts dbs;
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


    	private static Action<RenderArea, FPS> メインフォーム描画;
    	private static Action<RenderArea, FPS> 調教描画;
    	public static Action<RenderArea, FPS> 撮影描画;
    	private static Action<RenderArea, FPS> 対象描画;
    	private static Action<RenderArea, FPS> DrawBlessing;
    	private static Action<RenderArea, FPS> DrawOffice;
    	private static Action<RenderArea, FPS> DrawDebt;
    	private static Action<RenderArea, FPS> DrawSlaveShop;
    	private static Action<RenderArea, FPS> DrawToolShop;
    	private static Action<RenderArea, FPS> 中継描画;
    	private static Action<RenderArea, FPS> DrawOP0;
    	private static Action<RenderArea, FPS> DrawOP1;
    	private static Action<RenderArea, FPS> 説明描画;
    	private static Action<RenderArea, FPS> 初事務所描画;
    	private static Action<RenderArea, FPS> 返済イベント描画;
    	private static Action<RenderArea, FPS> 日数進行描画;
    	private static Action<RenderArea, FPS> PlayerInformationSliders;
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
    		Sta.LoadConfig();
    		Sta.タイル準備();
    		Sta.Set擬音();
    		Sta.Set喘ぎ();

            //setup buffers
    		drawArea = new RenderArea(Med, Hit: false);
    		DrawBuffer = new RenderArea(Med, Hit: true);

    		BlackBackground = new RenderArea(Med, Hit: true);
    		BlackBackground.Clear(Col.Black);

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
                Col.White,
                Col.Empty, 
                Col.Black,
                Col.Empty,
                Enumerable.Repeat(new TA(new string('A', 15), delegate{}), 10).ToArray()
            );
    		SaveData.SetHitColor(Med);


    		dbs = new Buts();



    		double y = 0.9075;
    		if (Sta.BigWindow)
    		{
    			y = 0.932;
    		}
            
            double x = 0.699;
            if (Sta.BigWindow)
            {
                x = 0.77;
            }


            dbs.Add("プレイヤー", MyUI.Button(Med, DrawBuffer, "Player", new Vector2D(-0.001, y), delegate
    		{
    			if (Sta.GameData.所持金 < 10000000)
    			{
    				ip.SubInfoIm = GameText.所持金が足りません;
    			}
    			else
    			{
                    //TODO fix?
                    //Sounds.精算.Play();
    				Sta.GameData.所持金 -= 10000000uL;
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
    				Color HitColor4 = Col.Empty;
    				dbs.Move(ref HitColor4);
    				ip.選択肢表示 = false;
    			};
    			ip.選択nAct = delegate
    			{
                    //TODO fix?
                    //Sounds.操作.Play();
    				ip.TextIm = tb;
    				ip.MaiShow = sb;
    				Color HitColor3 = Col.Empty;
    				dbs.Move(ref HitColor3);
    				ip.選択肢表示 = false;
    			};
    			ip.選択肢表示 = true;
    		}));


            x = 0.895;
            if (Sta.BigWindow)
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
    			Color HitColor2 = Col.Empty;
    			SaveData.Move(ref HitColor2);
    			SDShow = true;
    			ip.SubInfoIm = "RCl:" + GameText.戻る;
    		}));


            x = 0.797;
            if (Sta.BigWindow)
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
    			Color HitColor = Col.Empty;
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
                Col.White, 
                Col.Black, 
                Color.FromArgb(160, Col.Black), 
                19.0, 
                Dis: false, 
                Col.White, 
                delegate{}
            );
    		ViolaTextBubble.SetHitColor(Med);


    		SlaveTextBubble = new TextBubble(
                DrawBuffer, 
                右: false, 
                new Font("MS Gothic", 1f), 
                0.08, 
                " ", 
                Col.White, 
                Col.Black, 
                Color.FromArgb(160, Col.Black), 
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
                new Vector2D(ip.MaiB.Position.X, 0.026), 
                0.1, 
                1.5, 
                new Font("MS Gothic", 1f), 
                0.085, 
                "No Slave", 
                Col.White, 
                Col.Black, 
                ip.MaiB.BrushColor, 
                Col.Black
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
        static MotV mv = new MotV(0.0, 1.0)
        {
            BaseSpeed = 2.0
        };
        static double v = 0.0;

        private static void SwitchMode(ModeEventDispatcher Med, RenderArea Are, FPS FPS, Action<RenderArea, FPS> 描画)
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

    	public static void SwitchMode(this ModeEventDispatcher Med, string Mode, RenderArea Are, Action<RenderArea, FPS> 描画)
    	{
    		Med.Mode = Mode;
    		描画(drawArea, Med.FPSF);
    		Med.Sce.DrawStart(Are);
    		Med.Sce.DrawEnd(drawArea);
    		fade_in = true;
    	}

        public static void flash(this ModeEventDispatcher Med)
        {
            調教描画(drawArea, Med.FPSF);
            Color col = Color.FromArgb(128, Color.White);
            Med.Sce.ClearStart(ref col);
            Med.Sce.DrawEnd(drawArea);
            fade_in = true;
        }



        public static void SetDemandMaximum()
    	{
    		if (Sta.GameData.RepaymentStage == 0)
    		{
    			DemandMax = 88.0;
    		}
    		else if (Sta.GameData.RepaymentStage == 1)
    		{
    			DemandMax = 99.0;
    		}
    		else if (Sta.GameData.RepaymentStage == 2)
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

    	private static IEnumerable<TA> sllv(ModeEventDispatcher Med)
    	{
    		int j = 0;
    		string[] array = Sta.SDPaths();
    		foreach (string text in array)
    		{
    			string path = text;
    			int i = j;
    			bool f = path == null;
    			yield return new TA(f ? (i + ": No data") : Path.GetFileNameWithoutExtension(path).Replace("：", ":").Replace("_", "/"), delegate
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
    		string s = Path.Combine(Sta.SavePath, "0： ");
    		foreach (string item in from e in Directory.EnumerateFiles(Sta.SavePath)
    			where e.StartsWith(s)
    			select e)
            {
                System.IO.File.Delete(item);
            }
    		Sta.GDSave(0);
    	}

    	private static void Save(string Path, int i, ModeEventDispatcher Med)
    	{
    		ip.SubInfoIm = GameText.セーブ中です + "\r\n" + GameText.しばらくお待ちください;

    		if (Path != null)
    		{
                System.IO.File.Delete(Path);
    		}
    		Sta.GDSave(i);
    		SetSLlv(Med);
    		SDShow = false;
    		ip.SubInfoIm = i + ": " + Sta.GameData.GetSaveDateString() + "\r\n" + GameText.セーブしました;
    		//Med.InvokeL(Sounds.完了.Play);
    	}

    	private static void Load(string Path, int i, ModeEventDispatcher Med)
    	{
    		ip.SubInfoIm = GameText.ロード中です + "\r\n" + GameText.しばらくお待ちください;
		
    		Sta.GameData = Path.LoadExMod<GameState>();
    		Character d = Viola;
    		Viola = new Character(Med, DrawBuffer, Sta.GameData.ヴィオラ.ChaD);
    		Viola.Set衣装(Sta.GameData.ヴィオラ.着衣);
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
    			ip.SubInfoIm = i + ": " + Sta.GameData.GetSaveDateString() + "\r\n" + GameText.ロードしました;
    		}
    		SetDemandMaximum();
    		if (Sta.GameData.Slaves.Length < MaxRoomNumber)
    		{
    			Unit[] array = new Unit[MaxRoomNumber];
    			Array.Copy(Sta.GameData.Slaves, array, Sta.GameData.Slaves.Length);
    			Sta.GameData.Slaves = array;
    		}
    		//Med.InvokeL(Sounds.完了.Play);
    		
    	}

        public static void SetJSLlv(ModeEventDispatcher med)
        {
            SaveData.Acts = jsllv(med);
        }

        private static IEnumerable<TA> jsllv(ModeEventDispatcher med)
        {
            int k = 0;
            string[] array = Sta.JSDPaths();
            foreach (string text in array)
            {
                string path = text;
                int i = k;
                bool f = path == null;
                yield return new TA(f ? (i + ": No data") : Path.GetFileNameWithoutExtension(path).Replace("：", ":").Replace("_", "/"), delegate
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
            Sta.GDSaveJson(i);
            SetJSLlv(med);
            SDShow = false;
            ip.SubInfoIm = i + ": " + Sta.GameData.GetSaveDateString() + "\r\n" + GameText.セーブしました;
            //Sounds.完了.Play();
        }
        private static void JsonLoad(string Path, int i, ModeEventDispatcher med)
        {
            ip.SubInfoIm = GameText.ロード中です + "\r\n" + GameText.しばらくお待ちください;

            Sta.DontScar = true;
            if (Sta.TranslateJson)
            {
                string text = Sta.CurrentDirectory + "temp.json";
                string contents = Sta.Translate(Path, 1);
                File.WriteAllText(text, contents);
                Sta.GameData = Ser.UnJson<GameState>(text);
                System.IO.File.Delete(text);
            }
            else
            {
                Sta.GameData = Ser.UnJson<GameState>(Path);
            }
            Sta.DontScar = false;
            Character d = Viola;
            Viola = new Character(med, DrawBuffer, Sta.GameData.ヴィオラ.ChaD);
            Viola.Set衣装(Sta.GameData.ヴィオラ.着衣);
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
                ip.SubInfoIm = i + ": " + Sta.GameData.GetSaveDateString() + "\r\n" + GameText.ロードしました;
            }
            SetDemandMaximum();
            if (Sta.GameData.Slaves.Length < MaxRoomNumber)
            {
                Unit[] array = new Unit[MaxRoomNumber];
                Array.Copy(Sta.GameData.Slaves, array, Sta.GameData.Slaves.Length);
                Sta.GameData.Slaves = array;
            }
            Sta.GameData.Gen = new Generator[9];
            Sta.GameData.GenInstance();
            //Sounds.完了.Play();
        }

        private static void Initialize()
    	{
            Sta.GameData.Refresh = false;
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
            npl.Text = GameText.収容番号 + u.Number + "\r\n" + (Sta.AlwaysUseName ? u.Name : (u.Trained ? u.Name : u.Race));
        }

        public static void EndDay()
    	{
    		Player.RecoverPlayerStamina();
    		Sta.GameData.日借金額 = 0uL;
    		労働利益 = 0uL;
    		日利益額 = 0uL;
    		日利子額 = Sta.GameData.利子額;
    		DayEndLog = new string[MaxRoomNumber];
    		int num = 0;
    		Unit[] Slaves = Sta.GameData.Slaves;
    		foreach (Unit unit in Slaves)
    		{
    			if (unit != null)
    			{
    				unit.RecoverStamina();
    				unit.RecoverStamina();
    				unit.ChaD.現陰毛 = (unit.ChaD.現陰毛 + 0.05).Clamp(0.0, 1.0);
    				int num2 = ((unit.妊娠進行期間 <= 0) ? 1 : unit.妊娠進行期間);
    				bool flag = Sta.GameData.日数 % (ulong)(num2 * 2) == 0;
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
    						if (unchecked(Sta.GameData.日数 % (ulong)num2) == 0L)
    						{
    							if (unit.妊娠状態変数 == 4)
    							{
    								unit.体力消費();
    								unit.体力消費();
    								unit.体力消費();
    								DayLog(GameText.収容番号 + unit.Number + "/" + unit.Name + GameText.が出産しました, num);
    								if (Sta.GameData.Is地下室一杯())
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
    									Sta.GameData.Add地下室(unit.Child);
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
    						if (Sta.GameData.Is地下室一杯())
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
    							Sta.GameData.Add地下室(unit.DeepCopy().増殖時Reset());
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
    			Sta.GameData.新日 = true;
    		}
    	}
    	public static bool PassTime(ModeEventDispatcher Med)
    	{
    		bool flag = Sta.GameData.時間帯 == GameText.夜;
            Player.RecoverPlayerStamina();

            foreach (Unit u in Sta.GameData.Slaves)
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
    			Sta.GameData.Refresh = false;

                EndDay();
                AutoSave();

                Med.SwitchMode("StartOfDay", DrawBuffer, 日数進行描画);
    		}
    		else
    		{
    			Sta.GameData.時間進行();
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
    		if (Sta.GameData.TrainingTarget.妊娠状態変数 > -1)
    		{
    			TrainingTarget.Body.ボテ腹i = Sta.GameData.TrainingTarget.妊娠状態変数;
    			TrainingTarget.Body.ボテ腹_表示 = true;
    			if (!TrainingTarget.Body.Is獣)
    			{
    				TrainingTarget.Body.ボテ腹_人.ハイライト表示 = Sta.GameData.TrainingTarget.妊娠状態変数 > 2;
    			}
    		}
    		else
    		{
    			TrainingTarget.Body.ボテ腹i = 0;
    			TrainingTarget.Body.ボテ腹_表示 = false;
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
    		if (Sta.GameData.TrainingTarget.Trained)
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
    		if (Sta.GameData.TrainingTarget.ChaD.胸施術)
    		{
    			TrainingTarget.Body.胸施術();
    		}
    		if (Sta.GameData.TrainingTarget.ChaD.股施術)
    		{
    			TrainingTarget.Body.股施術();
    		}
    		if (Sta.GameData.TrainingTarget.ChaD.タトゥ)
    		{
    			TrainingTarget.Body.タトゥ();
    		}
    		if (Sta.GameData.TrainingTarget.着衣 != null)
    		{
    			TrainingTarget.Set衣装(Sta.GameData.TrainingTarget.着衣);
    		}
    		TrainingTarget.Body.Join();
    		TrainingTarget.Body.Update();
    	}

    	public static void SetTrainingTarget(ModeEventDispatcher Med, Unit u)
    	{
    		Sta.GameData.TrainingTarget = u;
    		if (TrainingTarget != null)
    		{
    			TrainingTarget.Dispose();
    		}
    		TrainingTarget = new Character(Med, DrawBuffer, Sta.GameData.TrainingTarget.ChaD);
    		SlaveTextBubble.接続(TrainingTarget.Body.頭.口_接続点);
    		Setnpl(u);
    		double d = ((u.Trained && Sta.MoveInsectMask) ? 1.0 : 0.0);
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
    		if (Sta.GameData.TrainingTarget.Trained)
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
    		if (dbs["プレイヤー"].PartGroup.Values.First().ToPar().HitColor == hc)
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
    		MotV mv = new MotV(0.0, 1.0){BaseSpeed = 0.5};

    		double v = 0.0;
    		bool fadeIn = true;
    		bool fadeOut = false;

            Lab label = MyUI.Label(Med, DrawBuffer, "Auto Eden Presents.", new Vector2D(0.4, 0.4));

            return new Module()
    		{
    			Setting = delegate
    			{
    				DrawBuffer.Clear(Col.Black);
    				DrawBuffer.Draw(label.ShapePartT);
    				Med.Sce.DrawStart(BlackBackground);
    				Med.Sce.DrawEnd(DrawBuffer);
    				v = 0.0;
    				fadeIn = true;
    				fadeOut = false;
    				mv.ResetValue();
    			},

    			Down = delegate
    			{
    				Med.Mode = "Title";
    			},

    			Draw = delegate (FPS FPS)
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
    							Med.Sce.DrawStart(DrawBuffer);
    							Med.Sce.DrawEnd(BlackBackground);
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
    		MotV mv = new MotV(0.0, 1.0)
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
    			new TA("Start", delegate
    			{
    				////Sounds.操作.Play();
    				Sta.GameData.SetDefault();

    				Viola?.Dispose();
    				TrainingTarget?.Dispose();
    				TrainingTarget = null;

    				Initialize();
    				start = true;
    				SetDemandMaximum();
    				Med.SwitchMode("PlayerInformation", DrawBuffer, PlayerInformationSliders);
    			}),
    			new TA("Load", delegate
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
                    DrawBuffer.Clear(Col.Black);
                    DrawBuffer.Draw(label.ShapePartT);
                    Med.Sce.DrawStart(BlackBackground);
                    Med.Sce.DrawEnd(DrawBuffer);
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
    			Draw = delegate (FPS FPS)
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
    		Buts bs = new Buts();

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
    			unit = ((Sta.GameData.TrainingTarget == null) ? (from e in Sta.GameData.Slaves
    				where e != null
    				orderby RNG.XS.Next()
    				select e).First() : (from e in Sta.GameData.Slaves
    				where e != null && e != Sta.GameData.TrainingTarget
    				orderby RNG.XS.Next()
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

            メインフォーム描画 = delegate (RenderArea a, FPS FPS)
            {
                Med.HitGraphics.Clear(Col.Transparent);
                if (a.HitGraphics != null)
                {
                    a.HitGraphics.Clear(Col.Transparent);
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
                            if (bs["ボタン7"].PartGroup.Values.First().ToPar().HitColor == hc)
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
                        Player.UI.ステート描画 = Sta.GameData.心眼;
                        if (TrainingTarget == null && Sta.GameData.TrainingTarget != null)
                        {
                            SetTrainingTarget(Med, Sta.GameData.TrainingTarget);
                        }
                        bs["ボタン2"].Dra = Sta.GameData.TrainingTarget != null;
                        bs["ボタン3"].Dra = !Sta.GameData.初事務所フラグ && Sta.GameData.Slaves.Count((Unit e) => e != null) > 0;
                        bs["ボタン4"].Dra = !Sta.GameData.初事務所フラグ;
                        bs["ボタン5"].Dra = !Sta.GameData.初事務所フラグ;
                        bs["ボタン6"].Dra = !Sta.GameData.初事務所フラグ;
                        bs["ボタン7"].Dra = !Sta.GameData.初事務所フラグ && Sta.GameData.Slaves.Count((Unit e) => e != null) > 0;
                        si.Set(bre: false);
                        Color HitColor = Col.Empty;
                        ip.Up(ref HitColor);
                        //Sounds.OPBGM.Stop();
                        //Sounds.日常BGM.Play();
                        npl.ShapePartT.PositionBase = new Vector2D(Player.UI.ステート.Position.X, 0.026);
                    }
                },
                Draw = delegate (FPS FPS)
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

            調教描画 = delegate (RenderArea a, FPS FPS)
            {
                Player.UI.Mots.Drive(FPS);
                Med.HitGraphics.Clear(Col.Transparent);
                if (a.HitGraphics != null)
                {
                    a.HitGraphics.Clear(Col.Transparent);
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
                            Action<Tex> o_done = SlaveTextBubble.Tex.Done;
                            SlaveTextBubble.Tex.Done = delegate (Tex tex)
                            {
                                o_done(tex);
                                TrainingTarget.顔面展開.Start();
                            };
                        }
                    }
                    調教済みチェック = false;
                }
            };
            撮影描画 = delegate (RenderArea a, FPS FPS)
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
                    Player.UI.ディルCM.Show = Sta.GameData.PurchasedTools[0];
                    Player.UI.コモンCM.Show = Sta.GameData.PurchasedTools[1];
                    Player.UI.ドリルCM.Show = Sta.GameData.PurchasedTools[2];
                    Player.UI.デンマCM.Show = Sta.GameData.PurchasedTools[3];
                    Player.UI.アナルCM.Show = Sta.GameData.PurchasedTools[4];
                    Player.UI.調教鞭CM.Show = Sta.GameData.PurchasedTools[5];
                    Player.UI.羽根箒CM.Show = Sta.GameData.PurchasedTools[6];
                    Player.UI.T剃刀CM.Show = Sta.GameData.PurchasedTools[7];
                    Player.UI.キャップ1CM.Show = Sta.GameData.PurchasedTools[8];
                    Player.UI.キャップ2CM.Show = Sta.GameData.PurchasedTools[8];
                    Player.UI.キャップ3CM.Show = Sta.GameData.PurchasedTools[8];
                    Player.UI.ロータCM.Show = Sta.GameData.PurchasedTools[9];
                    Player.UI.パールCM.Show = Sta.GameData.PurchasedTools[10];
                    Player.UI.目隠帯.Dra = Sta.GameData.PurchasedTools[11];
                    Player.UI.玉口枷.Dra = Sta.GameData.PurchasedTools[12];
                    Player.UI.撮影.Dra = Sta.GameData.PurchasedTools[13];
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
                    TrainingTargetTrained = Sta.GameData.TrainingTarget.Trained;
                    if (調教完了 = Sta.GameData.TrainingTarget.IsTrained())
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
                Draw = delegate (FPS FPS)
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
    		中継描画 = delegate(RenderArea a, FPS FPS)
    		{
    			Med.HitGraphics.Clear(Col.Transparent);
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(Col.Transparent);
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
                    Player.UI.SetTarget(Sta.GameData.TrainingTarget, TrainingTarget);
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
                Draw = delegate (FPS FPS)
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
                        b1 = Sta.GameData.TrainingTarget.Pregnant && Sta.GameData.TrainingTarget.非妊娠;
                        b2 = !TrainingTargetTrained && Sta.GameData.TrainingTarget.Trained;
                        b3 = Sta.GameData.TrainingTarget.Trained && Sta.GameData.祝福 == null;
                        Result3 = !(b1 || b2 || b3);
                    }
                    else if (!Result3)
                    {
                        ip.TextIm = "";
                        if (b1)
                        {
                            InfoPanel 情報パネル2 = ip;
                            情報パネル2.TextIm = 情報パネル2.TextIm + GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "/" + Sta.GameData.TrainingTarget.Name + GameText.が妊娠しました + ((Sta.GameData.TrainingTarget.Laboror || Sta.GameData.TrainingTarget.Prostitute) ? ("\r\n" + GameText.労働が解除されます) : "") + "\r\n";
                            Sta.GameData.TrainingTarget.非妊娠 = false;
                        }
                        if (b2)
                        {
                            InfoPanel 情報パネル2 = ip;
                            情報パネル2.TextIm = 情報パネル2.TextIm + GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "/" + Sta.GameData.TrainingTarget.Name + GameText.の調教が完了しました + "\r\n";
                        }
                        if (b3)
                        {
                            Sta.GameData.祝福 = Sta.GameData.TrainingTarget;
                            InfoPanel 情報パネル2 = ip;
                            情報パネル2.TextIm = 情報パネル2.TextIm + GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "/" + Sta.GameData.TrainingTarget.Name + GameText.から祝福を受けました;
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
                    Color HitColor = Col.Empty;
                    Player.UI.調教終了.Up(ref HitColor);
                    Player.Result1();
                    if (Player.UI.強制拘束)
                    {
                        Sta.GameData.拘束具 = Player.UI.拘束bu;
                    }
                    Sta.GameData.TrainingTarget.発情フラグ = Player.UI.発情bu;
                    Player.調教終了時();
                    TrainingTarget.Climax.End();
                    TrainingTarget.BodySway.End();


                    TrainingTarget.放尿強制終了();



                    Player.絶頂終了処理_();
                    Player.射精終了処理_();
                    TrainingTarget.Body.VaginalCumDrip.精液濃度 = 0.0;
                    TrainingTarget.Body.断面.精液濃度 = 0.0;
                    TrainingTarget.Body.スタンプClear();
                    TrainingTarget.Body.Waist.位置B = Med.Base.GetPosition(new Vector2D(0.5, 0.5));
                    TrainingTarget.Body.汗染み濃度 = 0.0;
                    TrainingTarget.Body.SplashIntencity = 0.0;
                    TrainingTarget.Body.SquirtStainIntensity = 0.0;
                    TrainingTarget.Body.UrineStainIntensity = 0.0;
                    if (!TrainingTarget.Body.Is粘)
                    {
                        TrainingTarget.Body.断面_表示 = false;
                    }
                    TrainingTarget.EyeTracking.End();
                    TrainingTarget.MouthCumDrip.End();
                    TrainingTarget.GenitalCumDrip.End();
                    TrainingTarget.AnalCumDrip.End();
                    TrainingTarget.ThreadCumDrip.End();
                    TrainingTarget.Body.SetWaist();
                    if (Sta.GameData.TrainingTarget.Trained)
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
                    TrainingTarget.舌_無し();
                    TrainingTarget.Set衣装(Sta.GameData.TrainingTarget.着衣);
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
                    Sta.GameData.目隠帯 = false;
                    Sta.GameData.玉口枷 = false;
                    Sta.GameData.拘束具 = false;
                    Sta.GameData.断面 = false;
                },
                Draw = delegate (FPS FPS)
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
    			Buts bs = new Buts();
    			Swi 保守sw = new Swi(Color.DarkRed);
    			Swi 一般sw = new Swi(Color.DarkRed);
    			Swi 娼婦sw = new Swi(Color.DarkRed);
    			int i = 0;
    			int f = 0;

                ListView lv = MyUI.Select(DrawBuffer, new Vector2D(0.01, 0.08),
                    Enumerable.Repeat(new TA("No Slave".PadLeft(15, ' '), delegate { }), 15).ToArray()
                );

    			Color lv初期縁色 = Col.Black;
    			Action lv縁色初期化 = delegate
    			{
    				foreach (But item in lv.bs.EnumBut)
    				{
    					item.PartGroup.Values.First().ToParT().PenColor = lv初期縁色;
    				}
    			};
    			Action<Unit> SetUI = delegate(Unit u)
    			{
    				if (u != null)
    				{
    					ip.TextIm = u.GetStatus();
    					bs["MoveRoomDown"].Dra = Sta.MoveButton;
    					bs["MoveRoomUp"].Dra = Sta.MoveButton;
    					bs["MoveFloorDown"].Dra = Sta.MoveButton;
    					bs["MoveFloorUp"].Dra = Sta.MoveButton;
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
    					bs["胸施術"].Dra = Sta.GameData.施術 && !u.ChaD.胸施術 && u.ChaD.Is胸甲殻();
    					bs["股施術"].Dra = Sta.GameData.施術 && !u.ChaD.股施術 && u.ChaD.Is股防御();
    					bs["淫紋"].Dra = Sta.GameData.淫紋 && u.Trained && !u.ChaD.タトゥ && !u.ChaD.Isタトゥ();
    					bs["衣装"].Dra = Sta.GameData.衣装 && u.Trained;
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
    				lv.Acts = Enumerable.Repeat(new TA("", delegate
    				{
    				}), 15).Select(delegate(TA e)
    				{
    					Unit u = Sta.GameData.Slaves[n + i];
    					if (u == null)
    					{
    						e.Text = "No Slave";
    						e.act = delegate(But b)
    						{
    							lv縁色初期化();
    							b.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    							Sta.GameData.TrainingTarget = null;
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
    						e.act = delegate(But b)
    						{
    							lv縁色初期化();
    							b.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    							Sta.GameData.TrainingTarget = u;
    							bs["子"].Action(bs["子"]);
    							if (ip.Mai2Show)
    							{
    								if (Sta.GameData.TrainingTarget == null)
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

                Color bs初期縁色 = Col.Black;
                Action bs縁色初期化 = delegate
                {
                    foreach (But item2 in bs.EnumBut.Skip(1).Take(3))
                    {
                        item2.PartGroup.Values.First().ToParT().PenColor = bs初期縁色;
                    }
                };
                Color f初期縁色 = Col.Black;
                Action f縁色初期化 = delegate
                {
                    foreach (But item3 in bs.EnumBut.Skip(10))
                    {
                        item3.PartGroup.Values.First().ToParT().PenColor = f初期縁色;
                    }
                };
                Action<But, int> 階層選択 = delegate (But b, int o)
                {
                    f縁色初期化();
                    b.PartGroup.Values.First().ToParT().PenColor = Color.Red;
                    set(o);
                };
                Action 部屋選択 = delegate
                {
                    lv縁色初期化();
                    if (Sta.GameData.TrainingTarget != null && f == Sta.GameData.TrainingTarget.階層位置 * 15)
                    {
                        lv.bs[Sta.GameData.TrainingTarget.RoomNumber.ToString()].PartGroup.Values.First().ToParT().PenColor = Color.Red;
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
                                if (bs["胸施術"].PartGroup.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.胸の甲殻を切除しました) && !(ip.SubInfoIm == GameText.所持金が足りません))
                                {
                                    ip.SubInfoIm = GameText.胸の甲殻を切除します + "(-" + 胸施術価格.ToString("#,0") + ")";
                                }
                                else if (ip.SubInfoIm == GameText.胸の甲殻を切除します + "(-" + 胸施術価格.ToString("#,0") + ")")
                                {
                                    si.Set(bre: false);
                                }
                                if (TrainingTarget != null)
                                {
                                    if (bs["股施術"].PartGroup.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.股の + (TrainingTarget.Body.Is蛇 ? GameText.鱗 : GameText.甲殻) + GameText.を切除しました) && !(ip.SubInfoIm == GameText.所持金が足りません))
                                    {
                                        ip.SubInfoIm = GameText.股の + (TrainingTarget.Body.Is蛇 ? GameText.鱗 : GameText.甲殻) + GameText.を切除します + "(-" + 股施術価格.ToString("#,0") + ")";
                                    }
                                    else if (ip.SubInfoIm == GameText.股の + (TrainingTarget.Body.Is蛇 ? GameText.鱗 : GameText.甲殻) + GameText.を切除します + "(-" + 股施術価格.ToString("#,0") + ")")
                                    {
                                        si.Set(bre: false);
                                    }
                                }
                                if (bs["淫紋"].PartGroup.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.淫紋を刻みました) && !(ip.SubInfoIm == GameText.所持金が足りません))
                                {
                                    ip.SubInfoIm = GameText.淫紋を刻みます + "(-" + 淫紋価格.ToString("#,0") + ")";
                                }
                                else if (ip.SubInfoIm == GameText.淫紋を刻みます + "(-" + 淫紋価格.ToString("#,0") + ")")
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["衣装"].PartGroup.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.衣装を変更しました) && !(ip.SubInfoIm == GameText.所持金が足りません))
                                {
                                    ip.SubInfoIm = GameText.衣装を変更します + "(-" + 衣装変更価格.ToString("#,0") + ")";
                                }
                                else if (ip.SubInfoIm == GameText.衣装を変更します + "(-" + 衣装変更価格.ToString("#,0") + ")")
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["保守"].PartGroup.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.奴隷を保守対象に設定しました) && !(ip.SubInfoIm == GameText.奴隷の保守設定を解除しました))
                                {
                                    ip.SubInfoIm = GameText.奴隷の保守設定を切り替えます;
                                }
                                else if (ip.SubInfoIm == GameText.奴隷の保守設定を切り替えます)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["一般労働"].PartGroup.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.奴隷を一般労働に設定しました) && !(ip.SubInfoIm == GameText.奴隷の一般労働を解除しました))
                                {
                                    ip.SubInfoIm = GameText.奴隷の一般労働設定を切り替えます;
                                }
                                else if (ip.SubInfoIm == GameText.奴隷の一般労働設定を切り替えます)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["娼婦労働"].PartGroup.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.奴隷を娼婦労働に設定しました) && !(ip.SubInfoIm == GameText.奴隷の娼婦労働を解除しました))
                                {
                                    ip.SubInfoIm = GameText.奴隷の娼婦労働設定を切り替えます;
                                }
                                else if (ip.SubInfoIm == GameText.奴隷の娼婦労働設定を切り替えます)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["売却"].PartGroup.Values.First().ToPar().HitColor == hc)
                                {
                                    ip.SubInfoIm = GameText.奴隷を売却します;
                                }
                                else if (ip.SubInfoIm == GameText.奴隷を売却します)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["全一般"].PartGroup.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.労働可能な全ての奴隷に一般労働を設定しました))
                                {
                                    ip.SubInfoIm = GameText.労働可能な全ての奴隷を働かせます;
                                }
                                else if (ip.SubInfoIm == GameText.労働可能な全ての奴隷を働かせます)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["全娼婦"].PartGroup.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.労働可能な全ての奴隷に娼婦労働を設定しました))
                                {
                                    ip.SubInfoIm = GameText.労働可能な全ての奴隷を娼婦として働かせます;
                                }
                                else if (ip.SubInfoIm == GameText.労働可能な全ての奴隷を娼婦として働かせます)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["全解除"].PartGroup.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.労働中の全ての奴隷の労働を解除しました))
                                {
                                    ip.SubInfoIm = GameText.全ての奴隷の労働を解除します;
                                }
                                else if (ip.SubInfoIm == GameText.全ての奴隷の労働を解除します)
                                {
                                    si.Set(bre: false);
                                }
                                if (bs["全売却"].PartGroup.Values.First().ToPar().HitColor == hc && !ip.SubInfoIm.StartsWith(GameText.保守以外の全ての奴隷を売却しました) && !(ip.SubInfoIm == GameText.全売却をキャンセルしました))
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
                        using (IEnumerator<But> enumerator2 = bs.EnumBut.Skip(12).GetEnumerator())
                        {
                            while (enumerator2.MoveNext() && !(enumerator2.Current.PartGroup.Values.First().ToParT().PenColor == Color.Red))
                            {
                                num2++;
                            }
                        }
                        int num3 = 0;
                        using (IEnumerator<But> enumerator2 = lv.bs.EnumBut.GetEnumerator())
                        {
                            while (enumerator2.MoveNext() && !(enumerator2.Current.PartGroup.Values.First().ToParT().PenColor == Color.Red))
                            {
                                num3++;
                            }
                        }
                        int num4 = num3 - dt.Sign();
                        d = false;
                        if (num4 < 0 && num2 > 0)
                        {
                            But but3 = bs["ボタン" + num2];
                            but3.Action(but3);
                            num4 = 14;
                        }
                        else if (num4 > 14 && num2 < Sta.GameData.フロア数 - 1)
                        {
                            But but4 = bs["ボタン" + (num2 + 2)];
                            but4.Action(but4);
                            num4 = 0;
                        }
                        d = true;
                        But but5 = lv.bs[num4.Limit(0, 15).ToString()];
                        but5.Action(but5);
                        if (ip.Mai2Show)
                        {
                            if (Sta.GameData.TrainingTarget == null)
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
                            for (int k = 1; k <= Sta.GameData.フロア数; k++)
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
                            if (Sta.GameData.TrainingTarget != null)
                            {
                                But but = bs["ボタン" + (Sta.GameData.TrainingTarget.階層位置 + 1)];
                                but.Action(but);
                                lv縁色初期化();
                                lv.bs[Sta.GameData.TrainingTarget.RoomNumber.ToString()].PartGroup.Values.First().ToParT().PenColor = Color.Red;
                                bs["子"].Action(bs["子"]);
                            }
                            else
                            {
                                ip.TextIm = GameText.対象が設定されていません;
                                階層選択(bs["ボタン" + (f / 15 + 1)], f);
                                SetUI(null);
                                int num = 0;
                                using (IEnumerator<But> enumerator = lv.bs.EnumBut.GetEnumerator())
                                {
                                    while (enumerator.MoveNext() && !(enumerator.Current.PartGroup.Values.First().ToParT().PenColor == Color.Red))
                                    {
                                        num++;
                                    }
                                }
                                But but2 = lv.bs[num.Limit(0, 15).ToString()];
                                but2.Action(but2);
                            }
                            d = true;
                            si.Set(bre: false);
                            if (Sta.BigWindow)
                            {
                                npl.ShapePartT.PositionBase = new Vector2D(0.095, 0.035);
                            }
                            else
                            {
                                npl.ShapePartT.PositionBase = new Vector2D(ip.MaiB.Position.X, 0.026);
                            }
                        }
                    },
                    Draw = delegate (FPS FPS)
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
                    if (Sta.GameData.TrainingTarget != null && bs["子"].PartGroup.Values.First().ToParT().PenColor != Color.Red)
                    {
                        SetTrainingTarget(Med, Sta.GameData.TrainingTarget);
                        SetUI(Sta.GameData.TrainingTarget);
                    }
                    Med.Mode = "メインフォーム";
                }));

                //TODO colors?
                //shapePartT2.PenColor = Color.Red;
                bs.Add("子", MyUI.Button2(Med, DrawBuffer, GameText.子, new Vector2D(0.85, 0.1), delegate (But b)
    			{
    				if (d)
    				{
    					////Sounds.操作.Play();
    				}
    				bs縁色初期化();
    				b.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    				if (Sta.GameData.TrainingTarget != null)
    				{
    					if (TrainingTarget == null || TrainingTarget.CharacterData != Sta.GameData.TrainingTarget.ChaD)
    					{
    						SetTrainingTarget(Med, Sta.GameData.TrainingTarget);
    					}
    					SetUI(Sta.GameData.TrainingTarget);
    					bs["胸施術"].Dra = Sta.GameData.施術 && !Sta.GameData.TrainingTarget.ChaD.胸施術 && Sta.GameData.TrainingTarget.ChaD.Is胸甲殻();
    					bs["股施術"].Dra = Sta.GameData.施術 && !Sta.GameData.TrainingTarget.ChaD.股施術 && Sta.GameData.TrainingTarget.ChaD.Is股防御();
    					bs["淫紋"].Dra = Sta.GameData.淫紋 && Sta.GameData.TrainingTarget.Trained && !Sta.GameData.TrainingTarget.ChaD.タトゥ && !Sta.GameData.TrainingTarget.ChaD.Isタトゥ();
    					bs["衣装"].Dra = Sta.GameData.衣装 && Sta.GameData.TrainingTarget.Trained;
    				}
    			}));

    			bs.Add("親形質1", MyUI.Button2(Med, DrawBuffer, GameText.親形質1, new Vector2D(0.85, 0.18), delegate(But b)
    			{
    				////Sounds.操作.Play();
    				bs縁色初期化();
    				b.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    				if (Sta.GameData.TrainingTarget != null)
    				{
    					if (TrainingTarget != null)
    					{
    						TrainingTarget.Dispose();
    					}
    					TrainingTarget = new Character(Med, DrawBuffer, Sta.GameData.TrainingTarget.Mother.ChaD);
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
    					if (Sta.GameData.TrainingTarget.Mother.Race == GameText.ヴィオランテ)
    					{
    						TrainingTarget.両瞼_卑();
    						TrainingTarget.両瞼_半1();
    					}
    					TrainingTarget.口_閉笑();
    					TrainingTarget.Set基本姿勢();
    					npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + GameText.親形質1;
    					ip.TextIm = Sta.GameData.TrainingTarget.Mother.GetStatus();
    					bs["胸施術"].Dra = false;
    					bs["股施術"].Dra = false;
    					bs["淫紋"].Dra = false;
    					bs["衣装"].Dra = false;
    				}
    			}));

    			bs.Add("親形質2", MyUI.Button2(Med, DrawBuffer, GameText.親形質2, new Vector2D(0.85, 0.26), delegate(But b)
    			{
    				////Sounds.操作.Play();
    				bs縁色初期化();
    				b.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    				if (Sta.GameData.TrainingTarget != null)
    				{
    					if (TrainingTarget != null)
    					{
    						TrainingTarget.Dispose();
    					}
    					TrainingTarget = new Character(Med, DrawBuffer, Sta.GameData.TrainingTarget.Father.ChaD);
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
    					if (Sta.GameData.TrainingTarget.Father.Race == GameText.ヴィオランテ)
    					{
    						TrainingTarget.両瞼_卑();
    						TrainingTarget.両瞼_半1();
    					}
    					TrainingTarget.口_閉笑();
    					TrainingTarget.Set基本姿勢();
    					npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + GameText.親形質2;
    					ip.TextIm = Sta.GameData.TrainingTarget.Father.GetStatus();
    					bs["胸施術"].Dra = false;
    					bs["股施術"].Dra = false;
    					bs["淫紋"].Dra = false;
    					bs["衣装"].Dra = false;
    				}
    			}));

    			bs.Add("保守", MyUI.Button2(Med, DrawBuffer, GameText.保守, new Vector2D(0.85, 0.34), delegate(But b)
    			{
    				////Sounds.操作.Play();
    				if (Sta.GameData.TrainingTarget != null)
    				{
    					保守sw.OnOff(b);
    					Sta.GameData.TrainingTarget.保守 = 保守sw.Flag;
    					bs["売却"].Dra = !Sta.GameData.TrainingTarget.保守;
    					ip.SubInfoIm = (Sta.GameData.TrainingTarget.保守 ? GameText.奴隷を保守対象に設定しました : GameText.奴隷の保守設定を解除しました);
    				}
    			}));

    			bs.Add("一般労働", MyUI.Button2(Med, DrawBuffer, GameText.一般労働, new Vector2D(0.85, 0.42), delegate(But b)
    			{
    				////Sounds.操作.Play();
    				if (Sta.GameData.TrainingTarget != null)
    				{
    					一般sw.OnOff(b);
    					Sta.GameData.TrainingTarget.Laboror = 一般sw.Flag;
    					if (一般sw.Flag && 娼婦sw.Flag)
    					{
    						娼婦sw.SetFlag(bs["娼婦労働"], On: false);
    					}
    					Sta.GameData.TrainingTarget.Prostitute = 娼婦sw.Flag;
    					ip.SubInfoIm = (Sta.GameData.TrainingTarget.Laboror ? GameText.奴隷を一般労働に設定しました : GameText.奴隷の一般労働を解除しました);
    				}
    			}));

    			bs.Add("娼婦労働", MyUI.Button2(Med, DrawBuffer, GameText.娼婦労働, new Vector2D(0.85, 0.5), delegate (But b)
    			{
    				////Sounds.操作.Play();
    				if (Sta.GameData.TrainingTarget != null)
    				{
    					娼婦sw.OnOff(b);
    					Sta.GameData.TrainingTarget.Prostitute = 娼婦sw.Flag;
    					if (娼婦sw.Flag && 一般sw.Flag)
    					{
    						一般sw.SetFlag(bs["一般労働"], On: false);
    					}
    					Sta.GameData.TrainingTarget.Laboror = 一般sw.Flag;
    					ip.SubInfoIm = (Sta.GameData.TrainingTarget.Prostitute ? GameText.奴隷を娼婦労働に設定しました : GameText.奴隷の娼婦労働を解除しました);
    				}
    			}));
    			
                bs.Add("全一般", MyUI.Button2(Med, DrawBuffer, GameText.全一般, new Vector2D(0.75, 0.405), delegate
    			{
    				////Sounds.操作.Play();
    				if (Sta.GameData.TrainingTarget != null)
    				{
    					一般sw.SetFlag(bs["一般労働"], On: true);
    					娼婦sw.SetFlag(bs["娼婦労働"], On: false);
    				}
    				Unit[] 地下室3 = Sta.GameData.Slaves;
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
    				if (Sta.GameData.TrainingTarget != null)
    				{
    					一般sw.SetFlag(bs["一般労働"], On: false);
    					娼婦sw.SetFlag(bs["娼婦労働"], On: true);
    				}
    				Unit[] 地下室2 = Sta.GameData.Slaves;
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
    				if (Sta.GameData.TrainingTarget != null)
    				{
    					一般sw.SetFlag(bs["一般労働"], On: false);
    					娼婦sw.SetFlag(bs["娼婦労働"], On: false);
    				}
    				Unit[] 地下室 = Sta.GameData.Slaves;
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
    				ip.Mai2Im = Sta.GameData.TrainingTarget.GetPriceInfo();
    				ip.Mai2Show = true;
    				if (!Sta.GameData.TrainingTarget.保守)
    				{
    					ip.TextIm = GameText.売却しますか;
    				}
    				ip.選択yAct = delegate
    				{
    					Color HitColor4 = Col.Empty;
    					bs.Move(ref HitColor4);
    					ulong price = Sta.GameData.TrainingTarget.GetPrice();
    					Sta.GameData.所持金 = Sta.GameData.所持金.overflow_add(price);
    					//Sounds.精算.Play();
    					ip.UpdateSub2();
    					for (int m = 0; m < Sta.GameData.Slaves.Length; m++)
    					{
    						if (Sta.GameData.Slaves[m] == Sta.GameData.TrainingTarget)
    						{
    							Sta.GameData.Slaves[m] = null;
    							break;
    						}
    					}
    					Sta.GameData.地下室詰め();
    					set(f);
    					ip.SubInfoIm = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + GameText.を売却しました + " \r\n+" + price.ToString("#,0");
    					d = false;
    					But but8 = bs["ボタン" + (Sta.GameData.TrainingTarget.階層位置 + 1)];
    					but8.Action(but8);
    					But but9 = lv.bs.EnumBut.ToArray()[Sta.GameData.TrainingTarget.RoomNumber];
    					but9.Action(but9);
    					if (Sta.GameData.TrainingTarget == null)
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
    					Color HitColor3 = Col.Empty;
    					bs.Move(ref HitColor3);
    					ip.Mai2Show = false;
    					if (Sta.GameData.TrainingTarget == null)
    					{
    						ip.TextIm = " ";
    					}
    					else
    					{
    						ip.TextIm = Sta.GameData.TrainingTarget.GetStatus();
    					}
    					ip.SubInfoIm = GameText.売却をキャンセルしました;
    					ip.選択肢表示 = false;
    				};
    				ip.選択肢表示 = !Sta.GameData.TrainingTarget.保守;
    			}));

    			bs.Add("全売却", MyUI.Button2(Med, DrawBuffer, GameText.全売却, new Vector2D(0.75, 0.645), delegate
    			{
    				//Sounds.操作.Play();
    				string tb = ip.TextIm;
    				ip.Mai2Im = Sta.GameData.GetPriceInfo(out var p);
    				ip.Mai2Show = true;
    				ip.TextIm = GameText.保守以外の全ての奴隷を売却しますか;
    				ip.選択yAct = delegate
    				{
    					Color HitColor2 = Col.Empty;
    					bs.Move(ref HitColor2);
    					ip.Mai2Show = false;
    					Sta.GameData.所持金 = Sta.GameData.所持金.overflow_add(p);
                        //TODO fix?
                        ////Sounds.精算.Play();
    					ip.UpdateSub2();
    					for (int l = 0; l < Sta.GameData.Slaves.Length; l++)
    					{
    						if (Sta.GameData.Slaves[l] != null && !Sta.GameData.Slaves[l].保守)
    						{
    							Sta.GameData.Slaves[l] = null;
    						}
    					}
    					Sta.GameData.地下室詰め();
    					set(f);
    					d = false;
    					if (Sta.GameData.TrainingTarget != null)
    					{
    						if (!Sta.GameData.TrainingTarget.保守)
    						{
    							But but6 = bs["ボタン" + (Sta.GameData.TrainingTarget.階層位置 + 1)];
    							but6.Action(but6);
    							But but7 = lv.bs.EnumBut.ToArray()[Sta.GameData.TrainingTarget.RoomNumber];
    							but7.Action(but7);
    						}
    						else if (Sta.AlwaysUseName)
    						{
                                npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + Sta.GameData.TrainingTarget.Name;
                            }
    						else
    						{
    							npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + (Sta.GameData.TrainingTarget.Trained ? ("\r\n" + Sta.GameData.TrainingTarget.Name) : Sta.GameData.TrainingTarget.Race);
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
    					Color HitColor = Col.Empty;
    					bs.Move(ref HitColor);
    					ip.Mai2Show = false;
    					ip.TextIm = tb;
    					ip.SubInfoIm = GameText.全売却をキャンセルしました;
    					ip.選択肢表示 = false;
    				};
    				ip.選択肢表示 = true;
    			}));


    			ShapePartT shapePartT13 = new ShapePartT();
    			shapePartT13.Font = new Font("MS Gothic", 0.1f);
    			shapePartT13.PositionBase = DrawBuffer.GetPosition(0.03, 0.03);
    			shapePartT13.Text = "1F";
    			shapePartT13.FontSize = 0.15;
    			shapePartT13.SizeBase = 0.05;
    			shapePartT13.OP.AddRange(new Out[1] { Shas.GetSquare() });
    			shapePartT13.BasePointBase = shapePartT13.OP.GetCenter();
    			shapePartT13.OP.ScalingXY(shapePartT13.BasePointBase, 0.3);
    			shapePartT13.Closed = true;
    			shapePartT13.TextColor = Col.White;
    			shapePartT13.BrushColor = Color.FromArgb(160, Col.Black);
    			shapePartT13.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			shapePartT13.StringFormat.Alignment = StringAlignment.Center;
    			shapePartT13.StringFormat.LineAlignment = StringAlignment.Center;
    			shapePartT13.PenColor = Color.Red;
    			bs.Add("ボタン1", new But1(shapePartT13, delegate(But b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 0);
    				部屋選択();
    			}));


    			ShapePartT shapePartT14 = new ShapePartT();
    			shapePartT14.Font = new Font("MS Gothic", 0.1f);
    			shapePartT14.PositionBase = DrawBuffer.GetPosition(0.07, 0.03);
    			shapePartT14.Text = "2F";
    			shapePartT14.FontSize = 0.15;
    			shapePartT14.SizeBase = 0.05;
    			shapePartT14.OP.AddRange(new Out[1] { Shas.GetSquare() });
    			shapePartT14.BasePointBase = shapePartT14.OP.GetCenter();
    			shapePartT14.OP.ScalingXY(shapePartT14.BasePointBase, 0.3);
    			shapePartT14.Closed = true;
    			shapePartT14.TextColor = Col.White;
    			shapePartT14.BrushColor = Color.FromArgb(160, Col.Black);
    			shapePartT14.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			shapePartT14.StringFormat.Alignment = StringAlignment.Center;
    			shapePartT14.StringFormat.LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン2", new But1(shapePartT14, delegate(But b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 15);
    				部屋選択();
    			}));
    			ShapePartT shapePartT15 = new ShapePartT();
    			shapePartT15.Font = new Font("MS Gothic", 0.1f);
    			shapePartT15.PositionBase = DrawBuffer.GetPosition(0.11, 0.03);
    			shapePartT15.Text = "3F";
    			shapePartT15.FontSize = 0.15;
    			shapePartT15.SizeBase = 0.05;
    			shapePartT15.OP.AddRange(new Out[1] { Shas.GetSquare() });
    			shapePartT15.BasePointBase = shapePartT15.OP.GetCenter();
    			shapePartT15.OP.ScalingXY(shapePartT15.BasePointBase, 0.3);
    			shapePartT15.Closed = true;
    			shapePartT15.TextColor = Col.White;
    			shapePartT15.BrushColor = Color.FromArgb(160, Col.Black);
    			shapePartT15.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			shapePartT15.StringFormat.Alignment = StringAlignment.Center;
    			shapePartT15.StringFormat.LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン3", new But1(shapePartT15, delegate(But b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 30);
    				部屋選択();
    			}));
    			ShapePartT shapePartT16 = new ShapePartT();
    			shapePartT16.Font = new Font("MS Gothic", 0.1f);
    			shapePartT16.PositionBase = DrawBuffer.GetPosition(0.15, 0.03);
    			shapePartT16.Text = "4F";
    			shapePartT16.FontSize = 0.15;
    			shapePartT16.SizeBase = 0.05;
    			shapePartT16.OP.AddRange(new Out[1] { Shas.GetSquare() });
    			shapePartT16.BasePointBase = shapePartT16.OP.GetCenter();
    			shapePartT16.OP.ScalingXY(shapePartT16.BasePointBase, 0.3);
    			shapePartT16.Closed = true;
    			shapePartT16.TextColor = Col.White;
    			shapePartT16.BrushColor = Color.FromArgb(160, Col.Black);
    			shapePartT16.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			shapePartT16.StringFormat.Alignment = StringAlignment.Center;
    			shapePartT16.StringFormat.LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン4", new But1(shapePartT16, delegate(But b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 45);
    				部屋選択();
    			}));
    			ShapePartT shapePartT17 = new ShapePartT();
    			shapePartT17.Font = new Font("MS Gothic", 0.1f);
    			shapePartT17.PositionBase = DrawBuffer.GetPosition(0.19, 0.03);
    			shapePartT17.Text = "5F";
    			shapePartT17.FontSize = 0.15;
    			shapePartT17.SizeBase = 0.05;
    			shapePartT17.OP.AddRange(new Out[1] { Shas.GetSquare() });
    			shapePartT17.BasePointBase = shapePartT17.OP.GetCenter();
    			shapePartT17.OP.ScalingXY(shapePartT17.BasePointBase, 0.3);
    			shapePartT17.Closed = true;
    			shapePartT17.TextColor = Col.White;
    			shapePartT17.BrushColor = Color.FromArgb(160, Col.Black);
    			shapePartT17.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			shapePartT17.StringFormat.Alignment = StringAlignment.Center;
    			shapePartT17.StringFormat.LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン5", new But1(shapePartT17, delegate(But b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 60);
    				部屋選択();
    			}));
    			ShapePartT shapePartT18 = new ShapePartT();
    			shapePartT18.Font = new Font("MS Gothic", 0.1f);
    			shapePartT18.PositionBase = DrawBuffer.GetPosition(0.23, 0.03);
    			shapePartT18.Text = "6F";
    			shapePartT18.FontSize = 0.15;
    			shapePartT18.SizeBase = 0.05;
    			shapePartT18.OP.AddRange(new Out[1] { Shas.GetSquare() });
    			shapePartT18.BasePointBase = shapePartT18.OP.GetCenter();
    			shapePartT18.OP.ScalingXY(shapePartT18.BasePointBase, 0.3);
    			shapePartT18.Closed = true;
    			shapePartT18.TextColor = Col.White;
    			shapePartT18.BrushColor = Color.FromArgb(160, Col.Black);
    			shapePartT18.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			shapePartT18.StringFormat.Alignment = StringAlignment.Center;
    			shapePartT18.StringFormat.LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン6", new But1(shapePartT18, delegate(But b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 75);
    				部屋選択();
    			}));
    			ShapePartT shapePartT19 = new ShapePartT();
    			shapePartT19.Font = new Font("MS Gothic", 0.1f);
    			shapePartT19.PositionBase = DrawBuffer.GetPosition(0.27, 0.03);
    			shapePartT19.Text = "7F";
    			shapePartT19.FontSize = 0.15;
    			shapePartT19.SizeBase = 0.05;
    			shapePartT19.OP.AddRange(new Out[1] { Shas.GetSquare() });
    			shapePartT19.BasePointBase = shapePartT19.OP.GetCenter();
    			shapePartT19.OP.ScalingXY(shapePartT19.BasePointBase, 0.3);
    			shapePartT19.Closed = true;
    			shapePartT19.TextColor = Col.White;
    			shapePartT19.BrushColor = Color.FromArgb(160, Col.Black);
    			shapePartT19.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			shapePartT19.StringFormat.Alignment = StringAlignment.Center;
    			shapePartT19.StringFormat.LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン7", new But1(shapePartT19, delegate(But b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 90);
    				部屋選択();
    			}));
    			ShapePartT shapePartT20 = new ShapePartT();
    			shapePartT20.Font = new Font("MS Gothic", 0.1f);
    			shapePartT20.PositionBase = DrawBuffer.GetPosition(0.31, 0.03);
    			shapePartT20.Text = "8F";
    			shapePartT20.FontSize = 0.15;
    			shapePartT20.SizeBase = 0.05;
    			shapePartT20.OP.AddRange(new Out[1] { Shas.GetSquare() });
    			shapePartT20.BasePointBase = shapePartT20.OP.GetCenter();
    			shapePartT20.OP.ScalingXY(shapePartT20.BasePointBase, 0.3);
    			shapePartT20.Closed = true;
    			shapePartT20.TextColor = Col.White;
    			shapePartT20.BrushColor = Color.FromArgb(160, Col.Black);
    			shapePartT20.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			shapePartT20.StringFormat.Alignment = StringAlignment.Center;
    			shapePartT20.StringFormat.LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン8", new But1(shapePartT20, delegate(But b)
    			{
    				if (d)
    				{
    					//Sounds.操作.Play();
    				}
    				階層選択(b, f = 105);
    				部屋選択();
    			}));
    			ShapePartT shapePartT21 = new ShapePartT();
    			shapePartT21.Font = new Font("MS Gothic", 0.1f);
    			shapePartT21.PositionBase = DrawBuffer.GetPosition(0.35, 0.03);
    			shapePartT21.Text = "9F";
    			shapePartT21.FontSize = 0.15;
    			shapePartT21.SizeBase = 0.05;
    			shapePartT21.OP.AddRange(new Out[1] { Shas.GetSquare() });
    			shapePartT21.BasePointBase = shapePartT21.OP.GetCenter();
    			shapePartT21.OP.ScalingXY(shapePartT21.BasePointBase, 0.3);
    			shapePartT21.Closed = true;
    			shapePartT21.TextColor = Col.White;
    			shapePartT21.BrushColor = Color.FromArgb(160, Col.Black);
    			shapePartT21.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    			shapePartT21.StringFormat.Alignment = StringAlignment.Center;
    			shapePartT21.StringFormat.LineAlignment = StringAlignment.Center;
    			bs.Add("ボタン9", new But1(shapePartT21, delegate(But b)
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
    				if (Sta.GameData.所持金 < 胸施術価格)
    				{
    					//Sounds.操作.Play();
    					ip.SubInfoIm = GameText.所持金が足りません;
    				}
    				else
    				{
    					Sta.GameData.所持金 -= 胸施術価格;
                        //TODO fix?
                        ////Sounds.精算.Play();
    					ip.UpdateSub2();
    					Sta.GameData.TrainingTarget.ChaD.胸施術 = true;
    					TrainingTarget.Body.胸施術();
    					if (Sta.GameData.TrainingTarget.着衣 != null)
    					{
    						TrainingTarget.Set衣装(Sta.GameData.TrainingTarget.着衣);
    					}
    					Sta.GameData.TrainingTarget.体力消費();
    					bs["胸施術"].Dra = false;
    					ip.SubInfoIm = GameText.胸の甲殻を切除しました;
    					TrainingTarget.SetInitialExpression();
    					TrainingTarget.Emotion();
    					TrainingTarget.UpdateExpression();
    					if (Sta.GameData.TrainingTarget.Trained)
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
    				if (Sta.GameData.所持金 < 股施術価格)
    				{
    					//Sounds.操作.Play();
    					ip.SubInfoIm = GameText.所持金が足りません;
    				}
    				else
    				{
    					Sta.GameData.所持金 -= 股施術価格;
    					//Sounds.精算.Play();
    					ip.UpdateSub2();
    					Sta.GameData.TrainingTarget.ChaD.股施術 = true;
    					TrainingTarget.Body.股施術();
    					if (Sta.GameData.TrainingTarget.着衣 != null)
    					{
    						TrainingTarget.Set衣装(Sta.GameData.TrainingTarget.着衣);
    					}
    					Sta.GameData.TrainingTarget.体力消費();
    					bs["股施術"].Dra = false;
    					ip.SubInfoIm = GameText.股の + (TrainingTarget.Body.Is蠍 ? GameText.甲殻 : GameText.鱗) + GameText.を切除しました;
    					TrainingTarget.SetInitialExpression();
    					TrainingTarget.Emotion();
    					TrainingTarget.UpdateExpression();
    					if (Sta.GameData.TrainingTarget.Trained)
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
    				if (Sta.GameData.所持金 < 淫紋価格)
    				{
    					//Sounds.操作.Play();
    					ip.SubInfoIm = GameText.所持金が足りません;
    				}
    				else
    				{
    					Sta.GameData.所持金 -= 淫紋価格;
    					//Sounds.精算.Play();
    					ip.UpdateSub2();
    					Sta.GameData.TrainingTarget.ChaD.タトゥ = true;
    					TrainingTarget.Body.タトゥ();
    					Sta.GameData.TrainingTarget.発情フラグ = true;
    					Sta.GameData.TrainingTarget.体力消費();
    					bs["淫紋"].Dra = false;
    					ip.SubInfoIm = GameText.淫紋を刻みました;
    					TrainingTarget.SetInitialExpression();
    					TrainingTarget.Emotion();
    					TrainingTarget.UpdateExpression();
    					if (Sta.GameData.TrainingTarget.Trained)
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
    				if (Sta.GameData.所持金 < 衣装変更価格)
    				{
                        //TODO fix?
                        ////Sounds.操作.Play();
    					ip.SubInfoIm = GameText.所持金が足りません;
    				}
    				else
    				{
    					Sta.GameData.所持金 -= 衣装変更価格;
                        //TODO fix?
                        ////Sounds.精算.Play();
    					ip.UpdateSub2();
    					Sta.GameData.TrainingTarget.Change衣装();
    					TrainingTarget.Set衣装(Sta.GameData.TrainingTarget.着衣);
    					ip.SubInfoIm = GameText.衣装を変更しました;
    					TrainingTarget.SetInitialExpression();
    					TrainingTarget.Emotion();
    					TrainingTarget.UpdateExpression();
    					if (Sta.GameData.TrainingTarget.Trained)
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

                bs.Add("MoveRoomDown", MyUI.Button(Med, DrawBuffer, "Room ▼", Sta.BigWindow ? new Vector2D(0.146, 0.14) : new Vector2D(0.195, 0.1625), delegate
                    {
                        //Sounds.操作.Play();
                        MoveRoomDown();
                        mod.Setting();
                        if (Sta.AlwaysUseName)
                        {
                            npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + Sta.GameData.TrainingTarget.Name;
                        }
                        else
                        {
                            npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + (Sta.GameData.TrainingTarget.Trained ? ("\r\n" + Sta.GameData.TrainingTarget.Name) : ("\r\n" + Sta.GameData.TrainingTarget.Race));
                        }
                    }));

                bs.Add("MoveRoomUp", MyUI.Button(Med, DrawBuffer, "Room ▲", Sta.BigWindow ? new Vector2D(0.146, 0.11) : new Vector2D(0.195, 0.12), delegate
                    {
                        //Sounds.操作.Play();
                        MoveRoomUp();
                        mod.Setting();
                        if (Sta.AlwaysUseName)
                        {
                            npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + Sta.GameData.TrainingTarget.Name;
                        }
                        else
                        {
                            npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + (Sta.GameData.TrainingTarget.Trained ? ("\r\n" + Sta.GameData.TrainingTarget.Name) : ("\r\n" + Sta.GameData.TrainingTarget.Race));
                        }
                    }));
                
                bs.Add("MoveFloorDown", MyUI.Button(Med, DrawBuffer, "Floor ▼", Sta.BigWindow ? new Vector2D(0.146, 0.2) : new Vector2D(0.195, 0.2475), delegate
                    {
                        //Sounds.操作.Play();
                        MoveFloorDown();
                        mod.Setting();
                        if (Sta.AlwaysUseName)
                        {
                            npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + Sta.GameData.TrainingTarget.Name;
                        }
                        else
                        {
                            npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + (Sta.GameData.TrainingTarget.Trained ? ("\r\n" + Sta.GameData.TrainingTarget.Name) : ("\r\n" + Sta.GameData.TrainingTarget.Race));
                        }
                    }));

                bs.Add("MoveFloorUp", MyUI.Button(Med, DrawBuffer, "Floor ▲", Sta.BigWindow ? new Vector2D(0.146, 0.17) : new Vector2D(0.195, 0.205), delegate
                    {
                        //Sounds.操作.Play();
                        MoveFloorUp();
                        mod.Setting();
                        if (Sta.AlwaysUseName)
                        {
                            npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + Sta.GameData.TrainingTarget.Name;
                        }
                        else
                        {
                            npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + (Sta.GameData.TrainingTarget.Trained ? ("\r\n" + Sta.GameData.TrainingTarget.Name) : ("\r\n" + Sta.GameData.TrainingTarget.Race));
                        }
                    }));

    			bs.SetHitColor(Med);

                対象描画 = delegate (RenderArea a, FPS FPS)
                {
                    Med.HitGraphics.Clear(Col.Transparent);
                    if (a.HitGraphics != null)
                    {
                        a.HitGraphics.Clear(Col.Transparent);
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
    		Lab l = new Lab(DrawBuffer, "ラベル1", new Vector2D(ip.MaiB.Position.X, 0.026), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "No blessing", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black);
    		Buts bs = new Buts();
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
    		Action<Buts> rs1 = delegate(Buts bs_)
    		{
    			Color penColor = bs_["ボタン0"].PartGroup.Values.First().ToParT().PenColor;
    			foreach (But item in bs_.EnumBut.Skip(1))
    			{
    				item.PartGroup.Values.First().ToParT().PenColor = penColor;
    			}
    		};

    		bs.Add("子", MyUI.Button2(Med, DrawBuffer, GameText.子, new Vector2D(0.85, 0.1), delegate(But bu)
    		{
    			if (d)
    			{
    				//Sounds.操作.Play();
    			}
    			rs1(bs);
    			bu.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    			if (Sta.GameData.祝福 != null)
    			{
    				l.Text = Sta.GameData.祝福.Name;
    				ip.TextIm = Sta.GameData.祝福.GetStatus();
    				if (祝福 != null)
    				{
    					祝福.Dispose();
    				}
    				祝福 = new Character(Med, DrawBuffer, Sta.GameData.祝福.ChaD);
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
    				if (Sta.GameData.祝福.Race == GameText.ヴィオランテ)
    				{
    					祝福.両瞼_卑();
    					祝福.両瞼_半1();
    				}
    				祝福.口_閉笑();
    				祝福.Set基本姿勢();
    			}
    		}));

    		bs.Add("親形質1", MyUI.Button2(Med, DrawBuffer, GameText.親形質1, new Vector2D(0.85, 0.18), delegate(But bu)
    		{
    			//Sounds.操作.Play();
    			rs1(bs);
    			bu.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    			if (Sta.GameData.祝福 != null)
    			{
    				l.Text = GameText.親形質1;
    				ip.TextIm = Sta.GameData.祝福.Mother.GetStatus();
    				if (祝福 != null)
    				{
    					祝福.Dispose();
    				}
    				祝福 = new Character(Med, DrawBuffer, Sta.GameData.祝福.Mother.ChaD);
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
    				if (Sta.GameData.祝福.Mother.Race == GameText.ヴィオランテ)
    				{
    					祝福.両瞼_卑();
    					祝福.両瞼_半1();
    				}
    				祝福.口_閉笑();
    				祝福.Set基本姿勢();
    			}
    		}));

    		bs.Add("親形質2", MyUI.Button2(Med, DrawBuffer, GameText.親形質2, new Vector2D(0.85, 0.26), delegate(But bu)
    		{
    			//Sounds.操作.Play();
    			rs1(bs);
    			bu.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    			if (Sta.GameData.祝福 != null)
    			{
    				l.Text = GameText.親形質2;
    				ip.TextIm = Sta.GameData.祝福.Father.GetStatus();
    				if (祝福 != null)
    				{
    					祝福.Dispose();
    				}
    				祝福 = new Character(Med, DrawBuffer, Sta.GameData.祝福.Father.ChaD);
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
    				if (Sta.GameData.祝福.Father.Race == GameText.ヴィオランテ)
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
    			Sta.GameData.祝福 = null;
    			祝福なし();
    			ip.SubInfoIm = GameText.祝福を解除しました;
    		}));

    		bs.SetHitColor(Med);
    		Action subinfo = delegate
    		{
    			if (Sta.GameData.祝福 != null)
    			{
    				ip.SubInfoIm = Sta.GameData.祝福.Name + GameText.から祝福を受けています;
    			}
    			else
    			{
    				ip.SubInfoIm = GameText.祝福されていません;
    			}
    		};

            DrawBlessing = delegate (RenderArea a, FPS FPS)
            {
                Med.HitGraphics.Clear(Col.Transparent);
                if (a.HitGraphics != null)
                {
                    a.HitGraphics.Clear(Col.Transparent);
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
                        if (Sta.GameData.祝福 != null)
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
                Draw = delegate (FPS FPS)
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
    		Buts bs = new Buts();
    		ShapePartT shapePartT = new ShapePartT();
    		shapePartT.Font = new Font("MS Gothic", 0.1f);
    		shapePartT.PositionBase = DrawBuffer.GetPosition(0.85, 0.02);
    		shapePartT.Text = GameText.戻る;
    		shapePartT.FontSize = 0.15;
    		shapePartT.SizeBase = 0.05;
    		shapePartT.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT.OP.ScalingY(shapePartT.OP.GetCenter(), 0.47);
    		shapePartT.OP.Rotation(shapePartT.OP.GetCenter(), -26.0);
    		shapePartT.Closed = true;
    		shapePartT.TextColor = Col.White;
    		shapePartT.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("ボタン0", new But1(shapePartT, delegate
    		{
    			//Sounds.操作.Play();
    			if (!PassTime(Med))
    			{
    				Med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
    			}
    		}));
    		ShapePartT shapePartT2 = new ShapePartT();
    		shapePartT2.Font = new Font("MS Gothic", 0.1f);
    		shapePartT2.PositionBase = DrawBuffer.GetPosition(0.85, 0.1);
    		shapePartT2.Text = GameText.借金;
    		shapePartT2.FontSize = 0.15;
    		shapePartT2.SizeBase = 0.05;
    		shapePartT2.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT2.OP.ScalingY(shapePartT2.OP.GetCenter(), 0.47);
    		shapePartT2.OP.Rotation(shapePartT2.OP.GetCenter(), -26.0);
    		shapePartT2.Closed = true;
    		shapePartT2.TextColor = Col.White;
    		shapePartT2.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT2.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT2.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("ボタン1", new But1(shapePartT2, delegate
    		{
    			//Sounds.操作.Play();
    			Med.Mode = "Debt";
    		}));
    		ShapePartT shapePartT3 = new ShapePartT();
    		shapePartT3.Font = new Font("MS Gothic", 0.1f);
    		shapePartT3.PositionBase = DrawBuffer.GetPosition(0.85, 0.18);
    		shapePartT3.Text = GameText.購入;
    		shapePartT3.FontSize = 0.15;
    		shapePartT3.SizeBase = 0.05;
    		shapePartT3.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT3.OP.ScalingY(shapePartT3.OP.GetCenter(), 0.47);
    		shapePartT3.OP.Rotation(shapePartT3.OP.GetCenter(), -26.0);
    		shapePartT3.Closed = true;
    		shapePartT3.TextColor = Col.White;
    		shapePartT3.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT3.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT3.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("ボタン2", new But1(shapePartT3, delegate
    		{
    			//Sounds.操作.Play();
    			Med.Mode = "SlaveShop";
    		}));
    		ShapePartT shapePartT4 = new ShapePartT();
    		shapePartT4.Font = new Font("MS Gothic", 0.1f);
    		shapePartT4.PositionBase = DrawBuffer.GetPosition(0.85, 0.58);
    		shapePartT4.Text = GameText.祝福;
    		shapePartT4.FontSize = 0.15;
    		shapePartT4.SizeBase = 0.05;
    		shapePartT4.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT4.OP.ScalingY(shapePartT4.OP.GetCenter(), 0.47);
    		shapePartT4.OP.Rotation(shapePartT4.OP.GetCenter(), -26.0);
    		shapePartT4.Closed = true;
    		shapePartT4.TextColor = Col.White;
    		shapePartT4.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT4.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT4.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("ボタン3", new But1(shapePartT4, delegate
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
    				ViolaTextBubble.Tex.Feed.Dra = false;
    				bs["ボタン1"].Dra = !Sta.GameData.初事務所フラグ;
    				bs["ボタン3"].Dra = Sta.GameData.RepaymentStage == 3;
    				Viola.両目_見つめ();
    				Viola.表情_基本0();
    				Viola.Set基本姿勢();
    				if (Sta.GameData.初事務所フラグ)
    				{
    					Viola.表情_不敵1();
    					ViolaText.Set();
    				}
    				else
    				{
    					ViolaText.Set();
    				}
    				si.Set(bre: false);
    				if (Sta.GameData.RepaymentStage < 3)
    				{
    					if (Sta.GameData.RepaymentStage == 0 && Sta.GameData.借金 < 単位返済段階額 * 2)
    					{
    						Sta.GameData.RepaymentStage = 1;
    						Sta.GameData.系統開放[2] = true;
    						Sta.GameData.系統開放[3] = true;
    						Sta.GameData.心眼 = true;
    						Med.SwitchMode("RepaymentEvent1", DrawBuffer, 返済イベント描画);
    						SetDemandMaximum();
    					}
    					else if (Sta.GameData.RepaymentStage == 1 && Sta.GameData.借金 < 単位返済段階額)
    					{
    						Sta.GameData.RepaymentStage = 2;
    						Sta.GameData.系統開放[4] = true;
    						Sta.GameData.系統開放[5] = true;
    						Sta.GameData.媚薬 = true;
    						Sta.GameData.施術 = true;
    						Sta.GameData.淫紋 = true;
    						Sta.GameData.衣装 = true;
    						Med.SwitchMode("RepaymentEvent2", DrawBuffer, 返済イベント描画);
    						SetDemandMaximum();
    					}
    					else if (Sta.GameData.RepaymentStage == 2 && Sta.GameData.借金 == 0L)
    					{
    						Sta.GameData.RepaymentStage = 3;
    						Sta.GameData.系統開放[6] = true;
    						Sta.GameData.系統開放[7] = true;
    						Sta.GameData.系統開放[8] = true;
    						Sta.GameData.ヴィオラ服 = true;
    						Med.SwitchMode("RepaymentEvent3", DrawBuffer, 返済イベント描画);
    						SetDemandMaximum();
    					}
    				}
    			}
    		};
    		DrawOffice = delegate(RenderArea a, FPS FPS)
    		{
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(Col.Transparent);
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
    		mod.Draw = delegate(FPS FPS)
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
    		Buts bs = new Buts();

    		bs.Add("ボタン0", MyUI.Button2(Med, DrawBuffer, GameText.戻る, new Vector2D(0.85, 0.02), delegate
    		{
    			//Sounds.操作.Play();
    			Med.Mode = "Office";
    		}));

    		ShapePartT shapePartT2 = new ShapePartT();
    		shapePartT2.Font = new Font("MS Gothic", 0.1f);
    		shapePartT2.PositionBase = position + DrawBuffer.GetPosition(0.0, 0.0);
    		shapePartT2.Text = "c";
    		shapePartT2.FontSize = 0.15;
    		shapePartT2.SizeBase = 0.07;
    		shapePartT2.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT2.OP.ScalingXY(shapePartT2.OP.GetCenter(), 0.3, 0.3);
    		shapePartT2.Closed = true;
    		shapePartT2.TextColor = Col.White;
    		shapePartT2.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT2.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT2.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("nc", new But1(shapePartT2, delegate
    		{
    			//Sounds.操作.Play();
    			ip.TextIm = "0";
    		}));

    		ShapePartT shapePartT3 = new ShapePartT();
    		shapePartT3.Font = new Font("MS Gothic", 0.1f);
    		shapePartT3.PositionBase = position + DrawBuffer.GetPosition(0.06, 0.0);
    		shapePartT3.Text = "m";
    		shapePartT3.FontSize = 0.15;
    		shapePartT3.SizeBase = 0.07;
    		shapePartT3.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT3.OP.ScalingXY(shapePartT3.OP.GetCenter(), 0.3, 0.3);
    		shapePartT3.Closed = true;
    		shapePartT3.TextColor = Col.White;
    		shapePartT3.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT3.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT3.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("nm", new But1(shapePartT3, delegate
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
    		shapePartT4.Font = new Font("MS Gothic", 0.1f);
    		shapePartT4.PositionBase = position + DrawBuffer.GetPosition(0.0, 0.07);
    		shapePartT4.Text = "7";
    		shapePartT4.FontSize = 0.15;
    		shapePartT4.SizeBase = 0.07;
    		shapePartT4.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT4.OP.ScalingXY(shapePartT4.OP.GetCenter(), 0.3, 0.3);
    		shapePartT4.Closed = true;
    		shapePartT4.TextColor = Col.White;
    		shapePartT4.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT4.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT4.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("n7", new But1(shapePartT4, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("7");
    		}));

    		ShapePartT shapePartT5 = new ShapePartT();
    		shapePartT5.Font = new Font("MS Gothic", 0.1f);
    		shapePartT5.PositionBase = position + DrawBuffer.GetPosition(0.06, 0.07);
    		shapePartT5.Text = "8";
    		shapePartT5.FontSize = 0.15;
    		shapePartT5.SizeBase = 0.07;
    		shapePartT5.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT5.OP.ScalingXY(shapePartT5.OP.GetCenter(), 0.3, 0.3);
    		shapePartT5.Closed = true;
    		shapePartT5.TextColor = Col.White;
    		shapePartT5.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT5.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT5.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("n8", new But1(shapePartT5, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("8");
    		}));

    		ShapePartT shapePartT6 = new ShapePartT();
    		shapePartT6.Font = new Font("MS Gothic", 0.1f);
    		shapePartT6.PositionBase = position + DrawBuffer.GetPosition(0.12, 0.07);
    		shapePartT6.Text = "9";
    		shapePartT6.FontSize = 0.15;
    		shapePartT6.SizeBase = 0.07;
    		shapePartT6.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT6.OP.ScalingXY(shapePartT6.OP.GetCenter(), 0.3, 0.3);
    		shapePartT6.Closed = true;
    		shapePartT6.TextColor = Col.White;
    		shapePartT6.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT6.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT6.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT6.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("n9", new But1(shapePartT6, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("9");
    		}));

    		ShapePartT shapePartT7 = new ShapePartT();
    		shapePartT7.Font = new Font("MS Gothic", 0.1f);
    		shapePartT7.PositionBase = position + DrawBuffer.GetPosition(0.0, 0.14);
    		shapePartT7.Text = "4";
    		shapePartT7.FontSize = 0.15;
    		shapePartT7.SizeBase = 0.07;
    		shapePartT7.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT7.OP.ScalingXY(shapePartT7.OP.GetCenter(), 0.3, 0.3);
    		shapePartT7.Closed = true;
    		shapePartT7.TextColor = Col.White;
    		shapePartT7.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT7.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT7.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT7.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("n4", new But1(shapePartT7, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("4");
    		}));

    		ShapePartT shapePartT8 = new ShapePartT();
    		shapePartT8.Font = new Font("MS Gothic", 0.1f);
    		shapePartT8.PositionBase = position + DrawBuffer.GetPosition(0.06, 0.14);
    		shapePartT8.Text = "5";
    		shapePartT8.FontSize = 0.15;
    		shapePartT8.SizeBase = 0.07;
    		shapePartT8.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT8.OP.ScalingXY(shapePartT8.OP.GetCenter(), 0.3, 0.3);
    		shapePartT8.Closed = true;
    		shapePartT8.TextColor = Col.White;
    		shapePartT8.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT8.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT8.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT8.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("n5", new But1(shapePartT8, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("5");
    		}));

    		ShapePartT shapePartT9 = new ShapePartT();
    		shapePartT9.Font = new Font("MS Gothic", 0.1f);
    		shapePartT9.PositionBase = position + DrawBuffer.GetPosition(0.12, 0.14);
    		shapePartT9.Text = "6";
    		shapePartT9.FontSize = 0.15;
    		shapePartT9.SizeBase = 0.07;
    		shapePartT9.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT9.OP.ScalingXY(shapePartT9.OP.GetCenter(), 0.3, 0.3);
    		shapePartT9.Closed = true;
    		shapePartT9.TextColor = Col.White;
    		shapePartT9.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT9.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT9.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT9.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("n6", new But1(shapePartT9, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("6");
    		}));

    		ShapePartT shapePartT10 = new ShapePartT();
    		shapePartT10.Font = new Font("MS Gothic", 0.1f);
    		shapePartT10.PositionBase = position + DrawBuffer.GetPosition(0.0, 0.21);
    		shapePartT10.Text = "1";
    		shapePartT10.FontSize = 0.15;
    		shapePartT10.SizeBase = 0.07;
    		shapePartT10.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT10.OP.ScalingXY(shapePartT10.OP.GetCenter(), 0.3, 0.3);
    		shapePartT10.Closed = true;
    		shapePartT10.TextColor = Col.White;
    		shapePartT10.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT10.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT10.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT10.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("n1", new But1(shapePartT10, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("1");
    		}));

    		ShapePartT shapePartT11 = new ShapePartT();
    		shapePartT11.Font = new Font("MS Gothic", 0.1f);
    		shapePartT11.PositionBase = position + DrawBuffer.GetPosition(0.06, 0.21);
    		shapePartT11.Text = "2";
    		shapePartT11.FontSize = 0.15;
    		shapePartT11.SizeBase = 0.07;
    		shapePartT11.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT11.OP.ScalingXY(shapePartT11.OP.GetCenter(), 0.3, 0.3);
    		shapePartT11.Closed = true;
    		shapePartT11.TextColor = Col.White;
    		shapePartT11.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT11.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT11.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT11.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("n2", new But1(shapePartT11, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("2");
    		}));

    		ShapePartT shapePartT12 = new ShapePartT();
    		shapePartT12.Font = new Font("MS Gothic", 0.1f);
    		shapePartT12.PositionBase = position + DrawBuffer.GetPosition(0.12, 0.21);
    		shapePartT12.Text = "3";
    		shapePartT12.FontSize = 0.15;
    		shapePartT12.SizeBase = 0.07;
    		shapePartT12.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT12.OP.ScalingXY(shapePartT12.OP.GetCenter(), 0.3, 0.3);
    		shapePartT12.Closed = true;
    		shapePartT12.TextColor = Col.White;
    		shapePartT12.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT12.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT12.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT12.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("n3", new But1(shapePartT12, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("3");
    		}));

    		ShapePartT shapePartT13 = new ShapePartT();
    		shapePartT13.Font = new Font("MS Gothic", 0.1f);
    		shapePartT13.PositionBase = position + DrawBuffer.GetPosition(0.0, 0.28);
    		shapePartT13.Text = "0";
    		shapePartT13.FontSize = 0.15;
    		shapePartT13.SizeBase = 0.07;
    		shapePartT13.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT13.OP.ScalingXY(shapePartT13.OP.GetCenter(), 0.3, 0.3);
    		shapePartT13.Closed = true;
    		shapePartT13.TextColor = Col.White;
    		shapePartT13.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT13.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT13.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT13.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("n0", new But1(shapePartT13, delegate
    		{
    			//Sounds.操作.Play();
    			SetNum("0");
    		}));

    		ShapePartT shapePartT14 = new ShapePartT();
    		shapePartT14.Font = new Font("MS Gothic", 0.1f);
    		shapePartT14.PositionBase = position + DrawBuffer.GetPosition(0.12, 0.28);
    		shapePartT14.Text = GameText.借;
    		shapePartT14.FontSize = 0.15;
    		shapePartT14.SizeBase = 0.07;
    		shapePartT14.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT14.OP.ScalingXY(shapePartT14.OP.GetCenter(), 0.3, 0.3);
    		shapePartT14.Closed = true;
    		shapePartT14.TextColor = Col.White;
    		shapePartT14.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT14.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT14.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT14.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("nb", new But1(shapePartT14, delegate
    		{
    			if (Sta.GameData.日借金可能額 != 0)
    			{
    				ulong num3 = ulong.Parse(ip.Text, NumberStyles.AllowThousands);
    				if (num3 != 0)
    				{
    					if (num3 > Sta.GameData.日借金可能額)
    					{
    						num3 = Sta.GameData.日借金可能額;
    						ip.SubInfo = GameText.借金可能額以上は無視されます;
    					}
    					Sta.GameData.日借金額 += num3;
    					Sta.GameData.所持金 = Sta.GameData.所持金.overflow_add(num3);
    					Sta.GameData.借金 = Sta.GameData.借金.overflow_add(num3);
    					bs["nr"].Dra = Sta.GameData.借金 != 0;
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
    		shapePartT15.Font = new Font("MS Gothic", 0.1f);
    		shapePartT15.PositionBase = position + DrawBuffer.GetPosition(0.06, 0.28);
    		shapePartT15.Text = GameText.返;
    		shapePartT15.FontSize = 0.15;
    		shapePartT15.SizeBase = 0.07;
    		shapePartT15.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT15.OP.ScalingXY(shapePartT15.OP.GetCenter(), 0.3, 0.3);
    		shapePartT15.Closed = true;
    		shapePartT15.TextColor = Col.White;
    		shapePartT15.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT15.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT15.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT15.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("nr", new But1(shapePartT15, delegate
    		{
    			if (Sta.GameData.所持金 != 0)
    			{
    				ulong num2 = ulong.Parse(ip.Text, NumberStyles.AllowThousands);
    				if (num2 != 0)
    				{
    					if (num2 > Sta.GameData.所持金)
    					{
    						num2 = Sta.GameData.所持金;
    						ip.SubInfo = GameText.返済可能額以上は無視されます;
    					}
    					if (num2 > Sta.GameData.借金)
    					{
    						Sta.GameData.所持金 = Sta.GameData.所持金.underflow_subtract(Sta.GameData.借金);
    						Sta.GameData.借金 = 0uL;
    						ip.SubInfo = GameText.返済可能額以上は無視されます;
    					}
    					else
    					{
    						Sta.GameData.所持金 = Sta.GameData.所持金.underflow_subtract(num2);
    						Sta.GameData.借金 = Sta.GameData.借金.underflow_subtract(num2);
    					}
    					bs["nr"].Dra = Sta.GameData.借金 != 0;
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
    				bs["nr"].Dra = Sta.GameData.借金 != 0;
    				//bs["nr"].Dra = Sta.GameData.借金 != 0;
    			}
    		};
    		DrawDebt = delegate(RenderArea a, FPS FPS)
    		{
    			Med.HitGraphics.Clear(Col.Transparent);
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(Col.Transparent);
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
    		mod.Draw = delegate(FPS FPS)
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
    		Buts bs = new Buts();
    		ShapePartT shapePartT = new ShapePartT();
    		shapePartT.Font = new Font("MS Gothic", 0.1f);
    		shapePartT.PositionBase = DrawBuffer.GetPosition(0.85, 0.02);
    		shapePartT.Text = GameText.戻る;
    		shapePartT.FontSize = 0.15;
    		shapePartT.SizeBase = 0.05;
    		shapePartT.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT.OP.ScalingY(shapePartT.OP.GetCenter(), 0.47);
    		shapePartT.OP.Rotation(shapePartT.OP.GetCenter(), -26.0);
    		shapePartT.Closed = true;
    		shapePartT.TextColor = Col.White;
    		shapePartT.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("ボタン0", new But1(shapePartT, delegate
    		{
    			//Sounds.操作.Play();
    			if (Sta.GameData.初事務所フラグ)
    			{
    				Med.SwitchMode("初事務所", DrawBuffer, 初事務所描画);
    			}
    			else
    			{
    				Med.Mode = "Office";
    			}
    		}));
    		ShapePartT shapePartT2 = new ShapePartT();
    		shapePartT2.Font = new Font("MS Gothic", 0.1f);
    		shapePartT2.PositionBase = DrawBuffer.GetPosition(0.85, 0.1);
    		shapePartT2.Text = GameText.奴隷;
    		shapePartT2.FontSize = 0.15;
    		shapePartT2.SizeBase = 0.05;
    		shapePartT2.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT2.OP.ScalingY(shapePartT2.OP.GetCenter(), 0.47);
    		shapePartT2.OP.Rotation(shapePartT2.OP.GetCenter(), -26.0);
    		shapePartT2.Closed = true;
    		shapePartT2.TextColor = Col.White;
    		shapePartT2.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT2.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT2.StringFormat.LineAlignment = StringAlignment.Center;
    		shapePartT2.PenColor = Color.Red;
    		bs.Add("ボタン1", new But1(shapePartT2, delegate
    		{
    			//Sounds.操作.Play();
    			Med.Mode = "SlaveShop";
    		}));
    		ShapePartT shapePartT3 = new ShapePartT();
    		shapePartT3.Font = new Font("MS Gothic", 0.1f);
    		shapePartT3.PositionBase = DrawBuffer.GetPosition(0.85, 0.18);
    		shapePartT3.Text = GameText.道具;
    		shapePartT3.FontSize = 0.15;
    		shapePartT3.SizeBase = 0.05;
    		shapePartT3.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT3.OP.ScalingY(shapePartT3.OP.GetCenter(), 0.47);
    		shapePartT3.OP.Rotation(shapePartT3.OP.GetCenter(), -26.0);
    		shapePartT3.Closed = true;
    		shapePartT3.TextColor = Col.White;
    		shapePartT3.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT3.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT3.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("ボタン2", new But1(shapePartT3, delegate
    		{
    			//Sounds.操作.Play();
    			Med.Mode = "ToolShop";
    		}));
    		Color bs初期縁色 = Col.Black;
    		Action bs縁色初期化 = delegate
    		{
    			foreach (But item in bs.EnumBut.Skip(3).Take(10))
    			{
    				item.PartGroup.Values.First().ToParT().PenColor = bs初期縁色;
    			}
    		};
    		double num = 0.7;
    		double num2 = -0.03;
    		ShapePartT shapePartT4 = new ShapePartT();
    		shapePartT4.Font = new Font("MS Gothic", 0.1f);
    		shapePartT4.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.02 * num);
    		shapePartT4.Text = GameText.ランダム;
    		shapePartT4.FontSize = 0.15;
    		shapePartT4.SizeBase = 0.05;
    		shapePartT4.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT4.OP.ScalingY(shapePartT4.OP.GetCenter(), 0.5 * num);
    		shapePartT4.Closed = true;
    		shapePartT4.TextColor = Col.White;
    		shapePartT4.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT4.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT4.StringFormat.LineAlignment = StringAlignment.Center;
    		shapePartT4.PenColor = Color.Red;
    		bs.Add("対象0", new But1(shapePartT4, delegate(But bu)
    		{
    			if (d)
    			{
    				//Sounds.操作.Play();
    			}
    			d = true;
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    			Reload();
    		}));
    		ShapePartT shapePartT5 = new ShapePartT();
    		shapePartT5.Font = new Font("MS Gothic", 0.1f);
    		shapePartT5.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.1 * num);
    		shapePartT5.Text = GameText.鳥系;
    		shapePartT5.FontSize = 0.15;
    		shapePartT5.SizeBase = 0.05;
    		shapePartT5.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT5.OP.ScalingY(shapePartT5.OP.GetCenter(), 0.5 * num);
    		shapePartT5.Closed = true;
    		shapePartT5.TextColor = Col.White;
    		shapePartT5.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT5.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT5.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("対象1", new But1(shapePartT5, delegate(But bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    			Reload();
    		}));
    		ShapePartT shapePartT6 = new ShapePartT();
    		shapePartT6.Font = new Font("MS Gothic", 0.1f);
    		shapePartT6.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.18 * num);
    		shapePartT6.Text = GameText.蛇系;
    		shapePartT6.FontSize = 0.15;
    		shapePartT6.SizeBase = 0.05;
    		shapePartT6.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT6.OP.ScalingY(shapePartT6.OP.GetCenter(), 0.5 * num);
    		shapePartT6.Closed = true;
    		shapePartT6.TextColor = Col.White;
    		shapePartT6.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT6.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT6.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT6.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("対象2", new But1(shapePartT6, delegate(But bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    			Reload();
    		}));
    		ShapePartT shapePartT7 = new ShapePartT();
    		shapePartT7.Font = new Font("MS Gothic", 0.1f);
    		shapePartT7.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.26 * num);
    		shapePartT7.Text = GameText.獣系;
    		shapePartT7.FontSize = 0.15;
    		shapePartT7.SizeBase = 0.05;
    		shapePartT7.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT7.OP.ScalingY(shapePartT7.OP.GetCenter(), 0.5 * num);
    		shapePartT7.Closed = true;
    		shapePartT7.TextColor = Col.White;
    		shapePartT7.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT7.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT7.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT7.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("対象3", new But1(shapePartT7, delegate(But bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    			Reload();
    		}));
    		ShapePartT shapePartT8 = new ShapePartT();
    		shapePartT8.Font = new Font("MS Gothic", 0.1f);
    		shapePartT8.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.34 * num);
    		shapePartT8.Text = GameText.水系;
    		shapePartT8.FontSize = 0.15;
    		shapePartT8.SizeBase = 0.05;
    		shapePartT8.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT8.OP.ScalingY(shapePartT8.OP.GetCenter(), 0.5 * num);
    		shapePartT8.Closed = true;
    		shapePartT8.TextColor = Col.White;
    		shapePartT8.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT8.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT8.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT8.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("対象4", new But1(shapePartT8, delegate(But bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    			Reload();
    		}));
    		ShapePartT shapePartT9 = new ShapePartT();
    		shapePartT9.Font = new Font("MS Gothic", 0.1f);
    		shapePartT9.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.42 * num);
    		shapePartT9.Text = GameText.虫系;
    		shapePartT9.FontSize = 0.15;
    		shapePartT9.SizeBase = 0.05;
    		shapePartT9.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT9.OP.ScalingY(shapePartT9.OP.GetCenter(), 0.5 * num);
    		shapePartT9.Closed = true;
    		shapePartT9.TextColor = Col.White;
    		shapePartT9.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT9.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT9.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT9.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("対象5", new But1(shapePartT9, delegate(But bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    			Reload();
    		}));
    		ShapePartT shapePartT10 = new ShapePartT();
    		shapePartT10.Font = new Font("MS Gothic", 0.1f);
    		shapePartT10.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.5 * num);
    		shapePartT10.Text = GameText.人型;
    		shapePartT10.FontSize = 0.15;
    		shapePartT10.SizeBase = 0.05;
    		shapePartT10.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT10.OP.ScalingY(shapePartT10.OP.GetCenter(), 0.5 * num);
    		shapePartT10.Closed = true;
    		shapePartT10.TextColor = Col.White;
    		shapePartT10.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT10.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT10.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT10.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("対象6", new But1(shapePartT10, delegate(But bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    			Reload();
    		}));
    		ShapePartT shapePartT11 = new ShapePartT();
    		shapePartT11.Font = new Font("MS Gothic", 0.1f);
    		shapePartT11.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.58 * num);
    		shapePartT11.Text = GameText.幻獣;
    		shapePartT11.FontSize = 0.15;
    		shapePartT11.SizeBase = 0.05;
    		shapePartT11.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT11.OP.ScalingY(shapePartT11.OP.GetCenter(), 0.5 * num);
    		shapePartT11.Closed = true;
    		shapePartT11.TextColor = Col.White;
    		shapePartT11.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT11.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT11.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT11.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("対象7", new But1(shapePartT11, delegate(But bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    			Reload();
    		}));
    		ShapePartT shapePartT12 = new ShapePartT();
    		shapePartT12.Font = new Font("MS Gothic", 0.1f);
    		shapePartT12.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.66 * num);
    		shapePartT12.Text = GameText.魔獣;
    		shapePartT12.FontSize = 0.15;
    		shapePartT12.SizeBase = 0.05;
    		shapePartT12.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT12.OP.ScalingY(shapePartT12.OP.GetCenter(), 0.5 * num);
    		shapePartT12.Closed = true;
    		shapePartT12.TextColor = Col.White;
    		shapePartT12.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT12.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT12.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT12.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("対象8", new But1(shapePartT12, delegate(But bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    			Reload();
    		}));
    		ShapePartT shapePartT13 = new ShapePartT();
    		shapePartT13.Font = new Font("MS Gothic", 0.1f);
    		shapePartT13.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.74 * num);
    		shapePartT13.Text = GameText.竜系;
    		shapePartT13.FontSize = 0.15;
    		shapePartT13.SizeBase = 0.05;
    		shapePartT13.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT13.OP.ScalingY(shapePartT13.OP.GetCenter(), 0.5 * num);
    		shapePartT13.Closed = true;
    		shapePartT13.TextColor = Col.White;
    		shapePartT13.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT13.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT13.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT13.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("対象9", new But1(shapePartT13, delegate(But bu)
    		{
    			//Sounds.操作.Play();
    			bs縁色初期化();
    			bu.PartGroup.Values.First().ToParT().PenColor = Color.Red;
    			Reload();
    		}));
    		Action SetGen = delegate
    		{
    			if (bs["対象0"].PartGroup.Values.First().ToParT().PenColor == Color.Red)
    			{
    				if ((Sta.GameData.鳥系.Count != 0 && Sta.GameData.系統開放[0]) || (Sta.GameData.蛇系.Count != 0 && Sta.GameData.系統開放[1]) || (Sta.GameData.獣系.Count != 0 && Sta.GameData.系統開放[2]) || (Sta.GameData.水系.Count != 0 && Sta.GameData.系統開放[3]) || (Sta.GameData.虫系.Count != 0 && Sta.GameData.系統開放[4]) || (Sta.GameData.人型.Count != 0 && Sta.GameData.系統開放[5]) || (Sta.GameData.幻獣.Count != 0 && Sta.GameData.系統開放[6]) || (Sta.GameData.魔獣.Count != 0 && Sta.GameData.系統開放[7]) || (Sta.GameData.竜系.Count != 0 && Sta.GameData.系統開放[8]))
    				{
    					do
    					{
    						switch (RNG.XS.Next(Sta.GameData.系統開放.Count((bool e) => e)))
    						{
    						case 0:
    							g = Sta.GameData.鳥系;
    							break;
    						case 1:
    							g = Sta.GameData.蛇系;
    							break;
    						case 2:
    							g = Sta.GameData.獣系;
    							break;
    						case 3:
    							g = Sta.GameData.水系;
    							break;
    						case 4:
    							g = Sta.GameData.虫系;
    							break;
    						case 5:
    							g = Sta.GameData.人型;
    							break;
    						case 6:
    							g = Sta.GameData.幻獣;
    							break;
    						case 7:
    							g = Sta.GameData.魔獣;
    							break;
    						case 8:
    							g = Sta.GameData.竜系;
    							break;
    						}
    					}
    					while (g.Count == 0);
    				}
    				else
    				{
    					switch (RNG.XS.Next(Sta.GameData.系統開放.Count((bool e) => e)))
    					{
    					case 0:
    						g = Sta.GameData.鳥系;
    						break;
    					case 1:
    						g = Sta.GameData.蛇系;
    						break;
    					case 2:
    						g = Sta.GameData.獣系;
    						break;
    					case 3:
    						g = Sta.GameData.水系;
    						break;
    					case 4:
    						g = Sta.GameData.虫系;
    						break;
    					case 5:
    						g = Sta.GameData.人型;
    						break;
    					case 6:
    						g = Sta.GameData.幻獣;
    						break;
    					case 7:
    						g = Sta.GameData.魔獣;
    						break;
    					case 8:
    						g = Sta.GameData.竜系;
    						break;
    					}
    				}
    			}
    			else if (bs["対象1"].PartGroup.Values.First().ToParT().PenColor == Color.Red)
    			{
    				g = Sta.GameData.鳥系;
    			}
    			else if (bs["対象2"].PartGroup.Values.First().ToParT().PenColor == Color.Red)
    			{
    				g = Sta.GameData.蛇系;
    			}
    			else if (bs["対象3"].PartGroup.Values.First().ToParT().PenColor == Color.Red)
    			{
    				g = Sta.GameData.獣系;
    			}
    			else if (bs["対象4"].PartGroup.Values.First().ToParT().PenColor == Color.Red)
    			{
    				g = Sta.GameData.水系;
    			}
    			else if (bs["対象5"].PartGroup.Values.First().ToParT().PenColor == Color.Red)
    			{
    				g = Sta.GameData.虫系;
    			}
    			else if (bs["対象6"].PartGroup.Values.First().ToParT().PenColor == Color.Red)
    			{
    				g = Sta.GameData.人型;
    			}
    			else if (bs["対象7"].PartGroup.Values.First().ToParT().PenColor == Color.Red)
    			{
    				g = Sta.GameData.幻獣;
    			}
    			else if (bs["対象8"].PartGroup.Values.First().ToParT().PenColor == Color.Red)
    			{
    				g = Sta.GameData.魔獣;
    			}
    			else if (bs["対象9"].PartGroup.Values.First().ToParT().PenColor == Color.Red)
    			{
    				g = Sta.GameData.竜系;
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
    		shapePartT14.Font = new Font("MS Gothic", 0.1f);
    		shapePartT14.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.9 * num);
    		shapePartT14.Text = GameText.チェンジ;
    		shapePartT14.FontSize = 0.15;
    		shapePartT14.SizeBase = 0.05;
    		shapePartT14.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT14.OP.ScalingY(shapePartT14.OP.GetCenter(), 0.5 * num);
    		shapePartT14.Closed = true;
    		shapePartT14.TextColor = Col.White;
    		shapePartT14.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT14.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT14.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT14.StringFormat.LineAlignment = StringAlignment.Center;
    		bs.Add("変更", new But1(shapePartT14, delegate
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
    		shapePartT15.Font = new Font("MS Gothic", 0.1f);
    		shapePartT15.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.98 * num);
    		shapePartT15.Text = GameText.購入;
    		shapePartT15.FontSize = 0.15;
    		shapePartT15.SizeBase = 0.05;
    		shapePartT15.OP.AddRange(new Out[1] { Shas.GetSquare() });
    		shapePartT15.OP.ScalingY(shapePartT15.OP.GetCenter(), 0.5 * num);
    		shapePartT15.Closed = true;
    		shapePartT15.TextColor = Col.White;
    		shapePartT15.BrushColor = Color.FromArgb(160, Col.Black);
    		shapePartT15.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
    		shapePartT15.StringFormat.Alignment = StringAlignment.Center;
    		shapePartT15.StringFormat.LineAlignment = StringAlignment.Center;
    		ulong 買値;
    		bs.Add("購入", new But1(shapePartT15, delegate
    		{
    			if (Sta.GameData.Is地下室一杯())
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
    			else if (Sta.GameData.所持金 < (買値 = (ulong)((double)u.GetPrice() * ((Sta.GameData.祝福 == Sta.GameData.ヴィオラ) ? 0.6 : 1.0))))
    			{
                    //TODO fix?
                    //Sounds.操作.Play();
    				ip.SubInfoIm = GameText.所持金が足りません;
    			}
    			else
    			{
    				u.Price = 買値;
    				Sta.GameData.所持金 -= 買値;
                    //TODO fix?
                    ////Sounds.精算.Play();
    				ip.UpdateSub2();
    				Sta.GameData.Add地下室(g.GetCharacter());
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
    			using (IEnumerator<But> enumerator = bs.EnumBut.Skip(3).Take(10).GetEnumerator())
    			{
    				while (enumerator.MoveNext() && !(enumerator.Current.PartGroup.Values.First().ToParT().PenColor == Color.Red))
    				{
    					num3++;
    				}
    			}
    			int num4 = Sta.GameData.系統開放.Count((bool e) => e) + 1;
    			int num5 = num3 - dt.Sign();
    			if (num5 < 0)
    			{
    				num5 = num4 - 1;
    			}
    			num5 %= num4;
    			But but = bs["対象" + num5];
    			but.Action(but);
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
    				bs["対象1"].Dra = Sta.GameData.系統開放[0];
    				bs["対象2"].Dra = Sta.GameData.系統開放[1];
    				bs["対象3"].Dra = Sta.GameData.系統開放[2];
    				bs["対象4"].Dra = Sta.GameData.系統開放[3];
    				bs["対象5"].Dra = Sta.GameData.系統開放[4];
    				bs["対象6"].Dra = Sta.GameData.系統開放[5];
    				bs["対象7"].Dra = Sta.GameData.系統開放[6];
    				bs["対象8"].Dra = Sta.GameData.系統開放[7];
    				bs["対象9"].Dra = Sta.GameData.系統開放[8];
    				if (Sta.RefreshStoreEveryTime)
    				{
    					Sta.GameData.新日 = true;
    				}
    				if (Sta.GameData.新日)
    				{
    					Sta.GameData.GenRefresh();
    					Sta.GameData.新日 = false;
    				}
    				Reload();
    				si.Set(bre: false);
    			}
    		};
    		DrawSlaveShop = delegate(RenderArea a, FPS FPS)
    		{
    			Med.HitGraphics.Clear(Col.Transparent);
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(Col.Transparent);
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
    		mod.Draw = delegate(FPS FPS)
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
    			bs["対象0"].PartGroup.Values.First().ToParT().PenColor = Color.Red;
    		};
    		return mod;
    	}

    	public static Module ToolShop(ModeEventDispatcher Med)
    	{
    		Module mod = new Module();
    		Buts bs = new Buts();

    		bs.Add("ボタン0", MyUI.Button2(Med, DrawBuffer, GameText.戻る, new Vector2D(0.85, 0.02), delegate
    		{
    			//Sounds.操作.Play();
    			if (Sta.GameData.初事務所フラグ)
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
    		Action<But, int, ulong> buy = delegate(But but, int ind, ulong pri)
    		{
    			if (Sta.GameData.所持金 >= pri)
    			{
    				but.Dra = false;
    				Sta.GameData.PurchasedTools[ind] = true;
    				Sta.GameData.所持金 -= pri;
    				//Sounds.精算.Play();
    				ip.UpdateSub2();
    				ip.TextIm = " ";
    				if (!lv.bs.EnumBut.Any((But e) => e.Dra))
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
    		
            
            lv = new ListView(DrawBuffer, DrawBuffer.GetPosition(0.01, 0.03), 0.5, new Font("MS Gothic", 1f), 0.07, Col.White, Col.Empty, Color.FromArgb(160, Col.Black), Col.Black, new TA(GameText.ﾃﾞｨﾙﾄﾞﾊﾞｲﾌﾞ + " 35,000,000", delegate(But b)
    		{
    			buy(b, 0, 35000000uL);
    		}), new TA(GameText.ﾉｰﾏﾙﾊﾞｲﾌﾞ + "   40,000,000", delegate(But b)
    		{
    			buy(b, 1, 40000000uL);
    		}), new TA(GameText.ﾄﾞﾘﾙﾊﾞｲﾌﾞ + "   60,000,000", delegate(But b)
    		{
    			buy(b, 2, 60000000uL);
    		}), new TA(GameText.ﾃﾞﾝﾏﾊﾞｲﾌﾞ + "   50,000,000", delegate(But b)
    		{
    			buy(b, 3, 50000000uL);
    		}), new TA(GameText.ｱﾅﾙﾊﾞｲﾌﾞ + "    45,000,000", delegate(But b)
    		{
    			buy(b, 4, 45000000uL);
    		}), new TA(GameText.調教鞭 + "      30,000,000", delegate(But b)
    		{
    			buy(b, 5, 30000000uL);
    		}), new TA(GameText.羽根箒 + "      20,000,000", delegate(But b)
    		{
    			buy(b, 6, 20000000uL);
    		}), new TA(GameText.T字剃刀 + "     20,000,000", delegate(But b)
    		{
    			buy(b, 7, 20000000uL);
    		}), new TA(GameText.振動ｷｬｯﾌﾟ + "   30,000,000", delegate(But b)
    		{
    			buy(b, 8, 30000000uL);
    		}), new TA(GameText.ﾋﾟﾝｸﾛｰﾀ + "     20,000,000", delegate(But b)
    		{
    			buy(b, 9, 20000000uL);
    		}), new TA(GameText.ｱﾅﾙﾊﾟｰﾙ + "     20,000,000", delegate(But b)
    		{
    			buy(b, 10, 20000000uL);
    		}), new TA(GameText.目隠帯 + "      25,000,000", delegate(But b)
    		{
    			buy(b, 11, 25000000uL);
    		}), new TA(GameText.玉口枷 + "      20,000,000", delegate(But b)
    		{
    			buy(b, 12, 20000000uL);
    		}), new TA(GameText.カメラ + "     100,000,000", delegate(But b)
    		{
    			buy(b, 13, 100000000uL);
    		}), new TA(GameText.ﾌﾛｱ増設 + "    300,000,000", delegate(But b)
    		{
    			ulong num = 300000000uL;
    			if (Sta.GameData.所持金 >= num)
    			{
    				Sta.GameData.フロア数++;
    				if (Sta.GameData.フロア数 == 9)
    				{
    					b.Dra = false;
    				}
    				Sta.GameData.所持金 -= num;
    				//Sounds.精算.Play();
    				ip.UpdateSub2();
    				ip.TextIm = " ";
    				if (!lv.bs.EnumBut.Any((But e) => e.Dra))
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
    			if (lv.bs.EnumBut.Any((But e) => e.Dra))
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
    					if (lv.bs["0"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.ペニスを模したバイブ + "\r\n" + GameText.刺激は控えめ;
    					}
    					if (lv.bs["1"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.一般的なバイブ + "\r\n" + GameText.ディルドバイブより刺激が強い;
    					}
    					if (lv.bs["2"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.振動と回転の2つの刺激をもたらすバイブ;
    					}
    					if (lv.bs["3"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.強力な振動のバイブ + "\r\n" + GameText.刺激が強い;
    					}
    					if (lv.bs["4"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.アナルの調教に適したバイブ;
    					}
    					if (lv.bs["5"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.痛みを与えるための道具;
    					}
    					if (lv.bs["6"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.緊張を解きほぐすために利用する;
    					}
    					if (lv.bs["7"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.陰毛を剃ることが出来る;
    					}
    					if (lv.bs["8"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.吸着振動するキャップ;
    					}
    					if (lv.bs["9"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.刺激の弱いバイブの一種;
    					}
    					if (lv.bs["10"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.アナルの調教に適した道具;
    					}
    					if (lv.bs["11"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.奴隷の視界を遮るための道具;
    					}
    					if (lv.bs["12"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.奴隷の口をふさぐための道具;
    					}
    					if (lv.bs["13"].PartGroup.Values.First().ToPar().HitColor == hc)
    					{
    						ip.TextIm = GameText.写真を撮影することが出来る;
    					}
    					if (lv.bs["14"].PartGroup.Values.First().ToPar().HitColor == hc)
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
    				lv.bs["0"].Dra = !Sta.GameData.PurchasedTools[0];
    				lv.bs["1"].Dra = !Sta.GameData.PurchasedTools[1];
    				lv.bs["2"].Dra = !Sta.GameData.PurchasedTools[2];
    				lv.bs["3"].Dra = !Sta.GameData.PurchasedTools[3];
    				lv.bs["4"].Dra = !Sta.GameData.PurchasedTools[4];
    				lv.bs["5"].Dra = !Sta.GameData.PurchasedTools[5];
    				lv.bs["6"].Dra = !Sta.GameData.PurchasedTools[6];
    				lv.bs["7"].Dra = !Sta.GameData.PurchasedTools[7];
    				lv.bs["8"].Dra = !Sta.GameData.PurchasedTools[8];
    				lv.bs["9"].Dra = !Sta.GameData.PurchasedTools[9];
    				lv.bs["10"].Dra = !Sta.GameData.PurchasedTools[10];
    				lv.bs["11"].Dra = !Sta.GameData.PurchasedTools[11];
    				lv.bs["12"].Dra = !Sta.GameData.PurchasedTools[12];
    				lv.bs["13"].Dra = !Sta.GameData.PurchasedTools[13];
    				lv.bs["14"].Dra = Sta.GameData.フロア数 < 9;
    				if (Sta.GameData.PurchasedTools.All((bool e) => e) && Sta.GameData.フロア数 == 9)
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
    		DrawToolShop = delegate(RenderArea a, FPS FPS)
    		{
    			Med.HitGraphics.Clear(Col.Transparent);
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(Col.Transparent);
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
    		mod.Draw = delegate(FPS FPS)
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
    				Sta.GameData.時間進行();
    				if (日利益額 != 0 || 日利子額 != 0)
    				{
    					if (日利益額 != 0)
    					{
    						Sta.GameData.所持金 = Sta.GameData.所持金.overflow_add(日利益額);
    					}
    					if (日利子額 != 0)
    					{
    						Sta.GameData.借金 = Sta.GameData.借金.overflow_add(日利子額);
    					}
    					//Sounds.精算.Play();
    					ip.UpdateSub2();
    				}
    				if (Sta.GameData.日数 >= 10)
    				{
    					Sta.GameData.利子 = 0.002;
    				}
    				Sta.GameData.需給更新();
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
    				if (TrainingTarget != null && Sta.GameData.TrainingTarget != null)
    				{
    					InitializeTrainingTarget();
    					妊娠状態反映();
    				}
    				si.Set(bre: false);
    			}
    		};
    		日数進行描画 = delegate(RenderArea a, FPS FPS)
    		{
    			if (TrainingTarget != null)
    			{
    				TrainingTarget.Motions.Drive(FPS);
    			}
    			Med.HitGraphics.Clear(Col.Transparent);
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(Col.Transparent);
    			}
    			a.Draw(BlackBackground);
    			ip.Draw(a, FPS);
    			Med.Draw(a);
    		};
    		obj.Draw = delegate(FPS FPS)
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
    		But1 完了 = MyUI.Button(Med, DrawBuffer, GameText.完了, new Vector2D(num2 + 0.19, num3 + 0.72), delegate
    		{
    			Sta.GameData.配色 = new 主人公配色(Sta.GameData.色);
    			Player.UI.ハンド右.再配色(Sta.GameData.配色);
    			Player.UI.ハンド左.再配色(Sta.GameData.配色);
    			Player.UI.ペニス.再配色(Sta.GameData.配色);
    			Player.UI.マウス.再配色(Sta.GameData.配色);
    			Sta.GameData.プレーヤー = Generator.プレーヤー();
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
    		Labs ls = new Labs(Med, DrawBuffer);
    		ls.Add("ラベル0", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 - 0.1)), 0.1, 2.5, new Font("MS Gothic", 1f), 0.085, " ", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル1", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, GameText.肌の色, Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル2", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル3", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "S:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル4", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.127)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "V:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル5", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, GameText.髪の色, Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル6", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル7", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "S:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル8", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.127)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "V:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル9", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, GameText.瞳の色, Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル10", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル11", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "S:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル12", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.127)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "V:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル13", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 3.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, GameText.体格, Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル14", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 3.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		ls.Add("ラベル15", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 3.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "W:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
    		Gau H肌 = new Gau("H肌", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 0.0 + 0.06)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
    		H肌.Gauge.PenColor = Col.White;
    		H肌.Frame1.PenColor = Col.White;
    		H肌.Knob.PenColor = Col.White;
    		H肌.Knob.HitColor = Med.GetUniqueColor();
    		Gau S肌 = new Gau("S肌", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 0.0 + 0.1)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
    		S肌.Gauge.PenColor = Col.White;
    		S肌.Frame1.PenColor = Col.White;
    		S肌.Knob.PenColor = Col.White;
    		S肌.Knob.HitColor = Med.GetUniqueColor();
    		Gau V肌 = new Gau("V肌", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 0.0 + 0.14)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
    		V肌.Gauge.PenColor = Col.White;
    		V肌.Frame1.PenColor = Col.White;
    		V肌.Knob.PenColor = Col.White;
    		V肌.Knob.HitColor = Med.GetUniqueColor();
    		Gau H髪 = new Gau("H髪", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 1.0 + 0.06)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
    		H髪.Gauge.PenColor = Col.White;
    		H髪.Frame1.PenColor = Col.White;
    		H髪.Knob.PenColor = Col.White;
    		H髪.Knob.HitColor = Med.GetUniqueColor();
    		Gau S髪 = new Gau("S髪", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 1.0 + 0.1)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
    		S髪.Gauge.PenColor = Col.White;
    		S髪.Frame1.PenColor = Col.White;
    		S髪.Knob.PenColor = Col.White;
    		S髪.Knob.HitColor = Med.GetUniqueColor();
    		Gau V髪 = new Gau("V髪", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 1.0 + 0.14)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
    		V髪.Gauge.PenColor = Col.White;
    		V髪.Frame1.PenColor = Col.White;
    		V髪.Knob.PenColor = Col.White;
    		V髪.Knob.HitColor = Med.GetUniqueColor();
    		Gau H瞳 = new Gau("H瞳", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 2.0 + 0.06)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
    		H瞳.Gauge.PenColor = Col.White;
    		H瞳.Frame1.PenColor = Col.White;
    		H瞳.Knob.PenColor = Col.White;
    		H瞳.Knob.HitColor = Med.GetUniqueColor();
    		Gau S瞳 = new Gau("S瞳", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 2.0 + 0.1)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
    		S瞳.Gauge.PenColor = Col.White;
    		S瞳.Frame1.PenColor = Col.White;
    		S瞳.Knob.PenColor = Col.White;
    		S瞳.Knob.HitColor = Med.GetUniqueColor();
    		Gau V瞳 = new Gau("V瞳", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 2.0 + 0.14)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
    		V瞳.Gauge.PenColor = Col.White;
    		V瞳.Frame1.PenColor = Col.White;
    		V瞳.Knob.PenColor = Col.White;
    		V瞳.Knob.HitColor = Med.GetUniqueColor();
    		Gau 身長 = new Gau("身長", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 3.0 + 0.06)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
    		身長.Gauge.PenColor = Col.White;
    		身長.Frame1.PenColor = Col.White;
    		身長.Knob.PenColor = Col.White;
    		身長.Knob.HitColor = Med.GetUniqueColor();
    		Gau 体重 = new Gau("体重", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 3.0 + 0.1)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, _2DGAMELIB.Range.ZeroOne, DrawBuffer.DisplayUnitScale, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
    		体重.Gauge.PenColor = Col.White;
    		体重.Frame1.PenColor = Col.White;
    		体重.Knob.PenColor = Col.White;
    		体重.Knob.HitColor = Med.GetUniqueColor();
    		Hsv hsv = HSV.ToHSV(ref Sta.GameData.色.肌色);
    		H肌.Value = (double)hsv.H / 360.0;
    		S肌.Value = (double)hsv.S / 255.0;
    		V肌.Value = (double)hsv.V / 255.0;
    		H肌.Base.BrushColor = Sta.GameData.色.肌色;
    		S肌.Base.BrushColor = Sta.GameData.色.肌色;
    		V肌.Base.BrushColor = Sta.GameData.色.肌色;
    		ls["ラベル2"].Text = "H:" + hsv.H;
    		ls["ラベル3"].Text = "S:" + hsv.S;
    		ls["ラベル4"].Text = "V:" + hsv.V;
    		hsv = HSV.ToHSV(ref Sta.GameData.色.髪色);
    		H髪.Value = (double)hsv.H / 360.0;
    		S髪.Value = (double)hsv.S / 255.0;
    		V髪.Value = (double)hsv.V / 255.0;
    		H髪.Base.BrushColor = Sta.GameData.色.髪色;
    		S髪.Base.BrushColor = Sta.GameData.色.髪色;
    		V髪.Base.BrushColor = Sta.GameData.色.髪色;
    		ls["ラベル6"].Text = "H:" + hsv.H;
    		ls["ラベル7"].Text = "S:" + hsv.S;
    		ls["ラベル8"].Text = "V:" + hsv.V;
    		hsv = HSV.ToHSV(ref Sta.GameData.色.瞳色);
    		H瞳.Value = (double)hsv.H / 360.0;
    		S瞳.Value = (double)hsv.S / 255.0;
    		V瞳.Value = (double)hsv.V / 255.0;
    		H瞳.Base.BrushColor = Sta.GameData.色.瞳色;
    		S瞳.Base.BrushColor = Sta.GameData.色.瞳色;
    		V瞳.Base.BrushColor = Sta.GameData.色.瞳色;
    		ls["ラベル10"].Text = "H:" + hsv.H;
    		ls["ラベル11"].Text = "S:" + hsv.S;
    		ls["ラベル12"].Text = "V:" + hsv.V;
    		身長.Value = Sta.GameData.身長;
    		体重.Value = Sta.GameData.体重;
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
    				HSV.ToRGB(h, s, v, out Sta.GameData.色.肌色);
    				H肌.Base.BrushColor = Sta.GameData.色.肌色;
    				S肌.Base.BrushColor = Sta.GameData.色.肌色;
    				V肌.Base.BrushColor = Sta.GameData.色.肌色;
    				ls["ラベル2"].Text = "H:" + h;
    				ls["ラベル3"].Text = "S:" + s;
    				ls["ラベル4"].Text = "V:" + v;
    				H髪.Move(ref cp);
    				S髪.Move(ref cp);
    				V髪.Move(ref cp);
    				h = (int)(360.0 * H髪.Value);
    				s = (int)(255.0 * S髪.Value);
    				v = (int)(255.0 * V髪.Value);
    				HSV.ToRGB(h, s, v, out Sta.GameData.色.髪色);
    				H髪.Base.BrushColor = Sta.GameData.色.髪色;
    				S髪.Base.BrushColor = Sta.GameData.色.髪色;
    				V髪.Base.BrushColor = Sta.GameData.色.髪色;
    				ls["ラベル6"].Text = "H:" + h;
    				ls["ラベル7"].Text = "S:" + s;
    				ls["ラベル8"].Text = "V:" + v;
    				H瞳.Move(ref cp);
    				S瞳.Move(ref cp);
    				V瞳.Move(ref cp);
    				h = (int)(360.0 * H瞳.Value);
    				s = (int)(255.0 * S瞳.Value);
    				v = (int)(255.0 * V瞳.Value);
    				HSV.ToRGB(h, s, v, out Sta.GameData.色.瞳色);
    				H瞳.Base.BrushColor = Sta.GameData.色.瞳色;
    				S瞳.Base.BrushColor = Sta.GameData.色.瞳色;
    				V瞳.Base.BrushColor = Sta.GameData.色.瞳色;
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
    			hsv = HSV.ToHSV(ref Sta.GameData.色.肌色);
    			H肌.Value = (double)hsv.H / 360.0;
    			S肌.Value = (double)hsv.S / 255.0;
    			V肌.Value = (double)hsv.V / 255.0;
    			H肌.Base.BrushColor = Sta.GameData.色.肌色;
    			S肌.Base.BrushColor = Sta.GameData.色.肌色;
    			V肌.Base.BrushColor = Sta.GameData.色.肌色;
    			ls["ラベル2"].Text = "H:" + hsv.H;
    			ls["ラベル3"].Text = "S:" + hsv.S;
    			ls["ラベル4"].Text = "V:" + hsv.V;
    			hsv = HSV.ToHSV(ref Sta.GameData.色.髪色);
    			H髪.Value = (double)hsv.H / 360.0;
    			S髪.Value = (double)hsv.S / 255.0;
    			V髪.Value = (double)hsv.V / 255.0;
    			H髪.Base.BrushColor = Sta.GameData.色.髪色;
    			S髪.Base.BrushColor = Sta.GameData.色.髪色;
    			V髪.Base.BrushColor = Sta.GameData.色.髪色;
    			ls["ラベル6"].Text = "H:" + hsv.H;
    			ls["ラベル7"].Text = "S:" + hsv.S;
    			ls["ラベル8"].Text = "V:" + hsv.V;
    			hsv = HSV.ToHSV(ref Sta.GameData.色.瞳色);
    			H瞳.Value = (double)hsv.H / 360.0;
    			S瞳.Value = (double)hsv.S / 255.0;
    			V瞳.Value = (double)hsv.V / 255.0;
    			H瞳.Base.BrushColor = Sta.GameData.色.瞳色;
    			S瞳.Base.BrushColor = Sta.GameData.色.瞳色;
    			V瞳.Base.BrushColor = Sta.GameData.色.瞳色;
    			ls["ラベル10"].Text = "H:" + hsv.H;
    			ls["ラベル11"].Text = "S:" + hsv.S;
    			ls["ラベル12"].Text = "V:" + hsv.V;
    			身長.Value = Sta.GameData.身長;
    			体重.Value = Sta.GameData.体重;
    			ls["ラベル14"].Text = "H:" + $"{身長.Value:0.00}";
    			ls["ラベル15"].Text = "W:" + $"{体重.Value:0.00}";
    		};
    		PlayerInformationSliders = delegate(RenderArea a, FPS FPS)
    		{
    			Med.HitGraphics.Clear(Col.Transparent);
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(Col.Transparent);
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
    		mod.Draw = delegate(FPS FPS)
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
    		DrawOP0 = delegate(RenderArea a, FPS FPS)
    		{
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(Col.Transparent);
    			}
    			a.Draw(BlackBackground);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FPS FPS)
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
    		Action<Tex> d = delegate
    		{
    			ip.SubInfo = GameText.安い額ではない;
    			ip.選択yAct = delegate
    			{
    				//Sounds.操作.Play();
    				ViolaTextBubble.Tex.Done = delegate
    				{
    					//Sounds.精算.Play();
    					Sta.GameData.借金 = 5000000000uL;
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
    				ViolaTextBubble.Tex.Done = delegate
    				{
    					//Sounds.精算.Play();
    					Sta.GameData.借金 = 5000000000uL;
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
    			if (!ViolaTextBubble.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying)
    			{
    				if (wi == i && i != 10 && ViolaTextBubble.Tex.Done == null)
    				{
    					i++;
    					wi = i;
    					if (i < tsp.Length)
    					{
    						if (i == 10)
    						{
    							ViolaTextBubble.Tex.Done = d;
    						}
    						else
    						{
    							ViolaTextBubble.Tex.Done = null;
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
    			Sta.GameData.ヴィオラ = new Unit();
    			Sta.GameData.ヴィオラ.SetViola(Med, DrawBuffer);
    			Viola = new Character(Med, DrawBuffer, Sta.GameData.ヴィオラ.ChaD);
    			Viola.Set衣装(Sta.GameData.ヴィオラ.着衣);
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
    		DrawOP1 = delegate(RenderArea a, FPS FPS)
    		{
    			a.Draw(OfficeBackground);
    			Viola.Draw(a, FPS);
    			ViolaTextBubble.Draw(a, FPS);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FPS FPS)
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
    			if (!ViolaTextBubble.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
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
    		説明描画 = delegate(RenderArea a, FPS FPS)
    		{
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(Col.Transparent);
    			}
    			a.Draw(BasementBackground);
    			Viola.Draw(a, FPS);
    			ViolaTextBubble.Draw(a, FPS);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FPS FPS)
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
    			GameText.借金には1日 + Sta.GameData.利子 * 100.0 + GameText.の利子がつくわよ + "  \r\n" + GameText.良心的よねうふふ,
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
    		Action<Tex> d1 = delegate
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
    		Action<Tex> d2 = delegate
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
    						ViolaTextBubble.Tex.Feed.Dra = true;
    						Sta.GameData.利子 *= 2.0;
    					};
    					ViolaTextBubble.Tex.Feed.Dra = false;
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
    			if (!ViolaTextBubble.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying)
    			{
    				if (wi == i && i != 1 && i != 6 && ViolaTextBubble.Tex.Done == null)
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
    							ViolaTextBubble.Tex.Done = d1;
    						}
    						else if (i == 6)
    						{
    							ViolaTextBubble.Tex.Done = d2;
    						}
    						else
    						{
    							ViolaTextBubble.Tex.Done = null;
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
    						Sta.GameData.初事務所フラグ = false;
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
    			ViolaTextBubble.Tex.Feed.Dra = true;
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
    		初事務所描画 = delegate(RenderArea a, FPS FPS)
    		{
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(Col.Transparent);
    			}
    			a.Draw(OfficeBackground);
    			Viola.Draw(a, FPS);
    			ViolaTextBubble.Draw(a, FPS);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FPS FPS)
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
    			if (!ViolaTextBubble.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
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
    			ViolaTextBubble.Tex.Feed.Dra = true;
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
    		返済イベント描画 = delegate(RenderArea a, FPS FPS)
    		{
    			if (a.HitGraphics != null)
    			{
    				a.HitGraphics.Clear(Col.Transparent);
    			}
    			a.Draw(OfficeBackground);
    			Viola.Draw(a, FPS);
    			ViolaTextBubble.Draw(a, FPS);
    			dbs.Draw(a);
    			ip.Draw(a, FPS);
    			Med.Draw(a);
    		};
    		mod.Draw = delegate(FPS FPS)
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
    			if (!ViolaTextBubble.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
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
    			ViolaTextBubble.Tex.Feed.Dra = true;
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
    		mod.Draw = delegate(FPS FPS)
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
    		Action<Tex> d1 = delegate
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
    			if (!ViolaTextBubble.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying)
    			{
    				if (wi == i && i != 2 && ViolaTextBubble.Tex.Done == null)
    				{
    					i++;
    					wi = i;
    					if (i < tsp.Length)
    					{
    						if (i == 2)
    						{
    							ViolaTextBubble.Tex.Done = d1;
    						}
    						else
    						{
    							ViolaTextBubble.Tex.Done = null;
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
    						Sta.GameData.初事務所フラグ = false;
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
    			ViolaTextBubble.Tex.Feed.Dra = true;
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
    		mod.Draw = delegate(FPS FPS)
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
    			if (!ViolaTextBubble.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
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
    			ViolaTextBubble.Tex.Feed.Dra = true;
    			Viola.両目_見つめ();
    			Viola.表情_基本0();
    			Viola.Set基本姿勢();
    			i = 0;
    			wi = 0;
    			sfc[i]();
    			ViolaTextBubble.Text = tsc[i];
    			ip.Text = tsp[i];
    			ip.SubInfo = sub[i];
    			Sta.GameData.祝福 = Sta.GameData.ヴィオラ;
    		};
    		mod.Draw = delegate(FPS FPS)
    		{
    			SwitchMode(Med, DrawBuffer, FPS, 返済イベント描画);
    		};
    		mod.Dispose = delegate
    		{
    		};
    		return mod;
    	}

    	static Mods()
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
    		if (Sta.SensesButton)
    		{
                double x = 0.6;
                double y = 0.9075;
                if (Sta.BigWindow)
                {
                    x = 0.695;
                    y = 0.932;
                }

                dbs.Add("Senses", MyUI.Button(med, DrawBuffer, "Senses", new Vector2D(x, y), delegate
                {
                    //Sounds.操作.Play();
                    Sta.ShowSenses = !Sta.ShowSenses;
                }));
            }
    		if (Sta.JsonButton)
    		{
                {
                    double x = 0.6;
                    double y = 0.9075;
                    if (Sta.BigWindow)
                    {
                        x = 0.695;
                        y = 0.932;
                        if (Sta.SensesButton)
                        {
                            x = 0.62;
                        }
                    }
                    if (!Sta.BigWindow && Sta.SensesButton)
                    {
                        x = 0.5;
                    }

                    dbs.Add("SaveJSON", MyUI.Button(med, DrawBuffer, "SaveJSON", new Vector2D(x, y), delegate
                    {
                        //Sounds.操作.Play();
                        SaveData.bs["0"].Dra = false;
                        save = true;
                        SetJSLlv(med);
                        Color HitColor = Col.Empty;
                        SaveData.Move(ref HitColor);
                        SDShow = true;
                        ip.SubInfoIm = "RCl:" + GameText.戻る;
                    }));
                }

                {
                    double y = 0.9075;
                    double x = 0.5;
                    if (Sta.BigWindow)
                    {
                        x = 0.62;
                        y = 0.932;
                        if (Sta.SensesButton)
                        {
                            x = 0.545;
                        }
                    }
                    if (!Sta.BigWindow && Sta.SensesButton)
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
                        Color HitColor = Col.Empty;
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
    		if (Sta.GameData.TrainingTarget != null)
    		{
    			int num = int.Parse(Sta.GameData.TrainingTarget.Number) - 1;
    			if (Sta.GameData.Slaves[num + 1] != null)
    			{
    				Unit unit = Sta.GameData.Slaves[num];
    				Unit unit2 = Sta.GameData.Slaves[num + 1];
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
    				Sta.GameData.Slaves[num] = unit2;
    				Sta.GameData.Slaves[num + 1] = unit;
    				Sta.GameData.TrainingTarget = Sta.GameData.Slaves[num + 1];
    			}
    		}
    	}

    	public static void MoveRoomUp()
    	{
    		if (Sta.GameData.TrainingTarget != null)
    		{
    			int num = int.Parse(Sta.GameData.TrainingTarget.Number) - 1;
    			if (num != 0 && Sta.GameData.Slaves[num - 1] != null)
    			{
    				Unit unit = Sta.GameData.Slaves[num];
    				Unit unit2 = Sta.GameData.Slaves[num - 1];
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
    				Sta.GameData.Slaves[num] = unit2;
    				Sta.GameData.Slaves[num - 1] = unit;
    				Sta.GameData.TrainingTarget = Sta.GameData.Slaves[num - 1];
    			}
    		}
    	}

    	public static void MoveFloorDown()
    	{
    		if (Sta.GameData.TrainingTarget == null)
    		{
    			return;
    		}
    		for (int i = 0; i < 15; i++)
    		{
    			int num = int.Parse(Sta.GameData.TrainingTarget.Number) - 1;
    			if (Sta.GameData.Slaves[num + 1] == null)
    			{
    				break;
    			}
    			Unit unit = Sta.GameData.Slaves[num];
    			Unit unit2 = Sta.GameData.Slaves[num + 1];
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
    			Sta.GameData.Slaves[num] = unit2;
    			Sta.GameData.Slaves[num + 1] = unit;
    			Sta.GameData.TrainingTarget = Sta.GameData.Slaves[num + 1];
    		}
    	}

    	public static void MoveFloorUp()
    	{
    		if (Sta.GameData.TrainingTarget == null)
    		{
    			return;
    		}
    		for (int i = 0; i < 15; i++)
    		{
    			int num = int.Parse(Sta.GameData.TrainingTarget.Number) - 1;
    			if (num == 0 || Sta.GameData.Slaves[num - 1] == null)
    			{
    				break;
    			}
    			Unit unit = Sta.GameData.Slaves[num];
    			Unit unit2 = Sta.GameData.Slaves[num - 1];
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
    			Sta.GameData.Slaves[num] = unit2;
    			Sta.GameData.Slaves[num - 1] = unit;
    			Sta.GameData.TrainingTarget = Sta.GameData.Slaves[num - 1];
    		}
    	}
    }
}
