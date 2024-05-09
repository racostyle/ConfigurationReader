using Newtonsoft.Json;

namespace ConfigurationReader.Utilities
{
    internal class LoadConfiguration
    {
        internal Dictionary<string, string>? LoadConfigurationFromFile(string fileLocation)
        {
            if (File.Exists(fileLocation))
            {
                string jsonData = File.ReadAllText(fileLocation);
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonData);
            }
            return null;
        }
    }
}
