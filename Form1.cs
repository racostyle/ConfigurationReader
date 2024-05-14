using ConfigurationReader.Assets;
using ConfigurationReader.Utilities;
using System.Drawing.Text;

namespace ConfigurationReader
{
    public partial class Form1 : Form
    {
        private readonly ConfigurationHelper _configurationHelper;
        private readonly NotificationObject _notificationObject;
        private List<ConfigData> _loadedConfigurations;
        private int _currentConfigIndex = 0;

        private readonly Dictionary<string, string> _settings;

        public Form1()
        {
            InitializeComponent();
            AdjustFormsComponents();
            _loadedConfigurations = new List<ConfigData>();
            _notificationObject = new NotificationObject(SetSelectedKeyText);
            _configurationHelper = new ConfigurationHelper(_notificationObject);
            _settings = _configurationHelper.LoadAppsettings();
            ClearAll();
            FillFormElements();
        }

        #region FORMS
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
        private void FillFormElements()
        {
            tbBaseFolder.Text = _settings[Stafi.APPSETTINGS_BASE_FOLDER];
            FillSavedValuesComboBox();
        }

        private void FillSavedValuesComboBox()
        {
            cbSavedValues.Items.Clear();
            var items = _settings.Where(v => v.Key.Contains(Stafi.VALUES_REGION_NAME)).Select(x => x.Value).ToArray();

            foreach (var item in items)
                cbSavedValues.Items.Add(item);
            SelectComboBoxItem(cbSavedValues);
        }

        private void SetSelectedKeyText(string value)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                tbSelectedKey.Text = value;
            });
        }

        private void ClearAll()
        {
            tbKeyValue.Text = string.Empty;
            tbSelectedKey.Text = string.Empty;
            pnlConfigKeys.Controls.Clear();
        }

        private void SelectComboBoxItem(ComboBox cb)
        {
            if (cb.Items.Count == 0)
                return;

            cb.SelectedIndex = 0;
            cb.SelectedItem = cb.SelectedIndex;
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

            ClearAll();
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
            var buttonBuilder = new DarkButtonBuilder(pnlConfigurations.Width - 10, 35, _notificationObject);

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
            if (_loadedConfigurations == null || _loadedConfigurations.Count == 0)
                return;

            var path = _loadedConfigurations[_currentConfigIndex].FullName;
            var config = _loadedConfigurations[_currentConfigIndex].Configuration;
            var result = _configurationHelper.SaveConfigurationToFile(config, path);

            if (result)
                NotifyUserIfSaveSuccessful();
        }

        private void OnBtnSaveAll_Click(object sender, EventArgs e)
        {
            if (_loadedConfigurations == null || _loadedConfigurations.Count == 0)
                return;

            List<bool> results = new List<bool>();
            foreach (var config in _loadedConfigurations)
            {
                var path = config.FullName;
                var result = _configurationHelper.SaveConfigurationToFile(config.Configuration, path);
                results.Add(result);
            }

            if (results.All(x => x == true))
                NotifyUserIfSaveSuccessful();
        }

        private void NotifyUserIfSaveSuccessful()
        {
            var oldColor = notifySavingPannel.BackColor;
            notifySavingPannel.BackColor = Color.Green;
            Task.Run(() =>
            {
                Task.Delay(300).Wait();
                notifySavingPannel.BackColor = oldColor;
            });
        }
        #endregion

        #region IMPORT & EXPORT SETTINGS
        private void OnBtnFromClipboard_Click(object sender, EventArgs e)
        {
            tbKeyValue.Text = cbSavedValues.Text;
        }

        private void OnBtnToClipboard_Click(object sender, EventArgs e)
        {
            var value = tbKeyValue.Text;
            if (_settings.ContainsValue(value))
                return;

            int index = _settings.Where(v => v.Key.Contains(Stafi.VALUES_REGION_NAME)).ToDictionary().Count;
            var key = $"{Stafi.VALUES_REGION_NAME}:{Stafi.VALUES_NAME}{index}";
            _settings.Add(key, value);
            FillSavedValuesComboBox();
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
