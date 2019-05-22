using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery
{
    public static class JsonFile
    {
        public static string jsonFile = "menu.json";
        public static void WriteTo<T>(string filePath, T objectToWrite, bool append = false)
        {
            TextWriter writer = null;
            try
            {
                var writeToJsonFile = JsonConvert.SerializeObject(objectToWrite, Formatting.Indented);
                writer = new StreamWriter(filePath, append);
                writer.Write(writeToJsonFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
        public static List<JsonMenuPrice> ReadFrom(string filePath)
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var readToJsonFile = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<JsonMenuPrice>>(readToJsonFile);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public static void WriteMenu()
        {
            JsonMenuPrice[] menuPrice = PizzeriaDB.MenuForJson();
            WriteTo(jsonFile, menuPrice);
        }
    }
}
