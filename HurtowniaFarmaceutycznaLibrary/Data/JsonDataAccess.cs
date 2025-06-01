using HurtowniaFarmaceutycznaLibrary.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

public class ProductJsonConverter : JsonConverter<IProduct>
{
    public override IProduct Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var json = doc.RootElement.GetRawText();
        return JsonSerializer.Deserialize<Medicine>(json)!;
    }

    public override void Write(Utf8JsonWriter writer, IProduct value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, (Medicine)value, options);
    }
}
