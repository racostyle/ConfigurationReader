using ConfigurationReader.Assets;
using ConfigurationReader.Buttons;
using Newtonsoft.Json.Linq;

namespace ConfigurationReader.Clipboard
{
    internal class ClipboardManager
    {
        private readonly ToolTip _toolTipClipboard;
        private readonly ClipboardForm _clipboardForm;
        private readonly DarkButtonBuilder _darkButtonBuilder;
        private List<DarkButton> _darkButtons;

        public ClipboardManager(string[] values)
        {
            _toolTipClipboard = new ToolTip();
            _clipboardForm = new ClipboardForm();
            _clipboardForm.Show();
            _darkButtonBuilder = new DarkButtonBuilder(_clipboardForm.pnlValues.Width - 10, 35, _toolTipClipboard);
            _darkButtons = new List<DarkButton>();

            foreach (var value in values)
            {
               CreateNewButton(value);
            }
        }

        internal void CreateNewButton(string value)
        {
            var button = _darkButtonBuilder.CreateButton(value, 0, _clipboardForm.pnlValues, 1.3f);
            _clipboardForm.pnlValues.Controls.Add(button);
            _darkButtons.Add(button);
        }

        public void Dispose()
        {
            _darkButtons.Clear();
            _toolTipClipboard.Dispose();
        }
    }
}
