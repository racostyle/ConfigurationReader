using ConfigurationReader.Assets;
using ConfigurationReader.Buttons;
using ConfigurationReader.Clipboard;
using ConfigurationReader.Utilities;

namespace ConfigurationReader
{
    public partial class Form1 : Form
    {
        private const double MAX_FILE_SIZE_BY_BYTES = 10000;  //10Kb

        private readonly ConfigurationHelper _configurationHelper;
        private readonly NotificationObject _notificationObject;
        private readonly LoadedConfigsHandler _loadedConfigs;
        private readonly ClipboardManager _clipboardManager;
        private List<DarkButton> _mainButtons;
        private readonly Dictionary<string, string> _settings;
        private string _lastLoadLocation;
        private EventHandler _onValueTbTextChangeHandler;

        private ToolTip? _toolTipMainForm;

        public Form1()
        {
            InitializeComponent();
            AdjustFormsComponents();
            _onValueTbTextChangeHandler = OnValueTbTextChangeHandler;
            _loadedConfigs = new LoadedConfigsHandler();
            _mainButtons = new List<DarkButton>();
            _notificationObject = new NotificationObject();
            _configurationHelper = new ConfigurationHelper(_notificationObject);
            _settings = _configurationHelper.LoadAppsettings();
            _lastLoadLocation = string.Empty;
            _clipboardManager = new ClipboardManager(OnClipboardButtonClick);
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
        }

        private void ClearAll()
        {
            tbKeyValue.Text = string.Empty;
            pnlConfigKeys.Controls.Clear();
        }

        private void SelectComboBoxItem(ComboBox cb)
        {
            if (cb.Items.Count == 0)
                return;

            cb.SelectedIndex = cb.Items.Count - 1;
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
            tbKeyValue.TextChanged -= _onValueTbTextChangeHandler;
            if (_lastLoadLocation == tbBaseFolder.Text) //just to prevent unnecesarry button creation
            {
                DialogResult result = MessageBox.Show(
                    $"Load configs from the{Environment.NewLine}same location again?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        return;
                }
            }
            _lastLoadLocation = tbBaseFolder.Text;

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
            _loadedConfigs.Clear();
            List<ConfigData> configs = new List<ConfigData>();
            for (int i = 0; i < configLocations.Length; i++)
            {
                var location = configLocations[i];
                var fileSIze = new FileInfo(location).Length;
                if (fileSIze >= MAX_FILE_SIZE_BY_BYTES) //prevent to large files being loaded since it cant be loaded into gui
                    continue;

                var configDict = _configurationHelper.LoadConfigurationFromFile(location);
                if (configDict == null)
                    continue;
                configs.Add(new ConfigData(i, configLocations[i], configDict));
            }
            _loadedConfigs.Set(configs);
        }
        #endregion

        #region ADDING BUTTONS
        private void CreateButtonsForEachConfiguration(FlowLayoutPanel configPanel)
        {
            if (_toolTipMainForm != null)
                _toolTipMainForm.Dispose();
            _toolTipMainForm = new ToolTip();

            var buttonBuilder = new DarkButtonBuilder(configPanel.Width - 10, 35, _toolTipMainForm);

            configPanel.Controls.Clear();
            if (_mainButtons.Count > 0)
            {
                foreach (var b in _mainButtons)
                    b.Dispose();
                _mainButtons.Clear();
            }

            var loadedConfigs = _loadedConfigs.GetAllConfigurations();
            if (loadedConfigs == null)
                return;

            for (int i = 0; i < loadedConfigs.Count; i++)
            {
                var button = buttonBuilder.Create(loadedConfigs[i], i, configPanel, this, _mainButtons, _loadedConfigs);
                _ = new HandlerBuilder_ConfigBtn(
                    loadedConfigs[i],
                    this,
                    _mainButtons,
                    _loadedConfigs,
                    button,
                    buttonBuilder,
                    _onValueTbTextChangeHandler);

                _mainButtons.Add(button);
                configPanel.Controls.Add(button);
            }
        }
        #endregion

        #region SAVING CONFIGURATIONS
        private void OnBtnSaveCurrent_Click(object sender, EventArgs e)
        {
            if (!_loadedConfigs.IsNotNullOrEmpty())
                return;

            var path = _loadedConfigs.GetPathToCurrentConfig();
            var config = _loadedConfigs.GetCurrentConfiguration();
            var result = _configurationHelper.SaveConfigurationToFile(config, path);

            if (result)
                NotifyUserIfSaveSuccessful();
        }

        private void OnBtnSaveAll_Click(object sender, EventArgs e)
        {
            if (!_loadedConfigs.IsNotNullOrEmpty())
                return;

            List<bool> results = new List<bool>();
            foreach (var config in _loadedConfigs.GetAllConfigurations())
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

        #region CLIPBOARD
        private void OnShowClipboard_Click(object sender, EventArgs e)
        {
            if (_clipboardManager.IsFormActive())
                return;
            var items = _settings.Where(v => v.Key.Contains(Stafi.VALUES_REGION_NAME)).Select(x => x.Value).ToArray();
            _clipboardManager.Initialize(items);
        }

        private void OnAddToClipboard_Click(object sender, EventArgs e)
        {
            var value = tbKeyValue.Text;
            if (string.IsNullOrEmpty(value))
                return;
            if (_settings.ContainsValue(value))
                return;

            int index = _settings.Where(v => v.Key.Contains(Stafi.VALUES_REGION_NAME)).ToDictionary().Count;
            var key = $"{Stafi.VALUES_REGION_NAME}:{Stafi.VALUES_NAME}{index}";
            _settings.Add(key, value);
            if (_clipboardManager.ClipboardForm != null)
                _clipboardManager.AddNewButton(value);
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
            _clipboardManager.Dispose();
            _configurationHelper.SaveConfigurationToFile(_settings, "appsettings.json");
        }

        private void OnValueTbTextChangeHandler(object? sender, EventArgs e)
        {
            if (sender != null)
                _loadedConfigs.Change(((TextBox)sender).Text);
        }

        private void OnClipboardButtonClick(string text)
        {
            this.tbKeyValue.Text = text;
        }

        private void OnChangeSavedClipboardValues_Click(object sender, EventArgs e)
        {
            ClearAll();
            string[] configLocations = { Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json") };
            CreateConfigObjects(configLocations);
            CreateButtonsForEachConfiguration(pnlConfigurations);
        }
        #endregion
    }
}
