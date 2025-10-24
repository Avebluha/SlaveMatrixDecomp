using System;
using System.Collections.Generic;
using System.Text;

namespace _2DGAMELIB
{
    public static class ObjExtensions 
    {
        static readonly Dictionary<string, string> KeyMap = new()
        {
            ["咳"] = "Cough",
            ["腰"] = "Waist",
            ["胴"] = "Torso"
        };

        public static void MigrateKeys(this Obj obj)
        {
            var newDict = new OrderedDictionary<string, Difs>();

            foreach (var key in obj.Keys)
            {
                var newKey = KeyMap.TryGetValue(key, out var mapped) ? mapped : key;
                var newDifs = obj.Difss[key];
                var newTag = KeyMap.TryGetValue(obj.Difss[key].Tag, out var mappedTag) ? mappedTag : obj.Difss[key].Tag;

                newDifs.Tag = newTag;

                for (var i = 0; i < newDifs.CountX; i++)
                {
                    var newDifTag = KeyMap.TryGetValue(newDifs[i].Tag, out var mappedDifTag) ? mappedDifTag : newDifs[i].Tag;
                    newDifs[i].Tag = newDifTag;
                }

                newDict.Add(newKey, newDifs);

            }

            var temp = newDict["Torso"];

            obj.Difss = newDict;
        }
    }
}
