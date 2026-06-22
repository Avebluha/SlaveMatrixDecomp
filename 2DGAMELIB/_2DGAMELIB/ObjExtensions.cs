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
            ["胸郭"] = "RibCage",
            ["舌"] = "Tounge",
            ["膣基"] = "VaginaOrigin",
            ["上着ボトム後"] = "JacketBottomRear",
            ["上着ボトム"] = "JacketBottom",
            ["上着ボトム前"] = "JacketBottomFront",
            ["断面"] = "XRay",
            ["膣内精液"] = "InternalSemen",
            ["ボテ腹"] = "PregnantBelly",
            ["腰肌"] = "WaistSkin",
            ["ボテ腹板"] = "PregnantBellyPlate",
            ["胴腹板"] = "TorsoPlate",
            ["胴肌"] = "TorsoSkin",
            ["肛門"] = "Anus",
            ["固定帯"] = "FixingBelt",
            ["基髪"] = "BaseHair",
            ["単眼目"] = "MonoEye",
            ["単眼瞼"] = "MonoEyelid",
            ["目左"] = "EyeLeft",
            ["魔性弱瞼左"] = "DemonicWeakEyelidLeft",
            ["魔性中瞼左"] = "DemonicMidEyelidLeft",
            ["魔性強瞼左"] = "DemonicStrongEyelidLeft",
            ["獣性瞼左"] = "BestialEyelidLeft",
            ["エイリアン目左"] = "AlienEyeLeft",
            ["鼻肌"] = "NoseSkin",
            ["目傷左"] = "EyeScarLeft",
            ["頬肌左"] = "CheekSkinLeft",
            ["額目"] = "ForeheadEye",
            ["額瞼"] = "ForeheadEyelid",
            ["頬目左"] = "CheekEyeLeft"
        };

        public static void MigrateKeys(this BodyTemplate BodyTemplate)
        {
            var newDict = new OrderedDictionary<string, VariantGrid>();

            foreach (var key in BodyTemplate.Keys)
            {
                var newKey = KeyMap.TryGetValue(key, out var mapped) ? mapped : key;
                var difs = BodyTemplate.Difss[key];

                newDict.Add(newKey, difs);
            }

            BodyTemplate.Difss = newDict;
        }

    }
}
