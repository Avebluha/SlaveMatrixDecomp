using _2DGAMELIB;

namespace SlaveMatrix.GameClasses
{
    public static class _Con
    {
        public static 胸D Get胸R()
        {
            胸D obj = Uni.胸();
            Sta.SetValuesD(value: RNG.XS.NextDouble(), src: obj.EnumEleD(), s: "バスト");
            return obj;
        }

        public static 頭D Get頭R()
        {
            頭D obj = Uni.頭().SetRandom();
            基髪D 基髪D2 = (基髪D)obj.基髪_接続[0];
            EleD eleD = Get後髪0R();
            基髪D2.後髪接続(eleD);
            if ((eleD is 後髪0_ジグD || eleD is 後髪0_ハネD || eleD is 後髪0_パツD || eleD is 後髪0_カルD || eleD is 後髪0_肢系D) && RNG.XS.NextBool())
            {
                基髪D2.後髪接続(Get後髪1R());
            }
            eleD = Get横髪R(右: false);
            基髪D2.横髪左接続(eleD);
            基髪D2.横髪右接続(eleD.Get逆());
            基髪D2.前髪接続(Get前髪R());
            return obj;
        }

        public static 頭D Get頭R1()
        {
            頭D obj = Uni.頭().SetRandom();
            基髪D 基髪D2 = (基髪D)obj.基髪_接続[0];
            EleD eleD = Get後髪0R();
            基髪D2.後髪接続(eleD);
            if ((eleD is 後髪0_ジグD || eleD is 後髪0_ハネD || eleD is 後髪0_パツD || eleD is 後髪0_カルD || eleD is 後髪0_肢系D) && RNG.XS.NextBool())
            {
                基髪D2.後髪接続(Get後髪1R());
            }
            eleD = Get横髪R(右: false);
            基髪D2.横髪左接続(eleD);
            基髪D2.横髪右接続(eleD.Get逆());
            基髪D2.前髪接続(Get前髪R1());
            return obj;
        }

        public static 双目D Get双眼R(bool 右)
        {
            switch (RNG.XS.NextM(3))
            {
                case 0:
                    {
                        双目D obj5 = Uni.魔弱目(右);
                        ((瞼_弱D)obj5.瞼_接続[0]).SetRandom();
                        return obj5;
                    }
                case 1:
                    {
                        双目D obj4 = Uni.魔中目(右);
                        ((瞼_中D)obj4.瞼_接続[0]).SetRandom();
                        return obj4;
                    }
                case 2:
                    {
                        双目D obj3 = Uni.魔強目(右);
                        ((瞼_強D)obj3.瞼_接続[0]).SetRandom();
                        return obj3;
                    }
                case 3:
                    {
                        双目D obj2 = Uni.獣性目(右);
                        ((瞼_獣D)obj2.瞼_接続[0]).SetRandom();
                        return obj2;
                    }
                default:
                    {
                        双目D obj = Uni.宇宙目(右);
                        ((瞼_宇D)obj.瞼_接続[0]).SetRandom();
                        return obj;
                    }
            }
        }

        public static 眉D Get眉R(bool 右)
        {
            return new 眉D
            {
                右 = 右
            }.SetRandom();
        }

        public static 単目D Get単眼R()
        {
            単目D obj = Uni.単眼目();
            ((単瞼D)obj.瞼_接続[0]).SetRandom();
            return obj;
        }

        public static 単眼眉D Get単眼眉R()
        {
            return new 単眼眉D().SetRandom();
        }

        public static 縦目D Get縦眼R()
        {
            縦目D obj = Uni.縦目();
            ((縦瞼D)obj.瞼_接続[0]).SetRandom();
            return obj;
        }

        public static 頬目D Get頬眼R(bool 右)
        {
            頬目D obj = Uni.頬目(右);
            ((頬瞼D)obj.瞼_接続[0]).SetRandom();
            return obj;
        }

        public static EleD Get鼻R()
        {
            if (RNG.XS.NextM(1) == 0)
            {
                return Uni.人鼻D();
            }
            return Uni.獣鼻D();
        }

        public static EleD[] Get口R()
        {
            if (RNG.XS.NextM(1) == 0)
            {
                return Uni.人口D();
            }
            return Uni.裂口D();
        }

