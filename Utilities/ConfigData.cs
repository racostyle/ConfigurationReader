namespace ConfigurationReader.Utilities
{
    internal class ConfigData
    {
        internal int Index;
        internal string FullName;
        internal Dictionary<string, string> Configuration;

        public ConfigData(int index, string fullName, Dictionary<string, string> configuration)
        {
            Index = index;
            FullName = fullName;
            Configuration = configuration;
        }
    }
}
