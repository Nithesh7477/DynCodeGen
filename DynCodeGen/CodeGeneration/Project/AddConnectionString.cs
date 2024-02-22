using DynCodeGen.CodeGeneration.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Project
{
    public class AddConnectionString
    {
        public static void SetConnectionString(string filePath, string connectionString)
        {
            if (File.Exists(filePath))
            {
                // Read the JSON file
                var json = JObject.Parse(File.ReadAllText(filePath));

                // Set the connection string
                if (json["ConnectionStrings"] == null)
                    json["ConnectionStrings"] = new JObject();

                json["ConnectionStrings"]["DefaultConnection"] = connectionString;

                // Save the updated JSON back to the file
                File.WriteAllText(filePath, json.ToString());
            }
            else
            {
                Debug.WriteLine($"Error: {filePath} does not exist.");
            }
        }

        public static void UpdateAzureAdSettings(string filePath, AzureAdSettings azureAdSettings)
        {
            string json = File.ReadAllText(filePath);
            JObject settings = JObject.Parse(json);
            settings["AzureAd"] = JObject.FromObject(azureAdSettings);
            File.WriteAllText(filePath, settings.ToString());
        }
    }
}
