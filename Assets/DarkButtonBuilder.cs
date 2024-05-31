using ConfigurationReader.Utilities;

namespace ConfigurationReader.Assets
{
    internal class DarkButtonBuilder
    {
        private readonly int _buttonWidth;
        private readonly int _buttonHeight;
        private EventHandler? _textChangedHandler;

        public DarkButtonBuilder(int buttonWidth, int buttonHeight)
        {
            // -21 for scrollable bar
            _buttonWidth = buttonWidth - 20;
            _buttonHeight = buttonHeight;
        }
        //pnlConfigKeys, tbKeyValue, tbSelectedConfig
        internal DarkButton Create(ConfigData sConfgData, int index, Panel configPanel, Form1 form, List<DarkButton> mainButtons, Action<int> setCurrentIndex)
        {
            DarkButton some = CreateButton(FilterButtonName(sConfgData.FullName, 3), index, configPanel, 1.3f);

            //some.Click += new EventHandler((sndr, evt) =>
            some.Click += new EventHandler((sndr, evt) =>
            {
                if (some.ForeColor == Color.Green)
                    return;
                foreach (var b in mainButtons)
                    b.ForeColor = Color.White;
                some.ForeColor = Color.Green;
                List<DarkButton> buttons = new List<DarkButton>();
                Button clickedButton = (Button)sndr;

                setCurrentIndex?.Invoke(sConfgData.Index);
                form.pnlConfigKeys.Controls.Clear();
                int i = 0;
                foreach (string key in sConfgData.Configuration.Keys)
                {
                    string localKey = key;

                    var btn = CreateButton(localKey, i, form.pnlConfigKeys, 1.3f);
                    btn.Click += new EventHandler((sndr, evt) =>
                    {
                        foreach (var b in buttons)
                            b.ForeColor = Color.White;
                        btn.ForeColor = Color.Green;

                        string localLocalKey = localKey;
                        ValuePanelTextChangeHandler(sConfgData, form, localLocalKey);
                    });
                    form.pnlConfigKeys.Controls.Add(btn);
                    buttons.Add(btn);
                    i++;
                }
            });

            return some;
        }

        private void ValuePanelTextChangeHandler(ConfigData sConfgData, Form1 form, string localLocalKey)
        {
            if (_textChangedHandler != null)
                form.tbKeyValue.TextChanged -= _textChangedHandler;
            _textChangedHandler = (s, e) => TextBoxTextChangedHandler(s, e, sConfgData, localLocalKey);
            form.tbKeyValue.Text = sConfgData.Configuration[localLocalKey];
            form.tbKeyValue.TextChanged += _textChangedHandler;
        }

        private void TextBoxTextChangedHandler(object sender, EventArgs e, ConfigData sConfgData, string localLocalKey)
        {
            sConfgData.Configuration[localLocalKey] = ((TextBox)sender).Text;
        }

        private DarkButton CreateButton(string name, int index, Panel panel, float heightMulti = 1)
        {
            float height = _buttonHeight;
            float finalHeight = height * heightMulti;

            DarkButton some = new DarkButton();
            some.Location = new Point(0, index * (_buttonHeight + 5));
            some.Width = _buttonWidth;
            some.Height = (int)finalHeight;
            some.Text = name;
            some.BackgroundImageLayout = ImageLayout.None;
            some.TextAlign = ContentAlignment.MiddleCenter;

            if (panel != null)
                some.Left = (panel.Width - some.Width) / 2;
            return some;
        }

        private string FilterButtonName(string fullName, int depth = 2)
        {
            var parts = fullName.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

            if (depth > parts.Length)
                depth = parts.Length;

            var selectedParts = parts.Skip(parts.Length - depth).ToArray();
            if (selectedParts.Length > 0)
            {
                int last = selectedParts.Length - 1;
                selectedParts[last] = selectedParts[last]
                    .Replace(".Json", string.Empty, StringComparison.CurrentCultureIgnoreCase)
                    .Replace(".Secrets", ".S", StringComparison.CurrentCultureIgnoreCase)
                    .Trim();
            }

            return string.Join("\\", selectedParts);
        }

        internal class ButtonClickHandlerBuilder
        {

        }
    }
}
