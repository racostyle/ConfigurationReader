using ConfigurationReader.Assets;
using ConfigurationReader.Utilities;

namespace ConfigurationReader.Buttons
{
    internal class HandlerBuilder_ConfigBtn : ButtonHandler
    {
        private readonly DarkButtonBuilder _darkButtonBuilder;
        private readonly List<DarkButton> _buttons;
        private readonly Form1 _form;
        private readonly DarkButton _button;
        private EventHandler? _textChangedHandler;
        //bull

        public HandlerBuilder_ConfigBtn(ConfigData sConfgData, Form1 form, List<DarkButton> mainButtons, Action<int> setCurrentIndex, DarkButton button, DarkButtonBuilder darkButtonBuilder)
        : base(button)
        {
            _buttons = new List<DarkButton>();
            _darkButtonBuilder = darkButtonBuilder;
            _form = form;
            _button = button;
            _onClickHandler = (s, e) => OnClickHandler(s, e, sConfgData, mainButtons, setCurrentIndex);
            base.SubscribeHandlers();
        }

        private void OnClickHandler(object sender, EventArgs e, ConfigData sConfgData, List<DarkButton> mainButtons, Action<int> setCurrentIndex)
        {
            if (_button.ForeColor == Color.Green)
                return;
            foreach (var b in mainButtons)
                b.ForeColor = Color.White;
            _button.ForeColor = Color.Green;

            Button clickedButton = (Button)sender;

            setCurrentIndex?.Invoke(sConfgData.Index);
            _form.pnlConfigKeys.Controls.Clear();
            int i = 0;
            foreach (string key in sConfgData.Configuration.Keys)
            {
                string localKey = key;
                int localIndex = i;
                var btn = _darkButtonBuilder.CreateButton(localKey, localIndex, _form.pnlConfigKeys, 1.3f);
                _ = new HandlerBuilder_ValueBtn(_textChangedHandler, btn, _buttons, _form, sConfgData, ValuePanelTextChangeHandler);
                i++;
            }
            base.AddDisposeAction(OnDisposeAction);
        }

        private void ValuePanelTextChangeHandler(ConfigData sConfgData, Form1 form, string _localKey)
        {
            if (_textChangedHandler != null)
                form.tbKeyValue.TextChanged -= _textChangedHandler;
            _textChangedHandler = (s, e) => TextBoxTextChangedHandler(s, e, sConfgData, _localKey);
            form.tbKeyValue.Text = sConfgData.Configuration[_localKey];
            form.tbKeyValue.TextChanged += _textChangedHandler;
        }

        private void TextBoxTextChangedHandler(object sender, EventArgs e, ConfigData sConfgData, string localKey)
        {
            sConfgData.Configuration[localKey] = ((TextBox)sender).Text;
        }

        private void OnDisposeAction()
        {
            if (_textChangedHandler != null)
                _form.tbKeyValue.TextChanged -= _textChangedHandler;
            foreach (var button in _buttons)
                button.Dispose();
        }
    }
}
