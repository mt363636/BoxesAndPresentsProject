using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStruct1.DataStructures;
using Newtonsoft.Json;

namespace DataStruct1.DatabaseLoad
{
    public class LoadAndSaveData  // saving and loading the total number of boxes from JSON file by serialization and deserialization, using a linear representation and correct date format
    {
        static string pathToFile = "items.json";

        static JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.All,
            DateFormatString = "yyyy-MM-ddTHH:mm:ss.fffK"
        };

        public static void SaveDataInFile(List<Box> data)
        {
            string content = JsonConvert.SerializeObject(data, Formatting.Indented, settings);
            File.WriteAllText(pathToFile, content);
        }

        public static List<Box> LoadDataFromFile()
        {
            if (File.Exists(pathToFile))
            {
                string dataFromFile = File.ReadAllText(pathToFile);
                List<Box> items = JsonConvert.DeserializeObject<List<Box>>(dataFromFile, settings);
                return items;
            }

            return new List<Box>();
        }
    }

}
