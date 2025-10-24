using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class Ele : IDisposable
    {
    	public Ele Par;

    	public ConnectionInfo ConnectionType;

    	public Difs 本体;

    	public static double 肥大mi1 = -5E-07;

    	public static double 肥大ma1 = 8E-05;

    	public static double 肥大d1 = 肥大ma1 - 肥大mi1;

    	public static double 肥大mi2 = 0.92;

    	public static double 肥大ma2 = 1.05;

    	public static double 肥大d2 = 肥大ma2 - 肥大mi2;

    	public static double 身長mi2 = 0.95;

    	public static double 身長ma2 = 1.05;

    	public static double 身長d2 = 身長ma2 - 身長mi2;

    	protected double 肥大_;

    	protected double 身長_;

    	protected bool Xasix = true;

    	protected bool 右_;

    	protected bool 反転X_;

    	protected bool 反転Y_;

    	public JointD 接続根;

    	public 配色指定 配色指定;

    	protected double サイズ_;

    	protected double サイズX_;

    	protected double サイズY_;

    	protected bool 欠損_;

    	protected bool 筋肉_;

    	protected bool 拘束_;

    	public Type ThisType;

    	public virtual Vector2D 基準B
    	{
    		get
    		{
    			return 本体.CurJoinRoot.BasePointBase;
    		}
    		set
    		{
    			foreach (Par item in 本体.EnumJoinRoot)
    			{
    				item.BasePointBase = value;
    			}
    			本体.JoinP();
    		}
    	}

    	public virtual Vector2D 基準C
    	{
    		get
    		{
    			return 本体.CurJoinRoot.BasePointCont;
    		}
    		set
    		{
    			foreach (Par item in 本体.EnumJoinRoot)
    			{
    				item.BasePointCont = value;
    			}
    			本体.JoinP();
    		}
    	}

    	public virtual Vector2D 位置 => 本体.CurJoinRoot.Position;

    	public virtual Vector2D 位置B
    	{
    		get
    		{
    			return 本体.CurJoinRoot.PositionBase;
    		}
    		set
    		{
    			foreach (Par item in 本体.EnumJoinRoot)
    			{
    				item.PositionBase = value;
    			}
    			本体.JoinP();
    		}
    	}

    	public virtual Vector2D 位置C
    	{
    		get
    		{
    			return 本体.CurJoinRoot.PositionCont;
    		}
    		set
    		{
    			foreach (Par item in 本体.EnumJoinRoot)
    			{
    				item.PositionCont = value;
    			}
    			本体.JoinP();
    		}
    	}

    	public virtual double AngleAll
    	{
    		set
    		{
    			foreach (Par item in 本体.EnumAllPar())
    			{
    				item.AngleBase = value;
    			}
    			本体.JoinPA();
    		}
    	}

    	public virtual double 角度B
    	{
    		get
    		{
    			return 本体.CurJoinRoot.AngleBase;
    		}
    		set
    		{
    			foreach (Par item in 本体.EnumJoinRoot)
    			{
    				item.AngleBase = value;
    			}
    			本体.JoinPA();
    		}
    	}

    	public virtual double 角度C
    	{
    		get
    		{
    			return 本体.CurJoinRoot.AngleCont;
    		}
    		set
    		{
    			foreach (Par item in 本体.EnumJoinRoot)
    			{
    				item.AngleCont = value;
    			}
    			本体.JoinPA();
    		}
    	}

    	public virtual double 尺度B
    	{
    		get
    		{
    			return 本体.CurJoinRoot.SizeBase;
    		}
    		set
    		{
    			foreach (Par item in 本体.EnumAllPar())
    			{
    				item.SizeBase *= value;
    			}
    			本体.JoinP();
    		}
    	}

    	public virtual double 尺度C
    	{
    		get
    		{
    			return 本体.CurJoinRoot.SizeCont;
    		}
    		set
    		{
    			foreach (Par item in 本体.EnumAllPar())
    			{
    				item.SizeCont = value;
    			}
    			本体.JoinP();
    		}
    	}

    	public virtual double 尺度XB
    	{
    		get
    		{
    			return 本体.CurJoinRoot.SizeXBase;
    		}
    		set
    		{
    			foreach (Par item in 本体.EnumAllPar())
    			{
    				item.SizeXBase *= value;
    			}
    			本体.JoinP();
    		}
    	}

    	public virtual double 尺度XC
    	{
    		get
    		{
    			return 本体.CurJoinRoot.SizeXCont;
    		}
    		set
    		{
    			foreach (Par item in 本体.EnumAllPar())
    			{
    				item.SizeXCont = value;
    			}
    			本体.JoinP();
    		}
    	}

    	public virtual double 尺度YB
    	{
    		get
    		{
    			return 本体.CurJoinRoot.SizeYBase;
    		}
    		set
    		{
    			foreach (Par item in 本体.EnumAllPar())
    			{
    				item.SizeYBase *= value;
    			}
    			本体.JoinP();
    		}
    	}

    	public virtual double 尺度YC
    	{
    		get
    		{
    			return 本体.CurJoinRoot.SizeYCont;
    		}
    		set
    		{
    			foreach (Par item in 本体.EnumAllPar())
    			{
    				item.SizeYCont = value;
    			}
    			本体.JoinP();
    		}
    	}

    	public virtual double 尺度 => 本体.CurJoinRoot.Size;

    	public virtual double 尺度Y => 本体.CurJoinRoot.SizeY;

    	public virtual double 尺度X => 本体.CurJoinRoot.SizeX;

    	public virtual double 肥大
    	{
    		get
    		{
    			return 肥大_;
    		}
    		set
    		{
    			肥大_ = value;
    			double rate = 肥大mi1 + 肥大d1 * 肥大_;
    			double num = 肥大mi2 + 肥大d2 * 肥大_;
    			double num2 = num + 0.05 * 肥大_.Inverse();
    			foreach (Par item in 本体.EnumAllPar())
    			{
    				if (item.Parent.Tag.Contains("眼") || item.Parent.Tag.Contains("コア") || item.Tag.Contains("傷") || item.Tag.Contains("ボタン"))
    				{
    					continue;
    				}
    				if (item.Parent.Tag.Contains("輪"))
    				{
    					item.SizeBase *= num2;
    				}
    				else if (item.Tag.Contains("吸盤") || this is 膣基 || this is 膣内精液 || this is 断面 || this is 性器 || this is 肛門 || this is 乳房 || this is 下着トップ || this is Waist || this is 腰肌 || this is 四足腰 || this is 下着ボトム || this is 上着ボトム || this is 手 || this is 噴乳 || this is 飛沫 || this is 潮吹_小 || this is 潮吹_大 || this is 放尿 || this is 半身 || this is 頭頂_天 || this is 背中_光 || this is ボテ腹)
    				{
    					item.SizeBase *= num;
    				}
    				else if (Xasix)
    				{
    					if (this is 頭 || this is 目隠帯 || this is 玉口枷)
    					{
    						item.OP.ExpansionX(item.OP.GetCenter(), rate);
    					}
    					else
    					{
    						item.SizeXBase *= num;
    					}
    				}
    				else if (this is 頭 || this is 目隠帯 || this is 玉口枷)
    				{
    					item.OP.ExpansionY(item.OP.GetCenter(), rate);
    				}
    				else
    				{
    					item.SizeYBase *= num;
    				}
    			}
    			本体.JoinP();
    		}
    	}

    	public virtual double 身長
    	{
    		get
    		{
    			return 身長_;
    		}
    		set
    		{
    			身長_ = value;
    			double num = 身長mi2 + 身長d2 * 身長_;
    			foreach (Par item in 本体.EnumAllPar())
    			{
    				if (!item.Parent.Tag.Contains("眼") && !item.Parent.Tag.Contains("コア") && !item.Tag.Contains("傷") && !item.Tag.Contains("ボタン") && !item.Parent.Tag.Contains("輪") && !item.Tag.Contains("吸盤") && !(this is 膣基) && !(this is 膣内精液) && !(this is 断面) && !(this is 性器) && !(this is 肛門) && !(this is 乳房) && !(this is 下着トップ) && !(this is Waist) && !(this is 腰肌) && !(this is 四足腰) && !(this is 下着ボトム) && !(this is 上着ボトム) && !(this is 手) && !(this is 噴乳) && !(this is 飛沫) && !(this is 潮吹_小) && !(this is 潮吹_大) && !(this is 放尿) && !(this is 頭) && !(this is 目隠帯) && !(this is 玉口枷) && !(this is 半身) && !(this is 頭頂) && !(this is 背中_光) && !(this is ボテ腹))
    				{
    					if (this is 頭 || this is 目隠帯 || this is 玉口枷)
    					{
    						if (num < 1.0)
    						{
    							if (Xasix)
    							{
    								item.SizeYBase *= num;
    							}
    							else
    							{
    								item.SizeXBase *= num;
    							}
    						}
    					}
    					else if (Xasix)
    					{
    						item.SizeYBase *= num;
    					}
    					else
    					{
    						item.SizeXBase *= num;
    					}
    				}
    				else if (item.Parent.Tag.Contains("コア"))
    				{
    					item.SizeBase *= num;
    					item.OP.ScalingXY(item.OP.GetCenter(), 1.0 / num);
    				}
    			}
    			本体.JoinP();
    		}
    	}

    	public virtual bool 右
    	{
    		get
    		{
    			return 右_;
    		}
    		set
    		{
    			if (右_ != value)
    			{
    				本体.JoinPAall();
    				本体.ReverseX();
    				本体.JoinP();
    			}
    			右_ = value;
    		}
    	}

    	public virtual bool 反転X
    	{
    		get
    		{
    			return 反転X_;
    		}
    		set
    		{
    			if (反転X_ != value)
    			{
    				本体.JoinPAall();
    				本体.ReverseX();
    				本体.JoinP();
    			}
    			反転X_ = value;
    		}
    	}

    	public virtual bool 反転Y
    	{
    		get
    		{
    			return 反転Y_;
    		}
    		set
    		{
    			if (反転Y_ != value)
    			{
    				本体.JoinPAall();
    				本体.ReverseY();
    				本体.JoinP();
    			}
    			反転Y_ = value;
    		}
    	}

    	public virtual double Xv
    	{
    		get
    		{
    			return 本体.ValueX;
    		}
    		set
    		{
    			本体.ValueX = value;
    		}
    	}

    	public virtual double Yv
    	{
    		get
    		{
    			return 本体.ValueY;
    		}
    		set
    		{
    			本体.ValueY = value;
    		}
    	}

    	public virtual int Xi
    	{
    		get
    		{
    			return 本体.IndexX;
    		}
    		set
    		{
    			本体.IndexX = value;
    		}
    	}

    	public virtual int Yi
    	{
    		get
    		{
    			return 本体.IndexY;
    		}
    		set
    		{
    			本体.IndexY = value;
    		}
    	}

    	public virtual double サイズ
    	{
    		get
    		{
    			return サイズ_;
    		}
    		set
    		{
    			サイズ_ = value;
    			double rate = 0.95 + 0.09 * サイズ_;
    			foreach (Par item in 本体.EnumAllPar())
    			{
    				Vector2D center = item.OP.GetCenter();
    				item.OP.ScalingXY(center, rate);
    				item.JP.ScalingXY(center, rate);
    			}
    		}
    	}

    	public virtual double サイズX
    	{
    		get
    		{
    			return サイズX_;
    		}
    		set
    		{
    			サイズX_ = value;
    			double rate = 0.95 + 0.09 * サイズX_;
    			foreach (Par item in 本体.EnumAllPar())
    			{
    				Vector2D center = item.OP.GetCenter();
    				item.OP.ScalingX(center, rate);
    				item.JP.ScalingX(center, rate);
    			}
    		}
    	}

    	public virtual double サイズY
    	{
    		get
    		{
    			return サイズY_;
    		}
    		set
    		{
    			サイズY_ = value;
    			double rate = 0.95 + 0.09 * サイズY_;
    			foreach (Par item in 本体.EnumAllPar())
    			{
    				Vector2D center = item.OP.GetCenter();
    				item.OP.ScalingY(center, rate);
    				item.JP.ScalingY(center, rate);
    			}
    		}
    	}

    	public virtual bool 欠損 { get; set; }

    	public virtual bool 筋肉 { get; set; }

    	public virtual bool 拘束 { get; set; }

    	public virtual bool 表示 { get; set; }

    	public virtual double 濃度 { get; set; }

    	public int 描画前後 => ConnectionType switch
    	{
    		ConnectionInfo.頭_基髪_接続 => 1, 
    		ConnectionInfo.頭_目左_接続 => 1, 
    		ConnectionInfo.頭_目右_接続 => 1, 
    		ConnectionInfo.頭_鼻_接続 => 1, 
    		ConnectionInfo.頭_口_接続 => 1, 
    		ConnectionInfo.頭_頬左_接続 => 1, 
    		ConnectionInfo.頭_頬右_接続 => 1, 
    		ConnectionInfo.頭_額_接続 => 1, 
    		ConnectionInfo.頭_眉左_接続 => 1, 
    		ConnectionInfo.頭_眉右_接続 => 1, 
    		ConnectionInfo.頭_耳左_接続 => 1, 
    		ConnectionInfo.頭_耳右_接続 => 1, 
    		ConnectionInfo.頭_鼻肌_接続 => 1, 
    		ConnectionInfo.頭_単眼目_接続 => 1, 
    		ConnectionInfo.頭_単眼眉_接続 => 1, 
    		ConnectionInfo.頭_頬肌左_接続 => 1, 
    		ConnectionInfo.頭_頬肌右_接続 => 1, 
    		ConnectionInfo.頭_触覚左_接続 => 1, 
    		ConnectionInfo.頭_触覚右_接続 => 1, 
    		ConnectionInfo.基髪_頭頂左_接続 => 1, 
    		ConnectionInfo.基髪_頭頂右_接続 => 1, 
    		ConnectionInfo.基髪_前髪_接続 => 1, 
    		ConnectionInfo.基髪_後髪_接続 => 0, 
    		ConnectionInfo.後髪0_肢系_左5_接続 => 1, 
    		ConnectionInfo.後髪0_肢系_左4_接続 => 1, 
    		ConnectionInfo.後髪0_肢系_左3_接続 => 1, 
    		ConnectionInfo.後髪0_肢系_左2_接続 => 1, 
    		ConnectionInfo.後髪0_肢系_左1_接続 => 1, 
    		ConnectionInfo.後髪0_肢系_中央_接続 => 1, 
    		ConnectionInfo.後髪0_肢系_右1_接続 => 1, 
    		ConnectionInfo.後髪0_肢系_右2_接続 => 1, 
    		ConnectionInfo.後髪0_肢系_右3_接続 => 1, 
    		ConnectionInfo.後髪0_肢系_右4_接続 => 1, 
    		ConnectionInfo.後髪0_肢系_右5_接続 => 1, 
    		ConnectionInfo.横髪_肢系_肢_接続 => 1, 
    		ConnectionInfo.双目_瞼_接続 => 1, 
    		ConnectionInfo.瞼_宇_涙_接続 => 1, 
    		ConnectionInfo.単目_瞼_接続 => 1, 
    		ConnectionInfo.頬目_瞼_接続 => 1, 
    		ConnectionInfo.縦目_瞼_接続 => 1, 
    		ConnectionInfo.鼻_人_鼻水左_接続 => 1, 
    		ConnectionInfo.鼻_人_鼻水右_接続 => 1, 
    		ConnectionInfo.鼻_獣_鼻水左_接続 => 1, 
    		ConnectionInfo.鼻_獣_鼻水右_接続 => 1, 
    		ConnectionInfo.首_頭_接続 => 1, 
    		ConnectionInfo.胸_首_接続 => 1, 
    		ConnectionInfo.胸_肩左_接続 => 1, 
    		ConnectionInfo.胸_肩右_接続 => 1, 
    		ConnectionInfo.胸_胸左_接続 => 1, 
    		ConnectionInfo.胸_胸右_接続 => 1, 
    		ConnectionInfo.胸_肌_接続 => 1, 
    		ConnectionInfo.胸_翼上左_接続 => 0, 
    		ConnectionInfo.胸_翼上右_接続 => 0, 
    		ConnectionInfo.胸_翼下左_接続 => 0, 
    		ConnectionInfo.胸_翼下右_接続 => 0, 
    		ConnectionInfo.胸_背中_接続 => 0, 
    		ConnectionInfo.乳房_噴乳_接続 => 1, 
    		ConnectionInfo.肩_上腕_接続 => 1, 
    		ConnectionInfo.Torso_胸_接続 => 1, 
    		ConnectionInfo.Torso_肌_接続 => 1, 
    		ConnectionInfo.Torso_翼左_接続 => 0, 
    		ConnectionInfo.Torso_翼右_接続 => 0, 
    		ConnectionInfo.Waist_Torso_接続 => 1, 
    		ConnectionInfo.Waist_腿左_接続 => 1, 
    		ConnectionInfo.Waist_腿右_接続 => 1, 
    		ConnectionInfo.Waist_膣基_接続 => 1, 
    		ConnectionInfo.Waist_肛門_接続 => 1, 
    		ConnectionInfo.Waist_尾_接続 => 0, 
    		ConnectionInfo.Waist_半身_接続 => 1, 
    		ConnectionInfo.Waist_上着_接続 => 0, 
    		ConnectionInfo.Waist_肌_接続 => 1, 
    		ConnectionInfo.Waist_翼左_接続 => 0, 
    		ConnectionInfo.Waist_翼右_接続 => 0, 
    		ConnectionInfo.ボテ腹_人_腹板_接続 => 1, 
    		ConnectionInfo.ボテ腹_獣_腹板_接続 => 1, 
    		ConnectionInfo.肛門_人_肛門精液_接続 => 1, 
    		ConnectionInfo.肛門_獣_肛門精液_接続 => 1, 
    		ConnectionInfo.性器_人_陰核_接続 => 1, 
    		ConnectionInfo.性器_人_尿道_接続 => 1, 
    		ConnectionInfo.性器_人_膣口_接続 => 1, 
    		ConnectionInfo.性器_獣_陰核_接続 => 1, 
    		ConnectionInfo.性器_獣_尿道_接続 => 1, 
    		ConnectionInfo.性器_獣_膣口_接続 => 1, 
    		ConnectionInfo.上着ボトム_クロス_上着ボトム後_接続 => 0, 
    		ConnectionInfo.顔面_甲_触覚左_接続 => 1, 
    		ConnectionInfo.顔面_甲_触覚右_接続 => 1, 
    		ConnectionInfo.顔面_虫_触覚左_接続 => 1, 
    		ConnectionInfo.顔面_虫_触覚右_接続 => 1, 
    		ConnectionInfo.顔面_蟲_触覚左_接続 => 1, 
    		ConnectionInfo.顔面_蟲_触覚右_接続 => 1, 
    		ConnectionInfo.頭頂_宇_頭部後_接続 => 0, 
    		ConnectionInfo.尾_ヘ_尾先_接続 => 0, 
    		ConnectionInfo.尾_ウ_尾先_接続 => 0, 
    		ConnectionInfo.尾_魚_左1_接続 => 1, 
    		ConnectionInfo.尾_魚_右1_接続 => 1, 
    		ConnectionInfo.尾_魚_左2_接続 => 1, 
    		ConnectionInfo.尾_魚_右2_接続 => 1, 
    		ConnectionInfo.尾_魚_左3_接続 => 1, 
    		ConnectionInfo.尾_魚_右3_接続 => 1, 
    		ConnectionInfo.尾_魚_左4_接続 => 1, 
    		ConnectionInfo.尾_魚_右4_接続 => 1, 
    		ConnectionInfo.尾_魚_左5_接続 => 1, 
    		ConnectionInfo.尾_魚_右5_接続 => 1, 
    		ConnectionInfo.尾_魚_左6_接続 => 1, 
    		ConnectionInfo.尾_魚_右6_接続 => 1, 
    		ConnectionInfo.尾_魚_左7_接続 => 1, 
    		ConnectionInfo.尾_魚_右7_接続 => 1, 
    		ConnectionInfo.尾_魚_左8_接続 => 1, 
    		ConnectionInfo.尾_魚_右8_接続 => 1, 
    		ConnectionInfo.尾_魚_左9_接続 => 1, 
    		ConnectionInfo.尾_魚_右9_接続 => 1, 
    		ConnectionInfo.尾_魚_左10_接続 => 1, 
    		ConnectionInfo.尾_魚_右10_接続 => 1, 
    		ConnectionInfo.尾_魚_左11_接続 => 1, 
    		ConnectionInfo.尾_魚_右11_接続 => 1, 
    		ConnectionInfo.尾_魚_左12_接続 => 1, 
    		ConnectionInfo.尾_魚_右12_接続 => 1, 
    		ConnectionInfo.尾_魚_左13_接続 => 1, 
    		ConnectionInfo.尾_魚_右13_接続 => 1, 
    		ConnectionInfo.尾_魚_左14_接続 => 1, 
    		ConnectionInfo.尾_魚_右14_接続 => 1, 
    		ConnectionInfo.尾_魚_左15_接続 => 1, 
    		ConnectionInfo.尾_魚_右15_接続 => 1, 
    		ConnectionInfo.尾_魚_左16_接続 => 1, 
    		ConnectionInfo.尾_魚_右16_接続 => 1, 
    		ConnectionInfo.尾_魚_左17_接続 => 1, 
    		ConnectionInfo.尾_魚_右17_接続 => 1, 
    		ConnectionInfo.尾_魚_左18_接続 => 1, 
    		ConnectionInfo.尾_魚_右18_接続 => 1, 
    		ConnectionInfo.尾_魚_左19_接続 => 1, 
    		ConnectionInfo.尾_魚_右19_接続 => 1, 
    		ConnectionInfo.尾_魚_左20_接続 => 1, 
    		ConnectionInfo.尾_魚_右20_接続 => 1, 
    		ConnectionInfo.尾_魚_左21_接続 => 1, 
    		ConnectionInfo.尾_魚_右21_接続 => 1, 
    		ConnectionInfo.尾_魚_左22_接続 => 1, 
    		ConnectionInfo.尾_魚_右22_接続 => 1, 
    		ConnectionInfo.尾_魚_左23_接続 => 1, 
    		ConnectionInfo.尾_魚_右23_接続 => 1, 
    		ConnectionInfo.尾_魚_左24_接続 => 1, 
    		ConnectionInfo.尾_魚_右24_接続 => 1, 
    		ConnectionInfo.尾_魚_左25_接続 => 1, 
    		ConnectionInfo.尾_魚_右25_接続 => 1, 
    		ConnectionInfo.尾_魚_左26_接続 => 1, 
    		ConnectionInfo.尾_魚_右26_接続 => 1, 
    		ConnectionInfo.尾_魚_左27_接続 => 1, 
    		ConnectionInfo.尾_魚_右27_接続 => 1, 
    		ConnectionInfo.尾_魚_左28_接続 => 1, 
    		ConnectionInfo.尾_魚_右28_接続 => 1, 
    		ConnectionInfo.尾_魚_左29_接続 => 1, 
    		ConnectionInfo.尾_魚_右29_接続 => 1, 
    		ConnectionInfo.尾_魚_左30_接続 => 1, 
    		ConnectionInfo.尾_魚_右30_接続 => 1, 
    		ConnectionInfo.尾_魚_左31_接続 => 1, 
    		ConnectionInfo.尾_魚_右31_接続 => 1, 
    		ConnectionInfo.尾_魚_左32_接続 => 1, 
    		ConnectionInfo.尾_魚_右32_接続 => 1, 
    		ConnectionInfo.尾_魚_左33_接続 => 1, 
    		ConnectionInfo.尾_魚_右33_接続 => 1, 
    		ConnectionInfo.尾_魚_左34_接続 => 1, 
    		ConnectionInfo.尾_魚_右34_接続 => 1, 
    		ConnectionInfo.尾_魚_尾先_接続 => 0, 
    		ConnectionInfo.尾_鯨_左1_接続 => 1, 
    		ConnectionInfo.尾_鯨_右1_接続 => 1, 
    		ConnectionInfo.尾_鯨_左2_接続 => 1, 
    		ConnectionInfo.尾_鯨_右2_接続 => 1, 
    		ConnectionInfo.尾_鯨_左3_接続 => 1, 
    		ConnectionInfo.尾_鯨_右3_接続 => 1, 
    		ConnectionInfo.尾_鯨_左4_接続 => 1, 
    		ConnectionInfo.尾_鯨_右4_接続 => 1, 
    		ConnectionInfo.尾_鯨_左5_接続 => 1, 
    		ConnectionInfo.尾_鯨_右5_接続 => 1, 
    		ConnectionInfo.尾_鯨_左6_接続 => 1, 
    		ConnectionInfo.尾_鯨_右6_接続 => 1, 
    		ConnectionInfo.尾_鯨_左7_接続 => 1, 
    		ConnectionInfo.尾_鯨_右7_接続 => 1, 
    		ConnectionInfo.尾_鯨_左8_接続 => 1, 
    		ConnectionInfo.尾_鯨_右8_接続 => 1, 
    		ConnectionInfo.尾_鯨_左9_接続 => 1, 
    		ConnectionInfo.尾_鯨_右9_接続 => 1, 
    		ConnectionInfo.尾_鯨_左10_接続 => 1, 
    		ConnectionInfo.尾_鯨_右10_接続 => 1, 
    		ConnectionInfo.尾_鯨_左11_接続 => 1, 
    		ConnectionInfo.尾_鯨_右11_接続 => 1, 
    		ConnectionInfo.尾_鯨_左12_接続 => 1, 
    		ConnectionInfo.尾_鯨_右12_接続 => 1, 
    		ConnectionInfo.尾_鯨_左13_接続 => 1, 
    		ConnectionInfo.尾_鯨_右13_接続 => 1, 
    		ConnectionInfo.尾_鯨_左14_接続 => 1, 
    		ConnectionInfo.尾_鯨_右14_接続 => 1, 
    		ConnectionInfo.尾_鯨_左15_接続 => 1, 
    		ConnectionInfo.尾_鯨_右15_接続 => 1, 
    		ConnectionInfo.尾_鯨_左16_接続 => 1, 
    		ConnectionInfo.尾_鯨_右16_接続 => 1, 
    		ConnectionInfo.尾_鯨_左17_接続 => 1, 
    		ConnectionInfo.尾_鯨_右17_接続 => 1, 
    		ConnectionInfo.尾_鯨_左18_接続 => 1, 
    		ConnectionInfo.尾_鯨_右18_接続 => 1, 
    		ConnectionInfo.尾_鯨_左19_接続 => 1, 
    		ConnectionInfo.尾_鯨_右19_接続 => 1, 
    		ConnectionInfo.尾_鯨_左20_接続 => 1, 
    		ConnectionInfo.尾_鯨_右20_接続 => 1, 
    		ConnectionInfo.尾_鯨_左21_接続 => 1, 
    		ConnectionInfo.尾_鯨_右21_接続 => 1, 
    		ConnectionInfo.尾_鯨_左22_接続 => 1, 
    		ConnectionInfo.尾_鯨_右22_接続 => 1, 
    		ConnectionInfo.尾_鯨_左23_接続 => 1, 
    		ConnectionInfo.尾_鯨_右23_接続 => 1, 
    		ConnectionInfo.尾_鯨_左24_接続 => 1, 
    		ConnectionInfo.尾_鯨_右24_接続 => 1, 
    		ConnectionInfo.尾_鯨_左25_接続 => 1, 
    		ConnectionInfo.尾_鯨_右25_接続 => 1, 
    		ConnectionInfo.尾_鯨_左26_接続 => 1, 
    		ConnectionInfo.尾_鯨_右26_接続 => 1, 
    		ConnectionInfo.尾_鯨_左27_接続 => 1, 
    		ConnectionInfo.尾_鯨_右27_接続 => 1, 
    		ConnectionInfo.尾_鯨_左28_接続 => 1, 
    		ConnectionInfo.尾_鯨_右28_接続 => 1, 
    		ConnectionInfo.尾_鯨_左29_接続 => 1, 
    		ConnectionInfo.尾_鯨_右29_接続 => 1, 
    		ConnectionInfo.尾_鯨_左30_接続 => 1, 
    		ConnectionInfo.尾_鯨_右30_接続 => 1, 
    		ConnectionInfo.尾_鯨_左31_接続 => 1, 
    		ConnectionInfo.尾_鯨_右31_接続 => 1, 
    		ConnectionInfo.尾_鯨_左32_接続 => 1, 
    		ConnectionInfo.尾_鯨_右32_接続 => 1, 
    		ConnectionInfo.尾_鯨_左33_接続 => 1, 
    		ConnectionInfo.尾_鯨_右33_接続 => 1, 
    		ConnectionInfo.尾_鯨_左34_接続 => 1, 
    		ConnectionInfo.尾_鯨_右34_接続 => 1, 
    		ConnectionInfo.尾_鯨_尾先_接続 => 0, 
    		ConnectionInfo.尾_蟲_左1_接続 => 1, 
    		ConnectionInfo.尾_蟲_右1_接続 => 1, 
    		ConnectionInfo.尾_蟲_左2_接続 => 1, 
    		ConnectionInfo.尾_蟲_右2_接続 => 1, 
    		ConnectionInfo.尾_蟲_左3_接続 => 1, 
    		ConnectionInfo.尾_蟲_右3_接続 => 1, 
    		ConnectionInfo.尾_蟲_左4_接続 => 1, 
    		ConnectionInfo.尾_蟲_右4_接続 => 1, 
    		ConnectionInfo.尾_蟲_左5_接続 => 1, 
    		ConnectionInfo.尾_蟲_右5_接続 => 1, 
    		ConnectionInfo.尾_蟲_尾左_接続 => 0, 
    		ConnectionInfo.尾_蟲_尾右_接続 => 0, 
    		ConnectionInfo.前翅_甲_軸1_接続 => 1, 
    		ConnectionInfo.前翅_甲_軸2_接続 => 1, 
    		ConnectionInfo.前翅_甲_軸3_接続 => 1, 
    		ConnectionInfo.触手_犬_頭_接続 => 1, 
    		ConnectionInfo.触手_犬_上腕左_接続 => 1, 
    		ConnectionInfo.触手_犬_上腕右_接続 => 1, 
    		ConnectionInfo.触手_犬_下腕左_接続 => 1, 
    		ConnectionInfo.触手_犬_下腕右_接続 => 1, 
    		ConnectionInfo.触手_犬_手左_接続 => 1, 
    		ConnectionInfo.触手_犬_手右_接続 => 1, 
    		ConnectionInfo.触手_蔦_節1_接続 => 1, 
    		ConnectionInfo.触手_蔦_節2_接続 => 1, 
    		ConnectionInfo.触手_蔦_節3_接続 => 1, 
    		ConnectionInfo.触手_蔦_節4_接続 => 1, 
    		ConnectionInfo.触手_蔦_節5_接続 => 1, 
    		ConnectionInfo.触手_蔦_節6_接続 => 1, 
    		ConnectionInfo.触手_蔦_節7_接続 => 1, 
    		ConnectionInfo.触手_蔦_節8_接続 => 1, 
    		ConnectionInfo.触手_蔦_節9_接続 => 1, 
    		ConnectionInfo.触手_蔦_節10_接続 => 1, 
    		ConnectionInfo.触手_蔦_節11_接続 => 1, 
    		ConnectionInfo.触手_蔦_節12_接続 => 1, 
    		ConnectionInfo.触手_蔦_節13_接続 => 1, 
    		ConnectionInfo.触手_蔦_節14_接続 => 1, 
    		ConnectionInfo.触手_蔦_節15_接続 => 1, 
    		ConnectionInfo.触手_蔦_節16_接続 => 1, 
    		ConnectionInfo.触手_蔦_節17_接続 => 1, 
    		ConnectionInfo.触手_蔦_節18_接続 => 1, 
    		ConnectionInfo.触手_蔦_節19_接続 => 1, 
    		ConnectionInfo.触手_蔦_節20_接続 => 1, 
    		ConnectionInfo.触手_蔦_節21_接続 => 1, 
    		ConnectionInfo.触手_蔦_節22_接続 => 1, 
    		ConnectionInfo.触手_蔦_節23_接続 => 1, 
    		ConnectionInfo.触手_蔦_節24_接続 => 1, 
    		ConnectionInfo.触手_蔦_先端_接続 => 1, 
    		ConnectionInfo.上腕_人_下腕_接続 => 1, 
    		ConnectionInfo.上腕_鳥_下腕_接続 => 1, 
    		ConnectionInfo.上腕_蝙_下腕_接続 => 1, 
    		ConnectionInfo.上腕_獣_下腕_接続 => 1, 
    		ConnectionInfo.上腕_蹄_下腕_接続 => 1, 
    		ConnectionInfo.下腕_人_外腕_接続 => 1, 
    		ConnectionInfo.下腕_人_手_接続 => 1, 
    		ConnectionInfo.下腕_人_虫鎌_接続 => 1, 
    		ConnectionInfo.下腕_鳥_手_接続 => 1, 
    		ConnectionInfo.下腕_蝙_手_接続 => 1, 
    		ConnectionInfo.下腕_蝙_腕輪_接続 => 1, 
    		ConnectionInfo.下腕_獣_手_接続 => 1, 
    		ConnectionInfo.下腕_蹄_手_接続 => 1, 
    		ConnectionInfo.腿_人_脚_接続 => 1, 
    		ConnectionInfo.腿_獣_脚_接続 => 1, 
    		ConnectionInfo.腿_蹄_脚_接続 => 1, 
    		ConnectionInfo.腿_鳥_脚_接続 => 1, 
    		ConnectionInfo.腿_竜_脚_接続 => 1, 
    		ConnectionInfo.脚_人_足_接続 => 1, 
    		ConnectionInfo.脚_人_脚輪下_接続 => 1, 
    		ConnectionInfo.脚_人_脚輪上_接続 => 1, 
    		ConnectionInfo.脚_獣_足_接続 => 1, 
    		ConnectionInfo.脚_蹄_足_接続 => 1, 
    		ConnectionInfo.脚_鳥_足_接続 => 1, 
    		ConnectionInfo.脚_竜_足_接続 => 1, 
    		ConnectionInfo.長物_魚_左0_接続 => 1, 
    		ConnectionInfo.長物_魚_右0_接続 => 1, 
    		ConnectionInfo.長物_魚_左1_接続 => 1, 
    		ConnectionInfo.長物_魚_右1_接続 => 1, 
    		ConnectionInfo.長物_魚_左2_接続 => 1, 
    		ConnectionInfo.長物_魚_右2_接続 => 1, 
    		ConnectionInfo.長物_魚_左3_接続 => 1, 
    		ConnectionInfo.長物_魚_右3_接続 => 1, 
    		ConnectionInfo.長物_魚_左4_接続 => 1, 
    		ConnectionInfo.長物_魚_右4_接続 => 1, 
    		ConnectionInfo.長物_魚_左5_接続 => 1, 
    		ConnectionInfo.長物_魚_右5_接続 => 1, 
    		ConnectionInfo.長物_魚_左6_接続 => 1, 
    		ConnectionInfo.長物_魚_右6_接続 => 1, 
    		ConnectionInfo.長物_魚_尾_接続 => 0, 
    		ConnectionInfo.長物_鯨_左0_接続 => 1, 
    		ConnectionInfo.長物_鯨_右0_接続 => 1, 
    		ConnectionInfo.長物_鯨_左1_接続 => 1, 
    		ConnectionInfo.長物_鯨_右1_接続 => 1, 
    		ConnectionInfo.長物_鯨_左2_接続 => 1, 
    		ConnectionInfo.長物_鯨_右2_接続 => 1, 
    		ConnectionInfo.長物_鯨_左3_接続 => 1, 
    		ConnectionInfo.長物_鯨_右3_接続 => 1, 
    		ConnectionInfo.長物_鯨_左4_接続 => 1, 
    		ConnectionInfo.長物_鯨_右4_接続 => 1, 
    		ConnectionInfo.長物_鯨_左5_接続 => 1, 
    		ConnectionInfo.長物_鯨_右5_接続 => 1, 
    		ConnectionInfo.長物_鯨_左6_接続 => 1, 
    		ConnectionInfo.長物_鯨_右6_接続 => 1, 
    		ConnectionInfo.長物_鯨_尾_接続 => 0, 
    		ConnectionInfo.長物_蛇_左_接続 => 1, 
    		ConnectionInfo.長物_蛇_右_接続 => 1, 
    		ConnectionInfo.長物_蛇_Torso_接続 => 0, 
    		ConnectionInfo.長物_蟲_左0_接続 => 1, 
    		ConnectionInfo.長物_蟲_右0_接続 => 1, 
    		ConnectionInfo.長物_蟲_左1_接続 => 1, 
    		ConnectionInfo.長物_蟲_右1_接続 => 1, 
    		ConnectionInfo.長物_蟲_Torso_接続 => 0, 
    		ConnectionInfo.四足胸_脇左_接続 => 0, 
    		ConnectionInfo.四足胸_脇右_接続 => 0, 
    		ConnectionInfo.四足胸_Torso_接続 => 0, 
    		ConnectionInfo.四足胸_胸左_接続 => 1, 
    		ConnectionInfo.四足胸_胸右_接続 => 1, 
    		ConnectionInfo.四足胸_肌_接続 => 1, 
    		ConnectionInfo.四足胸_翼上左_接続 => 0, 
    		ConnectionInfo.四足胸_翼上右_接続 => 0, 
    		ConnectionInfo.四足胸_翼下左_接続 => 0, 
    		ConnectionInfo.四足胸_翼下右_接続 => 0, 
    		ConnectionInfo.四足胸_背中_接続 => 0, 
    		ConnectionInfo.四足脇_上腕_接続 => 1, 
    		ConnectionInfo.四足胴_腰_接続 => 0, 
    		ConnectionInfo.四足胴_肌_接続 => 1, 
    		ConnectionInfo.四足胴_翼左_接続 => 0, 
    		ConnectionInfo.四足胴_翼右_接続 => 0, 
    		ConnectionInfo.四足腰_腿左_接続 => 1, 
    		ConnectionInfo.四足腰_腿右_接続 => 1, 
    		ConnectionInfo.四足腰_膣基_接続 => 1, 
    		ConnectionInfo.四足腰_肛門_接続 => 1, 
    		ConnectionInfo.四足腰_尾_接続 => 0, 
    		ConnectionInfo.四足腰_半身_接続 => 1, 
    		ConnectionInfo.四足腰_上着_接続 => 1, 
    		ConnectionInfo.四足腰_肌_接続 => 1, 
    		ConnectionInfo.四足腰_翼左_接続 => 0, 
    		ConnectionInfo.四足腰_翼右_接続 => 0, 
    		ConnectionInfo.多足_蛸_軟体外左_接続 => 1, 
    		ConnectionInfo.多足_蛸_軟体外右_接続 => 1, 
    		ConnectionInfo.多足_蛸_軟体内左_接続 => 1, 
    		ConnectionInfo.多足_蛸_軟体内右_接続 => 1, 
    		ConnectionInfo.多足_蜘_触肢左_接続 => 1, 
    		ConnectionInfo.多足_蜘_触肢右_接続 => 1, 
    		ConnectionInfo.多足_蜘_節足左1_接続 => 1, 
    		ConnectionInfo.多足_蜘_節足左2_接続 => 1, 
    		ConnectionInfo.多足_蜘_節足左3_接続 => 1, 
    		ConnectionInfo.多足_蜘_節足左4_接続 => 1, 
    		ConnectionInfo.多足_蜘_節足右1_接続 => 1, 
    		ConnectionInfo.多足_蜘_節足右2_接続 => 1, 
    		ConnectionInfo.多足_蜘_節足右3_接続 => 1, 
    		ConnectionInfo.多足_蜘_節足右4_接続 => 1, 
    		ConnectionInfo.多足_蜘_尾_接続 => 0, 
    		ConnectionInfo.多足_蠍_触肢左_接続 => 1, 
    		ConnectionInfo.多足_蠍_節足左1_接続 => 1, 
    		ConnectionInfo.多足_蠍_節足左2_接続 => 1, 
    		ConnectionInfo.多足_蠍_節足左3_接続 => 1, 
    		ConnectionInfo.多足_蠍_節足左4_接続 => 1, 
    		ConnectionInfo.多足_蠍_触肢右_接続 => 1, 
    		ConnectionInfo.多足_蠍_節足右1_接続 => 1, 
    		ConnectionInfo.多足_蠍_節足右2_接続 => 1, 
    		ConnectionInfo.多足_蠍_節足右3_接続 => 1, 
    		ConnectionInfo.多足_蠍_節足右4_接続 => 1, 
    		ConnectionInfo.多足_蠍_櫛状板左_接続 => 1, 
    		ConnectionInfo.多足_蠍_櫛状板右_接続 => 1, 
    		ConnectionInfo.多足_蠍_尾_接続 => 0, 
    		ConnectionInfo.単足_植_根外左_接続 => 0, 
    		ConnectionInfo.単足_植_根内左_接続 => 0, 
    		ConnectionInfo.単足_植_根中央_接続 => 0, 
    		ConnectionInfo.単足_植_根内右_接続 => 0, 
    		ConnectionInfo.単足_植_根外右_接続 => 0, 
    		ConnectionInfo.Torso_蛇_左_接続 => 1, 
    		ConnectionInfo.Torso_蛇_右_接続 => 1, 
    		ConnectionInfo.Torso_蛇_Torso_接続 => 0, 
    		ConnectionInfo.Torso_蟲_左_接続 => 1, 
    		ConnectionInfo.Torso_蟲_右_接続 => 1, 
    		ConnectionInfo.Torso_蟲_Torso_接続 => 0, 
    		ConnectionInfo.大顎基_顎左_接続 => 1, 
    		ConnectionInfo.大顎基_顎右_接続 => 1, 
    		ConnectionInfo.植_花_接続 => 1, 
    		_ => 0, 
    	};

    	public virtual void 接続(JointS 接続元)
    	{
    		接続根.Set(接続元);
    	}

    	public virtual void 描画0(Are Are)
    	{
    		本体.Draw(Are);
    	}

    	public virtual void 描画1(Are Are)
    	{
    	}

    	public virtual void 描画2(Are Are)
    	{
    	}

    	public virtual void Dispose()
    	{
    		本体.Dispose();
    	}

    	public virtual void 接続P()
    	{
    		接続根.JoinP();
    	}

    	public virtual void 接続PA()
    	{
    		接続根.JoinPA();
    	}

    	public virtual void 色更新()
    	{
    	}

    	public virtual void 色更新(Vector2D[] mm)
    	{
    	}

    	public virtual void SetAngle0()
    	{
    		角度B = 0.0;
    	}

    	public void SetAngle(Ele e)
    	{
    		foreach (var item in 本体.EnumAllPar().Zip(e.本体.EnumAllPar(), (Par a0, Par a1) => new { a0, a1 }))
    		{
    			item.a0.AngleBase = 0.0 - item.a1.AngleBase;
    		}
    		本体.JoinPAall();
    	}

    	public virtual void SetRestraintAngle()
    	{
    	}

    	public virtual IEnumerable<Ele> EnumEle()
    	{
    		yield return this;
    		foreach (FieldInfo item in from e in ThisType.GetFields()
    			where e.FieldType.ToString() == Sta.at
    			select e)
    		{
    			Ele[] array = (Ele[])item.GetValue(this);
    			if (array == null)
    			{
    				continue;
    			}
    			Ele[] array2 = array;
    			foreach (Ele ele in array2)
    			{
    				foreach (Ele item2 in ele.EnumEle())
    				{
    					yield return item2;
    				}
    			}
    		}
    	}

    	public IEnumerable<Ele> EnumConnectionType(ConnectionInfo 接続情報)
    	{
    		Ele[] array = (Ele[])ThisType.GetField(接続情報.ToString().Remove(0, ThisType.Name.Length + 1)).GetValue(this);
    		if (array != null)
    		{
    			Ele[] array2 = array;
    			for (int i = 0; i < array2.Length; i++)
    			{
    				yield return array2[i];
    			}
    		}
    	}

    	public ColorP GetParOfColorP(Par p)
    	{
    		return (from e in ThisType.GetFields()
    			where e.FieldType.ToString() == Sta.cpt
    			select e.GetValue(this)).Cast<ColorP>().FirstOrDefault((ColorP e) => e.Par == p);
    	}

    	public virtual bool Is布(Par p)
    	{
    		return false;
    	}

    	public virtual bool Is革(Par p)
    	{
    		return false;
    	}

    	public virtual bool Is鉄(Par p)
    	{
    		return false;
    	}
    }
}