        public static EleD Get後髪0R()
        {
            return RNG.XS.NextM(20) switch
            {
                0 => new 後髪0_ジグD().SetRandom(),
                1 => new 後髪0_ハネD().SetRandom(),
                2 => new 後髪0_パツD().SetRandom(),
                3 => new 後髪0_カルD().SetRandom(),
                4 => new 後髪0_肢系D().SetRandom(),
                5 => new 後髪0_編1ジグD().SetRandom(),
                6 => new 後髪0_編1ハネD().SetRandom(),
                7 => new 後髪0_編1パツD().SetRandom(),
                8 => new 後髪0_編1カルD().SetRandom(),
                9 => new 後髪0_下1ジグD().SetRandom(),
                10 => new 後髪0_下1ハネD().SetRandom(),
                11 => new 後髪0_下1パツD().SetRandom(),
                12 => new 後髪0_下1カルD().SetRandom(),
                13 => new 後髪0_編2ジグD().SetRandom(),
                14 => new 後髪0_編2ハネD().SetRandom(),
                15 => new 後髪0_編2パツD().SetRandom(),
                16 => new 後髪0_編2カルD().SetRandom(),
                17 => new 後髪0_下2ジグD().SetRandom(),
                18 => new 後髪0_下2ハネD().SetRandom(),
                19 => new 後髪0_下2パツD().SetRandom(),
                _ => new 後髪0_下2カルD().SetRandom(),
            };
        }

        public static EleD Get後髪1R()
        {
            return RNG.XS.NextM(8) switch
            {
                0 => new 後髪1_結1ジグD().SetRandom(),
                1 => new 後髪1_結1ハネD().SetRandom(),
                2 => new 後髪1_結1パツD().SetRandom(),
                3 => new 後髪1_結1カルD().SetRandom(),
                4 => new 後髪1_編結D().SetRandom(),
                5 => new 後髪1_結2ジグD().SetRandom(),
                6 => new 後髪1_結2ハネD().SetRandom(),
                7 => new 後髪1_結2パツD().SetRandom(),
                _ => new 後髪1_結2カルD().SetRandom(),
            };
        }

        public static EleD Get横髪R(bool 右)
        {
            return RNG.XS.NextM(5) switch
            {
                0 => new 横髪_ジグD
                {
                    右 = 右
                }.SetRandom(),
                1 => new 横髪_ハネD
                {
                    右 = 右
                }.SetRandom(),
                2 => new 横髪_パツD
                {
                    右 = 右
                }.SetRandom(),
                3 => new 横髪_カルD
                {
                    右 = 右
                }.SetRandom(),
                4 => new 横髪_編みD
                {
                    右 = 右
                }.SetRandom(),
                _ => new 横髪_肢系D
                {
                    右 = 右
                },
            };
        }

        public static EleD Get前髪R()
        {
            return RNG.XS.NextM(18) switch
            {
                0 => new 前髪_ジグD().SetRandom(),
                1 => new 前髪_ジグ中寄D().SetRandom(),
                2 => new 前髪_ジグ分けD().SetRandom(),
                3 => new 前髪_モジャD().SetRandom(),
                4 => new 前髪_パッツンD().SetRandom(),
                5 => new 前髪_横流しD().SetRandom(),
                6 => new 前髪_二分1D().SetRandom(),
                7 => new 前髪_三分1D().SetRandom(),
                8 => new 前髪_二分2D().SetRandom(),
                9 => new 前髪_三分2D().SetRandom(),
                10 => new 前髪_中分け1D().SetRandom(),
                11 => new 前髪_中分け2D().SetRandom(),
                12 => new 前髪_上げ短1D().SetRandom(),
                13 => new 前髪_上げ短2D().SetRandom(),
                14 => new 前髪_上げ長1D().SetRandom(),
                15 => new 前髪_上げ長2D().SetRandom(),
                16 => new 前髪_上げ片D().SetRandom(),
                17 => new 前髪_目隠れ1D().SetRandom(),
                _ => new 前髪_目隠れ2D().SetRandom(),
            };
        }

        public static EleD Get前髪R1()
        {
            return RNG.XS.NextM(12) switch
            {
                0 => new 前髪_ジグ分けD().SetRandom(),
                1 => new 前髪_横流しD().SetRandom(),
                2 => new 前髪_二分1D().SetRandom(),
                3 => new 前髪_二分2D().SetRandom(),
                4 => new 前髪_中分け1D().SetRandom(),
                5 => new 前髪_中分け2D().SetRandom(),
                6 => new 前髪_上げ短1D().SetRandom(),
                7 => new 前髪_上げ短2D().SetRandom(),
                8 => new 前髪_上げ長1D().SetRandom(),
                9 => new 前髪_上げ長2D().SetRandom(),
                10 => new 前髪_上げ片D().SetRandom(),
                _ => new 前髪_目隠れ2D().SetRandom(),
            };
        }

        public static EleD Get花R(bool 右)
        {
            if (RNG.XS.NextM(1) == 0)
            {
                return new 花_薔D
                {
                    右 = 右
                };
            }
            return new 花_百D
            {
                右 = 右
            };
        }

