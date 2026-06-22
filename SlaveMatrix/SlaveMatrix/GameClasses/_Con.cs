using _2DGAMELIB;

namespace SlaveMatrix.GameClasses
{
    public static class _Con
    {
        public static ChestD GetChestR()
        {
            ChestD obj = Uni.Chest();
            GlobalState.SetValuesD(value: Rng.XS.NextDouble(), src: obj.EnumEleD(), s: "バスト");
            return obj;
        }

        public static HeadD Get頭R()
        {
            HeadD obj = Uni.頭().SetRandom();
            BaseHairD BaseHairD2 = (BaseHairD)obj.BaseHair_接続[0];
            ElementData elementData = Get後髪0R();
            BaseHairD2.後髪接続(elementData);
            if ((elementData is BackHair0_ジグD || elementData is BackHair0_ハネD || elementData is BackHair0_パツD || elementData is BackHair0_カルD || elementData is BackHair0_肢系D) && Rng.XS.NextBool())
            {
                BaseHairD2.後髪接続(Get後髪1R());
            }
            elementData = Get横髪R(右: false);
            BaseHairD2.横髪左接続(elementData);
            BaseHairD2.横髪右接続(elementData.Get逆());
            BaseHairD2.前髪接続(Get前髪R());
            return obj;
        }

        public static HeadD Get頭R1()
        {
            HeadD obj = Uni.頭().SetRandom();
            BaseHairD BaseHairD2 = (BaseHairD)obj.BaseHair_接続[0];
            ElementData elementData = Get後髪0R();
            BaseHairD2.後髪接続(elementData);
            if ((elementData is BackHair0_ジグD || elementData is BackHair0_ハネD || elementData is BackHair0_パツD || elementData is BackHair0_カルD || elementData is BackHair0_肢系D) && Rng.XS.NextBool())
            {
                BaseHairD2.後髪接続(Get後髪1R());
            }
            elementData = Get横髪R(右: false);
            BaseHairD2.横髪左接続(elementData);
            BaseHairD2.横髪右接続(elementData.Get逆());
            BaseHairD2.前髪接続(Get前髪R1());
            return obj;
        }

