using ConfigurationReader.Utilities;

namespace ConfigurationReader
{
    public partial class Form1 : Form
    {
        private List<ConfigData> _loadedConfigurations;

        public Form1()
        {
            InitializeComponent();
        }

        #region EVENT HANDLERS
        private void OnFindFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select a Folder";

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog1.SelectedPath;
                tbBaseFolder.Text = selectedFolderPath;
            }
        }

        private void OnLoadConfigurations_Click(object sender, EventArgs e)
        {
            var configSearch = new SearchForJsonFiles();
            var configLocations = configSearch.Search(tbBaseFolder.Text);

            _loadedConfigurations = new List<ConfigData>();
            var configLoader = new LoadConfiguration();
            foreach (var location in configLocations)
            {
                var configDict = configLoader.LoadConfigurationFromFile(location);
                if (configDict == null)
                    continue;
                _loadedConfigurations.Add(new ConfigData
                {
                    FullName = location,
                    Configuration = configDict
                });
            }
        }
        #endregion
    }
}
