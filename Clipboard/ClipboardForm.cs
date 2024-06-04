using ConfigurationReader.Assets;
using ConfigurationReader.Utilities;

namespace ConfigurationReader
{
    public partial class ClipboardForm : Form
    {
        internal bool IsActive { get; private set; }
        public ClipboardForm()
        {
            IsActive = true;
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            IsActive = false;
        }
    }
}