        public static 双目D Get双眼R(bool 右)
        {
            switch (Rng.XS.NextM(3))
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
            単目D obj = Uni.MonoEye();
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

        public static ElementData Get鼻R()
        {
            if (Rng.XS.NextM(1) == 0)
            {
                return Uni.人鼻D();
            }
            return Uni.獣鼻D();
        }

        public static ElementData[] Get口R()
        {
            if (Rng.XS.NextM(1) == 0)
            {
                return Uni.人口D();
            }
            return Uni.裂口D();
        }

        public static ElementData Get後髪0R()
        {
            return Rng.XS.NextM(20) switch
            {
                0 => new BackHair0_ジグD().SetRandom(),
                1 => new BackHair0_ハネD().SetRandom(),
                2 => new BackHair0_パツD().SetRandom(),
                3 => new BackHair0_カルD().SetRandom(),
                4 => new BackHair0_肢系D().SetRandom(),
                5 => new 後髪0_編1ジグD().SetRandom(),
                6 => new 後髪0_編1ハネD().SetRandom(),
                7 => new BackHair0_編1パツD().SetRandom(),
                8 => new BackHair0_編1カルD().SetRandom(),
                9 => new BackHair0_下1ジグD().SetRandom(),
                10 => new BackHair0_下1ハネD().SetRandom(),
                11 => new BackHair0_下1パツD().SetRandom(),
                12 => new BackHair0_下1カルD().SetRandom(),
                13 => new 後髪0_編2ジグD().SetRandom(),
                14 => new 後髪0_編2ハネD().SetRandom(),
                15 => new 後髪0_編2パツD().SetRandom(),
                16 => new 後髪0_編2カルD().SetRandom(),
                17 => new BackHair0_下2ジグD().SetRandom(),
                18 => new 後髪0_下2ハネD().SetRandom(),
                19 => new BackHair0_下2パツD().SetRandom(),
                _ => new BackHair0_下2カルD().SetRandom(),
            };
        }

        public static ElementData Get後髪1R()
        {
            return Rng.XS.NextM(8) switch
            {
                0 => new BackHair1_結1ジグD().SetRandom(),
                1 => new BackHair1_結1ハネD().SetRandom(),
                2 => new BackHair1_結1パツD().SetRandom(),
                3 => new BackHair1_結1カルD().SetRandom(),
                4 => new BackHair1_編結D().SetRandom(),
                5 => new BackHair1_結2ジグD().SetRandom(),
                6 => new BackHair1_結2ハネD().SetRandom(),
                7 => new BackHair1_結2パツD().SetRandom(),
                _ => new BackHair1_結2カルD().SetRandom(),
            };
        }

        public static ElementData Get横髪R(bool 右)
        {
            return Rng.XS.NextM(5) switch
            {
                0 => new SideHair_ジグD
                {
                    右 = 右
                }.SetRandom(),
                1 => new SideHair_ハネD
                {
                    右 = 右
                }.SetRandom(),
                2 => new SideHair_パツD
                {
                    右 = 右
                }.SetRandom(),
                3 => new SideHair_カルD
                {
                    右 = 右
                }.SetRandom(),
                4 => new SideHair_編みD
                {
                    右 = 右
                }.SetRandom(),
                _ => new SideHair_肢系D
                {
                    右 = 右
                },
            };
        }

        public static ElementData Get前髪R()
        {
            return Rng.XS.NextM(18) switch
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

        public static ElementData Get前髪R1()
        {
            return Rng.XS.NextM(12) switch
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

        public static ElementData Get花R(bool 右)
        {
            if (Rng.XS.NextM(1) == 0)
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

        public static TorsoD SetTorso(this WaistD Waist)
        {
            TorsoD TorsoD2 = Uni.胴();
            Waist.胴接続(TorsoD2);
            return TorsoD2;
        }

        public static ChestD SetChestR(this TorsoD Torso)
        {
            ChestD ChestD2 = GetChestR();
            Torso.胴接続(ChestD2);
            return ChestD2;
        }

        public static NeckD SetNeck(this ChestD Chest)
        {
            NeckD NeckD2 = new NeckD();
            Chest.首接続(NeckD2);
            return NeckD2;
        }

        public static HeadD Set頭R(this NeckD Neck)
        {
            HeadD 頭D2 = Get頭R();
            Neck.頭接続(頭D2);
            return 頭D2;
        }

        public static HeadD Set頭R1(this NeckD Neck)
        {
            HeadD 頭D2 = Get頭R1();
            Neck.頭接続(頭D2);
            return 頭D2;
        }

        public static void Set双目R(this HeadD 頭)
        {
            双目D 双目D2 = Get双眼R(右: false);
            頭.目左接続(双目D2);
            頭.目右接続(双目D2.Get逆());
            眉D 眉D2 = Get眉R(右: false);
            頭.眉左接続(眉D2);
            頭.眉右接続(眉D2.Get逆());
        }

        public static void Set目弱R(this HeadD 頭)
        {
            双目D 双目D2 = Uni.魔弱目(右: false);
            ((瞼_弱D)双目D2.瞼_接続[0]).SetRandom();
            頭.目左接続(双目D2);
            頭.目右接続(双目D2.Get逆());
            眉D 眉D2 = Get眉R(右: false);
            頭.眉左接続(眉D2);
            頭.眉右接続(眉D2.Get逆());
        }

        public static void Set目宇R(this HeadD 頭)
        {
            双目D 双目D2 = Uni.宇宙目(右: false);
            ((瞼_宇D)双目D2.瞼_接続[0]).SetRandom();
            頭.目左接続(双目D2);
            頭.目右接続(双目D2.Get逆());
            眉D 眉D2 = Get眉R(右: false);
            頭.眉左接続(眉D2);
            頭.眉右接続(眉D2.Get逆());
        }

        public static void Set単目R(this HeadD 頭)
        {
            頭.単眼目接続(Get単眼R());
            頭.単眼眉接続(Get単眼眉R());
        }

        public static void Set鼻R(this HeadD 頭)
        {
            頭.鼻接続(Get鼻R());
        }

        public static void Set鼻人(this HeadD 頭)
        {
            頭.鼻接続(Uni.人鼻D());
        }

        public static void Set口R(this HeadD 頭)
        {
            ElementData[] array = Get口R();
            foreach (ElementData e in array)
            {
                頭.口接続(e);
            }
        }

        public static void Set口人(this HeadD 頭)
        {
            ElementData[] array = Uni.人口D();
            foreach (ElementData e in array)
            {
                頭.口接続(e);
            }
        }

        public static void Set口裂(this HeadD 頭)
        {
            ElementData[] array = Uni.裂口D();
            foreach (ElementData e in array)
            {
                頭.口接続(e);
            }
        }

        public static void Set舌短(this HeadD 頭)
        {
            頭.口接続(new Tounge_短D());
        }

        public static void Set舌長(this HeadD 頭)
        {
            頭.口接続(new Tounge_長D());
        }

        public static void Set耳人(this HeadD 頭)
        {
            耳_人D 耳_人D2 = new 耳_人D();
            頭.耳左接続(耳_人D2);
            頭.耳右接続(耳_人D2.Get逆());
        }

        public static void Set耳尖(this HeadD 頭)
        {
            耳_尖D 耳_尖D2 = new 耳_尖D();
            頭.耳左接続(耳_尖D2);
            頭.耳右接続(耳_尖D2.Get逆());
        }

        public static void Set耳長(this HeadD 頭)
        {
            耳_長D 耳_長D2 = new 耳_長D();
            頭.耳左接続(耳_長D2);
            頭.耳右接続(耳_長D2.Get逆());
        }

        public static void Set耳鰭(this HeadD 頭)
        {
            耳_鰭D 耳_鰭D2 = new 耳_鰭D();
            頭.耳左接続(耳_鰭D2);
            頭.耳右接続(耳_鰭D2.Get逆());
        }

        public static void Set耳羽(this HeadD 頭)
        {
            耳_羽D 耳_羽D2 = new 耳_羽D();
            頭.耳左接続(耳_羽D2);
            頭.耳右接続(耳_羽D2.Get逆());
        }

        public static void Set耳獣(this HeadD 頭)
        {
            耳_獣D 耳_獣D2 = new 耳_獣D();
            頭.耳左接続(耳_獣D2);
            頭.耳右接続(耳_獣D2.Get逆());
        }
    }
}
