using ConfigurationReader.Utilities;

namespace ConfigurationReader
{
    public partial class Form1 : Form
    {
        private string[] _loadedConfigurations;

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
            _loadedConfigurations = configSearch.Search(tbBaseFolder.Text);
        }
        #endregion

        private void LoadConfigurationFromFile()
        {
            var configLoader = new LoadConfiguration();
            var config = configLoader.LoadConfigurationFromFile("D:\\Programiranje\\ConfigurationReader\\service.Secrets.json");
        }
    }
}
