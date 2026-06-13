using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace _2DGAMELIB
{
    public sealed class RemappedTypeBinder : SerializationBinder
    {
        private readonly Dictionary<string, Type> _typeOnlyMap = new();
        private readonly Dictionary<string, (string AssemblyName, Type Type)> _fullMap = new();

        public RemappedTypeBinder Add(string oldTypeName, Type newType)
        {
            _typeOnlyMap[oldTypeName] = newType;
            return this;
        }

        public RemappedTypeBinder Add(string oldTypeName, string oldAssemblyName, Type newType)
        {
            _fullMap[oldTypeName] = (oldAssemblyName, newType);
            return this;
        }

        public override Type BindToType(string assemblyName, string typeName)
        {
            if (_fullMap.TryGetValue(typeName, out var entry))
            {
                if (assemblyName != null && assemblyName.StartsWith(entry.AssemblyName))
                    return entry.Type;
            }

            if (_typeOnlyMap.TryGetValue(typeName, out var type))
                return type;

            var fullName = typeName;
            if (!string.IsNullOrEmpty(assemblyName))
                fullName += ", " + assemblyName;

            var result = Type.GetType(fullName, throwOnError: false);
            if (result != null)
                return result;

            // Generic types like List<Pars> embed type args in the name.
            // Remap any old type names within the type arg list.
            if (typeName.Contains("[["))
            {
                var mangled = RemapTypeArgs(typeName);
                if (mangled != typeName)
                {
                    fullName = mangled;
                    if (!string.IsNullOrEmpty(assemblyName))
                        fullName += ", " + assemblyName;
                    result = Type.GetType(fullName, throwOnError: false);
                    if (result != null)
                        return result;
                }
            }

            return null;
        }

        private string RemapTypeArgs(string typeName)
        {
            // Find the generic arguments section: the outermost [...] containing [args]
            int outerStart = typeName.LastIndexOf('`');
            if (outerStart < 0) return typeName;

            int bracketStart = -1;
            for (int i = outerStart + 1; i < typeName.Length; i++)
            {
                if (typeName[i] == '[')
                {
                    bracketStart = i;
                    break;
                }
            }
            if (bracketStart < 0) return typeName;

            int depth = 0;
            int bracketEnd = -1;
            for (int i = bracketStart; i < typeName.Length; i++)
            {
                if (typeName[i] == '[') depth++;
                else if (typeName[i] == ']') depth--;
                if (depth == 0) { bracketEnd = i; break; }
            }
            if (bracketEnd < 0) return typeName;

            var inner = typeName.Substring(bracketStart, bracketEnd - bracketStart + 1);

            // Replace mapped old type names (longest first to avoid partial prefix matches)
            var sortedKeys = new List<string>(_typeOnlyMap.Keys);
            sortedKeys.Sort((a, b) => b.Length.CompareTo(a.Length));
            foreach (var old in sortedKeys)
            {
                var rep = _typeOnlyMap[old].FullName;
                inner = inner.Replace(old + ",", rep + ",");
                inner = inner.Replace(old + "]", rep + "]");
            }

            return typeName.Substring(0, bracketStart) + inner + typeName.Substring(bracketEnd + 1);
        }
    }
}
