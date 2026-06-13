using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace _2DGAMELIB
{
    public static class Ser
    {
        private static SerializableAttribute s = new SerializableAttribute();

        private static readonly RemappedTypeBinder Binder = new RemappedTypeBinder()
            .Add("_2DGAMELIB.Par", typeof(ShapePart))
            .Add("_2DGAMELIB.ParT", typeof(ShapePartT));

        private static BinaryFormatter NewFormatter()
        {
            return new BinaryFormatter { Binder = Binder };
        }

        private static JsonSerializerSettings CreateSettings()
        {
            var settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Newtonsoft.Json.Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };
            settings.Converters.Add(new OrderedDictionaryConverter<string, Difs>());
            settings.Converters.Add(new OrderedDictionaryConverter<string, object>());
            settings.Converters.Add(new OrderedDictionaryConverter<string, But>());
            settings.Converters.Add(new OrderedDictionaryConverter<string, Lab>());
            return settings;
        }

        public static T DeepCopy<T>(this T Object)
        {
            BinaryFormatter binaryFormatter = NewFormatter();
            using MemoryStream memoryStream = new MemoryStream();
            binaryFormatter.Serialize(memoryStream, Object);
            memoryStream.Position = 0L;
            return (T)binaryFormatter.Deserialize(memoryStream);
        }

        public static byte[] ToSerialBytes<T>(this T Object)
        {
            using MemoryStream memoryStream = new MemoryStream();
            NewFormatter().Serialize(memoryStream, Object);
            return memoryStream.ToArray();
        }

        public static T ToDeserialObject<T>(this byte[] Bytes)
        {
            using MemoryStream serializationStream = new MemoryStream(Bytes);
            return (T)NewFormatter().Deserialize(serializationStream);
        }

        public static void Save<T>(this T Object, string Path)
        {
            using FileStream serializationStream = new FileStream(Path, FileMode.Create, FileAccess.Write);
            NewFormatter().Serialize(serializationStream, Object);
        }

        public static T Load<T>(this string Path)
        {
            using FileStream serializationStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
            return (T)NewFormatter().Deserialize(serializationStream);
        }

        public static T Load<T>(this byte[] bd)
        {
            using MemoryStream serializationStream = new MemoryStream(bd);
            return (T)NewFormatter().Deserialize(serializationStream);
        }

        static Ser() { }

        public static T JsonDeepCopy<T>(this T Object)
        {
            var json = JsonConvert.SerializeObject(Object, CreateSettings());
            return JsonConvert.DeserializeObject<T>(json, CreateSettings());
        }

        public static byte[] ToJsonBytes<T>(this T Object)
        {
            var json = JsonConvert.SerializeObject(Object, CreateSettings());
            return Encoding.UTF8.GetBytes(json);
        }

        public static T ToUnJsonObject<T>(this byte[] Bytes)
        {
            var json = Encoding.UTF8.GetString(Bytes);
            return JsonConvert.DeserializeObject<T>(json, CreateSettings());
        }

        public static void ToJson<T>(this T Object, string Path)
        {
            var json = JsonConvert.SerializeObject(Object, CreateSettings());
            File.WriteAllText(Path, json);
        }

        public static T UnJson<T>(string Path)
        {
            var json = File.ReadAllText(Path);
            return JsonConvert.DeserializeObject<T>(json, CreateSettings());
        }

        public static JsonSerializerSettings GetSettings() => CreateSettings();
    }
}