        public static 胴D Set胴(this WaistD 腰)
        {
            胴D 胴D2 = Uni.胴();
            腰.胴接続(胴D2);
            return 胴D2;
        }

        public static 胸D Set胸R(this 胴D 胴)
        {
            胸D 胸D2 = Get胸R();
            胴.胸接続(胸D2);
            return 胸D2;
        }

        public static 首D Set首(this 胸D 胸)
        {
            首D 首D2 = new 首D();
            胸.首接続(首D2);
            return 首D2;
        }

        public static 頭D Set頭R(this 首D 首)
        {
            頭D 頭D2 = Get頭R();
            首.頭接続(頭D2);
            return 頭D2;
        }

        public static 頭D Set頭R1(this 首D 首)
        {
            頭D 頭D2 = Get頭R1();
            首.頭接続(頭D2);
            return 頭D2;
        }

        public static void Set双目R(this 頭D 頭)
        {
            双目D 双目D2 = Get双眼R(右: false);
            頭.目左接続(双目D2);
            頭.目右接続(双目D2.Get逆());
            眉D 眉D2 = Get眉R(右: false);
            頭.眉左接続(眉D2);
            頭.眉右接続(眉D2.Get逆());
        }

        public static void Set目弱R(this 頭D 頭)
        {
            双目D 双目D2 = Uni.魔弱目(右: false);
            ((瞼_弱D)双目D2.瞼_接続[0]).SetRandom();
            頭.目左接続(双目D2);
            頭.目右接続(双目D2.Get逆());
            眉D 眉D2 = Get眉R(右: false);
            頭.眉左接続(眉D2);
            頭.眉右接続(眉D2.Get逆());
        }

        public static void Set目宇R(this 頭D 頭)
        {
            双目D 双目D2 = Uni.宇宙目(右: false);
            ((瞼_宇D)双目D2.瞼_接続[0]).SetRandom();
            頭.目左接続(双目D2);
            頭.目右接続(双目D2.Get逆());
            眉D 眉D2 = Get眉R(右: false);
            頭.眉左接続(眉D2);
            頭.眉右接続(眉D2.Get逆());
        }

        public static void Set単目R(this 頭D 頭)
        {
            頭.単眼目接続(Get単眼R());
            頭.単眼眉接続(Get単眼眉R());
        }

        public static void Set鼻R(this 頭D 頭)
        {
            頭.鼻接続(Get鼻R());
        }

        public static void Set鼻人(this 頭D 頭)
        {
            頭.鼻接続(Uni.人鼻D());
        }

        public static void Set口R(this 頭D 頭)
        {
            EleD[] array = Get口R();
            foreach (EleD e in array)
            {
                頭.口接続(e);
            }
        }

        public static void Set口人(this 頭D 頭)
        {
            EleD[] array = Uni.人口D();
            foreach (EleD e in array)
            {
                頭.口接続(e);
            }
        }

        public static void Set口裂(this 頭D 頭)
        {
            EleD[] array = Uni.裂口D();
            foreach (EleD e in array)
            {
                頭.口接続(e);
            }
        }

        public static void Set舌短(this 頭D 頭)
        {
            頭.口接続(new 舌_短D());
        }

        public static void Set舌長(this 頭D 頭)
        {
            頭.口接続(new 舌_長D());
        }

        public static void Set耳人(this 頭D 頭)
        {
            耳_人D 耳_人D2 = new 耳_人D();
            頭.耳左接続(耳_人D2);
            頭.耳右接続(耳_人D2.Get逆());
        }

        public static void Set耳尖(this 頭D 頭)
        {
            耳_尖D 耳_尖D2 = new 耳_尖D();
            頭.耳左接続(耳_尖D2);
            頭.耳右接続(耳_尖D2.Get逆());
        }

        public static void Set耳長(this 頭D 頭)
        {
            耳_長D 耳_長D2 = new 耳_長D();
            頭.耳左接続(耳_長D2);
            頭.耳右接続(耳_長D2.Get逆());
        }

        public static void Set耳鰭(this 頭D 頭)
        {
            耳_鰭D 耳_鰭D2 = new 耳_鰭D();
            頭.耳左接続(耳_鰭D2);
            頭.耳右接続(耳_鰭D2.Get逆());
        }

        public static void Set耳羽(this 頭D 頭)
        {
            耳_羽D 耳_羽D2 = new 耳_羽D();
            頭.耳左接続(耳_羽D2);
            頭.耳右接続(耳_羽D2.Get逆());
        }

        public static void Set耳獣(this 頭D 頭)
        {
            耳_獣D 耳_獣D2 = new 耳_獣D();
            頭.耳左接続(耳_獣D2);
            頭.耳右接続(耳_獣D2.Get逆());
        }
    }
}
