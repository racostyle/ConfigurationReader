


namespace ConfigurationReader.Utilities
{
    internal class LoadedConfigsHandler
    {
        private List<ConfigData> _loadedConfigurations;
        private int _currentConfigIndex = -1;

        internal ConfigData CurrentConfig;
        internal string CurrentKey;

        internal void Set(List<ConfigData> loadedConfigurations)
        {
            _loadedConfigurations = loadedConfigurations;
        }

        internal void Clear()
        {
            if (IsNotNullOrEmpty())
                _loadedConfigurations.Clear();
        }

        internal bool IsNotNullOrEmpty()
        {
            if (_loadedConfigurations == null || _loadedConfigurations.Count == 0)
                return false;
            return true;
        }

        internal List<ConfigData> GetAllConfigurations()
        {
            return _loadedConfigurations;
        }

        internal Dictionary<string, string> GetCurrentConfiguration()
        {
            return _loadedConfigurations[_currentConfigIndex].Configuration;
        }

        internal string GetPathToCurrentConfig()
        {
            return _loadedConfigurations[_currentConfigIndex].FullName;
        }

        internal void SetCurrentConfig(ConfigData sConfgData)
        {
            _currentConfigIndex = sConfgData.Index;
            CurrentConfig = sConfgData;
            CurrentKey = string.Empty;
        }

        internal void Change(string text)
        {
            if (CurrentConfig == null) return;
            CurrentConfig.Configuration[CurrentKey] = text;
        }

        internal string GetCurrentValueText()
        {
            return CurrentConfig.Configuration[CurrentKey];
        }
    }
}
