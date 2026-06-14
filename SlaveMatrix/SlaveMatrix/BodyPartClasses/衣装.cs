using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public static class 衣装
    {
    	public static bool Is下着ボトム条件(this CharacterData c)
    	{
    		if (!c.body_tree.半身_接続.IsEleD<長物_魚D>() && !c.body_tree.半身_接続.IsEleD<長物_鯨D>() && !c.body_tree.半身_接続.IsEleD<長物_蛇D>() && !c.body_tree.半身_接続.IsEleD<長物_蟲D>() && !c.body_tree.半身_接続.IsEleD<四足胸D>() && !c.body_tree.半身_接続.IsEleD<多足_蛸D>() && !c.body_tree.半身_接続.IsEleD<多足_蜘D>())
    		{
    			return !c.body_tree.半身_接続.IsEleD<多足_蠍D>();
    		}
    		return false;
    	}

    	public static bool Is上着ボトム条件(this CharacterData c)
    	{
    		return true;
    	}

    	public static bool Is紐付き条件(this CharacterData c)
    	{
    		if (!c.body_tree.半身_接続.IsEleD<単足_植D>())
    		{
    			return Rng.XS.NextBool();
    		}
    		return true;
    	}

    	public static bool Is前掛け条件(this CharacterData c)
    	{
    		if (!c.body_tree.半身_接続.IsEleD<四足胸D>() && !c.body_tree.腿左_接続.IsEleD<獣腿D>())
    		{
    			腿_人D eleD;
    			if (!c.body_tree.半身_接続.IsEleD<長物_魚D>() && !c.body_tree.半身_接続.IsEleD<長物_鯨D>() && !c.body_tree.半身_接続.IsEleD<長物_蛇D>() && !c.body_tree.半身_接続.IsEleD<長物_蟲D>() && !c.body_tree.半身_接続.IsEleD<多足_蛸D>() && !c.body_tree.半身_接続.IsEleD<多足_蜘D>() && !c.body_tree.半身_接続.IsEleD<単足_粘D>() && !c.body_tree.腿左_接続.IsEleD<尾_魚D>() && !c.body_tree.腿左_接続.IsEleD<触手_犬D>() && ((eleD = c.body_tree.腿左_接続.GetEleD<腿_人D>()) == null || (!eleD.植性_葉1_表示 && !eleD.植性_葉2_表示 && !eleD.植性_葉3_表示)))
    			{
    				return Rng.XS.NextBool();
    			}
    			return true;
    		}
    		return false;
    	}

    	public static bool Isブーツ条件(this CharacterData c)
    	{
    		return c.body_tree.EnumEleD().IsEleD<Leg_人D>();
    	}

    	public static IEnumerable<object> Get髪留め(CharacterData c)
    	{
    		髪留2情報 @default = 髪留2情報.GetDefault();
    		髪留2情報 横髪 = 髪留2情報.GetDefault();
    		switch (Rng.XS.Next(3))
    		{
    		case 0:
    			@default.髪留左.色.SetRandom();
    			@default.髪留右.色.髪留1 = @default.髪留左.色.髪留1;
    			@default.髪留右.色.髪留2 = @default.髪留左.色.髪留2;
    			@default.髪留右.色.SetColor2();
    			横髪.髪留左.色.髪留1 = @default.髪留左.色.髪留1;
    			横髪.髪留左.色.髪留2 = @default.髪留左.色.髪留2;
    			横髪.髪留左.色.SetColor2();
    			横髪.髪留右.色.髪留1 = @default.髪留左.色.髪留1;
    			横髪.髪留右.色.髪留2 = @default.髪留左.色.髪留2;
    			横髪.髪留右.色.SetColor2();
    			break;
    		case 1:
    			@default.髪留左.色.SetRandom();
    			@default.髪留右.色.髪留1 = @default.髪留左.色.髪留1;
    			@default.髪留右.色.髪留2 = @default.髪留左.色.髪留2;
    			@default.髪留右.色.SetColor2();
    			横髪.髪留左.色.SetRandom();
    			横髪.髪留右.色.髪留1 = @default.髪留左.色.髪留1;
    			横髪.髪留右.色.髪留2 = @default.髪留左.色.髪留2;
    			横髪.髪留右.色.SetColor2();
    			break;
    		case 2:
    			@default.髪留左.色.SetRandom();
    			@default.髪留右.色.SetRandom();
    			横髪.髪留左.色.SetRandom();
    			横髪.髪留右.色.SetRandom();
    			break;
    		}
    		yield return @default;
    		yield return 横髪;
    	}

    	public static IEnumerable<object> Getビキニ(CharacterData c, bool t)
    	{
    		ColorHelper.GetRandomClothesColor(out var c0);
    		ColorHelper.GetRandomClothesColor(out var c1);
    		ColorHelper.GetRandomClothesColor(out var c2);
    		bool e = Rng.XS.NextBool();
    		if (Rng.XS.NextBool())
    		{
    			if (t)
    			{
    				下着T_ビキニ情報 @default = 下着T_ビキニ情報.GetDefault();
    				@default.縁 = e;
    				@default.色.生地 = c0;
    				@default.色.縁 = c1;
    				@default.色.紐 = c2;
    				@default.色.SetColor2();
    				yield return @default;
    			}
    			if (c.Is下着ボトム条件())
    			{
    				下着B_ノーマル情報 下着B_ノーマル情報2 = ((!c.Is紐付き条件()) ? 下着B_ノーマル情報.Getビキニ() : 下着B_ノーマル情報.Getビキニ紐付き());
    				下着B_ノーマル情報2.縁 = e;
    				下着B_ノーマル情報2.色.生地 = c0;
    				下着B_ノーマル情報2.色.縁 = c1;
    				下着B_ノーマル情報2.色.紐 = c2;
    				下着B_ノーマル情報2.色.SetColor2();
    				yield return 下着B_ノーマル情報2;
    			}
    			else if (c.Is上着ボトム条件())
    			{
    				if (c.Is前掛け条件())
    				{
    					上着B_前掛け情報 default2 = 上着B_前掛け情報.GetDefault();
    					default2.色.生地 = c0;
    					default2.色.縁 = c1;
    					default2.色.紐 = c2;
    					default2.色.SetColor2();
    					yield return default2;
    				}
    				else
    				{
    					上着B_クロス情報 default3 = 上着B_クロス情報.GetDefault();
    					default3.中 = false;
    					default3.色.生地1 = c0;
    					default3.色.生地2 = c1;
    					default3.色.SetColor2();
    					yield return default3;
    				}
    			}
    			yield break;
    		}
    		if (t)
    		{
    			下着T_マイクロ情報 default4 = 下着T_マイクロ情報.GetDefault();
    			default4.縁 = e;
    			default4.色.生地 = c0;
    			default4.色.縁 = c1;
    			default4.色.紐 = c2;
    			default4.色.SetColor2();
    			yield return default4;
    		}
    		if (c.Is下着ボトム条件())
    		{
    			下着B_マイクロ情報 下着B_マイクロ情報2 = ((!c.Is紐付き条件()) ? 下着B_マイクロ情報.Getマイクロ() : 下着B_マイクロ情報.Getマイクロ紐付き());
    			下着B_マイクロ情報2.縁 = e;
    			下着B_マイクロ情報2.色.生地 = c0;
    			下着B_マイクロ情報2.色.縁 = c1;
    			下着B_マイクロ情報2.色.紐 = c2;
    			下着B_マイクロ情報2.色.SetColor2();
    			yield return 下着B_マイクロ情報2;
    		}
    		else if (c.Is上着ボトム条件())
    		{
    			if (c.Is前掛け条件())
    			{
    				上着B_前掛け情報 default5 = 上着B_前掛け情報.GetDefault();
    				default5.色.生地 = c0;
    				default5.色.縁 = c1;
    				default5.色.紐 = c2;
    				default5.色.SetColor2();
    				yield return default5;
    			}
    			else
    			{
    				上着B_クロス情報 default6 = 上着B_クロス情報.GetDefault();
    				default6.中 = false;
    				default6.色.生地1 = c0;
    				default6.色.生地2 = c1;
    				default6.色.SetColor2();
    				yield return default6;
    			}
    		}
    	}

    	public static IEnumerable<object> Getランジェリー(CharacterData c, bool t, bool a)
    	{
    		ColorHelper.GetRandomClothesColor(a ? Rng.XS.Next(32, 256) : 255, out var c0);
    		ColorHelper.GetRandomClothesColor(a ? Rng.XS.Next(32, 256) : 255, out var c1);
    		ColorHelper.GetRandomClothesColor(a ? Rng.XS.Next(32, 256) : 255, out var c2);
    		ColorHelper.GetRandomClothesColor(a ? Rng.XS.Next(32, 256) : 255, out var c3);
    		ColorHelper.GetRandomClothesColor(a ? Rng.XS.Next(32, 256) : 255, out var c4);
    		ColorHelper.GetRandomClothesColor(a ? Rng.XS.Next(32, 256) : 255, out var c5);
    		if (t)
    		{
    			下着T_ブラ情報 @default = 下着T_ブラ情報.GetDefault();
    			@default.色.生地1 = c0;
    			@default.色.生地2 = c1;
    			@default.色.縁 = c2;
    			@default.色.紐 = c3;
    			@default.色.柄 = c4;
    			@default.色.リボン = c5;
    			@default.色.SetColor2();
    			yield return @default;
    		}
    		if (c.Is下着ボトム条件())
    		{
    			下着B_ノーマル情報 下着B_ノーマル情報2 = ((!c.Is紐付き条件()) ? 下着B_ノーマル情報.Getランジェリー() : 下着B_ノーマル情報.Getランジェリー紐付き());
    			下着B_ノーマル情報2.色.生地 = c0;
    			下着B_ノーマル情報2.色.縁 = c2;
    			下着B_ノーマル情報2.色.紐 = c3;
    			下着B_ノーマル情報2.色.柄 = c4;
    			下着B_ノーマル情報2.色.リボン = c5;
    			下着B_ノーマル情報2.色.SetColor2();
    			yield return 下着B_ノーマル情報2;
    		}
    		else if (c.Is上着ボトム条件())
    		{
    			if (c.Is前掛け条件())
    			{
    				上着B_前掛け情報 default2 = 上着B_前掛け情報.GetDefault();
    				default2.色.生地 = c0;
    				default2.色.縁 = c1;
    				default2.色.紐 = c2;
    				default2.色.SetColor2();
    				yield return default2;
    			}
    			else
    			{
    				上着B_クロス情報 default3 = 上着B_クロス情報.GetDefault();
    				default3.中 = false;
    				default3.色.生地1 = c0;
    				default3.色.生地2 = c1;
    				default3.色.SetColor2();
    				yield return default3;
    			}
    		}
    	}

    	public static IEnumerable<object> Getピアス(CharacterData c)
    	{
    		ピアス情報 ピアス中 = ピアス情報.GetDefault();
    		ピアス中.色.ピアス = (Rng.XS.NextBool() ? Color.Gold : Color.Silver);
    		ピアス中.色.SetColor2();
    		yield return ピアス中;
    		ピアス情報 @default = ピアス情報.GetDefault();
    		@default.色.ピアス = ピアス中.色.ピアス;
    		@default.色.SetColor2();
    		yield return @default;
    		ピアス情報 default2 = ピアス情報.GetDefault();
    		default2.色.ピアス = ピアス中.色.ピアス;
    		default2.色.SetColor2();
    		yield return default2;
    	}

    	public static IEnumerable<object> Getヴィオラ服0(CharacterData c)
    	{
    		ドレス首情報 ドレス首 = ドレス首情報.GetDefault();
    		ドレス首.色.SetDefault();
    		yield return ドレス首;
    		ドレス情報 @default = ドレス情報.GetDefault();
    		@default.色.SetDefault();
    		yield return @default;
    		if (c.Is下着ボトム条件())
    		{
    			下着B_マイクロ情報 下着B_マイクロ情報2 = 下着B_マイクロ情報.Getヴィオラ();
    			下着B_マイクロ情報2.色.Setヴィオラ();
    			yield return 下着B_マイクロ情報2;
    		}
    		else if (c.Is上着ボトム条件())
    		{
    			if (c.Is前掛け条件())
    			{
    				上着B_前掛け情報 default2 = 上着B_前掛け情報.GetDefault();
    				default2.色.生地 = ドレス首.色.生地;
    				default2.色.縁 = ドレス首.色.縁;
    				default2.色.紐 = ColorHelper.Black;
    				default2.色.SetColor2();
    				yield return default2;
    			}
    			else
    			{
    				上着B_クロス情報 default3 = 上着B_クロス情報.GetDefault();
    				default3.中 = false;
    				default3.色.生地1 = ドレス首.色.生地;
    				default3.色.生地2 = ColorHelper.Black;
    				default3.色.SetColor2();
    				yield return default3;
    			}
    		}
    		if (c.Isブーツ条件())
    		{
    			ブーツ情報 default4 = ブーツ情報.GetDefault();
    			default4.色.SetDefault();
    			yield return default4;
    		}
    	}

    	public static IEnumerable<object> Getヴィオラ服1(CharacterData c)
    	{
    		ColorHelper.GetRandomClothesColor(out var c0);
    		ColorHelper.GetRandomClothesColor(out var c1);
    		ColorHelper.GetRandomClothesColor(out var c2);
    		ColorHelper.GetRandomClothesColor(out var c3);
    		ColorHelper.GetRandomClothesColor(out var c4);
    		ドレス首情報 @default = ドレス首情報.GetDefault();
    		@default.色.生地 = c0;
    		@default.色.縁 = c2;
    		@default.色.SetColor2();
    		yield return @default;
    		ドレス情報 default2 = ドレス情報.GetDefault();
    		default2.色.生地 = c0;
    		default2.色.柄 = c2;
    		default2.色.縁 = c2;
    		default2.色.紐 = c3;
    		default2.色.SetColor2();
    		yield return default2;
    		if (c.Is下着ボトム条件())
    		{
    			下着B_マイクロ情報 下着B_マイクロ情報2 = 下着B_マイクロ情報.Getヴィオラ();
    			下着B_マイクロ情報2.色.生地 = c0;
    			下着B_マイクロ情報2.色.縁 = c2;
    			下着B_マイクロ情報2.色.紐 = c3;
    			下着B_マイクロ情報2.色.SetColor2();
    			yield return 下着B_マイクロ情報2;
    		}
    		else if (c.Is上着ボトム条件())
    		{
    			if (c.Is前掛け条件())
    			{
    				上着B_前掛け情報 default3 = 上着B_前掛け情報.GetDefault();
    				default3.色.生地 = c0;
    				default3.色.縁 = c2;
    				default3.色.紐 = c3;
    				default3.色.SetColor2();
    				yield return default3;
    			}
    			else
    			{
    				上着B_クロス情報 default4 = 上着B_クロス情報.GetDefault();
    				default4.中 = false;
    				default4.色.生地1 = c0;
    				default4.色.生地2 = c3;
    				default4.色.SetColor2();
    				yield return default4;
    			}
    		}
    		if (c.Isブーツ条件())
    		{
    			ブーツ情報 default5 = ブーツ情報.GetDefault();
    			default5.色.生地1 = c0;
    			default5.色.生地2 = c1;
    			default5.色.縁 = c2;
    			default5.色.柄 = c2;
    			default5.色.紐 = c3;
    			default5.色.金具 = c4;
    			default5.色.穴 = c3;
    			default5.色.靴底 = c3;
    			default5.色.踵 = c3;
    			default5.色.SetColor2();
    			yield return default5;
    		}
    	}

    	public static IEnumerable<object> Get奴隷服(CharacterData c, bool b, bool r, bool a)
    	{
    		Color c0 = ColorHelper.Empty;
    		Color c1 = ColorHelper.Empty;
    		Color c2 = ColorHelper.Empty;
    		if (r)
    		{
    			ColorHelper.GetRandomClothesColor(a ? Rng.XS.Next(32, 256) : 255, out c0);
    			ColorHelper.GetRandomClothesColor(a ? Rng.XS.Next(32, 256) : 255, out c1);
    			ColorHelper.GetRandomClothesColor(a ? Rng.XS.Next(32, 256) : 255, out c2);
    		}
    		if (b && c.Is下着ボトム条件())
    		{
    			if (r && Rng.XS.NextBool())
    			{
    				ColorHelper.GetRandomClothesColor(a ? Rng.XS.Next(32, 256) : 255, out var ret);
    				ColorHelper.GetRandomClothesColor(a ? Rng.XS.Next(32, 256) : 255, out var ret2);
    				ColorHelper.GetRandomClothesColor(a ? Rng.XS.Next(32, 256) : 255, out var ret3);
    				下着B_ノーマル情報 下着B_ノーマル情報2 = ((!c.Is紐付き条件()) ? 下着B_ノーマル情報.Getランジェリー() : 下着B_ノーマル情報.Getランジェリー紐付き());
    				下着B_ノーマル情報2.色.生地 = c0;
    				下着B_ノーマル情報2.色.縁 = c2;
    				下着B_ノーマル情報2.色.紐 = ret;
    				下着B_ノーマル情報2.色.柄 = ret2;
    				下着B_ノーマル情報2.色.リボン = ret3;
    				下着B_ノーマル情報2.色.SetColor2();
    				yield return 下着B_ノーマル情報2;
    			}
    			else
    			{
    				下着B_ノーマル情報 下着B_ノーマル情報3 = 下着B_ノーマル情報.Getビキニ();
    				下着B_ノーマル情報3.縁 = false;
    				if (r)
    				{
    					下着B_ノーマル情報3.色.SetRandom();
    				}
    				else
    				{
    					下着B_ノーマル情報3.色.生地 = Color.OldLace;
    					下着B_ノーマル情報3.色.リボン = Color.OldLace;
    					下着B_ノーマル情報3.色.柄 = Color.OldLace;
    					下着B_ノーマル情報3.色.縁 = Color.OldLace;
    					下着B_ノーマル情報3.色.紐 = Color.OldLace;
    					下着B_ノーマル情報3.色.SetColor2();
    				}
    				yield return 下着B_ノーマル情報3;
    			}
    		}
    		if (Rng.XS.NextBool())
    		{
    			下着T_クロス情報 @default = 下着T_クロス情報.GetDefault();
    			if (r)
    			{
    				@default.色.生地 = c0;
    				@default.色.縁 = c1;
    				@default.色.SetColor2();
    			}
    			yield return @default;
    		}
    		else
    		{
    			下着T_チューブ情報 default2 = 下着T_チューブ情報.GetDefault();
    			default2.縁 = Rng.XS.NextBool();
    			if (r)
    			{
    				default2.色.生地 = c0;
    				default2.色.縁 = c1;
    				default2.色.SetColor2();
    			}
    			yield return default2;
    		}
    		if (!c.Is上着ボトム条件())
    		{
    			yield break;
    		}
    		if (c.Is前掛け条件())
    		{
    			上着B_前掛け情報 default3 = 上着B_前掛け情報.GetDefault();
    			if (r)
    			{
    				default3.色.生地 = c0;
    				default3.色.縁 = c1;
    				default3.色.紐 = c2;
    				default3.色.SetColor2();
    			}
    			yield return default3;
    		}
    		else
    		{
    			上着B_クロス情報 default4 = 上着B_クロス情報.GetDefault();
    			default4.中 = false;
    			if (r)
    			{
    				default4.色.生地1 = c0;
    				default4.色.生地2 = c1;
    				default4.色.SetColor2();
    			}
    			yield return default4;
    		}
    	}

    	public static Unit Set衣装(this Unit u)
    	{
    		if (u.Race == GameText.サキュバス)
    		{
    			u.着衣番号 = 4;
    			u.着衣 = Get髪留め(u.ChaD).Concat(Getビキニ(u.ChaD, t: true)).ToArray();
    		}
    		else
    		{
    			u.着衣番号 = 0;
    			u.着衣 = Get髪留め(u.ChaD).Concat(Get奴隷服(u.ChaD, b: true, r: false, a: false)).ToArray();
    		}
    		return u;
    	}

    	public static Unit Change衣装(this Unit u)
    	{
    		int num = 0;
    		if (GlobalState.GameData.ヴィオラ服)
    		{
    			do
    			{
    				num = Rng.XS.Next(10);
    			}
    			while (u.着衣番号 == num);
    		}
    		else
    		{
    			do
    			{
    				num = Rng.XS.Next(8);
    			}
    			while (u.着衣番号 == num);
    		}
    		u.着衣番号 = num;
    		switch (num)
    		{
    		case 0:
    			u.着衣 = Get髪留め(u.ChaD).Concat(Get奴隷服(u.ChaD, b: true, r: false, a: false)).ToArray();
    			break;
    		case 1:
    			u.着衣 = Get髪留め(u.ChaD).Concat(Get奴隷服(u.ChaD, b: true, r: false, a: true)).ToArray();
    			break;
    		case 2:
    			u.着衣 = Get髪留め(u.ChaD).Concat(Get奴隷服(u.ChaD, b: true, r: true, a: false)).ToArray();
    			break;
    		case 3:
    			u.着衣 = Get髪留め(u.ChaD).Concat(Get奴隷服(u.ChaD, b: true, r: true, a: true)).ToArray();
    			break;
    		case 4:
    			u.着衣 = Get髪留め(u.ChaD).Concat(Getビキニ(u.ChaD, t: true)).ToArray();
    			break;
    		case 5:
    			u.着衣 = Get髪留め(u.ChaD).Concat(Getランジェリー(u.ChaD, t: true, a: false)).ToArray();
    			break;
    		case 6:
    			u.着衣 = Get髪留め(u.ChaD).Concat(Getランジェリー(u.ChaD, t: true, a: true)).ToArray();
    			break;
    		case 7:
    			u.着衣 = Get髪留め(u.ChaD).Concat(Getピアス(u.ChaD)).ToArray();
    			break;
    		case 8:
    			u.着衣 = Get髪留め(u.ChaD).Concat(Getヴィオラ服0(u.ChaD)).ToArray();
    			break;
    		case 9:
    			u.着衣 = Get髪留め(u.ChaD).Concat(Getヴィオラ服1(u.ChaD)).ToArray();
    			break;
    		}
    		return u;
    	}

    	public static double 一般労働倍率(this Unit u)
    	{
    		return u.着衣番号 switch
    		{
    			0 => 1.0, 
    			1 => 0.8, 
    			2 => 1.0, 
    			3 => 0.8, 
    			4 => 0.8, 
    			5 => 0.7, 
    			6 => 0.6, 
    			7 => 0.5, 
    			8 => 1.5, 
    			9 => 1.5, 
    			_ => 1.0, 
    		};
    	}

    	public static double 娼婦労働倍率(this Unit u)
    	{
    		return u.着衣番号 switch
    		{
    			0 => 1.0, 
    			1 => 1.2, 
    			2 => 1.1, 
    			3 => 1.2, 
    			4 => 1.2, 
    			5 => 1.3, 
    			6 => 1.4, 
    			7 => 1.5, 
    			8 => 1.5, 
    			9 => 1.5, 
    			_ => 1.0, 
    		};
    	}
    }
}
