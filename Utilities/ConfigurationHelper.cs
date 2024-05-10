using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConfigurationReader.Utilities
{
    internal class ConfigurationHelper
    {
        #region APPSETTINGS
        internal Dictionary<string, string> LoadAppsettings()
        {
            string filename = "appsettings.json";
            if (File.Exists(filename))
            {
                var settings = LoadConfigurationFromFile(filename);
                if (settings != null)
                    return settings;
            }
            return CreateAppsettings(filename);
        }

        private Dictionary<string, string> CreateAppsettings(string filename)
        {
            Dictionary<string, string> json = new Dictionary<string, string>
            {
                {Stafi.APPSETTINGS_BASE_FOLDER ,""}
            };
            SaveConfigurationToFile(json, filename);
            return json;
        }
        #endregion

        #region LOADING
        internal Dictionary<string, string>? LoadConfigurationFromFile(string fileLocation)
        {
            if (File.Exists(fileLocation))
            {
                string jsonData = File.ReadAllText(fileLocation);
                try
                {
                    var dict = new Dictionary<string, string>();
                    var obj = JObject.Parse(jsonData);

                    FillDictionaryFromJObject(obj, dict, string.Empty);
                    return dict;
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex);
                }   
                
            }
            return null;
        }

        private void FillDictionaryFromJObject(JObject jObject, Dictionary<string, string> dict, string prefix)
        {
            foreach (var property in jObject.Properties())
            {
                string key = !string.IsNullOrEmpty(prefix) ? $"{prefix}:{property.Name}" : property.Name;

                if (property.Value is JObject subObject)
                {
                    FillDictionaryFromJObject(subObject, dict, key);
                }
                else if (property.Value is JArray array)
                {
                    HandleArray(array, dict, key);
                }
                else
                {
                    dict[key] = property.Value.ToString();
                }
            }
        }

        private void HandleArray(JArray array, Dictionary<string, string> dict, string key)
        {
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] is JObject obj)
                {
                    FillDictionaryFromJObject(obj, dict, $"{key}[{i}]");
                }
                else
                {
                    dict[$"{key}[{i}]"] = array[i].ToString();
                }
            }
        }
        #endregion

        #region SAVING
        internal void SaveConfigurationToFile(Dictionary<string, string> dict, string fileLocation)
        {
            JObject jsonObject = CreateJObjectFromNestedDictionary(dict);
            string jsonText = JsonConvert.SerializeObject(jsonObject, Formatting.None);
            File.WriteAllText(fileLocation, jsonText);
        }

        public static JObject CreateJObjectFromNestedDictionary(Dictionary<string, string> nestedDictionary)
        {
            var jObject = new JObject();

            foreach (var kvp in nestedDictionary)
            {
                var keys = kvp.Key.Split(':'); // Split keys by ':'
                var currentJObject = jObject;

                for (int i = 0; i < keys.Length; i++)
                {
                    var key = keys[i];

                    if (!currentJObject.ContainsKey(key))
                    {
                        if (i == keys.Length - 1)
                        {
                            // Last key, add the value
                            currentJObject.Add(key, kvp.Value);
                        }
                        else
                        {
                            // Create a new nested JObject
                            var nested = new JObject();
                            currentJObject.Add(key, nested);
                            currentJObject = nested;
                        }
                    }
                    else
                    {
                        // Key already exists, move to the next level
                        currentJObject = (JObject)currentJObject[key];
                    }
                }
            }
            return jObject;
        }
        #endregion
    }
}
