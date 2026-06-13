using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _2DGAMELIB
{
    public class OrderedDictionaryConverter<T1, T2> : JsonConverter<OrderedDictionary<T1, T2>>
        where T1 : notnull
    {
        public override OrderedDictionary<T1, T2> ReadJson(JsonReader reader, Type objectType, OrderedDictionary<T1, T2> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var dict = new OrderedDictionary<T1, T2>();

            if (reader.TokenType == JsonToken.Null)
                return dict;

            var array = JArray.Load(reader);

            foreach (var item in array)
            {
                var key = item["Key"].ToObject<T1>(serializer);
                var value = item["Value"].ToObject<T2>(serializer);
                dict.Add(key, value);
            }

            return dict;
        }

        public override void WriteJson(JsonWriter writer, OrderedDictionary<T1, T2> value, JsonSerializer serializer)
        {
            writer.WriteStartArray();

            foreach (var key in value.Keys)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("Key");
                serializer.Serialize(writer, key);
                writer.WritePropertyName("Value");
                serializer.Serialize(writer, value[key]);
                writer.WriteEndObject();
            }

            writer.WriteEndArray();
        }
    }
}