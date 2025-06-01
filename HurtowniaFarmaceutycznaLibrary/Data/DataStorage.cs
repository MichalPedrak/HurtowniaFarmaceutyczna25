using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HurtowniaFarmaceutycznaLibrary.Models;

namespace HurtowniaFarmaceutycznaLibrary.Data
{
    public static class DataStorage
    {
        private static string filePath = "data.json";

        public static void Save(List<IProduct> products)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new ProductConverter() }
            };

            File.WriteAllText(filePath, JsonSerializer.Serialize(products, options));
        }

        public static List<IProduct> Load()
        {
            if (!File.Exists(filePath)) return new List<IProduct>();

            var options = new JsonSerializerOptions
            {
                Converters = { new ProductConverter() }
            };

            return JsonSerializer.Deserialize<List<IProduct>>(File.ReadAllText(filePath), options) ?? new();
        }
    }
}
