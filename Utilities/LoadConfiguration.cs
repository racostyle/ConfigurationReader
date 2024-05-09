using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConfigurationReader.Utilities
{
    internal class LoadConfiguration
    {
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
    }
}
