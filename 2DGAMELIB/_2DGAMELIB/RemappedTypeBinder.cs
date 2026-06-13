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
            var sb = new StringBuilder(typeName.Length);
            int i = 0;
            while (i < typeName.Length)
            {
                int start = typeName.IndexOf('[', i);
                if (start < 0 || start + 1 >= typeName.Length || typeName[start + 1] != '[')
                {
                    sb.Append(typeName, i, typeName.Length - i);
                    break;
                }

                sb.Append(typeName, i, start - i);

                int end = typeName.IndexOf("]]", start);
                if (end < 0)
                {
                    sb.Append(typeName, start, typeName.Length - start);
                    break;
                }

                var argFull = typeName.Substring(start + 2, end - start - 2);
                var comma = argFull.IndexOf(',');
                var argTypeName = comma >= 0 ? argFull.Substring(0, comma).Trim() : argFull.Trim();

                if (_typeOnlyMap.TryGetValue(argTypeName, out var mapped))
                    argFull = mapped.FullName + (comma >= 0 ? argFull.Substring(comma) : "");

                sb.Append("[[").Append(argFull).Append("]]");

                i = end + 2;
            }

            return sb.ToString();
        }
    }
}
