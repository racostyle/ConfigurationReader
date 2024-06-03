using ConfigurationReader.Assets;
using ConfigurationReader.Utilities;
using System.Runtime;

namespace ConfigurationReader
{
    public partial class ClipboardForm : Form
    {
        public ClipboardForm()
        {
            InitializeComponent();
            AdjustFormsComponents();
        }

        private void AdjustFormsComponents()
        {
            this.BackColor = CustomColors.BACKGROUND_COLOR;
            var controls = new FindAllControls().GetAllControls(this);

            foreach (var control in controls)
            {
                if (control.Name.StartsWith("pnl"))
                    control.BackColor = CustomColors.PANEL_COLOR;
            }
        }
    }
}
