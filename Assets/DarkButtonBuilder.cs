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
            // -20 for scrollable bar
            _buttonWidth = buttonWidth - 20;
            _buttonHeight = buttonHeight;
        }

        internal DarkButton Create(ConfigData sConfgData, int index, Panel pnlConfigurations, FlowLayoutPanel pnlConfigKeys, TextBox tbKeyValue, Action<int> setCurrentIndex)
        {
            DarkButton some = CreateButton(FilterButtonName(sConfgData.FullName, 3), index, pnlConfigurations, 1.25f);

            some.Click += new EventHandler((sndr, evt) =>
            {
                setCurrentIndex?.Invoke(sConfgData.Index);
                pnlConfigKeys.Controls.Clear();
                int i = 0;
                foreach (string key in sConfgData.Configuration.Keys)
                {
                    string localKey = key;

                    var btn = CreateButton(localKey, i, pnlConfigKeys, 1.25f);
                    btn.Click += new EventHandler((sndr, evt) =>
                    {
                        string localLocalKey = localKey;
                        if (_textChangedHandler != null)
                            tbKeyValue.TextChanged -= _textChangedHandler;
                        _textChangedHandler = (s, e) => TextBoxTextChangedHandler(s, e, sConfgData, localLocalKey);
                        tbKeyValue.Text = sConfgData.Configuration[localLocalKey];
                        tbKeyValue.TextChanged += _textChangedHandler;
                    });
                    pnlConfigKeys.Controls.Add(btn);
                    i++;
                }
            });

            return some;
        }

        private void TextBoxTextChangedHandler(object sender, EventArgs e, ConfigData sConfgData, string localLocalKey)
        {
            sConfgData.Configuration[localLocalKey] = ((TextBox)sender).Text;
        }

        private DarkButton CreateButton(string name, int index, Panel panel, float heightMulti = 1)
        {
            float height = _buttonHeight;
            float finalHeight = _buttonHeight * heightMulti;

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
    }
}
