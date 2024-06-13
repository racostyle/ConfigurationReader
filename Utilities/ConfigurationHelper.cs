using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using Librac.ConfigurationsLib;

namespace ConfigurationReader.Utilities
{
    internal class ConfigurationHelper
    {
        private NotificationObject _notificationObject;
        private StringBuilder _sb;

        public ConfigurationHelper(NotificationObject notificationObject)
        {
            _notificationObject = notificationObject;
            _sb = new StringBuilder();
        }

        private string BuildErrorMessage(string message, string errorMessage)
        {
            _sb.Clear();
            _sb.AppendLine("Error occured while loading configurations");
            _sb.AppendLine(Environment.NewLine);
            _sb.AppendLine(errorMessage);
            return _sb.ToString();
        }
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
                try
                {
                    return Configurations.LoadConfiguration(fileLocation);
                }
                catch (Exception ex)
                {
                    var message = BuildErrorMessage("Error occured while loading configurations", ex.Message);
                    _notificationObject.ShowResultBox(false, message);
                }

            }
            return null;
        }
        #endregion

        #region SAVING
        internal bool SaveConfigurationToFile(Dictionary<string, string> dict, string fileLocation)
        {
            try
            {
                Configurations.SaveConfiguration(dict, fileLocation);
                return true;
            }
            catch (Exception ex)
            {
                var message = BuildErrorMessage("Error occured while saving configurations", ex.Message);
                _notificationObject.ShowResultBox(false, message);
                return false;
            }
        }
        #endregion
    }
}
