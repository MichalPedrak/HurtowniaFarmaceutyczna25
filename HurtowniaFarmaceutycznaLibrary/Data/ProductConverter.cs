using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using HurtowniaFarmaceutycznaLibrary.Models;

namespace HurtowniaFarmaceutycznaLibrary.Data
{
    public class ProductConverter : JsonConverter<IProduct>
    {
        public override IProduct Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            var type = doc.RootElement.GetProperty("Type").GetString();

            return type switch
            {
                "Antibiotic" => JsonSerializer.Deserialize<Antibiotic>(doc.RootElement.GetRawText(), options)!,
                _ => JsonSerializer.Deserialize<Medicine>(doc.RootElement.GetRawText(), options)!,
            };
        }

        public override void Write(Utf8JsonWriter writer, IProduct value, JsonSerializerOptions options)
        {
            var type = value.GetType().Name;
            var json = JsonSerializer.SerializeToElement(value, value.GetType(), options);
            using var obj = JsonDocument.Parse(json.GetRawText());
            writer.WriteStartObject();
            writer.WriteString("Type", type);
            foreach (var prop in obj.RootElement.EnumerateObject())
            {
                prop.WriteTo(writer);
            }
            writer.WriteEndObject();
        }
    }
}
