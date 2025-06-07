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
    public class ProductConverter : JsonConverter<Medicine>
    {
        public override Medicine Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            var root = doc.RootElement;

            // Try to get type as string first
            if (root.TryGetProperty("Type", out var typeProp))
            {
                MedicineType typeEnum;

                if (typeProp.ValueKind == JsonValueKind.Number && typeProp.TryGetInt32(out var intVal))
                {
                    // Map number to enum
                    typeEnum = (MedicineType)intVal;
                }
                else if (typeProp.ValueKind == JsonValueKind.String)
                {
                    // Parse string to enum
                    if (!Enum.TryParse<MedicineType>(typeProp.GetString(), out typeEnum))
                        throw new NotSupportedException($"Unknown medicine type string: {typeProp.GetString()}");
                }
                else
                {
                    throw new NotSupportedException("Unsupported Type property format");
                }

                // Deserialize based on enum
                return typeEnum switch
                {
                    MedicineType.Antybiotyk => JsonSerializer.Deserialize<Antibiotic>(root.GetRawText(), options)!,
                    MedicineType.Przeciwbolowa => JsonSerializer.Deserialize<PainKiller>(root.GetRawText(), options)!,
                    _ => throw new NotSupportedException($"Unsupported MedicineType value: {typeEnum}")
                };
            }

            throw new JsonException("Missing Type property");
            
        }

        public override void Write(Utf8JsonWriter writer, Medicine value, JsonSerializerOptions options)
        {
            var newOptions = new JsonSerializerOptions(options);
            var converterToRemove = newOptions.Converters.FirstOrDefault(c => c is ProductConverter);
            if (converterToRemove != null)
                newOptions.Converters.Remove(converterToRemove);

            JsonSerializer.Serialize(writer, value, value.GetType(), newOptions);
        }
    }


}
