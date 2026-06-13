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
