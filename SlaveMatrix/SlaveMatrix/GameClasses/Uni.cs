using _2DGAMELIB;

namespace SlaveMatrix
{
    public static class Uni
    {
    	public static HeadD 頭()
    	{
    		HeadD obj = new HeadD();
    		obj.基髪接続(new 基髪D());
    		obj.目左接続(new 目傷D());
    		obj.目右接続(new 目傷D
    		{
    			右 = true
    		});
    		obj.目左接続(new 目尻影D());
    		obj.目右接続(new 目尻影D
    		{
    			右 = true
    		});
    		obj.鼻肌接続(new 鼻肌D());
    		obj.鼻肌接続(new 紅潮D());
    		obj.頬肌左接続(new 頬肌D());
    		obj.頬肌右接続(new 頬肌D
    		{
    			右 = true
    		});
    		obj.頬左接続(new 顔ハイライトD());
    		obj.頬右接続(new 顔ハイライトD
    		{
    			右 = true
    		});
    		obj.単眼目接続(new 目隠帯D());
    		obj.口接続(new 玉口枷D());
    		return obj;
    	}

    	public static ChestD Chest()
    	{
    		ChestD obj = new ChestD();
    		obj.肌接続(new 胸毛D());
    		obj.肌接続(new 胸肌D());
    		obj.肌接続(new 胸腹板D());
    		obj.肌接続(new 下着トップ_チューブD());
    		obj.肌接続(new 下着トップ_クロスD());
    		obj.肌接続(new 下着トップ_ビキニD());
    		obj.肌接続(new 下着トップ_マイクロD());
    		obj.肌接続(new 下着トップ_ブラD());
    		obj.肌接続(new 上着トップ_ドレスD());
    		乳房D 乳房D2 = 乳房();
    		obj.胸左接続(乳房D2);
    		obj.胸右接続(乳房D2.Get逆());
    		return obj;
    	}

    	public static TorsoD 胴()
    	{
    		TorsoD obj = new TorsoD();
    		obj.肌接続(new 胴腹板D());
    		obj.肌接続(new 胴肌D());
    		obj.肌接続(new 上着ミドル_ドレスD());
    		return obj;
    	}

    	public static WaistD Waist()
    	{
    		WaistD waist_description = new WaistD();
    		waist_description.膣基接続(new VaginaOrigin_人D());
    		waist_description.膣基接続(new InternalSemen_人D());
    		waist_description.膣基接続(new XRay_人D());
    		waist_description.膣基接続(性器());
    		waist_description.肛門接続(肛門());
    		waist_description.肌接続(PregnantBelly());
    		waist_description.肌接続(new WaistSkinD());
    		waist_description.肌接続(new 下着ボトム_ノーマルD());
    		waist_description.肌接続(new 下着ボトム_マイクロD());
    		JacketBottom_クロスD JacketBottom_クロスD2 = new JacketBottom_クロスD();
    		JacketBottom_クロスD2.JacketBottomRear接続(new JacketBottom_クロス後D());
    		waist_description.上着接続(JacketBottom_クロスD2);
    		waist_description.上着接続(new JacketBottom_前掛けD());
    		return waist_description;
    	}

    	public static 四足胸D 四足胸()
    	{
    		四足胸D obj = new 四足胸D();
    		obj.肌接続(new 胸毛D
    		{
    			尺度B = 1.4
    		});
    		obj.肌接続(new 胸肌D
    		{
    			尺度B = 1.3
    		});
    		return obj;
    	}

    	public static 四足胴D 四足胴()
    	{
    		四足胴D obj = new 四足胴D();
    		obj.肌接続(new 胴肌D
    		{
    			尺度B = 1.35
    		});
    		return obj;
    	}

    	public static 四足腰D 四足腰()
    	{
    		四足腰D obj = new 四足腰D();
    		obj.膣基接続(new VaginaOrigin_獣D());
    		obj.膣基接続(new InternalSemen_獣D());
    		obj.膣基接続(new XRay_獣D());
    		obj.膣基接続(四足性器());
    		obj.肛門接続(四足肛門());
    		obj.肌接続(new PregnantBelly_獣D());
    		obj.肌接続(new WaistSkinD
    		{
    			尺度B = 1.4,
    			虫性_腹板1_縦線_表示 = false,
    			虫性_腹板1_腹板_表示 = false,
    			虫性_腹板2_縦線_表示 = false,
    			虫性_腹板2_腹板_表示 = false
    		});
    		obj.竜性_中_鱗1_表示 = false;
    		obj.竜性_中_鱗2_表示 = false;
    		obj.竜性_中_鱗3_表示 = false;
    		obj.竜性_中_鱗4_表示 = false;
    		return obj;
    	}

    	public static 双目D 魔弱目(bool 右)
    	{
    		双目D obj = new 双目D();
    		obj.右 = 右;
    		obj.瞼接続(new 瞼_弱D
    		{
    			右 = 右
    		});
    		obj.瞼接続(new 涙D
    		{
    			右 = 右
    		});
    		return obj;
    	}

    	public static 双目D 魔中目(bool 右)
    	{
    		双目D obj = new 双目D();
    		obj.右 = 右;
    		obj.瞼接続(new 瞼_中D
    		{
    			右 = 右
    		});
    		obj.瞼接続(new 涙D
    		{
    			右 = 右
    		});
    		return obj;
    	}

