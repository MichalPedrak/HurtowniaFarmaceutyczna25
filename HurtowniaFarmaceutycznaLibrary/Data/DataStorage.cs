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
        // private static readonly string DataFolderName = "HurtowniaFarmaceutycznaData";
        // private static readonly string AppDirectory = AppDomain.CurrentDomain.BaseDirectory;
        // private static readonly string DataFolderPath = Path.Combine(AppDirectory, DataFolderName);
        // private static readonly string FilePath = Path.Combine(DataFolderPath, "data.json");

        // Zmienione: wylicz ścieżkę siostrzaną do folderu HurtowniaFarmaceutycznaData
        private static readonly string AppDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string DataFolderPath = Path.GetFullPath(
            Path.Combine(AppDirectory, @"..\..\..\..\HurtowniaFarmaceutycznaData")
        );
        private static readonly string FilePath = Path.Combine(DataFolderPath, "data.json");
        
        
        public static void Save(List<IProduct> products)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new ProductConverter() }
            };


            // Upewnij się, że folder istnieje
            if (!Directory.Exists(DataFolderPath))
                Directory.CreateDirectory(DataFolderPath);

            // Zapisz plik JSON w podfolderze
            File.WriteAllText(FilePath, JsonSerializer.Serialize(products, options));
        }

        public static List<IProduct> Load()
        {
            if (!File.Exists(FilePath)) return new List<IProduct>();

            var options = new JsonSerializerOptions
            {
                Converters = { new ProductConverter() }
            };

            return JsonSerializer.Deserialize<List<IProduct>>(File.ReadAllText(FilePath), options) ?? new();
        }
    }
}
