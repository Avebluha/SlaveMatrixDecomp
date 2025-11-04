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
            //["腕"] = "Arm"
            ["肩"] = "Shoulder",
            ["胸"] = "Chest",
            //["乳房"] = "Breast",
            //["腹"] = "Abdomen",
            //["顔"] = "Face",
            //["目"] = "Eye",
            //["眉"] = "Eyebrow",
            //["瞼"] = "Eyelid",
            //["鼻"] = "Nose",
            //["口"] = "Mouth",
            //["耳"] = "Ear",
            //["触覚"] = "Antenna",
            //["髪"] = "Hair",
            //["基髪"] = "BaseHair",
            //["吹出し"] = "SpeechBubble",
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
