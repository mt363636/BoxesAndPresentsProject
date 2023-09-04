using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;  

namespace WarehouseFormsApp.Settings
{
    public static class SettingsManager //as we did with the boxes, we save and load upon launching the program the settings we previously saved.
                                        //The latter will be store in a JSON file
    {
        private static readonly string SettingsFilePath = "settings.json";

        public static AppSettings LoadSettings()
        {
            if (File.Exists(SettingsFilePath))
            {
                string json = File.ReadAllText(SettingsFilePath);
                return JsonConvert.DeserializeObject<AppSettings>(json);
            }

            return GetDefaultSettings();
        }

        public static void SaveSettings(AppSettings settings)
        {
            string json = JsonConvert.SerializeObject(settings, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(SettingsFilePath, json);
        }

        public static AppSettings GetDefaultSettings()
        {
            return new AppSettings
            {
                MaxQuantity = 100,
                SuitableQuantity = 10,
                AgingDuration = 5,
                MaxDistancePercentage = 20
            };
        }
    }

}
