using ConfigurationReader.Assets;
using ConfigurationReader.Buttons;

namespace ConfigurationReader.Clipboard
{
    internal class ClipboardManager
    {
        private readonly Action<string> _tbValueTextAction;
        internal ClipboardForm ClipboardForm { get; private set; }
        private ToolTip _toolTipClipboard;
        private List<DarkButton> _darkButtons;

        public ClipboardManager(Action<string> tbValueTextAction)
        {
            
            _tbValueTextAction = tbValueTextAction;
            _darkButtons = new List<DarkButton>();
        }

        internal void Initialize(string[] values)
        {
            ClipboardForm = new ClipboardForm();
            if (_toolTipClipboard != null)
                _toolTipClipboard.Dispose();
            if (AreAnyValues(values))
            {
                _toolTipClipboard = new ToolTip();
                _darkButtons.Clear();
                var builder = CreateButtonBuilder();
                foreach (var value in values)
                    CreateNewButton(value, builder);
            }
            ClipboardForm.Show();
        }

        private bool AreAnyValues(string[] values)
        {
            if (values == null)
                return false;
            if (values.Count() == 0)
                return false;
            return true;
        }

        internal void AddNewButton(string value)
        {
            var builder = CreateButtonBuilder();
            CreateNewButton(value, builder);
        }

        private void CreateNewButton(string value, DarkButtonBuilder builder)
        {
            var button = builder.CreateButton(value, 0, ClipboardForm.pnlValues, 1.3f);
            ClipboardForm.pnlValues.Controls.Add(button);
            _ = new HandlerBuilder_Clipboard(button, OnClickAction);
            _darkButtons.Add(button);
        }

        private DarkButtonBuilder CreateButtonBuilder()
        {
            return new DarkButtonBuilder(ClipboardForm.pnlValues.Width - 10, 35, _toolTipClipboard);
        }

        private void OnClickAction(string text)
        {
            _tbValueTextAction?.Invoke(text);
        }

        public void Dispose()
        {
            _darkButtons?.Clear();
            _toolTipClipboard?.Dispose();
        }

        internal bool IsFormActive()
        {
            return ClipboardForm == null ? false : ClipboardForm.IsActive;
        }
    }
}
