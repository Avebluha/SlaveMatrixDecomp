using _2DGAMELIB;
using SlaveMatrix.GameClasses;
using System.Drawing;

namespace SlaveMatrix
{
    public static class SpeciesDefaults
    {
    	public static double 葉倍率 = 0.8;

    	public static void AdjustScale(this WaistD Waist, HeadD 頭)
    	{
    		foreach (ElementData item in 頭.EnumEleD())
    		{
    			if (!(item is 後髪0D) && !(item is BackHair1D) && !(item is SideHairD) && !(item is 前髪D))
    			{
    				item.尺度B *= 0.98;
    			}
    		}
    		foreach (ElementData item2 in Waist.EnumEleD())
    		{
    			item2.尺度B *= 1.065;
    		}
    	}

    	public static void SetLowerHair(this WaistD Waist)
    	{
    		WaistSkinD eleD = Waist.肌_接続.GetEleD<WaistSkinD>();
    		if (eleD.獣性_獣毛_表示)
    		{
    			if (Rng.XS.NextBool())
    			{
    				eleD.獣性_獣毛_表示 = false;
    				eleD.陰毛_表示 = true;
    			}
    		}
    		else if (eleD.陰毛_表示)
    		{
    			if (0.023.Lot())
    			{
    				eleD.陰毛_表示 = false;
    			}
    		}
    		else if (0.023.Inverse().Lot())
    		{
    			eleD.陰毛_表示 = true;
    		}
    	}

