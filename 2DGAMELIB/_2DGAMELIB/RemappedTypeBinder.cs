using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

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

            return null;
        }
    }
}
