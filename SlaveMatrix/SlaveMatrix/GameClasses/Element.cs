using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using _2DGAMELIB;

namespace SlaveMatrix.GameClasses
{
    public class Element : IDisposable
    {
        public Element Par;

        public ConnectionInfo ConnectionType;

        public VariantGrid Body; //本体

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
    			return Body.GetCurJoinRoot().GetBasePointBase();
    		}
    		set
    		{
    			foreach (ShapePart item in Body.EnumJoinRoot)
    			{
    				item.SetBasePointBase(value);
    			}
    			Body.JoinP();
    		}
    	}

        public virtual Vector2D 基準C
        {
            get => Body.GetCurJoinRoot().GetBasePointCont();
            set
            {
                foreach (ShapePart item in Body.EnumJoinRoot)
                {
                    item.SetBasePointCont(value);
                }
                Body.JoinP();
            }
        }

        public virtual Vector2D 位置 => Body.GetCurJoinRoot().GetPosition();

        public virtual Vector2D 位置B
        {
            get => Body.GetCurJoinRoot().GetPositionBase();
            set
            {
                foreach (ShapePart item in Body.EnumJoinRoot)
                {
                    item.SetPositionBase(value);
                }
                Body.JoinP();
            }
        }

        public virtual Vector2D 位置C
        {
            get => Body.GetCurJoinRoot().GetPositionCont();
            set
            {
                foreach (ShapePart item in Body.EnumJoinRoot)
                {
                    item.SetPositionCont(value);
                }
                Body.JoinP();
            }
        }

        public virtual double AngleAll
        {
            set
            {
                foreach (ShapePart item in Body.EnumAllPar())
                {
                    item.SetAngleBase(value);
                }
                Body.JoinPA();
            }
        }

        public virtual double 角度B
        {
            get => Body.GetCurJoinRoot().GetAngleBase();
            set
            {
                foreach (ShapePart item in Body.EnumJoinRoot)
                {
                    item.SetAngleBase(value);
                }
                Body.JoinPA();
            }
        }

        public virtual double 角度C
        {
            get => Body.GetCurJoinRoot().GetAngleCont();
            set
            {
                foreach (ShapePart item in Body.EnumJoinRoot)
                {
                    item.SetAngleCont(value);
                }
                Body.JoinPA();
            }
        }

        public virtual double 尺度B
        {
            get => Body.GetCurJoinRoot().GetSizeBase();
            set
            {
                foreach (ShapePart item in Body.EnumAllPar())
                {
                    item.SetSizeBase(item.GetSizeBase() * value);
                }
                Body.JoinP();
            }
        }

        public virtual double 尺度C
        {
            get => Body.GetCurJoinRoot().GetSizeCont();
            set
            {
                foreach (ShapePart item in Body.EnumAllPar())
                {
                    item.SetSizeCont(value);
                }
                Body.JoinP();
            }
        }

        public virtual double 尺度XB
        {
            get => Body.GetCurJoinRoot().GetSizeXBase();
            set
            {
                foreach (ShapePart item in Body.EnumAllPar())
                {
                    item.SetSizeXBase(item.GetSizeXBase() * value);
                }
                Body.JoinP();
            }
        }

        public virtual double 尺度XC
        {
            get => Body.GetCurJoinRoot().GetSizeXCont();
            set
            {
                foreach (ShapePart item in Body.EnumAllPar())
                {
                    item.SetSizeXCont(value);
                }
                Body.JoinP();
            }
        }

        public virtual double 尺度YB
        {
            get => Body.GetCurJoinRoot().GetSizeYBase();
            set
            {
                foreach (ShapePart item in Body.EnumAllPar())
                {
                    item.SetSizeYBase(item.GetSizeYBase() * value);
                }
                Body.JoinP();
            }
        }

        public virtual double 尺度YC
        {
            get => Body.GetCurJoinRoot().GetSizeYCont();
            set
            {
                foreach (ShapePart item in Body.EnumAllPar())
                {
                    item.SetSizeYCont(value);
                }
                Body.JoinP();
            }
        }

        public virtual double 肥大
        {
            get => 肥大_;
            set
            {
                肥大_ = value;
                double rate = 肥大mi1 + 肥大d1 * 肥大_;
                double num = 肥大mi2 + 肥大d2 * 肥大_;
                double num2 = num + 0.05 * 肥大_.Inverse();
                foreach (ShapePart item in Body.EnumAllPar())
                {
                    if (item.GetParent().Tag.Contains("眼") || item.GetParent().Tag.Contains("コア") || item.Tag.Contains("傷") || item.Tag.Contains("ボタン"))
                    {
                        continue;
                    }
                    if (item.GetParent().Tag.Contains("輪"))
                    {
                        item.SetSizeBase(item.GetSizeBase() * num2);
                    }
                    else if (item.Tag.Contains("吸盤") || this is VaginaOrigin || this is InternalSemen || this is XRay || this is 性器 || this is 肛門 || this is 乳房 || this is 下着トップ || this is Waist || this is 腰肌 || this is 四足腰 || this is 下着ボトム || this is JacketBottom || this is 手 || this is 噴乳 || this is 飛沫 || this is 潮吹_小 || this is 潮吹_大 || this is 放尿 || this is 半身 || this is 頭頂_天 || this is 背中_光 || this is PregnantBelly)
                    {
                        item.SetSizeBase(item.GetSizeBase() * num);
                    }
                    else if (Xasix)
                    {
                        if (this is Head or 目隠帯 or 玉口枷)
                        {
                            item.GetOP().ExpansionX(item.GetOP().GetCenter(), rate);
                        }
                        else
                        {
                            item.SetSizeXBase(item.GetSizeXBase() * num);
                        }
                    }
                    else if (this is Head or 目隠帯 or 玉口枷)
                    {
                        item.GetOP().ExpansionY(item.GetOP().GetCenter(), rate);
                    }
                    else
                    {
                        item.SetSizeYBase(item.GetSizeYBase() * num);
                    }
                }
                Body.JoinP();
            }
        }

        public virtual double 身長
        {
            get => 身長_;
            set
            {
                身長_ = value;
                double num = 身長mi2 + 身長d2 * 身長_;
                foreach (ShapePart item in Body.EnumAllPar())
                {
                    if (!item.GetParent().Tag.Contains("眼") && !item.GetParent().Tag.Contains("コア") && !item.Tag.Contains("傷") && !item.Tag.Contains("ボタン") && !item.GetParent().Tag.Contains("輪") && !item.Tag.Contains("吸盤") && this is not VaginaOrigin && this is not InternalSemen && this is not XRay && this is not 性器 && this is not 肛門 && this is not 乳房 && this is not 下着トップ && this is not Waist && this is not 腰肌 && this is not 四足腰 && this is not 下着ボトム && this is not JacketBottom && this is not 手 && this is not 噴乳 && this is not 飛沫 && this is not 潮吹_小 && this is not 潮吹_大 && this is not 放尿 && this is not Head && this is not 目隠帯 && this is not 玉口枷 && this is not 半身 && this is not 頭頂 && this is not 背中_光 && this is not PregnantBelly)
                    {
                        if (this is Head or 目隠帯 or 玉口枷)
                        {
                            if (num < 1.0)
                            {
                                if (Xasix)
                                {
                                    item.SetSizeYBase(item.GetSizeYBase() * num);
                                }
                                else
                                {
                                    item.SetSizeXBase(item.GetSizeXBase() * num);
                                }
                            }
                        }
                        else if (Xasix)
                        {
                            item.SetSizeYBase(item.GetSizeYBase() * num);
                        }
                        else
                        {
                            item.SetSizeXBase(item.GetSizeXBase() * num);
                        }
                    }
                    else if (item.GetParent().Tag.Contains("コア"))
                    {
                        item.SetSizeBase(item.GetSizeBase() * num);
                        item.GetOP().ScalingXY(item.GetOP().GetCenter(), 1.0 / num);
                    }
                }
                Body.JoinP();
            }
        }

        public virtual bool 右
        {
            get => 右_;
            set
            {
                if (右_ != value)
                {
                    Body.JoinPAall();
                    Body.ReverseX();
                    Body.JoinP();
                }
                右_ = value;
            }
        }

        public virtual bool 反転X
        {
            get => 反転X_;
            set
            {
                if (反転X_ != value)
                {
                    Body.JoinPAall();
                    Body.ReverseX();
                    Body.JoinP();
                }
                反転X_ = value;
            }
        }

        public virtual bool 反転Y
        {
            get => 反転Y_;
            set
            {
                if (反転Y_ != value)
                {
                    Body.JoinPAall();
                    Body.ReverseY();
                    Body.JoinP();
                }
                反転Y_ = value;
            }
        }

        public virtual double Xv
        {
            get => Body.ValueX; set => Body.ValueX = value;
        }

        public virtual double Yv
        {
            get => Body.ValueY; set => Body.ValueY = value;
        }

        public virtual int Xi
        {
            get => Body.GetIndexX(); set => Body.SetIndexX(value);
        }

        public virtual int Yi
        {
            get => Body.GetIndexY(); set => Body.SetIndexY(value);
        }

        public virtual double サイズ
        {
            get => サイズ_;
            set
            {
                サイズ_ = value;
                double rate = 0.95 + 0.09 * サイズ_;
                foreach (ShapePart item in Body.EnumAllPar())
                {
                    Vector2D center = item.GetOP().GetCenter();
                    item.GetOP().ScalingXY(center, rate);
                    item.GetJP().ScalingXY(center, rate);
                }
            }
        }

        public virtual double サイズX
        {
            get => サイズX_;
            set
            {
                サイズX_ = value;
                double rate = 0.95 + 0.09 * サイズX_;
                foreach (ShapePart item in Body.EnumAllPar())
                {
                    Vector2D center = item.GetOP().GetCenter();
                    item.GetOP().ScalingX(center, rate);
                    item.GetJP().ScalingX(center, rate);
                }
            }
        }

        public virtual double サイズY
        {
            get => サイズY_;
            set
            {
                サイズY_ = value;
                double rate = 0.95 + 0.09 * サイズY_;
                foreach (ShapePart item in Body.EnumAllPar())
                {
                    Vector2D center = item.GetOP().GetCenter();
                    item.GetOP().ScalingY(center, rate);
                    item.GetJP().ScalingY(center, rate);
                }
            }
        }

        public virtual bool 欠損 { get; set; }

        public virtual bool 筋肉 { get; set; }

        public virtual bool 拘束 { get; set; }

        public virtual bool 表示 { get; set; }

        public virtual double Intensity { get; set; }

        public int 描画前後 => ConnectionType switch
        {
            ConnectionInfo.Head_基髪_接続 => 1,
            ConnectionInfo.Head_目左_接続 => 1,
            ConnectionInfo.Head_目右_接続 => 1,
            ConnectionInfo.Head_鼻_接続 => 1,
            ConnectionInfo.Head_口_接続 => 1,
            ConnectionInfo.Head_頬左_接続 => 1,
            ConnectionInfo.Head_頬右_接続 => 1,
            ConnectionInfo.Head_額_接続 => 1,
            ConnectionInfo.Head_眉左_接続 => 1,
            ConnectionInfo.Head_眉右_接続 => 1,
            ConnectionInfo.Head_耳左_接続 => 1,
            ConnectionInfo.Head_耳右_接続 => 1,
            ConnectionInfo.Head_鼻肌_接続 => 1,
            ConnectionInfo.Head_単眼目_接続 => 1,
            ConnectionInfo.Head_単眼眉_接続 => 1,
            ConnectionInfo.Head_頬肌左_接続 => 1,
            ConnectionInfo.Head_頬肌右_接続 => 1,
            ConnectionInfo.Head_触覚左_接続 => 1,
            ConnectionInfo.Head_触覚右_接続 => 1,
            ConnectionInfo.基髪_頭頂左_接続 => 1,
            ConnectionInfo.基髪_頭頂右_接続 => 1,
            ConnectionInfo.基髪_前髪_接続 => 1,
            ConnectionInfo.基髪_後髪_接続 => 0,
            ConnectionInfo.BackHair0_肢系_左5_接続 => 1,
            ConnectionInfo.BackHair0_肢系_左4_接続 => 1,
            ConnectionInfo.BackHair0_肢系_左3_接続 => 1,
            ConnectionInfo.BackHair0_肢系_左2_接続 => 1,
            ConnectionInfo.BackHair0_肢系_左1_接続 => 1,
            ConnectionInfo.BackHair0_肢系_中央_接続 => 1,
            ConnectionInfo.BackHair0_肢系_右1_接続 => 1,
            ConnectionInfo.BackHair0_肢系_右2_接続 => 1,
            ConnectionInfo.BackHair0_肢系_右3_接続 => 1,
            ConnectionInfo.BackHair0_肢系_右4_接続 => 1,
            ConnectionInfo.BackHair0_肢系_右5_接続 => 1,
            ConnectionInfo.SideHair_肢系_肢_接続 => 1,
            ConnectionInfo.双目_瞼_接続 => 1,
            ConnectionInfo.瞼_宇_涙_接続 => 1,
            ConnectionInfo.単目_瞼_接続 => 1,
            ConnectionInfo.頬目_瞼_接続 => 1,
            ConnectionInfo.縦目_瞼_接続 => 1,
            ConnectionInfo.鼻_人_鼻水左_接続 => 1,
            ConnectionInfo.鼻_人_鼻水右_接続 => 1,
            ConnectionInfo.鼻_獣_鼻水左_接続 => 1,
            ConnectionInfo.鼻_獣_鼻水右_接続 => 1,
            ConnectionInfo.Neck_Head_接続 => 1,
            ConnectionInfo.Chest_Neck_接続 => 1,
            ConnectionInfo.Chest_肩左_接続 => 1,
            ConnectionInfo.Chest_肩右_接続 => 1,
            ConnectionInfo.Chest_胸左_接続 => 1,
            ConnectionInfo.Chest_胸右_接続 => 1,
            ConnectionInfo.Chest_肌_接続 => 1,
            ConnectionInfo.Chest_翼上左_接続 => 0,
            ConnectionInfo.Chest_翼上右_接続 => 0,
            ConnectionInfo.Chest_翼下左_接続 => 0,
            ConnectionInfo.Chest_翼下右_接続 => 0,
            ConnectionInfo.Chest_背中_接続 => 0,
            ConnectionInfo.乳房_噴乳_接続 => 1,
            ConnectionInfo.Shoulder_UpperArm_接続 => 1,
            ConnectionInfo.Torso_Chest_接続 => 1,
            ConnectionInfo.Torso_肌_接続 => 1,
            ConnectionInfo.Torso_翼左_接続 => 0,
            ConnectionInfo.Torso_翼右_接続 => 0,
            ConnectionInfo.Waist_Torso_接続 => 1,
            ConnectionInfo.Waist_腿左_接続 => 1,
            ConnectionInfo.Waist_腿右_接続 => 1,
            ConnectionInfo.Waist_VaginaOrigin_接続 => 1,
            ConnectionInfo.Waist_肛門_接続 => 1,
            ConnectionInfo.Waist_尾_接続 => 0,
            ConnectionInfo.Waist_半身_接続 => 1,
            ConnectionInfo.Waist_上着_接続 => 0,
            ConnectionInfo.Waist_肌_接続 => 1,
            ConnectionInfo.Waist_翼左_接続 => 0,
            ConnectionInfo.Waist_翼右_接続 => 0,
            ConnectionInfo.PregnantBelly_人_腹板_接続 => 1,
            ConnectionInfo.PregnantBelly_獣_腹板_接続 => 1,
            ConnectionInfo.肛門_人_肛門精液_接続 => 1,
            ConnectionInfo.肛門_獣_肛門精液_接続 => 1,
            ConnectionInfo.性器_人_陰核_接続 => 1,
            ConnectionInfo.性器_人_尿道_接続 => 1,
            ConnectionInfo.性器_人_膣口_接続 => 1,
            ConnectionInfo.性器_獣_陰核_接続 => 1,
            ConnectionInfo.性器_獣_尿道_接続 => 1,
            ConnectionInfo.性器_獣_膣口_接続 => 1,
            ConnectionInfo.JacketBottom_クロス_JacketBottomRear_接続 => 0,
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
            ConnectionInfo.触手_犬_Head_接続 => 1,
            ConnectionInfo.触手_犬_UpperArm左_接続 => 1,
            ConnectionInfo.触手_犬_UpperArm右_接続 => 1,
            ConnectionInfo.触手_犬_LowerArm左_接続 => 1,
            ConnectionInfo.触手_犬_LowerArm右_接続 => 1,
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
            ConnectionInfo.UpperArm_人_LowerArm_接続 => 1,
            ConnectionInfo.UpperArm_鳥_LowerArm_接続 => 1,
            ConnectionInfo.UpperArm_蝙_LowerArm_接続 => 1,
            ConnectionInfo.UpperArm_獣_LowerArm_接続 => 1,
            ConnectionInfo.UpperArm_蹄_LowerArm_接続 => 1,
            ConnectionInfo.LowerArm_人_OuterArm_接続 => 1,
            ConnectionInfo.LowerArm_人_手_接続 => 1,
            ConnectionInfo.LowerArm_人_虫鎌_接続 => 1,
            ConnectionInfo.LowerArm_鳥_手_接続 => 1,
            ConnectionInfo.LowerArm_蝙_手_接続 => 1,
            ConnectionInfo.LowerArm_蝙_腕輪_接続 => 1,
            ConnectionInfo.LowerArm_獣_手_接続 => 1,
            ConnectionInfo.LowerArm_蹄_手_接続 => 1,
            ConnectionInfo.腿_人_Leg_接続 => 1,
            ConnectionInfo.腿_獣_Leg_接続 => 1,
            ConnectionInfo.腿_蹄_Leg_接続 => 1,
            ConnectionInfo.腿_鳥_Leg_接続 => 1,
            ConnectionInfo.腿_竜_Leg_接続 => 1,
            ConnectionInfo.Leg_人_足_接続 => 1,
            ConnectionInfo.Leg_人_脚輪下_接続 => 1,
            ConnectionInfo.Leg_人_脚輪上_接続 => 1,
            ConnectionInfo.Leg_獣_足_接続 => 1,
            ConnectionInfo.Leg_蹄_足_接続 => 1,
            ConnectionInfo.Leg_鳥_足_接続 => 1,
            ConnectionInfo.Leg_竜_足_接続 => 1,
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
            ConnectionInfo.四足脇_UpperArm_接続 => 1,
            ConnectionInfo.四足胴_Waist_接続 => 0,
            ConnectionInfo.四足胴_肌_接続 => 1,
            ConnectionInfo.四足胴_翼左_接続 => 0,
            ConnectionInfo.四足胴_翼右_接続 => 0,
            ConnectionInfo.四足腰_腿左_接続 => 1,
            ConnectionInfo.四足腰_腿右_接続 => 1,
            ConnectionInfo.四足腰_VaginaOrigin_接続 => 1,
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
            ConnectionInfo.none => throw new NotImplementedException(),
            ConnectionInfo.Head_大顎基_接続 => throw new NotImplementedException(),
            ConnectionInfo.Head_顔面_接続 => throw new NotImplementedException(),
            ConnectionInfo.Head_頭頂_接続 => throw new NotImplementedException(),
            ConnectionInfo.基髪_横髪左_接続 => throw new NotImplementedException(),
            ConnectionInfo.基髪_横髪右_接続 => throw new NotImplementedException(),
            ConnectionInfo.吹出し_吹出し_接続 => throw new NotImplementedException(),
            ConnectionInfo.尾_蜘_出糸_接続 => throw new NotImplementedException(),
            ConnectionInfo.ペニス_尿道_接続 => throw new NotImplementedException(),
            _ => 0,
        };

        public virtual void 接続(JointS 接続元)
        {
            接続根.Set(接続元);
        }

        public virtual void 描画0(RenderArea Are)
        {
            Body.Draw(Are);
        }

        public virtual void 描画1(RenderArea Are)
        {
        }

        public virtual void 描画2(RenderArea Are)
        {
        }

        public virtual void Dispose()
        {
            Body.Dispose();
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

    	public void SetAngle(Element e)
    	{
    		foreach (var item in Body.EnumAllPar().Zip(e.Body.EnumAllPar(), (ShapePart a0, ShapePart a1) => new { a0, a1 }))
    		{
    			item.a0.SetAngleBase(0.0 - item.a1.GetAngleBase());
    		}
    		Body.JoinPAall();
    	}

    	public virtual void SetRestraintAngle()
    	{
    	}

        public virtual IEnumerable<Element> EnumEle()
        {
            yield return this;
            foreach (FieldInfo item in from e in ThisType.GetFields()
                                       where e.FieldType.ToString() == GlobalState.at
                                       select e)
            {
                Element[] array = (Element[])item.GetValue(this);
                if (array == null)
                {
                    continue;
                }
                Element[] array2 = array;
                foreach (Element ele in array2)
                {
                    foreach (Element item2 in ele.EnumEle())
                    {
                        yield return item2;
                    }
                }
            }
        }

        public IEnumerable<Element> EnumConnectionType(ConnectionInfo 接続情報)
        {
            Element[] array = (Element[])ThisType.GetField(接続情報.ToString()[(ThisType.Name.Length + 1)..]).GetValue(this);
            if (array != null)
            {
                Element[] array2 = array;
                for (int i = 0; i < array2.Length; i++)
                {
                    yield return array2[i];
                }
            }
        }

    	public ColorP GetParOfColorP(ShapePart p)
    	{
    		return (from e in ThisType.GetFields()
    			where e.FieldType.ToString() == GlobalState.cpt
    			select e.GetValue(this)).Cast<ColorP>().FirstOrDefault((ColorP e) => e.ShapePart == p);
    	}

    	public virtual bool Is布(ShapePart p)
    	{
    		return false;
    	}

    	public virtual bool Is革(ShapePart p)
    	{
    		return false;
    	}

    	public virtual bool Is鉄(ShapePart p)
    	{
    		return false;
    	}
    }
}