    	public static CharacterData GetHarpy()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		switch (Rng.XS.Next(4))
    		{
    		case 0:
    			頭D2.Set耳人();
    			break;
    		case 1:
    			頭D2.Set耳尖();
    			break;
    		case 2:
    			頭D2.Set耳獣();
    			break;
    		default:
    			頭D2.Set耳羽();
    			break;
    		}
    		手_鳥D 手_鳥D2 = new 手_鳥D
    		{
    			シャープ = Rng.XS.NextDouble()
    		};
    		LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D
    		{
    			シャープ = 手_鳥D2.シャープ
    		};
    		LowerArm_鳥D2.手接続(手_鳥D2);
    		UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D
    		{
    			シャープ = LowerArm_鳥D2.シャープ
    		};
    		UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_鳥D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		ChestD2.背中接続(new 背中_羽D());
    		足_鳥D e = new 足_鳥D();
    		Leg_鳥D Leg_鳥D2 = new Leg_鳥D();
    		Leg_鳥D2.足接続(e);
    		腿_鳥D 腿_鳥D2 = new 腿_鳥D();
    		腿_鳥D2.Leg接続(Leg_鳥D2);
    		WaistD2.腿左接続(腿_鳥D2);
    		WaistD2.腿右接続(腿_鳥D2.Get逆());
    		WaistD2.尾接続(new 尾_鳥D());
    		bool flag = 頭D2.EnumEleD().IsEleD<耳_羽D>() || 頭D2.EnumEleD().IsEleD<耳_獣D>();
    		WaistD2.EnumEleD().SetValuesD("獣性", flag);
    		WaistD2.EnumEleD().SetValuesD<頬肌D>("髭", false);
    		if (flag)
    		{
    			WaistD2.EnumEleD().SetValuesD<胸毛D>("表示", Rng.XS.NextBool());
    		}
    		else
    		{
    			WaistD2.EnumEleD().SetValuesD<胸毛D>("表示", false);
    		}
    		WaistD2.EnumEleD().SetValuesD<WaistSkinD>("獣性", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getアフール()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻R();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		ElementData eleD2 = new 獣耳D
    		{
    			尺度B = 1.2
    		};
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_蝙D e = new 手_蝙D();
    		LowerArm_蝙D LowerArm_蝙D2 = new LowerArm_蝙D();
    		LowerArm_蝙D2.手接続(e);
    		UpperArm_蝙D UpperArm_蝙D2 = new UpperArm_蝙D();
    		UpperArm_蝙D2.LowerArm接続(LowerArm_蝙D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_蝙D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		足_獣D e2 = new 足_獣D();
    		Leg_獣D Leg_獣D2 = new Leg_獣D();
    		Leg_獣D2.足接続(e2);
    		腿_獣D 腿_獣D2 = new 腿_獣D();
    		腿_獣D2.Leg接続(Leg_獣D2);
    		obj.腿左接続(腿_獣D2);
    		obj.腿右接続(腿_獣D2.Get逆());
    		obj.尾接続(new 尾_悪D());
    		obj.EnumEleD().SetValuesD("獣性", true);
    		obj.EnumEleD().SetValuesD<頬肌D>("髭", false);
    		obj.EnumEleD().SetValuesD<胸毛D>("表示", Rng.XS.NextBool());
    		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getハルピュイア()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		if (Rng.XS.NextBool())
    		{
    			頭D2.Set耳人();
    		}
    		else
    		{
    			頭D2.Set耳尖();
    		}
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		手_蝙D e2 = new 手_蝙D
    		{
    			シャープ = 1.0
    		};
    		LowerArm_蝙D LowerArm_蝙D2 = new LowerArm_蝙D();
    		LowerArm_蝙D2.手接続(e2);
    		UpperArm_蝙D UpperArm_蝙D2 = new UpperArm_蝙D();
    		UpperArm_蝙D2.LowerArm接続(LowerArm_蝙D2);
    		obj2.翼上左接続(UpperArm_蝙D2);
    		obj2.翼上右接続(UpperArm_蝙D2.Get逆());
    		長物_鯨D 長物_鯨D2 = new 長物_鯨D();
    		obj.半身接続(長物_鯨D2);
    		長物_鯨D2.尾接続(new 尾_鯨D());
    		obj.EnumEleD().SetValuesD<UpperArm_人D>("獣毛1", true);
    		obj.EnumEleD().SetValuesD<LowerArm_人D>("獣腕", true);
    		obj.EnumEleD().SetValuesD<手_人D>("獣性", true);
    		obj.EnumEleD().SetValuesD<手_人D>("肉球", false);
    		obj.EnumEleD().SetValuesD<LowerArm_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD("柄", false);
    		obj.EnumEleD().SetValuesD("紋柄", true);
    		obj.EnumEleD().SetValuesD<鼻肌D>("紋柄", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData GetPhoenix()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳羽();
    		手_鳥D 手_鳥D2 = new 手_鳥D
    		{
    			シャープ = Rng.XS.NextDouble()
    		};
    		LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D
    		{
    			シャープ = 手_鳥D2.シャープ
    		};
    		LowerArm_鳥D2.手接続(手_鳥D2);
    		UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D
    		{
    			シャープ = LowerArm_鳥D2.シャープ
    		};
    		UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_鳥D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		obj2.背中接続(new 背中_羽D());
    		足_鳥D e = new 足_鳥D();
    		Leg_鳥D Leg_鳥D2 = new Leg_鳥D();
    		Leg_鳥D2.足接続(e);
    		腿_鳥D 腿_鳥D2 = new 腿_鳥D();
    		腿_鳥D2.Leg接続(Leg_鳥D2);
    		obj.腿左接続(腿_鳥D2);
    		obj.腿右接続(腿_鳥D2.Get逆());
    		obj.尾接続(new 鳳凰D());
    		obj.尾接続(new 鳳凰D());
    		obj.尾接続(new 鳳凰D());
    		obj.尾接続(new 鳳凰D());
    		obj.尾接続(new 鳳凰D());
    		obj.尾接続(new 尾_鳥D());
    		obj.EnumEleD().SetValuesD("獣性", true);
    		obj.EnumEleD().SetValuesD<頬肌D>("髭", false);
    		obj.EnumEleD().SetValuesD("隈取", true);
    		頭D2.隈取_タトゥ_表示 = false;
    		obj.EnumEleD().SetValuesD("淫", true);
    		obj.EnumEleD().SetValuesD("ハート", false);
    		obj.SetValuesD("悪", true);
    		obj.EnumEleD().SetValuesD("植", true);
    		obj.EnumEleD().SetValuesD<足_鳥D>("竜性", true);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getラミア()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = obj.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌長();
    		if (Rng.XS.NextBool())
    		{
    			頭D2.Set耳人();
    		}
    		else
    		{
    			頭D2.Set耳尖();
    		}
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
    		WaistD2.半身接続(長物_蛇D2);
    		長物_蛇D2.くぱぁ = 1.0;
    		長物_蛇D2.ガード = false;
    		Torso_蛇D Torso_蛇D2 = new Torso_蛇D();
    		長物_蛇D2.胴接続(Torso_蛇D2);
    		for (int i = 0; i < 40; i++)
    		{
    			Torso_蛇D2.Torso接続(Torso_蛇D2 = new Torso_蛇D());
    		}
    		Torso_蛇D2.Torso接続(new 尾_ヘD());
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD<Tounge_長D>("股舌表示", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getシーラミア()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = obj.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌長();
    		頭D2.Set耳鰭();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
    		WaistD2.半身接続(長物_蛇D2);
    		if (Rng.XS.NextBool())
    		{
    			長物_蛇D2.くぱぁ = 1.0;
    			長物_蛇D2.ガード = false;
    		}
    		Torso_蛇D 胴_蛇D2 = new Torso_蛇D();
    		長物_蛇D2.胴接続(胴_蛇D2);
    		for (int i = 0; i < 40; i++)
    		{
    			胴_蛇D2.Torso接続(胴_蛇D2 = new Torso_蛇D());
    		}
    		胴_蛇D2.Torso接続(new 尾_ウD());
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD<Tounge_長D>("股舌表示", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getオノケンタウレ()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳獣();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		obj.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		手_馬D e2 = new 手_馬D();
    		LowerArm_蹄D LowerArm_蹄D2 = new LowerArm_蹄D();
    		LowerArm_蹄D2.手接続(e2);
    		UpperArm_蹄D UpperArm_蹄D2 = new UpperArm_蹄D();
    		UpperArm_蹄D2.LowerArm接続(LowerArm_蹄D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_蹄D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_馬D e3 = new 足_馬D();
    		Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    		Leg_蹄D2.足接続(e3);
    		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    		腿_蹄D2.Leg接続(Leg_蹄D2);
    		四足腰D2.腿左接続(腿_蹄D2);
    		四足腰D2.腿右接続(腿_蹄D2.Get逆());
    		四足腰D2.尾接続(new 尾_牛D());
    		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<WaistSkinD>("獣性", true);
    		四足腰D2.EnumEleD().SetValuesD<WaistSkinD>("獣性", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 0.0);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getヒッポケンタウレ()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		if (Rng.XS.Next(2) == 0)
    		{
    			頭D2.Set耳人();
    		}
    		else
    		{
    			頭D2.Set耳尖();
    		}
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		WaistD2.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		手_馬D e2 = new 手_馬D();
    		LowerArm_蹄D LowerArm_蹄D2 = new LowerArm_蹄D();
    		LowerArm_蹄D2.手接続(e2);
    		UpperArm_蹄D UpperArm_蹄D2 = new UpperArm_蹄D();
    		UpperArm_蹄D2.LowerArm接続(LowerArm_蹄D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_蹄D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_馬D e3 = new 足_馬D();
    		Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    		Leg_蹄D2.足接続(e3);
    		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    		腿_蹄D2.Leg接続(Leg_蹄D2);
    		四足腰D2.腿左接続(腿_蹄D2);
    		四足腰D2.腿右接続(腿_蹄D2.Get逆());
    		四足腰D2.尾接続(new 尾_馬D());
    		if (Rng.XS.NextBool())
    		{
    			WaistD2.EnumEleD().SetValuesD<HeadD>("馬", Rng.XS.NextBool());
    		}
    		WaistD2.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD<WaistSkinD>("獣性", true);
    		四足腰D2.EnumEleD().SetValuesD<WaistSkinD>("獣性", false);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getブケンタウレ()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳獣();
    		ElementData eleD2 = Rng.XS.Next(4) switch
    		{
    			0 => new 角2_牛1D(), 
    			1 => new 角2_牛2D(), 
    			2 => new 角2_牛3D(), 
    			_ => new 角2_牛4D(), 
    		};
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		WaistD2.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		手_牛D e2 = new 手_牛D();
    		LowerArm_蹄D LowerArm_蹄D2 = new LowerArm_蹄D();
    		LowerArm_蹄D2.手接続(e2);
    		UpperArm_蹄D UpperArm_蹄D2 = new UpperArm_蹄D();
    		UpperArm_蹄D2.LowerArm接続(LowerArm_蹄D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_蹄D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_牛D e3 = new 足_牛D();
    		Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    		Leg_蹄D2.足接続(e3);
    		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    		腿_蹄D2.Leg接続(Leg_蹄D2);
    		四足腰D2.腿左接続(腿_蹄D2);
    		四足腰D2.腿右接続(腿_蹄D2.Get逆());
    		四足腰D2.尾接続(new 尾_牛D());
    		if (Rng.XS.NextBool())
    		{
    			WaistD2.EnumEleD().SetValuesD<頬肌D>("牛", true);
    			WaistD2.EnumEleD().SetValuesD<四足脇D>("配色指定", 配色指定.H0);
    		}
    		WaistD2.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD<WaistSkinD>("獣性", true);
    		四足腰D2.EnumEleD().SetValuesD<WaistSkinD>("獣性", false);
    		WaistD2.EnumEleD().SetValuesD("バスト", 1.0);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getカプラケンタウレ()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳獣();
    		ElementData eleD2 = Rng.XS.Next(4) switch
    		{
    			0 => new 角2_山1D(), 
    			1 => new 角2_山2D(), 
    			2 => new 角2_山3D(), 
    			_ => new 角2_巻D(), 
    		};
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		WaistD2.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		四足胸D2.背中接続(new 背中_羽D
    		{
    			毛 = true
    		});
    		手_牛D e2 = new 手_牛D();
    		LowerArm_蹄D LowerArm_蹄D2 = new LowerArm_蹄D();
    		LowerArm_蹄D2.手接続(e2);
    		UpperArm_蹄D UpperArm_蹄D2 = new UpperArm_蹄D();
    		UpperArm_蹄D2.LowerArm接続(LowerArm_蹄D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_蹄D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_牛D e3 = new 足_牛D();
    		Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    		Leg_蹄D2.足接続(e3);
    		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    		腿_蹄D2.Leg接続(Leg_蹄D2);
    		四足腰D2.腿左接続(腿_蹄D2);
    		四足腰D2.腿右接続(腿_蹄D2.Get逆());
    		四足腰D2.尾接続(new 尾_犬D());
    		四足胴D2.SetValuesD("獣毛", true);
    		WaistD2.EnumEleD().SetValuesD("胸毛", true);
    		WaistD2.EnumEleD().SetValuesD<WaistSkinD>("獣毛", true);
    		WaistD2.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD<双目D>("蛸目", Rng.XS.NextBool());
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getマーメイド()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳人();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		長物_魚D 長物_魚D2 = new 長物_魚D();
    		obj.半身接続(長物_魚D2);
    		尾_魚D 尾_魚D2 = new 尾_魚D();
    		長物_魚D2.尾接続(尾_魚D2);
    		尾_魚D2.尾先接続(new 尾鰭_魚D());
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getドルフィンマーメイド()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳尖();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		長物_鯨D 長物_鯨D2 = new 長物_鯨D();
    		obj.半身接続(長物_鯨D2);
    		尾_鯨D 尾_鯨D2 = new 尾_鯨D();
    		長物_鯨D2.尾接続(尾_鯨D2);
    		尾_鯨D2.尾先接続(new 尾鰭_鯨D());
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getオールドマーメイド()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳人();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		尾_魚D 尾_魚D2 = new 尾_魚D();
    		尾_魚D2.尺度B = 1.2;
    		尾_魚D2.尺度YB = 1.5;
    		尾_魚D2.尾0_表示 = false;
    		尾_魚D2.尾0_鱗右_鱗1_表示 = false;
    		尾_魚D2.尾0_鱗右_鱗2_表示 = false;
    		尾_魚D2.尾先接続(new 尾鰭_魚D());
    		obj.腿左接続(尾_魚D2);
    		obj.腿右接続(尾_魚D2.Get逆());
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getイクテュオケンタウレ(bool b)
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = obj.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳鰭();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		if (b)
    		{
    			長物_魚D 長物_魚D2 = new 長物_魚D();
    			WaistD2.半身接続(長物_魚D2);
    			ElementData elementData = new 鰭_魚D();
    			長物_魚D2.左0接続(elementData);
    			長物_魚D2.右0接続(elementData.Get逆());
    			尾_魚D 尾_魚D2 = new 尾_魚D();
    			長物_魚D2.尾接続(尾_魚D2);
    			尾_魚D2.尾先接続(new 尾鰭_魚D());
    		}
    		else
    		{
    			長物_蛇D 長物_蛇D2 = new 長物_蛇D();
    			WaistD2.半身接続(長物_蛇D2);
    			if (Rng.XS.NextBool())
    			{
    				長物_蛇D2.くぱぁ = 1.0;
    				長物_蛇D2.ガード = false;
    			}
    			ElementData elementData = new 鰭_魚D();
    			長物_蛇D2.左接続(elementData);
    			長物_蛇D2.右接続(elementData.Get逆());
    			Torso_蛇D Torso_蛇D2 = new Torso_蛇D();
    			長物_蛇D2.胴接続(Torso_蛇D2);
    			尾_ヘD 尾_ヘD2 = new 尾_ヘD();
    			Torso_蛇D2.Torso接続(尾_ヘD2);
    			尾_ヘD2.尾先接続(new 尾鰭_魚D());
    		}
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getデルピヌスケンタウレ()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳尖();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		長物_鯨D 長物_鯨D2 = new 長物_鯨D();
    		obj.半身接続(長物_鯨D2);
    		ElementData elementData = new 鰭_豚D();
    		長物_鯨D2.左0接続(elementData);
    		長物_鯨D2.右0接続(elementData.Get逆());
    		尾_鯨D 尾_鯨D2 = new 尾_鯨D();
    		長物_鯨D2.尾接続(尾_鯨D2);
    		尾_鯨D2.尾先接続(new 尾鰭_鯨D());
    		obj.EnumEleD().SetValuesD<頬肌D>("豹", true);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getスキュラ()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = obj.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		if (Rng.XS.NextBool())
    		{
    			頭D2.Set耳尖();
    		}
    		else
    		{
    			頭D2.Set耳人();
    		}
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		多足_蛸D 多足_蛸D2 = new 多足_蛸D();
    		WaistD2.半身接続(多足_蛸D2);
    		触手_軟D 触手_軟D2 = new 触手_軟D
    		{
    			後足 = true
    		};
    		触手_軟D 触手_軟D3 = new 触手_軟D
    		{
    			前足 = true
    		};
    		if (Rng.XS.NextBool())
    		{
    			触手_軟D2.SetValuesD("鎧", true);
    			触手_軟D3.SetValuesD("鎧", true);
    		}
    		多足_蛸D2.軟体内左接続(触手_軟D2.Copy());
    		多足_蛸D2.軟体内右接続(触手_軟D2.Get逆());
    		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
    		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
    		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
    		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
    		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
    		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
    		if (Rng.XS.NextBool())
    		{
    			WaistD2.EnumEleD().SetValuesD("紋柄", true);
    		}
    		if (Rng.XS.NextBool())
    		{
    			WaistD2.EnumEleD().SetValuesD<鼻肌D>("紋柄", false);
    		}
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getオールドスキュラ(bool b)
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		if (Rng.XS.NextBool())
    		{
    			頭D2.Set耳尖();
    		}
    		else
    		{
    			頭D2.Set耳人();
    		}
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		触手_犬D 触手_犬D2 = new 触手_犬D();
    		触手_犬D2.SetValuesD("Leg", b);
    		if (b)
    		{
    			触手_犬D2.SetValuesD("鰭", Rng.XS.NextBool());
    		}
    		obj.腿左接続(触手_犬D2.Copy());
    		obj.腿右接続(触手_犬D2.Get逆());
    		obj.腿左接続(触手_犬D2.Copy());
    		obj.腿右接続(触手_犬D2.Get逆());
    		obj.腿左接続(触手_犬D2.Copy());
    		obj.腿右接続(触手_犬D2.Get逆());
    		長物_魚D 長物_魚D2 = new 長物_魚D();
    		obj.半身接続(長物_魚D2);
    		尾_魚D 尾_魚D2 = new 尾_魚D();
    		長物_魚D2.尾接続(尾_魚D2);
    		尾_魚D2.尾先接続(new 尾鰭_魚D());
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getカリュブディス()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口裂();
    		頭D2.Set舌長();
    		頭D2.Set耳鰭();
    		ElementData eleD2 = Rng.XS.Next(4) switch
    		{
    			0 => new 角2_牛1D(), 
    			1 => new 角2_牛2D(), 
    			2 => new 角2_牛3D(), 
    			_ => new 角2_牛4D(), 
    		};
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		長物_鯨D 長物_鯨D2 = new 長物_鯨D();
    		WaistD2.半身接続(長物_鯨D2);
    		eleD2 = new 鰭_鯨D();
    		長物_鯨D2.左0接続(eleD2);
    		長物_鯨D2.右0接続(eleD2.Get逆());
    		尾_鯨D 尾_鯨D2 = new 尾_鯨D();
    		長物_鯨D2.尾接続(尾_鯨D2);
    		尾_鯨D2.尾先接続(new 尾鰭_鯨D());
    		WaistD2.EnumEleD().SetValuesD("水掻", true);
    		WaistD2.EnumEleD().SetValuesD("竜性", true);
    		WaistD2.EnumEleD().SetValuesD("獣毛", true);
    		WaistD2.EnumEleD().SetValuesD<胸毛D>("表示", true);
    		WaistD2.EnumEleD().SetValuesD("悪", true);
    		WaistD2.EnumEleD().SetValuesD<LowerArm_人D>("悪", false);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("悪", false);
    		WaistD2.EnumEleD().SetValuesD("逆十字", false);
    		WaistD2.EnumEleD().SetValuesD<UpperArm_人D>("淫", true);
    		WaistD2.EnumEleD().SetValuesD<WaistD>("鱗", false);
    		WaistD2.EnumEleD().SetValuesD<WaistD>("毛", false);
    		WaistD2.EnumEleD().SetValuesD<WaistSkinD>("鱗", false);
    		WaistD2.EnumEleD().SetValuesD<WaistSkinD>("毛", false);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("配色", 配色指定.S0);
    		WaistD2.EnumEleD().SetValuesD("肥大", 1.0);
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getアラクネ(bool b)
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = obj.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		if (Rng.XS.NextBool())
    		{
    			頭D2.Set耳尖();
    		}
    		else
    		{
    			頭D2.Set耳人();
    		}
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		if (Rng.XS.NextBool())
    		{
    			ElementData elementData = new 虫顎D();
    			頭D2.頬左接続(elementData);
    			頭D2.頬右接続(elementData.Get逆());
    		}
    		多足_蜘D 多足_蜘D2 = new 多足_蜘D();
    		WaistD2.半身接続(多足_蜘D2);
    		尾_蜘D 尾_蜘D2 = new 尾_蜘D();
    		尾_蜘D2.出糸 = Rng.XS.NextBool();
    		多足_蜘D2.尾接続(尾_蜘D2);
    		触肢_肢蜘D 触肢_肢蜘D2 = new 触肢_肢蜘D();
    		節足_足蜘D 節足_足蜘D2 = new 節足_足蜘D();
    		節足_足蜘D2.爪 = b;
    		ElementData eleD2 = 節足_足蜘D2.Copy();
    		ElementData eleD3 = 節足_足蜘D2.Copy();
    		eleD3.反転Y = !尾_蜘D2.出糸;
    		ElementData eleD4 = 節足_足蜘D2.Copy();
    		eleD4.反転Y = eleD3.反転Y;
    		多足_蜘D2.触肢左接続(触肢_肢蜘D2);
    		多足_蜘D2.節足左1接続(節足_足蜘D2);
    		多足_蜘D2.節足左2接続(eleD2);
    		多足_蜘D2.節足左3接続(eleD3);
    		多足_蜘D2.節足左4接続(eleD4);
    		多足_蜘D2.触肢右接続(触肢_肢蜘D2.Get逆());
    		多足_蜘D2.節足右1接続(節足_足蜘D2.Get逆());
    		多足_蜘D2.節足右2接続(eleD2.Get逆());
    		多足_蜘D2.節足右3接続(eleD3.Get逆());
    		多足_蜘D2.節足右4接続(eleD4.Get逆());
    		if (Rng.XS.NextBool())
    		{
    			WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		}
    		if (Rng.XS.NextBool())
    		{
    			多足_蜘D2.EnumEleD().SetValuesD("柄", true);
    		}
    		WaistD2.EnumEleD().SetValuesD<HeadD>("蜘", 頭D2.頬左_接続.IsEleD<虫顎D>() || Rng.XS.NextBool());
    		WaistD2.EnumEleD().SetValuesD<頬肌D>("蜘", Rng.XS.NextBool());
    		WaistD2.EnumEleD().SetValuesD<胸肌D>("蜘", Rng.XS.NextBool());
    		if (頭D2.頬左_接続.IsEleD<虫顎D>())
    		{
    			WaistD2.EnumEleD().SetValuesD<頬肌D>("蜘", false);
    		}
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getギルタブリル()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = obj.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		if (Rng.XS.NextBool())
    		{
    			頭D2.Set耳尖();
    		}
    		else
    		{
    			頭D2.Set耳人();
    		}
    		if (Rng.XS.NextBool())
    		{
    			ElementData elementData = new 虫顎D();
    			頭D2.頬左接続(elementData);
    			頭D2.頬右接続(elementData.Get逆());
    		}
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		多足_蠍D 多足_蠍D2 = new 多足_蠍D();
    		WaistD2.半身接続(多足_蠍D2);
    		多足_蠍D2.前腹_腹節3_節線_表示 = Rng.XS.NextBool();
    		多足_蠍D2.前腹_腹節4_節線_表示 = 多足_蠍D2.前腹_腹節3_節線_表示;
    		多足_蠍D2.前腹_腹節5_節線_表示 = 多足_蠍D2.前腹_腹節3_節線_表示;
    		多足_蠍D2.前腹_腹節6_節線_表示 = 多足_蠍D2.前腹_腹節3_節線_表示;
    		触肢_肢蠍D 触肢_肢蠍D2 = new 触肢_肢蠍D();
    		節足_足蠍D 節足_足蠍D2 = new 節足_足蠍D();
    		節足_足蠍D2.爪 = Rng.XS.NextBool();
    		ElementData eleD2 = 節足_足蠍D2.Copy();
    		ElementData eleD3 = 節足_足蠍D2.Copy();
    		ElementData eleD4 = 節足_足蠍D2.Copy();
    		多足_蠍D2.触肢左接続(触肢_肢蠍D2);
    		多足_蠍D2.節足左1接続(節足_足蠍D2);
    		多足_蠍D2.節足左2接続(eleD2);
    		多足_蠍D2.節足左3接続(eleD3);
    		多足_蠍D2.節足左4接続(eleD4);
    		多足_蠍D2.触肢右接続(触肢_肢蠍D2.Get逆());
    		多足_蠍D2.節足右1接続(節足_足蠍D2.Get逆());
    		多足_蠍D2.節足右2接続(eleD2.Get逆());
    		多足_蠍D2.節足右3接続(eleD3.Get逆());
    		多足_蠍D2.節足右4接続(eleD4.Get逆());
    		if (Rng.XS.NextBool())
    		{
    			ElementData elementData = new 触覚_蠍D();
    			多足_蠍D2.櫛状板左接続(elementData);
    			多足_蠍D2.櫛状板右接続(elementData.Get逆());
    		}
    		多足_蠍D2.尾接続(new 尾_蠍D());
    		WaistD2.EnumEleD().SetValuesD("タトゥ", true);
    		WaistD2.EnumEleD().SetValuesD("ハート", false);
    		WaistD2.EnumEleD().SetValuesD("逆十字", false);
    		WaistD2.EnumEleD().SetValuesD<UpperArm_人D>("淫", false);
    		WaistD2.EnumEleD().SetValuesD<UpperArm_人D>("植", false);
    		WaistD2.EnumEleD().SetValuesD<頬肌D>("タトゥ", false);
    		WaistD2.EnumEleD().SetValuesD<ChestD>("植", false);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("悪", false);
    		if (Rng.XS.NextBool())
    		{
    			WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		}
    		if (Rng.XS.NextBool())
    		{
    			多足_蠍D2.EnumEleD().SetValuesD("柄", true);
    		}
    		WaistD2.EnumEleD().SetValuesD<HeadD>("蜘", 頭D2.頬左_接続.IsEleD<虫顎D>() || Rng.XS.NextBool());
    		WaistD2.EnumEleD().SetValuesD<頬肌D>("蜘", Rng.XS.NextBool());
    		if (頭D2.頬左_接続.IsEleD<虫顎D>())
    		{
    			WaistD2.EnumEleD().SetValuesD<頬肌D>("蜘", false);
    		}
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getギルタブルル()
    	{
    		WaistD obj = Uni.Waist();
    		TorsoD 胴D2 = obj.SetTorso();
    		ChestD ChestD2 = 胴D2.SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳尖();
    		頭D2.額接続(new 角1_虫D());
    		ElementData eleD2 = new 角2_虫D();
    		eleD2.SetValuesD("棘", true);
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		顔面_甲D e = new 顔面_甲D();
    		頭D2.顔面接続(e);
    		手_人D e2 = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e2);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		if (Rng.XS.NextBool())
    		{
    			手_鳥D e3 = new 手_鳥D();
    			LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D();
    			LowerArm_鳥D2.手接続(e3);
    			UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D();
    			UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    			ChestD2.翼上左接続(UpperArm_鳥D2);
    			ChestD2.翼上右接続(UpperArm_鳥D2.Get逆());
    		}
    		足_鳥D e4 = new 足_鳥D();
    		Leg_鳥D Leg_鳥D2 = new Leg_鳥D();
    		Leg_鳥D2.足接続(e4);
    		腿_鳥D 腿_鳥D2 = new 腿_鳥D();
    		腿_鳥D2.Leg接続(Leg_鳥D2);
    		obj.腿左接続(腿_鳥D2);
    		obj.腿右接続(腿_鳥D2.Get逆());
    		obj.尾接続(new 尾_鳥D());
    		obj.尾接続(new 尾_蛇D());
    		eleD2 = new 尾_蠍D();
    		胴D2.翼左接続(eleD2);
    		胴D2.翼右接続(eleD2.Get逆());
    		obj.EnumEleD().SetValuesD("タトゥ", true);
    		obj.EnumEleD().SetValuesD("ハート", false);
    		obj.EnumEleD().SetValuesD<手_人D>("タトゥ", false);
    		obj.EnumEleD().SetValuesD<ChestD>("植", false);
    		obj.EnumEleD().SetValuesD<胸肌D>("植", false);
    		obj.EnumEleD().SetValuesD<HeadD>("逆十字", false);
    		obj.EnumEleD().SetValuesD<HeadD>("顎下", true);
    		obj.EnumEleD().SetValuesD<WaistD>("獣", true);
    		obj.EnumEleD().SetValuesD<WaistSkinD>("獣", true);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getアルラウネ()
    	{
    		WaistD obj = Uni.Waist();
    		TorsoD obj2 = obj.SetTorso();
    		ChestD obj3 = obj2.SetChestR();
    		HeadD 頭D2 = obj3.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳尖();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj3.肩左接続(ShoulderD2);
    		obj3.肩右接続(ShoulderD2.Get逆());
    		植D 植D2 = new 植D();
    		ElementData eleD2 = SlaveMatrix.GameClasses._Con.Get花R(右: false);
    		植D2.花接続(eleD2);
    		bool flag = Rng.XS.NextBool();
    		if (eleD2 is 花_百D)
    		{
    			((花_百D)eleD2).萼_萼_表示 = !flag;
    		}
    		植D2.披針葉1_葉_表示 = flag;
    		植D2.披針葉1_葉脈_表示 = flag;
    		植D2.披針葉2_葉_表示 = flag;
    		植D2.披針葉2_葉脈_表示 = flag;
    		植D2.披針葉3_葉_表示 = flag;
    		植D2.披針葉3_葉脈_表示 = flag;
    		植D2.披針葉4_葉_表示 = flag;
    		植D2.披針葉4_葉脈_表示 = flag;
    		植D2.心臓葉1_葉_表示 = !flag;
    		植D2.心臓葉1_葉脈_表示 = !flag;
    		植D2.心臓葉2_葉_表示 = !flag;
    		植D2.心臓葉2_葉脈_表示 = !flag;
    		植D2.心臓葉3_葉_表示 = !flag;
    		植D2.心臓葉3_葉脈_表示 = !flag;
    		植D2.心臓葉4_葉_表示 = !flag;
    		植D2.心臓葉4_葉脈_表示 = !flag;
    		eleD.頭頂左接続(植D2);
    		eleD.頭頂右接続(植D2.Get逆());
    		触手_蔦D 触手_蔦D2 = new 触手_蔦D
    		{
    			先端表示 = Rng.XS.NextBool()
    		};
    		触手_蔦D2.SetValuesD("棘", Rng.XS.NextBool());
    		ElementData eleD3 = (flag ? ((葉D)new 葉_披D()) : ((葉D)new 葉_心D()));
    		eleD3.尺度B *= 1.2;
    		触手_蔦D2.節3接続(eleD3);
    		eleD3.尺度B *= 葉倍率;
    		触手_蔦D2.節5接続(eleD3 = eleD3.Copy());
    		eleD3.尺度B *= 葉倍率;
    		触手_蔦D2.節7接続(eleD3 = eleD3.Copy());
    		eleD3.尺度B *= 葉倍率;
    		触手_蔦D2.節9接続(eleD3 = eleD3.Copy());
    		eleD3.尺度B *= 葉倍率;
    		触手_蔦D2.節11接続(eleD3 = eleD3.Copy());
    		eleD3.尺度B *= 葉倍率;
    		触手_蔦D2.節13接続(eleD3 = eleD3.Copy());
    		eleD3.尺度B *= 葉倍率;
    		触手_蔦D2.節15接続(eleD3 = eleD3.Copy());
    		eleD3.尺度B *= 葉倍率;
    		触手_蔦D2.節17接続(eleD3 = eleD3.Copy());
    		eleD3.尺度B *= 葉倍率;
    		触手_蔦D2.節19接続(eleD3 = eleD3.Copy());
    		eleD3.尺度B *= 葉倍率;
    		ElementData eleD4 = 触手_蔦D2.Copy();
    		obj2.翼左接続(触手_蔦D2);
    		obj2.翼右接続(触手_蔦D2.Get逆());
    		obj.翼左接続(eleD4);
    		obj.翼右接続(eleD4.Get逆());
    		腿_人D 腿_人D2 = new 腿_人D();
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		単足_植D 単足_植D2 = new 単足_植D();
    		obj.半身接続(単足_植D2);
    		ElementData eleD5 = new 尾_根D();
    		単足_植D2.根外左接続(eleD5);
    		単足_植D2.根外右接続(eleD5.Copy());
    		単足_植D2.根内左接続(eleD5.Copy());
    		単足_植D2.根内右接続(eleD5.Copy());
    		単足_植D2.根中央接続(eleD5.Copy());
    		単足_植D2.根外左接続(eleD5.Copy());
    		単足_植D2.根外右接続(eleD5.Copy());
    		単足_植D2.根内左接続(eleD5.Copy());
    		単足_植D2.根内右接続(eleD5.Copy());
    		単足_植D2.根中央接続(eleD5.Copy());
    		obj.EnumEleD().SetValuesD("植", true);
    		obj.EnumEleD().SetValuesD("淫", true);
    		obj.EnumEleD().SetValuesD<LowerArm_人D>("淫", false);
    		obj.EnumEleD().SetValuesD("ハート", false);
    		obj.EnumEleD().SetValuesD("隈取", true);
    		obj.EnumEleD().SetValuesD<頬肌D>("隈取", false);
    		obj.EnumEleD().SetValuesD<腿_人D>("悪", true);
    		obj.EnumEleD().SetValuesD<腿_人D>("葉1", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getサキュバス()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		TorsoD TorsoD2 = WaistD2.SetTorso();
    		ChestD ChestD2 = TorsoD2.SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳長();
    		ElementData eleD2 = Rng.XS.Next(5) switch
    		{
    			0 => new 角2_山2D
    			{
    				尺度B = 0.9
    			}, 
    			1 => new 角2_巻D
    			{
    				尺度B = 0.9
    			}, 
    			2 => new 角2_牛1D
    			{
    				尺度B = 0.9
    			}, 
    			3 => new 角2_牛2D
    			{
    				尺度B = 0.9
    			}, 
    			_ => new 角2_牛4D
    			{
    				尺度B = 0.9
    			}, 
    		};
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		手_蝙D e2 = new 手_蝙D
    		{
    			シャープ = 1.0
    		};
    		LowerArm_蝙D LowerArm_蝙D2 = new LowerArm_蝙D();
    		LowerArm_蝙D2.手接続(e2);
    		UpperArm_蝙D UpperArm_蝙D2 = new UpperArm_蝙D();
    		UpperArm_蝙D2.LowerArm接続(LowerArm_蝙D2);
    		TorsoD2.翼左接続(UpperArm_蝙D2);
    		TorsoD2.翼右接続(UpperArm_蝙D2.Get逆());
    		足_人D e3 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e3);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		WaistD2.腿左接続(腿_人D2);
    		WaistD2.腿右接続(腿_人D2.Get逆());
    		WaistD2.尾接続(new 尾_淫D());
    		WaistD2.EnumEleD().SetValuesD("淫", true);
    		WaistD2.EnumEleD().SetValuesD<ChestD>("植", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()))
    		{
    			現陰毛 = 0.0
    		};
    	}

    	public static CharacterData Getデビル()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口R();
    		頭D2.Set舌短();
    		if (Rng.XS.NextBool())
    		{
    			頭D2.Set耳尖();
    		}
    		else
    		{
    			頭D2.Set耳長();
    		}
    		ElementData eleD2 = Rng.XS.Next(8) switch
    		{
    			0 => new 角2_山1D(), 
    			1 => new 角2_山2D(), 
    			2 => new 角2_山3D(), 
    			3 => new 角2_牛1D(), 
    			4 => new 角2_牛2D(), 
    			5 => new 角2_牛3D(), 
    			6 => new 角2_牛4D(), 
    			_ => new 角2_鬼D(), 
    		};
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		if (Rng.XS.NextBool())
    		{
    			手_蝙D e2 = new 手_蝙D
    			{
    				シャープ = Rng.XS.NextDouble()
    			};
    			LowerArm_蝙D LowerArm_蝙D2 = new LowerArm_蝙D();
    			LowerArm_蝙D2.手接続(e2);
    			UpperArm_蝙D UpperArm_蝙D2 = new UpperArm_蝙D();
    			UpperArm_蝙D2.LowerArm接続(LowerArm_蝙D2);
    			ChestD2.翼上左接続(UpperArm_蝙D2);
    			ChestD2.翼上右接続(UpperArm_蝙D2.Get逆());
    		}
    		else
    		{
    			手_鳥D e3 = new 手_鳥D();
    			LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D();
    			LowerArm_鳥D2.手接続(e3);
    			UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D();
    			UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    			ChestD2.翼上左接続(UpperArm_鳥D2);
    			ChestD2.翼上右接続(UpperArm_鳥D2.Get逆());
    		}
    		if (Rng.XS.NextBool())
    		{
    			足_人D e4 = new 足_人D();
    			Leg_人D Leg_人D2 = new Leg_人D();
    			Leg_人D2.足接続(e4);
    			腿_人D 腿_人D2 = new 腿_人D();
    			腿_人D2.Leg接続(Leg_人D2);
    			WaistD2.腿左接続(腿_人D2);
    			WaistD2.腿右接続(腿_人D2.Get逆());
    		}
    		else
    		{
    			足_牛D e5 = new 足_牛D();
    			Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    			Leg_蹄D2.足接続(e5);
    			腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    			腿_蹄D2.Leg接続(Leg_蹄D2);
    			WaistD2.腿左接続(腿_蹄D2);
    			WaistD2.腿右接続(腿_蹄D2.Get逆());
    			WaistD2.EnumEleD().SetValuesD<WaistSkinD>("獣性", true);
    			WaistD2.EnumEleD().SetValuesD<頬肌D>("髭", false);
    		}
    		WaistD2.尾接続(Rng.XS.NextM(4) switch
    		{
    			0 => new 尾_犬D(), 
    			1 => new 尾_馬D(), 
    			2 => new 尾_牛D(), 
    			_ => new 尾_悪D(), 
    		});
    		WaistD2.EnumEleD().SetValuesD("悪", true);
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getエンジェル(bool b)
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳人();
    		if (b)
    		{
    			頭D2.頭頂接続(new 頭頂_天D());
    		}
    		else
    		{
    			ChestD2.背中接続(new 背中_光D());
    		}
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		手_鳥D 手_鳥D2 = new 手_鳥D
    		{
    			シャープ = Rng.XS.NextDouble()
    		};
    		LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D
    		{
    			シャープ = 手_鳥D2.シャープ
    		};
    		LowerArm_鳥D2.手接続(手_鳥D2);
    		UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D
    		{
    			シャープ = LowerArm_鳥D2.シャープ
    		};
    		UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    		for (int i = 0; i < Rng.XS.Next(2) + 1; i++)
    		{
    			ChestD2.翼上左接続(UpperArm_鳥D2.Copy());
    			ChestD2.翼上右接続(UpperArm_鳥D2.Get逆());
    		}
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		WaistD2.腿左接続(腿_人D2);
    		WaistD2.腿右接続(腿_人D2.Get逆());
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getウェアキャット()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻R();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		ElementData eleD2 = new 獣耳D();
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		obj.尾接続(new 尾_猫D());
    		obj.EnumEleD().SetValuesD("獣性", true);
    		obj.EnumEleD().SetValuesD<LowerArm_人D>("獣腕", false);
    		obj.EnumEleD().SetValuesD<手_人D>("獣性", false);
    		obj.EnumEleD().SetValuesD<手_人D>("獣毛", true);
    		obj.EnumEleD().SetValuesD<手_人D>("肉球", true);
    		obj.EnumEleD().SetValuesD("胸毛", false);
    		obj.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
    		obj.EnumEleD().SetValuesD<双目D>("猫目", true);
    		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		obj.EnumEleD().SetValuesD<LowerArm_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD<Leg_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD<足_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getウェアフォックス()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻R();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		ElementData eleD2 = new 獣耳D
    		{
    			尺度YB = 1.2
    		};
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		obj.尾接続(new 尾_狐D());
    		obj.EnumEleD().SetValuesD("獣性", true);
    		obj.EnumEleD().SetValuesD<LowerArm_人D>("獣腕", false);
    		obj.EnumEleD().SetValuesD<手_人D>("獣性", false);
    		obj.EnumEleD().SetValuesD<手_人D>("獣毛", true);
    		obj.EnumEleD().SetValuesD<手_人D>("肉球", true);
    		obj.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
    		obj.EnumEleD().SetValuesD<双目D>("猫目", true);
    		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		obj.EnumEleD().SetValuesD<LowerArm_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD<Leg_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD<足_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getウェアウルフ()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻R();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		ElementData eleD2 = new 獣耳D();
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		obj.尾接続(new 尾_犬D());
    		obj.EnumEleD().SetValuesD("獣性", true);
    		obj.EnumEleD().SetValuesD<頬肌D>("髭", false);
    		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		obj.EnumEleD().SetValuesD<LowerArm_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD<Leg_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD<足_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getリザードマン()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = obj.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口R();
    		頭D2.Set舌短();
    		頭D2.Set耳尖();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		WaistD2.腿左接続(腿_人D2);
    		WaistD2.腿右接続(腿_人D2.Get逆());
    		ElementData elementData;
    		if (Rng.XS.Next(2) == 0)
    		{
    			elementData = new 尾_ヘD();
    			elementData.尺度B = 0.6;
    		}
    		else
    		{
    			elementData = new 尾_龍D();
    		}
    		WaistD2.尾接続(elementData);
    		WaistD2.EnumEleD().SetValuesD("竜性", true);
    		WaistD2.EnumEleD().SetValuesD<LowerArm_人D>("棘", false);
    		WaistD2.EnumEleD().SetValuesD<LowerArm_人D>("肘2", false);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("鱗", true);
    		WaistD2.EnumEleD().SetEleDs(delegate(手_人D f)
    		{
    			f.竜性 = false;
    		});
    		WaistD2.EnumEleD().SetValuesD<Leg_人D>("棘", false);
    		WaistD2.EnumEleD().SetValuesD<双目D>("猫目", true);
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getドラゴニュート()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		ElementData e;
    		if (Rng.XS.NextBool())
    		{
    			e = ((Rng.XS.Next(2) != 0) ? ((角1D)new 角1_鬼D()) : ((角1D)new 角1_一D()));
    			頭D2.額接続(e);
    		}
    		e = Rng.XS.Next(8) switch
    		{
    			0 => new 角2_山1D(), 
    			1 => new 角2_山2D(), 
    			2 => new 角2_山3D(), 
    			3 => new 角2_巻D(), 
    			4 => new 角2_牛1D(), 
    			5 => new 角2_牛2D(), 
    			6 => new 角2_牛3D(), 
    			_ => new 角2_牛4D(), 
    		};
    		eleD.頭頂左接続(e);
    		eleD.頭頂右接続(e.Get逆());
    		手_人D e2 = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e2);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		if (Rng.XS.NextBool())
    		{
    			if (Rng.XS.NextBool())
    			{
    				手_蝙D e3 = new 手_蝙D
    				{
    					シャープ = Rng.XS.NextDouble()
    				};
    				LowerArm_蝙D LowerArm_蝙D2 = new LowerArm_蝙D();
    				LowerArm_蝙D2.手接続(e3);
    				UpperArm_蝙D UpperArm_蝙D2 = new UpperArm_蝙D();
    				UpperArm_蝙D2.LowerArm接続(LowerArm_蝙D2);
    				ChestD2.翼上左接続(UpperArm_蝙D2);
    				ChestD2.翼上右接続(UpperArm_蝙D2.Get逆());
    				頭D2.Set耳長();
    			}
    			else
    			{
    				手_鳥D 手_鳥D2 = new 手_鳥D
    				{
    					シャープ = Rng.XS.NextDouble()
    				};
    				LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D
    				{
    					シャープ = 手_鳥D2.シャープ
    				};
    				LowerArm_鳥D2.手接続(手_鳥D2);
    				UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D
    				{
    					シャープ = LowerArm_鳥D2.シャープ
    				};
    				UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    				ChestD2.翼上左接続(UpperArm_鳥D2);
    				ChestD2.翼上右接続(UpperArm_鳥D2.Get逆());
    				頭D2.Set耳獣();
    			}
    		}
    		else
    		{
    			頭D2.Set耳尖();
    		}
    		足_人D e4 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e4);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		WaistD2.腿左接続(腿_人D2);
    		WaistD2.腿右接続(腿_人D2.Get逆());
    		switch (Rng.XS.Next(3))
    		{
    		case 0:
    			e = new 尾_ヘD();
    			e.尺度B = 0.6;
    			break;
    		case 1:
    			e = new 尾_竜D();
    			break;
    		default:
    			e = new 尾_龍D();
    			break;
    		}
    		WaistD2.尾接続(e);
    		WaistD2.EnumEleD().SetValuesD("竜性", true);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("竜性", false);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("鱗", true);
    		WaistD2.EnumEleD().SetValuesD<双目D>("猫目", Rng.XS.NextBool());
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getドラゴン()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口R();
    		頭D2.Set舌短();
    		ElementData e;
    		if (Rng.XS.NextBool())
    		{
    			e = ((Rng.XS.Next(2) != 0) ? ((角1D)new 角1_鬼D()) : ((角1D)new 角1_一D()));
    			頭D2.額接続(e);
    		}
    		e = Rng.XS.Next(8) switch
    		{
    			0 => new 角2_山1D(), 
    			1 => new 角2_山2D(), 
    			2 => new 角2_山3D(), 
    			3 => new 角2_巻D(), 
    			4 => new 角2_牛1D(), 
    			5 => new 角2_牛2D(), 
    			6 => new 角2_牛3D(), 
    			_ => new 角2_牛4D(), 
    		};
    		eleD.頭頂左接続(e);
    		eleD.頭頂右接続(e.Get逆());
    		手_人D e2 = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e2);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		WaistD2.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		if (Rng.XS.NextBool())
    		{
    			手_蝙D e3 = new 手_蝙D();
    			LowerArm_蝙D LowerArm_蝙D2 = new LowerArm_蝙D();
    			LowerArm_蝙D2.手接続(e3);
    			UpperArm_蝙D UpperArm_蝙D2 = new UpperArm_蝙D();
    			UpperArm_蝙D2.LowerArm接続(LowerArm_蝙D2);
    			四足胸D2.翼上左接続(UpperArm_蝙D2);
    			四足胸D2.翼上右接続(UpperArm_蝙D2.Get逆());
    			頭D2.Set耳鰭();
    		}
    		else
    		{
    			手_鳥D e4 = new 手_鳥D();
    			LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D();
    			LowerArm_鳥D2.手接続(e4);
    			UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D();
    			UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    			四足胸D2.翼上左接続(UpperArm_鳥D2);
    			四足胸D2.翼上右接続(UpperArm_鳥D2.Get逆());
    			WaistD2.EnumEleD().SetValuesD<四足胴D>("獣毛", true);
    			頭D2.Set耳羽();
    		}
    		手_獣D e5 = new 手_獣D();
    		LowerArm_獣D LowerArm_獣D2 = new LowerArm_獣D();
    		LowerArm_獣D2.手接続(e5);
    		UpperArm_獣D UpperArm_獣D2 = new UpperArm_獣D();
    		UpperArm_獣D2.LowerArm接続(LowerArm_獣D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_獣D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_竜D e6 = new 足_竜D();
    		Leg_竜D Leg_竜D2 = new Leg_竜D();
    		Leg_竜D2.足接続(e6);
    		腿_竜D 腿_竜D2 = new 腿_竜D();
    		腿_竜D2.Leg接続(Leg_竜D2);
    		四足腰D2.腿左接続(腿_竜D2);
    		四足腰D2.腿右接続(腿_竜D2.Get逆());
    		switch (Rng.XS.Next(5))
    		{
    		case 0:
    			e = new 尾_ヘD();
    			e.尺度B = 0.6;
    			break;
    		case 1:
    			e = new 尾_竜D();
    			break;
    		case 2:
    			e = new 尾_龍D();
    			break;
    		default:
    			e = new 尾_悪D();
    			break;
    		}
    		四足腰D2.尾接続(e);
    		WaistD2.EnumEleD().SetValuesD("竜性", true);
    		四足胸D2.EnumEleD().SetValuesD<胸肌D>("鱗", false);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("配色", 配色指定.S0);
    		WaistD2.EnumEleD().SetValuesD<双目D>("猫目", true);
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getドラコケンタウレ()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口R();
    		頭D2.Set舌短();
    		ElementData e;
    		if (Rng.XS.NextBool())
    		{
    			e = ((Rng.XS.Next(2) != 0) ? ((角1D)new 角1_鬼D()) : ((角1D)new 角1_一D()));
    			頭D2.額接続(e);
    		}
    		e = Rng.XS.Next(8) switch
    		{
    			0 => new 角2_山1D(), 
    			1 => new 角2_山2D(), 
    			2 => new 角2_山3D(), 
    			3 => new 角2_巻D(), 
    			4 => new 角2_牛1D(), 
    			5 => new 角2_牛2D(), 
    			6 => new 角2_牛3D(), 
    			_ => new 角2_牛4D(), 
    		};
    		eleD.頭頂左接続(e);
    		eleD.頭頂右接続(e.Get逆());
    		手_人D e2 = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e2);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		WaistD2.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		頭D2.Set耳長();
    		手_獣D e3 = new 手_獣D();
    		LowerArm_獣D LowerArm_獣D2 = new LowerArm_獣D();
    		LowerArm_獣D2.手接続(e3);
    		UpperArm_獣D UpperArm_獣D2 = new UpperArm_獣D();
    		UpperArm_獣D2.LowerArm接続(LowerArm_獣D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_獣D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_竜D e4 = new 足_竜D();
    		Leg_竜D Leg_竜D2 = new Leg_竜D();
    		Leg_竜D2.足接続(e4);
    		腿_竜D 腿_竜D2 = new 腿_竜D();
    		腿_竜D2.Leg接続(Leg_竜D2);
    		四足腰D2.腿左接続(腿_竜D2);
    		四足腰D2.腿右接続(腿_竜D2.Get逆());
    		switch (Rng.XS.Next(5))
    		{
    		case 0:
    			e = new 尾_ヘD();
    			e.尺度B = 0.6;
    			break;
    		case 1:
    			e = new 尾_竜D();
    			break;
    		case 2:
    			e = new 尾_龍D();
    			break;
    		default:
    			e = new 尾_悪D();
    			break;
    		}
    		四足腰D2.尾接続(e);
    		WaistD2.EnumEleD().SetValuesD("竜性", true);
    		四足胸D2.EnumEleD().SetValuesD<胸肌D>("鱗", false);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("配色", 配色指定.S0);
    		WaistD2.EnumEleD().SetValuesD<双目D>("猫目", true);
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getワイバーン()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口R();
    		頭D2.Set舌短();
    		ElementData e;
    		if (Rng.XS.NextBool())
    		{
    			e = ((Rng.XS.Next(2) != 0) ? ((角1D)new 角1_鬼D()) : ((角1D)new 角1_一D()));
    			頭D2.額接続(e);
    		}
    		e = Rng.XS.Next(6) switch
    		{
    			0 => new 角2_山1D(), 
    			1 => new 角2_山2D(), 
    			2 => new 角2_山3D(), 
    			3 => new 角2_牛2D(), 
    			4 => new 角2_牛3D(), 
    			_ => new 角2_牛4D(), 
    		};
    		eleD.頭頂左接続(e);
    		eleD.頭頂右接続(e.Get逆());
    		if (Rng.XS.NextBool())
    		{
    			手_蝙D e2 = new 手_蝙D
    			{
    				尺度B = 1.1
    			};
    			LowerArm_蝙D LowerArm_蝙D2 = new LowerArm_蝙D
    			{
    				尺度B = 1.1
    			};
    			LowerArm_蝙D2.手接続(e2);
    			UpperArm_蝙D UpperArm_蝙D2 = new UpperArm_蝙D
    			{
    				尺度B = 1.1
    			};
    			UpperArm_蝙D2.LowerArm接続(LowerArm_蝙D2);
    			ShoulderD ShoulderD2 = new ShoulderD();
    			ShoulderD2.UpperArm接続(UpperArm_蝙D2);
    			ChestD2.肩左接続(ShoulderD2);
    			ChestD2.肩右接続(ShoulderD2.Get逆());
    			頭D2.Set耳長();
    		}
    		else
    		{
    			手_鳥D e3 = new 手_鳥D
    			{
    				尺度B = 1.1,
    				指_表示 = true
    			};
    			LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D
    			{
    				尺度B = 1.1
    			};
    			LowerArm_鳥D2.手接続(e3);
    			UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D
    			{
    				尺度B = 1.1
    			};
    			UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    			ShoulderD ShoulderD3 = new ShoulderD();
    			ShoulderD3.UpperArm接続(UpperArm_鳥D2);
    			ChestD2.肩左接続(ShoulderD3);
    			ChestD2.肩右接続(ShoulderD3.Get逆());
    			ChestD2.背中接続(new 背中_羽D());
    			頭D2.Set耳獣();
    		}
    		足_鳥D e4 = new 足_鳥D();
    		Leg_竜D Leg_竜D2 = new Leg_竜D();
    		Leg_竜D2.足接続(e4);
    		腿_竜D 腿_竜D2 = new 腿_竜D();
    		腿_竜D2.Leg接続(Leg_竜D2);
    		WaistD2.腿左接続(腿_竜D2);
    		WaistD2.腿右接続(腿_竜D2.Get逆());
    		WaistD2.尾接続(Rng.XS.Next(5) switch
    		{
    			0 => new 尾_ヘD
    			{
    				尺度B = 0.6
    			}, 
    			1 => new 尾_竜D(), 
    			2 => new 尾_龍D(), 
    			3 => new 尾_蠍D
    			{
    				尺度B = 1.3
    			}, 
    			_ => new 尾_悪D
    			{
    				尺度B = 1.5
    			}, 
    		});
    		WaistD2.EnumEleD().SetValuesD("竜性", true);
    		WaistD2.EnumEleD().SetValuesD<双目D>("猫目", true);
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getワーム()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		HeadD 頭D2 = WaistD2.SetTorso().SetChestR().SetNeck()
    			.Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口裂();
    		頭D2.Set舌長();
    		頭D2.Set耳鰭();
    		頭D2.Set耳尖();
    		ElementData e;
    		if (Rng.XS.NextBool())
    		{
    			e = ((Rng.XS.Next(2) != 0) ? ((角1D)new 角1_鬼D()) : ((角1D)new 角1_一D()));
    			頭D2.額接続(e);
    		}
    		e = Rng.XS.Next(5) switch
    		{
    			0 => new 角2_山1D(), 
    			1 => new 角2_山2D(), 
    			2 => new 角2_牛2D(), 
    			3 => new 角2_牛4D(), 
    			_ => new 角2_鬼D(), 
    		};
    		eleD.頭頂左接続(e);
    		eleD.頭頂右接続(e.Get逆());
    		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
    		WaistD2.半身接続(長物_蛇D2);
    		Torso_蛇D Torso_蛇D2 = new Torso_蛇D();
    		長物_蛇D2.胴接続(Torso_蛇D2);
    		for (int i = 0; i < 40; i++)
    		{
    			Torso_蛇D2.Torso接続(Torso_蛇D2 = new Torso_蛇D());
    		}
    		Torso_蛇D2.Torso接続(new 尾_ヘD());
    		WaistD2.EnumEleD().SetValuesD("竜性", true);
    		WaistD2.EnumEleD().SetValuesD<WaistSkinD>("竜性", false);
    		WaistD2.EnumEleD().SetValuesD<双目D>("猫目", Rng.XS.NextBool());
    		WaistD2.EnumEleD().SetValuesD<Tounge_長D>("股舌表示", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getサンドワーム()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口裂();
    		頭D2.Set舌短();
    		頭D2.Set耳人();
    		ElementData eleD2 = Rng.XS.Next(5) switch
    		{
    			0 => new 角2_山1D(), 
    			1 => new 角2_山2D(), 
    			2 => new 角2_牛2D(), 
    			3 => new 角2_牛4D(), 
    			_ => new 角2_鬼D(), 
    		};
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		頭D2.頭頂接続(new 頭頂_皿D
    		{
    			甲殻 = true
    		});
    		大顎基D 大顎基D2 = new 大顎基D();
    		eleD2 = new 大顎D();
    		大顎基D2.顎左接続(eleD2);
    		大顎基D2.顎右接続(eleD2.Get逆());
    		頭D2.大顎基接続(大顎基D2);
    		顔面_蟲D e = new 顔面_蟲D();
    		頭D2.顔面接続(e);
    		if (Rng.XS.NextBool())
    		{
    			eleD2 = new 虫顎D
    			{
    				尺度B = 1.1
    			};
    			頭D2.頬左接続(eleD2);
    			頭D2.頬右接続(eleD2.Get逆());
    		}
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		LowerArm_人D2.虫鎌接続(new 虫鎌D());
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		ChestD2.肩左接続(ShoulderD2.Copy());
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		ChestD2.肩左接続(ShoulderD2.Copy());
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		長物_蟲D 長物_蟲D2 = new 長物_蟲D();
    		WaistD2.半身接続(長物_蟲D2);
    		Torso_蟲D 胴_蟲D2 = new Torso_蟲D();
    		長物_蟲D2.胴接続(胴_蟲D2);
    		for (int i = 0; i < 21; i++)
    		{
    			胴_蟲D2.Torso接続(胴_蟲D2 = new Torso_蟲D());
    		}
    		尾_蟲D 尾_蟲D2 = new 尾_蟲D();
    		節D 節D2 = (Rng.XS.NextBool() ? ((節尾D)new 節尾_曳航D()) : ((節尾D)new 節尾_鋏D()));
    		尾_蟲D2.尾左接続(節D2);
    		尾_蟲D2.尾右接続(節D2.Get逆());
    		胴_蟲D2.Torso接続(尾_蟲D2);
    		WaistD2.EnumEleD().SetValuesD("虫性", true);
    		WaistD2.EnumEleD().SetValuesD("配色", 配色指定.C0);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getリュウ()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口裂();
    		頭D2.Set舌長();
    		頭D2.Set耳鰭();
    		頭D2.Set耳尖();
    		ElementData eleD2 = new 角2_山2D();
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
    		WaistD2.半身接続(長物_蛇D2);
    		足_鳥D e = new 足_鳥D
    		{
    			尺度B = 1.1
    		};
    		Leg_竜D Leg_竜D2 = new Leg_竜D
    		{
    			尺度B = 1.1
    		};
    		Leg_竜D2.足接続(e);
    		四足脇D 四足脇D2 = new 四足脇D
    		{
    			尺度B = 1.1
    		};
    		四足脇D2.UpperArm接続(Leg_竜D2);
    		WaistD2.翼左接続(四足脇D2);
    		WaistD2.翼右接続(四足脇D2.Get逆());
    		Torso_蛇D Torso_蛇D2 = new Torso_蛇D();
    		長物_蛇D2.胴接続(Torso_蛇D2);
    		for (int i = 0; i < 50; i++)
    		{
    			Torso_蛇D2.Torso接続(Torso_蛇D2 = new Torso_蛇D());
    		}
    		e = new 足_鳥D();
    		Leg_竜D2 = new Leg_竜D();
    		Leg_竜D2.足接続(e);
    		腿_竜D 腿_竜D2 = new 腿_竜D();
    		腿_竜D2.Leg接続(Leg_竜D2);
    		Torso_蛇D2.左接続(腿_竜D2);
    		Torso_蛇D2.右接続(腿_竜D2.Get逆());
    		尾_ヘD 尾_ヘD2 = new 尾_ヘD();
    		尾_ヘD2.尾先接続(new 尾鰭_魚D());
    		Torso_蛇D2.Torso接続(尾_ヘD2);
    		WaistD2.EnumEleD().SetValuesD<HeadD>("馬", true);
    		ChestD2.肌_接続.SetValuesD<胸毛D>("表示", true);
    		WaistD2.EnumEleD().SetValuesD("竜性", true);
    		WaistD2.EnumEleD().SetValuesD<WaistSkinD>("竜性", false);
    		WaistD2.EnumEleD().SetValuesD<双目D>("猫目", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getスライム()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳人();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		腿_人D 腿_人D2 = new 腿_人D
    		{
    			スライム = true
    		};
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		obj.半身接続(new 単足_粘D());
    		obj.EnumEleD().SetValuesD("スライム", true);
    		obj.EnumEleD().SetValuesD("ハイライト", true);
    		obj.EnumEleD().SetValuesD<PregnantBelly_人D>("表示", false);
    		obj.EnumEleD().SetValuesD("眼", false);
    		obj.EnumEleD().SetValuesD("コア", false);
    		obj.EnumEleD().SetValuesD("秘石", false);
    		obj.EnumEleD().SetValuesD<双目D>("ハイライト下", false);
    		obj.EnumEleD().SetValuesD("コア1", Rng.XS.NextBool());
    		obj.EnumEleD().SetValuesD("コア2", Rng.XS.NextBool());
    		obj.EnumEleD().SetValuesD<双目D>("瞳孔", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getフェアリー(bool b1, bool b2)
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		switch (Rng.XS.Next(3))
    		{
    		case 0:
    			頭D2.Set耳人();
    			break;
    		case 1:
    			頭D2.Set耳尖();
    			break;
    		default:
    			頭D2.Set耳長();
    			break;
    		}
    		植D 植D2 = new 植D();
    		ElementData eleD2 = SlaveMatrix.GameClasses._Con.Get花R(右: false);
    		植D2.花接続(eleD2);
    		bool flag = Rng.XS.NextBool();
    		if (eleD2 is 花_百D)
    		{
    			((花_百D)eleD2).萼_萼_表示 = !flag;
    		}
    		植D2.披針葉1_葉_表示 = flag;
    		植D2.披針葉1_葉脈_表示 = flag;
    		植D2.披針葉2_葉_表示 = flag;
    		植D2.披針葉2_葉脈_表示 = flag;
    		植D2.披針葉3_葉_表示 = flag;
    		植D2.披針葉3_葉脈_表示 = flag;
    		植D2.披針葉4_葉_表示 = flag;
    		植D2.披針葉4_葉脈_表示 = flag;
    		植D2.心臓葉1_葉_表示 = !flag;
    		植D2.心臓葉1_葉脈_表示 = !flag;
    		植D2.心臓葉2_葉_表示 = !flag;
    		植D2.心臓葉2_葉脈_表示 = !flag;
    		植D2.心臓葉3_葉_表示 = !flag;
    		植D2.心臓葉3_葉脈_表示 = !flag;
    		植D2.心臓葉4_葉_表示 = !flag;
    		植D2.心臓葉4_葉脈_表示 = !flag;
    		eleD.頭頂左接続(植D2);
    		eleD.頭頂右接続(植D2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		if (b1)
    		{
    			ElementData eleD3 = new 前翅_羽D
    			{
    				尺度B = 0.9
    			};
    			ChestD2.翼上左接続(eleD3);
    			ChestD2.翼上右接続(eleD3.Get逆());
    			eleD3 = new 後翅_羽D
    			{
    				尺度B = 0.9
    			};
    			ChestD2.翼下左接続(eleD3);
    			ChestD2.翼下右接続(eleD3.Get逆());
    		}
    		else
    		{
    			ElementData eleD3 = new 前翅_蝶D
    			{
    				尺度B = 0.9,
    				水青 = b2
    			};
    			ChestD2.翼上左接続(eleD3);
    			ChestD2.翼上右接続(eleD3.Get逆());
    			eleD3 = new 後翅_蝶D
    			{
    				尺度B = 0.9,
    				水青 = b2
    			};
    			ChestD2.翼下左接続(eleD3);
    			ChestD2.翼下右接続(eleD3.Get逆());
    		}
    		if (Rng.XS.NextBool())
    		{
    			if (b1)
    			{
    				ElementData eleD3 = new 触覚_線D();
    				eleD3.尺度YB = 0.4;
    				頭D2.触覚左接続(eleD3);
    				頭D2.触覚右接続(eleD3.Get逆());
    			}
    			else if (b2)
    			{
    				ElementData eleD3 = new 触覚_蛾D();
    				頭D2.触覚左接続(eleD3);
    				頭D2.触覚右接続(eleD3.Get逆());
    			}
    			else
    			{
    				ElementData eleD3 = new 触覚_蝶D();
    				頭D2.触覚左接続(eleD3);
    				頭D2.触覚右接続(eleD3.Get逆());
    			}
    		}
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		WaistD2.腿左接続(腿_人D2);
    		WaistD2.腿右接続(腿_人D2.Get逆());
    		WaistD2.EnumEleD().SetValuesD("肥大", 0.0);
    		WaistD2.EnumEleD().SetValuesD("身長", 0.0);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getオーグリス(bool b)
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		NeckD 首D2 = obj.SetNeck();
    		HeadD 頭D2;
    		if (b)
    		{
    			頭D2 = 首D2.Set頭R1();
    			頭D2.EnumEleD().GetEleD<基髪D>();
    			頭D2.額接続(new 角1_鬼D());
    		}
    		else
    		{
    			頭D2 = 首D2.Set頭R();
    			基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    			ElementData eleD2 = new 角2_鬼D();
    			eleD.頭頂左接続(eleD2);
    			eleD.頭頂右接続(eleD2.Get逆());
    		}
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		if (Rng.XS.NextBool())
    		{
    			頭D2.Set耳人();
    		}
    		else
    		{
    			頭D2.Set耳尖();
    		}
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		WaistD2.腿左接続(腿_人D2);
    		WaistD2.腿右接続(腿_人D2.Get逆());
    		if (Rng.XS.NextBool())
    		{
    			WaistD2.EnumEleD().SetValuesD("隈取", true);
    			頭D2.隈取_タトゥ_表示 = false;
    			WaistD2.EnumEleD().SetValuesD<頬肌D>("豹", true);
    			WaistD2.EnumEleD().SetValuesD("淫", true);
    			WaistD2.EnumEleD().SetValuesD("ハート", false);
    			WaistD2.SetValuesD("悪", true);
    			WaistD2.EnumEleD().SetValuesD<ChestD>("植", true);
    			WaistD2.EnumEleD().SetValuesD<TorsoD>("植", true);
    			WaistD2.EnumEleD().SetValuesD<ChestD>("タトゥ2", false);
    			WaistD2.EnumEleD().SetValuesD<LowerArm_人D>("手首", false);
    			WaistD2.EnumEleD().SetValuesD<Leg_人D>("足首", false);
    		}
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getサイクロプス()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R1();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set単目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		if (Rng.XS.NextBool())
    		{
    			頭D2.Set耳人();
    		}
    		else
    		{
    			頭D2.Set耳尖();
    		}
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 1.0);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getエイリアン()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = obj.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set目宇R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳尖();
    		頭頂_宇D 頭頂_宇D2 = new 頭頂_宇D();
    		頭頂_宇D2.頭部後接続(new 頭頂後_宇D());
    		頭D2.頭頂接続(頭頂_宇D2);
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		LowerArm_人D2.虫鎌接続(new 虫鎌D());
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		多足_蛸D 多足_蛸D2 = new 多足_蛸D();
    		WaistD2.半身接続(多足_蛸D2);
    		触手_軟D 触手_軟D2 = new 触手_軟D
    		{
    			後足 = true
    		};
    		触手_軟D 触手_軟D3 = new 触手_軟D
    		{
    			前足 = true
    		};
    		多足_蛸D2.軟体内左接続(触手_軟D2.Copy());
    		多足_蛸D2.軟体内右接続(触手_軟D2.Get逆());
    		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
    		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
    		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
    		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
    		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
    		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
    		WaistD2.EnumEleD().SetValuesD("コア1", true);
    		WaistD2.EnumEleD().SetValuesD("虫性", true);
    		WaistD2.EnumEleD().SetValuesD<HeadD>("虫性", false);
    		WaistD2.EnumEleD().SetValuesD<ChestD>("器官", false);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("宇手", true);
    		if (Rng.XS.NextBool())
    		{
    			WaistD2.EnumEleD().SetValuesD("紋柄", true);
    		}
    		WaistD2.EnumEleD().SetValuesD("吸盤", false);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getクラーケン()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = obj.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口裂();
    		頭D2.Set舌短();
    		頭D2.Set耳長();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		多足_蛸D 多足_蛸D2 = new 多足_蛸D();
    		WaistD2.半身接続(多足_蛸D2);
    		触手_軟D 触手_軟D2 = new 触手_軟D
    		{
    			後足 = true
    		};
    		触手_軟D 触手_軟D3 = new 触手_軟D
    		{
    			前足 = true
    		};
    		触手_触D 触手_触D2 = new 触手_触D();
    		触手_触D2.SetValuesD("爪", Rng.XS.NextBool());
    		多足_蛸D2.軟体内左接続(触手_軟D2.Copy());
    		多足_蛸D2.軟体内右接続(触手_軟D2.Get逆());
    		多足_蛸D2.軟体内左接続(触手_触D2.Copy());
    		多足_蛸D2.軟体内右接続(触手_触D2.Get逆());
    		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
    		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
    		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
    		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
    		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
    		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
    		if (Rng.XS.NextBool())
    		{
    			WaistD2.EnumEleD().SetValuesD("紋柄", true);
    			多足_蛸D2.EnumEleD().SetValuesD<触手_触D>("柄", Rng.XS.NextBool());
    		}
    		WaistD2.EnumEleD().SetValuesD<双目D>("蛸目", Rng.XS.NextBool());
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getセイレーン(int i)
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口R();
    		頭D2.Set舌短();
    		頭D2.Set耳尖();
    		switch (i)
    		{
    		case 0:
    		{
    			if (Rng.XS.NextBool())
    			{
    				手_人D e4 = new 手_人D();
    				LowerArm_人D LowerArm_人D4 = new LowerArm_人D();
    				LowerArm_人D4.手接続(e4);
    				UpperArm_人D UpperArm_人D4 = new UpperArm_人D();
    				UpperArm_人D4.LowerArm接続(LowerArm_人D4);
    				ShoulderD ShoulderD4 = new ShoulderD();
    				ShoulderD4.UpperArm接続(UpperArm_人D4);
    				ChestD2.肩左接続(ShoulderD4);
    				ChestD2.肩右接続(ShoulderD4.Get逆());
    			}
    			手_鳥D e5 = new 手_鳥D
    			{
    				シャープ = 1.0
    			};
    			LowerArm_鳥D LowerArm_鳥D3 = new LowerArm_鳥D
    			{
    				シャープ = 1.0
    			};
    			LowerArm_鳥D3.手接続(e5);
    			UpperArm_鳥D UpperArm_鳥D3 = new UpperArm_鳥D
    			{
    				シャープ = 1.0
    			};
    			UpperArm_鳥D3.LowerArm接続(LowerArm_鳥D3);
    			ChestD2.翼上左接続(UpperArm_鳥D3);
    			ChestD2.翼上右接続(UpperArm_鳥D3.Get逆());
    			足_鳥D e6 = new 足_鳥D();
    			Leg_鳥D Leg_鳥D3 = new Leg_鳥D();
    			Leg_鳥D3.足接続(e6);
    			腿_鳥D 腿_鳥D3 = new 腿_鳥D();
    			腿_鳥D3.Leg接続(Leg_鳥D3);
    			WaistD2.腿左接続(腿_鳥D3);
    			WaistD2.腿右接続(腿_鳥D3.Get逆());
    			WaistD2.EnumEleD().SetValuesD<WaistSkinD>("獣毛", true);
    			WaistD2.尾接続(new 尾_鳥D());
    			break;
    		}
    		case 1:
    		{
    			手_人D e3 = new 手_人D();
    			LowerArm_人D LowerArm_人D3 = new LowerArm_人D();
    			LowerArm_人D3.手接続(e3);
    			UpperArm_人D UpperArm_人D3 = new UpperArm_人D();
    			UpperArm_人D3.LowerArm接続(LowerArm_人D3);
    			ShoulderD ShoulderD3 = new ShoulderD();
    			ShoulderD3.UpperArm接続(UpperArm_人D3);
    			ChestD2.肩左接続(ShoulderD3);
    			ChestD2.肩右接続(ShoulderD3.Get逆());
    			尾_魚D 尾_魚D2 = new 尾_魚D
    			{
    				尺度B = 1.2,
    				尺度YB = 1.5
    			};
    			尾_魚D2.尾0_表示 = false;
    			尾_魚D2.尾0_鱗右_鱗1_表示 = false;
    			尾_魚D2.尾0_鱗右_鱗2_表示 = false;
    			尾_魚D2.尾先接続(new 尾鰭_魚D());
    			WaistD2.腿左接続(尾_魚D2);
    			WaistD2.腿右接続(尾_魚D2.Get逆());
    			WaistD2.EnumEleD().SetValuesD<WaistD>("鱗", true);
    			WaistD2.EnumEleD().SetValuesD<WaistSkinD>("鱗", true);
    			break;
    		}
    		default:
    		{
    			WaistD2.EnumEleD().SetValuesD<WaistSkinD>("獣毛", true);
    			手_人D e = new 手_人D();
    			LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    			LowerArm_人D2.手接続(e);
    			UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    			UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    			ShoulderD ShoulderD2 = new ShoulderD();
    			ShoulderD2.UpperArm接続(UpperArm_人D2);
    			ChestD2.肩左接続(ShoulderD2);
    			ChestD2.肩右接続(ShoulderD2.Get逆());
    			四足胸D 四足胸D2 = Uni.四足胸();
    			WaistD2.半身接続(四足胸D2);
    			四足胴D 四足胴D2 = Uni.四足胴();
    			四足胸D2.胴接続(四足胴D2);
    			四足腰D 四足腰D2 = Uni.四足腰();
    			四足胴D2.腰接続(四足腰D2);
    			四足腰D2.SetValuesD("尺度YB", 0.9);
    			四足胴D2.SetValuesD("尺度YB", 0.8);
    			四足胸D2.SetValuesD("尺度YB", 0.8);
    			手_鳥D 手_鳥D2 = new 手_鳥D();
    			手_鳥D2.シャープ = 1.0;
    			LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D();
    			LowerArm_鳥D2.手接続(手_鳥D2);
    			LowerArm_鳥D2.シャープ = 1.0;
    			UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D();
    			UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    			UpperArm_鳥D2.シャープ = 1.0;
    			四足胸D2.翼上左接続(UpperArm_鳥D2);
    			四足胸D2.翼上右接続(UpperArm_鳥D2.Get逆());
    			足_鳥D e2 = new 足_鳥D();
    			Leg_鳥D Leg_鳥D2 = new Leg_鳥D();
    			Leg_鳥D2.足接続(e2);
    			腿_鳥D 腿_鳥D2 = new 腿_鳥D();
    			腿_鳥D2.Leg接続(Leg_鳥D2);
    			四足腰D2.腿左接続(腿_鳥D2);
    			四足腰D2.腿右接続(腿_鳥D2.Get逆());
    			四足腰D2.尾接続(new 尾_鳥D());
    			四足胴D2.SetValuesD("獣毛", true);
    			WaistD2.EnumEleD().SetValuesD<性器_人D>("表示", false);
    			WaistD2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    			break;
    		}
    		}
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getユニコーン()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R1();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳獣();
    		頭D2.額接続(new 角1_一D());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		obj.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		手_馬D e2 = new 手_馬D();
    		LowerArm_蹄D LowerArm_蹄D2 = new LowerArm_蹄D();
    		LowerArm_蹄D2.手接続(e2);
    		UpperArm_蹄D UpperArm_蹄D2 = new UpperArm_蹄D();
    		UpperArm_蹄D2.LowerArm接続(LowerArm_蹄D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_蹄D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_馬D e3 = new 足_馬D();
    		Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    		Leg_蹄D2.足接続(e3);
    		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    		腿_蹄D2.Leg接続(Leg_蹄D2);
    		四足腰D2.腿左接続(腿_蹄D2);
    		四足腰D2.腿右接続(腿_蹄D2.Get逆());
    		四足腰D2.尾接続(new 尾_馬D());
    		obj.EnumEleD().SetValuesD<HeadD>("馬", Rng.XS.NextBool());
    		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<WaistSkinD>("獣性", true);
    		四足腰D2.EnumEleD().SetValuesD<WaistSkinD>("獣性", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getモノケロス()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R1();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳獣();
    		頭D2.額接続(new 角1_一D
    		{
    			尺度YB = 2.0
    		});
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		obj.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		四足胸D2.背中接続(new 背中_羽D
    		{
    			毛 = true
    		});
    		手_牛D e2 = new 手_牛D();
    		LowerArm_蹄D LowerArm_蹄D2 = new LowerArm_蹄D();
    		LowerArm_蹄D2.手接続(e2);
    		UpperArm_蹄D UpperArm_蹄D2 = new UpperArm_蹄D();
    		UpperArm_蹄D2.LowerArm接続(LowerArm_蹄D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_蹄D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_牛D e3 = new 足_牛D();
    		Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    		Leg_蹄D2.足接続(e3);
    		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    		腿_蹄D2.Leg接続(Leg_蹄D2);
    		四足腰D2.腿左接続(腿_蹄D2);
    		四足腰D2.腿右接続(腿_蹄D2.Get逆());
    		四足腰D2.尾接続(new 尾_牛D());
    		obj.EnumEleD().SetValuesD<HeadD>("馬", true);
    		obj.EnumEleD().SetValuesD("胸毛", true);
    		obj.EnumEleD().SetValuesD<頬肌D>("獣毛", true);
    		obj.EnumEleD().SetValuesD<ChestD>("獣毛", true);
    		obj.EnumEleD().SetValuesD<WaistD>("獣毛", true);
    		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<WaistSkinD>("獣性", true);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getアリコーン()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R1();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳獣();
    		頭D2.額接続(new 角1_一D());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		obj.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		手_鳥D 手_鳥D2 = new 手_鳥D
    		{
    			シャープ = Rng.XS.NextDouble()
    		};
    		LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D
    		{
    			シャープ = 手_鳥D2.シャープ
    		};
    		LowerArm_鳥D2.手接続(手_鳥D2);
    		UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D
    		{
    			シャープ = LowerArm_鳥D2.シャープ
    		};
    		UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    		四足胸D2.翼上左接続(UpperArm_鳥D2);
    		四足胸D2.翼上右接続(UpperArm_鳥D2.Get逆());
    		手_馬D e2 = new 手_馬D();
    		LowerArm_蹄D LowerArm_蹄D2 = new LowerArm_蹄D();
    		LowerArm_蹄D2.手接続(e2);
    		UpperArm_蹄D UpperArm_蹄D2 = new UpperArm_蹄D();
    		UpperArm_蹄D2.LowerArm接続(LowerArm_蹄D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_蹄D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_馬D e3 = new 足_馬D();
    		Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    		Leg_蹄D2.足接続(e3);
    		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    		腿_蹄D2.Leg接続(Leg_蹄D2);
    		四足腰D2.腿左接続(腿_蹄D2);
    		四足腰D2.腿右接続(腿_蹄D2.Get逆());
    		四足腰D2.尾接続(new 尾_馬D());
    		obj.EnumEleD().SetValuesD<HeadD>("馬", Rng.XS.NextBool());
    		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<WaistSkinD>("獣性", true);
    		四足腰D2.EnumEleD().SetValuesD<WaistSkinD>("獣性", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getバイコーン()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD ChestD2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳獣();
    		ElementData eleD2 = new 角2_山2D
    		{
    			尺度YB = 1.5
    		};
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		obj.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		手_馬D e2 = new 手_馬D();
    		LowerArm_蹄D LowerArm_蹄D2 = new LowerArm_蹄D();
    		LowerArm_蹄D2.手接続(e2);
    		UpperArm_蹄D UpperArm_蹄D2 = new UpperArm_蹄D();
    		UpperArm_蹄D2.LowerArm接続(LowerArm_蹄D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_蹄D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_馬D e3 = new 足_馬D();
    		Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    		Leg_蹄D2.足接続(e3);
    		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    		腿_蹄D2.Leg接続(Leg_蹄D2);
    		四足腰D2.腿左接続(腿_蹄D2);
    		四足腰D2.腿右接続(腿_蹄D2.Get逆());
    		四足腰D2.尾接続(new 尾_馬D());
    		obj.EnumEleD().SetValuesD<HeadD>("馬", Rng.XS.NextBool());
    		ChestD2.肌_接続.SetValuesD("胸毛", true);
    		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<WaistSkinD>("獣性", true);
    		四足腰D2.EnumEleD().SetValuesD<WaistSkinD>("獣性", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getペガサス()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳獣();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		obj.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		手_鳥D 手_鳥D2 = new 手_鳥D
    		{
    			シャープ = Rng.XS.NextDouble()
    		};
    		LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D
    		{
    			シャープ = 手_鳥D2.シャープ
    		};
    		LowerArm_鳥D2.手接続(手_鳥D2);
    		UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D
    		{
    			シャープ = LowerArm_鳥D2.シャープ
    		};
    		UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    		四足胸D2.翼上左接続(UpperArm_鳥D2);
    		四足胸D2.翼上右接続(UpperArm_鳥D2.Get逆());
    		手_馬D e2 = new 手_馬D();
    		LowerArm_蹄D LowerArm_蹄D2 = new LowerArm_蹄D();
    		LowerArm_蹄D2.手接続(e2);
    		UpperArm_蹄D UpperArm_蹄D2 = new UpperArm_蹄D();
    		UpperArm_蹄D2.LowerArm接続(LowerArm_蹄D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_蹄D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_馬D e3 = new 足_馬D();
    		Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    		Leg_蹄D2.足接続(e3);
    		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    		腿_蹄D2.Leg接続(Leg_蹄D2);
    		四足腰D2.腿左接続(腿_蹄D2);
    		四足腰D2.腿右接続(腿_蹄D2.Get逆());
    		四足腰D2.尾接続(new 尾_馬D());
    		obj.EnumEleD().SetValuesD<HeadD>("馬", Rng.XS.NextBool());
    		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<WaistSkinD>("獣性", true);
    		四足腰D2.EnumEleD().SetValuesD<WaistSkinD>("獣性", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getグリフォン()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳羽();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		obj.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		四足胸D2.背中接続(new 背中_羽D
    		{
    			毛 = true
    		});
    		手_鳥D 手_鳥D2 = new 手_鳥D();
    		LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D();
    		LowerArm_鳥D2.手接続(手_鳥D2);
    		UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D();
    		UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    		if (Rng.XS.NextBool())
    		{
    			手_鳥D2.シャープ = 1.0;
    			LowerArm_鳥D2.シャープ = 1.0;
    			UpperArm_鳥D2.シャープ = 1.0;
    		}
    		四足胸D2.翼上左接続(UpperArm_鳥D2);
    		四足胸D2.翼上右接続(UpperArm_鳥D2.Get逆());
    		四足胸D2.背中接続(new 背中_羽D());
    		足_鳥D e2 = new 足_鳥D();
    		Leg_鳥D Leg_鳥D2 = new Leg_鳥D();
    		Leg_鳥D2.足接続(e2);
    		Leg_鳥D2.尺度B = 1.3;
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(Leg_鳥D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_獣D e3 = new 足_獣D();
    		Leg_獣D Leg_獣D2 = new Leg_獣D();
    		Leg_獣D2.足接続(e3);
    		腿_獣D 腿_獣D2 = new 腿_獣D();
    		腿_獣D2.Leg接続(Leg_獣D2);
    		四足腰D2.腿左接続(腿_獣D2);
    		四足腰D2.腿右接続(腿_獣D2.Get逆());
    		四足腰D2.尾接続(new 尾_牛D());
    		四足胴D2.SetValuesD("獣毛", true);
    		obj.EnumEleD().SetValuesD<WaistSkinD>("獣毛", true);
    		obj.EnumEleD().SetValuesD<胸毛D>("表示", true);
    		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getヒッポグリフ()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳羽();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		obj.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		四足胸D2.背中接続(new 背中_羽D
    		{
    			毛 = true
    		});
    		手_鳥D 手_鳥D2 = new 手_鳥D();
    		LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D();
    		LowerArm_鳥D2.手接続(手_鳥D2);
    		UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D();
    		UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    		if (Rng.XS.NextBool())
    		{
    			手_鳥D2.シャープ = 1.0;
    			LowerArm_鳥D2.シャープ = 1.0;
    			UpperArm_鳥D2.シャープ = 1.0;
    		}
    		四足胸D2.翼上左接続(UpperArm_鳥D2);
    		四足胸D2.翼上右接続(UpperArm_鳥D2.Get逆());
    		四足胸D2.背中接続(new 背中_羽D());
    		足_鳥D e2 = new 足_鳥D();
    		Leg_鳥D Leg_鳥D2 = new Leg_鳥D
    		{
    			尺度B = 1.3
    		};
    		Leg_鳥D2.足接続(e2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(Leg_鳥D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_馬D e3 = new 足_馬D();
    		Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    		Leg_蹄D2.足接続(e3);
    		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    		腿_蹄D2.Leg接続(Leg_蹄D2);
    		四足腰D2.腿左接続(腿_蹄D2);
    		四足腰D2.腿右接続(腿_蹄D2.Get逆());
    		四足腰D2.尾接続(new 尾_馬D());
    		obj.EnumEleD().SetValuesD<HeadD>("馬", Rng.XS.NextBool());
    		四足胴D2.SetValuesD("獣毛", true);
    		obj.EnumEleD().SetValuesD<WaistSkinD>("獣毛", true);
    		obj.EnumEleD().SetValuesD<胸毛D>("表示", true);
    		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		四足胴D2.SetValuesD("獣性", false);
    		四足腰D2.EnumEleD().SetValuesD<WaistSkinD>("獣性", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getキマイラ()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻R();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		ElementData eleD2 = new 獣耳D();
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		eleD2 = Rng.XS.Next(3) switch
    		{
    			0 => new 角2_山1D(), 
    			1 => new 角2_山2D(), 
    			_ => new 角2_山3D(), 
    		};
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		WaistD2.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		四足胸D2.背中接続(new 背中_羽D
    		{
    			毛 = true
    		});
    		手_獣D e2 = new 手_獣D();
    		LowerArm_獣D LowerArm_獣D2 = new LowerArm_獣D();
    		LowerArm_獣D2.手接続(e2);
    		UpperArm_獣D UpperArm_獣D2 = new UpperArm_獣D();
    		UpperArm_獣D2.LowerArm接続(LowerArm_獣D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_獣D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_牛D e3 = new 足_牛D();
    		Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    		Leg_蹄D2.足接続(e3);
    		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    		腿_蹄D2.Leg接続(Leg_蹄D2);
    		四足腰D2.腿左接続(腿_蹄D2);
    		四足腰D2.腿右接続(腿_蹄D2.Get逆());
    		四足腰D2.尾接続(new 尾_蛇D());
    		WaistD2.EnumEleD().SetValuesD("獣性", true);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
    		WaistD2.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getスフィンクス(bool b)
    	{
    		WaistD WaistD2 = Uni.Waist();
    		TorsoD e = WaistD2.SetTorso();
    		ChestD ChestD2 = e.SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳人();
    		if (b)
    		{
    			ElementData e2 = (Rng.XS.NextBool() ? ((尾D)new 尾_牛D()) : ((尾D)new 尾_蛇D()));
    			WaistD2.尾接続(e2);
    			ChestD2.背中接続(new 背中_羽D
    			{
    				毛 = true
    			});
    			手_鳥D e3 = new 手_鳥D();
    			LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D();
    			LowerArm_鳥D2.手接続(e3);
    			UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D();
    			UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    			ShoulderD ShoulderD2 = new ShoulderD();
    			ShoulderD2.UpperArm接続(UpperArm_鳥D2);
    			ChestD2.肩左接続(ShoulderD2);
    			ChestD2.肩右接続(ShoulderD2.Get逆());
    			手_獣D e4 = new 手_獣D
    			{
    				尺度B = 0.9
    			};
    			LowerArm_獣D LowerArm_獣D2 = new LowerArm_獣D
    			{
    				尺度B = 0.9
    			};
    			LowerArm_獣D2.手接続(e4);
    			UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    			UpperArm_人D2.LowerArm接続(LowerArm_獣D2);
    			ShoulderD ShoulderD3 = new ShoulderD();
    			ShoulderD3.UpperArm接続(UpperArm_人D2);
    			UpperArm_人D2.EnumEleD().SetValuesD("獣性", true);
    			ChestD2.肩左接続(ShoulderD3);
    			ChestD2.肩右接続(ShoulderD3.Get逆());
    			足_獣D e5 = new 足_獣D();
    			Leg_獣D Leg_獣D2 = new Leg_獣D();
    			Leg_獣D2.足接続(e5);
    			腿_獣D 腿_獣D2 = new 腿_獣D();
    			腿_獣D2.Leg接続(Leg_獣D2);
    			WaistD2.腿左接続(腿_獣D2);
    			WaistD2.腿右接続(腿_獣D2.Get逆());
    			ChestD2.肌_接続.SetValuesD<胸毛D>("表示", true);
    			ChestD2.SetValuesD("獣性", true);
    			e.SetValuesD("獣性", true);
    			WaistD2.SetValuesD("獣性", true);
    		}
    		else
    		{
    			手_鳥D e6 = new 手_鳥D();
    			LowerArm_鳥D LowerArm_鳥D3 = new LowerArm_鳥D();
    			LowerArm_鳥D3.手接続(e6);
    			UpperArm_鳥D UpperArm_鳥D3 = new UpperArm_鳥D();
    			UpperArm_鳥D3.LowerArm接続(LowerArm_鳥D3);
    			ShoulderD ShoulderD4 = new ShoulderD();
    			ShoulderD4.UpperArm接続(UpperArm_鳥D3);
    			ChestD2.肩左接続(ShoulderD4);
    			ChestD2.肩右接続(ShoulderD4.Get逆());
    			四足胸D 四足胸D2 = Uni.四足胸();
    			WaistD2.半身接続(四足胸D2);
    			四足胴D 四足胴D2 = Uni.四足胴();
    			四足胸D2.胴接続(四足胴D2);
    			四足腰D 四足腰D2 = Uni.四足腰();
    			四足胴D2.腰接続(四足腰D2);
    			四足胸D2.背中接続(new 背中_羽D
    			{
    				毛 = true
    			});
    			手_獣D e7 = new 手_獣D();
    			LowerArm_獣D LowerArm_獣D3 = new LowerArm_獣D();
    			LowerArm_獣D3.手接続(e7);
    			UpperArm_獣D UpperArm_獣D2 = new UpperArm_獣D();
    			UpperArm_獣D2.LowerArm接続(LowerArm_獣D3);
    			四足脇D 四足脇D2 = new 四足脇D();
    			四足脇D2.UpperArm接続(UpperArm_獣D2);
    			四足胸D2.脇左接続(四足脇D2);
    			四足胸D2.脇右接続(四足脇D2.Get逆());
    			足_獣D e8 = new 足_獣D();
    			Leg_獣D Leg_獣D3 = new Leg_獣D();
    			Leg_獣D3.足接続(e8);
    			腿_獣D 腿_獣D3 = new 腿_獣D();
    			腿_獣D3.Leg接続(Leg_獣D3);
    			四足腰D2.腿左接続(腿_獣D3);
    			四足腰D2.腿右接続(腿_獣D3.Get逆());
    			ElementData e2 = (Rng.XS.NextBool() ? ((尾D)new 尾_牛D()) : ((尾D)new 尾_蛇D()));
    			四足腰D2.尾接続(e2);
    			四足胴D2.SetValuesD("獣毛", true);
    			四足胸D2.肌_接続.SetValuesD<胸毛D>("表示", true);
    			WaistD2.EnumEleD().SetValuesD<性器_人D>("表示", false);
    			WaistD2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		}
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD<WaistSkinD>("獣性", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getレオントケンタウレ()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD ChestD2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻R();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		ElementData eleD2 = new 獣耳D();
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		obj.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		四足胸D2.背中接続(new 背中_羽D
    		{
    			毛 = true
    		});
    		手_獣D e2 = new 手_獣D();
    		LowerArm_獣D LowerArm_獣D2 = new LowerArm_獣D();
    		LowerArm_獣D2.手接続(e2);
    		UpperArm_獣D UpperArm_獣D2 = new UpperArm_獣D();
    		UpperArm_獣D2.LowerArm接続(LowerArm_獣D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_獣D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_獣D e3 = new 足_獣D();
    		Leg_獣D Leg_獣D2 = new Leg_獣D();
    		Leg_獣D2.足接続(e3);
    		腿_獣D 腿_獣D2 = new 腿_獣D();
    		腿_獣D2.Leg接続(Leg_獣D2);
    		四足腰D2.腿左接続(腿_獣D2);
    		四足腰D2.腿右接続(腿_獣D2.Get逆());
    		四足腰D2.尾接続(new 尾_牛D());
    		obj.EnumEleD().SetValuesD("獣性", true);
    		obj.EnumEleD().SetValuesD<LowerArm_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
    		ChestD2.肌_接続.SetValuesD("胸毛", false);
    		obj.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
    		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getティグリスケンタウレ()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = obj.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻R();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		ElementData eleD2 = new 獣耳D();
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		WaistD2.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		手_獣D e2 = new 手_獣D();
    		LowerArm_獣D LowerArm_獣D2 = new LowerArm_獣D();
    		LowerArm_獣D2.手接続(e2);
    		UpperArm_獣D UpperArm_獣D2 = new UpperArm_獣D();
    		UpperArm_獣D2.LowerArm接続(LowerArm_獣D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_獣D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_獣D e3 = new 足_獣D();
    		Leg_獣D Leg_獣D2 = new Leg_獣D();
    		Leg_獣D2.足接続(e3);
    		腿_獣D 腿_獣D2 = new 腿_獣D();
    		腿_獣D2.Leg接続(Leg_獣D2);
    		四足腰D2.腿左接続(腿_獣D2);
    		四足腰D2.腿右接続(腿_獣D2.Get逆());
    		四足腰D2.尾接続(new 尾_猫D());
    		WaistD2.EnumEleD().SetValuesD("獣性", true);
    		WaistD2.EnumEleD().SetValuesD<LowerArm_人D>("配色指定", 配色指定.B0);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
    		if (Rng.XS.NextBool())
    		{
    			WaistD2.EnumEleD().SetValuesD<獣耳D>("配色指定", 配色指定.T0);
    			WaistD2.EnumEleD().SetValuesD<尾_猫D>("配色指定", 配色指定.T0);
    		}
    		else
    		{
    			WaistD2.EnumEleD().SetValuesD<獣耳D>("配色指定", 配色指定.T1);
    			WaistD2.EnumEleD().SetValuesD<尾_猫D>("配色指定", 配色指定.T1);
    		}
    		四足胸D2.肌_接続.SetValuesD("胸毛", false);
    		WaistD2.EnumEleD().SetValuesD("虎", true);
    		WaistD2.EnumEleD().SetValuesD<頬肌D>("隈取", true);
    		WaistD2.EnumEleD().SetValuesD<頬肌D>("獣性", false);
    		WaistD2.EnumEleD().SetValuesD<UpperArm_人D>("淫", true);
    		WaistD2.EnumEleD().SetValuesD<UpperArm_人D>("ハート", false);
    		WaistD2.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getパンテーラケンタウレ()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻R();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		ElementData eleD2 = new 獣耳D();
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		obj.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		手_獣D e2 = new 手_獣D();
    		LowerArm_獣D LowerArm_獣D2 = new LowerArm_獣D();
    		LowerArm_獣D2.手接続(e2);
    		UpperArm_獣D UpperArm_獣D2 = new UpperArm_獣D();
    		UpperArm_獣D2.LowerArm接続(LowerArm_獣D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_獣D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_獣D e3 = new 足_獣D();
    		Leg_獣D Leg_獣D2 = new Leg_獣D();
    		Leg_獣D2.足接続(e3);
    		腿_獣D 腿_獣D2 = new 腿_獣D();
    		腿_獣D2.Leg接続(Leg_獣D2);
    		四足腰D2.腿左接続(腿_獣D2);
    		四足腰D2.腿右接続(腿_獣D2.Get逆());
    		四足腰D2.尾接続(new 尾_猫D());
    		obj.EnumEleD().SetValuesD("獣性", true);
    		obj.EnumEleD().SetValuesD<LowerArm_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD("胸毛", false);
    		obj.EnumEleD().SetValuesD("紋柄", true);
    		obj.EnumEleD().SetValuesD<鼻肌D>("紋柄", false);
    		obj.EnumEleD().SetValuesD<頬肌D>("獣性", false);
    		obj.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
    		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getチータケンタウレ()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻R();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		ElementData eleD2 = new 獣耳D();
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		double num = 0.95;
    		四足胸D 四足胸D2 = Uni.四足胸();
    		obj.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		四足胸D2.EnumEleD().SetValuesD("尺度XB", num);
    		手_獣D e2 = new 手_獣D();
    		LowerArm_獣D LowerArm_獣D2 = new LowerArm_獣D();
    		LowerArm_獣D2.手接続(e2);
    		UpperArm_獣D UpperArm_獣D2 = new UpperArm_獣D();
    		UpperArm_獣D2.LowerArm接続(LowerArm_獣D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_獣D2);
    		num = 1.035;
    		LowerArm_獣D2.EnumEleD().SetValuesD("尺度YB", num);
    		UpperArm_獣D2.尺度XB = num;
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_獣D e3 = new 足_獣D();
    		Leg_獣D Leg_獣D2 = new Leg_獣D();
    		Leg_獣D2.足接続(e3);
    		腿_獣D 腿_獣D2 = new 腿_獣D();
    		腿_獣D2.Leg接続(Leg_獣D2);
    		Leg_獣D2.EnumEleD().SetValuesD("尺度YB", num);
    		腿_獣D2.尺度XB = num;
    		四足腰D2.腿左接続(腿_獣D2);
    		四足腰D2.腿右接続(腿_獣D2.Get逆());
    		四足腰D2.尾接続(new 尾_猫D());
    		四足腰D2.EnumEleD().SetValuesD("肥大", 0.5);
    		obj.EnumEleD().SetValuesD("獣性", true);
    		obj.EnumEleD().SetValuesD<LowerArm_人D>("獣腕", false);
    		obj.EnumEleD().SetValuesD<手_人D>("獣性", false);
    		obj.EnumEleD().SetValuesD<手_人D>("獣毛", true);
    		obj.EnumEleD().SetValuesD<手_人D>("肉球", true);
    		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD<LowerArm_人D>("配色指定", 配色指定.B0);
    		obj.EnumEleD().SetValuesD("胸毛", false);
    		obj.EnumEleD().SetValuesD("紋柄", true);
    		obj.EnumEleD().SetValuesD<鼻肌D>("紋柄", false);
    		obj.EnumEleD().SetValuesD<頬肌D>("獣性", false);
    		obj.EnumEleD().SetValuesD<頬肌D>("豹", true);
    		obj.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
    		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getウェアドラゴンフライ()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口R();
    		頭D2.Set舌短();
    		頭D2.Set耳尖();
    		ElementData elementData = new 虫顎D();
    		頭D2.頬左接続(elementData);
    		頭D2.頬右接続(elementData.Get逆());
    		顔面_虫D 顔面_虫D2 = new 顔面_虫D();
    		elementData = new 触覚_線D
    		{
    			尺度YB = 0.4
    		};
    		顔面_虫D2.触覚左接続(elementData);
    		顔面_虫D2.触覚右接続(elementData.Get逆());
    		頭D2.顔面接続(顔面_虫D2);
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		obj2.肩左接続(ShoulderD2.Copy());
    		obj2.肩右接続(ShoulderD2.Get逆());
    		elementData = new 前翅_羽D();
    		obj2.翼上左接続(elementData);
    		obj2.翼上右接続(elementData.Get逆());
    		elementData = new 後翅_羽D();
    		obj2.翼下左接続(elementData);
    		obj2.翼下右接続(elementData.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		elementData = new 尾_竜D();
    		obj.尾接続(elementData);
    		obj.EnumEleD().SetValuesD("虫性", true);
    		obj.EnumEleD().SetValuesD("虫手", true);
    		obj.EnumEleD().SetValuesD("虫足", true);
    		obj.EnumEleD().SetValuesD("虫鎌節", false);
    		obj.EnumEleD().SetValuesD<手_人D>("鱗", true);
    		obj.EnumEleD().SetValuesD<足_人D>("鱗", true);
    		obj.EnumEleD().SetValuesD("配色", 配色指定.C0);
    		obj.EnumEleD().SetValuesD<双目D>("瞳孔", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getウェアビートル()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳尖();
    		頭D2.額接続(new 角1_虫D());
    		ElementData elementData = new 虫顎D();
    		頭D2.頬左接続(elementData);
    		頭D2.頬右接続(elementData.Get逆());
    		顔面_甲D 顔面_甲D2 = new 顔面_甲D();
    		elementData = new 触覚_甲D();
    		顔面_甲D2.触覚左接続(elementData);
    		顔面_甲D2.触覚右接続(elementData.Get逆());
    		頭D2.顔面接続(顔面_甲D2);
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		obj2.肩左接続(ShoulderD2.Copy());
    		obj2.肩右接続(ShoulderD2.Get逆());
    		elementData = new 後翅_甲D();
    		obj2.翼上左接続(elementData);
    		obj2.翼上右接続(elementData.Get逆());
    		elementData = new 前翅_甲D();
    		elementData.SetValuesD("紋", Rng.XS.NextBool());
    		obj2.翼上左接続(elementData);
    		obj2.翼上右接続(elementData.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		obj.EnumEleD().SetValuesD("虫性", true);
    		obj.EnumEleD().SetValuesD("虫手", true);
    		obj.EnumEleD().SetValuesD("虫足", true);
    		obj.EnumEleD().SetValuesD("虫鎌節", false);
    		obj.EnumEleD().SetValuesD<手_人D>("鱗", true);
    		obj.EnumEleD().SetValuesD<足_人D>("鱗", true);
    		obj.EnumEleD().SetValuesD("配色", 配色指定.C0);
    		obj.EnumEleD().SetValuesD("棘3", false);
    		obj.EnumEleD().SetValuesD("棘4", false);
    		obj.EnumEleD().SetValuesD<双目D>("瞳孔", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getウェアスタッグビートル()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳尖();
    		ElementData elementData = new 耳_尖D();
    		頭D2.耳左接続(elementData);
    		頭D2.耳右接続(elementData.Get逆());
    		大顎基D 大顎基D2 = new 大顎基D();
    		elementData = new 大顎D();
    		大顎基D2.顎左接続(elementData);
    		大顎基D2.顎右接続(elementData.Get逆());
    		頭D2.大顎基接続(大顎基D2);
    		顔面_甲D 顔面_甲D2 = new 顔面_甲D();
    		elementData = new 触覚_甲D();
    		顔面_甲D2.触覚左接続(elementData);
    		顔面_甲D2.触覚右接続(elementData.Get逆());
    		頭D2.顔面接続(顔面_甲D2);
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		obj2.肩左接続(ShoulderD2.Copy());
    		obj2.肩右接続(ShoulderD2.Get逆());
    		elementData = new 後翅_甲D();
    		obj2.翼上左接続(elementData);
    		obj2.翼上右接続(elementData.Get逆());
    		elementData = new 前翅_甲D();
    		elementData.SetValuesD("紋", Rng.XS.NextBool());
    		obj2.翼上左接続(elementData);
    		obj2.翼上右接続(elementData.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		obj.EnumEleD().SetValuesD("虫性", true);
    		obj.EnumEleD().SetValuesD("虫手", true);
    		obj.EnumEleD().SetValuesD("虫足", true);
    		obj.EnumEleD().SetValuesD("虫鎌節", false);
    		obj.EnumEleD().SetValuesD<手_人D>("鱗", true);
    		obj.EnumEleD().SetValuesD<足_人D>("鱗", true);
    		obj.EnumEleD().SetValuesD("配色", 配色指定.C0);
    		obj.EnumEleD().SetValuesD<Leg_人D>("棘", false);
    		obj.EnumEleD().SetValuesD<双目D>("瞳孔", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getウェアマンティス()
    	{
    		WaistD obj = Uni.Waist();
    		TorsoD obj2 = obj.SetTorso();
    		ChestD obj3 = obj2.SetChestR();
    		HeadD 頭D2 = obj3.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口R();
    		頭D2.Set舌短();
    		頭D2.Set耳尖();
    		ElementData elementData = new 虫顎D();
    		頭D2.頬左接続(elementData);
    		頭D2.頬右接続(elementData.Get逆());
    		顔面_虫D 顔面_虫D2 = new 顔面_虫D();
    		elementData = new 触覚_線D();
    		顔面_虫D2.触覚左接続(elementData);
    		顔面_虫D2.触覚右接続(elementData.Get逆());
    		頭D2.顔面接続(顔面_虫D2);
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		LowerArm_人D2.虫鎌接続(new 虫鎌D());
    		obj3.肩左接続(ShoulderD2);
    		obj3.肩右接続(ShoulderD2.Get逆());
    		elementData = new 前翅_草D();
    		elementData.SetValuesD("紋", Rng.XS.NextBool());
    		obj2.翼左接続(elementData);
    		obj2.翼右接続(elementData.Get逆());
    		elementData = new 後翅_草D();
    		obj2.翼左接続(elementData);
    		obj2.翼右接続(elementData.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		elementData = new 尾_虫D();
    		obj.尾接続(elementData);
    		obj.EnumEleD().SetValuesD("虫性", true);
    		obj.EnumEleD().SetValuesD("虫手", true);
    		obj.EnumEleD().SetValuesD("虫足", true);
    		obj.EnumEleD().SetValuesD<手_人D>("鱗", true);
    		obj.EnumEleD().SetValuesD<足_人D>("鱗", true);
    		obj.EnumEleD().SetValuesD("配色", 配色指定.C0);
    		obj.EnumEleD().SetValuesD<Leg_人D>("棘2", false);
    		obj.EnumEleD().SetValuesD<Leg_人D>("棘3", false);
    		obj.EnumEleD().SetValuesD<双目D>("瞳孔", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getエキドナ()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = obj.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌長();
    		if (Rng.XS.NextBool())
    		{
    			頭D2.Set耳人();
    		}
    		else
    		{
    			頭D2.Set耳尖();
    		}
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		手_鳥D 手_鳥D2 = new 手_鳥D
    		{
    			シャープ = Rng.XS.NextDouble()
    		};
    		LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D
    		{
    			シャープ = 手_鳥D2.シャープ
    		};
    		LowerArm_鳥D2.手接続(手_鳥D2);
    		UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D
    		{
    			シャープ = LowerArm_鳥D2.シャープ
    		};
    		UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    		obj.翼上左接続(UpperArm_鳥D2);
    		obj.翼上右接続(UpperArm_鳥D2.Get逆());
    		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
    		WaistD2.半身接続(長物_蛇D2);
    		Torso_蛇D Torso_蛇D2 = new Torso_蛇D();
    		長物_蛇D2.胴接続(Torso_蛇D2);
    		for (int i = 0; i < 45; i++)
    		{
    			Torso_蛇D2.Torso接続(Torso_蛇D2 = new Torso_蛇D());
    		}
    		Torso_蛇D2.Torso接続(Rng.XS.NextBool() ? ((尾D)new 尾_ヘD()) : ((尾D)new 尾_ガD()));
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD<Tounge_長D>("股舌表示", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getゴルゴン()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		BackHair0_肢系D 後髪0_肢系D2 = new BackHair0_肢系D();
    		ElementData eleD2 = new 尾_蛇D();
    		後髪0_肢系D2.左5接続(eleD2);
    		後髪0_肢系D2.左4接続(eleD2.Copy());
    		後髪0_肢系D2.左3接続(eleD2.Copy());
    		後髪0_肢系D2.左2接続(eleD2.Copy());
    		後髪0_肢系D2.左1接続(eleD2.Copy());
    		後髪0_肢系D2.右1接続(eleD2.Copy());
    		後髪0_肢系D2.右2接続(eleD2.Copy());
    		後髪0_肢系D2.右3接続(eleD2.Copy());
    		後髪0_肢系D2.右4接続(eleD2.Copy());
    		後髪0_肢系D2.右5接続(eleD2.Copy());
    		eleD.後髪_接続.RemoveAt(0);
    		eleD.後髪_接続.Insert(0, 後髪0_肢系D2);
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口裂();
    		頭D2.Set舌長();
    		頭D2.Set耳尖();
    		頭D2.額接続(SlaveMatrix.GameClasses._Con.Get縦眼R());
    		eleD2 = SlaveMatrix.GameClasses._Con.Get頬眼R(右: false);
    		頭D2.頬肌左接続(eleD2);
    		頭D2.頬肌右接続(eleD2.Get逆());
    		eleD2 = Rng.XS.Next(3) switch
    		{
    			0 => new 角2_牛1D(), 
    			1 => new 角2_牛4D(), 
    			_ => new 角2_鬼D(), 
    		};
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		WaistD2.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		手_鳥D 手_鳥D2 = new 手_鳥D
    		{
    			シャープ = Rng.XS.NextDouble()
    		};
    		LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D
    		{
    			シャープ = 手_鳥D2.シャープ
    		};
    		LowerArm_鳥D2.手接続(手_鳥D2);
    		UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D
    		{
    			シャープ = LowerArm_鳥D2.シャープ
    		};
    		UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    		四足胸D2.翼上左接続(UpperArm_鳥D2);
    		四足胸D2.翼上右接続(UpperArm_鳥D2.Get逆());
    		足_馬D e2 = new 足_馬D();
    		Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    		Leg_蹄D2.足接続(e2);
    		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    		腿_蹄D2.Leg接続(Leg_蹄D2);
    		四足腰D2.腿左接続(腿_蹄D2);
    		四足腰D2.腿右接続(腿_蹄D2.Get逆());
    		四足腰D2.尾接続(new 尾_馬D());
    		WaistD2.EnumEleD().SetValuesD<UpperArm_人D>("竜性", true);
    		WaistD2.EnumEleD().SetValuesD<LowerArm_人D>("竜性", true);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("鱗", true);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("配色", 配色指定.S0);
    		WaistD2.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getヒュドラ()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		HeadD 頭D2 = WaistD2.SetTorso().SetChestR().SetNeck()
    			.Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		BackHair0_肢系D 後髪0_肢系D2 = new BackHair0_肢系D();
    		ElementData eleD2 = new 尾_蛇D();
    		後髪0_肢系D2.左5接続(eleD2);
    		後髪0_肢系D2.左4接続(eleD2.Copy());
    		後髪0_肢系D2.左3接続(eleD2.Copy());
    		後髪0_肢系D2.左2接続(eleD2.Copy());
    		後髪0_肢系D2.左1接続(eleD2.Copy());
    		後髪0_肢系D2.右1接続(eleD2.Copy());
    		後髪0_肢系D2.右2接続(eleD2.Copy());
    		後髪0_肢系D2.右3接続(eleD2.Copy());
    		後髪0_肢系D2.右4接続(eleD2.Copy());
    		後髪0_肢系D2.右5接続(eleD2.Copy());
    		eleD.後髪_接続.RemoveAt(0);
    		eleD.後髪_接続.Insert(0, 後髪0_肢系D2);
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口裂();
    		頭D2.Set舌長();
    		頭D2.Set耳人();
    		頭頂_宇D 頭頂_宇D2 = new 頭頂_宇D
    		{
    			鱗 = true
    		};
    		頭頂_宇D2.頭部後接続(new 頭頂後_宇D());
    		頭D2.頭頂接続(頭頂_宇D2);
    		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
    		WaistD2.半身接続(長物_蛇D2);
    		Torso_蛇D Torso_蛇D2 = new Torso_蛇D();
    		長物_蛇D2.胴接続(Torso_蛇D2);
    		for (int i = 0; i < 45; i++)
    		{
    			Torso_蛇D2.Torso接続(Torso_蛇D2 = new Torso_蛇D());
    		}
    		Torso_蛇D2.Torso接続(new 尾_ヘD());
    		WaistD2.EnumEleD().SetValuesD("竜性", true);
    		WaistD2.EnumEleD().SetValuesD<WaistSkinD>("竜性", false);
    		WaistD2.EnumEleD().SetValuesD<Tounge_長D>("股舌表示", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getウロボロス()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		HeadD 頭D2 = WaistD2.SetTorso().SetChestR().SetNeck()
    			.Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口裂();
    		頭D2.Set舌長();
    		頭D2.Set耳人();
    		頭D2.額接続(new 角1_虫D());
    		ElementData eleD2 = new 角2_虫D();
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		顔面_甲D e = new 顔面_甲D();
    		頭D2.顔面接続(e);
    		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
    		WaistD2.半身接続(長物_蛇D2);
    		Torso_蛇D Torso_蛇D2 = new Torso_蛇D();
    		長物_蛇D2.胴接続(Torso_蛇D2);
    		for (int i = 0; i < 40; i++)
    		{
    			Torso_蛇D2.Torso接続(Torso_蛇D2 = new Torso_蛇D());
    		}
    		Torso_蛇D2.Torso接続(new 尾_ヘD());
    		WaistD2.EnumEleD().SetValuesD("竜性", true);
    		WaistD2.EnumEleD().SetValuesD<WaistSkinD>("竜性", false);
    		WaistD2.EnumEleD().SetValuesD("コア1", true);
    		WaistD2.EnumEleD().SetValuesD<Tounge_長D>("股舌表示", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getカッパ()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = obj.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳尖();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		頭D2.頭頂接続(new 頭頂_皿D());
    		obj.背中接続(new 背中_甲D
    		{
    			縁側角 = Rng.XS.NextDouble()
    		});
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		WaistD2.腿左接続(腿_人D2);
    		WaistD2.腿右接続(腿_人D2.Get逆());
    		if (Rng.XS.NextBool())
    		{
    			ElementData e3 = new 尾_短D();
    			WaistD2.尾接続(e3);
    		}
    		WaistD2.EnumEleD().SetValuesD("腹板", true);
    		WaistD2.EnumEleD().SetValuesD<胸腹板D>("表示", true);
    		WaistD2.EnumEleD().SetValuesD<胴腹板D>("表示", true);
    		WaistD2.EnumEleD().SetValuesD<PregnantBellyPlateD>("表示", false);
    		WaistD2.EnumEleD().SetValuesD("水掻", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getムカデジョウロウ()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口R();
    		頭D2.Set舌短();
    		頭D2.Set耳人();
    		ElementData elementData;
    		if (Rng.XS.NextBool())
    		{
    			elementData = new 虫顎D
    			{
    				尺度B = 1.1
    			};
    			頭D2.頬左接続(elementData);
    			頭D2.頬右接続(elementData.Get逆());
    		}
    		if (Rng.XS.NextBool())
    		{
    			elementData = new 触覚_節D
    			{
    				尺度B = 1.4
    			};
    			頭D2.触覚左接続(elementData);
    			頭D2.触覚右接続(elementData.Get逆());
    		}
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		if (Rng.XS.NextBool())
    		{
    			ChestD2.肩左接続(ShoulderD2.Copy());
    			ChestD2.肩右接続(ShoulderD2.Get逆());
    			ChestD2.肩左接続(ShoulderD2.Copy());
    			ChestD2.肩右接続(ShoulderD2.Get逆());
    		}
    		長物_蟲D 長物_蟲D2 = new 長物_蟲D();
    		WaistD2.半身接続(長物_蟲D2);
    		elementData = new 節足_足百D();
    		長物_蟲D2.左0接続(elementData);
    		長物_蟲D2.右0接続(elementData.Get逆());
    		長物_蟲D2.左1接続(elementData.Copy());
    		長物_蟲D2.右1接続(elementData.Get逆());
    		Torso_蟲D Torso_蟲D2 = new Torso_蟲D();
    		長物_蟲D2.胴接続(Torso_蟲D2);
    		Torso_蟲D2.左接続(elementData.Copy());
    		Torso_蟲D2.右接続(elementData.Get逆());
    		for (int i = 0; i < 21; i++)
    		{
    			Torso_蟲D2.Torso接続(Torso_蟲D2 = new Torso_蟲D());
    			Torso_蟲D2.左接続(elementData.Copy());
    			Torso_蟲D2.右接続(elementData.Get逆());
    		}
    		尾_蟲D 尾_蟲D2 = new 尾_蟲D();
    		節尾_曳航D 節尾_曳航D2 = new 節尾_曳航D();
    		尾_蟲D2.左1接続(elementData.Copy());
    		尾_蟲D2.右1接続(elementData.Get逆());
    		尾_蟲D2.左2接続(elementData.Copy());
    		尾_蟲D2.右2接続(elementData.Get逆());
    		尾_蟲D2.左3接続(elementData.Copy());
    		尾_蟲D2.右3接続(elementData.Get逆());
    		尾_蟲D2.左4接続(elementData.Copy());
    		尾_蟲D2.右4接続(elementData.Get逆());
    		尾_蟲D2.左5接続(elementData.Copy());
    		尾_蟲D2.右5接続(elementData.Get逆());
    		尾_蟲D2.尾左接続(節尾_曳航D2);
    		尾_蟲D2.尾右接続(節尾_曳航D2.Get逆());
    		Torso_蟲D2.Torso接続(尾_蟲D2);
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getカーバンクル()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD obj = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = obj.SetNeck().Set頭R1();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		ElementData eleD2 = new 獣耳D
    		{
    			尺度B = 1.1,
    			尺度YB = 1.2
    		};
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		WaistD2.尾接続(new 尾_馬D());
    		obj.背中接続(new 背中_羽D
    		{
    			毛 = true
    		});
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj.肩左接続(ShoulderD2);
    		obj.肩右接続(ShoulderD2.Get逆());
    		足_獣D e2 = new 足_獣D();
    		Leg_獣D Leg_獣D2 = new Leg_獣D();
    		Leg_獣D2.足接続(e2);
    		腿_獣D 腿_獣D2 = new 腿_獣D();
    		腿_獣D2.Leg接続(Leg_獣D2);
    		WaistD2.腿左接続(腿_獣D2);
    		WaistD2.腿右接続(腿_獣D2.Get逆());
    		WaistD2.EnumEleD().SetValuesD("獣性", true);
    		WaistD2.EnumEleD().SetValuesD("秘石", true);
    		WaistD2.EnumEleD().SetValuesD<LowerArm_人D>("配色指定", 配色指定.B0);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
    		WaistD2.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getバジリスク()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		TorsoD obj = WaistD2.SetTorso();
    		HeadD 頭D2 = obj.SetChestR().SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌長();
    		頭D2.Set耳人();
    		頭頂_宇D 頭頂_宇D2 = new 頭頂_宇D
    		{
    			鱗 = true
    		};
    		頭頂_宇D2.頭部後接続(new 頭頂後_宇D());
    		頭D2.頭頂接続(頭頂_宇D2);
    		頭D2.額接続(new 角1_虫D());
    		手_鳥D 手_鳥D2 = new 手_鳥D
    		{
    			シャープ = Rng.XS.NextDouble()
    		};
    		LowerArm_鳥D LowerArm_鳥D2 = new LowerArm_鳥D
    		{
    			シャープ = 手_鳥D2.シャープ
    		};
    		LowerArm_鳥D2.手接続(手_鳥D2);
    		UpperArm_鳥D UpperArm_鳥D2 = new UpperArm_鳥D
    		{
    			シャープ = LowerArm_鳥D2.シャープ
    		};
    		UpperArm_鳥D2.LowerArm接続(LowerArm_鳥D2);
    		obj.翼左接続(UpperArm_鳥D2);
    		obj.翼右接続(UpperArm_鳥D2.Get逆());
    		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
    		WaistD2.半身接続(長物_蛇D2);
    		足_鳥D e = new 足_鳥D
    		{
    			尺度B = 1.1
    		};
    		Leg_竜D Leg_竜D2 = new Leg_竜D
    		{
    			尺度B = 1.1
    		};
    		Leg_竜D2.足接続(e);
    		四足脇D 四足脇D2 = new 四足脇D
    		{
    			尺度B = 1.1
    		};
    		四足脇D2.UpperArm接続(Leg_竜D2);
    		WaistD2.翼左接続(四足脇D2);
    		WaistD2.翼右接続(四足脇D2.Get逆());
    		Torso_蛇D Torso_蛇D2 = new Torso_蛇D();
    		長物_蛇D2.胴接続(Torso_蛇D2);
    		for (int i = 0; i < 30; i++)
    		{
    			Torso_蛇D2.Torso接続(Torso_蛇D2 = new Torso_蛇D());
    		}
    		Torso_蛇D2.Torso接続(new 尾_ヘD());
    		WaistD2.EnumEleD().SetValuesD("竜性", true);
    		WaistD2.EnumEleD().SetValuesD<WaistSkinD>("竜性", false);
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getコカトリス()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		TorsoD obj = WaistD2.SetTorso();
    		ChestD ChestD2 = obj.SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌長();
    		頭D2.Set耳羽();
    		手_蝙D e = new 手_蝙D();
    		LowerArm_蝙D LowerArm_蝙D2 = new LowerArm_蝙D();
    		LowerArm_蝙D2.手接続(e);
    		UpperArm_蝙D UpperArm_蝙D2 = new UpperArm_蝙D();
    		UpperArm_蝙D2.LowerArm接続(LowerArm_蝙D2);
    		obj.翼左接続(UpperArm_蝙D2);
    		obj.翼右接続(UpperArm_蝙D2.Get逆());
    		ChestD2.背中接続(new 背中_羽D
    		{
    			毛 = true
    		});
    		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
    		WaistD2.半身接続(長物_蛇D2);
    		足_鳥D e2 = new 足_鳥D
    		{
    			尺度B = 1.1
    		};
    		Leg_竜D Leg_竜D2 = new Leg_竜D
    		{
    			尺度B = 1.1
    		};
    		Leg_竜D2.足接続(e2);
    		四足脇D 四足脇D2 = new 四足脇D
    		{
    			尺度B = 1.1
    		};
    		四足脇D2.UpperArm接続(Leg_竜D2);
    		WaistD2.翼左接続(四足脇D2);
    		WaistD2.翼右接続(四足脇D2.Get逆());
    		Torso_蛇D Torso_蛇D2 = new Torso_蛇D();
    		長物_蛇D2.胴接続(Torso_蛇D2);
    		for (int i = 0; i < 30; i++)
    		{
    			Torso_蛇D2.Torso接続(Torso_蛇D2 = new Torso_蛇D());
    		}
    		Torso_蛇D2.Torso接続(new 尾_ヘD());
    		WaistD2.EnumEleD().SetValuesD("獣性", true);
    		WaistD2.EnumEleD().SetValuesD("竜性", true);
    		WaistD2.EnumEleD().SetValuesD<WaistSkinD>("竜性", false);
    		WaistD2.EnumEleD().SetValuesD<頬肌D>("髭", false);
    		WaistD2.EnumEleD().SetValuesD<口_通常D>("牙", true);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(b0: false));
    	}

    	public static CharacterData Getカトブレパス()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		eleD.前髪_接続.RemoveAt(0);
    		eleD.前髪接続(new 前髪_目隠れ1D());
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳獣();
    		頭D2.額接続(SlaveMatrix.GameClasses._Con.Get縦眼R());
    		ElementData eleD2 = new 角2_牛2D();
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		四足胸D 四足胸D2 = Uni.四足胸();
    		obj.半身接続(四足胸D2);
    		四足胴D 四足胴D2 = Uni.四足胴();
    		四足胸D2.胴接続(四足胴D2);
    		四足腰D 四足腰D2 = Uni.四足腰();
    		四足胴D2.腰接続(四足腰D2);
    		手_牛D e2 = new 手_牛D();
    		LowerArm_蹄D LowerArm_蹄D2 = new LowerArm_蹄D();
    		LowerArm_蹄D2.手接続(e2);
    		UpperArm_蹄D UpperArm_蹄D2 = new UpperArm_蹄D();
    		UpperArm_蹄D2.LowerArm接続(LowerArm_蹄D2);
    		四足脇D 四足脇D2 = new 四足脇D();
    		四足脇D2.UpperArm接続(UpperArm_蹄D2);
    		四足胸D2.脇左接続(四足脇D2);
    		四足胸D2.脇右接続(四足脇D2.Get逆());
    		足_牛D e3 = new 足_牛D();
    		Leg_蹄D Leg_蹄D2 = new Leg_蹄D();
    		Leg_蹄D2.足接続(e3);
    		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
    		腿_蹄D2.Leg接続(Leg_蹄D2);
    		四足腰D2.腿左接続(腿_蹄D2);
    		四足腰D2.腿右接続(腿_蹄D2.Get逆());
    		四足腰D2.尾接続(new 尾_牛D());
    		obj.EnumEleD().SetValuesD("獣性", true);
    		obj.EnumEleD().SetValuesD<頬肌D>("髭", false);
    		obj.EnumEleD().SetValuesD("猫目", true);
    		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
    		obj.EnumEleD().SetValuesD<手_人D>("肉球", false);
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: false));
    	}

    	public static CharacterData Getミノタウロス()
    	{
    		WaistD WaistD2 = Uni.Waist();
    		ChestD ChestD2 = WaistD2.SetTorso().SetChestR();
    		HeadD 頭D2 = ChestD2.SetNeck().Set頭R();
    		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳獣();
    		ElementData eleD2 = Rng.XS.Next(4) switch
    		{
    			0 => new 角2_牛1D(), 
    			1 => new 角2_牛2D(), 
    			2 => new 角2_牛3D(), 
    			_ => new 角2_牛4D(), 
    		};
    		eleD.頭頂左接続(eleD2);
    		eleD.頭頂右接続(eleD2.Get逆());
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		ChestD2.肩左接続(ShoulderD2);
    		ChestD2.肩右接続(ShoulderD2.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		WaistD2.腿左接続(腿_人D2);
    		WaistD2.腿右接続(腿_人D2.Get逆());
    		WaistD2.尾接続(new 尾_牛D());
    		WaistD2.EnumEleD().SetValuesD("獣性", true);
    		WaistD2.EnumEleD().SetValuesD<頬肌D>("髭", false);
    		WaistD2.EnumEleD().SetValuesD<手_人D>("肉球", false);
    		WaistD2.EnumEleD().SetValuesD("獣毛2", false);
    		WaistD2.EnumEleD().SetValuesD<LowerArm_人D>("配色指定", 配色指定.B0);
    		WaistD2.EnumEleD().SetValuesD<Leg_人D>("配色指定", 配色指定.B0);
    		WaistD2.EnumEleD().SetValuesD<足_人D>("配色指定", 配色指定.B0);
    		WaistD2.EnumEleD().SetValuesD("バスト", 1.0);
    		WaistD2.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		WaistD2.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		WaistD2.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		WaistD2.SetLowerHair();
    		WaistD2.AdjustScale(頭D2);
    		return new CharacterData(WaistD2, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getリリン()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳人();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(Rng.XS.NextBool()));
    	}

    	public static CharacterData Getエルフ()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳長();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", 1.0);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: true));
    	}

    	public static CharacterData Getドワーフ()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳尖();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		obj.EnumEleD().SetValuesD("肥大", 1.0);
    		obj.EnumEleD().SetValuesD("身長", 0.0);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + Rng.XS.NextDouble(0.8));
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: true));
    	}

    	public static CharacterData GetViola()
    	{
    		WaistD waist_description = Uni.Waist();
    		TorsoD body_description = waist_description.SetTorso();
    		ChestD chest_description = body_description.SetChestR();
    		NeckD neck_description = chest_description.SetNeck();
    		HeadD head_description = Uni.頭();
    		neck_description.頭接続(head_description);
    		head_description.目高 = 0.85;
    		基髪D hair_description = (基髪D)head_description.基髪_接続[0];
    		BackHair0_カルD backhair_description = new BackHair0_カルD
    		{
    			髪長0 = 1.0,
    			髪長1 = 1.0,
    			毛量 = 1.0,
    			広がり = 1.0
    		};
    		hair_description.後髪接続(backhair_description);
    		SideHair_カルD sidehair_description = new SideHair_カルD
    		{
    			髪長1 = 1.0,
    			髪長2 = 1.0,
    			毛量 = 1.0,
    			広がり = 1.0
    		};
    		hair_description.横髪左接続(sidehair_description);
    		hair_description.横髪右接続(sidehair_description.Get逆());
    		hair_description.前髪接続(new 前髪_目隠れ2D
    		{
    			髪長 = 1.0,
    			髪ハネ左_表示 = false,
    			髪ハネ右_表示 = false,
    			編み左表示 = false,
    			編み右表示 = false
    		});
    		双目D eyes_description = Uni.魔中目(右: false);
    		瞼_中D eyelids_discription = (瞼_中D)eyes_description.瞼_接続[0];
    		eyelids_discription.サイズ = 0.5;
    		eyelids_discription.サイズX = 0.8;
    		eyelids_discription.サイズY = 0.5;
    		eyelids_discription.外線 = 0.5;
    		eyelids_discription.睫毛_睫毛3_長さ = 0.5;
    		eyelids_discription.睫毛_睫毛4_長さ = 0.5;
    		eyelids_discription.睫毛_睫毛1_長さ = 0.5;
    		eyelids_discription.睫毛_睫毛2_長さ = 0.5;
    		eyelids_discription.傾き = 0.8;
    		head_description.目左接続(eyes_description);
    		head_description.目右接続(eyes_description.Get逆());
    		眉D eyebrow_description = new 眉D
    		{
    			サイズY = 0.4
    		};
    		head_description.眉左接続(eyebrow_description);
    		head_description.眉右接続(eyebrow_description.Get逆());
    		head_description.Set鼻人();
    		head_description.Set口人();
    		head_description.Set舌短();
    		head_description.Set耳尖();


    		手_人D hand_description = new 手_人D();
    		LowerArm_人D lowerarm_description = new LowerArm_人D();
    		lowerarm_description.手接続(hand_description);
    		UpperArm_人D upperarm_description = new UpperArm_人D();
    		upperarm_description.LowerArm接続(lowerarm_description);

    		ShoulderD shoulder_description = new ShoulderD();
    		shoulder_description.UpperArm接続(upperarm_description);
    		chest_description.肩左接続(shoulder_description);
    		chest_description.肩右接続(shoulder_description.Get逆());

    		ElementData elementData = new 角2_牛4D();
    		hair_description.頭頂左接続(elementData);
    		hair_description.頭頂右接続(elementData.Get逆());

    		植D 植D2 = new 植D();
    		花_薔D 花_薔D2 = new 花_薔D();
    		植D2.花接続(花_薔D2);
    		花_薔D2.SetValuesD("表示", false);
    		花_薔D2.萼_萼_表示 = true;
    		花_薔D2.表示 = true;
		
    		bool flag = (植D2.披針葉4_葉脈_表示 = (植D2.披針葉4_葉_表示 = (植D2.披針葉3_葉脈_表示 = (植D2.披針葉3_葉_表示 = (植D2.披針葉2_葉脈_表示 = (植D2.披針葉2_葉_表示 = (植D2.披針葉1_葉脈_表示 = (植D2.披針葉1_葉_表示 = true))))))));
    		植D2.心臓葉1_葉_表示 = !flag;
    		植D2.心臓葉1_葉脈_表示 = !flag;
    		植D2.心臓葉2_葉_表示 = !flag;
    		植D2.心臓葉2_葉脈_表示 = !flag;
    		植D2.心臓葉3_葉_表示 = !flag;
    		植D2.心臓葉3_葉脈_表示 = !flag;
    		植D2.心臓葉4_葉_表示 = !flag;
    		植D2.心臓葉4_葉脈_表示 = !flag;

    		hair_description.頭頂左接続(植D2);
    		hair_description.頭頂右接続(植D2.Get逆());
    		手_蝙D e3 = new 手_蝙D
    		{
    			シャープ = 1.0
    		};


    		LowerArm_蝙D LowerArm_蝙D2 = new LowerArm_蝙D();
    		LowerArm_蝙D2.手接続(e3);
    		UpperArm_蝙D UpperArm_蝙D2 = new UpperArm_蝙D();
    		UpperArm_蝙D2.LowerArm接続(LowerArm_蝙D2);

    		chest_description.翼上左接続(UpperArm_蝙D2);
    		chest_description.翼上右接続(UpperArm_蝙D2.Get逆());
    		触手_蔦D 触手_蔦D2 = new 触手_蔦D
    		{
    			先端表示 = true
    		};

    		触手_蔦D2.SetValuesD("棘", true);
    		ElementData eleD2 = new 葉_披D();
    		eleD2.尺度B *= 1.25;
    		触手_蔦D2.節3接続(eleD2 = eleD2.Copy());
    		eleD2.尺度B *= 葉倍率;
    		触手_蔦D2.節5接続(eleD2 = eleD2.Copy());
    		eleD2.尺度B *= 葉倍率;
    		触手_蔦D2.節7接続(eleD2 = eleD2.Copy());
    		eleD2.尺度B *= 葉倍率;
    		触手_蔦D2.節9接続(eleD2 = eleD2.Copy());
    		eleD2.尺度B *= 葉倍率;
    		触手_蔦D2.節11接続(eleD2 = eleD2.Copy());
    		eleD2.尺度B *= 葉倍率;
    		触手_蔦D2.節13接続(eleD2 = eleD2.Copy());
    		eleD2.尺度B *= 葉倍率;
    		触手_蔦D2.節15接続(eleD2 = eleD2.Copy());
    		eleD2.尺度B *= 葉倍率;
    		触手_蔦D2.節17接続(eleD2 = eleD2.Copy());
    		eleD2.尺度B *= 葉倍率;
    		触手_蔦D2.節19接続(eleD2 = eleD2.Copy());
    		eleD2.尺度B *= 葉倍率;
    		ElementData eleD3 = 触手_蔦D2.Copy();

    		body_description.翼左接続(触手_蔦D2);
    		body_description.翼右接続(触手_蔦D2.Get逆());
    		waist_description.翼左接続(eleD3);
    		waist_description.翼右接続(eleD3.Get逆());
    		足_人D foot_description = new 足_人D();
    		Leg_人D legs_description = new Leg_人D();
    		legs_description.足接続(foot_description);
    		腿_人D thigh_description = new 腿_人D();
    		thigh_description.Leg接続(legs_description);

    		waist_description.腿左接続(thigh_description);
    		waist_description.腿右接続(thigh_description.Get逆());
    		waist_description.EnumEleD().SetValuesD("陰毛", true);
    		waist_description.EnumEleD().SetValuesD("植", true);
    		waist_description.EnumEleD().SetValuesD("淫", true);
    		waist_description.EnumEleD().SetValuesD<胸肌D>("植タトゥ", false);
    		waist_description.EnumEleD().SetValuesD<UpperArm_人D>("植タトゥ", false);
    		waist_description.EnumEleD().SetValuesD<LowerArm_人D>("淫", false);
    		waist_description.EnumEleD().SetValuesD<WaistSkinD>("ハート", false);
    		waist_description.EnumEleD().SetValuesD<頬肌D>("ハート", false);
    		waist_description.EnumEleD().SetValuesD<HeadD>("隈取", true);
    		waist_description.EnumEleD().SetValuesD<腿_人D>("悪", true);
    		waist_description.EnumEleD().SetValuesD<WaistD>("悪", true);
    		waist_description.EnumEleD().SetValuesD<腿_人D>("葉1", false);
    		waist_description.EnumEleD().SetValuesD("猫目", true);
    		waist_description.EnumEleD().SetValuesD("バスト", 0.85);
    		waist_description.EnumEleD().SetValuesD("肥大", 0.3);
    		waist_description.EnumEleD().SetValuesD("身長", 0.9);
    		waist_description.EnumEleD().SetValuesD("鋭爪", 0.6);

    		CharacterData chaD = new CharacterData(waist_description, new 体色(b0: false)
    		{
    			髪 = Color.FromArgb(255, 239, 241, 194).Add(0, 128, 0),
    			眉 = Color.FromArgb(255, 239, 241, 194).Add(0, 128, 0),
    			毛0 = Color.DarkGreen,
    			体1 = Color.Violet,
    			植0 = Color.DarkGreen.Add(0, 0, -50),
    			植1 = Color.DarkGreen,
    			人肌 = Color.FromArgb(255, 121, 200, 162),
    			目左 = Color.LightPink,
    			目右 = Color.LightPink,
    			白部 = Color.FromArgb(255, 238, 248, 238),
    			膜 = Color.Purple,
    			刺青 = Color.FromArgb(255, 134, 0, 62),
    			口紅 = Color.FromArgb(255, 134, 0, 62)
    		});

    		chaD.SetViola();
    		waist_description.AdjustScale(head_description);
    		return chaD;

    	}

    	public static CharacterData Getヒューマン()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set双目R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳人();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		obj.EnumEleD().SetValuesD("肥大", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("身長", Rng.XS.NextDouble());
    		obj.EnumEleD().SetValuesD("鋭爪", 0.0);
    		obj.SetLowerHair();
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: true));
    	}

    	public static CharacterData Getプレーヤー()
    	{
    		WaistD obj = Uni.Waist();
    		ChestD obj2 = obj.SetTorso().SetChestR();
    		HeadD 頭D2 = obj2.SetNeck().Set頭R();
    		頭D2.EnumEleD().GetEleD<基髪D>();
    		頭D2.Set目弱R();
    		頭D2.Set鼻人();
    		頭D2.Set口人();
    		頭D2.Set舌短();
    		頭D2.Set耳人();
    		手_人D e = new 手_人D();
    		LowerArm_人D LowerArm_人D2 = new LowerArm_人D();
    		LowerArm_人D2.手接続(e);
    		UpperArm_人D UpperArm_人D2 = new UpperArm_人D();
    		UpperArm_人D2.LowerArm接続(LowerArm_人D2);
    		ShoulderD ShoulderD2 = new ShoulderD();
    		ShoulderD2.UpperArm接続(UpperArm_人D2);
    		obj2.肩左接続(ShoulderD2);
    		obj2.肩右接続(ShoulderD2.Get逆());
    		足_人D e2 = new 足_人D();
    		Leg_人D Leg_人D2 = new Leg_人D();
    		Leg_人D2.足接続(e2);
    		腿_人D 腿_人D2 = new 腿_人D();
    		腿_人D2.Leg接続(Leg_人D2);
    		obj.腿左接続(腿_人D2);
    		obj.腿右接続(腿_人D2.Get逆());
    		obj.EnumEleD().SetValuesD("肥大", GlobalState.GameData.体重);
    		obj.EnumEleD().SetValuesD("身長", GlobalState.GameData.身長);
    		obj.EnumEleD().SetValuesD("鋭爪", 0.0);
    		obj.肌_接続.GetEleD<WaistSkinD>().陰毛_表示 = true;
    		obj.AdjustScale(頭D2);
    		return new CharacterData(obj, new 体色(b0: true)
    		{
    			目左 = GlobalState.GameData.色.瞳色,
    			目右 = GlobalState.GameData.色.瞳色,
    			縦目 = GlobalState.GameData.色.瞳色,
    			頬目左 = GlobalState.GameData.色.瞳色,
    			頬目右 = GlobalState.GameData.色.瞳色,
    			髪 = GlobalState.GameData.色.髪色,
    			眉 = GlobalState.GameData.色.髪色,
    			毛0 = GlobalState.GameData.色.髪色,
    			睫 = GlobalState.GameData.色.髪色,
    			人肌 = GlobalState.GameData.色.肌色,
    			爪 = Color.PapayaWhip
    		});
    	}
    }
}
