using ConfigurationReader.Utilities;

namespace ConfigurationReader.Assets
{
    internal class HandlerBuilder
    {
        private DarkButton _some;
        private readonly DarkButtonBuilder _darkButtonBuilder;

        private EventHandler? _textChangedHandler;
        private EventHandler? _onClickHandler;
        private EventHandler? _onDisposeHandler;

        public HandlerBuilder(ConfigData sConfgData, Form1 form, List<DarkButton> mainButtons, Action<int> setCurrentIndex, DarkButton some, DarkButtonBuilder darkButtonBuilder)
        {
            _darkButtonBuilder = darkButtonBuilder;
            _some = some;
            _onClickHandler = (s, e) => OnConfigButtonClickHandler(s, e, sConfgData, form, mainButtons, setCurrentIndex);
            _some.Click += _onClickHandler;
            _onDisposeHandler = (s, e) => OnDispose(s, e);
            _some.Disposed += _onDisposeHandler;
        }

        private void OnConfigButtonClickHandler(object sender, EventArgs e, ConfigData sConfgData, Form1 form, List<DarkButton> mainButtons, Action<int> setCurrentIndex)
        {
            if (_some.ForeColor == Color.Green)
                return;
            foreach (var b in mainButtons)
                b.ForeColor = Color.White;
            _some.ForeColor = Color.Green;
            List<DarkButton> buttons = new List<DarkButton>();
            Button clickedButton = (Button)sender;

            setCurrentIndex?.Invoke(sConfgData.Index);
            form.pnlConfigKeys.Controls.Clear();
            int i = 0;
            foreach (string key in sConfgData.Configuration.Keys)
            {
                string localKey = key;

                var btn = _darkButtonBuilder.CreateButton(localKey, i, form.pnlConfigKeys, 1.3f);
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
        }

        private void OnDispose(object sender, EventArgs e)
        {
            _some.Click -= _onClickHandler;
            _some.Disposed -= _onDisposeHandler;
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
    }
}
