using System.Windows.Forms;

namespace ConfigurationReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var configLoader = new LoadConfiguration();
            var config = configLoader.LoadConfigurationFromFile("D:\\Programiranje\\ConfigurationReader\\service.Secrets.json");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OnFindFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select a Folder";

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog1.SelectedPath;
                tbBaseFolder.Text = selectedFolderPath;  
            }
        }
    }
}
