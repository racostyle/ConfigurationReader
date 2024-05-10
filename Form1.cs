using ConfigurationReader.Assets;
using ConfigurationReader.Utilities;

namespace ConfigurationReader
{
    public partial class Form1 : Form
    {
        private List<ConfigData> _loadedConfigurations;
        private int _currentConfigIndex = 0;
        private readonly ConfigurationHelper _configurationHelper;
        private readonly Dictionary<string, string> _settings;

        public Form1()
        {
            InitializeComponent();
            AdjustFormsComponents();
            _loadedConfigurations = new List<ConfigData>();
            _configurationHelper = new ConfigurationHelper();
            _settings = _configurationHelper.LoadAppsettings();
            tbBaseFolder.Text = _settings[Stafi.APPSETTINGS_BASE_FOLDER];
        }

        #region FORMS ADJUSTMENTS
        private void AdjustFormsComponents()
        {
            this.BackColor = CustomColors.BACKGROUND_COLOR;
            var controls = new FindAllControls().GetAllControls(this);

            foreach (var control in controls)
            {
                if (control.Name.StartsWith("pnl"))
                    control.BackColor = CustomColors.PANEL_COLOR;

                if (control.Name.StartsWith("tb"))
                    control.BackColor = CustomColors.TEXT_BOX_COLOR;
            }
        }
        #endregion

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
        #endregion

        #region CONFIGURATION LOADING, BUTTON CREATION
        private void OnLoadConfigurations_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBaseFolder.Text))
                return;

            string[] configLocations = FindConfigurations();
            CreateConfigObjects(configLocations);
            CreateButtonsForEachConfiguration(pnlConfigurations);
        }

        private string[] FindConfigurations()
        {
            var configSearch = new SearchForJsonFiles();
            var configLocations = configSearch.Search(tbBaseFolder.Text);
            return configLocations;
        }

        private void CreateConfigObjects(string[] configLocations)
        {
            _loadedConfigurations.Clear();
            for (int i = 0; i < configLocations.Length; i++)
            {
                var configDict = _configurationHelper.LoadConfigurationFromFile(configLocations[i]);
                if (configDict == null)
                    continue;
                _loadedConfigurations.Add(new ConfigData(i, configLocations[i], configDict));
            }
        }
        #endregion

        #region ADDING BUTTONS

        private void CreateButtonsForEachConfiguration(FlowLayoutPanel pnlConfigurations)
        {
            var buttonBuilder = new DarkButtonBuilder(pnlConfigurations.Width - 10, 35);

            pnlConfigurations.Controls.Clear();
            List<DarkButton> buttons = new List<DarkButton>();
            for (int i = 0; i < _loadedConfigurations.Count; i++)
            {
                var btn = buttonBuilder.Create(_loadedConfigurations[i], i, pnlConfigurations, pnlConfigKeys, tbKeyValue, SetCurrentConfigIndex);
                buttons.Add(btn);
                pnlConfigurations.Controls.Add(btn);
            }
        }

        private void SetCurrentConfigIndex(int i)
        {
            _currentConfigIndex = i;
        }
        #endregion

        #region SAVING CONFIGURATIONS

        private void OnBtnSaveCurrent_Click(object sender, EventArgs e)
        {
            var path = _loadedConfigurations[_currentConfigIndex].FullName;
            var config = _loadedConfigurations[_currentConfigIndex].Configuration;
            _configurationHelper.SaveConfigurationToFile(config, path);
        }

        private void OnBtnSaveAll_Click(object sender, EventArgs e)
        {
            foreach (var config in _loadedConfigurations)
            {
                var path = config.FullName;
                _configurationHelper.SaveConfigurationToFile(config.Configuration, path);
            }
        }
        #endregion

        #region OTHER HANDLERS
        private void OnTbBaseFolder_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(tbBaseFolder.Text))
            {
                _settings[Stafi.APPSETTINGS_BASE_FOLDER] = tbBaseFolder.Text;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _configurationHelper.SaveConfigurationToFile(_settings, "appsettings.json");
        }
        #endregion
    }
}