    	public static 双目D 魔強目(bool 右)
    	{
    		双目D obj = new 双目D();
    		obj.右 = 右;
    		obj.瞼接続(new 瞼_強D
    		{
    			右 = 右
    		});
    		obj.瞼接続(new 涙D
    		{
    			右 = 右
    		});
    		return obj;
    	}

    	public static 双目D 獣性目(bool 右)
    	{
    		双目D obj = new 双目D();
    		obj.右 = 右;
    		obj.瞼接続(new 瞼_獣D
    		{
    			右 = 右
    		});
    		obj.瞼接続(new 涙D
    		{
    			右 = 右
    		});
    		return obj;
    	}

    	public static 双目D 宇宙目(bool 右)
    	{
    		双目D obj = new 双目D();
    		obj.右 = 右;
    		obj.瞼接続(new 瞼_宇D
    		{
    			右 = 右
    		});
    		obj.瞼接続(new 涙D
    		{
    			右 = 右
    		});
    		return obj;
    	}

    	public static 単目D 単眼目()
    	{
    		単目D obj = new 単目D();
    		obj.瞼接続(new 単瞼D());
    		obj.瞼接続(new 涙D
    		{
    			基準C = new Vector2D(0.01, 0.0)
    		});
    		obj.瞼接続(new 涙D
    		{
    			右 = true,
    			基準C = new Vector2D(-0.01, 0.0)
    		});
    		return obj;
    	}

    	public static 縦目D 縦目()
    	{
    		縦目D obj = new 縦目D();
    		obj.瞼接続(new 縦瞼D());
    		return obj;
    	}

    	public static 頬目D 頬目(bool 右)
    	{
    		頬目D obj = new 頬目D();
    		obj.右 = 右;
    		obj.瞼接続(new 頬瞼D
    		{
    			右 = 右
    		});
    		return obj;
    	}

    	public static 鼻_人D 人鼻D()
    	{
    		鼻_人D obj = new 鼻_人D();
    		obj.鼻水左接続(new 鼻水D());
    		obj.鼻水右接続(new 鼻水D
    		{
    			右 = true
    		});
    		return obj;
    	}

    	public static 鼻_獣D 獣鼻D()
    	{
    		鼻_獣D obj = new 鼻_獣D();
    		obj.鼻水左接続(new 鼻水D());
    		obj.鼻水右接続(new 鼻水D
    		{
    			右 = true
    		});
    		return obj;
    	}

    	public static ElementData[] 人口D()
    	{
    		return new ElementData[6]
    		{
    			new 口_通常D(),
    			new 涎_通常D(),
    			new 涎_通常D
    			{
    				右 = true
    			},
    			new 性器精液_人D(),
    			new 咳D(),
    			new 呼気D()
    		};
    	}

    	public static ElementData[] 裂口D()
    	{
    		return new ElementData[6]
    		{
    			new 口_裂けD(),
    			new 涎_裂けD(),
    			new 涎_裂けD
    			{
    				右 = true
    			},
    			new 性器精液_人D(),
    			new 咳D(),
    			new 呼気D()
    		};
    	}

    	public static 乳房D 乳房()
    	{
    		乳房D obj = new 乳房D();
    		obj.噴乳接続(new 噴乳D());
    		obj.噴乳接続(new ピアスD());
    		obj.噴乳接続(new キャップ2D());
    		obj.噴乳接続(new 下着乳首D());
    		return obj;
    	}

    	public static PregnantBelly_人D PregnantBelly()
    	{
    		PregnantBelly_人D obj = new PregnantBelly_人D();
    		obj.腹板接続(new PregnantBellyPlateD());
    		return obj;
    	}

    	public static 肛門_人D 肛門()
    	{
    		肛門_人D obj = new 肛門_人D();
    		obj.肛門精液接続(new 肛門精液_人D());
    		return obj;
    	}

    	public static 肛門_獣D 四足肛門()
    	{
    		肛門_獣D obj = new 肛門_獣D();
    		obj.肛門精液接続(new 肛門精液_獣D());
    		return obj;
    	}

    	public static 性器_人D 性器()
    	{
    		性器_人D obj = new 性器_人D();
    		obj.膣口接続(new 性器精液_人D());
    		obj.膣口接続(new 飛沫_人D());
    		obj.尿道接続(new 放尿_人D());
    		obj.尿道接続(new 潮吹_小_人D());
    		obj.尿道接続(new 潮吹_大_人D());
    		obj.陰核接続(new ピアスD());
    		obj.陰核接続(new キャップ1D());
    		obj.陰核接続(new 下着陰核D());
    		return obj;
    	}

    	public static 性器_獣D 四足性器()
    	{
    		性器_獣D obj = new 性器_獣D();
    		obj.膣口接続(new 性器精液_獣D());
    		obj.膣口接続(new 飛沫_獣D());
    		obj.尿道接続(new 放尿_獣D());
    		obj.尿道接続(new 潮吹_小_獣D());
    		obj.尿道接続(new 潮吹_大_獣D());
    		obj.陰核接続(new ピアスD());
    		obj.陰核接続(new キャップ1D());
    		return obj;
    	}
    }
}
