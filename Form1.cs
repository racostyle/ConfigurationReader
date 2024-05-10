using ConfigurationReader.Assets;
using ConfigurationReader.Utilities;

namespace ConfigurationReader
{
    public partial class Form1 : Form
    {
        private List<SConfigData> _loadedConfigurations;
        private int _currentConfigIndex = 0;

        public Form1()
        {
            InitializeComponent();
            AdjustFormsComponents();
            _loadedConfigurations = new List<SConfigData>();
        }

        #region Forms Asjustments
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

        #region Configuration loading and button creation
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
            var configLoader = new LoadConfiguration();
            for (int i = 0; i < configLocations.Length; i++)
            {
                var configDict = configLoader.LoadConfigurationFromFile(configLocations[i]);
                if (configDict == null)
                    continue;
                _loadedConfigurations.Add(new SConfigData
                {
                    Index = i,
                    FullName = configLocations[i],
                    Configuration = configDict
                });
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
    }
}
