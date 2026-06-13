using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _2DGAMELIB
{
    public static class ObjExtensions 
    {
        static readonly Dictionary<string, string> KeyMap = new()
        {
            ["咳"] = "Cough",
            ["腰"] = "Waist",
            ["胴"] = "Torso",
            ["首"] = "Neck",
            ["頭"] = "Head",
            ["後髪0"] = "BackHair0",
            ["後髪1"] = "BackHair1",
            ["横髪"] = "SideHair",
            ["脚"] = "Leg",
            ["腕"] = "Arm",
            ["肩"] = "Shoulder",
            ["胸"] = "Chest",
            ["下腕"] = "LowerArm",
            ["上腕"] = "UpperArm",
            ["鳥翼上腕"] = "鳥翼UpperArm",
            ["獣翼上腕"] = "獣翼UpperArm",
            ["四足上腕"] = "四足UpperArm",
            ["鳥翼下腕"] = "鳥翼LowerArm",
            ["獣翼下腕"] = "獣翼LowerArm",
            ["四足下腕"] = "四足LowerArm",
            ["基髪"] = "BaseHair",
            ["胸毛"] = "ChestHair",
            ["前髪"] = "FrontHair",
            ["眉左"] = "EyebrowLeft",
            ["額目"] = "ForeheadEye",
            ["額瞼"] = "ForeheadEyelid",
            ["顔ハイライト左"] = "FaceHighlightLeft",
            ["顔面"] = "Face",
            ["魔性中瞼左"] = "DemonicMidEyelidLeft",
            ["魔性強瞼左"] = "DemonicStrongEyelidLeft",
            ["魔性弱瞼左"] = "DemonicWeakEyelidLeft",
            ["単眼目"] = "MonoEye",
            ["単眼眉"] = "MonoEyebrow",
            ["単眼瞼"] = "MonoEyelid",
            ["単足"] = "MonoLeg",
            ["獣性瞼左"] = "BestialEyelidLeft",
            ["目傷左"] = "EyeScarLeft",
            ["目尻影左"] = "EyeCornerShadowLeft",
            ["目左"] = "EyeLeft",
            ["目隠帯"] = "Blindfold",
            ["頬目左"] = "CheekEyeLeft",
            ["頬瞼左"] = "CheekEyelidLeft",
            ["頬肌左"] = "CheekSkinLeft",
            ["口"] = "Mouth",
            ["舌"] = "Tongue",
            ["涎左"] = "DroolLeft",
            ["涎口裂け左"] = "DroolMouthGashLeft",
            ["呼気"] = "Breath",
            ["吹出し"] = "SpeechBubble",
            ["鼻"] = "Nose",
            ["鼻水左"] = "NoseDripLeft",
            ["鼻肌"] = "NoseSkin",
            ["耳"] = "Ear",
            ["獣耳"] = "BeastEar",
            ["角"] = "Horn",
            ["胸郭"] = "Chest",
            ["胸郭肌"] = "ChestSkin",
            ["胸郭腹板"] = "ChestPlate",
            ["胸左"] = "LeftBreast",
            ["胴肌"] = "TorsoSkin",
            ["胴腹板"] = "TorsoPlate",
            ["腰肌"] = "WaistSkin",
            ["ボテ腹"] = "PregnantBelly",
            ["ボテ腹板"] = "PregnantBellyPlate",
            ["固定帯"] = "FixingBelt",
            ["紅潮"] = "Blush",
            ["肛門"] = "Anus",
            ["肛門精液垂れ"] = "AnusSemenDrip",
            ["膣基"] = "VaginaBase",
            ["膣内精液"] = "InternalSemen",
            ["性器"] = "Genitals",
            ["性器精液垂れ"] = "GenitalsSemenDrip",
            ["射精"] = "Ejaculation",
            ["放尿"] = "Urination",
            ["噴乳左"] = "LactationLeft",
            ["潮吹"] = "Squirting",
            ["尾"] = "Tail",
            ["背中"] = "Back",
            ["手"] = "Hand",
            ["足"] = "Foot",
            ["腿"] = "Thigh",
        };

        public static void MigrateKeys(this Obj obj)
        {
            var newDict = new OrderedDictionary<string, Difs>();

            foreach (var key in obj.Keys)
            {
                var newKey = KeyMap.TryGetValue(key, out var mapped) ? mapped : key;
                var difs = obj.Difss[key];

                newDict.Add(newKey, difs);
            }

            obj.Difss = newDict;
        }

    }
}
