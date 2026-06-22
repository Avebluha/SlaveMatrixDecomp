using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class CharacterData
    {
    	public Unit Parent;

    	public WaistD body_tree;

    	public 体色 body_color;

    	public double Stamina = 1.0;

    	public double Sensitivity;

    	public double Excitement;

    	public double Wetness;

    	public double Tension = 1.0;

    	public double Shyness;

    	public double Pride;

    	public double Lust;

    	public double Affection;

    	public double Taming;

    	public double SkillL;

    	public Dictionary<ContactType, double> Sesnsitivities;

    	public double 現乳首;

    	public double 現乳房;

    	public double 現陰核;

    	public double 現性器;

    	public double 現肛門;

    	public double 現陰毛 = 1.0;

    	public double 最乳首;

    	public double 最乳房;

    	public double 最陰核;

    	public double 素乳首濃度;

    	public double 最乳首濃度;

    	public double 素性器濃度;

    	public double 最性器濃度;

    	public double 素肛門濃度;

    	public double 最肛門濃度;

    	public double 最陰毛濃度;

    	public double 固有値;

    	public double 魔力濃度;

    	public EmotionType Emotion;

    	public bool 撮影ピース経験;

    	public double 放尿経験値;

    	public bool 胸施術;

    	public bool 股施術;

    	public bool タトゥ;

    	public bool Is胸甲殻()
    	{
    		return body_tree.EnumEleD().GetEleD<乳房D>().虫性_甲殻_表示;
    	}

    	public bool Is股防御()
    	{
    		半身D eleD = body_tree.半身_接続.GetEleD<半身D>();
    		if (eleD is 長物_蛇D)
    		{
    			return ((長物_蛇D)eleD).ガード;
    		}
    		if (eleD is 多足_蠍D)
    		{
    			return true;
    		}
    		WaistSkinD eleD2 = body_tree.肌_接続.GetEleD<WaistSkinD>();
    		if (!eleD2.竜性_鱗1_表示 && !eleD2.竜性_鱗2_表示 && !eleD2.竜性_鱗3_表示)
    		{
    			return eleD2.竜性_鱗4_表示;
    		}
    		return true;
    	}

    	public bool Isタトゥ()
    	{
    		四足腰D eleD = body_tree.EnumEleD().GetEleD<四足腰D>();
    		if (eleD != null)
    		{
    			WaistSkinD eleD2 = eleD.EnumEleD().GetEleD<WaistSkinD>();
    			if (eleD2.淫タトゥ_タトゥ1右_表示 && eleD2.淫タトゥ_タトゥ1左_表示 && eleD2.淫タトゥ_タトゥ2右_表示 && eleD2.淫タトゥ_タトゥ2左_表示 && eleD2.淫タトゥ_ハート_タトゥ右1_表示 && eleD2.淫タトゥ_ハート_タトゥ右2_表示 && eleD2.淫タトゥ_ハート_タトゥ左1_表示)
    			{
    				return eleD2.淫タトゥ_ハート_タトゥ左2_表示;
    			}
    			return false;
    		}
    		WaistSkinD eleD3 = body_tree.EnumEleD().GetEleD<WaistSkinD>();
    		if (eleD3.淫タトゥ_タトゥ1右_表示 && eleD3.淫タトゥ_タトゥ1左_表示 && eleD3.淫タトゥ_タトゥ2右_表示 && eleD3.淫タトゥ_タトゥ2左_表示 && eleD3.淫タトゥ_ハート_タトゥ右1_表示 && eleD3.淫タトゥ_ハート_タトゥ右2_表示 && eleD3.淫タトゥ_ハート_タトゥ左1_表示)
    		{
    			return eleD3.淫タトゥ_ハート_タトゥ左2_表示;
    		}
    		return false;
    	}

    	public CharacterData(WaistD 構成, 体色 体色)
    	{
    		this.body_tree = 構成;
    		this.body_color = 体色;
    		Pride = Rng.XS.NextDouble();
    		Lust = Rng.XS.NextDouble(0.6);
    		Affection = Rng.XS.NextDouble(0.6);
    		Taming = Rng.XS.NextDouble(0.6);
    		SkillL = Rng.XS.NextDouble(0.6);
    		Sesnsitivities = new Dictionary<ContactType, double>
    		{
    			{
    				ContactType.Head,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Face,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Ear,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Mouth,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Hair,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Neck,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Shoulder,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Chest,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Milk,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Side,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Stomache,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Crotch,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Sex,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Vagina,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Nucleus,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Anal,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Thread,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Thigh,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Feet,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Hand,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Awareness,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Touch,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Tail,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Wing,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Fin,
    				Rng.XS.NextDouble(0.6)
    			},
    			{
    				ContactType.Other,
    				Rng.XS.NextDouble(0.6)
    			}
    		};
    		最乳首 = Rng.XS.NextDouble();
    		最乳房 = 構成.EnumEleD().GetEleD<乳房D>().バスト;
    		最陰核 = Rng.XS.NextDouble();
    		素乳首濃度 = 0.3 + Rng.XS.NextDouble(0.5);
    		最乳首濃度 = Rng.XS.NextDouble(0.19999999999999996);
    		素性器濃度 = 0.3 + Rng.XS.NextDouble(0.5);
    		最性器濃度 = Rng.XS.NextDouble(0.19999999999999996);
    		素肛門濃度 = 0.3 + Rng.XS.NextDouble(0.5);
    		最肛門濃度 = Rng.XS.NextDouble(0.19999999999999996);
    		最陰毛濃度 = Rng.XS.NextDouble();
    		固有値 = Rng.XS.NextDouble();
    		魔力濃度 = Rng.XS.NextDouble();
    		WaistSkinD eleD = 構成.EnumEleD().GetEleD<WaistSkinD>();
    		if (!eleD.陰毛_表示 && !eleD.獣性_獣毛_表示)
    		{
    			現陰毛 = 0.0;
    		}
    		Emotion = EmotionType.Denial;
    	}

    	public void SetViola()
    	{
    		Pride = 1.0;
    		Lust = 0.8;
    		Affection = 0.1;
    		Taming = 0.1;
    		SkillL = 0.8;
    		Sesnsitivities = new Dictionary<ContactType, double>
    		{
    			{
    				ContactType.Head,
    				0.01
    			},
    			{
    				ContactType.Face,
    				0.01
    			},
    			{
    				ContactType.Ear,
    				0.03
    			},
    			{
    				ContactType.Mouth,
    				0.01
    			},
    			{
    				ContactType.Hair,
    				0.01
    			},
    			{
    				ContactType.Neck,
    				0.02
    			},
    			{
    				ContactType.Shoulder,
    				0.01
    			},
    			{
    				ContactType.Chest,
    				0.03
    			},
    			{
    				ContactType.Milk,
    				0.04
    			},
    			{
    				ContactType.Side,
    				0.01
    			},
    			{
    				ContactType.Stomache,
    				0.01
    			},
    			{
    				ContactType.Crotch,
    				0.03
    			},
    			{
    				ContactType.Sex,
    				0.05
    			},
    			{
    				ContactType.Vagina,
    				0.04
    			},
    			{
    				ContactType.Nucleus,
    				0.1
    			},
    			{
    				ContactType.Anal,
    				0.01
    			},
    			{
    				ContactType.Thread,
    				0.0
    			},
    			{
    				ContactType.Thigh,
    				0.02
    			},
    			{
    				ContactType.Feet,
    				0.01
    			},
    			{
    				ContactType.Hand,
    				0.01
    			},
    			{
    				ContactType.Awareness,
    				0.0
    			},
    			{
    				ContactType.Touch,
    				0.01
    			},
    			{
    				ContactType.Tail,
    				0.0
    			},
    			{
    				ContactType.Wing,
    				0.02
    			},
    			{
    				ContactType.Fin,
    				0.0
    			},
    			{
    				ContactType.Other,
    				0.01
    			}
    		};
    		現陰毛 = 0.0;
    		最乳首 = 0.85;
    		最乳房 = 0.85;
    		最陰核 = 0.85;
    		素乳首濃度 = 0.5;
    		最乳首濃度 = 0.5;
    		素性器濃度 = 0.5;
    		最性器濃度 = 0.5;
    		素肛門濃度 = 0.5;
    		最肛門濃度 = 0.5;
    		最陰毛濃度 = 0.8;
    		固有値 = 0.99;
    		魔力濃度 = 1.0;
    	}

    	public void 娼婦調教(double max_skillL)
    	{
    		Lust = (Lust + 0.01 * Rng.XS.NextDouble()).Clamp(0.0, 1.0);
    		Taming = (Taming + 0.01 * Rng.XS.NextDouble()).Clamp(0.0, 1.0);
    		SkillL = (SkillL + 0.01 * Rng.XS.NextDouble()).Clamp(0.0, max_skillL);
    	}

    	public void 欲望補正()
    	{
    		Lust = (Lust + Rng.XS.NextDouble(Lust)).Clamp(0.0, 1.0);
    	}

    	public void 情愛補正()
    	{
    		Affection = (Affection + Rng.XS.NextDouble(Affection)).Clamp(0.0, 1.0);
    	}

    	public void 卑屈補正()
    	{
    		Taming = (Taming + Rng.XS.NextDouble(Taming)).Clamp(0.0, 1.0);
    	}

    	public void 技巧補正()
    	{
    		SkillL = (SkillL + Rng.XS.NextDouble(SkillL)).Clamp(0.0, 1.0);
    	}
    }
}
