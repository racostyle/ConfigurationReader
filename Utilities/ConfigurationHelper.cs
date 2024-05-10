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
            JObject jsonObject = BuildJObjectFromDictionary(dict);
            string jsonText = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            File.WriteAllText(fileLocation, jsonText);
        }

        private JObject BuildJObjectFromDictionary(Dictionary<string, string> dict)
        {
            var root = new JObject();
            foreach (var kvp in dict)
            {
                string[] parts = kvp.Key.Split(':');
                JObject current = root;
                for (int i = 0; i < parts.Length; i++)
                {
                    string part = parts[i];
                    // Check if the part is indicating an array
                    bool isArray = part.Contains("[") && part.Contains("]");

                    if (isArray)
                    {
                        string arrayName = part.Substring(0, part.IndexOf('['));
                        int arrayIndex = Convert.ToInt32(part.Substring(part.IndexOf('[') + 1, part.IndexOf(']') - part.IndexOf('[') - 1));

                        // Get or create the JArray
                        JArray arr = current[arrayName] as JArray;
                        if (arr == null)
                        {
                            arr = new JArray();
                            current[arrayName] = arr;
                        }

                        // Ensure the JArray has enough elements
                        while (arr.Count <= arrayIndex)
                        {
                            arr.Add(null);
                        }

                        if (i == parts.Length - 1) // Last part, assign the value
                        {
                            arr[arrayIndex] = kvp.Value;
                        }
                        else
                        {
                            var nextPart = parts[i + 1];
                            if (nextPart.Contains("[") && nextPart.Contains("]"))
                            {
                                // Continue with array
                            }
                            else
                            {
                                JObject obj = arr[arrayIndex] as JObject;
                                if (obj == null)
                                {
                                    obj = new JObject();
                                    arr[arrayIndex] = obj;
                                }
                                current = obj;
                            }
                        }
                    }
                    else
                    {
                        if (i == parts.Length - 1) // Last part, assign the value
                        {
                            current[part] = kvp.Value;
                        }
                        else
                        {
                            JObject nextObject = current[part] as JObject;
                            if (nextObject == null)
                            {
                                nextObject = new JObject();
                                current[part] = nextObject;
                            }
                            current = nextObject;
                        }
                    }
                }
            }

            return root;
        }
        #endregion
    }
}
